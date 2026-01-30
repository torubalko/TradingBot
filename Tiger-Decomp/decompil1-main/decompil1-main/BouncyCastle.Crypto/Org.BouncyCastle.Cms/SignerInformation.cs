using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms;

public class SignerInformation
{
	private static readonly CmsSignedHelper Helper = CmsSignedHelper.Instance;

	private SignerID sid;

	private CmsProcessable content;

	private byte[] signature;

	private DerObjectIdentifier contentType;

	private byte[] calculatedDigest;

	private byte[] resultDigest;

	private Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttributeTable;

	private Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable;

	private readonly bool isCounterSignature;

	protected Org.BouncyCastle.Asn1.Cms.SignerInfo info;

	protected AlgorithmIdentifier digestAlgorithm;

	protected AlgorithmIdentifier encryptionAlgorithm;

	protected readonly Asn1Set signedAttributeSet;

	protected readonly Asn1Set unsignedAttributeSet;

	public bool IsCounterSignature => isCounterSignature;

	public DerObjectIdentifier ContentType => contentType;

	public SignerID SignerID => sid;

	public int Version => info.Version.IntValueExact;

	public AlgorithmIdentifier DigestAlgorithmID => digestAlgorithm;

	public string DigestAlgOid => digestAlgorithm.Algorithm.Id;

	public Asn1Object DigestAlgParams => digestAlgorithm.Parameters?.ToAsn1Object();

	public AlgorithmIdentifier EncryptionAlgorithmID => encryptionAlgorithm;

	public string EncryptionAlgOid => encryptionAlgorithm.Algorithm.Id;

	public Asn1Object EncryptionAlgParams => encryptionAlgorithm.Parameters?.ToAsn1Object();

	public Org.BouncyCastle.Asn1.Cms.AttributeTable SignedAttributes
	{
		get
		{
			if (signedAttributeSet != null && signedAttributeTable == null)
			{
				signedAttributeTable = new Org.BouncyCastle.Asn1.Cms.AttributeTable(signedAttributeSet);
			}
			return signedAttributeTable;
		}
	}

	public Org.BouncyCastle.Asn1.Cms.AttributeTable UnsignedAttributes
	{
		get
		{
			if (unsignedAttributeSet != null && unsignedAttributeTable == null)
			{
				unsignedAttributeTable = new Org.BouncyCastle.Asn1.Cms.AttributeTable(unsignedAttributeSet);
			}
			return unsignedAttributeTable;
		}
	}

	internal SignerInformation(Org.BouncyCastle.Asn1.Cms.SignerInfo info, DerObjectIdentifier contentType, CmsProcessable content, IDigestCalculator digestCalculator)
	{
		this.info = info;
		sid = new SignerID();
		this.contentType = contentType;
		isCounterSignature = contentType == null;
		try
		{
			SignerIdentifier s = info.SignerID;
			if (s.IsTagged)
			{
				Asn1OctetString octs = Asn1OctetString.GetInstance(s.ID);
				sid.SubjectKeyIdentifier = octs.GetEncoded();
			}
			else
			{
				Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber iAnds = Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber.GetInstance(s.ID);
				sid.Issuer = iAnds.Name;
				sid.SerialNumber = iAnds.SerialNumber.Value;
			}
		}
		catch (IOException)
		{
			throw new ArgumentException("invalid sid in SignerInfo");
		}
		digestAlgorithm = info.DigestAlgorithm;
		signedAttributeSet = info.AuthenticatedAttributes;
		unsignedAttributeSet = info.UnauthenticatedAttributes;
		encryptionAlgorithm = info.DigestEncryptionAlgorithm;
		signature = (byte[])info.EncryptedDigest.GetOctets().Clone();
		this.content = content;
		calculatedDigest = digestCalculator?.GetDigest();
	}

	protected SignerInformation(SignerInformation baseInfo)
	{
		info = baseInfo.info;
		content = baseInfo.content;
		contentType = baseInfo.contentType;
		isCounterSignature = baseInfo.IsCounterSignature;
		sid = baseInfo.sid;
		digestAlgorithm = info.DigestAlgorithm;
		signedAttributeSet = info.AuthenticatedAttributes;
		unsignedAttributeSet = info.UnauthenticatedAttributes;
		encryptionAlgorithm = info.DigestEncryptionAlgorithm;
		signature = (byte[])info.EncryptedDigest.GetOctets().Clone();
		calculatedDigest = baseInfo.calculatedDigest;
		signedAttributeTable = baseInfo.signedAttributeTable;
		unsignedAttributeTable = baseInfo.unsignedAttributeTable;
	}

	public byte[] GetContentDigest()
	{
		if (resultDigest == null)
		{
			throw new InvalidOperationException("method can only be called after verify.");
		}
		return (byte[])resultDigest.Clone();
	}

