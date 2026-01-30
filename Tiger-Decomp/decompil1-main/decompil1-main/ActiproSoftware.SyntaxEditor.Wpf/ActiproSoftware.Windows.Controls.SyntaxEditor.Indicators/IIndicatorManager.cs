using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

public interface IIndicatorManager
{
	IBookmarkIndicatorManager Bookmarks { get; }

	IBreakpointIndicatorManager Breakpoints { get; }

	ICurrentStatementIndicatorManager CurrentStatement { get; }

	IEditorDocument Document { get; }

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> Add<TTagger, TTag>(ITextSnapshotLine snapshotLine, TTag tag) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> Add<TTagger, TTag>(TextSnapshotRange snapshotRange, TTag tag) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	void Clear<TTagger, TTag>() where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	int GetCount<TTagger, TTag>() where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> FindNext<TTagger, TTag>(ITextSnapshotLine snapshotLine, ITagSearchOptions<TTag> options) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> FindNext<TTagger, TTag>(TextSnapshotOffset snapshotOffset, ITagSearchOptions<TTag> options) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> GetInstance<TTagger, TTag>(TTag tag) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagVersionRange<TTag>> GetInstances<TTagger, TTag>() where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	IEnumerable<TagVersionRange<TTag>> GetInstances<TTagger, TTag>(ITextSnapshotLine snapshotLine) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	IEnumerable<TagVersionRange<TTag>> GetInstances<TTagger, TTag>(TextSnapshotRange snapshotRange) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	bool Remove<TTagger, TTag>(TTag tag) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	int RemoveAll<TTagger, TTag>(Predicate<TagVersionRange<TTag>> match) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> Toggle<TTagger, TTag>(ITextSnapshotLine snapshotLine, TTag tag) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	TagVersionRange<TTag> Toggle<TTagger, TTag>(TextSnapshotRange snapshotRange, TTag tag) where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag;
}
