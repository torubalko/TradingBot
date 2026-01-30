using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsPskKeyExchange : AbstractTlsKeyExchange
{
	protected TlsPskIdentity mPskIdentity;

	protected TlsPskIdentityManager mPskIdentityManager;

	protected TlsDHVerifier mDHVerifier;

	protected DHParameters mDHParameters;

	protected int[] mNamedCurves;

	protected byte[] mClientECPointFormats;

	protected byte[] mServerECPointFormats;

	protected byte[] mPskIdentityHint;

	protected byte[] mPsk;

	protected DHPrivateKeyParameters mDHAgreePrivateKey;

	protected DHPublicKeyParameters mDHAgreePublicKey;

	protected ECPrivateKeyParameters mECAgreePrivateKey;

	protected ECPublicKeyParameters mECAgreePublicKey;

	protected AsymmetricKeyParameter mServerPublicKey;

	protected RsaKeyParameters mRsaServerPublicKey;

	protected TlsEncryptionCredentials mServerCredentials;

	protected byte[] mPremasterSecret;

	public override bool RequiresServerKeyExchange
	{
		get
		{
			int num = mKeyExchange;
			if (num == 14 || num == 24)
			{
				return true;
			}
			return false;
		}
	}

	[Obsolete("Use constructor that takes a TlsDHVerifier")]
	public TlsPskKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, TlsPskIdentity pskIdentity, TlsPskIdentityManager pskIdentityManager, DHParameters dhParameters, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats)
		: this(keyExchange, supportedSignatureAlgorithms, pskIdentity, pskIdentityManager, new DefaultTlsDHVerifier(), dhParameters, namedCurves, clientECPointFormats, serverECPointFormats)
	{
	}

	public TlsPskKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, TlsPskIdentity pskIdentity, TlsPskIdentityManager pskIdentityManager, TlsDHVerifier dhVerifier, DHParameters dhParameters, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats)
		: base(keyExchange, supportedSignatureAlgorithms)
	{
		if ((uint)(keyExchange - 13) > 2u && keyExchange != 24)
		{
			throw new InvalidOperationException("unsupported key exchange algorithm");
		}
		mPskIdentity = pskIdentity;
		mPskIdentityManager = pskIdentityManager;
		mDHVerifier = dhVerifier;
		mDHParameters = dhParameters;
		mNamedCurves = namedCurves;
		mClientECPointFormats = clientECPointFormats;
		mServerECPointFormats = serverECPointFormats;
	}

	public override void SkipServerCredentials()
	{
		if (mKeyExchange == 15)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		if (!(serverCredentials is TlsEncryptionCredentials))
		{
			throw new TlsFatalAlert(80);
		}
		ProcessServerCertificate(serverCredentials.Certificate);
		mServerCredentials = (TlsEncryptionCredentials)serverCredentials;
	}

	public override byte[] GenerateServerKeyExchange()
	{
		mPskIdentityHint = mPskIdentityManager.GetHint();
		if (mPskIdentityHint == null && !RequiresServerKeyExchange)
		{
			return null;
		}
		MemoryStream buf = new MemoryStream();
		if (mPskIdentityHint == null)
		{
			TlsUtilities.WriteOpaque16(TlsUtilities.EmptyBytes, buf);
		}
		else
		{
			TlsUtilities.WriteOpaque16(mPskIdentityHint, buf);
		}
		if (mKeyExchange == 14)
		{
			if (mDHParameters == null)
			{
				throw new TlsFatalAlert(80);
			}
			mDHAgreePrivateKey = TlsDHUtilities.GenerateEphemeralServerKeyExchange(mContext.SecureRandom, mDHParameters, buf);
		}
		else if (mKeyExchange == 24)
		{
			mECAgreePrivateKey = TlsEccUtilities.GenerateEphemeralServerKeyExchange(mContext.SecureRandom, mNamedCurves, mClientECPointFormats, buf);
		}
		return buf.ToArray();
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		if (mKeyExchange != 15)
		{
			throw new TlsFatalAlert(10);
		}
		if (serverCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(50);
		}
		X509CertificateStructure x509Cert = serverCertificate.GetCertificateAt(0);
		SubjectPublicKeyInfo keyInfo = x509Cert.SubjectPublicKeyInfo;
		try
		{
			mServerPublicKey = PublicKeyFactory.CreateKey(keyInfo);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(43, alertCause);
		}
		if (mServerPublicKey.IsPrivate)
		{
			throw new TlsFatalAlert(80);
		}
		mRsaServerPublicKey = ValidateRsaPublicKey((RsaKeyParameters)mServerPublicKey);
		TlsUtilities.ValidateKeyUsage(x509Cert, 32);
		base.ProcessServerCertificate(serverCertificate);
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		mPskIdentityHint = TlsUtilities.ReadOpaque16(input);
		if (mKeyExchange == 14)
		{
			mDHParameters = TlsDHUtilities.ReceiveDHParameters(mDHVerifier, input);
			mDHAgreePublicKey = new DHPublicKeyParameters(TlsDHUtilities.ReadDHParameter(input), mDHParameters);
		}
		else if (mKeyExchange == 24)
		{
			ECDomainParameters ecParams = TlsEccUtilities.ReadECParameters(mNamedCurves, mClientECPointFormats, input);
			byte[] point = TlsUtilities.ReadOpaque8(input);
			mECAgreePublicKey = TlsEccUtilities.ValidateECPublicKey(TlsEccUtilities.DeserializeECPublicKey(mClientECPointFormats, ecParams, point));
		}
	}

	public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
	{
		throw new TlsFatalAlert(10);
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		throw new TlsFatalAlert(80);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		if (mPskIdentityHint == null)
		{
			mPskIdentity.SkipIdentityHint();
		}
		else
		{
			mPskIdentity.NotifyIdentityHint(mPskIdentityHint);
		}
		byte[] psk_identity = mPskIdentity.GetPskIdentity();
		if (psk_identity == null)
		{
			throw new TlsFatalAlert(80);
		}
		mPsk = mPskIdentity.GetPsk();
		if (mPsk == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.WriteOpaque16(psk_identity, output);
		mContext.SecurityParameters.pskIdentity = psk_identity;
		if (mKeyExchange == 14)
		{
			mDHAgreePrivateKey = TlsDHUtilities.GenerateEphemeralClientKeyExchange(mContext.SecureRandom, mDHParameters, output);
		}
		else if (mKeyExchange == 24)
		{
			mECAgreePrivateKey = TlsEccUtilities.GenerateEphemeralClientKeyExchange(mContext.SecureRandom, mServerECPointFormats, mECAgreePublicKey.Parameters, output);
		}
		else if (mKeyExchange == 15)
		{
			mPremasterSecret = TlsRsaUtilities.GenerateEncryptedPreMasterSecret(mContext, mRsaServerPublicKey, output);
		}
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		byte[] psk_identity = TlsUtilities.ReadOpaque16(input);
		mPsk = mPskIdentityManager.GetPsk(psk_identity);
		if (mPsk == null)
		{
			throw new TlsFatalAlert(115);
		}
		mContext.SecurityParameters.pskIdentity = psk_identity;
		if (mKeyExchange == 14)
		{
			mDHAgreePublicKey = new DHPublicKeyParameters(TlsDHUtilities.ReadDHParameter(input), mDHParameters);
		}
		else if (mKeyExchange == 24)
		{
			byte[] point = TlsUtilities.ReadOpaque8(input);
			ECDomainParameters curve_params = mECAgreePrivateKey.Parameters;
			mECAgreePublicKey = TlsEccUtilities.ValidateECPublicKey(TlsEccUtilities.DeserializeECPublicKey(mServerECPointFormats, curve_params, point));
		}
		else if (mKeyExchange == 15)
		{
			byte[] encryptedPreMasterSecret = ((!TlsUtilities.IsSsl(mContext)) ? TlsUtilities.ReadOpaque16(input) : Streams.ReadAll(input));
			mPremasterSecret = mServerCredentials.DecryptPreMasterSecret(encryptedPreMasterSecret);
		}
	}

	public override byte[] GeneratePremasterSecret()
	{
		byte[] other_secret = GenerateOtherSecret(mPsk.Length);
		MemoryStream buf = new MemoryStream(4 + other_secret.Length + mPsk.Length);
		TlsUtilities.WriteOpaque16(other_secret, buf);
		TlsUtilities.WriteOpaque16(mPsk, buf);
		Arrays.Fill(mPsk, 0);
		mPsk = null;
		return buf.ToArray();
	}

	protected virtual byte[] GenerateOtherSecret(int pskLength)
	{
		if (mKeyExchange == 14)
		{
			if (mDHAgreePrivateKey != null)
			{
				return TlsDHUtilities.CalculateDHBasicAgreement(mDHAgreePublicKey, mDHAgreePrivateKey);
			}
			throw new TlsFatalAlert(80);
		}
		if (mKeyExchange == 24)
		{
			if (mECAgreePrivateKey != null)
			{
				return TlsEccUtilities.CalculateECDHBasicAgreement(mECAgreePublicKey, mECAgreePrivateKey);
			}
			throw new TlsFatalAlert(80);
		}
		if (mKeyExchange == 15)
		{
			return mPremasterSecret;
		}
		return new byte[pskLength];
	}

	protected virtual RsaKeyParameters ValidateRsaPublicKey(RsaKeyParameters key)
	{
		if (!key.Exponent.IsProbablePrime(2))
		{
			throw new TlsFatalAlert(47);
		}
		return key;
	}
}
