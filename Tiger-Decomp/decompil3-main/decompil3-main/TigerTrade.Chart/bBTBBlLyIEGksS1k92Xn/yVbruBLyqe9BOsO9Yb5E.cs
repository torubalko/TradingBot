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
using aAa0wvLVte7CLQrFHlCF;
using BpieHJLVgS3G3qRoeH8Z;
using CxrNctLVMAMdEWPCMHj4;
using rKa1rNLC0VCcDunEXkgZ;

namespace bBTBBlLyIEGksS1k92Xn;

internal class yVbruBLyqe9BOsO9Yb5E
{
	private delegate void aZvJ7HLVYgTnIqAdoJ37(object o);

	internal class OMKMdqLVobyuxDPUn6Ya : Attribute
	{
		internal class ONbbVsLVvWXH3099x9cx<IjTggDLVB4PJ9sEYC8r0>
		{
			internal static object LgEFg4eTTZdbK8NRyqSh;

			public ONbbVsLVvWXH3099x9cx()
			{
				tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
				base._002Ector();
			}

			static ONbbVsLVvWXH3099x9cx()
			{
				rq3Ly8VsSFl();
				ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool fvRJJleTyVQ2DWGwIJbX()
			{
				return LgEFg4eTTZdbK8NRyqSh == null;
			}

			internal static object nsrEIeeTZ2XKuS2tv6y6()
			{
				return LgEFg4eTTZdbK8NRyqSh;
			}
		}

		public OMKMdqLVobyuxDPUn6Ya(object P_0)
		{
		}

		static OMKMdqLVobyuxDPUn6Ya()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class Nx06VxLVa1u0QbgkKpSY
	{
		internal static string DJlLViQxc3l(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] array = new byte[32];
			MaFnmteTKK6TEjXrySUo(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] key = array;
			byte[] iV = (byte[])y7tKUFeTmvbuodd1wVIG(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)QALguJeThorrkSB6VY8g();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)olEacoeTwUZwBdFmuEG8(symmetricAlgorithm), CryptoStreamMode.Write);
			xR3ipFeT79vbA3TDAg8t(cryptoStream, bytes, 0, bytes.Length);
			x1reooeT8sOorPcxNQ4o(cryptoStream);
			return Convert.ToBase64String((byte[])Ri1xTZeTABt02vls1Wqf(memoryStream));
		}

