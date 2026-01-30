using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms;

public class PasswordRecipientInformation : RecipientInformation
{
	private readonly PasswordRecipientInfo info;

	public virtual AlgorithmIdentifier KeyDerivationAlgorithm => info.KeyDerivationAlgorithm;

	internal PasswordRecipientInformation(PasswordRecipientInfo info, CmsSecureReadable secureReadable)
		: base(info.KeyEncryptionAlgorithm, secureReadable)
	{
		this.info = info;
		rid = new RecipientID();
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		try
		{
			Asn1Sequence obj = (Asn1Sequence)AlgorithmIdentifier.GetInstance(info.KeyEncryptionAlgorithm).Parameters;
			byte[] encryptedKey = info.EncryptedKey.GetOctets();
			string kekAlgName = DerObjectIdentifier.GetInstance(obj[0]).Id;
			IWrapper keyWrapper = WrapperUtilities.GetWrapper(CmsEnvelopedHelper.Instance.GetRfc3211WrapperName(kekAlgName));
			byte[] iv = Asn1OctetString.GetInstance(obj[1]).GetOctets();
			ICipherParameters parameters = ((CmsPbeKey)key).GetEncoded(kekAlgName);
			parameters = new ParametersWithIV(parameters, iv);
			keyWrapper.Init(forWrapping: false, parameters);
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
