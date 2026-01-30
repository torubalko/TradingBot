using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT283K1Curve : AbstractF2mCurve
{
	private class SecT283K1LookupTable : AbstractECLookupTable
	{
		private readonly SecT283K1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecT283K1LookupTable(SecT283K1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			ulong[] x = Nat320.Create64();
			ulong[] y = Nat320.Create64();
			int pos = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong MASK = (ulong)((i ^ index) - 1 >> 31);
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
			ulong[] x = Nat320.Create64();
			ulong[] y = Nat320.Create64();
			int pos = index * 5 * 2;
			for (int j = 0; j < 5; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + 5 + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(ulong[] x, ulong[] y)
		{
			return m_outer.CreateRawPoint(new SecT283FieldElement(x), new SecT283FieldElement(y), SECT283K1_AFFINE_ZS, withCompression: false);
		}
	}

	private const int SECT283K1_DEFAULT_COORDS = 6;

	private const int SECT283K1_FE_LONGS = 5;

	private static readonly ECFieldElement[] SECT283K1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecT283FieldElement(BigInteger.One)
	};

	protected readonly SecT283K1Point m_infinity;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => 283;

	public override bool IsKoblitz => true;

	public virtual int M => 283;

	public virtual bool IsTrinomial => false;

	public virtual int K1 => 5;

	public virtual int K2 => 7;

	public virtual int K3 => 12;

	public SecT283K1Curve()
		: base(283, 5, 7, 12)
	{
		m_infinity = new SecT283K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.One);
		m_order = new BigInteger(1, Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9AE2ED07577265DFF7F94451E061E163C61"));
		m_cofactor = BigInteger.ValueOf(4L);
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT283K1Curve();
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
		return new SecT283FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT283K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT283K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] table = new ulong[len * 5 * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat320.Copy64(((SecT283FieldElement)obj.RawXCoord).x, 0, table, pos);
			pos += 5;
			Nat320.Copy64(((SecT283FieldElement)obj.RawYCoord).x, 0, table, pos);
			pos += 5;
		}
		return new SecT283K1LookupTable(this, table, len);
	}
}
