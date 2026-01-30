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
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using lmwGsdkNtws8NQ6IFiIj;
using mbUKQckNlyCOeZGxOWCQ;

namespace fZl77HkDbCF2hZri4dVV;

internal class vpHjm6kDDRWPs2gcoFH7
{
	private delegate void WbJK1mkbrQOKh19qCixQ(object o);

	internal class GCjY1qkbKpS52xONDfV5 : Attribute
	{
		internal class wdDBs6kbm1QVIxJAanBD<pyKUGqkbh8MgGW904pFf>
		{
			internal static object QTDEw4kgnOCn6U2Ni8yx;

			public wdDBs6kbm1QVIxJAanBD()
			{
				qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
				base._002Ector();
			}

			static wdDBs6kbm1QVIxJAanBD()
			{
				YVLkDdJnH9g();
				P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool mb05H3kgGrnGRuNCRnN9()
			{
				return QTDEw4kgnOCn6U2Ni8yx == null;
			}

			internal static object IiXGPWkgYleRqWPX4lbU()
			{
				return QTDEw4kgnOCn6U2Ni8yx;
			}
		}

		public GCjY1qkbKpS52xONDfV5(object P_0)
		{
		}

		static GCjY1qkbKpS52xONDfV5()
		{
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class rdYV9xkbwVo6YEmDyMEr
	{
		internal static string sw9kb7VS2iM(string P_0, string P_1)
		{
			byte[] bytes = ((Encoding)Ch15v4kga9LKkFe6HQKG()).GetBytes(P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = (byte[])MT5tDkkgiroMdpcvsawx(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = lkOkDsoDH9H();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String((byte[])bQIKIEkgliuiMhPP81C8(memoryStream));
		}

		static rdYV9xkbwVo6YEmDyMEr()
		{
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object Ch15v4kga9LKkFe6HQKG()
		{
			return Encoding.Unicode;
		}

		internal static object MT5tDkkgiroMdpcvsawx(object P_0)
		{
			return H6ukDcKyaeC((byte[])P_0);
		}

		internal static object bQIKIEkgliuiMhPP81C8(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint U5aXbJkb8sH87gsgg74X(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Cy8tvbkbA8tYJnI9TMXn();

	internal struct ijALR9kbPWWGT1vPwx47
	{
		internal bool zMLkbJwrsk6;

		internal byte[] cKykbFFUZx3;
	}

	internal class aQVjJ3kb3Fc00iL6P6sI
	{
		private BinaryReader bP6kN2HXbL0;

		public aQVjJ3kb3Fc00iL6P6sI(Stream P_0)
		{
			bP6kN2HXbL0 = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return bP6kN2HXbL0.BaseStream;
		}

		internal byte[] d1Qkbp5Tf8s(int P_0)
		{
			return bP6kN2HXbL0.ReadBytes(P_0);
		}

		internal int ry1kbu8C63j(byte[] P_0, int P_1, int P_2)
		{
			return bP6kN2HXbL0.Read(P_0, P_1, P_2);
		}

		internal int NF1kbzr8p2f()
		{
			return CSKhaxkg5gf7xuHIbaHs(bP6kN2HXbL0);
		}

		internal void d3kkN0Os2YN()
		{
			bP6kN2HXbL0.Close();
		}

		static aQVjJ3kb3Fc00iL6P6sI()
		{
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static int CSKhaxkg5gf7xuHIbaHs(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr lV6E1gkNHFAk97yTBtRH(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr cXDbVJkNfLxDRZl2KbFH(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int DcTCOLkN96yQLHImZiYw(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int OILegKkNnIhdCC7iLMLv(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr cEtwmqkNGu7w542bu6RN(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int fxNY7UkNYurS3LyDsENR(IntPtr ptr);

	[Flags]
	private enum taA5bAkNoqb0yT5ZrLEb
	{

	}

	internal static Assembly LX1kbYpJYTk;

	private static Dictionary<int, int> R7LkbigGPpM;

	private static IntPtr qWFkb5r3JOC;

	[GCjY1qkbKpS52xONDfV5(typeof(GCjY1qkbKpS52xONDfV5.wdDBs6kbm1QVIxJAanBD<object>[]))]
	private static bool kjRkbqep8M2;

	private static IntPtr j29kbVJTPZ6;

	private static IntPtr Mx8kbOUtyYo;

	private static List<string> AVZkbb2IInv;

	private static cEtwmqkNGu7w542bu6RN ngfkbyGhMJ1;

	private static bool sTbkbGbx43B;

	private static int kCNkb4P4EWl;

	internal static U5aXbJkb8sH87gsgg74X an2kbQU6v4w;

	private static bool FVgkb62IdU0;

	private static int hXXkbcpvD5K;

	private static int LDokbMCljVL;

	private static bool DgRkbvjS2lc;

	internal static Hashtable pECkbICGqi4;

	internal static RSACryptoServiceProvider HZSkbayDl0N;

	private static int RockbgjIxrf;

	internal static U5aXbJkb8sH87gsgg74X ldykbEZJaYy;

	private static List<int> lqNkbNYbpjX;

	private static bool wZAkbROBte1;

	private static byte[] JXrkbkrDtvj;

	private static lV6E1gkNHFAk97yTBtRH DSdkbW5Vkiu;

	private static bool IgxkbBdqB64;

	private static object tbWkbxvXL1N;

	private static bool oLUkbsKAOlR;

	private static int D6rkbeXntOk;

	private static object nKYkblUtmR1;

	private static cXDbVJkNfLxDRZl2KbFH Xx5kbtEew19;

	private static object JfWkbD6U1fT;

	private static int[] x99kbLu75GN;

	private static long Q9skbdPeiBR;

	private static SortedList SLlkbXJBQDo;

	private static fxNY7UkNYurS3LyDsENR kiokbZyqUYn;

	private static IntPtr YlUkbSdEHCf;

	private static long NH6kbjgB4YW;

	private static DcTCOLkN96yQLHImZiYw WIbkbUE1Vfa;

	private static byte[] uD7kb1vxy0v;

	private static string ux6kbCCsNeZ;

	private static OILegKkNnIhdCC7iLMLv PI9kbTyQGXE;

	private static uint[] Kfwkbo27IXF;

	static vpHjm6kDDRWPs2gcoFH7()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		sTbkbGbx43B = false;
		LX1kbYpJYTk = Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554484)).Assembly;
		Kfwkbo27IXF = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		DgRkbvjS2lc = false;
		IgxkbBdqB64 = false;
		HZSkbayDl0N = null;
		R7LkbigGPpM = null;
		nKYkblUtmR1 = new object();
		kCNkb4P4EWl = 0;
		JfWkbD6U1fT = new object();
		AVZkbb2IInv = null;
		lqNkbNYbpjX = null;
		JXrkbkrDtvj = new byte[0];
		uD7kb1vxy0v = new byte[0];
		qWFkb5r3JOC = IntPtr.Zero;
		YlUkbSdEHCf = IntPtr.Zero;
		tbWkbxvXL1N = new string[0];
		x99kbLu75GN = new int[0];
		D6rkbeXntOk = 1;
		oLUkbsKAOlR = false;
		SLlkbXJBQDo = new SortedList();
		hXXkbcpvD5K = 0;
		NH6kbjgB4YW = 0L;
		ldykbEZJaYy = null;
		an2kbQU6v4w = null;
		Q9skbdPeiBR = 0L;
		RockbgjIxrf = 0;
		wZAkbROBte1 = false;
		FVgkb62IdU0 = false;
		LDokbMCljVL = 0;
		Mx8kbOUtyYo = IntPtr.Zero;
		kjRkbqep8M2 = false;
		pECkbICGqi4 = new Hashtable();
		DSdkbW5Vkiu = null;
		Xx5kbtEew19 = null;
		WIbkbUE1Vfa = null;
		PI9kbTyQGXE = null;
		ngfkbyGhMJ1 = null;
		kiokbZyqUYn = null;
		j29kbVJTPZ6 = IntPtr.Zero;
		ux6kbCCsNeZ = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void KRekWl4WRiE()
	{
	}

	internal static byte[] QoqkDNmmn4w(byte[] P_0)
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
			h2fkDkkCGBy(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			h2fkDkkCGBy(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			h2fkDkkCGBy(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			h2fkDkkCGBy(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			h2fkDkkCGBy(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			h2fkDkkCGBy(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			h2fkDkkCGBy(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			h2fkDkkCGBy(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			h2fkDkkCGBy(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			h2fkDkkCGBy(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			h2fkDkkCGBy(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			h2fkDkkCGBy(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			h2fkDkkCGBy(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			h2fkDkkCGBy(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			h2fkDkkCGBy(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			h2fkDkkCGBy(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			zZPkD1gSOBd(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			zZPkD1gSOBd(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			zZPkD1gSOBd(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			zZPkD1gSOBd(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			zZPkD1gSOBd(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			zZPkD1gSOBd(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			zZPkD1gSOBd(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			zZPkD1gSOBd(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			zZPkD1gSOBd(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			zZPkD1gSOBd(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			zZPkD1gSOBd(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			zZPkD1gSOBd(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			zZPkD1gSOBd(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			zZPkD1gSOBd(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			zZPkD1gSOBd(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			zZPkD1gSOBd(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			sBxkD5Eq2dk(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			sBxkD5Eq2dk(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			sBxkD5Eq2dk(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			sBxkD5Eq2dk(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			sBxkD5Eq2dk(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			sBxkD5Eq2dk(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			sBxkD5Eq2dk(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			sBxkD5Eq2dk(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			sBxkD5Eq2dk(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			sBxkD5Eq2dk(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			sBxkD5Eq2dk(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			sBxkD5Eq2dk(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			sBxkD5Eq2dk(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			sBxkD5Eq2dk(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			sBxkD5Eq2dk(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			sBxkD5Eq2dk(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			HNokDSm2weK(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			HNokDSm2weK(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			HNokDSm2weK(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			HNokDSm2weK(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			HNokDSm2weK(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			HNokDSm2weK(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			HNokDSm2weK(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			HNokDSm2weK(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			HNokDSm2weK(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			HNokDSm2weK(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			HNokDSm2weK(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			HNokDSm2weK(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			HNokDSm2weK(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			HNokDSm2weK(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			HNokDSm2weK(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			HNokDSm2weK(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void h2fkDkkCGBy(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + WnGkDxJgYZw(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + Kfwkbo27IXF[P_6 - 1], P_5);
	}

	private static void zZPkD1gSOBd(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + WnGkDxJgYZw(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + Kfwkbo27IXF[P_6 - 1], P_5);
	}

	private static void sBxkD5Eq2dk(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + WnGkDxJgYZw(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + Kfwkbo27IXF[P_6 - 1], P_5);
	}

	private static void HNokDSm2weK(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + WnGkDxJgYZw(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + Kfwkbo27IXF[P_6 - 1], P_5);
	}

	private static uint WnGkDxJgYZw(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool MZjkDLhDCIg()
	{
		if (!DgRkbvjS2lc)
		{
			uOnkDXZma6N();
			DgRkbvjS2lc = true;
		}
		return IgxkbBdqB64;
	}

	internal vpHjm6kDDRWPs2gcoFH7()
	{
	}

	private void aVpkDeTOCVX(byte[] P_0, byte[] P_1, byte[] P_2)
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
		JXrkbkrDtvj = array;
	}

	internal static SymmetricAlgorithm lkOkDsoDH9H()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (MZjkDLhDCIg())
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

	internal static void uOnkDXZma6N()
	{
		try
		{
			IgxkbBdqB64 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] H6ukDcKyaeC(byte[] P_0)
	{
		if (!MZjkDLhDCIg())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return QoqkDNmmn4w(P_0);
	}

	internal static void du2kDjyqHTi(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			uKNkDEmFOJ2(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void uKNkDEmFOJ2(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint xYOkDQSNCcm(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void YVLkDdJnH9g()
	{
		int num = 16;
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text = default(string);
		string text2 = default(string);
		BinaryReader binaryReader = default(BinaryReader);
		bool flag = default(bool);
		uint num16 = default(uint);
		int num17 = default(int);
		uint num24 = default(uint);
		byte[] array6 = default(byte[]);
		long num21 = default(long);
		long num20 = default(long);
		uint num19 = default(uint);
		int num14 = default(int);
		long num13 = default(long);
		uint num25 = default(uint);
		uint num22 = default(uint);
		uint num26 = default(uint);
		byte[] array7 = default(byte[]);
		long num23 = default(long);
		long num15 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					try
					{
						hashAlgorithm = (HashAlgorithm)IsJKmhkX99py3qD1CQTA();
						int num28 = 1;
						if (RgBZiiksu4fJIJhHHteN() != null)
						{
							num28 = 1;
						}
						while (true)
						{
							switch (num28)
							{
							default:
								return;
							case 3:
								if (OJJHGMkXGFlK2UdbQj4k(text))
								{
									num28 = 3;
									if (nQuoEwkspDNpQCIRN9KQ())
									{
										num28 = 4;
									}
									continue;
								}
								return;
							case 0:
								return;
							case 1:
								text2 = (string)wlhaQJkXnRXJ0vYlp07k("SHA1");
								num28 = 3;
								if (RgBZiiksu4fJIJhHHteN() == null)
								{
									num28 = 3;
								}
								continue;
							case 4:
								break;
							case 2:
								break;
							}
							break;
						}
					}
					catch
					{
						int num29 = 0;
						if (RgBZiiksu4fJIJhHHteN() == null)
						{
							num29 = 0;
						}
						switch (num29)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 4;
				default:
					if (VGOGFMkXfxVXs4TaMDwD(text) != 0)
					{
						num2 = 7;
						continue;
					}
					return;
				case 12:
					try
					{
						int num7;
						if (binaryReader == null)
						{
							num7 = 2;
							goto IL_01b3;
						}
						goto IL_01e8;
						IL_01e8:
						wbDsQykXqFJLEK4PDIRv(binaryReader);
						num7 = 0;
						if (!nQuoEwkspDNpQCIRN9KQ())
						{
							num7 = 0;
						}
						goto IL_01b3;
						IL_01b3:
						switch (num7)
						{
						default:
							goto end_IL_019e;
						case 2:
							goto end_IL_019e;
						case 1:
							break;
						case 0:
							goto end_IL_019e;
						}
						goto IL_01e8;
						end_IL_019e:;
					}
					catch
					{
						int num8 = 0;
						if (RgBZiiksu4fJIJhHHteN() != null)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 9;
				case 4:
					flag = false;
					num2 = 13;
					continue;
				case 20:
					throw new Exception((string)Nk6eSjkXt1Jl0gRqtAw3(ArQcHukXWhSgwf4dTC9n(lOUkA3kXIVS1HEOSZRZm(wR2fxNkX2hp9RNIjOIHA(typeof(vpHjm6kDDRWPs2gcoFH7).TypeHandle).Assembly)), " is tampered."));
				case 21:
					if (text == null)
					{
						num2 = 8;
						if (RgBZiiksu4fJIJhHHteN() != null)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 18:
					text2 = null;
					num2 = 3;
					continue;
				case 6:
					return;
				case 9:
				case 22:
					if (!flag)
					{
						flag = false;
						num2 = 6;
						if (RgBZiiksu4fJIJhHHteN() != null)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 20;
						if (RgBZiiksu4fJIJhHHteN() != null)
						{
							num2 = 18;
						}
					}
					continue;
				case 15:
					K23Rv2kszyvN4aSS0G2O();
					num2 = 1;
					if (!nQuoEwkspDNpQCIRN9KQ())
					{
						num2 = 1;
					}
					continue;
				case 19:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num9 = 39;
						while (true)
						{
							IL_0336:
							int num10 = num9;
							while (true)
							{
								switch (num10)
								{
								case 41:
									UdObATkXvsJFrojpiv2v(fileStream, num16);
									num10 = 0;
									if (RgBZiiksu4fJIJhHHteN() != null)
									{
										num10 = 0;
									}
									continue;
								case 17:
								case 43:
									num17++;
									num10 = 3;
									if (nQuoEwkspDNpQCIRN9KQ())
									{
										num10 = 6;
									}
									continue;
								case 21:
									UdObATkXvsJFrojpiv2v(fileStream, 376L);
									num10 = 22;
									continue;
								case 18:
									num16 = Gml9ElkXEGsy1xlGCkuH(binaryReader);
									num10 = 41;
									continue;
								case 15:
									VZjQy4kXej4WdwnB0mdN(hashAlgorithm, fileStream, num24, array6);
									num10 = 17;
									continue;
								case 24:
									num21 = num20 + num19;
									num10 = 26;
									continue;
								case 35:
								{
									uint num18 = Gml9ElkXEGsy1xlGCkuH(binaryReader);
									num19 = Gml9ElkXEGsy1xlGCkuH(binaryReader);
									num20 = DX7pVAkXQf5ZEr1xxjvB(num18, num14, num13, binaryReader);
									num10 = 24;
									if (RgBZiiksu4fJIJhHHteN() != null)
									{
										num10 = 4;
									}
									continue;
								}
								case 36:
									UdObATkXvsJFrojpiv2v(fileStream, num25 + 32);
									num10 = 34;
									if (RgBZiiksu4fJIJhHHteN() == null)
									{
										num10 = 35;
									}
									continue;
								case 29:
									num24 -= num22;
									num10 = 4;
									continue;
								case 2:
									num24 -= num26;
									num10 = 0;
									if (nQuoEwkspDNpQCIRN9KQ())
									{
										num10 = 5;
									}
									continue;
								case 34:
									array7 = (byte[])MBRRDPkXRFbbQmFh7Ryn(binaryReader, (int)num19);
									num9 = 3;
									break;
								case 7:
								case 22:
									num25 = DX7pVAkXQf5ZEr1xxjvB(Gml9ElkXEGsy1xlGCkuH(binaryReader), num14, num13, binaryReader);
									num10 = 36;
									if (!nQuoEwkspDNpQCIRN9KQ())
									{
										num10 = 13;
									}
									continue;
								case 25:
									num23 = Qt2a8dkXj1MJ7A12SxU0(fileStream);
									num10 = 6;
									if (nQuoEwkspDNpQCIRN9KQ())
									{
										num10 = 12;
									}
									continue;
								case 37:
									UdObATkXvsJFrojpiv2v(fileStream, num20);
									num10 = 34;
									continue;
								case 9:
									flag = !D9gBIQkXO3Umb0L6upLK(HZSkbayDl0N, xwirJskXMF737BOiOIj9(hashAlgorithm), text2, array7);
									num10 = 14;
									continue;
								case 28:
									num17 = 0;
									num10 = 1;
									if (!nQuoEwkspDNpQCIRN9KQ())
									{
										num10 = 1;
									}
									continue;
								case 27:
								case 42:
									if (num23 < num21)
									{
										num10 = 33;
										if (!nQuoEwkspDNpQCIRN9KQ())
										{
											num10 = 20;
										}
										continue;
									}
									goto case 15;
								case 26:
									UdObATkXvsJFrojpiv2v(fileStream, num15);
									num10 = 28;
									continue;
								case 20:
									JHwKhikXg2Xl96oe8Nww(hashAlgorithm, new byte[0], 0, 0);
									num10 = 37;
									continue;
								case 11:
									num24 = Gml9ElkXEGsy1xlGCkuH(binaryReader);
									num10 = 18;
									continue;
								case 1:
								case 6:
									if (num17 < num14)
									{
										num10 = 40;
										if (!nQuoEwkspDNpQCIRN9KQ())
										{
											num10 = 33;
										}
										continue;
									}
									goto case 20;
								case 13:
									num26 = (uint)(num21 - num23);
									num10 = 19;
									continue;
								case 30:
									if (num23 >= num21)
									{
										num10 = 42;
										continue;
									}
									goto case 13;
								case 19:
									if (num26 < num24)
									{
										num10 = 2;
										if (RgBZiiksu4fJIJhHHteN() == null)
										{
											num10 = 2;
										}
										continue;
									}
									goto case 17;
								case 5:
									UdObATkXvsJFrojpiv2v(fileStream, Qt2a8dkXj1MJ7A12SxU0(fileStream) + num26);
									num10 = 23;
									if (RgBZiiksu4fJIJhHHteN() != null)
									{
										num10 = 12;
									}
									continue;
								case 16:
									VZjQy4kXej4WdwnB0mdN(hashAlgorithm, fileStream, 152u, array6);
									num10 = 44;
									continue;
								case 3:
									R5TCxgkX6MvLyQaNkNoN(array7);
									num10 = 9;
									continue;
								case 8:
									array6 = new byte[65536];
									num10 = 16;
									if (RgBZiiksu4fJIJhHHteN() != null)
									{
										num10 = 7;
									}
									continue;
								case 10:
									UdObATkXvsJFrojpiv2v(fileStream, 360L);
									num10 = 7;
									if (!nQuoEwkspDNpQCIRN9KQ())
									{
										num10 = 7;
									}
									continue;
								case 12:
									if (num20 <= num23)
									{
										num10 = 30;
										if (RgBZiiksu4fJIJhHHteN() != null)
										{
											num10 = 10;
										}
										continue;
									}
									goto case 27;
								case 39:
									binaryReader = new BinaryReader(fileStream);
									num10 = 8;
									continue;
								case 38:
								case 40:
									UdObATkXvsJFrojpiv2v(fileStream, num13 + num17 * 40 + 16);
									num10 = 11;
									if (RgBZiiksu4fJIJhHHteN() != null)
									{
										num10 = 11;
									}
									continue;
								default:
									if (num24 == 0)
									{
										num9 = 43;
										break;
									}
									goto case 25;
								case 32:
									VZjQy4kXej4WdwnB0mdN(hashAlgorithm, fileStream, num22, array6);
									num10 = 29;
									continue;
								case 31:
								case 33:
									num22 = (uint)dkXs8lkXdVnExPa6YZET(num20 - num23, num24);
									num10 = 32;
									continue;
								case 44:
								{
									bool num11 = Bg1M8YkXso4DkHV4nm9e(binaryReader) != 523;
									int num12 = (num11 ? 96 : 112);
									UdObATkXvsJFrojpiv2v(fileStream, 152L);
									L0SFoYkXXIm0yhT1kqRY(fileStream, array6, 0, num12);
									array6[64] = 0;
									array6[65] = 0;
									array6[66] = 0;
									array6[67] = 0;
									XPNk8PkXcOLWULosXdYv(hashAlgorithm, array6, 0, num12);
									L0SFoYkXXIm0yhT1kqRY(fileStream, array6, 0, 128);
									array6[32] = 0;
									array6[33] = 0;
									array6[34] = 0;
									array6[35] = 0;
									array6[36] = 0;
									array6[37] = 0;
									array6[38] = 0;
									array6[39] = 0;
									XPNk8PkXcOLWULosXdYv(hashAlgorithm, array6, 0, 128);
									num13 = Qt2a8dkXj1MJ7A12SxU0(fileStream);
									UdObATkXvsJFrojpiv2v(fileStream, 134L);
									num14 = Bg1M8YkXso4DkHV4nm9e(binaryReader);
									UdObATkXvsJFrojpiv2v(fileStream, num13);
									VZjQy4kXej4WdwnB0mdN(hashAlgorithm, fileStream, (uint)(num14 * 40), array6);
									num15 = Qt2a8dkXj1MJ7A12SxU0(fileStream);
									if (num11)
									{
										num10 = 10;
										continue;
									}
									goto case 21;
								}
								case 14:
									goto end_IL_033a;
								}
								goto IL_0336;
								continue;
								end_IL_033a:
								break;
							}
							break;
						}
					}
					catch
					{
						int num27 = 1;
						if (RgBZiiksu4fJIJhHHteN() == null)
						{
							num27 = 1;
						}
						while (true)
						{
							switch (num27)
							{
							case 1:
								flag = true;
								num27 = 0;
								if (nQuoEwkspDNpQCIRN9KQ())
								{
									num27 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 5;
				case 8:
					return;
				case 10:
					HZSkbayDl0N = new RSACryptoServiceProvider();
					num2 = 17;
					if (RgBZiiksu4fJIJhHHteN() != null)
					{
						num2 = 9;
					}
					continue;
				case 5:
					num2 = 12;
					continue;
				case 14:
					if (flag)
					{
						num2 = 7;
						if (nQuoEwkspDNpQCIRN9KQ())
						{
							num2 = 9;
						}
						continue;
					}
					break;
				case 13:
					try
					{
						aQVjJ3kb3Fc00iL6P6sI aQVjJ3kb3Fc00iL6P6sI = new aQVjJ3kb3Fc00iL6P6sI((Stream)uck6sBkXY0aHGCMHCWgD(LX1kbYpJYTk, "38xt9EkDfYvjcAYgfFCW.4hr2ALkD9ksyhTJgegSR"));
						UdObATkXvsJFrojpiv2v(Uvk40MkXooUCINy6PjUq(aQVjJ3kb3Fc00iL6P6sI), 0L);
						byte[] array = (byte[])lNuyJakXagj2bi4mqprD(aQVjJ3kb3Fc00iL6P6sI, (int)pZbWePkXBfvKkeph6dWU(Uvk40MkXooUCINy6PjUq(aQVjJ3kb3Fc00iL6P6sI)));
						byte[] array2 = new byte[32];
						int num3 = 170 - 56;
						array2[0] = (byte)num3;
						num3 = 215 - 71;
						array2[0] = (byte)num3;
						array2[0] = 140;
						array2[1] = 132;
						num3 = 145 - 48;
						array2[1] = (byte)num3;
						array2[1] = 134;
						array2[1] = 216;
						array2[2] = 126;
						num3 = 10 + 117;
						array2[2] = (byte)num3;
						num3 = 12 + 97;
						array2[2] = (byte)num3;
						num3 = 24 + 69;
						array2[2] = (byte)num3;
						array2[2] = 168;
						array2[2] = 127;
						num3 = 237 - 79;
						array2[3] = (byte)num3;
						array2[3] = 113;
						num3 = 220 - 73;
						array2[3] = (byte)num3;
						array2[3] = 167;
						num3 = 109 + 28;
						array2[4] = (byte)num3;
						array2[4] = 163;
						num3 = 25 + 101;
						array2[4] = (byte)num3;
						array2[5] = 93;
						num3 = 133 - 44;
						array2[5] = (byte)num3;
						array2[5] = 156;
						array2[5] = 152;
						array2[5] = 112;
						num3 = 118 + 33;
						array2[6] = (byte)num3;
						num3 = 32 + 28;
						array2[6] = (byte)num3;
						num3 = 152 + 76;
						array2[6] = (byte)num3;
						num3 = 181 - 60;
						array2[7] = (byte)num3;
						array2[7] = 120;
						array2[7] = 135;
						array2[7] = 107;
						num3 = 151 - 122;
						array2[7] = (byte)num3;
						array2[8] = 188;
						num3 = 33 + 43;
						array2[8] = (byte)num3;
						num3 = 239 - 79;
						array2[8] = (byte)num3;
						num3 = 50 + 76;
						array2[8] = (byte)num3;
						array2[9] = 139;
						num3 = 117 + 37;
						array2[9] = (byte)num3;
						num3 = 80 + 25;
						array2[9] = (byte)num3;
						array2[9] = 178;
						num3 = 10 + 102;
						array2[9] = (byte)num3;
						num3 = 26 + 100;
						array2[9] = (byte)num3;
						array2[10] = 121;
						num3 = 6 + 0;
						array2[10] = (byte)num3;
						num3 = 188 - 62;
						array2[10] = (byte)num3;
						num3 = 153 + 11;
						array2[10] = (byte)num3;
						array2[11] = 34;
						num3 = 75 + 109;
						array2[11] = (byte)num3;
						num3 = 91 + 101;
						array2[11] = (byte)num3;
						array2[12] = 154;
						num3 = 172 - 57;
						array2[12] = (byte)num3;
						num3 = 134 - 44;
						array2[12] = (byte)num3;
						array2[12] = 126;
						array2[13] = 178;
						num3 = 7 + 83;
						array2[13] = (byte)num3;
						num3 = 102 + 47;
						array2[13] = (byte)num3;
						array2[13] = 79;
						array2[13] = 228;
						num3 = 223 - 74;
						array2[14] = (byte)num3;
						num3 = 117 + 2;
						array2[14] = (byte)num3;
						num3 = 134 - 44;
						array2[14] = (byte)num3;
						num3 = 123 - 82;
						array2[14] = (byte)num3;
						num3 = 13 + 6;
						array2[15] = (byte)num3;
						num3 = 48 + 14;
						array2[15] = (byte)num3;
						array2[15] = 162;
						array2[15] = 243;
						array2[16] = 97;
						num3 = 218 - 72;
						array2[16] = (byte)num3;
						array2[16] = 126;
						array2[16] = 94;
						num3 = 10 + 64;
						array2[16] = (byte)num3;
						num3 = 96 - 53;
						array2[16] = (byte)num3;
						array2[17] = 117;
						array2[17] = 123;
						array2[17] = 62;
						array2[18] = 186;
						num3 = 190 - 63;
						array2[18] = (byte)num3;
						array2[18] = 156;
						array2[18] = 129;
						array2[18] = 128;
						array2[18] = 204;
						array2[19] = 92;
						array2[19] = 75;
						num3 = 87 + 37;
						array2[19] = (byte)num3;
						array2[19] = 58;
						array2[19] = 171;
						num3 = 195 - 65;
						array2[20] = (byte)num3;
						num3 = 203 - 67;
						array2[20] = (byte)num3;
						num3 = 118 - 116;
						array2[20] = (byte)num3;
						num3 = 43 + 61;
						array2[21] = (byte)num3;
						array2[21] = 118;
						array2[21] = 140;
						array2[21] = 95;
						array2[21] = 125;
						num3 = 129 - 43;
						array2[22] = (byte)num3;
						array2[22] = 92;
						array2[22] = 135;
						array2[22] = 104;
						array2[22] = 48;
						num3 = 99 + 117;
						array2[23] = (byte)num3;
						num3 = 134 - 44;
						array2[23] = (byte)num3;
						num3 = 148 - 49;
						array2[23] = (byte)num3;
						num3 = 72 + 96;
						array2[23] = (byte)num3;
						array2[23] = 162;
						array2[24] = 156;
						num3 = 157 - 52;
						array2[24] = (byte)num3;
						num3 = 60 + 90;
						array2[24] = (byte)num3;
						num3 = 190 - 63;
						array2[24] = (byte)num3;
						num3 = 127 + 29;
						array2[24] = (byte)num3;
						num3 = 26 + 91;
						array2[25] = (byte)num3;
						array2[25] = 139;
						array2[25] = 200;
						num3 = 43 + 45;
						array2[25] = (byte)num3;
						array2[25] = 110;
						num3 = 66 + 6;
						array2[26] = (byte)num3;
						array2[26] = 132;
						array2[26] = 132;
						num3 = 109 + 112;
						array2[26] = (byte)num3;
						num3 = 125 - 41;
						array2[26] = (byte)num3;
						array2[26] = 150;
						num3 = 23 + 119;
						array2[27] = (byte)num3;
						num3 = 171 - 57;
						array2[27] = (byte)num3;
						array2[27] = 120;
						array2[27] = 50;
						array2[28] = 132;
						num3 = 224 - 74;
						array2[28] = (byte)num3;
						array2[28] = 11;
						array2[29] = 114;
						num3 = 63 + 92;
						array2[29] = (byte)num3;
						num3 = 8 + 108;
						array2[29] = (byte)num3;
						array2[29] = 6;
						array2[30] = 89;
						array2[30] = 120;
						array2[30] = 227;
						num3 = 125 - 41;
						array2[31] = (byte)num3;
						num3 = 99 + 52;
						array2[31] = (byte)num3;
						num3 = 152 - 50;
						array2[31] = (byte)num3;
						num3 = 83 + 52;
						array2[31] = (byte)num3;
						byte[] array3 = array2;
						byte[] array4 = new byte[16]
						{
							145, 0, 0, 0, 0, 0, 0, 0, 0, 0,
							0, 0, 0, 0, 0, 0
						};
						int num4 = 215 - 71;
						array4[0] = (byte)num4;
						array4[0] = 90;
						num4 = 44 + 19;
						array4[0] = (byte)num4;
						array4[0] = 202;
						array4[1] = 101;
						array4[1] = 78;
						array4[1] = 154;
						array4[2] = 165;
						array4[2] = 109;
						array4[2] = 93;
						num4 = 252 - 84;
						array4[2] = (byte)num4;
						num4 = 10 + 108;
						array4[2] = (byte)num4;
						num4 = 126 - 42;
						array4[2] = (byte)num4;
						num4 = 91 + 18;
						array4[3] = (byte)num4;
						num4 = 109 + 28;
						array4[3] = (byte)num4;
						array4[3] = 227;
						num4 = 70 + 101;
						array4[4] = (byte)num4;
						num4 = 138 - 46;
						array4[4] = (byte)num4;
						num4 = 125 - 41;
						array4[4] = (byte)num4;
						num4 = 219 + 6;
						array4[4] = (byte)num4;
						num4 = 10 + 99;
						array4[5] = (byte)num4;
						num4 = 244 - 81;
						array4[5] = (byte)num4;
						array4[5] = 107;
						array4[5] = 60;
						array4[5] = 162;
						array4[6] = 149;
						array4[6] = 85;
						num4 = 207 - 69;
						array4[6] = (byte)num4;
						num4 = 158 - 52;
						array4[6] = (byte)num4;
						num4 = 118 + 122;
						array4[6] = (byte)num4;
						array4[7] = 188;
						num4 = 33 + 43;
						array4[7] = (byte)num4;
						num4 = 239 - 79;
						array4[7] = (byte)num4;
						array4[7] = 136;
						array4[7] = 139;
						num4 = 135 - 117;
						array4[7] = (byte)num4;
						num4 = 170 - 56;
						array4[8] = (byte)num4;
						num4 = 151 - 50;
						array4[8] = (byte)num4;
						num4 = 124 + 54;
						array4[8] = (byte)num4;
						array4[8] = 90;
						num4 = 160 - 53;
						array4[8] = (byte)num4;
						array4[8] = 107;
						num4 = 181 - 60;
						array4[9] = (byte)num4;
						array4[9] = 88;
						array4[9] = 110;
						num4 = 236 + 11;
						array4[9] = (byte)num4;
						num4 = 0 + 34;
						array4[10] = (byte)num4;
						num4 = 203 - 67;
						array4[10] = (byte)num4;
						array4[10] = 165;
						array4[10] = 154;
						array4[10] = 115;
						num4 = 87 - 9;
						array4[10] = (byte)num4;
						num4 = 58 + 105;
						array4[11] = (byte)num4;
						array4[11] = 131;
						num4 = 83 + 68;
						array4[11] = (byte)num4;
						array4[11] = 180;
						num4 = 126 - 42;
						array4[12] = (byte)num4;
						num4 = 44 + 106;
						array4[12] = (byte)num4;
						array4[12] = 144;
						num4 = 98 - 2;
						array4[12] = (byte)num4;
						array4[13] = 90;
						array4[13] = 156;
						num4 = 131 - 43;
						array4[13] = (byte)num4;
						num4 = 175 - 58;
						array4[13] = (byte)num4;
						num4 = 185 - 61;
						array4[13] = (byte)num4;
						array4[13] = 101;
						num4 = 192 - 64;
						array4[14] = (byte)num4;
						array4[14] = 158;
						num4 = 64 - 60;
						array4[14] = (byte)num4;
						array4[15] = 94;
						num4 = 10 + 64;
						array4[15] = (byte)num4;
						num4 = 53 + 77;
						array4[15] = (byte)num4;
						array4[15] = 14;
						num4 = 100 - 50;
						array4[15] = (byte)num4;
						byte[] array5 = array4;
						object obj = nrIvymkXiq367ALKnp0j();
						cR6joKkXlYPk4GLA2pnN(obj, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)MdPMcpkX4QyVWbEJSyO6(obj, array3, array5);
						Stream stream = (Stream)CARaaBkXDcuEGXJXqi1D();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						wlCIUKkXbQUTPVE9Ed2W(cryptoStream, array, 0, array.Length);
						RbmYLFkXNJF8ClAky3IL(cryptoStream);
						dnSIFXkXSLbTp9Ll28Y7(HZSkbayDl0N, RsN7qNkX5VPn8v0NcKeV(gTqYE4kXkq5aYKiHXKAI(), u1PxQMkX1fBImtXDnnn9(stream)));
						DfJThikXxYfnTnPUWGZs(stream);
						DfJThikXxYfnTnPUWGZs(cryptoStream);
						n77Rg5kXLVRr8YZYAwbw(aQVjJ3kb3Fc00iL6P6sI);
						int num5 = 0;
						if (!nQuoEwkspDNpQCIRN9KQ())
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
						if (!nQuoEwkspDNpQCIRN9KQ())
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
								if (!nQuoEwkspDNpQCIRN9KQ())
								{
									num6 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 14;
				case 17:
					goto end_IL_0012;
				case 16:
					if (HZSkbayDl0N != null)
					{
						return;
					}
					num2 = 15;
					if (!nQuoEwkspDNpQCIRN9KQ())
					{
						num2 = 1;
					}
					continue;
				case 11:
					return;
				case 7:
					hashAlgorithm = null;
					num2 = 18;
					continue;
				case 1:
					AajxZ4kX0v4Q32FLUu75(true);
					num2 = 10;
					if (RgBZiiksu4fJIJhHHteN() != null)
					{
						num2 = 6;
					}
					continue;
				case 2:
					break;
				}
				binaryReader = null;
				num2 = 19;
				continue;
				end_IL_0012:
				break;
			}
			text = (string)vsCYFfkXH5mYiTmA0faB(wR2fxNkX2hp9RNIjOIHA(typeof(vpHjm6kDDRWPs2gcoFH7).TypeHandle).Assembly);
			num = 21;
		}
	}

	public static void TglkDg5mguS(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (R7LkbigGPpM == null)
			{
				lock (nKYkblUtmR1)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554484)).Assembly.GetManifestResourceStream("8ZQhinkDv4ke17vbrqlR.vhffhMkDB8udxuVaYjeT"));
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
							num3 += hmdkDMNTmxQ(num3);
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
						aQVjJ3kb3Fc00iL6P6sI aQVjJ3kb3Fc00iL6P6sI = new aQVjJ3kb3Fc00iL6P6sI(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = aQVjJ3kb3Fc00iL6P6sI.NF1kbzr8p2f();
							int value = aQVjJ3kb3Fc00iL6P6sI.NF1kbzr8p2f();
							dictionary.Add(key, value);
						}
						aQVjJ3kb3Fc00iL6P6sI.d3kkN0Os2YN();
					}
					R7LkbigGPpM = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = R7LkbigGPpM[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554484)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(16777236));
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

	private static uint HH8kD6w3TPr(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint hmdkDMNTmxQ(uint P_0)
	{
		return 0u;
	}

	internal static void SklkDOt3Qa0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void W1xkDqDcPPJ(Stream P_0, int P_1)
	{
		Ohj4BGkNWhTJYN6pbTqA.zkBkNZLispx(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string bKykDIaot93(int P_0)
	{
		if (JXrkbkrDtvj.Length == 0)
		{
			AVZkbb2IInv = new List<string>();
			lqNkbNYbpjX = new List<int>();
			W1xkDqDcPPJ(LX1kbYpJYTk.GetManifestResourceStream("WuhY2qk4z3rc2tPeRX0y.th1CsXkD0MI91Odm8Lqp"), P_0);
		}
		if (kCNkb4P4EWl < 75)
		{
			if (LX1kbYpJYTk != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			kCNkb4P4EWl++;
		}
		lock (JfWkbD6U1fT)
		{
			int num = BitConverter.ToInt32(JXrkbkrDtvj, P_0);
			if (num < lqNkbNYbpjX.Count && lqNkbNYbpjX[num] == P_0)
			{
				return AVZkbb2IInv[num];
			}
			try
			{
				qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
				byte[] array = new byte[num];
				Array.Copy(JXrkbkrDtvj, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				AVZkbb2IInv.Add(text);
				lqNkbNYbpjX.Add(P_0);
				Array.Copy(BitConverter.GetBytes(AVZkbb2IInv.Count - 1), 0, JXrkbkrDtvj, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string QdFkDW1K2AU(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int QOAkDtKm9xo()
	{
		return 5;
	}

	private static void BgZkDUOXKaJ()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate cxZkDTmHfQA(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(16777481)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(16777267)),
			Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(16777359))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object i5hkDy3ynyA(object P_0)
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
	public static extern IntPtr YXXkDZ6OKAo(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr OEPkDVMPhjY(IntPtr P_0, string P_1);

	private static IntPtr cIBkDCt7tXB(IntPtr P_0, string P_1, uint P_2)
	{
		if (DSdkbW5Vkiu == null)
		{
			DSdkbW5Vkiu = (lV6E1gkNHFAk97yTBtRH)Marshal.GetDelegateForFunctionPointer(OEPkDVMPhjY(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554493)));
		}
		return DSdkbW5Vkiu(P_0, P_1, P_2);
	}

	private static IntPtr xD4kDrEyo19(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (Xx5kbtEew19 == null)
		{
			Xx5kbtEew19 = (cXDbVJkNfLxDRZl2KbFH)Marshal.GetDelegateForFunctionPointer(OEPkDVMPhjY(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554494)));
		}
		return Xx5kbtEew19(P_0, P_1, P_2, P_3);
	}

	private static int wK7kDKjd2Rx(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (WIbkbUE1Vfa == null)
		{
			WIbkbUE1Vfa = (DcTCOLkN96yQLHImZiYw)Marshal.GetDelegateForFunctionPointer(OEPkDVMPhjY(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554495)));
		}
		return WIbkbUE1Vfa(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int cATkDm1CCuX(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (PI9kbTyQGXE == null)
		{
			PI9kbTyQGXE = (OILegKkNnIhdCC7iLMLv)Marshal.GetDelegateForFunctionPointer(OEPkDVMPhjY(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554496)));
		}
		return PI9kbTyQGXE(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr hAPkDh510eH(uint P_0, int P_1, uint P_2)
	{
		if (ngfkbyGhMJ1 == null)
		{
			ngfkbyGhMJ1 = (cEtwmqkNGu7w542bu6RN)Marshal.GetDelegateForFunctionPointer(OEPkDVMPhjY(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554497)));
		}
		return ngfkbyGhMJ1(P_0, P_1, P_2);
	}

	private static int tuHkDwwe5cV(IntPtr P_0)
	{
		if (kiokbZyqUYn == null)
		{
			kiokbZyqUYn = (fxNY7UkNYurS3LyDsENR)Marshal.GetDelegateForFunctionPointer(OEPkDVMPhjY(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554498)));
		}
		return kiokbZyqUYn(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (j29kbVJTPZ6 == IntPtr.Zero)
		{
			j29kbVJTPZ6 = YXXkDZ6OKAo("kernel ".Trim() + "32.dll");
		}
		return j29kbVJTPZ6;
	}

	private static byte[] DNxkD7ZSE8h(string P_0)
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

	internal static Stream E0fkD8i5Fnl()
	{
		return new MemoryStream();
	}

	internal static byte[] bvTkDAETJhp(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] IhXkDPa7VWG(byte[] P_0)
	{
		Stream stream = E0fkD8i5Fnl();
		SymmetricAlgorithm symmetricAlgorithm = lkOkDsoDH9H();
		symmetricAlgorithm.Key = new byte[32]
		{
			176, 133, 177, 245, 57, 33, 4, 31, 182, 31,
			177, 118, 99, 229, 39, 172, 154, 177, 186, 174,
			216, 221, 103, 226, 131, 110, 123, 199, 85, 124,
			161, 148
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			202, 221, 249, 80, 6, 248, 82, 23, 191, 168,
			26, 56, 223, 173, 151, 130
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = bvTkDAETJhp(stream);
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		return result;
	}

	private unsafe static int SdkkDJb65NY(string P_0)
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

	internal static bool R1gkDFFixTh(string P_0, string P_1)
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
		if (P_0.StartsWith(ux6kbCCsNeZ))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(ux6kbCCsNeZ))
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
			num = SdkkDJb65NY(P_0);
		}
		if (!flag2)
		{
			num2 = SdkkDJb65NY(P_1);
		}
		return num == num2;
	}

	private byte[] Ay2kD3XrSC4()
	{
		return null;
	}

	private byte[] UqSkDpyuUuN()
	{
		return null;
	}

	private byte[] AmOkDu3DV4A()
	{
		return null;
	}

	private byte[] nbIkDzjqUIR()
	{
		return null;
	}

	private byte[] LKakb0tl663()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] R8Ykb2BkhKN()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] A7fkbHvmkrD()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] FDDkbfa4IKk()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] alfkb9Y3lGN()
	{
		return null;
	}

	internal byte[] vA3kbnlboaY()
	{
		return null;
	}

	internal static object y6vgWsksUcFmMEXsCf1F(object P_0)
	{
		return ((aQVjJ3kb3Fc00iL6P6sI)P_0).m9OIO8Q0EK();
	}

	internal static void YAoWtwksTNF4uZiMBMei(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long bRKU9Oksyo9WwseyCT4Y(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object NIuHqKksZZgsCBYyW7Oj(object P_0, int P_1)
	{
		return ((aQVjJ3kb3Fc00iL6P6sI)P_0).d1Qkbp5Tf8s(P_1);
	}

	internal static void Qn5ry5ksVPJbU6DODITa(object P_0)
	{
		((aQVjJ3kb3Fc00iL6P6sI)P_0).d3kkN0Os2YN();
	}

	internal static void kovHxSksC6aq2kpwA2BU(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object RTnOVwksr8WD3C9KhB31(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object ltf8amksKJG6YQjBiDOK(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object tVI7OAksmChZ3yepoong()
	{
		return lkOkDsoDH9H();
	}

	internal static void J22oP7kshYcRDYiJC3j9(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object HEwxUWkswO3c9K18iSUR(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object NH4W8eks7wUoDiS3TdWt()
	{
		return E0fkD8i5Fnl();
	}

	internal static void BFoAAJks8M8j2Q36h8Br(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void KMimJWksAcE1ZEMC1BAL(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object Ppmyi2ksPaNdCG1tUep5(object P_0)
	{
		return bvTkDAETJhp((Stream)P_0);
	}

	internal static void EScSssksJtgrBHcrWbMC(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object ggXgqrksF5hQn3nhA8dn(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool n0uyr5ks3573vXOO3y8I(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool iaGj4uksWt0WgoFgxBFk()
	{
		return (object)null == null;
	}

	internal static object lV0EMtkstqYXjnbrSo5x()
	{
		return null;
	}

	internal static void K23Rv2kszyvN4aSS0G2O()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static void AajxZ4kX0v4Q32FLUu75(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type wR2fxNkX2hp9RNIjOIHA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object vsCYFfkXH5mYiTmA0faB(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int VGOGFMkXfxVXs4TaMDwD(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object IsJKmhkX99py3qD1CQTA()
	{
		return SHA1.Create();
	}

	internal static object wlhaQJkXnRXJ0vYlp07k(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool OJJHGMkXGFlK2UdbQj4k(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object uck6sBkXY0aHGCMHCWgD(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object Uvk40MkXooUCINy6PjUq(object P_0)
	{
		return ((aQVjJ3kb3Fc00iL6P6sI)P_0).m9OIO8Q0EK();
	}

	internal static void UdObATkXvsJFrojpiv2v(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long pZbWePkXBfvKkeph6dWU(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object lNuyJakXagj2bi4mqprD(object P_0, int P_1)
	{
		return ((aQVjJ3kb3Fc00iL6P6sI)P_0).d1Qkbp5Tf8s(P_1);
	}

	internal static object nrIvymkXiq367ALKnp0j()
	{
		return lkOkDsoDH9H();
	}

	internal static void cR6joKkXlYPk4GLA2pnN(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object MdPMcpkX4QyVWbEJSyO6(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object CARaaBkXDcuEGXJXqi1D()
	{
		return E0fkD8i5Fnl();
	}

	internal static void wlCIUKkXbQUTPVE9Ed2W(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void RbmYLFkXNJF8ClAky3IL(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object gTqYE4kXkq5aYKiHXKAI()
	{
		return Encoding.UTF8;
	}

	internal static object u1PxQMkX1fBImtXDnnn9(object P_0)
	{
		return bvTkDAETJhp((Stream)P_0);
	}

	internal static object RsN7qNkX5VPn8v0NcKeV(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void dnSIFXkXSLbTp9Ll28Y7(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void DfJThikXxYfnTnPUWGZs(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void n77Rg5kXLVRr8YZYAwbw(object P_0)
	{
		((aQVjJ3kb3Fc00iL6P6sI)P_0).d3kkN0Os2YN();
	}

	internal static void VZjQy4kXej4WdwnB0mdN(object P_0, object P_1, uint P_2, object P_3)
	{
		du2kDjyqHTi((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort Bg1M8YkXso4DkHV4nm9e(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int L0SFoYkXXIm0yhT1kqRY(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void XPNk8PkXcOLWULosXdYv(object P_0, object P_1, int P_2, int P_3)
	{
		uKNkDEmFOJ2((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long Qt2a8dkXj1MJ7A12SxU0(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint Gml9ElkXEGsy1xlGCkuH(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint DX7pVAkXQf5ZEr1xxjvB(uint P_0, int P_1, long P_2, object P_3)
	{
		return xYOkDQSNCcm(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long dkXs8lkXdVnExPa6YZET(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object JHwKhikXg2Xl96oe8Nww(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object MBRRDPkXRFbbQmFh7Ryn(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void R5TCxgkX6MvLyQaNkNoN(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object xwirJskXMF737BOiOIj9(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool D9gBIQkXO3Umb0L6upLK(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void wbDsQykXqFJLEK4PDIRv(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object lOUkA3kXIVS1HEOSZRZm(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object ArQcHukXWhSgwf4dTC9n(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object Nk6eSjkXt1Jl0gRqtAw3(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool nQuoEwkspDNpQCIRN9KQ()
	{
		return (object)null == null;
	}

	internal static object RgBZiiksu4fJIJhHHteN()
	{
		return null;
	}
}
