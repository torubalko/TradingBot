using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDX.XAudio2.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct ReverbParameters
{
	public float WetDryMix;

	public int ReflectionsDelay;

	public byte ReverbDelay;

	public byte RearDelay;

	public byte SideDelay;

	public byte PositionLeft;

	public byte PositionRight;

	public byte PositionMatrixLeft;

	public byte PositionMatrixRight;

	public byte EarlyDiffusion;

	public byte LateDiffusion;

	public byte LowEQGain;

	public byte LowEQCutoff;

	public byte HighEQGain;

	public byte HighEQCutoff;

	public float RoomFilterFreq;

	public float RoomFilterMain;

	public float RoomFilterHF;

	public float ReflectionsGain;

	public float ReverbGain;

	public float DecayTime;

	public float Density;

	public float RoomSize;

	public RawBool DisableLateField;

	public static explicit operator ReverbParameters(ReverbI3DL2Parameters I3DL2Parameters)
	{
		ReverbParameters result = new ReverbParameters
		{
			RearDelay = 5,
			PositionLeft = 6,
			PositionRight = 6,
			PositionMatrixLeft = 27,
			PositionMatrixRight = 27,
			RoomSize = 100f,
			LowEQCutoff = 4,
			HighEQCutoff = 6,
			RoomFilterMain = (float)I3DL2Parameters.Room / 100f,
			RoomFilterHF = (float)I3DL2Parameters.RoomHF / 100f
		};
		if (I3DL2Parameters.DecayHFRatio >= 1f)
		{
			int num = (int)(-4.0 * Math.Log10(I3DL2Parameters.DecayHFRatio));
			if (num < -8)
			{
				num = -8;
			}
			result.LowEQGain = (byte)((num < 0) ? ((uint)(num + 8)) : 8u);
			result.HighEQGain = 8;
			result.DecayTime = I3DL2Parameters.DecayTime * I3DL2Parameters.DecayHFRatio;
		}
		else
		{
			int num2 = (int)(4.0 * Math.Log10(I3DL2Parameters.DecayHFRatio));
			if (num2 < -8)
			{
				num2 = -8;
			}
			result.LowEQGain = 8;
			result.HighEQGain = (byte)((num2 < 0) ? ((uint)(num2 + 8)) : 8u);
			result.DecayTime = I3DL2Parameters.DecayTime;
		}
		float num3 = I3DL2Parameters.ReflectionsDelay * 1000f;
		if (num3 >= 300f)
		{
			num3 = 299f;
		}
		else if (num3 <= 1f)
		{
			num3 = 1f;
		}
		result.ReflectionsDelay = (int)num3;
		float num4 = I3DL2Parameters.ReverbDelay * 1000f;
		if (num4 >= 85f)
		{
			num4 = 84f;
		}
		result.ReverbDelay = (byte)num4;
		result.ReflectionsGain = (float)I3DL2Parameters.Reflections / 100f;
		result.ReverbGain = (float)I3DL2Parameters.Reverb / 100f;
		result.EarlyDiffusion = (byte)(15f * I3DL2Parameters.Diffusion / 100f);
		result.LateDiffusion = result.EarlyDiffusion;
		result.Density = I3DL2Parameters.Density;
		result.RoomFilterFreq = I3DL2Parameters.HFReference;
		result.WetDryMix = I3DL2Parameters.WetDryMix;
		return result;
	}
}
