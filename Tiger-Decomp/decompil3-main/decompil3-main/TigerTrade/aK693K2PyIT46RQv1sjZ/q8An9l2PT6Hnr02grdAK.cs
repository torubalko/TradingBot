using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace aK693K2PyIT46RQv1sjZ;

internal sealed class q8An9l2PT6Hnr02grdAK : ContentControl
{
	public static readonly DependencyProperty vpV2PuR7Aai;

	public static readonly DependencyProperty htY2Pzoi14g;

	public static readonly DependencyProperty yaC2J0q6m0b;

	public static readonly DependencyProperty fBN2J2hGq2t;

	public static readonly DependencyProperty fM92JHiq2nZ;

	public static readonly DependencyProperty JuH2Jf5uVAS;

	private Border Lar2J9Te3U8;

	private GradientStop lOs2JnuiZgg;

	private GradientStop oMJ2JGClgjv;

	private Border NhK2JYy3kyg;

	private GradientStop Xfp2JondkgR;

	private GradientStop qp52JvK6hFS;

	private Border zWV2JB1nyZV;

	private GradientStop YY02JawyQGY;

	private GradientStop VDw2JiT016b;

	private Border sGy2JlIKFWI;

	private GradientStop lWS2J44DJh0;

	private GradientStop esf2JDvhHRW;

	private static q8An9l2PT6Hnr02grdAK kVsVy6DGTvAqjElAo6Z9;

	[Category("Appearance")]
	[Description("Sets whether the content is clipped or not.")]
	public bool ClipContent
	{
		get
		{
			return (bool)GetValue(fM92JHiq2nZ);
		}
		set
		{
			SetValue(fM92JHiq2nZ, flag);
		}
	}

	[Description("Set 0 for behind the shadow, 1 for in front.")]
	[Category("Appearance")]
	public int ContentZIndex
	{
		get
		{
			return (int)WjV3J1DGrYsKKHyIu5PM(this, JuH2Jf5uVAS);
		}
		set
		{
			hpeOu2DGKrDKowDVLBf9(this, JuH2Jf5uVAS, num);
		}
	}

	[Category("Appearance")]
	[Description("The inner glow opacity.")]
	public double InnerGlowOpacity
	{
		get
		{
			return (double)GetValue(vpV2PuR7Aai);
		}
		set
		{
			hpeOu2DGKrDKowDVLBf9(this, vpV2PuR7Aai, num);
		}
	}

	[Category("Appearance")]
	[Description("The inner glow color.")]
	public Color InnerGlowColor
	{
		get
		{
			return (Color)GetValue(fBN2J2hGq2t);
		}
		set
		{
			SetValue(fBN2J2hGq2t, color);
		}
	}

	[Category("Appearance")]
	[Description("The inner glow size.")]
	public Thickness InnerGlowSize
	{
		get
		{
			return (Thickness)WjV3J1DGrYsKKHyIu5PM(this, htY2Pzoi14g);
		}
		set
		{
			SetValue(htY2Pzoi14g, thickness);
			IDt2PVNFwE0(thickness);
		}
	}

