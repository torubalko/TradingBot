using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.StringTrees;

internal abstract class StringTreeNodeBase : IStringTreeNode
{
	internal static StringTreeNodeBase yAx;

	public abstract int Depth { get; }

	public abstract bool IsLeaf { get; }

	public abstract IStringTreeNode Left { get; }

	public abstract int Length { get; }

	public abstract int LineFeedCount { get; }

	public abstract IStringTreeNode Right { get; }

	public abstract char this[int index] { get; }

	private IStringTreeNode nAI(int P_0, int P_1, IStringTreeNode P_2, int P_3, int P_4)
	{
		int num = P_1 - P_0;
		int num2 = P_4 - P_3;
		if (P_2 == null || P_2.Length == 0)
		{
			if (num == 0)
			{
				return Substring(P_3, P_4);
			}
			if (num2 == 0)
			{
				return Substring(P_0, P_1);
			}
			if (num + num2 == Length)
			{
				return this;
			}
			return ConcatenationStringTreeNode.Create(Substring(P_0, P_1), Substring(P_3, P_4));
		}
		if (num == 0)
		{
			if (num2 > 0)
			{
				return ConcatenationStringTreeNode.Create(P_2, Substring(P_3, P_4));
			}
			return P_2;
		}
		if (num2 == 0)
		{
			return ConcatenationStringTreeNode.Create(Substring(P_0, P_1), P_2);
		}
		if (num < num2)
		{
			return ConcatenationStringTreeNode.Create(ConcatenationStringTreeNode.Create(Substring(P_0, P_1), P_2), Substring(P_3, P_4));
		}
		return ConcatenationStringTreeNode.Create(Substring(P_0, P_1), ConcatenationStringTreeNode.Create(P_2, Substring(P_3, P_4)));
	}

	public abstract void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);

	public abstract int GetLineIndex(int offset);

	public abstract TextRange GetLineTextRange(int lineIndex);

	public IStringTreeNode Replace(int startOffset, int endOffset, string text)
	{
		if (startOffset < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5930));
		}
		if (endOffset > Length)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5956));
		}
		return nAI(0, startOffset, LeafStringTreeNode.Create(text), endOffset, Length);
	}

	public abstract IStringTreeNode Substring(int startOffset, int endOffset);

	public abstract string ToString(int startOffset, int endOffset);

	protected StringTreeNodeBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool VAT()
	{
		return yAx == null;
	}

	internal static StringTreeNodeBase kAk()
	{
		return yAx;
	}
}
