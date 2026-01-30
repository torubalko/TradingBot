using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
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
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("FibonacciExtensions", "ChartObjectsFibonacciExtensions", 3, Type = typeof(FibonacciExtensionsObject))]
[DataContract(Name = "FibonacciExtensionsObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class FibonacciExtensionsObject : LineObjectBase
{
	private bool _openStart;

	private bool _openEnd;

	private XColor _levelsLineColor;

	private int _levelsLineWidth;

	private XDashStyle _lineStyle;

	private int _levelsWidth;

	private ObjectTextAlignment _textAlignment;

	private bool _customLevels;

	private List<ObjectLine> _lines;

	private Point[] _startPoints;

	private Point[] _endPoints;

	private double[] _split;

	internal static FibonacciExtensionsObject PscPjyLz6AQTbq3DXPUw;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "OpenStart")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandLeft")]
	public bool OpenStart
	{
		get
		{
			return _openStart;
		}
		set
		{
			if (value != _openStart)
			{
				_openStart = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-520155535 ^ -520129073));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandRight")]
	[DataMember(Name = "OpenEnd")]
	public bool OpenEnd
	{
		get
		{
			return _openEnd;
		}
		set
		{
			if (value != _openEnd)
			{
				_openEnd = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1962651919 ^ -1962658523));
			}
		}
	}

	[Browsable(false)]
	private XBrush LevelsLineBrush { get; set; }

	[Browsable(false)]
	private XPen LevelsLinePen { get; set; }

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	[DataMember(Name = "LevelsLineColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineColor")]
	public XColor LevelsLineColor
	{
		get
		{
			return _levelsLineColor;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (ucv38yLzqwrsNLAuW3Zc(value, _levelsLineColor))
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
						{
							num2 = 1;
						}
						break;
					}
					_levelsLineColor = value;
					LevelsLineBrush = new XBrush(_levelsLineColor);
					LevelsLinePen = new XPen(LevelsLineBrush, LevelsLineWidth, base.LineStyle);
					OnPropertyChanged((string)dc2eSALzI8TPUlR4N1Us(0x1D7BA1ED ^ 0x1D7BDA0B));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	[DataMember(Name = "LevelsLineWidth")]
	public int LevelsLineWidth
	{
		get
		{
			return _levelsLineWidth;
		}
		set
		{
			value = Math.Max(1, Math.Min(10, value));
			int num;
			if (value != _levelsLineWidth)
			{
				_levelsLineWidth = value;
				LevelsLinePen = new XPen(LevelsLineBrush, _levelsLineWidth, base.LineStyle);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x32DEA4F1 ^ 0x32DED8F9));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
				{
					num = 1;
				}
			}
			else
			{
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 != 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
	}

	[DataMember(Name = "LevelsLineStyle")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineStyle")]
	public XDashStyle LevelsLineStyle
	{
		get
		{
			return _lineStyle;
		}
		set
		{
			if (value != _lineStyle)
			{
				_lineStyle = value;
				LevelsLinePen = new XPen(LevelsLineBrush, LevelsLineWidth, _lineStyle);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)dc2eSALzI8TPUlR4N1Us(-602153869 ^ -602169255));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLevelsWidth")]
	[DataMember(Name = "LevelsWidth")]
	public int LevelsWidth
	{
		get
		{
			return _levelsWidth;
		}
		set
		{
			value = Math.Max(20, vHYFjTLzWYEYFvbyRm1u(500, value));
			if (value != _levelsWidth)
			{
				_levelsWidth = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338774662));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsText")]
	[DataMember(Name = "TextAlignment")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLevels")]
	public ObjectTextAlignment TextAlignment
	{
		get
		{
			return _textAlignment;
		}
		set
		{
			if (value != _textAlignment)
			{
				_textAlignment = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1416954587));
			}
		}
	}

	[DataMember(Name = "CustomLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsEnable")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsCustomLevels")]
	public bool CustomLevels
	{
		get
		{
			return _customLevels;
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
					if (value == _customLevels)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_customLevels = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878978750));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLevels")]
	[DataMember(Name = "Levels")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsCustomLevels")]
	public List<ObjectLine> Levels
	{
		get
		{
			return _lines ?? (_lines = new List<ObjectLine>());
		}
		set
		{
			if (!object.Equals(value, _lines))
			{
				_lines = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1416954397));
			}
		}
	}

	public FibonacciExtensionsObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		OpenStart = false;
		OpenEnd = false;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Levels = new List<ObjectLine>
				{
					new ObjectLine(0.0, CgoCq8Lzt3hZKZX2ohD3()),
					new ObjectLine(23.6, Colors.Black),
					new ObjectLine(38.2, Colors.Black),
					new ObjectLine(50.0, Colors.Black),
					new ObjectLine(61.8, Colors.Black),
					new ObjectLine(78.6, Colors.Black),
					new ObjectLine(100.0, CgoCq8Lzt3hZKZX2ohD3()),
					new ObjectLine(161.8, Colors.Black),
					new ObjectLine(261.8, WxPLR7LzU26I8LInSAcv(CgoCq8Lzt3hZKZX2ohD3())),
					new ObjectLine(361.8, Colors.Black),
					new ObjectLine(423.6, Colors.Black)
				};
				return;
			case 3:
				LevelsLineWidth = 1;
				LevelsLineStyle = XDashStyle.Solid;
				LevelsWidth = 200;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
				{
					num = 0;
				}
				break;
			case 2:
				LevelsLineColor = Colors.Black;
				num = 3;
				break;
			case 1:
				TextAlignment = ObjectTextAlignment.LeftBottom;
				CustomLevels = false;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		CalcPoint();
		if (_startPoints == null)
		{
			return;
		}
		int num = 3;
		int num2 = default(int);
		ObjectLine objectLine = default(ObjectLine);
		while (true)
		{
			switch (num)
			{
			case 5:
				num2++;
				num = 7;
				break;
			case 3:
			{
				if (_endPoints == null)
				{
					num = 4;
					break;
				}
				Point[] points = ToPoints(base.ControlPoints);
				visual.DrawLines(base.LinePen, points);
				if (InSetup)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
					{
						num = 1;
					}
					break;
				}
				goto IL_0107;
			}
			case 2:
				visual.DrawString(GetStr(num2), (XFont)b3PM4OLzyksXrN86CIXF(base.Canvas), LevelsLineBrush, GetRect(num2, base.LineWidth));
				goto case 5;
			case 1:
				if (base.ControlPoints[0].X == base.ControlPoints[2].X && base.ControlPoints[0].Y == base.ControlPoints[2].Y)
				{
					return;
				}
				goto IL_0107;
			default:
				if (EYxXxoLzTXsfjq5qrc2Q(objectLine))
				{
					visual.DrawLine(objectLine.LinePen, _startPoints[num2], _endPoints[num2]);
					if (TextAlignment != ObjectTextAlignment.Hide)
					{
						CdJoqYLzV1xKN85gKmSm(visual, GetStr(num2), b3PM4OLzyksXrN86CIXF(base.Canvas), EfV4mFLzZZwyeQbhQoE9(objectLine), GetRect(num2, objectLine.LineWidth), XTextAlignment.Left);
						num = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
						{
							num = 5;
						}
						break;
					}
				}
				goto case 5;
			case 4:
				return;
			case 8:
				EfHGrxLzCUcs1T33p6mu(visual, LevelsLinePen, _startPoints[num2], _endPoints[num2]);
				if (TextAlignment != ObjectTextAlignment.Hide)
				{
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 5;
			case 7:
			case 9:
				if (num2 >= _startPoints.Length)
				{
					return;
				}
				goto case 6;
			case 6:
				{
					if (CustomLevels)
					{
						objectLine = Levels[num2];
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
						{
							num = 0;
						}
						break;
					}
					goto case 8;
				}
				IL_0107:
				num2 = 0;
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private string GetStr(int i)
	{
		string arg = ((IChartSymbol)K9R7rELzrhLBpYK28daF(base.DataProvider)).FormatPrice((decimal)GetPrice(i), shortDecimals: true);
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x385831B), _split[i], arg);
	}

	private Rect GetRect(int i, int lineWidth)
	{
		Size size = xYFNAeLzKVYttkNSSgKd(b3PM4OLzyksXrN86CIXF(base.Canvas), GetStr(i));
		double x = 0.0;
		double y = 0.0;
		double width = size.Width;
		int num = 7;
		ObjectTextAlignment textAlignment = default(ObjectTextAlignment);
		while (true)
		{
			switch (num)
			{
			default:
				return new Rect(x, y, width, size.Height);
			case 1:
				y = _startPoints[i].Y + 4.0 + Math.Ceiling((double)lineWidth / 2.0);
				goto IL_0132;
			case 4:
				goto IL_0132;
			case 7:
				textAlignment = TextAlignment;
				switch (textAlignment)
				{
				case ObjectTextAlignment.LeftBottom:
				case ObjectTextAlignment.CenterBottom:
				case ObjectTextAlignment.RightBottom:
					break;
				default:
					goto IL_0132;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.RightTop:
					goto end_IL_0009;
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.RightMiddle:
					y = _startPoints[i].Y - 4.0 - ih8fNlLzmBQ6LMfddIMw((double)lineWidth / 2.0);
					goto IL_0132;
				}
				goto case 1;
			case 2:
				break;
			case 6:
				{
					switch (textAlignment)
					{
					case ObjectTextAlignment.LeftTop:
					case ObjectTextAlignment.LeftMiddle:
					case ObjectTextAlignment.LeftBottom:
						x = LegUcRLzhMUmV3ZN0ifF(_startPoints[i].X, _endPoints[i].X) + 4.0;
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
						{
							num = 0;
						}
						continue;
					case ObjectTextAlignment.RightTop:
					case ObjectTextAlignment.RightMiddle:
					case ObjectTextAlignment.RightBottom:
						x = D9yYW8LzwEIcXPIrbauI(_startPoints[i].X, _endPoints[i].X) - width - 4.0;
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
						{
							num = 5;
						}
						continue;
					default:
						num = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
						{
							num = 0;
						}
						continue;
					case ObjectTextAlignment.CenterTop:
					case ObjectTextAlignment.CenterMiddle:
					case ObjectTextAlignment.CenterBottom:
						break;
					}
					x = (_startPoints[i].X + _endPoints[i].X - width) / 2.0;
					goto default;
				}
				IL_0132:
				textAlignment = TextAlignment;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 6;
				}
				continue;
				end_IL_0009:
				break;
			}
			y = _startPoints[i].Y - 4.0 - Math.Ceiling((double)lineWidth / 2.0) - size.Height;
			num = 4;
		}
	}

	private void CalcPoint()
	{
		int num = 4;
		ObjectPoint op = default(ObjectPoint);
		int num4 = default(int);
		Point point = default(Point);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					Point point2 = ToPoint(op);
					_startPoints[num4] = new Point(point.X, point2.Y);
					_endPoints[num4] = new Point(point.X + (double)LevelsWidth, point2.Y);
					num4++;
					goto IL_0388;
				}
				case 7:
					num5++;
					num2 = 12;
					continue;
				case 3:
					_split = new double[11]
					{
						0.0, 0.236, 0.382, 0.5, 0.618, 0.786, 1.0, 1.618, 2.618, 3.618,
						4.236
					};
					goto IL_020b;
				case 15:
					if (OpenEnd)
					{
						_endPoints[num3].X = base.Canvas.Rect.Right;
					}
					goto IL_0164;
				case 4:
					if (CustomLevels)
					{
						_split = new double[Levels.Count];
						num5 = 0;
						num2 = 11;
					}
					else
					{
						num2 = 3;
					}
					continue;
				case 5:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					if (OpenStart)
					{
						_endPoints[num3].X = 0.0;
					}
					if (OpenEnd)
					{
						_startPoints[num3].X = base.Canvas.Rect.Right;
					}
					goto IL_0164;
				case 2:
					if (num3 >= _startPoints.Length)
					{
						num2 = 10;
						continue;
					}
					goto case 13;
				case 16:
					_startPoints = new Point[_split.Length];
					_endPoints = new Point[_split.Length];
					op = new ObjectPoint(base.ControlPoints[2].X, 0.0);
					num2 = 14;
					continue;
				default:
					_split[num5] = Levels[num5].Value / 100.0;
					num = 7;
					break;
				case 13:
					if (_startPoints[num3].X <= _endPoints[num3].X)
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 9:
					_startPoints[num3].X = 0.0;
					num = 15;
					break;
				case 11:
				case 12:
					if (num5 >= Ev4vQsLz7bY0qGTAinWE(Levels))
					{
						goto IL_020b;
					}
					goto default;
				case 14:
					num4 = 0;
					goto IL_0388;
				case 6:
					if (OpenStart)
					{
						num2 = 9;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 15;
				case 10:
					return;
					IL_020b:
					point = ToPoint(base.ControlPoints[2]);
					num2 = 16;
					continue;
					IL_0388:
					if (num4 < _split.Length)
					{
						op.Y = GetPrice(num4);
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 5;
					}
					continue;
					IL_0164:
					num3++;
					goto case 2;
				}
				break;
			}
		}
	}

	private double GetPrice(int lineIndex)
	{
		return (base.ControlPoints[1].Y - base.ControlPoints[0].Y) * _split[lineIndex] + base.ControlPoints[2].Y;
	}

	protected override bool InObject(int x, int y)
	{
		int num = 6;
		int num2 = num;
		int num3 = default(int);
		Point[] array = default(Point[]);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				if (_startPoints != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 8;
			case 1:
				if (num3 < _startPoints.Length)
				{
					if (hRICGELz89WZ8HVNqy16(_startPoints[num3], default(Point)))
					{
						goto case 4;
					}
					if (CustomLevels)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				}
				array = ToPoints(base.ControlPoints);
				num4 = 0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				return false;
			case 5:
				if (_endPoints != null)
				{
					if (_startPoints.Length != Ev4vQsLz7bY0qGTAinWE(Levels))
					{
						return false;
					}
					num3 = 0;
					goto case 1;
				}
				num2 = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
				{
					num2 = 8;
				}
				continue;
			case 3:
				if (weQBAqLzPwYafYfcV1rJ(x, y, _startPoints[num3], _endPoints[num3], Aq78w3LzAPEngZFWWe4L(this) + 2))
				{
					return true;
				}
				goto case 4;
			case 2:
				if (!EYxXxoLzTXsfjq5qrc2Q(Levels[num3]))
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			case 7:
				return true;
			}
			while (true)
			{
				if (num4 < array.Length - 1)
				{
					if (XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(x, y, array[num4], array[num4 + 1], base.LineWidth + 2))
					{
						break;
					}
					num4++;
					continue;
				}
				return false;
			}
			num2 = 7;
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		LevelsLineColor = w9mjQMLzJhnDcr6qFq3D(theme);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				base.LineColor = w9mjQMLzJhnDcr6qFq3D(theme);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num = 0;
				}
				break;
			case 1:
			{
				foreach (ObjectLine level in Levels)
				{
					g9d2r2LzF8rFF8um6OdP(level, theme.ChartObjectLineColor);
					int num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
				return;
			}
			}
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		FibonacciExtensionsObject fibonacciExtensionsObject = objectBase as FibonacciExtensionsObject;
		int num;
		if (fibonacciExtensionsObject != null)
		{
			OpenStart = fibonacciExtensionsObject.OpenStart;
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0134;
		IL_0009:
		List<ObjectLine>.Enumerator enumerator = default(List<ObjectLine>.Enumerator);
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 4:
				try
				{
					while (enumerator.MoveNext())
					{
						ObjectLine current = enumerator.Current;
						Levels.Add(new ObjectLine(current));
						int num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
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
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				break;
			case 2:
				OpenEnd = xrsUbQLz32Xe8V55reuX(fibonacciExtensionsObject);
				LevelsLineColor = fibonacciExtensionsObject.LevelsLineColor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				TextAlignment = fibonacciExtensionsObject.TextAlignment;
				CustomLevels = fibonacciExtensionsObject.CustomLevels;
				Levels = new List<ObjectLine>();
				enumerator = fibonacciExtensionsObject.Levels.GetEnumerator();
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num = 4;
				}
				continue;
			default:
				LevelsLineStyle = fibonacciExtensionsObject.LevelsLineStyle;
				LevelsLineWidth = fibonacciExtensionsObject.LevelsLineWidth;
				LevelsWidth = fibonacciExtensionsObject.LevelsWidth;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
				{
					num = 3;
				}
				continue;
			case 5:
				break;
			}
			break;
		}
		OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838846792));
		goto IL_0134;
		IL_0134:
		base.CopyTemplate(objectBase, style);
		num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	static FibonacciExtensionsObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool hgpxEELzMLNUO654YYWm()
	{
		return PscPjyLz6AQTbq3DXPUw == null;
	}

	internal static FibonacciExtensionsObject bci8YMLzO0meAbXnhoaf()
	{
		return PscPjyLz6AQTbq3DXPUw;
	}

	internal static bool ucv38yLzqwrsNLAuW3Zc(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static object dc2eSALzI8TPUlR4N1Us(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static int vHYFjTLzWYEYFvbyRm1u(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static Color CgoCq8Lzt3hZKZX2ohD3()
	{
		return Colors.Black;
	}

	internal static XColor WxPLR7LzU26I8LInSAcv(Color P_0)
	{
		return P_0;
	}

	internal static bool EYxXxoLzTXsfjq5qrc2Q(object P_0)
	{
		return ((ObjectLine)P_0).ShowLine;
	}

	internal static object b3PM4OLzyksXrN86CIXF(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static object EfV4mFLzZZwyeQbhQoE9(object P_0)
	{
		return ((ObjectLine)P_0).LineBrush;
	}

	internal static void CdJoqYLzV1xKN85gKmSm(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static void EfHGrxLzCUcs1T33p6mu(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static object K9R7rELzrhLBpYK28daF(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static Size xYFNAeLzKVYttkNSSgKd(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static double ih8fNlLzmBQ6LMfddIMw(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static double LegUcRLzhMUmV3ZN0ifF(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double D9yYW8LzwEIcXPIrbauI(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static int Ev4vQsLz7bY0qGTAinWE(object P_0)
	{
		return ((List<ObjectLine>)P_0).Count;
	}

	internal static bool hRICGELz89WZ8HVNqy16(Point P_0, Point P_1)
	{
		return P_0 == P_1;
	}

	internal static int Aq78w3LzAPEngZFWWe4L(object P_0)
	{
		return ((ObjectBase)P_0).PenWidth;
	}

	internal static bool weQBAqLzPwYafYfcV1rJ(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		return XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(P_0, P_1, P_2, P_3, P_4);
	}

	internal static XColor w9mjQMLzJhnDcr6qFq3D(object P_0)
	{
		return ((IChartTheme)P_0).ChartObjectLineColor;
	}

	internal static void g9d2r2LzF8rFF8um6OdP(object P_0, XColor value)
	{
		((ObjectLine)P_0).LineColor = value;
	}

	internal static bool xrsUbQLz32Xe8V55reuX(object P_0)
	{
		return ((FibonacciExtensionsObject)P_0).OpenEnd;
	}
}
