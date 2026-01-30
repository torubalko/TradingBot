using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollDownAction : EditActionBase
{
	private static ScrollDownAction W9J;

	public ScrollDownAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollDownText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollVerticallyByLine(1);
		if (view.Selection.Ranges.Count != 1)
		{
			return;
		}
		ITextViewLine textViewLine = view.VisibleViewLines.FirstOrDefault((ITextViewLine l) => l.Visibility == TextViewLineVisibility.FullyVisible);
		if (textViewLine != null && view.Selection.CaretPosition < textViewLine.StartPosition)
		{
			double x = view.Selection.GetPreferredCaretHorizontalLocations()[0];
			TextPosition position = textViewLine.LocationToPosition(x, LocationToPositionAlgorithm.BestFit);
			using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
			{
				view.Selection.SelectRange(new TextPositionRange(position), view.Selection.Mode);
			}
		}
	}

	internal static bool Q9R()
	{
		return W9J == null;
	}

	internal static ScrollDownAction K9O()
	{
		return W9J;
	}
}
