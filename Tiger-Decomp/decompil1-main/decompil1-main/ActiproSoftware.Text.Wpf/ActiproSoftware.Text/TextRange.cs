using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

[Serializable]
public struct TextRange : ICloneable, IComparable, ITextRangeProvider
{
	private int BV9;

	private int SVA;

	internal static object Utf;

	TextRange ITextRangeProvider.TextRange
	{
		get
		{
			return this;
		}
		set
		{
			SVA = value.SVA;
			BV9 = value.BV9;
		}
	}

	public int AbsoluteLength => Math.Abs(BV9 - SVA);

	public static TextRange Deleted => new TextRange(-1, -1);

	public int EndOffset => BV9;

	public int FirstOffset => (SVA <= BV9) ? SVA : BV9;

	public bool IsDeleted => SVA == -1 || BV9 == -1;

	public bool IsNormalized => SVA <= BV9;

	public bool IsZeroLength => SVA == BV9;

	public int LastOffset => (SVA <= BV9) ? BV9 : SVA;

	public int Length => BV9 - SVA;

	public TextRange NormalizedTextRange
	{
		get
		{
			if (IsNormalized)
			{
				return new TextRange(SVA, BV9);
			}
			return new TextRange(BV9, SVA);
		}
	}

	public int StartOffset => SVA;

	public TextRange(int offset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		SVA = offset;
		BV9 = offset;
	}

	public TextRange(int startOffset, int endOffset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		SVA = startOffset;
		BV9 = endOffset;
	}

