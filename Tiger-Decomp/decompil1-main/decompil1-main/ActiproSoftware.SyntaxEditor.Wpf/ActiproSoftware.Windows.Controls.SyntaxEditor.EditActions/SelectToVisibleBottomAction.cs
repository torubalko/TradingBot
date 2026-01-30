using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToVisibleBottomAction : EditActionBase
{
	private static SelectToVisibleBottomAction CRv;

	public SelectToVisibleBottomAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToVisibleBottomText));
	}

	public override void Execute(IEditorView view)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					if (flag)
					{
						throw new ArgumentNullException(Q7Z.tqM(952));
					}
					SelectionModes mode = view.Selection.Mode;
					if (!view.SyntaxEditor.IsSelectionModeAllowed(mode))
					{
						return;
					}
					ITextViewLine textViewLine = view.VisibleViewLines.LastOrDefault((ITextViewLine l) => l.Visibility == TextViewLineVisibility.FullyVisible);
					if (textViewLine != null)
					{
						double x = view.Selection.GetPreferredCaretHorizontalLocations()[view.Selection.Ranges.PrimaryIndex];
						TextPosition endPosition = textViewLine.LocationToPosition(x, LocationToPositionAlgorithm.BestFit);
						using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
						{
							view.Selection.SelectRange(new TextPositionRange(view.Selection.StartPosition, endPosition), mode);
							return;
						}
					}
					return;
				}
				case 1:
					break;
				}
				flag = view == null;
				num2 = 0;
			}
			while (kRi() == null);
		}
	}

	internal static bool NRf()
	{
		return CRv == null;
	}

	internal static SelectToVisibleBottomAction kRi()
	{
		return CRv;
	}
}
