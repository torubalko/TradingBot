using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using A6axDDGGKi8DOb3rxDca;
using BXtLF4GvnJ9TtDSoIul7;
using fy1P9eGGjfHerRf1cwlP;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using HUGc1iGvL73jwyqCtN04;
using JjJjx1GYyEvOhHsEBOTm;
using kvtsvxkNBA3S7tECx5XS;
using LckAIVGv1q9tlWqHdC7b;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using SharpDX.Mathematics.Interop;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace ddNSnhGYkKGW9Lm4Oywl;

internal sealed class CPkTtnGYNNH0uUfMa1Hu : qSYrroGYT8tn7ReR4NtK
{
	private readonly KQjLWWGv9T0awfEPv2fW iOXGYIAeV07;

	private readonly Dictionary<int, Brush> PvkGYWqSkVC;

	private readonly Dictionary<long, LinearGradientBrush> TPNGYtPMydH;

	private readonly Dictionary<int, StrokeStyle> Q0hGYUOwhca;

	private static CPkTtnGYNNH0uUfMa1Hu OTKMgkkcxewjcmrHhht6;

	public CPkTtnGYNNH0uUfMa1Hu(DxHwndHost P_0)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		iOXGYIAeV07 = KQjLWWGv9T0awfEPv2fW.wRWGvNkVkDn;
		PvkGYWqSkVC = new Dictionary<int, Brush>();
		TPNGYtPMydH = new Dictionary<long, LinearGradientBrush>();
		Q0hGYUOwhca = new Dictionary<int, StrokeStyle>();
		base._002Ector(P_0);
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_cca28d80996a4dc593cc44ee0d127763 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void Dispose(bool P_0)
	{
		if (!P_0)
		{
			goto IL_0039;
		}
		foreach (KeyValuePair<int, StrokeStyle> item in Q0hGYUOwhca)
		{
			StrokeStyle value = item.Value;
			int num;
			if (value == null)
			{
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_652fc2b610314371895a1e9f39a6e400 == 0)
				{
					num = 1;
				}
			}
			else
			{
				vmrXZakcsDr3PO6qWh9Z(value);
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_c2e150130d354ba88208e31c0cb582bd == 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			}
		}
		goto IL_005a;
		IL_0039:
		base.Dispose(P_0);
		int num2 = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dca72933032c4a8e93671b633cde2f65 == 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		goto IL_005a;
		IL_005a:
		Q0hGYUOwhca.Clear();
		goto IL_0039;
	}

	protected override void IWUlng7y0Qt()
	{
		int num = 1;
		int num2 = num;
		Dictionary<long, LinearGradientBrush>.Enumerator enumerator = default(Dictionary<long, LinearGradientBrush>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				snGLKxkcXY1QD1M5KCBP(TPNGYtPMydH);
				return;
			case 1:
				base.IWUlng7y0Qt();
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_753e5d00adac40c8a6cf262825555139 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						LinearGradientBrush value = enumerator.Current.Value;
						int num3;
						if (value == null)
						{
							num3 = 1;
							if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_fffeef8bf30940068c7f5d57542945e3 != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							value.Dispose();
							num3 = 0;
							if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71862513ffe24172acf3377a71840acf == 0)
							{
								num3 = 0;
							}
						}
						switch (num3)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 2;
			}
			foreach (KeyValuePair<int, Brush> item in PvkGYWqSkVC)
			{
				int num4 = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_b346e95202ab4f07b19d2078200795ad != 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
					{
						Brush value2 = item.Value;
						if (value2 == null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e8d7b488a32d4c69b9cf5d320391d7ff == 0)
							{
								num4 = 0;
							}
							continue;
						}
						vmrXZakcsDr3PO6qWh9Z(value2);
						break;
					}
					}
					break;
				}
			}
			PvkGYWqSkVC.Clear();
			enumerator = TPNGYtPMydH.GetEnumerator();
			num2 = 3;
		}
	}

	private static RawColor4 nkpGY1nHyUj(XColor P_0)
	{
		RawColor4 result = new RawColor4
		{
			R = P_0.R
		};
		int num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_0e903a952e504596afea640b11f01495 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return result;
			case 1:
				result.G = P_0.G;
				result.B = P_0.B;
				result.A = P_0.A;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_435adc9cca494f0c843e4414401f799f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private Brush iBVGY5KTi5v(XColor P_0)
	{
		int num = 1;
		int num2 = num;
		int hash = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!PvkGYWqSkVC.ContainsKey(hash))
				{
					SolidColorBrush solidColorBrush = new SolidColorBrush(pXTGYuCsJC7(), nkpGY1nHyUj(P_0));
					PvkGYWqSkVC.Add(hash, solidColorBrush);
					return solidColorBrush;
				}
				goto case 2;
			case 2:
				return PvkGYWqSkVC[hash];
			case 1:
				hash = P_0.Hash;
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dd9d08d16b46492585868817bd5b329f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Brush uYSGYSqgRQs(XColor P_0, XColor P_1, RawRectangleF P_2)
	{
		int hash = P_0.Hash;
		int hash2 = P_1.Hash;
		int num = ((hash << 5) + hash) ^ hash2;
		int num2 = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_2e105f252f2d4c3197f1ac87f7d5a037 != 0)
		{
			num2 = 0;
		}
		LinearGradientBrush linearGradientBrush = default(LinearGradientBrush);
		while (true)
		{
			switch (num2)
			{
			case 1:
				TPNGYtPMydH.Add(num, linearGradientBrush);
				return linearGradientBrush;
			}
			if (!TPNGYtPMydH.ContainsKey(num))
			{
				linearGradientBrush = new LinearGradientBrush(pXTGYuCsJC7(), new LinearGradientBrushProperties
				{
					StartPoint = new RawVector2(0f, P_2.Top),
					EndPoint = new RawVector2(0f, P_2.Bottom)
				}, new GradientStopCollection(pXTGYuCsJC7(), new GradientStop[2]
				{
					new GradientStop
					{
						Color = lRETKOkccQfH5ylUuIiJ(P_0),
						Position = 0f
					},
					new GradientStop
					{
						Color = lRETKOkccQfH5ylUuIiJ(P_1),
						Position = 1f
					}
				}));
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7e2cedcef3cc4cf38b7bccbb81c290d2 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			LinearGradientBrush linearGradientBrush2 = TPNGYtPMydH[num];
			linearGradientBrush2.StartPoint = new RawVector2(0f, P_2.Top);
			XI6keWkcjUBO3rXg2eO1(linearGradientBrush2, new RawVector2(0f, P_2.Bottom));
			return linearGradientBrush2;
		}
	}

	private StrokeStyle pF3GYxM1ybK(XDashStyle P_0)
	{
		if (Q0hGYUOwhca.ContainsKey((int)P_0))
		{
			return Q0hGYUOwhca[(int)P_0];
		}
		float[] dashes = new float[0];
		int num;
		StrokeStyle strokeStyle = default(StrokeStyle);
		StrokeStyleProperties properties = default(StrokeStyleProperties);
		float[] array2;
		switch (P_0)
		{
		case XDashStyle.Dot:
			dashes = new float[2] { 1f, 1f };
			num = 2;
			goto IL_0009;
		case XDashStyle.DashDot:
			goto IL_007c;
		case XDashStyle.Dash:
			goto IL_00d3;
		case XDashStyle.DashDotDot:
		{
			float[] array = new float[6];
			VwTRpIkcE2lT6SqnoVlH(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			dashes = array;
			goto IL_018b;
		}
		default:
			goto IL_018b;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 3:
					strokeStyle = new StrokeStyle(a8mGY7NyjDk(), properties, dashes);
					num = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_2e8ef27ff10e46d5944c0ff54cb39537 != 0)
					{
						num = 1;
					}
					continue;
				case 4:
					goto IL_007c;
				case 6:
					goto IL_00d3;
				case 1:
					Q0hGYUOwhca.Add((int)P_0, strokeStyle);
					return strokeStyle;
				case 2:
				case 5:
					goto IL_018b;
				}
				break;
			}
			goto case XDashStyle.Dot;
			IL_00d3:
			dashes = new float[2] { 3f, 1f };
			num = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f3975df1d3114c95b9c7e589d6efa4b4 == 0)
			{
				num = 5;
			}
			goto IL_0009;
			IL_018b:
			properties = new StrokeStyleProperties
			{
				DashStyle = ((P_0 != XDashStyle.Solid) ? DashStyle.Custom : DashStyle.Solid)
			};
			num = 3;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_0e903a952e504596afea640b11f01495 == 0)
			{
				num = 3;
			}
			goto IL_0009;
			IL_007c:
			array2 = new float[4];
			VwTRpIkcE2lT6SqnoVlH(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			dashes = array2;
			goto IL_018b;
		}
	}

	public void Clear(ie4WSIGGrGgj3Eas0lVN cmd)
	{
		pXTGYuCsJC7().Clear(lRETKOkccQfH5ylUuIiJ(cmd.Color));
	}

	public void byyGYLgoYUR(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		pXTGYuCsJC7().PushAxisAlignedClip(new RawRectangleF((float)P_0.Rect.Left, (float)P_0.Rect.Top, (float)P_0.Rect.Right, (float)P_0.Rect.Bottom), AntialiasMode.PerPrimitive);
	}

	public void oWwGYeRFch5()
	{
		pXTGYuCsJC7().PopAxisAlignedClip();
	}

	public void hmqGYscdSXT(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		int num = 1;
		int num2 = num;
		float num5 = default(float);
		float num6 = default(float);
		float num7 = default(float);
		float num3 = default(float);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				J1vZPTkcQUsAIt8WOLOt(pXTGYuCsJC7(), new RawVector2(num5, num6), new RawVector2(num7, num3), iBVGY5KTi5v(P_0.Color), num4, pF3GYxM1ybK((XDashStyle)P_0.Values[1]));
				return;
			default:
				num6 = (int)P_0.lfHGYYOZGMV.Y;
				num7 = (int)P_0.HEJGYo324So.X;
				num2 = 6;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71bb8832f147473987544a7fa3578a88 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				num6 += 0.5f;
				num3 += 0.5f;
				goto case 5;
			case 4:
				num3 += 0.5f;
				goto case 5;
			case 8:
				num7 += 0.5f;
				num2 = 4;
				break;
			case 2:
				if (num5 == num7)
				{
					num5 += 0.5f;
					num7 += 0.5f;
					goto case 5;
				}
				if (num6 == num3)
				{
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_666e548577c3487b8d80fc502bc2d890 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 3;
			case 1:
				num5 = (int)P_0.lfHGYYOZGMV.X;
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e5a530e2d830470f9256d2fc6fb06740 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				num3 = (int)P_0.HEJGYo324So.Y;
				num4 = (int)P_0.Values[0];
				if (num4 % 2 == 0)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 3:
				num5 += 0.5f;
				num6 += 0.5f;
				num2 = 8;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a88909e12c974739b0a37dd0a505569a != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public void bnTGYXGQrO6(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		int num = (int)P_0.Width;
		if (num % 2 != 0)
		{
			goto IL_00af;
		}
		float num2 = 0f;
		goto IL_00f0;
		IL_00af:
		num2 = 0.5f;
		goto IL_00f0;
		IL_00f0:
		float num3 = num2;
		pXTGYuCsJC7().DrawRectangle(new RawRectangleF((float)(int)P_0.Rect.Left + num3, (float)(int)P_0.Rect.Top + num3, (float)(int)P_0.Rect.Right + num3, (float)(int)P_0.Rect.Bottom + num3), iBVGY5KTi5v(P_0.Color), num, pF3GYxM1ybK(P_0.yvSGYGk77j1));
		int num4 = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_531e4724fc0841dbac11abf515e7fa5e != 0)
		{
			num4 = 0;
		}
		switch (num4)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		goto IL_00af;
	}

	public void S6qGYcn42rT(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		mDCakLkcdDQgDZnHcJkQ(pXTGYuCsJC7(), new RawRectangleF((int)P_0.Rect.Left, (int)P_0.Rect.Top, (int)P_0.Rect.Right, (int)P_0.Rect.Bottom), iBVGY5KTi5v(P_0.Color));
	}

	public void ryGGYjCr5n0(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		int num = 1;
		int num2 = num;
		RawRectangleF rawRectangleF = default(RawRectangleF);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Brush brush = uYSGYSqgRQs(P_0.Color, P_0.k4kGYntojO0, rawRectangleF);
				pXTGYuCsJC7().FillRectangle(rawRectangleF, brush);
				return;
			}
			case 1:
				rawRectangleF = new RawRectangleF((int)P_0.Values[0], (int)P_0.Values[1], (int)P_0.Values[2], (int)P_0.Values[3]);
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_531e4724fc0841dbac11abf515e7fa5e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void GByGYEsoJW5(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		int num = (int)P_0.Values[6];
		int num2;
		if (num % 2 != 0)
		{
			num2 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_4244154882d84aceb472cc9692dc853e != 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		float num3 = 0f;
		goto IL_00fd;
		IL_0009:
		float num4 = default(float);
		switch (num2)
		{
		case 1:
			pXTGYuCsJC7().DrawRoundedRectangle(new RoundedRectangle
			{
				RadiusX = (int)P_0.Values[4],
				RadiusY = (int)P_0.Values[5],
				Rect = new RawRectangleF((float)(int)P_0.Values[0] + num4, (float)(int)P_0.Values[1] + num4, (float)(int)P_0.Values[2] + num4, (float)(int)P_0.Values[3] + num4)
			}, iBVGY5KTi5v(P_0.Color), num, pF3GYxM1ybK((XDashStyle)P_0.Values[7]));
			return;
		}
		num3 = 0.5f;
		goto IL_00fd;
		IL_00fd:
		num4 = num3;
		num2 = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a88909e12c974739b0a37dd0a505569a == 0)
		{
			num2 = 1;
		}
		goto IL_0009;
	}

	public void MbrGYQLYkef(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		pXTGYuCsJC7().FillRoundedRectangle(new RoundedRectangle
		{
			RadiusX = (int)P_0.Values[4],
			RadiusY = (int)P_0.Values[5],
			Rect = new RawRectangleF((int)P_0.Values[0], (int)P_0.Values[1], (int)P_0.Values[2], (int)P_0.Values[3])
		}, iBVGY5KTi5v(P_0.Color));
	}

	public void XHiGYdL2arl(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		pXTGYuCsJC7().DrawEllipse(new Ellipse(new RawVector2((float)P_0.Points[0].X, (float)P_0.Points[0].Y), (float)P_0.Values[0], (float)P_0.Values[1]), iBVGY5KTi5v(P_0.Color), (float)P_0.Values[2], pF3GYxM1ybK((XDashStyle)P_0.Values[3]));
	}

	public void OPXGYgkWd7L(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		pXTGYuCsJC7().FillEllipse(new Ellipse(new RawVector2((float)P_0.Points[0].X, (float)P_0.Points[0].Y), (float)P_0.Values[0], (float)P_0.Values[1]), iBVGY5KTi5v(P_0.Color));
	}

	public void CdUGYRss5wF(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		int num = 3;
		int num2 = num;
		Point[] points = default(Point[]);
		int i = default(int);
		float num7 = default(float);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				int num3 = (P_0.J12GYBSctl0.HasValue ? P_0.J12GYBSctl0.Value : points.Length);
				if (num3 == 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_56b8b1a6026c4b1e82172f38beccbc71 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if ((int)P_0.Values[3] != 1)
				{
					PathGeometry pathGeometry = new PathGeometry(a8mGY7NyjDk());
					try
					{
						GeometrySink geometrySink = pathGeometry.Open();
						try
						{
							geometrySink.SetFillMode(FillMode.Winding);
							int num4 = (int)P_0.Values[1];
							int num5 = 2;
							while (true)
							{
								int num8;
								float num6;
								switch (num5)
								{
								case 3:
									pXTGYuCsJC7().DrawGeometry(pathGeometry, iBVGY5KTi5v(P_0.Color), num4, pF3GYxM1ybK((XDashStyle)P_0.Values[2]));
									return;
								case 4:
									for (; i < num3; i++)
									{
										PkEVRfkcR4kd4l101hUM(geometrySink, new RawVector2((float)(int)points[i].X + num7, (float)(int)points[i].Y + num7));
									}
									geometrySink.EndFigure((P_0.Values[0] > 0.0) ? FigureEnd.Closed : FigureEnd.Open);
									num5 = 0;
									if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dca72933032c4a8e93671b633cde2f65 == 0)
									{
										num5 = 0;
									}
									break;
								default:
									CUl0Iokc6IOsYoM2DAiM(geometrySink);
									num8 = 3;
									goto IL_0063;
								case 2:
									if (num4 % 2 != 0)
									{
										num5 = 1;
										if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71bb8832f147473987544a7fa3578a88 == 0)
										{
											num5 = 1;
										}
										break;
									}
									num6 = 0f;
									goto IL_01b7;
								case 5:
									ItfZN3kcgS3YESN6nLOL(geometrySink, new RawVector2((float)(int)points[0].X + num7, (float)(int)points[0].Y + num7), FigureBegin.Filled);
									i = 1;
									num5 = 4;
									break;
								case 1:
									{
										num6 = 0.5f;
										goto IL_01b7;
									}
									IL_0063:
									num5 = num8;
									break;
									IL_01b7:
									num7 = num6;
									num8 = 5;
									goto IL_0063;
								}
							}
						}
						finally
						{
							if (geometrySink != null)
							{
								TldZ30kcM3ZdMwHKXdOC(geometrySink);
							}
						}
					}
					finally
					{
						if (pathGeometry != null)
						{
							((IDisposable)pathGeometry).Dispose();
							int num9 = 0;
							if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f3975df1d3114c95b9c7e589d6efa4b4 == 0)
							{
								num9 = 0;
							}
							switch (num9)
							{
							case 0:
								break;
							}
						}
					}
				}
				num2 = 4;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f86e5f1f94bb473ea99521e551650092 == 0)
				{
					num2 = 4;
				}
				break;
			}
			case 4:
				uL5GY6dZa6E(P_0);
				return;
			case 3:
				points = P_0.Points;
				num2 = 2;
				break;
			case 1:
				return;
			}
		}
	}

	public void uL5GY6dZa6E(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		Point[] points = P_0.Points;
		int num;
		if (!P_0.J12GYBSctl0.HasValue)
		{
			num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_3eb68d8d5ff548b8b5f6ee0645c6cc4e == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		int num2 = P_0.J12GYBSctl0.Value;
		goto IL_036b;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		case 2:
			return;
		}
		num2 = points.Length;
		goto IL_036b;
		IL_036b:
		if (num2 != 0)
		{
			mwD4pdGGcMFACacSSkKW.RX6GGEKprXg(points, out var array, out var array2);
			using PathGeometry pathGeometry = new PathGeometry(a8mGY7NyjDk());
			using GeometrySink geometrySink = pathGeometry.Open();
			geometrySink.SetFillMode(FillMode.Winding);
			int num3 = (int)P_0.Values[1];
			int num4 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_074b09844c3c44949f01ad6af7266f45 == 0)
			{
				num4 = 1;
			}
			int num7 = default(int);
			float num6 = default(float);
			while (true)
			{
				float num5;
				switch (num4)
				{
				case 4:
					return;
				case 3:
					num7++;
					num4 = 2;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_05692657bf2742bd873f9ce176ecb3de == 0)
					{
						num4 = 0;
					}
					break;
				default:
					num5 = 0.5f;
					goto IL_0273;
				case 2:
					if (num7 >= array.Length)
					{
						ixwWDMkcqeluurZMFvj8(geometrySink, (P_0.Values[0] > 0.0) ? FigureEnd.Closed : FigureEnd.Open);
						geometrySink.Close();
						int num8 = 5;
						num4 = num8;
						break;
					}
					yirjRtkcOXgKs4vulrYf(geometrySink, new BezierSegment
					{
						Point1 = new RawVector2((float)(int)array[num7].X + num6, (float)(int)array[num7].Y + num6),
						Point2 = new RawVector2((float)(int)array2[num7].X + num6, (float)(int)array2[num7].Y + num6),
						Point3 = new RawVector2((float)(int)points[num7 + 1].X + num6, (float)(int)points[num7 + 1].Y + num6)
					});
					num4 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_81fc17157f934e0c8e49b4bbf662606f != 0)
					{
						num4 = 3;
					}
					break;
				case 1:
					if (num3 % 2 != 0)
					{
						num4 = 0;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9e61d8add8d44babb7ee69056242227b == 0)
						{
							num4 = 0;
						}
						break;
					}
					num5 = 0f;
					goto IL_0273;
				case 5:
					{
						YNRJcKkcI5ZqKEunxdoy(pXTGYuCsJC7(), pathGeometry, iBVGY5KTi5v(P_0.Color), num3, pF3GYxM1ybK((XDashStyle)P_0.Values[2]));
						num4 = 4;
						break;
					}
					IL_0273:
					num6 = num5;
					geometrySink.BeginFigure(new RawVector2((float)(int)points[0].X + num6, (float)(int)points[0].Y + num6), FigureBegin.Filled);
					num7 = 1;
					goto case 2;
				}
			}
		}
		num = 2;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_0dddf5ef66c34125ab2fb5b0d18a207d == 0)
		{
			num = 2;
		}
		goto IL_0009;
	}

	public void qLeGYMNgXo6(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		Point[] points = P_0.Points;
		int num = points.Length;
		int num2 = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f2d35f054791405bae489efb85a9f584 != 0)
		{
			num2 = 1;
		}
		switch (num2)
		{
		case 1:
		{
			if (num == 0)
			{
				break;
			}
			using PathGeometry pathGeometry = new PathGeometry(a8mGY7NyjDk());
			using GeometrySink geometrySink = pathGeometry.Open();
			WNGXBtkcWYURUwbT7Myc(geometrySink, FillMode.Winding);
			ItfZN3kcgS3YESN6nLOL(geometrySink, new RawVector2((int)points[0].X, (int)points[0].Y), FigureBegin.Filled);
			int num3 = 2;
			int num4 = num3;
			int num5 = default(int);
			while (true)
			{
				switch (num4)
				{
				default:
					if (num5 >= num)
					{
						ixwWDMkcqeluurZMFvj8(geometrySink, (P_0.Values[0] > 0.0) ? FigureEnd.Closed : FigureEnd.Open);
						geometrySink.Close();
						pXTGYuCsJC7().FillGeometry(pathGeometry, iBVGY5KTi5v(P_0.Color));
						return;
					}
					goto case 3;
				case 3:
					PkEVRfkcR4kd4l101hUM(geometrySink, new RawVector2((int)points[num5].X, (int)points[num5].Y));
					num4 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_92fde72072f340cbb1258afbb2ecb037 != 0)
					{
						num4 = 1;
					}
					break;
				case 2:
					num5 = 1;
					num4 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_432f46d1d7314c65a511e6124fe643b3 != 0)
					{
						num4 = 0;
					}
					break;
				case 1:
					num5++;
					goto default;
				}
			}
		}
		case 0:
			break;
		}
	}

	public void ea1GYOT4ZyA(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		PathGeometry pathGeometry = new PathGeometry(a8mGY7NyjDk());
		try
		{
			GeometrySink geometrySink = pathGeometry.Open();
			try
			{
				geometrySink.SetFillMode(FillMode.Winding);
				ItfZN3kcgS3YESN6nLOL(geometrySink, new RawVector2((float)P_0.Points[0].X, (float)P_0.Points[0].Y), FigureBegin.Filled);
				int num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a157e6a3d94947ada3590d3d2dc40b26 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						pXTGYuCsJC7().DrawGeometry(pathGeometry, iBVGY5KTi5v(P_0.Color), (float)P_0.Values[2], pF3GYxM1ybK((XDashStyle)P_0.Values[3]));
						return;
					}
					geometrySink.AddArc(new ArcSegment
					{
						ArcSize = ArcSize.Small,
						SweepDirection = SweepDirection.Clockwise,
						Point = new RawVector2((float)P_0.Points[1].X, (float)P_0.Points[1].Y),
						Size = new Size2F((float)P_0.Values[0], (float)P_0.Values[0]),
						RotationAngle = (float)P_0.Values[1]
					});
					geometrySink.EndFigure(FigureEnd.Open);
					geometrySink.Close();
					num = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e0ee3c5246e246ef83b092a6a8b64751 != 0)
					{
						num = 1;
					}
				}
			}
			finally
			{
				if (geometrySink != null)
				{
					geometrySink.Dispose();
					int num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_fe376b8d46434266b8f6bda07e258b46 != 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
			}
		}
		finally
		{
			if (pathGeometry != null)
			{
				TldZ30kcM3ZdMwHKXdOC(pathGeometry);
				int num3 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dfe9f5da877a401b848251d2d558dcec != 0)
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

	public void cxEGYqB71LI(ie4WSIGGrGgj3Eas0lVN P_0)
	{
		int num = 18;
		string text = default(string);
		short[] array = default(short[]);
		float[] array2 = default(float[]);
		FontFace fontFace = default(FontFace);
		XFont xuMGY9TDPbH = default(XFont);
		GnvxFqGvxtP2TADa1T12 gnvxFqGvxtP2TADa1T = default(GnvxFqGvxtP2TADa1T12);
		double num10 = default(double);
		int num8 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		rfemodGvkIb7bHow3Pkn rfemodGvkIb7bHow3Pkn2 = default(rfemodGvkIb7bHow3Pkn);
		double num6 = default(double);
		double num14 = default(double);
		double num5 = default(double);
		double num4 = default(double);
		double num7 = default(double);
		double num13 = default(double);
		int num12 = default(int);
		int num11 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return;
				case 19:
					return;
				case 10:
					text = P_0.Text;
					array = new short[m65vmPkcyRejJ0NVZnZS(text)];
					array2 = new float[text.Length];
					num2 = 6;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_fffeef8bf30940068c7f5d57542945e3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					fontFace = iOXGYIAeV07.GYJGvYymN3K(xuMGY9TDPbH);
					if (fontFace == null)
					{
						return;
					}
					gnvxFqGvxtP2TADa1T = (GnvxFqGvxtP2TADa1T12)o4AqMrkctaBDNFOhyHHZ(xuMGY9TDPbH);
					if (gnvxFqGvxtP2TADa1T != null)
					{
						num10 = 0.0;
						num2 = 12;
						continue;
					}
					num2 = 8;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ad54b84e60ad4cb5b706bdc362a3d52b != 0)
					{
						num2 = 7;
					}
					continue;
				case 16:
					if (num10 <= (double)num8)
					{
						int newSize = num3 + 1;
						Array.Resize(ref array, newSize);
						Array.Resize(ref array2, newSize);
						num2 = 0;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_d08a575fafb24367bc1d7d2b7222228c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 7:
					num8 = (int)P_0.Rect.Width;
					num9 = (int)P_0.Rect.Height;
					rfemodGvkIb7bHow3Pkn2 = (rfemodGvkIb7bHow3Pkn)iOxLrckcZn2aZ0RdOZTT(gnvxFqGvxtP2TADa1T, '…');
					num3 = 0;
					num2 = 13;
					continue;
				case 15:
					num6 += Math.Round(((double)num8 - num10) * 0.5);
					goto case 3;
				case 9:
					num3++;
					num2 = 21;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7e2cedcef3cc4cf38b7bccbb81c290d2 == 0)
					{
						num2 = 20;
					}
					continue;
				case 11:
					num10 += num14;
					num2 = 20;
					continue;
				case 1:
					num14 = rfemodGvkIb7bHow3Pkn2.GuRGv5Dp1By * num5;
					num2 = 11;
					continue;
				case 5:
					array2[num3] = (float)num4;
					num10 += num4;
					if (num10 > (double)num8)
					{
						num2 = 1;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_fe376b8d46434266b8f6bda07e258b46 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 3:
				{
					RenderTarget renderTarget = pXTGYuCsJC7();
					RawVector2 baselineOrigin = new RawVector2((int)num6, (int)num7 + 1);
					GlyphRun glyphRun = new GlyphRun();
					HvaxcUkcCFGePgZsbNwS(glyphRun, fontFace);
					VBXbmskcrjvnIQfNdc6a(glyphRun, array2);
					glyphRun.BidiLevel = 0;
					glyphRun.FontSize = xuMGY9TDPbH.Size;
					voIcymkcKMNIKPstiZe7(glyphRun, array);
					glyphRun.IsSideways = false;
					renderTarget.DrawGlyphRun(baselineOrigin, glyphRun, iBVGY5KTi5v(P_0.Color), MeasuringMode.GdiNatural);
					num2 = 19;
					continue;
				}
				case 12:
					num13 = gnvxFqGvxtP2TADa1T.wJRGvcBt7jF() * (double)M4NZ8gkcU5MKETfZsnW6(xuMGY9TDPbH);
					num5 = num13 / IhTG9GkcT8eHKLVVbtgR(gnvxFqGvxtP2TADa1T) - 0.2;
					num2 = 10;
					continue;
				default:
					array[num3] = rfemodGvkIb7bHow3Pkn2.Qo4GvSHe7Et;
					array2[num3] = (float)num14;
					num2 = 2;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3a78f5673ba492cb3624f6fd9b0982f != 0)
					{
						num2 = 4;
					}
					continue;
				case 14:
					num7 = (double)num12 + ((double)num9 / 2.0 + num13 / 2.0);
					switch (P_0.PUDGYvR0DO1)
					{
					case XTextAlignment.Center:
						num2 = 15;
						continue;
					case XTextAlignment.Right:
						num6 += (double)num8 - num10;
						num2 = 3;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_c2e150130d354ba88208e31c0cb582bd != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 3;
				case 20:
					num10 -= (double)array2[num3];
					num = 16;
					break;
				case 2:
					if (num3 == 0)
					{
						return;
					}
					num3--;
					goto case 20;
				case 6:
					num11 = (int)P_0.Rect.X;
					num12 = (int)P_0.Rect.Y;
					num2 = 7;
					continue;
				case 4:
					num6 = (double)num11 + 0.0;
					num = 14;
					break;
				case 18:
					xuMGY9TDPbH = P_0.XuMGY9TDPbH;
					num2 = 17;
					continue;
				case 13:
				case 21:
					if (num3 < text.Length)
					{
						rfemodGvkIb7bHow3Pkn rfemodGvkIb7bHow3Pkn = gnvxFqGvxtP2TADa1T.mUyGveoQMjN(AHXMi9kcVu92cHwDfUWW(text, num3));
						array[num3] = rfemodGvkIb7bHow3Pkn.Qo4GvSHe7Et;
						num4 = rfemodGvkIb7bHow3Pkn.GuRGv5Dp1By * num5 + (double)(xuMGY9TDPbH.Bold ? 1 : 0);
						num2 = 5;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_56b8b1a6026c4b1e82172f38beccbc71 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	static CPkTtnGYNNH0uUfMa1Hu()
	{
		M0BhsDkcmk77dpushiRJ();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool HZJUqkkcLhXQ4iMkQk7O()
	{
		return OTKMgkkcxewjcmrHhht6 == null;
	}

	internal static CPkTtnGYNNH0uUfMa1Hu UVwBYdkce7K8MYNNddFm()
	{
		return OTKMgkkcxewjcmrHhht6;
	}

	internal static void vmrXZakcsDr3PO6qWh9Z(object P_0)
	{
		((DisposeBase)P_0).Dispose();
	}

	internal static void snGLKxkcXY1QD1M5KCBP(object P_0)
	{
		((Dictionary<long, LinearGradientBrush>)P_0).Clear();
	}

	internal static RawColor4 lRETKOkccQfH5ylUuIiJ(XColor P_0)
	{
		return nkpGY1nHyUj(P_0);
	}

	internal static void XI6keWkcjUBO3rXg2eO1(object P_0, RawVector2 P_1)
	{
		((LinearGradientBrush)P_0).EndPoint = P_1;
	}

	internal static void VwTRpIkcE2lT6SqnoVlH(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static void J1vZPTkcQUsAIt8WOLOt(object P_0, RawVector2 P_1, RawVector2 P_2, object P_3, float P_4, object P_5)
	{
		((RenderTarget)P_0).DrawLine(P_1, P_2, (Brush)P_3, P_4, (StrokeStyle)P_5);
	}

	internal static void mDCakLkcdDQgDZnHcJkQ(object P_0, RawRectangleF P_1, object P_2)
	{
		((RenderTarget)P_0).FillRectangle(P_1, (Brush)P_2);
	}

	internal static void ItfZN3kcgS3YESN6nLOL(object P_0, RawVector2 P_1, FigureBegin P_2)
	{
		((SimplifiedGeometrySink)P_0).BeginFigure(P_1, P_2);
	}

	internal static void PkEVRfkcR4kd4l101hUM(object P_0, RawVector2 P_1)
	{
		((GeometrySink)P_0).AddLine(P_1);
	}

	internal static void CUl0Iokc6IOsYoM2DAiM(object P_0)
	{
		((SimplifiedGeometrySink)P_0).Close();
	}

	internal static void TldZ30kcM3ZdMwHKXdOC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void yirjRtkcOXgKs4vulrYf(object P_0, BezierSegment P_1)
	{
		((GeometrySink)P_0).AddBezier(P_1);
	}

	internal static void ixwWDMkcqeluurZMFvj8(object P_0, FigureEnd P_1)
	{
		((SimplifiedGeometrySink)P_0).EndFigure(P_1);
	}

	internal static void YNRJcKkcI5ZqKEunxdoy(object P_0, object P_1, object P_2, float P_3, object P_4)
	{
		((RenderTarget)P_0).DrawGeometry((Geometry)P_1, (Brush)P_2, P_3, (StrokeStyle)P_4);
	}

	internal static void WNGXBtkcWYURUwbT7Myc(object P_0, FillMode P_1)
	{
		((SimplifiedGeometrySink)P_0).SetFillMode(P_1);
	}

	internal static object o4AqMrkctaBDNFOhyHHZ(object P_0)
	{
		return ((XFont)P_0).Typeface;
	}

	internal static int M4NZ8gkcU5MKETfZsnW6(object P_0)
	{
		return ((XFont)P_0).Size;
	}

	internal static double IhTG9GkcT8eHKLVVbtgR(object P_0)
	{
		return ((GnvxFqGvxtP2TADa1T12)P_0).wJRGvcBt7jF();
	}

	internal static int m65vmPkcyRejJ0NVZnZS(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object iOxLrckcZn2aZ0RdOZTT(object P_0, char P_1)
	{
		return ((GnvxFqGvxtP2TADa1T12)P_0).mUyGveoQMjN(P_1);
	}

	internal static char AHXMi9kcVu92cHwDfUWW(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static void HvaxcUkcCFGePgZsbNwS(object P_0, object P_1)
	{
		((GlyphRun)P_0).FontFace = (FontFace)P_1;
	}

	internal static void VBXbmskcrjvnIQfNdc6a(object P_0, object P_1)
	{
		((GlyphRun)P_0).Advances = (float[])P_1;
	}

	internal static void voIcymkcKMNIKPstiZe7(object P_0, object P_1)
	{
		((GlyphRun)P_0).Indices = (short[])P_1;
	}

	internal static void M0BhsDkcmk77dpushiRJ()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}
}
