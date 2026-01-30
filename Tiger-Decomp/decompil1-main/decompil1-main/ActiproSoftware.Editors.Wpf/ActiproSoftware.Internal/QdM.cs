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

internal class QdM
{
	private delegate void zdp(object o);

	internal class xdt : Attribute
	{
		internal class Ydn<fdl>
		{
			private static object Hew;

			public Ydn()
			{
				awj.QuEwGz();
				base._002Ector();
			}

			internal static bool geo()
			{
				return Hew == null;
			}

			internal static object Ce2()
			{
				return Hew;
			}
		}

		[xdt(typeof(Ydn<object>[]))]
		public xdt(object P_0)
		{
		}
	}

	internal class odJ
	{
		[xdt(typeof(xdt.Ydn<object>[]))]
		internal static string Ndp(string P_0, string P_1)
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
			byte[] iV = SRH(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = hR5();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Bdz(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Ewi();

	internal struct Nwd
	{
		internal bool ndW;

		internal byte[] kdi;
	}

	internal class uww
	{
		private BinaryReader Pde;

		public uww(Stream P_0)
		{
			Pde = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return Pde.BaseStream;
		}

		internal byte[] AdZ(int P_0)
		{
			return Pde.ReadBytes(P_0);
		}

		internal int Adt(byte[] P_0, int P_1, int P_2)
		{
			return Pde.Read(P_0, P_1, P_2);
		}

		internal int Gdn()
		{
			return Pde.ReadInt32();
		}

		internal void XdJ()
		{
			Pde.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr kw2(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr OwH(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int TwG(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Mwf(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Nwk(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int jw1(IntPtr ptr);

	[Flags]
	private enum ow4
	{

	}

	private static bool odP;

	internal static Assembly qd2;

	private static uint[] Fda;

	internal static RSACryptoServiceProvider Sdx;

	private static object pdY;

	private static byte[] Fdo;

	private static int TdD;

	private static bool adG;

	private static SortedList pdq;

	private static long VdK;

	private static long Od9;

	private static IntPtr YdF;

	internal static Hashtable hd3;

	private static TwG IdS;

	private static IntPtr odv;

	internal static Bdz Hdd;

	private static Nwk pd8;

	private static int Tdu;

	[xdt(typeof(xdt.Ydn<object>[]))]
	private static bool SdA;

	private static Dictionary<int, int> Sd0;

	private static IntPtr JdT;

	private static byte[] Gdg;

	private static bool wdc;

	private static int fd5;

	private static IntPtr cdO;

	private static object rdI;

	private static int[] Qdb;

	private static byte[] GdX;

	private static Mwf od1;

	private static bool Ydf;

	private static int VdL;

	private static jw1 odr;

	private static kw2 Edy;

	private static bool idl;

	internal static Bdz qdR;

	private static bool adH;

	private static OwH zdm;

	static QdM()
	{
		odP = false;
		qd2 = typeof(QdM).Assembly;
		Fda = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		Ydf = false;
		idl = false;
		GdX = new byte[0];
		Sdx = null;
		Sd0 = null;
		pdY = new object();
		Gdg = new byte[0];
		Fdo = new byte[0];
		cdO = IntPtr.Zero;
		JdT = IntPtr.Zero;
		rdI = new string[0];
		Qdb = new int[0];
		TdD = 1;
		adG = false;
		pdq = new SortedList();
		Tdu = 0;
		VdK = 0L;
		qdR = null;
		Hdd = null;
		Od9 = 0L;
		fd5 = 0;
		wdc = false;
		adH = false;
		VdL = 0;
		YdF = IntPtr.Zero;
		SdA = false;
		hd3 = new Hashtable();
		Edy = null;
		zdm = null;
		IdS = null;
		od1 = null;
		pd8 = null;
		odr = null;
		odv = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void fuEwGD()
	{
	}

	internal static byte[] LRG(byte[] P_0)
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
			fRq(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			fRq(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			fRq(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			fRq(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			fRq(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			fRq(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			fRq(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			fRq(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			fRq(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			fRq(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			fRq(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			fRq(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			fRq(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			fRq(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			fRq(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			fRq(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			BRu(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			BRu(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			BRu(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			BRu(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			BRu(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			BRu(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			BRu(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			BRu(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			BRu(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			BRu(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			BRu(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			BRu(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			BRu(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			BRu(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			BRu(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			BRu(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			sRK(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			sRK(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			sRK(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			sRK(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			sRK(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			sRK(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			sRK(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			sRK(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			sRK(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			sRK(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			sRK(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			sRK(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			sRK(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			sRK(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			sRK(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			sRK(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			iRR(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			iRR(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			iRR(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			iRR(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			iRR(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			iRR(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			iRR(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			iRR(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			iRR(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			iRR(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			iRR(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			iRR(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			iRR(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			iRR(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			iRR(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			iRR(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void fRq(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + xRd(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + Fda[P_6 - 1], P_5);
	}

	private static void BRu(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + xRd(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + Fda[P_6 - 1], P_5);
	}

	private static void sRK(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + xRd(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + Fda[P_6 - 1], P_5);
	}

	private static void iRR(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + xRd(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + Fda[P_6 - 1], P_5);
	}

	private static uint xRd(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool pR9()
	{
		if (!Ydf)
		{
			ARc();
			Ydf = true;
		}
		return idl;
	}

	internal static SymmetricAlgorithm hR5()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (pR9())
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

	internal static void ARc()
	{
		try
		{
			idl = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] SRH(byte[] P_0)
	{
		if (!pR9())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return LRG(P_0);
	}

	internal static void iRL(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			KRF(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void KRF(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint RRA(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	public static void pR3(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (Sd0 == null)
			{
				lock (pdY)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(QdM).Assembly.GetManifestResourceStream("JQaT97EMm4DbMsBNF0.inDldVssJSaK0HX2no"));
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
							num3 += vRS(num3);
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
						uww uww = new uww(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = uww.Gdn();
							int value = uww.Gdn();
							dictionary.Add(key, value);
						}
						uww.XdJ();
					}
					Sd0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Sd0[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(QdM).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint kRm(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint vRS(uint P_0)
	{
		return 0u;
	}

	internal static void yR1()
	{
	}

	[xdt(typeof(xdt.Ydn<object>[]))]
	internal static string AR8(int P_0)
	{
		int num = 59;
		int num24 = default(int);
		byte[] array3 = default(byte[]);
		int num21 = default(int);
		byte[] array = default(byte[]);
		int num22 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		int num20 = default(int);
		uint num38 = default(uint);
		int num39 = default(int);
		uint num26 = default(uint);
		int num32 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] array6 = default(byte[]);
		int num30 = default(int);
		uint num28 = default(uint);
		int num34 = default(int);
		byte[] array4 = default(byte[]);
		byte[] publicKeyToken = default(byte[]);
		int num29 = default(int);
		int num33 = default(int);
		int num31 = default(int);
		uww uww = default(uww);
		byte[] array2 = default(byte[]);
		uint num23 = default(uint);
		byte[] array5 = default(byte[]);
		uint num35 = default(uint);
		int num42 = default(int);
		string result = default(string);
		int count = default(int);
		uint num27 = default(uint);
		int num36 = default(int);
		int num40 = default(int);
		int num37 = default(int);
		uint num4 = default(uint);
		uint num25 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 268:
					num24 = 157 + 50;
					num2 = 361;
					continue;
				case 260:
					if (P_0 == -1)
					{
						num2 = 402;
						if (XR() != null)
						{
							num2 = 293;
						}
						continue;
					}
					goto case 111;
				case 378:
					array3[0] = (byte)num21;
					num2 = 288;
					continue;
				case 265:
					array[17] = 189;
					num2 = 136;
					if (gF())
					{
						continue;
					}
					break;
				case 159:
					num22 = 224 + 3;
					num2 = 285;
					continue;
				case 177:
					num22 = 135 - 45;
					num2 = 422;
					continue;
				case 85:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 120;
					continue;
				case 116:
					array[22] = (byte)num20;
					num2 = 369;
					if (gF())
					{
						num2 = 433;
					}
					continue;
				case 35:
					cryptoStream.FlushFinalBlock();
					num2 = 250;
					if (gF())
					{
						continue;
					}
					break;
				case 136:
					num22 = 166 - 55;
					num2 = 431;
					continue;
				case 88:
					num38 = 0u;
					num2 = 297;
					continue;
				case 172:
					num20 = 162 - 88;
					num = 353;
					break;
				case 379:
					array[29] = (byte)num22;
					num = 248;
					break;
				case 166:
					num20 = 193 - 64;
					num2 = 162;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 163:
					array[27] = (byte)num22;
					num2 = 208;
					continue;
				case 389:
					num22 = 22 + 15;
					num2 = 418;
					if (XR() != null)
					{
						num2 = 385;
					}
					continue;
				case 421:
					array[6] = 241;
					num2 = 385;
					continue;
				case 79:
					num39 = 0;
					num2 = 175;
					if (gF())
					{
						num2 = 407;
					}
					continue;
				case 350:
					num26 += num38;
					num2 = 79;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 230:
					num32++;
					num2 = 42;
					if (gF())
					{
						continue;
					}
					break;
				case 204:
					num22 = 140 - 46;
					num2 = 379;
					continue;
				case 95:
					array[12] = 155;
					num2 = 159;
					continue;
				case 119:
					num22 = 81 + 97;
					num2 = 96;
					if (gF())
					{
						continue;
					}
					break;
				case 402:
					symmetricAlgorithm = hR5();
					num2 = 153;
					continue;
				case 2:
					array[20] = (byte)num20;
					num2 = 26;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 14:
					array[31] = (byte)num20;
					num2 = 45;
					continue;
				case 356:
					array[4] = 109;
					num = 336;
					break;
				case 28:
					num24 = 190 - 100;
					num2 = 61;
					continue;
				case 444:
					array3[10] = 155;
					num2 = 281;
					continue;
				case 207:
					array[23] = (byte)num20;
					num2 = 119;
					continue;
				case 315:
					array[4] = 44;
					num2 = 6;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 432:
					array[28] = 95;
					num2 = 82;
					continue;
				case 120:
					cryptoStream.Write(array6, 0, array6.Length);
					num2 = 35;
					if (gF())
					{
						continue;
					}
					break;
				case 404:
					array[1] = 133;
					num2 = 430;
					continue;
				case 43:
					num22 = 191 - 63;
					num = 17;
					break;
				case 280:
					num20 = 252 - 84;
					num2 = 316;
					continue;
				case 18:
					num20 = 69 + 124;
					num2 = 203;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 428:
					array3[10] = 173;
					num2 = 247;
					continue;
				case 424:
					num22 = 243 - 81;
					num2 = 132;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 13:
					array[22] = 165;
					num2 = 131;
					continue;
				case 3:
					num24 = 230 - 76;
					num2 = 160;
					continue;
				case 9:
					num20 = 162 - 54;
					num2 = 426;
					continue;
				case 111:
					num30 = array6.Length % 4;
					num2 = 210;
					if (XR() == null)
					{
						num2 = 360;
					}
					continue;
				case 189:
					num20 = 198 - 66;
					num2 = 225;
					continue;
				case 231:
					num24 = 13 + 87;
					num2 = 190;
					continue;
				case 291:
					array[15] = 157;
					num2 = 419;
					if (gF())
					{
						continue;
					}
					break;
				case 405:
					array3[15] = 224;
					num2 = 311;
					if (gF())
					{
						num2 = 317;
					}
					continue;
				case 1:
					array[6] = (byte)num20;
					num2 = 123;
					continue;
				case 422:
					array[2] = (byte)num22;
					num2 = 107;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 146:
					num20 = 160 - 53;
					num2 = 238;
					continue;
				case 438:
					array3[14] = (byte)num21;
					num = 227;
					break;
				case 386:
					array = new byte[32];
					num2 = 341;
					continue;
				case 308:
					num28 = (uint)num34;
					num2 = 22;
					if (XR() == null)
					{
						num2 = 90;
					}
					continue;
				case 125:
					num20 = 17 + 74;
					num2 = 266;
					if (gF())
					{
						continue;
					}
					break;
				case 430:
					num22 = 60 + 7;
					num2 = 7;
					continue;
				case 334:
					array3[8] = 101;
					num2 = 22;
					continue;
				case 33:
					array4[7] = publicKeyToken[3];
					num2 = 140;
					if (gF())
					{
						num2 = 211;
					}
					continue;
				case 274:
					num20 = 162 - 38;
					num2 = 278;
					continue;
				case 99:
					array[15] = 180;
					num = 125;
					break;
				case 357:
					num29 = num33 % num31;
					num = 394;
					break;
				case 45:
					num20 = 171 - 57;
					num2 = 241;
					continue;
				case 114:
					num20 = 191 - 110;
					num2 = 275;
					continue;
				case 250:
					Gdg = HRh(stream);
					num = 48;
					break;
				case 20:
					num28 = (uint)(num29 * 4);
					num2 = 209;
					continue;
				case 361:
					array3[8] = (byte)num24;
					num2 = 216;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 415:
					uww.KDikMXewCI().Position = 0L;
					num2 = 258;
					if (gF())
					{
						continue;
					}
					break;
				case 363:
					array[26] = (byte)num22;
					num2 = 106;
					continue;
				case 397:
					array2 = array;
					num2 = 440;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 256:
					num20 = 28 - 12;
					num2 = 206;
					continue;
				case 182:
					num21 = 105 + 115;
					num2 = 199;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 358:
					array3[11] = 155;
					num2 = 252;
					continue;
				case 128:
					num20 = 149 + 102;
					num2 = 174;
					continue;
				case 343:
					array3[12] = (byte)num21;
					num2 = 441;
					continue;
				case 416:
					num23 <<= 8;
					num2 = 326;
					continue;
				case 209:
					num38 = (uint)((array2[num28 + 3] << 24) | (array2[num28 + 2] << 16) | (array2[num28 + 1] << 8) | array2[num28]);
					num2 = 215;
					continue;
				case 56:
					array3[2] = 151;
					num2 = 68;
					if (!gF())
					{
						num2 = 24;
					}
					continue;
				case 168:
					array[5] = (byte)num22;
					num2 = 147;
					continue;
				case 210:
					num20 = 30 + 9;
					num2 = 139;
					continue;
				case 239:
					array3[2] = (byte)num24;
					num2 = 339;
					if (XR() != null)
					{
						num2 = 159;
					}
					continue;
				case 285:
					array[12] = (byte)num22;
					num = 393;
					break;
				case 294:
					array[15] = 92;
					num2 = 99;
					continue;
				case 401:
					num20 = 170 - 56;
					num2 = 207;
					continue;
				case 377:
					array3[14] = (byte)num24;
					num = 30;
					break;
				case 374:
					num20 = 203 - 67;
					num2 = 51;
					continue;
				case 71:
					num22 = 114 + 49;
					num2 = 37;
					if (gF())
					{
						num2 = 362;
					}
					continue;
				case 137:
					array[6] = 139;
					num2 = 421;
					continue;
				case 29:
					array[28] = (byte)num20;
					num2 = 204;
					continue;
				case 398:
					if (num30 > 0)
					{
						num2 = 184;
						if (XR() != null)
						{
							num2 = 154;
						}
						continue;
					}
					goto case 151;
				case 323:
					array[7] = (byte)num20;
					num = 60;
					break;
				case 272:
					array3[0] = (byte)num21;
					num2 = 263;
					continue;
				case 93:
					array3[4] = 149;
					num2 = 202;
					continue;
				case 304:
					array[13] = (byte)num20;
					num2 = 271;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 257:
					num24 = 166 - 55;
					num2 = 377;
					continue;
				case 76:
					num24 = 150 - 50;
					num2 = 370;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 427:
					array[28] = 144;
					num2 = 134;
					continue;
				case 84:
					array5[num34 + 3] = (byte)((num35 & 0xFF000000u) >> 24);
					num2 = 349;
					continue;
				case 211:
					array4[9] = publicKeyToken[4];
					num = 77;
					break;
				case 48:
					stream.Close();
					num2 = 411;
					continue;
				case 4:
					publicKeyToken = qd2.GetName().GetPublicKeyToken();
					num2 = 270;
					if (gF())
					{
						continue;
					}
					break;
				case 130:
					num22 = 43 + 52;
					num2 = 345;
					if (!gF())
					{
						num2 = 309;
					}
					continue;
				case 279:
					array[22] = (byte)num22;
					num2 = 344;
					continue;
				case 127:
					array[1] = (byte)num20;
					num2 = 223;
					continue;
				case 135:
					try
					{
						awj.QuEwGz();
						int num41 = 0;
						if (!gF())
						{
							goto IL_133c;
						}
						goto IL_1340;
						IL_133c:
						num41 = num42;
						goto IL_1340;
						IL_1340:
						do
						{
							switch (num41)
							{
							case 1:
								return result;
							}
							result = Encoding.Unicode.GetString(Gdg, P_0 + 4, count);
							num41 = 1;
						}
						while (gF());
						goto IL_133c;
					}
					catch
					{
						int num43 = 0;
						if (XR() == null)
						{
							num43 = 0;
						}
						switch (num43)
						{
						case 0:
							break;
						}
					}
					goto case 195;
				case 170:
					array3[3] = (byte)num24;
					num2 = 384;
					if (gF())
					{
						continue;
					}
					break;
				case 192:
					num20 = 22 + 42;
					num2 = 188;
					continue;
				case 233:
					num20 = 172 + 34;
					num2 = 54;
					if (!gF())
					{
						num2 = 25;
					}
					continue;
				case 160:
					array3[5] = (byte)num24;
					num2 = 351;
					continue;
				case 161:
					array[1] = (byte)num20;
					num2 = 404;
					continue;
				case 242:
				case 407:
					if (num39 >= num30)
					{
						num2 = 217;
						continue;
					}
					goto case 391;
				case 288:
					num21 = 223 - 74;
					num2 = 180;
					continue;
				case 36:
					array[6] = 141;
					num2 = 229;
					continue;
				case 348:
					num21 = 61 - 58;
					num2 = 213;
					continue;
				case 58:
					uww = new uww(qd2.GetManifestResourceStream("ZtYZQJwQUh9XDXOwlT.V21aYRb8T5QCiiNiwC"));
					num2 = 415;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 331:
					array3[9] = (byte)num21;
					num2 = 25;
					continue;
				case 373:
					array[9] = 196;
					num2 = 41;
					continue;
				case 316:
					array[31] = (byte)num20;
					num2 = 205;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 212:
					array[25] = (byte)num20;
					num2 = 219;
					continue;
				case 47:
					num21 = 233 - 77;
					num2 = 378;
					continue;
				case 335:
					num22 = 219 - 73;
					num = 368;
					break;
				case 339:
					array3[2] = 26;
					num2 = 292;
					continue;
				case 138:
					num27 = 0u;
					num2 = 334;
					if (gF())
					{
						num2 = 350;
					}
					continue;
				case 12:
					num22 = 97 + 68;
					num2 = 380;
					if (gF())
					{
						continue;
					}
					break;
				case 227:
					array3[15] = 135;
					num2 = 98;
					continue;
				case 247:
					array3[10] = 173;
					num2 = 444;
					if (!gF())
					{
						num2 = 91;
					}
					continue;
				case 395:
					transform = symmetricAlgorithm.CreateDecryptor(array2, array4);
					num2 = 183;
					continue;
				case 371:
					num24 = 38 + 114;
					num2 = 170;
					continue;
				case 184:
					num36++;
					num2 = 151;
					continue;
				case 384:
					array3[4] = 112;
					num2 = 93;
					continue;
				case 289:
					array[17] = (byte)num20;
					num2 = 12;
					if (XR() == null)
					{
						num2 = 39;
					}
					continue;
				case 245:
					array[19] = 18;
					num2 = 319;
					continue;
				case 243:
					array[25] = 172;
					num2 = 9;
					continue;
				case 203:
					array[18] = (byte)num20;
					num = 251;
					break;
				case 429:
					array[7] = 191;
					num2 = 189;
					if (XR() != null)
					{
						num2 = 46;
					}
					continue;
				case 198:
					array3[7] = (byte)num21;
					num2 = 439;
					continue;
				case 188:
					array[25] = (byte)num20;
					num2 = 243;
					continue;
				case 228:
					num20 = 222 + 13;
					num2 = 423;
					continue;
				case 382:
					array5[num34] = (byte)(num35 & 0xFF);
					num2 = 164;
					continue;
				case 173:
					array3[1] = (byte)num21;
					num2 = 220;
					if (gF())
					{
						continue;
					}
					break;
				case 394:
					num34 = num33 * 4;
					num2 = 20;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 326:
					num40 += 8;
					num2 = 406;
					if (!gF())
					{
						num2 = 119;
					}
					continue;
				case 34:
					array3[6] = 139;
					num2 = 375;
					continue;
				case 267:
					array3[12] = 112;
					num2 = 340;
					continue;
				case 180:
					array3[0] = (byte)num21;
					num2 = 234;
					continue;
				case 91:
					array3[7] = 182;
					num2 = 8;
					if (XR() == null)
					{
						num2 = 32;
					}
					continue;
				case 147:
					num22 = 174 - 58;
					num2 = 226;
					continue;
				case 303:
					array4[3] = publicKeyToken[1];
					num2 = 200;
					continue;
				case 145:
					array[3] = 98;
					num = 172;
					break;
				case 150:
					num37++;
					num2 = 224;
					continue;
				case 194:
					num21 = 20 + 103;
					num2 = 117;
					continue;
				case 290:
					array[2] = (byte)num20;
					num2 = 424;
					if (XR() != null)
					{
						num2 = 14;
					}
					continue;
				case 282:
					array[30] = (byte)num22;
					num2 = 298;
					continue;
				case 333:
					array[18] = 136;
					num2 = 124;
					if (gF())
					{
						continue;
					}
					break;
				case 117:
					array3[12] = (byte)num21;
					num2 = 122;
					continue;
				case 271:
					num22 = 232 - 77;
					num2 = 193;
					continue;
				case 309:
					array3[6] = (byte)num21;
					num2 = 34;
					if (gF())
					{
						continue;
					}
					break;
				case 216:
					num21 = 231 - 77;
					num2 = 331;
					continue;
				case 139:
					array[11] = (byte)num20;
					num2 = 72;
					continue;
				case 235:
					num26 = num4;
					num2 = 408;
					continue;
				case 98:
					num24 = 133 - 44;
					num2 = 142;
					continue;
				case 248:
					array[29] = 132;
					num2 = 100;
					continue;
				case 126:
					array3[7] = (byte)num21;
					num2 = 283;
					if (XR() != null)
					{
						num2 = 164;
					}
					continue;
				case 387:
					array3[5] = (byte)num24;
					num2 = 44;
					continue;
				case 375:
					array3[6] = 80;
					num2 = 332;
					if (gF())
					{
						continue;
					}
					break;
				case 158:
					array[12] = 122;
					num2 = 374;
					if (gF())
					{
						continue;
					}
					break;
				case 62:
					array[19] = (byte)num20;
					num2 = 182;
					if (XR() == null)
					{
						num2 = 187;
					}
					continue;
				case 106:
					num22 = 100 + 70;
					num2 = 163;
					continue;
				case 100:
					num20 = 233 - 77;
					num2 = 87;
					continue;
				case 27:
					array[7] = 58;
					num2 = 372;
					continue;
				case 390:
					array3[3] = (byte)num21;
					num2 = 371;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 298:
					array[30] = 194;
					num2 = 355;
					continue;
				case 237:
					array3[11] = 148;
					num2 = 110;
					continue;
				case 225:
					array[8] = (byte)num20;
					num2 = 5;
					if (XR() == null)
					{
						num2 = 23;
					}
					continue;
				case 329:
					num20 = 166 - 55;
					num2 = 290;
					continue;
				case 39:
					num22 = 228 - 76;
					num = 66;
					break;
				case 409:
					num21 = 142 - 47;
					num2 = 126;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 412:
					num22 = 126 - 42;
					num2 = 273;
					continue;
				case 434:
					num21 = 119 + 85;
					num2 = 309;
					continue;
				case 342:
					array[24] = 156;
					num2 = 410;
					continue;
				case 393:
					num20 = 217 - 72;
					num2 = 304;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 218:
					array[5] = 91;
					num2 = 352;
					continue;
				case 80:
					num20 = 117 + 109;
					num2 = 75;
					continue;
				case 22:
					array3[8] = 84;
					num = 268;
					break;
				case 441:
					array3[12] = 44;
					num2 = 182;
					continue;
				case 70:
					num20 = 140 - 46;
					num2 = 46;
					continue;
				case 252:
					array3[11] = 86;
					num2 = 0;
					if (XR() == null)
					{
						num2 = 0;
					}
					continue;
				case 380:
					array[14] = (byte)num22;
					num2 = 291;
					continue;
				case 187:
					array[19] = 87;
					num2 = 49;
					continue;
				case 83:
					num20 = 106 + 87;
					num2 = 176;
					continue;
				case 46:
					array[26] = (byte)num20;
					num = 146;
					break;
				case 254:
					array3[15] = (byte)num24;
					num2 = 169;
					continue;
				case 370:
					array3[14] = (byte)num24;
					num2 = 231;
					continue;
				case 121:
					array[21] = (byte)num22;
					num2 = 274;
					continue;
				case 270:
					if (publicKeyToken != null)
					{
						num2 = 129;
						continue;
					}
					goto case 338;
				case 38:
					array[2] = 180;
					num2 = 190;
					if (gF())
					{
						num2 = 329;
					}
					continue;
				case 325:
					uww.XdJ();
					num2 = 339;
					if (XR() == null)
					{
						num2 = 386;
					}
					continue;
				case 263:
					array3[0] = 157;
					num2 = 47;
					continue;
				case 129:
					if (publicKeyToken.Length > 0)
					{
						num2 = 322;
						continue;
					}
					goto case 338;
				case 195:
					return "";
				case 278:
					array[21] = (byte)num20;
					num2 = 287;
					continue;
				case 141:
					num20 = 46 + 51;
					num2 = 14;
					if (gF())
					{
						continue;
					}
					break;
				case 251:
					array[18] = 54;
					num2 = 333;
					continue;
				case 73:
					num21 = 158 - 58;
					num2 = 196;
					if (gF())
					{
						continue;
					}
					break;
				case 32:
					array3[8] = 128;
					num2 = 334;
					if (gF())
					{
						continue;
					}
					break;
				case 213:
					array3[13] = (byte)num21;
					num2 = 143;
					continue;
				case 318:
					num21 = 137 - 45;
					num2 = 276;
					continue;
				case 122:
					array3[12] = 141;
					num2 = 143;
					if (XR() == null)
					{
						num2 = 267;
					}
					continue;
				case 16:
					array[11] = (byte)num20;
					num2 = 228;
					continue;
				case 431:
					array[17] = (byte)num22;
					num2 = 313;
					continue;
				case 347:
					num40 = 0;
					num2 = 171;
					continue;
				case 155:
					array[28] = (byte)num22;
					num2 = 432;
					continue;
				case 376:
					array3[5] = (byte)num24;
					num2 = 3;
					continue;
				case 305:
					array[26] = (byte)num20;
					num = 396;
					break;
				case 55:
					array[6] = (byte)num20;
					num2 = 36;
					continue;
				case 340:
					num21 = 136 - 45;
					num2 = 343;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 399:
					num20 = 91 + 110;
					num = 115;
					break;
				case 330:
					array[1] = (byte)num22;
					num2 = 324;
					continue;
				case 190:
					array3[14] = (byte)num24;
					num2 = 346;
					if (gF())
					{
						continue;
					}
					break;
				case 353:
					array[3] = (byte)num20;
					num2 = 356;
					continue;
				case 19:
					Gdg = array5;
					num = 37;
					break;
				case 295:
					num22 = 92 - 58;
					num2 = 97;
					continue;
				case 296:
					array[20] = (byte)num22;
					num2 = 437;
					if (gF())
					{
						continue;
					}
					break;
				case 26:
					array[21] = 184;
					num2 = 425;
					continue;
				case 246:
					array3[4] = (byte)num21;
					num2 = 286;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 345:
					array[0] = (byte)num22;
					num2 = 186;
					continue;
				case 360:
					num36 = array6.Length / 4;
					num = 101;
					break;
				case 102:
					num33 = 0;
					num = 414;
					break;
				case 96:
					array[23] = (byte)num22;
					num2 = 21;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 66:
					array[18] = (byte)num22;
					num2 = 18;
					continue;
				case 60:
					array[7] = 111;
					num2 = 27;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 337:
				case 349:
					num33++;
					num2 = 413;
					continue;
				case 234:
					array3[0] = 162;
					num2 = 264;
					continue;
				case 7:
					array[1] = (byte)num22;
					num2 = 179;
					if (gF())
					{
						continue;
					}
					break;
				case 87:
					array[29] = (byte)num20;
					num2 = 233;
					continue;
				case 307:
					num22 = 51 + 87;
					num2 = 214;
					if (XR() != null)
					{
						num2 = 73;
					}
					continue;
				case 321:
					num35 = num26 ^ num27;
					num2 = 382;
					continue;
				case 6:
					num20 = 124 + 73;
					num2 = 284;
					continue;
				case 236:
					num21 = 198 - 66;
					num = 390;
					break;
				case 31:
				case 42:
					if (num32 >= num30)
					{
						num2 = 337;
						continue;
					}
					goto case 269;
				case 175:
					num20 = 156 - 52;
					num2 = 58;
					if (XR() == null)
					{
						num2 = 62;
					}
					continue;
				case 396:
					num22 = 232 + 11;
					num2 = 363;
					continue;
				case 199:
					array3[13] = (byte)num21;
					num2 = 144;
					if (gF())
					{
						num2 = 328;
					}
					continue;
				case 443:
					array3[2] = 15;
					num2 = 56;
					continue;
				case 15:
					array[5] = (byte)num20;
					num2 = 399;
					if (XR() != null)
					{
						num2 = 151;
					}
					continue;
				case 200:
					array4[5] = publicKeyToken[2];
					num2 = 15;
					if (gF())
					{
						num2 = 33;
					}
					continue;
				case 40:
					num20 = 108 + 53;
					num2 = 16;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 262:
					array4[15] = publicKeyToken[7];
					num2 = 338;
					continue;
				case 142:
					array3[15] = (byte)num24;
					num2 = 105;
					continue;
				case 367:
					num22 = 223 - 74;
					num2 = 301;
					continue;
				case 344:
					array[22] = 84;
					num2 = 13;
					if (XR() != null)
					{
						num2 = 0;
					}
					continue;
				case 41:
					num22 = 25 + 0;
					num2 = 20;
					if (gF())
					{
						num2 = 442;
					}
					continue;
				case 105:
					array3[15] = 161;
					num2 = 405;
					continue;
				case 90:
					num27 = (uint)((array6[num28 + 3] << 24) | (array6[num28 + 2] << 16) | (array6[num28 + 1] << 8) | array6[num28]);
					num2 = 296;
					if (gF())
					{
						num2 = 388;
					}
					continue;
				case 50:
					num39++;
					num2 = 242;
					continue;
				case 253:
					num20 = 101 + 62;
					num2 = 212;
					continue;
				case 21:
					num20 = 76 + 93;
					num2 = 232;
					if (XR() != null)
					{
						num2 = 179;
					}
					continue;
				case 92:
					array[3] = 123;
					num2 = 145;
					continue;
				case 104:
					num20 = 203 - 67;
					num2 = 300;
					continue;
				case 54:
					array[29] = (byte)num20;
					num2 = 335;
					if (gF())
					{
						continue;
					}
					break;
				case 433:
					num22 = 33 + 107;
					num2 = 279;
					continue;
				case 362:
					array[3] = (byte)num22;
					num2 = 92;
					continue;
				case 115:
					array[6] = (byte)num20;
					num2 = 137;
					continue;
				case 5:
					array[21] = 122;
					num2 = 43;
					continue;
				case 133:
					num24 = 7 + 61;
					num2 = 103;
					continue;
				case 286:
					array3[4] = 127;
					num2 = 240;
					continue;
				case 232:
					array[24] = (byte)num20;
					num2 = 342;
					continue;
				case 179:
					num22 = 166 - 55;
					num = 330;
					break;
				case 185:
					array3[5] = (byte)num21;
					num2 = 434;
					continue;
				case 381:
					num26 += num38;
					num2 = 308;
					if (gF())
					{
						continue;
					}
					break;
				case 311:
					array[14] = 41;
					num = 420;
					break;
				case 103:
					array3[1] = (byte)num24;
					num2 = 148;
					continue;
				case 439:
					num24 = 14 + 71;
					num2 = 436;
					continue;
				case 445:
					num20 = 97 + 114;
					num2 = 2;
					continue;
				case 72:
					array[11] = 158;
					num2 = 40;
					continue;
				case 17:
					array[21] = (byte)num22;
					num2 = 277;
					if (XR() != null)
					{
						num2 = 141;
					}
					continue;
				case 300:
					array[12] = (byte)num20;
					num2 = 158;
					continue;
				case 411:
					cryptoStream.Close();
					num2 = 8;
					continue;
				case 338:
					num37 = 0;
					num2 = 259;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 183:
					stream = hRB();
					num2 = 85;
					continue;
				case 167:
					array3[7] = 190;
					num = 409;
					break;
				case 332:
					array3[6] = 88;
					num = 249;
					break;
				case 299:
					array[19] = (byte)num20;
					num = 245;
					break;
				case 144:
					num21 = 116 + 46;
					num2 = 185;
					continue;
				case 301:
					array[4] = (byte)num22;
					num = 412;
					break;
				case 281:
					num21 = 151 - 50;
					num2 = 261;
					if (gF())
					{
						continue;
					}
					break;
				case 109:
					Array.Reverse(array4);
					num2 = 4;
					continue;
				case 86:
					array3[14] = (byte)num21;
					num2 = 257;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 77:
					array4[11] = publicKeyToken[5];
					num2 = 11;
					if (XR() != null)
					{
						num2 = 8;
					}
					continue;
				case 148:
					array3[1] = 107;
					num = 314;
					break;
				case 174:
					array[10] = (byte)num20;
					num2 = 210;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 152:
					num27 <<= 8;
					num2 = 81;
					continue;
				case 107:
					array[2] = 76;
					num2 = 71;
					continue;
				case 277:
					num22 = 16 + 13;
					num2 = 121;
					continue;
				case 419:
					array[15] = 144;
					num2 = 294;
					continue;
				case 292:
					array3[2] = 144;
					num2 = 443;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 143:
					array3[14] = 165;
					num2 = 76;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 169:
					array4 = array3;
					num2 = 109;
					continue;
				case 164:
					array5[num34 + 1] = (byte)((num35 & 0xFF00) >> 8);
					num2 = 221;
					continue;
				case 341:
					num20 = 191 - 63;
					num2 = 94;
					continue;
				case 417:
					array[23] = 113;
					num = 80;
					break;
				case 37:
					count = BitConverter.ToInt32(Gdg, P_0);
					num2 = 135;
					continue;
				case 11:
					array4[13] = publicKeyToken[6];
					num2 = 262;
					continue;
				case 208:
					array[27] = 183;
					num2 = 64;
					continue;
				case 273:
					array[4] = (byte)num22;
					num2 = 315;
					if (gF())
					{
						continue;
					}
					break;
				case 364:
					array3[1] = (byte)num21;
					num2 = 369;
					continue;
				case 287:
					array[22] = 146;
					num2 = 104;
					if (gF())
					{
						num2 = 191;
					}
					continue;
				case 101:
					array5 = new byte[array6.Length];
					num2 = 306;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 63:
					num20 = 94 + 27;
					num2 = 127;
					if (XR() != null)
					{
						num2 = 5;
					}
					continue;
				case 383:
					num20 = 127 - 42;
					num = 323;
					break;
				case 275:
					array[24] = (byte)num20;
					num2 = 366;
					continue;
				case 149:
					array3[13] = 101;
					num2 = 348;
					if (gF())
					{
						continue;
					}
					break;
				case 59:
					if (Gdg.Length == 0)
					{
						num2 = 58;
						continue;
					}
					goto case 37;
				case 319:
					num22 = 0 + 56;
					num = 244;
					break;
				case 313:
					num20 = 136 - 45;
					num2 = 67;
					if (XR() != null)
					{
						num2 = 43;
					}
					continue;
				case 258:
					array6 = uww.AdZ((int)uww.KDikMXewCI().Length);
					num2 = 325;
					if (!gF())
					{
						num2 = 64;
					}
					continue;
				case 224:
				case 259:
					if (num37 >= array4.Length)
					{
						num2 = 186;
						if (gF())
						{
							num2 = 260;
						}
						continue;
					}
					goto case 197;
				case 426:
					array[26] = (byte)num20;
					num2 = 109;
					if (XR() == null)
					{
						num2 = 307;
					}
					continue;
				case 132:
					array[2] = (byte)num22;
					num2 = 177;
					continue;
				case 408:
					if (num33 == num36 - 1)
					{
						num2 = 154;
						if (XR() != null)
						{
							num2 = 116;
						}
						continue;
					}
					goto case 321;
				case 124:
					array[18] = 98;
					num2 = 168;
					if (gF())
					{
						num2 = 295;
					}
					continue;
				case 442:
					array[10] = (byte)num22;
					num2 = 74;
					continue;
				case 193:
					array[13] = (byte)num22;
					num2 = 83;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 226:
					array[5] = (byte)num22;
					num2 = 201;
					continue;
				case 284:
					array[5] = (byte)num20;
					num2 = 118;
					continue;
				case 365:
					array[23] = (byte)num22;
					num2 = 417;
					continue;
				case 440:
					array3 = new byte[16];
					num2 = 21;
					if (gF())
					{
						num2 = 24;
					}
					continue;
				case 25:
					array3[9] = 39;
					num2 = 65;
					continue;
				case 162:
					array[9] = (byte)num20;
					num2 = 181;
					continue;
				case 140:
					array[16] = 70;
					num2 = 327;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 69:
					num24 = 174 - 58;
					num2 = 239;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 81:
					num27 |= array6[array6.Length - (1 + num39)];
					num2 = 50;
					continue;
				case 406:
					array5[num34 + num32] = (byte)((num25 & num23) >> num40);
					num2 = 230;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 320:
					num21 = 124 + 73;
					num2 = 246;
					continue;
				case 327:
					array[16] = 81;
					num2 = 265;
					continue;
				case 51:
					array[12] = (byte)num20;
					num2 = 302;
					continue;
				case 317:
					num24 = 153 - 32;
					num2 = 254;
					continue;
				case 30:
					num21 = 160 + 10;
					num = 438;
					break;
				case 403:
					num20 = 14 + 119;
					num2 = 305;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 181:
					array[9] = 128;
					num2 = 373;
					continue;
				case 436:
					array3[7] = (byte)num24;
					num2 = 91;
					continue;
				case 425:
					array[21] = 141;
					num2 = 5;
					continue;
				case 352:
					num22 = 208 - 69;
					num2 = 168;
					continue;
				case 10:
					array[22] = (byte)num22;
					num2 = 310;
					continue;
				case 94:
					array[0] = (byte)num20;
					num2 = 130;
					continue;
				case 437:
					num22 = 74 + 36;
					num2 = 78;
					if (gF())
					{
						continue;
					}
					break;
				case 49:
					num20 = 97 + 91;
					num2 = 299;
					continue;
				case 153:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 395;
					continue;
				case 191:
					num22 = 199 - 66;
					num2 = 10;
					continue;
				case 206:
					array[27] = (byte)num20;
					num2 = 119;
					if (XR() == null)
					{
						num2 = 427;
					}
					continue;
				case 297:
					num27 = 0u;
					num2 = 398;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 123:
					num20 = 226 - 75;
					num2 = 55;
					continue;
				case 418:
					array[20] = (byte)num22;
					num2 = 89;
					if (gF())
					{
						num2 = 112;
					}
					continue;
				case 186:
					num20 = 226 - 75;
					num2 = 312;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 283:
					num21 = 71 + 1;
					num2 = 198;
					continue;
				case 328:
					array3[13] = 149;
					num2 = 318;
					continue;
				case 366:
					array[25] = 147;
					num2 = 253;
					continue;
				case 310:
					num20 = 110 + 25;
					num2 = 46;
					if (gF())
					{
						num2 = 116;
					}
					continue;
				case 385:
					num20 = 207 - 69;
					num2 = 1;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 435:
					if (num30 > 0)
					{
						num2 = 138;
						continue;
					}
					goto case 381;
				case 312:
					array[0] = (byte)num20;
					num2 = 293;
					if (gF())
					{
						continue;
					}
					break;
				case 244:
					array[20] = (byte)num22;
					num2 = 354;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 118:
					array[5] = 127;
					num = 218;
					break;
				case 372:
					array[7] = 208;
					num2 = 429;
					continue;
				case 369:
					array3[1] = 86;
					num = 133;
					break;
				case 413:
				case 414:
					if (num33 >= num36)
					{
						num2 = 19;
						continue;
					}
					goto case 357;
				case 269:
					if (num32 > 0)
					{
						num2 = 108;
						if (gF())
						{
							num2 = 416;
						}
						continue;
					}
					goto case 406;
				case 78:
					array[20] = (byte)num22;
					num2 = 389;
					continue;
				case 176:
					array[13] = (byte)num20;
					num2 = 311;
					continue;
				case 217:
				case 388:
					num4 = num26;
					num = 53;
					break;
				case 52:
					num22 = 42 + 96;
					num2 = 282;
					continue;
				case 178:
					array[10] = (byte)num22;
					num2 = 128;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 8:
					array6 = Gdg;
					num2 = 111;
					continue;
				case 219:
					array[25] = 142;
					num2 = 192;
					continue;
				case 391:
					if (num39 > 0)
					{
						num2 = 152;
						continue;
					}
					goto case 81;
				case 423:
					array[11] = (byte)num20;
					num2 = 104;
					continue;
				case 229:
					array[7] = 170;
					num2 = 383;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 165:
					array3[11] = (byte)num21;
					num2 = 358;
					continue;
				case 241:
					array[31] = (byte)num20;
					num2 = 280;
					if (gF())
					{
						continue;
					}
					break;
				case 266:
					array[16] = (byte)num20;
					num2 = 359;
					continue;
				case 302:
					array[12] = 133;
					num2 = 95;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 171:
					if (num33 == num36 - 1)
					{
						num2 = 435;
						continue;
					}
					goto case 381;
				case 221:
					array5[num34 + 2] = (byte)((num35 & 0xFF0000) >> 16);
					num2 = 84;
					continue;
				case 97:
					array[18] = (byte)num22;
					num2 = 175;
					continue;
				case 108:
					num26 = 0u;
					num2 = 88;
					if (!gF())
					{
						num2 = 4;
					}
					continue;
				case 75:
					array[23] = (byte)num20;
					num2 = 401;
					continue;
				case 156:
					array[27] = (byte)num22;
					num2 = 256;
					if (gF())
					{
						continue;
					}
					break;
				case 351:
					array3[5] = 124;
					num2 = 144;
					continue;
				case 74:
					num22 = 177 - 59;
					num2 = 178;
					if (gF())
					{
						continue;
					}
					break;
				case 264:
					num21 = 70 + 60;
					num2 = 364;
					continue;
				case 57:
					num32 = 0;
					num2 = 31;
					if (!gF())
					{
						num2 = 4;
					}
					continue;
				case 276:
					array3[13] = (byte)num21;
					num2 = 149;
					if (gF())
					{
						continue;
					}
					break;
				case 44:
					num24 = 47 + 90;
					num2 = 376;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 354:
					num22 = 121 + 22;
					num2 = 296;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 249:
					array3[6] = 111;
					num2 = 73;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 82:
					num20 = 181 - 102;
					num2 = 29;
					if (XR() != null)
					{
						num2 = 5;
					}
					continue;
				case 157:
					num24 = 29 + 80;
					num2 = 387;
					continue;
				case 67:
					array[17] = (byte)num20;
					num2 = 89;
					continue;
				case 89:
					array[17] = 104;
					num2 = 222;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 220:
					array3[1] = 158;
					num2 = 69;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 196:
					array3[6] = (byte)num21;
					num2 = 167;
					continue;
				case 68:
					array3[3] = 88;
					num2 = 236;
					continue;
				case 205:
					array[31] = 175;
					num2 = 397;
					if (XR() != null)
					{
						num2 = 248;
					}
					continue;
				default:
					array3[11] = 34;
					num = 194;
					break;
				case 306:
					num31 = array2.Length / 4;
					num = 108;
					break;
				case 261:
					array3[10] = (byte)num21;
					num2 = 28;
					continue;
				case 314:
					num21 = 207 - 69;
					num2 = 173;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 154:
					if (num30 > 0)
					{
						num2 = 255;
						continue;
					}
					goto case 321;
				case 65:
					array3[9] = 174;
					num2 = 428;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 293:
					array[0] = 72;
					num2 = 63;
					if (XR() != null)
					{
						num2 = 32;
					}
					continue;
				case 355:
					array[31] = 93;
					num2 = 141;
					continue;
				case 202:
					array3[4] = 107;
					num2 = 102;
					if (XR() == null)
					{
						num2 = 320;
					}
					continue;
				case 222:
					num20 = 162 - 61;
					num = 289;
					break;
				case 322:
					array4[1] = publicKeyToken[0];
					num2 = 303;
					continue;
				case 336:
					array[4] = 112;
					num2 = 367;
					continue;
				case 110:
					num21 = 181 - 60;
					num2 = 165;
					if (!gF())
					{
						num2 = 161;
					}
					continue;
				case 151:
					num28 = 0u;
					num2 = 102;
					if (XR() != null)
					{
						num2 = 77;
					}
					continue;
				case 346:
					num21 = 237 - 79;
					num2 = 86;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 64:
					num22 = 209 - 69;
					num2 = 156;
					continue;
				case 53:
					num26 = 0u;
					num2 = 400;
					continue;
				case 420:
					array[14] = 127;
					num2 = 12;
					continue;
				case 201:
					num20 = 110 - 48;
					num2 = 15;
					if (XR() != null)
					{
						num2 = 8;
					}
					continue;
				case 324:
					array[1] = 211;
					num2 = 38;
					continue;
				case 197:
					array2[num37] ^= array4[num37];
					num2 = 150;
					if (gF())
					{
						continue;
					}
					break;
				case 240:
					array3[4] = 231;
					num2 = 157;
					continue;
				case 24:
					num21 = 63 + 4;
					num2 = 272;
					if (gF())
					{
						continue;
					}
					break;
				case 255:
					num25 = num26 ^ num27;
					num2 = 57;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 131:
					num22 = 71 + 49;
					num = 365;
					break;
				case 238:
					array[26] = (byte)num20;
					num2 = 403;
					continue;
				case 410:
					array[24] = 44;
					num2 = 114;
					continue;
				case 392:
					array[16] = (byte)num22;
					num = 140;
					break;
				case 61:
					array3[10] = (byte)num24;
					num = 237;
					break;
				case 134:
					num22 = 187 - 62;
					num2 = 115;
					if (XR() == null)
					{
						num2 = 155;
					}
					continue;
				case 215:
					num23 = 255u;
					num2 = 347;
					continue;
				case 23:
					array[8] = 91;
					num2 = 113;
					continue;
				case 112:
					array[20] = 205;
					num2 = 445;
					continue;
				case 368:
					array[30] = (byte)num22;
					num2 = 52;
					if (XR() == null)
					{
						continue;
					}
					break;
				case 359:
					num22 = 36 + 117;
					num2 = 392;
					continue;
				case 113:
					array[8] = 28;
					num2 = 166;
					continue;
				case 223:
					num20 = 198 - 66;
					num2 = 161;
					continue;
				case 214:
					array[26] = (byte)num22;
					num2 = 70;
					if (gF())
					{
						continue;
					}
					break;
				case 400:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 10623062u;
					uint num7 = 82033301u;
					uint num8 = 1362563555u;
					uint num9 = num5;
					uint num10 = 819560168u;
					uint num11 = 33155205u;
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
					num2 = 235;
					if (gF())
					{
						continue;
					}
					break;
				}
				}
				break;
			}
		}
	}

	[xdt(typeof(xdt.Ydn<object>[]))]
	internal static string yRr(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int QRv()
	{
		return 5;
	}

	private static void TRp()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate NRW(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object NRi(object P_0)
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
	public static extern IntPtr dRZ(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr rRt(IntPtr P_0, string P_1);

	private static IntPtr kRn(IntPtr P_0, string P_1, uint P_2)
	{
		if (Edy == null)
		{
			IntPtr ptr = rRt(umLocehuEC(), "Find ".Trim() + "ResourceA");
			Edy = (kw2)Marshal.GetDelegateForFunctionPointer(ptr, typeof(kw2));
		}
		return Edy(P_0, P_1, P_2);
	}

	private static IntPtr eRJ(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (zdm == null)
		{
			IntPtr ptr = rRt(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			zdm = (OwH)Marshal.GetDelegateForFunctionPointer(ptr, typeof(OwH));
		}
		return zdm(P_0, P_1, P_2, P_3);
	}

	private static int pRe(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (IdS == null)
		{
			IntPtr ptr = rRt(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			IdS = (TwG)Marshal.GetDelegateForFunctionPointer(ptr, typeof(TwG));
		}
		return IdS(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int URk(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (od1 == null)
		{
			IntPtr ptr = rRt(umLocehuEC(), "Virtual ".Trim() + "Protect");
			od1 = (Mwf)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Mwf));
		}
		return od1(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr URE(uint P_0, int P_1, uint P_2)
	{
		if (pd8 == null)
		{
			IntPtr ptr = rRt(umLocehuEC(), "Open ".Trim() + "Process");
			pd8 = (Nwk)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Nwk));
		}
		return pd8(P_0, P_1, P_2);
	}

	private static int YR7(IntPtr P_0)
	{
		if (odr == null)
		{
			IntPtr ptr = rRt(umLocehuEC(), "Close ".Trim() + "Handle");
			odr = (jw1)Marshal.GetDelegateForFunctionPointer(ptr, typeof(jw1));
		}
		return odr(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (odv == IntPtr.Zero)
		{
			odv = dRZ("kernel ".Trim() + "32.dll");
		}
		return odv;
	}

	[xdt(typeof(xdt.Ydn<object>[]))]
	private static byte[] wR4(string P_0)
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

	internal static Stream hRB()
	{
		return new MemoryStream();
	}

	internal static byte[] HRh(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[xdt(typeof(xdt.Ydn<object>[]))]
	private static byte[] gRw(byte[] P_0)
	{
		Stream stream = hRB();
		SymmetricAlgorithm symmetricAlgorithm = hR5();
		symmetricAlgorithm.Key = new byte[32]
		{
			40, 1, 82, 166, 29, 91, 133, 115, 125, 132,
			195, 21, 205, 3, 245, 211, 36, 59, 103, 109,
			63, 22, 230, 105, 219, 44, 189, 4, 42, 45,
			83, 214
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			143, 141, 222, 85, 164, 55, 42, 148, 75, 76,
			63, 106, 142, 247, 56, 127
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = HRh(stream);
		awj.QuEwGz();
		return result;
	}

	private byte[] VRN()
	{
		return null;
	}

	private byte[] DRU()
	{
		return null;
	}

	private byte[] mRz()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] fdQ()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] UdV()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] ndC()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] od6()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] AdM()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] hds()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Rdj()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool gF()
	{
		return (object)null == null;
	}

	internal static object XR()
	{
		return null;
	}
}
