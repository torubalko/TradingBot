using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CollapseSelectionRightAction : EditActionBase
{
	private static CollapseSelectionRightAction LJ3;

	public CollapseSelectionRightAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCollapseSelectionRightText));
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
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEnumerable<TextPositionRange> positionRanges = view.Selection.Ranges.ToArray().Select(delegate(TextPositionRange sr)
		{
			TextPositionRange textPositionRange = sr;
			return new TextPositionRange(textPositionRange.LastPosition);
		});
		view.Selection.SelectRanges(positionRanges);
	}

	internal static bool yJv()
	{
		return LJ3 == null;
	}

	internal static CollapseSelectionRightAction xJf()
	{
		return LJ3;
	}
}
