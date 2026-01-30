namespace ActiproSoftware.Text.Exporters;

public interface IRtfTextExporter : ITextExporter
{
	string FontFamily { get; set; }

	double FontSizeInPoints { get; set; }
}
