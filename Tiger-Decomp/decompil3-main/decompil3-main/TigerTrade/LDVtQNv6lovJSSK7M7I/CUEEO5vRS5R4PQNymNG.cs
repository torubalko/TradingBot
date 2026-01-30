using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using B5A5hB2z2EVuSQ5VHGmu;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using LpWHqpHFxDr7bif08Fn4;
using pduUFuHP7jFN8rkxyl0l;
using RPVQtsHPzsQV1qIogYUn;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace LDVtQNv6lovJSSK7M7I;

internal class CUEEO5vRS5R4PQNymNG : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class J1PRxnnDGqFA1ty0dHEp
	{
		public static readonly J1PRxnnDGqFA1ty0dHEp mGjnDvgN1jZ;

		public static Func<KQbAjaHPuhQcsTd7NH8a, string> iMYnDB8Z28m;

		public static Func<KQbAjaHPuhQcsTd7NH8a, string> MKWnDahG13t;

		private static J1PRxnnDGqFA1ty0dHEp jRvfKSN0SfNbjSm67pEf;

		static J1PRxnnDGqFA1ty0dHEp()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					qhXmsYN0esUV81Z9jPXJ();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					fdKQgoN0stcXQSBEoguO();
					mGjnDvgN1jZ = new J1PRxnnDGqFA1ty0dHEp();
					return;
				}
			}
		}

		public J1PRxnnDGqFA1ty0dHEp()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string Y3MnDY3lx8m(KQbAjaHPuhQcsTd7NH8a item)
		{
			return (string)IwStyxN0XjKntaYhsCnt(item);
		}

		internal string qognDo7btie(KQbAjaHPuhQcsTd7NH8a rp)
		{
			return rp.SymbolName;
		}

		internal static void qhXmsYN0esUV81Z9jPXJ()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void fdKQgoN0stcXQSBEoguO()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool Yn2Hk5N0xEBbox5UpWXP()
		{
			return jRvfKSN0SfNbjSm67pEf == null;
		}

		internal static J1PRxnnDGqFA1ty0dHEp kkrZA9N0LAfwEcPeSYjI()
		{
			return jRvfKSN0SfNbjSm67pEf;
		}

		internal static object IwStyxN0XjKntaYhsCnt(object P_0)
		{
			return ((KQbAjaHPuhQcsTd7NH8a)P_0).Key;
		}
	}

	private KQbAjaHPuhQcsTd7NH8a H95vw23POj;

	internal Button ButtonSetPassword;

	internal ListBox ListBoxItems;

	internal VoU9lv2z05uTExIsC3Ip PropertyGrid;

	internal Button ButtonAdd;

	internal Button ButtonMoveUp;

	internal Button ButtonMoveDown;

	internal Button ButtonRemove;

	internal Button ButtonApply;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool PAAv7bFsfo;

	internal static CUEEO5vRS5R4PQNymNG UCq2B2l8HpKflHe3ugT6;

	public CUEEO5vRS5R4PQNymNG()
	{
		QKYB08l8nhXnKRgSdUG4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				WflVLTl8Yc76SZYmxQjw(L8XZQ9l8GSbplLUyljdb(0x78D396D8 ^ 0x78D3B3BE));
				InitializeComponent();
				PropertyGrid.Columns[0].Width = new GridLength(6.0, GridUnitType.Star);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
				{
					num = 0;
				}
				break;
			default:
				qNyuc5l8oEds19rVedel(PropertyGrid.Columns[1], new GridLength(4.0, GridUnitType.Star));
				return;
			}
		}
	}

	private void ftZvMGs6kY(object P_0, RoutedEventArgs P_1)
	{
		EeMvrsNVNR();
	}

	private void NZHvOgMl3d(object P_0, SelectionChangedEventArgs P_1)
	{
		ButtonMoveUp.IsEnabled = ListBoxItems.SelectedIndex > 0;
		ButtonMoveDown.IsEnabled = zlp6mpl8vcnXZa2qC0tp(ListBoxItems) < ListBoxItems.Items.Count - 1;
		bSH8ONl8BF7uuctNcIxF(ButtonRemove, ListBoxItems.SelectedIndex >= 0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void yv2vquPolj(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		KQbAjaHPuhQcsTd7NH8a kQbAjaHPuhQcsTd7NH8a = default(KQbAjaHPuhQcsTd7NH8a);
		while (true)
		{
			switch (num2)
			{
			default:
				ListBoxItems.Items.Add(kQbAjaHPuhQcsTd7NH8a);
				gltFJhl8aL0Q8O58Zwb5(ListBoxItems, kQbAjaHPuhQcsTd7NH8a);
				return;
			case 1:
				kQbAjaHPuhQcsTd7NH8a = new KQbAjaHPuhQcsTd7NH8a();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void EndvIP5uRp(object P_0, RoutedEventArgs P_1)
	{
		fvmvK0hEuS(-1);
	}

	private void LQxvWEfsah(object P_0, RoutedEventArgs P_1)
	{
		fvmvK0hEuS(1);
	}

	private void I7Pvttoh2X(object P_0, RoutedEventArgs P_1)
	{
		int num = zlp6mpl8vcnXZa2qC0tp(ListBoxItems);
		if (num >= 0)
		{
			((ItemCollection)HVhQMRl8isbmk0TFrEgw(ListBoxItems)).RemoveAt(num);
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
		}
		RP2vmwh6ru(num);
	}

	private void gA5vUhPBhp(object P_0, RoutedEventArgs P_1)
	{
		if (InputWindow.ShowWindow(this, TigerTrade.Properties.Resources.LimitsEditorWindowTitle, (string)qdo1mvl8lmcJfkA5vsGO(), out var value))
		{
			((Jm1YX8HFSEpmh6QJJmd6)nq3nngl84PKGBGaWImSM()).Password = value;
		}
	}

	private void YCXvTSn3IT(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (!dpqvCdsqZs())
				{
					yCfvVwFaYC();
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void AQcvyhul1A(object P_0, RoutedEventArgs P_1)
	{
		if (!dpqvCdsqZs())
		{
			yCfvVwFaYC();
			PcbWyRl8DOu8e1uP2SDX(this);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
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

	private void vNRvZYGVYa(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	private void yCfvVwFaYC()
	{
		R7XH8hl8b5gky9q7LD7J(((Jm1YX8HFSEpmh6QJJmd6)nq3nngl84PKGBGaWImSM()).NmjHFsmFyvR);
		IEnumerator enumerator = ((IEnumerable)HVhQMRl8isbmk0TFrEgw(ListBoxItems)).GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				KQbAjaHPuhQcsTd7NH8a item = (KQbAjaHPuhQcsTd7NH8a)K01Ephl8N4KfXFcUVvlR(enumerator);
				((Jm1YX8HFSEpmh6QJJmd6)nq3nngl84PKGBGaWImSM()).NmjHFsmFyvR.Add(item);
			}
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 0:
				break;
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				int num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					disposable.Dispose();
					break;
				}
			}
		}
		EeMvrsNVNR();
	}

	private bool dpqvCdsqZs()
	{
		List<string> list = (from KQbAjaHPuhQcsTd7NH8a item in ListBoxItems.Items
			select (string)J1PRxnnDGqFA1ty0dHEp.IwStyxN0XjKntaYhsCnt(item)).ToList();
		int num = 0;
		int num2 = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
		{
			num2 = 1;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				if (num + 1 >= LfXOMPl81UCkS6KtGL7q(list))
				{
					return false;
				}
				goto case 1;
			case 1:
			{
				for (int num3 = num + 1; num3 < LfXOMPl81UCkS6KtGL7q(list); num3++)
				{
					if (list[num] == list[num3])
					{
						MessageWindow.ShowWindow(this, (string)nC50JTl8kG377HT6VDfm(), TigerTrade.Properties.Resources.LimitsEditorWindowRemoveDuplicateSettings);
						return true;
					}
				}
				num2 = 3;
				break;
			}
			case 3:
				num++;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void EeMvrsNVNR()
	{
		bSH8ONl8BF7uuctNcIxF(ButtonMoveUp, false);
		ButtonMoveDown.IsEnabled = false;
		bSH8ONl8BF7uuctNcIxF(ButtonRemove, false);
		ItemCollection items = ListBoxItems.Items;
		int num = ListBoxItems.SelectedIndex;
		items.Clear();
		int num2 = 3;
		List<KQbAjaHPuhQcsTd7NH8a>.Enumerator enumerator = default(List<KQbAjaHPuhQcsTd7NH8a>.Enumerator);
		KQbAjaHPuhQcsTd7NH8a current = default(KQbAjaHPuhQcsTd7NH8a);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				ListBoxItems.SelectedIndex = num;
				num2 = 2;
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_00cc:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
							{
								num3 = 0;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								num = num4;
								H95vw23POj = null;
								break;
							default:
								num4 = items.Add(current.Clone());
								if (current == H95vw23POj && num == -1)
								{
									goto IL_00b6;
								}
								break;
							case 1:
								goto end_IL_007d;
							}
							goto IL_00cc;
							IL_00b6:
							num3 = 2;
							continue;
							end_IL_007d:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto default;
			case 2:
				if (zlp6mpl8vcnXZa2qC0tp(ListBoxItems) == -1)
				{
					ListBoxItems.SelectedIndex = 0;
				}
				return;
			case 3:
				enumerator = zyW7WyHPwnJEtIOWC1Wm.Settings.NmjHFsmFyvR.OrderBy((KQbAjaHPuhQcsTd7NH8a rp) => rp.SymbolName).ToList().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void fvmvK0hEuS(int P_0)
	{
		int selectedIndex = ListBoxItems.SelectedIndex;
		int num = selectedIndex + P_0;
		int num2 = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
		{
			num2 = 3;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				object obj = ListBoxItems.Items[selectedIndex];
				ListBoxItems.Items.RemoveAt(selectedIndex);
				OiNMXfl85N08VYuNV80H(HVhQMRl8isbmk0TFrEgw(ListBoxItems), selectedIndex + P_0, obj);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				Uj9XLPl8SAJZo4QcrO2Z(ListBoxItems, num);
				return;
			case 3:
				if (selectedIndex < 0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num < 0 || num >= ListBoxItems.Items.Count)
				{
					return;
				}
				num2 = 2;
				break;
			}
		}
	}

	private void RP2vmwh6ru(int P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (P_0 < 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00b0;
			default:
				if (P_0 < 0 || P_0 >= ListBoxItems.Items.Count)
				{
					return;
				}
				num2 = 3;
				break;
			case 1:
				P_0 = 0;
				goto IL_00b0;
			case 3:
				{
					ListBoxItems.SelectedIndex = P_0;
					return;
				}
				IL_00b0:
				if (P_0 >= ListBoxItems.Items.Count)
				{
					P_0 = ((CollectionView)HVhQMRl8isbmk0TFrEgw(ListBoxItems)).Count - 1;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static void M5Svhl98nr(Window P_0)
	{
		CUEEO5vRS5R4PQNymNG cUEEO5vRS5R4PQNymNG = new CUEEO5vRS5R4PQNymNG();
		cUEEO5vRS5R4PQNymNG.Owner = P_0;
		cUEEO5vRS5R4PQNymNG.ShowDialog();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 2;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!PAAv7bFsfo)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			default:
				PHRUwbl8xsqLCvM9gUWb(this, uri);
				return;
			case 1:
				PAAv7bFsfo = true;
				uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04037E), UriKind.Relative);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)RbXcukl8LtCokWoMaO2g(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 4:
			PropertyGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
			num = 8;
			goto IL_0009;
		default:
			PAAv7bFsfo = true;
			break;
		case 3:
			ListBoxItems = (ListBox)P_1;
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 11:
			ButtonCancel = (Button)P_1;
			num = 9;
			goto IL_0009;
		case 8:
			ButtonRemove = (Button)P_1;
			ycSwavl8sclQLWPJkR8Q(ButtonRemove, new RoutedEventHandler(I7Pvttoh2X));
			break;
		case 10:
			ButtonOk = (Button)P_1;
			num = 3;
			goto IL_0009;
		case 9:
			ButtonApply = (Button)P_1;
			ycSwavl8sclQLWPJkR8Q(ButtonApply, new RoutedEventHandler(YCXvTSn3IT));
			break;
		case 2:
			ButtonSetPassword = (Button)P_1;
			num = 7;
			goto IL_0009;
		case 7:
			ButtonMoveDown = (Button)P_1;
			ButtonMoveDown.Click += LQxvWEfsah;
			num = 5;
			goto IL_0009;
		case 1:
			WDLq8ql8eBKV2uwdUInG((CUEEO5vRS5R4PQNymNG)P_1, new RoutedEventHandler(ftZvMGs6kY));
			break;
		case 6:
			ButtonMoveUp = (Button)P_1;
			ButtonMoveUp.Click += EndvIP5uRp;
			break;
		case 5:
			{
				ButtonAdd = (Button)P_1;
				num = 6;
				goto IL_0009;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 9:
					ButtonCancel.Click += vNRvZYGVYa;
					return;
				case 7:
					ButtonSetPassword.Click += gA5vUhPBhp;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num = 1;
					}
					continue;
				case 1:
					return;
				case 5:
					return;
				case 4:
					ListBoxItems.SelectionChanged += NZHvOgMl3d;
					return;
				case 6:
					ButtonAdd.Click += yv2vquPolj;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
					{
						num = 1;
					}
					continue;
				case 2:
					return;
				case 8:
					return;
				case 3:
					ycSwavl8sclQLWPJkR8Q(ButtonOk, new RoutedEventHandler(AQcvyhul1A));
					return;
				}
				break;
			}
			goto case 1;
		}
	}

	static CUEEO5vRS5R4PQNymNG()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void QKYB08l8nhXnKRgSdUG4()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object L8XZQ9l8GSbplLUyljdb(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void WflVLTl8Yc76SZYmxQjw(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)P_0);
	}

	internal static void qNyuc5l8oEds19rVedel(object P_0, GridLength P_1)
	{
		((TreeListViewColumn)P_0).Width = P_1;
	}

	internal static bool zC4Jdql8fknWScIQkHcc()
	{
		return UCq2B2l8HpKflHe3ugT6 == null;
	}

	internal static CUEEO5vRS5R4PQNymNG iYU7tXl89T0okGDiv5O8()
	{
		return UCq2B2l8HpKflHe3ugT6;
	}

	internal static int zlp6mpl8vcnXZa2qC0tp(object P_0)
	{
		return ((Selector)P_0).SelectedIndex;
	}

	internal static void bSH8ONl8BF7uuctNcIxF(object P_0, bool P_1)
	{
		((UIElement)P_0).IsEnabled = P_1;
	}

	internal static void gltFJhl8aL0Q8O58Zwb5(object P_0, object P_1)
	{
		((Selector)P_0).SelectedValue = P_1;
	}

	internal static object HVhQMRl8isbmk0TFrEgw(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object qdo1mvl8lmcJfkA5vsGO()
	{
		return TigerTrade.Properties.Resources.LimitsEditorWindowSetPasswordForSettings;
	}

	internal static object nq3nngl84PKGBGaWImSM()
	{
		return zyW7WyHPwnJEtIOWC1Wm.Settings;
	}

	internal static void PcbWyRl8DOu8e1uP2SDX(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static void R7XH8hl8b5gky9q7LD7J(object P_0)
	{
		((List<KQbAjaHPuhQcsTd7NH8a>)P_0).Clear();
	}

	internal static object K01Ephl8N4KfXFcUVvlR(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object nC50JTl8kG377HT6VDfm()
	{
		return TigerTrade.Properties.Resources.LimitsEditorWindowTitle;
	}

	internal static int LfXOMPl81UCkS6KtGL7q(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static void OiNMXfl85N08VYuNV80H(object P_0, int P_1, object P_2)
	{
		((ItemCollection)P_0).Insert(P_1, P_2);
	}

	internal static void Uj9XLPl8SAJZo4QcrO2Z(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static void PHRUwbl8xsqLCvM9gUWb(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object RbXcukl8LtCokWoMaO2g(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void WDLq8ql8eBKV2uwdUInG(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void ycSwavl8sclQLWPJkR8Q(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
