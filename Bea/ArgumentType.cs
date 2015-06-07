using System;
using System.Runtime.InteropServices;

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class ArgumentType
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ArgMnemonic;

        public Int32 ArgType;

        public Int32 ArgSize;

        public UInt32 AccessMode;

        public MemoryType Memory;

        public UInt32 SegmentReg;
    }
}