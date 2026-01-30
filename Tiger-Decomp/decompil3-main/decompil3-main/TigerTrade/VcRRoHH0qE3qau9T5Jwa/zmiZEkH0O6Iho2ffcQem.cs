using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.ColorSelection;
using aSoiGpH0bkjsQEnESoqY;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using it6TGXH0GDTvLyIESHTf;
using N9Dqw2H0Xr7plZVxApV2;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace VcRRoHH0qE3qau9T5Jwa;

internal class zmiZEkH0O6Iho2ffcQem : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	public static readonly DependencyProperty AaoH0yLCURs;

	public static readonly DependencyProperty zYqH0ZaVPZ9;

	internal Border Border;

	internal SpectrumColorPicker ColorPicker;

	internal ColorComponentSlider SliderR;

	internal ColorComponentSlider SliderG;

	internal ColorComponentSlider SliderB;

	internal ColorComponentSlider SliderA;

	internal AA7kE5H0sek99LsV8L73 Swatch;

	private bool gyZH0V4NUmk;

	private static zmiZEkH0O6Iho2ffcQem GTAkJLDa627KFjy5sym5;

	public Color SelectedColor
	{
		get
		{
			return (Color)wJFRx7DaqkbuSSQcK5wi(this, AaoH0yLCURs);
		}
		set
		{
			SetValue(AaoH0yLCURs, color);
		}
	}

	public Color InitialColor
	{
		get
		{
			return (Color)GetValue(zYqH0ZaVPZ9);
		}
		set
		{
			J1rPUPDaIcslUUZaK0Yx(this, zYqH0ZaVPZ9, color);
		}
	}

	public zmiZEkH0O6Iho2ffcQem()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void Swatch_OnPickColor(Color color)
	{
		SelectedColor = color;
	}

	private void DqNH0IGWppJ(object P_0, RoutedEventArgs P_1)
	{
		if (new Ndgai9H0DCD1fcCboS58
		{
			Owner = base.ParentWindow
		}.ShowDialog() == true)
		{
			Swatch.SwatchListBox.ItemsSource = OPemsBH0nede2WBvOCR3.pwsH0YOfkWZ();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
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

	private void ColorPickerPanel_OnLoaded(object sender, RoutedEventArgs e)
	{
		Swatch.SwatchListBox.ItemsSource = OPemsBH0nede2WBvOCR3.pwsH0YOfkWZ();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!gyZH0V4NUmk)
		{
			gyZH0V4NUmk = true;
			Uri uri = new Uri((string)Qo9HjHDaWZY9mJ87EDaF(-1522697859 ^ -1522694623), UriKind.Relative);
			rlnYHgDatDwQnxI3VTM3(this, uri);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 6:
			SliderA = (ColorComponentSlider)P_1;
			num = 2;
			goto IL_0009;
		case 2:
			ColorPicker = (SpectrumColorPicker)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 5:
			SliderB = (ColorComponentSlider)P_1;
			break;
		default:
			gyZH0V4NUmk = true;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			Border = (Border)P_1;
			num = 3;
			goto IL_0009;
		case 7:
			Swatch = (AA7kE5H0sek99LsV8L73)P_1;
			break;
		case 4:
			SliderG = (ColorComponentSlider)P_1;
			break;
		case 3:
			SliderR = (ColorComponentSlider)P_1;
			break;
		case 8:
			{
				pGgWaFDaUW8wjXSnSqHh((Button)P_1, new RoutedEventHandler(DqNH0IGWppJ));
				break;
			}
			IL_0009:
			switch (num)
			{
			case 3:
				break;
			case 2:
				break;
			case 1:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static zmiZEkH0O6Iho2ffcQem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Qt7QCgDayomLnb8Z8YBs();
				AaoH0yLCURs = (DependencyProperty)kVpp0ODaCDNhhQsINm0E(Qo9HjHDaWZY9mJ87EDaF(-82860344 ^ -82880300), wR2MctDaVfgLb5RCDm2v(hdXwYMDaZeXARqCw6fXL(16777498)), Type.GetTypeFromHandle(hdXwYMDaZeXARqCw6fXL(33555199)), new PropertyMetadata(Colors.Black));
				zYqH0ZaVPZ9 = (DependencyProperty)kVpp0ODaCDNhhQsINm0E(Qo9HjHDaWZY9mJ87EDaF(-1435596783 ^ -1435600905), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777498)), wR2MctDaVfgLb5RCDm2v(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555199)), new PropertyMetadata(Q7sUa2DarehkAbasgKLu()));
				return;
			case 1:
				Dt2VGvDaTon6xH3m8x4Q();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object wJFRx7DaqkbuSSQcK5wi(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool o0FtcCDaMLtbt27TiUML()
	{
		return GTAkJLDa627KFjy5sym5 == null;
	}

	internal static zmiZEkH0O6Iho2ffcQem sjjSZGDaOR2BnkalZPle()
	{
		return GTAkJLDa627KFjy5sym5;
	}

	internal static void J1rPUPDaIcslUUZaK0Yx(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object Qo9HjHDaWZY9mJ87EDaF(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void rlnYHgDatDwQnxI3VTM3(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void pGgWaFDaUW8wjXSnSqHh(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void Dt2VGvDaTon6xH3m8x4Q()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void Qt7QCgDayomLnb8Z8YBs()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static RuntimeTypeHandle hdXwYMDaZeXARqCw6fXL(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type wR2MctDaVfgLb5RCDm2v(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object kVpp0ODaCDNhhQsINm0E(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static Color Q7sUa2DarehkAbasgKLu()
	{
		return Colors.Black;
	}
}
