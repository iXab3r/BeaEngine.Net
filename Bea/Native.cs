#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace Bea
{
    internal static class Native
    {
        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr LoadLibrary(string _lpFileName);
    }
}