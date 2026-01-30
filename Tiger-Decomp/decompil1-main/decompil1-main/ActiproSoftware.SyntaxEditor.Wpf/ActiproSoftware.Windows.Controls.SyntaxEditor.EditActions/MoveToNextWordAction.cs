using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToNextWordAction : EditActionBase
{
	internal static MoveToNextWordAction yFc;

	public MoveToNextWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToNextWordText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		IWordBreakFinder wordBreakFinder = view.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
		int num = array.Length - 1;
		int num3 = default(int);
		int offset = default(int);
		int visibleOffset = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2;
			if (num < 0)
			{
				num2 = 0;
				if (!wFd())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_013f;
			IL_00d7:
			num--;
			continue;
			IL_013f:
			TextPosition endPosition = array[num].EndPosition;
			if (view.IsVirtualLine(endPosition.Line))
			{
				if (view.SyntaxEditor.IsVirtualSpaceAtLineEndEnabled && endPosition.Character <= int.MaxValue)
				{
					array[num] = new TextPositionRange(new TextPosition(endPosition.Line, endPosition.Character + 1));
				}
				goto IL_00d7;
			}
			num3 = view.PositionToOffset(endPosition);
			offset = wordBreakFinder.FindNextWordStart(new TextSnapshotOffset(view.CurrentSnapshot, num3));
			visibleOffset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, offset), hasFarAffinity: false);
			num2 = 1;
			if (!wFd())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0005:
			num2 = num4;
			goto IL_0009;
			IL_0009:
			switch (num2)
			{
			case 1:
				break;
			default:
				view.Selection.SelectRanges(array);
				return;
			case 2:
				goto IL_013f;
			}
			if (num3 == visibleOffset)
			{
				visibleOffset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, offset), hasFarAffinity: true);
			}
			array[num] = new TextPositionRange(view.OffsetToPosition(visibleOffset));
			goto IL_00d7;
		}
	}

	internal static bool wFd()
	{
		return yFc == null;
	}

	internal static MoveToNextWordAction pFT()
	{
		return yFc;
	}
}
