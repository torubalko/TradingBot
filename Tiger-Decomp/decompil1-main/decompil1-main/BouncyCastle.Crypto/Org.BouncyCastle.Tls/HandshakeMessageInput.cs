using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class HandshakeMessageInput : MemoryStream
{
	private readonly int m_offset;

	internal HandshakeMessageInput(byte[] buf, int offset, int length)
		: base(buf, offset, length, writable: false, publiclyVisible: true)
	{
		m_offset = offset;
	}

	public void UpdateHash(TlsHash hash)
	{
		Streams.WriteBufTo(this, new TlsHashSink(hash));
	}

	internal void UpdateHashPrefix(TlsHash hash, int bindersSize)
	{
		byte[] buf = GetBuffer();
		int count = (int)Length;
		hash.Update(buf, m_offset, count - bindersSize);
	}

	internal void UpdateHashSuffix(TlsHash hash, int bindersSize)
	{
		byte[] buf = GetBuffer();
		int count = (int)Length;
		hash.Update(buf, m_offset + count - bindersSize, bindersSize);
	}
}
