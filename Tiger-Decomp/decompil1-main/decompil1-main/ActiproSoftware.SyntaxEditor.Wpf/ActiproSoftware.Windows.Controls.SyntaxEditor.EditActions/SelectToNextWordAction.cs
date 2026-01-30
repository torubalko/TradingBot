using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToNextWordAction : EditActionBase
{
	internal static SelectToNextWordAction sRG;

	public SelectToNextWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToNextWordText));
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
		int num = 0;
		if (rRN())
		{
			num = 0;
		}
		int num3 = default(int);
		int num2 = default(int);
		TextPositionRange textPositionRange = default(TextPositionRange);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				view.Selection.SelectRange(array[0], mode);
				return;
			default:
				num3 = array.Length - 1;
				goto IL_0052;
			case 1:
				{
					int offset = wordBreakFinder.FindNextWordStart(new TextSnapshotOffset(view.CurrentSnapshot, num2));
					int visibleOffset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, offset), hasFarAffinity: false);
					if (num2 == visibleOffset)
					{
						visibleOffset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, offset), hasFarAffinity: true);
					}
					array[num3] = new TextPositionRange(textPositionRange.StartPosition, view.OffsetToPosition(visibleOffset));
					num3--;
					goto IL_0052;
				}
				IL_0052:
				if (num3 >= 0)
				{
					textPositionRange = array[num3];
					num2 = view.PositionToOffset(textPositionRange.EndPosition);
					num = 1;
					if (!rRN())
					{
						num = num4;
					}
					break;
				}
				if (array.Length != 1)
				{
					view.Selection.SelectRanges(array);
					return;
				}
				goto case 2;
			}
		}
	}

	internal static bool rRN()
	{
		return sRG == null;
	}

	internal static SelectToNextWordAction fRH()
	{
		return sRG;
	}
}
