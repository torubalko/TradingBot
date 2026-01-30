using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.X509;

public class X509Name : Asn1Encodable
{
	public static readonly DerObjectIdentifier C;

	public static readonly DerObjectIdentifier O;

	public static readonly DerObjectIdentifier OU;

	public static readonly DerObjectIdentifier T;

	public static readonly DerObjectIdentifier CN;

	public static readonly DerObjectIdentifier Street;

	public static readonly DerObjectIdentifier SerialNumber;

	public static readonly DerObjectIdentifier L;

	public static readonly DerObjectIdentifier ST;

	public static readonly DerObjectIdentifier Surname;

	public static readonly DerObjectIdentifier GivenName;

	public static readonly DerObjectIdentifier Initials;

	public static readonly DerObjectIdentifier Generation;

	public static readonly DerObjectIdentifier UniqueIdentifier;

	public static readonly DerObjectIdentifier BusinessCategory;

	public static readonly DerObjectIdentifier PostalCode;

	public static readonly DerObjectIdentifier DnQualifier;

	public static readonly DerObjectIdentifier Pseudonym;

	public static readonly DerObjectIdentifier DateOfBirth;

	public static readonly DerObjectIdentifier PlaceOfBirth;

	public static readonly DerObjectIdentifier Gender;

	public static readonly DerObjectIdentifier CountryOfCitizenship;

	public static readonly DerObjectIdentifier CountryOfResidence;

	public static readonly DerObjectIdentifier NameAtBirth;

	public static readonly DerObjectIdentifier PostalAddress;

	public static readonly DerObjectIdentifier DmdName;

	public static readonly DerObjectIdentifier TelephoneNumber;

	public static readonly DerObjectIdentifier OrganizationIdentifier;

	public static readonly DerObjectIdentifier Name;

	public static readonly DerObjectIdentifier EmailAddress;

	public static readonly DerObjectIdentifier UnstructuredName;

	public static readonly DerObjectIdentifier UnstructuredAddress;

	public static readonly DerObjectIdentifier E;

	public static readonly DerObjectIdentifier DC;

	public static readonly DerObjectIdentifier UID;

	private static readonly bool[] defaultReverse;

	public static readonly Hashtable DefaultSymbols;

	public static readonly Hashtable RFC2253Symbols;

	public static readonly Hashtable RFC1779Symbols;

	public static readonly Hashtable DefaultLookup;

	private readonly IList ordering = Platform.CreateArrayList();

	private readonly X509NameEntryConverter converter;

	private IList values = Platform.CreateArrayList();

	private IList added = Platform.CreateArrayList();

	private Asn1Sequence seq;

	public static bool DefaultReverse
	{
		get
		{
			return defaultReverse[0];
		}
		set
		{
			defaultReverse[0] = value;
		}
	}

