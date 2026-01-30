using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerVideotexString : DerStringBase
{
	private readonly byte[] mString;

	public static DerVideotexString GetInstance(object obj)
	{
		if (obj == null || obj is DerVideotexString)
		{
			return (DerVideotexString)obj;
		}
		if (obj is byte[])
		{
			try
			{
				return (DerVideotexString)Asn1Object.FromByteArray((byte[])obj);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("encoding error in GetInstance: " + ex.ToString(), "obj");
			}
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public static DerVideotexString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerVideotexString)
		{
			return GetInstance(o);
		}
		return new DerVideotexString(((Asn1OctetString)o).GetOctets());
	}

	public DerVideotexString(byte[] encoding)
	{
		mString = Arrays.Clone(encoding);
	}

	public override string GetString()
	{
		return Strings.FromByteArray(mString);
	}

	public byte[] GetOctets()
	{
		return Arrays.Clone(mString);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, mString.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 21, mString);
	}

	protected override int Asn1GetHashCode()
	{
		return Arrays.GetHashCode(mString);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerVideotexString other))
		{
			return false;
		}
		return Arrays.AreEqual(mString, other.mString);
	}
}
