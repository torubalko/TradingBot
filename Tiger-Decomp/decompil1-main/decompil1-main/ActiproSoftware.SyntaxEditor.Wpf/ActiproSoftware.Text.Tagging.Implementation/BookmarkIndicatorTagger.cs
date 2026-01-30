using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class BookmarkIndicatorTagger : IndicatorTaggerBase<BookmarkIndicatorTag>
{
	private static BookmarkIndicatorTagger v5L;

	public BookmarkIndicatorTagger(ICodeDocument document)
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(197968), (IEnumerable<Ordering>)new Ordering[1]
		{
			new Ordering(Q7Z.tqM(198006), OrderPlacement.After)
		}, document, isForLanguage: true);
	}

	internal static bool I5g()
	{
		return v5L == null;
	}

	internal static BookmarkIndicatorTagger b5A()
	{
		return v5L;
	}
}
