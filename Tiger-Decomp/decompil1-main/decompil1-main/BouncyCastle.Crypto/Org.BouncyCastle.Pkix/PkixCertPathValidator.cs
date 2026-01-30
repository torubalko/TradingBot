using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixCertPathValidator
{
	public virtual PkixCertPathValidatorResult Validate(PkixCertPath certPath, PkixParameters paramsPkix)
	{
		if (paramsPkix.GetTrustAnchors() == null)
		{
			throw new ArgumentException("trustAnchors is null, this is not allowed for certification path validation.", "parameters");
		}
		IList certs = certPath.Certificates;
		int n = certs.Count;
		if (certs.Count == 0)
		{
			throw new PkixCertPathValidatorException("Certification path is empty.", null, certPath, 0);
		}
		ISet userInitialPolicySet = paramsPkix.GetInitialPolicies();
		TrustAnchor trust;
		try
		{
			trust = PkixCertPathValidatorUtilities.FindTrustAnchor((X509Certificate)certs[certs.Count - 1], paramsPkix.GetTrustAnchors());
			if (trust == null)
			{
				throw new PkixCertPathValidatorException("Trust anchor for certification path not found.", null, certPath, -1);
			}
			CheckCertificate(trust.TrustedCert);
		}
		catch (Exception ex)
		{
			throw new PkixCertPathValidatorException(ex.Message, ex.InnerException, certPath, certs.Count - 1);
		}
		int index = 0;
		IList[] policyNodes = new IList[n + 1];
		for (int j = 0; j < policyNodes.Length; j++)
		{
			policyNodes[j] = Platform.CreateArrayList();
		}
		ISet policySet = new HashSet();
		policySet.Add(Rfc3280CertPathUtilities.ANY_POLICY);
		PkixPolicyNode validPolicyTree = new PkixPolicyNode(Platform.CreateArrayList(), 0, policySet, null, new HashSet(), Rfc3280CertPathUtilities.ANY_POLICY, critical: false);
		policyNodes[0].Add(validPolicyTree);
		PkixNameConstraintValidator nameConstraintValidator = new PkixNameConstraintValidator();
		ISet acceptablePolicies = new HashSet();
		int explicitPolicy = ((!paramsPkix.IsExplicitPolicyRequired) ? (n + 1) : 0);
		int inhibitAnyPolicy = ((!paramsPkix.IsAnyPolicyInhibited) ? (n + 1) : 0);
		int policyMapping = ((!paramsPkix.IsPolicyMappingInhibited) ? (n + 1) : 0);
		X509Certificate sign = trust.TrustedCert;
		X509Name workingIssuerName;
		AsymmetricKeyParameter workingPublicKey;
		try
		{
			if (sign != null)
			{
				workingIssuerName = sign.SubjectDN;
				workingPublicKey = sign.GetPublicKey();
			}
			else
			{
				workingIssuerName = new X509Name(trust.CAName);
				workingPublicKey = trust.CAPublicKey;
			}
		}
		catch (ArgumentException cause)
		{
			throw new PkixCertPathValidatorException("Subject of trust anchor could not be (re)encoded.", cause, certPath, -1);
		}
		try
		{
			PkixCertPathValidatorUtilities.GetAlgorithmIdentifier(workingPublicKey);
		}
		catch (PkixCertPathValidatorException cause2)
		{
			throw new PkixCertPathValidatorException("Algorithm identifier of public key of trust anchor could not be read.", cause2, certPath, -1);
		}
		int maxPathLength = n;
		X509CertStoreSelector certConstraints = paramsPkix.GetTargetCertConstraints();
		if (certConstraints != null && !certConstraints.Match((X509Certificate)certs[0]))
		{
			throw new PkixCertPathValidatorException("Target certificate in certification path does not match targetConstraints.", null, certPath, 0);
		}
		IList pathCheckers = paramsPkix.GetCertPathCheckers();
		IEnumerator certIter = pathCheckers.GetEnumerator();
		while (certIter.MoveNext())
		{
			((PkixCertPathChecker)certIter.Current).Init(forward: false);
		}
		X509Certificate cert = null;
		for (index = certs.Count - 1; index >= 0; index--)
		{
			int i = n - index;
			cert = (X509Certificate)certs[index];
			try
			{
				CheckCertificate(cert);
			}
			catch (Exception ex2)
			{
				throw new PkixCertPathValidatorException(ex2.Message, ex2.InnerException, certPath, index);
			}
			Rfc3280CertPathUtilities.ProcessCertA(certPath, paramsPkix, index, workingPublicKey, workingIssuerName, sign);
			Rfc3280CertPathUtilities.ProcessCertBC(certPath, index, nameConstraintValidator);
			validPolicyTree = Rfc3280CertPathUtilities.ProcessCertD(certPath, index, acceptablePolicies, validPolicyTree, policyNodes, inhibitAnyPolicy);
			validPolicyTree = Rfc3280CertPathUtilities.ProcessCertE(certPath, index, validPolicyTree);
			Rfc3280CertPathUtilities.ProcessCertF(certPath, index, validPolicyTree, explicitPolicy);
			if (i != n)
			{
				if (cert != null && cert.Version == 1)
				{
					if (i != 1 || !cert.Equals(trust.TrustedCert))
					{
						throw new PkixCertPathValidatorException("Version 1 certificates can't be used as CA ones.", null, certPath, index);
					}
				}
				else
				{
					Rfc3280CertPathUtilities.PrepareNextCertA(certPath, index);
					validPolicyTree = Rfc3280CertPathUtilities.PrepareCertB(certPath, index, policyNodes, validPolicyTree, policyMapping);
					Rfc3280CertPathUtilities.PrepareNextCertG(certPath, index, nameConstraintValidator);
					explicitPolicy = Rfc3280CertPathUtilities.PrepareNextCertH1(certPath, index, explicitPolicy);
					policyMapping = Rfc3280CertPathUtilities.PrepareNextCertH2(certPath, index, policyMapping);
					inhibitAnyPolicy = Rfc3280CertPathUtilities.PrepareNextCertH3(certPath, index, inhibitAnyPolicy);
					explicitPolicy = Rfc3280CertPathUtilities.PrepareNextCertI1(certPath, index, explicitPolicy);
					policyMapping = Rfc3280CertPathUtilities.PrepareNextCertI2(certPath, index, policyMapping);
					inhibitAnyPolicy = Rfc3280CertPathUtilities.PrepareNextCertJ(certPath, index, inhibitAnyPolicy);
					Rfc3280CertPathUtilities.PrepareNextCertK(certPath, index);
					maxPathLength = Rfc3280CertPathUtilities.PrepareNextCertL(certPath, index, maxPathLength);
					maxPathLength = Rfc3280CertPathUtilities.PrepareNextCertM(certPath, index, maxPathLength);
					Rfc3280CertPathUtilities.PrepareNextCertN(certPath, index);
					ISet criticalExtensions1 = cert.GetCriticalExtensionOids();
					if (criticalExtensions1 != null)
					{
						criticalExtensions1 = new HashSet(criticalExtensions1);
						criticalExtensions1.Remove(X509Extensions.KeyUsage.Id);
						criticalExtensions1.Remove(X509Extensions.CertificatePolicies.Id);
						criticalExtensions1.Remove(X509Extensions.PolicyMappings.Id);
						criticalExtensions1.Remove(X509Extensions.InhibitAnyPolicy.Id);
						criticalExtensions1.Remove(X509Extensions.IssuingDistributionPoint.Id);
						criticalExtensions1.Remove(X509Extensions.DeltaCrlIndicator.Id);
						criticalExtensions1.Remove(X509Extensions.PolicyConstraints.Id);
						criticalExtensions1.Remove(X509Extensions.BasicConstraints.Id);
						criticalExtensions1.Remove(X509Extensions.SubjectAlternativeName.Id);
						criticalExtensions1.Remove(X509Extensions.NameConstraints.Id);
					}
					else
					{
						criticalExtensions1 = new HashSet();
					}
					Rfc3280CertPathUtilities.PrepareNextCertO(certPath, index, criticalExtensions1, pathCheckers);
					sign = cert;
					workingIssuerName = sign.SubjectDN;
					try
					{
						workingPublicKey = PkixCertPathValidatorUtilities.GetNextWorkingKey(certPath.Certificates, index);
					}
					catch (PkixCertPathValidatorException cause3)
					{
						throw new PkixCertPathValidatorException("Next working key could not be retrieved.", cause3, certPath, index);
					}
					PkixCertPathValidatorUtilities.GetAlgorithmIdentifier(workingPublicKey);
				}
			}
		}
		explicitPolicy = Rfc3280CertPathUtilities.WrapupCertA(explicitPolicy, cert);
		explicitPolicy = Rfc3280CertPathUtilities.WrapupCertB(certPath, index + 1, explicitPolicy);
		ISet criticalExtensions2 = cert.GetCriticalExtensionOids();
		if (criticalExtensions2 != null)
		{
			criticalExtensions2 = new HashSet(criticalExtensions2);
			criticalExtensions2.Remove(X509Extensions.KeyUsage.Id);
			criticalExtensions2.Remove(X509Extensions.CertificatePolicies.Id);
			criticalExtensions2.Remove(X509Extensions.PolicyMappings.Id);
			criticalExtensions2.Remove(X509Extensions.InhibitAnyPolicy.Id);
			criticalExtensions2.Remove(X509Extensions.IssuingDistributionPoint.Id);
			criticalExtensions2.Remove(X509Extensions.DeltaCrlIndicator.Id);
			criticalExtensions2.Remove(X509Extensions.PolicyConstraints.Id);
			criticalExtensions2.Remove(X509Extensions.BasicConstraints.Id);
			criticalExtensions2.Remove(X509Extensions.SubjectAlternativeName.Id);
			criticalExtensions2.Remove(X509Extensions.NameConstraints.Id);
			criticalExtensions2.Remove(X509Extensions.CrlDistributionPoints.Id);
		}
		else
		{
			criticalExtensions2 = new HashSet();
		}
		Rfc3280CertPathUtilities.WrapupCertF(certPath, index + 1, pathCheckers, criticalExtensions2);
		PkixPolicyNode intersection = Rfc3280CertPathUtilities.WrapupCertG(certPath, paramsPkix, userInitialPolicySet, index + 1, policyNodes, validPolicyTree, acceptablePolicies);
		if (explicitPolicy > 0 || intersection != null)
		{
			return new PkixCertPathValidatorResult(trust, intersection, cert.GetPublicKey());
		}
		throw new PkixCertPathValidatorException("Path processing failed on policy.", null, certPath, index);
	}

	internal static void CheckCertificate(X509Certificate cert)
	{
		try
		{
			TbsCertificateStructure.GetInstance(cert.CertificateStructure.TbsCertificate);
		}
		catch (CertificateEncodingException innerException)
		{
			throw new Exception("unable to process TBSCertificate", innerException);
		}
	}
}
