using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg;

public class SignaturePacket : ContainedPacket
{
	private int version;

	private int signatureType;

	private long creationTime;

	private long keyId;

	private PublicKeyAlgorithmTag keyAlgorithm;

	private HashAlgorithmTag hashAlgorithm;

	private MPInteger[] signature;

	private byte[] fingerprint;

	private SignatureSubpacket[] hashedData;

	private SignatureSubpacket[] unhashedData;

	private byte[] signatureEncoding;

	public int Version => version;

	public int SignatureType => signatureType;

	public long KeyId => keyId;

	public PublicKeyAlgorithmTag KeyAlgorithm => keyAlgorithm;

	public HashAlgorithmTag HashAlgorithm => hashAlgorithm;

	public long CreationTime => creationTime;

	internal SignaturePacket(BcpgInputStream bcpgIn)
	{
		version = bcpgIn.ReadByte();
		if (version == 3 || version == 2)
		{
			bcpgIn.ReadByte();
			signatureType = bcpgIn.ReadByte();
			creationTime = (((long)bcpgIn.ReadByte() << 24) | ((long)bcpgIn.ReadByte() << 16) | ((long)bcpgIn.ReadByte() << 8) | (uint)bcpgIn.ReadByte()) * 1000;
			keyId |= (long)bcpgIn.ReadByte() << 56;
			keyId |= (long)bcpgIn.ReadByte() << 48;
			keyId |= (long)bcpgIn.ReadByte() << 40;
			keyId |= (long)bcpgIn.ReadByte() << 32;
			keyId |= (long)bcpgIn.ReadByte() << 24;
			keyId |= (long)bcpgIn.ReadByte() << 16;
			keyId |= (long)bcpgIn.ReadByte() << 8;
			keyId |= (uint)bcpgIn.ReadByte();
			keyAlgorithm = (PublicKeyAlgorithmTag)bcpgIn.ReadByte();
			hashAlgorithm = (HashAlgorithmTag)bcpgIn.ReadByte();
		}
		else
		{
			if (version != 4)
			{
				Streams.Drain(bcpgIn);
				throw new UnsupportedPacketVersionException("unsupported version: " + version);
			}
			signatureType = bcpgIn.ReadByte();
			keyAlgorithm = (PublicKeyAlgorithmTag)bcpgIn.ReadByte();
			hashAlgorithm = (HashAlgorithmTag)bcpgIn.ReadByte();
			byte[] hashed = new byte[(bcpgIn.ReadByte() << 8) | bcpgIn.ReadByte()];
			bcpgIn.ReadFully(hashed);
			SignatureSubpacketsParser sIn = new SignatureSubpacketsParser(new MemoryStream(hashed, writable: false));
			IList v = Platform.CreateArrayList();
			SignatureSubpacket sub;
			while ((sub = sIn.ReadPacket()) != null)
			{
				v.Add(sub);
			}
			hashedData = new SignatureSubpacket[v.Count];
			for (int i = 0; i != hashedData.Length; i++)
			{
				SignatureSubpacket p = (SignatureSubpacket)v[i];
				if (p is IssuerKeyId)
				{
					keyId = ((IssuerKeyId)p).KeyId;
				}
				else if (p is SignatureCreationTime)
				{
					creationTime = DateTimeUtilities.DateTimeToUnixMs(((SignatureCreationTime)p).GetTime());
				}
				hashedData[i] = p;
			}
			byte[] unhashed = new byte[(bcpgIn.ReadByte() << 8) | bcpgIn.ReadByte()];
			bcpgIn.ReadFully(unhashed);
			sIn = new SignatureSubpacketsParser(new MemoryStream(unhashed, writable: false));
			v.Clear();
			while ((sub = sIn.ReadPacket()) != null)
			{
				v.Add(sub);
			}
			unhashedData = new SignatureSubpacket[v.Count];
			for (int j = 0; j != unhashedData.Length; j++)
			{
				SignatureSubpacket p2 = (SignatureSubpacket)v[j];
				if (p2 is IssuerKeyId)
				{
					keyId = ((IssuerKeyId)p2).KeyId;
				}
				unhashedData[j] = p2;
			}
		}
		fingerprint = new byte[2];
		bcpgIn.ReadFully(fingerprint);
		switch (keyAlgorithm)
		{
		case PublicKeyAlgorithmTag.RsaGeneral:
		case PublicKeyAlgorithmTag.RsaSign:
		{
			MPInteger v2 = new MPInteger(bcpgIn);
			signature = new MPInteger[1] { v2 };
			return;
		}
		case PublicKeyAlgorithmTag.Dsa:
		{
			MPInteger r = new MPInteger(bcpgIn);
			MPInteger s = new MPInteger(bcpgIn);
			signature = new MPInteger[2] { r, s };
			return;
		}
		case PublicKeyAlgorithmTag.ElGamalEncrypt:
		case PublicKeyAlgorithmTag.ElGamalGeneral:
		{
			MPInteger p3 = new MPInteger(bcpgIn);
			MPInteger g = new MPInteger(bcpgIn);
			MPInteger y = new MPInteger(bcpgIn);
			signature = new MPInteger[3] { p3, g, y };
			return;
		}
		case PublicKeyAlgorithmTag.ECDsa:
		{
			MPInteger ecR = new MPInteger(bcpgIn);
			MPInteger ecS = new MPInteger(bcpgIn);
			signature = new MPInteger[2] { ecR, ecS };
			return;
		}
		}
		if (keyAlgorithm >= PublicKeyAlgorithmTag.Experimental_1 && keyAlgorithm <= PublicKeyAlgorithmTag.Experimental_11)
		{
			signature = null;
			MemoryStream bOut = new MemoryStream();
			int ch;
			while ((ch = bcpgIn.ReadByte()) >= 0)
			{
				bOut.WriteByte((byte)ch);
			}
			signatureEncoding = bOut.ToArray();
			return;
		}
		throw new IOException("unknown signature key algorithm: " + keyAlgorithm);
	}

