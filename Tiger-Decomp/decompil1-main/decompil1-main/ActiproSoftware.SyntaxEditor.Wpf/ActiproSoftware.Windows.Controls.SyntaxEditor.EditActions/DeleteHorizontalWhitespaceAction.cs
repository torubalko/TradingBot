using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
public class DeleteHorizontalWhitespaceAction : EditActionBase
{
	internal static DeleteHorizontalWhitespaceAction PSc;

	public DeleteHorizontalWhitespaceAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteHorizontalWhitespaceText));
	}

	private static void QLq(ITextBufferReader P_0, TextRange P_1, ITextChange P_2)
	{
		P_1.Normalize();
		P_0.Offset = P_1.StartOffset;
		while (P_0.Offset < P_1.EndOffset)
		{
			char c = P_0.Read();
			if (c != '\n' && char.IsWhiteSpace(c))
			{
				P_2.DeleteText(P_0.Offset - 1, 1);
			}
		}
	}

	private static bool aL2(ITextSnapshot P_0, IList<TextRange> P_1, ITextChangeOptions P_2)
	{
		P_2.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
		ITextChange textChange = P_0.CreateTextChange(TextChangeTypes.Delete, P_2);
		ITextBufferReader bufferReader = P_0.GetReader(0).BufferReader;
		bool flag = false;
		foreach (TextRange item in P_1)
		{
			flag |= ML7(bufferReader, item);
			if (flag)
			{
				break;
			}
		}
		if (flag)
		{
			foreach (TextRange item2 in P_1)
			{
				uLi(bufferReader, item2, textChange);
			}
		}
		else
		{
			foreach (TextRange item3 in P_1)
			{
				QLq(bufferReader, item3, textChange);
			}
		}
		return textChange.Apply();
	}

	private static bool ML7(ITextBufferReader P_0, TextRange P_1)
	{
		P_1.Normalize();
		P_0.Offset = P_1.StartOffset;
		bool flag = false;
		int num2 = default(int);
		while (true)
		{
			bool flag2 = P_0.Offset < P_1.EndOffset;
			int num = 0;
			if (!ySd())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
				{
					if (!flag2)
					{
						return false;
					}
					char c = P_0.Read();
					if (c == '\n')
					{
						flag = false;
						break;
					}
					if (char.IsWhiteSpace(c))
					{
						if (flag)
						{
							return true;
						}
						flag = true;
						break;
					}
					goto IL_0031;
				}
				case 1:
					break;
				}
				break;
				IL_0031:
				flag = false;
				num = 1;
				if (nST() == null)
				{
					continue;
				}
				goto IL_0005;
			}
			continue;
			IL_0005:
			num = num2;
			goto IL_0009;
		}
	}

	private static void uLi(ITextBufferReader P_0, TextRange P_1, ITextChange P_2)
	{
		P_1.Normalize();
		P_0.Offset = P_1.StartOffset;
		bool flag = false;
		int offset = P_0.Offset;
		bool flag2 = true;
		while (P_0.Offset < P_1.EndOffset)
		{
			char c = P_0.Read();
			if (c != '\n' && char.IsWhiteSpace(c))
			{
				flag = true;
				continue;
			}
			if (flag)
			{
				if (flag2 || c == '\n')
				{
					P_2.DeleteText(offset, P_0.Offset - 1 - offset);
				}
				else if (P_0.Offset - offset > 2)
				{
					P_2.ReplaceText(offset, P_0.Offset - 1 - offset, Q7Z.tqM(195936));
				}
			}
			flag2 = c == '\n';
			flag = false;
			offset = P_0.Offset;
		}
		if (flag)
		{
			P_2.DeleteText(offset, P_0.Offset - offset);
		}
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
		if (view.Selection.Ranges.Count > 1 || view.Selection.Length > 0)
		{
			using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
			{
				IEditorViewSelectionState editorViewSelectionState = view.Selection.CaptureState();
				if (aL2(view.CurrentSnapshot, view.Selection.GetTextRanges(), new EditorViewTextChangeOptions(view)
				{
					CheckReadOnly = true
				}))
				{
					editorViewSelectionState.Restore();
				}
				return;
			}
		}
		int num = view.Selection.EndOffset;
		int num2 = num;
		ITextSnapshotReader reader = view.CurrentSnapshot.GetReader(num);
		while (!reader.IsAtSnapshotLineStart && char.IsWhiteSpace(reader.PeekCharacterReverse()))
		{
			reader.ReadCharacterReverse();
			num = reader.Offset;
		}
		bool isAtSnapshotLineStart = reader.IsAtSnapshotLineStart;
		reader.Offset = num2;
		while (!reader.IsAtSnapshotLineEnd && char.IsWhiteSpace(reader.PeekCharacter()))
		{
			reader.ReadCharacter();
			num2 = reader.Offset;
		}
		bool isAtSnapshotLineEnd = reader.IsAtSnapshotLineEnd;
		if (num < num2)
		{
			if (isAtSnapshotLineStart || isAtSnapshotLineEnd)
			{
				TextRange textRange = new TextRange(num, num2);
				view.SyntaxEditor.Document.DeleteText(TextChangeTypes.Delete, textRange.FirstOffset, textRange.AbsoluteLength, new EditorViewTextChangeOptions(view)
				{
					CheckReadOnly = true
				});
			}
			else if (num2 - num > 1)
			{
				TextRange textRange2 = new TextRange(num + 1, num2);
				view.SyntaxEditor.Document.DeleteText(TextChangeTypes.Delete, textRange2.FirstOffset, textRange2.AbsoluteLength, new EditorViewTextChangeOptions(view)
				{
					CheckReadOnly = true
				});
			}
		}
	}

	internal static bool ySd()
	{
		return PSc == null;
	}

	internal static DeleteHorizontalWhitespaceAction nST()
	{
		return PSc;
	}
}
