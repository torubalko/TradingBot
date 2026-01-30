using System;

namespace Org.BouncyCastle.Math.EC;

public abstract class ECPointBase : ECPoint
{
	protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
	}

	protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	public override byte[] GetEncoded(bool compressed)
	{
		if (base.IsInfinity)
		{
			return new byte[1];
		}
		ECPoint normed = Normalize();
		byte[] X = normed.XCoord.GetEncoded();
		if (compressed)
		{
			byte[] PO = new byte[X.Length + 1];
			PO[0] = (byte)(normed.CompressionYTilde ? 3u : 2u);
			Array.Copy(X, 0, PO, 1, X.Length);
			return PO;
		}
		byte[] Y = normed.YCoord.GetEncoded();
		byte[] PO2 = new byte[X.Length + Y.Length + 1];
		PO2[0] = 4;
		Array.Copy(X, 0, PO2, 1, X.Length);
		Array.Copy(Y, 0, PO2, X.Length + 1, Y.Length);
		return PO2;
	}

	public override ECPoint Multiply(BigInteger k)
	{
		return Curve.GetMultiplier().Multiply(this, k);
	}
}
