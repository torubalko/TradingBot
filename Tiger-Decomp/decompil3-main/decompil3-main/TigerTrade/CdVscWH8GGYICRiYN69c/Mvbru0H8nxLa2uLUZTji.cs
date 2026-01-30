using System;
using System.Runtime.CompilerServices;
using aWyZAjHVfueYKTD2qNgp;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SPAoDtH8UqWClrJdZZx5;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xsKIRfH8jh6BsrSefSnT;

namespace CdVscWH8GGYICRiYN69c;

[JsonObject(/*Could not decode attribute arguments.*/)]
internal class Mvbru0H8nxLa2uLUZTji : QCMRkVHVHQDMIML9Hckc
{
	[CompilerGenerated]
	private string JC8H81Yo3bl;

	[CompilerGenerated]
	private VDdUVdH8cph4KxvTnna2 zy1H85yAS3G;

	[CompilerGenerated]
	private long MAkH8S00DJe;

	[CompilerGenerated]
	private long? qHaH8xm0i5g;

	[CompilerGenerated]
	private K2bOtZH8tQ4TYA1jpZ1L NV0H8LWMKu6;

	internal static Mvbru0H8nxLa2uLUZTji K2KBHcDTbPkbi9Fa0mWx;

	[JsonProperty("symbol")]
	public string Symbol
	{
		[CompilerGenerated]
		get
		{
			return JC8H81Yo3bl;
		}
		[CompilerGenerated]
		set
		{
			JC8H81Yo3bl = value;
		}
	}

	[JsonProperty("interval")]
	[JsonConverter(typeof(StringEnumConverter))]
	public VDdUVdH8cph4KxvTnna2 MmJH8icJQFC
	{
		[CompilerGenerated]
		get
		{
			return zy1H85yAS3G;
		}
		[CompilerGenerated]
		set
		{
			zy1H85yAS3G = value;
		}
	}

	[JsonProperty("startTime")]
	public long StartTime
	{
		[CompilerGenerated]
		get
		{
			return MAkH8S00DJe;
		}
		[CompilerGenerated]
		set
		{
			MAkH8S00DJe = value;
		}
	}

	[JsonProperty("endTime")]
	public long? EndTime
	{
		[CompilerGenerated]
		get
		{
			return qHaH8xm0i5g;
		}
		[CompilerGenerated]
		set
		{
			qHaH8xm0i5g = value;
		}
	}

	[JsonConverter(typeof(StringEnumConverter))]
	[JsonProperty("priceType")]
	public K2bOtZH8tQ4TYA1jpZ1L PriceType
	{
		[CompilerGenerated]
		get
		{
			return NV0H8LWMKu6;
		}
		[CompilerGenerated]
		set
		{
			NV0H8LWMKu6 = value;
		}
	}

	public Mvbru0H8nxLa2uLUZTji(Symbol H5jtkllNRh0tPKByKuCn, DataCycle rAlCNklN6bRa0isElRU6)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Symbol = (string)uiEoP2DT1CTp0lTjJ969(H5jtkllNRh0tPKByKuCn);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				PriceType = K2bOtZH8tQ4TYA1jpZ1L.Last;
				return;
			}
			MmJH8icJQFC = spPH8YiHZ80(rAlCNklN6bRa0isElRU6);
			StartTime = Math.Max(DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1000L * (long)MmJH8icJQFC, 0L);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
			{
				num = 1;
			}
		}
	}

	private VDdUVdH8cph4KxvTnna2 spPH8YiHZ80(DataCycle lVxcw5lNMwfuxM9RJ0fY)
	{
		int num = 4;
		DataCycleBase cycleBase = default(DataCycleBase);
		int repeat = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					cycleBase = lVxcw5lNMwfuxM9RJ0fY.CycleBase;
					num2 = 3;
					break;
				case 8:
					if (repeat != 5)
					{
						goto IL_0149;
					}
					return VDdUVdH8cph4KxvTnna2.M5;
				case 2:
					return VDdUVdH8cph4KxvTnna2.M1;
				case 6:
					return VDdUVdH8cph4KxvTnna2.M15;
				case 10:
					return VDdUVdH8cph4KxvTnna2.M1;
				case 3:
					switch (cycleBase)
					{
					default:
						return VDdUVdH8cph4KxvTnna2.Vo9H8WCimAJ;
					case DataCycleBase.Hour:
						repeat = lVxcw5lNMwfuxM9RJ0fY.Repeat;
						num2 = 11;
						goto end_IL_0012;
					case DataCycleBase.Day:
						return lVxcw5lNMwfuxM9RJ0fY.Repeat switch
						{
							1 => VDdUVdH8cph4KxvTnna2.tDvH8OpLs4k, 
							3 => VDdUVdH8cph4KxvTnna2.kXdH8qsNo2x, 
							_ => VDdUVdH8cph4KxvTnna2.tDvH8OpLs4k, 
						};
					case DataCycleBase.Week:
						g5lndbDT5yO2eyAoAoYo(lVxcw5lNMwfuxM9RJ0fY);
						_ = 1;
						return VDdUVdH8cph4KxvTnna2.bH1H8IcZH2n;
					case DataCycleBase.Minute:
						break;
					}
					repeat = lVxcw5lNMwfuxM9RJ0fY.Repeat;
					if (repeat <= 5)
					{
						if (repeat != 1)
						{
							goto end_IL_0012_2;
						}
						goto case 10;
					}
					num2 = 9;
					break;
				case 7:
				case 9:
					if (repeat == 15)
					{
						return VDdUVdH8cph4KxvTnna2.M15;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return VDdUVdH8cph4KxvTnna2.T9sH8QNVgIK;
				default:
					if (repeat == 30)
					{
						return VDdUVdH8cph4KxvTnna2.nbtH8EW7ybJ;
					}
					goto IL_0149;
				case 11:
					if (repeat != 1)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 1;
				case 5:
					{
						switch (repeat)
						{
						case 4:
							return VDdUVdH8cph4KxvTnna2.FjEH8gw4kcx;
						case 12:
							return VDdUVdH8cph4KxvTnna2.dsSH8MV9DV8;
						default:
							if (lVxcw5lNMwfuxM9RJ0fY.Repeat % 4 != 0)
							{
								return VDdUVdH8cph4KxvTnna2.T9sH8QNVgIK;
							}
							return VDdUVdH8cph4KxvTnna2.FjEH8gw4kcx;
						}
					}
					IL_0149:
					if (g5lndbDT5yO2eyAoAoYo(lVxcw5lNMwfuxM9RJ0fY) % 30 == 0)
					{
						return VDdUVdH8cph4KxvTnna2.nbtH8EW7ybJ;
					}
					if (lVxcw5lNMwfuxM9RJ0fY.Repeat % 15 == 0)
					{
						num2 = 6;
						break;
					}
					if (lVxcw5lNMwfuxM9RJ0fY.Repeat % 5 == 0)
					{
						return VDdUVdH8cph4KxvTnna2.M5;
					}
					num2 = 2;
					break;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
			num = 8;
		}
	}

	static Mvbru0H8nxLa2uLUZTji()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Xkg16iDTNceaJo3RgtDf()
	{
		return K2KBHcDTbPkbi9Fa0mWx == null;
	}

	internal static Mvbru0H8nxLa2uLUZTji Jnmdl2DTkBIhA1PtdsDZ()
	{
		return K2KBHcDTbPkbi9Fa0mWx;
	}

	internal static object uiEoP2DT1CTp0lTjJ969(object P_0)
	{
		return ((Symbol)P_0).Code;
	}

	internal static int g5lndbDT5yO2eyAoAoYo(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}
}
