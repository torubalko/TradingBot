using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Ess;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Tsp;

public class TimeStampTokenGenerator
{
	private class TableGen : CmsAttributeTableGenerator
	{
		private readonly SignerInfoGenerator infoGen;

		private readonly EssCertID essCertID;

		public TableGen(SignerInfoGenerator infoGen, EssCertID essCertID)
		{
			this.infoGen = infoGen;
			this.essCertID = essCertID;
		}

		public Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(IDictionary parameters)
		{
			Org.BouncyCastle.Asn1.Cms.AttributeTable tab = infoGen.signedGen.GetAttributes(parameters);
			if (tab[PkcsObjectIdentifiers.IdAASigningCertificate] == null)
			{
				return tab.Add(PkcsObjectIdentifiers.IdAASigningCertificate, new SigningCertificate(essCertID));
			}
			return tab;
		}
	}

	private class TableGen2 : CmsAttributeTableGenerator
	{
		private readonly SignerInfoGenerator infoGen;

		private readonly EssCertIDv2 essCertID;

		public TableGen2(SignerInfoGenerator infoGen, EssCertIDv2 essCertID)
		{
			this.infoGen = infoGen;
			this.essCertID = essCertID;
		}

		public Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(IDictionary parameters)
		{
			Org.BouncyCastle.Asn1.Cms.AttributeTable tab = infoGen.signedGen.GetAttributes(parameters);
			if (tab[PkcsObjectIdentifiers.IdAASigningCertificateV2] == null)
			{
				return tab.Add(PkcsObjectIdentifiers.IdAASigningCertificateV2, new SigningCertificateV2(essCertID));
			}
			return tab;
		}
	}

	private int accuracySeconds = -1;

	private int accuracyMillis = -1;

	private int accuracyMicros = -1;

	private bool ordering;

	private GeneralName tsa;

	private DerObjectIdentifier tsaPolicyOID;

	private IX509Store x509Certs;

	private IX509Store x509Crls;

	private SignerInfoGenerator signerInfoGenerator;

	private IDigestFactory digestCalculator;

	private Resolution resolution;

	public Resolution Resolution
	{
		get
		{
			return resolution;
		}
		set
		{
			resolution = value;
		}
	}

	public TimeStampTokenGenerator(AsymmetricKeyParameter key, X509Certificate cert, string digestOID, string tsaPolicyOID)
		: this(key, cert, digestOID, tsaPolicyOID, null, null)
	{
	}

	public TimeStampTokenGenerator(SignerInfoGenerator signerInfoGen, IDigestFactory digestCalculator, DerObjectIdentifier tsaPolicy, bool isIssuerSerialIncluded)
	{
		signerInfoGenerator = signerInfoGen;
		this.digestCalculator = digestCalculator;
		tsaPolicyOID = tsaPolicy;
		if (signerInfoGenerator.certificate == null)
		{
			throw new ArgumentException("SignerInfoGenerator must have an associated certificate");
		}
		X509Certificate assocCert = signerInfoGenerator.certificate;
		TspUtil.ValidateCertificate(assocCert);
		try
		{
			IStreamCalculator calculator = digestCalculator.CreateCalculator();
			Stream stream = calculator.Stream;
			byte[] certEnc = assocCert.GetEncoded();
			stream.Write(certEnc, 0, certEnc.Length);
			stream.Flush();
			Platform.Dispose(stream);
			if (((AlgorithmIdentifier)digestCalculator.AlgorithmDetails).Algorithm.Equals(OiwObjectIdentifiers.IdSha1))
			{
				EssCertID essCertID = new EssCertID(((IBlockResult)calculator.GetResult()).Collect(), isIssuerSerialIncluded ? new IssuerSerial(new GeneralNames(new GeneralName(assocCert.IssuerDN)), new DerInteger(assocCert.SerialNumber)) : null);
				signerInfoGenerator = signerInfoGen.NewBuilder().WithSignedAttributeGenerator(new TableGen(signerInfoGen, essCertID)).Build(signerInfoGen.contentSigner, signerInfoGen.certificate);
			}
			else
			{
				new AlgorithmIdentifier(((AlgorithmIdentifier)digestCalculator.AlgorithmDetails).Algorithm);
				EssCertIDv2 essCertID2 = new EssCertIDv2(((IBlockResult)calculator.GetResult()).Collect(), isIssuerSerialIncluded ? new IssuerSerial(new GeneralNames(new GeneralName(assocCert.IssuerDN)), new DerInteger(assocCert.SerialNumber)) : null);
				signerInfoGenerator = signerInfoGen.NewBuilder().WithSignedAttributeGenerator(new TableGen2(signerInfoGen, essCertID2)).Build(signerInfoGen.contentSigner, signerInfoGen.certificate);
			}
		}
		catch (Exception e)
		{
			throw new TspException("Exception processing certificate", e);
		}
	}

