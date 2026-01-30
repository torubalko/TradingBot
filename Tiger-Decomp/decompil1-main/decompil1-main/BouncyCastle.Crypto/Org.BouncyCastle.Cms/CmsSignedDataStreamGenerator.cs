using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms;

public class CmsSignedDataStreamGenerator : CmsSignedGenerator
{
	private class DigestAndSignerInfoGeneratorHolder
	{
		internal readonly ISignerInfoGenerator signerInf;

		internal readonly string digestOID;

		internal AlgorithmIdentifier DigestAlgorithm => new AlgorithmIdentifier(new DerObjectIdentifier(digestOID), DerNull.Instance);

		internal DigestAndSignerInfoGeneratorHolder(ISignerInfoGenerator signerInf, string digestOID)
		{
			this.signerInf = signerInf;
			this.digestOID = digestOID;
		}
	}

	private class SignerInfoGeneratorImpl : ISignerInfoGenerator
	{
		private readonly CmsSignedDataStreamGenerator outer;

		private readonly SignerIdentifier _signerIdentifier;

		private readonly string _digestOID;

		private readonly string _encOID;

		private readonly CmsAttributeTableGenerator _sAttr;

		private readonly CmsAttributeTableGenerator _unsAttr;

		private readonly string _encName;

		private readonly ISigner _sig;

		internal SignerInfoGeneratorImpl(CmsSignedDataStreamGenerator outer, AsymmetricKeyParameter key, SignerIdentifier signerIdentifier, string digestOID, string encOID, CmsAttributeTableGenerator sAttr, CmsAttributeTableGenerator unsAttr)
		{
			this.outer = outer;
			_signerIdentifier = signerIdentifier;
			_digestOID = digestOID;
			_encOID = encOID;
			_sAttr = sAttr;
			_unsAttr = unsAttr;
			_encName = Helper.GetEncryptionAlgName(_encOID);
			string signatureName = Helper.GetDigestAlgName(_digestOID) + "with" + _encName;
			if (_sAttr != null)
			{
				_sig = Helper.GetSignatureInstance(signatureName);
			}
			else if (_encName.Equals("RSA"))
			{
				_sig = Helper.GetSignatureInstance("RSA");
			}
			else
			{
				if (!_encName.Equals("DSA"))
				{
					throw new SignatureException("algorithm: " + _encName + " not supported in base signatures.");
				}
				_sig = Helper.GetSignatureInstance("NONEwithDSA");
			}
			_sig.Init(forSigning: true, new ParametersWithRandom(key, outer.rand));
		}

		public SignerInfo Generate(DerObjectIdentifier contentType, AlgorithmIdentifier digestAlgorithm, byte[] calculatedDigest)
		{
			try
			{
				string algorithm = Helper.GetDigestAlgName(_digestOID) + "with" + _encName;
				byte[] bytesToSign = calculatedDigest;
				Asn1Set signedAttr = null;
				if (_sAttr != null)
				{
					IDictionary parameters = outer.GetBaseParameters(contentType, digestAlgorithm, calculatedDigest);
					Org.BouncyCastle.Asn1.Cms.AttributeTable signed = _sAttr.GetAttributes(parameters);
					if (contentType == null && signed != null && signed[CmsAttributes.ContentType] != null)
					{
						IDictionary dictionary = signed.ToDictionary();
						dictionary.Remove(CmsAttributes.ContentType);
						signed = new Org.BouncyCastle.Asn1.Cms.AttributeTable(dictionary);
					}
					signedAttr = outer.GetAttributeSet(signed);
					bytesToSign = signedAttr.GetEncoded("DER");
				}
				else if (_encName.Equals("RSA"))
				{
					bytesToSign = new DigestInfo(digestAlgorithm, calculatedDigest).GetEncoded("DER");
				}
				_sig.BlockUpdate(bytesToSign, 0, bytesToSign.Length);
				byte[] sigBytes = _sig.GenerateSignature();
				Asn1Set unsignedAttr = null;
				if (_unsAttr != null)
				{
					IDictionary parameters2 = outer.GetBaseParameters(contentType, digestAlgorithm, calculatedDigest);
					parameters2[CmsAttributeTableParameter.Signature] = sigBytes.Clone();
					Org.BouncyCastle.Asn1.Cms.AttributeTable unsigned = _unsAttr.GetAttributes(parameters2);
					unsignedAttr = outer.GetAttributeSet(unsigned);
				}
				Asn1Encodable sigX509Parameters = SignerUtilities.GetDefaultX509Parameters(algorithm);
				AlgorithmIdentifier digestEncryptionAlgorithm = Helper.GetEncAlgorithmIdentifier(new DerObjectIdentifier(_encOID), sigX509Parameters);
				return new SignerInfo(_signerIdentifier, digestAlgorithm, signedAttr, digestEncryptionAlgorithm, new DerOctetString(sigBytes), unsignedAttr);
			}
			catch (IOException e)
			{
				throw new CmsStreamException("encoding error.", e);
			}
			catch (SignatureException e2)
			{
				throw new CmsStreamException("error creating signature.", e2);
			}
		}
	}

