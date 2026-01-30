using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Tagging;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public interface ICodeDocumentTaggerProvider
{
	IEnumerable<Type> TagTypes { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	ITagger<T> GetTagger<T>(ICodeDocument document) where T : ITag;
}
