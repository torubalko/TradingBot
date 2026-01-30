using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public class TlsSrpKeyExchange : AbstractTlsKeyExchange
{
	protected TlsSrpIdentity m_srpIdentity;

	protected TlsSrpConfigVerifier m_srpConfigVerifier;

	protected TlsCertificate m_serverCertificate;

	protected byte[] m_srpSalt;

	protected TlsSrp6Client m_srpClient;

	protected TlsSrpLoginParameters m_srpLoginParameters;

	protected TlsCredentialedSigner m_serverCredentials;

	protected TlsSrp6Server m_srpServer;

	protected BigInteger m_srpPeerCredentials;

	public override bool RequiresServerKeyExchange => true;

	private static int CheckKeyExchange(int keyExchange)
	{
		if ((uint)(keyExchange - 21) <= 2u)
		{
			return keyExchange;
		}
		throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
	}

	public TlsSrpKeyExchange(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier)
		: base(CheckKeyExchange(keyExchange))
	{
		m_srpIdentity = srpIdentity;
		m_srpConfigVerifier = srpConfigVerifier;
	}

	public TlsSrpKeyExchange(int keyExchange, TlsSrpLoginParameters srpLoginParameters)
		: base(CheckKeyExchange(keyExchange))
	{
		m_srpLoginParameters = srpLoginParameters;
	}

	public override void SkipServerCredentials()
	{
		if (m_keyExchange != 21)
		{
			throw new TlsFatalAlert(80);
		}
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		if (m_keyExchange == 21)
		{
			throw new TlsFatalAlert(80);
		}
		m_serverCredentials = TlsUtilities.RequireSignerCredentials(serverCredentials);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		if (m_keyExchange == 21)
		{
			throw new TlsFatalAlert(80);
		}
		m_serverCertificate = serverCertificate.GetCertificateAt(0);
	}

	public override byte[] GenerateServerKeyExchange()
	{
		TlsSrpConfig config = m_srpLoginParameters.Config;
		m_srpServer = m_context.Crypto.CreateSrp6Server(config, m_srpLoginParameters.Verifier);
		BigInteger B = m_srpServer.GenerateServerCredentials();
		BigInteger[] ng = config.GetExplicitNG();
		ServerSrpParams serverSrpParams = new ServerSrpParams(ng[0], ng[1], m_srpLoginParameters.Salt, B);
		DigestInputBuffer digestBuffer = new DigestInputBuffer();
		serverSrpParams.Encode(digestBuffer);
		if (m_serverCredentials != null)
		{
			TlsUtilities.GenerateServerKeyExchangeSignature(m_context, m_serverCredentials, null, digestBuffer);
		}
		return digestBuffer.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		DigestInputBuffer digestBuffer = null;
		Stream teeIn = input;
		if (m_keyExchange != 21)
		{
			digestBuffer = new DigestInputBuffer();
			teeIn = new TeeInputStream(input, digestBuffer);
		}
		ServerSrpParams srpParams = ServerSrpParams.Parse(teeIn);
		if (digestBuffer != null)
		{
			TlsUtilities.VerifyServerKeyExchangeSignature(m_context, input, m_serverCertificate, null, digestBuffer);
		}
		TlsSrpConfig config = new TlsSrpConfig();
		config.SetExplicitNG(new BigInteger[2] { srpParams.N, srpParams.G });
		if (!m_srpConfigVerifier.Accept(config))
		{
			throw new TlsFatalAlert(71);
		}
		m_srpSalt = srpParams.S;
		m_srpPeerCredentials = ValidatePublicValue(srpParams.N, srpParams.B);
		m_srpClient = m_context.Crypto.CreateSrp6Client(config);
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		throw new TlsFatalAlert(80);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		byte[] identity = m_srpIdentity.GetSrpIdentity();
		byte[] password = m_srpIdentity.GetSrpPassword();
		TlsSrpUtilities.WriteSrpParameter(m_srpClient.GenerateClientCredentials(m_srpSalt, identity, password), output);
		m_context.SecurityParameters.m_srpIdentity = Arrays.Clone(identity);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		m_srpPeerCredentials = ValidatePublicValue(m_srpLoginParameters.Config.GetExplicitNG()[0], TlsSrpUtilities.ReadSrpParameter(input));
		m_context.SecurityParameters.m_srpIdentity = Arrays.Clone(m_srpLoginParameters.Identity);
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		BigInteger S = ((m_srpServer != null) ? m_srpServer.CalculateSecret(m_srpPeerCredentials) : m_srpClient.CalculateSecret(m_srpPeerCredentials));
		return m_context.Crypto.CreateSecret(BigIntegers.AsUnsignedByteArray(S));
	}

	protected static BigInteger ValidatePublicValue(BigInteger N, BigInteger val)
	{
		val = val.Mod(N);
		if (val.Equals(BigInteger.Zero))
		{
			throw new TlsFatalAlert(47);
		}
		return val;
	}
}
