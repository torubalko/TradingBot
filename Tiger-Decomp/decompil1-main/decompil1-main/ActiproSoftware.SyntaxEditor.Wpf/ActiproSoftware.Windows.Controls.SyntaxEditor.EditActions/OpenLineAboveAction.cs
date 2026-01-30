using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class OpenLineAboveAction : EditActionBase
{
	private static OpenLineAboveAction vkm;

	public OpenLineAboveAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandOpenLineAboveText));
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
			IEditorDocument document = view.SyntaxEditor.Document;
			ITextSnapshot currentSnapshot = view.CurrentSnapshot;
			EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
			{
				CanApplyToMultipleSelections = true,
				CheckReadOnly = true,
				VirtualCharacterFill = false
			};
			ITextChange textChange = currentSnapshot.CreateTextChange(TextChangeTypes.OpenLine, options);
			int num = view.Selection.Ranges.PrimaryIndex;
			TextPositionRange[] array = view.Selection.Ranges.ToArray();
			List<TextPosition> list = new List<TextPosition>(array.Length);
			TextPosition textPosition = TextPosition.Empty;
			for (int num2 = array.Length - 1; num2 >= 0; num2--)
			{
				TextPosition firstPosition = array[num2].FirstPosition;
				TextPosition startPosition = view.GetViewLine(firstPosition).StartPosition;
				if (startPosition != textPosition)
				{
					textPosition = startPosition;
					list.Add(startPosition);
				}
				else if (num2 < num)
				{
					num = Math.Max(0, num - 1);
				}
			}
			list.Reverse();
			TextPositionRange[] array2 = new TextPositionRange[list.Count];
			for (int num3 = list.Count - 1; num3 >= 0; num3--)
			{
				TextPosition position = list[num3];
				int offset = currentSnapshot.PositionToOffset(position);
				IIndentProvider indentProvider = document.Language.GetIndentProvider();
				string text = null;
				if (indentProvider == null || indentProvider.Mode != IndentMode.None)
				{
					ITextSnapshotLine textSnapshotLine = currentSnapshot.Lines[position.Line];
					int firstNonWhitespaceCharacterOffset = textSnapshotLine.FirstNonWhitespaceCharacterOffset;
					int num4 = textSnapshotLine.GetIndentAmountBefore(firstNonWhitespaceCharacterOffset);
					if (indentProvider != null && indentProvider.Mode == IndentMode.Smart)
					{
						num4 = Math.Max(0, indentProvider.GetIndentAmount(new TextSnapshotOffset(currentSnapshot, firstNonWhitespaceCharacterOffset), num4));
					}
					text = StringHelper.GetIndentText(document.AutoConvertTabsToSpaces, document.TabSize, num4);
				}
				array2[num3] = new TextPositionRange(new TextPosition(position.Line + num3, position.Character + (text?.Length ?? 0)));
				textChange.InsertText(offset, text + Q7Z.tqM(7894));
			}
			textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array2, num);
			textChange.Apply();
		}
	}

	internal static bool Ykp()
	{
		return vkm == null;
	}

	internal static OpenLineAboveAction Ck4()
	{
		return vkm;
	}
}
