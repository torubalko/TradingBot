namespace MimeKit;

internal enum MimeParserState : sbyte
{
	Error = -1,
	Initialized,
	MboxMarker,
	MessageHeaders,
	Headers,
	Content,
	Boundary,
	Complete,
	Eos
}
