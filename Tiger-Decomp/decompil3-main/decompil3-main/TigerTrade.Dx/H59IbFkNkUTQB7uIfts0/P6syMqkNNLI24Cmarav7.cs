using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using fZl77HkDbCF2hZri4dVV;
using kvtsvxkNBA3S7tECx5XS;
using mbUKQckNlyCOeZGxOWCQ;

namespace H59IbFkNkUTQB7uIfts0;

internal class P6syMqkNNLI24Cmarav7
{
	private enum wQaSWekNcSENrfvTT1jV
	{

	}

	internal class rIb2RSkNjwfatadOXjO3
	{
		private unsafe static uint LS6kNEZCmFA(void* P_0, uint P_1)
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

		private unsafe static bool whPkNQAvIBL(void* P_0, void* P_1, uint P_2)
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

		private unsafe static void HMmkNdja9I9(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = (sbyte)P_1;
			}
		}

		private unsafe static void gT9kNg2487u(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((sbyte*)P_0)[num] = ((sbyte*)P_1)[num];
			}
		}

		private unsafe static void jj6kNRdsXp1(byte* P_0, byte* P_1, uint P_2)
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
				gT9kNg2487u(P_0, P_1, P_2);
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

		private unsafe static uint XZ6kN6mVAq9(byte[] P_0, uint P_1, wQaSWekNcSENrfvTT1jV P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = ((int*)(ptr + P_1))[(int)P_2];
			}
			return (uint)result;
		}

		public static uint pnNkNM8iNyS(byte[] P_0, uint P_1)
		{
			return VyorlZkgZqAV7JwmOhud(P_0, P_1, (wQaSWekNcSENrfvTT1jV)3);
		}

		private unsafe static uint LNIkNOdj01w(byte[] P_0, uint P_1, byte[] P_2)
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
					byte* ptr7 = ptr2 + LS6kNEZCmFA(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16];
					t6UeFkkgVIwjtMNhnkr7(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					uint[] array2 = array;
					byte* ptr8 = ptr7 - 4;
					if (LS6kNEZCmFA(ptr6 + 4, 4u) != 1)
					{
						gT9kNg2487u(ptr2, ptr3 + num, LS6kNEZCmFA(ptr6 + 3, 4u));
						return LS6kNEZCmFA(ptr6 + 3, 4u);
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
							num2 = LS6kNEZCmFA(ptr4, 4u);
							ptr4 += 4;
						}
						uint num3 = LS6kNEZCmFA(ptr4, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								jj6kNRdsXp1(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								jj6kNRdsXp1(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr4 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								jj6kNRdsXp1(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								jj6kNRdsXp1(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								jj6kNRdsXp1(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr4 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFF;
								HMmkNdja9I9(ptr5, b, num5);
								ptr5 += num5;
								ptr4 += 3;
							}
						}
						else
						{
							jj6kNRdsXp1(ptr5, ptr4, 4u);
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

		internal static object oVEkNqcquut(byte[] P_0)
		{
			return KG3Xgokgr1OB1i216VDj(Jgbcd2kgCB7FkgSOivV5(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(16777426)).GetMethod(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-2017337494 ^ -2017339912).Trim(), new Type[1] { typeof(byte[]) }), null, new object[1] { P_0 });
		}

		public static byte[] WU7kNIlhNjL(byte[] P_0, uint P_1)
		{
			uint num = pnNkNM8iNyS(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				LNIkNOdj01w(P_0, P_1, array);
			}
			return array;
		}

		internal static uint VyorlZkgZqAV7JwmOhud(object P_0, uint P_1, wQaSWekNcSENrfvTT1jV P_2)
		{
			return XZ6kN6mVAq9((byte[])P_0, P_1, P_2);
		}

		internal static void t6UeFkkgVIwjtMNhnkr7(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static Type Jgbcd2kgCB7FkgSOivV5(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object KG3Xgokgr1OB1i216VDj(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}
	}

	private static string[] nQnkNLAKZBx = new string[0];

	private static object L12kNeLFSMu = null;

	private static bool xIAkNsKoqIl = false;

	private static bool zmOkNXJB8ue = false;

	private static void r7akN5hJTVa()
	{
		int num = 99;
		int num28 = default(int);
		byte[] array7 = default(byte[]);
		int num16 = default(int);
		byte[] array3 = default(byte[]);
		int num25 = default(int);
		int num15 = default(int);
		byte[] array = default(byte[]);
		uint num27 = default(uint);
		int num35 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num30 = default(int);
		int num17 = default(int);
		uint num32 = default(uint);
		int num26 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		int num29 = default(int);
		byte[] array8 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		int num22 = default(int);
		uint num31 = default(uint);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num18 = default(int);
		vpHjm6kDDRWPs2gcoFH7.aQVjJ3kb3Fc00iL6P6sI aQVjJ3kb3Fc00iL6P6sI = default(vpHjm6kDDRWPs2gcoFH7.aQVjJ3kb3Fc00iL6P6sI);
		int num34 = default(int);
		uint num24 = default(uint);
		uint num23 = default(uint);
		uint num33 = default(uint);
		int num19 = default(int);
		uint num4 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 34:
				case 183:
					if (num28 >= array7.Length)
					{
						num2 = 358;
						if (!XGrpiFksepLCgSfO3SDj())
						{
							num2 = 6;
						}
						continue;
					}
					goto case 257;
				case 269:
					num16 = 167 - 55;
					num2 = 308;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 69;
					}
					continue;
				case 299:
					array3[8] = (byte)num16;
					num2 = 331;
					continue;
				case 296:
					array3[0] = 15;
					num2 = 282;
					continue;
				case 253:
					num25 = 0;
					num2 = 19;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 154;
					}
					continue;
				case 385:
					array3[11] = (byte)num16;
					num2 = 138;
					continue;
				case 275:
					num15 = 188 - 62;
					num2 = 302;
					continue;
				case 234:
					array[18] = (byte)num15;
					num2 = 290;
					continue;
				case 121:
					array[0] = 250;
					num2 = 306;
					continue;
				case 64:
					array[10] = 112;
					num2 = 32;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 356;
					}
					continue;
				case 178:
					array3[7] = (byte)num16;
					num2 = 394;
					continue;
				case 312:
					num27 = (uint)(num35 * 4);
					num2 = 2;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 7;
					}
					continue;
				case 161:
					array2 = array6;
					num2 = 113;
					continue;
				case 365:
					array[24] = (byte)num15;
					num2 = 354;
					continue;
				case 96:
					array[5] = (byte)num15;
					num2 = 250;
					continue;
				case 109:
					array[1] = 143;
					num2 = 323;
					continue;
				case 15:
					array[1] = 121;
					num2 = 205;
					continue;
				case 394:
					num16 = 168 - 56;
					num2 = 67;
					continue;
				case 20:
					array3[7] = 135;
					num2 = 339;
					continue;
				case 112:
					if (num30 != 1)
					{
						num2 = 246;
						continue;
					}
					goto case 305;
				case 189:
					array3[10] = (byte)num16;
					num2 = 87;
					continue;
				case 47:
					array[18] = 36;
					num2 = 57;
					continue;
				case 326:
					num15 = 167 + 85;
					num = 184;
					break;
				case 337:
					array[19] = 13;
					num = 230;
					break;
				case 78:
					array[11] = 151;
					num2 = 3;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 1;
					}
					continue;
				case 99:
					if (!xIAkNsKoqIl)
					{
						num2 = 98;
						continue;
					}
					return;
				case 216:
					array[30] = (byte)num15;
					num2 = 283;
					continue;
				case 9:
					num17 = 0;
					num2 = 256;
					continue;
				case 329:
					array[28] = (byte)num15;
					num2 = 202;
					continue;
				case 8:
					array3[9] = 14;
					num2 = 6;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 26;
					}
					continue;
				case 320:
					array[13] = (byte)num15;
					num2 = 221;
					continue;
				case 386:
					array3[10] = 80;
					num2 = 343;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 274;
					}
					continue;
				case 348:
					num16 = 45 + 118;
					num2 = 314;
					continue;
				case 274:
					num16 = 45 - 10;
					num = 79;
					break;
				case 377:
					L12kNeLFSMu = BJJ8SFksgdwjoISOJRpv(array2);
					num2 = 281;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 94;
					}
					continue;
				case 176:
					array[13] = (byte)num15;
					num2 = 288;
					continue;
				case 83:
					array3[14] = 68;
					num = 39;
					break;
				case 314:
					array3[13] = (byte)num16;
					num2 = 83;
					continue;
				case 79:
					array3[5] = (byte)num16;
					num2 = 381;
					continue;
				case 75:
					array[29] = (byte)num15;
					num2 = 201;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 3;
					}
					continue;
				case 350:
					num32 = 255u;
					num2 = 222;
					continue;
				case 230:
					num15 = 6 + 25;
					num2 = 311;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 74;
					}
					continue;
				case 359:
					array[11] = (byte)num15;
					num2 = 279;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 64;
					}
					continue;
				case 170:
					array3[15] = 165;
					num2 = 203;
					continue;
				case 356:
					array[10] = 102;
					num2 = 119;
					continue;
				case 270:
					num15 = 35 + 31;
					num2 = 78;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 95;
					}
					continue;
				case 255:
					array[14] = (byte)num15;
					num2 = 50;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 147;
					}
					continue;
				case 277:
					num16 = 71 + 117;
					num2 = 178;
					continue;
				case 59:
					array[9] = 107;
					num = 88;
					break;
				case 69:
					array = new byte[32];
					num2 = 104;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 95;
					}
					continue;
				case 173:
				case 233:
					num26++;
					num2 = 93;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 251;
					}
					continue;
				case 293:
					array[26] = 120;
					num2 = 207;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 297;
					}
					continue;
				case 35:
					deflateStream = new DeflateStream(new MemoryStream(array2), CompressionMode.Decompress);
					num2 = 76;
					continue;
				case 322:
					num15 = 169 - 56;
					num2 = 347;
					continue;
				case 291:
					array[17] = (byte)num15;
					num2 = 164;
					continue;
				case 5:
					num15 = 112 + 120;
					num2 = 355;
					continue;
				case 6:
					num16 = 19 + 74;
					num2 = 68;
					continue;
				case 147:
					num15 = 240 - 80;
					num2 = 14;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 22;
					}
					continue;
				case 205:
					num15 = 237 - 79;
					num2 = 289;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 34;
					}
					continue;
				case 90:
					num15 = 75 + 87;
					num2 = 333;
					continue;
				case 12:
					array[29] = (byte)num15;
					num2 = 129;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 78;
					}
					continue;
				case 67:
					array3[7] = (byte)num16;
					num2 = 93;
					continue;
				case 195:
					array[12] = 118;
					num2 = 352;
					continue;
				case 122:
					num29 += 8;
					num2 = 258;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 143;
					}
					continue;
				case 162:
					array8 = array;
					num2 = 130;
					continue;
				case 267:
					array3[5] = 121;
					num2 = 54;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 51;
					}
					continue;
				case 334:
					num32 <<= 8;
					num2 = 122;
					continue;
				case 276:
					num15 = 89 - 24;
					num2 = 100;
					continue;
				case 346:
					num16 = 139 - 46;
					num2 = 385;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 265;
					}
					continue;
				case 203:
					array7 = array3;
					num2 = 92;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 12;
					}
					continue;
				case 243:
					array[7] = 117;
					num2 = 317;
					continue;
				case 28:
					array[13] = (byte)num15;
					num = 74;
					break;
				case 129:
					num15 = 24 + 53;
					num2 = 56;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 216;
					}
					continue;
				case 30:
					L12kNeLFSMu = BJJ8SFksgdwjoISOJRpv(U3xDHaksMlFsJp6Vn8x9(memoryStream));
					num2 = 102;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 261;
					}
					continue;
				case 57:
					num15 = 77 + 67;
					num2 = 284;
					continue;
				case 301:
					num15 = 34 + 121;
					num2 = 132;
					continue;
				case 258:
					array6[num22 + num17] = (byte)((num31 & num32) >> num29);
					num = 148;
					break;
				case 310:
					array[28] = 102;
					num2 = 189;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 228;
					}
					continue;
				case 295:
					array[23] = (byte)num15;
					num2 = 278;
					continue;
				case 92:
					num30 = 1;
					num2 = 268;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 330;
					}
					continue;
				case 397:
					array[31] = 232;
					num2 = 180;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 73;
					}
					continue;
				case 49:
					num16 = 136 - 45;
					num2 = 170;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 212;
					}
					continue;
				case 316:
					array[11] = (byte)num15;
					num2 = 78;
					continue;
				case 131:
					num15 = 17 + 81;
					num2 = 255;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 150;
					}
					continue;
				case 139:
					array3[4] = 181;
					num2 = 239;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 35;
					}
					continue;
				case 118:
					num16 = 226 - 75;
					num = 70;
					break;
				case 244:
					array[19] = 169;
					num2 = 344;
					continue;
				case 336:
					num27 = 0u;
					num2 = 110;
					continue;
				case 237:
					num15 = 169 - 56;
					num2 = 36;
					continue;
				case 262:
					array[5] = (byte)num15;
					num2 = 294;
					continue;
				case 200:
					array2 = new byte[0];
					num2 = 48;
					continue;
				case 367:
					array3[9] = (byte)num16;
					num2 = 19;
					continue;
				case 50:
					num16 = 224 - 74;
					num2 = 107;
					continue;
				case 357:
					array3[14] = (byte)num16;
					num2 = 392;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 82;
					}
					continue;
				case 214:
					array3[8] = (byte)num16;
					num2 = 140;
					continue;
				case 192:
					num16 = 238 - 79;
					num2 = 127;
					continue;
				case 351:
					array3[8] = (byte)num16;
					num2 = 300;
					continue;
				case 279:
					num15 = 13 + 32;
					num2 = 316;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 189;
					}
					continue;
				case 54:
					array3[5] = 155;
					num2 = 165;
					continue;
				case 117:
					num15 = 34 + 120;
					num2 = 393;
					continue;
				case 261:
					tfLq62ksO1rB545BoR6R(memoryStream);
					num2 = 121;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 171;
					}
					continue;
				case 375:
					array[14] = (byte)num15;
					num2 = 131;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 93;
					}
					continue;
				case 384:
					num15 = 243 + 8;
					num2 = 71;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 163;
					}
					continue;
				case 358:
					array4 = array5;
					num2 = 38;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 187;
					}
					continue;
				case 211:
					array[31] = 252;
					num2 = 27;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 162;
					}
					continue;
				case 388:
					array[20] = 112;
					num2 = 208;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 338;
					}
					continue;
				case 335:
					array[3] = (byte)num15;
					num2 = 271;
					continue;
				default:
					array[26] = 41;
					num2 = 293;
					continue;
				case 36:
					array[19] = (byte)num15;
					num2 = 65;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 337;
					}
					continue;
				case 285:
					num15 = 82 + 48;
					num2 = 17;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 5;
					}
					continue;
				case 305:
					memoryStream = new MemoryStream();
					num2 = 35;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 12;
					}
					continue;
				case 187:
					num18 = array4.Length % 4;
					num2 = 143;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 60;
					}
					continue;
				case 282:
					num16 = 2 + 114;
					num2 = 260;
					continue;
				case 256:
				case 324:
					if (num17 >= num18)
					{
						num2 = 173;
						continue;
					}
					goto case 18;
				case 63:
					array[27] = (byte)num15;
					num2 = 197;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 25;
					}
					continue;
				case 382:
					num15 = 13 + 71;
					num2 = 362;
					continue;
				case 98:
					aQVjJ3kb3Fc00iL6P6sI = new vpHjm6kDDRWPs2gcoFH7.aQVjJ3kb3Fc00iL6P6sI((Stream)fKjqCWkscIUQxfrkHjES(fea5LCksXUkUovmttxV4(typeof(vpHjm6kDDRWPs2gcoFH7).TypeHandle).Assembly, vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x11D1040B ^ 0x11D10E37)));
					num2 = 280;
					continue;
				case 80:
					array[2] = 158;
					num2 = 101;
					continue;
				case 330:
					num28 = 0;
					num2 = 183;
					continue;
				case 240:
					array3[4] = 160;
					num2 = 91;
					continue;
				case 294:
					array[5] = 149;
					num2 = 384;
					continue;
				case 60:
					array6 = new byte[array4.Length];
					num2 = 53;
					continue;
				case 349:
					num15 = 133 - 41;
					num = 16;
					break;
				case 212:
					array3[13] = (byte)num16;
					num2 = 348;
					continue;
				case 288:
					num15 = 126 - 42;
					num2 = 61;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 292;
					}
					continue;
				case 201:
					num15 = 82 + 122;
					num2 = 12;
					continue;
				case 248:
					array[20] = 135;
					num2 = 276;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 34;
					}
					continue;
				case 342:
					num15 = 83 + 79;
					num2 = 1;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 28;
					}
					continue;
				case 10:
					num35 = num26 % num34;
					num2 = 97;
					continue;
				case 323:
					num15 = 165 - 55;
					num2 = 2;
					continue;
				case 164:
					array[17] = 8;
					num2 = 219;
					continue;
				case 374:
					array[27] = 85;
					num2 = 236;
					continue;
				case 226:
					num15 = 0 + 17;
					num2 = 360;
					continue;
				case 88:
					num15 = 227 - 75;
					num2 = 25;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 14;
					}
					continue;
				case 202:
					array[28] = 219;
					num2 = 125;
					continue;
				case 284:
					array[19] = (byte)num15;
					num2 = 244;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 92;
					}
					continue;
				case 308:
					array3[0] = (byte)num16;
					num2 = 296;
					continue;
				case 21:
					array[17] = 40;
					num2 = 332;
					continue;
				case 101:
					num15 = 179 - 112;
					num2 = 188;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 187;
					}
					continue;
				case 172:
					array[15] = 110;
					num2 = 150;
					continue;
				case 29:
					array[23] = 25;
					num2 = 158;
					continue;
				case 341:
					num4 += num24;
					num2 = 387;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 137;
					}
					continue;
				case 138:
					array3[11] = 148;
					num = 118;
					break;
				case 146:
					num15 = 190 - 63;
					num2 = 134;
					continue;
				case 144:
					array[8] = 185;
					num2 = 229;
					continue;
				case 42:
					num16 = 173 - 122;
					num2 = 103;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 181;
					}
					continue;
				case 100:
					array[20] = (byte)num15;
					num = 301;
					break;
				case 152:
					if (num18 > 0)
					{
						num = 105;
						break;
					}
					goto case 215;
				case 213:
					array6[num22 + 3] = (byte)((num23 & 0xFF000000u) >> 24);
					num2 = 67;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 233;
					}
					continue;
				case 268:
					num28++;
					num2 = 34;
					continue;
				case 371:
					array3[10] = (byte)num16;
					num2 = 396;
					continue;
				case 165:
					array3[5] = 92;
					num2 = 274;
					continue;
				case 298:
					num15 = 114 + 68;
					num2 = 225;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 180;
					}
					continue;
				case 339:
					num16 = 45 + 59;
					num2 = 232;
					continue;
				case 355:
					array[7] = (byte)num15;
					num2 = 115;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 98;
					}
					continue;
				case 65:
					num15 = 153 - 51;
					num2 = 5;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 63;
					}
					continue;
				case 137:
					num15 = 62 + 41;
					num2 = 73;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 75;
					}
					continue;
				case 191:
					num15 = 136 - 58;
					num2 = 395;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 266;
					}
					continue;
				case 71:
					array[24] = (byte)num15;
					num = 166;
					break;
				case 338:
					array[20] = 179;
					num2 = 248;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 190;
					}
					continue;
				case 265:
					array[16] = 8;
					num2 = 21;
					continue;
				case 231:
					array[28] = (byte)num15;
					num2 = 281;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 310;
					}
					continue;
				case 151:
					array[0] = (byte)num15;
					num2 = 66;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 121;
					}
					continue;
				case 120:
					num33 <<= 8;
					num2 = 41;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 29;
					}
					continue;
				case 368:
					array3[3] = 112;
					num2 = 242;
					continue;
				case 209:
					array3[8] = (byte)num16;
					num2 = 369;
					continue;
				case 307:
					num16 = 153 - 51;
					num2 = 38;
					continue;
				case 45:
					array[8] = 154;
					num2 = 7;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 144;
					}
					continue;
				case 55:
					num4 = 0u;
					num2 = 128;
					continue;
				case 380:
					array3[12] = 238;
					num = 153;
					break;
				case 193:
				case 251:
					if (num26 >= num19)
					{
						num2 = 161;
						if (!XGrpiFksepLCgSfO3SDj())
						{
							num2 = 64;
						}
						continue;
					}
					goto case 10;
				case 94:
					num15 = 82 + 39;
					num2 = 335;
					continue;
				case 4:
					num15 = 167 - 55;
					num = 96;
					break;
				case 85:
					num16 = 228 - 76;
					num2 = 325;
					continue;
				case 156:
					array[15] = 157;
					num2 = 252;
					continue;
				case 110:
					num26 = 0;
					num2 = 3;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 193;
					}
					continue;
				case 353:
					array3[13] = (byte)num16;
					num2 = 49;
					continue;
				case 345:
					array[4] = 88;
					num = 33;
					break;
				case 376:
					array[25] = (byte)num15;
					num2 = 24;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 254;
					}
					continue;
				case 215:
					num23 = num4 ^ num33;
					num2 = 116;
					continue;
				case 66:
					num33 = 0u;
					num = 142;
					break;
				case 207:
					array3[2] = 166;
					num2 = 11;
					continue;
				case 228:
					num15 = 1 + 66;
					num2 = 329;
					continue;
				case 160:
				case 171:
				case 281:
					nQnkNLAKZBx = (string[])fqZsOEksIj0u5EIntxKD((Assembly)L12kNeLFSMu);
					num = 259;
					break;
				case 344:
					array[19] = 115;
					num2 = 208;
					continue;
				case 149:
					if (num26 == num19 - 1)
					{
						num2 = 152;
						continue;
					}
					goto case 215;
				case 166:
					num15 = 196 - 65;
					num2 = 264;
					continue;
				case 217:
					array[14] = 183;
					num2 = 62;
					continue;
				case 340:
					num16 = 27 + 1;
					num2 = 5;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 58;
					}
					continue;
				case 1:
				case 154:
					if (num25 >= num18)
					{
						num = 51;
						break;
					}
					goto case 174;
				case 250:
					num15 = 158 - 52;
					num2 = 262;
					continue;
				case 229:
					num15 = 241 - 80;
					num = 175;
					break;
				case 372:
					array[0] = 139;
					num2 = 86;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 41;
					}
					continue;
				case 95:
					array[7] = (byte)num15;
					num2 = 5;
					continue;
				case 72:
					num33 = 0u;
					num2 = 52;
					continue;
				case 190:
					array3[7] = 115;
					num2 = 8;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 20;
					}
					continue;
				case 210:
					array[22] = 245;
					num2 = 328;
					continue;
				case 107:
					array3[15] = (byte)num16;
					num2 = 68;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 170;
					}
					continue;
				case 62:
					num15 = 188 - 62;
					num2 = 303;
					continue;
				case 103:
					array3[10] = (byte)num16;
					num2 = 307;
					continue;
				case 188:
					array[2] = (byte)num15;
					num2 = 94;
					continue;
				case 61:
					array6[num22 + 1] = (byte)((num23 & 0xFF00) >> 8);
					num2 = 126;
					continue;
				case 297:
					num15 = 27 + 76;
					num2 = 158;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 167;
					}
					continue;
				case 7:
					num24 = (uint)((array8[num27 + 3] << 24) | (array8[num27 + 2] << 16) | (array8[num27 + 1] << 8) | array8[num27]);
					num2 = 303;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 350;
					}
					continue;
				case 204:
					array3[14] = 133;
					num2 = 192;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 119;
					}
					continue;
				case 387:
					num33 = (uint)((array4[num27 + 3] << 24) | (array4[num27 + 2] << 16) | (array4[num27 + 1] << 8) | array4[num27]);
					num2 = 36;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 159;
					}
					continue;
				case 196:
					num15 = 243 - 81;
					num2 = 391;
					continue;
				case 259:
					xIAkNsKoqIl = true;
					num2 = 313;
					continue;
				case 32:
					array[7] = (byte)num15;
					num2 = 117;
					continue;
				case 177:
					array[26] = 96;
					num2 = 191;
					continue;
				case 206:
					num16 = 169 - 56;
					num2 = 209;
					continue;
				case 181:
					array3[6] = (byte)num16;
					num2 = 190;
					continue;
				case 158:
					num15 = 113 + 19;
					num2 = 46;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 71;
					}
					continue;
				case 313:
					return;
				case 86:
					num15 = 9 + 30;
					num = 151;
					break;
				case 280:
					BGEqTeksE9bgvZoSHvXE(DXMsh4ksj54ilYctITJR(aQVjJ3kb3Fc00iL6P6sI), 0L);
					num2 = 200;
					continue;
				case 273:
					array[16] = 175;
					num2 = 242;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 247;
					}
					continue;
				case 3:
					array[11] = 199;
					num2 = 321;
					continue;
				case 366:
					num27 = (uint)num22;
					num2 = 341;
					continue;
				case 319:
					array[6] = 165;
					num2 = 185;
					continue;
				case 23:
					array[15] = 115;
					num = 172;
					break;
				case 56:
					array[14] = (byte)num15;
					num2 = 217;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 34;
					}
					continue;
				case 17:
					array[12] = (byte)num15;
					num2 = 135;
					continue;
				case 185:
					array[6] = 157;
					num = 243;
					break;
				case 286:
					num16 = 173 - 57;
					num2 = 367;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 59;
					}
					continue;
				case 126:
					array6[num22 + 2] = (byte)((num23 & 0xFF0000) >> 16);
					num2 = 213;
					continue;
				case 364:
					array[27] = (byte)num15;
					num2 = 265;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 374;
					}
					continue;
				case 155:
					num16 = 185 - 61;
					num2 = 353;
					continue;
				case 180:
					array[31] = 118;
					num2 = 211;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 6;
					}
					continue;
				case 25:
					array[9] = (byte)num15;
					num2 = 111;
					continue;
				case 304:
					array[3] = 115;
					num2 = 326;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 208;
					}
					continue;
				case 81:
					array[12] = 124;
					num2 = 285;
					continue;
				case 16:
					array[30] = (byte)num15;
					num2 = 397;
					continue;
				case 167:
					array[26] = (byte)num15;
					num2 = 177;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 29;
					}
					continue;
				case 127:
					array3[15] = (byte)num16;
					num2 = 50;
					continue;
				case 123:
					array[12] = (byte)num15;
					num2 = 114;
					continue;
				case 142:
					num4 += num24;
					num2 = 128;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 253;
					}
					continue;
				case 115:
					array[8] = 138;
					num2 = 220;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 107;
					}
					continue;
				case 370:
					array3[1] = 145;
					num2 = 86;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 207;
					}
					continue;
				case 224:
					array[28] = 120;
					num2 = 73;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 39;
					}
					continue;
				case 175:
					array[9] = (byte)num15;
					num2 = 196;
					continue;
				case 82:
					array3[13] = (byte)num16;
					num2 = 10;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 155;
					}
					continue;
				case 2:
					array[2] = (byte)num15;
					num2 = 227;
					continue;
				case 113:
					if (num30 != 0)
					{
						num2 = 112;
						continue;
					}
					goto case 377;
				case 266:
					array3[1] = 121;
					num2 = 370;
					continue;
				case 53:
					num34 = array8.Length / 4;
					num2 = 55;
					continue;
				case 315:
					num16 = 70 + 79;
					num2 = 351;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 168;
					}
					continue;
				case 379:
					array3[11] = 150;
					num2 = 207;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 346;
					}
					continue;
				case 105:
					num31 = num4 ^ num33;
					num2 = 7;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 9;
					}
					continue;
				case 352:
					array[13] = 41;
					num2 = 342;
					continue;
				case 73:
					num15 = 60 + 14;
					num2 = 231;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 150;
					}
					continue;
				case 148:
					num17++;
					num2 = 324;
					continue;
				case 168:
					array3[14] = (byte)num16;
					num2 = 204;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 14;
					}
					continue;
				case 14:
					array[16] = (byte)num15;
					num2 = 177;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 273;
					}
					continue;
				case 389:
					num25++;
					num2 = 1;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 0;
					}
					continue;
				case 26:
					array3[10] = 106;
					num2 = 187;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 272;
					}
					continue;
				case 249:
					array[27] = 96;
					num2 = 159;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 309;
					}
					continue;
				case 41:
					num33 |= array4[array4.Length - (1 + num25)];
					num2 = 389;
					continue;
				case 221:
					num15 = 51 - 42;
					num2 = 176;
					continue;
				case 347:
					array[4] = (byte)num15;
					num = 182;
					break;
				case 22:
					array[14] = (byte)num15;
					num2 = 112;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 238;
					}
					continue;
				case 390:
					array[21] = 225;
					num = 90;
					break;
				case 254:
					array[25] = 110;
					num2 = 13;
					continue;
				case 135:
					num15 = 147 - 49;
					num2 = 8;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 123;
					}
					continue;
				case 325:
					array3[12] = (byte)num16;
					num2 = 340;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 13;
					}
					continue;
				case 227:
					num15 = 231 - 77;
					num2 = 363;
					continue;
				case 264:
					array[24] = (byte)num15;
					num2 = 186;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 162;
					}
					continue;
				case 222:
					num29 = 0;
					num2 = 27;
					continue;
				case 263:
					array3[9] = 137;
					num2 = 286;
					continue;
				case 378:
					array3[3] = (byte)num16;
					num2 = 240;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 188;
					}
					continue;
				case 106:
					num15 = 237 - 79;
					num = 375;
					break;
				case 114:
					array[12] = 129;
					num2 = 162;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 195;
					}
					continue;
				case 321:
					array[12] = 126;
					num2 = 81;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 37;
					}
					continue;
				case 18:
					if (num17 > 0)
					{
						num2 = 31;
						if (x2f1s3kssKwvE8CMNlLw() == null)
						{
							num2 = 334;
						}
						continue;
					}
					goto case 258;
				case 97:
					num22 = num26 * 4;
					num2 = 294;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 312;
					}
					continue;
				case 174:
					if (num25 > 0)
					{
						num2 = 120;
						if (x2f1s3kssKwvE8CMNlLw() != null)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 41;
				case 391:
					array[9] = (byte)num15;
					num = 59;
					break;
				case 361:
					array[4] = (byte)num15;
					num2 = 345;
					continue;
				case 242:
					array3[3] = 90;
					num = 31;
					break;
				case 239:
					num16 = 157 - 52;
					num2 = 179;
					continue;
				case 133:
					array[18] = 45;
					num2 = 47;
					continue;
				case 194:
					array[9] = (byte)num15;
					num2 = 199;
					continue;
				case 89:
					array[3] = (byte)num15;
					num2 = 304;
					continue;
				case 186:
					num15 = 123 - 31;
					num2 = 336;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 365;
					}
					continue;
				case 257:
					array8[num28] ^= array7[num28];
					num2 = 268;
					continue;
				case 260:
					array3[1] = (byte)num16;
					num2 = 218;
					continue;
				case 290:
					array[18] = 84;
					num2 = 223;
					continue;
				case 245:
					num19++;
					num2 = 336;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 210;
					}
					continue;
				case 220:
					array[8] = 149;
					num2 = 45;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 37;
					}
					continue;
				case 208:
					array[19] = 142;
					num2 = 89;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 237;
					}
					continue;
				case 199:
					num15 = 190 - 63;
					num2 = 53;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 108;
					}
					continue;
				case 182:
					num15 = 173 - 57;
					num2 = 361;
					continue;
				case 84:
					array[25] = (byte)num15;
					num2 = 43;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 31;
					}
					continue;
				case 134:
					array[10] = (byte)num15;
					num2 = 38;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 64;
					}
					continue;
				case 331:
					num16 = 156 - 52;
					num2 = 214;
					continue;
				case 38:
					array3[11] = (byte)num16;
					num2 = 221;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 379;
					}
					continue;
				case 381:
					array3[6] = 35;
					num2 = 6;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 0;
					}
					continue;
				case 27:
					if (num26 == num19 - 1)
					{
						num2 = 124;
						continue;
					}
					goto case 366;
				case 218:
					array3[1] = 220;
					num2 = 266;
					continue;
				case 328:
					num15 = 199 - 66;
					num2 = 295;
					continue;
				case 157:
					array[6] = 103;
					num = 319;
					break;
				case 163:
					array[5] = (byte)num15;
					num2 = 157;
					continue;
				case 396:
					array3[10] = 120;
					num = 386;
					break;
				case 58:
					array3[12] = (byte)num16;
					num2 = 85;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 380;
					}
					continue;
				case 219:
					num15 = 169 - 56;
					num2 = 234;
					continue;
				case 130:
					array3 = new byte[16];
					num2 = 26;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 37;
					}
					continue;
				case 311:
					array[20] = (byte)num15;
					num2 = 119;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 388;
					}
					continue;
				case 48:
					array5 = (byte[])DP4ySSksdwBtODJYH9Gq(aQVjJ3kb3Fc00iL6P6sI, (int)PhlTtMksQk9rEn5hcUD0(DXMsh4ksj54ilYctITJR(aQVjJ3kb3Fc00iL6P6sI)));
					num2 = 69;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 57;
					}
					continue;
				case 33:
					array[4] = 46;
					num2 = 102;
					continue;
				case 111:
					num15 = 66 - 52;
					num2 = 194;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 80;
					}
					continue;
				case 392:
					num16 = 207 - 69;
					num2 = 168;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 60;
					}
					continue;
				case 11:
					array3[2] = 123;
					num2 = 46;
					continue;
				case 39:
					num16 = 178 - 59;
					num2 = 357;
					continue;
				case 247:
					array[16] = 148;
					num2 = 265;
					continue;
				case 287:
					num15 = 14 + 95;
					num2 = 320;
					continue;
				case 43:
					num15 = 177 - 59;
					num2 = 376;
					continue;
				case 141:
					array[22] = 150;
					num2 = 208;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 327;
					}
					continue;
				case 360:
					array[30] = (byte)num15;
					num2 = 349;
					continue;
				case 128:
					num24 = 0u;
					num2 = 72;
					continue;
				case 140:
					array3[8] = 136;
					num2 = 315;
					continue;
				case 317:
					array[7] = 128;
					num2 = 145;
					continue;
				case 169:
					array[28] = (byte)num15;
					num2 = 224;
					continue;
				case 44:
					num15 = 81 + 108;
					num2 = 136;
					continue;
				case 232:
					array3[7] = (byte)num16;
					num2 = 277;
					continue;
				case 303:
					array[15] = (byte)num15;
					num = 23;
					break;
				case 116:
					array6[num22] = (byte)(num23 & 0xFF);
					num2 = 61;
					continue;
				case 318:
					array[0] = (byte)num15;
					num2 = 44;
					continue;
				case 52:
					if (num18 > 0)
					{
						num2 = 245;
						continue;
					}
					goto case 336;
				case 31:
					array3[3] = 48;
					num2 = 24;
					continue;
				case 395:
					array[26] = (byte)num15;
					num = 275;
					break;
				case 333:
					array[21] = (byte)num15;
					num2 = 112;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 141;
					}
					continue;
				case 102:
					array[5] = 81;
					num2 = 3;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 4;
					}
					continue;
				case 197:
					num15 = 88 + 47;
					num2 = 241;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 214;
					}
					continue;
				case 272:
					num16 = 44 + 98;
					num2 = 371;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 247;
					}
					continue;
				case 70:
					array3[12] = (byte)num16;
					num2 = 85;
					continue;
				case 309:
					num15 = 68 + 62;
					num2 = 364;
					continue;
				case 37:
					array3[0] = 110;
					num = 269;
					break;
				case 271:
					num15 = 112 + 33;
					num2 = 85;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 89;
					}
					continue;
				case 292:
					array[14] = (byte)num15;
					num2 = 97;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 106;
					}
					continue;
				case 77:
					num15 = 14 + 8;
					num2 = 14;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 10;
					}
					continue;
				case 74:
					num15 = 173 - 57;
					num2 = 198;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 134;
					}
					continue;
				case 179:
					array3[5] = (byte)num16;
					num2 = 207;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 267;
					}
					continue;
				case 13:
					array[26] = 125;
					num2 = 0;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 0;
					}
					continue;
				case 383:
					array[0] = 119;
					num2 = 372;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 87;
					}
					continue;
				case 362:
					array[23] = (byte)num15;
					num2 = 29;
					continue;
				case 76:
					try
					{
						GUU72PksR9uLq2T4qgn8(deflateStream, memoryStream);
						int num20 = 0;
						if (XGrpiFksepLCgSfO3SDj())
						{
							num20 = 0;
						}
						switch (num20)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num21;
						if (deflateStream == null)
						{
							num21 = 2;
							goto IL_324e;
						}
						goto IL_3264;
						IL_3264:
						y8UJLkks6GDHlyT4MvdF(deflateStream);
						num21 = 1;
						if (x2f1s3kssKwvE8CMNlLw() != null)
						{
							num21 = 1;
						}
						goto IL_324e;
						IL_324e:
						switch (num21)
						{
						case 2:
							goto end_IL_3239;
						case 1:
							goto end_IL_3239;
						}
						goto IL_3264;
						end_IL_3239:;
					}
					goto case 30;
				case 198:
					array[13] = (byte)num15;
					num2 = 287;
					continue;
				case 327:
					array[22] = 114;
					num = 210;
					break;
				case 24:
					num16 = 159 - 71;
					num2 = 168;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 378;
					}
					continue;
				case 225:
					array[18] = (byte)num15;
					num2 = 133;
					continue;
				case 343:
					num16 = 172 - 57;
					num2 = 189;
					continue;
				case 306:
					array[1] = 22;
					num2 = 15;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 15;
					}
					continue;
				case 238:
					num15 = 214 - 71;
					num2 = 56;
					continue;
				case 332:
					num15 = 183 - 61;
					num2 = 291;
					continue;
				case 136:
					array[0] = (byte)num15;
					num2 = 383;
					continue;
				case 93:
					num16 = 139 - 44;
					num2 = 42;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 373;
					}
					continue;
				case 125:
					array[29] = 98;
					num2 = 8;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 137;
					}
					continue;
				case 289:
					array[1] = (byte)num15;
					num2 = 101;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 109;
					}
					continue;
				case 369:
					num16 = 35 + 34;
					num2 = 299;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 110;
					}
					continue;
				case 363:
					array[2] = (byte)num15;
					num2 = 80;
					continue;
				case 19:
					array3[9] = 161;
					num2 = 8;
					continue;
				case 373:
					array3[7] = (byte)num16;
					num2 = 206;
					continue;
				case 124:
					if (num18 > 0)
					{
						num2 = 66;
						continue;
					}
					goto case 366;
				case 300:
					array3[8] = 250;
					num2 = 175;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 263;
					}
					continue;
				case 104:
					num15 = 38 + 96;
					num2 = 318;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 19;
					}
					continue;
				case 108:
					array[10] = (byte)num15;
					num = 146;
					break;
				case 150:
					array[15] = 100;
					num2 = 156;
					continue;
				case 68:
					array3[6] = (byte)num16;
					num2 = 42;
					continue;
				case 119:
					array[10] = 215;
					num2 = 235;
					continue;
				case 143:
					num19 = array4.Length / 4;
					num2 = 60;
					continue;
				case 354:
					num15 = 155 - 51;
					num2 = 84;
					continue;
				case 46:
					array3[2] = 28;
					num2 = 83;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 368;
					}
					continue;
				case 40:
				case 246:
					L12kNeLFSMu = BJJ8SFksgdwjoISOJRpv(MD9iqmksqrqeeEwJpgy7(array2, 0u));
					num2 = 89;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 160;
					}
					continue;
				case 236:
					num15 = 48 + 109;
					num2 = 169;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 60;
					}
					continue;
				case 91:
					array3[4] = 205;
					num2 = 56;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 139;
					}
					continue;
				case 87:
					num16 = 134 - 59;
					num2 = 103;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 10;
					}
					continue;
				case 223:
					array[18] = 163;
					num2 = 144;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 298;
					}
					continue;
				case 132:
					array[21] = (byte)num15;
					num2 = 390;
					continue;
				case 302:
					array[27] = (byte)num15;
					num2 = 10;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 65;
					}
					continue;
				case 184:
					array[3] = (byte)num15;
					num2 = 322;
					continue;
				case 252:
					array[16] = 143;
					num2 = 77;
					continue;
				case 278:
					array[23] = 163;
					num2 = 382;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 365;
					}
					continue;
				case 241:
					array[27] = (byte)num15;
					num2 = 249;
					if (x2f1s3kssKwvE8CMNlLw() != null)
					{
						num2 = 49;
					}
					continue;
				case 235:
					num15 = 179 - 59;
					num2 = 359;
					continue;
				case 145:
					num15 = 247 - 82;
					num2 = 9;
					if (XGrpiFksepLCgSfO3SDj())
					{
						num2 = 32;
					}
					continue;
				case 153:
					num16 = 211 - 70;
					num2 = 68;
					if (x2f1s3kssKwvE8CMNlLw() == null)
					{
						num2 = 82;
					}
					continue;
				case 393:
					array[7] = (byte)num15;
					num2 = 270;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 180;
					}
					continue;
				case 283:
					array[30] = 104;
					num2 = 226;
					continue;
				case 51:
				case 159:
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
					num2 = 149;
					if (!XGrpiFksepLCgSfO3SDj())
					{
						num2 = 11;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] R1FkNSQr1Nc(Assembly P_0)
	{
		if (P_0 == Type.GetTypeFromHandle(yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(33554502)).Assembly)
		{
			if (!xIAkNsKoqIl)
			{
				r7akN5hJTVa();
			}
			List<string> list = new List<string>();
			list.AddRange(P_0.GetManifestResourceNames());
			list.AddRange(((Assembly)L12kNeLFSMu).GetManifestResourceNames());
			return list.ToArray();
		}
		return P_0.GetManifestResourceNames();
	}

	private static Assembly OeYkNxdjAxd(object P_0, ResolveEventArgs P_1)
	{
		if (!xIAkNsKoqIl)
		{
			r7akN5hJTVa();
		}
		string name = P_1.Name;
		for (int i = 0; i < nQnkNLAKZBx.Length; i++)
		{
			if (nQnkNLAKZBx[i] == name)
			{
				return (Assembly)L12kNeLFSMu;
			}
		}
		return null;
	}

	public P6syMqkNNLI24Cmarav7()
	{
		AppDomain.CurrentDomain.ResourceResolve += OeYkNxdjAxd;
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!zmOkNXJB8ue)
		{
			zmOkNXJB8ue = true;
			new P6syMqkNNLI24Cmarav7();
		}
	}

	internal static Type fea5LCksXUkUovmttxV4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object fKjqCWkscIUQxfrkHjES(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object DXMsh4ksj54ilYctITJR(object P_0)
	{
		return ((vpHjm6kDDRWPs2gcoFH7.aQVjJ3kb3Fc00iL6P6sI)P_0).m9OIO8Q0EK();
	}

	internal static void BGEqTeksE9bgvZoSHvXE(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long PhlTtMksQk9rEn5hcUD0(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object DP4ySSksdwBtODJYH9Gq(object P_0, int P_1)
	{
		return ((vpHjm6kDDRWPs2gcoFH7.aQVjJ3kb3Fc00iL6P6sI)P_0).d1Qkbp5Tf8s(P_1);
	}

	internal static object BJJ8SFksgdwjoISOJRpv(object P_0)
	{
		return rIb2RSkNjwfatadOXjO3.oVEkNqcquut((byte[])P_0);
	}

	internal static void GUU72PksR9uLq2T4qgn8(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void y8UJLkks6GDHlyT4MvdF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object U3xDHaksMlFsJp6Vn8x9(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void tfLq62ksO1rB545BoR6R(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object MD9iqmksqrqeeEwJpgy7(object P_0, uint P_1)
	{
		return rIb2RSkNjwfatadOXjO3.WU7kNIlhNjL((byte[])P_0, P_1);
	}

	internal static object fqZsOEksIj0u5EIntxKD(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool XGrpiFksepLCgSfO3SDj()
	{
		return (object)null == null;
	}

	internal static object x2f1s3kssKwvE8CMNlLw()
	{
		return null;
	}
}
