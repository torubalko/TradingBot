using System;
using System.Collections.Generic;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ConvertSpacesToTabsAction : EditActionBase
{
	internal static ConvertSpacesToTabsAction ikK;

	public ConvertSpacesToTabsAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandConvertSpacesToTabsText));
	}

	private static void ALd(ITextBufferReader P_0, TextRange P_1, ITextChange P_2, int P_3, bool P_4)
	{
		P_1.Normalize();
		P_0.Offset = P_1.StartOffset;
		bool flag = false;
		int num = 0;
		int num2 = 0;
		while (P_0.Offset < P_1.EndOffset)
		{
			char c = P_0.Read();
			if (c == '\n')
			{
				flag = false;
				num = 0;
				num2 = 0;
				continue;
			}
			if (c == ' ' && (!flag || !P_4))
			{
				num++;
			}
			else
			{
				if (num > 0)
				{
					if (c == '\t')
					{
						P_2.DeleteText(P_0.Offset - num - 1, num);
					}
					num = 0;
				}
				if (c == '\t')
				{
					num2 = P_3 - 1;
				}
				else
				{
					flag = true;
				}
			}
			if (++num2 != P_3)
			{
				continue;
			}
			if (num > 0)
			{
				if (num == num2)
				{
					P_2.ReplaceText(P_0.Offset - num, num, Q7Z.tqM(7824));
				}
				num = 0;
			}
			num2 = 0;
		}
	}

	internal static ITextChange TLz(ITextSnapshot P_0, IList<TextRange> P_1, ITextChangeOptions P_2, int P_3, bool P_4)
	{
		P_2.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
		ITextChange textChange = P_0.CreateTextChange(TextChangeTypes.ConvertSpacesToTabs, P_2);
		ITextBufferReader bufferReader = P_0.GetReader(0).BufferReader;
		foreach (TextRange item in P_1)
		{
			ALd(bufferReader, item, textChange, P_3, P_4);
		}
		return textChange;
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
		if (view.Selection.Length > 0)
		{
			IList<TextRange> textRanges = view.Selection.GetTextRanges();
			ITextChange textChange = TLz(view.CurrentSnapshot, textRanges, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			}, view.SyntaxEditor.Document.TabSize, _0020: false);
			if (view.Selection.Ranges.Count < 1)
			{
				bool isBlock = view.Selection.Mode == SelectionModes.Block;
				textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(view.Selection.PositionRange, isBlock);
				textChange.Apply();
				return;
			}
			int num = 0;
			if (!YkC())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				textChange.Apply(textRanges, view.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.ExpandBothEdges);
				return;
			}
		}
		int index = view.CurrentSnapshot.Lines.IndexOf(view.Selection.EndOffset);
		ITextSnapshotLine textSnapshotLine = view.CurrentSnapshot.Lines[index];
		if (textSnapshotLine.Length > 0)
		{
			ITextChange textChange2 = TLz(view.CurrentSnapshot, new TextRange[1] { textSnapshotLine.TextRange }, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			}, view.SyntaxEditor.Document.TabSize, _0020: false);
			textChange2.Apply(new TextRange[1]
			{
				new TextRange(view.Selection.EndOffset)
			}, view.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.Default);
		}
	}

	internal static bool YkC()
	{
		return ikK == null;
	}

	internal static ConvertSpacesToTabsAction Bkr()
	{
		return ikK;
	}
}
