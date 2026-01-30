using System;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignatureGenerator
{
	private static readonly SignatureSubpacket[] EmptySignatureSubpackets = new SignatureSubpacket[0];

	private PublicKeyAlgorithmTag keyAlgorithm;

	private HashAlgorithmTag hashAlgorithm;

	private PgpPrivateKey privKey;

	private ISigner sig;

	private IDigest dig;

	private int signatureType;

	private byte lastb;

	private SignatureSubpacket[] unhashed = EmptySignatureSubpackets;

	private SignatureSubpacket[] hashed = EmptySignatureSubpackets;

	public PgpSignatureGenerator(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
	{
		this.keyAlgorithm = keyAlgorithm;
		this.hashAlgorithm = hashAlgorithm;
		dig = DigestUtilities.GetDigest(PgpUtilities.GetDigestName(hashAlgorithm));
		sig = SignerUtilities.GetSigner(PgpUtilities.GetSignatureName(keyAlgorithm, hashAlgorithm));
	}

	public void InitSign(int sigType, PgpPrivateKey key)
	{
		InitSign(sigType, key, null);
	}

	public void InitSign(int sigType, PgpPrivateKey key, SecureRandom random)
	{
		privKey = key;
		signatureType = sigType;
		try
		{
			ICipherParameters cp = key.Key;
			if (random != null)
			{
				cp = new ParametersWithRandom(key.Key, random);
			}
			sig.Init(forSigning: true, cp);
		}
		catch (InvalidKeyException exception)
		{
			throw new PgpException("invalid key.", exception);
		}
		dig.Reset();
		lastb = 0;
	}

	public void Update(byte b)
	{
		if (signatureType == 1)
		{
			doCanonicalUpdateByte(b);
		}
		else
		{
			doUpdateByte(b);
		}
	}

	private void doCanonicalUpdateByte(byte b)
	{
		switch (b)
		{
		case 13:
			doUpdateCRLF();
			break;
		case 10:
			if (lastb != 13)
			{
				doUpdateCRLF();
			}
			break;
		default:
			doUpdateByte(b);
			break;
		}
		lastb = b;
	}

	private void doUpdateCRLF()
	{
		doUpdateByte(13);
		doUpdateByte(10);
	}

	private void doUpdateByte(byte b)
	{
		sig.Update(b);
		dig.Update(b);
	}

	public void Update(params byte[] b)
	{
		Update(b, 0, b.Length);
	}

	public void Update(byte[] b, int off, int len)
	{
		if (signatureType == 1)
		{
			int finish = off + len;
			for (int i = off; i != finish; i++)
			{
				doCanonicalUpdateByte(b[i]);
			}
		}
		else
		{
			sig.BlockUpdate(b, off, len);
			dig.BlockUpdate(b, off, len);
		}
	}

	public void SetHashedSubpackets(PgpSignatureSubpacketVector hashedPackets)
	{
		hashed = ((hashedPackets == null) ? EmptySignatureSubpackets : hashedPackets.ToSubpacketArray());
	}

	public void SetUnhashedSubpackets(PgpSignatureSubpacketVector unhashedPackets)
	{
		unhashed = ((unhashedPackets == null) ? EmptySignatureSubpackets : unhashedPackets.ToSubpacketArray());
	}

	public PgpOnePassSignature GenerateOnePassVersion(bool isNested)
	{
		return new PgpOnePassSignature(new OnePassSignaturePacket(signatureType, hashAlgorithm, keyAlgorithm, privKey.KeyId, isNested));
	}

	public PgpSignature Generate()
	{
		SignatureSubpacket[] hPkts = hashed;
		SignatureSubpacket[] unhPkts = unhashed;
		if (!packetPresent(hashed, SignatureSubpacketTag.CreationTime))
		{
			hPkts = insertSubpacket(hPkts, new SignatureCreationTime(critical: false, DateTime.UtcNow));
		}
		if (!packetPresent(hashed, SignatureSubpacketTag.IssuerKeyId) && !packetPresent(unhashed, SignatureSubpacketTag.IssuerKeyId))
		{
			unhPkts = insertSubpacket(unhPkts, new IssuerKeyId(critical: false, privKey.KeyId));
		}
		int version = 4;
		byte[] hData;
		try
		{
			MemoryStream hOut = new MemoryStream();
			for (int i = 0; i != hPkts.Length; i++)
			{
				hPkts[i].Encode(hOut);
			}
			byte[] data = hOut.ToArray();
			MemoryStream memoryStream = new MemoryStream(data.Length + 6);
			memoryStream.WriteByte((byte)version);
			memoryStream.WriteByte((byte)signatureType);
			memoryStream.WriteByte((byte)keyAlgorithm);
			memoryStream.WriteByte((byte)hashAlgorithm);
			memoryStream.WriteByte((byte)(data.Length >> 8));
			memoryStream.WriteByte((byte)data.Length);
			memoryStream.Write(data, 0, data.Length);
			hData = memoryStream.ToArray();
		}
		catch (IOException exception)
		{
			throw new PgpException("exception encoding hashed data.", exception);
		}
		sig.BlockUpdate(hData, 0, hData.Length);
		dig.BlockUpdate(hData, 0, hData.Length);
		hData = new byte[6]
		{
			(byte)version,
			255,
			(byte)(hData.Length >> 24),
			(byte)(hData.Length >> 16),
			(byte)(hData.Length >> 8),
			(byte)hData.Length
		};
		sig.BlockUpdate(hData, 0, hData.Length);
		dig.BlockUpdate(hData, 0, hData.Length);
		byte[] sigBytes = sig.GenerateSignature();
		byte[] digest = DigestUtilities.DoFinal(dig);
		byte[] fingerPrint = new byte[2]
		{
			digest[0],
			digest[1]
		};
		MPInteger[] sigValues = ((keyAlgorithm == PublicKeyAlgorithmTag.RsaSign || keyAlgorithm == PublicKeyAlgorithmTag.RsaGeneral) ? PgpUtilities.RsaSigToMpi(sigBytes) : PgpUtilities.DsaSigToMpi(sigBytes));
		return new PgpSignature(new SignaturePacket(signatureType, privKey.KeyId, keyAlgorithm, hashAlgorithm, hPkts, unhPkts, fingerPrint, sigValues));
	}

	public PgpSignature GenerateCertification(string id, PgpPublicKey pubKey)
	{
		UpdateWithPublicKey(pubKey);
		UpdateWithIdData(180, Strings.ToUtf8ByteArray(id));
		return Generate();
	}

	public PgpSignature GenerateCertification(PgpUserAttributeSubpacketVector userAttributes, PgpPublicKey pubKey)
	{
		UpdateWithPublicKey(pubKey);
		try
		{
			MemoryStream bOut = new MemoryStream();
			UserAttributeSubpacket[] array = userAttributes.ToSubpacketArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Encode(bOut);
			}
			UpdateWithIdData(209, bOut.ToArray());
		}
		catch (IOException exception)
		{
			throw new PgpException("cannot encode subpacket array", exception);
		}
		return Generate();
	}

	public PgpSignature GenerateCertification(PgpPublicKey masterKey, PgpPublicKey pubKey)
	{
		UpdateWithPublicKey(masterKey);
		UpdateWithPublicKey(pubKey);
		return Generate();
	}

	public PgpSignature GenerateCertification(PgpPublicKey pubKey)
	{
		UpdateWithPublicKey(pubKey);
		return Generate();
	}

	private byte[] GetEncodedPublicKey(PgpPublicKey pubKey)
	{
		try
		{
			return pubKey.publicPk.GetEncodedContents();
		}
		catch (IOException exception)
		{
			throw new PgpException("exception preparing key.", exception);
		}
	}

	private bool packetPresent(SignatureSubpacket[] packets, SignatureSubpacketTag type)
	{
		for (int i = 0; i != packets.Length; i++)
		{
			if (packets[i].SubpacketType == type)
			{
				return true;
			}
		}
		return false;
	}

	private SignatureSubpacket[] insertSubpacket(SignatureSubpacket[] packets, SignatureSubpacket subpacket)
	{
		SignatureSubpacket[] tmp = new SignatureSubpacket[packets.Length + 1];
		tmp[0] = subpacket;
		packets.CopyTo(tmp, 1);
		return tmp;
	}

	private void UpdateWithIdData(int header, byte[] idBytes)
	{
		Update((byte)header, (byte)(idBytes.Length >> 24), (byte)(idBytes.Length >> 16), (byte)(idBytes.Length >> 8), (byte)idBytes.Length);
		Update(idBytes);
	}

	private void UpdateWithPublicKey(PgpPublicKey key)
	{
		byte[] keyBytes = GetEncodedPublicKey(key);
		Update(153, (byte)(keyBytes.Length >> 8), (byte)keyBytes.Length);
		Update(keyBytes);
	}
}
