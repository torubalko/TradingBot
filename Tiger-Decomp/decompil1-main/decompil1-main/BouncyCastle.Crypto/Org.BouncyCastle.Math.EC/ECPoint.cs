using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC;

public abstract class ECPoint
{
	private class ValidityCallback : IPreCompCallback
	{
		private readonly ECPoint m_outer;

		private readonly bool m_decompressed;

		private readonly bool m_checkOrder;

		internal ValidityCallback(ECPoint outer, bool decompressed, bool checkOrder)
		{
			m_outer = outer;
			m_decompressed = decompressed;
			m_checkOrder = checkOrder;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			ValidityPreCompInfo info = existing as ValidityPreCompInfo;
			if (info == null)
			{
				info = new ValidityPreCompInfo();
			}
			if (info.HasFailed())
			{
				return info;
			}
			if (!info.HasCurveEquationPassed())
			{
				if (!m_decompressed && !m_outer.SatisfiesCurveEquation())
				{
					info.ReportFailed();
					return info;
				}
				info.ReportCurveEquationPassed();
			}
			if (m_checkOrder && !info.HasOrderPassed())
			{
				if (!m_outer.SatisfiesOrder())
				{
					info.ReportFailed();
					return info;
				}
				info.ReportOrderPassed();
			}
			return info;
		}
	}

	private static readonly SecureRandom Random = new SecureRandom();

	protected static ECFieldElement[] EMPTY_ZS = new ECFieldElement[0];

	protected internal readonly ECCurve m_curve;

	protected internal readonly ECFieldElement m_x;

	protected internal readonly ECFieldElement m_y;

	protected internal readonly ECFieldElement[] m_zs;

	protected internal readonly bool m_withCompression;

	protected internal IDictionary m_preCompTable;

	public virtual ECCurve Curve => m_curve;

	protected virtual int CurveCoordinateSystem
	{
		get
		{
			if (m_curve != null)
			{
				return m_curve.CoordinateSystem;
			}
			return 0;
		}
	}

	public virtual ECFieldElement AffineXCoord
	{
		get
		{
			CheckNormalized();
			return XCoord;
		}
	}

	public virtual ECFieldElement AffineYCoord
	{
		get
		{
			CheckNormalized();
			return YCoord;
		}
	}

	public virtual ECFieldElement XCoord => m_x;

	public virtual ECFieldElement YCoord => m_y;

	protected internal ECFieldElement RawXCoord => m_x;

	protected internal ECFieldElement RawYCoord => m_y;

	protected internal ECFieldElement[] RawZCoords => m_zs;

	public bool IsInfinity
	{
		get
		{
			if (m_x == null)
			{
				return m_y == null;
			}
			return false;
		}
	}

	public bool IsCompressed => m_withCompression;

	protected internal abstract bool CompressionYTilde { get; }

	protected static ECFieldElement[] GetInitialZCoords(ECCurve curve)
	{
		int coord = curve?.CoordinateSystem ?? 0;
		if (coord == 0 || coord == 5)
		{
			return EMPTY_ZS;
		}
		ECFieldElement one = curve.FromBigInteger(BigInteger.One);
		switch (coord)
		{
		case 1:
		case 2:
		case 6:
			return new ECFieldElement[1] { one };
		case 3:
			return new ECFieldElement[3] { one, one, one };
		case 4:
			return new ECFieldElement[2] { one, curve.A };
		default:
			throw new ArgumentException("unknown coordinate system");
		}
	}

	protected ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: this(curve, x, y, GetInitialZCoords(curve), withCompression)
	{
	}

