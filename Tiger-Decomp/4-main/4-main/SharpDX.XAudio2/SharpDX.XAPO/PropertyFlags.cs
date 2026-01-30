using System;

namespace SharpDX.XAPO;

[Flags]
public enum PropertyFlags
{
	ChannelsMustMatch = 1,
	FrameRateMustMatch = 2,
	BitspersampleMustMatch = 4,
	BufferCountMustMatch = 8,
	InplaceRequired = 0x20,
	InplaceSupported = 0x10,
	Default = 0x1F
}
