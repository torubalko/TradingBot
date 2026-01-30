using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerBoolean : Asn1Object
{
	private readonly byte value;

	public static readonly DerBoolean False = new DerBoolean(value: false);

	public static readonly DerBoolean True = new DerBoolean(value: true);

	public bool IsTrue => value != 0;

	public static DerBoolean GetInstance(object obj)
	{
		if (obj == null || obj is DerBoolean)
		{
			return (DerBoolean)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerBoolean GetInstance(bool value)
	{
		if (!value)
		{
			return False;
		}
		return True;
	}

	public static DerBoolean GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerBoolean)
		{
			return GetInstance(o);
		}
		return FromOctetString(((Asn1OctetString)o).GetOctets());
	}

	public DerBoolean(byte[] val)
	{
		if (val.Length != 1)
		{
			throw new ArgumentException("byte value should have 1 byte in it", "val");
		}
		value = val[0];
	}

	private DerBoolean(bool value)
	{
		this.value = (byte)(value ? byte.MaxValue : 0);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, 1);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 1, value);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerBoolean other))
		{
			return false;
		}
		return IsTrue == other.IsTrue;
	}

	protected override int Asn1GetHashCode()
	{
		return IsTrue.GetHashCode();
	}

	public override string ToString()
	{
		if (!IsTrue)
		{
			return "FALSE";
		}
		return "TRUE";
	}

	internal static DerBoolean FromOctetString(byte[] value)
	{
		if (value.Length != 1)
		{
			throw new ArgumentException("BOOLEAN value should have 1 byte in it", "value");
		}
		return value[0] switch
		{
			byte.MaxValue => True, 
			0 => False, 
			_ => new DerBoolean(value), 
		};
	}
}
