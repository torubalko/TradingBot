using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.Utils;

namespace MimeKit.IO;

public class MemoryBlockStream : Stream
{
	private const long MaxCapacity = 4398046509056L;

	private const long BlockSize = 2048L;

	private static readonly BufferPool DefaultPool = new BufferPool(2048, 200);

	private readonly List<byte[]> blocks = new List<byte[]>();

	private readonly BufferPool pool;

	private long position;

	private long length;

	private bool disposed;

	public override bool CanRead => true;

	public override bool CanWrite => true;

	public override bool CanSeek => true;

	public override bool CanTimeout => false;

	public override long Length
	{
		get
		{
			CheckDisposed();
			return length;
		}
	}

	public override long Position
	{
		get
		{
			return position;
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public MemoryBlockStream()
	{
		pool = DefaultPool;
		blocks.Add(pool.Rent(Debugger.IsAttached));
	}

	public byte[] ToArray()
	{
		byte[] array = new byte[length];
		int num = (int)length;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		while (num3 < length)
		{
			int num5 = Math.Min(2048, num);
			Buffer.BlockCopy(blocks[num4], 0, array, num2, num5);
			num2 += num5;
			num3 += num5;
			num -= num5;
			num4++;
		}
		return array;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("MemoryBlockStream");
		}
	}

	private static void ValidateArguments(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		if (position == 4398046509056L)
		{
			return 0;
		}
		int num = Math.Min((int)(length - position), count);
		int num2 = (int)(position % 2048);
		int num3 = (int)(position / 2048);
		int num4 = 0;
		while (num4 < num && num3 < blocks.Count)
		{
			int num5 = Math.Min(2048 - num2, num - num4);
			Buffer.BlockCopy(blocks[num3], num2, buffer, offset + num4, num5);
			num2 = 0;
			num4 += num5;
			num3++;
		}
		position += num4;
		return num4;
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return Task.FromResult(Read(buffer, offset, count));
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		if (position + count >= 4398046509056L)
		{
			throw new IOException(string.Format(CultureInfo.InvariantCulture, "Cannot exceed {0} bytes", 4398046509056L));
		}
		int num = (int)(position % 2048);
		long num2 = (long)blocks.Count * 2048L;
		int num3 = (int)(position / 2048);
		int num4 = 0;
		for (; num2 < position + count; num2 += 2048)
		{
			blocks.Add(pool.Rent(Debugger.IsAttached));
		}
		while (num4 < count)
		{
			int num5 = Math.Min(2048 - num, count - num4);
			Buffer.BlockCopy(buffer, offset + num4, blocks[num3], num, num5);
			num = 0;
			num4 += num5;
			num3++;
		}
		position += num4;
		length = Math.Max(length, position);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		Write(buffer, offset, count);
		return Task.FromResult(0);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		CheckDisposed();
		long num = origin switch
		{
			SeekOrigin.Begin => offset, 
			SeekOrigin.Current => position + offset, 
			SeekOrigin.End => length + offset, 
			_ => throw new ArgumentOutOfRangeException("origin", "Invalid SeekOrigin specified"), 
		};
		if (num < 0)
		{
			throw new IOException("Cannot seek to a position before the beginning of the stream");
		}
		if (num > 4398046509056L)
		{
			throw new IOException(string.Format(CultureInfo.InvariantCulture, "Cannot exceed {0} bytes", 4398046509056L));
		}
		if (num == position)
		{
			return position;
		}
		if (num > length)
		{
			throw new IOException("Cannot seek beyond the end of the stream");
		}
		position = num;
		return position;
	}

	public override void Flush()
	{
		CheckDisposed();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		return Task.FromResult(0);
	}

	public override void SetLength(long value)
	{
		CheckDisposed();
		if (value < 0 || value > 4398046509056L)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		long num = (long)blocks.Count * 2048L;
		if (value > num)
		{
			do
			{
				blocks.Add(pool.Rent(Debugger.IsAttached));
				num += 2048;
			}
			while (num < value);
		}
		else if (value < length)
		{
			while (num - value > 2048)
			{
				pool.Return(blocks[blocks.Count - 1]);
				blocks.RemoveAt(blocks.Count - 1);
				num -= 2048;
			}
			int num2 = (int)(Math.Min(length, num) - value);
			int index = (int)(value % 2048);
			int index2 = (int)(value / 2048);
			Array.Clear(blocks[index2], index, num2);
		}
		position = Math.Min(position, value);
		length = value;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			for (int i = 0; i < blocks.Count; i++)
			{
				pool.Return(blocks[i]);
				blocks[i] = null;
			}
			blocks.Clear();
			disposed = true;
		}
		base.Dispose(disposing);
	}
}
