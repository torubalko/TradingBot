using System;
using System.Diagnostics;
using System.Threading;

namespace MimeKit.Utils;

internal class BufferPool
{
	private readonly byte[][] buffers;

	private SpinLock spinLock;

	private int index;

	public int BufferSize { get; private set; }

	public int MaxBufferCount { get; private set; }

	public BufferPool(int bufferSize, int maxBufferCount)
	{
		if (bufferSize < 1)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		if (maxBufferCount < 1)
		{
			throw new ArgumentOutOfRangeException("maxBufferCount");
		}
		buffers = new byte[maxBufferCount][];
		MaxBufferCount = maxBufferCount;
		BufferSize = bufferSize;
		spinLock = new SpinLock(Debugger.IsAttached);
	}

	public byte[] Rent(bool clear = false)
	{
		byte[] array = null;
		bool lockTaken = false;
		try
		{
			spinLock.Enter(ref lockTaken);
			if (index < buffers.Length)
			{
				array = buffers[index];
				buffers[index] = null;
				index++;
			}
		}
		finally
		{
			if (lockTaken)
			{
				spinLock.Exit(useMemoryBarrier: false);
			}
		}
		if (array == null)
		{
			array = new byte[BufferSize];
		}
		else if (clear)
		{
			Array.Clear(array, 0, BufferSize);
		}
		return array;
	}

	public void Return(byte[] buffer)
	{
		bool lockTaken = false;
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (buffer.Length != BufferSize)
		{
			throw new ArgumentException("The size of the buffer does not match the size used by the pool.", "buffer");
		}
		try
		{
			spinLock.Enter(ref lockTaken);
			if (index > 0)
			{
				buffers[--index] = buffer;
			}
		}
		finally
		{
			if (lockTaken)
			{
				spinLock.Exit(useMemoryBarrier: false);
			}
		}
	}
}
