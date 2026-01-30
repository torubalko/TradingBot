using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace NTXvWAbI8ixQvDddFQJ;

public class IDaljVbqs0I3bBLcas3 : Panel
{
	private object lC1burpit4;

	private int W80bzt3wxA;

	private bool l3MN0JJ5Y4;

	private Storyboard NyUN2WsY34;

	private Storyboard MU0NHnvPif;

	private Storyboard aIXNfaDopK;

	private ContentControl yPkN91svlT;

	private ContentControl hHnNnp60Z0;

	private ContentControl U7TNG8Bo7u;

	private ContentControl kPrNYGQ3af;

	public static readonly DependencyProperty HdHNorfEAQ;

	public static readonly DependencyProperty Sy6NvdEYHv;

	internal static IDaljVbqs0I3bBLcas3 Yy6KQtlp04irw4YD4u7s;

	public WindowState ParentWindowState
	{
		get
		{
			return (WindowState)GetValue(HdHNorfEAQ);
		}
		set
		{
			saO3TxlpvXwd6SfyWDAX(this, HdHNorfEAQ, windowState);
		}
	}

	public object CurrentContent
	{
		get
		{
			return GetValue(Sy6NvdEYHv);
		}
		set
		{
			SetValue(Sy6NvdEYHv, value2);
		}
	}

