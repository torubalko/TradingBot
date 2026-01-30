using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollUpAction : EditActionBase
{
	internal static ScrollUpAction I9K;

	public ScrollUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollUpText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollVerticallyByLine(-1);
		if (view.Selection.Ranges.Count != 1)
		{
			return;
		}
		ITextViewLine textViewLine = view.VisibleViewLines.LastOrDefault((ITextViewLine l) => l.Visibility == TextViewLineVisibility.FullyVisible);
		int num = 0;
		if (!U9C())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (textViewLine != null && view.Selection.CaretPosition > textViewLine.EndPositionIncludingLineTerminator)
		{
			double x = view.Selection.GetPreferredCaretHorizontalLocations()[0];
			TextPosition position = textViewLine.LocationToPosition(x, LocationToPositionAlgorithm.BestFit);
			using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
			{
				view.Selection.SelectRange(new TextPositionRange(position), view.Selection.Mode);
			}
		}
	}

	internal static bool U9C()
	{
		return I9K == null;
	}

	internal static ScrollUpAction h9r()
	{
		return I9K;
	}
}
