using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
public class TrimTrailingWhitespaceAction : EditActionBase
{
	private static TrimTrailingWhitespaceAction ySw;

	public TrimTrailingWhitespaceAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandTrimTrailingWhitespaceText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	private static void oLp(ITextBufferReader P_0, TextRange P_1, ITextChange P_2)
	{
		P_1.Normalize();
		P_0.Offset = P_1.StartOffset;
		bool flag = false;
		int offset = P_0.Offset;
		int num2 = default(int);
		while (true)
		{
			int num;
			if (P_0.Offset >= P_1.EndOffset)
			{
				if (!flag)
				{
					break;
				}
				P_2.DeleteText(offset, P_0.Offset - offset);
				num = 1;
				if (qS8() != null)
				{
					goto IL_0005;
				}
			}
			else
			{
				char c = P_0.Read();
				if (c == '\n' || !char.IsWhiteSpace(c))
				{
					if (flag && c == '\n')
					{
						P_2.DeleteText(offset, P_0.Offset - 1 - offset);
					}
					flag = false;
					offset = P_0.Offset;
					continue;
				}
				flag = true;
				num = 0;
				if (!SSu())
				{
					goto IL_0005;
				}
			}
			goto IL_0009;
			IL_0009:
			switch (num)
			{
			case 1:
				return;
			}
			continue;
			IL_0005:
			num = num2;
			goto IL_0009;
		}
	}

	internal static bool FLM(ITextSnapshot P_0, IList<TextRange> P_1, ITextChangeOptions P_2)
	{
		P_2.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
		ITextChange textChange = P_0.CreateTextChange(TextChangeTypes.TrimTrailingWhitespace, P_2);
		ITextBufferReader bufferReader = P_0.GetReader(0).BufferReader;
		foreach (TextRange item in P_1)
		{
			oLp(bufferReader, item, textChange);
		}
		return textChange.Apply();
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
				if (FLM(view.CurrentSnapshot, view.Selection.GetTextRanges(), new EditorViewTextChangeOptions(view)
				{
					CheckReadOnly = true
				}))
				{
					editorViewSelectionState.Restore();
				}
				return;
			}
		}
		int index = view.CurrentSnapshot.Lines.IndexOf(view.Selection.EndOffset);
		ITextSnapshotLine textSnapshotLine = view.CurrentSnapshot.Lines[index];
		if (textSnapshotLine.Length > 0)
		{
			FLM(view.CurrentSnapshot, new TextRange[1] { textSnapshotLine.TextRange }, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true,
				RetainSelection = true
			});
		}
	}

	internal static bool SSu()
	{
		return ySw == null;
	}

	internal static TrimTrailingWhitespaceAction qS8()
	{
		return ySw;
	}
}
