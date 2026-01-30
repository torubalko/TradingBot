using System;
using System.IO;

namespace MimeKit.Text;

public class HtmlCDataToken : HtmlDataToken
{
	public HtmlCDataToken(string data)
		: base(HtmlTokenKind.CData, data)
	{
	}

	public override void WriteTo(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		output.Write("<![CDATA[");
		output.Write(base.Data);
		output.Write("]]>");
	}
}
