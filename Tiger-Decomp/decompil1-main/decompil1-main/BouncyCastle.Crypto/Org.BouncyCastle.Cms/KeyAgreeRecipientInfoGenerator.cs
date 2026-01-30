using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Cms.Ecc;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms;

internal class KeyAgreeRecipientInfoGenerator : RecipientInfoGenerator
{
	private static readonly CmsEnvelopedHelper Helper = CmsEnvelopedHelper.Instance;

	private DerObjectIdentifier keyAgreementOID;

	private DerObjectIdentifier keyEncryptionOID;

	private IList recipientCerts;

	private AsymmetricCipherKeyPair senderKeyPair;

	internal DerObjectIdentifier KeyAgreementOID
	{
		set
		{
			keyAgreementOID = value;
		}
	}

	internal DerObjectIdentifier KeyEncryptionOID
	{
		set
		{
			keyEncryptionOID = value;
		}
	}

	internal ICollection RecipientCerts
	{
		set
		{
			recipientCerts = Platform.CreateArrayList(value);
		}
	}

	internal AsymmetricCipherKeyPair SenderKeyPair
	{
		set
		{
			senderKeyPair = value;
		}
	}

	internal KeyAgreeRecipientInfoGenerator()
	{
	}

	public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
	{
		byte[] keyBytes = contentEncryptionKey.GetKey();
		AsymmetricKeyParameter senderPublicKey = senderKeyPair.Public;
		ICipherParameters senderPrivateParams = senderKeyPair.Private;
		OriginatorIdentifierOrKey originator;
		try
		{
			originator = new OriginatorIdentifierOrKey(CreateOriginatorPublicKey(senderPublicKey));
		}
		catch (IOException ex)
		{
			throw new InvalidKeyException("cannot extract originator public key: " + ex);
		}
		Asn1OctetString ukm = null;
		if (keyAgreementOID.Id.Equals(CmsEnvelopedGenerator.ECMqvSha1Kdf))
		{
			try
			{
				IAsymmetricCipherKeyPairGenerator keyPairGenerator = GeneratorUtilities.GetKeyPairGenerator(keyAgreementOID);
				keyPairGenerator.Init(((ECPublicKeyParameters)senderPublicKey).CreateKeyGenerationParameters(random));
				AsymmetricCipherKeyPair ephemKP = keyPairGenerator.GenerateKeyPair();
				ukm = new DerOctetString(new MQVuserKeyingMaterial(CreateOriginatorPublicKey(ephemKP.Public), null));
				senderPrivateParams = new MqvPrivateParameters((ECPrivateKeyParameters)senderPrivateParams, (ECPrivateKeyParameters)ephemKP.Private, (ECPublicKeyParameters)ephemKP.Public);
			}
			catch (IOException ex2)
			{
				throw new InvalidKeyException("cannot extract MQV ephemeral public key: " + ex2);
			}
			catch (SecurityUtilityException ex3)
			{
				throw new InvalidKeyException("cannot determine MQV ephemeral key pair parameters from public key: " + ex3);
			}
		}
		DerSequence paramSeq = new DerSequence(keyEncryptionOID, DerNull.Instance);
		AlgorithmIdentifier keyEncAlg = new AlgorithmIdentifier(keyAgreementOID, paramSeq);
		Asn1EncodableVector recipientEncryptedKeys = new Asn1EncodableVector();
		foreach (X509Certificate recipientCert in recipientCerts)
		{
			TbsCertificateStructure tbsCert;
			try
			{
				tbsCert = TbsCertificateStructure.GetInstance(Asn1Object.FromByteArray(recipientCert.GetTbsCertificate()));
			}
			catch (Exception)
			{
				throw new ArgumentException("can't extract TBS structure from certificate");
			}
			KeyAgreeRecipientIdentifier karid = new KeyAgreeRecipientIdentifier(new IssuerAndSerialNumber(tbsCert.Issuer, tbsCert.SerialNumber.Value));
			ICipherParameters recipientPublicParams = recipientCert.GetPublicKey();
			if (keyAgreementOID.Id.Equals(CmsEnvelopedGenerator.ECMqvSha1Kdf))
			{
				recipientPublicParams = new MqvPublicParameters((ECPublicKeyParameters)recipientPublicParams, (ECPublicKeyParameters)recipientPublicParams);
			}
			IBasicAgreement basicAgreementWithKdf = AgreementUtilities.GetBasicAgreementWithKdf(keyAgreementOID, keyEncryptionOID.Id);
			basicAgreementWithKdf.Init(new ParametersWithRandom(senderPrivateParams, random));
			BigInteger s = basicAgreementWithKdf.CalculateAgreement(recipientPublicParams);
			int keyEncryptionKeySize = GeneratorUtilities.GetDefaultKeySize(keyEncryptionOID) / 8;
			byte[] keyEncryptionKeyBytes = X9IntegerConverter.IntegerToBytes(s, keyEncryptionKeySize);
			KeyParameter keyEncryptionKey = ParameterUtilities.CreateKeyParameter(keyEncryptionOID, keyEncryptionKeyBytes);
			IWrapper wrapper = Helper.CreateWrapper(keyEncryptionOID.Id);
			wrapper.Init(forWrapping: true, new ParametersWithRandom(keyEncryptionKey, random));
			Asn1OctetString encryptedKey = new DerOctetString(wrapper.Wrap(keyBytes, 0, keyBytes.Length));
			recipientEncryptedKeys.Add(new RecipientEncryptedKey(karid, encryptedKey));
		}
		return new RecipientInfo(new KeyAgreeRecipientInfo(originator, ukm, keyEncAlg, new DerSequence(recipientEncryptedKeys)));
	}

	private static OriginatorPublicKey CreateOriginatorPublicKey(AsymmetricKeyParameter publicKey)
	{
		SubjectPublicKeyInfo spki = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
		return new OriginatorPublicKey(new AlgorithmIdentifier(spki.AlgorithmID.Algorithm, DerNull.Instance), spki.PublicKeyData.GetBytes());
	}
}
