using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "TimeRangeObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("TimeRange", "ChartObjectsTimeRange", 2, Type = typeof(TimeRangeObject))]
public sealed class TimeRangeObject : PolygonObjectBase
{
	private class y7dOIwiCP65MAxlMiMlb
	{
		public Point gGbiCJqSECa;

		public Point liWiCFKqdMF;

		public Point Center;

		public Rect NbkiC36jFLk;

		public Rect k9MiCpfMUUK;

		internal static y7dOIwiCP65MAxlMiMlb LelIjNetgBXf4rKheqdg;

		public y7dOIwiCP65MAxlMiMlb()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		static y7dOIwiCP65MAxlMiMlb()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool K7AHv4etRwp5assNM1xD()
		{
			return LelIjNetgBXf4rKheqdg == null;
		}

		internal static y7dOIwiCP65MAxlMiMlb glLeaqet66POxoJFWFwA()
		{
			return LelIjNetgBXf4rKheqdg;
		}
	}

	private y7dOIwiCP65MAxlMiMlb _rangeInfo;

	private static TimeRangeObject MmoTmPe9nRuXKwrHvOj2;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		_rangeInfo = new y7dOIwiCP65MAxlMiMlb();
		Point valueFromPos = base.Canvas.GetValueFromPos(0.0, cGnRuve9oG1JBWZbOwsk(base.Canvas).Top + cGnRuve9oG1JBWZbOwsk(base.Canvas).Height / 2.0);
		int num = 12;
		Point point = default(Point);
		Point gGbiCJqSECa = default(Point);
		double num2 = default(double);
		Point point2 = default(Point);
		Point liWiCFKqdMF = default(Point);
		Point point3 = default(Point);
		Point point4 = default(Point);
		double x = default(double);
		while (true)
		{
			switch (num)
			{
			case 3:
				point = new Point(gGbiCJqSECa.X - num2, cGnRuve9oG1JBWZbOwsk(base.Canvas).Bottom);
				point2 = new Point(liWiCFKqdMF.X + num2, base.Canvas.Rect.Top);
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
				{
					num = 0;
				}
				break;
			case 10:
				_rangeInfo.k9MiCpfMUUK = new Rect(new Point(_rangeInfo.Center.X - 10.0, _rangeInfo.Center.Y - 10.0), new Point(_rangeInfo.Center.X + 10.0, _rangeInfo.Center.Y + 10.0));
				if (!base.DrawBack)
				{
					return;
				}
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num = 0;
				}
				break;
			case 8:
				_rangeInfo.liWiCFKqdMF.X -= num2;
				goto IL_024e;
			case 11:
				_rangeInfo.liWiCFKqdMF.X += num2;
				goto IL_024e;
			case 7:
				_rangeInfo.Center = new Point((point3.X + point2.X) / 2.0, gGbiCJqSECa.Y);
				_rangeInfo.NbkiC36jFLk = new Rect(point3, point4);
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
				{
					num = 10;
				}
				break;
			case 9:
				visual.FillRectangle(base.BackBrush, _rangeInfo.NbkiC36jFLk);
				return;
			case 4:
				point4 = new Point(liWiCFKqdMF.X + num2, cGnRuve9oG1JBWZbOwsk(base.Canvas).Bottom);
				if (base.DrawBorder)
				{
					FWSAaMe9BlkHKWiTMAgV(visual, base.LinePen, point3, point);
					FWSAaMe9BlkHKWiTMAgV(visual, base.LinePen, point2, point4);
					num = 7;
					break;
				}
				goto case 7;
			case 12:
				base.ControlPoints[0].Y = valueFromPos.Y;
				base.ControlPoints[1].Y = valueFromPos.Y;
				num2 = gr4xCle9vHMrIjyPGAPO(base.Canvas) / 2.0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 != 0)
				{
					num = 5;
				}
				break;
			case 6:
				liWiCFKqdMF = _rangeInfo.liWiCFKqdMF;
				if (gGbiCJqSECa.X > liWiCFKqdMF.X)
				{
					x = gGbiCJqSECa.X;
					gGbiCJqSECa.X = liWiCFKqdMF.X;
					int num3 = 2;
					num = num3;
					break;
				}
				goto default;
			case 1:
				_rangeInfo.gGbiCJqSECa.X += num2;
				num = 8;
				break;
			default:
				_rangeInfo.gGbiCJqSECa.X -= num2;
				num = 11;
				break;
			case 2:
				liWiCFKqdMF.X = x;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				{
					_rangeInfo.gGbiCJqSECa = ToPoint(base.ControlPoints[0]);
					_rangeInfo.liWiCFKqdMF = ToPoint(base.ControlPoints[1]);
					gGbiCJqSECa = _rangeInfo.gGbiCJqSECa;
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
					{
						num = 6;
					}
					break;
				}
				IL_024e:
				point3 = new Point(gGbiCJqSECa.X - num2, cGnRuve9oG1JBWZbOwsk(base.Canvas).Top);
				num = 3;
				break;
			}
		}
	}

	public override void DrawControlPoints(DxVisualQueue visual)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				DrawControlPoint(visual, _rangeInfo.gGbiCJqSECa);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				DrawControlPoint(visual, _rangeInfo.Center);
				DrawControlPoint(visual, _rangeInfo.liWiCFKqdMF);
				return;
			case 2:
				if (_rangeInfo == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override int GetControlPoint(int x, int y)
	{
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					if (_rangeInfo == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
						{
							num2 = 1;
						}
						break;
					}
					Point[] array = new Point[2] { _rangeInfo.gGbiCJqSECa, _rangeInfo.liWiCFKqdMF };
					num3 = 0;
					while (num3 < array.Length)
					{
						double num4 = array[num3].X - (double)x;
						if (!(num4 * num4 < 9.0 + (double)PenWidth / 2.0))
						{
							num3++;
							continue;
						}
						goto IL_00bd;
					}
					goto end_IL_0012;
				}
				default:
					return num3;
				case 1:
					return -1;
				case 3:
					{
						return -1;
					}
					IL_00bd:
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected override bool InObject(int x, int y)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (_rangeInfo != null)
				{
					if (GetControlPoint(x, y) != -1)
					{
						return true;
					}
					if (_rangeInfo.k9MiCpfMUUK != Rect.Empty)
					{
						return _rangeInfo.k9MiCpfMUUK.Contains(x, y);
					}
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TimeRangeObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static TimeRangeObject()
	{
		O58LE5e9a1sFYYNGYH4e();
		zCVY1me9iRuqHsB6vrwD();
	}

	internal static Rect cGnRuve9oG1JBWZbOwsk(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static double gr4xCle9vHMrIjyPGAPO(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static void FWSAaMe9BlkHKWiTMAgV(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static bool gNYp6de9GLSKIbxJHmbY()
	{
		return MmoTmPe9nRuXKwrHvOj2 == null;
	}

	internal static TimeRangeObject pwG4Xne9YQSXqbcU3Unx()
	{
		return MmoTmPe9nRuXKwrHvOj2;
	}

	internal static void O58LE5e9a1sFYYNGYH4e()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void zCVY1me9iRuqHsB6vrwD()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
