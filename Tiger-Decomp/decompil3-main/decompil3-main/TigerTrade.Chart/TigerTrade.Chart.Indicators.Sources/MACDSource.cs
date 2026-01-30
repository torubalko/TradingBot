using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("MACD", Type = typeof(MACDSource))]
[DataContract(Name = "MACDSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class MACDSource : IndicatorSourceBase
{
	private int _slow;

	private int _fast;

	private int _signal;

	private IndicatorSourceBase _source;

	internal static MACDSource XPx3LWeBrlpuFLPuYiAC;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSlowPeriod")]
	[DataMember(Name = "Slow")]
	public int Slow
	{
		get
		{
			return _slow;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (value != _slow)
					{
						_slow = value;
						OnPropertyChanged((string)XKO0tdeBhQyH8iFAZNRX(0x130FEA25 ^ 0x130F6197));
					}
					return;
				case 1:
					value = Math.Max(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsFastPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Fast")]
	public int Fast
	{
		get
		{
			return _fast;
		}
		set
		{
			value = vj1MEJeBwBKJJ9HwXZsN(1, value);
			if (value != _fast)
			{
				_fast = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82891402));
			}
		}
	}

	[DataMember(Name = "Signal")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSignalPeriod")]
	public int Signal
	{
		get
		{
			return _signal;
		}
		set
		{
			value = vj1MEJeBwBKJJ9HwXZsN(1, value);
			if (value != _signal)
			{
				_signal = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28BBDCA ^ 0x28B3600));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorSourceBase Source
	{
		get
		{
			return _source ?? (_source = new StockSource());
		}
		set
		{
			if (value != _source)
			{
				_source = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710534138));
			}
		}
	}

	public MACDSource()
	{
		y6ZYdxeB7pBZ9dWHcGwL();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Slow = 26;
				Fast = 12;
				Signal = 9;
				base.SelectedSeries = (string)XKO0tdeBhQyH8iFAZNRX(0x1D7BA1ED ^ 0x1D7B2A37);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774636079),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461292091 ^ -1461258205),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3464847)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = Source.GetSeries(helper);
		double[] macd = default(double[]);
		double[] macdSignal = default(double[]);
		double[] macdHist = default(double[]);
		string selectedSeries = default(string);
		int num;
		if (series != null)
		{
			helper.MACD(series, Fast, Slow, Signal, out macd, out macdSignal, out macdHist);
			selectedSeries = base.SelectedSeries;
			if (OyOU5meB8W9gFmuoXamV(selectedSeries, XKO0tdeBhQyH8iFAZNRX(0x7394D272 ^ 0x739459A8)))
			{
				goto IL_0095;
			}
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 2:
			break;
		case 1:
			if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-490987856 ^ -490957482)))
			{
				if (OyOU5meB8W9gFmuoXamV(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECAB4D6)))
				{
					return macdHist;
				}
				return null;
			}
			return macdSignal;
		default:
			return null;
		}
		goto IL_0095;
		IL_0095:
		return macd;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		MACDSource mACDSource = default(MACDSource);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Slow = mACDSource.Slow;
				Fast = mACDSource.Fast;
				Signal = mACDSource.Signal;
				num2 = 3;
				continue;
			case 1:
				mACDSource = source as MACDSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				Source = ((IndicatorSourceBase)VD8jm1eBAykMqRRSpxYJ(mACDSource)).CloneSource();
				return;
			}
			if (mACDSource == null)
			{
				return;
			}
			base.SelectedSeries = mACDSource.SelectedSeries;
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
			{
				num2 = 2;
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x42D899B5 ^ 0x42D81E51);
		}
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB7A83), base.SelectedSeries, Source, Slow, Fast, Signal);
	}

	static MACDSource()
	{
		GS0ERxeBPA4F9nohleKH();
		IpAN04eBJkkYiZSfTrRm();
	}

	internal static object XKO0tdeBhQyH8iFAZNRX(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool lHZ4mFeBK0lRhZtlVANU()
	{
		return XPx3LWeBrlpuFLPuYiAC == null;
	}

	internal static MACDSource eYf7cReBmNuMU4aDjpY1()
	{
		return XPx3LWeBrlpuFLPuYiAC;
	}

	internal static int vj1MEJeBwBKJJ9HwXZsN(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void y6ZYdxeB7pBZ9dWHcGwL()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static bool OyOU5meB8W9gFmuoXamV(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object VD8jm1eBAykMqRRSpxYJ(object P_0)
	{
		return ((MACDSource)P_0).Source;
	}

	internal static void GS0ERxeBPA4F9nohleKH()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void IpAN04eBJkkYiZSfTrRm()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
