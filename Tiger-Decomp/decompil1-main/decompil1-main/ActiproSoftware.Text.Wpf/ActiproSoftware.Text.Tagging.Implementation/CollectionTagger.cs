using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public abstract class CollectionTagger<T> : TaggerBase<T>, ICollection<TagVersionRange<T>>, IEnumerable<TagVersionRange<T>>, IEnumerable, ICollectionTagger<T>, ITagger<T>, IOrderable, IKeyedObject, INotifyCollectionChanged where T : class, ITag
{
	private class Tp : DisposableObject
	{
		private CollectionTagger<T> FqF;

		internal static object icX;

		public Tp(CollectionTagger<T> P_0)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			FqF = P_0;
			P_0.v9v();
		}

		protected override void Dispose(bool P_0)
		{
			if (FqF != null)
			{
				FqF.b96();
				FqF = null;
			}
			base.Dispose(P_0);
		}

		internal static bool yc3()
		{
			return icX == null;
		}

		internal static object jcC()
		{
			return icX;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public Predicate<TagVersionRange<T>> match;

		internal static object vcO;

		public _003C_003Ec__DisplayClass33_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal bool Jqx(TagVersionRange<T> tr)
		{
			return match(tr);
		}

		internal static bool EcD()
		{
			return vcO == null;
		}

		internal static object Tcv()
		{
			return vcO;
		}
	}

	private int e9Y;

	private List<TagVersionRange<T>> i9o;

	private object a9D;

	private TextSnapshotRange Q91;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler R94;

	private static object FAV;

	bool ICollection<TagVersionRange<T>>.IsReadOnly => false;

	public int Count
	{
		get
		{
			lock (a9D)
			{
				return i9o.Count;
			}
		}
	}

	public TagVersionRange<T> this[T tag]
	{
		get
		{
			lock (a9D)
			{
				if (tag != null)
				{
					for (int i = 0; i < i9o.Count; i++)
					{
						if (tag.Equals(i9o[i].Tag))
						{
							return i9o[i];
						}
					}
				}
				return null;
			}
		}
	}

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = R94;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref R94, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = R94;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref R94, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
	}

	protected CollectionTagger(string key, IEnumerable<Ordering> orderings, ICodeDocument document, bool isForLanguage)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		i9o = new List<TagVersionRange<T>>();
		a9D = new object();
		Q91 = TextSnapshotRange.Deleted;
		base._002Ector(key, orderings, document, isForLanguage);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return i9o.GetEnumerator();
	}

	private TagVersionRange<T> b9W(TextSnapshotOffset P_0, int P_1, Predicate<TagVersionRange<T>> P_2, bool P_3)
	{
		TagVersionRange<T> result = null;
		int num = int.MaxValue;
		foreach (TagVersionRange<T> item in i9o)
		{
			TextSnapshotRange textSnapshotRange = item.VersionRange.Translate(P_0.Snapshot);
			if (textSnapshotRange.StartOffset > (int)P_0 - (P_3 ? 1 : 0) && textSnapshotRange.StartOffset <= P_1 && textSnapshotRange.StartOffset < num && (P_2 == null || P_2(item)))
			{
				result = item;
				num = textSnapshotRange.StartOffset;
			}
		}
		return result;
	}

	private TagVersionRange<T> V95(TextSnapshotOffset P_0, int P_1, Predicate<TagVersionRange<T>> P_2)
	{
		TagVersionRange<T> result = null;
		int num = -1;
		foreach (TagVersionRange<T> item in i9o)
		{
			TextSnapshotRange textSnapshotRange = item.VersionRange.Translate(P_0.Snapshot);
			if (textSnapshotRange.StartOffset < (int)P_0 && textSnapshotRange.StartOffset >= P_1 && textSnapshotRange.StartOffset > num && (P_2 == null || P_2(item)))
			{
				result = item;
				num = textSnapshotRange.StartOffset;
			}
		}
		return result;
	}

	private void b96()
	{
		bool flag = false;
		TextSnapshotRange q;
		lock (a9D)
		{
			q = Q91;
			if (e9Y > 0)
			{
				e9Y--;
			}
			flag = e9Y == 0;
			if (flag)
			{
				Q91 = TextSnapshotRange.Deleted;
			}
		}
		if (flag && !q.IsDeleted)
		{
			OnTagsChanged(new TagsChangedEventArgs(q));
		}
	}

	private void q9Z(ITextVersionRange P_0)
	{
		ITextDocument document = base.Document;
		ITextDocument textDocument = document ?? P_0.Document;
		TextSnapshotRange textSnapshotRange = P_0.Translate(textDocument.CurrentSnapshot);
		if (e9Y <= 0)
		{
			OnTagsChanged(new TagsChangedEventArgs(textSnapshotRange));
		}
		else if (!Q91.IsDeleted)
		{
			Q91 = new TextSnapshotRange(textSnapshotRange.Snapshot, TextRange.Union(Q91.TextRange, textSnapshotRange.TextRange));
		}
		else
		{
			Q91 = textSnapshotRange;
		}
	}

	private void l90(NotifyCollectionChangedAction P_0, TagVersionRange<T> P_1, int P_2)
	{
		NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = R94;
		if (notifyCollectionChangedEventHandler != null)
		{
			switch (P_0)
			{
			case NotifyCollectionChangedAction.Add:
			case NotifyCollectionChangedAction.Remove:
				notifyCollectionChangedEventHandler(this, new NotifyCollectionChangedEventArgs(P_0, P_1, P_2));
				break;
			case NotifyCollectionChangedAction.Reset:
				notifyCollectionChangedEventHandler(this, new NotifyCollectionChangedEventArgs(P_0));
				break;
			}
		}
	}

	private void v9v()
	{
		lock (a9D)
		{
			e9Y++;
		}
	}

	public void Add(TagVersionRange<T> tagRange)
	{
		if (tagRange == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5676));
		}
		lock (a9D)
		{
			i9o.Add(tagRange);
			l90(NotifyCollectionChangedAction.Add, tagRange, i9o.Count - 1);
			q9Z(tagRange.VersionRange);
		}
	}

	public TagVersionRange<T> Add(ITextSnapshotLine snapshotLine, T tag)
	{
		if (snapshotLine == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5696));
		}
		if (tag == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5562));
		}
		ITextVersionRange versionRange = snapshotLine.SnapshotRange.ToVersionRange(TextRangeTrackingModes.DeleteWhenSurrounded | TextRangeTrackingModes.LineBased);
		TagVersionRange<T> tagVersionRange = new TagVersionRange<T>(versionRange, tag);
		Add(tagVersionRange);
		return tagVersionRange;
	}

	public TagVersionRange<T> Add(TextSnapshotRange snapshotRange, T tag)
	{
		if (snapshotRange.IsDeleted)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5724));
		}
		if (tag == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5562));
		}
		ITextVersionRange versionRange = snapshotRange.ToVersionRange(TextRangeTrackingModes.DeleteWhenZeroLength);
		TagVersionRange<T> tagVersionRange = new TagVersionRange<T>(versionRange, tag);
		Add(tagVersionRange);
		return tagVersionRange;
	}

	public void Clear()
	{
		lock (a9D)
		{
			if (i9o.Count == 0)
			{
				return;
			}
			ITextVersionRange textVersionRange = null;
			if (base.Document != null)
			{
				ITextSnapshot currentSnapshot = base.Document.CurrentSnapshot;
				TextRange textRange = currentSnapshot.TextRange;
				if (i9o.Count <= 100 && i9o[0].VersionRange.Document == currentSnapshot.Document)
				{
					int num = int.MaxValue;
					int num2 = 0;
					for (int num3 = i9o.Count - 1; num3 >= 0; num3--)
					{
						TextSnapshotRange textSnapshotRange = i9o[num3].VersionRange.Translate(currentSnapshot);
						num = Math.Min(num, textSnapshotRange.StartOffset);
						num2 = Math.Max(num2, textSnapshotRange.EndOffset);
					}
					textRange = new TextRange(num, num2);
				}
				textVersionRange = currentSnapshot.Version.CreateRange(textRange);
			}
			i9o.Clear();
			l90(NotifyCollectionChangedAction.Reset, null, -1);
			if (textVersionRange != null)
			{
				q9Z(textVersionRange);
			}
		}
	}

	public IDisposable CreateBatch()
	{
		return new Tp(this);
	}

	public bool Contains(TagVersionRange<T> tagRange)
	{
		lock (a9D)
		{
			return i9o.Contains(tagRange);
		}
	}

	public void CopyTo(TagVersionRange<T>[] array, int arrayIndex)
	{
		lock (a9D)
		{
			i9o.CopyTo(array, arrayIndex);
		}
	}

	public TagVersionRange<T> FindNext(ITextSnapshotLine snapshotLine, ITagSearchOptions<T> options)
	{
		if (snapshotLine == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5696));
		}
		bool flag = options?.SearchUp ?? false;
		TextSnapshotOffset snapshotOffset = new TextSnapshotOffset(snapshotLine.Snapshot, flag ? snapshotLine.StartOffset : snapshotLine.EndOffset);
		return FindNext(snapshotOffset, options);
	}

	public TagVersionRange<T> FindNext(TextSnapshotOffset snapshotOffset, ITagSearchOptions<T> options)
	{
		if (snapshotOffset.IsDeleted)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5754));
		}
		TagVersionRange<T> tagVersionRange = null;
		lock (a9D)
		{
			bool flag = options?.SearchUp ?? false;
			bool flag2 = options?.CanWrap ?? false;
			Predicate<TagVersionRange<T>> predicate = options?.Filter;
			if (flag)
			{
				tagVersionRange = V95(snapshotOffset, 0, predicate);
				if (tagVersionRange == null && flag2)
				{
					tagVersionRange = V95(new TextSnapshotOffset(snapshotOffset.Snapshot, snapshotOffset.Snapshot.Length), snapshotOffset, predicate);
				}
			}
			else
			{
				tagVersionRange = b9W(snapshotOffset, snapshotOffset.Snapshot.Length, predicate, _0020: false);
				if (tagVersionRange == null && flag2)
				{
					tagVersionRange = b9W(new TextSnapshotOffset(snapshotOffset.Snapshot, 0), snapshotOffset, predicate, _0020: true);
				}
			}
		}
		return tagVersionRange;
	}

	public IEnumerator<TagVersionRange<T>> GetEnumerator()
	{
		lock (a9D)
		{
			for (int index = 0; index < i9o.Count; index++)
			{
				yield return i9o[index];
			}
		}
	}

	public override IEnumerable<TagSnapshotRange<T>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
	{
		if (snapshotRanges == null || snapshotRanges.Count <= 0)
		{
			yield break;
		}
		TagVersionRange<T>[] versionRangeArray;
		lock (a9D)
		{
			versionRangeArray = i9o.ToArray();
		}
		ITextSnapshot targetSnapshot = snapshotRanges[0].Snapshot;
		int index = 0;
		TagVersionRange<T>[] array = versionRangeArray;
		foreach (TagVersionRange<T> item in array)
		{
			if (item.VersionRange.Document == targetSnapshot.Document)
			{
				TextSnapshotRange targetSnapshotRange = item.VersionRange.Translate(targetSnapshot);
				if (targetSnapshotRange.IsDeleted)
				{
					lock (a9D)
					{
						i9o.Remove(item);
						l90(NotifyCollectionChangedAction.Remove, item, index);
					}
				}
				else
				{
					foreach (TextSnapshotRange requestedSnapshotRange in snapshotRanges)
					{
						if ((requestedSnapshotRange.IsZeroLength && targetSnapshotRange.Contains(requestedSnapshotRange)) || (targetSnapshotRange.IsZeroLength && requestedSnapshotRange.Contains(targetSnapshotRange)) || requestedSnapshotRange.OverlapsWith(targetSnapshotRange))
						{
							yield return new TagSnapshotRange<T>(targetSnapshotRange, item.Tag);
						}
					}
				}
			}
			index++;
		}
	}

	public bool Remove(TagVersionRange<T> tagRange)
	{
		if (tagRange == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5676));
		}
		lock (a9D)
		{
			int num = i9o.IndexOf(tagRange);
			if (num != -1)
			{
				i9o.RemoveAt(num);
				l90(NotifyCollectionChangedAction.Remove, tagRange, num);
				q9Z(tagRange.VersionRange);
				return true;
			}
			return false;
		}
	}

	public bool Remove(T tag)
	{
		if (tag == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5562));
		}
		TagVersionRange<T> tagVersionRange = this[tag];
		if (tagVersionRange != null)
		{
			Remove(tagVersionRange);
			return true;
		}
		return false;
	}

	public int RemoveAll(Predicate<TagVersionRange<T>> match)
	{
		_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass33_0();
		CS_0024_003C_003E8__locals2.match = match;
		lock (a9D)
		{
			TagVersionRange<T>[] array = i9o.Where((TagVersionRange<T> tr) => CS_0024_003C_003E8__locals2.match(tr)).ToArray();
			if (array != null && array.Length != 0)
			{
				using (CreateBatch())
				{
					TagVersionRange<T>[] array2 = array;
					foreach (TagVersionRange<T> tagRange in array2)
					{
						Remove(tagRange);
					}
				}
				return array.Length;
			}
			return 0;
		}
	}

	public TagVersionRange<T> Toggle(ITextSnapshotLine snapshotLine, T tag)
	{
		if (snapshotLine == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5696));
		}
		lock (a9D)
		{
			using (CreateBatch())
			{
				TagVersionRange<T>[] array = i9o.ToArray();
				bool flag = false;
				TextSnapshotRange snapshotRange = snapshotLine.SnapshotRange;
				TagVersionRange<T>[] array2 = array;
				foreach (TagVersionRange<T> tagVersionRange in array2)
				{
					TextSnapshotRange textSnapshotRange = tagVersionRange.VersionRange.Translate(snapshotLine.Snapshot);
					if (textSnapshotRange == snapshotRange || textSnapshotRange.OverlapsWith(snapshotRange))
					{
						Remove(tagVersionRange);
						flag = true;
					}
				}
				if (!flag)
				{
					return Add(snapshotLine, tag);
				}
			}
		}
		return null;
	}

	public TagVersionRange<T> Toggle(TextSnapshotRange snapshotRange, T tag)
	{
		if (snapshotRange.IsDeleted)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5724));
		}
		if (tag == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5562));
		}
		lock (a9D)
		{
			using (CreateBatch())
			{
				TagVersionRange<T>[] array = i9o.ToArray();
				bool flag = false;
				TagVersionRange<T>[] array2 = array;
				foreach (TagVersionRange<T> tagVersionRange in array2)
				{
					if (tagVersionRange.VersionRange.Translate(snapshotRange.Snapshot).OverlapsWith(snapshotRange))
					{
						Remove(tagVersionRange);
						flag = true;
					}
				}
				if (!flag)
				{
					return Add(snapshotRange, tag);
				}
			}
		}
		return null;
	}

	internal static bool mAb()
	{
		return FAV == null;
	}

	internal static object GA1()
	{
		return FAV;
	}
}
