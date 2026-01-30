using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ECOEgqlSad8NUJZ2Dr9n;
using it6TGXH0GDTvLyIESHTf;
using N9Dqw2H0Xr7plZVxApV2;
using OWUMXkHkWgCUprHQ3jb9;
using TuAMtrl1Nd3XoZQQUXf0;

namespace aSoiGpH0bkjsQEnESoqY;

internal class Ndgai9H0DCD1fcCboS58 : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private Color hLNH0Lj07Zp;

	internal SpectrumColorPicker ColorPicker;

	internal ColorComponentSlider SliderR;

	internal ColorComponentSlider SliderG;

	internal ColorComponentSlider SliderB;

	internal ColorComponentSlider SliderA;

	internal AA7kE5H0sek99LsV8L73 Swatch;

	private bool lUkH0eB5Esb;

	internal static Ndgai9H0DCD1fcCboS58 UuRI5aDakYBhRsuGhQas;

	public Color SelectedColor
	{
		get
		{
			return hLNH0Lj07Zp;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (hLNH0Lj07Zp == color)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					hLNH0Lj07Zp = color;
					Swatch.dktH060FtqV = color;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602201489));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public Ndgai9H0DCD1fcCboS58()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Swatch.SwatchListBox.ItemsSource = OPemsBH0nede2WBvOCR3.pwsH0YOfkWZ();
				return;
			case 1:
				hLNH0Lj07Zp = Colors.White;
				InitializeComponent();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void COIH0Naxc07(object P_0, RoutedEventArgs P_1)
	{
		l3d8iXDaSBOEHTcqxlTL(Swatch.SwatchListBox, OPemsBH0nede2WBvOCR3.vqiH0vRIJFm());
	}

	private void CabH0k6J5O8(object P_0, RoutedEventArgs P_1)
	{
		l3d8iXDaSBOEHTcqxlTL(Swatch.SwatchListBox, OPemsBH0nede2WBvOCR3.JcpH0BO98Eb());
	}

	private void qfcH01o5oYm(object P_0, RoutedEventArgs P_1)
	{
		OPemsBH0nede2WBvOCR3.YoIH0oQh9NQ(Swatch.j4uH0js94AS());
		base.DialogResult = true;
		rasmT6DaxnGdDhKEJcCd(this);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void rbFH05gdFOi(object P_0, RoutedEventArgs P_1)
	{
		rasmT6DaxnGdDhKEJcCd(this);
	}

	private void Swatch_OnPickColor(Color color)
	{
		SelectedColor = color;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!lUkH0eB5Esb)
		{
			lUkH0eB5Esb = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B7B5E5), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)xYwqb9DaLDHjTwGpVL47(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 7:
			yaJmwqDaedPAyv2H4bZE((Button)P_1, new RoutedEventHandler(CabH0k6J5O8));
			return;
		case 6:
			Swatch = (AA7kE5H0sek99LsV8L73)P_1;
			return;
		case 3:
			SliderG = (ColorComponentSlider)P_1;
			return;
		case 4:
			SliderB = (ColorComponentSlider)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			lUkH0eB5Esb = true;
			return;
		case 2:
		{
			SliderR = (ColorComponentSlider)P_1;
			int num2 = 4;
			num = num2;
			goto IL_0009;
		}
		case 9:
			yaJmwqDaedPAyv2H4bZE((Button)P_1, new RoutedEventHandler(qfcH01o5oYm));
			return;
		case 8:
			yaJmwqDaedPAyv2H4bZE((Button)P_1, new RoutedEventHandler(COIH0Naxc07));
			num = 3;
			goto IL_0009;
		case 5:
			SliderA = (ColorComponentSlider)P_1;
			return;
		case 1:
			break;
		case 10:
			{
				yaJmwqDaedPAyv2H4bZE((Button)P_1, new RoutedEventHandler(rbFH05gdFOi));
				num = 2;
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 4:
				return;
			case 2:
				return;
			case 3:
				return;
			case 1:
				return;
			}
			break;
		}
		ColorPicker = (SpectrumColorPicker)P_1;
	}

	static Ndgai9H0DCD1fcCboS58()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool nZcgGGDa1LEVvF0tAKK0()
	{
		return UuRI5aDakYBhRsuGhQas == null;
	}

	internal static Ndgai9H0DCD1fcCboS58 IE300oDa5bnyl2J1Oxe0()
	{
		return UuRI5aDakYBhRsuGhQas;
	}

	internal static void l3d8iXDaSBOEHTcqxlTL(object P_0, object P_1)
	{
		((ItemsControl)P_0).ItemsSource = (IEnumerable)P_1;
	}

	internal static void rasmT6DaxnGdDhKEJcCd(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object xYwqb9DaLDHjTwGpVL47(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void yaJmwqDaedPAyv2H4bZE(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
