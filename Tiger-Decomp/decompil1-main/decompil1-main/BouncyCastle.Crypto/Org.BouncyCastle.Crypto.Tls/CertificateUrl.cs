using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class CertificateUrl
{
	internal class ListBuffer16 : MemoryStream
	{
		internal ListBuffer16()
		{
			TlsUtilities.WriteUint16(0, this);
		}

		internal void EncodeTo(Stream output)
		{
			long num = Length - 2;
			TlsUtilities.CheckUint16(num);
			Position = 0L;
			TlsUtilities.WriteUint16((int)num, this);
			Streams.WriteBufTo(this, output);
			Platform.Dispose(this);
		}
	}

	protected readonly byte mType;

	protected readonly IList mUrlAndHashList;

	public virtual byte Type => mType;

	public virtual IList UrlAndHashList => mUrlAndHashList;

	public CertificateUrl(byte type, IList urlAndHashList)
	{
		if (!CertChainType.IsValid(type))
		{
			throw new ArgumentException("not a valid CertChainType value", "type");
		}
		if (urlAndHashList == null || urlAndHashList.Count < 1)
		{
			throw new ArgumentException("must have length > 0", "urlAndHashList");
		}
		mType = type;
		mUrlAndHashList = urlAndHashList;
	}

	public virtual void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(mType, output);
		ListBuffer16 buf = new ListBuffer16();
		foreach (UrlAndHash mUrlAndHash in mUrlAndHashList)
		{
			mUrlAndHash.Encode(buf);
		}
		buf.EncodeTo(output);
	}

	public static CertificateUrl parse(TlsContext context, Stream input)
	{
		byte type = TlsUtilities.ReadUint8(input);
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
		return new CertificateUrl(type, url_and_hash_list);
	}
}
