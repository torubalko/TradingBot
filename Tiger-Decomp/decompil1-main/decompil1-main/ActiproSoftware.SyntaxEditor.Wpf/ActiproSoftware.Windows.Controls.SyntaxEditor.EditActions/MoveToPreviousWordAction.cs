using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToPreviousWordAction : EditActionBase
{
	internal static MoveToPreviousWordAction WFs;

	public MoveToPreviousWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToPreviousWordText));
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
		while (num >= 0)
		{
			TextPosition endPosition = array[num].EndPosition;
			if (!view.IsVirtualLine(endPosition.Line))
			{
				goto IL_00ed;
			}
			if (endPosition.Character > 0)
			{
				array[num] = new TextPositionRange(new TextPosition(endPosition.Line, endPosition.Character - 1));
			}
			goto IL_0185;
			IL_0185:
			num--;
			int num2 = 0;
			if (TFo() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			case 1:
				goto IL_00ed;
			}
			continue;
			IL_00ed:
			int offset = view.PositionToOffset(endPosition);
			offset = wordBreakFinder.FindPreviousWordStart(new TextSnapshotOffset(view.CurrentSnapshot, offset));
			offset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, offset), hasFarAffinity: false);
			TextPosition position = view.OffsetToPosition(offset);
			array[num] = new TextPositionRange(new TextPosition(position, hasFarAffinity: true));
			goto IL_0185;
		}
		view.Selection.SelectRanges(array);
	}

	internal static bool tFP()
	{
		return WFs == null;
	}

	internal static MoveToPreviousWordAction TFo()
	{
		return WFs;
	}
}
