using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(string), typeof(string))]
public class CharacterCasingConverter : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CharacterCasing akx;

	private static CharacterCasingConverter mNR;

	public CharacterCasing CharacterCasing
	{
		[CompilerGenerated]
		get
		{
			return akx;
		}
		[CompilerGenerated]
		set
		{
			akx = value;
		}
	}

	public CharacterCasingConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		CharacterCasing = CharacterCasing.Upper;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					if (!flag)
					{
						return value;
					}
					string text = value.ToString();
					return CharacterCasing switch
					{
						CharacterCasing.Upper => text.ToUpper(CultureInfo.CurrentCulture), 
						CharacterCasing.Lower => text.ToLower(CultureInfo.CurrentCulture), 
						_ => text, 
					};
				}
				}
				flag = value != null;
				num2 = 0;
			}
			while (TN9());
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}

	internal static bool TN9()
	{
		return mNR == null;
	}

	internal static CharacterCasingConverter JNc()
	{
		return mNR;
	}
}
