namespace MimeKit.Encodings;

public interface IMimeDecoder
{
	ContentEncoding Encoding { get; }

	IMimeDecoder Clone();

	int EstimateOutputLength(int inputLength);

	unsafe int Decode(byte* input, int length, byte* output);

	int Decode(byte[] input, int startIndex, int length, byte[] output);

	void Reset();
}
