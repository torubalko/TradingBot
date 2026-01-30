using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP521R1Curve : AbstractFpCurve
{
	private class SecP521R1LookupTable : AbstractECLookupTable
	{
		private readonly SecP521R1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP521R1LookupTable(SecP521R1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] x = Nat.Create(17);
			uint[] y = Nat.Create(17);
			int pos = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint MASK = (uint)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 17; j++)
				{
					x[j] ^= m_table[pos + j] & MASK;
					y[j] ^= m_table[pos + 17 + j] & MASK;
				}
				pos += 34;
			}
			return CreatePoint(x, y);
		}

		public override ECPoint LookupVar(int index)
		{
			uint[] x = Nat.Create(17);
			uint[] y = Nat.Create(17);
			int pos = index * 17 * 2;
			for (int j = 0; j < 17; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + 17 + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new SecP521R1FieldElement(x), new SecP521R1FieldElement(y), SECP521R1_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP521R1FieldElement.Q;

	private const int SECP521R1_DEFAULT_COORDS = 2;

	private const int SECP521R1_FE_INTS = 17;

	private static readonly ECFieldElement[] SECP521R1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP521R1FieldElement(BigInteger.One)
	};

	protected readonly SecP521R1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP521R1Curve()
		: base(q)
	{
		m_infinity = new SecP521R1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC")));
		m_b = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("0051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00")));
		m_order = new BigInteger(1, Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP521R1Curve();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 2)
		{
			return true;
		}
		return false;
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new SecP521R1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP521R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP521R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] table = new uint[len * 17 * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint p = points[off + i];
			Nat.Copy(17, ((SecP521R1FieldElement)p.RawXCoord).x, 0, table, pos);
			pos += 17;
			Nat.Copy(17, ((SecP521R1FieldElement)p.RawYCoord).x, 0, table, pos);
			pos += 17;
		}
		return new SecP521R1LookupTable(this, table, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] x = Nat.Create(17);
		SecP521R1Field.Random(r, x);
		return new SecP521R1FieldElement(x);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] x = Nat.Create(17);
		SecP521R1Field.RandomMult(r, x);
		return new SecP521R1FieldElement(x);
	}
}
