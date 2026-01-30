using System.Collections;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class AbstractTlsClient : AbstractTlsPeer, TlsClient, TlsPeer
{
	protected TlsClientContext m_context;

	protected ProtocolVersion[] m_protocolVersions;

	protected int[] m_cipherSuites;

	protected IList m_supportedGroups;

	protected IList m_supportedSignatureAlgorithms;

	protected IList m_supportedSignatureAlgorithmsCert;

	protected AbstractTlsClient(TlsCrypto crypto)
		: base(crypto)
	{
	}

	protected virtual bool AllowUnexpectedServerExtension(int extensionType, byte[] extensionData)
	{
		switch (extensionType)
		{
		case 10:
			TlsExtensionsUtilities.ReadSupportedGroupsExtension(extensionData);
			return true;
		case 11:
			TlsExtensionsUtilities.ReadSupportedPointFormatsExtension(extensionData);
			return true;
		default:
			return false;
		}
	}

	protected virtual IList GetNamedGroupRoles()
	{
		IList namedGroupRoles = TlsUtilities.GetNamedGroupRoles(GetCipherSuites());
		IList sigAlgs = m_supportedSignatureAlgorithms;
		IList sigAlgsCert = m_supportedSignatureAlgorithmsCert;
		if (sigAlgs == null || TlsUtilities.ContainsAnySignatureAlgorithm(sigAlgs, 3) || (sigAlgsCert != null && TlsUtilities.ContainsAnySignatureAlgorithm(sigAlgsCert, 3)))
		{
			TlsUtilities.AddToSet(namedGroupRoles, 3);
		}
		return namedGroupRoles;
	}

	protected virtual void CheckForUnexpectedServerExtension(IDictionary serverExtensions, int extensionType)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(serverExtensions, extensionType);
		if (extensionData != null && !AllowUnexpectedServerExtension(extensionType, extensionData))
		{
			throw new TlsFatalAlert(47);
		}
	}

	public virtual TlsPskIdentity GetPskIdentity()
	{
		return null;
	}

	public virtual TlsSrpIdentity GetSrpIdentity()
	{
		return null;
	}

	public virtual TlsDHGroupVerifier GetDHGroupVerifier()
	{
		return new DefaultTlsDHGroupVerifier();
	}

	public virtual TlsSrpConfigVerifier GetSrpConfigVerifier()
	{
		return new DefaultTlsSrpConfigVerifier();
	}

	protected virtual IList GetCertificateAuthorities()
	{
		return null;
	}

	protected virtual IList GetProtocolNames()
	{
		return null;
	}

	protected virtual CertificateStatusRequest GetCertificateStatusRequest()
	{
		return new CertificateStatusRequest(1, new OcspStatusRequest(null, null));
	}

	protected virtual IList GetMultiCertStatusRequest()
	{
		return null;
	}

	protected virtual IList GetSniServerNames()
	{
		return null;
	}

	protected virtual IList GetSupportedGroups(IList namedGroupRoles)
	{
		TlsCrypto crypto = Crypto;
		IList supportedGroups = Platform.CreateArrayList();
		if (namedGroupRoles.Contains(2))
		{
			TlsUtilities.AddIfSupported(supportedGroups, crypto, new int[2] { 29, 30 });
		}
		if (namedGroupRoles.Contains(2) || namedGroupRoles.Contains(3))
		{
			TlsUtilities.AddIfSupported(supportedGroups, crypto, new int[2] { 23, 24 });
		}
		if (namedGroupRoles.Contains(1))
		{
			TlsUtilities.AddIfSupported(supportedGroups, crypto, new int[3] { 256, 257, 258 });
		}
		return supportedGroups;
	}

	protected virtual IList GetSupportedSignatureAlgorithms()
	{
		return TlsUtilities.GetDefaultSupportedSignatureAlgorithms(m_context);
	}

	protected virtual IList GetSupportedSignatureAlgorithmsCert()
	{
		return null;
	}

	protected virtual IList GetTrustedCAIndication()
	{
		return null;
	}

	public virtual void Init(TlsClientContext context)
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
		m_supportedGroups = null;
		m_supportedSignatureAlgorithms = null;
		m_supportedSignatureAlgorithmsCert = null;
	}

	public virtual TlsSession GetSessionToResume()
	{
		return null;
	}

	public virtual IList GetExternalPsks()
	{
		return null;
	}

	public virtual bool IsFallback()
	{
		return false;
	}

	public virtual IDictionary GetClientExtensions()
	{
		IDictionary clientExtensions = Platform.CreateHashtable();
		bool offeringTlsV13Plus = false;
		bool offeringPreTlsV13 = false;
		ProtocolVersion[] supportedVersions = GetProtocolVersions();
		for (int i = 0; i < supportedVersions.Length; i++)
		{
			if (TlsUtilities.IsTlsV13(supportedVersions[i]))
			{
				offeringTlsV13Plus = true;
			}
			else
			{
				offeringPreTlsV13 = true;
			}
		}
		IList protocolNames = GetProtocolNames();
		if (protocolNames != null)
		{
			TlsExtensionsUtilities.AddAlpnExtensionClient(clientExtensions, protocolNames);
		}
		IList sniServerNames = GetSniServerNames();
		if (sniServerNames != null)
		{
			TlsExtensionsUtilities.AddServerNameExtensionClient(clientExtensions, sniServerNames);
		}
		CertificateStatusRequest statusRequest = GetCertificateStatusRequest();
		if (statusRequest != null)
		{
			TlsExtensionsUtilities.AddStatusRequestExtension(clientExtensions, statusRequest);
		}
		if (offeringTlsV13Plus)
		{
			IList certificateAuthorities = GetCertificateAuthorities();
			if (certificateAuthorities != null)
			{
				TlsExtensionsUtilities.AddCertificateAuthoritiesExtension(clientExtensions, certificateAuthorities);
			}
		}
		if (offeringPreTlsV13)
		{
			TlsExtensionsUtilities.AddEncryptThenMacExtension(clientExtensions);
			IList statusRequestV2 = GetMultiCertStatusRequest();
			if (statusRequestV2 != null)
			{
				TlsExtensionsUtilities.AddStatusRequestV2Extension(clientExtensions, statusRequestV2);
			}
			IList trustedCAKeys = GetTrustedCAIndication();
			if (trustedCAKeys != null)
			{
				TlsExtensionsUtilities.AddTrustedCAKeysExtensionClient(clientExtensions, trustedCAKeys);
			}
		}
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(m_context.ClientVersion))
		{
			IList supportedSigAlgs = GetSupportedSignatureAlgorithms();
			if (supportedSigAlgs != null && supportedSigAlgs.Count > 0)
			{
				m_supportedSignatureAlgorithms = supportedSigAlgs;
				TlsExtensionsUtilities.AddSignatureAlgorithmsExtension(clientExtensions, supportedSigAlgs);
			}
			IList supportedSigAlgsCert = GetSupportedSignatureAlgorithmsCert();
			if (supportedSigAlgsCert != null && supportedSigAlgsCert.Count > 0)
			{
				m_supportedSignatureAlgorithmsCert = supportedSigAlgsCert;
				TlsExtensionsUtilities.AddSignatureAlgorithmsCertExtension(clientExtensions, supportedSigAlgsCert);
			}
		}
		IList namedGroupRoles = GetNamedGroupRoles();
		IList supportedGroups = GetSupportedGroups(namedGroupRoles);
		if (supportedGroups != null && supportedGroups.Count > 0)
		{
			m_supportedGroups = supportedGroups;
			TlsExtensionsUtilities.AddSupportedGroupsExtension(clientExtensions, supportedGroups);
		}
		if (offeringPreTlsV13 && (namedGroupRoles.Contains(2) || namedGroupRoles.Contains(3)))
		{
			TlsExtensionsUtilities.AddSupportedPointFormatsExtension(clientExtensions, new short[1]);
		}
		return clientExtensions;
	}

	public virtual IList GetEarlyKeyShareGroups()
	{
		if (m_supportedGroups == null || m_supportedGroups.Count < 1)
		{
			return null;
		}
		if (m_supportedGroups.Contains(29))
		{
			return TlsUtilities.VectorOfOne(29);
		}
		if (m_supportedGroups.Contains(23))
		{
			return TlsUtilities.VectorOfOne(23);
		}
		return TlsUtilities.VectorOfOne(m_supportedGroups[0]);
	}

	public virtual void NotifyServerVersion(ProtocolVersion serverVersion)
	{
	}

	public virtual void NotifySessionToResume(TlsSession session)
	{
	}

	public virtual void NotifySessionID(byte[] sessionID)
	{
	}

	public virtual void NotifySelectedCipherSuite(int selectedCipherSuite)
	{
	}

	public virtual void NotifySelectedPsk(TlsPsk selectedPsk)
	{
	}

	public virtual void ProcessServerExtensions(IDictionary serverExtensions)
	{
		if (serverExtensions == null)
		{
			return;
		}
		SecurityParameters securityParameters = m_context.SecurityParameters;
		if (!TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
		{
			CheckForUnexpectedServerExtension(serverExtensions, 13);
			CheckForUnexpectedServerExtension(serverExtensions, 50);
			CheckForUnexpectedServerExtension(serverExtensions, 10);
			if (TlsEccUtilities.IsEccCipherSuite(securityParameters.CipherSuite))
			{
				TlsExtensionsUtilities.GetSupportedPointFormatsExtension(serverExtensions);
			}
			else
			{
				CheckForUnexpectedServerExtension(serverExtensions, 11);
			}
			CheckForUnexpectedServerExtension(serverExtensions, 21);
		}
	}

	public virtual void ProcessServerSupplementalData(IList serverSupplementalData)
	{
		if (serverSupplementalData != null)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public abstract TlsAuthentication GetAuthentication();

	public virtual IList GetClientSupplementalData()
	{
		return null;
	}

	public virtual void NotifyNewSessionTicket(NewSessionTicket newSessionTicket)
	{
	}
}
