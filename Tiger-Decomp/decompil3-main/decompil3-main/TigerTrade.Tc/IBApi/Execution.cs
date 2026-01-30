using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using ULHF81GIBUcAq4qClu22;
using x97CE55GhEYKgt7TSVZT;

namespace IBApi;

internal class Execution
{
	internal static Execution Si8ZXg5MeNtHZxjs5oxn;

	public int OrderId { get; set; }

	public int ClientId { get; set; }

	public string ExecId { get; set; }

	public string Time { get; set; }

	public string AcctNumber { get; set; }

	public string Exchange { get; set; }

	public string Side { get; set; }

	public double Shares { get; set; }

	public double Price { get; set; }

	public int PermId { get; set; }

	public int Liquidation { get; set; }

	public double CumQty { get; set; }

	public double AvgPrice { get; set; }

	public string OrderRef { get; set; }

	public string EvRule { get; set; }

	public double EvMultiplier { get; set; }

	public string ModelCode { get; set; }

	public atSvyBGIvnuIbxoRqL7d LastLiquidity { get; set; }

	public Execution()
	{
		Je5m3e5Mc41COyPKFNle();
		base._002Ector();
		OrderId = 0;
		ClientId = 0;
		Shares = 0.0;
		Price = 0.0;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				EvMultiplier = 0.0;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				CumQty = 0.0;
				AvgPrice = 0.0;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				LastLiquidity = new atSvyBGIvnuIbxoRqL7d(0);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
				{
					num = 2;
				}
				break;
			case 3:
				PermId = 0;
				Liquidation = 0;
				num = 4;
				break;
			}
		}
	}

	public Execution(int orderId, int clientId, string execId, string time, string acctNumber, string exchange, string side, double shares, double price, int permId, int liquidation, double cumQty, double avgPrice, string orderRef, string evRule, double evMultiplier, string modelCode, atSvyBGIvnuIbxoRqL7d lastLiquidity)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		OrderId = orderId;
		ClientId = clientId;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				CumQty = cumQty;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
				{
					num = 0;
				}
				break;
			case 4:
				Liquidation = liquidation;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
				{
					num = 0;
				}
				break;
			case 6:
				Time = time;
				AcctNumber = acctNumber;
				Exchange = exchange;
				Side = side;
				Shares = shares;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
				{
					num = 7;
				}
				break;
			case 5:
				return;
			case 3:
				ExecId = execId;
				num = 6;
				break;
			case 2:
				OrderRef = orderRef;
				EvRule = evRule;
				EvMultiplier = evMultiplier;
				ModelCode = modelCode;
				LastLiquidity = lastLiquidity;
				num = 5;
				break;
			case 7:
				Price = price;
				PermId = permId;
				num = 4;
				break;
			default:
				AvgPrice = avgPrice;
				num = 2;
				break;
			}
		}
	}

	public override bool Equals(object p_other)
	{
		int num = 1;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (this != p_other)
				{
					Execution execution = (Execution)p_other;
					result = string.Compare(ExecId, execution.ExecId, ignoreCase: true) == 0;
					goto case 3;
				}
				result = true;
				num2 = 3;
				break;
			case 3:
			case 4:
				return result;
			default:
				if (p_other == null)
				{
					result = false;
					num2 = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 1:
				result = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static Execution()
	{
		VsG4iF5MjBLe5eAPncar();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool E1D4Ex5MsANTi72PitIv()
	{
		return Si8ZXg5MeNtHZxjs5oxn == null;
	}

	internal static Execution dYTOjI5MXFKtxuLdCJ7m()
	{
		return Si8ZXg5MeNtHZxjs5oxn;
	}

	internal static void Je5m3e5Mc41COyPKFNle()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void VsG4iF5MjBLe5eAPncar()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
