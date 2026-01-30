using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using vJABeM28jRE76a9iLula;
using xfdMo0lS4TP9pN36Goka;

namespace fOrKkY2Pb8Ob9kOe7FaE;

internal sealed class EPOYK22PDIi5yRLYd4ub : rgMHiS28c6PxPCkpgqUg, IComponentConnector
{
	private bool qPX2PNsj1hn;

	internal static EPOYK22PDIi5yRLYd4ub CbhqExDGa7w5Wc8Fnsq5;

	protected override double Offset
	{
		get
		{
			return Canvas.GetLeft(base.SwitchThumb);
		}
		set
		{
			DCkgiMDGDONaTJNYgOE8(base.SwitchTrack, num);
			DCkgiMDGDONaTJNYgOE8(base.SwitchThumb, num);
		}
	}

	protected override PropertyPath SlidePropertyPath => new PropertyPath(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B3AD75));

	public EPOYK22PDIi5yRLYd4ub()
	{
		jLUphuDG4a9TPdHHH5JW();
		base._002Ector();
		base.DefaultStyleKey = Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555148));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void OnDragDelta(object P_0, DragDeltaEventArgs P_1)
	{
		yoe28ux6mVq(VGd28pey9DJ() + P_1.HorizontalChange);
		LP3ejSDGN2v5NNi52510(this, mWweZdDGbCFAtYuilsux(R2e28JdLXSy(), Math.Min(eJa288LUcCy(), VGd28pey9DJ())));
	}

	protected override void LayoutControls()
	{
		if (base.SwitchThumb == null)
		{
			return;
		}
		double num = default(double);
		while (true)
		{
			IL_0234:
			int num2;
			if (base.SwitchRoot != null)
			{
				num = base.SwitchThumb.ActualWidth + YwxstkDGkZo15M1wymoP(base.SwitchThumb).Left + base.SwitchThumb.BorderThickness.Right;
				if (base.SwitchChecked == null)
				{
					goto IL_00b4;
				}
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num2 = 4;
				}
			}
			else
			{
				num2 = 5;
			}
			goto IL_0009;
			IL_00b4:
			SEKkUYDGSubkKODSUE57(base.SwitchThumb, new Thickness(base.SwitchRoot.ActualWidth - num, jvy2TxDG5CJyRjMSgc8n(base.SwitchThumb).Top, 0.0, base.SwitchThumb.Margin.Bottom));
			xo328FLJG4y(0.0 - base.SwitchRoot.ActualWidth + num - base.SwitchThumb.BorderThickness.Left);
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
			{
				num2 = 0;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 3:
					SU0V4oDG1RuvBn1LgWuO(base.SwitchChecked, new Thickness(0.0, 0.0, (base.SwitchThumb.ActualWidth + base.SwitchThumb.BorderThickness.Left) / 2.0, 0.0));
					base.SwitchUnchecked.Padding = new Thickness((base.SwitchThumb.ActualWidth + base.SwitchThumb.BorderThickness.Right) / 2.0, 0.0, 0.0, 0.0);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					MJA28A1Vqey(base.SwitchThumb.BorderThickness.Right);
					if (!Gv82A0JPZe2())
					{
						LP3ejSDGN2v5NNi52510(this, base.IsChecked ? eJa288LUcCy() : R2e28JdLXSy());
						QaVlfFhUw1L(_0020: false);
					}
					return;
				case 1:
					break;
				case 4:
					if (base.SwitchUnchecked != null)
					{
						Control control = base.SwitchChecked;
						double width = (base.SwitchUnchecked.Width = Math.Max(0.0, base.SwitchRoot.ActualWidth - num / 2.0));
						control.Width = width;
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 5:
					return;
				case 2:
					goto IL_0234;
				}
				break;
			}
			goto IL_00b4;
		}
	}

	protected override void OnDragCompleted(object P_0, DragCompletedEventArgs P_1)
	{
		kSg2A2Q6NXI(_0020: false);
		bool flag = false;
		double num = base.SwitchThumb.ActualWidth + YwxstkDGkZo15M1wymoP(base.SwitchThumb).Left + base.SwitchThumb.BorderThickness.Right;
		int num2;
		if (base.IsChecked)
		{
			num2 = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
			{
				num2 = 4;
			}
			goto IL_0009;
		}
		if (!(VGd28pey9DJ() > (hMYXvADGxBQSqJPaxsQ4(base.SwitchRoot) - num) * (base.Elasticity - 1.0)))
		{
			goto IL_009a;
		}
		goto IL_0117;
		IL_024b:
		double num4;
		double num3 = num4;
		num2 = 7;
		goto IL_0009;
		IL_01c3:
		flag = true;
		goto IL_01fa;
		IL_0127:
		num4 = R2e28JdLXSy();
		goto IL_024b;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 4:
				break;
			case 7:
				if (Offset != num3)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto IL_01fa;
			case 3:
				goto IL_00d1;
			case 2:
				if (VGd28pey9DJ() != R2e28JdLXSy())
				{
					goto default;
				}
				goto IL_01c3;
			default:
				SOAYCfDGL20jJnEPVhhw(this, true);
				goto IL_01fa;
			case 1:
				return;
			case 9:
				goto IL_0117;
			case 8:
				goto IL_0127;
			case 6:
				flag = true;
				num2 = 5;
				continue;
			case 5:
				goto IL_01fa;
			}
			break;
		}
		goto IL_009a;
		IL_0117:
		if (!base.IsChecked)
		{
			goto IL_0127;
		}
		num4 = eJa288LUcCy();
		goto IL_024b;
		IL_009a:
		if (base.IsChecked && VGd28pey9DJ() < (base.SwitchRoot.ActualWidth - num) * (0.0 - base.Elasticity))
		{
			num2 = 9;
			goto IL_0009;
		}
		goto IL_00d1;
		IL_01fa:
		if (flag)
		{
			X7Z28gKxVjN();
		}
		yoe28ux6mVq(0.0);
		num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
		{
			num2 = 1;
		}
		goto IL_0009;
		IL_00d1:
		if (VGd28pey9DJ() != eJa288LUcCy())
		{
			num2 = 2;
			goto IL_0009;
		}
		goto IL_01c3;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
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
				if (!qPX2PNsj1hn)
				{
					qPX2PNsj1hn = true;
					Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D31D8A4), UriKind.Relative);
					Application.LoadComponent(this, resourceLocator);
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		qPX2PNsj1hn = true;
	}

	static EPOYK22PDIi5yRLYd4ub()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void jLUphuDG4a9TPdHHH5JW()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool UKK9MADGis7yZaJRQwp8()
	{
		return CbhqExDGa7w5Wc8Fnsq5 == null;
	}

	internal static EPOYK22PDIi5yRLYd4ub DoQ6uMDGlnBReJbmtopg()
	{
		return CbhqExDGa7w5Wc8Fnsq5;
	}

	internal static void DCkgiMDGDONaTJNYgOE8(object P_0, double P_1)
	{
		Canvas.SetLeft((UIElement)P_0, P_1);
	}

	internal static double mWweZdDGbCFAtYuilsux(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void LP3ejSDGN2v5NNi52510(object P_0, double P_1)
	{
		((rgMHiS28c6PxPCkpgqUg)P_0).Offset = P_1;
	}

	internal static Thickness YwxstkDGkZo15M1wymoP(object P_0)
	{
		return ((Control)P_0).BorderThickness;
	}

	internal static void SU0V4oDG1RuvBn1LgWuO(object P_0, Thickness P_1)
	{
		((Control)P_0).Padding = P_1;
	}

	internal static Thickness jvy2TxDG5CJyRjMSgc8n(object P_0)
	{
		return ((FrameworkElement)P_0).Margin;
	}

	internal static void SEKkUYDGSubkKODSUE57(object P_0, Thickness P_1)
	{
		((FrameworkElement)P_0).Margin = P_1;
	}

	internal static double hMYXvADGxBQSqJPaxsQ4(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static void SOAYCfDGL20jJnEPVhhw(object P_0, bool P_1)
	{
		((rgMHiS28c6PxPCkpgqUg)P_0).QaVlfFhUw1L(P_1);
	}
}
