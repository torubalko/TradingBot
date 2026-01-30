using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Tagging;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public static class TaggerKeys
{
	public const string BookmarkIndicator = "BookmarkIndicator";

	public const string BreakpointIndicator = "BreakpointIndicator";

	public const string CurrentStatementIndicator = "CurrentStatementIndicator";

	public const string FindMatchHighlight = "FindMatchHighlight";

	public const string Token = "Token";
}
