using System;
using System.Collections.Generic;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ConvertTabsToSpacesAction : EditActionBase
{
	private static ConvertTabsToSpacesAction CkX;

	public ConvertTabsToSpacesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandConvertTabsToSpacesText));
	}

	private static void nnW(ITextBufferReader P_0, TextRange P_1, ITextChange P_2, int P_3, bool P_4)
	{
		P_1.Normalize();
		P_0.Offset = P_1.StartOffset;
		int num = 0;
		int num3 = default(int);
		int num4 = default(int);
		while (P_0.Offset < P_1.EndOffset)
		{
			char c = P_0.Read();
			char c2 = c;
			char c3 = c2;
			int num2;
			if (c3 != '\t')
			{
				if (c3 == '\n')
				{
					num = 0;
					continue;
				}
				num++;
				if (!P_4)
				{
					continue;
				}
				num2 = 3;
				if (Mkw() != null)
				{
					goto IL_0005;
				}
			}
			else
			{
				num3 = P_0.Offset - 1;
				num2 = 0;
				if (Mkw() != null)
				{
					goto IL_0005;
				}
			}
			goto IL_0009;
			IL_0005:
			num2 = num4;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				default:
				{
					int num5 = P_3 - num % P_3;
					while (P_0.Offset < P_1.EndOffset && P_0.Peek() == '\t')
					{
						P_0.Read();
						num5 += P_3;
					}
					num += num5;
					P_2.ReplaceText(num3, P_0.Offset - num3, new string(' ', num5));
					break;
				}
				case 2:
					if (P_0.Offset < P_1.EndOffset && P_0.Peek() != '\n')
					{
						goto IL_0134;
					}
					break;
				case 1:
					break;
				case 3:
					if (!char.IsWhiteSpace(c))
					{
						goto case 2;
					}
					break;
				}
				break;
				IL_0134:
				P_0.Read();
				num2 = 2;
			}
		}
	}

	internal static ITextChange unP(ITextSnapshot P_0, IList<TextRange> P_1, ITextChangeOptions P_2, int P_3, bool P_4)
	{
		P_2.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
		ITextChange textChange = P_0.CreateTextChange(TextChangeTypes.ConvertTabsToSpaces, P_2);
		ITextBufferReader bufferReader = P_0.GetReader(0).BufferReader;
		foreach (TextRange item in P_1)
		{
			nnW(bufferReader, item, textChange, P_3, P_4);
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
		IList<TextRange> textRanges = default(IList<TextRange>);
		ITextChange textChange = default(ITextChange);
		bool flag = default(bool);
		int num;
		ITextSnapshotLine textSnapshotLine = default(ITextSnapshotLine);
		if (view.Selection.Length > 0)
		{
			textRanges = view.Selection.GetTextRanges();
			textChange = unP(view.CurrentSnapshot, textRanges, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			}, view.SyntaxEditor.Document.TabSize, _0020: false);
			flag = view.Selection.Ranges.Count >= 1;
			num = 1;
			if (lkE())
			{
				num = 1;
			}
		}
		else
		{
			int index = view.CurrentSnapshot.Lines.IndexOf(view.Selection.EndOffset);
			textSnapshotLine = view.CurrentSnapshot.Lines[index];
			num = 0;
			if (!lkE())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
		{
			if (flag)
			{
				textChange.Apply(textRanges, view.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.ExpandBothEdges);
				return;
			}
			bool isBlock = view.Selection.Mode == SelectionModes.Block;
			textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(view.Selection.PositionRange, isBlock);
			textChange.Apply();
			return;
		}
		}
		if (textSnapshotLine.Length > 0)
		{
			ITextChange textChange2 = unP(view.CurrentSnapshot, new TextRange[1] { textSnapshotLine.TextRange }, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			}, view.SyntaxEditor.Document.TabSize, _0020: false);
			textChange2.Apply(new TextRange[1]
			{
				new TextRange(view.Selection.EndOffset)
			}, view.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.Default);
		}
	}

	internal static bool lkE()
	{
		return CkX == null;
	}

	internal static ConvertTabsToSpacesAction Mkw()
	{
		return CkX;
	}
}
