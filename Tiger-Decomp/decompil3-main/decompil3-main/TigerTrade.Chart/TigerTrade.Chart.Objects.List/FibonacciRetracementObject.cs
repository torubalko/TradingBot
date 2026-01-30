using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "FibonacciRetracementObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("FibonacciRetracement", "ChartObjectsFibonacciRetracement", 2, Type = typeof(FibonacciRetracementObject))]
public sealed class FibonacciRetracementObject : LineObjectBase
{
	private Point[] _startPoints;

	private Point[] _endPoints;

	private double[] _split;

	private bool _openStart;

	private bool _openEnd;

	private ObjectTextAlignment _textAlignment;

	private bool _customLevels;

	private List<ObjectLine> _lines;

	private static FibonacciRetracementObject ihj1nAe0vVGmgWMCfl0A;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandLeft")]
	[DataMember(Name = "OpenStart")]
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3419855));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "OpenEnd")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandRight")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)oXRDxBe0i2sgPbRc9kVI(--500511424 ^ 0x1DD54914));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[DataMember(Name = "TextAlignment")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlignment")]
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671203255));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsCustomLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsEnable")]
	[DataMember(Name = "CustomLevels")]
	public bool CustomLevels
	{
		get
		{
			return _customLevels;
		}
		set
		{
			if (value != _customLevels)
			{
				_customLevels = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)oXRDxBe0i2sgPbRc9kVI(-1461292091 ^ -1461317823));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsCustomLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLevels")]
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3391B));
			}
		}
	}

	public FibonacciRetracementObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		OpenStart = false;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Levels = new List<ObjectLine>
				{
					new ObjectLine(0.0, e7vKRue0lPUyWXEfyeDa()),
					new ObjectLine(23.6, f4sc3Ze04RlbRmbMDxj8(Colors.Black)),
					new ObjectLine(38.2, e7vKRue0lPUyWXEfyeDa()),
					new ObjectLine(50.0, Colors.Black),
					new ObjectLine(61.8, Colors.Black),
					new ObjectLine(78.6, Colors.Black),
					new ObjectLine(100.0, e7vKRue0lPUyWXEfyeDa())
				};
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
				{
					num = 0;
				}
				break;
			case 2:
				OpenEnd = false;
				TextAlignment = ObjectTextAlignment.LeftBottom;
				CustomLevels = false;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 9;
		Point point2 = default(Point);
		ObjectLine objectLine = default(ObjectLine);
		int num3 = default(int);
		Point point = default(Point);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (_startPoints == null || _endPoints == null)
					{
						return;
					}
					point2 = ToPoint(base.ControlPoints[0]);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!CustomLevels)
					{
						goto default;
					}
					objectLine = Levels[num3];
					num2 = 6;
					break;
				case 5:
					visual.DrawLine(base.LinePen, point2.X, point2.Y, point.X, point.Y);
					goto IL_0120;
				case 6:
					if (zW8tMPe0bNHYIBndrqDL(objectLine))
					{
						num2 = 3;
						break;
					}
					goto IL_01a4;
				default:
					visual.DrawLine(base.LinePen, _startPoints[num3], _endPoints[num3]);
					num2 = 4;
					break;
				case 3:
					visual.DrawLine(objectLine.LinePen, _startPoints[num3], _endPoints[num3]);
					if (TextAlignment != ObjectTextAlignment.Hide)
					{
						num2 = 7;
						break;
					}
					goto IL_01a4;
				case 10:
					visual.DrawString(GetStr(num3), base.Canvas.ChartFont, base.LineBrush, GetRect(num3, base.LineWidth));
					goto IL_01a4;
				case 1:
					point = ToPoint(base.ControlPoints[1]);
					if (InMove && tZ78S0e0DKiHtG4gksXk(point2, default(Point)) && tZ78S0e0DKiHtG4gksXk(point, default(Point)))
					{
						num2 = 5;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0120;
				case 4:
					if (TextAlignment != ObjectTextAlignment.Hide)
					{
						goto end_IL_0012;
					}
					goto IL_01a4;
				case 7:
					visual.DrawString(GetStr(num3), (XFont)LyMg34e0NG4QfFoEeNJ7(base.Canvas), objectLine.LineBrush, GetRect(num3, WCEK4Ge0kBOxyi7Phtm6(objectLine)));
					goto IL_01a4;
				case 9:
					{
						CalcPoint();
						num2 = 8;
						break;
					}
					IL_0120:
					num3 = 0;
					goto IL_0102;
					IL_0102:
					if (num3 >= _startPoints.Length)
					{
						return;
					}
					goto case 2;
					IL_01a4:
					num3++;
					goto IL_0102;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	private string GetStr(int i)
	{
		string arg = base.DataProvider.Symbol.FormatPrice((decimal)GetPrice(i), shortDecimals: true);
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1127423276 ^ -1127440796), _split[i], arg);
	}

	private Rect GetRect(int i, int lineWidth)
	{
		int num = 6;
		int num2 = num;
		ObjectTextAlignment textAlignment = default(ObjectTextAlignment);
		double y = default(double);
		Size size = default(Size);
		double x = default(double);
		double width = default(double);
		while (true)
		{
			switch (num2)
			{
			case 4:
				switch (textAlignment)
				{
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.RightTop:
					y = _startPoints[i].Y - 4.0 - Math.Ceiling((double)lineWidth / 2.0) - size.Height;
					break;
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.RightMiddle:
					y = _startPoints[i].Y - 4.0 - REnkRxe05ilECegYIb2D((double)lineWidth / 2.0);
					break;
				case ObjectTextAlignment.LeftBottom:
				case ObjectTextAlignment.CenterBottom:
				case ObjectTextAlignment.RightBottom:
					y = _startPoints[i].Y + 4.0 + REnkRxe05ilECegYIb2D((double)lineWidth / 2.0);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				}
				goto default;
			default:
				textAlignment = TextAlignment;
				switch (textAlignment)
				{
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.CenterBottom:
					goto IL_00fb;
				case ObjectTextAlignment.RightTop:
				case ObjectTextAlignment.RightMiddle:
				case ObjectTextAlignment.RightBottom:
					goto IL_0168;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.LeftBottom:
					goto IL_02cf;
				}
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				goto IL_0168;
			case 5:
				x = 0.0;
				y = 0.0;
				width = size.Width;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
				{
					num2 = 8;
				}
				break;
			case 1:
			case 3:
			case 7:
				return new Rect(x, y, width, size.Height);
			case 6:
				size = xQFiEme01VQqW4W8W52C(LyMg34e0NG4QfFoEeNJ7(base.Canvas), GetStr(i));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				{
					textAlignment = TextAlignment;
					num2 = 4;
					break;
				}
				IL_0168:
				x = Math.Max(_startPoints[i].X, _endPoints[i].X) - width - 4.0;
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 != 0)
				{
					num2 = 1;
				}
				break;
				IL_00fb:
				x = (_startPoints[i].X + _endPoints[i].X - width) / 2.0;
				num2 = 7;
				break;
				IL_02cf:
				x = Math.Min(_startPoints[i].X, _endPoints[i].X) + 4.0;
				goto case 1;
				end_IL_0012:
				break;
			}
		}
	}

	private void CalcPoint()
	{
		int num = 14;
		int num4 = default(int);
		ObjectPoint op = default(ObjectPoint);
		int num5 = default(int);
		Point point3 = default(Point);
		int num3 = default(int);
		Point point = default(Point);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_endPoints[num4].X = base.Canvas.Rect.Right;
					num2 = 3;
					continue;
				case 11:
					return;
				case 15:
					op = new ObjectPoint(base.ControlPoints[0].X, 0.0);
					num5 = 0;
					goto case 16;
				case 1:
					if (OpenEnd)
					{
						_startPoints[num4].X = VYwep9e0xwJrTeBCKcCw(base.Canvas).Right;
					}
					goto case 3;
				case 2:
				case 6:
					point3 = ToPoint(base.ControlPoints[0]);
					num = 8;
					break;
				case 5:
					if (num3 >= Levels.Count)
					{
						num2 = 2;
						continue;
					}
					_split[num3] = Levels[num3].Value / 100.0;
					num3++;
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					if (num4 >= _startPoints.Length)
					{
						num2 = 11;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 9;
				case 10:
					if (OpenEnd)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 16:
					if (num5 < _split.Length)
					{
						op.Y = GetPrice(num5);
						Point point2 = ToPoint(op);
						_startPoints[num5] = new Point(point3.X, point2.Y);
						_endPoints[num5] = new Point(point.X, point2.Y);
						num5++;
						num2 = 16;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num4 = 0;
						num2 = 7;
					}
					continue;
				case 13:
					_split = new double[Levels.Count];
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
				{
					double[] array = new double[7];
					seoDmEe0S89H3PdTWjCo(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					_split = array;
					num2 = 6;
					continue;
				}
				case 9:
					if (!(_startPoints[num4].X <= _endPoints[num4].X))
					{
						if (OpenStart)
						{
							_endPoints[num4].X = 0.0;
							num2 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					}
					if (OpenStart)
					{
						_startPoints[num4].X = 0.0;
						num2 = 6;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 10;
				case 8:
					point = ToPoint(base.ControlPoints[1]);
					_startPoints = new Point[_split.Length];
					_endPoints = new Point[_split.Length];
					num2 = 15;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
					{
						num2 = 13;
					}
					continue;
				case 14:
					if (CustomLevels)
					{
						num = 13;
						break;
					}
					goto case 12;
				case 3:
					num4++;
					goto case 7;
				case 4:
					num3 = 0;
					goto case 5;
				}
				break;
			}
		}
	}

	private double GetPrice(int lineIndex)
	{
		return (base.ControlPoints[0].Y - base.ControlPoints[1].Y) * _split[lineIndex] + base.ControlPoints[1].Y;
	}

	protected override bool InObject(int x, int y)
	{
		if (_startPoints != null && _endPoints != null)
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return true;
				default:
					num3++;
					goto case 3;
				case 3:
					if (num3 >= _startPoints.Length)
					{
						return false;
					}
					goto case 1;
				case 1:
					if (!BSY1J8e0LId6ANgQMk9q(_startPoints[num3], default(Point)))
					{
						if ((!CustomLevels || Levels[num3].ShowLine) && peVebTe0e7YaAXrQTCxH(x, y, _startPoints[num3], _endPoints[num3], PenWidth + 2))
						{
							num2 = 4;
							break;
						}
						goto default;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}
		return false;
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.ApplyTheme(theme);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			base.LineColor = theme.ChartObjectLineColor;
			foreach (ObjectLine level in Levels)
			{
				gpILXwe0ssf2AvTb4FaY(level, theme.ChartObjectLineColor);
				int num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				}
			}
			return;
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 3;
		FibonacciRetracementObject fibonacciRetracementObject = default(FibonacciRetracementObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					TextAlignment = fibonacciRetracementObject.TextAlignment;
					num2 = 5;
					continue;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309556798));
					goto IL_0054;
				case 3:
					break;
				case 5:
					CustomLevels = fibonacciRetracementObject.CustomLevels;
					Levels = new List<ObjectLine>();
					foreach (ObjectLine level in fibonacciRetracementObject.Levels)
					{
						Levels.Add(new ObjectLine(level));
						int num3 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
					}
					if (base.DataProvider != null)
					{
						CalcPoint();
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 2:
					if (fibonacciRetracementObject != null)
					{
						OpenStart = fibonacciRetracementObject.OpenStart;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_0054;
				case 1:
					{
						OpenEnd = CTRdkae0XOLRqgyoZmx1(fibonacciRetracementObject);
						num2 = 4;
						continue;
					}
					IL_0054:
					base.CopyTemplate(objectBase, style);
					return;
				}
				break;
			}
			fibonacciRetracementObject = objectBase as FibonacciRetracementObject;
			num = 2;
		}
	}

	static FibonacciRetracementObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool finduHe0BLtswy2pKwpb()
	{
		return ihj1nAe0vVGmgWMCfl0A == null;
	}

	internal static FibonacciRetracementObject qHnSj3e0aIM66e5uyvCf()
	{
		return ihj1nAe0vVGmgWMCfl0A;
	}

	internal static object oXRDxBe0i2sgPbRc9kVI(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color e7vKRue0lPUyWXEfyeDa()
	{
		return Colors.Black;
	}

	internal static XColor f4sc3Ze04RlbRmbMDxj8(Color P_0)
	{
		return P_0;
	}

	internal static bool tZ78S0e0DKiHtG4gksXk(Point P_0, Point P_1)
	{
		return P_0 != P_1;
	}

	internal static bool zW8tMPe0bNHYIBndrqDL(object P_0)
	{
		return ((ObjectLine)P_0).ShowLine;
	}

	internal static object LyMg34e0NG4QfFoEeNJ7(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static int WCEK4Ge0kBOxyi7Phtm6(object P_0)
	{
		return ((ObjectLine)P_0).LineWidth;
	}

	internal static Size xQFiEme01VQqW4W8W52C(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static double REnkRxe05ilECegYIb2D(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static void seoDmEe0S89H3PdTWjCo(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static Rect VYwep9e0xwJrTeBCKcCw(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static bool BSY1J8e0LId6ANgQMk9q(Point P_0, Point P_1)
	{
		return P_0 == P_1;
	}

	internal static bool peVebTe0e7YaAXrQTCxH(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		return XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(P_0, P_1, P_2, P_3, P_4);
	}

	internal static void gpILXwe0ssf2AvTb4FaY(object P_0, XColor value)
	{
		((ObjectLine)P_0).LineColor = value;
	}

	internal static bool CTRdkae0XOLRqgyoZmx1(object P_0)
	{
		return ((FibonacciRetracementObject)P_0).OpenEnd;
	}
}
