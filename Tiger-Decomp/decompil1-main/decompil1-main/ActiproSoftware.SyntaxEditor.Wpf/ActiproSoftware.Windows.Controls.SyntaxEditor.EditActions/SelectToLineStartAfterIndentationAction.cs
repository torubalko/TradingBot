using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToLineStartAfterIndentationAction : EditActionBase
{
	internal static SelectToLineStartAfterIndentationAction bR9;

	public SelectToLineStartAfterIndentationAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToLineStartAfterIndentationText));
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
		for (int num = array.Length - 1; num >= 0; num--)
		{
			TextPositionRange textPositionRange = array[num];
			ITextViewLine viewLine = view.GetViewLine(textPositionRange.EndPosition);
			if (viewLine.IsVirtualLine)
			{
				array[num] = new TextPositionRange(textPositionRange.StartPosition, new TextPosition(viewLine.StartPosition));
			}
			else
			{
				array[num] = new TextPositionRange(textPositionRange.StartPosition, new TextPosition(viewLine.CharacterIndexToPosition(viewLine.FirstNonWhitespaceCharacterIndex)));
			}
		}
		if (array.Length == 1)
		{
			view.Selection.SelectRange(array[0], mode);
		}
		else
		{
			view.Selection.SelectRanges(array);
		}
	}

	internal static bool TRJ()
	{
		return bR9 == null;
	}

	internal static SelectToLineStartAfterIndentationAction gRR()
	{
		return bR9;
	}
}
