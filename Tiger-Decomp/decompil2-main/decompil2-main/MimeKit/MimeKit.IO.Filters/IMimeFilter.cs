namespace MimeKit.IO.Filters;

public interface IMimeFilter
{
	byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength);

	byte[] Flush(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength);

	void Reset();
}
