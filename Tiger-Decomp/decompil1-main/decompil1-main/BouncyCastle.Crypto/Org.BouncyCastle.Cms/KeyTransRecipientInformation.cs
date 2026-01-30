using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms;

public class KeyTransRecipientInformation : RecipientInformation
{
	private KeyTransRecipientInfo info;

	internal KeyTransRecipientInformation(KeyTransRecipientInfo info, CmsSecureReadable secureReadable)
		: base(info.KeyEncryptionAlgorithm, secureReadable)
	{
		this.info = info;
		rid = new RecipientID();
		RecipientIdentifier r = info.RecipientIdentifier;
		try
		{
			if (r.IsTagged)
			{
				Asn1OctetString octs = Asn1OctetString.GetInstance(r.ID);
				rid.SubjectKeyIdentifier = octs.GetOctets();
			}
			else
			{
				Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber iAnds = Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber.GetInstance(r.ID);
				rid.Issuer = iAnds.Name;
				rid.SerialNumber = iAnds.SerialNumber.Value;
			}
		}
		catch (IOException)
		{
			throw new ArgumentException("invalid rid in KeyTransRecipientInformation");
		}
	}

	private string GetExchangeEncryptionAlgorithmName(AlgorithmIdentifier algo)
	{
		DerObjectIdentifier oid = algo.Algorithm;
		if (PkcsObjectIdentifiers.RsaEncryption.Equals(oid))
		{
			return "RSA//PKCS1Padding";
		}
		if (PkcsObjectIdentifiers.IdRsaesOaep.Equals(oid))
		{
			RsaesOaepParameters rsaParams = RsaesOaepParameters.GetInstance(algo.Parameters);
			return "RSA//OAEPWITH" + DigestUtilities.GetAlgorithmName(rsaParams.HashAlgorithm.Algorithm) + "ANDMGF1Padding";
		}
		return oid.Id;
	}

	internal KeyParameter UnwrapKey(ICipherParameters key)
	{
		byte[] encryptedKey = info.EncryptedKey.GetOctets();
		try
		{
			if (keyEncAlg.Algorithm.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
			{
				IKeyUnwrapper keyWrapper = new Asn1KeyUnwrapper(keyEncAlg.Algorithm, keyEncAlg.Parameters, key);
				return ParameterUtilities.CreateKeyParameter(GetContentAlgorithmName(), keyWrapper.Unwrap(encryptedKey, 0, encryptedKey.Length).Collect());
			}
			IWrapper keyWrapper2 = WrapperUtilities.GetWrapper(GetExchangeEncryptionAlgorithmName(keyEncAlg));
			keyWrapper2.Init(forWrapping: false, key);
			return ParameterUtilities.CreateKeyParameter(GetContentAlgorithmName(), keyWrapper2.Unwrap(encryptedKey, 0, encryptedKey.Length));
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("couldn't create cipher.", e);
		}
		catch (InvalidKeyException e2)
		{
			throw new CmsException("key invalid in message.", e2);
		}
		catch (DataLengthException e3)
		{
			throw new CmsException("illegal blocksize in message.", e3);
		}
		catch (InvalidCipherTextException e4)
		{
			throw new CmsException("bad padding in message.", e4);
		}
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		KeyParameter sKey = UnwrapKey(key);
		return GetContentFromSessionKey(sKey);
	}
}
