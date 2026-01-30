using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ValueConversion(typeof(string), typeof(string))]
public class TitleConverter : IValueConverter
{
	private string Px8;

	private int fxD;

	private int RxE;

	internal static TitleConverter EA9;

	[Localizability(LocalizationCategory.NeverLocalize)]
	public string Patch
	{
		get
		{
			return Px8;
		}
		set
		{
			Px8 = value;
		}
	}

	public int Prefix
	{
		get
		{
			return fxD;
		}
		set
		{
			fxD = value;
		}
	}

	public int Suffix
	{
		get
		{
			return RxE;
		}
		set
		{
			RxE = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int num = fxD + RxE;
		string text = value as string;
		if (text != null && text.Length > num)
		{
			text = text.Substring(0, fxD) + Px8 + text.Substring(text.Length - RxE);
		}
		return text;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public TitleConverter()
	{
		IVH.CecNqz();
		Px8 = vVK.ssH(22324);
		fxD = 20;
		RxE = 15;
		base._002Ector();
	}

	internal static bool dAm()
	{
		return EA9 == null;
	}

	internal static TitleConverter XAo()
	{
		return EA9;
	}
}
