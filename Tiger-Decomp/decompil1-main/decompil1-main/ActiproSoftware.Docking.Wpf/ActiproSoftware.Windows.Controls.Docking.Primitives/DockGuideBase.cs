using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

public abstract class DockGuideBase : ContentControl
{
	public static readonly DependencyProperty IsSelectedProperty;

	[CompilerGenerated]
	private IDockTarget Y8l;

	internal static DockGuideBase h8J;

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public abstract Side? Side { get; }

	public IDockTarget Target
	{
		[CompilerGenerated]
		get
		{
			return Y8l;
		}
		[CompilerGenerated]
		internal set
		{
			Y8l = value;
		}
	}

	internal fF X8r(Point P_0)
	{
		if (Target == null || !new Rect(default(Point), base.RenderSize).Contains(P_0))
		{
			return null;
		}
		return new fF(this, Target as iy, Side);
	}

	protected DockGuideBase()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	static DockGuideBase()
	{
		IVH.CecNqz();
		IsSelectedProperty = DependencyProperty.Register(vVK.ssH(8344), typeof(bool), typeof(DockGuideBase), new PropertyMetadata(false));
	}

	internal static bool y8U()
	{
		return h8J == null;
	}

	internal static DockGuideBase R8F()
	{
		return h8J;
	}
}
