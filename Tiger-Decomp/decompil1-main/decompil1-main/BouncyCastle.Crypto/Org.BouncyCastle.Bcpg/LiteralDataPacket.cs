using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg;

public class LiteralDataPacket : InputStreamPacket
{
	private int format;

	private byte[] fileName;

	private long modDate;

	public int Format => format;

	public long ModificationTime => modDate;

	public string FileName => Strings.FromUtf8ByteArray(fileName);

	internal LiteralDataPacket(BcpgInputStream bcpgIn)
		: base(bcpgIn)
	{
		format = bcpgIn.ReadByte();
		int len = bcpgIn.ReadByte();
		fileName = new byte[len];
		for (int i = 0; i != len; i++)
		{
			int ch = bcpgIn.ReadByte();
			if (ch < 0)
			{
				throw new IOException("literal data truncated in header");
			}
			fileName[i] = (byte)ch;
		}
		modDate = (long)(uint)((bcpgIn.ReadByte() << 24) | (bcpgIn.ReadByte() << 16) | (bcpgIn.ReadByte() << 8) | bcpgIn.ReadByte()) * 1000L;
	}

	public byte[] GetRawFileName()
	{
		return Arrays.Clone(fileName);
	}
}
