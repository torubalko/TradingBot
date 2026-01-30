using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Asn1.X500.Style;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Pkix;

public class PkixNameConstraintValidator
{
	private static readonly DerObjectIdentifier SerialNumberOid = new DerObjectIdentifier("2.5.4.5");

	private ISet excludedSubtreesDN = new HashSet();

	private ISet excludedSubtreesDNS = new HashSet();

	private ISet excludedSubtreesEmail = new HashSet();

	private ISet excludedSubtreesURI = new HashSet();

	private ISet excludedSubtreesIP = new HashSet();

	private ISet excludedSubtreesOtherName = new HashSet();

	private ISet permittedSubtreesDN;

	private ISet permittedSubtreesDNS;

	private ISet permittedSubtreesEmail;

	private ISet permittedSubtreesURI;

	private ISet permittedSubtreesIP;

	private ISet permittedSubtreesOtherName;

	private static bool WithinDNSubtree(Asn1Sequence dns, Asn1Sequence subtree)
	{
		if (subtree.Count < 1 || subtree.Count > dns.Count)
		{
			return false;
		}
		int start = 0;
		Rdn subtreeRdnStart = Rdn.GetInstance(subtree[0]);
		for (int j = 0; j < dns.Count; j++)
		{
			start = j;
			Rdn dnsRdn = Rdn.GetInstance(dns[j]);
			if (IetfUtilities.RdnAreEqual(subtreeRdnStart, dnsRdn))
			{
				break;
			}
		}
		if (subtree.Count > dns.Count - start)
		{
			return false;
		}
		for (int i = 0; i < subtree.Count; i++)
		{
			Rdn subtreeRdn = Rdn.GetInstance(subtree[i]);
			Rdn dnsRdn2 = Rdn.GetInstance(dns[start + i]);
			if (subtreeRdn.Count == 1 && dnsRdn2.Count == 1 && subtreeRdn.GetFirst().GetType().Equals(SerialNumberOid) && dnsRdn2.GetFirst().GetType().Equals(SerialNumberOid))
			{
				if (!Platform.StartsWith(dnsRdn2.GetFirst().Value.ToString(), subtreeRdn.GetFirst().Value.ToString()))
				{
					return false;
				}
			}
			else if (!IetfUtilities.RdnAreEqual(subtreeRdn, dnsRdn2))
			{
				return false;
			}
		}
		return true;
	}

	public void CheckPermittedDN(Asn1Sequence dn)
	{
		CheckPermittedDirectory(permittedSubtreesDN, dn);
	}

	public void CheckExcludedDN(Asn1Sequence dn)
	{
		CheckExcludedDirectory(excludedSubtreesDN, dn);
	}

	private ISet IntersectDN(ISet permitted, ISet dns)
	{
		ISet intersect = new HashSet();
		foreach (GeneralSubtree dn3 in dns)
		{
			Asn1Sequence dn1 = Asn1Sequence.GetInstance(dn3.Base.Name);
			if (permitted == null)
			{
				if (dn1 != null)
				{
					intersect.Add(dn1);
				}
				continue;
			}
			foreach (object item in permitted)
			{
				Asn1Sequence dn2 = Asn1Sequence.GetInstance(item);
				if (WithinDNSubtree(dn1, dn2))
				{
					intersect.Add(dn1);
				}
				else if (WithinDNSubtree(dn2, dn1))
				{
					intersect.Add(dn2);
				}
			}
		}
		return intersect;
	}

	private ISet UnionDN(ISet excluded, Asn1Sequence dn)
	{
		if (excluded.IsEmpty)
		{
			if (dn == null)
			{
				return excluded;
			}
			excluded.Add(dn);
			return excluded;
		}
		ISet union = new HashSet();
		foreach (object item in excluded)
		{
			Asn1Sequence subtree = Asn1Sequence.GetInstance(item);
			if (WithinDNSubtree(dn, subtree))
			{
				union.Add(subtree);
				continue;
			}
			if (WithinDNSubtree(subtree, dn))
			{
				union.Add(dn);
				continue;
			}
			union.Add(subtree);
			union.Add(dn);
		}
		return union;
	}

	private ISet IntersectOtherName(ISet permitted, ISet otherNames)
	{
		ISet intersect = new HashSet();
		foreach (GeneralSubtree otherName3 in otherNames)
		{
			OtherName otherName1 = OtherName.GetInstance(otherName3.Base.Name);
			if (otherName1 == null)
			{
				continue;
			}
			if (permitted == null)
			{
				intersect.Add(otherName1);
				continue;
			}
			foreach (object item in permitted)
			{
				OtherName otherName2 = OtherName.GetInstance(item);
				if (otherName2 != null)
				{
					IntersectOtherName(otherName1, otherName2, intersect);
				}
			}
		}
		return intersect;
	}

	private void IntersectOtherName(OtherName otherName1, OtherName otherName2, ISet intersect)
	{
		if (otherName1.Equals(otherName2))
		{
			intersect.Add(otherName1);
		}
	}

	private ISet UnionOtherName(ISet permitted, OtherName otherName)
	{
		HashSet obj = ((permitted != null) ? new HashSet(permitted) : new HashSet());
		((ISet)obj).Add((object)otherName);
		return obj;
	}

