using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.X509;

public class AttributeCertificateHolder : IX509Selector, ICloneable
{
	internal readonly Holder holder;

	public int DigestedObjectType => holder.ObjectDigestInfo?.DigestedObjectType.IntValueExact ?? (-1);

	public string DigestAlgorithm => holder.ObjectDigestInfo?.DigestAlgorithm.Algorithm.Id;

	public string OtherObjectTypeID => holder.ObjectDigestInfo?.OtherObjectTypeID.Id;

	public BigInteger SerialNumber
	{
		get
		{
			if (holder.BaseCertificateID != null)
			{
				return holder.BaseCertificateID.Serial.Value;
			}
			return null;
		}
	}

	internal AttributeCertificateHolder(Asn1Sequence seq)
	{
		holder = Holder.GetInstance(seq);
	}

	public AttributeCertificateHolder(X509Name issuerName, BigInteger serialNumber)
	{
		holder = new Holder(new IssuerSerial(GenerateGeneralNames(issuerName), new DerInteger(serialNumber)));
	}

	public AttributeCertificateHolder(X509Certificate cert)
	{
		X509Name name;
		try
		{
			name = PrincipalUtilities.GetIssuerX509Principal(cert);
		}
		catch (Exception ex)
		{
			throw new CertificateParsingException(ex.Message);
		}
		holder = new Holder(new IssuerSerial(GenerateGeneralNames(name), new DerInteger(cert.SerialNumber)));
	}

	public AttributeCertificateHolder(X509Name principal)
	{
		holder = new Holder(GenerateGeneralNames(principal));
	}

	public AttributeCertificateHolder(int digestedObjectType, string digestAlgorithm, string otherObjectTypeID, byte[] objectDigest)
	{
		holder = new Holder(new ObjectDigestInfo(digestedObjectType, otherObjectTypeID, new AlgorithmIdentifier(new DerObjectIdentifier(digestAlgorithm)), Arrays.Clone(objectDigest)));
	}

	public byte[] GetObjectDigest()
	{
		return holder.ObjectDigestInfo?.ObjectDigest.GetBytes();
	}

	private GeneralNames GenerateGeneralNames(X509Name principal)
	{
		return new GeneralNames(new GeneralName(principal));
	}

	private bool MatchesDN(X509Name subject, GeneralNames targets)
	{
		GeneralName[] names = targets.GetNames();
		for (int i = 0; i != names.Length; i++)
		{
			GeneralName gn = names[i];
			if (gn.TagNo != 4)
			{
				continue;
			}
			try
			{
				if (X509Name.GetInstance(gn.Name).Equivalent(subject))
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	private object[] GetNames(GeneralName[] names)
	{
		int count = 0;
		for (int i = 0; i != names.Length; i++)
		{
			if (names[i].TagNo == 4)
			{
				count++;
			}
		}
		object[] result = new object[count];
		int pos = 0;
		for (int j = 0; j != names.Length; j++)
		{
			if (names[j].TagNo == 4)
			{
				result[pos++] = X509Name.GetInstance(names[j].Name);
			}
		}
		return result;
	}

	private X509Name[] GetPrincipals(GeneralNames names)
	{
		object[] p = GetNames(names.GetNames());
		int count = 0;
		for (int i = 0; i != p.Length; i++)
		{
			if (p[i] is X509Name)
			{
				count++;
			}
		}
		X509Name[] result = new X509Name[count];
		int pos = 0;
		for (int j = 0; j != p.Length; j++)
		{
			if (p[j] is X509Name)
			{
				result[pos++] = (X509Name)p[j];
			}
		}
		return result;
	}

	public X509Name[] GetEntityNames()
	{
		if (holder.EntityName != null)
		{
			return GetPrincipals(holder.EntityName);
		}
		return null;
	}

	public X509Name[] GetIssuer()
	{
		if (holder.BaseCertificateID != null)
		{
			return GetPrincipals(holder.BaseCertificateID.Issuer);
		}
		return null;
	}

	public object Clone()
	{
		return new AttributeCertificateHolder((Asn1Sequence)holder.ToAsn1Object());
	}

	public bool Match(X509Certificate x509Cert)
	{
		try
		{
			if (holder.BaseCertificateID != null)
			{
				return holder.BaseCertificateID.Serial.HasValue(x509Cert.SerialNumber) && MatchesDN(PrincipalUtilities.GetIssuerX509Principal(x509Cert), holder.BaseCertificateID.Issuer);
			}
			if (holder.EntityName != null && MatchesDN(PrincipalUtilities.GetSubjectX509Principal(x509Cert), holder.EntityName))
			{
				return true;
			}
			if (holder.ObjectDigestInfo != null)
			{
				IDigest md = null;
				try
				{
					md = DigestUtilities.GetDigest(DigestAlgorithm);
				}
				catch (Exception)
				{
					return false;
				}
				switch (DigestedObjectType)
				{
				case 0:
				{
					byte[] b2 = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(x509Cert.GetPublicKey()).GetEncoded();
					md.BlockUpdate(b2, 0, b2.Length);
					break;
				}
				case 1:
				{
					byte[] b = x509Cert.GetEncoded();
					md.BlockUpdate(b, 0, b.Length);
					break;
				}
				}
				if (!Arrays.AreEqual(DigestUtilities.DoFinal(md), GetObjectDigest()))
				{
					return false;
				}
			}
		}
		catch (CertificateEncodingException)
		{
			return false;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is AttributeCertificateHolder))
		{
			return false;
		}
		AttributeCertificateHolder other = (AttributeCertificateHolder)obj;
		return holder.Equals(other.holder);
	}

	public override int GetHashCode()
	{
		return holder.GetHashCode();
	}

	public bool Match(object obj)
	{
		if (!(obj is X509Certificate))
		{
			return false;
		}
		return Match((X509Certificate)obj);
	}
}
