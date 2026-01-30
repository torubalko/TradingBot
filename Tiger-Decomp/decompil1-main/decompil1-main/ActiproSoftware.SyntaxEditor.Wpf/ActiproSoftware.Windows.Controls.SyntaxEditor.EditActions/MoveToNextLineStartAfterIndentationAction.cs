using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToNextLineStartAfterIndentationAction : EditActionBase
{
	internal static MoveToNextLineStartAfterIndentationAction zF2;

	public MoveToNextLineStartAfterIndentationAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToNextLineStartAfterIndentationText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		for (int num = array.Length - 1; num >= 0; num--)
		{
			ITextViewLine viewLine = view.GetViewLine(view.PositionFinder.GetPositionForLineDelta(array[num].EndPosition, 1, null, forceVirtualSpace: false));
			if (!viewLine.IsVirtualLine)
			{
				array[num] = new TextPositionRange(new TextPosition(viewLine.CharacterIndexToPosition(viewLine.FirstNonWhitespaceCharacterIndex), hasFarAffinity: true));
			}
			else
			{
				array[num] = new TextPositionRange(new TextPosition(viewLine.StartPosition, hasFarAffinity: true));
			}
		}
		view.Selection.SelectRanges(array);
	}

	internal static bool LFV()
	{
		return zF2 == null;
	}

	internal static MoveToNextLineStartAfterIndentationAction oFI()
	{
		return zF2;
	}
}