	int IComparable.CompareTo(object obj)
	{
		if (!(obj is TextRange))
		{
			return 0;
		}
		return CompareTo((TextRange)obj);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal bool AdjustForTextChangeOperation(ITextChangeRangedOperation operation, TextRangeTrackingModes trackingModes)
	{
		if (IsDeleted)
		{
			return false;
		}
		bool result = false;
		int startOffset = operation.StartOffset;
		bool flag = (trackingModes & TextRangeTrackingModes.ExpandFirstEdge) == TextRangeTrackingModes.ExpandFirstEdge;
		bool flag2 = (trackingModes & TextRangeTrackingModes.ExpandLastEdge) == TextRangeTrackingModes.ExpandLastEdge;
		if (operation.HasDeletion)
		{
			if (startOffset < BV9)
			{
				int deletionEndOffset = operation.DeletionEndOffset;
				if (deletionEndOffset <= SVA)
				{
					SVA -= deletionEndOffset - startOffset;
					BV9 -= deletionEndOffset - startOffset;
				}
				else if (startOffset <= SVA)
				{
					result = true;
					if (deletionEndOffset >= BV9)
					{
						bool flag3 = false;
						switch (trackingModes & TextRangeTrackingModes.DeleteWhenZeroLength)
						{
						case TextRangeTrackingModes.DeleteWhenZeroLength:
							if (!operation.HasInsertion || ((!flag || startOffset != SVA) && (!flag2 || deletionEndOffset != BV9)))
							{
								flag3 = true;
							}
							break;
						case TextRangeTrackingModes.DeleteWhenSurrounded:
							if ((startOffset != SVA || deletionEndOffset != BV9) && (!operation.HasInsertion || ((!flag || startOffset != SVA) && (!flag2 || deletionEndOffset != BV9))))
							{
								flag3 = true;
							}
							break;
						}
						if (flag3)
						{
							SVA = -1;
							BV9 = -1;
							return true;
						}
						SVA = startOffset;
						BV9 = startOffset;
					}
					else
					{
						SVA = startOffset;
						BV9 -= deletionEndOffset - startOffset;
					}
				}
				else
				{
					result = true;
					if (deletionEndOffset >= BV9)
					{
						BV9 = startOffset;
					}
					else
					{
						BV9 -= deletionEndOffset - startOffset;
					}
				}
			}
			else if (startOffset == SVA && SVA == BV9 && !operation.HasInsertion)
			{
				TextRangeTrackingModes textRangeTrackingModes = trackingModes & TextRangeTrackingModes.DeleteWhenZeroLength;
				TextRangeTrackingModes textRangeTrackingModes2 = textRangeTrackingModes;
				if (textRangeTrackingModes2 == TextRangeTrackingModes.DeleteWhenSurrounded || textRangeTrackingModes2 == TextRangeTrackingModes.DeleteWhenZeroLength)
				{
					SVA = -1;
					BV9 = -1;
					return true;
				}
			}
		}
		if (operation.HasInsertion)
		{
			bool flag4 = startOffset == SVA && SVA == BV9;
			if (flag4 && (flag || flag2))
			{
				BV9 += operation.InsertionLength;
				result = true;
			}
			else if (startOffset <= SVA - (flag ? 1 : 0) && (!flag4 || (trackingModes & TextRangeTrackingModes.NegativeWhenZeroLength) != TextRangeTrackingModes.NegativeWhenZeroLength))
			{
				SVA += operation.InsertionLength;
				BV9 += operation.InsertionLength;
			}
			else if (startOffset < BV9 + (flag2 ? 1 : 0))
			{
				BV9 += operation.InsertionLength;
				result = true;
			}
		}
		return result;
	}

	internal TextRange Translate(ITextVersion fromVersion, ITextVersion toVersion, TextRangeTrackingModes trackingModes, bool boundsCheck)
	{
		if (fromVersion == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1520));
		}
		if (toVersion == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1546));
		}
		if (fromVersion.Document != toVersion.Document)
		{
			throw new ArgumentException(SR.GetString(SRName.ExTextVersionDocumentMismatch));
		}
		if (IsDeleted)
		{
			return Deleted;
		}
		TextRange result = new TextRange(FirstOffset, LastOffset);
		if (fromVersion != toVersion)
		{
			if (fromVersion.Number <= toVersion.Number)
			{
				result.NVB(fromVersion, toVersion, trackingModes);
			}
			else
			{
				result.VVV(fromVersion, toVersion, trackingModes);
			}
		}
		if (boundsCheck && !result.IsDeleted)
		{
			result = new TextRange(Math.Max(0, Math.Min(toVersion.Length, result.StartOffset)), Math.Max(0, Math.Min(toVersion.Length, result.EndOffset)));
		}
		return result;
	}

	private void VVV(ITextVersion P_0, ITextVersion P_1, TextRangeTrackingModes P_2)
	{
		if (!IsDeleted)
		{
			bool flag = (P_2 & TextRangeTrackingModes.ExpandFirstEdge) == TextRangeTrackingModes.ExpandFirstEdge;
			bool flag2 = (P_2 & TextRangeTrackingModes.ExpandLastEdge) == TextRangeTrackingModes.ExpandLastEdge;
			SVA = TextSnapshotOffset.Translate(P_0, P_1, SVA, (!flag) ? TextOffsetTrackingMode.Positive : TextOffsetTrackingMode.Negative, boundsCheck: false);
			BV9 = TextSnapshotOffset.Translate(P_0, P_1, BV9, flag2 ? TextOffsetTrackingMode.Positive : TextOffsetTrackingMode.Negative, boundsCheck: false);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void NVB(ITextVersion P_0, ITextVersion P_1, TextRangeTrackingModes P_2)
	{
		ITextVersion textVersion = P_0;
		while (textVersion != null && textVersion != P_1)
		{
			IList<ITextChangeRangedOperation> operations = textVersion.Operations;
			if (operations != null)
			{
				foreach (ITextChangeRangedOperation item in operations)
				{
					if (IsDeleted)
					{
						return;
					}
					if (!item.IsIgnoredForTranslation || item.DeletionLength != item.InsertionLength)
					{
						AdjustForTextChangeOperation(item, P_2);
					}
				}
			}
			textVersion = textVersion.Next;
		}
	}

	public bool BordersOn(int offset)
	{
		return offset == SVA || offset == BV9;
	}

	public bool BordersOn(TextRange range)
	{
		return range.LastOffset == FirstOffset || range.FirstOffset == LastOffset;
	}

	public object Clone()
	{
		return new TextRange(SVA, BV9);
	}

	public int CompareTo(TextRange textRange)
	{
		int num = FirstOffset.CompareTo(textRange.FirstOffset);
		if (num == 0)
		{
			num = LastOffset.CompareTo(textRange.LastOffset);
		}
		return num;
	}

	public bool Contains(int offset)
	{
		return offset >= FirstOffset && offset < LastOffset;
	}

	public bool Contains(TextRange range)
	{
		return FirstOffset <= range.FirstOffset && LastOffset >= range.LastOffset;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is TextRange))
		{
			return false;
		}
		TextRange textRange = (TextRange)obj;
		return SVA == textRange.SVA && BV9 == textRange.BV9;
	}

	public static TextRange FromSpan(int offset, int length)
	{
		return new TextRange(offset, offset + length);
	}

	public override int GetHashCode()
	{
		return SVA ^ BV9;
	}

	public static TextRange Intersect(TextRange range1, TextRange range2)
	{
		int num = 1;
		bool isDeleted = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (isDeleted)
					{
						return range2;
					}
					if (range2.IsDeleted)
					{
						return range1;
					}
					if (range1.IntersectsWith(range2))
					{
						return new TextRange(Math.Max(range1.FirstOffset, range2.FirstOffset), Math.Min(range1.LastOffset, range2.LastOffset));
					}
					return Deleted;
				case 1:
					break;
				}
				isDeleted = range1.IsDeleted;
				num2 = 0;
			}
			while (jtM());
		}
	}

	public bool IntersectsWith(int offset)
	{
		return offset >= FirstOffset && offset <= LastOffset;
	}

	public bool IntersectsWith(TextRange range)
	{
		return range.LastOffset >= FirstOffset && range.FirstOffset <= LastOffset;
	}

	public bool IntersectsWith(TextRange range, bool includeFirstEdge, bool includeLastEdge)
	{
		return range.LastOffset - ((!includeFirstEdge) ? 1 : 0) >= FirstOffset && range.FirstOffset + ((!includeLastEdge) ? 1 : 0) <= LastOffset;
	}

	public void Normalize()
	{
		if (!IsNormalized)
		{
			int sVA = SVA;
			SVA = BV9;
			BV9 = sVA;
		}
	}

	public bool OverlapsWith(TextRange range)
	{
		return range.LastOffset > FirstOffset && range.FirstOffset < LastOffset;
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1568) + SVA + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1598) + BV9 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	public TextRange Translate(ITextSnapshot fromSnapshot, ITextSnapshot toSnapshot, TextRangeTrackingModes trackingModes)
	{
		if (fromSnapshot != null)
		{
			if (toSnapshot == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652));
			}
			return Translate(fromSnapshot.Version, toSnapshot.Version, trackingModes, boundsCheck: true);
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1624));
	}

	public TextRange Translate(ITextVersion fromVersion, ITextVersion toVersion, TextRangeTrackingModes trackingModes)
	{
		return Translate(fromVersion, toVersion, trackingModes, boundsCheck: true);
	}

	public static TextRange Union(TextRange range1, TextRange range2)
	{
		if (!range1.IsDeleted)
		{
			if (!range2.IsDeleted)
			{
				return new TextRange(Math.Min(range1.FirstOffset, range2.FirstOffset), Math.Max(range1.LastOffset, range2.LastOffset));
			}
			return range1;
		}
		return range2;
	}

	public static bool operator ==(TextRange left, TextRange right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextRange left, TextRange right)
	{
		return !(left == right);
	}

	public static bool operator <(TextRange left, TextRange right)
	{
		return left.CompareTo(right) < 0;
	}

	public static bool operator >(TextRange left, TextRange right)
	{
		return left.CompareTo(right) > 0;
	}

	internal static bool jtM()
	{
		return Utf == null;
	}

	internal static object ttZ()
	{
		return Utf;
	}
}
