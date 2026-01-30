using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class TransposeCharactersAction : EditActionBase
{
	internal static TransposeCharactersAction gZT;

	public TransposeCharactersAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandTransposeCharactersText));
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
		ITextSnapshotReader reader = view.CurrentSnapshot.GetReader(view.Selection.EndOffset);
		if (reader.IsAtSnapshotLineStart)
		{
			if (reader.IsAtSnapshotLineEnd)
			{
				return;
			}
			reader.ReadCharacter();
			if (reader.IsAtSnapshotLineEnd)
			{
				return;
			}
		}
		else if (reader.IsAtSnapshotLineEnd)
		{
			reader.ReadCharacterReverse();
			if (reader.IsAtSnapshotLineStart)
			{
				return;
			}
		}
		int offset = reader.Offset;
		view.SyntaxEditor.Document.ReplaceText(TextChangeTypes.TransposeCharacters, offset - 1, 2, reader.Snapshot[offset].ToString() + reader.Snapshot[offset - 1], new EditorViewTextChangeOptions(view)
		{
			CheckReadOnly = true
		});
	}

	internal static bool oZt()
	{
		return gZT == null;
	}

	internal static TransposeCharactersAction lZY()
	{
		return gZT;
	}
}
