using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveLeftAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public IEditorView L9o;

		public bool h9j;

		internal static _003C_003Ec__DisplayClass1_0 QvJ;

		public _003C_003Ec__DisplayClass1_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal _003C_003Ef__AnonymousType0<TextPositionRange, TextPosition> h94(TextPositionRange sr)
		{
			ITextPositionFinder positionFinder = L9o.PositionFinder;
			TextPositionRange textPositionRange = sr;
			return new
			{
				sr = sr,
				position = positionFinder.GetPositionForCharacterDelta(textPositionRange.EndPosition, -1, h9j, forceVirtualSpace: false)
			};
		}

		internal static bool LvR()
		{
			return QvJ == null;
		}

		internal static _003C_003Ec__DisplayClass1_0 jvO()
		{
			return QvJ;
		}
	}

	internal static MoveLeftAction dF0;

	public MoveLeftAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveLeftText));
	}

	public override void Execute(IEditorView view)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals10.L9o = view;
		if (CS_0024_003C_003E8__locals10.L9o == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!CS_0024_003C_003E8__locals10.L9o.Selection.Ranges.Any((TextPositionRange r) => !r.IsZeroLength))
		{
			CS_0024_003C_003E8__locals10.h9j = CS_0024_003C_003E8__locals10.L9o.SyntaxEditor.CanMoveCaretToPreviousLineAtLineStart;
			IEnumerable<TextPositionRange> positionRanges = from _003C_003Eh__TransparentIdentifier0 in CS_0024_003C_003E8__locals10.L9o.Selection.Ranges.ToArray().Select(delegate(TextPositionRange sr)
				{
					ITextPositionFinder positionFinder = CS_0024_003C_003E8__locals10.L9o.PositionFinder;
					TextPositionRange textPositionRange = sr;
					return new
					{
						sr = sr,
						position = positionFinder.GetPositionForCharacterDelta(textPositionRange.EndPosition, -1, CS_0024_003C_003E8__locals10.h9j, forceVirtualSpace: false)
					};
				})
				select new TextPositionRange(new TextPosition(_003C_003Eh__TransparentIdentifier0.position, hasFarAffinity: true));
			CS_0024_003C_003E8__locals10.L9o.Selection.SelectRanges(positionRanges);
		}
		else
		{
			CS_0024_003C_003E8__locals10.L9o.Selection.CollapseLeft();
		}
	}

	internal static bool KF7()
	{
		return dF0 == null;
	}

	internal static MoveLeftAction hFn()
	{
		return dF0;
	}
}
