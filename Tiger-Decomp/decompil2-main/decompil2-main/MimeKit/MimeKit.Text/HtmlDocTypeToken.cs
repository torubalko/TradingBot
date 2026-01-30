using System;
using System.IO;

namespace MimeKit.Text;

public class HtmlDocTypeToken : HtmlToken
{
	private string publicIdentifier;

	private string systemIdentifier;

	internal string RawTagName { get; set; }

	public bool ForceQuirksMode { get; set; }

	public string Name { get; set; }

	public string PublicIdentifier
	{
		get
		{
			return publicIdentifier;
		}
		set
		{
			publicIdentifier = value;
			if (value != null)
			{
				if (PublicKeyword == null)
				{
					PublicKeyword = "PUBLIC";
				}
			}
			else if (systemIdentifier != null)
			{
				SystemKeyword = "SYSTEM";
			}
		}
	}

	public string PublicKeyword { get; internal set; }

	public string SystemIdentifier
	{
		get
		{
			return systemIdentifier;
		}
		set
		{
			systemIdentifier = value;
			if (value != null)
			{
				if (publicIdentifier == null && SystemKeyword == null)
				{
					SystemKeyword = "SYSTEM";
				}
			}
			else
			{
				SystemKeyword = null;
			}
		}
	}

	public string SystemKeyword { get; internal set; }

	public HtmlDocTypeToken()
		: base(HtmlTokenKind.DocType)
	{
		RawTagName = "DOCTYPE";
	}

	public override void WriteTo(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		output.Write("<!");
		output.Write(RawTagName);
		if (Name != null)
		{
			output.Write(' ');
			output.Write(Name);
		}
		if (PublicIdentifier != null)
		{
			output.Write(' ');
			output.Write(PublicKeyword);
			output.Write(" \"");
			output.Write(PublicIdentifier);
			output.Write('"');
			if (SystemIdentifier != null)
			{
				output.Write(" \"");
				output.Write(SystemIdentifier);
				output.Write('"');
			}
		}
		else if (SystemIdentifier != null)
		{
			output.Write(' ');
			output.Write(SystemKeyword);
			output.Write(" \"");
			output.Write(SystemIdentifier);
			output.Write('"');
		}
		output.Write('>');
	}
}
