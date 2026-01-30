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

namespace ActiproSoftware.Internal;

internal class vVK
{
	private delegate void wV5(object o);

	internal class aVr : Attribute
	{
		internal class RVL<nV1>
		{
			private static object xLA;

			public RVL()
			{
				IVH.CecNqz();
				base._002Ector();
			}

			internal static bool ILY()
			{
				return xLA == null;
			}

			internal static object lLC()
			{
				return xLA;
			}
		}

		[aVr(typeof(RVL<object>[]))]
		public aVr(object P_0)
		{
		}
	}

	internal class IVb
	{
		[aVr(typeof(aVr.RVL<object>[]))]
		internal static string Dqg(string P_0, string P_1)
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
			byte[] iV = bsP(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = esF();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint VVm(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr zV4();

	internal struct rVs
	{
		internal bool SqX;

		internal byte[] zq5;
	}

	internal class WVA
	{
		private BinaryReader oqz;

		public WVA(Stream P_0)
		{
			oqz = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return oqz.BaseStream;
		}

		internal byte[] mqy(int P_0)
		{
			return oqz.ReadBytes(P_0);
		}

		internal int Iqo(byte[] P_0, int P_1, int P_2)
		{
			return oqz.Read(P_0, P_1, P_2);
		}

		internal int vqt()
		{
			return oqz.ReadInt32();
		}

		internal void tqu()
		{
			oqz.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr dVf(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr aVQ(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int iV0(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int eV8(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr lVk(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int OVy(IntPtr ptr);

	[Flags]
	private enum WVh
	{

	}

	private static uint[] MqO;

	private static byte[] zqD;

	private static Dictionary<int, int> nqr;

	private static byte[] bqM;

	private static IntPtr uqv;

	private static int DqL;

	private static SortedList Kq6;

	private static int Pq9;

	internal static VVm bqs;

	private static long Iqq;

	private static eV8 wqA;

	private static lVk vqH;

	private static bool jqV;

	private static bool pqT;

	private static bool VqP;

	private static bool rqJ;

	private static IntPtr tq7;

	private static object wqx;

	private static iV0 Uqb;

	private static object wqR;

	private static IntPtr zqh;

	private static IntPtr qqU;

	private static byte[] iql;

	[aVr(typeof(aVr.RVL<object>[]))]
	private static bool pqc;

	internal static Hashtable iq4;

	private static long oqY;

	private static int Bqf;

	private static int[] zqS;

	internal static Assembly vqn;

	private static dVf Jqj;

	private static bool Qq3;

	internal static VVm qqp;

	private static bool jq8;

	private static OVy kq0;

	private static int eqF;

	internal static RSACryptoServiceProvider HqE;

	private static aVQ kqZ;

	static vVK()
	{
		rqJ = false;
		vqn = typeof(vVK).Assembly;
		MqO = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		pqT = false;
		jq8 = false;
		zqD = new byte[0];
		HqE = null;
		nqr = null;
		wqx = new object();
		iql = new byte[0];
		bqM = new byte[0];
		uqv = IntPtr.Zero;
		tq7 = IntPtr.Zero;
		wqR = new string[0];
		zqS = new int[0];
		DqL = 1;
		Qq3 = false;
		Kq6 = new SortedList();
		Pq9 = 0;
		oqY = 0L;
		qqp = null;
		bqs = null;
		Iqq = 0L;
		eqF = 0;
		jqV = false;
		VqP = false;
		Bqf = 0;
		qqU = IntPtr.Zero;
		pqc = false;
		iq4 = new Hashtable();
		Jqj = null;
		kqZ = null;
		Uqb = null;
		wqA = null;
		vqH = null;
		kq0 = null;
		zqh = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void LecNq7()
	{
	}

	internal static byte[] Xs3(byte[] P_0)
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
			Is6(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			Is6(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			Is6(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			Is6(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			Is6(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			Is6(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			Is6(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			Is6(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			Is6(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			Is6(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			Is6(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			Is6(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			Is6(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			Is6(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			Is6(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			Is6(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			Es9(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			Es9(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			Es9(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			Es9(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			Es9(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			Es9(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			Es9(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			Es9(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			Es9(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			Es9(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			Es9(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			Es9(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			Es9(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			Es9(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			Es9(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			Es9(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			asY(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			asY(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			asY(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			asY(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			asY(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			asY(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			asY(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			asY(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			asY(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			asY(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			asY(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			asY(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			asY(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			asY(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			asY(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			asY(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			vsp(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			vsp(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			vsp(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			vsp(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			vsp(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			vsp(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			vsp(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			vsp(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			vsp(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			vsp(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			vsp(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			vsp(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			vsp(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			vsp(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			vsp(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			vsp(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void Is6(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Jss(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + MqO[P_6 - 1], P_5);
	}

	private static void Es9(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Jss(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + MqO[P_6 - 1], P_5);
	}

	private static void asY(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Jss(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + MqO[P_6 - 1], P_5);
	}

	private static void vsp(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Jss(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + MqO[P_6 - 1], P_5);
	}

	private static uint Jss(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool ysq()
	{
		if (!pqT)
		{
			LsV();
			pqT = true;
		}
		return jq8;
	}

	internal static SymmetricAlgorithm esF()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (ysq())
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

	internal static void LsV()
	{
		try
		{
			jq8 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] bsP(byte[] P_0)
	{
		if (!ysq())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return Xs3(P_0);
	}

	internal static void Qsf(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			lsU(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void lsU(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint Nsc(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	public static void Ds4(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (nqr == null)
			{
				lock (wqx)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(vVK).Assembly.GetManifestResourceStream("Q859qIm63OT0RtH3OI.PqhJmyBTCEu46MGd8y"));
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
							num3 += Vsb(num3);
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
						WVA wVA = new WVA(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = wVA.vqt();
							int value = wVA.vqt();
							dictionary.Add(key, value);
						}
						wVA.tqu();
					}
					nqr = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = nqr[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(vVK).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint dsZ(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint Vsb(uint P_0)
	{
		return 0u;
	}

	internal static void HsA()
	{
	}

	[aVr(typeof(aVr.RVL<object>[]))]
	internal static string ssH(int P_0)
	{
		int num = 156;
		int num23 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num22 = default(int);
		uint num27 = default(uint);
		uint num28 = default(uint);
		uint num29 = default(uint);
		int num24 = default(int);
		int num32 = default(int);
		int num35 = default(int);
		int num37 = default(int);
		int num21 = default(int);
		byte[] array3 = default(byte[]);
		byte[] publicKeyToken = default(byte[]);
		byte[] array5 = default(byte[]);
		uint num39 = default(uint);
		CryptoStream cryptoStream = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		int num30 = default(int);
		uint num20 = default(uint);
		int count = default(int);
		uint num31 = default(uint);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		int num34 = default(int);
		int num26 = default(int);
		int num36 = default(int);
		uint num38 = default(uint);
		byte[] array6 = default(byte[]);
		int num40 = default(int);
		int num42 = default(int);
		string result = default(string);
		int num44 = default(int);
		uint num4 = default(uint);
		byte[] array4 = default(byte[]);
		int num25 = default(int);
		WVA wVA = default(WVA);
		int num33 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 117:
					num23 = 242 - 80;
					num = 53;
					break;
				case 214:
					array2[12] = 149;
					num2 = 178;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 245:
					array[13] = 86;
					num2 = 7;
					continue;
				case 184:
					array2[8] = 134;
					num2 = 296;
					if (eF())
					{
						continue;
					}
					break;
				case 332:
					num22 = 159 - 53;
					num2 = 278;
					continue;
				case 406:
					num27 = num28 ^ num29;
					num2 = 267;
					continue;
				case 201:
					num29 = 0u;
					num2 = 165;
					continue;
				case 178:
					num24 = 243 - 81;
					num2 = 138;
					continue;
				case 256:
					array2[24] = 115;
					num2 = 148;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 330:
					array[15] = 46;
					num2 = 39;
					continue;
				case 302:
					num32 = num35 % num37;
					num2 = 194;
					continue;
				case 223:
					array2[21] = (byte)num24;
					num2 = 279;
					continue;
				case 87:
					array[6] = 168;
					num2 = 412;
					if (eF())
					{
						continue;
					}
					break;
				case 202:
					num24 = 86 + 123;
					num2 = 127;
					continue;
				case 408:
					num21 = 201 - 67;
					num2 = 337;
					if (!eF())
					{
						num2 = 325;
					}
					continue;
				case 283:
					array2[0] = (byte)num23;
					num2 = 232;
					continue;
				case 71:
					num23 = 50 + 58;
					num2 = 283;
					continue;
				case 367:
					array3[1] = publicKeyToken[0];
					num2 = 204;
					if (eF())
					{
						continue;
					}
					break;
				case 373:
					num21 = 231 - 77;
					num2 = 298;
					continue;
				case 166:
					array2[13] = 141;
					num2 = 10;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 281:
					array[9] = 137;
					num2 = 389;
					if (eF())
					{
						continue;
					}
					break;
				case 312:
					array2[3] = (byte)num24;
					num2 = 7;
					if (eF())
					{
						num2 = 11;
					}
					continue;
				case 239:
					iql = array5;
					num2 = 104;
					if (eF())
					{
						continue;
					}
					break;
				case 196:
					array[8] = (byte)num22;
					num2 = 95;
					continue;
				case 322:
					array[6] = (byte)num21;
					num2 = 79;
					continue;
				case 296:
					num24 = 85 - 52;
					num2 = 361;
					continue;
				case 309:
					num23 = 103 - 71;
					num2 = 168;
					continue;
				case 213:
					num24 = 70 - 56;
					num2 = 291;
					continue;
				case 220:
					num39 <<= 8;
					num2 = 30;
					continue;
				case 44:
					array2[1] = 46;
					num2 = 112;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 16:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 326;
					continue;
				case 10:
					num24 = 142 - 47;
					num2 = 325;
					if (eF())
					{
						continue;
					}
					break;
				case 324:
					array2[22] = 107;
					num2 = 153;
					continue;
				case 35:
					array2[22] = (byte)num24;
					num2 = 324;
					if (eF())
					{
						continue;
					}
					break;
				case 368:
					array2[25] = 98;
					num2 = 117;
					continue;
				case 171:
					iql = aqG(stream);
					num2 = 15;
					if (eF())
					{
						num2 = 15;
					}
					continue;
				case 306:
					array2[10] = 118;
					num2 = 69;
					continue;
				case 208:
					array2[16] = (byte)num23;
					num2 = 132;
					continue;
				case 170:
					num23 = 114 - 38;
					num2 = 125;
					continue;
				case 77:
					num23 = 162 - 54;
					num = 78;
					break;
				case 188:
					if (P_0 == -1)
					{
						num2 = 48;
						continue;
					}
					goto case 58;
				case 61:
					array2[9] = 148;
					num2 = 139;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 376:
					array2[15] = 153;
					num = 246;
					break;
				case 303:
					array2[11] = (byte)num24;
					num2 = 348;
					if (eF())
					{
						continue;
					}
					break;
				case 358:
					array3[7] = publicKeyToken[3];
					num2 = 218;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 273:
					num24 = 90 + 124;
					num2 = 157;
					continue;
				case 337:
					array[4] = (byte)num21;
					num = 235;
					break;
				case 186:
					array[0] = (byte)num21;
					num2 = 254;
					continue;
				case 195:
					if (num30 > 0)
					{
						num2 = 27;
						continue;
					}
					goto case 390;
				case 290:
					array2[4] = (byte)num23;
					num2 = 270;
					continue;
				case 84:
					array[6] = 79;
					num2 = 12;
					continue;
				case 106:
					num22 = 177 - 59;
					num2 = 318;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 222:
					num24 = 100 + 49;
					num2 = 247;
					if (UR() != null)
					{
						num2 = 184;
					}
					continue;
				case 399:
					array[13] = 102;
					num2 = 120;
					continue;
				case 270:
					array2[4] = 199;
					num2 = 329;
					continue;
				case 351:
					array2[14] = 158;
					num = 164;
					break;
				case 122:
					num24 = 204 - 68;
					num2 = 221;
					if (eF())
					{
						continue;
					}
					break;
				case 279:
					num24 = 202 - 67;
					num2 = 280;
					continue;
				case 369:
					array[5] = 132;
					num2 = 136;
					continue;
				case 59:
					num20 = 0u;
					num2 = 201;
					if (eF())
					{
						continue;
					}
					break;
				case 81:
					return "";
				case 104:
				case 155:
					count = BitConverter.ToInt32(iql, P_0);
					num2 = 78;
					if (UR() == null)
					{
						num2 = 116;
					}
					continue;
				case 304:
					num24 = 119 - 40;
					num2 = 314;
					continue;
				case 320:
					num23 = 147 - 49;
					num2 = 60;
					continue;
				case 181:
					array2[20] = (byte)num24;
					num2 = 264;
					if (UR() == null)
					{
						num2 = 388;
					}
					continue;
				case 99:
					array2[13] = 141;
					num2 = 166;
					continue;
				case 183:
					array3[13] = publicKeyToken[6];
					num2 = 199;
					continue;
				case 341:
					array[1] = (byte)num22;
					num = 346;
					break;
				case 356:
					num21 = 185 - 61;
					num2 = 377;
					if (eF())
					{
						continue;
					}
					break;
				case 231:
					num31 = 0u;
					num2 = 111;
					if (eF())
					{
						num2 = 197;
					}
					continue;
				case 48:
					symmetricAlgorithm = esF();
					num2 = 6;
					continue;
				case 180:
					array2[26] = 93;
					num2 = 215;
					continue;
				case 165:
					if (num34 > 0)
					{
						num2 = 269;
						continue;
					}
					goto case 231;
				case 161:
				case 362:
					if (num30 >= num34)
					{
						num2 = 31;
						if (eF())
						{
							continue;
						}
						break;
					}
					goto case 195;
				case 347:
					cryptoStream.FlushFinalBlock();
					num2 = 171;
					continue;
				case 12:
					array[6] = 163;
					num2 = 87;
					continue;
				case 355:
					array2[7] = (byte)num23;
					num2 = 387;
					continue;
				case 151:
					array[14] = 93;
					num2 = 292;
					continue;
				case 164:
					num23 = 177 - 123;
					num2 = 86;
					continue;
				case 156:
					if (iql.Length != 0)
					{
						num2 = 155;
						continue;
					}
					goto case 360;
				case 179:
					if (num26 > 0)
					{
						num2 = 220;
						continue;
					}
					goto case 352;
				case 278:
					array[4] = (byte)num22;
					num2 = 209;
					continue;
				case 334:
					num21 = 158 - 52;
					num2 = 8;
					continue;
				case 60:
					array2[23] = (byte)num23;
					num2 = 21;
					if (eF())
					{
						num2 = 190;
					}
					continue;
				case 34:
					array5[num36 + 1] = (byte)((num38 & 0xFF00) >> 8);
					num2 = 45;
					continue;
				case 90:
					array2 = new byte[32];
					num = 317;
					break;
				case 163:
					array[7] = 77;
					num2 = 359;
					continue;
				case 297:
					num22 = 27 + 73;
					num2 = 225;
					if (UR() == null)
					{
						num2 = 271;
					}
					continue;
				case 114:
					array2[12] = (byte)num24;
					num2 = 122;
					if (eF())
					{
						continue;
					}
					break;
				case 363:
					array2[20] = 128;
					num2 = 307;
					continue;
				case 58:
					num34 = array6.Length % 4;
					num2 = 409;
					continue;
				case 274:
					num23 = 29 + 121;
					num2 = 149;
					if (eF())
					{
						continue;
					}
					break;
				case 105:
					array5[num36] = (byte)(num38 & 0xFF);
					num2 = 34;
					continue;
				case 193:
					num28 = 0u;
					num2 = 129;
					continue;
				case 88:
					array[0] = (byte)num21;
					num2 = 100;
					continue;
				case 173:
					num21 = 175 - 58;
					num2 = 229;
					if (eF())
					{
						continue;
					}
					break;
				case 409:
					num40 = array6.Length / 4;
					num2 = 343;
					if (!eF())
					{
						num2 = 154;
					}
					continue;
				case 346:
					num21 = 140 - 79;
					num2 = 3;
					if (UR() == null)
					{
						num2 = 111;
					}
					continue;
				case 2:
					if (num35 == num40 - 1)
					{
						num = 257;
						break;
					}
					goto case 395;
				case 305:
					array3 = array;
					num2 = 9;
					continue;
				case 301:
					array[14] = (byte)num21;
					num2 = 328;
					if (eF())
					{
						continue;
					}
					break;
				case 192:
					num24 = 68 + 9;
					num2 = 371;
					continue;
				case 116:
					try
					{
						IVH.CecNqz();
						int num41 = 0;
						if (!eF())
						{
							num41 = num42;
						}
						while (true)
						{
							switch (num41)
							{
							case 1:
								return result;
							}
							result = Encoding.Unicode.GetString(iql, P_0 + 4, count);
							num41 = 1;
							if (!eF())
							{
								num41 = 0;
							}
						}
					}
					catch
					{
						int num43 = 0;
						if (!eF())
						{
							num43 = num44;
						}
						switch (num43)
						{
						case 0:
							break;
						}
					}
					goto case 81;
				case 353:
					array[2] = 127;
					num2 = 284;
					continue;
				case 295:
					num24 = 167 - 55;
					num2 = 405;
					continue;
				case 230:
					num28 = num4;
					num2 = 260;
					if (!eF())
					{
						num2 = 15;
					}
					continue;
				case 269:
					num40++;
					num2 = 231;
					continue;
				case 69:
					array2[10] = 49;
					num2 = 224;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 221:
					array2[13] = (byte)num24;
					num2 = 99;
					if (eF())
					{
						continue;
					}
					break;
				case 113:
					num23 = 182 - 60;
					num2 = 338;
					continue;
				case 45:
					array5[num36 + 2] = (byte)((num38 & 0xFF0000) >> 16);
					num2 = 227;
					if (eF())
					{
						continue;
					}
					break;
				case 14:
					array2[19] = (byte)num23;
					num2 = 118;
					continue;
				case 207:
					array[8] = 52;
					num2 = 67;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 4:
					num21 = 77 + 112;
					num2 = 301;
					continue;
				case 22:
					array[11] = (byte)num22;
					num2 = 198;
					if (UR() != null)
					{
						num2 = 89;
					}
					continue;
				case 203:
					num23 = 122 + 12;
					num2 = 175;
					if (eF())
					{
						continue;
					}
					break;
				case 160:
					array[5] = (byte)num22;
					num2 = 369;
					continue;
				case 136:
					array[5] = 202;
					num2 = 84;
					continue;
				case 210:
				case 226:
					if (num35 >= num40)
					{
						num2 = 239;
						if (UR() == null)
						{
							continue;
						}
						break;
					}
					goto case 302;
				case 246:
					array2[15] = 174;
					num2 = 174;
					continue;
				case 142:
					array2[22] = (byte)num23;
					num2 = 238;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 111:
					array[1] = (byte)num21;
					num2 = 21;
					continue;
				case 212:
					array2[24] = 46;
					num2 = 392;
					continue;
				case 326:
					cryptoStream.Write(array6, 0, array6.Length);
					num2 = 347;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 249:
					array2[16] = 137;
					num2 = 203;
					if (eF())
					{
						continue;
					}
					break;
				case 82:
					array2[27] = 108;
					num2 = 364;
					continue;
				case 144:
					num30 = 0;
					num2 = 362;
					continue;
				case 21:
					num21 = 16 + 36;
					num2 = 380;
					if (!eF())
					{
						num2 = 292;
					}
					continue;
				case 350:
					num21 = 183 + 15;
					num = 322;
					break;
				case 23:
					num22 = 240 - 80;
					num2 = 70;
					if (eF())
					{
						continue;
					}
					break;
				case 366:
					array2[10] = (byte)num24;
					num2 = 306;
					continue;
				case 102:
					array2[3] = (byte)num24;
					num2 = 146;
					continue;
				case 120:
					num22 = 24 - 20;
					num2 = 244;
					continue;
				case 383:
					array[12] = 36;
					num2 = 335;
					if (eF())
					{
						continue;
					}
					break;
				case 375:
					array2[20] = 125;
					num2 = 33;
					if (UR() == null)
					{
						num2 = 363;
					}
					continue;
				case 219:
					num23 = 186 - 62;
					num2 = 290;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 78:
					array2[28] = (byte)num23;
					num2 = 286;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 260:
					if (num35 == num40 - 1)
					{
						num2 = 5;
						continue;
					}
					goto case 276;
				case 41:
					array[7] = (byte)num21;
					num2 = 163;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 348:
					num24 = 179 - 59;
					num2 = 365;
					continue;
				case 388:
					num24 = 105 + 60;
					num2 = 223;
					continue;
				case 147:
					num23 = 106 - 31;
					num2 = 5;
					if (eF())
					{
						num2 = 110;
					}
					continue;
				case 36:
					array2[2] = (byte)num24;
					num2 = 80;
					continue;
				case 403:
					num23 = 247 - 82;
					num2 = 258;
					continue;
				case 67:
					array[8] = 159;
					num = 106;
					break;
				case 172:
					array2[7] = (byte)num23;
					num2 = 169;
					continue;
				case 329:
					array2[5] = 105;
					num2 = 76;
					if (eF())
					{
						continue;
					}
					break;
				case 125:
					array2[17] = (byte)num23;
					num2 = 381;
					continue;
				case 385:
					array[9] = (byte)num22;
					num2 = 167;
					continue;
				case 157:
					array2[3] = (byte)num24;
					num2 = 294;
					if (eF())
					{
						continue;
					}
					break;
				case 211:
					array2[30] = (byte)num23;
					num2 = 91;
					if (!eF())
					{
						num2 = 34;
					}
					continue;
				case 215:
					num23 = 73 + 87;
					num2 = 275;
					continue;
				case 289:
					array4[num25] ^= array3[num25];
					num2 = 259;
					continue;
				case 7:
					array[13] = 146;
					num2 = 399;
					continue;
				case 130:
					wVA.KDikMXewCI().Position = 0L;
					num2 = 107;
					if (eF())
					{
						num2 = 109;
					}
					continue;
				case 62:
					array = new byte[16];
					num2 = 143;
					continue;
				case 39:
					array[15] = 92;
					num2 = 100;
					if (eF())
					{
						num2 = 391;
					}
					continue;
				case 251:
					array2[10] = 137;
					num2 = 13;
					continue;
				case 15:
					stream.Close();
					num2 = 17;
					continue;
				case 29:
					array[7] = 108;
					num2 = 98;
					continue;
				case 268:
					num30++;
					num2 = 161;
					if (eF())
					{
						continue;
					}
					break;
				case 311:
					array2[30] = (byte)num23;
					num2 = 24;
					if (eF())
					{
						continue;
					}
					break;
				case 134:
					array2[23] = 103;
					num = 295;
					break;
				case 194:
					num36 = num35 * 4;
					num2 = 333;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 95:
					array[8] = 89;
					num2 = 207;
					continue;
				case 248:
					array2[31] = 162;
					num2 = 213;
					continue;
				case 119:
					num24 = 218 - 72;
					num2 = 1;
					if (UR() == null)
					{
						num2 = 1;
					}
					continue;
				case 284:
					array[3] = 145;
					num2 = 299;
					continue;
				case 255:
					num20 = (uint)((array4[num31 + 3] << 24) | (array4[num31 + 2] << 16) | (array4[num31 + 1] << 8) | array4[num31]);
					num2 = 93;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 338:
					array2[11] = (byte)num23;
					num = 121;
					break;
				case 42:
					array2[3] = (byte)num24;
					num2 = 327;
					continue;
				case 91:
					array2[31] = 100;
					num2 = 189;
					continue;
				case 242:
					num24 = 14 + 32;
					num2 = 200;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 382:
					num24 = 242 - 80;
					num2 = 316;
					continue;
				case 89:
					publicKeyToken = vqn.GetName().GetPublicKeyToken();
					num2 = 176;
					continue;
				case 28:
					num21 = 39 + 113;
					num2 = 88;
					if (UR() == null)
					{
						num2 = 293;
					}
					continue;
				case 200:
					array2[28] = (byte)num24;
					num2 = 37;
					continue;
				case 101:
					array2[16] = 84;
					num2 = 339;
					continue;
				case 162:
					array[3] = 112;
					num = 310;
					break;
				case 52:
					array[11] = 147;
					num2 = 397;
					continue;
				case 98:
					array[7] = 175;
					num2 = 187;
					continue;
				case 191:
					array2[8] = (byte)num23;
					num2 = 308;
					continue;
				case 93:
					num39 = 255u;
					num2 = 398;
					continue;
				case 238:
					num24 = 19 + 114;
					num2 = 35;
					if (!eF())
					{
						num2 = 17;
					}
					continue;
				case 405:
					array2[23] = (byte)num24;
					num2 = 320;
					continue;
				case 378:
					num24 = 243 - 81;
					num2 = 135;
					continue;
				case 182:
					transform = symmetricAlgorithm.CreateDecryptor(array4, array3);
					num2 = 331;
					continue;
				case 216:
					array[14] = 122;
					num2 = 173;
					continue;
				case 63:
					num26++;
					num2 = 38;
					continue;
				case 229:
					array[14] = (byte)num21;
					num2 = 151;
					continue;
				case 32:
					array2[30] = (byte)num23;
					num2 = 277;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 321:
					array2[2] = 123;
					num2 = 404;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 360:
					wVA = new WVA(vqn.GetManifestResourceStream("QOawFuLPfO2gleML3s.33ZwqM4ocxntHJMDTg"));
					num2 = 130;
					continue;
				case 299:
					array[3] = 130;
					num2 = 0;
					if (UR() != null)
					{
						num2 = 0;
					}
					continue;
				case 79:
					num22 = 114 + 37;
					num2 = 73;
					continue;
				case 51:
					array2[11] = (byte)num23;
					num2 = 214;
					continue;
				case 263:
					num24 = 96 + 10;
					num2 = 366;
					continue;
				case 190:
					array2[23] = 145;
					num2 = 233;
					continue;
				case 24:
					num23 = 92 + 109;
					num2 = 211;
					if (UR() != null)
					{
						num2 = 146;
					}
					continue;
				case 257:
					if (num34 > 0)
					{
						num2 = 255;
						if (UR() == null)
						{
							num2 = 264;
						}
						continue;
					}
					goto case 395;
				case 227:
					array5[num36 + 3] = (byte)((num38 & 0xFF000000u) >> 24);
					num2 = 374;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 73:
					array[7] = (byte)num22;
					num2 = 29;
					continue;
				case 158:
					num22 = 77 + 24;
					num = 411;
					break;
				case 264:
					num29 = 0u;
					num2 = 145;
					continue;
				case 410:
					array[8] = 224;
					num2 = 384;
					continue;
				case 65:
					array2[27] = 101;
					num2 = 107;
					continue;
				case 74:
					num23 = 0 + 49;
					num2 = 172;
					if (UR() != null)
					{
						num2 = 150;
					}
					continue;
				case 176:
					if (publicKeyToken != null)
					{
						num2 = 55;
						if (UR() == null)
						{
							continue;
						}
						break;
					}
					goto case 123;
				case 271:
					array[9] = (byte)num22;
					num2 = 281;
					if (eF())
					{
						continue;
					}
					break;
				case 53:
					array2[25] = (byte)num23;
					num2 = 141;
					continue;
				case 328:
					num21 = 88 + 55;
					num2 = 401;
					continue;
				case 291:
					array2[31] = (byte)num24;
					num = 108;
					break;
				default:
					num21 = 236 - 78;
					num2 = 236;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 204:
					array3[3] = publicKeyToken[1];
					num2 = 47;
					continue;
				case 307:
					num24 = 138 + 70;
					num2 = 181;
					continue;
				case 37:
					num23 = 6 + 67;
					num = 340;
					break;
				case 394:
					array[4] = 168;
					num2 = 332;
					continue;
				case 325:
					array2[14] = (byte)num24;
					num2 = 378;
					if (eF())
					{
						continue;
					}
					break;
				case 126:
					array2[24] = 236;
					num2 = 128;
					continue;
				case 349:
					num29 = (uint)((array6[num31 + 3] << 24) | (array6[num31 + 2] << 16) | (array6[num31 + 1] << 8) | array6[num31]);
					num2 = 400;
					if (UR() != null)
					{
						num2 = 334;
					}
					continue;
				case 57:
					num24 = 38 + 78;
					num2 = 102;
					if (UR() != null)
					{
						num2 = 16;
					}
					continue;
				case 143:
					array[0] = 114;
					num2 = 357;
					if (eF())
					{
						continue;
					}
					break;
				case 109:
					array6 = wVA.mqy((int)wVA.KDikMXewCI().Length);
					num2 = 46;
					continue;
				case 153:
					array2[23] = 140;
					num2 = 134;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 159:
					array[13] = (byte)num22;
					num2 = 245;
					continue;
				case 361:
					array2[8] = (byte)num24;
					num2 = 382;
					continue;
				case 228:
					array[5] = 127;
					num = 115;
					break;
				case 233:
					array2[23] = 243;
					num = 126;
					break;
				case 261:
					num23 = 189 - 63;
					num = 191;
					break;
				case 234:
					num23 = 210 - 70;
					num2 = 14;
					continue;
				case 317:
					array2[0] = 67;
					num2 = 11;
					if (eF())
					{
						num2 = 266;
					}
					continue;
				case 411:
					array[1] = (byte)num22;
					num2 = 285;
					continue;
				case 138:
					array2[12] = (byte)num24;
					num2 = 92;
					continue;
				case 391:
					array[15] = 233;
					num2 = 305;
					continue;
				case 359:
					num22 = 202 - 67;
					num2 = 196;
					continue;
				case 46:
					wVA.tqu();
					num2 = 90;
					continue;
				case 237:
					array2[20] = (byte)num24;
					num2 = 51;
					if (eF())
					{
						num2 = 375;
					}
					continue;
				case 94:
					array2[7] = 170;
					num2 = 54;
					continue;
				case 25:
					array6 = iql;
					num2 = 58;
					continue;
				case 18:
					array2[8] = (byte)num24;
					num2 = 184;
					continue;
				case 1:
					array2[6] = (byte)num24;
					num2 = 16;
					if (UR() == null)
					{
						num2 = 43;
					}
					continue;
				case 5:
					if (num34 > 0)
					{
						num2 = 406;
						continue;
					}
					goto case 276;
				case 56:
					array2[6] = 8;
					num2 = 94;
					continue;
				case 55:
					if (publicKeyToken.Length > 0)
					{
						num2 = 367;
						if (eF())
						{
							continue;
						}
						break;
					}
					goto case 123;
				case 379:
					array2[25] = 150;
					num2 = 154;
					continue;
				case 86:
					array2[14] = (byte)num23;
					num2 = 192;
					continue;
				case 13:
					array2[10] = 112;
					num2 = 263;
					continue;
				case 364:
					array2[27] = 13;
					num2 = 77;
					continue;
				case 310:
					num21 = 99 + 50;
					num2 = 97;
					continue;
				case 377:
					array[12] = (byte)num21;
					num2 = 127;
					if (eF())
					{
						num2 = 383;
					}
					continue;
				case 371:
					array2[15] = (byte)num24;
					num2 = 376;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 288:
					num37 = array4.Length / 4;
					num2 = 205;
					if (!eF())
					{
						num2 = 168;
					}
					continue;
				case 72:
					array2[0] = (byte)num24;
					num2 = 44;
					continue;
				case 197:
					num35 = 0;
					num2 = 210;
					continue;
				case 282:
					array[1] = (byte)num21;
					num = 158;
					break;
				case 389:
					array[9] = 13;
					num2 = 313;
					continue;
				case 205:
					num28 = 0u;
					num2 = 59;
					continue;
				case 387:
					array2[8] = 87;
					num2 = 261;
					if (eF())
					{
						continue;
					}
					break;
				case 276:
					num38 = num28 ^ num29;
					num = 105;
					break;
				case 323:
					array2[3] = (byte)num24;
					num2 = 319;
					continue;
				case 64:
					array2[19] = 122;
					num2 = 234;
					continue;
				case 152:
					array2[4] = (byte)num23;
					num2 = 206;
					continue;
				case 390:
					num29 |= array6[array6.Length - (1 + num30)];
					num2 = 268;
					continue;
				case 140:
					array3[11] = publicKeyToken[5];
					num2 = 183;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 100:
					array[0] = 183;
					num2 = 342;
					continue;
				case 107:
					array2[27] = 178;
					num2 = 82;
					continue;
				case 258:
					array2[2] = (byte)num23;
					num2 = 321;
					continue;
				case 137:
					array2[5] = 157;
					num2 = 287;
					continue;
				case 315:
					array[1] = 152;
					num2 = 332;
					if (UR() == null)
					{
						num2 = 370;
					}
					continue;
				case 30:
					num33 += 8;
					num2 = 352;
					continue;
				case 145:
					num28 += num20;
					num2 = 144;
					continue;
				case 85:
					array2[20] = 150;
					num2 = 396;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 236:
					array[3] = (byte)num21;
					num2 = 162;
					continue;
				case 198:
					array[12] = 116;
					num2 = 356;
					continue;
				case 335:
					num22 = 125 - 41;
					num2 = 159;
					continue;
				case 308:
					num24 = 167 - 55;
					num2 = 11;
					if (UR() == null)
					{
						num2 = 18;
					}
					continue;
				case 27:
					num29 <<= 8;
					num2 = 390;
					continue;
				case 50:
					array2[18] = 234;
					num2 = 129;
					if (eF())
					{
						num2 = 225;
					}
					continue;
				case 357:
					num21 = 43 + 117;
					num2 = 186;
					continue;
				case 83:
					array2[18] = 147;
					num2 = 20;
					if (UR() != null)
					{
						num2 = 16;
					}
					continue;
				case 127:
					array2[7] = (byte)num24;
					num2 = 74;
					continue;
				case 96:
					num31 = (uint)num36;
					num2 = 349;
					continue;
				case 80:
					array2[2] = 126;
					num2 = 147;
					if (eF())
					{
						continue;
					}
					break;
				case 139:
					num24 = 173 - 116;
					num2 = 68;
					continue;
				case 285:
					array[1] = 132;
					num2 = 315;
					continue;
				case 168:
					array2[1] = (byte)num23;
					num = 403;
					break;
				case 26:
				case 374:
					num35++;
					num2 = 226;
					continue;
				case 199:
					array3[15] = publicKeyToken[7];
					num2 = 123;
					continue;
				case 339:
					num23 = 81 + 120;
					num2 = 208;
					continue;
				case 372:
					num23 = 156 - 52;
					num2 = 32;
					continue;
				case 253:
					num23 = 121 - 81;
					num2 = 355;
					continue;
				case 217:
					array[2] = 72;
					num = 407;
					break;
				case 404:
					num24 = 43 + 72;
					num2 = 36;
					continue;
				case 241:
					array2[19] = 209;
					num2 = 85;
					continue;
				case 266:
					num23 = 178 - 59;
					num2 = 3;
					continue;
				case 277:
					num23 = 124 + 117;
					num2 = 311;
					if (eF())
					{
						continue;
					}
					break;
				case 150:
					array[10] = 215;
					num2 = 402;
					continue;
				case 31:
				case 400:
					num4 = num28;
					num2 = 193;
					continue;
				case 6:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 182;
					continue;
				case 407:
					num21 = 84 + 105;
					num = 240;
					break;
				case 38:
				case 386:
					if (num26 >= num34)
					{
						num2 = 26;
						continue;
					}
					goto case 179;
				case 66:
					array2[17] = 119;
					num2 = 170;
					continue;
				case 11:
					num24 = 128 - 48;
					num2 = 323;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 70:
					array[0] = (byte)num22;
					num2 = 177;
					continue;
				case 148:
					array2[24] = 115;
					num2 = 212;
					if (eF())
					{
						continue;
					}
					break;
				case 319:
					num23 = 191 - 63;
					num2 = 152;
					continue;
				case 294:
					num24 = 46 + 20;
					num2 = 42;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 68:
					array2[9] = (byte)num24;
					num2 = 251;
					continue;
				case 47:
					array3[5] = publicKeyToken[2];
					num2 = 28;
					if (UR() == null)
					{
						num2 = 358;
					}
					continue;
				case 262:
					array2[5] = (byte)num24;
					num2 = 137;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 398:
					num33 = 0;
					num2 = 2;
					continue;
				case 189:
					array2[31] = 153;
					num2 = 248;
					if (eF())
					{
						continue;
					}
					break;
				case 397:
					num22 = 162 - 80;
					num2 = 22;
					continue;
				case 286:
					num24 = 40 + 10;
					num2 = 133;
					continue;
				case 333:
					num31 = (uint)(num32 * 4);
					num = 255;
					break;
				case 19:
					array2[25] = 6;
					num2 = 66;
					if (UR() == null)
					{
						num2 = 180;
					}
					continue;
				case 402:
					array[10] = 118;
					num2 = 28;
					continue;
				case 235:
					array[4] = 112;
					num2 = 228;
					continue;
				case 243:
				case 252:
					if (num25 >= array3.Length)
					{
						num2 = 116;
						if (UR() == null)
						{
							num2 = 188;
						}
						continue;
					}
					goto case 289;
				case 365:
					array2[11] = (byte)num24;
					num2 = 113;
					continue;
				case 331:
					stream = mqe();
					num2 = 16;
					if (!eF())
					{
						num2 = 9;
					}
					continue;
				case 352:
					array5[num36 + num26] = (byte)((num27 & num39) >> num33);
					num2 = 8;
					if (UR() == null)
					{
						num2 = 63;
					}
					continue;
				case 316:
					array2[9] = (byte)num24;
					num2 = 61;
					if (!eF())
					{
						num2 = 51;
					}
					continue;
				case 133:
					array2[28] = (byte)num24;
					num2 = 242;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 123:
					num25 = 0;
					num2 = 252;
					continue;
				case 345:
					array2[0] = (byte)num24;
					num2 = 71;
					continue;
				case 218:
					array3[9] = publicKeyToken[4];
					num2 = 140;
					continue;
				case 250:
					array2[7] = (byte)num24;
					num2 = 253;
					continue;
				case 112:
					num24 = 45 + 83;
					num2 = 300;
					continue;
				case 33:
					array[11] = (byte)num22;
					num2 = 52;
					continue;
				case 247:
					array2[29] = (byte)num24;
					num2 = 306;
					if (eF())
					{
						num2 = 372;
					}
					continue;
				case 118:
					array2[19] = 138;
					num2 = 241;
					if (eF())
					{
						continue;
					}
					break;
				case 20:
					array2[18] = 90;
					num2 = 50;
					continue;
				case 187:
					num21 = 72 + 104;
					num2 = 41;
					continue;
				case 300:
					array2[1] = (byte)num24;
					num2 = 309;
					continue;
				case 177:
					num21 = 216 - 72;
					num2 = 88;
					if (eF())
					{
						continue;
					}
					break;
				case 54:
					array2[7] = 166;
					num2 = 202;
					continue;
				case 340:
					array2[28] = (byte)num23;
					num2 = 304;
					continue;
				case 8:
					array[14] = (byte)num21;
					num2 = 216;
					continue;
				case 393:
					num23 = 9 + 43;
					num2 = 142;
					continue;
				case 175:
					array2[16] = (byte)num23;
					num2 = 101;
					continue;
				case 115:
					num22 = 34 + 118;
					num2 = 160;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 342:
					num21 = 200 - 66;
					num2 = 282;
					if (eF())
					{
						continue;
					}
					break;
				case 224:
					num24 = 140 - 46;
					num2 = 303;
					continue;
				case 313:
					array[10] = 170;
					num = 373;
					break;
				case 298:
					array[10] = (byte)num21;
					num2 = 150;
					if (eF())
					{
						continue;
					}
					break;
				case 343:
					array5 = new byte[array6.Length];
					num = 288;
					break;
				case 370:
					num22 = 88 + 27;
					num2 = 341;
					if (eF())
					{
						continue;
					}
					break;
				case 110:
					array2[2] = (byte)num23;
					num2 = 273;
					continue;
				case 40:
					num24 = 37 + 76;
					num2 = 344;
					continue;
				case 344:
					array2[29] = (byte)num24;
					num2 = 336;
					if (!eF())
					{
						num2 = 51;
					}
					continue;
				case 314:
					array2[28] = (byte)num24;
					num2 = 40;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 108:
					array4 = array2;
					num2 = 62;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 43:
					array2[6] = 144;
					num2 = 56;
					continue;
				case 412:
					num22 = 36 + 30;
					num2 = 89;
					if (UR() == null)
					{
						num2 = 272;
					}
					continue;
				case 128:
					array2[24] = 119;
					num2 = 256;
					if (UR() != null)
					{
						num2 = 156;
					}
					continue;
				case 318:
					array[8] = (byte)num22;
					num2 = 410;
					continue;
				case 292:
					array[14] = 95;
					num2 = 0;
					if (UR() == null)
					{
						num2 = 4;
					}
					continue;
				case 327:
					array2[3] = 137;
					num = 57;
					break;
				case 131:
					num24 = 227 - 75;
					num2 = 345;
					if (eF())
					{
						continue;
					}
					break;
				case 336:
					array2[29] = 135;
					num2 = 222;
					continue;
				case 267:
					num26 = 0;
					num2 = 386;
					continue;
				case 225:
					array2[19] = 157;
					num2 = 64;
					continue;
				case 293:
					array[10] = (byte)num21;
					num2 = 265;
					if (!eF())
					{
						num2 = 26;
					}
					continue;
				case 169:
					num24 = 89 + 110;
					num2 = 250;
					continue;
				case 141:
					array2[25] = 160;
					num2 = 379;
					continue;
				case 384:
					num22 = 11 + 90;
					num2 = 385;
					continue;
				case 354:
					array[4] = (byte)num22;
					num2 = 408;
					continue;
				case 92:
					num24 = 133 - 34;
					num2 = 114;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 240:
					array[2] = (byte)num21;
					num = 353;
					break;
				case 392:
					array2[24] = 9;
					num2 = 368;
					continue;
				case 124:
					array2[17] = 148;
					num2 = 66;
					continue;
				case 396:
					num24 = 127 - 42;
					num2 = 237;
					continue;
				case 9:
					Array.Reverse(array3);
					num2 = 89;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 146:
					num24 = 171 - 57;
					num2 = 312;
					continue;
				case 232:
					num24 = 33 - 2;
					num2 = 72;
					continue;
				case 272:
					array[6] = (byte)num22;
					num2 = 350;
					if (UR() != null)
					{
						num2 = 328;
					}
					continue;
				case 185:
					array2[18] = (byte)num23;
					num2 = 83;
					continue;
				case 103:
					array2[26] = 96;
					num2 = 65;
					continue;
				case 76:
					num24 = 0 + 77;
					num2 = 262;
					continue;
				case 3:
					array2[0] = (byte)num23;
					num2 = 131;
					continue;
				case 167:
					array[9] = 140;
					num2 = 297;
					continue;
				case 209:
					num22 = 86 + 67;
					num = 354;
					break;
				case 121:
					num23 = 128 - 17;
					num2 = 51;
					continue;
				case 280:
					array2[21] = (byte)num24;
					num2 = 274;
					continue;
				case 254:
					array[0] = 108;
					num2 = 23;
					continue;
				case 259:
					num25++;
					num2 = 243;
					continue;
				case 287:
					array2[5] = 246;
					num2 = 119;
					continue;
				case 275:
					array2[26] = (byte)num23;
					num2 = 103;
					if (eF())
					{
						continue;
					}
					break;
				case 132:
					array2[17] = 88;
					num2 = 124;
					continue;
				case 135:
					array2[14] = (byte)num24;
					num2 = 49;
					if (eF())
					{
						continue;
					}
					break;
				case 97:
					array[4] = (byte)num21;
					num2 = 394;
					continue;
				case 17:
					cryptoStream.Close();
					num2 = 25;
					if (UR() != null)
					{
						num2 = 22;
					}
					continue;
				case 49:
					array2[14] = 92;
					num2 = 351;
					if (eF())
					{
						continue;
					}
					break;
				case 75:
					array2[16] = (byte)num24;
					num2 = 249;
					continue;
				case 154:
					array2[25] = 162;
					num2 = 19;
					if (eF())
					{
						continue;
					}
					break;
				case 244:
					array[13] = (byte)num22;
					num2 = 334;
					continue;
				case 381:
					num23 = 124 + 80;
					num2 = 185;
					continue;
				case 380:
					array[2] = (byte)num21;
					num2 = 217;
					if (eF())
					{
						continue;
					}
					break;
				case 174:
					num24 = 73 + 51;
					num2 = 75;
					if (eF())
					{
						continue;
					}
					break;
				case 395:
					num28 += num20;
					num2 = 96;
					if (UR() == null)
					{
						continue;
					}
					break;
				case 206:
					array2[4] = 142;
					num2 = 219;
					continue;
				case 149:
					array2[21] = (byte)num23;
					num2 = 393;
					continue;
				case 265:
					num22 = 130 - 43;
					num2 = 23;
					if (UR() == null)
					{
						num2 = 33;
					}
					continue;
				case 401:
					array[15] = (byte)num21;
					num2 = 330;
					continue;
				case 129:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 942927732u;
					uint num7 = 1746999804u;
					uint num8 = 1544473461u;
					uint num9 = num5;
					uint num10 = 583340020u;
					uint num11 = 155601700u;
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
					num = 230;
					break;
				}
				}
				break;
			}
		}
	}

	[aVr(typeof(aVr.RVL<object>[]))]
	internal static string ms0(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Tsh()
	{
		return 5;
	}

	private static void Ysg()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate ysX(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object ws5(object P_0)
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
	public static extern IntPtr qsy(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr qso(IntPtr P_0, string P_1);

	private static IntPtr ist(IntPtr P_0, string P_1, uint P_2)
	{
		if (Jqj == null)
		{
			IntPtr ptr = qso(umLocehuEC(), "Find ".Trim() + "ResourceA");
			Jqj = (dVf)Marshal.GetDelegateForFunctionPointer(ptr, typeof(dVf));
		}
		return Jqj(P_0, P_1, P_2);
	}

	private static IntPtr Tsu(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (kqZ == null)
		{
			IntPtr ptr = qso(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			kqZ = (aVQ)Marshal.GetDelegateForFunctionPointer(ptr, typeof(aVQ));
		}
		return kqZ(P_0, P_1, P_2, P_3);
	}

	private static int Osz(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (Uqb == null)
		{
			IntPtr ptr = qso(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			Uqb = (iV0)Marshal.GetDelegateForFunctionPointer(ptr, typeof(iV0));
		}
		return Uqb(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int gqi(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (wqA == null)
		{
			IntPtr ptr = qso(umLocehuEC(), "Virtual ".Trim() + "Protect");
			wqA = (eV8)Marshal.GetDelegateForFunctionPointer(ptr, typeof(eV8));
		}
		return wqA(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr Nqd(uint P_0, int P_1, uint P_2)
	{
		if (vqH == null)
		{
			IntPtr ptr = qso(umLocehuEC(), "Open ".Trim() + "Process");
			vqH = (lVk)Marshal.GetDelegateForFunctionPointer(ptr, typeof(lVk));
		}
		return vqH(P_0, P_1, P_2);
	}

	private static int Dqw(IntPtr P_0)
	{
		if (kq0 == null)
		{
			IntPtr ptr = qso(umLocehuEC(), "Close ".Trim() + "Handle");
			kq0 = (OVy)Marshal.GetDelegateForFunctionPointer(ptr, typeof(OVy));
		}
		return kq0(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (zqh == IntPtr.Zero)
		{
			zqh = qsy("kernel ".Trim() + "32.dll");
		}
		return zqh;
	}

	[aVr(typeof(aVr.RVL<object>[]))]
	private static byte[] Dq2(string P_0)
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

	internal static Stream mqe()
	{
		return new MemoryStream();
	}

	internal static byte[] aqG(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[aVr(typeof(aVr.RVL<object>[]))]
	private static byte[] jqI(byte[] P_0)
	{
		Stream stream = mqe();
		SymmetricAlgorithm symmetricAlgorithm = esF();
		symmetricAlgorithm.Key = new byte[32]
		{
			155, 6, 198, 150, 162, 73, 147, 31, 111, 197,
			178, 101, 196, 191, 92, 68, 211, 169, 89, 177,
			194, 23, 134, 159, 138, 98, 133, 222, 211, 40,
			65, 75
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			192, 220, 143, 5, 99, 102, 235, 196, 10, 29,
			248, 58, 118, 131, 207, 3
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = aqG(stream);
		IVH.CecNqz();
		return result;
	}

	private byte[] Fqk()
	{
		return null;
	}

	private byte[] aqC()
	{
		return null;
	}

	private byte[] sq1()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] pqN()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] vqQ()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] qqm()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Oqa()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] XqW()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] uqB()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] sqK()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool eF()
	{
		return (object)null == null;
	}

	internal static object UR()
	{
		return null;
	}
}
