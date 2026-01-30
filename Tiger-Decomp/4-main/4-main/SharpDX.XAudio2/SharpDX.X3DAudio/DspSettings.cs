using System;
using System.Runtime.InteropServices;

namespace SharpDX.X3DAudio;

public class DspSettings
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct __Native
	{
		public IntPtr MatrixCoefficientsPointer;

		public IntPtr DelayTimesPointer;

		public int SrcChannelCount;

		public int DstChannelCount;

		public float LPFDirectCoefficient;

		public float LPFReverbCoefficient;

		public float ReverbLevel;

		public float DopplerFactor;

		public float EmitterToListenerAngle;

		public float EmitterToListenerDistance;

		public float EmitterVelocityComponent;

		public float ListenerVelocityComponent;
	}

	public readonly float[] MatrixCoefficients;

	public readonly float[] DelayTimes;

	internal IntPtr MatrixCoefficientsPointer;

	internal IntPtr DelayTimesPointer;

	public readonly int SourceChannelCount;

	public readonly int DestinationChannelCount;

	public float LpfDirectCoefficient;

	public float LpfReverbCoefficient;

	public float ReverbLevel;

	public float DopplerFactor;

	public float EmitterToListenerAngle;

	public float EmitterToListenerDistance;

	public float EmitterVelocityComponent;

	public float ListenerVelocityComponent;

	public DspSettings(int sourceChannelCount, int destinationChannelCount)
	{
		SourceChannelCount = sourceChannelCount;
		DestinationChannelCount = destinationChannelCount;
		MatrixCoefficients = new float[sourceChannelCount * destinationChannelCount];
		DelayTimes = new float[destinationChannelCount];
	}

	internal void __MarshalFrom(ref __Native @ref)
	{
		LpfDirectCoefficient = @ref.LPFDirectCoefficient;
		LpfReverbCoefficient = @ref.LPFReverbCoefficient;
		ReverbLevel = @ref.ReverbLevel;
		DopplerFactor = @ref.DopplerFactor;
		EmitterToListenerAngle = @ref.EmitterToListenerAngle;
		EmitterToListenerDistance = @ref.EmitterToListenerDistance;
		EmitterVelocityComponent = @ref.EmitterVelocityComponent;
		ListenerVelocityComponent = @ref.ListenerVelocityComponent;
	}
}
