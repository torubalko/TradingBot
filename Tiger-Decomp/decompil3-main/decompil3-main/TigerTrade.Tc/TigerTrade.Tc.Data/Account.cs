using System.Collections.Generic;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Account
{
	private readonly HashSet<string> _classCodes;

	internal static Account SDHZgk5Axr81HD0cmJ4Z;

	public ConnectionInfo Connection { get; }

	public string ConnectionID { get; }

	internal string UniqueID { get; }

	public string Name { get; set; }

	public string Currency { get; set; }

	public string Union { get; set; }

	public bool Simulator { get; internal set; }

	public bool Trust { get; internal set; }

	public Dictionary<string, decimal> TrustAccounts { get; internal set; }

	internal string FcmId { get; set; }

	internal string IbId { get; set; }

	internal string InternalID { get; set; }

	internal string ClientCode { get; set; }

	internal int NumId { get; set; }

	internal Dictionary<string, string> TradeRoutes { get; set; }

	internal bool HedgeMode { get; set; }

	internal bool IsTradeAllowed { get; set; }

	public bool IsPlayer => AccountID.StartsWith((string)OY0Rlx5AsifaTqKInNUj(0x16AD7E76 ^ 0x16ADD8AA));

	public bool IsSimulator => AccountID.StartsWith((string)OY0Rlx5AsifaTqKInNUj(--737722733 ^ 0x2BF81EFD));

	public bool IsLive
	{
		get
		{
			if (!IsPlayer)
			{
				return !IsSimulator;
			}
			return false;
		}
	}

	public string AccountID => (string)eKJJTu5AckvB3p3ldBTE(ConnectionID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x22BF43FC ^ 0x22BFA6E2), UniqueID);

	public Account(ConnectionInfo connection, string uniqueID)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		_classCodes = new HashSet<string>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				ConnectionID = (string)GqKpYu5AXK6g0QPl72QR(connection);
				UniqueID = uniqueID;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
				{
					num = 0;
				}
				break;
			default:
				TradeRoutes = new Dictionary<string, string>();
				ClientCode = "";
				return;
			case 2:
				Connection = connection;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public static string GetUniqueID(string id)
	{
		if (WHKXlM5AjGfLdQIUlanj(id) || !id.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-991861155 ^ -991853757)))
		{
			return id;
		}
		return id.Split('@')[1];
	}

	public static string GetConnectionID(string id)
	{
		if (string.IsNullOrEmpty(id) || !id.Contains((string)OY0Rlx5AsifaTqKInNUj(--927068468 ^ 0x3741142A)))
		{
			return "";
		}
		return id.Split('@')[0];
	}

	public void SetClassCodes(string classCodes)
	{
		int num = 4;
		int num2 = num;
		string text = default(string);
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_classCodes.Add(text);
				goto IL_0030;
			case 2:
				if (!_classCodes.Contains(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0030;
			case 4:
				array = classCodes.Split('|');
				num2 = 3;
				break;
			case 3:
				{
					num3 = 0;
					goto IL_003b;
				}
				IL_0030:
				num3++;
				goto IL_003b;
				IL_003b:
				if (num3 >= array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
					{
						num2 = 0;
					}
					break;
				}
				text = array[num3];
				if (!WHKXlM5AjGfLdQIUlanj(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_0030;
			}
		}
	}

	public bool ContainsClassCode(string classCode)
	{
		if (Exk91m5AEY4Ih6w3kCDl(_classCodes) != 0 && !string.IsNullOrEmpty(classCode))
		{
			return _classCodes.Contains(classCode);
		}
		return true;
	}

	public bool ContainsClassCodes()
	{
		return _classCodes.Count > 0;
	}

	public override string ToString()
	{
		return Name;
	}

	static Account()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool ievC7V5ALsoAWaZQqjw3()
	{
		return SDHZgk5Axr81HD0cmJ4Z == null;
	}

	internal static Account Wpe0Ee5AelnfPjhwH7Fd()
	{
		return SDHZgk5Axr81HD0cmJ4Z;
	}

	internal static object OY0Rlx5AsifaTqKInNUj(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object GqKpYu5AXK6g0QPl72QR(object P_0)
	{
		return ((ConnectionInfo)P_0).ConnectionID;
	}

	internal static object eKJJTu5AckvB3p3ldBTE(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool WHKXlM5AjGfLdQIUlanj(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int Exk91m5AEY4Ih6w3kCDl(object P_0)
	{
		return ((HashSet<string>)P_0).Count;
	}
}
