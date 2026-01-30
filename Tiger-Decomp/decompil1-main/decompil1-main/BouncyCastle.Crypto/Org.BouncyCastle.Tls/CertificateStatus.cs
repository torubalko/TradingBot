using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateStatus
{
	private readonly short m_statusType;

	private readonly object m_response;

	public short StatusType => m_statusType;

	public object Response => m_response;

	public OcspResponse OcspResponse
	{
		get
		{
			if (!IsCorrectType(1, m_response))
			{
				throw new InvalidOperationException("'response' is not an OCSPResponse");
			}
			return (OcspResponse)m_response;
		}
	}

	public IList OcspResponseList
	{
		get
		{
			if (!IsCorrectType(2, m_response))
			{
				throw new InvalidOperationException("'response' is not an OCSPResponseList");
			}
			return (IList)m_response;
		}
	}

	public CertificateStatus(short statusType, object response)
	{
		if (!IsCorrectType(statusType, response))
		{
			throw new ArgumentException("not an instance of the correct type", "response");
		}
		m_statusType = statusType;
		m_response = response;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_statusType, output);
		switch (m_statusType)
		{
		case 1:
			TlsUtilities.WriteOpaque24(((OcspResponse)m_response).GetEncoded("DER"), output);
			break;
		case 2:
		{
			IList obj = (IList)m_response;
			IList derEncodings = Platform.CreateArrayList(obj.Count);
			long totalLength = 0L;
			foreach (OcspResponse ocspResponse in obj)
			{
				if (ocspResponse == null)
				{
					derEncodings.Add(TlsUtilities.EmptyBytes);
				}
				else
				{
					byte[] derEncoding = ocspResponse.GetEncoded("DER");
					derEncodings.Add(derEncoding);
					totalLength += derEncoding.Length;
				}
				totalLength += 3;
			}
			TlsUtilities.CheckUint24(totalLength);
			TlsUtilities.WriteUint24((int)totalLength, output);
			{
				foreach (byte[] item in derEncodings)
				{
					TlsUtilities.WriteOpaque24(item, output);
				}
				break;
			}
		}
		default:
			throw new TlsFatalAlert(80);
		}
	}

	public static CertificateStatus Parse(TlsContext context, Stream input)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		Certificate peerCertificate = securityParameters.PeerCertificate;
		if (peerCertificate == null || peerCertificate.IsEmpty || peerCertificate.CertificateType != 0)
		{
			throw new TlsFatalAlert(80);
		}
		int certificateCount = peerCertificate.Length;
		int statusRequestVersion = securityParameters.StatusRequestVersion;
		short status_type = TlsUtilities.ReadUint8(input);
		object response;
		switch (status_type)
		{
		case 1:
			RequireStatusRequestVersion(1, statusRequestVersion);
			response = OcspResponse.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque24(input, 1)));
			break;
		case 2:
		{
			RequireStatusRequestVersion(2, statusRequestVersion);
			MemoryStream buf = new MemoryStream(TlsUtilities.ReadOpaque24(input, 1), writable: false);
			IList ocspResponseList = Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				if (ocspResponseList.Count >= certificateCount)
				{
					throw new TlsFatalAlert(47);
				}
				int length = TlsUtilities.ReadUint24(buf);
				if (length < 1)
				{
					ocspResponseList.Add(null);
					continue;
				}
				OcspResponse ocspResponse = OcspResponse.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadFully(length, buf)));
				ocspResponseList.Add(ocspResponse);
			}
			response = Platform.CreateArrayList(ocspResponseList);
			break;
		}
		default:
			throw new TlsFatalAlert(50);
		}
		return new CertificateStatus(status_type, response);
	}

	private static bool IsCorrectType(short statusType, object response)
	{
		return statusType switch
		{
			1 => response is OcspResponse, 
			2 => IsOcspResponseList(response), 
			_ => throw new ArgumentException("unsupported CertificateStatusType", "statusType"), 
		};
	}

	private static bool IsOcspResponseList(object response)
	{
		if (!(response is IList))
		{
			return false;
		}
		IList v = (IList)response;
		if (v.Count < 1)
		{
			return false;
		}
		foreach (object e in v)
		{
			if (e != null && !(e is OcspResponse))
			{
				return false;
			}
		}
		return true;
	}

	private static void RequireStatusRequestVersion(int minVersion, int statusRequestVersion)
	{
		if (statusRequestVersion < minVersion)
		{
			throw new TlsFatalAlert(50);
		}
	}
}
