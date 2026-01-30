using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class IndentAction : EditActionBase
{
	private static IndentAction EZB;

	public IndentAction()
	{
		grA.DaB7cz();
		this._002Ector(SR.GetString(SRName.UICommandIndentText));
	}

	protected IndentAction(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
	}

	private static string hnE(IEditorView P_0, int P_1)
	{
		bool flag = P_0 == null || !P_0.SyntaxEditor.Document.AutoConvertTabsToSpaces;
		int num = 0;
		if (!cZ0())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (!flag)
			{
				if (P_1 == -1)
				{
					return new string(' ', P_0.SyntaxEditor.Document.TabSize);
				}
				TextPosition position = P_0.OffsetToPosition(P_1);
				return new string(' ', P_0.SyntaxEditor.Document.TabSize - P_0.GetCharacterColumn(position) % P_0.SyntaxEditor.Document.TabSize);
			}
			return Q7Z.tqM(7824);
		}
	}

	internal static void Dnc(IEditorView P_0, bool P_1)
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
		if (P_0.Selection.Mode == SelectionModes.Block)
		{
			IList<TextRange> textRanges = P_0.Selection.GetTextRanges();
			if (textRanges.Count > 0)
			{
				for (int i = 0; i < textRanges.Count; i++)
				{
					int startOffset = textRanges[i].StartOffset;
					string text = hnE(P_0, startOffset);
					textChange.InsertText(startOffset, text);
				}
				textChange.Apply(P_0.Selection.Ranges, TextRangeTrackingModes.ExpandLastEdge);
			}
			return;
		}
		string text2 = hnE(P_0, -1);
		ITextSnapshot currentSnapshot = P_0.CurrentSnapshot;
		TextPositionRange[] array = P_0.Selection.Ranges.ToArray();
		int num = -1;
		int num2 = 0;
		for (int j = 0; j < array.Length; j++)
		{
			TextPositionRange textPositionRange = array[j];
			int num3 = textPositionRange.FirstPosition.Line;
			int num4 = textPositionRange.LastPosition.Line;
			bool flag = num3 == num4;
			TextPositionRange positionRange = textPositionRange.NormalizedTextPositionRange;
			TextRange textRange = currentSnapshot.PositionRangeToTextRange(positionRange);
			if (!flag && !textRange.IsZeroLength)
			{
				int visibleOffset = P_0.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, textRange.StartOffset), hasFarAffinity: false);
				int endOffset = (textRange.IsZeroLength ? visibleOffset : P_0.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, textRange.EndOffset), hasFarAffinity: true));
				positionRange = currentSnapshot.TextRangeToPositionRange(new TextRange(visibleOffset, endOffset));
				num3 = positionRange.StartPosition.Line;
				num4 = positionRange.EndPosition.Line;
				if (num3 < num4 && positionRange.EndPosition.Character == 0)
				{
					num4--;
				}
			}
			if (P_1 || !flag)
			{
				if (num < num3)
				{
					num = num3;
					num2 = text2.Length;
				}
				else
				{
					num3++;
				}
				int num5 = num2;
				for (int k = num3; k <= num4; k++)
				{
					int offset = currentSnapshot.PositionToOffset(new TextPosition(k, 0));
					textChange.InsertText(offset, text2);
				}
				if (num < num4)
				{
					num = num4;
					num2 = text2.Length;
				}
				array[j] = new TextPositionRange(new TextPosition(positionRange.StartPosition.Line, (positionRange.StartPosition.Character > 0) ? (positionRange.StartPosition.Character + num5) : 0), (num4 < positionRange.EndPosition.Line) ? new TextPosition(positionRange.EndPosition.Line, 0) : new TextPosition(positionRange.EndPosition.Line, positionRange.EndPosition.Character + num2));
			}
			else
			{
				string text3 = hnE(P_0, textRange.StartOffset);
				textChange.ReplaceText(textRange, text3);
				if (num < num4)
				{
					num = num4;
					num2 = 0;
				}
				num2 += text3.Length - textRange.AbsoluteLength;
				array[j] = new TextPositionRange(new TextPosition(positionRange.EndPosition.Line, positionRange.EndPosition.Character + num2));
			}
			if (!textPositionRange.IsNormalized)
			{
				array[j] = new TextPositionRange(array[j].EndPosition, array[j].StartPosition);
			}
		}
		textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array, P_0.Selection.Ranges.PrimaryIndex);
		textChange.Apply();
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
		Dnc(view, _0020: true);
	}

	internal static bool cZ0()
	{
		return EZB == null;
	}

	internal static IndentAction NZ7()
	{
		return EZB;
	}
}
