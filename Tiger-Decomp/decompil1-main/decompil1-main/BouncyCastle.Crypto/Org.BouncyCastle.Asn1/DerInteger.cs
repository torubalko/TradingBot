using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerInteger : Asn1Object
{
	public const string AllowUnsafeProperty = "Org.BouncyCastle.Asn1.AllowUnsafeInteger";

	internal const int SignExtSigned = -1;

	internal const int SignExtUnsigned = 255;

	private readonly byte[] bytes;

	private readonly int start;

	public BigInteger PositiveValue => new BigInteger(1, bytes);

	public BigInteger Value => new BigInteger(bytes);

	public int IntPositiveValueExact
	{
		get
		{
			int count = bytes.Length - start;
			if (count > 4 || (count == 4 && (bytes[start] & 0x80) != 0))
			{
				throw new ArithmeticException("ASN.1 Integer out of positive int range");
			}
			return IntValue(bytes, start, 255);
		}
	}

	public int IntValueExact
	{
		get
		{
			if (bytes.Length - start > 4)
			{
				throw new ArithmeticException("ASN.1 Integer out of int range");
			}
			return IntValue(bytes, start, -1);
		}
	}

	public long LongValueExact
	{
		get
		{
			if (bytes.Length - start > 8)
			{
				throw new ArithmeticException("ASN.1 Integer out of long range");
			}
			return LongValue(bytes, start, -1);
		}
	}

	internal static bool AllowUnsafe()
	{
		string allowUnsafeValue = Platform.GetEnvironmentVariable("Org.BouncyCastle.Asn1.AllowUnsafeInteger");
		if (allowUnsafeValue != null)
		{
			return Platform.EqualsIgnoreCase("true", allowUnsafeValue);
		}
		return false;
	}

	public static DerInteger GetInstance(object obj)
	{
		if (obj == null || obj is DerInteger)
		{
			return (DerInteger)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerInteger GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerInteger)
		{
			return GetInstance(o);
		}
		return new DerInteger(Asn1OctetString.GetInstance(o).GetOctets());
	}

	public DerInteger(int value)
	{
		bytes = BigInteger.ValueOf(value).ToByteArray();
		start = 0;
	}

	public DerInteger(long value)
	{
		bytes = BigInteger.ValueOf(value).ToByteArray();
		start = 0;
	}

	public DerInteger(BigInteger value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		bytes = value.ToByteArray();
		start = 0;
	}

	public DerInteger(byte[] bytes)
		: this(bytes, clone: true)
	{
	}

	internal DerInteger(byte[] bytes, bool clone)
	{
		if (IsMalformed(bytes))
		{
			throw new ArgumentException("malformed integer", "bytes");
		}
		this.bytes = (clone ? Arrays.Clone(bytes) : bytes);
		start = SignBytesToSkip(bytes);
	}

	public bool HasValue(int x)
	{
		if (bytes.Length - start <= 4)
		{
			return IntValue(bytes, start, -1) == x;
		}
		return false;
	}

	public bool HasValue(long x)
	{
		if (bytes.Length - start <= 8)
		{
			return LongValue(bytes, start, -1) == x;
		}
		return false;
	}

	public bool HasValue(BigInteger x)
	{
		if (x != null && IntValue(bytes, start, -1) == x.IntValue)
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
		asn1Out.WriteEncodingDL(withID, 2, bytes);
	}

	protected override int Asn1GetHashCode()
	{
		return Arrays.GetHashCode(bytes);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerInteger other))
		{
			return false;
		}
		return Arrays.AreEqual(bytes, other.bytes);
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	internal static int IntValue(byte[] bytes, int start, int signExt)
	{
		int length = bytes.Length;
		int pos = System.Math.Max(start, length - 4);
		int val = (sbyte)bytes[pos] & signExt;
		while (++pos < length)
		{
			val = (val << 8) | bytes[pos];
		}
		return val;
	}

	internal static long LongValue(byte[] bytes, int start, int signExt)
	{
		int length = bytes.Length;
		int pos = System.Math.Max(start, length - 8);
		long val = (sbyte)bytes[pos] & signExt;
		while (++pos < length)
		{
			val = (val << 8) | bytes[pos];
		}
		return val;
	}

	internal static bool IsMalformed(byte[] bytes)
	{
		switch (bytes.Length)
		{
		case 0:
			return true;
		case 1:
			return false;
		default:
			if ((sbyte)bytes[0] == (sbyte)bytes[1] >> 7)
			{
				return !AllowUnsafe();
			}
			return false;
		}
	}

	internal static int SignBytesToSkip(byte[] bytes)
	{
		int pos = 0;
		for (int last = bytes.Length - 1; pos < last && (sbyte)bytes[pos] == (sbyte)bytes[pos + 1] >> 7; pos++)
		{
		}
		return pos;
	}
}
