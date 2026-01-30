using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms;

public class DefaultAuthenticatedAttributeTableGenerator : CmsAttributeTableGenerator
{
	private readonly IDictionary table;

	public DefaultAuthenticatedAttributeTableGenerator()
	{
		table = Platform.CreateHashtable();
	}

	public DefaultAuthenticatedAttributeTableGenerator(AttributeTable attributeTable)
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

	protected virtual IDictionary CreateStandardAttributeTable(IDictionary parameters)
	{
		IDictionary std = Platform.CreateHashtable(table);
		if (!std.Contains(CmsAttributes.ContentType))
		{
			DerObjectIdentifier contentType = (DerObjectIdentifier)parameters[CmsAttributeTableParameter.ContentType];
			Attribute attr = new Attribute(CmsAttributes.ContentType, new DerSet(contentType));
			std[attr.AttrType] = attr;
		}
		if (!std.Contains(CmsAttributes.MessageDigest))
		{
			byte[] messageDigest = (byte[])parameters[CmsAttributeTableParameter.Digest];
			Attribute attr2 = new Attribute(CmsAttributes.MessageDigest, new DerSet(new DerOctetString(messageDigest)));
			std[attr2.AttrType] = attr2;
		}
		return std;
	}

	public virtual AttributeTable GetAttributes(IDictionary parameters)
	{
		return new AttributeTable(CreateStandardAttributeTable(parameters));
	}
}
