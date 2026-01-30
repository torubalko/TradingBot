using System.Collections.Generic;
using System.Globalization;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

public interface IPart
{
	bool IsEditable { get; }

	bool IsLiteral { get; }

	bool IsOptional { get; }

	int Length { get; set; }

	int StartOffset { get; set; }

	string StringValue { get; set; }

	bool TryParseText(IList<IPart> parts, string text, int startOffset, CultureInfo culture, out int offset);
}
