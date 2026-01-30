using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms;

public class CmsSignedDataParser : CmsContentInfoParser
{
	private static readonly CmsSignedHelper Helper = CmsSignedHelper.Instance;

	private SignedDataParser _signedData;

	private DerObjectIdentifier _signedContentType;

	private CmsTypedStream _signedContent;

	private IDictionary _digests;

	private ISet _digestOids;

	private SignerInformationStore _signerInfoStore;

	private Asn1Set _certSet;

	private Asn1Set _crlSet;

	private bool _isCertCrlParsed;

	private IX509Store _attributeStore;

	private IX509Store _certificateStore;

	private IX509Store _crlStore;

	public int Version => _signedData.Version.IntValueExact;

	public ISet DigestOids => new HashSet(_digestOids);

	public DerObjectIdentifier SignedContentType => _signedContentType;

	public CmsSignedDataParser(byte[] sigBlock)
		: this(new MemoryStream(sigBlock, writable: false))
	{
	}

	public CmsSignedDataParser(CmsTypedStream signedContent, byte[] sigBlock)
		: this(signedContent, new MemoryStream(sigBlock, writable: false))
	{
	}

	public CmsSignedDataParser(Stream sigData)
		: this(null, sigData)
	{
	}

	public CmsSignedDataParser(CmsTypedStream signedContent, Stream sigData)
		: base(sigData)
	{
		try
		{
			_signedContent = signedContent;
			_signedData = SignedDataParser.GetInstance(contentInfo.GetContent(16));
			_digests = Platform.CreateHashtable();
			_digestOids = new HashSet();
			Asn1SetParser digAlgs = _signedData.GetDigestAlgorithms();
			IAsn1Convertible o;
			while ((o = digAlgs.ReadObject()) != null)
			{
				AlgorithmIdentifier id = AlgorithmIdentifier.GetInstance(o.ToAsn1Object());
				try
				{
					string digestOid = id.Algorithm.Id;
					string digestName = Helper.GetDigestAlgName(digestOid);
					if (!_digests.Contains(digestName))
					{
						_digests[digestName] = Helper.GetDigestInstance(digestName);
						_digestOids.Add(digestOid);
					}
				}
				catch (SecurityUtilityException)
				{
				}
			}
			ContentInfoParser cont = _signedData.GetEncapContentInfo();
			Asn1OctetStringParser octs = (Asn1OctetStringParser)cont.GetContent(4);
			if (octs != null)
			{
				CmsTypedStream ctStr = new CmsTypedStream(cont.ContentType.Id, octs.GetOctetStream());
				if (_signedContent == null)
				{
					_signedContent = ctStr;
				}
				else
				{
					ctStr.Drain();
				}
			}
			_signedContentType = ((_signedContent == null) ? cont.ContentType : new DerObjectIdentifier(_signedContent.ContentType));
		}
		catch (IOException ex2)
		{
			throw new CmsException("io exception: " + ex2.Message, ex2);
		}
	}

	public SignerInformationStore GetSignerInfos()
	{
		if (_signerInfoStore == null)
		{
			PopulateCertCrlSets();
			IList signerInfos = Platform.CreateArrayList();
			IDictionary hashes = Platform.CreateHashtable();
			foreach (object digestKey in _digests.Keys)
			{
				hashes[digestKey] = DigestUtilities.DoFinal((IDigest)_digests[digestKey]);
			}
			try
			{
				Asn1SetParser s = _signedData.GetSignerInfos();
				IAsn1Convertible o;
				while ((o = s.ReadObject()) != null)
				{
					SignerInfo info = SignerInfo.GetInstance(o.ToAsn1Object());
					string digestName = Helper.GetDigestAlgName(info.DigestAlgorithm.Algorithm.Id);
					byte[] hash = (byte[])hashes[digestName];
					signerInfos.Add(new SignerInformation(info, _signedContentType, null, new BaseDigestCalculator(hash)));
				}
			}
			catch (IOException ex)
			{
				throw new CmsException("io exception: " + ex.Message, ex);
			}
			_signerInfoStore = new SignerInformationStore(signerInfos);
		}
		return _signerInfoStore;
	}

