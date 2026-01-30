using System;
using System.IO;

namespace MimeKit.Text;

public class HtmlScriptDataToken : HtmlDataToken
{
	public HtmlScriptDataToken(string data)
		: base(HtmlTokenKind.ScriptData, data)
	{
	}

	public override void WriteTo(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		output.Write(base.Data);
	}
}
