using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using lmDVLFXTelX8TWB2gCPn;
using Mp0rQhXtcD2M433xKykv;
using nXNMiwXTSjaRAVOuyCXd;

namespace WUsie0XTELvQJLckfItk;

internal class opEHbQXTjwOP89DtxKKp
{
	private enum yLa6EYXTIBkAHHJmaP0v
	{

	}

	internal class P6wiLtXTWooyjBUAV3Sq
	{
		private unsafe static uint Ec0XTtxWy83(void* P_0, uint P_1)
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

		private unsafe static bool PDDXTUli5R2(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void oMPXTTUxKuJ(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void o8JXTyGm7pH(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void OcUXTZQYJok(byte* P_0, byte* P_1, uint P_2)
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
				o8JXTyGm7pH(P_0, P_1, P_2);
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

		private unsafe static uint x1jXTVgVIHp(byte[] P_0, uint P_1, yLa6EYXTIBkAHHJmaP0v P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint h09XTCVDTpD(byte[] P_0, uint P_1)
		{
			return uMMNLTXA6bQw9aU1jQVV(P_0, P_1, (yLa6EYXTIBkAHHJmaP0v)3);
		}

		private unsafe static uint LynXTrpG7hk(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + Ec0XTtxWy83(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (Ec0XTtxWy83(ptr6 + 4, 4u) != 1)
					{
						o8JXTyGm7pH(ptr2, ptr3 + num, Ec0XTtxWy83(ptr6 + 3, 4u));
						return Ec0XTtxWy83(ptr6 + 3, 4u);
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
							num2 = Ec0XTtxWy83(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = Ec0XTtxWy83(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								OcUXTZQYJok(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								OcUXTZQYJok(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								OcUXTZQYJok(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								OcUXTZQYJok(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								OcUXTZQYJok(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								oMPXTTUxKuJ(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							OcUXTZQYJok(ptr5, ptr4, 4u);
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

		internal static object AZqXTKqHcU5(byte[] P_0)
		{
			return Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(16777281)).GetMethod(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(--146713930 ^ 0x8BEABCA).Trim(), new Type[1] { typeof(byte[]) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] d9PXTmyNf0n(byte[] P_0, uint P_1)
		{
			uint num = h09XTCVDTpD(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				BVxLAJXAMFBnMhZuF3dj(P_0, P_1, array);
			}
			return array;
		}

		internal static uint uMMNLTXA6bQw9aU1jQVV(object P_0, uint P_1, yLa6EYXTIBkAHHJmaP0v P_2)
		{
			return x1jXTVgVIHp((byte[])P_0, P_1, P_2);
		}

		internal static uint BVxLAJXAMFBnMhZuF3dj(object P_0, uint P_1, object P_2)
		{
			return LynXTrpG7hk((byte[])P_0, P_1, (byte[])P_2);
		}
	}

	private static string[] mF9XT6gUiLI = new string[0];

	private static object P4PXTMWF2FL = null;

	private static bool gpyXTOwTlIi = false;

	private static bool gZnXTqkoxSu = false;

	private static void a5FXTdJuk9r()
	{
		int num = 41;
		int num21 = default(int);
		int num16 = default(int);
		byte[] array = default(byte[]);
		uint num18 = default(uint);
		byte[] array2 = default(byte[]);
		int num20 = default(int);
		int num19 = default(int);
		int num24 = default(int);
		byte[] array4 = default(byte[]);
		int num17 = default(int);
		byte[] array3 = default(byte[]);
		uint num25 = default(uint);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num29 = default(int);
		uint num32 = default(uint);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		int num15 = default(int);
		T2OXZhXtXqRemtkpvtX8.H5eCOjXTYRdoELpYcijW h5eCOjXTYRdoELpYcijW = default(T2OXZhXtXqRemtkpvtX8.H5eCOjXTYRdoELpYcijW);
		int num27 = default(int);
		int num26 = default(int);
		int num22 = default(int);
		int num31 = default(int);
		int num37 = default(int);
		int num30 = default(int);
		uint num33 = default(uint);
		uint num36 = default(uint);
		byte[] array8 = default(byte[]);
		int num23 = default(int);
		byte[] array7 = default(byte[]);
		uint num28 = default(uint);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 126:
					num21 = 116 - 32;
					num2 = 275;
					continue;
				case 163:
					num16 = 164 + 75;
					num2 = 238;
					continue;
				case 311:
					array[2] = 241;
					num2 = 301;
					continue;
				case 374:
					array[20] = (byte)num16;
					num2 = 45;
					continue;
				case 369:
					array[3] = 98;
					num2 = 82;
					continue;
				case 277:
					num16 = 245 - 81;
					num2 = 84;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 65;
					}
					continue;
				case 327:
					num18 |= array2[array2.Length - (1 + num20)];
					num2 = 306;
					continue;
				case 352:
					num19 = 210 - 121;
					num = 357;
					break;
				case 204:
				case 359:
					if (num24 >= array4.Length)
					{
						num2 = 285;
						if (osqowQXhIE733O0fL3iF() == null)
						{
							num2 = 401;
						}
						continue;
					}
					goto case 187;
				case 243:
					num17 = 17 + 113;
					num = 23;
					break;
				case 124:
					array[19] = (byte)num21;
					num2 = 321;
					continue;
				case 114:
					num21 = 248 - 82;
					num2 = 312;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 55;
					}
					continue;
				case 56:
					array3[0] = 99;
					num2 = 127;
					continue;
				case 334:
					array[16] = (byte)num16;
					num2 = 250;
					continue;
				case 12:
					array[1] = (byte)num21;
					num2 = 277;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 198;
					}
					continue;
				case 220:
					array[29] = 16;
					num2 = 95;
					continue;
				case 278:
					array3[0] = (byte)num19;
					num2 = 104;
					continue;
				case 208:
					array[25] = 127;
					num2 = 122;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 265;
					}
					continue;
				case 351:
					num19 = 53 + 72;
					num2 = 285;
					continue;
				case 275:
					array[4] = (byte)num21;
					num2 = 30;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 239;
					}
					continue;
				case 6:
					array3[11] = 185;
					num2 = 47;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 253;
					}
					continue;
				case 169:
					num19 = 96 - 79;
					num2 = 0;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 1;
					}
					continue;
				case 107:
					num24++;
					num2 = 359;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 222;
					}
					continue;
				case 321:
					array[19] = 136;
					num2 = 91;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 71;
					}
					continue;
				case 177:
					num19 = 54 + 110;
					num2 = 136;
					continue;
				case 26:
					num18 = (uint)((array2[num25 + 3] << 24) | (array2[num25 + 2] << 16) | (array2[num25 + 1] << 8) | array2[num25]);
					num2 = 161;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 0;
					}
					continue;
				case 7:
					array[31] = 125;
					num2 = 399;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 399;
					}
					continue;
				case 382:
					array[30] = 175;
					num2 = 9;
					continue;
				case 17:
					num21 = 89 + 14;
					num2 = 124;
					continue;
				case 248:
					array[3] = 144;
					num2 = 284;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 369;
					}
					continue;
				case 282:
					num19 = 137 - 45;
					num2 = 149;
					continue;
				case 69:
					array[15] = 123;
					num2 = 10;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 32;
					}
					continue;
				case 200:
					array[20] = 68;
					num2 = 17;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 115;
					}
					continue;
				case 117:
					array3[11] = (byte)num17;
					num2 = 165;
					continue;
				case 15:
					array[23] = 226;
					num2 = 71;
					continue;
				case 32:
					num16 = 2 + 16;
					num2 = 326;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 111;
					}
					continue;
				case 394:
					array[13] = 206;
					num2 = 142;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 98;
					}
					continue;
				case 242:
					num17 = 21 + 3;
					num2 = 371;
					continue;
				case 162:
					num21 = 158 - 45;
					num2 = 275;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 325;
					}
					continue;
				case 191:
					array[22] = (byte)num21;
					num2 = 90;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 173;
					}
					continue;
				case 343:
					array3[4] = 11;
					num2 = 100;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 52;
					}
					continue;
				case 50:
					num21 = 131 - 43;
					num = 372;
					break;
				case 183:
					array3[8] = (byte)num19;
					num2 = 136;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 236;
					}
					continue;
				case 14:
				case 199:
					P4PXTMWF2FL = D6MH59XhVpHMLxUNONtc(XWBuNfXhhLHk7uqEjqaB(array5, 0u));
					num2 = 112;
					continue;
				case 103:
					array[27] = 36;
					num2 = 73;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 52;
					}
					continue;
				case 86:
					array3[13] = 188;
					num2 = 57;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 70;
					}
					continue;
				case 398:
					array3[14] = (byte)num19;
					num2 = 128;
					continue;
				case 346:
					array[28] = (byte)num16;
					num2 = 220;
					continue;
				case 78:
					num21 = 194 + 38;
					num2 = 310;
					continue;
				case 52:
					num16 = 119 - 65;
					num2 = 63;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 56;
					}
					continue;
				case 228:
					num21 = 29 + 108;
					num = 185;
					break;
				case 240:
					array[1] = 94;
					num2 = 300;
					continue;
				case 90:
					array[6] = (byte)num21;
					num2 = 283;
					continue;
				case 345:
					array[20] = (byte)num21;
					num2 = 145;
					continue;
				case 127:
					array3[0] = 39;
					num2 = 122;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 39;
					}
					continue;
				case 1:
					array3[12] = (byte)num19;
					num2 = 148;
					continue;
				case 175:
					array[23] = (byte)num21;
					num2 = 10;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 24;
					}
					continue;
				case 146:
					array5 = array6;
					num2 = 225;
					continue;
				case 121:
					array6[num29 + 3] = (byte)((num32 & 0xFF000000u) >> 24);
					num2 = 314;
					continue;
				case 23:
					array3[9] = (byte)num17;
					num = 21;
					break;
				case 43:
					try
					{
						KswPbhXhCSkCPbllwhsq(deflateStream, memoryStream);
						int num34 = 0;
						if (osqowQXhIE733O0fL3iF() == null)
						{
							num34 = 0;
						}
						switch (num34)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							int num35 = 1;
							if (!mJC32KXhqO01uAYO098H())
							{
								num35 = 0;
							}
							while (true)
							{
								switch (num35)
								{
								case 1:
									LHfDuUXhrrMNDl6aBG3W(deflateStream);
									num35 = 0;
									if (mJC32KXhqO01uAYO098H())
									{
										num35 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 288;
				case 80:
					num16 = 244 - 81;
					num2 = 1;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 2;
					}
					continue;
				case 110:
					array[12] = 162;
					num2 = 78;
					continue;
				case 46:
					array[8] = (byte)num21;
					num2 = 303;
					continue;
				case 376:
					num4 = 0u;
					num2 = 223;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 395;
					}
					continue;
				case 303:
					num16 = 197 - 65;
					num2 = 319;
					continue;
				case 385:
					array3[13] = (byte)num19;
					num = 85;
					break;
				case 38:
					array3[7] = (byte)num19;
					num2 = 159;
					continue;
				case 402:
					array[21] = (byte)num21;
					num2 = 10;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 47;
					}
					continue;
				case 11:
					array[19] = (byte)num21;
					num = 200;
					break;
				case 354:
					num17 = 134 - 44;
					num2 = 380;
					continue;
				case 66:
					array[14] = 130;
					num2 = 168;
					continue;
				case 293:
					array[9] = (byte)num16;
					num2 = 205;
					continue;
				case 328:
					array[24] = (byte)num16;
					num2 = 160;
					continue;
				case 202:
					num16 = 182 - 60;
					num2 = 135;
					continue;
				case 239:
					array[5] = 168;
					num2 = 88;
					continue;
				case 154:
					array3[12] = (byte)num19;
					num2 = 324;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 14;
					}
					continue;
				case 67:
					array[24] = 156;
					num2 = 19;
					continue;
				case 397:
					array3[5] = 93;
					num2 = 356;
					continue;
				case 399:
					array[31] = 4;
					num2 = 35;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 37;
					}
					continue;
				case 104:
					array3[0] = 91;
					num2 = 317;
					continue;
				case 247:
					num21 = 193 - 64;
					num = 129;
					break;
				case 207:
					num17 = 14 + 7;
					num2 = 48;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 257;
					}
					continue;
				case 62:
					num16 = 100 + 80;
					num2 = 111;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 86;
					}
					continue;
				case 377:
					num16 = 47 + 9;
					num = 214;
					break;
				case 319:
					array[8] = (byte)num16;
					num2 = 137;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 170;
					}
					continue;
				case 132:
					if (num15 > 0)
					{
						num2 = 29;
						if (!mJC32KXhqO01uAYO098H())
						{
							num2 = 11;
						}
						continue;
					}
					goto case 375;
				case 342:
					array[9] = 124;
					num = 252;
					break;
				case 87:
					num17 = 198 + 19;
					num2 = 20;
					continue;
				case 195:
					array3[3] = 106;
					num2 = 60;
					continue;
				case 392:
					num25 = 0u;
					num2 = 30;
					continue;
				case 304:
					array[22] = (byte)num16;
					num = 61;
					break;
				case 5:
					array3[14] = 100;
					num2 = 340;
					continue;
				case 139:
					array[29] = 48;
					num2 = 28;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 247;
					}
					continue;
				case 224:
					array[18] = (byte)num21;
					num2 = 134;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 100;
					}
					continue;
				case 368:
					array3[7] = 124;
					num2 = 289;
					continue;
				case 91:
					num21 = 237 - 79;
					num = 212;
					break;
				case 196:
					num17 = 42 + 43;
					num2 = 184;
					continue;
				case 348:
					array[15] = (byte)num16;
					num = 151;
					break;
				case 355:
					array3[2] = (byte)num17;
					num2 = 337;
					continue;
				case 227:
					array3[4] = (byte)num17;
					num2 = 217;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 197;
					}
					continue;
				case 383:
					array[18] = 142;
					num2 = 125;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 1;
					}
					continue;
				case 340:
					array3[14] = 139;
					num2 = 339;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 194;
					}
					continue;
				case 205:
					array[9] = 147;
					num = 284;
					break;
				case 40:
					h5eCOjXTYRdoELpYcijW = new T2OXZhXtXqRemtkpvtX8.H5eCOjXTYRdoELpYcijW((Stream)OWA3gHXhtPT374aKgFfS(xhNHnrXhWab90QJmgn3c(typeof(T2OXZhXtXqRemtkpvtX8).TypeHandle).Assembly, T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-44540535 ^ -44541021)));
					num2 = 102;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 234;
					}
					continue;
				case 261:
					array[24] = 218;
					num2 = 361;
					continue;
				case 71:
					num16 = 125 - 41;
					num2 = 74;
					continue;
				case 28:
					array3[1] = (byte)num19;
					num = 140;
					break;
				case 231:
					num15 = array2.Length % 4;
					num2 = 35;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 26;
					}
					continue;
				case 233:
					array[26] = 156;
					num2 = 174;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 140;
					}
					continue;
				case 289:
					array3[7] = 158;
					num = 323;
					break;
				case 144:
					num27 = 0;
					num = 264;
					break;
				case 49:
					array[4] = 108;
					num2 = 120;
					continue;
				case 356:
					num17 = 235 - 78;
					num2 = 272;
					continue;
				case 213:
					num26 = num22 % num31;
					num2 = 68;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 172;
					}
					continue;
				case 39:
					array[18] = (byte)num16;
					num2 = 390;
					continue;
				case 315:
					array[28] = 102;
					num2 = 267;
					continue;
				case 271:
					num37 = 1;
					num2 = 42;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 102;
					}
					continue;
				case 217:
					num17 = 110 + 105;
					num = 108;
					break;
				case 306:
					num20++;
					num2 = 150;
					continue;
				case 158:
					array3[3] = (byte)num19;
					num2 = 33;
					continue;
				case 152:
					array[1] = 128;
					num2 = 384;
					continue;
				case 41:
					if (!gpyXTOwTlIi)
					{
						num2 = 40;
						if (!mJC32KXhqO01uAYO098H())
						{
							num2 = 31;
						}
						continue;
					}
					return;
				case 396:
					array6[num29 + num30] = (byte)((num33 & num36) >> num27);
					num2 = 97;
					continue;
				case 81:
					num16 = 59 + 39;
					num2 = 293;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 40;
					}
					continue;
				case 225:
					if (num37 == 0)
					{
						num2 = 279;
						continue;
					}
					goto case 179;
				case 236:
					array3[9] = 112;
					num2 = 223;
					continue;
				case 70:
					array3[13] = 167;
					num2 = 89;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 75;
					}
					continue;
				case 258:
					if (num15 > 0)
					{
						num = 305;
						break;
					}
					goto case 189;
				case 285:
					array3[5] = (byte)num19;
					num2 = 216;
					continue;
				case 44:
					array[7] = 154;
					num2 = 0;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 13;
					}
					continue;
				case 283:
					array[6] = 91;
					num2 = 203;
					continue;
				case 262:
					num21 = 15 + 115;
					num2 = 191;
					continue;
				case 85:
					array3[13] = 63;
					num2 = 68;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 86;
					}
					continue;
				case 292:
					array[14] = (byte)num16;
					num2 = 66;
					continue;
				case 82:
					num16 = 78 + 10;
					num2 = 270;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 54;
					}
					continue;
				case 141:
					array3[6] = 109;
					num2 = 177;
					continue;
				case 201:
					array[10] = (byte)num16;
					num2 = 350;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 212;
					}
					continue;
				case 276:
					array[23] = 95;
					num2 = 378;
					continue;
				case 404:
					array[19] = 88;
					num2 = 17;
					continue;
				case 241:
					array6[num29] = (byte)(num32 & 0xFF);
					num2 = 174;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 192;
					}
					continue;
				case 171:
					array[15] = (byte)num16;
					num2 = 386;
					continue;
				case 339:
					num19 = 133 + 108;
					num2 = 398;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 113;
					}
					continue;
				case 181:
					num19 = 68 - 49;
					num = 322;
					break;
				case 216:
					num17 = 218 - 72;
					num2 = 209;
					continue;
				case 370:
					num36 = 255u;
					num2 = 144;
					continue;
				case 150:
				case 349:
					if (num20 >= num15)
					{
						num2 = 219;
						continue;
					}
					goto case 130;
				case 102:
					num24 = 0;
					num2 = 204;
					continue;
				case 197:
					array[3] = 147;
					num2 = 248;
					continue;
				case 238:
					array[20] = (byte)num16;
					num2 = 190;
					continue;
				case 229:
					array8 = (byte[])sjLeJ0XhZhugxtTYgkV2(h5eCOjXTYRdoELpYcijW, (int)sfuBZsXhyhstvccX4SJZ(Uiu9n0XhUOH8RdYwMZZJ(h5eCOjXTYRdoELpYcijW)));
					num2 = 165;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 338;
					}
					continue;
				case 244:
					array[11] = 96;
					num2 = 29;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 50;
					}
					continue;
				case 137:
					array[23] = (byte)num16;
					num2 = 3;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 15;
					}
					continue;
				case 252:
					num16 = 85 + 27;
					num2 = 27;
					continue;
				case 143:
					array3[15] = (byte)num19;
					num2 = 389;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 279;
					}
					continue;
				case 131:
					num19 = 163 - 54;
					num2 = 68;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 93;
					}
					continue;
				case 388:
					num23++;
					num2 = 392;
					continue;
				case 401:
					array2 = array8;
					num2 = 117;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 231;
					}
					continue;
				case 151:
					array[16] = 59;
					num2 = 235;
					continue;
				case 59:
					array3[0] = (byte)num19;
					num2 = 56;
					continue;
				case 215:
					array6[num29 + 2] = (byte)((num32 & 0xFF0000) >> 16);
					num2 = 121;
					continue;
				case 3:
					num16 = 37 + 49;
					num = 292;
					break;
				case 329:
					array[3] = (byte)num16;
					num2 = 49;
					continue;
				case 93:
					array3[8] = (byte)num19;
					num2 = 10;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 9;
					}
					continue;
				case 335:
					array3[1] = (byte)num17;
					num2 = 282;
					continue;
				case 37:
					array7 = array;
					num2 = 75;
					continue;
				case 386:
					array[15] = 138;
					num2 = 331;
					continue;
				case 54:
					itXwLDXhmQNVIy14Mfbj(memoryStream);
					num2 = 92;
					continue;
				case 299:
					array[24] = 113;
					num2 = 67;
					continue;
				case 234:
					upK63SXhT4mnD4Hf0kqk(Uiu9n0XhUOH8RdYwMZZJ(h5eCOjXTYRdoELpYcijW), 0L);
					num2 = 245;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 205;
					}
					continue;
				case 263:
					array[14] = (byte)num21;
					num2 = 80;
					continue;
				case 92:
				case 112:
				case 153:
					mF9XT6gUiLI = (string[])OE83fQXhwFSECUPsV4Op((Assembly)P4PXTMWF2FL);
					num2 = 341;
					continue;
				case 120:
					array[4] = 157;
					num = 126;
					break;
				case 31:
					num28 = (uint)((array7[num25 + 3] << 24) | (array7[num25 + 2] << 16) | (array7[num25 + 1] << 8) | array7[num25]);
					num2 = 20;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 370;
					}
					continue;
				case 214:
					array[0] = (byte)num16;
					num2 = 50;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 52;
					}
					continue;
				case 165:
					array3[11] = 196;
					num2 = 8;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 3;
					}
					continue;
				case 391:
					memoryStream = new MemoryStream();
					num2 = 336;
					continue;
				case 268:
					array4 = array3;
					num2 = 271;
					continue;
				case 350:
					array[10] = 48;
					num2 = 244;
					continue;
				case 119:
					num16 = 19 + 90;
					num2 = 304;
					continue;
				case 89:
					num19 = 213 + 17;
					num2 = 193;
					continue;
				case 246:
				case 367:
					if (num30 >= num15)
					{
						num = 358;
						break;
					}
					goto case 316;
				case 167:
					num17 = 175 - 58;
					num2 = 2;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 53;
					}
					continue;
				case 61:
					num21 = 123 + 43;
					num2 = 0;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 0;
					}
					continue;
				case 325:
					array[17] = (byte)num21;
					num2 = 123;
					continue;
				case 35:
					num23 = array2.Length / 4;
					num2 = 58;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 188;
					}
					continue;
				case 389:
					num17 = 221 - 73;
					num2 = 180;
					continue;
				case 113:
					array[0] = (byte)num21;
					num2 = 51;
					continue;
				case 256:
					num21 = 248 - 82;
					num2 = 164;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 140;
					}
					continue;
				case 381:
					num16 = 162 - 54;
					num2 = 259;
					continue;
				case 322:
					array3[3] = (byte)num19;
					num2 = 242;
					continue;
				case 210:
					array[5] = 252;
					num = 254;
					break;
				case 235:
					num16 = 222 - 74;
					num2 = 334;
					continue;
				case 157:
					array[8] = (byte)num16;
					num = 81;
					break;
				case 125:
					num16 = 81 + 21;
					num2 = 25;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 39;
					}
					continue;
				case 24:
					array[23] = 57;
					num = 166;
					break;
				case 74:
					array[24] = (byte)num16;
					num2 = 299;
					continue;
				case 375:
					num25 = (uint)num29;
					num = 65;
					break;
				case 2:
					array[14] = (byte)num16;
					num2 = 100;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 101;
					}
					continue;
				case 363:
					array3[1] = (byte)num17;
					num2 = 40;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 291;
					}
					continue;
				case 189:
					num32 = num4 ^ num18;
					num2 = 96;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 241;
					}
					continue;
				case 140:
					array3[2] = 156;
					num2 = 206;
					continue;
				case 313:
					array3[10] = 176;
					num = 6;
					break;
				case 75:
					array3 = new byte[16];
					num2 = 222;
					continue;
				case 160:
					num16 = 151 - 50;
					num2 = 290;
					continue;
				case 138:
					array[2] = 87;
					num2 = 237;
					continue;
				case 362:
					num16 = 111 - 40;
					num = 329;
					break;
				case 302:
					num36 <<= 8;
					num2 = 63;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 274;
					}
					continue;
				case 365:
					array[30] = 171;
					num2 = 155;
					continue;
				case 308:
					num21 = 150 - 103;
					num2 = 77;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 232;
					}
					continue;
				case 279:
				case 403:
					P4PXTMWF2FL = D6MH59XhVpHMLxUNONtc(array5);
					num2 = 153;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 108;
					}
					continue;
				case 42:
					array[22] = 200;
					num2 = 119;
					continue;
				case 226:
					array3[14] = 109;
					num2 = 5;
					continue;
				case 326:
					array[15] = (byte)num16;
					num = 182;
					break;
				case 18:
					num21 = 123 + 72;
					num2 = 402;
					continue;
				case 281:
					num17 = 88 + 11;
					num2 = 286;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 282;
					}
					continue;
				case 156:
					array[8] = (byte)num21;
					num = 295;
					break;
				case 314:
				case 358:
					num22++;
					num2 = 22;
					continue;
				case 136:
					array3[6] = (byte)num19;
					num2 = 354;
					continue;
				case 108:
					array3[4] = (byte)num17;
					num2 = 266;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 227;
					}
					continue;
				case 148:
					array3[13] = 142;
					num2 = 393;
					continue;
				case 255:
					array[1] = (byte)num21;
					num2 = 60;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 152;
					}
					continue;
				case 83:
					array[12] = 119;
					num2 = 14;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 110;
					}
					continue;
				case 8:
					num19 = 118 + 17;
					num = 154;
					break;
				case 77:
					array3[9] = (byte)num17;
					num2 = 298;
					continue;
				case 174:
					array[26] = 22;
					num2 = 20;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 228;
					}
					continue;
				case 30:
					num22 = 0;
					num2 = 373;
					continue;
				case 118:
					array[0] = 148;
					num = 96;
					break;
				case 20:
					array3[15] = (byte)num17;
					num2 = 268;
					continue;
				case 270:
					array[3] = (byte)num16;
					num2 = 362;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 208;
					}
					continue;
				case 301:
					num21 = 49 + 123;
					num2 = 247;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 353;
					}
					continue;
				case 64:
					array[12] = 21;
					num2 = 83;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 46;
					}
					continue;
				case 99:
					array[12] = (byte)num21;
					num2 = 344;
					continue;
				case 27:
					array[10] = (byte)num16;
					num = 36;
					break;
				case 76:
					num30 = 0;
					num2 = 246;
					continue;
				case 266:
					array3[4] = 106;
					num2 = 352;
					continue;
				case 284:
					num16 = 33 + 90;
					num2 = 178;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 27;
					}
					continue;
				case 223:
					array3[9] = 126;
					num2 = 243;
					continue;
				case 305:
					num33 = num4 ^ num18;
					num2 = 76;
					continue;
				case 318:
					array3[5] = 133;
					num2 = 397;
					continue;
				case 298:
					array3[10] = 118;
					num2 = 364;
					continue;
				case 34:
					num21 = 93 - 11;
					num2 = 12;
					continue;
				case 264:
					if (num22 == num23 - 1)
					{
						num2 = 99;
						if (mJC32KXhqO01uAYO098H())
						{
							num2 = 132;
						}
						continue;
					}
					goto case 375;
				case 182:
					num16 = 223 - 74;
					num2 = 171;
					continue;
				case 21:
					num17 = 112 + 103;
					num2 = 77;
					continue;
				case 192:
					array6[num29 + 1] = (byte)((num32 & 0xFF00) >> 8);
					num2 = 215;
					continue;
				case 142:
					num16 = 0 + 85;
					num2 = 296;
					continue;
				case 265:
					array[25] = 90;
					num2 = 202;
					continue;
				case 166:
					num21 = 173 - 57;
					num2 = 211;
					continue;
				case 222:
					num19 = 103 + 45;
					num = 278;
					break;
				case 147:
					num19 = 147 - 49;
					num2 = 230;
					continue;
				case 341:
					gpyXTOwTlIi = true;
					num2 = 0;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 4;
					}
					continue;
				case 393:
					num19 = 57 + 4;
					num2 = 385;
					continue;
				case 116:
					array3[6] = 99;
					num2 = 94;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 48;
					}
					continue;
				case 390:
					num21 = 38 + 100;
					num2 = 224;
					continue;
				case 60:
					num19 = 49 + 123;
					num2 = 158;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 64;
					}
					continue;
				case 123:
					array[18] = 127;
					num2 = 78;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 383;
					}
					continue;
				case 130:
					if (num20 > 0)
					{
						num2 = 59;
						if (osqowQXhIE733O0fL3iF() == null)
						{
							num2 = 133;
						}
						continue;
					}
					goto case 327;
				case 337:
					array3[3] = 87;
					num2 = 194;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 67;
					}
					continue;
				case 47:
					array[21] = 145;
					num2 = 246;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 308;
					}
					continue;
				case 135:
					array[26] = (byte)num16;
					num2 = 42;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 57;
					}
					continue;
				case 4:
					return;
				case 245:
					array5 = new byte[0];
					num = 229;
					break;
				case 395:
					num28 = 0u;
					num2 = 360;
					continue;
				case 111:
					array[17] = (byte)num16;
					num2 = 221;
					continue;
				case 98:
					array[22] = 227;
					num2 = 387;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 174;
					}
					continue;
				case 194:
					array3[3] = 149;
					num = 195;
					break;
				case 101:
					array[14] = 242;
					num2 = 31;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 69;
					}
					continue;
				case 294:
					num17 = 22 + 115;
					num2 = 355;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 76;
					}
					continue;
				case 105:
					array3[3] = (byte)num19;
					num2 = 181;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 95;
					}
					continue;
				case 330:
					array[9] = 168;
					num2 = 342;
					continue;
				case 353:
					array[3] = (byte)num21;
					num2 = 122;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 197;
					}
					continue;
				case 190:
					num21 = 30 + 69;
					num2 = 269;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 120;
					}
					continue;
				case 221:
					array[17] = 158;
					num2 = 162;
					continue;
				case 257:
					array3[10] = (byte)num17;
					num2 = 167;
					continue;
				case 260:
					array[22] = (byte)num21;
					num2 = 98;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 84;
					}
					continue;
				case 372:
					array[11] = (byte)num21;
					num2 = 68;
					continue;
				case 57:
					num16 = 218 - 72;
					num2 = 55;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 14;
					}
					continue;
				case 296:
					array[14] = (byte)num16;
					num2 = 3;
					continue;
				case 267:
					num16 = 30 - 6;
					num = 346;
					break;
				case 176:
					array3[12] = 90;
					num2 = 196;
					continue;
				case 155:
					array[30] = 69;
					num2 = 382;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 321;
					}
					continue;
				case 300:
					num21 = 91 + 92;
					num2 = 214;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 255;
					}
					continue;
				case 253:
					num17 = 98 + 11;
					num = 117;
					break;
				case 134:
					array[18] = 143;
					num2 = 28;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 404;
					}
					continue;
				case 286:
					array3[2] = (byte)num17;
					num = 294;
					break;
				case 323:
					num19 = 77 - 45;
					num2 = 38;
					continue;
				case 184:
					array3[12] = (byte)num17;
					num2 = 287;
					continue;
				case 344:
					num16 = 208 - 69;
					num2 = 400;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 129;
					}
					continue;
				case 88:
					array[5] = 126;
					num2 = 114;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 332;
					}
					continue;
				case 168:
					num21 = 108 + 79;
					num2 = 157;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 263;
					}
					continue;
				case 230:
					array3[5] = (byte)num19;
					num2 = 351;
					continue;
				case 94:
					array3[7] = 96;
					num2 = 368;
					continue;
				case 379:
					if (num22 == num23 - 1)
					{
						num2 = 258;
						continue;
					}
					goto case 189;
				case 164:
					array[5] = (byte)num21;
					num2 = 210;
					continue;
				case 333:
					num31 = array7.Length / 4;
					num2 = 376;
					continue;
				case 317:
					num19 = 159 - 53;
					num2 = 59;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 19;
					}
					continue;
				case 250:
					array[16] = 249;
					num2 = 62;
					continue;
				case 287:
					array3[12] = 140;
					num2 = 169;
					continue;
				case 273:
					array[1] = 113;
					num2 = 174;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 240;
					}
					continue;
				case 129:
					array[30] = (byte)num21;
					num2 = 199;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 309;
					}
					continue;
				case 331:
					num16 = 25 + 121;
					num2 = 90;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 348;
					}
					continue;
				case 10:
					num19 = 205 - 104;
					num2 = 183;
					continue;
				case 254:
					num21 = 147 - 49;
					num2 = 90;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 85;
					}
					continue;
				case 212:
					array[19] = (byte)num21;
					num2 = 307;
					continue;
				case 309:
					array[30] = 153;
					num2 = 365;
					continue;
				case 193:
					array3[13] = (byte)num19;
					num2 = 226;
					continue;
				case 16:
					num21 = 50 - 4;
					num2 = 58;
					continue;
				case 36:
					num16 = 196 - 65;
					num2 = 201;
					continue;
				case 65:
					num4 += num28;
					num2 = 7;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 26;
					}
					continue;
				case 97:
					num30++;
					num2 = 80;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 367;
					}
					continue;
				case 188:
					array6 = new byte[array2.Length];
					num2 = 333;
					continue;
				case 33:
					num19 = 91 + 59;
					num2 = 105;
					continue;
				case 366:
					if (num15 > 0)
					{
						num2 = 312;
						if (osqowQXhIE733O0fL3iF() == null)
						{
							num2 = 388;
						}
						continue;
					}
					goto case 392;
				case 364:
					array3[10] = 139;
					num2 = 207;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 70;
					}
					continue;
				case 187:
					array7[num24] ^= array4[num24];
					num2 = 107;
					continue;
				case 53:
					array3[10] = (byte)num17;
					num2 = 313;
					continue;
				case 338:
					array = new byte[32];
					num2 = 118;
					continue;
				case 72:
					array3[6] = 187;
					num2 = 47;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 141;
					}
					continue;
				case 185:
					array[27] = (byte)num21;
					num = 25;
					break;
				case 336:
					deflateStream = new DeflateStream(new MemoryStream(array5), CompressionMode.Decompress);
					num2 = 43;
					continue;
				case 51:
					array[0] = 137;
					num2 = 381;
					continue;
				case 170:
					num16 = 169 + 17;
					num2 = 157;
					continue;
				case 357:
					array3[4] = (byte)num19;
					num2 = 318;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 227;
					}
					continue;
				case 115:
					num16 = 65 + 105;
					num = 374;
					break;
				case 290:
					array[25] = (byte)num16;
					num2 = 208;
					continue;
				case 13:
					array[7] = 161;
					num2 = 16;
					continue;
				case 45:
					num21 = 179 - 59;
					num2 = 345;
					continue;
				case 68:
					array[11] = 81;
					num2 = 249;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 211;
					}
					continue;
				case 380:
					array3[6] = (byte)num17;
					num2 = 73;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 116;
					}
					continue;
				default:
					array[22] = (byte)num21;
					num2 = 80;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 262;
					}
					continue;
				case 400:
					array[12] = (byte)num16;
					num2 = 64;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 16;
					}
					continue;
				case 95:
					array[29] = 98;
					num = 139;
					break;
				case 269:
					array[21] = (byte)num21;
					num2 = 18;
					continue;
				case 307:
					num21 = 141 - 24;
					num2 = 11;
					continue;
				case 172:
					num29 = num22 * 4;
					num2 = 320;
					continue;
				case 198:
					array[13] = 42;
					num2 = 114;
					continue;
				case 109:
					num4 += num28;
					num = 79;
					break;
				case 179:
					if (num37 != 1)
					{
						num2 = 199;
						continue;
					}
					goto case 391;
				case 9:
					num16 = 118 + 60;
					num2 = 297;
					continue;
				case 361:
					num16 = 130 - 66;
					num2 = 328;
					continue;
				case 84:
					array[2] = (byte)num16;
					num2 = 62;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 138;
					}
					continue;
				case 159:
					array3[8] = 107;
					num2 = 131;
					continue;
				case 378:
					num16 = 7 + 51;
					num2 = 137;
					continue;
				case 128:
					array3[15] = 115;
					num2 = 347;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 278;
					}
					continue;
				case 209:
					array3[6] = (byte)num17;
					num2 = 72;
					continue;
				case 384:
					array[1] = 121;
					num2 = 34;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 32;
					}
					continue;
				case 149:
					array3[1] = (byte)num19;
					num2 = 280;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 166;
					}
					continue;
				case 145:
					array[20] = 144;
					num2 = 163;
					continue;
				case 274:
					num27 += 8;
					num2 = 265;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 396;
					}
					continue;
				case 295:
					num21 = 127 - 42;
					num2 = 46;
					continue;
				case 291:
					num19 = 199 - 91;
					num2 = 28;
					continue;
				case 297:
					array[31] = (byte)num16;
					num = 7;
					break;
				case 19:
					array[24] = 33;
					num2 = 261;
					continue;
				case 63:
					array[0] = (byte)num16;
					num2 = 273;
					continue;
				case 320:
					num25 = (uint)(num26 * 4);
					num2 = 31;
					continue;
				case 48:
					num21 = 181 - 60;
					num2 = 156;
					continue;
				case 249:
					num21 = 3 + 115;
					num2 = 65;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 99;
					}
					continue;
				case 180:
					array3[15] = (byte)num17;
					num2 = 87;
					continue;
				case 310:
					array[12] = (byte)num21;
					num2 = 92;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 198;
					}
					continue;
				case 55:
					array[26] = (byte)num16;
					num2 = 233;
					continue;
				case 312:
					array[13] = (byte)num21;
					num2 = 394;
					continue;
				case 96:
					num21 = 156 - 52;
					num2 = 113;
					continue;
				case 371:
					array3[4] = (byte)num17;
					num2 = 90;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 343;
					}
					continue;
				case 25:
					array[27] = 127;
					num2 = 70;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 251;
					}
					continue;
				case 316:
					if (num30 > 0)
					{
						num2 = 302;
						continue;
					}
					goto case 396;
				case 203:
					array[6] = 77;
					num2 = 44;
					continue;
				case 73:
					array[28] = 151;
					num2 = 218;
					continue;
				case 218:
					array[28] = 122;
					num2 = 315;
					continue;
				case 288:
					P4PXTMWF2FL = D6MH59XhVpHMLxUNONtc(TC961hXhKoaHYtkJyGrC(memoryStream));
					num2 = 54;
					continue;
				case 122:
					num17 = 65 + 73;
					num2 = 335;
					continue;
				case 178:
					array[9] = (byte)num16;
					num2 = 330;
					continue;
				case 211:
					array[23] = (byte)num21;
					num2 = 276;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 253;
					}
					continue;
				case 22:
				case 373:
					if (num22 >= num23)
					{
						num2 = 146;
						continue;
					}
					goto case 213;
				case 232:
					array[21] = (byte)num21;
					num2 = 42;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 32;
					}
					continue;
				case 237:
					array[2] = 128;
					num2 = 311;
					continue;
				case 58:
					array[7] = (byte)num21;
					num2 = 48;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 41;
					}
					continue;
				case 29:
					num18 = 0u;
					num2 = 109;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 68;
					}
					continue;
				case 100:
					num17 = 179 - 59;
					num2 = 227;
					continue;
				case 387:
					num21 = 101 + 35;
					num2 = 175;
					continue;
				case 173:
					num21 = 34 + 31;
					num2 = 260;
					continue;
				case 79:
					num20 = 0;
					num2 = 349;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 202;
					}
					continue;
				case 251:
					array[27] = 106;
					num2 = 103;
					continue;
				case 347:
					num19 = 190 - 63;
					num2 = 143;
					continue;
				case 332:
					num16 = 18 + 105;
					num2 = 13;
					if (osqowQXhIE733O0fL3iF() == null)
					{
						num2 = 106;
					}
					continue;
				case 324:
					array3[12] = 84;
					num = 176;
					break;
				case 206:
					array3[2] = 164;
					num2 = 281;
					continue;
				case 280:
					num17 = 141 - 47;
					num2 = 186;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 363;
					}
					continue;
				case 133:
					num18 <<= 8;
					num2 = 327;
					if (osqowQXhIE733O0fL3iF() != null)
					{
						num2 = 142;
					}
					continue;
				case 106:
					array[5] = (byte)num16;
					num2 = 256;
					continue;
				case 360:
					num18 = 0u;
					num2 = 366;
					continue;
				case 186:
					array3[5] = 237;
					num = 147;
					break;
				case 272:
					array3[5] = (byte)num17;
					num2 = 186;
					continue;
				case 259:
					array[0] = (byte)num16;
					num2 = 25;
					if (mJC32KXhqO01uAYO098H())
					{
						num2 = 377;
					}
					continue;
				case 161:
				case 219:
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
					num2 = 379;
					if (!mJC32KXhqO01uAYO098H())
					{
						num2 = 91;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] WKdXTgQivYf(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554476)).Assembly)
		{
			if (!gpyXTOwTlIi)
			{
				a5FXTdJuk9r();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)P4PXTMWF2FL).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly iLRXTR2jSV6(object P_0, ResolveEventArgs P_1)
	{
		if (!gpyXTOwTlIi)
		{
			a5FXTdJuk9r();
		}
		string name = P_1.Name;
		for (int i = 0; i < mF9XT6gUiLI.Length; i++)
		{
			if (mF9XT6gUiLI[i] == name)
			{
				return (Assembly)P4PXTMWF2FL;
			}
		}
		return null;
	}

	public opEHbQXTjwOP89DtxKKp()
	{
		AppDomain.CurrentDomain.ResourceResolve += iLRXTR2jSV6;
		ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!gZnXTqkoxSu)
		{
			gZnXTqkoxSu = true;
			new opEHbQXTjwOP89DtxKKp();
		}
	}

	internal static Type xhNHnrXhWab90QJmgn3c(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object OWA3gHXhtPT374aKgFfS(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object Uiu9n0XhUOH8RdYwMZZJ(object P_0)
	{
		return ((T2OXZhXtXqRemtkpvtX8.H5eCOjXTYRdoELpYcijW)P_0).m9OIO8Q0EK();
	}

	internal static void upK63SXhT4mnD4Hf0kqk(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long sfuBZsXhyhstvccX4SJZ(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object sjLeJ0XhZhugxtTYgkV2(object P_0, int P_1)
	{
		return ((T2OXZhXtXqRemtkpvtX8.H5eCOjXTYRdoELpYcijW)P_0).OD7XTooLu0b(P_1);
	}

	internal static object D6MH59XhVpHMLxUNONtc(object P_0)
	{
		return P6wiLtXTWooyjBUAV3Sq.AZqXTKqHcU5((byte[])P_0);
	}

	internal static void KswPbhXhCSkCPbllwhsq(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void LHfDuUXhrrMNDl6aBG3W(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object TC961hXhKoaHYtkJyGrC(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void itXwLDXhmQNVIy14Mfbj(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object XWBuNfXhhLHk7uqEjqaB(object P_0, uint P_1)
	{
		return P6wiLtXTWooyjBUAV3Sq.d9PXTmyNf0n((byte[])P_0, P_1);
	}

	internal static object OE83fQXhwFSECUPsV4Op(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool mJC32KXhqO01uAYO098H()
	{
		return (object)null == null;
	}

	internal static object osqowQXhIE733O0fL3iF()
	{
		return null;
	}
}
