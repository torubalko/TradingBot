using System;
using System.IO;
using System.Text;

namespace Org.BouncyCastle.Bcpg.Sig;

public class NotationData : SignatureSubpacket
{
	public const int HeaderFlagLength = 4;

	public const int HeaderNameLength = 2;

	public const int HeaderValueLength = 2;

	public bool IsHumanReadable => data[0] == 128;

	public NotationData(bool critical, bool isLongLength, byte[] data)
		: base(SignatureSubpacketTag.NotationData, critical, isLongLength, data)
	{
	}

	public NotationData(bool critical, bool humanReadable, string notationName, string notationValue)
		: base(SignatureSubpacketTag.NotationData, critical, isLongLength: false, CreateData(humanReadable, notationName, notationValue))
	{
	}

	private static byte[] CreateData(bool humanReadable, string notationName, string notationValue)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte((byte)(humanReadable ? 128 : 0));
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		byte[] valueData = null;
		byte[] nameData = Encoding.UTF8.GetBytes(notationName);
		int nameLength = System.Math.Min(nameData.Length, 255);
		valueData = Encoding.UTF8.GetBytes(notationValue);
		int valueLength = System.Math.Min(valueData.Length, 255);
		memoryStream.WriteByte((byte)(nameLength >> 8));
		memoryStream.WriteByte((byte)nameLength);
		memoryStream.WriteByte((byte)(valueLength >> 8));
		memoryStream.WriteByte((byte)valueLength);
		memoryStream.Write(nameData, 0, nameLength);
		memoryStream.Write(valueData, 0, valueLength);
		return memoryStream.ToArray();
	}

	public string GetNotationName()
	{
		int nameLength = (data[4] << 8) + data[5];
		int namePos = 8;
		return Encoding.UTF8.GetString(data, namePos, nameLength);
	}

	public string GetNotationValue()
	{
		int nameLength = (data[4] << 8) + data[5];
		int valueLength = (data[6] << 8) + data[7];
		int valuePos = 8 + nameLength;
		return Encoding.UTF8.GetString(data, valuePos, valueLength);
	}

	public byte[] GetNotationValueBytes()
	{
		int nameLength = (data[4] << 8) + data[5];
		int valueLength = (data[6] << 8) + data[7];
		int valuePos = 8 + nameLength;
		byte[] bytes = new byte[valueLength];
		Array.Copy(data, valuePos, bytes, 0, valueLength);
		return bytes;
	}
}
