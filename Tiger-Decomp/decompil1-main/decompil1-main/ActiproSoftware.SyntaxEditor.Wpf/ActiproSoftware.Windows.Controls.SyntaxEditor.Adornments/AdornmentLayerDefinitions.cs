using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

public static class AdornmentLayerDefinitions
{
	private static AdornmentLayerDefinition NnR;

	private static AdornmentLayerDefinition snY;

	private static AdornmentLayerDefinition Ln4;

	private static AdornmentLayerDefinition highlight;

	private static AdornmentLayerDefinition Tno;

	private static AdornmentLayerDefinition enj;

	private static AdornmentLayerDefinition Enw;

	private static AdornmentLayerDefinition un6;

	private static AdornmentLayerDefinition unH;

	internal static AdornmentLayerDefinitions JOd;

	public static AdornmentLayerDefinition Caret
	{
		get
		{
			if (NnR == null)
			{
				NnR = new AdornmentLayerDefinition(Q7Z.tqM(192886), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return NnR;
		}
	}

	public static AdornmentLayerDefinition CollapsedRegion
	{
		get
		{
			if (snY == null)
			{
				snY = new AdornmentLayerDefinition(Q7Z.tqM(197558), new Ordering(Squiggle.Key, OrderPlacement.After), new Ordering(TextForeground.Key, OrderPlacement.After), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return snY;
		}
	}

	public static AdornmentLayerDefinition Guides
	{
		get
		{
			if (Ln4 == null)
			{
				Ln4 = new AdornmentLayerDefinition(Q7Z.tqM(197594), new Ordering(Selection.Key, OrderPlacement.After), new Ordering(CollapsedRegion.Key, OrderPlacement.After), new Ordering(Squiggle.Key, OrderPlacement.After), new Ordering(TextForeground.Key, OrderPlacement.After), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return Ln4;
		}
	}

	public static AdornmentLayerDefinition Highlight
	{
		get
		{
			if (highlight == null)
			{
				highlight = new AdornmentLayerDefinition(Q7Z.tqM(197610), new Ordering(Guides.Key, OrderPlacement.After), new Ordering(Selection.Key, OrderPlacement.After), new Ordering(CollapsedRegion.Key, OrderPlacement.After), new Ordering(Squiggle.Key, OrderPlacement.After), new Ordering(TextForeground.Key, OrderPlacement.After), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return highlight;
		}
	}

	public static AdornmentLayerDefinition OverlayPanes
	{
		get
		{
			if (Tno == null)
			{
				Tno = new AdornmentLayerDefinition(Q7Z.tqM(197632));
			}
			return Tno;
		}
	}

	public static AdornmentLayerDefinition Selection
	{
		get
		{
			if (enj == null)
			{
				enj = new AdornmentLayerDefinition(Q7Z.tqM(7712), new Ordering(CollapsedRegion.Key, OrderPlacement.After), new Ordering(Squiggle.Key, OrderPlacement.After), new Ordering(TextForeground.Key, OrderPlacement.After), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return enj;
		}
	}

	public static AdornmentLayerDefinition Squiggle
	{
		get
		{
			if (Enw == null)
			{
				Enw = new AdornmentLayerDefinition(Q7Z.tqM(197660), new Ordering(TextForeground.Key, OrderPlacement.After), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return Enw;
		}
	}

	public static AdornmentLayerDefinition TextBackground
	{
		get
		{
			if (un6 == null)
			{
				un6 = new AdornmentLayerDefinition(Q7Z.tqM(197680), new Ordering(Highlight.Key, OrderPlacement.After), new Ordering(Guides.Key, OrderPlacement.After), new Ordering(Selection.Key, OrderPlacement.After), new Ordering(CollapsedRegion.Key, OrderPlacement.After), new Ordering(Squiggle.Key, OrderPlacement.After), new Ordering(TextForeground.Key, OrderPlacement.After), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return un6;
		}
	}

	public static AdornmentLayerDefinition TextForeground
	{
		get
		{
			if (unH == null)
			{
				unH = new AdornmentLayerDefinition(Q7Z.tqM(197714), new Ordering(Caret.Key, OrderPlacement.After), new Ordering(OverlayPanes.Key, OrderPlacement.After));
			}
			return unH;
		}
	}

	internal static bool TOT()
	{
		return JOd == null;
	}

	internal static AdornmentLayerDefinitions EOt()
	{
		return JOd;
	}
}
