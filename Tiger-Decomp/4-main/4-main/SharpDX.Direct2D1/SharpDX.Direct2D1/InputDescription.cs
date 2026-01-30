using System.Runtime.InteropServices;

namespace SharpDX.Direct2D1;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct InputDescription
{
	public Filter Filter;

	public int LevelOfDetailCount;

	public InputDescription(Filter filter, int levelOfDetail)
	{
		Filter = filter;
		LevelOfDetailCount = levelOfDetail;
	}
}