	[Category("Appearance")]
	[Description("Sets the corner radius on the border.")]
	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(yaC2J0q6m0b);
		}
		set
		{
			hpeOu2DGKrDKowDVLBf9(this, yaC2J0q6m0b, cornerRadius);
		}
	}

	public q8An9l2PT6Hnr02grdAK()
	{
		wK8beGDGVJuZPX7lLJTj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.DefaultStyleKey = iMxuSIDGCC4PtEFu0ZTF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555150));
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		NhK2JYy3kyg = N9nFEADGmpQOdA38SXXD(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741B6E95)) as Border;
		int num = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				sGy2JlIKFWI = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842035197)) as Border;
				zWV2JB1nyZV = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009577489)) as Border;
				Lar2J9Te3U8 = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839697638)) as Border;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num = 1;
				}
				break;
			case 5:
				return;
			case 2:
				Xfp2JondkgR = GetTemplateChild((string)vlygi6DGhPAMTs9SXvBK(0x404ED0BE ^ 0x404E3B64)) as GradientStop;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				qp52JvK6hFS = N9nFEADGmpQOdA38SXXD(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x1262EE6A)) as GradientStop;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num = 0;
				}
				break;
			default:
				lWS2J44DJh0 = GetTemplateChild((string)vlygi6DGhPAMTs9SXvBK(-1461949456 ^ -1461942310)) as GradientStop;
				esf2JDvhHRW = N9nFEADGmpQOdA38SXXD(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28B519A)) as GradientStop;
				YY02JawyQGY = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57776071)) as GradientStop;
				VDw2JiT016b = GetTemplateChild((string)vlygi6DGhPAMTs9SXvBK(0x2BD86B18 ^ 0x2BD887B8)) as GradientStop;
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				lOs2JnuiZgg = GetTemplateChild((string)vlygi6DGhPAMTs9SXvBK(-1251569705 ^ -1251581155)) as GradientStop;
				oMJ2JGClgjv = N9nFEADGmpQOdA38SXXD(this, vlygi6DGhPAMTs9SXvBK(-371631841 ^ -371608087)) as GradientStop;
				znw2PZFRRCF(InnerGlowColor);
				IDt2PVNFwE0(InnerGlowSize);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	internal void znw2PZFRRCF(Color P_0)
	{
		if (Xfp2JondkgR != null)
		{
			fWGUemDGwulw1hd5vDnE(Xfp2JondkgR, P_0);
		}
		if (qp52JvK6hFS != null)
		{
			qp52JvK6hFS.Color = Color.FromArgb(0, P_0.R, P_0.G, P_0.B);
		}
		if (lWS2J44DJh0 != null)
		{
			fWGUemDGwulw1hd5vDnE(lWS2J44DJh0, P_0);
		}
		int num;
		if (esf2JDvhHRW == null)
		{
			num = 4;
			goto IL_0009;
		}
		goto IL_0033;
		IL_0129:
		if (lOs2JnuiZgg != null)
		{
			num = 6;
			goto IL_0009;
		}
		goto IL_0169;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 4:
				goto IL_009e;
			case 2:
				VDw2JiT016b.Color = Color.FromArgb(0, P_0.R, P_0.G, P_0.B);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num = 0;
				}
				continue;
			default:
				goto IL_0129;
			case 3:
				return;
			case 6:
				goto IL_01c9;
			case 5:
				return;
			case 1:
				goto IL_01db;
			}
			break;
		}
		goto IL_0033;
		IL_01c9:
		lOs2JnuiZgg.Color = P_0;
		goto IL_0169;
		IL_0169:
		if (oMJ2JGClgjv != null)
		{
			oMJ2JGClgjv.Color = Color.FromArgb(0, P_0.R, P_0.G, P_0.B);
			num = 5;
		}
		else
		{
			num = 3;
		}
		goto IL_0009;
		IL_009e:
		if (YY02JawyQGY != null)
		{
			YY02JawyQGY.Color = P_0;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_01db;
		IL_0033:
		esf2JDvhHRW.Color = ioN5gpDG7omUWIX4EZ0H(0, P_0.R, P_0.G, P_0.B);
		goto IL_009e;
		IL_01db:
		if (VDw2JiT016b != null)
		{
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_0129;
	}

	internal void IDt2PVNFwE0(Thickness P_0)
	{
		int num;
		if (NhK2JYy3kyg != null)
		{
			mVPuqoDG8aq40c8AKlsJ(NhK2JYy3kyg, Math.Abs(P_0.Left));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_0095;
		IL_00d1:
		if (Lar2J9Te3U8 != null)
		{
			UPwyLVDGACmphGw7G3g9(Lar2J9Te3U8, Math.Abs(P_0.Bottom));
			num = 3;
			goto IL_0009;
		}
		return;
		IL_0009:
		switch (num)
		{
		case 1:
			goto IL_003f;
		case 2:
			goto IL_0095;
		case 3:
			return;
		}
		zWV2JB1nyZV.Width = Math.Abs(P_0.Right);
		goto IL_00d1;
		IL_0095:
		if (sGy2JlIKFWI != null)
		{
			sGy2JlIKFWI.Height = Math.Abs(P_0.Top);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_003f;
		IL_003f:
		if (zWV2JB1nyZV != null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00d1;
	}

	private static void JZ62PCcLxOj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_1.NewValue != null)
		{
			((q8An9l2PT6Hnr02grdAK)P_0).znw2PZFRRCF((Color)P_1.NewValue);
		}
	}

	private static void vFy2Pr1OmGs(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		UDq9qIDGPYok7kyi8sM5((q8An9l2PT6Hnr02grdAK)P_0, (Thickness)P_1.NewValue);
	}

	static q8An9l2PT6Hnr02grdAK()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				yaC2J0q6m0b = (DependencyProperty)JmYxEPDGFKHfK4kokYhH(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBE0119), iMxuSIDGCC4PtEFu0ZTF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777950)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555150)), null);
				num = 2;
				continue;
			case 2:
				fBN2J2hGq2t = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087071462), iMxuSIDGCC4PtEFu0ZTF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777498)), Type.GetTypeFromHandle(POoALDDGJiEXc341bprD(33555150)), new PropertyMetadata(Colors.Black, JZ62PCcLxOj));
				fM92JHiq2nZ = (DependencyProperty)JmYxEPDGFKHfK4kokYhH(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82883188), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555150)), null);
				JuH2Jf5uVAS = (DependencyProperty)JmYxEPDGFKHfK4kokYhH(vlygi6DGhPAMTs9SXvBK(-2123795572 ^ -2123784696), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777220)), iMxuSIDGCC4PtEFu0ZTF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555150)), null);
				return;
			}
			vpV2PuR7Aai = (DependencyProperty)JmYxEPDGFKHfK4kokYhH(vlygi6DGhPAMTs9SXvBK(0x22BF43FC ^ 0x22BFAEDE), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), iMxuSIDGCC4PtEFu0ZTF(POoALDDGJiEXc341bprD(33555150)), null);
			htY2Pzoi14g = (DependencyProperty)JmYxEPDGFKHfK4kokYhH(vlygi6DGhPAMTs9SXvBK(0x1487846E ^ 0x14876928), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777469)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555150)), new PropertyMetadata(vFy2Pr1OmGs));
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
			{
				num = 1;
			}
		}
	}

	internal static void wK8beGDGVJuZPX7lLJTj()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Type iMxuSIDGCC4PtEFu0ZTF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool on5UcxDGySBxx36j6XZg()
	{
		return kVsVy6DGTvAqjElAo6Z9 == null;
	}

	internal static q8An9l2PT6Hnr02grdAK tDq9ptDGZ8hRpxLsrDhP()
	{
		return kVsVy6DGTvAqjElAo6Z9;
	}

	internal static object WjV3J1DGrYsKKHyIu5PM(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void hpeOu2DGKrDKowDVLBf9(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object N9nFEADGmpQOdA38SXXD(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static object vlygi6DGhPAMTs9SXvBK(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void fWGUemDGwulw1hd5vDnE(object P_0, Color P_1)
	{
		((GradientStop)P_0).Color = P_1;
	}

	internal static Color ioN5gpDG7omUWIX4EZ0H(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static void mVPuqoDG8aq40c8AKlsJ(object P_0, double P_1)
	{
		((FrameworkElement)P_0).Width = P_1;
	}

	internal static void UPwyLVDGACmphGw7G3g9(object P_0, double P_1)
	{
		((FrameworkElement)P_0).Height = P_1;
	}

	internal static void UDq9qIDGPYok7kyi8sM5(object P_0, Thickness P_1)
	{
		((q8An9l2PT6Hnr02grdAK)P_0).IDt2PVNFwE0(P_1);
	}

	internal static RuntimeTypeHandle POoALDDGJiEXc341bprD(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object JmYxEPDGFKHfK4kokYhH(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
