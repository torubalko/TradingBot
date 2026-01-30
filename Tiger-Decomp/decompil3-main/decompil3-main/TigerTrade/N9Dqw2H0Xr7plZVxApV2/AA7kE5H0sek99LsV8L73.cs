using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using MSuCo92zhmXaITw6ZG8X;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace N9Dqw2H0Xr7plZVxApV2;

internal class AA7kE5H0sek99LsV8L73 : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private Action<Color> m_OnPickColor;

	[CompilerGenerated]
	private bool tNYH0R4R23f;

	public Color dktH060FtqV;

	internal ItemsControl SwatchListBox;

	private bool FS8H0MEQ79L;

	private static AA7kE5H0sek99LsV8L73 IT31t5DasLAGmxJrGTDO;

	public bool Editable
	{
		[CompilerGenerated]
		get
		{
			return tNYH0R4R23f;
		}
		[CompilerGenerated]
		set
		{
			tNYH0R4R23f = flag;
		}
	}

	public event Action<Color> OnPickColor
	{
		[CompilerGenerated]
		add
		{
			Action<Color> action = this.m_OnPickColor;
			Action<Color> action2;
			do
			{
				action2 = action;
				Action<Color> value2 = (Action<Color>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_OnPickColor, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Color> action = this.m_OnPickColor;
			Action<Color> action2;
			do
			{
				action2 = action;
				Action<Color> value2 = (Action<Color>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_OnPickColor, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public AA7kE5H0sek99LsV8L73()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		dktH060FtqV = Colors.White;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void X6QH0c7xkAN(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		Border border = default(Border);
		while (true)
		{
			switch (num2)
			{
			case 2:
				border = P_0 as Border;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (border.DataContext is lepS2J2zmikWCDba0Qkw lepS2J2zmikWCDba0Qkw)
				{
					QpwDf0DaETfl2PtDDFYB(lepS2J2zmikWCDba0Qkw, dktH060FtqV);
				}
				return;
			case 3:
				if (border.Background is SolidColorBrush solidColorBrush)
				{
					Action<Color> action = this.OnPickColor;
					if (action == null)
					{
						num2 = 5;
						continue;
					}
					action(onsQfTDaQkBtTP01pW17(solidColorBrush));
				}
				return;
			case 1:
				if (border == null)
				{
					return;
				}
				if (Editable)
				{
					if (!ncBXSSDajkabcCDDif1Y(Key.LeftCtrl))
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			case 4:
				break;
			case 5:
				return;
			}
			border.Background = new SolidColorBrush(dktH060FtqV);
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
			{
				num2 = 0;
			}
		}
	}

	public List<lepS2J2zmikWCDba0Qkw> j4uH0js94AS()
	{
		if (SwatchListBox.ItemsSource is List<lepS2J2zmikWCDba0Qkw> result)
		{
			return result;
		}
		return null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!FS8H0MEQ79L)
		{
			FS8H0MEQ79L = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri((string)wYfpwQDadKBDAAi50XTF(0x6D18F862 ^ 0x6D1806B2), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				SwatchListBox = (ItemsControl)P_1;
				return;
			case 1:
				if (P_0 == 1)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
					{
						num2 = 0;
					}
					break;
				}
				FS8H0MEQ79L = true;
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int P_0, object P_1)
	{
		if (P_0 == 2)
		{
			IKgZsyDag4yQTxEHYjwG((Border)P_1, new MouseButtonEventHandler(X6QH0c7xkAN));
		}
	}

	static AA7kE5H0sek99LsV8L73()
	{
		N1WYbADaRcQjQM9kkGrW();
	}

	internal static bool UcfPlBDaXTJONjj4Df9Q()
	{
		return IT31t5DasLAGmxJrGTDO == null;
	}

	internal static AA7kE5H0sek99LsV8L73 BZReFwDacFdU2e2CaNt9()
	{
		return IT31t5DasLAGmxJrGTDO;
	}

	internal static bool ncBXSSDajkabcCDDif1Y(Key P_0)
	{
		return Keyboard.IsKeyDown(P_0);
	}

	internal static void QpwDf0DaETfl2PtDDFYB(object P_0, XColor P_1)
	{
		((lepS2J2zmikWCDba0Qkw)P_0).Color = P_1;
	}

	internal static Color onsQfTDaQkBtTP01pW17(object P_0)
	{
		return ((SolidColorBrush)P_0).Color;
	}

	internal static object wYfpwQDadKBDAAi50XTF(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void IKgZsyDag4yQTxEHYjwG(object P_0, object P_1)
	{
		((UIElement)P_0).MouseDown += (MouseButtonEventHandler)P_1;
	}

	internal static void N1WYbADaRcQjQM9kkGrW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
