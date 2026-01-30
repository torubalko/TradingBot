using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerT61String : DerStringBase
{
	private readonly string str;

	public static DerT61String GetInstance(object obj)
	{
		if (obj == null || obj is DerT61String)
		{
			return (DerT61String)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerT61String GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerT61String)
		{
			return GetInstance(o);
		}
		return new DerT61String(Asn1OctetString.GetInstance(o).GetOctets());
	}

	public DerT61String(byte[] str)
		: this(Strings.FromByteArray(str))
	{
	}

	public DerT61String(string str)
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

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, str.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 20, GetOctets());
	}

	public byte[] GetOctets()
	{
		return Strings.ToByteArray(str);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerT61String other))
		{
			return false;
		}
		return str.Equals(other.str);
	}
}
