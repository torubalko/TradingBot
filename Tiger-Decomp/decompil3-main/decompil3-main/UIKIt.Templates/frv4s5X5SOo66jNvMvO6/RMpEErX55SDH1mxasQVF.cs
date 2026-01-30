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
using hkZMMTXxD6qN8IAyOFGI;
using LEd148XxVLCrGO7jKJBd;
using MhxjOdXxkI6wEJmk4G3f;
using PWXKwRXxL9cVgWUpa4xk;

namespace frv4s5X5SOo66jNvMvO6;

internal class RMpEErX55SDH1mxasQVF
{
	private delegate void b0XdPcXS7IRtUsN0x1in(object o);

	internal class sAQoUSXS85Y0ka0F9PaI : Attribute
	{
		internal class u55rPUXSApArQQomY5rF<GtMlU8XSPOcBo6F8mn0R>
		{
			internal static object msGUZqXg8IE9fgStal0j;

			public u55rPUXSApArQQomY5rF()
			{
				Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
				base._002Ector();
			}

			static u55rPUXSApArQQomY5rF()
			{
				v64X5Ol3UFK();
				inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool eAj24rXgAtcuMQPo4OKy()
			{
				return msGUZqXg8IE9fgStal0j == null;
			}

			internal static object IJ0FaBXgPXdbs7ehP8Ik()
			{
				return msGUZqXg8IE9fgStal0j;
			}
		}

		public sAQoUSXS85Y0ka0F9PaI(object P_0)
		{
		}

