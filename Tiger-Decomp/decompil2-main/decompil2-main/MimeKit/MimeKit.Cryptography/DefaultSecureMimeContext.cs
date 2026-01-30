using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public class DefaultSecureMimeContext : BouncyCastleSecureMimeContext
{
	private const X509CertificateRecordFields CmsRecipientFields = X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.Certificate;

	private const X509CertificateRecordFields CmsSignerFields = X509CertificateRecordFields.Certificate | X509CertificateRecordFields.PrivateKey;

	private const X509CertificateRecordFields AlgorithmFields = X509CertificateRecordFields.Id | X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.AlgorithmsUpdated;

	private const X509CertificateRecordFields ImportPkcs12Fields = X509CertificateRecordFields.Id | X509CertificateRecordFields.Trusted | X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.AlgorithmsUpdated | X509CertificateRecordFields.PrivateKey;

	public static readonly string DefaultDatabasePath;

	private readonly IX509CertificateDatabase dbase;

	static DefaultSecureMimeContext()
	{
		string path;
		if (Path.DirectorySeparatorChar == '\\')
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			path = Path.Combine(folderPath, "Roaming\\mimekit");
		}
		else
		{
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			path = Path.Combine(folderPath2, ".mimekit");
		}
		DefaultDatabasePath = Path.Combine(path, "smime.db");
	}

	private static void CheckIsAvailable()
	{
		if (!SqliteCertificateDatabase.IsAvailable)
		{
			throw new NotSupportedException(string.Format("SQLite is not available. Install the {0} nuget.", "System.Data.SQLite"));
		}
	}

	public DefaultSecureMimeContext(string fileName, string password)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		CheckIsAvailable();
		string directoryName = Path.GetDirectoryName(fileName);
		bool flag = File.Exists(fileName);
		if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		dbase = new SqliteCertificateDatabase(fileName, password);
	}

	public DefaultSecureMimeContext(string password)
		: this(DefaultDatabasePath, password)
	{
	}

	public DefaultSecureMimeContext()
		: this(DefaultDatabasePath, "no.secret")
	{
	}

	public DefaultSecureMimeContext(IX509CertificateDatabase database)
	{
		if (database == null)
		{
			throw new ArgumentNullException("database");
		}
		dbase = database;
	}

	public override bool CanSign(MailboxAddress signer)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		foreach (X509CertificateRecord item in dbase.Find(signer, DateTime.UtcNow, requirePrivateKey: true, X509CertificateRecordFields.Certificate | X509CertificateRecordFields.PrivateKey))
		{
			if (item.KeyUsage == X509KeyUsageFlags.None || (item.KeyUsage & (X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature)) != X509KeyUsageFlags.None)
			{
				return true;
			}
		}
		return false;
	}

	public override bool CanEncrypt(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		foreach (X509CertificateRecord item in dbase.Find(mailbox, DateTime.UtcNow, requirePrivateKey: false, X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.Certificate))
		{
			if (item.KeyUsage == X509KeyUsageFlags.None || (item.KeyUsage & X509KeyUsageFlags.KeyEncipherment) != X509KeyUsageFlags.None)
			{
				return true;
			}
		}
		return false;
	}

	protected override X509Certificate GetCertificate(IX509Selector selector)
	{
		return dbase.FindCertificates(selector).FirstOrDefault();
	}

	protected override AsymmetricKeyParameter GetPrivateKey(IX509Selector selector)
	{
		return dbase.FindPrivateKeys(selector).FirstOrDefault();
	}

	protected override HashSet GetTrustedAnchors()
	{
		HashSet hashSet = new HashSet();
		X509CertStoreSelector x509CertStoreSelector = new X509CertStoreSelector();
		x509CertStoreSelector.KeyUsage = new bool[9] { false, false, false, false, false, true, false, false, false };
		foreach (X509CertificateRecord item in dbase.Find(x509CertStoreSelector, trustedAnchorsOnly: true, X509CertificateRecordFields.Certificate))
		{
			hashSet.Add(new TrustAnchor(item.Certificate, null));
		}
		return hashSet;
	}

	protected override IX509Store GetIntermediateCertificates()
	{
		return dbase;
	}

	protected override IX509Store GetCertificateRevocationLists()
	{
		return dbase.GetCrlStore();
	}

	protected override DateTime GetNextCertificateRevocationListUpdate(X509Name issuer)
	{
		DateTime dateTime = DateTime.MinValue.ToUniversalTime();
		foreach (X509CrlRecord item in dbase.Find(issuer, X509CrlRecordFields.NextUpdate))
		{
			dateTime = ((item.NextUpdate > dateTime) ? item.NextUpdate : dateTime);
		}
		return dateTime;
	}

	protected override CmsRecipient GetCmsRecipient(MailboxAddress mailbox)
	{
		foreach (X509CertificateRecord item in dbase.Find(mailbox, DateTime.UtcNow, requirePrivateKey: false, X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.Certificate))
		{
			if (item.KeyUsage == X509KeyUsageFlags.None || (item.KeyUsage & X509KeyUsageFlags.KeyEncipherment) != X509KeyUsageFlags.None)
			{
				CmsRecipient cmsRecipient = new CmsRecipient(item.Certificate);
				if (item.Algorithms != null)
				{
					cmsRecipient.EncryptionAlgorithms = item.Algorithms;
				}
				return cmsRecipient;
			}
		}
		throw new CertificateNotFoundException(mailbox, "A valid certificate could not be found.");
	}

	protected override CmsSigner GetCmsSigner(MailboxAddress mailbox, DigestAlgorithm digestAlgo)
	{
		AsymmetricKeyParameter asymmetricKeyParameter = null;
		X509Certificate x509Certificate = null;
		foreach (X509CertificateRecord item in dbase.Find(mailbox, DateTime.UtcNow, requirePrivateKey: true, X509CertificateRecordFields.Certificate | X509CertificateRecordFields.PrivateKey))
		{
			if (item.KeyUsage == X509KeyUsageFlags.None || (item.KeyUsage & (X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature)) != X509KeyUsageFlags.None)
			{
				x509Certificate = item.Certificate;
				asymmetricKeyParameter = item.PrivateKey;
				break;
			}
		}
		if (x509Certificate != null && asymmetricKeyParameter != null)
		{
			CmsSigner cmsSigner = new CmsSigner(BuildCertificateChain(x509Certificate), asymmetricKeyParameter);
			cmsSigner.DigestAlgorithm = digestAlgo;
			return cmsSigner;
		}
		throw new CertificateNotFoundException(mailbox, "A valid signing certificate could not be found.");
	}

	protected override void UpdateSecureMimeCapabilities(X509Certificate certificate, EncryptionAlgorithm[] algorithms, DateTime timestamp)
	{
		X509CertificateRecord x509CertificateRecord;
		if ((x509CertificateRecord = dbase.Find(certificate, X509CertificateRecordFields.Id | X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.AlgorithmsUpdated)) == null)
		{
			x509CertificateRecord = new X509CertificateRecord(certificate);
			x509CertificateRecord.AlgorithmsUpdated = timestamp;
			x509CertificateRecord.Algorithms = algorithms;
			dbase.Add(x509CertificateRecord);
		}
		else if (timestamp > x509CertificateRecord.AlgorithmsUpdated)
		{
			x509CertificateRecord.AlgorithmsUpdated = timestamp;
			x509CertificateRecord.Algorithms = algorithms;
			dbase.Update(x509CertificateRecord, X509CertificateRecordFields.Id | X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.AlgorithmsUpdated);
		}
	}

	public override void Import(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (dbase.Find(certificate, X509CertificateRecordFields.Id) == null)
		{
			dbase.Add(new X509CertificateRecord(certificate));
		}
	}

	public override void Import(X509Crl crl)
	{
		if (crl == null)
		{
			throw new ArgumentNullException("crl");
		}
		if (dbase.Find(crl, X509CrlRecordFields.Id) != null)
		{
			return;
		}
		List<X509CrlRecord> list = new List<X509CrlRecord>();
		bool flag = crl.IsDelta();
		foreach (X509CrlRecord item in dbase.Find(crl.IssuerDN, ~X509CrlRecordFields.Crl))
		{
			if (!item.IsDelta && item.ThisUpdate >= crl.ThisUpdate)
			{
				return;
			}
			if (!flag)
			{
				list.Add(item);
			}
		}
		foreach (X509CrlRecord item2 in list)
		{
			dbase.Remove(item2);
		}
		dbase.Add(new X509CrlRecord(crl));
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
		EncryptionAlgorithm[] algorithms = base.EnabledEncryptionAlgorithms;
		foreach (string alias in pkcs12Store.Aliases)
		{
			if (pkcs12Store.IsKeyEntry(alias))
			{
				X509CertificateEntry[] certificateChain = pkcs12Store.GetCertificateChain(alias);
				AsymmetricKeyEntry key = pkcs12Store.GetKey(alias);
				int num = 0;
				if (key.Key.IsPrivate)
				{
					X509CertificateRecord x509CertificateRecord;
					if ((x509CertificateRecord = dbase.Find(certificateChain[0].Certificate, X509CertificateRecordFields.Id | X509CertificateRecordFields.Trusted | X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.AlgorithmsUpdated | X509CertificateRecordFields.PrivateKey)) == null)
					{
						x509CertificateRecord = new X509CertificateRecord(certificateChain[0].Certificate, key.Key);
						x509CertificateRecord.AlgorithmsUpdated = DateTime.UtcNow;
						x509CertificateRecord.Algorithms = algorithms;
						x509CertificateRecord.IsTrusted = true;
						dbase.Add(x509CertificateRecord);
					}
					else
					{
						x509CertificateRecord.AlgorithmsUpdated = DateTime.UtcNow;
						x509CertificateRecord.Algorithms = algorithms;
						if (x509CertificateRecord.PrivateKey == null)
						{
							x509CertificateRecord.PrivateKey = key.Key;
						}
						x509CertificateRecord.IsTrusted = true;
						dbase.Update(x509CertificateRecord, X509CertificateRecordFields.Id | X509CertificateRecordFields.Trusted | X509CertificateRecordFields.Algorithms | X509CertificateRecordFields.AlgorithmsUpdated | X509CertificateRecordFields.PrivateKey);
					}
					num = 1;
				}
				for (int i = num; i < certificateChain.Length; i++)
				{
					Import(certificateChain[i].Certificate, trusted: true);
				}
			}
			else if (pkcs12Store.IsCertificateEntry(alias))
			{
				X509CertificateEntry certificate = pkcs12Store.GetCertificate(alias);
				Import(certificate.Certificate, trusted: true);
			}
		}
	}

	public void Import(X509Certificate certificate, bool trusted)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		X509CertificateRecord x509CertificateRecord;
		if ((x509CertificateRecord = dbase.Find(certificate, X509CertificateRecordFields.Id | X509CertificateRecordFields.Trusted)) != null)
		{
			if (trusted && !x509CertificateRecord.IsTrusted)
			{
				x509CertificateRecord.IsTrusted = trusted;
				dbase.Update(x509CertificateRecord, X509CertificateRecordFields.Trusted);
			}
		}
		else
		{
			x509CertificateRecord = new X509CertificateRecord(certificate);
			x509CertificateRecord.IsTrusted = trusted;
			dbase.Add(x509CertificateRecord);
		}
	}

	public void Import(Stream stream, bool trusted)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		X509CertificateParser x509CertificateParser = new X509CertificateParser();
		foreach (X509Certificate item in x509CertificateParser.ReadCertificates(stream))
		{
			Import(item, trusted);
		}
	}

	protected override void Dispose(bool disposing)
	{
		dbase.Dispose();
		base.Dispose(disposing);
	}
}
