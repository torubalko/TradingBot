using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

internal class Rfc3281CertPathUtilities
{
	internal static void ProcessAttrCert7(IX509AttributeCertificate attrCert, PkixCertPath certPath, PkixCertPath holderCertPath, PkixParameters pkixParams)
	{
		ISet critExtOids = attrCert.GetCriticalExtensionOids();
		if (critExtOids.Contains(X509Extensions.TargetInformation.Id))
		{
			try
			{
				TargetInformation.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(attrCert, X509Extensions.TargetInformation));
			}
			catch (Exception cause)
			{
				throw new PkixCertPathValidatorException("Target information extension could not be read.", cause);
			}
		}
		critExtOids.Remove(X509Extensions.TargetInformation.Id);
		foreach (PkixAttrCertChecker attrCertChecker in pkixParams.GetAttrCertCheckers())
		{
			attrCertChecker.Check(attrCert, certPath, holderCertPath, critExtOids);
		}
		if (!critExtOids.IsEmpty)
		{
			throw new PkixCertPathValidatorException("Attribute certificate contains unsupported critical extensions: " + critExtOids);
		}
	}

	internal static void CheckCrls(IX509AttributeCertificate attrCert, PkixParameters paramsPKIX, X509Certificate issuerCert, DateTime validDate, IList certPathCerts)
	{
		if (!paramsPKIX.IsRevocationEnabled)
		{
			return;
		}
		if (attrCert.GetExtensionValue(X509Extensions.NoRevAvail) != null)
		{
			if (attrCert.GetExtensionValue(X509Extensions.CrlDistributionPoints) == null && attrCert.GetExtensionValue(X509Extensions.AuthorityInfoAccess) == null)
			{
				return;
			}
			throw new PkixCertPathValidatorException("No rev avail extension is set, but also an AC revocation pointer.");
		}
		CrlDistPoint crldp = null;
		try
		{
			crldp = CrlDistPoint.GetInstance(PkixCertPathValidatorUtilities.GetExtensionValue(attrCert, X509Extensions.CrlDistributionPoints));
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("CRL distribution point extension could not be read.", cause);
		}
		try
		{
			PkixCertPathValidatorUtilities.AddAdditionalStoresFromCrlDistributionPoint(crldp, paramsPKIX);
		}
		catch (Exception cause2)
		{
			throw new PkixCertPathValidatorException("No additional CRL locations could be decoded from CRL distribution point extension.", cause2);
		}
		CertStatus certStatus = new CertStatus();
		ReasonsMask reasonsMask = new ReasonsMask();
		Exception lastException = null;
		bool validCrlFound = false;
		if (crldp != null)
		{
			DistributionPoint[] dps = null;
			try
			{
				dps = crldp.GetDistributionPoints();
			}
			catch (Exception cause3)
			{
				throw new PkixCertPathValidatorException("Distribution points could not be read.", cause3);
			}
			try
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
					CheckCrl(dps[i], attrCert, paramsPKIXClone, validDate, issuerCert, certStatus, reasonsMask, certPathCerts);
					validCrlFound = true;
				}
			}
			catch (Exception innerException)
			{
				lastException = new Exception("No valid CRL for distribution point found.", innerException);
			}
		}
		if (certStatus.Status == 11 && !reasonsMask.IsAllReasons)
		{
			try
			{
				X509Name issuer;
				try
				{
					issuer = X509Name.GetInstance(attrCert.Issuer.GetPrincipals()[0].GetEncoded());
				}
				catch (Exception innerException2)
				{
					throw new Exception("Issuer from certificate for CRL could not be reencoded.", innerException2);
				}
				DistributionPoint dp = new DistributionPoint(new DistributionPointName(0, new GeneralNames(new GeneralName(4, issuer))), null, null);
				PkixParameters paramsPKIXClone2 = (PkixParameters)paramsPKIX.Clone();
				CheckCrl(dp, attrCert, paramsPKIXClone2, validDate, issuerCert, certStatus, reasonsMask, certPathCerts);
				validCrlFound = true;
			}
			catch (Exception innerException3)
			{
				lastException = new Exception("No valid CRL for distribution point found.", innerException3);
			}
		}
		if (!validCrlFound)
		{
			throw new PkixCertPathValidatorException("No valid CRL found.", lastException);
		}
		if (certStatus.Status != 11)
		{
			string formattedDate = certStatus.RevocationDate.Value.ToString("ddd MMM dd HH:mm:ss K yyyy");
			throw new PkixCertPathValidatorException(string.Concat("Attribute certificate revocation after " + formattedDate, ", reason: ", Rfc3280CertPathUtilities.CrlReasons[certStatus.Status]));
		}
		if (!reasonsMask.IsAllReasons && certStatus.Status == 11)
		{
			certStatus.Status = 12;
		}
		if (certStatus.Status != 12)
		{
			return;
		}
		throw new PkixCertPathValidatorException("Attribute certificate status could not be determined.");
	}

	internal static void AdditionalChecks(IX509AttributeCertificate attrCert, PkixParameters pkixParams)
	{
		foreach (string oid in pkixParams.GetProhibitedACAttributes())
		{
			if (attrCert.GetAttributes(oid) != null)
			{
				throw new PkixCertPathValidatorException("Attribute certificate contains prohibited attribute: " + oid + ".");
			}
		}
		foreach (string oid2 in pkixParams.GetNecessaryACAttributes())
		{
			if (attrCert.GetAttributes(oid2) == null)
			{
				throw new PkixCertPathValidatorException("Attribute certificate does not contain necessary attribute: " + oid2 + ".");
			}
		}
	}

	internal static void ProcessAttrCert5(IX509AttributeCertificate attrCert, PkixParameters pkixParams)
	{
		try
		{
			attrCert.CheckValidity(PkixCertPathValidatorUtilities.GetValidDate(pkixParams));
		}
		catch (CertificateExpiredException cause)
		{
			throw new PkixCertPathValidatorException("Attribute certificate is not valid.", cause);
		}
		catch (CertificateNotYetValidException cause2)
		{
			throw new PkixCertPathValidatorException("Attribute certificate is not valid.", cause2);
		}
	}

	internal static void ProcessAttrCert4(X509Certificate acIssuerCert, PkixParameters pkixParams)
	{
		ISet trustedACIssuers = pkixParams.GetTrustedACIssuers();
		bool trusted = false;
		foreach (TrustAnchor anchor in trustedACIssuers)
		{
			IDictionary symbols = X509Name.RFC2253Symbols;
			if (acIssuerCert.SubjectDN.ToString(reverse: false, symbols).Equals(anchor.CAName) || acIssuerCert.Equals(anchor.TrustedCert))
			{
				trusted = true;
			}
		}
		if (!trusted)
		{
			throw new PkixCertPathValidatorException("Attribute certificate issuer is not directly trusted.");
		}
	}

	internal static void ProcessAttrCert3(X509Certificate acIssuerCert, PkixParameters pkixParams)
	{
		if (acIssuerCert.GetKeyUsage() != null && !acIssuerCert.GetKeyUsage()[0] && !acIssuerCert.GetKeyUsage()[1])
		{
			throw new PkixCertPathValidatorException("Attribute certificate issuer public key cannot be used to validate digital signatures.");
		}
		if (acIssuerCert.GetBasicConstraints() != -1)
		{
			throw new PkixCertPathValidatorException("Attribute certificate issuer is also a public key certificate issuer.");
		}
	}

	internal static PkixCertPathValidatorResult ProcessAttrCert2(PkixCertPath certPath, PkixParameters pkixParams)
	{
		PkixCertPathValidator validator = new PkixCertPathValidator();
		try
		{
			return validator.Validate(certPath, pkixParams);
		}
		catch (PkixCertPathValidatorException cause)
		{
			throw new PkixCertPathValidatorException("Certification path for issuer certificate of attribute certificate could not be validated.", cause);
		}
	}

	internal static PkixCertPath ProcessAttrCert1(IX509AttributeCertificate attrCert, PkixParameters pkixParams)
	{
		PkixCertPathBuilderResult result = null;
		ISet holderPKCs = new HashSet();
		if (attrCert.Holder.GetIssuer() != null)
		{
			X509CertStoreSelector selector = new X509CertStoreSelector();
			selector.SerialNumber = attrCert.Holder.SerialNumber;
			X509Name[] principals = attrCert.Holder.GetIssuer();
			for (int i = 0; i < principals.Length; i++)
			{
				try
				{
					selector.Issuer = principals[i];
					holderPKCs.AddAll(PkixCertPathValidatorUtilities.FindCertificates(selector, pkixParams.GetStores()));
				}
				catch (Exception cause)
				{
					throw new PkixCertPathValidatorException("Public key certificate for attribute certificate cannot be searched.", cause);
				}
			}
			if (holderPKCs.IsEmpty)
			{
				throw new PkixCertPathValidatorException("Public key certificate specified in base certificate ID for attribute certificate cannot be found.");
			}
		}
		if (attrCert.Holder.GetEntityNames() != null)
		{
			X509CertStoreSelector selector2 = new X509CertStoreSelector();
			X509Name[] principals2 = attrCert.Holder.GetEntityNames();
			for (int j = 0; j < principals2.Length; j++)
			{
				try
				{
					selector2.Issuer = principals2[j];
					holderPKCs.AddAll(PkixCertPathValidatorUtilities.FindCertificates(selector2, pkixParams.GetStores()));
				}
				catch (Exception cause2)
				{
					throw new PkixCertPathValidatorException("Public key certificate for attribute certificate cannot be searched.", cause2);
				}
			}
			if (holderPKCs.IsEmpty)
			{
				throw new PkixCertPathValidatorException("Public key certificate specified in entity name for attribute certificate cannot be found.");
			}
		}
		PkixBuilderParameters parameters = PkixBuilderParameters.GetInstance(pkixParams);
		PkixCertPathValidatorException lastException = null;
		foreach (X509Certificate cert in holderPKCs)
		{
			X509CertStoreSelector selector3 = new X509CertStoreSelector();
			selector3.Certificate = cert;
			parameters.SetTargetConstraints(selector3);
			PkixCertPathBuilder builder = new PkixCertPathBuilder();
			try
			{
				result = builder.Build(PkixBuilderParameters.GetInstance(parameters));
			}
			catch (PkixCertPathBuilderException cause3)
			{
				lastException = new PkixCertPathValidatorException("Certification path for public key certificate of attribute certificate could not be build.", cause3);
			}
		}
		if (lastException != null)
		{
			throw lastException;
		}
		return result.CertPath;
	}

	private static void CheckCrl(DistributionPoint dp, IX509AttributeCertificate attrCert, PkixParameters paramsPKIX, DateTime validDate, X509Certificate issuerCert, CertStatus certStatus, ReasonsMask reasonMask, IList certPathCerts)
	{
		if (attrCert.GetExtensionValue(X509Extensions.NoRevAvail) != null)
		{
			return;
		}
		DateTime currentDate = DateTime.UtcNow;
		if (validDate.CompareTo(currentDate) > 0)
		{
			throw new Exception("Validation time is in future.");
		}
		ISet completeCrls = PkixCertPathValidatorUtilities.GetCompleteCrls(dp, attrCert, currentDate, paramsPKIX);
		bool validCrlFound = false;
		Exception lastException = null;
		IEnumerator crl_iter = completeCrls.GetEnumerator();
		while (crl_iter.MoveNext() && certStatus.Status == 11 && !reasonMask.IsAllReasons)
		{
			try
			{
				X509Crl crl = (X509Crl)crl_iter.Current;
				ReasonsMask interimReasonsMask = Rfc3280CertPathUtilities.ProcessCrlD(crl, dp);
				if (interimReasonsMask.HasNewReasons(reasonMask))
				{
					ISet keys = Rfc3280CertPathUtilities.ProcessCrlF(crl, attrCert, null, null, paramsPKIX, certPathCerts);
					AsymmetricKeyParameter pubKey = Rfc3280CertPathUtilities.ProcessCrlG(crl, keys);
					X509Crl deltaCRL = null;
					if (paramsPKIX.IsUseDeltasEnabled)
					{
						deltaCRL = Rfc3280CertPathUtilities.ProcessCrlH(PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl), pubKey);
					}
					if (paramsPKIX.ValidityModel != 1 && attrCert.NotAfter.CompareTo(crl.ThisUpdate) < 0)
					{
						throw new Exception("No valid CRL for current time found.");
					}
					Rfc3280CertPathUtilities.ProcessCrlB1(dp, attrCert, crl);
					Rfc3280CertPathUtilities.ProcessCrlB2(dp, attrCert, crl);
					Rfc3280CertPathUtilities.ProcessCrlC(deltaCRL, crl, paramsPKIX);
					Rfc3280CertPathUtilities.ProcessCrlI(validDate, deltaCRL, attrCert, certStatus, paramsPKIX);
					Rfc3280CertPathUtilities.ProcessCrlJ(validDate, crl, attrCert, certStatus);
					if (certStatus.Status == 8)
					{
						certStatus.Status = 11;
					}
					reasonMask.AddReasons(interimReasonsMask);
					validCrlFound = true;
				}
			}
			catch (Exception ex)
			{
				lastException = ex;
			}
		}
		if (validCrlFound)
		{
			return;
		}
		throw lastException;
	}
}
