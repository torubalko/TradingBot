using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Ocsp;

public class OcspReq : X509ExtensionBase
{
	private OcspRequest req;

	public int Version => req.TbsRequest.Version.IntValueExact + 1;

	public GeneralName RequestorName => GeneralName.GetInstance(req.TbsRequest.RequestorName);

	public X509Extensions RequestExtensions => X509Extensions.GetInstance(req.TbsRequest.RequestExtensions);

	public string SignatureAlgOid
	{
		get
		{
			if (!IsSigned)
			{
				return null;
			}
			return req.OptionalSignature.SignatureAlgorithm.Algorithm.Id;
		}
	}

	public bool IsSigned => req.OptionalSignature != null;

	public OcspReq(OcspRequest req)
	{
		this.req = req;
	}

	public OcspReq(byte[] req)
		: this(new Asn1InputStream(req))
	{
	}

	public OcspReq(Stream inStr)
		: this(new Asn1InputStream(inStr))
	{
	}

	private OcspReq(Asn1InputStream aIn)
	{
		try
		{
			req = OcspRequest.GetInstance(aIn.ReadObject());
		}
		catch (ArgumentException ex)
		{
			throw new IOException("malformed request: " + ex.Message);
		}
		catch (InvalidCastException ex2)
		{
			throw new IOException("malformed request: " + ex2.Message);
		}
	}

	public byte[] GetTbsRequest()
	{
		try
		{
			return req.TbsRequest.GetEncoded();
		}
		catch (IOException e)
		{
			throw new OcspException("problem encoding tbsRequest", e);
		}
	}

	public Req[] GetRequestList()
	{
		Asn1Sequence seq = req.TbsRequest.RequestList;
		Req[] requests = new Req[seq.Count];
		for (int i = 0; i != requests.Length; i++)
		{
			requests[i] = new Req(Request.GetInstance(seq[i]));
		}
		return requests;
	}

	protected override X509Extensions GetX509Extensions()
	{
		return RequestExtensions;
	}

	public byte[] GetSignature()
	{
		if (!IsSigned)
		{
			return null;
		}
		return req.OptionalSignature.GetSignatureOctets();
	}

	private IList GetCertList()
	{
		IList certs = Platform.CreateArrayList();
		Asn1Sequence s = req.OptionalSignature.Certs;
		if (s != null)
		{
			foreach (Asn1Encodable ae in s)
			{
				try
				{
					certs.Add(new X509CertificateParser().ReadCertificate(ae.GetEncoded()));
				}
				catch (Exception e)
				{
					throw new OcspException("can't re-encode certificate!", e);
				}
			}
		}
		return certs;
	}

	public X509Certificate[] GetCerts()
	{
		if (!IsSigned)
		{
			return null;
		}
		IList certs = GetCertList();
		X509Certificate[] result = new X509Certificate[certs.Count];
		for (int i = 0; i < certs.Count; i++)
		{
			result[i] = (X509Certificate)certs[i];
		}
		return result;
	}

	public IX509Store GetCertificates(string type)
	{
		if (!IsSigned)
		{
			return null;
		}
		try
		{
			return X509StoreFactory.Create("Certificate/" + type, new X509CollectionStoreParameters(GetCertList()));
		}
		catch (Exception e)
		{
			throw new OcspException("can't setup the CertStore", e);
		}
	}

	public bool Verify(AsymmetricKeyParameter publicKey)
	{
		if (!IsSigned)
		{
			throw new OcspException("attempt to Verify signature on unsigned object");
		}
		try
		{
			ISigner signer = SignerUtilities.GetSigner(SignatureAlgOid);
			signer.Init(forSigning: false, publicKey);
			byte[] encoded = req.TbsRequest.GetEncoded();
			signer.BlockUpdate(encoded, 0, encoded.Length);
			return signer.VerifySignature(GetSignature());
		}
		catch (Exception ex)
		{
			throw new OcspException("exception processing sig: " + ex, ex);
		}
	}

	public byte[] GetEncoded()
	{
		return req.GetEncoded();
	}
}
