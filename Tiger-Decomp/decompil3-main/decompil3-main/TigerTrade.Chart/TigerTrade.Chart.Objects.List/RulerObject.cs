using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("Ruler", "ChartObjectsRuler", 3, Type = typeof(RulerObject))]
[DataContract(Name = "RulerObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class RulerObject : LineObjectBase
{
	private bool _showInfoBars;

	private bool _showInfoTime;

	private bool _showInfoPrice;

	private bool _showInfoTicks;

	private bool _showInfoChange;

	private bool _showInfoVolume;

	private bool _showInfoTrades;

	private bool _showInfoDelta;

	private bool _showInfoBid;

	private bool _showInfoAsk;

	private XColor _textColor;

	private Rect _infoRect;

	private static RulerObject xIqHhceHvBuBjhVTDplh;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "ShowInfoBars")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoBars")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoBars
	{
		get
		{
			return _showInfoBars;
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
					return;
				case 1:
					if (value == _showInfoBars)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_showInfoBars = value;
					OnPropertyChanged((string)WsVoSqeHinlw6dh9egue(-991861155 ^ -991828441));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "ShowInfoTime")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoTime")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoTime
	{
		get
		{
			return _showInfoTime;
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
					return;
				case 1:
					if (value == _showInfoTime)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
						{
							num2 = 0;
						}
						break;
					}
					_showInfoTime = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-842040449 ^ -842007575));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "ShowInfoPrice")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoPrice")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoPrice
	{
		get
		{
			return _showInfoPrice;
		}
		set
		{
			if (value != _showInfoPrice)
			{
				_showInfoPrice = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1962651919 ^ -1962619325));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoTicks")]
	[DataMember(Name = "ShowInfoTicks")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoTicks
	{
		get
		{
			return _showInfoTicks;
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
					return;
				case 1:
					if (value == _showInfoTicks)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_showInfoTicks = value;
					OnPropertyChanged((string)WsVoSqeHinlw6dh9egue(-377195341 ^ -377162653));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoChange")]
	[DataMember(Name = "ShowInfoChange")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoChange
	{
		get
		{
			return _showInfoChange;
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
					return;
				case 1:
					if (value == _showInfoChange)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_showInfoChange = value;
					OnPropertyChanged((string)WsVoSqeHinlw6dh9egue(0x4297C3EB ^ 0x42974305));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "ShowInfoVolume")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoVolume")]
	public bool ShowInfoVolume
	{
		get
		{
			return _showInfoVolume;
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
					return;
				case 0:
					return;
				case 1:
					if (value != _showInfoVolume)
					{
						_showInfoVolume = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3E0426F0 ^ 0x3E04A7FE));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoTrades")]
	[DataMember(Name = "ShowInfoTrades")]
	public bool ShowInfoTrades
	{
		get
		{
			return _showInfoTrades;
		}
		set
		{
			if (value != _showInfoTrades)
			{
				_showInfoTrades = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -6010645));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoDelta")]
	[DataMember(Name = "ShowInfoDelta")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoDelta
	{
		get
		{
			return _showInfoDelta;
		}
		set
		{
			if (value != _showInfoDelta)
			{
				_showInfoDelta = value;
				OnPropertyChanged((string)WsVoSqeHinlw6dh9egue(-530053095 ^ -530020009));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoBid")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "ShowInfoBid")]
	public bool ShowInfoBid
	{
		get
		{
			return _showInfoBid;
		}
		set
		{
			if (value != _showInfoBid)
			{
				_showInfoBid = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1417019345));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowInfoAsk")]
	[DataMember(Name = "ShowInfoAsk")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool ShowInfoAsk
	{
		get
		{
			return _showInfoAsk;
		}
		set
		{
			if (value != _showInfoAsk)
			{
				_showInfoAsk = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673651001));
			}
		}
	}

	[Browsable(false)]
	private XBrush TextBrush { get; set; }

	[DataMember(Name = "TextColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsTextColor")]
	public XColor TextColor
	{
		get
		{
			return _textColor;
		}
		set
		{
			if (!(value == _textColor))
			{
				_textColor = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				TextBrush = new XBrush(_textColor);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-123775059 ^ -123787021));
			}
		}
	}

	public RulerObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ShowInfoBars = true;
				num = 2;
				continue;
			case 3:
				return;
			case 2:
				ShowInfoTime = true;
				ShowInfoPrice = true;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
				{
					num = 0;
				}
				continue;
			}
			ShowInfoChange = true;
			ShowInfoTicks = true;
			ShowInfoVolume = true;
			ShowInfoDelta = true;
			TextColor = Colors.White;
			num = 3;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
			{
				num = 2;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		Point[] array = ToPoints(base.ControlPoints);
		visual.DrawLines(base.LinePen, array);
		if (InSetup && base.ControlPoints[0].X == base.ControlPoints[2].X && base.ControlPoints[0].Y == base.ControlPoints[2].Y)
		{
			return;
		}
		Point point = array[0];
		Point point2 = array[1];
		Point point3 = array[2];
		ObjectPoint objectPoint = ((point.X < point2.X) ? base.ControlPoints[0] : base.ControlPoints[1]);
		int num = 30;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
		{
			num = 16;
		}
		int num14 = default(int);
		DateTime dateTime2 = default(DateTime);
		IRawCluster rawCluster = default(IRawCluster);
		int num9 = default(int);
		long num2 = default(long);
		long num15 = default(long);
		long num3 = default(long);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		int num10 = default(int);
		double num4 = default(double);
		double num12 = default(double);
		double num13 = default(double);
		ObjectPoint objectPoint2 = default(ObjectPoint);
		IChartSymbol symbol = default(IChartSymbol);
		double num7 = default(double);
		double num8 = default(double);
		double x = default(double);
		double y2 = default(double);
		double num5 = default(double);
		double y = default(double);
		List<Tuple<string, Rect>>.Enumerator enumerator = default(List<Tuple<string, Rect>>.Enumerator);
		Rect item = default(Rect);
		List<Tuple<string, Rect>> list = default(List<Tuple<string, Rect>>);
		string text = default(string);
		double num11 = default(double);
		DateTime dateTime = default(DateTime);
		double y3 = default(double);
		while (true)
		{
			int num6;
			ObjectPoint objectPoint3;
			switch (num)
			{
			case 13:
			case 20:
				num14++;
				goto case 3;
			case 8:
				dateTime2 = rawCluster.Time;
				num = 18;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 20;
				}
				continue;
			case 3:
				if (num14 <= num9 + 1)
				{
					rawCluster = (IRawCluster)iwc7qneH4LFsWFR6CjG1(base.DataProvider, num14);
					if (rawCluster == null)
					{
						goto case 13;
					}
					if (num14 <= num9)
					{
						num2 += iYrLyoeHD1TDd3WKXGvG(rawCluster);
						num15 += fjatZQeHbhfo34cC8Nrf(rawCluster);
						num3 += rawCluster.Trades;
						num = 32;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
						{
							num = 14;
						}
						continue;
					}
					goto case 32;
				}
				if (ShowInfoBars)
				{
					dictionary.Add((string)ru4VWYeHkA7n5AVoD13I(), (string)MOaUtmeH1kRr1QgTDQsw(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671171185), num9 - num10 + 1));
					num6 = 40;
					goto IL_0005;
				}
				goto case 40;
			case 34:
				num4 = num12 + num13;
				num = 12;
				continue;
			case 33:
				num9 = U87MedeHl6wXgp3jxB9u(base.Canvas, objectPoint2.X, 0);
				symbol = base.DataProvider.Symbol;
				dictionary = new Dictionary<string, string>();
				num = 24;
				continue;
			case 16:
				if (ShowInfoBars)
				{
					goto case 22;
				}
				goto case 18;
			case 5:
				if (pp22XxeHs2mF5AwSmRuA(dictionary) == 0)
				{
					return;
				}
				num7 = point3.X + 5.0;
				num8 = point3.Y + 3.0;
				num = 25;
				continue;
			case 14:
				_infoRect = new Rect(x, y2, num4 + 10.0, num5 + 10.0);
				num = 28;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
				{
					num = 36;
				}
				continue;
			case 6:
				return;
			case 4:
				y = base.ControlPoints[1].Y;
				num = 15;
				continue;
			case 9:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<string, Rect> current = enumerator.Current;
						bxY66eeHdEFu4AgAW4B6(visual, current.Item1, base.Canvas.ChartFont, TextBrush, new Rect(current.Item2.X, current.Item2.Y, current.Item2.Width, current.Item2.Height), XTextAlignment.Left);
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 35:
				num10 = base.Canvas.DateToIndex(objectPoint.X, 0);
				num = 33;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
				{
					num = 2;
				}
				continue;
			case 25:
				num12 = 0.0;
				num = 42;
				continue;
			case 11:
			{
				double height = base.Canvas.ChartFont.GetHeight();
				foreach (KeyValuePair<string, string> item3 in dictionary)
				{
					int num16 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num16 = 0;
					}
					while (true)
					{
						switch (num16)
						{
						case 1:
						{
							Rect item2 = new Rect(num7, num8 + num5 + 2.0, num12, height + 2.0);
							item = new Rect(num7 + num12, num8 + num5 + 2.0, num13, height + 2.0);
							num5 += item2.Height + 2.0;
							list.Add(new Tuple<string, Rect>(item3.Key, item2));
							num16 = 2;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
							{
								num16 = 0;
							}
							continue;
						}
						case 2:
							list.Add(new Tuple<string, Rect>(item3.Value, item));
							num16 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
							{
								num16 = 0;
							}
							continue;
						}
						break;
					}
				}
				x = point3.X;
				num = 34;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
				{
					num = 31;
				}
				continue;
			}
			case 23:
			case 37:
				text = base.Canvas.FormatValue(Math.Abs(objectPoint2.Y - objectPoint.Y));
				num = 15;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num = 16;
				}
				continue;
			case 22:
				dictionary.Add((string)ru4VWYeHkA7n5AVoD13I(), (string)MOaUtmeH1kRr1QgTDQsw(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838808648), num9 - num10 + 1));
				num = 18;
				continue;
			case 2:
				if (ShowInfoAsk)
				{
					dictionary.Add(Resources.ChartRouletteFlagsAsk, symbol.FormatRawSize(num15, 0, minimize: true) ?? "");
				}
				goto case 5;
			case 10:
				dictionary.Add(Resources.ChartRouletteFlagsChange, (string)MOaUtmeH1kRr1QgTDQsw(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--927068468 ^ 0x37418DF8), num11));
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
				{
					num = 27;
				}
				continue;
			case 18:
				if (ShowInfoPrice)
				{
					dictionary.Add(Resources.ChartRouletteFlagsRange, text ?? "");
					num = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
					{
						num = 5;
					}
					continue;
				}
				goto case 5;
			case 42:
				num13 = 0.0;
				num5 = 0.0;
				num6 = 29;
				goto IL_0005;
			case 41:
				if (ShowInfoBid)
				{
					num = 16;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
					{
						num = 21;
					}
					continue;
				}
				goto case 2;
			case 28:
				dateTime2 = DateTime.MinValue;
				num14 = num10;
				num = 3;
				continue;
			case 26:
				dateTime = DateTime.MaxValue;
				num = 28;
				continue;
			case 24:
				if (!base.Canvas.IsStock)
				{
					num = 37;
					continue;
				}
				goto case 19;
			case 7:
				if (ShowInfoPrice)
				{
					num = 31;
					continue;
				}
				goto IL_0355;
			case 15:
				if (!(y3 > 0.0) || !(y > 0.0))
				{
					num11 = 0.0;
					num = 10;
					continue;
				}
				num11 = y / y3 - 1.0;
				goto case 10;
			case 17:
				dictionary.Add(Resources.ChartRouletteFlagsTicks, string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6EC99CAF ^ 0x6EC91D0F), Math.Abs(objectPoint2.Y - objectPoint.Y) / base.DataProvider.Step));
				goto IL_0879;
			case 38:
				objectPoint3 = base.ControlPoints[0];
				goto IL_0c4f;
			case 19:
				num2 = 0L;
				num15 = 0L;
				num = 39;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 16;
				}
				continue;
			case 32:
				if (rawCluster.Time < dateTime)
				{
					dateTime = rawCluster.Time;
				}
				if (!(hfLhOheHNxiNfaUdOg3e(rawCluster) > dateTime2))
				{
					num6 = 13;
					goto IL_0005;
				}
				goto case 8;
			case 27:
				if (ShowInfoVolume)
				{
					dictionary.Add(Resources.ChartRouletteFlagsVolume, symbol.FormatRawSize(num15 + num2, 0, minimize: true) ?? "");
				}
				if (ShowInfoTrades)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
					{
						num = 1;
					}
					continue;
				}
				goto IL_0152;
			case 36:
				nC1WyweHE3G7IFB5VNl1(visual, ((IChartTheme)bUgMnMeHjxjyGscO0AJ4(base.Canvas)).ChartBackBrush, _infoRect);
				HR3dOQeHQ2ldOA8xspiR(visual, base.LinePen, _infoRect);
				enumerator = list.GetEnumerator();
				num = 9;
				continue;
			case 12:
				y2 = point3.Y;
				num = 14;
				continue;
			case 40:
				if (ShowInfoTime)
				{
					string text2 = PrettyFormatTimeSpan(dateTime2 - dateTime);
					dictionary.Add(Resources.ChartRouletteFlagsTime, text2 ?? "");
					num = 7;
					continue;
				}
				goto case 7;
			case 39:
				num3 = 0L;
				num = 26;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
				{
					num = 14;
				}
				continue;
			case 30:
				if (!(point.X < point2.X))
				{
					num = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 != 0)
					{
						num = 38;
					}
					continue;
				}
				objectPoint3 = base.ControlPoints[1];
				goto IL_0c4f;
			case 29:
				list = new List<Tuple<string, Rect>>();
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
				{
					num = 0;
				}
				continue;
			case 31:
				dictionary.Add(Resources.ChartRouletteFlagsPrice, symbol.FormatPrice(UyqRhreHSNtpPqYWgQ4b(Gyg9aWeH5iydAIopfdjs(objectPoint2.Y - objectPoint.Y))) ?? "");
				goto IL_0355;
			case 1:
				dictionary.Add((string)XZP0GceHxXifwRHMgYmA(), symbol.FormatTrades(num3, 0, minimize: true) ?? "");
				goto IL_0152;
			case 21:
				{
					dictionary.Add(Resources.ChartRouletteFlagsBid, (string)(edENXaeHePkkryjoJgOZ(symbol, num2, 0, true) ?? ""));
					num = 2;
					continue;
				}
				IL_0355:
				if (ShowInfoTicks)
				{
					num = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
					{
						num = 3;
					}
					continue;
				}
				goto IL_0879;
				IL_0879:
				if (ShowInfoChange)
				{
					y3 = base.ControlPoints[0].Y;
					num = 4;
					continue;
				}
				goto case 27;
				IL_0c4f:
				objectPoint2 = objectPoint3;
				num = 35;
				continue;
				IL_0005:
				num = num6;
				continue;
				IL_0152:
				if (!ShowInfoDelta)
				{
					goto case 41;
				}
				dictionary.Add((string)NbNY53eHL7vh1IlyjuSq(), symbol.FormatRawSize(num15 - num2, 0, minimize: true) ?? "");
				num = 32;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
				{
					num = 41;
				}
				continue;
			}
			foreach (KeyValuePair<string, string> item4 in dictionary)
			{
				Size size = NnLmIKeHXb0tSQ0LKKqL(base.Canvas.ChartFont, item4.Key);
				Size size2 = ((XFont)I5o8FGeHcptfbVPJYDjk(base.Canvas)).GetSize(item4.Value);
				int num17 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
				{
					num17 = 0;
				}
				while (true)
				{
					switch (num17)
					{
					case 1:
						num13 = Math.Max(num13, size2.Width);
						num17 = 2;
						continue;
					case 2:
						break;
					default:
						num12 = Math.Max(num12, size.Width);
						num17 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
						{
							num17 = 1;
						}
						continue;
					}
					break;
				}
			}
			num12 += 10.0;
			num = 11;
		}
	}

	public string PrettyFormatTimeSpan(TimeSpan span)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num;
		if (span.Days <= 0)
		{
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
			{
				num = 3;
			}
			goto IL_0009;
		}
		goto IL_0023;
		IL_0023:
		Yd3wTDeHgW50TXpwWEw7(stringBuilder, MOaUtmeH1kRr1QgTDQsw(WsVoSqeHinlw6dh9egue(0x50C1C840 ^ 0x50C149F0), span.Days));
		goto IL_0057;
		IL_0057:
		if (span.Hours > 0)
		{
			stringBuilder.Append(string.Format((string)WsVoSqeHinlw6dh9egue(0x9F0F634 ^ 0x9F0778A), span.Hours));
		}
		if (span.Minutes > 0)
		{
			Yd3wTDeHgW50TXpwWEw7(stringBuilder, string.Format((string)WsVoSqeHinlw6dh9egue(-1878953018 ^ -1878920694), span.Minutes));
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0088;
		IL_0009:
		switch (num)
		{
		case 2:
			break;
		case 3:
			goto IL_0057;
		case 1:
			return stringBuilder.ToString();
		default:
			goto IL_0088;
		}
		goto IL_0023;
		IL_0088:
		if (CuYO9WeHRBZK6PNK4Jyk(stringBuilder.ToString()))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x739453AA);
		}
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	protected override bool InObject(int x, int y)
	{
		Point[] array = ToPoints(base.ControlPoints);
		int num = 0;
		int num2 = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
		{
			num2 = 0;
		}
		Rect infoRect = default(Rect);
		while (true)
		{
			switch (num2)
			{
			default:
				return infoRect.Contains(x, y);
			case 1:
			case 2:
				if (num >= array.Length - 1)
				{
					if (!(_infoRect != Rect.Empty))
					{
						return false;
					}
					infoRect = _infoRect;
					infoRect.Inflate(base.LineWidth + 2, base.LineWidth + 2);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
			{
				if (XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(x, y, array[num], array[num + 1], base.LineWidth + 2))
				{
					return true;
				}
				num++;
				int num3 = 2;
				num2 = num3;
				break;
			}
			}
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		TextColor = theme.ChartFontColor;
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 4;
		RulerObject rulerObject = default(RulerObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (rulerObject != null)
					{
						ShowInfoBars = rulerObject.ShowInfoBars;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_0044;
				case 1:
					ShowInfoTime = rulerObject.ShowInfoTime;
					ShowInfoPrice = V9YUGFeH6lbvFKCfnnhq(rulerObject);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					ShowInfoChange = rulerObject.ShowInfoChange;
					num2 = 2;
					continue;
				default:
					ShowInfoBid = sWw8h7eHO80rgdPLZGOT(rulerObject);
					ShowInfoAsk = rulerObject.ShowInfoAsk;
					TextColor = rulerObject.TextColor;
					goto IL_0044;
				case 4:
					rulerObject = objectBase as RulerObject;
					num2 = 3;
					continue;
				case 5:
					break;
				case 2:
					{
						ShowInfoTicks = vYW0D1eHMvdXK22ZP3KV(rulerObject);
						ShowInfoVolume = rulerObject.ShowInfoVolume;
						ShowInfoDelta = rulerObject.ShowInfoDelta;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_0044:
					base.CopyTemplate(objectBase, style);
					return;
				}
				break;
			}
			ShowInfoTicks = rulerObject.ShowInfoTicks;
			num = 6;
		}
	}

	static RulerObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object WsVoSqeHinlw6dh9egue(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool PSZtM0eHBpnHXAKUjddt()
	{
		return xIqHhceHvBuBjhVTDplh == null;
	}

	internal static RulerObject O9VrSveHaDNtuU9Eqwk4()
	{
		return xIqHhceHvBuBjhVTDplh;
	}

	internal static int U87MedeHl6wXgp3jxB9u(object P_0, double dt, int dir)
	{
		return ((IChartCanvas)P_0).DateToIndex(dt, dir);
	}

	internal static object iwc7qneH4LFsWFR6CjG1(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetRawCluster(i);
	}

	internal static long iYrLyoeHD1TDd3WKXGvG(object P_0)
	{
		return ((IRawCluster)P_0).Bid;
	}

	internal static long fjatZQeHbhfo34cC8Nrf(object P_0)
	{
		return ((IRawCluster)P_0).Ask;
	}

	internal static DateTime hfLhOheHNxiNfaUdOg3e(object P_0)
	{
		return ((IRawCluster)P_0).Time;
	}

	internal static object ru4VWYeHkA7n5AVoD13I()
	{
		return Resources.ChartRouletteFlagsBars;
	}

	internal static object MOaUtmeH1kRr1QgTDQsw(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static double Gyg9aWeH5iydAIopfdjs(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static decimal UyqRhreHSNtpPqYWgQ4b(double P_0)
	{
		return (decimal)P_0;
	}

	internal static object XZP0GceHxXifwRHMgYmA()
	{
		return Resources.ChartRouletteFlagsTrades;
	}

	internal static object NbNY53eHL7vh1IlyjuSq()
	{
		return Resources.ChartRouletteFlagsDelta;
	}

	internal static object edENXaeHePkkryjoJgOZ(object P_0, long size, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatRawSize(size, round, minimize);
	}

	internal static int pp22XxeHs2mF5AwSmRuA(object P_0)
	{
		return ((Dictionary<string, string>)P_0).Count;
	}

	internal static Size NnLmIKeHXb0tSQ0LKKqL(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static object I5o8FGeHcptfbVPJYDjk(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static object bUgMnMeHjxjyGscO0AJ4(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static void nC1WyweHE3G7IFB5VNl1(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void HR3dOQeHQ2ldOA8xspiR(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).DrawRectangle((XPen)P_1, P_2);
	}

	internal static void bxY66eeHdEFu4AgAW4B6(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static object Yd3wTDeHgW50TXpwWEw7(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static bool CuYO9WeHRBZK6PNK4Jyk(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool V9YUGFeH6lbvFKCfnnhq(object P_0)
	{
		return ((RulerObject)P_0).ShowInfoPrice;
	}

	internal static bool vYW0D1eHMvdXK22ZP3KV(object P_0)
	{
		return ((RulerObject)P_0).ShowInfoTicks;
	}

	internal static bool sWw8h7eHO80rgdPLZGOT(object P_0)
	{
		return ((RulerObject)P_0).ShowInfoBid;
	}
}
