using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public abstract class Asn1TaggedObject : Asn1Object, Asn1TaggedObjectParser, IAsn1Convertible
{
	internal int tagNo;

	internal bool explicitly = true;

	internal Asn1Encodable obj;

	public int TagNo => tagNo;

	internal static bool IsConstructed(bool isExplicit, Asn1Object obj)
	{
		if (isExplicit || obj is Asn1Sequence || obj is Asn1Set)
		{
			return true;
		}
		if (!(obj is Asn1TaggedObject tagged))
		{
			return false;
		}
		return IsConstructed(tagged.IsExplicit(), tagged.GetObject());
	}

	public static Asn1TaggedObject GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		if (explicitly)
		{
			return GetInstance(obj.GetObject());
		}
		throw new ArgumentException("implicitly tagged tagged object");
	}

	public static Asn1TaggedObject GetInstance(object obj)
	{
		if (obj == null || obj is Asn1TaggedObject)
		{
			return (Asn1TaggedObject)obj;
		}
		throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	protected Asn1TaggedObject(int tagNo, Asn1Encodable obj)
	{
		explicitly = true;
		this.tagNo = tagNo;
		this.obj = obj;
	}

	protected Asn1TaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
	{
		this.explicitly = explicitly || obj is IAsn1Choice;
		this.tagNo = tagNo;
		this.obj = obj;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is Asn1TaggedObject other))
		{
			return false;
		}
		if (tagNo == other.tagNo && explicitly == other.explicitly)
		{
			return object.Equals(GetObject(), other.GetObject());
		}
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		int code = tagNo.GetHashCode();
		if (obj != null)
		{
			code ^= obj.GetHashCode();
		}
		return code;
	}

	public bool IsExplicit()
	{
		return explicitly;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public Asn1Object GetObject()
	{
		if (obj != null)
		{
			return obj.ToAsn1Object();
		}
		return null;
	}

	public IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
	{
		switch (tag)
		{
		case 17:
			return Asn1Set.GetInstance(this, isExplicit).Parser;
		case 16:
			return Asn1Sequence.GetInstance(this, isExplicit).Parser;
		case 4:
			return Asn1OctetString.GetInstance(this, isExplicit).Parser;
		default:
			if (isExplicit)
			{
				return GetObject();
			}
			throw Platform.CreateNotImplementedException("implicit tagging for tag: " + tag);
		}
	}

	public override string ToString()
	{
		return "[" + tagNo + "]" + obj;
	}
}
