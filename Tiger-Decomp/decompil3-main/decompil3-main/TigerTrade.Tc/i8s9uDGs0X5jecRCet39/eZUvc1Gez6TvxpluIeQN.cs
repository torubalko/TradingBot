using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace i8s9uDGs0X5jecRCet39;

[DefaultMember("Item")]
internal class eZUvc1Gez6TvxpluIeQN
{
	private int f31GsnFYqrU;

	private static eZUvc1Gez6TvxpluIeQN sp3V765jOCZZ6Fi9rrp6;

	public eZUvc1Gez6TvxpluIeQN(int P_0)
	{
		cLlVZW5jWVkmOnC0S6ay();
		base._002Ector();
		f31GsnFYqrU = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public int aEFGs21FOVK()
	{
		return f31GsnFYqrU;
	}

	public void Clear()
	{
		f31GsnFYqrU = 0;
	}

	[SpecialName]
	public bool SpUGsHnNFit(int P_0)
	{
		if (P_0 >= 32)
		{
			throw new IndexOutOfRangeException();
		}
		return (f31GsnFYqrU & (1 << P_0)) != 0;
	}

	[SpecialName]
	public void iuZGsfEJVXj(int P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new IndexOutOfRangeException();
			case 1:
				if (P_0 < 32)
				{
					if (P_1)
					{
						f31GsnFYqrU |= 1 << P_0;
					}
					else
					{
						f31GsnFYqrU &= ~(1 << P_0);
					}
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static eZUvc1Gez6TvxpluIeQN()
	{
		mPjVwN5jtfAIKQ3SrkeI();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void cLlVZW5jWVkmOnC0S6ay()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool Vg2LNu5jqZIrylApxKCh()
	{
		return sp3V765jOCZZ6Fi9rrp6 == null;
	}

	internal static eZUvc1Gez6TvxpluIeQN TPny885jIGBPRk8CvVge()
	{
		return sp3V765jOCZZ6Fi9rrp6;
	}

	internal static void mPjVwN5jtfAIKQ3SrkeI()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
