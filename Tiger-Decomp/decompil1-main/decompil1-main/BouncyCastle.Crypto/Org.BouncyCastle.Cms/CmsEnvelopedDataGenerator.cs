using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms;

public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
{
	public CmsEnvelopedDataGenerator()
	{
	}

	public CmsEnvelopedDataGenerator(SecureRandom rand)
		: base(rand)
	{
	}

	private CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid, CipherKeyGenerator keyGen)
	{
		AlgorithmIdentifier encAlgId = null;
		KeyParameter encKey;
		Asn1OctetString encContent;
		try
		{
			byte[] encKeyBytes = keyGen.GenerateKey();
			encKey = ParameterUtilities.CreateKeyParameter(encryptionOid, encKeyBytes);
			Asn1Encodable asn1Params = GenerateAsn1Parameters(encryptionOid, encKeyBytes);
			encAlgId = GetAlgorithmIdentifier(encryptionOid, encKey, asn1Params, out var cipherParameters);
			IBufferedCipher cipher = CipherUtilities.GetCipher(encryptionOid);
			cipher.Init(forEncryption: true, new ParametersWithRandom(cipherParameters, rand));
			MemoryStream memoryStream = new MemoryStream();
			CipherStream cOut = new CipherStream(memoryStream, null, cipher);
			content.Write(cOut);
			Platform.Dispose(cOut);
			encContent = new BerOctetString(memoryStream.ToArray());
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
			throw new CmsException("exception decoding algorithm parameters.", e3);
		}
		Asn1EncodableVector recipientInfos = new Asn1EncodableVector();
		foreach (RecipientInfoGenerator rig in recipientInfoGenerators)
		{
			try
			{
				recipientInfos.Add(rig.Generate(encKey, rand));
			}
			catch (InvalidKeyException e4)
			{
				throw new CmsException("key inappropriate for algorithm.", e4);
			}
			catch (GeneralSecurityException e5)
			{
				throw new CmsException("error making encrypted content.", e5);
			}
		}
		EncryptedContentInfo eci = new EncryptedContentInfo(CmsObjectIdentifiers.Data, encAlgId, encContent);
		Asn1Set unprotectedAttrSet = null;
		if (unprotectedAttributeGenerator != null)
		{
			unprotectedAttrSet = new BerSet(unprotectedAttributeGenerator.GetAttributes(Platform.CreateHashtable()).ToAsn1EncodableVector());
		}
		return new CmsEnvelopedData(new ContentInfo(CmsObjectIdentifiers.EnvelopedData, new EnvelopedData(null, new DerSet(recipientInfos), eci, unprotectedAttrSet)));
	}

	public CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid)
	{
		try
		{
			CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);
			keyGen.Init(new KeyGenerationParameters(rand, keyGen.DefaultStrength));
			return Generate(content, encryptionOid, keyGen);
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("can't find key generation algorithm.", e);
		}
	}

	public CmsEnvelopedData Generate(CmsProcessable content, ICipherBuilderWithKey cipherBuilder)
	{
		KeyParameter encKey;
		Asn1OctetString encContent;
		try
		{
			encKey = (KeyParameter)cipherBuilder.Key;
			MemoryStream collector = new MemoryStream();
			Stream bOut = cipherBuilder.BuildCipher(collector).Stream;
			content.Write(bOut);
			Platform.Dispose(bOut);
			encContent = new BerOctetString(collector.ToArray());
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
			throw new CmsException("exception decoding algorithm parameters.", e3);
		}
		Asn1EncodableVector recipientInfos = new Asn1EncodableVector();
		foreach (RecipientInfoGenerator rig in recipientInfoGenerators)
		{
			try
			{
				recipientInfos.Add(rig.Generate(encKey, rand));
			}
			catch (InvalidKeyException e4)
			{
				throw new CmsException("key inappropriate for algorithm.", e4);
			}
			catch (GeneralSecurityException e5)
			{
				throw new CmsException("error making encrypted content.", e5);
			}
		}
		EncryptedContentInfo eci = new EncryptedContentInfo(CmsObjectIdentifiers.Data, (AlgorithmIdentifier)cipherBuilder.AlgorithmDetails, encContent);
		Asn1Set unprotectedAttrSet = null;
		if (unprotectedAttributeGenerator != null)
		{
			unprotectedAttrSet = new BerSet(unprotectedAttributeGenerator.GetAttributes(Platform.CreateHashtable()).ToAsn1EncodableVector());
		}
		return new CmsEnvelopedData(new ContentInfo(CmsObjectIdentifiers.EnvelopedData, new EnvelopedData(null, new DerSet(recipientInfos), eci, unprotectedAttrSet)));
	}

	public CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid, int keySize)
	{
		try
		{
			CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);
			keyGen.Init(new KeyGenerationParameters(rand, keySize));
			return Generate(content, encryptionOid, keyGen);
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("can't find key generation algorithm.", e);
		}
	}
}
