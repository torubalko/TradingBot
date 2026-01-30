using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Cms;

public class CmsEnvelopedDataParser : CmsContentInfoParser
{
	internal RecipientInformationStore recipientInfoStore;

	internal EnvelopedDataParser envelopedData;

	private AlgorithmIdentifier _encAlg;

	private Org.BouncyCastle.Asn1.Cms.AttributeTable _unprotectedAttributes;

	private bool _attrNotRead;

	public AlgorithmIdentifier EncryptionAlgorithmID => _encAlg;

	public string EncryptionAlgOid => _encAlg.Algorithm.Id;

	public Asn1Object EncryptionAlgParams => _encAlg.Parameters?.ToAsn1Object();

	public CmsEnvelopedDataParser(byte[] envelopedData)
		: this(new MemoryStream(envelopedData, writable: false))
	{
	}

	public CmsEnvelopedDataParser(Stream envelopedData)
		: base(envelopedData)
	{
		_attrNotRead = true;
		this.envelopedData = new EnvelopedDataParser((Asn1SequenceParser)contentInfo.GetContent(16));
		Asn1Set recipientInfos = Asn1Set.GetInstance(this.envelopedData.GetRecipientInfos().ToAsn1Object());
		EncryptedContentInfoParser encInfo = this.envelopedData.GetEncryptedContentInfo();
		_encAlg = encInfo.ContentEncryptionAlgorithm;
		CmsReadable readable = new CmsProcessableInputStream(((Asn1OctetStringParser)encInfo.GetEncryptedContent(4)).GetOctetStream());
		CmsSecureReadable secureReadable = new CmsEnvelopedHelper.CmsEnvelopedSecureReadable(_encAlg, readable);
		recipientInfoStore = CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
	}

	public RecipientInformationStore GetRecipientInfos()
	{
		return recipientInfoStore;
	}

	public Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnprotectedAttributes()
	{
		if (_unprotectedAttributes == null && _attrNotRead)
		{
			Asn1SetParser asn1Set = envelopedData.GetUnprotectedAttrs();
			_attrNotRead = false;
			if (asn1Set != null)
			{
				Asn1EncodableVector v = new Asn1EncodableVector();
				IAsn1Convertible o;
				while ((o = asn1Set.ReadObject()) != null)
				{
					Asn1SequenceParser seq = (Asn1SequenceParser)o;
					v.Add(seq.ToAsn1Object());
				}
				_unprotectedAttributes = new Org.BouncyCastle.Asn1.Cms.AttributeTable(new DerSet(v));
			}
		}
		return _unprotectedAttributes;
	}
}
