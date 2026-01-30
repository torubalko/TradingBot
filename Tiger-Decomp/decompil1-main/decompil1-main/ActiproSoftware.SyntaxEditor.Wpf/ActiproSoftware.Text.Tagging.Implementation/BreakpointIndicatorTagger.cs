using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class BreakpointIndicatorTagger : IndicatorClassificationTaggerBase<BreakpointIndicatorTag>
{
	internal static BreakpointIndicatorTagger l5k;

	public BreakpointIndicatorTagger(ICodeDocument document)
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(198020), (IEnumerable<Ordering>)new Ordering[3]
		{
			new Ordering(Q7Z.tqM(420), OrderPlacement.After),
			new Ordering(Q7Z.tqM(198006), OrderPlacement.Before),
			new Ordering(Q7Z.tqM(197968), OrderPlacement.Before)
		}, document, isForLanguage: true);
	}

	internal static bool B5Z()
	{
		return l5k == null;
	}

	internal static BreakpointIndicatorTagger a5F()
	{
		return l5k;
	}
}
