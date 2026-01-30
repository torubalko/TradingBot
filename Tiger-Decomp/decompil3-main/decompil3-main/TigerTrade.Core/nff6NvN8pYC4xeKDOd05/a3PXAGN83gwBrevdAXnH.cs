using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using EDugZvNwF6e5LYsQZ3C5;
using gyWf8lN8Aps6C4Xje11n;
using OrDDjnN8w7riQsQI5MiI;

namespace nff6NvN8pYC4xeKDOd05;

internal class a3PXAGN83gwBrevdAXnH
{
	private enum LLiTBbNAGgNrycsKtvJT
	{

	}

	internal class b9AKw8NAYI378ni0TJAF
	{
		private unsafe static uint j5MNAoGUMna(void* P_0, uint P_1)
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

		private unsafe static bool sfsNAvw2K2l(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void fctNABNAF7k(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void Be3NAat6oFP(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void Um5NAiHCYin(byte* P_0, byte* P_1, uint P_2)
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
				Be3NAat6oFP(P_0, P_1, P_2);
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

		private unsafe static uint tmZNAlcineZ(byte[] P_0, uint P_1, LLiTBbNAGgNrycsKtvJT P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint BDeNA4CEHoL(byte[] P_0, uint P_1)
		{
			return tmZNAlcineZ(P_0, P_1, (LLiTBbNAGgNrycsKtvJT)3);
		}

		private unsafe static uint J4aNADDUk7W(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + j5MNAoGUMna(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (j5MNAoGUMna(ptr6 + 4, 4u) != 1)
					{
						Be3NAat6oFP(ptr2, ptr3 + num, j5MNAoGUMna(ptr6 + 3, 4u));
						return j5MNAoGUMna(ptr6 + 3, 4u);
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
							num2 = j5MNAoGUMna(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = j5MNAoGUMna(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								Um5NAiHCYin(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								Um5NAiHCYin(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								Um5NAiHCYin(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								Um5NAiHCYin(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								Um5NAiHCYin(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								fctNABNAF7k(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							Um5NAiHCYin(ptr5, ptr4, 4u);
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

		internal static object kaXNAbS1aZ0(byte[] P_0)
		{
			return tEnix8ko5dm0JPoxuE1j(Type.GetTypeFromHandle(UpcGmqko1OCpCdvUVhIW(16777388)).GetMethod(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1306877528 ^ -1306875008).Trim(), new Type[1] { typeof(byte[]) }), null, new object[1] { P_0 });
		}

		public static byte[] xXDNAN16eEA(byte[] P_0, uint P_1)
		{
			uint num = BDeNA4CEHoL(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				KYqTUukoSvCEQeqU3jjM(P_0, P_1, array);
			}
			return array;
		}

		internal static RuntimeTypeHandle UpcGmqko1OCpCdvUVhIW(int token)
		{
			return V666v0N8875hxUavxV17.cHJk4pLGZX2(token);
		}

		internal static object tEnix8ko5dm0JPoxuE1j(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		internal static uint KYqTUukoSvCEQeqU3jjM(object P_0, uint P_1, object P_2)
		{
			return J4aNADDUk7W((byte[])P_0, P_1, (byte[])P_2);
		}
	}

	private static string[] NqvNAHM8XN8 = new string[0];

	private static object nUGNAfjlJVl = null;

	private static bool wpxNA9poQle = false;

	private static bool aiyNAngek4l = false;

	private static void ATHN8zKaci3()
	{
		int num = 210;
		byte[] array = default(byte[]);
		int num15 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array2 = default(byte[]);
		int num18 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num21 = default(int);
		uint num16 = default(uint);
		int num28 = default(int);
		int num32 = default(int);
		int num20 = default(int);
		int num33 = default(int);
		int num19 = default(int);
		int num22 = default(int);
		uint num23 = default(uint);
		byte[] array3 = default(byte[]);
		uint num25 = default(uint);
		byte[] array5 = default(byte[]);
		int num27 = default(int);
		int num30 = default(int);
		uint num31 = default(uint);
		uint num29 = default(uint);
		int num26 = default(int);
		byte[] array8 = default(byte[]);
		byte[] array7 = default(byte[]);
		RUVZnUNwJg2VA9xTOL2q.hq9Gd9N8qvF64Paq8ke1 hq9Gd9N8qvF64Paq8ke = default(RUVZnUNwJg2VA9xTOL2q.hq9Gd9N8qvF64Paq8ke1);
		uint num17 = default(uint);
		int num24 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 116:
					array[5] = (byte)num15;
					num2 = 104;
					continue;
				case 151:
					try
					{
						RthNTck0ank1VXAjNV0N(deflateStream, memoryStream);
						int num34 = 0;
						if (!jqC26Lk0HH4MFYkuT6V1())
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
						int num35;
						if (deflateStream == null)
						{
							num35 = 0;
							if (jqC26Lk0HH4MFYkuT6V1())
							{
								num35 = 1;
							}
							goto IL_06a4;
						}
						goto IL_06d9;
						IL_06a4:
						switch (num35)
						{
						case 1:
							goto end_IL_067f;
						case 2:
							goto end_IL_067f;
						}
						goto IL_06d9;
						IL_06d9:
						uVAYiCk0i4e77VPbcAhd(deflateStream);
						num35 = 2;
						goto IL_06a4;
						end_IL_067f:;
					}
					goto case 244;
				case 243:
					array2[4] = (byte)num18;
					num2 = 355;
					continue;
				case 140:
					deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
					num2 = 151;
					continue;
				case 66:
					array2[7] = (byte)num18;
					num2 = 255;
					continue;
				case 99:
					array2[5] = 222;
					num2 = 64;
					continue;
				case 21:
					array4[num21 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
					num = 156;
					break;
				case 48:
					num18 = 42 + 26;
					num = 385;
					break;
				case 355:
					num18 = 108 + 4;
					num2 = 331;
					continue;
				case 65:
					array2[8] = (byte)num18;
					num2 = 2;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 48;
					}
					continue;
				case 212:
					num15 = 154 - 35;
					num2 = 5;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 138;
					}
					continue;
				case 329:
					array[8] = (byte)num15;
					num2 = 176;
					continue;
				case 111:
					array[8] = (byte)num15;
					num2 = 267;
					continue;
				case 198:
					array2[8] = 84;
					num2 = 49;
					continue;
				case 228:
					array[17] = 82;
					num2 = 203;
					continue;
				case 42:
					array2[12] = (byte)num18;
					num2 = 10;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 10;
					}
					continue;
				case 357:
					num15 = 147 - 49;
					num2 = 105;
					continue;
				case 185:
					array2[15] = 66;
					num2 = 128;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 332;
					}
					continue;
				case 106:
					array2[6] = (byte)num18;
					num2 = 296;
					continue;
				case 290:
					num28 = 0;
					num2 = 300;
					continue;
				case 102:
					num18 = 4 + 38;
					num2 = 343;
					continue;
				case 100:
					array[0] = 90;
					num2 = 179;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 49;
					}
					continue;
				case 227:
					num18 = 185 - 61;
					num2 = 4;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 8;
					}
					continue;
				case 381:
					array2[1] = 113;
					num2 = 266;
					continue;
				case 316:
					num18 = 60 + 78;
					num2 = 360;
					continue;
				case 305:
					num32 = num20 % num33;
					num2 = 121;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 217;
					}
					continue;
				case 125:
					num15 = 206 + 40;
					num2 = 194;
					continue;
				case 46:
					array[22] = 122;
					num2 = 125;
					continue;
				case 134:
					array[1] = 116;
					num2 = 165;
					continue;
				case 358:
					array[24] = 154;
					num2 = 68;
					continue;
				case 380:
					array[11] = 148;
					num2 = 252;
					continue;
				case 120:
					array2[6] = (byte)num18;
					num2 = 57;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 85;
					}
					continue;
				case 93:
					num15 = 210 - 70;
					num2 = 3;
					continue;
				case 29:
				case 377:
					nUGNAfjlJVl = F089Pmk0BBoqjT1v0EnD(OhFe4pk0DUW66fEiIhio(array6, 0u));
					num2 = 66;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 69;
					}
					continue;
				case 297:
					array[28] = (byte)num15;
					num2 = 218;
					continue;
				case 201:
					num18 = 169 - 56;
					num2 = 82;
					continue;
				case 301:
					if (num20 == num19 - 1)
					{
						num2 = 246;
						continue;
					}
					goto case 285;
				case 31:
					num15 = 215 - 71;
					num2 = 48;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 169;
					}
					continue;
				case 284:
					array[28] = 160;
					num2 = 22;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 61;
					}
					continue;
				case 92:
					array[12] = 96;
					num2 = 304;
					continue;
				case 386:
					array[28] = 145;
					num2 = 71;
					continue;
				case 343:
					array2[1] = (byte)num18;
					num2 = 311;
					continue;
				case 8:
					array2[10] = (byte)num18;
					num2 = 35;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 17;
					}
					continue;
				case 230:
					array2[12] = 138;
					num2 = 111;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 137;
					}
					continue;
				case 298:
					num22++;
					num2 = 179;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 226;
					}
					continue;
				case 231:
					num15 = 193 - 64;
					num2 = 280;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 77;
					}
					continue;
				case 84:
					num18 = 34 + 91;
					num2 = 65;
					continue;
				case 300:
					if (num20 == num19 - 1)
					{
						num2 = 333;
						continue;
					}
					goto case 214;
				case 373:
					num15 = 20 + 105;
					num = 211;
					break;
				case 175:
					array[23] = 29;
					num2 = 281;
					continue;
				case 123:
					array[18] = 141;
					num2 = 259;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 306;
					}
					continue;
				case 85:
					array2[6] = 107;
					num2 = 321;
					continue;
				case 71:
					array[29] = 135;
					num2 = 164;
					continue;
				case 4:
					num23 = (uint)((array3[num25 + 3] << 24) | (array3[num25 + 2] << 16) | (array3[num25 + 1] << 8) | array3[num25]);
					num = 207;
					break;
				case 262:
					array[30] = 159;
					num2 = 96;
					continue;
				case 292:
					array6 = array4;
					num2 = 85;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 155;
					}
					continue;
				case 375:
					array[21] = (byte)num15;
					num2 = 109;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 127;
					}
					continue;
				case 95:
					array[9] = 202;
					num2 = 349;
					continue;
				case 163:
					num15 = 184 + 42;
					num2 = 105;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 258;
					}
					continue;
				case 94:
					array[4] = (byte)num15;
					num2 = 88;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 148;
					}
					continue;
				case 156:
				case 378:
					num20++;
					num2 = 83;
					continue;
				case 233:
					array[5] = (byte)num15;
					num2 = 326;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 91;
					}
					continue;
				case 347:
					array[18] = 253;
					num2 = 383;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 179;
					}
					continue;
				case 218:
					array[28] = 168;
					num2 = 126;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 376;
					}
					continue;
				case 190:
					num4 = 0u;
					num = 269;
					break;
				case 168:
					num19 = array5.Length / 4;
					num = 270;
					break;
				case 294:
					array2[7] = (byte)num18;
					num2 = 247;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 226;
					}
					continue;
				case 191:
					num15 = 165 - 55;
					num2 = 152;
					continue;
				case 119:
					num15 = 178 - 103;
					num = 11;
					break;
				case 345:
					array2[8] = (byte)num18;
					num2 = 157;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 97;
					}
					continue;
				case 256:
					array2[14] = 49;
					num2 = 173;
					continue;
				case 206:
					array2[11] = (byte)num18;
					num2 = 32;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 29;
					}
					continue;
				case 155:
					if (num27 == 0)
					{
						num2 = 310;
						if (!jqC26Lk0HH4MFYkuT6V1())
						{
							num2 = 4;
						}
						continue;
					}
					goto case 79;
				case 252:
					num15 = 132 - 44;
					num2 = 146;
					continue;
				case 273:
					num30++;
					num2 = 248;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 323;
					}
					continue;
				case 22:
					array4[num21 + num30] = (byte)((num31 & num29) >> num28);
					num2 = 55;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 273;
					}
					continue;
				case 131:
					array2[15] = 101;
					num2 = 97;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 70;
					}
					continue;
				case 326:
					num15 = 83 + 102;
					num2 = 54;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 54;
					}
					continue;
				case 56:
					array2[15] = (byte)num18;
					num2 = 109;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 15;
					}
					continue;
				case 369:
					array[27] = 58;
					num2 = 16;
					continue;
				case 303:
					array3[num26] ^= array8[num26];
					num2 = 6;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 143;
					}
					continue;
				case 68:
					num15 = 43 + 88;
					num2 = 97;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 299;
					}
					continue;
				case 370:
					array7 = (byte[])YbBq31k0va9iTHGFuM1B(hq9Gd9N8qvF64Paq8ke, (int)iPfy0hk0oaGC8VHqUW0x(Ar1PTLk0Gt1AV1ywyFtA(hq9Gd9N8qvF64Paq8ke)));
					num2 = 8;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 73;
					}
					continue;
				case 267:
					array[8] = 114;
					num2 = 188;
					continue;
				case 118:
				case 310:
					nUGNAfjlJVl = F089Pmk0BBoqjT1v0EnD(array6);
					num2 = 153;
					continue;
				case 352:
					num15 = 128 - 42;
					num2 = 319;
					continue;
				case 62:
					array[0] = (byte)num15;
					num2 = 100;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 68;
					}
					continue;
				case 268:
					array[30] = (byte)num15;
					num2 = 41;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 93;
					}
					continue;
				case 43:
					if (num22 > 0)
					{
						num2 = 132;
						continue;
					}
					goto case 372;
				case 45:
					array[1] = (byte)num15;
					num2 = 193;
					continue;
				case 144:
					array[2] = (byte)num15;
					num2 = 308;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 272;
					}
					continue;
				case 337:
					num20 = 0;
					num2 = 126;
					continue;
				case 197:
					array[23] = (byte)num15;
					num2 = 175;
					continue;
				case 41:
					array2[3] = 103;
					num2 = 330;
					continue;
				case 121:
					array[26] = 53;
					num2 = 36;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 26;
					}
					continue;
				case 222:
					num15 = 138 + 116;
					num2 = 18;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 4;
					}
					continue;
				case 89:
					array2[1] = (byte)num18;
					num2 = 381;
					continue;
				case 161:
					array2[7] = 248;
					num2 = 133;
					continue;
				case 211:
					array[16] = (byte)num15;
					num2 = 317;
					continue;
				case 124:
					num15 = 167 - 55;
					num = 116;
					break;
				case 51:
					array[2] = (byte)num15;
					num2 = 90;
					continue;
				case 170:
					array[14] = (byte)num15;
					num2 = 241;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 205;
					}
					continue;
				case 114:
					array[0] = 167;
					num2 = 24;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 0;
					}
					continue;
				case 79:
					if (num27 != 1)
					{
						num2 = 377;
						continue;
					}
					goto case 183;
				case 275:
					array2[10] = 126;
					num2 = 248;
					continue;
				case 209:
					hq9Gd9N8qvF64Paq8ke = new RUVZnUNwJg2VA9xTOL2q.hq9Gd9N8qvF64Paq8ke1((Stream)eNfElNk0nNfZKgGZfCsO(MxmaiKk09yvwPrrTqIkD(typeof(RUVZnUNwJg2VA9xTOL2q).TypeHandle).Assembly, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x2D313048 ^ 0x2D31399A)));
					num2 = 213;
					continue;
				case 2:
					array[11] = 120;
					num2 = 109;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 380;
					}
					continue;
				case 359:
					array2[3] = 162;
					num2 = 204;
					continue;
				case 196:
					num15 = 76 - 57;
					num2 = 54;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 170;
					}
					continue;
				case 244:
					nUGNAfjlJVl = F089Pmk0BBoqjT1v0EnD(gp1rCuk0l7SdKpkRUhCX(memoryStream));
					num2 = 40;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 181;
					}
					continue;
				case 10:
					array2[12] = 136;
					num2 = 287;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 172;
					}
					continue;
				case 299:
					array[24] = (byte)num15;
					num2 = 53;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 199;
					}
					continue;
				case 341:
					array[0] = (byte)num15;
					num = 202;
					break;
				case 229:
					num15 = 122 + 104;
					num2 = 197;
					continue;
				case 327:
					num15 = 202 - 67;
					num2 = 322;
					continue;
				case 199:
					array[24] = 177;
					num2 = 357;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 355;
					}
					continue;
				case 135:
					array2[6] = 163;
					num2 = 223;
					continue;
				case 348:
					array[18] = (byte)num15;
					num2 = 215;
					continue;
				case 40:
					array[26] = (byte)num15;
					num2 = 325;
					continue;
				case 86:
					array[13] = 140;
					num2 = 67;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 55;
					}
					continue;
				case 346:
					array[22] = (byte)num15;
					num = 46;
					break;
				case 293:
					num15 = 146 - 48;
					num2 = 351;
					continue;
				case 384:
					array[4] = 129;
					num2 = 110;
					continue;
				case 28:
					array[17] = (byte)num15;
					num2 = 52;
					continue;
				case 104:
					array[5] = 85;
					num2 = 283;
					continue;
				case 277:
					array2[2] = 125;
					num2 = 41;
					continue;
				case 67:
					num15 = 145 - 48;
					num2 = 145;
					continue;
				case 308:
					num15 = 191 - 117;
					num2 = 177;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 145;
					}
					continue;
				case 182:
				case 265:
					if (num26 >= array8.Length)
					{
						num2 = 162;
						if (!jqC26Lk0HH4MFYkuT6V1())
						{
							num2 = 30;
						}
						continue;
					}
					goto case 303;
				case 379:
					array2[9] = (byte)num18;
					num2 = 314;
					continue;
				case 342:
					num25 = (uint)(num32 * 4);
					num2 = 4;
					continue;
				case 281:
					array[23] = 50;
					num = 371;
					break;
				case 164:
					array[29] = 98;
					num2 = 352;
					continue;
				case 241:
					num15 = 79 + 103;
					num2 = 8;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 26;
					}
					continue;
				case 69:
				case 153:
				case 224:
					NqvNAHM8XN8 = (string[])fZPpRmk0bMxeGDFVQxWc((Assembly)nUGNAfjlJVl);
					num2 = 242;
					continue;
				case 242:
					wpxNA9poQle = true;
					num2 = 33;
					continue;
				case 361:
					num15 = 236 - 78;
					num2 = 367;
					continue;
				case 157:
					num18 = 187 - 62;
					num2 = 379;
					continue;
				case 366:
					array[10] = (byte)num15;
					num2 = 220;
					continue;
				case 296:
					num18 = 108 + 85;
					num2 = 66;
					continue;
				case 82:
					array2[4] = (byte)num18;
					num2 = 267;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 328;
					}
					continue;
				case 109:
					array2[15] = 142;
					num2 = 59;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 185;
					}
					continue;
				case 128:
					num17 = 0u;
					num2 = 63;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 4;
					}
					continue;
				case 372:
					num17 |= array5[array5.Length - (1 + num22)];
					num2 = 298;
					continue;
				case 90:
					num15 = 168 - 56;
					num2 = 144;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 65;
					}
					continue;
				case 259:
					num29 <<= 8;
					num2 = 354;
					continue;
				case 324:
					array[7] = 152;
					num2 = 186;
					continue;
				case 232:
					num15 = 167 - 96;
					num2 = 368;
					continue;
				case 25:
					array2[9] = 100;
					num2 = 237;
					continue;
				case 249:
					array2[2] = (byte)num18;
					num = 166;
					break;
				case 364:
					array[7] = (byte)num15;
					num = 324;
					break;
				case 97:
					num18 = 121 + 40;
					num2 = 27;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 56;
					}
					continue;
				case 248:
					num18 = 166 - 55;
					num2 = 136;
					continue;
				case 13:
					num4 += num23;
					num2 = 344;
					continue;
				case 328:
					array2[4] = 155;
					num2 = 165;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 192;
					}
					continue;
				case 317:
					array[16] = 42;
					num2 = 9;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 60;
					}
					continue;
				case 274:
					num33 = array3.Length / 4;
					num2 = 190;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 39;
					}
					continue;
				case 353:
					array2[13] = 156;
					num2 = 251;
					continue;
				case 221:
					array2[11] = (byte)num18;
					num2 = 178;
					continue;
				case 26:
					array[15] = (byte)num15;
					num2 = 293;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 32;
					}
					continue;
				case 278:
					num15 = 170 - 55;
					num2 = 189;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 146;
					}
					continue;
				case 141:
					array[18] = (byte)num15;
					num2 = 38;
					continue;
				case 266:
					num18 = 19 + 34;
					num2 = 249;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 22;
					}
					continue;
				case 264:
					array2[4] = 115;
					num2 = 97;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 201;
					}
					continue;
				case 3:
					array[30] = (byte)num15;
					num2 = 320;
					continue;
				case 154:
					array2[12] = (byte)num18;
					num = 230;
					break;
				case 167:
					array2[10] = (byte)num18;
					num2 = 275;
					continue;
				case 216:
					num15 = 146 - 48;
					num2 = 20;
					continue;
				case 194:
					array[22] = (byte)num15;
					num2 = 140;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 150;
					}
					continue;
				case 52:
					num15 = 84 + 52;
					num2 = 348;
					continue;
				case 204:
					array2[3] = 156;
					num2 = 9;
					continue;
				case 234:
					array2[2] = (byte)num18;
					num2 = 195;
					continue;
				case 171:
					num18 = 240 - 80;
					num2 = 15;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 3;
					}
					continue;
				case 64:
					num18 = 158 - 52;
					num2 = 350;
					continue;
				case 172:
					array[14] = (byte)num15;
					num2 = 231;
					continue;
				case 187:
					array[2] = 103;
					num2 = 77;
					continue;
				case 336:
					array[26] = 97;
					num2 = 121;
					continue;
				case 183:
					memoryStream = new MemoryStream();
					num2 = 140;
					continue;
				case 321:
					array2[6] = 105;
					num2 = 83;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 135;
					}
					continue;
				case 110:
					num15 = 237 - 79;
					num2 = 35;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 94;
					}
					continue;
				case 87:
					array[6] = 86;
					num2 = 103;
					continue;
				case 371:
					num15 = 151 + 38;
					num2 = 257;
					continue;
				case 17:
					array2[0] = 106;
					num2 = 238;
					continue;
				case 75:
					array[20] = 85;
					num2 = 8;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 158;
					}
					continue;
				case 60:
					array[16] = 120;
					num2 = 120;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 212;
					}
					continue;
				case 55:
					num15 = 88 + 34;
					num2 = 58;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 22;
					}
					continue;
				case 217:
					num21 = num20 * 4;
					num2 = 342;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 106;
					}
					continue;
				case 325:
					num15 = 156 - 52;
					num2 = 37;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 295;
					}
					continue;
				case 203:
					num15 = 203 + 40;
					num2 = 28;
					continue;
				case 115:
					num18 = 211 - 70;
					num2 = 85;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 120;
					}
					continue;
				case 15:
					array2[13] = (byte)num18;
					num2 = 353;
					continue;
				case 7:
					num18 = 70 + 94;
					num2 = 167;
					continue;
				case 285:
					num16 = num4 ^ num17;
					num2 = 80;
					continue;
				case 213:
					VDWFdBk0Yo88SoEO0xNn(Ar1PTLk0Gt1AV1ywyFtA(hq9Gd9N8qvF64Paq8ke), 0L);
					num2 = 335;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 147;
					}
					continue;
				case 142:
					num17 = 0u;
					num2 = 13;
					continue;
				case 332:
					array8 = array2;
					num = 53;
					break;
				case 193:
					array[2] = 34;
					num2 = 187;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 144;
					}
					continue;
				case 44:
					array4[num21 + 1] = (byte)((num16 & 0xFF00) >> 8);
					num2 = 83;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 159;
					}
					continue;
				case 253:
					array2[3] = (byte)num18;
					num2 = 264;
					continue;
				case 251:
					num18 = 181 + 21;
					num2 = 309;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 269;
					}
					continue;
				case 205:
					array[7] = 163;
					num2 = 55;
					continue;
				case 160:
					array[20] = 137;
					num2 = 38;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 75;
					}
					continue;
				case 19:
					num15 = 69 + 42;
					num2 = 149;
					continue;
				case 37:
					array[14] = 102;
					num2 = 272;
					continue;
				case 96:
					num15 = 3 + 25;
					num2 = 268;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 233;
					}
					continue;
				case 255:
					num18 = 97 + 40;
					num2 = 294;
					continue;
				case 108:
					array[27] = 131;
					num = 222;
					break;
				case 289:
					num26 = 0;
					num2 = 182;
					continue;
				case 374:
					array[31] = 135;
					num2 = 200;
					continue;
				case 385:
					array2[8] = (byte)num18;
					num2 = 191;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 276;
					}
					continue;
				case 363:
					array2[7] = (byte)num18;
					num2 = 161;
					continue;
				case 184:
				case 323:
					if (num30 >= num24)
					{
						num2 = 378;
						continue;
					}
					goto case 339;
				case 226:
				case 291:
					if (num22 >= num24)
					{
						num2 = 235;
						continue;
					}
					goto case 43;
				case 98:
					num25 = 0u;
					num2 = 337;
					continue;
				case 189:
					array[15] = (byte)num15;
					num2 = 373;
					continue;
				case 287:
					num18 = 184 - 61;
					num2 = 95;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 154;
					}
					continue;
				case 219:
					array2[14] = 251;
					num2 = 89;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 131;
					}
					continue;
				case 339:
					if (num30 > 0)
					{
						num2 = 259;
						continue;
					}
					goto case 22;
				case 30:
					num15 = 53 + 30;
					num2 = 147;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 282;
					}
					continue;
				case 238:
					num18 = 135 - 45;
					num2 = 78;
					continue;
				case 49:
					num18 = 119 - 41;
					num2 = 345;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 173;
					}
					continue;
				case 33:
					return;
				case 9:
					num18 = 22 - 20;
					num = 253;
					break;
				case 200:
					array[31] = 234;
					num2 = 271;
					continue;
				case 38:
					array[18] = 120;
					num2 = 123;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 23;
					}
					continue;
				case 282:
					array[6] = (byte)num15;
					num2 = 87;
					continue;
				case 322:
					array[26] = (byte)num15;
					num2 = 39;
					continue;
				case 331:
					array2[5] = (byte)num18;
					num2 = 139;
					continue;
				case 181:
					FVAu2Xk049FJJc4KHUXv(memoryStream);
					num2 = 224;
					continue;
				case 356:
					num15 = 158 - 52;
					num2 = 62;
					continue;
				case 330:
					num18 = 240 - 80;
					num2 = 14;
					continue;
				case 59:
					num31 = num4 ^ num17;
					num2 = 122;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 103;
					}
					continue;
				case 76:
					array[9] = 80;
					num2 = 47;
					continue;
				case 254:
					array[18] = (byte)num15;
					num2 = 347;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 227;
					}
					continue;
				case 311:
					num18 = 69 + 120;
					num2 = 89;
					continue;
				case 112:
					num18 = 12 - 12;
					num2 = 72;
					continue;
				case 258:
					array[21] = (byte)num15;
					num2 = 147;
					continue;
				case 158:
					num15 = 154 - 51;
					num2 = 107;
					continue;
				case 220:
					array[10] = 161;
					num2 = 236;
					continue;
				case 27:
					array2[14] = (byte)num18;
					num2 = 45;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 256;
					}
					continue;
				case 23:
					array[11] = 112;
					num2 = 2;
					continue;
				case 312:
					num18 = 49 + 16;
					num2 = 221;
					continue;
				case 113:
					array[11] = 82;
					num2 = 92;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 74;
					}
					continue;
				case 54:
					array[6] = (byte)num15;
					num2 = 30;
					continue;
				case 271:
					num15 = 239 + 14;
					num2 = 6;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 6;
					}
					continue;
				case 132:
					num17 <<= 8;
					num2 = 372;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 360;
					}
					continue;
				case 360:
					array2[12] = (byte)num18;
					num2 = 225;
					continue;
				case 195:
					array2[2] = 136;
					num2 = 277;
					continue;
				case 314:
					array2[9] = 93;
					num2 = 25;
					continue;
				case 149:
					array[3] = (byte)num15;
					num2 = 119;
					continue;
				case 269:
					num23 = 0u;
					num2 = 63;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 128;
					}
					continue;
				case 103:
					num15 = 77 + 54;
					num2 = 365;
					continue;
				case 177:
					array[2] = (byte)num15;
					num2 = 34;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 216;
					}
					continue;
				case 78:
					array2[0] = (byte)num18;
					num2 = 362;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 343;
					}
					continue;
				case 50:
					array[19] = 23;
					num2 = 74;
					continue;
				case 138:
					array[16] = (byte)num15;
					num = 338;
					break;
				case 362:
					array2[0] = 227;
					num2 = 102;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 97;
					}
					continue;
				case 276:
					array2[8] = 90;
					num2 = 198;
					continue;
				case 101:
					num15 = 97 + 40;
					num2 = 33;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 364;
					}
					continue;
				case 20:
					array[3] = (byte)num15;
					num2 = 191;
					continue;
				case 159:
					array4[num21 + 2] = (byte)((num16 & 0xFF0000) >> 16);
					num2 = 21;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 8;
					}
					continue;
				case 143:
					num26++;
					num2 = 106;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 265;
					}
					continue;
				case 72:
					array2[11] = (byte)num18;
					num2 = 316;
					continue;
				case 174:
					array2[11] = 92;
					num2 = 312;
					continue;
				case 368:
					array[25] = (byte)num15;
					num2 = 340;
					continue;
				case 130:
					array[17] = (byte)num15;
					num2 = 88;
					continue;
				case 91:
					array[12] = 222;
					num2 = 86;
					continue;
				case 169:
					array[12] = (byte)num15;
					num2 = 91;
					continue;
				case 105:
					array[25] = (byte)num15;
					num = 260;
					break;
				case 246:
					if (num24 > 0)
					{
						num2 = 59;
						continue;
					}
					goto case 285;
				case 11:
					array[3] = (byte)num15;
					num2 = 384;
					continue;
				case 88:
					array[17] = 155;
					num2 = 228;
					continue;
				case 210:
					if (wpxNA9poQle)
					{
						return;
					}
					num2 = 209;
					continue;
				case 188:
					num15 = 73 + 89;
					num2 = 329;
					continue;
				case 173:
					num18 = 162 - 54;
					num2 = 57;
					continue;
				case 338:
					num15 = 249 - 83;
					num2 = 130;
					continue;
				case 376:
					array[28] = 123;
					num2 = 386;
					continue;
				case 127:
					array[21] = 107;
					num2 = 75;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 163;
					}
					continue;
				case 215:
					num15 = 144 - 48;
					num2 = 141;
					continue;
				case 139:
					array2[5] = 91;
					num2 = 99;
					continue;
				case 261:
					array[1] = 97;
					num2 = 134;
					continue;
				case 24:
					array[0] = 223;
					num2 = 218;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 261;
					}
					continue;
				case 145:
					array[13] = (byte)num15;
					num2 = 208;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 2;
					}
					continue;
				case 349:
					num15 = 143 - 47;
					num2 = 366;
					continue;
				case 225:
					num18 = 4 + 9;
					num2 = 42;
					continue;
				case 313:
					array2 = new byte[16];
					num2 = 17;
					continue;
				case 223:
					num18 = 86 + 54;
					num = 106;
					break;
				case 186:
					array[7] = 168;
					num2 = 83;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 205;
					}
					continue;
				case 295:
					array[26] = (byte)num15;
					num2 = 336;
					continue;
				case 283:
					num15 = 135 - 31;
					num2 = 233;
					continue;
				case 122:
					num30 = 0;
					num = 184;
					break;
				case 240:
					array[19] = 128;
					num2 = 50;
					continue;
				case 35:
					array2[10] = 7;
					num2 = 174;
					continue;
				case 286:
					array[11] = 133;
					num2 = 23;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 23;
					}
					continue;
				case 263:
					array[25] = (byte)num15;
					num2 = 112;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 232;
					}
					continue;
				case 344:
					num22 = 0;
					num = 291;
					break;
				case 162:
					array5 = array7;
					num2 = 239;
					continue;
				case 207:
					num29 = 255u;
					num2 = 290;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 96;
					}
					continue;
				case 304:
					array[12] = 40;
					num2 = 31;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 25;
					}
					continue;
				case 354:
					num28 += 8;
					num2 = 22;
					continue;
				case 340:
					array[26] = 92;
					num2 = 327;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 206;
					}
					continue;
				case 333:
					if (num24 > 0)
					{
						num2 = 142;
						continue;
					}
					goto case 214;
				case 36:
					array[27] = 112;
					num2 = 117;
					continue;
				case 214:
					num25 = (uint)num21;
					num2 = 4;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 5;
					}
					continue;
				case 320:
					array[30] = 144;
					num2 = 374;
					continue;
				case 302:
					array[6] = 158;
					num2 = 334;
					continue;
				case 247:
					num18 = 227 - 75;
					num2 = 363;
					continue;
				case 245:
					array[29] = 215;
					num2 = 262;
					continue;
				case 166:
					num18 = 111 + 59;
					num = 234;
					break;
				case 53:
					num27 = 1;
					num2 = 268;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 289;
					}
					continue;
				default:
					array2[13] = 24;
					num2 = 171;
					continue;
				case 257:
					array[23] = (byte)num15;
					num2 = 358;
					continue;
				case 6:
					array[31] = (byte)num15;
					num2 = 16;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 129;
					}
					continue;
				case 335:
					array6 = new byte[0];
					num2 = 370;
					continue;
				case 351:
					array[15] = (byte)num15;
					num2 = 278;
					continue;
				case 150:
					array[23] = 100;
					num2 = 16;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 229;
					}
					continue;
				case 137:
					array2[12] = 116;
					num2 = 0;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 0;
					}
					continue;
				case 73:
					array = new byte[32];
					num2 = 356;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 28;
					}
					continue;
				case 382:
					array[20] = (byte)num15;
					num2 = 144;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 250;
					}
					continue;
				case 14:
					array2[3] = (byte)num18;
					num2 = 105;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 359;
					}
					continue;
				case 350:
					array2[6] = (byte)num18;
					num2 = 115;
					continue;
				case 32:
					num18 = 243 - 81;
					num2 = 387;
					continue;
				case 12:
					array[9] = (byte)num15;
					num = 76;
					break;
				case 148:
					array[4] = 160;
					num2 = 62;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 124;
					}
					continue;
				case 107:
					array[20] = (byte)num15;
					num2 = 307;
					continue;
				case 133:
					array2[8] = 53;
					num2 = 84;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 5;
					}
					continue;
				case 70:
					num17 = (uint)((array5[num25 + 3] << 24) | (array5[num25 + 2] << 16) | (array5[num25 + 1] << 8) | array5[num25]);
					num2 = 288;
					continue;
				case 237:
					num18 = 169 - 103;
					num2 = 23;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 81;
					}
					continue;
				case 315:
					num18 = 113 + 86;
					num2 = 206;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 90;
					}
					continue;
				case 239:
					num24 = array5.Length % 4;
					num2 = 168;
					continue;
				case 306:
					num15 = 131 - 43;
					num2 = 254;
					continue;
				case 367:
					array[29] = (byte)num15;
					num2 = 156;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 245;
					}
					continue;
				case 63:
					if (num24 > 0)
					{
						num2 = 1;
						if (uPGSF0k0fash1PGoEa0a() == null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 98;
				case 179:
					num15 = 203 - 67;
					num2 = 341;
					continue;
				case 387:
					array2[11] = (byte)num18;
					num2 = 49;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 112;
					}
					continue;
				case 5:
					num4 += num23;
					num2 = 70;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 27;
					}
					continue;
				case 117:
					array[27] = 38;
					num2 = 326;
					if (jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 369;
					}
					continue;
				case 47:
					array[9] = 93;
					num2 = 95;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 81;
					}
					continue;
				case 208:
					array[13] = 182;
					num = 37;
					break;
				case 307:
					num15 = 165 + 85;
					num2 = 382;
					continue;
				case 383:
					num15 = 49 + 14;
					num2 = 279;
					continue;
				case 319:
					array[29] = (byte)num15;
					num2 = 361;
					continue;
				case 34:
					array[0] = (byte)num15;
					num2 = 114;
					continue;
				case 136:
					array2[10] = (byte)num18;
					num2 = 227;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 121;
					}
					continue;
				case 272:
					num15 = 9 + 45;
					num2 = 172;
					continue;
				case 270:
					array4 = new byte[array5.Length];
					num2 = 88;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 274;
					}
					continue;
				case 180:
					num15 = 121 + 42;
					num2 = 111;
					continue;
				case 39:
					num15 = 70 + 1;
					num2 = 40;
					continue;
				case 202:
					num15 = 38 + 68;
					num2 = 34;
					continue;
				case 80:
					array4[num21] = (byte)(num16 & 0xFF);
					num2 = 44;
					continue;
				case 83:
				case 126:
					if (num20 >= num19)
					{
						num2 = 292;
						if (!jqC26Lk0HH4MFYkuT6V1())
						{
							num2 = 9;
						}
						continue;
					}
					goto case 305;
				case 77:
					num15 = 111 + 124;
					num2 = 40;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 51;
					}
					continue;
				case 250:
					num15 = 225 - 75;
					num2 = 375;
					continue;
				case 146:
					array[11] = (byte)num15;
					num = 113;
					break;
				case 260:
					num15 = 130 - 43;
					num2 = 263;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 32;
					}
					continue;
				case 279:
					array[19] = (byte)num15;
					num2 = 240;
					continue;
				case 280:
					array[14] = (byte)num15;
					num2 = 196;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 70;
					}
					continue;
				case 165:
					num15 = 139 + 43;
					num2 = 45;
					continue;
				case 192:
					num18 = 62 + 65;
					num2 = 222;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 243;
					}
					continue;
				case 1:
					num19++;
					num2 = 98;
					continue;
				case 129:
					array3 = array;
					num2 = 313;
					continue;
				case 334:
					array[6] = 26;
					num2 = 101;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 62;
					}
					continue;
				case 365:
					array[6] = (byte)num15;
					num2 = 302;
					if (!jqC26Lk0HH4MFYkuT6V1())
					{
						num2 = 255;
					}
					continue;
				case 81:
					array2[9] = (byte)num18;
					num2 = 7;
					continue;
				case 178:
					array2[11] = 55;
					num2 = 185;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 315;
					}
					continue;
				case 176:
					num15 = 1 + 101;
					num = 12;
					break;
				case 147:
					num15 = 212 - 70;
					num2 = 346;
					continue;
				case 309:
					array2[13] = (byte)num18;
					num2 = 318;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 30;
					}
					continue;
				case 61:
					num15 = 79 + 2;
					num2 = 297;
					continue;
				case 74:
					array[20] = 106;
					num2 = 146;
					if (uPGSF0k0fash1PGoEa0a() == null)
					{
						num2 = 160;
					}
					continue;
				case 57:
					array2[14] = (byte)num18;
					num2 = 219;
					continue;
				case 16:
					array[27] = 100;
					num2 = 108;
					continue;
				case 152:
					array[3] = (byte)num15;
					num2 = 19;
					continue;
				case 318:
					num18 = 97 + 52;
					num2 = 27;
					continue;
				case 58:
					array[8] = (byte)num15;
					num = 180;
					break;
				case 236:
					array[10] = 38;
					num2 = 286;
					continue;
				case 18:
					array[27] = (byte)num15;
					num = 284;
					break;
				case 235:
				case 288:
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
					num2 = 301;
					if (uPGSF0k0fash1PGoEa0a() != null)
					{
						num2 = 247;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] eSVNA0sF9XP(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(33554526)).Assembly)
		{
			if (!wpxNA9poQle)
			{
				ATHN8zKaci3();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)nUGNAfjlJVl).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly rdQNA2mw36D(object P_0, ResolveEventArgs P_1)
	{
		if (!wpxNA9poQle)
		{
			ATHN8zKaci3();
		}
		string name = P_1.Name;
		for (int i = 0; i < NqvNAHM8XN8.Length; i++)
		{
			if (NqvNAHM8XN8[i] == name)
			{
				return (Assembly)nUGNAfjlJVl;
			}
		}
		return null;
	}

	public a3PXAGN83gwBrevdAXnH()
	{
		AppDomain.CurrentDomain.ResourceResolve += rdQNA2mw36D;
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!aiyNAngek4l)
		{
			aiyNAngek4l = true;
			new a3PXAGN83gwBrevdAXnH();
		}
	}

	internal static Type MxmaiKk09yvwPrrTqIkD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object eNfElNk0nNfZKgGZfCsO(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object Ar1PTLk0Gt1AV1ywyFtA(object P_0)
	{
		return ((RUVZnUNwJg2VA9xTOL2q.hq9Gd9N8qvF64Paq8ke1)P_0).m9OIO8Q0EK();
	}

	internal static void VDWFdBk0Yo88SoEO0xNn(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long iPfy0hk0oaGC8VHqUW0x(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object YbBq31k0va9iTHGFuM1B(object P_0, int P_1)
	{
		return ((RUVZnUNwJg2VA9xTOL2q.hq9Gd9N8qvF64Paq8ke1)P_0).YCIN8INYlRd(P_1);
	}

	internal static object F089Pmk0BBoqjT1v0EnD(object P_0)
	{
		return b9AKw8NAYI378ni0TJAF.kaXNAbS1aZ0((byte[])P_0);
	}

	internal static void RthNTck0ank1VXAjNV0N(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void uVAYiCk0i4e77VPbcAhd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object gp1rCuk0l7SdKpkRUhCX(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void FVAu2Xk049FJJc4KHUXv(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object OhFe4pk0DUW66fEiIhio(object P_0, uint P_1)
	{
		return b9AKw8NAYI378ni0TJAF.xXDNAN16eEA((byte[])P_0, P_1);
	}

	internal static object fZPpRmk0bMxeGDFVQxWc(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool jqC26Lk0HH4MFYkuT6V1()
	{
		return (object)null == null;
	}

	internal static object uPGSF0k0fash1PGoEa0a()
	{
		return null;
	}
}
