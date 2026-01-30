using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Tagging;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public interface ITagger<T> : IOrderable, IKeyedObject where T : ITag
{
	event EventHandler Closed;

	event EventHandler<TagsChangedEventArgs> TagsChanged;

	void Close();

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagSnapshotRange<T>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter);
}
