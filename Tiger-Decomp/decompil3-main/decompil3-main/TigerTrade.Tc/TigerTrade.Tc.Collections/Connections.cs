using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using k7lvGwG7nsmvY8cRB5pp;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

internal sealed class Connections
{
	[CompilerGenerated]
	private sealed class vamuo7ioMTKdeJKURxwx
	{
		public bool IGSioq1f4n0;

		private static vamuo7ioMTKdeJKURxwx Srn7jbL6WaqPTlC6wa4g;

		public vamuo7ioMTKdeJKURxwx()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool zdHioOwdhto(AdVNpgG79ErxvcbgBD1J c)
		{
			return c.mWXlYwTb86e.IsConnected == IGSioq1f4n0;
		}

		static vamuo7ioMTKdeJKURxwx()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool GaP3uHL6teYAlcqdeXFK()
		{
			return Srn7jbL6WaqPTlC6wa4g == null;
		}

		internal static vamuo7ioMTKdeJKURxwx keG2GYL6UUEC14yIhtO1()
		{
			return Srn7jbL6WaqPTlC6wa4g;
		}
	}

	[CompilerGenerated]
	private sealed class eyfEHBioIg3ITAnF59Z5
	{
		public string A8QiotA3V1l;

		private static eyfEHBioIg3ITAnF59Z5 XGHkvCL6T8s6yFEpWjLu;

		public eyfEHBioIg3ITAnF59Z5()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool qO2ioWyH6og(AdVNpgG79ErxvcbgBD1J client)
		{
			return (string)rUWyAqL6V8K88ZS0boY9(client.mWXlYwTb86e) == A8QiotA3V1l;
		}

		static eyfEHBioIg3ITAnF59Z5()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool lJL2YEL6yEviiKlFFk8m()
		{
			return XGHkvCL6T8s6yFEpWjLu == null;
		}

		internal static eyfEHBioIg3ITAnF59Z5 FmA1pWL6ZopqAgb3WbVt()
		{
			return XGHkvCL6T8s6yFEpWjLu;
		}

		internal static object rUWyAqL6V8K88ZS0boY9(object P_0)
		{
			return ((ConnectionInfo)P_0).TradeClientID;
		}
	}

	private readonly Dictionary<string, AdVNpgG79ErxvcbgBD1J> _clients;

	private readonly object _locker;

	internal static Connections aQQstyx84v4XF1L1yTom;

	public void Add(AdVNpgG79ErxvcbgBD1J client)
	{
		int num = 1;
		int num2 = num;
		object locker = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				locker = _locker;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				if (!_clients.ContainsKey(((ConnectionInfo)GPqsamx8NbwihUovDNAV(client)).ConnectionID))
				{
					_clients.Add(client.mWXlYwTb86e.ConnectionID, client);
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				return;
			}
			finally
			{
				if (!lockTaken)
				{
					int num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				else
				{
					Monitor.Exit(locker);
				}
			}
		}
	}

	public AdVNpgG79ErxvcbgBD1J Get(string connectionID)
	{
		if (string.IsNullOrEmpty(connectionID))
		{
			return null;
		}
		object locker = _locker;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(locker, ref lockTaken);
			if (_clients.ContainsKey(connectionID))
			{
				return _clients[connectionID];
			}
		}
		finally
		{
			if (lockTaken)
			{
				yK29kqx8kiPjJJ9jIC4p(locker);
			}
		}
		return null;
	}

	public IList<AdVNpgG79ErxvcbgBD1J> GetAll()
	{
		lock (_locker)
		{
			return _clients.Values.ToList();
		}
	}

	public IList<AdVNpgG79ErxvcbgBD1J> GetAll(bool isConnected)
	{
		vamuo7ioMTKdeJKURxwx CS_0024_003C_003E8__locals2 = new vamuo7ioMTKdeJKURxwx();
		CS_0024_003C_003E8__locals2.IGSioq1f4n0 = isConnected;
		lock (_locker)
		{
			return _clients.Values.Where((AdVNpgG79ErxvcbgBD1J c) => c.mWXlYwTb86e.IsConnected == CS_0024_003C_003E8__locals2.IGSioq1f4n0).ToList();
		}
	}

	public void Remove(string connectionID)
	{
		object locker = _locker;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(locker, ref lockTaken);
			if (_clients.ContainsKey(connectionID))
			{
				_clients.Remove(connectionID);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(locker);
			}
		}
	}

	internal bool ContainsTradeClient(string id)
	{
		eyfEHBioIg3ITAnF59Z5 CS_0024_003C_003E8__locals2 = new eyfEHBioIg3ITAnF59Z5();
		CS_0024_003C_003E8__locals2.A8QiotA3V1l = id;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
		{
			num = 1;
		}
		object locker = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
				locker = _locker;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
				{
					num = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				return _clients.Values.Any((AdVNpgG79ErxvcbgBD1J client) => (string)eyfEHBioIg3ITAnF59Z5.rUWyAqL6V8K88ZS0boY9(client.mWXlYwTb86e) == CS_0024_003C_003E8__locals2.A8QiotA3V1l);
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(locker);
				}
			}
		}
	}

	public Connections()
	{
		lEsNMfx81YqxRrTNp02S();
		_clients = new Dictionary<string, AdVNpgG79ErxvcbgBD1J>();
		_locker = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Connections()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object GPqsamx8NbwihUovDNAV(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
	}

	internal static bool BfLpnux8DcFxmgu81HEQ()
	{
		return aQQstyx84v4XF1L1yTom == null;
	}

	internal static Connections XVa41Nx8bLXAQ0cG5ea4()
	{
		return aQQstyx84v4XF1L1yTom;
	}

	internal static void yK29kqx8kiPjJJ9jIC4p(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void lEsNMfx81YqxRrTNp02S()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}
}
