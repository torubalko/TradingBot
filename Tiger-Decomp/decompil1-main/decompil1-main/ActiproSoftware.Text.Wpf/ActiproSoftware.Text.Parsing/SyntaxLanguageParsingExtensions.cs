using System;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Parsing.Implementation;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Text.Parsing;

public static class SyntaxLanguageParsingExtensions
{
	internal static SyntaxLanguageParsingExtensions p15;

	public static IParseData Parse(this ISyntaxLanguage language, string text)
	{
		if (language == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7624));
		}
		IParser service = language.GetService<IParser>();
		if (service != null)
		{
			CodeDocument codeDocument = new CodeDocument();
			codeDocument.IsParsingEnabled = false;
			codeDocument.Language = language;
			codeDocument.SetText(text);
			ITextBufferReader bufferReader = codeDocument.CurrentSnapshot.GetReader(0).BufferReader;
			ParseRequest parseRequest = new ParseRequest(Guid.NewGuid().ToString(), bufferReader, language, codeDocument);
			parseRequest.Snapshot = codeDocument.CurrentSnapshot;
			return service.Parse(parseRequest);
		}
		int num = 0;
		if (l1U() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => null, 
		};
	}

	internal static bool H1P()
	{
		return p15 == null;
	}

	internal static SyntaxLanguageParsingExtensions l1U()
	{
		return p15;
	}
}
