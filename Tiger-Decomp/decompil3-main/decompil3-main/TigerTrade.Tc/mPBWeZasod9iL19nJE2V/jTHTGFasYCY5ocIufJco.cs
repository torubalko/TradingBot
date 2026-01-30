using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Grids;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using O36HY1aeumxwrhMPQQiL;
using TigerTrade.Tc;
using TigerTrade.Tc.Manager;
using TigerTrade.Tc.Properties;
using UIKit.Core;
using X56sUtasxKVNFqSrsuOF;
using x97CE55GhEYKgt7TSVZT;

namespace mPBWeZasod9iL19nJE2V;

internal class jTHTGFasYCY5ocIufJco : UserControl, IComponentConnector
{
	internal TreeListView TreeListViewConnections;

	private bool Q4kas55gQPV;

	private static jTHTGFasYCY5ocIufJco ow4GrKxmyUONqlkEVgdU;

	public PmWBAcasSZi1i4TPFqN8 ViewModel => base.DataContext as PmWBAcasSZi1i4TPFqN8;

	public jTHTGFasYCY5ocIufJco()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				InitializeComponent();
				base.Loaded += O28asvscarA;
				return;
			}
			TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-60853733 ^ -60908493));
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
			{
				num = 1;
			}
		}
	}

	private void O28asvscarA(object P_0, EventArgs P_1)
	{
		base.Loaded -= O28asvscarA;
		CW2GevaepETlPEEUFsEM cW2GevaepETlPEEUFsEM = ViewModel.RgZaszFJE7w();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		HOoasD3bu74(TreeListViewConnections, cW2GevaepETlPEEUFsEM.Xwpas2WG3t8, (ColumnSortDirection?)cW2GevaepETlPEEUFsEM.Direction);
	}

	private bool EnGasBlgAyY(DependencyObject P_0)
	{
		do
		{
			if (VisualTreeHelper.GetParent(P_0) is TreeListViewItemCell)
			{
				return false;
			}
			P_0 = (DependencyObject)mXo5X8xmCaW7rbwMuhki(P_0);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		while (!(P_0 is Control));
		return true;
	}

	private void TI2asaccpel(object P_0, MouseButtonEventArgs P_1)
	{
		if (!(wS4EjKxmrtVNbIvo8DwP(P_1) is DependencyObject dependencyObject))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		if (!EnGasBlgAyY(dependencyObject))
		{
			rf3UBExmmVVErSAAXGwR(yoI10jxmKtZ871pWbdtM(ViewModel), ViewModel.SelectedConnection);
		}
	}

	private void ConnectionIndicators_OnIndicatorChanged(int indicator, string connectionID)
	{
		IEnumerator<ConnectionInfo> enumerator = ViewModel.Connections.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ConnectionInfo current = enumerator.Current;
				if (!((string)IM1U1Gxmh8GHN5rr2BZD(current) == connectionID))
				{
					continue;
				}
				while (true)
				{
					current.Indicator = indicator;
					int num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
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
		}
		finally
		{
			if (enumerator == null)
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
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
				enumerator.Dispose();
			}
		}
	}

	private string N8QasigydoT(int P_0)
	{
		return P_0 switch
		{
			0 => (string)BSGySRxmwZYf3Lv6jOwQ(-57768881 ^ -57710079), 
			1 => (string)BSGySRxmwZYf3Lv6jOwQ(-3429745 ^ -3470361), 
			2 => F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1879007818), 
			_ => string.Empty, 
		};
	}

	private ColumnSortDirection? OWHasl9SoYk(ColumnSortDirection? P_0)
	{
		if (!P_0.HasValue)
		{
			return ColumnSortDirection.Ascending;
		}
		if (P_0 == ColumnSortDirection.Ascending)
		{
			return ColumnSortDirection.Descending;
		}
		return null;
	}

	private void GUVas46kxRN(object P_0, TreeListViewColumnEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		TreeListView treeListView = default(TreeListView);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				((TreeListViewColumn)iee7Yexm8kUI5C2b5LL2(P_1)).SortDirection = OWHasl9SoYk(P_1.Column.SortDirection);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				HOoasD3bu74(treeListView, text, ((TreeListViewColumn)iee7Yexm8kUI5C2b5LL2(P_1)).SortDirection);
				ViewModel.K3pasquYHAB(text, (ListSortDirection?)P_1.Column.SortDirection);
				return;
			case 1:
				text = N8QasigydoT(e74urOxm7tfRnNHsa02M(P_1.Column));
				num2 = 3;
				break;
			case 2:
				treeListView = P_0 as TreeListView;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void HOoasD3bu74(TreeListView P_0, string P_1, ColumnSortDirection? P_2)
	{
		foreach (TreeListViewColumn column in P_0.Columns)
		{
			column.SortDirection = ((N8QasigydoT(column.Index) != P_1) ? ((ColumnSortDirection?)null) : P_2);
		}
	}

	private void gdgasb0Zmh2(UIKit.Core.ContextMenu P_0, object P_1)
	{
		if (!(P_1 is ConnectionInfo connectionInfo))
		{
			return;
		}
		R6fasNMybnx(TigerTrade.Tc.Properties.Resources.ConnectionsWindowSetup, ViewModel.SetupCommand, P_0, P_1);
		int num;
		if (ViewModel.SkuasdfGWgK(connectionInfo))
		{
			R6fasNMybnx(TigerTrade.Tc.Properties.Resources.ConnectionsWindowOpenLogs, (ICommand)DnceQ5xmAVWyWvakH9at(ViewModel), P_0, P_1);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_003e;
		IL_003e:
		if (!ViewModel.IkbasQypYko(connectionInfo))
		{
			return;
		}
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c != 0)
		{
			num = 2;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				break;
			case 2:
				R6fasNMybnx(TigerTrade.Tc.Properties.Resources.TransaqControlPasswordChange, (ICommand)DNaTI0xmPF13KlCho8Ff(ViewModel), P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_003e;
	}

	private void R6fasNMybnx(string P_0, ICommand P_1, UIKit.Core.ContextMenu P_2, object P_3)
	{
		MenuItem newItem = new MenuItem
		{
			Header = P_0,
			Command = P_1,
			CommandParameter = P_3
		};
		((ItemCollection)erAX1SxmJQ2m7liK5PZg(P_2)).Add((object)newItem);
	}

	private void qXWaskaYMWp(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_1.Parameter is UIKit.Core.ContextMenu contextMenu && P_1.OriginalSource is FrameworkElement frameworkElement)
		{
			gdgasb0Zmh2(contextMenu, bMxqpbxmFdXmbwu5D02d(frameworkElement));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			case 2:
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Q4kas55gQPV)
		{
			Q4kas55gQPV = true;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri uri = new Uri((string)BSGySRxmwZYf3Lv6jOwQ(0x9F0F634 ^ 0x9F118BC), UriKind.Relative);
			hKGYp7xm3kMNm9Hf4sWo(this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)AgFhA7xmp1b5SEo7ykrE(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		if (P_0 != 1)
		{
			int num;
			if (P_0 != 2)
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
				{
					num = 0;
				}
			}
			else
			{
				TreeListViewConnections = (TreeListView)P_1;
				IsfNKcxmudVubMoQ6WUq(TreeListViewConnections, new MouseButtonEventHandler(TI2asaccpel));
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					TreeListViewConnections.ColumnHeaderTapped += GUVas46kxRN;
					return;
				}
				Q4kas55gQPV = true;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
				{
					num = 1;
				}
			}
		}
		((CommandBinding)P_1).Executed += qXWaskaYMWp;
	}

	static jTHTGFasYCY5ocIufJco()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool xSBFivxmZyD1iLUwTgnl()
	{
		return ow4GrKxmyUONqlkEVgdU == null;
	}

	internal static jTHTGFasYCY5ocIufJco eYnjYbxmVirVbN1q5Mop()
	{
		return ow4GrKxmyUONqlkEVgdU;
	}

	internal static object mXo5X8xmCaW7rbwMuhki(object P_0)
	{
		return VisualTreeHelper.GetParent((DependencyObject)P_0);
	}

	internal static object wS4EjKxmrtVNbIvo8DwP(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static object yoI10jxmKtZ871pWbdtM(object P_0)
	{
		return ((PmWBAcasSZi1i4TPFqN8)P_0).SetupCommand;
	}

	internal static void rf3UBExmmVVErSAAXGwR(object P_0, object P_1)
	{
		((ICommand)P_0).Execute(P_1);
	}

	internal static object IM1U1Gxmh8GHN5rr2BZD(object P_0)
	{
		return ((ConnectionInfo)P_0).ConnectionID;
	}

	internal static object BSGySRxmwZYf3Lv6jOwQ(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static int e74urOxm7tfRnNHsa02M(object P_0)
	{
		return ((TreeListViewColumn)P_0).Index;
	}

	internal static object iee7Yexm8kUI5C2b5LL2(object P_0)
	{
		return ((TreeListViewColumnEventArgs)P_0).Column;
	}

	internal static object DnceQ5xmAVWyWvakH9at(object P_0)
	{
		return ((PmWBAcasSZi1i4TPFqN8)P_0).tnFasFOPjU2();
	}

	internal static object DNaTI0xmPF13KlCho8Ff(object P_0)
	{
		return ((PmWBAcasSZi1i4TPFqN8)P_0).ChangePasswordCommand;
	}

	internal static object erAX1SxmJQ2m7liK5PZg(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object bMxqpbxmFdXmbwu5D02d(object P_0)
	{
		return ((FrameworkElement)P_0).DataContext;
	}

	internal static void hKGYp7xm3kMNm9Hf4sWo(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object AgFhA7xmp1b5SEo7ykrE(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void IsfNKcxmudVubMoQ6WUq(object P_0, object P_1)
	{
		((Control)P_0).MouseDoubleClick += (MouseButtonEventHandler)P_1;
	}
}
