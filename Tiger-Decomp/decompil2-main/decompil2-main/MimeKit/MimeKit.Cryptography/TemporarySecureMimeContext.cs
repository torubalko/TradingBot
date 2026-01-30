using System;
using System.Collections.Generic;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public class TemporarySecureMimeContext : BouncyCastleSecureMimeContext
{
	private readonly Dictionary<string, EncryptionAlgorithm[]> capabilities;

	internal readonly Dictionary<string, AsymmetricKeyParameter> keys;

	internal readonly List<X509Certificate> certificates;

	private readonly HashSet<string> fingerprints;

	private readonly List<X509Crl> crls;

	public TemporarySecureMimeContext()
	{
		capabilities = new Dictionary<string, EncryptionAlgorithm[]>(StringComparer.Ordinal);
		keys = new Dictionary<string, AsymmetricKeyParameter>(StringComparer.Ordinal);
		certificates = new List<X509Certificate>();
		fingerprints = new HashSet<string>();
		crls = new List<X509Crl>();
	}

	public override bool CanSign(MailboxAddress signer)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		AsymmetricKeyParameter key;
		return GetCmsSignerCertificate(signer, out key) != null;
	}

	public override bool CanEncrypt(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		return GetCmsRecipientCertificate(mailbox) != null;
	}

	protected override X509Certificate GetCertificate(IX509Selector selector)
	{
		if (selector == null && certificates.Count > 0)
		{
			return certificates[0];
		}
		foreach (X509Certificate certificate in certificates)
		{
			if (selector.Match(certificate))
			{
				return certificate;
			}
		}
		return null;
	}

	protected override AsymmetricKeyParameter GetPrivateKey(IX509Selector selector)
	{
		foreach (X509Certificate certificate in certificates)
		{
			string fingerprint = certificate.GetFingerprint();
			if (keys.TryGetValue(fingerprint, out var value) && (selector == null || selector.Match(certificate)))
			{
				return value;
			}
		}
		return null;
	}

	protected override HashSet GetTrustedAnchors()
	{
		HashSet hashSet = new HashSet();
		foreach (X509Certificate certificate in certificates)
		{
			bool[] keyUsage = certificate.GetKeyUsage();
			if (keyUsage != null && keyUsage[5] && certificate.IsSelfSigned())
			{
				hashSet.Add(new TrustAnchor(certificate, null));
			}
		}
		return hashSet;
	}

	protected override IX509Store GetIntermediateCertificates()
	{
		X509CertificateStore x509CertificateStore = new X509CertificateStore();
		foreach (X509Certificate certificate in certificates)
		{
			bool[] keyUsage = certificate.GetKeyUsage();
			if (keyUsage != null && keyUsage[5] && !certificate.IsSelfSigned())
			{
				x509CertificateStore.Add(certificate);
			}
		}
		return x509CertificateStore;
	}

	protected override IX509Store GetCertificateRevocationLists()
	{
		return X509StoreFactory.Create("Crl/Collection", new X509CollectionStoreParameters(crls));
	}

	protected override DateTime GetNextCertificateRevocationListUpdate(X509Name issuer)
	{
		DateTime dateTime = DateTime.MinValue.ToUniversalTime();
		foreach (X509Crl crl in crls)
		{
			if (crl.IssuerDN.Equals(issuer))
			{
				dateTime = ((crl.NextUpdate.Value > dateTime) ? crl.NextUpdate.Value : dateTime);
			}
		}
		return dateTime;
	}

	private X509Certificate GetCmsRecipientCertificate(MailboxAddress mailbox)
	{
		SecureMailboxAddress secureMailboxAddress = mailbox as SecureMailboxAddress;
		DateTime utcNow = DateTime.UtcNow;
		foreach (X509Certificate certificate in certificates)
		{
			if (certificate.NotBefore > utcNow || certificate.NotAfter < utcNow)
			{
				continue;
			}
			X509KeyUsageFlags keyUsageFlags = certificate.GetKeyUsageFlags();
			if (keyUsageFlags != X509KeyUsageFlags.None && (keyUsageFlags & X509KeyUsageFlags.KeyEncipherment) == 0)
			{
				continue;
			}
			if (secureMailboxAddress != null)
			{
				string fingerprint = certificate.GetFingerprint();
				if (!fingerprint.Equals(secureMailboxAddress.Fingerprint, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
			}
			else
			{
				string subjectEmailAddress = certificate.GetSubjectEmailAddress();
				if (!subjectEmailAddress.Equals(mailbox.Address, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
			}
			return certificate;
		}
		return null;
	}

	protected override CmsRecipient GetCmsRecipient(MailboxAddress mailbox)
	{
		X509Certificate cmsRecipientCertificate;
		if ((cmsRecipientCertificate = GetCmsRecipientCertificate(mailbox)) == null)
		{
			throw new CertificateNotFoundException(mailbox, "A valid certificate could not be found.");
		}
		CmsRecipient cmsRecipient = new CmsRecipient(cmsRecipientCertificate);
		if (capabilities.TryGetValue(cmsRecipientCertificate.GetFingerprint(), out var value))
		{
			cmsRecipient.EncryptionAlgorithms = value;
		}
		return cmsRecipient;
	}

	private X509Certificate GetCmsSignerCertificate(MailboxAddress mailbox, out AsymmetricKeyParameter key)
	{
		SecureMailboxAddress secureMailboxAddress = mailbox as SecureMailboxAddress;
		DateTime utcNow = DateTime.UtcNow;
		foreach (X509Certificate certificate in certificates)
		{
			if (certificate.NotBefore > utcNow || certificate.NotAfter < utcNow)
			{
				continue;
			}
			X509KeyUsageFlags keyUsageFlags = certificate.GetKeyUsageFlags();
			if (keyUsageFlags != X509KeyUsageFlags.None && (keyUsageFlags & (X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature)) == 0)
			{
				continue;
			}
			string fingerprint = certificate.GetFingerprint();
			if (!keys.TryGetValue(fingerprint, out key))
			{
				continue;
			}
			if (secureMailboxAddress != null)
			{
				if (!fingerprint.Equals(secureMailboxAddress.Fingerprint, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
			}
			else
			{
				string subjectEmailAddress = certificate.GetSubjectEmailAddress();
				if (!subjectEmailAddress.Equals(mailbox.Address, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
			}
			return certificate;
		}
		key = null;
		return null;
	}

	protected override CmsSigner GetCmsSigner(MailboxAddress mailbox, DigestAlgorithm digestAlgo)
	{
		X509Certificate cmsSignerCertificate;
		if ((cmsSignerCertificate = GetCmsSignerCertificate(mailbox, out var key)) == null)
		{
			throw new CertificateNotFoundException(mailbox, "A valid signing certificate could not be found.");
		}
		return new CmsSigner(BuildCertificateChain(cmsSignerCertificate), key)
		{
			DigestAlgorithm = digestAlgo
		};
	}

	protected override void UpdateSecureMimeCapabilities(X509Certificate certificate, EncryptionAlgorithm[] algorithms, DateTime timestamp)
	{
		capabilities[certificate.GetFingerprint()] = algorithms;
	}

	public override void Import(Stream stream, string password)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		Pkcs12Store pkcs12Store = new Pkcs12Store(stream, password.ToCharArray());
		foreach (string alias in pkcs12Store.Aliases)
		{
			if (pkcs12Store.IsKeyEntry(alias))
			{
				X509CertificateEntry[] certificateChain = pkcs12Store.GetCertificateChain(alias);
				AsymmetricKeyEntry key = pkcs12Store.GetKey(alias);
				for (int i = 0; i < certificateChain.Length; i++)
				{
					Import(certificateChain[i].Certificate);
				}
				string fingerprint = certificateChain[0].Certificate.GetFingerprint();
				if (!keys.ContainsKey(fingerprint))
				{
					keys.Add(fingerprint, key.Key);
				}
			}
			else if (pkcs12Store.IsCertificateEntry(alias))
			{
				X509CertificateEntry certificate = pkcs12Store.GetCertificate(alias);
				Import(certificate.Certificate);
			}
		}
	}

	public override void Import(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (fingerprints.Add(certificate.GetFingerprint()))
		{
			certificates.Add(certificate);
		}
	}

	public override void Import(X509Crl crl)
	{
		if (crl == null)
		{
			throw new ArgumentNullException("crl");
		}
		crls.Add(crl);
	}
}
