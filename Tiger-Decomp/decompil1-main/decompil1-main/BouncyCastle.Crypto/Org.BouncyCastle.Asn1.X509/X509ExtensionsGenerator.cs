using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class X509ExtensionsGenerator
{
	private IDictionary extensions = Platform.CreateHashtable();

	private IList extOrdering = Platform.CreateArrayList();

	private static readonly IDictionary dupsAllowed;

	public bool IsEmpty => extOrdering.Count < 1;

	static X509ExtensionsGenerator()
	{
		dupsAllowed = Platform.CreateHashtable();
		dupsAllowed.Add(X509Extensions.SubjectAlternativeName, true);
		dupsAllowed.Add(X509Extensions.IssuerAlternativeName, true);
		dupsAllowed.Add(X509Extensions.SubjectDirectoryAttributes, true);
		dupsAllowed.Add(X509Extensions.CertificateIssuer, true);
	}

	public void Reset()
	{
		extensions = Platform.CreateHashtable();
		extOrdering = Platform.CreateArrayList();
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable extValue)
	{
		byte[] encoded;
		try
		{
			encoded = extValue.GetDerEncoded();
		}
		catch (Exception ex)
		{
			throw new ArgumentException("error encoding value: " + ex);
		}
		AddExtension(oid, critical, encoded);
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, byte[] extValue)
	{
		if (extensions.Contains(oid))
		{
			if (!dupsAllowed.Contains(oid))
			{
				throw new ArgumentException("extension " + oid?.ToString() + " already added");
			}
			X509Extension existingExtension = (X509Extension)extensions[oid];
			Asn1EncodableVector items = Asn1EncodableVector.FromEnumerable(Asn1Sequence.GetInstance(Asn1OctetString.GetInstance(existingExtension.Value).GetOctets()));
			foreach (Asn1Encodable enc in Asn1Sequence.GetInstance(extValue))
			{
				items.Add(enc);
			}
			extensions[oid] = new X509Extension(existingExtension.IsCritical, new DerOctetString(new DerSequence(items).GetEncoded()));
		}
		else
		{
			extOrdering.Add(oid);
			extensions.Add(oid, new X509Extension(critical, new DerOctetString(extValue)));
		}
	}

	public void AddExtensions(X509Extensions extensions)
	{
		foreach (DerObjectIdentifier ident in extensions.ExtensionOids)
		{
			X509Extension ext = extensions.GetExtension(ident);
			AddExtension(ident, ext.critical, ext.Value.GetOctets());
		}
	}

	public X509Extensions Generate()
	{
		return new X509Extensions(extOrdering, extensions);
	}

	internal void AddExtension(DerObjectIdentifier oid, X509Extension x509Extension)
	{
		if (extensions.Contains(oid))
		{
			throw new ArgumentException("extension " + oid?.ToString() + " already added");
		}
		extOrdering.Add(oid);
		extensions.Add(oid, x509Extension);
	}
}
