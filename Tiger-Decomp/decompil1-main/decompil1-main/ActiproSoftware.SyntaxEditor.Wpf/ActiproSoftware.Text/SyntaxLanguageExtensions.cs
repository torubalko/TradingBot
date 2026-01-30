using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Analysis;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Text;

public static class SyntaxLanguageExtensions
{
	private static SyntaxLanguageExtensions J1T;

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IAutoCorrector GetAutoCorrector(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IAutoCorrector>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterAutoCorrector(this ISyntaxLanguage language, IAutoCorrector value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterAutoCorrector(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IAutoCorrector>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ICodeBlockFinder GetCodeBlockFinder(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<ICodeBlockFinder>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterCodeBlockFinder(this ISyntaxLanguage language, ICodeBlockFinder value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterCodeBlockFinder(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<ICodeBlockFinder>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IDelimiterAutoCompleter GetDelimiterAutoCompleter(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IDelimiterAutoCompleter>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterDelimiterAutoCompleter(this ISyntaxLanguage language, IDelimiterAutoCompleter value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterDelimiterAutoCompleter(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IDelimiterAutoCompleter>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IExampleTextProvider GetExampleTextProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IExampleTextProvider>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterExampleTextProvider(this ISyntaxLanguage language, IExampleTextProvider value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterExampleTextProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IExampleTextProvider>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IIndentProvider GetIndentProvider(this ISyntaxLanguage language)
	{
		if (language != null)
		{
			return language.GetService<IIndentProvider>();
		}
		throw new ArgumentNullException(Q7Z.tqM(197912));
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterIndentProvider(this ISyntaxLanguage language, IIndentProvider value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterIndentProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IIndentProvider>();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ILexer GetLexer(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<ILexer>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public static void RegisterLexer(this ISyntaxLanguage language, ILexer value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public static void UnregisterLexer(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<ILexer>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ILineCommenter GetLineCommenter(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<ILineCommenter>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterLineCommenter(this ISyntaxLanguage language, ILineCommenter value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterLineCommenter(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<ILineCommenter>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static INavigableSymbolProvider GetNavigableSymbolProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<INavigableSymbolProvider>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterNavigableSymbolProvider(this ISyntaxLanguage language, INavigableSymbolProvider value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterNavigableSymbolProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<INavigableSymbolProvider>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IOutliner GetOutliner(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IOutliner>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterOutliner(this ISyntaxLanguage language, IOutliner value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterOutliner(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IOutliner>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IParser GetParser(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IParser>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterParser(this ISyntaxLanguage language, IParser value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterParser(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IParser>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IStructureMatcher GetStructureMatcher(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IStructureMatcher>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterStructureMatcher(this ISyntaxLanguage language, IStructureMatcher value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterStructureMatcher(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IStructureMatcher>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ITextFormatter GetTextFormatter(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<ITextFormatter>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterTextFormatter(this ISyntaxLanguage language, ITextFormatter value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterTextFormatter(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<ITextFormatter>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ITextStatisticsFactory GetTextStatisticsFactory(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<ITextStatisticsFactory>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterTextStatisticsFactory(this ISyntaxLanguage language, ITextStatisticsFactory value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterTextStatisticsFactory(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<ITextStatisticsFactory>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ITextViewLineNumberProvider GetTextViewLineNumberProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<ITextViewLineNumberProvider>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void RegisterTextViewLineNumberProvider(this ISyntaxLanguage language, ITextViewLineNumberProvider value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void UnregisterTextViewLineNumberProvider(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<ITextViewLineNumberProvider>();
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "WordBreak")]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static IWordBreakFinder GetWordBreakFinder(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		return language.GetService<IWordBreakFinder>();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "WordBreak")]
	public static void RegisterWordBreakFinder(this ISyntaxLanguage language, IWordBreakFinder value)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.RegisterService(value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "WordBreak")]
	public static void UnregisterWordBreakFinder(this ISyntaxLanguage language)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		language.UnregisterService<IWordBreakFinder>();
	}

	internal static bool m1t()
	{
		return J1T == null;
	}

	internal static SyntaxLanguageExtensions V1Y()
	{
		return J1T;
	}
}
