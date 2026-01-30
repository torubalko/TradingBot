using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Smime;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public abstract class BouncyCastleSecureMimeContext : SecureMimeContext
{
	private class CmsRecipientInfoGenerator : RecipientInfoGenerator
	{
		private readonly CmsRecipient recipient;

		public CmsRecipientInfoGenerator(CmsRecipient recipient)
		{
			this.recipient = recipient;
		}

		private IWrapper CreateWrapper(AlgorithmIdentifier keyExchangeAlgorithm)
		{
			string algorithm;
			if (!PkcsObjectIdentifiers.IdRsaesOaep.Id.Equals(keyExchangeAlgorithm.Algorithm.Id, StringComparison.Ordinal))
			{
				algorithm = ((!PkcsObjectIdentifiers.RsaEncryption.Id.Equals(keyExchangeAlgorithm.Algorithm.Id, StringComparison.Ordinal)) ? keyExchangeAlgorithm.Algorithm.Id : "RSA//PKCS1Padding");
			}
			else
			{
				RsaesOaepParameters instance = RsaesOaepParameters.GetInstance(keyExchangeAlgorithm.Parameters);
				algorithm = "RSA//OAEPWITH" + DigestUtilities.GetAlgorithmName(instance.HashAlgorithm.Algorithm) + "ANDMGF1Padding";
			}
			return WrapperUtilities.GetWrapper(algorithm);
		}

		private byte[] GenerateWrappedKey(KeyParameter contentEncryptionKey, AlgorithmIdentifier keyEncryptionAlgorithm, AsymmetricKeyParameter publicKey, SecureRandom random)
		{
			IWrapper wrapper = CreateWrapper(keyEncryptionAlgorithm);
			byte[] key = contentEncryptionKey.GetKey();
			wrapper.Init(forWrapping: true, new ParametersWithRandom(publicKey, random));
			return wrapper.Wrap(key, 0, key.Length);
		}

		public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
		{
			Asn1Object obj = Asn1Object.FromByteArray(recipient.Certificate.GetTbsCertificate());
			TbsCertificateStructure instance = TbsCertificateStructure.GetInstance(obj);
			AsymmetricKeyParameter publicKey = recipient.Certificate.GetPublicKey();
			SubjectPublicKeyInfo subjectPublicKeyInfo = instance.SubjectPublicKeyInfo;
			AlgorithmIdentifier keyEncryptionAlgorithm;
			if (publicKey is RsaKeyParameters)
			{
				RsaEncryptionPadding rsaEncryptionPadding = recipient.RsaEncryptionPadding;
				if ((object)rsaEncryptionPadding != null && rsaEncryptionPadding.Scheme == RsaEncryptionPaddingScheme.Oaep)
				{
					keyEncryptionAlgorithm = recipient.RsaEncryptionPadding.GetAlgorithmIdentifier();
					goto IL_0075;
				}
			}
			keyEncryptionAlgorithm = subjectPublicKeyInfo.AlgorithmID;
			goto IL_0075;
			IL_0075:
			byte[] str = GenerateWrappedKey(contentEncryptionKey, keyEncryptionAlgorithm, publicKey, random);
			RecipientIdentifier recipientIdentifier = null;
			if (recipient.RecipientIdentifierType == SubjectIdentifierType.SubjectKeyIdentifier)
			{
				Asn1OctetString extensionValue = recipient.Certificate.GetExtensionValue(X509Extensions.SubjectKeyIdentifier);
				recipientIdentifier = new RecipientIdentifier(extensionValue);
			}
			if (recipientIdentifier == null)
			{
				Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber id = new Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(instance.Issuer, instance.SerialNumber.Value);
				recipientIdentifier = new RecipientIdentifier(id);
			}
			return new RecipientInfo(new KeyTransRecipientInfo(recipientIdentifier, keyEncryptionAlgorithm, new DerOctetString(str)));
		}
	}

	private static readonly string RsassaPssOid = PkcsObjectIdentifiers.IdRsassaPss.Id;

	private HttpClient client;

	public bool CheckCertificateRevocation { get; set; }

	protected BouncyCastleSecureMimeContext()
	{
		client = new HttpClient();
	}

	protected abstract X509Certificate GetCertificate(IX509Selector selector);

	protected abstract AsymmetricKeyParameter GetPrivateKey(IX509Selector selector);

	protected abstract HashSet GetTrustedAnchors();

	protected abstract IX509Store GetIntermediateCertificates();

	protected abstract IX509Store GetCertificateRevocationLists();

	protected abstract DateTime GetNextCertificateRevocationListUpdate(X509Name issuer);

	protected abstract CmsRecipient GetCmsRecipient(MailboxAddress mailbox);

	protected CmsRecipientCollection GetCmsRecipients(IEnumerable<MailboxAddress> mailboxes)
	{
		if (mailboxes == null)
		{
			throw new ArgumentNullException("mailboxes");
		}
		CmsRecipientCollection cmsRecipientCollection = new CmsRecipientCollection();
		foreach (MailboxAddress mailbox in mailboxes)
		{
			cmsRecipientCollection.Add(GetCmsRecipient(mailbox));
		}
		return cmsRecipientCollection;
	}

	protected abstract CmsSigner GetCmsSigner(MailboxAddress mailbox, DigestAlgorithm digestAlgo);

	protected abstract void UpdateSecureMimeCapabilities(X509Certificate certificate, EncryptionAlgorithm[] algorithms, DateTime timestamp);

	private CmsAttributeTableGenerator AddSecureMimeCapabilities(Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttributes)
	{
		SmimeCapabilitiesAttribute secureMimeCapabilitiesAttribute = GetSecureMimeCapabilitiesAttribute(includeRsaesOaep: true);
		return new DefaultSignedAttributeTableGenerator(signedAttributes.Add(secureMimeCapabilitiesAttribute.AttrType, secureMimeCapabilitiesAttribute.AttrValues[0]));
	}

	private Stream Sign(CmsSigner signer, Stream content, bool encapsulate)
	{
		SimpleAttributeTableGenerator unsignedAttrGenerator = new SimpleAttributeTableGenerator(signer.UnsignedAttributes);
		CmsAttributeTableGenerator signedAttrGenerator = AddSecureMimeCapabilities(signer.SignedAttributes);
		CmsSignedDataStreamGenerator cmsSignedDataStreamGenerator = new CmsSignedDataStreamGenerator();
		string digestOid = SecureMimeContext.GetDigestOid(signer.DigestAlgorithm);
		byte[] array = null;
		if (signer.SignerIdentifierType == SubjectIdentifierType.SubjectKeyIdentifier)
		{
			Asn1OctetString extensionValue = signer.Certificate.GetExtensionValue(X509Extensions.SubjectKeyIdentifier);
			if (extensionValue != null)
			{
				Asn1OctetString asn1OctetString = (Asn1OctetString)Asn1Object.FromByteArray(extensionValue.GetOctets());
				array = asn1OctetString.GetOctets();
			}
		}
		if (signer.PrivateKey is RsaKeyParameters && signer.RsaSignaturePadding == RsaSignaturePadding.Pss)
		{
			if (array == null)
			{
				cmsSignedDataStreamGenerator.AddSigner(signer.PrivateKey, signer.Certificate, RsassaPssOid, digestOid, signedAttrGenerator, unsignedAttrGenerator);
			}
			else
			{
				cmsSignedDataStreamGenerator.AddSigner(signer.PrivateKey, array, RsassaPssOid, digestOid, signedAttrGenerator, unsignedAttrGenerator);
			}
		}
		else if (array == null)
		{
			cmsSignedDataStreamGenerator.AddSigner(signer.PrivateKey, signer.Certificate, digestOid, signedAttrGenerator, unsignedAttrGenerator);
		}
		else
		{
			cmsSignedDataStreamGenerator.AddSigner(signer.PrivateKey, array, digestOid, signedAttrGenerator, unsignedAttrGenerator);
		}
		cmsSignedDataStreamGenerator.AddCertificates(signer.CertificateChain);
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		using (Stream destination = cmsSignedDataStreamGenerator.Open(memoryBlockStream, encapsulate))
		{
			content.CopyTo(destination, 4096);
		}
		memoryBlockStream.Position = 0L;
		return memoryBlockStream;
	}

	public override ApplicationPkcs7Mime EncapsulatedSign(CmsSigner signer, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return new ApplicationPkcs7Mime(SecureMimeType.SignedData, Sign(signer, content, encapsulate: true));
	}

	public override ApplicationPkcs7Mime EncapsulatedSign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		CmsSigner cmsSigner = GetCmsSigner(signer, digestAlgo);
		return EncapsulatedSign(cmsSigner, content);
	}

	public override ApplicationPkcs7Signature Sign(CmsSigner signer, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return new ApplicationPkcs7Signature(Sign(signer, content, encapsulate: false));
	}

	public override MimePart Sign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		CmsSigner cmsSigner = GetCmsSigner(signer, digestAlgo);
		return Sign(cmsSigner, content);
	}

	private X509Certificate GetCertificate(IX509Store store, SignerID signer)
	{
		ICollection matches = store.GetMatches(signer);
		IEnumerator enumerator = matches.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				return (X509Certificate)enumerator.Current;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return GetCertificate(signer);
	}

	protected IList<X509Certificate> BuildCertificateChain(X509Certificate certificate)
	{
		X509CertStoreSelector x509CertStoreSelector = new X509CertStoreSelector();
		x509CertStoreSelector.Certificate = certificate;
		X509CertificateStore x509CertificateStore = new X509CertificateStore();
		x509CertificateStore.Add(certificate);
		PkixBuilderParameters pkixBuilderParameters = new PkixBuilderParameters(GetTrustedAnchors(), x509CertStoreSelector);
		pkixBuilderParameters.ValidityModel = 0;
		pkixBuilderParameters.AddStore(x509CertificateStore);
		pkixBuilderParameters.AddStore(GetIntermediateCertificates());
		pkixBuilderParameters.IsRevocationEnabled = false;
		pkixBuilderParameters.Date = new DateTimeObject(DateTime.UtcNow);
		PkixCertPathBuilder pkixCertPathBuilder = new PkixCertPathBuilder();
		PkixCertPathBuilderResult pkixCertPathBuilderResult = pkixCertPathBuilder.Build(pkixBuilderParameters);
		X509Certificate[] array = new X509Certificate[pkixCertPathBuilderResult.CertPath.Certificates.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (X509Certificate)pkixCertPathBuilderResult.CertPath.Certificates[i];
		}
		return array;
	}

	private PkixCertPath BuildCertPath(HashSet anchors, IX509Store certificates, IX509Store crls, X509Certificate certificate, DateTime signingTime)
	{
		X509CertStoreSelector x509CertStoreSelector = new X509CertStoreSelector();
		x509CertStoreSelector.Certificate = certificate;
		X509CertificateStore x509CertificateStore = new X509CertificateStore();
		x509CertificateStore.Add(certificate);
		foreach (X509Certificate match in certificates.GetMatches(null))
		{
			x509CertificateStore.Add(match);
		}
		PkixBuilderParameters pkixBuilderParameters = new PkixBuilderParameters(anchors, x509CertStoreSelector);
		pkixBuilderParameters.AddStore(x509CertificateStore);
		pkixBuilderParameters.AddStore(crls);
		pkixBuilderParameters.AddStore(GetIntermediateCertificates());
		pkixBuilderParameters.AddStore(GetCertificateRevocationLists());
		pkixBuilderParameters.ValidityModel = 0;
		pkixBuilderParameters.IsRevocationEnabled = false;
		if (signingTime != default(DateTime))
		{
			pkixBuilderParameters.Date = new DateTimeObject(signingTime);
		}
		PkixCertPathBuilder pkixCertPathBuilder = new PkixCertPathBuilder();
		PkixCertPathBuilderResult pkixCertPathBuilderResult = pkixCertPathBuilder.Build(pkixBuilderParameters);
		return pkixCertPathBuilderResult.CertPath;
	}

	protected internal static bool TryGetDigestAlgorithm(AlgorithmIdentifier identifier, out DigestAlgorithm algorithm)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		return SecureMimeContext.TryGetDigestAlgorithm(identifier.Algorithm.Id, out algorithm);
	}

	protected internal static bool TryGetEncryptionAlgorithm(AlgorithmIdentifier identifier, out EncryptionAlgorithm algorithm)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.Aes256Cbc)
		{
			algorithm = EncryptionAlgorithm.Aes256;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.Aes192Cbc)
		{
			algorithm = EncryptionAlgorithm.Aes192;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.Aes128Cbc)
		{
			algorithm = EncryptionAlgorithm.Aes128;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.Camellia256Cbc)
		{
			algorithm = EncryptionAlgorithm.Camellia256;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.Camellia192Cbc)
		{
			algorithm = EncryptionAlgorithm.Camellia192;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.Camellia128Cbc)
		{
			algorithm = EncryptionAlgorithm.Camellia128;
			return true;
		}
		if (identifier.Algorithm.Id == "1.2.840.113533.7.66.10")
		{
			algorithm = EncryptionAlgorithm.Cast5;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.DesEde3Cbc)
		{
			algorithm = EncryptionAlgorithm.TripleDes;
			return true;
		}
		if (identifier.Algorithm.Id == SecureMimeContext.Blowfish.Id)
		{
			algorithm = EncryptionAlgorithm.Blowfish;
			return true;
		}
		if (identifier.Algorithm.Id == SecureMimeContext.Twofish.Id)
		{
			algorithm = EncryptionAlgorithm.Twofish;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.SeedCbc)
		{
			algorithm = EncryptionAlgorithm.Seed;
			return true;
		}
		if (identifier.Algorithm.Id == SmimeCapability.DesCbc.Id)
		{
			algorithm = EncryptionAlgorithm.Des;
			return true;
		}
		if (identifier.Algorithm.Id == "1.3.6.1.4.1.188.7.1.1.2")
		{
			algorithm = EncryptionAlgorithm.Idea;
			return true;
		}
		if (identifier.Algorithm.Id == CmsEnvelopedGenerator.RC2Cbc)
		{
			if (identifier.Parameters is DerSequence)
			{
				DerSequence derSequence = (DerSequence)identifier.Parameters;
				DerInteger derInteger = (DerInteger)derSequence[0];
				switch (derInteger.Value.IntValue)
				{
				case 58:
					algorithm = EncryptionAlgorithm.RC2128;
					return true;
				case 120:
					algorithm = EncryptionAlgorithm.RC264;
					return true;
				case 160:
					algorithm = EncryptionAlgorithm.RC240;
					return true;
				}
			}
			else
			{
				DerInteger derInteger2 = (DerInteger)identifier.Parameters;
				switch (derInteger2.Value.IntValue)
				{
				case 128:
					algorithm = EncryptionAlgorithm.RC2128;
					return true;
				case 64:
					algorithm = EncryptionAlgorithm.RC264;
					return true;
				case 40:
					algorithm = EncryptionAlgorithm.RC240;
					return true;
				}
			}
		}
		algorithm = EncryptionAlgorithm.RC240;
		return false;
	}

	private async Task<bool> DownloadCrlsOverHttpAsync(string location, Stream stream, bool doAsync, CancellationToken cancellationToken)
	{
		_ = 1;
		try
		{
			if (doAsync)
			{
				using HttpResponseMessage response = await client.GetAsync(location, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await response.Content.CopyToAsync(stream).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				cancellationToken.ThrowIfCancellationRequested();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(location);
				using WebResponse webResponse = httpWebRequest.GetResponse();
				Stream responseStream = webResponse.GetResponseStream();
				responseStream.CopyTo(stream, 4096);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private async Task DownloadCrlsAsync(X509Certificate certificate, bool doAsync, CancellationToken cancellationToken)
	{
		DateTime nextCertificateRevocationListUpdate = GetNextCertificateRevocationListUpdate(certificate.IssuerDN);
		DateTime utcNow = DateTime.UtcNow;
		Asn1OctetString extensionValue;
		if (nextCertificateRevocationListUpdate > utcNow || (extensionValue = certificate.GetExtensionValue(X509Extensions.CrlDistributionPoints)) == null)
		{
			return;
		}
		Asn1Object obj = Asn1Object.FromByteArray(extensionValue.GetOctets());
		CrlDistPoint instance = CrlDistPoint.GetInstance(obj);
		DistributionPoint[] points = instance.GetDistributionPoints();
		using MemoryBlockStream stream = new MemoryBlockStream();
		bool flag = false;
		for (int i = 0; i < points.Length; i++)
		{
			GeneralName[] generalNames = GeneralNames.GetInstance(points[i].DistributionPointName.Name).GetNames();
			for (int j = 0; j < generalNames.Length; j++)
			{
				if (flag)
				{
					break;
				}
				if (generalNames[j].TagNo != 6)
				{
					continue;
				}
				string text = DerIA5String.GetInstance(generalNames[j].Name).GetString();
				int num = text.IndexOf(':');
				if (num != -1)
				{
					string text2 = text.Substring(0, num).ToLowerInvariant();
					if (text2 == "https" || text2 == "http")
					{
						flag = await DownloadCrlsOverHttpAsync(text, stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
			}
		}
		if (!flag)
		{
			return;
		}
		stream.Position = 0L;
		X509CrlParser x509CrlParser = new X509CrlParser();
		foreach (X509Crl item in x509CrlParser.ReadCrls(stream))
		{
			Import(item);
		}
	}

	private async Task<DigitalSignatureCollection> GetDigitalSignaturesAsync(CmsSignedDataParser parser, bool doAsync, CancellationToken cancellationToken)
	{
		IX509Store certificates = parser.GetCertificates("Collection");
		List<IDigitalSignature> signatures = new List<IDigitalSignature>();
		IX509Store crls = parser.GetCrls("Collection");
		SignerInformationStore signerInfos = parser.GetSignerInfos();
		foreach (SignerInformation signer in signerInfos.GetSigners())
		{
			X509Certificate certificate = GetCertificate(certificates, signer.SignerID);
			SecureMimeDigitalSignature signature = new SecureMimeDigitalSignature(signer, certificate);
			if (CheckCertificateRevocation && certificate != null)
			{
				await DownloadCrlsAsync(certificate, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (certificate != null)
			{
				Import(certificate);
				if (signature.EncryptionAlgorithms.Length != 0 && signature.CreationDate != default(DateTime))
				{
					UpdateSecureMimeCapabilities(certificate, signature.EncryptionAlgorithms, signature.CreationDate);
				}
			}
			HashSet trustedAnchors = GetTrustedAnchors();
			try
			{
				signature.Chain = BuildCertPath(trustedAnchors, certificates, crls, certificate, signature.CreationDate);
			}
			catch (Exception chainException)
			{
				signature.ChainException = chainException;
			}
			signatures.Add(signature);
		}
		return new DigitalSignatureCollection(signatures);
	}

	public override DigitalSignatureCollection Verify(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (signatureData == null)
		{
			throw new ArgumentNullException("signatureData");
		}
		CmsSignedDataParser cmsSignedDataParser = new CmsSignedDataParser(new CmsTypedStream(content), signatureData);
		CmsTypedStream signedContent = cmsSignedDataParser.GetSignedContent();
		signedContent.Drain();
		return GetDigitalSignaturesAsync(cmsSignedDataParser, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<DigitalSignatureCollection> VerifyAsync(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (signatureData == null)
		{
			throw new ArgumentNullException("signatureData");
		}
		CmsSignedDataParser cmsSignedDataParser = new CmsSignedDataParser(new CmsTypedStream(content), signatureData);
		CmsTypedStream signedContent = cmsSignedDataParser.GetSignedContent();
		signedContent.Drain();
		return GetDigitalSignaturesAsync(cmsSignedDataParser, doAsync: true, cancellationToken);
	}

	public override DigitalSignatureCollection Verify(Stream signedData, out MimeEntity entity, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (signedData == null)
		{
			throw new ArgumentNullException("signedData");
		}
		CmsSignedDataParser cmsSignedDataParser = new CmsSignedDataParser(signedData);
		CmsTypedStream signedContent = cmsSignedDataParser.GetSignedContent();
		entity = MimeEntity.Load(signedContent.ContentStream, cancellationToken);
		signedContent.Drain();
		return GetDigitalSignaturesAsync(cmsSignedDataParser, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Stream Verify(Stream signedData, out DigitalSignatureCollection signatures, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (signedData == null)
		{
			throw new ArgumentNullException("signedData");
		}
		CmsSignedDataParser cmsSignedDataParser = new CmsSignedDataParser(signedData);
		CmsTypedStream signedContent = cmsSignedDataParser.GetSignedContent();
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		signedContent.ContentStream.CopyTo(memoryBlockStream, 4096);
		memoryBlockStream.Position = 0L;
		signedContent.Drain();
		signatures = GetDigitalSignaturesAsync(cmsSignedDataParser, doAsync: false, cancellationToken).GetAwaiter().GetResult();
		return memoryBlockStream;
	}

	private Stream Envelope(CmsRecipientCollection recipients, Stream content)
	{
		HashSet<X509Certificate> hashSet = new HashSet<X509Certificate>();
		CmsEnvelopedDataGenerator cmsEnvelopedDataGenerator = new CmsEnvelopedDataGenerator();
		int num = 0;
		foreach (CmsRecipient recipient in recipients)
		{
			if (hashSet.Add(recipient.Certificate))
			{
				cmsEnvelopedDataGenerator.AddRecipientInfoGenerator(new CmsRecipientInfoGenerator(recipient));
				num++;
			}
		}
		if (num == 0)
		{
			throw new ArgumentException("No recipients specified.", "recipients");
		}
		EncryptionAlgorithm preferredEncryptionAlgorithm = GetPreferredEncryptionAlgorithm(recipients);
		CmsProcessableInputStream content2 = new CmsProcessableInputStream(content);
		return new MemoryStream((preferredEncryptionAlgorithm switch
		{
			EncryptionAlgorithm.Aes128 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.Aes128Cbc), 
			EncryptionAlgorithm.Aes192 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.Aes192Cbc), 
			EncryptionAlgorithm.Aes256 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.Aes256Cbc), 
			EncryptionAlgorithm.Blowfish => cmsEnvelopedDataGenerator.Generate(content2, SecureMimeContext.Blowfish.Id), 
			EncryptionAlgorithm.Camellia128 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.Camellia128Cbc), 
			EncryptionAlgorithm.Camellia192 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.Camellia192Cbc), 
			EncryptionAlgorithm.Camellia256 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.Camellia256Cbc), 
			EncryptionAlgorithm.Cast5 => cmsEnvelopedDataGenerator.Generate(content2, "1.2.840.113533.7.66.10"), 
			EncryptionAlgorithm.Des => cmsEnvelopedDataGenerator.Generate(content2, SmimeCapability.DesCbc.Id), 
			EncryptionAlgorithm.Idea => cmsEnvelopedDataGenerator.Generate(content2, "1.3.6.1.4.1.188.7.1.1.2"), 
			EncryptionAlgorithm.RC240 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.RC2Cbc, 40), 
			EncryptionAlgorithm.RC264 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.RC2Cbc, 64), 
			EncryptionAlgorithm.RC2128 => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.RC2Cbc, 128), 
			EncryptionAlgorithm.Seed => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.SeedCbc), 
			EncryptionAlgorithm.TripleDes => cmsEnvelopedDataGenerator.Generate(content2, CmsEnvelopedGenerator.DesEde3Cbc), 
			_ => throw new NotSupportedException($"The {preferredEncryptionAlgorithm} encryption algorithm is not supported by the {GetType().Name}."), 
		}).GetEncoded(), writable: false);
	}

	public override ApplicationPkcs7Mime Encrypt(CmsRecipientCollection recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return new ApplicationPkcs7Mime(SecureMimeType.EnvelopedData, Envelope(recipients, content));
	}

	public override MimePart Encrypt(IEnumerable<MailboxAddress> recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return Encrypt(GetCmsRecipients(recipients), content);
	}

	public override MimeEntity Decrypt(Stream encryptedData, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (encryptedData == null)
		{
			throw new ArgumentNullException("encryptedData");
		}
		CmsEnvelopedDataParser cmsEnvelopedDataParser = new CmsEnvelopedDataParser(encryptedData);
		RecipientInformationStore recipientInfos = cmsEnvelopedDataParser.GetRecipientInfos();
		AlgorithmIdentifier encryptionAlgorithmID = cmsEnvelopedDataParser.EncryptionAlgorithmID;
		foreach (RecipientInformation recipient in recipientInfos.GetRecipients())
		{
			AsymmetricKeyParameter privateKey;
			if ((privateKey = GetPrivateKey(recipient.RecipientID)) != null)
			{
				byte[] content = recipient.GetContent(privateKey);
				MemoryStream stream = new MemoryStream(content, writable: false);
				return MimeEntity.Load(stream, persistent: true, cancellationToken);
			}
		}
		throw new CmsException("A suitable private key could not be found for decrypting.");
	}

	public override void DecryptTo(Stream encryptedData, Stream decryptedData)
	{
		if (encryptedData == null)
		{
			throw new ArgumentNullException("encryptedData");
		}
		if (decryptedData == null)
		{
			throw new ArgumentNullException("decryptedData");
		}
		CmsEnvelopedDataParser cmsEnvelopedDataParser = new CmsEnvelopedDataParser(encryptedData);
		RecipientInformationStore recipientInfos = cmsEnvelopedDataParser.GetRecipientInfos();
		AlgorithmIdentifier encryptionAlgorithmID = cmsEnvelopedDataParser.EncryptionAlgorithmID;
		foreach (RecipientInformation recipient in recipientInfos.GetRecipients())
		{
			AsymmetricKeyParameter privateKey;
			if ((privateKey = GetPrivateKey(recipient.RecipientID)) != null)
			{
				CmsTypedStream contentStream = recipient.GetContentStream(privateKey);
				contentStream.ContentStream.CopyTo(decryptedData, 4096);
				return;
			}
		}
		throw new CmsException("A suitable private key could not be found for decrypting.");
	}

	public override MimePart Export(IEnumerable<MailboxAddress> mailboxes)
	{
		if (mailboxes == null)
		{
			throw new ArgumentNullException("mailboxes");
		}
		X509CertificateStore x509CertificateStore = new X509CertificateStore();
		int num = 0;
		foreach (MailboxAddress mailbox in mailboxes)
		{
			CmsRecipient cmsRecipient = GetCmsRecipient(mailbox);
			x509CertificateStore.Add(cmsRecipient.Certificate);
			num++;
		}
		if (num == 0)
		{
			throw new ArgumentException("No mailboxes specified.", "mailboxes");
		}
		CmsSignedDataStreamGenerator cmsSignedDataStreamGenerator = new CmsSignedDataStreamGenerator();
		cmsSignedDataStreamGenerator.AddCertificates(x509CertificateStore);
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		cmsSignedDataStreamGenerator.Open(memoryBlockStream).Dispose();
		memoryBlockStream.Position = 0L;
		return new ApplicationPkcs7Mime(SecureMimeType.CertsOnly, memoryBlockStream);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && client != null)
		{
			client.Dispose();
			client = null;
		}
		base.Dispose(disposing);
	}
}
