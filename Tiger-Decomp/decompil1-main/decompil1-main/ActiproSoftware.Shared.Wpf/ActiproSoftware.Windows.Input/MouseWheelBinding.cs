using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;
using System.Windows.Markup;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class MouseWheelBinding : InputBinding
{
	private static object Xk2;

	private static MouseWheelBinding r3t;

	[ValueSerializer(typeof(MouseWheelGestureValueSerializer))]
	[TypeConverter(typeof(MouseWheelGestureConverter))]
	public override InputGesture Gesture
	{
		get
		{
			return base.Gesture as MouseWheelGesture;
		}
		set
		{
			if (!(value is MouseWheelGesture))
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110716), new object[1] { typeof(MouseWheelGesture) }));
			}
			base.Gesture = value;
		}
	}

	public MouseWheelAction MouseWheelAction
	{
		get
		{
			lock (Xk2)
			{
				if (Gesture != null)
				{
					return ((MouseWheelGesture)Gesture).MouseWheelAction;
				}
				return MouseWheelAction.None;
			}
		}
		set
		{
			lock (Xk2)
			{
				if (Gesture != null)
				{
					((MouseWheelGesture)Gesture).MouseWheelAction = value;
				}
				else
				{
					Gesture = new MouseWheelGesture(value);
				}
			}
		}
	}

	public MouseWheelBinding()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public MouseWheelBinding(ICommand command, MouseWheelGesture gesture)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(command, gesture);
	}

	static MouseWheelBinding()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Xk2 = new object();
	}

	internal static bool r3f()
	{
		return r3t == null;
	}

	internal static MouseWheelBinding U37()
	{
		return r3t;
	}
}
