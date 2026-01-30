using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.IO;

public class CipherStream : Stream
{
	internal Stream stream;

	internal IBufferedCipher inCipher;

	internal IBufferedCipher outCipher;

	private byte[] mInBuf;

	private int mInPos;

	private bool inStreamEnded;

	public IBufferedCipher ReadCipher => inCipher;

	public IBufferedCipher WriteCipher => outCipher;

	public override bool CanRead
	{
		get
		{
			if (stream.CanRead)
			{
				return inCipher != null;
			}
			return false;
		}
	}

	public override bool CanWrite
	{
		get
		{
			if (stream.CanWrite)
			{
				return outCipher != null;
			}
			return false;
		}
	}

	public override bool CanSeek => false;

	public sealed override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public sealed override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public CipherStream(Stream stream, IBufferedCipher readCipher, IBufferedCipher writeCipher)
	{
		this.stream = stream;
		if (readCipher != null)
		{
			inCipher = readCipher;
			mInBuf = null;
		}
		if (writeCipher != null)
		{
			outCipher = writeCipher;
		}
	}

	public override int ReadByte()
	{
		if (inCipher == null)
		{
			return stream.ReadByte();
		}
		if ((mInBuf == null || mInPos >= mInBuf.Length) && !FillInBuf())
		{
			return -1;
		}
		return mInBuf[mInPos++];
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (inCipher == null)
		{
			return stream.Read(buffer, offset, count);
		}
		int num;
		int numToCopy;
		for (num = 0; num < count; num += numToCopy)
		{
			if ((mInBuf == null || mInPos >= mInBuf.Length) && !FillInBuf())
			{
				break;
			}
			numToCopy = System.Math.Min(count - num, mInBuf.Length - mInPos);
			Array.Copy(mInBuf, mInPos, buffer, offset + num, numToCopy);
			mInPos += numToCopy;
		}
		return num;
	}

	private bool FillInBuf()
	{
		if (inStreamEnded)
		{
			return false;
		}
		mInPos = 0;
		do
		{
			mInBuf = ReadAndProcessBlock();
		}
		while (!inStreamEnded && mInBuf == null);
		return mInBuf != null;
	}

	private byte[] ReadAndProcessBlock()
	{
		int blockSize = inCipher.GetBlockSize();
		byte[] block = new byte[(blockSize == 0) ? 256 : blockSize];
		int numRead = 0;
		do
		{
			int count = stream.Read(block, numRead, block.Length - numRead);
			if (count < 1)
			{
				inStreamEnded = true;
				break;
			}
			numRead += count;
		}
		while (numRead < block.Length);
		byte[] bytes = (inStreamEnded ? inCipher.DoFinal(block, 0, numRead) : inCipher.ProcessBytes(block));
		if (bytes != null && bytes.Length == 0)
		{
			bytes = null;
		}
		return bytes;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (outCipher == null)
		{
			stream.Write(buffer, offset, count);
			return;
		}
		byte[] data = outCipher.ProcessBytes(buffer, offset, count);
		if (data != null)
		{
			stream.Write(data, 0, data.Length);
		}
	}

	public override void WriteByte(byte b)
	{
		if (outCipher == null)
		{
			stream.WriteByte(b);
			return;
		}
		byte[] data = outCipher.ProcessByte(b);
		if (data != null)
		{
			stream.Write(data, 0, data.Length);
		}
	}

	public override void Close()
	{
		if (outCipher != null)
		{
			byte[] data = outCipher.DoFinal();
			stream.Write(data, 0, data.Length);
			stream.Flush();
		}
		Platform.Dispose(stream);
		base.Close();
	}

	public override void Flush()
	{
		stream.Flush();
	}

	public sealed override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public sealed override void SetLength(long length)
	{
		throw new NotSupportedException();
	}
}
