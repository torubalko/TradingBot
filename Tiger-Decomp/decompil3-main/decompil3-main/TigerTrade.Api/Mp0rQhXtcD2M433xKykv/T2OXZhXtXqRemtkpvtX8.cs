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
using lmDVLFXTelX8TWB2gCPn;
using nXNMiwXTSjaRAVOuyCXd;
using Wdpou3XTwslLv0fuRs4G;
using WUsie0XTELvQJLckfItk;

namespace Mp0rQhXtcD2M433xKykv;

internal class T2OXZhXtXqRemtkpvtX8
{
	private delegate void MVUx63XU39vMW2V3slAC(object o);

	internal class Vaq8BoXUpoVM6Ytn11Fw : Attribute
	{
		internal class GBXmbFXUus5AjVpiskBb<LGAZGCXUzq3dnYEhrry2>
		{
			private static object Vjk9TwX8F8TB2F7wUmkR;

			public GBXmbFXUus5AjVpiskBb()
			{
				ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
				base._002Ector();
			}

			static GBXmbFXUus5AjVpiskBb()
			{
				g1uXtTdsjEL();
				opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool SB6rqeX83BwlvOJqTqSE()
			{
				return Vjk9TwX8F8TB2F7wUmkR == null;
			}

			internal static object H4gvuZX8pGmls6rqtFIS()
			{
				return Vjk9TwX8F8TB2F7wUmkR;
			}
		}

		public Vaq8BoXUpoVM6Ytn11Fw(object P_0)
		{
		}

		static Vaq8BoXUpoVM6Ytn11Fw()
		{
			eBYbaDX8JcMQwakbkipI();
		}

