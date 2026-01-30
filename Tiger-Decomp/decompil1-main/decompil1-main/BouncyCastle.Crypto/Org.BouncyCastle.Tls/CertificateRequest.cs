using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateRequest
{
	private readonly byte[] m_certificateRequestContext;

	private readonly short[] m_certificateTypes;

	private readonly IList m_supportedSignatureAlgorithms;

	private readonly IList m_supportedSignatureAlgorithmsCert;

	private readonly IList m_certificateAuthorities;

	public short[] CertificateTypes => m_certificateTypes;

	public IList SupportedSignatureAlgorithms => m_supportedSignatureAlgorithms;

	public IList SupportedSignatureAlgorithmsCert => m_supportedSignatureAlgorithmsCert;

	public IList CertificateAuthorities => m_certificateAuthorities;

	private static IList CheckSupportedSignatureAlgorithms(IList supportedSignatureAlgorithms, short alertDescription)
	{
		if (supportedSignatureAlgorithms == null)
		{
			throw new TlsFatalAlert(alertDescription, "'signature_algorithms' is required");
		}
		return supportedSignatureAlgorithms;
	}

	public CertificateRequest(short[] certificateTypes, IList supportedSignatureAlgorithms, IList certificateAuthorities)
		: this(null, certificateTypes, supportedSignatureAlgorithms, null, certificateAuthorities)
	{
	}

	public CertificateRequest(byte[] certificateRequestContext, IList supportedSignatureAlgorithms, IList supportedSignatureAlgorithmsCert, IList certificateAuthorities)
		: this(certificateRequestContext, null, CheckSupportedSignatureAlgorithms(supportedSignatureAlgorithms, 80), supportedSignatureAlgorithmsCert, certificateAuthorities)
	{
	}

	private CertificateRequest(byte[] certificateRequestContext, short[] certificateTypes, IList supportedSignatureAlgorithms, IList supportedSignatureAlgorithmsCert, IList certificateAuthorities)
	{
		if (certificateRequestContext != null && !TlsUtilities.IsValidUint8(certificateRequestContext.Length))
		{
			throw new ArgumentException("cannot be longer than 255", "certificateRequestContext");
		}
		if (certificateTypes != null && (certificateTypes.Length < 1 || !TlsUtilities.IsValidUint8(certificateTypes.Length)))
		{
			throw new ArgumentException("should have length from 1 to 255", "certificateTypes");
		}
		m_certificateRequestContext = TlsUtilities.Clone(certificateRequestContext);
		m_certificateTypes = certificateTypes;
		m_supportedSignatureAlgorithms = supportedSignatureAlgorithms;
		m_supportedSignatureAlgorithmsCert = supportedSignatureAlgorithmsCert;
		m_certificateAuthorities = certificateAuthorities;
	}

	public byte[] GetCertificateRequestContext()
	{
		return TlsUtilities.Clone(m_certificateRequestContext);
	}

	public bool HasCertificateRequestContext(byte[] certificateRequestContext)
	{
		return Arrays.AreEqual(m_certificateRequestContext, certificateRequestContext);
	}

	public void Encode(TlsContext context, Stream output)
	{
		ProtocolVersion serverVersion = context.ServerVersion;
		bool isTlsV12 = TlsUtilities.IsTlsV12(serverVersion);
		bool isTlsV13 = TlsUtilities.IsTlsV13(serverVersion);
		if (isTlsV13 != (m_certificateRequestContext != null) || isTlsV13 != (m_certificateTypes == null) || isTlsV12 != (m_supportedSignatureAlgorithms != null) || (!isTlsV13 && m_supportedSignatureAlgorithmsCert != null))
		{
			throw new InvalidOperationException();
		}
		if (isTlsV13)
		{
			TlsUtilities.WriteOpaque8(m_certificateRequestContext, output);
			IDictionary extensions = Platform.CreateHashtable();
			TlsExtensionsUtilities.AddSignatureAlgorithmsExtension(extensions, m_supportedSignatureAlgorithms);
			if (m_supportedSignatureAlgorithmsCert != null)
			{
				TlsExtensionsUtilities.AddSignatureAlgorithmsCertExtension(extensions, m_supportedSignatureAlgorithmsCert);
			}
			if (m_certificateAuthorities != null)
			{
				TlsExtensionsUtilities.AddCertificateAuthoritiesExtension(extensions, m_certificateAuthorities);
			}
			TlsUtilities.WriteOpaque16(TlsProtocol.WriteExtensionsData(extensions), output);
			return;
		}
		TlsUtilities.WriteUint8ArrayWithUint8Length(m_certificateTypes, output);
		if (isTlsV12)
		{
			TlsUtilities.EncodeSupportedSignatureAlgorithms(m_supportedSignatureAlgorithms, output);
		}
		if (m_certificateAuthorities == null || m_certificateAuthorities.Count < 1)
		{
			TlsUtilities.WriteUint16(0, output);
			return;
		}
		IList derEncodings = Platform.CreateArrayList(m_certificateAuthorities.Count);
		int totalLength = 0;
		foreach (X509Name certificateAuthority in m_certificateAuthorities)
		{
			byte[] derEncoding = certificateAuthority.GetEncoded("DER");
			derEncodings.Add(derEncoding);
			totalLength += derEncoding.Length + 2;
		}
		TlsUtilities.CheckUint16(totalLength);
		TlsUtilities.WriteUint16(totalLength, output);
		foreach (byte[] item in derEncodings)
		{
			TlsUtilities.WriteOpaque16(item, output);
		}
	}

	public static CertificateRequest Parse(TlsContext context, Stream input)
	{
		ProtocolVersion negotiatedVersion = context.ServerVersion;
		if (TlsUtilities.IsTlsV13(negotiatedVersion))
		{
			byte[] certificateRequestContext = TlsUtilities.ReadOpaque8(input);
			byte[] extEncoding = TlsUtilities.ReadOpaque16(input);
			IDictionary extensions = TlsProtocol.ReadExtensionsData13(13, extEncoding);
			IList supportedSignatureAlgorithms13 = CheckSupportedSignatureAlgorithms(TlsExtensionsUtilities.GetSignatureAlgorithmsExtension(extensions), 109);
			IList supportedSignatureAlgorithmsCert13 = TlsExtensionsUtilities.GetSignatureAlgorithmsCertExtension(extensions);
			IList certificateAuthorities13 = TlsExtensionsUtilities.GetCertificateAuthoritiesExtension(extensions);
			return new CertificateRequest(certificateRequestContext, supportedSignatureAlgorithms13, supportedSignatureAlgorithmsCert13, certificateAuthorities13);
		}
		bool num = TlsUtilities.IsTlsV12(negotiatedVersion);
		short[] certificateTypes = TlsUtilities.ReadUint8ArrayWithUint8Length(input, 1);
		IList supportedSignatureAlgorithms14 = null;
		if (num)
		{
			supportedSignatureAlgorithms14 = TlsUtilities.ParseSupportedSignatureAlgorithms(input);
		}
		IList certificateAuthorities14 = null;
		byte[] certAuthData = TlsUtilities.ReadOpaque16(input);
		if (certAuthData.Length != 0)
		{
			certificateAuthorities14 = Platform.CreateArrayList();
			MemoryStream bis = new MemoryStream(certAuthData, writable: false);
			do
			{
				Asn1Object asn1 = TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(bis, 1));
				certificateAuthorities14.Add(X509Name.GetInstance(asn1));
			}
			while (bis.Position < bis.Length);
		}
		return new CertificateRequest(certificateTypes, supportedSignatureAlgorithms14, certificateAuthorities14);
	}
}
