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
using K1GcsD5GTtMSlaiJI0Xh;
using RRGeI95GVMJEHGH0bnkl;
using s2UiSE5YBL9itf1iCcbq;
using x97CE55GhEYKgt7TSVZT;

namespace BfZtb759KlUg4482QKym;

internal class F71m3059rTj4gyFcUtWX
{
	private delegate void tlERWN5GN0wuscxOf7jr(object o);

	internal class kqV0Ys5GkOyTCad5HR0d : Attribute
	{
		internal class UVTllT5G1wiYm9dHkoIw<KDsFcZ5G5elI50yN044n>
		{
			private static object SKECShLOnHavOZLmwHOo;

			public UVTllT5G1wiYm9dHkoIw()
			{
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				base._002Ector();
			}

			static UVTllT5G1wiYm9dHkoIw()
			{
				xiX5n2gNr23();
				pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool SOZiL9LOG9Mp01bHqwyV()
			{
				return SKECShLOnHavOZLmwHOo == null;
			}

			internal static object WSeUeULOYBJneajOptP0()
			{
				return SKECShLOnHavOZLmwHOo;
			}
		}

		public kqV0Ys5GkOyTCad5HR0d(object P_0)
		{
		}

		static kqV0Ys5GkOyTCad5HR0d()
		{
			muaZuDLO9EZbfaEMFRmq();
		}

