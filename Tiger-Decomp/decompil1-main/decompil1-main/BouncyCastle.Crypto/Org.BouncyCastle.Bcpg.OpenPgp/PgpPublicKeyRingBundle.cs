using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKeyRingBundle
{
	private readonly IDictionary pubRings;

	private readonly IList order;

	[Obsolete("Use 'Count' property instead")]
	public int Size => order.Count;

	public int Count => order.Count;

	private PgpPublicKeyRingBundle(IDictionary pubRings, IList order)
	{
		this.pubRings = pubRings;
		this.order = order;
	}

	public PgpPublicKeyRingBundle(byte[] encoding)
		: this(new MemoryStream(encoding, writable: false))
	{
	}

	public PgpPublicKeyRingBundle(Stream inputStream)
		: this(new PgpObjectFactory(inputStream).AllPgpObjects())
	{
	}

	public PgpPublicKeyRingBundle(IEnumerable e)
	{
		pubRings = Platform.CreateHashtable();
		order = Platform.CreateArrayList();
		foreach (object obj in e)
		{
			if (!(obj is PgpMarker))
			{
				if (!(obj is PgpPublicKeyRing pgpPub))
				{
					throw new PgpException(Platform.GetTypeName(obj) + " found where PgpPublicKeyRing expected");
				}
				long key = pgpPub.GetPublicKey().KeyId;
				pubRings.Add(key, pgpPub);
				order.Add(key);
			}
		}
	}

	public IEnumerable GetKeyRings()
	{
		return new EnumerableProxy(pubRings.Values);
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
		foreach (PgpPublicKeyRing pubRing in GetKeyRings())
		{
			foreach (string userId2 in pubRing.GetPublicKey().GetUserIds())
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
						rings.Add(pubRing);
					}
				}
				else if (next.Equals(userId))
				{
					rings.Add(pubRing);
				}
			}
		}
		return new EnumerableProxy(rings);
	}

	public PgpPublicKey GetPublicKey(long keyId)
	{
		foreach (PgpPublicKeyRing keyRing in GetKeyRings())
		{
			PgpPublicKey pub = keyRing.GetPublicKey(keyId);
			if (pub != null)
			{
				return pub;
			}
		}
		return null;
	}

	public PgpPublicKeyRing GetPublicKeyRing(long keyId)
	{
		if (pubRings.Contains(keyId))
		{
			return (PgpPublicKeyRing)pubRings[keyId];
		}
		foreach (PgpPublicKeyRing pubRing in GetKeyRings())
		{
			if (pubRing.GetPublicKey(keyId) != null)
			{
				return pubRing;
			}
		}
		return null;
	}

	public bool Contains(long keyID)
	{
		return GetPublicKey(keyID) != null;
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
			((PgpPublicKeyRing)pubRings[key]).Encode(bcpgOut);
		}
	}

	public static PgpPublicKeyRingBundle AddPublicKeyRing(PgpPublicKeyRingBundle bundle, PgpPublicKeyRing publicKeyRing)
	{
		long key = publicKeyRing.GetPublicKey().KeyId;
		if (bundle.pubRings.Contains(key))
		{
			throw new ArgumentException("Bundle already contains a key with a keyId for the passed in ring.");
		}
		IDictionary dictionary = Platform.CreateHashtable(bundle.pubRings);
		IList newOrder = Platform.CreateArrayList(bundle.order);
		dictionary[key] = publicKeyRing;
		newOrder.Add(key);
		return new PgpPublicKeyRingBundle(dictionary, newOrder);
	}

	public static PgpPublicKeyRingBundle RemovePublicKeyRing(PgpPublicKeyRingBundle bundle, PgpPublicKeyRing publicKeyRing)
	{
		long key = publicKeyRing.GetPublicKey().KeyId;
		if (!bundle.pubRings.Contains(key))
		{
			throw new ArgumentException("Bundle does not contain a key with a keyId for the passed in ring.");
		}
		IDictionary dictionary = Platform.CreateHashtable(bundle.pubRings);
		IList newOrder = Platform.CreateArrayList(bundle.order);
		dictionary.Remove(key);
		newOrder.Remove(key);
		return new PgpPublicKeyRingBundle(dictionary, newOrder);
	}
}
