using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class Certificate
{
	public sealed class ParseOptions
	{
		private int m_maxChainLength = int.MaxValue;

		public int MaxChainLength => m_maxChainLength;

		public ParseOptions SetMaxChainLength(int maxChainLength)
		{
			m_maxChainLength = maxChainLength;
			return this;
		}
	}

	private static readonly TlsCertificate[] EmptyCerts = new TlsCertificate[0];

	private static readonly CertificateEntry[] EmptyCertEntries = new CertificateEntry[0];

	public static readonly Certificate EmptyChain = new Certificate(EmptyCerts);

	public static readonly Certificate EmptyChainTls13 = new Certificate(TlsUtilities.EmptyBytes, EmptyCertEntries);

	private readonly byte[] m_certificateRequestContext;

	private readonly CertificateEntry[] m_certificateEntryList;

	public short CertificateType => 0;

	public int Length => m_certificateEntryList.Length;

	public bool IsEmpty => m_certificateEntryList.Length == 0;

	private static CertificateEntry[] Convert(TlsCertificate[] certificateList)
	{
		if (TlsUtilities.IsNullOrContainsNull(certificateList))
		{
			throw new ArgumentException("cannot be null or contain any nulls", "certificateList");
		}
		int count = certificateList.Length;
		CertificateEntry[] result = new CertificateEntry[count];
		for (int i = 0; i < count; i++)
		{
			result[i] = new CertificateEntry(certificateList[i], null);
		}
		return result;
	}

	public Certificate(TlsCertificate[] certificateList)
		: this(null, Convert(certificateList))
	{
	}

	public Certificate(byte[] certificateRequestContext, CertificateEntry[] certificateEntryList)
	{
		if (certificateRequestContext != null && !TlsUtilities.IsValidUint8(certificateRequestContext.Length))
		{
			throw new ArgumentException("cannot be longer than 255", "certificateRequestContext");
		}
		if (TlsUtilities.IsNullOrContainsNull(certificateEntryList))
		{
			throw new ArgumentException("cannot be null or contain any nulls", "certificateEntryList");
		}
		m_certificateRequestContext = TlsUtilities.Clone(certificateRequestContext);
		m_certificateEntryList = certificateEntryList;
	}

	public byte[] GetCertificateRequestContext()
	{
		return TlsUtilities.Clone(m_certificateRequestContext);
	}

	public TlsCertificate[] GetCertificateList()
	{
		return CloneCertificateList();
	}

	public TlsCertificate GetCertificateAt(int index)
	{
		return m_certificateEntryList[index].Certificate;
	}

	public CertificateEntry GetCertificateEntryAt(int index)
	{
		return m_certificateEntryList[index];
	}

	public CertificateEntry[] GetCertificateEntryList()
	{
		return CloneCertificateEntryList();
	}

	public void Encode(TlsContext context, Stream messageOutput, Stream endPointHashOutput)
	{
		bool isTlsV13 = TlsUtilities.IsTlsV13(context);
		if (m_certificateRequestContext != null != isTlsV13)
		{
			throw new InvalidOperationException();
		}
		if (isTlsV13)
		{
			TlsUtilities.WriteOpaque8(m_certificateRequestContext, messageOutput);
		}
		int count = m_certificateEntryList.Length;
		IList certEncodings = Platform.CreateArrayList(count);
		IList extEncodings = (isTlsV13 ? Platform.CreateArrayList(count) : null);
		long totalLength = 0L;
		for (int i = 0; i < count; i++)
		{
			CertificateEntry entry = m_certificateEntryList[i];
			TlsCertificate cert = entry.Certificate;
			byte[] derEncoding = cert.GetEncoded();
			if (i == 0 && endPointHashOutput != null)
			{
				CalculateEndPointHash(context, cert, derEncoding, endPointHashOutput);
			}
			certEncodings.Add(derEncoding);
			totalLength += derEncoding.Length;
			totalLength += 3;
			if (isTlsV13)
			{
				IDictionary extensions = entry.Extensions;
				byte[] extEncoding = ((extensions == null) ? TlsUtilities.EmptyBytes : TlsProtocol.WriteExtensionsData(extensions));
				extEncodings.Add(extEncoding);
				totalLength += extEncoding.Length;
				totalLength += 2;
			}
		}
		TlsUtilities.CheckUint24(totalLength);
		TlsUtilities.WriteUint24((int)totalLength, messageOutput);
		for (int j = 0; j < count; j++)
		{
			TlsUtilities.WriteOpaque24((byte[])certEncodings[j], messageOutput);
			if (isTlsV13)
			{
				TlsUtilities.WriteOpaque16((byte[])extEncodings[j], messageOutput);
			}
		}
	}

	public static Certificate Parse(ParseOptions options, TlsContext context, Stream messageInput, Stream endPointHashOutput)
	{
		bool isTlsV13 = TlsUtilities.IsTlsV13(context.SecurityParameters.NegotiatedVersion);
		byte[] certificateRequestContext = null;
		if (isTlsV13)
		{
			certificateRequestContext = TlsUtilities.ReadOpaque8(messageInput);
		}
		int totalLength = TlsUtilities.ReadUint24(messageInput);
		if (totalLength == 0)
		{
			if (isTlsV13)
			{
				if (certificateRequestContext.Length >= 1)
				{
					return new Certificate(certificateRequestContext, EmptyCertEntries);
				}
				return EmptyChainTls13;
			}
			return EmptyChain;
		}
		MemoryStream buf = new MemoryStream(TlsUtilities.ReadFully(totalLength, messageInput), writable: false);
		TlsCrypto crypto = context.Crypto;
		int maxChainLength = System.Math.Max(1, options.MaxChainLength);
		IList certificate_list = Platform.CreateArrayList();
		while (buf.Position < buf.Length)
		{
			if (certificate_list.Count >= maxChainLength)
			{
				throw new TlsFatalAlert(80, "Certificate chain longer than maximum (" + maxChainLength + ")");
			}
			byte[] derEncoding = TlsUtilities.ReadOpaque24(buf, 1);
			TlsCertificate cert = crypto.CreateCertificate(derEncoding);
			if (certificate_list.Count < 1 && endPointHashOutput != null)
			{
				CalculateEndPointHash(context, cert, derEncoding, endPointHashOutput);
			}
			IDictionary extensions = null;
			if (isTlsV13)
			{
				byte[] extEncoding = TlsUtilities.ReadOpaque16(buf);
				extensions = TlsProtocol.ReadExtensionsData13(11, extEncoding);
			}
			certificate_list.Add(new CertificateEntry(cert, extensions));
		}
		CertificateEntry[] certificateList = new CertificateEntry[certificate_list.Count];
		for (int i = 0; i < certificate_list.Count; i++)
		{
			certificateList[i] = (CertificateEntry)certificate_list[i];
		}
		return new Certificate(certificateRequestContext, certificateList);
	}

	private static void CalculateEndPointHash(TlsContext context, TlsCertificate cert, byte[] encoding, Stream output)
	{
		byte[] endPointHash = TlsUtilities.CalculateEndPointHash(context, cert, encoding);
		if (endPointHash != null && endPointHash.Length != 0)
		{
			output.Write(endPointHash, 0, endPointHash.Length);
		}
	}

	private TlsCertificate[] CloneCertificateList()
	{
		int count = m_certificateEntryList.Length;
		if (count == 0)
		{
			return EmptyCerts;
		}
		TlsCertificate[] result = new TlsCertificate[count];
		for (int i = 0; i < count; i++)
		{
			result[i] = m_certificateEntryList[i].Certificate;
		}
		return result;
	}

	private CertificateEntry[] CloneCertificateEntryList()
	{
		int count = m_certificateEntryList.Length;
		if (count == 0)
		{
			return EmptyCertEntries;
		}
		CertificateEntry[] result = new CertificateEntry[count];
		Array.Copy(m_certificateEntryList, 0, result, 0, count);
		return result;
	}
}
