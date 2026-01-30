using System;

namespace Org.BouncyCastle.Math.EC.Abc;

internal class Tnaf
{
	private static readonly BigInteger MinusOne = BigInteger.One.Negate();

	private static readonly BigInteger MinusTwo = BigInteger.Two.Negate();

	private static readonly BigInteger MinusThree = BigInteger.Three.Negate();

	private static readonly BigInteger Four = BigInteger.ValueOf(4L);

	public const sbyte Width = 4;

	public const sbyte Pow2Width = 16;

	public static readonly ZTauElement[] Alpha0 = new ZTauElement[9]
	{
		null,
		new ZTauElement(BigInteger.One, BigInteger.Zero),
		null,
		new ZTauElement(MinusThree, MinusOne),
		null,
		new ZTauElement(MinusOne, MinusOne),
		null,
		new ZTauElement(BigInteger.One, MinusOne),
		null
	};

	public static readonly sbyte[][] Alpha0Tnaf = new sbyte[8][]
	{
		null,
		new sbyte[1] { 1 },
		null,
		new sbyte[3] { -1, 0, 1 },
		null,
		new sbyte[3] { 1, 0, 1 },
		null,
		new sbyte[4] { -1, 0, 0, 1 }
	};

	public static readonly ZTauElement[] Alpha1 = new ZTauElement[9]
	{
		null,
		new ZTauElement(BigInteger.One, BigInteger.Zero),
		null,
		new ZTauElement(MinusThree, BigInteger.One),
		null,
		new ZTauElement(MinusOne, BigInteger.One),
		null,
		new ZTauElement(BigInteger.One, BigInteger.One),
		null
	};

	public static readonly sbyte[][] Alpha1Tnaf = new sbyte[8][]
	{
		null,
		new sbyte[1] { 1 },
		null,
		new sbyte[3] { -1, 0, 1 },
		null,
		new sbyte[3] { 1, 0, 1 },
		null,
		new sbyte[4] { -1, 0, 0, -1 }
	};

	public static BigInteger Norm(sbyte mu, ZTauElement lambda)
	{
		BigInteger s1 = lambda.u.Multiply(lambda.u);
		BigInteger s2 = lambda.u.Multiply(lambda.v);
		BigInteger s3 = lambda.v.Multiply(lambda.v).ShiftLeft(1);
		return mu switch
		{
			1 => s1.Add(s2).Add(s3), 
			-1 => s1.Subtract(s2).Add(s3), 
			_ => throw new ArgumentException("mu must be 1 or -1"), 
		};
	}

	public static SimpleBigDecimal Norm(sbyte mu, SimpleBigDecimal u, SimpleBigDecimal v)
	{
		SimpleBigDecimal s1 = u.Multiply(u);
		SimpleBigDecimal s2 = u.Multiply(v);
		SimpleBigDecimal s3 = v.Multiply(v).ShiftLeft(1);
		return mu switch
		{
			1 => s1.Add(s2).Add(s3), 
			-1 => s1.Subtract(s2).Add(s3), 
			_ => throw new ArgumentException("mu must be 1 or -1"), 
		};
	}

