using System;
using System.Diagnostics.CodeAnalysis;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public struct TextSnapshotRange : ITextPositionRangeProvider, ITextRangeProvider
{
	private ITextSnapshot PVb;

	private TextRange vVC;

	internal static object AtH;

	TextPositionRange ITextPositionRangeProvider.PositionRange
	{
		get
		{
			return new TextPositionRange(StartPosition, EndPosition);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	TextRange ITextRangeProvider.TextRange
	{
		get
		{
			return vVC;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public int AbsoluteLength => vVC.AbsoluteLength;

	public static TextSnapshotRange Deleted => new TextSnapshotRange(null);

	public ITextSnapshotLine EndLine
	{
		get
		{
			int num = PVb.Lines.IndexOf(vVC.EndOffset);
			return (num != -1) ? PVb.Lines[num] : null;
		}
	}

	public int EndOffset => vVC.EndOffset;

	public TextPosition EndPosition => PVb.OffsetToPosition(vVC.EndOffset);

	public bool IsDeleted => PVb == null || vVC.IsDeleted;

	public bool IsZeroLength => vVC.IsZeroLength;

	public int Length => vVC.Length;

	public TextPositionRange PositionRange => new TextPositionRange(StartPosition, EndPosition);

	public ITextSnapshot Snapshot => PVb;

	public ITextSnapshotLine StartLine
	{
		get
		{
			int num = PVb.Lines.IndexOf(vVC.StartOffset);
			return (num != -1) ? PVb.Lines[num] : null;
		}
	}

	public int StartOffset => vVC.StartOffset;

	public TextPosition StartPosition => PVb.OffsetToPosition(vVC.StartOffset);

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public string Text
	{
		get
		{
			if (!IsDeleted)
			{
				return PVb.GetSubstring(vVC);
			}
			return string.Empty;
		}
	}

	public TextRange TextRange => vVC;

	private TextSnapshotRange(ITextSnapshot snapshot)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		PVb = snapshot;
		vVC = TextRange.Deleted;
	}

	public TextSnapshotRange(TextSnapshotOffset snapshotOffset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this = new TextSnapshotRange(snapshotOffset.Snapshot, snapshotOffset.Offset);
	}

	public TextSnapshotRange(ITextSnapshot snapshot, int offset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this = new TextSnapshotRange(snapshot, new TextRange(offset));
	}

	public TextSnapshotRange(ITextSnapshot snapshot, int startOffset, int endOffset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this = new TextSnapshotRange(snapshot, new TextRange(startOffset, endOffset));
	}

	public TextSnapshotRange(ITextSnapshot snapshot, TextRange textRange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		if (snapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		PVb = snapshot;
		if (textRange.IsDeleted)
		{
			vVC = textRange;
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			int length = snapshot.Length;
			vVC = new TextRange(Math.Max(0, Math.Min(length, textRange.FirstOffset)), Math.Max(0, Math.Min(length, textRange.LastOffset)));
		}
	}

	public bool BordersOn(int offset)
	{
		return vVC.BordersOn(offset);
	}

	public bool BordersOn(TextRange range)
	{
		return vVC.BordersOn(range);
	}

	public bool BordersOn(TextSnapshotRange range)
	{
		if (PVb != null && PVb != range.PVb)
		{
			return vVC.BordersOn(range.TranslateTo(PVb, TextRangeTrackingModes.Default).TextRange);
		}
		return vVC.BordersOn(range.TextRange);
	}

	public int CompareTo(TextRange range)
	{
		return vVC.CompareTo(range);
	}

	public int CompareTo(TextSnapshotRange range)
	{
		if (PVb != null && PVb != range.PVb)
		{
			return vVC.CompareTo(range.TranslateTo(PVb, TextRangeTrackingModes.Default).TextRange);
		}
		return vVC.CompareTo(range.vVC);
	}

	public bool Contains(int offset)
	{
		return vVC.Contains(offset);
	}

	public bool Contains(TextRange range)
	{
		return vVC.Contains(range);
	}

	public bool Contains(TextSnapshotRange range)
	{
		if (PVb != null && PVb != range.PVb)
		{
			return vVC.Contains(range.TranslateTo(PVb, TextRangeTrackingModes.Default).TextRange);
		}
		return vVC.Contains(range.TextRange);
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is TextSnapshotRange))
		{
			return false;
		}
		TextSnapshotRange textSnapshotRange = (TextSnapshotRange)obj;
		return PVb == textSnapshotRange.PVb && vVC == textSnapshotRange.vVC;
	}

	public static TextSnapshotRange FromSpan(ITextSnapshot snapshot, int offset, int length)
	{
		return new TextSnapshotRange(snapshot, offset, offset + length);
	}

	public override int GetHashCode()
	{
		return ((PVb != null) ? PVb.GetHashCode() : 0) ^ vVC.GetHashCode();
	}

	public string GetText(LineTerminator lineTerminator)
	{
		if (IsDeleted)
		{
			return string.Empty;
		}
		return PVb.GetSubstring(vVC, lineTerminator);
	}

	public bool IntersectsWith(int offset)
	{
		return vVC.IntersectsWith(offset);
	}

	public bool IntersectsWith(TextRange range)
	{
		return vVC.IntersectsWith(range);
	}

	public bool IntersectsWith(TextSnapshotRange range)
	{
		if (PVb != null && PVb != range.PVb)
		{
			return vVC.IntersectsWith(range.TranslateTo(PVb, TextRangeTrackingModes.Default).TextRange);
		}
		return vVC.IntersectsWith(range.TextRange);
	}

	public bool IntersectsWith(TextSnapshotRange range, bool includeFirstEdge, bool includeLastEdge)
	{
		if (PVb != null && PVb != range.PVb)
		{
			return vVC.IntersectsWith(range.TranslateTo(PVb, TextRangeTrackingModes.Default).TextRange, includeFirstEdge, includeLastEdge);
		}
		return vVC.IntersectsWith(range.TextRange, includeFirstEdge, includeLastEdge);
	}

	public bool OverlapsWith(TextRange range)
	{
		return vVC.OverlapsWith(range);
	}

	public bool OverlapsWith(TextSnapshotRange range)
	{
		if (PVb != null && PVb != range.PVb && range.PVb != null)
		{
			int num = 0;
			if (HtE() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (PVb.Document == range.PVb.Document)
			{
				return vVC.OverlapsWith(range.TranslateTo(PVb, TextRangeTrackingModes.Default).TextRange);
			}
		}
		return vVC.OverlapsWith(range.TextRange);
	}

	public override string ToString()
	{
		if (!IsDeleted)
		{
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1718) + PVb.Version.Number + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1752) + StartOffset + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1598) + EndOffset + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1696);
	}

	public ITextVersionRange ToVersionRange(TextRangeTrackingModes trackingModes)
	{
		if (PVb == null)
		{
			return null;
		}
		return PVb.Version.CreateRange(vVC, trackingModes);
	}

	public ITextVersionRange ToVersionRange(Func<TextRangeTrackingModes> trackingModesFunc)
	{
		if (PVb == null)
		{
			return null;
		}
		return PVb.Version.CreateRange(vVC, trackingModesFunc);
	}

	public TextSnapshotRange TranslateTo(ITextSnapshot toSnapshot, TextRangeTrackingModes trackingModes)
	{
		if (IsDeleted)
		{
			return this;
		}
		if (toSnapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652));
		}
		TextSnapshotRange textSnapshotRange = new TextSnapshotRange(toSnapshot, vVC.Translate(PVb.Version, toSnapshot.Version, trackingModes, boundsCheck: true));
		bool flag;
		int num;
		if (!textSnapshotRange.IsDeleted && (trackingModes & TextRangeTrackingModes.LineBased) == TextRangeTrackingModes.LineBased)
		{
			TextRange textRange = textSnapshotRange.EndLine.TextRange;
			flag = textSnapshotRange != textRange;
			num = 0;
			if (!ct6())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_00e9;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_00e9:
		return textSnapshotRange;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				if (!flag)
				{
					break;
				}
				goto IL_0067;
			case 1:
				textSnapshotRange = new TextSnapshotRange(toSnapshot, textSnapshotRange.EndLine.TextRange);
				break;
			}
			break;
			IL_0067:
			num = 1;
			if (ct6())
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_00e9;
	}

	public static implicit operator TextRange(TextSnapshotRange range)
	{
		return range.vVC;
	}

	public static bool operator ==(TextSnapshotRange left, TextSnapshotRange right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextSnapshotRange left, TextSnapshotRange right)
	{
		return !(left == right);
	}

	public static bool operator <(TextSnapshotRange left, TextSnapshotRange right)
	{
		return left.CompareTo(right) < 0;
	}

	public static bool operator >(TextSnapshotRange left, TextSnapshotRange right)
	{
		return left.CompareTo(right) > 0;
	}

	internal static bool ct6()
	{
		return AtH == null;
	}

	internal static object HtE()
	{
		return AtH;
	}
}
