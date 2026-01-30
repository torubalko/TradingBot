using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Tagging;

public interface ICollectionTagger<T> : ITagger<T>, IOrderable, IKeyedObject where T : ITag
{
	int Count { get; }

	TagVersionRange<T> this[T tag] { get; }

	void Add(TagVersionRange<T> tagRange);

	TagVersionRange<T> Add(ITextSnapshotLine snapshotLine, T tag);

	TagVersionRange<T> Add(TextSnapshotRange snapshotRange, T tag);

	void Clear();

	IDisposable CreateBatch();

	bool Contains(TagVersionRange<T> tagRange);

	void CopyTo(TagVersionRange<T>[] array, int arrayIndex);

	TagVersionRange<T> FindNext(ITextSnapshotLine snapshotLine, ITagSearchOptions<T> options);

	TagVersionRange<T> FindNext(TextSnapshotOffset snapshotOffset, ITagSearchOptions<T> options);

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerator<TagVersionRange<T>> GetEnumerator();

	bool Remove(TagVersionRange<T> tagRange);

	bool Remove(T tag);

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	int RemoveAll(Predicate<TagVersionRange<T>> match);

	TagVersionRange<T> Toggle(ITextSnapshotLine snapshotLine, T tag);

	TagVersionRange<T> Toggle(TextSnapshotRange snapshotRange, T tag);
}
