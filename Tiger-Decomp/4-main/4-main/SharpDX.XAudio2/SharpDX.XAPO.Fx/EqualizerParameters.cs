using System.Runtime.InteropServices;

namespace SharpDX.XAPO.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct EqualizerParameters
{
	public float FrequencyCenter0;

	public float Gain0;

	public float Bandwidth0;

	public float FrequencyCenter1;

	public float Gain1;

	public float Bandwidth1;

	public float FrequencyCenter2;

	public float Gain2;

	public float Bandwidth2;

	public float FrequencyCenter3;

	public float Gain3;

	public float Bandwidth3;
}
