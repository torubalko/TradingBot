using System;
using System.Collections;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC;

public abstract class ECCurve
{
	public class Config
	{
		protected ECCurve outer;

		protected int coord;

		protected ECEndomorphism endomorphism;

		protected ECMultiplier multiplier;

		internal Config(ECCurve outer, int coord, ECEndomorphism endomorphism, ECMultiplier multiplier)
		{
			this.outer = outer;
			this.coord = coord;
			this.endomorphism = endomorphism;
			this.multiplier = multiplier;
		}

		public Config SetCoordinateSystem(int coord)
		{
			this.coord = coord;
			return this;
		}

		public Config SetEndomorphism(ECEndomorphism endomorphism)
		{
			this.endomorphism = endomorphism;
			return this;
		}

		public Config SetMultiplier(ECMultiplier multiplier)
		{
			this.multiplier = multiplier;
			return this;
		}

		public ECCurve Create()
		{
			if (!outer.SupportsCoordinateSystem(coord))
			{
				throw new InvalidOperationException("unsupported coordinate system");
			}
			ECCurve eCCurve = outer.CloneCurve();
			if (eCCurve == outer)
			{
				throw new InvalidOperationException("implementation returned current curve");
			}
			eCCurve.m_coord = coord;
			eCCurve.m_endomorphism = endomorphism;
			eCCurve.m_multiplier = multiplier;
			return eCCurve;
		}
	}

	private class DefaultLookupTable : AbstractECLookupTable
	{
		private readonly ECCurve m_outer;

		private readonly byte[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal DefaultLookupTable(ECCurve outer, byte[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			int FE_BYTES = (m_outer.FieldSize + 7) / 8;
			byte[] x = new byte[FE_BYTES];
			byte[] y = new byte[FE_BYTES];
			int pos = 0;
			for (int i = 0; i < m_size; i++)
			{
				byte MASK = (byte)((i ^ index) - 1 >> 31);
				for (int j = 0; j < FE_BYTES; j++)
				{
					x[j] ^= (byte)(m_table[pos + j] & MASK);
					y[j] ^= (byte)(m_table[pos + FE_BYTES + j] & MASK);
				}
				pos += FE_BYTES * 2;
			}
			return CreatePoint(x, y);
		}

		public override ECPoint LookupVar(int index)
		{
			int FE_BYTES = (m_outer.FieldSize + 7) / 8;
			byte[] x = new byte[FE_BYTES];
			byte[] y = new byte[FE_BYTES];
			int pos = index * FE_BYTES * 2;
			for (int j = 0; j < FE_BYTES; j++)
			{
				x[j] = m_table[pos + j];
				y[j] = m_table[pos + FE_BYTES + j];
			}
			return CreatePoint(x, y);
		}

		private ECPoint CreatePoint(byte[] x, byte[] y)
		{
			ECFieldElement X = m_outer.FromBigInteger(new BigInteger(1, x));
			ECFieldElement Y = m_outer.FromBigInteger(new BigInteger(1, y));
			return m_outer.CreateRawPoint(X, Y, withCompression: false);
		}
	}

	public const int COORD_AFFINE = 0;

	public const int COORD_HOMOGENEOUS = 1;

	public const int COORD_JACOBIAN = 2;

	public const int COORD_JACOBIAN_CHUDNOVSKY = 3;

	public const int COORD_JACOBIAN_MODIFIED = 4;

	public const int COORD_LAMBDA_AFFINE = 5;

	public const int COORD_LAMBDA_PROJECTIVE = 6;

	public const int COORD_SKEWED = 7;

	protected readonly IFiniteField m_field;

	protected ECFieldElement m_a;

	protected ECFieldElement m_b;

	protected BigInteger m_order;

	protected BigInteger m_cofactor;

	protected int m_coord;

	protected ECEndomorphism m_endomorphism;

	protected ECMultiplier m_multiplier;

	public abstract int FieldSize { get; }

	public abstract ECPoint Infinity { get; }

	public virtual IFiniteField Field => m_field;

	public virtual ECFieldElement A => m_a;

	public virtual ECFieldElement B => m_b;

	public virtual BigInteger Order => m_order;

	public virtual BigInteger Cofactor => m_cofactor;

	public virtual int CoordinateSystem => m_coord;

	public static int[] GetAllCoordinateSystems()
	{
		return new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
	}

	protected ECCurve(IFiniteField field)
	{
		m_field = field;
	}

	public abstract ECFieldElement FromBigInteger(BigInteger x);

	public abstract bool IsValidFieldElement(BigInteger x);

	public abstract ECFieldElement RandomFieldElement(SecureRandom r);

	public abstract ECFieldElement RandomFieldElementMult(SecureRandom r);

	public virtual Config Configure()
	{
		return new Config(this, m_coord, m_endomorphism, m_multiplier);
	}

	public virtual ECPoint ValidatePoint(BigInteger x, BigInteger y)
	{
		ECPoint eCPoint = CreatePoint(x, y);
		if (!eCPoint.IsValid())
		{
			throw new ArgumentException("Invalid point coordinates");
		}
		return eCPoint;
	}

	[Obsolete("Per-point compression property will be removed")]
	public virtual ECPoint ValidatePoint(BigInteger x, BigInteger y, bool withCompression)
	{
		ECPoint eCPoint = CreatePoint(x, y, withCompression);
		if (!eCPoint.IsValid())
		{
			throw new ArgumentException("Invalid point coordinates");
		}
		return eCPoint;
	}

	public virtual ECPoint CreatePoint(BigInteger x, BigInteger y)
	{
		return CreatePoint(x, y, withCompression: false);
	}

	[Obsolete("Per-point compression property will be removed")]
	public virtual ECPoint CreatePoint(BigInteger x, BigInteger y, bool withCompression)
	{
		return CreateRawPoint(FromBigInteger(x), FromBigInteger(y), withCompression);
	}

	protected abstract ECCurve CloneCurve();

	protected internal abstract ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression);

