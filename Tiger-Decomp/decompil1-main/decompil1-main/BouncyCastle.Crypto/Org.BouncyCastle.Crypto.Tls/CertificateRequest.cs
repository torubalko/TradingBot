using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class CertificateRequest
{
	protected readonly byte[] mCertificateTypes;

	protected readonly IList mSupportedSignatureAlgorithms;

	protected readonly IList mCertificateAuthorities;

	public virtual byte[] CertificateTypes => mCertificateTypes;

	public virtual IList SupportedSignatureAlgorithms => mSupportedSignatureAlgorithms;

	public virtual IList CertificateAuthorities => mCertificateAuthorities;

	public CertificateRequest(byte[] certificateTypes, IList supportedSignatureAlgorithms, IList certificateAuthorities)
	{
		mCertificateTypes = certificateTypes;
		mSupportedSignatureAlgorithms = supportedSignatureAlgorithms;
		mCertificateAuthorities = certificateAuthorities;
	}

	public virtual void Encode(Stream output)
	{
		if (mCertificateTypes == null || mCertificateTypes.Length == 0)
		{
			TlsUtilities.WriteUint8(0, output);
		}
		else
		{
			TlsUtilities.WriteUint8ArrayWithUint8Length(mCertificateTypes, output);
		}
		if (mSupportedSignatureAlgorithms != null)
		{
			TlsUtilities.EncodeSupportedSignatureAlgorithms(mSupportedSignatureAlgorithms, allowAnonymous: false, output);
		}
		if (mCertificateAuthorities == null || mCertificateAuthorities.Count < 1)
		{
			TlsUtilities.WriteUint16(0, output);
			return;
		}
		IList derEncodings = Platform.CreateArrayList(mCertificateAuthorities.Count);
		int totalLength = 0;
		foreach (Asn1Encodable mCertificateAuthority in mCertificateAuthorities)
		{
			byte[] derEncoding = mCertificateAuthority.GetEncoded("DER");
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
		int numTypes = TlsUtilities.ReadUint8(input);
		byte[] certificateTypes = new byte[numTypes];
		for (int i = 0; i < numTypes; i++)
		{
			certificateTypes[i] = TlsUtilities.ReadUint8(input);
		}
		IList supportedSignatureAlgorithms = null;
		if (TlsUtilities.IsTlsV12(context))
		{
			supportedSignatureAlgorithms = TlsUtilities.ParseSupportedSignatureAlgorithms(allowAnonymous: false, input);
		}
		IList certificateAuthorities = Platform.CreateArrayList();
		MemoryStream bis = new MemoryStream(TlsUtilities.ReadOpaque16(input), writable: false);
		while (bis.Position < bis.Length)
		{
			Asn1Object asn1 = TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(bis));
			certificateAuthorities.Add(X509Name.GetInstance(asn1));
		}
		return new CertificateRequest(certificateTypes, supportedSignatureAlgorithms, certificateAuthorities);
	}
}
