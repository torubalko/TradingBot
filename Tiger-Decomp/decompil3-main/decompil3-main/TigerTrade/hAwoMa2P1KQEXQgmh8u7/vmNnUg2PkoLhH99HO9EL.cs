using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace hAwoMa2P1KQEXQgmh8u7;

internal sealed class vmNnUg2PkoLhH99HO9EL : ContentControl
{
	public static readonly DependencyProperty b9g2PdnvJRR;

	public static readonly DependencyProperty OdJ2PgqAaFr;

	private Border aF62PRDsMVa;

	private RectangleGeometry au92P6v7i0s;

	private ContentControl AT02PMZPWXg;

	private RectangleGeometry BHA2PObLe5x;

	private ContentControl Mb42PqImVSR;

	private RectangleGeometry yF92PIIIlyi;

	private ContentControl eT92PWSDrC1;

	private RectangleGeometry hio2PtgPfub;

	private ContentControl Uf72PUCRs7U;

	private static vmNnUg2PkoLhH99HO9EL sR9Pr2DGeBb5L3RQLiyr;

	[Description("Sets the corner radius on the border.")]
	[Category("Appearance")]
	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(b9g2PdnvJRR);
		}
		set
		{
			RVfssxDGjslgBC44nXWc(this, b9g2PdnvJRR, cornerRadius);
		}
	}

	[Description("Sets whether the content is clipped or not.")]
	[Category("Appearance")]
	public bool ClipContent
	{
		get
		{
			return (bool)GetValue(OdJ2PgqAaFr);
		}
		set
		{
			RVfssxDGjslgBC44nXWc(this, OdJ2PgqAaFr, flag);
		}
	}

	public vmNnUg2PkoLhH99HO9EL()
	{
		dQnTKRDGckaoyPd4ZsdI();
		base._002Ector();
		base.DefaultStyleKey = Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555149));
		base.SizeChanged += rEr2PeDE1cl;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void OnApplyTemplate()
	{
		R8UImuDGE5hRlNaJtkB6(this);
		aF62PRDsMVa = GetTemplateChild((string)rFk9ZlDGQohhZbydSN0f(-203064540 ^ -203058598)) as Border;
		eT92PWSDrC1 = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82882736)) as ContentControl;
		Uf72PUCRs7U = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999688882)) as ContentControl;
		Mb42PqImVSR = eRpUDoDGdPPspN03T8sW(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB1E464)) as ContentControl;
		int num = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				BHA2PObLe5x = GetTemplateChild((string)rFk9ZlDGQohhZbydSN0f(0x7394D272 ^ 0x739438A0)) as RectangleGeometry;
				au92P6v7i0s = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461944050)) as RectangleGeometry;
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num = 2;
				}
				continue;
			case 1:
				if (eT92PWSDrC1 != null)
				{
					num = 2;
					continue;
				}
				break;
			case 5:
				OdS2PSWILPU(ClipContent);
				Xyh2P5BNGiD(CornerRadius);
				return;
			case 2:
				eT92PWSDrC1.SizeChanged += oxK2PsaS6pd;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				AT02PMZPWXg = eRpUDoDGdPPspN03T8sW(this, rFk9ZlDGQohhZbydSN0f(-53782092 ^ -53758978)) as ContentControl;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num = 0;
				}
				continue;
			}
			yF92PIIIlyi = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225783643)) as RectangleGeometry;
			hio2PtgPfub = eRpUDoDGdPPspN03T8sW(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C122EC)) as RectangleGeometry;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
			{
				num = 4;
			}
		}
	}

	internal void Xyh2P5BNGiD(CornerRadius P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (au92P6v7i0s != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto IL_01a2;
			case 2:
			{
				RectangleGeometry bHA2PObLe5x = BHA2PObLe5x;
				double radiusX = (BHA2PObLe5x.RadiusY = P_0.BottomRight - Math.Min(base.BorderThickness.Right, base.BorderThickness.Bottom) / 2.0);
				bHA2PObLe5x.RadiusX = radiusX;
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 5:
			{
				RectangleGeometry rectangleGeometry2 = au92P6v7i0s;
				double radiusX;
				PK7V5sDG6EBMQbqCoxYb(au92P6v7i0s, radiusX = P_0.BottomLeft - Math.Min(base.BorderThickness.Bottom, base.BorderThickness.Left) / 2.0);
				rectangleGeometry2.RadiusX = radiusX;
				goto IL_01a2;
			}
			case 4:
				if (hio2PtgPfub != null)
				{
					RectangleGeometry rectangleGeometry3 = hio2PtgPfub;
					double radiusX;
					PK7V5sDG6EBMQbqCoxYb(hio2PtgPfub, radiusX = P_0.TopRight - xGyK8UDGRrW182hkJYeP(base.BorderThickness.Top, base.BorderThickness.Right) / 2.0);
					rectangleGeometry3.RadiusX = radiusX;
				}
				if (BHA2PObLe5x == null)
				{
					goto case 3;
				}
				goto case 2;
			default:
				aF62PRDsMVa.CornerRadius = P_0;
				goto IL_0192;
			case 1:
				{
					if (aF62PRDsMVa != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0192;
				}
				IL_01a2:
				UHA2PXPo6dW(new Size(base.ActualWidth, base.ActualHeight));
				return;
				IL_0192:
				if (yF92PIIIlyi != null)
				{
					RectangleGeometry rectangleGeometry = yF92PIIIlyi;
					double radiusX;
					PK7V5sDG6EBMQbqCoxYb(yF92PIIIlyi, radiusX = P_0.TopLeft - xGyK8UDGRrW182hkJYeP(DAuoKwDGgb1M52I6nqwM(this).Left, DAuoKwDGgb1M52I6nqwM(this).Top) / 2.0);
					rectangleGeometry.RadiusX = radiusX;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	internal void OdS2PSWILPU(bool P_0)
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					eT92PWSDrC1.Clip = null;
					num2 = 3;
					continue;
				case 3:
					if (Uf72PUCRs7U != null)
					{
						Uf72PUCRs7U.Clip = null;
					}
					if (Mb42PqImVSR != null)
					{
						Mb42PqImVSR.Clip = null;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				default:
					if (AT02PMZPWXg != null)
					{
						AT02PMZPWXg.Clip = null;
					}
					return;
				case 4:
					if (Mb42PqImVSR == null)
					{
						goto case 2;
					}
					Mb42PqImVSR.Clip = BHA2PObLe5x;
					num2 = 2;
					continue;
				case 5:
					AT02PMZPWXg.Clip = au92P6v7i0s;
					goto IL_00a7;
				case 6:
					if (eT92PWSDrC1 != null)
					{
						eT92PWSDrC1.Clip = yF92PIIIlyi;
					}
					if (Uf72PUCRs7U != null)
					{
						num = 8;
						break;
					}
					goto case 4;
				case 7:
					if (P_0)
					{
						num2 = 6;
						continue;
					}
					if (eT92PWSDrC1 != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 2:
					if (AT02PMZPWXg != null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_00a7;
				case 8:
					{
						Uf72PUCRs7U.Clip = hio2PtgPfub;
						num = 4;
						break;
					}
					IL_00a7:
					UHA2PXPo6dW(new Size(base.ActualWidth, bn1UBUDGM1Vp3CrKWVts(this)));
					return;
				}
				break;
			}
		}
	}

	private static void abw2PxLoEAa(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((vmNnUg2PkoLhH99HO9EL)P_0).Xyh2P5BNGiD((CornerRadius)P_1.NewValue);
	}

	private static void nHM2PLxy6Bn(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ho9VtBDGO6AZBeYvidCj((vmNnUg2PkoLhH99HO9EL)P_0, (bool)P_1.NewValue);
	}

	private void rEr2PeDE1cl(object P_0, SizeChangedEventArgs P_1)
	{
		if (ClipContent)
		{
			UHA2PXPo6dW(P_1.NewSize);
		}
	}

	private void oxK2PsaS6pd(object P_0, SizeChangedEventArgs P_1)
	{
		if (ClipContent)
		{
			UHA2PXPo6dW(new Size(ID8ZKpDGqMGWSM5SJc4H(this), base.ActualHeight));
		}
	}

	private void UHA2PXPo6dW(Size P_0)
	{
		int num;
		if (!(P_0.Width > 0.0))
		{
			if (P_0.Height > 0.0)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			return;
		}
		goto IL_00ba;
		IL_010f:
		double num2 = default(double);
		double num3 = default(double);
		if (BHA2PObLe5x != null)
		{
			BHA2PObLe5x.Rect = new Rect(0.0 - CornerRadius.BottomRight, 0.0 - CornerRadius.BottomRight, num2 + CornerRadius.BottomRight, num3 + CornerRadius.BottomRight);
		}
		if (au92P6v7i0s == null)
		{
			return;
		}
		goto IL_028e;
		IL_028e:
		au92P6v7i0s.Rect = new Rect(0.0, 0.0 - CornerRadius.BottomLeft, num2 + CornerRadius.BottomLeft, num3 + CornerRadius.BottomLeft);
		num = 5;
		goto IL_0009;
		IL_012e:
		yF92PIIIlyi.Rect = new Rect(0.0, 0.0, num2 + CornerRadius.TopLeft * 2.0, num3 + CornerRadius.TopLeft * 2.0);
		goto IL_00f6;
		IL_0009:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_00ba;
		default:
			goto IL_00f6;
		case 4:
			goto IL_012e;
		case 5:
			return;
		case 3:
			goto IL_028e;
		}
		butgNdDGWPRq66b4HXgk(hio2PtgPfub, new Rect(0.0 - CornerRadius.TopRight, 0.0, num2 + CornerRadius.TopRight, num3 + CornerRadius.TopRight));
		goto IL_010f;
		IL_00ba:
		num2 = smjcN7DGIQWBjRx98AmS(0.0, P_0.Width - base.BorderThickness.Left - base.BorderThickness.Right);
		num3 = Math.Max(0.0, P_0.Height - base.BorderThickness.Top - DAuoKwDGgb1M52I6nqwM(this).Bottom);
		if (yF92PIIIlyi == null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_012e;
		IL_00f6:
		if (hio2PtgPfub != null)
		{
			int num4 = 2;
			num = num4;
			goto IL_0009;
		}
		goto IL_010f;
	}

	static vmNnUg2PkoLhH99HO9EL()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		b9g2PdnvJRR = DependencyProperty.Register((string)rFk9ZlDGQohhZbydSN0f(0x706541F3 ^ 0x7065AADB), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777950)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555149)), new PropertyMetadata(abw2PxLoEAa));
		OdJ2PgqAaFr = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x73943936), Type.GetTypeFromHandle(BOZoyTDGtib9FiGm2mRi(16777221)), HjJNwUDGU0bEr61iG6rV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555149)), new PropertyMetadata(nHM2PLxy6Bn));
	}

	internal static void dQnTKRDGckaoyPd4ZsdI()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool pngV66DGs3mfBqYvyMPN()
	{
		return sR9Pr2DGeBb5L3RQLiyr == null;
	}

	internal static vmNnUg2PkoLhH99HO9EL mK1JYoDGX0uJ3Eennhjr()
	{
		return sR9Pr2DGeBb5L3RQLiyr;
	}

	internal static void RVfssxDGjslgBC44nXWc(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void R8UImuDGE5hRlNaJtkB6(object P_0)
	{
		((FrameworkElement)P_0).OnApplyTemplate();
	}

	internal static object rFk9ZlDGQohhZbydSN0f(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object eRpUDoDGdPPspN03T8sW(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static Thickness DAuoKwDGgb1M52I6nqwM(object P_0)
	{
		return ((Control)P_0).BorderThickness;
	}

	internal static double xGyK8UDGRrW182hkJYeP(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void PK7V5sDG6EBMQbqCoxYb(object P_0, double P_1)
	{
		((RectangleGeometry)P_0).RadiusY = P_1;
	}

	internal static double bn1UBUDGM1Vp3CrKWVts(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static void ho9VtBDGO6AZBeYvidCj(object P_0, bool P_1)
	{
		((vmNnUg2PkoLhH99HO9EL)P_0).OdS2PSWILPU(P_1);
	}

	internal static double ID8ZKpDGqMGWSM5SJc4H(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static double smjcN7DGIQWBjRx98AmS(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void butgNdDGWPRq66b4HXgk(object P_0, Rect P_1)
	{
		((RectangleGeometry)P_0).Rect = P_1;
	}

	internal static RuntimeTypeHandle BOZoyTDGtib9FiGm2mRi(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type HjJNwUDGU0bEr61iG6rV(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
