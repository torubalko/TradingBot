using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using frv4s5X5SOo66jNvMvO6;
using hkZMMTXxD6qN8IAyOFGI;
using MhxjOdXxkI6wEJmk4G3f;

namespace PWXKwRXxL9cVgWUpa4xk;

internal class inixpGXxxRbVxvw72CyL
{
	private enum hTcsBrXxgD980LIjZF5r
	{

	}

	internal class NbXk2oXxRm2h2ySDkVDS
	{
		private unsafe static uint i7PXx63j92Y(void* P_0, uint P_1)
		{
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)P_0;
			}
			else
			{
				switch (P_1)
				{
				case 4u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16) | (((byte*)P_0)[3] << 24));
					break;
				case 3u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16));
					break;
				case 2u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8));
					break;
				case 1u:
					result = *(byte*)P_0;
					break;
				}
			}
			return result;
		}

		private unsafe static bool hP6XxMR6m3b(void* P_0, void* P_1, uint P_2)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < P_2)
			{
				flag = ((byte*)P_0)[num] == ((byte*)P_1)[num];
				num++;
			}
			return flag;
		}

		private unsafe static void tNDXxOi0P5L(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void h2uXxqpjsFy(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void HQ5XxIReKvv(byte* P_0, byte* P_1, uint P_2)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (P_2 < 5)
				{
					*(int*)P_0 = *(int*)P_1;
					return;
				}
				byte* ptr = P_0 + P_2;
				while (P_0 < ptr)
				{
					*(int*)P_0 = *(int*)P_1;
					P_0 += 4;
					P_1 += 4;
				}
			}
			else if (P_2 > 8 && P_1 + P_2 < P_0)
			{
				h2uXxqpjsFy(P_0, P_1, P_2);
			}
			else
			{
				byte* ptr2 = P_0 + P_2;
				while (P_0 < ptr2)
				{
					*P_0 = *P_1;
					P_0++;
					P_1++;
				}
			}
		}

		private unsafe static uint NlRXxWFq0KW(byte[] P_0, uint P_1, hTcsBrXxgD980LIjZF5r P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint xerXxtI3KZR(byte[] P_0, uint P_1)
		{
			return NlRXxWFq0KW(P_0, P_1, (hTcsBrXxgD980LIjZF5r)3);
		}

		private unsafe static uint khTXxUIDwEv(byte[] P_0, uint P_1, byte[] P_2)
		{
			fixed (byte* ptr = P_0)
			{
				fixed (byte* ptr2 = P_2)
				{
					byte* ptr3 = ptr + P_1;
					uint num = 32u;
					byte* ptr4 = ptr3 + num;
					byte* ptr5 = ptr2;
					uint* ptr6 = (uint*)ptr3;
					byte* ptr7 = ptr2 + i7PXx63j92Y(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16];
					x8sENwXRRm3uuOlVnhTu(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					uint[] array2 = array;
					byte* ptr8 = ptr7 - 4;
					if (i7PXx63j92Y(ptr6 + 4, 4u) != 1)
					{
						h2uXxqpjsFy(ptr2, ptr3 + num, i7PXx63j92Y(ptr6 + 3, 4u));
						return i7PXx63j92Y(ptr6 + 3, 4u);
					}
					if (ptr5 >= ptr8)
					{
						ptr4 += 4;
						while (ptr5 < ptr7)
						{
							*ptr5 = *ptr4;
							ptr5++;
							ptr4++;
						}
						return (uint)(ptr5 - ptr2);
					}
					while (true)
					{
						if (num2 == 1)
						{
							num2 = i7PXx63j92Y(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = i7PXx63j92Y(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								HQ5XxIReKvv(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								HQ5XxIReKvv(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								HQ5XxIReKvv(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								HQ5XxIReKvv(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								HQ5XxIReKvv(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								tNDXxOi0P5L(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							HQ5XxIReKvv(ptr5, ptr4, 4u);
							ptr5 += array2[num2 & 0xF];
							ptr4 += array2[num2 & 0xF];
							num2 >>= (int)(byte)array2[num2 & 0xF];
							if (ptr5 >= ptr8)
							{
								break;
							}
						}
					}
					while (ptr5 < ptr7)
					{
						if (num2 == 1)
						{
							ptr4 += 4;
							num2 = 2147483648u;
						}
						*ptr5 = *ptr4;
						ptr5++;
						ptr4++;
						num2 >>= 1;
					}
					return (uint)(ptr5 - ptr2);
				}
			}
		}

		internal static object jH8XxT0pXsK(byte[] P_0)
		{
			return Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777261)).GetMethod(((string)VFRudPXR60b6OT4aRVZY(-527080372 ^ -527079478)).Trim(), new Type[1] { LqK2DcXRMbr1vrJ2Lcmc(typeof(byte[]).TypeHandle) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] q2kXxyUf0Nj(byte[] P_0, uint P_1)
		{
			uint num = xerXxtI3KZR(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				khTXxUIDwEv(P_0, P_1, array);
			}
			return array;
		}

		internal static void x8sENwXRRm3uuOlVnhTu(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static object VFRudPXR60b6OT4aRVZY(int P_0)
		{
			return RMpEErX55SDH1mxasQVF.pbtX5yHUPdJ(P_0);
		}

		internal static Type LqK2DcXRMbr1vrJ2Lcmc(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	private static string[] qnIXxje7MGM = new string[0];

	private static object qRDXxE09Jwu = null;

	private static bool YUJXxQM5pji = false;

	private static bool hWSXxdY8pjR = false;

	private static void iy3XxsLsHlG()
	{
		int num = 272;
		int num20 = default(int);
		byte[] array2 = default(byte[]);
		int num16 = default(int);
		byte[] array = default(byte[]);
		int num19 = default(int);
		int num15 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array8 = default(byte[]);
		uint num37 = default(uint);
		uint num21 = default(uint);
		int num26 = default(int);
		int num29 = default(int);
		int num24 = default(int);
		RMpEErX55SDH1mxasQVF.YjMTdEXx2JCASdVCVphO yjMTdEXx2JCASdVCVphO = default(RMpEErX55SDH1mxasQVF.YjMTdEXx2JCASdVCVphO);
		int num35 = default(int);
		int num28 = default(int);
		int num31 = default(int);
		uint num34 = default(uint);
		byte[] array7 = default(byte[]);
		int num36 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		byte[] array4 = default(byte[]);
		int num33 = default(int);
		uint num23 = default(uint);
		byte[] array6 = default(byte[]);
		uint num22 = default(uint);
		int num25 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num30 = default(int);
		byte[] array3 = default(byte[]);
		uint num32 = default(uint);
		int num27 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 202:
					num20 = 234 - 78;
					num2 = 64;
					continue;
				case 418:
					num20 = 147 - 49;
					num2 = 76;
					continue;
				case 118:
					array2 = new byte[16];
					num2 = 317;
					continue;
				case 3:
					array2[9] = 53;
					num2 = 406;
					continue;
				case 92:
					num16 = 112 - 91;
					num2 = 73;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 241;
					}
					continue;
				case 360:
					array2[10] = 91;
					num2 = 279;
					continue;
				case 308:
					array[0] = (byte)num20;
					num2 = 411;
					continue;
				case 187:
					array[15] = (byte)num16;
					num2 = 183;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 267;
					}
					continue;
				case 5:
					array[0] = 51;
					num2 = 124;
					continue;
				case 350:
					num20 = 196 - 65;
					num2 = 2;
					continue;
				case 101:
					array2[14] = 103;
					num2 = 192;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 221;
					}
					continue;
				case 279:
					num19 = 118 + 45;
					num2 = 185;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 198;
					}
					continue;
				case 300:
					array2[8] = (byte)num15;
					num2 = 258;
					continue;
				case 122:
					num16 = 130 + 22;
					num2 = 79;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 55;
					}
					continue;
				case 203:
					array[19] = 118;
					num2 = 104;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 168;
					}
					continue;
				case 4:
					num16 = 87 + 44;
					num2 = 252;
					continue;
				case 120:
					array5 = array8;
					num2 = 277;
					continue;
				case 64:
					array[20] = (byte)num20;
					num2 = 315;
					continue;
				case 408:
					num16 = 13 + 31;
					num = 333;
					break;
				case 166:
					array2[6] = 121;
					num2 = 309;
					continue;
				case 69:
					array[18] = (byte)num20;
					num2 = 248;
					continue;
				case 162:
					num19 = 17 + 40;
					num2 = 87;
					continue;
				case 44:
					num37 = num4 ^ num21;
					num2 = 135;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 230;
					}
					continue;
				case 283:
					num15 = 133 + 73;
					num2 = 25;
					continue;
				case 104:
				case 320:
					if (num26 >= num29)
					{
						num2 = 108;
						continue;
					}
					goto case 215;
				case 353:
					num16 = 53 + 78;
					num2 = 326;
					continue;
				case 236:
					num16 = 146 - 88;
					num2 = 91;
					continue;
				case 77:
					num16 = 235 - 78;
					num2 = 111;
					continue;
				case 82:
					array[2] = (byte)num20;
					num2 = 174;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 197;
					}
					continue;
				case 121:
					array[21] = 45;
					num2 = 141;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 16;
					}
					continue;
				case 311:
					num24 = 0;
					num2 = 140;
					continue;
				case 144:
					array[30] = 96;
					num2 = 62;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 110;
					}
					continue;
				case 134:
					num16 = 117 + 54;
					num2 = 351;
					continue;
				case 240:
					num19 = 204 - 68;
					num2 = 343;
					continue;
				case 306:
					array2[15] = (byte)num15;
					num2 = 303;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 369;
					}
					continue;
				case 206:
					array2[0] = 149;
					num2 = 9;
					continue;
				case 333:
					array[11] = (byte)num16;
					num2 = 194;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 372;
					}
					continue;
				case 309:
					array2[6] = 102;
					num2 = 133;
					continue;
				case 259:
					array[4] = 220;
					num2 = 72;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 115;
					}
					continue;
				case 175:
					array2[14] = (byte)num15;
					num2 = 101;
					continue;
				case 278:
					num15 = 125 - 41;
					num2 = 306;
					continue;
				case 212:
					array[7] = (byte)num20;
					num2 = 194;
					continue;
				case 35:
					array2[8] = 70;
					num2 = 274;
					continue;
				case 368:
					array8 = (byte[])S0wXqKXQSr2QAepiQS6Y(yjMTdEXx2JCASdVCVphO, (int)DmD8nNXQ5BLvh45UQJSS(QyerBXXQkwfmghKLRrfA(yjMTdEXx2JCASdVCVphO)));
					num2 = 60;
					continue;
				case 401:
					yjMTdEXx2JCASdVCVphO = new RMpEErX55SDH1mxasQVF.YjMTdEXx2JCASdVCVphO((Stream)ewg4IgXQNw5lgttSf4xg(Asm8IFXQbgLZ6o98n3ww(typeof(RMpEErX55SDH1mxasQVF).TypeHandle).Assembly, RMpEErX55SDH1mxasQVF.pbtX5yHUPdJ(-490987856 ^ -490988160)));
					num2 = 177;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 260;
					}
					continue;
				case 115:
					num20 = 153 - 51;
					num2 = 93;
					continue;
				case 102:
					num19 = 134 - 44;
					num2 = 99;
					continue;
				case 233:
					array2[9] = 79;
					num2 = 286;
					continue;
				case 275:
					array[26] = 217;
					num2 = 27;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 84;
					}
					continue;
				case 293:
					array[16] = (byte)num16;
					num = 19;
					break;
				case 76:
					array[3] = (byte)num20;
					num2 = 44;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 57;
					}
					continue;
				case 176:
					num16 = 110 + 83;
					num2 = 88;
					continue;
				case 215:
					num35 = num26 % num28;
					num2 = 238;
					continue;
				case 288:
					array[14] = 160;
					num2 = 326;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 415;
					}
					continue;
				case 286:
					array2[9] = 157;
					num2 = 3;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 0;
					}
					continue;
				case 28:
					array2[6] = 134;
					num2 = 57;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 200;
					}
					continue;
				case 247:
					array[6] = (byte)num20;
					num2 = 364;
					continue;
				case 46:
					array2[8] = (byte)num19;
					num2 = 225;
					continue;
				case 303:
					array[15] = 138;
					num2 = 146;
					continue;
				case 143:
					if (num31 > 0)
					{
						num2 = 256;
						continue;
					}
					goto case 128;
				case 26:
					num34 <<= 8;
					num2 = 208;
					continue;
				case 244:
					array7[num36 + 3] = (byte)((num37 & 0xFF000000u) >> 24);
					num2 = 359;
					continue;
				case 88:
					array[27] = (byte)num16;
					num2 = 3;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 55;
					}
					continue;
				case 100:
					if (num24 > 0)
					{
						num2 = 26;
						if (!jNv5vYXQ4GBFZe3fGi1x())
						{
							num2 = 24;
						}
						continue;
					}
					goto case 51;
				case 201:
					num20 = 172 - 62;
					num2 = 285;
					continue;
				case 195:
					num16 = 89 + 89;
					num2 = 48;
					continue;
				case 163:
					array2[11] = (byte)num19;
					num2 = 96;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 328;
					}
					continue;
				case 325:
					deflateStream = new DeflateStream(new MemoryStream(array4), CompressionMode.Decompress);
					num = 295;
					break;
				case 414:
					array2[5] = (byte)num15;
					num2 = 273;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 46;
					}
					continue;
				case 68:
					array2[1] = (byte)num19;
					num2 = 102;
					continue;
				case 36:
					array2[11] = 112;
					num2 = 312;
					continue;
				case 182:
					num15 = 190 - 63;
					num2 = 345;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 298;
					}
					continue;
				case 7:
					num33++;
					num2 = 319;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 85;
					}
					continue;
				case 184:
					array[1] = (byte)num16;
					num2 = 71;
					continue;
				case 62:
					array[11] = (byte)num20;
					num2 = 408;
					continue;
				case 407:
					num16 = 167 - 55;
					num2 = 396;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 52;
					}
					continue;
				case 404:
					num15 = 45 + 49;
					num2 = 26;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 139;
					}
					continue;
				case 147:
					num4 = 0u;
					num2 = 29;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 1;
					}
					continue;
				case 181:
					array[25] = 217;
					num2 = 22;
					continue;
				case 346:
					num20 = 81 + 18;
					num2 = 371;
					continue;
				case 410:
					array7[num36 + 1] = (byte)((num37 & 0xFF00) >> 8);
					num2 = 299;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 273;
					}
					continue;
				case 174:
					num15 = 238 - 79;
					num2 = 175;
					continue;
				case 316:
					array[2] = 128;
					num2 = 54;
					continue;
				case 123:
					num16 = 120 + 27;
					num2 = 160;
					continue;
				case 239:
					num20 = 146 + 17;
					num = 17;
					break;
				case 297:
					num21 = (uint)((array5[num23 + 3] << 24) | (array5[num23 + 2] << 16) | (array5[num23 + 1] << 8) | array5[num23]);
					num2 = 276;
					continue;
				case 319:
				case 347:
					if (num33 >= array6.Length)
					{
						num2 = 120;
						continue;
					}
					goto case 329;
				case 327:
					num20 = 216 - 72;
					num2 = 219;
					continue;
				case 2:
					array[22] = (byte)num20;
					num2 = 14;
					continue;
				case 237:
					num31++;
					num2 = 223;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 10;
					}
					continue;
				case 185:
					num20 = 79 + 118;
					num2 = 56;
					continue;
				case 45:
					array[28] = 112;
					num2 = 30;
					continue;
				case 321:
					array[22] = 165;
					num2 = 12;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 171;
					}
					continue;
				case 326:
					array[25] = (byte)num16;
					num2 = 181;
					continue;
				case 80:
					array[29] = 114;
					num2 = 81;
					continue;
				case 337:
					array[30] = 61;
					num2 = 167;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 132;
					}
					continue;
				case 66:
					YUJXxQM5pji = true;
					num2 = 32;
					continue;
				case 114:
					num4 += num22;
					num2 = 169;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 297;
					}
					continue;
				case 352:
					array[24] = (byte)num16;
					num2 = 80;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 217;
					}
					continue;
				case 413:
					num20 = 41 + 102;
					num2 = 322;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 188;
					}
					continue;
				case 355:
					array2[12] = 91;
					num2 = 287;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 17;
					}
					continue;
				case 332:
					array[13] = (byte)num16;
					num2 = 137;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 180;
					}
					continue;
				case 403:
					array[13] = 142;
					num2 = 302;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 399;
					}
					continue;
				case 381:
					array2[5] = (byte)num15;
					num = 28;
					break;
				case 136:
					array[30] = (byte)num20;
					num2 = 144;
					continue;
				case 258:
					num19 = 131 - 43;
					num2 = 46;
					continue;
				case 310:
					array[18] = 133;
					num2 = 318;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 131;
					}
					continue;
				case 117:
					num26 = 0;
					num = 320;
					break;
				case 140:
				case 392:
					if (num24 >= num25)
					{
						num2 = 11;
						if (AyLRoeXQDNXdaBmv7aOQ() != null)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 100;
				case 148:
					num16 = 211 - 70;
					num2 = 259;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 352;
					}
					continue;
				case 73:
					num16 = 129 - 43;
					num = 154;
					break;
				case 168:
					num20 = 142 - 47;
					num2 = 15;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 53;
					}
					continue;
				case 71:
					array[1] = 134;
					num2 = 70;
					continue;
				case 261:
					array[15] = (byte)num16;
					num2 = 188;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 354;
					}
					continue;
				case 367:
					num15 = 161 - 53;
					num2 = 265;
					continue;
				case 50:
					memoryStream = new MemoryStream();
					num2 = 107;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 325;
					}
					continue;
				case 301:
					array2[14] = (byte)num19;
					num2 = 174;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 123;
					}
					continue;
				case 96:
					array[9] = 219;
					num2 = 151;
					continue;
				case 38:
					array2[6] = (byte)num15;
					num2 = 356;
					continue;
				case 11:
				case 359:
					num26++;
					num2 = 104;
					continue;
				case 411:
					num16 = 223 - 74;
					num2 = 272;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 412;
					}
					continue;
				case 270:
					array[10] = (byte)num16;
					num2 = 346;
					continue;
				case 227:
					num19 = 177 - 55;
					num2 = 191;
					continue;
				case 218:
					array[1] = (byte)num20;
					num2 = 4;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 316;
					}
					continue;
				case 388:
					array2[1] = 150;
					num2 = 222;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 214;
					}
					continue;
				case 344:
					num20 = 170 - 56;
					num2 = 308;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 68;
					}
					continue;
				case 363:
					array[9] = 95;
					num2 = 63;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 169;
					}
					continue;
				case 264:
					array2[3] = (byte)num19;
					num2 = 43;
					continue;
				case 89:
					array[2] = (byte)num20;
					num2 = 18;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 41;
					}
					continue;
				case 317:
					array2[0] = 99;
					num2 = 74;
					continue;
				case 93:
					array[4] = (byte)num20;
					num2 = 190;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 196;
					}
					continue;
				case 228:
					array2[4] = (byte)num15;
					num2 = 86;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 103;
					}
					continue;
				case 141:
					array[22] = 102;
					num2 = 321;
					continue;
				case 186:
					array[26] = (byte)num20;
					num2 = 87;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 116;
					}
					continue;
				case 246:
					array[31] = 121;
					num2 = 183;
					continue;
				case 111:
					array[10] = (byte)num16;
					num2 = 37;
					continue;
				case 53:
					array[20] = (byte)num20;
					num2 = 73;
					continue;
				case 375:
					array2[3] = 168;
					num2 = 294;
					continue;
				case 16:
					num15 = 3 + 50;
					num2 = 214;
					continue;
				case 113:
					num15 = 106 - 101;
					num2 = 250;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 348;
					}
					continue;
				case 250:
					array[16] = (byte)num16;
					num2 = 92;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 34;
					}
					continue;
				case 305:
					LppkUXXQXcdRrgkmm8N5(memoryStream);
					num2 = 266;
					continue;
				case 241:
					array[16] = (byte)num16;
					num = 382;
					break;
				case 243:
					array[3] = (byte)num20;
					num2 = 73;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 259;
					}
					continue;
				case 97:
					num20 = 60 + 4;
					num2 = 72;
					continue;
				case 307:
					array2[5] = 104;
					num = 220;
					break;
				case 43:
					array2[3] = 148;
					num2 = 404;
					continue;
				case 31:
					if (num26 == num29 - 1)
					{
						num2 = 137;
						continue;
					}
					goto case 232;
				case 265:
					array2[0] = (byte)num15;
					num = 283;
					break;
				case 52:
					array[5] = 134;
					num2 = 130;
					continue;
				case 312:
					num19 = 123 + 81;
					num2 = 163;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 28;
					}
					continue;
				case 362:
					array[23] = (byte)num16;
					num2 = 239;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 257;
					}
					continue;
				case 192:
					if (num30 != 1)
					{
						num = 170;
						break;
					}
					goto case 50;
				case 290:
					array2[2] = (byte)num19;
					num2 = 4;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 18;
					}
					continue;
				case 29:
					num22 = 0u;
					num2 = 340;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 127;
					}
					continue;
				case 161:
					array4 = new byte[0];
					num2 = 368;
					continue;
				case 380:
					num16 = 118 + 34;
					num2 = 270;
					continue;
				case 15:
					array[5] = 109;
					num2 = 413;
					continue;
				case 335:
					array2[15] = (byte)num19;
					num2 = 216;
					continue;
				case 409:
					array2[13] = (byte)num15;
					num2 = 125;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 129;
					}
					continue;
				case 133:
					array2[6] = 233;
					num = 162;
					break;
				case 146:
					num16 = 0 + 31;
					num2 = 187;
					continue;
				case 61:
					array[22] = (byte)num20;
					num2 = 334;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 334;
					}
					continue;
				case 131:
					num16 = 153 - 51;
					num2 = 362;
					continue;
				case 157:
					array7 = new byte[array5.Length];
					num2 = 241;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 378;
					}
					continue;
				case 254:
					array2[12] = (byte)num19;
					num2 = 107;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 355;
					}
					continue;
				case 171:
					num20 = 71 + 113;
					num2 = 61;
					continue;
				case 230:
					array7[num36] = (byte)(num37 & 0xFF);
					num2 = 410;
					continue;
				case 253:
					num24++;
					num2 = 392;
					continue;
				case 221:
					array2[15] = 179;
					num2 = 341;
					continue;
				case 255:
					num19 = 63 + 27;
					num2 = 290;
					continue;
				case 272:
					if (YUJXxQM5pji)
					{
						num2 = 271;
						continue;
					}
					goto case 401;
				case 238:
					num36 = num26 * 4;
					num2 = 386;
					continue;
				case 260:
					rpMZXAXQ1LMRLpoF59L7(QyerBXXQkwfmghKLRrfA(yjMTdEXx2JCASdVCVphO), 0L);
					num = 161;
					break;
				case 232:
					num23 = (uint)num36;
					num2 = 114;
					continue;
				case 226:
					array2[4] = 7;
					num2 = 284;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 103;
					}
					continue;
				case 124:
					num16 = 161 - 53;
					num = 184;
					break;
				case 287:
					num19 = 100 + 76;
					num2 = 85;
					continue;
				case 205:
					num16 = 88 + 4;
					num2 = 267;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 293;
					}
					continue;
				case 209:
					array[11] = 250;
					num2 = 63;
					continue;
				case 139:
					array2[4] = (byte)num15;
					num2 = 338;
					continue;
				case 159:
					array2[13] = (byte)num19;
					num2 = 33;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 15;
					}
					continue;
				case 324:
					array[27] = (byte)num20;
					num = 123;
					break;
				case 81:
					num16 = 62 + 116;
					num2 = 304;
					continue;
				case 116:
					array[26] = 119;
					num2 = 275;
					continue;
				case 125:
					num19 = 231 - 107;
					num2 = 335;
					continue;
				case 402:
					array2[11] = 196;
					num2 = 182;
					continue;
				case 135:
					array[16] = (byte)num20;
					num2 = 13;
					continue;
				case 224:
					array[24] = (byte)num16;
					num2 = 152;
					continue;
				case 14:
					array[22] = 171;
					num2 = 119;
					continue;
				case 55:
					num20 = 92 + 118;
					num2 = 324;
					continue;
				case 370:
					array2[12] = (byte)num19;
					num2 = 387;
					continue;
				case 74:
					num15 = 33 + 44;
					num2 = 32;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 95;
					}
					continue;
				case 257:
					array[23] = 87;
					num2 = 201;
					continue;
				case 328:
					array2[11] = 123;
					num = 402;
					break;
				case 47:
				case 150:
				case 266:
					qnIXxje7MGM = (string[])L0vbDRXQjt8pouvOmJs4((Assembly)qRDXxE09Jwu);
					num2 = 66;
					continue;
				case 39:
				case 235:
					qRDXxE09Jwu = aeXkUeXQx9uSAfEa4BnD(array4);
					num2 = 85;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 150;
					}
					continue;
				case 339:
					array[23] = (byte)num16;
					num = 8;
					break;
				case 79:
					array[17] = (byte)num16;
					num2 = 310;
					continue;
				case 364:
					array[6] = 180;
					num2 = 6;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 213;
					}
					continue;
				case 37:
					array[10] = 114;
					num2 = 380;
					continue;
				case 365:
					num20 = 41 + 87;
					num2 = 153;
					continue;
				case 220:
					num15 = 123 + 49;
					num2 = 381;
					continue;
				case 126:
					array2[14] = 98;
					num2 = 249;
					continue;
				case 200:
					num15 = 125 - 41;
					num2 = 38;
					continue;
				case 361:
					array[12] = (byte)num20;
					num2 = 86;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 379;
					}
					continue;
				case 274:
					array2[8] = 134;
					num2 = 314;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 206;
					}
					continue;
				case 60:
					array = new byte[32];
					num2 = 211;
					continue;
				case 108:
					array4 = array7;
					num2 = 86;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 245;
					}
					continue;
				case 63:
					num20 = 70 + 118;
					num2 = 361;
					continue;
				case 252:
					array[6] = (byte)num16;
					num2 = 105;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 56;
					}
					continue;
				case 204:
					num20 = 188 - 62;
					num2 = 212;
					continue;
				case 9:
					array2[0] = 52;
					num2 = 367;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 50;
					}
					continue;
				case 369:
					array2[15] = 168;
					num2 = 13;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 125;
					}
					continue;
				case 83:
					array[15] = 158;
					num2 = 303;
					continue;
				case 372:
					array[11] = 161;
					num2 = 88;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 209;
					}
					continue;
				case 12:
					array[14] = (byte)num16;
					num2 = 288;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 114;
					}
					continue;
				case 343:
					array2[7] = (byte)num19;
					num2 = 165;
					continue;
				case 94:
					num16 = 14 + 100;
					num2 = 332;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 74;
					}
					continue;
				case 342:
					num20 = 89 + 72;
					num2 = 247;
					continue;
				case 322:
					array[6] = (byte)num20;
					num2 = 4;
					continue;
				case 341:
					array2[15] = 87;
					num2 = 186;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 278;
					}
					continue;
				case 412:
					array[0] = (byte)num16;
					num2 = 282;
					continue;
				case 41:
					num20 = 96 + 109;
					num2 = 67;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 82;
					}
					continue;
				case 391:
					array[1] = 114;
					num = 302;
					break;
				case 249:
					num19 = 198 - 66;
					num2 = 301;
					continue;
				case 225:
					array2[8] = 38;
					num2 = 233;
					continue;
				case 299:
					array7[num36 + 2] = (byte)((num37 & 0xFF0000) >> 16);
					num2 = 111;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 244;
					}
					continue;
				case 1:
					array[8] = (byte)num20;
					num2 = 357;
					continue;
				case 398:
					num20 = 6 + 20;
					num2 = 268;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 260;
					}
					continue;
				case 132:
					array[25] = 100;
					num2 = 353;
					continue;
				case 158:
					array[31] = 96;
					num2 = 1;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 10;
					}
					continue;
				case 149:
					num20 = 200 - 66;
					num2 = 107;
					continue;
				default:
					array2[13] = 205;
					num2 = 23;
					continue;
				case 277:
					num25 = array5.Length % 4;
					num2 = 349;
					continue;
				case 366:
					array2[13] = (byte)num19;
					num2 = 77;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 173;
					}
					continue;
				case 269:
					array[5] = 148;
					num2 = 52;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 47;
					}
					continue;
				case 285:
					array[23] = (byte)num20;
					num = 148;
					break;
				case 21:
					array[14] = 142;
					num = 405;
					break;
				case 137:
					if (num25 > 0)
					{
						num2 = 34;
						continue;
					}
					goto case 232;
				case 385:
					num20 = 89 - 67;
					num2 = 36;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 218;
					}
					continue;
				case 318:
					array[18] = 146;
					num2 = 189;
					continue;
				case 179:
					num19 = 190 - 63;
					num2 = 200;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 330;
					}
					continue;
				case 214:
					array2[2] = (byte)num15;
					num2 = 373;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 361;
					}
					continue;
				case 70:
					array[1] = 146;
					num = 391;
					break;
				case 99:
					array2[1] = (byte)num19;
					num = 388;
					break;
				case 242:
					array3 = array;
					num2 = 118;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 64;
					}
					continue;
				case 263:
					num31 = 0;
					num2 = 393;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 391;
					}
					continue;
				case 127:
					array2[2] = 234;
					num2 = 375;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 320;
					}
					continue;
				case 358:
					num20 = 118 + 64;
					num2 = 136;
					continue;
				case 165:
					array2[7] = 232;
					num2 = 35;
					continue;
				case 383:
					num20 = 27 + 31;
					num2 = 42;
					continue;
				case 20:
					array[19] = 147;
					num2 = 394;
					continue;
				case 87:
					array2[7] = (byte)num19;
					num = 390;
					break;
				case 216:
					array6 = array2;
					num2 = 75;
					continue;
				case 22:
					num20 = 58 + 61;
					num = 186;
					break;
				case 354:
					array[16] = 161;
					num2 = 205;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 23;
					}
					continue;
				case 211:
					num16 = 212 - 70;
					num2 = 67;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 32;
					}
					continue;
				case 281:
					array2[4] = (byte)num15;
					num2 = 226;
					continue;
				case 95:
					array2[0] = (byte)num15;
					num2 = 206;
					continue;
				case 154:
					array[20] = (byte)num16;
					num2 = 202;
					continue;
				case 57:
					array[3] = 160;
					num2 = 164;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 164;
					}
					continue;
				case 40:
					array[6] = 146;
					num2 = 317;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 342;
					}
					continue;
				case 415:
					array[15] = 211;
					num2 = 195;
					continue;
				case 351:
					array[7] = (byte)num16;
					num2 = 204;
					continue;
				case 138:
					array[13] = (byte)num20;
					num2 = 146;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 185;
					}
					continue;
				case 356:
					array2[6] = 130;
					num2 = 71;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 166;
					}
					continue;
				case 382:
					array[17] = 104;
					num2 = 119;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 149;
					}
					continue;
				case 90:
					num19 = 93 + 61;
					num2 = 370;
					continue;
				case 371:
					array[11] = (byte)num20;
					num2 = 417;
					continue;
				case 304:
					array[29] = (byte)num16;
					num2 = 397;
					continue;
				case 289:
					array[0] = 156;
					num2 = 344;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 270;
					}
					continue;
				case 10:
					array[31] = 134;
					num2 = 246;
					continue;
				case 229:
					array2[7] = 165;
					num2 = 240;
					continue;
				case 58:
					array[28] = 152;
					num2 = 59;
					continue;
				case 183:
					array[31] = 42;
					num2 = 236;
					continue;
				case 334:
					array[22] = 102;
					num2 = 350;
					continue;
				case 23:
					num15 = 250 - 83;
					num2 = 9;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 78;
					}
					continue;
				case 268:
					array[10] = (byte)num20;
					num2 = 109;
					continue;
				case 189:
					num20 = 68 + 13;
					num = 69;
					break;
				case 167:
					num16 = 89 + 71;
					num2 = 291;
					continue;
				case 267:
					num16 = 106 + 33;
					num2 = 261;
					continue;
				case 156:
					num23 = 0u;
					num2 = 78;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 117;
					}
					continue;
				case 273:
					array2[5] = 165;
					num2 = 300;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 307;
					}
					continue;
				case 314:
					num15 = 186 - 62;
					num2 = 300;
					continue;
				case 109:
					array[10] = 79;
					num2 = 77;
					continue;
				case 78:
					array2[13] = (byte)num15;
					num2 = 177;
					continue;
				case 142:
					num29++;
					num2 = 155;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 156;
					}
					continue;
				case 217:
					array[24] = 89;
					num2 = 213;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 298;
					}
					continue;
				case 160:
					array[28] = (byte)num16;
					num2 = 58;
					continue;
				case 191:
					array2[10] = (byte)num19;
					num2 = 36;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 33;
					}
					continue;
				case 386:
					num23 = (uint)(num35 * 4);
					num2 = 336;
					continue;
				case 331:
					num20 = 91 - 59;
					num2 = 112;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 107;
					}
					continue;
				case 105:
					array[6] = 159;
					num2 = 24;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 40;
					}
					continue;
				case 6:
					if (num25 > 0)
					{
						num2 = 142;
						if (!jNv5vYXQ4GBFZe3fGi1x())
						{
							num2 = 41;
						}
						continue;
					}
					goto case 156;
				case 151:
					array[9] = 168;
					num2 = 398;
					continue;
				case 33:
					num19 = 229 - 76;
					num2 = 366;
					continue;
				case 106:
					array[23] = (byte)num20;
					num2 = 92;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 131;
					}
					continue;
				case 280:
					num20 = 92 + 116;
					num2 = 0;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 1;
					}
					continue;
				case 194:
					array[7] = 146;
					num2 = 239;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 66;
					}
					continue;
				case 405:
					array[14] = 161;
					num2 = 118;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 207;
					}
					continue;
				case 373:
					num19 = 7 + 109;
					num2 = 375;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 400;
					}
					continue;
				case 51:
					array7[num36 + num24] = (byte)((num32 & num34) >> num27);
					num2 = 253;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 220;
					}
					continue;
				case 416:
					num34 = 255u;
					num2 = 98;
					continue;
				case 340:
					num21 = 0u;
					num2 = 6;
					continue;
				case 152:
					array[25] = 110;
					num2 = 132;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 100;
					}
					continue;
				case 129:
					array2[14] = 146;
					num2 = 126;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 100;
					}
					continue;
				case 399:
					num16 = 159 + 61;
					num2 = 262;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 214;
					}
					continue;
				case 291:
					array[31] = (byte)num16;
					num2 = 158;
					continue;
				case 262:
					array[13] = (byte)num16;
					num2 = 145;
					continue;
				case 164:
					num20 = 171 - 63;
					num2 = 243;
					continue;
				case 42:
					array[21] = (byte)num20;
					num2 = 407;
					continue;
				case 394:
					num16 = 40 + 25;
					num2 = 210;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 139;
					}
					continue;
				case 180:
					array[13] = 225;
					num2 = 403;
					continue;
				case 25:
					array2[0] = (byte)num15;
					num2 = 251;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 119;
					}
					continue;
				case 395:
					array[9] = (byte)num20;
					num2 = 31;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 96;
					}
					continue;
				case 193:
					array[18] = (byte)num16;
					num2 = 331;
					continue;
				case 213:
					array[7] = 152;
					num2 = 134;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 6;
					}
					continue;
				case 349:
					num29 = array5.Length / 4;
					num2 = 157;
					continue;
				case 298:
					num16 = 61 + 113;
					num2 = 224;
					continue;
				case 384:
					array[8] = 125;
					num2 = 280;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 172;
					}
					continue;
				case 234:
					num33 = 0;
					num2 = 206;
					if (jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 347;
					}
					continue;
				case 13:
					num16 = 10 + 64;
					num2 = 250;
					continue;
				case 294:
					num19 = 27 + 93;
					num = 264;
					break;
				case 59:
					array[28] = 137;
					num = 45;
					break;
				case 119:
					num16 = 218 - 72;
					num2 = 339;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 230;
					}
					continue;
				case 128:
					num21 |= array5[array5.Length - (1 + num31)];
					num2 = 92;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 237;
					}
					continue;
				case 84:
					array[27] = 100;
					num2 = 176;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 39;
					}
					continue;
				case 207:
					num16 = 146 - 48;
					num2 = 12;
					continue;
				case 32:
					return;
				case 271:
					return;
				case 389:
					num32 = num4 ^ num21;
					num2 = 186;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 311;
					}
					continue;
				case 231:
					num19 = 233 - 77;
					num2 = 68;
					continue;
				case 219:
					array[30] = (byte)num20;
					num2 = 358;
					continue;
				case 222:
					num19 = 78 + 74;
					num2 = 374;
					continue;
				case 284:
					num15 = 68 + 87;
					num2 = 414;
					continue;
				case 396:
					array[21] = (byte)num16;
					num2 = 121;
					continue;
				case 110:
					array[30] = 53;
					num2 = 337;
					continue;
				case 85:
					array2[13] = (byte)num19;
					num2 = 0;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 0;
					}
					continue;
				case 49:
					num20 = 190 - 63;
					num2 = 89;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 0;
					}
					continue;
				case 338:
					num15 = 19 + 124;
					num2 = 228;
					continue;
				case 390:
					array2[7] = 105;
					num2 = 229;
					continue;
				case 330:
					array2[2] = (byte)num19;
					num2 = 127;
					continue;
				case 374:
					array2[1] = (byte)num19;
					num2 = 113;
					continue;
				case 329:
					array3[num33] ^= array6[num33];
					num2 = 7;
					continue;
				case 170:
				case 296:
					qRDXxE09Jwu = aeXkUeXQx9uSAfEa4BnD(gtHg5QXQc9M6CLnJrDx2(array4, 0u));
					num2 = 47;
					continue;
				case 302:
					array[1] = 104;
					num = 385;
					break;
				case 75:
					num30 = 1;
					num = 234;
					break;
				case 54:
					array[2] = 188;
					num2 = 49;
					continue;
				case 103:
					num15 = 17 + 48;
					num2 = 199;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 281;
					}
					continue;
				case 223:
				case 393:
					if (num31 >= num25)
					{
						num2 = 24;
						continue;
					}
					goto case 143;
				case 27:
					num4 += num22;
					num = 263;
					break;
				case 345:
					array2[12] = (byte)num15;
					num2 = 90;
					continue;
				case 379:
					array[12] = 97;
					num2 = 188;
					continue;
				case 323:
					array2[10] = (byte)num19;
					num2 = 360;
					continue;
				case 245:
					if (num30 == 0)
					{
						num2 = 235;
						if (!jNv5vYXQ4GBFZe3fGi1x())
						{
							num2 = 145;
						}
						continue;
					}
					goto case 192;
				case 56:
					array[13] = (byte)num20;
					num2 = 94;
					continue;
				case 417:
					array[11] = 115;
					num2 = 86;
					continue;
				case 292:
					array2[12] = (byte)num19;
					num2 = 178;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 78;
					}
					continue;
				case 19:
					num20 = 63 + 33;
					num2 = 135;
					continue;
				case 91:
					array[31] = (byte)num16;
					num2 = 242;
					continue;
				case 65:
					array[0] = (byte)num20;
					num2 = 5;
					continue;
				case 208:
					num27 += 8;
					num2 = 51;
					continue;
				case 48:
					array[15] = (byte)num16;
					num2 = 83;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 54;
					}
					continue;
				case 172:
					array[29] = 132;
					num2 = 80;
					continue;
				case 397:
					array[29] = 53;
					num2 = 327;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 10;
					}
					continue;
				case 376:
					array[20] = (byte)num16;
					num2 = 97;
					continue;
				case 210:
					array[19] = (byte)num16;
					num2 = 203;
					continue;
				case 8:
					num20 = 142 - 47;
					num2 = 15;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 106;
					}
					continue;
				case 251:
					array2[1] = 173;
					num2 = 231;
					continue;
				case 282:
					num20 = 165 - 55;
					num2 = 45;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 65;
					}
					continue;
				case 155:
					if (num26 == num29 - 1)
					{
						num2 = 199;
						if (AyLRoeXQDNXdaBmv7aOQ() != null)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 44;
				case 190:
					qRDXxE09Jwu = aeXkUeXQx9uSAfEa4BnD(XGtGceXQsS4NDQXxIEKO(memoryStream));
					num2 = 305;
					continue;
				case 153:
					array[19] = (byte)num20;
					num2 = 20;
					continue;
				case 197:
					array[3] = 104;
					num2 = 418;
					continue;
				case 378:
					num28 = array3.Length / 4;
					num2 = 147;
					continue;
				case 18:
					array2[2] = 146;
					num2 = 16;
					continue;
				case 198:
					array2[10] = (byte)num19;
					num = 227;
					break;
				case 177:
					num19 = 234 - 78;
					num2 = 159;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 112;
					}
					continue;
				case 248:
					num16 = 243 - 81;
					num2 = 193;
					continue;
				case 34:
					num21 = 0u;
					num2 = 27;
					continue;
				case 169:
					array[9] = 162;
					num2 = 377;
					continue;
				case 112:
					array[18] = (byte)num20;
					num2 = 365;
					continue;
				case 406:
					num19 = 224 - 74;
					num2 = 323;
					continue;
				case 72:
					array[21] = (byte)num20;
					num2 = 383;
					continue;
				case 188:
					array[12] = 25;
					num2 = 313;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 100;
					}
					continue;
				case 357:
					array[8] = 31;
					num2 = 363;
					continue;
				case 130:
					array[5] = 161;
					num2 = 15;
					continue;
				case 17:
					array[7] = (byte)num20;
					num2 = 384;
					continue;
				case 98:
					num27 = 0;
					num2 = 31;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 30;
					}
					continue;
				case 313:
					num20 = 75 + 1;
					num2 = 138;
					continue;
				case 199:
					if (num25 > 0)
					{
						num2 = 389;
						continue;
					}
					goto case 44;
				case 196:
					array[4] = 88;
					num2 = 201;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 269;
					}
					continue;
				case 387:
					num19 = 75 + 1;
					num2 = 195;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 292;
					}
					continue;
				case 377:
					num20 = 53 + 61;
					num2 = 395;
					continue;
				case 173:
					num15 = 46 - 8;
					num2 = 409;
					continue;
				case 348:
					array2[1] = (byte)num15;
					num2 = 255;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 46;
					}
					continue;
				case 400:
					array2[2] = (byte)num19;
					num2 = 179;
					if (AyLRoeXQDNXdaBmv7aOQ() != null)
					{
						num2 = 51;
					}
					continue;
				case 86:
					num20 = 55 + 106;
					num2 = 62;
					continue;
				case 336:
					num22 = (uint)((array3[num23 + 3] << 24) | (array3[num23 + 2] << 16) | (array3[num23 + 1] << 8) | array3[num23]);
					num2 = 375;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 416;
					}
					continue;
				case 107:
					array[17] = (byte)num20;
					num = 122;
					break;
				case 67:
					array[0] = (byte)num16;
					num2 = 264;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 289;
					}
					continue;
				case 256:
					num21 <<= 8;
					num2 = 107;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 128;
					}
					continue;
				case 178:
					num19 = 79 + 118;
					num2 = 254;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 128;
					}
					continue;
				case 315:
					num16 = 111 + 46;
					num2 = 376;
					continue;
				case 145:
					array[14] = 123;
					num2 = 21;
					if (!jNv5vYXQ4GBFZe3fGi1x())
					{
						num2 = 14;
					}
					continue;
				case 30:
					array[28] = 58;
					num2 = 63;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 172;
					}
					continue;
				case 295:
					try
					{
						wPvsAsXQLpH80Z5Ul9Hi(deflateStream, memoryStream);
						int num17 = 0;
						if (jNv5vYXQ4GBFZe3fGi1x())
						{
							num17 = 0;
						}
						switch (num17)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num18;
						if (deflateStream == null)
						{
							num18 = 0;
							if (!jNv5vYXQ4GBFZe3fGi1x())
							{
								num18 = 0;
							}
							goto IL_3a5d;
						}
						goto IL_3a73;
						IL_3a5d:
						switch (num18)
						{
						default:
							goto end_IL_3a38;
						case 2:
							break;
						case 0:
							goto end_IL_3a38;
						case 1:
							goto end_IL_3a38;
						}
						goto IL_3a73;
						IL_3a73:
						FIwfPoXQeWP15IRs9aX4(deflateStream);
						num18 = 1;
						if (!jNv5vYXQ4GBFZe3fGi1x())
						{
							num18 = 0;
						}
						goto IL_3a5d;
						end_IL_3a38:;
					}
					goto case 190;
				case 24:
				case 276:
				{
					uint num3 = num4;
					num4 = 255u;
					uint num5 = 316093745u;
					uint num6 = 712448728u;
					uint num7 = 2061577663u;
					uint num8 = num3;
					uint num9 = 1809831234u;
					uint num10 = 1374586903u;
					ulong num11 = 1596760126 * num7;
					num11 |= 1;
					num6 = (uint)(num6 * num6 % num11);
					num9 -= num5;
					if ((double)num5 == 0.0)
					{
						num5--;
					}
					uint num12 = (uint)(-6346.0 / (double)num5 + (double)num5);
					num5 = (uint)((ulong)(1482676717 + num12) + 14500uL);
					num7 += num6;
					uint num13 = num10 & 0xFF00FF;
					uint num14 = num10 & 0xFF00FF00u;
					num13 = ((num13 >> 8) | (num14 << 8)) ^ num6;
					num10 = (num10 << 8) | (num10 >> 24);
					num8 ^= num8 >> 6;
					num8 += num5;
					num8 ^= num8 >> 11;
					num8 += num7;
					num8 ^= num8 << 1;
					num8 += num10;
					num8 = (((num7 << 20) - num7) ^ num5) + num8;
					num4 = num3 + (uint)(double)num8;
					num2 = 33;
					if (AyLRoeXQDNXdaBmv7aOQ() == null)
					{
						num2 = 155;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] UNKXxXqm21o(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554466)).Assembly)
		{
			if (!YUJXxQM5pji)
			{
				iy3XxsLsHlG();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)qRDXxE09Jwu).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly owCXxcRwmZ3(object P_0, ResolveEventArgs P_1)
	{
		if (!YUJXxQM5pji)
		{
			iy3XxsLsHlG();
		}
		string name = P_1.Name;
		for (int i = 0; i < qnIXxje7MGM.Length; i++)
		{
			if (qnIXxje7MGM[i] == name)
			{
				return (Assembly)qRDXxE09Jwu;
			}
		}
		return null;
	}

	public inixpGXxxRbVxvw72CyL()
	{
		AppDomain.CurrentDomain.ResourceResolve += owCXxcRwmZ3;
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!hWSXxdY8pjR)
		{
			hWSXxdY8pjR = true;
			new inixpGXxxRbVxvw72CyL();
		}
	}

	internal static Type Asm8IFXQbgLZ6o98n3ww(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ewg4IgXQNw5lgttSf4xg(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object QyerBXXQkwfmghKLRrfA(object P_0)
	{
		return ((RMpEErX55SDH1mxasQVF.YjMTdEXx2JCASdVCVphO)P_0).m9OIO8Q0EK();
	}

	internal static void rpMZXAXQ1LMRLpoF59L7(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long DmD8nNXQ5BLvh45UQJSS(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object S0wXqKXQSr2QAepiQS6Y(object P_0, int P_1)
	{
		return ((RMpEErX55SDH1mxasQVF.YjMTdEXx2JCASdVCVphO)P_0).VUMXxHeTqDm(P_1);
	}

	internal static object aeXkUeXQx9uSAfEa4BnD(object P_0)
	{
		return NbXk2oXxRm2h2ySDkVDS.jH8XxT0pXsK((byte[])P_0);
	}

	internal static void wPvsAsXQLpH80Z5Ul9Hi(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void FIwfPoXQeWP15IRs9aX4(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object XGtGceXQsS4NDQXxIEKO(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void LppkUXXQXcdRrgkmm8N5(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object gtHg5QXQc9M6CLnJrDx2(object P_0, uint P_1)
	{
		return NbXk2oXxRm2h2ySDkVDS.q2kXxyUf0Nj((byte[])P_0, P_1);
	}

	internal static object L0vbDRXQjt8pouvOmJs4(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool jNv5vYXQ4GBFZe3fGi1x()
	{
		return (object)null == null;
	}

	internal static object AyLRoeXQDNXdaBmv7aOQ()
	{
		return null;
	}
}