	private ISet IntersectEmail(ISet permitted, ISet emails)
	{
		ISet intersect = new HashSet();
		foreach (GeneralSubtree subtree1 in emails)
		{
			string email = ExtractNameAsString(subtree1.Base);
			if (permitted == null)
			{
				if (email != null)
				{
					intersect.Add(email);
				}
				continue;
			}
			foreach (string _permitted in permitted)
			{
				IntersectEmail(email, _permitted, intersect);
			}
		}
		return intersect;
	}

	private ISet UnionEmail(ISet excluded, string email)
	{
		if (excluded.IsEmpty)
		{
			if (email == null)
			{
				return excluded;
			}
			excluded.Add(email);
			return excluded;
		}
		ISet union = new HashSet();
		foreach (string _excluded in excluded)
		{
			UnionEmail(_excluded, email, union);
		}
		return union;
	}

	private ISet IntersectIP(ISet permitted, ISet ips)
	{
		ISet intersect = new HashSet();
		foreach (GeneralSubtree ip2 in ips)
		{
			byte[] ip = Asn1OctetString.GetInstance(ip2.Base.Name).GetOctets();
			if (permitted == null)
			{
				if (ip != null)
				{
					intersect.Add(ip);
				}
				continue;
			}
			foreach (byte[] _permitted in permitted)
			{
				intersect.AddAll(IntersectIPRange(_permitted, ip));
			}
		}
		return intersect;
	}

	private ISet UnionIP(ISet excluded, byte[] ip)
	{
		if (excluded.IsEmpty)
		{
			if (ip == null)
			{
				return excluded;
			}
			excluded.Add(ip);
			return excluded;
		}
		ISet union = new HashSet();
		foreach (byte[] _excluded in excluded)
		{
			union.AddAll(UnionIPRange(_excluded, ip));
		}
		return union;
	}

	private ISet UnionIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
	{
		ISet set = new HashSet();
		if (Arrays.AreEqual(ipWithSubmask1, ipWithSubmask2))
		{
			set.Add(ipWithSubmask1);
		}
		else
		{
			set.Add(ipWithSubmask1);
			set.Add(ipWithSubmask2);
		}
		return set;
	}

	private ISet IntersectIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
	{
		if (ipWithSubmask1.Length != ipWithSubmask2.Length)
		{
			return new HashSet();
		}
		byte[][] array = ExtractIPsAndSubnetMasks(ipWithSubmask1, ipWithSubmask2);
		byte[] ip1 = array[0];
		byte[] subnetmask1 = array[1];
		byte[] ip2 = array[2];
		byte[] subnetmask2 = array[3];
		byte[][] minMax = MinMaxIPs(ip1, subnetmask1, ip2, subnetmask2);
		byte[] max = Min(minMax[1], minMax[3]);
		if (CompareTo(Max(minMax[0], minMax[2]), max) == 1)
		{
			return new HashSet();
		}
		byte[] ip3 = Or(minMax[0], minMax[2]);
		byte[] subnetmask3 = Or(subnetmask1, subnetmask2);
		return new HashSet { (object)IpWithSubnetMask(ip3, subnetmask3) };
	}

	private byte[] IpWithSubnetMask(byte[] ip, byte[] subnetMask)
	{
		int ipLength = ip.Length;
		byte[] temp = new byte[ipLength * 2];
		Array.Copy(ip, 0, temp, 0, ipLength);
		Array.Copy(subnetMask, 0, temp, ipLength, ipLength);
		return temp;
	}

