using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP192K1Curve : AbstractFpCurve
{
	private class SecP192K1LookupTable : AbstractECLookupTable
	{
		private readonly SecP192K1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP192K1LookupTable(SecP192K1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] x = Nat192.Create();
			uint[] y = Nat192.Create();
			int pos = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint MASK = (uint)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 6; j++)
				{
					x[j] ^= m_table[pos + j] & MASK;
					y[j] ^= m_table[pos + 6 + j] & MASK;
				}
				pos += 12;
			}
			return CreatePoint(x, y);
		}

		public override ECPoint LookupVar(int index)
		{
			uint[] x = Nat192.Create();
			uint[] y = Nat192.Create();
			int pos = index * 6 * 2;
			for (int j = 0; j < 6; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + 6 + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new SecP192K1FieldElement(x), new SecP192K1FieldElement(y), SECP192K1_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP192K1FieldElement.Q;

	private const int SECP192K1_DEFAULT_COORDS = 2;

	private const int SECP192K1_FE_INTS = 6;

	private static readonly ECFieldElement[] SECP192K1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP192K1FieldElement(BigInteger.One)
	};

	protected readonly SecP192K1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP192K1Curve()
		: base(q)
	{
		m_infinity = new SecP192K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.ValueOf(3L));
		m_order = new BigInteger(1, Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFE26F2FC170F69466A74DEFD8D"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP192K1Curve();
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
		return new SecP192K1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP192K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP192K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] table = new uint[len * 6 * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat192.Copy(((SecP192K1FieldElement)obj.RawXCoord).x, 0, table, pos);
			pos += 6;
			Nat192.Copy(((SecP192K1FieldElement)obj.RawYCoord).x, 0, table, pos);
			pos += 6;
		}
		return new SecP192K1LookupTable(this, table, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] x = Nat192.Create();
		SecP192K1Field.Random(r, x);
		return new SecP192K1FieldElement(x);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] x = Nat192.Create();
		SecP192K1Field.RandomMult(r, x);
		return new SecP192K1FieldElement(x);
	}
}
