using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509.Store;

public class X509CrlStoreSelector : IX509Selector, ICloneable
{
	private X509Certificate certificateChecking;

	private DateTimeObject dateAndTime;

	private ICollection issuers;

	private BigInteger maxCrlNumber;

	private BigInteger minCrlNumber;

	private IX509AttributeCertificate attrCertChecking;

	private bool completeCrlEnabled;

	private bool deltaCrlIndicatorEnabled;

	private byte[] issuingDistributionPoint;

	private bool issuingDistributionPointEnabled;

	private BigInteger maxBaseCrlNumber;

	public X509Certificate CertificateChecking
	{
		get
		{
			return certificateChecking;
		}
		set
		{
			certificateChecking = value;
		}
	}

	public DateTimeObject DateAndTime
	{
		get
		{
			return dateAndTime;
		}
		set
		{
			dateAndTime = value;
		}
	}

	public ICollection Issuers
	{
		get
		{
			return Platform.CreateArrayList(issuers);
		}
		set
		{
			issuers = Platform.CreateArrayList(value);
		}
	}

	public BigInteger MaxCrlNumber
	{
		get
		{
			return maxCrlNumber;
		}
		set
		{
			maxCrlNumber = value;
		}
	}

	public BigInteger MinCrlNumber
	{
		get
		{
			return minCrlNumber;
		}
		set
		{
			minCrlNumber = value;
		}
	}

	public IX509AttributeCertificate AttrCertChecking
	{
		get
		{
			return attrCertChecking;
		}
		set
		{
			attrCertChecking = value;
		}
	}

	public bool CompleteCrlEnabled
	{
		get
		{
			return completeCrlEnabled;
		}
		set
		{
			completeCrlEnabled = value;
		}
	}

	public bool DeltaCrlIndicatorEnabled
	{
		get
		{
			return deltaCrlIndicatorEnabled;
		}
		set
		{
			deltaCrlIndicatorEnabled = value;
		}
	}

	public byte[] IssuingDistributionPoint
	{
		get
		{
			return Arrays.Clone(issuingDistributionPoint);
		}
		set
		{
			issuingDistributionPoint = Arrays.Clone(value);
		}
	}

	public bool IssuingDistributionPointEnabled
	{
		get
		{
			return issuingDistributionPointEnabled;
		}
		set
		{
			issuingDistributionPointEnabled = value;
		}
	}

	public BigInteger MaxBaseCrlNumber
	{
		get
		{
			return maxBaseCrlNumber;
		}
		set
		{
			maxBaseCrlNumber = value;
		}
	}

	public X509CrlStoreSelector()
	{
	}

	public X509CrlStoreSelector(X509CrlStoreSelector o)
	{
		certificateChecking = o.CertificateChecking;
		dateAndTime = o.DateAndTime;
		issuers = o.Issuers;
		maxCrlNumber = o.MaxCrlNumber;
		minCrlNumber = o.MinCrlNumber;
		deltaCrlIndicatorEnabled = o.DeltaCrlIndicatorEnabled;
		completeCrlEnabled = o.CompleteCrlEnabled;
		maxBaseCrlNumber = o.MaxBaseCrlNumber;
		attrCertChecking = o.AttrCertChecking;
		issuingDistributionPointEnabled = o.IssuingDistributionPointEnabled;
		issuingDistributionPoint = o.IssuingDistributionPoint;
	}

	public virtual object Clone()
	{
		return new X509CrlStoreSelector(this);
	}

	public virtual bool Match(object obj)
	{
		if (!(obj is X509Crl c))
		{
			return false;
		}
		if (dateAndTime != null)
		{
			DateTime dt = dateAndTime.Value;
			DateTime tu = c.ThisUpdate;
			DateTimeObject nu = c.NextUpdate;
			if (dt.CompareTo(tu) < 0 || nu == null || dt.CompareTo(nu.Value) >= 0)
			{
				return false;
			}
		}
		if (issuers != null)
		{
			X509Name i = c.IssuerDN;
			bool found = false;
			foreach (X509Name issuer in issuers)
			{
				if (issuer.Equivalent(i, inOrder: true))
				{
					found = true;
					break;
				}
			}
			if (!found)
			{
				return false;
			}
		}
		if (maxCrlNumber != null || minCrlNumber != null)
		{
			Asn1OctetString extVal = c.GetExtensionValue(X509Extensions.CrlNumber);
			if (extVal == null)
			{
				return false;
			}
			BigInteger cn = DerInteger.GetInstance(X509ExtensionUtilities.FromExtensionValue(extVal)).PositiveValue;
			if (maxCrlNumber != null && cn.CompareTo(maxCrlNumber) > 0)
			{
				return false;
			}
			if (minCrlNumber != null && cn.CompareTo(minCrlNumber) < 0)
			{
				return false;
			}
		}
		DerInteger dci = null;
		try
		{
			Asn1OctetString bytes = c.GetExtensionValue(X509Extensions.DeltaCrlIndicator);
			if (bytes != null)
			{
				dci = DerInteger.GetInstance(X509ExtensionUtilities.FromExtensionValue(bytes));
			}
		}
		catch (Exception)
		{
			return false;
		}
		if (dci == null)
		{
			if (DeltaCrlIndicatorEnabled)
			{
				return false;
			}
		}
		else
		{
			if (CompleteCrlEnabled)
			{
				return false;
			}
			if (maxBaseCrlNumber != null && dci.PositiveValue.CompareTo(maxBaseCrlNumber) > 0)
			{
				return false;
			}
		}
		if (issuingDistributionPointEnabled)
		{
			Asn1OctetString idp = c.GetExtensionValue(X509Extensions.IssuingDistributionPoint);
			if (issuingDistributionPoint == null)
			{
				if (idp != null)
				{
					return false;
				}
			}
			else if (!Arrays.AreEqual(idp.GetOctets(), issuingDistributionPoint))
			{
				return false;
			}
		}
		return true;
	}
}