	static X509Name()
	{
		C = new DerObjectIdentifier("2.5.4.6");
		O = new DerObjectIdentifier("2.5.4.10");
		OU = new DerObjectIdentifier("2.5.4.11");
		T = new DerObjectIdentifier("2.5.4.12");
		CN = new DerObjectIdentifier("2.5.4.3");
		Street = new DerObjectIdentifier("2.5.4.9");
		SerialNumber = new DerObjectIdentifier("2.5.4.5");
		L = new DerObjectIdentifier("2.5.4.7");
		ST = new DerObjectIdentifier("2.5.4.8");
		Surname = new DerObjectIdentifier("2.5.4.4");
		GivenName = new DerObjectIdentifier("2.5.4.42");
		Initials = new DerObjectIdentifier("2.5.4.43");
		Generation = new DerObjectIdentifier("2.5.4.44");
		UniqueIdentifier = new DerObjectIdentifier("2.5.4.45");
		BusinessCategory = new DerObjectIdentifier("2.5.4.15");
		PostalCode = new DerObjectIdentifier("2.5.4.17");
		DnQualifier = new DerObjectIdentifier("2.5.4.46");
		Pseudonym = new DerObjectIdentifier("2.5.4.65");
		DateOfBirth = new DerObjectIdentifier("1.3.6.1.5.5.7.9.1");
		PlaceOfBirth = new DerObjectIdentifier("1.3.6.1.5.5.7.9.2");
		Gender = new DerObjectIdentifier("1.3.6.1.5.5.7.9.3");
		CountryOfCitizenship = new DerObjectIdentifier("1.3.6.1.5.5.7.9.4");
		CountryOfResidence = new DerObjectIdentifier("1.3.6.1.5.5.7.9.5");
		NameAtBirth = new DerObjectIdentifier("1.3.36.8.3.14");
		PostalAddress = new DerObjectIdentifier("2.5.4.16");
		DmdName = new DerObjectIdentifier("2.5.4.54");
		TelephoneNumber = X509ObjectIdentifiers.id_at_telephoneNumber;
		OrganizationIdentifier = X509ObjectIdentifiers.id_at_organizationIdentifier;
		Name = X509ObjectIdentifiers.id_at_name;
		EmailAddress = PkcsObjectIdentifiers.Pkcs9AtEmailAddress;
		UnstructuredName = PkcsObjectIdentifiers.Pkcs9AtUnstructuredName;
		UnstructuredAddress = PkcsObjectIdentifiers.Pkcs9AtUnstructuredAddress;
		E = EmailAddress;
		DC = new DerObjectIdentifier("0.9.2342.19200300.100.1.25");
		UID = new DerObjectIdentifier("0.9.2342.19200300.100.1.1");
		defaultReverse = new bool[1];
		DefaultSymbols = new Hashtable();
		RFC2253Symbols = new Hashtable();
		RFC1779Symbols = new Hashtable();
		DefaultLookup = new Hashtable();
		DefaultSymbols.Add(C, "C");
		DefaultSymbols.Add(O, "O");
		DefaultSymbols.Add(T, "T");
		DefaultSymbols.Add(OU, "OU");
		DefaultSymbols.Add(CN, "CN");
		DefaultSymbols.Add(L, "L");
		DefaultSymbols.Add(ST, "ST");
		DefaultSymbols.Add(SerialNumber, "SERIALNUMBER");
		DefaultSymbols.Add(EmailAddress, "E");
		DefaultSymbols.Add(DC, "DC");
		DefaultSymbols.Add(UID, "UID");
		DefaultSymbols.Add(Street, "STREET");
		DefaultSymbols.Add(Surname, "SURNAME");
		DefaultSymbols.Add(GivenName, "GIVENNAME");
		DefaultSymbols.Add(Initials, "INITIALS");
		DefaultSymbols.Add(Generation, "GENERATION");
		DefaultSymbols.Add(UnstructuredAddress, "unstructuredAddress");
		DefaultSymbols.Add(UnstructuredName, "unstructuredName");
		DefaultSymbols.Add(UniqueIdentifier, "UniqueIdentifier");
		DefaultSymbols.Add(DnQualifier, "DN");
		DefaultSymbols.Add(Pseudonym, "Pseudonym");
		DefaultSymbols.Add(PostalAddress, "PostalAddress");
		DefaultSymbols.Add(NameAtBirth, "NameAtBirth");
		DefaultSymbols.Add(CountryOfCitizenship, "CountryOfCitizenship");
		DefaultSymbols.Add(CountryOfResidence, "CountryOfResidence");
		DefaultSymbols.Add(Gender, "Gender");
		DefaultSymbols.Add(PlaceOfBirth, "PlaceOfBirth");
		DefaultSymbols.Add(DateOfBirth, "DateOfBirth");
		DefaultSymbols.Add(PostalCode, "PostalCode");
		DefaultSymbols.Add(BusinessCategory, "BusinessCategory");
		DefaultSymbols.Add(TelephoneNumber, "TelephoneNumber");
		RFC2253Symbols.Add(C, "C");
		RFC2253Symbols.Add(O, "O");
		RFC2253Symbols.Add(OU, "OU");
		RFC2253Symbols.Add(CN, "CN");
		RFC2253Symbols.Add(L, "L");
		RFC2253Symbols.Add(ST, "ST");
		RFC2253Symbols.Add(Street, "STREET");
		RFC2253Symbols.Add(DC, "DC");
		RFC2253Symbols.Add(UID, "UID");
		RFC1779Symbols.Add(C, "C");
		RFC1779Symbols.Add(O, "O");
		RFC1779Symbols.Add(OU, "OU");
		RFC1779Symbols.Add(CN, "CN");
		RFC1779Symbols.Add(L, "L");
		RFC1779Symbols.Add(ST, "ST");
		RFC1779Symbols.Add(Street, "STREET");
		DefaultLookup.Add("c", C);
		DefaultLookup.Add("o", O);
		DefaultLookup.Add("t", T);
		DefaultLookup.Add("ou", OU);
		DefaultLookup.Add("cn", CN);
		DefaultLookup.Add("l", L);
		DefaultLookup.Add("st", ST);
		DefaultLookup.Add("serialnumber", SerialNumber);
		DefaultLookup.Add("street", Street);
		DefaultLookup.Add("emailaddress", E);
		DefaultLookup.Add("dc", DC);
		DefaultLookup.Add("e", E);
		DefaultLookup.Add("uid", UID);
		DefaultLookup.Add("surname", Surname);
		DefaultLookup.Add("givenname", GivenName);
		DefaultLookup.Add("initials", Initials);
		DefaultLookup.Add("generation", Generation);
		DefaultLookup.Add("unstructuredaddress", UnstructuredAddress);
		DefaultLookup.Add("unstructuredname", UnstructuredName);
		DefaultLookup.Add("uniqueidentifier", UniqueIdentifier);
		DefaultLookup.Add("dn", DnQualifier);
		DefaultLookup.Add("pseudonym", Pseudonym);
		DefaultLookup.Add("postaladdress", PostalAddress);
		DefaultLookup.Add("nameofbirth", NameAtBirth);
		DefaultLookup.Add("countryofcitizenship", CountryOfCitizenship);
		DefaultLookup.Add("countryofresidence", CountryOfResidence);
		DefaultLookup.Add("gender", Gender);
		DefaultLookup.Add("placeofbirth", PlaceOfBirth);
		DefaultLookup.Add("dateofbirth", DateOfBirth);
		DefaultLookup.Add("postalcode", PostalCode);
		DefaultLookup.Add("businesscategory", BusinessCategory);
		DefaultLookup.Add("telephonenumber", TelephoneNumber);
	}

