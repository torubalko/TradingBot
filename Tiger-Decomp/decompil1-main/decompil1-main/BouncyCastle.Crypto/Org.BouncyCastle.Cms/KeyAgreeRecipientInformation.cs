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
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms;

public class KeyAgreeRecipientInformation : RecipientInformation
{
	private KeyAgreeRecipientInfo info;

	private Asn1OctetString encryptedKey;

	internal static void ReadRecipientInfo(IList infos, KeyAgreeRecipientInfo info, CmsSecureReadable secureReadable)
	{
		try
		{
			foreach (Asn1Encodable recipientEncryptedKey in info.RecipientEncryptedKeys)
			{
				RecipientEncryptedKey id = RecipientEncryptedKey.GetInstance(recipientEncryptedKey.ToAsn1Object());
				RecipientID rid = new RecipientID();
				KeyAgreeRecipientIdentifier karid = id.Identifier;
				IssuerAndSerialNumber iAndSN = karid.IssuerAndSerialNumber;
				if (iAndSN != null)
				{
					rid.Issuer = iAndSN.Name;
					rid.SerialNumber = iAndSN.SerialNumber.Value;
				}
				else
				{
					RecipientKeyIdentifier rKeyID = karid.RKeyID;
					rid.SubjectKeyIdentifier = rKeyID.SubjectKeyIdentifier.GetOctets();
				}
				infos.Add(new KeyAgreeRecipientInformation(info, rid, id.EncryptedKey, secureReadable));
			}
		}
		catch (IOException innerException)
		{
			throw new ArgumentException("invalid rid in KeyAgreeRecipientInformation", innerException);
		}
	}

	internal KeyAgreeRecipientInformation(KeyAgreeRecipientInfo info, RecipientID rid, Asn1OctetString encryptedKey, CmsSecureReadable secureReadable)
		: base(info.KeyEncryptionAlgorithm, secureReadable)
	{
		this.info = info;
		base.rid = rid;
		this.encryptedKey = encryptedKey;
	}

	private AsymmetricKeyParameter GetSenderPublicKey(AsymmetricKeyParameter receiverPrivateKey, OriginatorIdentifierOrKey originator)
	{
		OriginatorPublicKey opk = originator.OriginatorPublicKey;
		if (opk != null)
		{
			return GetPublicKeyFromOriginatorPublicKey(receiverPrivateKey, opk);
		}
		OriginatorID origID = new OriginatorID();
		IssuerAndSerialNumber iAndSN = originator.IssuerAndSerialNumber;
		if (iAndSN != null)
		{
			origID.Issuer = iAndSN.Name;
			origID.SerialNumber = iAndSN.SerialNumber.Value;
		}
		else
		{
			SubjectKeyIdentifier ski = originator.SubjectKeyIdentifier;
			origID.SubjectKeyIdentifier = ski.GetKeyIdentifier();
		}
		return GetPublicKeyFromOriginatorID(origID);
	}

	private AsymmetricKeyParameter GetPublicKeyFromOriginatorPublicKey(AsymmetricKeyParameter receiverPrivateKey, OriginatorPublicKey originatorPublicKey)
	{
		return PublicKeyFactory.CreateKey(new SubjectPublicKeyInfo(PrivateKeyInfoFactory.CreatePrivateKeyInfo(receiverPrivateKey).PrivateKeyAlgorithm, originatorPublicKey.PublicKey.GetBytes()));
	}

	private AsymmetricKeyParameter GetPublicKeyFromOriginatorID(OriginatorID origID)
	{
		throw new CmsException("No support for 'originator' as IssuerAndSerialNumber or SubjectKeyIdentifier");
	}

	private KeyParameter CalculateAgreedWrapKey(string wrapAlg, AsymmetricKeyParameter senderPublicKey, AsymmetricKeyParameter receiverPrivateKey)
	{
		DerObjectIdentifier algorithm = keyEncAlg.Algorithm;
		ICipherParameters senderPublicParams = senderPublicKey;
		ICipherParameters receiverPrivateParams = receiverPrivateKey;
		if (algorithm.Id.Equals(CmsEnvelopedGenerator.ECMqvSha1Kdf))
		{
			MQVuserKeyingMaterial ukm = MQVuserKeyingMaterial.GetInstance(Asn1Object.FromByteArray(info.UserKeyingMaterial.GetOctets()));
			senderPublicParams = new MqvPublicParameters(ephemeralPublicKey: (ECPublicKeyParameters)GetPublicKeyFromOriginatorPublicKey(receiverPrivateKey, ukm.EphemeralPublicKey), staticPublicKey: (ECPublicKeyParameters)senderPublicParams);
			receiverPrivateParams = new MqvPrivateParameters((ECPrivateKeyParameters)receiverPrivateParams, (ECPrivateKeyParameters)receiverPrivateParams);
		}
		IBasicAgreement basicAgreementWithKdf = AgreementUtilities.GetBasicAgreementWithKdf(algorithm, wrapAlg);
		basicAgreementWithKdf.Init(receiverPrivateParams);
		BigInteger s = basicAgreementWithKdf.CalculateAgreement(senderPublicParams);
		int wrapKeySize = GeneratorUtilities.GetDefaultKeySize(wrapAlg) / 8;
		byte[] wrapKeyBytes = X9IntegerConverter.IntegerToBytes(s, wrapKeySize);
		return ParameterUtilities.CreateKeyParameter(wrapAlg, wrapKeyBytes);
	}

	private KeyParameter UnwrapSessionKey(string wrapAlg, KeyParameter agreedKey)
	{
		byte[] encKeyOctets = encryptedKey.GetOctets();
		IWrapper wrapper = WrapperUtilities.GetWrapper(wrapAlg);
		wrapper.Init(forWrapping: false, agreedKey);
		byte[] sKeyBytes = wrapper.Unwrap(encKeyOctets, 0, encKeyOctets.Length);
		return ParameterUtilities.CreateKeyParameter(GetContentAlgorithmName(), sKeyBytes);
	}

	internal KeyParameter GetSessionKey(AsymmetricKeyParameter receiverPrivateKey)
	{
		try
		{
			string wrapAlg = DerObjectIdentifier.GetInstance(Asn1Sequence.GetInstance(keyEncAlg.Parameters)[0]).Id;
			AsymmetricKeyParameter senderPublicKey = GetSenderPublicKey(receiverPrivateKey, info.Originator);
			KeyParameter agreedWrapKey = CalculateAgreedWrapKey(wrapAlg, senderPublicKey, receiverPrivateKey);
			return UnwrapSessionKey(wrapAlg, agreedWrapKey);
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("couldn't create cipher.", e);
		}
		catch (InvalidKeyException e2)
		{
			throw new CmsException("key invalid in message.", e2);
		}
		catch (Exception e3)
		{
			throw new CmsException("originator key invalid.", e3);
		}
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		if (!(key is AsymmetricKeyParameter))
		{
			throw new ArgumentException("KeyAgreement requires asymmetric key", "key");
		}
		AsymmetricKeyParameter receiverPrivateKey = (AsymmetricKeyParameter)key;
		if (!receiverPrivateKey.IsPrivate)
		{
			throw new ArgumentException("Expected private key", "key");
		}
		KeyParameter sKey = GetSessionKey(receiverPrivateKey);
		return GetContentFromSessionKey(sKey);
	}
}
