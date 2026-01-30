using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerIA5String : DerStringBase
{
	private readonly string str;

	public static DerIA5String GetInstance(object obj)
	{
		if (obj == null || obj is DerIA5String)
		{
			return (DerIA5String)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerIA5String GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerIA5String)
		{
			return GetInstance(o);
		}
		return new DerIA5String(((Asn1OctetString)o).GetOctets());
	}

	public DerIA5String(byte[] str)
		: this(Strings.FromAsciiByteArray(str), validate: false)
	{
	}

	public DerIA5String(string str)
		: this(str, validate: false)
	{
	}

	public DerIA5String(string str, bool validate)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (validate && !IsIA5String(str))
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
		asn1Out.WriteEncodingDL(withID, 22, GetOctets());
	}

	protected override int Asn1GetHashCode()
	{
		return str.GetHashCode();
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerIA5String other))
		{
			return false;
		}
		return str.Equals(other.str);
	}

	public static bool IsIA5String(string str)
	{
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] > '\u007f')
			{
				return false;
			}
		}
		return true;
	}
}
