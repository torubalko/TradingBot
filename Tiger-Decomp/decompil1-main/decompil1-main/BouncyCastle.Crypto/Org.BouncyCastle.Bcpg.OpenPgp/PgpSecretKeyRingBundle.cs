using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpSecretKeyRingBundle
{
	private readonly IDictionary secretRings;

	private readonly IList order;

	[Obsolete("Use 'Count' property instead")]
	public int Size => order.Count;

	public int Count => order.Count;

	private PgpSecretKeyRingBundle(IDictionary secretRings, IList order)
	{
		this.secretRings = secretRings;
		this.order = order;
	}

	public PgpSecretKeyRingBundle(byte[] encoding)
		: this(new MemoryStream(encoding, writable: false))
	{
	}

	public PgpSecretKeyRingBundle(Stream inputStream)
		: this(new PgpObjectFactory(inputStream).AllPgpObjects())
	{
	}

	public PgpSecretKeyRingBundle(IEnumerable e)
	{
		secretRings = Platform.CreateHashtable();
		order = Platform.CreateArrayList();
		foreach (object obj in e)
		{
			if (!(obj is PgpMarker))
			{
				if (!(obj is PgpSecretKeyRing pgpSecret))
				{
					throw new PgpException(Platform.GetTypeName(obj) + " found where PgpSecretKeyRing expected");
				}
				long key = pgpSecret.GetPublicKey().KeyId;
				secretRings.Add(key, pgpSecret);
				order.Add(key);
			}
		}
	}

	public IEnumerable GetKeyRings()
	{
		return new EnumerableProxy(secretRings.Values);
	}

	public IEnumerable GetKeyRings(string userId)
	{
		return GetKeyRings(userId, matchPartial: false, ignoreCase: false);
	}

	public IEnumerable GetKeyRings(string userId, bool matchPartial)
	{
		return GetKeyRings(userId, matchPartial, ignoreCase: false);
	}

	public IEnumerable GetKeyRings(string userId, bool matchPartial, bool ignoreCase)
	{
		IList rings = Platform.CreateArrayList();
		if (ignoreCase)
		{
			userId = Platform.ToUpperInvariant(userId);
		}
		foreach (PgpSecretKeyRing secRing in GetKeyRings())
		{
			foreach (string userId2 in secRing.GetSecretKey().UserIds)
			{
				string next = userId2;
				if (ignoreCase)
				{
					next = Platform.ToUpperInvariant(next);
				}
				if (matchPartial)
				{
					if (Platform.IndexOf(next, userId) > -1)
					{
						rings.Add(secRing);
					}
				}
				else if (next.Equals(userId))
				{
					rings.Add(secRing);
				}
			}
		}
		return new EnumerableProxy(rings);
	}

	public PgpSecretKey GetSecretKey(long keyId)
	{
		foreach (PgpSecretKeyRing keyRing in GetKeyRings())
		{
			PgpSecretKey sec = keyRing.GetSecretKey(keyId);
			if (sec != null)
			{
				return sec;
			}
		}
		return null;
	}

	public PgpSecretKeyRing GetSecretKeyRing(long keyId)
	{
		if (secretRings.Contains(keyId))
		{
			return (PgpSecretKeyRing)secretRings[keyId];
		}
		foreach (PgpSecretKeyRing secretRing in GetKeyRings())
		{
			if (secretRing.GetSecretKey(keyId) != null)
			{
				return secretRing;
			}
		}
		return null;
	}

	public bool Contains(long keyID)
	{
		return GetSecretKey(keyID) != null;
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
		foreach (long key in order)
		{
			((PgpSecretKeyRing)secretRings[key]).Encode(bcpgOut);
		}
	}

	public static PgpSecretKeyRingBundle AddSecretKeyRing(PgpSecretKeyRingBundle bundle, PgpSecretKeyRing secretKeyRing)
	{
		long key = secretKeyRing.GetPublicKey().KeyId;
		if (bundle.secretRings.Contains(key))
		{
			throw new ArgumentException("Collection already contains a key with a keyId for the passed in ring.");
		}
		IDictionary dictionary = Platform.CreateHashtable(bundle.secretRings);
		IList newOrder = Platform.CreateArrayList(bundle.order);
		dictionary[key] = secretKeyRing;
		newOrder.Add(key);
		return new PgpSecretKeyRingBundle(dictionary, newOrder);
	}

	public static PgpSecretKeyRingBundle RemoveSecretKeyRing(PgpSecretKeyRingBundle bundle, PgpSecretKeyRing secretKeyRing)
	{
		long key = secretKeyRing.GetPublicKey().KeyId;
		if (!bundle.secretRings.Contains(key))
		{
			throw new ArgumentException("Collection does not contain a key with a keyId for the passed in ring.");
		}
		IDictionary dictionary = Platform.CreateHashtable(bundle.secretRings);
		IList newOrder = Platform.CreateArrayList(bundle.order);
		dictionary.Remove(key);
		newOrder.Remove(key);
		return new PgpSecretKeyRingBundle(dictionary, newOrder);
	}
}
