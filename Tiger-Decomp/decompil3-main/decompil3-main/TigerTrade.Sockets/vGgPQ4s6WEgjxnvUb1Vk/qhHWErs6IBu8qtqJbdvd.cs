using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using HExkDCsORifnalUv1owx;
using rXssPVsOOYd71bKiWjYb;
using UxBecVsOUPcejrh1NEnp;
using xK07mpsq2KGB3PNnpKCM;

namespace vGgPQ4s6WEgjxnvUb1Vk;

internal class qhHWErs6IBu8qtqJbdvd
{
	private delegate void ArfVuXsOo3bF3f78lDLe(object o);

	internal class cD1JeBsOvtW1B1YscW4K : Attribute
	{
		internal class eVDJHasOBPQFpehqrh1G<kyT4ZAsOayCTm53aGOP4>
		{
			private static object KxKuMssrv0hnWfmYKd9H;

			public eVDJHasOBPQFpehqrh1G()
			{
				wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
				base._002Ector();
			}

			static eVDJHasOBPQFpehqrh1G()
			{
				DI9s6AAreQp();
				vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool NO4ZvSsrBd4IYyI4Y9nC()
			{
				return KxKuMssrv0hnWfmYKd9H == null;
			}

			internal static object N9Ul9lsraAhIr8YP8eFY()
			{
				return KxKuMssrv0hnWfmYKd9H;
			}
		}

		public cD1JeBsOvtW1B1YscW4K(object P_0)
		{
		}

		static cD1JeBsOvtW1B1YscW4K()
		{
			sIinZ1sroIkiWp9BF8If();
		}

