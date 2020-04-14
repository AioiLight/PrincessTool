using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AioiLight.PrincessTool.Works
{
    public class ConvertSound : IWorkable
    {
        public ConvertSound(string folder, string desc)
        {
            var targetFolder = Path.Combine(Program.Dest, folder);

            if (!Directory.Exists(targetFolder))
            {
                return;
            }

            // .awb, .acbファイルのみ該当させる。
            var files = Directory.GetFiles(targetFolder, "*.*", SearchOption.AllDirectories)
                .Where(f => f.EndsWith(".awb", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".acb", StringComparison.OrdinalIgnoreCase))
                .ToArray();
            var filesAmount = files.Count();
            Folder = folder;
            new Progress(desc, filesAmount, Process);

        }

        public void Process(IProgress<int> progress)
        {
            // .awb, .acbファイルのみ該当させる。
            var targetFolder = Path.Combine(Program.Dest, Folder);
            var files = Directory.GetFiles(targetFolder, "*.*", SearchOption.AllDirectories)
                .Where(f => f.EndsWith(".awb", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".acb", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            // コピー先フォルダの決定。
            var copyFolder = Path.Combine(Program.Dest, $@"convert-{Folder}");

            var cnt = 0;
            foreach (var item in files)
            {
                var itemFolder = Path.GetDirectoryName(item);
                var itemRelative = item.Substring(targetFolder.Length + 1);

                var itemConvertedPath = Path.Combine(copyFolder, itemRelative);
                var itemConvertedFolder = Path.GetDirectoryName(itemConvertedPath);
                if (!Directory.Exists(itemConvertedFolder))
                {
                    // ディレクトリがなかったら作る。
                    Directory.CreateDirectory(itemConvertedFolder);
                }

                var tracks = GetTracks(item);
                if (tracks != null)
                {
                    foreach (var track in tracks)
                    {
                        Convert(item, Path.Combine(itemConvertedFolder,
                            $"{track.Name}.wav"),
                            track.TrackNum);
                    }
                }

                cnt++;
                progress.Report(cnt);
            }
        }

        /// <summary>
        /// トラック情報の配列を生成する。
        /// </summary>
        /// <param name="filePath">ファイルパス。</param>
        /// <returns>場合によってはnullが返ることもある。</returns>
        private TrackInfo[] GetTracks(string filePath)
        {
            var info = GetInfo(filePath);

            var lines = info.Split(new char[] { '\r', '\n' });
            if (lines.Where(s => s.StartsWith("failed opening")).Any())
            {
                // ウェーブデータの無い.acbや、
                // その他変なファイルが投げられた。
                return null;
            }


            var findTrack = "stream count: ";
            var tracks = lines.Where(s => s.StartsWith(findTrack));
            if (tracks.Any())
            {
                // 複数のトラックがある。
                if (int.TryParse(tracks.First().Substring(findTrack.Length), out var number))
                {
                    var trackInfo = new TrackInfo[number];
                    for (int i = 0; i < number; i++)
                    {
                        var track = new TrackInfo();

                        // もういちどトラック番号から情報を取得してみる。
                        track.Name = GetTrackName(GetInfo(filePath, i + 1));
                        track.TrackNum = i + 1;

                        trackInfo[i] = track;
                    }
                    return trackInfo;
                }
                else
                {
                    // トラック数が取得できなかった。
                    return null;
                }
            }
            else
            {
                // 1つのトラックしか無い
                var trackInfo = new TrackInfo[1];
                var track = new TrackInfo();
                
                track.Name = GetTrackName(GetInfo(filePath));

                if (string.IsNullOrWhiteSpace(track.Name))
                {
                    // エラーが出力で受け取れないのでここで処理する。
                    return null;
                }

                track.TrackNum = 1;

                trackInfo[0] = track;

                return trackInfo;
            }
        }

        /// <summary>
        /// ファイル情報からトラック名を取得する。
        /// </summary>
        /// <param name="info">ファイル情報。</param>
        /// <returns>トラック名。nullが返ることもある。</returns>
        private string GetTrackName(string info)
        {
            if (info == null)
            {
                // 情報がnull
                return null;
            }

            var lines = info.Split(new char[] { '\r', '\n' });
            if (lines.Where(s => s.StartsWith("failed opening")).Any())
            {
                // ウェーブデータの無い.acbや、
                // その他変なファイルが投げられた。
                return null;
            }

            // ストリーム名を取得。
            var findName = "stream name: ";
            var name = lines.Where(s => s.StartsWith(findName));
            if (!name.Any())
            {
                // 名前が取得できなかった
                return null;
            }
            var streamName = name.First().Substring(findName.Length);

            return streamName;
        }

        /// <summary>
        /// ファイルパスよりtest.exeを動かす。
        /// </summary>
        /// <param name="filePath">ファイルパス。</param>
        /// <param name="track">トラック数。</param>
        /// <returns>ファイル情報。</returns>
        private string GetInfo(string filePath, int? track = null)
        {
            var vgmstreamPath = GetVgmstream();

            var cmd = new Process();
            // cmd.exeの場所
            cmd.StartInfo.FileName = vgmstreamPath;
            // 引数
            if (track.HasValue)
            {
                cmd.StartInfo.Arguments = $"-m -s {track.Value} {filePath}";
            }
            else
            {
                cmd.StartInfo.Arguments = $"-m {filePath}";
            }
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.Start();

            var result = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            cmd.Close();


            return result;
        }

        /// <summary>
        /// .acb、.awbから.wavに変換する。
        /// </summary>
        /// <param name="input">入力パス。</param>
        /// <param name="output">出力パス。</param>
        /// <param name="track">トラック数。</param>
        private void Convert(string input, string output, int? track = null)
        {
            var vgmstreamPath = GetVgmstream();

            var cmd = new Process();
            // cmd.exeの場所
            cmd.StartInfo.FileName = vgmstreamPath;
            // 引数
            if (track.HasValue)
            {
                cmd.StartInfo.Arguments = $"-s {track.Value} -o {output} {input}";
            }
            else
            {
                cmd.StartInfo.Arguments = $"-o {output} {input}";
            }
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;

            cmd.Start();

            cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            cmd.Close();
        }

        private string GetVgmstream()
        {
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(appDir, @"tools\vgmstream\test.exe");
            return path;
        }

        private string Folder { get; set; }

        private class TrackInfo
        {
            public string Name { get; set; }
            public int TrackNum { get; set; }
        }
    }
}
