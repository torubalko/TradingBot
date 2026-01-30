using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class NewTabButton : Button
{
	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty IsContentHorizontalProperty;

	public static readonly DependencyProperty TabStripPlacementProperty;

	internal static NewTabButton EnX;

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
		}
	}

	public bool IsContentHorizontal
	{
		get
		{
			return (bool)GetValue(IsContentHorizontalProperty);
		}
		set
		{
			SetValue(IsContentHorizontalProperty, value);
		}
	}

	public Dock TabStripPlacement
	{
		get
		{
			return (Dock)GetValue(TabStripPlacementProperty);
		}
		set
		{
			SetValue(TabStripPlacementProperty, value);
		}
	}

	public NewTabButton()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(NewTabButton);
	}

	static NewTabButton()
	{
		IVH.CecNqz();
		CornerRadiusProperty = DependencyProperty.Register(vVK.ssH(5600), typeof(CornerRadius), typeof(NewTabButton), new PropertyMetadata(default(CornerRadius)));
		IsContentHorizontalProperty = DependencyProperty.Register(vVK.ssH(6208), typeof(bool), typeof(NewTabButton), new PropertyMetadata(true));
		TabStripPlacementProperty = DependencyProperty.Register(vVK.ssH(3510), typeof(Dock), typeof(NewTabButton), new PropertyMetadata(Dock.Top));
	}

	internal static bool lns()
	{
		return EnX == null;
	}

	internal static NewTabButton inQ()
	{
		return EnX;
	}
}