	protected internal abstract ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression);

	protected virtual ECMultiplier CreateDefaultMultiplier()
	{
		if (m_endomorphism is GlvEndomorphism glvEndomorphism)
		{
			return new GlvMultiplier(this, glvEndomorphism);
		}
		return new WNafL2RMultiplier();
	}

	public virtual bool SupportsCoordinateSystem(int coord)
	{
		return coord == 0;
	}

	public virtual PreCompInfo GetPreCompInfo(ECPoint point, string name)
	{
		CheckPoint(point);
		IDictionary table;
		lock (point)
		{
			table = point.m_preCompTable;
		}
		if (table == null)
		{
			return null;
		}
		lock (table)
		{
			return (PreCompInfo)table[name];
		}
	}

	public virtual PreCompInfo Precompute(ECPoint point, string name, IPreCompCallback callback)
	{
		CheckPoint(point);
		IDictionary table;
		lock (point)
		{
			table = point.m_preCompTable;
			if (table == null)
			{
				table = (point.m_preCompTable = Platform.CreateHashtable(4));
			}
		}
		lock (table)
		{
			PreCompInfo existing = (PreCompInfo)table[name];
			PreCompInfo result = callback.Precompute(existing);
			if (result != existing)
			{
				table[name] = result;
			}
			return result;
		}
	}

	public virtual ECPoint ImportPoint(ECPoint p)
	{
		if (this == p.Curve)
		{
			return p;
		}
		if (p.IsInfinity)
		{
			return Infinity;
		}
		p = p.Normalize();
		return CreatePoint(p.XCoord.ToBigInteger(), p.YCoord.ToBigInteger(), p.IsCompressed);
	}

	public virtual void NormalizeAll(ECPoint[] points)
	{
		NormalizeAll(points, 0, points.Length, null);
	}