		internal static void muaZuDLO9EZbfaEMFRmq()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class zgdnH35GSsMsSJPDjvQs
	{
		internal static string sH25GxqysfG(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = dU659p2QlfE((byte[])GFTCVGLOaS4eN3jT34CB(Encoding.Unicode, P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = kaW59Flnq2H();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)FxODHhLOiFAPhvl6p8Qm(symmetricAlgorithm), CryptoStreamMode.Write);
			g6AyK5LOlVedjWNMfRmX(cryptoStream, bytes, 0, bytes.Length);
			cryptoStream.Close();
			return (string)zO9vEWLO4mq5IRAi4vp4(memoryStream.ToArray());
		}

		static zgdnH35GSsMsSJPDjvQs()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object GFTCVGLOaS4eN3jT34CB(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static object FxODHhLOiFAPhvl6p8Qm(object P_0)
		{
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		internal static void g6AyK5LOlVedjWNMfRmX(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static object zO9vEWLO4mq5IRAi4vp4(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint s75e7t5GLBnCfvWMeYpr(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr EbDYX25GenKKHN9b5yvE();

	internal struct tA9EeJ5Gs65iNNN8XmqH
	{
		internal bool LKv5GX5KjPc;

		internal byte[] TqB5Gcn4irm;
	}

	internal class dGLTKW5Gj2RRv85HF7Gu
	{
		private BinaryReader UDQ5GRBx92o;

		public dGLTKW5Gj2RRv85HF7Gu(Stream P_0)
		{
			UDQ5GRBx92o = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return (Stream)SJkCfcLOSLKpRivJLADE(UDQ5GRBx92o);
		}

		internal byte[] M4C5GEj2CRn(int P_0)
		{
			return UDQ5GRBx92o.ReadBytes(P_0);
		}

		internal int Q0R5GQlrcES(byte[] P_0, int P_1, int P_2)
		{
			return ENqbsPLOxG4E0QCGtBVm(UDQ5GRBx92o, P_0, P_1, P_2);
		}

		internal int D5N5GdZtrdY()
		{
			return UDQ5GRBx92o.ReadInt32();
		}

		internal void XKg5GgPTcKY()
		{
			UDQ5GRBx92o.Close();
		}

		static dGLTKW5Gj2RRv85HF7Gu()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object SJkCfcLOSLKpRivJLADE(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static int ENqbsPLOxG4E0QCGtBVm(object P_0, object P_1, int P_2, int P_3)
		{
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr AoeLtj5G6oJs1gIubOQt(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr VPt4XY5GMQNW13SUjmY4(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int JQKZSi5GOUDLux8IW02O(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int FxEkeo5GqkOWM2Os50ub(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr S0ttlR5GIcMk3G4p0mCy(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int pEfOKP5GWlhbgqwkwTCv(IntPtr ptr);

	[Flags]
	private enum nvk2rN5GtC3BveHdJN5u
	{

	}

	private static bool GOo5nIFdG95;

	private static bool HJj5nUVPchA;

	private static Dictionary<int, int> EZU5nZKqPNI;

	private static object Xpv5nr66PNe;

	private static int iBn5nJepeIE;

	private static long cvL5G2tK45A;

	private static pEfOKP5GWlhbgqwkwTCv thD5G4vEPPG;

	private static long l4I5nuJSIeC;

	private static uint[] Nhq5nthqh4t;

	private static int JHs5GHR4Zjx;

	private static bool qO85nFkQVNP;

	private static List<string> MV15nKYFS3K;

	private static int[] oXV5nPhtg15;

	private static IntPtr K5y5GD55mIM;

	private static IntPtr U0t5n89tAvg;

	private static bool Gcx5Gf23j3F;

	private static bool LGX5G9iubbB;

	private static VPt4XY5GMQNW13SUjmY4 gQn5GBref0V;

	private static IntPtr MMx5GGGuuxl;

	private static object e5W5nVaQJ2k;

	internal static Hashtable GNU5Go0ZQKT;

	internal static RSACryptoServiceProvider Uu95nyalaIS;

	private static AoeLtj5G6oJs1gIubOQt VlN5GvYBPVL;

	private static SortedList KcU5n3UDE6i;

	private static int Hwi5np1MXPh;

	private static int pqd5nCDxp6v;

	private static List<int> aEj5nmZW265;

	private static byte[] hHf5nwC9GFv;

	internal static s75e7t5GLBnCfvWMeYpr mSB5nz5uc97;

	internal static Assembly ID35nWpUaQq;

	private static S0ttlR5GIcMk3G4p0mCy t435GlqFw5Z;

	private static IntPtr xUL5n7khM2Q;

	private static int ROC5GnsXU7C;

	private static object hmF5nAqpdBJ;

	private static byte[] SRF5nh9XxGM;

	[kqV0Ys5GkOyTCad5HR0d(typeof(kqV0Ys5GkOyTCad5HR0d.UVTllT5G1wiYm9dHkoIw<object>[]))]
	private static bool fkT5GYogPBB;

	private static string Kau5GbRwfKl;

	private static FxEkeo5GqkOWM2Os50ub UBZ5GiBCYYq;

	internal static s75e7t5GLBnCfvWMeYpr Soj5G0OnxTM;

	private static bool riE5nTGmkcO;

	private static JQKZSi5GOUDLux8IW02O OwR5Gaxhqn5;

	static F71m3059rTj4gyFcUtWX()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		GOo5nIFdG95 = false;
		ID35nWpUaQq = Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556043)).Assembly;
		Nhq5nthqh4t = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		HJj5nUVPchA = false;
		riE5nTGmkcO = false;
		Uu95nyalaIS = null;
		EZU5nZKqPNI = null;
		e5W5nVaQJ2k = new object();
		pqd5nCDxp6v = 0;
		Xpv5nr66PNe = new object();
		MV15nKYFS3K = null;
		aEj5nmZW265 = null;
		SRF5nh9XxGM = new byte[0];
		hHf5nwC9GFv = new byte[0];
		xUL5n7khM2Q = IntPtr.Zero;
		U0t5n89tAvg = IntPtr.Zero;
		hmF5nAqpdBJ = new string[0];
		oXV5nPhtg15 = new int[0];
		iBn5nJepeIE = 1;
		qO85nFkQVNP = false;
		KcU5n3UDE6i = new SortedList();
		Hwi5np1MXPh = 0;
		l4I5nuJSIeC = 0L;
		mSB5nz5uc97 = null;
		Soj5G0OnxTM = null;
		cvL5G2tK45A = 0L;
		JHs5GHR4Zjx = 0;
		Gcx5Gf23j3F = false;
		LGX5G9iubbB = false;
		ROC5GnsXU7C = 0;
		MMx5GGGuuxl = IntPtr.Zero;
		fkT5GYogPBB = false;
		GNU5Go0ZQKT = new Hashtable();
		VlN5GvYBPVL = null;
		gQn5GBref0V = null;
		OwR5Gaxhqn5 = null;
		UBZ5GiBCYYq = null;
		t435GlqFw5Z = null;
		thD5G4vEPPG = null;
		K5y5GD55mIM = IntPtr.Zero;
		Kau5GbRwfKl = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void D45LyN3ts30()
	{
	}

	internal static byte[] y1l59matWvt(byte[] P_0)
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
			qIh59hi8WxY(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			qIh59hi8WxY(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			qIh59hi8WxY(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			qIh59hi8WxY(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			qIh59hi8WxY(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			qIh59hi8WxY(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			qIh59hi8WxY(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			qIh59hi8WxY(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			qIh59hi8WxY(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			qIh59hi8WxY(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			qIh59hi8WxY(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			qIh59hi8WxY(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			qIh59hi8WxY(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			qIh59hi8WxY(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			qIh59hi8WxY(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			qIh59hi8WxY(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			jsP59wu9UrQ(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			jsP59wu9UrQ(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			jsP59wu9UrQ(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			jsP59wu9UrQ(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			jsP59wu9UrQ(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			jsP59wu9UrQ(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			jsP59wu9UrQ(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			jsP59wu9UrQ(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			jsP59wu9UrQ(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			jsP59wu9UrQ(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			jsP59wu9UrQ(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			jsP59wu9UrQ(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			jsP59wu9UrQ(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			jsP59wu9UrQ(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			jsP59wu9UrQ(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			jsP59wu9UrQ(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			j2q5971bihv(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			j2q5971bihv(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			j2q5971bihv(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			j2q5971bihv(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			j2q5971bihv(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			j2q5971bihv(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			j2q5971bihv(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			j2q5971bihv(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			j2q5971bihv(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			j2q5971bihv(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			j2q5971bihv(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			j2q5971bihv(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			j2q5971bihv(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			j2q5971bihv(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			j2q5971bihv(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			j2q5971bihv(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			Equ5981top0(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			Equ5981top0(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			Equ5981top0(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			Equ5981top0(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			Equ5981top0(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			Equ5981top0(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			Equ5981top0(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			Equ5981top0(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			Equ5981top0(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			Equ5981top0(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			Equ5981top0(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			Equ5981top0(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			Equ5981top0(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			Equ5981top0(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			Equ5981top0(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			Equ5981top0(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void qIh59hi8WxY(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Yfw59A2T2WD(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + Nhq5nthqh4t[P_6 - 1], P_5);
	}

	private static void jsP59wu9UrQ(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Yfw59A2T2WD(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + Nhq5nthqh4t[P_6 - 1], P_5);
	}

	private static void j2q5971bihv(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Yfw59A2T2WD(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + Nhq5nthqh4t[P_6 - 1], P_5);
	}

	private static void Equ5981top0(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Yfw59A2T2WD(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + Nhq5nthqh4t[P_6 - 1], P_5);
	}

	private static uint Yfw59A2T2WD(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool R6Q59P51WPd()
	{
		if (!HJj5nUVPchA)
		{
			TVs593atYbg();
			HJj5nUVPchA = true;
		}
		return riE5nTGmkcO;
	}

	internal F71m3059rTj4gyFcUtWX()
	{
	}

	private void Lrm59J70J8P(byte[] P_0, byte[] P_1, byte[] P_2)
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
		SRF5nh9XxGM = array;
	}

	internal static SymmetricAlgorithm kaW59Flnq2H()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (R6Q59P51WPd())
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

	internal static void TVs593atYbg()
	{
		try
		{
			riE5nTGmkcO = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] dU659p2QlfE(byte[] P_0)
	{
		if (!R6Q59P51WPd())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return y1l59matWvt(P_0);
	}

	internal static void Y6y59ukNYbX(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			TOw59zk4uHS(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void TOw59zk4uHS(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint oXL5n0XbNkZ(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void xiX5n2gNr23()
	{
		int num = 18;
		bool flag = default(bool);
		string text = default(string);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		uint num15 = default(uint);
		byte[] array6 = default(byte[]);
		int num22 = default(int);
		int num12 = default(int);
		string text2 = default(string);
		byte[] array7 = default(byte[]);
		long num24 = default(long);
		uint num17 = default(uint);
		long num11 = default(long);
		long num19 = default(long);
		uint num21 = default(uint);
		uint num18 = default(uint);
		long num20 = default(long);
		long num13 = default(long);
		uint num14 = default(uint);
		BinaryReader binaryReader = default(BinaryReader);
		uint num23 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					flag = false;
					num2 = 7;
					if (jMKeiG51wwyiuBEjoo8x() != null)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (qvdUUe51JtbmZfZnkkOC(text) != 0)
					{
						num2 = 3;
						continue;
					}
					return;
				case 14:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num8 = 7;
						if (jMKeiG51wwyiuBEjoo8x() == null)
						{
							num8 = 39;
						}
						while (true)
						{
							switch (num8)
							{
							case 30:
								QsNLeZ55LgGkYsoFBiwJ(hashAlgorithm, new byte[0], 0, 0);
								num8 = 42;
								continue;
							case 32:
							{
								NGKAlj55DrBqvYTfrm4e(hashAlgorithm, fileStream, num15, array6);
								int num16 = 29;
								num8 = num16;
								continue;
							}
							case 6:
							case 19:
								if (num22 < num12)
								{
									num8 = 4;
									continue;
								}
								goto case 30;
							case 27:
								flag = !tjr8tP55cE7cBZY3MkTZ(Uu95nyalaIS, cU5DdZ55XoS67iWH00xk(hashAlgorithm), text2, array7);
								num8 = 36;
								continue;
							case 42:
								MRt35Q550O2bOyBBDER9(fileStream, num24);
								num8 = 19;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 43;
								}
								continue;
							case 7:
							case 8:
								num22++;
								num8 = 16;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 19;
								}
								continue;
							case 31:
								MRt35Q550O2bOyBBDER9(fileStream, 360L);
								num8 = 41;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num8 = 13;
								}
								continue;
							case 23:
								NGKAlj55DrBqvYTfrm4e(hashAlgorithm, fileStream, num17, array6);
								num8 = 3;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 7;
								}
								continue;
							case 28:
								array6 = new byte[65536];
								num8 = 29;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 40;
								}
								continue;
							default:
								cVteX155sObPYXcj79oW(array7);
								num8 = 4;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 27;
								}
								continue;
							case 4:
							case 33:
								MRt35Q550O2bOyBBDER9(fileStream, num11 + num22 * 40 + 16);
								num8 = 24;
								if (JxDkN051hxfhNiYoF1JW())
								{
									num8 = 38;
								}
								continue;
							case 25:
								num19 = num24 + num21;
								num8 = 1;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 26;
								}
								continue;
							case 5:
								num17 -= num18;
								num8 = 22;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num8 = 12;
								}
								continue;
							case 37:
								num22 = 0;
								num8 = 6;
								if (jMKeiG51wwyiuBEjoo8x() != null)
								{
									num8 = 6;
								}
								continue;
							case 20:
								num20 = MZcTi25512v5gF1OgUuZ(fileStream);
								num8 = 1;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num8 = 0;
								}
								continue;
							case 26:
								MRt35Q550O2bOyBBDER9(fileStream, num13);
								num8 = 37;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num8 = 12;
								}
								continue;
							case 10:
								num14 = hYimmr555fcH6x2Dds1r(binaryReader);
								num8 = 11;
								continue;
							case 1:
								if (num24 > num20)
								{
									num8 = 14;
									continue;
								}
								goto case 35;
							case 9:
							case 15:
							case 21:
								if (num17 == 0)
								{
									num8 = 8;
									continue;
								}
								goto case 20;
							case 16:
							case 41:
								num23 = wREUca55So4EpquD8MvS(hYimmr555fcH6x2Dds1r(binaryReader), num12, num11, binaryReader);
								num8 = 3;
								if (jMKeiG51wwyiuBEjoo8x() != null)
								{
									num8 = 0;
								}
								continue;
							case 12:
							{
								uint num25 = hYimmr555fcH6x2Dds1r(binaryReader);
								num21 = hYimmr555fcH6x2Dds1r(binaryReader);
								num24 = wREUca55So4EpquD8MvS(num25, num12, num11, binaryReader);
								num8 = 25;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num8 = 23;
								}
								continue;
							}
							case 39:
								binaryReader = new BinaryReader(fileStream);
								num8 = 28;
								continue;
							case 40:
								NGKAlj55DrBqvYTfrm4e(hashAlgorithm, fileStream, 152u, array6);
								num8 = 0;
								if (JxDkN051hxfhNiYoF1JW())
								{
									num8 = 13;
								}
								continue;
							case 18:
								if (num18 < num17)
								{
									num8 = 5;
									if (!JxDkN051hxfhNiYoF1JW())
									{
										num8 = 3;
									}
									continue;
								}
								goto case 7;
							case 35:
								if (num20 < num19)
								{
									num8 = 17;
									continue;
								}
								goto case 2;
							case 22:
								MRt35Q550O2bOyBBDER9(fileStream, MZcTi25512v5gF1OgUuZ(fileStream) + num18);
								num8 = 21;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num8 = 0;
								}
								continue;
							case 3:
								MRt35Q550O2bOyBBDER9(fileStream, num23 + 32);
								num8 = 12;
								continue;
							case 43:
								array7 = (byte[])DWOPk755esPVLPd42slT(binaryReader, (int)num21);
								num8 = 0;
								if (jMKeiG51wwyiuBEjoo8x() != null)
								{
									num8 = 0;
								}
								continue;
							case 24:
								num15 = (uint)BWACbY55xLpX4eos5Uvn(num24 - num20, num17);
								num8 = 32;
								if (jMKeiG51wwyiuBEjoo8x() != null)
								{
									num8 = 29;
								}
								continue;
							case 29:
								num17 -= num15;
								num8 = 9;
								continue;
							case 34:
								MRt35Q550O2bOyBBDER9(fileStream, 376L);
								num8 = 5;
								if (jMKeiG51wwyiuBEjoo8x() == null)
								{
									num8 = 16;
								}
								continue;
							case 38:
								num17 = hYimmr555fcH6x2Dds1r(binaryReader);
								num8 = 10;
								if (jMKeiG51wwyiuBEjoo8x() != null)
								{
									num8 = 8;
								}
								continue;
							case 11:
								MRt35Q550O2bOyBBDER9(fileStream, num14);
								num8 = 15;
								continue;
							case 2:
							case 14:
								if (num20 >= num19)
								{
									num8 = 23;
									continue;
								}
								goto case 24;
							case 17:
								num18 = (uint)(num19 - num20);
								num8 = 18;
								continue;
							case 13:
							{
								bool num9 = rhu6lQ55biAK6d61p6xI(binaryReader) != 523;
								int num10 = (num9 ? 96 : 112);
								MRt35Q550O2bOyBBDER9(fileStream, 152L);
								AyVpKS55NdA2fid0jE5R(fileStream, array6, 0, num10);
								array6[64] = 0;
								array6[65] = 0;
								array6[66] = 0;
								array6[67] = 0;
								tfrtKd55k3q2RZUF6nes(hashAlgorithm, array6, 0, num10);
								AyVpKS55NdA2fid0jE5R(fileStream, array6, 0, 128);
								array6[32] = 0;
								array6[33] = 0;
								array6[34] = 0;
								array6[35] = 0;
								array6[36] = 0;
								array6[37] = 0;
								array6[38] = 0;
								array6[39] = 0;
								tfrtKd55k3q2RZUF6nes(hashAlgorithm, array6, 0, 128);
								num11 = MZcTi25512v5gF1OgUuZ(fileStream);
								MRt35Q550O2bOyBBDER9(fileStream, 134L);
								num12 = rhu6lQ55biAK6d61p6xI(binaryReader);
								MRt35Q550O2bOyBBDER9(fileStream, num11);
								NGKAlj55DrBqvYTfrm4e(hashAlgorithm, fileStream, (uint)(num12 * 40), array6);
								num13 = MZcTi25512v5gF1OgUuZ(fileStream);
								if (num9)
								{
									num8 = 31;
									continue;
								}
								goto case 34;
							}
							case 36:
								break;
							}
							break;
						}
					}
					catch
					{
						int num26 = 0;
						if (jMKeiG51wwyiuBEjoo8x() != null)
						{
							num26 = 0;
						}
						while (true)
						{
							switch (num26)
							{
							default:
								flag = true;
								num26 = 1;
								if (jMKeiG51wwyiuBEjoo8x() != null)
								{
									num26 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 15;
				case 18:
					if (Uu95nyalaIS != null)
					{
						num2 = 17;
						continue;
					}
					goto case 10;
				case 5:
				case 21:
					if (!flag)
					{
						num2 = 12;
						continue;
					}
					goto default;
				case 16:
					try
					{
						int num29;
						if (binaryReader == null)
						{
							num29 = 1;
							if (jMKeiG51wwyiuBEjoo8x() == null)
							{
								num29 = 2;
							}
							goto IL_081a;
						}
						goto IL_0830;
						IL_081a:
						switch (num29)
						{
						case 2:
							goto end_IL_07f5;
						case 1:
							goto end_IL_07f5;
						}
						goto IL_0830;
						IL_0830:
						XaSKhx55js9nKfDEQGU5(binaryReader);
						num29 = 1;
						if (jMKeiG51wwyiuBEjoo8x() == null)
						{
							num29 = 1;
						}
						goto IL_081a;
						end_IL_07f5:;
					}
					catch
					{
						int num30 = 0;
						if (!JxDkN051hxfhNiYoF1JW())
						{
							num30 = 0;
						}
						switch (num30)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 17:
					return;
				default:
					throw new Exception((string)Ux5uNP55dgE9ylnueERD(aiJKoo55Q7XRdwHG3SKd(lMmlHM55EOsaYZ6ejUSV(DlBwbt51AibedjfnR2dD(typeof(F71m3059rTj4gyFcUtWX).TypeHandle).Assembly)), " is tampered."));
				case 12:
					flag = false;
					num2 = 11;
					continue;
				case 6:
					try
					{
						hashAlgorithm = (HashAlgorithm)LSDZb851Fk6QoULXTPyx();
						int num27 = 2;
						if (jMKeiG51wwyiuBEjoo8x() != null)
						{
							num27 = 1;
						}
						while (true)
						{
							switch (num27)
							{
							case 1:
								if (!aQKQJa51pKRjjepHXa7w(text))
								{
									num27 = 1;
									if (jMKeiG51wwyiuBEjoo8x() == null)
									{
										num27 = 3;
									}
									continue;
								}
								break;
							case 2:
								text2 = (string)wYSuOs513gLIdd5byglB("SHA1");
								num27 = 1;
								if (!JxDkN051hxfhNiYoF1JW())
								{
									num27 = 1;
								}
								continue;
							case 3:
								return;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num28 = 0;
						if (jMKeiG51wwyiuBEjoo8x() == null)
						{
							num28 = 0;
						}
						switch (num28)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 4;
				case 13:
					text = (string)WW5xwg51PuKbmOG9wVr7(DlBwbt51AibedjfnR2dD(typeof(F71m3059rTj4gyFcUtWX).TypeHandle).Assembly);
					num2 = 1;
					if (!JxDkN051hxfhNiYoF1JW())
					{
						num2 = 1;
					}
					continue;
				case 23:
					Uu95nyalaIS = new RSACryptoServiceProvider();
					num = 13;
					break;
				case 22:
					text2 = null;
					num2 = 6;
					continue;
				case 10:
					dgVOow51782405NZjMpZ();
					num2 = 19;
					if (jMKeiG51wwyiuBEjoo8x() != null)
					{
						num2 = 19;
					}
					continue;
				case 11:
					return;
				case 20:
					if (flag)
					{
						num2 = 21;
						if (jMKeiG51wwyiuBEjoo8x() != null)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 2;
				case 1:
					if (text != null)
					{
						num2 = 9;
						if (!JxDkN051hxfhNiYoF1JW())
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 2:
					binaryReader = null;
					num2 = 14;
					continue;
				case 7:
					try
					{
						dGLTKW5Gj2RRv85HF7Gu dGLTKW5Gj2RRv85HF7Gu = new dGLTKW5Gj2RRv85HF7Gu((Stream)MgyhOM51uynwJL9b21Rq(ID35nWpUaQq, "j6OsCVkWSZBRC0B7IeUR.6b3PT4kWxUdOyGr2R33G"));
						MRt35Q550O2bOyBBDER9(hVLkis51zEJWMYwILYeu(dGLTKW5Gj2RRv85HF7Gu), 0L);
						byte[] array = (byte[])VEPGjW55HUDUKSOBGdfN(dGLTKW5Gj2RRv85HF7Gu, (int)KQ3vBA552s0pYXBhPqKr(hVLkis51zEJWMYwILYeu(dGLTKW5Gj2RRv85HF7Gu)));
						byte[] array2 = new byte[32];
						array2[0] = 89;
						int num3 = 152 - 50;
						array2[0] = (byte)num3;
						array2[0] = 146;
						num3 = 1 + 99;
						array2[0] = (byte)num3;
						array2[0] = 249;
						num3 = 19 + 72;
						array2[1] = (byte)num3;
						array2[1] = 55;
						array2[1] = 62;
						num3 = 26 + 102;
						array2[2] = (byte)num3;
						num3 = 113 + 28;
						array2[2] = (byte)num3;
						num3 = 120 + 53;
						array2[2] = (byte)num3;
						num3 = 181 - 103;
						array2[2] = (byte)num3;
						array2[3] = 121;
						array2[3] = 140;
						array2[3] = 133;
						num3 = 13 + 112;
						array2[3] = (byte)num3;
						num3 = 52 + 88;
						array2[4] = (byte)num3;
						num3 = 151 - 50;
						array2[4] = (byte)num3;
						array2[4] = 128;
						num3 = 121 + 73;
						array2[5] = (byte)num3;
						num3 = 144 - 48;
						array2[5] = (byte)num3;
						num3 = 131 - 43;
						array2[5] = (byte)num3;
						num3 = 43 + 77;
						array2[5] = (byte)num3;
						array2[5] = 143;
						num3 = 51 + 104;
						array2[5] = (byte)num3;
						num3 = 117 + 25;
						array2[6] = (byte)num3;
						num3 = 127 - 42;
						array2[6] = (byte)num3;
						num3 = 135 - 45;
						array2[6] = (byte)num3;
						num3 = 110 - 75;
						array2[6] = (byte)num3;
						num3 = 250 - 83;
						array2[7] = (byte)num3;
						num3 = 120 + 8;
						array2[7] = (byte)num3;
						array2[7] = 39;
						array2[7] = 204;
						num3 = 5 + 0;
						array2[8] = (byte)num3;
						num3 = 53 + 98;
						array2[8] = (byte)num3;
						num3 = 228 - 108;
						array2[8] = (byte)num3;
						num3 = 214 - 71;
						array2[9] = (byte)num3;
						array2[9] = 90;
						num3 = 13 + 27;
						array2[9] = (byte)num3;
						array2[9] = 50;
						array2[9] = 159;
						array2[10] = 196;
						num3 = 62 + 66;
						array2[10] = (byte)num3;
						array2[10] = 146;
						num3 = 102 + 39;
						array2[10] = (byte)num3;
						array2[10] = 137;
						array2[10] = 110;
						array2[11] = 142;
						array2[11] = 104;
						array2[11] = 67;
						num3 = 0 + 88;
						array2[12] = (byte)num3;
						num3 = 75 + 44;
						array2[12] = (byte)num3;
						num3 = 142 - 73;
						array2[12] = (byte)num3;
						array2[13] = 195;
						num3 = 6 + 56;
						array2[13] = (byte)num3;
						array2[13] = 123;
						array2[13] = 88;
						array2[13] = 94;
						array2[13] = 11;
						array2[14] = 127;
						array2[14] = 116;
						array2[14] = 150;
						num3 = 66 - 27;
						array2[14] = (byte)num3;
						num3 = 254 - 84;
						array2[15] = (byte)num3;
						num3 = 11 + 7;
						array2[15] = (byte)num3;
						array2[15] = 88;
						array2[15] = 35;
						num3 = 112 + 103;
						array2[16] = (byte)num3;
						num3 = 68 + 89;
						array2[16] = (byte)num3;
						array2[16] = 138;
						num3 = 124 - 53;
						array2[16] = (byte)num3;
						num3 = 167 - 55;
						array2[17] = (byte)num3;
						array2[17] = 164;
						num3 = 156 + 10;
						array2[17] = (byte)num3;
						array2[18] = 72;
						array2[18] = 135;
						num3 = 185 + 41;
						array2[18] = (byte)num3;
						num3 = 139 - 46;
						array2[19] = (byte)num3;
						array2[19] = 71;
						array2[19] = 219;
						num3 = 89 + 62;
						array2[20] = (byte)num3;
						array2[20] = 144;
						array2[20] = 139;
						array2[20] = 130;
						num3 = 112 + 4;
						array2[20] = (byte)num3;
						num3 = 109 - 1;
						array2[20] = (byte)num3;
						num3 = 42 + 40;
						array2[21] = (byte)num3;
						num3 = 109 + 18;
						array2[21] = (byte)num3;
						array2[21] = 96;
						array2[21] = 85;
						num3 = 117 + 34;
						array2[21] = (byte)num3;
						array2[22] = 70;
						array2[22] = 158;
						num3 = 7 + 73;
						array2[22] = (byte)num3;
						num3 = 197 + 24;
						array2[22] = (byte)num3;
						num3 = 105 + 28;
						array2[23] = (byte)num3;
						num3 = 183 - 61;
						array2[23] = (byte)num3;
						array2[23] = 136;
						num3 = 73 + 113;
						array2[23] = (byte)num3;
						array2[23] = 34;
						num3 = 185 - 61;
						array2[24] = (byte)num3;
						array2[24] = 164;
						array2[24] = 191;
						num3 = 77 + 81;
						array2[25] = (byte)num3;
						num3 = 92 + 103;
						array2[25] = (byte)num3;
						array2[25] = 212;
						array2[26] = 144;
						array2[26] = 161;
						num3 = 34 + 57;
						array2[26] = (byte)num3;
						array2[26] = 136;
						num3 = 33 + 53;
						array2[27] = (byte)num3;
						array2[27] = 93;
						num3 = 209 - 69;
						array2[27] = (byte)num3;
						array2[27] = 114;
						array2[27] = 152;
						array2[28] = 100;
						num3 = 125 - 41;
						array2[28] = (byte)num3;
						array2[28] = 253;
						array2[29] = 231;
						num3 = 37 + 29;
						array2[29] = (byte)num3;
						array2[29] = 87;
						array2[29] = 86;
						array2[29] = 112;
						num3 = 63 - 62;
						array2[29] = (byte)num3;
						array2[30] = 114;
						num3 = 73 + 3;
						array2[30] = (byte)num3;
						num3 = 190 - 63;
						array2[30] = (byte)num3;
						num3 = 157 + 62;
						array2[30] = (byte)num3;
						num3 = 229 - 76;
						array2[31] = (byte)num3;
						array2[31] = 161;
						array2[31] = 67;
						num3 = 83 + 32;
						array2[31] = (byte)num3;
						array2[31] = 147;
						byte[] array3 = array2;
						byte[] array4 = new byte[16]
						{
							150, 0, 0, 0, 0, 0, 0, 0, 0, 0,
							0, 0, 0, 0, 0, 0
						};
						int num4 = 49 + 22;
						array4[0] = (byte)num4;
						array4[0] = 40;
						array4[1] = 118;
						array4[1] = 122;
						num4 = 97 + 121;
						array4[1] = (byte)num4;
						num4 = 73 - 28;
						array4[1] = (byte)num4;
						int num5 = 87 + 101;
						array4[2] = (byte)num5;
						array4[2] = 227;
						array4[2] = 53;
						array4[3] = 166;
						array4[3] = 149;
						num5 = 118 + 16;
						array4[3] = (byte)num5;
						num5 = 40 + 53;
						array4[4] = (byte)num5;
						array4[4] = 167;
						num5 = 156 - 52;
						array4[4] = (byte)num5;
						array4[4] = 52;
						array4[4] = 207;
						array4[5] = 96;
						num5 = 242 - 80;
						array4[5] = (byte)num5;
						array4[5] = 83;
						num5 = 156 - 52;
						array4[6] = (byte)num5;
						num5 = 56 + 23;
						array4[6] = (byte)num5;
						array4[6] = 108;
						array4[6] = 2;
						num4 = 29 + 83;
						array4[7] = (byte)num4;
						array4[7] = 136;
						num4 = 54 + 97;
						array4[7] = (byte)num4;
						array4[7] = 168;
						num4 = 152 - 50;
						array4[8] = (byte)num4;
						num4 = 110 + 36;
						array4[8] = (byte)num4;
						array4[8] = 192;
						num5 = 177 - 59;
						array4[8] = (byte)num5;
						array4[8] = 90;
						num5 = 11 + 122;
						array4[8] = (byte)num5;
						num4 = 83 + 94;
						array4[9] = (byte)num4;
						array4[9] = 169;
						num4 = 115 - 30;
						array4[9] = (byte)num4;
						array4[10] = 94;
						array4[10] = 217;
						array4[10] = 128;
						num5 = 27 + 40;
						array4[10] = (byte)num5;
						num4 = 116 + 86;
						array4[10] = (byte)num4;
						array4[11] = 90;
						num5 = 158 - 52;
						array4[11] = (byte)num5;
						array4[11] = 119;
						num5 = 6 + 53;
						array4[11] = (byte)num5;
						num5 = 155 + 22;
						array4[11] = (byte)num5;
						num5 = 89 + 119;
						array4[12] = (byte)num5;
						num4 = 170 - 56;
						array4[12] = (byte)num4;
						num4 = 86 - 81;
						array4[12] = (byte)num4;
						array4[13] = 101;
						array4[13] = 102;
						num5 = 223 - 74;
						array4[13] = (byte)num5;
						array4[13] = 100;
						array4[14] = 216;
						num4 = 81 + 80;
						array4[14] = (byte)num4;
						array4[14] = 24;
						num4 = 188 - 62;
						array4[15] = (byte)num4;
						array4[15] = 158;
						num5 = 88 + 9;
						array4[15] = (byte)num5;
						num5 = 50 - 38;
						array4[15] = (byte)num5;
						byte[] array5 = array4;
						object obj = xYOhbC55fUY2EBGgBY2A();
						MPSNZR559OPBmGV6nHgv(obj, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)emg3X655nno7TlNDuBdC(obj, array3, array5);
						Stream stream = (Stream)QF6dkr55GopbMUBudrkb();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						cmOeaJ55Y3SIp5s44st5(cryptoStream, array, 0, array.Length);
						zNvWU855oo4KyAy6CxtX(cryptoStream);
						TedUNj55iAYLR69HhOfu(Uu95nyalaIS, j6NT5r55aDYIl8eUxEdU(sm5UmC55v8U6omSwMyFG(), E2nhjD55BCEQZ78Thbt9(stream)));
						DOlv4Q55lCXaRG9syysV(stream);
						DOlv4Q55lCXaRG9syysV(cryptoStream);
						fwstMN554wOJlbWo07eo(dGLTKW5Gj2RRv85HF7Gu);
						int num6 = 0;
						if (jMKeiG51wwyiuBEjoo8x() == null)
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
						int num7 = 0;
						if (JxDkN051hxfhNiYoF1JW())
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
								if (JxDkN051hxfhNiYoF1JW())
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
					goto case 20;
				case 15:
					num = 16;
					break;
				case 8:
					return;
				case 3:
					hashAlgorithm = null;
					num2 = 11;
					if (JxDkN051hxfhNiYoF1JW())
					{
						num2 = 22;
					}
					continue;
				case 19:
					aiGSc9518OGsE1fwLUZy(true);
					num2 = 10;
					if (jMKeiG51wwyiuBEjoo8x() == null)
					{
						num2 = 23;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void Udj5nHIYOCE(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (EZU5nZKqPNI == null)
			{
				lock (e5W5nVaQJ2k)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556043)).Assembly.GetManifestResourceStream("raU1YakWcjFFnOYVqu5L.fScYQdkWjqfCZD7lCFQI"));
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
							num3 += S6y5nnq14Ov(num3);
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
						dGLTKW5Gj2RRv85HF7Gu dGLTKW5Gj2RRv85HF7Gu = new dGLTKW5Gj2RRv85HF7Gu(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = dGLTKW5Gj2RRv85HF7Gu.D5N5GdZtrdY();
							int value = dGLTKW5Gj2RRv85HF7Gu.D5N5GdZtrdY();
							dictionary.Add(key, value);
						}
						dGLTKW5Gj2RRv85HF7Gu.XKg5GgPTcKY();
					}
					EZU5nZKqPNI = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = EZU5nZKqPNI[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556043)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777237));
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

	private static uint ntC5n9ng59E(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint S6y5nnq14Ov(uint P_0)
	{
		return 0u;
	}

	internal static void iyq5nGcIxhg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void nrN5nYC38BQ(Stream P_0, int P_1)
	{
		jR6Pnd5YvEbw7bdAD3oG.YQb5Y4jOfG9(3, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string JNO5no2YvQQ(int P_0)
	{
		if (SRF5nh9XxGM.Length == 0)
		{
			MV15nKYFS3K = new List<string>();
			aEj5nmZW265 = new List<int>();
			nrN5nYC38BQ(ID35nWpUaQq.GetManifestResourceStream("DQyu7QkWNEZPQ4ah37pt.quuGQrkWksgqWOoa6Pkt"), P_0);
		}
		if (pqd5nCDxp6v < 75)
		{
			if (ID35nWpUaQq != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			pqd5nCDxp6v++;
		}
		lock (Xpv5nr66PNe)
		{
			int num = BitConverter.ToInt32(SRF5nh9XxGM, P_0);
			if (num < aEj5nmZW265.Count && aEj5nmZW265[num] == P_0)
			{
				return MV15nKYFS3K[num];
			}
			try
			{
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				byte[] array = new byte[num];
				Array.Copy(SRF5nh9XxGM, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				MV15nKYFS3K.Add(text);
				aEj5nmZW265.Add(P_0);
				Array.Copy(BitConverter.GetBytes(MV15nKYFS3K.Count - 1), 0, SRF5nh9XxGM, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string N905nvPWRrh(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int AmM5nBG8EJW()
	{
		return 5;
	}

	private static void ddd5natiJrU()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate yQP5ni9q6GF(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777580)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777285)),
			Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777267))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object W9P5nlgUVh3(object P_0)
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
	public static extern IntPtr mh85n43slqJ(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr Jvx5nDbRfI2(IntPtr P_0, string P_1);

	private static IntPtr imQ5nbQPHGx(IntPtr P_0, string P_1, uint P_2)
	{
		if (VlN5GvYBPVL == null)
		{
			VlN5GvYBPVL = (AoeLtj5G6oJs1gIubOQt)Marshal.GetDelegateForFunctionPointer(Jvx5nDbRfI2(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556052)));
		}
		return VlN5GvYBPVL(P_0, P_1, P_2);
	}

	private static IntPtr yfV5nNhNtNr(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (gQn5GBref0V == null)
		{
			gQn5GBref0V = (VPt4XY5GMQNW13SUjmY4)Marshal.GetDelegateForFunctionPointer(Jvx5nDbRfI2(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556053)));
		}
		return gQn5GBref0V(P_0, P_1, P_2, P_3);
	}

	private static int xkN5nkFsrps(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (OwR5Gaxhqn5 == null)
		{
			OwR5Gaxhqn5 = (JQKZSi5GOUDLux8IW02O)Marshal.GetDelegateForFunctionPointer(Jvx5nDbRfI2(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556054)));
		}
		return OwR5Gaxhqn5(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int sj55n1emQvD(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (UBZ5GiBCYYq == null)
		{
			UBZ5GiBCYYq = (FxEkeo5GqkOWM2Os50ub)Marshal.GetDelegateForFunctionPointer(Jvx5nDbRfI2(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556055)));
		}
		return UBZ5GiBCYYq(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr ApG5n5F8k2Y(uint P_0, int P_1, uint P_2)
	{
		if (t435GlqFw5Z == null)
		{
			t435GlqFw5Z = (S0ttlR5GIcMk3G4p0mCy)Marshal.GetDelegateForFunctionPointer(Jvx5nDbRfI2(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556056)));
		}
		return t435GlqFw5Z(P_0, P_1, P_2);
	}

	private static int wU75nSH5JtP(IntPtr P_0)
	{
		if (thD5G4vEPPG == null)
		{
			thD5G4vEPPG = (pEfOKP5GWlhbgqwkwTCv)Marshal.GetDelegateForFunctionPointer(Jvx5nDbRfI2(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556057)));
		}
		return thD5G4vEPPG(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (K5y5GD55mIM == IntPtr.Zero)
		{
			K5y5GD55mIM = mh85n43slqJ("kernel ".Trim() + "32.dll");
		}
		return K5y5GD55mIM;
	}

	private static byte[] tXb5nxEPO1O(string P_0)
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

	internal static Stream VIy5nLE4NuQ()
	{
		return new MemoryStream();
	}

	internal static byte[] jAk5neYKyPm(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] NkG5nswMG88(byte[] P_0)
	{
		Stream stream = VIy5nLE4NuQ();
		SymmetricAlgorithm symmetricAlgorithm = kaW59Flnq2H();
		symmetricAlgorithm.Key = new byte[32]
		{
			21, 205, 247, 210, 185, 197, 137, 239, 127, 200,
			82, 21, 126, 33, 254, 166, 92, 193, 121, 183,
			104, 67, 251, 100, 174, 70, 136, 158, 17, 37,
			170, 150
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			168, 112, 162, 109, 26, 149, 93, 151, 233, 81,
			112, 21, 21, 217, 73, 103
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = jAk5neYKyPm(stream);
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		return result;
	}

	private unsafe static int X5t5nXBn2oB(string P_0)
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

	internal static bool kJy5nc3hHdP(string P_0, string P_1)
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
		if (P_0.StartsWith(Kau5GbRwfKl))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(Kau5GbRwfKl))
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
			num = X5t5nXBn2oB(P_0);
		}
		if (!flag2)
		{
			num2 = X5t5nXBn2oB(P_1);
		}
		return num == num2;
	}

	private byte[] z745nj8Ko7o()
	{
		return null;
	}

	private byte[] RMO5nEs755H()
	{
		return null;
	}

	private byte[] m2R5nQ4JnFo()
	{
		return null;
	}

	private byte[] nKS5ndX6dNi()
	{
		return null;
	}

	private byte[] CLx5ngnhkhO()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] gIZ5nRc06KP()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] vy25n60mcxI()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] fsX5nMq6B4Z()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] N7a5nOWWbKo()
	{
		return null;
	}

	internal byte[] Coe5nqtaVrS()
	{
		return null;
	}

	internal static object J4ZAB351gdC63YhlvLlQ(object P_0)
	{
		return ((dGLTKW5Gj2RRv85HF7Gu)P_0).m9OIO8Q0EK();
	}

	internal static void FGyqIw51RsDAUdwdMLZ6(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long RGjKaL516c1htEblC4dg(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object HK0Sbs51MZR2r4ivDmLE(object P_0, int P_1)
	{
		return ((dGLTKW5Gj2RRv85HF7Gu)P_0).M4C5GEj2CRn(P_1);
	}

	internal static void XTkfLP51OeiempbOYxwg(object P_0)
	{
		((dGLTKW5Gj2RRv85HF7Gu)P_0).XKg5GgPTcKY();
	}

	internal static void tYftiR51q7QE038lA7Tt(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object U47CvP51I8saGPBOacxB(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object SSaKAm51W7gwVU9aHXLq(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object o9pkaT51tBGnQRNtvsF2()
	{
		return kaW59Flnq2H();
	}

	internal static void H6LcfV51UTpHWaZTfoy0(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object tWSWUt51TfZj00v7cuVL(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object kWfGL951yR5iG4cFjXJC()
	{
		return VIy5nLE4NuQ();
	}

	internal static void Y3249i51Zp2PvbYiIBnE(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void qIuhSa51VQCpqp6Vj86c(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object IvwLiY51C7lGauhXX8fY(object P_0)
	{
		return jAk5neYKyPm((Stream)P_0);
	}

	internal static void su5yrM51rah7AbZqqFSk(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object qsgIZj51Kdv2Nhf8ISvl(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool AW7j7n51mD2VVbaCxRNg(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool mSKGT951Qwu3MNKQJH23()
	{
		return (object)null == null;
	}

	internal static object YTPZv551dDJD3p02q0bl()
	{
		return null;
	}

	internal static void dgVOow51782405NZjMpZ()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void aiGSc9518OGsE1fwLUZy(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type DlBwbt51AibedjfnR2dD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object WW5xwg51PuKbmOG9wVr7(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int qvdUUe51JtbmZfZnkkOC(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object LSDZb851Fk6QoULXTPyx()
	{
		return SHA1.Create();
	}

	internal static object wYSuOs513gLIdd5byglB(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool aQKQJa51pKRjjepHXa7w(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object MgyhOM51uynwJL9b21Rq(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object hVLkis51zEJWMYwILYeu(object P_0)
	{
		return ((dGLTKW5Gj2RRv85HF7Gu)P_0).m9OIO8Q0EK();
	}

	internal static void MRt35Q550O2bOyBBDER9(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long KQ3vBA552s0pYXBhPqKr(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object VEPGjW55HUDUKSOBGdfN(object P_0, int P_1)
	{
		return ((dGLTKW5Gj2RRv85HF7Gu)P_0).M4C5GEj2CRn(P_1);
	}

	internal static object xYOhbC55fUY2EBGgBY2A()
	{
		return kaW59Flnq2H();
	}

	internal static void MPSNZR559OPBmGV6nHgv(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object emg3X655nno7TlNDuBdC(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object QF6dkr55GopbMUBudrkb()
	{
		return VIy5nLE4NuQ();
	}

	internal static void cmOeaJ55Y3SIp5s44st5(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void zNvWU855oo4KyAy6CxtX(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object sm5UmC55v8U6omSwMyFG()
	{
		return Encoding.UTF8;
	}

	internal static object E2nhjD55BCEQZ78Thbt9(object P_0)
	{
		return jAk5neYKyPm((Stream)P_0);
	}

	internal static object j6NT5r55aDYIl8eUxEdU(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void TedUNj55iAYLR69HhOfu(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void DOlv4Q55lCXaRG9syysV(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void fwstMN554wOJlbWo07eo(object P_0)
	{
		((dGLTKW5Gj2RRv85HF7Gu)P_0).XKg5GgPTcKY();
	}

	internal static void NGKAlj55DrBqvYTfrm4e(object P_0, object P_1, uint P_2, object P_3)
	{
		Y6y59ukNYbX((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort rhu6lQ55biAK6d61p6xI(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int AyVpKS55NdA2fid0jE5R(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void tfrtKd55k3q2RZUF6nes(object P_0, object P_1, int P_2, int P_3)
	{
		TOw59zk4uHS((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long MZcTi25512v5gF1OgUuZ(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint hYimmr555fcH6x2Dds1r(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint wREUca55So4EpquD8MvS(uint P_0, int P_1, long P_2, object P_3)
	{
		return oXL5n0XbNkZ(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long BWACbY55xLpX4eos5Uvn(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object QsNLeZ55LgGkYsoFBiwJ(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object DWOPk755esPVLPd42slT(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void cVteX155sObPYXcj79oW(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object cU5DdZ55XoS67iWH00xk(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool tjr8tP55cE7cBZY3MkTZ(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void XaSKhx55js9nKfDEQGU5(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object lMmlHM55EOsaYZ6ejUSV(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object aiJKoo55Q7XRdwHG3SKd(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object Ux5uNP55dgE9ylnueERD(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool JxDkN051hxfhNiYoF1JW()
	{
		return (object)null == null;
	}

	internal static object jMKeiG51wwyiuBEjoo8x()
	{
		return null;
	}
}
