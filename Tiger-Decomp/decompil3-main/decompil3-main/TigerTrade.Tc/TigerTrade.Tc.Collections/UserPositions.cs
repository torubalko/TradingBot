using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

[DataContract(Name = "UserPositions", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Tc.Storage")]
public sealed class UserPositions : ICloneable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class jFKPciiv2DHf2rRX0G4o
	{
		public static readonly jFKPciiv2DHf2rRX0G4o a9Yiv9uu5AR;

		public static Func<KeyValuePair<string, UserPosition>, string> LkPivnHYiGt;

		public static Func<KeyValuePair<string, UserPosition>, UserPosition> LqvivGoL3CA;

		internal static jFKPciiv2DHf2rRX0G4o VGSS5qLMNwixeLlDOELy;

		static jFKPciiv2DHf2rRX0G4o()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			YfClRsLM5p2b9ePB3U0b();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			a9Yiv9uu5AR = new jFKPciiv2DHf2rRX0G4o();
		}

		public jFKPciiv2DHf2rRX0G4o()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal string s2CivH00eOZ(KeyValuePair<string, UserPosition> key)
		{
			return key.Key;
		}

		internal UserPosition jDYivf6xHdA(KeyValuePair<string, UserPosition> value)
		{
			return (UserPosition)value.Value.Clone();
		}

		internal static void YfClRsLM5p2b9ePB3U0b()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool VaAxEvLMkCnAOaebTf0U()
		{
			return VGSS5qLMNwixeLlDOELy == null;
		}

		internal static jFKPciiv2DHf2rRX0G4o MDOcEXLM1QRJgAVgeAgO()
		{
			return VGSS5qLMNwixeLlDOELy;
		}
	}

	private static readonly List<UserPosition> Empty;

	private Dictionary<string, UserPosition> _positions;

	private Dictionary<string, List<UserPosition>> _sortedPositions;

	private object _locker;

	internal static UserPositions Y2YS8GxAQUkQMfFlhdSd;

	[DataMember(Name = "Positions")]
	internal List<UserPosition> Positions
	{
		get
		{
			lock (_locker)
			{
				return _positions.Values.ToList();
			}
		}
		set
		{
			Init();
			foreach (UserPosition item in value)
			{
				Add(item);
			}
		}
	}

	private void Init()
	{
		int num;
		if (_positions == null)
		{
			_positions = new Dictionary<string, UserPosition>();
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0081;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		case 2:
			return;
		}
		goto IL_0081;
		IL_0081:
		if (_sortedPositions == null)
		{
			_sortedPositions = new Dictionary<string, List<UserPosition>>();
		}
		if (_locker == null)
		{
			_locker = new object();
			int num2 = 2;
			num = num2;
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
			{
				num = 1;
			}
		}
		goto IL_0009;
	}

	public void Add(UserPosition position)
	{
		object locker = _locker;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(locker, ref lockTaken);
			if (_positions.ContainsKey(position.PositionID))
			{
				return;
			}
			while (true)
			{
				_positions.Add(position.PositionID, position);
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						_sortedPositions[position.SymbolID].Add(position);
						return;
					case 1:
						if (!_sortedPositions.ContainsKey(position.SymbolID))
						{
							_sortedPositions.Add(position.SymbolID, new List<UserPosition>());
							num = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 2;
					}
					break;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				NSIw3txAR0oKui3xx7fe(locker);
			}
		}
	}

	internal UserPosition Get(string positionID)
	{
		object locker = _locker;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				int num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				case 1:
					if (!H5056txA6nUhtYtGGeZq(positionID) && _positions.ContainsKey(positionID))
					{
						return _positions[positionID];
					}
					break;
				}
				return null;
			}
			finally
			{
				if (lockTaken)
				{
					NSIw3txAR0oKui3xx7fe(locker);
				}
			}
		}
	}

	internal UserPosition Get(Symbol symbol, Account account)
	{
		object locker = _locker;
		bool lockTaken = false;
		UserPosition result = default(UserPosition);
		try
		{
			Monitor.Enter(locker, ref lockTaken);
			string text = (string)QlUIyExAMv7jGvSDadVk(symbol, account);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (!H5056txA6nUhtYtGGeZq(text) && _positions.ContainsKey(text))
					{
						result = _positions[text];
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
						{
							num = 1;
						}
						continue;
					}
					goto case 2;
				case 2:
					result = null;
					break;
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
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
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
				NSIw3txAR0oKui3xx7fe(locker);
			}
		}
		return result;
	}

	public List<UserPosition> GetAll()
	{
		lock (_locker)
		{
			return _positions.Values.ToList();
		}
	}

	public List<UserPosition> GetBySymbol(string symbolID)
	{
		lock (_locker)
		{
			return _sortedPositions.ContainsKey(symbolID) ? _sortedPositions[symbolID].ToList() : Empty;
		}
	}

	public UserPosition AddExecution(Execution execution, out UserDeal deal, out bool updated)
	{
		UserPosition userPosition = Get(UserPosition.GetID((Symbol)M2JDx9xAOvJ5I1BpbWZS(execution), execution.Account));
		if (userPosition == null)
		{
			userPosition = new UserPosition((ConnectionInfo)DpQjgvxAqZ00fhkmrOO6(execution), (Symbol)M2JDx9xAOvJ5I1BpbWZS(execution), execution.Account);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					Add(userPosition);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
		userPosition.AddExecution(execution, out deal, out updated);
		return userPosition;
	}

	public UserPosition Create(Symbol symbol, Account account)
	{
		UserPosition userPosition = Get(UserPosition.GetID(symbol, account));
		if (userPosition == null)
		{
			userPosition = new UserPosition(account.Connection, symbol, account);
			Add(userPosition);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		return userPosition;
	}

	public void Remove(UserPosition position)
	{
		lock (_locker)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
			{
				num = 0;
			}
			List<UserPosition>.Enumerator enumerator = default(List<UserPosition>.Enumerator);
			while (true)
			{
				switch (num)
				{
				default:
					_positions.Remove((string)CQgbxCxAImiCjWDDcWXK(position));
					if (!_sortedPositions.ContainsKey(position.SymbolID))
					{
						return;
					}
					enumerator = _sortedPositions[(string)IjhUZaxAWSTx0uBYa1Cr(position)].ToList().GetEnumerator();
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
					{
						num = 1;
					}
					break;
				case 1:
					try
					{
						while (enumerator.MoveNext())
						{
							UserPosition current = enumerator.Current;
							int num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
							{
								num2 = 0;
							}
							while (true)
							{
								switch (num2)
								{
								default:
									if (KFUultxAt6mk1QIm8RN5(current.PositionID, position.PositionID))
									{
										_sortedPositions[position.SymbolID].Remove(current);
										num2 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
										{
											num2 = 0;
										}
										continue;
									}
									break;
								case 1:
									break;
								}
								break;
							}
						}
						return;
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
				}
			}
		}
	}

	public void Clear()
	{
		object locker = _locker;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(locker, ref lockTaken);
			_positions.Clear();
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			tD8pyuxAUm6T2f97OpEJ(_sortedPositions);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(locker);
			}
		}
	}

	public object Clone()
	{
		return new UserPositions
		{
			_positions = _positions.ToDictionary((KeyValuePair<string, UserPosition> key) => key.Key, (KeyValuePair<string, UserPosition> value) => (UserPosition)value.Value.Clone())
		};
	}

	public UserPositions()
	{
		AKssOpxATDT55Ivjw5IA();
		_positions = new Dictionary<string, UserPosition>();
		_sortedPositions = new Dictionary<string, List<UserPosition>>();
		_locker = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserPositions()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		AKssOpxATDT55Ivjw5IA();
		Empty = new List<UserPosition>();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JNas7CxAdB6o8vonA6eM()
	{
		return Y2YS8GxAQUkQMfFlhdSd == null;
	}

	internal static UserPositions pkc46YxAgIqI1ScQOh3h()
	{
		return Y2YS8GxAQUkQMfFlhdSd;
	}

	internal static void NSIw3txAR0oKui3xx7fe(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool H5056txA6nUhtYtGGeZq(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object QlUIyExAMv7jGvSDadVk(object P_0, object P_1)
	{
		return UserPosition.GetID((Symbol)P_0, (Account)P_1);
	}

	internal static object M2JDx9xAOvJ5I1BpbWZS(object P_0)
	{
		return ((Execution)P_0).Symbol;
	}

	internal static object DpQjgvxAqZ00fhkmrOO6(object P_0)
	{
		return ((Execution)P_0).Connection;
	}

	internal static object CQgbxCxAImiCjWDDcWXK(object P_0)
	{
		return ((UserPosition)P_0).PositionID;
	}

	internal static object IjhUZaxAWSTx0uBYa1Cr(object P_0)
	{
		return ((UserPosition)P_0).SymbolID;
	}

	internal static bool KFUultxAt6mk1QIm8RN5(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void tD8pyuxAUm6T2f97OpEJ(object P_0)
	{
		((Dictionary<string, List<UserPosition>>)P_0).Clear();
	}

	internal static void AKssOpxATDT55Ivjw5IA()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}
}
