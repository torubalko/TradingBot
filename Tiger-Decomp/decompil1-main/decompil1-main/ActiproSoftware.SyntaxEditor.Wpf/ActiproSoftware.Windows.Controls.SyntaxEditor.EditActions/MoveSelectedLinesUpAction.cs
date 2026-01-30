using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveSelectedLinesUpAction : EditActionBase
{
	internal static MoveSelectedLinesUpAction UZF;

	public MoveSelectedLinesUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveSelectedLinesUpText));
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
		ITextViewLine previousLine = textViewLine.PreviousLine;
		if (previousLine == null || textViewLine2.IsVirtualLine || textViewLine.StartOffset == previousLine.StartOffset)
		{
			return;
		}
		ITextSnapshotLine textSnapshotLine = view.CurrentSnapshot.Lines[previousLine.StartPosition.Line];
		ITextSnapshotLine textSnapshotLine2 = view.CurrentSnapshot.Lines[previousLine.EndPosition.Line];
		ITextSnapshot currentSnapshot = view.CurrentSnapshot;
		EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
		{
			CheckReadOnly = true,
			RetainSelection = true,
			OffsetDelta = TextChangeOffsetDelta.SequentialOnly
		};
		ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.MoveSelectedLinesUp, options);
		string text = Q7Z.tqM(7894) + currentSnapshot.GetSubstring(new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffset), LineTerminator.Newline);
		textChange.DeleteText(new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffsetIncludingLineTerminator));
		textChange.InsertText(textViewLine2.EndOffset, text);
		TextRange textRange = view.Selection.TextRange;
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			textChange.Apply();
			textRange = new TextRange(textRange.StartOffset - text.Length, textRange.EndOffset - text.Length);
			view.Selection.SelectRange(textRange);
		}
	}

	internal static bool VZ9()
	{
		return UZF == null;
	}

	internal static MoveSelectedLinesUpAction NZJ()
	{
		return UZF;
	}
}
