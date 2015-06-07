#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace Bea
{
    public class UnmanagedBuffer
    {
        public readonly int Length = 0;

        public readonly IntPtr Ptr = IntPtr.Zero;

        public UnmanagedBuffer(byte[] data)
        {
            Ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, Ptr, data.Length);
            Length = data.Length;
        }

        ~UnmanagedBuffer()
        {
            if (Ptr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(Ptr);
            }
        }
    }
}