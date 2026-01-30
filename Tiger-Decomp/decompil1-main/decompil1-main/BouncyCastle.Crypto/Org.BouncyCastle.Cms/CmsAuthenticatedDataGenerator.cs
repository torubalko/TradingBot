using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms;

public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
{
	public CmsAuthenticatedDataGenerator()
	{
	}

	public CmsAuthenticatedDataGenerator(SecureRandom rand)
		: base(rand)
	{
	}

	private CmsAuthenticatedData Generate(CmsProcessable content, string macOid, CipherKeyGenerator keyGen)
	{
		KeyParameter encKey;
		AlgorithmIdentifier macAlgId;
		Asn1OctetString encContent;
		Asn1OctetString macResult;
		try
		{
			byte[] encKeyBytes = keyGen.GenerateKey();
			encKey = ParameterUtilities.CreateKeyParameter(macOid, encKeyBytes);
			Asn1Encodable asn1Params = GenerateAsn1Parameters(macOid, encKeyBytes);
			macAlgId = GetAlgorithmIdentifier(macOid, encKey, asn1Params, out var _);
			IMac mac = MacUtilities.GetMac(macOid);
			mac.Init(encKey);
			MemoryStream memoryStream = new MemoryStream();
			Stream mOut = new TeeOutputStream(memoryStream, new MacSink(mac));
			content.Write(mOut);
			Platform.Dispose(mOut);
			encContent = new BerOctetString(memoryStream.ToArray());
			macResult = new DerOctetString(MacUtilities.DoFinal(mac));
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
		ContentInfo eci = new ContentInfo(CmsObjectIdentifiers.Data, encContent);
		return new CmsAuthenticatedData(new ContentInfo(CmsObjectIdentifiers.AuthenticatedData, new AuthenticatedData(null, new DerSet(recipientInfos), macAlgId, null, eci, null, macResult, null)));
	}

	public CmsAuthenticatedData Generate(CmsProcessable content, string encryptionOid)
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
}
