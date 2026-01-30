using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectLeftAction : EditActionBase
{
	private static SelectLeftAction gJ8;

	public SelectLeftAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectLeftText));
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
		bool canMoveCaretToPreviousLineAtLineStart = view.SyntaxEditor.CanMoveCaretToPreviousLineAtLineStart;
		int num = 1;
		if (DJe() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		TextPositionRange[] array = default(TextPositionRange[]);
		int num2 = default(int);
		do
		{
			switch (num)
			{
			case 1:
				array = view.Selection.Ranges.ToArray();
				num2 = array.Length - 1;
				break;
			}
			if (num2 < 0)
			{
				if (array.Length == 1)
				{
					view.Selection.SelectRange(array[0], mode);
				}
				else
				{
					view.Selection.SelectRanges(array);
				}
				return;
			}
			array[num2] = new TextPositionRange(array[num2].StartPosition, view.PositionFinder.GetPositionForCharacterDelta(array[num2].EndPosition, -1, canMoveCaretToPreviousLineAtLineStart, forceVirtualSpace: false));
			num2--;
			num = 0;
		}
		while (DJe() == null);
		goto IL_0005;
		IL_0005:
		int num3 = default(int);
		num = num3;
		goto IL_0009;
	}

	internal static bool NJU()
	{
		return gJ8 == null;
	}

	internal static SelectLeftAction DJe()
	{
		return gJ8;
	}
}
