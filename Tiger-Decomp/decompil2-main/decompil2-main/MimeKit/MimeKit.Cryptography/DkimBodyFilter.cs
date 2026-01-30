using MimeKit.IO.Filters;

namespace MimeKit.Cryptography;

internal abstract class DkimBodyFilter : MimeFilterBase
{
	protected internal bool LastWasNewLine;

	protected bool IsEmptyLine;

	protected int EmptyLines;
}
