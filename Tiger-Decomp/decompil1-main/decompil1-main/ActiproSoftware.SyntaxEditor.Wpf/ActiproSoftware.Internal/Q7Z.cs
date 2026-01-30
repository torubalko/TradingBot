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

internal class Q7Z
{
	private delegate void x7E(object o);

	internal class a7X : Attribute
	{
		internal class N71<I79>
		{
			private static object Iis;

			public N71()
			{
				grA.DaB7cz();
				base._002Ector();
			}

			internal static bool TiP()
			{
				return Iis == null;
			}

			internal static object Dio()
			{
				return Iis;
			}
		}

		[a7X(typeof(N71<object>[]))]
		public a7X(object P_0)
		{
		}
	}

	internal class j72
	{
		[a7X(typeof(a7X.N71<object>[]))]
		internal static string G2J(string P_0, string P_1)
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
			byte[] iV = lqk(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = fqr();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint T7f(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Q76();

	internal struct j7e
	{
		internal bool M2t;

		internal byte[] s2Z;
	}

	internal class u7J
	{
		private BinaryReader l7W;

		public u7J(Stream P_0)
		{
			l7W = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return l7W.BaseStream;
		}

		internal byte[] m2h(int P_0)
		{
			return l7W.ReadBytes(P_0);
		}

		internal int M2N(byte[] P_0, int P_1, int P_2)
		{
			return l7W.Read(P_0, P_1, P_2);
		}

		internal int a2d()
		{
			return l7W.ReadInt32();
		}

		internal void W2z()
		{
			l7W.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr e7W(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr C78(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int W7j(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int A7q(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Y7z(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int qrS(IntPtr ptr);

	[Flags]
	private enum HrT
	{

	}

	private static bool A2F;

	private static bool s23;

	internal static RSACryptoServiceProvider Y2Y;

	private static Dictionary<int, int> o24;

	private static object g2o;

	private static byte[] f2w;

	internal static T7f O20;

	private static long t2V;

	private static IntPtr W29;

	internal static Hashtable J2q;

	private static bool w2n;

	private static byte[] N2R;

	private static bool I2s;

	private static uint[] x21;

	private static int r2I;

	private static qrS Q2O;

	private static bool k2C;

	private static byte[] t2j;

	private static int p2S;

	private static A7q P2p;

	private static int[] f2T;

	private static IntPtr P2H;

	internal static Assembly N2u;

	private static SortedList D28;

	private static W7j a2i;

	private static int M2L;

	internal static T7f g2B;

	private static Y7z G2M;

	private static e7W v22;

	[a7X(typeof(a7X.N71<object>[]))]
	private static bool P2y;

	private static bool c2k;

	private static C78 T27;

	private static IntPtr e26;

	private static long I25;

	private static object h2b;

	private static IntPtr d2U;

	private static int V2r;

	static Q7Z()
	{
		k2C = false;
		N2u = typeof(Q7Z).Assembly;
		x21 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		A2F = false;
		s23 = false;
		N2R = new byte[0];
		Y2Y = null;
		o24 = null;
		g2o = new object();
		t2j = new byte[0];
		f2w = new byte[0];
		e26 = IntPtr.Zero;
		P2H = IntPtr.Zero;
		h2b = new string[0];
		f2T = new int[0];
		M2L = 1;
		w2n = false;
		D28 = new SortedList();
		r2I = 0;
		I25 = 0L;
		O20 = null;
		g2B = null;
		t2V = 0L;
		V2r = 0;
		I2s = false;
		c2k = false;
		p2S = 0;
		W29 = IntPtr.Zero;
		P2y = false;
		J2q = new Hashtable();
		v22 = null;
		T27 = null;
		a2i = null;
		P2p = null;
		G2M = null;
		Q2O = null;
		d2U = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void daB7cl()
	{
	}

	internal static byte[] rqn(byte[] P_0)
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
			Iq8(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			Iq8(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			Iq8(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			Iq8(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			Iq8(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			Iq8(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			Iq8(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			Iq8(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			Iq8(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			Iq8(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			Iq8(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			Iq8(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			Iq8(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			Iq8(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			Iq8(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			Iq8(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			aqI(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			aqI(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			aqI(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			aqI(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			aqI(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			aqI(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			aqI(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			aqI(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			aqI(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			aqI(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			aqI(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			aqI(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			aqI(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			aqI(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			aqI(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			aqI(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			tq5(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			tq5(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			tq5(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			tq5(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			tq5(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			tq5(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			tq5(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			tq5(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			tq5(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			tq5(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			tq5(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			tq5(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			tq5(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			tq5(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			tq5(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			tq5(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			kq0(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			kq0(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			kq0(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			kq0(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			kq0(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			kq0(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			kq0(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			kq0(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			kq0(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			kq0(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			kq0(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			kq0(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			kq0(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			kq0(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			kq0(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			kq0(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void Iq8(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + gqB(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + x21[P_6 - 1], P_5);
	}

	private static void aqI(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + gqB(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + x21[P_6 - 1], P_5);
	}

	private static void tq5(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + gqB(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + x21[P_6 - 1], P_5);
	}

	private static void kq0(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + gqB(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + x21[P_6 - 1], P_5);
	}

	private static uint gqB(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool TqV()
	{
		if (!A2F)
		{
			eqs();
			A2F = true;
		}
		return s23;
	}

	internal static SymmetricAlgorithm fqr()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (TqV())
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

	internal static void eqs()
	{
		try
		{
			s23 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] lqk(byte[] P_0)
	{
		if (!TqV())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return rqn(P_0);
	}

	internal static void OqS(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			Kq9(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void Kq9(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint zqy(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	public static void eqq(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (o24 == null)
			{
				lock (g2o)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Q7Z).Assembly.GetManifestResourceStream("uICPkMbUKVn57FG0To.yOK4voqLXY72npHigl"));
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
							num3 += eqi(num3);
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
						u7J u7J = new u7J(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = u7J.a2d();
							int value = u7J.a2d();
							dictionary.Add(key, value);
						}
						u7J.W2z();
					}
					o24 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = o24[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(Q7Z).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint Cq7(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint eqi(uint P_0)
	{
		return 0u;
	}

	internal static void jqp()
	{
	}

	[a7X(typeof(a7X.N71<object>[]))]
	internal static string tqM(int P_0)
	{
		int num = 78;
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num21 = default(int);
		byte[] array4 = default(byte[]);
		int num37 = default(int);
		uint num38 = default(uint);
		byte[] array6 = default(byte[]);
		int num22 = default(int);
		byte[] array3 = default(byte[]);
		int num20 = default(int);
		int num29 = default(int);
		int num23 = default(int);
		int num25 = default(int);
		int num24 = default(int);
		uint num4 = default(uint);
		uint num27 = default(uint);
		int num26 = default(int);
		int num30 = default(int);
		uint num36 = default(uint);
		int count = default(int);
		byte[] publicKeyToken = default(byte[]);
		int num32 = default(int);
		uint num31 = default(uint);
		byte[] array5 = default(byte[]);
		uint num43 = default(uint);
		uint num28 = default(uint);
		int num33 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		CryptoStream cryptoStream = default(CryptoStream);
		string result = default(string);
		int num40 = default(int);
		int num42 = default(int);
		int num34 = default(int);
		Stream stream = default(Stream);
		u7J u7J = default(u7J);
		uint num35 = default(uint);
		ICryptoTransform transform = default(ICryptoTransform);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 57:
					array[8] = 129;
					num = 224;
					break;
				case 87:
					array2[29] = 11;
					num2 = 348;
					continue;
				case 386:
					num21 = 131 - 43;
					num2 = 168;
					continue;
				case 413:
					array2[3] = 116;
					num2 = 35;
					continue;
				case 127:
					array4[num37 + 2] = (byte)((num38 & 0xFF0000) >> 16);
					num2 = 408;
					continue;
				case 288:
					num21 = 134 - 44;
					num2 = 100;
					if (SG() != null)
					{
						num2 = 96;
					}
					continue;
				case 397:
					array6[num22] ^= array3[num22];
					num2 = 200;
					continue;
				case 344:
					array2[21] = (byte)num21;
					num2 = 86;
					if (!MS())
					{
						num2 = 4;
					}
					continue;
				case 239:
					array[4] = (byte)num20;
					num2 = 5;
					if (SG() == null)
					{
						num2 = 19;
					}
					continue;
				case 361:
					num21 = 76 + 86;
					num2 = 64;
					continue;
				case 297:
					num21 = 149 - 109;
					num2 = 274;
					continue;
				case 103:
					num21 = 220 + 0;
					num2 = 244;
					if (MS())
					{
						continue;
					}
					break;
				case 101:
					num21 = 238 - 79;
					num2 = 106;
					if (SG() != null)
					{
						num2 = 46;
					}
					continue;
				case 271:
					array2[18] = (byte)num21;
					num2 = 333;
					continue;
				case 241:
					array4[num37 + 1] = (byte)((num38 & 0xFF00) >> 8);
					num2 = 127;
					if (MS())
					{
						continue;
					}
					break;
				case 204:
					array[14] = 172;
					num2 = 173;
					continue;
				case 209:
					array2[10] = 249;
					num2 = 119;
					continue;
				case 313:
					array[1] = (byte)num20;
					num2 = 418;
					continue;
				case 307:
					array[2] = (byte)num29;
					num2 = 183;
					continue;
				case 52:
					array[10] = (byte)num29;
					num2 = 360;
					continue;
				case 154:
					num20 = 203 - 67;
					num2 = 43;
					if (SG() == null)
					{
						num2 = 97;
					}
					continue;
				case 79:
					num21 = 2 + 25;
					num2 = 366;
					continue;
				case 95:
					num37 = num23 * 4;
					num2 = 243;
					if (SG() != null)
					{
						num2 = 94;
					}
					continue;
				case 191:
					num25 = 0;
					num2 = 44;
					continue;
				case 224:
					num29 = 39 + 97;
					num2 = 197;
					if (!MS())
					{
						num2 = 123;
					}
					continue;
				case 391:
					if (num23 == num24 - 1)
					{
						num2 = 7;
						if (SG() == null)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 15;
				case 219:
					array[4] = (byte)num20;
					num2 = 326;
					if (SG() != null)
					{
						num2 = 166;
					}
					continue;
				case 32:
					array[6] = 165;
					num2 = 175;
					continue;
				case 149:
					num29 = 217 - 72;
					num2 = 107;
					continue;
				case 384:
					num20 = 137 + 13;
					num2 = 394;
					continue;
				case 258:
					array2[19] = 98;
					num2 = 22;
					continue;
				case 334:
					array2[27] = (byte)num21;
					num2 = 6;
					if (MS())
					{
						continue;
					}
					break;
				case 333:
					array2[18] = 71;
					num2 = 250;
					continue;
				case 147:
					num24++;
					num2 = 350;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 45:
					num21 = 51 + 44;
					num2 = 395;
					continue;
				case 24:
					array2[18] = (byte)num21;
					num = 88;
					break;
				case 125:
					num21 = 235 - 78;
					num = 306;
					break;
				case 193:
				case 387:
					num4 = num27;
					num2 = 22;
					if (MS())
					{
						num2 = 27;
					}
					continue;
				case 12:
					num21 = 20 + 111;
					num2 = 134;
					if (!MS())
					{
						num2 = 85;
					}
					continue;
				case 358:
					if (num26 > 0)
					{
						num = 147;
						break;
					}
					goto case 350;
				case 240:
					array2[24] = 100;
					num2 = 10;
					continue;
				case 212:
					array[11] = 124;
					num2 = 116;
					continue;
				case 348:
					num21 = 51 + 36;
					num2 = 138;
					continue;
				case 266:
					array2[22] = 50;
					num2 = 79;
					continue;
				case 20:
					array6 = array2;
					num2 = 185;
					continue;
				case 56:
					array2[21] = 151;
					num = 133;
					break;
				case 347:
					array[3] = 158;
					num2 = 146;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 404:
					array2[5] = 169;
					num2 = 178;
					if (MS())
					{
						continue;
					}
					break;
				case 197:
					array[9] = (byte)num29;
					num2 = 11;
					continue;
				case 293:
					array2[17] = 162;
					num2 = 381;
					continue;
				case 107:
					array[11] = (byte)num29;
					num2 = 37;
					continue;
				case 280:
					num21 = 133 - 44;
					num2 = 415;
					if (!MS())
					{
						num2 = 70;
					}
					continue;
				case 166:
					array[5] = 52;
					num2 = 171;
					continue;
				case 259:
					array2[18] = (byte)num21;
					num2 = 5;
					continue;
				case 238:
					num20 = 64 + 78;
					num2 = 313;
					if (SG() != null)
					{
						num2 = 2;
					}
					continue;
				case 48:
					array[15] = 146;
					num2 = 407;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 106:
					array2[28] = (byte)num21;
					num2 = 169;
					continue;
				case 146:
					array[3] = 106;
					num2 = 337;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 305:
					t2j = array4;
					num2 = 62;
					continue;
				case 265:
					num20 = 29 - 18;
					num2 = 320;
					continue;
				case 69:
					num30 += 8;
					num = 218;
					break;
				case 58:
					array2[12] = (byte)num21;
					num2 = 94;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 374:
					if (num23 == num24 - 1)
					{
						num2 = 41;
						continue;
					}
					goto case 152;
				case 252:
					array2[26] = 171;
					num2 = 156;
					if (MS())
					{
						continue;
					}
					break;
				case 255:
					array[9] = (byte)num20;
					num = 290;
					break;
				case 396:
					array2[6] = 31;
					num2 = 17;
					continue;
				case 390:
					array2[27] = 116;
					num2 = 356;
					continue;
				case 23:
					num36 = (uint)num37;
					num2 = 268;
					continue;
				case 290:
					array[9] = 136;
					num2 = 208;
					continue;
				case 236:
				case 335:
					num22 = 0;
					num2 = 76;
					if (!MS())
					{
						num2 = 21;
					}
					continue;
				case 221:
					array2[15] = (byte)num21;
					num2 = 7;
					continue;
				case 164:
				case 196:
					num23++;
					num2 = 229;
					if (MS())
					{
						continue;
					}
					break;
				case 7:
					array2[15] = 197;
					num2 = 327;
					if (MS())
					{
						continue;
					}
					break;
				case 381:
					num21 = 115 + 67;
					num2 = 321;
					continue;
				case 89:
					num25++;
					num2 = 311;
					continue;
				case 385:
					num21 = 22 + 29;
					num2 = 81;
					continue;
				case 330:
					num21 = 111 + 77;
					num = 308;
					break;
				case 116:
					array[11] = 134;
					num2 = 141;
					continue;
				case 178:
					array2[6] = 104;
					num2 = 396;
					continue;
				case 211:
					array2[16] = (byte)num21;
					num2 = 419;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 25:
					if (num26 > 0)
					{
						num2 = 187;
						if (MS())
						{
							num2 = 410;
						}
						continue;
					}
					goto case 15;
				case 179:
					array2[2] = 66;
					num2 = 357;
					if (!MS())
					{
						num2 = 259;
					}
					continue;
				case 60:
					num29 = 98 + 102;
					num2 = 26;
					continue;
				case 382:
					array2[16] = (byte)num21;
					num2 = 367;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 59:
					array2[23] = (byte)num21;
					num2 = 363;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 46:
					array[15] = 134;
					num2 = 48;
					continue;
				case 300:
					array2[17] = (byte)num21;
					num = 131;
					break;
				case 2:
					array4[num37] = (byte)(num38 & 0xFF);
					num2 = 241;
					continue;
				case 260:
					if (num25 > 0)
					{
						num2 = 201;
						continue;
					}
					goto case 343;
				case 144:
					num21 = 6 + 99;
					num2 = 92;
					continue;
				case 62:
					count = BitConverter.ToInt32(t2j, P_0);
					num2 = 51;
					continue;
				case 230:
					num29 = 188 - 71;
					num2 = 401;
					continue;
				case 167:
					array2[30] = (byte)num21;
					num2 = 12;
					if (SG() != null)
					{
						num2 = 2;
					}
					continue;
				case 115:
					array[7] = 141;
					num2 = 301;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 401:
					array[13] = (byte)num29;
					num2 = 329;
					continue;
				case 182:
					array3[3] = publicKeyToken[1];
					num2 = 232;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 295:
					num21 = 90 + 58;
					num2 = 1;
					if (MS())
					{
						continue;
					}
					break;
				case 30:
					array2[14] = 130;
					num2 = 249;
					continue;
				case 264:
					array2[30] = (byte)num21;
					num2 = 247;
					continue;
				case 412:
					array2[28] = (byte)num21;
					num2 = 139;
					continue;
				case 185:
					array = new byte[16];
					num2 = 154;
					if (MS())
					{
						continue;
					}
					break;
				case 70:
					if (num32 > 0)
					{
						num2 = 130;
						if (SG() == null)
						{
							continue;
						}
						break;
					}
					goto case 218;
				case 253:
					num21 = 58 + 7;
					num2 = 302;
					continue;
				case 111:
					array2[28] = 41;
					num2 = 21;
					continue;
				case 301:
					array[7] = 77;
					num2 = 388;
					if (SG() != null)
					{
						num2 = 258;
					}
					continue;
				case 86:
					array2[21] = 194;
					num2 = 280;
					continue;
				case 88:
					array2[18] = 142;
					num2 = 245;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 232:
					array3[5] = publicKeyToken[2];
					num2 = 186;
					continue;
				case 66:
					array2[4] = 169;
					num2 = 34;
					if (!MS())
					{
						num2 = 3;
					}
					continue;
				case 359:
					num21 = 210 - 70;
					num2 = 29;
					continue;
				case 38:
					array2[31] = (byte)num21;
					num2 = 103;
					continue;
				case 19:
					num20 = 223 - 74;
					num2 = 219;
					continue;
				case 28:
					array2[9] = (byte)num21;
					num2 = 140;
					continue;
				case 36:
					num20 = 31 + 124;
					num2 = 110;
					continue;
				case 369:
					array2[14] = (byte)num21;
					num2 = 61;
					continue;
				case 134:
					array2[31] = (byte)num21;
					num2 = 351;
					if (MS())
					{
						continue;
					}
					break;
				case 400:
					num31 = 0u;
					num2 = 398;
					continue;
				case 380:
					num21 = 175 - 58;
					num2 = 365;
					continue;
				case 302:
					array2[12] = (byte)num21;
					num2 = 4;
					continue;
				case 120:
					array[7] = 96;
					num2 = 309;
					continue;
				case 364:
					num21 = 192 - 64;
					num2 = 332;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 78:
					if (t2j.Length == 0)
					{
						num2 = 77;
						if (SG() == null)
						{
							continue;
						}
						break;
					}
					goto case 62;
				case 228:
					num29 = 3 + 2;
					num2 = 278;
					continue;
				case 340:
					num29 = 145 + 67;
					num2 = 43;
					if (MS())
					{
						num2 = 331;
					}
					continue;
				case 225:
					array[13] = 140;
					num2 = 192;
					if (!MS())
					{
						num2 = 175;
					}
					continue;
				case 263:
					num21 = 61 + 74;
					num2 = 153;
					continue;
				case 371:
					num27 = 0u;
					num2 = 108;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 165:
					array2[12] = 76;
					num2 = 253;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 206:
					array5 = t2j;
					num2 = 104;
					continue;
				case 199:
					num21 = 47 + 95;
					num2 = 279;
					continue;
				case 299:
					num43 = 255u;
					num2 = 231;
					continue;
				case 130:
					num43 <<= 8;
					num2 = 69;
					continue;
				case 319:
					array3[13] = publicKeyToken[6];
					num2 = 210;
					continue;
				case 393:
					array2[24] = 150;
					num2 = 251;
					continue;
				case 216:
					array2[10] = 148;
					num2 = 209;
					continue;
				case 75:
					array2[2] = 87;
					num2 = 47;
					continue;
				case 376:
					num21 = 152 - 50;
					num2 = 82;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 378:
					array[11] = (byte)num29;
					num2 = 149;
					continue;
				case 14:
				case 205:
					if (num32 >= num26)
					{
						num = 196;
						break;
					}
					goto case 70;
				case 174:
					array[5] = (byte)num20;
					num2 = 166;
					continue;
				case 6:
					array2[27] = 135;
					num2 = 390;
					continue;
				case 329:
					num20 = 99 + 85;
					num2 = 84;
					if (!MS())
					{
						num2 = 28;
					}
					continue;
				case 222:
					array2[20] = 90;
					num2 = 129;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 346:
					array2[3] = (byte)num21;
					num2 = 144;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 183:
					num20 = 110 + 15;
					num2 = 202;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 33:
					num28 = (uint)((array6[num36 + 3] << 24) | (array6[num36 + 2] << 16) | (array6[num36 + 1] << 8) | array6[num36]);
					num = 299;
					break;
				case 31:
				case 76:
					if (num22 >= array3.Length)
					{
						num2 = 352;
						continue;
					}
					goto case 397;
				case 247:
					array2[30] = 87;
					num2 = 54;
					if (MS())
					{
						continue;
					}
					break;
				case 336:
					array2[31] = 126;
					num2 = 0;
					if (MS())
					{
						num2 = 3;
					}
					continue;
				case 108:
					num28 = 0u;
					num = 314;
					break;
				case 312:
					array2[2] = (byte)num21;
					num2 = 179;
					continue;
				case 3:
					num21 = 7 + 98;
					num2 = 38;
					continue;
				case 213:
					array2[26] = 70;
					num2 = 383;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 110:
					array[6] = (byte)num20;
					num2 = 195;
					continue;
				case 172:
					array[1] = (byte)num20;
					num2 = 238;
					continue;
				case 71:
					array2[15] = (byte)num21;
					num = 362;
					break;
				case 272:
					if (publicKeyToken.Length > 0)
					{
						num2 = 194;
						if (MS())
						{
							continue;
						}
						break;
					}
					goto case 236;
				case 292:
					array2[1] = 151;
					num2 = 96;
					continue;
				case 332:
					array2[19] = (byte)num21;
					num2 = 316;
					continue;
				case 353:
					num29 = 182 - 60;
					num2 = 285;
					continue;
				case 274:
					array2[0] = (byte)num21;
					num2 = 136;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 320:
					array[1] = (byte)num20;
					num2 = 150;
					if (!MS())
					{
						num2 = 107;
					}
					continue;
				case 268:
					num31 = (uint)((array5[num36 + 3] << 24) | (array5[num36 + 2] << 16) | (array5[num36 + 1] << 8) | array5[num36]);
					num2 = 387;
					continue;
				case 245:
					array2[18] = 202;
					num2 = 83;
					if (MS())
					{
						continue;
					}
					break;
				case 117:
					array2[1] = (byte)num21;
					num2 = 234;
					continue;
				case 354:
					array2[29] = (byte)num21;
					num2 = 31;
					if (SG() == null)
					{
						num2 = 39;
					}
					continue;
				case 338:
					num20 = 108 + 69;
					num2 = 174;
					if (SG() != null)
					{
						num2 = 102;
					}
					continue;
				case 243:
					num36 = (uint)(num33 * 4);
					num2 = 33;
					continue;
				case 201:
					num31 <<= 8;
					num2 = 343;
					if (!MS())
					{
						num2 = 191;
					}
					continue;
				case 74:
					num20 = 59 + 106;
					num = 172;
					break;
				case 92:
					array2[4] = (byte)num21;
					num2 = 199;
					continue;
				case 61:
					num21 = 121 + 24;
					num2 = 57;
					if (MS())
					{
						num2 = 71;
					}
					continue;
				case 383:
					array2[26] = 119;
					num2 = 252;
					continue;
				case 98:
					num20 = 119 + 38;
					num2 = 277;
					if (MS())
					{
						num2 = 399;
					}
					continue;
				case 316:
					array2[19] = 176;
					num2 = 276;
					continue;
				case 139:
					array2[29] = 48;
					num2 = 145;
					continue;
				case 43:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 269;
					continue;
				case 198:
					array2[21] = 150;
					num2 = 257;
					continue;
				case 118:
					num21 = 101 + 66;
					num2 = 369;
					continue;
				case 26:
					array[0] = (byte)num29;
					num2 = 340;
					continue;
				case 418:
					array[1] = 165;
					num2 = 265;
					continue;
				case 83:
					num21 = 67 + 98;
					num2 = 259;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 27:
					num27 = 0u;
					num2 = 324;
					continue;
				case 41:
					if (num26 > 0)
					{
						num2 = 400;
						if (SG() == null)
						{
							continue;
						}
						break;
					}
					goto case 152;
				case 296:
					array[13] = (byte)num20;
					num2 = 230;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 277:
					num20 = 13 + 109;
					num = 181;
					break;
				case 368:
					array2[1] = 118;
					num2 = 67;
					continue;
				case 11:
					num20 = 25 + 49;
					num2 = 150;
					if (SG() == null)
					{
						num2 = 255;
					}
					continue;
				case 281:
					num21 = 4 + 117;
					num2 = 354;
					continue;
				case 403:
					array2[13] = 93;
					num2 = 322;
					continue;
				case 112:
					array[5] = 115;
					num2 = 148;
					if (SG() == null)
					{
						num2 = 237;
					}
					continue;
				case 192:
					num20 = 1 + 48;
					num2 = 296;
					continue;
				case 318:
					cryptoStream.Close();
					num2 = 206;
					continue;
				case 362:
					num21 = 20 + 94;
					num2 = 221;
					continue;
				case 51:
					try
					{
						grA.DaB7cz();
						int num39 = 0;
						if (!MS())
						{
							num39 = 0;
						}
						while (true)
						{
							switch (num39)
							{
							case 1:
								return result;
							}
							result = Encoding.Unicode.GetString(t2j, P_0 + 4, count);
							num39 = 1;
							if (SG() != null)
							{
								num39 = num40;
							}
						}
					}
					catch
					{
						int num41 = 0;
						if (!MS())
						{
							num41 = num42;
						}
						switch (num41)
						{
						case 0:
							break;
						}
					}
					goto case 422;
				case 339:
					num21 = 39 + 74;
					num2 = 140;
					if (MS())
					{
						num2 = 264;
					}
					continue;
				case 419:
					array2[16] = 110;
					num2 = 90;
					continue;
				case 402:
					array2[6] = 100;
					num2 = 91;
					continue;
				case 420:
					array2[0] = (byte)num21;
					num2 = 102;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 85:
					array2[28] = (byte)num21;
					num2 = 42;
					continue;
				case 231:
					num30 = 0;
					num2 = 374;
					continue;
				case 414:
					array2[5] = 109;
					num = 355;
					break;
				case 159:
					array[12] = 185;
					num2 = 384;
					continue;
				case 408:
					array4[num37 + 3] = (byte)((num38 & 0xFF000000u) >> 24);
					num2 = 164;
					continue;
				case 184:
					array2[4] = (byte)num21;
					num2 = 66;
					continue;
				case 34:
					array2[5] = 139;
					num2 = 162;
					continue;
				case 123:
					num29 = 189 - 63;
					num2 = 114;
					continue;
				case 171:
					array[6] = 81;
					num2 = 32;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 267:
					num21 = 229 - 76;
					num2 = 55;
					continue;
				case 392:
					num21 = 149 + 56;
					num2 = 287;
					if (MS())
					{
						continue;
					}
					break;
				case 151:
					cryptoStream.FlushFinalBlock();
					num2 = 227;
					continue;
				case 190:
					num20 = 124 + 30;
					num2 = 176;
					if (!MS())
					{
						num2 = 23;
					}
					continue;
				case 421:
					array2[14] = (byte)num21;
					num2 = 118;
					if (!MS())
					{
						num2 = 85;
					}
					continue;
				case 161:
					num21 = 254 - 84;
					num2 = 28;
					continue;
				case 169:
					array2[28] = 114;
					num2 = 111;
					continue;
				case 323:
					num27 = num4;
					num2 = 391;
					if (MS())
					{
						continue;
					}
					break;
				default:
					array2[25] = 116;
					num2 = 8;
					continue;
				case 249:
					num21 = 123 + 12;
					num = 421;
					break;
				case 73:
					num24 = array5.Length / 4;
					num2 = 294;
					continue;
				case 35:
					num21 = 132 + 58;
					num2 = 146;
					if (MS())
					{
						num2 = 346;
					}
					continue;
				case 91:
					array2[6] = 29;
					num2 = 380;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 188:
					num34 = array6.Length / 4;
					num2 = 371;
					if (MS())
					{
						continue;
					}
					break;
				case 373:
					array2[16] = (byte)num21;
					num2 = 40;
					if (SG() == null)
					{
						num2 = 293;
					}
					continue;
				case 331:
					array[0] = (byte)num29;
					num2 = 289;
					if (MS())
					{
						num2 = 310;
					}
					continue;
				case 176:
					array[10] = (byte)num20;
					num2 = 212;
					continue;
				case 4:
					array2[12] = 168;
					num2 = 246;
					continue;
				case 343:
					num31 |= array5[array5.Length - (1 + num25)];
					num2 = 36;
					if (MS())
					{
						num2 = 89;
					}
					continue;
				case 327:
					array2[15] = 42;
					num = 177;
					break;
				case 104:
					num26 = array5.Length % 4;
					num = 73;
					break;
				case 237:
					num20 = 77 + 104;
					num2 = 411;
					continue;
				case 148:
					array[8] = (byte)num20;
					num2 = 228;
					continue;
				case 322:
					array2[13] = 82;
					num = 295;
					break;
				case 96:
					array2[2] = 90;
					num2 = 75;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 261:
					array[15] = (byte)num20;
					num2 = 98;
					continue;
				case 140:
					array2[9] = 123;
					num2 = 361;
					continue;
				case 315:
					num21 = 196 - 65;
					num2 = 271;
					continue;
				case 187:
					array2[16] = 101;
					num2 = 214;
					continue;
				case 379:
					array2[25] = 137;
					num2 = 0;
					if (MS())
					{
						continue;
					}
					break;
				case 49:
					array2[19] = (byte)num21;
					num2 = 222;
					continue;
				case 207:
					array3 = array;
					num2 = 389;
					continue;
				case 326:
					num20 = 112 + 81;
					num2 = 99;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 210:
					array3[15] = publicKeyToken[7];
					num2 = 236;
					continue;
				case 370:
					array[11] = (byte)num20;
					num2 = 270;
					if (!MS())
					{
						num2 = 94;
					}
					continue;
				case 284:
					array2[8] = 204;
					num2 = 6;
					if (SG() == null)
					{
						num2 = 13;
					}
					continue;
				case 350:
					num36 = 0u;
					num2 = 325;
					continue;
				case 37:
					num20 = 30 + 96;
					num2 = 89;
					if (SG() == null)
					{
						num2 = 370;
					}
					continue;
				case 372:
					array2[25] = 149;
					num2 = 222;
					if (SG() == null)
					{
						num2 = 379;
					}
					continue;
				case 328:
					stream.Close();
					num2 = 318;
					continue;
				case 126:
					array[6] = 136;
					num2 = 36;
					continue;
				case 170:
					num21 = 119 + 34;
					num2 = 309;
					if (SG() == null)
					{
						num2 = 349;
					}
					continue;
				case 283:
					array2[27] = (byte)num21;
					num2 = 101;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 15:
					num38 = num27 ^ num31;
					num2 = 2;
					continue;
				case 256:
					array2[23] = 121;
					num2 = 405;
					continue;
				case 279:
					array2[4] = (byte)num21;
					num2 = 217;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 77:
					u7J = new u7J(N2u.GetManifestResourceStream("EG1XQy3R8DljPEJZgd.2OTec8J2J67UU0j8UX"));
					num2 = 72;
					continue;
				case 337:
					num29 = 171 - 57;
					num2 = 304;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 294:
					array4 = new byte[array5.Length];
					num2 = 188;
					continue;
				case 64:
					array2[9] = (byte)num21;
					num2 = 203;
					if (SG() != null)
					{
						num2 = 92;
					}
					continue;
				case 309:
					array[7] = 156;
					num2 = 115;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 145:
					array2[29] = 90;
					num2 = 281;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 13:
					array2[8] = 107;
					num = 93;
					break;
				case 360:
					array[10] = 126;
					num2 = 190;
					if (SG() != null)
					{
						num2 = 154;
					}
					continue;
				case 349:
					array2[14] = (byte)num21;
					num2 = 30;
					if (!MS())
					{
						num2 = 1;
					}
					continue;
				case 410:
					num35 = num27 ^ num31;
					num2 = 121;
					continue;
				case 220:
					array3[9] = publicKeyToken[4];
					num2 = 132;
					continue;
				case 94:
					array2[12] = 46;
					num2 = 417;
					continue;
				case 128:
					num20 = 154 - 51;
					num2 = 239;
					continue;
				case 17:
					array2[6] = 132;
					num2 = 273;
					continue;
				case 389:
					Array.Reverse(array3);
					num2 = 158;
					continue;
				case 202:
					array[3] = (byte)num20;
					num2 = 347;
					continue;
				case 289:
					array2[5] = 159;
					num = 414;
					break;
				case 133:
					array2[22] = 87;
					num2 = 386;
					continue;
				case 325:
					num23 = 0;
					num2 = 375;
					continue;
				case 356:
					num21 = 142 - 47;
					num2 = 254;
					continue;
				case 119:
					num21 = 6 + 56;
					num2 = 345;
					continue;
				case 93:
					array2[8] = 201;
					num2 = 215;
					continue;
				case 152:
					num27 += num28;
					num2 = 23;
					continue;
				case 377:
					num20 = 136 - 45;
					num2 = 261;
					continue;
				case 278:
					array[8] = (byte)num29;
					num2 = 57;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 181:
					array[12] = (byte)num20;
					num2 = 159;
					continue;
				case 162:
					array2[5] = 104;
					num2 = 289;
					continue;
				case 262:
					array2 = new byte[32];
					num2 = 275;
					continue;
				case 158:
					publicKeyToken = N2u.GetName().GetPublicKeyToken();
					num2 = 80;
					continue;
				case 398:
					num27 += num28;
					num2 = 191;
					if (!MS())
					{
						num2 = 125;
					}
					continue;
				case 16:
					array2[10] = (byte)num21;
					num2 = 216;
					continue;
				case 114:
					array[1] = (byte)num29;
					num2 = 74;
					continue;
				case 138:
					array2[30] = (byte)num21;
					num2 = 339;
					continue;
				case 55:
					array2[0] = (byte)num21;
					num2 = 45;
					continue;
				case 18:
					num21 = 184 - 60;
					num2 = 160;
					continue;
				case 80:
					if (publicKeyToken == null)
					{
						num = 335;
						break;
					}
					goto case 272;
				case 250:
					num21 = 161 - 53;
					num2 = 24;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 254:
					array2[27] = (byte)num21;
					num2 = 263;
					if (MS())
					{
						continue;
					}
					break;
				case 417:
					array2[12] = 224;
					num2 = 359;
					continue;
				case 248:
					num33 = num23 % num34;
					num2 = 95;
					continue;
				case 50:
					array2[31] = (byte)num21;
					num2 = 336;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 131:
					array2[17] = 33;
					num2 = 315;
					continue;
				case 68:
					array[14] = 14;
					num = 377;
					break;
				case 226:
					array2[14] = 144;
					num2 = 170;
					continue;
				case 415:
					array2[21] = (byte)num21;
					num2 = 56;
					continue;
				case 189:
					array2[7] = (byte)num21;
					num2 = 288;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 99:
					array[4] = (byte)num20;
					num2 = 112;
					continue;
				case 308:
					array2[11] = (byte)num21;
					num2 = 165;
					continue;
				case 366:
					array2[22] = (byte)num21;
					num2 = 392;
					continue;
				case 105:
					array2[19] = (byte)num21;
					num2 = 258;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 113:
					u7J.W2z();
					num2 = 262;
					continue;
				case 84:
					array[14] = (byte)num20;
					num2 = 416;
					continue;
				case 367:
					num21 = 35 + 112;
					num2 = 197;
					if (MS())
					{
						num2 = 211;
					}
					continue;
				case 142:
					num21 = 190 - 63;
					num = 189;
					break;
				case 215:
					array2[9] = 120;
					num2 = 161;
					continue;
				case 304:
					array[4] = (byte)num29;
					num2 = 128;
					if (!MS())
					{
						num2 = 73;
					}
					continue;
				case 157:
					array2[7] = 118;
					num2 = 142;
					if (!MS())
					{
						num2 = 1;
					}
					continue;
				case 65:
					num29 = 107 + 53;
					num2 = 223;
					continue;
				case 406:
					array2[7] = 90;
					num2 = 18;
					continue;
				case 269:
					transform = symmetricAlgorithm.CreateDecryptor(array6, array3);
					num2 = 298;
					continue;
				case 409:
					array2[20] = (byte)num21;
					num2 = 143;
					continue;
				case 141:
					num29 = 197 - 65;
					num2 = 345;
					if (SG() == null)
					{
						num2 = 378;
					}
					continue;
				case 150:
					array[2] = 87;
					num2 = 163;
					continue;
				case 10:
					num21 = 223 - 74;
					num2 = 282;
					continue;
				case 121:
					num32 = 0;
					num2 = 14;
					if (MS())
					{
						continue;
					}
					break;
				case 223:
					array[10] = (byte)num29;
					num2 = 53;
					continue;
				case 275:
					num21 = 168 - 56;
					num2 = 420;
					continue;
				case 175:
					array[6] = 136;
					num2 = 126;
					if (MS())
					{
						continue;
					}
					break;
				case 22:
					num21 = 175 - 107;
					num2 = 49;
					continue;
				case 42:
					num21 = 170 - 113;
					num2 = 412;
					continue;
				case 63:
					num21 = 113 + 70;
					num2 = 283;
					continue;
				case 180:
					array5 = u7J.m2h((int)u7J.KDikMXewCI().Length);
					num2 = 113;
					if (SG() != null)
					{
						num2 = 32;
					}
					continue;
				case 395:
					array2[0] = (byte)num21;
					num2 = 297;
					continue;
				case 298:
					stream = x2x();
					num = 122;
					break;
				case 342:
					num21 = 88 + 53;
					num2 = 409;
					if (MS())
					{
						continue;
					}
					break;
				case 317:
					num29 = 106 + 119;
					num2 = 307;
					if (SG() != null)
					{
						num2 = 262;
					}
					continue;
				case 129:
					array2[20] = 117;
					num2 = 144;
					if (MS())
					{
						num2 = 342;
					}
					continue;
				case 270:
					array[11] = 212;
					num2 = 40;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 341:
					array2[25] = (byte)num21;
					num2 = 213;
					continue;
				case 177:
					num21 = 95 + 90;
					num2 = 298;
					if (SG() == null)
					{
						num2 = 382;
					}
					continue;
				case 135:
					cryptoStream.Write(array5, 0, array5.Length);
					num2 = 151;
					continue;
				case 229:
				case 375:
					if (num23 >= num24)
					{
						num2 = 134;
						if (MS())
						{
							num2 = 305;
						}
						continue;
					}
					goto case 248;
				case 186:
					array3[7] = publicKeyToken[3];
					num2 = 220;
					continue;
				case 72:
					u7J.KDikMXewCI().Position = 0L;
					num2 = 180;
					if (MS())
					{
						continue;
					}
					break;
				case 90:
					num21 = 90 + 75;
					num2 = 235;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 306:
					array2[11] = (byte)num21;
					num2 = 330;
					continue;
				case 137:
					array[14] = (byte)num20;
					num2 = 204;
					continue;
				case 345:
					array2[11] = (byte)num21;
					num2 = 125;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 97:
					array[0] = (byte)num20;
					num2 = 109;
					if (MS())
					{
						continue;
					}
					break;
				case 242:
					array[12] = 162;
					num2 = 277;
					continue;
				case 246:
					num21 = 207 - 69;
					num2 = 58;
					continue;
				case 285:
					array[13] = (byte)num29;
					num2 = 147;
					if (SG() == null)
					{
						num2 = 225;
					}
					continue;
				case 257:
					num21 = 211 - 70;
					num2 = 344;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 195:
					array[6] = 168;
					num2 = 120;
					if (MS())
					{
						continue;
					}
					break;
				case 394:
					array[12] = (byte)num20;
					num2 = 353;
					continue;
				case 124:
					symmetricAlgorithm = fqr();
					num2 = 43;
					if (MS())
					{
						continue;
					}
					break;
				case 234:
					array2[1] = 202;
					num2 = 368;
					if (!MS())
					{
						num2 = 298;
					}
					continue;
				case 357:
					array2[3] = 144;
					num2 = 413;
					continue;
				case 422:
					return "";
				case 303:
					array2[8] = 121;
					num2 = 284;
					continue;
				case 29:
					array2[13] = (byte)num21;
					num2 = 116;
					if (MS())
					{
						num2 = 403;
					}
					continue;
				case 8:
					num21 = 102 - 78;
					num2 = 341;
					continue;
				case 286:
					num32++;
					num2 = 205;
					continue;
				case 102:
					array2[0] = 106;
					num2 = 267;
					continue;
				case 153:
					array2[27] = (byte)num21;
					num2 = 63;
					continue;
				case 351:
					num21 = 84 + 103;
					num2 = 50;
					if (SG() != null)
					{
						num2 = 14;
					}
					continue;
				case 217:
					num21 = 16 + 88;
					num2 = 184;
					continue;
				case 168:
					array2[22] = (byte)num21;
					num2 = 266;
					continue;
				case 363:
					array2[23] = 176;
					num2 = 198;
					if (SG() == null)
					{
						num2 = 240;
					}
					continue;
				case 136:
					num21 = 242 - 80;
					num2 = 117;
					if (MS())
					{
						continue;
					}
					break;
				case 100:
					array2[7] = (byte)num21;
					num = 406;
					break;
				case 273:
					array2[6] = 147;
					num2 = 402;
					continue;
				case 109:
					array[0] = 107;
					num2 = 60;
					continue;
				case 388:
					num20 = 132 - 44;
					num = 148;
					break;
				case 291:
					num21 = 243 - 81;
					num2 = 300;
					continue;
				case 132:
					array3[11] = publicKeyToken[5];
					num2 = 319;
					if (MS())
					{
						continue;
					}
					break;
				case 40:
					array[12] = 144;
					num2 = 242;
					if (SG() != null)
					{
						num2 = 205;
					}
					continue;
				case 81:
					array2[25] = (byte)num21;
					num = 372;
					break;
				case 244:
					array2[31] = (byte)num21;
					num2 = 20;
					if (MS())
					{
						continue;
					}
					break;
				case 276:
					num21 = 36 + 87;
					num2 = 105;
					continue;
				case 233:
					num21 = 184 - 61;
					num = 16;
					break;
				case 47:
					num21 = 10 + 28;
					num2 = 312;
					continue;
				case 122:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 135;
					continue;
				case 82:
					array2[1] = (byte)num21;
					num = 292;
					break;
				case 310:
					array[1] = 99;
					num2 = 123;
					continue;
				case 39:
					array2[29] = 187;
					num2 = 87;
					continue;
				case 163:
					array[2] = 112;
					num2 = 317;
					continue;
				case 54:
					num21 = 71 + 90;
					num2 = 167;
					if (SG() != null)
					{
						num2 = 9;
					}
					continue;
				case 194:
					array3[1] = publicKeyToken[0];
					num2 = 182;
					continue;
				case 203:
					array2[10] = 237;
					num2 = 233;
					continue;
				case 156:
					num21 = 239 - 79;
					num2 = 334;
					continue;
				case 67:
					array2[1] = 129;
					num2 = 376;
					continue;
				case 411:
					array[5] = (byte)num20;
					num2 = 338;
					continue;
				case 314:
					num31 = 0u;
					num2 = 149;
					if (MS())
					{
						num2 = 358;
					}
					continue;
				case 208:
					array[10] = 151;
					num2 = 65;
					if (SG() != null)
					{
						num2 = 13;
					}
					continue;
				case 214:
					num21 = 170 + 7;
					num2 = 373;
					continue;
				case 227:
					t2j = s2G(stream);
					num2 = 328;
					if (MS())
					{
						continue;
					}
					break;
				case 155:
					array[14] = (byte)num20;
					num2 = 46;
					if (MS())
					{
						num2 = 68;
					}
					continue;
				case 416:
					num20 = 130 - 43;
					num = 137;
					break;
				case 399:
					array[15] = (byte)num20;
					num = 46;
					break;
				case 235:
					array2[16] = (byte)num21;
					num2 = 187;
					continue;
				case 405:
					num21 = 43 + 12;
					num2 = 59;
					continue;
				case 53:
					num29 = 222 - 74;
					num2 = 52;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 173:
					num20 = 20 + 77;
					num2 = 155;
					continue;
				case 321:
					array2[17] = (byte)num21;
					num2 = 52;
					if (SG() == null)
					{
						num2 = 291;
					}
					continue;
				case 21:
					num21 = 230 - 76;
					num2 = 85;
					if (SG() == null)
					{
						continue;
					}
					break;
				case 44:
				case 311:
					if (num25 >= num26)
					{
						num2 = 193;
						if (MS())
						{
							continue;
						}
						break;
					}
					goto case 260;
				case 287:
					array2[22] = (byte)num21;
					num2 = 256;
					if (MS())
					{
						continue;
					}
					break;
				case 251:
					num21 = 67 - 24;
					num2 = 9;
					continue;
				case 352:
					if (P_0 == -1)
					{
						num2 = 124;
						if (MS())
						{
							continue;
						}
						break;
					}
					goto case 104;
				case 1:
					array2[14] = (byte)num21;
					num = 226;
					break;
				case 282:
					array2[24] = (byte)num21;
					num = 393;
					break;
				case 365:
					array2[7] = (byte)num21;
					num2 = 157;
					continue;
				case 160:
					array2[7] = (byte)num21;
					num = 303;
					break;
				case 355:
					array2[5] = 104;
					num2 = 404;
					continue;
				case 218:
					array4[num37 + num32] = (byte)((num35 & num43) >> num30);
					num2 = 286;
					continue;
				case 407:
					array[15] = 130;
					num2 = 207;
					if (SG() != null)
					{
						num2 = 32;
					}
					continue;
				case 143:
					array2[20] = 225;
					num2 = 198;
					continue;
				case 200:
					num22++;
					num2 = 31;
					continue;
				case 5:
					array2[19] = 145;
					num2 = 364;
					continue;
				case 9:
					array2[24] = (byte)num21;
					num = 385;
					break;
				case 324:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 1935158433u;
					uint num7 = 1852179718u;
					uint num8 = 1032345398u;
					uint num9 = num5;
					uint num10 = 1829684816u;
					uint num11 = 1015486868u;
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
					num2 = 323;
					continue;
				}
				}
				break;
			}
		}
	}

	[a7X(typeof(a7X.N71<object>[]))]
	internal static string pqO(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int fqU()
	{
		return 5;
	}

	private static void TqJ()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate Sqt(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object UqZ(object P_0)
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
	public static extern IntPtr aqh(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr lqN(IntPtr P_0, string P_1);

	private static IntPtr Mqd(IntPtr P_0, string P_1, uint P_2)
	{
		if (v22 == null)
		{
			IntPtr ptr = lqN(umLocehuEC(), "Find ".Trim() + "ResourceA");
			v22 = (e7W)Marshal.GetDelegateForFunctionPointer(ptr, typeof(e7W));
		}
		return v22(P_0, P_1, P_2);
	}

	private static IntPtr bqz(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (T27 == null)
		{
			IntPtr ptr = lqN(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			T27 = (C78)Marshal.GetDelegateForFunctionPointer(ptr, typeof(C78));
		}
		return T27(P_0, P_1, P_2, P_3);
	}

	private static int X2W(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (a2i == null)
		{
			IntPtr ptr = lqN(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			a2i = (W7j)Marshal.GetDelegateForFunctionPointer(ptr, typeof(W7j));
		}
		return a2i(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int x2P(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (P2p == null)
		{
			IntPtr ptr = lqN(umLocehuEC(), "Virtual ".Trim() + "Protect");
			P2p = (A7q)Marshal.GetDelegateForFunctionPointer(ptr, typeof(A7q));
		}
		return P2p(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr l2E(uint P_0, int P_1, uint P_2)
	{
		if (G2M == null)
		{
			IntPtr ptr = lqN(umLocehuEC(), "Open ".Trim() + "Process");
			G2M = (Y7z)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Y7z));
		}
		return G2M(P_0, P_1, P_2);
	}

	private static int e2c(IntPtr P_0)
	{
		if (Q2O == null)
		{
			IntPtr ptr = lqN(umLocehuEC(), "Close ".Trim() + "Handle");
			Q2O = (qrS)Marshal.GetDelegateForFunctionPointer(ptr, typeof(qrS));
		}
		return Q2O(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (d2U == IntPtr.Zero)
		{
			d2U = aqh("kernel ".Trim() + "32.dll");
		}
		return d2U;
	}

	[a7X(typeof(a7X.N71<object>[]))]
	private static byte[] K2a(string P_0)
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

	internal static Stream x2x()
	{
		return new MemoryStream();
	}

	internal static byte[] s2G(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[a7X(typeof(a7X.N71<object>[]))]
	private static byte[] R2X(byte[] P_0)
	{
		Stream stream = x2x();
		SymmetricAlgorithm symmetricAlgorithm = fqr();
		symmetricAlgorithm.Key = new byte[32]
		{
			219, 160, 37, 32, 145, 161, 34, 189, 194, 166,
			110, 183, 85, 154, 87, 78, 175, 62, 101, 252,
			17, 104, 11, 156, 4, 31, 231, 190, 231, 165,
			168, 222
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			121, 103, 53, 190, 65, 220, 205, 126, 102, 56,
			218, 128, 66, 151, 206, 127
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = s2G(stream);
		grA.DaB7cz();
		return result;
	}

	private byte[] k2K()
	{
		return null;
	}

	private byte[] o2f()
	{
		return null;
	}

	private byte[] A2D()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] b2g()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] r2Q()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] u2e()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] G2l()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] P2A()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] b2v()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] V2m()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool MS()
	{
		return (object)null == null;
	}

	internal static object SG()
	{
		return null;
	}
}
