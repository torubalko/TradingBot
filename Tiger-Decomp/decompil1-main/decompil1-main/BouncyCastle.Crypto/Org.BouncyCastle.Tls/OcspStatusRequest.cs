using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class OcspStatusRequest
{
	private readonly IList m_responderIDList;

	private readonly X509Extensions m_requestExtensions;

	public IList ResponderIDList => m_responderIDList;

	public X509Extensions RequestExtensions => m_requestExtensions;

	public OcspStatusRequest(IList responderIDList, X509Extensions requestExtensions)
	{
		m_responderIDList = responderIDList;
		m_requestExtensions = requestExtensions;
	}

	public void Encode(Stream output)
	{
		if (m_responderIDList == null || m_responderIDList.Count < 1)
		{
			TlsUtilities.WriteUint16(0, output);
		}
		else
		{
			MemoryStream buf = new MemoryStream();
			foreach (ResponderID responderID in m_responderIDList)
			{
				TlsUtilities.WriteOpaque16(responderID.GetEncoded("DER"), buf);
			}
			TlsUtilities.CheckUint16(buf.Length);
			TlsUtilities.WriteUint16((int)buf.Length, output);
			Streams.WriteBufTo(buf, output);
		}
		if (m_requestExtensions == null)
		{
			TlsUtilities.WriteUint16(0, output);
			return;
		}
		byte[] derEncoding = m_requestExtensions.GetEncoded("DER");
		TlsUtilities.CheckUint16(derEncoding.Length);
		TlsUtilities.WriteUint16(derEncoding.Length, output);
		output.Write(derEncoding, 0, derEncoding.Length);
	}

	public static OcspStatusRequest Parse(Stream input)
	{
		IList responderIDList = Platform.CreateArrayList();
		byte[] data = TlsUtilities.ReadOpaque16(input);
		if (data.Length != 0)
		{
			MemoryStream buf = new MemoryStream(data, writable: false);
			do
			{
				ResponderID responderID = ResponderID.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(buf, 1)));
				responderIDList.Add(responderID);
			}
			while (buf.Position < buf.Length);
		}
		X509Extensions requestExtensions = null;
		byte[] derEncoding = TlsUtilities.ReadOpaque16(input);
		if (derEncoding.Length != 0)
		{
			requestExtensions = X509Extensions.GetInstance(TlsUtilities.ReadDerObject(derEncoding));
		}
		return new OcspStatusRequest(responderIDList, requestExtensions);
	}
}
