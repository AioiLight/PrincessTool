using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AioiLight.PrincessTool.Works
{
    public class FileCopy : IWorkable
    {
        public FileCopy()
        {
            var files = Directory.GetFiles(Program.Origin, "*.*", SearchOption.AllDirectories);
            var filesAmount = files.Count();
            new Progress("Copy all files", filesAmount, Process);
        }

        public void Process(IProgress<int> progress)
        {
            var files = Directory.GetFiles(Program.Origin, "*.*", SearchOption.AllDirectories);
            var cnt = 0;
            foreach (var item in files)
            {
                // どこにコピーすべきか決定。
                var itemOriginFolder = Path.GetDirectoryName(item);
                var originFolder = Path.GetDirectoryName(Program.Origin);
                var itemRelative = item.Substring(originFolder.Length + 1);

                var itemDestPath = Path.Combine(Program.Dest, itemRelative);
                var itemDestFolder = Path.GetDirectoryName(itemDestPath);
                if (!Directory.Exists(itemDestFolder))
                {
                    // ディレクトリがなかったら作る。
                    Directory.CreateDirectory(itemDestFolder);
                }

                // コピーする。
                File.Copy(item, itemDestPath, true);
                cnt++;
                progress.Report(cnt);
            }
        }
    }
}
