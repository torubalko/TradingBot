using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveSelectedLinesDownAction : EditActionBase
{
	private static MoveSelectedLinesDownAction BZS;

	public MoveSelectedLinesDownAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveSelectedLinesDownText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ITextViewLine textViewLine = view.GetViewLine(view.Selection.FirstPosition);
		while (textViewLine != null && textViewLine.StartPosition.Character > 0)
		{
			textViewLine = textViewLine.PreviousLine;
		}
		ITextViewLine textViewLine2 = view.GetViewLine(view.Selection.LastPosition);
		while (textViewLine2 != null && !textViewLine2.HasHardLineBreak && !textViewLine2.IsLastLine)
		{
			textViewLine2 = textViewLine2.NextLine;
		}
		if (textViewLine == null || textViewLine2 == null)
		{
			return;
		}
		if (textViewLine.StartOffset < textViewLine2.StartOffset && view.Selection.LastPosition.Character == 0)
		{
			textViewLine2 = textViewLine2.PreviousLine;
			if (textViewLine2 == null)
			{
				return;
			}
		}
		ITextViewLine nextLine = textViewLine2.NextLine;
		if (nextLine == null || nextLine.IsVirtualLine || textViewLine2.StartOffset == nextLine.StartOffset)
		{
			return;
		}
		ITextSnapshotLine textSnapshotLine = view.CurrentSnapshot.Lines[nextLine.StartPosition.Line];
		ITextSnapshotLine textSnapshotLine2 = view.CurrentSnapshot.Lines[nextLine.EndPosition.Line];
		ITextSnapshot currentSnapshot = view.CurrentSnapshot;
		EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
		{
			CheckReadOnly = true,
			RetainSelection = true
		};
		ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.MoveSelectedLinesDown, options);
		string text = currentSnapshot.GetSubstring(new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffset), LineTerminator.Newline) + Q7Z.tqM(7894);
		if (textSnapshotLine2.IsLastLine)
		{
			TextRange textRange = new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffsetIncludingLineTerminator);
			textRange = new TextRange(textRange.StartOffset - 1, textRange.EndOffset);
			textChange.DeleteText(textRange);
			textChange.InsertText(textViewLine.StartOffset, text);
		}
		else
		{
			textChange.DeleteText(new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffsetIncludingLineTerminator));
			textChange.InsertText(textViewLine.StartOffset, text);
		}
		TextRange textRange2 = view.Selection.TextRange;
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			textChange.Apply();
			textRange2 = new TextRange(textRange2.StartOffset + text.Length, textRange2.EndOffset + text.Length);
			view.Selection.SelectRange(textRange2);
		}
	}

	internal static bool oZk()
	{
		return BZS == null;
	}

	internal static MoveSelectedLinesDownAction EZZ()
	{
		return BZS;
	}
}
