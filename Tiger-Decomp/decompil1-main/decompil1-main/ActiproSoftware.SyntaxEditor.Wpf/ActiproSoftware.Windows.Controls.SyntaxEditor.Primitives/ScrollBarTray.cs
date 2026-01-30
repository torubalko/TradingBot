using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class ScrollBarTray : ContentControl
{
	public static readonly DependencyProperty OrientationProperty;

	internal static ScrollBarTray F01;

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public ScrollBarTray()
	{
		grA.DaB7cz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ScrollBarTray);
	}

	static ScrollBarTray()
	{
		grA.DaB7cz();
		OrientationProperty = DependencyProperty.Register(Q7Z.tqM(9550), typeof(Orientation), typeof(ScrollBarTray), new PropertyMetadata(Orientation.Horizontal));
	}

	internal static bool B05()
	{
		return F01 == null;
	}

	internal static ScrollBarTray U0G()
	{
		return F01;
	}
}
