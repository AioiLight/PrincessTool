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
            var files = Directory.GetFiles(Program.Origin, "*.*");
            var filesAmount = files.Count();
            new Progress("Copy all files", filesAmount, Process);
        }

        public void Process(IProgress<int> progress)
        {

        }
    }
}
