using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace CgILg72JN68wqv0TCnxE;

internal sealed class D8vrVv2Jba9l6mxIaRLq : ContentControl
{
	public static readonly DependencyProperty EU92JMEPupF;

	public static readonly DependencyProperty Obb2JO7aekZ;

	public static readonly DependencyProperty JcS2JqoUfIm;

	public static readonly DependencyProperty I7P2JIF6WbL;

	public static readonly DependencyProperty DrY2JWfEBAP;

	public static readonly DependencyProperty now2JtM4lNS;

	private Border y8o2JUErYcW;

	private GradientStop YGL2JTa1btc;

	private GradientStop wcB2JycI6ji;

	private GradientStop Mc12JZ9vbbP;

	private GradientStop LXJ2JVGu0Ap;

	private GradientStop ceS2JCmASrx;

	private GradientStop AOx2JrdLPuB;

	private static D8vrVv2Jba9l6mxIaRLq pYHPnGDG39Tqn9wvT9wb;

	[Description("Sets whether the content is clipped or not.")]
	[Category("Appearance")]
	public bool ClipContent
	{
		get
		{
			return (bool)OD2TqUDY0L7mCFXwB62T(this, now2JtM4lNS);
		}
		set
		{
			SetValue(now2JtM4lNS, flag);
		}
	}

	[Description("The outer glow opacity.")]
	[Category("Appearance")]
	public double OuterGlowOpacity
	{
		get
		{
			return (double)GetValue(EU92JMEPupF);
		}
		set
		{
			SetValue(EU92JMEPupF, num);
		}
	}

