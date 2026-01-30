using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Smime;
using Org.BouncyCastle.Asn1.X509;

namespace MimeKit.Cryptography;

public class WindowsSecureMimeDigitalSignature : IDigitalSignature
{
	private DigitalSignatureVerifyException vex;

	public System.Security.Cryptography.Pkcs.SignerInfo SignerInfo { get; private set; }

	public EncryptionAlgorithm[] EncryptionAlgorithms { get; private set; }

	public IDigitalCertificate SignerCertificate { get; private set; }

	public PublicKeyAlgorithm PublicKeyAlgorithm
	{
		get
		{
			if (SignerCertificate == null)
			{
				return PublicKeyAlgorithm.None;
			}
			return SignerCertificate.PublicKeyAlgorithm;
		}
	}

	public DigestAlgorithm DigestAlgorithm { get; private set; }

	public DateTime CreationDate { get; private set; }

	public WindowsSecureMimeDigitalSignature(System.Security.Cryptography.Pkcs.SignerInfo signerInfo)
	{
		if (signerInfo == null)
		{
			throw new ArgumentNullException("signerInfo");
		}
		SignerInfo = signerInfo;
		List<EncryptionAlgorithm> list = new List<EncryptionAlgorithm>();
		if (signerInfo.SignedAttributes != null)
		{
			for (int i = 0; i < signerInfo.SignedAttributes.Count; i++)
			{
				if (signerInfo.SignedAttributes[i].Oid.Value == CmsAttributes.SigningTime.Id)
				{
					if (signerInfo.SignedAttributes[i].Values[0] is Pkcs9SigningTime pkcs9SigningTime)
					{
						CreationDate = pkcs9SigningTime.SigningTime;
					}
				}
				else
				{
					if (!(signerInfo.SignedAttributes[i].Oid.Value == SmimeAttributes.SmimeCapabilities.Id))
					{
						continue;
					}
					AsnEncodedDataEnumerator enumerator = signerInfo.SignedAttributes[i].Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						AsnEncodedData current = enumerator.Current;
						DerSequence derSequence = (DerSequence)Asn1Object.FromByteArray(current.RawData);
						foreach (Asn1Sequence item in derSequence)
						{
							Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier instance = Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(item);
							if (BouncyCastleSecureMimeContext.TryGetEncryptionAlgorithm(instance, out var algorithm))
							{
								list.Add(algorithm);
							}
						}
					}
				}
			}
		}
		EncryptionAlgorithms = list.ToArray();
		if (WindowsSecureMimeContext.TryGetDigestAlgorithm(signerInfo.DigestAlgorithm, out var algorithm2))
		{
			DigestAlgorithm = algorithm2;
		}
		SignerCertificate = new WindowsSecureMimeDigitalCertificate(signerInfo.Certificate);
	}

	public bool Verify()
	{
		return Verify(verifySignatureOnly: false);
	}

	public bool Verify(bool verifySignatureOnly)
	{
		if (vex != null)
		{
			throw vex;
		}
		try
		{
			SignerInfo.CheckSignature(verifySignatureOnly);
			return true;
		}
		catch (Exception ex)
		{
			string message = $"Failed to verify digital signature: {ex.Message}";
			vex = new DigitalSignatureVerifyException(message, ex);
			throw vex;
		}
	}
}
