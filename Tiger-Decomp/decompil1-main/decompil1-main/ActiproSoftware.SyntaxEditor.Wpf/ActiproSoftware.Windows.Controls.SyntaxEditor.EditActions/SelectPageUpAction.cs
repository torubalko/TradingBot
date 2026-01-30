using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectPageUpAction : EditActionBase
{
	internal static SelectPageUpAction XR4;

	public SelectPageUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectPageUpText));
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
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		IList<double> preferredCaretHorizontalLocations = view.Selection.GetPreferredCaretHorizontalLocations();
		ITextPositionFinder positionFinder = view.PositionFinder;
		int fullyVisibleCount = view.VisibleViewLines.FullyVisibleCount;
		view.Scroller.ScrollVerticallyByLine(-fullyVisibleCount);
		int num = array.Length - 1;
		int num3 = default(int);
		while (true)
		{
			bool flag = num >= 0;
			int num2 = 0;
			if (oRB() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			case 1:
				return;
			}
			if (flag)
			{
				array[num] = new TextPositionRange(array[num].StartPosition, positionFinder.GetPositionForLineDelta(array[num].EndPosition, -fullyVisibleCount, preferredCaretHorizontalLocations[num], forceVirtualSpace: false));
				num--;
				continue;
			}
			using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
			{
				if (array.Length == 1)
				{
					view.Selection.SelectRange(array[0], mode);
				}
				else
				{
					view.Selection.SelectRanges(array);
				}
				return;
			}
		}
	}

	internal static bool ERD()
	{
		return XR4 == null;
	}

	internal static SelectPageUpAction oRB()
	{
		return XR4;
	}
}
