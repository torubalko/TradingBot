using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToLineEndAction : EditActionBase
{
	private static SelectToLineEndAction TRl;

	public SelectToLineEndAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToLineEndText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		SelectionModes mode = view.Selection.Mode;
		bool flag = !view.SyntaxEditor.IsSelectionModeAllowed(mode);
		int num = 1;
		if (XRS() != null)
		{
			num = 0;
		}
		TextPositionRange[] array = default(TextPositionRange[]);
		int num2 = default(int);
		bool isVirtualLine = default(bool);
		TextPositionRange textPositionRange = default(TextPositionRange);
		ITextViewLine viewLine = default(ITextViewLine);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (flag)
				{
					return;
				}
				array = view.Selection.Ranges.ToArray();
				num2 = array.Length - 1;
				break;
			default:
				if (isVirtualLine)
				{
					array[num2] = new TextPositionRange(textPositionRange.StartPosition, viewLine.StartPosition);
				}
				else
				{
					array[num2] = new TextPositionRange(textPositionRange.StartPosition, viewLine.EndPosition);
				}
				num2--;
				break;
			}
			if (num2 < 0)
			{
				if (array.Length != 1)
				{
					view.Selection.SelectRanges(array);
				}
				else
				{
					view.Selection.SelectRange(array[0], mode);
				}
				break;
			}
			textPositionRange = array[num2];
			viewLine = view.GetViewLine(textPositionRange.EndPosition);
			isVirtualLine = viewLine.IsVirtualLine;
			num = 0;
			if (!QRW())
			{
				num = num3;
			}
		}
	}

	internal static bool QRW()
	{
		return TRl == null;
	}

	internal static SelectToLineEndAction XRS()
	{
		return TRl;
	}
}
