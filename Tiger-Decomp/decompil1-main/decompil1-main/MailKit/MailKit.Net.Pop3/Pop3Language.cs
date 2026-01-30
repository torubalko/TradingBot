namespace MailKit.Net.Pop3;

public class Pop3Language
{
	public string Language { get; private set; }

	public string Description { get; private set; }

	internal Pop3Language(string lang, string desc)
	{
		Language = lang;
		Description = desc;
	}
}
