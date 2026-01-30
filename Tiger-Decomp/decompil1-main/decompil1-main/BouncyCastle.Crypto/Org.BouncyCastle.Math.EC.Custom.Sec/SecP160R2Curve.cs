using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160R2Curve : AbstractFpCurve
{
	private class SecP160R2LookupTable : AbstractECLookupTable
	{
		private readonly SecP160R2Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP160R2LookupTable(SecP160R2Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] x = Nat160.Create();
			uint[] y = Nat160.Create();
			int pos = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint MASK = (uint)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 5; j++)
				{
					x[j] ^= m_table[pos + j] & MASK;
					y[j] ^= m_table[pos + 5 + j] & MASK;
				}
				pos += 10;
			}
			return CreatePoint(x, y);
		}

		public override ECPoint LookupVar(int index)
		{
			uint[] x = Nat160.Create();
			uint[] y = Nat160.Create();
			int pos = index * 5 * 2;
			for (int j = 0; j < 5; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + 5 + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new SecP160R2FieldElement(x), new SecP160R2FieldElement(y), SECP160R2_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP160R2FieldElement.Q;

	private const int SECP160R2_DEFAULT_COORDS = 2;

	private const int SECP160R2_FE_INTS = 5;

	private static readonly ECFieldElement[] SECP160R2_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP160R2FieldElement(BigInteger.One)
	};

	protected readonly SecP160R2Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP160R2Curve()
		: base(q)
	{
		m_infinity = new SecP160R2Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFAC70")));
		m_b = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("B4E134D3FB59EB8BAB57274904664D5AF50388BA")));
		m_order = new BigInteger(1, Hex.DecodeStrict("0100000000000000000000351EE786A818F3A1A16B"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP160R2Curve();
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
		return new SecP160R2FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP160R2Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP160R2Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] table = new uint[len * 5 * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat160.Copy(((SecP160R2FieldElement)obj.RawXCoord).x, 0, table, pos);
			pos += 5;
			Nat160.Copy(((SecP160R2FieldElement)obj.RawYCoord).x, 0, table, pos);
			pos += 5;
		}
		return new SecP160R2LookupTable(this, table, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] x = Nat160.Create();
		SecP160R2Field.Random(r, x);
		return new SecP160R2FieldElement(x);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] x = Nat160.Create();
		SecP160R2Field.RandomMult(r, x);
		return new SecP160R2FieldElement(x);
	}
}
