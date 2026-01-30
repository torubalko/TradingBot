using System;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixAttrCertPathValidator
{
	public virtual PkixCertPathValidatorResult Validate(PkixCertPath certPath, PkixParameters pkixParams)
	{
		IX509Selector targetConstraints = pkixParams.GetTargetConstraints();
		if (!(targetConstraints is X509AttrCertStoreSelector))
		{
			throw new ArgumentException("TargetConstraints must be an instance of " + typeof(X509AttrCertStoreSelector).FullName, "pkixParams");
		}
		IX509AttributeCertificate attrCert = ((X509AttrCertStoreSelector)targetConstraints).AttributeCert;
		PkixCertPath holderCertPath = Rfc3281CertPathUtilities.ProcessAttrCert1(attrCert, pkixParams);
		PkixCertPathValidatorResult result = Rfc3281CertPathUtilities.ProcessAttrCert2(certPath, pkixParams);
		X509Certificate issuerCert = (X509Certificate)certPath.Certificates[0];
		Rfc3281CertPathUtilities.ProcessAttrCert3(issuerCert, pkixParams);
		Rfc3281CertPathUtilities.ProcessAttrCert4(issuerCert, pkixParams);
		Rfc3281CertPathUtilities.ProcessAttrCert5(attrCert, pkixParams);
		Rfc3281CertPathUtilities.ProcessAttrCert7(attrCert, certPath, holderCertPath, pkixParams);
		Rfc3281CertPathUtilities.AdditionalChecks(attrCert, pkixParams);
		DateTime date;
		try
		{
			date = PkixCertPathValidatorUtilities.GetValidCertDateFromValidityModel(pkixParams, null, -1);
		}
		catch (Exception cause)
		{
			throw new PkixCertPathValidatorException("Could not get validity date from attribute certificate.", cause);
		}
		Rfc3281CertPathUtilities.CheckCrls(attrCert, pkixParams, issuerCert, date, certPath.Certificates);
		return result;
	}
}
