using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class CmsRecipient
{
	public Org.BouncyCastle.X509.X509Certificate Certificate { get; private set; }

	public SubjectIdentifierType RecipientIdentifierType { get; private set; }

	public EncryptionAlgorithm[] EncryptionAlgorithms { get; set; }

	public RsaEncryptionPadding RsaEncryptionPadding { get; set; }

	public CmsRecipient(Org.BouncyCastle.X509.X509Certificate certificate, SubjectIdentifierType recipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (recipientIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			RecipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			RecipientIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		EncryptionAlgorithms = certificate.GetEncryptionAlgorithms();
		Certificate = certificate;
	}

	public CmsRecipient(Stream stream, SubjectIdentifierType recipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (recipientIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			RecipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			RecipientIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		X509CertificateParser x509CertificateParser = new X509CertificateParser();
		Certificate = x509CertificateParser.ReadCertificate(stream);
		if (Certificate == null)
		{
			throw new FormatException();
		}
		EncryptionAlgorithms = Certificate.GetEncryptionAlgorithms();
	}

	public CmsRecipient(string fileName, SubjectIdentifierType recipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (recipientIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			RecipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			RecipientIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		using (FileStream inStream = File.OpenRead(fileName))
		{
			X509CertificateParser x509CertificateParser = new X509CertificateParser();
			Certificate = x509CertificateParser.ReadCertificate(inStream);
		}
		if (Certificate == null)
		{
			throw new FormatException();
		}
		EncryptionAlgorithms = Certificate.GetEncryptionAlgorithms();
	}

	public CmsRecipient(X509Certificate2 certificate, SubjectIdentifierType recipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (recipientIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			RecipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			RecipientIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		EncryptionAlgorithms = certificate.GetEncryptionAlgorithms();
		Certificate = certificate.AsBouncyCastleCertificate();
	}
}
