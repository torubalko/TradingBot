using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509.Store;

public class X509CertStoreSelector : IX509Selector, ICloneable
{
	private byte[] authorityKeyIdentifier;

	private int basicConstraints = -1;

	private X509Certificate certificate;

	private DateTimeObject certificateValid;

	private ISet extendedKeyUsage;

	private bool ignoreX509NameOrdering;

	private X509Name issuer;

	private bool[] keyUsage;

	private ISet policy;

	private DateTimeObject privateKeyValid;

	private BigInteger serialNumber;

	private X509Name subject;

	private byte[] subjectKeyIdentifier;

	private SubjectPublicKeyInfo subjectPublicKey;

	private DerObjectIdentifier subjectPublicKeyAlgID;

	public byte[] AuthorityKeyIdentifier
	{
		get
		{
			return Arrays.Clone(authorityKeyIdentifier);
		}
		set
		{
			authorityKeyIdentifier = Arrays.Clone(value);
		}
	}

	public int BasicConstraints
	{
		get
		{
			return basicConstraints;
		}
		set
		{
			if (value < -2)
			{
				throw new ArgumentException("value can't be less than -2", "value");
			}
			basicConstraints = value;
		}
	}

	public X509Certificate Certificate
	{
		get
		{
			return certificate;
		}
		set
		{
			certificate = value;
		}
	}

	public DateTimeObject CertificateValid
	{
		get
		{
			return certificateValid;
		}
		set
		{
			certificateValid = value;
		}
	}

	public ISet ExtendedKeyUsage
	{
		get
		{
			return CopySet(extendedKeyUsage);
		}
		set
		{
			extendedKeyUsage = CopySet(value);
		}
	}

	public bool IgnoreX509NameOrdering
	{
		get
		{
			return ignoreX509NameOrdering;
		}
		set
		{
			ignoreX509NameOrdering = value;
		}
	}

	public X509Name Issuer
	{
		get
		{
			return issuer;
		}
		set
		{
			issuer = value;
		}
	}

	[Obsolete("Avoid working with X509Name objects in string form")]
	public string IssuerAsString
	{
		get
		{
			if (issuer == null)
			{
				return null;
			}
			return issuer.ToString();
		}
	}

	public bool[] KeyUsage
	{
		get
		{
			return CopyBoolArray(keyUsage);
		}
		set
		{
			keyUsage = CopyBoolArray(value);
		}
	}

	public ISet Policy
	{
		get
		{
			return CopySet(policy);
		}
		set
		{
			policy = CopySet(value);
		}
	}

	public DateTimeObject PrivateKeyValid
	{
		get
		{
			return privateKeyValid;
		}
		set
		{
			privateKeyValid = value;
		}
	}

	public BigInteger SerialNumber
	{
		get
		{
			return serialNumber;
		}
		set
		{
			serialNumber = value;
		}
	}

	public X509Name Subject
	{
		get
		{
			return subject;
		}
		set
		{
			subject = value;
		}
	}

	[Obsolete("Avoid working with X509Name objects in string form")]
	public string SubjectAsString
	{
		get
		{
			if (subject == null)
			{
				return null;
			}
			return subject.ToString();
		}
	}

	public byte[] SubjectKeyIdentifier
	{
		get
		{
			return Arrays.Clone(subjectKeyIdentifier);
		}
		set
		{
			subjectKeyIdentifier = Arrays.Clone(value);
		}
	}

	public SubjectPublicKeyInfo SubjectPublicKey
	{
		get
		{
			return subjectPublicKey;
		}
		set
		{
			subjectPublicKey = value;
		}
	}

	public DerObjectIdentifier SubjectPublicKeyAlgID
	{
		get
		{
			return subjectPublicKeyAlgID;
		}
		set
		{
			subjectPublicKeyAlgID = value;
		}
	}

	public X509CertStoreSelector()
	{
	}

	public X509CertStoreSelector(X509CertStoreSelector o)
	{
		authorityKeyIdentifier = o.AuthorityKeyIdentifier;
		basicConstraints = o.BasicConstraints;
		certificate = o.Certificate;
		certificateValid = o.CertificateValid;
		extendedKeyUsage = o.ExtendedKeyUsage;
		ignoreX509NameOrdering = o.IgnoreX509NameOrdering;
		issuer = o.Issuer;
		keyUsage = o.KeyUsage;
		policy = o.Policy;
		privateKeyValid = o.PrivateKeyValid;
		serialNumber = o.SerialNumber;
		subject = o.Subject;
		subjectKeyIdentifier = o.SubjectKeyIdentifier;
		subjectPublicKey = o.SubjectPublicKey;
		subjectPublicKeyAlgID = o.SubjectPublicKeyAlgID;
	}

