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
using cvsMDenpthHB6chZmnm;
using ECOEgqlSad8NUJZ2Dr9n;
using euNCE9lsfjbYKw86YuS;
using lM9xconKIP2UunwAoZl;
using mBOuwh2x7WYCRTWvJexc;
using Microsoft.Win32;
using pBQZTE4DLtk18IAiFuJ;
using PgTFZmHaRDLPpi3M5aW9;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.UI.DocControls.Common.Link;
using TuAMtrl1Nd3XoZQQUXf0;
using vG0WidHawbhpKdkcelf8;
using xfdMo0lS4TP9pN36Goka;
using XjyHjhTrMPkTHc9HOFO;
using yH1aSw95cBMPqRpT6nEr;

namespace TigerTrade.UI.ToolControls.Executions;

internal sealed class ExecutionsControl : mMZmHD44odQv31rC92N, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class wvESu6n4masPmpOk6o07
	{
		public static readonly wvESu6n4masPmpOk6o07 RBKn4wR62sP;

		public static Predicate<object> Gvun47OMhNA;

		internal static wvESu6n4masPmpOk6o07 IjHrYYbzpqAwUlsrt54H;

		static wvESu6n4masPmpOk6o07()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			RBKn4wR62sP = new wvESu6n4masPmpOk6o07();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public wvESu6n4masPmpOk6o07()
		{
			BtDsWqN00UjfSg06iIOG();
			base._002Ector();
		}

		internal bool CXBn4hqfLrM(object o)
		{
			if (!(o is gSC5j6n3i4ckEaQII3r gSC5j6n3i4ckEaQII3r))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => false, 
				};
			}
			return an8TxKN02ZCQBUH8Tqw8(gSC5j6n3i4ckEaQII3r);
		}

		internal static bool LlRQCpbzun41INtdbmRl()
		{
			return IjHrYYbzpqAwUlsrt54H == null;
		}

		internal static wvESu6n4masPmpOk6o07 lc6ApJbzzSXH0aN3WBIO()
		{
			return IjHrYYbzpqAwUlsrt54H;
		}

		internal static void BtDsWqN00UjfSg06iIOG()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool an8TxKN02ZCQBUH8Tqw8(object P_0)
		{
			return ((gSC5j6n3i4ckEaQII3r)P_0).IsVisible;
		}
	}

	private CollectionViewSource viewSource;

	private readonly ContextMenu _itemContextMenu;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	internal static ExecutionsControl qT6T48lmIFykGUGh79vA;

	public SsSxcsnrdCDK7MkPasj ViewModel { get; }

	public ExecutionsControl()
	{
		oWs8nIlmUTYMePAiuo7H();
		_itemContextMenu = new ContextMenu();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Executions);
		ViewModel = new SsSxcsnrdCDK7MkPasj();
		int num = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				InitializeComponent();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
				{
					num = 0;
				}
				continue;
			case 2:
				return;
			case 1:
				viewSource = (CollectionViewSource)HuRwYWlmyjIXtOYAcXTJ(base.Resources, u7XGxTlmTW8V424FPaxt(0x20B584D2 ^ 0x20B59ADC));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num = 0;
				}
				continue;
			}
			viewSource.View.Filter = delegate(object o)
			{
				if (!(o is gSC5j6n3i4ckEaQII3r gSC5j6n3i4ckEaQII3r))
				{
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num2 = 0;
					}
					return num2 switch
					{
						_ => false, 
					};
				}
				return wvESu6n4masPmpOk6o07.an8TxKN02ZCQBUH8Tqw8(gSC5j6n3i4ckEaQII3r);
			};
			MenuItem menuItem = new MenuItem
			{
				Header = V9jKXUlmZhiI1qIjFusJ()
			};
			menuItem.Click += OnItemContextMenuClick;
			_itemContextMenu.Items.Add(menuItem);
			num = 2;
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		DependencyObject dependencyObject = (DependencyObject)e.OriginalSource;
		ContextMenu contextMenu = default(ContextMenu);
		MenuItem menuItem2 = default(MenuItem);
		MenuItem menuItem = default(MenuItem);
		while (true)
		{
			int num;
			if (dependencyObject != null)
			{
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 7;
				}
				goto IL_0009;
			}
			goto IL_00c6;
			IL_01a2:
			contextMenu = new ContextMenu();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
			{
				num = 6;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 3:
					contextMenu.Items.Add(menuItem2);
					peF29KlmVN6Om83VS40y(contextMenu.Items, new Separator());
					menuItem = new MenuItem
					{
						Header = kJIAJjlmCDk5M5Wxg3DJ()
					};
					menuItem.Click += delegate
					{
						int num2 = 1;
						int num3 = num2;
						SaveFileDialog saveFileDialog = default(SaveFileDialog);
						bool? flag = default(bool?);
						bool flag2 = default(bool);
						while (true)
						{
							switch (num3)
							{
							case 1:
								saveFileDialog = new SaveFileDialog
								{
									Filter = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82855928)
								};
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
								{
									num3 = 0;
								}
								break;
							default:
								flag = saveFileDialog.ShowDialog();
								flag2 = true;
								num3 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
								{
									num3 = 0;
								}
								break;
							case 2:
								if (flag == flag2)
								{
									qrlBNOlmuJH32svhdrdi(DataGrid, saveFileDialog.FileName);
								}
								return;
							}
						}
					};
					((ItemCollection)VKaRiRlmr7XhQvGxsmLp(contextMenu)).Add((object)new Separator());
					num = 5;
					continue;
				case 2:
					break;
				case 7:
					if (!(dependencyObject is DataGridCell))
					{
						num = 2;
						continue;
					}
					goto IL_00c6;
				case 1:
					goto IL_00c6;
				case 6:
					contextMenu.Items.Add(new Separator());
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
					{
						num = 0;
					}
					continue;
				case 8:
					menuItem2.Click += OnItemContextMenuClick;
					num = 3;
					continue;
				case 9:
					DataGrid.rWAHi2QjAqn();
					return;
				case 4:
					goto IL_01a2;
				default:
					menuItem2 = new MenuItem
					{
						Header = V9jKXUlmZhiI1qIjFusJ()
					};
					num = 8;
					continue;
				case 5:
					peF29KlmVN6Om83VS40y(contextMenu.Items, menuItem);
					contextMenu.Opened += delegate
					{
						DataGrid.ContextMenu = null;
					};
					RwscVmlmKs8IRB9x205l(DataGrid, contextMenu);
					return;
				}
				break;
			}
			if (!(dependencyObject is DataGridColumnHeader))
			{
				dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
				continue;
			}
			goto IL_00c6;
			IL_00c6:
			if (dependencyObject is DataGridColumnHeader)
			{
				num = 9;
				goto IL_0009;
			}
			if (dependencyObject == null)
			{
				break;
			}
			goto IL_01a2;
		}
	}

	private void OnItemContextMenuClick(object sender, RoutedEventArgs e)
	{
		if (!(DataGrid.SelectedItem is gSC5j6n3i4ckEaQII3r gSC5j6n3i4ckEaQII3r))
		{
			return;
		}
		while (true)
		{
			jVLpbJlmm20mAyLBiTfB();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				continue;
			}
			Clipboard.SetText(gSC5j6n3i4ckEaQII3r.Symbol, TextDataFormat.UnicodeText);
			return;
		}
	}

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				DataGrid.to8HinyXyDi(b0Y45wEcGs(workspaceID));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				v5y2PdlmwoktYqPiBZsX(this, B3rYVvlmhO0upYe3D80B(settings));
				ISWsSplm7w8fcCDZHScQ(base.DocLinkContext, SeIlfLmGQY2);
				base.DocLinkContext.LedBrush = MfLO4e2xwx7qp1Q89I0Y.kp22x8aRS0a(SeIlfLmGQY2);
				return;
			}
		}
	}

	public override void Serialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.kUmHi9sIHwh(b0Y45wEcGs(workspaceID));
		settings.FJqlOCnixF = SeIlfLmGQY2;
	}

	private void DataGrid_OnSorting(object sender, DataGridSortingEventArgs e)
	{
		e.Handled = true;
		DataGridColumn dataGridColumn = (DataGridColumn)y4Gp86lm8oaIUnQ6EGZj(e);
		dataGridColumn.PdwHa6wgtGq();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		MMw2rMlmA38Q2tfA2Np0((ListCollectionView)viewSource.View, new z57CJATCGcw5B9BVbOK(dataGridColumn));
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		O1I4NQwQCH(groupID);
	}

	private void DataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (((MhMDPU9v8rkigy1ao0Th)yF7RG0lmP4higQ33DE5Z()).TickerSwitchingMode == IknmHh95XIeQvfxb4I0a.uSr95jaMU03)
		{
			GGi4kNPKJO(ViewModel.SelectedExecution?.Execution.Symbol);
		}
	}

	private void DataGrid_OnPreviewLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		if (!(sender is u0GAIHHahyHxCr1XJKud u0GAIHHahyHxCr1XJKud))
		{
			return;
		}
		DataGridRow dataGridRow = u0GAIHHahyHxCr1XJKud.fEnHiGVTCDB(e);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
		{
			num = 1;
		}
		gSC5j6n3i4ckEaQII3r gSC5j6n3i4ckEaQII3r = default(gSC5j6n3i4ckEaQII3r);
		DataObject dataObject = default(DataObject);
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num)
			{
			default:
				if (gSC5j6n3i4ckEaQII3r != null)
				{
					num = 2;
					break;
				}
				return;
			case 3:
				dataObject = new DataObject(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777446)), symbol);
				num = 5;
				break;
			case 2:
				symbol = gSC5j6n3i4ckEaQII3r.Execution.Symbol;
				if (symbol != null)
				{
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num = 3;
					}
					break;
				}
				return;
			case 1:
				if (dataGridRow == null)
				{
					return;
				}
				if (P0p5FBlmJJ4BGeYWkj1F(e) == 2)
				{
					num = 4;
					break;
				}
				goto IL_00c7;
			case 4:
				if (j18iDj9nukSCmEyZs5lH.Settings.TickerSwitchingMode == IknmHh95XIeQvfxb4I0a.V6U95Eue85N)
				{
					object obj = BKLfOdlmFEeAV9iBRXDg(ViewModel);
					GGi4kNPKJO((Symbol)((obj != null) ? iWaegulm3l7Z5fM3vXWN(((gSC5j6n3i4ckEaQII3r)obj).Execution) : null));
					return;
				}
				goto IL_00c7;
			case 5:
				{
					dataObject.SetData(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554595)), this);
					wem8G3lmpUYsgm4A3dCV(this, dataObject, DragDropEffects.Copy);
					return;
				}
				IL_00c7:
				gSC5j6n3i4ckEaQII3r = dataGridRow.Item as gSC5j6n3i4ckEaQII3r;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
				{
					num = 0;
				}
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
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799504991), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			DataGrid = (u0GAIHHahyHxCr1XJKud)target;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
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
			_contentLoaded = true;
		}
	}

	static ExecutionsControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void oWs8nIlmUTYMePAiuo7H()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object u7XGxTlmTW8V424FPaxt(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object HuRwYWlmyjIXtOYAcXTJ(object P_0, object P_1)
	{
		return ((ResourceDictionary)P_0)[P_1];
	}

	internal static object V9jKXUlmZhiI1qIjFusJ()
	{
		return TigerTrade.Properties.Resources.WatchlistControlCopyTicker;
	}

	internal static bool c3eGuXlmWUGEyGGmccMA()
	{
		return qT6T48lmIFykGUGh79vA == null;
	}

	internal static ExecutionsControl E6Ttb4lmtc8l1lvtFjJq()
	{
		return qT6T48lmIFykGUGh79vA;
	}

	internal static int peF29KlmVN6Om83VS40y(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static object kJIAJjlmCDk5M5Wxg3DJ()
	{
		return TigerTrade.Properties.Resources.ExecutionsControlExport;
	}

	internal static object VKaRiRlmr7XhQvGxsmLp(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static void RwscVmlmKs8IRB9x205l(object P_0, object P_1)
	{
		((FrameworkElement)P_0).ContextMenu = (ContextMenu)P_1;
	}

	internal static void jVLpbJlmm20mAyLBiTfB()
	{
		Clipboard.Clear();
	}

	internal static int B3rYVvlmhO0upYe3D80B(object P_0)
	{
		return ((bBd5AkleWrv2LnDCh5X)P_0).FJqlOCnixF;
	}

	internal static void v5y2PdlmwoktYqPiBZsX(object P_0, int P_1)
	{
		((mMZmHD44odQv31rC92N)P_0).SeIlfLmGQY2 = P_1;
	}

	internal static void ISWsSplm7w8fcCDZHScQ(object P_0, int P_1)
	{
		((DocLinkContext)P_0).GroupId = P_1;
	}

	internal static object y4Gp86lm8oaIUnQ6EGZj(object P_0)
	{
		return ((DataGridColumnEventArgs)P_0).Column;
	}

	internal static void MMw2rMlmA38Q2tfA2Np0(object P_0, object P_1)
	{
		((ListCollectionView)P_0).CustomSort = (IComparer)P_1;
	}

	internal static object yF7RG0lmP4higQ33DE5Z()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static int P0p5FBlmJJ4BGeYWkj1F(object P_0)
	{
		return ((MouseButtonEventArgs)P_0).ClickCount;
	}

	internal static object BKLfOdlmFEeAV9iBRXDg(object P_0)
	{
		return ((SsSxcsnrdCDK7MkPasj)P_0).SelectedExecution;
	}

	internal static object iWaegulm3l7Z5fM3vXWN(object P_0)
	{
		return ((Execution)P_0).Symbol;
	}

	internal static DragDropEffects wem8G3lmpUYsgm4A3dCV(object P_0, object P_1, DragDropEffects P_2)
	{
		return DragDrop.DoDragDrop((DependencyObject)P_0, P_1, P_2);
	}

	internal static void qrlBNOlmuJH32svhdrdi(object P_0, object P_1)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).e2OHiHb1IbE((string)P_1);
	}
}