	private byte[][] ExtractIPsAndSubnetMasks(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
	{
		int ipLength = ipWithSubmask1.Length / 2;
		byte[] ip1 = new byte[ipLength];
		byte[] subnetmask1 = new byte[ipLength];
		Array.Copy(ipWithSubmask1, 0, ip1, 0, ipLength);
		Array.Copy(ipWithSubmask1, ipLength, subnetmask1, 0, ipLength);
		byte[] ip2 = new byte[ipLength];
		byte[] subnetmask2 = new byte[ipLength];
		Array.Copy(ipWithSubmask2, 0, ip2, 0, ipLength);
		Array.Copy(ipWithSubmask2, ipLength, subnetmask2, 0, ipLength);
		return new byte[4][] { ip1, subnetmask1, ip2, subnetmask2 };
	}

	private byte[][] MinMaxIPs(byte[] ip1, byte[] subnetmask1, byte[] ip2, byte[] subnetmask2)
	{
		int ipLength = ip1.Length;
		byte[] min1 = new byte[ipLength];
		byte[] max1 = new byte[ipLength];
		byte[] min2 = new byte[ipLength];
		byte[] max2 = new byte[ipLength];
		for (int i = 0; i < ipLength; i++)
		{
			min1[i] = (byte)(ip1[i] & subnetmask1[i]);
			max1[i] = (byte)((ip1[i] & subnetmask1[i]) | ~subnetmask1[i]);
			min2[i] = (byte)(ip2[i] & subnetmask2[i]);
			max2[i] = (byte)((ip2[i] & subnetmask2[i]) | ~subnetmask2[i]);
		}
		return new byte[4][] { min1, max1, min2, max2 };
	}

	private bool IsOtherNameConstrained(OtherName constraint, OtherName otherName)
	{
		return constraint.Equals(otherName);
	}

	private bool IsOtherNameConstrained(ISet constraints, OtherName otherName)
	{
		foreach (object constraint2 in constraints)
		{
			OtherName constraint = OtherName.GetInstance(constraint2);
			if (IsOtherNameConstrained(constraint, otherName))
			{
				return true;
			}
		}
		return false;
	}

	private void CheckPermittedOtherName(ISet permitted, OtherName name)
	{
		if (permitted != null && !IsOtherNameConstrained(permitted, name))
		{
			throw new PkixNameConstraintValidatorException("Subject OtherName is not from a permitted subtree.");
		}
	}

	private void CheckExcludedOtherName(ISet excluded, OtherName name)
	{
		if (IsOtherNameConstrained(excluded, name))
		{
			throw new PkixNameConstraintValidatorException("OtherName is from an excluded subtree.");
		}
	}

	private bool IsEmailConstrained(string constraint, string email)
	{
		string sub = email.Substring(email.IndexOf('@') + 1);
		if (constraint.IndexOf('@') != -1)
		{
			if (Platform.ToUpperInvariant(email).Equals(Platform.ToUpperInvariant(constraint)))
			{
				return true;
			}
		}
		else if (!constraint[0].Equals('.'))
		{
			if (Platform.ToUpperInvariant(sub).Equals(Platform.ToUpperInvariant(constraint)))
			{
				return true;
			}
		}
		else if (WithinDomain(sub, constraint))
		{
			return true;
		}
		return false;
	}

	private bool IsEmailConstrained(ISet constraints, string email)
	{
		foreach (string constraint in constraints)
		{
			if (IsEmailConstrained(constraint, email))
			{
				return true;
			}
		}
		return false;
	}

	private void CheckPermittedEmail(ISet permitted, string email)
	{
		if (permitted != null && (email.Length != 0 || !permitted.IsEmpty) && !IsEmailConstrained(permitted, email))
		{
			throw new PkixNameConstraintValidatorException("Subject email address is not from a permitted subtree.");
		}
	}

	private void CheckExcludedEmail(ISet excluded, string email)
	{
		if (IsEmailConstrained(excluded, email))
		{
			throw new PkixNameConstraintValidatorException("Email address is from an excluded subtree.");
		}
	}

	private bool IsDnsConstrained(string constraint, string dns)
	{
		if (!WithinDomain(dns, constraint))
		{
			return Platform.EqualsIgnoreCase(dns, constraint);
		}
		return true;
	}

	private bool IsDnsConstrained(ISet constraints, string dns)
	{
		foreach (string constraint in constraints)
		{
			if (IsDnsConstrained(constraint, dns))
			{
				return true;
			}
		}
		return false;
	}

	private void CheckPermittedDns(ISet permitted, string dns)
	{
		if (permitted != null && (dns.Length != 0 || !permitted.IsEmpty) && !IsDnsConstrained(permitted, dns))
		{
			throw new PkixNameConstraintValidatorException("DNS is not from a permitted subtree.");
		}
	}

	private void CheckExcludedDns(ISet excluded, string dns)
	{
		if (IsDnsConstrained(excluded, dns))
		{
			throw new PkixNameConstraintValidatorException("DNS is from an excluded subtree.");
		}
	}

	private bool IsDirectoryConstrained(ISet constraints, Asn1Sequence directory)
	{
		foreach (object constraint2 in constraints)
		{
			Asn1Sequence constraint = Asn1Sequence.GetInstance(constraint2);
			if (WithinDNSubtree(directory, constraint))
			{
				return true;
			}
		}
		return false;
	}

	private void CheckPermittedDirectory(ISet permitted, Asn1Sequence directory)
	{
		if (permitted != null && (directory.Count != 0 || !permitted.IsEmpty) && !IsDirectoryConstrained(permitted, directory))
		{
			throw new PkixNameConstraintValidatorException("Subject distinguished name is not from a permitted subtree");
		}
	}

	private void CheckExcludedDirectory(ISet excluded, Asn1Sequence directory)
	{
		if (IsDirectoryConstrained(excluded, directory))
		{
			throw new PkixNameConstraintValidatorException("Subject distinguished name is from an excluded subtree");
		}
	}

	private bool IsUriConstrained(string constraint, string uri)
	{
		string host = ExtractHostFromURL(uri);
		if (Platform.StartsWith(constraint, "."))
		{
			return WithinDomain(host, constraint);
		}
		return Platform.EqualsIgnoreCase(host, constraint);
	}

	private bool IsUriConstrained(ISet constraints, string uri)
	{
		foreach (string constraint in constraints)
		{
			if (IsUriConstrained(constraint, uri))
			{
				return true;
			}
		}
		return false;
	}

	private void CheckPermittedUri(ISet permitted, string uri)
	{
		if (permitted != null && (uri.Length != 0 || !permitted.IsEmpty) && !IsUriConstrained(permitted, uri))
		{
			throw new PkixNameConstraintValidatorException("URI is not from a permitted subtree.");
		}
	}

	private void CheckExcludedUri(ISet excluded, string uri)
	{
		if (IsUriConstrained(excluded, uri))
		{
			throw new PkixNameConstraintValidatorException("URI is from an excluded subtree.");
		}
	}

	private bool IsIPConstrained(byte[] constraint, byte[] ip)
	{
		int ipLength = ip.Length;
		if (ipLength != constraint.Length / 2)
		{
			return false;
		}
		byte[] subnetMask = new byte[ipLength];
		Array.Copy(constraint, ipLength, subnetMask, 0, ipLength);
		byte[] permittedSubnetAddress = new byte[ipLength];
		byte[] ipSubnetAddress = new byte[ipLength];
		for (int i = 0; i < ipLength; i++)
		{
			permittedSubnetAddress[i] = (byte)(constraint[i] & subnetMask[i]);
			ipSubnetAddress[i] = (byte)(ip[i] & subnetMask[i]);
		}
		return Arrays.AreEqual(permittedSubnetAddress, ipSubnetAddress);
	}

	private bool IsIPConstrained(ISet constraints, byte[] ip)
	{
		foreach (byte[] constraint in constraints)
		{
			if (IsIPConstrained(constraint, ip))
			{
				return true;
			}
		}
		return false;
	}

	private void CheckPermittedIP(ISet permitted, byte[] ip)
	{
		if (permitted != null && (ip.Length != 0 || !permitted.IsEmpty) && !IsIPConstrained(permitted, ip))
		{
			throw new PkixNameConstraintValidatorException("IP is not from a permitted subtree.");
		}
	}

	private void CheckExcludedIP(ISet excluded, byte[] ip)
	{
		if (IsIPConstrained(excluded, ip))
		{
			throw new PkixNameConstraintValidatorException("IP is from an excluded subtree.");
		}
	}

	private bool WithinDomain(string testDomain, string domain)
	{
		string tempDomain = domain;
		if (Platform.StartsWith(tempDomain, "."))
		{
			tempDomain = tempDomain.Substring(1);
		}
		string[] domainParts = tempDomain.Split('.');
		string[] testDomainParts = testDomain.Split('.');
		if (testDomainParts.Length <= domainParts.Length)
		{
			return false;
		}
		int d = testDomainParts.Length - domainParts.Length;
		for (int i = -1; i < domainParts.Length; i++)
		{
			if (i == -1)
			{
				if (testDomainParts[i + d].Length < 1)
				{
					return false;
				}
			}
			else if (!Platform.EqualsIgnoreCase(testDomainParts[i + d], domainParts[i]))
			{
				return false;
			}
		}
		return true;
	}

	private void UnionEmail(string email1, string email2, ISet union)
	{
		if (email1.IndexOf('@') != -1)
		{
			string _sub = email1.Substring(email1.IndexOf('@') + 1);
			if (email2.IndexOf('@') != -1)
			{
				if (Platform.EqualsIgnoreCase(email1, email2))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(_sub, email2))
				{
					union.Add(email2);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (Platform.EqualsIgnoreCase(_sub, email2))
			{
				union.Add(email2);
			}
			else
			{
				union.Add(email1);
				union.Add(email2);
			}
		}
		else if (Platform.StartsWith(email1, "."))
		{
			if (email2.IndexOf('@') != -1)
			{
				string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
				if (WithinDomain(_sub2, email1))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(email1, email2) || Platform.EqualsIgnoreCase(email1, email2))
				{
					union.Add(email2);
					return;
				}
				if (WithinDomain(email2, email1))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (WithinDomain(email2, email1))
			{
				union.Add(email1);
			}
			else
			{
				union.Add(email1);
				union.Add(email2);
			}
		}
		else if (email2.IndexOf('@') != -1)
		{
			if (Platform.EqualsIgnoreCase(email2.Substring(email1.IndexOf('@') + 1), email1))
			{
				union.Add(email1);
				return;
			}
			union.Add(email1);
			union.Add(email2);
		}
		else if (Platform.StartsWith(email2, "."))
		{
			if (WithinDomain(email1, email2))
			{
				union.Add(email2);
				return;
			}
			union.Add(email1);
			union.Add(email2);
		}
		else if (Platform.EqualsIgnoreCase(email1, email2))
		{
			union.Add(email1);
		}
		else
		{
			union.Add(email1);
			union.Add(email2);
		}
	}

	private void unionURI(string email1, string email2, ISet union)
	{
		if (email1.IndexOf('@') != -1)
		{
			string _sub = email1.Substring(email1.IndexOf('@') + 1);
			if (email2.IndexOf('@') != -1)
			{
				if (Platform.EqualsIgnoreCase(email1, email2))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(_sub, email2))
				{
					union.Add(email2);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (Platform.EqualsIgnoreCase(_sub, email2))
			{
				union.Add(email2);
			}
			else
			{
				union.Add(email1);
				union.Add(email2);
			}
		}
		else if (Platform.StartsWith(email1, "."))
		{
			if (email2.IndexOf('@') != -1)
			{
				string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
				if (WithinDomain(_sub2, email1))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(email1, email2) || Platform.EqualsIgnoreCase(email1, email2))
				{
					union.Add(email2);
					return;
				}
				if (WithinDomain(email2, email1))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
			}
			else if (WithinDomain(email2, email1))
			{
				union.Add(email1);
			}
			else
			{
				union.Add(email1);
				union.Add(email2);
			}
		}
		else if (email2.IndexOf('@') != -1)
		{
			if (Platform.EqualsIgnoreCase(email2.Substring(email1.IndexOf('@') + 1), email1))
			{
				union.Add(email1);
				return;
			}
			union.Add(email1);
			union.Add(email2);
		}
		else if (Platform.StartsWith(email2, "."))
		{
			if (WithinDomain(email1, email2))
			{
				union.Add(email2);
				return;
			}
			union.Add(email1);
			union.Add(email2);
		}
		else if (Platform.EqualsIgnoreCase(email1, email2))
		{
			union.Add(email1);
		}
		else
		{
			union.Add(email1);
			union.Add(email2);
		}
	}

	private ISet IntersectDns(ISet permitted, ISet dnss)
	{
		ISet intersect = new HashSet();
		foreach (GeneralSubtree subtree in dnss)
		{
			string dns = ExtractNameAsString(subtree.Base);
			if (permitted == null)
			{
				if (dns != null)
				{
					intersect.Add(dns);
				}
				continue;
			}
			foreach (string _permitted in permitted)
			{
				if (WithinDomain(_permitted, dns))
				{
					intersect.Add(_permitted);
				}
				else if (WithinDomain(dns, _permitted))
				{
					intersect.Add(dns);
				}
			}
		}
		return intersect;
	}

	private ISet UnionDns(ISet excluded, string dns)
	{
		if (excluded.IsEmpty)
		{
			if (dns == null)
			{
				return excluded;
			}
			excluded.Add(dns);
			return excluded;
		}
		ISet union = new HashSet();
		foreach (string _excluded in excluded)
		{
			if (WithinDomain(_excluded, dns))
			{
				union.Add(dns);
				continue;
			}
			if (WithinDomain(dns, _excluded))
			{
				union.Add(_excluded);
				continue;
			}
			union.Add(_excluded);
			union.Add(dns);
		}
		return union;
	}

	private void IntersectEmail(string email1, string email2, ISet intersect)
	{
		if (email1.IndexOf('@') != -1)
		{
			string _sub = email1.Substring(email1.IndexOf('@') + 1);
			if (email2.IndexOf('@') != -1)
			{
				if (Platform.EqualsIgnoreCase(email1, email2))
				{
					intersect.Add(email1);
				}
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(_sub, email2))
				{
					intersect.Add(email1);
				}
			}
			else if (Platform.EqualsIgnoreCase(_sub, email2))
			{
				intersect.Add(email1);
			}
		}
		else if (Platform.StartsWith(email1, "."))
		{
			if (email2.IndexOf('@') != -1)
			{
				string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
				if (WithinDomain(_sub2, email1))
				{
					intersect.Add(email2);
				}
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(email1, email2) || Platform.EqualsIgnoreCase(email1, email2))
				{
					intersect.Add(email1);
				}
				else if (WithinDomain(email2, email1))
				{
					intersect.Add(email2);
				}
			}
			else if (WithinDomain(email2, email1))
			{
				intersect.Add(email2);
			}
		}
		else if (email2.IndexOf('@') != -1)
		{
			if (Platform.EqualsIgnoreCase(email2.Substring(email2.IndexOf('@') + 1), email1))
			{
				intersect.Add(email2);
			}
		}
		else if (Platform.StartsWith(email2, "."))
		{
			if (WithinDomain(email1, email2))
			{
				intersect.Add(email1);
			}
		}
		else if (Platform.EqualsIgnoreCase(email1, email2))
		{
			intersect.Add(email1);
		}
	}

