using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Markup;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class MouseWheelGestureValueSerializer : ValueSerializer
{
	internal static MouseWheelGestureValueSerializer A3G;

	public override bool CanConvertFromString(string value, IValueSerializerContext context)
	{
		return true;
	}

	public override bool CanConvertToString(object value, IValueSerializerContext context)
	{
		return value is MouseWheelGesture mouseWheelGesture && ModifierKeysConverter.IsDefinedModifierKeys(mouseWheelGesture.Modifiers) && MouseWheelGestureConverter.IsDefinedMouseWheelAction(mouseWheelGesture.MouseWheelAction);
	}

	public override object ConvertFromString(string value, IValueSerializerContext context)
	{
		TypeConverter converter = TypeDescriptor.GetConverter(typeof(MouseWheelGesture));
		if (converter == null)
		{
			return base.ConvertFromString(value, context);
		}
		return converter.ConvertFromString(value);
	}

	public override string ConvertToString(object value, IValueSerializerContext context)
	{
		TypeConverter converter = TypeDescriptor.GetConverter(typeof(MouseWheelGesture));
		if (converter != null)
		{
			return converter.ConvertToInvariantString(value);
		}
		return base.ConvertToString(value, context);
	}

	public MouseWheelGestureValueSerializer()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool R3n()
	{
		return A3G == null;
	}

	internal static MouseWheelGestureValueSerializer m30()
	{
		return A3G;
	}
}
