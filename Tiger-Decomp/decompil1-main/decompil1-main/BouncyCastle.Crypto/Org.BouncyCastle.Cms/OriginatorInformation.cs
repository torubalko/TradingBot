using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms;

public class OriginatorInformation
{
	private readonly OriginatorInfo originatorInfo;

	internal OriginatorInformation(OriginatorInfo originatorInfo)
	{
		this.originatorInfo = originatorInfo;
	}

	public virtual IX509Store GetCertificates()
	{
		Asn1Set certSet = originatorInfo.Certificates;
		if (certSet != null)
		{
			IList certList = Platform.CreateArrayList(certSet.Count);
			foreach (Asn1Encodable item in certSet)
			{
				Asn1Object obj = item.ToAsn1Object();
				if (obj is Asn1Sequence)
				{
					certList.Add(new X509Certificate(X509CertificateStructure.GetInstance(obj)));
				}
			}
			return X509StoreFactory.Create("Certificate/Collection", new X509CollectionStoreParameters(certList));
		}
		return X509StoreFactory.Create("Certificate/Collection", new X509CollectionStoreParameters(Platform.CreateArrayList()));
	}

	public virtual IX509Store GetCrls()
	{
		Asn1Set crlSet = originatorInfo.Certificates;
		if (crlSet != null)
		{
			IList crlList = Platform.CreateArrayList(crlSet.Count);
			foreach (Asn1Encodable item in crlSet)
			{
				Asn1Object obj = item.ToAsn1Object();
				if (obj is Asn1Sequence)
				{
					crlList.Add(new X509Crl(CertificateList.GetInstance(obj)));
				}
			}
			return X509StoreFactory.Create("CRL/Collection", new X509CollectionStoreParameters(crlList));
		}
		return X509StoreFactory.Create("CRL/Collection", new X509CollectionStoreParameters(Platform.CreateArrayList()));
	}

	public virtual OriginatorInfo ToAsn1Structure()
	{
		return originatorInfo;
	}
}
