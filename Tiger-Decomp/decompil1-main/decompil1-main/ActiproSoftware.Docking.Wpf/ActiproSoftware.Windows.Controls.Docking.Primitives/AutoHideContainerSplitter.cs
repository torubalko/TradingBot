using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class AutoHideContainerSplitter : SplitterBase, Va, IOrientedElement
{
	[CompilerGenerated]
	private Side nTr;

	[CompilerGenerated]
	private ToolWindowContainer sTx;

	internal static AutoHideContainerSplitter P8p;

	UIElement Va.ElementAfter => JT8();

	UIElement Va.ElementBefore => JT8();

	double Va.TranslationOffset
	{
		get
		{
			return Srr();
		}
		set
		{
			Urx(value);
		}
	}

	public AutoHideContainerSplitter()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(AutoHideContainerSplitter);
	}

	internal override N7 CreateSplitDragProcessor()
	{
		if (base.Parent is ig ig)
		{
			DockHost dockHost = ig.STP();
			DockSite dockSite = dockHost?.DockSite;
			bool flag = dockSite?.IsLiveSplittingEnabled ?? true;
			bool flag2 = dockSite?.IQR() ?? true;
			return new Tw(dockHost, this, nTn(), flag, flag2);
		}
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Side nTn()
	{
		return nTr;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void iTO(Side value)
	{
		nTr = value;
	}

	Rect Va.GetBounds()
	{
		return Nrm();
	}

	[SpecialName]
	[CompilerGenerated]
	internal ToolWindowContainer JT8()
	{
		return sTx;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void vTD(ToolWindowContainer value)
	{
		sTx = value;
	}

	internal static bool W84()
	{
		return P8p == null;
	}

	internal static AutoHideContainerSplitter e82()
	{
		return P8p;
	}
}
