using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg;

public class PublicKeyEncSessionPacket : ContainedPacket
{
	private int version;

	private long keyId;

	private PublicKeyAlgorithmTag algorithm;

	private byte[][] data;

	public int Version => version;

	public long KeyId => keyId;

	public PublicKeyAlgorithmTag Algorithm => algorithm;

	internal PublicKeyEncSessionPacket(BcpgInputStream bcpgIn)
	{
		version = bcpgIn.ReadByte();
		keyId |= (long)bcpgIn.ReadByte() << 56;
		keyId |= (long)bcpgIn.ReadByte() << 48;
		keyId |= (long)bcpgIn.ReadByte() << 40;
		keyId |= (long)bcpgIn.ReadByte() << 32;
		keyId |= (long)bcpgIn.ReadByte() << 24;
		keyId |= (long)bcpgIn.ReadByte() << 16;
		keyId |= (long)bcpgIn.ReadByte() << 8;
		keyId |= (uint)bcpgIn.ReadByte();
		algorithm = (PublicKeyAlgorithmTag)bcpgIn.ReadByte();
		switch (algorithm)
		{
		case PublicKeyAlgorithmTag.RsaGeneral:
		case PublicKeyAlgorithmTag.RsaEncrypt:
			data = new byte[1][] { new MPInteger(bcpgIn).GetEncoded() };
			break;
		case PublicKeyAlgorithmTag.ElGamalEncrypt:
		case PublicKeyAlgorithmTag.ElGamalGeneral:
		{
			MPInteger p = new MPInteger(bcpgIn);
			MPInteger g = new MPInteger(bcpgIn);
			data = new byte[2][]
			{
				p.GetEncoded(),
				g.GetEncoded()
			};
			break;
		}
		case PublicKeyAlgorithmTag.EC:
			data = new byte[1][] { Streams.ReadAll(bcpgIn) };
			break;
		default:
			throw new IOException("unknown PGP public key algorithm encountered");
		}
	}

	public PublicKeyEncSessionPacket(long keyId, PublicKeyAlgorithmTag algorithm, byte[][] data)
	{
		version = 3;
		this.keyId = keyId;
		this.algorithm = algorithm;
		this.data = new byte[data.Length][];
		for (int i = 0; i < data.Length; i++)
		{
			this.data[i] = Arrays.Clone(data[i]);
		}
	}

	public byte[][] GetEncSessionKey()
	{
		return data;
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
		MemoryStream bOut = new MemoryStream();
		BcpgOutputStream pOut = new BcpgOutputStream(bOut);
		pOut.WriteByte((byte)version);
		pOut.WriteLong(keyId);
		pOut.WriteByte((byte)algorithm);
		for (int i = 0; i < data.Length; i++)
		{
			pOut.Write(data[i]);
		}
		Platform.Dispose(pOut);
		bcpgOut.WritePacket(PacketTag.PublicKeyEncryptedSession, bOut.ToArray(), oldFormat: true);
	}
}