	private class CmsSignedDataOutputStream : BaseOutputStream
	{
		private readonly CmsSignedDataStreamGenerator outer;

		private Stream _out;

		private DerObjectIdentifier _contentOID;

		private BerSequenceGenerator _sGen;

		private BerSequenceGenerator _sigGen;

		private BerSequenceGenerator _eiGen;

		public CmsSignedDataOutputStream(CmsSignedDataStreamGenerator outer, Stream outStream, string contentOID, BerSequenceGenerator sGen, BerSequenceGenerator sigGen, BerSequenceGenerator eiGen)
		{
			this.outer = outer;
			_out = outStream;
			_contentOID = new DerObjectIdentifier(contentOID);
			_sGen = sGen;
			_sigGen = sigGen;
			_eiGen = eiGen;
		}

		public override void WriteByte(byte b)
		{
			_out.WriteByte(b);
		}

		public override void Write(byte[] bytes, int off, int len)
		{
			_out.Write(bytes, off, len);
		}

		public override void Close()
		{
			DoClose();
			base.Close();
		}

		private void DoClose()
		{
			Platform.Dispose(_out);
			_eiGen.Close();
			outer._digests.Clear();
			if (outer._certs.Count > 0)
			{
				Asn1Set certs = (outer.UseDerForCerts ? CmsUtilities.CreateDerSetFromList(outer._certs) : CmsUtilities.CreateBerSetFromList(outer._certs));
				WriteToGenerator(_sigGen, new BerTaggedObject(explicitly: false, 0, certs));
			}
			if (outer._crls.Count > 0)
			{
				Asn1Set crls = (outer.UseDerForCrls ? CmsUtilities.CreateDerSetFromList(outer._crls) : CmsUtilities.CreateBerSetFromList(outer._crls));
				WriteToGenerator(_sigGen, new BerTaggedObject(explicitly: false, 1, crls));
			}
			foreach (DictionaryEntry de in outer._messageDigests)
			{
				outer._messageHashes.Add(de.Key, DigestUtilities.DoFinal((IDigest)de.Value));
			}
			Asn1EncodableVector signerInfos = new Asn1EncodableVector();
			foreach (DigestAndSignerInfoGeneratorHolder holder in outer._signerInfs)
			{
				AlgorithmIdentifier digestAlgorithm = holder.DigestAlgorithm;
				byte[] calculatedDigest = (byte[])outer._messageHashes[Helper.GetDigestAlgName(holder.digestOID)];
				outer._digests[holder.digestOID] = calculatedDigest.Clone();
				signerInfos.Add(holder.signerInf.Generate(_contentOID, digestAlgorithm, calculatedDigest));
			}
			foreach (SignerInformation signer in outer._signers)
			{
				signerInfos.Add(signer.ToSignerInfo());
			}
			WriteToGenerator(_sigGen, new DerSet(signerInfos));
			_sigGen.Close();
			_sGen.Close();
		}

		private static void WriteToGenerator(Asn1Generator ag, Asn1Encodable ae)
		{
			byte[] encoded = ae.GetEncoded();
			ag.GetRawOutputStream().Write(encoded, 0, encoded.Length);
		}
	}

	private static readonly CmsSignedHelper Helper = CmsSignedHelper.Instance;

	private readonly IList _signerInfs = Platform.CreateArrayList();

	private readonly ISet _messageDigestOids = new HashSet();

	private readonly IDictionary _messageDigests = Platform.CreateHashtable();

	private readonly IDictionary _messageHashes = Platform.CreateHashtable();

	private bool _messageDigestsLocked;

	private int _bufferSize;

	public CmsSignedDataStreamGenerator()
	{
	}

	public CmsSignedDataStreamGenerator(SecureRandom rand)
		: base(rand)
	{
	}

	public void SetBufferSize(int bufferSize)
	{
		_bufferSize = bufferSize;
	}

