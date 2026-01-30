using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class CurrentStatementIndicatorTagger : IndicatorClassificationTaggerBase<CurrentStatementIndicatorTag>
{
	private static CurrentStatementIndicatorTagger Q5O;

	public CurrentStatementIndicatorTagger(ICodeDocument document)
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(198062), (IEnumerable<Ordering>)new Ordering[4]
		{
			new Ordering(Q7Z.tqM(420), OrderPlacement.After),
			new Ordering(Q7Z.tqM(198020), OrderPlacement.Before),
			new Ordering(Q7Z.tqM(198006), OrderPlacement.Before),
			new Ordering(Q7Z.tqM(197968), OrderPlacement.Before)
		}, document, isForLanguage: true);
	}

	internal static bool m51()
	{
		return Q5O == null;
	}

	internal static CurrentStatementIndicatorTagger u55()
	{
		return Q5O;
	}
}