	public byte[] GetSignature()
	{
		return (byte[])signature.Clone();
	}

	public SignerInformationStore GetCounterSignatures()
	{
		Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable = UnsignedAttributes;
		if (unsignedAttributeTable == null)
		{
			return new SignerInformationStore(Platform.CreateArrayList(0));
		}
		IList counterSignatures = Platform.CreateArrayList();
		foreach (Org.BouncyCastle.Asn1.Cms.Attribute item in unsignedAttributeTable.GetAll(CmsAttributes.CounterSignature))
		{
			Asn1Set attrValues = item.AttrValues;
			_ = attrValues.Count;
			_ = 1;
			foreach (Asn1Encodable item2 in attrValues)
			{
				Org.BouncyCastle.Asn1.Cms.SignerInfo si = Org.BouncyCastle.Asn1.Cms.SignerInfo.GetInstance(item2.ToAsn1Object());
				string digestName = CmsSignedHelper.Instance.GetDigestAlgName(si.DigestAlgorithm.Algorithm.Id);
				counterSignatures.Add(new SignerInformation(si, null, null, new CounterSignatureDigestCalculator(digestName, GetSignature())));
			}
		}
		return new SignerInformationStore(counterSignatures);
	}

	public virtual byte[] GetEncodedSignedAttributes()
	{
		if (signedAttributeSet != null)
		{
			return signedAttributeSet.GetEncoded("DER");
		}
		return null;
	}

	private bool DoVerify(AsymmetricKeyParameter key)
	{
		DerObjectIdentifier sigAlgOid = encryptionAlgorithm.Algorithm;
		Asn1Encodable sigParams = encryptionAlgorithm.Parameters;
		string digestName = Helper.GetDigestAlgName(EncryptionAlgOid);
		if (digestName.Equals(sigAlgOid.Id))
		{
			digestName = Helper.GetDigestAlgName(DigestAlgOid);
		}
		IDigest digest = Helper.GetDigestInstance(digestName);
		ISigner sig;
		if (sigAlgOid.Equals(PkcsObjectIdentifiers.IdRsassaPss))
		{
			if (sigParams == null)
			{
				throw new CmsException("RSASSA-PSS signature must specify algorithm parameters");
			}
			try
			{
				RsassaPssParameters pss = RsassaPssParameters.GetInstance(sigParams.ToAsn1Object());
				if (!pss.HashAlgorithm.Algorithm.Equals(digestAlgorithm.Algorithm))
				{
					throw new CmsException("RSASSA-PSS signature parameters specified incorrect hash algorithm");
				}
				if (!pss.MaskGenAlgorithm.Algorithm.Equals(PkcsObjectIdentifiers.IdMgf1))
				{
					throw new CmsException("RSASSA-PSS signature parameters specified unknown MGF");
				}
				IDigest pssDigest = DigestUtilities.GetDigest(pss.HashAlgorithm.Algorithm);
				int saltLength = pss.SaltLength.IntValueExact;
				if (!RsassaPssParameters.DefaultTrailerField.Equals(pss.TrailerField))
				{
					throw new CmsException("RSASSA-PSS signature parameters must have trailerField of 1");
				}
				IAsymmetricBlockCipher rsa = new RsaBlindedEngine();
				sig = ((signedAttributeSet != null || calculatedDigest == null) ? new PssSigner(rsa, pssDigest, saltLength) : PssSigner.CreateRawSigner(rsa, pssDigest, pssDigest, saltLength, 188));
			}
			catch (Exception e)
			{
				throw new CmsException("failed to set RSASSA-PSS signature parameters", e);
			}
		}
		else
		{
			string signatureName = digestName + "with" + Helper.GetEncryptionAlgName(EncryptionAlgOid);
			sig = Helper.GetSignatureInstance(signatureName);
		}
		try
		{
			if (calculatedDigest != null)
			{
				resultDigest = calculatedDigest;
			}
			else
			{
				if (content != null)
				{
					content.Write(new DigestSink(digest));
				}
				else if (signedAttributeSet == null)
				{
					throw new CmsException("data not encapsulated in signature - use detached constructor.");
				}
				resultDigest = DigestUtilities.DoFinal(digest);
			}
		}
		catch (IOException e2)
		{
			throw new CmsException("can't process mime object to create signature.", e2);
		}
		Asn1Object validContentType = GetSingleValuedSignedAttribute(CmsAttributes.ContentType, "content-type");
		if (validContentType == null)
		{
			if (!isCounterSignature && signedAttributeSet != null)
			{
				throw new CmsException("The content-type attribute type MUST be present whenever signed attributes are present in signed-data");
			}
		}
		else
		{
			if (isCounterSignature)
			{
				throw new CmsException("[For counter signatures,] the signedAttributes field MUST NOT contain a content-type attribute");
			}
			if (!(validContentType is DerObjectIdentifier))
			{
				throw new CmsException("content-type attribute value not of ASN.1 type 'OBJECT IDENTIFIER'");
			}
			if (!((DerObjectIdentifier)validContentType).Equals(contentType))
			{
				throw new CmsException("content-type attribute value does not match eContentType");
			}
		}
		Asn1Object validMessageDigest = GetSingleValuedSignedAttribute(CmsAttributes.MessageDigest, "message-digest");
		if (validMessageDigest == null)
		{
			if (signedAttributeSet != null)
			{
				throw new CmsException("the message-digest signed attribute type MUST be present when there are any signed attributes present");
			}
		}
		else
		{
			if (!(validMessageDigest is Asn1OctetString))
			{
				throw new CmsException("message-digest attribute value not of ASN.1 type 'OCTET STRING'");
			}
			Asn1OctetString signedMessageDigest = (Asn1OctetString)validMessageDigest;
			if (!Arrays.AreEqual(resultDigest, signedMessageDigest.GetOctets()))
			{
				throw new CmsException("message-digest attribute value does not match calculated value");
			}
		}
		Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttrTable = SignedAttributes;
		if (signedAttrTable != null && signedAttrTable.GetAll(CmsAttributes.CounterSignature).Count > 0)
		{
			throw new CmsException("A countersignature attribute MUST NOT be a signed attribute");
		}
		Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttrTable = UnsignedAttributes;
		if (unsignedAttrTable != null)
		{
			foreach (Org.BouncyCastle.Asn1.Cms.Attribute item in unsignedAttrTable.GetAll(CmsAttributes.CounterSignature))
			{
				if (item.AttrValues.Count < 1)
				{
					throw new CmsException("A countersignature attribute MUST contain at least one AttributeValue");
				}
			}
		}
		try
		{
			sig.Init(forSigning: false, key);
			if (signedAttributeSet == null)
			{
				if (calculatedDigest != null)
				{
					if (!(sig is PssSigner))
					{
						return VerifyDigest(resultDigest, key, GetSignature());
					}
					sig.BlockUpdate(resultDigest, 0, resultDigest.Length);
				}
				else if (content != null)
				{
					try
					{
						content.Write(new SignerSink(sig));
					}
					catch (SignatureException ex)
					{
						throw new CmsStreamException("signature problem: " + ex);
					}
				}
			}
			else
			{
				byte[] tmp = GetEncodedSignedAttributes();
				sig.BlockUpdate(tmp, 0, tmp.Length);
			}
			return sig.VerifySignature(GetSignature());
		}
		catch (InvalidKeyException e3)
		{
			throw new CmsException("key not appropriate to signature in message.", e3);
		}
		catch (IOException e4)
		{
			throw new CmsException("can't process mime object to create signature.", e4);
		}
		catch (SignatureException ex2)
		{
			throw new CmsException("invalid signature format in message: " + ex2.Message, ex2);
		}
	}

