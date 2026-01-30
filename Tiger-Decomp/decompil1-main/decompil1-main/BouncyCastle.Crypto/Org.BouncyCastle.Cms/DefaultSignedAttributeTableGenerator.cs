using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms;

public class DefaultSignedAttributeTableGenerator : CmsAttributeTableGenerator
{
	private readonly IDictionary table;

	public DefaultSignedAttributeTableGenerator()
	{
		table = Platform.CreateHashtable();
	}

	public DefaultSignedAttributeTableGenerator(AttributeTable attributeTable)
	{
		if (attributeTable != null)
		{
			table = attributeTable.ToDictionary();
		}
		else
		{
			table = Platform.CreateHashtable();
		}
	}

	protected virtual Hashtable createStandardAttributeTable(IDictionary parameters)
	{
		Hashtable std = new Hashtable(table);
		DoCreateStandardAttributeTable(parameters, std);
		return std;
	}

	private void DoCreateStandardAttributeTable(IDictionary parameters, IDictionary std)
	{
		if (parameters.Contains(CmsAttributeTableParameter.ContentType) && !std.Contains(CmsAttributes.ContentType))
		{
			DerObjectIdentifier contentType = (DerObjectIdentifier)parameters[CmsAttributeTableParameter.ContentType];
			Org.BouncyCastle.Asn1.Cms.Attribute attr = new Org.BouncyCastle.Asn1.Cms.Attribute(CmsAttributes.ContentType, new DerSet(contentType));
			std[attr.AttrType] = attr;
		}
		if (!std.Contains(CmsAttributes.SigningTime))
		{
			Org.BouncyCastle.Asn1.Cms.Attribute attr2 = new Org.BouncyCastle.Asn1.Cms.Attribute(CmsAttributes.SigningTime, new DerSet(new Time(DateTime.UtcNow)));
			std[attr2.AttrType] = attr2;
		}
		if (!std.Contains(CmsAttributes.MessageDigest))
		{
			byte[] messageDigest = (byte[])parameters[CmsAttributeTableParameter.Digest];
			Org.BouncyCastle.Asn1.Cms.Attribute attr3 = new Org.BouncyCastle.Asn1.Cms.Attribute(CmsAttributes.MessageDigest, new DerSet(new DerOctetString(messageDigest)));
			std[attr3.AttrType] = attr3;
		}
	}

	public virtual AttributeTable GetAttributes(IDictionary parameters)
	{
		return new AttributeTable((IDictionary)createStandardAttributeTable(parameters));
	}
}
