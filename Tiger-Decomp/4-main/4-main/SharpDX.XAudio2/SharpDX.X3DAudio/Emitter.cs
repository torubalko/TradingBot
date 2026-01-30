using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDX.X3DAudio;

public class Emitter
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct __Native
	{
		public IntPtr ConePointer;

		public RawVector3 OrientFront;

		public RawVector3 OrientTop;

		public RawVector3 Position;

		public RawVector3 Velocity;

		public float InnerRadius;

		public float InnerRadiusAngle;

		public int ChannelCount;

		public float ChannelRadius;

		public IntPtr ChannelAzimuthsPointer;

		public IntPtr VolumeCurvePointer;

		public IntPtr LFECurvePointer;

		public IntPtr LPFDirectCurvePointer;

		public IntPtr LPFReverbCurvePointer;

		public IntPtr ReverbCurvePointer;

		public float CurveDistanceScaler;

		public float DopplerScaler;

		public Cone.__Native Cone;

		internal void __MarshalFree()
		{
			if (ConePointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(ConePointer);
			}
			if (ChannelAzimuthsPointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(ChannelAzimuthsPointer);
			}
			if (VolumeCurvePointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(VolumeCurvePointer);
			}
			if (LFECurvePointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(LFECurvePointer);
			}
			if (LPFDirectCurvePointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(LPFDirectCurvePointer);
			}
			if (LPFReverbCurvePointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(LPFReverbCurvePointer);
			}
			if (ReverbCurvePointer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(ReverbCurvePointer);
			}
		}
	}

	public Cone Cone;

	public float[] ChannelAzimuths;

	public CurvePoint[] VolumeCurve;

	public CurvePoint[] LfeCurve;

	public CurvePoint[] LpfDirectCurve;

	public CurvePoint[] LpfReverbCurve;

	public CurvePoint[] ReverbCurve;

	internal IntPtr ConePointer;

	public RawVector3 OrientFront;

	public RawVector3 OrientTop;

	public RawVector3 Position;

	public RawVector3 Velocity;

	public float InnerRadius;

	public float InnerRadiusAngle;

	public int ChannelCount;

	public float ChannelRadius;

	internal IntPtr ChannelAzimuthsPointer;

	internal IntPtr VolumeCurvePointer;

	internal IntPtr LFECurvePointer;

	internal IntPtr LPFDirectCurvePointer;

	internal IntPtr LPFReverbCurvePointer;

	internal IntPtr ReverbCurvePointer;

	public float CurveDistanceScaler;

	public float DopplerScaler;

	internal void __MarshalFree(ref __Native @ref)
	{
		@ref.__MarshalFree();
	}

	internal unsafe void __MarshalTo(ref __Native @ref)
	{
		@ref.OrientFront = OrientFront;
		@ref.OrientTop = OrientTop;
		@ref.Position = Position;
		@ref.Velocity = Velocity;
		@ref.InnerRadius = InnerRadius;
		@ref.InnerRadiusAngle = InnerRadiusAngle;
		@ref.ChannelCount = ChannelCount;
		@ref.ChannelRadius = ChannelRadius;
		if (ChannelAzimuths != null && ChannelAzimuths.Length != 0 && ChannelCount > 0)
		{
			@ref.ChannelAzimuthsPointer = Marshal.AllocHGlobal(4 * Math.Min(ChannelCount, ChannelAzimuths.Length));
			Utilities.Write(@ref.ChannelAzimuthsPointer, ChannelAzimuths, 0, ChannelCount);
		}
		@ref.VolumeCurvePointer = DistanceCurve.FromCurvePoints(VolumeCurve);
		@ref.LFECurvePointer = DistanceCurve.FromCurvePoints(LfeCurve);
		@ref.LPFDirectCurvePointer = DistanceCurve.FromCurvePoints(LpfDirectCurve);
		@ref.LPFReverbCurvePointer = DistanceCurve.FromCurvePoints(LpfReverbCurve);
		@ref.ReverbCurvePointer = DistanceCurve.FromCurvePoints(ReverbCurve);
		@ref.CurveDistanceScaler = CurveDistanceScaler;
		@ref.DopplerScaler = DopplerScaler;
		if (Cone == null)
		{
			@ref.ConePointer = IntPtr.Zero;
			return;
		}
		fixed (Cone.__Native* cone = &@ref.Cone)
		{
			void* ptr = cone;
			@ref.ConePointer = (IntPtr)ptr;
		}
		Cone.__MarshalTo(ref @ref.Cone);
	}
}
