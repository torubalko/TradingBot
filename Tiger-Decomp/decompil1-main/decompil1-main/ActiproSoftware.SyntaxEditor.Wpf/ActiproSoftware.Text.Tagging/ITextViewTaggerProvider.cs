using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Text.Tagging;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public interface ITextViewTaggerProvider
{
	IEnumerable<Type> TagTypes { get; }

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
	ITagger<T> GetTagger<T>(ITextView view) where T : ITag;
}
