using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Tagging;

public interface ITagSearchOptions<T> where T : ITag
{
	bool CanWrap { get; set; }

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	Predicate<TagVersionRange<T>> Filter { get; set; }

	bool SearchUp { get; set; }
}
