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
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "FibonacciTimeZonesObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("FibonacciTimeZones", "ChartObjectsFibonacciTimeZones", 2, Type = typeof(FibonacciTimeZonesObject))]
public sealed class FibonacciTimeZonesObject : LineObjectBase
{
	private static readonly double[] _defaultFibonacci;

	private Point[] _startPoints;

	private Point[] _endPoints;

	private double[] _split;

	private bool _openStart;

	private bool _openEnd;

	private ObjectTextAlignment _textAlignment;

	private bool _customLevels;

	private List<ObjectLine> _lines;

	private static FibonacciTimeZonesObject PHMw6re0cBmbPtnH5crv;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	[DataMember(Name = "OpenStart")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandTop")]
	public bool OpenStart
	{
		get
		{
			return _openStart;
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
					if (value == _openStart)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_openStart = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D314BF6));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "OpenEnd")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandBottom")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)rXncWIe0QaALpj4BUk1c(0x7D553BE0 ^ 0x7D554034));
			}
		}
	}

	[DataMember(Name = "TextAlignment")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlignment")]
	public ObjectTextAlignment TextAlignment
	{
		get
		{
			return _textAlignment;
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
					if (value != _textAlignment)
					{
						_textAlignment = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-527080372 ^ -527099862));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsEnable")]
	[DataMember(Name = "CustomLevels")]
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
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_customLevels = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB8A15));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsCustomLevels")]
	[DataMember(Name = "Levels")]
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x385830B));
			}
		}
	}

	public FibonacciTimeZonesObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		OpenStart = false;
		OpenEnd = false;
		int num = 4;
		double[] defaultFibonacci = default(double[]);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				double num3 = defaultFibonacci[num2];
				Levels.Add(new ObjectLine(num3 * 100.0, BHQqq3e0dYdEc2VvuTrM()));
				num2++;
				num = 3;
				break;
			}
			case 4:
				TextAlignment = ObjectTextAlignment.LeftBottom;
				CustomLevels = false;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				Levels = new List<ObjectLine>(_defaultFibonacci.Length);
				defaultFibonacci = _defaultFibonacci;
				num = 5;
				break;
			case 5:
				num2 = 0;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
				{
					num = 0;
				}
				break;
			case 1:
			case 3:
				if (num2 >= defaultFibonacci.Length)
				{
					return;
				}
				goto default;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 10;
		int num3 = default(int);
		ObjectLine objectLine = default(ObjectLine);
		Point point2 = default(Point);
		Point point = default(Point);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (CustomLevels)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				case 9:
					if (_startPoints == null || _endPoints == null)
					{
						return;
					}
					goto end_IL_0012;
				default:
					num3 = 0;
					goto IL_0214;
				case 3:
					objectLine = Levels[num3];
					if (objectLine.ShowLine)
					{
						visual.DrawLine(objectLine.LinePen, _startPoints[num3], _endPoints[num3]);
						if (TextAlignment != ObjectTextAlignment.Hide)
						{
							num2 = 8;
							break;
						}
					}
					goto IL_00bb;
				case 5:
					xNueT3e06g6mRswiqV5F(visual, base.LinePen, _startPoints[num3], _endPoints[num3]);
					num2 = 6;
					break;
				case 8:
					visual.DrawString(GetStr(num3), base.Canvas.ChartFont, objectLine.LineBrush, GetRect(num3, v4xwTPe0RfIJvkcAiHon(objectLine)));
					goto IL_00bb;
				case 2:
					point2 = ToPoint(base.ControlPoints[0]);
					if (InMove && i4Cga9e0gSOl89oPRojQ(point, default(Point)) && point2 != default(Point))
					{
						num2 = 7;
						break;
					}
					goto default;
				case 1:
					F1aI0Oe0ONA9MjlOhNjC(visual, GetStr(num3), Nb3QFre0MGXN8Uk9To89(base.Canvas), base.LineBrush, GetRect(num3, base.LineWidth), XTextAlignment.Left);
					goto IL_00bb;
				case 6:
					if (TextAlignment != ObjectTextAlignment.Hide)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00bb;
				case 10:
					CalcPoint();
					num2 = 9;
					break;
				case 7:
					{
						visual.DrawLine(base.LinePen, point.X, point.Y, point2.X, point2.Y);
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
						{
							num2 = 0;
						}
						break;
					}
					IL_00bb:
					num3++;
					goto IL_0214;
					IL_0214:
					if (num3 >= _startPoints.Length)
					{
						return;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			point = ToPoint(base.ControlPoints[1]);
			num = 2;
		}
	}

	private string GetStr(int i)
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176549265), _split[i]);
	}

	private Rect GetRect(int i, int lineWidth)
	{
		Size size = base.Canvas.ChartFont.GetSize(GetStr(i));
		double x = 0.0;
		double y = 0.0;
		int num = 6;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
		{
			num = 3;
		}
		double width = default(double);
		ObjectTextAlignment textAlignment = default(ObjectTextAlignment);
		while (true)
		{
			switch (num)
			{
			case 6:
				width = size.Width;
				num = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				return new Rect(x, y, width, size.Height);
			case 1:
			case 3:
				textAlignment = TextAlignment;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
				{
					num = 0;
				}
				break;
			case 2:
				goto IL_0247;
			case 5:
				goto IL_0285;
			default:
				switch (textAlignment)
				{
				case ObjectTextAlignment.RightTop:
				case ObjectTextAlignment.RightMiddle:
				case ObjectTextAlignment.RightBottom:
					x = Math.Min(_startPoints[i].X, _endPoints[i].X) + 4.0;
					break;
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.CenterBottom:
					x = (_startPoints[i].X + _endPoints[i].X - width) / 2.0;
					break;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.LeftBottom:
					x = Math.Max(_startPoints[i].X, _endPoints[i].X) - width - 4.0;
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
					{
						num = 4;
					}
					goto end_IL_0009;
				}
				goto case 4;
			case 7:
				{
					textAlignment = TextAlignment;
					switch (textAlignment)
					{
					case ObjectTextAlignment.LeftMiddle:
					case ObjectTextAlignment.CenterMiddle:
					case ObjectTextAlignment.RightMiddle:
						break;
					default:
						goto IL_01dd;
					case ObjectTextAlignment.LeftBottom:
					case ObjectTextAlignment.CenterBottom:
					case ObjectTextAlignment.RightBottom:
						goto IL_0247;
					case ObjectTextAlignment.LeftTop:
					case ObjectTextAlignment.CenterTop:
					case ObjectTextAlignment.RightTop:
						goto IL_0285;
					}
					y = _startPoints[i].Y + (_endPoints[i].Y - _startPoints[i].Y) / 2.0 - 4.0 - KTQxuqe0qepk9Zbrtaj8(size.Height / 2.0);
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num = 1;
					}
					break;
				}
				IL_01dd:
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 1;
				}
				break;
				IL_0285:
				y = _startPoints[i].Y - 4.0 - Math.Ceiling((double)lineWidth / 2.0) - size.Height;
				goto case 1;
				IL_0247:
				y = _endPoints[i].Y + 4.0 + Math.Ceiling((double)lineWidth / 2.0);
				goto case 1;
				end_IL_0009:
				break;
			}
		}
	}

	private void CalcPoint()
	{
		int num = 7;
		int num2 = num;
		int num4 = default(int);
		int num3 = default(int);
		ObjectPoint op = default(ObjectPoint);
		int num5 = default(int);
		Point point = default(Point);
		Point point2 = default(Point);
		Point point3 = default(Point);
		while (true)
		{
			switch (num2)
			{
			case 10:
				_split = _defaultFibonacci;
				goto IL_0379;
			case 1:
				num4++;
				goto IL_0428;
			case 5:
				if (OpenEnd)
				{
					_endPoints[num3].Y = HhYdare0WVuGT0FBHK97(base.Canvas).Right;
				}
				goto IL_0060;
			case 14:
				_startPoints[num3].Y = HhYdare0WVuGT0FBHK97(base.Canvas).Right;
				goto IL_0060;
			case 16:
				op.X = GetTime(num4);
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num2 = 3;
				}
				break;
			case 12:
				num3 = 0;
				goto IL_026e;
			case 6:
				_split = new double[qtlOOZe0IguWZB4JyZ2Z(Levels)];
				num5 = 0;
				goto case 2;
			case 9:
				if (_startPoints[num3].Y <= _endPoints[num3].Y)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 3;
			case 15:
				op = new ObjectPoint(base.ControlPoints[1].X, base.ControlPoints[1].Y);
				num4 = 0;
				goto IL_0428;
			case 13:
				_startPoints[num4] = new Point(point.X, point2.Y);
				_endPoints[num4] = new Point(point.X, point3.Y);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (OpenStart)
				{
					_endPoints[num3].Y = 0.0;
				}
				if (!OpenEnd)
				{
					goto IL_0060;
				}
				goto case 14;
			case 7:
				if (CustomLevels)
				{
					num2 = 6;
					break;
				}
				goto case 10;
			case 4:
				point = ToPoint(op);
				num2 = 13;
				break;
			case 2:
				if (num5 < Levels.Count)
				{
					_split[num5] = Levels[num5].Value / 100.0;
					num5++;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0379;
			case 8:
				return;
			default:
				_endPoints = new Point[_split.Length];
				num2 = 15;
				break;
			case 11:
				{
					if (OpenStart)
					{
						_startPoints[num3].Y = 0.0;
						num2 = 5;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 5;
				}
				IL_0428:
				if (num4 >= _split.Length)
				{
					num2 = 12;
					break;
				}
				goto case 16;
				IL_0379:
				point2 = ToPoint(base.ControlPoints[1]);
				point3 = ToPoint(base.ControlPoints[0]);
				_startPoints = new Point[_split.Length];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
				{
					num2 = 0;
				}
				break;
				IL_0060:
				num3++;
				goto IL_026e;
				IL_026e:
				if (num3 >= _startPoints.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 9;
			}
		}
	}

	private double GetTime(int lineIndex)
	{
		return (base.ControlPoints[1].X - base.ControlPoints[0].X) * _split[lineIndex] + base.ControlPoints[0].X;
	}

	protected override bool InObject(int x, int y)
	{
		if (_startPoints == null || _endPoints == null)
		{
			return false;
		}
		int num = 0;
		int num2 = 3;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!CustomLevels)
				{
					goto case 2;
				}
				if (h026WWe0t9VGdIgwnKqy(Levels[num]))
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0093;
			case 2:
				if (cHd7V6e0TPfRibXIMZZN(x, y, _startPoints[num], _endPoints[num], rf914Xe0U61Waghe9Hg9(this) + 2))
				{
					return true;
				}
				goto IL_0093;
			case 1:
			case 3:
				{
					if (num < _startPoints.Length)
					{
						if (!(_startPoints[num] == default(Point)))
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0093;
					}
					return false;
				}
				IL_0093:
				num++;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		base.LineColor = qXjnp9e0yE7CXaCMy6LW(theme);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		using List<ObjectLine>.Enumerator enumerator = Levels.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.LineColor = theme.ChartObjectLineColor;
		}
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		if (objectBase is FibonacciTimeZonesObject fibonacciTimeZonesObject)
		{
			OpenStart = fibonacciTimeZonesObject.OpenStart;
			OpenEnd = fibonacciTimeZonesObject.OpenEnd;
			int num = 4;
			List<ObjectLine>.Enumerator enumerator = default(List<ObjectLine>.Enumerator);
			while (true)
			{
				switch (num)
				{
				default:
					Levels = new List<ObjectLine>();
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
					{
						num = 1;
					}
					continue;
				case 1:
					enumerator = fibonacciTimeZonesObject.Levels.GetEnumerator();
					num = 2;
					continue;
				case 3:
					break;
				case 4:
					TextAlignment = fibonacciTimeZonesObject.TextAlignment;
					CustomLevels = Fxf7lLe0ZU3TgRuVeOlV(fibonacciTimeZonesObject);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
					{
						num = 0;
					}
					continue;
				case 2:
					try
					{
						while (enumerator.MoveNext())
						{
							ObjectLine current = enumerator.Current;
							Levels.Add(new ObjectLine(current));
						}
						int num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x7394AED2));
					num = 3;
					continue;
				}
				break;
			}
		}
		base.CopyTemplate(objectBase, style);
	}

	static FibonacciTimeZonesObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		_defaultFibonacci = new double[7] { 0.0, 0.236, 0.382, 0.5, 0.618, 0.786, 1.0 };
	}

	internal static bool eXykbZe0jVl9Rh1niLSq()
	{
		return PHMw6re0cBmbPtnH5crv == null;
	}

	internal static FibonacciTimeZonesObject MVoJUVe0EvrrZBcNF6u2()
	{
		return PHMw6re0cBmbPtnH5crv;
	}

	internal static object rXncWIe0QaALpj4BUk1c(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color BHQqq3e0dYdEc2VvuTrM()
	{
		return Colors.Black;
	}

	internal static bool i4Cga9e0gSOl89oPRojQ(Point P_0, Point P_1)
	{
		return P_0 != P_1;
	}

	internal static int v4xwTPe0RfIJvkcAiHon(object P_0)
	{
		return ((ObjectLine)P_0).LineWidth;
	}

	internal static void xNueT3e06g6mRswiqV5F(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static object Nb3QFre0MGXN8Uk9To89(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static void F1aI0Oe0ONA9MjlOhNjC(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static double KTQxuqe0qepk9Zbrtaj8(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static int qtlOOZe0IguWZB4JyZ2Z(object P_0)
	{
		return ((List<ObjectLine>)P_0).Count;
	}

	internal static Rect HhYdare0WVuGT0FBHK97(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static bool h026WWe0t9VGdIgwnKqy(object P_0)
	{
		return ((ObjectLine)P_0).ShowLine;
	}

	internal static int rf914Xe0U61Waghe9Hg9(object P_0)
	{
		return ((ObjectBase)P_0).PenWidth;
	}

	internal static bool cHd7V6e0TPfRibXIMZZN(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		return XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(P_0, P_1, P_2, P_3, P_4);
	}

	internal static XColor qXjnp9e0yE7CXaCMy6LW(object P_0)
	{
		return ((IChartTheme)P_0).ChartObjectLineColor;
	}

	internal static bool Fxf7lLe0ZU3TgRuVeOlV(object P_0)
	{
		return ((FibonacciTimeZonesObject)P_0).CustomLevels;
	}
}
