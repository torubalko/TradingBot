using System;
using System.Windows.Input;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace QSf8R5iuIoHg3nPXYEYS;

internal sealed class F5Ux3RiuqLSaMmKMukm1 : ICommand
{
	private readonly Action<object> eoeiuWTZgjT;

	private readonly Predicate<object> jSriut6op3W;

	internal static F5Ux3RiuqLSaMmKMukm1 hh46jlXvTAh8isqbYOp4;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			MolOPXXvVHFp9EXeEXmv(eventHandler);
		}
		remove
		{
			CommandManager.RequerySuggested -= value2;
		}
	}

	public F5Ux3RiuqLSaMmKMukm1(Action<object> P_0)
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		this._002Ector(P_0, null);
	}

	public F5Ux3RiuqLSaMmKMukm1(Action<object> P_0, Predicate<object> P_1)
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
		eoeiuWTZgjT = P_0;
		jSriut6op3W = P_1;
	}

	public bool CanExecute(object P_0)
	{
		int num = 2;
		int num2 = num;
		bool result2 = default(bool);
		int result;
		while (true)
		{
			switch (num2)
			{
			default:
				return result2;
			case 2:
				if (jSriut6op3W != null)
				{
					result = (jSriut6op3W(P_0) ? 1 : 0);
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_ead17c0106b44a49af4758c71ff2ff4b == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				result = 1;
				break;
			}
			break;
		}
		return (byte)result != 0;
	}

	public void Execute(object P_0)
	{
		eoeiuWTZgjT(P_0);
	}

	static F5Ux3RiuqLSaMmKMukm1()
	{
		RkA3OYXvCXAEE5h5vHWX();
		xtrJkyXvr4ajcHpv4ZsU();
	}

	internal static void MolOPXXvVHFp9EXeEXmv(object P_0)
	{
		CommandManager.RequerySuggested += (EventHandler)P_0;
	}

	internal static bool M4RjSnXvy66wwsaOIFun()
	{
		return hh46jlXvTAh8isqbYOp4 == null;
	}

	internal static F5Ux3RiuqLSaMmKMukm1 NtcmlIXvZ4bSljlWH2PZ()
	{
		return hh46jlXvTAh8isqbYOp4;
	}

	internal static void RkA3OYXvCXAEE5h5vHWX()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static void xtrJkyXvr4ajcHpv4ZsU()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}
}
