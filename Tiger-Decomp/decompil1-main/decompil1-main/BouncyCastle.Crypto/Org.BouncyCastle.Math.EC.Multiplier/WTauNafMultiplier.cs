using System;
using Org.BouncyCastle.Math.EC.Abc;

namespace Org.BouncyCastle.Math.EC.Multiplier;

public class WTauNafMultiplier : AbstractECMultiplier
{
	private class WTauNafCallback : IPreCompCallback
	{
		private readonly AbstractF2mPoint m_p;

		private readonly sbyte m_a;

		internal WTauNafCallback(AbstractF2mPoint p, sbyte a)
		{
			m_p = p;
			m_a = a;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			if (existing is WTauNafPreCompInfo)
			{
				return existing;
			}
			return new WTauNafPreCompInfo
			{
				PreComp = Tnaf.GetPreComp(m_p, m_a)
			};
		}
	}

	internal static readonly string PRECOMP_NAME = "bc_wtnaf";

	protected override ECPoint MultiplyPositive(ECPoint point, BigInteger k)
	{
		if (!(point is AbstractF2mPoint))
		{
			throw new ArgumentException("Only AbstractF2mPoint can be used in WTauNafMultiplier");
		}
		AbstractF2mPoint p = (AbstractF2mPoint)point;
		AbstractF2mCurve obj = (AbstractF2mCurve)p.Curve;
		int m = obj.FieldSize;
		sbyte a = (sbyte)obj.A.ToBigInteger().IntValue;
		sbyte mu = Tnaf.GetMu(a);
		BigInteger[] s = obj.GetSi();
		ZTauElement rho = Tnaf.PartModReduction(k, m, a, s, mu, 10);
		return MultiplyWTnaf(p, rho, a, mu);
	}

	private AbstractF2mPoint MultiplyWTnaf(AbstractF2mPoint p, ZTauElement lambda, sbyte a, sbyte mu)
	{
		ZTauElement[] alpha = ((a == 0) ? Tnaf.Alpha0 : Tnaf.Alpha1);
		BigInteger tw = Tnaf.GetTw(mu, 4);
		sbyte[] u = Tnaf.TauAdicWNaf(mu, lambda, 4, BigInteger.ValueOf(16L), tw, alpha);
		return MultiplyFromWTnaf(p, u);
	}

	private static AbstractF2mPoint MultiplyFromWTnaf(AbstractF2mPoint p, sbyte[] u)
	{
		AbstractF2mCurve obj = (AbstractF2mCurve)p.Curve;
		sbyte a = (sbyte)obj.A.ToBigInteger().IntValue;
		AbstractF2mPoint[] pu = ((WTauNafPreCompInfo)obj.Precompute(callback: new WTauNafCallback(p, a), point: p, name: PRECOMP_NAME)).PreComp;
		AbstractF2mPoint[] puNeg = new AbstractF2mPoint[pu.Length];
		for (int i = 0; i < pu.Length; i++)
		{
			puNeg[i] = (AbstractF2mPoint)pu[i].Negate();
		}
		AbstractF2mPoint q = (AbstractF2mPoint)p.Curve.Infinity;
		int tauCount = 0;
		for (int i2 = u.Length - 1; i2 >= 0; i2--)
		{
			tauCount++;
			int ui = u[i2];
			if (ui != 0)
			{
				q = q.TauPow(tauCount);
				tauCount = 0;
				ECPoint x = ((ui > 0) ? pu[ui >> 1] : puNeg[-ui >> 1]);
				q = (AbstractF2mPoint)q.Add(x);
			}
		}
		if (tauCount > 0)
		{
			q = q.TauPow(tauCount);
		}
		return q;
	}
}
