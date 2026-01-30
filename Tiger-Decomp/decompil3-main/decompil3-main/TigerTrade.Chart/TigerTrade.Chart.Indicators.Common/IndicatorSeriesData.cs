using System;
using System.Collections;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Drawings;

namespace TigerTrade.Chart.Indicators.Common;

public sealed class IndicatorSeriesData
{
	private readonly Hashtable _subData;

	private readonly Hashtable _pointsCache;

	internal static IndicatorSeriesData jpcA4ReMAuMxweAaMdFR;

	public double[] Data { get; }

	public IndicatorSeriesStyle Style { get; }

	public Hashtable UserData { get; }

	public double this[int n] => Data[n];

	public double this[double n] => this[(int)n];

	public double[] this[string name]
	{
		get
		{
			return (double[])sT7RtyeM3v2Li3BwfLju(_subData, name);
		}
		set
		{
			TGcoWJeMpaLnevelEB49(_subData, name, value);
		}
	}

	public int Length => Data.Length;

	private IndicatorSeriesData()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Style = new IndicatorSeriesStyle();
		UserData = new Hashtable();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				_pointsCache = new Hashtable();
				return;
			}
			_subData = new Hashtable();
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
			{
				num = 1;
			}
		}
	}

	public IndicatorSeriesData(double[] data)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector();
		Data = data;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public IndicatorSeriesData(double[] data, ChartSeries style, string name = "")
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(data);
		Style.Set(style, name);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public IndicatorSeriesData(double[] data, ChartRegion style)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(data);
		Style.Set(style);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public IndicatorSeriesData(double[] data, ChartLine style)
	{
		JK9SW5eMFOv24mt9D31M();
		this._002Ector(data);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Style.Set(style);
	}

	public double MaxValue()
	{
		return MaxValue(0, Length);
	}

	public double MaxValue(int start, int count)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = MaxValue(Data, start, count, double.MinValue);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (_subData != null)
			{
				IEnumerator enumerator = ((IEnumerable)KToMVXeMuqxX7XexYNXt(_subData)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string text = (string)enumerator.Current;
						num3 = MaxValue((double[])sT7RtyeM3v2Li3BwfLju(_subData, text), start, count, num3);
					}
					int num4 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						UqPXdVeMzZGSnp7I94BD(disposable);
						int num5 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				}
			}
			return num3;
		}
	}

	private double MaxValue(double[] dd, int start, int count, double currentMax)
	{
		double num = currentMax;
		int num2 = dd.Length - Math.Max(0, start) - 1;
		int num3 = mDbmJBeO0i0tEIOTNNqM(0, dd.Length - start - count);
		int num4 = num2;
		int num5 = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
		{
			num5 = 2;
		}
		while (true)
		{
			switch (num5)
			{
			case 2:
			case 3:
				if (num4 < num3)
				{
					return num;
				}
				if (!double.IsNaN(dd[num4]))
				{
					num5 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
					{
						num5 = 0;
					}
					break;
				}
				goto default;
			default:
				num4--;
				num5 = 3;
				break;
			case 1:
				if (double.IsInfinity(dd[num4]) || !(dd[num4] > num))
				{
					goto default;
				}
				num = dd[num4];
				num5 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num5 = 0;
				}
				break;
			}
		}
	}

	public double MinValue()
	{
		return MinValue(0, Length);
	}

	public double MinValue(int start, int count)
	{
		double num = qqE22ueO2p5UtmacnXL1(Data, start, count, double.MaxValue);
		if (_subData != null)
		{
			IEnumerator enumerator = _subData.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string key = (string)enumerator.Current;
					num = MinValue((double[])_subData[key], start, count, num);
					int num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
					int num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
		}
		return num;
	}

	private static double MinValue(double[] dd, int start, int count, double currentMin)
	{
		double num = currentMin;
		int num2 = dd.Length - Math.Max(0, start) - 1;
		int num3 = Math.Max(0, dd.Length - start - count);
		int num4 = num2;
		int num5 = 3;
		while (true)
		{
			switch (num5)
			{
			default:
				if (dd[num4] < num)
				{
					num = dd[num4];
				}
				break;
			case 2:
				return num;
			case 1:
			case 3:
				if (num4 >= num3)
				{
					if (!fWM4Y7eOHmKKVSTJ70Ab(dd[num4]) && !ljGnCJeOfXC1uFWh65v8(dd[num4]))
					{
						num5 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
						{
							num5 = 0;
						}
						continue;
					}
					break;
				}
				num5 = 2;
				continue;
			}
			num4--;
			num5 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
			{
				num5 = 1;
			}
		}
	}

	public void CachePoints(Point[] points, string pointsName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				pointsName = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2123795572 ^ -2123769814);
				goto IL_003d;
			case 1:
				{
					if (string.IsNullOrEmpty(pointsName))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_003d;
				}
				IL_003d:
				TGcoWJeMpaLnevelEB49(_pointsCache, pointsName, points);
				return;
			}
		}
	}

	public double GetDistance(double x, double y)
	{
		double num = double.MaxValue;
		if (_pointsCache != null)
		{
			IEnumerator enumerator = _pointsCache.Values.GetEnumerator();
			try
			{
				int minDistIndex = default(int);
				while (enumerator.MoveNext())
				{
					Point[] array = (Point[])enumerator.Current;
					if (array == null)
					{
						continue;
					}
					int num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							minDistIndex = GetMinDistIndex(x, array);
							num2 = 2;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
							{
								num2 = 2;
							}
							continue;
						default:
							num = QMxKNQeO985ajVon3p4Q(num, Math.Abs(y - array[minDistIndex].Y));
							break;
						case 2:
							if (minDistIndex >= 0 && minDistIndex < array.Length)
							{
								num2 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						}
						break;
					}
				}
				return num;
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				int num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					if (disposable != null)
					{
						UqPXdVeMzZGSnp7I94BD(disposable);
					}
					break;
				}
			}
		}
		int num4 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
		{
			num4 = 0;
		}
		return num4 switch
		{
			_ => num, 
		};
	}

	private int GetMinDistIndex(double x, Point[] points)
	{
		int num = 0;
		int num2 = points.Length - 1;
		int num3 = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
		{
			num3 = 3;
		}
		int num4 = default(int);
		while (true)
		{
			switch (num3)
			{
			default:
				return num4;
			case 3:
			{
				while (num < num2)
				{
					num4 = (num + num2) / 2;
					if (x < points[num4].X)
					{
						num = num4 + 1;
						continue;
					}
					goto IL_0068;
				}
				int num5 = 2;
				num3 = num5;
				break;
			}
			case 1:
				num2 = num4;
				goto case 3;
			case 2:
				{
					return num;
				}
				IL_0068:
				if (x > points[num4].X)
				{
					num3 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
					{
						num3 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	static IndicatorSeriesData()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		zNRw4QeOnn5OnbendDF4();
	}

	internal static bool biV7tveMP57UuQ2CMYDp()
	{
		return jpcA4ReMAuMxweAaMdFR == null;
	}

	internal static IndicatorSeriesData HlLpf9eMJ8SmKO5YwHKI()
	{
		return jpcA4ReMAuMxweAaMdFR;
	}

	internal static void JK9SW5eMFOv24mt9D31M()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object sT7RtyeM3v2Li3BwfLju(object P_0, object P_1)
	{
		return ((Hashtable)P_0)[P_1];
	}

	internal static void TGcoWJeMpaLnevelEB49(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0)[P_1] = P_2;
	}

	internal static object KToMVXeMuqxX7XexYNXt(object P_0)
	{
		return ((Hashtable)P_0).Keys;
	}

	internal static void UqPXdVeMzZGSnp7I94BD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int mDbmJBeO0i0tEIOTNNqM(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double qqE22ueO2p5UtmacnXL1(object P_0, int start, int count, double currentMin)
	{
		return MinValue((double[])P_0, start, count, currentMin);
	}

	internal static bool fWM4Y7eOHmKKVSTJ70Ab(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static bool ljGnCJeOfXC1uFWh65v8(double P_0)
	{
		return double.IsInfinity(P_0);
	}

	internal static double QMxKNQeO985ajVon3p4Q(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void zNRw4QeOnn5OnbendDF4()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
