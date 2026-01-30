using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9;

public abstract class X9IntegerConverter
{
	public static int GetByteLength(ECFieldElement fe)
	{
		return (fe.FieldSize + 7) / 8;
	}

	public static int GetByteLength(ECCurve c)
	{
		return (c.FieldSize + 7) / 8;
	}

	public static byte[] IntegerToBytes(BigInteger s, int qLength)
	{
		byte[] bytes = s.ToByteArrayUnsigned();
		if (qLength < bytes.Length)
		{
			byte[] tmp = new byte[qLength];
			Array.Copy(bytes, bytes.Length - tmp.Length, tmp, 0, tmp.Length);
			return tmp;
		}
		if (qLength > bytes.Length)
		{
			byte[] tmp2 = new byte[qLength];
			Array.Copy(bytes, 0, tmp2, tmp2.Length - bytes.Length, bytes.Length);
			return tmp2;
		}
		return bytes;
	}
}
