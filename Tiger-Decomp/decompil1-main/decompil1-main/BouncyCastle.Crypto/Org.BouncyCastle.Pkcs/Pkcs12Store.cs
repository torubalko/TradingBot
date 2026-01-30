using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs;

public class Pkcs12Store
{
	internal class CertId
	{
		private readonly byte[] id;

		internal byte[] Id => id;

		internal CertId(AsymmetricKeyParameter pubKey)
		{
			id = CreateSubjectKeyID(pubKey).GetKeyIdentifier();
		}

		internal CertId(byte[] id)
		{
			this.id = id;
		}

		public override int GetHashCode()
		{
			return Arrays.GetHashCode(id);
		}

		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (!(obj is CertId other))
			{
				return false;
			}
			return Arrays.AreEqual(id, other.id);
		}
	}

	private class IgnoresCaseHashtable : IEnumerable
	{
		private readonly IDictionary orig = Platform.CreateHashtable();

		private readonly IDictionary keys = Platform.CreateHashtable();

		public ICollection Keys => orig.Keys;

		public object this[string alias]
		{
			get
			{
				string upper = Platform.ToUpperInvariant(alias);
				string k = (string)keys[upper];
				if (k == null)
				{
					return null;
				}
				return orig[k];
			}
			set
			{
				string upper = Platform.ToUpperInvariant(alias);
				string k = (string)keys[upper];
				if (k != null)
				{
					orig.Remove(k);
				}
				keys[upper] = alias;
				orig[alias] = value;
			}
		}

		public ICollection Values => orig.Values;

		public int Count => orig.Count;

		public void Clear()
		{
			orig.Clear();
			keys.Clear();
		}

		public IEnumerator GetEnumerator()
		{
			return orig.GetEnumerator();
		}

		public object Remove(string alias)
		{
			string upper = Platform.ToUpperInvariant(alias);
			string k = (string)keys[upper];
			if (k == null)
			{
				return null;
			}
			keys.Remove(upper);
			object result = orig[k];
			orig.Remove(k);
			return result;
		}
	}

	public const string IgnoreUselessPasswordProperty = "Org.BouncyCastle.Pkcs12.IgnoreUselessPassword";

	private readonly IgnoresCaseHashtable keys = new IgnoresCaseHashtable();

	private readonly IDictionary localIds = Platform.CreateHashtable();

	private readonly IgnoresCaseHashtable certs = new IgnoresCaseHashtable();

	private readonly IDictionary chainCerts = Platform.CreateHashtable();

	private readonly IDictionary keyCerts = Platform.CreateHashtable();

	private readonly DerObjectIdentifier keyAlgorithm;

	private readonly DerObjectIdentifier keyPrfAlgorithm;

	private readonly DerObjectIdentifier certAlgorithm;

	private readonly DerObjectIdentifier certPrfAlgorithm;

	private readonly bool useDerEncoding;

	private AsymmetricKeyEntry unmarkedKeyEntry;

	private const int MinIterations = 1024;

	private const int SaltSize = 20;

	public IEnumerable Aliases => new EnumerableProxy(GetAliasesTable().Keys);

	public int Count => GetAliasesTable().Count;

	private static SubjectKeyIdentifier CreateSubjectKeyID(AsymmetricKeyParameter pubKey)
	{
		return new SubjectKeyIdentifier(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pubKey));
	}

	internal Pkcs12Store(DerObjectIdentifier keyAlgorithm, DerObjectIdentifier certAlgorithm, bool useDerEncoding)
	{
		this.keyAlgorithm = keyAlgorithm;
		keyPrfAlgorithm = null;
		this.certAlgorithm = certAlgorithm;
		certPrfAlgorithm = null;
		this.useDerEncoding = useDerEncoding;
	}

	internal Pkcs12Store(DerObjectIdentifier keyAlgorithm, DerObjectIdentifier keyPrfAlgorithm, DerObjectIdentifier certAlgorithm, DerObjectIdentifier certPrfAlgorithm, bool useDerEncoding)
	{
		this.keyAlgorithm = keyAlgorithm;
		this.keyPrfAlgorithm = keyPrfAlgorithm;
		this.certAlgorithm = certAlgorithm;
		this.certPrfAlgorithm = certPrfAlgorithm;
		this.useDerEncoding = useDerEncoding;
	}

	public Pkcs12Store()
		: this(PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc, PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc, useDerEncoding: false)
	{
	}

	public Pkcs12Store(Stream input, char[] password)
		: this()
	{
		Load(input, password);
	}

	protected virtual void LoadKeyBag(PrivateKeyInfo privKeyInfo, Asn1Set bagAttributes)
	{
		AsymmetricKeyParameter key = PrivateKeyFactory.CreateKey(privKeyInfo);
		IDictionary attributes = Platform.CreateHashtable();
		AsymmetricKeyEntry keyEntry = new AsymmetricKeyEntry(key, attributes);
		string alias = null;
		Asn1OctetString localId = null;
		if (bagAttributes != null)
		{
			foreach (Asn1Sequence bagAttribute in bagAttributes)
			{
				DerObjectIdentifier aOid = DerObjectIdentifier.GetInstance(bagAttribute[0]);
				Asn1Set attrSet = Asn1Set.GetInstance(bagAttribute[1]);
				Asn1Encodable attr = null;
				if (attrSet.Count <= 0)
				{
					continue;
				}
				attr = attrSet[0];
				if (attributes.Contains(aOid.Id))
				{
					if (!attributes[aOid.Id].Equals(attr))
					{
						throw new IOException("attempt to add existing attribute with different value");
					}
				}
				else
				{
					attributes.Add(aOid.Id, attr);
				}
				if (aOid.Equals(PkcsObjectIdentifiers.Pkcs9AtFriendlyName))
				{
					alias = ((DerBmpString)attr).GetString();
					keys[alias] = keyEntry;
				}
				else if (aOid.Equals(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID))
				{
					localId = (Asn1OctetString)attr;
				}
			}
		}
		if (localId != null)
		{
			string name = Hex.ToHexString(localId.GetOctets());
			if (alias == null)
			{
				keys[name] = keyEntry;
			}
			else
			{
				localIds[alias] = name;
			}
		}
		else
		{
			unmarkedKeyEntry = keyEntry;
		}
	}

	protected virtual void LoadPkcs8ShroudedKeyBag(EncryptedPrivateKeyInfo encPrivKeyInfo, Asn1Set bagAttributes, char[] password, bool wrongPkcs12Zero)
	{
		if (password != null)
		{
			PrivateKeyInfo privInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(password, wrongPkcs12Zero, encPrivKeyInfo);
			LoadKeyBag(privInfo, bagAttributes);
		}
	}

	public void Load(Stream input, char[] password)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		Pfx bag = Pfx.GetInstance(Asn1Object.FromStream(input));
		ContentInfo info = bag.AuthSafe;
		bool wrongPkcs12Zero = false;
		if (bag.MacData != null)
		{
			if (password == null)
			{
				throw new ArgumentNullException("password", "no password supplied when one expected");
			}
			MacData macData = bag.MacData;
			DigestInfo dInfo = macData.Mac;
			AlgorithmIdentifier algId = dInfo.AlgorithmID;
			byte[] salt = macData.GetSalt();
			int itCount = macData.IterationCount.IntValue;
			byte[] data = Asn1OctetString.GetInstance(info.Content).GetOctets();
			byte[] a = CalculatePbeMac(algId.Algorithm, salt, itCount, password, wrongPkcs12Zero: false, data);
			byte[] dig = dInfo.GetDigest();
			if (!Arrays.ConstantTimeAreEqual(a, dig))
			{
				if (password.Length != 0)
				{
					throw new IOException("PKCS12 key store MAC invalid - wrong password or corrupted file.");
				}
				if (!Arrays.ConstantTimeAreEqual(CalculatePbeMac(algId.Algorithm, salt, itCount, password, wrongPkcs12Zero: true, data), dig))
				{
					throw new IOException("PKCS12 key store MAC invalid - wrong password or corrupted file.");
				}
				wrongPkcs12Zero = true;
			}
		}
		else if (password != null)
		{
			string ignoreProperty = Platform.GetEnvironmentVariable("Org.BouncyCastle.Pkcs12.IgnoreUselessPassword");
			if (ignoreProperty == null || !Platform.EqualsIgnoreCase("true", ignoreProperty))
			{
				throw new IOException("password supplied for keystore that does not require one");
			}
		}
		keys.Clear();
		localIds.Clear();
		unmarkedKeyEntry = null;
		IList certBags = Platform.CreateArrayList();
		if (info.ContentType.Equals(PkcsObjectIdentifiers.Data))
		{
			ContentInfo[] contentInfo = AuthenticatedSafe.GetInstance(Asn1OctetString.GetInstance(info.Content).GetOctets()).GetContentInfo();
			foreach (ContentInfo ci in contentInfo)
			{
				DerObjectIdentifier oid = ci.ContentType;
				byte[] octets = null;
				if (oid.Equals(PkcsObjectIdentifiers.Data))
				{
					octets = Asn1OctetString.GetInstance(ci.Content).GetOctets();
				}
				else if (oid.Equals(PkcsObjectIdentifiers.EncryptedData) && password != null)
				{
					EncryptedData d = EncryptedData.GetInstance(ci.Content);
					octets = CryptPbeData(forEncryption: false, d.EncryptionAlgorithm, password, wrongPkcs12Zero, d.Content.GetOctets());
				}
				if (octets == null)
				{
					continue;
				}
				foreach (Asn1Sequence item in Asn1Sequence.GetInstance(octets))
				{
					SafeBag b = SafeBag.GetInstance(item);
					if (b.BagID.Equals(PkcsObjectIdentifiers.CertBag))
					{
						certBags.Add(b);
					}
					else if (b.BagID.Equals(PkcsObjectIdentifiers.Pkcs8ShroudedKeyBag))
					{
						LoadPkcs8ShroudedKeyBag(EncryptedPrivateKeyInfo.GetInstance(b.BagValue), b.BagAttributes, password, wrongPkcs12Zero);
					}
					else if (b.BagID.Equals(PkcsObjectIdentifiers.KeyBag))
					{
						LoadKeyBag(PrivateKeyInfo.GetInstance(b.BagValue), b.BagAttributes);
					}
				}
			}
		}
		certs.Clear();
		chainCerts.Clear();
		keyCerts.Clear();
		foreach (SafeBag b2 in certBags)
		{
			byte[] octets2 = ((Asn1OctetString)CertBag.GetInstance(b2.BagValue).CertValue).GetOctets();
			X509Certificate cert = new X509CertificateParser().ReadCertificate(octets2);
			IDictionary attributes = Platform.CreateHashtable();
			Asn1OctetString localId = null;
			string alias = null;
			if (b2.BagAttributes != null)
			{
				foreach (Asn1Sequence bagAttribute in b2.BagAttributes)
				{
					DerObjectIdentifier aOid = DerObjectIdentifier.GetInstance(bagAttribute[0]);
					Asn1Set attrSet = Asn1Set.GetInstance(bagAttribute[1]);
					if (attrSet.Count <= 0)
					{
						continue;
					}
					Asn1Encodable attr = attrSet[0];
					if (attributes.Contains(aOid.Id))
					{
						if (aOid.Equals(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID))
						{
							string id = Hex.ToHexString(Asn1OctetString.GetInstance(attr).GetOctets());
							if (keys[id] == null && localIds[id] == null)
							{
								continue;
							}
						}
						if (!attributes[aOid.Id].Equals(attr))
						{
							throw new IOException("attempt to add existing attribute with different value");
						}
					}
					else
					{
						attributes.Add(aOid.Id, attr);
					}
					if (aOid.Equals(PkcsObjectIdentifiers.Pkcs9AtFriendlyName))
					{
						alias = ((DerBmpString)attr).GetString();
					}
					else if (aOid.Equals(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID))
					{
						localId = (Asn1OctetString)attr;
					}
				}
			}
			CertId certId = new CertId(cert.GetPublicKey());
			X509CertificateEntry certEntry = new X509CertificateEntry(cert, attributes);
			chainCerts[certId] = certEntry;
			if (unmarkedKeyEntry != null)
			{
				if (keyCerts.Count == 0)
				{
					string name = Hex.ToHexString(certId.Id);
					keyCerts[name] = certEntry;
					keys[name] = unmarkedKeyEntry;
				}
				else
				{
					keys["unmarked"] = unmarkedKeyEntry;
				}
				continue;
			}
			if (localId != null)
			{
				string name2 = Hex.ToHexString(localId.GetOctets());
				keyCerts[name2] = certEntry;
			}
			if (alias != null)
			{
				certs[alias] = certEntry;
			}
		}
	}

	public AsymmetricKeyEntry GetKey(string alias)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		return (AsymmetricKeyEntry)keys[alias];
	}

	public bool IsCertificateEntry(string alias)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		if (certs[alias] != null)
		{
			return keys[alias] == null;
		}
		return false;
	}

	public bool IsKeyEntry(string alias)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		return keys[alias] != null;
	}

	private IDictionary GetAliasesTable()
	{
		IDictionary tab = Platform.CreateHashtable();
		foreach (string key in certs.Keys)
		{
			tab[key] = "cert";
		}
		foreach (string a in keys.Keys)
		{
			if (tab[a] == null)
			{
				tab[a] = "key";
			}
		}
		return tab;
	}

	public bool ContainsAlias(string alias)
	{
		if (certs[alias] == null)
		{
			return keys[alias] != null;
		}
		return true;
	}

	public X509CertificateEntry GetCertificate(string alias)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		X509CertificateEntry c = (X509CertificateEntry)certs[alias];
		if (c == null)
		{
			string id = (string)localIds[alias];
			c = ((id == null) ? ((X509CertificateEntry)keyCerts[alias]) : ((X509CertificateEntry)keyCerts[id]));
		}
		return c;
	}

	public string GetCertificateAlias(X509Certificate cert)
	{
		if (cert == null)
		{
			throw new ArgumentNullException("cert");
		}
		foreach (DictionaryEntry entry in certs)
		{
			if (((X509CertificateEntry)entry.Value).Certificate.Equals(cert))
			{
				return (string)entry.Key;
			}
		}
		foreach (DictionaryEntry entry2 in keyCerts)
		{
			if (((X509CertificateEntry)entry2.Value).Certificate.Equals(cert))
			{
				return (string)entry2.Key;
			}
		}
		return null;
	}

	public X509CertificateEntry[] GetCertificateChain(string alias)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		if (!IsKeyEntry(alias))
		{
			return null;
		}
		X509CertificateEntry c = GetCertificate(alias);
		if (c != null)
		{
			IList cs = Platform.CreateArrayList();
			while (c != null)
			{
				X509Certificate x509c = c.Certificate;
				X509CertificateEntry nextC = null;
				Asn1OctetString akiValue = x509c.GetExtensionValue(X509Extensions.AuthorityKeyIdentifier);
				if (akiValue != null)
				{
					byte[] keyID = AuthorityKeyIdentifier.GetInstance(akiValue.GetOctets()).GetKeyIdentifier();
					if (keyID != null)
					{
						nextC = (X509CertificateEntry)chainCerts[new CertId(keyID)];
					}
				}
				if (nextC == null)
				{
					X509Name i = x509c.IssuerDN;
					X509Name s = x509c.SubjectDN;
					if (!i.Equivalent(s))
					{
						foreach (CertId certId in chainCerts.Keys)
						{
							X509CertificateEntry x509CertEntry = (X509CertificateEntry)chainCerts[certId];
							X509Certificate crt = x509CertEntry.Certificate;
							if (crt.SubjectDN.Equivalent(i))
							{
								try
								{
									x509c.Verify(crt.GetPublicKey());
									nextC = x509CertEntry;
								}
								catch (InvalidKeyException)
								{
									continue;
								}
								break;
							}
						}
					}
				}
				cs.Add(c);
				c = ((nextC == c) ? null : nextC);
			}
			X509CertificateEntry[] result = new X509CertificateEntry[cs.Count];
			for (int j = 0; j < cs.Count; j++)
			{
				result[j] = (X509CertificateEntry)cs[j];
			}
			return result;
		}
		return null;
	}

	public void SetCertificateEntry(string alias, X509CertificateEntry certEntry)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		if (certEntry == null)
		{
			throw new ArgumentNullException("certEntry");
		}
		if (keys[alias] != null)
		{
			throw new ArgumentException("There is a key entry with the name " + alias + ".");
		}
		certs[alias] = certEntry;
		chainCerts[new CertId(certEntry.Certificate.GetPublicKey())] = certEntry;
	}

	public void SetKeyEntry(string alias, AsymmetricKeyEntry keyEntry, X509CertificateEntry[] chain)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		if (keyEntry == null)
		{
			throw new ArgumentNullException("keyEntry");
		}
		if (keyEntry.Key.IsPrivate && chain == null)
		{
			throw new ArgumentException("No certificate chain for private key");
		}
		if (keys[alias] != null)
		{
			DeleteEntry(alias);
		}
		keys[alias] = keyEntry;
		certs[alias] = chain[0];
		for (int i = 0; i != chain.Length; i++)
		{
			chainCerts[new CertId(chain[i].Certificate.GetPublicKey())] = chain[i];
		}
	}

	public void DeleteEntry(string alias)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		AsymmetricKeyEntry k = (AsymmetricKeyEntry)keys[alias];
		if (k != null)
		{
			keys.Remove(alias);
		}
		X509CertificateEntry c = (X509CertificateEntry)certs[alias];
		if (c != null)
		{
			certs.Remove(alias);
			chainCerts.Remove(new CertId(c.Certificate.GetPublicKey()));
		}
		if (k != null)
		{
			string id = (string)localIds[alias];
			if (id != null)
			{
				localIds.Remove(alias);
				c = (X509CertificateEntry)keyCerts[id];
			}
			if (c != null)
			{
				keyCerts.Remove(id);
				chainCerts.Remove(new CertId(c.Certificate.GetPublicKey()));
			}
		}
		if (c == null && k == null)
		{
			throw new ArgumentException("no such entry as " + alias);
		}
	}

	public bool IsEntryOfType(string alias, Type entryType)
	{
		if (entryType == typeof(X509CertificateEntry))
		{
			return IsCertificateEntry(alias);
		}
		if (entryType == typeof(AsymmetricKeyEntry))
		{
			if (IsKeyEntry(alias))
			{
				return GetCertificate(alias) != null;
			}
			return false;
		}
		return false;
	}

	[Obsolete("Use 'Count' property instead")]
	public int Size()
	{
		return Count;
	}

	public void Save(Stream stream, char[] password, SecureRandom random)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (random == null)
		{
			throw new ArgumentNullException("random");
		}
		Asn1EncodableVector keyBags = new Asn1EncodableVector();
		foreach (string name in keys.Keys)
		{
			byte[] kSalt = new byte[20];
			random.NextBytes(kSalt);
			AsymmetricKeyEntry privKey = (AsymmetricKeyEntry)keys[name];
			DerObjectIdentifier bagOid;
			Asn1Encodable bagData;
			if (password == null)
			{
				bagOid = PkcsObjectIdentifiers.KeyBag;
				bagData = PrivateKeyInfoFactory.CreatePrivateKeyInfo(privKey.Key);
			}
			else
			{
				bagOid = PkcsObjectIdentifiers.Pkcs8ShroudedKeyBag;
				bagData = ((keyPrfAlgorithm == null) ? EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(keyAlgorithm, password, kSalt, 1024, privKey.Key) : EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(keyAlgorithm, keyPrfAlgorithm, password, kSalt, 1024, random, privKey.Key));
			}
			Asn1EncodableVector kName = new Asn1EncodableVector();
			foreach (string oid in privKey.BagAttributeKeys)
			{
				Asn1Encodable entry = privKey[oid];
				if (!oid.Equals(PkcsObjectIdentifiers.Pkcs9AtFriendlyName.Id))
				{
					kName.Add(new DerSequence(new DerObjectIdentifier(oid), new DerSet(entry)));
				}
			}
			kName.Add(new DerSequence(PkcsObjectIdentifiers.Pkcs9AtFriendlyName, new DerSet(new DerBmpString(name))));
			if (privKey[PkcsObjectIdentifiers.Pkcs9AtLocalKeyID] == null)
			{
				SubjectKeyIdentifier subjectKeyID = CreateSubjectKeyID(GetCertificate(name).Certificate.GetPublicKey());
				kName.Add(new DerSequence(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID, new DerSet(subjectKeyID)));
			}
			keyBags.Add(new SafeBag(bagOid, bagData.ToAsn1Object(), new DerSet(kName)));
		}
		byte[] keyBagsEncoding = new DerSequence(keyBags).GetDerEncoded();
		ContentInfo keysInfo = new ContentInfo(PkcsObjectIdentifiers.Data, new BerOctetString(keyBagsEncoding));
		byte[] cSalt = new byte[20];
		random.NextBytes(cSalt);
		Asn1EncodableVector certBags = new Asn1EncodableVector();
		Pkcs12PbeParams cParams = new Pkcs12PbeParams(cSalt, 1024);
		AlgorithmIdentifier cAlgId = new AlgorithmIdentifier(certAlgorithm, cParams.ToAsn1Object());
		ISet doneCerts = new HashSet();
		foreach (string name2 in keys.Keys)
		{
			X509CertificateEntry certEntry = GetCertificate(name2);
			CertBag cBag = new CertBag(PkcsObjectIdentifiers.X509Certificate, new DerOctetString(certEntry.Certificate.GetEncoded()));
			Asn1EncodableVector fName = new Asn1EncodableVector();
			foreach (string oid2 in certEntry.BagAttributeKeys)
			{
				Asn1Encodable entry2 = certEntry[oid2];
				if (!oid2.Equals(PkcsObjectIdentifiers.Pkcs9AtFriendlyName.Id))
				{
					fName.Add(new DerSequence(new DerObjectIdentifier(oid2), new DerSet(entry2)));
				}
			}
			fName.Add(new DerSequence(PkcsObjectIdentifiers.Pkcs9AtFriendlyName, new DerSet(new DerBmpString(name2))));
			if (certEntry[PkcsObjectIdentifiers.Pkcs9AtLocalKeyID] == null)
			{
				SubjectKeyIdentifier subjectKeyID2 = CreateSubjectKeyID(certEntry.Certificate.GetPublicKey());
				fName.Add(new DerSequence(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID, new DerSet(subjectKeyID2)));
			}
			certBags.Add(new SafeBag(PkcsObjectIdentifiers.CertBag, cBag.ToAsn1Object(), new DerSet(fName)));
			doneCerts.Add(certEntry.Certificate);
		}
		foreach (string certId in certs.Keys)
		{
			X509CertificateEntry cert = (X509CertificateEntry)certs[certId];
			if (keys[certId] != null)
			{
				continue;
			}
			CertBag cBag2 = new CertBag(PkcsObjectIdentifiers.X509Certificate, new DerOctetString(cert.Certificate.GetEncoded()));
			Asn1EncodableVector fName2 = new Asn1EncodableVector();
			foreach (string oid3 in cert.BagAttributeKeys)
			{
				if (!oid3.Equals(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID.Id))
				{
					Asn1Encodable entry3 = cert[oid3];
					if (!oid3.Equals(PkcsObjectIdentifiers.Pkcs9AtFriendlyName.Id))
					{
						fName2.Add(new DerSequence(new DerObjectIdentifier(oid3), new DerSet(entry3)));
					}
				}
			}
			fName2.Add(new DerSequence(PkcsObjectIdentifiers.Pkcs9AtFriendlyName, new DerSet(new DerBmpString(certId))));
			certBags.Add(new SafeBag(PkcsObjectIdentifiers.CertBag, cBag2.ToAsn1Object(), new DerSet(fName2)));
			doneCerts.Add(cert.Certificate);
		}
		foreach (CertId certId2 in chainCerts.Keys)
		{
			X509CertificateEntry cert2 = (X509CertificateEntry)chainCerts[certId2];
			if (doneCerts.Contains(cert2.Certificate))
			{
				continue;
			}
			CertBag cBag3 = new CertBag(PkcsObjectIdentifiers.X509Certificate, new DerOctetString(cert2.Certificate.GetEncoded()));
			Asn1EncodableVector fName3 = new Asn1EncodableVector();
			foreach (string oid4 in cert2.BagAttributeKeys)
			{
				if (!oid4.Equals(PkcsObjectIdentifiers.Pkcs9AtLocalKeyID.Id))
				{
					fName3.Add(new DerSequence(new DerObjectIdentifier(oid4), new DerSet(cert2[oid4])));
				}
			}
			certBags.Add(new SafeBag(PkcsObjectIdentifiers.CertBag, cBag3.ToAsn1Object(), new DerSet(fName3)));
		}
		byte[] certBagsEncoding = new DerSequence(certBags).GetDerEncoded();
		ContentInfo certsInfo;
		if (password == null || certAlgorithm == null)
		{
			certsInfo = new ContentInfo(PkcsObjectIdentifiers.Data, new BerOctetString(certBagsEncoding));
		}
		else
		{
			byte[] certBytes = CryptPbeData(forEncryption: true, cAlgId, password, wrongPkcs12Zero: false, certBagsEncoding);
			EncryptedData cInfo = new EncryptedData(PkcsObjectIdentifiers.Data, cAlgId, new BerOctetString(certBytes));
			certsInfo = new ContentInfo(PkcsObjectIdentifiers.EncryptedData, cInfo.ToAsn1Object());
		}
		byte[] data = new AuthenticatedSafe(new ContentInfo[2] { keysInfo, certsInfo }).GetEncoded(useDerEncoding ? "DER" : "BER");
		ContentInfo contentInfo = new ContentInfo(PkcsObjectIdentifiers.Data, new BerOctetString(data));
		MacData macData = null;
		if (password != null)
		{
			byte[] mSalt = new byte[20];
			random.NextBytes(mSalt);
			macData = new MacData(new DigestInfo(digest: CalculatePbeMac(OiwObjectIdentifiers.IdSha1, mSalt, 1024, password, wrongPkcs12Zero: false, data), algID: new AlgorithmIdentifier(OiwObjectIdentifiers.IdSha1, DerNull.Instance)), mSalt, 1024);
		}
		new Pfx(contentInfo, macData).EncodeTo(stream, useDerEncoding ? "DER" : "BER");
	}

	internal static byte[] CalculatePbeMac(DerObjectIdentifier oid, byte[] salt, int itCount, char[] password, bool wrongPkcs12Zero, byte[] data)
	{
		Asn1Encodable asn1Params = PbeUtilities.GenerateAlgorithmParameters(oid, salt, itCount);
		ICipherParameters cipherParams = PbeUtilities.GenerateCipherParameters(oid, password, wrongPkcs12Zero, asn1Params);
		IMac obj = (IMac)PbeUtilities.CreateEngine(oid);
		obj.Init(cipherParams);
		return MacUtilities.DoFinal(obj, data);
	}

	private static byte[] CryptPbeData(bool forEncryption, AlgorithmIdentifier algId, char[] password, bool wrongPkcs12Zero, byte[] data)
	{
		if (!(PbeUtilities.CreateEngine(algId) is IBufferedCipher cipher))
		{
			throw new Exception("Unknown encryption algorithm: " + algId.Algorithm);
		}
		if (algId.Algorithm.Equals(PkcsObjectIdentifiers.IdPbeS2))
		{
			PbeS2Parameters pbeParameters = PbeS2Parameters.GetInstance(algId.Parameters);
			ICipherParameters cipherParams = PbeUtilities.GenerateCipherParameters(algId.Algorithm, password, pbeParameters);
			cipher.Init(forEncryption, cipherParams);
			return cipher.DoFinal(data);
		}
		Pkcs12PbeParams pbeParameters2 = Pkcs12PbeParams.GetInstance(algId.Parameters);
		ICipherParameters cipherParams2 = PbeUtilities.GenerateCipherParameters(algId.Algorithm, password, wrongPkcs12Zero, pbeParameters2);
		cipher.Init(forEncryption, cipherParams2);
		return cipher.DoFinal(data);
	}
}
