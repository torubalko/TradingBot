using System;
using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Logging;
using x97CE55GhEYKgt7TSVZT;

namespace mMS0DAajtX57wBOVJ6DF;

internal class S1ilpHajWIEC6jhcH0pY<gFV681521biJnwFSFogZ> : IDisposable
{
	public delegate void Dx5IvtiodVUFuw3SONnR(List<gFV681521biJnwFSFogZ> data);

	private readonly Queue<gFV681521biJnwFSFogZ> hDhajZW7NIq;

	private readonly object KfPajVC7vP3;

	private readonly Dx5IvtiodVUFuw3SONnR jYcajCPy9Va;

	private readonly Thread s7Uajrn11r8;

	private bool pn6ajKE5oGk;

	private bool G11ajmh03UT;

	internal static object QXthnvx7XA74QDOWXA37;

	public S1ilpHajWIEC6jhcH0pY(string P_0, Dx5IvtiodVUFuw3SONnR P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		hDhajZW7NIq = new Queue<gFV681521biJnwFSFogZ>();
		KfPajVC7vP3 = new object();
		base._002Ector();
		jYcajCPy9Va = P_1;
		s7Uajrn11r8 = new Thread(eC5ajUGx3IF)
		{
			Name = P_0 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28B345BB ^ 0x28B2B61F),
			IsBackground = true
		};
		s7Uajrn11r8.Start();
	}

	public void eC5ajUGx3IF()
	{
		int num = 4;
		int num2 = num;
		gFV681521biJnwFSFogZ item = default(gFV681521biJnwFSFogZ);
		List<gFV681521biJnwFSFogZ> list = default(List<gFV681521biJnwFSFogZ>);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 3:
			{
				if (pn6ajKE5oGk)
				{
					return;
				}
				object kfPajVC7vP = KfPajVC7vP3;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(kfPajVC7vP, ref lockTaken);
					if (hDhajZW7NIq.Count == 0)
					{
						Monitor.Wait(KfPajVC7vP3);
					}
					while (true)
					{
						IL_0103:
						int num3;
						if (hDhajZW7NIq.Count > 0)
						{
							item = hDhajZW7NIq.Dequeue();
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
							{
								num3 = 1;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							default:
								goto IL_0154;
							case 1:
								goto end_IL_00c6;
							}
							goto IL_0103;
							IL_0154:
							list.Add(item);
							num3 = 2;
							continue;
							end_IL_00c6:
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(kfPajVC7vP);
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				}
				goto default;
			}
			default:
				if (list.Count == 0)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				try
				{
					jYcajCPy9Va(list);
					list.Clear();
				}
				catch (Exception e)
				{
					LogManager.WriteError(e);
				}
				goto case 2;
			case 4:
				list = new List<gFV681521biJnwFSFogZ>(128);
				num2 = 3;
				break;
			}
		}
	}

	public void mbvajTsVSk1(gFV681521biJnwFSFogZ uEinsO525koUtNqHYbqU)
	{
		if (pn6ajKE5oGk)
		{
			return;
		}
		lock (KfPajVC7vP3)
		{
			hDhajZW7NIq.Enqueue(uEinsO525koUtNqHYbqU);
			Monitor.Pulse(KfPajVC7vP3);
		}
	}

	public void Close()
	{
		Dispose();
	}

	private void cnDajyA9m5k(bool P_0)
	{
		if (G11ajmh03UT || !P_0)
		{
			goto IL_00dc;
		}
		pn6ajKE5oGk = true;
		object kfPajVC7vP = KfPajVC7vP3;
		bool lockTaken = false;
		int num = 2;
		goto IL_0009;
		IL_00dc:
		G11ajmh03UT = true;
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 2:
			try
			{
				Monitor.Enter(kfPajVC7vP, ref lockTaken);
				Monitor.Pulse(KfPajVC7vP3);
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(kfPajVC7vP);
				}
			}
			break;
		case 1:
			return;
		}
		goto IL_00dc;
	}

	public void Dispose()
	{
		cnDajyA9m5k(_0020: true);
		GC.SuppressFinalize(this);
	}

	~S1ilpHajWIEC6jhcH0pY()
	{
		cnDajyA9m5k(_0020: false);
	}

	static S1ilpHajWIEC6jhcH0pY()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool LhO3ZVx7cGYqh3ylNh05()
	{
		return QXthnvx7XA74QDOWXA37 == null;
	}

	internal static object Vr2bAWx7jo9E7nmpgavl()
	{
		return QXthnvx7XA74QDOWXA37;
	}
}
