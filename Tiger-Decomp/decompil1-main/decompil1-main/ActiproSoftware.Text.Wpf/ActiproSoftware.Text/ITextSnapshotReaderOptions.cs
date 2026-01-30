namespace ActiproSoftware.Text;

public interface ITextSnapshotReaderOptions
{
	int DefaultTokenLoadBufferLength { get; set; }

	int InitialTokenLoadBufferLength { get; set; }

	TextScanDirection? PrimaryScanDirection { get; set; }
}
