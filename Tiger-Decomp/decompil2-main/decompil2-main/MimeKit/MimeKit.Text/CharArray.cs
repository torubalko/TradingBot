using System.IO;

namespace MimeKit.Text;

internal class CharArray : ICharArray
{
	private readonly char[] array;

	public char this[int index] => array[index];

	public CharArray(char[] value)
	{
		array = value;
	}

	public void Write(TextWriter output, int startIndex, int count)
	{
		output.Write(array, startIndex, count);
	}
}
