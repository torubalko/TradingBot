using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectPageDownAction : EditActionBase
{
	internal static SelectPageDownAction RJz;

	public SelectPageDownAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectPageDownText));
	}

	public override void Execute(IEditorView view)
	{
		int num = 1;
		TextPositionRange[] array = default(TextPositionRange[]);
		ITextPositionFinder positionFinder = default(ITextPositionFinder);
		int fullyVisibleCount = default(int);
		IList<double> preferredCaretHorizontalLocations = default(IList<double>);
		SelectionModes mode = default(SelectionModes);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
				{
					for (int num3 = array.Length - 1; num3 >= 0; num3--)
					{
						array[num3] = new TextPositionRange(array[num3].StartPosition, positionFinder.GetPositionForLineDelta(array[num3].EndPosition, fullyVisibleCount, preferredCaretHorizontalLocations[num3], forceVirtualSpace: false));
					}
					using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
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
				}
				default:
					if (flag)
					{
						throw new ArgumentNullException(Q7Z.tqM(952));
					}
					mode = view.Selection.Mode;
					if (!view.SyntaxEditor.IsSelectionModeAllowed(mode))
					{
						return;
					}
					goto IL_0187;
				case 1:
					flag = view == null;
					num2 = 0;
					if (!TRm())
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0012;
				IL_0187:
				array = view.Selection.Ranges.ToArray();
				preferredCaretHorizontalLocations = view.Selection.GetPreferredCaretHorizontalLocations();
				positionFinder = view.PositionFinder;
				fullyVisibleCount = view.VisibleViewLines.FullyVisibleCount;
				view.Scroller.ScrollVerticallyByLine(fullyVisibleCount);
				num2 = 2;
			}
			while (NRp() == null);
		}
	}

	internal static bool TRm()
	{
		return RJz == null;
	}

	internal static SelectPageDownAction NRp()
	{
		return RJz;
	}
}
