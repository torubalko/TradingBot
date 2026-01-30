using System;
using System.Threading;
using a27KeQGfLUok5gGBn96W;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using tpDLBrGJAci5JWh2s4im;
using x97CE55GhEYKgt7TSVZT;

namespace UMI2GBGJ3kloSb47d3eV;

public class EventOwner<T> : AsgpCmGfxoWiQaB3LIpj where T : anI4lfGJ8TTwhTlujQ36
{
	private long noOGF2ZVO0Z;

	private T F7GGFH9nSsj;

	private Action<EventOwner<T>> Lu8GFfmhMBd;

	internal static object q90Noi58gpEQohbFaB2K;

	public T Value => F7GGFH9nSsj;

	public void k1pGJpywlFB(T oKPGiektYF2yWuacLNwG)
	{
		F7GGFH9nSsj = oKPGiektYF2yWuacLNwG;
	}

	public void smrGJuchiUC(Action<EventOwner<T>> P_0)
	{
		Lu8GFfmhMBd = P_0;
	}

	public bool dqLlndlurqO()
	{
		noOGF2ZVO0Z = 0L;
		F7GGFH9nSsj = null;
		return true;
	}

	public void TKjGJzSd8Na()
	{
		Interlocked.Increment(ref noOGF2ZVO0Z);
	}

	public void Uw7GF03Qn6r()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (Interlocked.Decrement(ref noOGF2ZVO0Z) != 0L)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (Lu8GFfmhMBd != null)
				{
					Lu8GFfmhMBd(this);
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 0:
				return;
			}
		}
	}

	public EventOwner()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static EventOwner()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool XrHW7A58R3qEARvALWMK()
	{
		return q90Noi58gpEQohbFaB2K == null;
	}

	internal static object ywgY4X586ql4TvnFFv1D()
	{
		return q90Noi58gpEQohbFaB2K;
	}
}