	public static X509Name GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static X509Name GetInstance(object obj)
	{
		if (obj is X509Name)
		{
			return (X509Name)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new X509Name(Asn1Sequence.GetInstance(obj));
	}

	protected X509Name()
	{
	}

	protected X509Name(Asn1Sequence seq)
	{
		this.seq = seq;
		foreach (Asn1Encodable item in seq)
		{
			Asn1Set asn1Set = Asn1Set.GetInstance(item.ToAsn1Object());
			for (int i = 0; i < asn1Set.Count; i++)
			{
				Asn1Sequence s = Asn1Sequence.GetInstance(asn1Set[i].ToAsn1Object());
				if (s.Count != 2)
				{
					throw new ArgumentException("badly sized pair");
				}
				ordering.Add(DerObjectIdentifier.GetInstance(s[0].ToAsn1Object()));
				Asn1Object derValue = s[1].ToAsn1Object();
				if (derValue is IAsn1String && !(derValue is DerUniversalString))
				{
					string v = ((IAsn1String)derValue).GetString();
					if (Platform.StartsWith(v, "#"))
					{
						v = "\\" + v;
					}
					values.Add(v);
				}
				else
				{
					values.Add("#" + Hex.ToHexString(derValue.GetEncoded()));
				}
				added.Add(i != 0);
			}
		}
	}

	public X509Name(IList ordering, IDictionary attributes)
		: this(ordering, attributes, new X509DefaultEntryConverter())
	{
	}

	public X509Name(IList ordering, IDictionary attributes, X509NameEntryConverter converter)
	{
		this.converter = converter;
		foreach (DerObjectIdentifier oid in ordering)
		{
			object attribute = attributes[oid];
			if (attribute == null)
			{
				throw new ArgumentException("No attribute for object id - " + oid?.ToString() + " - passed to distinguished name");
			}
			this.ordering.Add(oid);
			added.Add(false);
			values.Add(attribute);
		}
	}

	public X509Name(IList oids, IList values)
		: this(oids, values, new X509DefaultEntryConverter())
	{
	}

	public X509Name(IList oids, IList values, X509NameEntryConverter converter)
	{
		this.converter = converter;
		if (oids.Count != values.Count)
		{
			throw new ArgumentException("'oids' must be same length as 'values'.");
		}
		for (int i = 0; i < oids.Count; i++)
		{
			ordering.Add(oids[i]);
			this.values.Add(values[i]);
			added.Add(false);
		}
	}

	public X509Name(string dirName)
		: this(DefaultReverse, DefaultLookup, dirName)
	{
	}

	public X509Name(string dirName, X509NameEntryConverter converter)
		: this(DefaultReverse, DefaultLookup, dirName, converter)
	{
	}

	public X509Name(bool reverse, string dirName)
		: this(reverse, DefaultLookup, dirName)
	{
	}

	public X509Name(bool reverse, string dirName, X509NameEntryConverter converter)
		: this(reverse, DefaultLookup, dirName, converter)
	{
	}

	public X509Name(bool reverse, IDictionary lookUp, string dirName)
		: this(reverse, lookUp, dirName, new X509DefaultEntryConverter())
	{
	}

	private DerObjectIdentifier DecodeOid(string name, IDictionary lookUp)
	{
		if (Platform.StartsWith(Platform.ToUpperInvariant(name), "OID."))
		{
			return new DerObjectIdentifier(name.Substring(4));
		}
		if (name[0] >= '0' && name[0] <= '9')
		{
			return new DerObjectIdentifier(name);
		}
		return ((DerObjectIdentifier)lookUp[Platform.ToLowerInvariant(name)]) ?? throw new ArgumentException("Unknown object id - " + name + " - passed to distinguished name");
	}

	public X509Name(bool reverse, IDictionary lookUp, string dirName, X509NameEntryConverter converter)
	{
		this.converter = converter;
		X509NameTokenizer nTok = new X509NameTokenizer(dirName);
		while (nTok.HasMoreTokens())
		{
			string text = nTok.NextToken();
			int index = text.IndexOf('=');
			if (index == -1)
			{
				throw new ArgumentException("badly formated directory string");
			}
			string name = text.Substring(0, index);
			string value = text.Substring(index + 1);
			DerObjectIdentifier oid = DecodeOid(name, lookUp);
			if (value.IndexOf('+') > 0)
			{
				X509NameTokenizer vTok = new X509NameTokenizer(value, '+');
				string v = vTok.NextToken();
				ordering.Add(oid);
				values.Add(v);
				added.Add(false);
				while (vTok.HasMoreTokens())
				{
					string text2 = vTok.NextToken();
					int ndx = text2.IndexOf('=');
					string nm = text2.Substring(0, ndx);
					string vl = text2.Substring(ndx + 1);
					ordering.Add(DecodeOid(nm, lookUp));
					values.Add(vl);
					added.Add(true);
				}
			}
			else
			{
				ordering.Add(oid);
				values.Add(value);
				added.Add(false);
			}
		}
		if (!reverse)
		{
			return;
		}
		IList o = Platform.CreateArrayList();
		IList v2 = Platform.CreateArrayList();
		IList a = Platform.CreateArrayList();
		int count = 1;
		for (int i = 0; i < ordering.Count; i++)
		{
			if (!(bool)added[i])
			{
				count = 0;
			}
			int index2 = count++;
			o.Insert(index2, ordering[i]);
			v2.Insert(index2, values[i]);
			a.Insert(index2, added[i]);
		}
		ordering = o;
		values = v2;
		added = a;
	}

	public IList GetOidList()
	{
		return Platform.CreateArrayList(ordering);
	}

	public IList GetValueList()
	{
		return GetValueList(null);
	}

	public IList GetValueList(DerObjectIdentifier oid)
	{
		IList v = Platform.CreateArrayList();
		for (int i = 0; i != values.Count; i++)
		{
			if (oid == null || oid.Equals(ordering[i]))
			{
				string val = (string)values[i];
				if (Platform.StartsWith(val, "\\#"))
				{
					val = val.Substring(1);
				}
				v.Add(val);
			}
		}
		return v;
	}

	public override Asn1Object ToAsn1Object()
	{
		if (seq == null)
		{
			Asn1EncodableVector vec = new Asn1EncodableVector();
			Asn1EncodableVector sVec = new Asn1EncodableVector();
			DerObjectIdentifier lstOid = null;
			for (int i = 0; i != ordering.Count; i++)
			{
				DerObjectIdentifier oid = (DerObjectIdentifier)ordering[i];
				string str = (string)values[i];
				if (lstOid != null && !(bool)added[i])
				{
					vec.Add(new DerSet(sVec));
					sVec = new Asn1EncodableVector();
				}
				sVec.Add(new DerSequence(oid, converter.GetConvertedValue(oid, str)));
				lstOid = oid;
			}
			vec.Add(new DerSet(sVec));
			seq = new DerSequence(vec);
		}
		return seq;
	}

	public bool Equivalent(X509Name other, bool inOrder)
	{
		if (!inOrder)
		{
			return Equivalent(other);
		}
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		int orderingSize = ordering.Count;
		if (orderingSize != other.ordering.Count)
		{
			return false;
		}
		for (int i = 0; i < orderingSize; i++)
		{
			DerObjectIdentifier obj = (DerObjectIdentifier)ordering[i];
			DerObjectIdentifier oOid = (DerObjectIdentifier)other.ordering[i];
			if (!obj.Equals(oOid))
			{
				return false;
			}
			string s = (string)values[i];
			string oVal = (string)other.values[i];
			if (!equivalentStrings(s, oVal))
			{
				return false;
			}
		}
		return true;
	}

	public bool Equivalent(X509Name other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		int orderingSize = ordering.Count;
		if (orderingSize != other.ordering.Count)
		{
			return false;
		}
		bool[] indexes = new bool[orderingSize];
		int start;
		int end;
		int delta;
		if (ordering[0].Equals(other.ordering[0]))
		{
			start = 0;
			end = orderingSize;
			delta = 1;
		}
		else
		{
			start = orderingSize - 1;
			end = -1;
			delta = -1;
		}
		for (int i = start; i != end; i += delta)
		{
			bool found = false;
			DerObjectIdentifier oid = (DerObjectIdentifier)ordering[i];
			string value = (string)values[i];
			for (int j = 0; j < orderingSize; j++)
			{
				if (indexes[j])
				{
					continue;
				}
				DerObjectIdentifier oOid = (DerObjectIdentifier)other.ordering[j];
				if (oid.Equals(oOid))
				{
					string oValue = (string)other.values[j];
					if (equivalentStrings(value, oValue))
					{
						indexes[j] = true;
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
		return true;
	}

	private static bool equivalentStrings(string s1, string s2)
	{
		string v1 = canonicalize(s1);
		string v2 = canonicalize(s2);
		if (!v1.Equals(v2))
		{
			v1 = stripInternalSpaces(v1);
			v2 = stripInternalSpaces(v2);
			if (!v1.Equals(v2))
			{
				return false;
			}
		}
		return true;
	}

	private static string canonicalize(string s)
	{
		string v = Platform.ToLowerInvariant(s).Trim();
		if (Platform.StartsWith(v, "#"))
		{
			Asn1Object obj = decodeObject(v);
			if (obj is IAsn1String)
			{
				v = Platform.ToLowerInvariant(((IAsn1String)obj).GetString()).Trim();
			}
		}
		return v;
	}

	private static Asn1Object decodeObject(string v)
	{
		try
		{
			return Asn1Object.FromByteArray(Hex.DecodeStrict(v, 1, v.Length - 1));
		}
		catch (IOException ex)
		{
			throw new InvalidOperationException("unknown encoding in name: " + ex.Message, ex);
		}
	}

	private static string stripInternalSpaces(string str)
	{
		StringBuilder res = new StringBuilder();
		if (str.Length != 0)
		{
			char c1 = str[0];
			res.Append(c1);
			for (int k = 1; k < str.Length; k++)
			{
				char c2 = str[k];
				if (c1 != ' ' || c2 != ' ')
				{
					res.Append(c2);
				}
				c1 = c2;
			}
		}
		return res.ToString();
	}

	private void AppendValue(StringBuilder buf, IDictionary oidSymbols, DerObjectIdentifier oid, string val)
	{
		string sym = (string)oidSymbols[oid];
		if (sym != null)
		{
			buf.Append(sym);
		}
		else
		{
			buf.Append(oid.Id);
		}
		buf.Append('=');
		int index = buf.Length;
		buf.Append(val);
		int end = buf.Length;
		if (Platform.StartsWith(val, "\\#"))
		{
			index += 2;
		}
		for (; index != end; index++)
		{
			if (buf[index] == ',' || buf[index] == '"' || buf[index] == '\\' || buf[index] == '+' || buf[index] == '=' || buf[index] == '<' || buf[index] == '>' || buf[index] == ';')
			{
				buf.Insert(index++, "\\");
				end++;
			}
		}
	}

	public string ToString(bool reverse, IDictionary oidSymbols)
	{
		ArrayList components = new ArrayList();
		StringBuilder ava = null;
		for (int i = 0; i < ordering.Count; i++)
		{
			if ((bool)added[i])
			{
				ava.Append('+');
				AppendValue(ava, oidSymbols, (DerObjectIdentifier)ordering[i], (string)values[i]);
			}
			else
			{
				ava = new StringBuilder();
				AppendValue(ava, oidSymbols, (DerObjectIdentifier)ordering[i], (string)values[i]);
				components.Add(ava);
			}
		}
		if (reverse)
		{
			components.Reverse();
		}
		StringBuilder buf = new StringBuilder();
		if (components.Count > 0)
		{
			buf.Append(components[0].ToString());
			for (int j = 1; j < components.Count; j++)
			{
				buf.Append(',');
				buf.Append(components[j].ToString());
			}
		}
		return buf.ToString();
	}

	public override string ToString()
	{
		return ToString(DefaultReverse, DefaultSymbols);
	}
}
