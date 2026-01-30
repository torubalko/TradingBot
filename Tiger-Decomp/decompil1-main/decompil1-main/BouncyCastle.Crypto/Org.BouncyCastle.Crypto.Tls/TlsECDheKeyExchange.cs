using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsECDheKeyExchange : TlsECDHKeyExchange
{
	protected TlsSignerCredentials mServerCredentials;

	public TlsECDheKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats)
		: base(keyExchange, supportedSignatureAlgorithms, namedCurves, clientECPointFormats, serverECPointFormats)
	{
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		if (!(serverCredentials is TlsSignerCredentials))
		{
			throw new TlsFatalAlert(80);
		}
		ProcessServerCertificate(serverCredentials.Certificate);
		mServerCredentials = (TlsSignerCredentials)serverCredentials;
	}

	public override byte[] GenerateServerKeyExchange()
	{
		DigestInputBuffer buf = new DigestInputBuffer();
		mECAgreePrivateKey = TlsEccUtilities.GenerateEphemeralServerKeyExchange(mContext.SecureRandom, mNamedCurves, mClientECPointFormats, buf);
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = TlsUtilities.GetSignatureAndHashAlgorithm(mContext, mServerCredentials);
		IDigest d = TlsUtilities.CreateHash(signatureAndHashAlgorithm);
		SecurityParameters securityParameters = mContext.SecurityParameters;
		d.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
		d.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
		buf.UpdateDigest(d);
		byte[] hash = DigestUtilities.DoFinal(d);
		byte[] signature = mServerCredentials.GenerateCertificateSignature(hash);
		new DigitallySigned(signatureAndHashAlgorithm, signature).Encode(buf);
		return buf.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		SecurityParameters securityParameters = mContext.SecurityParameters;
		SignerInputBuffer buf = new SignerInputBuffer();
		Stream teeIn = new TeeInputStream(input, buf);
		ECDomainParameters curve_params = TlsEccUtilities.ReadECParameters(mNamedCurves, mClientECPointFormats, teeIn);
		byte[] point = TlsUtilities.ReadOpaque8(teeIn);
		DigitallySigned signed_params = ParseSignature(input);
		ISigner signer = InitVerifyer(mTlsSigner, signed_params.Algorithm, securityParameters);
		buf.UpdateSigner(signer);
		if (!signer.VerifySignature(signed_params.Signature))
		{
			throw new TlsFatalAlert(51);
		}
		mECAgreePublicKey = TlsEccUtilities.ValidateECPublicKey(TlsEccUtilities.DeserializeECPublicKey(mClientECPointFormats, curve_params, point));
	}

	public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
	{
		byte[] types = certificateRequest.CertificateTypes;
		foreach (byte b in types)
		{
			if ((uint)(b - 1) > 1u && b != 64)
			{
				throw new TlsFatalAlert(47);
			}
		}
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		if (!(clientCredentials is TlsSignerCredentials))
		{
			throw new TlsFatalAlert(80);
		}
	}

	protected virtual ISigner InitVerifyer(TlsSigner tlsSigner, SignatureAndHashAlgorithm algorithm, SecurityParameters securityParameters)
	{
		ISigner signer = tlsSigner.CreateVerifyer(algorithm, mServerPublicKey);
		signer.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
		signer.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
		return signer;
	}
}