	public virtual void NormalizeAll(ECPoint[] points, int off, int len, ECFieldElement iso)
	{
		CheckPoints(points, off, len);
		int coordinateSystem = CoordinateSystem;
		if (coordinateSystem == 0 || coordinateSystem == 5)
		{
			if (iso != null)
			{
				throw new ArgumentException("not valid for affine coordinates", "iso");
			}
			return;
		}
		ECFieldElement[] zs = new ECFieldElement[len];
		int[] indices = new int[len];
		int count = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint p = points[off + i];
			if (p != null && (iso != null || !p.IsNormalized()))
			{
				zs[count] = p.GetZCoord(0);
				indices[count++] = off + i;
			}
		}
		if (count != 0)
		{
			ECAlgorithms.MontgomeryTrick(zs, 0, count, iso);
			for (int j = 0; j < count; j++)
			{
				int index = indices[j];
				points[index] = points[index].Normalize(zs[j]);
			}
		}
	}

	public virtual ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		int FE_BYTES = (FieldSize + 7) / 8;
		byte[] table = new byte[len * FE_BYTES * 2];
		int pos = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			byte[] px = obj.RawXCoord.ToBigInteger().ToByteArray();
			byte[] array = obj.RawYCoord.ToBigInteger().ToByteArray();
			int pxStart = ((px.Length > FE_BYTES) ? 1 : 0);
			int pxLen = px.Length - pxStart;
			int pyStart = ((array.Length > FE_BYTES) ? 1 : 0);
			int pyLen = array.Length - pyStart;
			Array.Copy(px, pxStart, table, pos + FE_BYTES - pxLen, pxLen);
			pos += FE_BYTES;
			Array.Copy(array, pyStart, table, pos + FE_BYTES - pyLen, pyLen);
			pos += FE_BYTES;
		}
		return new DefaultLookupTable(this, table, len);
	}

	protected virtual void CheckPoint(ECPoint point)
	{
		if (point == null || this != point.Curve)
		{
			throw new ArgumentException("must be non-null and on this curve", "point");
		}
	}

	protected virtual void CheckPoints(ECPoint[] points)
	{
		CheckPoints(points, 0, points.Length);
	}

	protected virtual void CheckPoints(ECPoint[] points, int off, int len)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (off < 0 || len < 0 || off > points.Length - len)
		{
			throw new ArgumentException("invalid range specified", "points");
		}
		for (int i = 0; i < len; i++)
		{
			ECPoint point = points[off + i];
			if (point != null && this != point.Curve)
			{
				throw new ArgumentException("entries must be null or on this curve", "points");
			}
		}
	}

	public virtual bool Equals(ECCurve other)
	{
		if (this == other)
		{
			return true;
		}
		if (other == null)
		{
			return false;
		}
		if (Field.Equals(other.Field) && A.ToBigInteger().Equals(other.A.ToBigInteger()))
		{
			return B.ToBigInteger().Equals(other.B.ToBigInteger());
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as ECCurve);
	}

	public override int GetHashCode()
	{
		return Field.GetHashCode() ^ Integers.RotateLeft(A.ToBigInteger().GetHashCode(), 8) ^ Integers.RotateLeft(B.ToBigInteger().GetHashCode(), 16);
	}

	protected abstract ECPoint DecompressPoint(int yTilde, BigInteger X1);

	public virtual ECEndomorphism GetEndomorphism()
	{
		return m_endomorphism;
	}

	public virtual ECMultiplier GetMultiplier()
	{
		if (m_multiplier == null)
		{
			m_multiplier = CreateDefaultMultiplier();
		}
		return m_multiplier;
	}

	public virtual ECPoint DecodePoint(byte[] encoded)
	{
		ECPoint p = null;
		int expectedLength = (FieldSize + 7) / 8;
		byte type = encoded[0];
		switch (type)
		{
		case 0:
			if (encoded.Length != 1)
			{
				throw new ArgumentException("Incorrect length for infinity encoding", "encoded");
			}
			p = Infinity;
			break;
		case 2:
		case 3:
		{
			if (encoded.Length != expectedLength + 1)
			{
				throw new ArgumentException("Incorrect length for compressed encoding", "encoded");
			}
			int yTilde = type & 1;
			BigInteger X3 = new BigInteger(1, encoded, 1, expectedLength);
			p = DecompressPoint(yTilde, X3);
			if (!p.ImplIsValid(decompressed: true, checkOrder: true))
			{
				throw new ArgumentException("Invalid point");
			}
			break;
		}
		case 4:
		{
			if (encoded.Length != 2 * expectedLength + 1)
			{
				throw new ArgumentException("Incorrect length for uncompressed encoding", "encoded");
			}
			BigInteger X2 = new BigInteger(1, encoded, 1, expectedLength);
			BigInteger Y2 = new BigInteger(1, encoded, 1 + expectedLength, expectedLength);
			p = ValidatePoint(X2, Y2);
			break;
		}
		case 6:
		case 7:
		{
			if (encoded.Length != 2 * expectedLength + 1)
			{
				throw new ArgumentException("Incorrect length for hybrid encoding", "encoded");
			}
			BigInteger X = new BigInteger(1, encoded, 1, expectedLength);
			BigInteger Y = new BigInteger(1, encoded, 1 + expectedLength, expectedLength);
			if (Y.TestBit(0) != (type == 7))
			{
				throw new ArgumentException("Inconsistent Y coordinate in hybrid encoding", "encoded");
			}
			p = ValidatePoint(X, Y);
			break;
		}
		default:
			throw new FormatException("Invalid point encoding " + type);
		}
		if (type != 0 && p.IsInfinity)
		{
			throw new ArgumentException("Invalid infinity encoding", "encoded");
		}
		return p;
	}
}
