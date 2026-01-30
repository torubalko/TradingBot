using System;
using System.Collections.Generic;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DeleteBlankLinesAction : EditActionBase
{
	private static DeleteBlankLinesAction KS2;

	public DeleteBlankLinesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteBlankLinesText));
	}

	private static void GLy(ITextBufferReader P_0, TextRange P_1, ITextChange P_2)
	{
		int num = 2;
		bool flag = default(bool);
		int offset = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				bool flag2;
				switch (num2)
				{
				default:
					if (flag)
					{
						P_2.DeleteText(offset, P_0.Offset - offset);
					}
					goto case 2;
				case 2:
					if (P_0.Offset >= P_1.EndOffset)
					{
						return;
					}
					goto case 1;
				case 1:
					if (!char.IsWhiteSpace(P_0.Peek()))
					{
						P_0.ReadThrough('\n', P_1.EndOffset);
						goto case 2;
					}
					offset = P_0.Offset;
					flag2 = true;
					while (P_0.Offset < P_1.EndOffset)
					{
						char c = P_0.Read();
						if (c != '\n')
						{
							if (flag2 && !char.IsWhiteSpace(c))
							{
								flag2 = false;
							}
							continue;
						}
						break;
					}
					break;
				}
				flag = flag2;
				num2 = 0;
			}
			while (aSV());
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
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			IEditorViewSelectionState editorViewSelectionState = view.Selection.CaptureState();
			List<TextRange> list = new List<TextRange>();
			if (editorViewSelectionState.Ranges.Count == 1 && editorViewSelectionState.Ranges[0].IsZeroLength)
			{
				ITextViewLine viewLine = view.GetViewLine(editorViewSelectionState.Ranges[0].StartPosition);
				TextRange item;
				if (viewLine.FirstNonWhitespaceCharacterIndex < viewLine.CharacterCount)
				{
					viewLine = viewLine.PreviousLine;
					if (viewLine == null || viewLine.FirstNonWhitespaceCharacterIndex != viewLine.CharacterCount)
					{
						return;
					}
					item = new TextRange(viewLine.StartOffset, viewLine.EndOffsetIncludingLineTerminator);
					while (viewLine != null && !viewLine.IsFirstLine && viewLine.FirstNonWhitespaceCharacterIndex >= viewLine.CharacterCount)
					{
						item = new TextRange(viewLine.StartOffset, item.EndOffset);
						viewLine = viewLine.PreviousLine;
					}
				}
				else
				{
					item = new TextRange(viewLine.StartOffset, viewLine.EndOffsetIncludingLineTerminator);
					viewLine = viewLine.NextLine;
					while (viewLine != null && !viewLine.IsLastLine && !viewLine.IsVirtualLine && viewLine.FirstNonWhitespaceCharacterIndex >= viewLine.CharacterCount)
					{
						item = new TextRange(item.StartOffset, viewLine.EndOffsetIncludingLineTerminator);
						viewLine = viewLine.NextLine;
					}
				}
				list.Add(item);
			}
			else
			{
				for (int i = 0; i < editorViewSelectionState.Ranges.Count; i++)
				{
					TextPositionRange normalizedTextPositionRange = editorViewSelectionState.Ranges[i].NormalizedTextPositionRange;
					ITextViewLine viewLine2 = view.GetViewLine(normalizedTextPositionRange.StartPosition);
					ITextViewLine textViewLine = ((normalizedTextPositionRange.EndPosition > viewLine2.EndPosition) ? view.GetViewLine(normalizedTextPositionRange.EndPosition) : viewLine2);
					TextRange textRange = new TextRange(viewLine2.StartOffset, textViewLine.EndOffsetIncludingLineTerminator);
					if (list.Count == 0 || list[list.Count - 1] != textRange)
					{
						list.Add(textRange);
					}
				}
			}
			ITextSnapshot currentSnapshot = view.CurrentSnapshot;
			EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			};
			editorViewTextChangeOptions.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
			ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.Delete, editorViewTextChangeOptions);
			ITextBufferReader bufferReader = currentSnapshot.GetReader(list[0].StartOffset).BufferReader;
			foreach (TextRange item2 in list)
			{
				GLy(bufferReader, item2, textChange);
			}
			if (textChange.Operations.Count > 0)
			{
				textChange.Apply();
				editorViewSelectionState.Restore();
			}
		}
	}

	internal static bool aSV()
	{
		return KS2 == null;
	}

	internal static DeleteBlankLinesAction gSI()
	{
		return KS2;
	}
}