		static Nx06VxLVa1u0QbgkKpSY()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void MaFnmteTKK6TEjXrySUo(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static object y7tKUFeTmvbuodd1wVIG(object P_0)
		{
			return XI9LymeJy83((byte[])P_0);
		}

		internal static object QALguJeThorrkSB6VY8g()
		{
			return IY1LyrngXlH();
		}

		internal static object olEacoeTwUZwBdFmuEG8(object P_0)
		{
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		internal static void xR3ipFeT79vbA3TDAg8t(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void x1reooeT8sOorPcxNQ4o(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object Ri1xTZeTABt02vls1Wqf(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint MK7D5gLVldT0KEW03WCR(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr t9EtILLV4aqLlnxNRL8k();

	internal struct HL7gfxLVDVmPIfnPDk1j
	{
		internal bool USELVbePCBW;

		internal byte[] SyNLVNHgRFv;
	}

	internal class rFjo4ELVkSpcIZcFSLKW
	{
		private BinaryReader r4hLVLBpZGW;

		public rFjo4ELVkSpcIZcFSLKW(Stream P_0)
		{
			r4hLVLBpZGW = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return (Stream)m6Bok6eTzE3cmJseo85y(r4hLVLBpZGW);
		}

		internal byte[] GfnLV1rmaDJ(int P_0)
		{
			return r4hLVLBpZGW.ReadBytes(P_0);
		}

		internal int ADTLV5EfCMt(byte[] P_0, int P_1, int P_2)
		{
			return r4hLVLBpZGW.Read(P_0, P_1, P_2);
		}

		internal int fgbLVS4Zye4()
		{
			return sYUlKKey0MRKI3ZswuY8(r4hLVLBpZGW);
		}

		internal void dmkLVxnCryE()
		{
			r4hLVLBpZGW.Close();
		}

		static rFjo4ELVkSpcIZcFSLKW()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object m6Bok6eTzE3cmJseo85y(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static int sYUlKKey0MRKI3ZswuY8(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr fwWAr1LVeNSqE7BuKrgX(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr aXyoYaLVssG5dhqRWs0y(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int YcCF98LVX204NsPKuN71(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int heFPQeLVceFm48tGJFoL(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr mE0wC4LVj761vmQRqkcP(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int yOJMkvLVEQnKFNvtOFsv(IntPtr ptr);

	[Flags]
	private enum MQifhpLVQos3jCbidp1l
	{

	}

	private static List<int> hkVLZWZ9qk5;

	internal static MK7D5gLVldT0KEW03WCR VKgLZw6B2g1;

	private static long V1wLZ880kq7;

	private static bool sdGLZPlBJcy;

	private static byte[] TNwLZUHdcRF;

	private static bool VMeLZJub8Ir;

	private static object yfoLZMTbDDP;

	internal static MK7D5gLVldT0KEW03WCR zyJLZ7IMi3b;

	private static int nZrLZmaThqB;

	private static heFPQeLVceFm48tGJFoL xMVLVHIio89;

	private static IntPtr MetLVnSvGHO;

	private static object lI8LZqqEYv2;

	internal static Assembly pSTLZEPKX46;

	private static bool XhkLZgEVf84;

	private static bool NXWLZdMtdF5;

	private static aXyoYaLVssG5dhqRWs0y vZYLV013r9p;

	private static SortedList ToDLZKGaCae;

	private static int KrJLZOFbho9;

	private static int[] rhDLZVUoGQH;

	private static IntPtr kX2LZ3SOCn9;

	private static uint[] UKELZQYZsu2;

	private static YcCF98LVX204NsPKuN71 CCVLV2iW9uK;

	private static Dictionary<int, int> oRaLZ67KR0R;

	private static mE0wC4LVj761vmQRqkcP UksLVffuen9;

	private static object R4LLZZp5Vay;

	private static List<string> lbsLZI3Bf5x;

	internal static RSACryptoServiceProvider paGLZRR3oYN;

	private static yOJMkvLVEQnKFNvtOFsv wMsLV9fYFmJ;

	private static IntPtr P5GLZys6mrm;

	private static byte[] yrGLZtwOG3R;

	private static int h7gLZAntqQc;

	private static int YI6LZFOrCQ0;

	private static int VmULZCAPiSx;

	private static IntPtr NqPLZTZbiN3;

	private static long qdXLZhsUmw6;

	private static bool KenLZjjfvaZ;

	private static fwWAr1LVeNSqE7BuKrgX pBeLZzgm50c;

	[OMKMdqLVobyuxDPUn6Ya(typeof(OMKMdqLVobyuxDPUn6Ya.ONbbVsLVvWXH3099x9cx<object>[]))]
	private static bool imKLZpLF8CU;

	internal static Hashtable TbqLZu71AyD;

	private static bool fg8LZrWaZec;

	private static string U4xLVGc2XMI;

	static yVbruBLyqe9BOsO9Yb5E()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		KenLZjjfvaZ = false;
		pSTLZEPKX46 = Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554801)).Assembly;
		UKELZQYZsu2 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		NXWLZdMtdF5 = false;
		XhkLZgEVf84 = false;
		paGLZRR3oYN = null;
		oRaLZ67KR0R = null;
		yfoLZMTbDDP = new object();
		KrJLZOFbho9 = 0;
		lI8LZqqEYv2 = new object();
		lbsLZI3Bf5x = null;
		hkVLZWZ9qk5 = null;
		yrGLZtwOG3R = new byte[0];
		TNwLZUHdcRF = new byte[0];
		NqPLZTZbiN3 = IntPtr.Zero;
		P5GLZys6mrm = IntPtr.Zero;
		R4LLZZp5Vay = new string[0];
		rhDLZVUoGQH = new int[0];
		VmULZCAPiSx = 1;
		fg8LZrWaZec = false;
		ToDLZKGaCae = new SortedList();
		nZrLZmaThqB = 0;
		qdXLZhsUmw6 = 0L;
		VKgLZw6B2g1 = null;
		zyJLZ7IMi3b = null;
		V1wLZ880kq7 = 0L;
		h7gLZAntqQc = 0;
		sdGLZPlBJcy = false;
		VMeLZJub8Ir = false;
		YI6LZFOrCQ0 = 0;
		kX2LZ3SOCn9 = IntPtr.Zero;
		imKLZpLF8CU = false;
		TbqLZu71AyD = new Hashtable();
		pBeLZzgm50c = null;
		vZYLV013r9p = null;
		CCVLV2iW9uK = null;
		xMVLVHIio89 = null;
		UksLVffuen9 = null;
		wMsLV9fYFmJ = null;
		MetLVnSvGHO = IntPtr.Zero;
		U4xLVGc2XMI = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void SygehfKew84()
	{
	}

	internal static byte[] tIgLyWnw8tT(byte[] P_0)
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
			o83LytEDmtT(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			o83LytEDmtT(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			o83LytEDmtT(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			o83LytEDmtT(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			o83LytEDmtT(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			o83LytEDmtT(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			o83LytEDmtT(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			o83LytEDmtT(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			o83LytEDmtT(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			o83LytEDmtT(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			o83LytEDmtT(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			o83LytEDmtT(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			o83LytEDmtT(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			o83LytEDmtT(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			o83LytEDmtT(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			o83LytEDmtT(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			lDMLyUtlLs5(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			lDMLyUtlLs5(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			lDMLyUtlLs5(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			lDMLyUtlLs5(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			lDMLyUtlLs5(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			lDMLyUtlLs5(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			lDMLyUtlLs5(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			lDMLyUtlLs5(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			lDMLyUtlLs5(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			lDMLyUtlLs5(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			lDMLyUtlLs5(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			lDMLyUtlLs5(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			lDMLyUtlLs5(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			lDMLyUtlLs5(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			lDMLyUtlLs5(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			lDMLyUtlLs5(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			lSALyTr6slM(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			lSALyTr6slM(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			lSALyTr6slM(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			lSALyTr6slM(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			lSALyTr6slM(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			lSALyTr6slM(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			lSALyTr6slM(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			lSALyTr6slM(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			lSALyTr6slM(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			lSALyTr6slM(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			lSALyTr6slM(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			lSALyTr6slM(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			lSALyTr6slM(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			lSALyTr6slM(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			lSALyTr6slM(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			lSALyTr6slM(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			XqYLyy5pTFP(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			XqYLyy5pTFP(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			XqYLyy5pTFP(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			XqYLyy5pTFP(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			XqYLyy5pTFP(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			XqYLyy5pTFP(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			XqYLyy5pTFP(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			XqYLyy5pTFP(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			XqYLyy5pTFP(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			XqYLyy5pTFP(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			XqYLyy5pTFP(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			XqYLyy5pTFP(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			XqYLyy5pTFP(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			XqYLyy5pTFP(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			XqYLyy5pTFP(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			XqYLyy5pTFP(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void o83LytEDmtT(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ffrLyZK0180(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + UKELZQYZsu2[P_6 - 1], P_5);
	}

	private static void lDMLyUtlLs5(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ffrLyZK0180(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + UKELZQYZsu2[P_6 - 1], P_5);
	}

	private static void lSALyTr6slM(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ffrLyZK0180(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + UKELZQYZsu2[P_6 - 1], P_5);
	}

	private static void XqYLyy5pTFP(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + ffrLyZK0180(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + UKELZQYZsu2[P_6 - 1], P_5);
	}

	private static uint ffrLyZK0180(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool kYlLyV7lVvM()
	{
		if (!NXWLZdMtdF5)
		{
			h3ALyKr6XyO();
			NXWLZdMtdF5 = true;
		}
		return XhkLZgEVf84;
	}

	internal yVbruBLyqe9BOsO9Yb5E()
	{
	}

	private void EJ4LyCnwthm(byte[] P_0, byte[] P_1, byte[] P_2)
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
		yrGLZtwOG3R = array;
	}

	internal static SymmetricAlgorithm IY1LyrngXlH()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (kYlLyV7lVvM())
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

	internal static void h3ALyKr6XyO()
	{
		try
		{
			XhkLZgEVf84 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] XI9LymeJy83(byte[] P_0)
	{
		if (!kYlLyV7lVvM())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return tIgLyWnw8tT(P_0);
	}

	internal static void NK0Lyhx5U6d(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			hkjLywlDVuT(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void hkjLywlDVuT(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint vLVLy7p3F2c(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void rq3Ly8VsSFl()
	{
		int num = 18;
		string text = default(string);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		bool flag = default(bool);
		string text2 = default(string);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array2 = default(byte[]);
		uint num21 = default(uint);
		long num19 = default(long);
		long num20 = default(long);
		uint num18 = default(uint);
		uint num17 = default(uint);
		byte[] array = default(byte[]);
		uint num16 = default(uint);
		long num14 = default(long);
		int num10 = default(int);
		long num9 = default(long);
		int num12 = default(int);
		uint num13 = default(uint);
		uint num22 = default(uint);
		long num11 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					return;
				case 6:
					if (SD0ijMLAAGph8gG9Fr8K(text) == 0)
					{
						num2 = 16;
						continue;
					}
					hashAlgorithm = null;
					num2 = 2;
					continue;
				case 21:
					try
					{
						rFjo4ELVkSpcIZcFSLKW rFjo4ELVkSpcIZcFSLKW = new rFjo4ELVkSpcIZcFSLKW((Stream)fBiQPMLA3GS1Oh1ydTxv(pSTLZEPKX46, "LrpuQpLysvpYvpqf7pjJ.0hwpwJLyXt0eFBQd1jdp"));
						jmNS81LAu1e0WXHq7r9N(KccvYsLApoqbdZODolxK(rFjo4ELVkSpcIZcFSLKW), 0L);
						byte[] array3 = (byte[])Y4K3QbLP0j8EQfNlT84C(rFjo4ELVkSpcIZcFSLKW, (int)wPT1sXLAze8UIHd5Xny8(KccvYsLApoqbdZODolxK(rFjo4ELVkSpcIZcFSLKW)));
						byte[] array4 = new byte[32];
						int num26 = 142 - 47;
						array4[0] = (byte)num26;
						num26 = 254 - 84;
						array4[0] = (byte)num26;
						num26 = 155 - 55;
						array4[0] = (byte)num26;
						array4[1] = 73;
						num26 = 73 + 49;
						array4[1] = (byte)num26;
						num26 = 198 - 66;
						array4[1] = (byte)num26;
						array4[1] = 0;
						num26 = 170 - 56;
						array4[2] = (byte)num26;
						array4[2] = 99;
						array4[2] = 129;
						num26 = 42 + 61;
						array4[2] = (byte)num26;
						num26 = 113 + 65;
						array4[2] = (byte)num26;
						num26 = 142 - 47;
						array4[3] = (byte)num26;
						num26 = 94 + 49;
						array4[3] = (byte)num26;
						array4[3] = 107;
						num26 = 164 + 69;
						array4[3] = (byte)num26;
						num26 = 239 - 79;
						array4[4] = (byte)num26;
						array4[4] = 162;
						array4[4] = 51;
						num26 = 67 + 21;
						array4[5] = (byte)num26;
						array4[5] = 121;
						num26 = 218 - 111;
						array4[5] = (byte)num26;
						array4[6] = 145;
						array4[6] = 167;
						num26 = 16 + 22;
						array4[6] = (byte)num26;
						array4[6] = 141;
						array4[6] = 1;
						num26 = 138 - 46;
						array4[7] = (byte)num26;
						array4[7] = 84;
						array4[7] = 184;
						num26 = 92 + 40;
						array4[7] = (byte)num26;
						array4[8] = 181;
						num26 = 230 - 76;
						array4[8] = (byte)num26;
						num26 = 25 + 18;
						array4[8] = (byte)num26;
						array4[8] = 151;
						array4[8] = 196;
						num26 = 2 + 62;
						array4[9] = (byte)num26;
						num26 = 141 - 47;
						array4[9] = (byte)num26;
						num26 = 106 + 63;
						array4[9] = (byte)num26;
						array4[9] = 220;
						num26 = 52 + 10;
						array4[10] = (byte)num26;
						array4[10] = 87;
						array4[10] = 209;
						num26 = 47 + 78;
						array4[11] = (byte)num26;
						num26 = 37 + 61;
						array4[11] = (byte)num26;
						num26 = 215 - 71;
						array4[11] = (byte)num26;
						num26 = 106 + 73;
						array4[11] = (byte)num26;
						num26 = 90 + 18;
						array4[12] = (byte)num26;
						array4[12] = 146;
						num26 = 58 + 82;
						array4[12] = (byte)num26;
						num26 = 162 + 59;
						array4[12] = (byte)num26;
						array4[13] = 212;
						num26 = 8 + 68;
						array4[13] = (byte)num26;
						array4[13] = 158;
						num26 = 127 - 86;
						array4[13] = (byte)num26;
						array4[14] = 66;
						num26 = 40 + 15;
						array4[14] = (byte)num26;
						array4[14] = 108;
						array4[14] = 78;
						array4[14] = 10;
						num26 = 2 + 39;
						array4[15] = (byte)num26;
						num26 = 241 - 80;
						array4[15] = (byte)num26;
						array4[15] = 157;
						num26 = 131 + 122;
						array4[15] = (byte)num26;
						array4[16] = 36;
						num26 = 247 - 82;
						array4[16] = (byte)num26;
						array4[16] = 126;
						array4[16] = 85;
						num26 = 216 - 72;
						array4[16] = (byte)num26;
						num26 = 47 + 85;
						array4[16] = (byte)num26;
						array4[17] = 150;
						num26 = 127 - 42;
						array4[17] = (byte)num26;
						array4[17] = 194;
						array4[18] = 45;
						array4[18] = 165;
						array4[18] = 111;
						num26 = 199 - 66;
						array4[18] = (byte)num26;
						array4[18] = 96;
						array4[18] = 125;
						array4[19] = 110;
						num26 = 50 + 36;
						array4[19] = (byte)num26;
						num26 = 121 + 36;
						array4[19] = (byte)num26;
						array4[19] = 130;
						array4[19] = 44;
						array4[20] = 163;
						num26 = 34 + 63;
						array4[20] = (byte)num26;
						num26 = 0 + 79;
						array4[20] = (byte)num26;
						num26 = 137 - 45;
						array4[20] = (byte)num26;
						array4[20] = 198;
						num26 = 194 - 64;
						array4[21] = (byte)num26;
						array4[21] = 120;
						num26 = 129 - 43;
						array4[21] = (byte)num26;
						array4[21] = 243;
						num26 = 7 + 120;
						array4[22] = (byte)num26;
						array4[22] = 145;
						num26 = 82 + 88;
						array4[22] = (byte)num26;
						num26 = 81 + 70;
						array4[22] = (byte)num26;
						num26 = 112 + 10;
						array4[23] = (byte)num26;
						num26 = 80 + 29;
						array4[23] = (byte)num26;
						array4[23] = 148;
						array4[23] = 162;
						array4[23] = 155;
						num26 = 119 - 43;
						array4[23] = (byte)num26;
						num26 = 247 - 82;
						array4[24] = (byte)num26;
						array4[24] = 114;
						num26 = 76 + 17;
						array4[24] = (byte)num26;
						array4[24] = 168;
						array4[24] = 70;
						num26 = 99 + 70;
						array4[25] = (byte)num26;
						num26 = 235 - 78;
						array4[25] = (byte)num26;
						array4[25] = 169;
						array4[25] = 202;
						array4[26] = 86;
						num26 = 84 + 9;
						array4[26] = (byte)num26;
						array4[26] = 170;
						num26 = 242 - 80;
						array4[26] = (byte)num26;
						array4[26] = 99;
						num26 = 40 + 26;
						array4[27] = (byte)num26;
						num26 = 134 - 44;
						array4[27] = (byte)num26;
						array4[27] = 153;
						num26 = 33 + 66;
						array4[27] = (byte)num26;
						array4[27] = 96;
						array4[27] = 174;
						array4[28] = 135;
						array4[28] = 128;
						num26 = 220 - 99;
						array4[28] = (byte)num26;
						num26 = 165 - 55;
						array4[29] = (byte)num26;
						array4[29] = 146;
						array4[29] = 117;
						array4[29] = 120;
						array4[29] = 85;
						array4[30] = 62;
						num26 = 240 - 80;
						array4[30] = (byte)num26;
						array4[30] = 101;
						array4[30] = 92;
						array4[31] = 83;
						array4[31] = 115;
						array4[31] = 93;
						array4[31] = 38;
						array4[31] = 47;
						byte[] array5 = array4;
						byte[] array6 = new byte[16];
						int num27 = 10 + 77;
						array6[0] = (byte)num27;
						array6[0] = 190;
						num27 = 0 + 23;
						array6[0] = (byte)num27;
						num27 = 137 - 78;
						array6[0] = (byte)num27;
						array6[1] = 231;
						num27 = 225 - 75;
						array6[1] = (byte)num27;
						array6[1] = 164;
						array6[1] = 163;
						array6[1] = 126;
						array6[2] = 83;
						array6[2] = 100;
						num27 = 153 - 51;
						array6[2] = (byte)num27;
						num27 = 147 - 110;
						array6[2] = (byte)num27;
						array6[3] = 100;
						array6[3] = 224;
						array6[3] = 189;
						array6[3] = 16;
						array6[4] = 137;
						num27 = 199 - 66;
						array6[4] = (byte)num27;
						num27 = 201 - 67;
						array6[4] = (byte)num27;
						array6[4] = 126;
						array6[4] = 168;
						array6[4] = 251;
						num27 = 109 + 18;
						array6[5] = (byte)num27;
						array6[5] = 112;
						num27 = 14 + 122;
						array6[5] = (byte)num27;
						array6[5] = 103;
						array6[6] = 164;
						num27 = 164 - 54;
						array6[6] = (byte)num27;
						array6[6] = 104;
						array6[6] = 71;
						array6[6] = 153;
						num27 = 222 - 74;
						array6[7] = (byte)num27;
						num27 = 220 - 73;
						array6[7] = (byte)num27;
						array6[7] = 62;
						array6[7] = 104;
						num27 = 96 + 48;
						array6[7] = (byte)num27;
						num27 = 121 + 18;
						array6[8] = (byte)num27;
						array6[8] = 160;
						array6[8] = 173;
						num27 = 149 - 49;
						array6[8] = (byte)num27;
						array6[8] = 74;
						num27 = 24 + 76;
						array6[9] = (byte)num27;
						num27 = 141 - 47;
						array6[9] = (byte)num27;
						array6[9] = 156;
						array6[10] = 160;
						array6[10] = 138;
						num27 = 63 + 85;
						array6[10] = (byte)num27;
						num27 = 83 + 113;
						array6[10] = (byte)num27;
						num27 = 121 - 102;
						array6[10] = (byte)num27;
						num27 = 68 + 73;
						array6[11] = (byte)num27;
						num27 = 104 + 55;
						array6[11] = (byte)num27;
						num27 = 86 + 118;
						array6[11] = (byte)num27;
						num27 = 6 + 13;
						array6[11] = (byte)num27;
						num27 = 184 - 110;
						array6[11] = (byte)num27;
						num27 = 50 + 22;
						array6[12] = (byte)num27;
						array6[12] = 132;
						num27 = 175 - 58;
						array6[12] = (byte)num27;
						array6[12] = 114;
						num27 = 113 - 74;
						array6[12] = (byte)num27;
						num27 = 119 + 80;
						array6[13] = (byte)num27;
						array6[13] = 89;
						array6[13] = 132;
						num27 = 181 - 60;
						array6[13] = (byte)num27;
						num27 = 39 + 110;
						array6[13] = (byte)num27;
						array6[14] = 50;
						num27 = 6 + 17;
						array6[14] = (byte)num27;
						array6[14] = 100;
						array6[14] = 130;
						array6[14] = 175;
						array6[15] = 85;
						num27 = 175 - 58;
						array6[15] = (byte)num27;
						array6[15] = 164;
						num27 = 170 - 56;
						array6[15] = (byte)num27;
						num27 = 116 + 59;
						array6[15] = (byte)num27;
						num27 = 191 - 98;
						array6[15] = (byte)num27;
						byte[] array7 = array6;
						object obj4 = LqiG0ALP2WgK74Q6rLEg();
						p07dU5LPH08REDdJvpwq(obj4, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)vey1GGLPfVaow7Xn5CqF(obj4, array5, array7);
						Stream stream = (Stream)dUi1JGLP9uyijrHuwVb2();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						BSg7wZLPnu74DHcI6JcC(cryptoStream, array3, 0, array3.Length);
						SaL6dILPGyevnQ4OKf59(cryptoStream);
						wN0hb3LPB6xqacCwscEG(paGLZRR3oYN, cWOcqsLPv8NqBFdtnnOW(T4hnUOLPYEkBY8rCNyZW(), CvteYeLPoHQwvVPPQh7G(stream)));
						n1qvr3LPal4jAS9tcQ5T(stream);
						n1qvr3LPal4jAS9tcQ5T(cryptoStream);
						MmmHCBLPiuxQ5cnHjbtd(rFjo4ELVkSpcIZcFSLKW);
						int num28 = 0;
						if (u4gYTZLAmBEM7Ly1JU3S() != null)
						{
							num28 = 0;
						}
						switch (num28)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num29 = 1;
						if (u4gYTZLAmBEM7Ly1JU3S() == null)
						{
							num29 = 1;
						}
						while (true)
						{
							switch (num29)
							{
							case 1:
								flag = true;
								num29 = 0;
								if (!JBdLTHLAKNRhboBmXcAT())
								{
									num29 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 11;
				case 7:
				case 15:
					if (flag)
					{
						num2 = 20;
						continue;
					}
					flag = false;
					num2 = 1;
					if (!JBdLTHLAKNRhboBmXcAT())
					{
						num2 = 0;
					}
					continue;
				case 2:
					text2 = null;
					num2 = 5;
					continue;
				case 1:
					return;
				case 12:
					if (text == null)
					{
						num = 19;
						break;
					}
					goto case 6;
				case 19:
					return;
				case 18:
					if (paGLZRR3oYN != null)
					{
						num = 17;
						break;
					}
					goto default;
				case 16:
					return;
				case 8:
					try
					{
						if (binaryReader != null)
						{
							int num24 = 1;
							if (u4gYTZLAmBEM7Ly1JU3S() == null)
							{
								num24 = 1;
							}
							while (true)
							{
								switch (num24)
								{
								case 1:
									AJpcgILPXrcLxkNEhk2o(binaryReader);
									num24 = 0;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num24 = 0;
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
						int num25 = 0;
						if (u4gYTZLAmBEM7Ly1JU3S() != null)
						{
							num25 = 0;
						}
						switch (num25)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 4:
					Mks0idLAwYSI2e8Z2Nwp(true);
					num2 = 9;
					continue;
				case 22:
					flag = false;
					num2 = 19;
					if (u4gYTZLAmBEM7Ly1JU3S() == null)
					{
						num2 = 21;
					}
					continue;
				case 13:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num5 = 16;
						while (true)
						{
							IL_184a:
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								case 33:
									jmNS81LAu1e0WXHq7r9N(fileStream, 360L);
									num6 = 1;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 0;
									}
									continue;
								case 9:
									flag = !NUdX7ALPsLqoOtS7b9wk(paGLZRR3oYN, BUPaqNLPec177e5oVw8I(hashAlgorithm), text2, array2);
									num6 = 42;
									continue;
								case 7:
									num21 = CO2hdjLPka9xEjNa9RwV(binaryReader);
									num6 = 0;
									if (JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 0;
									}
									continue;
								default:
									jmNS81LAu1e0WXHq7r9N(fileStream, num21);
									num6 = 4;
									continue;
								case 45:
									if (num19 < num20)
									{
										num6 = 15;
										continue;
									}
									goto case 19;
								case 2:
									if (num18 >= num17)
									{
										num6 = 20;
										continue;
									}
									goto case 44;
								case 32:
									array = new byte[65536];
									num6 = 13;
									continue;
								case 19:
									if (num19 < num20)
									{
										num5 = 43;
										break;
									}
									goto case 30;
								case 15:
									num18 = (uint)(num20 - num19);
									num6 = 2;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 1;
									}
									continue;
								case 21:
								{
									uint num15 = CO2hdjLPka9xEjNa9RwV(binaryReader);
									num16 = CO2hdjLPka9xEjNa9RwV(binaryReader);
									num14 = yhZ3HgLP1Rhjkx1IiePs(num15, num10, num9, binaryReader);
									num6 = 31;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 1;
									}
									continue;
								}
								case 23:
								case 37:
									jmNS81LAu1e0WXHq7r9N(fileStream, num9 + num12 * 40 + 16);
									num6 = 17;
									continue;
								case 5:
									cxn8TGLPSSiMnYJPSuCy(hashAlgorithm, new byte[0], 0, 0);
									num6 = 3;
									continue;
								case 20:
								case 25:
								case 34:
									num12++;
									num6 = 28;
									continue;
								case 12:
									jmNS81LAu1e0WXHq7r9N(fileStream, num13 + 32);
									num6 = 21;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 21;
									}
									continue;
								case 6:
								case 10:
									jmNS81LAu1e0WXHq7r9N(fileStream, 376L);
									num6 = 27;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 7;
									}
									continue;
								case 24:
								case 43:
									num22 = (uint)knSpxsLP57OLpgktjyml(num14 - num19, num17);
									num6 = 29;
									if (!JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 16;
									}
									continue;
								case 11:
									array2 = (byte[])O2tVCALPxcXZgnbjI24t(binaryReader, (int)num16);
									num6 = 9;
									if (u4gYTZLAmBEM7Ly1JU3S() == null)
									{
										num6 = 14;
									}
									continue;
								case 29:
									jfJa7YLPlgwcDHojQauN(hashAlgorithm, fileStream, num22, array);
									num6 = 46;
									continue;
								case 14:
									Q6gbMGLPL4nogsrydurg(array2);
									num5 = 9;
									break;
								case 17:
									num17 = CO2hdjLPka9xEjNa9RwV(binaryReader);
									num6 = 7;
									continue;
								case 31:
									num20 = num14 + num16;
									num6 = 6;
									if (u4gYTZLAmBEM7Ly1JU3S() == null)
									{
										num6 = 36;
									}
									continue;
								case 46:
									num17 -= num22;
									num6 = 40;
									if (u4gYTZLAmBEM7Ly1JU3S() != null)
									{
										num6 = 29;
									}
									continue;
								case 44:
									num17 -= num18;
									num6 = 41;
									continue;
								case 16:
									binaryReader = new BinaryReader(fileStream);
									num6 = 32;
									continue;
								case 28:
								case 35:
									if (num12 < num10)
									{
										num6 = 37;
										continue;
									}
									goto case 5;
								case 4:
								case 39:
								case 40:
									if (num17 != 0)
									{
										num6 = 22;
										continue;
									}
									goto case 20;
								case 18:
								case 22:
									num19 = uplESqLPNTloH8wA0bOY(fileStream);
									num6 = 26;
									continue;
								case 13:
									jfJa7YLPlgwcDHojQauN(hashAlgorithm, fileStream, 152u, array);
									num6 = 8;
									continue;
								case 36:
									jmNS81LAu1e0WXHq7r9N(fileStream, num11);
									num6 = 38;
									continue;
								case 26:
									if (num14 <= num19)
									{
										num6 = 36;
										if (JBdLTHLAKNRhboBmXcAT())
										{
											num6 = 45;
										}
										continue;
									}
									goto case 19;
								case 41:
									jmNS81LAu1e0WXHq7r9N(fileStream, uplESqLPNTloH8wA0bOY(fileStream) + num18);
									num6 = 39;
									continue;
								case 1:
								case 27:
									num13 = yhZ3HgLP1Rhjkx1IiePs(CO2hdjLPka9xEjNa9RwV(binaryReader), num10, num9, binaryReader);
									num5 = 12;
									break;
								case 38:
									num12 = 0;
									num6 = 11;
									if (JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 35;
									}
									continue;
								case 3:
									jmNS81LAu1e0WXHq7r9N(fileStream, num14);
									num6 = 7;
									if (JBdLTHLAKNRhboBmXcAT())
									{
										num6 = 11;
									}
									continue;
								case 30:
									jfJa7YLPlgwcDHojQauN(hashAlgorithm, fileStream, num17, array);
									num5 = 34;
									break;
								case 8:
								{
									bool num7 = TU4KtOLP4TmRCItT0IgG(binaryReader) != 523;
									int num8 = (num7 ? 96 : 112);
									jmNS81LAu1e0WXHq7r9N(fileStream, 152L);
									MX2sLnLPDs4l29KQHFSe(fileStream, array, 0, num8);
									array[64] = 0;
									array[65] = 0;
									array[66] = 0;
									array[67] = 0;
									XraJaxLPbCuvlm1SmkJE(hashAlgorithm, array, 0, num8);
									MX2sLnLPDs4l29KQHFSe(fileStream, array, 0, 128);
									array[32] = 0;
									array[33] = 0;
									array[34] = 0;
									array[35] = 0;
									array[36] = 0;
									array[37] = 0;
									array[38] = 0;
									array[39] = 0;
									XraJaxLPbCuvlm1SmkJE(hashAlgorithm, array, 0, 128);
									num9 = uplESqLPNTloH8wA0bOY(fileStream);
									jmNS81LAu1e0WXHq7r9N(fileStream, 134L);
									num10 = TU4KtOLP4TmRCItT0IgG(binaryReader);
									jmNS81LAu1e0WXHq7r9N(fileStream, num9);
									jfJa7YLPlgwcDHojQauN(hashAlgorithm, fileStream, (uint)(num10 * 40), array);
									num11 = uplESqLPNTloH8wA0bOY(fileStream);
									if (!num7)
									{
										num6 = 1;
										if (u4gYTZLAmBEM7Ly1JU3S() == null)
										{
											num6 = 6;
										}
										continue;
									}
									goto case 33;
								}
								case 42:
									goto end_IL_184e;
								}
								goto IL_184a;
								continue;
								end_IL_184e:
								break;
							}
							break;
						}
					}
					catch
					{
						int num23 = 0;
						if (u4gYTZLAmBEM7Ly1JU3S() != null)
						{
							num23 = 0;
						}
						while (true)
						{
							switch (num23)
							{
							default:
								flag = true;
								num23 = 0;
								if (JBdLTHLAKNRhboBmXcAT())
								{
									num23 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 3;
				case 14:
					text = (string)vNyy4NLA8aQWHduT4opQ(qFMnDvLA79qTOC6iwfsi(typeof(yVbruBLyqe9BOsO9Yb5E).TypeHandle).Assembly);
					num2 = 12;
					continue;
				case 10:
					binaryReader = null;
					num2 = 13;
					continue;
				case 20:
					throw new Exception((string)yUbthQLPESHMPUhvhUPY(qJBFqaLPjQ8uVxxCs5Ma(VygocXLPcwGSXApfT7BH(qFMnDvLA79qTOC6iwfsi(typeof(yVbruBLyqe9BOsO9Yb5E).TypeHandle).Assembly)), " is tampered."));
				case 3:
					num2 = 8;
					continue;
				case 5:
					try
					{
						hashAlgorithm = (HashAlgorithm)Ec1gceLAPgmXmh97OjZF();
						int num3 = 2;
						if (u4gYTZLAmBEM7Ly1JU3S() != null)
						{
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 2:
								text2 = (string)ge9dm5LAJ4lyxyH4ruTk("SHA1");
								num3 = 1;
								if (!JBdLTHLAKNRhboBmXcAT())
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							case 1:
								if (!TsxLcBLAFFSvo4ecGdKh(text))
								{
									return;
								}
								num3 = 0;
								if (JBdLTHLAKNRhboBmXcAT())
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							}
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (u4gYTZLAmBEM7Ly1JU3S() != null)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 22;
				case 9:
					paGLZRR3oYN = new RSACryptoServiceProvider();
					num2 = 11;
					if (u4gYTZLAmBEM7Ly1JU3S() == null)
					{
						num2 = 14;
					}
					continue;
				case 11:
					if (flag)
					{
						num = 7;
						break;
					}
					goto case 10;
				default:
					b1WG6ELAhPApqoT0jS43();
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	public static void p40LyA9jc4k(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (oRaLZ67KR0R == null)
			{
				lock (yfoLZMTbDDP)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554801)).Assembly.GetManifestResourceStream("OS74GyLydkREyUtt4xjS.3jjQ44Lyg8FY4t2Uuiec"));
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
							num3 += oqwLyFs1pcH(num3);
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
						rFjo4ELVkSpcIZcFSLKW rFjo4ELVkSpcIZcFSLKW = new rFjo4ELVkSpcIZcFSLKW(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = rFjo4ELVkSpcIZcFSLKW.fgbLVS4Zye4();
							int value = rFjo4ELVkSpcIZcFSLKW.fgbLVS4Zye4();
							dictionary.Add(key, value);
						}
						rFjo4ELVkSpcIZcFSLKW.dmkLVxnCryE();
					}
					oRaLZ67KR0R = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = oRaLZ67KR0R[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554801)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(16777237));
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

	private static uint popLyJ54ZWh(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint oqwLyFs1pcH(uint P_0)
	{
		return 0u;
	}

	internal static void RjGLy3WFj73()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void IDuLypToVWN(Stream P_0, int P_1)
	{
		ExUKb3LVz3XXXH6keC8K.PytLC9mFA8C(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string MyLLyuxXiJ7(int P_0)
	{
		if (yrGLZtwOG3R.Length == 0)
		{
			lbsLZI3Bf5x = new List<string>();
			hkVLZWZ9qk5 = new List<int>();
			IDuLypToVWN(pSTLZEPKX46.GetManifestResourceStream("GtThv9LySPjAij7jokEK.luw2C7Lyx0Y7rA6tlmSk"), P_0);
		}
		if (KrJLZOFbho9 < 75)
		{
			if (pSTLZEPKX46 != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			KrJLZOFbho9++;
		}
		lock (lI8LZqqEYv2)
		{
			int num = BitConverter.ToInt32(yrGLZtwOG3R, P_0);
			if (num < hkVLZWZ9qk5.Count && hkVLZWZ9qk5[num] == P_0)
			{
				return lbsLZI3Bf5x[num];
			}
			try
			{
				tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
				byte[] array = new byte[num];
				Array.Copy(yrGLZtwOG3R, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				lbsLZI3Bf5x.Add(text);
				hkVLZWZ9qk5.Add(P_0);
				Array.Copy(BitConverter.GetBytes(lbsLZI3Bf5x.Count - 1), 0, yrGLZtwOG3R, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string rQdLyzIMZSZ(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int jhlLZ04sNmA()
	{
		return 5;
	}

	private static void cRpLZ2BdkQR()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate DZdLZHuru09(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(16777370)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(16777277)),
			Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(16777252))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object OArLZfacpd7(object P_0)
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
	public static extern IntPtr BgdLZ9QXm8r(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr u8hLZnCEYYE(IntPtr P_0, string P_1);

	private static IntPtr BUHLZGo7NKV(IntPtr P_0, string P_1, uint P_2)
	{
		if (pBeLZzgm50c == null)
		{
			pBeLZzgm50c = (fwWAr1LVeNSqE7BuKrgX)Marshal.GetDelegateForFunctionPointer(u8hLZnCEYYE(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554810)));
		}
		return pBeLZzgm50c(P_0, P_1, P_2);
	}

	private static IntPtr RiXLZYVl5Z1(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (vZYLV013r9p == null)
		{
			vZYLV013r9p = (aXyoYaLVssG5dhqRWs0y)Marshal.GetDelegateForFunctionPointer(u8hLZnCEYYE(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554811)));
		}
		return vZYLV013r9p(P_0, P_1, P_2, P_3);
	}

	private static int RZGLZoNuDdq(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (CCVLV2iW9uK == null)
		{
			CCVLV2iW9uK = (YcCF98LVX204NsPKuN71)Marshal.GetDelegateForFunctionPointer(u8hLZnCEYYE(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554812)));
		}
		return CCVLV2iW9uK(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int vnOLZvkm6I1(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (xMVLVHIio89 == null)
		{
			xMVLVHIio89 = (heFPQeLVceFm48tGJFoL)Marshal.GetDelegateForFunctionPointer(u8hLZnCEYYE(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554813)));
		}
		return xMVLVHIio89(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr PTyLZBEI8Er(uint P_0, int P_1, uint P_2)
	{
		if (UksLVffuen9 == null)
		{
			UksLVffuen9 = (mE0wC4LVj761vmQRqkcP)Marshal.GetDelegateForFunctionPointer(u8hLZnCEYYE(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554814)));
		}
		return UksLVffuen9(P_0, P_1, P_2);
	}

	private static int YHLLZanv826(IntPtr P_0)
	{
		if (wMsLV9fYFmJ == null)
		{
			wMsLV9fYFmJ = (yOJMkvLVEQnKFNvtOFsv)Marshal.GetDelegateForFunctionPointer(u8hLZnCEYYE(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554815)));
		}
		return wMsLV9fYFmJ(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (MetLVnSvGHO == IntPtr.Zero)
		{
			MetLVnSvGHO = BgdLZ9QXm8r("kernel ".Trim() + "32.dll");
		}
		return MetLVnSvGHO;
	}

	private static byte[] hVQLZi9LLSu(string P_0)
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

	internal static Stream hFNLZlLYtCx()
	{
		return new MemoryStream();
	}

	internal static byte[] OefLZ4CNq40(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] cJLLZDh9YBV(byte[] P_0)
	{
		Stream stream = hFNLZlLYtCx();
		SymmetricAlgorithm symmetricAlgorithm = IY1LyrngXlH();
		symmetricAlgorithm.Key = new byte[32]
		{
			170, 12, 185, 242, 204, 112, 239, 163, 117, 57,
			8, 94, 85, 74, 146, 198, 100, 244, 211, 131,
			121, 94, 244, 23, 71, 168, 24, 209, 60, 178,
			83, 133
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			109, 18, 16, 130, 63, 199, 41, 253, 8, 117,
			110, 249, 113, 194, 216, 127
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = OefLZ4CNq40(stream);
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		return result;
	}

	private unsafe static int RhlLZbkkJyp(string P_0)
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

	internal static bool WqlLZNkjy3E(string P_0, string P_1)
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
		if (P_0.StartsWith(U4xLVGc2XMI))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(U4xLVGc2XMI))
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
			num = RhlLZbkkJyp(P_0);
		}
		if (!flag2)
		{
			num2 = RhlLZbkkJyp(P_1);
		}
		return num == num2;
	}

	private byte[] AhFLZkZ6yxO()
	{
		return null;
	}

	private byte[] kxeLZ1UBlVI()
	{
		return null;
	}

	private byte[] yqcLZ5bBNu7()
	{
		return null;
	}

	private byte[] VdtLZSBqwKK()
	{
		return null;
	}

	private byte[] ywcLZx29iA5()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] FkeLZLZ0Oe4()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] NJ7LZecbMHy()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] YaLLZsgdRP1()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] aBYLZXkqCR4()
	{
		return null;
	}

	internal byte[] ouLLZcLiMsu()
	{
		return null;
	}

	internal static object fiT27TLAQyJ2HjV7fcVs(object P_0)
	{
		return ((rFjo4ELVkSpcIZcFSLKW)P_0).m9OIO8Q0EK();
	}

	internal static void bJ29NsLAdgDTiwWm6ijp(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long TN1pFpLAg7yA8QAKXLje(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object Vas8nLLARBUTgQv8HCfZ(object P_0, int P_1)
	{
		return ((rFjo4ELVkSpcIZcFSLKW)P_0).GfnLV1rmaDJ(P_1);
	}

	internal static void EYOS53LA6k0p2H2TUw4S(object P_0)
	{
		((rFjo4ELVkSpcIZcFSLKW)P_0).dmkLVxnCryE();
	}

	internal static void i0SYU4LAM7mbvPCkB2JZ(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object RQMq0fLAOSWJX8JK1pbu(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object IM1WveLAqmEkxfQhS8oZ(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object fEIuEULAIIKWLeVI8jVo()
	{
		return IY1LyrngXlH();
	}

	internal static void E4O1ICLAWluLTOYJerVy(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object X1wYvhLAt51V4DdOYOZJ(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object pgLr6DLAU7j8VM6K7Ph7()
	{
		return hFNLZlLYtCx();
	}

	internal static void wKMioeLATPIDQnYbeiHn(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void D8jOUaLAyDrrYKj2FJV9(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object fa4lThLAZooLhCkhGmpx(object P_0)
	{
		return OefLZ4CNq40((Stream)P_0);
	}

	internal static void X3Gw7MLAVsOZM6Qxkbms(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object ceQw02LAC1PhvcJW16tX(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool c9QygsLArFV5JhEmGk3P(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool foV5yGLAjtwpuit0FqnQ()
	{
		return (object)null == null;
	}

	internal static object Rk0dA1LAEwa3busyeQCN()
	{
		return null;
	}

	internal static void b1WG6ELAhPApqoT0jS43()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void Mks0idLAwYSI2e8Z2Nwp(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type qFMnDvLA79qTOC6iwfsi(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object vNyy4NLA8aQWHduT4opQ(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int SD0ijMLAAGph8gG9Fr8K(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object Ec1gceLAPgmXmh97OjZF()
	{
		return SHA1.Create();
	}

	internal static object ge9dm5LAJ4lyxyH4ruTk(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool TsxLcBLAFFSvo4ecGdKh(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object fBiQPMLA3GS1Oh1ydTxv(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object KccvYsLApoqbdZODolxK(object P_0)
	{
		return ((rFjo4ELVkSpcIZcFSLKW)P_0).m9OIO8Q0EK();
	}

	internal static void jmNS81LAu1e0WXHq7r9N(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long wPT1sXLAze8UIHd5Xny8(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object Y4K3QbLP0j8EQfNlT84C(object P_0, int P_1)
	{
		return ((rFjo4ELVkSpcIZcFSLKW)P_0).GfnLV1rmaDJ(P_1);
	}

	internal static object LqiG0ALP2WgK74Q6rLEg()
	{
		return IY1LyrngXlH();
	}

	internal static void p07dU5LPH08REDdJvpwq(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object vey1GGLPfVaow7Xn5CqF(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object dUi1JGLP9uyijrHuwVb2()
	{
		return hFNLZlLYtCx();
	}

	internal static void BSg7wZLPnu74DHcI6JcC(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void SaL6dILPGyevnQ4OKf59(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object T4hnUOLPYEkBY8rCNyZW()
	{
		return Encoding.UTF8;
	}

	internal static object CvteYeLPoHQwvVPPQh7G(object P_0)
	{
		return OefLZ4CNq40((Stream)P_0);
	}

	internal static object cWOcqsLPv8NqBFdtnnOW(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void wN0hb3LPB6xqacCwscEG(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void n1qvr3LPal4jAS9tcQ5T(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void MmmHCBLPiuxQ5cnHjbtd(object P_0)
	{
		((rFjo4ELVkSpcIZcFSLKW)P_0).dmkLVxnCryE();
	}

	internal static void jfJa7YLPlgwcDHojQauN(object P_0, object P_1, uint P_2, object P_3)
	{
		NK0Lyhx5U6d((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort TU4KtOLP4TmRCItT0IgG(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int MX2sLnLPDs4l29KQHFSe(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void XraJaxLPbCuvlm1SmkJE(object P_0, object P_1, int P_2, int P_3)
	{
		hkjLywlDVuT((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long uplESqLPNTloH8wA0bOY(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint CO2hdjLPka9xEjNa9RwV(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint yhZ3HgLP1Rhjkx1IiePs(uint P_0, int P_1, long P_2, object P_3)
	{
		return vLVLy7p3F2c(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long knSpxsLP57OLpgktjyml(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object cxn8TGLPSSiMnYJPSuCy(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object O2tVCALPxcXZgnbjI24t(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void Q6gbMGLPL4nogsrydurg(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object BUPaqNLPec177e5oVw8I(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool NUdX7ALPsLqoOtS7b9wk(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void AJpcgILPXrcLxkNEhk2o(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object VygocXLPcwGSXApfT7BH(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object qJBFqaLPjQ8uVxxCs5Ma(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object yUbthQLPESHMPUhvhUPY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool JBdLTHLAKNRhboBmXcAT()
	{
		return (object)null == null;
	}

	internal static object u4gYTZLAmBEM7Ly1JU3S()
	{
		return null;
	}
}
