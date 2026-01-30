using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms;

public class AttributeTable
{
	private readonly IDictionary attributes;

	public Attribute this[DerObjectIdentifier oid]
	{
		get
		{
			object obj = attributes[oid];
			if (obj is IList)
			{
				return (Attribute)((IList)obj)[0];
			}
			return (Attribute)obj;
		}
	}

	public int Count
	{
		get
		{
			int total = 0;
			foreach (object o in attributes.Values)
			{
				total = ((!(o is IList)) ? (total + 1) : (total + ((IList)o).Count));
			}
			return total;
		}
	}

	[Obsolete]
	public AttributeTable(Hashtable attrs)
	{
		attributes = Platform.CreateHashtable(attrs);
	}

	public AttributeTable(IDictionary attrs)
	{
		attributes = Platform.CreateHashtable(attrs);
	}

	public AttributeTable(Asn1EncodableVector v)
	{
		attributes = Platform.CreateHashtable(v.Count);
		foreach (Asn1Encodable item in v)
		{
			Attribute a = Attribute.GetInstance(item);
			AddAttribute(a);
		}
	}

	public AttributeTable(Asn1Set s)
	{
		attributes = Platform.CreateHashtable(s.Count);
		for (int i = 0; i != s.Count; i++)
		{
			Attribute a = Attribute.GetInstance(s[i]);
			AddAttribute(a);
		}
	}

	public AttributeTable(Attributes attrs)
		: this(Asn1Set.GetInstance(attrs.ToAsn1Object()))
	{
	}

	private void AddAttribute(Attribute a)
	{
		DerObjectIdentifier oid = a.AttrType;
		object obj = attributes[oid];
		if (obj == null)
		{
			attributes[oid] = a;
			return;
		}
		IList v;
		if (obj is Attribute)
		{
			v = Platform.CreateArrayList();
			v.Add(obj);
			v.Add(a);
		}
		else
		{
			v = (IList)obj;
			v.Add(a);
		}
		attributes[oid] = v;
	}

	[Obsolete("Use 'object[oid]' syntax instead")]
	public Attribute Get(DerObjectIdentifier oid)
	{
		return this[oid];
	}

	public Asn1EncodableVector GetAll(DerObjectIdentifier oid)
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		object obj = attributes[oid];
		if (obj is IList)
		{
			foreach (Attribute a in (IList)obj)
			{
				v.Add(a);
			}
		}
		else if (obj != null)
		{
			v.Add((Attribute)obj);
		}
		return v;
	}

	public IDictionary ToDictionary()
	{
		return Platform.CreateHashtable(attributes);
	}

	[Obsolete("Use 'ToDictionary' instead")]
	public Hashtable ToHashtable()
	{
		return new Hashtable(attributes);
	}

	public Asn1EncodableVector ToAsn1EncodableVector()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		foreach (object obj in attributes.Values)
		{
			if (obj is IList)
			{
				foreach (object el in (IList)obj)
				{
					v.Add(Attribute.GetInstance(el));
				}
			}
			else
			{
				v.Add(Attribute.GetInstance(obj));
			}
		}
		return v;
	}

	public Attributes ToAttributes()
	{
		return new Attributes(ToAsn1EncodableVector());
	}

	public AttributeTable Add(DerObjectIdentifier attrType, Asn1Encodable attrValue)
	{
		AttributeTable attributeTable = new AttributeTable(attributes);
		attributeTable.AddAttribute(new Attribute(attrType, new DerSet(attrValue)));
		return attributeTable;
	}

	public AttributeTable Remove(DerObjectIdentifier attrType)
	{
		AttributeTable attributeTable = new AttributeTable(attributes);
		attributeTable.attributes.Remove(attrType);
		return attributeTable;
	}
}
