using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Djb;

internal class Curve25519 : AbstractFpCurve
{
	private class Curve25519LookupTable : AbstractECLookupTable
	{
		private readonly Curve25519 m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal Curve25519LookupTable(Curve25519 outer, uint[] table, int size)
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
				for (int j = 0; j < 8; j++)
				{
					x[j] ^= m_table[pos + j] & MASK;
					y[j] ^= m_table[pos + 8 + j] & MASK;
				}
				pos += 16;
			}
			return CreatePoint(x, y);
		}

		public override ECPoint LookupVar(int index)
		{
			uint[] x = Nat256.Create();
			uint[] y = Nat256.Create();
			int pos = index * 8 * 2;
			for (int j = 0; j < 8; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + 8 + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new Curve25519FieldElement(x), new Curve25519FieldElement(y), CURVE25519_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = Curve25519FieldElement.Q;

	private static readonly BigInteger C_a = new BigInteger(1, Hex.DecodeStrict("2AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA984914A144"));

	private static readonly BigInteger C_b = new BigInteger(1, Hex.DecodeStrict("7B425ED097B425ED097B425ED097B425ED097B425ED097B4260B5E9C7710C864"));

	private const int CURVE25519_DEFAULT_COORDS = 4;

	private const int CURVE25519_FE_INTS = 8;

	private static readonly ECFieldElement[] CURVE25519_AFFINE_ZS = new ECFieldElement[2]
	{
		new Curve25519FieldElement(BigInteger.One),
		new Curve25519FieldElement(C_a)
	};

	protected readonly Curve25519Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public Curve25519()
		: base(q)
	{
		m_infinity = new Curve25519Point(this, null, null);
		m_a = FromBigInteger(C_a);
		m_b = FromBigInteger(C_b);
		m_order = new BigInteger(1, Hex.DecodeStrict("1000000000000000000000000000000014DEF9DEA2F79CD65812631A5CF5D3ED"));
		m_cofactor = BigInteger.ValueOf(8L);
		m_coord = 4;
	}

	protected override ECCurve CloneCurve()
	{
		return new Curve25519();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 4)
		{
			return true;
		}
		return false;
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new Curve25519FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new Curve25519Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new Curve25519Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] table = new uint[len * 8 * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat256.Copy(((Curve25519FieldElement)obj.RawXCoord).x, 0, table, pos);
			pos += 8;
			Nat256.Copy(((Curve25519FieldElement)obj.RawYCoord).x, 0, table, pos);
			pos += 8;
		}
		return new Curve25519LookupTable(this, table, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] x = Nat256.Create();
		Curve25519Field.Random(r, x);
		return new Curve25519FieldElement(x);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] x = Nat256.Create();
		Curve25519Field.RandomMult(r, x);
		return new Curve25519FieldElement(x);
	}
}
