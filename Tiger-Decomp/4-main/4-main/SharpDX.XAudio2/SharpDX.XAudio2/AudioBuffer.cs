using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

public class AudioBuffer
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	internal struct __Native
	{
		public BufferFlags Flags;

		public int AudioBytes;

		public IntPtr AudioDataPointer;

		public int PlayBegin;

		public int PlayLength;

		public int LoopBegin;

		public int LoopLength;

		public int LoopCount;

		public IntPtr Context;
	}

	private DataStream _dataStream;

	public const int LoopInfinite = 255;

	public BufferFlags Flags;

	public int AudioBytes;

	public IntPtr AudioDataPointer;

	public int PlayBegin;

	public int PlayLength;

	public int LoopBegin;

	public int LoopLength;

	public int LoopCount;

	public IntPtr Context;

	public DataStream Stream
	{
		get
		{
			return _dataStream;
		}
		set
		{
			_dataStream = value;
			AudioDataPointer = _dataStream.PositionPointer;
		}
	}

	public AudioBuffer()
	{
	}

	public AudioBuffer(DataStream stream)
	{
		Stream = stream;
		Flags = BufferFlags.EndOfStream;
		AudioBytes = (int)stream.Length;
	}

	public AudioBuffer(DataPointer dataBuffer)
	{
		AudioDataPointer = dataBuffer.Pointer;
		Flags = BufferFlags.EndOfStream;
		AudioBytes = dataBuffer.Size;
	}

	internal void __MarshalFree(ref __Native @ref)
	{
	}

	internal void __MarshalFrom(ref __Native @ref)
	{
		Flags = @ref.Flags;
		AudioBytes = @ref.AudioBytes;
		AudioDataPointer = @ref.AudioDataPointer;
		PlayBegin = @ref.PlayBegin;
		PlayLength = @ref.PlayLength;
		LoopBegin = @ref.LoopBegin;
		LoopLength = @ref.LoopLength;
		LoopCount = @ref.LoopCount;
		Context = @ref.Context;
	}

	internal void __MarshalTo(ref __Native @ref)
	{
		@ref.Flags = Flags;
		@ref.AudioBytes = AudioBytes;
		@ref.AudioDataPointer = AudioDataPointer;
		@ref.PlayBegin = PlayBegin;
		@ref.PlayLength = PlayLength;
		@ref.LoopBegin = LoopBegin;
		@ref.LoopLength = LoopLength;
		@ref.LoopCount = LoopCount;
		@ref.Context = Context;
	}
}
