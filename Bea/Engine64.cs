#region Usings

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

namespace BeaEngine.Net
{
	public class BeaEngine64
	{
		public const string LibraryName = @"BeaEngine64.dll";

		[MethodImpl(MethodImplOptions.NoOptimization)]
		static BeaEngine64()
		{
			ResourcesHelper.LoadBea64();
		}

		public static UInt64 Version
		{
			get
			{
				return BeaEngineVersion();
			}
		}

		public static UInt64 Revision
		{
			get
			{
				return BeaEngineRevision();
			}
		}

		[DllImport(LibraryName)]
		public static extern int Disasm([In] [Out] [MarshalAs(UnmanagedType.LPStruct)] Disasm _disasm);

		[DllImport(LibraryName)]
		private static extern UInt64 BeaEngineVersion();

		[DllImport(LibraryName)]
		private static extern UInt64 BeaEngineRevision();
	}
}