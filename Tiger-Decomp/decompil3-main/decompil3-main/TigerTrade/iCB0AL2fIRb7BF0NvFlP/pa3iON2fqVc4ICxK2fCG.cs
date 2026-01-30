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
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Editors;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using NHkZqbf77HnCtq0ER8ta;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using yDO8qofhQHpBlOTGIf1I;

namespace iCB0AL2fIRb7BF0NvFlP;

internal sealed class pa3iON2fqVc4ICxK2fCG : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	public delegate void urvufRndxFMqS4RGlKyL();

	[Serializable]
	[CompilerGenerated]
	private sealed class HcV8GSndLKJ3CL8TJm57
	{
		public static readonly HcV8GSndLKJ3CL8TJm57 tgIndXjkyPR;

		public static Func<BpmEftf7wYbuVebk5Vku, bool> qIvndccrXDP;

		public static Func<BpmEftf7wYbuVebk5Vku, DateTime> guWndjZl4pm;

		private static HcV8GSndLKJ3CL8TJm57 KHxFrQNlzOkxPFlWCWDB;

		static HcV8GSndLKJ3CL8TJm57()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					tgIndXjkyPR = new HcV8GSndLKJ3CL8TJm57();
					return;
				case 1:
					swxPVoN4HShEMA16o9Nk();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public HcV8GSndLKJ3CL8TJm57()
		{
			o5IsFSN4f23bECXSvZF3();
			base._002Ector();
		}

		internal bool AWFndeTg7eT(BpmEftf7wYbuVebk5Vku l)
		{
			return l.oqff8mcuTCH != DateTime.MinValue;
		}

		internal DateTime KrqndsvffXj(BpmEftf7wYbuVebk5Vku l)
		{
			return l.oqff8mcuTCH;
		}

		internal static void swxPVoN4HShEMA16o9Nk()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool tkG3nvN40E6sqMqS7YRj()
		{
			return KHxFrQNlzOkxPFlWCWDB == null;
		}

		internal static HcV8GSndLKJ3CL8TJm57 LFLRleN42GCiPWvnDfNf()
		{
			return KHxFrQNlzOkxPFlWCWDB;
		}

		internal static void o5IsFSN4f23bECXSvZF3()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	private MarketSettings JFH2fPam1ko;

	private urvufRndxFMqS4RGlKyL Vi92fJsYXHj;

	private BpmEftf7wYbuVebk5Vku Jwi2fFIDoh3;

	private Symbol hmh2f3WHdTU;

	[CompilerGenerated]
	private BpmEftf7wYbuVebk5Vku Yqg2fptkEu5;

	internal ListBox ListBoxItems;

	internal DoubleEditBox DoubleEditBoxPrice;

	internal Button ButtonAdd;

	internal Button ButtonMoveUp;

	internal Button ButtonMoveDown;

	internal Button ButtonRemove;

	internal Button ButtonApply;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool vCu2fuktDUc;

	private static pa3iON2fqVc4ICxK2fCG UJ7Xga4gMgFk9ej6aw73;

	public BpmEftf7wYbuVebk5Vku LevelTemplate
	{
		[CompilerGenerated]
		get
		{
			return Yqg2fptkEu5;
		}
		[CompilerGenerated]
		set
		{
			Yqg2fptkEu5 = yqg2fptkEu;
		}
	}

	public pa3iON2fqVc4ICxK2fCG()
	{
		olKD2u4gI9QQwEbtuYiw();
		base._002Ector();
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F06E8F));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	internal static bool up32fW8gi8s(Window P_0, MarketSettings P_1, Symbol P_2, urvufRndxFMqS4RGlKyL P_3, BpmEftf7wYbuVebk5Vku P_4)
	{
		return new pa3iON2fqVc4ICxK2fCG
		{
			Owner = P_0,
			JFH2fPam1ko = P_1,
			hmh2f3WHdTU = P_2,
			Vi92fJsYXHj = P_3,
			Jwi2fFIDoh3 = P_4
		}.ShowDialog() == true;
	}

	private void LevelsEditorWindow_Loaded(object sender, RoutedEventArgs e)
	{
		DoubleEditBoxPrice.SmallChange = hmh2f3WHdTU.Step;
		LevelTemplate = ((BpmEftf7wYbuVebk5Vku)ucZrep4gWowuWy0mhnSb()).Clone() as BpmEftf7wYbuVebk5Vku;
		ifWlfmRSlkr((string)oJhDQI4gteXSuFMTmqox(-90307782 ^ -90272364));
		e0W2fmgSVgJ();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void fxG2ftEsVYY(object P_0, SelectionChangedEventArgs P_1)
	{
		n1MhRx4gUbSgFkT18fIa(ButtonMoveUp, ListBoxItems.SelectedIndex > 0);
		n1MhRx4gUbSgFkT18fIa(ButtonMoveDown, ListBoxItems.SelectedIndex < ((CollectionView)v9gDWq4gTP2cTb6AEfWw(ListBoxItems)).Count - 1);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ButtonRemove.IsEnabled = ListBoxItems.SelectedIndex >= 0;
	}

	private void gS62fUdgpO0(object P_0, RoutedEventArgs P_1)
	{
		BpmEftf7wYbuVebk5Vku bpmEftf7wYbuVebk5Vku;
		int num;
		if (wsrDWBfhEyqEYOXKI8P0.RCBfhTKYHeQ() == null)
		{
			bpmEftf7wYbuVebk5Vku = new BpmEftf7wYbuVebk5Vku();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
			{
				num = 1;
			}
		}
		else
		{
			bpmEftf7wYbuVebk5Vku = (BpmEftf7wYbuVebk5Vku)((BpmEftf7wYbuVebk5Vku)ucZrep4gWowuWy0mhnSb()).Clone();
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				ListBoxItems.SelectedIndex = ((CollectionView)v9gDWq4gTP2cTb6AEfWw(ListBoxItems)).Count - 1;
				return;
			case 3:
				bpmEftf7wYbuVebk5Vku.balf7pvwCJI = deVb3G4gy4s7X5b0hoKx().ToString();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num = 0;
				}
				continue;
			}
			bpmEftf7wYbuVebk5Vku.u2Uf80PdXgt = WRc3Kg4gZR4Vi2iRjfJ5(hmh2f3WHdTU);
			bpmEftf7wYbuVebk5Vku.YHbf8fE2TKg = hmh2f3WHdTU.Precision;
			((ItemCollection)v9gDWq4gTP2cTb6AEfWw(ListBoxItems)).Add((object)bpmEftf7wYbuVebk5Vku);
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
			{
				num = 0;
			}
		}
	}

	private void jCK2fTjvX42(object P_0, RoutedEventArgs P_1)
	{
		W3h2fhM4lde(-1);
	}

	private void K1V2fyjC8L2(object P_0, RoutedEventArgs P_1)
	{
		W3h2fhM4lde(1);
	}

	private void Afs2fZUYQFd(object P_0, RoutedEventArgs P_1)
	{
		RemoveItem();
	}

	private void RemoveItem()
	{
		int selectedIndex = ListBoxItems.SelectedIndex;
		int num;
		if (selectedIndex >= 0)
		{
			XJCBtm4gV6mxDcUHJq09(ListBoxItems.Items, selectedIndex);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		}
		Gax2fwdN1fv(selectedIndex);
	}

	private void QBJ2fVfDIiF(object P_0, RoutedEventArgs P_1)
	{
		NMO2fKIktYn();
	}

	private void tgx2fCeQLFm(object P_0, RoutedEventArgs P_1)
	{
		NMO2fKIktYn();
		uowyPB4gCK39h9lJ9A7a(this);
	}

	private void FTD2fret0wG(object P_0, RoutedEventArgs P_1)
	{
		uowyPB4gCK39h9lJ9A7a(this);
	}

	private void NMO2fKIktYn()
	{
		List<BpmEftf7wYbuVebk5Vku> list = ((IEnumerable)v9gDWq4gTP2cTb6AEfWw(ListBoxItems)).Cast<BpmEftf7wYbuVebk5Vku>().ToList();
		JFH2fPam1ko.Levels.Ia0fPf3Ad95((string)IejK2i4grW4vntPcFG7Q(hmh2f3WHdTU), list);
		SaveTemplate(list);
		urvufRndxFMqS4RGlKyL vi92fJsYXHj = Vi92fJsYXHj;
		int num;
		if (vi92fJsYXHj == null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		vi92fJsYXHj();
		goto IL_008e;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		goto IL_008e;
		IL_008e:
		e0W2fmgSVgJ();
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	private void SaveTemplate(IEnumerable<BpmEftf7wYbuVebk5Vku> levels)
	{
		if (LevelTemplate != null)
		{
			BpmEftf7wYbuVebk5Vku bpmEftf7wYbuVebk5Vku = (from l in levels
				where l.oqff8mcuTCH != DateTime.MinValue
				orderby l.oqff8mcuTCH
				select l).LastOrDefault();
			if (bpmEftf7wYbuVebk5Vku != null)
			{
				LevelTemplate.Price = bpmEftf7wYbuVebk5Vku.Price;
				LevelTemplate.Text = bpmEftf7wYbuVebk5Vku.Text;
			}
			wsrDWBfhEyqEYOXKI8P0.GmAfhyYKw1O((BpmEftf7wYbuVebk5Vku)LevelTemplate.Clone());
		}
	}

	private void e0W2fmgSVgJ()
	{
		ButtonMoveUp.IsEnabled = false;
		ButtonMoveDown.IsEnabled = false;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
		{
			num = 1;
		}
		ItemCollection items = default(ItemCollection);
		int num4 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				ButtonRemove.IsEnabled = false;
				items = ListBoxItems.Items;
				num4 = ListBoxItems.SelectedIndex;
				num = 2;
				break;
			default:
				cugBBR4gmjeyTbSYaDBD(ListBoxItems, 0);
				return;
			case 3:
				if (MLovNb4gKMXsXpjVbCt5(ListBoxItems) != -1)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
				{
					num = 0;
				}
				break;
			case 2:
			{
				items.Clear();
				using (List<BpmEftf7wYbuVebk5Vku>.Enumerator enumerator = JFH2fPam1ko.Levels.IDQfPHZll5G(hmh2f3WHdTU.ID).GetEnumerator())
				{
					while (true)
					{
						IL_00a9:
						int num3;
						if (enumerator.MoveNext())
						{
							BpmEftf7wYbuVebk5Vku current = enumerator.Current;
							num2 = items.Add((BpmEftf7wYbuVebk5Vku)current.Clone());
							if (current != Jwi2fFIDoh3)
							{
								continue;
							}
							num3 = 2;
						}
						else
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
							{
								num3 = 0;
							}
						}
						while (true)
						{
							switch (num3)
							{
							default:
								goto end_IL_0044;
							case 1:
								break;
							case 2:
								if (num4 == -1)
								{
									num4 = num2;
									Jwi2fFIDoh3 = null;
									num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 0:
								goto end_IL_0044;
							}
							goto IL_00a9;
							continue;
							end_IL_0044:
							break;
						}
						break;
					}
				}
				ListBoxItems.SelectedIndex = num4;
				num = 3;
				break;
			}
			}
		}
	}

	private void W3h2fhM4lde(int P_0)
	{
		int selectedIndex = ListBoxItems.SelectedIndex;
		int num = selectedIndex + P_0;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
		{
			num2 = 3;
		}
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (selectedIndex >= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 1:
				if (num >= ListBoxItems.Items.Count)
				{
					return;
				}
				obj = iPktUt4ghG8h0RFwgO6y(ListBoxItems.Items, selectedIndex);
				ListBoxItems.Items.RemoveAt(selectedIndex);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				w9JItI4gw3JmhXTgYQLJ(v9gDWq4gTP2cTb6AEfWw(ListBoxItems), selectedIndex + P_0, obj);
				ListBoxItems.SelectedIndex = num;
				return;
			}
			if (num >= 0)
			{
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return;
		}
	}

	private void Gax2fwdN1fv(int P_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				cugBBR4gmjeyTbSYaDBD(ListBoxItems, P_0);
				return;
			case 3:
				if (P_0 >= 0)
				{
					num2 = 2;
					break;
				}
				P_0 = 0;
				goto case 2;
			case 1:
				if (P_0 < ListBoxItems.Items.Count)
				{
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				if (P_0 >= ListBoxItems.Items.Count)
				{
					P_0 = ((CollectionView)v9gDWq4gTP2cTb6AEfWw(ListBoxItems)).Count - 1;
				}
				if (P_0 < 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 0:
				return;
			}
		}
	}

	private void hxX2f7kmJpb(object P_0, KeyEventArgs P_1)
	{
		if (P_1.Key == Key.Delete)
		{
			RemoveItem();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!vCu2fuktDUc)
		{
			vCu2fuktDUc = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F06DF1), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)YrUBNC4g7CBwJhC9ttGr(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ButtonOk.Click += tgx2fCeQLFm;
				return;
			case 7:
				return;
			case 5:
				vCu2fuktDUc = true;
				return;
			case 0:
				return;
			case 6:
				switch (P_0)
				{
				case 5:
					ButtonMoveDown = (Button)P_1;
					num2 = 4;
					break;
				case 1:
					ListBoxItems = (ListBox)P_1;
					ListBoxItems.SelectionChanged += fxG2ftEsVYY;
					ListBoxItems.KeyDown += hxX2f7kmJpb;
					num2 = 3;
					break;
				case 7:
					ButtonApply = (Button)P_1;
					ButtonApply.Click += QBJ2fVfDIiF;
					num2 = 9;
					break;
				case 3:
					ButtonAdd = (Button)P_1;
					Oas4424g8Aen1MGvVkJ0(ButtonAdd, new RoutedEventHandler(gS62fUdgpO0));
					num2 = 8;
					break;
				case 9:
					ButtonCancel = (Button)P_1;
					num2 = 2;
					break;
				default:
					num2 = 5;
					break;
				case 4:
					ButtonMoveUp = (Button)P_1;
					ButtonMoveUp.Click += jCK2fTjvX42;
					return;
				case 8:
					ButtonOk = (Button)P_1;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					DoubleEditBoxPrice = (DoubleEditBox)P_1;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					ButtonRemove = (Button)P_1;
					ButtonRemove.Click += Afs2fZUYQFd;
					return;
				}
				break;
			case 4:
				ButtonMoveDown.Click += K1V2fyjC8L2;
				return;
			case 8:
				return;
			case 2:
				ButtonCancel.Click += FTD2fret0wG;
				num2 = 7;
				break;
			case 9:
				return;
			case 3:
				return;
			}
		}
	}

	static pa3iON2fqVc4ICxK2fCG()
	{
		vNpor94gAUj5T3vvJ7Yw();
	}

	internal static bool mwnamO4gOsa7ahvHdpVk()
	{
		return UJ7Xga4gMgFk9ej6aw73 == null;
	}

	internal static pa3iON2fqVc4ICxK2fCG C06tCk4gq2pv0nsZFkt0()
	{
		return UJ7Xga4gMgFk9ej6aw73;
	}

	internal static void olKD2u4gI9QQwEbtuYiw()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object ucZrep4gWowuWy0mhnSb()
	{
		return wsrDWBfhEyqEYOXKI8P0.RCBfhTKYHeQ();
	}

	internal static object oJhDQI4gteXSuFMTmqox(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void n1MhRx4gUbSgFkT18fIa(object P_0, bool P_1)
	{
		((UIElement)P_0).IsEnabled = P_1;
	}

	internal static object v9gDWq4gTP2cTb6AEfWw(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static Guid deVb3G4gy4s7X5b0hoKx()
	{
		return Guid.NewGuid();
	}

	internal static double WRc3Kg4gZR4Vi2iRjfJ5(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static void XJCBtm4gV6mxDcUHJq09(object P_0, int P_1)
	{
		((ItemCollection)P_0).RemoveAt(P_1);
	}

	internal static void uowyPB4gCK39h9lJ9A7a(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object IejK2i4grW4vntPcFG7Q(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static int MLovNb4gKMXsXpjVbCt5(object P_0)
	{
		return ((Selector)P_0).SelectedIndex;
	}

	internal static void cugBBR4gmjeyTbSYaDBD(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static object iPktUt4ghG8h0RFwgO6y(object P_0, int P_1)
	{
		return ((ItemCollection)P_0)[P_1];
	}

	internal static void w9JItI4gw3JmhXTgYQLJ(object P_0, int P_1, object P_2)
	{
		((ItemCollection)P_0).Insert(P_1, P_2);
	}

	internal static object YrUBNC4g7CBwJhC9ttGr(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void Oas4424g8Aen1MGvVkJ0(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void vNpor94gAUj5T3vvJ7Yw()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