	public void AddDigests(params string[] digestOids)
	{
		AddDigests((IEnumerable)digestOids);
	}

	public void AddDigests(IEnumerable digestOids)
	{
		foreach (string digestOid in digestOids)
		{
			ConfigureDigest(digestOid);
		}
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOid)
	{
		AddSigner(privateKey, cert, digestOid, new DefaultSignedAttributeTableGenerator(), null);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOid, string digestOid)
	{
		AddSigner(privateKey, cert, encryptionOid, digestOid, new DefaultSignedAttributeTableGenerator(), null);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOid, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
		AddSigner(privateKey, cert, digestOid, new DefaultSignedAttributeTableGenerator(signedAttr), new SimpleAttributeTableGenerator(unsignedAttr));
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOid, string digestOid, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
		AddSigner(privateKey, cert, encryptionOid, digestOid, new DefaultSignedAttributeTableGenerator(signedAttr), new SimpleAttributeTableGenerator(unsignedAttr));
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
		AddSigner(privateKey, cert, Helper.GetEncOid(privateKey, digestOid), digestOid, signedAttrGenerator, unsignedAttrGenerator);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOid, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
		DoAddSigner(privateKey, CmsSignedGenerator.GetSignerIdentifier(cert), encryptionOid, digestOid, signedAttrGenerator, unsignedAttrGenerator);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid)
	{
		AddSigner(privateKey, subjectKeyID, digestOid, new DefaultSignedAttributeTableGenerator(), null);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOid, string digestOid)
	{
		AddSigner(privateKey, subjectKeyID, encryptionOid, digestOid, new DefaultSignedAttributeTableGenerator(), null);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
		AddSigner(privateKey, subjectKeyID, digestOid, new DefaultSignedAttributeTableGenerator(signedAttr), new SimpleAttributeTableGenerator(unsignedAttr));
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
		AddSigner(privateKey, subjectKeyID, Helper.GetEncOid(privateKey, digestOid), digestOid, signedAttrGenerator, unsignedAttrGenerator);
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOid, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
		DoAddSigner(privateKey, CmsSignedGenerator.GetSignerIdentifier(subjectKeyID), encryptionOid, digestOid, signedAttrGenerator, unsignedAttrGenerator);
	}

	private void DoAddSigner(AsymmetricKeyParameter privateKey, SignerIdentifier signerIdentifier, string encryptionOid, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
		ConfigureDigest(digestOid);
		SignerInfoGeneratorImpl signerInf = new SignerInfoGeneratorImpl(this, privateKey, signerIdentifier, digestOid, encryptionOid, signedAttrGenerator, unsignedAttrGenerator);
		_signerInfs.Add(new DigestAndSignerInfoGeneratorHolder(signerInf, digestOid));
	}

	internal override void AddSignerCallback(SignerInformation si)
	{
		RegisterDigestOid(si.DigestAlgorithmID.Algorithm.Id);
	}

	public Stream Open(Stream outStream)
	{
		return Open(outStream, encapsulate: false);
	}

	public Stream Open(Stream outStream, bool encapsulate)
	{
		return Open(outStream, CmsSignedGenerator.Data, encapsulate);
	}

	public Stream Open(Stream outStream, bool encapsulate, Stream dataOutputStream)
	{
		return Open(outStream, CmsSignedGenerator.Data, encapsulate, dataOutputStream);
	}

	public Stream Open(Stream outStream, string signedContentType, bool encapsulate)
	{
		return Open(outStream, signedContentType, encapsulate, null);
	}

