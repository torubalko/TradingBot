using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms;

internal class CmsEnvelopedHelper
{
	internal class CmsAuthenticatedSecureReadable : CmsSecureReadable
	{
		private AlgorithmIdentifier algorithm;

		private IMac mac;

		private CmsReadable readable;

		public AlgorithmIdentifier Algorithm => algorithm;

		public object CryptoObject => mac;

		internal CmsAuthenticatedSecureReadable(AlgorithmIdentifier algorithm, CmsReadable readable)
		{
			this.algorithm = algorithm;
			this.readable = readable;
		}

		public CmsReadable GetReadable(KeyParameter sKey)
		{
			string macAlg = algorithm.Algorithm.Id;
			try
			{
				mac = MacUtilities.GetMac(macAlg);
				mac.Init(sKey);
			}
			catch (SecurityUtilityException e)
			{
				throw new CmsException("couldn't create cipher.", e);
			}
			catch (InvalidKeyException e2)
			{
				throw new CmsException("key invalid in message.", e2);
			}
			catch (IOException e3)
			{
				throw new CmsException("error decoding algorithm parameters.", e3);
			}
			try
			{
				return new CmsProcessableInputStream(new TeeInputStream(readable.GetInputStream(), new MacSink(mac)));
			}
			catch (IOException e4)
			{
				throw new CmsException("error reading content.", e4);
			}
		}
	}

	internal class CmsEnvelopedSecureReadable : CmsSecureReadable
	{
		private AlgorithmIdentifier algorithm;

		private IBufferedCipher cipher;

		private CmsReadable readable;

		public AlgorithmIdentifier Algorithm => algorithm;

		public object CryptoObject => cipher;

		internal CmsEnvelopedSecureReadable(AlgorithmIdentifier algorithm, CmsReadable readable)
		{
			this.algorithm = algorithm;
			this.readable = readable;
		}

		public CmsReadable GetReadable(KeyParameter sKey)
		{
			try
			{
				cipher = CipherUtilities.GetCipher(algorithm.Algorithm);
				Asn1Object asn1Params = algorithm.Parameters?.ToAsn1Object();
				ICipherParameters cipherParameters = sKey;
				if (asn1Params != null && !(asn1Params is Asn1Null))
				{
					cipherParameters = ParameterUtilities.GetCipherParameters(algorithm.Algorithm, cipherParameters, asn1Params);
				}
				else
				{
					string alg = algorithm.Algorithm.Id;
					if (alg.Equals(CmsEnvelopedGenerator.DesEde3Cbc) || alg.Equals("1.3.6.1.4.1.188.7.1.1.2") || alg.Equals("1.2.840.113533.7.66.10"))
					{
						cipherParameters = new ParametersWithIV(cipherParameters, new byte[8]);
					}
				}
				cipher.Init(forEncryption: false, cipherParameters);
			}
			catch (SecurityUtilityException e)
			{
				throw new CmsException("couldn't create cipher.", e);
			}
			catch (InvalidKeyException e2)
			{
				throw new CmsException("key invalid in message.", e2);
			}
			catch (IOException e3)
			{
				throw new CmsException("error decoding algorithm parameters.", e3);
			}
			try
			{
				return new CmsProcessableInputStream(new CipherStream(readable.GetInputStream(), cipher, null));
			}
			catch (IOException e4)
			{
				throw new CmsException("error reading content.", e4);
			}
		}
	}

	internal static readonly CmsEnvelopedHelper Instance;

	private static readonly IDictionary KeySizes;

	private static readonly IDictionary BaseCipherNames;

	static CmsEnvelopedHelper()
	{
		Instance = new CmsEnvelopedHelper();
		KeySizes = Platform.CreateHashtable();
		BaseCipherNames = Platform.CreateHashtable();
		KeySizes.Add(CmsEnvelopedGenerator.DesEde3Cbc, 192);
		KeySizes.Add(CmsEnvelopedGenerator.Aes128Cbc, 128);
		KeySizes.Add(CmsEnvelopedGenerator.Aes192Cbc, 192);
		KeySizes.Add(CmsEnvelopedGenerator.Aes256Cbc, 256);
		BaseCipherNames.Add(CmsEnvelopedGenerator.DesEde3Cbc, "DESEDE");
		BaseCipherNames.Add(CmsEnvelopedGenerator.Aes128Cbc, "AES");
		BaseCipherNames.Add(CmsEnvelopedGenerator.Aes192Cbc, "AES");
		BaseCipherNames.Add(CmsEnvelopedGenerator.Aes256Cbc, "AES");
	}

	private string GetAsymmetricEncryptionAlgName(string encryptionAlgOid)
	{
		if (PkcsObjectIdentifiers.RsaEncryption.Id.Equals(encryptionAlgOid))
		{
			return "RSA/ECB/PKCS1Padding";
		}
		return encryptionAlgOid;
	}

	internal IBufferedCipher CreateAsymmetricCipher(string encryptionOid)
	{
		string asymName = GetAsymmetricEncryptionAlgName(encryptionOid);
		if (!asymName.Equals(encryptionOid))
		{
			try
			{
				return CipherUtilities.GetCipher(asymName);
			}
			catch (SecurityUtilityException)
			{
			}
		}
		return CipherUtilities.GetCipher(encryptionOid);
	}

	internal IWrapper CreateWrapper(string encryptionOid)
	{
		try
		{
			return WrapperUtilities.GetWrapper(encryptionOid);
		}
		catch (SecurityUtilityException)
		{
			return WrapperUtilities.GetWrapper(GetAsymmetricEncryptionAlgName(encryptionOid));
		}
	}

	internal string GetRfc3211WrapperName(string oid)
	{
		if (oid == null)
		{
			throw new ArgumentNullException("oid");
		}
		return (((string)BaseCipherNames[oid]) ?? throw new ArgumentException("no name for " + oid, "oid")) + "RFC3211Wrap";
	}

	internal int GetKeySize(string oid)
	{
		if (!KeySizes.Contains(oid))
		{
			throw new ArgumentException("no keysize for " + oid, "oid");
		}
		return (int)KeySizes[oid];
	}

	internal static RecipientInformationStore BuildRecipientInformationStore(Asn1Set recipientInfos, CmsSecureReadable secureReadable)
	{
		IList infos = Platform.CreateArrayList();
		for (int i = 0; i != recipientInfos.Count; i++)
		{
			RecipientInfo info = RecipientInfo.GetInstance(recipientInfos[i]);
			ReadRecipientInfo(infos, info, secureReadable);
		}
		return new RecipientInformationStore(infos);
	}

	private static void ReadRecipientInfo(IList infos, RecipientInfo info, CmsSecureReadable secureReadable)
	{
		Asn1Encodable recipInfo = info.Info;
		if (recipInfo is KeyTransRecipientInfo)
		{
			infos.Add(new KeyTransRecipientInformation((KeyTransRecipientInfo)recipInfo, secureReadable));
		}
		else if (recipInfo is KekRecipientInfo)
		{
			infos.Add(new KekRecipientInformation((KekRecipientInfo)recipInfo, secureReadable));
		}
		else if (recipInfo is KeyAgreeRecipientInfo)
		{
			KeyAgreeRecipientInformation.ReadRecipientInfo(infos, (KeyAgreeRecipientInfo)recipInfo, secureReadable);
		}
		else if (recipInfo is PasswordRecipientInfo)
		{
			infos.Add(new PasswordRecipientInformation((PasswordRecipientInfo)recipInfo, secureReadable));
		}
	}
}
