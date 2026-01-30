using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveRightAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public IEditorView I9n;

		public bool B98;

		internal static _003C_003Ec__DisplayClass1_0 ovN;

		public _003C_003Ec__DisplayClass1_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal TextPositionRange N9L(TextPositionRange sr)
		{
			ITextPositionFinder positionFinder = I9n.PositionFinder;
			TextPositionRange textPositionRange = sr;
			return new TextPositionRange(positionFinder.GetPositionForCharacterDelta(textPositionRange.EndPosition, 1, B98, forceVirtualSpace: false));
		}

		internal static bool CvH()
		{
			return ovN == null;
		}

		internal static _003C_003Ec__DisplayClass1_0 ovj()
		{
			return ovN;
		}
	}

	private static MoveRightAction BFl;

	public MoveRightAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveRightText));
	}

	public override void Execute(IEditorView view)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals10.I9n = view;
		if (CS_0024_003C_003E8__locals10.I9n == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (CS_0024_003C_003E8__locals10.I9n.Selection.Ranges.Any((TextPositionRange r) => !r.IsZeroLength))
		{
			CS_0024_003C_003E8__locals10.I9n.Selection.CollapseRight();
			return;
		}
		CS_0024_003C_003E8__locals10.B98 = CS_0024_003C_003E8__locals10.I9n.SyntaxEditor.CanMoveCaretToNextLineAtLineEnd;
		IEnumerable<TextPositionRange> positionRanges = CS_0024_003C_003E8__locals10.I9n.Selection.Ranges.ToArray().Select(delegate(TextPositionRange sr)
		{
			ITextPositionFinder positionFinder = CS_0024_003C_003E8__locals10.I9n.PositionFinder;
			TextPositionRange textPositionRange = sr;
			return new TextPositionRange(positionFinder.GetPositionForCharacterDelta(textPositionRange.EndPosition, 1, CS_0024_003C_003E8__locals10.B98, forceVirtualSpace: false));
		});
		CS_0024_003C_003E8__locals10.I9n.Selection.SelectRanges(positionRanges);
	}

	internal static bool pFW()
	{
		return BFl == null;
	}

	internal static MoveRightAction AFS()
	{
		return BFl;
	}
}
