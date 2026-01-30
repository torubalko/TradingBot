using System;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Threading;
using BfZtb759KlUg4482QKym;
using conBMMYBtKf7u05w6mBZ;
using GBTptOYlZysXFLCCB4JB;
using K1GcsD5GTtMSlaiJI0Xh;
using lKxADVYvSkLdNjbvOrBi;
using OX2b7TYbXbjH2i4QRB1T;
using Qk5NBsYoArSMdUZGlvTX;
using qY5ldEYYvSUIUQQ77oPO;
using T5ZjrgYo7gnddmdnjL0l;
using tBBmH4Ya1gMdS6owZ4UN;
using TigerTrade.Core.Utils.Logging;
using urffJxYvae90muGelARv;
using vSM8GrY41W7BCAxSYNEL;
using vZnnVkYDnry7DpKxoAu6;
using wiKheyYlFtxtdvACwDSe;
using x97CE55GhEYKgt7TSVZT;
using yIl9ETYoJmR0T9XqLZUb;
using YYikqHYinlbJd3fAKXQw;

namespace bYxFbPYYrqjybhgB9DQV;

internal sealed class n1XWCwYYCGV7oxrtFA9w : mKyqoyYowvDkEeBEo1eA
{
	[CompilerGenerated]
	private Action m_Connected;

	[CompilerGenerated]
	private Action<bool> m_Disconnected;

	[CompilerGenerated]
	private Action<mJ4PtaYlyx9OwiiAYiE6[]> m_Symbols;

	[CompilerGenerated]
	private Action<mCMoDUYoPpg9XOXnETgw[]> m_Accounts;

	[CompilerGenerated]
	private Action<string, byte[]> m_Ticks;

	[CompilerGenerated]
	private Action<Av0ZjvYlJa9VldBWm8Fn> Q88YodhjrlT;

	[CompilerGenerated]
	private Action<Soi9F3YvBpUWe4vk9UAq> iYaYog8Y5CN;

	[CompilerGenerated]
	private Action<MhypANYi9h2fDLRUrR3d> WdmYoR0IWI5;

	[CompilerGenerated]
	private Action<YKo5OsY4krj5Aou5U5ZM> vdwYo6R9IAV;

	[CompilerGenerated]
	private Action<Eckcw3Yv5NOg4bCrD6Hb> m_Order;

	[CompilerGenerated]
	private Action<zPK74CYakrQXC7jZKDXc> m_Position;

	[CompilerGenerated]
	private Action<UXs7tXYBWXaq62OHgYEN> G6AYoMIwiZ0;

	[CompilerGenerated]
	private Action<ON0ubVYbs7yv2WLb4qg3> x4TYoO8SfIY;

	[CompilerGenerated]
	private Action VaZYoqJkEED;

	[CompilerGenerated]
	private bool uheYoINULIy;

	private x1LyagYo83y8Ar0GEt6Y vEMYoWSBZyq;

	private string tLQYot6XcMa;

	internal static n1XWCwYYCGV7oxrtFA9w Dp0ekySvOhrAg2NR0ae3;

	public event Action Connected
	{
		[CompilerGenerated]
		add
		{
			Action action = this.m_Connected;
			Action action2;
			do
			{
				action2 = action;
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
					{
						Action value2 = (Action)Delegate.Combine(action2, b);
						action = Interlocked.CompareExchange(ref this.m_Connected, value2, action2);
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
						{
							num = 0;
						}
						continue;
					}
					case 1:
						break;
					}
					break;
				}
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = this.m_Connected;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Connected, value2, action2);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
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
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
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

