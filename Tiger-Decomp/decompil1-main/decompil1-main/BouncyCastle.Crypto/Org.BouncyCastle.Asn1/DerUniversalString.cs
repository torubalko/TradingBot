using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerUniversalString : DerStringBase
{
	private static readonly char[] table = new char[16]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F'
	};

	private readonly byte[] str;

	public static DerUniversalString GetInstance(object obj)
	{
		if (obj == null || obj is DerUniversalString)
		{
			return (DerUniversalString)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerUniversalString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerUniversalString)
		{
			return GetInstance(o);
		}
		return new DerUniversalString(Asn1OctetString.GetInstance(o).GetOctets());
	}

	public DerUniversalString(byte[] str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		this.str = str;
	}

	public override string GetString()
	{
		StringBuilder buffer = new StringBuilder("#");
		byte[] enc = GetDerEncoded();
		for (int i = 0; i != enc.Length; i++)
		{
			uint ubyte = enc[i];
			buffer.Append(table[(ubyte >> 4) & 0xF]);
			buffer.Append(table[enc[i] & 0xF]);
		}
		return buffer.ToString();
	}

	public byte[] GetOctets()
	{
		return (byte[])str.Clone();
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, str.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 28, str);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerUniversalString other))
		{
			return false;
		}
		return Arrays.AreEqual(str, other.str);
	}
}
