using System.Runtime.InteropServices;

namespace SharpDX.DirectWrite;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct TextRange
{
	public int StartPosition;

	public int Length;

	public TextRange(int startPosition, int length)
	{
		StartPosition = startPosition;
		Length = length;
	}
}
