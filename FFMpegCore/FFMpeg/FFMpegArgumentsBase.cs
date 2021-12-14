using System.Collections.Generic;
using FFMpegCore.Arguments;

namespace FFMpegCore
{
    public abstract class FFMpegArgumentsBase
    {
        public readonly List<IArgument> Arguments = new List<IArgument>();
    }
}