using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateUrl
{
	internal class ListBuffer16 : MemoryStream
	{
		internal ListBuffer16()
		{
			TlsUtilities.WriteUint16(0, this);
		}

		internal void EncodeTo(Stream output)
		{
			int i = (int)Length - 2;
			TlsUtilities.CheckUint16(i);
			Seek(0L, SeekOrigin.Begin);
			TlsUtilities.WriteUint16(i, this);
			Streams.WriteBufTo(this, output);
			Platform.Dispose(this);
		}
	}

	private readonly short m_type;

	private readonly IList m_urlAndHashList;

	public short Type => m_type;

	public IList UrlAndHashList => m_urlAndHashList;

	public CertificateUrl(short type, IList urlAndHashList)
	{
		if (!CertChainType.IsValid(type))
		{
			throw new ArgumentException("not a valid CertChainType value", "type");
		}
		if (urlAndHashList == null || urlAndHashList.Count < 1)
		{
			throw new ArgumentException("must have length > 0", "urlAndHashList");
		}
		if (type == 1 && urlAndHashList.Count != 1)
		{
			throw new ArgumentException("must contain exactly one entry when type is " + CertChainType.GetText(type), "urlAndHashList");
		}
		m_type = type;
		m_urlAndHashList = urlAndHashList;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_type, output);
		ListBuffer16 buf = new ListBuffer16();
		foreach (UrlAndHash urlAndHash in m_urlAndHashList)
		{
			urlAndHash.Encode(buf);
		}
		buf.EncodeTo(output);
	}

	public static CertificateUrl Parse(TlsContext context, Stream input)
	{
		short type = TlsUtilities.ReadUint8(input);
		if (!CertChainType.IsValid(type))
		{
			throw new TlsFatalAlert(50);
		}
		int num = TlsUtilities.ReadUint16(input);
		if (num < 1)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream buf = new MemoryStream(TlsUtilities.ReadFully(num, input), writable: false);
		IList url_and_hash_list = Platform.CreateArrayList();
		while (buf.Position < buf.Length)
		{
			UrlAndHash url_and_hash = UrlAndHash.Parse(context, buf);
			url_and_hash_list.Add(url_and_hash);
		}
		if (type == 1 && url_and_hash_list.Count != 1)
		{
			throw new TlsFatalAlert(50);
		}
		return new CertificateUrl(type, url_and_hash_list);
	}
}
