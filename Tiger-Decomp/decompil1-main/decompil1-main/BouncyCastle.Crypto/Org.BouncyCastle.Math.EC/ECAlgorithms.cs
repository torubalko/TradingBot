using System;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC;

public class ECAlgorithms
{
	public static bool IsF2mCurve(ECCurve c)
	{
		return IsF2mField(c.Field);
	}

	public static bool IsF2mField(IFiniteField field)
	{
		if (field.Dimension > 1 && field.Characteristic.Equals(BigInteger.Two))
		{
			return field is IPolynomialExtensionField;
		}
		return false;
	}

	public static bool IsFpCurve(ECCurve c)
	{
		return IsFpField(c.Field);
	}

	public static bool IsFpField(IFiniteField field)
	{
		return field.Dimension == 1;
	}

	public static ECPoint SumOfMultiplies(ECPoint[] ps, BigInteger[] ks)
	{
		if (ps == null || ks == null || ps.Length != ks.Length || ps.Length < 1)
		{
			throw new ArgumentException("point and scalar arrays should be non-null, and of equal, non-zero, length");
		}
		int count = ps.Length;
		switch (count)
		{
		case 1:
			return ps[0].Multiply(ks[0]);
		case 2:
			return SumOfTwoMultiplies(ps[0], ks[0], ps[1], ks[1]);
		default:
		{
			ECPoint p = ps[0];
			ECCurve c = p.Curve;
			ECPoint[] imported = new ECPoint[count];
			imported[0] = p;
			for (int i = 1; i < count; i++)
			{
				imported[i] = ImportPoint(c, ps[i]);
			}
			if (c.GetEndomorphism() is GlvEndomorphism glvEndomorphism)
			{
				return ImplCheckResult(ImplSumOfMultipliesGlv(imported, ks, glvEndomorphism));
			}
			return ImplCheckResult(ImplSumOfMultiplies(imported, ks));
		}
		}
	}

	public static ECPoint SumOfTwoMultiplies(ECPoint P, BigInteger a, ECPoint Q, BigInteger b)
	{
		ECCurve cp = P.Curve;
		Q = ImportPoint(cp, Q);
		if (cp is AbstractF2mCurve { IsKoblitz: not false })
		{
			return ImplCheckResult(P.Multiply(a).Add(Q.Multiply(b)));
		}
		if (cp.GetEndomorphism() is GlvEndomorphism glvEndomorphism)
		{
			return ImplCheckResult(ImplSumOfMultipliesGlv(new ECPoint[2] { P, Q }, new BigInteger[2] { a, b }, glvEndomorphism));
		}
		return ImplCheckResult(ImplShamirsTrickWNaf(P, a, Q, b));
	}

	public static ECPoint ShamirsTrick(ECPoint P, BigInteger k, ECPoint Q, BigInteger l)
	{
		Q = ImportPoint(P.Curve, Q);
		return ImplCheckResult(ImplShamirsTrickJsf(P, k, Q, l));
	}

	public static ECPoint ImportPoint(ECCurve c, ECPoint p)
	{
		ECCurve cp = p.Curve;
		if (!c.Equals(cp))
		{
			throw new ArgumentException("Point must be on the same curve");
		}
		return c.ImportPoint(p);
	}

	public static void MontgomeryTrick(ECFieldElement[] zs, int off, int len)
	{
		MontgomeryTrick(zs, off, len, null);
	}

	public static void MontgomeryTrick(ECFieldElement[] zs, int off, int len, ECFieldElement scale)
	{
		ECFieldElement[] c = new ECFieldElement[len];
		c[0] = zs[off];
		int i = 0;
		while (++i < len)
		{
			c[i] = c[i - 1].Multiply(zs[off + i]);
		}
		i--;
		if (scale != null)
		{
			c[i] = c[i].Multiply(scale);
		}
		ECFieldElement u = c[i].Invert();
		while (i > 0)
		{
			int j = off + i--;
			ECFieldElement tmp = zs[j];
			zs[j] = c[i].Multiply(u);
			u = u.Multiply(tmp);
		}
		zs[off] = u;
	}

	public static ECPoint ReferenceMultiply(ECPoint p, BigInteger k)
	{
		BigInteger x = k.Abs();
		ECPoint q = p.Curve.Infinity;
		int t = x.BitLength;
		if (t > 0)
		{
			if (x.TestBit(0))
			{
				q = p;
			}
			for (int i = 1; i < t; i++)
			{
				p = p.Twice();
				if (x.TestBit(i))
				{
					q = q.Add(p);
				}
			}
		}
		if (k.SignValue >= 0)
		{
			return q;
		}
		return q.Negate();
	}

	public static ECPoint ValidatePoint(ECPoint p)
	{
		if (!p.IsValid())
		{
			throw new InvalidOperationException("Invalid point");
		}
		return p;
	}

