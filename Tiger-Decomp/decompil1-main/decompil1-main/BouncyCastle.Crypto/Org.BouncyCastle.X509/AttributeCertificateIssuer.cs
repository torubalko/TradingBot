using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.X509;

public class AttributeCertificateIssuer : IX509Selector, ICloneable
{
	internal readonly Asn1Encodable form;

	public AttributeCertificateIssuer(AttCertIssuer issuer)
	{
		form = issuer.Issuer;
	}

	public AttributeCertificateIssuer(X509Name principal)
	{
		form = new V2Form(new GeneralNames(new GeneralName(principal)));
	}

	private object[] GetNames()
	{
		GeneralNames name = ((!(form is V2Form)) ? ((GeneralNames)form) : ((V2Form)form).IssuerName);
		GeneralName[] names = name.GetNames();
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

	public X509Name[] GetPrincipals()
	{
		object[] p = GetNames();
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

	public object Clone()
	{
		return new AttributeCertificateIssuer(AttCertIssuer.GetInstance(form));
	}

	public bool Match(X509Certificate x509Cert)
	{
		if (form is V2Form)
		{
			V2Form issuer = (V2Form)form;
			if (issuer.BaseCertificateID != null)
			{
				if (issuer.BaseCertificateID.Serial.HasValue(x509Cert.SerialNumber))
				{
					return MatchesDN(x509Cert.IssuerDN, issuer.BaseCertificateID.Issuer);
				}
				return false;
			}
			return MatchesDN(x509Cert.SubjectDN, issuer.IssuerName);
		}
		return MatchesDN(x509Cert.SubjectDN, (GeneralNames)form);
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is AttributeCertificateIssuer))
		{
			return false;
		}
		AttributeCertificateIssuer other = (AttributeCertificateIssuer)obj;
		return form.Equals(other.form);
	}

	public override int GetHashCode()
	{
		return form.GetHashCode();
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