	[Description("The outer glow size.")]
	[Category("Appearance")]
	public double OuterGlowSize
	{
		get
		{
			return (double)GetValue(Obb2JO7aekZ);
		}
		set
		{
			oOv9xoDY2xsReCR8SEm0(this, Obb2JO7aekZ, num);
			sk72JkXopMT(OuterGlowSize);
			xxC2JxF7gCV(new Size(bCVU3iDYHy4aKT2wGXFf(this), base.ActualHeight));
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
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

	[Category("Appearance")]
	[Description("The outer glow color.")]
	public Color OuterGlowColor
	{
		get
		{
			return (Color)GetValue(DrY2JWfEBAP);
		}
		set
		{
			SetValue(DrY2JWfEBAP, color);
		}
	}

	[Description("Sets the corner radius on the border.")]
	[Category("Appearance")]
	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)OD2TqUDY0L7mCFXwB62T(this, JcS2JqoUfIm);
		}
		set
		{
			SetValue(JcS2JqoUfIm, cornerRadius);
			ShadowCornerRadius = new CornerRadius(s70oy2DYfo2Ur9pP9ZRZ(cornerRadius.TopLeft * 1.5), Math.Abs(cornerRadius.TopRight * 1.5), s70oy2DYfo2Ur9pP9ZRZ(cornerRadius.BottomRight * 1.5), Math.Abs(cornerRadius.BottomLeft * 1.5));
		}
	}

	[Description("Sets the corner radius on the border.")]
	[Category("Appearance")]
	public CornerRadius ShadowCornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(I7P2JIF6WbL);
		}
		set
		{
			oOv9xoDY2xsReCR8SEm0(this, I7P2JIF6WbL, cornerRadius);
		}
	}

	public D8vrVv2Jba9l6mxIaRLq()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.DefaultStyleKey = Type.GetTypeFromHandle(dhmB5VDGztS22LnbyN9I(33555151));
		base.SizeChanged += sh12JSo4skg;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Mc12JZ9vbbP = (GradientStop)QD4V6DDY9v49TWAV93nn(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161561160));
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				y8o2JUErYcW = (Border)GetTemplateChild((string)lXWtOMDYnDG4YDNgXfra(-1774602229 ^ -1774627139));
				sk72JkXopMT(OuterGlowSize);
				v7o2J1wJddr(OuterGlowColor);
				return;
			case 3:
				AOx2JrdLPuB = (GradientStop)GetTemplateChild((string)lXWtOMDYnDG4YDNgXfra(0x735715F1 ^ 0x7357FBDB));
				YGL2JTa1btc = (GradientStop)QD4V6DDY9v49TWAV93nn(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123749893));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				LXJ2JVGu0Ap = (GradientStop)QD4V6DDY9v49TWAV93nn(this, lXWtOMDYnDG4YDNgXfra(0x404ED0BE ^ 0x404E3D6E));
				ceS2JCmASrx = (GradientStop)GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D31D937));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num = 0;
				}
				break;
			default:
				wcB2JycI6ji = (GradientStop)GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962631049));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal void sk72JkXopMT(double P_0)
	{
		if (y8o2JUErYcW != null)
		{
			y8o2JUErYcW.Margin = new Thickness(0.0 - s70oy2DYfo2Ur9pP9ZRZ(P_0));
		}
	}

	internal void v7o2J1wJddr(Color P_0)
	{
		if (ceS2JCmASrx != null)
		{
			ceS2JCmASrx.Color = P_0;
		}
		if (AOx2JrdLPuB != null)
		{
			AOx2JrdLPuB.Color = P_0;
		}
		int num;
		if (Mc12JZ9vbbP != null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00e2;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				goto IL_0052;
			}
			break;
			IL_0052:
			McwDV8DYGYc0RlRIAbQf(LXJ2JVGu0Ap, Color.FromArgb(0, P_0.R, P_0.G, P_0.B));
			num = 2;
		}
		Mc12JZ9vbbP.Color = Color.FromArgb(0, P_0.R, P_0.G, P_0.B);
		goto IL_00e2;
		IL_00e2:
		if (LXJ2JVGu0Ap == null)
		{
			return;
		}
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	private static void h3y2J5DanXB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_1.NewValue != null)
		{
			((D8vrVv2Jba9l6mxIaRLq)P_0).v7o2J1wJddr((Color)P_1.NewValue);
		}
	}

	private void sh12JSo4skg(object P_0, SizeChangedEventArgs P_1)
	{
		xxC2JxF7gCV(P_1.NewSize);
	}

	private void xxC2JxF7gCV(Size P_0)
	{
		if (!(P_0.Width > 0.0) || !(P_0.Height > 0.0))
		{
			return;
		}
		int num;
		if (YGL2JTa1btc != null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_01b2;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				rL5dgFDYYv5n4MUxj7Tr(AOx2JrdLPuB, 1.0 - s70oy2DYfo2Ur9pP9ZRZ(OuterGlowSize) / (P_0.Height + Math.Abs(OuterGlowSize) + Math.Abs(OuterGlowSize)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
				{
					num = 3;
				}
				continue;
			case 3:
				return;
			case 1:
				YGL2JTa1btc.Offset = Math.Abs(OuterGlowSize) / (P_0.Width + Math.Abs(OuterGlowSize) + Math.Abs(OuterGlowSize));
				num = 2;
				continue;
			case 2:
				break;
			}
			break;
		}
		goto IL_01b2;
		IL_01b2:
		if (wcB2JycI6ji != null)
		{
			wcB2JycI6ji.Offset = 1.0 - Math.Abs(OuterGlowSize) / (P_0.Width + Math.Abs(OuterGlowSize) + Math.Abs(OuterGlowSize));
		}
		if (ceS2JCmASrx != null)
		{
			rL5dgFDYYv5n4MUxj7Tr(ceS2JCmASrx, s70oy2DYfo2Ur9pP9ZRZ(OuterGlowSize) / (P_0.Height + s70oy2DYfo2Ur9pP9ZRZ(OuterGlowSize) + s70oy2DYfo2Ur9pP9ZRZ(OuterGlowSize)));
		}
		if (AOx2JrdLPuB == null)
		{
			return;
		}
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	static D8vrVv2Jba9l6mxIaRLq()
	{
		LWxZ8pDYod0Z3PTAaiUc();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		EU92JMEPupF = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CDA1F7), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), OYShkZDYvVbiF1aMprmM(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555151)), null);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				Obb2JO7aekZ = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741B6ACD), Type.GetTypeFromHandle(dhmB5VDGztS22LnbyN9I(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555151)), null);
				JcS2JqoUfIm = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C9219), OYShkZDYvVbiF1aMprmM(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777950)), OYShkZDYvVbiF1aMprmM(dhmB5VDGztS22LnbyN9I(33555151)), null);
				I7P2JIF6WbL = DependencyProperty.Register((string)lXWtOMDYnDG4YDNgXfra(-1461292091 ^ -1461281567), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777950)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555151)), null);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				now2JtM4lNS = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127478896), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555151)), null);
				return;
			default:
				DrY2JWfEBAP = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404E3FF2), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777498)), OYShkZDYvVbiF1aMprmM(dhmB5VDGztS22LnbyN9I(33555151)), new PropertyMetadata(BnwJRTDYBJnmtsBOaZ6I(), h3y2J5DanXB));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static RuntimeTypeHandle dhmB5VDGztS22LnbyN9I(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static bool E2cGGsDGp2IDpXClnDS0()
	{
		return pYHPnGDG39Tqn9wvT9wb == null;
	}

	internal static D8vrVv2Jba9l6mxIaRLq bbwC6VDGunBuslXaeh7C()
	{
		return pYHPnGDG39Tqn9wvT9wb;
	}

	internal static object OD2TqUDY0L7mCFXwB62T(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void oOv9xoDY2xsReCR8SEm0(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static double bCVU3iDYHy4aKT2wGXFf(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static double s70oy2DYfo2Ur9pP9ZRZ(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object QD4V6DDY9v49TWAV93nn(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static object lXWtOMDYnDG4YDNgXfra(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void McwDV8DYGYc0RlRIAbQf(object P_0, Color P_1)
	{
		((GradientStop)P_0).Color = P_1;
	}

	internal static void rL5dgFDYYv5n4MUxj7Tr(object P_0, double P_1)
	{
		((GradientStop)P_0).Offset = P_1;
	}

	internal static void LWxZ8pDYod0Z3PTAaiUc()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static Type OYShkZDYvVbiF1aMprmM(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Color BnwJRTDYBJnmtsBOaZ6I()
	{
		return Colors.Black;
	}
}
