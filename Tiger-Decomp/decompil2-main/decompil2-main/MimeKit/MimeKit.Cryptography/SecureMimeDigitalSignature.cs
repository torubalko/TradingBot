using System;
using System.Collections;
using System.Collections.Generic;
using MimeKit.Utils;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Smime;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class SecureMimeDigitalSignature : IDigitalSignature
{
	private DigitalSignatureVerifyException vex;

	private bool? valid;

	public SignerInformation SignerInfo { get; private set; }

	public EncryptionAlgorithm[] EncryptionAlgorithms { get; private set; }

	public PkixCertPath Chain { get; internal set; }

	public Exception ChainException { get; internal set; }

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

	private static DateTime ToAdjustedDateTime(DerUtcTime time)
	{
		return DateUtils.Parse(time.AdjustedTimeString, "yyyyMMddHHmmsszzz");
	}

	public SecureMimeDigitalSignature(SignerInformation signerInfo, X509Certificate certificate)
	{
		if (signerInfo == null)
		{
			throw new ArgumentNullException("signerInfo");
		}
		SignerInfo = signerInfo;
		List<EncryptionAlgorithm> list = new List<EncryptionAlgorithm>();
		if (signerInfo.SignedAttributes != null)
		{
			Asn1EncodableVector all = signerInfo.SignedAttributes.GetAll(CmsAttributes.SigningTime);
			{
				IEnumerator enumerator = all.GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						Org.BouncyCastle.Asn1.Cms.Attribute attribute = (Org.BouncyCastle.Asn1.Cms.Attribute)enumerator.Current;
						DerUtcTime time = (DerUtcTime)((DerSet)attribute.AttrValues)[0];
						CreationDate = ToAdjustedDateTime(time);
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			all = signerInfo.SignedAttributes.GetAll(SmimeAttributes.SmimeCapabilities);
			foreach (Org.BouncyCastle.Asn1.Cms.Attribute item in all)
			{
				foreach (Asn1Sequence attrValue in item.AttrValues)
				{
					for (int i = 0; i < attrValue.Count; i++)
					{
						AlgorithmIdentifier instance = AlgorithmIdentifier.GetInstance(attrValue[i]);
						if (BouncyCastleSecureMimeContext.TryGetEncryptionAlgorithm(instance, out var algorithm))
						{
							list.Add(algorithm);
						}
					}
				}
			}
		}
		EncryptionAlgorithms = list.ToArray();
		if (BouncyCastleSecureMimeContext.TryGetDigestAlgorithm(signerInfo.DigestAlgorithmID, out var algorithm2))
		{
			DigestAlgorithm = algorithm2;
		}
		if (certificate != null)
		{
			SignerCertificate = new SecureMimeDigitalCertificate(certificate);
		}
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
		if (SignerCertificate == null)
		{
			string message = "Failed to verify digital signature: missing certificate.";
			vex = new DigitalSignatureVerifyException(message);
			throw vex;
		}
		if (!valid.HasValue)
		{
			try
			{
				X509Certificate certificate = ((SecureMimeDigitalCertificate)SignerCertificate).Certificate;
				valid = SignerInfo.Verify(certificate);
			}
			catch (Exception ex)
			{
				string message2 = $"Failed to verify digital signature: {ex.Message}";
				vex = new DigitalSignatureVerifyException(message2, ex);
				throw vex;
			}
		}
		if (!verifySignatureOnly && ChainException != null)
		{
			string message3 = $"Failed to verify digital signature chain: {ChainException.Message}";
			throw new DigitalSignatureVerifyException(message3, ChainException);
		}
		return valid.Value;
	}
}
