using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using ECOEgqlSad8NUJZ2Dr9n;
using nMdsO0nBS6mwx8OlNjMY;
using s8CVoTnYOlGDs7vDiB5f;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Theme;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TuAMtrl1Nd3XoZQQUXf0;
using W7vgMFnvUmmoQloCDPpC;

namespace BxclxZ9r2PXTJqynAQd8;

internal sealed class smVmOf9r0GqjHV49hQim
{
	private readonly vJGfm5nYMCEZFuST02my cas9rB9eYnI;

	internal static smVmOf9r0GqjHV49hQim VHTPSAbylfM20MpQmheU;

	public smVmOf9r0GqjHV49hQim(vJGfm5nYMCEZFuST02my P_0)
	{
		MvUMYHbyblVgcTpFqqiC();
		base._002Ector();
		cas9rB9eYnI = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void d5C9rH2nBso(IndicatorBase P_0, DxVisualQueue P_1)
	{
		P_0.Render(P_1);
		if (P_0.DisableRender)
		{
			return;
		}
		Rect rect = YBc3gpbyk3MSJ75QkrJJ(F7i456byNc1ZPYXhBsiM(cas9rB9eYnI));
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
		{
			num = 2;
		}
		List<ChartLevel>.Enumerator enumerator = default(List<ChartLevel>.Enumerator);
		while (true)
		{
			switch (num)
			{
			case 2:
				enumerator = P_0.Levels.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num = 0;
				}
				continue;
			case 1:
				return;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					while (true)
					{
						ChartLevel current = enumerator.Current;
						if (current.Visible)
						{
							double num2 = cas9rB9eYnI.ybUnYpBPWvT().A0PnvVYTtGb((double)current.Level);
							P_1.DrawLine((XPen)V6tQ6eby1VJDakRHKGOr(current), rect.Left, num2, rect.Right, num2);
							int num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
							{
								num3 = 1;
							}
							switch (num3)
							{
							case 1:
								break;
							default:
								continue;
							}
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			IEnumerator<IndicatorSeriesData> enumerator2 = ((IndicatorSeries)tP6E9iby5gw7rMMqbwQM(P_0)).GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					IndicatorSeriesData current2 = enumerator2.Current;
					if (!current2.Style.Visible)
					{
						continue;
					}
					ChartSeriesType renderType = ((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(current2)).RenderType;
					int num4 = 6;
					while (true)
					{
						switch (num4)
						{
						case 2:
						case 3:
						case 4:
						case 5:
							break;
						default:
							zke9rfaLldg(P_1, current2);
							break;
						case 7:
							DrawLine(P_1, current2);
							num4 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
							{
								num4 = 5;
							}
							continue;
						case 6:
							switch (renderType)
							{
							case ChartSeriesType.Columns:
								break;
							case ChartSeriesType.Area:
								goto IL_00a7;
							case ChartSeriesType.Region:
								goto IL_00ca;
							case ChartSeriesType.Line:
								goto IL_0162;
							default:
								goto IL_0193;
							case ChartSeriesType.Points:
								goto IL_01a7;
							}
							goto default;
						case 1:
							goto IL_01a7;
							IL_01a7:
							f9B9rYE5E1C(P_1, current2);
							break;
							IL_0193:
							num4 = 2;
							continue;
							IL_0162:
							if (current2.Style.StraightLine)
							{
								tb89rGd4ffW(P_1, current2);
								break;
							}
							goto case 7;
							IL_00ca:
							xBw9r92t5pS(P_1, current2);
							num4 = 3;
							continue;
							IL_00a7:
							aMR9rn6Hheb(P_1, current2);
							num4 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
							{
								num4 = 1;
							}
							continue;
						}
						break;
					}
				}
				return;
			}
			finally
			{
				if (enumerator2 != null)
				{
					JC1pNPbyxJls9N28681f(enumerator2);
				}
			}
		}
	}

	private void zke9rfaLldg(DxVisualQueue P_0, IndicatorSeriesData P_1)
	{
		Point[] array = wSn9rvykN0C(P_1);
		double num = AbUxuwbyLGFHrcaBMvAv(cas9rB9eYnI.ybUnYpBPWvT(), 0.0);
		int num2 = 9;
		int num4 = default(int);
		XBrush xBrush2 = default(XBrush);
		XColor color2 = default(XColor);
		XPen xPen2 = default(XPen);
		int num5 = default(int);
		bool flag = default(bool);
		double num7 = default(double);
		double x = default(double);
		double num6 = default(double);
		XBrush xBrush = default(XBrush);
		XPen xPen = default(XPen);
		Rect rect = default(Rect);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 6:
				num4 = -num4;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				xBrush2 = new XBrush(color2);
				xPen2 = new XPen(xBrush2, 1);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
			case 11:
				num5++;
				goto case 12;
			case 4:
				num5 = 0;
				num3 = 12;
				goto IL_0005;
			default:
				flag = true;
				num7 = Math.Max(cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth - 1.0, 1.0);
				num2 = 4;
				break;
			case 1:
				flag = ((num5 < array.Length - 1) ? (array[num5].Y < array[num5 + 1].Y) : flag);
				goto IL_0104;
			case 3:
				x = array[num5].X;
				num6 = array[num5].Y;
				num4 = (int)num - (int)num6;
				if (P_1.Style.ColorSplit == ChartSeriesColorSplit.UpDownZero)
				{
					flag = num4 > 0;
					goto IL_0104;
				}
				goto case 10;
			case 9:
			{
				XColor color = ((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).Color;
				color2 = P_1.Style.Color2;
				xBrush = new XBrush(color);
				xPen = new XPen(xBrush, 1);
				num2 = 8;
				break;
			}
			case 2:
				num4 = Math.Max(1, num4);
				if (num7 > 1.0)
				{
					rect = new Rect(x - num7 / 2.0, num6, num7, num4);
					num2 = 5;
				}
				else
				{
					P_0.DrawLine(flag ? xPen : xPen2, x, num6, x, num6 + (double)num4);
					num2 = 11;
				}
				break;
			case 10:
				if (P_1.Style.ColorSplit == ChartSeriesColorSplit.UpDown)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0104;
			case 12:
				if (num5 >= array.Length)
				{
					return;
				}
				goto case 3;
			case 5:
				{
					P_0.FillRectangle(flag ? xBrush : xBrush2, rect);
					num3 = 7;
					goto IL_0005;
				}
				IL_0104:
				if ((double)num4 < 0.0)
				{
					num6 += (double)num4;
					num2 = 6;
					break;
				}
				goto case 2;
				IL_0005:
				num2 = num3;
				break;
			}
		}
	}

	private void xBw9r92t5pS(DxVisualQueue P_0, IndicatorSeriesData P_1)
	{
		if (P_1[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801531160)] == null)
		{
			P_1[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -5906769)] = new double[P_1.Length];
		}
		Point[] array = wSn9rvykN0C(P_1);
		int num = 31;
		int num9 = default(int);
		int num12 = default(int);
		Point[] array5 = default(Point[]);
		int num6 = default(int);
		Point[] array6 = default(Point[]);
		int num13 = default(int);
		List<Point> list = default(List<Point>);
		int num10 = default(int);
		Point[] array4 = default(Point[]);
		bool[] array2 = default(bool[]);
		object obj = default(object);
		int num7 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int count = default(int);
		Point[] array3 = default(Point[]);
		int num3 = default(int);
		int num14 = default(int);
		List<Point> list2 = default(List<Point>);
		int num5 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num11;
			int num2;
			switch (num)
			{
			case 1:
			case 28:
				if (num9 >= num12)
				{
					num = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
					{
						num = 7;
					}
					continue;
				}
				array5[num9 + num6] = array6[num12 - 1 - num9];
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
				{
					num = 0;
				}
				continue;
			case 31:
				array6 = wSn9rvykN0C(P_1, (string)eX3f1CbyeI6opS3xaFRD(-1841489831 ^ -1841557709));
				num6 = array.Length;
				num12 = array6.Length;
				num13 = num6 + num12;
				if (num13 < 4)
				{
					return;
				}
				num = 2;
				continue;
			case 17:
				list.Add(array6[num10]);
				num = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num = 21;
				}
				continue;
			case 32:
				FKBi1dbydkDG344n1w1E(P_0, new XBrush(((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).Color), array4);
				return;
			case 2:
				if (num6 != num12)
				{
					return;
				}
				array2 = zc0rgfbyscoaK3liaLt7(P_1.UserData, eX3f1CbyeI6opS3xaFRD(-1763895751 ^ -1763966537)) as bool[];
				num = 7;
				continue;
			case 8:
				array5 = new Point[num13];
				num = 3;
				continue;
			case 22:
				obj = zc0rgfbyscoaK3liaLt7(XXkr1IbyXMDB1rruHFV0(P_1), eX3f1CbyeI6opS3xaFRD(0x22BF43FC ^ 0x22BB328A));
				num = 25;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
				{
					num = 18;
				}
				continue;
			case 26:
				array4[num7 + num4] = list[num4 - 1 - num7];
				num7++;
				num = 30;
				continue;
			case 21:
				if (flag)
				{
					num = 10;
					continue;
				}
				goto IL_016c;
			case 6:
				list[count - 1] = new Point(list[count - 1].X - cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, list[count - 1].Y);
				goto IL_012e;
			case 29:
				num9 = 0;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
				{
					num = 1;
				}
				continue;
			case 5:
				num10++;
				num = 11;
				continue;
			case 18:
				array3[num3 + count] = list[count - 1 - num3];
				num3++;
				goto case 20;
			case 11:
				if (num10 >= num6)
				{
					num = 27;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num = 24;
					}
				}
				else
				{
					num14 = Td97wsbycwjAJvcvFEjh(cas9rB9eYnI.T6NnYzm3A5s(), num10);
					list2.Add(array[num10]);
					num = 17;
				}
				continue;
			case 19:
				array5[num5] = array[num5];
				num5++;
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num = 1;
				}
				continue;
			case 23:
				gqN39ibyEd9ZQDMEPGR1(list2);
				list.Clear();
				num = 5;
				continue;
			case 16:
				count = list2.Count;
				num = 4;
				continue;
			case 10:
				if (list2.Count == 1)
				{
					list2[0] = new Point(list2[0].X + ((cqA0v8nB5WPCq4KbMXlc)F7i456byNc1ZPYXhBsiM(cas9rB9eYnI)).ColumnWidth / 2.0, list2[0].Y);
					list[0] = new Point(list[0].X + cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, list[0].Y);
				}
				goto IL_016c;
			case 12:
				if (num8 < num4)
				{
					array4[num8] = list2[num8];
					num8++;
					num = 12;
					continue;
				}
				num7 = 0;
				goto case 30;
			case 3:
				num5 = 0;
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 2;
				}
				continue;
			case 25:
				if (obj is bool)
				{
					flag2 = (bool)obj;
					num11 = 1;
				}
				else
				{
					num11 = 0;
				}
				break;
			case 30:
				if (num7 >= num4)
				{
					num = 32;
					continue;
				}
				goto case 26;
			case 20:
				if (num3 >= count)
				{
					P_0.FillPolygon(new XBrush(P_1.Style.Color), array3);
					num = 23;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
					{
						num = 5;
					}
					continue;
				}
				goto case 18;
			case 24:
				list = new List<Point>();
				num10 = 0;
				goto case 11;
			default:
				num9++;
				num2 = 28;
				goto IL_0005;
			case 14:
				FKBi1dbydkDG344n1w1E(P_0, new XBrush(P_1.Style.Color), array5);
				return;
			case 4:
				if (flag)
				{
					list2[count - 1] = new Point(list2[count - 1].X - dy6XKZbyjqtalL99j1Sa(cas9rB9eYnI.T6NnYzm3A5s()) / 2.0, list2[count - 1].Y);
					num = 6;
					continue;
				}
				goto IL_012e;
			case 15:
				array4 = new Point[num4 * 2];
				num8 = 0;
				goto case 12;
			case 9:
			case 13:
				if (num5 >= num6)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num = 29;
					}
					continue;
				}
				goto case 19;
			case 27:
				if (yCtMw2byQDTX7s06kk3x(list2) <= 2)
				{
					return;
				}
				num4 = yCtMw2byQDTX7s06kk3x(list2);
				num = 15;
				continue;
			case 7:
				{
					if (array2 == null)
					{
						num2 = 8;
						goto IL_0005;
					}
					goto case 22;
				}
				IL_0005:
				num = num2;
				continue;
				IL_012e:
				array3 = new Point[count * 2];
				for (int i = 0; i < count; i++)
				{
					array3[i] = list2[i];
				}
				num3 = 0;
				num = 20;
				continue;
				IL_016c:
				if (array2[num14])
				{
					num = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num = 11;
					}
					continue;
				}
				goto case 5;
			}
			flag = (byte)((uint)num11 & (flag2 ? 1u : 0u)) != 0;
			list2 = new List<Point>();
			num = 24;
		}
	}

	private void aMR9rn6Hheb(DxVisualQueue P_0, IndicatorSeriesData P_1)
	{
		Point[] array = wSn9rvykN0C(P_1);
		Point[] array2 = default(Point[]);
		int num = default(int);
		int num2;
		if (array.Length > 1)
		{
			array2 = new Point[array.Length + 2];
			num = 0;
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
			{
				num2 = 1;
			}
		}
		else
		{
			num2 = 3;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
				num++;
				break;
			case 3:
				return;
			default:
				goto IL_010a;
			case 1:
				break;
			}
			if (num >= array.Length)
			{
				break;
			}
			goto IL_010a;
			IL_010a:
			array2[num] = array[num];
			int num3 = 2;
			num2 = num3;
		}
		array2[array.Length] = new Point(array[array.Length - 1].X, cas9rB9eYnI.T6NnYzm3A5s().Rect.Bottom);
		array2[array.Length + 1] = new Point(array[0].X, cas9rB9eYnI.T6NnYzm3A5s().Rect.Bottom);
		FKBi1dbydkDG344n1w1E(P_0, new XBrush(P_1.Style.Color), array2);
	}

	private void DrawLine(DxVisualQueue visual, IndicatorSeriesData data)
	{
		Point[] array = default(Point[]);
		XPen xPen = default(XPen);
		int num;
		if (!((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(data)).StraightLine)
		{
			array = wSn9rvykN0C(data);
			xPen = new XPen(new XBrush(data.Style.Color), data.Style.LineWidth, ((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(data)).LineStyle);
			num = 6;
		}
		else
		{
			tb89rGd4ffW(visual, data);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
			{
				num = 0;
			}
		}
		bool flag4 = default(bool);
		bool flag = default(bool);
		List<Point> list = default(List<Point>);
		bool flag2 = default(bool);
		int num2 = default(int);
		XPen xPen3 = default(XPen);
		double num6 = default(double);
		bool[] array2 = default(bool[]);
		XPen xPen2 = default(XPen);
		List<Point> list2 = default(List<Point>);
		int num3 = default(int);
		bool flag3 = default(bool);
		while (true)
		{
			int num4;
			switch (num)
			{
			default:
				return;
			case 14:
			{
				object obj = data.UserData[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC19AA4D)];
				int num5;
				if (obj is bool)
				{
					flag4 = (bool)obj;
					num5 = 1;
				}
				else
				{
					num5 = 0;
				}
				flag = (byte)((uint)num5 & (flag4 ? 1u : 0u)) != 0;
				list = new List<Point>();
				num4 = 17;
				goto IL_0005;
			}
			case 16:
				return;
			case 1:
				flag2 = true;
				num = 21;
				break;
			case 0:
				return;
			case 17:
				num2 = 0;
				num = 10;
				break;
			case 22:
				xPen3 = new XPen(new XBrush(data.Style.Color2), xPen.Width, xPen.Style);
				num6 = AbUxuwbyLGFHrcaBMvAv(cas9rB9eYnI.ybUnYpBPWvT(), 0.0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 1;
				}
				break;
			case 4:
				if (array2 == null)
				{
					num = 7;
					break;
				}
				goto case 14;
			case 24:
				return;
			case 6:
				if (array.Length <= 1 || xPen.Width <= 0)
				{
					return;
				}
				if (data.Style.ColorSplit != ChartSeriesColorSplit.NoSplit && data.Style.Color2 != data.Style.Color)
				{
					xPen2 = new XPen(new XBrush(data.Style.Color), xPen.Width, xPen.Style);
					num = 22;
					break;
				}
				array2 = data.UserData[eX3f1CbyeI6opS3xaFRD(0x130FEA25 ^ 0x130EFDAB)] as bool[];
				num4 = 4;
				goto IL_0005;
			case 10:
			case 11:
				if (num2 >= array.Length)
				{
					Q9ZW3cbyR7khiwJ3Vqlo(visual, xPen, list.ToArray());
					num4 = 20;
					goto IL_0005;
				}
				list.Add(array[num2]);
				num = 9;
				break;
			case 21:
				list2 = new List<Point> { array[0] };
				num3 = 1;
				goto case 12;
			case 20:
				list.Clear();
				num = 5;
				break;
			case 23:
				flag3 = array[num3].Y > array[num3 - 1].Y;
				num = 19;
				break;
			case 18:
				list2.Add(array[num3 - 1]);
				goto IL_0596;
			case 3:
			case 19:
				if (flag2 == flag3)
				{
					goto IL_0208;
				}
				if (list2.Count > 1)
				{
					visual.DrawLines(flag2 ? xPen2 : xPen3, list2.ToArray());
					list2.Clear();
					num = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
					{
						num = 7;
					}
					break;
				}
				goto IL_0596;
			case 15:
				num3++;
				num = 12;
				break;
			case 2:
				if (flag)
				{
					num4 = 13;
					goto IL_0005;
				}
				goto IL_01ac;
			case 13:
				list[list.Count - 1] = new Point(list[yCtMw2byQDTX7s06kk3x(list) - 1].X - cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, list[list.Count - 1].Y);
				goto IL_01ac;
			case 8:
				if (((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(data)).ColorSplit != ChartSeriesColorSplit.UpDown)
				{
					flag3 = array[num3].Y <= num6;
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
					{
						num = 2;
					}
				}
				else
				{
					num = 23;
				}
				break;
			case 5:
				return;
			case 7:
				visual.DrawLines(xPen, array);
				num4 = 16;
				goto IL_0005;
			case 9:
			{
				if (flag && list.Count == 1)
				{
					list[0] = new Point(list[0].X + cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, list[0].Y);
				}
				int index = ((cqA0v8nB5WPCq4KbMXlc)F7i456byNc1ZPYXhBsiM(cas9rB9eYnI)).GetIndex(num2);
				if (array2[index])
				{
					num = 2;
					break;
				}
				goto IL_0501;
			}
			case 12:
				{
					if (num3 >= array.Length)
					{
						visual.DrawLines(flag2 ? xPen2 : xPen3, list2.ToArray());
						list2.Clear();
						num = 24;
						break;
					}
					goto case 8;
				}
				IL_01ac:
				Q9ZW3cbyR7khiwJ3Vqlo(visual, xPen, eRileobygn6FStMlhv99(list));
				gqN39ibyEd9ZQDMEPGR1(list);
				goto IL_0501;
				IL_0501:
				num2++;
				num = 11;
				break;
				IL_0005:
				num = num4;
				break;
				IL_0596:
				flag2 = flag3;
				goto IL_0208;
				IL_0208:
				list2.Add(array[num3]);
				num = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
				{
					num = 12;
				}
				break;
			}
		}
	}

	private void tb89rGd4ffW(DxVisualQueue P_0, IndicatorSeriesData P_1)
	{
		int num = 13;
		int num4 = default(int);
		Point[] array = default(Point[]);
		XPen xPen3 = default(XPen);
		List<Point> list2 = default(List<Point>);
		XPen xPen2 = default(XPen);
		double num5 = default(double);
		int num6 = default(int);
		List<Point> list = default(List<Point>);
		Point point = default(Point);
		int num3 = default(int);
		List<Point> list3 = default(List<Point>);
		bool flag = default(bool);
		bool flag2 = default(bool);
		XPen xPen = default(XPen);
		Point point4 = default(Point);
		Point point3 = default(Point);
		bool[] array2 = default(bool[]);
		int index = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (num4 >= array.Length)
					{
						P_0.DrawLines(xPen3, list2.ToArray());
						return;
					}
					goto case 24;
				case 17:
					xPen2 = new XPen(new XBrush(P_1.Style.Color2), xPen3.Width, xPen3.Style);
					num5 = AbUxuwbyLGFHrcaBMvAv(cas9rB9eYnI.ybUnYpBPWvT(), 0.0);
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num2 = 20;
					}
					continue;
				case 11:
					num4 = 0;
					goto case 2;
				case 1:
					num6++;
					goto IL_06c2;
				case 25:
					list.Add(new Point(point.X - dy6XKZbyjqtalL99j1Sa(cas9rB9eYnI.T6NnYzm3A5s()) / 2.0, point.Y));
					num3 = 1;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
					{
						num2 = 19;
					}
					continue;
				case 27:
				{
					Point point5 = array[num6];
					list3.Add(new Point(point5.X + dy6XKZbyjqtalL99j1Sa(cas9rB9eYnI.T6NnYzm3A5s()) / 2.0, point5.Y));
					list3.Add(new Point(point5.X - cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point5.Y));
					num2 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
					{
						num2 = 10;
					}
					continue;
				}
				case 12:
					xPen3 = new XPen(new XBrush(((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).Color), P_1.Style.LineWidth, P_1.Style.LineStyle);
					if (array.Length <= 1 || xPen3.Width <= 0)
					{
						return;
					}
					if (P_1.Style.ColorSplit != ChartSeriesColorSplit.NoSplit)
					{
						num2 = 6;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_03e3;
				case 21:
					P_0.DrawLines(xPen3, list3.ToArray());
					gqN39ibyEd9ZQDMEPGR1(list3);
					return;
				case 16:
				{
					Point point2 = array[num3];
					list.Add(new Point(point2.X + cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point2.Y));
					list.Add(new Point(point2.X - cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point2.Y));
					num3++;
					num2 = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 3:
					list = new List<Point>();
					num = 22;
					break;
				case 14:
					num4++;
					num2 = 2;
					continue;
				case 15:
				case 23:
					if (flag == flag2)
					{
						goto case 16;
					}
					if (list.Count > 1)
					{
						Q9ZW3cbyR7khiwJ3Vqlo(P_0, flag ? xPen : xPen2, list.ToArray());
						gqN39ibyEd9ZQDMEPGR1(list);
						point4 = array[num3 - 1];
						list.Add(new Point(point4.X + cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point4.Y));
						num2 = 5;
						continue;
					}
					goto IL_040a;
				case 5:
					list.Add(new Point(point4.X - ((cqA0v8nB5WPCq4KbMXlc)F7i456byNc1ZPYXhBsiM(cas9rB9eYnI)).ColumnWidth / 2.0, point4.Y));
					goto IL_040a;
				case 24:
					point3 = array[num4];
					num2 = 26;
					continue;
				case 6:
					if (ghaTG7by6SVDLnRr5TEb(P_1.Style.Color2, ((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).Color))
					{
						xPen = new XPen(new XBrush(P_1.Style.Color), xPen3.Width, VrcfIybyMBLuMl9sWqMd(xPen3));
						num2 = 17;
						continue;
					}
					goto IL_03e3;
				case 4:
					if (array2[index])
					{
						P_0.DrawLines(xPen3, list3.ToArray());
						num2 = 8;
						continue;
					}
					goto case 1;
				case 10:
					index = cas9rB9eYnI.T6NnYzm3A5s().GetIndex(num6);
					num2 = 4;
					continue;
				case 20:
					flag = true;
					num2 = 3;
					continue;
				case 26:
					list2.Add(new Point(point3.X + cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point3.Y));
					list2.Add(new Point(point3.X - cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point3.Y));
					num = 14;
					break;
				default:
					list3 = new List<Point>();
					num6 = 0;
					goto IL_06c2;
				case 8:
					list3.Clear();
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					point = array[0];
					list.Add(new Point(point.X + cas9rB9eYnI.T6NnYzm3A5s().ColumnWidth / 2.0, point.Y));
					num2 = 19;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 25;
					}
					continue;
				case 9:
					if (((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).ColorSplit != ChartSeriesColorSplit.UpDown)
					{
						flag2 = array[num3].Y <= num5;
						num2 = 15;
						continue;
					}
					flag2 = array[num3].Y > array[num3 - 1].Y;
					num2 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
					{
						num2 = 23;
					}
					continue;
				case 13:
					array = wSn9rvykN0C(P_1);
					num2 = 12;
					continue;
				case 18:
				case 19:
					if (num3 >= array.Length)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 9;
				case 7:
					{
						P_0.DrawLines(flag ? xPen : xPen2, (Point[])eRileobygn6FStMlhv99(list));
						list.Clear();
						return;
					}
					IL_040a:
					flag = flag2;
					num2 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 15;
					}
					continue;
					IL_06c2:
					if (num6 >= array.Length)
					{
						num2 = 21;
						continue;
					}
					goto case 27;
					IL_03e3:
					array2 = zc0rgfbyscoaK3liaLt7(P_1.UserData, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-165474503 ^ -165537609)) as bool[];
					if (array2 == null)
					{
						list2 = new List<Point>();
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	private void f9B9rYE5E1C(DxVisualQueue P_0, IndicatorSeriesData P_1)
	{
		int num = 11;
		int num4 = default(int);
		int num6 = default(int);
		Point[] array = default(Point[]);
		bool flag = default(bool);
		XPen xPen2 = default(XPen);
		XPen xPen3 = default(XPen);
		int num7 = default(int);
		int num3 = default(int);
		XBrush xBrush = default(XBrush);
		XPen xPen = default(XPen);
		XBrush xBrush2 = default(XBrush);
		double num5 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					num4 = 0;
					goto case 1;
				case 11:
					goto end_IL_0012;
				case 5:
					num6 = (int)array[num4].Y;
					switch (P_1.Style.DotType)
					{
					case ChartSeriesDotStyle.Cross:
						goto IL_031d;
					case ChartSeriesDotStyle.Point:
						goto end_IL_0012_2;
					case ChartSeriesDotStyle.Circle:
						P_0.DrawEllipse(flag ? xPen2 : xPen3, new Point(num7, num6), num3, num3);
						break;
					}
					goto case 3;
				case 8:
					xBrush = new XBrush(P_1.Style.Color);
					xPen2 = new XPen(xBrush, xPen.Width, xPen.Style);
					xBrush2 = new XBrush(P_1.Style.Color2);
					xPen3 = new XPen(xBrush2, xPen.Width, VrcfIybyMBLuMl9sWqMd(xPen));
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					xPen = new XPen(new XBrush(P_1.Style.Color), P_1.Style.LineWidth, P_1.Style.LineStyle);
					num5 = AbUxuwbyLGFHrcaBMvAv(cas9rB9eYnI.ybUnYpBPWvT(), 0.0);
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					return;
				case 1:
					if (num4 >= array.Length)
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 2:
					if (((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).ColorSplit == ChartSeriesColorSplit.UpDownZero)
					{
						flag = array[num4].Y < num5;
						goto IL_020e;
					}
					goto case 4;
				case 3:
				case 9:
					num4++;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					num3 = Math.Max((int)(dy6XKZbyjqtalL99j1Sa(cas9rB9eYnI.T6NnYzm3A5s()) * cas9rB9eYnI.T6NnYzm3A5s().ColumnPercent / 2.0), 1);
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
					{
						num2 = 12;
					}
					continue;
				case 4:
					if (((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(P_1)).ColorSplit == ChartSeriesColorSplit.UpDown)
					{
						flag = ((num4 < array.Length - 1) ? (array[num4].Y < array[num4 + 1].Y) : flag);
					}
					goto IL_020e;
				case 6:
					goto IL_031d;
				case 13:
					break;
					IL_031d:
					PdEMdxbyOx4jgUE0PqZC(P_0, flag ? xPen2 : xPen3, num7 - num3, num6, num7 + num3 + 1, num6);
					P_0.DrawLine(flag ? xPen2 : xPen3, num7, num6 - num3, num7, num6 + num3 + 1);
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
					{
						num2 = 0;
					}
					continue;
					IL_020e:
					num7 = (int)array[num4].X;
					num2 = 5;
					continue;
					end_IL_0012_2:
					break;
				}
				P_0.FillEllipse(flag ? xBrush : xBrush2, new Point(num7, num6), num3, num3);
				num2 = 9;
				continue;
				end_IL_0012:
				break;
			}
			array = wSn9rvykN0C(P_1);
			num = 10;
		}
	}

	public void BQv9roCqTBM(IndicatorBase P_0, DxVisualQueue P_1)
	{
		IEnumerator<IndicatorSeriesData> enumerator = ((IndicatorSeries)tP6E9iby5gw7rMMqbwQM(P_0)).GetEnumerator();
		try
		{
			Point[] array = default(Point[]);
			int num3 = default(int);
			double num2 = default(double);
			List<Rect> list = default(List<Rect>);
			Rect[] rects = default(Rect[]);
			while (AKcPWsbyIiVZ4lN71FTZ(enumerator))
			{
				IndicatorSeriesData current = enumerator.Current;
				int num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
				{
					num = 4;
				}
				while (true)
				{
					switch (num)
					{
					case 6:
					{
						Point point = array[num3];
						if (!(num2 - point.X < 40.0))
						{
							list.Add(new Rect((int)(point.X - 3.0), (int)(point.Y - 3.0), 6.0, 6.0));
							num2 = point.X;
						}
						num3++;
						goto IL_01a7;
					}
					case 4:
						num3 = 0;
						goto IL_01a7;
					case 3:
						num2 = double.MaxValue;
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
						{
							num = 7;
						}
						continue;
					case 2:
						if (current.Style.Visible)
						{
							list = new List<Rect>();
							num = 3;
							continue;
						}
						break;
					case 7:
						array = wSn9rvykN0C(current);
						num = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
						{
							num = 3;
						}
						continue;
					case 5:
						if (!((IndicatorSeriesStyle)TmyUqYbySpZQtABnemTe(current)).DisableSelect)
						{
							num = 2;
							continue;
						}
						break;
					case 1:
						P_1.DrawRectangles(cas9rB9eYnI.Theme.ChartCpLinePen, rects);
						break;
					default:
						{
							rects = list.ToArray();
							P_1.FillRectangles(((ChartTheme)LpT2EebyqyJ4Sxt5GBtj(cas9rB9eYnI)).ChartCpFillBrush, rects);
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
							{
								num = 1;
							}
							continue;
						}
						IL_01a7:
						if (num3 >= array.Length)
						{
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 6;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
				int num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	private Point[] wSn9rvykN0C(IndicatorSeriesData P_0, string P_1 = null)
	{
		int num = 2;
		int num3 = default(int);
		int stop = default(int);
		double[] array2 = default(double[]);
		List<Point> list = default(List<Point>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					if (num3 < stop)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					if (double.IsNaN(array2[num3]))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 2:
					if (!ILs8nhbyWDEVNIPd5ctF(P_1))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = P_0.Data;
					break;
				case 4:
				{
					Point[] array = (Point[])eRileobygn6FStMlhv99(list);
					P_0.CachePoints(array, P_1);
					return array;
				}
				default:
					num3--;
					goto case 5;
				case 1:
					obj = zx7UBnbytOMY41GXsZ89(P_0, P_1);
					break;
				}
				array2 = (double[])obj;
				if (array2 == null)
				{
					return null;
				}
				int num4 = array2.Length - Math.Max(0, ((cqA0v8nB5WPCq4KbMXlc)F7i456byNc1ZPYXhBsiM(cas9rB9eYnI)).Start) - 1;
				stop = cas9rB9eYnI.T6NnYzm3A5s().Stop;
				list = new List<Point>(Math.Max(num4 - stop, 5));
				num3 = num4;
				num2 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			list.Add(new Point(SRaRXwbyU1UGieZwuDXy(F7i456byNc1ZPYXhBsiM(cas9rB9eYnI), num3), ((NMHchMnvtxgoKNmDEII2)L7r4C9byTYZuBmSDXnPf(cas9rB9eYnI)).A0PnvVYTtGb(array2[num3])));
			num = 3;
		}
	}

	static smVmOf9r0GqjHV49hQim()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void MvUMYHbyblVgcTpFqqiC()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool Ff9xZ8by41aYgTCbJuXT()
	{
		return VHTPSAbylfM20MpQmheU == null;
	}

	internal static smVmOf9r0GqjHV49hQim GESOPebyD9Z3xRlaordf()
	{
		return VHTPSAbylfM20MpQmheU;
	}

	internal static object F7i456byNc1ZPYXhBsiM(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).T6NnYzm3A5s();
	}

	internal static Rect YBc3gpbyk3MSJ75QkrJJ(object P_0)
	{
		return ((cqA0v8nB5WPCq4KbMXlc)P_0).Rect;
	}

	internal static object V6tQ6eby1VJDakRHKGOr(object P_0)
	{
		return ((ChartLevel)P_0).LinePen;
	}

	internal static object tP6E9iby5gw7rMMqbwQM(object P_0)
	{
		return ((IndicatorBase)P_0).Series;
	}

	internal static object TmyUqYbySpZQtABnemTe(object P_0)
	{
		return ((IndicatorSeriesData)P_0).Style;
	}

	internal static void JC1pNPbyxJls9N28681f(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static double AbUxuwbyLGFHrcaBMvAv(object P_0, double P_1)
	{
		return ((NMHchMnvtxgoKNmDEII2)P_0).A0PnvVYTtGb(P_1);
	}

	internal static object eX3f1CbyeI6opS3xaFRD(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object zc0rgfbyscoaK3liaLt7(object P_0, object P_1)
	{
		return ((Hashtable)P_0)[P_1];
	}

	internal static object XXkr1IbyXMDB1rruHFV0(object P_0)
	{
		return ((IndicatorSeriesData)P_0).UserData;
	}

	internal static int Td97wsbycwjAJvcvFEjh(object P_0, int P_1)
	{
		return ((cqA0v8nB5WPCq4KbMXlc)P_0).GetIndex(P_1);
	}

	internal static double dy6XKZbyjqtalL99j1Sa(object P_0)
	{
		return ((cqA0v8nB5WPCq4KbMXlc)P_0).ColumnWidth;
	}

	internal static void gqN39ibyEd9ZQDMEPGR1(object P_0)
	{
		((List<Point>)P_0).Clear();
	}

	internal static int yCtMw2byQDTX7s06kk3x(object P_0)
	{
		return ((List<Point>)P_0).Count;
	}

	internal static void FKBi1dbydkDG344n1w1E(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).FillPolygon((XBrush)P_1, (Point[])P_2);
	}

	internal static object eRileobygn6FStMlhv99(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}

	internal static void Q9ZW3cbyR7khiwJ3Vqlo(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).DrawLines((XPen)P_1, (Point[])P_2);
	}

	internal static bool ghaTG7by6SVDLnRr5TEb(XColor P_0, XColor P_1)
	{
		return P_0 != P_1;
	}

	internal static XDashStyle VrcfIybyMBLuMl9sWqMd(object P_0)
	{
		return ((XPen)P_0).Style;
	}

	internal static void PdEMdxbyOx4jgUE0PqZC(object P_0, object P_1, double P_2, double P_3, double P_4, double P_5)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3, P_4, P_5);
	}

	internal static object LpT2EebyqyJ4Sxt5GBtj(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).Theme;
	}

	internal static bool AKcPWsbyIiVZ4lN71FTZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool ILs8nhbyWDEVNIPd5ctF(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object zx7UBnbytOMY41GXsZ89(object P_0, object P_1)
	{
		return ((IndicatorSeriesData)P_0)[(string)P_1];
	}

	internal static double SRaRXwbyU1UGieZwuDXy(object P_0, int P_1)
	{
		return ((cqA0v8nB5WPCq4KbMXlc)P_0).GetX(P_1);
	}

	internal static object L7r4C9byTYZuBmSDXnPf(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).ybUnYpBPWvT();
	}
}
