using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class TransposeLinesAction : EditActionBase
{
	private static TransposeLinesAction EZb;

	public TransposeLinesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandTransposeLinesText));
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
		if (view.IsVirtualLine(view.Selection.EndPosition))
		{
			return;
		}
		ITextSnapshot currentSnapshot = view.CurrentSnapshot;
		TextPosition textPosition = view.Selection.EndPosition;
		if (textPosition.Line == currentSnapshot.Lines.Count - 1)
		{
			if (textPosition.Line == 0)
			{
				return;
			}
			textPosition = new TextPosition(textPosition.Line - 1, textPosition.Character);
		}
		EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
		{
			CheckReadOnly = true,
			RetainSelection = true
		};
		ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.TransposeLines, options);
		ITextSnapshotLine textSnapshotLine = currentSnapshot.Lines[textPosition.Line];
		ITextSnapshotLine textSnapshotLine2 = currentSnapshot.Lines[textPosition.Line + 1];
		textChange.DeleteText(new TextRange(textSnapshotLine.EndOffset, textSnapshotLine2.EndOffset));
		textChange.InsertText(textSnapshotLine.StartOffset, currentSnapshot.GetSubstring(textSnapshotLine2.TextRange, LineTerminator.Newline) + Q7Z.tqM(7894));
		textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(new TextPositionRange(new TextPosition(textPosition.Line + 1, textPosition.Character)), isBlock: false);
		textChange.Apply();
	}

	internal static bool nZs()
	{
		return EZb == null;
	}

	internal static TransposeLinesAction xZP()
	{
		return EZb;
	}
}
