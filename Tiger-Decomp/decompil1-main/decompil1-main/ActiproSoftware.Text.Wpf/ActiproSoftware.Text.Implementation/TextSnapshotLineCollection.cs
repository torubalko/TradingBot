using System;
using System.Collections;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextSnapshotLineCollection : ITextSnapshotLineCollection, ICollection, IEnumerable
{
	internal class TextSnapshotLineCollectionEnumerator : IEnumerator
	{
		private int bIV;

		private TextSnapshotLineCollection kIB;

		internal static TextSnapshotLineCollectionEnumerator IMv;

		public object Current
		{
			get
			{
				if (bIV <= -1)
				{
					throw new InvalidOperationException(SR.GetString(SRName.ExEnumerationNotStarted));
				}
				if (bIV >= kIB.Count)
				{
					throw new InvalidOperationException(SR.GetString(SRName.ExEnumerationEnded));
				}
				return new TextSnapshotLine(kIB.XhK, bIV, kIB.GetLineTextRange(bIV));
			}
		}

		internal TextSnapshotLineCollectionEnumerator(TextSnapshotLineCollection snapshotLines)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			kIB = snapshotLines;
			bIV = -1;
		}

		public bool MoveNext()
		{
			if (bIV < kIB.Count - 1)
			{
				bIV++;
				return true;
			}
			bIV = kIB.Count;
			return false;
		}

		public void Reset()
		{
			bIV = -1;
		}

		internal static bool VMY()
		{
			return IMv == null;
		}

		internal static TextSnapshotLineCollectionEnumerator pMe()
		{
			return IMv;
		}
	}

	private TextSnapshot XhK;

	private static TextSnapshotLineCollection z2M;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public int Count => XhK.TextData.LineFeedCount + 1;

	public ITextSnapshotLine this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5502));
			}
			return new TextSnapshotLine(XhK, index, GetLineTextRange(index));
		}
	}

	internal TextSnapshotLineCollection(TextSnapshot snapshot)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		XhK = snapshot;
	}

	void ICollection.CopyTo(Array array, int index)
	{
		throw new NotImplementedException();
	}

	public virtual IEnumerator GetEnumerator()
	{
		return new TextSnapshotLineCollectionEnumerator(this);
	}

	public TextRange GetLineTextRange(int index)
	{
		return XhK.TextData.GetLineTextRange(index);
	}

	public int IndexOf(int offset)
	{
		return XhK.TextData.GetLineIndex(offset);
	}

	internal static bool W2Z()
	{
		return z2M == null;
	}

	internal static TextSnapshotLineCollection B29()
	{
		return z2M;
	}
}
