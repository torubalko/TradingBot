using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class NAO : DecorationAdornmentManagerBase<IEditorView, IDelimiterHighlightTag>
{
	internal static NAO i1S;

	public NAO(IEditorView P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0, AdornmentLayerDefinitions.Highlight, isForLanguage: false);
	}

	private void E8o(TextViewDrawContext P_0, IAdornment P_1)
	{
		IEditorView view = base.View;
		Rect textAreaBounds = P_0.TextAreaBounds;
		Rect bounds = new Rect(new Point(textAreaBounds.X + P_1.Location.X - view.ScrollState.HorizontalAmount, textAreaBounds.Y + P_1.Location.Y), P_1.Size);
		P_0.FillRectangle(bounds, P_0.DelimiterMatchingBackground);
	}

	protected override void AddAdornment(AdornmentChangeReason P_0, ITextViewLine P_1, TagSnapshotRange<IDelimiterHighlightTag> P_2, TextBounds P_3)
	{
		if (base.View != null && P_2 != null)
		{
			Rect bounds = new Rect(Math.Round(P_3.Left, MidpointRounding.AwayFromZero), Math.Round(P_3.Top, MidpointRounding.AwayFromZero), Math.Round(P_3.Width, MidpointRounding.AwayFromZero), Math.Round(P_3.Height, MidpointRounding.AwayFromZero));
			base.AdornmentLayer.AddAdornment(P_0, E8o, bounds, P_2.Tag, P_1, P_2.SnapshotRange, TextRangeTrackingModes.ExpandBothEdges, null);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation.DelimiterHighlightAdornmentManager")]
	public static void g8j(IEditorView P_0)
	{
		new NAO(P_0);
	}

	protected override void OnClosed()
	{
		base.AdornmentLayer.RemoveAdornments(AdornmentChangeReason.ManagerClosed, base.AdornmentLayer.FindAdornments((IAdornment a) => a.Tag is IDelimiterHighlightTag));
		base.OnClosed();
	}

	internal static bool x1k()
	{
		return i1S == null;
	}

	internal static NAO c1Z()
	{
		return i1S;
	}
}
