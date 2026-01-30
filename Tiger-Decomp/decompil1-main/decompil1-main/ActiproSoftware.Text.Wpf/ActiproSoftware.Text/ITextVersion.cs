using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

public interface ITextVersion
{
	ITextDocument Document { get; }

	int Length { get; }

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Next")]
	ITextVersion Next { get; }

	int Number { get; }

	IList<ITextChangeRangedOperation> Operations { get; }

	ITextVersionRange CreateRange(int startOffset, int length);

	ITextVersionRange CreateRange(int startOffset, int length, TextRangeTrackingModes trackingModes);

	ITextVersionRange CreateRange(TextRange textRange);

	ITextVersionRange CreateRange(TextRange textRange, TextRangeTrackingModes trackingModes);

	ITextVersionRange CreateRange(TextRange textRange, Func<TextRangeTrackingModes> trackingModesFunc);
}
