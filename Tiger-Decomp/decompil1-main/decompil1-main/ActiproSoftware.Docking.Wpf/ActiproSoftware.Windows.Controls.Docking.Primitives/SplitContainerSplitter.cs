using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class SplitContainerSplitter : SplitterBase, Va, IOrientedElement
{
	[CompilerGenerated]
	private UIElement er1;

	[CompilerGenerated]
	private UIElement mrN;

	private static SplitContainerSplitter anT;

	UIElement Va.ElementAfter => wr2();

	UIElement Va.ElementBefore => PrI();

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

	public SplitContainerSplitter()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SplitContainerSplitter);
	}

	internal override N7 CreateSplitDragProcessor()
	{
		if (base.Parent is SplitContainerPanel splitContainerPanel)
		{
			DockSite dockSite = splitContainerPanel.xEA()?.DockSite;
			bool flag = dockSite?.IsLiveSplittingEnabled ?? true;
			bool flag2 = dockSite?.IQR() ?? true;
			return new Iu(splitContainerPanel, this, flag, flag2);
		}
		return null;
	}

	Rect Va.GetBounds()
	{
		return Nrm();
	}

	[SpecialName]
	[CompilerGenerated]
	internal UIElement wr2()
	{
		return er1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Wre(UIElement value)
	{
		er1 = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal UIElement PrI()
	{
		return mrN;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Trk(UIElement value)
	{
		mrN = value;
	}

	internal static bool Unx()
	{
		return anT == null;
	}

	internal static SplitContainerSplitter ynR()
	{
		return anT;
	}
}
