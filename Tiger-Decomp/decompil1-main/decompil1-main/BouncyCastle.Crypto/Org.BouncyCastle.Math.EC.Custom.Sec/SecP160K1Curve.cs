using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160K1Curve : AbstractFpCurve
{
	private class SecP160K1LookupTable : AbstractECLookupTable
	{
		private readonly SecP160K1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP160K1LookupTable(SecP160K1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] x = Nat256.Create();
			uint[] y = Nat256.Create();
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
			uint[] x = Nat256.Create();
			uint[] y = Nat256.Create();
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
			return m_outer.CreateRawPoint(new SecP160R2FieldElement(x), new SecP160R2FieldElement(y), SECP160K1_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP160R2FieldElement.Q;

	private const int SECP160K1_DEFAULT_COORDS = 2;

	private const int SECP160K1_FE_INTS = 5;

	private static readonly ECFieldElement[] SECP160K1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP160R2FieldElement(BigInteger.One)
	};

	protected readonly SecP160K1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP160K1Curve()
		: base(q)
	{
		m_infinity = new SecP160K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.ValueOf(7L));
		m_order = new BigInteger(1, Hex.DecodeStrict("0100000000000000000001B8FA16DFAB9ACA16B6B3"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP160K1Curve();
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
		return new SecP160K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP160K1Point(this, x, y, zs, withCompression);
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
		return new SecP160K1LookupTable(this, table, len);
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
