using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToLineEndAction : EditActionBase
{
	internal static MoveToLineEndAction PFO;

	public MoveToLineEndAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToLineEndText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		for (int num = array.Length - 1; num >= 0; num--)
		{
			ITextViewLine viewLine = view.GetViewLine(array[num].EndPosition);
			if (viewLine.IsVirtualLine)
			{
				array[num] = new TextPositionRange(viewLine.StartPosition);
			}
			else
			{
				array[num] = new TextPositionRange(viewLine.EndPosition);
			}
		}
		view.Selection.SelectRanges(array);
	}

	internal static bool DF1()
	{
		return PFO == null;
	}

	internal static MoveToLineEndAction CF5()
	{
		return PFO;
	}
}
