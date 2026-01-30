using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

[SuppressMessage("Microsoft.Usage", "CA2217:DoNotMarkEnumsWithFlags")]
[Flags]
[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
public enum TextRangeTrackingModes
{
	Default = 0,
	ExpandFirstEdge = 1,
	ExpandLastEdge = 2,
	ExpandBothEdges = 3,
	ExpandMask = 3,
	DeleteWhenSurrounded = 4,
	DeleteWhenZeroLength = 0xC,
	DeleteMask = 0xC,
	LineBased = 0x10,
	NegativeWhenZeroLength = 0x20
}
