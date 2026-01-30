using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToVisibleTopAction : EditActionBase
{
	private static SelectToVisibleTopAction FR2;

	public SelectToVisibleTopAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToVisibleTopText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		SelectionModes mode = view.Selection.Mode;
		if (!view.SyntaxEditor.IsSelectionModeAllowed(mode))
		{
			return;
		}
		ITextViewLine textViewLine = view.VisibleViewLines.FirstOrDefault((ITextViewLine l) => l.Visibility == TextViewLineVisibility.FullyVisible);
		if (textViewLine == null)
		{
			return;
		}
		double x = view.Selection.GetPreferredCaretHorizontalLocations()[view.Selection.Ranges.PrimaryIndex];
		int num = 0;
		if (!SRV())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		TextPosition endPosition = textViewLine.LocationToPosition(x, LocationToPositionAlgorithm.BestFit);
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
		{
			view.Selection.SelectRange(new TextPositionRange(view.Selection.StartPosition, endPosition), mode);
		}
	}

	internal static bool SRV()
	{
		return FR2 == null;
	}

	internal static SelectToVisibleTopAction zRI()
	{
		return FR2;
	}
}
