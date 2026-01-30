namespace MimeKit.Text;

internal class UrlMatch
{
	public readonly string Pattern;

	public readonly string Prefix;

	public int StartIndex;

	public int EndIndex;

	public UrlMatch(string pattern, string prefix)
	{
		Pattern = pattern;
		Prefix = prefix;
	}
}