		internal static void eBYbaDX8JcMQwakbkipI()
		{
			opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class oA48s7XT0rGyP72Abs1u
	{
		internal static string VsPXT2oU7KW(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] array = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = u5VXtIbSIdm(((Encoding)htdwJSXA2N084D2WGEf7()).GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = XskXtOOsjp3();
			UnKmpQXAHdd2lFOpTRBP(symmetricAlgorithm, array);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return (string)Ts25GOXAfF0uipcqtk1s(memoryStream.ToArray());
		}

		static oA48s7XT0rGyP72Abs1u()
		{
			opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object htdwJSXA2N084D2WGEf7()
		{
			return Encoding.Unicode;
		}

		internal static void UnKmpQXAHdd2lFOpTRBP(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		internal static object Ts25GOXAfF0uipcqtk1s(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint pND2WhXTHYd5uxxySumu(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr e9GqbKXTfaqmrp2pwWvd();

	internal struct sV2Kf6XT9ToVFtaxMta2
	{
		internal bool wwOXTnEGcEJ;

		internal byte[] upoXTGfqn8s;
	}

	internal class H5eCOjXTYRdoELpYcijW
	{
		private BinaryReader xxjXTiNZldg;

		public H5eCOjXTYRdoELpYcijW(Stream P_0)
		{
			xxjXTiNZldg = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return (Stream)XaAZ4GXAB0SVDxkNtFBM(xxjXTiNZldg);
		}

		internal byte[] OD7XTooLu0b(int P_0)
		{
			return xxjXTiNZldg.ReadBytes(P_0);
		}

		internal int BN1XTvBOuY3(byte[] P_0, int P_1, int P_2)
		{
			return yeWEpMXAaG0Is7Ix2TbJ(xxjXTiNZldg, P_0, P_1, P_2);
		}

		internal int D7IXTBBfY7o()
		{
			return xxjXTiNZldg.ReadInt32();
		}

		internal void QoUXTat4k29()
		{
			xxjXTiNZldg.Close();
		}

		static H5eCOjXTYRdoELpYcijW()
		{
			opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object XaAZ4GXAB0SVDxkNtFBM(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static int yeWEpMXAaG0Is7Ix2TbJ(object P_0, object P_1, int P_2, int P_3)
		{
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr z6bYV9XTlYgnDo3pnUom(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr YRsG4wXT4IxIskqki7ba(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Thm6AqXTDAY4YvgQCrUa(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int VXfaqXXTb6px9RSNtPhT(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr opTup2XTNX76wYdfJ2ZM(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int pNXtLoXTkcxOK3YmAXfg(IntPtr ptr);

	[Flags]
	private enum Ax9norXT1jI4lvEdJtUT
	{

	}

	private static object ho6XUe94QsT;

	private static int[] GCvXU6cykF4;

	internal static pND2WhXTHYd5uxxySumu AVqXUtcusK4;

	internal static pND2WhXTHYd5uxxySumu eAtXUULh4eT;

	private static int JbyXUC808BZ;

	private static int b6FXUsrAfg1;

	private static List<int> YimXUjU5g5Q;

	private static long KeFXUW5oWwI;

	private static string lKVXUFjWARJ;

	private static bool GWyXU5dbVIj;

	private static object RJuXUXYd96w;

	private static IntPtr fejXUgObTKf;

	private static int nTWXUMBIugU;

	private static bool xGkXUSTfVXx;

	private static z6bYV9XTlYgnDo3pnUom BOkXUhLV1LW;

	private static object xnNXURk27pL;

	private static opTup2XTNX76wYdfJ2ZM V62XUAwPvt2;

	[Vaq8BoXUpoVM6Ytn11Fw(typeof(Vaq8BoXUpoVM6Ytn11Fw.GBXmbFXUus5AjVpiskBb<object>[]))]
	private static bool F7JXUKTT7fB;

	private static List<string> U65XUcG5QBA;

	private static pNXtLoXTkcxOK3YmAXfg GwtXUPDP5Tw;

	internal static Hashtable sRxXUmjyYYg;

	private static byte[] K3BXUE4VApY;

	private static IntPtr n1QXUJfemKC;

	private static IntPtr fg9XUrAP2FE;

	private static Thm6AqXTDAY4YvgQCrUa byDXU7wFvVA;

	private static int kZ2XUI9JcXJ;

	private static SortedList Rk1XUqfArIq;

	private static YRsG4wXT4IxIskqki7ba UOwXUwE65Ek;

	private static uint[] l8UXU10aOKU;

	private static bool zd7XUZW3Iwh;

	internal static Assembly tSIXUkH9Bxr;

	private static Dictionary<int, int> OteXULDSRpN;

	private static bool pHFXUNxCXwl;

	internal static RSACryptoServiceProvider DfIXUxFDPBe;

	private static long PqeXUTXFFkI;

	private static bool TkUXUVopxjE;

	private static bool LlCXUOpyluV;

	private static VXfaqXXTb6px9RSNtPhT maJXU8nBSFU;

	private static int nOaXUyAIZiZ;

	private static IntPtr BTlXUdoqZo9;

	private static byte[] Hu5XUQiifbE;

	static T2OXZhXtXqRemtkpvtX8()
	{
		opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
		pHFXUNxCXwl = false;
		tSIXUkH9Bxr = Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554458)).Assembly;
		l8UXU10aOKU = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		GWyXU5dbVIj = false;
		xGkXUSTfVXx = false;
		DfIXUxFDPBe = null;
		OteXULDSRpN = null;
		ho6XUe94QsT = new object();
		b6FXUsrAfg1 = 0;
		RJuXUXYd96w = new object();
		U65XUcG5QBA = null;
		YimXUjU5g5Q = null;
		K3BXUE4VApY = new byte[0];
		Hu5XUQiifbE = new byte[0];
		BTlXUdoqZo9 = IntPtr.Zero;
		fejXUgObTKf = IntPtr.Zero;
		xnNXURk27pL = new string[0];
		GCvXU6cykF4 = new int[0];
		nTWXUMBIugU = 1;
		LlCXUOpyluV = false;
		Rk1XUqfArIq = new SortedList();
		kZ2XUI9JcXJ = 0;
		KeFXUW5oWwI = 0L;
		AVqXUtcusK4 = null;
		eAtXUULh4eT = null;
		PqeXUTXFFkI = 0L;
		nOaXUyAIZiZ = 0;
		zd7XUZW3Iwh = false;
		TkUXUVopxjE = false;
		JbyXUC808BZ = 0;
		fg9XUrAP2FE = IntPtr.Zero;
		F7JXUKTT7fB = false;
		sRxXUmjyYYg = new Hashtable();
		BOkXUhLV1LW = null;
		UOwXUwE65Ek = null;
		byDXU7wFvVA = null;
		maJXU8nBSFU = null;
		V62XUAwPvt2 = null;
		GwtXUPDP5Tw = null;
		n1QXUJfemKC = IntPtr.Zero;
		lKVXUFjWARJ = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void g2QXuzaijh3()
	{
	}

	internal static byte[] EOPXtj04Qcj(byte[] P_0)
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
			LwWXtEsZv5t(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			LwWXtEsZv5t(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			LwWXtEsZv5t(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			LwWXtEsZv5t(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			LwWXtEsZv5t(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			LwWXtEsZv5t(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			LwWXtEsZv5t(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			LwWXtEsZv5t(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			LwWXtEsZv5t(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			LwWXtEsZv5t(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			LwWXtEsZv5t(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			LwWXtEsZv5t(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			LwWXtEsZv5t(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			LwWXtEsZv5t(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			LwWXtEsZv5t(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			LwWXtEsZv5t(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			WnfXtQrDCZU(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			WnfXtQrDCZU(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			WnfXtQrDCZU(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			WnfXtQrDCZU(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			WnfXtQrDCZU(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			WnfXtQrDCZU(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			WnfXtQrDCZU(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			WnfXtQrDCZU(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			WnfXtQrDCZU(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			WnfXtQrDCZU(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			WnfXtQrDCZU(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			WnfXtQrDCZU(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			WnfXtQrDCZU(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			WnfXtQrDCZU(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			WnfXtQrDCZU(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			WnfXtQrDCZU(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			obuXtdiragP(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			obuXtdiragP(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			obuXtdiragP(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			obuXtdiragP(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			obuXtdiragP(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			obuXtdiragP(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			obuXtdiragP(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			obuXtdiragP(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			obuXtdiragP(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			obuXtdiragP(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			obuXtdiragP(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			obuXtdiragP(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			obuXtdiragP(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			obuXtdiragP(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			obuXtdiragP(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			obuXtdiragP(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			uSsXtgkYHyY(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			uSsXtgkYHyY(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			uSsXtgkYHyY(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			uSsXtgkYHyY(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			uSsXtgkYHyY(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			uSsXtgkYHyY(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			uSsXtgkYHyY(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			uSsXtgkYHyY(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			uSsXtgkYHyY(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			uSsXtgkYHyY(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			uSsXtgkYHyY(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			uSsXtgkYHyY(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			uSsXtgkYHyY(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			uSsXtgkYHyY(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			uSsXtgkYHyY(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			uSsXtgkYHyY(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void LwWXtEsZv5t(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + EfFXtRL9Wes(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + l8UXU10aOKU[P_6 - 1], P_5);
	}

	private static void WnfXtQrDCZU(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + EfFXtRL9Wes(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + l8UXU10aOKU[P_6 - 1], P_5);
	}

	private static void obuXtdiragP(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + EfFXtRL9Wes(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + l8UXU10aOKU[P_6 - 1], P_5);
	}

	private static void uSsXtgkYHyY(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + EfFXtRL9Wes(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + l8UXU10aOKU[P_6 - 1], P_5);
	}

	private static uint EfFXtRL9Wes(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool POwXt6MuxgR()
	{
		if (!GWyXU5dbVIj)
		{
			MDnXtqY0qrN();
			GWyXU5dbVIj = true;
		}
		return xGkXUSTfVXx;
	}

	internal T2OXZhXtXqRemtkpvtX8()
	{
	}

	private void JTCXtMUZtoc(byte[] P_0, byte[] P_1, byte[] P_2)
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
		K3BXUE4VApY = array;
	}

	internal static SymmetricAlgorithm XskXtOOsjp3()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (POwXt6MuxgR())
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

	internal static void MDnXtqY0qrN()
	{
		try
		{
			xGkXUSTfVXx = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] u5VXtIbSIdm(byte[] P_0)
	{
		if (!POwXt6MuxgR())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return EOPXtj04Qcj(P_0);
	}

	internal static void MB0XtWe2GcP(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			MGvXtto4mD7(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void MGvXtto4mD7(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint NdjXtUvIFf6(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void g1uXtTdsjEL()
	{
		int num = 21;
		bool flag = default(bool);
		string text = default(string);
		BinaryReader binaryReader = default(BinaryReader);
		int num27 = default(int);
		int num16 = default(int);
		uint num18 = default(uint);
		byte[] array7 = default(byte[]);
		uint num25 = default(uint);
		uint num19 = default(uint);
		long num26 = default(long);
		long num24 = default(long);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		uint num21 = default(uint);
		byte[] array6 = default(byte[]);
		uint num20 = default(uint);
		string text2 = default(string);
		long num15 = default(long);
		long num22 = default(long);
		uint num29 = default(uint);
		long num17 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					if (DfIXUxFDPBe == null)
					{
						num2 = 20;
						continue;
					}
					return;
				case 3:
				case 12:
					if (!flag)
					{
						num2 = 18;
						continue;
					}
					goto case 19;
				case 13:
					num2 = 8;
					continue;
				case 14:
					text = (string)lTQDJNXwDDSmvZi0eY7L(MnoJKVXw4TbqrrGciuor(typeof(T2OXZhXtXqRemtkpvtX8).TypeHandle).Assembly);
					num2 = 4;
					continue;
				case 5:
					try
					{
						H5eCOjXTYRdoELpYcijW h5eCOjXTYRdoELpYcijW = new H5eCOjXTYRdoELpYcijW((Stream)iIcF0EXw5EITa3T6XPlV(tSIXUkH9Bxr, "nNqUu7Xt4uU6fY9DLuoe.4vC5IiXtDqJc7fSZs5Gu"));
						LqMFflXwxm4Qlu7cfI2G(mj9I14XwS3C9CgaT8eYM(h5eCOjXTYRdoELpYcijW), 0L);
						byte[] array = (byte[])d87YQnXweDH7Zhlog0nb(h5eCOjXTYRdoELpYcijW, (int)CWnvVxXwLoMJqdGfQFIk(mj9I14XwS3C9CgaT8eYM(h5eCOjXTYRdoELpYcijW)));
						byte[] array2 = new byte[32];
						array2[0] = 99;
						int num3 = 159 - 53;
						array2[0] = (byte)num3;
						int num4 = 128 + 109;
						array2[0] = (byte)num4;
						num4 = 201 - 67;
						array2[1] = (byte)num4;
						array2[1] = 94;
						num4 = 107 - 66;
						array2[1] = (byte)num4;
						array2[2] = 143;
						num4 = 212 - 70;
						array2[2] = (byte)num4;
						array2[2] = 142;
						array2[2] = 95;
						array2[3] = 132;
						num3 = 97 + 58;
						array2[3] = (byte)num3;
						num4 = 102 + 11;
						array2[3] = (byte)num4;
						array2[3] = 9;
						array2[4] = 144;
						array2[4] = 77;
						num4 = 220 - 100;
						array2[4] = (byte)num4;
						num3 = 191 - 63;
						array2[5] = (byte)num3;
						num3 = 194 - 64;
						array2[5] = (byte)num3;
						array2[5] = 85;
						array2[5] = 96;
						array2[5] = 100;
						array2[6] = 156;
						num3 = 203 - 67;
						array2[6] = (byte)num3;
						array2[6] = 90;
						array2[6] = 181;
						array2[7] = 104;
						array2[7] = 160;
						num4 = 66 + 113;
						array2[7] = (byte)num4;
						num3 = 30 + 104;
						array2[7] = (byte)num3;
						array2[8] = 127;
						array2[8] = 150;
						num3 = 105 + 82;
						array2[8] = (byte)num3;
						array2[8] = 63;
						array2[9] = 160;
						array2[9] = 83;
						array2[9] = 102;
						array2[9] = 168;
						num4 = 204 - 68;
						array2[10] = (byte)num4;
						num4 = 185 - 61;
						array2[10] = (byte)num4;
						array2[10] = 51;
						array2[10] = 116;
						num3 = 134 + 23;
						array2[10] = (byte)num3;
						num3 = 40 + 69;
						array2[11] = (byte)num3;
						array2[11] = 145;
						num4 = 114 + 63;
						array2[11] = (byte)num4;
						num4 = 121 + 87;
						array2[11] = (byte)num4;
						num3 = 50 + 26;
						array2[11] = (byte)num3;
						num3 = 79 - 1;
						array2[11] = (byte)num3;
						num3 = 61 + 40;
						array2[12] = (byte)num3;
						num4 = 95 + 4;
						array2[12] = (byte)num4;
						num3 = 108 + 94;
						array2[12] = (byte)num3;
						num3 = 121 - 15;
						array2[12] = (byte)num3;
						num4 = 166 - 55;
						array2[13] = (byte)num4;
						num3 = 70 + 91;
						array2[13] = (byte)num3;
						num4 = 154 - 51;
						array2[13] = (byte)num4;
						num4 = 187 - 62;
						array2[13] = (byte)num4;
						array2[13] = 155;
						array2[13] = 97;
						array2[14] = 153;
						array2[14] = 144;
						num3 = 45 + 62;
						array2[14] = (byte)num3;
						num4 = 86 + 65;
						array2[14] = (byte)num4;
						num3 = 39 + 104;
						array2[14] = (byte)num3;
						num4 = 117 + 43;
						array2[14] = (byte)num4;
						array2[15] = 114;
						array2[15] = 115;
						num4 = 179 - 59;
						array2[15] = (byte)num4;
						array2[15] = 100;
						array2[15] = 61;
						array2[15] = 177;
						num3 = 99 + 26;
						array2[16] = (byte)num3;
						num4 = 145 - 48;
						array2[16] = (byte)num4;
						num3 = 69 - 1;
						array2[16] = (byte)num3;
						array2[17] = 92;
						array2[17] = 149;
						array2[17] = 218;
						num4 = 62 + 120;
						array2[18] = (byte)num4;
						num4 = 180 - 60;
						array2[18] = (byte)num4;
						num4 = 24 + 35;
						array2[18] = (byte)num4;
						array2[18] = 86;
						num4 = 129 + 92;
						array2[18] = (byte)num4;
						array2[19] = 170;
						num3 = 87 + 54;
						array2[19] = (byte)num3;
						array2[19] = 132;
						num3 = 18 + 116;
						array2[19] = (byte)num3;
						array2[19] = 24;
						num3 = 181 - 60;
						array2[20] = (byte)num3;
						num4 = 179 - 59;
						array2[20] = (byte)num4;
						num3 = 234 - 78;
						array2[20] = (byte)num3;
						num4 = 214 + 13;
						array2[20] = (byte)num4;
						array2[21] = 152;
						array2[21] = 87;
						array2[21] = 148;
						num3 = 188 - 62;
						array2[22] = (byte)num3;
						array2[22] = 74;
						num4 = 126 - 42;
						array2[22] = (byte)num4;
						array2[22] = 81;
						array2[23] = 156;
						array2[23] = 162;
						array2[23] = 92;
						num4 = 133 - 66;
						array2[23] = (byte)num4;
						num4 = 41 + 44;
						array2[24] = (byte)num4;
						num4 = 229 - 76;
						array2[24] = (byte)num4;
						num3 = 91 - 64;
						array2[24] = (byte)num3;
						num3 = 190 - 63;
						array2[25] = (byte)num3;
						num4 = 49 + 66;
						array2[25] = (byte)num4;
						num4 = 173 + 10;
						array2[25] = (byte)num4;
						array2[26] = 152;
						array2[26] = 123;
						num3 = 158 - 108;
						array2[26] = (byte)num3;
						array2[27] = 174;
						array2[27] = 92;
						num4 = 96 - 72;
						array2[27] = (byte)num4;
						num3 = 60 + 11;
						array2[28] = (byte)num3;
						array2[28] = 94;
						array2[28] = 218;
						array2[29] = 94;
						array2[29] = 155;
						num3 = 129 + 82;
						array2[29] = (byte)num3;
						array2[30] = 233;
						num3 = 101 + 118;
						array2[30] = (byte)num3;
						array2[30] = 99;
						array2[30] = 213;
						num4 = 65 + 103;
						array2[31] = (byte)num4;
						num3 = 159 - 53;
						array2[31] = (byte)num3;
						num4 = 211 - 70;
						array2[31] = (byte)num4;
						array2[31] = 5;
						byte[] array3 = array2;
						byte[] array4 = new byte[16];
						int num5 = 150 - 50;
						array4[0] = (byte)num5;
						num5 = 27 + 106;
						array4[0] = (byte)num5;
						array4[0] = 124;
						num5 = 99 - 15;
						array4[0] = (byte)num5;
						array4[1] = 129;
						num5 = 158 - 52;
						array4[1] = (byte)num5;
						num5 = 160 - 53;
						array4[1] = (byte)num5;
						num5 = 62 + 67;
						array4[1] = (byte)num5;
						array4[1] = 130;
						num5 = 118 - 17;
						array4[1] = (byte)num5;
						num5 = 235 - 78;
						array4[2] = (byte)num5;
						array4[2] = 144;
						array4[2] = 79;
						array4[2] = 165;
						array4[2] = 179;
						array4[3] = 119;
						num5 = 196 - 65;
						array4[3] = (byte)num5;
						num5 = 42 + 36;
						array4[3] = (byte)num5;
						array4[3] = 132;
						array4[3] = 106;
						num5 = 135 + 13;
						array4[3] = (byte)num5;
						array4[4] = 140;
						num5 = 74 + 75;
						array4[4] = (byte)num5;
						num5 = 198 + 0;
						array4[4] = (byte)num5;
						array4[5] = 222;
						num5 = 112 + 51;
						array4[5] = (byte)num5;
						array4[5] = 94;
						num5 = 36 + 4;
						array4[5] = (byte)num5;
						array4[5] = 128;
						array4[5] = 17;
						array4[6] = 163;
						num5 = 145 - 48;
						array4[6] = (byte)num5;
						array4[6] = 104;
						num5 = 120 + 8;
						array4[6] = (byte)num5;
						array4[6] = 93;
						array4[6] = 142;
						array4[7] = 127;
						num5 = 64 + 51;
						array4[7] = (byte)num5;
						num5 = 134 + 88;
						array4[7] = (byte)num5;
						num5 = 2 + 23;
						array4[8] = (byte)num5;
						num5 = 53 + 44;
						array4[8] = (byte)num5;
						array4[8] = 116;
						array4[8] = 114;
						num5 = 74 - 61;
						array4[8] = (byte)num5;
						num5 = 174 - 58;
						array4[9] = (byte)num5;
						num5 = 139 - 46;
						array4[9] = (byte)num5;
						num5 = 247 - 82;
						array4[9] = (byte)num5;
						array4[9] = 233;
						array4[10] = 114;
						num5 = 251 - 83;
						array4[10] = (byte)num5;
						num5 = 170 - 56;
						array4[10] = (byte)num5;
						num5 = 125 - 55;
						array4[10] = (byte)num5;
						array4[11] = 98;
						num5 = 73 + 63;
						array4[11] = (byte)num5;
						array4[11] = 163;
						array4[11] = 88;
						num5 = 104 + 53;
						array4[11] = (byte)num5;
						num5 = 50 + 113;
						array4[11] = (byte)num5;
						array4[12] = 102;
						array4[12] = 96;
						array4[12] = 55;
						num5 = 163 + 35;
						array4[12] = (byte)num5;
						num5 = 180 - 60;
						array4[13] = (byte)num5;
						num5 = 23 + 49;
						array4[13] = (byte)num5;
						array4[13] = 145;
						num5 = 224 - 74;
						array4[13] = (byte)num5;
						num5 = 99 - 0;
						array4[13] = (byte)num5;
						num5 = 79 + 87;
						array4[14] = (byte)num5;
						num5 = 33 + 28;
						array4[14] = (byte)num5;
						num5 = 18 + 40;
						array4[14] = (byte)num5;
						num5 = 48 + 24;
						array4[14] = (byte)num5;
						array4[14] = 52;
						array4[15] = 121;
						num5 = 162 - 54;
						array4[15] = (byte)num5;
						num5 = 128 - 42;
						array4[15] = (byte)num5;
						array4[15] = 173;
						num5 = 175 - 121;
						array4[15] = (byte)num5;
						byte[] array5 = array4;
						object obj = pjc9StXwsgn8lZ7A0rAc();
						oQlFIfXwXWYqFmD4Wwoy(obj, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)KuV9avXwcVU3wBAxmkYG(obj, array3, array5);
						Stream stream = (Stream)qH3jynXwjo2qItyru3Ui();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						YS2ExaXwE62GnUgut1YF(cryptoStream, array, 0, array.Length);
						l80WR9XwQPjFBlqmN0Fq(cryptoStream);
						kBYlVPXw62dkpAFFM5WY(DfIXUxFDPBe, tCrOaCXwR9eeX19yTDv4(KXdb59XwdgC292ufHg4i(), BVDgqIXwgh6OUSwm2ruj(stream)));
						fRwgG6XwMYep6BrNLV7L(stream);
						fRwgG6XwMYep6BrNLV7L(cryptoStream);
						ueBjWjXwOW2rZNf4VPIq(h5eCOjXTYRdoELpYcijW);
						int num6 = 0;
						if (m72g72XwasfL4HEaI7u5() == null)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num7 = 1;
						if (!ihGGg6XwBVH9rlLuwiy2())
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								flag = true;
								num7 = 0;
								if (ihGGg6XwBVH9rlLuwiy2())
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
					goto case 11;
				default:
					binaryReader = null;
					num2 = 6;
					if (!ihGGg6XwBVH9rlLuwiy2())
					{
						num2 = 5;
					}
					continue;
				case 6:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num12 = 19;
						if (!ihGGg6XwBVH9rlLuwiy2())
						{
							num12 = 13;
						}
						while (true)
						{
							switch (num12)
							{
							case 15:
							case 22:
								if (num27 >= num16)
								{
									num12 = 7;
									continue;
								}
								goto case 42;
							case 30:
								LqMFflXwxm4Qlu7cfI2G(fileStream, num18 + 32);
								num12 = 0;
								if (m72g72XwasfL4HEaI7u5() == null)
								{
									num12 = 0;
								}
								continue;
							case 36:
								num27 = 0;
								num12 = 22;
								continue;
							case 34:
								array7 = (byte[])twjxfJXwC3R5voIgYa3X(binaryReader, (int)num25);
								num12 = 6;
								if (!ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 6;
								}
								continue;
							case 19:
								binaryReader = new BinaryReader(fileStream);
								num12 = 15;
								if (ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 43;
								}
								continue;
							case 39:
								LqMFflXwxm4Qlu7cfI2G(fileStream, oAgZJJXwURbtk4kdts9V(fileStream) + num19);
								num12 = 9;
								if (!ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 5;
								}
								continue;
							case 21:
								if (num26 < num24)
								{
									num12 = 16;
									if (ihGGg6XwBVH9rlLuwiy2())
									{
										num12 = 28;
									}
									continue;
								}
								goto case 8;
							case 12:
								gPMV8rXwqfqpmIKkqNYY(hashAlgorithm, fileStream, num21, array6);
								num12 = 10;
								continue;
							case 11:
								num20 = GAKpUEXwTkA1PVvDs21L(binaryReader);
								num12 = 1;
								if (!ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 1;
								}
								continue;
							case 38:
								flag = !o2eDjoXwmpviA9QEW9d6(DfIXUxFDPBe, qkibUgXwKcJi3T0Ug4FA(hashAlgorithm), text2, array7);
								num12 = 18;
								if (!ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 11;
								}
								continue;
							case 28:
								num19 = (uint)(num24 - num26);
								num12 = 16;
								if (m72g72XwasfL4HEaI7u5() != null)
								{
									num12 = 10;
								}
								continue;
							case 5:
							case 13:
								num18 = oAVA1HXwyXpxOt6E4UdJ(GAKpUEXwTkA1PVvDs21L(binaryReader), num16, num15, binaryReader);
								num12 = 30;
								continue;
							case 20:
								gPMV8rXwqfqpmIKkqNYY(hashAlgorithm, fileStream, 152u, array6);
								num12 = 29;
								continue;
							case 8:
								if (num26 < num24)
								{
									num12 = 41;
									if (m72g72XwasfL4HEaI7u5() != null)
									{
										num12 = 10;
									}
									continue;
								}
								goto case 12;
							case 42:
								LqMFflXwxm4Qlu7cfI2G(fileStream, num15 + num27 * 40 + 16);
								num12 = 33;
								continue;
							case 24:
								if (num22 <= num26)
								{
									num12 = 21;
									continue;
								}
								goto case 8;
							case 17:
							case 41:
								num29 = (uint)EMdPUVXwZAD3LQqt6XO4(num22 - num26, num21);
								num12 = 40;
								continue;
							case 31:
							case 44:
								num26 = oAgZJJXwURbtk4kdts9V(fileStream);
								num12 = 8;
								if (m72g72XwasfL4HEaI7u5() == null)
								{
									num12 = 24;
								}
								continue;
							case 33:
								num21 = GAKpUEXwTkA1PVvDs21L(binaryReader);
								num12 = 11;
								if (m72g72XwasfL4HEaI7u5() != null)
								{
									num12 = 7;
								}
								continue;
							case 25:
								num21 -= num29;
								num12 = 14;
								continue;
							case 43:
								array6 = new byte[65536];
								num12 = 20;
								continue;
							case 23:
								LqMFflXwxm4Qlu7cfI2G(fileStream, 360L);
								num12 = 13;
								continue;
							case 10:
							case 32:
								num27++;
								num12 = 15;
								continue;
							case 1:
								LqMFflXwxm4Qlu7cfI2G(fileStream, num20);
								num12 = 37;
								continue;
							case 35:
								LqMFflXwxm4Qlu7cfI2G(fileStream, num17);
								num12 = 36;
								if (!ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 23;
								}
								continue;
							case 2:
							case 26:
								LqMFflXwxm4Qlu7cfI2G(fileStream, 376L);
								num12 = 5;
								if (!ihGGg6XwBVH9rlLuwiy2())
								{
									num12 = 2;
								}
								continue;
							case 40:
								gPMV8rXwqfqpmIKkqNYY(hashAlgorithm, fileStream, num29, array6);
								num12 = 25;
								continue;
							case 7:
								MA9SaxXwVInKBpoSmphj(hashAlgorithm, new byte[0], 0, 0);
								num12 = 27;
								continue;
							case 6:
								PX8wFIXwr8tYRRBk1mjR(array7);
								num12 = 38;
								continue;
							default:
							{
								uint num28 = GAKpUEXwTkA1PVvDs21L(binaryReader);
								num25 = GAKpUEXwTkA1PVvDs21L(binaryReader);
								num22 = oAVA1HXwyXpxOt6E4UdJ(num28, num16, num15, binaryReader);
								num12 = 3;
								continue;
							}
							case 9:
							case 14:
							case 37:
								if (num21 != 0)
								{
									num12 = 31;
									if (m72g72XwasfL4HEaI7u5() != null)
									{
										num12 = 12;
									}
									continue;
								}
								goto case 10;
							case 3:
								num24 = num22 + num25;
								num12 = 35;
								continue;
							case 4:
							{
								num21 -= num19;
								int num23 = 39;
								num12 = num23;
								continue;
							}
							case 27:
								LqMFflXwxm4Qlu7cfI2G(fileStream, num22);
								num12 = 34;
								continue;
							case 16:
								if (num19 < num21)
								{
									num12 = 4;
									continue;
								}
								goto case 10;
							case 29:
							{
								bool num13 = bv2fVLXwIPECkmghsxH3(binaryReader) != 523;
								int num14 = (num13 ? 96 : 112);
								LqMFflXwxm4Qlu7cfI2G(fileStream, 152L);
								dBatm8XwWpkSH9dm6jSS(fileStream, array6, 0, num14);
								array6[64] = 0;
								array6[65] = 0;
								array6[66] = 0;
								array6[67] = 0;
								mBcfypXwt4FkgJwgVHmS(hashAlgorithm, array6, 0, num14);
								dBatm8XwWpkSH9dm6jSS(fileStream, array6, 0, 128);
								array6[32] = 0;
								array6[33] = 0;
								array6[34] = 0;
								array6[35] = 0;
								array6[36] = 0;
								array6[37] = 0;
								array6[38] = 0;
								array6[39] = 0;
								mBcfypXwt4FkgJwgVHmS(hashAlgorithm, array6, 0, 128);
								num15 = oAgZJJXwURbtk4kdts9V(fileStream);
								LqMFflXwxm4Qlu7cfI2G(fileStream, 134L);
								num16 = bv2fVLXwIPECkmghsxH3(binaryReader);
								LqMFflXwxm4Qlu7cfI2G(fileStream, num15);
								gPMV8rXwqfqpmIKkqNYY(hashAlgorithm, fileStream, (uint)(num16 * 40), array6);
								num17 = oAgZJJXwURbtk4kdts9V(fileStream);
								if (!num13)
								{
									num12 = 2;
									continue;
								}
								goto case 23;
							}
							case 18:
								break;
							}
							break;
						}
					}
					catch
					{
						int num30 = 0;
						if (!ihGGg6XwBVH9rlLuwiy2())
						{
							num30 = 0;
						}
						while (true)
						{
							switch (num30)
							{
							default:
								flag = true;
								num30 = 1;
								if (ihGGg6XwBVH9rlLuwiy2())
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
					goto case 13;
				case 8:
					try
					{
						if (binaryReader != null)
						{
							int num10 = 0;
							if (m72g72XwasfL4HEaI7u5() == null)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									gqoDr6XwhOySVUWTcie2(binaryReader);
									num10 = 1;
									if (ihGGg6XwBVH9rlLuwiy2())
									{
										num10 = 1;
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
						int num11 = 0;
						if (m72g72XwasfL4HEaI7u5() != null)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 15:
					DfIXUxFDPBe = new RSACryptoServiceProvider();
					num = 14;
					break;
				case 9:
					return;
				case 4:
					if (text != null)
					{
						num = 7;
						break;
					}
					return;
				case 17:
					text2 = null;
					num2 = 16;
					continue;
				case 20:
					sMsKbIXwiMbIYxcJm0AN();
					num2 = 1;
					if (m72g72XwasfL4HEaI7u5() == null)
					{
						num2 = 1;
					}
					continue;
				case 16:
					try
					{
						hashAlgorithm = (HashAlgorithm)vRvd6kXwN8uNibOIr4R7();
						int num8 = 1;
						if (!ihGGg6XwBVH9rlLuwiy2())
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							case 2:
								return;
							case 3:
								if (!D9wxF3Xw17wY1jUWhRYU(text))
								{
									num8 = 2;
									if (m72g72XwasfL4HEaI7u5() == null)
									{
										num8 = 2;
									}
									continue;
								}
								break;
							case 1:
								text2 = (string)fcovupXwkmO4RJcMJljK("SHA1");
								num8 = 0;
								if (m72g72XwasfL4HEaI7u5() == null)
								{
									num8 = 3;
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
						int num9 = 0;
						if (m72g72XwasfL4HEaI7u5() != null)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 2;
				case 1:
					KJ9IEiXwlCAtVAD0PU8y(true);
					num2 = 1;
					if (ihGGg6XwBVH9rlLuwiy2())
					{
						num2 = 15;
					}
					continue;
				case 7:
					if (yapZ49XwbGsVsjDiRsgS(text) == 0)
					{
						num2 = 10;
						if (!ihGGg6XwBVH9rlLuwiy2())
						{
							num2 = 0;
						}
					}
					else
					{
						hashAlgorithm = null;
						num2 = 17;
					}
					continue;
				case 2:
					flag = false;
					num2 = 1;
					if (ihGGg6XwBVH9rlLuwiy2())
					{
						num2 = 5;
					}
					continue;
				case 11:
					if (flag)
					{
						num2 = 0;
						if (m72g72XwasfL4HEaI7u5() == null)
						{
							num2 = 12;
						}
						continue;
					}
					goto default;
				case 19:
					throw new Exception((string)BHbd5ZXw8kkNh8j5td5Q(OnmjpPXw7uAe1m5Xo0cb(wsGIUbXwwIUjKDqOHRge(MnoJKVXw4TbqrrGciuor(typeof(T2OXZhXtXqRemtkpvtX8).TypeHandle).Assembly)), " is tampered."));
				case 18:
					flag = false;
					num2 = 9;
					if (m72g72XwasfL4HEaI7u5() != null)
					{
						num2 = 7;
					}
					continue;
				case 10:
					return;
				}
				break;
			}
		}
	}

	public static void JKRXtyo4RuY(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (OteXULDSRpN == null)
			{
				lock (ho6XUe94QsT)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554458)).Assembly.GetManifestResourceStream("rEgNIkXt5maW47MCfbKF.b8pAOcXtSBphBN4rAT5Z"));
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
							num3 += sVPXtCh6cMB(num3);
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
						H5eCOjXTYRdoELpYcijW h5eCOjXTYRdoELpYcijW = new H5eCOjXTYRdoELpYcijW(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = h5eCOjXTYRdoELpYcijW.D7IXTBBfY7o();
							int value = h5eCOjXTYRdoELpYcijW.D7IXTBBfY7o();
							dictionary.Add(key, value);
						}
						h5eCOjXTYRdoELpYcijW.QoUXTat4k29();
					}
					OteXULDSRpN = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = OteXULDSRpN[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554458)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(16777236));
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

	private static uint HGjXtVWhpMx(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint sVPXtCh6cMB(uint P_0)
	{
		return 0u;
	}

	internal static void kDpXtrkmVqg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void MC4XtKgPoCJ(Stream P_0, int P_1)
	{
		e2KEnqXThmPeu5Bnihhm.fr0XTPHRFRg(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string cdCXtmiQMBZ(int P_0)
	{
		if (K3BXUE4VApY.Length == 0)
		{
			U65XUcG5QBA = new List<string>();
			YimXUjU5g5Q = new List<int>();
			MC4XtKgPoCJ(tSIXUkH9Bxr.GetManifestResourceStream("Ux9YU3XtBtd8lWct5WU4.PyDI8aXtajbih0ba9ekp"), P_0);
		}
		if (b6FXUsrAfg1 < 75)
		{
			if (tSIXUkH9Bxr != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			b6FXUsrAfg1++;
		}
		lock (RJuXUXYd96w)
		{
			int num = BitConverter.ToInt32(K3BXUE4VApY, P_0);
			if (num < YimXUjU5g5Q.Count && YimXUjU5g5Q[num] == P_0)
			{
				return U65XUcG5QBA[num];
			}
			try
			{
				ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
				byte[] array = new byte[num];
				Array.Copy(K3BXUE4VApY, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				U65XUcG5QBA.Add(text);
				YimXUjU5g5Q.Add(P_0);
				Array.Copy(BitConverter.GetBytes(U65XUcG5QBA.Count - 1), 0, K3BXUE4VApY, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string pEoXthSHHqo(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int lMuXtwK5Ts7()
	{
		return 5;
	}

	private static void tbJXt7NPWUW()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate BdQXt8YFiE7(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(16777325)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(16777263)),
			Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(16777275))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object yDyXtAjZklO(object P_0)
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
	public static extern IntPtr UXFXtPkp2o6(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr McWXtJ8KN93(IntPtr P_0, string P_1);

	private static IntPtr UfPXtFVkD6w(IntPtr P_0, string P_1, uint P_2)
	{
		if (BOkXUhLV1LW == null)
		{
			BOkXUhLV1LW = (z6bYV9XTlYgnDo3pnUom)Marshal.GetDelegateForFunctionPointer(McWXtJ8KN93(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554467)));
		}
		return BOkXUhLV1LW(P_0, P_1, P_2);
	}

	private static IntPtr EsyXt3Xg7ec(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (UOwXUwE65Ek == null)
		{
			UOwXUwE65Ek = (YRsG4wXT4IxIskqki7ba)Marshal.GetDelegateForFunctionPointer(McWXtJ8KN93(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554468)));
		}
		return UOwXUwE65Ek(P_0, P_1, P_2, P_3);
	}

	private static int LIEXtpYcA0w(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (byDXU7wFvVA == null)
		{
			byDXU7wFvVA = (Thm6AqXTDAY4YvgQCrUa)Marshal.GetDelegateForFunctionPointer(McWXtJ8KN93(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554469)));
		}
		return byDXU7wFvVA(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int ArSXtuCogiU(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (maJXU8nBSFU == null)
		{
			maJXU8nBSFU = (VXfaqXXTb6px9RSNtPhT)Marshal.GetDelegateForFunctionPointer(McWXtJ8KN93(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554470)));
		}
		return maJXU8nBSFU(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr sNRXtzHWPpo(uint P_0, int P_1, uint P_2)
	{
		if (V62XUAwPvt2 == null)
		{
			V62XUAwPvt2 = (opTup2XTNX76wYdfJ2ZM)Marshal.GetDelegateForFunctionPointer(McWXtJ8KN93(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554471)));
		}
		return V62XUAwPvt2(P_0, P_1, P_2);
	}

	private static int DSoXU0RJEsl(IntPtr P_0)
	{
		if (GwtXUPDP5Tw == null)
		{
			GwtXUPDP5Tw = (pNXtLoXTkcxOK3YmAXfg)Marshal.GetDelegateForFunctionPointer(McWXtJ8KN93(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554472)));
		}
		return GwtXUPDP5Tw(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (n1QXUJfemKC == IntPtr.Zero)
		{
			n1QXUJfemKC = UXFXtPkp2o6("kernel ".Trim() + "32.dll");
		}
		return n1QXUJfemKC;
	}

	private static byte[] T5mXU2sV6yb(string P_0)
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

	internal static Stream jcnXUHoZyPW()
	{
		return new MemoryStream();
	}

	internal static byte[] bl6XUfXbwx9(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] qJ9XU9pIKp1(byte[] P_0)
	{
		Stream stream = jcnXUHoZyPW();
		SymmetricAlgorithm symmetricAlgorithm = XskXtOOsjp3();
		symmetricAlgorithm.Key = new byte[32]
		{
			199, 130, 89, 20, 149, 55, 0, 175, 45, 174,
			168, 104, 104, 52, 156, 251, 57, 80, 131, 93,
			42, 164, 146, 135, 104, 27, 52, 207, 9, 91,
			202, 205
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			186, 156, 59, 76, 187, 28, 107, 10, 100, 38,
			51, 103, 113, 251, 100, 41
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = bl6XUfXbwx9(stream);
		ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
		return result;
	}

	private unsafe static int BBtXUnUKiO4(string P_0)
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

	internal static bool NIFXUGeqEFn(string P_0, string P_1)
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
		if (P_0.StartsWith(lKVXUFjWARJ))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(lKVXUFjWARJ))
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
			num = BBtXUnUKiO4(P_0);
		}
		if (!flag2)
		{
			num2 = BBtXUnUKiO4(P_1);
		}
		return num == num2;
	}

	private byte[] G70XUYnQHvW()
	{
		return null;
	}

	private byte[] y1RXUoPTMdn()
	{
		return null;
	}

	private byte[] gEyXUvStBOI()
	{
		return null;
	}

	private byte[] UlfXUB5RLgc()
	{
		return null;
	}

	private byte[] z3CXUaJIwXG()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] H6bXUioYMGj()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] Ww8XUl9e4j7()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] NYQXU4besHM()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] vROXUDDaUQr()
	{
		return null;
	}

	internal byte[] xCEXUbLpM1B()
	{
		return null;
	}

	internal static object nmBRFMXhAyRH1cP24koG(object P_0)
	{
		return ((H5eCOjXTYRdoELpYcijW)P_0).m9OIO8Q0EK();
	}

	internal static void UosAK7XhPJj9PWUY7lR9(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long iQHlkrXhJ03nrORMueqp(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object K2XmxQXhFwhvE13v8J6v(object P_0, int P_1)
	{
		return ((H5eCOjXTYRdoELpYcijW)P_0).OD7XTooLu0b(P_1);
	}

	internal static void zhSkv8Xh37IgEeXxdwt6(object P_0)
	{
		((H5eCOjXTYRdoELpYcijW)P_0).QoUXTat4k29();
	}

	internal static void JOqbbKXhpkEcX0myI2P9(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object d1fgU6XhuHG4FBtVMZwA(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object SsvaiyXhzke5XNu0yIWg(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object XvvwFeXw0YqemSf7oudA()
	{
		return XskXtOOsjp3();
	}

	internal static void QolQA0Xw2mX0UaZO5QHe(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object LakUREXwHTBGHnm92Q6T(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object X6It7SXwfeb4EgrgoLbs()
	{
		return jcnXUHoZyPW();
	}

	internal static void qgoaOOXw9JeLEThRiBi0(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void NN3WdFXwnFoRwabRxX6V(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object L8dKrcXwGqngiXRWeUwC(object P_0)
	{
		return bl6XUfXbwx9((Stream)P_0);
	}

	internal static void IApj1xXwYgSdfeSkh9iI(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object HO6JKXXwopbe9ImUxyLn(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool AFnoXZXwvd5YuIabVUF3(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool B20v0tXh7mafhKl2LLuG()
	{
		return (object)null == null;
	}

	internal static object jxTDLhXh8DbsmqDmTZJt()
	{
		return null;
	}

	internal static void sMsKbIXwiMbIYxcJm0AN()
	{
		ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
	}

	internal static void KJ9IEiXwlCAtVAD0PU8y(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type MnoJKVXw4TbqrrGciuor(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object lTQDJNXwDDSmvZi0eY7L(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int yapZ49XwbGsVsjDiRsgS(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object vRvd6kXwN8uNibOIr4R7()
	{
		return SHA1.Create();
	}

	internal static object fcovupXwkmO4RJcMJljK(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool D9wxF3Xw17wY1jUWhRYU(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object iIcF0EXw5EITa3T6XPlV(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object mj9I14XwS3C9CgaT8eYM(object P_0)
	{
		return ((H5eCOjXTYRdoELpYcijW)P_0).m9OIO8Q0EK();
	}

	internal static void LqMFflXwxm4Qlu7cfI2G(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long CWnvVxXwLoMJqdGfQFIk(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object d87YQnXweDH7Zhlog0nb(object P_0, int P_1)
	{
		return ((H5eCOjXTYRdoELpYcijW)P_0).OD7XTooLu0b(P_1);
	}

	internal static object pjc9StXwsgn8lZ7A0rAc()
	{
		return XskXtOOsjp3();
	}

	internal static void oQlFIfXwXWYqFmD4Wwoy(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object KuV9avXwcVU3wBAxmkYG(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object qH3jynXwjo2qItyru3Ui()
	{
		return jcnXUHoZyPW();
	}

	internal static void YS2ExaXwE62GnUgut1YF(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void l80WR9XwQPjFBlqmN0Fq(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object KXdb59XwdgC292ufHg4i()
	{
		return Encoding.UTF8;
	}

	internal static object BVDgqIXwgh6OUSwm2ruj(object P_0)
	{
		return bl6XUfXbwx9((Stream)P_0);
	}

	internal static object tCrOaCXwR9eeX19yTDv4(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void kBYlVPXw62dkpAFFM5WY(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void fRwgG6XwMYep6BrNLV7L(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void ueBjWjXwOW2rZNf4VPIq(object P_0)
	{
		((H5eCOjXTYRdoELpYcijW)P_0).QoUXTat4k29();
	}

	internal static void gPMV8rXwqfqpmIKkqNYY(object P_0, object P_1, uint P_2, object P_3)
	{
		MB0XtWe2GcP((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort bv2fVLXwIPECkmghsxH3(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int dBatm8XwWpkSH9dm6jSS(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void mBcfypXwt4FkgJwgVHmS(object P_0, object P_1, int P_2, int P_3)
	{
		MGvXtto4mD7((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long oAgZJJXwURbtk4kdts9V(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint GAKpUEXwTkA1PVvDs21L(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint oAVA1HXwyXpxOt6E4UdJ(uint P_0, int P_1, long P_2, object P_3)
	{
		return NdjXtUvIFf6(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long EMdPUVXwZAD3LQqt6XO4(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object MA9SaxXwVInKBpoSmphj(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object twjxfJXwC3R5voIgYa3X(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void PX8wFIXwr8tYRRBk1mjR(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object qkibUgXwKcJi3T0Ug4FA(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool o2eDjoXwmpviA9QEW9d6(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void gqoDr6XwhOySVUWTcie2(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object wsGIUbXwwIUjKDqOHRge(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object OnmjpPXw7uAe1m5Xo0cb(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object BHbd5ZXw8kkNh8j5td5Q(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool ihGGg6XwBVH9rlLuwiy2()
	{
		return (object)null == null;
	}

	internal static object m72g72XwasfL4HEaI7u5()
	{
		return null;
	}
}
