namespace ActiproSoftware.Text.Analysis;

public interface IDelimiterAutoCompleter
{
	bool CanCompleteAngleBraces { get; set; }

	bool CanCompleteCurlyBraces { get; set; }

	bool CanCompleteParentheses { get; set; }

	bool CanCompleteSquareBraces { get; set; }
}
