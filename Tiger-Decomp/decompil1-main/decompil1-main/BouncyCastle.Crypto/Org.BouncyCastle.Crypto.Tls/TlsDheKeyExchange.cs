using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsDheKeyExchange : TlsDHKeyExchange
{
	protected TlsSignerCredentials mServerCredentials;

	[Obsolete("Use constructor that takes a TlsDHVerifier")]
	public TlsDheKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, DHParameters dhParameters)
		: this(keyExchange, supportedSignatureAlgorithms, new DefaultTlsDHVerifier(), dhParameters)
	{
	}

	public TlsDheKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, TlsDHVerifier dhVerifier, DHParameters dhParameters)
		: base(keyExchange, supportedSignatureAlgorithms, dhVerifier, dhParameters)
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
		if (mDHParameters == null)
		{
			throw new TlsFatalAlert(80);
		}
		DigestInputBuffer buf = new DigestInputBuffer();
		mDHAgreePrivateKey = TlsDHUtilities.GenerateEphemeralServerKeyExchange(mContext.SecureRandom, mDHParameters, buf);
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
		mDHParameters = TlsDHUtilities.ReceiveDHParameters(mDHVerifier, teeIn);
		mDHAgreePublicKey = new DHPublicKeyParameters(TlsDHUtilities.ReadDHParameter(teeIn), mDHParameters);
		DigitallySigned signed_params = ParseSignature(input);
		ISigner signer = InitVerifyer(mTlsSigner, signed_params.Algorithm, securityParameters);
		buf.UpdateSigner(signer);
		if (!signer.VerifySignature(signed_params.Signature))
		{
			throw new TlsFatalAlert(51);
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
