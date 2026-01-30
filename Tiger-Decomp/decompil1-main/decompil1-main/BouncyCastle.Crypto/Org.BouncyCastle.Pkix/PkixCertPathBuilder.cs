using System;
using System.Collections;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixCertPathBuilder
{
	private Exception certPathException;

	public virtual PkixCertPathBuilderResult Build(PkixBuilderParameters pkixParams)
	{
		IX509Selector certSelect = pkixParams.GetTargetCertConstraints();
		if (!(certSelect is X509CertStoreSelector))
		{
			throw new PkixCertPathBuilderException("TargetConstraints must be an instance of " + typeof(X509CertStoreSelector).FullName + " for " + Platform.GetTypeName(this) + " class.");
		}
		ISet targets = new HashSet();
		try
		{
			targets.AddAll(PkixCertPathValidatorUtilities.FindCertificates((X509CertStoreSelector)certSelect, pkixParams.GetStores()));
		}
		catch (Exception exception)
		{
			throw new PkixCertPathBuilderException("Error finding target certificate.", exception);
		}
		if (targets.IsEmpty)
		{
			throw new PkixCertPathBuilderException("No certificate found matching targetConstraints.");
		}
		PkixCertPathBuilderResult result = null;
		IList certPathList = Platform.CreateArrayList();
		foreach (X509Certificate cert in targets)
		{
			result = Build(cert, pkixParams, certPathList);
			if (result != null)
			{
				break;
			}
		}
		if (result == null && certPathException != null)
		{
			throw new PkixCertPathBuilderException(certPathException.Message, certPathException.InnerException);
		}
		if (result == null && certPathException == null)
		{
			throw new PkixCertPathBuilderException("Unable to find certificate chain.");
		}
		return result;
	}

	protected virtual PkixCertPathBuilderResult Build(X509Certificate tbvCert, PkixBuilderParameters pkixParams, IList tbvPath)
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
		PkixCertPathValidator validator = new PkixCertPathValidator();
		try
		{
			if (PkixCertPathValidatorUtilities.IsIssuerTrustAnchor(tbvCert, pkixParams.GetTrustAnchors()))
			{
				PkixCertPath certPath = null;
				try
				{
					certPath = new PkixCertPath(tbvPath);
				}
				catch (Exception innerException)
				{
					throw new Exception("Certification path could not be constructed from certificate list.", innerException);
				}
				PkixCertPathValidatorResult result = null;
				try
				{
					result = validator.Validate(certPath, pkixParams);
				}
				catch (Exception innerException2)
				{
					throw new Exception("Certification path could not be validated.", innerException2);
				}
				return new PkixCertPathBuilderResult(certPath, result.TrustAnchor, result.PolicyTree, result.SubjectPublicKey);
			}
			try
			{
				PkixCertPathValidatorUtilities.AddAdditionalStoresFromAltNames(tbvCert, pkixParams);
			}
			catch (CertificateParsingException innerException3)
			{
				throw new Exception("No additiontal X.509 stores can be added from certificate locations.", innerException3);
			}
			HashSet issuers = new HashSet();
			try
			{
				issuers.AddAll(PkixCertPathValidatorUtilities.FindIssuerCerts(tbvCert, pkixParams));
			}
			catch (Exception innerException4)
			{
				throw new Exception("Cannot find issuer certificate for certificate in certification path.", innerException4);
			}
			if (issuers.IsEmpty)
			{
				throw new Exception("No issuer certificate for certificate in certification path found.");
			}
			foreach (X509Certificate issuer in issuers)
			{
				builderResult = Build(issuer, pkixParams, tbvPath);
				if (builderResult != null)
				{
					break;
				}
			}
		}
		catch (Exception ex)
		{
			certPathException = ex;
		}
		if (builderResult == null)
		{
			tbvPath.Remove(tbvCert);
		}
		return builderResult;
	}
}
