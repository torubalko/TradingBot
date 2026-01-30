using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.IsisMtt;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixCertPathValidatorUtilities
{
	private static readonly PkixCrlUtilities CrlUtilities = new PkixCrlUtilities();

	internal static readonly string ANY_POLICY = "2.5.29.32.0";

	internal static readonly string CRL_NUMBER = X509Extensions.CrlNumber.Id;

	internal static readonly int KEY_CERT_SIGN = 5;

	internal static readonly int CRL_SIGN = 6;

	internal static readonly string[] crlReasons = new string[11]
	{
		"unspecified", "keyCompromise", "cACompromise", "affiliationChanged", "superseded", "cessationOfOperation", "certificateHold", "unknown", "removeFromCRL", "privilegeWithdrawn",
		"aACompromise"
	};

	internal static TrustAnchor FindTrustAnchor(X509Certificate cert, ISet trustAnchors)
	{
		IEnumerator iter = trustAnchors.GetEnumerator();
		TrustAnchor trust = null;
		AsymmetricKeyParameter trustPublicKey = null;
		Exception invalidKeyEx = null;
		X509CertStoreSelector certSelectX509 = new X509CertStoreSelector();
		try
		{
			certSelectX509.Subject = GetIssuerPrincipal(cert);
		}
		catch (IOException innerException)
		{
			throw new Exception("Cannot set subject search criteria for trust anchor.", innerException);
		}
		while (iter.MoveNext() && trust == null)
		{
			trust = (TrustAnchor)iter.Current;
			if (trust.TrustedCert != null)
			{
				if (certSelectX509.Match(trust.TrustedCert))
				{
					trustPublicKey = trust.TrustedCert.GetPublicKey();
				}
				else
				{
					trust = null;
				}
			}
			else if (trust.CAName != null && trust.CAPublicKey != null)
			{
				try
				{
					X509Name issuerPrincipal = GetIssuerPrincipal(cert);
					X509Name caName = new X509Name(trust.CAName);
					if (issuerPrincipal.Equivalent(caName, inOrder: true))
					{
						trustPublicKey = trust.CAPublicKey;
					}
					else
					{
						trust = null;
					}
				}
				catch (InvalidParameterException)
				{
					trust = null;
				}
			}
			else
			{
				trust = null;
			}
			if (trustPublicKey != null)
			{
				try
				{
					cert.Verify(trustPublicKey);
				}
				catch (Exception ex2)
				{
					invalidKeyEx = ex2;
					trust = null;
				}
			}
		}
		if (trust == null && invalidKeyEx != null)
		{
			throw new Exception("TrustAnchor found but certificate validation failed.", invalidKeyEx);
		}
		return trust;
	}

	internal static bool IsIssuerTrustAnchor(X509Certificate cert, ISet trustAnchors)
	{
		try
		{
			return FindTrustAnchor(cert, trustAnchors) != null;
		}
		catch (Exception)
		{
			return false;
		}
	}

	internal static void AddAdditionalStoresFromAltNames(X509Certificate cert, PkixParameters pkixParams)
	{
		if (cert.GetIssuerAlternativeNames() == null)
		{
			return;
		}
		IEnumerator it = cert.GetIssuerAlternativeNames().GetEnumerator();
		while (it.MoveNext())
		{
			IList list = (IList)it.Current;
			if (list[0].Equals(6))
			{
				AddAdditionalStoreFromLocation((string)list[1], pkixParams);
			}
		}
	}

	internal static DateTime GetValidDate(PkixParameters paramsPKIX)
	{
		return paramsPKIX.Date?.Value ?? DateTime.UtcNow;
	}

	internal static X509Name GetIssuerPrincipal(object cert)
	{
		if (cert is X509Certificate)
		{
			return ((X509Certificate)cert).IssuerDN;
		}
		return ((IX509AttributeCertificate)cert).Issuer.GetPrincipals()[0];
	}

	internal static bool IsSelfIssued(X509Certificate cert)
	{
		return cert.SubjectDN.Equivalent(cert.IssuerDN, inOrder: true);
	}

	internal static AlgorithmIdentifier GetAlgorithmIdentifier(AsymmetricKeyParameter key)
	{
		try
		{
			return SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(key).AlgorithmID;
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Subject public key cannot be decoded.", cause);
		}
	}

	internal static bool IsAnyPolicy(ISet policySet)
	{
		if (policySet != null && !policySet.Contains(ANY_POLICY))
		{
			return policySet.Count == 0;
		}
		return true;
	}

	internal static void AddAdditionalStoreFromLocation(string location, PkixParameters pkixParams)
	{
		if (!pkixParams.IsAdditionalLocationsEnabled)
		{
			return;
		}
		try
		{
			if (Platform.StartsWith(location, "ldap://"))
			{
				location = location.Substring(7);
				int slashPos = location.IndexOf('/');
				if (slashPos != -1)
				{
					_ = "ldap://" + location.Substring(0, slashPos);
				}
				else
				{
					_ = "ldap://" + location;
				}
				throw Platform.CreateNotImplementedException("LDAP cert/CRL stores");
			}
		}
		catch (Exception)
		{
			throw new Exception("Exception adding X.509 stores.");
		}
	}

	private static BigInteger GetSerialNumber(object cert)
	{
		if (cert is X509Certificate)
		{
			return ((X509Certificate)cert).SerialNumber;
		}
		return ((X509V2AttributeCertificate)cert).SerialNumber;
	}

	internal static ISet GetQualifierSet(Asn1Sequence qualifiers)
	{
		ISet pq = new HashSet();
		if (qualifiers == null)
		{
			return pq;
		}
		foreach (Asn1Encodable ae in qualifiers)
		{
			try
			{
				pq.Add(PolicyQualifierInfo.GetInstance(ae.ToAsn1Object()));
			}
			catch (IOException cause)
			{
				throw new PkixCertPathValidatorException("Policy qualifier info cannot be decoded.", cause);
			}
		}
		return pq;
	}

	internal static PkixPolicyNode RemovePolicyNode(PkixPolicyNode validPolicyTree, IList[] policyNodes, PkixPolicyNode _node)
	{
		PkixPolicyNode _parent = _node.Parent;
		if (validPolicyTree == null)
		{
			return null;
		}
		if (_parent == null)
		{
			for (int j = 0; j < policyNodes.Length; j++)
			{
				policyNodes[j] = Platform.CreateArrayList();
			}
			return null;
		}
		_parent.RemoveChild(_node);
		RemovePolicyNodeRecurse(policyNodes, _node);
		return validPolicyTree;
	}

	private static void RemovePolicyNodeRecurse(IList[] policyNodes, PkixPolicyNode _node)
	{
		policyNodes[_node.Depth].Remove(_node);
		if (!_node.HasChildren)
		{
			return;
		}
		foreach (PkixPolicyNode _child in _node.Children)
		{
			RemovePolicyNodeRecurse(policyNodes, _child);
		}
	}

	internal static void PrepareNextCertB1(int i, IList[] policyNodes, string id_p, IDictionary m_idp, X509Certificate cert)
	{
		bool idp_found = false;
		IEnumerator nodes_i = policyNodes[i].GetEnumerator();
		while (nodes_i.MoveNext())
		{
			PkixPolicyNode node = (PkixPolicyNode)nodes_i.Current;
			if (node.ValidPolicy.Equals(id_p))
			{
				idp_found = true;
				node.ExpectedPolicies = (ISet)m_idp[id_p];
				break;
			}
		}
		if (idp_found)
		{
			return;
		}
		nodes_i = policyNodes[i].GetEnumerator();
		while (nodes_i.MoveNext())
		{
			PkixPolicyNode node2 = (PkixPolicyNode)nodes_i.Current;
			if (!ANY_POLICY.Equals(node2.ValidPolicy))
			{
				continue;
			}
			ISet pq = null;
			Asn1Sequence policies = null;
			try
			{
				policies = Asn1Sequence.GetInstance(GetExtensionValue(cert, X509Extensions.CertificatePolicies));
			}
			catch (Exception innerException)
			{
				throw new Exception("Certificate policies cannot be decoded.", innerException);
			}
			IEnumerator enm = policies.GetEnumerator();
			while (enm.MoveNext())
			{
				PolicyInformation pinfo = null;
				try
				{
					pinfo = PolicyInformation.GetInstance(enm.Current);
				}
				catch (Exception innerException2)
				{
					throw new Exception("Policy information cannot be decoded.", innerException2);
				}
				if (ANY_POLICY.Equals(pinfo.PolicyIdentifier.Id))
				{
					try
					{
						pq = GetQualifierSet(pinfo.PolicyQualifiers);
					}
					catch (PkixCertPathValidatorException cause)
					{
						throw new PkixCertPathValidatorException("Policy qualifier info set could not be built.", cause);
					}
					break;
				}
			}
			bool ci = false;
			ISet critExtOids = cert.GetCriticalExtensionOids();
			if (critExtOids != null)
			{
				ci = critExtOids.Contains(X509Extensions.CertificatePolicies.Id);
			}
			PkixPolicyNode p_node = node2.Parent;
			if (ANY_POLICY.Equals(p_node.ValidPolicy))
			{
				PkixPolicyNode c_node = new PkixPolicyNode(Platform.CreateArrayList(), i, (ISet)m_idp[id_p], p_node, pq, id_p, ci);
				p_node.AddChild(c_node);
				policyNodes[i].Add(c_node);
			}
			break;
		}
	}

	internal static PkixPolicyNode PrepareNextCertB2(int i, IList[] policyNodes, string id_p, PkixPolicyNode validPolicyTree)
	{
		int pos = 0;
		foreach (PkixPolicyNode node in Platform.CreateArrayList(policyNodes[i]))
		{
			if (node.ValidPolicy.Equals(id_p))
			{
				node.Parent.RemoveChild(node);
				policyNodes[i].RemoveAt(pos);
				for (int k = i - 1; k >= 0; k--)
				{
					IList nodes = policyNodes[k];
					for (int l = 0; l < nodes.Count; l++)
					{
						PkixPolicyNode node2 = (PkixPolicyNode)nodes[l];
						if (!node2.HasChildren)
						{
							validPolicyTree = RemovePolicyNode(validPolicyTree, policyNodes, node2);
							if (validPolicyTree == null)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				pos++;
			}
		}
		return validPolicyTree;
	}

	internal static void GetCertStatus(DateTime validDate, X509Crl crl, object cert, CertStatus certStatus)
	{
		X509Crl bcCRL = null;
		try
		{
			bcCRL = new X509Crl(CertificateList.GetInstance((Asn1Sequence)Asn1Object.FromByteArray(crl.GetEncoded())));
		}
		catch (Exception innerException)
		{
			throw new Exception("Bouncy Castle X509Crl could not be created.", innerException);
		}
		X509CrlEntry crl_entry = bcCRL.GetRevokedCertificate(GetSerialNumber(cert));
		if (crl_entry == null)
		{
			return;
		}
		X509Name issuer = GetIssuerPrincipal(cert);
		if (!issuer.Equivalent(crl_entry.GetCertificateIssuer(), inOrder: true) && !issuer.Equivalent(crl.IssuerDN, inOrder: true))
		{
			return;
		}
		int reasonCodeValue = 0;
		if (crl_entry.HasExtensions)
		{
			try
			{
				DerEnumerated reasonCode = DerEnumerated.GetInstance(GetExtensionValue(crl_entry, X509Extensions.ReasonCode));
				if (reasonCode != null)
				{
					reasonCodeValue = reasonCode.IntValueExact;
				}
			}
			catch (Exception innerException2)
			{
				throw new Exception("Reason code CRL entry extension could not be decoded.", innerException2);
			}
		}
		DateTime revocationDate = crl_entry.RevocationDate;
		if (validDate.Ticks >= revocationDate.Ticks || (uint)reasonCodeValue <= 2u || reasonCodeValue == 10)
		{
			certStatus.Status = reasonCodeValue;
			certStatus.RevocationDate = new DateTimeObject(revocationDate);
		}
	}

	internal static AsymmetricKeyParameter GetNextWorkingKey(IList certs, int index)
	{
		AsymmetricKeyParameter pubKey = ((X509Certificate)certs[index]).GetPublicKey();
		if (!(pubKey is DsaPublicKeyParameters))
		{
			return pubKey;
		}
		DsaPublicKeyParameters dsaPubKey = (DsaPublicKeyParameters)pubKey;
		if (dsaPubKey.Parameters != null)
		{
			return dsaPubKey;
		}
		for (int i = index + 1; i < certs.Count; i++)
		{
			pubKey = ((X509Certificate)certs[i]).GetPublicKey();
			if (!(pubKey is DsaPublicKeyParameters))
			{
				throw new PkixCertPathValidatorException("DSA parameters cannot be inherited from previous certificate.");
			}
			DsaPublicKeyParameters prevDSAPubKey = (DsaPublicKeyParameters)pubKey;
			if (prevDSAPubKey.Parameters != null)
			{
				DsaParameters dsaParams = prevDSAPubKey.Parameters;
				try
				{
					return new DsaPublicKeyParameters(dsaPubKey.Y, dsaParams);
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}
		throw new PkixCertPathValidatorException("DSA parameters cannot be inherited from previous certificate.");
	}

	internal static DateTime GetValidCertDateFromValidityModel(PkixParameters paramsPkix, PkixCertPath certPath, int index)
	{
		if (paramsPkix.ValidityModel != 1)
		{
			return GetValidDate(paramsPkix);
		}
		if (index <= 0)
		{
			return GetValidDate(paramsPkix);
		}
		if (index - 1 == 0)
		{
			DerGeneralizedTime dateOfCertgen = null;
			try
			{
				dateOfCertgen = DerGeneralizedTime.GetInstance(((X509Certificate)certPath.Certificates[index - 1]).GetExtensionValue(IsisMttObjectIdentifiers.IdIsisMttATDateOfCertGen));
			}
			catch (ArgumentException)
			{
				throw new Exception("Date of cert gen extension could not be read.");
			}
			if (dateOfCertgen != null)
			{
				try
				{
					return dateOfCertgen.ToDateTime();
				}
				catch (ArgumentException innerException)
				{
					throw new Exception("Date from date of cert gen extension could not be parsed.", innerException);
				}
			}
		}
		return ((X509Certificate)certPath.Certificates[index - 1]).NotBefore;
	}

	internal static ICollection FindCertificates(X509CertStoreSelector certSelect, IList certStores)
	{
		ISet certs = new HashSet();
		foreach (IX509Store certStore in certStores)
		{
			try
			{
				foreach (X509Certificate c in certStore.GetMatches(certSelect))
				{
					certs.Add(c);
				}
			}
			catch (Exception innerException)
			{
				throw new Exception("Problem while picking certificates from X.509 store.", innerException);
			}
		}
		return certs;
	}

	internal static void GetCrlIssuersFromDistributionPoint(DistributionPoint dp, ICollection issuerPrincipals, X509CrlStoreSelector selector, PkixParameters pkixParams)
	{
		IList issuers = Platform.CreateArrayList();
		if (dp.CrlIssuer != null)
		{
			GeneralName[] genNames = dp.CrlIssuer.GetNames();
			for (int j = 0; j < genNames.Length; j++)
			{
				if (genNames[j].TagNo == 4)
				{
					try
					{
						issuers.Add(X509Name.GetInstance(genNames[j].Name.ToAsn1Object()));
					}
					catch (IOException innerException)
					{
						throw new Exception("CRL issuer information from distribution point cannot be decoded.", innerException);
					}
				}
			}
		}
		else
		{
			if (dp.DistributionPointName == null)
			{
				throw new Exception("CRL issuer is omitted from distribution point but no distributionPoint field present.");
			}
			IEnumerator it = issuerPrincipals.GetEnumerator();
			while (it.MoveNext())
			{
				issuers.Add((X509Name)it.Current);
			}
		}
		selector.Issuers = issuers;
	}

	internal static ISet GetCompleteCrls(DistributionPoint dp, object cert, DateTime currentDate, PkixParameters paramsPKIX)
	{
		X509CrlStoreSelector crlselect = new X509CrlStoreSelector();
		try
		{
			ISet issuers = new HashSet();
			if (cert is X509V2AttributeCertificate)
			{
				issuers.Add(((X509V2AttributeCertificate)cert).Issuer.GetPrincipals()[0]);
			}
			else
			{
				issuers.Add(GetIssuerPrincipal(cert));
			}
			GetCrlIssuersFromDistributionPoint(dp, issuers, crlselect, paramsPKIX);
		}
		catch (Exception innerException)
		{
			throw new Exception("Could not get issuer information from distribution point.", innerException);
		}
		if (cert is X509Certificate)
		{
			crlselect.CertificateChecking = (X509Certificate)cert;
		}
		else if (cert is X509V2AttributeCertificate)
		{
			crlselect.AttrCertChecking = (IX509AttributeCertificate)cert;
		}
		crlselect.CompleteCrlEnabled = true;
		ISet set = CrlUtilities.FindCrls(crlselect, paramsPKIX, currentDate);
		if (set.IsEmpty)
		{
			if (cert is IX509AttributeCertificate)
			{
				IX509AttributeCertificate aCert = (IX509AttributeCertificate)cert;
				throw new Exception("No CRLs found for issuer \"" + aCert.Issuer.GetPrincipals()[0]?.ToString() + "\"");
			}
			X509Certificate xCert = (X509Certificate)cert;
			throw new Exception("No CRLs found for issuer \"" + xCert.IssuerDN?.ToString() + "\"");
		}
		return set;
	}

	internal static ISet GetDeltaCrls(DateTime currentDate, PkixParameters paramsPKIX, X509Crl completeCRL)
	{
		X509CrlStoreSelector deltaSelect = new X509CrlStoreSelector();
		try
		{
			IList deltaSelectIssuer = Platform.CreateArrayList();
			deltaSelectIssuer.Add(completeCRL.IssuerDN);
			deltaSelect.Issuers = deltaSelectIssuer;
		}
		catch (IOException innerException)
		{
			throw new Exception("Cannot extract issuer from CRL.", innerException);
		}
		BigInteger completeCRLNumber = null;
		try
		{
			Asn1Object asn1Object = GetExtensionValue(completeCRL, X509Extensions.CrlNumber);
			if (asn1Object != null)
			{
				completeCRLNumber = DerInteger.GetInstance(asn1Object).PositiveValue;
			}
		}
		catch (Exception innerException2)
		{
			throw new Exception("CRL number extension could not be extracted from CRL.", innerException2);
		}
		byte[] idp = null;
		try
		{
			Asn1Object obj = GetExtensionValue(completeCRL, X509Extensions.IssuingDistributionPoint);
			if (obj != null)
			{
				idp = obj.GetDerEncoded();
			}
		}
		catch (Exception innerException3)
		{
			throw new Exception("Issuing distribution point extension value could not be read.", innerException3);
		}
		deltaSelect.MinCrlNumber = completeCRLNumber?.Add(BigInteger.One);
		deltaSelect.IssuingDistributionPoint = idp;
		deltaSelect.IssuingDistributionPointEnabled = true;
		deltaSelect.MaxBaseCrlNumber = completeCRLNumber;
		ISet set = CrlUtilities.FindCrls(deltaSelect, paramsPKIX, currentDate);
		ISet result = new HashSet();
		foreach (X509Crl crl in set)
		{
			if (isDeltaCrl(crl))
			{
				result.Add(crl);
			}
		}
		return result;
	}

	private static bool isDeltaCrl(X509Crl crl)
	{
		return crl.GetCriticalExtensionOids().Contains(X509Extensions.DeltaCrlIndicator.Id);
	}

	internal static ICollection FindCertificates(X509AttrCertStoreSelector certSelect, IList certStores)
	{
		ISet certs = new HashSet();
		foreach (IX509Store certStore in certStores)
		{
			try
			{
				foreach (X509V2AttributeCertificate ac in certStore.GetMatches(certSelect))
				{
					certs.Add(ac);
				}
			}
			catch (Exception innerException)
			{
				throw new Exception("Problem while picking certificates from X.509 store.", innerException);
			}
		}
		return certs;
	}

	internal static void AddAdditionalStoresFromCrlDistributionPoint(CrlDistPoint crldp, PkixParameters pkixParams)
	{
		if (crldp == null)
		{
			return;
		}
		DistributionPoint[] dps = null;
		try
		{
			dps = crldp.GetDistributionPoints();
		}
		catch (Exception innerException)
		{
			throw new Exception("Distribution points could not be read.", innerException);
		}
		for (int i = 0; i < dps.Length; i++)
		{
			DistributionPointName dpn = dps[i].DistributionPointName;
			if (dpn == null || dpn.PointType != 0)
			{
				continue;
			}
			GeneralName[] genNames = GeneralNames.GetInstance(dpn.Name).GetNames();
			for (int j = 0; j < genNames.Length; j++)
			{
				if (genNames[j].TagNo == 6)
				{
					AddAdditionalStoreFromLocation(DerIA5String.GetInstance(genNames[j].Name).GetString(), pkixParams);
				}
			}
		}
	}

	internal static bool ProcessCertD1i(int index, IList[] policyNodes, DerObjectIdentifier pOid, ISet pq)
	{
		IList policyNodeVec = policyNodes[index - 1];
		for (int j = 0; j < policyNodeVec.Count; j++)
		{
			PkixPolicyNode node = (PkixPolicyNode)policyNodeVec[j];
			if (node.ExpectedPolicies.Contains(pOid.Id))
			{
				ISet childExpectedPolicies = new HashSet();
				childExpectedPolicies.Add(pOid.Id);
				PkixPolicyNode child = new PkixPolicyNode(Platform.CreateArrayList(), index, childExpectedPolicies, node, pq, pOid.Id, critical: false);
				node.AddChild(child);
				policyNodes[index].Add(child);
				return true;
			}
		}
		return false;
	}

	internal static void ProcessCertD1ii(int index, IList[] policyNodes, DerObjectIdentifier _poid, ISet _pq)
	{
		IList policyNodeVec = policyNodes[index - 1];
		for (int j = 0; j < policyNodeVec.Count; j++)
		{
			PkixPolicyNode _node = (PkixPolicyNode)policyNodeVec[j];
			if (ANY_POLICY.Equals(_node.ValidPolicy))
			{
				ISet _childExpectedPolicies = new HashSet();
				_childExpectedPolicies.Add(_poid.Id);
				PkixPolicyNode _child = new PkixPolicyNode(Platform.CreateArrayList(), index, _childExpectedPolicies, _node, _pq, _poid.Id, critical: false);
				_node.AddChild(_child);
				policyNodes[index].Add(_child);
				break;
			}
		}
	}

	internal static ICollection FindIssuerCerts(X509Certificate cert, PkixBuilderParameters pkixParams)
	{
		X509CertStoreSelector certSelect = new X509CertStoreSelector();
		ISet certs = new HashSet();
		try
		{
			certSelect.Subject = cert.IssuerDN;
		}
		catch (IOException innerException)
		{
			throw new Exception("Subject criteria for certificate selector to find issuer certificate could not be set.", innerException);
		}
		try
		{
			certs.AddAll(FindCertificates(certSelect, pkixParams.GetStores()));
			certs.AddAll(FindCertificates(certSelect, pkixParams.GetAdditionalStores()));
			return certs;
		}
		catch (Exception innerException2)
		{
			throw new Exception("Issuer certificate cannot be searched.", innerException2);
		}
	}

	internal static Asn1Object GetExtensionValue(IX509Extension ext, DerObjectIdentifier oid)
	{
		Asn1OctetString bytes = ext.GetExtensionValue(oid);
		if (bytes == null)
		{
			return null;
		}
		return X509ExtensionUtilities.FromExtensionValue(bytes);
	}
}
