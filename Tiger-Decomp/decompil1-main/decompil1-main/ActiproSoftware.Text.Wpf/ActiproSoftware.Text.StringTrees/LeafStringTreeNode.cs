using System;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.StringTrees;

internal sealed class LeafStringTreeNode : StringTreeNodeBase
{
	private string hAd;

	private int QAL;

	private int[] bAq;

	private static readonly IStringTreeNode qAs;

	internal static LeafStringTreeNode sAG;

	public sealed override int Depth => 0;

	public sealed override bool IsLeaf => true;

	public sealed override IStringTreeNode Left => null;

	public sealed override int Length => QAL;

	public sealed override int LineFeedCount => bAq.Length;

	public sealed override IStringTreeNode Right => null;

	public sealed override char this[int index] => hAd[index];

	private LeafStringTreeNode(string text)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		hAd = text;
		QAL = text.Length;
		bAq = StringHelper.GetLineFeedIndices(text);
	}

	internal static IStringTreeNode Create(string text)
	{
		if (!string.IsNullOrEmpty(text))
		{
			int length = text.Length;
			if (length > 10000)
			{
				int num = 0;
				IStringTreeNode stringTreeNode = new LeafStringTreeNode(text.Substring(num, 10000));
				for (num += 10000; num + 10000 < length; num += 10000)
				{
					stringTreeNode = ConcatenationStringTreeNode.Create(stringTreeNode, new LeafStringTreeNode(text.Substring(num, 10000)));
				}
				if (num < length)
				{
					stringTreeNode = ConcatenationStringTreeNode.Create(stringTreeNode, new LeafStringTreeNode(text.Substring(num, length - num)));
				}
				return stringTreeNode;
			}
			return new LeafStringTreeNode(text);
		}
		return qAs;
	}

	public sealed override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
		hAd.CopyTo(sourceIndex, destination, destinationIndex, count);
	}

	public sealed override int GetLineIndex(int offset)
	{
		if (offset < 0 || offset > QAL)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5978));
		}
		int num = Array.BinarySearch(bAq, offset);
		if (num >= 0)
		{
			return num;
		}
		return ~num;
	}

	public sealed override TextRange GetLineTextRange(int lineIndex)
	{
		int num = bAq.Length;
		if (lineIndex < 0 || lineIndex > num)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5908));
		}
		int startOffset = ((lineIndex != 0) ? (bAq[lineIndex - 1] + 1) : 0);
		if (lineIndex < num)
		{
			return new TextRange(startOffset, bAq[lineIndex]);
		}
		return new TextRange(startOffset, QAL);
	}

	public sealed override IStringTreeNode Substring(int startOffset, int endOffset)
	{
		if (startOffset < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5930));
		}
		if (endOffset > QAL)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5956));
		}
		if (endOffset - startOffset == QAL)
		{
			return this;
		}
		return Create(hAd.Substring(startOffset, endOffset - startOffset));
	}

	public sealed override string ToString()
	{
		return hAd;
	}

	public sealed override string ToString(int startOffset, int endOffset)
	{
		return hAd.Substring(startOffset, endOffset - startOffset);
	}

	static LeafStringTreeNode()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		qAs = new LeafStringTreeNode(string.Empty);
	}

	internal static bool wAh()
	{
		return sAG == null;
	}

	internal static LeafStringTreeNode FAQ()
	{
		return sAG;
	}
}
