using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class Certificate
{
	public static readonly Certificate EmptyChain = new Certificate(new X509CertificateStructure[0]);

	protected readonly X509CertificateStructure[] mCertificateList;

	public virtual int Length => mCertificateList.Length;

	public virtual bool IsEmpty => mCertificateList.Length == 0;

	public Certificate(X509CertificateStructure[] certificateList)
	{
		if (certificateList == null)
		{
			throw new ArgumentNullException("certificateList");
		}
		mCertificateList = certificateList;
	}

	public virtual X509CertificateStructure[] GetCertificateList()
	{
		return CloneCertificateList();
	}

	public virtual X509CertificateStructure GetCertificateAt(int index)
	{
		return mCertificateList[index];
	}

	public virtual void Encode(Stream output)
	{
		IList derEncodings = Platform.CreateArrayList(mCertificateList.Length);
		int totalLength = 0;
		X509CertificateStructure[] array = mCertificateList;
		for (int i = 0; i < array.Length; i++)
		{
			byte[] derEncoding = array[i].GetEncoded("DER");
			derEncodings.Add(derEncoding);
			totalLength += derEncoding.Length + 3;
		}
		TlsUtilities.CheckUint24(totalLength);
		TlsUtilities.WriteUint24(totalLength, output);
		foreach (byte[] item in derEncodings)
		{
			TlsUtilities.WriteOpaque24(item, output);
		}
	}

	public static Certificate Parse(Stream input)
	{
		int totalLength = TlsUtilities.ReadUint24(input);
		if (totalLength == 0)
		{
			return EmptyChain;
		}
		MemoryStream buf = new MemoryStream(TlsUtilities.ReadFully(totalLength, input), writable: false);
		IList certificate_list = Platform.CreateArrayList();
		while (buf.Position < buf.Length)
		{
			Asn1Object asn1Cert = TlsUtilities.ReadAsn1Object(TlsUtilities.ReadOpaque24(buf));
			certificate_list.Add(X509CertificateStructure.GetInstance(asn1Cert));
		}
		X509CertificateStructure[] certificateList = new X509CertificateStructure[certificate_list.Count];
		for (int i = 0; i < certificate_list.Count; i++)
		{
			certificateList[i] = (X509CertificateStructure)certificate_list[i];
		}
		return new Certificate(certificateList);
	}

	protected virtual X509CertificateStructure[] CloneCertificateList()
	{
		return (X509CertificateStructure[])mCertificateList.Clone();
	}
}
