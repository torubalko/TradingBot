using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using B5A5hB2z2EVuSQ5VHGmu;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using jqfYn59CZIflM45NL1SW;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Sources;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace Bge4KF2dmmQwopAHbhyf;

internal sealed class aAhK7N2dKpmmKvNUeg2Y : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	[CompilerGenerated]
	private sealed class CcI2HBnMESc9KRT5ESXC
	{
		public IPropertyModel MKBnMdNnB6T;

		internal static CcI2HBnMESc9KRT5ESXC G2uTaENNGNcrvpRtfw91;

		public CcI2HBnMESc9KRT5ESXC()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void UX7nMQV0r47(IndicatorSourceBase s)
		{
			if (s != null)
			{
				MKBnMdNnB6T.Value = s;
			}
		}

		static CcI2HBnMESc9KRT5ESXC()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool sPqqtSNNYyCTKOjsmSpL()
		{
			return G2uTaENNGNcrvpRtfw91 == null;
		}

		internal static CcI2HBnMESc9KRT5ESXC F3VGfaNNoO3aRmQXevbc()
		{
			return G2uTaENNGNcrvpRtfw91;
		}
	}

	[CompilerGenerated]
	private static readonly RoutedCommand pV82gHHF1PP;

	[CompilerGenerated]
	private Action<IndicatorSourceBase> VhR2gfvRYHK;

	private IndicatorSourceBase M0c2g9d33P6;

	private IndicatorSourceBase bwo2gn55Lj9;

	internal TreeView TreeViewSources;

	internal VoU9lv2z05uTExIsC3Ip PropertyGrid;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool p2C2gGl2EUf;

	internal static aAhK7N2dKpmmKvNUeg2Y VuG8bx4AO60g6gW57XWn;

	public static RoutedCommand ShowSelectSourceDialog
	{
		[CompilerGenerated]
		get
		{
			return pV82gHHF1PP;
		}
	}

	public IndicatorSourceBase SelectedSource
	{
		get
		{
			return M0c2g9d33P6;
		}
		set
		{
			if (!object.Equals(indicatorSourceBase, M0c2g9d33P6))
			{
				M0c2g9d33P6 = indicatorSourceBase;
				ifWlfmRSlkr((string)eykUAN4AWfKOeaygvux6(-490987856 ^ -490940256));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
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
	}

	public IndicatorSourceBase CurrentSource
	{
		get
		{
			return bwo2gn55Lj9;
		}
		set
		{
			if (!uuChhH4Ati7JcWqRjeTR(indicatorSourceBase, bwo2gn55Lj9))
			{
				bwo2gn55Lj9 = indicatorSourceBase;
				ifWlfmRSlkr((string)eykUAN4AWfKOeaygvux6(-29702950 ^ -29752598));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
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
	}

	[SpecialName]
	[CompilerGenerated]
	public void jQu2dzbXExL(Action<IndicatorSourceBase> P_0)
	{
		Action<IndicatorSourceBase> action = VhR2gfvRYHK;
		Action<IndicatorSourceBase> action2;
		do
		{
			action2 = action;
			Action<IndicatorSourceBase> value = (Action<IndicatorSourceBase>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref VhR2gfvRYHK, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Kaj2g0b1jxT(Action<IndicatorSourceBase> P_0)
	{
		Action<IndicatorSourceBase> action = VhR2gfvRYHK;
		Action<IndicatorSourceBase> action2;
		do
		{
			action2 = action;
			Action<IndicatorSourceBase> value = (Action<IndicatorSourceBase>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref VhR2gfvRYHK, value, action2);
		}
		while ((object)action != action2);
	}

	static aAhK7N2dKpmmKvNUeg2Y()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				pV82gHHF1PP = new RoutedCommand((string)eykUAN4AWfKOeaygvux6(-671204305 ^ -671154261), Type.GetTypeFromHandle(Hs4GNy4AUrUVCl99nnhd(33555044)));
				P03P1l4ATBxmcQNUn7R9(Type.GetTypeFromHandle(Hs4GNy4AUrUVCl99nnhd(33555044)), new CommandBinding(ShowSelectSourceDialog, THm2dhS8qQT, taW2dwckHXi));
				return;
			}
		}
	}

	private static void THm2dhS8qQT(object P_0, ExecutedRoutedEventArgs P_1)
	{
		CcI2HBnMESc9KRT5ESXC CS_0024_003C_003E8__locals8 = new CcI2HBnMESc9KRT5ESXC();
		object obj = z32MCl4AyPjgjMXIllWv(P_1);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
		{
			num = 0;
		}
		aAhK7N2dKpmmKvNUeg2Y aAhK7N2dKpmmKvNUeg2Y2 = default(aAhK7N2dKpmmKvNUeg2Y);
		IndicatorSourceBase indicatorSourceBase = default(IndicatorSourceBase);
		while (true)
		{
			switch (num)
			{
			case 6:
				P_1.Handled = true;
				num = 5;
				break;
			case 5:
				return;
			case 4:
				if (O4piFe4ACxmC21EOLFok(aAhK7N2dKpmmKvNUeg2Y2) != null)
				{
					nPEL4u4AZXqrvKlIXkEI(CS_0024_003C_003E8__locals8.MKBnMdNnB6T, O4piFe4ACxmC21EOLFok(aAhK7N2dKpmmKvNUeg2Y2));
					num = 6;
					break;
				}
				goto case 6;
			case 2:
				indicatorSourceBase = (IndicatorSourceBase)trXx2x4AV7JtELHNLwkg(CS_0024_003C_003E8__locals8.MKBnMdNnB6T);
				aAhK7N2dKpmmKvNUeg2Y2 = new aAhK7N2dKpmmKvNUeg2Y
				{
					Owner = (P_0 as Window),
					SelectedSource = indicatorSourceBase
				};
				aAhK7N2dKpmmKvNUeg2Y2.jQu2dzbXExL(delegate(IndicatorSourceBase s)
				{
					if (s != null)
					{
						CS_0024_003C_003E8__locals8.MKBnMdNnB6T.Value = s;
					}
				});
				if (aAhK7N2dKpmmKvNUeg2Y2.ShowDialog() != true)
				{
					num = 3;
					break;
				}
				goto case 4;
			case 7:
				if (CS_0024_003C_003E8__locals8.MKBnMdNnB6T.Value == null)
				{
					nPEL4u4AZXqrvKlIXkEI(CS_0024_003C_003E8__locals8.MKBnMdNnB6T, new StockSource());
					num = 2;
					break;
				}
				goto case 2;
			case 1:
				if (CS_0024_003C_003E8__locals8.MKBnMdNnB6T == null)
				{
					return;
				}
				num = 7;
				break;
			default:
				CS_0024_003C_003E8__locals8.MKBnMdNnB6T = obj as IPropertyModel;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				CS_0024_003C_003E8__locals8.MKBnMdNnB6T.Value = indicatorSourceBase;
				goto case 6;
			}
		}
	}

	private static void taW2dwckHXi(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_1.Parameter is IPropertyModel)
		{
			lt42EX4ArP0JP79ERq3Y(P_1, true);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			yjY5Oj4AKx66HWBvceZR(P_1, true);
		}
	}

	public aAhK7N2dKpmmKvNUeg2Y()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82878330));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		lXU2dA9hUeL();
	}

	private void fK92d7yvZSp(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (CurrentSource != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				SelectedSource = CurrentSource;
				base.DialogResult = true;
				break;
			}
			break;
		}
		Nh4ARf4Amg8bUvxstEQ4(this);
	}

	private void QdW2d8xOr8N(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	private void lXU2dA9hUeL()
	{
		bool flag = true;
		string[] array = og0EJ79CyLyrLqprMA0b.hH69CCtHnfs();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
		{
			num = 1;
		}
		int num3 = default(int);
		TreeViewItem treeViewItem = default(TreeViewItem);
		IndicatorSourceBase indicatorSourceBase = default(IndicatorSourceBase);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 2:
			{
				num3++;
				int num4 = 3;
				num = num4;
				continue;
			}
			case 1:
				num3 = 0;
				break;
			case 3:
				break;
			default:
			{
				TreeViewSources.Items.Add(treeViewItem);
				IEnumerator<string> enumerator = indicatorSourceBase.GetSeriesList().GetEnumerator();
				try
				{
					while (plQOdZ4AJAQPZD9pX1t6(enumerator))
					{
						string current = enumerator.Current;
						TreeViewItem treeViewItem2 = new TreeViewItem();
						CDyXYe4AAFCms0A1J7aW(treeViewItem2, current);
						hNqWG04AwleZ2E3sIeZN(treeViewItem2, current);
						treeViewItem2.IsSelected = SelectedSource != null && dtIvXE4A70mfhtUEf2ad(current, SelectedSource.SelectedSeries);
						TreeViewItem treeViewItem3 = treeViewItem2;
						int num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num2 = 0;
						}
						while (true)
						{
							switch (num2)
							{
							case 1:
								JaqfFZ4APJyrZjUVchdG(treeViewItem.Items, treeViewItem3);
								num2 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						JXLZrF4AFPZxuD0YHT1O(enumerator);
					}
				}
				goto case 2;
			}
			}
			if (num3 >= array.Length)
			{
				break;
			}
			indicatorSourceBase = (IndicatorSourceBase)VIphQG4AhyIhnIs8YT4u(array[num3]);
			TreeViewItem obj = new TreeViewItem
			{
				Header = indicatorSourceBase.Name
			};
			hNqWG04AwleZ2E3sIeZN(obj, indicatorSourceBase);
			WoE3oE4A84t8RR14eBQn(obj, flag || (SelectedSource != null && dtIvXE4A70mfhtUEf2ad(indicatorSourceBase.Name, SelectedSource.Name)));
			treeViewItem = obj;
			flag = false;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
			{
				num = 0;
			}
		}
	}

	private void wZG2dPHUiAU(object P_0, RoutedPropertyChangedEventArgs<object> P_1)
	{
		CurrentSource = null;
		if (!(TreeViewSources.SelectedItem is TreeViewItem { Tag: not null } treeViewItem))
		{
			return;
		}
		string text = treeViewItem.Tag as string;
		if (!string.IsNullOrEmpty(text))
		{
			CurrentSource = ((TreeViewItem)treeViewItem.Parent).Tag as IndicatorSourceBase;
			if (CurrentSource != null)
			{
				if (CurrentSource.Name == SelectedSource.Name && CurrentSource.SelectedSeries == text)
				{
					CurrentSource.CopySettings(SelectedSource);
				}
				else
				{
					CurrentSource.SelectedSeries = text;
				}
				VhR2gfvRYHK?.Invoke(CurrentSource.CloneSource());
			}
			return;
		}
		foreach (TreeViewItem item in (IEnumerable)TreeViewSources.Items)
		{
			item.IsExpanded = false;
		}
		treeViewItem.IsExpanded = true;
	}

	private void PropertyGrid_OnPropertyValueChanged(object sender, PropertyModelValueChangeEventArgs e)
	{
		VhR2gfvRYHK?.Invoke(CurrentSource.CloneSource());
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!p2C2gGl2EUf)
		{
			p2C2gGl2EUf = true;
			Uri resourceLocator = new Uri((string)eykUAN4AWfKOeaygvux6(0x2CBEEA31 ^ 0x2CBE2C49), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				TreeViewSources = (TreeView)P_1;
				TreeViewSources.SelectedItemChanged += wZG2dPHUiAU;
				return;
			case 4:
				switch (P_0)
				{
				case 1:
					break;
				case 3:
					ButtonOk = (Button)P_1;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				default:
					num2 = 3;
					goto end_IL_0012;
				case 2:
					PropertyGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
					return;
				case 4:
					ButtonCancel = (Button)P_1;
					ButtonCancel.Click += QdW2d8xOr8N;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num2 = 1;
					}
					goto end_IL_0012;
				}
				goto case 2;
			default:
				yE8sld4A36Y3CKASiXAq(ButtonOk, new RoutedEventHandler(fK92d7yvZSp));
				return;
			case 1:
				return;
			case 3:
				{
					p2C2gGl2EUf = true;
					return;
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static object eykUAN4AWfKOeaygvux6(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool vGKiCh4AqZiTE6CA9Kkm()
	{
		return VuG8bx4AO60g6gW57XWn == null;
	}

	internal static aAhK7N2dKpmmKvNUeg2Y qQpBkd4AIeXViV500pNA()
	{
		return VuG8bx4AO60g6gW57XWn;
	}

	internal static bool uuChhH4Ati7JcWqRjeTR(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static RuntimeTypeHandle Hs4GNy4AUrUVCl99nnhd(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static void P03P1l4ATBxmcQNUn7R9(Type P_0, object P_1)
	{
		CommandManager.RegisterClassCommandBinding(P_0, (CommandBinding)P_1);
	}

	internal static object z32MCl4AyPjgjMXIllWv(object P_0)
	{
		return ((ExecutedRoutedEventArgs)P_0).Parameter;
	}

	internal static void nPEL4u4AZXqrvKlIXkEI(object P_0, object P_1)
	{
		((IPropertyModel)P_0).Value = P_1;
	}

	internal static object trXx2x4AV7JtELHNLwkg(object P_0)
	{
		return ((IPropertyModel)P_0).Value;
	}

	internal static object O4piFe4ACxmC21EOLFok(object P_0)
	{
		return ((aAhK7N2dKpmmKvNUeg2Y)P_0).SelectedSource;
	}

	internal static void lt42EX4ArP0JP79ERq3Y(object P_0, bool P_1)
	{
		((CanExecuteRoutedEventArgs)P_0).CanExecute = P_1;
	}

	internal static void yjY5Oj4AKx66HWBvceZR(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static void Nh4ARf4Amg8bUvxstEQ4(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object VIphQG4AhyIhnIs8YT4u(object P_0)
	{
		return og0EJ79CyLyrLqprMA0b.qpD9CV0FEWb((string)P_0);
	}

	internal static void hNqWG04AwleZ2E3sIeZN(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Tag = P_1;
	}

	internal static bool dtIvXE4A70mfhtUEf2ad(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void WoE3oE4A84t8RR14eBQn(object P_0, bool P_1)
	{
		((TreeViewItem)P_0).IsExpanded = P_1;
	}

	internal static void CDyXYe4AAFCms0A1J7aW(object P_0, object P_1)
	{
		((HeaderedItemsControl)P_0).Header = P_1;
	}

	internal static int JaqfFZ4APJyrZjUVchdG(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static bool plQOdZ4AJAQPZD9pX1t6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void JXLZrF4AFPZxuD0YHT1O(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void yE8sld4A36Y3CKASiXAq(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
