using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace k1HkEmlS1dtfyOJUb1At;

internal class aMVIXxlSkgpiTGaSyVJP
{
	private enum qZr8aglSjeA1HCjGG9QY
	{

	}

	internal class cfnYGBlSEMSnVLqTlXBi
	{
		private unsafe static uint gxUlSQ9mp6B(void* P_0, uint P_1)
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

		private unsafe static bool iFolSd4TvEn(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void N7slSgYxk1G(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void MkAlSRqV0r7(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void bUylS6ZN3eY(byte* P_0, byte* P_1, uint P_2)
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
				MkAlSRqV0r7(P_0, P_1, P_2);
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

		private unsafe static uint HpslSM5WvHb(byte[] P_0, uint P_1, qZr8aglSjeA1HCjGG9QY P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint iWmlSOFCePt(byte[] P_0, uint P_1)
		{
			return HpslSM5WvHb(P_0, P_1, (qZr8aglSjeA1HCjGG9QY)3);
		}

		private unsafe static uint UbJlSqLjoVd(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + gxUlSQ9mp6B(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (gxUlSQ9mp6B(ptr6 + 4, 4u) != 1)
					{
						MkAlSRqV0r7(ptr2, ptr3 + num, gxUlSQ9mp6B(ptr6 + 3, 4u));
						return gxUlSQ9mp6B(ptr6 + 3, 4u);
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
							num2 = gxUlSQ9mp6B(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = gxUlSQ9mp6B(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								bUylS6ZN3eY(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								bUylS6ZN3eY(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								bUylS6ZN3eY(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								bUylS6ZN3eY(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								bUylS6ZN3eY(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								N7slSgYxk1G(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							bUylS6ZN3eY(ptr5, ptr4, 4u);
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

		internal static object BgclSI6tZ4x(byte[] P_0)
		{
			return S983DiNZ4ppXNb8LeNAh(Type.GetTypeFromHandle(oYBDQ0NZlv1HeSd55mUR(16777352)).GetMethod(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D3590B0).Trim(), new Type[1] { typeof(byte[]) }), null, new object[1] { P_0 });
		}

		public static byte[] WKElSWdh3M8(byte[] P_0, uint P_1)
		{
			uint num = iWmlSOFCePt(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				UbJlSqLjoVd(P_0, P_1, array);
			}
			return array;
		}

		internal static RuntimeTypeHandle oYBDQ0NZlv1HeSd55mUR(int token)
		{
			return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
		}

		internal static object S983DiNZ4ppXNb8LeNAh(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}
	}

	private static string[] bKslSepk46o = new string[0];

	private static object FlelSsjyggk = null;

	private static bool EsnlSXB4Z7a = false;

	private static bool WoHlScWOAYW = false;

	private static void b52lSSNbURk()
	{
		int num = 61;
		byte[] array = default(byte[]);
		int num15 = default(int);
		int num18 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		uint num16 = default(uint);
		int num27 = default(int);
		byte[] array2 = default(byte[]);
		int num17 = default(int);
		int num22 = default(int);
		byte[] array7 = default(byte[]);
		uint num29 = default(uint);
		int num20 = default(int);
		stmj4Ul1bF7178khnjLy.F5CPUNl5pxqM6Zmk7dMj f5CPUNl5pxqM6Zmk7dMj = default(stmj4Ul1bF7178khnjLy.F5CPUNl5pxqM6Zmk7dMj);
		int num25 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num36 = default(int);
		int num24 = default(int);
		uint num35 = default(uint);
		uint num19 = default(uint);
		int num21 = default(int);
		uint num31 = default(uint);
		int num32 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		int num26 = default(int);
		uint num28 = default(uint);
		byte[] array8 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num23 = default(int);
		int num30 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 182:
					array[9] = (byte)num15;
					num2 = 254;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 110;
					}
					continue;
				case 366:
					array[17] = 139;
					num2 = 114;
					continue;
				case 223:
					num18 = 120 - 85;
					num2 = 347;
					continue;
				case 284:
					memoryStream = new MemoryStream();
					num2 = 42;
					continue;
				case 371:
					num15 = 47 + 90;
					num2 = 208;
					continue;
				case 134:
					num16 = (uint)num27;
					num2 = 107;
					continue;
				case 298:
					num15 = 116 - 87;
					num2 = 171;
					continue;
				case 87:
					array2[9] = 181;
					num2 = 242;
					continue;
				case 54:
					num17 = 131 + 63;
					num2 = 112;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 40;
					}
					continue;
				case 333:
					if (num22 > 0)
					{
						num2 = 203;
						continue;
					}
					goto case 319;
				case 349:
					array[18] = 74;
					num2 = 321;
					continue;
				case 158:
					num18 = 67 + 52;
					num2 = 237;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 136;
					}
					continue;
				case 202:
					array7[num27 + 2] = (byte)((num29 & 0xFF0000) >> 16);
					num2 = 266;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 389;
					}
					continue;
				case 328:
					num20 = 0;
					num2 = 109;
					continue;
				case 163:
					array[7] = 210;
					num2 = 153;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 263;
					}
					continue;
				case 72:
					array2[15] = 237;
					num2 = 337;
					continue;
				case 241:
					array[21] = 169;
					num2 = 169;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 63;
					}
					continue;
				case 89:
					array[21] = (byte)num15;
					num2 = 241;
					continue;
				case 252:
					array[31] = (byte)num17;
					num2 = 248;
					continue;
				case 162:
					array[4] = 42;
					num2 = 300;
					continue;
				case 214:
					array[0] = (byte)num15;
					num = 283;
					break;
				case 355:
					vuwAUilO177wIyBpHh5J(CS0dRMlOkHyWq3qVC09t(f5CPUNl5pxqM6Zmk7dMj), 0L);
					num2 = 340;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 27;
					}
					continue;
				case 272:
					num18 = 53 + 24;
					num2 = 35;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 35;
					}
					continue;
				case 164:
					num17 = 56 - 16;
					num2 = 161;
					continue;
				case 288:
					array[26] = (byte)num17;
					num2 = 258;
					continue;
				case 165:
					num25 = array5.Length / 4;
					num = 204;
					break;
				case 148:
					num17 = 147 - 49;
					num2 = 0;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 0;
					}
					continue;
				case 194:
					num15 = 127 - 42;
					num2 = 150;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 38;
					}
					continue;
				case 330:
					array[7] = 216;
					num2 = 100;
					continue;
				case 231:
					array[28] = (byte)num17;
					num2 = 399;
					continue;
				case 398:
					array[5] = 135;
					num2 = 343;
					continue;
				case 237:
					array2[13] = (byte)num18;
					num2 = 329;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 179;
					}
					continue;
				case 62:
					FlelSsjyggk = EfrvaYlOxDg5Bg7L3cVW(array6);
					num2 = 401;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 201;
					}
					continue;
				case 135:
					num16 = (uint)(num36 * 4);
					num2 = 317;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 57;
					}
					continue;
				case 2:
					array2[9] = (byte)num18;
					num2 = 170;
					continue;
				case 370:
					num15 = 180 - 60;
					num2 = 185;
					continue;
				case 222:
					array2[0] = 181;
					num = 375;
					break;
				case 340:
					array6 = new byte[0];
					num2 = 3;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 51;
					}
					continue;
				case 11:
					array[7] = (byte)num15;
					num2 = 372;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 254;
					}
					continue;
				case 58:
					return;
				case 60:
					return;
				case 331:
					array2[6] = 124;
					num2 = 123;
					continue;
				case 122:
					if (num24 > 0)
					{
						num = 234;
						break;
					}
					goto case 33;
				case 26:
					num35 = num4 ^ num19;
					num2 = 256;
					continue;
				case 316:
					array2[0] = 166;
					num2 = 101;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 250;
					}
					continue;
				case 20:
					array[6] = (byte)num15;
					num2 = 179;
					continue;
				case 312:
					array[10] = (byte)num17;
					num2 = 116;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 142;
					}
					continue;
				case 66:
					array7[num27 + num21] = (byte)((num35 & num31) >> num32);
					num2 = 91;
					continue;
				case 175:
					num18 = 228 - 76;
					num2 = 12;
					continue;
				case 131:
				case 144:
					FlelSsjyggk = EfrvaYlOxDg5Bg7L3cVW(E90tiZlOchab8eVZ8JgB(array6, 0u));
					num2 = 126;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 64;
					}
					continue;
				case 368:
					num18 = 143 - 47;
					num2 = 14;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 28;
					}
					continue;
				case 24:
					array[2] = (byte)num15;
					num2 = 178;
					continue;
				case 315:
					num18 = 146 - 48;
					num2 = 178;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 336;
					}
					continue;
				case 193:
					num18 = 181 - 60;
					num2 = 2;
					continue;
				case 119:
					array[13] = 100;
					num2 = 137;
					continue;
				case 353:
					try
					{
						s2VhIKlOLPlny3Zp9b5E(deflateStream, memoryStream);
						int num33 = 0;
						if (WXqhsslO4LXJOodQQQf6())
						{
							num33 = 0;
						}
						switch (num33)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num34;
						if (deflateStream == null)
						{
							num34 = 2;
							goto IL_0d30;
						}
						goto IL_0d65;
						IL_0d65:
						M9fcU5lOeg3ZRPxp6DZo(deflateStream);
						num34 = 0;
						if (feFCDPlOD7wyK1Om4EsB() != null)
						{
							num34 = 0;
						}
						goto IL_0d30;
						IL_0d30:
						switch (num34)
						{
						default:
							goto end_IL_0d1b;
						case 2:
							goto end_IL_0d1b;
						case 1:
							break;
						case 0:
							goto end_IL_0d1b;
						}
						goto IL_0d65;
						end_IL_0d1b:;
					}
					goto case 229;
				case 44:
					num29 = num4 ^ num19;
					num2 = 153;
					continue;
				case 18:
					array[25] = 205;
					num2 = 168;
					continue;
				case 75:
					array[10] = (byte)num17;
					num2 = 282;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 76;
					}
					continue;
				case 172:
					array2[14] = 150;
					num2 = 78;
					continue;
				case 384:
					num15 = 56 + 123;
					num2 = 18;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 20;
					}
					continue;
				case 154:
					array[12] = (byte)num17;
					num2 = 338;
					continue;
				case 373:
					num17 = 50 + 119;
					num2 = 277;
					continue;
				case 27:
					array2[8] = 157;
					num2 = 70;
					continue;
				case 37:
					num18 = 251 - 83;
					num2 = 3;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 108;
					}
					continue;
				case 92:
					array[19] = 45;
					num2 = 236;
					continue;
				case 358:
					array2[11] = 85;
					num2 = 76;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 128;
					}
					continue;
				case 364:
					array[2] = (byte)num15;
					num2 = 212;
					continue;
				case 385:
					array[8] = (byte)num15;
					num2 = 387;
					continue;
				case 156:
					num15 = 221 - 73;
					num = 271;
					break;
				case 341:
					array[29] = (byte)num17;
					num2 = 346;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 343;
					}
					continue;
				case 174:
					array2[3] = (byte)num18;
					num2 = 59;
					continue;
				case 258:
					array[27] = 154;
					num2 = 156;
					continue;
				case 33:
					num19 |= array5[array5.Length - (1 + num24)];
					num2 = 95;
					continue;
				case 50:
					num17 = 230 - 76;
					num = 98;
					break;
				case 35:
					array2[12] = (byte)num18;
					num2 = 211;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 225;
					}
					continue;
				case 91:
					num21++;
					num2 = 7;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 239;
					}
					continue;
				case 380:
					array[0] = (byte)num17;
					num = 286;
					break;
				case 192:
					array[13] = (byte)num15;
					num2 = 219;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 60;
					}
					continue;
				case 212:
					num15 = 39 - 11;
					num = 24;
					break;
				case 146:
					array[17] = (byte)num15;
					num2 = 366;
					continue;
				case 318:
					array2[13] = (byte)num18;
					num2 = 158;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 29;
					}
					continue;
				case 297:
					num18 = 73 + 112;
					num2 = 323;
					continue;
				case 209:
					array[30] = 96;
					num2 = 379;
					continue;
				case 263:
					array[7] = 80;
					num2 = 330;
					continue;
				case 190:
					array[15] = 118;
					num2 = 303;
					continue;
				case 213:
					array[1] = (byte)num17;
					num = 38;
					break;
				case 12:
					array2[15] = (byte)num18;
					num2 = 72;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 36;
					}
					continue;
				case 289:
					array2[15] = (byte)num18;
					num2 = 175;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 112;
					}
					continue;
				case 320:
					array[1] = 94;
					num2 = 292;
					continue;
				case 303:
					array[15] = 242;
					num2 = 56;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 51;
					}
					continue;
				case 187:
					array[20] = 149;
					num2 = 363;
					continue;
				case 65:
					if (num26 == num25 - 1)
					{
						num2 = 80;
						continue;
					}
					goto case 134;
				case 47:
					array2[10] = (byte)num18;
					num2 = 124;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 79;
					}
					continue;
				case 321:
					num15 = 52 + 73;
					num2 = 295;
					continue;
				case 101:
					array[17] = (byte)num15;
					num2 = 371;
					continue;
				case 113:
					array[14] = (byte)num17;
					num2 = 29;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 373;
					}
					continue;
				case 266:
					array = new byte[32];
					num2 = 285;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 67;
					}
					continue;
				case 339:
					num15 = 88 + 91;
					num2 = 89;
					continue;
				case 67:
					num18 = 113 - 22;
					num2 = 383;
					continue;
				case 350:
					array2[8] = 135;
					num2 = 308;
					continue;
				case 307:
					num18 = 225 - 75;
					num2 = 128;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 198;
					}
					continue;
				case 46:
				case 239:
					if (num21 >= num22)
					{
						num2 = 138;
						continue;
					}
					goto case 205;
				case 143:
					num18 = 174 - 58;
					num2 = 140;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 87;
					}
					continue;
				case 68:
					array2[5] = 199;
					num2 = 143;
					continue;
				case 64:
					array[16] = 140;
					num2 = 69;
					continue;
				case 111:
					num15 = 118 + 17;
					num = 302;
					break;
				case 3:
					EsnlSXB4Z7a = true;
					num2 = 58;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 29;
					}
					continue;
				case 217:
					array2[3] = (byte)num18;
					num2 = 4;
					continue;
				case 45:
					array[20] = (byte)num17;
					num2 = 111;
					continue;
				case 296:
					num17 = 201 - 67;
					num2 = 253;
					continue;
				case 63:
					array[18] = 133;
					num2 = 352;
					continue;
				case 76:
					array[11] = (byte)num15;
					num2 = 393;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 154;
					}
					continue;
				case 399:
					array[28] = 162;
					num2 = 370;
					continue;
				case 80:
					if (num22 > 0)
					{
						num2 = 344;
						if (!WXqhsslO4LXJOodQQQf6())
						{
							num2 = 313;
						}
						continue;
					}
					goto case 134;
				case 9:
					num15 = 144 - 48;
					num2 = 76;
					continue;
				case 127:
					array2[11] = 138;
					num2 = 358;
					continue;
				case 244:
					num15 = 192 + 50;
					num2 = 144;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 214;
					}
					continue;
				case 232:
					array6 = array7;
					num2 = 392;
					continue;
				case 184:
					array[14] = 76;
					num2 = 74;
					continue;
				case 95:
					num24++;
					num2 = 0;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 7;
					}
					continue;
				case 8:
					array[28] = 216;
					num = 251;
					break;
				case 150:
					array[9] = (byte)num15;
					num2 = 103;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 22;
					}
					continue;
				case 247:
					array[31] = 103;
					num2 = 148;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 151;
					}
					continue;
				case 25:
					array[9] = 104;
					num2 = 386;
					continue;
				case 291:
					array[3] = 94;
					num2 = 226;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 156;
					}
					continue;
				case 278:
					num17 = 181 - 67;
					num2 = 255;
					continue;
				case 14:
					num4 += num28;
					num2 = 230;
					continue;
				case 262:
					num18 = 113 + 89;
					num2 = 31;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 29;
					}
					continue;
				case 22:
					array[24] = (byte)num15;
					num2 = 39;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 33;
					}
					continue;
				case 90:
					num15 = 211 - 70;
					num = 240;
					break;
				case 335:
					array[6] = 71;
					num2 = 17;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 384;
					}
					continue;
				case 332:
					num17 = 171 - 57;
					num2 = 100;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 231;
					}
					continue;
				case 326:
					num17 = 30 + 26;
					num2 = 45;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 5;
					}
					continue;
				case 57:
					array[28] = 88;
					num = 8;
					break;
				case 242:
					array2[10] = 112;
					num2 = 259;
					continue;
				case 267:
					array2[13] = (byte)num18;
					num2 = 204;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 233;
					}
					continue;
				case 386:
					array[9] = 159;
					num2 = 194;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 27;
					}
					continue;
				case 219:
					array[13] = 168;
					num2 = 261;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 110;
					}
					continue;
				case 281:
					array2[6] = 158;
					num2 = 331;
					continue;
				case 161:
					array[10] = (byte)num17;
					num2 = 4;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 9;
					}
					continue;
				case 271:
					array[27] = (byte)num15;
					num2 = 130;
					continue;
				case 159:
					array2[7] = 251;
					num2 = 350;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 34;
					}
					continue;
				case 21:
					array2[1] = (byte)num18;
					num2 = 136;
					continue;
				case 19:
					if (num22 > 0)
					{
						num2 = 23;
						if (WXqhsslO4LXJOodQQQf6())
						{
							num2 = 26;
						}
						continue;
					}
					goto case 44;
				case 10:
					array[7] = 130;
					num2 = 163;
					continue;
				case 356:
					array5 = array8;
					num2 = 116;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 20;
					}
					continue;
				case 235:
					array2[5] = (byte)num18;
					num2 = 368;
					continue;
				case 311:
					array4[num20] ^= array3[num20];
					num2 = 220;
					continue;
				case 377:
					num28 = 0u;
					num2 = 304;
					continue;
				case 394:
					array2[3] = 158;
					num2 = 381;
					continue;
				case 185:
					array[28] = (byte)num15;
					num = 57;
					break;
				case 218:
					num18 = 87 + 90;
					num2 = 227;
					continue;
				case 359:
					num36 = num26 % num23;
					num2 = 94;
					continue;
				case 334:
					num18 = 207 + 37;
					num2 = 12;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 152;
					}
					continue;
				case 48:
					array[13] = 106;
					num2 = 83;
					continue;
				case 268:
					array[19] = 104;
					num2 = 92;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 48;
					}
					continue;
				case 283:
					array[1] = 90;
					num2 = 320;
					continue;
				case 74:
					array[14] = 204;
					num2 = 13;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 1;
					}
					continue;
				case 43:
					num15 = 15 + 69;
					num2 = 301;
					continue;
				case 136:
					array2[2] = 192;
					num2 = 16;
					continue;
				case 305:
					array[30] = (byte)num15;
					num2 = 54;
					continue;
				case 30:
					array2[7] = 138;
					num2 = 228;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 129;
					}
					continue;
				case 124:
					num18 = 141 - 64;
					num2 = 345;
					continue;
				case 167:
					num17 = 146 - 22;
					num2 = 288;
					continue;
				case 103:
					num15 = 246 - 82;
					num2 = 115;
					continue;
				case 329:
					num18 = 162 + 16;
					num2 = 59;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 322;
					}
					continue;
				case 309:
					num18 = 46 + 68;
					num2 = 290;
					continue;
				case 254:
					num17 = 49 + 103;
					num2 = 75;
					continue;
				case 397:
					num32 = 0;
					num2 = 65;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 43;
					}
					continue;
				case 61:
					if (EsnlSXB4Z7a)
					{
						num2 = 2;
						if (feFCDPlOD7wyK1Om4EsB() == null)
						{
							num2 = 60;
						}
						continue;
					}
					goto case 313;
				case 308:
					array2[8] = 160;
					num2 = 27;
					continue;
				case 4:
					array2[4] = 18;
					num2 = 79;
					continue;
				case 23:
					num18 = 50 + 115;
					num2 = 189;
					continue;
				case 118:
					array[24] = (byte)num17;
					num2 = 390;
					continue;
				case 300:
					array[4] = 65;
					num2 = 28;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 391;
					}
					continue;
				case 197:
					array[30] = (byte)num15;
					num = 243;
					break;
				case 155:
					array[8] = 135;
					num2 = 357;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 3;
					}
					continue;
				case 132:
					array2[6] = (byte)num18;
					num2 = 96;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 53;
					}
					continue;
				case 240:
					array[21] = (byte)num15;
					num2 = 6;
					continue;
				case 337:
					array3 = array2;
					num2 = 91;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 183;
					}
					continue;
				case 229:
					FlelSsjyggk = EfrvaYlOxDg5Bg7L3cVW(Kk5IuNlOsY2msn6ARsWr(memoryStream));
					num = 196;
					break;
				case 352:
					array[18] = 46;
					num2 = 349;
					continue;
				case 243:
					array[30] = 155;
					num2 = 265;
					continue;
				case 32:
					num15 = 244 - 81;
					num2 = 7;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 125;
					}
					continue;
				case 387:
					num17 = 99 + 1;
					num2 = 275;
					continue;
				case 183:
					num30 = 1;
					num2 = 328;
					continue;
				case 211:
					array[25] = 132;
					num2 = 18;
					continue;
				case 253:
					array[21] = (byte)num17;
					num2 = 24;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 43;
					}
					continue;
				case 287:
					array2[12] = (byte)num18;
					num2 = 17;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 3;
					}
					continue;
				case 59:
					array2[3] = 233;
					num2 = 394;
					continue;
				case 123:
					num18 = 151 - 50;
					num2 = 132;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 121;
					}
					continue;
				case 71:
					array[4] = (byte)num15;
					num2 = 162;
					continue;
				case 256:
					num21 = 0;
					num2 = 46;
					continue;
				case 29:
					array[2] = 101;
					num2 = 270;
					continue;
				case 338:
					array[12] = 222;
					num2 = 119;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 27;
					}
					continue;
				case 177:
					array[9] = 120;
					num2 = 10;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 25;
					}
					continue;
				case 77:
					array[5] = 113;
					num2 = 147;
					continue;
				case 292:
					num17 = 41 + 43;
					num2 = 213;
					continue;
				case 93:
					num17 = 88 + 35;
					num2 = 118;
					continue;
				case 98:
					array[22] = (byte)num17;
					num2 = 102;
					continue;
				case 117:
					array[12] = 183;
					num2 = 181;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 245;
					}
					continue;
				case 351:
					num17 = 80 + 73;
					num2 = 55;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 206;
					}
					continue;
				case 336:
					array2[11] = (byte)num18;
					num2 = 127;
					continue;
				case 245:
					num17 = 132 - 44;
					num2 = 154;
					continue;
				case 145:
					array[23] = 165;
					num2 = 164;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 264;
					}
					continue;
				case 196:
					kIaewxlOXHoJqxRpcy7t(memoryStream);
					num2 = 120;
					continue;
				case 52:
					array[11] = (byte)num17;
					num2 = 117;
					continue;
				case 323:
					array2[8] = (byte)num18;
					num2 = 311;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 334;
					}
					continue;
				case 34:
					array[29] = (byte)num17;
					num2 = 32;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 9;
					}
					continue;
				case 393:
					array[11] = 99;
					num2 = 274;
					continue;
				case 206:
					array[24] = (byte)num17;
					num2 = 354;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 323;
					}
					continue;
				case 276:
				case 395:
					if (num26 >= num25)
					{
						num2 = 232;
						continue;
					}
					goto case 359;
				case 346:
					num15 = 243 - 81;
					num2 = 197;
					continue;
				case 173:
					num17 = 241 - 80;
					num2 = 3;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 41;
					}
					continue;
				case 17:
					array2[13] = 218;
					num2 = 200;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 76;
					}
					continue;
				case 280:
					num18 = 225 - 75;
					num2 = 73;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 382;
					}
					continue;
				case 286:
					array[0] = 162;
					num2 = 244;
					continue;
				case 181:
					array[6] = (byte)num15;
					num2 = 190;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 335;
					}
					continue;
				case 342:
					array[20] = (byte)num15;
					num2 = 174;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 296;
					}
					continue;
				case 79:
					array2[4] = 169;
					num2 = 49;
					continue;
				case 140:
					array2[5] = (byte)num18;
					num2 = 37;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 67;
					}
					continue;
				case 255:
					array[27] = (byte)num17;
					num2 = 186;
					continue;
				case 86:
					num18 = 176 - 58;
					num2 = 235;
					continue;
				case 317:
					num28 = (uint)((array4[num16 + 3] << 24) | (array4[num16 + 2] << 16) | (array4[num16 + 1] << 8) | array4[num16]);
					num2 = 1;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 1;
					}
					continue;
				case 85:
					array[11] = 176;
					num2 = 20;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 327;
					}
					continue;
				case 105:
					if (num26 == num25 - 1)
					{
						num2 = 5;
						if (WXqhsslO4LXJOodQQQf6())
						{
							num2 = 19;
						}
						continue;
					}
					goto case 44;
				case 204:
					array7 = new byte[array5.Length];
					num2 = 73;
					continue;
				case 199:
					array[20] = (byte)num17;
					num = 326;
					break;
				case 108:
					array2[1] = (byte)num18;
					num2 = 218;
					continue;
				case 203:
					num25++;
					num2 = 319;
					continue;
				case 56:
					array[16] = 238;
					num2 = 201;
					continue;
				case 302:
					array[20] = (byte)num15;
					num2 = 187;
					continue;
				case 128:
					array2[11] = 53;
					num2 = 374;
					continue;
				case 5:
					num26 = 0;
					num2 = 276;
					continue;
				case 188:
					array2[11] = (byte)num18;
					num2 = 280;
					continue;
				case 293:
					array[5] = (byte)num15;
					num2 = 173;
					continue;
				case 49:
					array2[4] = 69;
					num2 = 299;
					continue;
				case 270:
					num15 = 194 - 64;
					num2 = 364;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 261;
					}
					continue;
				case 295:
					array[19] = (byte)num15;
					num2 = 45;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 268;
					}
					continue;
				case 157:
					if (num30 != 1)
					{
						num2 = 144;
						continue;
					}
					goto case 284;
				case 198:
					array2[11] = (byte)num18;
					num2 = 315;
					continue;
				case 205:
					if (num21 > 0)
					{
						num2 = 129;
						continue;
					}
					goto case 66;
				case 178:
					num15 = 25 + 12;
					num2 = 216;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 184;
					}
					continue;
				case 129:
					num31 <<= 8;
					num2 = 362;
					continue;
				case 361:
					num18 = 155 + 29;
					num = 306;
					break;
				case 207:
					array[27] = (byte)num17;
					num2 = 278;
					continue;
				case 227:
					array2[1] = (byte)num18;
					num2 = 110;
					continue;
				case 375:
					num18 = 213 - 71;
					num2 = 34;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 210;
					}
					continue;
				case 41:
					array[6] = (byte)num17;
					num2 = 133;
					continue;
				case 324:
					array2[14] = 171;
					num2 = 314;
					continue;
				case 374:
					num18 = 138 - 27;
					num2 = 170;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 188;
					}
					continue;
				case 362:
					num32 += 8;
					num2 = 33;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 66;
					}
					continue;
				case 225:
					num18 = 123 - 6;
					num2 = 287;
					continue;
				case 51:
					array8 = (byte[])x3Bq1ElOSqnLVPeZOSgg(f5CPUNl5pxqM6Zmk7dMj, (int)FxHEF3lO5NmgIki9VwYI(CS0dRMlOkHyWq3qVC09t(f5CPUNl5pxqM6Zmk7dMj)));
					num2 = 266;
					continue;
				case 88:
					num17 = 52 - 42;
					num2 = 341;
					continue;
				case 299:
					array2[4] = 44;
					num2 = 86;
					continue;
				case 1:
					num31 = 255u;
					num2 = 397;
					continue;
				case 396:
					num17 = 192 - 64;
					num2 = 4;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 34;
					}
					continue;
				case 82:
					array2 = new byte[16];
					num2 = 23;
					continue;
				case 70:
					array2[8] = 68;
					num2 = 297;
					continue;
				case 367:
					num4 = 0u;
					num2 = 377;
					continue;
				case 264:
					array[23] = 99;
					num2 = 93;
					continue;
				case 210:
					array2[0] = (byte)num18;
					num2 = 316;
					continue;
				case 304:
					num19 = 0u;
					num2 = 333;
					continue;
				case 294:
					num17 = 228 - 105;
					num2 = 252;
					continue;
				case 388:
					num15 = 9 + 115;
					num2 = 40;
					continue;
				case 130:
					array[27] = 118;
					num2 = 135;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 191;
					}
					continue;
				case 259:
					array2[10] = 68;
					num2 = 166;
					continue;
				case 133:
					num15 = 239 - 79;
					num2 = 181;
					continue;
				case 99:
				case 138:
					num26++;
					num2 = 395;
					continue;
				case 13:
					array[15] = 128;
					num2 = 400;
					continue;
				case 55:
					num15 = 239 - 79;
					num2 = 257;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 30;
					}
					continue;
				case 277:
					array[14] = (byte)num17;
					num = 184;
					break;
				case 116:
					num22 = array5.Length % 4;
					num2 = 165;
					continue;
				case 120:
				case 126:
				case 401:
					bKslSepk46o = (string[])gwTUuVlOjb0JRDgo4cuP((Assembly)FlelSsjyggk);
					num2 = 3;
					continue;
				case 354:
					num15 = 125 - 86;
					num2 = 160;
					continue;
				case 376:
					array[31] = (byte)num15;
					num2 = 294;
					continue;
				case 226:
					array[3] = 21;
					num2 = 298;
					continue;
				case 171:
					array[3] = (byte)num15;
					num2 = 261;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 378;
					}
					continue;
				case 236:
					num17 = 132 - 44;
					num2 = 199;
					continue;
				case 345:
					array2[10] = (byte)num18;
					num = 307;
					break;
				case 16:
					num18 = 88 + 13;
					num2 = 180;
					continue;
				case 160:
					array[24] = (byte)num15;
					num2 = 148;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 137;
					}
					continue;
				case 216:
					array[3] = (byte)num15;
					num2 = 291;
					continue;
				case 228:
					array2[7] = 145;
					num2 = 159;
					continue;
				case 360:
					array2[14] = 94;
					num2 = 324;
					continue;
				case 306:
					array2[2] = (byte)num18;
					num2 = 104;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 79;
					}
					continue;
				case 274:
					array[11] = 94;
					num2 = 369;
					continue;
				case 166:
					num18 = 197 - 65;
					num2 = 7;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 47;
					}
					continue;
				case 153:
					array7[num27] = (byte)(num29 & 0xFF);
					num2 = 249;
					continue;
				case 347:
					array2[6] = (byte)num18;
					num2 = 30;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 2;
					}
					continue;
				case 265:
					array[30] = 149;
					num2 = 209;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 171;
					}
					continue;
				case 200:
					num18 = 209 - 69;
					num = 267;
					break;
				case 389:
					array7[num27 + 3] = (byte)((num29 & 0xFF000000u) >> 24);
					num2 = 99;
					continue;
				case 7:
				case 348:
					if (num24 >= num22)
					{
						num2 = 19;
						if (WXqhsslO4LXJOodQQQf6())
						{
							num2 = 106;
						}
						continue;
					}
					goto case 122;
				case 233:
					num18 = 218 - 72;
					num2 = 157;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 318;
					}
					continue;
				case 81:
					array[22] = (byte)num15;
					num = 50;
					break;
				case 383:
					array2[5] = (byte)num18;
					num2 = 281;
					continue;
				case 343:
					num15 = 110 + 95;
					num2 = 117;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 293;
					}
					continue;
				case 392:
					if (num30 != 0)
					{
						num2 = 157;
						continue;
					}
					goto case 62;
				case 357:
					array[8] = 24;
					num2 = 177;
					continue;
				case 248:
					array4 = array;
					num2 = 60;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 82;
					}
					continue;
				case 121:
					array2[1] = 165;
					num2 = 37;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 37;
					}
					continue;
				case 257:
					array[18] = (byte)num15;
					num2 = 63;
					continue;
				case 195:
					num17 = 131 - 43;
					num2 = 273;
					continue;
				case 249:
					array7[num27 + 1] = (byte)((num29 & 0xFF00) >> 8);
					num2 = 202;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 183;
					}
					continue;
				case 107:
					num4 += num28;
					num = 149;
					break;
				case 261:
					array[13] = 141;
					num2 = 48;
					continue;
				case 110:
					num18 = 151 + 53;
					num2 = 21;
					continue;
				case 327:
					num17 = 126 + 59;
					num = 52;
					break;
				case 147:
					array[5] = 142;
					num2 = 91;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 398;
					}
					continue;
				case 363:
					num15 = 181 - 95;
					num2 = 342;
					continue;
				case 319:
					num16 = 0u;
					num = 5;
					break;
				case 42:
					deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
					num2 = 353;
					continue;
				case 94:
					num27 = num26 * 4;
					num2 = 135;
					continue;
				case 234:
					num19 <<= 8;
					num2 = 33;
					continue;
				case 201:
					num17 = 47 + 33;
					num2 = 224;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 269;
					}
					continue;
				case 400:
					array[15] = 95;
					num2 = 221;
					continue;
				case 382:
					array2[12] = (byte)num18;
					num2 = 62;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 246;
					}
					continue;
				case 390:
					num15 = 194 - 64;
					num2 = 16;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 22;
					}
					continue;
				case 224:
					num15 = 161 - 53;
					num2 = 365;
					continue;
				case 97:
					array2[9] = 88;
					num = 87;
					break;
				case 125:
					array[29] = (byte)num15;
					num = 224;
					break;
				case 379:
					num15 = 77 + 69;
					num2 = 305;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 111;
					}
					continue;
				case 149:
					num19 = (uint)((array5[num16 + 3] << 24) | (array5[num16 + 2] << 16) | (array5[num16 + 1] << 8) | array5[num16]);
					num2 = 176;
					continue;
				case 141:
					num15 = 95 + 54;
					num2 = 182;
					continue;
				case 372:
					array[7] = 128;
					num = 10;
					break;
				case 325:
					array[16] = 138;
					num2 = 48;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 64;
					}
					continue;
				case 285:
					num17 = 230 - 76;
					num = 380;
					break;
				case 191:
					num17 = 175 - 58;
					num2 = 207;
					continue;
				case 152:
					array2[8] = (byte)num18;
					num2 = 193;
					continue;
				case 251:
					array[29] = 150;
					num2 = 266;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 396;
					}
					continue;
				case 273:
					array[8] = (byte)num17;
					num2 = 155;
					continue;
				case 230:
					num24 = 0;
					num2 = 348;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 266;
					}
					continue;
				case 301:
					array[21] = (byte)num15;
					num2 = 90;
					continue;
				case 369:
					array[11] = 164;
					num2 = 73;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 85;
					}
					continue;
				case 139:
					array[15] = (byte)num15;
					num2 = 15;
					continue;
				case 269:
					array[16] = (byte)num17;
					num2 = 325;
					continue;
				case 179:
					num15 = 61 + 117;
					num2 = 8;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 11;
					}
					continue;
				case 365:
					array[29] = (byte)num15;
					num2 = 88;
					continue;
				case 275:
					array[8] = (byte)num17;
					num2 = 195;
					continue;
				case 310:
					array[26] = 97;
					num2 = 167;
					continue;
				case 39:
					array[24] = 150;
					num2 = 351;
					continue;
				case 100:
					num15 = 149 - 49;
					num = 385;
					break;
				case 208:
					array[17] = (byte)num15;
					num2 = 388;
					continue;
				case 15:
					num17 = 43 + 12;
					num2 = 60;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 260;
					}
					continue;
				case 246:
					num18 = 17 + 102;
					num2 = 279;
					continue;
				case 322:
					array2[13] = (byte)num18;
					num2 = 309;
					continue;
				case 69:
					num15 = 121 + 97;
					num2 = 146;
					continue;
				case 112:
					array[30] = (byte)num17;
					num2 = 247;
					continue;
				case 313:
					f5CPUNl5pxqM6Zmk7dMj = new stmj4Ul1bF7178khnjLy.F5CPUNl5pxqM6Zmk7dMj((Stream)IhWQT9lONjd2morlBd3m(zKqRGUlObjt3sPnTq3Zk(typeof(stmj4Ul1bF7178khnjLy).TypeHandle).Assembly, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606640510)));
					num2 = 295;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 355;
					}
					continue;
				case 378:
					num15 = 202 - 67;
					num2 = 71;
					continue;
				case 78:
					array2[14] = 142;
					num2 = 315;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 360;
					}
					continue;
				case 381:
					num18 = 27 - 1;
					num2 = 217;
					continue;
				case 279:
					array2[12] = (byte)num18;
					num2 = 200;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 272;
					}
					continue;
				case 169:
					num15 = 88 + 24;
					num2 = 52;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 81;
					}
					continue;
				case 6:
					array[21] = 157;
					num2 = 339;
					continue;
				case 221:
					num15 = 117 + 12;
					num2 = 139;
					continue;
				case 36:
					array[23] = 51;
					num2 = 120;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 145;
					}
					continue;
				case 114:
					num15 = 134 - 44;
					num2 = 101;
					continue;
				case 102:
					array[22] = 93;
					num2 = 30;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 36;
					}
					continue;
				case 250:
					array2[0] = 59;
					num2 = 262;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 168;
					}
					continue;
				case 73:
					num23 = array4.Length / 4;
					num2 = 246;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 367;
					}
					continue;
				case 186:
					num17 = 112 + 74;
					num = 238;
					break;
				case 40:
					array[18] = (byte)num15;
					num2 = 215;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 204;
					}
					continue;
				case 104:
					num18 = 198 - 66;
					num = 174;
					break;
				case 83:
					num17 = 108 + 64;
					num2 = 75;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 113;
					}
					continue;
				case 115:
					array[9] = (byte)num15;
					num2 = 141;
					continue;
				case 282:
					num17 = 211 - 70;
					num2 = 13;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 312;
					}
					continue;
				case 137:
					num15 = 52 + 45;
					num2 = 192;
					continue;
				case 391:
					array[5] = 137;
					num2 = 77;
					continue;
				case 220:
					num20++;
					num2 = 53;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 31;
					}
					continue;
				case 96:
					array2[6] = 130;
					num2 = 223;
					continue;
				case 170:
					array2[9] = 129;
					num2 = 97;
					continue;
				case 260:
					array[15] = (byte)num17;
					num2 = 190;
					continue;
				case 31:
					array2[1] = (byte)num18;
					num2 = 121;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 121;
					}
					continue;
				case 38:
					array[1] = 2;
					num2 = 29;
					continue;
				case 53:
				case 109:
					if (num20 >= array3.Length)
					{
						num2 = 356;
						continue;
					}
					goto case 311;
				case 238:
					array[28] = (byte)num17;
					num2 = 332;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 44;
					}
					continue;
				case 189:
					array2[0] = (byte)num18;
					num2 = 7;
					if (WXqhsslO4LXJOodQQQf6())
					{
						num2 = 222;
					}
					continue;
				case 28:
					array2[5] = (byte)num18;
					num2 = 68;
					continue;
				case 84:
					array[26] = 85;
					num2 = 310;
					continue;
				case 290:
					array2[14] = (byte)num18;
					num2 = 172;
					continue;
				case 168:
					array[26] = 79;
					num2 = 84;
					continue;
				case 215:
					array[18] = 123;
					num2 = 50;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 55;
					}
					continue;
				case 344:
					num19 = 0u;
					num2 = 14;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 3;
					}
					continue;
				case 314:
					num18 = 1 + 34;
					num2 = 289;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 129;
					}
					continue;
				case 142:
					array[10] = 116;
					num2 = 60;
					if (feFCDPlOD7wyK1Om4EsB() == null)
					{
						num2 = 164;
					}
					continue;
				case 180:
					array2[2] = (byte)num18;
					num2 = 361;
					if (!WXqhsslO4LXJOodQQQf6())
					{
						num2 = 180;
					}
					continue;
				default:
					array[25] = (byte)num17;
					num2 = 211;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 96;
					}
					continue;
				case 151:
					num15 = 163 - 54;
					num2 = 376;
					if (feFCDPlOD7wyK1Om4EsB() != null)
					{
						num2 = 67;
					}
					continue;
				case 106:
				case 176:
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
					num2 = 105;
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] HFClSxBjh86(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556141)).Assembly)
		{
			if (!EsnlSXB4Z7a)
			{
				b52lSSNbURk();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)FlelSsjyggk).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly yrElSLJlecd(object P_0, ResolveEventArgs P_1)
	{
		if (!EsnlSXB4Z7a)
		{
			b52lSSNbURk();
		}
		string name = P_1.Name;
		for (int i = 0; i < bKslSepk46o.Length; i++)
		{
			if (bKslSepk46o[i] == name)
			{
				return (Assembly)FlelSsjyggk;
			}
		}
		return null;
	}

	public aMVIXxlSkgpiTGaSyVJP()
	{
		AppDomain.CurrentDomain.ResourceResolve += yrElSLJlecd;
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!WoHlScWOAYW)
		{
			WoHlScWOAYW = true;
			new aMVIXxlSkgpiTGaSyVJP();
		}
	}

	internal static Type zKqRGUlObjt3sPnTq3Zk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object IhWQT9lONjd2morlBd3m(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object CS0dRMlOkHyWq3qVC09t(object P_0)
	{
		return ((stmj4Ul1bF7178khnjLy.F5CPUNl5pxqM6Zmk7dMj)P_0).m9OIO8Q0EK();
	}

	internal static void vuwAUilO177wIyBpHh5J(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long FxHEF3lO5NmgIki9VwYI(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object x3Bq1ElOSqnLVPeZOSgg(object P_0, int P_1)
	{
		return ((stmj4Ul1bF7178khnjLy.F5CPUNl5pxqM6Zmk7dMj)P_0).TdKl5uhcEnE(P_1);
	}

	internal static object EfrvaYlOxDg5Bg7L3cVW(object P_0)
	{
		return cfnYGBlSEMSnVLqTlXBi.BgclSI6tZ4x((byte[])P_0);
	}

	internal static void s2VhIKlOLPlny3Zp9b5E(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void M9fcU5lOeg3ZRPxp6DZo(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Kk5IuNlOsY2msn6ARsWr(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void kIaewxlOXHoJqxRpcy7t(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object E90tiZlOchab8eVZ8JgB(object P_0, uint P_1)
	{
		return cfnYGBlSEMSnVLqTlXBi.WKElSWdh3M8((byte[])P_0, P_1);
	}

	internal static object gwTUuVlOjb0JRDgo4cuP(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool WXqhsslO4LXJOodQQQf6()
	{
		return (object)null == null;
	}

	internal static object feFCDPlOD7wyK1Om4EsB()
	{
		return null;
	}
}
