using System;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Threading;
using AdLbwZYjeixWF0WHbS4K;
using BfZtb759KlUg4482QKym;
using bwjBP8YgIYjGi4ESFNrx;
using GTLILlYXK9CZAtrEW5Ov;
using H1JNoZYdsGpw9R2ENOnC;
using h6uEljYd0Lrl77dHUu3V;
using Iw9ai3YRc5qQDX3FAdgI;
using jXpee7YXZyFJRs3dBfd4;
using K1GcsD5GTtMSlaiJI0Xh;
using ME6xTfYEtZ6IAeYZrk6P;
using NpPp04YcjX7Z32p7fQxj;
using pjg2ZIYcDvDGBQxLHyZf;
using Q1hlZtYd310DdVgq8xBK;
using r5tk1FYdb3wghuwemfLI;
using sUYQHVYeJlM31HYPEfSr;
using TigerTrade.Core.Utils.Logging;
using x97CE55GhEYKgt7TSVZT;
using xhjo3XYjAKxYRH0k5iB1;
using YmLUebYXCRZa3JyS4MWE;

namespace chKZFfYsWhPyXoZlkgAY;

internal sealed class GIwcurYsIvQZaWl8SgkA : JtcCwqYXyEQFynH8emV4
{
	[CompilerGenerated]
	private Action m_Connected;

	[CompilerGenerated]
	private Action<bool> m_Disconnected;

	[CompilerGenerated]
	private Action<KSEJIQYdDVOkeZU0LWU5[]> m_Symbols;

	[CompilerGenerated]
	private Action<S48lmjYXrJ4Q59RxkkkG[]> m_Accounts;

	[CompilerGenerated]
	private Action<string, byte[]> m_Ticks;

	[CompilerGenerated]
	private Action<DrDjfgYdeuJS2KqRRX5b> dBSYXs0bamc;

	[CompilerGenerated]
	private Action<VQUp5GYc4fEFG1A4R01F> fJ4YXX1NIaf;

	[CompilerGenerated]
	private Action<VQUp5GYc4fEFG1A4R01F> a5EYXct7qq4;

	[CompilerGenerated]
	private Action<rginoPYEWJ2N98c8yybm> XwPYXjqVwAY;

	[CompilerGenerated]
	private Action<uVu1bPYdFSYNtHvpyi1f> AxMYXEZdUCB;

	[CompilerGenerated]
	private Action<g2aDPXYccy9KYR83W4tv> m_Order;

	[CompilerGenerated]
	private Action<GBCEGhYj8OBdqtMEbgmD> m_Position;

	[CompilerGenerated]
	private Action<GBCEGhYj8OBdqtMEbgmD[]> m_Positions;

	[CompilerGenerated]
	private Action<sL6wTZYjLnpqdk3BxHTV> NvAYXQCn7Lo;

	[CompilerGenerated]
	private Action<tu0W6xYRXmu1GsJGftj0> amIYXdhMrIG;

	[CompilerGenerated]
	private bool DotYXgqWOD0;

	private fikfkiYXVWYI6UabveGU jK9YXRWCFHd;

	private string c94YX66ahUM;

	[CompilerGenerated]
	private string ifpYXMhrFpb;

	[CompilerGenerated]
	private TimeSpan drtYXOx6u3u;

	internal static GIwcurYsIvQZaWl8SgkA b2Mj2YSxg3f7jIketXcg;

