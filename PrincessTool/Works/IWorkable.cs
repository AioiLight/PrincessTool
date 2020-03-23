using System;

namespace AioiLight.PrincessTool.Works
{
    public interface IWorkable
    {
        void Process(IProgress<int> progress);
    }
}
