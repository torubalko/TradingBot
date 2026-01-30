using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.IO;

public class DigestStream : Stream
{
	protected readonly Stream stream;

	protected readonly IDigest inDigest;

	protected readonly IDigest outDigest;

	public override bool CanRead => stream.CanRead;

	public override bool CanWrite => stream.CanWrite;

	public override bool CanSeek => stream.CanSeek;

	public override long Length => stream.Length;

	public override long Position
	{
		get
		{
			return stream.Position;
		}
		set
		{
			stream.Position = value;
		}
	}

	public DigestStream(Stream stream, IDigest readDigest, IDigest writeDigest)
	{
		this.stream = stream;
		inDigest = readDigest;
		outDigest = writeDigest;
	}

	public virtual IDigest ReadDigest()
	{
		return inDigest;
	}

	public virtual IDigest WriteDigest()
	{
		return outDigest;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int n = stream.Read(buffer, offset, count);
		if (inDigest != null && n > 0)
		{
			inDigest.BlockUpdate(buffer, offset, n);
		}
		return n;
	}

	public override int ReadByte()
	{
		int b = stream.ReadByte();
		if (inDigest != null && b >= 0)
		{
			inDigest.Update((byte)b);
		}
		return b;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (outDigest != null && count > 0)
		{
			outDigest.BlockUpdate(buffer, offset, count);
		}
		stream.Write(buffer, offset, count);
	}

	public override void WriteByte(byte b)
	{
		if (outDigest != null)
		{
			outDigest.Update(b);
		}
		stream.WriteByte(b);
	}

	public override void Close()
	{
		Platform.Dispose(stream);
		base.Close();
	}

	public override void Flush()
	{
		stream.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream.Seek(offset, origin);
	}

	public override void SetLength(long length)
	{
		stream.SetLength(length);
	}
}
