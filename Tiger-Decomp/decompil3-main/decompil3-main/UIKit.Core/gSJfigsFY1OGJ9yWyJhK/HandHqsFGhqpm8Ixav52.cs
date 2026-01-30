using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using bengxqsFHOBf5kWpcG0Y;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace gSJfigsFY1OGJ9yWyJhK;

internal class HandHqsFGhqpm8Ixav52
{
	private enum VBDOuGsFblWe8sNQQyTD
	{

	}

	internal class FsDUiFsFNvltvFdT1BXj
	{
		private unsafe static uint d3msFkVWCuV(void* P_0, uint P_1)
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

		private unsafe static bool rX9sF1cpKDQ(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void THqsF5SsyRi(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void t55sFSSBvb4(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void dtcsFxxhE0T(byte* P_0, byte* P_1, uint P_2)
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
				t55sFSSBvb4(P_0, P_1, P_2);
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

		private unsafe static uint E8KsFLkBftn(byte[] P_0, uint P_1, VBDOuGsFblWe8sNQQyTD P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint hSIsFeS1IDs(byte[] P_0, uint P_1)
		{
			return E8KsFLkBftn(P_0, P_1, (VBDOuGsFblWe8sNQQyTD)3);
		}

		private unsafe static uint R0lsFsOMkul(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + d3msFkVWCuV(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (d3msFkVWCuV(ptr6 + 4, 4u) != 1)
					{
						t55sFSSBvb4(ptr2, ptr3 + num, d3msFkVWCuV(ptr6 + 3, 4u));
						return d3msFkVWCuV(ptr6 + 3, 4u);
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
							num2 = d3msFkVWCuV(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = d3msFkVWCuV(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								dtcsFxxhE0T(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								dtcsFxxhE0T(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								dtcsFxxhE0T(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								dtcsFxxhE0T(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								dtcsFxxhE0T(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								THqsF5SsyRi(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							dtcsFxxhE0T(ptr5, ptr4, 4u);
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

		internal static object cPwsFXuoTyf(byte[] P_0)
		{
			return Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777374)).GetMethod(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x746ED405 ^ 0x746EDF81).Trim(), new Type[1] { Ks3nQ1XlcJUMluSqjA3n(typeof(byte[]).TypeHandle) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] GiesFcXG8gq(byte[] P_0, uint P_1)
		{
			uint num = z0CBpbXljBQQ0a3Dr2vI(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				sx9CMjXlEQha4jIJ91ck(P_0, P_1, array);
			}
			return array;
		}

		internal static Type Ks3nQ1XlcJUMluSqjA3n(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static uint z0CBpbXljBQQ0a3Dr2vI(object P_0, uint P_1)
		{
			return hSIsFeS1IDs((byte[])P_0, P_1);
		}

		internal static uint sx9CMjXlEQha4jIJ91ck(object P_0, uint P_1, object P_2)
		{
			return R0lsFsOMkul((byte[])P_0, P_1, (byte[])P_2);
		}
	}

	private static string[] GHlsFimNvKN = new string[0];

	private static object y7psFlBj8gm = null;

	private static bool rL9sF472avd = false;

	private static bool KdNsFDBwL8g = false;

	private static void WRqsFvfevx2()
	{
		int num = 172;
		byte[] array = default(byte[]);
		int num18 = default(int);
		byte[] array2 = default(byte[]);
		int num22 = default(int);
		int num19 = default(int);
		int num15 = default(int);
		int num31 = default(int);
		int num25 = default(int);
		uint num20 = default(uint);
		byte[] array4 = default(byte[]);
		int num28 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array3 = default(byte[]);
		uint num35 = default(uint);
		int num36 = default(int);
		uint num21 = default(uint);
		int num16 = default(int);
		uint num33 = default(uint);
		int num37 = default(int);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num23 = default(int);
		int num24 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num32 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		uint num17 = default(uint);
		OQNZEtsP93U56NxbHlup.esTXBjsJrjJbaHqQrcuh esTXBjsJrjJbaHqQrcuh = default(OQNZEtsP93U56NxbHlup.esTXBjsJrjJbaHqQrcuh);
		uint num30 = default(uint);
		byte[] array5 = default(byte[]);
		int num34 = default(int);
		int num29 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 273:
					array[31] = 150;
					num2 = 318;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 246;
					}
					continue;
				case 266:
					num18 = 27 + 66;
					num2 = 162;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 139;
					}
					continue;
				case 89:
					array2[2] = (byte)num22;
					num2 = 64;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 257;
					}
					continue;
				case 392:
					array[27] = (byte)num18;
					num2 = 379;
					continue;
				case 217:
					array2[10] = (byte)num19;
					num2 = 40;
					continue;
				case 375:
					array[13] = (byte)num15;
					num2 = 39;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 80;
					}
					continue;
				case 286:
					num18 = 231 - 77;
					num2 = 421;
					continue;
				case 163:
					if (num31 > 0)
					{
						num = 3;
						break;
					}
					goto case 297;
				case 67:
					num25 = 0;
					num2 = 293;
					continue;
				case 365:
					array2[1] = (byte)num22;
					num2 = 288;
					continue;
				case 412:
					array2[4] = 116;
					num2 = 108;
					continue;
				case 114:
					num18 = 116 - 6;
					num2 = 13;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 6;
					}
					continue;
				case 20:
					array[26] = (byte)num18;
					num = 242;
					break;
				case 177:
					num18 = 239 - 79;
					num2 = 45;
					continue;
				case 107:
					num20 |= array4[array4.Length - (1 + num28)];
					num2 = 359;
					continue;
				case 361:
					array[16] = (byte)num15;
					num = 138;
					break;
				case 185:
					num15 = 246 - 82;
					num2 = 29;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 240;
					}
					continue;
				case 263:
					array[13] = (byte)num18;
					num2 = 128;
					continue;
				case 200:
					array2[14] = (byte)num19;
					num2 = 108;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 222;
					}
					continue;
				case 401:
					array6 = array3;
					num2 = 101;
					continue;
				case 212:
					array[24] = 102;
					num2 = 332;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 229;
					}
					continue;
				case 178:
					array[18] = (byte)num18;
					num2 = 175;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 81;
					}
					continue;
				case 183:
					array2[2] = 119;
					num2 = 223;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 326;
					}
					continue;
				case 25:
					num18 = 155 - 51;
					num2 = 380;
					continue;
				case 21:
					array[15] = 144;
					num2 = 289;
					continue;
				case 131:
					array[9] = (byte)num15;
					num2 = 393;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 335;
					}
					continue;
				case 315:
					array[3] = 123;
					num2 = 299;
					continue;
				case 4:
					array[17] = 74;
					num2 = 286;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 280;
					}
					continue;
				case 43:
					num19 = 54 + 87;
					num2 = 173;
					continue;
				case 62:
					array[21] = (byte)num15;
					num2 = 306;
					continue;
				case 333:
					array2[4] = 123;
					num2 = 129;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 16;
					}
					continue;
				case 398:
					array[22] = 118;
					num2 = 276;
					continue;
				case 253:
					array[25] = (byte)num15;
					num2 = 204;
					continue;
				case 356:
					num4 = 0u;
					num2 = 282;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 16;
					}
					continue;
				case 338:
					array[13] = (byte)num18;
					num2 = 49;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 17;
					}
					continue;
				case 34:
					array2[4] = 202;
					num2 = 333;
					continue;
				case 280:
					array[27] = (byte)num18;
					num2 = 155;
					continue;
				case 425:
					array2[0] = (byte)num19;
					num2 = 424;
					continue;
				case 278:
					array2[5] = 119;
					num2 = 206;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 73;
					}
					continue;
				case 191:
					num15 = 233 - 77;
					num2 = 190;
					continue;
				case 350:
					array[26] = (byte)num18;
					num2 = 255;
					continue;
				case 281:
					array2[11] = (byte)num19;
					num2 = 123;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 304;
					}
					continue;
				case 3:
					num35 <<= 8;
					num2 = 414;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 97;
					}
					continue;
				case 258:
					array[0] = 152;
					num2 = 170;
					continue;
				case 319:
					array2[1] = 158;
					num2 = 15;
					continue;
				case 416:
					array2[10] = (byte)num22;
					num2 = 1;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 11;
					}
					continue;
				case 407:
					array[28] = 34;
					num2 = 274;
					continue;
				case 232:
					num20 = 0u;
					num2 = 100;
					continue;
				case 414:
					num36 += 8;
					num2 = 297;
					continue;
				case 121:
					num20 <<= 8;
					num2 = 107;
					continue;
				case 7:
					array[2] = 104;
					num2 = 213;
					continue;
				case 138:
					num15 = 57 + 71;
					num2 = 122;
					continue;
				case 216:
					num18 = 107 - 34;
					num2 = 194;
					continue;
				case 66:
					num21 = (uint)num16;
					num2 = 402;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 293;
					}
					continue;
				case 231:
					array[10] = 111;
					num2 = 160;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 290;
					}
					continue;
				case 55:
					array[5] = (byte)num18;
					num2 = 146;
					continue;
				case 180:
					array2[7] = 116;
					num2 = 18;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 24;
					}
					continue;
				case 359:
					num28++;
					num2 = 59;
					continue;
				case 186:
					array[22] = (byte)num18;
					num2 = 61;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 60;
					}
					continue;
				case 314:
					num22 = 245 - 81;
					num2 = 417;
					continue;
				case 46:
					array[30] = 129;
					num2 = 372;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 270;
					}
					continue;
				case 297:
					array3[num16 + num31] = (byte)((num33 & num35) >> num36);
					num2 = 422;
					continue;
				case 316:
					num15 = 107 + 41;
					num2 = 20;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 27;
					}
					continue;
				case 257:
					array2[2] = 98;
					num2 = 283;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 207;
					}
					continue;
				case 72:
					array[12] = (byte)num18;
					num2 = 123;
					continue;
				case 421:
					array[17] = (byte)num18;
					num2 = 261;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 61;
					}
					continue;
				case 221:
					array2[15] = 164;
					num2 = 43;
					continue;
				case 142:
					array[14] = (byte)num18;
					num2 = 197;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 354;
					}
					continue;
				case 74:
					array[31] = (byte)num15;
					num2 = 342;
					continue;
				case 134:
					num19 = 249 - 83;
					num2 = 48;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 36;
					}
					continue;
				case 17:
					array[14] = (byte)num15;
					num2 = 295;
					continue;
				case 150:
					num15 = 221 - 73;
					num = 62;
					break;
				case 51:
					num22 = 88 + 20;
					num2 = 365;
					continue;
				case 255:
					array[26] = 85;
					num2 = 362;
					continue;
				case 256:
					array[20] = 155;
					num2 = 406;
					continue;
				case 332:
					num15 = 247 - 82;
					num2 = 310;
					continue;
				case 364:
					array2[7] = 158;
					num2 = 188;
					continue;
				case 301:
					array[7] = 79;
					num2 = 219;
					continue;
				case 101:
					if (num37 == 0)
					{
						num2 = 59;
						if (xsc5P5Xf2WVMeTHCsNLj() == null)
						{
							num2 = 77;
						}
						continue;
					}
					goto case 68;
				case 348:
					array7[num25] ^= array8[num25];
					num2 = 106;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 104;
					}
					continue;
				case 176:
					if (num23 == num24 - 1)
					{
						num2 = 71;
						continue;
					}
					goto case 158;
				case 112:
					array[10] = 159;
					num2 = 31;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 382;
					}
					continue;
				case 13:
					array[20] = (byte)num18;
					num2 = 92;
					continue;
				case 370:
					num18 = 61 + 102;
					num2 = 78;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 103;
					}
					continue;
				case 371:
					num18 = 31 + 113;
					num2 = 55;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 179;
					}
					continue;
				case 61:
					array[22] = 144;
					num2 = 106;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 279;
					}
					continue;
				case 162:
					array[9] = (byte)num18;
					num2 = 93;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 80;
					}
					continue;
				case 322:
					array[7] = 146;
					num2 = 301;
					continue;
				case 68:
					if (num37 != 1)
					{
						num2 = 223;
						continue;
					}
					goto case 70;
				case 385:
					array[10] = (byte)num15;
					num2 = 74;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 112;
					}
					continue;
				case 23:
					NaRR3YXfi6icMuKPwUld(memoryStream);
					num2 = 8;
					continue;
				case 237:
					array2[8] = 79;
					num2 = 18;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 17;
					}
					continue;
				case 15:
					array2[1] = 166;
					num2 = 29;
					continue;
				case 400:
					num18 = 21 + 64;
					num2 = 268;
					continue;
				case 335:
					num19 = 246 - 82;
					num2 = 425;
					continue;
				case 211:
				case 223:
					y7psFlBj8gm = tnOhFxXfoVE35lKhnkI3(ro99dZXfloA4ypAAcOkO(array6, 0u));
					num2 = 207;
					continue;
				case 122:
					array[16] = (byte)num15;
					num2 = 140;
					continue;
				case 268:
					array[20] = (byte)num18;
					num2 = 146;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 256;
					}
					continue;
				case 199:
					num23 = 0;
					num2 = 185;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 254;
					}
					continue;
				case 271:
					array[3] = 116;
					num2 = 328;
					continue;
				case 116:
					if (num32 > 0)
					{
						num2 = 320;
						continue;
					}
					goto case 98;
				case 269:
					array[25] = 121;
					num2 = 3;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 152;
					}
					continue;
				case 24:
					array2[7] = 85;
					num2 = 156;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 364;
					}
					continue;
				case 117:
					num18 = 180 - 60;
					num2 = 178;
					continue;
				case 406:
					num15 = 0 + 25;
					num2 = 39;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 24;
					}
					continue;
				case 270:
					array2[15] = (byte)num19;
					num2 = 366;
					continue;
				case 12:
					num19 = 157 - 74;
					num2 = 131;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 281;
					}
					continue;
				case 50:
					num19 = 241 - 80;
					num2 = 159;
					continue;
				case 274:
					array[29] = 65;
					num2 = 371;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 418;
					}
					continue;
				case 241:
					try
					{
						KiWi7bXfvZSyaxngsy7V(deflateStream, memoryStream);
						int num26 = 0;
						if (xsc5P5Xf2WVMeTHCsNLj() != null)
						{
							num26 = 0;
						}
						switch (num26)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num27;
						if (deflateStream == null)
						{
							num27 = 0;
							if (!LuQh7RXf0erYPQyOS8qN())
							{
								num27 = 0;
							}
							goto IL_1521;
						}
						goto IL_1556;
						IL_1521:
						switch (num27)
						{
						default:
							goto end_IL_14fc;
						case 0:
							goto end_IL_14fc;
						case 2:
							break;
						case 1:
							goto end_IL_14fc;
						}
						goto IL_1556;
						IL_1556:
						PA2iNFXfBqxEoGEvR43q(deflateStream);
						num27 = 0;
						if (LuQh7RXf0erYPQyOS8qN())
						{
							num27 = 1;
						}
						goto IL_1521;
						end_IL_14fc:;
					}
					goto case 127;
				case 143:
					array[13] = (byte)num18;
					num2 = 360;
					continue;
				case 277:
					num22 = 223 - 74;
					num2 = 376;
					continue;
				case 302:
					array[18] = 166;
					num2 = 102;
					continue;
				case 235:
					array2[4] = (byte)num19;
					num2 = 278;
					continue;
				case 118:
					array2[9] = (byte)num19;
					num2 = 112;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 250;
					}
					continue;
				case 106:
					num25++;
					num2 = 79;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 71;
					}
					continue;
				case 393:
					array[9] = 84;
					num2 = 170;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 331;
					}
					continue;
				case 219:
					array[7] = 76;
					num2 = 395;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 391;
					}
					continue;
				case 311:
					if (num23 == num24 - 1)
					{
						num2 = 243;
						if (xsc5P5Xf2WVMeTHCsNLj() != null)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 66;
				case 352:
					num20 = (uint)((array4[num21 + 3] << 24) | (array4[num21 + 2] << 16) | (array4[num21 + 1] << 8) | array4[num21]);
					num2 = 148;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 117;
					}
					continue;
				case 84:
					array3[num16 + 3] = (byte)((num17 & 0xFF000000u) >> 24);
					num2 = 2;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 126;
					}
					continue;
				case 233:
					array[23] = (byte)num15;
					num2 = 369;
					continue;
				case 413:
					array2[3] = 45;
					num2 = 412;
					continue;
				case 351:
					array2[11] = (byte)num19;
					num2 = 2;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 12;
					}
					continue;
				case 102:
					array[18] = 77;
					num2 = 6;
					continue;
				case 346:
					MUfAZnXfnLO3EX9L6wQt(nmlF1OXf9RulDYqIbiHr(esTXBjsJrjJbaHqQrcuh), 0L);
					num2 = 125;
					continue;
				case 9:
					num18 = 184 - 108;
					num2 = 147;
					continue;
				case 213:
					num15 = 29 + 20;
					num = 64;
					break;
				case 2:
					array[28] = 162;
					num2 = 73;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 185;
					}
					continue;
				case 326:
					array2[3] = 205;
					num2 = 133;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 277;
					}
					continue;
				case 38:
					num15 = 62 + 96;
					num2 = 165;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 391;
					}
					continue;
				case 159:
					array2[13] = (byte)num19;
					num2 = 135;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 66;
					}
					continue;
				case 321:
					array[15] = 138;
					num2 = 229;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 126;
					}
					continue;
				case 99:
					array[27] = (byte)num18;
					num2 = 19;
					continue;
				case 328:
					num15 = 129 - 123;
					num2 = 203;
					continue;
				case 373:
					array[30] = (byte)num18;
					num2 = 404;
					continue;
				case 27:
					array[2] = (byte)num15;
					num = 191;
					break;
				case 71:
					if (num32 > 0)
					{
						num2 = 174;
						continue;
					}
					goto case 158;
				case 396:
					num15 = 24 + 15;
					num2 = 267;
					continue;
				case 250:
					array2[9] = 138;
					num2 = 52;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 367;
					}
					continue;
				case 349:
					array[4] = 145;
					num2 = 341;
					continue;
				case 126:
				case 201:
					num23++;
					num2 = 260;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 260;
					}
					continue;
				case 366:
					num22 = 33 + 105;
					num2 = 228;
					continue;
				case 234:
					array[28] = (byte)num15;
					num2 = 381;
					continue;
				case 53:
					if (num28 > 0)
					{
						num = 121;
						break;
					}
					goto case 107;
				case 391:
					array[15] = (byte)num15;
					num2 = 321;
					continue;
				case 409:
					num16 = num23 * 4;
					num2 = 427;
					continue;
				case 125:
					array6 = new byte[0];
					num2 = 5;
					continue;
				case 386:
					num35 = 255u;
					num2 = 43;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 157;
					}
					continue;
				case 188:
					array2[7] = 125;
					num2 = 296;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 336;
					}
					continue;
				case 340:
					return;
				case 175:
					array[18] = 134;
					num2 = 302;
					continue;
				case 147:
					array[6] = (byte)num18;
					num2 = 236;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 262;
					}
					continue;
				case 85:
					array[0] = 127;
					num2 = 75;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 60;
					}
					continue;
				case 153:
					num18 = 107 + 120;
					num2 = 94;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 16;
					}
					continue;
				case 64:
					array[2] = (byte)num15;
					num2 = 69;
					continue;
				case 405:
					array[1] = 148;
					num2 = 316;
					continue;
				case 104:
					array2[0] = 146;
					num2 = 335;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 20;
					}
					continue;
				case 318:
					num15 = 11 + 123;
					num2 = 97;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 41;
					}
					continue;
				case 428:
					array2[11] = 157;
					num2 = 65;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 40;
					}
					continue;
				case 410:
					array[5] = (byte)num15;
					num2 = 408;
					continue;
				case 292:
					array2[13] = 107;
					num2 = 244;
					continue;
				case 70:
					memoryStream = new MemoryStream();
					num2 = 5;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 111;
					}
					continue;
				case 291:
					num22 = 102 + 105;
					num2 = 327;
					continue;
				case 160:
					array2[9] = (byte)num22;
					num2 = 36;
					continue;
				case 267:
					array[6] = (byte)num15;
					num2 = 57;
					continue;
				case 418:
					array[29] = 126;
					num = 324;
					break;
				case 379:
					num15 = 153 - 51;
					num2 = 234;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 78;
					}
					continue;
				case 390:
					array2[14] = 142;
					num2 = 36;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 193;
					}
					continue;
				case 354:
					array[14] = 96;
					num2 = 308;
					continue;
				case 383:
					num19 = 96 + 4;
					num2 = 351;
					continue;
				case 31:
					array3[num16 + 1] = (byte)((num17 & 0xFF00) >> 8);
					num2 = 252;
					continue;
				case 136:
					array[31] = 120;
					num2 = 129;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 358;
					}
					continue;
				case 204:
					array[25] = 123;
					num = 269;
					break;
				case 187:
					array[11] = 49;
					num2 = 371;
					continue;
				case 94:
					array[12] = (byte)num18;
					num2 = 33;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 264;
					}
					continue;
				case 98:
					num21 = 0u;
					num2 = 199;
					continue;
				case 308:
					array[14] = 138;
					num2 = 130;
					continue;
				case 157:
					num36 = 0;
					num2 = 311;
					continue;
				case 166:
					array[22] = (byte)num18;
					num2 = 398;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 347;
					}
					continue;
				case 198:
					array[17] = (byte)num18;
					num2 = 117;
					continue;
				case 144:
					array2[6] = 128;
					num2 = 88;
					continue;
				case 402:
					num4 += num30;
					num2 = 352;
					continue;
				case 29:
					array2[1] = 70;
					num2 = 22;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 22;
					}
					continue;
				case 60:
					num15 = 60 + 32;
					num2 = 97;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 236;
					}
					continue;
				case 317:
					array[1] = 155;
					num2 = 405;
					continue;
				case 242:
					array[26] = 173;
					num2 = 133;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 60;
					}
					continue;
				case 324:
					array[29] = 157;
					num2 = 388;
					continue;
				case 184:
					array[24] = 116;
					num = 30;
					break;
				case 357:
					num31 = 0;
					num2 = 214;
					continue;
				case 82:
					num15 = 104 + 51;
					num2 = 375;
					continue;
				case 306:
					num15 = 129 - 43;
					num2 = 227;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 175;
					}
					continue;
				case 372:
					num18 = 60 + 82;
					num2 = 373;
					continue;
				case 251:
					array2[9] = (byte)num22;
					num2 = 181;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 291;
					}
					continue;
				case 417:
					array2[11] = (byte)num22;
					num2 = 100;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 383;
					}
					continue;
				case 303:
					array2[13] = 106;
					num2 = 208;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 292;
					}
					continue;
				case 300:
					array[25] = 159;
					num2 = 259;
					continue;
				case 341:
					array[4] = 119;
					num2 = 397;
					continue;
				case 294:
					array[7] = 92;
					num2 = 167;
					continue;
				case 282:
					num30 = 0u;
					num2 = 1;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 1;
					}
					continue;
				case 22:
					num22 = 30 + 109;
					num2 = 89;
					continue;
				case 345:
					array2[1] = 50;
					num2 = 268;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 319;
					}
					continue;
				case 206:
					array2[5] = 159;
					num2 = 161;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 196;
					}
					continue;
				case 14:
					array[4] = (byte)num18;
					num2 = 337;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 258;
					}
					continue;
				case 426:
					rL9sF472avd = true;
					num2 = 340;
					continue;
				case 399:
					array2[14] = (byte)num19;
					num2 = 221;
					continue;
				case 59:
				case 394:
					if (num28 >= num32)
					{
						num2 = 0;
						if (xsc5P5Xf2WVMeTHCsNLj() != null)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 53;
				case 355:
					array[19] = (byte)num15;
					num2 = 25;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 287;
					}
					continue;
				case 42:
					array[1] = 86;
					num2 = 317;
					continue;
				case 79:
				case 293:
					if (num25 >= array8.Length)
					{
						num2 = 312;
						continue;
					}
					goto case 348;
				case 182:
					num15 = 105 + 91;
					num2 = 28;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 16;
					}
					continue;
				case 283:
					array2[2] = 27;
					num2 = 183;
					continue;
				case 423:
					num30 = (uint)((array7[num21 + 3] << 24) | (array7[num21 + 2] << 16) | (array7[num21 + 1] << 8) | array7[num21]);
					num2 = 386;
					continue;
				case 243:
					if (num32 > 0)
					{
						num = 232;
						break;
					}
					goto case 66;
				case 80:
					num18 = 57 + 94;
					num2 = 263;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 68;
					}
					continue;
				case 228:
					array2[15] = (byte)num22;
					num2 = 91;
					continue;
				case 305:
					array[11] = (byte)num18;
					num2 = 187;
					continue;
				case 115:
					array2[0] = 133;
					num2 = 51;
					continue;
				case 272:
					array = new byte[32];
					num2 = 85;
					continue;
				case 344:
					array2[14] = (byte)num19;
					num2 = 119;
					continue;
				case 109:
					array[30] = (byte)num15;
					num2 = 73;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 66;
					}
					continue;
				case 194:
					array[18] = (byte)num18;
					num2 = 377;
					continue;
				case 312:
					array4 = array5;
					num2 = 368;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 196;
					}
					continue;
				case 164:
					num18 = 64 + 46;
					num2 = 55;
					continue;
				case 374:
					num18 = 218 - 72;
					num2 = 58;
					continue;
				case 149:
					array[0] = (byte)num15;
					num2 = 177;
					continue;
				case 247:
					num19 = 160 - 53;
					num2 = 205;
					continue;
				case 103:
					array[23] = (byte)num18;
					num2 = 26;
					continue;
				case 227:
					array[21] = (byte)num15;
					num2 = 239;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 128;
					}
					continue;
				case 395:
					num15 = 82 + 43;
					num2 = 168;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 164;
					}
					continue;
				case 343:
					num18 = 244 - 81;
					num2 = 44;
					continue;
				case 238:
					num19 = 80 + 42;
					num2 = 270;
					continue;
				case 156:
					array[16] = (byte)num15;
					num2 = 220;
					continue;
				case 37:
					num37 = 1;
					num2 = 21;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 67;
					}
					continue;
				case 376:
					array2[3] = (byte)num22;
					num2 = 413;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 76;
					}
					continue;
				case 171:
					esTXBjsJrjJbaHqQrcuh = new OQNZEtsP93U56NxbHlup.esTXBjsJrjJbaHqQrcuh((Stream)T8ntUsXffgvnn3u32CeQ(ia0GOQXfHuR8s83lAty0(typeof(OQNZEtsP93U56NxbHlup).TypeHandle).Assembly, OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-962524685 ^ -962526499)));
					num2 = 346;
					continue;
				case 127:
					y7psFlBj8gm = tnOhFxXfoVE35lKhnkI3(MuETDMXfaLHctLlFtmLW(memoryStream));
					num2 = 1;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 23;
					}
					continue;
				case 135:
					array2[13] = 104;
					num2 = 197;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 31;
					}
					continue;
				case 32:
					array[29] = (byte)num15;
					num2 = 165;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 151;
					}
					continue;
				case 288:
					array2[1] = 30;
					num2 = 210;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 345;
					}
					continue;
				case 377:
					num18 = 197 - 65;
					num2 = 224;
					continue;
				case 58:
					array[19] = (byte)num18;
					num2 = 52;
					continue;
				case 35:
					array[8] = 88;
					num2 = 182;
					continue;
				case 26:
					num15 = 109 + 9;
					num2 = 233;
					continue;
				case 275:
					array[15] = 72;
					num2 = 38;
					continue;
				case 261:
					num18 = 88 + 55;
					num = 198;
					break;
				case 285:
					array2[11] = 199;
					num2 = 314;
					continue;
				case 218:
					array[14] = (byte)num15;
					num2 = 21;
					continue;
				case 404:
					num15 = 82 + 110;
					num2 = 109;
					continue;
				case 154:
					num18 = 197 - 65;
					num2 = 186;
					continue;
				case 220:
					num15 = 125 - 41;
					num2 = 54;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 361;
					}
					continue;
				case 224:
					array[19] = (byte)num18;
					num2 = 374;
					continue;
				case 246:
					array2[6] = 98;
					num2 = 137;
					continue;
				case 336:
					num22 = 140 - 46;
					num2 = 81;
					continue;
				case 33:
					array[11] = 155;
					num2 = 204;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 347;
					}
					continue;
				case 239:
					num15 = 14 + 82;
					num = 86;
					break;
				case 146:
					num15 = 179 - 104;
					num2 = 339;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 410;
					}
					continue;
				case 342:
					num15 = 43 + 14;
					num2 = 105;
					continue;
				case 190:
					array[2] = (byte)num15;
					num2 = 7;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 0;
					}
					continue;
				case 420:
					array2[10] = 17;
					num2 = 428;
					continue;
				case 167:
					array[7] = 187;
					num2 = 322;
					continue;
				case 161:
					num15 = 227 - 75;
					num = 385;
					break;
				case 320:
					num24++;
					num2 = 98;
					continue;
				case 325:
					array[0] = (byte)num18;
					num2 = 258;
					continue;
				case 262:
					num15 = 140 - 46;
					num2 = 313;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 218;
					}
					continue;
				case 347:
					num18 = 74 + 96;
					num2 = 305;
					continue;
				case 419:
					array[3] = 121;
					num2 = 115;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 271;
					}
					continue;
				case 296:
					array2[0] = (byte)num22;
					num2 = 115;
					continue;
				case 95:
					num15 = 110 + 92;
					num2 = 299;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 363;
					}
					continue;
				case 45:
					array[1] = (byte)num18;
					num2 = 41;
					continue;
				case 172:
					if (rL9sF472avd)
					{
						return;
					}
					num2 = 171;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 102;
					}
					continue;
				case 193:
					num19 = 4 + 76;
					num2 = 39;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 200;
					}
					continue;
				case 28:
					array[8] = (byte)num15;
					num2 = 226;
					continue;
				case 422:
					num31++;
					num = 323;
					break;
				case 245:
					num34 = num23 % num29;
					num2 = 409;
					continue;
				case 389:
					num15 = 103 + 25;
					num2 = 38;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 149;
					}
					continue;
				case 353:
					array2[8] = (byte)num19;
					num2 = 210;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 237;
					}
					continue;
				case 36:
					num22 = 138 - 90;
					num2 = 141;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 251;
					}
					continue;
				case 111:
					deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
					num2 = 213;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 241;
					}
					continue;
				case 226:
					array[8] = 111;
					num2 = 266;
					continue;
				case 287:
					array[20] = 76;
					num = 400;
					break;
				case 41:
					num18 = 88 + 20;
					num2 = 132;
					continue;
				case 295:
					num18 = 204 - 68;
					num2 = 142;
					continue;
				case 203:
					array[3] = (byte)num15;
					num2 = 95;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 36;
					}
					continue;
				case 403:
					num18 = 71 - 46;
					num2 = 298;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 103;
					}
					continue;
				case 108:
					num19 = 253 - 84;
					num2 = 10;
					continue;
				case 215:
					array2 = new byte[16];
					num2 = 181;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 16;
					}
					continue;
				case 387:
					array[16] = 210;
					num2 = 343;
					continue;
				case 91:
					array8 = array2;
					num2 = 37;
					continue;
				case 48:
					array2[12] = (byte)num19;
					num2 = 189;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 114;
					}
					continue;
				case 388:
					num15 = 223 - 74;
					num2 = 32;
					continue;
				case 310:
					array[24] = (byte)num15;
					num2 = 184;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 128;
					}
					continue;
				case 52:
					num15 = 134 + 49;
					num = 355;
					break;
				case 381:
					array[28] = 114;
					num2 = 0;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 2;
					}
					continue;
				case 196:
					array2[5] = 189;
					num2 = 246;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 10;
					}
					continue;
				case 380:
					array[21] = (byte)num18;
					num2 = 393;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 403;
					}
					continue;
				case 56:
					num18 = 208 - 69;
					num2 = 143;
					continue;
				case 254:
				case 260:
					if (num23 >= num24)
					{
						num2 = 401;
						if (!LuQh7RXf0erYPQyOS8qN())
						{
							num2 = 108;
						}
						continue;
					}
					goto case 245;
				case 90:
					array2[12] = 44;
					num2 = 38;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 247;
					}
					continue;
				case 173:
					array2[15] = (byte)num19;
					num2 = 21;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 87;
					}
					continue;
				case 44:
					array[17] = (byte)num18;
					num2 = 195;
					continue;
				case 378:
					num22 = 75 + 82;
					num2 = 160;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 53;
					}
					continue;
				case 367:
					array2[9] = 98;
					num2 = 141;
					continue;
				case 170:
					array[0] = 149;
					num2 = 389;
					continue;
				case 30:
					num15 = 77 + 74;
					num2 = 47;
					continue;
				case 248:
					array[5] = (byte)num18;
					num2 = 17;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 164;
					}
					continue;
				case 16:
					num19 = 159 + 63;
					num2 = 197;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 399;
					}
					continue;
				case 299:
					array[3] = 164;
					num2 = 419;
					continue;
				case 284:
					array[31] = 40;
					num2 = 136;
					continue;
				case 119:
					array2[14] = 101;
					num2 = 390;
					continue;
				case 49:
					array[13] = 168;
					num2 = 82;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 62;
					}
					continue;
				case 427:
					num21 = (uint)(num34 * 4);
					num2 = 423;
					continue;
				case 236:
					array[30] = (byte)num15;
					num2 = 46;
					continue;
				case 128:
					num15 = 41 + 122;
					num2 = 17;
					continue;
				case 327:
					array2[10] = (byte)num22;
					num2 = 124;
					continue;
				case 189:
					array2[12] = 76;
					num2 = 50;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 26;
					}
					continue;
				case 93:
					num15 = 198 - 66;
					num2 = 131;
					continue;
				case 139:
					array3 = new byte[array4.Length];
					num2 = 0;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 96;
					}
					continue;
				case 397:
					num18 = 109 + 103;
					num2 = 9;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 14;
					}
					continue;
				case 168:
					array[8] = (byte)num15;
					num2 = 35;
					continue;
				case 205:
					array2[12] = (byte)num19;
					num2 = 33;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 134;
					}
					continue;
				case 276:
					array[22] = 132;
					num2 = 370;
					continue;
				case 81:
					array2[8] = (byte)num22;
					num2 = 245;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 309;
					}
					continue;
				case 69:
					num18 = 88 - 17;
					num2 = 208;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 210;
					}
					continue;
				case 210:
					array[2] = (byte)num18;
					num2 = 161;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 315;
					}
					continue;
				case 362:
					array[26] = 135;
					num2 = 209;
					continue;
				case 192:
					array2[0] = (byte)num22;
					num2 = 104;
					continue;
				case 57:
					array[6] = 115;
					num2 = 9;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 9;
					}
					continue;
				case 6:
					array[18] = 166;
					num2 = 216;
					continue;
				case 358:
					array7 = array;
					num2 = 215;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 122;
					}
					continue;
				case 86:
					array[21] = (byte)num15;
					num2 = 25;
					continue;
				case 105:
					array[31] = (byte)num15;
					num2 = 273;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 221;
					}
					continue;
				case 76:
					array[6] = (byte)num18;
					num2 = 120;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 105;
					}
					continue;
				case 368:
					num32 = array4.Length % 4;
					num2 = 339;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 129;
					}
					continue;
				case 259:
					num18 = 150 - 50;
					num = 350;
					break;
				case 92:
					array[21] = 166;
					num2 = 150;
					continue;
				case 174:
					num33 = num4 ^ num20;
					num2 = 283;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 357;
					}
					continue;
				case 78:
					num18 = 112 + 121;
					num2 = 99;
					continue;
				case 123:
					num15 = 47 + 91;
					num2 = 307;
					continue;
				case 181:
					array2[0] = 68;
					num2 = 107;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 113;
					}
					continue;
				case 265:
					num18 = 47 + 104;
					num2 = 248;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 217;
					}
					continue;
				case 339:
					num24 = array4.Length / 4;
					num2 = 139;
					continue;
				case 222:
					array2[14] = 96;
					num2 = 16;
					continue;
				case 214:
				case 323:
					if (num31 >= num32)
					{
						num2 = 201;
						continue;
					}
					goto case 163;
				case 411:
					num19 = 16 + 83;
					num2 = 118;
					continue;
				case 100:
					num4 += num30;
					num2 = 230;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 98;
					}
					continue;
				case 382:
					array[10] = 181;
					num2 = 231;
					continue;
				case 249:
					array2[11] = (byte)num19;
					num2 = 285;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 31;
					}
					continue;
				case 334:
					num15 = 66 + 14;
					num = 156;
					break;
				case 307:
					array[13] = (byte)num15;
					num2 = 56;
					continue;
				case 309:
					num19 = 45 + 18;
					num2 = 353;
					continue;
				case 145:
					array2[7] = 108;
					num2 = 180;
					continue;
				case 408:
					num18 = 241 - 80;
					num2 = 49;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 76;
					}
					continue;
				case 169:
					array[24] = 238;
					num2 = 83;
					continue;
				case 96:
					num29 = array7.Length / 4;
					num2 = 356;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 85;
					}
					continue;
				case 39:
					array[20] = (byte)num15;
					num2 = 114;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 28;
					}
					continue;
				case 331:
					array[10] = 201;
					num2 = 137;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 161;
					}
					continue;
				case 73:
					num15 = 103 + 39;
					num2 = 74;
					continue;
				case 304:
					array2[12] = 157;
					num2 = 151;
					continue;
				case 65:
					num19 = 212 - 70;
					num2 = 235;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 249;
					}
					continue;
				case 132:
					array[1] = (byte)num18;
					num2 = 42;
					continue;
				case 244:
					num19 = 233 - 77;
					num = 344;
					break;
				case 10:
					array2[4] = (byte)num19;
					num2 = 34;
					continue;
				case 415:
					array[6] = 158;
					num2 = 396;
					continue;
				case 209:
					num18 = 157 - 52;
					num2 = 13;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 20;
					}
					continue;
				case 298:
					array[21] = (byte)num18;
					num2 = 154;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 9;
					}
					continue;
				case 230:
					num28 = 0;
					num2 = 394;
					continue;
				case 252:
					array3[num16 + 2] = (byte)((num17 & 0xFF0000) >> 16);
					num2 = 55;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 84;
					}
					continue;
				case 54:
				case 77:
					y7psFlBj8gm = tnOhFxXfoVE35lKhnkI3(array6);
					num2 = 63;
					continue;
				case 155:
					array[27] = 138;
					num2 = 78;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 25;
					}
					continue;
				case 1:
					num20 = 0u;
					num2 = 116;
					continue;
				case 87:
					array2[15] = 154;
					num2 = 238;
					continue;
				case 195:
					array[17] = 111;
					num2 = 2;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 4;
					}
					continue;
				case 152:
					array[25] = 171;
					num2 = 300;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 244;
					}
					continue;
				case 384:
					num18 = 3 + 31;
					num2 = 110;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 280;
					}
					continue;
				case 110:
					array[15] = 140;
					num2 = 275;
					continue;
				case 289:
					array[15] = 135;
					num2 = 110;
					continue;
				case 137:
					array2[6] = 156;
					num2 = 144;
					continue;
				case 202:
					array[24] = 102;
					num2 = 10;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 212;
					}
					continue;
				case 208:
					array[30] = 97;
					num2 = 60;
					continue;
				case 290:
					array[11] = 137;
					num2 = 33;
					continue;
				case 158:
					num17 = num4 ^ num20;
					num2 = 330;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 228;
					}
					continue;
				case 279:
					num18 = 73 + 85;
					num2 = 100;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 166;
					}
					continue;
				case 424:
					num22 = 135 - 45;
					num2 = 296;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 180;
					}
					continue;
				case 179:
					array[12] = (byte)num18;
					num2 = 25;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 153;
					}
					continue;
				case 97:
					array[31] = (byte)num15;
					num2 = 284;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 273;
					}
					continue;
				case 124:
					num19 = 216 - 72;
					num2 = 217;
					continue;
				case 120:
					num18 = 60 + 17;
					num2 = 225;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 37;
					}
					continue;
				case 130:
					num15 = 108 + 66;
					num2 = 218;
					if (xsc5P5Xf2WVMeTHCsNLj() != null)
					{
						num2 = 81;
					}
					continue;
				case 151:
					array2[12] = 150;
					num2 = 90;
					continue;
				case 329:
					array[4] = 123;
					num2 = 349;
					continue;
				case 8:
				case 63:
				case 207:
					GHlsFimNvKN = (string[])lX3rS6Xf4J3VHwc4XLAK((Assembly)y7psFlBj8gm);
					num2 = 426;
					continue;
				case 113:
					num22 = 51 + 122;
					num2 = 192;
					continue;
				case 47:
					array[24] = (byte)num15;
					num2 = 46;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 169;
					}
					continue;
				case 140:
					array[16] = 169;
					num2 = 387;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 291;
					}
					continue;
				case 133:
					array[27] = 136;
					num2 = 384;
					continue;
				case 330:
					array3[num16] = (byte)(num17 & 0xFF);
					num2 = 31;
					continue;
				case 19:
					num18 = 123 - 16;
					num2 = 298;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 392;
					}
					continue;
				case 165:
					array[29] = 173;
					num2 = 208;
					continue;
				case 88:
					array2[6] = 208;
					num2 = 145;
					continue;
				case 197:
					array2[13] = 38;
					num = 303;
					break;
				case 363:
					array[4] = (byte)num15;
					num2 = 329;
					continue;
				case 129:
					num19 = 101 + 88;
					num2 = 235;
					continue;
				case 18:
					array2[8] = 99;
					num2 = 95;
					if (LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 411;
					}
					continue;
				case 369:
					array[23] = 143;
					num2 = 202;
					continue;
				case 5:
					array5 = (byte[])C0o9y2XfYnBefo0W4fTy(esTXBjsJrjJbaHqQrcuh, (int)UI0e7dXfGJlbvFKXPjTT(nmlF1OXf9RulDYqIbiHr(esTXBjsJrjJbaHqQrcuh)));
					num2 = 272;
					continue;
				case 11:
					array2[10] = 157;
					num2 = 420;
					continue;
				case 229:
					array[16] = 98;
					num2 = 334;
					continue;
				case 225:
					array[6] = (byte)num18;
					num2 = 415;
					continue;
				case 141:
					array2[9] = 88;
					num = 378;
					break;
				case 75:
					num18 = 57 + 51;
					num2 = 325;
					continue;
				case 40:
					num22 = 153 - 51;
					num2 = 416;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 97;
					}
					continue;
				case 337:
					array[4] = 184;
					num2 = 265;
					if (!LuQh7RXf0erYPQyOS8qN())
					{
						num2 = 242;
					}
					continue;
				case 83:
					num15 = 104 + 106;
					num2 = 253;
					continue;
				case 240:
					array[28] = (byte)num15;
					num2 = 407;
					continue;
				case 264:
					num18 = 24 + 113;
					num2 = 13;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 72;
					}
					continue;
				case 360:
					num18 = 14 + 84;
					num2 = 338;
					continue;
				case 313:
					array[7] = (byte)num15;
					num2 = 294;
					continue;
				default:
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
					num2 = 168;
					if (xsc5P5Xf2WVMeTHCsNLj() == null)
					{
						num2 = 176;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] wjlsFBrvotw(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554513)).Assembly)
		{
			if (!rL9sF472avd)
			{
				WRqsFvfevx2();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)y7psFlBj8gm).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly AMfsFaXLTcl(object P_0, ResolveEventArgs P_1)
	{
		if (!rL9sF472avd)
		{
			WRqsFvfevx2();
		}
		string name = P_1.Name;
		for (int i = 0; i < GHlsFimNvKN.Length; i++)
		{
			if (GHlsFimNvKN[i] == name)
			{
				return (Assembly)y7psFlBj8gm;
			}
		}
		return null;
	}

	public HandHqsFGhqpm8Ixav52()
	{
		AppDomain.CurrentDomain.ResourceResolve += AMfsFaXLTcl;
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!KdNsFDBwL8g)
		{
			KdNsFDBwL8g = true;
			new HandHqsFGhqpm8Ixav52();
		}
	}

	internal static Type ia0GOQXfHuR8s83lAty0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object T8ntUsXffgvnn3u32CeQ(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object nmlF1OXf9RulDYqIbiHr(object P_0)
	{
		return ((OQNZEtsP93U56NxbHlup.esTXBjsJrjJbaHqQrcuh)P_0).m9OIO8Q0EK();
	}

	internal static void MUfAZnXfnLO3EX9L6wQt(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long UI0e7dXfGJlbvFKXPjTT(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object C0o9y2XfYnBefo0W4fTy(object P_0, int P_1)
	{
		return ((OQNZEtsP93U56NxbHlup.esTXBjsJrjJbaHqQrcuh)P_0).VtvsJKVst6l(P_1);
	}

	internal static object tnOhFxXfoVE35lKhnkI3(object P_0)
	{
		return FsDUiFsFNvltvFdT1BXj.cPwsFXuoTyf((byte[])P_0);
	}

	internal static void KiWi7bXfvZSyaxngsy7V(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void PA2iNFXfBqxEoGEvR43q(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object MuETDMXfaLHctLlFtmLW(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void NaRR3YXfi6icMuKPwUld(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object ro99dZXfloA4ypAAcOkO(object P_0, uint P_1)
	{
		return FsDUiFsFNvltvFdT1BXj.GiesFcXG8gq((byte[])P_0, P_1);
	}

	internal static object lX3rS6Xf4J3VHwc4XLAK(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool LuQh7RXf0erYPQyOS8qN()
	{
		return (object)null == null;
	}

	internal static object xsc5P5Xf2WVMeTHCsNLj()
	{
		return null;
	}
}
