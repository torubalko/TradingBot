using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class DeleteAction : EditActionBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public Dictionary<TextPosition, int> K9g;

		public TextPositionRange[] N9Q;

		internal static _003C_003Ec__DisplayClass2_0 cv7;

		public _003C_003Ec__DisplayClass2_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal TextPositionRange g9D(TextPosition position)
		{
			if (K9g != null && K9g.TryGetValue(position, out var value))
			{
				return N9Q[value];
			}
			return new TextPositionRange(position);
		}

		internal static bool Ivn()
		{
			return cv7 == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 Pvq()
		{
			return cv7;
		}
	}

	internal static DeleteAction rSv;

	public DeleteAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandDeleteText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.Selection.Ranges.Count == 1 && view.Selection.IsZeroLength)
		{
			TextRange textRange = view.Selection.TextRange;
			if (textRange.IsZeroLength && textRange.EndOffset >= view.CurrentSnapshot.Length)
			{
				return false;
			}
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass2_0();
			bool flag = false;
			bool flag2 = true;
			CS_0024_003C_003E8__locals14.N9Q = view.Selection.Ranges.ToArray();
			CS_0024_003C_003E8__locals14.K9g = null;
			for (int num = CS_0024_003C_003E8__locals14.N9Q.Length - 1; num >= 0; num--)
			{
				TextPositionRange textPositionRange = CS_0024_003C_003E8__locals14.N9Q[num];
				if (textPositionRange.IsZeroLength)
				{
					ITextSnapshot currentSnapshot = view.CurrentSnapshot;
					int num2 = currentSnapshot.PositionToOffset(textPositionRange.EndPosition);
					if (view.IsVirtualCharacter(textPositionRange.EndPosition, lineTerminatorsAreVirtual: true))
					{
						if (num2 < currentSnapshot.Length)
						{
							int num3 = Math.Min(currentSnapshot.Length, Math.Max(num2 + 1, view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, num2 + 1), hasFarAffinity: true)));
							if (vAE.u0u(view.CurrentSnapshot[num3]))
							{
								num3++;
							}
							CS_0024_003C_003E8__locals14.N9Q[num] = new TextPositionRange(textPositionRange.EndPosition, currentSnapshot.OffsetToPosition(num3));
							flag = true;
							flag2 = false;
						}
					}
					else
					{
						int num4 = Math.Min(currentSnapshot.Length, Math.Max(num2 + 1, view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(currentSnapshot, num2), hasFarAffinity: true)));
						if (vAE.u0u(view.CurrentSnapshot[num4]))
						{
							num4++;
						}
						CS_0024_003C_003E8__locals14.N9Q[num] = currentSnapshot.TextRangeToPositionRange(new TextRange(num2, num4));
						flag = true;
						flag2 = false;
					}
					if (CS_0024_003C_003E8__locals14.K9g == null)
					{
						CS_0024_003C_003E8__locals14.K9g = new Dictionary<TextPosition, int>();
					}
					CS_0024_003C_003E8__locals14.K9g[textPositionRange.EndPosition] = num;
				}
				else if (textPositionRange.Lines == 1 && view.IsVirtualCharacter(textPositionRange.FirstPosition, lineTerminatorsAreVirtual: true))
				{
					CS_0024_003C_003E8__locals14.N9Q[num] = new TextPositionRange(textPositionRange.FirstPosition);
					flag = true;
				}
				else
				{
					flag2 = false;
				}
			}
			if (flag2)
			{
				if (flag)
				{
					view.Selection.SelectRanges(CS_0024_003C_003E8__locals14.N9Q);
				}
				return;
			}
			EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(view)
			{
				CanApplyToMultipleSelections = true,
				CheckReadOnly = true
			};
			editorViewTextChangeOptions.BlockEditRangeAdjustFunc = delegate(ITextViewLine viewLine, Range characterRange)
			{
				if (characterRange.Length == 0)
				{
					characterRange = new Range(characterRange.Min, characterRange.Max + 1);
				}
				return characterRange;
			};
			editorViewTextChangeOptions.ZeroLengthEditRangeAdjustFunc = (TextPosition position) => (CS_0024_003C_003E8__locals14.K9g != null && CS_0024_003C_003E8__locals14.K9g.TryGetValue(position, out var value)) ? CS_0024_003C_003E8__locals14.N9Q[value] : new TextPositionRange(position);
			view.DeleteSelectedText(TextChangeTypes.Delete, editorViewTextChangeOptions);
		}
	}

	internal static bool NSf()
	{
		return rSv == null;
	}

	internal static DeleteAction mSi()
	{
		return rSv;
	}
}
