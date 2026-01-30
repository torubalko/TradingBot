using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DeleteLineAction : EditActionBase
{
	private static DeleteLineAction ESt;

	public DeleteLineAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteLineText));
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
			bool flag = false;
			ITextSnapshot currentSnapshot = view.CurrentSnapshot;
			TextPositionRange[] array = view.Selection.Ranges.ToArray();
			for (int num = array.Length - 1; num >= 0; num--)
			{
				TextPositionRange textPositionRange = array[num];
				TextPosition startPosition = view.GetViewLine(textPositionRange.FirstPosition).StartPosition;
				TextPosition textPosition = currentSnapshot.OffsetToPosition(view.GetViewLine(textPositionRange.LastPosition).EndOffsetIncludingLineTerminator);
				if (textPositionRange.FirstPosition != startPosition || textPositionRange.LastPosition != textPosition)
				{
					array[num] = new TextPositionRange(startPosition, textPosition);
					flag = true;
				}
			}
			if (flag)
			{
				view.Selection.SelectRanges(array);
			}
			EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
			{
				CanApplyToMultipleSelections = true,
				CheckReadOnly = true
			};
			view.DeleteSelectedText(TextChangeTypes.Delete, options);
		}
	}

	internal static bool iSY()
	{
		return ESt == null;
	}

	internal static DeleteLineAction USb()
	{
		return ESt;
	}
}
