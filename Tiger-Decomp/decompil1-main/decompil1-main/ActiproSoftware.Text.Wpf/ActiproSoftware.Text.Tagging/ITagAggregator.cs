using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Tagging;

public interface ITagAggregator<T> : IDisposable where T : ITag
{
	event EventHandler<TagsChangedEventArgs> TagsChanged;

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagSnapshotRange<T>> GetTags(params TextSnapshotRange[] snapshotRanges);

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagSnapshotRange<T>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter);
}