	internal ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		m_curve = curve;
		m_x = x;
		m_y = y;
		m_zs = zs;
		m_withCompression = withCompression;
	}

	protected abstract bool SatisfiesCurveEquation();

	protected virtual bool SatisfiesOrder()
	{
		if (BigInteger.One.Equals(Curve.Cofactor))
		{
			return true;
		}
		BigInteger n = Curve.Order;
		if (n != null)
		{
			return ECAlgorithms.ReferenceMultiply(this, n).IsInfinity;
		}
		return true;
	}

	public ECPoint GetDetachedPoint()
	{
		return Normalize().Detach();
	}

	protected abstract ECPoint Detach();

	public virtual ECFieldElement GetZCoord(int index)
	{
		if (index >= 0 && index < m_zs.Length)
		{
			return m_zs[index];
		}
		return null;
	}

	public virtual ECFieldElement[] GetZCoords()
	{
		int zsLen = m_zs.Length;
		if (zsLen == 0)
		{
			return m_zs;
		}
		ECFieldElement[] copy = new ECFieldElement[zsLen];
		Array.Copy(m_zs, 0, copy, 0, zsLen);
		return copy;
	}

	protected virtual void CheckNormalized()
	{
		if (!IsNormalized())
		{
			throw new InvalidOperationException("point not in normal form");
		}
	}

	public virtual bool IsNormalized()
	{
		int coord = CurveCoordinateSystem;
		if (coord != 0 && coord != 5 && !IsInfinity)
		{
			return RawZCoords[0].IsOne;
		}
		return true;
	}

	public virtual ECPoint Normalize()
	{
		if (IsInfinity)
		{
			return this;
		}
		int curveCoordinateSystem = CurveCoordinateSystem;
		if (curveCoordinateSystem == 0 || curveCoordinateSystem == 5)
		{
			return this;
		}
		ECFieldElement z = RawZCoords[0];
		if (z.IsOne)
		{
			return this;
		}
		if (m_curve == null)
		{
			throw new InvalidOperationException("Detached points must be in affine coordinates");
		}
		SecureRandom r = Random;
		ECFieldElement b = m_curve.RandomFieldElementMult(r);
		ECFieldElement zInv = z.Multiply(b).Invert().Multiply(b);
		return Normalize(zInv);
	}

	internal virtual ECPoint Normalize(ECFieldElement zInv)
	{
		switch (CurveCoordinateSystem)
		{
		case 1:
		case 6:
			return CreateScaledPoint(zInv, zInv);
		case 2:
		case 3:
		case 4:
		{
			ECFieldElement zInv2 = zInv.Square();
			ECFieldElement zInv3 = zInv2.Multiply(zInv);
			return CreateScaledPoint(zInv2, zInv3);
		}
		default:
			throw new InvalidOperationException("not a projective coordinate system");
		}
	}

	protected virtual ECPoint CreateScaledPoint(ECFieldElement sx, ECFieldElement sy)
	{
		return Curve.CreateRawPoint(RawXCoord.Multiply(sx), RawYCoord.Multiply(sy), IsCompressed);
	}

	public bool IsValid()
	{
		return ImplIsValid(decompressed: false, checkOrder: true);
	}

	internal bool IsValidPartial()
	{
		return ImplIsValid(decompressed: false, checkOrder: false);
	}

	internal bool ImplIsValid(bool decompressed, bool checkOrder)
	{
		if (IsInfinity)
		{
			return true;
		}
		ValidityCallback callback = new ValidityCallback(this, decompressed, checkOrder);
		return !((ValidityPreCompInfo)Curve.Precompute(this, ValidityPreCompInfo.PRECOMP_NAME, callback)).HasFailed();
	}

	public virtual ECPoint ScaleX(ECFieldElement scale)
	{
		if (!IsInfinity)
		{
			return Curve.CreateRawPoint(RawXCoord.Multiply(scale), RawYCoord, RawZCoords, IsCompressed);
		}
		return this;
	}

	public virtual ECPoint ScaleXNegateY(ECFieldElement scale)
	{
		if (!IsInfinity)
		{
			return Curve.CreateRawPoint(RawXCoord.Multiply(scale), RawYCoord.Negate(), RawZCoords, IsCompressed);
		}
		return this;
	}

	public virtual ECPoint ScaleY(ECFieldElement scale)
	{
		if (!IsInfinity)
		{
			return Curve.CreateRawPoint(RawXCoord, RawYCoord.Multiply(scale), RawZCoords, IsCompressed);
		}
		return this;
	}

	public virtual ECPoint ScaleYNegateX(ECFieldElement scale)
	{
		if (!IsInfinity)
		{
			return Curve.CreateRawPoint(RawXCoord.Negate(), RawYCoord.Multiply(scale), RawZCoords, IsCompressed);
		}
		return this;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as ECPoint);
	}

	public virtual bool Equals(ECPoint other)
	{
		if (this == other)
		{
			return true;
		}
		if (other == null)
		{
			return false;
		}
		ECCurve c1 = Curve;
		ECCurve c2 = other.Curve;
		bool n1 = c1 == null;
		bool n2 = c2 == null;
		bool i1 = IsInfinity;
		bool i2 = other.IsInfinity;
		if (i1 || i2)
		{
			if (i1 && i2)
			{
				if (!(n1 || n2))
				{
					return c1.Equals(c2);
				}
				return true;
			}
			return false;
		}
		ECPoint p1 = this;
		ECPoint p2 = other;
		if (!(n1 && n2))
		{
			if (n1)
			{
				p2 = p2.Normalize();
			}
			else if (n2)
			{
				p1 = p1.Normalize();
			}
			else
			{
				if (!c1.Equals(c2))
				{
					return false;
				}
				ECPoint[] points = new ECPoint[2]
				{
					this,
					c1.ImportPoint(p2)
				};
				c1.NormalizeAll(points);
				p1 = points[0];
				p2 = points[1];
			}
		}
		if (p1.XCoord.Equals(p2.XCoord))
		{
			return p1.YCoord.Equals(p2.YCoord);
		}
		return false;
	}

	public override int GetHashCode()
	{
		ECCurve c = Curve;
		int hc = ((c != null) ? (~c.GetHashCode()) : 0);
		if (!IsInfinity)
		{
			ECPoint p = Normalize();
			hc ^= p.XCoord.GetHashCode() * 17;
			hc ^= p.YCoord.GetHashCode() * 257;
		}
		return hc;
	}

	public override string ToString()
	{
		if (IsInfinity)
		{
			return "INF";
		}
		StringBuilder sb = new StringBuilder();
		sb.Append('(');
		sb.Append(RawXCoord);
		sb.Append(',');
		sb.Append(RawYCoord);
		for (int i = 0; i < m_zs.Length; i++)
		{
			sb.Append(',');
			sb.Append(m_zs[i]);
		}
		sb.Append(')');
		return sb.ToString();
	}

	public virtual byte[] GetEncoded()
	{
		return GetEncoded(m_withCompression);
	}

	public abstract byte[] GetEncoded(bool compressed);

	public abstract ECPoint Add(ECPoint b);

	public abstract ECPoint Subtract(ECPoint b);

	public abstract ECPoint Negate();

	public virtual ECPoint TimesPow2(int e)
	{
		if (e < 0)
		{
			throw new ArgumentException("cannot be negative", "e");
		}
		ECPoint p = this;
		while (--e >= 0)
		{
			p = p.Twice();
		}
		return p;
	}

	public abstract ECPoint Twice();

	public abstract ECPoint Multiply(BigInteger b);

	public virtual ECPoint TwicePlus(ECPoint b)
	{
		return Twice().Add(b);
	}

	public virtual ECPoint ThreeTimes()
	{
		return TwicePlus(this);
	}
}
