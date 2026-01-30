using System;
using System.Collections.Concurrent;
using System.Threading;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;
using P3L23fGfsm8EyHDtMx1M;
using wDr8kGGfcuv9QbuHShJg;

namespace VbYeMsGfGBlbxImmfCXc;

public class bKnGOlGfnm63RpB8BYr7<yYPQq0Nw97nb3ekQGm58> : x1wTPJGferXKPDtNpnp2<yYPQq0Nw97nb3ekQGm58> where yYPQq0Nw97nb3ekQGm58 : class
{
	private readonly Action<yYPQq0Nw97nb3ekQGm58> fRpGfo1H0RF;

	private readonly Func<yYPQq0Nw97nb3ekQGm58> LktGfvm4j40;

	private readonly Func<yYPQq0Nw97nb3ekQGm58, bool> ugXGfB2eWOZ;

	private readonly int MwXGfaWr6No;

	private readonly ConcurrentQueue<yYPQq0Nw97nb3ekQGm58> NR3Gfi6CX7c;

	private int jZ6GflOo6FS;

	private yYPQq0Nw97nb3ekQGm58 TOLGf4yhsL8;

	public bKnGOlGfnm63RpB8BYr7(fLVP3VGfXD9Wgp2LjsmN<yYPQq0Nw97nb3ekQGm58> P_0)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		this._002Ector(P_0, Environment.ProcessorCount * 2);
	}

	public bKnGOlGfnm63RpB8BYr7(fLVP3VGfXD9Wgp2LjsmN<yYPQq0Nw97nb3ekQGm58> P_0, int P_1)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		fRpGfo1H0RF = P_0.vvxlnEMWMhK;
		LktGfvm4j40 = P_0.NUOlnQLnqy6;
		ugXGfB2eWOZ = P_0.RAllnjc3H3Y;
		MwXGfaWr6No = P_1 - 1;
		NR3Gfi6CX7c = new ConcurrentQueue<yYPQq0Nw97nb3ekQGm58>();
	}

	public override yYPQq0Nw97nb3ekQGm58 ClIlncxBjdi()
	{
		yYPQq0Nw97nb3ekQGm58 result = TOLGf4yhsL8;
		if (result == null || Interlocked.CompareExchange(ref TOLGf4yhsL8, null, result) != result)
		{
			if (NR3Gfi6CX7c.TryDequeue(out result))
			{
				Interlocked.Decrement(ref jZ6GflOo6FS);
				fRpGfo1H0RF(result);
				return result;
			}
			return LktGfvm4j40();
		}
		return result;
	}

	public override void RAllnjc3H3Y(yYPQq0Nw97nb3ekQGm58 lUJ2vINwninvIDpfdM4w)
	{
		eUiGfYL5Qe5(lUJ2vINwninvIDpfdM4w);
	}

	private bool eUiGfYL5Qe5(yYPQq0Nw97nb3ekQGm58 wONF3aNwGGCL8fjPyIr2)
	{
		if (!ugXGfB2eWOZ(wONF3aNwGGCL8fjPyIr2))
		{
			return false;
		}
		if (TOLGf4yhsL8 != null || Interlocked.CompareExchange(ref TOLGf4yhsL8, wONF3aNwGGCL8fjPyIr2, null) != null)
		{
			if (Interlocked.Increment(ref jZ6GflOo6FS) <= MwXGfaWr6No)
			{
				NR3Gfi6CX7c.Enqueue(wONF3aNwGGCL8fjPyIr2);
				return true;
			}
			Interlocked.Decrement(ref jZ6GflOo6FS);
			return false;
		}
		return true;
	}

	static bKnGOlGfnm63RpB8BYr7()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}
}
