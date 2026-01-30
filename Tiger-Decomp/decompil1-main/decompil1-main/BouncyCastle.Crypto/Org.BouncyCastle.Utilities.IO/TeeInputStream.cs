using System.IO;

namespace Org.BouncyCastle.Utilities.IO;

public class TeeInputStream : BaseInputStream
{
	private readonly Stream input;

	private readonly Stream tee;

	public TeeInputStream(Stream input, Stream tee)
	{
		this.input = input;
		this.tee = tee;
	}

	public override void Close()
	{
		Platform.Dispose(input);
		Platform.Dispose(tee);
		base.Close();
	}

	public override int Read(byte[] buf, int off, int len)
	{
		int i = input.Read(buf, off, len);
		if (i > 0)
		{
			tee.Write(buf, off, i);
		}
		return i;
	}

	public override int ReadByte()
	{
		int i = input.ReadByte();
		if (i >= 0)
		{
			tee.WriteByte((byte)i);
		}
		return i;
	}
}
