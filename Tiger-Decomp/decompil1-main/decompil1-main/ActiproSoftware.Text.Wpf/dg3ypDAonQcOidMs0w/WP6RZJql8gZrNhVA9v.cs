using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using rE4lpnT863QnijKQK5;

namespace dg3ypDAonQcOidMs0w;

internal class WP6RZJql8gZrNhVA9v
{
	private delegate void gK(object o);

	internal class RJDcsuMfOxrTCYImPe : Attribute
	{
		internal class iGR41459RDH4FvPdNk<T>
		{
			internal static object lZ9;

			public iGR41459RDH4FvPdNk()
			{
				hHEYokUTtehNq5ji0d.BN1hJz();
				base._002Ector();
			}

			internal static bool BZ8()
			{
				return lZ9 == null;
			}

			internal static object tZL()
			{
				return lZ9;
			}
		}

		[RJDcsuMfOxrTCYImPe(typeof(iGR41459RDH4FvPdNk<object>[]))]
		public RJDcsuMfOxrTCYImPe(object P_0)
		{
		}
	}

	internal class qcBC7nbplYPB6DW0yw
	{
		[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
		internal static string G9skPDgcXb(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = XEDoeIU7mj(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint QZEOeHRUkDiNqCWT0p(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr vk();

	internal struct BIpvxRBRb2dOGl802m
	{
		internal bool JDNkifbo3S;

		internal byte[] jsbkrdexts;
	}

	internal class VtNVUKGulysZw81C3E
	{
		private BinaryReader b7V;

		public VtNVUKGulysZw81C3E(Stream P_0)
		{
			b7V = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return b7V.BaseStream;
		}

		internal byte[] B2XkaLi4dH(int P_0)
		{
			return b7V.ReadBytes(P_0);
		}

		internal int hx5kqNgSj4(byte[] P_0, int P_1, int P_2)
		{
			return b7V.Read(P_0, P_1, P_2);
		}

		internal int TVtkAMaqpL()
		{
			return b7V.ReadInt32();
		}

		internal void VDqkQKyKML()
		{
			b7V.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr oE(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr vr(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int R3(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int SJ(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr hX(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int fN(IntPtr ptr);

	[Flags]
	private enum tR
	{

	}

	private static byte[] TI5;

	private static object BIZ;

	private static byte[] HI0;

	private static int XI4;

	private static bool LIK;

	private static long AIr;

	internal static QZEOeHRUkDiNqCWT0p abxkLGOVrU;

	private static bool OIX;

	private static bool YIN;

	private static IntPtr cIf;

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static bool QIt;

	private static fN CIz;

	private static IntPtr R7S;

	private static hX VIy;

	private static int CIR;

	private static int[] AI1;

	private static R3 lIG;

	private static Dictionary<int, int> hI6;

	internal static Hashtable lmdkVksVkh;

	private static SortedList SIk;

	private static uint[] JIl;

	private static IntPtr tIY;

	private static long BI3;

	private static vr WIn;

	private static bool SIW;

	private static bool GIi;

	private static bool dIO;

	internal static QZEOeHRUkDiNqCWT0p rNZkehfwNu;

	private static int IIJ;

	private static SJ LIe;

	private static int OIE;

	private static oE tIQ;

	internal static Assembly x4Dk2IHVmX;

	private static IntPtr VIo;

	private static object uID;

	internal static RSACryptoServiceProvider onZkkIlVOi;

	private static byte[] xIv;

	static WP6RZJql8gZrNhVA9v()
	{
		dIO = false;
		x4Dk2IHVmX = typeof(WP6RZJql8gZrNhVA9v).Assembly;
		JIl = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		GIi = false;
		SIW = false;
		TI5 = new byte[0];
		onZkkIlVOi = null;
		hI6 = null;
		BIZ = new object();
		HI0 = new byte[0];
		xIv = new byte[0];
		tIY = IntPtr.Zero;
		VIo = IntPtr.Zero;
		uID = new string[0];
		AI1 = new int[0];
		XI4 = 1;
		LIK = false;
		SIk = new SortedList();
		OIE = 0;
		AIr = 0L;
		abxkLGOVrU = null;
		rNZkehfwNu = null;
		BI3 = 0L;
		IIJ = 0;
		OIX = false;
		YIN = false;
		CIR = 0;
		cIf = IntPtr.Zero;
		QIt = false;
		lmdkVksVkh = new Hashtable();
		tIQ = null;
		WIn = null;
		lIG = null;
		LIe = null;
		VIy = null;
		CIz = null;
		R7S = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void LN1hJj()
	{
	}

	internal static byte[] ab9oDe4UH3(byte[] P_0)
	{
		uint[] array = new uint[16];
		int num = 448 - P_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(P_0.Length + num2 / 8 + 8);
		ulong num4 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num3];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint num7 = 1732584193u;
		uint num8 = 4023233417u;
		uint num9 = 2562383102u;
		uint num10 = 271733878u;
		for (uint num11 = 0u; num11 < num6 / 16; num11++)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0u; num13 < 61; num13 += 4)
			{
				array[num13 >> 2] = (uint)((array2[num12 + (num13 + 3)] << 24) | (array2[num12 + (num13 + 2)] << 16) | (array2[num12 + (num13 + 1)] << 8) | array2[num12 + num13]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			II8(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			II8(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			II8(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			II8(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			II8(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			II8(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			II8(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			II8(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			II8(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			II8(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			II8(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			II8(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			II8(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			II8(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			II8(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			II8(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			dIT(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			dIT(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			dIT(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			dIT(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			dIT(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			dIT(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			dIT(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			dIT(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			dIT(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			dIT(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			dIT(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			dIT(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			dIT(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			dIT(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			dIT(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			dIT(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			iI2(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			iI2(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			iI2(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			iI2(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			iI2(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			iI2(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			iI2(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			iI2(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			iI2(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			iI2(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			iI2(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			iI2(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			iI2(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			iI2(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			iI2(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			iI2(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			fIm(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			fIm(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			fIm(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			fIm(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			fIm(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			fIm(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			fIm(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			fIm(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			fIm(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			fIm(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			fIm(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			fIm(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			fIm(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			fIm(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			fIm(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			fIm(ref num8, num9, num10, num7, 9u, 21, 64u, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array3, 12, 4);
		return array3;
	}

	private static void II8(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + mIc(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + JIl[P_6 - 1], P_5);
	}

	private static void dIT(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + mIc(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + JIl[P_6 - 1], P_5);
	}

	private static void iI2(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + mIc(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + JIl[P_6 - 1], P_5);
	}

	private static void fIm(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + mIc(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + JIl[P_6 - 1], P_5);
	}

	private static uint mIc(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool gX8onkMSd7()
	{
		if (!GIi)
		{
			XS8oLZGMXn();
			GIi = true;
		}
		return SIW;
	}

	internal static SymmetricAlgorithm PEXoCqmS4w()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (gX8onkMSd7())
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

	internal static void XS8oLZGMXn()
	{
		try
		{
			SIW = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] XEDoeIU7mj(byte[] P_0)
	{
		if (!gX8onkMSd7())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return ab9oDe4UH3(P_0);
	}

	internal static void vBuojdip3i(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			NSmolmd79S(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void NSmolmd79S(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint SDQoufkqT0(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	public static void TAJo1U8fio(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (hI6 == null)
			{
				lock (BIZ)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(WP6RZJql8gZrNhVA9v).Assembly.GetManifestResourceStream("C2ce2yKBvSeJJu4Rpi.buU5cZfaslhIXXBktA"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
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
							num3 += UIL(num3);
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
						VtNVUKGulysZw81C3E vtNVUKGulysZw81C3E = new VtNVUKGulysZw81C3E(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = vtNVUKGulysZw81C3E.TVtkAMaqpL();
							int value = vtNVUKGulysZw81C3E.TVtkAMaqpL();
							dictionary.Add(key, value);
						}
						vtNVUKGulysZw81C3E.VDqkQKyKML();
					}
					hI6 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = hI6[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(WP6RZJql8gZrNhVA9v).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = typeof(object);
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
		}
		catch (Exception)
		{
		}
	}

	private static uint oId(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint UIL(uint P_0)
	{
		return 0u;
	}

	internal static void w65ov7siki()
	{
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string L3hoFlcqP6(int P_0)
	{
		int num = 54;
		byte[] array2 = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array5 = default(byte[]);
		int num25 = default(int);
		int num20 = default(int);
		byte[] array3 = default(byte[]);
		int num22 = default(int);
		int num26 = default(int);
		uint num4 = default(uint);
		uint num27 = default(uint);
		int num21 = default(int);
		int count = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num42 = default(int);
		string result = default(string);
		int num44 = default(int);
		uint num39 = default(uint);
		Stream stream = default(Stream);
		int num32 = default(int);
		uint num23 = default(uint);
		byte[] array = default(byte[]);
		VtNVUKGulysZw81C3E vtNVUKGulysZw81C3E = default(VtNVUKGulysZw81C3E);
		int num36 = default(int);
		int num34 = default(int);
		int num38 = default(int);
		int num30 = default(int);
		int num33 = default(int);
		byte[] publicKeyToken = default(byte[]);
		int num28 = default(int);
		uint num29 = default(uint);
		int num24 = default(int);
		uint num35 = default(uint);
		uint num37 = default(uint);
		int num31 = default(int);
		uint num40 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 375:
					array2[6] = 104;
					num2 = 376;
					continue;
				case 271:
					cryptoStream.Close();
					num2 = 396;
					continue;
				case 79:
					HI0 = array5;
					num2 = 55;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 168:
					if (num25 > 0)
					{
						num2 = 186;
						continue;
					}
					goto case 238;
				case 144:
					array2[15] = (byte)num20;
					num2 = 4;
					if (J6() != null)
					{
						num2 = 3;
					}
					continue;
				case 169:
					array3[30] = (byte)num22;
					num2 = 125;
					if (J6() == null)
					{
						num2 = 213;
					}
					continue;
				case 366:
					array2[13] = (byte)num26;
					num2 = 192;
					if (J6() == null)
					{
						num2 = 273;
					}
					continue;
				case 30:
					array3 = new byte[32];
					num2 = 425;
					continue;
				case 2:
				case 188:
					num4 = num27;
					num2 = 253;
					continue;
				case 426:
					num21 = 198 - 99;
					num2 = 139;
					continue;
				case 260:
					array3[25] = 118;
					num2 = 392;
					if (!sq())
					{
						num2 = 7;
					}
					continue;
				case 46:
					array3[27] = 56;
					num2 = 246;
					continue;
				case 19:
					array3[20] = (byte)num22;
					num2 = 422;
					continue;
				case 71:
					num22 = 104 + 68;
					num2 = 75;
					if (sq())
					{
						num2 = 247;
					}
					continue;
				case 315:
					array3[5] = (byte)num21;
					num2 = 27;
					if (sq())
					{
						continue;
					}
					break;
				case 167:
					array3[14] = (byte)num21;
					num2 = 250;
					continue;
				case 145:
					num21 = 31 + 41;
					num = 320;
					break;
				case 328:
					array3[11] = (byte)num22;
					num2 = 68;
					continue;
				case 91:
					num21 = 200 - 66;
					num2 = 333;
					continue;
				case 232:
					num21 = 126 - 104;
					num2 = 315;
					if (J6() != null)
					{
						num2 = 194;
					}
					continue;
				case 29:
					num26 = 205 - 68;
					num2 = 112;
					if (J6() == null)
					{
						num2 = 166;
					}
					continue;
				case 410:
					array3[21] = 20;
					num2 = 389;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 166:
					array2[3] = (byte)num26;
					num2 = 182;
					continue;
				case 159:
					array3[12] = 155;
					num2 = 103;
					if (J6() == null)
					{
						num2 = 394;
					}
					continue;
				case 53:
				case 55:
					count = BitConverter.ToInt32(HI0, P_0);
					num2 = 194;
					continue;
				case 368:
					return "";
				case 399:
					array3[26] = (byte)num22;
					num2 = 240;
					if (J6() == null)
					{
						num2 = 300;
					}
					continue;
				case 102:
					num26 = 130 - 43;
					num2 = 349;
					continue;
				case 303:
					transform = symmetricAlgorithm.CreateDecryptor(array6, array4);
					num2 = 170;
					continue;
				case 204:
					array2[4] = (byte)num26;
					num2 = 387;
					continue;
				case 194:
					try
					{
						hHEYokUTtehNq5ji0d.BN1hJz();
						int num41 = 0;
						if (!sq())
						{
							goto IL_0a82;
						}
						goto IL_0a86;
						IL_0a82:
						num41 = num42;
						goto IL_0a86;
						IL_0a86:
						do
						{
							switch (num41)
							{
							case 1:
								return result;
							}
							result = Encoding.Unicode.GetString(HI0, P_0 + 4, count);
							num41 = 1;
						}
						while (J6() == null);
						goto IL_0a82;
					}
					catch
					{
						int num43 = 0;
						if (!sq())
						{
							num43 = num44;
						}
						switch (num43)
						{
						case 0:
							break;
						}
					}
					goto case 368;
				case 300:
					num22 = 71 - 29;
					num2 = 220;
					if (sq())
					{
						continue;
					}
					break;
				case 408:
					num39 = 0u;
					num2 = 47;
					continue;
				case 90:
					array3[19] = 114;
					num2 = 244;
					continue;
				case 406:
					num27 = 0u;
					num2 = 408;
					continue;
				case 258:
					num21 = 172 - 57;
					num2 = 206;
					continue;
				case 209:
					array2[5] = (byte)num26;
					num2 = 240;
					continue;
				case 189:
					array2[13] = 205;
					num2 = 87;
					if (J6() == null)
					{
						num2 = 134;
					}
					continue;
				case 72:
					num27 += num39;
					num = 187;
					break;
				case 137:
					array3[18] = 150;
					num = 241;
					break;
				case 27:
					array3[6] = 134;
					num2 = 201;
					if (sq())
					{
						continue;
					}
					break;
				case 151:
					array2[7] = 50;
					num2 = 317;
					continue;
				case 266:
					num22 = 62 + 56;
					num2 = 104;
					continue;
				case 125:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 369;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 402:
					array2[14] = 149;
					num2 = 61;
					if (sq())
					{
						num2 = 103;
					}
					continue;
				case 206:
					array3[17] = (byte)num21;
					num2 = 352;
					continue;
				case 99:
					num26 = 168 - 71;
					num2 = 204;
					continue;
				case 393:
					array3[4] = 230;
					num2 = 395;
					continue;
				case 225:
					array3[21] = (byte)num21;
					num2 = 410;
					if (sq())
					{
						continue;
					}
					break;
				case 296:
					array3[9] = 251;
					num = 106;
					break;
				case 123:
					if (num32 > 0)
					{
						num2 = 8;
						continue;
					}
					goto case 274;
				case 337:
					num23 = 0u;
					num2 = 370;
					continue;
				case 83:
					array3[18] = (byte)num21;
					num2 = 339;
					continue;
				case 254:
					array3[9] = 141;
					num2 = 198;
					continue;
				case 379:
					array3[27] = (byte)num21;
					num = 131;
					break;
				case 421:
					array2[11] = (byte)num20;
					num2 = 102;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 330:
					array2[12] = 91;
					num2 = 46;
					if (J6() == null)
					{
						num2 = 58;
					}
					continue;
				case 319:
					array3[24] = 91;
					num2 = 15;
					continue;
				case 255:
					num22 = 205 - 68;
					num2 = 372;
					if (J6() != null)
					{
						num2 = 2;
					}
					continue;
				case 341:
					array3[10] = 209;
					num = 118;
					break;
				case 41:
					array = vtNVUKGulysZw81C3E.B2XkaLi4dH((int)vtNVUKGulysZw81C3E.KDikMXewCI().Length);
					num = 119;
					break;
				case 274:
					num23 |= array[array.Length - (1 + num32)];
					num2 = 210;
					if (sq())
					{
						continue;
					}
					break;
				case 345:
					array2[15] = (byte)num20;
					num2 = 286;
					continue;
				case 48:
					array2[0] = 152;
					num2 = 114;
					continue;
				case 304:
					array3[15] = 136;
					num2 = 275;
					continue;
				case 57:
					array2[11] = (byte)num20;
					num2 = 257;
					continue;
				case 86:
				case 171:
					if (num36 >= array4.Length)
					{
						num2 = 122;
						continue;
					}
					goto case 109;
				case 170:
					stream = Njco6C1nc4();
					num2 = 125;
					if (!sq())
					{
						num2 = 90;
					}
					continue;
				case 113:
					num20 = 73 + 76;
					num2 = 421;
					continue;
				case 344:
					array3[16] = (byte)num22;
					num2 = 42;
					continue;
				case 417:
					num26 = 135 - 45;
					num2 = 21;
					continue;
				case 317:
					array2[8] = 126;
					num2 = 105;
					if (sq())
					{
						continue;
					}
					break;
				case 262:
					array3[10] = (byte)num22;
					num2 = 67;
					continue;
				case 242:
					array3[24] = (byte)num21;
					num2 = 363;
					continue;
				case 374:
					num22 = 60 + 23;
					num2 = 44;
					if (sq())
					{
						num2 = 282;
					}
					continue;
				case 114:
					array2[0] = 33;
					num2 = 272;
					continue;
				case 77:
					array3[7] = 149;
					num2 = 43;
					continue;
				case 34:
					array2[2] = (byte)num26;
					num2 = 88;
					continue;
				case 389:
					array3[22] = 105;
					num2 = 94;
					continue;
				case 20:
					array2[1] = 118;
					num2 = 63;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 117:
					array2 = new byte[16];
					num2 = 256;
					if (!sq())
					{
						num2 = 137;
					}
					continue;
				case 32:
					num22 = 101 + 90;
					num = 193;
					break;
				case 198:
					num21 = 150 - 50;
					num2 = 285;
					continue;
				case 104:
					array3[0] = (byte)num22;
					num2 = 261;
					if (sq())
					{
						continue;
					}
					break;
				case 112:
					array3[22] = (byte)num21;
					num2 = 364;
					if (sq())
					{
						continue;
					}
					break;
				case 318:
					num21 = 142 - 120;
					num = 73;
					break;
				case 31:
					num34 += 8;
					num2 = 9;
					if (J6() == null)
					{
						num2 = 200;
					}
					continue;
				case 370:
					num27 += num39;
					num2 = 294;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 322:
					array3[23] = 125;
					num2 = 414;
					continue;
				case 295:
					num38 = num30 % num33;
					num2 = 259;
					if (sq())
					{
						continue;
					}
					break;
				case 108:
					array3[24] = (byte)num21;
					num2 = 291;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 95:
					array2[0] = (byte)num26;
					num2 = 48;
					continue;
				case 310:
					array3[10] = (byte)num21;
					num2 = 341;
					continue;
				case 247:
					array3[23] = (byte)num22;
					num2 = 25;
					if (sq())
					{
						num2 = 25;
					}
					continue;
				case 165:
					array3[0] = 70;
					num2 = 347;
					continue;
				case 182:
					num20 = 145 - 48;
					num2 = 24;
					if (J6() != null)
					{
						num2 = 1;
					}
					continue;
				case 158:
					array4[7] = publicKeyToken[3];
					num2 = 124;
					continue;
				case 377:
					array2[9] = (byte)num26;
					num2 = 283;
					continue;
				case 293:
					array2[14] = (byte)num26;
					num2 = 402;
					continue;
				case 43:
					num21 = 47 + 108;
					num2 = 205;
					continue;
				case 201:
					array3[6] = 140;
					num2 = 251;
					continue;
				case 148:
					array3[20] = (byte)num22;
					num2 = 356;
					continue;
				case 390:
					array2[6] = 108;
					num2 = 107;
					continue;
				case 241:
					num21 = 60 + 11;
					num2 = 83;
					continue;
				case 339:
					num22 = 131 + 92;
					num2 = 371;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 42:
					num22 = 7 + 31;
					num2 = 234;
					continue;
				case 202:
					num26 = 133 - 53;
					num = 199;
					break;
				case 277:
					array3[3] = (byte)num21;
					num2 = 284;
					continue;
				case 359:
					array3[28] = (byte)num22;
					num2 = 75;
					continue;
				case 391:
					array3[6] = (byte)num22;
					num2 = 6;
					if (sq())
					{
						continue;
					}
					break;
				case 387:
					num20 = 235 - 78;
					num2 = 420;
					if (J6() != null)
					{
						num2 = 61;
					}
					continue;
				case 244:
					array3[19] = 147;
					num2 = 164;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 184:
					array3[12] = 56;
					num2 = 38;
					continue;
				case 163:
					array2[4] = 166;
					num2 = 99;
					if (sq())
					{
						continue;
					}
					break;
				case 273:
					num26 = 79 + 70;
					num2 = 293;
					continue;
				case 383:
					array3[2] = 159;
					num2 = 207;
					continue;
				case 222:
					array5[num28 + 2] = (byte)((num29 & 0xFF0000) >> 16);
					num2 = 45;
					continue;
				case 228:
					array3[9] = 91;
					num2 = 296;
					continue;
				case 173:
					array2[5] = (byte)num20;
					num2 = 326;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 286:
					array2[15] = 198;
					num2 = 147;
					continue;
				case 226:
					if (publicKeyToken != null)
					{
						num2 = 309;
						continue;
					}
					goto case 179;
				case 292:
					array4[11] = publicKeyToken[5];
					num2 = 160;
					continue;
				case 133:
					array2[4] = (byte)num20;
					num2 = 163;
					continue;
				case 381:
					array3[25] = 92;
					num2 = 380;
					continue;
				case 289:
					num25 = array.Length % 4;
					num2 = 221;
					if (J6() != null)
					{
						num2 = 196;
					}
					continue;
				case 213:
					array3[30] = 84;
					num2 = 276;
					continue;
				case 380:
					array3[25] = 72;
					num2 = 115;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 418:
					num20 = 249 - 83;
					num2 = 233;
					continue;
				case 94:
					array3[22] = 125;
					num2 = 154;
					continue;
				case 49:
					array3[2] = 219;
					num2 = 348;
					if (sq())
					{
						continue;
					}
					break;
				case 283:
					array2[9] = 208;
					num2 = 100;
					if (!sq())
					{
						num2 = 32;
					}
					continue;
				case 360:
					array3[6] = (byte)num21;
					num2 = 95;
					if (J6() == null)
					{
						num2 = 172;
					}
					continue;
				case 121:
					if (num24 > 0)
					{
						num = 252;
						break;
					}
					goto case 200;
				case 9:
					array3[1] = (byte)num21;
					num2 = 278;
					continue;
				case 394:
					num21 = 243 - 81;
					num2 = 358;
					continue;
				case 333:
					array3[28] = (byte)num21;
					num2 = 305;
					if (sq())
					{
						continue;
					}
					break;
				case 335:
					array6 = array3;
					num2 = 117;
					continue;
				case 230:
					symmetricAlgorithm = PEXoCqmS4w();
					num2 = 132;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 407:
					num22 = 24 + 120;
					num2 = 423;
					continue;
				case 122:
					if (P_0 == -1)
					{
						num2 = 230;
						if (!sq())
						{
							num2 = 169;
						}
						continue;
					}
					goto case 289;
				case 285:
					array3[9] = (byte)num21;
					num2 = 228;
					continue;
				case 6:
					num22 = 138 - 29;
					num2 = 263;
					continue;
				case 154:
					num21 = 174 - 83;
					num2 = 112;
					continue;
				case 51:
					num26 = 202 - 67;
					num2 = 107;
					if (J6() == null)
					{
						num2 = 129;
					}
					continue;
				case 395:
					array3[5] = 152;
					num2 = 111;
					if (sq())
					{
						num2 = 382;
					}
					continue;
				case 11:
					array3[17] = 156;
					num2 = 177;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 136:
					array3[17] = (byte)num21;
					num2 = 400;
					continue;
				case 369:
					cryptoStream.Write(array, 0, array.Length);
					num2 = 302;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 234:
					array3[16] = (byte)num22;
					num2 = 149;
					if (!sq())
					{
						num2 = 45;
					}
					continue;
				case 420:
					array2[5] = (byte)num20;
					num2 = 316;
					continue;
				case 290:
					num26 = 111 + 28;
					num2 = 69;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 142:
					array2[2] = (byte)num26;
					num = 409;
					break;
				case 287:
					array3[12] = (byte)num22;
					num2 = 80;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 236:
					array3[30] = 122;
					num2 = 196;
					if (!sq())
					{
						num2 = 80;
					}
					continue;
				case 58:
					array2[12] = 192;
					num2 = 401;
					continue;
				case 396:
					array = HI0;
					num2 = 289;
					if (sq())
					{
						continue;
					}
					break;
				case 253:
					num27 = 0u;
					num2 = 97;
					continue;
				case 153:
					num27 = num4;
					num2 = 208;
					continue;
				case 321:
					array3[10] = 140;
					num2 = 26;
					continue;
				case 3:
					Array.Reverse(array4);
					num2 = 338;
					if (J6() != null)
					{
						num2 = 300;
					}
					continue;
				case 384:
					array2[10] = (byte)num26;
					num2 = 324;
					continue;
				case 87:
					array2[10] = (byte)num20;
					num2 = 74;
					continue;
				case 245:
					array3[31] = 215;
					num2 = 335;
					continue;
				case 81:
					num21 = 66 - 37;
					num2 = 140;
					continue;
				case 362:
					array3[23] = (byte)num21;
					num2 = 89;
					continue;
				case 382:
					num22 = 61 + 98;
					num2 = 336;
					continue;
				case 243:
					array2[8] = 138;
					num2 = 111;
					if (sq())
					{
						num2 = 413;
					}
					continue;
				case 400:
					array3[17] = 31;
					num2 = 25;
					if (sq())
					{
						num2 = 137;
					}
					continue;
				case 161:
					num26 = 71 + 118;
					num2 = 34;
					continue;
				case 196:
					num22 = 110 - 71;
					num = 18;
					break;
				case 21:
					array2[13] = (byte)num26;
					num2 = 189;
					continue;
				case 128:
					array3[23] = 109;
					num2 = 322;
					if (J6() != null)
					{
						num2 = 208;
					}
					continue;
				case 178:
					array3[8] = 52;
					num2 = 270;
					continue;
				case 403:
					num22 = 196 - 65;
					num2 = 287;
					continue;
				case 272:
					num20 = 226 - 75;
					num2 = 12;
					continue;
				case 70:
					array2[15] = 120;
					num2 = 386;
					continue;
				case 301:
					num21 = 46 + 21;
					num2 = 312;
					continue;
				case 340:
					array2[1] = 140;
					num = 264;
					break;
				case 38:
					num21 = 193 - 118;
					num2 = 231;
					continue;
				case 308:
					array2[8] = (byte)num26;
					num2 = 243;
					continue;
				case 398:
					array3[4] = 203;
					num2 = 127;
					continue;
				case 401:
					num20 = 124 + 66;
					num2 = 216;
					continue;
				case 284:
					array3[3] = 128;
					num2 = 299;
					if (sq())
					{
						continue;
					}
					break;
				case 14:
					array3[19] = 239;
					num2 = 61;
					if (sq())
					{
						num2 = 76;
					}
					continue;
				case 84:
					num39 = (uint)((array6[num35 + 3] << 24) | (array6[num35 + 2] << 16) | (array6[num35 + 1] << 8) | array6[num35]);
					num2 = 249;
					continue;
				case 36:
					num21 = 237 - 79;
					num2 = 118;
					if (J6() == null)
					{
						num2 = 342;
					}
					continue;
				case 331:
					num26 = 101 + 50;
					num2 = 23;
					continue;
				case 126:
					num22 = 15 + 39;
					num2 = 262;
					if (!sq())
					{
						num2 = 159;
					}
					continue;
				case 263:
					array3[6] = (byte)num22;
					num2 = 77;
					continue;
				case 132:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 303;
					if (sq())
					{
						continue;
					}
					break;
				case 68:
					array3[11] = 194;
					num2 = 81;
					continue;
				case 404:
					num22 = 217 - 72;
					num2 = 183;
					continue;
				case 316:
					num26 = 21 + 51;
					num2 = 209;
					if (sq())
					{
						continue;
					}
					break;
				case 210:
					num32++;
					num2 = 211;
					continue;
				case 40:
					if (num25 > 0)
					{
						num2 = 85;
						continue;
					}
					goto case 212;
				case 248:
					num26 = 153 + 47;
					num2 = 267;
					continue;
				case 299:
					array3[3] = 96;
					num2 = 32;
					continue;
				case 25:
					num22 = 74 + 73;
					num2 = 0;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 155:
					num26 = 90 + 77;
					num2 = 308;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 252:
					num37 <<= 8;
					num2 = 31;
					if (sq())
					{
						continue;
					}
					break;
				case 264:
					array2[1] = 0;
					num2 = 98;
					if (J6() != null)
					{
						num2 = 10;
					}
					continue;
				case 415:
					array4[5] = publicKeyToken[2];
					num2 = 158;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 302:
					cryptoStream.FlushFinalBlock();
					num2 = 365;
					continue;
				case 135:
					num22 = 130 + 72;
					num2 = 148;
					continue;
				case 305:
					num22 = 114 + 60;
					num2 = 359;
					continue;
				case 329:
					array3[29] = 212;
					num = 50;
					break;
				case 297:
					array3[28] = 159;
					num2 = 280;
					continue;
				case 65:
					num26 = 69 + 10;
					num2 = 219;
					continue;
				case 378:
					num21 = 33 + 14;
					num2 = 197;
					continue;
				case 1:
					vtNVUKGulysZw81C3E = new VtNVUKGulysZw81C3E(x4Dk2IHVmX.GetManifestResourceStream("Rts9K5j41cxoQcVE8o.n9hpuT7tCrOIDDZ6vt"));
					num2 = 157;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 350:
					array3[14] = 109;
					num2 = 306;
					if (sq())
					{
						continue;
					}
					break;
				case 73:
					array3[7] = (byte)num21;
					num = 152;
					break;
				case 280:
					array3[29] = 114;
					num2 = 329;
					continue;
				case 23:
					array2[14] = (byte)num26;
					num2 = 298;
					if (sq())
					{
						continue;
					}
					break;
				case 175:
					array3[14] = (byte)num21;
					num2 = 378;
					continue;
				case 221:
					num31 = array.Length / 4;
					num2 = 416;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 64:
					num30 = 0;
					num = 397;
					break;
				case 187:
					num35 = (uint)num28;
					num2 = 15;
					if (sq())
					{
						num2 = 66;
					}
					continue;
				case 180:
					num20 = 45 + 62;
					num2 = 133;
					continue;
				case 24:
					array2[3] = (byte)num20;
					num2 = 56;
					continue;
				case 361:
					num22 = 148 - 49;
					num2 = 169;
					continue;
				case 88:
					num26 = 57 + 84;
					num2 = 33;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 35:
					array3[31] = (byte)num22;
					num2 = 245;
					if (sq())
					{
						continue;
					}
					break;
				case 44:
					array3[0] = 52;
					num = 266;
					break;
				case 152:
					array3[8] = 102;
					num2 = 255;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 59:
					array2[10] = 108;
					num = 215;
					break;
				case 75:
					num21 = 220 - 73;
					num = 307;
					break;
				case 26:
					num21 = 17 + 43;
					num2 = 10;
					continue;
				case 367:
					array2[11] = 84;
					num2 = 113;
					continue;
				case 203:
					array3[17] = 160;
					num2 = 258;
					continue;
				case 85:
					num40 = num27 ^ num23;
					num = 314;
					break;
				case 74:
					array2[11] = 97;
					num2 = 72;
					if (sq())
					{
						num2 = 367;
					}
					continue;
				case 306:
					array3[14] = 116;
					num2 = 214;
					continue;
				case 224:
					array2[6] = (byte)num20;
					num2 = 390;
					continue;
				case 291:
					num21 = 93 + 109;
					num2 = 130;
					if (J6() != null)
					{
						num2 = 69;
					}
					continue;
				case 131:
					array3[27] = 184;
					num2 = 354;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 183:
					array3[13] = (byte)num22;
					num2 = 301;
					continue;
				case 312:
					array3[13] = (byte)num21;
					num2 = 407;
					continue;
				case 93:
					array3[2] = 58;
					num2 = 156;
					continue;
				case 89:
					num21 = 120 + 59;
					num2 = 325;
					continue;
				case 211:
				case 227:
					if (num32 >= num25)
					{
						num = 2;
						break;
					}
					goto case 123;
				case 16:
					num26 = 81 + 78;
					num2 = 174;
					continue;
				case 205:
					array3[7] = (byte)num21;
					num2 = 318;
					continue;
				case 105:
					num20 = 159 - 53;
					num2 = 138;
					if (!sq())
					{
						num2 = 100;
					}
					continue;
				case 15:
					num21 = 173 - 57;
					num2 = 242;
					continue;
				case 172:
					num22 = 179 - 59;
					num2 = 391;
					continue;
				case 229:
					if (num25 > 0)
					{
						num2 = 337;
						continue;
					}
					goto case 72;
				case 127:
					array3[4] = 121;
					num2 = 393;
					continue;
				case 240:
					num20 = 130 + 114;
					num2 = 173;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 246:
					num21 = 16 - 6;
					num2 = 79;
					if (sq())
					{
						num2 = 313;
					}
					continue;
				case 118:
					num22 = 30 + 9;
					num2 = 328;
					continue;
				case 146:
					num22 = 18 + 54;
					num2 = 60;
					if (sq())
					{
						continue;
					}
					break;
				case 352:
					num21 = 202 - 67;
					num2 = 136;
					continue;
				case 78:
					array3[28] = 120;
					num2 = 91;
					continue;
				case 238:
					num35 = 0u;
					num2 = 64;
					if (!sq())
					{
						num2 = 39;
					}
					continue;
				case 96:
					num21 = 80 + 116;
					num2 = 412;
					continue;
				case 190:
					array3[31] = 85;
					num2 = 146;
					if (!sq())
					{
						num2 = 50;
					}
					continue;
				case 109:
					array6[num36] ^= array4[num36];
					num2 = 217;
					continue;
				case 358:
					array3[12] = (byte)num21;
					num2 = 184;
					continue;
				case 365:
					HI0 = rLIoBbVVpm(stream);
					num2 = 22;
					continue;
				case 124:
					array4[9] = publicKeyToken[4];
					num2 = 292;
					continue;
				case 347:
					num21 = 159 - 53;
					num2 = 9;
					continue;
				case 363:
					array3[24] = 27;
					num2 = 260;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 270:
					array3[9] = 181;
					num2 = 254;
					continue;
				case 388:
					array3[4] = 77;
					num2 = 398;
					continue;
				case 107:
					array2[6] = 97;
					num2 = 405;
					continue;
				case 139:
					array3[3] = (byte)num21;
					num2 = 388;
					continue;
				case 346:
					array4[15] = publicKeyToken[7];
					num2 = 179;
					if (sq())
					{
						continue;
					}
					break;
				case 115:
					array3[26] = 96;
					num2 = 39;
					continue;
				case 10:
					array3[10] = (byte)num21;
					num2 = 126;
					if (sq())
					{
						continue;
					}
					break;
				case 288:
					array2[6] = (byte)num20;
					num2 = 375;
					if (sq())
					{
						continue;
					}
					break;
				case 219:
					array2[7] = (byte)num26;
					num2 = 16;
					continue;
				default:
					array3[24] = (byte)num22;
					num2 = 141;
					if (sq())
					{
						continue;
					}
					break;
				case 111:
					array4[3] = publicKeyToken[1];
					num2 = 415;
					continue;
				case 424:
					num35 = (uint)(num38 * 4);
					num2 = 84;
					continue;
				case 39:
					num22 = 102 + 23;
					num2 = 399;
					continue;
				case 54:
					if (HI0.Length != 0)
					{
						num2 = 53;
						if (sq())
						{
							continue;
						}
						break;
					}
					goto case 1;
				case 343:
					num24++;
					num2 = 92;
					if (sq())
					{
						continue;
					}
					break;
				case 320:
					array3[14] = (byte)num21;
					num2 = 350;
					continue;
				case 120:
					num21 = 101 + 9;
					num2 = 218;
					continue;
				case 314:
					num24 = 0;
					num2 = 61;
					continue;
				case 17:
					array2[6] = (byte)num26;
					num2 = 143;
					continue;
				case 138:
					array2[8] = (byte)num20;
					num = 290;
					break;
				case 251:
					array3[6] = 133;
					num2 = 176;
					continue;
				case 200:
					array5[num28 + num24] = (byte)((num40 & num37) >> num34);
					num2 = 343;
					continue;
				case 336:
					array3[5] = (byte)num22;
					num2 = 232;
					continue;
				case 134:
					num26 = 125 - 26;
					num2 = 366;
					continue;
				case 141:
					num21 = 34 + 81;
					num2 = 108;
					continue;
				case 309:
					if (publicKeyToken.Length > 0)
					{
						num2 = 265;
						continue;
					}
					goto case 179;
				case 37:
					num20 = 118 + 68;
					num = 62;
					break;
				case 353:
					array3[0] = (byte)num21;
					num2 = 96;
					if (!sq())
					{
						num2 = 76;
					}
					continue;
				case 355:
					num21 = 148 + 68;
					num2 = 175;
					if (J6() != null)
					{
						num2 = 99;
					}
					continue;
				case 332:
					array2[14] = (byte)num20;
					num2 = 331;
					continue;
				case 18:
					array3[30] = (byte)num22;
					num2 = 190;
					continue;
				case 177:
					array3[17] = 117;
					num2 = 203;
					continue;
				case 147:
					array4 = array2;
					num2 = 3;
					continue;
				case 106:
					array3[10] = 162;
					num2 = 321;
					continue;
				case 192:
					if (num30 == num31 - 1)
					{
						num2 = 229;
						continue;
					}
					goto case 72;
				case 179:
					num36 = 0;
					num2 = 171;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 140:
					array3[11] = (byte)num21;
					num2 = 403;
					continue;
				case 294:
					num32 = 0;
					num2 = 227;
					continue;
				case 156:
					array3[2] = 99;
					num2 = 383;
					continue;
				case 12:
					array2[0] = (byte)num20;
					num = 110;
					break;
				case 413:
					array2[8] = 106;
					num2 = 281;
					continue;
				case 223:
					num26 = 45 + 42;
					num2 = 95;
					continue;
				case 257:
					array2[12] = 73;
					num = 37;
					break;
				case 249:
					num37 = 255u;
					num2 = 101;
					continue;
				case 217:
					num36++;
					num2 = 86;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 281:
					num26 = 219 - 73;
					num2 = 377;
					continue;
				case 371:
					array3[18] = (byte)num22;
					num2 = 90;
					if (sq())
					{
						continue;
					}
					break;
				case 338:
					publicKeyToken = x4Dk2IHVmX.GetName().GetPublicKeyToken();
					num2 = 226;
					continue;
				case 422:
					array3[20] = 143;
					num2 = 135;
					continue;
				case 268:
					array2[1] = (byte)num20;
					num2 = 418;
					continue;
				case 13:
				case 28:
					num30++;
					num2 = 7;
					continue;
				case 66:
					num23 = (uint)((array[num35 + 3] << 24) | (array[num35 + 2] << 16) | (array[num35 + 1] << 8) | array[num35]);
					num2 = 135;
					if (sq())
					{
						num2 = 188;
					}
					continue;
				case 275:
					array3[15] = 168;
					num2 = 327;
					continue;
				case 76:
					num21 = 187 - 62;
					num2 = 82;
					continue;
				case 199:
					array2[14] = (byte)num26;
					num2 = 70;
					continue;
				case 185:
					num22 = 240 - 80;
					num2 = 35;
					if (sq())
					{
						continue;
					}
					break;
				case 119:
					vtNVUKGulysZw81C3E.VDqkQKyKML();
					num2 = 30;
					continue;
				case 164:
					num22 = 116 + 69;
					num2 = 334;
					continue;
				case 364:
					num22 = 159 - 53;
					num2 = 52;
					continue;
				case 409:
					array2[2] = 11;
					num2 = 29;
					continue;
				case 386:
					array2[15] = 106;
					num2 = 51;
					if (sq())
					{
						continue;
					}
					break;
				case 215:
					num26 = 199 - 66;
					num2 = 384;
					continue;
				case 385:
					array2[0] = (byte)num26;
					num2 = 20;
					continue;
				case 342:
					array3[28] = (byte)num21;
					num2 = 41;
					if (sq())
					{
						num2 = 78;
					}
					continue;
				case 110:
					num26 = 137 - 114;
					num2 = 385;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 181:
					array2[14] = (byte)num20;
					num2 = 202;
					continue;
				case 419:
					num21 = 138 - 46;
					num2 = 379;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 82:
					array3[20] = (byte)num21;
					num2 = 5;
					continue;
				case 98:
					array2[2] = 146;
					num2 = 161;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 174:
					array2[7] = (byte)num26;
					num2 = 373;
					continue;
				case 212:
					num29 = num27 ^ num23;
					num2 = 116;
					continue;
				case 150:
					num26 = 193 - 64;
					num2 = 142;
					continue;
				case 103:
					num20 = 69 + 118;
					num2 = 332;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 197:
					array3[15] = (byte)num21;
					num = 323;
					break;
				case 276:
					array3[30] = 199;
					num2 = 236;
					continue;
				case 349:
					array2[11] = (byte)num26;
					num2 = 195;
					continue;
				case 69:
					array2[8] = (byte)num26;
					num2 = 155;
					if (sq())
					{
						continue;
					}
					break;
				case 325:
					array3[23] = (byte)num21;
					num2 = 71;
					continue;
				case 116:
					array5[num28] = (byte)(num29 & 0xFF);
					num2 = 311;
					continue;
				case 130:
					array3[24] = (byte)num21;
					num2 = 319;
					continue;
				case 186:
					num31++;
					num2 = 112;
					if (J6() == null)
					{
						num2 = 238;
					}
					continue;
				case 412:
					array3[0] = (byte)num21;
					num2 = 165;
					if (sq())
					{
						continue;
					}
					break;
				case 80:
					array3[12] = 90;
					num2 = 159;
					if (J6() != null)
					{
						num2 = 90;
					}
					continue;
				case 348:
					num22 = 16 + 55;
					num2 = 279;
					if (sq())
					{
						continue;
					}
					break;
				case 423:
					array3[13] = (byte)num22;
					num2 = 145;
					continue;
				case 207:
					array3[2] = 65;
					num2 = 357;
					if (!sq())
					{
						num2 = 20;
					}
					continue;
				case 231:
					array3[12] = (byte)num21;
					num2 = 145;
					if (sq())
					{
						num2 = 404;
					}
					continue;
				case 149:
					array3[16] = 169;
					num2 = 11;
					if (sq())
					{
						continue;
					}
					break;
				case 351:
					array2[1] = 137;
					num2 = 340;
					if (J6() != null)
					{
						num2 = 173;
					}
					continue;
				case 67:
					num21 = 132 - 44;
					num2 = 310;
					if (!sq())
					{
						num2 = 141;
					}
					continue;
				case 62:
					array2[12] = (byte)num20;
					num2 = 330;
					if (sq())
					{
						continue;
					}
					break;
				case 279:
					array3[2] = (byte)num22;
					num2 = 93;
					continue;
				case 311:
					array5[num28 + 1] = (byte)((num29 & 0xFF00) >> 8);
					num2 = 222;
					continue;
				case 208:
					if (num30 == num31 - 1)
					{
						num2 = 40;
						continue;
					}
					goto case 212;
				case 101:
					num34 = 0;
					num2 = 192;
					continue;
				case 235:
					num33 = array6.Length / 4;
					num2 = 406;
					continue;
				case 60:
					array3[31] = (byte)num22;
					num2 = 185;
					if (!sq())
					{
						num2 = 114;
					}
					continue;
				case 269:
					array2[9] = 90;
					num2 = 124;
					if (J6() == null)
					{
						num2 = 248;
					}
					continue;
				case 323:
					array3[15] = 118;
					num2 = 304;
					continue;
				case 356:
					num21 = 7 + 116;
					num = 411;
					break;
				case 313:
					array3[27] = (byte)num21;
					num2 = 33;
					if (sq())
					{
						num2 = 36;
					}
					continue;
				case 259:
					num28 = num30 * 4;
					num2 = 424;
					if (sq())
					{
						continue;
					}
					break;
				case 326:
					num20 = 88 + 71;
					num2 = 224;
					continue;
				case 324:
					num20 = 193 - 105;
					num2 = 87;
					continue;
				case 162:
					array3[1] = 80;
					num2 = 49;
					continue;
				case 193:
					array3[3] = (byte)num22;
					num2 = 128;
					if (J6() == null)
					{
						num2 = 239;
					}
					continue;
				case 8:
					num23 <<= 8;
					num2 = 274;
					continue;
				case 100:
					array2[9] = 99;
					num2 = 269;
					continue;
				case 176:
					num21 = 168 - 56;
					num2 = 360;
					continue;
				case 191:
					num20 = 228 - 76;
					num2 = 144;
					continue;
				case 129:
					array2[15] = (byte)num26;
					num2 = 191;
					if (sq())
					{
						continue;
					}
					break;
				case 220:
					array3[26] = (byte)num22;
					num2 = 419;
					continue;
				case 50:
					array3[29] = 27;
					num2 = 361;
					continue;
				case 267:
					array2[9] = (byte)num26;
					num2 = 59;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 278:
					array3[1] = 210;
					num2 = 120;
					continue;
				case 52:
					array3[23] = (byte)num22;
					num = 128;
					break;
				case 214:
					num21 = 155 - 51;
					num2 = 167;
					continue;
				case 5:
					num22 = 16 + 32;
					num2 = 19;
					continue;
				case 357:
					num21 = 193 - 64;
					num2 = 277;
					continue;
				case 250:
					array3[14] = 130;
					num2 = 355;
					continue;
				case 416:
					array5 = new byte[array.Length];
					num2 = 235;
					continue;
				case 22:
					stream.Close();
					num2 = 271;
					continue;
				case 233:
					array2[1] = (byte)num20;
					num2 = 351;
					continue;
				case 7:
				case 397:
					if (num30 >= num31)
					{
						num = 79;
						break;
					}
					goto case 295;
				case 63:
					num20 = 6 + 39;
					num2 = 268;
					continue;
				case 195:
					num20 = 126 - 31;
					num2 = 57;
					if (sq())
					{
						continue;
					}
					break;
				case 261:
					num21 = 102 + 61;
					num2 = 353;
					continue;
				case 45:
					array5[num28 + 3] = (byte)((num29 & 0xFF000000u) >> 24);
					num2 = 28;
					if (J6() != null)
					{
						num2 = 23;
					}
					continue;
				case 411:
					array3[21] = (byte)num21;
					num2 = 237;
					continue;
				case 157:
					vtNVUKGulysZw81C3E.KDikMXewCI().Position = 0L;
					num2 = 41;
					continue;
				case 373:
					array2[7] = 157;
					num2 = 151;
					continue;
				case 334:
					array3[19] = (byte)num22;
					num2 = 374;
					continue;
				case 354:
					array3[27] = 128;
					num2 = 46;
					continue;
				case 425:
					array3[0] = 152;
					num2 = 44;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 160:
					array4[13] = publicKeyToken[6];
					num2 = 346;
					continue;
				case 239:
					array3[3] = 193;
					num2 = 426;
					continue;
				case 143:
					num20 = 96 + 54;
					num2 = 288;
					if (!sq())
					{
						num2 = 222;
					}
					continue;
				case 282:
					array3[19] = (byte)num22;
					num2 = 14;
					continue;
				case 405:
					num26 = 191 - 63;
					num2 = 17;
					if (!sq())
					{
						num2 = 8;
					}
					continue;
				case 372:
					array3[8] = (byte)num22;
					num2 = 178;
					if (J6() == null)
					{
						continue;
					}
					break;
				case 256:
					array2[0] = 119;
					num2 = 223;
					if (!sq())
					{
						num2 = 206;
					}
					continue;
				case 327:
					num22 = 174 - 58;
					num2 = 344;
					continue;
				case 33:
					array2[2] = (byte)num26;
					num2 = 150;
					continue;
				case 4:
					num20 = 144 - 48;
					num2 = 345;
					continue;
				case 237:
					num21 = 145 - 48;
					num2 = 225;
					continue;
				case 376:
					array2[7] = 151;
					num2 = 65;
					continue;
				case 265:
					array4[1] = publicKeyToken[0];
					num2 = 111;
					continue;
				case 218:
					array3[1] = (byte)num21;
					num2 = 162;
					continue;
				case 61:
				case 92:
					if (num24 >= num25)
					{
						num2 = 13;
						continue;
					}
					goto case 121;
				case 47:
					num23 = 0u;
					num2 = 168;
					continue;
				case 56:
					array2[3] = 130;
					num2 = 161;
					if (sq())
					{
						num2 = 180;
					}
					continue;
				case 307:
					array3[28] = (byte)num21;
					num2 = 297;
					continue;
				case 216:
					array2[13] = (byte)num20;
					num2 = 417;
					continue;
				case 298:
					num20 = 14 + 44;
					num2 = 181;
					continue;
				case 392:
					array3[25] = 128;
					num2 = 381;
					continue;
				case 414:
					num21 = 184 - 61;
					num2 = 362;
					if (J6() != null)
					{
						num2 = 275;
					}
					continue;
				case 97:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 1662765296u;
					uint num7 = 99704530u;
					uint num8 = 79367849u;
					uint num9 = num5;
					uint num10 = 870929846u;
					uint num11 = 1875877379u;
					if ((double)num7 == 0.0)
					{
						num7--;
					}
					uint num12 = (uint)((double)num6 / (double)num7 + (double)num7);
					num7 = num6 - num10 - num12 + num6;
					ulong num13 = 18446744073587320690uL;
					num13 |= 1;
					num8 = (uint)(num8 * num8 % num13);
					uint num14 = num6 & 0xFF00FF;
					uint num15 = num6 & 0xFF00FF00u;
					num14 = ((num14 >> 8) | (num15 << 8)) ^ num7;
					num6 = (num6 >> 12) | (num6 << 20);
					uint num16 = num10 & 0xFF00FF;
					uint num17 = num10 & 0xFF00FF00u;
					num16 = ((num16 >> 8) | (num17 << 8)) + num7;
					num10 = (num10 >> 9) | (num10 << 23);
					uint num18 = num11 & 0xFF00FF;
					uint num19 = num11 & 0xFF00FF00u;
					num18 = ((num18 >> 8) | (num19 << 8)) ^ num7;
					num11 = (num11 >> 7) | (num11 << 25);
					num9 ^= num9 << 8;
					num9 += num6;
					num9 ^= num9 >> 27;
					num9 += num10;
					num9 ^= num9 << 5;
					num9 += num11;
					num9 = (((num10 << 20) + num6) ^ num6) - num9;
					num4 = num3 + (uint)(double)num9;
					num2 = 153;
					continue;
				}
				}
				break;
			}
		}
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string hg2oY5yaSM(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int rIq()
	{
		return 5;
	}

	private static void nIs()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate zII(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object PvroikJllY(object P_0)
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
	public static extern IntPtr H1sorrpiaP(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr oGjoaYPPLS(IntPtr P_0, string P_1);

	private static IntPtr HI7(IntPtr P_0, string P_1, uint P_2)
	{
		if (tIQ == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Find ".Trim() + "ResourceA");
			tIQ = (oE)Marshal.GetDelegateForFunctionPointer(ptr, typeof(oE));
		}
		return tIQ(P_0, P_1, P_2);
	}

	private static IntPtr qIM(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (WIn == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			WIn = (vr)Marshal.GetDelegateForFunctionPointer(ptr, typeof(vr));
		}
		return WIn(P_0, P_1, P_2, P_3);
	}

	private static int XIw(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (lIG == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			lIG = (R3)Marshal.GetDelegateForFunctionPointer(ptr, typeof(R3));
		}
		return lIG(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int jIH(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (LIe == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Virtual ".Trim() + "Protect");
			LIe = (SJ)Marshal.GetDelegateForFunctionPointer(ptr, typeof(SJ));
		}
		return LIe(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr VIP(uint P_0, int P_1, uint P_2)
	{
		if (VIy == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Open ".Trim() + "Process");
			VIy = (hX)Marshal.GetDelegateForFunctionPointer(ptr, typeof(hX));
		}
		return VIy(P_0, P_1, P_2);
	}

	private static int OIp(IntPtr P_0)
	{
		if (CIz == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Close ".Trim() + "Handle");
			CIz = (fN)Marshal.GetDelegateForFunctionPointer(ptr, typeof(fN));
		}
		return CIz(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (R7S == IntPtr.Zero)
		{
			R7S = H1sorrpiaP("kernel ".Trim() + "32.dll");
		}
		return R7S;
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] MIb(string P_0)
	{
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream Njco6C1nc4()
	{
		return new MemoryStream();
	}

	internal static byte[] rLIoBbVVpm(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] XIC(byte[] P_0)
	{
		Stream stream = Njco6C1nc4();
		SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
		symmetricAlgorithm.Key = new byte[32]
		{
			245, 55, 206, 96, 34, 223, 103, 191, 236, 88,
			17, 33, 166, 97, 118, 50, 229, 130, 24, 94,
			254, 211, 205, 163, 166, 9, 51, 229, 101, 188,
			155, 199
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			164, 184, 233, 95, 116, 3, 249, 159, 214, 151,
			238, 95, 204, 227, 38, 139
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = rLIoBbVVpm(stream);
		hHEYokUTtehNq5ji0d.BN1hJz();
		return result;
	}

	private byte[] qIU()
	{
		return null;
	}

	private byte[] VIa()
	{
		return null;
	}

	private byte[] iIj()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] fIF()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] IIx()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] NIg()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] J6JoHkltLH()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] FtroUJNIfo()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] KIxoTLeGZr()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] S0yo9WrR0W()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool sq()
	{
		return (object)null == null;
	}

	internal static object J6()
	{
		return null;
	}
}
