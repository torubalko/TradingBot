using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

public interface ITextStatistics
{
	double AverageLettersPerWord { get; }

	double AverageSyllablesPerWord { get; }

	double AverageWordsPerSentence { get; }

	int Characters { get; }

	int Consonants { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Flesch")]
	double FleschKincaidGradeLevel { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Flesch")]
	double FleschReadingEaseScore { get; }

	int Letters { get; }

	int Lines { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int NonWhitespaceCharacters { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int NonWhitespaceLines { get; }

	int Sentences { get; }

	int Syllables { get; }

	int Vowels { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int WhitespaceCharacters { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int WhitespaceLines { get; }

	int Words { get; }

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	IList<ITextStatistic> GetRawStatistics();
}
