using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DeleteToLineEndAction : EditActionBase
{
	internal static DeleteToLineEndAction MSs;

	public DeleteToLineEndAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteToLineEndText));
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
			int num2 = 0;
			if (ASo() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			case 1:
			{
				TextPositionRange textPositionRange = array[num];
				ITextViewLine viewLine = view.GetViewLine(textPositionRange.LastPosition);
				TextPosition endPosition = viewLine.EndPosition;
				if (textPositionRange.LastPosition != endPosition)
				{
					array[num] = new TextPositionRange(textPositionRange.FirstPosition, endPosition);
					flag = true;
				}
				num--;
				goto default;
			}
			default:
			{
				if (num >= 0)
				{
					goto case 1;
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
				break;
			}
			}
		}
	}

	internal static bool FSP()
	{
		return MSs == null;
	}

	internal static DeleteToLineEndAction ASo()
	{
		return MSs;
	}
}
