using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms;

public class KekRecipientInformation : RecipientInformation
{
	private KekRecipientInfo info;

	internal KekRecipientInformation(KekRecipientInfo info, CmsSecureReadable secureReadable)
		: base(info.KeyEncryptionAlgorithm, secureReadable)
	{
		this.info = info;
		rid = new RecipientID();
		KekIdentifier kekId = info.KekID;
		rid.KeyIdentifier = kekId.KeyIdentifier.GetOctets();
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		try
		{
			byte[] encryptedKey = info.EncryptedKey.GetOctets();
			IWrapper keyWrapper = WrapperUtilities.GetWrapper(keyEncAlg.Algorithm.Id);
			keyWrapper.Init(forWrapping: false, key);
			KeyParameter sKey = ParameterUtilities.CreateKeyParameter(GetContentAlgorithmName(), keyWrapper.Unwrap(encryptedKey, 0, encryptedKey.Length));
			return GetContentFromSessionKey(sKey);
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("couldn't create cipher.", e);
		}
		catch (InvalidKeyException e2)
		{
			throw new CmsException("key invalid in message.", e2);
		}
	}
}