	public virtual object Clone()
	{
		return new X509CertStoreSelector(this);
	}

	public virtual bool Match(object obj)
	{
		if (!(obj is X509Certificate c))
		{
			return false;
		}
		if (!MatchExtension(authorityKeyIdentifier, c, X509Extensions.AuthorityKeyIdentifier))
		{
			return false;
		}
		if (basicConstraints != -1)
		{
			int bc = c.GetBasicConstraints();
			if (basicConstraints == -2)
			{
				if (bc != -1)
				{
					return false;
				}
			}
			else if (bc < basicConstraints)
			{
				return false;
			}
		}
		if (certificate != null && !certificate.Equals(c))
		{
			return false;
		}
		if (certificateValid != null && !c.IsValid(certificateValid.Value))
		{
			return false;
		}
		if (extendedKeyUsage != null)
		{
			IList eku = c.GetExtendedKeyUsage();
			if (eku != null)
			{
				foreach (DerObjectIdentifier oid in extendedKeyUsage)
				{
					if (!eku.Contains(oid.Id))
					{
						return false;
					}
				}
			}
		}
		if (issuer != null && !issuer.Equivalent(c.IssuerDN, !ignoreX509NameOrdering))
		{
			return false;
		}
		if (keyUsage != null)
		{
			bool[] ku = c.GetKeyUsage();
			if (ku != null)
			{
				for (int i = 0; i < 9; i++)
				{
					if (keyUsage[i] && !ku[i])
					{
						return false;
					}
				}
			}
		}
		if (policy != null)
		{
			Asn1OctetString extVal = c.GetExtensionValue(X509Extensions.CertificatePolicies);
			if (extVal == null)
			{
				return false;
			}
			Asn1Sequence certPolicies = Asn1Sequence.GetInstance(X509ExtensionUtilities.FromExtensionValue(extVal));
			if (policy.Count < 1 && certPolicies.Count < 1)
			{
				return false;
			}
			bool found = false;
			foreach (PolicyInformation pi in certPolicies)
			{
				if (policy.Contains(pi.PolicyIdentifier))
				{
					found = true;
					break;
				}
			}
			if (!found)
			{
				return false;
			}
		}
		if (privateKeyValid != null)
		{
			Asn1OctetString extVal2 = c.GetExtensionValue(X509Extensions.PrivateKeyUsagePeriod);
			if (extVal2 == null)
			{
				return false;
			}
			PrivateKeyUsagePeriod instance = PrivateKeyUsagePeriod.GetInstance(X509ExtensionUtilities.FromExtensionValue(extVal2));
			DateTime dt = privateKeyValid.Value;
			DateTime notAfter = instance.NotAfter.ToDateTime();
			DateTime notBefore = instance.NotBefore.ToDateTime();
			if (dt.CompareTo(notAfter) > 0 || dt.CompareTo(notBefore) < 0)
			{
				return false;
			}
		}
		if (serialNumber != null && !serialNumber.Equals(c.SerialNumber))
		{
			return false;
		}
		if (subject != null && !subject.Equivalent(c.SubjectDN, !ignoreX509NameOrdering))
		{
			return false;
		}
		if (!MatchExtension(subjectKeyIdentifier, c, X509Extensions.SubjectKeyIdentifier))
		{
			return false;
		}
		if (subjectPublicKey != null && !subjectPublicKey.Equals(GetSubjectPublicKey(c)))
		{
			return false;
		}
		if (subjectPublicKeyAlgID != null && !subjectPublicKeyAlgID.Equals(GetSubjectPublicKey(c).AlgorithmID))
		{
			return false;
		}
		return true;
	}

	internal static bool IssuersMatch(X509Name a, X509Name b)
	{
		return a?.Equivalent(b, inOrder: true) ?? (b == null);
	}

	private static bool[] CopyBoolArray(bool[] b)
	{
		if (b != null)
		{
			return (bool[])b.Clone();
		}
		return null;
	}

	private static ISet CopySet(ISet s)
	{
		if (s != null)
		{
			return new HashSet(s);
		}
		return null;
	}

	private static SubjectPublicKeyInfo GetSubjectPublicKey(X509Certificate c)
	{
		return SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(c.GetPublicKey());
	}

	private static bool MatchExtension(byte[] b, X509Certificate c, DerObjectIdentifier oid)
	{
		if (b == null)
		{
			return true;
		}
		Asn1OctetString extVal = c.GetExtensionValue(oid);
		if (extVal == null)
		{
			return false;
		}
		return Arrays.AreEqual(b, extVal.GetOctets());
	}
}
