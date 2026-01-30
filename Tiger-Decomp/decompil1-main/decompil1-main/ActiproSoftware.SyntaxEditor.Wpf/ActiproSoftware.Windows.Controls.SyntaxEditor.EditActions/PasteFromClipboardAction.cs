using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class PasteFromClipboardAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public IEditorView qSh;

		internal static _003C_003Ec__DisplayClass4_0 F3r;

		public _003C_003Ec__DisplayClass4_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal Range WSZ(ITextViewLine viewLine, Range characterRange)
		{
			if (characterRange.Length == 0 && qSh.SyntaxEditor.IsOverwriteModeActive)
			{
				characterRange = new Range(characterRange.Min, characterRange.Max + 1);
			}
			return characterRange;
		}

		internal static bool I3X()
		{
			return F3r == null;
		}

		internal static _003C_003Ec__DisplayClass4_0 M3E()
		{
			return F3r;
		}
	}

	private IDataStore RL9;

	private static PasteFromClipboardAction MSk;

	public PasteFromClipboardAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandPasteFromClipboardText));
	}

	public PasteFromClipboardAction(IDataStore clipboardData)
	{
		grA.DaB7cz();
		this._002Ector();
		RL9 = clipboardData;
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	public override void Execute(IEditorView view)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals28 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals28.qSh = view;
		if (CS_0024_003C_003E8__locals28.qSh == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IDataStore dataStore = RL9 ?? fTO.WRh();
		if (dataStore == null)
		{
			return;
		}
		string text = dataStore.GetText();
		if (text == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(text) && !CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.IsMultiLine)
		{
			int num = text.IndexOfAny(new char[2] { '\r', '\n' });
			if (num != -1)
			{
				text = text.Substring(0, num);
			}
		}
		PasteDragDropEventArgs e = new PasteDragDropEventArgs(PasteDragDropAction.Paste, dataStore, text);
		CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.Uxj(e);
		if (e.Text == null)
		{
			return;
		}
		if (CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.Document != null && (CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.Document.WhitespaceTrimModes & WhitespaceTrimModes.TrailingOnPaste) == WhitespaceTrimModes.TrailingOnPaste)
		{
			string text2 = e.Text;
			if (StringHelper.TrimTrailingWhitespace(ref text2))
			{
				e.Text = text2;
			}
		}
		if (!CS_0024_003C_003E8__locals28.qSh.Selection.IsReadOnly)
		{
			switch (dataStore.TextKind)
			{
			case DataStoreTextKind.FullLine:
			{
				ITextChange textChange2 = CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.Document.CreateTextChange(TextChangeTypes.Paste, new EditorViewTextChangeOptions(CS_0024_003C_003E8__locals28.qSh)
				{
					CheckReadOnly = true,
					OffsetDelta = TextChangeOffsetDelta.SequentialOnly
				});
				int num3 = -1;
				IEditorViewSelectionState editorViewSelectionState = CS_0024_003C_003E8__locals28.qSh.Selection.CaptureState();
				TextRange[] array3 = new TextRange[editorViewSelectionState.Ranges.Count];
				for (int num4 = 0; num4 < editorViewSelectionState.Ranges.Count; num4++)
				{
					TextPositionRange textPositionRange = editorViewSelectionState.Ranges[num4];
					int num5 = CS_0024_003C_003E8__locals28.qSh.PositionToOffset(new TextPosition(textPositionRange.FirstPosition.Line, 0));
					if (num5 != num3)
					{
						textChange2.InsertText(num5, e.Text);
						num3 = num5;
					}
					int num6 = CS_0024_003C_003E8__locals28.qSh.PositionToOffset(textPositionRange.FirstPosition);
					if (!textPositionRange.IsZeroLength)
					{
						int num7 = CS_0024_003C_003E8__locals28.qSh.PositionToOffset(textPositionRange.LastPosition);
						if (num6 < num7)
						{
							textChange2.DeleteText(new TextRange(num6, num7));
						}
					}
					array3[num4] = new TextRange(num6);
				}
				textChange2.Apply(array3, editorViewSelectionState.Ranges.PrimaryIndex, TextRangeTrackingModes.Default);
				break;
			}
			case DataStoreTextKind.Block:
			{
				string text3 = e.Text;
				if (text3.Length > 1 && text3[text3.Length - 1] == '\n')
				{
					text3 = ((text3[text3.Length - 2] != '\r') ? text3.Substring(0, text3.Length - 1) : text3.Substring(0, text3.Length - 2));
				}
				CS_0024_003C_003E8__locals28.qSh.ReplaceSelectedText(TextChangeTypes.Paste, text3, new EditorViewTextChangeOptions(CS_0024_003C_003E8__locals28.qSh)
				{
					CheckReadOnly = true,
					IsBlock = true
				});
				break;
			}
			default:
			{
				if (CS_0024_003C_003E8__locals28.qSh.Selection.Mode == SelectionModes.ContinuousStream && CS_0024_003C_003E8__locals28.qSh.Selection.Ranges.Count > 1 && CS_0024_003C_003E8__locals28.qSh.Selection.Ranges.Count == StringHelper.GetTextPositionDelta(e.Text).DisplayLine)
				{
					IList<string> list = StringHelper.ConvertTextToLines(e.Text);
					if (CS_0024_003C_003E8__locals28.qSh.Selection.Ranges.Count == list.Count)
					{
						ITextChange textChange = CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.Document.CreateTextChange(TextChangeTypes.Paste, new EditorViewTextChangeOptions(CS_0024_003C_003E8__locals28.qSh)
						{
							CheckReadOnly = true
						});
						ITextSnapshot currentSnapshot = CS_0024_003C_003E8__locals28.qSh.CurrentSnapshot;
						TextPositionRange[] array = CS_0024_003C_003E8__locals28.qSh.Selection.Ranges.ToArray();
						TextRange[] array2 = new TextRange[array.Length];
						for (int num2 = array.Length - 1; num2 >= 0; num2--)
						{
							TextRange textRange = currentSnapshot.PositionRangeToTextRange(array[num2]);
							string insertText = list[num2];
							textChange.ReplaceText(textRange, insertText);
							array2[num2] = new TextRange(textRange.FirstOffset);
						}
						textChange.Apply(array2, CS_0024_003C_003E8__locals28.qSh.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.Default);
						break;
					}
				}
				EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(CS_0024_003C_003E8__locals28.qSh)
				{
					CanApplyToBlockEdit = true,
					CanApplyToMultipleSelections = true,
					CheckReadOnly = true
				};
				editorViewTextChangeOptions.BlockEditRangeAdjustFunc = delegate(ITextViewLine viewLine, Range characterRange)
				{
					if (characterRange.Length == 0 && CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.IsOverwriteModeActive)
					{
						characterRange = new Range(characterRange.Min, characterRange.Max + 1);
					}
					return characterRange;
				};
				CS_0024_003C_003E8__locals28.qSh.ReplaceSelectedText(TextChangeTypes.Paste, e.Text, editorViewTextChangeOptions);
				break;
			}
			}
		}
		e = new PasteDragDropEventArgs(PasteDragDropAction.PasteComplete, dataStore, e.Text);
		CS_0024_003C_003E8__locals28.qSh.SyntaxEditor.Uxj(e);
	}

	public override void ReadFromXml(XmlReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195884));
		}
		string attribute = reader.GetAttribute(Q7Z.tqM(7058));
		if (attribute == null)
		{
			return;
		}
		DataStoreTextKind result = DataStoreTextKind.Default;
		int num = 0;
		if (!rSZ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		string attribute2 = reader.GetAttribute(Q7Z.tqM(195900));
		if (!string.IsNullOrEmpty(attribute2) && !Enum.TryParse<DataStoreTextKind>(attribute2, out result))
		{
			result = DataStoreTextKind.Default;
		}
		IDataStore dataStore = fTO.ARZ();
		dataStore.SetText(attribute, result);
		RL9 = dataStore;
	}

	public override void WriteToXml(XmlWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(195920));
		}
		if (RL9 == null)
		{
			return;
		}
		string text = RL9.GetText();
		int num = 0;
		if (!rSZ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (text != null)
		{
			writer.WriteAttributeString(Q7Z.tqM(7058), text);
			writer.WriteAttributeString(Q7Z.tqM(195900), RL9.TextKind.ToString());
		}
	}

	internal static bool rSZ()
	{
		return MSk == null;
	}

	internal static PasteFromClipboardAction sSF()
	{
		return MSk;
	}
}
