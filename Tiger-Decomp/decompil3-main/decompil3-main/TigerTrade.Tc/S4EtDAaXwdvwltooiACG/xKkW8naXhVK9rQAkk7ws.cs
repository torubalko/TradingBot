using System;
using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Logging;
using x97CE55GhEYKgt7TSVZT;

namespace S4EtDAaXwdvwltooiACG;

internal sealed class xKkW8naXhVK9rQAkk7ws<zbnTpv52vlGrs8QdOtjM> : IDisposable
{
	public delegate void AMnLocio4NtfWG4lLaPL(zbnTpv52vlGrs8QdOtjM data);

	private readonly Queue<zbnTpv52vlGrs8QdOtjM> nguaXPkPaVl;

	private readonly object MVnaXJ6WyZq;

	private readonly AMnLocio4NtfWG4lLaPL bN6aXFUuaPc;

	private Thread VN0aX3L56vF;

	private bool cEraXpyo3CZ;

	private bool SiuaXu5ik82;

	internal static object jbkrsTxhzcgLPhk4MPQM;

	public xKkW8naXhVK9rQAkk7ws(AMnLocio4NtfWG4lLaPL P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		nguaXPkPaVl = new Queue<zbnTpv52vlGrs8QdOtjM>();
		MVnaXJ6WyZq = new object();
		base._002Ector();
		bN6aXFUuaPc = P_0;
		VN0aX3L56vF = new Thread(qQIaX7GqGwd)
		{
			Name = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2074141628 ^ -2074153522),
			IsBackground = true
		};
		VN0aX3L56vF.Start();
	}

	public void qQIaX7GqGwd()
	{
		Queue<zbnTpv52vlGrs8QdOtjM> queue = new Queue<zbnTpv52vlGrs8QdOtjM>();
		zbnTpv52vlGrs8QdOtjM item = default(zbnTpv52vlGrs8QdOtjM);
		while (true)
		{
			int num;
			if (cEraXpyo3CZ)
			{
				num = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num = 2;
				}
				goto IL_0009;
			}
			if (Monitor.TryEnter(MVnaXJ6WyZq))
			{
				if (nguaXPkPaVl.Count == 0)
				{
					Monitor.Wait(MVnaXJ6WyZq);
					goto IL_007b;
				}
				goto IL_018e;
			}
			goto IL_0142;
			IL_007b:
			Monitor.Exit(MVnaXJ6WyZq);
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
			{
				num = 0;
			}
			goto IL_0009;
			IL_0159:
			item = nguaXPkPaVl.Dequeue();
			num = 3;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
			{
				num = 3;
			}
			goto IL_0009;
			IL_0142:
			if (queue.Count <= 0)
			{
				num = 5;
				goto IL_0009;
			}
			goto IL_0180;
			IL_0180:
			zbnTpv52vlGrs8QdOtjM data = queue.Dequeue();
			try
			{
				bN6aXFUuaPc(data);
			}
			catch (Exception e)
			{
				LogManager.WriteError(e);
			}
			goto IL_0142;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 3:
					queue.Enqueue(item);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
					{
						num = 1;
					}
					continue;
				case 6:
					return;
				case 5:
					break;
				default:
					goto IL_0142;
				case 4:
					goto IL_0159;
				case 2:
					goto IL_0180;
				case 1:
					goto IL_018e;
				}
				break;
			}
			continue;
			IL_018e:
			if (nguaXPkPaVl.Count <= 0)
			{
				goto IL_007b;
			}
			goto IL_0159;
		}
	}

	public void RL7aX8W5dsg(zbnTpv52vlGrs8QdOtjM DnAJZU52BCMrLpcdQGW4)
	{
		if (cEraXpyo3CZ)
		{
			return;
		}
		lock (MVnaXJ6WyZq)
		{
			if (VN0aX3L56vF == null)
			{
				VN0aX3L56vF = new Thread(qQIaX7GqGwd)
				{
					Name = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1999650146 ^ -1999752428),
					IsBackground = true
				};
				VN0aX3L56vF.Start();
			}
			nguaXPkPaVl.Enqueue(DnAJZU52BCMrLpcdQGW4);
			Monitor.Pulse(MVnaXJ6WyZq);
		}
	}

	public void Close()
	{
		Dispose();
	}

	private void WbdaXAWo9U9(bool P_0)
	{
		int num;
		if (!SiuaXu5ik82 && P_0)
		{
			cEraXpyo3CZ = true;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_00c8;
		IL_00c8:
		SiuaXu5ik82 = true;
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		object mVnaXJ6WyZq = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				break;
			case 1:
				mVnaXJ6WyZq = MVnaXJ6WyZq;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
				{
					num = 2;
				}
				continue;
			case 0:
				return;
			}
			break;
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(mVnaXJ6WyZq, ref lockTaken);
			Monitor.Pulse(MVnaXJ6WyZq);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(mVnaXJ6WyZq);
			}
		}
		goto IL_00c8;
	}

	public void Dispose()
	{
		WbdaXAWo9U9(_0020: true);
		GC.SuppressFinalize(this);
	}

	~xKkW8naXhVK9rQAkk7ws()
	{
		WbdaXAWo9U9(_0020: false);
	}

	static xKkW8naXhVK9rQAkk7ws()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool NZViVxxw0dSruPAJq8Ja()
	{
		return jbkrsTxhzcgLPhk4MPQM == null;
	}

	internal static object vCaj8gxw2lvW3tK9lorI()
	{
		return jbkrsTxhzcgLPhk4MPQM;
	}
}
