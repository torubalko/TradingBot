using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using wD2D07vwPIrV2JDl7658;
using x97CE55GhEYKgt7TSVZT;

namespace tTtpErvw3ufi8BSQGCNJ;

internal abstract class zZicx0vwFCtLOpvTueqh : zFlAHNvwA9yqWBn2mYyo
{
	[CompilerGenerated]
	private IDictionary<string, string> E0uvwzMWu2t;

	internal static zZicx0vwFCtLOpvTueqh qFmK3XxbDKUD3XZXxqRA;

	public IDictionary<string, string> Filter
	{
		[CompilerGenerated]
		get
		{
			return E0uvwzMWu2t;
		}
		[CompilerGenerated]
		set
		{
			E0uvwzMWu2t = e0uvwzMWu2t;
		}
	}

	public override string MlPl9kI3Tww()
	{
		string text = base.MlPl9kI3Tww();
		int num;
		if (Filter != null)
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		object obj = string.Empty;
		goto IL_0155;
		IL_0009:
		string text2 = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x68C7EAE6 ^ 0x68C6B76A) + text2;
			case 1:
				break;
			case 2:
				return text2;
			case 3:
				if (!dd8nvoxb5uXopnr8aZW6(text))
				{
					if (string.IsNullOrWhiteSpace(text2))
					{
						return text;
					}
					if (dd8nvoxb5uXopnr8aZW6(text2) || string.IsNullOrWhiteSpace(text))
					{
						return string.Empty;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
					{
						num = 1;
					}
				}
				continue;
			}
			break;
		}
		obj = mnykdGxbkYlXcNSdp4VT(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-29702950 ^ -29658026), HttpUtility.UrlEncode(JsonConvert.SerializeObject((object)Filter)));
		goto IL_0155;
		IL_0155:
		string text3 = (string)obj;
		text2 = string.Join((string)BnfPjCxb1ULZN0Q2JfCA(-837284864 ^ -837201524), text3) ?? "";
		num = 3;
		goto IL_0009;
	}

	protected zZicx0vwFCtLOpvTueqh()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static zZicx0vwFCtLOpvTueqh()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object mnykdGxbkYlXcNSdp4VT(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object BnfPjCxb1ULZN0Q2JfCA(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool dd8nvoxb5uXopnr8aZW6(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool GjDykaxbbcgeuTxDkSi2()
	{
		return qFmK3XxbDKUD3XZXxqRA == null;
	}

	internal static zZicx0vwFCtLOpvTueqh Pl9nZbxbNxPA7W8khkFR()
	{
		return qFmK3XxbDKUD3XZXxqRA;
	}
}
