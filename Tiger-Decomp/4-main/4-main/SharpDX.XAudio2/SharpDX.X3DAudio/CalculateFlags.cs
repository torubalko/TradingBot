using System;

namespace SharpDX.X3DAudio;

[Flags]
public enum CalculateFlags
{
	Matrix = 1,
	Delay = 2,
	LpfDirect = 4,
	LpfReverb = 8,
	Reverb = 0x10,
	Doppler = 0x20,
	EmitterAngle = 0x40,
	ZeroCenter = 0x10000,
	RedirectToLfe = 0x20000
}
