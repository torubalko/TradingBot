namespace MimeKit.Text;

internal class UrlPattern
{
	public readonly UrlPatternType Type;

	public readonly string Pattern;

	public readonly string Prefix;

	public UrlPattern(UrlPatternType type, string pattern, string prefix)
	{
		Pattern = pattern;
		Prefix = prefix;
		Type = type;
	}
}
