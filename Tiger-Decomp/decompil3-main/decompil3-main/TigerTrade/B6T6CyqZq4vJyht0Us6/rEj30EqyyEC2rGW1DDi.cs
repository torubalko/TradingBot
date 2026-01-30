using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls.Docking;
using TuAMtrl1Nd3XoZQQUXf0;

namespace B6T6CyqZq4vJyht0Us6;

internal static class rEj30EqyyEC2rGW1DDi
{
	internal static rEj30EqyyEC2rGW1DDi gBD5bv4awqOwbVnaaqw8;

	public static void SwitchToNextTab(AdvancedTabControl advancedTabControl)
	{
		if (advancedTabControl == null)
		{
			return;
		}
		int num = 0;
		AdvancedTabItem advancedTabItem2 = default(AdvancedTabItem);
		int index = default(int);
		while (num < dXIns44aJYs6fvhH9l3p(advancedTabControl.Items))
		{
			AdvancedTabItem advancedTabItem = ((ItemCollection)lRg7Zj4aALRcND4csGOp(advancedTabControl))[num] as AdvancedTabItem;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (advancedTabItem2 == null)
					{
						num2 = 3;
						continue;
					}
					bPifvi4aPW55n592tAwq(advancedTabItem2, true);
					return;
				case 3:
					num++;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (advancedTabItem != null && advancedTabItem.IsSelected)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 1:
					advancedTabItem2 = advancedTabControl.Items[index] as AdvancedTabItem;
					num2 = 5;
					continue;
				case 4:
					index = ((num != advancedTabControl.Items.Count - 1) ? (num + 1) : 0);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void SwitchToPrevTab(AdvancedTabControl advancedTabControl)
	{
		if (advancedTabControl == null)
		{
			return;
		}
		int num = 0;
		int num3 = default(int);
		AdvancedTabItem advancedTabItem2 = default(AdvancedTabItem);
		while (num < dXIns44aJYs6fvhH9l3p(advancedTabControl.Items))
		{
			while (true)
			{
				IL_00e4:
				AdvancedTabItem advancedTabItem = ((ItemCollection)lRg7Zj4aALRcND4csGOp(advancedTabControl))[num] as AdvancedTabItem;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					int num4;
					switch (num2)
					{
					case 2:
						break;
					case 5:
						if (!advancedTabItem.IsSelected)
						{
							goto IL_0030;
						}
						goto case 1;
					case 1:
						num3 = ((num == 0) ? (dXIns44aJYs6fvhH9l3p(lRg7Zj4aALRcND4csGOp(advancedTabControl)) - 1) : (num - 1));
						num2 = 3;
						continue;
					default:
						if (advancedTabItem != null)
						{
							num2 = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto IL_0030;
					case 4:
						bPifvi4aPW55n592tAwq(advancedTabItem2, true);
						return;
					case 6:
						goto IL_00e4;
					case 3:
						{
							advancedTabItem2 = Ylpikt4aFnk3fQYoVZKj(advancedTabControl.Items, num3) as AdvancedTabItem;
							if (advancedTabItem2 != null)
							{
								num2 = 4;
								continue;
							}
							goto IL_0030;
						}
						IL_0030:
						num++;
						num4 = 2;
						num2 = num4;
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	static rEj30EqyyEC2rGW1DDi()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object lRg7Zj4aALRcND4csGOp(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static void bPifvi4aPW55n592tAwq(object P_0, bool P_1)
	{
		((TabItem)P_0).IsSelected = P_1;
	}

	internal static int dXIns44aJYs6fvhH9l3p(object P_0)
	{
		return ((CollectionView)P_0).Count;
	}

	internal static bool zXqNCW4a7NKngmyu7H9h()
	{
		return gBD5bv4awqOwbVnaaqw8 == null;
	}

	internal static rEj30EqyyEC2rGW1DDi gtUUuA4a8aGBfwRT2o9o()
	{
		return gBD5bv4awqOwbVnaaqw8;
	}

	internal static object Ylpikt4aFnk3fQYoVZKj(object P_0, int P_1)
	{
		return ((ItemCollection)P_0)[P_1];
	}
}
