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
	private delegate void Lx(object o);

	internal class RJDcsuMfOxrTCYImPe : Attribute
	{
		internal class iGR41459RDH4FvPdNk<T>
		{
			private static object QwQ;

			public iGR41459RDH4FvPdNk()
			{
				hHEYokUTtehNq5ji0d.LrmWXz();
				base._002Ector();
			}

			internal static bool fwC()
			{
				return QwQ == null;
			}

			internal static object EwR()
			{
				return QwQ;
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
	private delegate IntPtr tG();

	internal struct BIpvxRBRb2dOGl802m
	{
		internal bool JDNkifbo3S;

		internal byte[] jsbkrdexts;
	}

	internal class VtNVUKGulysZw81C3E
	{
		private BinaryReader pV2;

		public VtNVUKGulysZw81C3E(Stream P_0)
		{
			pV2 = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return pV2.BaseStream;
		}

		internal byte[] B2XkaLi4dH(int P_0)
		{
			return pV2.ReadBytes(P_0);
		}

		internal int hx5kqNgSj4(byte[] P_0, int P_1, int P_2)
		{
			return pV2.Read(P_0, P_1, P_2);
		}

		internal int TVtkAMaqpL()
		{
			return pV2.ReadInt32();
		}

		internal void VDqkQKyKML()
		{
			pV2.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Cq(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr ne(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int MC(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int JV(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr k2(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int rM(IntPtr ptr);

	[Flags]
	private enum K4
	{

	}

	internal static Assembly x4Dk2IHVmX;

	private static uint[] P6N;

	private static bool R6M;

	internal static RSACryptoServiceProvider onZkkIlVOi;

	private static IntPtr S61;

	private static bool FVX;

	private static long iVp;

	private static bool aVf;

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static bool bVt;

	private static rM HV4;

	private static IntPtr AVu;

	private static int kVv;

	private static bool r6K;

	internal static Hashtable lmdkVksVkh;

	private static JV UVm;

	private static object Q6D;

	private static int yVB;

	private static Dictionary<int, int> J68;

	private static MC NVh;

	private static byte[] Y6g;

	private static int aVS;

	private static long yVb;

	private static k2 mVw;

	private static byte[] V6G;

	private static int[] bVj;

	private static SortedList iVT;

	private static IntPtr L6z;

	internal static QZEOeHRUkDiNqCWT0p abxkLGOVrU;

	private static Cq vVJ;

	private static int SVy;

	private static object oVc;

	private static IntPtr eV3;

	private static bool g6d;

	private static bool jVi;

	internal static QZEOeHRUkDiNqCWT0p rNZkehfwNu;

	private static ne IV9;

	private static byte[] P6P;

	static WP6RZJql8gZrNhVA9v()
	{
		g6d = false;
		x4Dk2IHVmX = typeof(WP6RZJql8gZrNhVA9v).Assembly;
		P6N = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		R6M = false;
		r6K = false;
		Y6g = new byte[0];
		onZkkIlVOi = null;
		J68 = null;
		Q6D = new object();
		P6P = new byte[0];
		V6G = new byte[0];
		S61 = IntPtr.Zero;
		L6z = IntPtr.Zero;
		oVc = new string[0];
		bVj = new int[0];
		kVv = 1;
		FVX = false;
		iVT = new SortedList();
		yVB = 0;
		iVp = 0L;
		abxkLGOVrU = null;
		rNZkehfwNu = null;
		yVb = 0L;
		SVy = 0;
		aVf = false;
		jVi = false;
		aVS = 0;
		eV3 = IntPtr.Zero;
		bVt = false;
		lmdkVksVkh = new Hashtable();
		vVJ = null;
		IV9 = null;
		NVh = null;
		UVm = null;
		mVw = null;
		HV4 = null;
		AVu = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void urmWXG()
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
			T6Q(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			T6Q(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			T6Q(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			T6Q(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			T6Q(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			T6Q(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			T6Q(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			T6Q(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			T6Q(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			T6Q(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			T6Q(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			T6Q(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			T6Q(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			T6Q(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			T6Q(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			T6Q(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			d6O(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			d6O(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			d6O(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			d6O(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			d6O(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			d6O(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			d6O(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			d6O(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			d6O(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			d6O(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			d6O(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			d6O(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			d6O(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			d6O(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			d6O(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			d6O(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			o60(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			o60(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			o60(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			o60(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			o60(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			o60(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			o60(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			o60(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			o60(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			o60(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			o60(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			o60(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			o60(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			o60(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			o60(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			o60(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			L6k(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			L6k(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			L6k(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			L6k(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			L6k(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			L6k(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			L6k(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			L6k(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			L6k(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			L6k(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			L6k(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			L6k(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			L6k(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			L6k(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			L6k(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			L6k(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void T6Q(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + E6l(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + P6N[P_6 - 1], P_5);
	}

	private static void d6O(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + E6l(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + P6N[P_6 - 1], P_5);
	}

	private static void o60(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + E6l(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + P6N[P_6 - 1], P_5);
	}

	private static void L6k(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + E6l(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + P6N[P_6 - 1], P_5);
	}

	private static uint E6l(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool gX8onkMSd7()
	{
		if (!R6M)
		{
			XS8oLZGMXn();
			R6M = true;
		}
		return r6K;
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
			r6K = CryptoConfig.AllowOnlyFipsAlgorithms;
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
			if (J68 == null)
			{
				lock (Q6D)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(WP6RZJql8gZrNhVA9v).Assembly.GetManifestResourceStream("ALePHUldyfuoJN3a3N.ufCweAU73B034VRERi"));
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
							num3 += a6Y(num3);
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
					J68 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = J68[metadataToken];
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

	private static uint z6C(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint a6Y(uint P_0)
	{
		return 0u;
	}

	internal static void w65ov7siki()
	{
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string L3hoFlcqP6(int P_0)
	{
		int num = 55;
		byte[] array = default(byte[]);
		int num20 = default(int);
		int num21 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array5 = default(byte[]);
		byte[] array3 = default(byte[]);
		uint num24 = default(uint);
		int num30 = default(int);
		VtNVUKGulysZw81C3E vtNVUKGulysZw81C3E = default(VtNVUKGulysZw81C3E);
		int num27 = default(int);
		byte[] array2 = default(byte[]);
		int count = default(int);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] publicKeyToken = default(byte[]);
		int num22 = default(int);
		uint num40 = default(uint);
		int num26 = default(int);
		uint num32 = default(uint);
		uint num28 = default(uint);
		byte[] array4 = default(byte[]);
		int num31 = default(int);
		uint num38 = default(uint);
		uint num25 = default(uint);
		int num41 = default(int);
		int num33 = default(int);
		uint num4 = default(uint);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] array6 = default(byte[]);
		int num34 = default(int);
		int num23 = default(int);
		int num39 = default(int);
		string result = default(string);
		int num36 = default(int);
		uint num29 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 53:
					array[31] = (byte)num20;
					num2 = 114;
					continue;
				case 381:
					num21 = 179 - 59;
					num2 = 125;
					continue;
				case 406:
					array[10] = 116;
					num2 = 334;
					continue;
				case 412:
					cryptoStream.Write(array5, 0, array5.Length);
					num2 = 17;
					if (RM() == null)
					{
						num2 = 75;
					}
					continue;
				case 87:
					num21 = 194 - 64;
					num2 = 238;
					continue;
				case 324:
					num21 = 69 + 7;
					num2 = 255;
					continue;
				case 398:
					array[24] = (byte)num20;
					num2 = 245;
					if (nX())
					{
						continue;
					}
					break;
				case 349:
					array[9] = 159;
					num2 = 111;
					continue;
				case 118:
					num20 = 96 + 56;
					num2 = 50;
					continue;
				case 97:
					num20 = 198 - 66;
					num2 = 26;
					if (RM() == null)
					{
						num2 = 241;
					}
					continue;
				case 419:
					num21 = 27 + 98;
					num = 284;
					break;
				case 253:
					num20 = 138 - 46;
					num2 = 372;
					continue;
				case 252:
					num20 = 22 + 74;
					num2 = 193;
					continue;
				case 427:
					num21 = 85 + 22;
					num2 = 209;
					continue;
				case 65:
					array3[13] = (byte)num21;
					num2 = 29;
					continue;
				case 195:
					array[5] = 83;
					num2 = 301;
					continue;
				case 378:
					array[3] = 99;
					num2 = 256;
					if (RM() == null)
					{
						num2 = 288;
					}
					continue;
				case 98:
					num21 = 95 + 77;
					num2 = 63;
					if (RM() == null)
					{
						num2 = 79;
					}
					continue;
				case 212:
					array[15] = (byte)num20;
					num2 = 326;
					continue;
				case 70:
					num24 = 0u;
					num2 = 295;
					continue;
				case 162:
					array3[10] = 190;
					num = 380;
					break;
				case 119:
					array[31] = (byte)num20;
					num2 = 0;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 370:
					array3[7] = 103;
					num2 = 33;
					continue;
				case 388:
					array3[11] = 96;
					num2 = 383;
					continue;
				case 276:
					array3[14] = (byte)num21;
					num2 = 409;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 64:
					array[10] = 103;
					num2 = 2;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 244:
					num20 = 183 - 61;
					num2 = 345;
					continue;
				case 399:
					num21 = 36 + 38;
					num2 = 103;
					continue;
				case 383:
					num21 = 216 - 72;
					num2 = 163;
					continue;
				case 116:
					array3[6] = 91;
					num2 = 80;
					if (nX())
					{
						continue;
					}
					break;
				case 74:
					num20 = 145 - 48;
					num2 = 213;
					continue;
				case 315:
					array[31] = 166;
					num = 425;
					break;
				case 24:
					num20 = 112 - 16;
					num2 = 364;
					continue;
				case 57:
					array[13] = (byte)num20;
					num2 = 88;
					if (nX())
					{
						num2 = 143;
					}
					continue;
				case 11:
					array[18] = 246;
					num2 = 206;
					continue;
				case 178:
					array3[3] = (byte)num21;
					num2 = 190;
					continue;
				case 219:
					num30++;
					num2 = 136;
					if (nX())
					{
						continue;
					}
					break;
				case 332:
					num20 = 195 - 65;
					num2 = 354;
					continue;
				case 72:
					num20 = 33 + 13;
					num2 = 88;
					if (!nX())
					{
						num2 = 84;
					}
					continue;
				case 424:
					vtNVUKGulysZw81C3E.VDqkQKyKML();
					num2 = 214;
					continue;
				case 26:
					array[30] = (byte)num20;
					num2 = 155;
					continue;
				case 131:
				case 185:
					if (num27 >= array2.Length)
					{
						num2 = 67;
						if (!nX())
						{
							num2 = 11;
						}
						continue;
					}
					goto case 44;
				case 73:
					count = BitConverter.ToInt32(P6P, P_0);
					num2 = 155;
					if (nX())
					{
						num2 = 290;
					}
					continue;
				case 222:
					num21 = 107 + 2;
					num2 = 59;
					continue;
				case 126:
					num21 = 104 - 92;
					num2 = 35;
					if (!nX())
					{
						num2 = 28;
					}
					continue;
				case 151:
					array3[0] = (byte)num21;
					num2 = 322;
					continue;
				case 358:
					stream = Njco6C1nc4();
					num2 = 351;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 175:
					num30 = 0;
					num2 = 41;
					continue;
				case 402:
					array3[3] = 106;
					num2 = 68;
					if (nX())
					{
						num2 = 188;
					}
					continue;
				case 351:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 412;
					continue;
				case 293:
					array[16] = (byte)num20;
					num2 = 244;
					continue;
				case 42:
					array2[9] = publicKeyToken[4];
					num2 = 77;
					continue;
				case 375:
					array3[12] = (byte)num21;
					num2 = 85;
					continue;
				case 420:
					array3[0] = (byte)num21;
					num = 297;
					break;
				case 233:
					array[10] = (byte)num20;
					num2 = 192;
					continue;
				case 63:
					array[17] = 127;
					num2 = 72;
					continue;
				case 168:
					num21 = 46 + 23;
					num = 49;
					break;
				case 187:
					num20 = 164 - 54;
					num2 = 36;
					if (nX())
					{
						num2 = 221;
					}
					continue;
				case 21:
					array3[7] = (byte)num21;
					num2 = 81;
					if (!nX())
					{
						num2 = 53;
					}
					continue;
				case 318:
					num21 = 226 - 114;
					num2 = 189;
					if (!nX())
					{
						num2 = 21;
					}
					continue;
				case 207:
					num20 = 25 - 19;
					num2 = 177;
					continue;
				case 302:
					array[7] = 155;
					num2 = 99;
					if (nX())
					{
						continue;
					}
					break;
				case 224:
					if (publicKeyToken.Length > 0)
					{
						num2 = 246;
						continue;
					}
					goto case 146;
				case 363:
					num20 = 151 - 50;
					num2 = 50;
					if (nX())
					{
						num2 = 191;
					}
					continue;
				case 347:
					num20 = 181 - 60;
					num2 = 57;
					continue;
				case 135:
					num21 = 86 + 49;
					num2 = 51;
					if (nX())
					{
						continue;
					}
					break;
				case 220:
					num22 = 0;
					num = 37;
					break;
				case 82:
					array[28] = 130;
					num = 262;
					break;
				case 141:
					num21 = 118 + 13;
					num = 343;
					break;
				case 167:
					num20 = 191 - 69;
					num2 = 313;
					continue;
				case 392:
					array[2] = (byte)num20;
					num2 = 201;
					continue;
				case 81:
					array3[7] = 77;
					num2 = 200;
					continue;
				case 339:
					array3[9] = (byte)num21;
					num2 = 147;
					if (nX())
					{
						continue;
					}
					break;
				case 125:
					array3[9] = (byte)num21;
					num2 = 68;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 372:
					array[14] = (byte)num20;
					num2 = 100;
					continue;
				case 93:
					array3[7] = 144;
					num2 = 370;
					continue;
				case 384:
					array[19] = 94;
					num = 352;
					break;
				case 215:
					array5 = vtNVUKGulysZw81C3E.B2XkaLi4dH((int)vtNVUKGulysZw81C3E.KDikMXewCI().Length);
					num2 = 424;
					continue;
				case 28:
					array[13] = 122;
					num2 = 414;
					continue;
				case 404:
					num20 = 68 + 118;
					num2 = 362;
					if (nX())
					{
						continue;
					}
					break;
				case 423:
					num40 = 0u;
					num2 = 292;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 4:
					array3[8] = 99;
					num2 = 331;
					if (RM() == null)
					{
						num2 = 403;
					}
					continue;
				case 390:
					num20 = 93 + 106;
					num2 = 422;
					continue;
				case 209:
					array3[15] = (byte)num21;
					num2 = 107;
					continue;
				case 416:
					array[2] = 163;
					num2 = 0;
					if (RM() == null)
					{
						num2 = 24;
					}
					continue;
				case 314:
					array[27] = 88;
					num2 = 325;
					continue;
				case 165:
					array3[3] = (byte)num21;
					num2 = 361;
					continue;
				case 210:
					array3[6] = 186;
					num2 = 374;
					if (!nX())
					{
						num2 = 173;
					}
					continue;
				case 380:
					num21 = 170 - 56;
					num2 = 3;
					if (RM() != null)
					{
						num2 = 1;
					}
					continue;
				case 345:
					array[16] = (byte)num20;
					num2 = 52;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 27:
					num20 = 2 + 52;
					num2 = 138;
					if (nX())
					{
						continue;
					}
					break;
				case 36:
					num21 = 30 + 16;
					num2 = 108;
					continue;
				case 107:
					num21 = 211 + 13;
					num2 = 78;
					continue;
				case 235:
					array3[12] = (byte)num21;
					num2 = 274;
					continue;
				case 274:
					array3[13] = 162;
					num2 = 222;
					continue;
				case 13:
				case 37:
					if (num22 >= num26)
					{
						num2 = 109;
						continue;
					}
					goto case 369;
				case 30:
					num32 <<= 8;
					num2 = 122;
					continue;
				case 260:
					num20 = 213 - 71;
					num2 = 271;
					continue;
				case 379:
					num28 = 0u;
					num2 = 48;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 263:
					array[11] = (byte)num20;
					num2 = 291;
					continue;
				case 269:
					array[4] = 106;
					num2 = 129;
					continue;
				case 91:
					num20 = 198 - 66;
					num = 139;
					break;
				case 225:
					num20 = 228 - 76;
					num2 = 69;
					continue;
				case 368:
					array3[1] = 171;
					num2 = 87;
					continue;
				case 255:
					array3[14] = (byte)num21;
					num2 = 208;
					continue;
				case 259:
					num20 = 145 + 107;
					num2 = 263;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 304:
					stream.Close();
					num2 = 43;
					continue;
				case 55:
					if (P6P.Length == 0)
					{
						num2 = 54;
						if (RM() != null)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 73;
				case 301:
					num20 = 99 + 77;
					num2 = 307;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 137:
					num28 = 0u;
					num2 = 423;
					if (nX())
					{
						continue;
					}
					break;
				case 142:
					array[20] = 195;
					num2 = 260;
					continue;
				case 169:
					array[12] = (byte)num20;
					num2 = 286;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 296:
					num20 = 59 + 79;
					num2 = 392;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 102:
					num20 = 48 + 98;
					num2 = 198;
					continue;
				case 329:
					array4[num31] = (byte)(num38 & 0xFF);
					num2 = 239;
					if (RM() != null)
					{
						num2 = 20;
					}
					continue;
				case 410:
					array[13] = 132;
					num = 347;
					break;
				case 350:
					num20 = 114 + 24;
					num2 = 2;
					if (RM() == null)
					{
						num2 = 6;
					}
					continue;
				case 39:
					num20 = 68 + 62;
					num2 = 236;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 386:
					array3[9] = 231;
					num2 = 162;
					if (nX())
					{
						continue;
					}
					break;
				case 89:
					array[4] = (byte)num20;
					num = 187;
					break;
				case 84:
					num32 = 255u;
					num2 = 148;
					if (nX())
					{
						continue;
					}
					break;
				case 328:
					array3[6] = 110;
					num2 = 210;
					continue;
				case 19:
					num20 = 76 + 52;
					num2 = 7;
					continue;
				default:
					array[31] = 68;
					num2 = 315;
					continue;
				case 395:
					num20 = 76 + 67;
					num2 = 215;
					if (RM() == null)
					{
						num2 = 348;
					}
					continue;
				case 25:
					array3[15] = (byte)num21;
					num2 = 399;
					continue;
				case 374:
					num21 = 62 + 2;
					num2 = 15;
					continue;
				case 373:
					P6P = rLIoBbVVpm(stream);
					num2 = 298;
					if (RM() == null)
					{
						num2 = 304;
					}
					continue;
				case 156:
					array[27] = (byte)num20;
					num = 91;
					break;
				case 391:
					if (num26 > 0)
					{
						num2 = 70;
						continue;
					}
					goto case 105;
				case 106:
					num25 = (uint)(num41 * 4);
					num2 = 2;
					if (RM() == null)
					{
						num2 = 227;
					}
					continue;
				case 71:
					array[3] = 199;
					num = 282;
					break;
				case 172:
					num20 = 147 - 71;
					num2 = 120;
					continue;
				case 193:
					array[24] = (byte)num20;
					num2 = 283;
					if (nX())
					{
						continue;
					}
					break;
				case 113:
					array3[1] = 87;
					num2 = 278;
					if (RM() != null)
					{
						num2 = 103;
					}
					continue;
				case 138:
					array[12] = (byte)num20;
					num2 = 158;
					if (!nX())
					{
						num2 = 104;
					}
					continue;
				case 385:
					num20 = 219 - 73;
					num2 = 11;
					if (RM() == null)
					{
						num2 = 17;
					}
					continue;
				case 47:
					num20 = 168 + 18;
					num2 = 169;
					continue;
				case 189:
					array3[2] = (byte)num21;
					num = 333;
					break;
				case 407:
					num20 = 141 + 40;
					num2 = 66;
					continue;
				case 188:
					num21 = 97 + 2;
					num2 = 231;
					continue;
				case 343:
					array3[8] = (byte)num21;
					num2 = 381;
					continue;
				case 217:
					array3[5] = (byte)num21;
					num2 = 337;
					continue;
				case 180:
					array3[7] = (byte)num21;
					num2 = 4;
					continue;
				case 286:
					num20 = 225 - 75;
					num2 = 229;
					continue;
				case 241:
					array[28] = (byte)num20;
					num2 = 82;
					continue;
				case 148:
					num33 = 0;
					num2 = 145;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 3:
					array3[10] = (byte)num21;
					num2 = 30;
					if (RM() == null)
					{
						num2 = 123;
					}
					continue;
				case 312:
					array[0] = (byte)num20;
					num2 = 166;
					continue;
				case 190:
					array3[4] = 123;
					num2 = 376;
					continue;
				case 147:
					num21 = 125 - 41;
					num2 = 320;
					continue;
				case 308:
					array4[num31 + 2] = (byte)((num38 & 0xFF0000) >> 16);
					num = 257;
					break;
				case 239:
					array4[num31 + 1] = (byte)((num38 & 0xFF00) >> 8);
					num2 = 308;
					continue;
				case 352:
					num20 = 87 + 108;
					num2 = 336;
					continue;
				case 139:
					array[27] = (byte)num20;
					num2 = 234;
					continue;
				case 61:
					array3[12] = 132;
					num2 = 149;
					continue;
				case 367:
					array[13] = 69;
					num2 = 410;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 130:
					array3[5] = (byte)num21;
					num2 = 248;
					continue;
				case 216:
					array[14] = (byte)num20;
					num2 = 34;
					continue;
				case 159:
					array2[7] = publicKeyToken[3];
					num2 = 42;
					if (nX())
					{
						continue;
					}
					break;
				case 322:
					num21 = 82 + 67;
					num = 117;
					break;
				case 105:
					num28 += num40;
					num2 = 394;
					continue;
				case 344:
					array[5] = 64;
					num2 = 91;
					if (RM() == null)
					{
						num2 = 101;
					}
					continue;
				case 201:
					array[2] = 130;
					num2 = 275;
					continue;
				case 334:
					array[10] = 16;
					num2 = 243;
					continue;
				case 128:
					array3[8] = (byte)num21;
					num2 = 141;
					continue;
				case 214:
					array = new byte[32];
					num2 = 277;
					if (RM() == null)
					{
						num2 = 356;
					}
					continue;
				case 295:
					num28 += num40;
					num2 = 220;
					if (nX())
					{
						continue;
					}
					break;
				case 79:
					array3[6] = (byte)num21;
					num2 = 93;
					continue;
				case 338:
					array[7] = 107;
					num2 = 319;
					continue;
				case 272:
					num20 = 4 + 64;
					num2 = 173;
					continue;
				case 109:
				case 331:
					num4 = num28;
					num = 379;
					break;
				case 283:
					num20 = 63 + 112;
					num2 = 204;
					continue;
				case 184:
					array[20] = 105;
					num2 = 118;
					continue;
				case 294:
					num20 = 29 + 16;
					num2 = 212;
					continue;
				case 10:
					symmetricAlgorithm = PEXoCqmS4w();
					num2 = 396;
					continue;
				case 330:
					array[22] = 144;
					num2 = 121;
					continue;
				case 365:
					num21 = 46 + 82;
					num2 = 178;
					continue;
				case 16:
					num24 <<= 8;
					num2 = 421;
					continue;
				case 408:
					P6P = array4;
					num2 = 73;
					if (!nX())
					{
						num2 = 12;
					}
					continue;
				case 306:
					array3[1] = (byte)num21;
					num2 = 36;
					if (nX())
					{
						continue;
					}
					break;
				case 360:
					array3[2] = 102;
					num = 318;
					break;
				case 340:
					array[31] = (byte)num20;
					num2 = 321;
					continue;
				case 366:
					num20 = 219 - 95;
					num2 = 171;
					continue;
				case 311:
					array[9] = (byte)num20;
					num = 104;
					break;
				case 164:
					transform = symmetricAlgorithm.CreateDecryptor(array6, array2);
					num2 = 358;
					continue;
				case 177:
					array[1] = (byte)num20;
					num2 = 296;
					continue;
				case 66:
					array[23] = (byte)num20;
					num2 = 86;
					continue;
				case 29:
					array3[13] = 86;
					num2 = 126;
					continue;
				case 251:
					vtNVUKGulysZw81C3E.KDikMXewCI().Position = 0L;
					num2 = 215;
					continue;
				case 181:
					array[14] = 119;
					num2 = 205;
					continue;
				case 297:
					array3[0] = 148;
					num2 = 11;
					if (RM() == null)
					{
						num2 = 176;
					}
					continue;
				case 355:
					array[28] = (byte)num20;
					num2 = 183;
					if (!nX())
					{
						num2 = 3;
					}
					continue;
				case 357:
					array[3] = 150;
					num2 = 378;
					continue;
				case 229:
					array[13] = (byte)num20;
					num2 = 367;
					continue;
				case 320:
					array3[9] = (byte)num21;
					num2 = 264;
					if (nX())
					{
						continue;
					}
					break;
				case 58:
					array[22] = (byte)num20;
					num2 = 201;
					if (RM() == null)
					{
						num2 = 272;
					}
					continue;
				case 231:
					array3[3] = (byte)num21;
					num2 = 365;
					continue;
				case 298:
					return "";
				case 281:
					array2[5] = publicKeyToken[2];
					num2 = 159;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 194:
					array[5] = (byte)num20;
					num2 = 195;
					continue;
				case 117:
					array3[0] = (byte)num21;
					num2 = 368;
					continue;
				case 146:
				case 186:
					num27 = 0;
					num2 = 129;
					if (nX())
					{
						num2 = 131;
					}
					continue;
				case 223:
				case 300:
					if (num34 >= num23)
					{
						num2 = 408;
						continue;
					}
					goto case 12;
				case 243:
					array[11] = 123;
					num2 = 299;
					if (nX())
					{
						continue;
					}
					break;
				case 394:
					num25 = (uint)num31;
					num2 = 265;
					continue;
				case 68:
					num21 = 152 - 50;
					num2 = 339;
					continue;
				case 317:
					array[14] = (byte)num20;
					num2 = 346;
					if (nX())
					{
						continue;
					}
					break;
				case 92:
					num23 = array5.Length / 4;
					num2 = 38;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 245:
					num20 = 203 - 67;
					num2 = 289;
					continue;
				case 163:
					array3[11] = (byte)num21;
					num2 = 305;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 307:
					array[6] = (byte)num20;
					num2 = 400;
					if (RM() != null)
					{
						num2 = 14;
					}
					continue;
				case 387:
					array3[6] = (byte)num21;
					num2 = 98;
					continue;
				case 333:
					num21 = 16 + 49;
					num2 = 165;
					continue;
				case 100:
					num20 = 146 + 28;
					num2 = 100;
					if (nX())
					{
						num2 = 216;
					}
					continue;
				case 389:
					array[23] = 133;
					num2 = 242;
					continue;
				case 173:
					array[23] = (byte)num20;
					num2 = 389;
					if (nX())
					{
						continue;
					}
					break;
				case 22:
					array3[13] = (byte)num21;
					num2 = 279;
					continue;
				case 8:
					num20 = 48 + 88;
					num2 = 293;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 359:
					array[25] = (byte)num20;
					num2 = 5;
					continue;
				case 114:
					array6 = array;
					num2 = 280;
					continue;
				case 143:
					num20 = 115 + 85;
					num2 = 81;
					if (RM() == null)
					{
						num2 = 196;
					}
					continue;
				case 325:
					array[27] = 207;
					num2 = 22;
					if (RM() == null)
					{
						num2 = 385;
					}
					continue;
				case 264:
					array3[9] = 163;
					num2 = 386;
					continue;
				case 95:
					array[11] = 162;
					num2 = 259;
					continue;
				case 83:
					num21 = 219 - 73;
					num2 = 270;
					continue;
				case 376:
					num21 = 178 - 59;
					num = 247;
					break;
				case 12:
					num41 = num34 % num39;
					num = 426;
					break;
				case 282:
					num20 = 99 + 100;
					num2 = 127;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 208:
					num21 = 241 - 80;
					num2 = 377;
					continue;
				case 323:
					array[22] = 17;
					num2 = 261;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 247:
					array3[4] = (byte)num21;
					num2 = 310;
					if (!nX())
					{
						num2 = 126;
					}
					continue;
				case 232:
					array[8] = 93;
					num2 = 17;
					if (nX())
					{
						num2 = 19;
					}
					continue;
				case 7:
					array[8] = (byte)num20;
					num2 = 249;
					continue;
				case 354:
					array[17] = (byte)num20;
					num2 = 1;
					if (nX())
					{
						num2 = 9;
					}
					continue;
				case 291:
					array[12] = 106;
					num2 = 395;
					continue;
				case 275:
					array[2] = 94;
					num2 = 14;
					continue;
				case 289:
					array[25] = (byte)num20;
					num = 102;
					break;
				case 171:
					array[9] = (byte)num20;
					num2 = 64;
					continue;
				case 292:
					num24 = 0u;
					num2 = 43;
					if (RM() == null)
					{
						num2 = 237;
					}
					continue;
				case 246:
					array2[1] = publicKeyToken[0];
					num = 287;
					break;
				case 353:
					array[1] = 141;
					num2 = 258;
					continue;
				case 18:
					num34 = 0;
					num2 = 300;
					if (nX())
					{
						continue;
					}
					break;
				case 166:
					array[0] = 104;
					num = 353;
					break;
				case 326:
					array[15] = 189;
					num2 = 103;
					if (RM() == null)
					{
						num2 = 226;
					}
					continue;
				case 176:
					num21 = 23 + 59;
					num = 151;
					break;
				case 56:
					num26 = array5.Length % 4;
					num2 = 92;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 377:
					array3[14] = (byte)num21;
					num2 = 150;
					continue;
				case 335:
					num20 = 92 + 117;
					num2 = 26;
					continue;
				case 182:
					num20 = 87 + 104;
					num2 = 14;
					if (nX())
					{
						num2 = 58;
					}
					continue;
				case 179:
					if (num34 == num23 - 1)
					{
						num = 250;
						break;
					}
					goto case 342;
				case 254:
					array[16] = (byte)num20;
					num2 = 8;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 249:
					num20 = 152 - 50;
					num2 = 311;
					continue;
				case 421:
					num24 |= array5[array5.Length - (1 + num22)];
					num2 = 199;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 90:
					array2[13] = publicKeyToken[6];
					num2 = 76;
					continue;
				case 284:
					array3[11] = (byte)num21;
					num2 = 114;
					if (RM() == null)
					{
						num2 = 135;
					}
					continue;
				case 2:
					num20 = 48 + 86;
					num2 = 233;
					continue;
				case 145:
					if (num34 == num23 - 1)
					{
						num2 = 134;
						if (RM() == null)
						{
							num2 = 391;
						}
						continue;
					}
					goto case 105;
				case 6:
					array[25] = (byte)num20;
					num2 = 32;
					if (RM() != null)
					{
						num2 = 30;
					}
					continue;
				case 33:
					num21 = 108 + 67;
					num = 21;
					break;
				case 371:
				case 415:
					num34++;
					num2 = 223;
					if (nX())
					{
						continue;
					}
					break;
				case 43:
					cryptoStream.Close();
					num = 401;
					break;
				case 313:
					array[19] = (byte)num20;
					num2 = 184;
					continue;
				case 112:
					num21 = 120 + 99;
					num = 306;
					break;
				case 319:
					array[8] = 38;
					num2 = 232;
					continue;
				case 69:
					array[3] = (byte)num20;
					num2 = 71;
					if (nX())
					{
						continue;
					}
					break;
				case 20:
					if (publicKeyToken == null)
					{
						num = 186;
						break;
					}
					goto case 224;
				case 270:
					array3[15] = (byte)num21;
					num = 132;
					break;
				case 348:
					array[12] = (byte)num20;
					num2 = 27;
					continue;
				case 78:
					array3[15] = (byte)num21;
					num2 = 405;
					continue;
				case 362:
					array[5] = (byte)num20;
					num2 = 344;
					continue;
				case 346:
					array[14] = 107;
					num = 253;
					break;
				case 280:
					array3 = new byte[16];
					num2 = 309;
					continue;
				case 248:
					array3[5] = 89;
					num2 = 328;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 400:
					array[6] = 144;
					num2 = 417;
					if (RM() != null)
					{
						num2 = 260;
					}
					continue;
				case 174:
					array[7] = (byte)num20;
					num2 = 39;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 127:
					array[4] = (byte)num20;
					num2 = 269;
					continue;
				case 122:
					num33 += 8;
					num2 = 202;
					continue;
				case 285:
					num20 = 109 + 10;
					num2 = 153;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 133:
					array[9] = 84;
					num2 = 349;
					continue;
				case 361:
					array3[3] = 91;
					num2 = 402;
					continue;
				case 205:
					num20 = 151 - 50;
					num2 = 272;
					if (RM() == null)
					{
						num2 = 317;
					}
					continue;
				case 227:
					num40 = (uint)((array6[num25 + 3] << 24) | (array6[num25 + 2] << 16) | (array6[num25 + 1] << 8) | array6[num25]);
					num2 = 84;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 86:
					array[24] = 144;
					num2 = 252;
					if (RM() != null)
					{
						num2 = 113;
					}
					continue;
				case 203:
					num20 = 100 + 102;
					num2 = 31;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 226:
					num20 = 117 + 67;
					num2 = 254;
					if (!nX())
					{
						num2 = 228;
					}
					continue;
				case 94:
					num25 = 0u;
					num2 = 18;
					continue;
				case 60:
					array[10] = 164;
					num2 = 406;
					continue;
				case 144:
					num39 = array6.Length / 4;
					num2 = 137;
					if (!nX())
					{
						num2 = 114;
					}
					continue;
				case 262:
					num20 = 49 + 124;
					num2 = 355;
					continue;
				case 206:
					array[19] = 92;
					num = 384;
					break;
				case 287:
					array2[3] = publicKeyToken[1];
					num2 = 281;
					continue;
				case 161:
					Array.Reverse(array2);
					num2 = 341;
					if (!nX())
					{
						num2 = 328;
					}
					continue;
				case 213:
					array[29] = (byte)num20;
					num2 = 46;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 75:
					cryptoStream.FlushFinalBlock();
					num2 = 373;
					continue;
				case 411:
					num27++;
					num2 = 185;
					if (nX())
					{
						continue;
					}
					break;
				case 273:
					array[6] = (byte)num20;
					num2 = 302;
					continue;
				case 257:
					array4[num31 + 3] = (byte)((num38 & 0xFF000000u) >> 24);
					num2 = 415;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 52:
					array[16] = 52;
					num2 = 261;
					if (nX())
					{
						num2 = 316;
					}
					continue;
				case 316:
					array[16] = 225;
					num2 = 332;
					continue;
				case 67:
					if (P_0 == -1)
					{
						num2 = 10;
						if (!nX())
						{
							num2 = 0;
						}
						continue;
					}
					goto case 56;
				case 99:
					num20 = 226 - 75;
					num2 = 174;
					continue;
				case 414:
					array[14] = 82;
					num = 181;
					break;
				case 59:
					array3[13] = (byte)num21;
					num2 = 140;
					if (!nX())
					{
						num2 = 72;
					}
					continue;
				case 140:
					num21 = 173 - 57;
					num2 = 22;
					continue;
				case 290:
					try
					{
						hHEYokUTtehNq5ji0d.LrmWXz();
						int num35 = 1;
						if (RM() == null)
						{
							num35 = 1;
						}
						while (true)
						{
							switch (num35)
							{
							case 1:
								result = Encoding.Unicode.GetString(P6P, P_0 + 4, count);
								num35 = 0;
								if (RM() != null)
								{
									num35 = num36;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num37 = 0;
						if (RM() == null)
						{
							num37 = 0;
						}
						switch (num37)
						{
						}
						goto case 298;
					}
					return result;
				case 121:
					array[22] = 202;
					num2 = 203;
					continue;
				case 153:
					array[21] = (byte)num20;
					num2 = 418;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 80:
					num21 = 246 - 82;
					num2 = 387;
					continue;
				case 305:
					array3[11] = 86;
					num = 134;
					break;
				case 426:
					num31 = num34 * 4;
					num2 = 106;
					continue;
				case 76:
					array2[15] = publicKeyToken[7];
					num2 = 146;
					continue;
				case 382:
					array[15] = 92;
					num2 = 294;
					continue;
				case 198:
					array[25] = (byte)num20;
					num = 350;
					break;
				case 132:
					array3[15] = 101;
					num2 = 427;
					continue;
				case 337:
					num21 = 81 + 117;
					num2 = 130;
					continue;
				case 41:
				case 136:
					if (num30 >= num26)
					{
						num2 = 371;
						if (nX())
						{
							continue;
						}
						break;
					}
					goto case 96;
				case 258:
					array[1] = 11;
					num2 = 207;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 230:
					array[15] = (byte)num20;
					num2 = 382;
					continue;
				case 23:
					num20 = 120 + 120;
					num2 = 398;
					continue;
				case 393:
					array[18] = 145;
					num = 11;
					break;
				case 403:
					num21 = 62 + 99;
					num2 = 268;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 242:
					array[23] = 177;
					num2 = 407;
					continue;
				case 278:
					array3[1] = 48;
					num2 = 397;
					continue;
				case 401:
					array5 = P6P;
					num2 = 56;
					continue;
				case 9:
					array[17] = 110;
					num2 = 63;
					continue;
				case 418:
					array[21] = 132;
					num2 = 170;
					continue;
				case 341:
					publicKeyToken = x4Dk2IHVmX.GetName().GetPublicKeyToken();
					num2 = 20;
					if (!nX())
					{
						num2 = 14;
					}
					continue;
				case 228:
					num20 = 163 - 43;
					num2 = 53;
					continue;
				case 218:
					num29 = num28 ^ num24;
					num2 = 175;
					continue;
				case 364:
					array[2] = (byte)num20;
					num2 = 171;
					if (nX())
					{
						num2 = 363;
					}
					continue;
				case 196:
					array[13] = (byte)num20;
					num2 = 28;
					continue;
				case 240:
					array[26] = 116;
					num2 = 325;
					if (RM() == null)
					{
						num2 = 413;
					}
					continue;
				case 46:
					array[29] = 177;
					num2 = 154;
					continue;
				case 336:
					array[19] = (byte)num20;
					num2 = 167;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 96:
					if (num30 > 0)
					{
						num2 = 30;
						if (RM() == null)
						{
							continue;
						}
						break;
					}
					goto case 202;
				case 204:
					array[24] = (byte)num20;
					num2 = 23;
					continue;
				case 155:
					array[30] = 90;
					num2 = 152;
					continue;
				case 183:
					array[29] = 131;
					num2 = 74;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 256:
					num28 = num4;
					num2 = 179;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 35:
					array3[13] = (byte)num21;
					num2 = 277;
					continue;
				case 397:
					array3[1] = 138;
					num2 = 112;
					if (nX())
					{
						continue;
					}
					break;
				case 250:
					if (num26 > 0)
					{
						num2 = 218;
						if (nX())
						{
							continue;
						}
						break;
					}
					goto case 342;
				case 236:
					array[7] = (byte)num20;
					num2 = 338;
					if (!nX())
					{
						num2 = 107;
					}
					continue;
				case 115:
					num20 = 159 + 4;
					num2 = 273;
					continue;
				case 157:
					array[0] = 65;
					num2 = 40;
					if (nX())
					{
						continue;
					}
					break;
				case 45:
					array[2] = (byte)num20;
					num2 = 416;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 221:
					array[5] = (byte)num20;
					num2 = 404;
					continue;
				case 327:
					array[6] = 100;
					num2 = 115;
					if (nX())
					{
						continue;
					}
					break;
				case 279:
					num21 = 76 + 67;
					num2 = 65;
					continue;
				case 17:
					array[28] = (byte)num20;
					num2 = 97;
					continue;
				case 124:
					array[12] = (byte)num20;
					num = 47;
					break;
				case 120:
					array[21] = (byte)num20;
					num2 = 330;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 54:
					vtNVUKGulysZw81C3E = new VtNVUKGulysZw81C3E(x4Dk2IHVmX.GetManifestResourceStream("FJqiAXJwYKB5Xggukb.IfYOf54PqvhCLfOd3k"));
					num2 = 251;
					continue;
				case 237:
					if (num26 > 0)
					{
						num2 = 1;
						if (!nX())
						{
							num2 = 1;
						}
						continue;
					}
					goto case 94;
				case 44:
					array6[num27] ^= array2[num27];
					num2 = 411;
					if (nX())
					{
						continue;
					}
					break;
				case 134:
					array3[11] = 37;
					num2 = 23;
					if (RM() == null)
					{
						num2 = 61;
					}
					continue;
				case 309:
					num21 = 149 - 49;
					num2 = 420;
					if (nX())
					{
						continue;
					}
					break;
				case 321:
					num20 = 1 + 85;
					num2 = 119;
					if (nX())
					{
						continue;
					}
					break;
				case 160:
					array[21] = (byte)num20;
					num2 = 172;
					continue;
				case 170:
					num20 = 248 - 82;
					num2 = 160;
					continue;
				case 417:
					array[6] = 124;
					num2 = 327;
					continue;
				case 268:
					array3[8] = (byte)num21;
					num = 266;
					break;
				case 101:
					num20 = 136 - 45;
					num2 = 194;
					continue;
				case 51:
					array3[11] = (byte)num21;
					num2 = 388;
					continue;
				case 14:
					num20 = 152 - 50;
					num2 = 45;
					continue;
				case 265:
					num24 = (uint)((array5[num25 + 3] << 24) | (array5[num25 + 2] << 16) | (array5[num25 + 1] << 8) | array5[num25]);
					num2 = 331;
					continue;
				case 310:
					array3[4] = 72;
					num2 = 211;
					if (nX())
					{
						continue;
					}
					break;
				case 1:
					num23++;
					num2 = 94;
					continue;
				case 211:
					num21 = 100 + 33;
					num2 = 217;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 202:
					array4[num31 + num30] = (byte)((num29 & num32) >> num33);
					num2 = 71;
					if (nX())
					{
						num2 = 219;
					}
					continue;
				case 34:
					num20 = 172 - 57;
					num2 = 230;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 62:
					array3[10] = (byte)num21;
					num2 = 419;
					continue;
				case 110:
					array[26] = 138;
					num2 = 240;
					continue;
				case 31:
					array[22] = (byte)num20;
					num2 = 323;
					if (nX())
					{
						continue;
					}
					break;
				case 303:
					array[30] = 79;
					num2 = 335;
					continue;
				case 5:
					array[26] = 192;
					num2 = 110;
					if (nX())
					{
						continue;
					}
					break;
				case 154:
					array[29] = 128;
					num = 267;
					break;
				case 123:
					num21 = 154 - 95;
					num2 = 62;
					continue;
				case 38:
					array4 = new byte[array5.Length];
					num2 = 144;
					continue;
				case 103:
					array3[15] = (byte)num21;
					num2 = 83;
					continue;
				case 277:
					array3[14] = 87;
					num2 = 197;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 85:
					num21 = 96 - 46;
					num = 235;
					break;
				case 149:
					num21 = 50 + 9;
					num2 = 375;
					continue;
				case 192:
					array[10] = 89;
					num2 = 60;
					if (RM() != null)
					{
						num2 = 48;
					}
					continue;
				case 129:
					num20 = 91 + 61;
					num2 = 89;
					continue;
				case 108:
					array3[2] = (byte)num21;
					num2 = 360;
					continue;
				case 356:
					array[0] = 100;
					num2 = 390;
					if (nX())
					{
						continue;
					}
					break;
				case 191:
					array[3] = (byte)num20;
					num2 = 357;
					continue;
				case 271:
					array[21] = (byte)num20;
					num2 = 285;
					continue;
				case 104:
					array[9] = 72;
					num2 = 106;
					if (nX())
					{
						num2 = 133;
					}
					continue;
				case 111:
					array[9] = 152;
					num2 = 366;
					continue;
				case 77:
					array2[11] = publicKeyToken[5];
					num2 = 90;
					continue;
				case 152:
					num20 = 2 + 29;
					num2 = 340;
					continue;
				case 261:
					array[22] = 188;
					num2 = 78;
					if (nX())
					{
						num2 = 182;
					}
					continue;
				case 288:
					array[3] = 115;
					num2 = 225;
					continue;
				case 32:
					num20 = 180 - 72;
					num2 = 359;
					continue;
				case 15:
					array3[6] = (byte)num21;
					num2 = 116;
					continue;
				case 266:
					num21 = 22 + 16;
					num2 = 128;
					continue;
				case 197:
					array3[14] = 161;
					num2 = 168;
					continue;
				case 40:
					num20 = 143 - 47;
					num2 = 312;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 199:
					num22++;
					num2 = 13;
					continue;
				case 369:
					if (num22 > 0)
					{
						num2 = 16;
						continue;
					}
					goto case 421;
				case 200:
					num21 = 61 + 103;
					num2 = 180;
					continue;
				case 88:
					array[18] = (byte)num20;
					num2 = 393;
					continue;
				case 413:
					num20 = 12 + 8;
					num2 = 156;
					if (nX())
					{
						continue;
					}
					break;
				case 425:
					array[31] = 120;
					num2 = 228;
					if (nX())
					{
						continue;
					}
					break;
				case 238:
					array3[1] = (byte)num21;
					num2 = 113;
					continue;
				case 422:
					array[0] = (byte)num20;
					num2 = 157;
					if (nX())
					{
						continue;
					}
					break;
				case 49:
					array3[14] = (byte)num21;
					num2 = 324;
					continue;
				case 50:
					array[20] = (byte)num20;
					num2 = 142;
					continue;
				case 342:
					num38 = num28 ^ num24;
					num = 329;
					break;
				case 409:
					num21 = 171 - 57;
					num2 = 25;
					if (RM() == null)
					{
						continue;
					}
					break;
				case 234:
					array[27] = 185;
					num2 = 314;
					continue;
				case 405:
					array2 = array3;
					num2 = 161;
					continue;
				case 158:
					num20 = 67 + 72;
					num2 = 124;
					continue;
				case 299:
					array[11] = 61;
					num2 = 95;
					continue;
				case 150:
					num21 = 53 + 85;
					num2 = 276;
					if (nX())
					{
						continue;
					}
					break;
				case 267:
					array[29] = 179;
					num2 = 303;
					continue;
				case 396:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 164;
					if (nX())
					{
						continue;
					}
					break;
				case 48:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 766294713u;
					uint num7 = 1802274269u;
					uint num8 = 1180766026u;
					uint num9 = num5;
					uint num10 = 1494039358u;
					uint num11 = 1989657910u;
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
					num2 = 256;
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

	private static int V6I()
	{
		return 5;
	}

	private static void v6x()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate N6r(IntPtr P_0, Type P_1)
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

	private static IntPtr t6Z(IntPtr P_0, string P_1, uint P_2)
	{
		if (vVJ == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Find ".Trim() + "ResourceA");
			vVJ = (Cq)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Cq));
		}
		return vVJ(P_0, P_1, P_2);
	}

	private static IntPtr a6n(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (IV9 == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			IV9 = (ne)Marshal.GetDelegateForFunctionPointer(ptr, typeof(ne));
		}
		return IV9(P_0, P_1, P_2, P_3);
	}

	private static int T6a(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (NVh == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			NVh = (MC)Marshal.GetDelegateForFunctionPointer(ptr, typeof(MC));
		}
		return NVh(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int T6q(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (UVm == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Virtual ".Trim() + "Protect");
			UVm = (JV)Marshal.GetDelegateForFunctionPointer(ptr, typeof(JV));
		}
		return UVm(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr N6W(uint P_0, int P_1, uint P_2)
	{
		if (mVw == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Open ".Trim() + "Process");
			mVw = (k2)Marshal.GetDelegateForFunctionPointer(ptr, typeof(k2));
		}
		return mVw(P_0, P_1, P_2);
	}

	private static int v6U(IntPtr P_0)
	{
		if (HV4 == null)
		{
			IntPtr ptr = oGjoaYPPLS(umLocehuEC(), "Close ".Trim() + "Handle");
			HV4 = (rM)Marshal.GetDelegateForFunctionPointer(ptr, typeof(rM));
		}
		return HV4(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (AVu == IntPtr.Zero)
		{
			AVu = H1sorrpiaP("kernel ".Trim() + "32.dll");
		}
		return AVu;
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] q6H(string P_0)
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
	private static byte[] Q66(byte[] P_0)
	{
		Stream stream = Njco6C1nc4();
		SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
		symmetricAlgorithm.Key = new byte[32]
		{
			120, 165, 236, 135, 75, 11, 163, 144, 78, 178,
			99, 85, 141, 20, 239, 136, 21, 232, 71, 212,
			102, 37, 141, 125, 175, 250, 125, 235, 142, 245,
			68, 68
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			31, 2, 79, 217, 41, 184, 167, 26, 147, 228,
			178, 228, 76, 95, 181, 254
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = rLIoBbVVpm(stream);
		hHEYokUTtehNq5ji0d.LrmWXz();
		return result;
	}

	private byte[] m6V()
	{
		return null;
	}

	private byte[] b65()
	{
		return null;
	}

	private byte[] S6R()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] k6E()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] N6s()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] c6L()
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

	internal static bool nX()
	{
		return (object)null == null;
	}

	internal static object RM()
	{
		return null;
	}
}
