using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
public class OutdentAction : EditActionBase
{
	internal static OutdentAction AZR;

	public OutdentAction()
	{
		grA.DaB7cz();
		this._002Ector(SR.GetString(SRName.UICommandOutdentText));
	}

	protected OutdentAction(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
	}

	private static int jna(ITextBufferReader P_0, int P_1, ref int P_2)
	{
		int num = 0;
		P_0.Offset = P_2;
		while (!P_0.IsAtStart)
		{
			switch (P_0.ReadReverse())
			{
			case ' ':
				break;
			case '\t':
				P_2--;
				return P_1;
			default:
				return num;
			}
			P_2--;
			if (++num >= P_1)
			{
				return num;
			}
		}
		return num;
	}

	internal static void znx(IEditorView P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ITextChange textChange = P_0.CurrentSnapshot.CreateTextChange(TextChangeTypes.Indent, new EditorViewTextChangeOptions(P_0)
		{
			CheckReadOnly = true,
			OffsetDelta = TextChangeOffsetDelta.SequentialOnly
		});
		ITextSnapshot currentSnapshot = P_0.CurrentSnapshot;
		if (P_0.Selection.Mode == SelectionModes.Block)
		{
			IList<TextRange> textRanges = P_0.Selection.GetTextRanges();
			if (textRanges.Count <= 0)
			{
				return;
			}
			ITextBufferReader bufferReader = currentSnapshot.GetReader(0).BufferReader;
			int tabSize = P_0.SyntaxEditor.Document.TabSize;
			int num = tabSize;
			for (int i = 0; i < textRanges.Count; i++)
			{
				int startOffset = textRanges[i].StartOffset;
				TextPosition textPosition = currentSnapshot.OffsetToPosition(startOffset);
				int val = jna(bufferReader, tabSize, ref startOffset);
				num = Math.Min(num, val);
			}
			if (num <= 0)
			{
				return;
			}
			for (int j = 0; j < textRanges.Count; j++)
			{
				int startOffset2 = textRanges[j].StartOffset;
				int num2 = startOffset2;
				jna(bufferReader, num, ref num2);
				if (num2 < startOffset2)
				{
					textChange.DeleteText(new TextRange(num2, startOffset2));
				}
			}
			textChange.Apply(P_0.Selection.Ranges, TextRangeTrackingModes.Default);
			return;
		}
		TextPositionRange[] array = P_0.Selection.Ranges.ToArray();
		int num3 = -1;
		for (int k = 0; k < array.Length; k++)
		{
			ITextBufferReader bufferReader2 = currentSnapshot.GetReader(0).BufferReader;
			int tabSize2 = P_0.SyntaxEditor.Document.TabSize;
			TextPositionRange textPositionRange = array[k];
			int num4 = textPositionRange.FirstPosition.Line;
			int num5 = textPositionRange.LastPosition.Line;
			bool flag = num4 == num5;
			TextPositionRange normalizedTextPositionRange = textPositionRange.NormalizedTextPositionRange;
			TextRange textRange = currentSnapshot.PositionRangeToTextRange(normalizedTextPositionRange);
			if (!flag && !textRange.IsZeroLength)
			{
				int visibleOffset = P_0.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, textRange.StartOffset), hasFarAffinity: false);
				int endOffset = (textRange.IsZeroLength ? visibleOffset : P_0.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, textRange.EndOffset), hasFarAffinity: true));
				normalizedTextPositionRange = currentSnapshot.TextRangeToPositionRange(new TextRange(visibleOffset, endOffset));
				num4 = normalizedTextPositionRange.StartPosition.Line;
				num5 = normalizedTextPositionRange.EndPosition.Line;
				if (num4 < num5 && normalizedTextPositionRange.EndPosition.Character == 0)
				{
					num5--;
				}
			}
			if (P_1 || !flag)
			{
				if (num3 < num4)
				{
					num3 = num4;
				}
				else
				{
					num4++;
				}
				for (int l = num4; l <= num5; l++)
				{
					int num6 = (bufferReader2.Offset = currentSnapshot.PositionToOffset(new TextPosition(l, 0)));
					int num8 = 0;
					while (num8 < tabSize2 && !bufferReader2.IsAtEnd)
					{
						switch (bufferReader2.Read())
						{
						case ' ':
							num8++;
							break;
						case '\t':
							num8 = tabSize2;
							break;
						default:
							bufferReader2.ReadReverse();
							num8 = int.MaxValue;
							break;
						}
					}
					if (bufferReader2.Offset > num6)
					{
						textChange.DeleteText(new TextRange(num6, bufferReader2.Offset));
					}
				}
				if (num3 < num5)
				{
					num3 = num5;
				}
			}
			else
			{
				int startOffset3 = textRange.StartOffset;
				int num9 = startOffset3;
				jna(bufferReader2, tabSize2, ref num9);
				num3 = num5;
				if (num9 < startOffset3)
				{
					textChange.DeleteText(new TextRange(num9, startOffset3));
				}
			}
		}
		textChange.Apply(P_0.Selection.Ranges, TextRangeTrackingModes.Default);
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
		znx(view, _0020: true);
	}

	internal static bool IZO()
	{
		return AZR == null;
	}

	internal static OutdentAction mZ1()
	{
		return AZR;
	}
}
