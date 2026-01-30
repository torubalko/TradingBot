namespace MimeKit;

internal enum BoundaryType
{
	None,
	Eos,
	ImmediateBoundary,
	ImmediateEndBoundary,
	ParentBoundary,
	ParentEndBoundary
}
