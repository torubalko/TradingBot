using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509.Store;

public class X509AttrCertStoreSelector : IX509Selector, ICloneable
{
	private IX509AttributeCertificate attributeCert;

	private DateTimeObject attributeCertificateValid;

	private AttributeCertificateHolder holder;

	private AttributeCertificateIssuer issuer;

	private BigInteger serialNumber;

	private ISet targetNames = new HashSet();

	private ISet targetGroups = new HashSet();

	public IX509AttributeCertificate AttributeCert
	{
		get
		{
			return attributeCert;
		}
		set
		{
			attributeCert = value;
		}
	}

	[Obsolete("Use AttributeCertificateValid instead")]
	public DateTimeObject AttribueCertificateValid
	{
		get
		{
			return attributeCertificateValid;
		}
		set
		{
			attributeCertificateValid = value;
		}
	}

	public DateTimeObject AttributeCertificateValid
	{
		get
		{
			return attributeCertificateValid;
		}
		set
		{
			attributeCertificateValid = value;
		}
	}

	public AttributeCertificateHolder Holder
	{
		get
		{
			return holder;
		}
		set
		{
			holder = value;
		}
	}

	public AttributeCertificateIssuer Issuer
	{
		get
		{
			return issuer;
		}
		set
		{
			issuer = value;
		}
	}

	public BigInteger SerialNumber
	{
		get
		{
			return serialNumber;
		}
		set
		{
			serialNumber = value;
		}
	}

	public X509AttrCertStoreSelector()
	{
	}

	private X509AttrCertStoreSelector(X509AttrCertStoreSelector o)
	{
		attributeCert = o.attributeCert;
		attributeCertificateValid = o.attributeCertificateValid;
		holder = o.holder;
		issuer = o.issuer;
		serialNumber = o.serialNumber;
		targetGroups = new HashSet(o.targetGroups);
		targetNames = new HashSet(o.targetNames);
	}

	public bool Match(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (!(obj is IX509AttributeCertificate attrCert))
		{
			return false;
		}
		if (attributeCert != null && !attributeCert.Equals(attrCert))
		{
			return false;
		}
		if (serialNumber != null && !attrCert.SerialNumber.Equals(serialNumber))
		{
			return false;
		}
		if (holder != null && !attrCert.Holder.Equals(holder))
		{
			return false;
		}
		if (issuer != null && !attrCert.Issuer.Equals(issuer))
		{
			return false;
		}
		if (attributeCertificateValid != null && !attrCert.IsValid(attributeCertificateValid.Value))
		{
			return false;
		}
		if (targetNames.Count > 0 || targetGroups.Count > 0)
		{
			Asn1OctetString targetInfoExt = attrCert.GetExtensionValue(X509Extensions.TargetInformation);
			if (targetInfoExt != null)
			{
				TargetInformation targetinfo;
				try
				{
					targetinfo = TargetInformation.GetInstance(X509ExtensionUtilities.FromExtensionValue(targetInfoExt));
				}
				catch (Exception)
				{
					return false;
				}
				Targets[] targetss = targetinfo.GetTargetsObjects();
				if (targetNames.Count > 0)
				{
					bool found = false;
					for (int i = 0; i < targetss.Length; i++)
					{
						if (found)
						{
							break;
						}
						Target[] targets = targetss[i].GetTargets();
						for (int j = 0; j < targets.Length; j++)
						{
							GeneralName targetName = targets[j].TargetName;
							if (targetName != null && targetNames.Contains(targetName))
							{
								found = true;
								break;
							}
						}
					}
					if (!found)
					{
						return false;
					}
				}
				if (targetGroups.Count > 0)
				{
					bool found2 = false;
					for (int k = 0; k < targetss.Length; k++)
					{
						if (found2)
						{
							break;
						}
						Target[] targets2 = targetss[k].GetTargets();
						for (int l = 0; l < targets2.Length; l++)
						{
							GeneralName targetGroup = targets2[l].TargetGroup;
							if (targetGroup != null && targetGroups.Contains(targetGroup))
							{
								found2 = true;
								break;
							}
						}
					}
					if (!found2)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	public object Clone()
	{
		return new X509AttrCertStoreSelector(this);
	}

	public void AddTargetName(GeneralName name)
	{
		targetNames.Add(name);
	}

	public void AddTargetName(byte[] name)
	{
		AddTargetName(GeneralName.GetInstance(Asn1Object.FromByteArray(name)));
	}

	public void SetTargetNames(IEnumerable names)
	{
		targetNames = ExtractGeneralNames(names);
	}

	public IEnumerable GetTargetNames()
	{
		return new EnumerableProxy(targetNames);
	}

	public void AddTargetGroup(GeneralName group)
	{
		targetGroups.Add(group);
	}

	public void AddTargetGroup(byte[] name)
	{
		AddTargetGroup(GeneralName.GetInstance(Asn1Object.FromByteArray(name)));
	}

	public void SetTargetGroups(IEnumerable names)
	{
		targetGroups = ExtractGeneralNames(names);
	}

	public IEnumerable GetTargetGroups()
	{
		return new EnumerableProxy(targetGroups);
	}

	private ISet ExtractGeneralNames(IEnumerable names)
	{
		ISet result = new HashSet();
		if (names != null)
		{
			foreach (object o in names)
			{
				if (o is GeneralName)
				{
					result.Add(o);
				}
				else
				{
					result.Add(GeneralName.GetInstance(Asn1Object.FromByteArray((byte[])o)));
				}
			}
		}
		return result;
	}
}
