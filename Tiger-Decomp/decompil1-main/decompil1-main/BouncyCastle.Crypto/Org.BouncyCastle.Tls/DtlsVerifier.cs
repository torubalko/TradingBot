using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class DtlsVerifier
{
	private readonly TlsMac m_cookieMac;

	private readonly TlsMacSink m_cookieMacSink;

	private static TlsMac CreateCookieMac(TlsCrypto crypto)
	{
		TlsHmac tlsHmac = crypto.CreateHmac(3);
		byte[] secret = new byte[tlsHmac.MacLength];
		crypto.SecureRandom.NextBytes(secret);
		tlsHmac.SetKey(secret, 0, secret.Length);
		return tlsHmac;
	}

	public DtlsVerifier(TlsCrypto crypto)
	{
		m_cookieMac = CreateCookieMac(crypto);
		m_cookieMacSink = new TlsMacSink(m_cookieMac);
	}

	public virtual DtlsRequest VerifyRequest(byte[] clientID, byte[] data, int dataOff, int dataLen, DatagramSender sender)
	{
		lock (this)
		{
			bool resetCookieMac = true;
			try
			{
				m_cookieMac.Update(clientID, 0, clientID.Length);
				DtlsRequest request = DtlsReliableHandshake.ReadClientRequest(data, dataOff, dataLen, m_cookieMacSink);
				if (request != null)
				{
					byte[] expectedCookie = m_cookieMac.CalculateMac();
					resetCookieMac = false;
					if (Arrays.ConstantTimeAreEqual(expectedCookie, request.ClientHello.Cookie))
					{
						return request;
					}
					DtlsReliableHandshake.SendHelloVerifyRequest(sender, request.RecordSeq, expectedCookie);
				}
			}
			catch (IOException)
			{
			}
			finally
			{
				if (resetCookieMac)
				{
					m_cookieMac.Reset();
				}
			}
			return null;
		}
	}
}
