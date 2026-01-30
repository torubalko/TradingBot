using System;
using System.Text;

namespace Org.BouncyCastle.Asn1.X509;

public class RoleSyntax : Asn1Encodable
{
	private readonly GeneralNames roleAuthority;

	private readonly GeneralName roleName;

	public GeneralNames RoleAuthority => roleAuthority;

	public GeneralName RoleName => roleName;

	public static RoleSyntax GetInstance(object obj)
	{
		if (obj is RoleSyntax)
		{
			return (RoleSyntax)obj;
		}
		if (obj != null)
		{
			return new RoleSyntax(Asn1Sequence.GetInstance(obj));
		}
		return null;
	}

	public RoleSyntax(GeneralNames roleAuthority, GeneralName roleName)
	{
		if (roleName == null || roleName.TagNo != 6 || ((IAsn1String)roleName.Name).GetString().Equals(""))
		{
			throw new ArgumentException("the role name MUST be non empty and MUST use the URI option of GeneralName");
		}
		this.roleAuthority = roleAuthority;
		this.roleName = roleName;
	}

	public RoleSyntax(GeneralName roleName)
		: this(null, roleName)
	{
	}

	public RoleSyntax(string roleName)
		: this(new GeneralName(6, (roleName == null) ? "" : roleName))
	{
	}

	private RoleSyntax(Asn1Sequence seq)
	{
		if (seq.Count < 1 || seq.Count > 2)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		for (int i = 0; i != seq.Count; i++)
		{
			Asn1TaggedObject taggedObject = Asn1TaggedObject.GetInstance(seq[i]);
			switch (taggedObject.TagNo)
			{
			case 0:
				roleAuthority = GeneralNames.GetInstance(taggedObject, explicitly: false);
				break;
			case 1:
				roleName = GeneralName.GetInstance(taggedObject, explicitly: true);
				break;
			default:
				throw new ArgumentException("Unknown tag in RoleSyntax");
			}
		}
	}

	public string GetRoleNameAsString()
	{
		return ((IAsn1String)roleName.Name).GetString();
	}

	public string[] GetRoleAuthorityAsString()
	{
		if (roleAuthority == null)
		{
			return new string[0];
		}
		GeneralName[] names = roleAuthority.GetNames();
		string[] namesString = new string[names.Length];
		for (int i = 0; i < names.Length; i++)
		{
			Asn1Encodable asn1Value = names[i].Name;
			if (asn1Value is IAsn1String)
			{
				namesString[i] = ((IAsn1String)asn1Value).GetString();
			}
			else
			{
				namesString[i] = asn1Value.ToString();
			}
		}
		return namesString;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		asn1EncodableVector.AddOptionalTagged(isExplicit: false, 0, roleAuthority);
		asn1EncodableVector.Add(new DerTaggedObject(explicitly: true, 1, roleName));
		return new DerSequence(asn1EncodableVector);
	}

	public override string ToString()
	{
		StringBuilder buff = new StringBuilder("Name: " + GetRoleNameAsString() + " - Auth: ");
		if (roleAuthority == null || roleAuthority.GetNames().Length == 0)
		{
			buff.Append("N/A");
		}
		else
		{
			string[] names = GetRoleAuthorityAsString();
			buff.Append('[').Append(names[0]);
			for (int i = 1; i < names.Length; i++)
			{
				buff.Append(", ").Append(names[i]);
			}
			buff.Append(']');
		}
		return buff.ToString();
	}
}