		internal static void sIinZ1sroIkiWp9BF8If()
		{
			vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class giqV0vsOiwAZKu0UBL0E
	{
		internal static string oYYsOlhOrZP(string P_0, string P_1)
		{
			byte[] array = (byte[])jQ6NSPsrDp7WotKoh3CJ(Encoding.Unicode, P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array2 = PE6s6h0AnpZ(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = tNvs6Ku5yIH();
			symmetricAlgorithm.Key = key;
			rKqeq6srb2qv4XudS6wd(symmetricAlgorithm, array2);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			virR9OsrNFwntpfJTHo2(cryptoStream);
			return (string)RqwbZssrk38afXGX02pc(memoryStream.ToArray());
		}

		static giqV0vsOiwAZKu0UBL0E()
		{
			h7or8Csr1PLDvjik17EZ();
		}

		internal static object jQ6NSPsrDp7WotKoh3CJ(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static void rKqeq6srb2qv4XudS6wd(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
		}

		internal static void virR9OsrNFwntpfJTHo2(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object RqwbZssrk38afXGX02pc(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}

		internal static void h7or8Csr1PLDvjik17EZ()
		{
			vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint rtRWWEsO4jWQYHtK3CtG(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr bNq0xRsOD4gvO2ESbT5a();

	internal struct yZkLM7sObKYhahN2dIWj
	{
		internal bool hWKsONqGP5R;

		internal byte[] TLksOkbT8Uy;
	}

	internal class Lo0gPNsO1FdPmLPkq0Hr
	{
		private BinaryReader IERsOeMB2h8;

		public Lo0gPNsO1FdPmLPkq0Hr(Stream P_0)
		{
			IERsOeMB2h8 = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return (Stream)AaFUavsrXesAIHRkXBRZ(IERsOeMB2h8);
		}

		internal byte[] XHIsO5TRG9D(int P_0)
		{
			return (byte[])WF60Udsrc2u8qqtKuLnp(IERsOeMB2h8, P_0);
		}

		internal int l63sOS3krRx(byte[] P_0, int P_1, int P_2)
		{
			return IERsOeMB2h8.Read(P_0, P_1, P_2);
		}

		internal int MjKsOxP50KB()
		{
			return IERsOeMB2h8.ReadInt32();
		}

		internal void KHDsOLUmm9l()
		{
			IERsOeMB2h8.Close();
		}

		static Lo0gPNsO1FdPmLPkq0Hr()
		{
			vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object AaFUavsrXesAIHRkXBRZ(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static object WF60Udsrc2u8qqtKuLnp(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ODPVTwsOsbfd47ouZX4i(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr QA7WCSsOXZ5ilCjDwnKE(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int qSD7DysOcjuOprhGxfDL(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int DmbBMmsOjeE1AUAeAQ42(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr vMUruusOEZVppgJCHY17(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int IDfUj4sOQPYlSmeYHRMh(IntPtr ptr);

	[Flags]
	private enum lpntwAsOdUdudxYnFfVk
	{

	}

	internal static RSACryptoServiceProvider miosM6vfNJe;

	private static object A6WsMObRWei;

	private static List<int> QpDsMtd1GaN;

	private static int MTMsMhmwRoH;

	internal static rtRWWEsO4jWQYHtK3CtG LcOsM8Yntcy;

	internal static Hashtable c9JsMzaIENI;

	private static IntPtr uaMsMpNnuPu;

	private static DmbBMmsOjeE1AUAeAQ42 c0QsOf6FOmj;

	private static IDfUj4sOQPYlSmeYHRMh Aw3sOnHM7kL;

	private static object wEOsMVgBOyI;

	[cD1JeBsOvtW1B1YscW4K(typeof(cD1JeBsOvtW1B1YscW4K.eVDJHasOBPQFpehqrh1G<object>[]))]
	private static bool oRbsMuWrV9T;

	private static long HsssMACNIW6;

	internal static Assembly sWHsMQluTaT;

	private static string Ur8sOYAIcHd;

	private static int[] hiDsMCHcS90;

	private static byte[] RHKsMTVVRdK;

	internal static rtRWWEsO4jWQYHtK3CtG vl4sM7VDv5B;

	private static bool EgnsMK0S31r;

	private static ODPVTwsOsbfd47ouZX4i infsO0fsACg;

	private static Dictionary<int, int> fNesMMB02xC;

	private static QA7WCSsOXZ5ilCjDwnKE by7sO21hjeE;

	private static bool qpVsMFDdONb;

	private static SortedList jtEsMm1rle0;

	private static bool RjdsMgWfN2D;

	private static bool KSZsMR6lxSm;

	private static qSD7DysOcjuOprhGxfDL VfssOHPNRwM;

	private static int vndsMrXN9EJ;

	private static int FJasMP29jeY;

	private static long B77sMw11dFt;

	private static bool AngsMEjN4bN;

	private static IntPtr pbSsMZqXNZ8;

	private static int iivsMqjQQCo;

	private static object X4DsMIawIws;

	private static bool DSxsMJvnOyb;

	private static List<string> HBZsMWg7JlD;

	private static IntPtr eZYsMyEQJDb;

	private static IntPtr XjDsOGDG25F;

	private static vMUruusOEZVppgJCHY17 GTDsO9TO5lV;

	private static uint[] NJWsMdOT7l8;

	private static byte[] F4tsMUsC15o;

	private static int UegsM3xbldt;

	static qhHWErs6IBu8qtqJbdvd()
	{
		vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
		AngsMEjN4bN = false;
		sWHsMQluTaT = Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554447)).Assembly;
		NJWsMdOT7l8 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		RjdsMgWfN2D = false;
		KSZsMR6lxSm = false;
		miosM6vfNJe = null;
		fNesMMB02xC = null;
		A6WsMObRWei = new object();
		iivsMqjQQCo = 0;
		X4DsMIawIws = new object();
		HBZsMWg7JlD = null;
		QpDsMtd1GaN = null;
		F4tsMUsC15o = new byte[0];
		RHKsMTVVRdK = new byte[0];
		eZYsMyEQJDb = IntPtr.Zero;
		pbSsMZqXNZ8 = IntPtr.Zero;
		wEOsMVgBOyI = new string[0];
		hiDsMCHcS90 = new int[0];
		vndsMrXN9EJ = 1;
		EgnsMK0S31r = false;
		jtEsMm1rle0 = new SortedList();
		MTMsMhmwRoH = 0;
		B77sMw11dFt = 0L;
		vl4sM7VDv5B = null;
		LcOsM8Yntcy = null;
		HsssMACNIW6 = 0L;
		FJasMP29jeY = 0;
		DSxsMJvnOyb = false;
		qpVsMFDdONb = false;
		UegsM3xbldt = 0;
		uaMsMpNnuPu = IntPtr.Zero;
		oRbsMuWrV9T = false;
		c9JsMzaIENI = new Hashtable();
		infsO0fsACg = null;
		by7sO21hjeE = null;
		VfssOHPNRwM = null;
		c0QsOf6FOmj = null;
		GTDsO9TO5lV = null;
		Aw3sOnHM7kL = null;
		XjDsOGDG25F = IntPtr.Zero;
		Ur8sOYAIcHd = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void J9fsAV1THlM()
	{
	}

	internal static byte[] epBs6ta8lbO(byte[] P_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - P_0.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(P_0.Length + num / 8 + 8);
		ulong num3 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			I4Ls6UA7hGP(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			I4Ls6UA7hGP(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			I4Ls6UA7hGP(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			I4Ls6UA7hGP(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			I4Ls6UA7hGP(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			I4Ls6UA7hGP(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			I4Ls6UA7hGP(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			I4Ls6UA7hGP(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			I4Ls6UA7hGP(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			I4Ls6UA7hGP(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			I4Ls6UA7hGP(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			I4Ls6UA7hGP(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			I4Ls6UA7hGP(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			I4Ls6UA7hGP(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			I4Ls6UA7hGP(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			I4Ls6UA7hGP(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			TeBs6TnC0M7(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			TeBs6TnC0M7(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			TeBs6TnC0M7(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			TeBs6TnC0M7(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			TeBs6TnC0M7(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			TeBs6TnC0M7(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			TeBs6TnC0M7(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			TeBs6TnC0M7(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			TeBs6TnC0M7(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			TeBs6TnC0M7(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			TeBs6TnC0M7(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			TeBs6TnC0M7(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			TeBs6TnC0M7(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			TeBs6TnC0M7(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			TeBs6TnC0M7(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			TeBs6TnC0M7(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			xfAs6ybOElC(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			xfAs6ybOElC(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			xfAs6ybOElC(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			xfAs6ybOElC(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			xfAs6ybOElC(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			xfAs6ybOElC(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			xfAs6ybOElC(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			xfAs6ybOElC(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			xfAs6ybOElC(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			xfAs6ybOElC(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			xfAs6ybOElC(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			xfAs6ybOElC(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			xfAs6ybOElC(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			xfAs6ybOElC(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			xfAs6ybOElC(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			xfAs6ybOElC(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			Nu2s6Z5bDPG(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			Nu2s6Z5bDPG(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			Nu2s6Z5bDPG(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			Nu2s6Z5bDPG(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			Nu2s6Z5bDPG(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			Nu2s6Z5bDPG(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			Nu2s6Z5bDPG(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			Nu2s6Z5bDPG(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			Nu2s6Z5bDPG(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			Nu2s6Z5bDPG(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			Nu2s6Z5bDPG(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			Nu2s6Z5bDPG(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			Nu2s6Z5bDPG(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			Nu2s6Z5bDPG(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			Nu2s6Z5bDPG(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			Nu2s6Z5bDPG(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	private static void I4Ls6UA7hGP(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + bhUs6V53Xn9(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + NJWsMdOT7l8[P_6 - 1], P_5);
	}

	private static void TeBs6TnC0M7(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + bhUs6V53Xn9(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + NJWsMdOT7l8[P_6 - 1], P_5);
	}

	private static void xfAs6ybOElC(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + bhUs6V53Xn9(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + NJWsMdOT7l8[P_6 - 1], P_5);
	}

	private static void Nu2s6Z5bDPG(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + bhUs6V53Xn9(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + NJWsMdOT7l8[P_6 - 1], P_5);
	}

	private static uint bhUs6V53Xn9(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool B66s6CYEkqy()
	{
		if (!RjdsMgWfN2D)
		{
			xOfs6mmkth5();
			RjdsMgWfN2D = true;
		}
		return KSZsMR6lxSm;
	}

	internal qhHWErs6IBu8qtqJbdvd()
	{
	}

	private void gBHs6ru7UAC(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		int num = P_2.Length % 4;
		int num2 = P_2.Length / 4;
		byte[] array = new byte[P_2.Length];
		int num3 = P_0.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= P_2[P_2.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + 1] << 8) | P_2[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = 316093745u;
			uint num14 = 712448728u;
			uint num15 = 2061577663u;
			uint num16 = num12;
			uint num17 = 1809831234u;
			uint num18 = 1374586903u;
			ulong num19 = 1596760126 * num15;
			num19 |= 1;
			num14 = (uint)(num14 * num14 % num19);
			num17 -= num13;
			if ((double)num13 == 0.0)
			{
				num13--;
			}
			uint num20 = (uint)(-6346.0 / (double)num13 + (double)num13);
			num13 = (uint)((ulong)(1482676717 + num20) + 14500uL);
			num15 += num14;
			uint num21 = num18 & 0xFF00FF;
			uint num22 = num18 & 0xFF00FF00u;
			num21 = ((num21 >> 8) | (num22 << 8)) ^ num14;
			num18 = (num18 << 8) | (num18 >> 24);
			num16 ^= num16 >> 6;
			num16 += num13;
			num16 ^= num16 >> 11;
			num16 += num15;
			num16 ^= num16 << 1;
			num16 += num18;
			num16 = (((num15 << 20) - num15) ^ num13) + num16;
			num4 = num12 + (uint)(double)num16;
			if (i == num2 - 1 && num > 0)
			{
				uint num23 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num23 & num10) >> num11);
				}
			}
			else
			{
				uint num24 = num4 ^ num6;
				array[num9] = (byte)(num24 & 0xFF);
				array[num9 + 1] = (byte)((num24 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num24 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num24 & 0xFF000000u) >> 24);
			}
		}
		F4tsMUsC15o = array;
	}

	internal static SymmetricAlgorithm tNvs6Ku5yIH()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (B66s6CYEkqy())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	internal static void xOfs6mmkth5()
	{
		try
		{
			KSZsMR6lxSm = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] PE6s6h0AnpZ(byte[] P_0)
	{
		if (!B66s6CYEkqy())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return epBs6ta8lbO(P_0);
	}

	internal static void pZ2s6woPkhx(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			G29s67IGL2i(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void G29s67IGL2i(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint CvIs68r0Feb(uint P_0, int P_1, long P_2, BinaryReader P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			P_3.BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = P_3.ReadUInt32();
			uint num2 = P_3.ReadUInt32();
			P_3.ReadUInt32();
			uint num3 = P_3.ReadUInt32();
			if (num2 <= P_0 && P_0 < num2 + num)
			{
				return num3 + P_0 - num2;
			}
		}
		return 0u;
	}

	internal static void DI9s6AAreQp()
	{
		int num = 16;
		BinaryReader binaryReader = default(BinaryReader);
		string text2 = default(string);
		bool flag = default(bool);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text = default(string);
		byte[] array7 = default(byte[]);
		uint num24 = default(uint);
		uint num21 = default(uint);
		long num17 = default(long);
		long num18 = default(long);
		long num16 = default(long);
		uint num28 = default(uint);
		int num15 = default(int);
		long num14 = default(long);
		byte[] array6 = default(byte[]);
		int num22 = default(int);
		uint num27 = default(uint);
		long num19 = default(long);
		uint num20 = default(uint);
		uint num25 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						if (binaryReader != null)
						{
							int num7 = 1;
							if (PXxRfMsV9JycIuIwjGNn() != null)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									ziq54osVyf2CftqUixAF(binaryReader);
									num7 = 0;
									if (PXxRfMsV9JycIuIwjGNn() == null)
									{
										num7 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					catch
					{
						int num8 = 0;
						if (PXxRfMsV9JycIuIwjGNn() != null)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 2;
				case 6:
					miosM6vfNJe = new RSACryptoServiceProvider();
					num2 = 5;
					continue;
				case 16:
					if (miosM6vfNJe == null)
					{
						num2 = 15;
						continue;
					}
					return;
				case 7:
					try
					{
						FileStream fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num11 = 7;
						while (true)
						{
							int num23;
							switch (num11)
							{
							case 34:
								flag = !lUg9K7sVTxmncD4m4Jf3(miosM6vfNJe, O6iEqgsVUjnsh4lVnVGK(hashAlgorithm), text, array7);
								num11 = 14;
								continue;
							case 1:
								num24 = Ij0Ey4sVM14vFj36xMn0(binaryReader);
								num11 = 21;
								if (Ng92lqsVfjqGe8jg5hh5())
								{
									num11 = 37;
								}
								continue;
							case 7:
								binaryReader = new BinaryReader(fileStream);
								num11 = 24;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 24;
								}
								continue;
							case 3:
								paHrsUsVDti4LsdHp0of(fileStream, HBw6glsV6pNlju5rFAI3(fileStream) + num21);
								num11 = 20;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 32;
								}
								continue;
							case 12:
							case 26:
							case 33:
								if (num17 < num18)
								{
									num11 = 16;
									continue;
								}
								goto case 10;
							case 20:
								paHrsUsVDti4LsdHp0of(fileStream, num16);
								num11 = 31;
								continue;
							case 39:
							case 40:
								num28 = IgJbCQsVOsWeGmj9OJo8(Ij0Ey4sVM14vFj36xMn0(binaryReader), num15, num14, binaryReader);
								num11 = 2;
								if (!Ng92lqsVfjqGe8jg5hh5())
								{
									num11 = 1;
								}
								continue;
							case 17:
								zWSYIysVQenRdOWyrYeN(hashAlgorithm, fileStream, 152u, array6);
								num11 = 43;
								continue;
							case 31:
								num22 = 0;
								num11 = 36;
								continue;
							case 27:
								paHrsUsVDti4LsdHp0of(fileStream, num27);
								num11 = 44;
								if (PXxRfMsV9JycIuIwjGNn() != null)
								{
									num11 = 27;
								}
								continue;
							case 13:
							case 32:
							case 44:
								if (num24 == 0)
								{
									num11 = 0;
									if (Ng92lqsVfjqGe8jg5hh5())
									{
										num11 = 4;
									}
									continue;
								}
								goto default;
							case 9:
								if (num17 >= num18)
								{
									num11 = 8;
									if (PXxRfMsV9JycIuIwjGNn() == null)
									{
										num11 = 12;
									}
									continue;
								}
								goto case 5;
							case 11:
								num18 = num19 + num20;
								num11 = 20;
								continue;
							case 4:
							case 22:
							case 42:
								num22++;
								num11 = 35;
								continue;
							case 24:
								array6 = new byte[65536];
								num11 = 11;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 17;
								}
								continue;
							case 6:
								if (num19 > num17)
								{
									num11 = 33;
									continue;
								}
								goto case 9;
							case 25:
								num24 -= num25;
								num11 = 13;
								if (!Ng92lqsVfjqGe8jg5hh5())
								{
									num11 = 13;
								}
								continue;
							case 29:
								zWSYIysVQenRdOWyrYeN(hashAlgorithm, fileStream, num25, array6);
								num11 = 25;
								continue;
							case 8:
								if (num21 >= num24)
								{
									num11 = 22;
									continue;
								}
								goto case 28;
							case 19:
								sOBBTosVIB1WoNxXrqbP(hashAlgorithm, new byte[0], 0, 0);
								num23 = 30;
								goto IL_0151;
							case 2:
								paHrsUsVDti4LsdHp0of(fileStream, num28 + 32);
								num11 = 15;
								continue;
							case 5:
								num21 = (uint)(num18 - num17);
								num11 = 3;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 8;
								}
								continue;
							case 41:
								paHrsUsVDti4LsdHp0of(fileStream, num14 + num22 * 40 + 16);
								num11 = 0;
								if (Ng92lqsVfjqGe8jg5hh5())
								{
									num11 = 1;
								}
								continue;
							case 37:
								num27 = Ij0Ey4sVM14vFj36xMn0(binaryReader);
								num11 = 14;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 27;
								}
								continue;
							case 28:
								num24 -= num21;
								num11 = 3;
								continue;
							case 15:
							{
								uint num26 = Ij0Ey4sVM14vFj36xMn0(binaryReader);
								num20 = Ij0Ey4sVM14vFj36xMn0(binaryReader);
								num19 = IgJbCQsVOsWeGmj9OJo8(num26, num15, num14, binaryReader);
								num11 = 11;
								continue;
							}
							case 38:
								paHrsUsVDti4LsdHp0of(fileStream, 376L);
								num11 = 36;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 39;
								}
								continue;
							case 16:
							case 21:
								num25 = (uint)NjloyhsVqFJmCmo2XJtv(num19 - num17, num24);
								num23 = 29;
								goto IL_0151;
							case 30:
								paHrsUsVDti4LsdHp0of(fileStream, num19);
								num11 = 18;
								if (PXxRfMsV9JycIuIwjGNn() == null)
								{
									num11 = 18;
								}
								continue;
							case 18:
								array7 = (byte[])LwtPFfsVWxn7iX56sW5r(binaryReader, (int)num20);
								num11 = 8;
								if (Ng92lqsVfjqGe8jg5hh5())
								{
									num11 = 45;
								}
								continue;
							default:
								num17 = HBw6glsV6pNlju5rFAI3(fileStream);
								num11 = 6;
								continue;
							case 10:
								zWSYIysVQenRdOWyrYeN(hashAlgorithm, fileStream, num24, array6);
								num11 = 42;
								continue;
							case 35:
							case 36:
								if (num22 >= num15)
								{
									num23 = 19;
									goto IL_0151;
								}
								goto case 41;
							case 23:
								paHrsUsVDti4LsdHp0of(fileStream, 360L);
								num11 = 40;
								continue;
							case 45:
								vYppbqsVtPAZKuLbEE4v(array7);
								num11 = 0;
								if (Ng92lqsVfjqGe8jg5hh5())
								{
									num11 = 34;
								}
								continue;
							case 43:
							{
								bool num12 = wwhp99sVd8jgsKLILdro(binaryReader) != 523;
								int num13 = (num12 ? 96 : 112);
								paHrsUsVDti4LsdHp0of(fileStream, 152L);
								qfocXUsVg5CEsqsb81O8(fileStream, array6, 0, num13);
								array6[64] = 0;
								array6[65] = 0;
								array6[66] = 0;
								array6[67] = 0;
								qCm4hWsVR5tbCYpmTorV(hashAlgorithm, array6, 0, num13);
								qfocXUsVg5CEsqsb81O8(fileStream, array6, 0, 128);
								array6[32] = 0;
								array6[33] = 0;
								array6[34] = 0;
								array6[35] = 0;
								array6[36] = 0;
								array6[37] = 0;
								array6[38] = 0;
								array6[39] = 0;
								qCm4hWsVR5tbCYpmTorV(hashAlgorithm, array6, 0, 128);
								num14 = HBw6glsV6pNlju5rFAI3(fileStream);
								paHrsUsVDti4LsdHp0of(fileStream, 134L);
								num15 = wwhp99sVd8jgsKLILdro(binaryReader);
								paHrsUsVDti4LsdHp0of(fileStream, num14);
								zWSYIysVQenRdOWyrYeN(hashAlgorithm, fileStream, (uint)(num15 * 40), array6);
								num16 = HBw6glsV6pNlju5rFAI3(fileStream);
								if (num12)
								{
									num11 = 13;
									if (Ng92lqsVfjqGe8jg5hh5())
									{
										num11 = 23;
									}
									continue;
								}
								goto case 38;
							}
							case 14:
								break;
								IL_0151:
								num11 = num23;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num29 = 0;
						if (Ng92lqsVfjqGe8jg5hh5())
						{
							num29 = 0;
						}
						while (true)
						{
							switch (num29)
							{
							default:
								flag = true;
								num29 = 1;
								if (!Ng92lqsVfjqGe8jg5hh5())
								{
									num29 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 19;
				case 10:
					throw new Exception((string)Ode4vAsVClHXDXeBkZB6(Foeok2sVVyEILSWFUbms(L1bTfUsVZc5ZroMBQujs(qaXMY6sVYelyUlGv2AYJ(typeof(qhHWErs6IBu8qtqJbdvd).TypeHandle).Assembly)), " is tampered."));
				case 19:
					num2 = 0;
					if (PXxRfMsV9JycIuIwjGNn() == null)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 15:
					O8dRgfsVnQg0cuuQjhtK();
					num2 = 13;
					continue;
				case 21:
					if (yZ48NMsVvJbrbBpuB9n8(text2) != 0)
					{
						num2 = 4;
						continue;
					}
					return;
				case 17:
					if (text2 == null)
					{
						num2 = 9;
						continue;
					}
					goto case 21;
				case 9:
					return;
				case 8:
					try
					{
						hashAlgorithm = (HashAlgorithm)PhKURRsVBvAoKanXAvow();
						int num9 = 1;
						if (Ng92lqsVfjqGe8jg5hh5())
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								text = (string)zRGXpfsVaw4VZ57bCr8S("SHA1");
								num9 = 1;
								if (Ng92lqsVfjqGe8jg5hh5())
								{
									num9 = 3;
								}
								continue;
							case 3:
								if (!dYILUbsViQTYqUYasoAM(text2))
								{
									num9 = 0;
									if (PXxRfMsV9JycIuIwjGNn() == null)
									{
										num9 = 0;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
					}
					catch
					{
						int num10 = 0;
						if (!Ng92lqsVfjqGe8jg5hh5())
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
						return;
					}
					break;
				case 5:
					text2 = (string)IGvPkQsVohH6QuZJDSs1(qaXMY6sVYelyUlGv2AYJ(typeof(qhHWErs6IBu8qtqJbdvd).TypeHandle).Assembly);
					num2 = 17;
					continue;
				case 12:
					text = null;
					num2 = 6;
					if (PXxRfMsV9JycIuIwjGNn() == null)
					{
						num2 = 8;
					}
					continue;
				case 2:
				case 11:
					if (!flag)
					{
						flag = false;
						num2 = 3;
						if (!Ng92lqsVfjqGe8jg5hh5())
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 10;
					}
					continue;
				case 14:
					try
					{
						Lo0gPNsO1FdPmLPkq0Hr lo0gPNsO1FdPmLPkq0Hr = new Lo0gPNsO1FdPmLPkq0Hr((Stream)nrLicBsVldr0nONrTqmR(sWHsMQluTaT, "S3oFb7s6XLUfhY24c3Wn.k3JLZ2s6cRi5kQVahtO3"));
						paHrsUsVDti4LsdHp0of(EvN1ahsV4DfDyAZQ7xo8(lo0gPNsO1FdPmLPkq0Hr), 0L);
						byte[] array = (byte[])hWM3ZnsVN0Pq1r2i1bHK(lo0gPNsO1FdPmLPkq0Hr, (int)tY3FlIsVbb4MxbOBOSJ8(EvN1ahsV4DfDyAZQ7xo8(lo0gPNsO1FdPmLPkq0Hr)));
						byte[] array2 = new byte[32];
						int num3 = 182 - 60;
						array2[0] = (byte)num3;
						num3 = 229 - 76;
						array2[0] = (byte)num3;
						num3 = 157 - 52;
						array2[0] = (byte)num3;
						array2[0] = 158;
						num3 = 97 + 49;
						array2[0] = (byte)num3;
						array2[0] = 188;
						array2[1] = 160;
						array2[1] = 98;
						array2[1] = 14;
						num3 = 196 - 65;
						array2[1] = (byte)num3;
						array2[1] = 160;
						num3 = 228 - 76;
						array2[2] = (byte)num3;
						num3 = 153 - 51;
						array2[2] = (byte)num3;
						num3 = 155 + 8;
						array2[2] = (byte)num3;
						num3 = 174 - 58;
						array2[3] = (byte)num3;
						array2[3] = 90;
						num3 = 83 + 85;
						array2[3] = (byte)num3;
						array2[4] = 108;
						array2[4] = 199;
						num3 = 142 - 117;
						array2[4] = (byte)num3;
						num3 = 247 - 82;
						array2[5] = (byte)num3;
						num3 = 250 - 83;
						array2[5] = (byte)num3;
						num3 = 218 - 72;
						array2[5] = (byte)num3;
						array2[5] = 60;
						array2[5] = 130;
						num3 = 100 - 88;
						array2[5] = (byte)num3;
						array2[6] = 193;
						array2[6] = 177;
						array2[6] = 220;
						num3 = 22 + 16;
						array2[7] = (byte)num3;
						num3 = 120 + 101;
						array2[7] = (byte)num3;
						array2[7] = 19;
						array2[8] = 130;
						num3 = 99 + 121;
						array2[8] = (byte)num3;
						num3 = 104 + 34;
						array2[8] = (byte)num3;
						num3 = 65 + 82;
						array2[9] = (byte)num3;
						array2[9] = 122;
						num3 = 130 - 61;
						array2[9] = (byte)num3;
						num3 = 230 - 76;
						array2[10] = (byte)num3;
						array2[10] = 169;
						array2[10] = 110;
						array2[10] = 106;
						array2[10] = 153;
						num3 = 140 + 87;
						array2[10] = (byte)num3;
						num3 = 56 + 74;
						array2[11] = (byte)num3;
						num3 = 242 - 80;
						array2[11] = (byte)num3;
						num3 = 39 + 99;
						array2[11] = (byte)num3;
						array2[11] = 161;
						num3 = 76 + 58;
						array2[12] = (byte)num3;
						num3 = 135 - 45;
						array2[12] = (byte)num3;
						array2[12] = 203;
						num3 = 60 + 102;
						array2[12] = (byte)num3;
						num3 = 108 - 28;
						array2[12] = (byte)num3;
						num3 = 221 - 73;
						array2[13] = (byte)num3;
						num3 = 102 + 22;
						array2[13] = (byte)num3;
						num3 = 198 - 114;
						array2[13] = (byte)num3;
						num3 = 228 - 76;
						array2[14] = (byte)num3;
						num3 = 159 - 53;
						array2[14] = (byte)num3;
						num3 = 54 + 52;
						array2[14] = (byte)num3;
						array2[14] = 152;
						array2[14] = 228;
						num3 = 194 - 64;
						array2[15] = (byte)num3;
						array2[15] = 233;
						num3 = 225 - 75;
						array2[15] = (byte)num3;
						num3 = 37 + 57;
						array2[15] = (byte)num3;
						array2[15] = 100;
						array2[15] = 103;
						array2[16] = 147;
						array2[16] = 124;
						num3 = 123 + 56;
						array2[16] = (byte)num3;
						num3 = 139 - 45;
						array2[16] = (byte)num3;
						array2[17] = 103;
						num3 = 141 - 47;
						array2[17] = (byte)num3;
						num3 = 93 + 14;
						array2[17] = (byte)num3;
						array2[17] = 134;
						num3 = 16 + 3;
						array2[17] = (byte)num3;
						num3 = 118 + 80;
						array2[17] = (byte)num3;
						num3 = 29 + 80;
						array2[18] = (byte)num3;
						num3 = 84 + 108;
						array2[18] = (byte)num3;
						array2[18] = 100;
						num3 = 153 - 51;
						array2[18] = (byte)num3;
						array2[18] = 99;
						array2[18] = 181;
						num3 = 72 + 114;
						array2[19] = (byte)num3;
						array2[19] = 138;
						array2[19] = 140;
						num3 = 23 - 4;
						array2[19] = (byte)num3;
						num3 = 68 + 31;
						array2[20] = (byte)num3;
						array2[20] = 94;
						num3 = 219 + 30;
						array2[20] = (byte)num3;
						array2[21] = 150;
						array2[21] = 169;
						num3 = 209 - 69;
						array2[21] = (byte)num3;
						array2[21] = 62;
						num3 = 138 - 109;
						array2[21] = (byte)num3;
						num3 = 49 + 99;
						array2[22] = (byte)num3;
						num3 = 179 - 59;
						array2[22] = (byte)num3;
						num3 = 221 + 8;
						array2[22] = (byte)num3;
						array2[23] = 154;
						array2[23] = 132;
						array2[23] = 157;
						num3 = 32 + 87;
						array2[23] = (byte)num3;
						array2[23] = 94;
						num3 = 78 + 91;
						array2[23] = (byte)num3;
						array2[24] = 136;
						array2[24] = 102;
						array2[24] = 153;
						num3 = 6 + 76;
						array2[24] = (byte)num3;
						num3 = 191 - 63;
						array2[24] = (byte)num3;
						array2[24] = 175;
						num3 = 148 - 49;
						array2[25] = (byte)num3;
						num3 = 69 + 104;
						array2[25] = (byte)num3;
						num3 = 241 - 80;
						array2[25] = (byte)num3;
						array2[25] = 94;
						array2[25] = 189;
						array2[26] = 109;
						num3 = 208 - 69;
						array2[26] = (byte)num3;
						array2[26] = 148;
						array2[26] = 102;
						num3 = 162 + 77;
						array2[26] = (byte)num3;
						num3 = 53 + 25;
						array2[27] = (byte)num3;
						array2[27] = 99;
						array2[27] = 156;
						num3 = 125 + 38;
						array2[27] = (byte)num3;
						num3 = 185 - 61;
						array2[28] = (byte)num3;
						num3 = 141 - 47;
						array2[28] = (byte)num3;
						array2[28] = 140;
						array2[29] = 113;
						array2[29] = 27;
						array2[29] = 230;
						array2[30] = 147;
						array2[30] = 150;
						array2[30] = 35;
						num3 = 79 + 54;
						array2[31] = (byte)num3;
						array2[31] = 158;
						array2[31] = 222;
						byte[] array3 = array2;
						byte[] array4 = new byte[16];
						int num4 = 55 + 121;
						array4[0] = (byte)num4;
						array4[0] = 106;
						num4 = 56 + 102;
						array4[0] = (byte)num4;
						array4[0] = 146;
						array4[0] = 164;
						array4[0] = 128;
						num4 = 2 + 51;
						array4[1] = (byte)num4;
						array4[1] = 53;
						array4[1] = 130;
						num4 = 131 + 99;
						array4[1] = (byte)num4;
						num4 = 27 + 73;
						array4[2] = (byte)num4;
						num4 = 73 + 47;
						array4[2] = (byte)num4;
						num4 = 10 + 45;
						array4[2] = (byte)num4;
						array4[2] = 6;
						num4 = 36 + 114;
						array4[3] = (byte)num4;
						num4 = 107 + 85;
						array4[3] = (byte)num4;
						array4[3] = 208;
						num4 = 120 + 41;
						array4[3] = (byte)num4;
						array4[3] = 156;
						num4 = 175 - 58;
						array4[3] = (byte)num4;
						array4[4] = 130;
						array4[4] = 144;
						array4[4] = 207;
						array4[5] = 144;
						num4 = 199 - 66;
						array4[5] = (byte)num4;
						num4 = 71 + 22;
						array4[5] = (byte)num4;
						array4[5] = 148;
						array4[5] = 155;
						array4[5] = 62;
						num4 = 228 - 76;
						array4[6] = (byte)num4;
						array4[6] = 102;
						num4 = 65 + 82;
						array4[6] = (byte)num4;
						num4 = 55 + 96;
						array4[6] = (byte)num4;
						num4 = 146 + 48;
						array4[6] = (byte)num4;
						array4[7] = 145;
						num4 = 164 - 54;
						array4[7] = (byte)num4;
						num4 = 159 - 53;
						array4[7] = (byte)num4;
						array4[7] = 244;
						array4[8] = 146;
						array4[8] = 123;
						num4 = 93 - 27;
						array4[8] = (byte)num4;
						num4 = 151 - 50;
						array4[9] = (byte)num4;
						array4[9] = 152;
						array4[9] = 185;
						num4 = 218 - 72;
						array4[9] = (byte)num4;
						num4 = 195 + 37;
						array4[9] = (byte)num4;
						num4 = 241 - 80;
						array4[10] = (byte)num4;
						num4 = 60 + 102;
						array4[10] = (byte)num4;
						array4[10] = 104;
						array4[10] = 54;
						num4 = 163 - 54;
						array4[11] = (byte)num4;
						array4[11] = 45;
						num4 = 140 + 2;
						array4[11] = (byte)num4;
						num4 = 114 + 33;
						array4[12] = (byte)num4;
						num4 = 181 - 60;
						array4[12] = (byte)num4;
						num4 = 35 + 98;
						array4[12] = (byte)num4;
						array4[12] = 94;
						num4 = 151 - 50;
						array4[12] = (byte)num4;
						num4 = 207 - 121;
						array4[12] = (byte)num4;
						num4 = 96 + 11;
						array4[13] = (byte)num4;
						num4 = 185 - 61;
						array4[13] = (byte)num4;
						array4[13] = 55;
						num4 = 220 - 73;
						array4[13] = (byte)num4;
						array4[13] = 102;
						num4 = 181 + 41;
						array4[13] = (byte)num4;
						num4 = 184 - 61;
						array4[14] = (byte)num4;
						array4[14] = 150;
						array4[14] = 108;
						array4[14] = 161;
						array4[14] = 102;
						array4[15] = 97;
						array4[15] = 19;
						num4 = 172 - 80;
						array4[15] = (byte)num4;
						byte[] array5 = array4;
						object obj = QdMQRTsVkcv9XeBPcG3P();
						mXeuMjsV17F27pOErkrx(obj, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)MhXIeAsV5PE8VmUSb6Wf(obj, array3, array5);
						Stream stream = (Stream)nkpPNIsVSqMORaWRtMNJ();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						zpJqdqsVxpLvdbvMRAnc(cryptoStream, array, 0, array.Length);
						VbeWBEsVLGljCVFrARLU(cryptoStream);
						drlf38sVcCelxsNRIvfu(miosM6vfNJe, Ov6iX1sVXhww2wsBKQ7j(QbO92usVejuyc9wjN7ea(), FXhD5ZsVs8RREOWNnG73(stream)));
						hAhC4TsVjPportEYr6YQ(stream);
						hAhC4TsVjPportEYr6YQ(cryptoStream);
						eL5xLGsVEEC8iSJIsj0P(lo0gPNsO1FdPmLPkq0Hr);
						int num5 = 0;
						if (Ng92lqsVfjqGe8jg5hh5())
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num6 = 0;
						if (!Ng92lqsVfjqGe8jg5hh5())
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								flag = true;
								num6 = 1;
								if (PXxRfMsV9JycIuIwjGNn() != null)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 18;
				case 18:
					if (flag)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 13:
					HrvO3lsVGjJCEZNPJuBu(true);
					num2 = 6;
					continue;
				case 1:
					binaryReader = null;
					num2 = 7;
					continue;
				case 22:
					return;
				case 4:
					goto end_IL_0012;
				case 20:
					break;
				}
				flag = false;
				num2 = 1;
				if (Ng92lqsVfjqGe8jg5hh5())
				{
					num2 = 14;
				}
				continue;
				end_IL_0012:
				break;
			}
			hashAlgorithm = null;
			num = 12;
		}
	}

	public static void HBts6PrtqTi(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (fNesMMB02xC == null)
			{
				lock (A6WsMObRWei)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554447)).Assembly.GetManifestResourceStream("6HVCJXs6gBQd9Vv9B2aE.5PuQALs6RBfotp3QjfQM"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += wXTs63O5eOx(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFF);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						Lo0gPNsO1FdPmLPkq0Hr lo0gPNsO1FdPmLPkq0Hr = new Lo0gPNsO1FdPmLPkq0Hr(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = lo0gPNsO1FdPmLPkq0Hr.MjKsOxP50KB();
							int value = lo0gPNsO1FdPmLPkq0Hr.MjKsOxP50KB();
							dictionary.Add(key, value);
						}
						lo0gPNsO1FdPmLPkq0Hr.KHDsOLUmm9l();
					}
					fNesMMB02xC = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = fNesMMB02xC[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554447)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(16777237));
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint FW6s6Fq81pd(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint wXTs63O5eOx(uint P_0)
	{
		return 0u;
	}

	internal static void Y51s6pVWTN5()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void f6es6utoIXj(Stream P_0, int P_1)
	{
		r7nJI6sq0nyMu16869NI.GTFsqnlcAeS(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string rA7s6znQmFT(int P_0)
	{
		if (F4tsMUsC15o.Length == 0)
		{
			HBZsMWg7JlD = new List<string>();
			QpDsMtd1GaN = new List<int>();
			f6es6utoIXj(sWHsMQluTaT.GetManifestResourceStream("NvsmSCs6xKajBtRDnqFY.Psqh6Cs6LRS6EBpI92yX"), P_0);
		}
		if (iivsMqjQQCo < 75)
		{
			if (sWHsMQluTaT != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			iivsMqjQQCo++;
		}
		lock (X4DsMIawIws)
		{
			int num = BitConverter.ToInt32(F4tsMUsC15o, P_0);
			if (num < QpDsMtd1GaN.Count && QpDsMtd1GaN[num] == P_0)
			{
				return HBZsMWg7JlD[num];
			}
			try
			{
				wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
				byte[] array = new byte[num];
				Array.Copy(F4tsMUsC15o, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				HBZsMWg7JlD.Add(text);
				QpDsMtd1GaN.Add(P_0);
				Array.Copy(BitConverter.GetBytes(HBZsMWg7JlD.Count - 1), 0, F4tsMUsC15o, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string urPsM0US7lV(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int vqcsM2b4b54()
	{
		return 5;
	}

	private static void KeqsMH0cB9X()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate t8osMfIJBCC(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(16777321)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(16777254)),
			Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(16777276))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object kWPsM9aG5HG(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr c5psMn1gu3f(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr CnYsMGupplu(IntPtr P_0, string P_1);

	private static IntPtr p0WsMYqJ18j(IntPtr P_0, string P_1, uint P_2)
	{
		if (infsO0fsACg == null)
		{
			infsO0fsACg = (ODPVTwsOsbfd47ouZX4i)Marshal.GetDelegateForFunctionPointer(CnYsMGupplu(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554456)));
		}
		return infsO0fsACg(P_0, P_1, P_2);
	}

	private static IntPtr s6HsMoMwrjt(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (by7sO21hjeE == null)
		{
			by7sO21hjeE = (QA7WCSsOXZ5ilCjDwnKE)Marshal.GetDelegateForFunctionPointer(CnYsMGupplu(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554457)));
		}
		return by7sO21hjeE(P_0, P_1, P_2, P_3);
	}

	private static int yEIsMv0j4KQ(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (VfssOHPNRwM == null)
		{
			VfssOHPNRwM = (qSD7DysOcjuOprhGxfDL)Marshal.GetDelegateForFunctionPointer(CnYsMGupplu(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554458)));
		}
		return VfssOHPNRwM(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int pkNsMBm414S(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (c0QsOf6FOmj == null)
		{
			c0QsOf6FOmj = (DmbBMmsOjeE1AUAeAQ42)Marshal.GetDelegateForFunctionPointer(CnYsMGupplu(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554459)));
		}
		return c0QsOf6FOmj(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr lhmsMaAl63b(uint P_0, int P_1, uint P_2)
	{
		if (GTDsO9TO5lV == null)
		{
			GTDsO9TO5lV = (vMUruusOEZVppgJCHY17)Marshal.GetDelegateForFunctionPointer(CnYsMGupplu(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554460)));
		}
		return GTDsO9TO5lV(P_0, P_1, P_2);
	}

	private static int SiWsMibpVGh(IntPtr P_0)
	{
		if (Aw3sOnHM7kL == null)
		{
			Aw3sOnHM7kL = (IDfUj4sOQPYlSmeYHRMh)Marshal.GetDelegateForFunctionPointer(CnYsMGupplu(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554461)));
		}
		return Aw3sOnHM7kL(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (XjDsOGDG25F == IntPtr.Zero)
		{
			XjDsOGDG25F = c5psMn1gu3f("kernel ".Trim() + "32.dll");
		}
		return XjDsOGDG25F;
	}

	private static byte[] Rj6sMld5wtk(string P_0)
	{
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream eZ9sM4UHHiJ()
	{
		return new MemoryStream();
	}

	internal static byte[] W58sMD8ymV1(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] bqvsMbXshCI(byte[] P_0)
	{
		Stream stream = eZ9sM4UHHiJ();
		SymmetricAlgorithm symmetricAlgorithm = tNvs6Ku5yIH();
		symmetricAlgorithm.Key = new byte[32]
		{
			33, 170, 147, 136, 29, 238, 207, 254, 245, 238,
			246, 219, 101, 119, 121, 142, 128, 182, 46, 20,
			167, 131, 179, 145, 139, 134, 156, 181, 179, 148,
			82, 54
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			226, 134, 132, 218, 204, 160, 52, 216, 190, 24,
			21, 114, 86, 81, 139, 117
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = W58sMD8ymV1(stream);
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
		return result;
	}

	private unsafe static int JB9sMNRjrAv(string P_0)
	{
		fixed (char* ptr = P_0)
		{
			int num = 5381;
			int num2 = num;
			char* ptr2 = ptr;
			int num3;
			while ((num3 = *ptr2) != 0)
			{
				num = ((num << 5) + num) ^ num3;
				num3 = ptr2[1];
				if (num3 == 0)
				{
					break;
				}
				num2 = ((num2 << 5) + num2) ^ num3;
				ptr2 += 2;
			}
			return num + num2 * 1566083941;
		}
	}

	internal static bool Rp3sMkEw6Qk(string P_0, string P_1)
	{
		if (P_0 == P_1)
		{
			return true;
		}
		if (P_0 == null || P_1 == null)
		{
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		if (P_0.StartsWith(Ur8sOYAIcHd))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(Ur8sOYAIcHd))
		{
			flag2 = true;
			num2 = (int)(P_1[4] | ((uint)P_1[5] << 8) | ((uint)P_1[6] << 16) | ((uint)P_1[7] << 24));
		}
		if (!flag && !flag2)
		{
			return false;
		}
		if (!flag)
		{
			num = JB9sMNRjrAv(P_0);
		}
		if (!flag2)
		{
			num2 = JB9sMNRjrAv(P_1);
		}
		return num == num2;
	}

	private byte[] Op6sM1XI26r()
	{
		return null;
	}

	private byte[] IKGsM5idvTW()
	{
		return null;
	}

	private byte[] phHsMSr9q9g()
	{
		return null;
	}

	private byte[] y61sMx8Dkel()
	{
		return null;
	}

	private byte[] VfTsMLi4oJu()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] ukCsMeQNoPH()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] yltsMsocMmM()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] Qr1sMXVi26Y()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] rJDsMcstUtx()
	{
		return null;
	}

	internal byte[] uR8sMjcwUVb()
	{
		return null;
	}

	internal static object Y31qrYsZrFL1CwILIyiZ(object P_0)
	{
		return ((Lo0gPNsO1FdPmLPkq0Hr)P_0).m9OIO8Q0EK();
	}

	internal static void RGnGtSsZKXZyieABI3c4(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long AFjHZcsZmmWRWyO7WUxO(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object CMoTvRsZhvkXB6hEMQpE(object P_0, int P_1)
	{
		return ((Lo0gPNsO1FdPmLPkq0Hr)P_0).XHIsO5TRG9D(P_1);
	}

	internal static void haOChDsZwcslDpWAG5AP(object P_0)
	{
		((Lo0gPNsO1FdPmLPkq0Hr)P_0).KHDsOLUmm9l();
	}

	internal static void HQ5GNIsZ7gbhhHOrliHN(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object rLIA6gsZ8ShbDP6dyboI(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object UoNUHRsZADZ9M3snM19Q(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object v54RD2sZPuolx180m8gR()
	{
		return tNvs6Ku5yIH();
	}

	internal static void eEj2AasZJg54T6xct0rJ(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object Dj3ZBXsZFHTPA4vOvZOf(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object xMnPdOsZ3fiHKskcgl03()
	{
		return eZ9sM4UHHiJ();
	}

	internal static void flwKEhsZpmJxc0l2AB2W(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void gBJ3G6sZu23rr5NjC2sv(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object j1MP8usZzwnWxCnNXhl3(object P_0)
	{
		return W58sMD8ymV1((Stream)P_0);
	}

	internal static void TKNLVUsV03tCEcpS5foO(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object tDE74XsV2KEYYdFSwyWl(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool wVMajnsVHBsi0ENoxjCw(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool nONCebsZVPU8fvwPYSX7()
	{
		return (object)null == null;
	}

	internal static object JF42oEsZC05MODLpNDbb()
	{
		return null;
	}

	internal static void O8dRgfsVnQg0cuuQjhtK()
	{
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
	}

	internal static void HrvO3lsVGjJCEZNPJuBu(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type qaXMY6sVYelyUlGv2AYJ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object IGvPkQsVohH6QuZJDSs1(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int yZ48NMsVvJbrbBpuB9n8(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object PhKURRsVBvAoKanXAvow()
	{
		return SHA1.Create();
	}

	internal static object zRGXpfsVaw4VZ57bCr8S(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool dYILUbsViQTYqUYasoAM(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object nrLicBsVldr0nONrTqmR(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object EvN1ahsV4DfDyAZQ7xo8(object P_0)
	{
		return ((Lo0gPNsO1FdPmLPkq0Hr)P_0).m9OIO8Q0EK();
	}

	internal static void paHrsUsVDti4LsdHp0of(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long tY3FlIsVbb4MxbOBOSJ8(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object hWM3ZnsVN0Pq1r2i1bHK(object P_0, int P_1)
	{
		return ((Lo0gPNsO1FdPmLPkq0Hr)P_0).XHIsO5TRG9D(P_1);
	}

	internal static object QdMQRTsVkcv9XeBPcG3P()
	{
		return tNvs6Ku5yIH();
	}

	internal static void mXeuMjsV17F27pOErkrx(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object MhXIeAsV5PE8VmUSb6Wf(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object nkpPNIsVSqMORaWRtMNJ()
	{
		return eZ9sM4UHHiJ();
	}

	internal static void zpJqdqsVxpLvdbvMRAnc(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void VbeWBEsVLGljCVFrARLU(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object QbO92usVejuyc9wjN7ea()
	{
		return Encoding.UTF8;
	}

	internal static object FXhD5ZsVs8RREOWNnG73(object P_0)
	{
		return W58sMD8ymV1((Stream)P_0);
	}

	internal static object Ov6iX1sVXhww2wsBKQ7j(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void drlf38sVcCelxsNRIvfu(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void hAhC4TsVjPportEYr6YQ(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void eL5xLGsVEEC8iSJIsj0P(object P_0)
	{
		((Lo0gPNsO1FdPmLPkq0Hr)P_0).KHDsOLUmm9l();
	}

	internal static void zWSYIysVQenRdOWyrYeN(object P_0, object P_1, uint P_2, object P_3)
	{
		pZ2s6woPkhx((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort wwhp99sVd8jgsKLILdro(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int qfocXUsVg5CEsqsb81O8(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void qCm4hWsVR5tbCYpmTorV(object P_0, object P_1, int P_2, int P_3)
	{
		G29s67IGL2i((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long HBw6glsV6pNlju5rFAI3(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint Ij0Ey4sVM14vFj36xMn0(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint IgJbCQsVOsWeGmj9OJo8(uint P_0, int P_1, long P_2, object P_3)
	{
		return CvIs68r0Feb(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long NjloyhsVqFJmCmo2XJtv(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object sOBBTosVIB1WoNxXrqbP(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object LwtPFfsVWxn7iX56sW5r(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void vYppbqsVtPAZKuLbEE4v(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object O6iEqgsVUjnsh4lVnVGK(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool lUg9K7sVTxmncD4m4Jf3(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void ziq54osVyf2CftqUixAF(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object L1bTfUsVZc5ZroMBQujs(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object Foeok2sVVyEILSWFUbms(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object Ode4vAsVClHXDXeBkZB6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool Ng92lqsVfjqGe8jg5hh5()
	{
		return (object)null == null;
	}

	internal static object PXxRfMsV9JycIuIwjGNn()
	{
		return null;
	}
}
