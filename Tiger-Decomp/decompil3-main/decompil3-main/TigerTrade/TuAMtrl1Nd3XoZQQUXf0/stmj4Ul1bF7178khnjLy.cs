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
using ECOEgqlSad8NUJZ2Dr9n;
using JoKBoElSUBwVPr4PkuGe;
using xfdMo0lS4TP9pN36Goka;

namespace TuAMtrl1Nd3XoZQQUXf0;

internal class stmj4Ul1bF7178khnjLy
{
	private delegate void x2kjQcl5KvYK1ND3JnKK(object o);

	internal class k0lxKUl5m8i7RJwWY4C9 : Attribute
	{
		internal class cE6fHFl5hAWRxfF8Rf8I<QkkJX5l5wdWKaUk2gdec>
		{
			internal static object J0W0XaNyO9TSoFHmltuC;

			public cE6fHFl5hAWRxfF8Rf8I()
			{
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				base._002Ector();
			}

			static cE6fHFl5hAWRxfF8Rf8I()
			{
				nWrl1glAtDi();
			}

			internal static bool EhPcXZNyqIhotYvZeSPO()
			{
				return J0W0XaNyO9TSoFHmltuC == null;
			}

			internal static object uFUREmNyIdwEm1voADp5()
			{
				return J0W0XaNyO9TSoFHmltuC;
			}
		}

		public k0lxKUl5m8i7RJwWY4C9(object P_0)
		{
		}
	}

	internal class kYOaHVl57VX8bYjbyPep
	{
		internal static string m3Ol58Dlbv5(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] array = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = nwhl1jvncyU(((Encoding)YhxFbwNyT1NE3oyDOZNU()).GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = lYvl1Xgkjvy();
			FJCYjSNyyEY883L6o4EN(symmetricAlgorithm, array);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)fGqAmpNyZGq1AxOr2N3T(symmetricAlgorithm), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			ujdgmdNyVE0SJFfFH24x(cryptoStream);
			return Convert.ToBase64String((byte[])ATiXxPNyC3ImsxX96D9g(memoryStream));
		}

		internal static object YhxFbwNyT1NE3oyDOZNU()
		{
			return Encoding.Unicode;
		}

