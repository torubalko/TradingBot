using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class DropDownButton : ToggleButton
{
	public static readonly DependencyProperty IsPointerOverParentProperty;

	internal static DropDownButton Tjr;

	public bool IsPointerOverParent
	{
		get
		{
			return (bool)GetValue(IsPointerOverParentProperty);
		}
		set
		{
			SetValue(IsPointerOverParentProperty, value);
		}
	}

	public DropDownButton()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DropDownButton);
	}

	static DropDownButton()
	{
		awj.QuEwGz();
		IsPointerOverParentProperty = DependencyProperty.Register(QdM.AR8(24050), typeof(bool), typeof(DropDownButton), new PropertyMetadata(false));
	}

	internal static bool Sja()
	{
		return Tjr == null;
	}

	internal static DropDownButton Ejj()
	{
		return Tjr;
	}
}
