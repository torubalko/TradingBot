using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerBmpString : DerStringBase
{
	private readonly string str;

	public static DerBmpString GetInstance(object obj)
	{
		if (obj == null || obj is DerBmpString)
		{
			return (DerBmpString)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerBmpString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerBmpString)
		{
			return GetInstance(o);
		}
		return new DerBmpString(Asn1OctetString.GetInstance(o).GetOctets());
	}

	[Obsolete("Will become internal")]
	public DerBmpString(byte[] str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		int byteLen = str.Length;
		if ((byteLen & 1) != 0)
		{
			throw new ArgumentException("malformed BMPString encoding encountered", "str");
		}
		int charLen = byteLen / 2;
		char[] cs = new char[charLen];
		for (int i = 0; i != charLen; i++)
		{
			cs[i] = (char)((str[2 * i] << 8) | (str[2 * i + 1] & 0xFF));
		}
		this.str = new string(cs);
	}

	internal DerBmpString(char[] str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		this.str = new string(str);
	}

	public DerBmpString(string str)
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
		if (!(asn1Object is DerBmpString other))
		{
			return false;
		}
		return str.Equals(other.str);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, str.Length * 2);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		char[] c = str.ToCharArray();
		byte[] b = new byte[c.Length * 2];
		for (int i = 0; i != c.Length; i++)
		{
			b[2 * i] = (byte)((int)c[i] >> 8);
			b[2 * i + 1] = (byte)c[i];
		}
		asn1Out.WriteEncodingDL(withID, 30, b);
	}
}
