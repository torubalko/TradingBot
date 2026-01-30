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

internal class xv
{
	private delegate void k8(object o);

	internal class d9 : Attribute
	{
		internal class S3<XL>
		{
			internal static object FXb;

			public S3()
			{
				fc.taYSkz();
				base._002Ector();
			}

			internal static bool sXz()
			{
				return FXb == null;
			}

			internal static object B9Q()
			{
				return FXb;
			}
		}

		[d9(typeof(S3<object>[]))]
		public d9(object P_0)
		{
		}
	}

	internal class oj
	{
		[d9(typeof(d9.S3<object>[]))]
		internal static string lY1(string P_0, string P_1)
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
			byte[] iV = DTs(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = nTD();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint xx(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr ba();

	internal struct Ni
	{
		internal bool kYt;

		internal byte[] AYU;
	}

	internal class Rb
	{
		private BinaryReader AYW;

		public Rb(Stream P_0)
		{
			AYW = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return AYW.BaseStream;
		}

		internal byte[] AY6(int P_0)
		{
			return AYW.ReadBytes(P_0);
		}

		internal int oYq(byte[] P_0, int P_1, int P_2)
		{
			return AYW.Read(P_0, P_1, P_2);
		}

		internal int CYJ()
		{
			return AYW.ReadInt32();
		}

		internal void cY5()
		{
			AYW.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ch(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr qZ(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int TH(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int tD(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr I7(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int @is(IntPtr ptr);

	[Flags]
	private enum EF
	{

	}

	private static bool Por;

	private static object toX;

	private static byte[] kov;

	private static IntPtr Fo8;

	private static int[] PoL;

	private static int soj;

	private static long Pob;

	private static bool jo7;

	private static TH No4;

	private static tD moS;

	private static IntPtr aYP;

	private static int FoD;

	private static ch Lo0;

	private static byte[] go2;

	private static bool Nox;

	private static byte[] iou;

	private static I7 Yoz;

	private static bool Xos;

	internal static xx uoZ;

	private static int VoF;

	private static bool BoG;

	private static Dictionary<int, int> uow;

	private static uint[] Ioe;

	private static long doH;

	internal static RSACryptoServiceProvider yoO;

	internal static Hashtable bof;

	private static object Qo3;

	private static qZ SoA;

	internal static Assembly loM;

	private static SortedList yoa;

	[d9(typeof(d9.S3<object>[]))]
	private static bool zoV;

	private static @is VYI;

	private static IntPtr zoc;

	private static int doi;

	internal static xx Loh;

	private static bool foR;

	private static IntPtr ro9;

	static xv()
	{
		foR = false;
		loM = typeof(xv).Assembly;
		Ioe = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		Por = false;
		BoG = false;
		iou = new byte[0];
		yoO = null;
		uow = null;
		toX = new object();
		go2 = new byte[0];
		kov = new byte[0];
		Fo8 = IntPtr.Zero;
		ro9 = IntPtr.Zero;
		Qo3 = new string[0];
		PoL = new int[0];
		soj = 1;
		Nox = false;
		yoa = new SortedList();
		doi = 0;
		Pob = 0L;
		Loh = null;
		uoZ = null;
		doH = 0L;
		FoD = 0;
		jo7 = false;
		Xos = false;
		VoF = 0;
		zoc = IntPtr.Zero;
		zoV = false;
		bof = new Hashtable();
		Lo0 = null;
		SoA = null;
		No4 = null;
		moS = null;
		Yoz = null;
		VYI = null;
		aYP = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void zaYSkP()
	{
	}

	internal static byte[] FTx(byte[] P_0)
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
			OTa(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			OTa(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			OTa(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			OTa(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			OTa(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			OTa(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			OTa(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			OTa(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			OTa(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			OTa(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			OTa(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			OTa(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			OTa(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			OTa(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			OTa(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			OTa(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			HTi(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			HTi(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			HTi(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			HTi(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			HTi(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			HTi(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			HTi(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			HTi(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			HTi(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			HTi(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			HTi(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			HTi(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			HTi(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			HTi(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			HTi(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			HTi(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			oTb(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			oTb(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			oTb(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			oTb(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			oTb(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			oTb(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			oTb(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			oTb(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			oTb(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			oTb(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			oTb(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			oTb(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			oTb(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			oTb(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			oTb(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			oTb(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			jTh(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			jTh(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			jTh(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			jTh(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			jTh(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			jTh(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			jTh(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			jTh(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			jTh(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			jTh(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			jTh(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			jTh(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			jTh(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			jTh(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			jTh(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			jTh(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void OTa(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + KTZ(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + Ioe[P_6 - 1], P_5);
	}

	private static void HTi(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + KTZ(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + Ioe[P_6 - 1], P_5);
	}

	private static void oTb(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + KTZ(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + Ioe[P_6 - 1], P_5);
	}

	private static void jTh(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + KTZ(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + Ioe[P_6 - 1], P_5);
	}

	private static uint KTZ(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool OTH()
	{
		if (!Por)
		{
			bT7();
			Por = true;
		}
		return BoG;
	}

	internal static SymmetricAlgorithm nTD()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (OTH())
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

	internal static void bT7()
	{
		try
		{
			BoG = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] DTs(byte[] P_0)
	{
		if (!OTH())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return FTx(P_0);
	}

	internal static void eTF(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			hTc(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void hTc(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint GTV(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

	public static void XTf(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (uow == null)
			{
				lock (toX)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(xv).Assembly.GetManifestResourceStream("okS0Twg5eJRIxPWYEN.jwbwFLnia3LSQpQuRB"));
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
							num3 += VT4(num3);
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
						Rb rb = new Rb(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = rb.CYJ();
							int value = rb.CYJ();
							dictionary.Add(key, value);
						}
						rb.cY5();
					}
					uow = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = uow[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(xv).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint qTA(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint VT4(uint P_0)
	{
		return 0u;
	}

	internal static void XTS()
	{
	}

	[d9(typeof(d9.S3<object>[]))]
	internal static string hTz(int P_0)
	{
		int num = 105;
		int num24 = default(int);
		int num22 = default(int);
		int num21 = default(int);
		byte[] array = default(byte[]);
		int num20 = default(int);
		byte[] array3 = default(byte[]);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		int num36 = default(int);
		byte[] array5 = default(byte[]);
		uint num27 = default(uint);
		int num44 = default(int);
		byte[] array2 = default(byte[]);
		Stream stream = default(Stream);
		Rb rb = default(Rb);
		int num23 = default(int);
		int num35 = default(int);
		uint num30 = default(uint);
		int num25 = default(int);
		byte[] publicKeyToken = default(byte[]);
		uint num26 = default(uint);
		byte[] array6 = default(byte[]);
		int num31 = default(int);
		uint num32 = default(uint);
		CryptoStream cryptoStream = default(CryptoStream);
		int num33 = default(int);
		byte[] array4 = default(byte[]);
		int count = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		uint num28 = default(uint);
		uint num29 = default(uint);
		int num43 = default(int);
		uint num4 = default(uint);
		uint num42 = default(uint);
		int num41 = default(int);
		int num38 = default(int);
		string result = default(string);
		int num40 = default(int);
		int num34 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					num24++;
					num2 = 59;
					if (R3())
					{
						continue;
					}
					break;
				case 177:
					num22 = 4 + 104;
					num2 = 237;
					if (R3())
					{
						continue;
					}
					break;
				case 150:
					num21 = 15 + 119;
					num = 413;
					break;
				case 254:
					array[12] = (byte)num20;
					num2 = 207;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 149:
					array3[3] = 37;
					num2 = 55;
					continue;
				case 299:
					array[28] = 116;
					num2 = 163;
					if (R3())
					{
						num2 = 245;
					}
					continue;
				case 385:
					array[12] = (byte)num21;
					num2 = 291;
					continue;
				case 200:
					array[2] = (byte)num20;
					num = 401;
					break;
				case 247:
					array[14] = (byte)num20;
					num2 = 212;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 364:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num2 = 139;
					if (cJ() == null)
					{
						num2 = 164;
					}
					continue;
				case 312:
					array[22] = 127;
					num2 = 206;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 306:
					num21 = 179 + 36;
					num2 = 119;
					if (!R3())
					{
						num2 = 3;
					}
					continue;
				case 145:
					array[13] = (byte)num21;
					num2 = 74;
					continue;
				case 404:
					num36 = array5.Length / 4;
					num2 = 327;
					if (R3())
					{
						continue;
					}
					break;
				case 382:
					num27 = 0u;
					num = 324;
					break;
				case 114:
				case 323:
					if (num44 >= array2.Length)
					{
						num2 = 17;
						if (cJ() == null)
						{
							num2 = 91;
						}
						continue;
					}
					goto case 231;
				case 348:
					Array.Reverse(array2);
					num2 = 129;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 172:
					array3[7] = (byte)num22;
					num2 = 120;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 305:
					num20 = 4 + 14;
					num = 398;
					break;
				case 142:
					array[2] = 86;
					num2 = 203;
					continue;
				case 221:
					num20 = 141 - 47;
					num2 = 125;
					continue;
				case 152:
					num20 = 201 - 67;
					num2 = 161;
					if (!R3())
					{
						num2 = 90;
					}
					continue;
				case 222:
					array[22] = 110;
					num2 = 140;
					continue;
				case 194:
					array3[10] = 173;
					num2 = 17;
					if (R3())
					{
						num2 = 264;
					}
					continue;
				case 49:
					array[21] = 82;
					num2 = 312;
					continue;
				case 31:
					stream = coK();
					num = 410;
					break;
				case 347:
					array[25] = (byte)num20;
					num2 = 258;
					continue;
				case 277:
					num22 = 117 + 109;
					num2 = 394;
					continue;
				case 399:
					array3[1] = 127;
					num2 = 34;
					continue;
				case 337:
					array[2] = (byte)num20;
					num = 142;
					break;
				case 350:
					array[7] = 123;
					num2 = 65;
					continue;
				case 320:
					array3[15] = (byte)num22;
					num = 3;
					break;
				case 298:
					array[3] = (byte)num21;
					num2 = 204;
					if (R3())
					{
						continue;
					}
					break;
				case 263:
					array3[8] = (byte)num22;
					num2 = 32;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 220:
					rb.KDikMXewCI().Position = 0L;
					num2 = 190;
					continue;
				case 192:
					num23 = 36 + 22;
					num2 = 79;
					continue;
				case 292:
					array3[4] = 146;
					num2 = 294;
					continue;
				case 93:
				case 115:
					num35++;
					num2 = 154;
					continue;
				case 276:
					array[2] = (byte)num21;
					num2 = 6;
					if (R3())
					{
						num2 = 9;
					}
					continue;
				case 245:
					array[28] = 143;
					num2 = 38;
					continue;
				case 13:
					array[27] = (byte)num21;
					num2 = 152;
					continue;
				case 140:
					array[22] = 118;
					num2 = 13;
					if (R3())
					{
						num2 = 16;
					}
					continue;
				case 86:
					array3[13] = (byte)num23;
					num2 = 288;
					if (R3())
					{
						continue;
					}
					break;
				case 300:
					array[21] = (byte)num20;
					num2 = 89;
					if (cJ() != null)
					{
						num2 = 64;
					}
					continue;
				case 344:
					num30 |= array5[array5.Length - (1 + num25)];
					num2 = 181;
					continue;
				case 73:
					array3[13] = 21;
					num = 329;
					break;
				case 235:
					num21 = 163 - 54;
					num2 = 215;
					if (R3())
					{
						num2 = 250;
					}
					continue;
				case 217:
					array2[9] = publicKeyToken[4];
					num2 = 293;
					if (!R3())
					{
						num2 = 2;
					}
					continue;
				case 57:
					array5 = go2;
					num2 = 92;
					continue;
				case 53:
					array[26] = (byte)num20;
					num2 = 287;
					continue;
				case 317:
					num23 = 138 - 46;
					num2 = 397;
					continue;
				case 60:
					array3[14] = (byte)num23;
					num2 = 230;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 244:
					array3[12] = 137;
					num2 = 141;
					continue;
				case 286:
					num23 = 128 - 42;
					num2 = 0;
					if (R3())
					{
						num2 = 0;
					}
					continue;
				case 168:
					num26 = 255u;
					num2 = 202;
					continue;
				case 77:
					array[8] = (byte)num21;
					num2 = 262;
					continue;
				case 69:
					array3[6] = (byte)num23;
					num2 = 317;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 315:
					num24 = 0;
					num2 = 171;
					continue;
				case 349:
					array3[2] = 120;
					num = 243;
					break;
				case 227:
					array[16] = (byte)num20;
					num2 = 208;
					continue;
				case 241:
					array[1] = (byte)num20;
					num2 = 99;
					if (cJ() == null)
					{
						num2 = 134;
					}
					continue;
				case 251:
					array[10] = 91;
					num2 = 358;
					if (R3())
					{
						continue;
					}
					break;
				case 301:
					array6[num31 + 3] = (byte)((num32 & 0xFF000000u) >> 24);
					num2 = 93;
					if (cJ() != null)
					{
						num2 = 81;
					}
					continue;
				case 352:
					num31 = num35 * 4;
					num2 = 297;
					continue;
				case 183:
					num23 = 208 + 5;
					num = 225;
					break;
				case 332:
					return "";
				case 257:
					num20 = 118 - 57;
					num2 = 351;
					continue;
				case 388:
					array[24] = (byte)num20;
					num2 = 0;
					if (R3())
					{
						num2 = 1;
					}
					continue;
				case 120:
					array3[8] = 139;
					num2 = 396;
					continue;
				case 29:
					array[29] = 100;
					num2 = 246;
					if (!R3())
					{
						num2 = 208;
					}
					continue;
				case 85:
					array2 = array3;
					num2 = 348;
					if (R3())
					{
						continue;
					}
					break;
				case 262:
					num20 = 64 + 14;
					num2 = 389;
					if (R3())
					{
						continue;
					}
					break;
				case 215:
					cryptoStream.Close();
					num2 = 57;
					continue;
				case 284:
					array[4] = 109;
					num = 158;
					break;
				case 226:
					array[30] = 132;
					num2 = 330;
					continue;
				case 224:
					array[1] = (byte)num20;
					num2 = 248;
					continue;
				case 156:
					if (publicKeyToken.Length > 0)
					{
						num = 139;
						break;
					}
					goto case 197;
				case 59:
				case 171:
					if (num24 >= num33)
					{
						num2 = 115;
						continue;
					}
					goto case 354;
				case 274:
					num20 = 196 - 65;
					num2 = 254;
					continue;
				case 355:
					num21 = 88 + 100;
					num = 122;
					break;
				case 187:
					num21 = 202 - 90;
					num2 = 311;
					if (R3())
					{
						continue;
					}
					break;
				case 88:
					array3[0] = (byte)num22;
					num2 = 282;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 125:
					array[16] = (byte)num20;
					num2 = 271;
					if (R3())
					{
						num2 = 379;
					}
					continue;
				case 16:
					num20 = 160 - 53;
					num2 = 23;
					continue;
				case 27:
					go2 = zoN(stream);
					num2 = 274;
					if (R3())
					{
						num2 = 316;
					}
					continue;
				case 266:
					array3[13] = (byte)num23;
					num2 = 255;
					continue;
				case 157:
					array[27] = (byte)num20;
					num2 = 299;
					continue;
				case 123:
					array[29] = 159;
					num2 = 29;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 413:
					array[19] = (byte)num21;
					num2 = 285;
					continue;
				case 407:
					array3[3] = (byte)num22;
					num2 = 240;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 231:
					array4[num44] ^= array2[num44];
					num2 = 380;
					continue;
				case 279:
					array[30] = 144;
					num2 = 226;
					continue;
				case 295:
					array[0] = 148;
					num2 = 100;
					continue;
				case 103:
					array[1] = (byte)num20;
					num2 = 151;
					continue;
				case 236:
					array[16] = (byte)num20;
					num2 = 371;
					continue;
				case 389:
					array[9] = (byte)num20;
					num2 = 341;
					if (R3())
					{
						continue;
					}
					break;
				case 99:
					rb = new Rb(loM.GetManifestResourceStream("8YujpnVt1mJZTw12cH.HyRbWHBSONaBlttiVv"));
					num2 = 220;
					continue;
				case 375:
					array[8] = 131;
					num2 = 47;
					continue;
				case 269:
					array[7] = (byte)num20;
					num2 = 21;
					if (cJ() == null)
					{
						num2 = 51;
					}
					continue;
				case 131:
					array[17] = 99;
					num2 = 8;
					if (R3())
					{
						num2 = 39;
					}
					continue;
				case 290:
					num30 = 0u;
					num2 = 165;
					if (R3())
					{
						num2 = 368;
					}
					continue;
				case 380:
					num44++;
					num2 = 323;
					continue;
				case 335:
					array[24] = 149;
					num2 = 238;
					if (R3())
					{
						continue;
					}
					break;
				case 104:
				case 165:
					count = BitConverter.ToInt32(go2, P_0);
					num2 = 234;
					continue;
				case 341:
					array[9] = 180;
					num2 = 378;
					if (R3())
					{
						continue;
					}
					break;
				case 21:
					array[18] = 121;
					num2 = 213;
					if (R3())
					{
						continue;
					}
					break;
				case 133:
					num23 = 238 + 2;
					num2 = 370;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 361:
					num20 = 234 - 78;
					num2 = 347;
					continue;
				case 164:
					transform = symmetricAlgorithm.CreateDecryptor(array4, array2);
					num2 = 31;
					continue;
				case 390:
					num21 = 247 - 82;
					num2 = 148;
					continue;
				case 363:
					array3[15] = 90;
					num2 = 261;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 15:
					array[31] = 100;
					num2 = 302;
					continue;
				case 110:
					array[14] = 14;
					num2 = 289;
					continue;
				case 41:
					num21 = 155 - 51;
					num2 = 19;
					continue;
				case 218:
					array[4] = (byte)num21;
					num2 = 284;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 268:
					num21 = 140 - 46;
					num2 = 211;
					continue;
				case 367:
					num20 = 125 - 41;
					num2 = 269;
					continue;
				case 62:
					array[11] = 183;
					num = 71;
					break;
				case 345:
					num28 = 0u;
					num2 = 290;
					continue;
				case 65:
					num21 = 202 - 67;
					num2 = 63;
					if (R3())
					{
						continue;
					}
					break;
				case 369:
					array[20] = 187;
					num2 = 143;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 36:
				case 154:
					if (num35 >= num36)
					{
						num2 = 28;
						continue;
					}
					goto case 117;
				case 92:
					num33 = array5.Length % 4;
					num2 = 404;
					continue;
				case 411:
					array3[13] = (byte)num22;
					num2 = 169;
					continue;
				case 271:
					array[12] = 134;
					num2 = 274;
					continue;
				case 3:
					num22 = 182 - 60;
					num2 = 339;
					continue;
				case 225:
					array3[5] = (byte)num23;
					num2 = 65;
					if (cJ() == null)
					{
						num2 = 87;
					}
					continue;
				case 78:
					num20 = 151 - 40;
					num2 = 167;
					if (!R3())
					{
						num2 = 138;
					}
					continue;
				case 136:
					array3[5] = 169;
					num2 = 183;
					continue;
				case 138:
					array3[12] = (byte)num23;
					num = 7;
					break;
				case 406:
					array[26] = 92;
					num2 = 6;
					if (cJ() == null)
					{
						num2 = 228;
					}
					continue;
				case 174:
					array3[11] = 89;
					num2 = 18;
					continue;
				case 228:
					num20 = 133 - 90;
					num = 53;
					break;
				case 393:
					array3[12] = 166;
					num2 = 244;
					continue;
				case 52:
					num22 = 233 - 77;
					num2 = 260;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 372:
					array3[11] = 134;
					num2 = 277;
					continue;
				case 402:
					num29 = 0u;
					num2 = 178;
					continue;
				case 386:
					array3[3] = 126;
					num2 = 232;
					continue;
				case 18:
					array3[11] = 31;
					num2 = 393;
					continue;
				case 258:
					num21 = 72 - 9;
					num2 = 377;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 173:
					if (num33 > 0)
					{
						num2 = 216;
						if (cJ() == null)
						{
							continue;
						}
						break;
					}
					goto case 121;
				case 339:
					array3[15] = (byte)num22;
					num2 = 363;
					continue;
				case 207:
					num21 = 77 + 42;
					num2 = 385;
					continue;
				case 63:
					array[7] = (byte)num21;
					num2 = 11;
					if (cJ() != null)
					{
						num2 = 2;
					}
					continue;
				case 370:
					array3[1] = (byte)num23;
					num2 = 286;
					continue;
				case 47:
					num21 = 64 - 61;
					num2 = 77;
					continue;
				case 144:
					array[28] = (byte)num21;
					num2 = 225;
					if (cJ() == null)
					{
						num2 = 326;
					}
					continue;
				case 203:
					array[2] = 94;
					num2 = 83;
					continue;
				case 19:
					array[8] = (byte)num21;
					num2 = 196;
					continue;
				case 294:
					array3[4] = 54;
					num2 = 229;
					continue;
				case 101:
					array[15] = 115;
					num2 = 223;
					continue;
				case 169:
					num23 = 40 - 14;
					num2 = 266;
					if (!R3())
					{
						num2 = 135;
					}
					continue;
				case 360:
					num23 = 99 + 69;
					num = 69;
					break;
				case 91:
					if (P_0 == -1)
					{
						num2 = 376;
						continue;
					}
					goto case 92;
				case 28:
					go2 = array6;
					num2 = 165;
					continue;
				case 124:
					array2[7] = publicKeyToken[3];
					num2 = 217;
					continue;
				case 278:
					array[1] = (byte)num20;
					num2 = 81;
					continue;
				case 252:
					num27 = 0u;
					num2 = 345;
					continue;
				case 392:
					array[18] = 157;
					num2 = 70;
					continue;
				case 308:
					array3[0] = 96;
					num2 = 2;
					continue;
				case 326:
					num21 = 210 - 106;
					num2 = 189;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 302:
					array[31] = 90;
					num2 = 381;
					continue;
				default:
					array3[2] = (byte)num23;
					num2 = 257;
					if (R3())
					{
						num2 = 365;
					}
					continue;
				case 280:
					array3[9] = 101;
					num2 = 331;
					if (R3())
					{
						continue;
					}
					break;
				case 182:
					array[25] = 33;
					num2 = 361;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 374:
					array3[13] = (byte)num22;
					num2 = 73;
					if (R3())
					{
						continue;
					}
					break;
				case 24:
					array4 = array;
					num2 = 328;
					continue;
				case 119:
					array[18] = (byte)num21;
					num2 = 150;
					continue;
				case 223:
					num20 = 95 + 89;
					num2 = 30;
					if (R3())
					{
						continue;
					}
					break;
				case 377:
					array[25] = (byte)num21;
					num2 = 321;
					if (!R3())
					{
						num2 = 63;
					}
					continue;
				case 204:
					array[4] = 141;
					num2 = 201;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 107:
					array[13] = 144;
					num = 209;
					break;
				case 327:
					array6 = new byte[array5.Length];
					num2 = 359;
					if (R3())
					{
						continue;
					}
					break;
				case 212:
					num20 = 234 - 78;
					num2 = 353;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 51:
					num20 = 172 - 58;
					num2 = 198;
					continue;
				case 81:
					num20 = 131 - 43;
					num2 = 200;
					continue;
				case 256:
					array[0] = 208;
					num2 = 96;
					continue;
				case 109:
					num23 = 117 + 104;
					num2 = 273;
					continue;
				case 199:
					array2[13] = publicKeyToken[6];
					num2 = 67;
					continue;
				case 1:
					array[24] = 148;
					num = 305;
					break;
				case 296:
					num20 = 111 + 47;
					num2 = 236;
					if (R3())
					{
						continue;
					}
					break;
				case 180:
					num22 = 77 - 33;
					num2 = 172;
					continue;
				case 96:
					num20 = 119 + 18;
					num2 = 103;
					continue;
				case 202:
					num43 = 0;
					num2 = 75;
					continue;
				case 143:
					array[21] = 12;
					num = 387;
					break;
				case 206:
					num20 = 203 - 67;
					num2 = 118;
					continue;
				case 313:
					num21 = 36 + 22;
					num2 = 395;
					if (!R3())
					{
						num2 = 157;
					}
					continue;
				case 113:
					num20 = 251 - 83;
					num2 = 233;
					continue;
				case 9:
					num20 = 103 + 2;
					num = 337;
					break;
				case 122:
					array[9] = (byte)num21;
					num2 = 153;
					if (cJ() == null)
					{
						num2 = 184;
					}
					continue;
				case 135:
				case 303:
					num4 = num27;
					num2 = 382;
					continue;
				case 246:
					num21 = 22 - 11;
					num2 = 8;
					continue;
				case 281:
					if (num33 > 0)
					{
						num = 336;
						break;
					}
					goto case 127;
				case 141:
					num23 = 103 + 37;
					num2 = 272;
					continue;
				case 64:
					array6[num31] = (byte)(num32 & 0xFF);
					num2 = 2;
					if (R3())
					{
						num2 = 4;
					}
					continue;
				case 68:
					num43 += 8;
					num2 = 98;
					continue;
				case 391:
					num23 = 121 + 43;
					num2 = 60;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 329:
					num22 = 14 + 105;
					num2 = 411;
					continue;
				case 211:
					array[15] = (byte)num21;
					num2 = 101;
					continue;
				case 10:
					cryptoStream.FlushFinalBlock();
					num2 = 27;
					continue;
				case 216:
					num42 = num27 ^ num30;
					num = 315;
					break;
				case 137:
					num20 = 42 + 116;
					num2 = 278;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 116:
					num22 = 168 - 56;
					num2 = 147;
					continue;
				case 412:
					array[22] = (byte)num20;
					num2 = 384;
					continue;
				case 351:
					array[17] = (byte)num20;
					num2 = 21;
					continue;
				case 128:
					array3[0] = (byte)num23;
					num2 = 308;
					if (R3())
					{
						continue;
					}
					break;
				case 208:
					num21 = 195 - 65;
					num2 = 275;
					continue;
				case 401:
					num21 = 164 - 54;
					num2 = 276;
					if (R3())
					{
						continue;
					}
					break;
				case 201:
					num20 = 211 - 70;
					num2 = 405;
					if (cJ() != null)
					{
						num2 = 102;
					}
					continue;
				case 197:
				case 322:
					num44 = 0;
					num2 = 114;
					continue;
				case 178:
					num35 = 0;
					num2 = 36;
					continue;
				case 297:
					num29 = (uint)(num41 * 4);
					num2 = 97;
					continue;
				case 100:
					array[0] = 143;
					num2 = 256;
					continue;
				case 153:
					array3[7] = (byte)num22;
					num = 52;
					break;
				case 293:
					array2[11] = publicKeyToken[5];
					num2 = 94;
					if (cJ() == null)
					{
						num2 = 199;
					}
					continue;
				case 112:
					array[1] = (byte)num20;
					num2 = 137;
					continue;
				case 239:
					num21 = 216 - 122;
					num2 = 298;
					continue;
				case 400:
					array[24] = 25;
					num2 = 335;
					continue;
				case 362:
					array3[3] = (byte)num23;
					num2 = 149;
					continue;
				case 365:
					array3[2] = 61;
					num2 = 349;
					continue;
				case 56:
					num22 = 49 + 24;
					num2 = 283;
					continue;
				case 311:
					array[23] = (byte)num21;
					num2 = 95;
					continue;
				case 98:
					array6[num31 + num24] = (byte)((num42 & num26) >> num43);
					num2 = 22;
					continue;
				case 161:
					array[27] = (byte)num20;
					num2 = 310;
					continue;
				case 163:
					array3[8] = (byte)num23;
					num2 = 343;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 321:
					array[26] = 102;
					num2 = 406;
					continue;
				case 265:
					array[23] = 148;
					num = 187;
					break;
				case 371:
					array[17] = 171;
					num2 = 131;
					if (R3())
					{
						continue;
					}
					break;
				case 358:
					array[11] = 159;
					num2 = 62;
					continue;
				case 196:
					array[8] = 118;
					num2 = 90;
					if (R3())
					{
						continue;
					}
					break;
				case 58:
					num23 = 199 - 66;
					num2 = 163;
					continue;
				case 2:
					num22 = 26 + 5;
					num2 = 88;
					continue;
				case 34:
					array3[1] = 116;
					num2 = 88;
					if (R3())
					{
						num2 = 133;
					}
					continue;
				case 291:
					num21 = 129 - 104;
					num2 = 43;
					continue;
				case 181:
					num25++;
					num2 = 314;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 159:
					array[3] = 147;
					num2 = 239;
					continue;
				case 72:
					array[8] = (byte)num20;
					num2 = 41;
					continue;
				case 397:
					array3[6] = (byte)num23;
					num2 = 109;
					continue;
				case 307:
					array3[3] = (byte)num23;
					num2 = 325;
					if (R3())
					{
						continue;
					}
					break;
				case 354:
					if (num24 > 0)
					{
						num = 342;
						break;
					}
					goto case 98;
				case 80:
					num30 <<= 8;
					num2 = 344;
					continue;
				case 230:
					num22 = 183 - 61;
					num2 = 320;
					continue;
				case 20:
					array[3] = 120;
					num2 = 390;
					continue;
				case 151:
					num20 = 26 + 5;
					num2 = 241;
					continue;
				case 5:
					array[10] = 118;
					num2 = 251;
					continue;
				case 55:
					array3[4] = 144;
					num2 = 292;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 234:
					try
					{
						fc.taYSkz();
						int num37 = 1;
						if (!R3())
						{
							goto IL_23da;
						}
						goto IL_23de;
						IL_23da:
						num37 = num38;
						goto IL_23de;
						IL_23de:
						while (true)
						{
							switch (num37)
							{
							case 1:
								goto IL_23f0;
							case 0:
								break;
							}
							break;
							IL_23f0:
							result = Encoding.Unicode.GetString(go2, P_0 + 4, count);
							num37 = 0;
							if (cJ() == null)
							{
								continue;
							}
							goto IL_23da;
						}
					}
					catch
					{
						int num39 = 0;
						if (cJ() != null)
						{
							num39 = num40;
						}
						switch (num39)
						{
						}
						goto case 332;
					}
					return result;
				case 353:
					array[15] = (byte)num20;
					num2 = 160;
					if (cJ() == null)
					{
						num2 = 268;
					}
					continue;
				case 188:
					array[17] = (byte)num20;
					num2 = 383;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 117:
					num41 = num35 % num34;
					num2 = 277;
					if (R3())
					{
						num2 = 352;
					}
					continue;
				case 333:
					array3[6] = 32;
					num2 = 33;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 32:
					array3[8] = 176;
					num2 = 58;
					continue;
				case 379:
					num20 = 141 - 47;
					num2 = 373;
					continue;
				case 193:
					rb.cY5();
					num2 = 35;
					if (cJ() != null)
					{
						num2 = 21;
					}
					continue;
				case 242:
					num20 = 247 - 82;
					num2 = 188;
					continue;
				case 95:
					num20 = 51 + 114;
					num2 = 388;
					continue;
				case 214:
					num23 = 77 + 83;
					num2 = 307;
					continue;
				case 75:
					if (num35 == num36 - 1)
					{
						num2 = 281;
						continue;
					}
					goto case 127;
				case 287:
					num21 = 134 - 44;
					num2 = 253;
					if (cJ() != null)
					{
						num2 = 112;
					}
					continue;
				case 102:
					array[19] = 243;
					num2 = 319;
					continue;
				case 129:
					publicKeyToken = loM.GetName().GetPublicKeyToken();
					num2 = 366;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 346:
					num20 = 35 + 16;
					num2 = 72;
					if (cJ() != null)
					{
						num2 = 61;
					}
					continue;
				case 198:
					array[7] = (byte)num20;
					num2 = 63;
					if (R3())
					{
						num2 = 346;
					}
					continue;
				case 210:
					array3[9] = 167;
					num2 = 17;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 127:
					num27 += num28;
					num2 = 186;
					continue;
				case 175:
					if (num25 > 0)
					{
						num2 = 80;
						continue;
					}
					goto case 344;
				case 394:
					array3[11] = (byte)num22;
					num2 = 174;
					continue;
				case 237:
					array3[6] = (byte)num22;
					num2 = 333;
					if (R3())
					{
						continue;
					}
					break;
				case 398:
					array[24] = (byte)num20;
					num2 = 400;
					continue;
				case 23:
					array[22] = (byte)num20;
					num2 = 155;
					continue;
				case 105:
					if (go2.Length != 0)
					{
						num2 = 76;
						if (cJ() == null)
						{
							num2 = 104;
						}
						continue;
					}
					goto case 99;
				case 304:
					cryptoStream.Write(array5, 0, array5.Length);
					num2 = 2;
					if (cJ() == null)
					{
						num2 = 10;
					}
					continue;
				case 82:
					array[5] = (byte)num21;
					num2 = 170;
					continue;
				case 190:
					array5 = rb.AY6((int)rb.KDikMXewCI().Length);
					num2 = 193;
					continue;
				case 325:
					num22 = 211 - 70;
					num2 = 407;
					continue;
				case 17:
					array3[10] = 98;
					num2 = 45;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 250:
					array[13] = (byte)num21;
					num2 = 107;
					continue;
				case 126:
					array3[5] = (byte)num22;
					num2 = 136;
					continue;
				case 233:
					array[29] = (byte)num20;
					num2 = 123;
					continue;
				case 275:
					array[16] = (byte)num21;
					num2 = 296;
					continue;
				case 84:
					array[10] = 167;
					num2 = 5;
					continue;
				case 357:
					array[29] = 126;
					num2 = 113;
					continue;
				case 6:
					array3[0] = 179;
					num2 = 14;
					continue;
				case 146:
					num27 = num4;
					num2 = 403;
					continue;
				case 310:
					num20 = 163 + 67;
					num2 = 157;
					continue;
				case 191:
					array3[9] = (byte)num23;
					num2 = 280;
					continue;
				case 14:
					array3[1] = 158;
					num2 = 4;
					if (R3())
					{
						num2 = 116;
					}
					continue;
				case 340:
					array3[8] = (byte)num23;
					num2 = 42;
					continue;
				case 209:
					num21 = 207 + 9;
					num2 = 145;
					continue;
				case 259:
					array[5] = 102;
					num2 = 40;
					continue;
				case 328:
					array3 = new byte[16];
					num2 = 253;
					if (cJ() == null)
					{
						num2 = 270;
					}
					continue;
				case 219:
					array[10] = 136;
					num2 = 84;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 71:
					array[11] = 194;
					num = 267;
					break;
				case 158:
					array[4] = 141;
					num = 78;
					break;
				case 26:
					array2[5] = publicKeyToken[2];
					num2 = 124;
					continue;
				case 185:
					num36++;
					num2 = 402;
					if (!R3())
					{
						num2 = 263;
					}
					continue;
				case 74:
					array[14] = 84;
					num2 = 110;
					continue;
				case 186:
					num29 = (uint)num31;
					num2 = 356;
					if (R3())
					{
						continue;
					}
					break;
				case 46:
				case 314:
					if (num25 >= num33)
					{
						num2 = 303;
						if (cJ() == null)
						{
							continue;
						}
						break;
					}
					goto case 175;
				case 403:
					if (num35 == num36 - 1)
					{
						num2 = 173;
						continue;
					}
					goto case 121;
				case 106:
					num20 = 12 + 8;
					num2 = 227;
					continue;
				case 338:
					num21 = 238 - 79;
					num2 = 318;
					continue;
				case 83:
					array[2] = 165;
					num2 = 20;
					if (R3())
					{
						continue;
					}
					break;
				case 378:
					array[9] = 122;
					num2 = 355;
					continue;
				case 285:
					array[19] = 177;
					num = 102;
					break;
				case 381:
					array[31] = 32;
					num2 = 24;
					continue;
				case 316:
					stream.Close();
					num2 = 215;
					continue;
				case 395:
					array[7] = (byte)num21;
					num2 = 367;
					continue;
				case 7:
					num23 = 9 + 91;
					num2 = 86;
					continue;
				case 359:
					num34 = array4.Length / 4;
					num = 252;
					break;
				case 409:
					array6[num31 + 2] = (byte)((num32 & 0xFF0000) >> 16);
					num2 = 301;
					continue;
				case 38:
					num21 = 103 + 75;
					num = 144;
					break;
				case 162:
					num21 = 214 - 99;
					num2 = 82;
					continue;
				case 368:
					if (num33 > 0)
					{
						num2 = 185;
						continue;
					}
					goto case 402;
				case 270:
					array3[0] = 118;
					num2 = 160;
					continue;
				case 205:
					array3[10] = (byte)num23;
					num2 = 44;
					if (!R3())
					{
						num2 = 14;
					}
					continue;
				case 170:
					array[6] = 133;
					num2 = 195;
					continue;
				case 4:
					array6[num31 + 1] = (byte)((num32 & 0xFF00) >> 8);
					num2 = 409;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 260:
					array3[7] = (byte)num22;
					num2 = 192;
					continue;
				case 213:
					array[18] = 102;
					num2 = 392;
					if (R3())
					{
						continue;
					}
					break;
				case 132:
					num23 = 4 + 58;
					num2 = 205;
					continue;
				case 356:
					num30 = (uint)((array5[num29 + 3] << 24) | (array5[num29 + 2] << 16) | (array5[num29 + 1] << 8) | array5[num29]);
					num2 = 135;
					continue;
				case 309:
					array[20] = 154;
					num2 = 50;
					if (R3())
					{
						continue;
					}
					break;
				case 243:
					num23 = 102 + 117;
					num2 = 94;
					continue;
				case 67:
					array2[15] = publicKeyToken[7];
					num2 = 322;
					continue;
				case 66:
					array[21] = (byte)num21;
					num2 = 338;
					continue;
				case 318:
					array[21] = (byte)num21;
					num2 = 49;
					if (!R3())
					{
						num2 = 7;
					}
					continue;
				case 167:
					array[4] = (byte)num20;
					num2 = 259;
					continue;
				case 90:
					array[8] = 136;
					num2 = 375;
					continue;
				case 396:
					num22 = 135 - 45;
					num2 = 263;
					continue;
				case 25:
					array[6] = (byte)num21;
					num2 = 51;
					if (R3())
					{
						num2 = 108;
					}
					continue;
				case 342:
					num26 <<= 8;
					num2 = 68;
					continue;
				case 384:
					array[23] = 97;
					num2 = 265;
					continue;
				case 44:
					array3[10] = 149;
					num2 = 56;
					continue;
				case 70:
					array[18] = 189;
					num2 = 306;
					continue;
				case 336:
					num30 = 0u;
					num2 = 76;
					continue;
				case 189:
					array[28] = (byte)num21;
					num2 = 357;
					continue;
				case 176:
					array3[14] = 109;
					num2 = 391;
					continue;
				case 166:
					array[6] = (byte)num20;
					num2 = 350;
					continue;
				case 155:
					num20 = 177 - 80;
					num2 = 412;
					if (R3())
					{
						continue;
					}
					break;
				case 39:
					array[17] = 126;
					num2 = 242;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 282:
					num22 = 214 - 71;
					num2 = 54;
					continue;
				case 30:
					array[15] = (byte)num20;
					num2 = 221;
					continue;
				case 79:
					array3[7] = (byte)num23;
					num2 = 111;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 97:
					num28 = (uint)((array4[num29 + 3] << 24) | (array4[num29 + 2] << 16) | (array4[num29 + 1] << 8) | array4[num29]);
					num2 = 168;
					if (!R3())
					{
						num2 = 47;
					}
					continue;
				case 408:
					num21 = 163 - 54;
					num2 = 13;
					continue;
				case 87:
					array3[6] = 192;
					num2 = 360;
					continue;
				case 33:
					num22 = 67 + 74;
					num2 = 153;
					continue;
				case 43:
					array[12] = (byte)num21;
					num2 = 235;
					if (!R3())
					{
						num2 = 182;
					}
					continue;
				case 405:
					array[4] = (byte)num20;
					num2 = 334;
					continue;
				case 273:
					array3[6] = (byte)num23;
					num2 = 177;
					continue;
				case 12:
					array[24] = (byte)num21;
					num2 = 182;
					if (R3())
					{
						continue;
					}
					break;
				case 330:
					array[30] = 180;
					num2 = 15;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 50:
					array[20] = 131;
					num2 = 369;
					continue;
				case 255:
					num23 = 240 - 80;
					num2 = 179;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 343:
					num23 = 63 + 64;
					num2 = 340;
					continue;
				case 118:
					array[22] = (byte)num20;
					num2 = 222;
					continue;
				case 240:
					num23 = 218 - 72;
					num2 = 362;
					continue;
				case 121:
					num32 = num27 ^ num30;
					num2 = 64;
					continue;
				case 54:
					array3[0] = (byte)num22;
					num2 = 6;
					continue;
				case 40:
					array[5] = 117;
					num2 = 130;
					if (R3())
					{
						continue;
					}
					break;
				case 373:
					array[16] = (byte)num20;
					num2 = 106;
					continue;
				case 272:
					array3[12] = (byte)num23;
					num2 = 249;
					if (!R3())
					{
						num2 = 128;
					}
					continue;
				case 289:
					num20 = 128 - 24;
					num2 = 247;
					continue;
				case 160:
					num23 = 42 + 16;
					num2 = 128;
					continue;
				case 94:
					array3[2] = (byte)num23;
					num2 = 386;
					continue;
				case 130:
					array[5] = 192;
					num2 = 28;
					if (R3())
					{
						num2 = 162;
					}
					continue;
				case 261:
					array3[15] = 196;
					num2 = 85;
					continue;
				case 111:
					array3[7] = 35;
					num2 = 180;
					continue;
				case 410:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num = 304;
					break;
				case 76:
					num27 += num28;
					num2 = 48;
					continue;
				case 37:
					array2[3] = publicKeyToken[1];
					num2 = 26;
					continue;
				case 248:
					num20 = 107 + 18;
					num2 = 112;
					if (!R3())
					{
						num2 = 49;
					}
					continue;
				case 89:
					num21 = 82 + 8;
					num2 = 66;
					continue;
				case 249:
					num23 = 132 + 87;
					num2 = 138;
					continue;
				case 331:
					array3[9] = 84;
					num2 = 210;
					if (!R3())
					{
						num2 = 87;
					}
					continue;
				case 108:
					num20 = 166 + 4;
					num2 = 166;
					continue;
				case 366:
					if (publicKeyToken == null)
					{
						num2 = 197;
						continue;
					}
					goto case 156;
				case 319:
					array[20] = 175;
					num2 = 309;
					continue;
				case 48:
					num25 = 0;
					num2 = 46;
					continue;
				case 134:
					num20 = 86 + 62;
					num2 = 224;
					continue;
				case 147:
					array3[1] = (byte)num22;
					num = 61;
					break;
				case 238:
					num21 = 225 - 117;
					num2 = 12;
					if (R3())
					{
						continue;
					}
					break;
				case 35:
					array = new byte[32];
					num2 = 295;
					continue;
				case 148:
					array[3] = (byte)num21;
					num2 = 159;
					if (!R3())
					{
						num2 = 151;
					}
					continue;
				case 45:
					array3[10] = 206;
					num2 = 132;
					continue;
				case 264:
					array3[11] = 70;
					num2 = 372;
					continue;
				case 232:
					array3[3] = 146;
					num2 = 214;
					if (R3())
					{
						continue;
					}
					break;
				case 42:
					num23 = 245 - 81;
					num2 = 191;
					continue;
				case 334:
					num21 = 89 + 77;
					num2 = 218;
					if (R3())
					{
						continue;
					}
					break;
				case 376:
					symmetricAlgorithm = nTD();
					num2 = 364;
					continue;
				case 61:
					array3[1] = 88;
					num = 399;
					break;
				case 179:
					array3[14] = (byte)num23;
					num2 = 176;
					continue;
				case 184:
					array[9] = 123;
					num2 = 219;
					continue;
				case 11:
					array[7] = 156;
					num2 = 313;
					continue;
				case 387:
					num20 = 165 - 55;
					num2 = 300;
					continue;
				case 253:
					array[27] = (byte)num21;
					num2 = 408;
					if (R3())
					{
						continue;
					}
					break;
				case 229:
					num22 = 251 - 83;
					num2 = 126;
					if (R3())
					{
						continue;
					}
					break;
				case 267:
					array[12] = 155;
					num2 = 271;
					continue;
				case 8:
					array[29] = (byte)num21;
					num2 = 279;
					continue;
				case 288:
					num22 = 173 - 57;
					num2 = 374;
					continue;
				case 383:
					array[17] = 153;
					num2 = 257;
					continue;
				case 283:
					array3[10] = (byte)num22;
					num2 = 194;
					if (cJ() == null)
					{
						continue;
					}
					break;
				case 195:
					num21 = 117 + 104;
					num2 = 25;
					if (!R3())
					{
						num2 = 8;
					}
					continue;
				case 139:
					array2[1] = publicKeyToken[0];
					num2 = 37;
					continue;
				case 324:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 2622601u;
					uint num7 = 2141237150u;
					uint num8 = 1644533176u;
					uint num9 = num5;
					uint num10 = 1221040637u;
					uint num11 = 737019700u;
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
					num2 = 146;
					continue;
				}
				}
				break;
			}
		}
	}

	[d9(typeof(d9.S3<object>[]))]
	internal static string zoI(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int coP()
	{
		return 5;
	}

	private static void so1()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate vot(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object joU(object P_0)
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
	public static extern IntPtr So6(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr Qoq(IntPtr P_0, string P_1);

	private static IntPtr OoJ(IntPtr P_0, string P_1, uint P_2)
	{
		if (Lo0 == null)
		{
			IntPtr ptr = Qoq(umLocehuEC(), "Find ".Trim() + "ResourceA");
			Lo0 = (ch)Marshal.GetDelegateForFunctionPointer(ptr, typeof(ch));
		}
		return Lo0(P_0, P_1, P_2);
	}

	private static IntPtr Vo5(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (SoA == null)
		{
			IntPtr ptr = Qoq(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			SoA = (qZ)Marshal.GetDelegateForFunctionPointer(ptr, typeof(qZ));
		}
		return SoA(P_0, P_1, P_2, P_3);
	}

	private static int uoW(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (No4 == null)
		{
			IntPtr ptr = Qoq(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			No4 = (TH)Marshal.GetDelegateForFunctionPointer(ptr, typeof(TH));
		}
		return No4(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int Kon(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (moS == null)
		{
			IntPtr ptr = Qoq(umLocehuEC(), "Virtual ".Trim() + "Protect");
			moS = (tD)Marshal.GetDelegateForFunctionPointer(ptr, typeof(tD));
		}
		return moS(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr iop(uint P_0, int P_1, uint P_2)
	{
		if (Yoz == null)
		{
			IntPtr ptr = Qoq(umLocehuEC(), "Open ".Trim() + "Process");
			Yoz = (I7)Marshal.GetDelegateForFunctionPointer(ptr, typeof(I7));
		}
		return Yoz(P_0, P_1, P_2);
	}

	private static int woE(IntPtr P_0)
	{
		if (VYI == null)
		{
			IntPtr ptr = Qoq(umLocehuEC(), "Close ".Trim() + "Handle");
			VYI = (@is)Marshal.GetDelegateForFunctionPointer(ptr, typeof(@is));
		}
		return VYI(P_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (aYP == IntPtr.Zero)
		{
			aYP = So6("kernel ".Trim() + "32.dll");
		}
		return aYP;
	}

	[d9(typeof(d9.S3<object>[]))]
	private static byte[] GoC(string P_0)
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

	internal static Stream coK()
	{
		return new MemoryStream();
	}

	internal static byte[] zoN(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[d9(typeof(d9.S3<object>[]))]
	private static byte[] Uol(byte[] P_0)
	{
		Stream stream = coK();
		SymmetricAlgorithm symmetricAlgorithm = nTD();
		symmetricAlgorithm.Key = new byte[32]
		{
			203, 141, 41, 135, 64, 252, 39, 233, 136, 185,
			93, 193, 14, 186, 21, 130, 154, 58, 245, 56,
			116, 2, 240, 186, 144, 71, 221, 228, 72, 139,
			187, 158
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			34, 63, 109, 230, 65, 132, 207, 39, 87, 158,
			217, 215, 125, 96, 154, 133
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = zoN(stream);
		fc.taYSkz();
		return result;
	}

	private byte[] hog()
	{
		return null;
	}

	private byte[] com()
	{
		return null;
	}

	private byte[] poT()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Soo()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] ooY()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] mok()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] XoQ()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] hoy()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Lod()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] DoB()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static bool R3()
	{
		return (object)null == null;
	}

	internal static object cJ()
	{
		return null;
	}
}
