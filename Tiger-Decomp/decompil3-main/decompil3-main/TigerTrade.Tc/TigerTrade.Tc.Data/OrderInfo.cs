using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class OrderInfo
{
	private static OrderInfo Rbkh7A5FDLFZeBYArP18;

	public Order Order { get; }

	public OrderStatus Status { get; }

	public bool Silent { get; }

	public string ErrorMsg { get; set; }

	public OrderInfo(Order order, OrderStatus status, string errorMsg = "")
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Order = order;
				Status = status;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
				{
					num = 0;
				}
				break;
			default:
				Silent = order.Invisible;
				ErrorMsg = errorMsg;
				return;
			}
		}
	}

	static OrderInfo()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool FKr9ag5FbxVDdXbhqHFP()
	{
		return Rbkh7A5FDLFZeBYArP18 == null;
	}

	internal static OrderInfo dalOhp5FNnj988fQZ73F()
	{
		return Rbkh7A5FDLFZeBYArP18;
	}
}
