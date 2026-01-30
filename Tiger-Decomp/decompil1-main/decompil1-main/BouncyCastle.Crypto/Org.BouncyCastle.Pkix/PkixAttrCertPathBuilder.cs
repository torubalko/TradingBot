using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixAttrCertPathBuilder
{
	private Exception certPathException;

	public virtual PkixCertPathBuilderResult Build(PkixBuilderParameters pkixParams)
	{
		IX509Selector certSelect = pkixParams.GetTargetConstraints();
		if (!(certSelect is X509AttrCertStoreSelector))
		{
			throw new PkixCertPathBuilderException("TargetConstraints must be an instance of " + typeof(X509AttrCertStoreSelector).FullName + " for " + typeof(PkixAttrCertPathBuilder).FullName + " class.");
		}
		ICollection targets;
		try
		{
			targets = PkixCertPathValidatorUtilities.FindCertificates((X509AttrCertStoreSelector)certSelect, pkixParams.GetStores());
		}
		catch (Exception exception)
		{
			throw new PkixCertPathBuilderException("Error finding target attribute certificate.", exception);
		}
		if (targets.Count == 0)
		{
			throw new PkixCertPathBuilderException("No attribute certificate found matching targetConstraints.");
		}
		PkixCertPathBuilderResult result = null;
		foreach (IX509AttributeCertificate cert in targets)
		{
			X509CertStoreSelector selector = new X509CertStoreSelector();
			X509Name[] principals = cert.Issuer.GetPrincipals();
			ISet issuers = new HashSet();
			for (int i = 0; i < principals.Length; i++)
			{
				try
				{
					selector.Subject = principals[i];
					issuers.AddAll(PkixCertPathValidatorUtilities.FindCertificates(selector, pkixParams.GetStores()));
				}
				catch (Exception exception2)
				{
					throw new PkixCertPathBuilderException("Public key certificate for attribute certificate cannot be searched.", exception2);
				}
			}
			if (issuers.IsEmpty)
			{
				throw new PkixCertPathBuilderException("Public key certificate for attribute certificate cannot be found.");
			}
			IList certPathList = Platform.CreateArrayList();
			foreach (X509Certificate issuer in issuers)
			{
				result = Build(cert, issuer, pkixParams, certPathList);
				if (result != null)
				{
					break;
				}
			}
			if (result != null)
			{
				break;
			}
		}
		if (result == null && certPathException != null)
		{
			throw new PkixCertPathBuilderException("Possible certificate chain could not be validated.", certPathException);
		}
		if (result == null && certPathException == null)
		{
			throw new PkixCertPathBuilderException("Unable to find certificate chain.");
		}
		return result;
	}

	private PkixCertPathBuilderResult Build(IX509AttributeCertificate attrCert, X509Certificate tbvCert, PkixBuilderParameters pkixParams, IList tbvPath)
	{
		if (tbvPath.Contains(tbvCert))
		{
			return null;
		}
		if (pkixParams.GetExcludedCerts().Contains(tbvCert))
		{
			return null;
		}
		if (pkixParams.MaxPathLength != -1 && tbvPath.Count - 1 > pkixParams.MaxPathLength)
		{
			return null;
		}
		tbvPath.Add(tbvCert);
		PkixCertPathBuilderResult builderResult = null;
		PkixAttrCertPathValidator validator = new PkixAttrCertPathValidator();
		try
		{
			if (PkixCertPathValidatorUtilities.IsIssuerTrustAnchor(tbvCert, pkixParams.GetTrustAnchors()))
			{
				PkixCertPath certPath = new PkixCertPath(tbvPath);
				PkixCertPathValidatorResult result;
				try
				{
					result = validator.Validate(certPath, pkixParams);
				}
				catch (Exception innerException)
				{
					throw new Exception("Certification path could not be validated.", innerException);
				}
				return new PkixCertPathBuilderResult(certPath, result.TrustAnchor, result.PolicyTree, result.SubjectPublicKey);
			}
			try
			{
				PkixCertPathValidatorUtilities.AddAdditionalStoresFromAltNames(tbvCert, pkixParams);
			}
			catch (CertificateParsingException innerException2)
			{
				throw new Exception("No additional X.509 stores can be added from certificate locations.", innerException2);
			}
			ISet issuers = new HashSet();
			try
			{
				issuers.AddAll(PkixCertPathValidatorUtilities.FindIssuerCerts(tbvCert, pkixParams));
			}
			catch (Exception innerException3)
			{
				throw new Exception("Cannot find issuer certificate for certificate in certification path.", innerException3);
			}
			if (issuers.IsEmpty)
			{
				throw new Exception("No issuer certificate for certificate in certification path found.");
			}
			foreach (X509Certificate issuer in issuers)
			{
				if (!PkixCertPathValidatorUtilities.IsSelfIssued(issuer))
				{
					builderResult = Build(attrCert, issuer, pkixParams, tbvPath);
					if (builderResult != null)
					{
						break;
					}
				}
			}
		}
		catch (Exception innerException4)
		{
			certPathException = new Exception("No valid certification path could be build.", innerException4);
		}
		if (builderResult == null)
		{
			tbvPath.Remove(tbvCert);
		}
		return builderResult;
	}
}