	public event Action Connected
	{
		[CompilerGenerated]
		add
		{
			Action action = this.m_Connected;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Yk3NNHSxM4OnHkslfFEr(action2, action3);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					action = Interlocked.CompareExchange(ref this.m_Connected, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			Action action = this.m_Connected;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)RsakuESxOd9Sr1dV14wb(action2, action3);
				action = Interlocked.CompareExchange(ref this.m_Connected, value2, action2);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					if ((object)action != action2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public event Action<bool> Disconnected
	{
		[CompilerGenerated]
		add
		{
			Action<bool> action = this.m_Disconnected;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Disconnected, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<bool> action = this.m_Disconnected;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Disconnected, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<KSEJIQYdDVOkeZU0LWU5[]> Symbols
	{
		[CompilerGenerated]
		add
		{
			Action<KSEJIQYdDVOkeZU0LWU5[]> action = this.m_Symbols;
			Action<KSEJIQYdDVOkeZU0LWU5[]> action2;
			do
			{
				action2 = action;
				Action<KSEJIQYdDVOkeZU0LWU5[]> value2 = (Action<KSEJIQYdDVOkeZU0LWU5[]>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Symbols, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<KSEJIQYdDVOkeZU0LWU5[]> action = this.m_Symbols;
			Action<KSEJIQYdDVOkeZU0LWU5[]> action2;
			do
			{
				action2 = action;
				Action<KSEJIQYdDVOkeZU0LWU5[]> value2 = (Action<KSEJIQYdDVOkeZU0LWU5[]>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Symbols, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<S48lmjYXrJ4Q59RxkkkG[]> Accounts
	{
		[CompilerGenerated]
		add
		{
			Action<S48lmjYXrJ4Q59RxkkkG[]> action = this.m_Accounts;
			Action<S48lmjYXrJ4Q59RxkkkG[]> action2;
			do
			{
				action2 = action;
				Action<S48lmjYXrJ4Q59RxkkkG[]> value2 = (Action<S48lmjYXrJ4Q59RxkkkG[]>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Accounts, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<S48lmjYXrJ4Q59RxkkkG[]> action = this.m_Accounts;
			Action<S48lmjYXrJ4Q59RxkkkG[]> action2;
			do
			{
				action2 = action;
				Action<S48lmjYXrJ4Q59RxkkkG[]> value2 = (Action<S48lmjYXrJ4Q59RxkkkG[]>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Accounts, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<string, byte[]> Ticks
	{
		[CompilerGenerated]
		add
		{
			Action<string, byte[]> action = this.m_Ticks;
			Action<string, byte[]> action2;
			do
			{
				action2 = action;
				Action<string, byte[]> value2 = (Action<string, byte[]>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Ticks, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string, byte[]> action = this.m_Ticks;
			Action<string, byte[]> action2;
			do
			{
				action2 = action;
				Action<string, byte[]> value2 = (Action<string, byte[]>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Ticks, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<uVu1bPYdFSYNtHvpyi1f> Trade
	{
		[CompilerGenerated]
		add
		{
			Action<uVu1bPYdFSYNtHvpyi1f> action = AxMYXEZdUCB;
			Action<uVu1bPYdFSYNtHvpyi1f> action2;
			do
			{
				action2 = action;
				Action<uVu1bPYdFSYNtHvpyi1f> value2 = (Action<uVu1bPYdFSYNtHvpyi1f>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref AxMYXEZdUCB, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<uVu1bPYdFSYNtHvpyi1f> action = AxMYXEZdUCB;
			Action<uVu1bPYdFSYNtHvpyi1f> action2;
			do
			{
				action2 = action;
				Action<uVu1bPYdFSYNtHvpyi1f> value2 = (Action<uVu1bPYdFSYNtHvpyi1f>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref AxMYXEZdUCB, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<g2aDPXYccy9KYR83W4tv> Order
	{
		[CompilerGenerated]
		add
		{
			Action<g2aDPXYccy9KYR83W4tv> action = this.m_Order;
			Action<g2aDPXYccy9KYR83W4tv> action2;
			do
			{
				action2 = action;
				Action<g2aDPXYccy9KYR83W4tv> value2 = (Action<g2aDPXYccy9KYR83W4tv>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Order, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<g2aDPXYccy9KYR83W4tv> action = this.m_Order;
			Action<g2aDPXYccy9KYR83W4tv> action2;
			do
			{
				action2 = action;
				Action<g2aDPXYccy9KYR83W4tv> value2 = (Action<g2aDPXYccy9KYR83W4tv>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Order, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<GBCEGhYj8OBdqtMEbgmD> Position
	{
		[CompilerGenerated]
		add
		{
			Action<GBCEGhYj8OBdqtMEbgmD> action = this.m_Position;
			Action<GBCEGhYj8OBdqtMEbgmD> action2;
			do
			{
				action2 = action;
				Action<GBCEGhYj8OBdqtMEbgmD> value2 = (Action<GBCEGhYj8OBdqtMEbgmD>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Position, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<GBCEGhYj8OBdqtMEbgmD> action = this.m_Position;
			Action<GBCEGhYj8OBdqtMEbgmD> action2;
			do
			{
				action2 = action;
				Action<GBCEGhYj8OBdqtMEbgmD> value2 = (Action<GBCEGhYj8OBdqtMEbgmD>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Position, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<GBCEGhYj8OBdqtMEbgmD[]> Positions
	{
		[CompilerGenerated]
		add
		{
			Action<GBCEGhYj8OBdqtMEbgmD[]> action = this.m_Positions;
			Action<GBCEGhYj8OBdqtMEbgmD[]> action2;
			do
			{
				action2 = action;
				Action<GBCEGhYj8OBdqtMEbgmD[]> value2 = (Action<GBCEGhYj8OBdqtMEbgmD[]>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Positions, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<GBCEGhYj8OBdqtMEbgmD[]> action = this.m_Positions;
			Action<GBCEGhYj8OBdqtMEbgmD[]> action2;
			do
			{
				action2 = action;
				Action<GBCEGhYj8OBdqtMEbgmD[]> value2 = (Action<GBCEGhYj8OBdqtMEbgmD[]>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Positions, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<sL6wTZYjLnpqdk3BxHTV> Portfolio
	{
		[CompilerGenerated]
		add
		{
			Action<sL6wTZYjLnpqdk3BxHTV> action = NvAYXQCn7Lo;
			Action<sL6wTZYjLnpqdk3BxHTV> action2;
			do
			{
				action2 = action;
				Action<sL6wTZYjLnpqdk3BxHTV> value2 = (Action<sL6wTZYjLnpqdk3BxHTV>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref NvAYXQCn7Lo, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<sL6wTZYjLnpqdk3BxHTV> action = NvAYXQCn7Lo;
			Action<sL6wTZYjLnpqdk3BxHTV> action2;
			do
			{
				action2 = action;
				Action<sL6wTZYjLnpqdk3BxHTV> value2 = (Action<sL6wTZYjLnpqdk3BxHTV>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref NvAYXQCn7Lo, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void uECYX0fW8BL(Action<DrDjfgYdeuJS2KqRRX5b> P_0)
	{
		Action<DrDjfgYdeuJS2KqRRX5b> action = dBSYXs0bamc;
		Action<DrDjfgYdeuJS2KqRRX5b> action2;
		do
		{
			action2 = action;
			Action<DrDjfgYdeuJS2KqRRX5b> value = (Action<DrDjfgYdeuJS2KqRRX5b>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref dBSYXs0bamc, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void TcbYX21IPSL(Action<DrDjfgYdeuJS2KqRRX5b> P_0)
	{
		Action<DrDjfgYdeuJS2KqRRX5b> action = dBSYXs0bamc;
		Action<DrDjfgYdeuJS2KqRRX5b> action2;
		do
		{
			action2 = action;
			Action<DrDjfgYdeuJS2KqRRX5b> value = (Action<DrDjfgYdeuJS2KqRRX5b>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref dBSYXs0bamc, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j5dYXfBSREp(Action<VQUp5GYc4fEFG1A4R01F> P_0)
	{
		Action<VQUp5GYc4fEFG1A4R01F> action = fJ4YXX1NIaf;
		Action<VQUp5GYc4fEFG1A4R01F> action2;
		do
		{
			action2 = action;
			Action<VQUp5GYc4fEFG1A4R01F> value = (Action<VQUp5GYc4fEFG1A4R01F>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref fJ4YXX1NIaf, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void MeuYX9oBROE(Action<VQUp5GYc4fEFG1A4R01F> P_0)
	{
		Action<VQUp5GYc4fEFG1A4R01F> action = fJ4YXX1NIaf;
		Action<VQUp5GYc4fEFG1A4R01F> action2;
		do
		{
			action2 = action;
			Action<VQUp5GYc4fEFG1A4R01F> value = (Action<VQUp5GYc4fEFG1A4R01F>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref fJ4YXX1NIaf, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void DUdYXGgxfp0(Action<VQUp5GYc4fEFG1A4R01F> P_0)
	{
		Action<VQUp5GYc4fEFG1A4R01F> action = a5EYXct7qq4;
		Action<VQUp5GYc4fEFG1A4R01F> action2;
		do
		{
			action2 = action;
			Action<VQUp5GYc4fEFG1A4R01F> value = (Action<VQUp5GYc4fEFG1A4R01F>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref a5EYXct7qq4, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Y0SYXYh0oHc(Action<VQUp5GYc4fEFG1A4R01F> P_0)
	{
		Action<VQUp5GYc4fEFG1A4R01F> action = a5EYXct7qq4;
		Action<VQUp5GYc4fEFG1A4R01F> action2;
		do
		{
			action2 = action;
			Action<VQUp5GYc4fEFG1A4R01F> value = (Action<VQUp5GYc4fEFG1A4R01F>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref a5EYXct7qq4, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void otmYXvf9yDg(Action<rginoPYEWJ2N98c8yybm> P_0)
	{
		Action<rginoPYEWJ2N98c8yybm> action = XwPYXjqVwAY;
		Action<rginoPYEWJ2N98c8yybm> action2;
		do
		{
			action2 = action;
			Action<rginoPYEWJ2N98c8yybm> value = (Action<rginoPYEWJ2N98c8yybm>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref XwPYXjqVwAY, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void OyRYXBFqlXK(Action<rginoPYEWJ2N98c8yybm> P_0)
	{
		Action<rginoPYEWJ2N98c8yybm> action = XwPYXjqVwAY;
		Action<rginoPYEWJ2N98c8yybm> action2;
		do
		{
			action2 = action;
			Action<rginoPYEWJ2N98c8yybm> value = (Action<rginoPYEWJ2N98c8yybm>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref XwPYXjqVwAY, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c4lYXxQt5Kt(Action<tu0W6xYRXmu1GsJGftj0> P_0)
	{
		Action<tu0W6xYRXmu1GsJGftj0> action = amIYXdhMrIG;
		Action<tu0W6xYRXmu1GsJGftj0> action2;
		do
		{
			action2 = action;
			Action<tu0W6xYRXmu1GsJGftj0> value = (Action<tu0W6xYRXmu1GsJGftj0>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref amIYXdhMrIG, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void jNbYXLG461M(Action<tu0W6xYRXmu1GsJGftj0> P_0)
	{
		Action<tu0W6xYRXmu1GsJGftj0> action = amIYXdhMrIG;
		Action<tu0W6xYRXmu1GsJGftj0> action2;
		do
		{
			action2 = action;
			Action<tu0W6xYRXmu1GsJGftj0> value = (Action<tu0W6xYRXmu1GsJGftj0>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref amIYXdhMrIG, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool xn4YsyZ5djc()
	{
		return DotYXgqWOD0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void yghYsZ7rnXn(bool P_0)
	{
		DotYXgqWOD0 = P_0;
	}

	public bool xWUloD1FdfW()
	{
		return true;
	}

	[SpecialName]
	[CompilerGenerated]
	public string uELYsCQ6Nmm()
	{
		return ifpYXMhrFpb;
	}

	[SpecialName]
	[CompilerGenerated]
	private void lkLYsrAwXCE(string P_0)
	{
		ifpYXMhrFpb = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public TimeSpan BslYsm3gDf9()
	{
		return drtYXOx6u3u;
	}

	[SpecialName]
	[CompilerGenerated]
	private void exWYshQlyKl(TimeSpan P_0)
	{
		drtYXOx6u3u = P_0;
	}

	public void dHqlnXLmFxp(string P_0, string P_1, TimeSpan P_2)
	{
		try
		{
			jK9YXRWCFHd = ((OperationContext)YtlEGMSxqpfnyvDEZsVX()).GetCallbackChannel<fikfkiYXVWYI6UabveGU>();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					cJXNjmYePuN0GOXdR3L2.h3YYeFKtwcR(P_0, this);
					return;
				}
				c94YX66ahUM = P_0;
				lkLYsrAwXCE(P_1);
				exWYshQlyKl(P_2);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
				{
					num = 0;
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public void Stop()
	{
		cJXNjmYePuN0GOXdR3L2.ra7Ye3ablqf(c94YX66ahUM);
		Action<bool> action = this.Disconnected;
		if (action != null)
		{
			action(obj: true);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void Uu4lobsMACD()
	{
		Action action = this.Connected;
		if (action != null)
		{
			EDpQevSxIjGF3GNLRnHg(action);
		}
	}

	public void YBsloNtGCL7()
	{
		this.Disconnected?.Invoke(obj: false);
	}

	public void UxKlokxSCCI(KSEJIQYdDVOkeZU0LWU5[] P_0)
	{
		this.Symbols?.Invoke(P_0);
	}

	public void PYSlo1BUi0R(S48lmjYXrJ4Q59RxkkkG[] P_0)
	{
		this.Accounts?.Invoke(P_0);
	}

	public void Hlslo5UTGnw(string P_0, byte[] P_1)
	{
		this.Ticks?.Invoke(P_0, P_1);
	}

	public void b9oloSDQXFb(DrDjfgYdeuJS2KqRRX5b P_0)
	{
		dBSYXs0bamc?.Invoke(P_0);
	}

	public void onMloxMsZn9(VQUp5GYc4fEFG1A4R01F P_0)
	{
		fJ4YXX1NIaf?.Invoke(P_0);
	}

	public void dqAloU7PJo5(VQUp5GYc4fEFG1A4R01F P_0)
	{
		a5EYXct7qq4?.Invoke(P_0);
	}

	public void mFTloLkqCv8(rginoPYEWJ2N98c8yybm P_0)
	{
		XwPYXjqVwAY?.Invoke(P_0);
	}

	public void MwQloeu8i7D(uVu1bPYdFSYNtHvpyi1f P_0)
	{
		AxMYXEZdUCB?.Invoke(P_0);
	}

	public void ThYlosYNvKY(g2aDPXYccy9KYR83W4tv P_0)
	{
		this.Order?.Invoke(P_0);
	}

	public void tTvloXtZnCt(GBCEGhYj8OBdqtMEbgmD P_0)
	{
		this.Position?.Invoke(P_0);
	}

	public void An4loTxdvGb(GBCEGhYj8OBdqtMEbgmD[] P_0)
	{
		this.Positions?.Invoke(P_0);
	}

	public void v51locvjv1v(sL6wTZYjLnpqdk3BxHTV P_0)
	{
		NvAYXQCn7Lo?.Invoke(P_0);
	}

	public void e0qlojeoQ0u(tu0W6xYRXmu1GsJGftj0 P_0)
	{
		amIYXdhMrIG?.Invoke(P_0);
	}

	public void xDhYstRP0Lp(d1GpgEYgqgbjOfI6nnLm P_0)
	{
		jK9YXRWCFHd.B9sloQFZKOB(P_0);
	}

	public void Subscribe(aGbZVwYQzDYUFR7Rkv5P sub)
	{
		jK9YXRWCFHd.Subscribe(sub);
	}

	public void tALYsURBKN9()
	{
		jK9YXRWCFHd.gvg5bW0rmux();
	}

	public void yIrYsTgFNyX(string P_0)
	{
		jK9YXRWCFHd.PnDlYXj2m35(P_0);
	}

	public GIwcurYsIvQZaWl8SgkA()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		c94YX66ahUM = string.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static GIwcurYsIvQZaWl8SgkA()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		RAHPbSSxWQKKyZJS1fPd();
	}

	internal static object Yk3NNHSxM4OnHkslfFEr(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static bool uvDgO6SxRYj2b9VtUquo()
	{
		return b2Mj2YSxg3f7jIketXcg == null;
	}

	internal static GIwcurYsIvQZaWl8SgkA wWPOgMSx6awjO17KhrdT()
	{
		return b2Mj2YSxg3f7jIketXcg;
	}

	internal static object RsakuESxOd9Sr1dV14wb(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object YtlEGMSxqpfnyvDEZsVX()
	{
		return OperationContext.Current;
	}

	internal static void EDpQevSxIjGF3GNLRnHg(object P_0)
	{
		P_0();
	}

	internal static void RAHPbSSxWQKKyZJS1fPd()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
