using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerEnumerated : Asn1Object
{
	private readonly byte[] bytes;

	private readonly int start;

	private static readonly DerEnumerated[] cache = new DerEnumerated[12];

	public BigInteger Value => new BigInteger(bytes);

	public int IntValueExact
	{
		get
		{
			if (bytes.Length - start > 4)
			{
				throw new ArithmeticException("ASN.1 Enumerated out of int range");
			}
			return DerInteger.IntValue(bytes, start, -1);
		}
	}

	public static DerEnumerated GetInstance(object obj)
	{
		if (obj == null || obj is DerEnumerated)
		{
			return (DerEnumerated)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerEnumerated GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerEnumerated)
		{
			return GetInstance(o);
		}
		return FromOctetString(((Asn1OctetString)o).GetOctets());
	}

	public DerEnumerated(int val)
	{
		if (val < 0)
		{
			throw new ArgumentException("enumerated must be non-negative", "val");
		}
		bytes = BigInteger.ValueOf(val).ToByteArray();
		start = 0;
	}

	public DerEnumerated(long val)
	{
		if (val < 0)
		{
			throw new ArgumentException("enumerated must be non-negative", "val");
		}
		bytes = BigInteger.ValueOf(val).ToByteArray();
		start = 0;
	}

	public DerEnumerated(BigInteger val)
	{
		if (val.SignValue < 0)
		{
			throw new ArgumentException("enumerated must be non-negative", "val");
		}
		bytes = val.ToByteArray();
		start = 0;
	}

	public DerEnumerated(byte[] bytes)
	{
		if (DerInteger.IsMalformed(bytes))
		{
			throw new ArgumentException("malformed enumerated", "bytes");
		}
		if ((bytes[0] & 0x80) != 0)
		{
			throw new ArgumentException("enumerated must be non-negative", "bytes");
		}
		this.bytes = Arrays.Clone(bytes);
		start = DerInteger.SignBytesToSkip(bytes);
	}

	public bool HasValue(int x)
	{
		if (bytes.Length - start <= 4)
		{
			return DerInteger.IntValue(bytes, start, -1) == x;
		}
		return false;
	}

	public bool HasValue(BigInteger x)
	{
		if (x != null && DerInteger.IntValue(bytes, start, -1) == x.IntValue)
		{
			return Value.Equals(x);
		}
		return false;
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, bytes.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 10, bytes);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerEnumerated other))
		{
			return false;
		}
		return Arrays.AreEqual(bytes, other.bytes);
	}

	protected override int Asn1GetHashCode()
	{
		return Arrays.GetHashCode(bytes);
	}

	internal static DerEnumerated FromOctetString(byte[] enc)
	{
		if (enc.Length > 1)
		{
			return new DerEnumerated(enc);
		}
		if (enc.Length == 0)
		{
			throw new ArgumentException("ENUMERATED has zero length", "enc");
		}
		int value = enc[0];
		if (value >= cache.Length)
		{
			return new DerEnumerated(enc);
		}
		DerEnumerated possibleMatch = cache[value];
		if (possibleMatch == null)
		{
			possibleMatch = (cache[value] = new DerEnumerated(enc));
		}
		return possibleMatch;
	}
}
