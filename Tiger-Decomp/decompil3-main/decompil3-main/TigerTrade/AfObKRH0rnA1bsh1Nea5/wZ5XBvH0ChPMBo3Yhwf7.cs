using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

namespace AfObKRH0rnA1bsh1Nea5;

internal sealed class wZ5XBvH0ChPMBo3Yhwf7 : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	public static readonly DependencyProperty bRdH0AnRgws;

	public static readonly DependencyProperty tqbH0Pul9xq;

	internal Border Border;

	internal SpectrumColorPicker ColorPicker;

	internal ColorComponentSlider SliderR;

	internal ColorComponentSlider SliderG;

	internal ColorComponentSlider SliderB;

	internal ColorComponentSlider SliderA;

	internal AA7kE5H0sek99LsV8L73 Swatch;

	private bool gVaH0JkgdLc;

	private static wZ5XBvH0ChPMBo3Yhwf7 TE1BOfDaKRhCjoniimSw;

	public Color SelectedColor
	{
		get
		{
			return (Color)GetValue(bRdH0AnRgws);
		}
		set
		{
			kocU1ADawZBmGRy9G9QC(this, bRdH0AnRgws, color);
		}
	}

	public Color InitialColor
	{
		get
		{
			return (Color)GetValue(tqbH0Pul9xq);
		}
		set
		{
			SetValue(tqbH0Pul9xq, color);
		}
	}

	public wZ5XBvH0ChPMBo3Yhwf7()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void Swatch_OnPickColor(Color color)
	{
		SelectedColor = color;
	}

	private void xyXH0KX1EHj(object P_0, RoutedEventArgs P_1)
	{
		if (new Ndgai9H0DCD1fcCboS58
		{
			Owner = base.ParentWindow
		}.ShowDialog() != true)
		{
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
		}
		gcfHYGDa78VcG5UGbQJU(Swatch.SwatchListBox, OPemsBH0nede2WBvOCR3.pwsH0YOfkWZ());
	}

	private void ColorPickerControl_OnLoaded(object sender, RoutedEventArgs e)
	{
		Swatch.SwatchListBox.ItemsSource = OPemsBH0nede2WBvOCR3.pwsH0YOfkWZ();
	}

	private void h4kH0m90smP(object P_0, MouseButtonEventArgs P_1)
	{
		P_1.Handled = true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!gVaH0JkgdLc)
		{
			gVaH0JkgdLc = true;
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5E1B9C), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			ItOQ5sDa8CCZvvRMwOR7(this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num2;
		int num;
		switch (P_0)
		{
		case 6:
			SliderA = (ColorComponentSlider)P_1;
			num2 = 2;
			goto IL_0005;
		case 8:
			((Button)P_1).Click += xyXH0KX1EHj;
			break;
		default:
			gVaH0JkgdLc = true;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 3:
			SliderR = (ColorComponentSlider)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 4:
			SliderG = (ColorComponentSlider)P_1;
			num2 = 3;
			goto IL_0005;
		case 7:
			Swatch = (AA7kE5H0sek99LsV8L73)P_1;
			break;
		case 5:
			SliderB = (ColorComponentSlider)P_1;
			break;
		case 1:
			Border = (Border)P_1;
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 2:
			{
				ColorPicker = (SpectrumColorPicker)P_1;
				break;
			}
			IL_0005:
			num = num2;
			goto IL_0009;
			IL_0009:
			switch (num)
			{
			case 0:
				break;
			case 2:
				break;
			case 3:
				break;
			case 1:
				break;
			case 4:
				Border.MouseDown += h4kH0m90smP;
				break;
			}
			break;
		}
	}

	static wZ5XBvH0ChPMBo3Yhwf7()
	{
		rqBAeIDaATvXNFCRpDWU();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		bRdH0AnRgws = (DependencyProperty)eofq1CDaFGS55wA1MPLb(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999684478), DRjmm4DaJXTdUM8yRj3Y(UAmV6HDaPC2xoWKqT1Ix(16777498)), DRjmm4DaJXTdUM8yRj3Y(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555200)), new PropertyMetadata(Colors.Black));
		tqbH0Pul9xq = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x7065BE15), DRjmm4DaJXTdUM8yRj3Y(UAmV6HDaPC2xoWKqT1Ix(16777498)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555200)), new PropertyMetadata(Colors.Black));
	}

	internal static bool iXriATDamSIqYeyfu9yQ()
	{
		return TE1BOfDaKRhCjoniimSw == null;
	}

	internal static wZ5XBvH0ChPMBo3Yhwf7 WuPfSJDahBEckWA3fOUO()
	{
		return TE1BOfDaKRhCjoniimSw;
	}

	internal static void kocU1ADawZBmGRy9G9QC(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void gcfHYGDa78VcG5UGbQJU(object P_0, object P_1)
	{
		((ItemsControl)P_0).ItemsSource = (IEnumerable)P_1;
	}

	internal static void ItOQ5sDa8CCZvvRMwOR7(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void rqBAeIDaATvXNFCRpDWU()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static RuntimeTypeHandle UAmV6HDaPC2xoWKqT1Ix(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type DRjmm4DaJXTdUM8yRj3Y(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object eofq1CDaFGS55wA1MPLb(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