	public IX509Store GetAttributeCertificates(string type)
	{
		if (_attributeStore == null)
		{
			PopulateCertCrlSets();
			_attributeStore = Helper.CreateAttributeStore(type, _certSet);
		}
		return _attributeStore;
	}

	public IX509Store GetCertificates(string type)
	{
		if (_certificateStore == null)
		{
			PopulateCertCrlSets();
			_certificateStore = Helper.CreateCertificateStore(type, _certSet);
		}
		return _certificateStore;
	}

	public IX509Store GetCrls(string type)
	{
		if (_crlStore == null)
		{
			PopulateCertCrlSets();
			_crlStore = Helper.CreateCrlStore(type, _crlSet);
		}
		return _crlStore;
	}

	private void PopulateCertCrlSets()
	{
		if (_isCertCrlParsed)
		{
			return;
		}
		_isCertCrlParsed = true;
		try
		{
			_certSet = GetAsn1Set(_signedData.GetCertificates());
			_crlSet = GetAsn1Set(_signedData.GetCrls());
		}
		catch (IOException e)
		{
			throw new CmsException("problem parsing cert/crl sets", e);
		}
	}

	public CmsTypedStream GetSignedContent()
	{
		if (_signedContent == null)
		{
			return null;
		}
		Stream digStream = _signedContent.ContentStream;
		foreach (IDigest digest in _digests.Values)
		{
			digStream = new DigestStream(digStream, digest, null);
		}
		return new CmsTypedStream(_signedContent.ContentType, digStream);
	}

	public static Stream ReplaceSigners(Stream original, SignerInformationStore signerInformationStore, Stream outStr)
	{
		CmsSignedDataStreamGenerator cmsSignedDataStreamGenerator = new CmsSignedDataStreamGenerator();
		CmsSignedDataParser parser = new CmsSignedDataParser(original);
		cmsSignedDataStreamGenerator.AddSigners(signerInformationStore);
		CmsTypedStream signedContent = parser.GetSignedContent();
		bool encapsulate = signedContent != null;
		Stream contentOut = cmsSignedDataStreamGenerator.Open(outStr, parser.SignedContentType.Id, encapsulate);
		if (encapsulate)
		{
			Streams.PipeAll(signedContent.ContentStream, contentOut);
		}
		cmsSignedDataStreamGenerator.AddAttributeCertificates(parser.GetAttributeCertificates("Collection"));
		cmsSignedDataStreamGenerator.AddCertificates(parser.GetCertificates("Collection"));
		cmsSignedDataStreamGenerator.AddCrls(parser.GetCrls("Collection"));
		Platform.Dispose(contentOut);
		return outStr;
	}

	public static Stream ReplaceCertificatesAndCrls(Stream original, IX509Store x509Certs, IX509Store x509Crls, IX509Store x509AttrCerts, Stream outStr)
	{
		CmsSignedDataStreamGenerator gen = new CmsSignedDataStreamGenerator();
		CmsSignedDataParser parser = new CmsSignedDataParser(original);
		gen.AddDigests(parser.DigestOids);
		CmsTypedStream signedContent = parser.GetSignedContent();
		bool encapsulate = signedContent != null;
		Stream contentOut = gen.Open(outStr, parser.SignedContentType.Id, encapsulate);
		if (encapsulate)
		{
			Streams.PipeAll(signedContent.ContentStream, contentOut);
		}
		if (x509AttrCerts != null)
		{
			gen.AddAttributeCertificates(x509AttrCerts);
		}
		if (x509Certs != null)
		{
			gen.AddCertificates(x509Certs);
		}
		if (x509Crls != null)
		{
			gen.AddCrls(x509Crls);
		}
		gen.AddSigners(parser.GetSignerInfos());
		Platform.Dispose(contentOut);
		return outStr;
	}

	private static Asn1Set GetAsn1Set(Asn1SetParser asn1SetParser)
	{
		if (asn1SetParser != null)
		{
			return Asn1Set.GetInstance(asn1SetParser.ToAsn1Object());
		}
		return null;
	}
}
