using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms;

public class CmsSignedData
{
	private static readonly CmsSignedHelper Helper = CmsSignedHelper.Instance;

	private readonly CmsProcessable signedContent;

	private SignedData signedData;

	private ContentInfo contentInfo;

	private SignerInformationStore signerInfoStore;

	private IX509Store attrCertStore;

	private IX509Store certificateStore;

	private IX509Store crlStore;

	private IDictionary hashes;

	public int Version => signedData.Version.IntValueExact;

	[Obsolete("Use 'SignedContentType' property instead.")]
	public string SignedContentTypeOid => signedData.EncapContentInfo.ContentType.Id;

	public DerObjectIdentifier SignedContentType => signedData.EncapContentInfo.ContentType;

	public CmsProcessable SignedContent => signedContent;

	public ContentInfo ContentInfo => contentInfo;

	private CmsSignedData(CmsSignedData c)
	{
		signedData = c.signedData;
		contentInfo = c.contentInfo;
		signedContent = c.signedContent;
		signerInfoStore = c.signerInfoStore;
	}

	public CmsSignedData(byte[] sigBlock)
		: this(CmsUtilities.ReadContentInfo(new MemoryStream(sigBlock, writable: false)))
	{
	}

	public CmsSignedData(CmsProcessable signedContent, byte[] sigBlock)
		: this(signedContent, CmsUtilities.ReadContentInfo(new MemoryStream(sigBlock, writable: false)))
	{
	}

	public CmsSignedData(IDictionary hashes, byte[] sigBlock)
		: this(hashes, CmsUtilities.ReadContentInfo(sigBlock))
	{
	}

	public CmsSignedData(CmsProcessable signedContent, Stream sigData)
		: this(signedContent, CmsUtilities.ReadContentInfo(sigData))
	{
	}

	public CmsSignedData(Stream sigData)
		: this(CmsUtilities.ReadContentInfo(sigData))
	{
	}

	public CmsSignedData(CmsProcessable signedContent, ContentInfo sigData)
	{
		this.signedContent = signedContent;
		contentInfo = sigData;
		signedData = SignedData.GetInstance(contentInfo.Content);
	}

	public CmsSignedData(IDictionary hashes, ContentInfo sigData)
	{
		this.hashes = hashes;
		contentInfo = sigData;
		signedData = SignedData.GetInstance(contentInfo.Content);
	}

	public CmsSignedData(ContentInfo sigData)
	{
		contentInfo = sigData;
		signedData = SignedData.GetInstance(contentInfo.Content);
		if (signedData.EncapContentInfo.Content != null)
		{
			signedContent = new CmsProcessableByteArray(((Asn1OctetString)signedData.EncapContentInfo.Content).GetOctets());
		}
	}

	internal IX509Store GetCertificates()
	{
		return Helper.GetCertificates(signedData.Certificates);
	}

	public SignerInformationStore GetSignerInfos()
	{
		if (signerInfoStore == null)
		{
			IList signerInfos = Platform.CreateArrayList();
			foreach (object signerInfo in signedData.SignerInfos)
			{
				SignerInfo info = SignerInfo.GetInstance(signerInfo);
				DerObjectIdentifier contentType = signedData.EncapContentInfo.ContentType;
				if (hashes == null)
				{
					signerInfos.Add(new SignerInformation(info, contentType, signedContent, null));
					continue;
				}
				byte[] hash = (byte[])hashes[info.DigestAlgorithm.Algorithm.Id];
				signerInfos.Add(new SignerInformation(info, contentType, null, new BaseDigestCalculator(hash)));
			}
			signerInfoStore = new SignerInformationStore(signerInfos);
		}
		return signerInfoStore;
	}

	public IX509Store GetAttributeCertificates(string type)
	{
		if (attrCertStore == null)
		{
			attrCertStore = Helper.CreateAttributeStore(type, signedData.Certificates);
		}
		return attrCertStore;
	}

	public IX509Store GetCertificates(string type)
	{
		if (certificateStore == null)
		{
			certificateStore = Helper.CreateCertificateStore(type, signedData.Certificates);
		}
		return certificateStore;
	}

	public IX509Store GetCrls(string type)
	{
		if (crlStore == null)
		{
			crlStore = Helper.CreateCrlStore(type, signedData.CRLs);
		}
		return crlStore;
	}

	public byte[] GetEncoded()
	{
		return contentInfo.GetEncoded();
	}

	public byte[] GetEncoded(string encoding)
	{
		return contentInfo.GetEncoded(encoding);
	}

	public static CmsSignedData ReplaceSigners(CmsSignedData signedData, SignerInformationStore signerInformationStore)
	{
		CmsSignedData cms = new CmsSignedData(signedData);
		cms.signerInfoStore = signerInformationStore;
		Asn1EncodableVector digestAlgs = new Asn1EncodableVector();
		Asn1EncodableVector vec = new Asn1EncodableVector();
		foreach (SignerInformation signer in signerInformationStore.GetSigners())
		{
			digestAlgs.Add(Helper.FixAlgID(signer.DigestAlgorithmID));
			vec.Add(signer.ToSignerInfo());
		}
		Asn1Set digests = new DerSet(digestAlgs);
		Asn1Set signers = new DerSet(vec);
		Asn1Sequence sD = (Asn1Sequence)signedData.signedData.ToAsn1Object();
		vec = new Asn1EncodableVector(sD[0], digests);
		for (int i = 2; i != sD.Count - 1; i++)
		{
			vec.Add(sD[i]);
		}
		vec.Add(signers);
		cms.signedData = SignedData.GetInstance(new BerSequence(vec));
		cms.contentInfo = new ContentInfo(cms.contentInfo.ContentType, cms.signedData);
		return cms;
	}

	public static CmsSignedData ReplaceCertificatesAndCrls(CmsSignedData signedData, IX509Store x509Certs, IX509Store x509Crls, IX509Store x509AttrCerts)
	{
		if (x509AttrCerts != null)
		{
			throw Platform.CreateNotImplementedException("Currently can't replace attribute certificates");
		}
		CmsSignedData cms = new CmsSignedData(signedData);
		Asn1Set certs = null;
		try
		{
			Asn1Set asn1Set = CmsUtilities.CreateBerSetFromList(CmsUtilities.GetCertificatesFromStore(x509Certs));
			if (asn1Set.Count != 0)
			{
				certs = asn1Set;
			}
		}
		catch (X509StoreException e)
		{
			throw new CmsException("error getting certificates from store", e);
		}
		Asn1Set crls = null;
		try
		{
			Asn1Set asn1Set2 = CmsUtilities.CreateBerSetFromList(CmsUtilities.GetCrlsFromStore(x509Crls));
			if (asn1Set2.Count != 0)
			{
				crls = asn1Set2;
			}
		}
		catch (X509StoreException e2)
		{
			throw new CmsException("error getting CRLs from store", e2);
		}
		SignedData old = signedData.signedData;
		cms.signedData = new SignedData(old.DigestAlgorithms, old.EncapContentInfo, certs, crls, old.SignerInfos);
		cms.contentInfo = new ContentInfo(cms.contentInfo.ContentType, cms.signedData);
		return cms;
	}
}
