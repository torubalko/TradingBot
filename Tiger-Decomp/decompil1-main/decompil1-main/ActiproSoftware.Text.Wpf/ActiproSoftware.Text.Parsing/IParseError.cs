namespace ActiproSoftware.Text.Parsing;

public interface IParseError
{
	IClassificationType ClassificationType { get; }

	string Description { get; }

	ParseErrorLevel Level { get; }

	TextPositionRange PositionRange { get; }
}
