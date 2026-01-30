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
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "FibonacciFanObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("FibonacciFan", "ChartObjectsFibonacciFan", 2, Type = typeof(FibonacciFanObject))]
public sealed class FibonacciFanObject : LineObjectBase
{
	private Point[] _startPoints;

	private Point[] _endPoints;

	private double[] _split;

	private bool _customLevels;

	private List<ObjectLine> _lines;

	private static FibonacciFanObject eKTBIMLzpFUIelnYLy7g;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D1884E6));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsCustomLevels")]
	[DataMember(Name = "Levels")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLevels")]
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD817B8));
			}
		}
	}

	public FibonacciFanObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		CustomLevels = false;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Levels = new List<ObjectLine>
		{
			new ObjectLine(0.0, IVDP7Ze00Rr231khLfS8()),
			new ObjectLine(23.6, Colors.Black),
			new ObjectLine(38.2, Colors.Black),
			new ObjectLine(50.0, Colors.Black),
			new ObjectLine(61.8, a4w4j1e02uNQTgKDL2RD(IVDP7Ze00Rr231khLfS8())),
			new ObjectLine(78.6, Colors.Black),
			new ObjectLine(100.0, Colors.Black)
		};
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				if (num3 >= _startPoints.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!CustomLevels)
				{
					visual.DrawLine(base.LinePen, _startPoints[num3], _endPoints[num3]);
					goto IL_00dc;
				}
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (_endPoints == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num3 = 0;
					num2 = 5;
				}
				break;
			case 4:
				CalcPoint();
				num2 = 3;
				break;
			case 1:
			{
				ObjectLine objectLine = Levels[num3];
				if (eEsY0Xe0H5IAJN1q8ysu(objectLine))
				{
					visual.DrawLine(objectLine.LinePen, _startPoints[num3], _endPoints[num3]);
				}
				goto IL_00dc;
			}
			case 6:
				return;
			case 3:
				if (_startPoints == null)
				{
					return;
				}
				goto case 2;
			case 0:
				return;
				IL_00dc:
				num3++;
				goto case 5;
			}
		}
	}

	private void CalcPoint()
	{
		if (!CustomLevels)
		{
			goto IL_0192;
		}
		_split = new double[VeSXyMe0fa0RcehVDy9y(Levels)];
		int num = 0;
		goto IL_0244;
		IL_0009:
		int num2;
		int num3 = default(int);
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_startPoints = new Point[_split.Length];
				_endPoints = new Point[_split.Length];
				num3 = 0;
				goto case 4;
			case 1:
			{
				_startPoints[num3] = array[0];
				_endPoints[num3] = new Point(array[1].X, array[0].Y + (array[1].Y - array[0].Y) * _split[num3]);
				XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, _startPoints[num3], _endPoints[num3], out var point);
				_endPoints[num3] = point;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 4:
				if (num3 >= _split.Length)
				{
					return;
				}
				goto case 1;
			case 2:
			case 5:
				array = ToPoints(base.ControlPoints);
				num2 = 6;
				continue;
			case 7:
				break;
			case 3:
				goto IL_01c3;
			default:
				num3++;
				num2 = 4;
				continue;
			}
			break;
		}
		goto IL_0192;
		IL_0244:
		if (num < Levels.Count)
		{
			_split[num] = oLGn4fe095hbghR0ULb3(Levels[num]) / 100.0;
			num2 = 3;
		}
		else
		{
			num2 = 5;
		}
		goto IL_0009;
		IL_0192:
		double[] array2 = new double[7];
		sAoSe5e0nKWhBLN82GxB(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		_split = array2;
		num2 = 2;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
		{
			num2 = 2;
		}
		goto IL_0009;
		IL_01c3:
		num++;
		goto IL_0244;
	}

	protected override bool InObject(int x, int y)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 4:
				if (!CustomLevels || Levels[num3].ShowLine)
				{
					if (XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(x, y, _startPoints[num3], _endPoints[num3], PenWidth + 2))
					{
						return true;
					}
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 1:
				if (_startPoints != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00c4;
			case 2:
				num3++;
				goto IL_00a6;
			case 5:
				if (!(_startPoints[num3] == default(Point)))
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			default:
				{
					if (_endPoints != null)
					{
						num3 = 0;
						goto IL_00a6;
					}
					goto IL_00c4;
				}
				IL_00a6:
				if (num3 >= _startPoints.Length)
				{
					goto case 3;
				}
				goto case 5;
				IL_00c4:
				return false;
			}
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		base.LineColor = HWtQEVe0GJlHnVxef1Ve(theme);
		List<ObjectLine>.Enumerator enumerator = Levels.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				RH0pCxe0YoXFpoEqJDdf(enumerator.Current, HWtQEVe0GJlHnVxef1Ve(theme));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
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
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		if (objectBase is FibonacciFanObject fibonacciFanObject)
		{
			CustomLevels = MLS8vOe0oVB8VnSfCU5b(fibonacciFanObject);
			Levels = new List<ObjectLine>();
			int num = 2;
			List<ObjectLine>.Enumerator enumerator = default(List<ObjectLine>.Enumerator);
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					try
					{
						while (enumerator.MoveNext())
						{
							ObjectLine current = enumerator.Current;
							Levels.Add(new ObjectLine(current));
							int num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
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
					enumerator = fibonacciFanObject.Levels.GetEnumerator();
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--871424829 ^ 0x33F09F9D));
		}
		base.CopyTemplate(objectBase, style);
	}

	static FibonacciFanObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool I9P5WOLzuDKGP724faTk()
	{
		return eKTBIMLzpFUIelnYLy7g == null;
	}

	internal static FibonacciFanObject VRjnI5Lzz1Uerja36GNY()
	{
		return eKTBIMLzpFUIelnYLy7g;
	}

	internal static Color IVDP7Ze00Rr231khLfS8()
	{
		return Colors.Black;
	}

	internal static XColor a4w4j1e02uNQTgKDL2RD(Color P_0)
	{
		return P_0;
	}

	internal static bool eEsY0Xe0H5IAJN1q8ysu(object P_0)
	{
		return ((ObjectLine)P_0).ShowLine;
	}

	internal static int VeSXyMe0fa0RcehVDy9y(object P_0)
	{
		return ((List<ObjectLine>)P_0).Count;
	}

	internal static double oLGn4fe095hbghR0ULb3(object P_0)
	{
		return ((ObjectLine)P_0).Value;
	}

	internal static void sAoSe5e0nKWhBLN82GxB(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static XColor HWtQEVe0GJlHnVxef1Ve(object P_0)
	{
		return ((IChartTheme)P_0).ChartObjectLineColor;
	}

	internal static void RH0pCxe0YoXFpoEqJDdf(object P_0, XColor value)
	{
		((ObjectLine)P_0).LineColor = value;
	}

	internal static bool MLS8vOe0oVB8VnSfCU5b(object P_0)
	{
		return ((FibonacciFanObject)P_0).CustomLevels;
	}
}
