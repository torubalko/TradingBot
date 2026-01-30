using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerNumericString : DerStringBase
{
	private readonly string str;

	public static DerNumericString GetInstance(object obj)
	{
		if (obj == null || obj is DerNumericString)
		{
			return (DerNumericString)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerNumericString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerNumericString)
		{
			return GetInstance(o);
		}
		return new DerNumericString(Asn1OctetString.GetInstance(o).GetOctets());
	}

	public DerNumericString(byte[] str)
		: this(Strings.FromAsciiByteArray(str), validate: false)
	{
	}

	public DerNumericString(string str)
		: this(str, validate: false)
	{
	}

	public DerNumericString(string str, bool validate)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (validate && !IsNumericString(str))
		{
			throw new ArgumentException("string contains illegal characters", "str");
		}
		this.str = str;
	}

	public override string GetString()
	{
		return str;
	}

	public byte[] GetOctets()
	{
		return Strings.ToAsciiByteArray(str);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, str.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 18, GetOctets());
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerNumericString other))
		{
			return false;
		}
		return str.Equals(other.str);
	}

	public static bool IsNumericString(string str)
	{
		foreach (char ch in str)
		{
			if (ch > '\u007f' || (ch != ' ' && !char.IsDigit(ch)))
			{
				return false;
			}
		}
		return true;
	}
}
