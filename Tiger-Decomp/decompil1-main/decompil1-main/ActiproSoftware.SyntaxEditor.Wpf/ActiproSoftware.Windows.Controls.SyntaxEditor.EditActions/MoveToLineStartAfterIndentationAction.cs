using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToLineStartAfterIndentationAction : EditActionBase
{
	internal static MoveToLineStartAfterIndentationAction CFj;

	public MoveToLineStartAfterIndentationAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToLineStartAfterIndentationText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		int num3 = default(int);
		for (int num = array.Length - 1; num >= 0; num--)
		{
			ITextViewLine viewLine = view.GetViewLine(array[num].EndPosition);
			if (viewLine.IsVirtualLine)
			{
				int num2 = 0;
				if (jF3() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				default:
					array[num] = new TextPositionRange(new TextPosition(viewLine.StartPosition, hasFarAffinity: true));
					break;
				}
			}
			else
			{
				array[num] = new TextPositionRange(new TextPosition(viewLine.CharacterIndexToPosition(viewLine.FirstNonWhitespaceCharacterIndex)));
			}
		}
		view.Selection.SelectRanges(array);
	}

	internal static bool JFM()
	{
		return CFj == null;
	}

	internal static MoveToLineStartAfterIndentationAction jF3()
	{
		return CFj;
	}
}
