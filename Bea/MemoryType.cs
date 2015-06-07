#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace Bea
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class MemoryType
    {
        public Int32 BaseRegister;

        public Int32 IndexRegister;

        public Int32 Scale;

        public Int64 Displacement;
    }
}