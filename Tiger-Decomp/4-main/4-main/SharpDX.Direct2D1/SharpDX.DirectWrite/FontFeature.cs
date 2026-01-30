using System.Runtime.InteropServices;

namespace SharpDX.DirectWrite;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct FontFeature
{
	public FontFeatureTag NameTag;

	public int Parameter;

	public FontFeature(FontFeatureTag nameTag, int parameter)
	{
		NameTag = nameTag;
		Parameter = parameter;
	}
}
