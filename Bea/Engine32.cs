#region Usings

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

namespace Bea
{
    public class BeaEngine32
    {
        [MethodImpl(MethodImplOptions.NoOptimization)]
        static BeaEngine32()
        {
            ResourcesHelper.LoadBea32();
        }

        public static string Version
        {
            get
            {
                return BeaEngineVersion();
            }
        }

        public static string Revision
        {
            get
            {
                return BeaEngineRevision();
            }
        }

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall)]
        public static extern int Disasm([In] [Out] [MarshalAs(UnmanagedType.LPStruct)] Disasm _disasm);

        [DllImport(LibraryName,CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        private static extern string BeaEngineVersion();

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        private static extern string BeaEngineRevision();

        public const string LibraryName = @"BeaEngine32.dll";

    }
}