	private ISet IntersectUri(ISet permitted, ISet uris)
	{
		ISet intersect = new HashSet();
		foreach (GeneralSubtree subtree in uris)
		{
			string uri = ExtractNameAsString(subtree.Base);
			if (permitted == null)
			{
				if (uri != null)
				{
					intersect.Add(uri);
				}
				continue;
			}
			foreach (string _permitted in permitted)
			{
				IntersectUri(_permitted, uri, intersect);
			}
		}
		return intersect;
	}

	private ISet UnionUri(ISet excluded, string uri)
	{
		if (excluded.IsEmpty)
		{
			if (uri == null)
			{
				return excluded;
			}
			excluded.Add(uri);
			return excluded;
		}
		ISet union = new HashSet();
		foreach (string _excluded in excluded)
		{
			unionURI(_excluded, uri, union);
		}
		return union;
	}

	private void IntersectUri(string email1, string email2, ISet intersect)
	{
		if (email1.IndexOf('@') != -1)
		{
			string _sub = email1.Substring(email1.IndexOf('@') + 1);
			if (email2.IndexOf('@') != -1)
			{
				if (Platform.EqualsIgnoreCase(email1, email2))
				{
					intersect.Add(email1);
				}
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(_sub, email2))
				{
					intersect.Add(email1);
				}
			}
			else if (Platform.EqualsIgnoreCase(_sub, email2))
			{
				intersect.Add(email1);
			}
		}
		else if (Platform.StartsWith(email1, "."))
		{
			if (email2.IndexOf('@') != -1)
			{
				string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
				if (WithinDomain(_sub2, email1))
				{
					intersect.Add(email2);
				}
			}
			else if (Platform.StartsWith(email2, "."))
			{
				if (WithinDomain(email1, email2) || Platform.EqualsIgnoreCase(email1, email2))
				{
					intersect.Add(email1);
				}
				else if (WithinDomain(email2, email1))
				{
					intersect.Add(email2);
				}
			}
			else if (WithinDomain(email2, email1))
			{
				intersect.Add(email2);
			}
		}
		else if (email2.IndexOf('@') != -1)
		{
			if (Platform.EqualsIgnoreCase(email2.Substring(email2.IndexOf('@') + 1), email1))
			{
				intersect.Add(email2);
			}
		}
		else if (Platform.StartsWith(email2, "."))
		{
			if (WithinDomain(email1, email2))
			{
				intersect.Add(email1);
			}
		}
		else if (Platform.EqualsIgnoreCase(email1, email2))
		{
			intersect.Add(email1);
		}
	}

	private static string ExtractHostFromURL(string url)
	{
		string sub = url.Substring(url.IndexOf(':') + 1);
		int idxOfSlashes = Platform.IndexOf(sub, "//");
		if (idxOfSlashes != -1)
		{
			sub = sub.Substring(idxOfSlashes + 2);
		}
		if (sub.LastIndexOf(':') != -1)
		{
			sub = sub.Substring(0, sub.LastIndexOf(':'));
		}
		sub = sub.Substring(sub.IndexOf(':') + 1);
		sub = sub.Substring(sub.IndexOf('@') + 1);
		if (sub.IndexOf('/') != -1)
		{
			sub = sub.Substring(0, sub.IndexOf('/'));
		}
		return sub;
	}

	public void checkPermitted(GeneralName name)
	{
		switch (name.TagNo)
		{
		case 0:
			CheckPermittedOtherName(permittedSubtreesOtherName, OtherName.GetInstance(name.Name));
			break;
		case 1:
			CheckPermittedEmail(permittedSubtreesEmail, ExtractNameAsString(name));
			break;
		case 2:
			CheckPermittedDns(permittedSubtreesDNS, ExtractNameAsString(name));
			break;
		case 4:
			CheckPermittedDN(Asn1Sequence.GetInstance(name.Name.ToAsn1Object()));
			break;
		case 6:
			CheckPermittedUri(permittedSubtreesURI, ExtractNameAsString(name));
			break;
		case 7:
			CheckPermittedIP(permittedSubtreesIP, Asn1OctetString.GetInstance(name.Name).GetOctets());
			break;
		case 3:
		case 5:
			break;
		}
	}

	public void checkExcluded(GeneralName name)
	{
		switch (name.TagNo)
		{
		case 0:
			CheckExcludedOtherName(excludedSubtreesOtherName, OtherName.GetInstance(name.Name));
			break;
		case 1:
			CheckExcludedEmail(excludedSubtreesEmail, ExtractNameAsString(name));
			break;
		case 2:
			CheckExcludedDns(excludedSubtreesDNS, ExtractNameAsString(name));
			break;
		case 4:
			CheckExcludedDN(Asn1Sequence.GetInstance(name.Name.ToAsn1Object()));
			break;
		case 6:
			CheckExcludedUri(excludedSubtreesURI, ExtractNameAsString(name));
			break;
		case 7:
			CheckExcludedIP(excludedSubtreesIP, Asn1OctetString.GetInstance(name.Name).GetOctets());
			break;
		case 3:
		case 5:
			break;
		}
	}

	public void IntersectPermittedSubtree(Asn1Sequence permitted)
	{
		IDictionary subtreesMap = Platform.CreateHashtable();
		foreach (object item in permitted)
		{
			GeneralSubtree subtree = GeneralSubtree.GetInstance(item);
			int tagNo = subtree.Base.TagNo;
			if (subtreesMap[tagNo] == null)
			{
				subtreesMap[tagNo] = new HashSet();
			}
			((ISet)subtreesMap[tagNo]).Add(subtree);
		}
		foreach (DictionaryEntry entry in subtreesMap)
		{
			switch ((int)entry.Key)
			{
			case 0:
				permittedSubtreesOtherName = IntersectOtherName(permittedSubtreesOtherName, (ISet)entry.Value);
				break;
			case 1:
				permittedSubtreesEmail = IntersectEmail(permittedSubtreesEmail, (ISet)entry.Value);
				break;
			case 2:
				permittedSubtreesDNS = IntersectDns(permittedSubtreesDNS, (ISet)entry.Value);
				break;
			case 4:
				permittedSubtreesDN = IntersectDN(permittedSubtreesDN, (ISet)entry.Value);
				break;
			case 6:
				permittedSubtreesURI = IntersectUri(permittedSubtreesURI, (ISet)entry.Value);
				break;
			case 7:
				permittedSubtreesIP = IntersectIP(permittedSubtreesIP, (ISet)entry.Value);
				break;
			}
		}
	}

	private string ExtractNameAsString(GeneralName name)
	{
		return DerIA5String.GetInstance(name.Name).GetString();
	}

	public void IntersectEmptyPermittedSubtree(int nameType)
	{
		switch (nameType)
		{
		case 0:
			permittedSubtreesOtherName = new HashSet();
			break;
		case 1:
			permittedSubtreesEmail = new HashSet();
			break;
		case 2:
			permittedSubtreesDNS = new HashSet();
			break;
		case 4:
			permittedSubtreesDN = new HashSet();
			break;
		case 6:
			permittedSubtreesURI = new HashSet();
			break;
		case 7:
			permittedSubtreesIP = new HashSet();
			break;
		case 3:
		case 5:
			break;
		}
	}

	public void AddExcludedSubtree(GeneralSubtree subtree)
	{
		GeneralName subTreeBase = subtree.Base;
		switch (subTreeBase.TagNo)
		{
		case 0:
			excludedSubtreesOtherName = UnionOtherName(excludedSubtreesOtherName, OtherName.GetInstance(subTreeBase.Name));
			break;
		case 1:
			excludedSubtreesEmail = UnionEmail(excludedSubtreesEmail, ExtractNameAsString(subTreeBase));
			break;
		case 2:
			excludedSubtreesDNS = UnionDns(excludedSubtreesDNS, ExtractNameAsString(subTreeBase));
			break;
		case 4:
			excludedSubtreesDN = UnionDN(excludedSubtreesDN, (Asn1Sequence)subTreeBase.Name.ToAsn1Object());
			break;
		case 6:
			excludedSubtreesURI = UnionUri(excludedSubtreesURI, ExtractNameAsString(subTreeBase));
			break;
		case 7:
			excludedSubtreesIP = UnionIP(excludedSubtreesIP, Asn1OctetString.GetInstance(subTreeBase.Name).GetOctets());
			break;
		case 3:
		case 5:
			break;
		}
	}

	private static byte[] Max(byte[] ip1, byte[] ip2)
	{
		for (int i = 0; i < ip1.Length; i++)
		{
			if ((ip1[i] & 0xFFFF) > (ip2[i] & 0xFFFF))
			{
				return ip1;
			}
		}
		return ip2;
	}

	private static byte[] Min(byte[] ip1, byte[] ip2)
	{
		for (int i = 0; i < ip1.Length; i++)
		{
			if ((ip1[i] & 0xFFFF) < (ip2[i] & 0xFFFF))
			{
				return ip1;
			}
		}
		return ip2;
	}

	private static int CompareTo(byte[] ip1, byte[] ip2)
	{
		if (Arrays.AreEqual(ip1, ip2))
		{
			return 0;
		}
		if (Arrays.AreEqual(Max(ip1, ip2), ip1))
		{
			return 1;
		}
		return -1;
	}

	private static byte[] Or(byte[] ip1, byte[] ip2)
	{
		byte[] temp = new byte[ip1.Length];
		for (int i = 0; i < ip1.Length; i++)
		{
			temp[i] = (byte)(ip1[i] | ip2[i]);
		}
		return temp;
	}

	[Obsolete("Use GetHashCode instead")]
	public int HashCode()
	{
		return GetHashCode();
	}

	public override int GetHashCode()
	{
		return HashCollection(excludedSubtreesDN) + HashCollection(excludedSubtreesDNS) + HashCollection(excludedSubtreesEmail) + HashCollection(excludedSubtreesIP) + HashCollection(excludedSubtreesURI) + HashCollection(excludedSubtreesOtherName) + HashCollection(permittedSubtreesDN) + HashCollection(permittedSubtreesDNS) + HashCollection(permittedSubtreesEmail) + HashCollection(permittedSubtreesIP) + HashCollection(permittedSubtreesURI) + HashCollection(permittedSubtreesOtherName);
	}

	private int HashCollection(ICollection c)
	{
		if (c == null)
		{
			return 0;
		}
		int hash = 0;
		foreach (object o in c)
		{
			hash = ((!(o is byte[])) ? (hash + o.GetHashCode()) : (hash + Arrays.GetHashCode((byte[])o)));
		}
		return hash;
	}

	public override bool Equals(object o)
	{
		if (!(o is PkixNameConstraintValidator))
		{
			return false;
		}
		PkixNameConstraintValidator constraintValidator = (PkixNameConstraintValidator)o;
		if (CollectionsAreEqual(constraintValidator.excludedSubtreesDN, excludedSubtreesDN) && CollectionsAreEqual(constraintValidator.excludedSubtreesDNS, excludedSubtreesDNS) && CollectionsAreEqual(constraintValidator.excludedSubtreesEmail, excludedSubtreesEmail) && CollectionsAreEqual(constraintValidator.excludedSubtreesIP, excludedSubtreesIP) && CollectionsAreEqual(constraintValidator.excludedSubtreesURI, excludedSubtreesURI) && CollectionsAreEqual(constraintValidator.excludedSubtreesOtherName, excludedSubtreesOtherName) && CollectionsAreEqual(constraintValidator.permittedSubtreesDN, permittedSubtreesDN) && CollectionsAreEqual(constraintValidator.permittedSubtreesDNS, permittedSubtreesDNS) && CollectionsAreEqual(constraintValidator.permittedSubtreesEmail, permittedSubtreesEmail) && CollectionsAreEqual(constraintValidator.permittedSubtreesIP, permittedSubtreesIP) && CollectionsAreEqual(constraintValidator.permittedSubtreesURI, permittedSubtreesURI))
		{
			return CollectionsAreEqual(constraintValidator.permittedSubtreesOtherName, permittedSubtreesOtherName);
		}
		return false;
	}

	private bool CollectionsAreEqual(ICollection coll1, ICollection coll2)
	{
		if (coll1 == coll2)
		{
			return true;
		}
		if (coll1 == null || coll2 == null || coll1.Count != coll2.Count)
		{
			return false;
		}
		foreach (object a in coll1)
		{
			bool found = false;
			foreach (object b in coll2)
			{
				if (SpecialEquals(a, b))
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
		return true;
	}

	private bool SpecialEquals(object o1, object o2)
	{
		if (o1 == o2)
		{
			return true;
		}
		if (o1 == null || o2 == null)
		{
			return false;
		}
		if (o1 is byte[] && o2 is byte[])
		{
			return Arrays.AreEqual((byte[])o1, (byte[])o2);
		}
		return o1.Equals(o2);
	}

	private string StringifyIP(byte[] ip)
	{
		string temp = "";
		for (int i = 0; i < ip.Length / 2; i++)
		{
			temp = temp + (ip[i] & 0xFF) + ".";
		}
		temp = temp.Substring(0, temp.Length - 1);
		temp += "/";
		for (int j = ip.Length / 2; j < ip.Length; j++)
		{
			temp = temp + (ip[j] & 0xFF) + ".";
		}
		return temp.Substring(0, temp.Length - 1);
	}

	private string StringifyIPCollection(ISet ips)
	{
		string temp = "";
		temp += "[";
		foreach (byte[] ip in ips)
		{
			temp = temp + StringifyIP(ip) + ",";
		}
		if (temp.Length > 1)
		{
			temp = temp.Substring(0, temp.Length - 1);
		}
		return temp + "]";
	}

	private string StringifyOtherNameCollection(ISet otherNames)
	{
		string temp = "";
		temp += "[";
		foreach (object otherName in otherNames)
		{
			OtherName name = OtherName.GetInstance(otherName);
			if (temp.Length > 1)
			{
				temp += ",";
			}
			temp += name.TypeID.Id;
			temp += ":";
			try
			{
				temp += Hex.ToHexString(name.Value.ToAsn1Object().GetEncoded());
			}
			catch (IOException ex)
			{
				temp += ex.ToString();
			}
		}
		return temp + "]";
	}

	public override string ToString()
	{
		string temp = "";
		temp += "permitted:\n";
		if (permittedSubtreesDN != null)
		{
			temp += "DN:\n";
			temp = temp + permittedSubtreesDN.ToString() + "\n";
		}
		if (permittedSubtreesDNS != null)
		{
			temp += "DNS:\n";
			temp = temp + permittedSubtreesDNS.ToString() + "\n";
		}
		if (permittedSubtreesEmail != null)
		{
			temp += "Email:\n";
			temp = temp + permittedSubtreesEmail.ToString() + "\n";
		}
		if (permittedSubtreesURI != null)
		{
			temp += "URI:\n";
			temp = temp + permittedSubtreesURI.ToString() + "\n";
		}
		if (permittedSubtreesIP != null)
		{
			temp += "IP:\n";
			temp = temp + StringifyIPCollection(permittedSubtreesIP) + "\n";
		}
		if (permittedSubtreesOtherName != null)
		{
			temp += "OtherName:\n";
			temp += StringifyOtherNameCollection(permittedSubtreesOtherName);
		}
		temp += "excluded:\n";
		if (!excludedSubtreesDN.IsEmpty)
		{
			temp += "DN:\n";
			temp = temp + excludedSubtreesDN.ToString() + "\n";
		}
		if (!excludedSubtreesDNS.IsEmpty)
		{
			temp += "DNS:\n";
			temp = temp + excludedSubtreesDNS.ToString() + "\n";
		}
		if (!excludedSubtreesEmail.IsEmpty)
		{
			temp += "Email:\n";
			temp = temp + excludedSubtreesEmail.ToString() + "\n";
		}
		if (!excludedSubtreesURI.IsEmpty)
		{
			temp += "URI:\n";
			temp = temp + excludedSubtreesURI.ToString() + "\n";
		}
		if (!excludedSubtreesIP.IsEmpty)
		{
			temp += "IP:\n";
			temp = temp + StringifyIPCollection(excludedSubtreesIP) + "\n";
		}
		if (!excludedSubtreesOtherName.IsEmpty)
		{
			temp += "OtherName:\n";
			temp += StringifyOtherNameCollection(excludedSubtreesOtherName);
		}
		return temp;
	}
}
