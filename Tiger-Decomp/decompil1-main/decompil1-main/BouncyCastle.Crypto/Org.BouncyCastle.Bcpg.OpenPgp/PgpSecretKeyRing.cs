using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpSecretKeyRing : PgpKeyRing
{
	private readonly IList keys;

	private readonly IList extraPubKeys;

	internal PgpSecretKeyRing(IList keys)
		: this(keys, Platform.CreateArrayList())
	{
	}

	private PgpSecretKeyRing(IList keys, IList extraPubKeys)
	{
		this.keys = keys;
		this.extraPubKeys = extraPubKeys;
	}

	public PgpSecretKeyRing(byte[] encoding)
		: this(new MemoryStream(encoding))
	{
	}

	public PgpSecretKeyRing(Stream inputStream)
	{
		keys = Platform.CreateArrayList();
		extraPubKeys = Platform.CreateArrayList();
		BcpgInputStream bcpgInput = BcpgInputStream.Wrap(inputStream);
		PacketTag initialTag = bcpgInput.SkipMarkerPackets();
		if (initialTag != PacketTag.SecretKey && initialTag != PacketTag.SecretSubkey)
		{
			int num = (int)initialTag;
			throw new IOException("secret key ring doesn't start with secret key tag: tag 0x" + num.ToString("X"));
		}
		SecretKeyPacket secret = (SecretKeyPacket)bcpgInput.ReadPacket();
		while (bcpgInput.NextPacketTag() == PacketTag.Experimental2)
		{
			bcpgInput.ReadPacket();
		}
		TrustPacket trust = PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
		IList keySigs = PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
		PgpKeyRing.ReadUserIDs(bcpgInput, out var ids, out var idTrusts, out var idSigs);
		keys.Add(new PgpSecretKey(secret, new PgpPublicKey(secret.PublicKeyPacket, trust, keySigs, ids, idTrusts, idSigs)));
		while (bcpgInput.NextPacketTag() == PacketTag.SecretSubkey || bcpgInput.NextPacketTag() == PacketTag.PublicSubkey)
		{
			if (bcpgInput.NextPacketTag() == PacketTag.SecretSubkey)
			{
				SecretSubkeyPacket sub = (SecretSubkeyPacket)bcpgInput.ReadPacket();
				while (bcpgInput.NextPacketTag() == PacketTag.Experimental2)
				{
					bcpgInput.ReadPacket();
				}
				TrustPacket subTrust = PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
				IList sigList = PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
				keys.Add(new PgpSecretKey(sub, new PgpPublicKey(sub.PublicKeyPacket, subTrust, sigList)));
			}
			else
			{
				PublicSubkeyPacket sub2 = (PublicSubkeyPacket)bcpgInput.ReadPacket();
				TrustPacket subTrust2 = PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
				IList sigList2 = PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
				extraPubKeys.Add(new PgpPublicKey(sub2, subTrust2, sigList2));
			}
		}
	}

	public PgpPublicKey GetPublicKey()
	{
		return ((PgpSecretKey)keys[0]).PublicKey;
	}

	public PgpSecretKey GetSecretKey()
	{
		return (PgpSecretKey)keys[0];
	}

	public IEnumerable GetSecretKeys()
	{
		return new EnumerableProxy(keys);
	}

	public PgpSecretKey GetSecretKey(long keyId)
	{
		foreach (PgpSecretKey k in keys)
		{
			if (keyId == k.KeyId)
			{
				return k;
			}
		}
		return null;
	}

	public IEnumerable GetExtraPublicKeys()
	{
		return new EnumerableProxy(extraPubKeys);
	}

	public byte[] GetEncoded()
	{
		MemoryStream bOut = new MemoryStream();
		Encode(bOut);
		return bOut.ToArray();
	}

	public void Encode(Stream outStr)
	{
		if (outStr == null)
		{
			throw new ArgumentNullException("outStr");
		}
		foreach (PgpSecretKey key in keys)
		{
			key.Encode(outStr);
		}
		foreach (PgpPublicKey extraPubKey in extraPubKeys)
		{
			extraPubKey.Encode(outStr);
		}
	}

	public static PgpSecretKeyRing ReplacePublicKeys(PgpSecretKeyRing secretRing, PgpPublicKeyRing publicRing)
	{
		IList newList = Platform.CreateArrayList(secretRing.keys.Count);
		foreach (PgpSecretKey sk in secretRing.keys)
		{
			PgpPublicKey pk = publicRing.GetPublicKey(sk.KeyId);
			newList.Add(PgpSecretKey.ReplacePublicKey(sk, pk));
		}
		return new PgpSecretKeyRing(newList);
	}

	public static PgpSecretKeyRing CopyWithNewPassword(PgpSecretKeyRing ring, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
	{
		IList newKeys = Platform.CreateArrayList(ring.keys.Count);
		foreach (PgpSecretKey secretKey in ring.GetSecretKeys())
		{
			if (secretKey.IsPrivateKeyEmpty)
			{
				newKeys.Add(secretKey);
			}
			else
			{
				newKeys.Add(PgpSecretKey.CopyWithNewPassword(secretKey, oldPassPhrase, newPassPhrase, newEncAlgorithm, rand));
			}
		}
		return new PgpSecretKeyRing(newKeys, ring.extraPubKeys);
	}

	public static PgpSecretKeyRing InsertSecretKey(PgpSecretKeyRing secRing, PgpSecretKey secKey)
	{
		IList keys = Platform.CreateArrayList(secRing.keys);
		bool found = false;
		bool masterFound = false;
		for (int i = 0; i != keys.Count; i++)
		{
			PgpSecretKey obj = (PgpSecretKey)keys[i];
			if (obj.KeyId == secKey.KeyId)
			{
				found = true;
				keys[i] = secKey;
			}
			if (obj.IsMasterKey)
			{
				masterFound = true;
			}
		}
		if (!found)
		{
			if (secKey.IsMasterKey)
			{
				if (masterFound)
				{
					throw new ArgumentException("cannot add a master key to a ring that already has one");
				}
				keys.Insert(0, secKey);
			}
			else
			{
				keys.Add(secKey);
			}
		}
		return new PgpSecretKeyRing(keys, secRing.extraPubKeys);
	}

	public static PgpSecretKeyRing RemoveSecretKey(PgpSecretKeyRing secRing, PgpSecretKey secKey)
	{
		IList keys = Platform.CreateArrayList(secRing.keys);
		bool found = false;
		for (int i = 0; i < keys.Count; i++)
		{
			if (((PgpSecretKey)keys[i]).KeyId == secKey.KeyId)
			{
				found = true;
				keys.RemoveAt(i);
			}
		}
		if (!found)
		{
			return null;
		}
		return new PgpSecretKeyRing(keys, secRing.extraPubKeys);
	}
}
