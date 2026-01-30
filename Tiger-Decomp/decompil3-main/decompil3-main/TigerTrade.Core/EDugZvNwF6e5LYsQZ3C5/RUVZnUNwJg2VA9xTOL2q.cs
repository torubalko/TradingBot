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
using gyWf8lN8Aps6C4Xje11n;
using H1tZMQNA1jJEJXtc2nDJ;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace EDugZvNwF6e5LYsQZ3C5;

internal class RUVZnUNwJg2VA9xTOL2q
{
	private delegate void yE05GZN8Xk6G6IPi5tT9(object o);

	internal class h1OlEmN8cYanp0MdTx22 : Attribute
	{
		internal class AgqbPpN8jxB4RKa9NJyr<Oo21JpN8ECmvU7y1SHjD>
		{
			private static object onNAYMkYttE38o8y1P1l;

			public AgqbPpN8jxB4RKa9NJyr()
			{
				PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
				base._002Ector();
			}

			static AgqbPpN8jxB4RKa9NJyr()
			{
				hFyN7BZEP4e();
				a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool aGqu1BkYU3G0w1CQhoAb()
			{
				return onNAYMkYttE38o8y1P1l == null;
			}

			internal static object kK9kpkkYTVcClcai0GHV()
			{
				return onNAYMkYttE38o8y1P1l;
			}
		}

		public h1OlEmN8cYanp0MdTx22(object P_0)
		{
		}

		static h1OlEmN8cYanp0MdTx22()
		{
			eNOkOMkYWAhRAuopi465();
		}

