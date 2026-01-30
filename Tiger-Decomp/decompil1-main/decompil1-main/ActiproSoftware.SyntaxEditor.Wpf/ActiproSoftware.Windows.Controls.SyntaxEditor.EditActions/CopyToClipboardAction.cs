using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CopyToClipboardAction : EditActionBase
{
	private static CopyToClipboardAction XS0;

	protected virtual bool Append => false;

	public CopyToClipboardAction()
	{
		grA.DaB7cz();
		this._002Ector(SR.GetString(SRName.UICommandCopyToClipboardText));
	}

	protected CopyToClipboardAction(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal static void eLS(IEditorView P_0, bool P_1, bool P_2, bool P_3)
	{
		IDataStore dataStore = null;
		string text = null;
		if (P_1)
		{
			dataStore = fTO.WRh();
			if (dataStore != null)
			{
				text = dataStore.GetText();
			}
		}
		if (text == null)
		{
			text = string.Empty;
		}
		dataStore = fTO.ARZ();
		if (dataStore == null)
		{
			return;
		}
		IHighlightingStyleRegistry highlightingStyleRegistry = ((P_0.SyntaxEditor.PrintSettings != null) ? P_0.SyntaxEditor.PrintSettings.HighlightingStyleRegistry : null) ?? P_0.SyntaxEditor.HighlightingStyleRegistry;
		ITextSnapshot currentSnapshot = P_0.CurrentSnapshot;
		List<TextRange> list = new List<TextRange>();
		ITextSnapshotLine textSnapshotLine = null;
		ITextSnapshotLine textSnapshotLine2 = null;
		bool flag = P_3 || (P_0.Selection.IsZeroLength && P_0.Selection.Ranges.Count == 1);
		if (flag)
		{
			TextPosition firstPosition = P_0.Selection.FirstPosition;
			TextPosition lastPosition = P_0.Selection.LastPosition;
			if (P_0.IsVirtualLine(firstPosition.Line) || P_0.IsVirtualLine(lastPosition.Line))
			{
				return;
			}
			ITextViewLine viewLine = P_0.GetViewLine(firstPosition);
			ITextViewLine viewLine2 = P_0.GetViewLine(lastPosition);
			if (viewLine == null || viewLine2 == null)
			{
				return;
			}
			textSnapshotLine = currentSnapshot.Lines[viewLine.StartPosition.Line];
			textSnapshotLine2 = currentSnapshot.Lines[viewLine2.EndPosition.Line];
			string substring = currentSnapshot.GetSubstring(new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffset), LineTerminator.CarriageReturnNewline);
			if (!P_3 && !P_0.SyntaxEditor.CanCutCopyBlankLineWhenNoSelection && substring.Trim().Length == 0)
			{
				if (P_2)
				{
					P_0.SyntaxEditor.Document.DeleteText(TextChangeTypes.Cut, new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffsetIncludingLineTerminator), new EditorViewTextChangeOptions(P_0)
					{
						CheckReadOnly = true
					});
				}
				return;
			}
			DataStoreTextKind textKind = ((!textSnapshotLine2.IsLastLine) ? DataStoreTextKind.FullLine : DataStoreTextKind.Default);
			dataStore.SetText(text + substring + (textSnapshotLine2.IsLastLine ? string.Empty : Q7Z.tqM(7886)), textKind);
			list.Add(new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffsetIncludingLineTerminator));
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (TextRange textRange in P_0.Selection.GetTextRanges())
			{
				if (!textRange.IsZeroLength || P_0.Selection.Mode == SelectionModes.Block)
				{
					list.Add(textRange);
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(Q7Z.tqM(7886));
					}
					stringBuilder.Append(currentSnapshot.GetSubstring(textRange, LineTerminator.CarriageReturnNewline));
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			if (!string.IsNullOrEmpty(text) && list.Count > 1)
			{
				stringBuilder.Insert(0, Q7Z.tqM(7886));
			}
			DataStoreTextKind textKind2 = ((P_0.Selection.Mode == SelectionModes.Block) ? DataStoreTextKind.Block : DataStoreTextKind.Default);
			dataStore.SetText(text + stringBuilder, textKind2);
		}
		if (dataStore is cTH cTH)
		{
			cTH.mY3(P_0.SyntaxEditor, currentSnapshot, list);
		}
		P_0.SyntaxEditor.mxe(new CutCopyDragEventArgs(P_2 ? CutCopyDragAction.Cut : CutCopyDragAction.Copy, dataStore));
		fTO.iRN(dataStore);
		if (P_2)
		{
			if (flag)
			{
				if (textSnapshotLine.StartOffset < textSnapshotLine2.EndOffsetIncludingLineTerminator)
				{
					P_0.SyntaxEditor.Document.DeleteText(TextChangeTypes.Cut, new TextRange(textSnapshotLine.StartOffset, textSnapshotLine2.EndOffsetIncludingLineTerminator), new EditorViewTextChangeOptions(P_0)
					{
						CheckReadOnly = true
					});
				}
			}
			else
			{
				P_0.DeleteSelectedText(TextChangeTypes.Cut, new EditorViewTextChangeOptions(P_0)
				{
					CanApplyToMultipleSelections = true,
					CheckReadOnly = true,
					VirtualCharacterFill = false
				});
			}
		}
		else if (P_0.SyntaxEditor.SelectionCollapsesOnCopy && list.Any((TextRange tr) => !tr.IsZeroLength))
		{
			new CollapseSelectionAction().Execute(P_0);
		}
	}

	public override void Execute(IEditorView view)
	{
		eLS(view, Append, _0020: false, _0020: false);
	}

	internal static bool iS7()
	{
		return XS0 == null;
	}

	internal static CopyToClipboardAction fSn()
	{
		return XS0;
	}
}
