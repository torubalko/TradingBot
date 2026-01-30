using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DeleteToLineStartAction : EditActionBase
{
	internal static DeleteToLineStartAction YSQ;

	public DeleteToLineStartAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteToLineStartText));
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
			int num = array.Length - 1;
			int num3 = default(int);
			while (true)
			{
				int num2;
				if (num >= 0)
				{
					TextPositionRange textPositionRange = array[num];
					ITextViewLine viewLine = view.GetViewLine(textPositionRange.FirstPosition);
					TextPosition startPosition = viewLine.StartPosition;
					if (textPositionRange.FirstPosition != startPosition)
					{
						array[num] = new TextPositionRange(startPosition, textPositionRange.LastPosition);
						flag = true;
					}
					num--;
					num2 = 0;
					if (LSh() != null)
					{
						num2 = num3;
					}
				}
				else
				{
					if (!flag)
					{
						break;
					}
					num2 = 0;
					if (NSy())
					{
						num2 = 1;
					}
				}
				switch (num2)
				{
				case 1:
					break;
				default:
					continue;
				}
				view.Selection.SelectRanges(array);
				break;
			}
			EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(view)
			{
				CanApplyToMultipleSelections = true,
				CheckReadOnly = true
			};
			view.DeleteSelectedText(TextChangeTypes.Delete, options);
		}
	}

	internal static bool NSy()
	{
		return YSQ == null;
	}

	internal static DeleteToLineStartAction LSh()
	{
		return YSQ;
	}
}
