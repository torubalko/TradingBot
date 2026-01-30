namespace MimeKit.IO.Filters;

public class PassThroughFilter : IMimeFilter
{
	public byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
	{
		outputIndex = startIndex;
		outputLength = length;
		return input;
	}

	public byte[] Flush(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
	{
		outputIndex = startIndex;
		outputLength = length;
		return input;
	}

	public void Reset()
	{
	}
}
