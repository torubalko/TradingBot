using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

public interface ITextRangeIndicatorManager<TTagger, TTag> where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag, new()
{
	int Count { get; }

	TagVersionRange<TTag> this[TTag tag] { get; }

	TagVersionRange<TTag> Add(TextSnapshotRange snapshotRange);

	TagVersionRange<TTag> Add(TextSnapshotRange snapshotRange, TTag tag);

	void Clear();

	TagVersionRange<TTag> FindNext(TextSnapshotOffset snapshotOffset, ITagSearchOptions<TTag> options);

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagVersionRange<TTag>> GetInstances();

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagVersionRange<TTag>> GetInstances(TextSnapshotRange snapshotRange);

	bool Remove(TTag tag);

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	int RemoveAll(Predicate<TagVersionRange<TTag>> match);

	TagVersionRange<TTag> Toggle(TextSnapshotRange snapshotRange);

	TagVersionRange<TTag> Toggle(TextSnapshotRange snapshotRange, TTag tag);
}
