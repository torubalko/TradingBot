using System.IO;

namespace MimeKit.Text;

internal class CharString : ICharArray
{
	private readonly string array;

	public char this[int index] => array[index];

	public CharString(string value)
	{
		array = value;
	}

	public void Write(TextWriter output, int startIndex, int count)
	{
		int num = startIndex + count;
		for (int i = startIndex; i < num; i++)
		{
			output.Write(array[i]);
		}
	}
}
