using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

internal sealed class Securities
{
	private readonly Dictionary<string, Security> k8oaQmQrWXv;

	private readonly object iRyaQhqWCyy;

	internal static Securities Ru8DGExAY6OTowt58D9i;

	internal void qKPaQyx1AxZ(Security P_0)
	{
		object obj = iRyaQhqWCyy;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			if (P_0 == null)
			{
				return;
			}
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			if (!k8oaQmQrWXv.ContainsKey((string)sqCIw3xABBCI5lOUFHrL(P_0.Symbol)))
			{
				k8oaQmQrWXv.Add(((Symbol)RPJa7YxAaKPbGnUNagWT(P_0)).ID, P_0);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	public Security jemaQZBB4Zt(string P_0)
	{
		object obj = iRyaQhqWCyy;
		bool lockTaken = false;
		Security result = default(Security);
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (!string.IsNullOrEmpty(P_0) && k8oaQmQrWXv.ContainsKey(P_0))
					{
						result = k8oaQmQrWXv[P_0];
						break;
					}
					result = null;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
					{
						num = 1;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		finally
		{
			if (!lockTaken)
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				Monitor.Exit(obj);
			}
		}
		return result;
	}

	public Security H2DaQVpJneq(Symbol P_0)
	{
		Security result = default(Security);
		lock (iRyaQhqWCyy)
		{
			int num;
			if (!k8oaQmQrWXv.TryGetValue(P_0.ID, out var value))
			{
				k8oaQmQrWXv.Add((string)sqCIw3xABBCI5lOUFHrL(P_0), value = new Security(P_0));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num = 0;
				}
				goto IL_002a;
			}
			goto IL_008d;
			IL_008d:
			result = value;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
			{
				num = 0;
			}
			goto IL_002a;
			IL_002a:
			switch (num)
			{
			default:
				goto end_IL_0018;
			case 1:
				break;
			case 0:
				goto end_IL_0018;
			}
			goto IL_008d;
			end_IL_0018:;
		}
		return result;
	}

	public List<Security> I3GaQCvrME1()
	{
		lock (iRyaQhqWCyy)
		{
			return k8oaQmQrWXv.Values.ToList();
		}
	}

	internal void Clear()
	{
		object obj = iRyaQhqWCyy;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			k8oaQmQrWXv.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[SpecialName]
	public int WFcaQrC2ETp()
	{
		object obj = iRyaQhqWCyy;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			return k8oaQmQrWXv.Count;
		}
		finally
		{
			if (lockTaken)
			{
				eoNC1AxAiE3gfD3McteF(obj);
			}
		}
	}

	public Securities()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		k8oaQmQrWXv = new Dictionary<string, Security>();
		iRyaQhqWCyy = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Securities()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object sqCIw3xABBCI5lOUFHrL(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static object RPJa7YxAaKPbGnUNagWT(object P_0)
	{
		return ((Security)P_0).Symbol;
	}

	internal static bool ue9URlxAo5TNrRd4pCEg()
	{
		return Ru8DGExAY6OTowt58D9i == null;
	}

	internal static Securities VNAVwyxAvchfOetsrFD9()
	{
		return Ru8DGExAY6OTowt58D9i;
	}

	internal static void eoNC1AxAiE3gfD3McteF(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
