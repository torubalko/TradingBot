using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bnYBBQ4RRnJxHbvk4Rm;
using ECOEgqlSad8NUJZ2Dr9n;
using euNCE9lsfjbYKw86YuS;
using GDESDRTZhCD0q4yhgPN;
using mBOuwh2x7WYCRTWvJexc;
using Microsoft.Win32;
using o8rG8jYJaX1AsbMm6sM;
using pBQZTE4DLtk18IAiFuJ;
using PgTFZmHaRDLPpi3M5aW9;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using vG0WidHawbhpKdkcelf8;
using xfdMo0lS4TP9pN36Goka;
using yH1aSw95cBMPqRpT6nEr;
using zTFYZBYMmy0JcBtIhoa;

namespace TigerTrade.UI.ToolControls.Orders;

internal sealed class OrdersControl : mMZmHD44odQv31rC92N, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class vbQFDDn4zoURrRdh13Cx
	{
		public static readonly vbQFDDn4zoURrRdh13Cx HkGnD2r94KW;

		public static Predicate<object> nrXnDHQxkfe;

		private static vbQFDDn4zoURrRdh13Cx X11LA5N0aWLMynIGdnGI;

		static vbQFDDn4zoURrRdh13Cx()
		{
			wyDsdSN04aftg63AafFg();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			HkGnD2r94KW = new vbQFDDn4zoURrRdh13Cx();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public vbQFDDn4zoURrRdh13Cx()
		{
			WK0rW5N0DCigf64ITmwc();
			base._002Ector();
		}

		internal bool CM5nD07PQyo(object o)
		{
			if (o is qvF510YP9saQf2tcISw qvF510YP9saQf2tcISw)
			{
				return qvF510YP9saQf2tcISw.IsVisible;
			}
			return false;
		}

		internal static void wyDsdSN04aftg63AafFg()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool bKXUWyN0iHklRLsD8oMd()
		{
			return X11LA5N0aWLMynIGdnGI == null;
		}

		internal static vbQFDDn4zoURrRdh13Cx kBpvAdN0lQHyll5aW54L()
		{
			return X11LA5N0aWLMynIGdnGI;
		}

		internal static void WK0rW5N0DCigf64ITmwc()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	[CompilerGenerated]
	private sealed class aO0KdjnDf1G1kcj6uRwS
	{
		public qvF510YP9saQf2tcISw lUYnDnPXsma;

		internal static aO0KdjnDf1G1kcj6uRwS W246oGN0beBsouD2otbx;

		public aO0KdjnDf1G1kcj6uRwS()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void zHinD9YL74h(object o, RoutedEventArgs args)
		{
			YGWAjeN05mOcfW1ZSbpJ(eVNs5ZN01xlv1xteoI8Z(lUYnDnPXsma));
		}

		static aO0KdjnDf1G1kcj6uRwS()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool dyD9KJN0NsiM12IiVSjS()
		{
			return W246oGN0beBsouD2otbx == null;
		}

		internal static aO0KdjnDf1G1kcj6uRwS Eajg9oN0kJE1gDf4uLrB()
		{
			return W246oGN0beBsouD2otbx;
		}

		internal static object eVNs5ZN01xlv1xteoI8Z(object P_0)
		{
			return ((qvF510YP9saQf2tcISw)P_0).Order;
		}

		internal static void YGWAjeN05mOcfW1ZSbpJ(object P_0)
		{
			bbMtLYY6D3fsv2ktRUA.jFaYIhdO4Q((Order)P_0);
		}
	}

	private readonly CollectionViewSource _viewSource;

	private readonly ContextMenu _itemContextMenu;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	internal static OrdersControl rNoQGDlwbUKredpI5oqU;

	public bbMtLYY6D3fsv2ktRUA ViewModel { get; }

	public OrdersControl()
	{
		MeKsnUlw1LC5RQonO25X();
		_itemContextMenu = new ContextMenu();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Orders);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				MenuItem menuItem = new MenuItem
				{
					Header = qJeUvSlwxo2eGSQfNm3f()
				};
				esdstnlwLYS2UXcIrMxN(menuItem, new RoutedEventHandler(OnItemContextMenuClick));
				((ItemCollection)l02DRtlwe70dd7ty49Nx(_itemContextMenu)).Add((object)menuItem);
				return;
			}
			case 1:
			{
				InitializeComponent();
				_viewSource = (CollectionViewSource)W2fkHOlw5S5bRYUctuwP(base.Resources, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D312E46));
				int num2 = 2;
				num = num2;
				continue;
			}
			case 2:
				((ICollectionView)kscmfilwSVARn8xEREj0(_viewSource)).Filter = (object o) => o is qvF510YP9saQf2tcISw qvF510YP9saQf2tcISw && qvF510YP9saQf2tcISw.IsVisible;
				num = 3;
				continue;
			}
			ViewModel = new bbMtLYY6D3fsv2ktRUA();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
			{
				num = 1;
			}
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		int num = 5;
		ContextMenu contextMenu = default(ContextMenu);
		MenuItem menuItem2 = default(MenuItem);
		aO0KdjnDf1G1kcj6uRwS aO0KdjnDf1G1kcj6uRwS = default(aO0KdjnDf1G1kcj6uRwS);
		MenuItem menuItem5 = default(MenuItem);
		DependencyObject dependencyObject = default(DependencyObject);
		object obj2 = default(object);
		MenuItem menuItem4 = default(MenuItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				MenuItem menuItem3;
				switch (num2)
				{
				case 9:
					((ItemCollection)l02DRtlwe70dd7ty49Nx(contextMenu)).Add((object)menuItem2);
					((ItemCollection)l02DRtlwe70dd7ty49Nx(contextMenu)).Add((object)new Separator());
					goto IL_01f0;
				case 6:
					esdstnlwLYS2UXcIrMxN(menuItem2, new RoutedEventHandler(aO0KdjnDf1G1kcj6uRwS.zHinD9YL74h));
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
				{
					MenuItem menuItem6 = new MenuItem();
					Qmkc8JlwcbkbtRFEUsKH(menuItem6, TigerTrade.Properties.Resources.WatchlistControlCopyTicker);
					menuItem5 = menuItem6;
					num2 = 11;
					continue;
				}
				case 11:
					menuItem5.Click += OnItemContextMenuClick;
					((ItemCollection)l02DRtlwe70dd7ty49Nx(contextMenu)).Add((object)menuItem5);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					goto end_IL_0012;
				case 2:
					bAl1SnlwjiyNEpgG6d3G(l02DRtlwe70dd7ty49Nx(contextMenu), new Separator());
					if (J0E7DplwQGhuEilhi9mm(PZ9TaAlwE7WGRcfeyhSV(aO0KdjnDf1G1kcj6uRwS.lUYnDnPXsma)))
					{
						MenuItem menuItem = new MenuItem();
						Qmkc8JlwcbkbtRFEUsKH(menuItem, TigerTrade.Properties.Resources.OrdersControlCancel);
						menuItem2 = menuItem;
						num2 = 6;
						continue;
					}
					goto IL_01f0;
				case 5:
					dependencyObject = (DependencyObject)e.OriginalSource;
					num2 = 4;
					continue;
				case 8:
					aO0KdjnDf1G1kcj6uRwS.lUYnDnPXsma = obj2 as qvF510YP9saQf2tcISw;
					if (aO0KdjnDf1G1kcj6uRwS.lUYnDnPXsma != null)
					{
						goto case 1;
					}
					goto IL_01f0;
				case 10:
					esdstnlwLYS2UXcIrMxN(menuItem4, (RoutedEventHandler)delegate
					{
						int num3 = 1;
						int num4 = num3;
						SaveFileDialog saveFileDialog = default(SaveFileDialog);
						bool? flag = default(bool?);
						while (true)
						{
							switch (num4)
							{
							case 1:
								saveFileDialog = new SaveFileDialog
								{
									Filter = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53786764)
								};
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
								{
									num4 = 0;
								}
								break;
							default:
								flag = saveFileDialog.ShowDialog();
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
								{
									num4 = 2;
								}
								break;
							case 2:
								if (flag == true)
								{
									DataGrid.e2OHiHb1IbE(saveFileDialog.FileName);
								}
								return;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				{
					aO0KdjnDf1G1kcj6uRwS = new aO0KdjnDf1G1kcj6uRwS();
					contextMenu = new ContextMenu();
					DataGridRow rowContainingElement = DataGridRow.GetRowContainingElement(dependencyObject as DataGridCell);
					if (rowContainingElement == null)
					{
						num2 = 12;
						continue;
					}
					obj = rowContainingElement.Item;
					break;
				}
				case 4:
					while (dependencyObject != null && !(dependencyObject is DataGridCell))
					{
						if (!(dependencyObject is DataGridColumnHeader))
						{
							dependencyObject = (DependencyObject)goUmcLlwsxIM8SCmaX61(dependencyObject);
							continue;
						}
						goto IL_00fa;
					}
					goto case 13;
				case 7:
					b0UvfblwdEX8n2ceO8G8(contextMenu, (RoutedEventHandler)delegate
					{
						DlqvAMlwg7y3NikjhUds(DataGrid, null);
					});
					DlqvAMlwg7y3NikjhUds(DataGrid, contextMenu);
					return;
				case 13:
					if (!(dependencyObject is DataGridColumnHeader))
					{
						if (dependencyObject != null)
						{
							num2 = 3;
							continue;
						}
					}
					else
					{
						PUA0qnlwXD70112SPXCB(DataGrid);
					}
					return;
				case 12:
					{
						obj = null;
						break;
					}
					IL_00fa:
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
					{
						num2 = 13;
					}
					continue;
					IL_01f0:
					menuItem3 = new MenuItem();
					Qmkc8JlwcbkbtRFEUsKH(menuItem3, TigerTrade.Properties.Resources.OrdersControlExport);
					menuItem4 = menuItem3;
					num2 = 10;
					continue;
				}
				obj2 = obj;
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			((ItemCollection)l02DRtlwe70dd7ty49Nx(contextMenu)).Add((object)menuItem4);
			num = 7;
		}
	}

	private void OnItemContextMenuClick(object sender, RoutedEventArgs e)
	{
		if (!(uvX4IElwRf2Yx4o74apv(DataGrid) is qvF510YP9saQf2tcISw qvF510YP9saQf2tcISw))
		{
			return;
		}
		while (true)
		{
			Clipboard.Clear();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				continue;
			}
			Clipboard.SetText(qvF510YP9saQf2tcISw.Symbol, TextDataFormat.UnicodeText);
			return;
		}
	}

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.to8HinyXyDi(b0Y45wEcGs(workspaceID));
		ViewModel.OnlyActiveOrders = mpoZ02lw6MC3gCuU36xi(settings);
		rN3Pg4lwMEBeuMNGIO3k(ViewModel, settings.OrderTypeIndex);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				eaEsFPlwq8uNWX27SYts(this, NxyXXIlwOgYfHs4a0Tim(settings));
				base.DocLinkContext.GroupId = SeIlfLmGQY2;
				base.DocLinkContext.LedBrush = MfLO4e2xwx7qp1Q89I0Y.kp22x8aRS0a(SeIlfLmGQY2);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Serialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.kUmHi9sIHwh(b0Y45wEcGs(workspaceID));
		wTrpNMlwIOwHmogDEuHn(settings, ViewModel.OnlyActiveOrders);
		vaomGGlwtm3wo1nNR2Q1(settings, moV1dhlwW1cSZbiky3in(ViewModel));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		settings.J4IlRV6a3j = SeIlfLmGQY2;
	}

	private void MenuButton_Click(object sender, RoutedEventArgs e)
	{
		string text = ((ButtonBase)sender).CommandParameter.ToString();
		if (!qPPyJ5lwUGivZ3eZR2NK(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999641762)))
		{
			int num;
			if (!(text == (string)DyCTJPlwTrPlu2E9DH33(-1774602229 ^ -1774609957)))
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 0;
				}
			}
			else
			{
				ViewModel.CancelAllOrders();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
		else
		{
			ViewModel.k50YWETkUd();
		}
	}

	private void DataGrid_OnSorting(object sender, DataGridSortingEventArgs e)
	{
		e.Handled = true;
		DataGridColumn column = e.Column;
		column.PdwHa6wgtGq();
		V5qiXflwycO1nXbZ8ZoT((ListCollectionView)_viewSource.View, new UZYK1oTyYk7YkolLH2D(column));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		O1I4NQwQCH(groupID);
	}

	private void DataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (wuHOSWlwZUxN8A5SB5U2(j18iDj9nukSCmEyZs5lH.Settings) == IknmHh95XIeQvfxb4I0a.uSr95jaMU03)
		{
			SetLinkSymbol();
		}
	}

	private void SetLinkSymbol()
	{
		Symbol symbol = ((qvF510YP9saQf2tcISw)borIwRlwVKUATupekS6A(ViewModel))?.Order.Symbol;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		GGi4kNPKJO(symbol);
	}

	private void DataGrid_OnPreviewLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		DataGridRow dataGridRow = default(DataGridRow);
		int num;
		if (sender is u0GAIHHahyHxCr1XJKud u0GAIHHahyHxCr1XJKud)
		{
			dataGridRow = u0GAIHHahyHxCr1XJKud.fEnHiGVTCDB(e);
			num = 3;
		}
		else
		{
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
			{
				num = 2;
			}
		}
		qvF510YP9saQf2tcISw qvF510YP9saQf2tcISw = default(qvF510YP9saQf2tcISw);
		DataObject dataObject = default(DataObject);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				return;
			case 2:
				return;
			case 3:
				if (dataGridRow == null)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
					{
						num = 0;
					}
					break;
				}
				if (e.ClickCount == 2 && wuHOSWlwZUxN8A5SB5U2(j18iDj9nukSCmEyZs5lH.Settings) == IknmHh95XIeQvfxb4I0a.V6U95Eue85N)
				{
					SetLinkSymbol();
					return;
				}
				qvF510YP9saQf2tcISw = dataGridRow.Item as qvF510YP9saQf2tcISw;
				if (qvF510YP9saQf2tcISw != null)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num = 0;
					}
					break;
				}
				return;
			case 1:
			{
				Symbol symbol = (Symbol)hDiwq0lwCQ1DAFpkZWNg(qvF510YP9saQf2tcISw.Order);
				if (symbol == null)
				{
					return;
				}
				dataObject = new DataObject(Type.GetTypeFromHandle(VZVOkjlwrFtu8XchtxMm(16777446)), symbol);
				num = 5;
				break;
			}
			case 0:
				return;
			case 5:
				dataObject.SetData(o62ex1lwKTAPxVP1Icln(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554595)), this);
				DragDrop.DoDragDrop(this, dataObject, DragDropEffects.Copy);
				num = 2;
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
			{
				Uri resourceLocator = new Uri((string)DyCTJPlwTrPlu2E9DH33(-1153206687 ^ -1153214585), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				break;
			}
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
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_contentLoaded = true;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				switch (connectionId)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					((Button)target).Click += MenuButton_Click;
					return;
				case 2:
					((Button)target).Click += MenuButton_Click;
					return;
				case 3:
					DataGrid = (u0GAIHHahyHxCr1XJKud)target;
					return;
				}
				break;
			case 2:
				return;
			}
		}
	}

	static OrdersControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void MeKsnUlw1LC5RQonO25X()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object W2fkHOlw5S5bRYUctuwP(object P_0, object P_1)
	{
		return ((ResourceDictionary)P_0)[P_1];
	}

	internal static object kscmfilwSVARn8xEREj0(object P_0)
	{
		return ((CollectionViewSource)P_0).View;
	}

	internal static object qJeUvSlwxo2eGSQfNm3f()
	{
		return TigerTrade.Properties.Resources.WatchlistControlCopyTicker;
	}

	internal static void esdstnlwLYS2UXcIrMxN(object P_0, object P_1)
	{
		((MenuItem)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static object l02DRtlwe70dd7ty49Nx(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static bool aLUAUrlwNRJeEXLZFxpW()
	{
		return rNoQGDlwbUKredpI5oqU == null;
	}

	internal static OrdersControl O8F2sNlwkVJrDhoPjsAe()
	{
		return rNoQGDlwbUKredpI5oqU;
	}

	internal static object goUmcLlwsxIM8SCmaX61(object P_0)
	{
		return VisualTreeHelper.GetParent((DependencyObject)P_0);
	}

	internal static void PUA0qnlwXD70112SPXCB(object P_0)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).rWAHi2QjAqn();
	}

	internal static void Qmkc8JlwcbkbtRFEUsKH(object P_0, object P_1)
	{
		((HeaderedItemsControl)P_0).Header = P_1;
	}

	internal static int bAl1SnlwjiyNEpgG6d3G(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static object PZ9TaAlwE7WGRcfeyhSV(object P_0)
	{
		return ((qvF510YP9saQf2tcISw)P_0).Order;
	}

	internal static bool J0E7DplwQGhuEilhi9mm(object P_0)
	{
		return bbMtLYY6D3fsv2ktRUA.OSCYqnsYW8((Order)P_0);
	}

	internal static void b0UvfblwdEX8n2ceO8G8(object P_0, object P_1)
	{
		((ContextMenu)P_0).Opened += (RoutedEventHandler)P_1;
	}

	internal static void DlqvAMlwg7y3NikjhUds(object P_0, object P_1)
	{
		((FrameworkElement)P_0).ContextMenu = (ContextMenu)P_1;
	}

	internal static object uvX4IElwRf2Yx4o74apv(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static bool mpoZ02lw6MC3gCuU36xi(object P_0)
	{
		return ((bBd5AkleWrv2LnDCh5X)P_0).OnlyActiveOrders;
	}

	internal static void rN3Pg4lwMEBeuMNGIO3k(object P_0, int P_1)
	{
		((bbMtLYY6D3fsv2ktRUA)P_0).OrderTypeIndex = P_1;
	}

	internal static int NxyXXIlwOgYfHs4a0Tim(object P_0)
	{
		return ((bBd5AkleWrv2LnDCh5X)P_0).J4IlRV6a3j;
	}

	internal static void eaEsFPlwq8uNWX27SYts(object P_0, int P_1)
	{
		((mMZmHD44odQv31rC92N)P_0).SeIlfLmGQY2 = P_1;
	}

	internal static void wTrpNMlwIOwHmogDEuHn(object P_0, bool P_1)
	{
		((bBd5AkleWrv2LnDCh5X)P_0).OnlyActiveOrders = P_1;
	}

	internal static int moV1dhlwW1cSZbiky3in(object P_0)
	{
		return ((bbMtLYY6D3fsv2ktRUA)P_0).OrderTypeIndex;
	}

	internal static void vaomGGlwtm3wo1nNR2Q1(object P_0, int P_1)
	{
		((bBd5AkleWrv2LnDCh5X)P_0).OrderTypeIndex = P_1;
	}

	internal static bool qPPyJ5lwUGivZ3eZR2NK(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object DyCTJPlwTrPlu2E9DH33(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void V5qiXflwycO1nXbZ8ZoT(object P_0, object P_1)
	{
		((ListCollectionView)P_0).CustomSort = (IComparer)P_1;
	}

	internal static IknmHh95XIeQvfxb4I0a wuHOSWlwZUxN8A5SB5U2(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TickerSwitchingMode;
	}

	internal static object borIwRlwVKUATupekS6A(object P_0)
	{
		return ((bbMtLYY6D3fsv2ktRUA)P_0).SelectedOrder;
	}

	internal static object hDiwq0lwCQ1DAFpkZWNg(object P_0)
	{
		return ((Order)P_0).Symbol;
	}

	internal static RuntimeTypeHandle VZVOkjlwrFtu8XchtxMm(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type o62ex1lwKTAPxVP1Icln(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
