using System;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public interface IX509CertificateDatabase : IX509Store, IDisposable
{
	X509CertificateRecord Find(X509Certificate certificate, X509CertificateRecordFields fields);

	IEnumerable<X509Certificate> FindCertificates(IX509Selector selector);

	IEnumerable<AsymmetricKeyParameter> FindPrivateKeys(IX509Selector selector);

	IEnumerable<X509CertificateRecord> Find(MailboxAddress mailbox, DateTime now, bool requirePrivateKey, X509CertificateRecordFields fields);

	IEnumerable<X509CertificateRecord> Find(IX509Selector selector, bool trustedAnchorsOnly, X509CertificateRecordFields fields);

	void Add(X509CertificateRecord record);

	void Remove(X509CertificateRecord record);

	void Update(X509CertificateRecord record, X509CertificateRecordFields fields);

	IEnumerable<X509CrlRecord> Find(X509Name issuer, X509CrlRecordFields fields);

	X509CrlRecord Find(X509Crl crl, X509CrlRecordFields fields);

	void Add(X509CrlRecord record);

	void Remove(X509CrlRecord record);

	void Update(X509CrlRecord record);

	IX509Store GetCrlStore();
}
