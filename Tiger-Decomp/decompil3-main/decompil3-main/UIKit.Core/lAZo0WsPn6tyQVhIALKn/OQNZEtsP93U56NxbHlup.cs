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
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using R72ySIsFEH144oNis8Mo;

namespace lAZo0WsPn6tyQVhIALKn;

internal class OQNZEtsP93U56NxbHlup
{
	private delegate void BCgBKfsJOwclIOTNtH1d(object o);

	internal class xV1CWisJqTaXVNAeilwP : Attribute
	{
		internal class gLUkNusJIfdWTn5n6heo<afSSmysJWfrkoNIAilv3>
		{
			private static object gWERsyXiVX7xlvL9pY1V;

			public gLUkNusJIfdWTn5n6heo()
			{
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				base._002Ector();
			}

			static gLUkNusJIfdWTn5n6heo()
			{
				tMIsP5FCtWb();
				HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static bool NWCrb9XiCCnITwYODFrg()
			{
				return gWERsyXiVX7xlvL9pY1V == null;
			}

			internal static object RyUatpXirSNL2rLHygUi()
			{
				return gWERsyXiVX7xlvL9pY1V;
			}
		}

		public xV1CWisJqTaXVNAeilwP(object P_0)
		{
		}

		static xV1CWisJqTaXVNAeilwP()
		{
			HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal class h4RTPPsJtVjKbohj0u6J
	{
		internal static string BAGsJUUK6an(string P_0, string P_1)
		{
			byte[] bytes = ((Encoding)Gi6OjFXiwFk63NARaMRX()).GetBytes(P_0);
			byte[] array = new byte[32];
			q8KM7UXi71DN2T01xecO(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] key = array;
			byte[] iV = (byte[])Bd6hfSXiAfOZop5XcJwl(D6PXcOXi8KkgsJGtnl82(Encoding.Unicode, P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = JYQsP4jByQW();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			CsL8jcXiP8ZlFWpl0EYu(cryptoStream, bytes, 0, bytes.Length);
			wG3NvWXiJuGPCVQuyB4R(cryptoStream);
			return Convert.ToBase64String((byte[])qBVd0vXiFJqyqCekLnwo(memoryStream));
		}

		static h4RTPPsJtVjKbohj0u6J()
		{
			md11deXi31Hv51afXNsg();
		}

		internal static object Gi6OjFXiwFk63NARaMRX()
		{
			return Encoding.Unicode;
		}

		internal static void q8KM7UXi71DN2T01xecO(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static object D6PXcOXi8KkgsJGtnl82(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static object Bd6hfSXiAfOZop5XcJwl(object P_0)
		{
			return G6asPbtViy1((byte[])P_0);
		}

		internal static void CsL8jcXiP8ZlFWpl0EYu(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void wG3NvWXiJuGPCVQuyB4R(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object qBVd0vXiFJqyqCekLnwo(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal static void md11deXi31Hv51afXNsg()
		{
			HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint W7PhubsJT8xmm5YYdRPa(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr N3WyvssJyiJvxaYfV0Cm();

	internal struct nuUqNqsJZHjD56ShLVhl
	{
		internal bool huhsJVEpZGq;

		internal byte[] OQysJCk6LhD;
	}

	internal class esTXBjsJrjJbaHqQrcuh
	{
		private BinaryReader zm9sJ71MmZC;

		public esTXBjsJrjJbaHqQrcuh(Stream P_0)
		{
			zm9sJ71MmZC = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return zm9sJ71MmZC.BaseStream;
		}

		internal byte[] VtvsJKVst6l(int P_0)
		{
			return (byte[])NgghD8XlfvtxhCF9jDyu(zm9sJ71MmZC, P_0);
		}

		internal int x5UsJmJIJFP(byte[] P_0, int P_1, int P_2)
		{
			return zm9sJ71MmZC.Read(P_0, P_1, P_2);
		}

		internal int CVfsJhfIcUa()
		{
			return zm9sJ71MmZC.ReadInt32();
		}

		internal void NQ7sJwYVQqv()
		{
			zm9sJ71MmZC.Close();
		}

		static esTXBjsJrjJbaHqQrcuh()
		{
			Fu8dgyXl9voRlP07fAI5();
		}

		internal static object NgghD8XlfvtxhCF9jDyu(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static void Fu8dgyXl9voRlP07fAI5()
		{
			HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr DFik8gsJ8IP2E0jWmOn0(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr DDIMrWsJAXHnjkRPgJFY(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int jUsiC6sJPvS3BsfNSQHI(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Qv0GCJsJJ4vgk4DGkt1E(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr WsdKCRsJFbhy7xQPDlxO(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Bpn8WHsJ30lpl6S2XwuL(IntPtr ptr);

	[Flags]
	private enum cSu9dRsJpXxMviHChvGk
	{

	}

	private static int mlJsJfmJlhO;

	private static byte[] lFdsJoi0jOc;

	private static bool DMJsJ4iFbsh;

	internal static W7PhubsJT8xmm5YYdRPa eutsJ1BE42F;

	private static IntPtr x5rsJsMonH3;

	private static IntPtr Q9BsJ6XtC5q;

	private static IntPtr RwFsJvuiYEx;

	private static WsdKCRsJFbhy7xQPDlxO qVFsJg8AgO7;

	internal static W7PhubsJT8xmm5YYdRPa YXXsJk5Ddu5;

	private static string DiasJMhJf2p;

	private static byte[] jEOsJYHH2Wf;

	private static uint[] uySsPpHfdep;

	private static DFik8gsJ8IP2E0jWmOn0 MoZsJjQJlur;

	private static int kkJsJer9b5p;

	private static int effsJbDDIsu;

	private static object QVgsJaox3im;

	internal static Assembly fhUsP3WKQnO;

	private static Dictionary<int, int> mC5sJ2HoFGA;

	private static IntPtr HN3sJByo7bF;

	private static List<string> JfbsJnHKUWx;

	private static bool KlPsJxgAr0r;

	private static Bpn8WHsJ30lpl6S2XwuL Cd9sJRDKxxs;

	[xV1CWisJqTaXVNAeilwP(typeof(xV1CWisJqTaXVNAeilwP.gLUkNusJIfdWTn5n6heo<object>[]))]
	private static bool hcUsJXd3xr1;

	private static int oEosJS5Wm1t;

	private static SortedList WxrsJDJYVxo;

	private static Qv0GCJsJJ4vgk4DGkt1E NcCsJdKJHV6;

	private static object dnHsJ9oV3il;

	private static bool zu8sJLonkEv;

	private static List<int> JrNsJGpG0P0;

	private static int[] Bq4sJiaD3ux;

	internal static RSACryptoServiceProvider RyDsJ0ddOeh;

	private static long IqBsJNsjWaR;

	private static bool ztosPufGoGb;

	private static long udJsJ5mWn8A;

	internal static Hashtable lSysJc4EHs5;

	private static int L4bsJltxPDG;

	private static DDIMrWsJAXHnjkRPgJFY m6osJEfBjDm;

	private static jUsiC6sJPvS3BsfNSQHI gQxsJQ1Cxit;

	private static bool SIisPzGmSWR;

	private static object psbsJHhZLQk;

	private static bool RoisPFREGEe;

	static OQNZEtsP93U56NxbHlup()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		RoisPFREGEe = false;
		fhUsP3WKQnO = Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554495)).Assembly;
		uySsPpHfdep = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		ztosPufGoGb = false;
		SIisPzGmSWR = false;
		RyDsJ0ddOeh = null;
		mC5sJ2HoFGA = null;
		psbsJHhZLQk = new object();
		mlJsJfmJlhO = 0;
		dnHsJ9oV3il = new object();
		JfbsJnHKUWx = null;
		JrNsJGpG0P0 = null;
		jEOsJYHH2Wf = new byte[0];
		lFdsJoi0jOc = new byte[0];
		RwFsJvuiYEx = IntPtr.Zero;
		HN3sJByo7bF = IntPtr.Zero;
		QVgsJaox3im = new string[0];
		Bq4sJiaD3ux = new int[0];
		L4bsJltxPDG = 1;
		DMJsJ4iFbsh = false;
		WxrsJDJYVxo = new SortedList();
		effsJbDDIsu = 0;
		IqBsJNsjWaR = 0L;
		YXXsJk5Ddu5 = null;
		eutsJ1BE42F = null;
		udJsJ5mWn8A = 0L;
		oEosJS5Wm1t = 0;
		KlPsJxgAr0r = false;
		zu8sJLonkEv = false;
		kkJsJer9b5p = 0;
		x5rsJsMonH3 = IntPtr.Zero;
		hcUsJXd3xr1 = false;
		lSysJc4EHs5 = new Hashtable();
		MoZsJjQJlur = null;
		m6osJEfBjDm = null;
		gQxsJQ1Cxit = null;
		NcCsJdKJHV6 = null;
		qVFsJg8AgO7 = null;
		Cd9sJRDKxxs = null;
		Q9BsJ6XtC5q = IntPtr.Zero;
		DiasJMhJf2p = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void rqNX50GcjNW()
	{
	}

	internal static byte[] ob8sPGWfhR2(byte[] P_0)
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
			KJNsPYfsK3W(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			KJNsPYfsK3W(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			KJNsPYfsK3W(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			KJNsPYfsK3W(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			KJNsPYfsK3W(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			KJNsPYfsK3W(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			KJNsPYfsK3W(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			KJNsPYfsK3W(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			KJNsPYfsK3W(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			KJNsPYfsK3W(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			KJNsPYfsK3W(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			KJNsPYfsK3W(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			KJNsPYfsK3W(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			KJNsPYfsK3W(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			KJNsPYfsK3W(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			KJNsPYfsK3W(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			RHqsPohSjX3(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			RHqsPohSjX3(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			RHqsPohSjX3(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			RHqsPohSjX3(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			RHqsPohSjX3(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			RHqsPohSjX3(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			RHqsPohSjX3(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			RHqsPohSjX3(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			RHqsPohSjX3(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			RHqsPohSjX3(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			RHqsPohSjX3(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			RHqsPohSjX3(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			RHqsPohSjX3(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			RHqsPohSjX3(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			RHqsPohSjX3(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			RHqsPohSjX3(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			L8CsPvRNldG(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			L8CsPvRNldG(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			L8CsPvRNldG(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			L8CsPvRNldG(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			L8CsPvRNldG(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			L8CsPvRNldG(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			L8CsPvRNldG(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			L8CsPvRNldG(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			L8CsPvRNldG(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			L8CsPvRNldG(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			L8CsPvRNldG(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			L8CsPvRNldG(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			L8CsPvRNldG(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			L8CsPvRNldG(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			L8CsPvRNldG(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			L8CsPvRNldG(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			NOVsPBGtLQ3(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			NOVsPBGtLQ3(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			NOVsPBGtLQ3(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			NOVsPBGtLQ3(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			NOVsPBGtLQ3(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			NOVsPBGtLQ3(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			NOVsPBGtLQ3(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			NOVsPBGtLQ3(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			NOVsPBGtLQ3(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			NOVsPBGtLQ3(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			NOVsPBGtLQ3(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			NOVsPBGtLQ3(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			NOVsPBGtLQ3(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			NOVsPBGtLQ3(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			NOVsPBGtLQ3(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			NOVsPBGtLQ3(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void KJNsPYfsK3W(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + tCPsPaAuw90(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + uySsPpHfdep[P_6 - 1], P_5);
	}

	private static void RHqsPohSjX3(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + tCPsPaAuw90(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + uySsPpHfdep[P_6 - 1], P_5);
	}

	private static void L8CsPvRNldG(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + tCPsPaAuw90(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + uySsPpHfdep[P_6 - 1], P_5);
	}

	private static void NOVsPBGtLQ3(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + tCPsPaAuw90(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + uySsPpHfdep[P_6 - 1], P_5);
	}

	private static uint tCPsPaAuw90(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool QoHsPiqZry2()
	{
		if (!ztosPufGoGb)
		{
			tpesPDk6bQP();
			ztosPufGoGb = true;
		}
		return SIisPzGmSWR;
	}

	internal OQNZEtsP93U56NxbHlup()
	{
	}

	private void MpgsPl7aUW4(byte[] P_0, byte[] P_1, byte[] P_2)
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
		jEOsJYHH2Wf = array;
	}

	internal static SymmetricAlgorithm JYQsP4jByQW()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (QoHsPiqZry2())
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

	internal static void tpesPDk6bQP()
	{
		try
		{
			SIisPzGmSWR = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] G6asPbtViy1(byte[] P_0)
	{
		if (!QoHsPiqZry2())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return ob8sPGWfhR2(P_0);
	}

	internal static void bVwsPNjDBgE(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			vi3sPkVnXk0(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void vi3sPkVnXk0(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint RaCsP1Kd7VC(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	internal static void tMIsP5FCtWb()
	{
		int num = 13;
		int num2 = num;
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text2 = default(string);
		string text = default(string);
		bool flag = default(bool);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array = default(byte[]);
		long num13 = default(long);
		long num12 = default(long);
		uint num11 = default(uint);
		int num17 = default(int);
		long num8 = default(long);
		int num7 = default(int);
		long num10 = default(long);
		byte[] array2 = default(byte[]);
		uint num14 = default(uint);
		uint num20 = default(uint);
		uint num19 = default(uint);
		uint num16 = default(uint);
		uint num18 = default(uint);
		long num6 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 18:
				H27vUYXfIYp2fjTQInOr(true);
				num2 = 16;
				break;
			case 3:
				return;
			case 5:
				return;
			case 19:
				hashAlgorithm = null;
				num2 = 2;
				if (pQsN8QXfMRPALN3eFUbY())
				{
					num2 = 20;
				}
				break;
			case 20:
				text2 = null;
				num2 = 24;
				break;
			case 24:
				try
				{
					hashAlgorithm = (HashAlgorithm)F6LKNKXfTCqntl3syIiN();
					int num29 = 0;
					if (Kivn3tXfOvCEldvu2dkT() == null)
					{
						num29 = 2;
					}
					while (true)
					{
						switch (num29)
						{
						case 2:
							text2 = (string)mYEfYDXfyZ1i8WaXb7oo("SHA1");
							num29 = 4;
							continue;
						case 3:
							return;
						case 0:
							break;
						case 4:
							if (!xBSS1NXfZgO5SjAwT7dv(text))
							{
								return;
							}
							num29 = 0;
							if (Kivn3tXfOvCEldvu2dkT() != null)
							{
								num29 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch
				{
					int num30 = 0;
					if (!pQsN8QXfMRPALN3eFUbY())
					{
						num30 = 0;
					}
					switch (num30)
					{
					case 0:
						break;
					}
					return;
				}
				goto case 2;
			case 2:
				flag = false;
				num2 = 10;
				break;
			case 23:
				sJuKCCXfqiqJ3UVRqMqv();
				num2 = 18;
				break;
			case 13:
				if (RyDsJ0ddOeh != null)
				{
					num2 = 12;
					break;
				}
				goto case 23;
			case 6:
			case 17:
				if (!flag)
				{
					num2 = 11;
					if (!pQsN8QXfMRPALN3eFUbY())
					{
						num2 = 2;
					}
					break;
				}
				goto case 7;
			default:
				if (text == null)
				{
					num2 = 3;
					break;
				}
				goto case 22;
			case 7:
				throw new Exception((string)a1rhtqX9b54hVtGcmtpO(wM9P81X9D8CtQ70dv8i0(DNeqxpX94vaA8ueuujQp(p9dHfZXfWBhA79X5MFl8(typeof(OQNZEtsP93U56NxbHlup).TypeHandle).Assembly)), " is tampered."));
			case 11:
				flag = false;
				num2 = 9;
				break;
			case 22:
				if (DmZ3vwXfUrxQs1NQFris(text) == 0)
				{
					return;
				}
				num2 = 19;
				if (!pQsN8QXfMRPALN3eFUbY())
				{
					num2 = 6;
				}
				break;
			case 16:
				RyDsJ0ddOeh = new RSACryptoServiceProvider();
				num2 = 15;
				break;
			case 10:
				try
				{
					esTXBjsJrjJbaHqQrcuh esTXBjsJrjJbaHqQrcuh = new esTXBjsJrjJbaHqQrcuh((Stream)N3gNEKXfV8ujyW0xR1qX(fhUsP3WKQnO, "1BEP8csA8YWgOB1Ud1WH.yVW466sAA1XopXHm0DUO"));
					nZ2usrXfruyW3nHbKDlK(B1X8hWXfCZ04tjMyS0qJ(esTXBjsJrjJbaHqQrcuh), 0L);
					byte[] array3 = (byte[])npy3WlXfme7C9Jr6R3Va(esTXBjsJrjJbaHqQrcuh, (int)a0LE0kXfKAdfY3pE1Dtu(B1X8hWXfCZ04tjMyS0qJ(esTXBjsJrjJbaHqQrcuh)));
					byte[] array4 = new byte[32];
					array4[0] = 142;
					int num24 = 231 - 77;
					array4[0] = (byte)num24;
					array4[0] = 157;
					int num25 = 11 + 37;
					array4[0] = (byte)num25;
					array4[0] = 124;
					array4[0] = 34;
					array4[1] = 111;
					num24 = 195 - 65;
					array4[1] = (byte)num24;
					num24 = 125 - 41;
					array4[1] = (byte)num24;
					num25 = 79 + 56;
					array4[1] = (byte)num25;
					num25 = 234 - 78;
					array4[1] = (byte)num25;
					array4[1] = 179;
					num25 = 207 - 69;
					array4[2] = (byte)num25;
					num24 = 119 + 73;
					array4[2] = (byte)num24;
					array4[2] = 161;
					num25 = 202 - 67;
					array4[2] = (byte)num25;
					num25 = 156 - 46;
					array4[2] = (byte)num25;
					num25 = 116 + 19;
					array4[3] = (byte)num25;
					array4[3] = 100;
					num24 = 32 + 39;
					array4[3] = (byte)num24;
					array4[3] = 120;
					array4[3] = 142;
					num24 = 78 + 83;
					array4[4] = (byte)num24;
					num24 = 186 - 62;
					array4[4] = (byte)num24;
					num24 = 33 + 107;
					array4[4] = (byte)num24;
					num25 = 211 - 123;
					array4[4] = (byte)num25;
					array4[5] = 99;
					array4[5] = 194;
					array4[5] = 58;
					array4[5] = 127;
					num25 = 68 + 91;
					array4[6] = (byte)num25;
					array4[6] = 111;
					num25 = 172 - 57;
					array4[6] = (byte)num25;
					num24 = 106 - 80;
					array4[6] = (byte)num24;
					num24 = 148 - 49;
					array4[7] = (byte)num24;
					array4[7] = 110;
					num25 = 52 - 41;
					array4[7] = (byte)num25;
					array4[8] = 142;
					array4[8] = 148;
					array4[8] = 130;
					array4[8] = 231;
					array4[9] = 97;
					num24 = 5 + 102;
					array4[9] = (byte)num24;
					array4[9] = 87;
					array4[9] = 102;
					num24 = 208 - 69;
					array4[9] = (byte)num24;
					array4[9] = 165;
					num24 = 171 - 57;
					array4[10] = (byte)num24;
					num25 = 217 - 72;
					array4[10] = (byte)num25;
					array4[10] = 144;
					num25 = 113 - 2;
					array4[10] = (byte)num25;
					num24 = 49 + 98;
					array4[11] = (byte)num24;
					num25 = 190 - 63;
					array4[11] = (byte)num25;
					array4[11] = 126;
					array4[11] = 94;
					array4[11] = 139;
					num25 = 75 - 57;
					array4[11] = (byte)num25;
					num25 = 189 - 63;
					array4[12] = (byte)num25;
					num24 = 121 + 96;
					array4[12] = (byte)num24;
					array4[12] = 12;
					array4[13] = 160;
					num24 = 217 - 72;
					array4[13] = (byte)num24;
					array4[13] = 70;
					num24 = 5 + 67;
					array4[13] = (byte)num24;
					num24 = 172 - 57;
					array4[13] = (byte)num24;
					num24 = 129 - 48;
					array4[13] = (byte)num24;
					num24 = 235 - 78;
					array4[14] = (byte)num24;
					num25 = 126 - 42;
					array4[14] = (byte)num25;
					array4[14] = 147;
					num24 = 135 - 45;
					array4[14] = (byte)num24;
					num24 = 80 + 4;
					array4[15] = (byte)num24;
					num25 = 27 + 63;
					array4[15] = (byte)num25;
					array4[15] = 114;
					num25 = 84 + 96;
					array4[15] = (byte)num25;
					array4[15] = 133;
					num24 = 104 + 109;
					array4[16] = (byte)num24;
					num25 = 228 - 76;
					array4[16] = (byte)num25;
					array4[16] = 152;
					num25 = 159 + 33;
					array4[16] = (byte)num25;
					num25 = 143 - 47;
					array4[17] = (byte)num25;
					num25 = 140 - 46;
					array4[17] = (byte)num25;
					num24 = 105 + 11;
					array4[17] = (byte)num24;
					num24 = 156 - 90;
					array4[17] = (byte)num24;
					array4[18] = 122;
					array4[18] = 135;
					num25 = 130 - 48;
					array4[18] = (byte)num25;
					array4[19] = 98;
					num25 = 44 + 38;
					array4[19] = (byte)num25;
					num24 = 195 - 102;
					array4[19] = (byte)num24;
					array4[20] = 120;
					num25 = 239 - 79;
					array4[20] = (byte)num25;
					array4[20] = 132;
					num24 = 47 + 14;
					array4[20] = (byte)num24;
					array4[20] = 46;
					array4[21] = 114;
					num24 = 54 + 115;
					array4[21] = (byte)num24;
					num24 = 13 + 25;
					array4[21] = (byte)num24;
					num24 = 246 - 82;
					array4[21] = (byte)num24;
					num24 = 91 + 61;
					array4[21] = (byte)num24;
					array4[22] = 132;
					array4[22] = 106;
					num25 = 187 - 62;
					array4[22] = (byte)num25;
					array4[22] = 112;
					array4[22] = 72;
					array4[22] = 154;
					num24 = 40 + 53;
					array4[23] = (byte)num24;
					num24 = 70 + 108;
					array4[23] = (byte)num24;
					array4[23] = 101;
					array4[23] = 32;
					num25 = 17 + 118;
					array4[23] = (byte)num25;
					num24 = 52 - 42;
					array4[23] = (byte)num24;
					array4[24] = 136;
					num24 = 17 + 52;
					array4[24] = (byte)num24;
					num24 = 227 - 75;
					array4[24] = (byte)num24;
					array4[24] = 138;
					num25 = 179 + 12;
					array4[24] = (byte)num25;
					array4[25] = 94;
					num25 = 144 - 48;
					array4[25] = (byte)num25;
					array4[25] = 100;
					array4[25] = 76;
					array4[25] = 88;
					num24 = 136 + 69;
					array4[25] = (byte)num24;
					array4[26] = 166;
					num24 = 164 - 54;
					array4[26] = (byte)num24;
					array4[26] = 174;
					num25 = 82 + 103;
					array4[27] = (byte)num25;
					array4[27] = 121;
					num24 = 14 + 60;
					array4[27] = (byte)num24;
					num24 = 210 - 70;
					array4[27] = (byte)num24;
					array4[27] = 159;
					num24 = 79 + 10;
					array4[28] = (byte)num24;
					num24 = 187 - 62;
					array4[28] = (byte)num24;
					num24 = 206 - 68;
					array4[28] = (byte)num24;
					array4[28] = 88;
					array4[28] = 33;
					num25 = 152 - 50;
					array4[29] = (byte)num25;
					array4[29] = 153;
					array4[29] = 72;
					num24 = 114 + 31;
					array4[29] = (byte)num24;
					array4[29] = 49;
					array4[29] = 165;
					num24 = 160 - 53;
					array4[30] = (byte)num24;
					num25 = 60 + 29;
					array4[30] = (byte)num25;
					array4[30] = 137;
					array4[30] = 134;
					array4[30] = 49;
					num25 = 233 - 77;
					array4[31] = (byte)num25;
					num24 = 245 - 81;
					array4[31] = (byte)num24;
					array4[31] = 141;
					byte[] array5 = array4;
					byte[] array6 = new byte[16];
					int num26 = 153 - 51;
					array6[0] = (byte)num26;
					array6[0] = 109;
					num26 = 225 - 75;
					array6[0] = (byte)num26;
					array6[0] = 119;
					num26 = 230 - 76;
					array6[0] = (byte)num26;
					array6[0] = 59;
					num26 = 73 + 105;
					array6[1] = (byte)num26;
					array6[1] = 132;
					array6[1] = 190;
					num26 = 216 - 72;
					array6[2] = (byte)num26;
					array6[2] = 91;
					array6[2] = 109;
					num26 = 196 - 65;
					array6[2] = (byte)num26;
					num26 = 43 + 118;
					array6[2] = (byte)num26;
					array6[3] = 92;
					num26 = 242 - 80;
					array6[3] = (byte)num26;
					num26 = 204 - 68;
					array6[3] = (byte)num26;
					array6[3] = 99;
					num26 = 94 - 23;
					array6[3] = (byte)num26;
					array6[4] = 62;
					num26 = 16 + 37;
					array6[4] = (byte)num26;
					num26 = 140 - 46;
					array6[4] = (byte)num26;
					array6[4] = 42;
					array6[4] = 166;
					num26 = 161 - 54;
					array6[4] = (byte)num26;
					num26 = 202 - 67;
					array6[5] = (byte)num26;
					array6[5] = 112;
					num26 = 237 - 79;
					array6[5] = (byte)num26;
					array6[5] = 165;
					num26 = 195 - 65;
					array6[5] = (byte)num26;
					array6[5] = 164;
					num26 = 228 - 76;
					array6[6] = (byte)num26;
					array6[6] = 152;
					array6[6] = 84;
					num26 = 11 + 40;
					array6[6] = (byte)num26;
					num26 = 90 - 74;
					array6[6] = (byte)num26;
					num26 = 138 - 46;
					array6[7] = (byte)num26;
					num26 = 221 - 73;
					array6[7] = (byte)num26;
					num26 = 246 - 82;
					array6[7] = (byte)num26;
					num26 = 33 + 43;
					array6[7] = (byte)num26;
					num26 = 166 - 55;
					array6[7] = (byte)num26;
					num26 = 177 + 5;
					array6[7] = (byte)num26;
					num26 = 96 + 98;
					array6[8] = (byte)num26;
					array6[8] = 117;
					array6[8] = 100;
					array6[9] = 180;
					array6[9] = 110;
					array6[9] = 144;
					array6[9] = 176;
					array6[9] = 173;
					array6[10] = 117;
					num26 = 164 - 54;
					array6[10] = (byte)num26;
					array6[10] = 173;
					num26 = 162 - 101;
					array6[10] = (byte)num26;
					array6[11] = 102;
					array6[11] = 85;
					num26 = 164 - 54;
					array6[11] = (byte)num26;
					num26 = 172 + 37;
					array6[11] = (byte)num26;
					num26 = 79 + 123;
					array6[12] = (byte)num26;
					num26 = 169 - 56;
					array6[12] = (byte)num26;
					num26 = 92 + 100;
					array6[12] = (byte)num26;
					num26 = 100 + 103;
					array6[12] = (byte)num26;
					num26 = 164 - 54;
					array6[13] = (byte)num26;
					array6[13] = 103;
					num26 = 163 + 66;
					array6[13] = (byte)num26;
					array6[14] = 94;
					array6[14] = 119;
					array6[14] = 188;
					num26 = 114 + 111;
					array6[14] = (byte)num26;
					array6[14] = 140;
					num26 = 42 + 87;
					array6[14] = (byte)num26;
					array6[15] = 110;
					num26 = 244 - 81;
					array6[15] = (byte)num26;
					array6[15] = 100;
					num26 = 129 - 70;
					array6[15] = (byte)num26;
					byte[] array7 = array6;
					object obj3 = pa1tgcXfhsLZhl8IyAWC();
					Tkj4dtXfw00LOCcjdO4v(obj3, CipherMode.CBC);
					ICryptoTransform transform = (ICryptoTransform)GPtfxAXf7COgR7H23LAn(obj3, array5, array7);
					Stream stream = (Stream)bgnQJcXf8u9SqKKJxfvb();
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					qYZYx5XfAdv7XS7LduYP(cryptoStream, array3, 0, array3.Length);
					MDyOIpXfPiJ79Eg1ikhy(cryptoStream);
					EVn1bQXfpg07Pgt9DA8D(RyDsJ0ddOeh, O43ysBXf3cO0nFbAeIIb(CobqZXXfJwfRi2W6uqxQ(), xNR7lDXfFXesy9s3neoc(stream)));
					bHTgUPXfuhLDxCbmQyaT(stream);
					bHTgUPXfuhLDxCbmQyaT(cryptoStream);
					osDhdrXfzXYcZJ7AjPB5(esTXBjsJrjJbaHqQrcuh);
					int num27 = 0;
					if (Kivn3tXfOvCEldvu2dkT() != null)
					{
						num27 = 0;
					}
					switch (num27)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num28 = 1;
					if (!pQsN8QXfMRPALN3eFUbY())
					{
						num28 = 1;
					}
					while (true)
					{
						switch (num28)
						{
						case 1:
							flag = true;
							num28 = 0;
							if (Kivn3tXfOvCEldvu2dkT() == null)
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
				goto case 1;
			case 12:
				return;
			case 9:
				return;
			case 1:
				if (flag)
				{
					num2 = 17;
					break;
				}
				goto case 21;
			case 4:
				try
				{
					if (binaryReader != null)
					{
						int num22 = 1;
						if (Kivn3tXfOvCEldvu2dkT() != null)
						{
							num22 = 1;
						}
						while (true)
						{
							switch (num22)
							{
							case 1:
								h2OSonX9lfjtRXpNla8e(binaryReader);
								num22 = 0;
								if (Kivn3tXfOvCEldvu2dkT() == null)
								{
									num22 = 0;
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
					int num23 = 0;
					if (Kivn3tXfOvCEldvu2dkT() == null)
					{
						num23 = 0;
					}
					switch (num23)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 14:
				try
				{
					FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
					int num3 = 25;
					while (true)
					{
						int num9;
						switch (num3)
						{
						case 22:
							nZ2usrXfruyW3nHbKDlK(fileStream, 360L);
							num3 = 2;
							continue;
						case 17:
							xCg76WX90Y0GbOB1kWbr(hashAlgorithm, fileStream, 152u, array);
							num3 = 33;
							if (Kivn3tXfOvCEldvu2dkT() != null)
							{
								num3 = 9;
							}
							continue;
						case 26:
						case 29:
							nZ2usrXfruyW3nHbKDlK(fileStream, 376L);
							num3 = 37;
							continue;
						case 3:
							if (num13 >= num12)
							{
								num3 = 24;
								continue;
							}
							goto case 23;
						case 21:
							num11 = (uint)(num12 - num13);
							num3 = 5;
							if (!pQsN8QXfMRPALN3eFUbY())
							{
								num3 = 5;
							}
							continue;
						case 32:
							num17 = 0;
							num3 = 2;
							if (Kivn3tXfOvCEldvu2dkT() == null)
							{
								num3 = 9;
							}
							continue;
						case 4:
							nZ2usrXfruyW3nHbKDlK(fileStream, num8);
							num3 = 32;
							if (Kivn3tXfOvCEldvu2dkT() != null)
							{
								num3 = 27;
							}
							continue;
						case 6:
						case 9:
							if (num17 >= num7)
							{
								num3 = 22;
								if (Kivn3tXfOvCEldvu2dkT() == null)
								{
									num3 = 27;
								}
								continue;
							}
							goto case 20;
						case 28:
							nZ2usrXfruyW3nHbKDlK(fileStream, num10);
							num3 = 0;
							if (Kivn3tXfOvCEldvu2dkT() != null)
							{
								num3 = 0;
							}
							continue;
						case 34:
							flag = !rRZPOaX9ipn1tZE1lXPj(RyDsJ0ddOeh, JyxEmVX9ah3majE9Qd9c(hashAlgorithm), text2, array2);
							num9 = 10;
							goto IL_1b1f;
						case 31:
							num13 = a7G1pwX99rT42NCnhwdA(fileStream);
							num3 = 15;
							continue;
						case 1:
						case 8:
						case 41:
							num17++;
							num3 = 6;
							continue;
						case 43:
							num14 = Q2SONFX9nHByVo28h7Gg(binaryReader);
							num3 = 5;
							if (Kivn3tXfOvCEldvu2dkT() == null)
							{
								num3 = 7;
							}
							continue;
						case 15:
							if (num10 <= num13)
							{
								num3 = 39;
								if (!pQsN8QXfMRPALN3eFUbY())
								{
									num3 = 34;
								}
								continue;
							}
							goto case 3;
						case 7:
							num20 = Q2SONFX9nHByVo28h7Gg(binaryReader);
							num3 = 16;
							continue;
						case 40:
							xCg76WX90Y0GbOB1kWbr(hashAlgorithm, fileStream, num19, array);
							num3 = 19;
							continue;
						case 18:
							num12 = num10 + num16;
							num3 = 4;
							continue;
						case 25:
							binaryReader = new BinaryReader(fileStream);
							num3 = 14;
							continue;
						case 5:
							if (num11 >= num14)
							{
								num3 = 0;
								if (Kivn3tXfOvCEldvu2dkT() == null)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 38;
						case 42:
							nZ2usrXfruyW3nHbKDlK(fileStream, num18 + 32);
							num3 = 2;
							if (Kivn3tXfOvCEldvu2dkT() == null)
							{
								num3 = 11;
							}
							continue;
						case 13:
							nZ2usrXfruyW3nHbKDlK(fileStream, a7G1pwX99rT42NCnhwdA(fileStream) + num11);
							num3 = 12;
							continue;
						case 16:
							nZ2usrXfruyW3nHbKDlK(fileStream, num20);
							num3 = 36;
							continue;
						case 19:
							num14 -= num19;
							num3 = 30;
							continue;
						default:
							array2 = (byte[])E3NTqoX9vaVZd6NZv0jn(binaryReader, (int)num16);
							num9 = 35;
							goto IL_1b1f;
						case 39:
							if (num13 < num12)
							{
								num3 = 21;
								continue;
							}
							goto case 3;
						case 27:
							AJ4xhRX9owkEqhGAqJEk(hashAlgorithm, new byte[0], 0, 0);
							num3 = 28;
							continue;
						case 35:
							M0s9CAX9Bd4yla6Ga74x(array2);
							num3 = 34;
							if (!pQsN8QXfMRPALN3eFUbY())
							{
								num3 = 11;
							}
							continue;
						case 2:
						case 37:
							num18 = NMftXJX9GroHCGGeqjey(Q2SONFX9nHByVo28h7Gg(binaryReader), num7, num6, binaryReader);
							num3 = 42;
							continue;
						case 20:
							nZ2usrXfruyW3nHbKDlK(fileStream, num6 + num17 * 40 + 16);
							num3 = 43;
							if (!pQsN8QXfMRPALN3eFUbY())
							{
								num3 = 25;
							}
							continue;
						case 12:
						case 30:
						case 36:
							if (num14 == 0)
							{
								num3 = 8;
								continue;
							}
							goto case 31;
						case 38:
							num14 -= num11;
							num3 = 13;
							continue;
						case 14:
							array = new byte[65536];
							num3 = 17;
							continue;
						case 11:
						{
							uint num15 = Q2SONFX9nHByVo28h7Gg(binaryReader);
							num16 = Q2SONFX9nHByVo28h7Gg(binaryReader);
							num10 = NMftXJX9GroHCGGeqjey(num15, num7, num6, binaryReader);
							num3 = 18;
							continue;
						}
						case 24:
							xCg76WX90Y0GbOB1kWbr(hashAlgorithm, fileStream, num14, array);
							num9 = 41;
							goto IL_1b1f;
						case 23:
							num19 = (uint)umeLH0X9YVQmYYrC3K5I(num10 - num13, num14);
							num3 = 40;
							continue;
						case 33:
						{
							bool num4 = KbwMIIX92NLjhNWMN093(binaryReader) != 523;
							int num5 = (num4 ? 96 : 112);
							nZ2usrXfruyW3nHbKDlK(fileStream, 152L);
							H1Ifl1X9HDnmYAQFl7Nv(fileStream, array, 0, num5);
							array[64] = 0;
							array[65] = 0;
							array[66] = 0;
							array[67] = 0;
							xCJrmCX9f2ikaX4wjdYD(hashAlgorithm, array, 0, num5);
							H1Ifl1X9HDnmYAQFl7Nv(fileStream, array, 0, 128);
							array[32] = 0;
							array[33] = 0;
							array[34] = 0;
							array[35] = 0;
							array[36] = 0;
							array[37] = 0;
							array[38] = 0;
							array[39] = 0;
							xCJrmCX9f2ikaX4wjdYD(hashAlgorithm, array, 0, 128);
							num6 = a7G1pwX99rT42NCnhwdA(fileStream);
							nZ2usrXfruyW3nHbKDlK(fileStream, 134L);
							num7 = KbwMIIX92NLjhNWMN093(binaryReader);
							nZ2usrXfruyW3nHbKDlK(fileStream, num6);
							xCg76WX90Y0GbOB1kWbr(hashAlgorithm, fileStream, (uint)(num7 * 40), array);
							num8 = a7G1pwX99rT42NCnhwdA(fileStream);
							if (!num4)
							{
								num3 = 29;
								continue;
							}
							goto case 22;
						}
						case 10:
							break;
							IL_1b1f:
							num3 = num9;
							continue;
						}
						break;
					}
				}
				catch
				{
					int num21 = 0;
					if (Kivn3tXfOvCEldvu2dkT() == null)
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
							if (pQsN8QXfMRPALN3eFUbY())
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
				goto case 8;
			case 21:
				binaryReader = null;
				num2 = 14;
				break;
			case 8:
				num2 = 0;
				if (pQsN8QXfMRPALN3eFUbY())
				{
					num2 = 4;
				}
				break;
			case 15:
				text = (string)BiXKf1XftukCSKIgueM7(p9dHfZXfWBhA79X5MFl8(typeof(OQNZEtsP93U56NxbHlup).TypeHandle).Assembly);
				num2 = 0;
				if (Kivn3tXfOvCEldvu2dkT() != null)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Bs7sPSvY56E(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (mC5sJ2HoFGA == null)
			{
				lock (psbsJHhZLQk)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554495)).Assembly.GetManifestResourceStream("9dMf3PsApESDg3l3flyb.n10aIEsAuLkAje43EZjX"));
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
							num3 += MZmsPeivQbd(num3);
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
						esTXBjsJrjJbaHqQrcuh esTXBjsJrjJbaHqQrcuh = new esTXBjsJrjJbaHqQrcuh(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = esTXBjsJrjJbaHqQrcuh.CVfsJhfIcUa();
							int value = esTXBjsJrjJbaHqQrcuh.CVfsJhfIcUa();
							dictionary.Add(key, value);
						}
						esTXBjsJrjJbaHqQrcuh.NQ7sJwYVQqv();
					}
					mC5sJ2HoFGA = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = mC5sJ2HoFGA[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554495)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
						array3[0] = Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236));
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

	private static uint CNmsPLaBQ0d(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint MZmsPeivQbd(uint P_0)
	{
		return 0u;
	}

	internal static void LpusPsrSCpn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void uw4sPXN0SJG(Stream P_0, int P_1)
	{
		Yl66IasFjUf1jxOHWjFy.eUusFRYSd8W(0, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string BeJsPcmdLda(int P_0)
	{
		if (jEOsJYHH2Wf.Length == 0)
		{
			JfbsJnHKUWx = new List<string>();
			JrNsJGpG0P0 = new List<int>();
			uw4sPXN0SJG(fhUsP3WKQnO.GetManifestResourceStream("IU612msAmLEMfps60QLw.Gq2cgJsAhHhq2Uulf85u"), P_0);
		}
		if (mlJsJfmJlhO < 75)
		{
			if (fhUsP3WKQnO != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			mlJsJfmJlhO++;
		}
		lock (dnHsJ9oV3il)
		{
			int num = BitConverter.ToInt32(jEOsJYHH2Wf, P_0);
			if (num < JrNsJGpG0P0.Count && JrNsJGpG0P0[num] == P_0)
			{
				return JfbsJnHKUWx[num];
			}
			try
			{
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				byte[] array = new byte[num];
				Array.Copy(jEOsJYHH2Wf, P_0 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				JfbsJnHKUWx.Add(text);
				JrNsJGpG0P0.Add(P_0);
				Array.Copy(BitConverter.GetBytes(JfbsJnHKUWx.Count - 1), 0, jEOsJYHH2Wf, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string eA9sPjbE25H(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int sD5sPEGY7Ql()
	{
		return 5;
	}

	private static void uBCsPQZphvO()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate mPKsPdMmHaS(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777437)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777258)),
			Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777281))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object IiysPgg60YR(object P_0)
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
	public static extern IntPtr wjfsPRsBfSd(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr DEnsP6gZNZy(IntPtr P_0, string P_1);

	private static IntPtr bOZsPMaOMeC(IntPtr P_0, string P_1, uint P_2)
	{
		if (MoZsJjQJlur == null)
		{
			MoZsJjQJlur = (DFik8gsJ8IP2E0jWmOn0)Marshal.GetDelegateForFunctionPointer(DEnsP6gZNZy(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554504)));
		}
		return MoZsJjQJlur(P_0, P_1, P_2);
	}

	private static IntPtr EALsPOlZubb(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (m6osJEfBjDm == null)
		{
			m6osJEfBjDm = (DDIMrWsJAXHnjkRPgJFY)Marshal.GetDelegateForFunctionPointer(DEnsP6gZNZy(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554505)));
		}
		return m6osJEfBjDm(P_0, P_1, P_2, P_3);
	}

	private static int JIQsPqbS8O5(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (gQxsJQ1Cxit == null)
		{
			gQxsJQ1Cxit = (jUsiC6sJPvS3BsfNSQHI)Marshal.GetDelegateForFunctionPointer(DEnsP6gZNZy(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554506)));
		}
		return gQxsJQ1Cxit(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int MKwsPIJ9an0(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (NcCsJdKJHV6 == null)
		{
			NcCsJdKJHV6 = (Qv0GCJsJJ4vgk4DGkt1E)Marshal.GetDelegateForFunctionPointer(DEnsP6gZNZy(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554507)));
		}
		return NcCsJdKJHV6(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr Y9HsPWR1cXe(uint P_0, int P_1, uint P_2)
	{
		if (qVFsJg8AgO7 == null)
		{
			qVFsJg8AgO7 = (WsdKCRsJFbhy7xQPDlxO)Marshal.GetDelegateForFunctionPointer(DEnsP6gZNZy(pZbnhv6YB(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554508)));
		}
		return qVFsJg8AgO7(P_0, P_1, P_2);
	}

	private static int JuBsPtMdd88(IntPtr P_0)
	{
		if (Cd9sJRDKxxs == null)
		{
			Cd9sJRDKxxs = (Bpn8WHsJ30lpl6S2XwuL)Marshal.GetDelegateForFunctionPointer(DEnsP6gZNZy(pZbnhv6YB(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554509)));
		}
		return Cd9sJRDKxxs(P_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (Q9BsJ6XtC5q == IntPtr.Zero)
		{
			Q9BsJ6XtC5q = wjfsPRsBfSd("kernel ".Trim() + "32.dll");
		}
		return Q9BsJ6XtC5q;
	}

	private static byte[] bfksPUXCm3u(string P_0)
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

	internal static Stream lMWsPTNjFDu()
	{
		return new MemoryStream();
	}

	internal static byte[] yIQsPyFv2Mv(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] RxNsPZCVrf4(byte[] P_0)
	{
		Stream stream = lMWsPTNjFDu();
		SymmetricAlgorithm symmetricAlgorithm = JYQsP4jByQW();
		symmetricAlgorithm.Key = new byte[32]
		{
			75, 242, 94, 192, 72, 128, 145, 112, 64, 205,
			223, 248, 128, 107, 211, 141, 132, 130, 149, 111,
			245, 211, 45, 28, 30, 114, 246, 103, 187, 151,
			102, 108
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			36, 144, 197, 161, 166, 7, 187, 116, 67, 53,
			147, 72, 26, 213, 208, 217
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = yIQsPyFv2Mv(stream);
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		return result;
	}

	private unsafe static int SxIsPVORxYv(string P_0)
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

	internal static bool FmlsPC2gEch(string P_0, string P_1)
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
		if (P_0.StartsWith(DiasJMhJf2p))
		{
			flag = true;
			num = (int)(P_0[4] | ((uint)P_0[5] << 8) | ((uint)P_0[6] << 16) | ((uint)P_0[7] << 24));
		}
		if (P_1.StartsWith(DiasJMhJf2p))
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
			num = SxIsPVORxYv(P_0);
		}
		if (!flag2)
		{
			num2 = SxIsPVORxYv(P_1);
		}
		return num == num2;
	}

	private byte[] gjesPrKOrYO()
	{
		return null;
	}

	private byte[] t4gsPK6vlvd()
	{
		return null;
	}

	private byte[] FausPmM6x2G()
	{
		return null;
	}

	private byte[] JlEsPhPC2ij()
	{
		return null;
	}

	private byte[] CP7sPwChvWi()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] DwEsP7CVFyU()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] XqIsP8CHTju()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] lNnsPAZvaqx()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] yIksPPW8Zbm()
	{
		return null;
	}

	internal byte[] nHisPJXdiuk()
	{
		return null;
	}

	internal static object To3j8yXfNZKHgcyeTTCW(object P_0)
	{
		return ((esTXBjsJrjJbaHqQrcuh)P_0).m9OIO8Q0EK();
	}

	internal static void nSI6nRXfkNxRJgmDiZ8C(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long NlAiTgXf1kPEoEOnXaXO(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object mER9BfXf56bmQKLrhHx2(object P_0, int P_1)
	{
		return ((esTXBjsJrjJbaHqQrcuh)P_0).VtvsJKVst6l(P_1);
	}

	internal static void iHuNFaXfSR8IkwRE7L2C(object P_0)
	{
		((esTXBjsJrjJbaHqQrcuh)P_0).NQ7sJwYVQqv();
	}

	internal static void pe2SslXfxVbukE24KGXU(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object SfUoXpXfLZ9Y7nI36UOs(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object DklNXHXfedqeeow1e0od(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object doESJRXfs74dM4VtA1LJ()
	{
		return JYQsP4jByQW();
	}

	internal static void d01HdZXfXElVTfbHhY11(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object dwqdv9XfcCXgNXnaXAYQ(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object isgw1UXfj6L2VbgAMMSv()
	{
		return lMWsPTNjFDu();
	}

	internal static void Hi0dZ2XfElWPc2VoJNtn(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void xp6tlMXfQXoRj98DydHm(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object JUfmgcXfdGkThVPQpURM(object P_0)
	{
		return yIQsPyFv2Mv((Stream)P_0);
	}

	internal static void L2I4ypXfg0b6wihA5N71(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object pJrb3jXfRXaRGUoXasT1(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool LXL6FdXf6WY2ElKFKS83(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool EoArPCXfD9eAReU65URC()
	{
		return (object)null == null;
	}

	internal static object H30r0sXfbyumKHy4N5gx()
	{
		return null;
	}

	internal static void sJuKCCXfqiqJ3UVRqMqv()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static void H27vUYXfIYp2fjTQInOr(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type p9dHfZXfWBhA79X5MFl8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object BiXKf1XftukCSKIgueM7(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int DmZ3vwXfUrxQs1NQFris(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object F6LKNKXfTCqntl3syIiN()
	{
		return SHA1.Create();
	}

	internal static object mYEfYDXfyZ1i8WaXb7oo(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool xBSS1NXfZgO5SjAwT7dv(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object N3gNEKXfV8ujyW0xR1qX(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object B1X8hWXfCZ04tjMyS0qJ(object P_0)
	{
		return ((esTXBjsJrjJbaHqQrcuh)P_0).m9OIO8Q0EK();
	}

	internal static void nZ2usrXfruyW3nHbKDlK(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long a0LE0kXfKAdfY3pE1Dtu(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object npy3WlXfme7C9Jr6R3Va(object P_0, int P_1)
	{
		return ((esTXBjsJrjJbaHqQrcuh)P_0).VtvsJKVst6l(P_1);
	}

	internal static object pa1tgcXfhsLZhl8IyAWC()
	{
		return JYQsP4jByQW();
	}

	internal static void Tkj4dtXfw00LOCcjdO4v(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object GPtfxAXf7COgR7H23LAn(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object bgnQJcXf8u9SqKKJxfvb()
	{
		return lMWsPTNjFDu();
	}

	internal static void qYZYx5XfAdv7XS7LduYP(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void MDyOIpXfPiJ79Eg1ikhy(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object CobqZXXfJwfRi2W6uqxQ()
	{
		return Encoding.UTF8;
	}

	internal static object xNR7lDXfFXesy9s3neoc(object P_0)
	{
		return yIQsPyFv2Mv((Stream)P_0);
	}

	internal static object O43ysBXf3cO0nFbAeIIb(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void EVn1bQXfpg07Pgt9DA8D(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void bHTgUPXfuhLDxCbmQyaT(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void osDhdrXfzXYcZJ7AjPB5(object P_0)
	{
		((esTXBjsJrjJbaHqQrcuh)P_0).NQ7sJwYVQqv();
	}

	internal static void xCg76WX90Y0GbOB1kWbr(object P_0, object P_1, uint P_2, object P_3)
	{
		bVwsPNjDBgE((HashAlgorithm)P_0, (Stream)P_1, P_2, (byte[])P_3);
	}

	internal static ushort KbwMIIX92NLjhNWMN093(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int H1Ifl1X9HDnmYAQFl7Nv(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void xCJrmCX9f2ikaX4wjdYD(object P_0, object P_1, int P_2, int P_3)
	{
		vi3sPkVnXk0((HashAlgorithm)P_0, (byte[])P_1, P_2, P_3);
	}

	internal static long a7G1pwX99rT42NCnhwdA(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint Q2SONFX9nHByVo28h7Gg(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint NMftXJX9GroHCGGeqjey(uint P_0, int P_1, long P_2, object P_3)
	{
		return RaCsP1Kd7VC(P_0, P_1, P_2, (BinaryReader)P_3);
	}

	internal static long umeLH0X9YVQmYYrC3K5I(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object AJ4xhRX9owkEqhGAqJEk(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object E3NTqoX9vaVZd6NZv0jn(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void M0s9CAX9Bd4yla6Ga74x(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object JyxEmVX9ah3majE9Qd9c(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool rRZPOaX9ipn1tZE1lXPj(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void h2OSonX9lfjtRXpNla8e(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object DNeqxpX94vaA8ueuujQp(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object wM9P81X9D8CtQ70dv8i0(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object a1rhtqX9b54hVtGcmtpO(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool pQsN8QXfMRPALN3eFUbY()
	{
		return (object)null == null;
	}

	internal static object Kivn3tXfOvCEldvu2dkT()
	{
		return null;
	}
}
