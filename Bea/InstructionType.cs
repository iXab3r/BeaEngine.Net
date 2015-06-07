using System;
using System.Runtime.InteropServices;

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class InstructionType
    {
        public Int32 Category;

        public Int32 Opcode;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string Mnemonic;

        public Int32 BranchType;

        public EflStruct Flags;

        public UInt64 AddrValue;

        public Int64 Immediat;

        public UInt32 ImplicitModifiedRegs;
    }
}