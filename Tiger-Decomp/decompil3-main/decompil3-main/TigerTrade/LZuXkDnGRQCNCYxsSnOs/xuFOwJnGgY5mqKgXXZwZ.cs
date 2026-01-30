using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NsWD4W9miMxRbFU3fsu9;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace LZuXkDnGRQCNCYxsSnOs;

internal static class xuFOwJnGgY5mqKgXXZwZ
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct rPRQjrG0847eReeADRSP
	{
		public ypqMIv9maFM0tRwF0xMh hKYG0ALZJhy;

		public IList<double> oknG0PfRIlD;

		public double BxTG0JsQkTR;
	}

	internal static xuFOwJnGgY5mqKgXXZwZ uTq92sbPKsmhFH7yVBZ1;

	public static double j24nG6IF1hO(ypqMIv9maFM0tRwF0xMh P_0, int P_1)
	{
		IList<double> dates = P_0.Dates;
		if (W5Wwu6bPwAWd57TCHOIh(dates) != 0)
		{
			int num = 5;
			DataCycle dataCycle = default(DataCycle);
			DateTime dateTime = default(DateTime);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					if (P_1 < 0)
					{
						return dates[0];
					}
					if (P_1 < dates.Count)
					{
						num = 14;
						continue;
					}
					dataCycle = P_0.DataCycle;
					dateTime = DateTime.FromOADate(dates[dates.Count - 1]);
					num = 9;
					continue;
				case 6:
					while (FZ2ONLbPA1P1WjHKMuk7(dateTime, P_0.Symbol.Exchange))
					{
						dateTime = dateTime.AddMinutes(dataCycle.Repeat);
					}
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num = 2;
					}
					continue;
				case 13:
					dateTime = dateTime.AddMinutes(dataCycle.Repeat * num2);
					num = 6;
					continue;
				case 9:
					num2 = P_1 - (dates.Count - 1);
					switch (d6B02jbP7RsSwmQgpBWT(dataCycle))
					{
					case DataCycleBase.Year:
						dateTime = dateTime.AddYears(dataCycle.Repeat * num2);
						goto IL_023d;
					case DataCycleBase.Minute:
						break;
					case DataCycleBase.Day:
						goto IL_00f9;
					case DataCycleBase.Week:
						goto IL_0189;
					default:
						goto IL_023d;
					case DataCycleBase.Hour:
						goto IL_027b;
					case DataCycleBase.Second:
						goto IL_02a2;
					case DataCycleBase.Month:
						goto IL_02bb;
					case DataCycleBase.Tick:
					case DataCycleBase.Volume:
					case DataCycleBase.Delta:
					case DataCycleBase.Range:
					case DataCycleBase.Renko:
					case DataCycleBase.Reversal:
						goto IL_03d3;
					}
					goto case 13;
				case 14:
					return dates[P_1];
				case 2:
				case 4:
				case 7:
				case 15:
					goto IL_023d;
				case 10:
					dateTime = dateTime.AddHours(dataCycle.Repeat);
					goto IL_01b9;
				case 1:
					goto IL_027b;
				case 8:
					goto IL_02bb;
				case 11:
					dateTime = dateTime.AddSeconds(mrWQixbP8hQ2hKThOQEM(dataCycle));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
					{
						num = 0;
					}
					continue;
				default:
					if (!TimeHelper.IsInvalidTime(dateTime, P_0.Symbol.Exchange))
					{
						goto IL_023d;
					}
					num = 11;
					continue;
				case 12:
					goto IL_03d3;
					IL_00f9:
					dateTime = dateTime.AddDays(mrWQixbP8hQ2hKThOQEM(dataCycle) * num2);
					num = 7;
					continue;
					IL_03d3:
					dateTime = dateTime.AddMinutes(num2);
					goto IL_023d;
					IL_02bb:
					dateTime = dateTime.AddMonths(mrWQixbP8hQ2hKThOQEM(dataCycle) * num2);
					goto IL_023d;
					IL_02a2:
					dateTime = dateTime.AddSeconds(dataCycle.Repeat * num2);
					goto default;
					IL_027b:
					dateTime = dateTime.AddHours(mrWQixbP8hQ2hKThOQEM(dataCycle) * num2);
					goto IL_01b9;
					IL_01b9:
					if (!TimeHelper.IsInvalidTime(dateTime, P_0.Symbol.Exchange))
					{
						num = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
						{
							num = 2;
						}
						continue;
					}
					goto case 10;
					IL_0189:
					dateTime = dateTime.AddDays(dataCycle.Repeat * num2 * 7);
					num = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
					{
						num = 15;
					}
					continue;
					IL_023d:
					return dateTime.ToOADate();
				}
				break;
			}
		}
		return 0.0;
	}

	public static double ck4nGMMvCA1(ypqMIv9maFM0tRwF0xMh P_0, int P_1)
	{
		IList<double> dates = P_0.Dates;
		if (dates.Count != 0)
		{
			int num = 7;
			DateTime dateTime = default(DateTime);
			DataCycle dataCycle = default(DataCycle);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return dates[P_1];
					case 4:
					case 10:
					case 12:
					case 13:
						return dateTime.ToOADate();
					case 9:
						if (FZ2ONLbPA1P1WjHKMuk7(dateTime, ((SymbolBase)VaSfsmbPJBwoCuSX1sYj(P_0)).Exchange))
						{
							num2 = 8;
							continue;
						}
						goto case 4;
					case 3:
						goto IL_00db;
					default:
						goto IL_0115;
					case 8:
						dateTime = dateTime.AddHours(dataCycle.Repeat);
						goto case 9;
					case 5:
						if (TimeHelper.IsInvalidTime(dateTime, ((SymbolBase)VaSfsmbPJBwoCuSX1sYj(P_0)).Exchange))
						{
							num2 = 14;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 4;
					case 7:
						if (P_1 < 0 || P_1 >= W5Wwu6bPwAWd57TCHOIh(dates))
						{
							num3 = 0;
							num2 = 15;
							continue;
						}
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						num3 = P_1 - (W5Wwu6bPwAWd57TCHOIh(dates) - 1);
						goto IL_02cc;
					case 6:
						dateTime = dateTime.AddMinutes(mrWQixbP8hQ2hKThOQEM(dataCycle));
						goto IL_0169;
					case 17:
						goto IL_02f8;
					case 14:
						dateTime = dateTime.AddSeconds(dataCycle.Repeat);
						goto case 5;
					case 15:
						if (P_1 < 0)
						{
							num2 = 16;
							continue;
						}
						dateTime = qcRRwDbPPTWb6rck0US2(dates[dates.Count - 1]);
						num2 = 2;
						continue;
					case 16:
						dateTime = qcRRwDbPPTWb6rck0US2(dates[0]);
						num3 = P_1;
						goto IL_02cc;
					case 11:
						{
							switch (dataCycle.CycleBase)
							{
							case DataCycleBase.Second:
								goto IL_0079;
							case DataCycleBase.Day:
								goto IL_00db;
							case DataCycleBase.Year:
								dateTime = dateTime.AddYears(dataCycle.Repeat * num3);
								break;
							case DataCycleBase.Minute:
								goto IL_0115;
							case DataCycleBase.Week:
								dateTime = dateTime.AddDays(mrWQixbP8hQ2hKThOQEM(dataCycle) * num3 * 7);
								break;
							case DataCycleBase.Tick:
							case DataCycleBase.Volume:
							case DataCycleBase.Delta:
							case DataCycleBase.Range:
							case DataCycleBase.Renko:
							case DataCycleBase.Reversal:
								goto IL_02e2;
							case DataCycleBase.Hour:
								goto IL_02f8;
							case DataCycleBase.Month:
								dateTime = dateTime.AddMonths(dataCycle.Repeat * num3);
								break;
							}
							goto case 4;
						}
						IL_02e2:
						dateTime = dateTime.AddMinutes(num3);
						num2 = 12;
						continue;
						IL_0079:
						dateTime = dateTime.AddSeconds(dataCycle.Repeat * num3);
						num = 5;
						break;
						IL_0115:
						dateTime = dateTime.AddMinutes(dataCycle.Repeat * num3);
						goto IL_0169;
						IL_02f8:
						dateTime = dateTime.AddHours(dataCycle.Repeat * num3);
						num2 = 9;
						continue;
						IL_02cc:
						dataCycle = P_0.DataCycle;
						num = 11;
						break;
						IL_0169:
						if (!TimeHelper.IsInvalidTime(dateTime, P_0.Symbol.Exchange))
						{
							num2 = 10;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 6;
						IL_00db:
						dateTime = dateTime.AddDays(dataCycle.Repeat * num3);
						num = 13;
						break;
					}
					break;
				}
			}
		}
		return 0.0;
	}

	public static int f1MnGOxEZsq(ypqMIv9maFM0tRwF0xMh P_0, double P_1)
	{
		int result = default(int);
		try
		{
			int num;
			if (P_0.Count == 0)
			{
				result = 0;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 0;
				}
				goto IL_0015;
			}
			int num2 = -uWd8sfbPFahQRHOZZMqv(P_0) * 20;
			int num3 = P_0.Count * 20;
			goto IL_010b;
			IL_0015:
			int num4 = default(int);
			double num5 = default(double);
			double num6 = default(double);
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 8:
					goto IL_005d;
				default:
					result = num2;
					break;
				case 2:
					result = num4;
					num = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
					{
						num = 3;
					}
					continue;
				case 5:
					num2 = num4 + 1;
					num = 7;
					continue;
				case 7:
					goto IL_010b;
				case 1:
					goto IL_0147;
				case 4:
					goto IL_0186;
				case 6:
					break;
				}
				break;
				IL_0186:
				if (P_1 >= num5 && P_1 <= num6)
				{
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
					{
						num = 0;
					}
					continue;
				}
				if (!(P_1 < num5))
				{
					goto IL_005d;
				}
				num3 = num4 - 1;
				goto IL_010b;
				IL_005d:
				if (P_1 > num6)
				{
					num = 5;
					continue;
				}
				goto IL_010b;
			}
			goto end_IL_0001;
			IL_0147:
			num4 = (num2 + num3) / 2;
			num5 = zEs61bbP3NmrMA8ZFKNa(P_0, num4);
			num6 = num5 + VDfnGI5WPBi(P_0);
			int num7 = 4;
			num = num7;
			goto IL_0015;
			IL_010b:
			if (num2 > num3)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num = 0;
				}
				goto IL_0015;
			}
			goto IL_0147;
			end_IL_0001:;
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	public static int rKonGqaU8Rp(ypqMIv9maFM0tRwF0xMh P_0, double P_1, int P_2)
	{
		int num = 3;
		int num2 = num;
		int num4 = default(int);
		rPRQjrG0847eReeADRSP rPRQjrG0847eReeADRSP = default(rPRQjrG0847eReeADRSP);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				num4 = W5Wwu6bPwAWd57TCHOIh(rPRQjrG0847eReeADRSP.oknG0PfRIlD) - 1;
				num2 = 7;
				break;
			case 2:
				rPRQjrG0847eReeADRSP.BxTG0JsQkTR = P_1;
				rPRQjrG0847eReeADRSP.oknG0PfRIlD = rPRQjrG0847eReeADRSP.hKYG0ALZJhy.Dates;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				rPRQjrG0847eReeADRSP.hKYG0ALZJhy = P_0;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				if (rPRQjrG0847eReeADRSP.oknG0PfRIlD.Count == 0)
				{
					return 0;
				}
				if (rPRQjrG0847eReeADRSP.BxTG0JsQkTR > rPRQjrG0847eReeADRSP.oknG0PfRIlD[rPRQjrG0847eReeADRSP.oknG0PfRIlD.Count - 1])
				{
					num2 = 6;
					break;
				}
				if (rPRQjrG0847eReeADRSP.BxTG0JsQkTR < rPRQjrG0847eReeADRSP.oknG0PfRIlD[0])
				{
					return FdGnGUX7gZ6(ref rPRQjrG0847eReeADRSP);
				}
				num5 = 0;
				num2 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (!(rPRQjrG0847eReeADRSP.oknG0PfRIlD[num3] > rPRQjrG0847eReeADRSP.BxTG0JsQkTR + 1E-07))
				{
					goto case 1;
				}
				num4 = num3 + P_2;
				goto case 7;
			case 1:
				return num3;
			case 7:
				while (true)
				{
					if (num5 >= num4)
					{
						return num5;
					}
					num3 = (num5 + num4 - P_2) / 2;
					if (!(rPRQjrG0847eReeADRSP.oknG0PfRIlD[num3] < rPRQjrG0847eReeADRSP.BxTG0JsQkTR - 1E-07))
					{
						break;
					}
					num5 = num3 + P_2 + 1;
				}
				goto default;
			case 6:
				return EcXnGt4FKLk(ref rPRQjrG0847eReeADRSP);
			}
		}
	}

	public static double VDfnGI5WPBi(ypqMIv9maFM0tRwF0xMh P_0)
	{
		DateTime dateTime = DateTime.Now;
		DataCycle dataCycle = P_0.DataCycle;
		int num;
		DateTime now = default(DateTime);
		double num2 = default(double);
		switch (d6B02jbP7RsSwmQgpBWT(dataCycle))
		{
		case DataCycleBase.Day:
			dateTime = dateTime.AddDays(dataCycle.Repeat);
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
			{
				num = 6;
			}
			goto IL_0009;
		case DataCycleBase.Tick:
		case DataCycleBase.Volume:
		case DataCycleBase.Delta:
		case DataCycleBase.Range:
		case DataCycleBase.Renko:
		case DataCycleBase.Reversal:
			dateTime = dateTime.AddMinutes(1.0);
			num = 8;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
			{
				num = 4;
			}
			goto IL_0009;
		case DataCycleBase.Second:
			dateTime = dateTime.AddSeconds(dataCycle.Repeat);
			goto IL_0037;
		case DataCycleBase.Month:
			dateTime = dateTime.AddMonths(dataCycle.Repeat);
			goto IL_0037;
		default:
			num = 5;
			goto IL_0009;
		case DataCycleBase.Minute:
			dateTime = dateTime.AddMinutes(mrWQixbP8hQ2hKThOQEM(dataCycle));
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case DataCycleBase.Week:
			goto IL_01b8;
		case DataCycleBase.Year:
			dateTime = dateTime.AddYears(dataCycle.Repeat);
			goto IL_0037;
		case DataCycleBase.Hour:
			goto IL_01fd;
			IL_01fd:
			dateTime = dateTime.AddHours(mrWQixbP8hQ2hKThOQEM(dataCycle));
			num = 7;
			goto IL_0009;
			IL_01b8:
			dateTime = dateTime.AddDays(dataCycle.Repeat * 7);
			goto IL_0037;
			IL_0037:
			now = DateTime.Now;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num = 2;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
				case 6:
				case 7:
				case 8:
					break;
				case 4:
					return dateTime.ToOADate() - num2;
				default:
					goto IL_01b8;
				case 3:
					goto IL_01fd;
				case 2:
					num2 = now.ToOADate();
					num = 4;
					continue;
				}
				break;
			}
			goto IL_0037;
		}
	}

	[CompilerGenerated]
	internal static int CRbnGWfwGfr(ref rPRQjrG0847eReeADRSP P_0)
	{
		DataCycle dataCycle = (DataCycle)iC40ITbPp6N5UJ0CGDTx(P_0.hKYG0ALZJhy);
		DataCycleBase cycleBase = dataCycle.CycleBase;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			switch (cycleBase)
			{
			case DataCycleBase.Second:
				return dataCycle.Repeat;
			case DataCycleBase.Minute:
				return dataCycle.Repeat * 60;
			case DataCycleBase.Hour:
				return dataCycle.Repeat * 60 * 60;
			case DataCycleBase.Day:
				return dataCycle.Repeat * 60 * 60 * 24;
			case DataCycleBase.Week:
				return dataCycle.Repeat * 60 * 60 * 24 * 7;
			case DataCycleBase.Month:
				return dataCycle.Repeat * 60 * 60 * 24 * 30;
			case DataCycleBase.Year:
				return mrWQixbP8hQ2hKThOQEM(dataCycle) * 60 * 60 * 24 * 365;
			case DataCycleBase.Tick:
			case DataCycleBase.Volume:
			case DataCycleBase.Delta:
			case DataCycleBase.Range:
			case DataCycleBase.Renko:
			case DataCycleBase.Reversal:
				return 60;
			default:
				return 60;
			}
		}
	}

	[CompilerGenerated]
	internal static int EcXnGt4FKLk(ref rPRQjrG0847eReeADRSP P_0)
	{
		DateTime dateTime = qcRRwDbPPTWb6rck0US2(P_0.oknG0PfRIlD[P_0.oknG0PfRIlD.Count - 1]);
		TimeSpan timeSpan = qcRRwDbPPTWb6rck0US2(P_0.BxTG0JsQkTR) - dateTime;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			int num2 = CRbnGWfwGfr(ref P_0);
			return P_0.oknG0PfRIlD.Count - 1 + (int)(timeSpan.TotalSeconds / (double)num2);
		}
		}
	}

	[CompilerGenerated]
	internal static int FdGnGUX7gZ6(ref rPRQjrG0847eReeADRSP P_0)
	{
		DateTime dateTime = DateTime.FromOADate(P_0.BxTG0JsQkTR);
		TimeSpan timeSpan = OgCNh0bPuj8jKmq95lkm(DateTime.FromOADate(P_0.oknG0PfRIlD[0]), dateTime);
		int num = CRbnGWfwGfr(ref P_0);
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => -(int)(timeSpan.TotalSeconds / (double)num), 
		};
	}

	static xuFOwJnGgY5mqKgXXZwZ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static int W5Wwu6bPwAWd57TCHOIh(object P_0)
	{
		return ((ICollection<double>)P_0).Count;
	}

	internal static DataCycleBase d6B02jbP7RsSwmQgpBWT(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static int mrWQixbP8hQ2hKThOQEM(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static bool FZ2ONLbPA1P1WjHKMuk7(DateTime P_0, object P_1)
	{
		return TimeHelper.IsInvalidTime(P_0, (string)P_1);
	}

	internal static bool MfxNiobPmeWM872CUbZq()
	{
		return uTq92sbPKsmhFH7yVBZ1 == null;
	}

	internal static xuFOwJnGgY5mqKgXXZwZ dFBwZPbPh8eQ1vpGV4S3()
	{
		return uTq92sbPKsmhFH7yVBZ1;
	}

	internal static DateTime qcRRwDbPPTWb6rck0US2(double P_0)
	{
		return DateTime.FromOADate(P_0);
	}

	internal static object VaSfsmbPJBwoCuSX1sYj(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Symbol;
	}

	internal static int uWd8sfbPFahQRHOZZMqv(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Count;
	}

	internal static double zEs61bbP3NmrMA8ZFKNa(object P_0, int P_1)
	{
		return ck4nGMMvCA1((ypqMIv9maFM0tRwF0xMh)P_0, P_1);
	}

	internal static object iC40ITbPp6N5UJ0CGDTx(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).DataCycle;
	}

	internal static TimeSpan OgCNh0bPuj8jKmq95lkm(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}
}
