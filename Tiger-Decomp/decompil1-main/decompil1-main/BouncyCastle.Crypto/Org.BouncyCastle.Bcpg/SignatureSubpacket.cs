using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg;

public class SignatureSubpacket
{
	private readonly SignatureSubpacketTag type;

	private readonly bool critical;

	private readonly bool isLongLength;

	internal byte[] data;

	public SignatureSubpacketTag SubpacketType => type;

	protected internal SignatureSubpacket(SignatureSubpacketTag type, bool critical, bool isLongLength, byte[] data)
	{
		this.type = type;
		this.critical = critical;
		this.isLongLength = isLongLength;
		this.data = data;
	}

	public bool IsCritical()
	{
		return critical;
	}

	public bool IsLongLength()
	{
		return isLongLength;
	}

	public byte[] GetData()
	{
		return (byte[])data.Clone();
	}

	public void Encode(Stream os)
	{
		int bodyLen = data.Length + 1;
		if (isLongLength)
		{
			os.WriteByte(byte.MaxValue);
			os.WriteByte((byte)(bodyLen >> 24));
			os.WriteByte((byte)(bodyLen >> 16));
			os.WriteByte((byte)(bodyLen >> 8));
			os.WriteByte((byte)bodyLen);
		}
		else if (bodyLen < 192)
		{
			os.WriteByte((byte)bodyLen);
		}
		else if (bodyLen <= 8383)
		{
			bodyLen -= 192;
			os.WriteByte((byte)(((bodyLen >> 8) & 0xFF) + 192));
			os.WriteByte((byte)bodyLen);
		}
		else
		{
			os.WriteByte(byte.MaxValue);
			os.WriteByte((byte)(bodyLen >> 24));
			os.WriteByte((byte)(bodyLen >> 16));
			os.WriteByte((byte)(bodyLen >> 8));
			os.WriteByte((byte)bodyLen);
		}
		if (critical)
		{
			os.WriteByte((byte)((SignatureSubpacketTag)128 | type));
		}
		else
		{
			os.WriteByte((byte)type);
		}
		os.Write(data, 0, data.Length);
	}

	public override int GetHashCode()
	{
		return (critical ? 1 : 0) + 7 * (int)type + 49 * Arrays.GetHashCode(data);
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is SignatureSubpacket other))
		{
			return false;
		}
		if (type == other.type && critical == other.critical)
		{
			return Arrays.AreEqual(data, other.data);
		}
		return false;
	}
}
