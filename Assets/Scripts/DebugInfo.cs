#if KMDEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KModkit.Internal
{
    public static class DebugInfo
    {
        public static string[] SourceDocuments()
        {
            return new string[0];
        }

        public static string[] DebugLines()
        {
            return new string[0];
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void _DebugLine(string line)
        {
        }
    }
}
#endif
