using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using CxrNctLVMAMdEWPCMHj4;

namespace aAa0wvLVte7CLQrFHlCF;

internal class ObwCXyLVWLAqZaA6biRs
{
	private enum qBbspfLVm5cCJYj9GrM7
	{

	}

	internal class admJtILVhewRvZg7a0jD
	{
		private unsafe static uint Wv7LVwCPPb1(void* P_0, uint P_1)
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

		private unsafe static bool t18LV7udwFY(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void YM1LV8DuRHn(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void TkuLVAtMj3J(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void LcRLVPdIXFC(byte* P_0, byte* P_1, uint P_2)
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
				TkuLVAtMj3J(P_0, P_1, P_2);
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

		private unsafe static uint rqJLVJ5yr8a(byte[] P_0, uint P_1, qBbspfLVm5cCJYj9GrM7 P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint qYILVFOPEeY(byte[] P_0, uint P_1)
		{
			return rqJLVJ5yr8a(P_0, P_1, (qBbspfLVm5cCJYj9GrM7)3);
		}

		private unsafe static uint hb1LV3c6ZRv(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + Wv7LVwCPPb1(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (Wv7LVwCPPb1(ptr6 + 4, 4u) != 1)
					{
						TkuLVAtMj3J(ptr2, ptr3 + num, Wv7LVwCPPb1(ptr6 + 3, 4u));
						return Wv7LVwCPPb1(ptr6 + 3, 4u);
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
							num2 = Wv7LVwCPPb1(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = Wv7LVwCPPb1(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								LcRLVPdIXFC(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								LcRLVPdIXFC(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								LcRLVPdIXFC(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								LcRLVPdIXFC(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								LcRLVPdIXFC(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								YM1LV8DuRHn(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							LcRLVPdIXFC(ptr5, ptr4, 4u);
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

		internal static object FgZLVpci4vB(byte[] P_0)
		{
			return Type.GetTypeFromHandle(jTIj5AeyxsjML1UV53mF(16777254)).GetMethod(((string)q6i767eyLAkly4J8r93D(-45476899 ^ -45433543)).Trim(), new Type[1] { typeof(byte[]) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] ID5LVuG6iH7(byte[] P_0, uint P_1)
		{
			uint num = qYILVFOPEeY(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				hb1LV3c6ZRv(P_0, P_1, array);
			}
			return array;
		}

		internal static RuntimeTypeHandle jTIj5AeyxsjML1UV53mF(int token)
		{
			return PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(token);
		}

		internal static object q6i767eyLAkly4J8r93D(int P_0)
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
		}
	}

	private static string[] RdZLVVuoOWH = new string[0];

	private static object dE4LVCZcQFV = null;

	private static bool xZrLVrUlU6B = false;

	private static bool cDjLVKEZNFg = false;

	private static void xjFLVT2I3fc()
	{
		int num = 167;
		int num28 = default(int);
		int num31 = default(int);
		int num15 = default(int);
		byte[] array2 = default(byte[]);
		int num16 = default(int);
		byte[] array = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		int num32 = default(int);
		byte[] array3 = default(byte[]);
		int num20 = default(int);
		uint num21 = default(uint);
		int num22 = default(int);
		uint num17 = default(uint);
		byte[] array6 = default(byte[]);
		uint num33 = default(uint);
		byte[] array4 = default(byte[]);
		byte[] array8 = default(byte[]);
		yVbruBLyqe9BOsO9Yb5E.rFjo4ELVkSpcIZcFSLKW rFjo4ELVkSpcIZcFSLKW = default(yVbruBLyqe9BOsO9Yb5E.rFjo4ELVkSpcIZcFSLKW);
		DeflateStream deflateStream = default(DeflateStream);
		int num29 = default(int);
		uint num26 = default(uint);
		uint num18 = default(uint);
		int num35 = default(int);
		int num30 = default(int);
		byte[] array7 = default(byte[]);
		int num34 = default(int);
		byte[] array5 = default(byte[]);
		int num19 = default(int);
		uint num25 = default(uint);
		int num27 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 141:
					if (num28 == num31 - 1)
					{
						num2 = 289;
						continue;
					}
					goto case 149;
				case 281:
					num15 = 69 + 8;
					num2 = 295;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 170;
					}
					continue;
				case 311:
					array2[14] = (byte)num16;
					num2 = 61;
					continue;
				case 300:
					num15 = 4 + 68;
					num2 = 72;
					continue;
				case 60:
					num15 = 28 + 37;
					num2 = 131;
					continue;
				case 40:
					num16 = 33 + 80;
					num2 = 269;
					continue;
				case 350:
					array[12] = (byte)num15;
					num2 = 381;
					continue;
				case 354:
					array[8] = 144;
					num2 = 125;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 102;
					}
					continue;
				case 327:
					num15 = 42 + 119;
					num = 5;
					break;
				case 352:
					fqJGjRLAsLNuwwWxqE1Q(memoryStream);
					num2 = 137;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 69;
					}
					continue;
				case 219:
					array[1] = (byte)num15;
					num2 = 91;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 217;
					}
					continue;
				case 51:
					array2[8] = 112;
					num2 = 160;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 290;
					}
					continue;
				case 180:
					num16 = 31 + 35;
					num2 = 282;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 124;
					}
					continue;
				case 53:
					array[23] = (byte)num15;
					num = 144;
					break;
				case 283:
					num4 = 0u;
					num2 = 79;
					continue;
				case 371:
					array2[14] = (byte)num16;
					num2 = 325;
					continue;
				case 306:
					num16 = 4 + 68;
					num2 = 313;
					continue;
				case 155:
					num32++;
					num2 = 163;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 231;
					}
					continue;
				case 330:
					array3[num20] = (byte)(num21 & 0xFF);
					num2 = 123;
					continue;
				case 7:
					array[10] = 110;
					num = 39;
					break;
				case 190:
					array2[2] = (byte)num16;
					num2 = 304;
					continue;
				case 200:
					num15 = 147 - 49;
					num2 = 249;
					continue;
				case 380:
					array[11] = (byte)num15;
					num2 = 164;
					continue;
				case 386:
					array2[2] = 200;
					num2 = 196;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 61;
					}
					continue;
				case 310:
					array2[13] = 166;
					num2 = 342;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 17;
					}
					continue;
				case 216:
					array2[1] = (byte)num16;
					num = 12;
					break;
				case 317:
					array2[13] = 79;
					num2 = 310;
					continue;
				case 197:
					array[24] = 59;
					num2 = 177;
					continue;
				case 346:
					array2[12] = (byte)num16;
					num2 = 331;
					continue;
				case 226:
					num15 = 84 + 18;
					num = 48;
					break;
				case 170:
					if (num22 > 0)
					{
						num2 = 203;
						if (hIcU8CLA4OflfaRaU8gJ() == null)
						{
							num2 = 214;
						}
						continue;
					}
					goto case 284;
				case 201:
					num16 = 224 - 74;
					num2 = 10;
					continue;
				case 264:
					num16 = 6 + 53;
					num2 = 333;
					continue;
				case 100:
					num17 = (uint)((array6[num33 + 3] << 24) | (array6[num33 + 2] << 16) | (array6[num33 + 1] << 8) | array6[num33]);
					num2 = 24;
					continue;
				case 120:
					num16 = 16 + 44;
					num2 = 351;
					continue;
				case 132:
					num15 = 139 - 46;
					num2 = 68;
					continue;
				case 103:
				case 140:
					dE4LVCZcQFV = R690rqLASskICwXqDs3s(array4);
					num2 = 2;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 142;
					}
					continue;
				case 263:
					num15 = 160 - 53;
					num2 = 43;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 33;
					}
					continue;
				case 207:
					array[3] = 110;
					num2 = 263;
					continue;
				case 368:
					array[16] = (byte)num15;
					num2 = 212;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 383;
					}
					continue;
				case 269:
					array2[9] = (byte)num16;
					num2 = 264;
					continue;
				case 383:
					num15 = 7 + 13;
					num2 = 56;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 174;
					}
					continue;
				case 20:
					num16 = 114 + 112;
					num = 9;
					break;
				case 379:
					array2[5] = 140;
					num = 104;
					break;
				case 217:
					array[1] = 154;
					num2 = 390;
					continue;
				case 224:
					array[31] = (byte)num15;
					num2 = 279;
					continue;
				case 139:
					array4 = new byte[0];
					num = 251;
					break;
				case 14:
					array[8] = 2;
					num2 = 3;
					continue;
				case 4:
					array2[12] = (byte)num16;
					num2 = 150;
					continue;
				case 308:
					num31 = array6.Length / 4;
					num2 = 78;
					continue;
				case 178:
					array[17] = (byte)num15;
					num = 33;
					break;
				case 393:
					array[1] = (byte)num15;
					num2 = 362;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 31;
					}
					continue;
				case 325:
					num16 = 82 - 33;
					num2 = 39;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 193;
					}
					continue;
				case 225:
					array2[5] = (byte)num16;
					num = 332;
					break;
				case 37:
					num15 = 75 - 8;
					num = 148;
					break;
				case 378:
					array[16] = (byte)num15;
					num2 = 242;
					continue;
				case 123:
					array3[num20 + 1] = (byte)((num21 & 0xFF00) >> 8);
					num2 = 186;
					continue;
				case 297:
					array[29] = 41;
					num2 = 188;
					continue;
				default:
					num16 = 178 - 59;
					num2 = 209;
					continue;
				case 67:
					num16 = 231 - 77;
					num2 = 216;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 15;
					}
					continue;
				case 293:
					num15 = 127 - 42;
					num2 = 312;
					continue;
				case 117:
					num33 = 0u;
					num = 285;
					break;
				case 166:
					return;
				case 43:
					array[3] = (byte)num15;
					num2 = 195;
					continue;
				case 319:
					array[19] = 102;
					num2 = 236;
					continue;
				case 244:
					array[27] = (byte)num15;
					num2 = 62;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 48;
					}
					continue;
				case 251:
					array8 = (byte[])hgOkX4LA572ji2xHamit(rFjo4ELVkSpcIZcFSLKW, (int)Dmuki2LA1i61beAQND76(c0q1XwLANSaT5eIXuLMZ(rFjo4ELVkSpcIZcFSLKW)));
					num2 = 370;
					continue;
				case 289:
					if (num22 > 0)
					{
						num2 = 93;
						continue;
					}
					goto case 149;
				case 358:
					array[29] = (byte)num15;
					num2 = 297;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 196;
					}
					continue;
				case 397:
					array[26] = (byte)num15;
					num2 = 347;
					continue;
				case 106:
					array[9] = 202;
					num2 = 58;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 11;
					}
					continue;
				case 195:
					num15 = 5 + 124;
					num2 = 49;
					continue;
				case 314:
					deflateStream = new DeflateStream(new MemoryStream(array4), CompressionMode.Decompress);
					num2 = 55;
					continue;
				case 343:
					if (num29 != 1)
					{
						num2 = 10;
						if (hIcU8CLA4OflfaRaU8gJ() == null)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 360;
				case 1:
					num15 = 79 + 51;
					num = 291;
					break;
				case 341:
					array[21] = (byte)num15;
					num2 = 63;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 70;
					}
					continue;
				case 49:
					array[3] = (byte)num15;
					num2 = 335;
					continue;
				case 373:
					num15 = 243 - 81;
					num2 = 122;
					continue;
				case 81:
					array[15] = 149;
					num2 = 63;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 267;
					}
					continue;
				case 33:
					num15 = 169 - 56;
					num2 = 206;
					continue;
				case 322:
					num15 = 126 - 42;
					num2 = 18;
					continue;
				case 335:
					num15 = 31 + 88;
					num2 = 239;
					continue;
				case 150:
					num16 = 222 - 74;
					num = 398;
					break;
				case 84:
					array[20] = 140;
					num2 = 191;
					continue;
				case 148:
					array[27] = (byte)num15;
					num2 = 211;
					continue;
				case 381:
					array[12] = 88;
					num2 = 65;
					continue;
				case 304:
					num16 = 99 - 44;
					num2 = 87;
					continue;
				case 218:
					num15 = 99 - 68;
					num2 = 105;
					continue;
				case 259:
					array[26] = 168;
					num2 = 69;
					continue;
				case 121:
				case 208:
					num28++;
					num2 = 192;
					continue;
				case 129:
					array[18] = 73;
					num2 = 273;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 158;
					}
					continue;
				case 272:
					rFjo4ELVkSpcIZcFSLKW = new yVbruBLyqe9BOsO9Yb5E.rFjo4ELVkSpcIZcFSLKW((Stream)P9lm8rLAb8VAkNxR4d59(wqs4ZRLADU03CS4mwVxO(typeof(yVbruBLyqe9BOsO9Yb5E).TypeHandle).Assembly, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7E551)));
					num2 = 188;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 296;
					}
					continue;
				case 399:
					num15 = 102 - 40;
					num2 = 368;
					continue;
				case 235:
					num26 = 255u;
					num2 = 90;
					continue;
				case 236:
					array[19] = 108;
					num2 = 6;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 84;
					}
					continue;
				case 206:
					array[17] = (byte)num15;
					num2 = 119;
					continue;
				case 270:
					array[13] = 158;
					num2 = 323;
					continue;
				case 305:
					array2[6] = 108;
					num2 = 179;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 162;
					}
					continue;
				case 41:
					num4 += num18;
					num2 = 23;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 59;
					}
					continue;
				case 173:
					array[9] = (byte)num15;
					num2 = 234;
					continue;
				case 309:
					array[9] = 185;
					num2 = 183;
					continue;
				case 31:
					array[24] = 127;
					num2 = 258;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 145;
					}
					continue;
				case 246:
					num15 = 21 + 2;
					num2 = 12;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 136;
					}
					continue;
				case 29:
					array[25] = 57;
					num2 = 203;
					continue;
				case 295:
					array[5] = (byte)num15;
					num2 = 344;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 60;
					}
					continue;
				case 26:
					num16 = 254 - 84;
					num2 = 346;
					continue;
				case 179:
					array2[6] = 23;
					num2 = 0;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 0;
					}
					continue;
				case 356:
					array2[9] = 171;
					num2 = 51;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 194;
					}
					continue;
				case 99:
					num15 = 26 + 22;
					num2 = 45;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 50;
					}
					continue;
				case 3:
					num15 = 97 + 105;
					num = 173;
					break;
				case 265:
					num16 = 196 - 65;
					num2 = 4;
					continue;
				case 64:
					num16 = 17 + 70;
					num2 = 114;
					continue;
				case 247:
					dE4LVCZcQFV = R690rqLASskICwXqDs3s(XaybQILAefracribY8YH(memoryStream));
					num2 = 352;
					continue;
				case 194:
					num16 = 177 - 59;
					num2 = 261;
					continue;
				case 131:
					array[19] = (byte)num15;
					num2 = 319;
					continue;
				case 52:
					array2[4] = 87;
					num2 = 357;
					continue;
				case 158:
					num16 = 234 - 78;
					num2 = 228;
					continue;
				case 109:
					num35 = num28 % num30;
					num2 = 50;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 54;
					}
					continue;
				case 75:
					array2[4] = (byte)num16;
					num2 = 262;
					continue;
				case 291:
					array[6] = (byte)num15;
					num2 = 318;
					continue;
				case 360:
					memoryStream = new MemoryStream();
					num2 = 314;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 122;
					}
					continue;
				case 165:
					array4 = array3;
					num2 = 222;
					continue;
				case 118:
					array2[11] = 133;
					num2 = 294;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 306;
					}
					continue;
				case 98:
					num15 = 49 + 44;
					num2 = 154;
					continue;
				case 8:
					array[22] = (byte)num15;
					num2 = 218;
					continue;
				case 58:
					num15 = 180 - 60;
					num2 = 138;
					continue;
				case 384:
					array7 = array2;
					num2 = 385;
					continue;
				case 122:
					array[7] = (byte)num15;
					num2 = 395;
					continue;
				case 48:
					array[27] = (byte)num15;
					num2 = 66;
					continue;
				case 188:
					num15 = 203 - 67;
					num2 = 232;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 39;
					}
					continue;
				case 275:
					num15 = 202 - 67;
					num2 = 8;
					continue;
				case 17:
					array[0] = 202;
					num2 = 219;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 353;
					}
					continue;
				case 349:
					array[25] = (byte)num15;
					num2 = 132;
					continue;
				case 392:
					num16 = 172 - 57;
					num = 147;
					break;
				case 36:
					array2[7] = 143;
					num2 = 227;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 8;
					}
					continue;
				case 16:
					array[2] = 7;
					num2 = 329;
					continue;
				case 331:
					array2[12] = 204;
					num2 = 158;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 93;
					}
					continue;
				case 273:
					num15 = 206 - 68;
					num2 = 20;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 287;
					}
					continue;
				case 249:
					array[0] = (byte)num15;
					num2 = 17;
					continue;
				case 391:
					array2[1] = 126;
					num2 = 392;
					continue;
				case 288:
					num22 = array6.Length % 4;
					num2 = 308;
					continue;
				case 364:
					array[29] = 124;
					num2 = 365;
					continue;
				case 296:
					KeKXCcLAkUl4DJ94UeBP(c0q1XwLANSaT5eIXuLMZ(rFjo4ELVkSpcIZcFSLKW), 0L);
					num2 = 139;
					continue;
				case 365:
					num15 = 78 + 38;
					num2 = 358;
					continue;
				case 377:
					array2[4] = 138;
					num2 = 96;
					continue;
				case 287:
					array[18] = (byte)num15;
					num2 = 74;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 162;
					}
					continue;
				case 46:
					num15 = 243 - 81;
					num2 = 350;
					continue;
				case 145:
					array2[1] = (byte)num16;
					num2 = 153;
					continue;
				case 285:
					num28 = 0;
					num2 = 161;
					continue;
				case 372:
					array[28] = (byte)num15;
					num2 = 394;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 361;
					}
					continue;
				case 345:
					num32 = 0;
					num2 = 160;
					continue;
				case 332:
					array2[5] = 135;
					num2 = 201;
					continue;
				case 230:
					array2[11] = (byte)num16;
					num2 = 80;
					continue;
				case 13:
					num34++;
					num2 = 86;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 83;
					}
					continue;
				case 220:
					num34 = 0;
					num2 = 1;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 82;
					}
					continue;
				case 388:
					array2[0] = 154;
					num2 = 180;
					continue;
				case 136:
					array[30] = (byte)num15;
					num2 = 107;
					continue;
				case 71:
					num15 = 198 - 66;
					num2 = 23;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 3;
					}
					continue;
				case 271:
					array2[10] = 12;
					num2 = 57;
					continue;
				case 268:
					array[2] = 168;
					num2 = 99;
					continue;
				case 83:
					array5[num34] ^= array7[num34];
					num2 = 13;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 0;
					}
					continue;
				case 233:
					num16 = 17 + 69;
					num2 = 130;
					continue;
				case 240:
					array[4] = 45;
					num2 = 337;
					continue;
				case 163:
					num15 = 26 + 72;
					num2 = 34;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 42;
					}
					continue;
				case 146:
					array[0] = 52;
					num2 = 315;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 12;
					}
					continue;
				case 182:
					if (num22 > 0)
					{
						num2 = 348;
						continue;
					}
					goto case 117;
				case 76:
					array2[4] = (byte)num16;
					num2 = 108;
					continue;
				case 277:
					array2[8] = (byte)num16;
					num2 = 78;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 128;
					}
					continue;
				case 9:
					array2[14] = (byte)num16;
					num2 = 18;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 47;
					}
					continue;
				case 266:
					array6 = array8;
					num2 = 288;
					continue;
				case 279:
					array[31] = 96;
					num2 = 1;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 77;
					}
					continue;
				case 101:
					array[15] = (byte)num15;
					num2 = 376;
					continue;
				case 395:
					num15 = 40 + 29;
					num2 = 30;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 301;
					}
					continue;
				case 177:
					array[25] = 112;
					num2 = 29;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 25;
					}
					continue;
				case 198:
					num15 = 110 + 10;
					num2 = 1;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 341;
					}
					continue;
				case 307:
					array[21] = 140;
					num2 = 326;
					continue;
				case 329:
					array[3] = 95;
					num2 = 116;
					continue;
				case 374:
					num15 = 29 + 22;
					num2 = 389;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 154;
					}
					continue;
				case 54:
					num20 = num28 * 4;
					num2 = 19;
					continue;
				case 248:
					array2[1] = (byte)num16;
					num2 = 386;
					continue;
				case 108:
					array2[5] = 148;
					num2 = 367;
					continue;
				case 382:
					array[27] = (byte)num15;
					num2 = 213;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 144;
					}
					continue;
				case 19:
					num33 = (uint)(num35 * 4);
					num2 = 321;
					continue;
				case 160:
				case 231:
					if (num32 >= num22)
					{
						num2 = 150;
						if (hIcU8CLA4OflfaRaU8gJ() == null)
						{
							num2 = 208;
						}
						continue;
					}
					goto case 396;
				case 70:
					array[21] = 118;
					num2 = 307;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 152;
					}
					continue;
				case 328:
					array[12] = (byte)num15;
					num2 = 152;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 43;
					}
					continue;
				case 290:
					num16 = 204 - 68;
					num2 = 124;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 215;
					}
					continue;
				case 387:
					num17 = 0u;
					num2 = 182;
					continue;
				case 175:
					num15 = 198 - 66;
					num2 = 57;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 363;
					}
					continue;
				case 187:
					array2[3] = 87;
					num2 = 64;
					continue;
				case 375:
					num15 = 250 - 83;
					num2 = 178;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 174;
					}
					continue;
				case 242:
					array[16] = 162;
					num2 = 127;
					continue;
				case 338:
					array2[15] = (byte)num16;
					num2 = 340;
					continue;
				case 38:
					num16 = 167 - 55;
					num2 = 145;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 61;
					}
					continue;
				case 168:
					array[28] = 120;
					num2 = 339;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 364;
					}
					continue;
				case 396:
					if (num32 > 0)
					{
						num = 28;
						break;
					}
					goto case 189;
				case 32:
					array5 = array;
					num2 = 197;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 294;
					}
					continue;
				case 144:
					array[23] = 194;
					num2 = 221;
					continue;
				case 202:
					num15 = 96 + 74;
					num = 56;
					break;
				case 27:
					array[20] = 83;
					num2 = 198;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 100;
					}
					continue;
				case 85:
					num17 |= array6[array6.Length - (1 + num19)];
					num2 = 181;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 184;
					}
					continue;
				case 298:
					array2[10] = 161;
					num = 271;
					break;
				case 363:
					array[17] = (byte)num15;
					num2 = 45;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 327;
					}
					continue;
				case 116:
					num15 = 98 + 3;
					num2 = 151;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 149;
					}
					continue;
				case 223:
					xZrLVrUlU6B = true;
					num2 = 320;
					continue;
				case 63:
					array2[3] = 78;
					num2 = 187;
					continue;
				case 324:
					num15 = 81 + 47;
					num2 = 53;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 14;
					}
					continue;
				case 353:
					num15 = 64 + 45;
					num2 = 219;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 46;
					}
					continue;
				case 316:
					num15 = 238 - 79;
					num2 = 30;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 397;
					}
					continue;
				case 12:
					num16 = 109 + 123;
					num2 = 248;
					continue;
				case 222:
					if (num29 == 0)
					{
						num2 = 103;
						continue;
					}
					goto case 343;
				case 156:
					array[28] = 110;
					num2 = 168;
					continue;
				case 74:
					if (num28 == num31 - 1)
					{
						num2 = 170;
						if (hIcU8CLA4OflfaRaU8gJ() != null)
						{
							num2 = 163;
						}
						continue;
					}
					goto case 284;
				case 35:
					array2[11] = 126;
					num2 = 260;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 44;
					}
					continue;
				case 203:
					array[25] = 141;
					num2 = 91;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 56;
					}
					continue;
				case 212:
					array3[num20 + 3] = (byte)((num21 & 0xFF000000u) >> 24);
					num2 = 121;
					continue;
				case 299:
					num15 = 34 + 59;
					num2 = 9;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 302;
					}
					continue;
				case 284:
					num33 = (uint)num20;
					num2 = 88;
					continue;
				case 204:
					array[11] = (byte)num15;
					num2 = 176;
					continue;
				case 91:
					num15 = 127 + 121;
					num = 349;
					break;
				case 72:
					array[11] = (byte)num15;
					num2 = 8;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 21;
					}
					continue;
				case 45:
					array[14] = 135;
					num2 = 172;
					continue;
				case 88:
					num4 += num18;
					num2 = 100;
					continue;
				case 320:
					return;
				case 366:
					num16 = 126 - 42;
					num2 = 339;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 135;
					}
					continue;
				case 337:
					array[4] = 251;
					num2 = 202;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 202;
					}
					continue;
				case 205:
					num15 = 36 + 107;
					num2 = 181;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 90;
					}
					continue;
				case 162:
					array[18] = 138;
					num2 = 205;
					continue;
				case 355:
					array2[0] = (byte)num16;
					num2 = 356;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 388;
					}
					continue;
				case 367:
					num16 = 104 + 48;
					num = 225;
					break;
				case 126:
					array2[9] = 151;
					num2 = 280;
					continue;
				case 174:
					array[17] = (byte)num15;
					num2 = 375;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 223;
					}
					continue;
				case 333:
					array2[9] = (byte)num16;
					num2 = 126;
					continue;
				case 159:
					array2[6] = (byte)num16;
					num2 = 305;
					continue;
				case 376:
					num15 = 157 - 52;
					num2 = 378;
					continue;
				case 66:
					num15 = 4 + 7;
					num2 = 382;
					continue;
				case 342:
					array2[13] = 186;
					num2 = 20;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 10;
					}
					continue;
				case 303:
					array[6] = 162;
					num2 = 1;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 0;
					}
					continue;
				case 82:
				case 86:
					if (num34 >= array7.Length)
					{
						num2 = 266;
						continue;
					}
					goto case 83;
				case 228:
					array2[13] = (byte)num16;
					num2 = 317;
					continue;
				case 245:
					num15 = 101 + 115;
					num2 = 286;
					continue;
				case 239:
					array[4] = (byte)num15;
					num2 = 293;
					continue;
				case 359:
					num15 = 121 + 77;
					num2 = 393;
					continue;
				case 114:
					array2[3] = (byte)num16;
					num2 = 49;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 95;
					}
					continue;
				case 347:
					num15 = 33 + 84;
					num2 = 278;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 233;
					}
					continue;
				case 124:
					num15 = 185 - 61;
					num2 = 204;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 65;
					}
					continue;
				case 171:
					array[10] = 31;
					num = 7;
					break;
				case 215:
					array2[8] = (byte)num16;
					num2 = 115;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 57;
					}
					continue;
				case 185:
					num16 = 5 + 59;
					num2 = 110;
					continue;
				case 253:
					num16 = 223 - 74;
					num2 = 338;
					continue;
				case 47:
					num16 = 71 + 108;
					num2 = 143;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 311;
					}
					continue;
				case 189:
					array3[num20 + num32] = (byte)((num25 & num26) >> num27);
					num = 155;
					break;
				case 149:
					num21 = num4 ^ num17;
					num2 = 330;
					continue;
				case 323:
					array[13] = 97;
					num2 = 45;
					continue;
				case 15:
					array[8] = 10;
					num2 = 14;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 14;
					}
					continue;
				case 344:
					array[5] = 85;
					num2 = 299;
					continue;
				case 28:
					num26 <<= 8;
					num2 = 274;
					continue;
				case 210:
					array[7] = 140;
					num2 = 373;
					continue;
				case 276:
					array[13] = 233;
					num2 = 270;
					continue;
				case 153:
					num16 = 147 - 49;
					num2 = 2;
					continue;
				case 34:
					array[19] = (byte)num15;
					num2 = 31;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 60;
					}
					continue;
				case 398:
					array2[12] = (byte)num16;
					num2 = 26;
					continue;
				case 321:
					num18 = (uint)((array5[num33 + 3] << 24) | (array5[num33 + 2] << 16) | (array5[num33 + 1] << 8) | array5[num33]);
					num2 = 235;
					continue;
				case 262:
					array2[4] = 88;
					num2 = 377;
					continue;
				case 260:
					array2[12] = 150;
					num2 = 265;
					continue;
				case 5:
					array[17] = (byte)num15;
					num2 = 129;
					continue;
				case 44:
					num15 = 107 + 42;
					num2 = 133;
					continue;
				case 286:
					array[0] = (byte)num15;
					num2 = 146;
					continue;
				case 282:
					array2[0] = (byte)num16;
					num2 = 256;
					continue;
				case 21:
					array[11] = 88;
					num2 = 124;
					continue;
				case 237:
					array[23] = (byte)num15;
					num2 = 30;
					continue;
				case 181:
					array[18] = (byte)num15;
					num2 = 374;
					continue;
				case 161:
				case 192:
					if (num28 >= num31)
					{
						num2 = 165;
						continue;
					}
					goto case 109;
				case 23:
					array[2] = (byte)num15;
					num2 = 4;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 16;
					}
					continue;
				case 57:
					num16 = 79 + 63;
					num2 = 230;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 211;
					}
					continue;
				case 193:
					array2[14] = (byte)num16;
					num2 = 185;
					continue;
				case 69:
					array[27] = 163;
					num2 = 115;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 226;
					}
					continue;
				case 78:
					array3 = new byte[array6.Length];
					num2 = 89;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 34;
					}
					continue;
				case 25:
					array[12] = (byte)num15;
					num2 = 46;
					continue;
				case 312:
					array[4] = (byte)num15;
					num2 = 1;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 6;
					}
					continue;
				case 370:
					array = new byte[32];
					num2 = 322;
					continue;
				case 348:
					num31++;
					num2 = 117;
					continue;
				case 152:
					array[13] = 115;
					num2 = 276;
					continue;
				case 6:
					array[4] = 162;
					num2 = 240;
					continue;
				case 130:
					array2[11] = (byte)num16;
					num2 = 118;
					continue;
				case 209:
					array2[7] = (byte)num16;
					num2 = 252;
					continue;
				case 238:
					array2[10] = 77;
					num2 = 366;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 362;
					}
					continue;
				case 128:
					array2[8] = 4;
					num2 = 356;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 331;
					}
					continue;
				case 274:
					num27 += 8;
					num2 = 189;
					continue;
				case 234:
					array[9] = 133;
					num2 = 163;
					continue;
				case 390:
					array[1] = 169;
					num2 = 359;
					continue;
				case 301:
					array[7] = (byte)num15;
					num2 = 157;
					continue;
				case 77:
					array[31] = 123;
					num2 = 32;
					continue;
				case 73:
					array[22] = (byte)num15;
					num2 = 275;
					continue;
				case 167:
					if (xZrLVrUlU6B)
					{
						num2 = 166;
						continue;
					}
					goto case 272;
				case 318:
					array[7] = 153;
					num2 = 210;
					continue;
				case 89:
					num30 = array5.Length / 4;
					num = 283;
					break;
				case 2:
					array2[1] = (byte)num16;
					num2 = 391;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 174;
					}
					continue;
				case 61:
					array2[14] = 61;
					num = 257;
					break;
				case 18:
					array[0] = (byte)num15;
					num2 = 245;
					continue;
				case 334:
					if (num19 > 0)
					{
						num2 = 292;
						continue;
					}
					goto case 85;
				case 143:
					array[14] = 48;
					num2 = 113;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 55;
					}
					continue;
				case 394:
					array[28] = 111;
					num2 = 156;
					continue;
				case 261:
					array2[9] = (byte)num16;
					num2 = 40;
					continue;
				case 294:
					array2 = new byte[16];
					num2 = 33;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 135;
					}
					continue;
				case 385:
					num29 = 1;
					num2 = 83;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 220;
					}
					continue;
				case 138:
					array[9] = (byte)num15;
					num2 = 309;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 266;
					}
					continue;
				case 135:
					num16 = 126 - 42;
					num2 = 355;
					continue;
				case 65:
					num15 = 210 - 121;
					num2 = 328;
					continue;
				case 278:
					array[26] = (byte)num15;
					num2 = 259;
					continue;
				case 241:
					num15 = 62 + 10;
					num2 = 34;
					continue;
				case 183:
					array[10] = 156;
					num2 = 171;
					continue;
				case 389:
					array[19] = (byte)num15;
					num2 = 95;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 111;
					}
					continue;
				case 362:
					array[2] = 86;
					num2 = 243;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 0;
					}
					continue;
				case 250:
					num15 = 59 + 119;
					num2 = 101;
					continue;
				case 90:
					num27 = 0;
					num2 = 74;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 51;
					}
					continue;
				case 257:
					num16 = 212 - 70;
					num2 = 371;
					continue;
				case 315:
					num15 = 167 - 55;
					num2 = 255;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 165;
					}
					continue;
				case 107:
					array[30] = 116;
					num2 = 369;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 168;
					}
					continue;
				case 211:
					num15 = 46 + 101;
					num = 372;
					break;
				case 221:
					num15 = 17 + 113;
					num2 = 237;
					continue;
				case 214:
					num17 = 0u;
					num2 = 41;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 28;
					}
					continue;
				case 92:
					array[17] = (byte)num15;
					num2 = 175;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 29;
					}
					continue;
				case 111:
					array[19] = 156;
					num2 = 241;
					continue;
				case 157:
					num15 = 107 + 48;
					num2 = 199;
					continue;
				case 176:
					num15 = 102 + 74;
					num2 = 380;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 30;
					}
					continue;
				case 357:
					num16 = 6 + 48;
					num2 = 75;
					continue;
				case 227:
					array2[8] = 201;
					num2 = 21;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 51;
					}
					continue;
				case 252:
					array2[7] = 112;
					num = 36;
					break;
				case 112:
					num15 = 1 + 114;
					num = 73;
					break;
				case 93:
					num25 = num4 ^ num17;
					num2 = 345;
					continue;
				case 169:
					array[27] = (byte)num15;
					num2 = 7;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 37;
					}
					continue;
				case 22:
				case 94:
					dE4LVCZcQFV = R690rqLASskICwXqDs3s(h0uaiXLAXWKBu1eaveNi(array4, 0u));
					num2 = 336;
					continue;
				case 42:
					array[9] = (byte)num15;
					num2 = 106;
					continue;
				case 119:
					num15 = 179 - 59;
					num2 = 79;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 92;
					}
					continue;
				case 369:
					num15 = 113 + 50;
					num2 = 67;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 224;
					}
					continue;
				case 113:
					array[15] = 64;
					num2 = 81;
					continue;
				case 133:
					array[8] = (byte)num15;
					num2 = 346;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 354;
					}
					continue;
				case 256:
					array2[0] = 50;
					num2 = 38;
					if (!g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 8;
					}
					continue;
				case 55:
					try
					{
						XADS66LAxn0SJ8RaB5A5(deflateStream, memoryStream);
						int num23 = 0;
						if (hIcU8CLA4OflfaRaU8gJ() == null)
						{
							num23 = 0;
						}
						switch (num23)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							int num24 = 0;
							if (!g8i7XALAlJUH7Q6ybbCt())
							{
								num24 = 0;
							}
							while (true)
							{
								switch (num24)
								{
								default:
									A2l1wPLALkXcLu00A6io(deflateStream);
									num24 = 1;
									if (!g8i7XALAlJUH7Q6ybbCt())
									{
										num24 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 247;
				case 147:
					array2[1] = (byte)num16;
					num2 = 67;
					continue;
				case 95:
					array2[3] = 3;
					num2 = 120;
					continue;
				case 134:
				case 361:
					if (num19 >= num22)
					{
						num2 = 229;
						continue;
					}
					goto case 334;
				case 164:
					array[12] = 205;
					num2 = 254;
					continue;
				case 258:
					array[24] = 99;
					num = 197;
					break;
				case 326:
					array[21] = 39;
					num2 = 38;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 98;
					}
					continue;
				case 267:
					array[15] = 122;
					num2 = 250;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 84;
					}
					continue;
				case 280:
					num16 = 97 + 108;
					num2 = 5;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 11;
					}
					continue;
				case 186:
					array3[num20 + 2] = (byte)((num21 & 0xFF0000) >> 16);
					num2 = 199;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 212;
					}
					continue;
				case 184:
					num19++;
					num2 = 361;
					continue;
				case 80:
					array2[11] = 219;
					num2 = 70;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 233;
					}
					continue;
				case 313:
					array2[11] = (byte)num16;
					num2 = 35;
					continue;
				case 11:
					array2[9] = (byte)num16;
					num2 = 116;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 238;
					}
					continue;
				case 104:
					num16 = 87 + 5;
					num2 = 159;
					continue;
				case 10:
					array2[5] = (byte)num16;
					num2 = 22;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 102;
					}
					continue;
				case 39:
					array[11] = 133;
					num = 300;
					break;
				case 125:
					array[8] = 141;
					num2 = 15;
					continue;
				case 110:
					array2[15] = (byte)num16;
					num2 = 253;
					continue;
				case 340:
					array2[15] = 224;
					num2 = 384;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 89;
					}
					continue;
				case 115:
					num16 = 248 - 82;
					num2 = 277;
					continue;
				case 56:
					array[5] = (byte)num15;
					num2 = 281;
					continue;
				case 59:
					num19 = 0;
					num2 = 134;
					continue;
				case 254:
					num15 = 252 - 84;
					num2 = 25;
					continue;
				case 151:
					array[3] = (byte)num15;
					num2 = 50;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 207;
					}
					continue;
				case 62:
					num15 = 82 + 7;
					num2 = 169;
					continue;
				case 79:
					num18 = 0u;
					num2 = 387;
					continue;
				case 213:
					num15 = 31 + 20;
					num2 = 244;
					continue;
				case 351:
					array2[4] = (byte)num16;
					num2 = 52;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 19;
					}
					continue;
				case 127:
					array[16] = 166;
					num2 = 399;
					continue;
				case 196:
					num16 = 133 - 44;
					num2 = 190;
					continue;
				case 255:
					array[0] = (byte)num15;
					num2 = 200;
					continue;
				case 30:
					num15 = 105 + 106;
					num2 = 97;
					continue;
				case 154:
					array[22] = (byte)num15;
					num2 = 112;
					continue;
				case 172:
					array[14] = 161;
					num = 143;
					break;
				case 97:
					array[23] = (byte)num15;
					num = 31;
					break;
				case 50:
					array[2] = (byte)num15;
					num2 = 9;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 71;
					}
					continue;
				case 96:
					num16 = 166 - 75;
					num2 = 76;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 43;
					}
					continue;
				case 191:
					array[20] = 136;
					num2 = 27;
					continue;
				case 302:
					array[6] = (byte)num15;
					num2 = 303;
					continue;
				case 87:
					array2[2] = (byte)num16;
					num2 = 63;
					continue;
				case 232:
					array[30] = (byte)num15;
					num2 = 246;
					continue;
				case 292:
					num17 <<= 8;
					num2 = 85;
					continue;
				case 105:
					array[22] = (byte)num15;
					num2 = 32;
					if (hIcU8CLA4OflfaRaU8gJ() == null)
					{
						num2 = 324;
					}
					continue;
				case 68:
					array[26] = (byte)num15;
					num2 = 316;
					if (hIcU8CLA4OflfaRaU8gJ() != null)
					{
						num2 = 83;
					}
					continue;
				case 199:
					array[7] = (byte)num15;
					num2 = 44;
					continue;
				case 243:
					array[2] = 153;
					num2 = 268;
					continue;
				case 102:
					array2[5] = 168;
					num2 = 40;
					if (g8i7XALAlJUH7Q6ybbCt())
					{
						num2 = 379;
					}
					continue;
				case 339:
					array2[10] = (byte)num16;
					num2 = 298;
					continue;
				case 137:
				case 142:
				case 336:
					RdZLVVuoOWH = (string[])IxWAplLAcgZoh4nZ7VT9((Assembly)dE4LVCZcQFV);
					num2 = 223;
					continue;
				case 24:
				case 229:
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
					num2 = 141;
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] YlrLVyK45tL(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554819)).Assembly)
		{
			if (!xZrLVrUlU6B)
			{
				xjFLVT2I3fc();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)dE4LVCZcQFV).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly hb0LVZP0RnK(object P_0, ResolveEventArgs P_1)
	{
		if (!xZrLVrUlU6B)
		{
			xjFLVT2I3fc();
		}
		string name = P_1.Name;
		for (int i = 0; i < RdZLVVuoOWH.Length; i++)
		{
			if (RdZLVVuoOWH[i] == name)
			{
				return (Assembly)dE4LVCZcQFV;
			}
		}
		return null;
	}

	public ObwCXyLVWLAqZaA6biRs()
	{
		AppDomain.CurrentDomain.ResourceResolve += hb0LVZP0RnK;
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!cDjLVKEZNFg)
		{
			cDjLVKEZNFg = true;
			new ObwCXyLVWLAqZaA6biRs();
		}
	}

	internal static Type wqs4ZRLADU03CS4mwVxO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object P9lm8rLAb8VAkNxR4d59(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object c0q1XwLANSaT5eIXuLMZ(object P_0)
	{
		return ((yVbruBLyqe9BOsO9Yb5E.rFjo4ELVkSpcIZcFSLKW)P_0).m9OIO8Q0EK();
	}

	internal static void KeKXCcLAkUl4DJ94UeBP(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long Dmuki2LA1i61beAQND76(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object hgOkX4LA572ji2xHamit(object P_0, int P_1)
	{
		return ((yVbruBLyqe9BOsO9Yb5E.rFjo4ELVkSpcIZcFSLKW)P_0).GfnLV1rmaDJ(P_1);
	}

	internal static object R690rqLASskICwXqDs3s(object P_0)
	{
		return admJtILVhewRvZg7a0jD.FgZLVpci4vB((byte[])P_0);
	}

	internal static void XADS66LAxn0SJ8RaB5A5(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void A2l1wPLALkXcLu00A6io(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object XaybQILAefracribY8YH(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void fqJGjRLAsLNuwwWxqE1Q(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object h0uaiXLAXWKBu1eaveNi(object P_0, uint P_1)
	{
		return admJtILVhewRvZg7a0jD.ID5LVuG6iH7((byte[])P_0, P_1);
	}

	internal static object IxWAplLAcgZoh4nZ7VT9(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool g8i7XALAlJUH7Q6ybbCt()
	{
		return (object)null == null;
	}

	internal static object hIcU8CLA4OflfaRaU8gJ()
	{
		return null;
	}
}
