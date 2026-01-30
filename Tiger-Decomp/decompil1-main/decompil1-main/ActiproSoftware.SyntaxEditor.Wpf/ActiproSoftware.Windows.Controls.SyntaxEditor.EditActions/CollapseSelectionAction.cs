using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CollapseSelectionAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public bool W9J;

		private static _003C_003Ec__DisplayClass2_0 hvy;

		public _003C_003Ec__DisplayClass2_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal TextPositionRange z9U(TextPositionRange sr)
		{
			TextPosition position;
			if (W9J)
			{
				TextPositionRange textPositionRange = sr;
				position = textPositionRange.StartPosition;
			}
			else
			{
				TextPositionRange textPositionRange = sr;
				position = textPositionRange.EndPosition;
			}
			return new TextPositionRange(position);
		}

		internal static bool Vvh()
		{
			return hvy == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 vv6()
		{
			return hvy;
		}
	}

	private static CollapseSelectionAction BJ5;

	public CollapseSelectionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCollapseSelectionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return view.Selection.Ranges.Count > 0 || view.Selection.Ranges.Any((TextPositionRange pr) => !pr.IsZeroLength);
	}

	public override void Execute(IEditorView view)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass2_0();
		bool flag = view == null;
		int num = 0;
		if (BJN() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.Selection.Ranges.Count <= 1)
		{
			CS_0024_003C_003E8__locals2.W9J = view.SyntaxEditor.SelectionCollapsesToAnchor;
			IEnumerable<TextPositionRange> positionRanges = view.Selection.Ranges.ToArray().Select(delegate(TextPositionRange sr)
			{
				TextPosition position;
				if (CS_0024_003C_003E8__locals2.W9J)
				{
					TextPositionRange textPositionRange = sr;
					position = textPositionRange.StartPosition;
				}
				else
				{
					TextPositionRange textPositionRange = sr;
					position = textPositionRange.EndPosition;
				}
				return new TextPositionRange(position);
			});
			view.Selection.SelectRanges(positionRanges);
		}
		else
		{
			view.Selection.SelectRange(view.Selection.PositionRange);
		}
	}

	internal static bool qJG()
	{
		return BJ5 == null;
	}

	internal static CollapseSelectionAction BJN()
	{
		return BJ5;
	}
}