	public Stream Open(Stream outStream, string signedContentType, bool encapsulate, Stream dataOutputStream)
	{
		if (outStream == null)
		{
			throw new ArgumentNullException("outStream");
		}
		if (!outStream.CanWrite)
		{
			throw new ArgumentException("Expected writeable stream", "outStream");
		}
		if (dataOutputStream != null && !dataOutputStream.CanWrite)
		{
			throw new ArgumentException("Expected writeable stream", "dataOutputStream");
		}
		_messageDigestsLocked = true;
		BerSequenceGenerator sGen = new BerSequenceGenerator(outStream);
		sGen.AddObject(CmsObjectIdentifiers.SignedData);
		BerSequenceGenerator sigGen = new BerSequenceGenerator(sGen.GetRawOutputStream(), 0, isExplicit: true);
		DerObjectIdentifier contentTypeOid = ((signedContentType == null) ? null : new DerObjectIdentifier(signedContentType));
		sigGen.AddObject(CalculateVersion(contentTypeOid));
		Asn1EncodableVector digestAlgs = new Asn1EncodableVector();
		foreach (string digestOid in _messageDigestOids)
		{
			digestAlgs.Add(new AlgorithmIdentifier(new DerObjectIdentifier(digestOid), DerNull.Instance));
		}
		byte[] tmp = new DerSet(digestAlgs).GetEncoded();
		sigGen.GetRawOutputStream().Write(tmp, 0, tmp.Length);
		BerSequenceGenerator eiGen = new BerSequenceGenerator(sigGen.GetRawOutputStream());
		eiGen.AddObject(contentTypeOid);
		Stream encapStream = (encapsulate ? CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, isExplicit: true, _bufferSize) : null);
		Stream teeStream = GetSafeTeeOutputStream(dataOutputStream, encapStream);
		Stream digStream = AttachDigestsToOutputStream(_messageDigests.Values, teeStream);
		return new CmsSignedDataOutputStream(this, digStream, signedContentType, sGen, sigGen, eiGen);
	}

	private void RegisterDigestOid(string digestOid)
	{
		if (_messageDigestsLocked)
		{
			if (!_messageDigestOids.Contains(digestOid))
			{
				throw new InvalidOperationException("Cannot register new digest OIDs after the data stream is opened");
			}
		}
		else
		{
			_messageDigestOids.Add(digestOid);
		}
	}

	private void ConfigureDigest(string digestOid)
	{
		RegisterDigestOid(digestOid);
		string digestName = Helper.GetDigestAlgName(digestOid);
		IDigest dig = (IDigest)_messageDigests[digestName];
		if (dig == null)
		{
			if (_messageDigestsLocked)
			{
				throw new InvalidOperationException("Cannot configure new digests after the data stream is opened");
			}
			dig = Helper.GetDigestInstance(digestName);
			_messageDigests[digestName] = dig;
		}
	}

	internal void Generate(Stream outStream, string eContentType, bool encapsulate, Stream dataOutputStream, CmsProcessable content)
	{
		Stream signedOut = Open(outStream, eContentType, encapsulate, dataOutputStream);
		content?.Write(signedOut);
		Platform.Dispose(signedOut);
	}

	private DerInteger CalculateVersion(DerObjectIdentifier contentOid)
	{
		bool otherCert = false;
		bool otherCrl = false;
		bool attrCertV1Found = false;
		bool attrCertV2Found = false;
		if (_certs != null)
		{
			foreach (object obj in _certs)
			{
				if (obj is Asn1TaggedObject)
				{
					Asn1TaggedObject tagged = (Asn1TaggedObject)obj;
					if (tagged.TagNo == 1)
					{
						attrCertV1Found = true;
					}
					else if (tagged.TagNo == 2)
					{
						attrCertV2Found = true;
					}
					else if (tagged.TagNo == 3)
					{
						otherCert = true;
						break;
					}
				}
			}
		}
		if (otherCert)
		{
			return new DerInteger(5);
		}
		if (_crls != null)
		{
			foreach (object crl in _crls)
			{
				if (crl is Asn1TaggedObject)
				{
					otherCrl = true;
					break;
				}
			}
		}
		if (otherCrl)
		{
			return new DerInteger(5);
		}
		if (attrCertV2Found)
		{
			return new DerInteger(4);
		}
		if (attrCertV1Found || !CmsObjectIdentifiers.Data.Equals(contentOid) || CheckForVersion3(_signers))
		{
			return new DerInteger(3);
		}
		return new DerInteger(1);
	}

	private bool CheckForVersion3(IList signerInfos)
	{
		foreach (SignerInformation signerInfo in signerInfos)
		{
			if (SignerInfo.GetInstance(signerInfo.ToSignerInfo()).Version.IntValueExact == 3)
			{
				return true;
			}
		}
		return false;
	}

	private static Stream AttachDigestsToOutputStream(ICollection digests, Stream s)
	{
		Stream result = s;
		foreach (IDigest digest in digests)
		{
			result = GetSafeTeeOutputStream(result, new DigestSink(digest));
		}
		return result;
	}

	private static Stream GetSafeOutputStream(Stream s)
	{
		if (s == null)
		{
			return new NullOutputStream();
		}
		return s;
	}

	private static Stream GetSafeTeeOutputStream(Stream s1, Stream s2)
	{
		if (s1 == null)
		{
			return GetSafeOutputStream(s2);
		}
		if (s2 == null)
		{
			return GetSafeOutputStream(s1);
		}
		return new TeeOutputStream(s1, s2);
	}
}
