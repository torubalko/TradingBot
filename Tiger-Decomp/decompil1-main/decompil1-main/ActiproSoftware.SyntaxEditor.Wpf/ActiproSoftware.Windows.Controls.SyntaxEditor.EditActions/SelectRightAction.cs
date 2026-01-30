using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectRightAction : EditActionBase
{
	internal static SelectRightAction XR0;

	public SelectRightAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectRightText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		SelectionModes mode = view.Selection.Mode;
		if (!view.SyntaxEditor.IsSelectionModeAllowed(mode))
		{
			return;
		}
		bool canMoveCaretToNextLineAtLineEnd = view.SyntaxEditor.CanMoveCaretToNextLineAtLineEnd;
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		int num = array.Length - 1;
		int num3 = default(int);
		while (true)
		{
			bool flag = num >= 0;
			int num2 = 0;
			if (ORn() == null)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					if (flag)
					{
						break;
					}
					if (array.Length == 1)
					{
						num2 = 1;
						if (ORn() != null)
						{
							num2 = num3;
						}
						continue;
					}
					view.Selection.SelectRanges(array);
					return;
				case 1:
					view.Selection.SelectRange(array[0], mode);
					return;
				}
				break;
			}
			array[num] = new TextPositionRange(array[num].StartPosition, view.PositionFinder.GetPositionForCharacterDelta(array[num].EndPosition, 1, canMoveCaretToNextLineAtLineEnd, forceVirtualSpace: false));
			num--;
		}
	}

	internal static bool QR7()
	{
		return XR0 == null;
	}

	internal static SelectRightAction ORn()
	{
		return XR0;
	}
}
