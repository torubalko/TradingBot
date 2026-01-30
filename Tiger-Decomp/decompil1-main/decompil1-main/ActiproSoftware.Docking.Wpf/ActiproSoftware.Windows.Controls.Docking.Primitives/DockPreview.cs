using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockPreview : Control
{
	public static readonly DependencyProperty GeometryProperty;

	internal static DockPreview gno;

	public Geometry Geometry
	{
		get
		{
			return (Geometry)GetValue(GeometryProperty);
		}
		set
		{
			SetValue(GeometryProperty, value);
		}
	}

	public DockPreview()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockPreview);
	}

	static DockPreview()
	{
		IVH.CecNqz();
		GeometryProperty = DependencyProperty.Register(vVK.ssH(21304), typeof(Geometry), typeof(DockPreview), new PropertyMetadata(null));
	}

	internal static bool anB()
	{
		return gno == null;
	}

	internal static DockPreview Vn5()
	{
		return gno;
	}
}