	public SignaturePacket(int signatureType, long keyId, PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm, SignatureSubpacket[] hashedData, SignatureSubpacket[] unhashedData, byte[] fingerprint, MPInteger[] signature)
		: this(4, signatureType, keyId, keyAlgorithm, hashAlgorithm, hashedData, unhashedData, fingerprint, signature)
	{
	}

	public SignaturePacket(int version, int signatureType, long keyId, PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm, long creationTime, byte[] fingerprint, MPInteger[] signature)
		: this(version, signatureType, keyId, keyAlgorithm, hashAlgorithm, null, null, fingerprint, signature)
	{
		this.creationTime = creationTime;
	}

	public SignaturePacket(int version, int signatureType, long keyId, PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm, SignatureSubpacket[] hashedData, SignatureSubpacket[] unhashedData, byte[] fingerprint, MPInteger[] signature)
	{
		this.version = version;
		this.signatureType = signatureType;
		this.keyId = keyId;
		this.keyAlgorithm = keyAlgorithm;
		this.hashAlgorithm = hashAlgorithm;
		this.hashedData = hashedData;
		this.unhashedData = unhashedData;
		this.fingerprint = fingerprint;
		this.signature = signature;
		if (hashedData != null)
		{
			setCreationTime();
		}
	}

	public byte[] GetSignatureTrailer()
	{
		byte[] trailer = null;
		if (version == 3)
		{
			trailer = new byte[5];
			long time = creationTime / 1000;
			trailer[0] = (byte)signatureType;
			trailer[1] = (byte)(time >> 24);
			trailer[2] = (byte)(time >> 16);
			trailer[3] = (byte)(time >> 8);
			trailer[4] = (byte)time;
		}
		else
		{
			MemoryStream sOut = new MemoryStream();
			sOut.WriteByte((byte)Version);
			sOut.WriteByte((byte)SignatureType);
			sOut.WriteByte((byte)KeyAlgorithm);
			sOut.WriteByte((byte)HashAlgorithm);
			MemoryStream hOut = new MemoryStream();
			SignatureSubpacket[] hashed = GetHashedSubPackets();
			for (int i = 0; i != hashed.Length; i++)
			{
				hashed[i].Encode(hOut);
			}
			byte[] data = hOut.ToArray();
			sOut.WriteByte((byte)(data.Length >> 8));
			sOut.WriteByte((byte)data.Length);
			sOut.Write(data, 0, data.Length);
			byte[] hData = sOut.ToArray();
			sOut.WriteByte((byte)Version);
			sOut.WriteByte(byte.MaxValue);
			sOut.WriteByte((byte)(hData.Length >> 24));
			sOut.WriteByte((byte)(hData.Length >> 16));
			sOut.WriteByte((byte)(hData.Length >> 8));
			sOut.WriteByte((byte)hData.Length);
			trailer = sOut.ToArray();
		}
		return trailer;
	}

