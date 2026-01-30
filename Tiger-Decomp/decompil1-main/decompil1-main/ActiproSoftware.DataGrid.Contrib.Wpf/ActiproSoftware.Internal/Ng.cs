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

internal class Ng
{
	private delegate void PN(object o);

	internal class io : Attribute
	{
		internal class Ki<hY>
		{
			internal static object jj;

			public Ki()
			{
				ns.vQ9Sfz();
				base._002Ector();
			}

			internal static bool Hf()
			{
				return jj == null;
			}

			internal static object mW()
			{
				return jj;
			}
		}

		[io(typeof(Ki<object>[]))]
		public io(object P_0)
		{
		}
	}

	internal class B9
	{
		[io(typeof(io.Ki<object>[]))]
		internal static string q2k(string P_0, string P_1)
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
			byte[] iV = uC(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Jb();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint XL(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Od();

	internal struct Y8
	{
		internal bool m2a;

		internal byte[] A2c;
	}

	internal class It
	{
		private BinaryReader eIg;

		public It(Stream P_0)
		{
			eIg = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return eIg.BaseStream;
		}

		internal byte[] k2z(int P_0)
		{
			return eIg.ReadBytes(P_0);
		}

		internal int gIZ(byte[] P_0, int P_1, int P_2)
		{
			return eIg.Read(P_0, P_1, P_2);
		}

		internal int iI2()
		{
			return eIg.ReadInt32();
		}

		internal void GII()
		{
			eIg.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr kE(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr sO(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int uF(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int rU(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr DA(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int SX(IntPtr ptr);

	[Flags]
	private enum pQ
	{

	}

	private static uint[] n23;

	internal static RSACryptoServiceProvider V20;

	private static Dictionary<int, int> x25;

	private static byte[] X27;

	private static IntPtr H2y;

	private static int[] t21;

	private static int L2p;

	private static long W2j;

	private static bool v2l;

	private static int X2h;

	private static IntPtr N2T;

	[io(typeof(io.Ki<object>[]))]
	private static bool Q2K;

	private static uF q2B;

	private static DA s2n;

	private static object a2H;

	private static rU M2v;

	private static int a2D;

	private static IntPtr o2G;

	private static int J2b;

	private static bool C2m;

	private static object M2M;

	private static byte[] s2W;

	private static IntPtr r2R;

	internal static XL U2w;

	private static sO J26;

	private static kE k2u;

	private static bool j2f;

	internal static Hashtable G2P;

	private static bool W2S;

	private static long w24;

	internal static Assembly z2V;

	private static bool z2x;

	private static SX l2r;

	private static byte[] K2e;

	private static bool g2C;

	internal static XL L2J;

	private static SortedList H2q;

	static Ng()
	{
		C2m = false;
		z2V = typeof(Ng).Assembly;
		n23 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		W2S = false;
		j2f = false;
		K2e = new byte[0];
		V20 = null;
		x25 = null;
		M2M = new object();
		X27 = new byte[0];
		s2W = new byte[0];
		H2y = IntPtr.Zero;
		o2G = IntPtr.Zero;
		a2H = new string[0];
		t21 = new int[0];
		a2D = 1;
		z2x = false;
		H2q = new SortedList();
		L2p = 0;
		w24 = 0L;
		L2J = null;
		U2w = null;
		W2j = 0L;
		J2b = 0;
		v2l = false;
		g2C = false;
		X2h = 0;
		N2T = IntPtr.Zero;
		Q2K = false;
		G2P = new Hashtable();
		k2u = null;
		J26 = null;
		q2B = null;
		M2v = null;
		s2n = null;
		l2r = null;
		r2R = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void vQ9Sfv()
	{
	}

	internal static byte[] Rx(byte[] P_0)
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
		for (int j = 0; j < P_0.Length; j++)
		{
			array2[j] = P_0[j];
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
			vq(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			vq(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			vq(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			vq(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			vq(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			vq(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			vq(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			vq(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			vq(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			vq(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			vq(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			vq(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			vq(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			vq(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			vq(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			vq(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			Lp(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			Lp(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			Lp(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			Lp(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			Lp(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			Lp(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			Lp(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			Lp(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			Lp(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			Lp(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			Lp(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			Lp(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			Lp(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			Lp(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			Lp(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			Lp(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			x4(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			x4(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			x4(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			x4(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			x4(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			x4(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			x4(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			x4(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			x4(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			x4(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			x4(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			x4(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			x4(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			x4(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			x4(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			x4(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			HJ(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			HJ(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			HJ(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			HJ(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			HJ(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			HJ(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			HJ(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			HJ(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			HJ(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			HJ(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			HJ(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			HJ(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			HJ(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			HJ(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			HJ(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			HJ(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void vq(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + vw(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + n23[P_6 - 1], P_5);
	}

	private static void Lp(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + vw(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + n23[P_6 - 1], P_5);
	}

	private static void x4(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + vw(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + n23[P_6 - 1], P_5);
	}

	private static void HJ(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + vw(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + n23[P_6 - 1], P_5);
	}

	private static uint vw(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool Sj()
	{
		if (!W2S)
		{
			fl();
			W2S = true;
		}
		return j2f;
	}

	internal static SymmetricAlgorithm Jb()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Sj())
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

	internal static void fl()
	{
		try
		{
			j2f = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] uC(byte[] P_0)
	{
		if (!Sj())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return Rx(P_0);
	}

	internal static void qh(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			uT(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void uT(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint EK(uint P_0, int P_1, long P_2, BinaryReader P_3)
	{
		for (int j = 0; j < P_1; j++)
		{
			P_3.BaseStream.Position = P_2 + (j * 40 + 8);
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

	public static void iP(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (x25 == null)
			{
				lock (M2M)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Ng).Assembly.GetManifestResourceStream("mCVUGywaTXK82O121m.oioFMQipBLwc3YttlC"));
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
						for (int j = 0; j < num2; j++)
						{
							int num6 = j * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (j == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + k)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += dB(num3);
							if (j == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int l = 0; l < num; l++)
								{
									if (l > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + l] = (byte)((num9 & num7) >> num8);
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
						It it = new It(new MemoryStream(array));
						for (int m = 0; m < num11; m++)
						{
							int key = it.iI2();
							int value = it.iI2();
							dictionary.Add(key, value);
						}
						it.GII();
					}
					x25 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = x25[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(Ng).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
				for (int num14 = 0; num14 < parameters.Length; num14++)
				{
					array3[num14 + 1] = parameters[num14].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num15 = 0; num15 < num13; num15++)
				{
					switch (num15)
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
						iLGenerator.Emit(OpCodes.Ldarg_S, num15);
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

	private static uint P6(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint dB(uint P_0)
	{
		return 0u;
	}

	internal static void Rv()
	{
	}

	[io(typeof(io.Ki<object>[]))]
	internal static string cn(int P_0)
	{
		int num = 49;
		byte[] array = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num20 = default(int);
		int num21 = default(int);
		byte[] publicKeyToken = default(byte[]);
		int num25 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		int num29 = default(int);
		int num33 = default(int);
		Stream stream = default(Stream);
		byte[] array5 = default(byte[]);
		byte[] array2 = default(byte[]);
		int num24 = default(int);
		uint num36 = default(uint);
		uint num4 = default(uint);
		uint num34 = default(uint);
		int num28 = default(int);
		uint num31 = default(uint);
		int num27 = default(int);
		uint num38 = default(uint);
		uint num35 = default(uint);
		int num30 = default(int);
		byte[] array3 = default(byte[]);
		int num22 = default(int);
		uint num23 = default(uint);
		int num40 = default(int);
		string result = default(string);
		int count = default(int);
		int num32 = default(int);
		int num26 = default(int);
		It it = default(It);
		uint num37 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 314:
					array[7] = 144;
					num2 = 419;
					continue;
				case 248:
					transform = symmetricAlgorithm.CreateDecryptor(array6, array4);
					num2 = 207;
					if (Uk())
					{
						continue;
					}
					break;
				case 40:
					array[2] = (byte)num20;
					num2 = 24;
					continue;
				case 226:
					num21 = 33 + 105;
					num2 = 375;
					continue;
				case 84:
					publicKeyToken = z2V.GetName().GetPublicKeyToken();
					num2 = 162;
					continue;
				case 170:
					if (num25 > 0)
					{
						num2 = 209;
						continue;
					}
					goto case 300;
				case 195:
					array[13] = (byte)num20;
					num2 = 391;
					continue;
				case 255:
					cryptoStream.FlushFinalBlock();
					num2 = 337;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 276:
					array[27] = 106;
					num2 = 256;
					continue;
				case 30:
					num20 = 207 - 69;
					num = 2;
					break;
				case 265:
					num20 = 89 + 104;
					num2 = 218;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 259:
					array = new byte[32];
					num2 = 270;
					continue;
				case 187:
				case 370:
					if (num29 >= num33)
					{
						num2 = 53;
						if (S8() == null)
						{
							continue;
						}
						break;
					}
					goto case 198;
				case 403:
					num21 = 87 + 1;
					num2 = 379;
					continue;
				case 337:
					X27 = w2L(stream);
					num2 = 225;
					if (S8() != null)
					{
						num2 = 8;
					}
					continue;
				case 418:
					num33 = array5.Length / 4;
					num2 = 328;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 329:
					num21 = 127 - 42;
					num2 = 75;
					continue;
				case 164:
					array2[1] = (byte)num21;
					num2 = 2;
					if (Uk())
					{
						num2 = 223;
					}
					continue;
				case 364:
					num20 = 145 - 48;
					num2 = 197;
					continue;
				case 210:
					if (num24 > 0)
					{
						num2 = 116;
						continue;
					}
					goto case 37;
				case 51:
					array[0] = (byte)num20;
					num2 = 360;
					continue;
				case 38:
					array2[9] = (byte)num21;
					num2 = 362;
					if (Uk())
					{
						continue;
					}
					break;
				case 389:
					array[23] = 177;
					num2 = 91;
					if (S8() != null)
					{
						num2 = 11;
					}
					continue;
				case 14:
					array[13] = (byte)num20;
					num2 = 227;
					if (!Uk())
					{
						num2 = 140;
					}
					continue;
				case 147:
					array[19] = (byte)num20;
					num2 = 415;
					continue;
				case 414:
					array2[10] = 99;
					num = 203;
					break;
				case 97:
					num21 = 62 + 59;
					num2 = 169;
					continue;
				case 131:
					Array.Reverse(array4);
					num2 = 84;
					continue;
				case 277:
					array[25] = 86;
					num2 = 33;
					continue;
				case 410:
					array2[5] = (byte)num21;
					num2 = 18;
					if (Uk())
					{
						continue;
					}
					break;
				case 4:
					num21 = 218 - 72;
					num2 = 219;
					if (S8() != null)
					{
						num2 = 0;
					}
					continue;
				case 238:
					array2[12] = 109;
					num2 = 29;
					if (!Uk())
					{
						num2 = 10;
					}
					continue;
				case 271:
					num20 = 92 + 49;
					num2 = 201;
					continue;
				case 352:
					num36 = num4;
					num2 = 134;
					continue;
				case 254:
					array[21] = (byte)num20;
					num2 = 87;
					continue;
				case 361:
					array[18] = (byte)num20;
					num2 = 15;
					continue;
				case 18:
					num21 = 196 - 65;
					num2 = 6;
					if (Uk())
					{
						num2 = 83;
					}
					continue;
				case 392:
					array[9] = (byte)num20;
					num2 = 243;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 423:
					array[4] = 103;
					num2 = 119;
					continue;
				case 63:
					array[22] = (byte)num20;
					num2 = 389;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 312:
					num20 = 238 - 79;
					num = 383;
					break;
				case 236:
					array2[3] = (byte)num21;
					num2 = 221;
					continue;
				case 60:
					array2[14] = (byte)num21;
					num2 = 114;
					continue;
				case 176:
					array6 = array;
					num2 = 299;
					if (Uk())
					{
						continue;
					}
					break;
				case 130:
					array[20] = 162;
					num2 = 324;
					if (Uk())
					{
						continue;
					}
					break;
				case 288:
					num21 = 55 + 83;
					num2 = 289;
					continue;
				case 331:
					array2[3] = 133;
					num2 = 230;
					if (Uk())
					{
						num2 = 264;
					}
					continue;
				case 390:
					array2[13] = 150;
					num2 = 81;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 113:
					num20 = 79 + 59;
					num = 145;
					break;
				case 339:
					array[20] = 165;
					num2 = 185;
					if (!Uk())
					{
						num2 = 180;
					}
					continue;
				case 422:
					num34 = (uint)(num28 * 4);
					num2 = 211;
					if (S8() != null)
					{
						num2 = 211;
					}
					continue;
				case 57:
					array2[7] = 84;
					num2 = 406;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 129:
					array[11] = (byte)num20;
					num2 = 28;
					if (Uk())
					{
						num2 = 47;
					}
					continue;
				case 228:
					array[3] = 99;
					num2 = 23;
					if (Uk())
					{
						continue;
					}
					break;
				case 338:
					num20 = 19 + 50;
					num2 = 402;
					continue;
				case 116:
					num31 <<= 8;
					num2 = 37;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 117:
					array[16] = (byte)num20;
					num2 = 188;
					if (S8() == null)
					{
						num2 = 272;
					}
					continue;
				case 96:
					num21 = 132 - 44;
					num2 = 60;
					continue;
				case 128:
					num27 = 0;
					num2 = 200;
					continue;
				case 99:
					num21 = 68 - 55;
					num2 = 185;
					if (S8() == null)
					{
						num2 = 229;
					}
					continue;
				case 374:
					array[10] = (byte)num20;
					num2 = 330;
					continue;
				case 402:
					array[21] = (byte)num20;
					num2 = 55;
					continue;
				case 184:
					num21 = 223 - 74;
					num2 = 224;
					continue;
				case 408:
					array[25] = (byte)num20;
					num2 = 277;
					continue;
				case 153:
					num20 = 129 - 43;
					num2 = 51;
					continue;
				case 285:
					array[9] = 220;
					num2 = 52;
					continue;
				case 119:
					array[4] = 92;
					num2 = 267;
					if (Uk())
					{
						continue;
					}
					break;
				case 322:
					array2[8] = 199;
					num2 = 317;
					continue;
				case 93:
					array[22] = (byte)num20;
					num = 367;
					break;
				case 243:
					array[10] = 84;
					num2 = 333;
					if (Uk())
					{
						continue;
					}
					break;
				case 78:
					num38 <<= 8;
					num2 = 70;
					if (Uk())
					{
						continue;
					}
					break;
				case 215:
					array[19] = 116;
					num2 = 269;
					continue;
				case 278:
					array[8] = 154;
					num2 = 204;
					if (S8() != null)
					{
						num2 = 139;
					}
					continue;
				case 134:
					if (num29 == num33 - 1)
					{
						num2 = 296;
						if (S8() == null)
						{
							continue;
						}
						break;
					}
					goto case 66;
				case 175:
					array[1] = (byte)num20;
					num2 = 220;
					continue;
				case 327:
					num20 = 152 - 50;
					num2 = 140;
					continue;
				case 358:
					array[14] = (byte)num20;
					num = 126;
					break;
				case 397:
					array2[0] = 108;
					num2 = 356;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 379:
					array2[15] = (byte)num21;
					num2 = 226;
					continue;
				case 419:
					array[7] = 158;
					num2 = 342;
					if (!Uk())
					{
						num2 = 316;
					}
					continue;
				case 7:
					num21 = 100 + 32;
					num = 401;
					break;
				case 160:
					num38 = 255u;
					num2 = 122;
					if (Uk())
					{
						num2 = 128;
					}
					continue;
				case 81:
					array2[13] = 115;
					num = 136;
					break;
				case 155:
					array[28] = (byte)num20;
					num2 = 151;
					continue;
				case 237:
					num36 = 0u;
					num2 = 230;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 386:
					return "";
				case 205:
					num36 += num35;
					num = 190;
					break;
				case 413:
					num20 = 95 + 7;
					num2 = 168;
					continue;
				case 317:
					num21 = 137 - 35;
					num2 = 88;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 21:
					array2[6] = 93;
					num2 = 106;
					if (S8() == null)
					{
						num2 = 334;
					}
					continue;
				case 273:
					array[12] = 211;
					num2 = 271;
					continue;
				case 341:
					array[22] = 128;
					num2 = 56;
					continue;
				case 252:
					array2[11] = 100;
					num2 = 234;
					continue;
				case 191:
					array[24] = (byte)num20;
					num = 373;
					break;
				case 13:
					array2[4] = (byte)num21;
					num2 = 96;
					if (S8() == null)
					{
						num2 = 428;
					}
					continue;
				case 71:
					num20 = 137 + 35;
					num = 345;
					break;
				case 217:
					array[0] = (byte)num20;
					num2 = 208;
					if (S8() == null)
					{
						num2 = 405;
					}
					continue;
				case 25:
					array2[13] = 121;
					num2 = 16;
					if (S8() == null)
					{
						num2 = 96;
					}
					continue;
				case 223:
					array2[1] = 89;
					num2 = 282;
					if (!Uk())
					{
						num2 = 181;
					}
					continue;
				case 333:
					num20 = 122 + 42;
					num2 = 125;
					continue;
				case 92:
					array[0] = (byte)num20;
					num2 = 231;
					continue;
				case 246:
					array2[1] = 188;
					num2 = 9;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 199:
					if (P_0 == -1)
					{
						num2 = 149;
						continue;
					}
					goto case 268;
				case 11:
					array[28] = 102;
					num2 = 16;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 286:
					num20 = 43 + 116;
					num2 = 74;
					continue;
				case 391:
					array[13] = 106;
					num2 = 64;
					if (Uk())
					{
						continue;
					}
					break;
				case 1:
					array2[4] = 170;
					num = 357;
					break;
				case 77:
					array[11] = (byte)num20;
					num2 = 384;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 251:
					array[6] = 152;
					num2 = 73;
					continue;
				case 200:
					if (num29 == num33 - 1)
					{
						num2 = 39;
						continue;
					}
					goto case 205;
				case 44:
					num30 = array6.Length / 4;
					num = 237;
					break;
				case 295:
					num20 = 79 + 82;
					num2 = 202;
					continue;
				case 350:
					array[27] = (byte)num20;
					num2 = 173;
					if (S8() != null)
					{
						num2 = 134;
					}
					continue;
				case 73:
					num20 = 76 - 5;
					num = 26;
					break;
				case 378:
					array2[8] = (byte)num21;
					num2 = 298;
					continue;
				case 307:
					array2[9] = (byte)num21;
					num2 = 85;
					continue;
				case 177:
					array[17] = (byte)num20;
					num2 = 132;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 290:
					array[20] = (byte)num20;
					num2 = 62;
					continue;
				case 270:
					num20 = 172 - 57;
					num = 92;
					break;
				case 380:
					num31 = 0u;
					num2 = 170;
					continue;
				case 107:
					num20 = 60 + 4;
					num = 79;
					break;
				case 133:
					array2[2] = (byte)num21;
					num2 = 35;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 216:
					num21 = 52 + 13;
					num2 = 183;
					continue;
				case 411:
					array[26] = 126;
					num2 = 301;
					continue;
				case 330:
					num20 = 115 + 84;
					num = 400;
					break;
				case 303:
					array2[5] = (byte)num21;
					num2 = 86;
					continue;
				case 225:
					stream.Close();
					num2 = 354;
					continue;
				case 208:
					num20 = 14 + 123;
					num2 = 61;
					if (!Uk())
					{
						num2 = 43;
					}
					continue;
				case 121:
					array[23] = 136;
					num2 = 412;
					continue;
				case 293:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 110;
					continue;
				case 214:
					num20 = 216 - 72;
					num2 = 374;
					if (Uk())
					{
						continue;
					}
					break;
				case 42:
					num20 = 215 - 71;
					num2 = 105;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 8:
					array[18] = (byte)num20;
					num2 = 332;
					if (Uk())
					{
						continue;
					}
					break;
				case 344:
					array3[num22 + 2] = (byte)((num23 & 0xFF0000) >> 16);
					num2 = 41;
					continue;
				case 233:
					num20 = 154 - 51;
					num = 155;
					break;
				case 111:
					array2[10] = (byte)num21;
					num2 = 98;
					continue;
				case 58:
					array[31] = 124;
					num2 = 176;
					continue;
				case 194:
					num21 = 4 + 17;
					num2 = 103;
					if (S8() != null)
					{
						num2 = 62;
					}
					continue;
				case 85:
					num21 = 200 - 66;
					num2 = 38;
					continue;
				case 258:
					array[19] = (byte)num20;
					num2 = 130;
					continue;
				case 83:
					array2[6] = (byte)num21;
					num2 = 32;
					continue;
				case 250:
					array2[1] = (byte)num21;
					num2 = 336;
					continue;
				case 245:
					num21 = 65 + 5;
					num2 = 227;
					if (S8() == null)
					{
						num2 = 307;
					}
					continue;
				case 46:
					array[28] = (byte)num20;
					num2 = 11;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 309:
					num21 = 182 - 60;
					num = 189;
					break;
				case 349:
					array2[2] = (byte)num21;
					num2 = 46;
					if (S8() == null)
					{
						num2 = 143;
					}
					continue;
				case 104:
					array[2] = (byte)num20;
					num2 = 166;
					continue;
				case 284:
					try
					{
						ns.vQ9Sfz();
						int num39 = 0;
						if (!Uk())
						{
							goto IL_18af;
						}
						goto IL_18b3;
						IL_18af:
						num39 = num40;
						goto IL_18b3;
						IL_18b3:
						do
						{
							switch (num39)
							{
							case 1:
								return result;
							}
							result = Encoding.Unicode.GetString(X27, P_0 + 4, count);
							num39 = 1;
						}
						while (S8() == null);
						goto IL_18af;
					}
					catch
					{
						int num41 = 0;
						if (!Uk())
						{
							num41 = 0;
						}
						switch (num41)
						{
						case 0:
							break;
						}
					}
					goto case 386;
				case 61:
					array[3] = (byte)num20;
					num2 = 228;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 9:
					num21 = 252 - 84;
					num2 = 164;
					continue;
				case 53:
					X27 = array3;
					num2 = 347;
					if (S8() != null)
					{
						num2 = 304;
					}
					continue;
				case 282:
					array2[1] = 153;
					num2 = 351;
					continue;
				case 263:
				case 426:
					if (num32 >= num25)
					{
						num2 = 163;
						continue;
					}
					goto case 313;
				case 325:
					num20 = 21 + 67;
					num2 = 281;
					continue;
				case 29:
					num21 = 176 - 58;
					num = 388;
					break;
				case 383:
					array[12] = (byte)num20;
					num2 = 273;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 305:
					array6[num26] ^= array4[num26];
					num2 = 420;
					continue;
				case 298:
					num21 = 61 + 43;
					num2 = 308;
					continue;
				case 182:
					array[28] = (byte)num20;
					num2 = 233;
					continue;
				case 50:
					array2[7] = (byte)num21;
					num2 = 94;
					continue;
				case 28:
					array2[11] = (byte)num21;
					num = 97;
					break;
				case 359:
					it.KDikMXewCI().Position = 0L;
					num2 = 366;
					continue;
				case 266:
					array[0] = 91;
					num2 = 153;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 279:
					num20 = 157 + 20;
					num2 = 63;
					if (S8() != null)
					{
						num2 = 54;
					}
					continue;
				case 257:
					num22 = num29 * 4;
					num2 = 422;
					continue;
				case 151:
					num20 = 96 + 64;
					num2 = 46;
					continue;
				case 287:
					array[16] = 162;
					num2 = 45;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 174:
					num20 = 122 + 3;
					num2 = 0;
					if (S8() == null)
					{
						num2 = 0;
					}
					continue;
				case 5:
					num21 = 97 - 16;
					num2 = 179;
					if (!Uk())
					{
						num2 = 150;
					}
					continue;
				case 122:
					array[29] = 166;
					num = 416;
					break;
				case 328:
					array3 = new byte[array5.Length];
					num2 = 44;
					if (Uk())
					{
						continue;
					}
					break;
				case 19:
					array4 = array2;
					num2 = 59;
					if (Uk())
					{
						num2 = 131;
					}
					continue;
				case 299:
					array2 = new byte[16];
					num2 = 296;
					if (Uk())
					{
						num2 = 329;
					}
					continue;
				case 362:
					array2[9] = 91;
					num2 = 425;
					continue;
				case 405:
					num20 = 14 + 117;
					num2 = 283;
					if (S8() != null)
					{
						num2 = 261;
					}
					continue;
				case 372:
					array4[3] = publicKeyToken[1];
					num2 = 376;
					continue;
				case 424:
					array[3] = 132;
					num2 = 157;
					if (S8() == null)
					{
						num2 = 208;
					}
					continue;
				case 388:
					array2[12] = (byte)num21;
					num2 = 151;
					if (Uk())
					{
						num2 = 188;
					}
					continue;
				case 351:
					array2[1] = 140;
					num2 = 319;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 375:
					array2[15] = (byte)num21;
					num2 = 59;
					if (S8() == null)
					{
						num2 = 106;
					}
					continue;
				case 377:
					num21 = 111 + 22;
					num2 = 133;
					continue;
				case 150:
					array[30] = (byte)num20;
					num2 = 364;
					continue;
				case 281:
					array[24] = (byte)num20;
					num = 395;
					break;
				case 146:
					array4[7] = publicKeyToken[3];
					num2 = 148;
					continue;
				case 227:
					num20 = 24 + 15;
					num2 = 195;
					continue;
				case 302:
					array[2] = (byte)num20;
					num2 = 71;
					continue;
				case 306:
					array2[7] = 123;
					num2 = 178;
					continue;
				case 301:
					array[26] = 177;
					num2 = 29;
					if (Uk())
					{
						num2 = 157;
					}
					continue;
				case 268:
					num25 = array5.Length % 4;
					num2 = 418;
					continue;
				case 211:
					num35 = (uint)((array6[num34 + 3] << 24) | (array6[num34 + 2] << 16) | (array6[num34 + 1] << 8) | array6[num34]);
					num2 = 160;
					if (!Uk())
					{
						num2 = 103;
					}
					continue;
				case 135:
					num20 = 28 + 96;
					num = 34;
					break;
				case 148:
					array4[9] = publicKeyToken[4];
					num2 = 172;
					continue;
				case 33:
					array[25] = 117;
					num2 = 393;
					continue;
				case 213:
					array[30] = 230;
					num2 = 135;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 102:
					array[1] = (byte)num20;
					num2 = 294;
					continue;
				case 118:
					array[16] = 106;
					num2 = 398;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 421:
					num36 = 0u;
					num2 = 159;
					continue;
				case 105:
					array[31] = (byte)num20;
					num2 = 152;
					continue;
				case 87:
					array[22] = 122;
					num = 341;
					break;
				case 126:
					num20 = 34 + 106;
					num2 = 112;
					continue;
				case 181:
					num20 = 206 + 46;
					num2 = 217;
					continue;
				case 272:
					num20 = 226 - 75;
					num2 = 177;
					if (Uk())
					{
						continue;
					}
					break;
				case 354:
					cryptoStream.Close();
					num2 = 291;
					continue;
				case 385:
					array[3] = 96;
					num2 = 424;
					continue;
				case 162:
					if (publicKeyToken != null)
					{
						num = 115;
						break;
					}
					goto case 68;
				case 115:
					if (publicKeyToken.Length > 0)
					{
						num2 = 196;
						continue;
					}
					goto case 68;
				case 342:
					num20 = 16 + 55;
					num2 = 326;
					continue;
				case 172:
					array4[11] = publicKeyToken[5];
					num2 = 343;
					if (Uk())
					{
						continue;
					}
					break;
				case 297:
					array[5] = 29;
					num2 = 69;
					continue;
				case 80:
					array2[2] = (byte)num21;
					num = 318;
					break;
				case 32:
					num21 = 94 + 28;
					num2 = 316;
					if (!Uk())
					{
						num2 = 309;
					}
					continue;
				case 202:
					array[4] = (byte)num20;
					num2 = 107;
					continue;
				case 308:
					array2[8] = (byte)num21;
					num2 = 152;
					if (Uk())
					{
						num2 = 322;
					}
					continue;
				case 6:
					num32 = 0;
					num2 = 87;
					if (S8() == null)
					{
						num2 = 263;
					}
					continue;
				case 387:
					array2[6] = 39;
					num2 = 127;
					continue;
				case 416:
					num20 = 138 - 46;
					num2 = 45;
					if (S8() == null)
					{
						num2 = 150;
					}
					continue;
				case 163:
				case 394:
					num29++;
					num2 = 370;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 369:
					array[29] = (byte)num20;
					num2 = 122;
					continue;
				case 283:
					array[1] = (byte)num20;
					num2 = 17;
					continue;
				case 62:
					num20 = 195 - 65;
					num2 = 253;
					continue;
				case 173:
					array[27] = 91;
					num2 = 12;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 242:
					num31 = (uint)((array5[num34 + 3] << 24) | (array5[num34 + 2] << 16) | (array5[num34 + 1] << 8) | array5[num34]);
					num2 = 249;
					continue;
				case 316:
					array2[6] = (byte)num21;
					num = 21;
					break;
				case 192:
					array[1] = (byte)num20;
					num2 = 141;
					continue;
				case 89:
					array[7] = 144;
					num2 = 413;
					if (Uk())
					{
						continue;
					}
					break;
				case 154:
					num20 = 43 + 102;
					num2 = 175;
					continue;
				case 138:
					num20 = 188 + 14;
					num2 = 77;
					if (Uk())
					{
						continue;
					}
					break;
				case 300:
					num34 = 0u;
					num2 = 241;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 304:
					num20 = 184 - 61;
					num2 = 129;
					continue;
				case 190:
					num34 = (uint)num22;
					num2 = 242;
					continue;
				case 201:
					array[12] = (byte)num20;
					num2 = 371;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 88:
					array2[8] = (byte)num21;
					num2 = 7;
					continue;
				case 76:
					array[11] = (byte)num20;
					num2 = 20;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 353:
					num20 = 37 + 55;
					num2 = 369;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 197:
					array[30] = (byte)num20;
					num2 = 396;
					if (!Uk())
					{
						num2 = 361;
					}
					continue;
				case 149:
					symmetricAlgorithm = Jb();
					num2 = 180;
					continue;
				case 207:
					stream = z29();
					num2 = 293;
					continue;
				case 356:
					num21 = 97 + 38;
					num2 = 137;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 55:
					num20 = 125 - 72;
					num = 254;
					break;
				case 108:
					array[30] = 214;
					num2 = 42;
					continue;
				case 196:
					array4[1] = publicKeyToken[0];
					num2 = 372;
					if (Uk())
					{
						continue;
					}
					break;
				case 289:
					array2[3] = (byte)num21;
					num2 = 331;
					continue;
				case 26:
					array[6] = (byte)num20;
					num2 = 314;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 425:
					array2[9] = 230;
					num2 = 5;
					continue;
				case 384:
					array[12] = 57;
					num2 = 27;
					continue;
				case 98:
					array2[10] = 164;
					num = 144;
					break;
				case 222:
					it.GII();
					num2 = 259;
					continue;
				case 336:
					num21 = 95 + 9;
					num2 = 349;
					if (S8() != null)
					{
						num2 = 17;
					}
					continue;
				case 3:
					array[5] = 116;
					num2 = 297;
					continue;
				case 365:
					array2[3] = (byte)num21;
					num = 262;
					break;
				case 240:
					array2[7] = (byte)num21;
					num2 = 306;
					continue;
				case 324:
					array[20] = 79;
					num2 = 198;
					if (S8() == null)
					{
						num2 = 339;
					}
					continue;
				case 52:
					num20 = 145 + 73;
					num2 = 392;
					continue;
				case 319:
					num21 = 101 - 93;
					num2 = 250;
					continue;
				case 179:
					array2[9] = (byte)num21;
					num2 = 232;
					continue;
				case 206:
					array[15] = 118;
					num2 = 113;
					continue;
				case 373:
					num20 = 162 - 54;
					num2 = 408;
					continue;
				case 256:
					num20 = 203 - 67;
					num2 = 182;
					continue;
				case 404:
					array[0] = (byte)num20;
					num2 = 266;
					continue;
				case 139:
					num20 = 208 - 69;
					num2 = 302;
					continue;
				case 360:
					num20 = 243 - 81;
					num2 = 310;
					continue;
				case 39:
					if (num25 > 0)
					{
						num2 = 142;
						continue;
					}
					goto case 205;
				case 345:
					array[2] = (byte)num20;
					num2 = 385;
					if (Uk())
					{
						continue;
					}
					break;
				case 37:
					num31 |= array5[array5.Length - (1 + num24)];
					num2 = 235;
					continue;
				case 91:
					array[23] = 127;
					num2 = 286;
					continue;
				case 140:
					array[1] = (byte)num20;
					num2 = 154;
					continue;
				case 43:
					array4[15] = publicKeyToken[7];
					num2 = 68;
					continue;
				case 320:
					num21 = 86 + 85;
					num2 = 335;
					continue;
				case 220:
					array[2] = 103;
					num2 = 363;
					continue;
				case 156:
					array3[num22 + 1] = (byte)((num23 & 0xFF00) >> 8);
					num2 = 344;
					continue;
				case 334:
					num21 = 59 + 69;
					num = 417;
					break;
				case 393:
					array[26] = 42;
					num = 411;
					break;
				case 103:
					array2[11] = (byte)num21;
					num2 = 309;
					continue;
				case 16:
					array[29] = 154;
					num2 = 353;
					if (Uk())
					{
						continue;
					}
					break;
				case 67:
					array[27] = (byte)num20;
					num2 = 276;
					continue;
				case 94:
					array2[7] = 138;
					num2 = 178;
					if (S8() == null)
					{
						num2 = 184;
					}
					continue;
				case 75:
					array2[0] = (byte)num21;
					num2 = 288;
					if (S8() == null)
					{
						num2 = 397;
					}
					continue;
				case 406:
					num21 = 158 - 52;
					num2 = 240;
					continue;
				case 407:
					num21 = 144 - 32;
					num2 = 80;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 229:
					array2[14] = (byte)num21;
					num2 = 161;
					if (!Uk())
					{
						num2 = 150;
					}
					continue;
				case 253:
					array[21] = (byte)num20;
					num2 = 338;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 313:
					if (num32 > 0)
					{
						num2 = 78;
						if (Uk())
						{
							continue;
						}
						break;
					}
					goto case 193;
				case 27:
					array[12] = 108;
					num2 = 312;
					if (Uk())
					{
						continue;
					}
					break;
				case 260:
					num20 = 136 + 6;
					num = 31;
					break;
				case 169:
					array2[11] = (byte)num21;
					num2 = 194;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 340:
					num37 = num36 ^ num31;
					num = 6;
					break;
				case 36:
					array[19] = (byte)num20;
					num2 = 399;
					continue;
				case 275:
					num21 = 89 - 26;
					num2 = 95;
					continue;
				case 326:
					array[7] = (byte)num20;
					num2 = 89;
					continue;
				case 24:
					num20 = 132 - 44;
					num2 = 104;
					if (Uk())
					{
						continue;
					}
					break;
				case 193:
					array3[num22 + num32] = (byte)((num37 & num38) >> num27);
					num2 = 90;
					continue;
				case 86:
					array2[5] = 181;
					num2 = 158;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 125:
					array[10] = (byte)num20;
					num2 = 123;
					if (Uk())
					{
						continue;
					}
					break;
				case 420:
					num26++;
					num = 186;
					break;
				case 143:
					array2[2] = 34;
					num = 348;
					break;
				case 10:
					num20 = 177 - 59;
					num2 = 65;
					continue;
				case 106:
					array2[15] = 91;
					num = 19;
					break;
				case 415:
					array[19] = 145;
					num2 = 59;
					continue;
				case 189:
					array2[11] = (byte)num21;
					num2 = 252;
					continue;
				case 382:
					array[10] = 125;
					num2 = 214;
					continue;
				case 310:
					array[0] = (byte)num20;
					num2 = 181;
					continue;
				case 429:
					num20 = 183 + 35;
					num2 = 8;
					continue;
				case 145:
					array[15] = (byte)num20;
					num2 = 368;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 400:
					array[10] = (byte)num20;
					num2 = 304;
					continue;
				default:
					array[24] = (byte)num20;
					num2 = 261;
					continue;
				case 428:
					num21 = 117 + 120;
					num = 303;
					break;
				case 132:
					array[17] = 126;
					num2 = 260;
					continue;
				case 112:
					array[14] = (byte)num20;
					num = 409;
					break;
				case 396:
					num20 = 52 + 57;
					num = 355;
					break;
				case 355:
					array[30] = (byte)num20;
					num2 = 213;
					if (Uk())
					{
						continue;
					}
					break;
				case 70:
					num27 += 8;
					num2 = 193;
					continue;
				case 264:
					array2[4] = 157;
					num2 = 4;
					continue;
				case 188:
					num21 = 108 + 46;
					num2 = 54;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 79:
					array[5] = (byte)num20;
					num2 = 3;
					if (!Uk())
					{
						num2 = 2;
					}
					continue;
				case 401:
					array2[9] = (byte)num21;
					num2 = 245;
					continue;
				case 212:
				case 249:
					num4 = num36;
					num2 = 421;
					continue;
				case 64:
					num20 = 217 - 72;
					num2 = 358;
					continue;
				case 45:
					array[16] = 91;
					num2 = 118;
					continue;
				case 142:
					num31 = 0u;
					num2 = 82;
					continue;
				case 120:
					num21 = 128 - 42;
					num2 = 28;
					if (Uk())
					{
						continue;
					}
					break;
				case 167:
					array[15] = 226;
					num2 = 41;
					if (S8() == null)
					{
						num2 = 287;
					}
					continue;
				case 54:
					array2[12] = (byte)num21;
					num2 = 320;
					continue;
				case 158:
					array2[5] = 84;
					num2 = 165;
					continue;
				case 346:
					array2[14] = (byte)num21;
					num2 = 99;
					if (Uk())
					{
						continue;
					}
					break;
				case 417:
					array2[6] = (byte)num21;
					num2 = 387;
					continue;
				case 395:
					num20 = 187 - 98;
					num2 = 191;
					continue;
				case 367:
					array[22] = 102;
					num2 = 279;
					if (Uk())
					{
						continue;
					}
					break;
				case 65:
					array[14] = (byte)num20;
					num2 = 265;
					continue;
				case 231:
					num20 = 104 + 88;
					num2 = 25;
					if (S8() == null)
					{
						num2 = 404;
					}
					continue;
				case 311:
					num20 = 109 + 94;
					num2 = 14;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 66:
					num23 = num36 ^ num31;
					num = 427;
					break;
				case 157:
					num20 = 41 + 55;
					num2 = 350;
					continue;
				case 165:
					array2[5] = 100;
					num2 = 280;
					continue;
				case 82:
					num36 += num35;
					num = 22;
					break;
				case 168:
					array[8] = (byte)num20;
					num2 = 30;
					continue;
				case 185:
					num20 = 193 + 7;
					num2 = 290;
					if (S8() != null)
					{
						num2 = 102;
					}
					continue;
				case 161:
					array2[15] = 120;
					num2 = 403;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 137:
					array2[0] = (byte)num21;
					num2 = 275;
					if (S8() != null)
					{
						num2 = 39;
					}
					continue;
				case 127:
					num21 = 136 - 45;
					num2 = 50;
					continue;
				case 321:
					array[31] = (byte)num20;
					num2 = 58;
					if (S8() != null)
					{
						num2 = 35;
					}
					continue;
				case 17:
					num20 = 6 + 26;
					num2 = 102;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 357:
					num21 = 176 - 58;
					num2 = 109;
					continue;
				case 366:
					array5 = it.k2z((int)it.KDikMXewCI().Length);
					num2 = 222;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 34:
					array[30] = (byte)num20;
					num2 = 108;
					continue;
				case 171:
					array2[11] = (byte)num21;
					num2 = 238;
					continue;
				case 59:
					num20 = 151 - 92;
					num2 = 258;
					continue;
				case 109:
					array2[4] = (byte)num21;
					num2 = 323;
					continue;
				case 166:
					array[2] = 61;
					num2 = 139;
					continue;
				case 178:
					num21 = 215 - 71;
					num2 = 378;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 230:
					num35 = 0u;
					num2 = 380;
					continue;
				case 232:
					array2[10] = 163;
					num2 = 414;
					continue;
				case 68:
					num26 = 0;
					num2 = 101;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 23:
					num20 = 64 + 110;
					num2 = 100;
					continue;
				case 49:
					if (X27.Length == 0)
					{
						num2 = 48;
						if (!Uk())
						{
							num2 = 25;
						}
						continue;
					}
					goto case 347;
				case 20:
					array[11] = 112;
					num2 = 138;
					continue;
				case 144:
					array2[10] = 54;
					num2 = 120;
					continue;
				case 31:
					array[17] = (byte)num20;
					num2 = 239;
					continue;
				case 381:
					array2[13] = (byte)num21;
					num2 = 25;
					if (Uk())
					{
						continue;
					}
					break;
				case 209:
					num33++;
					num = 300;
					break;
				case 74:
					array[23] = (byte)num20;
					num2 = 121;
					if (Uk())
					{
						continue;
					}
					break;
				case 261:
					array[24] = 103;
					num = 124;
					break;
				case 69:
					array[6] = 93;
					num2 = 251;
					continue;
				case 241:
					num29 = 0;
					num2 = 187;
					continue;
				case 221:
					num21 = 95 + 48;
					num2 = 365;
					if (S8() != null)
					{
						num2 = 114;
					}
					continue;
				case 90:
					num32++;
					num2 = 426;
					continue;
				case 323:
					array2[4] = 104;
					num2 = 292;
					continue;
				case 368:
					array[15] = 123;
					num2 = 167;
					continue;
				case 114:
					num21 = 31 + 90;
					num2 = 280;
					if (Uk())
					{
						num2 = 346;
					}
					continue;
				case 48:
					it = new It(z2V.GetManifestResourceStream("JmnN8pF2QG6wo9V3NU.0lAEYrRe3GPKVv7fgZ"));
					num2 = 359;
					continue;
				case 348:
					num21 = 52 + 73;
					num2 = 274;
					continue;
				case 110:
					cryptoStream.Write(array5, 0, array5.Length);
					num2 = 255;
					continue;
				case 123:
					array[10] = 74;
					num2 = 382;
					if (S8() != null)
					{
						num2 = 117;
					}
					continue;
				case 398:
					num20 = 84 + 106;
					num2 = 117;
					continue;
				case 247:
					array[1] = (byte)num20;
					num2 = 327;
					if (Uk())
					{
						continue;
					}
					break;
				case 427:
					array3[num22] = (byte)(num23 & 0xFF);
					num2 = 156;
					continue;
				case 47:
					num20 = 150 - 50;
					num2 = 54;
					if (S8() == null)
					{
						num2 = 76;
					}
					continue;
				case 183:
					array2[3] = (byte)num21;
					num2 = 288;
					continue;
				case 234:
					num21 = 156 - 118;
					num2 = 171;
					if (Uk())
					{
						continue;
					}
					break;
				case 224:
					array2[7] = (byte)num21;
					num2 = 57;
					if (!Uk())
					{
						num2 = 3;
					}
					continue;
				case 136:
					num21 = 132 - 44;
					num2 = 381;
					continue;
				case 343:
					array4[13] = publicKeyToken[6];
					num2 = 43;
					continue;
				case 203:
					num21 = 248 - 82;
					num = 111;
					break;
				case 204:
					array[9] = 86;
					num2 = 285;
					continue;
				case 296:
					if (num25 > 0)
					{
						num2 = 340;
						continue;
					}
					goto case 66;
				case 409:
					array[14] = 110;
					num2 = 10;
					if (!Uk())
					{
						num2 = 9;
					}
					continue;
				case 376:
					array4[5] = publicKeyToken[2];
					num2 = 50;
					if (Uk())
					{
						num2 = 146;
					}
					continue;
				case 12:
					num20 = 134 - 44;
					num2 = 67;
					continue;
				case 294:
					num20 = 138 - 46;
					num2 = 192;
					if (S8() != null)
					{
						num2 = 147;
					}
					continue;
				case 363:
					num20 = 144 - 48;
					num = 40;
					break;
				case 124:
					array[24] = 174;
					num2 = 325;
					continue;
				case 35:
					array2[2] = 124;
					num2 = 407;
					if (!Uk())
					{
						num2 = 322;
					}
					continue;
				case 318:
					num21 = 19 + 75;
					num2 = 236;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 235:
					num24++;
					num = 72;
					break;
				case 291:
					array5 = X27;
					num2 = 268;
					if (S8() != null)
					{
						num2 = 238;
					}
					continue;
				case 267:
					array[4] = 34;
					num2 = 295;
					if (!Uk())
					{
						num2 = 113;
					}
					continue;
				case 2:
					array[8] = (byte)num20;
					num2 = 278;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 198:
					num28 = num29 % num30;
					num2 = 257;
					if (Uk())
					{
						continue;
					}
					break;
				case 280:
					num21 = 217 + 33;
					num2 = 410;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 412:
					array[23] = 40;
					num2 = 174;
					continue;
				case 219:
					array2[4] = (byte)num21;
					num2 = 1;
					if (S8() != null)
					{
						num2 = 0;
					}
					continue;
				case 371:
					array[13] = 139;
					num2 = 311;
					if (Uk())
					{
						continue;
					}
					break;
				case 292:
					num21 = 113 - 58;
					num2 = 13;
					if (Uk())
					{
						continue;
					}
					break;
				case 101:
				case 186:
					if (num26 >= array4.Length)
					{
						num2 = 199;
						if (!Uk())
						{
							num2 = 103;
						}
						continue;
					}
					goto case 305;
				case 72:
				case 315:
					if (num24 >= num25)
					{
						num2 = 212;
						continue;
					}
					goto case 210;
				case 239:
					num20 = 28 + 110;
					num2 = 361;
					if (S8() != null)
					{
						num2 = 222;
					}
					continue;
				case 100:
					array[3] = (byte)num20;
					num2 = 423;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 180:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 248;
					if (!Uk())
					{
						num2 = 203;
					}
					continue;
				case 244:
					array2[3] = (byte)num21;
					num = 216;
					break;
				case 141:
					num20 = 183 - 61;
					num2 = 247;
					continue;
				case 347:
					count = BitConverter.ToInt32(X27, P_0);
					num2 = 284;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 218:
					array[14] = (byte)num20;
					num2 = 206;
					continue;
				case 22:
					num24 = 0;
					num2 = 315;
					continue;
				case 152:
					num20 = 98 + 74;
					num2 = 321;
					continue;
				case 41:
					array3[num22 + 3] = (byte)((num23 & 0xFF000000u) >> 24);
					num2 = 394;
					continue;
				case 56:
					num20 = 84 + 111;
					num2 = 87;
					if (S8() == null)
					{
						num2 = 93;
					}
					continue;
				case 262:
					num21 = 172 - 57;
					num2 = 244;
					if (!Uk())
					{
						num2 = 226;
					}
					continue;
				case 399:
					num20 = 212 - 70;
					num2 = 147;
					continue;
				case 269:
					num20 = 56 + 80;
					num2 = 36;
					continue;
				case 15:
					array[18] = 102;
					num2 = 429;
					continue;
				case 335:
					array2[13] = (byte)num21;
					num2 = 390;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 332:
					array[19] = 152;
					num2 = 215;
					continue;
				case 274:
					array2[2] = (byte)num21;
					num2 = 377;
					if (S8() == null)
					{
						continue;
					}
					break;
				case 95:
					array2[0] = (byte)num21;
					num2 = 246;
					continue;
				case 159:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 383789269u;
					uint num7 = 1712557283u;
					uint num8 = 1648953462u;
					uint num9 = num5;
					uint num10 = 472672088u;
					uint num11 = 2104576106u;
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
					num2 = 352;
					continue;
				}
				}
				break;
			}
		}
	}

	[io(typeof(io.Ki<object>[]))]
	internal static string lr(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int GR()
	{
		return 5;
	}

	private static void Dk()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate ia(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object Vc(object P_0)
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
	public static extern IntPtr jz(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr V2Z(IntPtr P_0, string P_1);

	private static IntPtr L22(IntPtr P_0, string P_1, uint P_2)
	{
		if (k2u == null)
		{
			IntPtr ptr = V2Z(umLocehuEC(), "Find ".Trim() + "ResourceA");
			k2u = (kE)Marshal.GetDelegateForFunctionPointer(ptr, typeof(kE));
		}
		return k2u(P_0, P_1, P_2);
	}

	private static IntPtr L2I(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (J26 == null)
		{
			IntPtr ptr = V2Z(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			J26 = (sO)Marshal.GetDelegateForFunctionPointer(ptr, typeof(sO));
		}
		return J26(P_0, P_1, P_2, P_3);
	}

	private static int O2g(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (q2B == null)
		{
			IntPtr ptr = V2Z(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			q2B = (uF)Marshal.GetDelegateForFunctionPointer(ptr, typeof(uF));
		}
		return q2B(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int W2N(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (M2v == null)
		{
			IntPtr ptr = V2Z(umLocehuEC(), "Virtual ".Trim() + "Protect");
			M2v = (rU)Marshal.GetDelegateForFunctionPointer(ptr, typeof(rU));
		}
		return M2v(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr U2o(uint P_0, int P_1, uint P_2)
	{
		if (s2n == null)
		{
			IntPtr ptr = V2Z(umLocehuEC(), "Open ".Trim() + "Process");
			s2n = (DA)Marshal.GetDelegateForFunctionPointer(ptr, typeof(DA));
		}
		return s2n(P_0, P_1, P_2);
	}

	private static int z2i(IntPtr P_0)
	{
		if (l2r == null)
		{
			IntPtr ptr = V2Z(umLocehuEC(), "Close ".Trim() + "Handle");
			l2r = (SX)Marshal.GetDelegateForFunctionPointer(ptr, typeof(SX));
		}
		return l2r(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (r2R == IntPtr.Zero)
		{
			r2R = jz("kernel ".Trim() + "32.dll");
		}
		return r2R;
	}

	[io(typeof(io.Ki<object>[]))]
	private static byte[] c2Y(string P_0)
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

	internal static Stream z29()
	{
		return new MemoryStream();
	}

	internal static byte[] w2L(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[io(typeof(io.Ki<object>[]))]
	private static byte[] H2d(byte[] P_0)
	{
		Stream stream = z29();
		SymmetricAlgorithm symmetricAlgorithm = Jb();
		symmetricAlgorithm.Key = new byte[32]
		{
			8, 122, 137, 116, 33, 67, 214, 140, 71, 132,
			120, 237, 17, 4, 205, 163, 43, 223, 174, 215,
			13, 65, 15, 205, 149, 69, 124, 236, 198, 73,
			232, 233
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			110, 114, 31, 169, 5, 199, 138, 105, 80, 244,
			159, 149, 12, 113, 172, 177
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = w2L(stream);
		ns.vQ9Sfz();
		return result;
	}

	private byte[] i28()
	{
		return null;
	}

	private byte[] w2t()
	{
		return null;
	}

	private byte[] E2E()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] m2O()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] A2F()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] n2U()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] T2A()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] b2X()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Y2Q()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] o2s()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool Uk()
	{
		return (object)null == null;
	}

	internal static object S8()
	{
		return null;
	}
}
