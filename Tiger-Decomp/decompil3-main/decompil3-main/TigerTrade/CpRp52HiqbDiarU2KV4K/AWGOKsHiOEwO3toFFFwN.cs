using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace CpRp52HiqbDiarU2KV4K;

internal class AWGOKsHiOEwO3toFFFwN
{
	[CompilerGenerated]
	private sealed class zMfe7Gnt7DhqJJQsfED4
	{
		public DataGrid ViuntPZaDZT;

		public EventHandler<DataGridRowEventArgs> lbqntJSIXPn;

		public ItemsChangedEventHandler UADntFwyeYY;

		internal static zMfe7Gnt7DhqJJQsfED4 eBaPUvNSU541pFXeMI5r;

		public zMfe7Gnt7DhqJJQsfED4()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void cbPnt8DAUhr(object sender, DataGridRowEventArgs ea)
		{
			if (!GetDisplayRowNumber(ViuntPZaDZT))
			{
				ViuntPZaDZT.LoadingRow -= lbqntJSIXPn;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				((DataGridRow)rS5Z9bNSZOiJtnHtfOKy(ea)).Header = ((DataGridRow)rS5Z9bNSZOiJtnHtfOKy(ea)).GetIndex() + 1;
			}
		}

		internal void UplntAmpVQ6(object sender, ItemsChangedEventArgs ea)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					ViuntPZaDZT.ItemContainerGenerator.ItemsChanged -= UADntFwyeYY;
					return;
				case 1:
					if (!GetDisplayRowNumber(ViuntPZaDZT))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num2 = 0;
						}
						break;
					}
					RFYHiWfovTh<DataGridRow>(ViuntPZaDZT).ForEach(sb1eIJnt3XR4fEmyOr4Q.GHbntuo1q2m.TG1ntpQ9KfB);
					return;
				}
			}
		}

		static zMfe7Gnt7DhqJJQsfED4()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool GBCpvgNST6QZc4Ee4RqT()
		{
			return eBaPUvNSU541pFXeMI5r == null;
		}

		internal static zMfe7Gnt7DhqJJQsfED4 bP7oQnNSyOVIBilLA8A2()
		{
			return eBaPUvNSU541pFXeMI5r;
		}

		internal static object rS5Z9bNSZOiJtnHtfOKy(object P_0)
		{
			return ((DataGridRowEventArgs)P_0).Row;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class sb1eIJnt3XR4fEmyOr4Q
	{
		public static readonly sb1eIJnt3XR4fEmyOr4Q GHbntuo1q2m;

		public static Action<DataGridRow> HlJntzFQpo7;

		internal static sb1eIJnt3XR4fEmyOr4Q foPbspNSVMywF72oaPMJ;

		static sb1eIJnt3XR4fEmyOr4Q()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			GHbntuo1q2m = new sb1eIJnt3XR4fEmyOr4Q();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public sb1eIJnt3XR4fEmyOr4Q()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void TG1ntpQ9KfB(DataGridRow d)
		{
			WndSO9NSKoK3KWZdEpqw(d, d.GetIndex());
		}

		internal static bool DQKHSENSCXFls8Tx03N3()
		{
			return foPbspNSVMywF72oaPMJ == null;
		}

		internal static sb1eIJnt3XR4fEmyOr4Q BxQNoTNSrydvFQymPp7c()
		{
			return foPbspNSVMywF72oaPMJ;
		}

		internal static void WndSO9NSKoK3KWZdEpqw(object P_0, object P_1)
		{
			((DataGridRow)P_0).Header = P_1;
		}
	}

	public static DependencyProperty DisplayRowNumberProperty;

	private static AWGOKsHiOEwO3toFFFwN xlmxr6DkIR3mjMep0gy8;

	public static bool GetDisplayRowNumber(DependencyObject target)
	{
		return (bool)target.GetValue(DisplayRowNumberProperty);
	}

	public static void SetDisplayRowNumber(DependencyObject target, bool value)
	{
		wIrserDkUnJ3rJ4j0vZC(target, DisplayRowNumberProperty, value);
	}

	private static void A8WHiI3IHsc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		zMfe7Gnt7DhqJJQsfED4 CS_0024_003C_003E8__locals16 = new zMfe7Gnt7DhqJJQsfED4();
		CS_0024_003C_003E8__locals16.ViuntPZaDZT = P_0 as DataGrid;
		if (!(bool)P_1.NewValue)
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				CS_0024_003C_003E8__locals16.ViuntPZaDZT.LoadingRow += CS_0024_003C_003E8__locals16.lbqntJSIXPn;
				CS_0024_003C_003E8__locals16.UADntFwyeYY = null;
				CS_0024_003C_003E8__locals16.UADntFwyeYY = delegate
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							CS_0024_003C_003E8__locals16.ViuntPZaDZT.ItemContainerGenerator.ItemsChanged -= CS_0024_003C_003E8__locals16.UADntFwyeYY;
							return;
						case 1:
							if (GetDisplayRowNumber(CS_0024_003C_003E8__locals16.ViuntPZaDZT))
							{
								RFYHiWfovTh<DataGridRow>(CS_0024_003C_003E8__locals16.ViuntPZaDZT).ForEach(sb1eIJnt3XR4fEmyOr4Q.GHbntuo1q2m.TG1ntpQ9KfB);
								return;
							}
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				};
				grPwvuDkTcKs3I8OSBeM(CS_0024_003C_003E8__locals16.ViuntPZaDZT.ItemContainerGenerator, CS_0024_003C_003E8__locals16.UADntFwyeYY);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 3:
				return;
			case 1:
				CS_0024_003C_003E8__locals16.lbqntJSIXPn = null;
				CS_0024_003C_003E8__locals16.lbqntJSIXPn = delegate(object sender, DataGridRowEventArgs ea)
				{
					if (!GetDisplayRowNumber(CS_0024_003C_003E8__locals16.ViuntPZaDZT))
					{
						CS_0024_003C_003E8__locals16.ViuntPZaDZT.LoadingRow -= CS_0024_003C_003E8__locals16.lbqntJSIXPn;
						int num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
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
						((DataGridRow)zMfe7Gnt7DhqJJQsfED4.rS5Z9bNSZOiJtnHtfOKy(ea)).Header = ((DataGridRow)zMfe7Gnt7DhqJJQsfED4.rS5Z9bNSZOiJtnHtfOKy(ea)).GetIndex() + 1;
					}
				};
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	private static List<dhi1NaliD9AMirUloCrd> RFYHiWfovTh<dhi1NaliD9AMirUloCrd>(object P_0) where dhi1NaliD9AMirUloCrd : Visual
	{
		List<dhi1NaliD9AMirUloCrd> list = new List<dhi1NaliD9AMirUloCrd>();
		QujHitbofwW(P_0 as DependencyObject, list);
		return list;
	}

	private static void QujHitbofwW<Jp6on7liboRYGBfsUWgP>(DependencyObject P_0, List<Jp6on7liboRYGBfsUWgP> P_1) where Jp6on7liboRYGBfsUWgP : Visual
	{
		int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
		for (int i = 0; i < childrenCount; i++)
		{
			DependencyObject child = VisualTreeHelper.GetChild(P_0, i);
			if (child is Jp6on7liboRYGBfsUWgP)
			{
				P_1.Add(child as Jp6on7liboRYGBfsUWgP);
			}
			if (child != null)
			{
				QujHitbofwW(child, P_1);
			}
		}
	}

	public AWGOKsHiOEwO3toFFFwN()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static AWGOKsHiOEwO3toFFFwN()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				DisplayRowNumberProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DFBEA5), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(TbO6TaDky5v85e5DlRQN(33555258)), new FrameworkPropertyMetadata(false, A8WHiI3IHsc));
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool C9JR92DkWLZfGjwRUF1N()
	{
		return xlmxr6DkIR3mjMep0gy8 == null;
	}

	internal static AWGOKsHiOEwO3toFFFwN AcIxprDktkbuwQ27RQFu()
	{
		return xlmxr6DkIR3mjMep0gy8;
	}

	internal static void wIrserDkUnJ3rJ4j0vZC(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void grPwvuDkTcKs3I8OSBeM(object P_0, object P_1)
	{
		((ItemContainerGenerator)P_0).ItemsChanged += (ItemsChangedEventHandler)P_1;
	}

	internal static RuntimeTypeHandle TbO6TaDky5v85e5DlRQN(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