	public static ECPoint CleanPoint(ECCurve c, ECPoint p)
	{
		ECCurve cp = p.Curve;
		if (!c.Equals(cp))
		{
			throw new ArgumentException("Point must be on the same curve", "p");
		}
		return c.DecodePoint(p.GetEncoded(compressed: false));
	}

	internal static ECPoint ImplCheckResult(ECPoint p)
	{
		if (!p.IsValidPartial())
		{
			throw new InvalidOperationException("Invalid result");
		}
		return p;
	}

	internal static ECPoint ImplShamirsTrickJsf(ECPoint P, BigInteger k, ECPoint Q, BigInteger l)
	{
		ECCurve curve = P.Curve;
		ECPoint infinity = curve.Infinity;
		ECPoint PaddQ = P.Add(Q);
		ECPoint PsubQ = P.Subtract(Q);
		ECPoint[] points = new ECPoint[4] { Q, PsubQ, P, PaddQ };
		curve.NormalizeAll(points);
		ECPoint[] table = new ECPoint[9]
		{
			points[3].Negate(),
			points[2].Negate(),
			points[1].Negate(),
			points[0].Negate(),
			infinity,
			points[0],
			points[1],
			points[2],
			points[3]
		};
		byte[] jsf = WNafUtilities.GenerateJsf(k, l);
		ECPoint R = infinity;
		int i = jsf.Length;
		while (--i >= 0)
		{
			byte num = jsf[i];
			int kDigit = num << 24 >> 28;
			int lDigit = num << 28 >> 28;
			int index = 4 + kDigit * 3 + lDigit;
			R = R.TwicePlus(table[index]);
		}
		return R;
	}

	internal static ECPoint ImplShamirsTrickWNaf(ECPoint P, BigInteger k, ECPoint Q, BigInteger l)
	{
		bool negK = k.SignValue < 0;
		bool negL = l.SignValue < 0;
		BigInteger kAbs = k.Abs();
		BigInteger lAbs = l.Abs();
		int minWidthP = WNafUtilities.GetWindowSize(kAbs.BitLength, 8);
		int minWidthQ = WNafUtilities.GetWindowSize(lAbs.BitLength, 8);
		WNafPreCompInfo infoP = WNafUtilities.Precompute(P, minWidthP, includeNegated: true);
		WNafPreCompInfo infoQ = WNafUtilities.Precompute(Q, minWidthQ, includeNegated: true);
		int combSize = FixedPointUtilities.GetCombSize(P.Curve);
		if (!negK && !negL && k.BitLength <= combSize && l.BitLength <= combSize && infoP.IsPromoted && infoQ.IsPromoted)
		{
			return ImplShamirsTrickFixedPoint(P, k, Q, l);
		}
		int widthP = System.Math.Min(8, infoP.Width);
		int width = System.Math.Min(8, infoQ.Width);
		ECPoint[] preCompP = (negK ? infoP.PreCompNeg : infoP.PreComp);
		ECPoint[] preCompQ = (negL ? infoQ.PreCompNeg : infoQ.PreComp);
		ECPoint[] preCompNegP = (negK ? infoP.PreComp : infoP.PreCompNeg);
		ECPoint[] preCompNegQ = (negL ? infoQ.PreComp : infoQ.PreCompNeg);
		byte[] wnafP = WNafUtilities.GenerateWindowNaf(widthP, kAbs);
		byte[] wnafQ = WNafUtilities.GenerateWindowNaf(width, lAbs);
		return ImplShamirsTrickWNaf(preCompP, preCompNegP, wnafP, preCompQ, preCompNegQ, wnafQ);
	}

	internal static ECPoint ImplShamirsTrickWNaf(ECEndomorphism endomorphism, ECPoint P, BigInteger k, BigInteger l)
	{
		bool negK = k.SignValue < 0;
		bool negL = l.SignValue < 0;
		k = k.Abs();
		l = l.Abs();
		int minWidth = WNafUtilities.GetWindowSize(System.Math.Max(k.BitLength, l.BitLength), 8);
		WNafPreCompInfo infoP = WNafUtilities.Precompute(P, minWidth, includeNegated: true);
		WNafPreCompInfo infoQ = WNafUtilities.PrecomputeWithPointMap(EndoUtilities.MapPoint(endomorphism, P), endomorphism.PointMap, infoP, includeNegated: true);
		int widthP = System.Math.Min(8, infoP.Width);
		int width = System.Math.Min(8, infoQ.Width);
		ECPoint[] preCompP = (negK ? infoP.PreCompNeg : infoP.PreComp);
		ECPoint[] preCompQ = (negL ? infoQ.PreCompNeg : infoQ.PreComp);
		ECPoint[] preCompNegP = (negK ? infoP.PreComp : infoP.PreCompNeg);
		ECPoint[] preCompNegQ = (negL ? infoQ.PreComp : infoQ.PreCompNeg);
		byte[] wnafP = WNafUtilities.GenerateWindowNaf(widthP, k);
		byte[] wnafQ = WNafUtilities.GenerateWindowNaf(width, l);
		return ImplShamirsTrickWNaf(preCompP, preCompNegP, wnafP, preCompQ, preCompNegQ, wnafQ);
	}

