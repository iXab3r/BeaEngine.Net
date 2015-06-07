using System.Runtime.InteropServices;

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class REX_Struct
    {
        public byte W_;

        public byte R_;

        public byte X_;

        public byte B_;

        public byte state;
    }
}