using System;
using System.Runtime.InteropServices;

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class Disasm
    {
        public IntPtr EIP;

        public UInt64 VirtualAddr;

        public UInt32 SecurityBlock;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string CompleteInstr;

        public UInt32 Archi;

        public UInt64 Options;

        public InstructionType Instruction;

        public ArgumentType Argument1;

        public ArgumentType Argument2;

        public ArgumentType Argument3;

        public PrefixInfo Prefix;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
        private UInt32[] Reserved_;
    }
}