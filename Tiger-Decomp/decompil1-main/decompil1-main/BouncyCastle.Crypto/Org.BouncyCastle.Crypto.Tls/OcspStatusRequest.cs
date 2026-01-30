using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class OcspStatusRequest
{
	protected readonly IList mResponderIDList;

	protected readonly X509Extensions mRequestExtensions;

	public virtual IList ResponderIDList => mResponderIDList;

	public virtual X509Extensions RequestExtensions => mRequestExtensions;

	public OcspStatusRequest(IList responderIDList, X509Extensions requestExtensions)
	{
		mResponderIDList = responderIDList;
		mRequestExtensions = requestExtensions;
	}

	public virtual void Encode(Stream output)
	{
		if (mResponderIDList == null || mResponderIDList.Count < 1)
		{
			TlsUtilities.WriteUint16(0, output);
		}
		else
		{
			MemoryStream buf = new MemoryStream();
			for (int i = 0; i < mResponderIDList.Count; i++)
			{
				TlsUtilities.WriteOpaque16(((ResponderID)mResponderIDList[i]).GetEncoded("DER"), buf);
			}
			TlsUtilities.CheckUint16(buf.Length);
			TlsUtilities.WriteUint16((int)buf.Length, output);
			Streams.WriteBufTo(buf, output);
		}
		if (mRequestExtensions == null)
		{
			TlsUtilities.WriteUint16(0, output);
			return;
		}
		byte[] derEncoding = mRequestExtensions.GetEncoded("DER");
		TlsUtilities.CheckUint16(derEncoding.Length);
		TlsUtilities.WriteUint16(derEncoding.Length, output);
		output.Write(derEncoding, 0, derEncoding.Length);
	}

	public static OcspStatusRequest Parse(Stream input)
	{
		IList responderIDList = Platform.CreateArrayList();
		int length = TlsUtilities.ReadUint16(input);
		if (length > 0)
		{
			MemoryStream buf = new MemoryStream(TlsUtilities.ReadFully(length, input), writable: false);
			do
			{
				ResponderID responderID = ResponderID.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(buf)));
				responderIDList.Add(responderID);
			}
			while (buf.Position < buf.Length);
		}
		X509Extensions requestExtensions = null;
		int length2 = TlsUtilities.ReadUint16(input);
		if (length2 > 0)
		{
			requestExtensions = X509Extensions.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadFully(length2, input)));
		}
		return new OcspStatusRequest(responderIDList, requestExtensions);
	}
}
