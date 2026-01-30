using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectDownAction : EditActionBase
{
	private static SelectDownAction yJE;

	public SelectDownAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectDownText));
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
		for (int num = array.Length - 1; num >= 0; num--)
		{
			array[num] = new TextPositionRange(array[num].StartPosition, positionFinder.GetPositionForLineDelta(array[num].EndPosition, 1, preferredCaretHorizontalLocations[num], mode == SelectionModes.Block));
		}
		int num2 = 0;
		if (DJu() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
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
		}
	}

	internal static bool UJw()
	{
		return yJE == null;
	}

	internal static SelectDownAction DJu()
	{
		return yJE;
	}
}
