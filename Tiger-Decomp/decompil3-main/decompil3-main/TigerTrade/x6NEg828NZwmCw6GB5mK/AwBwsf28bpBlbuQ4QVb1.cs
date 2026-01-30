using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace x6NEg828NZwmCw6GB5mK;

internal sealed class AwBwsf28bpBlbuQ4QVb1 : FrameworkElement, INotifyPropertyChanged
{
	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	public static readonly DependencyProperty vvT28X2D5ms;

	internal static AwBwsf28bpBlbuQ4QVb1 Vg39sfDnM0YZUCTEnNOk;

	public FrameworkElement Element
	{
		get
		{
			return (FrameworkElement)iWnAtYDnW6P37F8BRtFM(this, vvT28X2D5ms);
		}
		set
		{
			O9jwKxDntXpXyRscjME4(this, vvT28X2D5ms, frameworkElement);
		}
	}

	public double ActualHeightValue => Element?.ActualHeight ?? 0.0;

	public double ActualWidthValue => Element?.ActualWidth ?? 0.0;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)XklSp7DnI3iOHko6oTe3(propertyChangedEventHandler2, propertyChangedEventHandler3);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	private static void LM128kkmmJq(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AwBwsf28bpBlbuQ4QVb1)P_0)?.iD9281iKqYS(P_1);
	}

	private void iD9281iKqYS(DependencyPropertyChangedEventArgs P_0)
	{
		int num = 2;
		int num2 = num;
		FrameworkElement frameworkElement = default(FrameworkElement);
		FrameworkElement frameworkElement2 = default(FrameworkElement);
		while (true)
		{
			switch (num2)
			{
			case 2:
				frameworkElement = (FrameworkElement)P_0.OldValue;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				frameworkElement2 = (FrameworkElement)P_0.NewValue;
				if (frameworkElement != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0067;
			case 3:
				return;
			default:
				{
					YMfNK6DnU3VxroQB0GX6(frameworkElement, new SizeChangedEventHandler(o6j285r25nY));
					goto IL_0067;
				}
				IL_0067:
				if (frameworkElement2 != null)
				{
					frameworkElement2.SizeChanged += o6j285r25nY;
				}
				W3U28S2bd82();
				num2 = 3;
				break;
			}
		}
	}

	private void o6j285r25nY(object P_0, SizeChangedEventArgs P_1)
	{
		W3U28S2bd82();
	}

	private void W3U28S2bd82()
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
				if (this.PropertyChanged != null)
				{
					this.PropertyChanged(this, new PropertyChangedEventArgs((string)Sbb2IpDnTfaY0SuqkjHw(-1461292091 ^ -1461283303)));
					this.PropertyChanged(this, new PropertyChangedEventArgs((string)Sbb2IpDnTfaY0SuqkjHw(0x4662F6AF ^ 0x466210AF)));
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public AwBwsf28bpBlbuQ4QVb1()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static AwBwsf28bpBlbuQ4QVb1()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				BSCRcfDnyw1n6YZcgpUD();
				vvT28X2D5ms = (DependencyProperty)utp2lRDnV6kKti5KDRmN(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673676953), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777265)), wBfoEnDnZmI2PHGIMYna(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555146)), new PropertyMetadata(null, LM128kkmmJq));
				return;
			}
		}
	}

	internal static bool oijmGODnOa7plUay2MDY()
	{
		return Vg39sfDnM0YZUCTEnNOk == null;
	}

	internal static AwBwsf28bpBlbuQ4QVb1 unSuWoDnqbmcMxW7P0mG()
	{
		return Vg39sfDnM0YZUCTEnNOk;
	}

	internal static object XklSp7DnI3iOHko6oTe3(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object iWnAtYDnW6P37F8BRtFM(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void O9jwKxDntXpXyRscjME4(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void YMfNK6DnU3VxroQB0GX6(object P_0, object P_1)
	{
		((FrameworkElement)P_0).SizeChanged -= (SizeChangedEventHandler)P_1;
	}

	internal static object Sbb2IpDnTfaY0SuqkjHw(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void BSCRcfDnyw1n6YZcgpUD()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Type wBfoEnDnZmI2PHGIMYna(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object utp2lRDnV6kKti5KDRmN(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
