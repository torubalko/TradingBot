using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDX.X3DAudio;

public class Listener
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct __Native
	{
		public RawVector3 OrientFront;

		public RawVector3 OrientTop;

		public RawVector3 Position;

		public RawVector3 Velocity;

		public IntPtr ConePointer;

		public Cone.__Native Cone;

		internal void __MarshalFree()
		{
		}
	}

	public Cone Cone;

	public RawVector3 OrientFront;

	public RawVector3 OrientTop;

	public RawVector3 Position;

	public RawVector3 Velocity;

	internal IntPtr ConePointer;

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
