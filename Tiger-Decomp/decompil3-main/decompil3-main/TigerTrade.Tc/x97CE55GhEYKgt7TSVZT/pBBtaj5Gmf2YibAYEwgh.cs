using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using RRGeI95GVMJEHGH0bnkl;

namespace x97CE55GhEYKgt7TSVZT;

internal class pBBtaj5Gmf2YibAYEwgh
{
	private enum gbp6uZ5GpyFdAGqLNrco
	{

	}

	internal class BI0Sc95GuGJ4uDB0DLxh
	{
		private unsafe static uint Dt05GzbtRwf(void* P_0, uint P_1)
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

		private unsafe static bool uIQ5Y0fK4S3(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void BuM5Y2gL8fX(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void YFf5YHAklMj(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void Ris5YfFRLpn(byte* P_0, byte* P_1, uint P_2)
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
				YFf5YHAklMj(P_0, P_1, P_2);
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

		private unsafe static uint Vk95Y90be2V(byte[] P_0, uint P_1, gbp6uZ5GpyFdAGqLNrco P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint gyE5YnLoRHr(byte[] P_0, uint P_1)
		{
			return Vk95Y90be2V(P_0, P_1, (gbp6uZ5GpyFdAGqLNrco)3);
		}

		private unsafe static uint BEg5YG4vSAF(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + Dt05GzbtRwf(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16];
					gEsQm0LOydM7TXdrtEkl(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					uint[] array2 = array;
					byte* ptr8 = ptr7 - 4;
					if (Dt05GzbtRwf(ptr6 + 4, 4u) != 1)
					{
						YFf5YHAklMj(ptr2, ptr3 + num, Dt05GzbtRwf(ptr6 + 3, 4u));
						return Dt05GzbtRwf(ptr6 + 3, 4u);
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
							num2 = Dt05GzbtRwf(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = Dt05GzbtRwf(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								Ris5YfFRLpn(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								Ris5YfFRLpn(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								Ris5YfFRLpn(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								Ris5YfFRLpn(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								Ris5YfFRLpn(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								BuM5Y2gL8fX(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							Ris5YfFRLpn(ptr5, ptr4, 4u);
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

		internal static object Q835YYfKgZR(byte[] P_0)
		{
			return Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777374)).GetMethod(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-617064403 ^ -616927147).Trim(), new Type[1] { typeof(byte[]) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] Q775YoumpVZ(byte[] P_0, uint P_1)
		{
			uint num = gyE5YnLoRHr(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				WhpmhJLOZ8uKZg6uGwvU(P_0, P_1, array);
			}
			return array;
		}

		internal static void gEsQm0LOydM7TXdrtEkl(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static uint WhpmhJLOZ8uKZg6uGwvU(object P_0, uint P_1, object P_2)
		{
			return BEg5YG4vSAF((byte[])P_0, P_1, (byte[])P_2);
		}
	}

	private static string[] GfG5GP1yDyr = new string[0];

	private static object kJh5GJjmm7n = null;

	private static bool Eye5GF9Kb65 = false;

	private static bool Sx05G3JqqoK = false;

	private static void bD35G7JxY5H()
	{
		int num = 226;
		int num23 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num15 = default(int);
		int num16 = default(int);
		uint num24 = default(uint);
		int num17 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array6 = default(byte[]);
		int num18 = default(int);
		int num37 = default(int);
		int num34 = default(int);
		uint num26 = default(uint);
		byte[] array5 = default(byte[]);
		uint num19 = default(uint);
		int num30 = default(int);
		byte[] array8 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num32 = default(int);
		int num22 = default(int);
		uint num33 = default(uint);
		int num20 = default(int);
		int num25 = default(int);
		byte[] array7 = default(byte[]);
		int num21 = default(int);
		uint num35 = default(uint);
		uint num31 = default(uint);
		int num36 = default(int);
		int num27 = default(int);
		byte[] array3 = default(byte[]);
		F71m3059rTj4gyFcUtWX.dGLTKW5Gj2RRv85HF7Gu dGLTKW5Gj2RRv85HF7Gu = default(F71m3059rTj4gyFcUtWX.dGLTKW5Gj2RRv85HF7Gu);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 369:
					num23 = 97 + 119;
					num2 = 342;
					continue;
				case 382:
					array2[14] = 153;
					num2 = 312;
					continue;
				case 63:
					array[24] = 90;
					num2 = 151;
					continue;
				case 338:
					num15 = 190 - 63;
					num2 = 191;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 118;
					}
					continue;
				case 90:
					num16 = 104 + 81;
					num2 = 9;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 158;
					}
					continue;
				case 381:
					array2[3] = 84;
					num2 = 0;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 0;
					}
					continue;
				case 237:
					num16 = 61 + 28;
					num2 = 286;
					continue;
				case 257:
					array[1] = (byte)num16;
					num2 = 30;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 301;
					}
					continue;
				case 401:
					array[10] = 134;
					num2 = 188;
					continue;
				case 282:
					array[7] = 58;
					num2 = 207;
					continue;
				case 30:
					num16 = 247 - 82;
					num2 = 13;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 353;
					}
					continue;
				case 166:
					array[18] = (byte)num16;
					num2 = 135;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 97;
					}
					continue;
				case 181:
					array[30] = 119;
					num2 = 132;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 180;
					}
					continue;
				case 347:
					array2[1] = (byte)num23;
					num2 = 93;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 141;
					}
					continue;
				case 143:
					num15 = 136 - 45;
					num2 = 224;
					continue;
				case 337:
					num16 = 94 + 73;
					num2 = 273;
					continue;
				case 124:
					array[20] = 238;
					num2 = 237;
					continue;
				case 167:
					array[28] = (byte)num16;
					num2 = 26;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 11;
					}
					continue;
				case 6:
					num24 = 0u;
					num2 = 41;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 120;
					}
					continue;
				case 204:
					array2[12] = (byte)num17;
					num2 = 54;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 400;
					}
					continue;
				case 159:
					num15 = 64 + 53;
					num2 = 161;
					continue;
				case 249:
					try
					{
						jteY6m51ejGVGjS3gdE6(deflateStream, memoryStream);
						int num28 = 0;
						if (!teyBV551DToEaVNvXNds())
						{
							num28 = 0;
						}
						switch (num28)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							int num29 = 0;
							if (teyBV551DToEaVNvXNds())
							{
								num29 = 0;
							}
							while (true)
							{
								switch (num29)
								{
								default:
									WlRxEF51sOfBWHmSkiPv(deflateStream);
									num29 = 0;
									if (teyBV551DToEaVNvXNds())
									{
										num29 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 241;
				case 187:
					array6 = new byte[0];
					num2 = 199;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 386;
					}
					continue;
				case 27:
					array2[14] = 47;
					num2 = 366;
					continue;
				case 8:
				case 329:
					if (num18 >= num37)
					{
						num2 = 43;
						if (teyBV551DToEaVNvXNds())
						{
							num2 = 61;
						}
						continue;
					}
					goto case 138;
				case 152:
					array[25] = 219;
					num2 = 54;
					continue;
				case 365:
					array[6] = (byte)num16;
					num2 = 359;
					continue;
				case 330:
					array2[8] = (byte)num17;
					num = 175;
					break;
				case 15:
					num18 = 0;
					num2 = 329;
					continue;
				case 199:
					array[11] = 112;
					num2 = 361;
					continue;
				case 208:
					array2[4] = 98;
					num2 = 285;
					continue;
				case 41:
					array2[0] = (byte)num23;
					num2 = 182;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 182;
					}
					continue;
				case 268:
					num34 = 0;
					num2 = 147;
					continue;
				case 342:
					array2[10] = (byte)num23;
					num2 = 32;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 83;
					}
					continue;
				case 107:
					num23 = 193 - 64;
					num2 = 41;
					continue;
				case 248:
					array[1] = 225;
					num2 = 43;
					continue;
				case 39:
					num17 = 94 + 27;
					num2 = 4;
					continue;
				case 164:
					array[21] = 148;
					num2 = 111;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 100;
					}
					continue;
				case 188:
					num15 = 74 - 20;
					num2 = 211;
					continue;
				case 296:
					array2[4] = (byte)num23;
					num = 208;
					break;
				case 373:
					array[21] = 227;
					num2 = 354;
					continue;
				case 275:
					array2[15] = (byte)num17;
					num2 = 78;
					continue;
				case 241:
					kJh5GJjmm7n = P17IWW51LOCTb66ahW8T(oohQas51X2np9SIS2oex(memoryStream));
					num2 = 28;
					continue;
				case 266:
					num26 = (uint)((array5[num19 + 3] << 24) | (array5[num19 + 2] << 16) | (array5[num19 + 1] << 8) | array5[num19]);
					num2 = 13;
					continue;
				case 137:
					array[10] = 102;
					num2 = 202;
					continue;
				case 280:
					array2[1] = 164;
					num2 = 230;
					continue;
				case 86:
					array5[num30] ^= array8[num30];
					num2 = 272;
					continue;
				case 333:
					array2[10] = 232;
					num2 = 369;
					continue;
				case 229:
					num24 |= array4[array4.Length - (1 + num18)];
					num2 = 278;
					continue;
				case 387:
					num16 = 144 - 48;
					num2 = 346;
					continue;
				case 106:
					array[12] = (byte)num16;
					num2 = 188;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 250;
					}
					continue;
				case 146:
					num32++;
					num = 245;
					break;
				case 150:
					num16 = 15 + 120;
					num2 = 14;
					continue;
				case 217:
					array[24] = 215;
					num = 367;
					break;
				case 341:
					Eye5GF9Kb65 = true;
					num2 = 223;
					continue;
				case 4:
					array2[12] = (byte)num17;
					num2 = 228;
					continue;
				case 301:
					array[1] = 137;
					num2 = 26;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 198;
					}
					continue;
				case 69:
					array[22] = (byte)num15;
					num = 140;
					break;
				case 5:
				case 356:
					num22++;
					num2 = 205;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 18;
					}
					continue;
				case 362:
					array[28] = (byte)num15;
					num2 = 338;
					continue;
				case 23:
					if (num37 > 0)
					{
						num2 = 101;
						continue;
					}
					goto case 292;
				case 200:
					array2[6] = 94;
					num2 = 371;
					continue;
				case 93:
					num33 <<= 8;
					num2 = 31;
					continue;
				case 142:
					num16 = 247 - 82;
					num2 = 75;
					continue;
				case 163:
					if (num37 > 0)
					{
						num2 = 18;
						if (!teyBV551DToEaVNvXNds())
						{
							num2 = 10;
						}
						continue;
					}
					goto case 47;
				case 176:
					array[31] = 52;
					num2 = 343;
					continue;
				case 13:
					num33 = 255u;
					num2 = 209;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 268;
					}
					continue;
				case 136:
					num15 = 140 + 111;
					num = 96;
					break;
				case 234:
					num15 = 154 - 51;
					num2 = 334;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 89;
					}
					continue;
				case 168:
					array[9] = (byte)num16;
					num2 = 137;
					continue;
				case 36:
					array[7] = (byte)num15;
					num2 = 282;
					continue;
				case 363:
					array[11] = (byte)num15;
					num2 = 269;
					continue;
				case 128:
					num20 = num22 % num25;
					num2 = 389;
					continue;
				case 21:
					array2[9] = (byte)num17;
					num2 = 308;
					continue;
				case 180:
					array[30] = 142;
					num2 = 150;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 108;
					}
					continue;
				case 197:
					array2[7] = (byte)num17;
					num2 = 258;
					continue;
				case 334:
					array[22] = (byte)num15;
					num2 = 319;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 299;
					}
					continue;
				case 267:
					array[4] = 45;
					num2 = 271;
					continue;
				case 240:
					num17 = 184 - 61;
					num2 = 105;
					continue;
				case 243:
					array[23] = (byte)num15;
					num = 260;
					break;
				case 313:
					array5 = array;
					num2 = 102;
					continue;
				case 108:
					array[18] = (byte)num15;
					num = 195;
					break;
				case 49:
					array7[num21] = (byte)(num35 & 0xFF);
					num2 = 10;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 0;
					}
					continue;
				case 209:
					array[11] = (byte)num16;
					num2 = 317;
					continue;
				case 305:
					array7[num21 + num32] = (byte)((num31 & num33) >> num34);
					num2 = 146;
					continue;
				case 271:
					array[5] = 144;
					num2 = 232;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 104;
					}
					continue;
				case 97:
					array[4] = (byte)num15;
					num2 = 287;
					continue;
				case 383:
					num15 = 231 - 77;
					num2 = 120;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 363;
					}
					continue;
				case 314:
					array[16] = 93;
					num2 = 399;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 122;
					}
					continue;
				case 18:
					num31 = num4 ^ num24;
					num2 = 315;
					continue;
				case 291:
					num30 = 0;
					num2 = 113;
					continue;
				case 238:
					num16 = 245 - 81;
					num2 = 365;
					continue;
				case 392:
					num4 = 0u;
					num2 = 196;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 256;
					}
					continue;
				case 84:
					array2[15] = (byte)num17;
					num2 = 115;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 160;
					}
					continue;
				case 358:
					array[12] = (byte)num16;
					num2 = 66;
					continue;
				case 310:
					num15 = 42 + 86;
					num2 = 194;
					continue;
				case 7:
					array[6] = 117;
					num2 = 0;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 17;
					}
					continue;
				case 48:
					array[16] = (byte)num16;
					num2 = 314;
					continue;
				case 366:
					array2[14] = 27;
					num2 = 344;
					continue;
				case 256:
					num26 = 0u;
					num2 = 6;
					continue;
				case 26:
					num15 = 127 + 81;
					num2 = 362;
					continue;
				case 242:
					array2[5] = (byte)num17;
					num2 = 374;
					continue;
				case 345:
					array[2] = (byte)num15;
					num = 185;
					break;
				case 98:
					num15 = 90 + 110;
					num2 = 259;
					continue;
				case 32:
					num17 = 76 + 87;
					num2 = 20;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 21;
					}
					continue;
				case 359:
					num15 = 188 - 62;
					num2 = 53;
					continue;
				case 60:
					array2[6] = (byte)num23;
					num2 = 71;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 57;
					}
					continue;
				case 201:
					array2[4] = 28;
					num2 = 156;
					continue;
				case 230:
					num23 = 123 + 45;
					num2 = 347;
					continue;
				case 321:
					array[0] = 142;
					num2 = 213;
					continue;
				case 14:
					array[30] = (byte)num16;
					num2 = 1;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 1;
					}
					continue;
				case 151:
					num15 = 120 + 59;
					num = 153;
					break;
				case 227:
					array2[7] = (byte)num17;
					num2 = 194;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 323;
					}
					continue;
				case 59:
					array[31] = (byte)num15;
					num2 = 176;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 50;
					}
					continue;
				case 17:
					num15 = 211 + 33;
					num2 = 172;
					continue;
				case 307:
					array[14] = 233;
					num2 = 219;
					continue;
				case 174:
					num16 = 23 + 93;
					num = 206;
					break;
				case 219:
					num16 = 120 + 82;
					num2 = 340;
					continue;
				case 218:
					num16 = 18 + 19;
					num2 = 257;
					continue;
				case 318:
					array[23] = 42;
					num2 = 391;
					continue;
				case 76:
					array[4] = 169;
					num2 = 352;
					continue;
				case 102:
					array2 = new byte[16];
					num2 = 109;
					continue;
				case 225:
					return;
				case 153:
					array[24] = (byte)num15;
					num = 217;
					break;
				case 138:
					if (num18 > 0)
					{
						num2 = 95;
						continue;
					}
					goto case 229;
				case 105:
					array2[15] = (byte)num17;
					num2 = 388;
					continue;
				case 37:
					num23 = 32 + 71;
					num2 = 12;
					continue;
				case 183:
					array2[14] = 35;
					num2 = 284;
					continue;
				case 132:
					array2[1] = (byte)num17;
					num2 = 280;
					continue;
				case 322:
					array2[12] = 101;
					num2 = 4;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 11;
					}
					continue;
				case 192:
					array2[4] = 85;
					num2 = 201;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 25;
					}
					continue;
				case 162:
					num15 = 56 + 104;
					num2 = 112;
					continue;
				case 202:
					num15 = 202 - 67;
					num2 = 85;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 42;
					}
					continue;
				case 67:
					array[25] = 118;
					num2 = 246;
					continue;
				case 3:
					num4 += num26;
					num2 = 15;
					continue;
				case 160:
					num17 = 15 + 48;
					num2 = 275;
					continue;
				case 175:
					array2[9] = 155;
					num2 = 57;
					continue;
				case 327:
					num23 = 1 + 22;
					num2 = 58;
					continue;
				case 332:
					array2[2] = 233;
					num2 = 188;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 381;
					}
					continue;
				case 224:
					array[8] = (byte)num15;
					num2 = 193;
					continue;
				case 272:
					num30++;
					num = 2;
					break;
				case 155:
					array[13] = 162;
					num2 = 55;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 123;
					}
					continue;
				case 171:
					array2[2] = (byte)num17;
					num2 = 22;
					continue;
				case 372:
					num16 = 71 + 18;
					num2 = 46;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 48;
					}
					continue;
				case 215:
					array2[8] = 92;
					num2 = 360;
					continue;
				case 178:
					num37 = array4.Length % 4;
					num2 = 92;
					continue;
				case 52:
					num16 = 42 + 51;
					num = 210;
					break;
				case 206:
					array[8] = (byte)num16;
					num2 = 279;
					continue;
				case 360:
					num17 = 229 - 76;
					num2 = 261;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 394;
					}
					continue;
				case 370:
					num36 = 1;
					num = 291;
					break;
				case 255:
					array[14] = 170;
					num2 = 307;
					continue;
				case 79:
					array[7] = 109;
					num2 = 121;
					continue;
				case 285:
					array2[4] = 128;
					num2 = 222;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 151;
					}
					continue;
				case 354:
					num16 = 216 - 72;
					num2 = 214;
					continue;
				case 51:
					array[22] = 54;
					num = 234;
					break;
				case 311:
					array2[8] = 162;
					num2 = 295;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 289;
					}
					continue;
				case 388:
					array2[15] = 89;
					num2 = 336;
					continue;
				case 95:
					num24 <<= 8;
					num2 = 229;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 199;
					}
					continue;
				case 357:
					num15 = 35 + 19;
					num2 = 36;
					continue;
				case 211:
					array[10] = (byte)num15;
					num2 = 130;
					continue;
				case 312:
					num23 = 17 + 14;
					num2 = 186;
					continue;
				case 19:
					num16 = 156 - 52;
					num2 = 179;
					continue;
				case 344:
					array2[15] = 23;
					num2 = 240;
					continue;
				case 173:
					num15 = 101 - 59;
					num2 = 316;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 45;
					}
					continue;
				case 177:
					num17 = 204 - 68;
					num2 = 242;
					continue;
				case 147:
					if (num22 == num27 - 1)
					{
						num2 = 23;
						if (eXNjvm51bndcNZfZcNcD() != null)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 292;
				case 126:
					array[4] = 49;
					num2 = 277;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 16;
					}
					continue;
				case 28:
					Y3SvPl51c2vYLeqmfoJ6(memoryStream);
					num2 = 117;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 139;
					}
					continue;
				case 393:
					num15 = 175 - 58;
					num2 = 243;
					continue;
				case 290:
					array2[1] = (byte)num17;
					num2 = 262;
					continue;
				case 125:
					array2[7] = 187;
					num2 = 351;
					continue;
				case 156:
					num23 = 196 - 65;
					num2 = 296;
					continue;
				case 45:
					array[29] = 124;
					num2 = 74;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 67;
					}
					continue;
				default:
					array2[3] = 145;
					num = 118;
					break;
				case 118:
					num17 = 94 + 0;
					num2 = 220;
					continue;
				case 235:
					array[25] = 140;
					num2 = 63;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 67;
					}
					continue;
				case 74:
					array[29] = 52;
					num2 = 181;
					continue;
				case 42:
					num17 = 187 - 62;
					num2 = 119;
					continue;
				case 315:
					num32 = 0;
					num2 = 189;
					continue;
				case 325:
					num15 = 117 - 80;
					num2 = 244;
					continue;
				case 198:
					array[1] = 187;
					num2 = 248;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 106;
					}
					continue;
				case 391:
					array[23] = 140;
					num2 = 304;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 328;
					}
					continue;
				case 103:
					array2[13] = 114;
					num2 = 20;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 11;
					}
					continue;
				case 129:
					array2[7] = (byte)num17;
					num = 125;
					break;
				case 2:
				case 113:
					if (num30 >= array8.Length)
					{
						num2 = 32;
						if (teyBV551DToEaVNvXNds())
						{
							num2 = 35;
						}
						continue;
					}
					goto case 86;
				case 10:
					array7[num21 + 1] = (byte)((num35 & 0xFF00) >> 8);
					num2 = 349;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 114;
					}
					continue;
				case 57:
					num23 = 187 - 62;
					num2 = 385;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 372;
					}
					continue;
				case 376:
					num15 = 216 - 72;
					num2 = 190;
					continue;
				case 189:
				case 245:
					if (num32 >= num37)
					{
						num2 = 1;
						if (eXNjvm51bndcNZfZcNcD() == null)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 265;
				case 53:
					array[6] = (byte)num15;
					num2 = 270;
					continue;
				case 361:
					num16 = 132 - 44;
					num = 100;
					break;
				case 78:
					num23 = 69 - 28;
					num2 = 263;
					continue;
				case 302:
					array[4] = (byte)num15;
					num2 = 169;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 267;
					}
					continue;
				case 258:
					num17 = 233 - 77;
					num2 = 129;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 24;
					}
					continue;
				case 185:
					array[2] = 116;
					num2 = 325;
					continue;
				case 263:
					array2[15] = (byte)num23;
					num2 = 145;
					continue;
				case 223:
					return;
				case 194:
					array[27] = (byte)num15;
					num2 = 89;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 46;
					}
					continue;
				case 101:
					num24 = 0u;
					num2 = 2;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 3;
					}
					continue;
				case 31:
					num34 += 8;
					num2 = 305;
					continue;
				case 196:
					array[26] = 43;
					num2 = 30;
					continue;
				case 35:
					array4 = array3;
					num2 = 178;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 105;
					}
					continue;
				case 278:
					num18++;
					num2 = 8;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 8;
					}
					continue;
				case 121:
					array[7] = 93;
					num2 = 357;
					continue;
				case 286:
					array[21] = (byte)num16;
					num2 = 164;
					continue;
				case 172:
					array[6] = (byte)num15;
					num2 = 79;
					continue;
				case 395:
					array6 = array7;
					num2 = 94;
					continue;
				case 110:
					array2[11] = 23;
					num2 = 9;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 2;
					}
					continue;
				case 46:
					num17 = 207 - 69;
					num2 = 110;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 197;
					}
					continue;
				case 293:
					array[12] = (byte)num16;
					num2 = 15;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 29;
					}
					continue;
				case 58:
					array2[11] = (byte)num23;
					num2 = 152;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 364;
					}
					continue;
				case 83:
					num23 = 164 - 54;
					num = 134;
					break;
				case 298:
					num19 = 0u;
					num2 = 377;
					continue;
				case 72:
					array = new byte[32];
					num2 = 239;
					continue;
				case 297:
					if (num22 == num27 - 1)
					{
						num2 = 37;
						if (eXNjvm51bndcNZfZcNcD() == null)
						{
							num2 = 163;
						}
						continue;
					}
					goto case 47;
				case 283:
					num16 = 235 - 78;
					num = 166;
					break;
				case 346:
					array[18] = (byte)num16;
					num = 350;
					break;
				case 239:
					array[0] = 118;
					num2 = 63;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 321;
					}
					continue;
				case 246:
					array[25] = 161;
					num2 = 306;
					continue;
				case 326:
					array[1] = 84;
					num2 = 38;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 218;
					}
					continue;
				case 353:
					array[27] = (byte)num16;
					num2 = 98;
					continue;
				case 179:
					array[5] = (byte)num16;
					num2 = 159;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 221;
					}
					continue;
				case 55:
					array[9] = 107;
					num2 = 300;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 83;
					}
					continue;
				case 343:
					array[31] = 142;
					num2 = 91;
					continue;
				case 141:
					array2[1] = 215;
					num2 = 33;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 20;
					}
					continue;
				case 22:
					array2[2] = 145;
					num2 = 332;
					continue;
				case 120:
					if (num37 > 0)
					{
						num2 = 276;
						continue;
					}
					goto case 298;
				case 261:
					array[20] = (byte)num15;
					num2 = 233;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 196;
					}
					continue;
				case 247:
					array[19] = 120;
					num2 = 114;
					continue;
				case 68:
					num16 = 71 - 18;
					num = 168;
					break;
				case 244:
					array[2] = (byte)num15;
					num2 = 253;
					continue;
				case 220:
					array2[3] = (byte)num17;
					num2 = 144;
					continue;
				case 210:
					array[21] = (byte)num16;
					num2 = 373;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 269;
					}
					continue;
				case 221:
					array[5] = 106;
					num = 320;
					break;
				case 331:
					array2[0] = 128;
					num2 = 107;
					continue;
				case 289:
					num17 = 96 - 65;
					num2 = 56;
					continue;
				case 134:
					array2[10] = (byte)num23;
					num2 = 110;
					continue;
				case 390:
					array2[6] = 127;
					num2 = 137;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 200;
					}
					continue;
				case 339:
					deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
					num2 = 249;
					continue;
				case 316:
					array[15] = (byte)num15;
					num2 = 203;
					continue;
				case 71:
					array2[6] = 109;
					num2 = 254;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 249;
					}
					continue;
				case 335:
					array2[12] = 112;
					num2 = 322;
					continue;
				case 165:
				case 205:
					if (num22 >= num27)
					{
						num2 = 395;
						continue;
					}
					goto case 128;
				case 54:
					array[26] = 142;
					num2 = 376;
					continue;
				case 29:
					num16 = 2 + 46;
					num2 = 106;
					continue;
				case 281:
					array[5] = (byte)num15;
					num2 = 19;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 1;
					}
					continue;
				case 274:
					array[22] = (byte)num16;
					num2 = 396;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 26;
					}
					continue;
				case 399:
					array[16] = 166;
					num2 = 131;
					continue;
				case 62:
					memoryStream = new MemoryStream();
					num2 = 339;
					continue;
				case 133:
					array2[3] = 183;
					num2 = 5;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 192;
					}
					continue;
				case 364:
					num17 = 85 - 84;
					num2 = 184;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 252;
					}
					continue;
				case 34:
					num15 = 35 + 7;
					num2 = 18;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 261;
					}
					continue;
				case 324:
					array[17] = 45;
					num2 = 283;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 192;
					}
					continue;
				case 11:
					num17 = 222 + 2;
					num2 = 204;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 166;
					}
					continue;
				case 117:
					array[6] = 146;
					num2 = 7;
					continue;
				case 50:
					array[5] = 70;
					num2 = 238;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 37;
					}
					continue;
				case 295:
					array2[8] = 152;
					num = 380;
					break;
				case 139:
				case 170:
				case 375:
					GfG5GP1yDyr = (string[])W3aj6H51EwRnr5Rnp48x((Assembly)kJh5GJjmm7n);
					num2 = 248;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 341;
					}
					continue;
				case 294:
					if (num36 != 1)
					{
						num2 = 397;
						continue;
					}
					goto case 62;
				case 40:
					array[26] = 26;
					num2 = 186;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 196;
					}
					continue;
				case 317:
					num16 = 92 + 47;
					num2 = 150;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 293;
					}
					continue;
				case 231:
					array2[0] = 143;
					num2 = 331;
					continue;
				case 115:
					array[3] = 117;
					num2 = 136;
					continue;
				case 161:
					array[21] = (byte)num15;
					num2 = 52;
					continue;
				case 81:
					array2[13] = (byte)num23;
					num2 = 289;
					continue;
				case 350:
					num15 = 118 + 95;
					num2 = 108;
					continue;
				case 306:
					num15 = 9 + 11;
					num2 = 304;
					continue;
				case 89:
					array[28] = 111;
					num2 = 97;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 154;
					}
					continue;
				case 252:
					array2[11] = (byte)num17;
					num2 = 13;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 39;
					}
					continue;
				case 140:
					num16 = 187 - 122;
					num2 = 220;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 274;
					}
					continue;
				case 212:
					array[19] = (byte)num16;
					num2 = 24;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 149;
					}
					continue;
				case 12:
					array2[0] = (byte)num23;
					num2 = 231;
					continue;
				case 319:
					num15 = 214 - 71;
					num2 = 67;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 69;
					}
					continue;
				case 73:
					num16 = 155 + 44;
					num2 = 33;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 299;
					}
					continue;
				case 379:
					array2[13] = (byte)num23;
					num2 = 103;
					continue;
				case 385:
					array2[9] = (byte)num23;
					num2 = 42;
					continue;
				case 348:
					num16 = 144 - 65;
					num2 = 358;
					continue;
				case 131:
					array[16] = 183;
					num2 = 142;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 75;
					}
					continue;
				case 77:
					array[12] = (byte)num16;
					num2 = 348;
					continue;
				case 203:
					array[16] = 102;
					num2 = 372;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 343;
					}
					continue;
				case 154:
					array[28] = 134;
					num2 = 88;
					continue;
				case 94:
					if (num36 != 0)
					{
						num2 = 245;
						if (teyBV551DToEaVNvXNds())
						{
							num2 = 294;
						}
						continue;
					}
					goto case 184;
				case 122:
					array7[num21 + 3] = (byte)((num35 & 0xFF000000u) >> 24);
					num2 = 181;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 356;
					}
					continue;
				case 259:
					array[27] = (byte)num15;
					num2 = 90;
					continue;
				case 368:
					array2[3] = 197;
					num2 = 133;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 69;
					}
					continue;
				case 207:
					array[7] = 114;
					num2 = 73;
					continue;
				case 114:
					num16 = 198 - 66;
					num2 = 14;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 16;
					}
					continue;
				case 300:
					array[9] = 85;
					num2 = 99;
					continue;
				case 378:
					num17 = 84 - 62;
					num2 = 82;
					continue;
				case 236:
					array[15] = (byte)num15;
					num2 = 173;
					continue;
				case 135:
					array[18] = 201;
					num2 = 387;
					continue;
				case 349:
					array7[num21 + 2] = (byte)((num35 & 0xFF0000) >> 16);
					num2 = 122;
					continue;
				case 380:
					num17 = 89 - 21;
					num2 = 330;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 114;
					}
					continue;
				case 182:
					num17 = 60 - 2;
					num2 = 157;
					continue;
				case 88:
					num16 = 81 + 2;
					num2 = 167;
					continue;
				case 214:
					array[22] = (byte)num16;
					num2 = 51;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 47;
					}
					continue;
				case 111:
					array[21] = 164;
					num2 = 159;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 64;
					}
					continue;
				case 65:
					num17 = 29 + 105;
					num2 = 132;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 112;
					}
					continue;
				case 352:
					num15 = 170 - 56;
					num = 97;
					break;
				case 91:
					num16 = 98 + 62;
					num2 = 80;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 75;
					}
					continue;
				case 64:
					num24 = (uint)((array4[num19 + 3] << 24) | (array4[num19 + 2] << 16) | (array4[num19 + 1] << 8) | array4[num19]);
					num2 = 251;
					continue;
				case 145:
					array8 = array2;
					num2 = 370;
					continue;
				case 216:
					array7 = new byte[array4.Length];
					num = 398;
					break;
				case 374:
					num17 = 45 + 122;
					num = 116;
					break;
				case 304:
					array[25] = (byte)num15;
					num2 = 58;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 152;
					}
					continue;
				case 38:
					array[1] = 183;
					num2 = 326;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 60;
					}
					continue;
				case 355:
					num17 = 20 + 111;
					num = 290;
					break;
				case 119:
					array2[9] = (byte)num17;
					num2 = 104;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 68;
					}
					continue;
				case 262:
					array2[1] = 46;
					num2 = 65;
					continue;
				case 213:
					array[0] = 6;
					num2 = 38;
					continue;
				case 148:
				case 397:
					kJh5GJjmm7n = P17IWW51LOCTb66ahW8T(eBoxmB51jYmILDYSZ83R(array6, 0u));
					num2 = 170;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 46;
					}
					continue;
				case 328:
					num15 = 172 - 74;
					num2 = 25;
					continue;
				case 377:
					num22 = 0;
					num2 = 165;
					continue;
				case 123:
					array[13] = 109;
					num2 = 264;
					continue;
				case 149:
					array[19] = 101;
					num2 = 247;
					continue;
				case 47:
					num35 = num4 ^ num24;
					num2 = 49;
					continue;
				case 250:
					num16 = 225 - 75;
					num2 = 77;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 18;
					}
					continue;
				case 190:
					array[26] = (byte)num15;
					num2 = 40;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 16;
					}
					continue;
				case 100:
					array[11] = (byte)num16;
					num = 383;
					break;
				case 303:
					array[8] = (byte)num15;
					num2 = 174;
					continue;
				case 320:
					array[5] = 130;
					num2 = 50;
					continue;
				case 270:
					array[6] = 84;
					num2 = 117;
					continue;
				case 186:
					array2[14] = (byte)num23;
					num2 = 27;
					continue;
				case 158:
					array[27] = (byte)num16;
					num2 = 310;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 236;
					}
					continue;
				case 292:
					num19 = (uint)num21;
					num2 = 107;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 169;
					}
					continue;
				case 127:
					NwE2q4515LmjUTm8GAvn(pdinb4511gi3xvqpA1ux(dGLTKW5Gj2RRv85HF7Gu), 0L);
					num2 = 57;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 187;
					}
					continue;
				case 309:
					num17 = 163 + 48;
					num2 = 227;
					continue;
				case 44:
					array[11] = (byte)num16;
					num = 199;
					break;
				case 287:
					array[4] = 189;
					num2 = 34;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 126;
					}
					continue;
				case 85:
					array[10] = (byte)num15;
					num2 = 401;
					continue;
				case 70:
					dGLTKW5Gj2RRv85HF7Gu = new F71m3059rTj4gyFcUtWX.dGLTKW5Gj2RRv85HF7Gu((Stream)tbUgZN51kbIeiWOUWnAW(UeWl5f51NHeHadXpv3VR(typeof(F71m3059rTj4gyFcUtWX).TypeHandle).Assembly, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4220DA8 ^ 0x420258A)));
					num = 127;
					break;
				case 308:
					array2[10] = 96;
					num2 = 333;
					continue;
				case 20:
					num23 = 48 + 20;
					num2 = 18;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 81;
					}
					continue;
				case 92:
					num27 = array4.Length / 4;
					num2 = 216;
					continue;
				case 33:
					num17 = 9 + 15;
					num2 = 150;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 171;
					}
					continue;
				case 43:
					num15 = 177 - 59;
					num2 = 297;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 345;
					}
					continue;
				case 109:
					array2[0] = 98;
					num2 = 37;
					continue;
				case 157:
					array2[0] = (byte)num17;
					num2 = 355;
					continue;
				case 193:
					num15 = 252 - 84;
					num2 = 303;
					continue;
				case 253:
					array[3] = 85;
					num2 = 20;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 115;
					}
					continue;
				case 112:
					array[20] = (byte)num15;
					num2 = 46;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 124;
					}
					continue;
				case 191:
					array[29] = (byte)num15;
					num2 = 45;
					continue;
				case 16:
					array[20] = (byte)num16;
					num2 = 34;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 7;
					}
					continue;
				case 104:
					array2[9] = 100;
					num2 = 13;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 32;
					}
					continue;
				case 336:
					num17 = 24 + 9;
					num2 = 84;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 62;
					}
					continue;
				case 351:
					array2[7] = 119;
					num2 = 242;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 309;
					}
					continue;
				case 269:
					num16 = 166 + 58;
					num2 = 144;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 209;
					}
					continue;
				case 116:
					array2[5] = (byte)num17;
					num = 378;
					break;
				case 276:
					num27++;
					num2 = 298;
					continue;
				case 169:
					num4 += num26;
					num2 = 64;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 21;
					}
					continue;
				case 82:
					array2[5] = (byte)num17;
					num2 = 390;
					continue;
				case 367:
					array[25] = 155;
					num = 235;
					break;
				case 1:
					num15 = 49 + 29;
					num2 = 59;
					continue;
				case 144:
					array2[3] = 110;
					num2 = 368;
					continue;
				case 279:
					array[8] = 78;
					num2 = 55;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 45;
					}
					continue;
				case 87:
					array[17] = (byte)num15;
					num2 = 324;
					continue;
				case 254:
					array2[7] = 151;
					num2 = 46;
					continue;
				case 260:
					array[23] = 168;
					num2 = 318;
					continue;
				case 394:
					array2[8] = (byte)num17;
					num2 = 311;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 129;
					}
					continue;
				case 232:
					num15 = 179 - 59;
					num2 = 281;
					continue;
				case 277:
					num15 = 203 - 67;
					num2 = 302;
					continue;
				case 273:
					array[24] = (byte)num16;
					num2 = 63;
					continue;
				case 96:
					array[3] = (byte)num15;
					num2 = 76;
					continue;
				case 56:
					array2[13] = (byte)num17;
					num2 = 183;
					continue;
				case 396:
					array[23] = 234;
					num2 = 393;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 198;
					}
					continue;
				case 66:
					array[13] = 166;
					num2 = 52;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 155;
					}
					continue;
				case 398:
					num25 = array5.Length / 4;
					num = 392;
					break;
				case 226:
					if (Eye5GF9Kb65)
					{
						num = 225;
						break;
					}
					goto case 70;
				case 233:
					array[20] = 68;
					num2 = 162;
					continue;
				case 371:
					num23 = 94 + 79;
					num2 = 34;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 60;
					}
					continue;
				case 265:
					if (num32 > 0)
					{
						num2 = 93;
						continue;
					}
					goto case 305;
				case 386:
					array3 = (byte[])SpiQOS51xwUHPY0LWys7(dGLTKW5Gj2RRv85HF7Gu, (int)KL5bnK51SeWWNatynPCP(pdinb4511gi3xvqpA1ux(dGLTKW5Gj2RRv85HF7Gu)));
					num2 = 60;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 72;
					}
					continue;
				case 284:
					array2[14] = 116;
					num2 = 382;
					continue;
				case 99:
					array[9] = 108;
					num2 = 68;
					continue;
				case 228:
					array2[12] = 149;
					num2 = 335;
					continue;
				case 184:
					kJh5GJjmm7n = P17IWW51LOCTb66ahW8T(array6);
					num2 = 375;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 127;
					}
					continue;
				case 340:
					array[15] = (byte)num16;
					num2 = 24;
					continue;
				case 24:
					num15 = 133 - 44;
					num2 = 236;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 216;
					}
					continue;
				case 400:
					num23 = 29 + 122;
					num2 = 379;
					continue;
				case 9:
					array2[11] = 158;
					num2 = 327;
					continue;
				case 389:
					num21 = num22 * 4;
					num2 = 384;
					if (eXNjvm51bndcNZfZcNcD() != null)
					{
						num2 = 273;
					}
					continue;
				case 195:
					num16 = 105 + 43;
					num2 = 139;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 212;
					}
					continue;
				case 80:
					array[31] = (byte)num16;
					num2 = 129;
					if (teyBV551DToEaVNvXNds())
					{
						num2 = 313;
					}
					continue;
				case 75:
					array[17] = (byte)num16;
					num = 288;
					break;
				case 264:
					array[14] = 203;
					num2 = 255;
					continue;
				case 299:
					array[7] = (byte)num16;
					num2 = 143;
					continue;
				case 384:
					num19 = (uint)(num20 * 4);
					num2 = 266;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 98;
					}
					continue;
				case 323:
					array2[8] = 167;
					num2 = 215;
					continue;
				case 25:
					array[23] = (byte)num15;
					num = 337;
					break;
				case 288:
					num15 = 232 - 77;
					num2 = 80;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 87;
					}
					continue;
				case 222:
					array2[4] = 177;
					num2 = 177;
					continue;
				case 130:
					num16 = 161 - 53;
					num2 = 28;
					if (eXNjvm51bndcNZfZcNcD() == null)
					{
						num2 = 44;
					}
					continue;
				case 61:
				case 251:
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
					num2 = 297;
					if (!teyBV551DToEaVNvXNds())
					{
						num2 = 150;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] syD5G82O7Xn(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556061)).Assembly)
		{
			if (!Eye5GF9Kb65)
			{
				bD35G7JxY5H();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)kJh5GJjmm7n).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly wtj5GABkpMN(object P_0, ResolveEventArgs P_1)
	{
		if (!Eye5GF9Kb65)
		{
			bD35G7JxY5H();
		}
		string name = P_1.Name;
		for (int i = 0; i < GfG5GP1yDyr.Length; i++)
		{
			if (GfG5GP1yDyr[i] == name)
			{
				return (Assembly)kJh5GJjmm7n;
			}
		}
		return null;
	}

	public pBBtaj5Gmf2YibAYEwgh()
	{
		AppDomain.CurrentDomain.ResourceResolve += wtj5GABkpMN;
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!Sx05G3JqqoK)
		{
			Sx05G3JqqoK = true;
			new pBBtaj5Gmf2YibAYEwgh();
		}
	}

	internal static Type UeWl5f51NHeHadXpv3VR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object tbUgZN51kbIeiWOUWnAW(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object pdinb4511gi3xvqpA1ux(object P_0)
	{
		return ((F71m3059rTj4gyFcUtWX.dGLTKW5Gj2RRv85HF7Gu)P_0).m9OIO8Q0EK();
	}

	internal static void NwE2q4515LmjUTm8GAvn(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long KL5bnK51SeWWNatynPCP(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object SpiQOS51xwUHPY0LWys7(object P_0, int P_1)
	{
		return ((F71m3059rTj4gyFcUtWX.dGLTKW5Gj2RRv85HF7Gu)P_0).M4C5GEj2CRn(P_1);
	}

	internal static object P17IWW51LOCTb66ahW8T(object P_0)
	{
		return BI0Sc95GuGJ4uDB0DLxh.Q835YYfKgZR((byte[])P_0);
	}

	internal static void jteY6m51ejGVGjS3gdE6(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void WlRxEF51sOfBWHmSkiPv(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object oohQas51X2np9SIS2oex(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void Y3SvPl51c2vYLeqmfoJ6(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object eBoxmB51jYmILDYSZ83R(object P_0, uint P_1)
	{
		return BI0Sc95GuGJ4uDB0DLxh.Q775YoumpVZ((byte[])P_0, P_1);
	}

	internal static object W3aj6H51EwRnr5Rnp48x(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool teyBV551DToEaVNvXNds()
	{
		return (object)null == null;
	}

	internal static object eXNjvm51bndcNZfZcNcD()
	{
		return null;
	}
}
