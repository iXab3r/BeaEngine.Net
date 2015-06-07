using System.Runtime.InteropServices;

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class PrefixInfo
    {
        public int Number;

        public int NbUndefined;

        public byte LockPrefix;

        public byte OperandSize;

        public byte AddressSize;

        public byte RepnePrefix;

        public byte RepPrefix;

        public byte FSPrefix;

        public byte SSPrefix;

        public byte GSPrefix;

        public byte ESPrefix;

        public byte CSPrefix;

        public byte DSPrefix;

        public byte BranchTaken;

        public byte BranchNotTaken;

        public REX_Struct REX;
    }
}