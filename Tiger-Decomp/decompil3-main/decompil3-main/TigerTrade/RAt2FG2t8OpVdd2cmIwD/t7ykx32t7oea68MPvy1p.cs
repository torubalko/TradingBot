using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using B5A5hB2z2EVuSQ5VHGmu;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using Fb8gFFHFUNPFVH1wej60;
using TigerTrade.Chart.Base;
using TuAMtrl1Nd3XoZQQUXf0;

namespace RAt2FG2t8OpVdd2cmIwD;

internal sealed class t7ykx32t7oea68MPvy1p : Window, IComponentConnector
{
	private DataCycle E8a2UGvqK4s;

	internal ListBox ListBoxItems;

	internal VoU9lv2z05uTExIsC3Ip PropertyGrid;

	internal Button ButtonAdd;

	internal Button ButtonMoveUp;

	internal Button ButtonMoveDown;

	internal Button ButtonRemove;

	internal Button ButtonApply;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool rP72UYnMGpQ;

	private static t7ykx32t7oea68MPvy1p f5gr0T4p6Ee8jPthhGZg;

	public t7ykx32t7oea68MPvy1p()
	{
		f3Rp3I4pqv4dWWUDfI9U();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B03454));
		InitializeComponent();
	}

	private void x3r2tAVRbbn(object P_0, RoutedEventArgs P_1)
	{
		XT92UHOrLWG();
	}

	private void bll2tPMvxfO(object P_0, SelectionChangedEventArgs P_1)
	{
		ButtonMoveUp.IsEnabled = ListBoxItems.SelectedIndex > 0;
		ButtonMoveDown.IsEnabled = mweLTC4pIqyH4q92GSE2(ListBoxItems) < ListBoxItems.Items.Count - 1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ButtonRemove.IsEnabled = mweLTC4pIqyH4q92GSE2(ListBoxItems) >= 0;
	}

	private void oBJ2tJeloJl(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		DataCycle newItem = default(DataCycle);
		while (true)
		{
			switch (num2)
			{
			case 1:
				newItem = new DataCycle();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ListBoxItems.Items.Add(newItem);
				cm043h4pWOiQ1sRyNJUp(ListBoxItems, ListBoxItems.Items.Count - 1);
				return;
			}
		}
	}

	private void RxM2tFIpKJ5(object P_0, RoutedEventArgs P_1)
	{
		Vmr2UfDL9Rk(-1);
	}

	private void s862t3V7oCl(object P_0, RoutedEventArgs P_1)
	{
		Vmr2UfDL9Rk(1);
	}

	private void qm12tp4dTgZ(object P_0, RoutedEventArgs P_1)
	{
		int selectedIndex = ListBoxItems.SelectedIndex;
		if (selectedIndex >= 0)
		{
			WOw3Jq4ptNTdGeHGVaWh(ListBoxItems.Items, selectedIndex);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		Ukq2U97tGmy(selectedIndex);
	}

	private void d3v2tuGnrdB(object P_0, RoutedEventArgs P_1)
	{
		YIK2U2ssGOZ();
	}

	private void Q6C2tzjbM7K(object P_0, RoutedEventArgs P_1)
	{
		YIK2U2ssGOZ();
		MttS0d4pUtMx9yXeQImh(this);
	}

	private void I0E2U0lhANF(object P_0, RoutedEventArgs P_1)
	{
		MttS0d4pUtMx9yXeQImh(this);
	}

	private void YIK2U2ssGOZ()
	{
		fKvKggHFteRddgHojOPb.IACHFTrIuRD(ListBoxItems.Items.Cast<DataCycle>().ToList());
	}

	private void XT92UHOrLWG()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				WfNd7L4pTxT1EkgQbEHE(ButtonRemove, false);
				num2 = 4;
				break;
			case 1:
				ButtonMoveDown.IsEnabled = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				ButtonMoveUp.IsEnabled = false;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
			{
				ItemCollection itemCollection = (ItemCollection)SPLRO74py7UhrWK90aNA(ListBoxItems);
				int num3 = ListBoxItems.SelectedIndex;
				SZ0Im24pZsTowOX6oO09(itemCollection);
				using (List<DataCycle>.Enumerator enumerator = fKvKggHFteRddgHojOPb.Periods.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IL_0124:
							DataCycle current = enumerator.Current;
							int num4 = itemCollection.Add(new DataCycle(current)
							{
								HotKey = current.HotKey
							});
							if (!dpIXP44pVM90aOFsGmLT(current, E8a2UGvqK4s) || num3 != -1)
							{
								break;
							}
							int num5 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 2:
									break;
								case 1:
									num3 = num4;
									E8a2UGvqK4s = null;
									num5 = 2;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
									{
										num5 = 2;
									}
									continue;
								default:
									goto IL_0124;
								}
								break;
							}
							break;
						}
					}
				}
				ListBoxItems.SelectedIndex = num3;
				if (ListBoxItems.SelectedIndex != -1)
				{
					return;
				}
				ListBoxItems.SelectedIndex = 0;
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
				{
					num2 = 3;
				}
				break;
			}
			}
		}
	}

	private void Vmr2UfDL9Rk(int P_0)
	{
		int selectedIndex = ListBoxItems.SelectedIndex;
		int num = selectedIndex + P_0;
		int num2 = 2;
		object insertItem = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				WOw3Jq4ptNTdGeHGVaWh(ListBoxItems.Items, selectedIndex);
				ListBoxItems.Items.Insert(selectedIndex + P_0, insertItem);
				ListBoxItems.SelectedIndex = num;
				return;
			case 3:
				return;
			case 2:
				if (selectedIndex < 0)
				{
					num2 = 3;
					break;
				}
				if (num < 0)
				{
					return;
				}
				if (num < dOEvBl4pCNcY6IYWviaB(ListBoxItems.Items))
				{
					insertItem = ListBoxItems.Items[selectedIndex];
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void Ukq2U97tGmy(int P_0)
	{
		int num2;
		if (P_0 < 0)
		{
			P_0 = 0;
			int num = 2;
			num2 = num;
			goto IL_0009;
		}
		goto IL_0088;
		IL_0088:
		if (P_0 >= ListBoxItems.Items.Count)
		{
			P_0 = ((CollectionView)SPLRO74py7UhrWK90aNA(ListBoxItems)).Count - 1;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		goto IL_0030;
		IL_0009:
		switch (num2)
		{
		case 1:
			ListBoxItems.SelectedIndex = P_0;
			return;
		case 2:
			goto IL_0088;
		}
		goto IL_0030;
		IL_0030:
		if (P_0 < 0 || P_0 >= ListBoxItems.Items.Count)
		{
			return;
		}
		num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num2 = 0;
		}
		goto IL_0009;
	}

	public static bool lxm2UnlKpmH(Window P_0)
	{
		return new t7ykx32t7oea68MPvy1p
		{
			Owner = P_0
		}.ShowDialog() == true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!rP72UYnMGpQ)
		{
			rP72UYnMGpQ = true;
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-837284864 ^ -837231328), UriKind.Relative);
			L4e9R34prcsYwwPYeEwH(this, uri);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 3:
			PropertyGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
			break;
		case 5:
			ButtonMoveUp = (Button)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 4:
			ButtonAdd = (Button)P_1;
			ButtonAdd.Click += oBJ2tJeloJl;
			break;
		case 2:
			ListBoxItems = (ListBox)P_1;
			ListBoxItems.SelectionChanged += bll2tPMvxfO;
			num = 3;
			goto IL_0009;
		case 6:
			ButtonMoveDown = (Button)P_1;
			num = 4;
			goto IL_0009;
		default:
			rP72UYnMGpQ = true;
			num = 6;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
			{
				num = 4;
			}
			goto IL_0009;
		case 10:
			ButtonCancel = (Button)P_1;
			num = 8;
			goto IL_0009;
		case 1:
			HLu9Ar4pKojWs4fs1WJv((t7ykx32t7oea68MPvy1p)P_1, new RoutedEventHandler(x3r2tAVRbbn));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 9:
			ButtonOk = (Button)P_1;
			ButtonOk.Click += Q6C2tzjbM7K;
			break;
		case 7:
			ButtonRemove = (Button)P_1;
			num = 5;
			goto IL_0009;
		case 8:
			{
				ButtonApply = (Button)P_1;
				ButtonApply.Click += d3v2tuGnrdB;
				break;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 3:
					return;
				case 6:
					return;
				case 4:
					NBphA24pmEhrCMFOUyZd(ButtonMoveDown, new RoutedEventHandler(s862t3V7oCl));
					return;
				case 0:
					return;
				case 2:
					return;
				case 7:
					return;
				case 5:
					NBphA24pmEhrCMFOUyZd(ButtonRemove, new RoutedEventHandler(qm12tp4dTgZ));
					return;
				case 8:
					NBphA24pmEhrCMFOUyZd(ButtonCancel, new RoutedEventHandler(I0E2U0lhANF));
					num = 7;
					break;
				case 1:
					ButtonMoveUp.Click += RxM2tFIpKJ5;
					num = 2;
					break;
				}
			}
		}
	}

	static t7ykx32t7oea68MPvy1p()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void f3Rp3I4pqv4dWWUDfI9U()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool pZPmIk4pMCtJqyGikZ9D()
	{
		return f5gr0T4p6Ee8jPthhGZg == null;
	}

	internal static t7ykx32t7oea68MPvy1p Ggdmuh4pO0hTCWeTRrhF()
	{
		return f5gr0T4p6Ee8jPthhGZg;
	}

	internal static int mweLTC4pIqyH4q92GSE2(object P_0)
	{
		return ((Selector)P_0).SelectedIndex;
	}

	internal static void cm043h4pWOiQ1sRyNJUp(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static void WOw3Jq4ptNTdGeHGVaWh(object P_0, int P_1)
	{
		((ItemCollection)P_0).RemoveAt(P_1);
	}

	internal static void MttS0d4pUtMx9yXeQImh(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static void WfNd7L4pTxT1EkgQbEHE(object P_0, bool P_1)
	{
		((UIElement)P_0).IsEnabled = P_1;
	}

	internal static object SPLRO74py7UhrWK90aNA(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static void SZ0Im24pZsTowOX6oO09(object P_0)
	{
		((ItemCollection)P_0).Clear();
	}

	internal static bool dpIXP44pVM90aOFsGmLT(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static int dOEvBl4pCNcY6IYWviaB(object P_0)
	{
		return ((CollectionView)P_0).Count;
	}

	internal static void L4e9R34prcsYwwPYeEwH(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void HLu9Ar4pKojWs4fs1WJv(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void NBphA24pmEhrCMFOUyZd(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