	public TimeStampTokenGenerator(AsymmetricKeyParameter key, X509Certificate cert, string digestOID, string tsaPolicyOID, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		: this(makeInfoGenerator(key, cert, digestOID, signedAttr, unsignedAttr), Asn1DigestFactory.Get(OiwObjectIdentifiers.IdSha1), (tsaPolicyOID != null) ? new DerObjectIdentifier(tsaPolicyOID) : null, isIssuerSerialIncluded: false)
	{
	}

	internal static SignerInfoGenerator makeInfoGenerator(AsymmetricKeyParameter key, X509Certificate cert, string digestOID, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
		TspUtil.ValidateCertificate(cert);
		IDictionary signedAttrs = ((signedAttr == null) ? Platform.CreateHashtable() : signedAttr.ToDictionary());
		Asn1SignatureFactory sigfact = new Asn1SignatureFactory(CmsSignedHelper.Instance.GetDigestAlgName(digestOID) + "with" + CmsSignedHelper.Instance.GetEncryptionAlgName(CmsSignedHelper.Instance.GetEncOid(key, digestOID)), key);
		return new SignerInfoGeneratorBuilder().WithSignedAttributeGenerator(new DefaultSignedAttributeTableGenerator(new Org.BouncyCastle.Asn1.Cms.AttributeTable(signedAttrs))).WithUnsignedAttributeGenerator(new SimpleAttributeTableGenerator(unsignedAttr)).Build(sigfact, cert);
	}

	public void SetCertificates(IX509Store certificates)
	{
		x509Certs = certificates;
	}

	public void SetCrls(IX509Store crls)
	{
		x509Crls = crls;
	}

	public void SetAccuracySeconds(int accuracySeconds)
	{
		this.accuracySeconds = accuracySeconds;
	}

	public void SetAccuracyMillis(int accuracyMillis)
	{
		this.accuracyMillis = accuracyMillis;
	}

	public void SetAccuracyMicros(int accuracyMicros)
	{
		this.accuracyMicros = accuracyMicros;
	}

	public void SetOrdering(bool ordering)
	{
		this.ordering = ordering;
	}

	public void SetTsa(GeneralName tsa)
	{
		this.tsa = tsa;
	}

	public TimeStampToken Generate(TimeStampRequest request, BigInteger serialNumber, DateTime genTime)
	{
		return Generate(request, serialNumber, genTime, null);
	}

	public TimeStampToken Generate(TimeStampRequest request, BigInteger serialNumber, DateTime genTime, X509Extensions additionalExtensions)
	{
		MessageImprint messageImprint = new MessageImprint(new AlgorithmIdentifier(new DerObjectIdentifier(request.MessageImprintAlgOid), DerNull.Instance), request.GetMessageImprintDigest());
		Accuracy accuracy = null;
		if (accuracySeconds > 0 || accuracyMillis > 0 || accuracyMicros > 0)
		{
			DerInteger seconds = null;
			if (accuracySeconds > 0)
			{
				seconds = new DerInteger(accuracySeconds);
			}
			DerInteger millis = null;
			if (accuracyMillis > 0)
			{
				millis = new DerInteger(accuracyMillis);
			}
			DerInteger micros = null;
			if (accuracyMicros > 0)
			{
				micros = new DerInteger(accuracyMicros);
			}
			accuracy = new Accuracy(seconds, millis, micros);
		}
		DerBoolean derOrdering = null;
		if (ordering)
		{
			derOrdering = DerBoolean.GetInstance(ordering);
		}
		DerInteger nonce = null;
		if (request.Nonce != null)
		{
			nonce = new DerInteger(request.Nonce);
		}
		DerObjectIdentifier tsaPolicy = tsaPolicyOID;
		if (request.ReqPolicy != null)
		{
			tsaPolicy = new DerObjectIdentifier(request.ReqPolicy);
		}
		if (tsaPolicy == null)
		{
			throw new TspValidationException("request contains no policy", 256);
		}
		X509Extensions respExtensions = request.Extensions;
		if (additionalExtensions != null)
		{
			X509ExtensionsGenerator extGen = new X509ExtensionsGenerator();
			if (respExtensions != null)
			{
				foreach (object extensionOid in respExtensions.ExtensionOids)
				{
					DerObjectIdentifier id = DerObjectIdentifier.GetInstance(extensionOid);
					extGen.AddExtension(id, respExtensions.GetExtension(DerObjectIdentifier.GetInstance(id)));
				}
			}
			foreach (object extensionOid2 in additionalExtensions.ExtensionOids)
			{
				DerObjectIdentifier id2 = DerObjectIdentifier.GetInstance(extensionOid2);
				extGen.AddExtension(id2, additionalExtensions.GetExtension(DerObjectIdentifier.GetInstance(id2)));
			}
			respExtensions = extGen.Generate();
		}
		TstInfo tstInfo = new TstInfo(genTime: (resolution == Resolution.R_SECONDS) ? new DerGeneralizedTime(genTime) : new DerGeneralizedTime(createGeneralizedTime(genTime)), tsaPolicyId: tsaPolicy, messageImprint: messageImprint, serialNumber: new DerInteger(serialNumber), accuracy: accuracy, ordering: derOrdering, nonce: nonce, tsa: tsa, extensions: respExtensions);
		try
		{
			CmsSignedDataGenerator signedDataGenerator = new CmsSignedDataGenerator();
			byte[] derEncodedTstInfo = tstInfo.GetDerEncoded();
			if (request.CertReq)
			{
				signedDataGenerator.AddCertificates(x509Certs);
			}
			signedDataGenerator.AddCrls(x509Crls);
			signedDataGenerator.AddSignerInfoGenerator(signerInfoGenerator);
			return new TimeStampToken(signedDataGenerator.Generate(PkcsObjectIdentifiers.IdCTTstInfo.Id, new CmsProcessableByteArray(derEncodedTstInfo), encapsulate: true));
		}
		catch (CmsException e)
		{
			throw new TspException("Error generating time-stamp token", e);
		}
		catch (IOException e2)
		{
			throw new TspException("Exception encoding info", e2);
		}
		catch (X509StoreException e3)
		{
			throw new TspException("Exception handling CertStore", e3);
		}
	}

	private string createGeneralizedTime(DateTime genTime)
	{
		string format = "yyyyMMddHHmmss.fff";
		StringBuilder sBuild = new StringBuilder(genTime.ToString(format));
		int dotIndex = sBuild.ToString().IndexOf(".");
		if (dotIndex < 0)
		{
			sBuild.Append("Z");
			return sBuild.ToString();
		}
		switch (resolution)
		{
		case Resolution.R_TENTHS_OF_SECONDS:
			if (sBuild.Length > dotIndex + 2)
			{
				sBuild.Remove(dotIndex + 2, sBuild.Length - (dotIndex + 2));
			}
			break;
		case Resolution.R_HUNDREDTHS_OF_SECONDS:
			if (sBuild.Length > dotIndex + 3)
			{
				sBuild.Remove(dotIndex + 3, sBuild.Length - (dotIndex + 3));
			}
			break;
		}
		while (sBuild[sBuild.Length - 1] == '0')
		{
			sBuild.Remove(sBuild.Length - 1, 1);
		}
		if (sBuild.Length - 1 == dotIndex)
		{
			sBuild.Remove(sBuild.Length - 1, 1);
		}
		sBuild.Append("Z");
		return sBuild.ToString();
	}
}
