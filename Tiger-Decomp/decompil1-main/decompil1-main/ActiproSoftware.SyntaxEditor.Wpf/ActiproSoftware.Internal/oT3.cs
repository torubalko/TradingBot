using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class oT3 : IEditorViewSelectionState
{
	private SelectionModes yoy;

	private ITextSnapshot Uoq;

	private TextRangeTrackingModes eo2;

	private IEditorView po7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextPositionRangeCollection zoi;

	internal static oT3 oAU;

	public ITextPositionRangeCollection Ranges
	{
		[CompilerGenerated]
		get
		{
			return zoi;
		}
		[CompilerGenerated]
		private set
		{
			zoi = textPositionRangeCollection;
		}
	}

	internal oT3(IEditorView P_0, ITextPositionRangeCollection P_1, SelectionModes P_2, ITextSnapshot P_3, TextRangeTrackingModes P_4)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193530));
		}
		po7 = P_0;
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		Ranges = P_1;
		yoy = P_2;
		Uoq = P_3 ?? P_0.CurrentSnapshot;
		eo2 = P_4;
	}

	public void Restore()
	{
		Restore(_0020: false);
	}

	public void Restore(bool P_0)
	{
		ITextSnapshot currentSnapshot = po7.CurrentSnapshot;
		if (Uoq.Document != currentSnapshot.Document)
		{
			return;
		}
		TextPositionRange[] array = Ranges.ToArray();
		for (int num = array.Length - 1; num >= 0; num--)
		{
			TextPositionRange positionRange = array[num];
			int num2 = Math.Max(0, positionRange.StartPosition.Line + 1 - Uoq.Lines.Count);
			int num3 = Math.Max(0, (num2 > 0) ? positionRange.StartPosition.Character : (positionRange.StartPosition.Character - Uoq.Lines[positionRange.StartPosition.Line].Length));
			int num4;
			int num5;
			if (positionRange.IsZeroLength)
			{
				num4 = num2;
				num5 = num3;
			}
			else
			{
				num4 = Math.Max(0, positionRange.EndPosition.Line + 1 - Uoq.Lines.Count);
				num5 = Math.Max(0, (num4 > 0) ? positionRange.EndPosition.Character : (positionRange.EndPosition.Character - Uoq.Lines[positionRange.EndPosition.Line].Length));
			}
			TextRange textRange = Uoq.PositionRangeToTextRange(positionRange);
			TextSnapshotRange textSnapshotRange = new TextSnapshotRange(Uoq, textRange).TranslateTo(currentSnapshot, eo2);
			TextPosition textPosition = new TextPosition(textSnapshotRange.EndPosition.Line + num4, textSnapshotRange.EndPosition.Character + num5);
			TextPosition textPosition2 = ((!P_0) ? new TextPosition(textSnapshotRange.StartPosition.Line + num2, textSnapshotRange.StartPosition.Character + num3) : ((yoy != SelectionModes.Block) ? textPosition : po7.PositionFinder.GetPositionForLineDelta(textSnapshotRange.EndPosition, textSnapshotRange.StartPosition.Line - textSnapshotRange.EndPosition.Line, null, forceVirtualSpace: true)));
			if (!textRange.IsNormalized)
			{
				TextPosition textPosition3 = textPosition2;
				textPosition2 = textPosition;
				textPosition = textPosition3;
			}
			array[num] = new TextPositionRange(textPosition2, textPosition);
		}
		if (yoy == SelectionModes.Block && array.Length == 1)
		{
			po7.Selection.SelectRange(array[0], yoy);
		}
		else
		{
			po7.Selection.SelectRanges(array, Ranges.PrimaryIndex);
		}
	}

	internal static bool IAe()
	{
		return oAU == null;
	}

	internal static oT3 xAz()
	{
		return oAU;
	}
}
