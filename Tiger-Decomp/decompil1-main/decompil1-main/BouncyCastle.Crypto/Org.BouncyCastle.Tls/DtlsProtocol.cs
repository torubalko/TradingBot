using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class DtlsProtocol
{
	internal DtlsProtocol()
	{
	}

	internal virtual void ProcessFinished(byte[] body, byte[] expected_verify_data)
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
			if (!MaxFragmentLength.IsValid(maxFragmentLength))
			{
				throw new TlsFatalAlert(80);
			}
			int plainTextLimit = 1 << 8 + maxFragmentLength;
			recordLayer.SetPlaintextLimit(plainTextLimit);
		}
	}

	internal static short EvaluateMaxFragmentLengthExtension(bool resumedSession, IDictionary clientExtensions, IDictionary serverExtensions, short alertDescription)
	{
		short maxFragmentLength = TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
		if (maxFragmentLength >= 0 && (!MaxFragmentLength.IsValid(maxFragmentLength) || (!resumedSession && maxFragmentLength != TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
		{
			throw new TlsFatalAlert(alertDescription);
		}
		return maxFragmentLength;
	}

	internal static byte[] GenerateCertificate(TlsContext context, Certificate certificate, Stream endPointHash)
	{
		MemoryStream buf = new MemoryStream();
		certificate.Encode(context, buf, endPointHash);
		return buf.ToArray();
	}

	internal static byte[] GenerateSupplementalData(IList supplementalData)
	{
		MemoryStream memoryStream = new MemoryStream();
		TlsProtocol.WriteSupplementalData(memoryStream, supplementalData);
		return memoryStream.ToArray();
	}

	internal static void SendCertificateMessage(TlsContext context, DtlsReliableHandshake handshake, Certificate certificate, Stream endPointHash)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		if (securityParameters.LocalCertificate != null)
		{
			throw new TlsFatalAlert(80);
		}
		if (certificate == null)
		{
			certificate = Certificate.EmptyChain;
		}
		byte[] certificateBody = GenerateCertificate(context, certificate, endPointHash);
		handshake.SendMessage(11, certificateBody);
		securityParameters.m_localCertificate = certificate;
	}

	internal static int ValidateSelectedCipherSuite(int selectedCipherSuite, short alertDescription)
	{
		int encryptionAlgorithm = TlsUtilities.GetEncryptionAlgorithm(selectedCipherSuite);
		if (encryptionAlgorithm == -1 || (uint)(encryptionAlgorithm - 1) <= 1u)
		{
			throw new TlsFatalAlert(alertDescription);
		}
		return selectedCipherSuite;
	}
}
