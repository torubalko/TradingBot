using System;
using System.IO;

namespace MimeKit.Text;

public class HtmlDataToken : HtmlToken
{
	internal bool EncodeEntities { get; set; }

	public string Data { get; private set; }

	protected HtmlDataToken(HtmlTokenKind kind, string data)
		: base(kind)
	{
		switch (kind)
		{
		default:
			throw new ArgumentOutOfRangeException("kind");
		case HtmlTokenKind.CData:
		case HtmlTokenKind.Data:
		case HtmlTokenKind.ScriptData:
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			Data = data;
			break;
		}
	}

	public HtmlDataToken(string data)
		: base(HtmlTokenKind.Data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Data = data;
	}

	public override void WriteTo(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (!EncodeEntities)
		{
			output.Write(Data);
		}
		else
		{
			HtmlUtils.HtmlEncode(output, Data);
		}
	}
}
