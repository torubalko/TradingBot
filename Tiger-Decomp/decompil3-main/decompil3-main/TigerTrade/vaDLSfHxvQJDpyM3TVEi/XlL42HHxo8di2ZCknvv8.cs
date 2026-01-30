using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Docking;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace vaDLSfHxvQJDpyM3TVEi;

public class XlL42HHxo8di2ZCknvv8
{
	private static class ParentWindow
	{
		private static ParentWindow Qy5FZnNLMiX1UP88CoQn;

		public static void NO0nyxVIWcJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
		{
			int num = 1;
			int num2 = num;
			ButtonBase buttonBase = default(ButtonBase);
			while (true)
			{
				switch (num2)
				{
				default:
					if (buttonBase != null)
					{
						num2 = 3;
						break;
					}
					return;
				case 1:
					buttonBase = P_0 as ButtonBase;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					buttonBase.PreviewMouseLeftButtonUp -= faInyLENyEm;
					return;
				case 2:
					return;
				case 3:
					if (!(P_1.NewValue is DocumentWindow documentWindow) || buttonBase == null)
					{
						return;
					}
					if (documentWindow != null)
					{
						buttonBase.PreviewMouseLeftButtonUp += faInyLENyEm;
						return;
					}
					num2 = 4;
					break;
				}
			}
		}

		private static void faInyLENyEm(object P_0, MouseButtonEventArgs P_1)
		{
			int num;
			DocumentWindow documentWindow = default(DocumentWindow);
			if (!(P_0 is ButtonBase buttonBase))
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num = 0;
				}
			}
			else
			{
				documentWindow = (DocumentWindow)Y4gMswNLIPkSAoDghJLE(buttonBase);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 1;
				}
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				if (documentWindow != null)
				{
					documentWindow.IsActive = true;
				}
				break;
			}
		}

		static ParentWindow()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool UlT1cWNLOFGwuAOOP0gB()
		{
			return Qy5FZnNLMiX1UP88CoQn == null;
		}

		internal static ParentWindow SnE8QqNLqOSiwFD2GiLN()
		{
			return Qy5FZnNLMiX1UP88CoQn;
		}

		internal static object Y4gMswNLIPkSAoDghJLE(object P_0)
		{
			return GetParentWindow((UIElement)P_0);
		}
	}

	public static readonly DependencyProperty ParentWindowProperty;

	private static XlL42HHxo8di2ZCknvv8 iVHrXpDX6LS5a4R3sK97;

	public static DocumentWindow GetParentWindow(UIElement element)
	{
		return (DocumentWindow)element.GetValue(ParentWindowProperty);
	}

	public static void SetParentWindow(UIElement element, DocumentWindow value)
	{
		EyexgtDXqvdGIDxkS0Xk(element, ParentWindowProperty, value);
	}

	public XlL42HHxo8di2ZCknvv8()
	{
		EeDNLODXIsNiRCIDHSFo();
		base._002Ector();
	}

	static XlL42HHxo8di2ZCknvv8()
	{
		Xl212GDXWPeeXpQ5sWip();
		EeDNLODXIsNiRCIDHSFo();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ParentWindowProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624811873), txVFyNDXtqCeT1WAoa8c(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777442)), txVFyNDXtqCeT1WAoa8c(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555361)), new UIPropertyMetadata(null, ParentWindow.NO0nyxVIWcJ));
	}

	internal static bool XSNJFtDXMiOSsgLdZqBQ()
	{
		return iVHrXpDX6LS5a4R3sK97 == null;
	}

	internal static XlL42HHxo8di2ZCknvv8 ga3scGDXOQNbS58RXxWg()
	{
		return iVHrXpDX6LS5a4R3sK97;
	}

	internal static void EyexgtDXqvdGIDxkS0Xk(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void EeDNLODXIsNiRCIDHSFo()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void Xl212GDXWPeeXpQ5sWip()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static Type txVFyNDXtqCeT1WAoa8c(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