	public IDaljVbqs0I3bBLcas3()
	{
		g8FSTRlpfYG8YoQPl8Sm();
		base._002Ector();
		yPkN91svlT = new ContentControl
		{
			Focusable = false,
			Opacity = 0.0,
			Name = (string)yrCRuylp9DYd98RXToNL(0x1D7BA1ED ^ 0x1D7B9137)
		};
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				kPrNYGQ3af = hHnNnp60Z0;
				base.Loaded += GN9bhO3OIv;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
				{
					num = 1;
				}
				break;
			case 3:
			{
				ContentControl contentControl = new ContentControl();
				cCn1TZlpnaq6XPwVdIsa(contentControl, false);
				Axmf7LlpG6n0ixbEcvwQ(contentControl, 0.0);
				contentControl.Name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315A8113);
				hHnNnp60Z0 = contentControl;
				dOdj4ilpY98bYyCqw6vs(base.Children, yPkN91svlT);
				num = 2;
				break;
			}
			case 1:
				return;
			case 2:
				((UIElementCollection)JVLfhjlpof5s96ae65lr(this)).Add((UIElement)hHnNnp60Z0);
				U7TNG8Bo7u = yPkN91svlT;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static void PXwbW8bFrE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is IDaljVbqs0I3bBLcas3 daljVbqs0I3bBLcas && daljVbqs0I3bBLcas.lC1burpit4 != P_1.NewValue)
		{
			dEhwJ3lpBPVRPQYIlJNL(daljVbqs0I3bBLcas, P_1.NewValue);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
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

	private void hk6btMZRll()
	{
		rImbU2ocuO();
		Size size = kPrNYGQ3af.DesiredSize;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
		{
			num = 0;
		}
		DoubleAnimation doubleAnimation = default(DoubleAnimation);
		DoubleAnimation doubleAnimation2 = default(DoubleAnimation);
		ContentControl u7TNG8Bo7u = default(ContentControl);
		while (true)
		{
			switch (num)
			{
			case 4:
				U7TNG8Bo7u = kPrNYGQ3af;
				num = 3;
				break;
			case 8:
				return;
			case 7:
				px1VSYlp1wYVTU8ZJfKu(M63F9dlpk0DeleyY3E2Y(MU0NHnvPif), doubleAnimation);
				MU0NHnvPif.Children.Add(doubleAnimation2);
				MU0NHnvPif.Completed += GZxbTq2Uj0;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num = 1;
				}
				break;
			case 6:
			{
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(FrameworkElement.WidthProperty));
				DoubleAnimation obj2 = new DoubleAnimation
				{
					From = base.ActualHeight
				};
				size = kPrNYGQ3af.DesiredSize;
				obj2.To = size.Height;
				uOrvuGlpN7d7f9GLm4Zw(obj2, TimeSpan.FromMilliseconds(250.0));
				doubleAnimation2 = obj2;
				Storyboard.SetTarget(doubleAnimation2, this);
				Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(FrameworkElement.HeightProperty));
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
				{
					num = 7;
				}
				break;
			}
			case 3:
				kPrNYGQ3af = u7TNG8Bo7u;
				num = 5;
				break;
			case 1:
				iYH0eBlp5AruQXiqhJnl(Dispatcher.CurrentDispatcher, DispatcherPriority.Render, (Action)delegate
				{
					MU0NHnvPif.Begin();
				});
				return;
			default:
				if (!(size.Width < 1.0))
				{
					size = kPrNYGQ3af.DesiredSize;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num = 0;
					}
					break;
				}
				goto IL_01d6;
			case 5:
				U7TNG8Bo7u.Opacity = 1.0;
				U7TNG8Bo7u.Visibility = Visibility.Visible;
				InvalidateMeasure();
				bDrkuFlplUX1geob8Qlp(this);
				num = 8;
				break;
			case 2:
				if (!(size.Height < 1.0))
				{
					MU0NHnvPif = new Storyboard();
					num = 9;
					break;
				}
				goto IL_01d6;
			case 9:
				{
					DoubleAnimation obj = new DoubleAnimation
					{
						From = YYU1lclp4O6VqcACDGFe(this)
					};
					size = EA7M8SlpD02LqbLl9mUM(kPrNYGQ3af);
					obj.To = size.Width;
					obj.Duration = FldavjlpbYGAGcB9G1EN(TimeSpan.FromMilliseconds(250.0));
					doubleAnimation = obj;
					Storyboard.SetTarget(doubleAnimation, this);
					num = 6;
					break;
				}
				IL_01d6:
				kPrNYGQ3af.Measure(new Size(IxYDqslpaCJIsJ47JDKN(this), Y7hlLdlpiMJmC0aTetEo(this)));
				u7TNG8Bo7u = U7TNG8Bo7u;
				num = 4;
				break;
			}
		}
	}

	private void rImbU2ocuO()
	{
		MU0NHnvPif?.Stop();
	}

	private void GZxbTq2Uj0(object P_0, EventArgs P_1)
	{
		ContentControl u7TNG8Bo7u = U7TNG8Bo7u;
		U7TNG8Bo7u = kPrNYGQ3af;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				kPrNYGQ3af = u7TNG8Bo7u;
				U7TNG8Bo7u.Visibility = Visibility.Visible;
				InvalidateMeasure();
				bDrkuFlplUX1geob8Qlp(this);
				MU0NHnvPif.FillBehavior = FillBehavior.Stop;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
			{
				Kuqbycm7av();
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	private void Kuqbycm7av()
	{
		rwXbZWxK81();
		aIXNfaDopK = new Storyboard();
		int num = 2;
		DoubleAnimation doubleAnimation = default(DoubleAnimation);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Storyboard.SetTarget(doubleAnimation, U7TNG8Bo7u);
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
				DcDAF6lpLjC1wQ6Bxcah(aIXNfaDopK, new EventHandler(UbIbVrY1nx));
				aIXNfaDopK.Children.Add(doubleAnimation);
				((Dispatcher)AKpssUlpee54Vxr0pxCu()).Invoke(DispatcherPriority.Render, (Delegate)(Action)delegate
				{
					d5s0CBlp66G8M4BTLu4y(aIXNfaDopK);
				});
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
			{
				DoubleAnimation obj = new DoubleAnimation
				{
					From = 0.0,
					To = 1.0
				};
				uOrvuGlpN7d7f9GLm4Zw(obj, TimeSpan.FromMilliseconds(175.0));
				QuinticEase quinticEase = new QuinticEase();
				dgnXUxlpSre8si03MG5i(quinticEase, EasingMode.EaseOut);
				jtqmjFlpxCXJ9qJ7jtxx(obj, quinticEase);
				doubleAnimation = obj;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
				{
					num = 1;
				}
				break;
			}
			}
		}
	}

	private void rwXbZWxK81()
	{
		Storyboard storyboard = aIXNfaDopK;
		if (storyboard != null)
		{
			Nbvh46lpsKiQAEmp6Cy6(storyboard);
		}
	}

	private void UbIbVrY1nx(object P_0, EventArgs P_1)
	{
		l3MN0JJ5Y4 = false;
		aIXNfaDopK.FillBehavior = FillBehavior.Stop;
	}

	private void uqkbCUp9O1()
	{
		int num = 4;
		int num2 = num;
		double num3 = default(double);
		DoubleAnimation doubleAnimation = default(DoubleAnimation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = ((U7TNG8Bo7u.Content == null) ? 0.0 : 175.0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
				NyUN2WsY34 = new Storyboard();
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				do7bKisVVj();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				NyUN2WsY34.Children.Add(doubleAnimation);
				NyUN2WsY34.Completed += Iv1brO2Nb6;
				iYH0eBlp5AruQXiqhJnl(Dispatcher.CurrentDispatcher, DispatcherPriority.Render, (Action)delegate
				{
					d5s0CBlp66G8M4BTLu4y(NyUN2WsY34);
				});
				return;
			case 4:
				l3MN0JJ5Y4 = true;
				num2 = 3;
				continue;
			}
			DoubleAnimation obj = new DoubleAnimation
			{
				From = 1.0,
				To = 0.0
			};
			uOrvuGlpN7d7f9GLm4Zw(obj, Sq23QclpX6Z19DIINP7T(num3));
			obj.EasingFunction = new QuinticEase
			{
				EasingMode = EasingMode.EaseOut
			};
			doubleAnimation = obj;
			Storyboard.SetTarget(doubleAnimation, U7TNG8Bo7u);
			num2 = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
			{
				num2 = 5;
			}
		}
	}

	private void Iv1brO2Nb6(object P_0, EventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pMMULZlpc9SX5orKNqeN(U7TNG8Bo7u, Visibility.Hidden);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				pK0pM8lpjga97oIWo1G3(NyUN2WsY34, FillBehavior.Stop);
				hk6btMZRll();
				return;
			}
		}
	}

	private void do7bKisVVj()
	{
		Storyboard nyUN2WsY = NyUN2WsY34;
		if (nyUN2WsY != null)
		{
			Nbvh46lpsKiQAEmp6Cy6(nyUN2WsY);
		}
	}

	private void SvYbm4X448(object P_0)
	{
		int num;
		if (l3MN0JJ5Y4)
		{
			do7bKisVVj();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0066;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				rImbU2ocuO();
				rwXbZWxK81();
				l3MN0JJ5Y4 = false;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				break;
			case 1:
				kPrNYGQ3af.Content = P_0;
				uqkbCUp9O1();
				return;
			}
			break;
		}
		goto IL_0066;
		IL_0066:
		kPrNYGQ3af.Visibility = Visibility.Hidden;
		num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		Size size = new Size(base.MaxWidth, base.MaxHeight);
		yPkN91svlT.Measure(size);
		a9XtIZlpEOtqcPnDtSwf(hHnNnp60Z0, size);
		Size desiredSize = U7TNG8Bo7u.DesiredSize;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => new Size(desiredSize.Width, U7TNG8Bo7u.DesiredSize.Height), 
		};
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		double x = (P_0.Width - U7TNG8Bo7u.DesiredSize.Width) / 2.0;
		double y = (P_0.Height - U7TNG8Bo7u.DesiredSize.Height) / 2.0;
		U7TNG8Bo7u.Arrange(new Rect(x, y, U7TNG8Bo7u.DesiredSize.Width, U7TNG8Bo7u.DesiredSize.Height));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => base.ArrangeOverride(P_0), 
		};
	}

	private void GN9bhO3OIv(object P_0, RoutedEventArgs P_1)
	{
		if (CurrentContent != null && yPkN91svlT.Content == null && hHnNnp60Z0.Content == null)
		{
			SvYbm4X448(CurrentContent);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
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

	static IDaljVbqs0I3bBLcas3()
	{
		V4MNxIlpQVNZXRjcW9iF();
		g8FSTRlpfYG8YoQPl8Sm();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		HdHNorfEAQ = (DependencyProperty)Em4wx3lpRhWgFIQaQm2k(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28B8CCC), Type.GetTypeFromHandle(G8IlRrlpd3CE6OVBE5wp(16777414)), VnMsevlpgdZq2bGXE67f(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554612)), new PropertyMetadata(WindowState.Normal));
		Sy6NvdEYHv = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F4267), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554612)), new PropertyMetadata(null, PXwbW8bFrE));
	}

	[CompilerGenerated]
	private void i39bwkvSPl()
	{
		MU0NHnvPif.Begin();
	}

	[CompilerGenerated]
	private void j7cb7LQBOs()
	{
		d5s0CBlp66G8M4BTLu4y(aIXNfaDopK);
	}

	[CompilerGenerated]
	private void C6Sb8uYnOR()
	{
		d5s0CBlp66G8M4BTLu4y(NyUN2WsY34);
	}

	internal static void g8FSTRlpfYG8YoQPl8Sm()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object yrCRuylp9DYd98RXToNL(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void cCn1TZlpnaq6XPwVdIsa(object P_0, bool P_1)
	{
		((UIElement)P_0).Focusable = P_1;
	}

	internal static void Axmf7LlpG6n0ixbEcvwQ(object P_0, double P_1)
	{
		((UIElement)P_0).Opacity = P_1;
	}

	internal static int dOdj4ilpY98bYyCqw6vs(object P_0, object P_1)
	{
		return ((UIElementCollection)P_0).Add((UIElement)P_1);
	}

	internal static object JVLfhjlpof5s96ae65lr(object P_0)
	{
		return ((Panel)P_0).Children;
	}

	internal static bool kdwP2wlp2y4QpgZ2xSid()
	{
		return Yy6KQtlp04irw4YD4u7s == null;
	}

	internal static IDaljVbqs0I3bBLcas3 tjuqyrlpHA786OWneN6B()
	{
		return Yy6KQtlp04irw4YD4u7s;
	}

	internal static void saO3TxlpvXwd6SfyWDAX(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void dEhwJ3lpBPVRPQYIlJNL(object P_0, object P_1)
	{
		((IDaljVbqs0I3bBLcas3)P_0).SvYbm4X448(P_1);
	}

	internal static double IxYDqslpaCJIsJ47JDKN(object P_0)
	{
		return ((FrameworkElement)P_0).MaxWidth;
	}

	internal static double Y7hlLdlpiMJmC0aTetEo(object P_0)
	{
		return ((FrameworkElement)P_0).MaxHeight;
	}

	internal static void bDrkuFlplUX1geob8Qlp(object P_0)
	{
		((UIElement)P_0).InvalidateArrange();
	}

	internal static double YYU1lclp4O6VqcACDGFe(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static Size EA7M8SlpD02LqbLl9mUM(object P_0)
	{
		return ((UIElement)P_0).DesiredSize;
	}

	internal static Duration FldavjlpbYGAGcB9G1EN(TimeSpan P_0)
	{
		return P_0;
	}

	internal static void uOrvuGlpN7d7f9GLm4Zw(object P_0, Duration P_1)
	{
		((Timeline)P_0).Duration = P_1;
	}

	internal static object M63F9dlpk0DeleyY3E2Y(object P_0)
	{
		return ((TimelineGroup)P_0).Children;
	}

	internal static void px1VSYlp1wYVTU8ZJfKu(object P_0, object P_1)
	{
		((TimelineCollection)P_0).Add((Timeline)P_1);
	}

	internal static object iYH0eBlp5AruQXiqhJnl(object P_0, DispatcherPriority P_1, object P_2)
	{
		return ((Dispatcher)P_0).Invoke(P_1, (Delegate)P_2);
	}

	internal static void dgnXUxlpSre8si03MG5i(object P_0, EasingMode P_1)
	{
		((EasingFunctionBase)P_0).EasingMode = P_1;
	}

	internal static void jtqmjFlpxCXJ9qJ7jtxx(object P_0, object P_1)
	{
		((DoubleAnimation)P_0).EasingFunction = (IEasingFunction)P_1;
	}

	internal static void DcDAF6lpLjC1wQ6Bxcah(object P_0, object P_1)
	{
		((Timeline)P_0).Completed += (EventHandler)P_1;
	}

	internal static object AKpssUlpee54Vxr0pxCu()
	{
		return Dispatcher.CurrentDispatcher;
	}

	internal static void Nbvh46lpsKiQAEmp6Cy6(object P_0)
	{
		((Storyboard)P_0).Stop();
	}

	internal static TimeSpan Sq23QclpX6Z19DIINP7T(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}

	internal static void pMMULZlpc9SX5orKNqeN(object P_0, Visibility P_1)
	{
		((UIElement)P_0).Visibility = P_1;
	}

	internal static void pK0pM8lpjga97oIWo1G3(object P_0, FillBehavior P_1)
	{
		((Timeline)P_0).FillBehavior = P_1;
	}

	internal static void a9XtIZlpEOtqcPnDtSwf(object P_0, Size P_1)
	{
		((UIElement)P_0).Measure(P_1);
	}

	internal static void V4MNxIlpQVNZXRjcW9iF()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static RuntimeTypeHandle G8IlRrlpd3CE6OVBE5wp(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type VnMsevlpgdZq2bGXE67f(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Em4wx3lpRhWgFIQaQm2k(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static void d5s0CBlp66G8M4BTLu4y(object P_0)
	{
		((Storyboard)P_0).Begin();
	}
}
