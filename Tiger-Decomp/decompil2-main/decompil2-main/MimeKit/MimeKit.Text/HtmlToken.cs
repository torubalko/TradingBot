using System.IO;

namespace MimeKit.Text;

public abstract class HtmlToken
{
	public HtmlTokenKind Kind { get; private set; }

	protected HtmlToken(HtmlTokenKind kind)
	{
		Kind = kind;
	}

	public abstract void WriteTo(TextWriter output);

	public override string ToString()
	{
		using StringWriter stringWriter = new StringWriter();
		WriteTo(stringWriter);
		return stringWriter.ToString();
	}
}
