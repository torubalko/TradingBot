using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class AbstractTlsServer : AbstractTlsPeer, TlsServer, TlsPeer
{
	protected TlsServerContext m_context;

	protected ProtocolVersion[] m_protocolVersions;

	protected int[] m_cipherSuites;

	protected int[] m_offeredCipherSuites;

	protected IDictionary m_clientExtensions;

	protected bool m_encryptThenMACOffered;

	protected short m_maxFragmentLengthOffered;

	protected bool m_truncatedHMacOffered;

	protected bool m_clientSentECPointFormats;

	protected CertificateStatusRequest m_certificateStatusRequest;

	protected IList m_statusRequestV2;

	protected IList m_trustedCAKeys;

	protected int m_selectedCipherSuite;

	protected IList m_clientProtocolNames;

	protected ProtocolName m_selectedProtocolName;

	protected readonly IDictionary m_serverExtensions = Platform.CreateHashtable();

	public AbstractTlsServer(TlsCrypto crypto)
		: base(crypto)
	{
	}

	protected virtual bool AllowCertificateStatus()
	{
		return true;
	}

	protected virtual bool AllowEncryptThenMac()
	{
		return true;
	}

	protected virtual bool AllowMultiCertStatus()
	{
		return false;
	}

	protected virtual bool AllowTruncatedHmac()
	{
		return false;
	}

	protected virtual bool AllowTrustedCAIndication()
	{
		return false;
	}

	protected virtual int GetMaximumNegotiableCurveBits()
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return NamedGroup.GetMaximumCurveBits();
		}
		int maxBits = 0;
		for (int i = 0; i < clientSupportedGroups.Length; i++)
		{
			maxBits = System.Math.Max(maxBits, NamedGroup.GetCurveBits(clientSupportedGroups[i]));
		}
		return maxBits;
	}

	protected virtual int GetMaximumNegotiableFiniteFieldBits()
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return NamedGroup.GetMaximumFiniteFieldBits();
		}
		int maxBits = 0;
		for (int i = 0; i < clientSupportedGroups.Length; i++)
		{
			maxBits = System.Math.Max(maxBits, NamedGroup.GetFiniteFieldBits(clientSupportedGroups[i]));
		}
		return maxBits;
	}

	protected virtual IList GetProtocolNames()
	{
		return null;
	}

	protected virtual bool IsSelectableCipherSuite(int cipherSuite, int availCurveBits, int availFiniteFieldBits, IList sigAlgs)
	{
		if (TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, m_context.ServerVersion) && availCurveBits >= TlsEccUtilities.GetMinimumCurveBits(cipherSuite) && availFiniteFieldBits >= TlsDHUtilities.GetMinimumFiniteFieldBits(cipherSuite))
		{
			return TlsUtilities.IsValidCipherSuiteForSignatureAlgorithms(cipherSuite, sigAlgs);
		}
		return false;
	}

	protected virtual bool PreferLocalCipherSuites()
	{
		return false;
	}

	protected virtual bool SelectCipherSuite(int cipherSuite)
	{
		m_selectedCipherSuite = cipherSuite;
		return true;
	}

	protected virtual int SelectDH(int minimumFiniteFieldBits)
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return SelectDHDefault(minimumFiniteFieldBits);
		}
		foreach (int namedGroup in clientSupportedGroups)
		{
			if (NamedGroup.GetFiniteFieldBits(namedGroup) >= minimumFiniteFieldBits)
			{
				return namedGroup;
			}
		}
		return -1;
	}

	protected virtual int SelectDHDefault(int minimumFiniteFieldBits)
	{
		if (minimumFiniteFieldBits > 2048)
		{
			if (minimumFiniteFieldBits > 3072)
			{
				if (minimumFiniteFieldBits > 4096)
				{
					if (minimumFiniteFieldBits > 6144)
					{
						if (minimumFiniteFieldBits > 8192)
						{
							return -1;
						}
						return 260;
					}
					return 259;
				}
				return 258;
			}
			return 257;
		}
		return 256;
	}

	protected virtual int SelectECDH(int minimumCurveBits)
	{
		int[] clientSupportedGroups = m_context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null)
		{
			return SelectECDHDefault(minimumCurveBits);
		}
		foreach (int namedGroup in clientSupportedGroups)
		{
			if (NamedGroup.GetCurveBits(namedGroup) >= minimumCurveBits)
			{
				return namedGroup;
			}
		}
		return -1;
	}

	protected virtual int SelectECDHDefault(int minimumCurveBits)
	{
		if (minimumCurveBits > 256)
		{
			if (minimumCurveBits > 384)
			{
				if (minimumCurveBits > 521)
				{
					return -1;
				}
				return 25;
			}
			return 24;
		}
		return 23;
	}

	protected virtual ProtocolName SelectProtocolName()
	{
		IList serverProtocolNames = GetProtocolNames();
		if (serverProtocolNames == null || serverProtocolNames.Count < 1)
		{
			return null;
		}
		ProtocolName result = SelectProtocolName(m_clientProtocolNames, serverProtocolNames);
		if (result == null)
		{
			throw new TlsFatalAlert(120);
		}
		return result;
	}

	protected virtual ProtocolName SelectProtocolName(IList clientProtocolNames, IList serverProtocolNames)
	{
		foreach (ProtocolName serverProtocolName in serverProtocolNames)
		{
			if (clientProtocolNames.Contains(serverProtocolName))
			{
				return serverProtocolName;
			}
		}
		return null;
	}

	protected virtual bool ShouldSelectProtocolNameEarly()
	{
		return true;
	}

	public virtual void Init(TlsServerContext context)
	{
		m_context = context;
		m_protocolVersions = GetSupportedVersions();
		m_cipherSuites = GetSupportedCipherSuites();
	}

	public override ProtocolVersion[] GetProtocolVersions()
	{
		return m_protocolVersions;
	}

	public override int[] GetCipherSuites()
	{
		return m_cipherSuites;
	}

	public override void NotifyHandshakeBeginning()
	{
		base.NotifyHandshakeBeginning();
		m_offeredCipherSuites = null;
		m_clientExtensions = null;
		m_encryptThenMACOffered = false;
		m_maxFragmentLengthOffered = 0;
		m_truncatedHMacOffered = false;
		m_clientSentECPointFormats = false;
		m_certificateStatusRequest = null;
		m_selectedCipherSuite = -1;
		m_selectedProtocolName = null;
		m_serverExtensions.Clear();
	}

	public virtual TlsSession GetSessionToResume(byte[] sessionID)
	{
		return null;
	}

	public virtual byte[] GetNewSessionID()
	{
		return null;
	}

	public virtual TlsPskExternal GetExternalPsk(IList identities)
	{
		return null;
	}

	public virtual void NotifySession(TlsSession session)
	{
	}

	public virtual void NotifyClientVersion(ProtocolVersion clientVersion)
	{
	}

	public virtual void NotifyFallback(bool isFallback)
	{
		if (!isFallback)
		{
			return;
		}
		ProtocolVersion[] serverVersions = GetProtocolVersions();
		ProtocolVersion clientVersion = m_context.ClientVersion;
		ProtocolVersion latestServerVersion;
		if (clientVersion.IsTls)
		{
			latestServerVersion = ProtocolVersion.GetLatestTls(serverVersions);
		}
		else
		{
			if (!clientVersion.IsDtls)
			{
				throw new TlsFatalAlert(80);
			}
			latestServerVersion = ProtocolVersion.GetLatestDtls(serverVersions);
		}
		if (latestServerVersion != null && latestServerVersion.IsLaterVersionOf(clientVersion))
		{
			throw new TlsFatalAlert(86);
		}
	}

	public virtual void NotifyOfferedCipherSuites(int[] offeredCipherSuites)
	{
		m_offeredCipherSuites = offeredCipherSuites;
	}

	public virtual void ProcessClientExtensions(IDictionary clientExtensions)
	{
		m_clientExtensions = clientExtensions;
		if (clientExtensions != null)
		{
			m_clientProtocolNames = TlsExtensionsUtilities.GetAlpnExtensionClient(clientExtensions);
			if (ShouldSelectProtocolNameEarly() && m_clientProtocolNames != null && m_clientProtocolNames.Count > 0)
			{
				m_selectedProtocolName = SelectProtocolName();
			}
			m_encryptThenMACOffered = TlsExtensionsUtilities.HasEncryptThenMacExtension(clientExtensions);
			m_truncatedHMacOffered = TlsExtensionsUtilities.HasTruncatedHmacExtension(clientExtensions);
			m_statusRequestV2 = TlsExtensionsUtilities.GetStatusRequestV2Extension(clientExtensions);
			m_trustedCAKeys = TlsExtensionsUtilities.GetTrustedCAKeysExtensionClient(clientExtensions);
			m_clientSentECPointFormats = TlsExtensionsUtilities.GetSupportedPointFormatsExtension(clientExtensions) != null;
			m_certificateStatusRequest = TlsExtensionsUtilities.GetStatusRequestExtension(clientExtensions);
			m_maxFragmentLengthOffered = TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions);
			if (m_maxFragmentLengthOffered >= 0 && !MaxFragmentLength.IsValid(m_maxFragmentLengthOffered))
			{
				throw new TlsFatalAlert(47);
			}
		}
	}

	public virtual ProtocolVersion GetServerVersion()
	{
		ProtocolVersion[] serverVersions = GetProtocolVersions();
		ProtocolVersion[] clientSupportedVersions = m_context.ClientSupportedVersions;
		foreach (ProtocolVersion clientVersion in clientSupportedVersions)
		{
			if (ProtocolVersion.Contains(serverVersions, clientVersion))
			{
				return clientVersion;
			}
		}
		throw new TlsFatalAlert(70);
	}

	public virtual int[] GetSupportedGroups()
	{
		return new int[7] { 29, 30, 23, 24, 256, 257, 258 };
	}

	public virtual int GetSelectedCipherSuite()
	{
		SecurityParameters securityParameters = m_context.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (TlsUtilities.IsTlsV13(negotiatedVersion))
		{
			int commonCipherSuite13 = TlsUtilities.GetCommonCipherSuite13(negotiatedVersion, m_offeredCipherSuites, GetCipherSuites(), PreferLocalCipherSuites());
			if (commonCipherSuite13 >= 0 && SelectCipherSuite(commonCipherSuite13))
			{
				return commonCipherSuite13;
			}
		}
		else
		{
			IList sigAlgs = TlsUtilities.GetUsableSignatureAlgorithms(securityParameters.ClientSigAlgs);
			int availCurveBits = GetMaximumNegotiableCurveBits();
			int availFiniteFieldBits = GetMaximumNegotiableFiniteFieldBits();
			int[] cipherSuites = TlsUtilities.GetCommonCipherSuites(m_offeredCipherSuites, GetCipherSuites(), PreferLocalCipherSuites());
			foreach (int cipherSuite in cipherSuites)
			{
				if (IsSelectableCipherSuite(cipherSuite, availCurveBits, availFiniteFieldBits, sigAlgs) && SelectCipherSuite(cipherSuite))
				{
					return cipherSuite;
				}
			}
		}
		throw new TlsFatalAlert(40, "No selectable cipher suite");
	}

	public virtual IDictionary GetServerExtensions()
	{
		if (TlsUtilities.IsTlsV13(m_context))
		{
			if (m_certificateStatusRequest != null && !AllowCertificateStatus())
			{
			}
		}
		else
		{
			if (m_encryptThenMACOffered && AllowEncryptThenMac() && TlsUtilities.IsBlockCipherSuite(m_selectedCipherSuite))
			{
				TlsExtensionsUtilities.AddEncryptThenMacExtension(m_serverExtensions);
			}
			if (m_truncatedHMacOffered && AllowTruncatedHmac())
			{
				TlsExtensionsUtilities.AddTruncatedHmacExtension(m_serverExtensions);
			}
			if (m_clientSentECPointFormats && TlsEccUtilities.IsEccCipherSuite(m_selectedCipherSuite))
			{
				TlsExtensionsUtilities.AddSupportedPointFormatsExtension(m_serverExtensions, new short[1]);
			}
			if (m_statusRequestV2 != null && AllowMultiCertStatus())
			{
				TlsExtensionsUtilities.AddEmptyExtensionData(m_serverExtensions, 17);
			}
			else if (m_certificateStatusRequest != null && AllowCertificateStatus())
			{
				TlsExtensionsUtilities.AddEmptyExtensionData(m_serverExtensions, 5);
			}
			if (m_trustedCAKeys != null && AllowTrustedCAIndication())
			{
				TlsExtensionsUtilities.AddTrustedCAKeysExtensionServer(m_serverExtensions);
			}
		}
		if (m_maxFragmentLengthOffered >= 0 && MaxFragmentLength.IsValid(m_maxFragmentLengthOffered))
		{
			TlsExtensionsUtilities.AddMaxFragmentLengthExtension(m_serverExtensions, m_maxFragmentLengthOffered);
		}
		return m_serverExtensions;
	}

	public virtual void GetServerExtensionsForConnection(IDictionary serverExtensions)
	{
		if (!ShouldSelectProtocolNameEarly() && m_clientProtocolNames != null && m_clientProtocolNames.Count > 0)
		{
			m_selectedProtocolName = SelectProtocolName();
		}
		if (m_selectedProtocolName == null)
		{
			serverExtensions.Remove(16);
		}
		else
		{
			TlsExtensionsUtilities.AddAlpnExtensionServer(serverExtensions, m_selectedProtocolName);
		}
	}

	public virtual IList GetServerSupplementalData()
	{
		return null;
	}

	public abstract TlsCredentials GetCredentials();

	public virtual CertificateStatus GetCertificateStatus()
	{
		return null;
	}

	public virtual CertificateRequest GetCertificateRequest()
	{
		return null;
	}

	public virtual TlsPskIdentityManager GetPskIdentityManager()
	{
		return null;
	}

	public virtual TlsSrpLoginParameters GetSrpLoginParameters()
	{
		return null;
	}

	public virtual TlsDHConfig GetDHConfig()
	{
		int minimumFiniteFieldBits = TlsDHUtilities.GetMinimumFiniteFieldBits(m_selectedCipherSuite);
		int namedGroup = SelectDH(minimumFiniteFieldBits);
		return TlsDHUtilities.CreateNamedDHConfig(m_context, namedGroup);
	}

	public virtual TlsECConfig GetECDHConfig()
	{
		int minimumCurveBits = TlsEccUtilities.GetMinimumCurveBits(m_selectedCipherSuite);
		int namedGroup = SelectECDH(minimumCurveBits);
		return TlsEccUtilities.CreateNamedECConfig(m_context, namedGroup);
	}

	public virtual void ProcessClientSupplementalData(IList clientSupplementalData)
	{
		if (clientSupplementalData != null)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual NewSessionTicket GetNewSessionTicket()
	{
		return new NewSessionTicket(0L, TlsUtilities.EmptyBytes);
	}
}
