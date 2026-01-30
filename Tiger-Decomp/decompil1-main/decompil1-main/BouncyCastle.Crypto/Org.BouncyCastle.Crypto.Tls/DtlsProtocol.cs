using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public abstract class DtlsProtocol
{
	protected readonly SecureRandom mSecureRandom;

	protected DtlsProtocol(SecureRandom secureRandom)
	{
		if (secureRandom == null)
		{
			throw new ArgumentNullException("secureRandom");
		}
		mSecureRandom = secureRandom;
	}

	protected virtual void ProcessFinished(byte[] body, byte[] expected_verify_data)
	{
		MemoryStream buf = new MemoryStream(body, writable: false);
		byte[] verify_data = TlsUtilities.ReadFully(expected_verify_data.Length, buf);
		TlsProtocol.AssertEmpty(buf);
		if (!Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
		{
			throw new TlsFatalAlert(40);
		}
	}

	internal static void ApplyMaxFragmentLengthExtension(DtlsRecordLayer recordLayer, short maxFragmentLength)
	{
		if (maxFragmentLength >= 0)
		{
			if (!MaxFragmentLength.IsValid((byte)maxFragmentLength))
			{
				throw new TlsFatalAlert(80);
			}
			int plainTextLimit = 1 << 8 + maxFragmentLength;
			recordLayer.SetPlaintextLimit(plainTextLimit);
		}
	}

	protected static short EvaluateMaxFragmentLengthExtension(bool resumedSession, IDictionary clientExtensions, IDictionary serverExtensions, byte alertDescription)
	{
		short maxFragmentLength = TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
		if (maxFragmentLength >= 0 && (!MaxFragmentLength.IsValid((byte)maxFragmentLength) || (!resumedSession && maxFragmentLength != TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
		{
			throw new TlsFatalAlert(alertDescription);
		}
		return maxFragmentLength;
	}

	protected static byte[] GenerateCertificate(Certificate certificate)
	{
		MemoryStream buf = new MemoryStream();
		certificate.Encode(buf);
		return buf.ToArray();
	}

	protected static byte[] GenerateSupplementalData(IList supplementalData)
	{
		MemoryStream memoryStream = new MemoryStream();
		TlsProtocol.WriteSupplementalData(memoryStream, supplementalData);
		return memoryStream.ToArray();
	}

	protected static void ValidateSelectedCipherSuite(int selectedCipherSuite, byte alertDescription)
	{
		int encryptionAlgorithm = TlsUtilities.GetEncryptionAlgorithm(selectedCipherSuite);
		if ((uint)(encryptionAlgorithm - 1) <= 1u)
		{
			throw new TlsFatalAlert(alertDescription);
		}
	}
}
