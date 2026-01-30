using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using HExkDCsORifnalUv1owx;
using rXssPVsOOYd71bKiWjYb;
using vGgPQ4s6WEgjxnvUb1Vk;

namespace UxBecVsOUPcejrh1NEnp;

internal class vgyu2XsOtpI4mGGhk89T
{
	private enum U723WhsOhQSX6tQuLthO
	{

	}

	internal class m2iTu5sOwLnoN8hZpiQx
	{
		private unsafe static uint XUysO7Hjlx8(void* P_0, uint P_1)
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

		private unsafe static bool L9qsO8brhVK(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void nDtsOAb3ofE(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void mWgsOPHNr1w(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void eTVsOJ3Ikv5(byte* P_0, byte* P_1, uint P_2)
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
				mWgsOPHNr1w(P_0, P_1, P_2);
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

		private unsafe static uint g7msOFw8f2w(byte[] P_0, uint P_1, U723WhsOhQSX6tQuLthO P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint XbEsO3DGyRU(byte[] P_0, uint P_1)
		{
			return pwVkIfsrmmRUZvfZuUQv(P_0, P_1, (U723WhsOhQSX6tQuLthO)3);
		}

		private unsafe static uint vSRsOpqfVQ5(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + XUysO7Hjlx8(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (XUysO7Hjlx8(ptr6 + 4, 4u) != 1)
					{
						mWgsOPHNr1w(ptr2, ptr3 + num, XUysO7Hjlx8(ptr6 + 3, 4u));
						return XUysO7Hjlx8(ptr6 + 3, 4u);
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
							num2 = XUysO7Hjlx8(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = XUysO7Hjlx8(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								eTVsOJ3Ikv5(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								eTVsOJ3Ikv5(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								eTVsOJ3Ikv5(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								eTVsOJ3Ikv5(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								eTVsOJ3Ikv5(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								nDtsOAb3ofE(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							eTVsOJ3Ikv5(ptr5, ptr4, 4u);
							ptr5 += array[num2 & 0xF];
							ptr4 += array[num2 & 0xF];
							num2 >>= (int)(byte)array[num2 & 0xF];
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

		internal static object hrgsOueGtIo(byte[] P_0)
		{
			return Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(16777278)).GetMethod(qhHWErs6IBu8qtqJbdvd.rA7s6znQmFT(0x5CD4F15 ^ 0x5CD4E11).Trim(), new Type[1] { typeof(byte[]) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] VFUsOzrQwTJ(byte[] P_0, uint P_1)
		{
			uint num = XbEsO3DGyRU(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				SjM1vrsrhTy7pfVjUBUe(P_0, P_1, array);
			}
			return array;
		}

		internal static uint pwVkIfsrmmRUZvfZuUQv(object P_0, uint P_1, U723WhsOhQSX6tQuLthO P_2)
		{
			return g7msOFw8f2w((byte[])P_0, P_1, P_2);
		}

		internal static uint SjM1vrsrhTy7pfVjUBUe(object P_0, uint P_1, object P_2)
		{
			return vSRsOpqfVQ5((byte[])P_0, P_1, (byte[])P_2);
		}
	}

	private static string[] ohgsOCwqbH5 = new string[0];

	private static object hsksOrhnScw = null;

	private static bool emjsOK43Ot7 = false;

	private static bool UnPsOmM8n1r = false;

	private static void I5EsOywcnj9()
	{
		int num = 83;
		byte[] array2 = default(byte[]);
		int num33 = default(int);
		byte[] array3 = default(byte[]);
		int num15 = default(int);
		byte[] array6 = default(byte[]);
		qhHWErs6IBu8qtqJbdvd.Lo0gPNsO1FdPmLPkq0Hr lo0gPNsO1FdPmLPkq0Hr = default(qhHWErs6IBu8qtqJbdvd.Lo0gPNsO1FdPmLPkq0Hr);
		byte[] array = default(byte[]);
		byte[] array4 = default(byte[]);
		int num18 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		uint num36 = default(uint);
		uint num32 = default(uint);
		int num19 = default(int);
		int num26 = default(int);
		byte[] array7 = default(byte[]);
		int num25 = default(int);
		uint num20 = default(uint);
		int num31 = default(int);
		uint num30 = default(uint);
		byte[] array8 = default(byte[]);
		int num23 = default(int);
		int num27 = default(int);
		byte[] array5 = default(byte[]);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		uint num29 = default(uint);
		int num24 = default(int);
		uint num37 = default(uint);
		int num34 = default(int);
		int num35 = default(int);
		int num28 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 225:
					array2[12] = 115;
					num2 = 119;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 33;
					}
					continue;
				case 319:
					if (num33 == 0)
					{
						num = 78;
						break;
					}
					goto case 202;
				case 297:
					array3[8] = 184;
					num2 = 17;
					continue;
				case 251:
					array2[0] = 97;
					num2 = 376;
					continue;
				case 222:
					array2[0] = 129;
					num2 = 414;
					continue;
				case 120:
					array2[15] = (byte)num15;
					num2 = 23;
					continue;
				case 361:
					array2[6] = 114;
					num2 = 106;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 226;
					}
					continue;
				case 99:
					array6 = (byte[])KMLbcYsZq6GYyCkJYIgx(lo0gPNsO1FdPmLPkq0Hr, (int)KxyRBvsZOy0osr1s1xnn(hZ45RVsZ6h239Iy2R1be(lo0gPNsO1FdPmLPkq0Hr)));
					num2 = 76;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 184;
					}
					continue;
				case 108:
					array = array4;
					num2 = 319;
					continue;
				case 95:
					num18 = 131 - 43;
					num2 = 131;
					continue;
				case 209:
					num16 = 168 - 56;
					num2 = 341;
					continue;
				case 295:
					array3[21] = (byte)num17;
					num2 = 244;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 253;
					}
					continue;
				case 26:
					array3[8] = 84;
					num2 = 297;
					continue;
				case 197:
					num16 = 92 + 46;
					num2 = 331;
					continue;
				case 407:
					num17 = 106 + 44;
					num2 = 366;
					continue;
				case 303:
					num36 = 255u;
					num2 = 348;
					continue;
				case 107:
					array3[11] = 143;
					num2 = 360;
					continue;
				case 260:
					num15 = 50 + 120;
					num2 = 233;
					continue;
				case 161:
					num17 = 181 + 55;
					num2 = 87;
					continue;
				case 143:
					array3[13] = 109;
					num2 = 130;
					continue;
				case 162:
					num32 = 0u;
					num = 171;
					break;
				case 184:
					array3 = new byte[32];
					num2 = 364;
					continue;
				case 315:
					num15 = 10 + 31;
					num2 = 227;
					continue;
				case 130:
					array3[13] = 95;
					num2 = 210;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 186;
					}
					continue;
				case 328:
					num32 = (uint)num19;
					num2 = 147;
					continue;
				case 123:
					num16 = 40 + 108;
					num2 = 79;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 70;
					}
					continue;
				case 372:
					array3[31] = (byte)num16;
					num2 = 129;
					continue;
				case 57:
					array3[27] = 124;
					num2 = 185;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 385;
					}
					continue;
				case 165:
				case 266:
					if (num26 >= array7.Length)
					{
						num2 = 352;
						continue;
					}
					goto case 383;
				case 38:
					array3[28] = (byte)num16;
					num = 8;
					break;
				case 192:
					num16 = 169 - 56;
					num2 = 195;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 306;
					}
					continue;
				case 102:
					array3[7] = (byte)num17;
					num2 = 182;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 43;
					}
					continue;
				case 230:
					num17 = 177 - 59;
					num2 = 317;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 163;
					}
					continue;
				case 56:
					num15 = 9 + 99;
					num = 4;
					break;
				case 221:
					num18 = 92 + 46;
					num2 = 203;
					continue;
				case 355:
					array3[9] = (byte)num17;
					num2 = 34;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 278;
					}
					continue;
				case 300:
					num17 = 158 - 52;
					num2 = 194;
					continue;
				case 144:
					array2[2] = 94;
					num2 = 3;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 166;
					}
					continue;
				case 234:
					num15 = 198 - 66;
					num2 = 379;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 321;
					}
					continue;
				case 342:
					array3[4] = 152;
					num2 = 14;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 132;
					}
					continue;
				case 40:
					array3[15] = 212;
					num = 249;
					break;
				case 365:
					num33 = 1;
					num2 = 390;
					continue;
				case 86:
					array3[16] = (byte)num17;
					num2 = 267;
					continue;
				case 291:
					num16 = 144 + 43;
					num2 = 169;
					continue;
				case 14:
					num25++;
					num2 = 162;
					continue;
				case 362:
					array3[19] = (byte)num17;
					num2 = 238;
					continue;
				case 413:
					array3[13] = 120;
					num2 = 209;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 17;
					}
					continue;
				case 175:
					num4 = 0u;
					num2 = 252;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 92;
					}
					continue;
				case 156:
					array4[num19 + 2] = (byte)((num20 & 0xFF0000) >> 16);
					num = 312;
					break;
				case 2:
					num16 = 86 + 75;
					num2 = 77;
					continue;
				case 181:
					array3[5] = (byte)num16;
					num2 = 42;
					continue;
				case 337:
					num16 = 208 - 69;
					num2 = 158;
					continue;
				case 41:
				case 271:
					if (num31 >= num25)
					{
						num2 = 108;
						if (omrIt7sZd56ARrZZwWhA() != null)
						{
							num2 = 95;
						}
						continue;
					}
					goto case 359;
				case 382:
					array2[2] = 175;
					num2 = 70;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 354;
					}
					continue;
				case 55:
					array3[7] = 76;
					num2 = 285;
					continue;
				case 246:
					array2[12] = 188;
					num2 = 268;
					continue;
				case 344:
					array3[26] = 112;
					num2 = 388;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 279;
					}
					continue;
				case 172:
					n0YwZqsZMf1rrs5puDds(hZ45RVsZ6h239Iy2R1be(lo0gPNsO1FdPmLPkq0Hr), 0L);
					num2 = 358;
					continue;
				case 285:
					num17 = 162 - 54;
					num2 = 243;
					continue;
				case 116:
					num20 = num4 ^ num30;
					num2 = 207;
					continue;
				case 54:
					num30 = 0u;
					num2 = 64;
					continue;
				case 273:
					array2[7] = 200;
					num2 = 115;
					continue;
				case 168:
					num17 = 239 - 79;
					num2 = 193;
					continue;
				case 288:
					array3[21] = (byte)num16;
					num2 = 20;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 10;
					}
					continue;
				case 241:
					num16 = 5 + 14;
					num2 = 60;
					continue;
				case 32:
					array3[12] = 221;
					num2 = 231;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 413;
					}
					continue;
				case 275:
					num16 = 231 - 77;
					num2 = 288;
					continue;
				case 409:
					array3[24] = (byte)num17;
					num2 = 337;
					continue;
				case 61:
					array3[29] = 171;
					num2 = 245;
					continue;
				case 87:
					array3[18] = (byte)num17;
					num2 = 2;
					continue;
				case 178:
					emjsOK43Ot7 = true;
					num2 = 389;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 61;
					}
					continue;
				case 261:
					array7 = array2;
					num2 = 365;
					continue;
				case 125:
					num17 = 152 - 50;
					num2 = 88;
					continue;
				case 392:
					num18 = 71 + 96;
					num2 = 340;
					continue;
				case 308:
					num18 = 103 + 13;
					num2 = 54;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 71;
					}
					continue;
				case 177:
					array3[3] = 132;
					num2 = 342;
					continue;
				case 28:
					num17 = 78 + 76;
					num2 = 31;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 102;
					}
					continue;
				case 374:
					array3[23] = (byte)num16;
					num2 = 135;
					continue;
				case 39:
					array8 = array3;
					num2 = 75;
					continue;
				case 290:
					array3[14] = 151;
					num2 = 254;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 399;
					}
					continue;
				case 287:
					array3[0] = 93;
					num = 353;
					break;
				case 224:
					array3[30] = 136;
					num2 = 1;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 0;
					}
					continue;
				case 27:
					array3[24] = 5;
					num2 = 195;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 206;
					}
					continue;
				case 81:
					array3[22] = 111;
					num2 = 118;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 279;
					}
					continue;
				case 256:
					array2[14] = (byte)num15;
					num2 = 401;
					continue;
				case 171:
					num31 = 0;
					num2 = 41;
					continue;
				case 250:
					num16 = 14 - 11;
					num2 = 138;
					continue;
				case 180:
					array3[29] = (byte)num17;
					num2 = 84;
					continue;
				case 205:
					if (num31 == num25 - 1)
					{
						num2 = 73;
						continue;
					}
					goto case 328;
				case 151:
					array3[25] = (byte)num16;
					num2 = 46;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 397;
					}
					continue;
				case 18:
					array3[16] = 149;
					num2 = 386;
					continue;
				case 194:
					array3[28] = (byte)num17;
					num2 = 91;
					continue;
				case 37:
					array2[6] = (byte)num18;
					num2 = 93;
					continue;
				case 415:
					array3[22] = (byte)num17;
					num = 81;
					break;
				case 347:
					num17 = 130 - 79;
					num2 = 333;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 41;
					}
					continue;
				case 208:
					num16 = 67 - 44;
					num2 = 374;
					continue;
				case 136:
					num16 = 92 + 103;
					num2 = 265;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 294;
					}
					continue;
				case 278:
					num16 = 133 - 71;
					num2 = 217;
					continue;
				case 406:
					array3[11] = (byte)num17;
					num2 = 238;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 272;
					}
					continue;
				case 98:
				case 402:
					hsksOrhnScw = g6EANAsZIfGxmPnkL41a(oDBCIhsZyp9hgnyxoDoP(array, 0u));
					num2 = 133;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 8;
					}
					continue;
				case 163:
					array3[13] = 91;
					num2 = 143;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 126;
					}
					continue;
				case 385:
					num16 = 163 - 54;
					num2 = 67;
					continue;
				case 187:
					num23++;
					num2 = 109;
					continue;
				case 206:
					num16 = 188 - 62;
					num2 = 188;
					continue;
				case 207:
					array4[num19] = (byte)(num20 & 0xFF);
					num2 = 248;
					continue;
				case 22:
					array3[15] = (byte)num17;
					num2 = 123;
					continue;
				case 410:
					num27++;
					num2 = 326;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 57;
					}
					continue;
				case 110:
					num17 = 143 - 47;
					num2 = 274;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 394;
					}
					continue;
				case 154:
					num25 = array5.Length / 4;
					num2 = 411;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 154;
					}
					continue;
				case 1:
					num17 = 131 - 43;
					num2 = 216;
					continue;
				case 113:
					num17 = 82 + 89;
					num2 = 69;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 35;
					}
					continue;
				case 336:
					array3[14] = 106;
					num2 = 311;
					continue;
				case 346:
					try
					{
						bybOMfsZWk4lk8sgAfPy(deflateStream, memoryStream);
						int num21 = 0;
						if (omrIt7sZd56ARrZZwWhA() != null)
						{
							num21 = 0;
						}
						switch (num21)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							int num22 = 0;
							if (xH24jOsZQmRuoRBlO2LU())
							{
								num22 = 0;
							}
							while (true)
							{
								switch (num22)
								{
								default:
									MaFvAmsZt5d4qviNhY8n(deflateStream);
									num22 = 0;
									if (xH24jOsZQmRuoRBlO2LU())
									{
										num22 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 114;
				case 46:
					array2[6] = (byte)num18;
					num2 = 361;
					continue;
				case 312:
					array4[num19 + 3] = (byte)((num20 & 0xFF000000u) >> 24);
					num2 = 181;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 214;
					}
					continue;
				case 376:
					num15 = 147 - 49;
					num2 = 173;
					continue;
				case 358:
					array = new byte[0];
					num2 = 99;
					continue;
				case 213:
					array2[14] = (byte)num15;
					num2 = 218;
					continue;
				case 135:
					num17 = 68 + 99;
					num2 = 393;
					continue;
				case 349:
					num17 = 72 + 118;
					num2 = 76;
					continue;
				case 257:
					num15 = 1 + 40;
					num2 = 16;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 106;
					}
					continue;
				case 316:
					num17 = 33 + 20;
					num2 = 409;
					continue;
				case 277:
					array2[13] = (byte)num18;
					num2 = 224;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 232;
					}
					continue;
				case 72:
					num17 = 230 + 23;
					num2 = 242;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 184;
					}
					continue;
				case 232:
					array2[13] = 112;
					num2 = 15;
					continue;
				case 264:
					array2[4] = (byte)num18;
					num2 = 237;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 260;
					}
					continue;
				case 320:
					array3[20] = 187;
					num2 = 407;
					continue;
				case 369:
					num17 = 248 - 82;
					num2 = 230;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 355;
					}
					continue;
				case 112:
					array3[18] = 120;
					num2 = 167;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 126;
					}
					continue;
				case 219:
					array2[8] = 128;
					num = 351;
					break;
				case 282:
					num16 = 21 + 76;
					num2 = 4;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 38;
					}
					continue;
				case 370:
					num17 = 74 + 44;
					num2 = 415;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 70;
					}
					continue;
				case 341:
					array3[13] = (byte)num16;
					num2 = 163;
					continue;
				case 134:
					array3[15] = (byte)num16;
					num2 = 118;
					continue;
				case 265:
					array3[3] = (byte)num16;
					num2 = 177;
					continue;
				case 398:
					array3[7] = 145;
					num = 28;
					break;
				case 302:
					array3[10] = (byte)num16;
					num = 197;
					break;
				case 114:
					hsksOrhnScw = g6EANAsZIfGxmPnkL41a(sJH9xksZUkHrUR4XZvnI(memoryStream));
					num2 = 263;
					continue;
				case 100:
					array3[29] = (byte)num17;
					num2 = 276;
					continue;
				case 47:
					array3[22] = (byte)num17;
					num = 204;
					break;
				case 78:
				case 367:
					hsksOrhnScw = g6EANAsZIfGxmPnkL41a(array);
					num2 = 381;
					continue;
				case 138:
					array3[4] = (byte)num16;
					num2 = 110;
					continue;
				case 106:
					array2[15] = (byte)num15;
					num2 = 56;
					continue;
				case 317:
					array3[17] = (byte)num17;
					num2 = 313;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 123;
					}
					continue;
				case 141:
					array2[3] = (byte)num18;
					num2 = 235;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 314;
					}
					continue;
				case 331:
					array3[11] = (byte)num16;
					num2 = 7;
					continue;
				case 236:
					array2[1] = (byte)num15;
					num2 = 368;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 355;
					}
					continue;
				case 229:
					array3[25] = (byte)num16;
					num2 = 212;
					continue;
				case 391:
					array3[7] = (byte)num17;
					num2 = 55;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 47;
					}
					continue;
				case 400:
					num16 = 16 + 52;
					num2 = 194;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 199;
					}
					continue;
				case 354:
					num15 = 65 + 99;
					num2 = 327;
					continue;
				case 259:
					num16 = 99 + 105;
					num2 = 134;
					continue;
				case 118:
					num17 = 95 + 18;
					num2 = 126;
					continue;
				case 408:
					array3[6] = (byte)num16;
					num2 = 51;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 92;
					}
					continue;
				case 64:
					num4 += num29;
					num2 = 145;
					continue;
				case 335:
					num16 = 241 - 80;
					num2 = 307;
					continue;
				case 179:
					array2[4] = 134;
					num2 = 211;
					continue;
				case 253:
					array3[21] = 27;
					num2 = 4;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 370;
					}
					continue;
				case 131:
					array2[11] = (byte)num18;
					num2 = 310;
					continue;
				case 34:
					array3[8] = (byte)num17;
					num2 = 16;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 26;
					}
					continue;
				case 276:
					array3[29] = 239;
					num2 = 237;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 237;
					}
					continue;
				case 334:
					array2[13] = (byte)num18;
					num2 = 298;
					continue;
				case 94:
					num18 = 62 - 31;
					num = 293;
					break;
				case 395:
					array3[5] = 140;
					num2 = 404;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 391;
					}
					continue;
				case 149:
					array3[0] = (byte)num17;
					num2 = 287;
					continue;
				case 137:
					num16 = 135 - 45;
					num2 = 151;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 54;
					}
					continue;
				case 73:
					if (num24 > 0)
					{
						num2 = 54;
						continue;
					}
					goto case 328;
				case 380:
					array2[1] = (byte)num15;
					num2 = 301;
					continue;
				case 82:
					lo0gPNsO1FdPmLPkq0Hr = new qhHWErs6IBu8qtqJbdvd.Lo0gPNsO1FdPmLPkq0Hr((Stream)OvqpncsZRpiYdSTeyQQ5(r8n6ThsZgRmhyV7cvH9B(typeof(qhHWErs6IBu8qtqJbdvd).TypeHandle).Assembly, qhHWErs6IBu8qtqJbdvd.rA7s6znQmFT(0x32DEA4F1 ^ 0x32DEA45F)));
					num2 = 172;
					continue;
				case 293:
					array2[7] = (byte)num18;
					num2 = 195;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 179;
					}
					continue;
				case 216:
					array3[31] = (byte)num17;
					num = 168;
					break;
				case 388:
					num16 = 123 + 60;
					num2 = 50;
					continue;
				case 119:
					num18 = 241 - 80;
					num2 = 292;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 249;
					}
					continue;
				case 333:
					array3[27] = (byte)num17;
					num2 = 300;
					continue;
				case 140:
					num37 = num4 ^ num30;
					num2 = 244;
					continue;
				case 157:
					array3[3] = 136;
					num2 = 155;
					continue;
				case 11:
					array3[24] = 123;
					num = 27;
					break;
				case 10:
					num16 = 193 - 64;
					num2 = 372;
					continue;
				case 371:
					array2[9] = 156;
					num2 = 234;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 228;
					}
					continue;
				case 360:
					num17 = 137 + 50;
					num2 = 406;
					continue;
				case 50:
					array3[26] = (byte)num16;
					num = 318;
					break;
				case 348:
					num34 = 0;
					num2 = 205;
					continue;
				case 92:
					num17 = 106 + 102;
					num2 = 13;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 10;
					}
					continue;
				case 25:
				case 326:
					if (num27 >= num24)
					{
						num2 = 122;
						continue;
					}
					goto case 142;
				case 268:
					num18 = 112 + 59;
					num2 = 44;
					continue;
				case 101:
					array3[1] = 93;
					num2 = 223;
					continue;
				case 343:
					array3[9] = (byte)num17;
					num2 = 369;
					continue;
				case 85:
					array3[5] = 97;
					num2 = 47;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 395;
					}
					continue;
				case 133:
				case 189:
				case 381:
					ohgsOCwqbH5 = (string[])PPWCqjsZZEbuly7rtGWu((Assembly)hsksOrhnScw);
					num2 = 43;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 178;
					}
					continue;
				case 218:
					num18 = 29 + 50;
					num2 = 262;
					continue;
				case 62:
					array2[1] = 144;
					num2 = 308;
					continue;
				case 45:
					num17 = 180 - 60;
					num2 = 145;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 180;
					}
					continue;
				case 384:
					array2[6] = 149;
					num2 = 24;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 152;
					}
					continue;
				case 368:
					num15 = 52 + 105;
					num2 = 380;
					continue;
				case 84:
					array3[29] = 118;
					num2 = 378;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 209;
					}
					continue;
				case 416:
					num17 = 202 - 67;
					num2 = 362;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 48;
					}
					continue;
				case 299:
					array3[10] = (byte)num17;
					num2 = 192;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 46;
					}
					continue;
				case 318:
					array3[27] = 110;
					num2 = 57;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 19;
					}
					continue;
				case 301:
					num15 = 27 + 8;
					num2 = 135;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 283;
					}
					continue;
				case 284:
					array2[7] = (byte)num15;
					num2 = 273;
					continue;
				case 387:
					array3[1] = (byte)num16;
					num2 = 127;
					continue;
				case 63:
					array3[2] = (byte)num17;
					num2 = 321;
					continue;
				case 393:
					array3[24] = (byte)num17;
					num2 = 19;
					continue;
				case 6:
					num17 = 82 + 34;
					num2 = 90;
					continue;
				case 329:
					num17 = 7 + 70;
					num2 = 47;
					continue;
				case 311:
					array3[14] = 118;
					num2 = 123;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 349;
					}
					continue;
				case 16:
					num24 = array5.Length % 4;
					num2 = 154;
					continue;
				case 169:
					array3[2] = (byte)num16;
					num2 = 136;
					continue;
				case 375:
					array3[14] = 154;
					num2 = 290;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 103;
					}
					continue;
				case 145:
					num27 = 0;
					num2 = 25;
					continue;
				case 80:
					array3[24] = (byte)num17;
					num2 = 316;
					continue;
				case 314:
					num18 = 58 + 71;
					num2 = 254;
					continue;
				case 51:
					array4[num19 + num23] = (byte)((num37 & num36) >> num34);
					num2 = 187;
					continue;
				case 3:
					array2[10] = 18;
					num2 = 221;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 202;
					}
					continue;
				case 200:
					num30 = 0u;
					num2 = 96;
					continue;
				case 202:
					if (num33 != 1)
					{
						num2 = 98;
						continue;
					}
					goto case 357;
				case 147:
					num4 += num29;
					num2 = 52;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 43;
					}
					continue;
				case 13:
					array3[6] = (byte)num17;
					num2 = 323;
					continue;
				case 305:
					num15 = 81 + 82;
					num2 = 236;
					continue;
				case 160:
					num16 = 107 + 97;
					num2 = 265;
					continue;
				case 345:
					num16 = 37 + 36;
					num2 = 258;
					continue;
				case 176:
					array3[16] = (byte)num17;
					num = 332;
					break;
				case 193:
					array3[31] = (byte)num17;
					num2 = 5;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 10;
					}
					continue;
				case 215:
					array2[0] = (byte)num15;
					num2 = 251;
					continue;
				case 201:
					num30 |= array5[array5.Length - (1 + num27)];
					num2 = 410;
					continue;
				case 121:
					num15 = 108 + 41;
					num2 = 215;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 103;
					}
					continue;
				case 19:
					num17 = 5 + 51;
					num2 = 80;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 19;
					}
					continue;
				case 237:
					num16 = 119 + 101;
					num2 = 7;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 74;
					}
					continue;
				case 105:
					array3[23] = 68;
					num2 = 345;
					continue;
				case 269:
					array3[26] = 162;
					num = 344;
					break;
				case 359:
					num35 = num31 % num28;
					num2 = 247;
					continue;
				case 60:
					array3[25] = (byte)num16;
					num2 = 322;
					continue;
				case 267:
					array3[16] = 64;
					num2 = 6;
					continue;
				case 235:
					array2[14] = (byte)num15;
					num2 = 89;
					continue;
				case 248:
					array4[num19 + 1] = (byte)((num20 & 0xFF00) >> 8);
					num2 = 156;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 91;
					}
					continue;
				case 152:
					num18 = 214 - 71;
					num2 = 29;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 37;
					}
					continue;
				case 296:
					deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress);
					num = 346;
					break;
				case 270:
					array3[23] = 156;
					num2 = 31;
					continue;
				case 321:
					array3[2] = 133;
					num2 = 48;
					continue;
				case 52:
					num30 = (uint)((array5[num32 + 3] << 24) | (array5[num32 + 2] << 16) | (array5[num32 + 1] << 8) | array5[num32]);
					num2 = 41;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 58;
					}
					continue;
				case 228:
					array3[6] = (byte)num16;
					num2 = 139;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 95;
					}
					continue;
				case 214:
				case 377:
					num31++;
					num2 = 271;
					continue;
				case 379:
					array2[10] = (byte)num15;
					num2 = 373;
					continue;
				case 212:
					array3[25] = 108;
					num2 = 241;
					continue;
				case 280:
					array2[8] = (byte)num15;
					num2 = 219;
					continue;
				case 412:
					array3[30] = 135;
					num2 = 114;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 224;
					}
					continue;
				case 383:
					array8[num26] ^= array7[num26];
					num2 = 68;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 41;
					}
					continue;
				case 242:
					array3[20] = (byte)num17;
					num2 = 275;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 126;
					}
					continue;
				default:
					array3[17] = (byte)num17;
					num2 = 13;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 29;
					}
					continue;
				case 43:
					array3[2] = 131;
					num = 291;
					break;
				case 339:
					num36 <<= 8;
					num2 = 153;
					continue;
				case 389:
					return;
				case 70:
					num17 = 198 - 66;
					num2 = 295;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 299;
					}
					continue;
				case 9:
					array2[7] = 47;
					num2 = 94;
					continue;
				case 324:
					num18 = 145 - 56;
					num2 = 27;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 334;
					}
					continue;
				case 24:
					num17 = 200 - 66;
					num2 = 231;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 39;
					}
					continue;
				case 231:
					array3[10] = (byte)num17;
					num2 = 70;
					continue;
				case 220:
					array3[30] = 129;
					num2 = 412;
					continue;
				case 166:
					array2[2] = 107;
					num2 = 315;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 213;
					}
					continue;
				case 164:
					num18 = 108 + 48;
					num2 = 141;
					continue;
				case 182:
					array3[8] = 135;
					num2 = 325;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 27;
					}
					continue;
				case 17:
					num16 = 103 + 28;
					num2 = 79;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 191;
					}
					continue;
				case 289:
					if (num24 > 0)
					{
						num2 = 140;
						continue;
					}
					goto case 116;
				case 414:
					array2[0] = 232;
					num2 = 304;
					continue;
				case 243:
					array3[7] = (byte)num17;
					num2 = 5;
					continue;
				case 245:
					array3[29] = 113;
					num2 = 34;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 45;
					}
					continue;
				case 167:
					array3[18] = 84;
					num2 = 161;
					continue;
				case 139:
					array3[6] = 170;
					num2 = 128;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 125;
					}
					continue;
				case 21:
					array3[20] = 105;
					num2 = 72;
					continue;
				case 327:
					array2[3] = (byte)num15;
					num2 = 164;
					continue;
				case 7:
					array3[11] = 35;
					num2 = 25;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 36;
					}
					continue;
				case 185:
					array2[5] = 17;
					num2 = 191;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 384;
					}
					continue;
				case 244:
					num23 = 0;
					num2 = 338;
					continue;
				case 396:
					num16 = 201 - 120;
					num2 = 387;
					continue;
				case 183:
					array3[6] = (byte)num16;
					num2 = 159;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 15;
					}
					continue;
				case 356:
					num32 = (uint)(num35 * 4);
					num2 = 148;
					continue;
				case 394:
					array3[5] = (byte)num17;
					num2 = 54;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 85;
					}
					continue;
				case 307:
					array3[12] = (byte)num16;
					num2 = 32;
					continue;
				case 255:
					array3[22] = (byte)num16;
					num2 = 329;
					continue;
				case 298:
					num15 = 42 + 51;
					num2 = 213;
					continue;
				case 254:
					array2[3] = (byte)num18;
					num2 = 179;
					continue;
				case 186:
					if (num31 == num25 - 1)
					{
						num2 = 289;
						continue;
					}
					goto case 116;
				case 83:
					if (emjsOK43Ot7)
					{
						return;
					}
					num2 = 82;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 16;
					}
					continue;
				case 401:
					num15 = 54 + 102;
					num2 = 103;
					continue;
				case 148:
					num29 = (uint)((array8[num32 + 3] << 24) | (array8[num32 + 2] << 16) | (array8[num32 + 1] << 8) | array8[num32]);
					num2 = 215;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 303;
					}
					continue;
				case 153:
					num34 += 8;
					num2 = 30;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 51;
					}
					continue;
				case 96:
					if (num24 > 0)
					{
						num2 = 8;
						if (xH24jOsZQmRuoRBlO2LU())
						{
							num2 = 14;
						}
						continue;
					}
					goto case 162;
				case 262:
					array2[14] = (byte)num18;
					num2 = 126;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 198;
					}
					continue;
				case 340:
					array2[9] = (byte)num18;
					num2 = 36;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 371;
					}
					continue;
				case 188:
					array3[25] = (byte)num16;
					num2 = 137;
					continue;
				case 68:
					num26++;
					num2 = 266;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 70;
					}
					continue;
				case 90:
					array3[17] = (byte)num17;
					num2 = 230;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 171;
					}
					continue;
				case 390:
					num26 = 0;
					num2 = 32;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 165;
					}
					continue;
				case 233:
					array2[5] = (byte)num15;
					num2 = 111;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 101;
					}
					continue;
				case 364:
					num17 = 238 - 79;
					num2 = 93;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 149;
					}
					continue;
				case 325:
					num17 = 187 - 62;
					num2 = 34;
					continue;
				case 191:
					array3[9] = (byte)num16;
					num2 = 125;
					continue;
				case 49:
					array2[2] = 158;
					num2 = 382;
					continue;
				case 404:
					num16 = 124 + 44;
					num2 = 181;
					continue;
				case 304:
					num15 = 85 + 6;
					num2 = 30;
					continue;
				case 204:
					num17 = 162 + 23;
					num2 = 12;
					continue;
				case 158:
					array3[24] = (byte)num16;
					num2 = 11;
					continue;
				case 198:
					num15 = 200 - 66;
					num = 256;
					break;
				case 238:
					array3[19] = 201;
					num2 = 400;
					continue;
				case 323:
					num17 = 181 - 60;
					num2 = 391;
					continue;
				case 66:
					array3[28] = (byte)num16;
					num2 = 282;
					continue;
				case 263:
					wcR4JIsZTgaje5bjoDtB(memoryStream);
					num2 = 20;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 189;
					}
					continue;
				case 195:
					num15 = 28 + 120;
					num = 280;
					break;
				case 4:
					array2[15] = (byte)num15;
					num2 = 59;
					continue;
				case 249:
					array3[16] = 149;
					num2 = 18;
					continue;
				case 351:
					array2[8] = 198;
					num2 = 53;
					continue;
				case 142:
					if (num27 > 0)
					{
						num2 = 30;
						if (omrIt7sZd56ARrZZwWhA() == null)
						{
							num2 = 174;
						}
						continue;
					}
					goto case 201;
				case 159:
					num16 = 152 - 50;
					num2 = 228;
					continue;
				case 76:
					array3[14] = (byte)num17;
					num2 = 375;
					continue;
				case 155:
					num16 = 157 - 52;
					num2 = 2;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 35;
					}
					continue;
				case 23:
					num15 = 211 + 18;
					num2 = 117;
					continue;
				case 124:
					array3[27] = 100;
					num2 = 140;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 347;
					}
					continue;
				case 91:
					num16 = 141 - 47;
					num2 = 66;
					continue;
				case 239:
					num18 = 59 + 52;
					num2 = 277;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 44;
					}
					continue;
				case 69:
					array3[2] = (byte)num17;
					num2 = 43;
					continue;
				case 258:
					array3[23] = (byte)num16;
					num2 = 208;
					continue;
				case 29:
					array3[17] = 108;
					num = 112;
					break;
				case 199:
					array3[20] = (byte)num16;
					num2 = 320;
					continue;
				case 132:
					array3[4] = 159;
					num2 = 250;
					continue;
				case 150:
					num17 = 231 - 77;
					num = 343;
					break;
				case 111:
					array2[5] = 197;
					num2 = 185;
					continue;
				case 203:
					array2[11] = (byte)num18;
					num2 = 95;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 58;
					}
					continue;
				case 77:
					array3[19] = (byte)num16;
					num2 = 416;
					continue;
				case 306:
					array3[10] = (byte)num16;
					num2 = 405;
					continue;
				case 211:
					array2[4] = 83;
					num2 = 335;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 403;
					}
					continue;
				case 294:
					array3[3] = (byte)num16;
					num2 = 157;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 26;
					}
					continue;
				case 104:
					num15 = 48 + 88;
					num2 = 51;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 284;
					}
					continue;
				case 309:
					num17 = 249 - 83;
					num2 = 22;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 5;
					}
					continue;
				case 88:
					array3[9] = (byte)num17;
					num2 = 150;
					continue;
				case 79:
					array3[15] = (byte)num16;
					num2 = 41;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 259;
					}
					continue;
				case 350:
					array2[4] = 99;
					num = 65;
					break;
				case 5:
					array3[7] = 163;
					num2 = 398;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 202;
					}
					continue;
				case 357:
					memoryStream = new MemoryStream();
					num2 = 76;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 296;
					}
					continue;
				case 75:
					array2 = new byte[16];
					num2 = 121;
					continue;
				case 274:
					if (num23 > 0)
					{
						num2 = 339;
						continue;
					}
					goto case 51;
				case 170:
					array3[2] = (byte)num16;
					num2 = 113;
					continue;
				case 42:
					num16 = 98 + 22;
					num2 = 183;
					continue;
				case 93:
					num18 = 205 - 68;
					num2 = 46;
					continue;
				case 310:
					array2[11] = 127;
					num2 = 96;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 97;
					}
					continue;
				case 223:
					array3[1] = 129;
					num2 = 396;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 334;
					}
					continue;
				case 313:
					num17 = 166 - 55;
					num2 = 0;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 0;
					}
					continue;
				case 283:
					array2[2] = (byte)num15;
					num2 = 68;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 144;
					}
					continue;
				case 281:
					num15 = 162 + 20;
					num2 = 235;
					continue;
				case 247:
					num19 = num31 * 4;
					num2 = 356;
					continue;
				case 12:
					array3[22] = (byte)num17;
					num2 = 172;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 270;
					}
					continue;
				case 74:
					array3[30] = (byte)num16;
					num2 = 163;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 220;
					}
					continue;
				case 217:
					array3[9] = (byte)num16;
					num2 = 24;
					continue;
				case 378:
					num17 = 227 - 75;
					num2 = 13;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 100;
					}
					continue;
				case 44:
					array2[12] = (byte)num18;
					num = 225;
					break;
				case 330:
					array2[7] = (byte)num15;
					num2 = 9;
					continue;
				case 20:
					num17 = 40 + 108;
					num = 295;
					break;
				case 405:
					array3[10] = 91;
					num2 = 30;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 33;
					}
					continue;
				case 322:
					array3[25] = 222;
					num2 = 266;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 269;
					}
					continue;
				case 173:
					array2[0] = (byte)num15;
					num2 = 222;
					continue;
				case 126:
					array3[15] = (byte)num17;
					num2 = 40;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 7;
					}
					continue;
				case 411:
					array4 = new byte[array5.Length];
					num2 = 190;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 72;
					}
					continue;
				case 332:
					num17 = 221 - 73;
					num2 = 83;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 86;
					}
					continue;
				case 353:
					array3[0] = 99;
					num2 = 101;
					continue;
				case 174:
					num30 <<= 8;
					num2 = 201;
					continue;
				case 36:
					num16 = 211 - 70;
					num2 = 146;
					continue;
				case 252:
					num29 = 0u;
					num2 = 200;
					continue;
				case 115:
					num15 = 214 - 71;
					num2 = 330;
					continue;
				case 286:
					array2[13] = (byte)num18;
					num2 = 196;
					continue;
				case 272:
					array3[12] = 167;
					num2 = 335;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 42;
					}
					continue;
				case 403:
					array2[4] = 118;
					num2 = 350;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 164;
					}
					continue;
				case 59:
					num15 = 203 - 67;
					num2 = 120;
					continue;
				case 33:
					num16 = 68 - 25;
					num = 302;
					break;
				case 196:
					array2[13] = 86;
					num2 = 324;
					continue;
				case 8:
					num17 = 115 + 16;
					num2 = 162;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 363;
					}
					continue;
				case 190:
					num28 = array8.Length / 4;
					num2 = 175;
					continue;
				case 399:
					array3[15] = 145;
					num2 = 309;
					continue;
				case 15:
					num18 = 24 + 67;
					num2 = 150;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 286;
					}
					continue;
				case 227:
					array2[2] = (byte)num15;
					num2 = 49;
					continue;
				case 30:
					array2[1] = (byte)num15;
					num2 = 45;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 62;
					}
					continue;
				case 89:
					array2[15] = 144;
					num2 = 78;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 257;
					}
					continue;
				case 128:
					num16 = 101 + 96;
					num2 = 408;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 209;
					}
					continue;
				case 103:
					array2[14] = (byte)num15;
					num2 = 281;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 212;
					}
					continue;
				case 53:
					array2[9] = 166;
					num = 392;
					break;
				case 210:
					array3[13] = 145;
					num2 = 336;
					continue;
				case 97:
					array2[12] = 145;
					num2 = 246;
					continue;
				case 386:
					num17 = 93 + 73;
					num2 = 176;
					continue;
				case 240:
					array2[10] = 89;
					num2 = 3;
					continue;
				case 35:
					array3[3] = (byte)num16;
					num2 = 148;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 160;
					}
					continue;
				case 127:
					num17 = 6 + 122;
					num2 = 63;
					continue;
				case 129:
					array3[31] = 91;
					num2 = 0;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 39;
					}
					continue;
				case 397:
					num16 = 54 + 4;
					num2 = 37;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 229;
					}
					continue;
				case 48:
					num16 = 210 - 70;
					num2 = 170;
					if (!xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 75;
					}
					continue;
				case 226:
					array2[6] = 116;
					num2 = 104;
					continue;
				case 67:
					array3[27] = (byte)num16;
					num2 = 124;
					continue;
				case 352:
					array5 = array6;
					num2 = 16;
					continue;
				case 109:
				case 338:
					if (num23 >= num24)
					{
						num2 = 377;
						if (!xH24jOsZQmRuoRBlO2LU())
						{
							num2 = 150;
						}
						continue;
					}
					goto case 274;
				case 31:
					array3[23] = 128;
					num2 = 105;
					if (omrIt7sZd56ARrZZwWhA() != null)
					{
						num2 = 87;
					}
					continue;
				case 71:
					array2[1] = (byte)num18;
					num2 = 305;
					continue;
				case 363:
					array3[28] = (byte)num17;
					num2 = 41;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 61;
					}
					continue;
				case 65:
					num18 = 150 + 26;
					num2 = 109;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 264;
					}
					continue;
				case 146:
					array3[11] = (byte)num16;
					num = 107;
					break;
				case 117:
					array2[15] = (byte)num15;
					num2 = 261;
					continue;
				case 292:
					array2[13] = (byte)num18;
					num2 = 95;
					if (omrIt7sZd56ARrZZwWhA() == null)
					{
						num2 = 239;
					}
					continue;
				case 366:
					array3[20] = (byte)num17;
					num = 21;
					break;
				case 373:
					array2[10] = 131;
					num2 = 240;
					continue;
				case 279:
					num16 = 184 - 61;
					num2 = 255;
					continue;
				case 58:
				case 122:
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
					num2 = 100;
					if (xH24jOsZQmRuoRBlO2LU())
					{
						num2 = 186;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] UfusOZpmQDl(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(33554465)).Assembly)
		{
			if (!emjsOK43Ot7)
			{
				I5EsOywcnj9();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)hsksOrhnScw).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly wxCsOVRlMrP(object P_0, ResolveEventArgs P_1)
	{
		if (!emjsOK43Ot7)
		{
			I5EsOywcnj9();
		}
		string name = P_1.Name;
		for (int i = 0; i < ohgsOCwqbH5.Length; i++)
		{
			if (ohgsOCwqbH5[i] == name)
			{
				return (Assembly)hsksOrhnScw;
			}
		}
		return null;
	}

	public vgyu2XsOtpI4mGGhk89T()
	{
		AppDomain.CurrentDomain.ResourceResolve += wxCsOVRlMrP;
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!UnPsOmM8n1r)
		{
			UnPsOmM8n1r = true;
			new vgyu2XsOtpI4mGGhk89T();
		}
	}

	internal static Type r8n6ThsZgRmhyV7cvH9B(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object OvqpncsZRpiYdSTeyQQ5(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object hZ45RVsZ6h239Iy2R1be(object P_0)
	{
		return ((qhHWErs6IBu8qtqJbdvd.Lo0gPNsO1FdPmLPkq0Hr)P_0).m9OIO8Q0EK();
	}

	internal static void n0YwZqsZMf1rrs5puDds(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long KxyRBvsZOy0osr1s1xnn(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object KMLbcYsZq6GYyCkJYIgx(object P_0, int P_1)
	{
		return ((qhHWErs6IBu8qtqJbdvd.Lo0gPNsO1FdPmLPkq0Hr)P_0).XHIsO5TRG9D(P_1);
	}

	internal static object g6EANAsZIfGxmPnkL41a(object P_0)
	{
		return m2iTu5sOwLnoN8hZpiQx.hrgsOueGtIo((byte[])P_0);
	}

	internal static void bybOMfsZWk4lk8sgAfPy(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void MaFvAmsZt5d4qviNhY8n(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object sJH9xksZUkHrUR4XZvnI(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void wcR4JIsZTgaje5bjoDtB(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object oDBCIhsZyp9hgnyxoDoP(object P_0, uint P_1)
	{
		return m2iTu5sOwLnoN8hZpiQx.VFUsOzrQwTJ((byte[])P_0, P_1);
	}

	internal static object PPWCqjsZZEbuly7rtGWu(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool xH24jOsZQmRuoRBlO2LU()
	{
		return (object)null == null;
	}

	internal static object omrIt7sZd56ARrZZwWhA()
	{
		return null;
	}
}
