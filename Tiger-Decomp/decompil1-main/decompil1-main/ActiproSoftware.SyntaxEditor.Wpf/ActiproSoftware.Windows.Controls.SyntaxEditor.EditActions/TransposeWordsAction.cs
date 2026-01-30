using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class TransposeWordsAction : EditActionBase
{
	private static TransposeWordsAction XZo;

	public TransposeWordsAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandTransposeWordsText));
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
		reader.GoToCurrentWordStart();
		if (!char.IsLetterOrDigit(reader.Character))
		{
			while (!reader.IsAtSnapshotStart)
			{
				reader.GoToPreviousWordStart();
				if (char.IsLetterOrDigit(reader.Character))
				{
					break;
				}
			}
		}
		if (!char.IsLetterOrDigit(reader.Character))
		{
			return;
		}
		int offset = reader.Offset;
		reader.GoToCurrentWordEnd();
		TextRange textRange = new TextRange(offset, reader.Offset);
		reader.GoToNextWordStart();
		int num;
		if (!char.IsLetterOrDigit(reader.Character))
		{
			num = 2;
			goto IL_0009;
		}
		goto IL_0195;
		IL_0009:
		ITextChange textChange = default(ITextChange);
		TextRange textRange2 = default(TextRange);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				textChange.Apply();
				num = 1;
				if (wZy() == null)
				{
					continue;
				}
				goto IL_0005;
			case 3:
			{
				EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
				{
					CheckReadOnly = true
				};
				textChange = reader.Snapshot.CreateTextChange(TextChangeTypes.TransposeWords, options);
				textChange.DeleteText(textRange2);
				textChange.ReplaceText(textRange, reader.Snapshot.GetSubstring(textRange2, LineTerminator.Newline));
				textChange.InsertText(textRange2.StartOffset + (textRange2.Length - textRange.Length), reader.Snapshot.GetSubstring(textRange, LineTerminator.Newline));
				num = 0;
				if (wZy() == null)
				{
					continue;
				}
				goto IL_0005;
			}
			case 1:
				return;
			case 2:
				break;
				IL_0005:
				num = num2;
				continue;
			}
			break;
		}
		while (!reader.IsAtSnapshotEnd)
		{
			reader.GoToNextWordStart();
			if (char.IsLetterOrDigit(reader.Character))
			{
				break;
			}
		}
		goto IL_0195;
		IL_0195:
		if (!char.IsLetterOrDigit(reader.Character))
		{
			return;
		}
		offset = reader.Offset;
		reader.GoToCurrentWordEnd();
		textRange2 = new TextRange(offset, reader.Offset);
		num = 3;
		goto IL_0009;
	}

	internal static bool RZQ()
	{
		return XZo == null;
	}

	internal static TransposeWordsAction wZy()
	{
		return XZo;
	}
}
