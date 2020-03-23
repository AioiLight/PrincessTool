using System;
using System.IO;
using System.Linq;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace AioiLight.PrincessTool.Works
{
    public class RenameHashedFile : IWorkable
    {
        public RenameHashedFile()
        {
            var files = Directory.GetFiles(Program.Dest, "*.*", SearchOption.AllDirectories);
            var filesAmount = files.Count();

            HashList = new Dictionary<string, string>();
            var connection = new SQLiteConnection($"Data Source={Path.Combine(Program.Dest, @"manifest.db")};");
            connection.Open();
            try
            {
                // SQL文
                var sql = "SELECT * from t";
                var result = new SQLiteCommand(sql, connection).ExecuteReader();
                while (result.Read())
                {
                    var hash = result.GetString(1);
                    var filename = result.GetString(0);
                    if (!HashList.ContainsKey(hash))
                    {
                        HashList.Add(hash, filename);
                    }
                }
                result.Close();
            }
            finally
            {
                connection.Close();
            }
            new Progress("Rename hashed files", filesAmount, Process);
        }

        public void Process(IProgress<int> progress)
        {
            var files = Directory.GetFiles(Program.Dest, "*.*", SearchOption.AllDirectories);
            var cnt = 0;
            foreach (var item in files)
            {
                // ファイルの相対パスを出す。
                var itemFolder = Path.GetDirectoryName(item);
                var itemRelative = item.Substring(Program.Dest.Length + 1);

                if (!File.Exists(item))
                {
                    cnt++;
                progress.Report(cnt);
                    continue;
                }

                if (!itemRelative.Contains("\\"))
                {
                    // ルートのやつなので検索しない。
                    cnt++;
                    progress.Report(cnt);
                    continue;
                }

                // SHA1ハッシュの計算。
                var fileStream = new FileStream(item,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.None);
                var md5 = MD5.Create();
                var fileMD5 = md5.ComputeHash(fileStream);
                var hash = BitConverter.ToString(fileMD5).ToLower().Replace("-", "");

                // 後片付け
                md5.Clear();
                fileStream.Close();

                if (!HashList.ContainsKey(hash))
                {
                    cnt++;
                    progress.Report(cnt);
                    continue;
                }

                // リネームする。
                var result = Path.Combine(Path.GetDirectoryName(itemRelative), Path.GetFileName(HashList[hash]));

                try
                {
                    // note:たまにファイル名が重複しているやつがある？
                    File.Move(item, Path.Combine(Program.Dest, result));
                }
                catch (IOException)
                {

                }
                finally
                {
                    cnt++;
                    progress.Report(cnt);
                }

            }
        }

        private Dictionary<string, string> HashList;
    }
}