		static sAQoUSXS85Y0ka0F9PaI()
		{
			inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class AEInrQXSJI8tlHnUgaDG
	{
		internal static string SrKXSFJ923R(string P_0, string P_1)
		{
			byte[] array = (byte[])OPvRBFXgpcO3gU0mIda4(Encoding.Unicode, P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = (byte[])z46V7CXgzGD8ueorUVJE(OPvRBFXgpcO3gU0mIda4(EyNOskXgu5ufMvRD29ff(), P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = AFUX5QCjkpf();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			Y87eQVXR0aB3WVcmhttZ(cryptoStream, array, 0, array.Length);
			PuhoL5XR2wT2HwIhNiZQ(cryptoStream);
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		static AEInrQXSJI8tlHnUgaDG()
		{
			inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object OPvRBFXgpcO3gU0mIda4(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static object EyNOskXgu5ufMvRD29ff()
		{
			return Encoding.Unicode;
		}

		internal static object z46V7CXgzGD8ueorUVJE(object P_0)
		{
			return rARX5gGXGbG((byte[])P_0);
		}

		internal static void Y87eQVXR0aB3WVcmhttZ(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void PuhoL5XR2wT2HwIhNiZQ(object P_0)
		{
			((Stream)P_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint OGGEjdXS3Y6Q6Txyh2dk(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr ivFVNbXSpLZdMkS2pywA();

	internal struct XP3eUdXSunX2dv09Xy6O
	{
		internal bool yllXSzmkh1K;

		internal byte[] OnEXx0hDN3V;
	}

	internal class YjMTdEXx2JCASdVCVphO
	{
		private BinaryReader EedXxGTYpdM;

		public YjMTdEXx2JCASdVCVphO(Stream P_0)
		{
			EedXxGTYpdM = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return EedXxGTYpdM.BaseStream;
		}

		internal byte[] VUMXxHeTqDm(int P_0)
		{
			return (byte[])Tp8lN4XRowSlNQg8UYXj(EedXxGTYpdM, P_0);
		}

		internal int zuAXxfw8KuQ(byte[] P_0, int P_1, int P_2)
		{
			return EedXxGTYpdM.Read(P_0, P_1, P_2);
		}

		internal int Q7ZXx95LeXG()
		{
			return EedXxGTYpdM.ReadInt32();
		}

		internal void KDpXxnPfGsD()
		{
			EedXxGTYpdM.Close();
		}

		static YjMTdEXx2JCASdVCVphO()
		{
			kLIKhvXRvBxWZAGqfFq4();
		}

		internal static object Tp8lN4XRowSlNQg8UYXj(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static void kLIKhvXRvBxWZAGqfFq4()
		{
			inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr vC0QqBXxYSbK6KppnlPM(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr o8qtKDXxoyj6l88A6m1h(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int LPvkOyXxvjvwONnjc0sL(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int At2np9XxBQJnrsLxk9l9(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr vSm715Xxa96Yh7afkWSK(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int D8o0LgXxiTu9GLxOQqAo(IntPtr ptr);

	[Flags]
	private enum jp46N3Xxl5pVkjpHJhvP
	{

	}

	private static object QCKXSk2GU9a;

	private static SortedList p4RXSdCI0V3;

	private static IntPtr mjSXShnXy8Y;

	private static IntPtr fv0XSsdVZo2;

	internal static Hashtable QqCXSykhcBn;

	private static List<string> HW2XSSKaJmV;

	private static uint[] PgxXSltuFLK;

	private static IntPtr vhQXSXRjjxU;

	private static List<int> WXWXSxTpNDa;

	private static object BpXXSc4OYWG;

	private static LPvkOyXxvjvwONnjc0sL H9rXSCarmad;

	private static vC0QqBXxYSbK6KppnlPM brvXSZxVqIa;

	private static byte[] agcXSLSVqCd;

	private static IntPtr bSBXSUl16OH;

	internal static Assembly TNmXSiuahlF;

	private static long OoeXSOkLytl;

	private static o8qtKDXxoyj6l88A6m1h znGXSVuSv0e;

	private static bool cq9XSakYt9u;

	private static int lSbXStld3mY;

	private static object U1HXS5mNhTq;

	private static At2np9XxBQJnrsLxk9l9 F9gXSrJexRR;

	internal static OGGEjdXS3Y6Q6Txyh2dk LmeXSMJtsjL;

	private static int ISTXSgSsnAZ;

	internal static OGGEjdXS3Y6Q6Txyh2dk fB4XS642MGB;

	private static D8o0LgXxiTu9GLxOQqAo TGpXSmONxjo;

	private static byte[] xeYXSeZb81J;

	private static string fEcXSwIUkqa;

	private static int gAOXSqs2wnR;

	private static long cdnXSRmgcTd;

	private static int j2qXSEUjxLq;

	private static Dictionary<int, int> eimXSNw4wk0;

	private static bool v80XSQ1rXYu;

	private static bool QsWXS46cwE4;

	private static int YXvXS1LOH4O;

	private static vSm715Xxa96Yh7afkWSK GMPXSKQx8lo;

	[sAQoUSXS85Y0ka0F9PaI(typeof(sAQoUSXS85Y0ka0F9PaI.u55rPUXSApArQQomY5rF<object>[]))]
	private static bool LGeXSTLKhKC;

	internal static RSACryptoServiceProvider pv5XSbuGb41;

	private static bool jm6XSWjPTdm;

	private static int[] yDKXSj4aanp;

	private static bool pl0XSDokykl;

	private static bool kxiXSI7YhSl;

	static RMpEErX55SDH1mxasQVF()
	{
		inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
		cq9XSakYt9u = false;
		TNmXSiuahlF = Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554448)).Assembly;
		PgxXSltuFLK = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		QsWXS46cwE4 = false;
		pl0XSDokykl = false;
		pv5XSbuGb41 = null;
		eimXSNw4wk0 = null;
		QCKXSk2GU9a = new object();
		YXvXS1LOH4O = 0;
		U1HXS5mNhTq = new object();
		HW2XSSKaJmV = null;
		WXWXSxTpNDa = null;
		agcXSLSVqCd = new byte[0];
		xeYXSeZb81J = new byte[0];
		fv0XSsdVZo2 = IntPtr.Zero;
		vhQXSXRjjxU = IntPtr.Zero;
		BpXXSc4OYWG = new string[0];
		yDKXSj4aanp = new int[0];
		j2qXSEUjxLq = 1;
		v80XSQ1rXYu = false;
		p4RXSdCI0V3 = new SortedList();
		ISTXSgSsnAZ = 0;
		cdnXSRmgcTd = 0L;
		fB4XS642MGB = null;
		LmeXSMJtsjL = null;
		OoeXSOkLytl = 0L;
		gAOXSqs2wnR = 0;
		kxiXSI7YhSl = false;
		jm6XSWjPTdm = false;
		lSbXStld3mY = 0;
		bSBXSUl16OH = IntPtr.Zero;
		LGeXSTLKhKC = false;
		QqCXSykhcBn = new Hashtable();
		brvXSZxVqIa = null;
		znGXSVuSv0e = null;
		H9rXSCarmad = null;
		F9gXSrJexRR = null;
		GMPXSKQx8lo = null;
		TGpXSmONxjo = null;
		mjSXShnXy8Y = IntPtr.Zero;
		fEcXSwIUkqa = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void HCUXtG0dDOO()
	{
	}

	internal static byte[] nwmX5xK9Ww1(byte[] P_0)
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
			eDOX5LHTwIJ(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			eDOX5LHTwIJ(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			eDOX5LHTwIJ(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			eDOX5LHTwIJ(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			eDOX5LHTwIJ(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			eDOX5LHTwIJ(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			eDOX5LHTwIJ(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			eDOX5LHTwIJ(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			eDOX5LHTwIJ(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			eDOX5LHTwIJ(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			eDOX5LHTwIJ(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			eDOX5LHTwIJ(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			eDOX5LHTwIJ(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			eDOX5LHTwIJ(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			eDOX5LHTwIJ(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			eDOX5LHTwIJ(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			iDZX5eHmq84(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			iDZX5eHmq84(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			iDZX5eHmq84(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			iDZX5eHmq84(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			iDZX5eHmq84(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			iDZX5eHmq84(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			iDZX5eHmq84(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			iDZX5eHmq84(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			iDZX5eHmq84(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			iDZX5eHmq84(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			iDZX5eHmq84(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			iDZX5eHmq84(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			iDZX5eHmq84(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			iDZX5eHmq84(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			iDZX5eHmq84(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			iDZX5eHmq84(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			KuLX5syL2Up(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			KuLX5syL2Up(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			KuLX5syL2Up(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			KuLX5syL2Up(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			KuLX5syL2Up(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			KuLX5syL2Up(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			KuLX5syL2Up(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			KuLX5syL2Up(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			KuLX5syL2Up(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			KuLX5syL2Up(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			KuLX5syL2Up(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			KuLX5syL2Up(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			KuLX5syL2Up(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			KuLX5syL2Up(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			KuLX5syL2Up(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			KuLX5syL2Up(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			Q27X5XLwNVg(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			Q27X5XLwNVg(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			Q27X5XLwNVg(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			Q27X5XLwNVg(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			Q27X5XLwNVg(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			Q27X5XLwNVg(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			Q27X5XLwNVg(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			Q27X5XLwNVg(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			Q27X5XLwNVg(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			Q27X5XLwNVg(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			Q27X5XLwNVg(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			Q27X5XLwNVg(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			Q27X5XLwNVg(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			Q27X5XLwNVg(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			Q27X5XLwNVg(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			Q27X5XLwNVg(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void eDOX5LHTwIJ(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + GdrX5ce0p6W(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + PgxXSltuFLK[P_6 - 1], P_5);
	}

	private static void iDZX5eHmq84(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + GdrX5ce0p6W(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + PgxXSltuFLK[P_6 - 1], P_5);
	}

	private static void KuLX5syL2Up(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + GdrX5ce0p6W(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + PgxXSltuFLK[P_6 - 1], P_5);
	}

	private static void Q27X5XLwNVg(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + GdrX5ce0p6W(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + PgxXSltuFLK[P_6 - 1], P_5);
	}

	private static uint GdrX5ce0p6W(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool YGBX5jfPTSM()
	{
		if (!QsWXS46cwE4)
		{
			vgLX5dEa3JV();
			QsWXS46cwE4 = true;
		}
		return pl0XSDokykl;
	}

	internal RMpEErX55SDH1mxasQVF()
	{
	}

	private void FwDX5EeqMr9(byte[] P_0, byte[] P_1, byte[] P_2)
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
		agcXSLSVqCd = array;
	}

	internal static SymmetricAlgorithm AFUX5QCjkpf()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (YGBX5jfPTSM())
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

	internal static void vgLX5dEa3JV()
	{
		try
		{
			pl0XSDokykl = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] rARX5gGXGbG(byte[] P_0)
	{
		if (!YGBX5jfPTSM())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return nwmX5xK9Ww1(P_0);
	}

	internal static void s62X5R4ZppK(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			RUkX56yDJOn(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void RUkX56yDJOn(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint X3VX5M68vJg(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void v64X5Ol3UFK()
	{
		int num = 11;
		bool flag = default(bool);
		string text = default(string);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array2 = default(byte[]);
		int num19 = default(int);
		int num11 = default(int);
		long num12 = default(long);
		uint num14 = default(uint);
		long num10 = default(long);
		uint num18 = default(uint);
		uint num24 = default(uint);
		uint num23 = default(uint);
		uint num15 = default(uint);
		long num16 = default(long);
		long num21 = default(long);
		long num17 = default(long);
		uint num20 = default(uint);
		byte[] array = default(byte[]);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					CHqM5FXQwtwWNYQs5Res();
					num2 = 16;
					continue;
				case 10:
					return;
				case 14:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				case 16:
					break;
				case 12:
					pv5XSbuGb41 = new RSACryptoServiceProvider();
					num2 = 18;
					if (AEpLBbXQhtWW8594uvUX() != null)
					{
						num2 = 6;
					}
					continue;
				case 21:
					if (xNLZJ9XQPXGg3BBwaFpU(text) == 0)
					{
						num2 = 17;
						if (!roRxFeXQmkN2Ix8r8fOc())
						{
							num2 = 17;
						}
					}
					else
					{
						hashAlgorithm = null;
						num2 = 20;
					}
					continue;
				case 2:
					try
					{
						YjMTdEXx2JCASdVCVphO yjMTdEXx2JCASdVCVphO = new YjMTdEXx2JCASdVCVphO((Stream)HcOk8eXQpblvf3iyaDBp(TNmXSiuahlF, "7S4O9cX5oc2BREN0kZ3x.Za08eiX5vEbvikFUu9Af"));
						fiQ2eiXQzSNfFgBorgee(QxeUZAXQu9mrIK0hol1L(yjMTdEXx2JCASdVCVphO), 0L);
						byte[] array3 = (byte[])O7BcuiXd2CeOeaAu0EKe(yjMTdEXx2JCASdVCVphO, (int)DfnjREXd08cgCWi4VrHv(QxeUZAXQu9mrIK0hol1L(yjMTdEXx2JCASdVCVphO)));
						byte[] array4 = new byte[32];
						array4[0] = 97;
						array4[0] = 96;
						array4[0] = 142;
						array4[0] = 20;
						array4[1] = 96;
						array4[1] = 146;
						array4[1] = 150;
						int num26 = 193 - 64;
						array4[1] = (byte)num26;
						array4[1] = 119;
						num26 = 148 + 57;
						array4[1] = (byte)num26;
						num26 = 217 - 72;
						array4[2] = (byte)num26;
						array4[2] = 161;
						array4[2] = 187;
						array4[3] = 96;
						num26 = 25 + 78;
						array4[3] = (byte)num26;
						num26 = 204 - 68;
						array4[3] = (byte)num26;
						array4[3] = 110;
						num26 = 5 + 83;
						array4[3] = (byte)num26;
						array4[3] = 84;
						num26 = 191 - 63;
						array4[4] = (byte)num26;
						num26 = 0 + 42;
						array4[4] = (byte)num26;
						num26 = 118 + 10;
						array4[4] = (byte)num26;
						num26 = 22 + 100;
						array4[5] = (byte)num26;
						num26 = 246 - 82;
						array4[5] = (byte)num26;
						num26 = 208 - 94;
						array4[5] = (byte)num26;
						num26 = 43 + 1;
						array4[6] = (byte)num26;
						array4[6] = 173;
						num26 = 26 + 120;
						array4[6] = (byte)num26;
						num26 = 15 + 21;
						array4[6] = (byte)num26;
						array4[6] = 141;
						array4[7] = 100;
						num26 = 243 - 81;
						array4[7] = (byte)num26;
						array4[7] = 231;
						array4[7] = 219;
						array4[8] = 136;
						array4[8] = 83;
						array4[8] = 179;
						array4[9] = 177;
						array4[9] = 107;
						num26 = 29 + 112;
						array4[9] = (byte)num26;
						array4[10] = 134;
						num26 = 174 - 58;
						array4[10] = (byte)num26;
						array4[10] = 174;
						num26 = 25 + 6;
						array4[10] = (byte)num26;
						num26 = 144 - 48;
						array4[10] = (byte)num26;
						array4[10] = 142;
						array4[11] = 107;
						num26 = 112 + 50;
						array4[11] = (byte)num26;
						array4[11] = 146;
						num26 = 254 - 84;
						array4[11] = (byte)num26;
						array4[11] = 84;
						array4[11] = 42;
						num26 = 229 - 76;
						array4[12] = (byte)num26;
						num26 = 193 - 64;
						array4[12] = (byte)num26;
						num26 = 124 + 4;
						array4[12] = (byte)num26;
						num26 = 149 - 49;
						array4[12] = (byte)num26;
						array4[12] = 29;
						num26 = 187 - 62;
						array4[13] = (byte)num26;
						num26 = 247 - 82;
						array4[13] = (byte)num26;
						array4[13] = 121;
						array4[13] = 88;
						num26 = 151 - 50;
						array4[13] = (byte)num26;
						num26 = 79 - 64;
						array4[13] = (byte)num26;
						array4[14] = 84;
						num26 = 137 - 45;
						array4[14] = (byte)num26;
						array4[14] = 96;
						array4[14] = 156;
						array4[14] = 40;
						num26 = 6 + 62;
						array4[15] = (byte)num26;
						num26 = 143 - 47;
						array4[15] = (byte)num26;
						num26 = 205 - 68;
						array4[15] = (byte)num26;
						num26 = 35 + 100;
						array4[15] = (byte)num26;
						num26 = 42 + 96;
						array4[16] = (byte)num26;
						array4[16] = 88;
						array4[16] = 195;
						num26 = 186 - 62;
						array4[16] = (byte)num26;
						num26 = 129 - 43;
						array4[16] = (byte)num26;
						num26 = 95 - 59;
						array4[16] = (byte)num26;
						num26 = 252 - 84;
						array4[17] = (byte)num26;
						num26 = 74 + 106;
						array4[17] = (byte)num26;
						array4[17] = 40;
						num26 = 83 + 49;
						array4[18] = (byte)num26;
						array4[18] = 136;
						array4[18] = 111;
						array4[18] = 86;
						num26 = 170 - 56;
						array4[18] = (byte)num26;
						array4[18] = 206;
						num26 = 7 + 37;
						array4[19] = (byte)num26;
						num26 = 36 + 79;
						array4[19] = (byte)num26;
						num26 = 118 + 10;
						array4[19] = (byte)num26;
						num26 = 173 - 57;
						array4[19] = (byte)num26;
						array4[19] = 35;
						num26 = 69 + 93;
						array4[20] = (byte)num26;
						num26 = 174 - 58;
						array4[20] = (byte)num26;
						num26 = 22 + 103;
						array4[20] = (byte)num26;
						array4[20] = 136;
						array4[20] = 176;
						num26 = 195 - 65;
						array4[21] = (byte)num26;
						num26 = 95 + 107;
						array4[21] = (byte)num26;
						array4[21] = 166;
						array4[21] = 38;
						num26 = 152 - 39;
						array4[21] = (byte)num26;
						num26 = 119 + 116;
						array4[22] = (byte)num26;
						array4[22] = 148;
						num26 = 29 + 84;
						array4[22] = (byte)num26;
						num26 = 117 + 52;
						array4[22] = (byte)num26;
						array4[22] = 67;
						array4[23] = 191;
						array4[23] = 138;
						array4[23] = 154;
						array4[23] = 29;
						num26 = 204 - 68;
						array4[24] = (byte)num26;
						num26 = 162 - 54;
						array4[24] = (byte)num26;
						array4[24] = 120;
						array4[24] = 155;
						array4[25] = 118;
						num26 = 86 + 72;
						array4[25] = (byte)num26;
						array4[25] = 158;
						array4[25] = 150;
						num26 = 217 - 72;
						array4[25] = (byte)num26;
						array4[25] = 199;
						array4[26] = 164;
						num26 = 238 - 79;
						array4[26] = (byte)num26;
						num26 = 197 - 65;
						array4[26] = (byte)num26;
						num26 = 171 - 57;
						array4[26] = (byte)num26;
						array4[26] = 197;
						num26 = 78 + 8;
						array4[27] = (byte)num26;
						array4[27] = 109;
						num26 = 182 - 60;
						array4[27] = (byte)num26;
						num26 = 170 - 56;
						array4[27] = (byte)num26;
						num26 = 48 + 2;
						array4[27] = (byte)num26;
						array4[27] = 200;
						num26 = 7 + 115;
						array4[28] = (byte)num26;
						num26 = 204 - 68;
						array4[28] = (byte)num26;
						num26 = 124 + 20;
						array4[28] = (byte)num26;
						num26 = 105 - 8;
						array4[28] = (byte)num26;
						num26 = 222 - 74;
						array4[29] = (byte)num26;
						array4[29] = 114;
						num26 = 159 - 53;
						array4[29] = (byte)num26;
						array4[29] = 99;
						array4[29] = 48;
						array4[29] = 130;
						array4[30] = 127;
						array4[30] = 144;
						array4[30] = 149;
						num26 = 163 - 54;
						array4[30] = (byte)num26;
						num26 = 155 - 51;
						array4[30] = (byte)num26;
						num26 = 120 + 62;
						array4[30] = (byte)num26;
						array4[31] = 135;
						num26 = 72 + 38;
						array4[31] = (byte)num26;
						array4[31] = 155;
						byte[] array5 = array4;
						byte[] array6 = new byte[16];
						array6[0] = 88;
						array6[0] = 219;
						array6[0] = 28;
						int num27 = 210 - 70;
						array6[0] = (byte)num27;
						array6[0] = 146;
						num27 = 241 - 80;
						array6[1] = (byte)num27;
						num27 = 226 - 75;
						array6[1] = (byte)num27;
						array6[1] = 100;
						array6[1] = 157;
						array6[1] = 57;
						array6[2] = 134;
						array6[2] = 142;
						array6[2] = 152;
						array6[2] = 84;
						num27 = 142 - 35;
						array6[2] = (byte)num27;
						array6[3] = 98;
						num27 = 162 - 54;
						array6[3] = (byte)num27;
						array6[3] = 136;
						array6[3] = 209;
						array6[3] = 181;
						num27 = 98 + 83;
						array6[4] = (byte)num27;
						array6[4] = 48;
						num27 = 67 + 107;
						array6[4] = (byte)num27;
						array6[5] = 217;
						num27 = 18 + 34;
						array6[5] = (byte)num27;
						num27 = 163 + 8;
						array6[5] = (byte)num27;
						num27 = 132 - 44;
						array6[6] = (byte)num27;
						num27 = 102 + 25;
						array6[6] = (byte)num27;
						num27 = 115 - 107;
						array6[6] = (byte)num27;
						num27 = 135 - 45;
						array6[7] = (byte)num27;
						array6[7] = 144;
						num27 = 126 - 42;
						array6[7] = (byte)num27;
						array6[7] = 190;
						array6[8] = 68;
						array6[8] = 99;
						num27 = 230 - 76;
						array6[8] = (byte)num27;
						array6[8] = 1;
						num27 = 142 - 47;
						array6[9] = (byte)num27;
						array6[9] = 93;
						array6[9] = 122;
						num27 = 150 - 50;
						array6[9] = (byte)num27;
						array6[9] = 84;
						array6[9] = 249;
						num27 = 175 - 58;
						array6[10] = (byte)num27;
						num27 = 134 - 44;
						array6[10] = (byte)num27;
						array6[10] = 98;
						array6[10] = 155;
						array6[10] = 235;
						num27 = 89 + 57;
						array6[11] = (byte)num27;
						num27 = 59 + 121;
						array6[11] = (byte)num27;
						num27 = 21 + 39;
						array6[11] = (byte)num27;
						array6[11] = 100;
						num27 = 54 + 113;
						array6[11] = (byte)num27;
						num27 = 145 + 1;
						array6[11] = (byte)num27;
						num27 = 152 - 50;
						array6[12] = (byte)num27;
						array6[12] = 36;
						num27 = 177 + 6;
						array6[12] = (byte)num27;
						num27 = 152 - 50;
						array6[13] = (byte)num27;
						array6[13] = 166;
						array6[13] = 123;
						num27 = 142 - 47;
						array6[14] = (byte)num27;
						num27 = 130 - 43;
						array6[14] = (byte)num27;
						array6[14] = 64;
						array6[14] = 93;
						array6[14] = 102;
						num27 = 125 - 58;
						array6[14] = (byte)num27;
						num27 = 191 - 63;
						array6[15] = (byte)num27;
						num27 = 148 - 49;
						array6[15] = (byte)num27;
						array6[15] = 123;
						byte[] array7 = array6;
						object obj4 = sE2kg1XdHZBeT280Lsux();
						LADpWvXdfQ3mP4tOZVq0(obj4, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)vapucRXd9u4B0uUUbqTh(obj4, array5, array7);
						Stream stream = (Stream)qkwqgpXdnsAurwcFHZLd();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						tKZJYdXdGC7KfNfMZXrE(cryptoStream, array3, 0, array3.Length);
						uXpBRkXdYa2KEsCEhPOc(cryptoStream);
						vFq5ndXdaFJGkGNH32ug(pv5XSbuGb41, hL9aG9XdB09KJWEhXwSF(fEaGC8XdotUhIbASTWUq(), VtilxyXdvdmspgrp7oR4(stream)));
						os5a1RXdi2eoFZxQERBu(stream);
						os5a1RXdi2eoFZxQERBu(cryptoStream);
						I79xeeXdlW8iAurZGsmk(yjMTdEXx2JCASdVCVphO);
						int num28 = 0;
						if (roRxFeXQmkN2Ix8r8fOc())
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
						if (AEpLBbXQhtWW8594uvUX() != null)
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
								if (roRxFeXQmkN2Ix8r8fOc())
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
					goto case 14;
				case 7:
					num2 = 3;
					continue;
				case 4:
					binaryReader = null;
					num2 = 0;
					if (roRxFeXQmkN2Ix8r8fOc())
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (pv5XSbuGb41 != null)
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 9:
					throw new Exception((string)A2GJdPXdQBh2TcVMpJkj(RaHhQrXdEp2MlIiXeaIT(Jn2qTqXdjQ0U7aQFyhAu(v7kyLNXQ8LttLY2MHBNN(typeof(RMpEErX55SDH1mxasQVF).TypeHandle).Assembly)), " is tampered."));
				case 19:
					flag = false;
					num2 = 8;
					continue;
				case 8:
					return;
				case 13:
					if (!flag)
					{
						num2 = 19;
						if (!roRxFeXQmkN2Ix8r8fOc())
						{
							num2 = 10;
						}
						continue;
					}
					goto case 9;
				case 17:
					return;
				case 15:
					flag = false;
					num2 = 1;
					if (AEpLBbXQhtWW8594uvUX() == null)
					{
						num2 = 2;
					}
					continue;
				default:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num7 = 16;
						if (roRxFeXQmkN2Ix8r8fOc())
						{
							num7 = 25;
						}
						while (true)
						{
							int num13;
							switch (num7)
							{
							case 20:
								e3S9RSXdeqPrskqWSQ2I(array2);
								num13 = 22;
								goto IL_18cd;
							case 4:
							case 7:
								if (num19 >= num11)
								{
									num7 = 24;
									if (AEpLBbXQhtWW8594uvUX() == null)
									{
										num7 = 43;
									}
									continue;
								}
								goto case 5;
							case 27:
								fiQ2eiXQzSNfFgBorgee(fileStream, 360L);
								num7 = 2;
								if (AEpLBbXQhtWW8594uvUX() == null)
								{
									num7 = 26;
								}
								continue;
							case 9:
								fiQ2eiXQzSNfFgBorgee(fileStream, num12);
								num7 = 31;
								continue;
							case 40:
								num14 = bSepqlXd1EuPSyMDH9tl(binaryReader);
								num7 = 17;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 3;
								}
								continue;
							case 5:
								fiQ2eiXQzSNfFgBorgee(fileStream, num10 + num19 * 40 + 16);
								num13 = 40;
								goto IL_18cd;
							case 37:
								array2 = (byte[])fs2bcOXdLouVClGIv8nD(binaryReader, (int)num18);
								num13 = 20;
								goto IL_18cd;
							case 17:
								num24 = bSepqlXd1EuPSyMDH9tl(binaryReader);
								num7 = 3;
								if (AEpLBbXQhtWW8594uvUX() == null)
								{
									num7 = 42;
								}
								continue;
							case 43:
								MTqIy5XdxKHjJ2NYfMi2(hashAlgorithm, new byte[0], 0, 0);
								num7 = 14;
								continue;
							case 26:
							case 39:
								num23 = oYTTVgXd5wcEYDTlVgOG(bSepqlXd1EuPSyMDH9tl(binaryReader), num11, num10, binaryReader);
								num7 = 33;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 18;
								}
								continue;
							case 30:
								num15 = (uint)(num16 - num21);
								num7 = 8;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 0;
								}
								continue;
							default:
							{
								uint num22 = bSepqlXd1EuPSyMDH9tl(binaryReader);
								num18 = bSepqlXd1EuPSyMDH9tl(binaryReader);
								num17 = oYTTVgXd5wcEYDTlVgOG(num22, num11, num10, binaryReader);
								num7 = 15;
								continue;
							}
							case 28:
								dfKqPOXd4Id1gkb91ks8(hashAlgorithm, fileStream, num20, array);
								num7 = 29;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 16;
								}
								continue;
							case 35:
								fiQ2eiXQzSNfFgBorgee(fileStream, odebXaXdkGu1T702FTE5(fileStream) + num15);
								num7 = 34;
								continue;
							case 3:
							case 23:
								num19++;
								num7 = 7;
								continue;
							case 38:
								num20 = (uint)RrbpGdXdSDsvm6ceeoIi(num17 - num21, num14);
								num13 = 28;
								goto IL_18cd;
							case 15:
								num16 = num17 + num18;
								num7 = 9;
								if (AEpLBbXQhtWW8594uvUX() != null)
								{
									num7 = 3;
								}
								continue;
							case 1:
								num14 -= num15;
								num7 = 30;
								if (AEpLBbXQhtWW8594uvUX() == null)
								{
									num7 = 35;
								}
								continue;
							case 13:
								array = new byte[65536];
								num7 = 32;
								continue;
							case 25:
								binaryReader = new BinaryReader(fileStream);
								num7 = 13;
								if (AEpLBbXQhtWW8594uvUX() != null)
								{
									num7 = 6;
								}
								continue;
							case 33:
								fiQ2eiXQzSNfFgBorgee(fileStream, num23 + 32);
								num7 = 0;
								if (AEpLBbXQhtWW8594uvUX() != null)
								{
									num7 = 0;
								}
								continue;
							case 19:
							case 24:
								fiQ2eiXQzSNfFgBorgee(fileStream, 376L);
								num7 = 39;
								continue;
							case 42:
								fiQ2eiXQzSNfFgBorgee(fileStream, num24);
								num7 = 36;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 33;
								}
								continue;
							case 32:
								dfKqPOXd4Id1gkb91ks8(hashAlgorithm, fileStream, 152u, array);
								num7 = 1;
								if (AEpLBbXQhtWW8594uvUX() == null)
								{
									num7 = 2;
								}
								continue;
							case 16:
								dfKqPOXd4Id1gkb91ks8(hashAlgorithm, fileStream, num14, array);
								num7 = 3;
								continue;
							case 6:
								if (num21 < num16)
								{
									num7 = 30;
									if (AEpLBbXQhtWW8594uvUX() != null)
									{
										num7 = 20;
									}
									continue;
								}
								goto case 10;
							case 8:
								if (num15 < num14)
								{
									num7 = 1;
									if (roRxFeXQmkN2Ix8r8fOc())
									{
										num7 = 1;
									}
									continue;
								}
								goto case 3;
							case 11:
								if (num17 > num21)
								{
									num7 = 10;
									if (!roRxFeXQmkN2Ix8r8fOc())
									{
										num7 = 0;
									}
									continue;
								}
								goto case 6;
							case 18:
							case 44:
								num21 = odebXaXdkGu1T702FTE5(fileStream);
								num7 = 4;
								if (roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 11;
								}
								continue;
							case 29:
								num14 -= num20;
								num7 = 12;
								continue;
							case 22:
								flag = !wMOxtBXdXpM0hIfLfSPy(pv5XSbuGb41, XXacIHXdsdsTtJomA1Pw(hashAlgorithm), text2, array2);
								num7 = 21;
								continue;
							case 14:
								fiQ2eiXQzSNfFgBorgee(fileStream, num17);
								num7 = 37;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num7 = 20;
								}
								continue;
							case 12:
							case 34:
							case 36:
								if (num14 != 0)
								{
									num7 = 18;
									if (!roRxFeXQmkN2Ix8r8fOc())
									{
										num7 = 8;
									}
									continue;
								}
								goto case 3;
							case 31:
								num19 = 0;
								num13 = 4;
								goto IL_18cd;
							case 10:
							case 41:
								if (num21 >= num16)
								{
									num7 = 16;
									if (!roRxFeXQmkN2Ix8r8fOc())
									{
										num7 = 0;
									}
									continue;
								}
								goto case 38;
							case 2:
							{
								bool num8 = L3eFCtXdDO1wBPyhGFba(binaryReader) != 523;
								int num9 = (num8 ? 96 : 112);
								fiQ2eiXQzSNfFgBorgee(fileStream, 152L);
								FcCMYpXdbxGKutM2BwUR(fileStream, array, 0, num9);
								array[64] = 0;
								array[65] = 0;
								array[66] = 0;
								array[67] = 0;
								PHCIdrXdNjuPW9sBTKyh(hashAlgorithm, array, 0, num9);
								FcCMYpXdbxGKutM2BwUR(fileStream, array, 0, 128);
								array[32] = 0;
								array[33] = 0;
								array[34] = 0;
								array[35] = 0;
								array[36] = 0;
								array[37] = 0;
								array[38] = 0;
								array[39] = 0;
								PHCIdrXdNjuPW9sBTKyh(hashAlgorithm, array, 0, 128);
								num10 = odebXaXdkGu1T702FTE5(fileStream);
								fiQ2eiXQzSNfFgBorgee(fileStream, 134L);
								num11 = L3eFCtXdDO1wBPyhGFba(binaryReader);
								fiQ2eiXQzSNfFgBorgee(fileStream, num10);
								dfKqPOXd4Id1gkb91ks8(hashAlgorithm, fileStream, (uint)(num11 * 40), array);
								num12 = odebXaXdkGu1T702FTE5(fileStream);
								if (!num8)
								{
									num13 = 19;
									goto IL_18cd;
								}
								goto case 27;
							}
							case 21:
								break;
								IL_18cd:
								num7 = num13;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num25 = 0;
						if (roRxFeXQmkN2Ix8r8fOc())
						{
							num25 = 1;
						}
						while (true)
						{
							switch (num25)
							{
							case 1:
								flag = true;
								num25 = 0;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num25 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 7;
				case 18:
					text = (string)V1JtccXQA0LyKRh9jwoA(v7kyLNXQ8LttLY2MHBNN(typeof(RMpEErX55SDH1mxasQVF).TypeHandle).Assembly);
					num2 = 1;
					if (roRxFeXQmkN2Ix8r8fOc())
					{
						num2 = 5;
					}
					continue;
				case 1:
					try
					{
						hashAlgorithm = (HashAlgorithm)h83axhXQJndBI2cT31Rj();
						int num5 = 3;
						if (!roRxFeXQmkN2Ix8r8fOc())
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 2:
								return;
							case 3:
								text2 = (string)zH1hK0XQFvUYh11Pp4hd("SHA1");
								num5 = 0;
								if (!roRxFeXQmkN2Ix8r8fOc())
								{
									num5 = 0;
								}
								continue;
							default:
								if (!rWtDSOXQ3Gm1oTv2ErON(text))
								{
									num5 = 1;
									if (AEpLBbXQhtWW8594uvUX() == null)
									{
										num5 = 2;
									}
									continue;
								}
								break;
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num6 = 0;
						if (!roRxFeXQmkN2Ix8r8fOc())
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 15;
				case 3:
					try
					{
						if (binaryReader != null)
						{
							int num3 = 0;
							if (roRxFeXQmkN2Ix8r8fOc())
							{
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								default:
									P0ZfOiXdcg8IsvaNtGak(binaryReader);
									num3 = 1;
									if (!roRxFeXQmkN2Ix8r8fOc())
									{
										num3 = 0;
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
						int num4 = 0;
						if (!roRxFeXQmkN2Ix8r8fOc())
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 13;
				case 20:
					text2 = null;
					num2 = 1;
					if (AEpLBbXQhtWW8594uvUX() != null)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (text == null)
					{
						return;
					}
					num2 = 21;
					continue;
				}
				break;
			}
			iypoK9XQ7mEThhZ6TikX(true);
			num = 12;
		}
	}

	public static void ATcX5qBWemn(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (eimXSNw4wk0 == null)
			{
				lock (QCKXSk2GU9a)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554448)).Assembly.GetManifestResourceStream("HBm37xX54mMiineum4Bd.I1dguWX5D2PNdAXS2iUI"));
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
							num3 += pQLX5te61Mx(num3);
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
						YjMTdEXx2JCASdVCVphO yjMTdEXx2JCASdVCVphO = new YjMTdEXx2JCASdVCVphO(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = yjMTdEXx2JCASdVCVphO.Q7ZXx95LeXG();
							int value = yjMTdEXx2JCASdVCVphO.Q7ZXx95LeXG();
							dictionary.Add(key, value);
						}
						yjMTdEXx2JCASdVCVphO.KDpXxnPfGsD();
					}
					eimXSNw4wk0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = eimXSNw4wk0[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554448)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777239));
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

	private static uint dIAX5WRoSHt(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint pQLX5te61Mx(uint P_0)
	{
		return 0u;
	}

	internal static void nOBX5UsCZk3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Yb5X5Ti2Iu9(Stream P_0, int P_1)
	{
		YOcxOJXxZBTmdgwBarvZ.CNJXxmqh4MK(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string pbtX5yHUPdJ(int P_0)
	{
		if (agcXSLSVqCd.Length == 0)
		{
			HW2XSSKaJmV = new List<string>();
			WXWXSxTpNDa = new List<int>();
			Yb5X5Ti2Iu9(TNmXSiuahlF.GetManifestResourceStream("ZQYkEQX59NdNfXUcskB0.SgntrTX5nYx7F7kBUHCX"), P_0);
		}
		if (YXvXS1LOH4O < 75)
		{
			if (TNmXSiuahlF != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			YXvXS1LOH4O++;
		}
		lock (U1HXS5mNhTq)
		{
			int num = BitConverter.ToInt32(agcXSLSVqCd, P_0);
			if (num < WXWXSxTpNDa.Count && WXWXSxTpNDa[num] == P_0)
			{
				return HW2XSSKaJmV[num];
			}
			try
			{
				Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
				byte[] array = new byte[num];
				Array.Copy(agcXSLSVqCd, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				HW2XSSKaJmV.Add(text);
				WXWXSxTpNDa.Add(P_0);
				Array.Copy(BitConverter.GetBytes(HW2XSSKaJmV.Count - 1), 0, agcXSLSVqCd, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string DjbX5ZjdjkZ(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int oFOX5VXVaw8()
	{
		return 5;
	}

	private static void wDvX5C3Xmei()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate jgfX5rPZ5WF(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777321)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777278)),
			Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777247))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object efMX5KvERSU(object P_0)
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
	public static extern IntPtr KaiX5m2hkWo(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr xL9X5ho70Uy(IntPtr P_0, string P_1);

	private static IntPtr NWPX5w0YVkm(IntPtr P_0, string P_1, uint P_2)
	{
		if (brvXSZxVqIa == null)
		{
			brvXSZxVqIa = (vC0QqBXxYSbK6KppnlPM)Marshal.GetDelegateForFunctionPointer(xL9X5ho70Uy(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554457)));
		}
		return brvXSZxVqIa(P_0, P_1, P_2);
	}

	private static IntPtr QVOX57GtvRM(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (znGXSVuSv0e == null)
		{
			znGXSVuSv0e = (o8qtKDXxoyj6l88A6m1h)Marshal.GetDelegateForFunctionPointer(xL9X5ho70Uy(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554458)));
		}
		return znGXSVuSv0e(P_0, P_1, P_2, P_3);
	}

	private static int lyLX58qHrnb(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (H9rXSCarmad == null)
		{
			H9rXSCarmad = (LPvkOyXxvjvwONnjc0sL)Marshal.GetDelegateForFunctionPointer(xL9X5ho70Uy(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554459)));
		}
		return H9rXSCarmad(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int ILqX5AOnYMG(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (F9gXSrJexRR == null)
		{
			F9gXSrJexRR = (At2np9XxBQJnrsLxk9l9)Marshal.GetDelegateForFunctionPointer(xL9X5ho70Uy(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554460)));
		}
		return F9gXSrJexRR(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr oGpX5PZp4e1(uint P_0, int P_1, uint P_2)
	{
		if (GMPXSKQx8lo == null)
		{
			GMPXSKQx8lo = (vSm715Xxa96Yh7afkWSK)Marshal.GetDelegateForFunctionPointer(xL9X5ho70Uy(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554461)));
		}
		return GMPXSKQx8lo(P_0, P_1, P_2);
	}

	private static int s0sX5JnaceE(IntPtr P_0)
	{
		if (TGpXSmONxjo == null)
		{
			TGpXSmONxjo = (D8o0LgXxiTu9GLxOQqAo)Marshal.GetDelegateForFunctionPointer(xL9X5ho70Uy(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554462)));
		}
		return TGpXSmONxjo(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (mjSXShnXy8Y == IntPtr.Zero)
		{
			mjSXShnXy8Y = KaiX5m2hkWo("kernel ".Trim() + "32.dll");
		}
		return mjSXShnXy8Y;
	}

	private static byte[] dNNX5FdJHY4(string P_0)
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

	internal static Stream ijKX53tUpw8()
	{
		return new MemoryStream();
	}

	internal static byte[] BW9X5p6kiKP(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] uG8X5ucCbNW(byte[] P_0)
	{
		Stream stream = ijKX53tUpw8();
		SymmetricAlgorithm symmetricAlgorithm = AFUX5QCjkpf();
		symmetricAlgorithm.Key = new byte[32]
		{
			16, 114, 77, 226, 95, 86, 115, 64, 63, 37,
			23, 232, 73, 52, 239, 85, 62, 109, 62, 166,
			31, 96, 162, 13, 92, 196, 154, 98, 100, 54,
			230, 226
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			147, 155, 170, 192, 104, 221, 250, 9, 136, 214,
			16, 54, 160, 219, 247, 111
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = BW9X5p6kiKP(stream);
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
		return result;
	}

	private unsafe static int EMgX5zwqswx(string P_0)
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

	internal static bool CkfXS0feyoF(string P_0, string P_1)
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
		if (P_0.StartsWith(fEcXSwIUkqa))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(fEcXSwIUkqa))
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
			num = EMgX5zwqswx(P_0);
		}
		if (!flag2)
		{
			num2 = EMgX5zwqswx(P_1);
		}
		return num == num2;
	}

	private byte[] oJJXS2ycsVh()
	{
		return null;
	}

	private byte[] QuiXSH7i0rU()
	{
		return null;
	}

	private byte[] ktlXSfGdE1G()
	{
		return null;
	}

	private byte[] ITWXS96yoIH()
	{
		return null;
	}

	private byte[] osEXSnvwr7K()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] JE1XSGFv2nC()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] sCOXSYqSSu7()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] RjwXSoeLuJJ()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] nNbXSvlYdQv()
	{
		return null;
	}

	internal byte[] IsAXSBo0CRb()
	{
		return null;
	}

	internal static object qJ5srjXQd7Zp3H9xDosc(object P_0)
	{
		return ((YjMTdEXx2JCASdVCVphO)P_0).m9OIO8Q0EK();
	}

	internal static void GM6w2nXQgv4rX7gmuKHj(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long c6JfyjXQR2YHYqDEmKJP(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object BLTjSdXQ69siCsENbePK(object P_0, int P_1)
	{
		return ((YjMTdEXx2JCASdVCVphO)P_0).VUMXxHeTqDm(P_1);
	}

	internal static void eQeBu7XQMBZ5RjaJpiHE(object P_0)
	{
		((YjMTdEXx2JCASdVCVphO)P_0).KDpXxnPfGsD();
	}

	internal static void iwMwJgXQOZVMSvpA6ova(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object sDqZZrXQq3aDSCNAYLIy(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object P8wKSTXQIEI1AZIWOGZ0(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object orkMj3XQW5bbPM9YXmmZ()
	{
		return AFUX5QCjkpf();
	}

	internal static void Suew7uXQt8Bdpa9KQPi0(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object os1vmiXQUqaveV5gNUHs(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object zSs9bEXQTeHRLTiGyeuj()
	{
		return ijKX53tUpw8();
	}

	internal static void bDDf10XQy0Ys0N4JTSaK(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void Kon0YhXQZgbwvpX0RWVY(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object I5QMGeXQVkFMH2PGp6Q4(object P_0)
	{
		return BW9X5p6kiKP((Stream)P_0);
	}

	internal static void GfMCOhXQCt6OBJKN3sxy(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object hNtlciXQrt73ZojLrQxt(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool mfl4mmXQKKDHdSXdrF1k(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool OnJjwRXQEuctR8VspWwZ()
	{
		return (object)null == null;
	}

	internal static object YxGNNhXQQLq924XKMDkM()
	{
		return null;
	}

	internal static void CHqM5FXQwtwWNYQs5Res()
	{
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
	}

	internal static void iypoK9XQ7mEThhZ6TikX(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type v7kyLNXQ8LttLY2MHBNN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object V1JtccXQA0LyKRh9jwoA(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int xNLZJ9XQPXGg3BBwaFpU(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object h83axhXQJndBI2cT31Rj()
	{
		return SHA1.Create();
	}

	internal static object zH1hK0XQFvUYh11Pp4hd(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool rWtDSOXQ3Gm1oTv2ErON(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object HcOk8eXQpblvf3iyaDBp(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object QxeUZAXQu9mrIK0hol1L(object P_0)
	{
		return ((YjMTdEXx2JCASdVCVphO)P_0).m9OIO8Q0EK();
	}

	internal static void fiQ2eiXQzSNfFgBorgee(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long DfnjREXd08cgCWi4VrHv(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object O7BcuiXd2CeOeaAu0EKe(object P_0, int P_1)
	{
		return ((YjMTdEXx2JCASdVCVphO)P_0).VUMXxHeTqDm(P_1);
	}

	internal static object sE2kg1XdHZBeT280Lsux()
	{
		return AFUX5QCjkpf();
	}

	internal static void LADpWvXdfQ3mP4tOZVq0(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object vapucRXd9u4B0uUUbqTh(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object qkwqgpXdnsAurwcFHZLd()
	{
		return ijKX53tUpw8();
	}

	internal static void tKZJYdXdGC7KfNfMZXrE(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void uXpBRkXdYa2KEsCEhPOc(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object fEaGC8XdotUhIbASTWUq()
	{
		return Encoding.UTF8;
	}

	internal static object VtilxyXdvdmspgrp7oR4(object P_0)
	{
		return BW9X5p6kiKP((Stream)P_0);
	}

	internal static object hL9aG9XdB09KJWEhXwSF(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void vFq5ndXdaFJGkGNH32ug(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void os5a1RXdi2eoFZxQERBu(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void I79xeeXdlW8iAurZGsmk(object P_0)
	{
		((YjMTdEXx2JCASdVCVphO)P_0).KDpXxnPfGsD();
	}

	internal static void dfKqPOXd4Id1gkb91ks8(object P_0, object P_1, uint P_2, object P_3)
	{
		s62X5R4ZppK((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort L3eFCtXdDO1wBPyhGFba(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int FcCMYpXdbxGKutM2BwUR(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void PHCIdrXdNjuPW9sBTKyh(object P_0, object P_1, int P_2, int P_3)
	{
		RUkX56yDJOn((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long odebXaXdkGu1T702FTE5(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint bSepqlXd1EuPSyMDH9tl(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint oYTTVgXd5wcEYDTlVgOG(uint P_0, int P_1, long P_2, object P_3)
	{
		return X3VX5M68vJg(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long RrbpGdXdSDsvm6ceeoIi(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object MTqIy5XdxKHjJ2NYfMi2(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object fs2bcOXdLouVClGIv8nD(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void e3S9RSXdeqPrskqWSQ2I(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object XXacIHXdsdsTtJomA1Pw(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool wMOxtBXdXpM0hIfLfSPy(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void P0ZfOiXdcg8IsvaNtGak(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object Jn2qTqXdjQ0U7aQFyhAu(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object RaHhQrXdEp2MlIiXeaIT(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object A2GJdPXdQBh2TcVMpJkj(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool roRxFeXQmkN2Ix8r8fOc()
	{
		return (object)null == null;
	}

	internal static object AEpLBbXQhtWW8594uvUX()
	{
		return null;
	}
}
