using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CollapseSelectionLeftAction : EditActionBase
{
	internal static CollapseSelectionLeftAction AJH;

	public CollapseSelectionLeftAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCollapseSelectionLeftText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return view.Selection.Ranges.Any((TextPositionRange pr) => !pr.IsZeroLength);
	}

	public override void Execute(IEditorView view)
	{
		if (view != null)
		{
			IEnumerable<TextPositionRange> positionRanges = view.Selection.Ranges.ToArray().Select(delegate(TextPositionRange sr)
			{
				TextPositionRange textPositionRange = sr;
				return new TextPositionRange(textPositionRange.FirstPosition);
			});
			view.Selection.SelectRanges(positionRanges);
			return;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	internal static bool sJj()
	{
		return AJH == null;
	}

	internal static CollapseSelectionLeftAction wJM()
	{
		return AJH;
	}
}
