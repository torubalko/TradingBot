using System.Collections.Generic;

namespace ActiproSoftware.Text.Exporters;

public interface ITextExporter
{
	string DataFormat { get; }

	LineTerminator LineTerminator { get; set; }

	string Export(ITextSnapshot snapshot, ICollection<TextRange> textRanges);
}
