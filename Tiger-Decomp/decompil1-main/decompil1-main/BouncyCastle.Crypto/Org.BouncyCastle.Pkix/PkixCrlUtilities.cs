using System;
using System.Collections;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixCrlUtilities
{
	public virtual ISet FindCrls(X509CrlStoreSelector crlselect, PkixParameters paramsPkix, DateTime currentDate)
	{
		ISet initialSet = new HashSet();
		try
		{
			initialSet.AddAll(FindCrls(crlselect, paramsPkix.GetAdditionalStores()));
			initialSet.AddAll(FindCrls(crlselect, paramsPkix.GetStores()));
		}
		catch (Exception innerException)
		{
			throw new Exception("Exception obtaining complete CRLs.", innerException);
		}
		ISet finalSet = new HashSet();
		DateTime validityDate = currentDate;
		if (paramsPkix.Date != null)
		{
			validityDate = paramsPkix.Date.Value;
		}
		foreach (X509Crl crl in initialSet)
		{
			DateTimeObject nextUpdate = crl.NextUpdate;
			if (nextUpdate == null || nextUpdate.Value.CompareTo(validityDate) > 0)
			{
				X509Certificate cert = crlselect.CertificateChecking;
				if (cert == null || crl.ThisUpdate.CompareTo(cert.NotAfter) < 0)
				{
					finalSet.Add(crl);
				}
			}
		}
		return finalSet;
	}

	public virtual ISet FindCrls(X509CrlStoreSelector crlselect, PkixParameters paramsPkix)
	{
		ISet completeSet = new HashSet();
		try
		{
			completeSet.AddAll(FindCrls(crlselect, paramsPkix.GetStores()));
			return completeSet;
		}
		catch (Exception innerException)
		{
			throw new Exception("Exception obtaining complete CRLs.", innerException);
		}
	}

	private ICollection FindCrls(X509CrlStoreSelector crlSelect, IList crlStores)
	{
		ISet crls = new HashSet();
		Exception lastException = null;
		bool foundValidStore = false;
		foreach (IX509Store store in crlStores)
		{
			try
			{
				crls.AddAll(store.GetMatches(crlSelect));
				foundValidStore = true;
			}
			catch (X509StoreException innerException)
			{
				lastException = new Exception("Exception searching in X.509 CRL store.", innerException);
			}
		}
		if (!foundValidStore && lastException != null)
		{
			throw lastException;
		}
		return crls;
	}
}
