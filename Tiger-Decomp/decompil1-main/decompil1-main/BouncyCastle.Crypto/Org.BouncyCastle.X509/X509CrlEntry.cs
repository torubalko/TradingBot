using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509;

public class X509CrlEntry : X509ExtensionBase
{
	private CrlEntry c;

	private bool isIndirect;

	private X509Name previousCertificateIssuer;

	private X509Name certificateIssuer;

	private volatile bool hashValueSet;

	private volatile int hashValue;

	public BigInteger SerialNumber => c.UserCertificate.Value;

	public DateTime RevocationDate => c.RevocationDate.ToDateTime();

	public bool HasExtensions => c.Extensions != null;

	public X509CrlEntry(CrlEntry c)
	{
		this.c = c;
		certificateIssuer = loadCertificateIssuer();
	}

	public X509CrlEntry(CrlEntry c, bool isIndirect, X509Name previousCertificateIssuer)
	{
		this.c = c;
		this.isIndirect = isIndirect;
		this.previousCertificateIssuer = previousCertificateIssuer;
		certificateIssuer = loadCertificateIssuer();
	}

	private X509Name loadCertificateIssuer()
	{
		if (!isIndirect)
		{
			return null;
		}
		Asn1OctetString ext = GetExtensionValue(X509Extensions.CertificateIssuer);
		if (ext == null)
		{
			return previousCertificateIssuer;
		}
		try
		{
			GeneralName[] names = GeneralNames.GetInstance(X509ExtensionUtilities.FromExtensionValue(ext)).GetNames();
			for (int i = 0; i < names.Length; i++)
			{
				if (names[i].TagNo == 4)
				{
					return X509Name.GetInstance(names[i].Name);
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public X509Name GetCertificateIssuer()
	{
		return certificateIssuer;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return c.Extensions;
	}

	public byte[] GetEncoded()
	{
		try
		{
			return c.GetDerEncoded();
		}
		catch (Exception ex)
		{
			throw new CrlException(ex.ToString());
		}
	}

	public override bool Equals(object other)
	{
		if (this == other)
		{
			return true;
		}
		if (!(other is X509CrlEntry that))
		{
			return false;
		}
		if (hashValueSet && that.hashValueSet && hashValue != that.hashValue)
		{
			return false;
		}
		return c.Equals(that.c);
	}

	public override int GetHashCode()
	{
		if (!hashValueSet)
		{
			hashValue = c.GetHashCode();
			hashValueSet = true;
		}
		return hashValue;
	}

	public override string ToString()
	{
		StringBuilder buf = new StringBuilder();
		string nl = Platform.NewLine;
		buf.Append("        userCertificate: ").Append(SerialNumber).Append(nl);
		buf.Append("         revocationDate: ").Append(RevocationDate).Append(nl);
		buf.Append("      certificateIssuer: ").Append(GetCertificateIssuer()).Append(nl);
		X509Extensions extensions = c.Extensions;
		if (extensions != null)
		{
			IEnumerator e = extensions.ExtensionOids.GetEnumerator();
			if (e.MoveNext())
			{
				buf.Append("   crlEntryExtensions:").Append(nl);
				do
				{
					DerObjectIdentifier oid = (DerObjectIdentifier)e.Current;
					X509Extension ext = extensions.GetExtension(oid);
					if (ext.Value != null)
					{
						Asn1Object obj = X509ExtensionUtilities.FromExtensionValue(ext.Value);
						buf.Append("                       critical(").Append(ext.IsCritical).Append(") ");
						try
						{
							if (oid.Equals(X509Extensions.ReasonCode))
							{
								buf.Append(new CrlReason(DerEnumerated.GetInstance(obj)));
							}
							else if (oid.Equals(X509Extensions.CertificateIssuer))
							{
								buf.Append("Certificate issuer: ").Append(GeneralNames.GetInstance((Asn1Sequence)obj));
							}
							else
							{
								buf.Append(oid.Id);
								buf.Append(" value = ").Append(Asn1Dump.DumpAsString(obj));
							}
							buf.Append(nl);
						}
						catch (Exception)
						{
							buf.Append(oid.Id);
							buf.Append(" value = ").Append("*****").Append(nl);
						}
					}
					else
					{
						buf.Append(nl);
					}
				}
				while (e.MoveNext());
			}
		}
		return buf.ToString();
	}
}
