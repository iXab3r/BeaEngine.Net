using System.Runtime.InteropServices;

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class EflStruct
    {
        public byte OF_;

        public byte SF_;

        public byte ZF_;

        public byte AF_;

        public byte PF_;

        public byte CF_;

        public byte TF_;

        public byte IF_;

        public byte DF_;

        public byte NT_;

        public byte RF_;

        public byte alignment;
    }
}