	private bool IsNull(Asn1Encodable o)
	{
		if (!(o is Asn1Null))
		{
			return o == null;
		}
		return true;
	}

	private DigestInfo DerDecode(byte[] encoding)
	{
		if (encoding[0] != 48)
		{
			throw new IOException("not a digest info object");
		}
		DigestInfo instance = DigestInfo.GetInstance(Asn1Object.FromByteArray(encoding));
		if (instance.GetEncoded().Length != encoding.Length)
		{
			throw new CmsException("malformed RSA signature");
		}
		return instance;
	}

	private bool VerifyDigest(byte[] digest, AsymmetricKeyParameter key, byte[] signature)
	{
		string algorithm = Helper.GetEncryptionAlgName(EncryptionAlgOid);
		try
		{
			if (algorithm.Equals("RSA"))
			{
				IBufferedCipher bufferedCipher = CmsEnvelopedHelper.Instance.CreateAsymmetricCipher("RSA/ECB/PKCS1Padding");
				bufferedCipher.Init(forEncryption: false, key);
				byte[] decrypt = bufferedCipher.DoFinal(signature);
				DigestInfo digInfo = DerDecode(decrypt);
				if (!digInfo.AlgorithmID.Algorithm.Equals(digestAlgorithm.Algorithm))
				{
					return false;
				}
				if (!IsNull(digInfo.AlgorithmID.Parameters))
				{
					return false;
				}
				byte[] sigHash = digInfo.GetDigest();
				return Arrays.ConstantTimeAreEqual(digest, sigHash);
			}
			if (algorithm.Equals("DSA"))
			{
				ISigner signer = SignerUtilities.GetSigner("NONEwithDSA");
				signer.Init(forSigning: false, key);
				signer.BlockUpdate(digest, 0, digest.Length);
				return signer.VerifySignature(signature);
			}
			throw new CmsException("algorithm: " + algorithm + " not supported in base signatures.");
		}
		catch (SecurityUtilityException ex)
		{
			throw ex;
		}
		catch (GeneralSecurityException ex2)
		{
			throw new CmsException("Exception processing signature: " + ex2, ex2);
		}
		catch (IOException ex3)
		{
			throw new CmsException("Exception decoding signature: " + ex3, ex3);
		}
	}

