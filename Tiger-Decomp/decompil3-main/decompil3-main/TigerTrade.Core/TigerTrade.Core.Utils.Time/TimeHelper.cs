using System;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;
using sMFne2GHAlf89keFJ43Q;

namespace TigerTrade.Core.Utils.Time;

public static class TimeHelper
{
	internal static TimeHelper mDtPdrkHGhUVbejvXT8n;

	public static C9uTJdGH8bibVknh46Q6 PlayerTimeProvider { get; set; }

	public static TimeSpan KyivTimeOffsetUtc { get; }

	public static TimeSpan MoscowTimeOffsetUtc { get; }

	public static TimeSpan EasternTimeOffsetUtc { get; }

	public static TimeSpan CentralTimeOffsetUtc { get; }

	private static TimeZoneInfo KyivStandardTime { get; }

	private static TimeZoneInfo RussianStandardTime { get; }

	private static TimeZoneInfo EasternStandardTime { get; }

	private static TimeZoneInfo CentralStandardTime { get; }

	public static DateTime LocalTime => NVo2i5kHvYZKMc6JmDyQ();

	public static DateTime UtcTime => DateTime.UtcNow;

	public static DateTime KyivTime => E8oxsEkHld14I3pEySM3(JaotyrkHBrO1DHVWISjG(), nN0V3mkHabPwUgdJdTSL(), aV2i1dkHiY2KB10KhxEE());

	public static DateTime MoscowTime => TimeZoneInfo.ConvertTime(LocalTime, TimeZoneInfo.Local, RussianStandardTime);

	public static DateTime EasternTime => TimeZoneInfo.ConvertTime(JaotyrkHBrO1DHVWISjG(), TimeZoneInfo.Local, EasternStandardTime);

	public static DateTime ChicagoTime => TimeZoneInfo.ConvertTime(LocalTime, (TimeZoneInfo)nN0V3mkHabPwUgdJdTSL(), CentralStandardTime);

	public static bool AppLocalTime { get; set; }

	public static long NtpTimeDiff { get; set; }

	private static TimeSpan MoscowTimeOffset { get; }

	private static TimeSpan EasternTimeOffset { get; }

