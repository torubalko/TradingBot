using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class MouseWheelGestureConverter : TypeConverter
{
	private static MouseWheelGestureConverter C3N;

	internal static bool IsDefinedMouseWheelAction(MouseWheelAction mouseWheelAction)
	{
		return mouseWheelAction >= MouseWheelAction.None && mouseWheelAction <= MouseWheelAction.AnyDelta;
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return sourceType == typeof(string);
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (context != null && context.Instance != null && typeof(string) == destinationType && context.Instance is MouseWheelGesture mouseWheelGesture)
		{
			return ModifierKeysConverter.IsDefinedModifierKeys(mouseWheelGesture.Modifiers) && IsDefinedMouseWheelAction(mouseWheelGesture.MouseWheelAction);
		}
		return false;
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value != null && value is string text)
		{
			string text2 = text.Trim();
			if (string.IsNullOrEmpty(text2))
			{
				return new MouseWheelGesture(MouseWheelAction.None, ModifierKeys.None);
			}
			int num = text2.LastIndexOf('+');
			string value2;
			string value3;
			if (num >= 0)
			{
				value2 = text2.Substring(0, num);
				value3 = text2.Substring(num + 1);
			}
			else
			{
				value2 = string.Empty;
				value3 = text2;
			}
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(MouseWheelAction));
			if (converter != null)
			{
				object obj = converter.ConvertFrom(context, culture, value3);
				if (obj != null)
				{
					if (string.IsNullOrEmpty(value2))
					{
						return new MouseWheelGesture((MouseWheelAction)obj);
					}
					TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(ModifierKeys));
					if (converter2 != null)
					{
						object obj2 = converter2.ConvertFrom(context, culture, value2);
						if (obj2 is ModifierKeys)
						{
							return new MouseWheelGesture((MouseWheelAction)obj, (ModifierKeys)obj2);
						}
					}
				}
			}
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (null == destinationType)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110862));
		}
		if (typeof(string) == destinationType)
		{
			if (value == null)
			{
				return string.Empty;
			}
			if (value is MouseWheelGesture mouseWheelGesture)
			{
				string text = string.Empty;
				TypeConverter converter = TypeDescriptor.GetConverter(typeof(ModifierKeys));
				if (converter != null)
				{
					text += converter.ConvertTo(context, culture, mouseWheelGesture.Modifiers, destinationType);
					if (!string.IsNullOrEmpty(text))
					{
						text += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110896);
					}
				}
				TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(MouseWheelAction));
				if (converter2 != null)
				{
					text += converter2.ConvertTo(context, culture, mouseWheelGesture.MouseWheelAction, destinationType) as string;
				}
				return text;
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public MouseWheelGestureConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool Y3O()
	{
		return C3N == null;
	}

	internal static MouseWheelGestureConverter L3q()
	{
		return C3N;
	}
}