	public bool Verify(AsymmetricKeyParameter pubKey)
	{
		if (pubKey.IsPrivate)
		{
			throw new ArgumentException("Expected public key", "pubKey");
		}
		GetSigningTime();
		return DoVerify(pubKey);
	}

	public bool Verify(X509Certificate cert)
	{
		Org.BouncyCastle.Asn1.Cms.Time signingTime = GetSigningTime();
		if (signingTime != null)
		{
			cert.CheckValidity(signingTime.Date);
		}
		return DoVerify(cert.GetPublicKey());
	}

	public Org.BouncyCastle.Asn1.Cms.SignerInfo ToSignerInfo()
	{
		return info;
	}

	private Asn1Object GetSingleValuedSignedAttribute(DerObjectIdentifier attrOID, string printableName)
	{
		Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttrTable = UnsignedAttributes;
		if (unsignedAttrTable != null && unsignedAttrTable.GetAll(attrOID).Count > 0)
		{
			throw new CmsException("The " + printableName + " attribute MUST NOT be an unsigned attribute");
		}
		Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttrTable = SignedAttributes;
		if (signedAttrTable == null)
		{
			return null;
		}
		Asn1EncodableVector v = signedAttrTable.GetAll(attrOID);
		switch (v.Count)
		{
		case 0:
			return null;
		case 1:
		{
			Asn1Set attrValues = ((Org.BouncyCastle.Asn1.Cms.Attribute)v[0]).AttrValues;
			if (attrValues.Count != 1)
			{
				throw new CmsException("A " + printableName + " attribute MUST have a single attribute value");
			}
			return attrValues[0].ToAsn1Object();
		}
		default:
			throw new CmsException("The SignedAttributes in a signerInfo MUST NOT include multiple instances of the " + printableName + " attribute");
		}
	}

	private Org.BouncyCastle.Asn1.Cms.Time GetSigningTime()
	{
		Asn1Object validSigningTime = GetSingleValuedSignedAttribute(CmsAttributes.SigningTime, "signing-time");
		if (validSigningTime == null)
		{
			return null;
		}
		try
		{
			return Org.BouncyCastle.Asn1.Cms.Time.GetInstance(validSigningTime);
		}
		catch (ArgumentException)
		{
			throw new CmsException("signing-time attribute value not a valid 'Time' structure");
		}
	}

	public static SignerInformation ReplaceUnsignedAttributes(SignerInformation signerInformation, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributes)
	{
		Org.BouncyCastle.Asn1.Cms.SignerInfo sInfo = signerInformation.info;
		Asn1Set unsignedAttr = null;
		if (unsignedAttributes != null)
		{
			unsignedAttr = new DerSet(unsignedAttributes.ToAsn1EncodableVector());
		}
		return new SignerInformation(new Org.BouncyCastle.Asn1.Cms.SignerInfo(sInfo.SignerID, sInfo.DigestAlgorithm, sInfo.AuthenticatedAttributes, sInfo.DigestEncryptionAlgorithm, sInfo.EncryptedDigest, unsignedAttr), signerInformation.contentType, signerInformation.content, null);
	}

	public static SignerInformation AddCounterSigners(SignerInformation signerInformation, SignerInformationStore counterSigners)
	{
		Org.BouncyCastle.Asn1.Cms.SignerInfo sInfo = signerInformation.info;
		Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr = signerInformation.UnsignedAttributes;
		Asn1EncodableVector v = ((unsignedAttr == null) ? new Asn1EncodableVector() : unsignedAttr.ToAsn1EncodableVector());
		Asn1EncodableVector sigs = new Asn1EncodableVector();
		foreach (SignerInformation sigInf in counterSigners.GetSigners())
		{
			sigs.Add(sigInf.ToSignerInfo());
		}
		v.Add(new Org.BouncyCastle.Asn1.Cms.Attribute(CmsAttributes.CounterSignature, new DerSet(sigs)));
		return new SignerInformation(new Org.BouncyCastle.Asn1.Cms.SignerInfo(sInfo.SignerID, sInfo.DigestAlgorithm, sInfo.AuthenticatedAttributes, sInfo.DigestEncryptionAlgorithm, sInfo.EncryptedDigest, new DerSet(v)), signerInformation.contentType, signerInformation.content, null);
	}
}