		internal static void FJCYjSNyyEY883L6o4EN(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		internal static object fGqAmpNyZGq1AxOr2N3T(object P_0)
		{
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		internal static void ujdgmdNyVE0SJFfFH24x(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object ATiXxPNyC3ImsxX96D9g(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint K4kswOl5AlXvjS06Wl10(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr A9RWHCl5PwjJB3xu9a2s();

	internal struct QhEEjUl5JHVXSDun5Dex
	{
		internal bool UL8l5Fg1Z5k;

		internal byte[] fxnl53TQjek;
	}

	internal class F5CPUNl5pxqM6Zmk7dMj
	{
		private BinaryReader ErllSHZBrpe;

		public F5CPUNl5pxqM6Zmk7dMj(Stream P_0)
		{
			ErllSHZBrpe = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return ErllSHZBrpe.BaseStream;
		}

		internal byte[] TdKl5uhcEnE(int P_0)
		{
			return ErllSHZBrpe.ReadBytes(P_0);
		}

		internal int jQrl5zawLRX(byte[] P_0, int P_1, int P_2)
		{
			return MjGL1cNy8ww2dtJYpEK7(ErllSHZBrpe, P_0, P_1, P_2);
		}

		internal int NsUlS0NutXp()
		{
			return ErllSHZBrpe.ReadInt32();
		}

		internal void IIdlS2OWuFo()
		{
			ErllSHZBrpe.Close();
		}

		internal static int MjGL1cNy8ww2dtJYpEK7(object P_0, object P_1, int P_2, int P_3)
		{
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr B3erc8lSfauluQbIlMxL(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr KjDm58lS905Ccynr87X5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int LMpjljlSnRXawvPAIWOP(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int xXW3XelSGdIMPeQRlTvd(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Rx1TLrlSYPTkCtwm3l68(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int ffdrL1lSoG2o3mg0PRrm(IntPtr ptr);

	[Flags]
	private enum QFHOpclSvTABaRm4qQP1
	{

	}

	private static uint[] K1Cl5vUQW6h;

	private static Dictionary<int, int> IGtl5lxLZ3h;

	private static object YCEl54i3pvD;

	private static List<string> oAbl5Nb7llJ;

	private static int[] K8il5eG7TxB;

	private static long Mgll5Ety5uF;

	private static string WOhl5rv97lE;

	private static LMpjljlSnRXawvPAIWOP apJl5TmUZ5T;

	private static bool r1rl5aW4fyj;

	private static List<int> EmHl5kyy7bc;

	internal static RSACryptoServiceProvider c0ul5ipfmVV;

	private static int t0Zl5s332bj;

	private static bool c6Gl5M5L2q3;

	private static long bI4l5glvieT;

	private static object njyl5LKXpEJ;

	private static IntPtr P9ll5qZjWKN;

	private static byte[] z8Ol55KWlvn;

	private static KjDm58lS905Ccynr87X5 D6Jl5UJ2fwk;

	private static int Sqkl5DqTM8a;

	private static SortedList gfLl5cpNrtZ;

	private static bool HARl5XujFC5;

	private static int QAal5OSdIT9;

	private static B3erc8lSfauluQbIlMxL hhml5tWCOg2;

	[k0lxKUl5m8i7RJwWY4C9(typeof(k0lxKUl5m8i7RJwWY4C9.cE6fHFl5hAWRxfF8Rf8I<object>[]))]
	private static bool OPGl5ISWiLd;

	private static Rx1TLrlSYPTkCtwm3l68 nv3l5Zt6QbT;

	private static IntPtr AIql5CnGNn3;

	private static byte[] f9Ol5176USy;

	internal static K4kswOl5AlXvjS06Wl10 Du3l5Q89yW4;

	private static ffdrL1lSoG2o3mg0PRrm iKSl5VP7h7Q;

	internal static Hashtable H2al5WcL99u;

	internal static K4kswOl5AlXvjS06Wl10 xrxl5d9lGTh;

	private static IntPtr SgVl5xXts3Y;

	private static object u5hl5b42kFi;

	private static int XjPl5Rfgstd;

	private static bool y6ml5Bd79WK;

	private static int Urxl5jvhWf5;

	private static bool Rlpl5Yyt1ym;

	private static xXW3XelSGdIMPeQRlTvd F3Wl5ysJ7Yc;

	private static IntPtr nxol5ShbuZt;

	private static bool Owhl569cEVp;

	internal static Assembly ErSl5oeB0q0;

	static stmj4Ul1bF7178khnjLy()
	{
		Rlpl5Yyt1ym = false;
		ErSl5oeB0q0 = Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556123)).Assembly;
		K1Cl5vUQW6h = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		y6ml5Bd79WK = false;
		r1rl5aW4fyj = false;
		c0ul5ipfmVV = null;
		IGtl5lxLZ3h = null;
		YCEl54i3pvD = new object();
		Sqkl5DqTM8a = 0;
		u5hl5b42kFi = new object();
		oAbl5Nb7llJ = null;
		EmHl5kyy7bc = null;
		f9Ol5176USy = new byte[0];
		z8Ol55KWlvn = new byte[0];
		nxol5ShbuZt = IntPtr.Zero;
		SgVl5xXts3Y = IntPtr.Zero;
		njyl5LKXpEJ = new string[0];
		K8il5eG7TxB = new int[0];
		t0Zl5s332bj = 1;
		HARl5XujFC5 = false;
		gfLl5cpNrtZ = new SortedList();
		Urxl5jvhWf5 = 0;
		Mgll5Ety5uF = 0L;
		Du3l5Q89yW4 = null;
		xrxl5d9lGTh = null;
		bI4l5glvieT = 0L;
		XjPl5Rfgstd = 0;
		Owhl569cEVp = false;
		c6Gl5M5L2q3 = false;
		QAal5OSdIT9 = 0;
		P9ll5qZjWKN = IntPtr.Zero;
		OPGl5ISWiLd = false;
		H2al5WcL99u = new Hashtable();
		hhml5tWCOg2 = null;
		D6Jl5UJ2fwk = null;
		apJl5TmUZ5T = null;
		F3Wl5ysJ7Yc = null;
		nv3l5Zt6QbT = null;
		iKSl5VP7h7Q = null;
		AIql5CnGNn3 = IntPtr.Zero;
		WOhl5rv97lE = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void NRSNhC8wfgp()
	{
	}

	internal static byte[] Gy2l1kuaNnr(byte[] P_0)
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
			x9tl1109VDX(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			x9tl1109VDX(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			x9tl1109VDX(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			x9tl1109VDX(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			x9tl1109VDX(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			x9tl1109VDX(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			x9tl1109VDX(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			x9tl1109VDX(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			x9tl1109VDX(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			x9tl1109VDX(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			x9tl1109VDX(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			x9tl1109VDX(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			x9tl1109VDX(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			x9tl1109VDX(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			x9tl1109VDX(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			x9tl1109VDX(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			O93l155mk4W(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			O93l155mk4W(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			O93l155mk4W(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			O93l155mk4W(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			O93l155mk4W(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			O93l155mk4W(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			O93l155mk4W(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			O93l155mk4W(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			O93l155mk4W(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			O93l155mk4W(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			O93l155mk4W(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			O93l155mk4W(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			O93l155mk4W(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			O93l155mk4W(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			O93l155mk4W(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			O93l155mk4W(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			V9ml1S5ZAad(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			V9ml1S5ZAad(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			V9ml1S5ZAad(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			V9ml1S5ZAad(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			V9ml1S5ZAad(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			V9ml1S5ZAad(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			V9ml1S5ZAad(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			V9ml1S5ZAad(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			V9ml1S5ZAad(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			V9ml1S5ZAad(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			V9ml1S5ZAad(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			V9ml1S5ZAad(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			V9ml1S5ZAad(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			V9ml1S5ZAad(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			V9ml1S5ZAad(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			V9ml1S5ZAad(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			EB0l1xZlgiS(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			EB0l1xZlgiS(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			EB0l1xZlgiS(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			EB0l1xZlgiS(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			EB0l1xZlgiS(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			EB0l1xZlgiS(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			EB0l1xZlgiS(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			EB0l1xZlgiS(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			EB0l1xZlgiS(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			EB0l1xZlgiS(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			EB0l1xZlgiS(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			EB0l1xZlgiS(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			EB0l1xZlgiS(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			EB0l1xZlgiS(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			EB0l1xZlgiS(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			EB0l1xZlgiS(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void x9tl1109VDX(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + yu7l1LeAemV(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + K1Cl5vUQW6h[P_6 - 1], P_5);
	}

	private static void O93l155mk4W(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + yu7l1LeAemV(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + K1Cl5vUQW6h[P_6 - 1], P_5);
	}

	private static void V9ml1S5ZAad(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + yu7l1LeAemV(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + K1Cl5vUQW6h[P_6 - 1], P_5);
	}

	private static void EB0l1xZlgiS(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + yu7l1LeAemV(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + K1Cl5vUQW6h[P_6 - 1], P_5);
	}

	private static uint yu7l1LeAemV(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool vRYl1eXe91G()
	{
		if (!y6ml5Bd79WK)
		{
			pU5l1cPpANU();
			y6ml5Bd79WK = true;
		}
		return r1rl5aW4fyj;
	}

	internal stmj4Ul1bF7178khnjLy()
	{
	}

	private void Y9ll1st55WJ(byte[] P_0, byte[] P_1, byte[] P_2)
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
		f9Ol5176USy = array;
	}

	internal static SymmetricAlgorithm lYvl1Xgkjvy()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (vRYl1eXe91G())
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

	internal static void pU5l1cPpANU()
	{
		try
		{
			r1rl5aW4fyj = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] nwhl1jvncyU(byte[] P_0)
	{
		if (!vRYl1eXe91G())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return Gy2l1kuaNnr(P_0);
	}

	internal static void kKrl1EFUQWc(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			FM2l1QLmO9U(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void FM2l1QLmO9U(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint cu6l1dpkR0L(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void nWrl1glAtDi()
	{
		int num = 9;
		bool flag = default(bool);
		string text2 = default(string);
		string text = default(string);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		BinaryReader binaryReader = default(BinaryReader);
		uint num10 = default(uint);
		uint num17 = default(uint);
		long num18 = default(long);
		int num7 = default(int);
		long num6 = default(long);
		byte[] array2 = default(byte[]);
		long num12 = default(long);
		long num11 = default(long);
		int num15 = default(int);
		uint num19 = default(uint);
		uint num9 = default(uint);
		uint num13 = default(uint);
		byte[] array = default(byte[]);
		uint num20 = default(uint);
		long num8 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 15:
				case 18:
					if (!flag)
					{
						num2 = 5;
						break;
					}
					goto case 19;
				case 20:
					text2 = null;
					num2 = 4;
					break;
				case 7:
					c0ul5ipfmVV = new RSACryptoServiceProvider();
					num2 = 3;
					break;
				case 16:
					if (ohvQqslOPWc3THcSnQT7(text) == 0)
					{
						num2 = 1;
						if (UVoxnYlOhpyIgIR4DnhD() == null)
						{
							num2 = 1;
						}
					}
					else
					{
						hashAlgorithm = null;
						num2 = 20;
					}
					break;
				case 1:
					return;
				case 2:
					return;
				case 23:
					pdUDk7lO7nAZfewxmAEr(true);
					num2 = 3;
					if (lTLPYIlOmZe0anALXu7Y())
					{
						num2 = 7;
					}
					break;
				case 6:
					try
					{
						F5CPUNl5pxqM6Zmk7dMj f5CPUNl5pxqM6Zmk7dMj = new F5CPUNl5pxqM6Zmk7dMj((Stream)umORmilOpjG4gFipgirf(ErSl5oeB0q0, "qK3FP8lvZ7TTkU6yBQW4.6eUw5UlvVKZETsWEgZwH"));
						lXC6S2lOzOHWXZgeV65F(oPIBA2lOuk487WtrpwQS(f5CPUNl5pxqM6Zmk7dMj), 0L);
						byte[] array3 = (byte[])c5ttWTlq2MCpunlwy9eo(f5CPUNl5pxqM6Zmk7dMj, (int)sRadS2lq0RInRfEilL5m(oPIBA2lOuk487WtrpwQS(f5CPUNl5pxqM6Zmk7dMj)));
						byte[] array4 = new byte[32];
						int num27 = 21 + 81;
						array4[0] = (byte)num27;
						array4[0] = 194;
						array4[0] = 114;
						array4[0] = 136;
						array4[0] = 147;
						num27 = 200 - 115;
						array4[0] = (byte)num27;
						array4[1] = 65;
						array4[1] = 139;
						num27 = 218 - 72;
						array4[1] = (byte)num27;
						num27 = 29 + 74;
						array4[1] = (byte)num27;
						array4[1] = 162;
						num27 = 232 + 11;
						array4[1] = (byte)num27;
						array4[2] = 154;
						array4[2] = 162;
						array4[2] = 149;
						array4[2] = 148;
						array4[2] = 108;
						array4[3] = 155;
						num27 = 64 + 16;
						array4[3] = (byte)num27;
						array4[3] = 171;
						array4[3] = 169;
						num27 = 164 + 5;
						array4[3] = (byte)num27;
						array4[4] = 206;
						array4[4] = 176;
						array4[4] = 116;
						num27 = 98 + 88;
						array4[5] = (byte)num27;
						num27 = 216 - 72;
						array4[5] = (byte)num27;
						array4[5] = 110;
						array4[5] = 117;
						num27 = 164 + 65;
						array4[5] = (byte)num27;
						array4[6] = 132;
						num27 = 251 - 83;
						array4[6] = (byte)num27;
						array4[6] = 182;
						array4[6] = 97;
						array4[6] = 225;
						num27 = 13 + 118;
						array4[7] = (byte)num27;
						array4[7] = 104;
						num27 = 227 - 75;
						array4[7] = (byte)num27;
						array4[7] = 149;
						num27 = 161 + 5;
						array4[7] = (byte)num27;
						array4[8] = 219;
						array4[8] = 69;
						array4[8] = 184;
						num27 = 165 - 55;
						array4[9] = (byte)num27;
						array4[9] = 143;
						array4[9] = 60;
						num27 = 147 - 49;
						array4[10] = (byte)num27;
						array4[10] = 136;
						array4[10] = 244;
						array4[11] = 84;
						array4[11] = 132;
						array4[11] = 151;
						array4[11] = 190;
						num27 = 114 + 14;
						array4[12] = (byte)num27;
						num27 = 59 + 52;
						array4[12] = (byte)num27;
						num27 = 15 + 100;
						array4[12] = (byte)num27;
						num27 = 147 + 54;
						array4[12] = (byte)num27;
						num27 = 63 + 105;
						array4[13] = (byte)num27;
						array4[13] = 132;
						num27 = 140 - 51;
						array4[13] = (byte)num27;
						array4[14] = 77;
						num27 = 5 + 47;
						array4[14] = (byte)num27;
						num27 = 132 - 44;
						array4[14] = (byte)num27;
						array4[14] = 101;
						array4[14] = 117;
						array4[15] = 162;
						num27 = 232 - 77;
						array4[15] = (byte)num27;
						array4[15] = 154;
						array4[15] = 178;
						num27 = 69 + 83;
						array4[15] = (byte)num27;
						array4[15] = 177;
						num27 = 199 - 66;
						array4[16] = (byte)num27;
						num27 = 154 - 51;
						array4[16] = (byte)num27;
						array4[16] = 106;
						array4[16] = 106;
						num27 = 55 - 9;
						array4[16] = (byte)num27;
						array4[17] = 195;
						array4[17] = 223;
						array4[17] = 84;
						num27 = 100 + 118;
						array4[17] = (byte)num27;
						array4[18] = 120;
						num27 = 153 - 51;
						array4[18] = (byte)num27;
						num27 = 27 + 6;
						array4[18] = (byte)num27;
						array4[18] = 110;
						array4[18] = 0;
						num27 = 236 - 78;
						array4[19] = (byte)num27;
						num27 = 86 + 24;
						array4[19] = (byte)num27;
						num27 = 233 - 77;
						array4[19] = (byte)num27;
						num27 = 211 - 70;
						array4[19] = (byte)num27;
						num27 = 154 + 50;
						array4[19] = (byte)num27;
						num27 = 175 - 58;
						array4[20] = (byte)num27;
						array4[20] = 215;
						array4[20] = 28;
						num27 = 175 - 58;
						array4[20] = (byte)num27;
						num27 = 120 - 98;
						array4[20] = (byte)num27;
						array4[21] = 133;
						array4[21] = 166;
						num27 = 154 - 51;
						array4[21] = (byte)num27;
						array4[21] = 98;
						array4[21] = 55;
						array4[22] = 187;
						array4[22] = 110;
						array4[22] = 133;
						num27 = 112 + 87;
						array4[22] = (byte)num27;
						array4[23] = 152;
						num27 = 234 - 78;
						array4[23] = (byte)num27;
						array4[23] = 27;
						array4[24] = 132;
						num27 = 245 - 81;
						array4[24] = (byte)num27;
						num27 = 118 + 113;
						array4[24] = (byte)num27;
						array4[24] = 151;
						array4[24] = 32;
						array4[25] = 225;
						num27 = 193 - 64;
						array4[25] = (byte)num27;
						num27 = 23 + 22;
						array4[25] = (byte)num27;
						array4[25] = 212;
						array4[26] = 88;
						array4[26] = 71;
						num27 = 167 - 55;
						array4[26] = (byte)num27;
						num27 = 141 + 103;
						array4[26] = (byte)num27;
						num27 = 226 - 75;
						array4[27] = (byte)num27;
						array4[27] = 156;
						array4[27] = 106;
						array4[27] = 102;
						array4[28] = 148;
						array4[28] = 164;
						num27 = 218 - 72;
						array4[28] = (byte)num27;
						array4[28] = 243;
						array4[29] = 200;
						num27 = 173 - 57;
						array4[29] = (byte)num27;
						array4[29] = 9;
						array4[29] = 140;
						num27 = 66 + 111;
						array4[30] = (byte)num27;
						array4[30] = 100;
						num27 = 157 - 55;
						array4[30] = (byte)num27;
						num27 = 184 - 61;
						array4[31] = (byte)num27;
						array4[31] = 132;
						num27 = 24 + 76;
						array4[31] = (byte)num27;
						num27 = 228 - 76;
						array4[31] = (byte)num27;
						array4[31] = 129;
						byte[] array5 = array4;
						byte[] array6 = new byte[16];
						int num28 = 147 - 49;
						array6[0] = (byte)num28;
						array6[0] = 128;
						num28 = 167 + 49;
						array6[0] = (byte)num28;
						array6[1] = 146;
						num28 = 75 + 11;
						array6[1] = (byte)num28;
						array6[1] = 164;
						num28 = 115 + 30;
						array6[1] = (byte)num28;
						num28 = 71 - 46;
						array6[1] = (byte)num28;
						num28 = 198 - 66;
						array6[2] = (byte)num28;
						num28 = 190 - 63;
						array6[2] = (byte)num28;
						num28 = 51 + 29;
						array6[2] = (byte)num28;
						array6[2] = 133;
						array6[2] = 16;
						array6[2] = 127;
						array6[3] = 114;
						array6[3] = 212;
						num28 = 153 - 51;
						array6[3] = (byte)num28;
						num28 = 68 + 45;
						array6[3] = (byte)num28;
						array6[3] = 117;
						array6[3] = 181;
						array6[4] = 24;
						num28 = 236 - 78;
						array6[4] = (byte)num28;
						array6[4] = 168;
						array6[4] = 189;
						num28 = 144 - 40;
						array6[4] = (byte)num28;
						array6[5] = 134;
						array6[5] = 192;
						array6[5] = 160;
						num28 = 87 + 78;
						array6[6] = (byte)num28;
						array6[6] = 59;
						array6[6] = 129;
						num28 = 92 + 70;
						array6[6] = (byte)num28;
						num28 = 251 - 83;
						array6[7] = (byte)num28;
						array6[7] = 146;
						array6[7] = 133;
						num28 = 149 + 5;
						array6[7] = (byte)num28;
						num28 = 13 + 118;
						array6[8] = (byte)num28;
						array6[8] = 155;
						num28 = 93 + 98;
						array6[8] = (byte)num28;
						num28 = 94 + 7;
						array6[8] = (byte)num28;
						array6[8] = 221;
						num28 = 109 + 110;
						array6[9] = (byte)num28;
						array6[9] = 102;
						array6[9] = 252;
						num28 = 117 + 38;
						array6[10] = (byte)num28;
						num28 = 220 - 73;
						array6[10] = (byte)num28;
						num28 = 225 - 75;
						array6[10] = (byte)num28;
						num28 = 62 - 21;
						array6[10] = (byte)num28;
						num28 = 75 + 111;
						array6[11] = (byte)num28;
						array6[11] = 91;
						num28 = 242 - 80;
						array6[11] = (byte)num28;
						num28 = 96 + 53;
						array6[11] = (byte)num28;
						num28 = 157 + 80;
						array6[11] = (byte)num28;
						num28 = 114 + 14;
						array6[12] = (byte)num28;
						num28 = 59 + 52;
						array6[12] = (byte)num28;
						num28 = 111 - 15;
						array6[12] = (byte)num28;
						array6[13] = 132;
						array6[13] = 169;
						array6[13] = 118;
						array6[14] = 96;
						array6[14] = 170;
						array6[14] = 90;
						num28 = 155 + 43;
						array6[14] = (byte)num28;
						array6[15] = 88;
						array6[15] = 71;
						array6[15] = 31;
						byte[] array7 = array6;
						object obj4 = bUFtmulqHrnss8AuFhL2();
						V1JfdtlqfoCr4SAf2ECl(obj4, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)HBy1PGlq98f3NQNXDhsS(obj4, array5, array7);
						Stream stream = (Stream)t086M7lqn6X0aExUXrLn();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						aaEohAlqG8dyNjFa5Tkr(cryptoStream, array3, 0, array3.Length);
						vBaQGjlqYU2k0EUscvp3(cryptoStream);
						MDIsPTlqawxhirCf95KU(c0ul5ipfmVV, XLUaltlqBSCg8p2dIKOw(JAvmlvlqoAQahRYYVQNJ(), HFRFUilqvSZmfVtKYFJI(stream)));
						RSoZH5lqiUcv8KJgjI2a(stream);
						RSoZH5lqiUcv8KJgjI2a(cryptoStream);
						KRmM7wlqlSRgSNtLyxmu(f5CPUNl5pxqM6Zmk7dMj);
						int num29 = 0;
						if (!lTLPYIlOmZe0anALXu7Y())
						{
							num29 = 0;
						}
						switch (num29)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num30 = 0;
						if (UVoxnYlOhpyIgIR4DnhD() == null)
						{
							num30 = 0;
						}
						while (true)
						{
							switch (num30)
							{
							default:
								flag = true;
								num30 = 0;
								if (UVoxnYlOhpyIgIR4DnhD() == null)
								{
									num30 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 10;
				case 12:
					if (text == null)
					{
						num2 = 2;
						break;
					}
					goto case 16;
				case 4:
					try
					{
						hashAlgorithm = (HashAlgorithm)RKlS4ylOJXu5BBFqf0Eb();
						int num24 = 3;
						while (true)
						{
							switch (num24)
							{
							case 1:
								return;
							case 3:
								text2 = (string)a9o02NlOFkJpHBpBjcPe("SHA1");
								num24 = 2;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num24 = 1;
								}
								continue;
							case 4:
								break;
							case 2:
								if (hi2q2wlO3ict9gxn3jtL(text))
								{
									int num25 = 4;
									num24 = num25;
									continue;
								}
								return;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num26 = 0;
						if (UVoxnYlOhpyIgIR4DnhD() == null)
						{
							num26 = 0;
						}
						switch (num26)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 14;
				case 11:
					try
					{
						if (binaryReader != null)
						{
							int num22 = 0;
							if (!lTLPYIlOmZe0anALXu7Y())
							{
								num22 = 0;
							}
							while (true)
							{
								switch (num22)
								{
								default:
									hKqqO4lqcaRKcpvrA4m5(binaryReader);
									num22 = 1;
									if (UVoxnYlOhpyIgIR4DnhD() != null)
									{
										num22 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					catch
					{
						int num23 = 0;
						if (lTLPYIlOmZe0anALXu7Y())
						{
							num23 = 0;
						}
						switch (num23)
						{
						case 0:
							break;
						}
					}
					goto case 15;
				case 14:
					flag = false;
					num2 = 2;
					if (UVoxnYlOhpyIgIR4DnhD() == null)
					{
						num2 = 6;
					}
					break;
				case 21:
					EHanVvlOwPijcIlBbF55();
					num2 = 23;
					break;
				case 22:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num3 = 0;
						if (UVoxnYlOhpyIgIR4DnhD() == null)
						{
							num3 = 0;
						}
						while (true)
						{
							int num14;
							switch (num3)
							{
							case 15:
								num10 = ExF2mrlq1MKmaHTwIo6F(binaryReader);
								num3 = 32;
								continue;
							case 34:
							{
								uint num16 = ExF2mrlq1MKmaHTwIo6F(binaryReader);
								num17 = ExF2mrlq1MKmaHTwIo6F(binaryReader);
								num18 = dIfY6Xlq5CJ1DFMmMCWq(num16, num7, num6, binaryReader);
								num3 = 0;
								if (UVoxnYlOhpyIgIR4DnhD() == null)
								{
									num3 = 1;
								}
								continue;
							}
							case 11:
								lXC6S2lOzOHWXZgeV65F(fileStream, num18);
								num3 = 16;
								if (!lTLPYIlOmZe0anALXu7Y())
								{
									num3 = 0;
								}
								continue;
							case 27:
								flag = !dCnjgDlqXq2IDydBvJqD(c0ul5ipfmVV, vH1E3MlqsvL9G327kQMg(hashAlgorithm), text2, array2);
								num14 = 26;
								goto IL_1835;
							case 39:
								if (num12 >= num11)
								{
									num3 = 14;
									if (UVoxnYlOhpyIgIR4DnhD() != null)
									{
										num3 = 13;
									}
									continue;
								}
								goto case 33;
							case 17:
							case 35:
								if (num15 >= num7)
								{
									num14 = 18;
									goto IL_1835;
								}
								goto case 36;
							case 22:
								lXC6S2lOzOHWXZgeV65F(fileStream, num19 + 32);
								num3 = 34;
								continue;
							case 12:
							case 38:
							case 42:
								if (num10 == 0)
								{
									num3 = 31;
									continue;
								}
								goto case 8;
							case 36:
								lXC6S2lOzOHWXZgeV65F(fileStream, num6 + num15 * 40 + 16);
								num14 = 15;
								goto IL_1835;
							case 40:
								if (num9 < num10)
								{
									num3 = 20;
									continue;
								}
								goto case 3;
							case 21:
								nonICElq4g7OQVqUbOgm(hashAlgorithm, fileStream, num13, array);
								num14 = 19;
								goto IL_1835;
							case 7:
								num15 = 0;
								num3 = 35;
								continue;
							case 25:
								if (num18 <= num12)
								{
									num3 = 39;
									continue;
								}
								goto case 10;
							case 8:
								num12 = j0ytkilqkrKk6PlOBpoA(fileStream);
								num3 = 25;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num3 = 2;
								}
								continue;
							case 9:
							case 28:
								num19 = dIfY6Xlq5CJ1DFMmMCWq(ExF2mrlq1MKmaHTwIo6F(binaryReader), num7, num6, binaryReader);
								num3 = 22;
								continue;
							case 16:
								array2 = (byte[])rJcoHrlqLK5rKLdsGo1X(binaryReader, (int)num17);
								num3 = 13;
								continue;
							case 4:
								nonICElq4g7OQVqUbOgm(hashAlgorithm, fileStream, 152u, array);
								num3 = 43;
								continue;
							case 32:
								num20 = ExF2mrlq1MKmaHTwIo6F(binaryReader);
								num3 = 41;
								if (!lTLPYIlOmZe0anALXu7Y())
								{
									num3 = 36;
								}
								continue;
							case 3:
							case 31:
								num15++;
								num14 = 17;
								goto IL_1835;
							case 33:
								num9 = (uint)(num11 - num12);
								num3 = 40;
								if (!lTLPYIlOmZe0anALXu7Y())
								{
									num3 = 28;
								}
								continue;
							case 19:
								num10 -= num13;
								num3 = 12;
								continue;
							case 5:
								array = new byte[65536];
								num3 = 3;
								if (UVoxnYlOhpyIgIR4DnhD() == null)
								{
									num3 = 4;
								}
								continue;
							case 30:
								lXC6S2lOzOHWXZgeV65F(fileStream, num8);
								num3 = 7;
								continue;
							case 10:
							case 14:
								if (num12 >= num11)
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							case 13:
								spJtbslqeJ5kykWsO7fS(array2);
								num3 = 27;
								continue;
							case 6:
								num13 = (uint)qgTG6WlqSDI4CLit06GS(num18 - num12, num10);
								num3 = 21;
								continue;
							case 41:
								lXC6S2lOzOHWXZgeV65F(fileStream, num20);
								num3 = 42;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num3 = 16;
								}
								continue;
							case 1:
								num11 = num18 + num17;
								num3 = 30;
								continue;
							case 23:
								lXC6S2lOzOHWXZgeV65F(fileStream, j0ytkilqkrKk6PlOBpoA(fileStream) + num9);
								num3 = 38;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num3 = 27;
								}
								continue;
							case 20:
								num10 -= num9;
								num3 = 23;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num3 = 2;
								}
								continue;
							case 2:
								nonICElq4g7OQVqUbOgm(hashAlgorithm, fileStream, num10, array);
								num3 = 2;
								if (lTLPYIlOmZe0anALXu7Y())
								{
									num3 = 3;
								}
								continue;
							case 18:
								fMBdDwlqx3H3xdLAW9OQ(hashAlgorithm, new byte[0], 0, 0);
								num3 = 11;
								continue;
							case 29:
								lXC6S2lOzOHWXZgeV65F(fileStream, 360L);
								num3 = 9;
								continue;
							case 24:
							case 37:
								lXC6S2lOzOHWXZgeV65F(fileStream, 376L);
								num3 = 28;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num3 = 21;
								}
								continue;
							default:
								binaryReader = new BinaryReader(fileStream);
								num3 = 5;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num3 = 5;
								}
								continue;
							case 43:
							{
								bool num4 = L8fc8SlqDabOu3VUBQWY(binaryReader) != 523;
								int num5 = (num4 ? 96 : 112);
								lXC6S2lOzOHWXZgeV65F(fileStream, 152L);
								JK3Uc6lqbxVks7idD63G(fileStream, array, 0, num5);
								array[64] = 0;
								array[65] = 0;
								array[66] = 0;
								array[67] = 0;
								ABbkB4lqNysd3YD1p6QM(hashAlgorithm, array, 0, num5);
								JK3Uc6lqbxVks7idD63G(fileStream, array, 0, 128);
								array[32] = 0;
								array[33] = 0;
								array[34] = 0;
								array[35] = 0;
								array[36] = 0;
								array[37] = 0;
								array[38] = 0;
								array[39] = 0;
								ABbkB4lqNysd3YD1p6QM(hashAlgorithm, array, 0, 128);
								num6 = j0ytkilqkrKk6PlOBpoA(fileStream);
								lXC6S2lOzOHWXZgeV65F(fileStream, 134L);
								num7 = L8fc8SlqDabOu3VUBQWY(binaryReader);
								lXC6S2lOzOHWXZgeV65F(fileStream, num6);
								nonICElq4g7OQVqUbOgm(hashAlgorithm, fileStream, (uint)(num7 * 40), array);
								num8 = j0ytkilqkrKk6PlOBpoA(fileStream);
								if (!num4)
								{
									num3 = 24;
									if (lTLPYIlOmZe0anALXu7Y())
									{
										num3 = 37;
									}
									continue;
								}
								goto case 29;
							}
							case 26:
								break;
								IL_1835:
								num3 = num14;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num21 = 1;
						if (UVoxnYlOhpyIgIR4DnhD() == null)
						{
							num21 = 1;
						}
						while (true)
						{
							switch (num21)
							{
							case 1:
								flag = true;
								num21 = 0;
								if (UVoxnYlOhpyIgIR4DnhD() != null)
								{
									num21 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 17;
				case 9:
					if (c0ul5ipfmVV != null)
					{
						num2 = 0;
						if (UVoxnYlOhpyIgIR4DnhD() == null)
						{
							num2 = 8;
						}
						break;
					}
					goto case 21;
				case 10:
					if (flag)
					{
						goto end_IL_0012;
					}
					goto case 13;
				case 3:
					text = (string)usKcQ1lOARRlPlkHobnP(pxPKcolO8NmG1FmBydPs(typeof(stmj4Ul1bF7178khnjLy).TypeHandle).Assembly);
					num2 = 12;
					break;
				case 13:
					binaryReader = null;
					num2 = 22;
					if (!lTLPYIlOmZe0anALXu7Y())
					{
						num2 = 8;
					}
					break;
				case 0:
					return;
				case 8:
					return;
				case 17:
					num2 = 11;
					if (!lTLPYIlOmZe0anALXu7Y())
					{
						num2 = 0;
					}
					break;
				case 19:
					throw new Exception((string)s1wPVTlqQb8D9TAyPvMS(UBpZg7lqEHe9OvqFUpuB(FgwavVlqjcxuxG9EAtps(pxPKcolO8NmG1FmBydPs(typeof(stmj4Ul1bF7178khnjLy).TypeHandle).Assembly)), " is tampered."));
				case 5:
					flag = false;
					num2 = 0;
					if (UVoxnYlOhpyIgIR4DnhD() == null)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	public static void Xqxl1RiccIC(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (IGtl5lxLZ3h == null)
			{
				lock (YCEl54i3pvD)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556123)).Assembly.GetManifestResourceStream("Za9rTwlvho25VBDHYHUX.S3VABvlvwU66mTAngkBY"));
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
							num3 += ulFl1OFCvGF(num3);
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
						F5CPUNl5pxqM6Zmk7dMj f5CPUNl5pxqM6Zmk7dMj = new F5CPUNl5pxqM6Zmk7dMj(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = f5CPUNl5pxqM6Zmk7dMj.NsUlS0NutXp();
							int value = f5CPUNl5pxqM6Zmk7dMj.NsUlS0NutXp();
							dictionary.Add(key, value);
						}
						f5CPUNl5pxqM6Zmk7dMj.IIdlS2OWuFo();
					}
					IGtl5lxLZ3h = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = IGtl5lxLZ3h[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556123)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240));
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

	private static uint KN6l1M7InSV(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint ulFl1OFCvGF(uint P_0)
	{
		return 0u;
	}

	internal static void Hqpl1q9a4xD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void llel1ISRNHI(Stream P_0, int P_1)
	{
		FEyTCPlStyZXoF8uKFOP.BcBlSVT9FuL(47, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string BC1l1WXFcAt(int P_0)
	{
		if (f9Ol5176USy.Length == 0)
		{
			oAbl5Nb7llJ = new List<string>();
			EmHl5kyy7bc = new List<int>();
			llel1ISRNHI(ErSl5oeB0q0.GetManifestResourceStream("yAkOEslvt5ZKVxCYy0yj.YrIdAslvUF16pq15n2ZR"), P_0);
		}
		if (Sqkl5DqTM8a < 75)
		{
			if (ErSl5oeB0q0 != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			Sqkl5DqTM8a++;
		}
		lock (u5hl5b42kFi)
		{
			int num = BitConverter.ToInt32(f9Ol5176USy, P_0);
			if (num < EmHl5kyy7bc.Count && EmHl5kyy7bc[num] == P_0)
			{
				return oAbl5Nb7llJ[num];
			}
			try
			{
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				byte[] array = new byte[num];
				Array.Copy(f9Ol5176USy, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				oAbl5Nb7llJ.Add(text);
				EmHl5kyy7bc.Add(P_0);
				Array.Copy(BitConverter.GetBytes(oAbl5Nb7llJ.Count - 1), 0, f9Ol5176USy, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string Cnql1tCgZSs(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Lwnl1UfiQEr()
	{
		return 5;
	}

	private static void huyl1T3WNaE()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate w7xl1yjo6kd(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16778051)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777329)),
			Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777302))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object Tksl1ZZQSPZ(object P_0)
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
	public static extern IntPtr t2nl1VuB0hb(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr lU9l1CheBb2(IntPtr P_0, string P_1);

	private static IntPtr iMbl1rsC6mp(IntPtr P_0, string P_1, uint P_2)
	{
		if (hhml5tWCOg2 == null)
		{
			hhml5tWCOg2 = (B3erc8lSfauluQbIlMxL)Marshal.GetDelegateForFunctionPointer(lU9l1CheBb2(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556132)));
		}
		return hhml5tWCOg2(P_0, P_1, P_2);
	}

	private static IntPtr zLdl1K8nLPo(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (D6Jl5UJ2fwk == null)
		{
			D6Jl5UJ2fwk = (KjDm58lS905Ccynr87X5)Marshal.GetDelegateForFunctionPointer(lU9l1CheBb2(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556133)));
		}
		return D6Jl5UJ2fwk(P_0, P_1, P_2, P_3);
	}

	private static int Y7Ql1mTobXy(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (apJl5TmUZ5T == null)
		{
			apJl5TmUZ5T = (LMpjljlSnRXawvPAIWOP)Marshal.GetDelegateForFunctionPointer(lU9l1CheBb2(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556134)));
		}
		return apJl5TmUZ5T(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int Qwvl1hFIpqq(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (F3Wl5ysJ7Yc == null)
		{
			F3Wl5ysJ7Yc = (xXW3XelSGdIMPeQRlTvd)Marshal.GetDelegateForFunctionPointer(lU9l1CheBb2(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556135)));
		}
		return F3Wl5ysJ7Yc(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr D6Jl1wo9Khj(uint P_0, int P_1, uint P_2)
	{
		if (nv3l5Zt6QbT == null)
		{
			nv3l5Zt6QbT = (Rx1TLrlSYPTkCtwm3l68)Marshal.GetDelegateForFunctionPointer(lU9l1CheBb2(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556136)));
		}
		return nv3l5Zt6QbT(P_0, P_1, P_2);
	}

	private static int xB0l17pmAjb(IntPtr P_0)
	{
		if (iKSl5VP7h7Q == null)
		{
			iKSl5VP7h7Q = (ffdrL1lSoG2o3mg0PRrm)Marshal.GetDelegateForFunctionPointer(lU9l1CheBb2(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556137)));
		}
		return iKSl5VP7h7Q(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (AIql5CnGNn3 == IntPtr.Zero)
		{
			AIql5CnGNn3 = t2nl1VuB0hb("kernel ".Trim() + "32.dll");
		}
		return AIql5CnGNn3;
	}

	private static byte[] EtZl18I0hiV(string P_0)
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

	internal static Stream LTjl1AXFoAm()
	{
		return new MemoryStream();
	}

	internal static byte[] gGMl1P6DnGZ(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] us8l1JlrFRA(byte[] P_0)
	{
		Stream stream = LTjl1AXFoAm();
		SymmetricAlgorithm symmetricAlgorithm = lYvl1Xgkjvy();
		symmetricAlgorithm.Key = new byte[32]
		{
			139, 65, 81, 178, 76, 53, 203, 43, 246, 99,
			176, 130, 84, 99, 155, 174, 16, 247, 70, 76,
			205, 143, 191, 158, 38, 133, 78, 147, 122, 121,
			52, 153
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			234, 245, 163, 46, 65, 76, 205, 237, 252, 189,
			218, 17, 34, 58, 238, 53
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = gGMl1P6DnGZ(stream);
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		return result;
	}

	private unsafe static int l7Fl1FqA9Ec(string P_0)
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

	internal static bool oAZl13jUKcI(string P_0, string P_1)
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
		if (P_0.StartsWith(WOhl5rv97lE))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(WOhl5rv97lE))
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
			num = l7Fl1FqA9Ec(P_0);
		}
		if (!flag2)
		{
			num2 = l7Fl1FqA9Ec(P_1);
		}
		return num == num2;
	}

	private byte[] HAWl1pokHiR()
	{
		return null;
	}

	private byte[] og4l1uwuvi6()
	{
		return null;
	}

	private byte[] FqUl1zN385b()
	{
		return null;
	}

	private byte[] cYAl50G9uE6()
	{
		return null;
	}

	private byte[] iGYl52CF0Rt()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] wJal5HZN0gc()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] uBsl5frCPyW()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] Xahl59jtRXw()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] p7ll5nVy6Jj()
	{
		return null;
	}

	internal byte[] sXUl5G1oiuj()
	{
		return null;
	}

	internal static object L3J5QQlOdejcGX0xJ7fl(object P_0)
	{
		return ((F5CPUNl5pxqM6Zmk7dMj)P_0).m9OIO8Q0EK();
	}

	internal static void qQBga6lOgKZiFFG80pm1(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long JcwHoVlORxuC8oTkdw66(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object lUBgoelO6oPStJWXJuU9(object P_0, int P_1)
	{
		return ((F5CPUNl5pxqM6Zmk7dMj)P_0).TdKl5uhcEnE(P_1);
	}

	internal static void YuQhCclOMNUaGwbjNFsm(object P_0)
	{
		((F5CPUNl5pxqM6Zmk7dMj)P_0).IIdlS2OWuFo();
	}

	internal static void DcKx58lOOf3Q2q0FLhZS(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object Sa7V3ClOqs2WTAlOjtSP(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object UykZGolOIbr8ZJeMMHiS(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object S1sLx6lOWXgMKhtBaxGI()
	{
		return lYvl1Xgkjvy();
	}

	internal static void jlyVeAlOtMPhQB1oaWHE(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object UMCSJrlOUqfZVZjxCVXv(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object MkX1bBlOTlkfyvH5848i()
	{
		return LTjl1AXFoAm();
	}

	internal static void DmHh3FlOylIPZbTrcTEA(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void UsltKvlOZtNF1f8IpALq(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object jquibolOVfRT7K2Z1aEg(object P_0)
	{
		return gGMl1P6DnGZ((Stream)P_0);
	}

	internal static void TF1j4WlOC9iMdNZuFEay(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object FB5iMUlOrpqiPvub3xZt(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool E3wnLglOKMgFvZPk1Ov5(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool J8ajDLlOE43AogbX3peF()
	{
		return (object)null == null;
	}

	internal static object LacEQNlOQ7Rcnryk6kBd()
	{
		return null;
	}

	internal static void EHanVvlOwPijcIlBbF55()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void pdUDk7lO7nAZfewxmAEr(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type pxPKcolO8NmG1FmBydPs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object usKcQ1lOARRlPlkHobnP(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int ohvQqslOPWc3THcSnQT7(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object RKlS4ylOJXu5BBFqf0Eb()
	{
		return SHA1.Create();
	}

	internal static object a9o02NlOFkJpHBpBjcPe(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool hi2q2wlO3ict9gxn3jtL(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object umORmilOpjG4gFipgirf(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object oPIBA2lOuk487WtrpwQS(object P_0)
	{
		return ((F5CPUNl5pxqM6Zmk7dMj)P_0).m9OIO8Q0EK();
	}

	internal static void lXC6S2lOzOHWXZgeV65F(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long sRadS2lq0RInRfEilL5m(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object c5ttWTlq2MCpunlwy9eo(object P_0, int P_1)
	{
		return ((F5CPUNl5pxqM6Zmk7dMj)P_0).TdKl5uhcEnE(P_1);
	}

	internal static object bUFtmulqHrnss8AuFhL2()
	{
		return lYvl1Xgkjvy();
	}

	internal static void V1JfdtlqfoCr4SAf2ECl(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object HBy1PGlq98f3NQNXDhsS(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object t086M7lqn6X0aExUXrLn()
	{
		return LTjl1AXFoAm();
	}

	internal static void aaEohAlqG8dyNjFa5Tkr(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void vBaQGjlqYU2k0EUscvp3(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object JAvmlvlqoAQahRYYVQNJ()
	{
		return Encoding.UTF8;
	}

	internal static object HFRFUilqvSZmfVtKYFJI(object P_0)
	{
		return gGMl1P6DnGZ((Stream)P_0);
	}

	internal static object XLUaltlqBSCg8p2dIKOw(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void MDIsPTlqawxhirCf95KU(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void RSoZH5lqiUcv8KJgjI2a(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void KRmM7wlqlSRgSNtLyxmu(object P_0)
	{
		((F5CPUNl5pxqM6Zmk7dMj)P_0).IIdlS2OWuFo();
	}

	internal static void nonICElq4g7OQVqUbOgm(object P_0, object P_1, uint P_2, object P_3)
	{
		kKrl1EFUQWc((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort L8fc8SlqDabOu3VUBQWY(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int JK3Uc6lqbxVks7idD63G(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void ABbkB4lqNysd3YD1p6QM(object P_0, object P_1, int P_2, int P_3)
	{
		FM2l1QLmO9U((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long j0ytkilqkrKk6PlOBpoA(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint ExF2mrlq1MKmaHTwIo6F(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint dIfY6Xlq5CJ1DFMmMCWq(uint P_0, int P_1, long P_2, object P_3)
	{
		return cu6l1dpkR0L(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long qgTG6WlqSDI4CLit06GS(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object fMBdDwlqx3H3xdLAW9OQ(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object rJcoHrlqLK5rKLdsGo1X(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void spJtbslqeJ5kykWsO7fS(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object vH1E3MlqsvL9G327kQMg(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool dCnjgDlqXq2IDydBvJqD(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void hKqqO4lqcaRKcpvrA4m5(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object FgwavVlqjcxuxG9EAtps(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object UBpZg7lqEHe9OvqFUpuB(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object s1wPVTlqQb8D9TAyPvMS(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool lTLPYIlOmZe0anALXu7Y()
	{
		return (object)null == null;
	}

	internal static object UVoxnYlOhpyIgIR4DnhD()
	{
		return null;
	}
}
