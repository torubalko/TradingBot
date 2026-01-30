using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class Rfc3280CertPathUtilities
{
	private static readonly PkixCrlUtilities CrlUtilities = new PkixCrlUtilities();

	internal static readonly string ANY_POLICY = "2.5.29.32.0";

	internal static readonly int KEY_CERT_SIGN = 5;

	internal static readonly int CRL_SIGN = 6;

	internal static readonly string[] CrlReasons = new string[11]
	{
		"unspecified", "keyCompromise", "cACompromise", "affiliationChanged", "superseded", "cessationOfOperation", "certificateHold", "unknown", "removeFromCRL", "privilegeWithdrawn",
		"aACompromise"
	};

	internal static void ProcessCrlB2(DistributionPoint dp, object cert, X509Crl crl)
	{
		IssuingDistributionPoint idp = null;
		try
		{
			idp = IssuingDistributionPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(crl, X509Extensions.IssuingDistributionPoint));
		}
		catch (Exception innerException)
		{
			throw new Exception("0 Issuing distribution point extension could not be decoded.", innerException);
		}
		if (idp == null)
		{
			return;
		}
		if (idp.DistributionPoint != null)
		{
			DistributionPointName dpName = IssuingDistributionPoint.GetInstance(idp).DistributionPoint;
			IList names = Platform.CreateArrayList();
			if (dpName.PointType == 0)
			{
				GeneralName[] genNames = GeneralNames.GetInstance(dpName.Name).GetNames();
				for (int j = 0; j < genNames.Length; j++)
				{
					names.Add(genNames[j]);
				}
			}
			if (dpName.PointType == 1)
			{
				Asn1EncodableVector vec = new Asn1EncodableVector();
				try
				{
					IEnumerator e = Asn1Sequence.GetInstance(Asn1Object.FromByteArray(crl.IssuerDN.GetEncoded())).GetEnumerator();
					while (e.MoveNext())
					{
						vec.Add((Asn1Encodable)e.Current);
					}
				}
				catch (IOException innerException2)
				{
					throw new Exception("Could not read CRL issuer.", innerException2);
				}
				vec.Add(dpName.Name);
				names.Add(new GeneralName(X509Name.GetInstance(new DerSequence(vec))));
			}
			bool matches = false;
			if (dp.DistributionPointName != null)
			{
				dpName = dp.DistributionPointName;
				GeneralName[] genNames2 = null;
				if (dpName.PointType == 0)
				{
					genNames2 = GeneralNames.GetInstance(dpName.Name).GetNames();
				}
				if (dpName.PointType == 1)
				{
					if (dp.CrlIssuer != null)
					{
						genNames2 = dp.CrlIssuer.GetNames();
					}
					else
					{
						genNames2 = new GeneralName[1];
						try
						{
							genNames2[0] = new GeneralName(PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert));
						}
						catch (IOException innerException3)
						{
							throw new Exception("Could not read certificate issuer.", innerException3);
						}
					}
					for (int i = 0; i < genNames2.Length; i++)
					{
						IEnumerator e2 = Asn1Sequence.GetInstance(genNames2[i].Name.ToAsn1Object()).GetEnumerator();
						Asn1EncodableVector vec2 = new Asn1EncodableVector();
						while (e2.MoveNext())
						{
							vec2.Add((Asn1Encodable)e2.Current);
						}
						vec2.Add(dpName.Name);
						genNames2[i] = new GeneralName(X509Name.GetInstance(new DerSequence(vec2)));
					}
				}
				if (genNames2 != null)
				{
					for (int k = 0; k < genNames2.Length; k++)
					{
						if (names.Contains(genNames2[k]))
						{
							matches = true;
							break;
						}
					}
				}
				if (!matches)
				{
					throw new Exception("No match for certificate CRL issuing distribution point name to cRLIssuer CRL distribution point.");
				}
			}
			else
			{
				if (dp.CrlIssuer == null)
				{
					throw new Exception("Either the cRLIssuer or the distributionPoint field must be contained in DistributionPoint.");
				}
				GeneralName[] genNames3 = dp.CrlIssuer.GetNames();
				for (int l = 0; l < genNames3.Length; l++)
				{
					if (names.Contains(genNames3[l]))
					{
						matches = true;
						break;
					}
				}
				if (!matches)
				{
					throw new Exception("No match for certificate CRL issuing distribution point name to cRLIssuer CRL distribution point.");
				}
			}
		}
		BasicConstraints bc = null;
		try
		{
			bc = BasicConstraints.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue((IX509Extension)cert, X509Extensions.BasicConstraints));
		}
		catch (Exception innerException4)
		{
			throw new Exception("Basic constraints extension could not be decoded.", innerException4);
		}
		if (idp.OnlyContainsUserCerts && bc != null && bc.IsCA())
		{
			throw new Exception("CA Cert CRL only contains user certificates.");
		}
		if (idp.OnlyContainsCACerts && (bc == null || !bc.IsCA()))
		{
			throw new Exception("End CRL only contains CA certificates.");
		}
		if (idp.OnlyContainsAttributeCerts)
		{
			throw new Exception("onlyContainsAttributeCerts boolean is asserted.");
		}
	}

	internal static void ProcessCertBC(PkixCertPath certPath, int index, PkixNameConstraintValidator nameConstraintValidator)
	{
		IList certificates = certPath.Certificates;
		X509Certificate cert = (X509Certificate)certificates[index];
		int n = certificates.Count;
		int i = n - index;
		if (PkixCertPathValidatorUtilities.IsSelfIssued(cert) && i < n)
		{
			return;
		}
		X509Name principal = cert.SubjectDN;
		Asn1Sequence dns;
		try
		{
			dns = Asn1Sequence.GetInstance(principal.GetEncoded());
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Exception extracting subject name when checking subtrees.", cause, certPath, index);
		}
		try
		{
			nameConstraintValidator.CheckPermittedDN(dns);
			nameConstraintValidator.CheckExcludedDN(dns);
		}
		catch (PkixNameConstraintValidatorException cause2)
		{
			throw new PkixCertPathValidatorException("Subtree check for certificate subject failed.", cause2, certPath, index);
		}
		GeneralNames altName = null;
		try
		{
			altName = GeneralNames.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.SubjectAlternativeName));
		}
		catch (Exception cause3)
		{
			throw new PkixCertPathValidatorException("Subject alternative name extension could not be decoded.", cause3, certPath, index);
		}
		foreach (string email in X509Name.GetInstance(dns).GetValueList(X509Name.EmailAddress))
		{
			GeneralName emailAsGeneralName = new GeneralName(1, email);
			try
			{
				nameConstraintValidator.checkPermitted(emailAsGeneralName);
				nameConstraintValidator.checkExcluded(emailAsGeneralName);
			}
			catch (PkixNameConstraintValidatorException cause4)
			{
				throw new PkixCertPathValidatorException("Subtree check for certificate subject alternative email failed.", cause4, certPath, index);
			}
		}
		if (altName == null)
		{
			return;
		}
		GeneralName[] genNames = null;
		try
		{
			genNames = altName.GetNames();
		}
		catch (Exception cause5)
		{
			throw new PkixCertPathValidatorException("Subject alternative name contents could not be decoded.", cause5, certPath, index);
		}
		GeneralName[] array = genNames;
		foreach (GeneralName genName in array)
		{
			try
			{
				nameConstraintValidator.checkPermitted(genName);
				nameConstraintValidator.checkExcluded(genName);
			}
			catch (PkixNameConstraintValidatorException cause6)
			{
				throw new PkixCertPathValidatorException("Subtree check for certificate subject alternative name failed.", cause6, certPath, index);
			}
		}
	}

	internal static void PrepareNextCertA(PkixCertPath certPath, int index)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		Asn1Sequence pm = null;
		try
		{
			pm = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.PolicyMappings));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Policy mappings extension could not be decoded.", cause, certPath, index);
		}
		if (pm == null)
		{
			return;
		}
		Asn1Sequence mappings = pm;
		for (int j = 0; j < mappings.Count; j++)
		{
			DerObjectIdentifier issuerDomainPolicy = null;
			DerObjectIdentifier subjectDomainPolicy = null;
			try
			{
				Asn1Sequence instance = Asn1Sequence.GetInstance(mappings[j]);
				issuerDomainPolicy = DerObjectIdentifier.GetInstance(instance[0]);
				subjectDomainPolicy = DerObjectIdentifier.GetInstance(instance[1]);
			}
			catch (Exception cause2)
			{
				throw new PkixCertPathValidatorException("Policy mappings extension contents could not be decoded.", cause2, certPath, index);
			}
			if (ANY_POLICY.Equals(issuerDomainPolicy.Id))
			{
				throw new PkixCertPathValidatorException("IssuerDomainPolicy is anyPolicy", null, certPath, index);
			}
			if (ANY_POLICY.Equals(subjectDomainPolicy.Id))
			{
				throw new PkixCertPathValidatorException("SubjectDomainPolicy is anyPolicy,", null, certPath, index);
			}
		}
	}

	internal static PkixPolicyNode ProcessCertD(PkixCertPath certPath, int index, ISet acceptablePolicies, PkixPolicyNode validPolicyTree, IList[] policyNodes, int inhibitAnyPolicy)
	{
		IList certificates = certPath.Certificates;
		X509Certificate cert = (X509Certificate)certificates[index];
		int n = certificates.Count;
		int i = n - index;
		Asn1Sequence certPolicies = null;
		try
		{
			certPolicies = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.CertificatePolicies));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Could not read certificate policies extension from certificate.", cause, certPath, index);
		}
		if (certPolicies != null && validPolicyTree != null)
		{
			ISet pols = new HashSet();
			foreach (Asn1Encodable item in certPolicies)
			{
				PolicyInformation pInfo = PolicyInformation.GetInstance(item.ToAsn1Object());
				DerObjectIdentifier pOid = pInfo.PolicyIdentifier;
				pols.Add(pOid.Id);
				if (!ANY_POLICY.Equals(pOid.Id))
				{
					ISet pq = null;
					try
					{
						pq = PkixCertPathValidatorUtilities.GetQualifierSet(pInfo.PolicyQualifiers);
					}
					catch (PkixCertPathValidatorException cause2)
					{
						throw new PkixCertPathValidatorException("Policy qualifier info set could not be build.", cause2, certPath, index);
					}
					if (!PkixCertPathValidatorUtilities.ProcessCertD1i(i, policyNodes, pOid, pq))
					{
						PkixCertPathValidatorUtilities.ProcessCertD1ii(i, policyNodes, pOid, pq);
					}
				}
			}
			if (acceptablePolicies.IsEmpty || acceptablePolicies.Contains(ANY_POLICY))
			{
				acceptablePolicies.Clear();
				acceptablePolicies.AddAll(pols);
			}
			else
			{
				ISet t1 = new HashSet();
				foreach (object o in acceptablePolicies)
				{
					if (pols.Contains(o))
					{
						t1.Add(o);
					}
				}
				acceptablePolicies.Clear();
				acceptablePolicies.AddAll(t1);
			}
			if (inhibitAnyPolicy > 0 || (i < n && PkixCertPathValidatorUtilities.IsSelfIssued(cert)))
			{
				foreach (Asn1Encodable item2 in certPolicies)
				{
					PolicyInformation pInfo2 = PolicyInformation.GetInstance(item2.ToAsn1Object());
					if (!ANY_POLICY.Equals(pInfo2.PolicyIdentifier.Id))
					{
						continue;
					}
					ISet _apq = PkixCertPathValidatorUtilities.GetQualifierSet(pInfo2.PolicyQualifiers);
					IList _nodes = policyNodes[i - 1];
					for (int k = 0; k < _nodes.Count; k++)
					{
						PkixPolicyNode _node = (PkixPolicyNode)_nodes[k];
						IEnumerator _policySetIter = _node.ExpectedPolicies.GetEnumerator();
						while (_policySetIter.MoveNext())
						{
							object _tmp = _policySetIter.Current;
							string _policy;
							if (_tmp is string)
							{
								_policy = (string)_tmp;
							}
							else
							{
								if (!(_tmp is DerObjectIdentifier))
								{
									continue;
								}
								_policy = ((DerObjectIdentifier)_tmp).Id;
							}
							bool _found = false;
							foreach (PkixPolicyNode _child in _node.Children)
							{
								if (_policy.Equals(_child.ValidPolicy))
								{
									_found = true;
								}
							}
							if (!_found)
							{
								ISet _newChildExpectedPolicies = new HashSet();
								_newChildExpectedPolicies.Add(_policy);
								PkixPolicyNode _newChild = new PkixPolicyNode(Platform.CreateArrayList(), i, _newChildExpectedPolicies, _node, _apq, _policy, critical: false);
								_node.AddChild(_newChild);
								policyNodes[i].Add(_newChild);
							}
						}
					}
					break;
				}
			}
			PkixPolicyNode _validPolicyTree = validPolicyTree;
			for (int j = i - 1; j >= 0; j--)
			{
				IList nodes = policyNodes[j];
				for (int l = 0; l < nodes.Count; l++)
				{
					PkixPolicyNode node = (PkixPolicyNode)nodes[l];
					if (!node.HasChildren)
					{
						_validPolicyTree = PkixCertPathValidatorUtilities.RemovePolicyNode(_validPolicyTree, policyNodes, node);
						if (_validPolicyTree == null)
						{
							break;
						}
					}
				}
			}
			ISet criticalExtensionOids = cert.GetCriticalExtensionOids();
			if (criticalExtensionOids != null)
			{
				bool critical = criticalExtensionOids.Contains(X509Extensions.CertificatePolicies.Id);
				IList nodes2 = policyNodes[i];
				for (int m = 0; m < nodes2.Count; m++)
				{
					((PkixPolicyNode)nodes2[m]).IsCritical = critical;
				}
			}
			return _validPolicyTree;
		}
		return null;
	}

	internal static void ProcessCrlB1(DistributionPoint dp, object cert, X509Crl crl)
	{
		Asn1Object idp = PkixCertPathValidatorUtilities.GetExtensionValue(crl, X509Extensions.IssuingDistributionPoint);
		bool isIndirect = false;
		if (idp != null && IssuingDistributionPoint.GetInstance(idp).IsIndirectCrl)
		{
			isIndirect = true;
		}
		byte[] issuerBytes = crl.IssuerDN.GetEncoded();
		bool matchIssuer = false;
		if (dp.CrlIssuer != null)
		{
			GeneralName[] genNames = dp.CrlIssuer.GetNames();
			for (int j = 0; j < genNames.Length; j++)
			{
				if (genNames[j].TagNo != 4)
				{
					continue;
				}
				try
				{
					if (Arrays.AreEqual(genNames[j].Name.ToAsn1Object().GetEncoded(), issuerBytes))
					{
						matchIssuer = true;
					}
				}
				catch (IOException innerException)
				{
					throw new Exception("CRL issuer information from distribution point cannot be decoded.", innerException);
				}
			}
			if (matchIssuer && !isIndirect)
			{
				throw new Exception("Distribution point contains cRLIssuer field but CRL is not indirect.");
			}
			if (!matchIssuer)
			{
				throw new Exception("CRL issuer of CRL does not match CRL issuer of distribution point.");
			}
		}
		else if (crl.IssuerDN.Equivalent(PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert), inOrder: true))
		{
			matchIssuer = true;
		}
		if (!matchIssuer)
		{
			throw new Exception("Cannot find matching CRL issuer for certificate.");
		}
	}

	internal static ReasonsMask ProcessCrlD(X509Crl crl, DistributionPoint dp)
	{
		IssuingDistributionPoint idp = null;
		try
		{
			idp = IssuingDistributionPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(crl, X509Extensions.IssuingDistributionPoint));
		}
		catch (Exception innerException)
		{
			throw new Exception("issuing distribution point extension could not be decoded.", innerException);
		}
		if (idp != null && idp.OnlySomeReasons != null && dp.Reasons != null)
		{
			return new ReasonsMask(dp.Reasons.IntValue).Intersect(new ReasonsMask(idp.OnlySomeReasons.IntValue));
		}
		if ((idp == null || idp.OnlySomeReasons == null) && dp.Reasons == null)
		{
			return ReasonsMask.AllReasons;
		}
		ReasonsMask dpReasons = null;
		dpReasons = ((dp.Reasons != null) ? new ReasonsMask(dp.Reasons.IntValue) : ReasonsMask.AllReasons);
		ReasonsMask idpReasons = null;
		idpReasons = ((idp != null) ? new ReasonsMask(idp.OnlySomeReasons.IntValue) : ReasonsMask.AllReasons);
		return dpReasons.Intersect(idpReasons);
	}

	internal static ISet ProcessCrlF(X509Crl crl, object cert, X509Certificate defaultCRLSignCert, AsymmetricKeyParameter defaultCRLSignKey, PkixParameters paramsPKIX, IList certPathCerts)
	{
		X509CertStoreSelector selector = new X509CertStoreSelector();
		try
		{
			selector.Subject = crl.IssuerDN;
		}
		catch (IOException innerException)
		{
			throw new Exception("Subject criteria for certificate selector to find issuer certificate for CRL could not be set.", innerException);
		}
		IList coll = Platform.CreateArrayList();
		try
		{
			CollectionUtilities.AddRange(coll, PkixCertPathValidatorUtilities.FindCertificates(selector, paramsPKIX.GetStores()));
			CollectionUtilities.AddRange(coll, PkixCertPathValidatorUtilities.FindCertificates(selector, paramsPKIX.GetAdditionalStores()));
		}
		catch (Exception innerException2)
		{
			throw new Exception("Issuer certificate for CRL cannot be searched.", innerException2);
		}
		coll.Add(defaultCRLSignCert);
		IEnumerator cert_it = coll.GetEnumerator();
		IList validCerts = Platform.CreateArrayList();
		IList validKeys = Platform.CreateArrayList();
		while (cert_it.MoveNext())
		{
			X509Certificate signingCert = (X509Certificate)cert_it.Current;
			if (signingCert.Equals(defaultCRLSignCert))
			{
				validCerts.Add(signingCert);
				validKeys.Add(defaultCRLSignKey);
				continue;
			}
			try
			{
				PkixCertPathBuilder pkixCertPathBuilder = new PkixCertPathBuilder();
				selector = new X509CertStoreSelector
				{
					Certificate = signingCert
				};
				PkixParameters obj = (PkixParameters)paramsPKIX.Clone();
				obj.SetTargetCertConstraints(selector);
				PkixBuilderParameters parameters = PkixBuilderParameters.GetInstance(obj);
				if (certPathCerts.Contains(signingCert))
				{
					parameters.IsRevocationEnabled = false;
				}
				else
				{
					parameters.IsRevocationEnabled = true;
				}
				IList certs = pkixCertPathBuilder.Build(parameters).CertPath.Certificates;
				validCerts.Add(signingCert);
				validKeys.Add(PkixCertPathValidatorUtilities.GetNextWorkingKey(certs, 0));
			}
			catch (PkixCertPathBuilderException innerException3)
			{
				throw new Exception("CertPath for CRL signer failed to validate.", innerException3);
			}
			catch (PkixCertPathValidatorException innerException4)
			{
				throw new Exception("Public key of issuer certificate of CRL could not be retrieved.", innerException4);
			}
		}
		ISet checkKeys = new HashSet();
		Exception lastException = null;
		for (int i = 0; i < validCerts.Count; i++)
		{
			bool[] keyusage = ((X509Certificate)validCerts[i]).GetKeyUsage();
			if (keyusage != null && (keyusage.Length < 7 || !keyusage[CRL_SIGN]))
			{
				lastException = new Exception("Issuer certificate key usage extension does not permit CRL signing.");
			}
			else
			{
				checkKeys.Add(validKeys[i]);
			}
		}
		if (checkKeys.Count == 0 && lastException == null)
		{
			throw new Exception("Cannot find a valid issuer certificate.");
		}
		if (checkKeys.Count == 0 && lastException != null)
		{
			throw lastException;
		}
		return checkKeys;
	}

	internal static AsymmetricKeyParameter ProcessCrlG(X509Crl crl, ISet keys)
	{
		Exception lastException = null;
		foreach (AsymmetricKeyParameter key in keys)
		{
			try
			{
				crl.Verify(key);
				return key;
			}
			catch (Exception ex)
			{
				lastException = ex;
			}
		}
		throw new Exception("Cannot verify CRL.", lastException);
	}

	internal static X509Crl ProcessCrlH(ISet deltaCrls, AsymmetricKeyParameter key)
	{
		Exception lastException = null;
		foreach (X509Crl crl in deltaCrls)
		{
			try
			{
				crl.Verify(key);
				return crl;
			}
			catch (Exception ex)
			{
				lastException = ex;
			}
		}
		if (lastException != null)
		{
			throw new Exception("Cannot verify delta CRL.", lastException);
		}
		return null;
	}

	private static void CheckCrl(DistributionPoint dp, PkixParameters paramsPKIX, X509Certificate cert, DateTime validDate, X509Certificate defaultCRLSignCert, AsymmetricKeyParameter defaultCRLSignKey, CertStatus certStatus, ReasonsMask reasonMask, IList certPathCerts)
	{
		DateTime currentDate = DateTime.UtcNow;
		if (validDate.Ticks > currentDate.Ticks)
		{
			throw new Exception("Validation time is in future.");
		}
		ISet completeCrls = PkixCertPathValidatorUtilities.GetCompleteCrls(dp, cert, currentDate, paramsPKIX);
		bool validCrlFound = false;
		Exception lastException = null;
		IEnumerator crl_iter = completeCrls.GetEnumerator();
		while (crl_iter.MoveNext() && certStatus.Status == 11 && !reasonMask.IsAllReasons)
		{
			try
			{
				X509Crl crl = (X509Crl)crl_iter.Current;
				ReasonsMask interimReasonsMask = ProcessCrlD(crl, dp);
				if (!interimReasonsMask.HasNewReasons(reasonMask))
				{
					continue;
				}
				ISet keys = ProcessCrlF(crl, cert, defaultCRLSignCert, defaultCRLSignKey, paramsPKIX, certPathCerts);
				AsymmetricKeyParameter key = ProcessCrlG(crl, keys);
				X509Crl deltaCRL = null;
				if (paramsPKIX.IsUseDeltasEnabled)
				{
					deltaCRL = ProcessCrlH(PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl), key);
				}
				if (paramsPKIX.ValidityModel != 1 && cert.NotAfter.Ticks < crl.ThisUpdate.Ticks)
				{
					throw new Exception("No valid CRL for current time found.");
				}
				ProcessCrlB1(dp, cert, crl);
				ProcessCrlB2(dp, cert, crl);
				ProcessCrlC(deltaCRL, crl, paramsPKIX);
				ProcessCrlI(validDate, deltaCRL, cert, certStatus, paramsPKIX);
				ProcessCrlJ(validDate, crl, cert, certStatus);
				if (certStatus.Status == 8)
				{
					certStatus.Status = 11;
				}
				reasonMask.AddReasons(interimReasonsMask);
				ISet criticalExtensions = crl.GetCriticalExtensionOids();
				if (criticalExtensions != null)
				{
					criticalExtensions = new HashSet(criticalExtensions);
					criticalExtensions.Remove(X509Extensions.IssuingDistributionPoint.Id);
					criticalExtensions.Remove(X509Extensions.DeltaCrlIndicator.Id);
					if (!criticalExtensions.IsEmpty)
					{
						throw new Exception("CRL contains unsupported critical extensions.");
					}
				}
				if (deltaCRL != null)
				{
					criticalExtensions = deltaCRL.GetCriticalExtensionOids();
					if (criticalExtensions != null)
					{
						criticalExtensions = new HashSet(criticalExtensions);
						criticalExtensions.Remove(X509Extensions.IssuingDistributionPoint.Id);
						criticalExtensions.Remove(X509Extensions.DeltaCrlIndicator.Id);
						if (!criticalExtensions.IsEmpty)
						{
							throw new Exception("Delta CRL contains unsupported critical extension.");
						}
					}
				}
				validCrlFound = true;
			}
			catch (Exception ex)
			{
				lastException = ex;
			}
		}
		if (!validCrlFound)
		{
			throw lastException;
		}
	}

	protected static void CheckCrls(PkixParameters paramsPKIX, X509Certificate cert, DateTime validDate, X509Certificate sign, AsymmetricKeyParameter workingPublicKey, IList certPathCerts)
	{
		Exception lastException = null;
		CrlDistPoint crldp = null;
		try
		{
			crldp = CrlDistPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.CrlDistributionPoints));
		}
		catch (Exception innerException)
		{
			throw new Exception("CRL distribution point extension could not be read.", innerException);
		}
		try
		{
			PkixCertPathValidatorUtilities.AddAdditionalStoresFromCrlDistributionPoint(crldp, paramsPKIX);
		}
		catch (Exception innerException2)
		{
			throw new Exception("No additional CRL locations could be decoded from CRL distribution point extension.", innerException2);
		}
		CertStatus certStatus = new CertStatus();
		ReasonsMask reasonsMask = new ReasonsMask();
		bool validCrlFound = false;
		if (crldp != null)
		{
			DistributionPoint[] dps = null;
			try
			{
				dps = crldp.GetDistributionPoints();
			}
			catch (Exception innerException3)
			{
				throw new Exception("Distribution points could not be read.", innerException3);
			}
			if (dps != null)
			{
				for (int i = 0; i < dps.Length; i++)
				{
					if (certStatus.Status != 11)
					{
						break;
					}
					if (reasonsMask.IsAllReasons)
					{
						break;
					}
					PkixParameters paramsPKIXClone = (PkixParameters)paramsPKIX.Clone();
					try
					{
						CheckCrl(dps[i], paramsPKIXClone, cert, validDate, sign, workingPublicKey, certStatus, reasonsMask, certPathCerts);
						validCrlFound = true;
					}
					catch (Exception ex)
					{
						lastException = ex;
					}
				}
			}
		}
		if (certStatus.Status == 11 && !reasonsMask.IsAllReasons)
		{
			try
			{
				X509Name issuer;
				try
				{
					issuer = X509Name.GetInstance(cert.IssuerDN.GetEncoded());
				}
				catch (Exception innerException4)
				{
					throw new Exception("Issuer from certificate for CRL could not be reencoded.", innerException4);
				}
				DistributionPoint dp = new DistributionPoint(new DistributionPointName(0, new GeneralNames(new GeneralName(4, issuer))), null, null);
				PkixParameters paramsPKIXClone2 = (PkixParameters)paramsPKIX.Clone();
				CheckCrl(dp, paramsPKIXClone2, cert, validDate, sign, workingPublicKey, certStatus, reasonsMask, certPathCerts);
				validCrlFound = true;
			}
			catch (Exception ex2)
			{
				lastException = ex2;
			}
		}
		if (!validCrlFound)
		{
			throw lastException;
		}
		if (certStatus.Status != 11)
		{
			string formattedDate = certStatus.RevocationDate.Value.ToString("ddd MMM dd HH:mm:ss K yyyy");
			throw new Exception(string.Concat("Certificate revocation after " + formattedDate, ", reason: ", CrlReasons[certStatus.Status]));
		}
		if (!reasonsMask.IsAllReasons && certStatus.Status == 11)
		{
			certStatus.Status = 12;
		}
		if (certStatus.Status == 12)
		{
			throw new Exception("Certificate status could not be determined.");
		}
	}

	internal static PkixPolicyNode PrepareCertB(PkixCertPath certPath, int index, IList[] policyNodes, PkixPolicyNode validPolicyTree, int policyMapping)
	{
		IList certificates = certPath.Certificates;
		X509Certificate cert = (X509Certificate)certificates[index];
		int i = certificates.Count - index;
		Asn1Sequence pm = null;
		try
		{
			pm = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.PolicyMappings));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Policy mappings extension could not be decoded.", cause, certPath, index);
		}
		PkixPolicyNode _validPolicyTree = validPolicyTree;
		if (pm != null)
		{
			Asn1Sequence mappings = pm;
			IDictionary m_idp = Platform.CreateHashtable();
			ISet s_idp = new HashSet();
			for (int j = 0; j < mappings.Count; j++)
			{
				Asn1Sequence obj = (Asn1Sequence)mappings[j];
				string id_p = ((DerObjectIdentifier)obj[0]).Id;
				string sd_p = ((DerObjectIdentifier)obj[1]).Id;
				if (!m_idp.Contains(id_p))
				{
					ISet tmp = new HashSet();
					tmp.Add(sd_p);
					m_idp[id_p] = tmp;
					s_idp.Add(id_p);
				}
				else
				{
					ISet tmp = (ISet)m_idp[id_p];
					tmp.Add(sd_p);
				}
			}
			IEnumerator it_idp = s_idp.GetEnumerator();
			while (it_idp.MoveNext())
			{
				string id_p2 = (string)it_idp.Current;
				if (policyMapping > 0)
				{
					bool idp_found = false;
					IEnumerator nodes_i = policyNodes[i].GetEnumerator();
					while (nodes_i.MoveNext())
					{
						PkixPolicyNode node = (PkixPolicyNode)nodes_i.Current;
						if (node.ValidPolicy.Equals(id_p2))
						{
							idp_found = true;
							node.ExpectedPolicies = (ISet)m_idp[id_p2];
							break;
						}
					}
					if (idp_found)
					{
						continue;
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
							policies = (Asn1Sequence)PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.CertificatePolicies);
						}
						catch (Exception cause2)
						{
							throw new PkixCertPathValidatorException("Certificate policies extension could not be decoded.", cause2, certPath, index);
						}
						foreach (Asn1Encodable ae in policies)
						{
							PolicyInformation pinfo = null;
							try
							{
								pinfo = PolicyInformation.GetInstance(ae.ToAsn1Object());
							}
							catch (Exception cause3)
							{
								throw new PkixCertPathValidatorException("Policy information could not be decoded.", cause3, certPath, index);
							}
							if (ANY_POLICY.Equals(pinfo.PolicyIdentifier.Id))
							{
								try
								{
									pq = PkixCertPathValidatorUtilities.GetQualifierSet(pinfo.PolicyQualifiers);
								}
								catch (PkixCertPathValidatorException cause4)
								{
									throw new PkixCertPathValidatorException("Policy qualifier info set could not be decoded.", cause4, certPath, index);
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
							PkixPolicyNode c_node = new PkixPolicyNode(Platform.CreateArrayList(), i, (ISet)m_idp[id_p2], p_node, pq, id_p2, ci);
							p_node.AddChild(c_node);
							policyNodes[i].Add(c_node);
						}
						break;
					}
				}
				else
				{
					if (policyMapping > 0)
					{
						continue;
					}
					foreach (PkixPolicyNode node3 in Platform.CreateArrayList(policyNodes[i]))
					{
						if (!node3.ValidPolicy.Equals(id_p2))
						{
							continue;
						}
						node3.Parent.RemoveChild(node3);
						for (int k = i - 1; k >= 0; k--)
						{
							foreach (PkixPolicyNode node4 in Platform.CreateArrayList(policyNodes[k]))
							{
								if (!node4.HasChildren)
								{
									_validPolicyTree = PkixCertPathValidatorUtilities.RemovePolicyNode(_validPolicyTree, policyNodes, node4);
									if (_validPolicyTree == null)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
		}
		return _validPolicyTree;
	}

	internal static ISet[] ProcessCrlA1ii(DateTime currentDate, PkixParameters paramsPKIX, X509Certificate cert, X509Crl crl)
	{
		ISet deltaSet = new HashSet();
		X509CrlStoreSelector crlselect = new X509CrlStoreSelector();
		crlselect.CertificateChecking = cert;
		try
		{
			IList issuer = Platform.CreateArrayList();
			issuer.Add(crl.IssuerDN);
			crlselect.Issuers = issuer;
		}
		catch (IOException ex)
		{
			throw new Exception("Cannot extract issuer from CRL." + ex, ex);
		}
		crlselect.CompleteCrlEnabled = true;
		ISet completeSet = CrlUtilities.FindCrls(crlselect, paramsPKIX, currentDate);
		if (paramsPKIX.IsUseDeltasEnabled)
		{
			try
			{
				deltaSet.AddAll(PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl));
			}
			catch (Exception innerException)
			{
				throw new Exception("Exception obtaining delta CRLs.", innerException);
			}
		}
		return new ISet[2] { completeSet, deltaSet };
	}

	internal static ISet ProcessCrlA1i(DateTime currentDate, PkixParameters paramsPKIX, X509Certificate cert, X509Crl crl)
	{
		ISet deltaSet = new HashSet();
		if (paramsPKIX.IsUseDeltasEnabled)
		{
			CrlDistPoint freshestCRL = null;
			try
			{
				freshestCRL = CrlDistPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.FreshestCrl));
			}
			catch (Exception innerException)
			{
				throw new Exception("Freshest CRL extension could not be decoded from certificate.", innerException);
			}
			if (freshestCRL == null)
			{
				try
				{
					freshestCRL = CrlDistPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(crl, X509Extensions.FreshestCrl));
				}
				catch (Exception innerException2)
				{
					throw new Exception("Freshest CRL extension could not be decoded from CRL.", innerException2);
				}
			}
			if (freshestCRL != null)
			{
				try
				{
					PkixCertPathValidatorUtilities.AddAdditionalStoresFromCrlDistributionPoint(freshestCRL, paramsPKIX);
				}
				catch (Exception innerException3)
				{
					throw new Exception("No new delta CRL locations could be added from Freshest CRL extension.", innerException3);
				}
				try
				{
					deltaSet.AddAll(PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl));
				}
				catch (Exception innerException4)
				{
					throw new Exception("Exception obtaining delta CRLs.", innerException4);
				}
			}
		}
		return deltaSet;
	}

	internal static void ProcessCertF(PkixCertPath certPath, int index, PkixPolicyNode validPolicyTree, int explicitPolicy)
	{
		if (explicitPolicy <= 0 && validPolicyTree == null)
		{
			throw new PkixCertPathValidatorException("No valid policy tree found when one expected.", null, certPath, index);
		}
	}

	internal static void ProcessCertA(PkixCertPath certPath, PkixParameters paramsPKIX, int index, AsymmetricKeyParameter workingPublicKey, X509Name workingIssuerName, X509Certificate sign)
	{
		IList certs = certPath.Certificates;
		X509Certificate cert = (X509Certificate)certs[index];
		try
		{
			cert.Verify(workingPublicKey);
		}
		catch (GeneralSecurityException cause)
		{
			throw new PkixCertPathValidatorException("Could not validate certificate signature.", cause, certPath, index);
		}
		try
		{
			cert.CheckValidity(PkixCertPathValidatorUtilities.GetValidCertDateFromValidityModel(paramsPKIX, certPath, index));
		}
		catch (CertificateExpiredException ex)
		{
			throw new PkixCertPathValidatorException("Could not validate certificate: " + ex.Message, ex, certPath, index);
		}
		catch (CertificateNotYetValidException ex2)
		{
			throw new PkixCertPathValidatorException("Could not validate certificate: " + ex2.Message, ex2, certPath, index);
		}
		catch (Exception cause2)
		{
			throw new PkixCertPathValidatorException("Could not validate time of certificate.", cause2, certPath, index);
		}
		if (paramsPKIX.IsRevocationEnabled)
		{
			try
			{
				CheckCrls(paramsPKIX, cert, PkixCertPathValidatorUtilities.GetValidCertDateFromValidityModel(paramsPKIX, certPath, index), sign, workingPublicKey, certs);
			}
			catch (Exception ex3)
			{
				Exception cause3 = ex3.InnerException;
				if (cause3 == null)
				{
					cause3 = ex3;
				}
				throw new PkixCertPathValidatorException(ex3.Message, cause3, certPath, index);
			}
		}
		X509Name issuer = PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert);
		if (!issuer.Equivalent(workingIssuerName, inOrder: true))
		{
			throw new PkixCertPathValidatorException("IssuerName(" + issuer?.ToString() + ") does not match SubjectName(" + workingIssuerName?.ToString() + ") of signing certificate.", null, certPath, index);
		}
	}

	internal static int PrepareNextCertI1(PkixCertPath certPath, int index, int explicitPolicy)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		Asn1Sequence pc = null;
		try
		{
			pc = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.PolicyConstraints));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Policy constraints extension cannot be decoded.", cause, certPath, index);
		}
		if (pc != null)
		{
			IEnumerator policyConstraints = pc.GetEnumerator();
			while (policyConstraints.MoveNext())
			{
				try
				{
					Asn1TaggedObject constraint = Asn1TaggedObject.GetInstance(policyConstraints.Current);
					if (constraint.TagNo == 0)
					{
						int tmpInt = DerInteger.GetInstance(constraint, isExplicit: false).IntValueExact;
						if (tmpInt < explicitPolicy)
						{
							return tmpInt;
						}
						break;
					}
				}
				catch (ArgumentException cause2)
				{
					throw new PkixCertPathValidatorException("Policy constraints extension contents cannot be decoded.", cause2, certPath, index);
				}
			}
		}
		return explicitPolicy;
	}

	internal static int PrepareNextCertI2(PkixCertPath certPath, int index, int policyMapping)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		Asn1Sequence pc = null;
		try
		{
			pc = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.PolicyConstraints));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Policy constraints extension cannot be decoded.", cause, certPath, index);
		}
		if (pc != null)
		{
			IEnumerator policyConstraints = pc.GetEnumerator();
			while (policyConstraints.MoveNext())
			{
				try
				{
					Asn1TaggedObject constraint = Asn1TaggedObject.GetInstance(policyConstraints.Current);
					if (constraint.TagNo == 1)
					{
						int tmpInt = DerInteger.GetInstance(constraint, isExplicit: false).IntValueExact;
						if (tmpInt < policyMapping)
						{
							return tmpInt;
						}
						break;
					}
				}
				catch (ArgumentException cause2)
				{
					throw new PkixCertPathValidatorException("Policy constraints extension contents cannot be decoded.", cause2, certPath, index);
				}
			}
		}
		return policyMapping;
	}

	internal static void PrepareNextCertG(PkixCertPath certPath, int index, PkixNameConstraintValidator nameConstraintValidator)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		NameConstraints nc = null;
		try
		{
			Asn1Sequence ncSeq = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.NameConstraints));
			if (ncSeq != null)
			{
				nc = new NameConstraints(ncSeq);
			}
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Name constraints extension could not be decoded.", cause, certPath, index);
		}
		if (nc == null)
		{
			return;
		}
		Asn1Sequence permitted = nc.PermittedSubtrees;
		if (permitted != null)
		{
			try
			{
				nameConstraintValidator.IntersectPermittedSubtree(permitted);
			}
			catch (Exception cause2)
			{
				throw new PkixCertPathValidatorException("Permitted subtrees cannot be build from name constraints extension.", cause2, certPath, index);
			}
		}
		Asn1Sequence excluded = nc.ExcludedSubtrees;
		if (excluded == null)
		{
			return;
		}
		IEnumerator e = excluded.GetEnumerator();
		try
		{
			while (e.MoveNext())
			{
				GeneralSubtree subtree = GeneralSubtree.GetInstance(e.Current);
				nameConstraintValidator.AddExcludedSubtree(subtree);
			}
		}
		catch (Exception cause3)
		{
			throw new PkixCertPathValidatorException("Excluded subtrees cannot be build from name constraints extension.", cause3, certPath, index);
		}
	}

	internal static int PrepareNextCertJ(PkixCertPath certPath, int index, int inhibitAnyPolicy)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		DerInteger iap = null;
		try
		{
			iap = DerInteger.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.InhibitAnyPolicy));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Inhibit any-policy extension cannot be decoded.", cause, certPath, index);
		}
		if (iap != null)
		{
			int _inhibitAnyPolicy = iap.IntValueExact;
			if (_inhibitAnyPolicy < inhibitAnyPolicy)
			{
				return _inhibitAnyPolicy;
			}
		}
		return inhibitAnyPolicy;
	}

	internal static void PrepareNextCertK(PkixCertPath certPath, int index)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		BasicConstraints bc = null;
		try
		{
			bc = BasicConstraints.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.BasicConstraints));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Basic constraints extension cannot be decoded.", cause, certPath, index);
		}
		if (bc != null)
		{
			if (!bc.IsCA())
			{
				throw new PkixCertPathValidatorException("Not a CA certificate");
			}
			return;
		}
		throw new PkixCertPathValidatorException("Intermediate certificate lacks BasicConstraints");
	}

	internal static int PrepareNextCertL(PkixCertPath certPath, int index, int maxPathLength)
	{
		if (!PkixCertPathValidatorUtilities.IsSelfIssued((X509Certificate)certPath.Certificates[index]))
		{
			if (maxPathLength <= 0)
			{
				throw new PkixCertPathValidatorException("Max path length not greater than zero", null, certPath, index);
			}
			return maxPathLength - 1;
		}
		return maxPathLength;
	}

	internal static int PrepareNextCertM(PkixCertPath certPath, int index, int maxPathLength)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		BasicConstraints bc = null;
		try
		{
			bc = BasicConstraints.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.BasicConstraints));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Basic constraints extension cannot be decoded.", cause, certPath, index);
		}
		if (bc != null)
		{
			BigInteger _pathLengthConstraint = bc.PathLenConstraint;
			if (_pathLengthConstraint != null)
			{
				int _plc = _pathLengthConstraint.IntValue;
				if (_plc < maxPathLength)
				{
					return _plc;
				}
			}
		}
		return maxPathLength;
	}

	internal static void PrepareNextCertN(PkixCertPath certPath, int index)
	{
		bool[] _usage = ((X509Certificate)certPath.Certificates[index]).GetKeyUsage();
		if (_usage != null && !_usage[KEY_CERT_SIGN])
		{
			throw new PkixCertPathValidatorException("Issuer certificate keyusage extension is critical and does not permit key signing.", null, certPath, index);
		}
	}

	internal static void PrepareNextCertO(PkixCertPath certPath, int index, ISet criticalExtensions, IList pathCheckers)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		IEnumerator tmpIter = pathCheckers.GetEnumerator();
		while (tmpIter.MoveNext())
		{
			try
			{
				((PkixCertPathChecker)tmpIter.Current).Check(cert, criticalExtensions);
			}
			catch (PkixCertPathValidatorException ex)
			{
				throw new PkixCertPathValidatorException(ex.Message, ex.InnerException, certPath, index);
			}
		}
		if (!criticalExtensions.IsEmpty)
		{
			throw new PkixCertPathValidatorException("Certificate has unsupported critical extension.", null, certPath, index);
		}
	}

	internal static int PrepareNextCertH1(PkixCertPath certPath, int index, int explicitPolicy)
	{
		if (!PkixCertPathValidatorUtilities.IsSelfIssued((X509Certificate)certPath.Certificates[index]) && explicitPolicy != 0)
		{
			return explicitPolicy - 1;
		}
		return explicitPolicy;
	}

	internal static int PrepareNextCertH2(PkixCertPath certPath, int index, int policyMapping)
	{
		if (!PkixCertPathValidatorUtilities.IsSelfIssued((X509Certificate)certPath.Certificates[index]) && policyMapping != 0)
		{
			return policyMapping - 1;
		}
		return policyMapping;
	}

	internal static int PrepareNextCertH3(PkixCertPath certPath, int index, int inhibitAnyPolicy)
	{
		if (!PkixCertPathValidatorUtilities.IsSelfIssued((X509Certificate)certPath.Certificates[index]) && inhibitAnyPolicy != 0)
		{
			return inhibitAnyPolicy - 1;
		}
		return inhibitAnyPolicy;
	}

	internal static int WrapupCertA(int explicitPolicy, X509Certificate cert)
	{
		if (!PkixCertPathValidatorUtilities.IsSelfIssued(cert) && explicitPolicy != 0)
		{
			explicitPolicy--;
		}
		return explicitPolicy;
	}

	internal static int WrapupCertB(PkixCertPath certPath, int index, int explicitPolicy)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		Asn1Sequence pc = null;
		try
		{
			pc = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.PolicyConstraints));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Policy constraints could not be decoded.", cause, certPath, index);
		}
		if (pc != null)
		{
			IEnumerator policyConstraints = pc.GetEnumerator();
			while (policyConstraints.MoveNext())
			{
				Asn1TaggedObject constraint = (Asn1TaggedObject)policyConstraints.Current;
				if (constraint.TagNo == 0)
				{
					int tmpInt;
					try
					{
						tmpInt = DerInteger.GetInstance(constraint, isExplicit: false).IntValueExact;
					}
					catch (Exception cause2)
					{
						throw new PkixCertPathValidatorException("Policy constraints requireExplicitPolicy field could not be decoded.", cause2, certPath, index);
					}
					if (tmpInt == 0)
					{
						return 0;
					}
				}
			}
		}
		return explicitPolicy;
	}

	internal static void WrapupCertF(PkixCertPath certPath, int index, IList pathCheckers, ISet criticalExtensions)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		IEnumerator tmpIter = pathCheckers.GetEnumerator();
		while (tmpIter.MoveNext())
		{
			try
			{
				((PkixCertPathChecker)tmpIter.Current).Check(cert, criticalExtensions);
			}
			catch (PkixCertPathValidatorException cause)
			{
				throw new PkixCertPathValidatorException("Additional certificate path checker failed.", cause, certPath, index);
			}
		}
		if (!criticalExtensions.IsEmpty)
		{
			throw new PkixCertPathValidatorException("Certificate has unsupported critical extension", null, certPath, index);
		}
	}

	internal static PkixPolicyNode WrapupCertG(PkixCertPath certPath, PkixParameters paramsPKIX, ISet userInitialPolicySet, int index, IList[] policyNodes, PkixPolicyNode validPolicyTree, ISet acceptablePolicies)
	{
		int n = certPath.Certificates.Count;
		if (validPolicyTree == null)
		{
			if (paramsPKIX.IsExplicitPolicyRequired)
			{
				throw new PkixCertPathValidatorException("Explicit policy requested but none available.", null, certPath, index);
			}
			return null;
		}
		if (PkixCertPathValidatorUtilities.IsAnyPolicy(userInitialPolicySet))
		{
			if (paramsPKIX.IsExplicitPolicyRequired)
			{
				if (acceptablePolicies.IsEmpty)
				{
					throw new PkixCertPathValidatorException("Explicit policy requested but none available.", null, certPath, index);
				}
				ISet _validPolicyNodeSet = new HashSet();
				foreach (IList _nodeDepth in policyNodes)
				{
					for (int k = 0; k < _nodeDepth.Count; k++)
					{
						PkixPolicyNode _node = (PkixPolicyNode)_nodeDepth[k];
						if (!ANY_POLICY.Equals(_node.ValidPolicy))
						{
							continue;
						}
						foreach (object o in _node.Children)
						{
							_validPolicyNodeSet.Add(o);
						}
					}
				}
				foreach (PkixPolicyNode item in _validPolicyNodeSet)
				{
					string _validPolicy = item.ValidPolicy;
					acceptablePolicies.Contains(_validPolicy);
				}
				if (validPolicyTree != null)
				{
					for (int j2 = n - 1; j2 >= 0; j2--)
					{
						IList nodes = policyNodes[j2];
						for (int i = 0; i < nodes.Count; i++)
						{
							PkixPolicyNode node = (PkixPolicyNode)nodes[i];
							if (!node.HasChildren)
							{
								validPolicyTree = PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, node);
							}
						}
					}
				}
			}
			return validPolicyTree;
		}
		ISet _validPolicyNodeSet2 = new HashSet();
		foreach (IList _nodeDepth2 in policyNodes)
		{
			for (int m = 0; m < _nodeDepth2.Count; m++)
			{
				PkixPolicyNode _node2 = (PkixPolicyNode)_nodeDepth2[m];
				if (!ANY_POLICY.Equals(_node2.ValidPolicy))
				{
					continue;
				}
				foreach (PkixPolicyNode _c_node in _node2.Children)
				{
					if (!ANY_POLICY.Equals(_c_node.ValidPolicy))
					{
						_validPolicyNodeSet2.Add(_c_node);
					}
				}
			}
		}
		IEnumerator _vpnsIter = _validPolicyNodeSet2.GetEnumerator();
		while (_vpnsIter.MoveNext())
		{
			PkixPolicyNode _node3 = (PkixPolicyNode)_vpnsIter.Current;
			string _validPolicy2 = _node3.ValidPolicy;
			if (!userInitialPolicySet.Contains(_validPolicy2))
			{
				validPolicyTree = PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, _node3);
			}
		}
		if (validPolicyTree != null)
		{
			for (int j3 = n - 1; j3 >= 0; j3--)
			{
				IList nodes2 = policyNodes[j3];
				for (int num = 0; num < nodes2.Count; num++)
				{
					PkixPolicyNode node2 = (PkixPolicyNode)nodes2[num];
					if (!node2.HasChildren)
					{
						validPolicyTree = PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, node2);
					}
				}
			}
		}
		return validPolicyTree;
	}

	internal static void ProcessCrlC(X509Crl deltaCRL, X509Crl completeCRL, PkixParameters pkixParams)
	{
		if (deltaCRL == null)
		{
			return;
		}
		IssuingDistributionPoint completeidp = null;
		try
		{
			completeidp = IssuingDistributionPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(completeCRL, X509Extensions.IssuingDistributionPoint));
		}
		catch (Exception innerException)
		{
			throw new Exception("000 Issuing distribution point extension could not be decoded.", innerException);
		}
		if (pkixParams.IsUseDeltasEnabled)
		{
			if (!deltaCRL.IssuerDN.Equivalent(completeCRL.IssuerDN, inOrder: true))
			{
				throw new Exception("Complete CRL issuer does not match delta CRL issuer.");
			}
			IssuingDistributionPoint deltaidp = null;
			try
			{
				deltaidp = IssuingDistributionPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(deltaCRL, X509Extensions.IssuingDistributionPoint));
			}
			catch (Exception innerException2)
			{
				throw new Exception("Issuing distribution point extension from delta CRL could not be decoded.", innerException2);
			}
			if (!object.Equals(completeidp, deltaidp))
			{
				throw new Exception("Issuing distribution point extension from delta CRL and complete CRL does not match.");
			}
			Asn1Object completeKeyIdentifier = null;
			try
			{
				completeKeyIdentifier = PkixCertPathValidatorUtilities.GetExtensionValue(completeCRL, X509Extensions.AuthorityKeyIdentifier);
			}
			catch (Exception innerException3)
			{
				throw new Exception("Authority key identifier extension could not be extracted from complete CRL.", innerException3);
			}
			Asn1Object deltaKeyIdentifier = null;
			try
			{
				deltaKeyIdentifier = PkixCertPathValidatorUtilities.GetExtensionValue(deltaCRL, X509Extensions.AuthorityKeyIdentifier);
			}
			catch (Exception innerException4)
			{
				throw new Exception("Authority key identifier extension could not be extracted from delta CRL.", innerException4);
			}
			if (completeKeyIdentifier == null)
			{
				throw new Exception("CRL authority key identifier is null.");
			}
			if (deltaKeyIdentifier == null)
			{
				throw new Exception("Delta CRL authority key identifier is null.");
			}
			if (!completeKeyIdentifier.Equals(deltaKeyIdentifier))
			{
				throw new Exception("Delta CRL authority key identifier does not match complete CRL authority key identifier.");
			}
		}
	}

	internal static void ProcessCrlI(DateTime validDate, X509Crl deltacrl, object cert, CertStatus certStatus, PkixParameters pkixParams)
	{
		if (pkixParams.IsUseDeltasEnabled && deltacrl != null)
		{
			PkixCertPathValidatorUtilities.GetCertStatus(validDate, deltacrl, cert, certStatus);
		}
	}

	internal static void ProcessCrlJ(DateTime validDate, X509Crl completecrl, object cert, CertStatus certStatus)
	{
		if (certStatus.Status == 11)
		{
			PkixCertPathValidatorUtilities.GetCertStatus(validDate, completecrl, cert, certStatus);
		}
	}

	internal static PkixPolicyNode ProcessCertE(PkixCertPath certPath, int index, PkixPolicyNode validPolicyTree)
	{
		X509Certificate cert = (X509Certificate)certPath.Certificates[index];
		Asn1Sequence certPolicies = null;
		try
		{
			certPolicies = Asn1Sequence.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(cert, X509Extensions.CertificatePolicies));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Could not read certificate policies extension from certificate.", cause, certPath, index);
		}
		if (certPolicies == null)
		{
			validPolicyTree = null;
		}
		return validPolicyTree;
	}
}
