using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKeyRing : PgpKeyRing
{
	private readonly IList keys;

	public PgpPublicKeyRing(byte[] encoding)
		: this(new MemoryStream(encoding, writable: false))
	{
	}

	internal PgpPublicKeyRing(IList pubKeys)
	{
		keys = pubKeys;
	}

	public PgpPublicKeyRing(Stream inputStream)
	{
		keys = Platform.CreateArrayList();
		BcpgInputStream bcpgInput = BcpgInputStream.Wrap(inputStream);
		PacketTag initialTag = bcpgInput.SkipMarkerPackets();
		if (initialTag != PacketTag.PublicKey && initialTag != PacketTag.PublicSubkey)
		{
			int num = (int)initialTag;
			throw new IOException("public key ring doesn't start with public key tag: tag 0x" + num.ToString("X"));
		}
		PublicKeyPacket pubPk = ReadPublicKeyPacket(bcpgInput);
		TrustPacket trustPk = PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
		IList keySigs = PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
		PgpKeyRing.ReadUserIDs(bcpgInput, out var ids, out var idTrusts, out var idSigs);
		keys.Add(new PgpPublicKey(pubPk, trustPk, keySigs, ids, idTrusts, idSigs));
		while (bcpgInput.NextPacketTag() == PacketTag.PublicSubkey)
		{
			keys.Add(ReadSubkey(bcpgInput));
		}
	}

	public virtual PgpPublicKey GetPublicKey()
	{
		return (PgpPublicKey)keys[0];
	}

	public virtual PgpPublicKey GetPublicKey(long keyId)
	{
		foreach (PgpPublicKey k in keys)
		{
			if (keyId == k.KeyId)
			{
				return k;
			}
		}
		return null;
	}

	public virtual IEnumerable GetPublicKeys()
	{
		return new EnumerableProxy(keys);
	}

	public virtual byte[] GetEncoded()
	{
		MemoryStream bOut = new MemoryStream();
		Encode(bOut);
		return bOut.ToArray();
	}

	public virtual void Encode(Stream outStr)
	{
		if (outStr == null)
		{
			throw new ArgumentNullException("outStr");
		}
		foreach (PgpPublicKey key in keys)
		{
			key.Encode(outStr);
		}
	}

	public static PgpPublicKeyRing InsertPublicKey(PgpPublicKeyRing pubRing, PgpPublicKey pubKey)
	{
		IList keys = Platform.CreateArrayList(pubRing.keys);
		bool found = false;
		bool masterFound = false;
		for (int i = 0; i != keys.Count; i++)
		{
			PgpPublicKey obj = (PgpPublicKey)keys[i];
			if (obj.KeyId == pubKey.KeyId)
			{
				found = true;
				keys[i] = pubKey;
			}
			if (obj.IsMasterKey)
			{
				masterFound = true;
			}
		}
		if (!found)
		{
			if (pubKey.IsMasterKey)
			{
				if (masterFound)
				{
					throw new ArgumentException("cannot add a master key to a ring that already has one");
				}
				keys.Insert(0, pubKey);
			}
			else
			{
				keys.Add(pubKey);
			}
		}
		return new PgpPublicKeyRing(keys);
	}

	public static PgpPublicKeyRing RemovePublicKey(PgpPublicKeyRing pubRing, PgpPublicKey pubKey)
	{
		IList keys = Platform.CreateArrayList(pubRing.keys);
		bool found = false;
		for (int i = 0; i < keys.Count; i++)
		{
			if (((PgpPublicKey)keys[i]).KeyId == pubKey.KeyId)
			{
				found = true;
				keys.RemoveAt(i);
			}
		}
		if (!found)
		{
			return null;
		}
		return new PgpPublicKeyRing(keys);
	}

	internal static PublicKeyPacket ReadPublicKeyPacket(BcpgInputStream bcpgInput)
	{
		Packet packet = bcpgInput.ReadPacket();
		if (!(packet is PublicKeyPacket))
		{
			throw new IOException("unexpected packet in stream: " + packet);
		}
		return (PublicKeyPacket)packet;
	}

	internal static PgpPublicKey ReadSubkey(BcpgInputStream bcpgInput)
	{
		PublicKeyPacket publicPk = ReadPublicKeyPacket(bcpgInput);
		TrustPacket kTrust = PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
		IList sigList = PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
		return new PgpPublicKey(publicPk, kTrust, sigList);
	}
}
