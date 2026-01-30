using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Markup;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

[ValueSerializer(typeof(MouseWheelGestureValueSerializer))]
[TypeConverter(typeof(MouseWheelGestureConverter))]
public class MouseWheelGesture : InputGesture
{
	private ModifierKeys Cke;

	private MouseWheelAction Mk7;

	internal static MouseWheelGesture w3H;

	public ModifierKeys Modifiers
	{
		get
		{
			return Cke;
		}
		set
		{
			if (!ModifierKeysConverter.IsDefinedModifierKeys(value))
			{
				throw new InvalidEnumArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), (int)value, typeof(ModifierKeys));
			}
			Cke = value;
		}
	}

	public MouseWheelAction MouseWheelAction
	{
		get
		{
			return Mk7;
		}
		set
		{
			if (!MouseWheelGestureConverter.IsDefinedMouseWheelAction(value))
			{
				throw new InvalidEnumArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), (int)value, typeof(MouseWheelAction));
			}
			Mk7 = value;
		}
	}

	public MouseWheelGesture()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public MouseWheelGesture(MouseWheelAction mouseWheelAction)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(mouseWheelAction, ModifierKeys.None);
	}

	public MouseWheelGesture(MouseWheelAction mouseWheelAction, ModifierKeys modifiers)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (!MouseWheelGestureConverter.IsDefinedMouseWheelAction(mouseWheelAction))
		{
			throw new InvalidEnumArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110804), (int)mouseWheelAction, typeof(MouseWheelAction));
		}
		if (!ModifierKeysConverter.IsDefinedModifierKeys(modifiers))
		{
			throw new InvalidEnumArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110840), (int)modifiers, typeof(ModifierKeys));
		}
		Cke = modifiers;
		Mk7 = mouseWheelAction;
	}

	public override bool Matches(object targetElement, InputEventArgs inputEventArgs)
	{
		bool flag = MouseWheelAction == MouseWheelAction.None || Modifiers != Keyboard.Modifiers;
		int num = 0;
		if (!d3J())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		MouseWheelEventArgs e = default(MouseWheelEventArgs);
		do
		{
			int result;
			switch (num)
			{
			default:
				if (!flag)
				{
					e = inputEventArgs as MouseWheelEventArgs;
					if (e == null)
					{
						return false;
					}
					if (e.Delta <= 0)
					{
						goto IL_0031;
					}
					goto IL_00c7;
				}
				return false;
			case 1:
				{
					if (MouseWheelAction.NegativeDelta == MouseWheelAction)
					{
						goto IL_0031;
					}
					result = 1;
					break;
				}
				IL_0031:
				result = ((e.Delta < 0 && MouseWheelAction.PositiveDelta != MouseWheelAction) ? 1 : 0);
				break;
			}
			return (byte)result != 0;
			IL_00c7:
			num = 1;
		}
		while (l33() == null);
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	internal static bool d3J()
	{
		return w3H == null;
	}

	internal static MouseWheelGesture l33()
	{
		return w3H;
	}
}
