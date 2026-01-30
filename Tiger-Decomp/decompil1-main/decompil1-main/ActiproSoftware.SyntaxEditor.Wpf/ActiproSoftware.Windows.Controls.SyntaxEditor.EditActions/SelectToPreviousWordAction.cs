using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToPreviousWordAction : EditActionBase
{
	private static SelectToPreviousWordAction DRj;

	public SelectToPreviousWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToPreviousWordText));
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
		IWordBreakFinder wordBreakFinder = view.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
		int num = array.Length - 1;
		int num3 = default(int);
		while (true)
		{
			if (num < 0)
			{
				if (array.Length != 1)
				{
					break;
				}
				int num2 = 0;
				if (!oRM())
				{
					num2 = num3;
				}
				switch (num2)
				{
				default:
					view.Selection.SelectRange(array[0], mode);
					return;
				case 1:
					break;
				}
			}
			TextPositionRange textPositionRange = array[num];
			int offset = view.PositionToOffset(textPositionRange.EndPosition);
			offset = wordBreakFinder.FindPreviousWordStart(new TextSnapshotOffset(view.CurrentSnapshot, offset));
			offset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, offset), hasFarAffinity: false);
			array[num] = new TextPositionRange(textPositionRange.StartPosition, view.OffsetToPosition(offset));
			num--;
		}
		view.Selection.SelectRanges(array);
	}

	internal static bool oRM()
	{
		return DRj == null;
	}

	internal static SelectToPreviousWordAction uR3()
	{
		return DRj;
	}
}
