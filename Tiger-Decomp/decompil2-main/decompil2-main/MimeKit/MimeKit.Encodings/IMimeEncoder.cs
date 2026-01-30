namespace MimeKit.Encodings;

public interface IMimeEncoder
{
	ContentEncoding Encoding { get; }

	IMimeEncoder Clone();

	int EstimateOutputLength(int inputLength);

	int Encode(byte[] input, int startIndex, int length, byte[] output);

	int Flush(byte[] input, int startIndex, int length, byte[] output);

	void Reset();
}
