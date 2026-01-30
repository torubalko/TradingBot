using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class UTd : ITextPositionRangeCollection, IEnumerable<TextPositionRange>, IEnumerable
{
	private SelectionModes xor;

	private List<TextPositionRange> fos;

	private IList<double> sok;

	private int aoS;

	internal static UTd dAw;

	public int Count => fos.Count;

	public bool IsBlock => xor == SelectionModes.Block;

	public SelectionModes Mode => xor;

	public TextPositionRange Primary => this[aoS];

	public int PrimaryIndex => aoS;

	public TextPositionRange this[int P_0] => fos[P_0];

	public UTd()
	{
		grA.DaB7cz();
		xor = SelectionModes.ContinuousStream;
		base._002Ector();
		fos = new List<TextPositionRange>(1);
		ToT(default(TextPositionRange), _0020: false, _0020: false);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private void noH()
	{
		for (int i = 0; i < fos.Count - 1; i++)
		{
			TextPositionRange range = fos[i];
			TextPositionRange range2 = fos[i + 1];
			if (range.LastPosition >= range2.FirstPosition)
			{
				TextPositionRange value = TextPositionRange.Union(range, range2);
				if (aoS == i + 1 && !range2.IsNormalized)
				{
					value = new TextPositionRange(value.EndPosition, value.StartPosition);
				}
				fos[i] = value;
				fos.RemoveAt(i + 1);
				if (sok != null)
				{
					sok.RemoveAt(i + 1);
				}
				if (aoS > i)
				{
					aoS--;
				}
			}
		}
	}

	private void vob(int P_0)
	{
		int num2 = default(int);
		while (P_0 < fos.Count - 1)
		{
			TextPositionRange range = fos[P_0];
			int num = 0;
			if (nA8() != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			TextPositionRange range2 = fos[P_0 + 1];
			if (range.LastPosition >= range2.FirstPosition)
			{
				fos[P_0] = TextPositionRange.Union(range, range2);
				fos.RemoveAt(P_0 + 1);
				if (sok != null)
				{
					sok.RemoveAt(P_0 + 1);
				}
				if (aoS > P_0)
				{
					aoS--;
				}
				continue;
			}
			return;
		}
	}

	public bool ToT(TextPositionRange P_0, bool P_1, bool P_2)
	{
		Ron();
		int num = 0;
		if (fos.Count > 0)
		{
			TextPosition firstPosition = P_0.FirstPosition;
			if (firstPosition > fos[fos.Count - 1].LastPosition)
			{
				num = fos.Count;
			}
			else
			{
				num = BinarySearch(firstPosition);
				if (num < 0)
				{
					num = ~num;
				}
				if (P_2 && fos.Count > 1)
				{
					if (num < fos.Count && fos[num].NormalizedTextPositionRange == P_0.NormalizedTextPositionRange)
					{
						fos.RemoveAt(num);
						if (aoS >= num)
						{
							aoS = Math.Max(0, aoS - 1);
						}
						return false;
					}
					if (num > 0 && fos[num - 1].LastPosition >= firstPosition)
					{
						fos.RemoveAt(--num);
						if (aoS >= num)
						{
							aoS = Math.Max(0, aoS - 1);
						}
					}
					TextPosition lastPosition = P_0.LastPosition;
					while (num < fos.Count && fos[num].FirstPosition <= lastPosition)
					{
						fos.RemoveAt(num);
						if (aoS >= num)
						{
							aoS = Math.Max(0, aoS - 1);
						}
					}
				}
				else if (num > 0)
				{
					TextPositionRange range = fos[num - 1];
					if (range.LastPosition >= firstPosition)
					{
						P_0 = TextPositionRange.Union(range, P_0);
						fos[--num] = P_0;
						if (P_1)
						{
							aoS = num;
						}
						vob(num);
						return true;
					}
				}
			}
		}
		fos.Insert(num, P_0);
		if (P_1)
		{
			aoS = num;
		}
		vob(num);
		return true;
	}

	public int BinarySearch(TextPosition P_0)
	{
		int num = 0;
		int num2 = fos.Count - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			TextPositionRange textPositionRange = fos[num3];
			if (textPositionRange.Contains(P_0) || textPositionRange.FirstPosition == P_0)
			{
				return num3;
			}
			if (textPositionRange.LastPosition > P_0)
			{
				num2 = num3 - 1;
			}
			else
			{
				num = num3 + 1;
			}
		}
		if (num2 >= 0)
		{
			if (fos[num2].LastPosition > P_0)
			{
				return ~num2;
			}
			return ~(num2 + 1);
		}
		return -1;
	}

	public void CoL(SelectionModes P_0)
	{
		int num = 0;
		if (nA8() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		switch (P_0)
		{
		case SelectionModes.ContinuousStream:
		case SelectionModes.Block:
			xor = P_0;
			break;
		case SelectionModes.None:
			break;
		default:
			throw new ArgumentException(SR.GetString(SRName.ExInvalidSelectionMode));
		}
	}

	public IEnumerator<TextPositionRange> GetEnumerator()
	{
		return fos.GetEnumerator();
	}

	public void Ron()
	{
		sok = null;
	}

	[SpecialName]
	public IList<double> Yo0()
	{
		return sok;
	}

	[SpecialName]
	public void uoB(IList<double> P_0)
	{
		if (P_0 != null && fos.Count != P_0.Count)
		{
			P_0 = null;
		}
		sok = P_0;
	}

	public void Uo8(TextPositionRange P_0)
	{
		if (fos.Count == 1)
		{
			fos[0] = P_0;
			return;
		}
		Ron();
		fos.Clear();
		ToT(P_0, _0020: true, _0020: false);
	}

	public void goI(TextPositionRange[] P_0, int? P_1 = null)
	{
		if (P_0.Length == fos.Count)
		{
			Array.Sort(P_0, (TextPositionRange x, TextPositionRange y) => x.StartPosition.CompareTo(y.StartPosition));
			for (int num = P_0.Length - 1; num >= 0; num--)
			{
				fos[num] = P_0[num];
			}
			noH();
		}
		else
		{
			Ron();
			fos.Clear();
			foreach (TextPositionRange textPositionRange in P_0)
			{
				ToT(textPositionRange, !P_1.HasValue, _0020: false);
			}
			if (fos.Count == 0)
			{
				ToT(default(TextPositionRange), !P_1.HasValue, _0020: false);
			}
		}
		if (P_1.HasValue)
		{
			aoS = Math.Max(0, Math.Min(fos.Count - 1, P_1.Value));
		}
	}

	internal static bool vAu()
	{
		return dAw == null;
	}

	internal static UTd nA8()
	{
		return dAw;
	}
}