	private static ECPoint ImplShamirsTrickWNaf(ECPoint[] preCompP, ECPoint[] preCompNegP, byte[] wnafP, ECPoint[] preCompQ, ECPoint[] preCompNegQ, byte[] wnafQ)
	{
		int num = System.Math.Max(wnafP.Length, wnafQ.Length);
		ECPoint infinity = preCompP[0].Curve.Infinity;
		ECPoint R = infinity;
		int zeroes = 0;
		for (int i = num - 1; i >= 0; i--)
		{
			int wiP = ((i < wnafP.Length) ? ((sbyte)wnafP[i]) : 0);
			int wiQ = ((i < wnafQ.Length) ? ((sbyte)wnafQ[i]) : 0);
			if ((wiP | wiQ) == 0)
			{
				zeroes++;
			}
			else
			{
				ECPoint r = infinity;
				if (wiP != 0)
				{
					int nP = System.Math.Abs(wiP);
					ECPoint[] tableP = ((wiP < 0) ? preCompNegP : preCompP);
					r = r.Add(tableP[nP >> 1]);
				}
				if (wiQ != 0)
				{
					int nQ = System.Math.Abs(wiQ);
					ECPoint[] tableQ = ((wiQ < 0) ? preCompNegQ : preCompQ);
					r = r.Add(tableQ[nQ >> 1]);
				}
				if (zeroes > 0)
				{
					R = R.TimesPow2(zeroes);
					zeroes = 0;
				}
				R = R.TwicePlus(r);
			}
		}
		if (zeroes > 0)
		{
			R = R.TimesPow2(zeroes);
		}
		return R;
	}

	internal static ECPoint ImplSumOfMultiplies(ECPoint[] ps, BigInteger[] ks)
	{
		int count = ps.Length;
		bool[] negs = new bool[count];
		WNafPreCompInfo[] infos = new WNafPreCompInfo[count];
		byte[][] wnafs = new byte[count][];
		for (int i = 0; i < count; i++)
		{
			BigInteger ki = ks[i];
			negs[i] = ki.SignValue < 0;
			ki = ki.Abs();
			int minWidth = WNafUtilities.GetWindowSize(ki.BitLength, 8);
			WNafPreCompInfo info = WNafUtilities.Precompute(ps[i], minWidth, includeNegated: true);
			int width = System.Math.Min(8, info.Width);
			infos[i] = info;
			wnafs[i] = WNafUtilities.GenerateWindowNaf(width, ki);
		}
		return ImplSumOfMultiplies(negs, infos, wnafs);
	}

	internal static ECPoint ImplSumOfMultipliesGlv(ECPoint[] ps, BigInteger[] ks, GlvEndomorphism glvEndomorphism)
	{
		BigInteger n = ps[0].Curve.Order;
		int len = ps.Length;
		BigInteger[] abs = new BigInteger[len << 1];
		int i = 0;
		int j = 0;
		for (; i < len; i++)
		{
			BigInteger[] ab = glvEndomorphism.DecomposeScalar(ks[i].Mod(n));
			abs[j++] = ab[0];
			abs[j++] = ab[1];
		}
		if (glvEndomorphism.HasEfficientPointMap)
		{
			return ImplSumOfMultiplies(glvEndomorphism, ps, abs);
		}
		ECPoint[] pqs = new ECPoint[len << 1];
		int k = 0;
		int j2 = 0;
		for (; k < len; k++)
		{
			ECPoint p = ps[k];
			ECPoint q = EndoUtilities.MapPoint(glvEndomorphism, p);
			pqs[j2++] = p;
			pqs[j2++] = q;
		}
		return ImplSumOfMultiplies(pqs, abs);
	}

