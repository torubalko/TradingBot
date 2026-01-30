using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToLineStartAction : EditActionBase
{
	internal static MoveToLineStartAction hFG;

	public MoveToLineStartAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToLineStartText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		int num3 = default(int);
		TextPosition textPosition = default(TextPosition);
		for (int num = array.Length - 1; num >= 0; num--)
		{
			TextPositionRange textPositionRange = array[num];
			ITextViewLine viewLine = view.GetViewLine(textPositionRange.EndPosition);
			int num2 = 1;
			if (rFH() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			default:
				array[num] = new TextPositionRange(new TextPosition(textPosition, hasFarAffinity: true));
				continue;
			case 1:
				textPosition = viewLine.CharacterIndexToPosition(viewLine.FirstNonWhitespaceCharacterIndex);
				if (viewLine.IsVirtualLine || textPositionRange.EndPosition == textPosition)
				{
					break;
				}
				goto default;
			}
			array[num] = new TextPositionRange(new TextPosition(viewLine.StartPosition, hasFarAffinity: true));
		}
		view.Selection.SelectRanges(array);
	}

	internal static bool qFN()
	{
		return hFG == null;
	}

	internal static MoveToLineStartAction rFH()
	{
		return hFG;
	}
}
