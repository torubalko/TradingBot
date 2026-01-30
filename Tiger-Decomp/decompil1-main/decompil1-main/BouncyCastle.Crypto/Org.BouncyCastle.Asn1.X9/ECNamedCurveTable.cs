using System.Collections;
using Org.BouncyCastle.Asn1.Anssi;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.X9;

public class ECNamedCurveTable
{
	public static IEnumerable Names
	{
		get
		{
			IList list = Platform.CreateArrayList();
			CollectionUtilities.AddRange(list, X962NamedCurves.Names);
			CollectionUtilities.AddRange(list, SecNamedCurves.Names);
			CollectionUtilities.AddRange(list, NistNamedCurves.Names);
			CollectionUtilities.AddRange(list, TeleTrusTNamedCurves.Names);
			CollectionUtilities.AddRange(list, AnssiNamedCurves.Names);
			CollectionUtilities.AddRange(list, ECGost3410NamedCurves.Names);
			CollectionUtilities.AddRange(list, GMNamedCurves.Names);
			return list;
		}
	}

	public static X9ECParameters GetByName(string name)
	{
		X9ECParameters ecP = X962NamedCurves.GetByName(name);
		if (ecP == null)
		{
			ecP = SecNamedCurves.GetByName(name);
		}
		if (ecP == null)
		{
			ecP = NistNamedCurves.GetByName(name);
		}
		if (ecP == null)
		{
			ecP = TeleTrusTNamedCurves.GetByName(name);
		}
		if (ecP == null)
		{
			ecP = AnssiNamedCurves.GetByName(name);
		}
		if (ecP == null)
		{
			ecP = ECGost3410NamedCurves.GetByNameX9(name);
		}
		if (ecP == null)
		{
			ecP = GMNamedCurves.GetByName(name);
		}
		return ecP;
	}

	public static string GetName(DerObjectIdentifier oid)
	{
		string name = X962NamedCurves.GetName(oid);
		if (name == null)
		{
			name = SecNamedCurves.GetName(oid);
		}
		if (name == null)
		{
			name = NistNamedCurves.GetName(oid);
		}
		if (name == null)
		{
			name = TeleTrusTNamedCurves.GetName(oid);
		}
		if (name == null)
		{
			name = AnssiNamedCurves.GetName(oid);
		}
		if (name == null)
		{
			name = ECGost3410NamedCurves.GetName(oid);
		}
		if (name == null)
		{
			name = GMNamedCurves.GetName(oid);
		}
		return name;
	}

	public static DerObjectIdentifier GetOid(string name)
	{
		DerObjectIdentifier oid = X962NamedCurves.GetOid(name);
		if (oid == null)
		{
			oid = SecNamedCurves.GetOid(name);
		}
		if (oid == null)
		{
			oid = NistNamedCurves.GetOid(name);
		}
		if (oid == null)
		{
			oid = TeleTrusTNamedCurves.GetOid(name);
		}
		if (oid == null)
		{
			oid = AnssiNamedCurves.GetOid(name);
		}
		if (oid == null)
		{
			oid = ECGost3410NamedCurves.GetOid(name);
		}
		if (oid == null)
		{
			oid = GMNamedCurves.GetOid(name);
		}
		return oid;
	}

	public static X9ECParameters GetByOid(DerObjectIdentifier oid)
	{
		X9ECParameters ecP = X962NamedCurves.GetByOid(oid);
		if (ecP == null)
		{
			ecP = SecNamedCurves.GetByOid(oid);
		}
		if (ecP == null)
		{
			ecP = TeleTrusTNamedCurves.GetByOid(oid);
		}
		if (ecP == null)
		{
			ecP = AnssiNamedCurves.GetByOid(oid);
		}
		if (ecP == null)
		{
			ecP = ECGost3410NamedCurves.GetByOidX9(oid);
		}
		if (ecP == null)
		{
			ecP = GMNamedCurves.GetByOid(oid);
		}
		return ecP;
	}
}
