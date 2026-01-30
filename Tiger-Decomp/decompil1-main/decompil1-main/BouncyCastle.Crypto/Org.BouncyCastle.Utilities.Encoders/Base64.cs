using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders;

public sealed class Base64
{
	private Base64()
	{
	}

	public static string ToBase64String(byte[] data)
	{
		return Convert.ToBase64String(data, 0, data.Length);
	}

	public static string ToBase64String(byte[] data, int off, int length)
	{
		return Convert.ToBase64String(data, off, length);
	}

	public static byte[] Encode(byte[] data)
	{
		return Encode(data, 0, data.Length);
	}

	public static byte[] Encode(byte[] data, int off, int length)
	{
		return Strings.ToAsciiByteArray(Convert.ToBase64String(data, off, length));
	}

	public static int Encode(byte[] data, Stream outStream)
	{
		byte[] encoded = Encode(data);
		outStream.Write(encoded, 0, encoded.Length);
		return encoded.Length;
	}

	public static int Encode(byte[] data, int off, int length, Stream outStream)
	{
		byte[] encoded = Encode(data, off, length);
		outStream.Write(encoded, 0, encoded.Length);
		return encoded.Length;
	}

	public static byte[] Decode(byte[] data)
	{
		return Convert.FromBase64String(Strings.FromAsciiByteArray(data));
	}

	public static byte[] Decode(string data)
	{
		return Convert.FromBase64String(data);
	}

	public static int Decode(string data, Stream outStream)
	{
		byte[] decoded = Decode(data);
		outStream.Write(decoded, 0, decoded.Length);
		return decoded.Length;
	}
}
