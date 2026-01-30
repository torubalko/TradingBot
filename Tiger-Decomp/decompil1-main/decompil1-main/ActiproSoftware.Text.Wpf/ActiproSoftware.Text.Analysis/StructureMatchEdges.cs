using System;

namespace ActiproSoftware.Text.Analysis;

[Flags]
public enum StructureMatchEdges
{
	None = 0,
	Start = 1,
	End = 2,
	Both = 3
}
