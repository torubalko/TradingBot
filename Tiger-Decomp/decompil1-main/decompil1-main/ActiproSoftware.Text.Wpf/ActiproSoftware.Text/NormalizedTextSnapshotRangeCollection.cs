using System;
using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public class NormalizedTextSnapshotRangeCollection : IList<TextSnapshotRange>, ICollection<TextSnapshotRange>, IEnumerable<TextSnapshotRange>, IEnumerable
{
	private List<TextSnapshotRange> dI;

	internal static NormalizedTextSnapshotRangeCollection tiv;

	bool ICollection<TextSnapshotRange>.IsReadOnly => true;

	public int Count => dI.Count;

	public TextSnapshotRange this[int index]
	{
		get
		{
			return dI[index];
		}
		set
		{
			dI[index] = value;
		}
	}

	public NormalizedTextSnapshotRangeCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		dI = new List<TextSnapshotRange>();
	}

	public NormalizedTextSnapshotRangeCollection(params TextSnapshotRange[] snapshotRanges)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(snapshotRanges, mergeSequentialRanges: true);
	}

	public NormalizedTextSnapshotRangeCollection(IEnumerable<TextSnapshotRange> snapshotRanges)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(snapshotRanges, mergeSequentialRanges: true);
	}

	public NormalizedTextSnapshotRangeCollection(IEnumerable<TextSnapshotRange> snapshotRanges, bool mergeSequentialRanges)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (snapshotRanges == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(264));
		}
		ITextSnapshot textSnapshot = null;
		foreach (TextSnapshotRange snapshotRange in snapshotRanges)
		{
			bool flag = false;
			if (snapshotRange.Snapshot == null)
			{
				throw new ArgumentException(SR.GetString(SRName.ExTextSnapshotRangeDeleted));
			}
			if (textSnapshot == null)
			{
				textSnapshot = snapshotRange.Snapshot;
			}
			if (snapshotRange.Snapshot != textSnapshot)
			{
				throw new ArgumentException(SR.GetString(SRName.ExTextSnapshotRangeSnapshotMismatch));
			}
		}
		dI = ts(new List<TextSnapshotRange>(snapshotRanges), mergeSequentialRanges);
	}

	void ICollection<TextSnapshotRange>.Add(TextSnapshotRange item)
	{
		throw new NotSupportedException();
	}

	void ICollection<TextSnapshotRange>.Clear()
	{
		throw new NotSupportedException();
	}

	bool ICollection<TextSnapshotRange>.Remove(TextSnapshotRange item)
	{
		throw new NotSupportedException();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		for (int index = 0; index < Count; index++)
		{
			yield return dI[index];
		}
	}

	void IList<TextSnapshotRange>.Insert(int index, TextSnapshotRange item)
	{
		throw new NotSupportedException();
	}

	void IList<TextSnapshotRange>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	private static List<TextSnapshotRange> ts(List<TextSnapshotRange> P_0, bool P_1)
	{
		List<TextSnapshotRange> list = new List<TextSnapshotRange>(P_0.Count);
		P_0.Sort((TextSnapshotRange x, TextSnapshotRange y) => x.StartOffset.CompareTo(y.StartOffset));
		if (P_0.Count > 1)
		{
			ITextSnapshot snapshot = P_0[0].Snapshot;
			int startOffset = P_0[0].StartOffset;
			int endOffset = P_0[0].EndOffset;
			int count = P_0.Count;
			for (int num = 1; num < count; num++)
			{
				TextSnapshotRange textSnapshotRange = P_0[num];
				if (textSnapshotRange.StartOffset + ((!P_1) ? 1 : 0) > endOffset)
				{
					list.Add(new TextSnapshotRange(snapshot, startOffset, endOffset));
					startOffset = textSnapshotRange.StartOffset;
					endOffset = textSnapshotRange.EndOffset;
				}
				else if (textSnapshotRange.EndOffset > endOffset)
				{
					endOffset = textSnapshotRange.EndOffset;
				}
			}
			list.Add(new TextSnapshotRange(snapshot, startOffset, endOffset));
		}
		else
		{
			list.AddRange(P_0);
		}
		return list;
	}

	public bool Contains(TextSnapshotRange item)
	{
		return dI.Contains(item);
	}

	public void CopyTo(TextSnapshotRange[] array, int arrayIndex)
	{
		dI.CopyTo(array, arrayIndex);
	}

	public IEnumerator<TextSnapshotRange> GetEnumerator()
	{
		for (int index = 0; index < Count; index++)
		{
			yield return dI[index];
		}
	}

	public NormalizedTextSnapshotRangeCollection GetInverse(TextSnapshotRange targetSnapshotRange)
	{
		NormalizedTextSnapshotRangeCollection normalizedTextSnapshotRangeCollection = new NormalizedTextSnapshotRangeCollection();
		if (dI.Count > 0)
		{
			int num = targetSnapshotRange.StartOffset;
			foreach (TextSnapshotRange item in dI)
			{
				if (num >= targetSnapshotRange.EndOffset)
				{
					break;
				}
				if (!item.OverlapsWith(targetSnapshotRange))
				{
					continue;
				}
				int num2 = Math.Min(Math.Max(item.StartOffset, targetSnapshotRange.StartOffset), targetSnapshotRange.EndOffset);
				if (num <= num2)
				{
					if (num < num2)
					{
						normalizedTextSnapshotRangeCollection.dI.Add(new TextSnapshotRange(targetSnapshotRange.Snapshot, num, num2));
					}
					num = item.EndOffset;
				}
			}
			if (num < targetSnapshotRange.EndOffset)
			{
				normalizedTextSnapshotRangeCollection.dI.Add(new TextSnapshotRange(targetSnapshotRange.Snapshot, num, targetSnapshotRange.EndOffset));
			}
			else if (num == targetSnapshotRange.Snapshot.Length && normalizedTextSnapshotRangeCollection.dI.Count > 0)
			{
				normalizedTextSnapshotRangeCollection.dI.Add(new TextSnapshotRange(targetSnapshotRange.Snapshot, num, num));
			}
		}
		else
		{
			normalizedTextSnapshotRangeCollection.dI.Add(targetSnapshotRange);
		}
		return normalizedTextSnapshotRangeCollection;
	}

	public int IndexOf(TextSnapshotRange item)
	{
		return dI.IndexOf(item);
	}

	internal static bool ViY()
	{
		return tiv == null;
	}

	internal static NormalizedTextSnapshotRangeCollection Qie()
	{
		return tiv;
	}
}
