using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKey
{
	private static readonly int[] MasterKeyCertificationTypes = new int[5] { 19, 18, 17, 16, 31 };

	private long keyId;

	private byte[] fingerprint;

	private int keyStrength;

	internal PublicKeyPacket publicPk;

	internal TrustPacket trustPk;

	internal IList keySigs = Platform.CreateArrayList();

	internal IList ids = Platform.CreateArrayList();

	internal IList idTrusts = Platform.CreateArrayList();

	internal IList idSigs = Platform.CreateArrayList();

	internal IList subSigs;

	public int Version => publicPk.Version;

	public DateTime CreationTime => publicPk.GetTime();

	[Obsolete("Use 'GetValidSeconds' instead")]
	public int ValidDays
	{
		get
		{
			if (publicPk.Version <= 3)
			{
				return publicPk.ValidDays;
			}
			long expSecs = GetValidSeconds();
			if (expSecs <= 0)
			{
				return 0;
			}
			int days = (int)(expSecs / 86400);
			return System.Math.Max(1, days);
		}
	}

	public long KeyId => keyId;

	public bool IsEncryptionKey
	{
		get
		{
			switch (publicPk.Algorithm)
			{
			case PublicKeyAlgorithmTag.RsaGeneral:
			case PublicKeyAlgorithmTag.RsaEncrypt:
			case PublicKeyAlgorithmTag.ElGamalEncrypt:
			case PublicKeyAlgorithmTag.EC:
			case PublicKeyAlgorithmTag.ElGamalGeneral:
				return true;
			default:
				return false;
			}
		}
	}

	public bool IsMasterKey
	{
		get
		{
			if (subSigs == null)
			{
				if (IsEncryptionKey)
				{
					return publicPk.Algorithm == PublicKeyAlgorithmTag.RsaGeneral;
				}
				return true;
			}
			return false;
		}
	}

	public PublicKeyAlgorithmTag Algorithm => publicPk.Algorithm;

	public int BitStrength => keyStrength;

	public PublicKeyPacket PublicKeyPacket => publicPk;

	public static byte[] CalculateFingerprint(PublicKeyPacket publicPk)
	{
		IBcpgKey key = publicPk.Key;
		IDigest digest;
		if (publicPk.Version <= 3)
		{
			RsaPublicBcpgKey rK = (RsaPublicBcpgKey)key;
			try
			{
				digest = DigestUtilities.GetDigest("MD5");
				UpdateDigest(digest, rK.Modulus);
				UpdateDigest(digest, rK.PublicExponent);
			}
			catch (Exception ex)
			{
				throw new PgpException("can't encode key components: " + ex.Message, ex);
			}
		}
		else
		{
			try
			{
				byte[] kBytes = publicPk.GetEncodedContents();
				digest = DigestUtilities.GetDigest("SHA1");
				digest.Update(153);
				digest.Update((byte)(kBytes.Length >> 8));
				digest.Update((byte)kBytes.Length);
				digest.BlockUpdate(kBytes, 0, kBytes.Length);
			}
			catch (Exception ex2)
			{
				throw new PgpException("can't encode key components: " + ex2.Message, ex2);
			}
		}
		return DigestUtilities.DoFinal(digest);
	}

	private static void UpdateDigest(IDigest d, BigInteger b)
	{
		byte[] bytes = b.ToByteArrayUnsigned();
		d.BlockUpdate(bytes, 0, bytes.Length);
	}

	private void Init()
	{
		IBcpgKey key = publicPk.Key;
		fingerprint = CalculateFingerprint(publicPk);
		if (publicPk.Version <= 3)
		{
			RsaPublicBcpgKey rK = (RsaPublicBcpgKey)key;
			keyId = rK.Modulus.LongValue;
			keyStrength = rK.Modulus.BitLength;
			return;
		}
		keyId = (long)(((ulong)fingerprint[fingerprint.Length - 8] << 56) | ((ulong)fingerprint[fingerprint.Length - 7] << 48) | ((ulong)fingerprint[fingerprint.Length - 6] << 40) | ((ulong)fingerprint[fingerprint.Length - 5] << 32) | ((ulong)fingerprint[fingerprint.Length - 4] << 24) | ((ulong)fingerprint[fingerprint.Length - 3] << 16) | ((ulong)fingerprint[fingerprint.Length - 2] << 8) | fingerprint[fingerprint.Length - 1]);
		if (key is RsaPublicBcpgKey)
		{
			keyStrength = ((RsaPublicBcpgKey)key).Modulus.BitLength;
		}
		else if (key is DsaPublicBcpgKey)
		{
			keyStrength = ((DsaPublicBcpgKey)key).P.BitLength;
		}
		else if (key is ElGamalPublicBcpgKey)
		{
			keyStrength = ((ElGamalPublicBcpgKey)key).P.BitLength;
		}
		else if (key is ECPublicBcpgKey)
		{
			keyStrength = ECKeyPairGenerator.FindECCurveByOid(((ECPublicBcpgKey)key).CurveOid).Curve.FieldSize;
		}
	}

	public PgpPublicKey(PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, DateTime time)
	{
		if (pubKey.IsPrivate)
		{
			throw new ArgumentException("Expected a public key", "pubKey");
		}
		IBcpgKey bcpgKey;
		if (pubKey is RsaKeyParameters)
		{
			RsaKeyParameters rK = (RsaKeyParameters)pubKey;
			bcpgKey = new RsaPublicBcpgKey(rK.Modulus, rK.Exponent);
		}
		else if (pubKey is DsaPublicKeyParameters)
		{
			DsaPublicKeyParameters dK = (DsaPublicKeyParameters)pubKey;
			DsaParameters dP = dK.Parameters;
			bcpgKey = new DsaPublicBcpgKey(dP.P, dP.Q, dP.G, dK.Y);
		}
		else if (pubKey is ECPublicKeyParameters)
		{
			ECPublicKeyParameters ecK = (ECPublicKeyParameters)pubKey;
			bcpgKey = algorithm switch
			{
				PublicKeyAlgorithmTag.EC => new ECDHPublicBcpgKey(ecK.PublicKeyParamSet, ecK.Q, HashAlgorithmTag.Sha256, SymmetricKeyAlgorithmTag.Aes128), 
				PublicKeyAlgorithmTag.ECDsa => new ECDsaPublicBcpgKey(ecK.PublicKeyParamSet, ecK.Q), 
				_ => throw new PgpException("unknown EC algorithm"), 
			};
		}
		else
		{
			if (!(pubKey is ElGamalPublicKeyParameters))
			{
				throw new PgpException("unknown key class");
			}
			ElGamalPublicKeyParameters eK = (ElGamalPublicKeyParameters)pubKey;
			ElGamalParameters eS = eK.Parameters;
			bcpgKey = new ElGamalPublicBcpgKey(eS.P, eS.G, eK.Y);
		}
		publicPk = new PublicKeyPacket(algorithm, time, bcpgKey);
		ids = Platform.CreateArrayList();
		idSigs = Platform.CreateArrayList();
		try
		{
			Init();
		}
		catch (IOException exception)
		{
			throw new PgpException("exception calculating keyId", exception);
		}
	}

	public PgpPublicKey(PublicKeyPacket publicPk)
		: this(publicPk, Platform.CreateArrayList(), Platform.CreateArrayList())
	{
	}

	internal PgpPublicKey(PublicKeyPacket publicPk, TrustPacket trustPk, IList sigs)
	{
		this.publicPk = publicPk;
		this.trustPk = trustPk;
		subSigs = sigs;
		Init();
	}

	internal PgpPublicKey(PgpPublicKey key, TrustPacket trust, IList subSigs)
	{
		publicPk = key.publicPk;
		trustPk = trust;
		this.subSigs = subSigs;
		fingerprint = key.fingerprint;
		keyId = key.keyId;
		keyStrength = key.keyStrength;
	}

	internal PgpPublicKey(PgpPublicKey pubKey)
	{
		publicPk = pubKey.publicPk;
		keySigs = Platform.CreateArrayList(pubKey.keySigs);
		ids = Platform.CreateArrayList(pubKey.ids);
		idTrusts = Platform.CreateArrayList(pubKey.idTrusts);
		idSigs = Platform.CreateArrayList(pubKey.idSigs.Count);
		for (int i = 0; i != pubKey.idSigs.Count; i++)
		{
			idSigs.Add(Platform.CreateArrayList((IList)pubKey.idSigs[i]));
		}
		if (pubKey.subSigs != null)
		{
			subSigs = Platform.CreateArrayList(pubKey.subSigs.Count);
			for (int j = 0; j != pubKey.subSigs.Count; j++)
			{
				subSigs.Add(pubKey.subSigs[j]);
			}
		}
		fingerprint = pubKey.fingerprint;
		keyId = pubKey.keyId;
		keyStrength = pubKey.keyStrength;
	}

	internal PgpPublicKey(PublicKeyPacket publicPk, TrustPacket trustPk, IList keySigs, IList ids, IList idTrusts, IList idSigs)
	{
		this.publicPk = publicPk;
		this.trustPk = trustPk;
		this.keySigs = keySigs;
		this.ids = ids;
		this.idTrusts = idTrusts;
		this.idSigs = idSigs;
		Init();
	}

	internal PgpPublicKey(PublicKeyPacket publicPk, IList ids, IList idSigs)
	{
		this.publicPk = publicPk;
		this.ids = ids;
		this.idSigs = idSigs;
		Init();
	}

	public byte[] GetTrustData()
	{
		if (trustPk == null)
		{
			return null;
		}
		return Arrays.Clone(trustPk.GetLevelAndTrustAmount());
	}

	public long GetValidSeconds()
	{
		if (publicPk.Version <= 3)
		{
			return (long)publicPk.ValidDays * 86400L;
		}
		if (IsMasterKey)
		{
			for (int i = 0; i != MasterKeyCertificationTypes.Length; i++)
			{
				long seconds = GetExpirationTimeFromSig(selfSigned: true, MasterKeyCertificationTypes[i]);
				if (seconds >= 0)
				{
					return seconds;
				}
			}
		}
		else
		{
			long seconds2 = GetExpirationTimeFromSig(selfSigned: false, 24);
			if (seconds2 >= 0)
			{
				return seconds2;
			}
			seconds2 = GetExpirationTimeFromSig(selfSigned: false, 31);
			if (seconds2 >= 0)
			{
				return seconds2;
			}
		}
		return 0L;
	}

	private long GetExpirationTimeFromSig(bool selfSigned, int signatureType)
	{
		long expiryTime = -1L;
		long lastDate = -1L;
		foreach (PgpSignature sig in GetSignaturesOfType(signatureType))
		{
			if (selfSigned && sig.KeyId != KeyId)
			{
				continue;
			}
			PgpSignatureSubpacketVector hashed = sig.GetHashedSubPackets();
			if (hashed == null || !hashed.HasSubpacket(SignatureSubpacketTag.KeyExpireTime))
			{
				continue;
			}
			long current = hashed.GetKeyExpirationTime();
			if (sig.KeyId == KeyId)
			{
				if (sig.CreationTime.Ticks > lastDate)
				{
					lastDate = sig.CreationTime.Ticks;
					expiryTime = current;
				}
			}
			else if (current == 0L || current > expiryTime)
			{
				expiryTime = current;
			}
		}
		return expiryTime;
	}

	public byte[] GetFingerprint()
	{
		return (byte[])fingerprint.Clone();
	}

	public AsymmetricKeyParameter GetKey()
	{
		try
		{
			switch (publicPk.Algorithm)
			{
			case PublicKeyAlgorithmTag.RsaGeneral:
			case PublicKeyAlgorithmTag.RsaEncrypt:
			case PublicKeyAlgorithmTag.RsaSign:
			{
				RsaPublicBcpgKey rsaK = (RsaPublicBcpgKey)publicPk.Key;
				return new RsaKeyParameters(isPrivate: false, rsaK.Modulus, rsaK.PublicExponent);
			}
			case PublicKeyAlgorithmTag.Dsa:
			{
				DsaPublicBcpgKey dsaK = (DsaPublicBcpgKey)publicPk.Key;
				return new DsaPublicKeyParameters(dsaK.Y, new DsaParameters(dsaK.P, dsaK.Q, dsaK.G));
			}
			case PublicKeyAlgorithmTag.ECDsa:
				return GetECKey("ECDSA");
			case PublicKeyAlgorithmTag.EC:
				return GetECKey("ECDH");
			case PublicKeyAlgorithmTag.ElGamalEncrypt:
			case PublicKeyAlgorithmTag.ElGamalGeneral:
			{
				ElGamalPublicBcpgKey elK = (ElGamalPublicBcpgKey)publicPk.Key;
				return new ElGamalPublicKeyParameters(elK.Y, new ElGamalParameters(elK.P, elK.G));
			}
			default:
				throw new PgpException("unknown public key algorithm encountered");
			}
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("exception constructing public key", exception);
		}
	}

	private ECPublicKeyParameters GetECKey(string algorithm)
	{
		ECPublicBcpgKey ecK = (ECPublicBcpgKey)publicPk.Key;
		ECPoint q = ECKeyPairGenerator.FindECCurveByOid(ecK.CurveOid).Curve.DecodePoint(BigIntegers.AsUnsignedByteArray(ecK.EncodedPoint));
		return new ECPublicKeyParameters(algorithm, q, ecK.CurveOid);
	}

	public IEnumerable GetUserIds()
	{
		IList temp = Platform.CreateArrayList();
		foreach (object o in ids)
		{
			if (o is string)
			{
				temp.Add(o);
			}
		}
		return new EnumerableProxy(temp);
	}

	public IEnumerable GetUserAttributes()
	{
		IList temp = Platform.CreateArrayList();
		foreach (object o in ids)
		{
			if (o is PgpUserAttributeSubpacketVector)
			{
				temp.Add(o);
			}
		}
		return new EnumerableProxy(temp);
	}

	public IEnumerable GetSignaturesForId(string id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		IList signatures = Platform.CreateArrayList();
		bool userIdFound = false;
		for (int i = 0; i != ids.Count; i++)
		{
			if (id.Equals(ids[i]))
			{
				userIdFound = true;
				CollectionUtilities.AddRange(signatures, (IList)idSigs[i]);
			}
		}
		if (!userIdFound)
		{
			return null;
		}
		return signatures;
	}

	public IEnumerable GetSignaturesForUserAttribute(PgpUserAttributeSubpacketVector userAttributes)
	{
		if (userAttributes == null)
		{
			throw new ArgumentNullException("userAttributes");
		}
		IList signatures = Platform.CreateArrayList();
		bool attributeFound = false;
		for (int i = 0; i != ids.Count; i++)
		{
			if (userAttributes.Equals(ids[i]))
			{
				attributeFound = true;
				CollectionUtilities.AddRange(signatures, (IList)idSigs[i]);
			}
		}
		if (!attributeFound)
		{
			return null;
		}
		return signatures;
	}

	public IEnumerable GetSignaturesOfType(int signatureType)
	{
		IList temp = Platform.CreateArrayList();
		foreach (PgpSignature sig in GetSignatures())
		{
			if (sig.SignatureType == signatureType)
			{
				temp.Add(sig);
			}
		}
		return new EnumerableProxy(temp);
	}

	public IEnumerable GetSignatures()
	{
		IList sigs = subSigs;
		if (sigs == null)
		{
			sigs = Platform.CreateArrayList(keySigs);
			foreach (ICollection extraSigs in idSigs)
			{
				CollectionUtilities.AddRange(sigs, extraSigs);
			}
		}
		return new EnumerableProxy(sigs);
	}

	public IEnumerable GetKeySignatures()
	{
		IList sigs = subSigs;
		if (sigs == null)
		{
			sigs = Platform.CreateArrayList(keySigs);
		}
		return new EnumerableProxy(sigs);
	}

	public byte[] GetEncoded()
	{
		MemoryStream bOut = new MemoryStream();
		Encode(bOut);
		return bOut.ToArray();
	}

	public void Encode(Stream outStr)
	{
		BcpgOutputStream bcpgOut = BcpgOutputStream.Wrap(outStr);
		bcpgOut.WritePacket(publicPk);
		if (trustPk != null)
		{
			bcpgOut.WritePacket(trustPk);
		}
		if (subSigs == null)
		{
			foreach (PgpSignature keySig in keySigs)
			{
				keySig.Encode(bcpgOut);
			}
			for (int i = 0; i != ids.Count; i++)
			{
				if (ids[i] is string)
				{
					string id = (string)ids[i];
					bcpgOut.WritePacket(new UserIdPacket(id));
				}
				else
				{
					PgpUserAttributeSubpacketVector v = (PgpUserAttributeSubpacketVector)ids[i];
					bcpgOut.WritePacket(new UserAttributePacket(v.ToSubpacketArray()));
				}
				if (idTrusts[i] != null)
				{
					bcpgOut.WritePacket((ContainedPacket)idTrusts[i]);
				}
				foreach (PgpSignature item in (IList)idSigs[i])
				{
					item.Encode(bcpgOut);
				}
			}
			return;
		}
		foreach (PgpSignature subSig in subSigs)
		{
			subSig.Encode(bcpgOut);
		}
	}

	public bool IsRevoked()
	{
		int ns = 0;
		bool revoked = false;
		if (IsMasterKey)
		{
			while (!revoked && ns < keySigs.Count)
			{
				if (((PgpSignature)keySigs[ns++]).SignatureType == 32)
				{
					revoked = true;
				}
			}
		}
		else
		{
			while (!revoked && ns < subSigs.Count)
			{
				if (((PgpSignature)subSigs[ns++]).SignatureType == 40)
				{
					revoked = true;
				}
			}
		}
		return revoked;
	}

	public static PgpPublicKey AddCertification(PgpPublicKey key, string id, PgpSignature certification)
	{
		return AddCert(key, id, certification);
	}

	public static PgpPublicKey AddCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes, PgpSignature certification)
	{
		return AddCert(key, userAttributes, certification);
	}

	private static PgpPublicKey AddCert(PgpPublicKey key, object id, PgpSignature certification)
	{
		PgpPublicKey returnKey = new PgpPublicKey(key);
		IList sigList = null;
		for (int i = 0; i != returnKey.ids.Count; i++)
		{
			if (id.Equals(returnKey.ids[i]))
			{
				sigList = (IList)returnKey.idSigs[i];
			}
		}
		if (sigList != null)
		{
			sigList.Add(certification);
		}
		else
		{
			sigList = Platform.CreateArrayList();
			sigList.Add(certification);
			returnKey.ids.Add(id);
			returnKey.idTrusts.Add(null);
			returnKey.idSigs.Add(sigList);
		}
		return returnKey;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes)
	{
		return RemoveCert(key, userAttributes);
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, string id)
	{
		return RemoveCert(key, id);
	}

	private static PgpPublicKey RemoveCert(PgpPublicKey key, object id)
	{
		PgpPublicKey returnKey = new PgpPublicKey(key);
		bool found = false;
		for (int i = 0; i < returnKey.ids.Count; i++)
		{
			if (id.Equals(returnKey.ids[i]))
			{
				found = true;
				returnKey.ids.RemoveAt(i);
				returnKey.idTrusts.RemoveAt(i);
				returnKey.idSigs.RemoveAt(i);
			}
		}
		if (!found)
		{
			return null;
		}
		return returnKey;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, string id, PgpSignature certification)
	{
		return RemoveCert(key, id, certification);
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes, PgpSignature certification)
	{
		return RemoveCert(key, userAttributes, certification);
	}

	private static PgpPublicKey RemoveCert(PgpPublicKey key, object id, PgpSignature certification)
	{
		PgpPublicKey returnKey = new PgpPublicKey(key);
		bool found = false;
		for (int i = 0; i < returnKey.ids.Count; i++)
		{
			if (id.Equals(returnKey.ids[i]))
			{
				IList certs = (IList)returnKey.idSigs[i];
				found = certs.Contains(certification);
				if (found)
				{
					certs.Remove(certification);
				}
			}
		}
		if (!found)
		{
			return null;
		}
		return returnKey;
	}

	public static PgpPublicKey AddCertification(PgpPublicKey key, PgpSignature certification)
	{
		if (key.IsMasterKey)
		{
			if (certification.SignatureType == 40)
			{
				throw new ArgumentException("signature type incorrect for master key revocation.");
			}
		}
		else if (certification.SignatureType == 32)
		{
			throw new ArgumentException("signature type incorrect for sub-key revocation.");
		}
		PgpPublicKey returnKey = new PgpPublicKey(key);
		if (returnKey.subSigs != null)
		{
			returnKey.subSigs.Add(certification);
		}
		else
		{
			returnKey.keySigs.Add(certification);
		}
		return returnKey;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpSignature certification)
	{
		PgpPublicKey returnKey = new PgpPublicKey(key);
		IList sigs = ((returnKey.subSigs != null) ? returnKey.subSigs : returnKey.keySigs);
		int pos = sigs.IndexOf(certification);
		bool found = pos >= 0;
		if (found)
		{
			sigs.RemoveAt(pos);
		}
		else
		{
			foreach (string id in key.GetUserIds())
			{
				foreach (object sig in key.GetSignaturesForId(id))
				{
					if (certification == sig)
					{
						found = true;
						returnKey = RemoveCertification(returnKey, id, certification);
					}
				}
			}
			if (!found)
			{
				foreach (PgpUserAttributeSubpacketVector id2 in key.GetUserAttributes())
				{
					foreach (object sig2 in key.GetSignaturesForUserAttribute(id2))
					{
						if (certification == sig2)
						{
							found = true;
							returnKey = RemoveCertification(returnKey, id2, certification);
						}
					}
				}
			}
		}
		return returnKey;
	}
}
