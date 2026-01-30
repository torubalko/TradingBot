using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT233K1Curve : AbstractF2mCurve
{
	private class SecT233K1LookupTable : AbstractECLookupTable
	{
		private readonly SecT233K1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecT233K1LookupTable(SecT233K1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			ulong[] x = Nat256.Create64();
			ulong[] y = Nat256.Create64();
			int pos = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong MASK = (ulong)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 4; j++)
				{
					x[j] ^= m_table[pos + j] & MASK;
					y[j] ^= m_table[pos + 4 + j] & MASK;
				}
				pos += 8;
			}
			return CreatePoint(x, y);
		}

		public override ECPoint LookupVar(int index)
		{
			ulong[] x = Nat256.Create64();
			ulong[] y = Nat256.Create64();
			int pos = index * 4 * 2;
			for (int j = 0; j < 4; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + 4 + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(ulong[] x, ulong[] y)
		{
			return m_outer.CreateRawPoint(new SecT233FieldElement(x), new SecT233FieldElement(y), SECT233K1_AFFINE_ZS, withCompression: false);
		}
	}

	private const int SECT233K1_DEFAULT_COORDS = 6;

	private const int SECT233K1_FE_LONGS = 4;

	private static readonly ECFieldElement[] SECT233K1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecT233FieldElement(BigInteger.One)
	};

	protected readonly SecT233K1Point m_infinity;

	public override int FieldSize => 233;

	public override ECPoint Infinity => m_infinity;

	public override bool IsKoblitz => true;

	public virtual int M => 233;

	public virtual bool IsTrinomial => true;

	public virtual int K1 => 74;

	public virtual int K2 => 0;

	public virtual int K3 => 0;

	public SecT233K1Curve()
		: base(233, 74, 0, 0)
	{
		m_infinity = new SecT233K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.One);
		m_order = new BigInteger(1, Hex.DecodeStrict("8000000000000000000000000000069D5BB915BCD46EFB1AD5F173ABDF"));
		m_cofactor = BigInteger.ValueOf(4L);
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT233K1Curve();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 6)
		{
			return true;
		}
		return false;
	}

	protected override ECMultiplier CreateDefaultMultiplier()
	{
		return new WTauNafMultiplier();
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new SecT233FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT233K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT233K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] table = new ulong[len * 4 * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat256.Copy64(((SecT233FieldElement)obj.RawXCoord).x, 0, table, pos);
			pos += 4;
			Nat256.Copy64(((SecT233FieldElement)obj.RawYCoord).x, 0, table, pos);
			pos += 4;
		}
		return new SecT233K1LookupTable(this, table, len);
	}
}
