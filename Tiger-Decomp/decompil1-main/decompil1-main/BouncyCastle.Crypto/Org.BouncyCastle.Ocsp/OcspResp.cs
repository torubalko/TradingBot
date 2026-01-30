using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Ocsp;

public class OcspResp
{
	private OcspResponse resp;

	public int Status => resp.ResponseStatus.IntValueExact;

	public OcspResp(OcspResponse resp)
	{
		this.resp = resp;
	}

	public OcspResp(byte[] resp)
		: this(new Asn1InputStream(resp))
	{
	}

	public OcspResp(Stream inStr)
		: this(new Asn1InputStream(inStr))
	{
	}

	private OcspResp(Asn1InputStream aIn)
	{
		try
		{
			resp = OcspResponse.GetInstance(aIn.ReadObject());
		}
		catch (Exception ex)
		{
			throw new IOException("malformed response: " + ex.Message, ex);
		}
	}

	public object GetResponseObject()
	{
		ResponseBytes rb = resp.ResponseBytes;
		if (rb == null)
		{
			return null;
		}
		if (rb.ResponseType.Equals(OcspObjectIdentifiers.PkixOcspBasic))
		{
			try
			{
				return new BasicOcspResp(BasicOcspResponse.GetInstance(Asn1Object.FromByteArray(rb.Response.GetOctets())));
			}
			catch (Exception ex)
			{
				throw new OcspException("problem decoding object: " + ex, ex);
			}
		}
		return rb.Response;
	}

	public byte[] GetEncoded()
	{
		return resp.GetEncoded();
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is OcspResp other))
		{
			return false;
		}
		return resp.Equals(other.resp);
	}

	public override int GetHashCode()
	{
		return resp.GetHashCode();
	}
}
