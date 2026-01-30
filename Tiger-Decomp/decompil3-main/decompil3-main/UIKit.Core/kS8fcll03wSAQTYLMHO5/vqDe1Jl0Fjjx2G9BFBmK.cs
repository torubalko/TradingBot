using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace kS8fcll03wSAQTYLMHO5;

public class vqDe1Jl0Fjjx2G9BFBmK
{
	public static readonly DependencyProperty PreventRightMouseButtonActionProperty;

	internal static vqDe1Jl0Fjjx2G9BFBmK a6WOluXaPqbkZkaV1h8s;

	public static void SetPreventRightMouseButtonAction(DependencyObject element, bool value)
	{
		element.SetValue(PreventRightMouseButtonActionProperty, value);
	}

	public static bool GetPreventRightMouseButtonAction(DependencyObject element)
	{
		return (bool)kXYVSCXa3hdEdl27MpkA(element, PreventRightMouseButtonActionProperty);
	}

	private static void N0Nl0p5TXiW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		UIElement uIElement = P_0 as UIElement;
		bool flag = uIElement != null;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_eb5248e0c761453cb12954b91b9ede6d == 0)
		{
			num = 2;
		}
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (flag2)
				{
					uIElement.PreviewMouseRightButtonUp += delegate(object obj, MouseButtonEventArgs e)
					{
						QKNyKhXi0gGFn83uhaxN(e, true);
					};
					return;
				}
				BOX6T5XapTORYH71RiNI(uIElement, (MouseButtonEventHandler)delegate(object obj, MouseButtonEventArgs e)
				{
					QKNyKhXi0gGFn83uhaxN(e, true);
				});
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_867f6430c8bf44129c7d3aede0ae7e7f == 0)
				{
					num = 0;
				}
				break;
			case 3:
			{
				bool flag3 = (bool)P_1.NewValue;
				flag2 = flag3;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_883f478e115e47949c2e3479fe99223e == 0)
				{
					num = 1;
				}
				break;
			}
			case 2:
				if (!flag)
				{
					return;
				}
				num = 3;
				break;
			}
		}
	}

	public vqDe1Jl0Fjjx2G9BFBmK()
	{
		HDQmKPXauUTClUL8jt8A();
		base._002Ector();
	}

	static vqDe1Jl0Fjjx2G9BFBmK()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8e3e4338deec43e48dad5ad47c3daa41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				PreventRightMouseButtonActionProperty = DependencyProperty.RegisterAttached(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x6D18F862 ^ 0x6D18F280), YvAc55Xaz6kKuFiTqvOg(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), YvAc55Xaz6kKuFiTqvOg(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554491)), new PropertyMetadata(false, N0Nl0p5TXiW));
				return;
			}
		}
	}

	[CompilerGenerated]
	internal static void rell0upMeEM(object P_0, MouseButtonEventArgs P_1)
	{
		QKNyKhXi0gGFn83uhaxN(P_1, true);
	}

	internal static bool ViQRmoXaJHIHAGQmQT5D()
	{
		return a6WOluXaPqbkZkaV1h8s == null;
	}

	internal static vqDe1Jl0Fjjx2G9BFBmK kF6HGaXaFgMUqSeiogau()
	{
		return a6WOluXaPqbkZkaV1h8s;
	}

	internal static object kXYVSCXa3hdEdl27MpkA(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void BOX6T5XapTORYH71RiNI(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewMouseRightButtonUp -= (MouseButtonEventHandler)P_1;
	}

	internal static void HDQmKPXauUTClUL8jt8A()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static Type YvAc55Xaz6kKuFiTqvOg(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void QKNyKhXi0gGFn83uhaxN(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}
}