	public static ZTauElement Round(SimpleBigDecimal lambda0, SimpleBigDecimal lambda1, sbyte mu)
	{
		int scale = lambda0.Scale;
		if (lambda1.Scale != scale)
		{
			throw new ArgumentException("lambda0 and lambda1 do not have same scale");
		}
		if (mu != 1 && mu != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		BigInteger f0 = lambda0.Round();
		BigInteger f1 = lambda1.Round();
		SimpleBigDecimal eta0 = lambda0.Subtract(f0);
		SimpleBigDecimal eta1 = lambda1.Subtract(f1);
		SimpleBigDecimal eta2 = eta0.Add(eta0);
		eta2 = ((mu != 1) ? eta2.Subtract(eta1) : eta2.Add(eta1));
		SimpleBigDecimal threeEta1 = eta1.Add(eta1).Add(eta1);
		SimpleBigDecimal fourEta1 = threeEta1.Add(eta1);
		SimpleBigDecimal check1;
		SimpleBigDecimal check2;
		if (mu == 1)
		{
			check1 = eta0.Subtract(threeEta1);
			check2 = eta0.Add(fourEta1);
		}
		else
		{
			check1 = eta0.Add(threeEta1);
			check2 = eta0.Subtract(fourEta1);
		}
		sbyte h0 = 0;
		sbyte h1 = 0;
		if (eta2.CompareTo(BigInteger.One) >= 0)
		{
			if (check1.CompareTo(MinusOne) < 0)
			{
				h1 = mu;
			}
			else
			{
				h0 = 1;
			}
		}
		else if (check2.CompareTo(BigInteger.Two) >= 0)
		{
			h1 = mu;
		}
		if (eta2.CompareTo(MinusOne) < 0)
		{
			if (check1.CompareTo(BigInteger.One) >= 0)
			{
				h1 = (sbyte)(-mu);
			}
			else
			{
				h0 = -1;
			}
		}
		else if (check2.CompareTo(MinusTwo) < 0)
		{
			h1 = (sbyte)(-mu);
		}
		BigInteger u = f0.Add(BigInteger.ValueOf(h0));
		BigInteger q1 = f1.Add(BigInteger.ValueOf(h1));
		return new ZTauElement(u, q1);
	}

	public static SimpleBigDecimal ApproximateDivisionByN(BigInteger k, BigInteger s, BigInteger vm, sbyte a, int m, int c)
	{
		int _k = (m + 5) / 2 + c;
		BigInteger ns = k.ShiftRight(m - _k - 2 + a);
		BigInteger bigInteger = s.Multiply(ns);
		BigInteger hs = bigInteger.ShiftRight(m);
		BigInteger js = vm.Multiply(hs);
		BigInteger bigInteger2 = bigInteger.Add(js);
		BigInteger ls = bigInteger2.ShiftRight(_k - c);
		if (bigInteger2.TestBit(_k - c - 1))
		{
			ls = ls.Add(BigInteger.One);
		}
		return new SimpleBigDecimal(ls, c);
	}

	public static sbyte[] TauAdicNaf(sbyte mu, ZTauElement lambda)
	{
		if (mu != 1 && mu != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		int log2Norm = Norm(mu, lambda).BitLength;
		sbyte[] u = new sbyte[(log2Norm > 30) ? (log2Norm + 4) : 34];
		int i = 0;
		int length = 0;
		BigInteger r0 = lambda.u;
		BigInteger r1 = lambda.v;
		while (!r0.Equals(BigInteger.Zero) || !r1.Equals(BigInteger.Zero))
		{
			if (r0.TestBit(0))
			{
				u[i] = (sbyte)BigInteger.Two.Subtract(r0.Subtract(r1.ShiftLeft(1)).Mod(Four)).IntValue;
				r0 = ((u[i] != 1) ? r0.Add(BigInteger.One) : r0.ClearBit(0));
				length = i;
			}
			else
			{
				u[i] = 0;
			}
			BigInteger bigInteger = r0;
			BigInteger s = r0.ShiftRight(1);
			r0 = ((mu != 1) ? r1.Subtract(s) : r1.Add(s));
			r1 = bigInteger.ShiftRight(1).Negate();
			i++;
		}
		length++;
		sbyte[] tnaf = new sbyte[length];
		Array.Copy(u, 0, tnaf, 0, length);
		return tnaf;
	}

	public static AbstractF2mPoint Tau(AbstractF2mPoint p)
	{
		return p.Tau();
	}

	public static sbyte GetMu(AbstractF2mCurve curve)
	{
		BigInteger a = curve.A.ToBigInteger();
		if (a.SignValue == 0)
		{
			return -1;
		}
		if (a.Equals(BigInteger.One))
		{
			return 1;
		}
		throw new ArgumentException("No Koblitz curve (ABC), TNAF multiplication not possible");
	}

	public static sbyte GetMu(ECFieldElement curveA)
	{
		return (sbyte)((!curveA.IsZero) ? 1 : (-1));
	}

	public static sbyte GetMu(int curveA)
	{
		return (sbyte)((curveA != 0) ? 1 : (-1));
	}

	public static BigInteger[] GetLucas(sbyte mu, int k, bool doV)
	{
		if (mu != 1 && mu != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		BigInteger u0;
		BigInteger u1;
		if (doV)
		{
			u0 = BigInteger.Two;
			u1 = BigInteger.ValueOf(mu);
		}
		else
		{
			u0 = BigInteger.Zero;
			u1 = BigInteger.One;
		}
		for (int i = 1; i < k; i++)
		{
			BigInteger s = null;
			s = ((mu != 1) ? u1.Negate() : u1);
			BigInteger bigInteger = s.Subtract(u0.ShiftLeft(1));
			u0 = u1;
			u1 = bigInteger;
		}
		return new BigInteger[2] { u0, u1 };
	}

	public static BigInteger GetTw(sbyte mu, int w)
	{
		if (w == 4)
		{
			if (mu == 1)
			{
				return BigInteger.ValueOf(6L);
			}
			return BigInteger.ValueOf(10L);
		}
		BigInteger[] us = GetLucas(mu, w, doV: false);
		BigInteger twoToW = BigInteger.Zero.SetBit(w);
		BigInteger u1invert = us[1].ModInverse(twoToW);
		return BigInteger.Two.Multiply(us[0]).Multiply(u1invert).Mod(twoToW);
	}

	public static BigInteger[] GetSi(AbstractF2mCurve curve)
	{
		if (!curve.IsKoblitz)
		{
			throw new ArgumentException("si is defined for Koblitz curves only");
		}
		int m = curve.FieldSize;
		int a = curve.A.ToBigInteger().IntValue;
		sbyte mu = GetMu(a);
		int shifts = GetShiftsForCofactor(curve.Cofactor);
		int index = m + 3 - a;
		BigInteger[] ui = GetLucas(mu, index, doV: false);
		if (mu == 1)
		{
			ui[0] = ui[0].Negate();
			ui[1] = ui[1].Negate();
		}
		BigInteger dividend0 = BigInteger.One.Add(ui[1]).ShiftRight(shifts);
		BigInteger dividend1 = BigInteger.One.Add(ui[0]).ShiftRight(shifts).Negate();
		return new BigInteger[2] { dividend0, dividend1 };
	}

	public static BigInteger[] GetSi(int fieldSize, int curveA, BigInteger cofactor)
	{
		sbyte mu = GetMu(curveA);
		int shifts = GetShiftsForCofactor(cofactor);
		int index = fieldSize + 3 - curveA;
		BigInteger[] ui = GetLucas(mu, index, doV: false);
		if (mu == 1)
		{
			ui[0] = ui[0].Negate();
			ui[1] = ui[1].Negate();
		}
		BigInteger dividend0 = BigInteger.One.Add(ui[1]).ShiftRight(shifts);
		BigInteger dividend1 = BigInteger.One.Add(ui[0]).ShiftRight(shifts).Negate();
		return new BigInteger[2] { dividend0, dividend1 };
	}

	protected static int GetShiftsForCofactor(BigInteger h)
	{
		if (h != null && h.BitLength < 4)
		{
			switch (h.IntValue)
			{
			case 2:
				return 1;
			case 4:
				return 2;
			}
		}
		throw new ArgumentException("h (Cofactor) must be 2 or 4");
	}

	public static ZTauElement PartModReduction(BigInteger k, int m, sbyte a, BigInteger[] s, sbyte mu, sbyte c)
	{
		BigInteger d0 = ((mu != 1) ? s[0].Subtract(s[1]) : s[0].Add(s[1]));
		BigInteger vm = GetLucas(mu, m, doV: true)[1];
		SimpleBigDecimal lambda = ApproximateDivisionByN(k, s[0], vm, a, m, c);
		SimpleBigDecimal lambda2 = ApproximateDivisionByN(k, s[1], vm, a, m, c);
		ZTauElement q = Round(lambda, lambda2, mu);
		BigInteger u = k.Subtract(d0.Multiply(q.u)).Subtract(BigInteger.ValueOf(2L).Multiply(s[1]).Multiply(q.v));
		BigInteger r1 = s[1].Multiply(q.u).Subtract(s[0].Multiply(q.v));
		return new ZTauElement(u, r1);
	}

	public static AbstractF2mPoint MultiplyRTnaf(AbstractF2mPoint p, BigInteger k)
	{
		AbstractF2mCurve obj = (AbstractF2mCurve)p.Curve;
		int m = obj.FieldSize;
		int a = obj.A.ToBigInteger().IntValue;
		sbyte mu = GetMu(a);
		BigInteger[] s = obj.GetSi();
		ZTauElement rho = PartModReduction(k, m, (sbyte)a, s, mu, 10);
		return MultiplyTnaf(p, rho);
	}

	public static AbstractF2mPoint MultiplyTnaf(AbstractF2mPoint p, ZTauElement lambda)
	{
		sbyte[] u = TauAdicNaf(GetMu(((AbstractF2mCurve)p.Curve).A), lambda);
		return MultiplyFromTnaf(p, u);
	}

	public static AbstractF2mPoint MultiplyFromTnaf(AbstractF2mPoint p, sbyte[] u)
	{
		AbstractF2mPoint q = (AbstractF2mPoint)p.Curve.Infinity;
		AbstractF2mPoint pNeg = (AbstractF2mPoint)p.Negate();
		int tauCount = 0;
		for (int i = u.Length - 1; i >= 0; i--)
		{
			tauCount++;
			sbyte ui = u[i];
			if (ui != 0)
			{
				q = q.TauPow(tauCount);
				tauCount = 0;
				ECPoint x = ((ui > 0) ? p : pNeg);
				q = (AbstractF2mPoint)q.Add(x);
			}
		}
		if (tauCount > 0)
		{
			q = q.TauPow(tauCount);
		}
		return q;
	}

	public static sbyte[] TauAdicWNaf(sbyte mu, ZTauElement lambda, sbyte width, BigInteger pow2w, BigInteger tw, ZTauElement[] alpha)
	{
		if (mu != 1 && mu != -1)
		{
			throw new ArgumentException("mu must be 1 or -1");
		}
		int log2Norm = Norm(mu, lambda).BitLength;
		sbyte[] u = new sbyte[(log2Norm > 30) ? (log2Norm + 4 + width) : (34 + width)];
		BigInteger pow2wMin1 = pow2w.ShiftRight(1);
		BigInteger r0 = lambda.u;
		BigInteger r1 = lambda.v;
		int i = 0;
		while (!r0.Equals(BigInteger.Zero) || !r1.Equals(BigInteger.Zero))
		{
			if (r0.TestBit(0))
			{
				BigInteger uUnMod = r0.Add(r1.Multiply(tw)).Mod(pow2w);
				sbyte uLocal = (u[i] = ((uUnMod.CompareTo(pow2wMin1) < 0) ? ((sbyte)uUnMod.IntValue) : ((sbyte)uUnMod.Subtract(pow2w).IntValue)));
				bool s = true;
				if (uLocal < 0)
				{
					s = false;
					uLocal = (sbyte)(-uLocal);
				}
				if (s)
				{
					r0 = r0.Subtract(alpha[uLocal].u);
					r1 = r1.Subtract(alpha[uLocal].v);
				}
				else
				{
					r0 = r0.Add(alpha[uLocal].u);
					r1 = r1.Add(alpha[uLocal].v);
				}
			}
			else
			{
				u[i] = 0;
			}
			BigInteger bigInteger = r0;
			r0 = ((mu != 1) ? r1.Subtract(r0.ShiftRight(1)) : r1.Add(r0.ShiftRight(1)));
			r1 = bigInteger.ShiftRight(1).Negate();
			i++;
		}
		return u;
	}

	public static AbstractF2mPoint[] GetPreComp(AbstractF2mPoint p, sbyte a)
	{
		sbyte[][] alphaTnaf = ((a == 0) ? Alpha0Tnaf : Alpha1Tnaf);
		AbstractF2mPoint[] pu = new AbstractF2mPoint[alphaTnaf.Length + 1 >>> 1];
		pu[0] = p;
		uint precompLen = (uint)alphaTnaf.Length;
		for (uint i = 3u; i < precompLen; i += 2)
		{
			pu[i >> 1] = MultiplyFromTnaf(p, alphaTnaf[i]);
		}
		ECCurve curve = p.Curve;
		ECPoint[] points = pu;
		curve.NormalizeAll(points);
		return pu;
	}
}