	static TimeHelper()
	{
		Li4aEVkH4GZuXgu2f9Jw();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 4:
				CentralStandardTime = TimeZoneInfo.FindSystemTimeZoneById(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--737722733 ^ 0x2BF8C1B7));
				num = 1;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_783c5ce2dc1c46a2a6e7d2bdb7898bca == 0)
				{
					num = 1;
				}
				break;
			case 3:
				KyivStandardTime = TimeZoneInfo.FindSystemTimeZoneById(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1999650146 ^ -1999650106));
				RussianStandardTime = (TimeZoneInfo)y0FIVpkHDMrL5d26rBRk(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x78D396D8 ^ 0x78D396A6));
				EasternStandardTime = (TimeZoneInfo)y0FIVpkHDMrL5d26rBRk(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-624753169 ^ -624753341));
				num = 4;
				break;
			case 1:
				KyivTimeOffsetUtc = heA3P1kHbMCxIpxIUL3B(TimeZoneInfo.ConvertTime(DateTime.UtcNow, KyivStandardTime), DateTime.UtcNow);
				num = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_ab31c8f21877491e810e3daff7636f6b == 0)
				{
					num = 0;
				}
				break;
			default:
			{
				MoscowTimeOffsetUtc = TimeZoneInfo.ConvertTime(DateTime.UtcNow, (TimeZoneInfo)fhsKoYkHNelNZhKW9UBi()) - Jni00gkHkqS5XCHaWTZx();
				EasternTimeOffsetUtc = dYCkljkH52yQZDpxBiCB(Jni00gkHkqS5XCHaWTZx(), bJIHGhkH1tV7V6MiOY4n()) - Jni00gkHkqS5XCHaWTZx();
				CentralTimeOffsetUtc = TimeZoneInfo.ConvertTime(Jni00gkHkqS5XCHaWTZx(), CentralStandardTime) - DateTime.UtcNow;
				DateTime now = DateTime.Now;
				MoscowTimeOffset = now - TimeZoneInfo.ConvertTime(now, TimeZoneInfo.FindSystemTimeZoneById((string)MaapxkkHSjMwyEPWbZhu(-44540535 ^ -44540425)));
				EasternTimeOffset = heA3P1kHbMCxIpxIUL3B(now, dYCkljkH52yQZDpxBiCB(now, y0FIVpkHDMrL5d26rBRk(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x16AD7E76 ^ 0x16AD7EDA))));
				num = 2;
				break;
			}
			}
		}
	}

	public static DateTime GetCurrTime(string exchange)
	{
		int num = 2;
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = WCUTKXkHxHu9Jmc5NFH4(exchange);
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_e616f9da38cd421ab3eda2a8682c4989 == 0)
					{
						num2 = 1;
					}
					break;
				case 43:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x28C965BE ^ 0x28C9641C))
					{
						goto case 46;
					}
					goto case 3;
				case 35:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x42D899B5 ^ 0x42D8988D)))
					{
						num2 = 6;
						break;
					}
					goto case 21;
				case 39:
					if (num3 == 3677625335u && exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-123775059 ^ -123775387))
					{
						goto case 46;
					}
					goto case 3;
				case 1:
					if (num3 > 2020397624)
					{
						if (num3 > 3516542306u)
						{
							if (num3 <= 3677625335u)
							{
								if (num3 != 3573002156u)
								{
									num2 = 23;
									if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_cffb9074f7244a46a7e8c2f280b0a849 != 0)
									{
										num2 = 22;
									}
									break;
								}
								goto default;
							}
							goto case 42;
						}
						if (num3 <= 2618539384u)
						{
							goto case 18;
						}
						if (num3 <= 2769128249u)
						{
							goto case 13;
						}
						if (num3 == 2770757464u)
						{
							if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x1EFE0A28 ^ 0x1EFE0B20)))
							{
								num2 = 11;
								if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0fc6a9bedd3f4ce189c95b2dffc82884 != 0)
								{
									num2 = 36;
								}
								break;
							}
							goto IL_088d;
						}
						if (num3 != 3516542306u || !(exchange == (string)MaapxkkHSjMwyEPWbZhu(-894902996 ^ -894902444)))
						{
							goto case 3;
						}
						num2 = 50;
						break;
					}
					if (num3 <= 1041130325)
					{
						if (num3 <= 207070566)
						{
							num2 = 51;
							break;
						}
						goto case 33;
					}
					goto case 38;
				case 10:
					if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x2CBEEA31 ^ 0x2CBEEB87)))
					{
						num2 = 15;
						break;
					}
					goto case 46;
				case 33:
					if (num3 <= 665101479)
					{
						num2 = 37;
						break;
					}
					if (num3 == 702486649)
					{
						goto case 9;
					}
					if (num3 != 1041130325)
					{
						goto case 3;
					}
					goto case 45;
				case 19:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-2002318893 ^ -2002318379)))
					{
						num2 = 24;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_a7002cbefdd44e2bb93e2ef1e5d81bc8 == 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 46;
				case 9:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--871424829 ^ 0x33F0E2BB))
					{
						goto case 21;
					}
					goto case 3;
				case 34:
					if (num3 == 1976993578)
					{
						if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1461292091 ^ -1461292641)))
						{
							goto case 46;
						}
						goto case 3;
					}
					num2 = 37;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_dbd670bee0e840219277072e73777cbe == 0)
					{
						num2 = 41;
					}
					break;
				case 4:
					if (num3 == 207070566)
					{
						goto case 47;
					}
					goto case 3;
				case 18:
					if (num3 == 2132487982)
					{
						goto case 30;
					}
					if (num3 == 2204885439u)
					{
						if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x1A5F1B9E ^ 0x1A5F19A6)))
						{
							num2 = 8;
							break;
						}
					}
					else
					{
						if (num3 != 2618539384u)
						{
							goto case 3;
						}
						if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x2D313048 ^ 0x2D31322E)))
						{
							num2 = 3;
							break;
						}
					}
					goto case 46;
				case 37:
					if (num3 == 433752978)
					{
						goto case 29;
					}
					if (num3 != 665101479)
					{
						goto case 3;
					}
					if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-90307782 ^ -90307880)))
					{
						num2 = 32;
						break;
					}
					goto case 46;
				case 51:
					if (num3 == 62387165)
					{
						if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x5EA8FF2A ^ 0x5EA8FD6C)))
						{
							num2 = 14;
							break;
						}
						goto case 46;
					}
					if (num3 == 121984828)
					{
						if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x130FEA25 ^ 0x130FEB5F))
						{
							goto case 21;
						}
						goto case 3;
					}
					num2 = 4;
					break;
				case 47:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-520155535 ^ -520156073)))
					{
						goto case 3;
					}
					num2 = 46;
					break;
				case 13:
					if (num3 == 2658020261u)
					{
						if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x385FFAB ^ 0x385FDBD)))
						{
							num2 = 5;
							break;
						}
						goto case 46;
					}
					num2 = 4;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_caa8a213c8b9430d9f7c3714c3c1b2a3 != 0)
					{
						num2 = 28;
					}
					break;
				case 30:
					if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7F645F3C ^ 0x7F645DA4)))
					{
						goto case 46;
					}
					goto case 3;
				case 22:
					if (num3 != 4122702944u)
					{
						if (num3 == 4147010490u && exchange == (string)MaapxkkHSjMwyEPWbZhu(-490987856 ^ -490987548))
						{
							goto case 21;
						}
						goto case 3;
					}
					goto case 49;
				case 27:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-490987856 ^ -490987620))
					{
						goto case 21;
					}
					goto case 3;
				case 40:
					if (num3 == 1945420267 && exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-490987856 ^ -490988432))
					{
						goto case 46;
					}
					goto case 3;
				case 28:
					if (num3 == 2769128249u)
					{
						if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x86EFEF6 ^ 0x86EFFE2)))
						{
							num2 = 44;
							break;
						}
						goto IL_088d;
					}
					goto case 3;
				case 29:
					if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-377195341 ^ -377195019)))
					{
						goto case 21;
					}
					goto case 3;
				case 21:
					return TimeZoneInfo.ConvertTime(LocalTime, TimeZoneInfo.Local, EasternStandardTime);
				case 46:
				case 50:
					return Jni00gkHkqS5XCHaWTZx();
				case 3:
				case 5:
				case 6:
				case 7:
				case 8:
				case 11:
				case 12:
				case 14:
				case 15:
				case 16:
				case 17:
				case 20:
				case 24:
				case 26:
				case 31:
				case 32:
				case 36:
				case 44:
				case 48:
				case 52:
					return LocalTime;
				case 45:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-710503328 ^ -710502864)))
					{
						num2 = 26;
						break;
					}
					goto case 46;
				case 25:
					if (num3 != 3777067153u)
					{
						if (num3 != 3887724832u)
						{
							num2 = 20;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d9c7ae7fb1634a7eb31f7674bad7490f == 0)
							{
								num2 = 20;
							}
							break;
						}
						goto case 43;
					}
					goto case 10;
				case 38:
					if (num3 <= 1619544453)
					{
						if (num3 != 1339068711)
						{
							if (num3 == 1610380443)
							{
								goto case 27;
							}
							if (num3 != 1619544453)
							{
								goto end_IL_0012;
							}
							if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x706541F3 ^ 0x70654091))
							{
								num2 = 21;
								break;
							}
							goto case 3;
						}
						if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-82860344 ^ -82860194)))
						{
							num2 = 16;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_17f48e9409d64a0386c570d11c68f824 != 0)
							{
								num2 = 8;
							}
							break;
						}
						goto case 21;
					}
					if (num3 <= 1945420267)
					{
						if (num3 != 1903672507)
						{
							num2 = 9;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_775badda1710490c80e5abdbd734ca80 == 0)
							{
								num2 = 40;
							}
							break;
						}
						goto case 35;
					}
					goto case 34;
				case 23:
					if (num3 != 3670628538u)
					{
						num2 = 39;
						break;
					}
					goto case 19;
				case 49:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1461292091 ^ -1461292363)))
					{
						num2 = 7;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_ddd61f309d844557b98cb748068df4e1 != 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 21;
				case 41:
					if (num3 == 2020397624)
					{
						if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1801468030 ^ -1801468256)))
						{
							num2 = 2;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_46c91ca7558c40198f89fff39088a987 == 0)
							{
								num2 = 7;
							}
							break;
						}
						goto case 21;
					}
					num2 = 12;
					break;
				default:
					if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-203064540 ^ -203064940))
					{
						goto case 46;
					}
					goto case 3;
				case 42:
					{
						if (num3 <= 3887724832u)
						{
							num2 = 25;
							break;
						}
						goto case 22;
					}
					IL_088d:
					return TimeZoneInfo.ConvertTime(JaotyrkHBrO1DHVWISjG(), TimeZoneInfo.Local, RussianStandardTime);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 48;
		}
	}

	public static DateTime GetCurrDate(string exchange)
	{
		return GetCurrTime(exchange).Date;
	}

	public static DateTime GetCityTime(string city)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(city == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1841489831 ^ -1841489273)))
				{
					if (!q1Qgl4kHLcuVPZAo4q3e(city, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--737722733 ^ 0x2BF8C387)))
					{
						if (!q1Qgl4kHLcuVPZAo4q3e(city, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x28C965BE ^ 0x28C96744)))
						{
							num2 = 0;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b4f383c2ef60442582501c46cbd6e5c8 == 0)
							{
								num2 = 0;
							}
							break;
						}
						return EasternTime;
					}
					return MoscowTime;
				}
				return KXD9LTkHe9XcQpSLTa4e();
			case 3:
				return UtcTime;
			default:
				if (q1Qgl4kHLcuVPZAo4q3e(city, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-338769610 ^ -338769350)))
				{
					return N0oN9akHscUH3CP2tI6e();
				}
				return LocalTime;
			case 2:
				if (!(city == (string)MaapxkkHSjMwyEPWbZhu(--18459671 ^ 0x119AEC3)))
				{
					num2 = 1;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0797e62afb0c4241b7a0c427b8e94e96 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static double GetSessionOffset(string exchange)
	{
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
		int num2;
		if (num <= 1619544453)
		{
			if (num <= 1339068711)
			{
				num2 = 7;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_775badda1710490c80e5abdbd734ca80 != 0)
				{
					num2 = 4;
				}
			}
			else
			{
				if (num == 1610380443)
				{
					goto IL_03d7;
				}
				if (num != 1619544453 || !(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-225822163 ^ -225821873)))
				{
					goto IL_00ce;
				}
				num2 = 14;
			}
		}
		else
		{
			if (num > 2020397624)
			{
				goto IL_02d1;
			}
			num2 = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_52c6a6e4ab8247c1a9fa3a8313af5589 == 0)
			{
				num2 = 0;
			}
		}
		goto IL_0009;
		IL_02d1:
		if (num != 2769128249u)
		{
			if (num != 4122702944u)
			{
				if (num == 4147010490u)
				{
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-2017337494 ^ -2017337794))
					{
						goto IL_00b0;
					}
					num2 = 2;
				}
				else
				{
					num2 = 10;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_583676900d234e42b13914d805f1fbd3 == 0)
					{
						num2 = 10;
					}
				}
			}
			else
			{
				if (q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-690510723 ^ -690510579)))
				{
					goto IL_00b0;
				}
				num2 = 8;
			}
			goto IL_0009;
		}
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-29702950 ^ -29702706)))
		{
			goto IL_00ce;
		}
		return -0.416666;
		IL_03d7:
		if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-710503328 ^ -710503092))
		{
			goto IL_00b0;
		}
		goto IL_00ce;
		IL_00b0:
		return 0.25;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 12:
			case 14:
				break;
			case 1:
			case 2:
			case 6:
			case 8:
			case 10:
			case 11:
			case 13:
			case 15:
				goto IL_00ce;
			case 4:
				if (num != 1339068711)
				{
					num2 = 3;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_958fb4ed0ac04088853ded3c38efcdda == 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 5;
			case 7:
				goto IL_01c9;
			default:
				if (num != 1903672507)
				{
					if (num == 2020397624 && exchange == (string)MaapxkkHSjMwyEPWbZhu(0x4220DA8 ^ 0x4220C8A))
					{
						break;
					}
					goto IL_00ce;
				}
				goto case 16;
			case 3:
				goto IL_02d1;
			case 5:
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x404ED0BE ^ 0x404ED128))
				{
					return 0.291667;
				}
				goto IL_00ce;
			case 16:
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-1380525184 ^ -1380525384)))
				{
					goto IL_00ce;
				}
				num2 = 6;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_7dd7fb4251aa4aa58edfcf03fb28751b == 0)
				{
					num2 = 12;
				}
				continue;
			case 9:
				goto IL_03d7;
			}
			break;
			IL_01c9:
			if (num != 433752978)
			{
				int num3 = 4;
				num2 = num3;
				continue;
			}
			if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x78D396D8 ^ 0x78D3979E)))
			{
				goto IL_00ce;
			}
			break;
		}
		goto IL_00b0;
		IL_00ce:
		return 0.0;
	}

	public static TimeSpan GetSessionOffsetTs(string exchange)
	{
		int num = 15;
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num3 != 4147010490u)
					{
						num2 = 8;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d9c7ae7fb1634a7eb31f7674bad7490f != 0)
						{
							num2 = 5;
						}
						continue;
					}
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1999650146 ^ -1999649846)))
					{
						goto case 2;
					}
					goto case 1;
				case 15:
					num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
					num = 14;
					break;
				case 1:
				case 12:
					return ToCl1UkHXUm86cNVxOw1(6.0);
				case 2:
				case 5:
				case 7:
				case 8:
				case 10:
				case 13:
					return TimeSpan.Zero;
				case 14:
					if (num3 > 1619544453)
					{
						goto case 9;
					}
					if (num3 <= 1339068711)
					{
						if (num3 == 433752978)
						{
							if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(0x130FEA25 ^ 0x130FEB63)))
							{
								num2 = 2;
								continue;
							}
							goto case 1;
						}
						if (num3 != 1339068711)
						{
							goto case 2;
						}
						goto case 16;
					}
					goto case 6;
				case 3:
					if (num3 != 2769128249u)
					{
						if (num3 != 4122702944u)
						{
							num2 = 0;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3003f96c370e481ba4f92d4c1a0a7ae5 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-165474503 ^ -165474743)))
						{
							num2 = 12;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_c15ee73cea4e4b56b74a2d79b4e4679c != 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 2;
					}
					goto case 4;
				case 4:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-671204305 ^ -671204037))
					{
						return ToCl1UkHXUm86cNVxOw1(-10.0);
					}
					goto case 2;
				case 17:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x24085900 ^ 0x24085862))
					{
						goto case 1;
					}
					goto case 2;
				case 9:
					if (num3 > 2020397624)
					{
						goto case 3;
					}
					if (num3 != 1903672507)
					{
						if (num3 == 2020397624)
						{
							if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-1325234765 ^ -1325235055))
							{
								goto case 1;
							}
							goto case 2;
						}
						num = 7;
						break;
					}
					goto case 11;
				case 16:
					if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-624753169 ^ -624753543))
					{
						return TimeSpan.FromHours(7.0);
					}
					num2 = 5;
					continue;
				case 11:
					if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(--500511424 ^ 0x1DD533F8)))
					{
						num2 = 10;
						continue;
					}
					goto case 1;
				case 6:
					if (num3 != 1610380443)
					{
						if (num3 == 1619544453)
						{
							goto case 17;
						}
					}
					else if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x28B345BB ^ 0x28B34497))
					{
						num2 = 0;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_8f6422f449ee4ba8b3826a215baa7eba == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	public static DateTime GetSessionDate(string exchange)
	{
		int num = 8;
		uint num3 = default(uint);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x50C1C840 ^ 0x50C1C9D6))
					{
						goto case 6;
					}
					goto default;
				case 4:
					if (num3 == 1903672507)
					{
						goto case 1;
					}
					goto default;
				case 1:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0xC1DDB3B ^ 0xC1DDA03))
					{
						goto case 2;
					}
					goto default;
				case 6:
					if (dateTime.Hour >= 17)
					{
						dateTime = dateTime.AddDays(1.0);
						num2 = 11;
						break;
					}
					goto default;
				case 2:
					if (dateTime.Hour >= 18)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 14:
					if (num3 == 1619544453)
					{
						if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x2BD86B18 ^ 0x2BD86A7A))
						{
							goto case 2;
						}
						goto default;
					}
					num2 = 4;
					break;
				case 7:
					num3 = WCUTKXkHxHu9Jmc5NFH4(exchange);
					num2 = 15;
					break;
				case 9:
					if (num3 != 433752978)
					{
						if (num3 == 1339068711)
						{
							goto case 13;
						}
						if (num3 != 1610380443)
						{
							goto default;
						}
						if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x24085900 ^ 0x2408582C)))
						{
							num2 = 0;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_fde1e2b988414f6aa0c032a729a39c63 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
					else if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-225822163 ^ -225821845)))
					{
						num2 = 0;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_6646d59cf92743dc861b4d59be507f19 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 2;
				default:
					return dateTime.Date;
				case 5:
					dateTime = dateTime.AddDays(1.0);
					num2 = 12;
					break;
				case 15:
					if (num3 <= 1610380443)
					{
						goto end_IL_0012;
					}
					if (num3 <= 1903672507)
					{
						num2 = 14;
						break;
					}
					if (num3 != 2020397624)
					{
						if (num3 == 4122702944u && exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x6AB40973 ^ 0x6AB40803))
						{
							goto case 2;
						}
					}
					else if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1087080834 ^ -1087080612))
					{
						goto case 2;
					}
					goto default;
				case 8:
					dateTime = zRMK9pkHc8706wRSwevb(exchange);
					num2 = 7;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_cd71425f651a4405a1288e9be5595ce4 != 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public static DateTime GetSessionDate(DateTime dt, string exchange)
	{
		int num = 4;
		uint num3 = default(uint);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3 = WCUTKXkHxHu9Jmc5NFH4(exchange);
					if (num3 > 1610380443)
					{
						goto case 15;
					}
					if (num3 != 433752978)
					{
						goto end_IL_0012;
					}
					if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-527080372 ^ -527080182))
					{
						goto case 10;
					}
					goto default;
				case 11:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1962651919 ^ -1962651683)))
					{
						num2 = 14;
						break;
					}
					goto case 10;
				case 13:
					if (num3 != 1339068711)
					{
						if (num3 != 1610380443)
						{
							num2 = 6;
							break;
						}
						goto case 11;
					}
					goto case 2;
				case 10:
					if (dateTime.Hour >= 18)
					{
						dateTime = dateTime.AddDays(1.0);
					}
					goto default;
				case 1:
					if (num3 == 1903672507)
					{
						if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x22BF43FC ^ 0x22BF42C4))
						{
							goto case 10;
						}
						goto default;
					}
					num2 = 8;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_39472ed9ae09430d94d3d242e0aa54a8 == 0)
					{
						num2 = 9;
					}
					break;
				case 4:
					dateTime = dt;
					num2 = 3;
					break;
				case 15:
					if (num3 > 1903672507)
					{
						goto case 7;
					}
					if (num3 != 1619544453)
					{
						num2 = 1;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_8781d71bab134ab5919bea2cb3172d07 == 0)
						{
							num2 = 1;
						}
						break;
					}
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x130FEA25 ^ 0x130FEB47))
					{
						goto case 10;
					}
					goto default;
				case 7:
					if (num3 != 2020397624)
					{
						if (num3 == 4122702944u)
						{
							if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-5977659 ^ -5977931)))
							{
								num2 = 0;
								if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b6fceb011d92466ca7b14ec23ec9eb29 != 0)
								{
									num2 = 0;
								}
								break;
							}
							goto case 10;
						}
					}
					else if (exchange == (string)MaapxkkHSjMwyEPWbZhu(0x28C965BE ^ 0x28C9649C))
					{
						goto case 10;
					}
					goto default;
				default:
					return dateTime.Date;
				case 2:
					if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-671204305 ^ -671203911))
					{
						if (dateTime.Hour >= 17)
						{
							dateTime = dateTime.AddDays(1.0);
							num2 = 5;
							break;
						}
						goto default;
					}
					num2 = 12;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0ef8be99fae94c90b579a4d7752c6260 != 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public static bool IsInvalidTime(DateTime dt, string exchange)
	{
		uint num = WCUTKXkHxHu9Jmc5NFH4(exchange);
		int num2;
		if (num > 1903672507)
		{
			if (num <= 2770757464u)
			{
				num2 = 29;
				goto IL_0009;
			}
			goto IL_029d;
		}
		if (num > 665101479)
		{
			goto IL_039c;
		}
		if (num > 121984828)
		{
			if (num != 207070566)
			{
				if (num == 433752978)
				{
					goto IL_08b1;
				}
				if (num == 665101479 && exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x1EFE0A28 ^ 0x1EFE0BCA))
				{
					goto IL_04ae;
				}
			}
			else if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1087080834 ^ -1087081384))
			{
				goto IL_04ae;
			}
		}
		else
		{
			if (num == 62387165)
			{
				goto IL_066d;
			}
			if (num == 121984828)
			{
				goto IL_0445;
			}
		}
		goto IL_04ba;
		IL_04ba:
		return false;
		IL_039c:
		if (num > 1339068711)
		{
			goto IL_03ad;
		}
		if (num != 702486649)
		{
			if (num == 1041130325)
			{
				goto IL_069d;
			}
			if (num != 1339068711 || !q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-1192989954 ^ -1192989848)))
			{
				goto IL_04ba;
			}
		}
		else if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-2063361985 ^ -2063361607)))
		{
			num2 = 10;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_43e084292d09448095ccf30726039725 == 0)
			{
				num2 = 1;
			}
			goto IL_0009;
		}
		goto IL_04a2;
		IL_029d:
		if (num > 3777067153u)
		{
			if (num == 3887724832u)
			{
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-342738082 ^ -342738180)))
				{
					goto IL_04ba;
				}
				goto IL_04ae;
			}
			num2 = 17;
		}
		else
		{
			num2 = 9;
		}
		goto IL_0009;
		IL_04a2:
		return ILWvVikHjUlGaWnHiZ59(EasternStandardTime, dt);
		IL_0249:
		int num3 = 37;
		goto IL_0005;
		IL_0005:
		num2 = num3;
		goto IL_0009;
		IL_08b1:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-838841832 ^ -838841506)))
		{
			num3 = 22;
			goto IL_0005;
		}
		goto IL_04a2;
		IL_05a2:
		if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-2056710528 ^ -2056711018)))
		{
			num3 = 13;
			goto IL_0005;
		}
		goto IL_04ae;
		IL_03ad:
		if (num != 1610380443)
		{
			num2 = 6;
		}
		else
		{
			if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-45476899 ^ -45477135)))
			{
				goto IL_04ba;
			}
			num2 = 14;
		}
		goto IL_0009;
		IL_047b:
		if (num != 3677625335u)
		{
			if (num != 3777067153u || !q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1461292091 ^ -1461292429)))
			{
				goto IL_04ba;
			}
		}
		else if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-377195341 ^ -377195141)))
		{
			num3 = 18;
			goto IL_0005;
		}
		goto IL_04ae;
		IL_066d:
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-82860344 ^ -82860914)))
		{
			goto IL_04ba;
		}
		num2 = 33;
		goto IL_0009;
		IL_0445:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x16AD7E76 ^ 0x16AD7F0C)))
		{
			num2 = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_bf3674a0d58447d8b41fa5fbff1483ca == 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		goto IL_04a2;
		IL_069d:
		if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-377195341 ^ -377194781)))
		{
			goto IL_04ae;
		}
		goto IL_04ba;
		IL_04ae:
		return TimeZoneInfo.Utc.IsInvalidTime(dt);
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 26:
				if (num != 4147010490u)
				{
					num2 = 3;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_69c5a0be35f641e2a0aee7e7539714fa == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 31:
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-60853733 ^ -60854243))
				{
					goto IL_04ae;
				}
				goto IL_04ba;
			case 6:
				break;
			case 4:
				goto end_IL_0009;
			case 36:
				if (num != 2204885439u)
				{
					goto IL_04ba;
				}
				if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-1251569705 ^ -1251570193)))
				{
					num2 = 21;
					continue;
				}
				goto IL_04ae;
			case 35:
				goto IL_0349;
			case 37:
				if (num != 1903672507)
				{
					goto IL_04ba;
				}
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-530053095 ^ -530052831)))
				{
					num2 = 17;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_886e202b3f2f4f6dbb66ec0188f50627 == 0)
					{
						num2 = 32;
					}
					continue;
				}
				goto IL_04a2;
			case 27:
				goto IL_039c;
			case 12:
				goto IL_03ad;
			case 28:
				goto IL_0445;
			case 14:
				goto IL_04a2;
			case 33:
				goto IL_04ae;
			default:
				goto IL_04ba;
			case 2:
				goto IL_05a2;
			case 15:
				if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x7D553BE0 ^ 0x7D553AC2)))
				{
					num2 = 16;
					continue;
				}
				goto IL_04a2;
			case 5:
				goto IL_066d;
			case 30:
				goto IL_069d;
			case 7:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x446AB724 ^ 0x446AB670)))
				{
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b6fceb011d92466ca7b14ec23ec9eb29 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_04a2;
			case 29:
				if (num <= 2204885439u)
				{
					num2 = 23;
					continue;
				}
				goto IL_0349;
			case 23:
				if (num != 2020397624)
				{
					num2 = 1;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_c15ee73cea4e4b56b74a2d79b4e4679c == 0)
					{
						num2 = 36;
					}
					continue;
				}
				goto case 15;
			case 9:
				if (num == 3670628538u)
				{
					goto case 31;
				}
				goto IL_047b;
			case 17:
				goto IL_0866;
			case 19:
				goto IL_08b1;
			}
			if (num != 1619544453)
			{
				goto IL_0249;
			}
			if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-838841832 ^ -838841478)))
			{
				num2 = 5;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_636117356299466fb3f39a58fe56c3a7 == 0)
				{
					num2 = 20;
				}
				continue;
			}
			goto IL_04a2;
			IL_0866:
			if (num == 4122702944u)
			{
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-842040449 ^ -842040817))
				{
					goto IL_04a2;
				}
				goto IL_04ba;
			}
			num2 = 26;
			continue;
			IL_0349:
			if (num != 2658020261u)
			{
				if (num == 2769128249u)
				{
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0xECA3F28 ^ 0xECA3E3C)))
					{
						goto IL_04ba;
					}
				}
				else
				{
					if (num != 2770757464u)
					{
						num2 = 24;
						continue;
					}
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x68C7EAE6 ^ 0x68C7EBEE)))
					{
						num2 = 8;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d4dd2f37e24a48e994de10296154703f != 0)
						{
							num2 = 1;
						}
						continue;
					}
				}
				return ILWvVikHjUlGaWnHiZ59(RussianStandardTime, dt);
			}
			goto IL_05a2;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_029d;
	}

	public static string FormatTime(DateTime dt, string format, string exchange)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dateTime = ConvertTimeToLocal(dt, exchange);
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_fde1e2b988414f6aa0c032a729a39c63 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (format == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7DB10E6E ^ 0x7DB10D70))
				{
					return dateTime.ToLongTimeString();
				}
				return dateTime.ToString((!string.IsNullOrEmpty(format)) ? format : RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x315AB1E3 ^ 0x315AB2C7));
			}
		}
	}

	public static DateTime ConvertFromExchangeTimeToUtc(DateTime dt, string exchange)
	{
		int num = 2;
		DateTime result = default(DateTime);
		DateTime dateTime = default(DateTime);
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					result = E8oxsEkHld14I3pEySM3(dateTime, fhsKoYkHNelNZhKW9UBi(), TimeZoneInfo.Utc);
					goto default;
				case 5:
					if (num3 != 2770757464u)
					{
						num2 = 13;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b4f383c2ef60442582501c46cbd6e5c8 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 6:
					if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-2123795572 ^ -2123795766))
					{
						goto IL_0392;
					}
					goto default;
				case 1:
					dateTime = new DateTime(dt.Ticks, DateTimeKind.Unspecified);
					num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
					num2 = 19;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_73bed1502c3543549d390ad7000cdc04 != 0)
					{
						num2 = 12;
					}
					continue;
				case 10:
					if (num3 == 702486649 && q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-490987856 ^ -490987722)))
					{
						goto IL_0392;
					}
					goto default;
				case 20:
					if (q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(0x3544E813 ^ 0x3544E92B)))
					{
						goto IL_0392;
					}
					goto default;
				case 15:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-82860344 ^ -82860110))
					{
						goto IL_0392;
					}
					goto default;
				case 11:
					if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-60853733 ^ -60853485)))
					{
						num2 = 0;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_583676900d234e42b13914d805f1fbd3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 23:
					if (num3 != 433752978)
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 18:
					if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x2D313048 ^ 0x2D31311C)))
					{
						num2 = 3;
						continue;
					}
					goto IL_0392;
				case 13:
					if (num3 == 4122702944u)
					{
						goto case 14;
					}
					if (num3 == 4147010490u)
					{
						goto case 18;
					}
					goto default;
				case 22:
					if (num3 != 2769128249u || !(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1309555870 ^ -1309556106)))
					{
						goto default;
					}
					num2 = 8;
					continue;
				case 21:
					if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1380525184 ^ -1380525396)))
					{
						goto IL_0392;
					}
					goto default;
				case 14:
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x741B85CB ^ 0x741B84BB))
					{
						goto IL_0392;
					}
					goto default;
				case 17:
					if (num3 <= 2769128249u)
					{
						if (num3 == 1903672507)
						{
							goto case 20;
						}
						if (num3 != 2020397624)
						{
							num2 = 22;
							continue;
						}
						goto case 16;
					}
					goto case 5;
				case 19:
					if (num3 <= 1619544453)
					{
						if (num3 <= 702486649)
						{
							if (num3 != 121984828)
							{
								num2 = 23;
								if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_45605a9ff99f452c8f46c5b8b2f292ad != 0)
								{
									num2 = 13;
								}
								continue;
							}
							goto case 15;
						}
						num2 = 9;
						continue;
					}
					goto case 17;
				default:
					return result;
				case 2:
					result = dt;
					num2 = 1;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_8b1c6f1e798e49d9afbdae3a0f6bb856 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					if (num3 == 1339068711)
					{
						if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1047165041 ^ -1047165415)))
						{
							goto IL_0392;
						}
					}
					else
					{
						if (num3 == 1610380443)
						{
							goto case 21;
						}
						if (num3 == 1619544453)
						{
							if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1309555870 ^ -1309556224)))
							{
								break;
							}
							goto IL_0392;
						}
					}
					goto default;
				case 16:
					{
						if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--871424829 ^ 0x33F0E21F)))
						{
							goto IL_0392;
						}
						goto default;
					}
					IL_0392:
					result = TimeZoneInfo.ConvertTime(dateTime, EasternStandardTime, (TimeZoneInfo)UXXnGRkHE7vuLy5OBeGy());
					num2 = 4;
					continue;
				}
				break;
			}
			num = 12;
		}
	}

	public static DateTime ConvertTimeToLocal(DateTime dt, string exchange, bool ignoreGlobalOption = false)
	{
		if (!AppLocalTime && !ignoreGlobalOption)
		{
			goto IL_067b;
		}
		DateTime result = dt;
		DateTime dateTime = new DateTime(dt.Ticks, DateTimeKind.Unspecified);
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
		int num2;
		if (num <= 2020397624)
		{
			if (num <= 1041130325)
			{
				num2 = 5;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_9bafeb14789d451da1f4b7c9a1bf736e != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				if (num > 1619544453)
				{
					goto IL_0651;
				}
				num2 = 52;
			}
			goto IL_0009;
		}
		goto IL_0aa0;
		IL_014c:
		if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1763895751 ^ -1763895503)))
		{
			num2 = 55;
			goto IL_0009;
		}
		goto IL_0172;
		IL_0bfa:
		if (num <= 3677625335u)
		{
			num2 = 22;
			goto IL_0009;
		}
		goto IL_05e2;
		IL_020c:
		if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-1416986301 ^ -1416986379)))
		{
			goto IL_0172;
		}
		goto IL_0a3e;
		IL_0578:
		result = TimeZoneInfo.ConvertTime(dateTime, EasternStandardTime, TimeZoneInfo.Local);
		num2 = 1;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_2e8f9d59c4ed4588bb0181fd18668558 != 0)
		{
			num2 = 23;
		}
		goto IL_0009;
		IL_0a3e:
		result = E8oxsEkHld14I3pEySM3(dateTime, TimeZoneInfo.Utc, TimeZoneInfo.Local);
		num2 = 6;
		goto IL_0009;
		IL_0172:
		return result;
		IL_0685:
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-2108526692 ^ -2108527132)))
		{
			goto IL_0172;
		}
		goto IL_0a3e;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 45:
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x404ED0BE ^ 0x404ED1F8))
				{
					num2 = 17;
					continue;
				}
				goto IL_0172;
			case 43:
				break;
			case 2:
			case 6:
			case 9:
			case 10:
			case 12:
			case 13:
			case 18:
			case 21:
			case 23:
			case 24:
			case 25:
			case 26:
			case 28:
			case 31:
			case 34:
			case 38:
			case 47:
			case 48:
			case 50:
			case 54:
			case 56:
				goto IL_0172;
			case 49:
				if (num != 2020397624)
				{
					goto IL_0172;
				}
				goto case 42;
			case 5:
				if (num <= 207070566)
				{
					goto IL_01ea;
				}
				goto case 4;
			case 35:
				goto IL_020c;
			case 22:
				goto IL_022c;
			case 7:
				goto IL_023d;
			case 19:
				goto IL_025d;
			case 30:
				if (num != 2132487982)
				{
					num2 = 7;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_43e084292d09448095ccf30726039725 != 0)
					{
						num2 = 51;
					}
					continue;
				}
				goto case 27;
			case 41:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1841489831 ^ -1841489651)))
				{
					goto IL_0172;
				}
				goto IL_0578;
			case 14:
				if (num != 433752978)
				{
					num2 = 44;
					continue;
				}
				goto case 45;
			case 55:
				goto IL_0331;
			default:
				goto IL_03de;
			case 15:
				goto IL_042a;
			case 44:
				if (num != 665101479 || !(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-710503328 ^ -710503038)))
				{
					goto IL_0172;
				}
				goto IL_0a3e;
			case 42:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-839659358 ^ -839659136)))
				{
					num2 = 25;
					continue;
				}
				goto IL_0578;
			case 29:
				goto IL_0505;
			case 40:
				goto IL_0558;
			case 17:
				goto IL_0578;
			case 39:
				goto IL_05e2;
			case 36:
				goto IL_0651;
			case 11:
				goto IL_067b;
			case 16:
				goto IL_0685;
			case 33:
				if (num != 4147010490u)
				{
					num2 = 47;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_7853a959e5234bcd81440f35d26d5f10 != 0)
					{
						num2 = 15;
					}
					continue;
				}
				goto case 41;
			case 52:
				goto IL_0779;
			case 20:
				goto IL_087d;
			case 37:
				goto IL_0960;
			case 51:
				goto IL_09ab;
			case 4:
				if (num <= 665101479)
				{
					num2 = 14;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d3878af610b846108a5237604e24fce3 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto IL_087d;
			case 3:
			case 32:
			case 46:
			case 53:
				goto IL_0a3e;
			case 1:
				goto IL_0aa0;
			case 27:
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-371631841 ^ -371631225))
				{
					int num3 = 32;
					num2 = num3;
					continue;
				}
				goto IL_0172;
			case 8:
				goto IL_0bfa;
			}
			break;
			IL_09ab:
			if (num == 2204885439u)
			{
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7394D272 ^ 0x7394D04A)))
				{
					num2 = 31;
					continue;
				}
				goto IL_0a3e;
			}
			if (num != 2618539384u)
			{
				num2 = 26;
				continue;
			}
			goto IL_023d;
			IL_0558:
			if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(0x1A5F1B9E ^ 0x1A5F1998)))
			{
				goto IL_0172;
			}
			goto IL_0a3e;
			IL_025d:
			if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7D553BE0 ^ 0x7D553A28))
			{
				num2 = 53;
				continue;
			}
			goto IL_0172;
			IL_01ea:
			if (num != 62387165)
			{
				if (num == 121984828)
				{
					if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x6E2DFBED ^ 0x6E2DFA97)))
					{
						num2 = 48;
						continue;
					}
					goto IL_0578;
				}
				if (num != 207070566)
				{
					goto IL_0172;
				}
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x741B85CB ^ 0x741B87ED)))
				{
					num2 = 34;
					continue;
				}
			}
			else if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x1A5F1B9E ^ 0x1A5F19D8)))
			{
				goto IL_0172;
			}
			goto IL_0a3e;
			IL_042a:
			if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1878953018 ^ -1878953238)))
			{
				goto IL_0578;
			}
			goto IL_0172;
			IL_0779:
			if (num != 1339068711)
			{
				if (num == 1610380443)
				{
					goto IL_042a;
				}
				if (num != 1619544453)
				{
					goto IL_0172;
				}
				if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x68C7EAE6 ^ 0x68C7EB84)))
				{
					num2 = 2;
					continue;
				}
			}
			else if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-45476899 ^ -45477301)))
			{
				goto IL_0172;
			}
			goto IL_0578;
			IL_023d:
			if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-520155535 ^ -520156137)))
			{
				goto IL_0172;
			}
			goto IL_0a3e;
			IL_022c:
			if (num != 3573002156u)
			{
				if (num != 3670628538u)
				{
					if (num != 3677625335u)
					{
						num2 = 9;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b66f5b1bd8a5426795439c024370427a == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto IL_025d;
				}
				goto IL_0558;
			}
			if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x78D396D8 ^ 0x78D39468)))
			{
				num2 = 10;
				continue;
			}
			goto IL_0a3e;
			IL_087d:
			if (num != 702486649)
			{
				if (num != 1041130325)
				{
					num2 = 38;
					continue;
				}
				if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1346994499 ^ -1346994963)))
				{
					goto IL_0a3e;
				}
			}
			else if (exchange == (string)MaapxkkHSjMwyEPWbZhu(-1848952786 ^ -1848952408))
			{
				goto IL_0578;
			}
			goto IL_0172;
		}
		goto IL_014c;
		IL_0aa0:
		if (num > 3516542306u)
		{
			goto IL_0bfa;
		}
		if (num > 2618539384u)
		{
			if (num <= 2769128249u)
			{
				if (num == 2658020261u)
				{
					if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x404ED0BE ^ 0x404ED2A8)))
					{
						num2 = 2;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0942fa5f1f5b4611b19614be5d79cd10 == 0)
						{
							num2 = 46;
						}
						goto IL_0009;
					}
				}
				else
				{
					if (num != 2769128249u)
					{
						num2 = 12;
						goto IL_0009;
					}
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-962524685 ^ -962524953))
					{
						goto IL_0331;
					}
				}
			}
			else
			{
				if (num == 2770757464u)
				{
					goto IL_014c;
				}
				if (num == 3516542306u)
				{
					goto IL_0685;
				}
			}
			goto IL_0172;
		}
		num2 = 30;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d4dd2f37e24a48e994de10296154703f != 0)
		{
			num2 = 8;
		}
		goto IL_0009;
		IL_03de:
		if (num != 4122702944u)
		{
			num2 = 14;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_6646d59cf92743dc861b4d59be507f19 != 0)
			{
				num2 = 33;
			}
			goto IL_0009;
		}
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-5977659 ^ -5977931)))
		{
			goto IL_0172;
		}
		goto IL_0578;
		IL_067b:
		return dt;
		IL_0651:
		if (num > 1945420267)
		{
			if (num != 1976993578)
			{
				num2 = 49;
				goto IL_0009;
			}
			if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x735715F1 ^ 0x735717AB)))
			{
				goto IL_0172;
			}
		}
		else
		{
			if (num == 1903672507)
			{
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(0x6F7F734B ^ 0x6F7F7273)))
				{
					num2 = 24;
					goto IL_0009;
				}
				goto IL_0578;
			}
			if (num != 1945420267 || !q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-371631841 ^ -371631137)))
			{
				goto IL_0172;
			}
		}
		goto IL_0a3e;
		IL_0960:
		if (num == 3777067153u)
		{
			goto IL_020c;
		}
		if (num != 3887724832u)
		{
			goto IL_0172;
		}
		goto IL_0505;
		IL_0505:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-44540535 ^ -44540885)))
		{
			goto IL_0172;
		}
		goto IL_0a3e;
		IL_0331:
		result = TimeZoneInfo.ConvertTime(dateTime, (TimeZoneInfo)fhsKoYkHNelNZhKW9UBi(), TimeZoneInfo.Local);
		num2 = 18;
		goto IL_0009;
		IL_05e2:
		if (num > 3887724832u)
		{
			goto IL_03de;
		}
		goto IL_0960;
	}

	public static DateTime ConvertTimeFromLocal(DateTime dt, string exchange, bool ignoreGlobalOption = false)
	{
		int num;
		if (!AppLocalTime)
		{
			if (ignoreGlobalOption)
			{
				num = 28;
				goto IL_0009;
			}
			return dt;
		}
		goto IL_04b8;
		IL_0c6d:
		uint num2 = default(uint);
		if (num2 <= 3677625335u)
		{
			if (num2 != 3573002156u)
			{
				num = 11;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3a80f21f876f4cfd845b5629c73a033f == 0)
				{
					num = 31;
				}
			}
			else
			{
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x6D18F862 ^ 0x6D18FAD2))
				{
					goto IL_02b0;
				}
				num = 9;
			}
		}
		else
		{
			if (num2 > 3887724832u)
			{
				goto IL_07c9;
			}
			if (num2 == 3777067153u)
			{
				goto IL_0c2c;
			}
			if (num2 == 3887724832u)
			{
				goto IL_0a37;
			}
			num = 4;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_a50ff9449a714e8bbe53d133cc817d7d == 0)
			{
				num = 3;
			}
		}
		goto IL_0009;
		IL_04b8:
		DateTime result = dt;
		DateTime dateTime = new DateTime(dt.Ticks, DateTimeKind.Unspecified);
		num2 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
		int num3;
		if (num2 <= 2020397624)
		{
			if (num2 <= 1041130325)
			{
				if (num2 > 207070566)
				{
					goto IL_0212;
				}
				if (num2 != 62387165)
				{
					num = 33;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_cffb9074f7244a46a7e8c2f280b0a849 != 0)
					{
						num = 15;
					}
					goto IL_0009;
				}
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x769C7931 ^ 0x769C7B77)))
				{
					num3 = 29;
					goto IL_0005;
				}
				goto IL_02b0;
			}
			goto IL_06c9;
		}
		goto IL_0aca;
		IL_0a37:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(0x6E2DFBED ^ 0x6E2DFA4F)))
		{
			num = 47;
			goto IL_0009;
		}
		goto IL_02b0;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 13:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x735715F1 ^ 0x7357148B)))
				{
					goto IL_0168;
				}
				goto IL_0555;
			case 12:
				break;
			default:
				goto IL_0168;
			case 49:
				goto IL_01f2;
			case 42:
				goto IL_0212;
			case 46:
				if (num2 != 1041130325)
				{
					goto IL_0168;
				}
				goto case 43;
			case 44:
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1799510641 ^ -1799510039)))
				{
					num = 14;
					continue;
				}
				goto IL_02b0;
			case 1:
				goto IL_036d;
			case 11:
				if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x684F243E ^ 0x684F2646)))
				{
					num = 26;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_14e5fa8e2dd14879a83c11f539dbf47a == 0)
					{
						num = 11;
					}
					continue;
				}
				goto IL_02b0;
			case 50:
				if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-5977659 ^ -5977945)))
				{
					goto IL_0168;
				}
				goto IL_0555;
			case 28:
				goto IL_04b8;
			case 37:
				goto IL_0520;
			case 41:
			case 52:
				goto IL_0555;
			case 35:
				if (num2 == 1610380443)
				{
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7D553BE0 ^ 0x7D553ACC))
					{
						num = 52;
						continue;
					}
				}
				else if (num2 == 1619544453)
				{
					goto case 50;
				}
				goto IL_0168;
			case 8:
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1606927328 ^ -1606926910)))
				{
					goto IL_0168;
				}
				goto IL_02b0;
			case 3:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x2D3134C9 ^ 0x2D313609)))
				{
					goto IL_0168;
				}
				goto IL_02b0;
			case 19:
				goto IL_06a3;
			case 25:
				goto IL_06c9;
			case 6:
			case 27:
				if (num2 > 2769128249u)
				{
					goto case 15;
				}
				goto IL_0a01;
			case 54:
				goto IL_07c9;
			case 33:
				if (num2 == 121984828)
				{
					goto case 13;
				}
				if (num2 != 207070566)
				{
					num = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_ab31c8f21877491e810e3daff7636f6b == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 7;
			case 15:
				if (num2 == 2770757464u)
				{
					goto IL_0520;
				}
				if (num2 == 3516542306u)
				{
					goto case 11;
				}
				goto IL_0a9d;
			case 36:
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x24085900 ^ 0x24085B38)))
				{
					num = 2;
					continue;
				}
				goto IL_02b0;
			case 43:
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-57768881 ^ -57768417)))
				{
					goto IL_0168;
				}
				goto IL_02b0;
			case 24:
				goto IL_08bd;
			case 32:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x446AB724 ^ 0x446AB670)))
				{
					goto IL_0168;
				}
				goto IL_0555;
			case 21:
				if (num2 != 2204885439u)
				{
					num = 53;
					continue;
				}
				goto case 36;
			case 31:
				goto IL_0947;
			case 53:
				if (num2 != 2618539384u)
				{
					goto IL_0168;
				}
				goto case 44;
			case 7:
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-2017337494 ^ -2017338036)))
				{
					goto IL_0168;
				}
				goto IL_02b0;
			case 30:
				goto IL_0a37;
			case 17:
				if (num2 != 1945420267)
				{
					num = 20;
					continue;
				}
				goto case 3;
			case 5:
				goto IL_0aca;
			case 10:
				goto IL_0adb;
			case 18:
				goto IL_0af1;
			case 40:
				if (num2 == 433752978)
				{
					if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--927068468 ^ 0x3741F072))
					{
						goto IL_0555;
					}
				}
				else if (num2 == 665101479)
				{
					goto case 8;
				}
				goto IL_0168;
			case 55:
				goto IL_0bcd;
			case 38:
				goto IL_0c2c;
			case 48:
				if (num2 != 4147010490u)
				{
					goto IL_0168;
				}
				goto case 32;
			case 45:
				goto IL_0c6d;
			}
			break;
			IL_0947:
			if (num2 == 3670628538u)
			{
				if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-2017337494 ^ -2017338004)))
				{
					goto IL_0168;
				}
				goto IL_02b0;
			}
			num = 19;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_43e084292d09448095ccf30726039725 != 0)
			{
				num = 24;
			}
			continue;
			IL_0520:
			if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-962524685 ^ -962524933)))
			{
				num = 9;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_52c6a6e4ab8247c1a9fa3a8313af5589 == 0)
				{
					num = 23;
				}
				continue;
			}
			goto IL_0919;
			IL_0919:
			result = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Local, (TimeZoneInfo)fhsKoYkHNelNZhKW9UBi());
			goto IL_0168;
			IL_0a01:
			if (num2 != 2658020261u)
			{
				if (num2 == 2769128249u && exchange == (string)MaapxkkHSjMwyEPWbZhu(0x684F243E ^ 0x684F252A))
				{
					goto IL_0919;
				}
			}
			else if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1325234765 ^ -1325234267)))
			{
				goto IL_02b0;
			}
			goto IL_0168;
			IL_08bd:
			if (num2 == 3677625335u)
			{
				if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--871424829 ^ 0x33F0E2F5)))
				{
					goto IL_0168;
				}
				goto IL_02b0;
			}
			num = 34;
		}
		goto IL_012e;
		IL_01f2:
		if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x6F7F734B ^ 0x6F7F7273))
		{
			goto IL_0555;
		}
		goto IL_0168;
		IL_0aca:
		if (num2 <= 3516542306u)
		{
			if (num2 > 2618539384u)
			{
				num = 5;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0820a5f28ecf4cc78ceb810611003aee == 0)
				{
					num = 6;
				}
				goto IL_0009;
			}
			goto IL_0adb;
		}
		goto IL_0c6d;
		IL_07c9:
		if (num2 != 4122702944u)
		{
			num = 48;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_8781d71bab134ab5919bea2cb3172d07 == 0)
			{
				num = 44;
			}
			goto IL_0009;
		}
		goto IL_0bcd;
		IL_0005:
		num = num3;
		goto IL_0009;
		IL_02b0:
		result = E8oxsEkHld14I3pEySM3(dateTime, nN0V3mkHabPwUgdJdTSL(), TimeZoneInfo.Utc);
		num = 39;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_a50ff9449a714e8bbe53d133cc817d7d == 0)
		{
			num = 13;
		}
		goto IL_0009;
		IL_0bcd:
		if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(0x684F243E ^ 0x684F254E)))
		{
			goto IL_0168;
		}
		goto IL_0555;
		IL_0555:
		result = E8oxsEkHld14I3pEySM3(dateTime, TimeZoneInfo.Local, bJIHGhkH1tV7V6MiOY4n());
		goto IL_0168;
		IL_0af1:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(0x1A5F1B9E ^ 0x1A5F1A08)))
		{
			goto IL_0168;
		}
		num = 13;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d3878af610b846108a5237604e24fce3 != 0)
		{
			num = 41;
		}
		goto IL_0009;
		IL_06c9:
		if (num2 > 1619544453)
		{
			if (num2 > 1945420267)
			{
				if (num2 != 1976993578)
				{
					if (num2 == 2020397624)
					{
						goto IL_012e;
					}
					goto IL_0168;
				}
				goto IL_036d;
			}
			if (num2 != 1903672507)
			{
				num3 = 17;
				goto IL_0005;
			}
			goto IL_01f2;
		}
		if (num2 != 1339068711)
		{
			num = 35;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_5e0f883d27674d988f2b989cfc21c9dc == 0)
			{
				num = 13;
			}
			goto IL_0009;
		}
		goto IL_0af1;
		IL_06a3:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-530053095 ^ -530052479)))
		{
			goto IL_0168;
		}
		goto IL_02b0;
		IL_012e:
		if (!(exchange == (string)MaapxkkHSjMwyEPWbZhu(-176525661 ^ -176525439)))
		{
			goto IL_0168;
		}
		goto IL_0555;
		IL_0c2c:
		if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x1487846E ^ 0x148785D8)))
		{
			goto IL_0168;
		}
		goto IL_02b0;
		IL_0168:
		return result;
		IL_0adb:
		if (num2 != 2132487982)
		{
			num = 21;
			goto IL_0009;
		}
		goto IL_06a3;
		IL_0a9d:
		num3 = 16;
		goto IL_0005;
		IL_0212:
		if (num2 <= 665101479)
		{
			num = 40;
		}
		else if (num2 == 702486649)
		{
			if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x5EA8FF2A ^ 0x5EA8FEAC)))
			{
				goto IL_0555;
			}
			num = 22;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_6646d59cf92743dc861b4d59be507f19 == 0)
			{
				num = 18;
			}
		}
		else
		{
			num = 46;
		}
		goto IL_0009;
		IL_036d:
		if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-2017337494 ^ -2017338064))
		{
			goto IL_02b0;
		}
		goto IL_0168;
	}

	public static DateTime CorrectLocalTime(DateTime localTime, string exchange)
	{
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
		int num2;
		if (num <= 702486649)
		{
			if (num != 121984828)
			{
				if (num == 433752978)
				{
					goto IL_0296;
				}
				if (num == 702486649)
				{
					goto IL_0094;
				}
				num2 = 8;
			}
			else
			{
				if (exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-690510723 ^ -690510585))
				{
					goto IL_00e9;
				}
				int num3 = 6;
				num2 = num3;
			}
			goto IL_0009;
		}
		goto IL_0220;
		IL_0094:
		if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-838841832 ^ -838841442)))
		{
			goto IL_00e9;
		}
		goto IL_00fa;
		IL_01a3:
		if (num == 1903672507)
		{
			goto IL_00c3;
		}
		if (num == 2020397624 && exchange == (string)MaapxkkHSjMwyEPWbZhu(-1192989954 ^ -1192989732))
		{
			goto IL_00e9;
		}
		goto IL_00fa;
		IL_0296:
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-123775059 ^ -123775253)))
		{
			goto IL_00fa;
		}
		goto IL_00e9;
		IL_0220:
		if (num <= 1619544453)
		{
			num2 = 3;
			goto IL_0009;
		}
		goto IL_01a3;
		IL_00e9:
		return TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, EasternStandardTime);
		IL_00c3:
		if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x28C965BE ^ 0x28C96486)))
		{
			goto IL_00e9;
		}
		goto IL_00fa;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 7:
				break;
			case 9:
				goto IL_00c3;
			default:
				goto IL_00fa;
			case 1:
				goto IL_01a3;
			case 4:
				goto IL_0220;
			case 3:
				goto IL_024f;
			case 10:
				goto IL_0296;
			}
			break;
			IL_024f:
			if (num != 1610380443)
			{
				if (num != 1619544453)
				{
					num2 = 2;
					continue;
				}
				if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--927068468 ^ 0x3741F056)))
				{
					goto IL_00fa;
				}
			}
			else if (!q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7ADBF691 ^ 0x7ADBF7BD)))
			{
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_373428409f1e4944a16e6e1a459b6f73 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			goto IL_00e9;
		}
		goto IL_0094;
		IL_00fa:
		return localTime;
	}

	public static DateTime CorrectUtcTime(DateTime utcTime, string exchange)
	{
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
		int num2;
		if (num <= 702486649)
		{
			if (num == 121984828)
			{
				goto IL_00bf;
			}
			if (num == 433752978)
			{
				goto IL_011e;
			}
			if (num != 702486649 || !(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x706541F3 ^ 0x70654075)))
			{
				goto IL_01f3;
			}
			num2 = 7;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_783c5ce2dc1c46a2a6e7d2bdb7898bca == 0)
			{
				num2 = 4;
			}
		}
		else if (num <= 1619544453)
		{
			num2 = 5;
		}
		else
		{
			if (num == 1903672507)
			{
				goto IL_019c;
			}
			if (num != 2020397624)
			{
				goto IL_01f3;
			}
			if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x706541F3 ^ 0x706540D1)))
			{
				goto IL_01e2;
			}
			num2 = 6;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_7c432fb6ac314e0dac07b628339ad04f != 0)
			{
				num2 = 3;
			}
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 8:
				goto IL_011e;
			case 2:
				goto IL_019c;
			case 7:
				goto IL_01e2;
			case 1:
			case 4:
			case 6:
			case 9:
			case 10:
				goto IL_01f3;
			case 5:
				goto IL_01f5;
			case 3:
				goto IL_02a7;
			}
			break;
			IL_02a7:
			if (num == 1619544453)
			{
				if (q1Qgl4kHLcuVPZAo4q3e(exchange, MaapxkkHSjMwyEPWbZhu(-2074141628 ^ -2074141402)))
				{
					goto IL_01e2;
				}
				goto IL_01f3;
			}
			num2 = 1;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_024b7dc8ad0444029044c5845d055c38 != 0)
			{
				num2 = 4;
			}
			continue;
			IL_01f5:
			if (num != 1610380443)
			{
				num2 = 3;
				continue;
			}
			if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x5CD4F15 ^ 0x5CD4E39)))
			{
				goto IL_01f3;
			}
			goto IL_01e2;
		}
		goto IL_00bf;
		IL_019c:
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-44540535 ^ -44540751)))
		{
			num2 = 10;
			goto IL_0009;
		}
		goto IL_01e2;
		IL_00bf:
		if (q1Qgl4kHLcuVPZAo4q3e(exchange, RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x7F645F3C ^ 0x7F645E46)))
		{
			goto IL_01e2;
		}
		goto IL_01f3;
		IL_01f3:
		return utcTime;
		IL_011e:
		if (!(exchange == RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x1EFE0A28 ^ 0x1EFE0B6E)))
		{
			num2 = 1;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_783c5ce2dc1c46a2a6e7d2bdb7898bca != 0)
			{
				num2 = 1;
			}
			goto IL_0009;
		}
		goto IL_01e2;
		IL_01e2:
		return TimeZoneInfo.ConvertTime(utcTime, (TimeZoneInfo)UXXnGRkHE7vuLy5OBeGy(), (TimeZoneInfo)bJIHGhkH1tV7V6MiOY4n());
	}

	public static long UnixMs(this DateTime? dateTime)
	{
		if (!dateTime.HasValue)
		{
			return 0L;
		}
		return new DateTimeOffset(dateTime.Value.ToLocalTime()).ToUnixTimeMilliseconds();
	}

	public static DateTime GetLocalTimeWithNtpCorrection()
	{
		return LocalTime.AddMilliseconds(NtpTimeDiff);
	}

	internal static DateTime NVo2i5kHvYZKMc6JmDyQ()
	{
		return DateTime.Now;
	}

	internal static DateTime JaotyrkHBrO1DHVWISjG()
	{
		return LocalTime;
	}

	internal static object nN0V3mkHabPwUgdJdTSL()
	{
		return TimeZoneInfo.Local;
	}

	internal static object aV2i1dkHiY2KB10KhxEE()
	{
		return KyivStandardTime;
	}

	internal static DateTime E8oxsEkHld14I3pEySM3(DateTime P_0, object P_1, object P_2)
	{
		return TimeZoneInfo.ConvertTime(P_0, (TimeZoneInfo)P_1, (TimeZoneInfo)P_2);
	}

	internal static bool mTBMLrkHYapYB47e54PK()
	{
		return mDtPdrkHGhUVbejvXT8n == null;
	}

	internal static TimeHelper zKrCF5kHoED4kgEtahd1()
	{
		return mDtPdrkHGhUVbejvXT8n;
	}

	internal static void Li4aEVkH4GZuXgu2f9Jw()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
	}

	internal static object y0FIVpkHDMrL5d26rBRk(object P_0)
	{
		return TimeZoneInfo.FindSystemTimeZoneById((string)P_0);
	}

	internal static TimeSpan heA3P1kHbMCxIpxIUL3B(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object fhsKoYkHNelNZhKW9UBi()
	{
		return RussianStandardTime;
	}

	internal static DateTime Jni00gkHkqS5XCHaWTZx()
	{
		return DateTime.UtcNow;
	}

	internal static object bJIHGhkH1tV7V6MiOY4n()
	{
		return EasternStandardTime;
	}

	internal static DateTime dYCkljkH52yQZDpxBiCB(DateTime P_0, object P_1)
	{
		return TimeZoneInfo.ConvertTime(P_0, (TimeZoneInfo)P_1);
	}

	internal static object MaapxkkHSjMwyEPWbZhu(int P_0)
	{
		return RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(P_0);
	}

	internal static uint WCUTKXkHxHu9Jmc5NFH4(object P_0)
	{
		return global::_003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool q1Qgl4kHLcuVPZAo4q3e(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static DateTime KXD9LTkHe9XcQpSLTa4e()
	{
		return KyivTime;
	}

	internal static DateTime N0oN9akHscUH3CP2tI6e()
	{
		return ChicagoTime;
	}

	internal static TimeSpan ToCl1UkHXUm86cNVxOw1(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static DateTime zRMK9pkHc8706wRSwevb(object P_0)
	{
		return GetCurrTime((string)P_0);
	}

	internal static bool ILWvVikHjUlGaWnHiZ59(object P_0, DateTime P_1)
	{
		return ((TimeZoneInfo)P_0).IsInvalidTime(P_1);
	}

	internal static object UXXnGRkHE7vuLy5OBeGy()
	{
		return TimeZoneInfo.Utc;
	}
}
