using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Collections;

public sealed class IndicatorSeries : IEnumerable<IndicatorSeriesData>, IEnumerable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Bv8FnZimK1CMy8qyOlSH
	{
		public static readonly Bv8FnZimK1CMy8qyOlSH RtaimhGM9nV;

		public static Func<double, bool> CjLimwW6BFW;

		private static Bv8FnZimK1CMy8qyOlSH AsUJvbeTbqVAXHKmTl1b;

		static Bv8FnZimK1CMy8qyOlSH()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
					tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
					RtaimhGM9nV = new Bv8FnZimK1CMy8qyOlSH();
					return;
				}
			}
		}

		public Bv8FnZimK1CMy8qyOlSH()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		internal bool aBPimmWSVeI(double d)
		{
			if (d != 0.0)
			{
				return !double.IsNaN(d);
			}
			return false;
		}

		internal static bool HXDjwgeTNTDEo9R8SbRc()
		{
			return AsUJvbeTbqVAXHKmTl1b == null;
		}

		internal static Bv8FnZimK1CMy8qyOlSH Hh2pIMeTkxI0CRLqVfxa()
		{
			return AsUJvbeTbqVAXHKmTl1b;
		}
	}

	private readonly List<IndicatorSeriesData> _series;

	private static IndicatorSeries gTUv3meqgIRjekvxYygu;

	public int Count => _series.Count;

	public IndicatorSeriesData this[int i]
	{
		get
		{
			return _series[i];
		}
		set
		{
			_series[i] = value;
		}
	}

	private static bool CheckSeries(IndicatorSeriesData series)
	{
		if (series.Data.Length != 0)
		{
			return series.Data.Any((double d) => d != 0.0 && !double.IsNaN(d));
		}
		return true;
	}

	public void Add(IndicatorSeriesData series)
	{
		if (CheckSeries(series))
		{
			_series.Add(series);
		}
	}

	public void Add(IndicatorSeriesData series1, IndicatorSeriesData series2)
	{
		if (pVVmaxeqM3ivC6Tgvqu3(series1))
		{
			_series.Add(series1);
		}
		if (CheckSeries(series2))
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			_series.Add(series2);
		}
	}

	public void Add(IndicatorSeriesData series1, IndicatorSeriesData series2, IndicatorSeriesData series3)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			case 3:
				if (pVVmaxeqM3ivC6Tgvqu3(series2))
				{
					_series.Add(series2);
				}
				if (!pVVmaxeqM3ivC6Tgvqu3(series3))
				{
					return;
				}
				_series.Add(series3);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (CheckSeries(series1))
				{
					_series.Add(series1);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public void Add(params IndicatorSeriesData[] series)
	{
		int num = 4;
		int num2 = num;
		IndicatorSeriesData indicatorSeriesData = default(IndicatorSeriesData);
		int num3 = default(int);
		IndicatorSeriesData[] array = default(IndicatorSeriesData[]);
		while (true)
		{
			switch (num2)
			{
			default:
				if (CheckSeries(indicatorSeriesData))
				{
					_series.Add(indicatorSeriesData);
				}
				num3++;
				goto case 2;
			case 4:
				array = series;
				num2 = 3;
				break;
			case 1:
				indicatorSeriesData = array[num3];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (num3 >= array.Length)
				{
					return;
				}
				goto case 1;
			case 3:
				num3 = 0;
				num2 = 2;
				break;
			}
		}
	}

	public void Clear()
	{
		_series.Clear();
	}

	public IEnumerator<IndicatorSeriesData> GetEnumerator()
	{
		return _series.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)_series).GetEnumerator();
	}

	public IndicatorSeries()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		_series = new List<IndicatorSeriesData>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static IndicatorSeries()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		dQJxndeqOu0AE53riZXC();
	}

	internal static bool PSRNageqRpYDYAHbj9Nr()
	{
		return gTUv3meqgIRjekvxYygu == null;
	}

	internal static IndicatorSeries zL9emKeq68jE8qWeRZns()
	{
		return gTUv3meqgIRjekvxYygu;
	}

	internal static bool pVVmaxeqM3ivC6Tgvqu3(object P_0)
	{
		return CheckSeries((IndicatorSeriesData)P_0);
	}

	internal static void dQJxndeqOu0AE53riZXC()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
