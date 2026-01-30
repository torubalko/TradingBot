using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Input;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ValueConversion(typeof(InputScopeNameValue), typeof(InputScope))]
public class InputScopeConverter : IValueConverter
{
	internal static InputScopeConverter Ojy;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is InputScopeNameValue))
		{
			throw new ArgumentException(QdM.AR8(24516), QdM.AR8(23908));
		}
		return new InputScope
		{
			Names = { (object)new InputScopeName((InputScopeNameValue)value) }
		};
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public InputScopeConverter()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool pjX()
	{
		return Ojy == null;
	}

	internal static InputScopeConverter IjK()
	{
		return Ojy;
	}
}
