using System.Collections.Generic;

namespace MimeKit;

public sealed class MimeEntityConstructorArgs
{
	internal readonly ParserOptions ParserOptions;

	internal readonly IEnumerable<Header> Headers;

	internal readonly ContentType ContentType;

	internal readonly bool IsTopLevel;

	internal MimeEntityConstructorArgs(ParserOptions options, ContentType ctype, IEnumerable<Header> headers, bool toplevel)
	{
		ParserOptions = options;
		IsTopLevel = toplevel;
		ContentType = ctype;
		Headers = headers;
	}
}