	public MPInteger[] GetSignature()
	{
		return signature;
	}

	public byte[] GetSignatureBytes()
	{
		if (signatureEncoding != null)
		{
			return (byte[])signatureEncoding.Clone();
		}
		MemoryStream bOut = new MemoryStream();
		BcpgOutputStream bcOut = new BcpgOutputStream(bOut);
		MPInteger[] array = signature;
		foreach (MPInteger sigObj in array)
		{
			try
			{
				bcOut.WriteObject(sigObj);
			}
			catch (IOException ex)
			{
				throw new Exception("internal error: " + ex);
			}
		}
		return bOut.ToArray();
	}

	public SignatureSubpacket[] GetHashedSubPackets()
	{
		return hashedData;
	}

	public SignatureSubpacket[] GetUnhashedSubPackets()
	{
		return unhashedData;
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
		MemoryStream bOut = new MemoryStream();
		BcpgOutputStream pOut = new BcpgOutputStream(bOut);
		pOut.WriteByte((byte)version);
		if (version == 3 || version == 2)
		{
			pOut.Write(5, (byte)signatureType);
			pOut.WriteInt((int)(creationTime / 1000));
			pOut.WriteLong(keyId);
			pOut.Write((byte)keyAlgorithm, (byte)hashAlgorithm);
		}
		else
		{
			if (version != 4)
			{
				throw new IOException("unknown version: " + version);
			}
			pOut.Write((byte)signatureType, (byte)keyAlgorithm, (byte)hashAlgorithm);
			EncodeLengthAndData(pOut, GetEncodedSubpackets(hashedData));
			EncodeLengthAndData(pOut, GetEncodedSubpackets(unhashedData));
		}
		pOut.Write(fingerprint);
		if (signature != null)
		{
			BcpgObject[] v = signature;
			pOut.WriteObjects(v);
		}
		else
		{
			pOut.Write(signatureEncoding);
		}
		bcpgOut.WritePacket(PacketTag.Signature, bOut.ToArray(), oldFormat: true);
	}

	private static void EncodeLengthAndData(BcpgOutputStream pOut, byte[] data)
	{
		pOut.WriteShort((short)data.Length);
		pOut.Write(data);
	}

	private static byte[] GetEncodedSubpackets(SignatureSubpacket[] ps)
	{
		MemoryStream sOut = new MemoryStream();
		for (int i = 0; i < ps.Length; i++)
		{
			ps[i].Encode(sOut);
		}
		return sOut.ToArray();
	}

	private void setCreationTime()
	{
		SignatureSubpacket[] array = hashedData;
		foreach (SignatureSubpacket p in array)
		{
			if (p is SignatureCreationTime)
			{
				creationTime = DateTimeUtilities.DateTimeToUnixMs(((SignatureCreationTime)p).GetTime());
				break;
			}
		}
	}

	public static SignaturePacket FromByteArray(byte[] data)
	{
		return new SignaturePacket(BcpgInputStream.Wrap(new MemoryStream(data)));
	}
}
