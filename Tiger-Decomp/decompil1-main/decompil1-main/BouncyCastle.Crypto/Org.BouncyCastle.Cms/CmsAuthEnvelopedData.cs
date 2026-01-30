using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms;

internal class CmsAuthEnvelopedData
{
	private class AuthEnvelopedSecureReadable : CmsSecureReadable
	{
		private readonly CmsAuthEnvelopedData parent;

		public AlgorithmIdentifier Algorithm => parent.authEncAlg;

		public object CryptoObject => null;

		internal AuthEnvelopedSecureReadable(CmsAuthEnvelopedData parent)
		{
			this.parent = parent;
		}

		public CmsReadable GetReadable(KeyParameter key)
		{
			throw new CmsException("AuthEnveloped data decryption not yet implemented");
		}
	}

	internal RecipientInformationStore recipientInfoStore;

	internal ContentInfo contentInfo;

	private OriginatorInfo originator;

	private AlgorithmIdentifier authEncAlg;

	private Asn1Set authAttrs;

	private byte[] mac;

	private Asn1Set unauthAttrs;

	public CmsAuthEnvelopedData(byte[] authEnvData)
		: this(CmsUtilities.ReadContentInfo(authEnvData))
	{
	}

	public CmsAuthEnvelopedData(Stream authEnvData)
		: this(CmsUtilities.ReadContentInfo(authEnvData))
	{
	}

	public CmsAuthEnvelopedData(ContentInfo contentInfo)
	{
		this.contentInfo = contentInfo;
		AuthEnvelopedData authEnvData = AuthEnvelopedData.GetInstance(contentInfo.Content);
		originator = authEnvData.OriginatorInfo;
		Asn1Set recipientInfos = authEnvData.RecipientInfos;
		EncryptedContentInfo authEncInfo = authEnvData.AuthEncryptedContentInfo;
		authEncAlg = authEncInfo.ContentEncryptionAlgorithm;
		CmsSecureReadable secureReadable = new AuthEnvelopedSecureReadable(this);
		recipientInfoStore = CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
		authAttrs = authEnvData.AuthAttrs;
		mac = authEnvData.Mac.GetOctets();
		unauthAttrs = authEnvData.UnauthAttrs;
	}
}
