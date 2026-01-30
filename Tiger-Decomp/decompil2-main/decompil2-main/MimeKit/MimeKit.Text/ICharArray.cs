using System.IO;

namespace MimeKit.Text;

internal interface ICharArray
{
	char this[int index] { get; }

	void Write(TextWriter output, int startIndex, int count);
}