		internal static void eNOkOMkYWAhRAuopi465()
		{
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class GR2C0TN8QGyrP6xXZo3G
	{
		internal static string wIIN8dflnoe(string P_0, string P_1)
		{
			byte[] array = (byte[])Q2smB6kYCi7sFP9njJxV(Encoding.Unicode, P_0);
			byte[] array2 = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = TfTN7GG21Lk(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = tRGN79LhFMR();
			LYZctOkYrw1EFAc769rg(symmetricAlgorithm, array2);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			HsMEuWkYKuOopSiwae1v(cryptoStream, array, 0, array.Length);
			cryptoStream.Close();
			return (string)eY4vIUkYmWcMnpmQvPlG(memoryStream.ToArray());
		}

		static GR2C0TN8QGyrP6xXZo3G()
		{
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object Q2smB6kYCi7sFP9njJxV(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static void LYZctOkYrw1EFAc769rg(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		internal static void HsMEuWkYKuOopSiwae1v(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static object eY4vIUkYmWcMnpmQvPlG(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint xIRbYiN8gRJiatuMO0gG(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr MQDV5DN8R7RRrKiBUIwg();

	internal struct lxRBhlN86NErLiD0uuND
	{
		internal bool j4IN8MrHc4w;

		internal byte[] UkJN8OF3iuZ;
	}

	internal class hq9Gd9N8qvF64Paq8ke1
	{
		private BinaryReader kFKN8TfJytQ;

		public hq9Gd9N8qvF64Paq8ke1(Stream P_0)
		{
			kFKN8TfJytQ = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return (Stream)u3wqxLkYJA0RImJ27PvZ(kFKN8TfJytQ);
		}

		internal byte[] YCIN8INYlRd(int P_0)
		{
			return kFKN8TfJytQ.ReadBytes(P_0);
		}

		internal int N0vN8Wej3nw(byte[] P_0, int P_1, int P_2)
		{
			return kFKN8TfJytQ.Read(P_0, P_1, P_2);
		}

		internal int oa7N8t9d1PM()
		{
			return kFKN8TfJytQ.ReadInt32();
		}

		internal void SKvN8UtwYVT()
		{
			JCkoLOkYFBZ3Nw9KvQ9N(kFKN8TfJytQ);
		}

		static hq9Gd9N8qvF64Paq8ke1()
		{
			NuejpIkY3Y4PRCosr9c5();
		}

		internal static object u3wqxLkYJA0RImJ27PvZ(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static void JCkoLOkYFBZ3Nw9KvQ9N(object P_0)
		{
			((BinaryReader)P_0).Close();
		}

		internal static void NuejpIkY3Y4PRCosr9c5()
		{
			a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr QDk79JN8yDad39Hv486w(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr bLw4U0N8ZOvvBW32Rwpo(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int nC42HKN8VV3dAZ1P2Ted(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int NWCwTON8C2tYu4SxYr7b(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr quCBdRN8rZMGOhjrEJRY(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int l4FuTqN8K1WYgSxRoPI2(IntPtr ptr);

	[Flags]
	private enum U1lyA9N8mmL1BHft7ykW
	{

	}

	private static bool cJVN7r56mDw;

	private static int[] QlEN8HQxVMS;

	private static int QaiN8fx6hg6;

	private static int HEGN8GQVh9M;

	private static bool FY9N8ihLDy9;

	private static int K2yN84bpJDh;

	internal static xIRbYiN8gRJiatuMO0gG zGVN8oXanyj;

	private static int ytpN8aUutbO;

	internal static Assembly n8BN7KHHBUK;

	private static bool ufNN7wB5jHR;

	internal static RSACryptoServiceProvider t0jN77Lpvf8;

	private static bool wl8N892ysKI;

	private static NWCwTON8C2tYu4SxYr7b BvUN8SouYac;

	private static long DFeN8BaF7IS;

	private static string bPAN8sd2tjF;

	private static bLw4U0N8ZOvvBW32Rwpo q3lN81KG4p4;

	private static List<int> ei9N739NXdD;

	private static uint[] sH9N7mR6XBb;

	internal static Hashtable AO4N8NcoD7g;

	private static IntPtr HDiN8DPaPwV;

	private static IntPtr IUrN7zX1uLE;

	private static object uTGN82eRIJB;

	private static Dictionary<int, int> Uy2N78SNKld;

	internal static xIRbYiN8gRJiatuMO0gG ygPN8vgNfoq;

	private static l4FuTqN8K1WYgSxRoPI2 v1bN8LYMx9d;

	private static quCBdRN8rZMGOhjrEJRY YqFN8xbrBEs;

	private static object nF4N7JIdgFD;

	private static IntPtr X1LN80k6E3Q;

	private static nC42HKN8VV3dAZ1P2Ted ndGN85ANHj5;

	private static long WYiN8Y6dtco;

	private static bool KmmN7hvhNJs;

	private static List<string> d5BN7FFMNO6;

	private static byte[] U7FN7uTHRua;

	private static byte[] QCjN7pQbVbs;

	private static QDk79JN8yDad39Hv486w XbyN8koWvXI;

	private static SortedList eI4N8nSuHPh;

	private static int hMoN7PHMoyV;

	private static IntPtr aAoN8ecdD0G;

	private static object vt0N7AljdZM;

	[h1OlEmN8cYanp0MdTx22(typeof(h1OlEmN8cYanp0MdTx22.AgqbPpN8jxB4RKa9NJyr<object>[]))]
	private static bool sTLN8bsRuWS;

	private static bool gkCN8lsyu3s;

	static RUVZnUNwJg2VA9xTOL2q()
	{
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		cJVN7r56mDw = false;
		n8BN7KHHBUK = Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554508)).Assembly;
		sH9N7mR6XBb = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		KmmN7hvhNJs = false;
		ufNN7wB5jHR = false;
		t0jN77Lpvf8 = null;
		Uy2N78SNKld = null;
		vt0N7AljdZM = new object();
		hMoN7PHMoyV = 0;
		nF4N7JIdgFD = new object();
		d5BN7FFMNO6 = null;
		ei9N739NXdD = null;
		QCjN7pQbVbs = new byte[0];
		U7FN7uTHRua = new byte[0];
		IUrN7zX1uLE = IntPtr.Zero;
		X1LN80k6E3Q = IntPtr.Zero;
		uTGN82eRIJB = new string[0];
		QlEN8HQxVMS = new int[0];
		QaiN8fx6hg6 = 1;
		wl8N892ysKI = false;
		eI4N8nSuHPh = new SortedList();
		HEGN8GQVh9M = 0;
		WYiN8Y6dtco = 0L;
		zGVN8oXanyj = null;
		ygPN8vgNfoq = null;
		DFeN8BaF7IS = 0L;
		ytpN8aUutbO = 0;
		FY9N8ihLDy9 = false;
		gkCN8lsyu3s = false;
		K2yN84bpJDh = 0;
		HDiN8DPaPwV = IntPtr.Zero;
		sTLN8bsRuWS = false;
		AO4N8NcoD7g = new Hashtable();
		XbyN8koWvXI = null;
		q3lN81KG4p4 = null;
		ndGN85ANHj5 = null;
		BvUN8SouYac = null;
		YqFN8xbrBEs = null;
		v1bN8LYMx9d = null;
		aAoN8ecdD0G = IntPtr.Zero;
		bPAN8sd2tjF = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void IO3k4Fgu6la()
	{
	}

	internal static byte[] IgBNw3XfKgV(byte[] P_0)
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
			XfNNwpqFCHM(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			XfNNwpqFCHM(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			XfNNwpqFCHM(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			XfNNwpqFCHM(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			XfNNwpqFCHM(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			XfNNwpqFCHM(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			XfNNwpqFCHM(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			XfNNwpqFCHM(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			XfNNwpqFCHM(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			XfNNwpqFCHM(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			XfNNwpqFCHM(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			XfNNwpqFCHM(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			XfNNwpqFCHM(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			XfNNwpqFCHM(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			XfNNwpqFCHM(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			XfNNwpqFCHM(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			jjvNwunyVxi(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			jjvNwunyVxi(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			jjvNwunyVxi(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			jjvNwunyVxi(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			jjvNwunyVxi(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			jjvNwunyVxi(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			jjvNwunyVxi(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			jjvNwunyVxi(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			jjvNwunyVxi(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			jjvNwunyVxi(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			jjvNwunyVxi(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			jjvNwunyVxi(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			jjvNwunyVxi(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			jjvNwunyVxi(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			jjvNwunyVxi(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			jjvNwunyVxi(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			Y1lNwzQAYO8(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			Y1lNwzQAYO8(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			Y1lNwzQAYO8(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			Y1lNwzQAYO8(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			Y1lNwzQAYO8(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			Y1lNwzQAYO8(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			Y1lNwzQAYO8(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			Y1lNwzQAYO8(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			Y1lNwzQAYO8(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			Y1lNwzQAYO8(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			Y1lNwzQAYO8(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			Y1lNwzQAYO8(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			Y1lNwzQAYO8(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			Y1lNwzQAYO8(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			Y1lNwzQAYO8(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			Y1lNwzQAYO8(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			j67N70IJlEG(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			j67N70IJlEG(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			j67N70IJlEG(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			j67N70IJlEG(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			j67N70IJlEG(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			j67N70IJlEG(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			j67N70IJlEG(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			j67N70IJlEG(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			j67N70IJlEG(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			j67N70IJlEG(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			j67N70IJlEG(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			j67N70IJlEG(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			j67N70IJlEG(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			j67N70IJlEG(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			j67N70IJlEG(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			j67N70IJlEG(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void XfNNwpqFCHM(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XGpN72JM7SI(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + sH9N7mR6XBb[P_6 - 1], P_5);
	}

	private static void jjvNwunyVxi(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XGpN72JM7SI(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + sH9N7mR6XBb[P_6 - 1], P_5);
	}

	private static void Y1lNwzQAYO8(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XGpN72JM7SI(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + sH9N7mR6XBb[P_6 - 1], P_5);
	}

	private static void j67N70IJlEG(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + XGpN72JM7SI(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + sH9N7mR6XBb[P_6 - 1], P_5);
	}

	private static uint XGpN72JM7SI(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool n82N7Hn53Wv()
	{
		if (!KmmN7hvhNJs)
		{
			kh3N7nLcL4U();
			KmmN7hvhNJs = true;
		}
		return ufNN7wB5jHR;
	}

	internal RUVZnUNwJg2VA9xTOL2q()
	{
	}

	private void uimN7fkjbCi(byte[] P_0, byte[] P_1, byte[] P_2)
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
		QCjN7pQbVbs = array;
	}

	internal static SymmetricAlgorithm tRGN79LhFMR()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (n82N7Hn53Wv())
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

	internal static void kh3N7nLcL4U()
	{
		try
		{
			ufNN7wB5jHR = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] TfTN7GG21Lk(byte[] P_0)
	{
		if (!n82N7Hn53Wv())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return IgBNw3XfKgV(P_0);
	}

	internal static void wvnN7YL173H(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			IOHN7o1AZYk(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void IOHN7o1AZYk(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint aA4N7vvrsn2(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void hFyN7BZEP4e()
	{
		int num = 1;
		string text2 = default(string);
		bool flag = default(bool);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text = default(string);
		BinaryReader binaryReader = default(BinaryReader);
		uint num12 = default(uint);
		byte[] array2 = default(byte[]);
		uint num19 = default(uint);
		uint num14 = default(uint);
		uint num20 = default(uint);
		int num17 = default(int);
		uint num9 = default(uint);
		long num8 = default(long);
		byte[] array = default(byte[]);
		long num11 = default(long);
		long num10 = default(long);
		uint num15 = default(uint);
		int num7 = default(int);
		long num6 = default(long);
		long num13 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 10:
					text2 = null;
					num2 = 14;
					if (cxXcUvk0qJGBbjDxkNNT())
					{
						num2 = 14;
					}
					continue;
				case 16:
					try
					{
						hq9Gd9N8qvF64Paq8ke1 hq9Gd9N8qvF64Paq8ke = new hq9Gd9N8qvF64Paq8ke1((Stream)yLYmX3k0r57y8IwXcQ7N(n8BN7KHHBUK, "w81tPqNhA3P8WUQI8V56.sE3AHDNhPGqgkKVNrPZr"));
						QtnDK5k0m5gFaVvf00Gx(mAclAsk0KHWSMqDGAxMc(hq9Gd9N8qvF64Paq8ke), 0L);
						byte[] array3 = (byte[])qFmtIHk0wO2fsOq8oT4P(hq9Gd9N8qvF64Paq8ke, (int)MhtZcjk0hVxZgVtmHtoR(mAclAsk0KHWSMqDGAxMc(hq9Gd9N8qvF64Paq8ke)));
						byte[] array4 = new byte[32];
						int num22 = 247 - 82;
						array4[0] = (byte)num22;
						array4[0] = 15;
						num22 = 145 - 91;
						array4[0] = (byte)num22;
						num22 = 149 - 49;
						array4[1] = (byte)num22;
						num22 = 33 + 111;
						array4[1] = (byte)num22;
						array4[1] = 121;
						array4[2] = 11;
						array4[2] = 114;
						array4[2] = 162;
						int num23 = 193 - 119;
						array4[2] = (byte)num23;
						num23 = 23 + 119;
						array4[3] = (byte)num23;
						array4[3] = 120;
						num22 = 125 - 87;
						array4[3] = (byte)num22;
						num22 = 9 + 82;
						array4[4] = (byte)num22;
						array4[4] = 134;
						num22 = 253 - 84;
						array4[4] = (byte)num22;
						array4[4] = 227;
						array4[5] = 105;
						num23 = 39 + 82;
						array4[5] = (byte)num23;
						num22 = 159 + 8;
						array4[5] = (byte)num22;
						array4[6] = 124;
						array4[6] = 154;
						array4[6] = 181;
						array4[7] = 140;
						num22 = 131 - 43;
						array4[7] = (byte)num22;
						num23 = 12 + 122;
						array4[7] = (byte)num23;
						array4[7] = 135;
						array4[7] = 99;
						array4[7] = 57;
						array4[8] = 102;
						num22 = 175 - 58;
						array4[8] = (byte)num22;
						array4[8] = 21;
						array4[9] = 145;
						array4[9] = 41;
						num23 = 66 + 6;
						array4[9] = (byte)num23;
						array4[9] = 178;
						num23 = 6 + 86;
						array4[10] = (byte)num23;
						num23 = 206 - 68;
						array4[10] = (byte)num23;
						array4[10] = 218;
						num23 = 23 + 108;
						array4[11] = (byte)num23;
						num22 = 32 + 19;
						array4[11] = (byte)num22;
						array4[11] = 211;
						num23 = 152 - 50;
						array4[12] = (byte)num23;
						num22 = 192 - 64;
						array4[12] = (byte)num22;
						array4[12] = 95;
						array4[12] = 77;
						array4[13] = 148;
						array4[13] = 114;
						array4[13] = 101;
						num23 = 200 + 23;
						array4[13] = (byte)num23;
						num23 = 149 - 49;
						array4[14] = (byte)num23;
						num22 = 181 - 60;
						array4[14] = (byte)num22;
						array4[14] = 195;
						array4[15] = 119;
						num23 = 112 + 120;
						array4[15] = (byte)num23;
						num23 = 188 + 25;
						array4[15] = (byte)num23;
						num23 = 96 + 44;
						array4[16] = (byte)num23;
						array4[16] = 119;
						array4[16] = 143;
						num22 = 103 + 32;
						array4[16] = (byte)num22;
						num23 = 83 + 122;
						array4[16] = (byte)num23;
						num22 = 162 - 51;
						array4[16] = (byte)num22;
						num22 = 11 + 35;
						array4[17] = (byte)num22;
						array4[17] = 122;
						num22 = 36 + 3;
						array4[17] = (byte)num22;
						num23 = 124 + 119;
						array4[17] = (byte)num23;
						num22 = 8 + 60;
						array4[17] = (byte)num22;
						array4[17] = 200;
						num22 = 109 + 102;
						array4[18] = (byte)num22;
						array4[18] = 166;
						array4[18] = 104;
						array4[18] = 151;
						num22 = 75 + 63;
						array4[18] = (byte)num22;
						num23 = 12 + 88;
						array4[19] = (byte)num23;
						num23 = 98 + 30;
						array4[19] = (byte)num23;
						num22 = 65 + 18;
						array4[19] = (byte)num22;
						num23 = 50 + 55;
						array4[19] = (byte)num23;
						num23 = 203 - 123;
						array4[19] = (byte)num23;
						array4[20] = 150;
						array4[20] = 64;
						array4[20] = 91;
						num23 = 236 + 15;
						array4[20] = (byte)num23;
						array4[21] = 105;
						array4[21] = 191;
						num22 = 212 - 70;
						array4[21] = (byte)num22;
						array4[21] = 111;
						num22 = 230 - 76;
						array4[22] = (byte)num22;
						num22 = 244 - 81;
						array4[22] = (byte)num22;
						array4[22] = 140;
						array4[22] = 195;
						num22 = 208 - 69;
						array4[23] = (byte)num22;
						num23 = 134 - 44;
						array4[23] = (byte)num23;
						array4[23] = 96;
						num22 = 213 - 71;
						array4[23] = (byte)num22;
						num22 = 84 + 36;
						array4[23] = (byte)num22;
						array4[23] = 78;
						array4[24] = 199;
						num23 = 158 - 52;
						array4[24] = (byte)num23;
						array4[24] = 151;
						array4[25] = 120;
						array4[25] = 112;
						array4[25] = 107;
						array4[25] = 134;
						array4[25] = 186;
						array4[26] = 163;
						array4[26] = 106;
						num23 = 237 - 79;
						array4[26] = (byte)num23;
						num23 = 55 - 12;
						array4[26] = (byte)num23;
						array4[27] = 46;
						num23 = 97 + 99;
						array4[27] = (byte)num23;
						array4[27] = 102;
						array4[27] = 214;
						num22 = 46 + 113;
						array4[28] = (byte)num22;
						array4[28] = 118;
						num23 = 81 + 121;
						array4[28] = (byte)num23;
						num22 = 129 - 37;
						array4[28] = (byte)num22;
						array4[29] = 185;
						num23 = 123 + 124;
						array4[29] = (byte)num23;
						array4[29] = 168;
						array4[29] = 84;
						array4[29] = 12;
						array4[30] = 105;
						num22 = 57 + 121;
						array4[30] = (byte)num22;
						num22 = 59 + 22;
						array4[30] = (byte)num22;
						array4[30] = 237;
						num23 = 35 + 82;
						array4[31] = (byte)num23;
						num23 = 143 - 47;
						array4[31] = (byte)num23;
						num23 = 160 + 67;
						array4[31] = (byte)num23;
						byte[] array5 = array4;
						byte[] array6 = new byte[16];
						array6[0] = 165;
						array6[0] = 15;
						array6[0] = 216;
						int num24 = 107 + 23;
						array6[1] = (byte)num24;
						array6[1] = 144;
						array6[1] = 153;
						array6[1] = 58;
						int num25 = 241 - 80;
						array6[2] = (byte)num25;
						num25 = 96 + 120;
						array6[2] = (byte)num25;
						num24 = 54 + 31;
						array6[2] = (byte)num24;
						array6[2] = 147;
						num25 = 23 + 119;
						array6[3] = (byte)num25;
						array6[3] = 120;
						array6[3] = 144;
						num24 = 135 - 45;
						array6[3] = (byte)num24;
						array6[3] = 44;
						array6[4] = 156;
						num24 = 152 - 50;
						array6[4] = (byte)num24;
						num25 = 5 + 100;
						array6[4] = (byte)num25;
						num25 = 166 - 55;
						array6[4] = (byte)num25;
						array6[4] = 153;
						num25 = 34 - 4;
						array6[4] = (byte)num25;
						num25 = 187 - 62;
						array6[5] = (byte)num25;
						num24 = 205 - 68;
						array6[5] = (byte)num24;
						num25 = 69 + 70;
						array6[5] = (byte)num25;
						num24 = 228 - 76;
						array6[6] = (byte)num24;
						array6[6] = 126;
						array6[6] = 226;
						num25 = 211 - 70;
						array6[6] = (byte)num25;
						array6[6] = 99;
						num25 = 104 + 33;
						array6[6] = (byte)num25;
						array6[7] = 129;
						array6[7] = 117;
						num25 = 122 + 51;
						array6[7] = (byte)num25;
						array6[7] = 190;
						array6[8] = 108;
						array6[8] = 102;
						num24 = 6 + 44;
						array6[8] = (byte)num24;
						num25 = 126 - 6;
						array6[8] = (byte)num25;
						num24 = 186 - 62;
						array6[9] = (byte)num24;
						num24 = 185 - 61;
						array6[9] = (byte)num24;
						array6[9] = 100;
						array6[9] = 117;
						num25 = 82 - 45;
						array6[9] = (byte)num25;
						array6[10] = 102;
						num24 = 192 - 64;
						array6[10] = (byte)num24;
						num24 = 142 - 47;
						array6[10] = (byte)num24;
						array6[10] = 68;
						num24 = 40 + 108;
						array6[11] = (byte)num24;
						array6[11] = 115;
						array6[11] = 108;
						array6[11] = 85;
						num25 = 85 + 54;
						array6[11] = (byte)num25;
						num25 = 159 - 41;
						array6[11] = (byte)num25;
						num25 = 101 + 24;
						array6[12] = (byte)num25;
						num24 = 250 - 83;
						array6[12] = (byte)num24;
						num25 = 25 + 37;
						array6[12] = (byte)num25;
						array6[12] = 114;
						num25 = 173 - 57;
						array6[12] = (byte)num25;
						array6[12] = 186;
						array6[13] = 108;
						num24 = 110 + 103;
						array6[13] = (byte)num24;
						num25 = 195 + 11;
						array6[13] = (byte)num25;
						num24 = 252 - 84;
						array6[14] = (byte)num24;
						array6[14] = 119;
						array6[14] = 1;
						array6[15] = 54;
						array6[15] = 185;
						array6[15] = 13;
						byte[] array7 = array6;
						object obj2 = ccYCwSk07Q7K9vDUXbmV();
						gc7pjVk08cKyumI6wMa6(obj2, CipherMode.CBC);
						ICryptoTransform transform = (ICryptoTransform)CFFrwwk0ALY26hppZMFj(obj2, array5, array7);
						Stream stream = (Stream)nHtKhDk0PNEfHW71ggPM();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						PwwIBek0JjxCPHtA5BuJ(cryptoStream, array3, 0, array3.Length);
						mTR2r0k0F9QEdqXHY61C(cryptoStream);
						Ke1ZqUk0zfKGniPaZxGc(t0jN77Lpvf8, UWXL2ik0uEQ2ZWn7JVde(rbCTjtk03nTLV46h9U8f(), EOIfVWk0pWXEekN1tN6o(stream)));
						BY8KQRk20NEsNZJl5YFr(stream);
						BY8KQRk20NEsNZJl5YFr(cryptoStream);
						b859xjk229hVfx4aLmjC(hq9Gd9N8qvF64Paq8ke);
						int num26 = 0;
						if (cxXcUvk0qJGBbjDxkNNT())
						{
							num26 = 0;
						}
						switch (num26)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num27 = 0;
						if (cxXcUvk0qJGBbjDxkNNT())
						{
							num27 = 0;
						}
						while (true)
						{
							switch (num27)
							{
							default:
								flag = true;
								num27 = 1;
								if (!cxXcUvk0qJGBbjDxkNNT())
								{
									num27 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 20;
				case 11:
					flag = false;
					num2 = 10;
					if (OeYJVCk0I3oMWysrMVVx() == null)
					{
						num2 = 16;
					}
					continue;
				case 12:
					t0jN77Lpvf8 = new RSACryptoServiceProvider();
					num2 = 18;
					continue;
				case 20:
					if (!flag)
					{
						num2 = 2;
						if (OeYJVCk0I3oMWysrMVVx() != null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 13;
				case 5:
					return;
				case 14:
					try
					{
						hashAlgorithm = (HashAlgorithm)YUop5Dk0ZE7PZmfZIf1n();
						int num30 = 1;
						if (!cxXcUvk0qJGBbjDxkNNT())
						{
							num30 = 0;
						}
						while (true)
						{
							switch (num30)
							{
							case 1:
								text2 = (string)E4UnvVk0VhPiN5a4Kdeh("SHA1");
								num30 = 4;
								if (!cxXcUvk0qJGBbjDxkNNT())
								{
									num30 = 1;
								}
								continue;
							case 2:
								return;
							case 3:
								break;
							case 4:
								if (!N3dWrRk0C2twZai7bHdT(text))
								{
									return;
								}
								num30 = 1;
								if (cxXcUvk0qJGBbjDxkNNT())
								{
									num30 = 3;
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
						int num31 = 0;
						if (OeYJVCk0I3oMWysrMVVx() == null)
						{
							num31 = 0;
						}
						switch (num31)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 11;
				case 4:
					num2 = 3;
					if (OeYJVCk0I3oMWysrMVVx() == null)
					{
						num2 = 3;
					}
					continue;
				case 15:
					return;
				case 3:
					try
					{
						if (binaryReader != null)
						{
							int num28 = 0;
							if (OeYJVCk0I3oMWysrMVVx() == null)
							{
								num28 = 1;
							}
							while (true)
							{
								switch (num28)
								{
								case 1:
									ofUQAGk2D4T2UFjBUjXx(binaryReader);
									num28 = 0;
									if (cxXcUvk0qJGBbjDxkNNT())
									{
										num28 = 0;
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
						int num29 = 0;
						if (!cxXcUvk0qJGBbjDxkNNT())
						{
							num29 = 0;
						}
						switch (num29)
						{
						case 0:
							break;
						}
					}
					goto case 13;
				case 18:
					text = (string)ecjAaVk0T3MeiA234AWg(WLOSsTk0UcSOImpenorT(typeof(RUVZnUNwJg2VA9xTOL2q).TypeHandle).Assembly);
					num2 = 21;
					continue;
				case 9:
					goto end_IL_0012;
				case 1:
					if (t0jN77Lpvf8 != null)
					{
						num2 = 0;
						if (cxXcUvk0qJGBbjDxkNNT())
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 21:
					if (text == null)
					{
						num2 = 5;
						continue;
					}
					break;
				case 19:
					return;
				case 13:
					if (flag)
					{
						num2 = 17;
						continue;
					}
					flag = false;
					num2 = 15;
					if (!cxXcUvk0qJGBbjDxkNNT())
					{
						num2 = 11;
					}
					continue;
				case 7:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num3 = 7;
						while (true)
						{
							int num16;
							switch (num3)
							{
							case 16:
							case 40:
							case 44:
								if (num12 != 0)
								{
									num3 = 37;
									continue;
								}
								goto case 24;
							case 43:
								array2 = (byte[])XBUUySk2axwWx1Hgj8S5(binaryReader, (int)num19);
								num3 = 0;
								if (OeYJVCk0I3oMWysrMVVx() == null)
								{
									num3 = 9;
								}
								continue;
							case 41:
								QtnDK5k0m5gFaVvf00Gx(fileStream, gaqZf9k2GXkXGcrBGs7Z(fileStream) + num14);
								num3 = 17;
								if (OeYJVCk0I3oMWysrMVVx() == null)
								{
									num3 = 44;
								}
								continue;
							case 9:
								KlF8Fsk2ivBDxMLRy9Fp(array2);
								num3 = 35;
								continue;
							case 12:
								MsrKgIk2BACDtQaFqPTC(hashAlgorithm, new byte[0], 0, 0);
								num3 = 32;
								continue;
							case 33:
								num20 = SC3t0Dk2YpIp2b2R95pU(binaryReader);
								num3 = 45;
								continue;
							case 19:
								num17 = 0;
								num3 = 0;
								if (cxXcUvk0qJGBbjDxkNNT())
								{
									num3 = 2;
								}
								continue;
							case 7:
								binaryReader = new BinaryReader(fileStream);
								num16 = 5;
								goto IL_17e4;
							case 34:
								num12 -= num9;
								num3 = 16;
								if (OeYJVCk0I3oMWysrMVVx() != null)
								{
									num3 = 10;
								}
								continue;
							case 13:
								num12 = SC3t0Dk2YpIp2b2R95pU(binaryReader);
								num3 = 18;
								if (cxXcUvk0qJGBbjDxkNNT())
								{
									num3 = 33;
								}
								continue;
							case 26:
								QtnDK5k0m5gFaVvf00Gx(fileStream, num8);
								num3 = 10;
								if (OeYJVCk0I3oMWysrMVVx() == null)
								{
									num3 = 19;
								}
								continue;
							case 4:
								RoPFIlk2HTfmHuQceBR4(hashAlgorithm, fileStream, 152u, array);
								num3 = 11;
								continue;
							case 35:
								flag = !V879yok24HJBOuyntkbk(t0jN77Lpvf8, VMvyxJk2luqdyCuDaleI(hashAlgorithm), text2, array2);
								num3 = 38;
								continue;
							default:
								num11 = gaqZf9k2GXkXGcrBGs7Z(fileStream);
								num3 = 25;
								continue;
							case 15:
							case 28:
								num9 = (uint)esNUK8k2vEQSPk9751yJ(num10 - num11, num12);
								num3 = 2;
								if (OeYJVCk0I3oMWysrMVVx() == null)
								{
									num3 = 6;
								}
								continue;
							case 1:
							case 21:
								num15 = oktKX5k2o1p5wH8HI17f(SC3t0Dk2YpIp2b2R95pU(binaryReader), num7, num6, binaryReader);
								num3 = 8;
								if (!cxXcUvk0qJGBbjDxkNNT())
								{
									num3 = 2;
								}
								continue;
							case 29:
								if (num14 < num12)
								{
									num3 = 36;
									if (!cxXcUvk0qJGBbjDxkNNT())
									{
										num3 = 11;
									}
									continue;
								}
								goto case 24;
							case 3:
								num13 = num10 + num19;
								num3 = 17;
								if (OeYJVCk0I3oMWysrMVVx() == null)
								{
									num3 = 26;
								}
								continue;
							case 6:
								RoPFIlk2HTfmHuQceBR4(hashAlgorithm, fileStream, num9, array);
								num3 = 34;
								continue;
							case 2:
							case 14:
								if (num17 < num7)
								{
									num16 = 20;
									goto IL_17e4;
								}
								goto case 12;
							case 27:
								RoPFIlk2HTfmHuQceBR4(hashAlgorithm, fileStream, num12, array);
								num3 = 46;
								continue;
							case 45:
								QtnDK5k0m5gFaVvf00Gx(fileStream, num20);
								num3 = 40;
								continue;
							case 32:
								QtnDK5k0m5gFaVvf00Gx(fileStream, num10);
								num3 = 43;
								continue;
							case 22:
							case 30:
								QtnDK5k0m5gFaVvf00Gx(fileStream, 376L);
								num3 = 1;
								if (OeYJVCk0I3oMWysrMVVx() != null)
								{
									num3 = 1;
								}
								continue;
							case 39:
							{
								uint num18 = SC3t0Dk2YpIp2b2R95pU(binaryReader);
								num19 = SC3t0Dk2YpIp2b2R95pU(binaryReader);
								num10 = oktKX5k2o1p5wH8HI17f(num18, num7, num6, binaryReader);
								num3 = 3;
								if (OeYJVCk0I3oMWysrMVVx() != null)
								{
									num3 = 3;
								}
								continue;
							}
							case 47:
								QtnDK5k0m5gFaVvf00Gx(fileStream, 360L);
								num3 = 21;
								continue;
							case 20:
							case 31:
								QtnDK5k0m5gFaVvf00Gx(fileStream, num6 + num17 * 40 + 16);
								num3 = 13;
								continue;
							case 10:
								if (num11 >= num13)
								{
									num3 = 42;
									if (!cxXcUvk0qJGBbjDxkNNT())
									{
										num3 = 34;
									}
									continue;
								}
								goto case 17;
							case 8:
								QtnDK5k0m5gFaVvf00Gx(fileStream, num15 + 32);
								num16 = 39;
								goto IL_17e4;
							case 24:
							case 46:
								num17++;
								num3 = 6;
								if (OeYJVCk0I3oMWysrMVVx() == null)
								{
									num3 = 14;
								}
								continue;
							case 36:
								num12 -= num14;
								num3 = 41;
								continue;
							case 5:
								array = new byte[65536];
								num3 = 2;
								if (cxXcUvk0qJGBbjDxkNNT())
								{
									num3 = 4;
								}
								continue;
							case 17:
								num14 = (uint)(num13 - num11);
								num3 = 29;
								if (!cxXcUvk0qJGBbjDxkNNT())
								{
									num3 = 10;
								}
								continue;
							case 25:
								if (num10 > num11)
								{
									num3 = 23;
									if (!cxXcUvk0qJGBbjDxkNNT())
									{
										num3 = 21;
									}
									continue;
								}
								goto case 10;
							case 18:
							case 23:
							case 42:
								if (num11 < num13)
								{
									num3 = 15;
									continue;
								}
								goto case 27;
							case 11:
							{
								bool num4 = f1QJd8k2fCxBrKd3o8Jq(binaryReader) != 523;
								int num5 = (num4 ? 96 : 112);
								QtnDK5k0m5gFaVvf00Gx(fileStream, 152L);
								MDtJJ4k29JfM71fbni6H(fileStream, array, 0, num5);
								array[64] = 0;
								array[65] = 0;
								array[66] = 0;
								array[67] = 0;
								rFv381k2nSeKTXcn2v73(hashAlgorithm, array, 0, num5);
								MDtJJ4k29JfM71fbni6H(fileStream, array, 0, 128);
								array[32] = 0;
								array[33] = 0;
								array[34] = 0;
								array[35] = 0;
								array[36] = 0;
								array[37] = 0;
								array[38] = 0;
								array[39] = 0;
								rFv381k2nSeKTXcn2v73(hashAlgorithm, array, 0, 128);
								num6 = gaqZf9k2GXkXGcrBGs7Z(fileStream);
								QtnDK5k0m5gFaVvf00Gx(fileStream, 134L);
								num7 = f1QJd8k2fCxBrKd3o8Jq(binaryReader);
								QtnDK5k0m5gFaVvf00Gx(fileStream, num6);
								RoPFIlk2HTfmHuQceBR4(hashAlgorithm, fileStream, (uint)(num7 * 40), array);
								num8 = gaqZf9k2GXkXGcrBGs7Z(fileStream);
								if (!num4)
								{
									num3 = 30;
									continue;
								}
								goto case 47;
							}
							case 38:
								break;
								IL_17e4:
								num3 = num16;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num21 = 0;
						if (OeYJVCk0I3oMWysrMVVx() == null)
						{
							num21 = 0;
						}
						while (true)
						{
							switch (num21)
							{
							default:
								flag = true;
								num21 = 1;
								if (OeYJVCk0I3oMWysrMVVx() != null)
								{
									num21 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 4;
				case 8:
					Uo1rSek0t8YCXRHqo9Om(true);
					num2 = 12;
					continue;
				case 2:
					binaryReader = null;
					num2 = 7;
					continue;
				case 17:
					throw new Exception((string)IC2mNKk2kfGTfOR4juF9(mE6qh4k2NKCUsnm1fTXC(Jw2xj0k2bWen9X5DtHWq(WLOSsTk0UcSOImpenorT(typeof(RUVZnUNwJg2VA9xTOL2q).TypeHandle).Assembly)), " is tampered."));
				case 6:
					break;
				}
				if (JuEhtPk0y97AR1T6DFxq(text) != 0)
				{
					hashAlgorithm = null;
					num2 = 10;
				}
				else
				{
					num2 = 19;
				}
				continue;
				end_IL_0012:
				break;
			}
			kYLA8lk0WcRU0Aw7BjTU();
			num = 8;
		}
	}

	public static void mMCN7aZx0T7(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (Uy2N78SNKld == null)
			{
				lock (vt0N7AljdZM)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554508)).Assembly.GetManifestResourceStream("mF6Er0NhunIifIQ0HVqA.U54hULNhz7WUuyuphDFD"));
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
							num3 += HPwN74fqnaE(num3);
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
						hq9Gd9N8qvF64Paq8ke1 hq9Gd9N8qvF64Paq8ke = new hq9Gd9N8qvF64Paq8ke1(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = hq9Gd9N8qvF64Paq8ke.oa7N8t9d1PM();
							int value = hq9Gd9N8qvF64Paq8ke.oa7N8t9d1PM();
							dictionary.Add(key, value);
						}
						hq9Gd9N8qvF64Paq8ke.SKvN8UtwYVT();
					}
					Uy2N78SNKld = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = Uy2N78SNKld[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554508)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777237));
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

	private static uint Ca2N7lQCFyR(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint HPwN74fqnaE(uint P_0)
	{
		return 0u;
	}

	internal static void MYjN7DyvnQ8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ciFN7bhDmWJ(Stream P_0, int P_1)
	{
		pcphsXNAkpvYVMbRV1Zp.ERZNALUACh4(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string PIwN7NHVqJi(int P_0)
	{
		if (QCjN7pQbVbs.Length == 0)
		{
			d5BN7FFMNO6 = new List<string>();
			ei9N739NXdD = new List<int>();
			ciFN7bhDmWJ(n8BN7KHHBUK.GetManifestResourceStream("12LNRpNhh1u8pNHfcTDB.PL4uF5NhwoOVlHQ4yZlM"), P_0);
		}
		if (hMoN7PHMoyV < 75)
		{
			if (n8BN7KHHBUK != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			hMoN7PHMoyV++;
		}
		lock (nF4N7JIdgFD)
		{
			int num = BitConverter.ToInt32(QCjN7pQbVbs, P_0);
			if (num < ei9N739NXdD.Count && ei9N739NXdD[num] == P_0)
			{
				return d5BN7FFMNO6[num];
			}
			try
			{
				PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
				byte[] array = new byte[num];
				Array.Copy(QCjN7pQbVbs, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				d5BN7FFMNO6.Add(text);
				ei9N739NXdD.Add(P_0);
				Array.Copy(BitConverter.GetBytes(d5BN7FFMNO6.Count - 1), 0, QCjN7pQbVbs, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string oJkN7kwLreF(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int BFqN71JRK8R()
	{
		return 5;
	}

	private static void ixkN75D94Ti()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate QEkN7SkUoeV(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777273)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777266)),
			Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777254))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object ayEN7xJjlhU(object P_0)
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
	public static extern IntPtr AScN7L0KQb4(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr LhSN7e7QCg3(IntPtr P_0, string P_1);

	private static IntPtr sevN7sb3QY7(IntPtr P_0, string P_1, uint P_2)
	{
		if (XbyN8koWvXI == null)
		{
			XbyN8koWvXI = (QDk79JN8yDad39Hv486w)Marshal.GetDelegateForFunctionPointer(LhSN7e7QCg3(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554517)));
		}
		return XbyN8koWvXI(P_0, P_1, P_2);
	}

	private static IntPtr oFrN7XJLuwZ(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (q3lN81KG4p4 == null)
		{
			q3lN81KG4p4 = (bLw4U0N8ZOvvBW32Rwpo)Marshal.GetDelegateForFunctionPointer(LhSN7e7QCg3(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554518)));
		}
		return q3lN81KG4p4(P_0, P_1, P_2, P_3);
	}

	private static int w2oN7cIi7LJ(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (ndGN85ANHj5 == null)
		{
			ndGN85ANHj5 = (nC42HKN8VV3dAZ1P2Ted)Marshal.GetDelegateForFunctionPointer(LhSN7e7QCg3(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554519)));
		}
		return ndGN85ANHj5(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int MC3N7jFl6fL(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (BvUN8SouYac == null)
		{
			BvUN8SouYac = (NWCwTON8C2tYu4SxYr7b)Marshal.GetDelegateForFunctionPointer(LhSN7e7QCg3(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554520)));
		}
		return BvUN8SouYac(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr sc8N7EttWC4(uint P_0, int P_1, uint P_2)
	{
		if (YqFN8xbrBEs == null)
		{
			YqFN8xbrBEs = (quCBdRN8rZMGOhjrEJRY)Marshal.GetDelegateForFunctionPointer(LhSN7e7QCg3(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554521)));
		}
		return YqFN8xbrBEs(P_0, P_1, P_2);
	}

	private static int GwNN7QyXVgf(IntPtr P_0)
	{
		if (v1bN8LYMx9d == null)
		{
			v1bN8LYMx9d = (l4FuTqN8K1WYgSxRoPI2)Marshal.GetDelegateForFunctionPointer(LhSN7e7QCg3(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554522)));
		}
		return v1bN8LYMx9d(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (aAoN8ecdD0G == IntPtr.Zero)
		{
			aAoN8ecdD0G = AScN7L0KQb4("kernel ".Trim() + "32.dll");
		}
		return aAoN8ecdD0G;
	}

	private static byte[] EiXN7dcUSvD(string P_0)
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

	internal static Stream HVgN7gnw49f()
	{
		return new MemoryStream();
	}

	internal static byte[] RE2N7RPTZkc(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] iBfN76NwOr9(byte[] P_0)
	{
		Stream stream = HVgN7gnw49f();
		SymmetricAlgorithm symmetricAlgorithm = tRGN79LhFMR();
		symmetricAlgorithm.Key = new byte[32]
		{
			205, 17, 17, 195, 73, 153, 227, 155, 199, 63,
			78, 81, 190, 125, 162, 162, 2, 83, 251, 164,
			89, 214, 180, 242, 11, 100, 14, 26, 48, 31,
			229, 65
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			185, 117, 211, 102, 138, 226, 193, 242, 212, 92,
			43, 84, 86, 249, 232, 122
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = RE2N7RPTZkc(stream);
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		return result;
	}

	private unsafe static int PVON7MDqyLK(string P_0)
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

	internal static bool ejmN7OdUguW(string P_0, string P_1)
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
		if (P_0.StartsWith(bPAN8sd2tjF))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(bPAN8sd2tjF))
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
			num = PVON7MDqyLK(P_0);
		}
		if (!flag2)
		{
			num2 = PVON7MDqyLK(P_1);
		}
		return num == num2;
	}

	private byte[] puIN7qeEYaD()
	{
		return null;
	}

	private byte[] KOGN7I6IEcK()
	{
		return null;
	}

	private byte[] eQrN7WVXCHc()
	{
		return null;
	}

	private byte[] xlMN7tWSyxA()
	{
		return null;
	}

	private byte[] MCbN7UAxnyO()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] X6iN7TN7tY9()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] rqHN7yWdB9G()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] nmFN7ZsX5WL()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] xMIN7V89TfE()
	{
		return null;
	}

	internal byte[] b2rN7Cdka4R()
	{
		return null;
	}

	internal static object KB2jQIk01J6p5qZlGTMB(object P_0)
	{
		return ((hq9Gd9N8qvF64Paq8ke1)P_0).m9OIO8Q0EK();
	}

	internal static void Ok4Vuok059hVaPXgj67m(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long DOtRa2k0SAGB8qqIUUIR(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object aDhm1tk0xKiUBk12Vrhr(object P_0, int P_1)
	{
		return ((hq9Gd9N8qvF64Paq8ke1)P_0).YCIN8INYlRd(P_1);
	}

	internal static void cjHjpek0Lso0GVSXFICg(object P_0)
	{
		((hq9Gd9N8qvF64Paq8ke1)P_0).SKvN8UtwYVT();
	}

	internal static void A7TQ0Xk0eeoh83N0LI8g(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object Qefv54k0spU80xy2djG5(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object dcEdB3k0XbVK5n6hRlsB(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object w3IwWTk0cuwgX8Qe25I8()
	{
		return tRGN79LhFMR();
	}

	internal static void px4ICwk0jMd4pdU0eVbW(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object AfeyvNk0E36CeE60cpS9(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object T1wbfqk0QMjKl7026dey()
	{
		return HVgN7gnw49f();
	}

	internal static void pKVC2Rk0djV25AQyUcSn(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void JTSwL6k0gnHsQ7tFHywu(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object tn30i4k0RgeDACFwf2Tv(object P_0)
	{
		return RE2N7RPTZkc((Stream)P_0);
	}

	internal static void El0S0Jk06mYh7EFP5NvD(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object UXPy3Fk0MvNmvgqDhZO8(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool A0LWOkk0O12V8DgcRRID(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool biTZusk0NnkWb7dsVrIy()
	{
		return (object)null == null;
	}

	internal static object o4a31sk0kltYcbMSRWog()
	{
		return null;
	}

	internal static void kYLA8lk0WcRU0Aw7BjTU()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
	}

	internal static void Uo1rSek0t8YCXRHqo9Om(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type WLOSsTk0UcSOImpenorT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ecjAaVk0T3MeiA234AWg(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int JuEhtPk0y97AR1T6DFxq(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object YUop5Dk0ZE7PZmfZIf1n()
	{
		return SHA1.Create();
	}

	internal static object E4UnvVk0VhPiN5a4Kdeh(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool N3dWrRk0C2twZai7bHdT(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object yLYmX3k0r57y8IwXcQ7N(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object mAclAsk0KHWSMqDGAxMc(object P_0)
	{
		return ((hq9Gd9N8qvF64Paq8ke1)P_0).m9OIO8Q0EK();
	}

	internal static void QtnDK5k0m5gFaVvf00Gx(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long MhtZcjk0hVxZgVtmHtoR(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object qFmtIHk0wO2fsOq8oT4P(object P_0, int P_1)
	{
		return ((hq9Gd9N8qvF64Paq8ke1)P_0).YCIN8INYlRd(P_1);
	}

	internal static object ccYCwSk07Q7K9vDUXbmV()
	{
		return tRGN79LhFMR();
	}

	internal static void gc7pjVk08cKyumI6wMa6(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object CFFrwwk0ALY26hppZMFj(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object nHtKhDk0PNEfHW71ggPM()
	{
		return HVgN7gnw49f();
	}

	internal static void PwwIBek0JjxCPHtA5BuJ(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void mTR2r0k0F9QEdqXHY61C(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object rbCTjtk03nTLV46h9U8f()
	{
		return Encoding.UTF8;
	}

	internal static object EOIfVWk0pWXEekN1tN6o(object P_0)
	{
		return RE2N7RPTZkc((Stream)P_0);
	}

	internal static object UWXL2ik0uEQ2ZWn7JVde(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void Ke1ZqUk0zfKGniPaZxGc(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void BY8KQRk20NEsNZJl5YFr(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void b859xjk229hVfx4aLmjC(object P_0)
	{
		((hq9Gd9N8qvF64Paq8ke1)P_0).SKvN8UtwYVT();
	}

	internal static void RoPFIlk2HTfmHuQceBR4(object P_0, object P_1, uint P_2, object P_3)
	{
		wvnN7YL173H((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort f1QJd8k2fCxBrKd3o8Jq(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int MDtJJ4k29JfM71fbni6H(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void rFv381k2nSeKTXcn2v73(object P_0, object P_1, int P_2, int P_3)
	{
		IOHN7o1AZYk((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long gaqZf9k2GXkXGcrBGs7Z(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint SC3t0Dk2YpIp2b2R95pU(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint oktKX5k2o1p5wH8HI17f(uint P_0, int P_1, long P_2, object P_3)
	{
		return aA4N7vvrsn2(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long esNUK8k2vEQSPk9751yJ(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object MsrKgIk2BACDtQaFqPTC(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object XBUUySk2axwWx1Hgj8S5(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void KlF8Fsk2ivBDxMLRy9Fp(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object VMvyxJk2luqdyCuDaleI(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool V879yok24HJBOuyntkbk(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void ofUQAGk2D4T2UFjBUjXx(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object Jw2xj0k2bWen9X5DtHWq(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object mE6qh4k2NKCUsnm1fTXC(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object IC2mNKk2kfGTfOR4juF9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool cxXcUvk0qJGBbjDxkNNT()
	{
		return (object)null == null;
	}

	internal static object OeYJVCk0I3oMWysrMVVx()
	{
		return null;
	}
}
