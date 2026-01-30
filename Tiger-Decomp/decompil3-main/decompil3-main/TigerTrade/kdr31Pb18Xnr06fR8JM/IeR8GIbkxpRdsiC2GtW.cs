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
using lj4T8ZHF7x3Bq5iQiaUo;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Properties;
using tsQHvsH35TbwGvTJYivH;
using TuAMtrl1Nd3XoZQQUXf0;
using YEElclH3lvRpuu1MG0YY;

namespace kdr31Pb18Xnr06fR8JM;

internal class IeR8GIbkxpRdsiC2GtW : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class I1ZiVLnbMsyLDfETdWEN
	{
		public static readonly I1ZiVLnbMsyLDfETdWEN cHFnbqjGDXG;

		public static Func<bPlY5UHFwpoioxZbeXFB, string> RhjnbIo904M;

		private static I1ZiVLnbMsyLDfETdWEN qjJ9D1NH4HhCHcfytTWv;

		static I1ZiVLnbMsyLDfETdWEN()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			cHFnbqjGDXG = new I1ZiVLnbMsyLDfETdWEN();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public I1ZiVLnbMsyLDfETdWEN()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string S6EnbO9onJ3(bPlY5UHFwpoioxZbeXFB item)
		{
			return item.Name;
		}

		internal static bool B5HEruNHDMHCwiVYh5sG()
		{
			return qjJ9D1NH4HhCHcfytTWv == null;
		}

		internal static I1ZiVLnbMsyLDfETdWEN sNIVfsNHbBesV5YNNBJ7()
		{
			return qjJ9D1NH4HhCHcfytTWv;
		}
	}

	private bPlY5UHFwpoioxZbeXFB RUYbMGAouU;

	internal ListBox ListBoxItems;

	internal VoU9lv2z05uTExIsC3Ip PropertyGrid;

	internal Button ButtonAdd;

	internal Button ButtonMoveUp;

	internal Button ButtonMoveDown;

	internal Button ButtonRemove;

	internal Button ButtonApply;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool DQsbOsUkpL;

	internal static IeR8GIbkxpRdsiC2GtW NVQvEtl3I8vLJvWhEcmf;

	public IeR8GIbkxpRdsiC2GtW()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Vnstwcl3UeNcTrSthDNO(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB7BD6B));
		InitializeComponent();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				PropertyGrid.Columns[1].Width = new GridLength(4.0, GridUnitType.Star);
				return;
			case 1:
				eZNcG7l3TAGLyVpomrYH(PropertyGrid.Columns[0], new GridLength(6.0, GridUnitType.Star));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void fBOb5WpRrh(object P_0, RoutedEventArgs P_1)
	{
		Et6bdtAcZp();
	}

	private void zqKbSSU4e6(object P_0, SelectionChangedEventArgs P_1)
	{
		nP0Npvl3yurZqjjym9Jd(ButtonMoveUp, ListBoxItems.SelectedIndex > 0);
		ButtonMoveDown.IsEnabled = ListBoxItems.SelectedIndex < ListBoxItems.Items.Count - 1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		nP0Npvl3yurZqjjym9Jd(ButtonRemove, xXWItUl3ZWQcyUcbDkfr(ListBoxItems) >= 0);
	}

	private void vMRbxeFdNQ(object P_0, RoutedEventArgs P_1)
	{
		bPlY5UHFwpoioxZbeXFB bPlY5UHFwpoioxZbeXFB = new bPlY5UHFwpoioxZbeXFB();
		sLT9Hol3VRxulxm76lrJ(ListBoxItems.Items, bPlY5UHFwpoioxZbeXFB);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ListBoxItems.SelectedValue = bPlY5UHFwpoioxZbeXFB;
	}

	private void nGMbLAtRRE(object P_0, RoutedEventArgs P_1)
	{
		X5MbgXWse3(-1);
	}

	private void L47beS5mXK(object P_0, RoutedEventArgs P_1)
	{
		X5MbgXWse3(1);
	}

	private void bxwbs0YsjG(object P_0, RoutedEventArgs P_1)
	{
		int selectedIndex = ListBoxItems.SelectedIndex;
		if (selectedIndex >= 0)
		{
			while (true)
			{
				wlen2Dl3CMro5fmtmdRI(ListBoxItems.Items, selectedIndex);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					continue;
				}
				break;
			}
		}
		ckvbRUg06L(selectedIndex);
	}

	private void xgXbXSGlns(object P_0, RoutedEventArgs P_1)
	{
		if (!VoabQ9rJ0W())
		{
			phqbEsvUTl();
		}
	}

	private void i32bc8Btxa(object P_0, RoutedEventArgs P_1)
	{
		if (!VoabQ9rJ0W())
		{
			phqbEsvUTl();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			UlgTN3l3raadRA9lCkEp(this);
		}
	}

	private void ln3bjQ8KJC(object P_0, RoutedEventArgs P_1)
	{
		UlgTN3l3raadRA9lCkEp(this);
	}

	private void phqbEsvUTl()
	{
		K5ggEll3mCZjQ8NgSJE5(((WjB0DfH31o2TXoQckhVQ)FmO349l3KvfdfpcsgVui()).lGTH3LYjunm);
		IEnumerator enumerator = (IEnumerator)f5plUul3hWarXTYYZQa2(ListBoxItems.Items);
		try
		{
			while (enumerator.MoveNext())
			{
				bPlY5UHFwpoioxZbeXFB item = (bPlY5UHFwpoioxZbeXFB)enumerator.Current;
				((WjB0DfH31o2TXoQckhVQ)FmO349l3KvfdfpcsgVui()).lGTH3LYjunm.Add(item);
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			default:
				disposable?.Dispose();
				break;
			}
		}
		Et6bdtAcZp();
		int num3 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num3 = 0;
		}
		switch (num3)
		{
		case 0:
			break;
		}
	}

	private bool VoabQ9rJ0W()
	{
		List<string> list = (from bPlY5UHFwpoioxZbeXFB item in (IEnumerable)mk7DnWl3wlUuCiWTlOmk(ListBoxItems)
			select item.Name).ToList();
		int num = 0;
		while (num + 1 < Gw4nGql3AMT3ww9xH1mb(list))
		{
			while (true)
			{
				IL_00ff:
				int num2 = num + 1;
				while (true)
				{
					IL_0094:
					int num3;
					if (num2 >= Gw4nGql3AMT3ww9xH1mb(list))
					{
						num3 = 4;
						goto IL_0009;
					}
					goto IL_00be;
					IL_0009:
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						default:
							goto IL_0094;
						case 2:
							goto IL_00be;
						case 4:
							num++;
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							goto IL_00ff;
						}
						break;
					}
					break;
					IL_00be:
					if (list[num] == list[num2])
					{
						MessageWindow.ShowWindow(this, (string)A6eFr1l37J67Jhx6KOkM(), (string)FxVqW0l38Nv607SDxEy3());
						return true;
					}
					num2++;
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num3 = 0;
					}
					goto IL_0009;
				}
				break;
			}
		}
		return false;
	}

	private void Et6bdtAcZp()
	{
		int num = 2;
		int num2 = num;
		int num4 = default(int);
		ItemCollection itemCollection = default(ItemCollection);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				num4 = ListBoxItems.SelectedIndex;
				num2 = 3;
				break;
			case 3:
				itemCollection.Clear();
				foreach (bPlY5UHFwpoioxZbeXFB item in XhswApH3iouMedcVCcQ4.Settings.lGTH3LYjunm.ToList())
				{
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							num5 = itemCollection.Add(item.Clone());
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							break;
						case 1:
							if (item == RUYbMGAouU && num4 == -1)
							{
								num4 = num5;
								RUYbMGAouU = null;
								num3 = 2;
								continue;
							}
							break;
						}
						break;
					}
				}
				FHB84El3PU2uifOYurQZ(ListBoxItems, num4);
				if (ListBoxItems.SelectedIndex == -1)
				{
					FHB84El3PU2uifOYurQZ(ListBoxItems, 0);
				}
				return;
			case 4:
				itemCollection = (ItemCollection)mk7DnWl3wlUuCiWTlOmk(ListBoxItems);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				nP0Npvl3yurZqjjym9Jd(ButtonMoveUp, false);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ButtonMoveDown.IsEnabled = false;
				ButtonRemove.IsEnabled = false;
				num2 = 4;
				break;
			}
		}
	}

	private void X5MbgXWse3(int P_0)
	{
		int num = 3;
		int num2 = num;
		int selectedIndex = default(int);
		object insertItem = default(object);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				ListBoxItems.Items.Insert(selectedIndex + P_0, insertItem);
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				if (num3 < 0 || num3 >= ListBoxItems.Items.Count)
				{
					return;
				}
				insertItem = arpPwkl3JtjiQqfVeLoA(ListBoxItems.Items, selectedIndex);
				wlen2Dl3CMro5fmtmdRI(ListBoxItems.Items, selectedIndex);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				ListBoxItems.SelectedIndex = num3;
				return;
			case 2:
				num3 = selectedIndex + P_0;
				if (selectedIndex >= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 3:
				selectedIndex = ListBoxItems.SelectedIndex;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void ckvbRUg06L(int P_0)
	{
		if (P_0 < 0)
		{
			P_0 = 0;
		}
		int num;
		if (P_0 < ListBoxItems.Items.Count)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
			{
				num = 1;
			}
		}
		else
		{
			P_0 = qVOx8El3FdtJng4dB0v9(ListBoxItems.Items) - 1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			default:
				if (P_0 >= 0)
				{
					if (P_0 >= ((CollectionView)mk7DnWl3wlUuCiWTlOmk(ListBoxItems)).Count)
					{
						goto IL_00b6;
					}
					break;
				}
				return;
			case 2:
				break;
			}
			break;
			IL_00b6:
			num = 3;
		}
		ListBoxItems.SelectedIndex = P_0;
	}

	public static void XYDb6RbGFn(Window P_0)
	{
		IeR8GIbkxpRdsiC2GtW ieR8GIbkxpRdsiC2GtW = new IeR8GIbkxpRdsiC2GtW();
		ieR8GIbkxpRdsiC2GtW.Owner = P_0;
		ieR8GIbkxpRdsiC2GtW.ShowDialog();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!DQsbOsUkpL)
		{
			DQsbOsUkpL = true;
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108530762), UriKind.Relative);
			vrXtj1l33QOMfi5HKniP(this, uri);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		int num2;
		switch (P_0)
		{
		case 10:
			ButtonCancel = (Button)P_1;
			ButtonCancel.Click += ln3bjQ8KJC;
			break;
		case 6:
			ButtonMoveDown = (Button)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 2:
			ListBoxItems = (ListBox)P_1;
			cGKU2El3uCUswYyaPXV7(ListBoxItems, new SelectionChangedEventHandler(zqKbSSU4e6));
			num = 6;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
			{
				num = 4;
			}
			goto IL_0009;
		case 3:
			PropertyGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
			break;
		default:
			DQsbOsUkpL = true;
			break;
		case 7:
			ButtonRemove = (Button)P_1;
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 4:
			ButtonAdd = (Button)P_1;
			num2 = 8;
			goto IL_0005;
		case 8:
			ButtonApply = (Button)P_1;
			num2 = 2;
			goto IL_0005;
		case 5:
			ButtonMoveUp = (Button)P_1;
			ButtonMoveUp.Click += nGMbLAtRRE;
			break;
		case 9:
			ButtonOk = (Button)P_1;
			ButtonOk.Click += i32bc8Btxa;
			num2 = 7;
			goto IL_0005;
		case 1:
			{
				fn9UHnl3pRXU57EpX87B((IeR8GIbkxpRdsiC2GtW)P_1, new RoutedEventHandler(fBOb5WpRrh));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
				{
					num = 3;
				}
				goto IL_0009;
			}
			IL_0005:
			num = num2;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 8:
					ButtonAdd.Click += vMRbxeFdNQ;
					num = 4;
					break;
				case 7:
					return;
				case 3:
					return;
				case 1:
					bqPsmLl3zF5k4wq1wYkp(ButtonMoveDown, new RoutedEventHandler(L47beS5mXK));
					return;
				case 6:
					return;
				case 4:
					return;
				case 0:
					return;
				case 5:
					ButtonRemove.Click += bxwbs0YsjG;
					return;
				case 2:
					ButtonApply.Click += xgXbXSGlns;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	static IeR8GIbkxpRdsiC2GtW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void Vnstwcl3UeNcTrSthDNO(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)P_0);
	}

	internal static void eZNcG7l3TAGLyVpomrYH(object P_0, GridLength P_1)
	{
		((TreeListViewColumn)P_0).Width = P_1;
	}

	internal static bool OrjkGGl3WxktowehxEPX()
	{
		return NVQvEtl3I8vLJvWhEcmf == null;
	}

	internal static IeR8GIbkxpRdsiC2GtW HrX81ol3tXsEof0LyXdl()
	{
		return NVQvEtl3I8vLJvWhEcmf;
	}

	internal static void nP0Npvl3yurZqjjym9Jd(object P_0, bool P_1)
	{
		((UIElement)P_0).IsEnabled = P_1;
	}

	internal static int xXWItUl3ZWQcyUcbDkfr(object P_0)
	{
		return ((Selector)P_0).SelectedIndex;
	}

	internal static int sLT9Hol3VRxulxm76lrJ(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static void wlen2Dl3CMro5fmtmdRI(object P_0, int P_1)
	{
		((ItemCollection)P_0).RemoveAt(P_1);
	}

	internal static void UlgTN3l3raadRA9lCkEp(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object FmO349l3KvfdfpcsgVui()
	{
		return XhswApH3iouMedcVCcQ4.Settings;
	}

	internal static void K5ggEll3mCZjQ8NgSJE5(object P_0)
	{
		((List<bPlY5UHFwpoioxZbeXFB>)P_0).Clear();
	}

	internal static object f5plUul3hWarXTYYZQa2(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object mk7DnWl3wlUuCiWTlOmk(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object A6eFr1l37J67Jhx6KOkM()
	{
		return TigerTrade.Properties.Resources.PortfolioGroupEditorWindowTitle;
	}

	internal static object FxVqW0l38Nv607SDxEy3()
	{
		return TigerTrade.Properties.Resources.PortfolioGroupEditorWindowRemoveDuplicateNames;
	}

	internal static int Gw4nGql3AMT3ww9xH1mb(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static void FHB84El3PU2uifOYurQZ(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static object arpPwkl3JtjiQqfVeLoA(object P_0, int P_1)
	{
		return ((ItemCollection)P_0)[P_1];
	}

	internal static int qVOx8El3FdtJng4dB0v9(object P_0)
	{
		return ((CollectionView)P_0).Count;
	}

	internal static void vrXtj1l33QOMfi5HKniP(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void fn9UHnl3pRXU57EpX87B(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void cGKU2El3uCUswYyaPXV7(object P_0, object P_1)
	{
		((Selector)P_0).SelectionChanged += (SelectionChangedEventHandler)P_1;
	}

	internal static void bqPsmLl3zF5k4wq1wYkp(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