	public event Action<mJ4PtaYlyx9OwiiAYiE6[]> Symbols
	{
		[CompilerGenerated]
		add
		{
			Action<mJ4PtaYlyx9OwiiAYiE6[]> action = this.m_Symbols;
			Action<mJ4PtaYlyx9OwiiAYiE6[]> action2;
			do
			{
				action2 = action;
				Action<mJ4PtaYlyx9OwiiAYiE6[]> value2 = (Action<mJ4PtaYlyx9OwiiAYiE6[]>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Symbols, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<mJ4PtaYlyx9OwiiAYiE6[]> action = this.m_Symbols;
			Action<mJ4PtaYlyx9OwiiAYiE6[]> action2;
			do
			{
				action2 = action;
				Action<mJ4PtaYlyx9OwiiAYiE6[]> value2 = (Action<mJ4PtaYlyx9OwiiAYiE6[]>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Symbols, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<mCMoDUYoPpg9XOXnETgw[]> Accounts
	{
		[CompilerGenerated]
		add
		{
			Action<mCMoDUYoPpg9XOXnETgw[]> action = this.m_Accounts;
			Action<mCMoDUYoPpg9XOXnETgw[]> action2;
			do
			{
				action2 = action;
				Action<mCMoDUYoPpg9XOXnETgw[]> value2 = (Action<mCMoDUYoPpg9XOXnETgw[]>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Accounts, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<mCMoDUYoPpg9XOXnETgw[]> action = this.m_Accounts;
			Action<mCMoDUYoPpg9XOXnETgw[]> action2;
			do
			{
				action2 = action;
				Action<mCMoDUYoPpg9XOXnETgw[]> value2 = (Action<mCMoDUYoPpg9XOXnETgw[]>)Delegate.Remove(action2, value3);
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

	public event Action<YKo5OsY4krj5Aou5U5ZM> Trade
	{
		[CompilerGenerated]
		add
		{
			Action<YKo5OsY4krj5Aou5U5ZM> action = vdwYo6R9IAV;
			Action<YKo5OsY4krj5Aou5U5ZM> action2;
			do
			{
				action2 = action;
				Action<YKo5OsY4krj5Aou5U5ZM> value2 = (Action<YKo5OsY4krj5Aou5U5ZM>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref vdwYo6R9IAV, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<YKo5OsY4krj5Aou5U5ZM> action = vdwYo6R9IAV;
			Action<YKo5OsY4krj5Aou5U5ZM> action2;
			do
			{
				action2 = action;
				Action<YKo5OsY4krj5Aou5U5ZM> value2 = (Action<YKo5OsY4krj5Aou5U5ZM>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref vdwYo6R9IAV, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<Eckcw3Yv5NOg4bCrD6Hb> Order
	{
		[CompilerGenerated]
		add
		{
			Action<Eckcw3Yv5NOg4bCrD6Hb> action = this.m_Order;
			Action<Eckcw3Yv5NOg4bCrD6Hb> action2;
			do
			{
				action2 = action;
				Action<Eckcw3Yv5NOg4bCrD6Hb> value2 = (Action<Eckcw3Yv5NOg4bCrD6Hb>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Order, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Eckcw3Yv5NOg4bCrD6Hb> action = this.m_Order;
			Action<Eckcw3Yv5NOg4bCrD6Hb> action2;
			do
			{
				action2 = action;
				Action<Eckcw3Yv5NOg4bCrD6Hb> value2 = (Action<Eckcw3Yv5NOg4bCrD6Hb>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Order, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<zPK74CYakrQXC7jZKDXc> Position
	{
		[CompilerGenerated]
		add
		{
			Action<zPK74CYakrQXC7jZKDXc> action = this.m_Position;
			Action<zPK74CYakrQXC7jZKDXc> action2;
			do
			{
				action2 = action;
				Action<zPK74CYakrQXC7jZKDXc> value2 = (Action<zPK74CYakrQXC7jZKDXc>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Position, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<zPK74CYakrQXC7jZKDXc> action = this.m_Position;
			Action<zPK74CYakrQXC7jZKDXc> action2;
			do
			{
				action2 = action;
				Action<zPK74CYakrQXC7jZKDXc> value2 = (Action<zPK74CYakrQXC7jZKDXc>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Position, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<UXs7tXYBWXaq62OHgYEN> Portfolio
	{
		[CompilerGenerated]
		add
		{
			Action<UXs7tXYBWXaq62OHgYEN> action = G6AYoMIwiZ0;
			Action<UXs7tXYBWXaq62OHgYEN> action2;
			do
			{
				action2 = action;
				Action<UXs7tXYBWXaq62OHgYEN> value2 = (Action<UXs7tXYBWXaq62OHgYEN>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref G6AYoMIwiZ0, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<UXs7tXYBWXaq62OHgYEN> action = G6AYoMIwiZ0;
			Action<UXs7tXYBWXaq62OHgYEN> action2;
			do
			{
				action2 = action;
				Action<UXs7tXYBWXaq62OHgYEN> value2 = (Action<UXs7tXYBWXaq62OHgYEN>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref G6AYoMIwiZ0, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void u9eYooQrkGp(Action<Av0ZjvYlJa9VldBWm8Fn> P_0)
	{
		Action<Av0ZjvYlJa9VldBWm8Fn> action = Q88YodhjrlT;
		Action<Av0ZjvYlJa9VldBWm8Fn> action2;
		do
		{
			action2 = action;
			Action<Av0ZjvYlJa9VldBWm8Fn> value = (Action<Av0ZjvYlJa9VldBWm8Fn>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref Q88YodhjrlT, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void aqyYovcDSKT(Action<Av0ZjvYlJa9VldBWm8Fn> P_0)
	{
		Action<Av0ZjvYlJa9VldBWm8Fn> action = Q88YodhjrlT;
		Action<Av0ZjvYlJa9VldBWm8Fn> action2;
		do
		{
			action2 = action;
			Action<Av0ZjvYlJa9VldBWm8Fn> value = (Action<Av0ZjvYlJa9VldBWm8Fn>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref Q88YodhjrlT, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void b2kYoaeFgp9(Action<Soi9F3YvBpUWe4vk9UAq> P_0)
	{
		Action<Soi9F3YvBpUWe4vk9UAq> action = iYaYog8Y5CN;
		Action<Soi9F3YvBpUWe4vk9UAq> action2;
		do
		{
			action2 = action;
			Action<Soi9F3YvBpUWe4vk9UAq> value = (Action<Soi9F3YvBpUWe4vk9UAq>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref iYaYog8Y5CN, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Jx9YoiRxqA2(Action<Soi9F3YvBpUWe4vk9UAq> P_0)
	{
		Action<Soi9F3YvBpUWe4vk9UAq> action = iYaYog8Y5CN;
		Action<Soi9F3YvBpUWe4vk9UAq> action2;
		do
		{
			action2 = action;
			Action<Soi9F3YvBpUWe4vk9UAq> value = (Action<Soi9F3YvBpUWe4vk9UAq>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref iYaYog8Y5CN, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void UlXYo43XMTg(Action<MhypANYi9h2fDLRUrR3d> P_0)
	{
		Action<MhypANYi9h2fDLRUrR3d> action = WdmYoR0IWI5;
		Action<MhypANYi9h2fDLRUrR3d> action2;
		do
		{
			action2 = action;
			Action<MhypANYi9h2fDLRUrR3d> value = (Action<MhypANYi9h2fDLRUrR3d>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref WdmYoR0IWI5, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void skLYoDyqNW8(Action<MhypANYi9h2fDLRUrR3d> P_0)
	{
		Action<MhypANYi9h2fDLRUrR3d> action = WdmYoR0IWI5;
		Action<MhypANYi9h2fDLRUrR3d> action2;
		do
		{
			action2 = action;
			Action<MhypANYi9h2fDLRUrR3d> value = (Action<MhypANYi9h2fDLRUrR3d>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref WdmYoR0IWI5, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void RfGYosF4R7y(Action<ON0ubVYbs7yv2WLb4qg3> P_0)
	{
		Action<ON0ubVYbs7yv2WLb4qg3> action = x4TYoO8SfIY;
		Action<ON0ubVYbs7yv2WLb4qg3> action2;
		do
		{
			action2 = action;
			Action<ON0ubVYbs7yv2WLb4qg3> value = (Action<ON0ubVYbs7yv2WLb4qg3>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref x4TYoO8SfIY, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void nWxYoX4oRIg(Action<ON0ubVYbs7yv2WLb4qg3> P_0)
	{
		Action<ON0ubVYbs7yv2WLb4qg3> action = x4TYoO8SfIY;
		Action<ON0ubVYbs7yv2WLb4qg3> action2;
		do
		{
			action2 = action;
			Action<ON0ubVYbs7yv2WLb4qg3> value = (Action<ON0ubVYbs7yv2WLb4qg3>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref x4TYoO8SfIY, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void NZpYojbgLJa(Action P_0)
	{
		Action action = VaZYoqJkEED;
		while (true)
		{
			Action action2 = action;
			Action value = (Action)Delegate.Combine(action2, P_0);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					break;
				}
				action = Interlocked.CompareExchange(ref VaZYoqJkEED, value, action2);
				if ((object)action != action2)
				{
					break;
				}
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
				{
					num = 0;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void MfMYoExekwA(Action P_0)
	{
		Action action = VaZYoqJkEED;
		while (true)
		{
			Action action2 = action;
			Action value = (Action)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref VaZYoqJkEED, value, action2);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c != 0)
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
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool o8KYYFLZU9G()
	{
		return uheYoINULIy;
	}

	[SpecialName]
	[CompilerGenerated]
	public void YTHYY3wwTbO(bool P_0)
	{
		uheYoINULIy = P_0;
	}

	public bool xWUloD1FdfW()
	{
		return true;
	}

	public void dHqlnXLmFxp(string P_0)
	{
		try
		{
			vEMYoWSBZyq = OperationContext.Current.GetCallbackChannel<x1LyagYo83y8Ar0GEt6Y>();
			tLQYot6XcMa = P_0;
			RWNL5eYYohrZ2yJBifOp.eiiYYBl4Cle(P_0, this);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public void Stop()
	{
		RWNL5eYYohrZ2yJBifOp.OqCYYagG0Qu(tLQYot6XcMa);
		Action<bool> action = this.Disconnected;
		if (action != null)
		{
			action(obj: true);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
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
			wA5aVgSvWqPsLTShafqW(action);
		}
	}

	public void YBsloNtGCL7()
	{
		this.Disconnected?.Invoke(obj: false);
	}

	public void UxKlokxSCCI(mJ4PtaYlyx9OwiiAYiE6[] P_0)
	{
		this.Symbols?.Invoke(P_0);
	}

	public void PYSlo1BUi0R(mCMoDUYoPpg9XOXnETgw[] P_0)
	{
		this.Accounts?.Invoke(P_0);
	}

	public void Hlslo5UTGnw(string P_0, byte[] P_1)
	{
		this.Ticks?.Invoke(P_0, P_1);
	}

	public void b9oloSDQXFb(Av0ZjvYlJa9VldBWm8Fn P_0)
	{
		Q88YodhjrlT?.Invoke(P_0);
	}

	public void onMloxMsZn9(Soi9F3YvBpUWe4vk9UAq P_0)
	{
		iYaYog8Y5CN?.Invoke(P_0);
	}

	public void mFTloLkqCv8(MhypANYi9h2fDLRUrR3d P_0)
	{
		WdmYoR0IWI5?.Invoke(P_0);
	}

	public void MwQloeu8i7D(YKo5OsY4krj5Aou5U5ZM P_0)
	{
		vdwYo6R9IAV?.Invoke(P_0);
	}

	public void ThYlosYNvKY(Eckcw3Yv5NOg4bCrD6Hb P_0)
	{
		this.Order?.Invoke(P_0);
	}

	public void tTvloXtZnCt(zPK74CYakrQXC7jZKDXc P_0)
	{
		this.Position?.Invoke(P_0);
	}

	public void v51locvjv1v(UXs7tXYBWXaq62OHgYEN P_0)
	{
		G6AYoMIwiZ0?.Invoke(P_0);
	}

	public void e0qlojeoQ0u(ON0ubVYbs7yv2WLb4qg3 P_0)
	{
		x4TYoO8SfIY?.Invoke(P_0);
	}

	public void lLJloEl1YxK()
	{
		Action action = VaZYoqJkEED;
		if (action != null)
		{
			wA5aVgSvWqPsLTShafqW(action);
		}
	}

	public void eYFYYKULQgZ(n1iJxrYD95hlVUridLEE P_0)
	{
		vEMYoWSBZyq.B9sloQFZKOB(P_0);
	}

	public void gJuYYm7avrA(string P_0)
	{
		vEMYoWSBZyq.gtDlodYSyiE(P_0);
	}

	public void uR1YYhvpT95(string P_0)
	{
		vEMYoWSBZyq.p42log7iNy8(P_0);
	}

	public void ssfYYwPCTgO(string P_0)
	{
		vEMYoWSBZyq.lrUloRXiXCY(P_0);
	}

	public void IfkYY70hFxB(string P_0)
	{
		vEMYoWSBZyq.FV8lo6vJwXE(P_0);
	}

	public void WNmYY8kc0Yr(string P_0)
	{
		vEMYoWSBZyq.oQPloM6Pfcb(P_0);
	}

	public void e00YYAqocE9(string P_0)
	{
		vEMYoWSBZyq.XebloOnFjYO(P_0);
	}

	public void vZ9YYPeOjwN()
	{
		vEMYoWSBZyq.gvg5bW0rmux();
	}

	public void BJgYYJR4Tgv(string P_0)
	{
		vEMYoWSBZyq.PnDlYXj2m35(P_0);
	}

	public n1XWCwYYCGV7oxrtFA9w()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		tLQYot6XcMa = string.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static n1XWCwYYCGV7oxrtFA9w()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool PXZ0biSvqVpsUcUMOSKp()
	{
		return Dp0ekySvOhrAg2NR0ae3 == null;
	}

	internal static n1XWCwYYCGV7oxrtFA9w j77GOrSvIg0DLTJ7J01M()
	{
		return Dp0ekySvOhrAg2NR0ae3;
	}

	internal static void wA5aVgSvWqPsLTShafqW(object P_0)
	{
		P_0();
	}
}
