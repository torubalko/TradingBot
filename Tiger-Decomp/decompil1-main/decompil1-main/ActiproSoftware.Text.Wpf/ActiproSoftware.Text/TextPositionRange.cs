using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Text.Implementation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

[Serializable]
public struct TextPositionRange : ICloneable
{
	private TextPosition Cz;

	private TextPosition pVS;

	private static object Tt2;

	public static TextPositionRange Empty => new TextPositionRange(TextPosition.Empty, TextPosition.Empty);

	public TextPosition EndPosition => Cz;

	public TextPosition FirstPosition => TextPosition.First(pVS, Cz);

	public bool IsEmpty => pVS.IsEmpty && Cz.IsEmpty;

	public bool IsNormalized => pVS <= Cz;

	public bool IsZeroLength => pVS == Cz;

	public TextPosition LastPosition => TextPosition.Last(pVS, Cz);

	public int Lines => Math.Abs(Cz.Line - pVS.Line) + 1;

	public TextPositionRange NormalizedTextPositionRange
	{
		get
		{
			if (IsNormalized)
			{
				return new TextPositionRange(pVS, Cz);
			}
			return new TextPositionRange(Cz, pVS);
		}
	}

	public TextPosition StartPosition => pVS;

	public TextPositionRange(TextPosition position)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		pVS = new TextPosition(position.Line, position.Character, position.HasFarAffinity);
		Cz = new TextPosition(position.Line, position.Character, position.HasFarAffinity);
	}

	public TextPositionRange(int startLine, int startCharacter, int endLine, int endCharacter)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		pVS = new TextPosition(startLine, startCharacter);
		Cz = new TextPosition(endLine, endCharacter);
	}

	public TextPositionRange(TextPosition startPosition, TextPosition endPosition)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		pVS = new TextPosition(startPosition.Line, startPosition.Character, startPosition.HasFarAffinity);
		Cz = new TextPosition(endPosition.Line, endPosition.Character, endPosition.HasFarAffinity);
	}

	public bool BordersOn(TextPosition position)
	{
		return position == pVS || position == Cz;
	}

	public bool BordersOn(TextPositionRange range)
	{
		return range.LastPosition == FirstPosition || range.FirstPosition == LastPosition;
	}

	public object Clone()
	{
		return new TextPositionRange(pVS, Cz);
	}

	public bool Contains(TextPosition position)
	{
		return position >= FirstPosition && position < LastPosition;
	}

	public bool Contains(TextPositionRange range)
	{
		return FirstPosition <= range.FirstPosition && LastPosition >= range.LastPosition;
	}

	public static ITextPositionRangeCollection CreateCollection(TextPositionRange positionRange, bool isBlock)
	{
		if (isBlock)
		{
			return new BlockTextPositionRangeSnapshot(positionRange);
		}
		return new SingleTextPositionRangeSnapshot(positionRange);
	}

	public static ITextPositionRangeCollection CreateCollection(IEnumerable<TextPositionRange> positionRanges, int primaryIndex)
	{
		if (positionRanges == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1424));
		}
		return positionRanges.Count() switch
		{
			0 => throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1424)), 
			1 => new SingleTextPositionRangeSnapshot(positionRanges.First()), 
			_ => new MultipleTextPositionRangeSnapshot(positionRanges, primaryIndex), 
		};
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is TextPositionRange))
		{
			return false;
		}
		TextPositionRange textPositionRange = (TextPositionRange)obj;
		return pVS == textPositionRange.pVS && Cz == textPositionRange.Cz;
	}

	public override int GetHashCode()
	{
		return pVS.GetHashCode() ^ Cz.GetHashCode();
	}

	public bool IntersectsWith(TextPosition position)
	{
		return position >= FirstPosition && position <= LastPosition;
	}

	public bool IntersectsWith(TextPositionRange range)
	{
		return range.LastPosition >= FirstPosition && range.FirstPosition <= LastPosition;
	}

	public void Normalize()
	{
		if (!IsNormalized)
		{
			TextPosition cz = pVS;
			pVS = Cz;
			Cz = cz;
		}
	}

	public bool OverlapsWith(TextPositionRange range)
	{
		return range.LastPosition > FirstPosition && range.FirstPosition < LastPosition;
	}

	public override string ToString()
	{
		string[] obj = new string[5]
		{
			WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1456),
			null,
			null,
			null,
			null
		};
		TextPosition textPosition = pVS;
		obj[1] = textPosition.ToString();
		obj[2] = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1490);
		textPosition = Cz;
		obj[3] = textPosition.ToString();
		obj[4] = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
		return string.Concat(obj);
	}

	public static TextPositionRange Union(TextPositionRange range1, TextPositionRange range2)
	{
		return new TextPositionRange((range1.FirstPosition <= range2.FirstPosition) ? range1.FirstPosition : range2.FirstPosition, (range1.LastPosition >= range2.LastPosition) ? range1.LastPosition : range2.LastPosition);
	}

	public static bool operator ==(TextPositionRange left, TextPositionRange right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextPositionRange left, TextPositionRange right)
	{
		return !(left == right);
	}

	internal static bool ytq()
	{
		return Tt2 == null;
	}

	internal static object stc()
	{
		return Tt2;
	}
}
