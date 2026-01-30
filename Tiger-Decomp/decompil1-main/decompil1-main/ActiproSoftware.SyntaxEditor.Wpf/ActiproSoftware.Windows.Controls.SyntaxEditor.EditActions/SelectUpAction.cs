using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectUpAction : EditActionBase
{
	private static SelectUpAction QRc;

	public SelectUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectUpText));
	}

	public override void Execute(IEditorView view)
	{
		if (view != null)
		{
			SelectionModes mode = view.Selection.Mode;
			if (!view.SyntaxEditor.IsSelectionModeAllowed(mode))
			{
				return;
			}
			TextPositionRange[] array = view.Selection.Ranges.ToArray();
			IList<double> preferredCaretHorizontalLocations = view.Selection.GetPreferredCaretHorizontalLocations();
			ITextPositionFinder positionFinder = view.PositionFinder;
			int num = array.Length - 1;
			int num3 = default(int);
			while (true)
			{
				bool flag = num >= 0;
				int num2 = 1;
				if (jRT() != null)
				{
					num2 = num3;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!flag)
						{
							using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
							{
								if (array.Length != 1)
								{
									view.Selection.SelectRanges(array);
								}
								else
								{
									view.Selection.SelectRange(array[0], mode);
								}
								return;
							}
						}
						array[num] = new TextPositionRange(array[num].StartPosition, positionFinder.GetPositionForLineDelta(array[num].EndPosition, -1, preferredCaretHorizontalLocations[num], mode == SelectionModes.Block));
						num--;
						num2 = 0;
						if (!WRd())
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	internal static bool WRd()
	{
		return QRc == null;
	}

	internal static SelectUpAction jRT()
	{
		return QRc;
	}
}
