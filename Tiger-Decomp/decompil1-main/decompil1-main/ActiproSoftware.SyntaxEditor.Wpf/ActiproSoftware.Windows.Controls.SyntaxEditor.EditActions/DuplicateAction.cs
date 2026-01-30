using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DuplicateAction : EditActionBase
{
	private static DuplicateAction jku;

	public DuplicateAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDuplicateText));
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
		ITextSnapshot currentSnapshot = view.CurrentSnapshot;
		ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.Duplicate, new EditorViewTextChangeOptions(view)
		{
			CheckReadOnly = true
		});
		TextPositionRange normalizedTextPositionRange = view.Selection.PositionRange.NormalizedTextPositionRange;
		if (normalizedTextPositionRange.IsZeroLength)
		{
			ITextSnapshotLine textSnapshotLine = view.CurrentSnapshot.Lines[normalizedTextPositionRange.EndPosition.Line];
			textChange.InsertText(textSnapshotLine.StartOffset, textSnapshotLine.Text + Q7Z.tqM(7886));
			textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(new TextPositionRange(new TextPosition(normalizedTextPositionRange.EndPosition.Line + 1, normalizedTextPositionRange.EndPosition.Character)), isBlock: false);
		}
		else
		{
			textChange.InsertText(view.Selection.LastOffset, view.SelectedText);
			TextPositionRange positionRange = new TextPositionRange(normalizedTextPositionRange.EndPosition, (normalizedTextPositionRange.Lines > 1) ? new TextPosition(normalizedTextPositionRange.EndPosition.Line + normalizedTextPositionRange.Lines - 1, normalizedTextPositionRange.EndPosition.Character) : new TextPosition(normalizedTextPositionRange.EndPosition.Line, normalizedTextPositionRange.EndPosition.Character + (normalizedTextPositionRange.EndPosition.Character - normalizedTextPositionRange.StartPosition.Character)));
			textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(positionRange, isBlock: false);
		}
		textChange.Apply();
	}

	internal static bool ek8()
	{
		return jku == null;
	}

	internal static DuplicateAction qkU()
	{
		return jku;
	}
}
