using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerUtf8String : DerStringBase
{
	private readonly string str;

	public static DerUtf8String GetInstance(object obj)
	{
		if (obj == null || obj is DerUtf8String)
		{
			return (DerUtf8String)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerUtf8String GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerUtf8String)
		{
			return GetInstance(o);
		}
		return new DerUtf8String(Asn1OctetString.GetInstance(o).GetOctets());
	}

	public DerUtf8String(byte[] str)
		: this(Encoding.UTF8.GetString(str, 0, str.Length))
	{
	}

	public DerUtf8String(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		this.str = str;
	}

	public override string GetString()
	{
		return str;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerUtf8String other))
		{
			return false;
		}
		return str.Equals(other.str);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, Encoding.UTF8.GetByteCount(str));
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 12, Encoding.UTF8.GetBytes(str));
	}
}
