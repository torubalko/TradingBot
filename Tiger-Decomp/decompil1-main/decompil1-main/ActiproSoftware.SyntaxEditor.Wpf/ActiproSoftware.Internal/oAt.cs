using System;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class oAt : DecorationAdornmentManagerBase<ITextView, ISquiggleTag>
{
	private static oAt l1i;

	private oAt(ITextView P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0, AdornmentLayerDefinitions.Squiggle, isForLanguage: false);
		S8k();
	}

	private void o8s(TextViewDrawContext P_0, IAdornment P_1)
	{
		ITextView view = base.View;
		Rect textAreaBounds = P_0.TextAreaBounds;
		Rect rect = new Rect(new Point(textAreaBounds.X + P_1.Location.X - view.ScrollState.HorizontalAmount, textAreaBounds.Y + P_1.Location.Y), P_1.Size);
		if (!P_0.ClipBounds.IntersectsWith(rect))
		{
			return;
		}
		Color color = Colors.Red;
		if (P_1.Tag is ISquiggleTag { ClassificationType: { } classificationType })
		{
			IHighlightingStyleRegistry highlightingStyleRegistry = view.HighlightingStyleRegistry;
			if (highlightingStyleRegistry != null)
			{
				IHighlightingStyle highlightingStyle = highlightingStyleRegistry[classificationType];
				if (highlightingStyle != null && highlightingStyle.Foreground.HasValue)
				{
					color = highlightingStyle.Foreground.Value;
				}
			}
		}
		P_0.DrawSquiggleLine(rect, color);
	}

	private void S8k()
	{
		base.IsActive = !(base.View is IPrinterView printerView) || printerView.SyntaxEditor.PrintSettings.AreSquiggleLinesVisible;
	}

	protected override void AddAdornment(AdornmentChangeReason P_0, ITextViewLine P_1, TagSnapshotRange<ISquiggleTag> P_2, TextBounds P_3)
	{
		if (base.IsActive)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(11110));
			}
			if (P_2 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(7610));
			}
			Rect bounds = new Rect(Math.Round(P_3.Left, MidpointRounding.AwayFromZero), Math.Round(P_3.Top, MidpointRounding.AwayFromZero), Math.Round(P_3.Width, MidpointRounding.AwayFromZero), Math.Round(P_3.Height, MidpointRounding.AwayFromZero));
			base.AdornmentLayer.AddAdornment(P_0, o8s, bounds, P_2.Tag, P_1, P_2.SnapshotRange, TextRangeTrackingModes.ExpandBothEdges, null);
		}
	}

	public static oAt w8S(ITextView P_0)
	{
		return new oAt(P_0);
	}

	internal static bool V12()
	{
		return l1i == null;
	}

	internal static oAt h1V()
	{
		return l1i;
	}
}
