using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToLineStartAction : EditActionBase
{
	private static SelectToLineStartAction sRk;

	public SelectToLineStartAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToLineStartText));
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
			TextPosition textPosition = viewLine.CharacterIndexToPosition(viewLine.FirstNonWhitespaceCharacterIndex);
			if (viewLine.IsVirtualLine || textPositionRange.EndPosition == textPosition)
			{
				array[num] = new TextPositionRange(textPositionRange.StartPosition, new TextPosition(viewLine.StartPosition, hasFarAffinity: true));
			}
			else
			{
				array[num] = new TextPositionRange(textPositionRange.StartPosition, new TextPosition(textPosition, hasFarAffinity: true));
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

	internal static bool DRZ()
	{
		return sRk == null;
	}

	internal static SelectToLineStartAction fRF()
	{
		return sRk;
	}
}
