using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.StringTrees;

internal sealed class ConcatenationStringTreeNode : StringTreeNodeBase
{
	private int nAT;

	private IStringTreeNode rA2;

	private int TAm;

	private int AAc;

	private IStringTreeNode TAh;

	internal static ConcatenationStringTreeNode UAl;

	public sealed override int Depth => nAT;

	public sealed override bool IsLeaf => false;

	public sealed override IStringTreeNode Left => rA2;

	public sealed override int Length => TAm;

	public sealed override int LineFeedCount => AAc;

	public sealed override IStringTreeNode Right => TAh;

	public sealed override char this[int index] => ToString(index, index + 1)[0];

	private ConcatenationStringTreeNode(IStringTreeNode left, IStringTreeNode right)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		rA2 = left;
		TAh = right;
		TAm = left.Length + right.Length;
		AAc = left.LineFeedCount + right.LineFeedCount;
		nAT = Math.Max(left.Depth, right.Depth) + 1;
	}

	private static IStringTreeNode RAA(IStringTreeNode P_0, IStringTreeNode P_1, bool P_2)
	{
		if (P_2 && P_0.Length + P_1.Length < 500)
		{
			return LeafStringTreeNode.Create(P_0.ToString() + P_1.ToString());
		}
		if (P_0.Depth > P_1.Depth + 1)
		{
			return wA8(P_0, P_1);
		}
		if (P_1.Depth > P_0.Depth + 1)
		{
			return dAu(P_1, P_0);
		}
		return new ConcatenationStringTreeNode(P_0, P_1);
	}

	internal static IStringTreeNode Create(IStringTreeNode left, IStringTreeNode right)
	{
		if (left == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5882));
		}
		bool flag = right == null;
		int num = 1;
		if (fAI() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			return RAA(left, right, _0020: false);
		case 1:
			if (flag)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5894));
			}
			if (left.Length == 0)
			{
				return right;
			}
			if (right.Length == 0)
			{
				return left;
			}
			if (left.Length + right.Length < 500)
			{
				return LeafStringTreeNode.Create(left.ToString() + right.ToString());
			}
			goto default;
		}
	}

	private static IStringTreeNode dAu(IStringTreeNode P_0, IStringTreeNode P_1)
	{
		IStringTreeNode left = P_0.Left;
		IStringTreeNode right = P_0.Right;
		if (left.Depth <= right.Depth)
		{
			return RAA(RAA(P_1, left, _0020: true), right, _0020: true);
		}
		return RAA(RAA(P_1, left.Left, _0020: true), RAA(left.Right, right, _0020: true), _0020: true);
	}

	private static IStringTreeNode wA8(IStringTreeNode P_0, IStringTreeNode P_1)
	{
		IStringTreeNode left = P_0.Left;
		IStringTreeNode right = P_0.Right;
		if (left.Depth <= right.Depth)
		{
			return RAA(RAA(left, right.Left, _0020: true), RAA(right.Right, P_1, _0020: true), _0020: true);
		}
		return RAA(left, RAA(right, P_1, _0020: true), _0020: true);
	}

	public sealed override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
		int length = rA2.Length;
		if (sourceIndex + count <= length)
		{
			rA2.CopyTo(sourceIndex, destination, destinationIndex, count);
		}
		else if (sourceIndex >= length)
		{
			int num = 0;
			if (!OAo())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			TAh.CopyTo(sourceIndex - length, destination, destinationIndex, count);
		}
		else
		{
			int num3 = length - sourceIndex;
			rA2.CopyTo(sourceIndex, destination, destinationIndex, num3);
			TAh.CopyTo(0, destination, destinationIndex + num3, count - num3);
		}
	}

	public sealed override int GetLineIndex(int offset)
	{
		if (offset < 0)
		{
			offset = 0;
		}
		else if (offset > TAm)
		{
			offset = TAm;
			int num = 0;
			if (!OAo())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		int length = rA2.Length;
		if (offset <= length)
		{
			return rA2.GetLineIndex(offset);
		}
		return rA2.LineFeedCount + TAh.GetLineIndex(offset - length);
	}

	public sealed override TextRange GetLineTextRange(int lineIndex)
	{
		if (lineIndex < 0 || lineIndex > AAc)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5908));
		}
		if (lineIndex < rA2.LineFeedCount)
		{
			return rA2.GetLineTextRange(lineIndex);
		}
		if (lineIndex > rA2.LineFeedCount)
		{
			TextRange lineTextRange = TAh.GetLineTextRange(lineIndex - rA2.LineFeedCount);
			return new TextRange(lineTextRange.StartOffset + rA2.Length, lineTextRange.EndOffset + rA2.Length);
		}
		int startOffset = ((lineIndex != 0) ? rA2.GetLineTextRange(lineIndex).StartOffset : 0);
		if (lineIndex < AAc)
		{
			return new TextRange(startOffset, rA2.Length + TAh.GetLineTextRange(0).EndOffset);
		}
		return new TextRange(startOffset, TAm);
	}

	public sealed override IStringTreeNode Substring(int startOffset, int endOffset)
	{
		if (startOffset < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5930));
		}
		if (endOffset > TAm)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5956));
		}
		if (endOffset - startOffset == TAm)
		{
			return this;
		}
		int length = rA2.Length;
		if (endOffset <= length)
		{
			return rA2.Substring(startOffset, endOffset);
		}
		if (startOffset >= length)
		{
			return TAh.Substring(startOffset - length, endOffset - length);
		}
		return Create(rA2.Substring(startOffset, length), TAh.Substring(0, endOffset - length));
	}

	public sealed override string ToString()
	{
		char[] array = new char[TAm];
		rA2.CopyTo(0, array, 0, rA2.Length);
		TAh.CopyTo(0, array, rA2.Length, TAh.Length);
		return new string(array);
	}

	public sealed override string ToString(int startOffset, int endOffset)
	{
		if (startOffset >= 0)
		{
			if (endOffset > TAm)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5956));
			}
			char[] array = new char[endOffset - startOffset];
			CopyTo(startOffset, array, 0, endOffset - startOffset);
			return new string(array);
		}
		throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5930));
	}

	internal static bool OAo()
	{
		return UAl == null;
	}

	internal static ConcatenationStringTreeNode fAI()
	{
		return UAl;
	}
}
