using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509;

public class NamingAuthority : Asn1Encodable
{
	public static readonly DerObjectIdentifier IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern = new DerObjectIdentifier(IsisMttObjectIdentifiers.IdIsisMttATNamingAuthorities?.ToString() + ".1");

	private readonly DerObjectIdentifier namingAuthorityID;

	private readonly string namingAuthorityUrl;

	private readonly DirectoryString namingAuthorityText;

	public virtual DerObjectIdentifier NamingAuthorityID => namingAuthorityID;

	public virtual DirectoryString NamingAuthorityText => namingAuthorityText;

	public virtual string NamingAuthorityUrl => namingAuthorityUrl;

	public static NamingAuthority GetInstance(object obj)
	{
		if (obj == null || obj is NamingAuthority)
		{
			return (NamingAuthority)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new NamingAuthority((Asn1Sequence)obj);
		}
		throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	public static NamingAuthority GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, isExplicit));
	}

	private NamingAuthority(Asn1Sequence seq)
	{
		if (seq.Count > 3)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		IEnumerator e = seq.GetEnumerator();
		if (e.MoveNext())
		{
			Asn1Encodable o = (Asn1Encodable)e.Current;
			if (o is DerObjectIdentifier)
			{
				namingAuthorityID = (DerObjectIdentifier)o;
			}
			else if (o is DerIA5String)
			{
				namingAuthorityUrl = DerIA5String.GetInstance(o).GetString();
			}
			else
			{
				if (!(o is IAsn1String))
				{
					throw new ArgumentException("Bad object encountered: " + Platform.GetTypeName(o));
				}
				namingAuthorityText = DirectoryString.GetInstance(o);
			}
		}
		if (e.MoveNext())
		{
			Asn1Encodable o2 = (Asn1Encodable)e.Current;
			if (o2 is DerIA5String)
			{
				namingAuthorityUrl = DerIA5String.GetInstance(o2).GetString();
			}
			else
			{
				if (!(o2 is IAsn1String))
				{
					throw new ArgumentException("Bad object encountered: " + Platform.GetTypeName(o2));
				}
				namingAuthorityText = DirectoryString.GetInstance(o2);
			}
		}
		if (e.MoveNext())
		{
			Asn1Encodable o3 = (Asn1Encodable)e.Current;
			if (!(o3 is IAsn1String))
			{
				throw new ArgumentException("Bad object encountered: " + Platform.GetTypeName(o3));
			}
			namingAuthorityText = DirectoryString.GetInstance(o3);
		}
	}

	public NamingAuthority(DerObjectIdentifier namingAuthorityID, string namingAuthorityUrl, DirectoryString namingAuthorityText)
	{
		this.namingAuthorityID = namingAuthorityID;
		this.namingAuthorityUrl = namingAuthorityUrl;
		this.namingAuthorityText = namingAuthorityText;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		v.AddOptional(namingAuthorityID);
		if (namingAuthorityUrl != null)
		{
			v.Add(new DerIA5String(namingAuthorityUrl, validate: true));
		}
		v.AddOptional(namingAuthorityText);
		return new DerSequence(v);
	}
}