	internal static ECPoint ImplSumOfMultiplies(ECEndomorphism endomorphism, ECPoint[] ps, BigInteger[] ks)
	{
		int halfCount = ps.Length;
		int num = halfCount << 1;
		bool[] negs = new bool[num];
		WNafPreCompInfo[] infos = new WNafPreCompInfo[num];
		byte[][] wnafs = new byte[num][];
		ECPointMap pointMap = endomorphism.PointMap;
		for (int i = 0; i < halfCount; i++)
		{
			int j0 = i << 1;
			int j1 = j0 + 1;
			BigInteger kj0 = ks[j0];
			negs[j0] = kj0.SignValue < 0;
			kj0 = kj0.Abs();
			BigInteger kj1 = ks[j1];
			negs[j1] = kj1.SignValue < 0;
			kj1 = kj1.Abs();
			int minWidth = WNafUtilities.GetWindowSize(System.Math.Max(kj0.BitLength, kj1.BitLength), 8);
			ECPoint P = ps[i];
			WNafPreCompInfo infoP = WNafUtilities.Precompute(P, minWidth, includeNegated: true);
			WNafPreCompInfo infoQ = WNafUtilities.PrecomputeWithPointMap(EndoUtilities.MapPoint(endomorphism, P), pointMap, infoP, includeNegated: true);
			int widthP = System.Math.Min(8, infoP.Width);
			int widthQ = System.Math.Min(8, infoQ.Width);
			infos[j0] = infoP;
			infos[j1] = infoQ;
			wnafs[j0] = WNafUtilities.GenerateWindowNaf(widthP, kj0);
			wnafs[j1] = WNafUtilities.GenerateWindowNaf(widthQ, kj1);
		}
		return ImplSumOfMultiplies(negs, infos, wnafs);
	}

	private static ECPoint ImplSumOfMultiplies(bool[] negs, WNafPreCompInfo[] infos, byte[][] wnafs)
	{
		int len = 0;
		int count = wnafs.Length;
		for (int i = 0; i < count; i++)
		{
			len = System.Math.Max(len, wnafs[i].Length);
		}
		ECPoint infinity = infos[0].PreComp[0].Curve.Infinity;
		ECPoint R = infinity;
		int zeroes = 0;
		for (int i2 = len - 1; i2 >= 0; i2--)
		{
			ECPoint r = infinity;
			for (int j = 0; j < count; j++)
			{
				byte[] wnaf = wnafs[j];
				int wi = ((i2 < wnaf.Length) ? ((sbyte)wnaf[i2]) : 0);
				if (wi != 0)
				{
					int n = System.Math.Abs(wi);
					WNafPreCompInfo info = infos[j];
					ECPoint[] table = ((wi < 0 == negs[j]) ? info.PreComp : info.PreCompNeg);
					r = r.Add(table[n >> 1]);
				}
			}
			if (r == infinity)
			{
				zeroes++;
			}
			else
			{
				if (zeroes > 0)
				{
					R = R.TimesPow2(zeroes);
					zeroes = 0;
				}
				R = R.TwicePlus(r);
			}
		}
		if (zeroes > 0)
		{
			R = R.TimesPow2(zeroes);
		}
		return R;
	}

	private static ECPoint ImplShamirsTrickFixedPoint(ECPoint p, BigInteger k, ECPoint q, BigInteger l)
	{
		ECCurve c = p.Curve;
		int combSize = FixedPointUtilities.GetCombSize(c);
		if (k.BitLength > combSize || l.BitLength > combSize)
		{
			throw new InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
		}
		FixedPointPreCompInfo infoP = FixedPointUtilities.Precompute(p);
		FixedPointPreCompInfo infoQ = FixedPointUtilities.Precompute(q);
		ECLookupTable lookupTableP = infoP.LookupTable;
		ECLookupTable lookupTableQ = infoQ.LookupTable;
		int widthP = infoP.Width;
		int widthQ = infoQ.Width;
		if (widthP != widthQ)
		{
			FixedPointCombMultiplier fixedPointCombMultiplier = new FixedPointCombMultiplier();
			ECPoint r1 = fixedPointCombMultiplier.Multiply(p, k);
			ECPoint r2 = fixedPointCombMultiplier.Multiply(q, l);
			return r1.Add(r2);
		}
		int width = widthP;
		int d = (combSize + width - 1) / width;
		ECPoint R = c.Infinity;
		int num = d * width;
		uint[] K = Nat.FromBigInteger(num, k);
		uint[] L = Nat.FromBigInteger(num, l);
		int top = num - 1;
		for (int i = 0; i < d; i++)
		{
			uint secretIndexK = 0u;
			uint secretIndexL = 0u;
			for (int j = top - i; j >= 0; j -= d)
			{
				uint secretBitK = K[j >> 5] >> j;
				secretIndexK ^= secretBitK >> 1;
				secretIndexK <<= 1;
				secretIndexK ^= secretBitK;
				uint secretBitL = L[j >> 5] >> j;
				secretIndexL ^= secretBitL >> 1;
				secretIndexL <<= 1;
				secretIndexL ^= secretBitL;
			}
			ECPoint eCPoint = lookupTableP.LookupVar((int)secretIndexK);
			ECPoint addQ = lookupTableQ.LookupVar((int)secretIndexL);
			ECPoint T = eCPoint.Add(addQ);
			R = R.TwicePlus(T);
		}
		return R.Add(infoP.Offset).Add(infoQ.Offset);
	}
}
