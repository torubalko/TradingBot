using System;
using System.IO;

namespace MimeKit.Text;

public class HtmlCommentToken : HtmlToken
{
	public string Comment { get; private set; }

	public bool IsBogusComment { get; private set; }

	internal bool IsBangComment { get; set; }

	public HtmlCommentToken(string comment, bool bogus = false)
		: base(HtmlTokenKind.Comment)
	{
		if (comment == null)
		{
			throw new ArgumentNullException("comment");
		}
		IsBogusComment = bogus;
		Comment = comment;
	}

	public override void WriteTo(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (!IsBogusComment)
		{
			output.Write("<!--");
			output.Write(Comment);
			output.Write("-->");
			return;
		}
		output.Write('<');
		if (IsBangComment)
		{
			output.Write('!');
		}
		output.Write(Comment);
		output.Write('>');
	}
}
