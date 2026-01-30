using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg;

public abstract class ECPublicBcpgKey : BcpgObject, IBcpgKey
{
	internal DerObjectIdentifier oid;

	internal BigInteger point;

	public string Format => "PGP";

	public virtual BigInteger EncodedPoint => point;

	public virtual DerObjectIdentifier CurveOid => oid;

	protected ECPublicBcpgKey(BcpgInputStream bcpgIn)
	{
		oid = DerObjectIdentifier.GetInstance(Asn1Object.FromByteArray(ReadBytesOfEncodedLength(bcpgIn)));
		point = new MPInteger(bcpgIn).Value;
	}

	protected ECPublicBcpgKey(DerObjectIdentifier oid, ECPoint point)
	{
		this.point = new BigInteger(1, point.GetEncoded(compressed: false));
		this.oid = oid;
	}

	protected ECPublicBcpgKey(DerObjectIdentifier oid, BigInteger encodedPoint)
	{
		point = encodedPoint;
		this.oid = oid;
	}

	public override byte[] GetEncoded()
	{
		try
		{
			return base.GetEncoded();
		}
		catch (IOException)
		{
			return null;
		}
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
		byte[] oid = this.oid.GetEncoded();
		bcpgOut.Write(oid, 1, oid.Length - 1);
		MPInteger point = new MPInteger(this.point);
		bcpgOut.WriteObject(point);
	}

	protected static byte[] ReadBytesOfEncodedLength(BcpgInputStream bcpgIn)
	{
		int length = bcpgIn.ReadByte();
		if (length < 0)
		{
			throw new EndOfStreamException();
		}
		if (length == 0 || length == 255)
		{
			throw new IOException("future extensions not yet implemented");
		}
		if (length > 127)
		{
			throw new IOException("unsupported OID");
		}
		byte[] buffer = new byte[length + 2];
		bcpgIn.ReadFully(buffer, 2, buffer.Length - 2);
		buffer[0] = 6;
		buffer[1] = (byte)length;
		return buffer;
	}
}
