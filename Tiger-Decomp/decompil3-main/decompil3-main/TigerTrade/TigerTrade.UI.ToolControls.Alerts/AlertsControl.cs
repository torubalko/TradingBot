using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bnYBBQ4RRnJxHbvk4Rm;
using ECOEgqlSad8NUJZ2Dr9n;
using euNCE9lsfjbYKw86YuS;
using Ki5UMm4zgRG9YQRpEjE;
using mBOuwh2x7WYCRTWvJexc;
using pBQZTE4DLtk18IAiFuJ;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.DocControls.Common.Link;
using TuAMtrl1Nd3XoZQQUXf0;
using vG0WidHawbhpKdkcelf8;
using w1lE3p4MSVZb7S0mVrv;
using xfdMo0lS4TP9pN36Goka;
using yH1aSw95cBMPqRpT6nEr;

namespace TigerTrade.UI.ToolControls.Alerts;

internal sealed class AlertsControl : mMZmHD44odQv31rC92N, IComponentConnector
{
	internal PopupButton PopupButtonSymbols;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	internal static AlertsControl cFMJLmlFlMmgVEMXE0Uf;

	public uPJaqK46ZA7lVpRfCuO ViewModel { get; }

	public AlertsControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Alerts);
		ViewModel = new uPJaqK46ZA7lVpRfCuO();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.to8HinyXyDi(b0Y45wEcGs(workspaceID));
		ViewModel.SourceChart = settings.pAolhUo5ik;
		ViewModel.SourceDom = settings.poBl8lFG4A;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Ie4GKLlFkjBpqY6AjJhe(base.DocLinkContext, MfLO4e2xwx7qp1Q89I0Y.kp22x8aRS0a(SeIlfLmGQY2));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				return;
			}
			ViewModel.SourceTape = settings.T50lJ6CNit;
			ViewModel.SourceServerAlerts = settings.d4Ylp55ri8;
			SeIlfLmGQY2 = CxeaEklFbqcOqGFdI04t(settings);
			ULOWMOlFNrTIgHv1jdsA(base.DocLinkContext, SeIlfLmGQY2);
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num = 2;
			}
		}
	}

	public override void Serialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.kUmHi9sIHwh(b0Y45wEcGs(workspaceID));
		M7AOZ2lF5Drvlw0sHq4i(settings, kX14kglF1eAjusw6ukit(ViewModel));
		settings.poBl8lFG4A = ViewModel.SourceDom;
		pNj4SIlFxcJt16SO0NT3(settings, J5m7R3lFSJQR57IkFyWr(ViewModel));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				zJe1jflFsrAkMFRjj5NE(settings, p3BQ1ZlFelng1UHT2DOI(this));
				return;
			}
			lnd5sflFL3IjZaiFdO6K(settings, ViewModel.SourceServerAlerts);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
			{
				num = 1;
			}
		}
	}

	private void MenuButton_Click(object sender, RoutedEventArgs e)
	{
		if (tOh8kRlFjsvW9eLwaFQx(McsRlflFXAWq9MaVDE32((ButtonBase)sender).ToString(), tqXcy0lFcD4CrPmy6dqa(-2063361985 ^ -2063354445)))
		{
			ViewModel.Clear();
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		int num = 3;
		int num2 = num;
		DependencyObject dependencyObject = default(DependencyObject);
		MenuItem menuItem = default(MenuItem);
		ContextMenu contextMenu = default(ContextMenu);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 1:
			case 8:
				dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
				goto case 2;
			case 5:
				DCWlp7lFdpJ3S0Q89v5X(menuItem, (RoutedEventHandler)delegate
				{
					if (DataGrid.SelectedItem is RM5s4c4uga18xZ0DLZF rM5s4c4uga18xZ0DLZF)
					{
						int num3;
						if (!a5cFyblFUpfYlNGYtmfN(y3FcQMlFtsRhcLOm721n(rM5s4c4uga18xZ0DLZF)))
						{
							Clipboard.SetText(rM5s4c4uga18xZ0DLZF.Symbol);
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
							{
								num3 = 1;
							}
						}
						switch (num3)
						{
						case 0:
							break;
						case 1:
							break;
						}
					}
				});
				contextMenu.Items.Add(menuItem);
				jRZgR6lFgR2BkVLyDrCU(contextMenu, (RoutedEventHandler)delegate
				{
					DataGrid.ContextMenu = null;
				});
				DataGrid.ContextMenu = contextMenu;
				return;
			default:
				CqoE7FlFEAFeNaNrd2uU(DataGrid);
				return;
			case 4:
				if (!(dependencyObject is DataGridCell))
				{
					if (!(dependencyObject is DataGridColumnHeader))
					{
						num2 = 8;
						break;
					}
					goto case 6;
				}
				num2 = 6;
				break;
			case 3:
				dependencyObject = (DependencyObject)e.OriginalSource;
				num2 = 2;
				break;
			case 6:
				if (!(dependencyObject is DataGridColumnHeader))
				{
					if (dependencyObject == null)
					{
						return;
					}
					if (dvoZtwlFQhjuNNmQ2I2j(DataGrid) is RM5s4c4uga18xZ0DLZF)
					{
						contextMenu = new ContextMenu();
						menuItem = new MenuItem
						{
							Header = TigerTrade.Properties.Resources.WatchlistControlCopyTicker
						};
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
						{
							num2 = 5;
						}
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				if (dependencyObject != null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		O1I4NQwQCH(groupID);
	}

	private void OnSetLinkSymbol(string symbolId)
	{
		int num = 1;
		int num2 = num;
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num2)
			{
			default:
				if (symbol != null)
				{
					GGi4kNPKJO(symbol);
				}
				return;
			case 1:
				symbol = SymbolManager.Get(symbolId);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void DataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (((MhMDPU9v8rkigy1ao0Th)pC4ypVlFR4Tj4RkLhmr1()).TickerSwitchingMode == IknmHh95XIeQvfxb4I0a.uSr95jaMU03)
		{
			SetLinkSymbol();
		}
	}

	private void SetLinkSymbol()
	{
		Symbol symbol = (Symbol)mmf7pplFMErIpUMeiLqf(((RM5s4c4uga18xZ0DLZF)a8f43JlF6WhuhMJi1rts(ViewModel))?.Alert?.qgLfG0d5L0c());
		GGi4kNPKJO(symbol);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void DataGrid_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		int num = 6;
		u0GAIHHahyHxCr1XJKud u0GAIHHahyHxCr1XJKud = default(u0GAIHHahyHxCr1XJKud);
		DataGridRow dataGridRow = default(DataGridRow);
		DataObject dataObject = default(DataObject);
		Symbol symbol = default(Symbol);
		RM5s4c4uga18xZ0DLZF rM5s4c4uga18xZ0DLZF = default(RM5s4c4uga18xZ0DLZF);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					if (u0GAIHHahyHxCr1XJKud == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					dataGridRow = u0GAIHHahyHxCr1XJKud.fEnHiGVTCDB(e);
					if (dataGridRow != null)
					{
						if (e.ClickCount == 2)
						{
							num2 = 7;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto IL_0111;
					}
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					dataObject = new DataObject(sq7JbVlFq1iYeoW6UFvu(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777446)), symbol);
					dataObject.SetData(Type.GetTypeFromHandle(YWHr6TlFIwJPq0Xrad1n(33554595)), this);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					DragDrop.DoDragDrop(this, dataObject, DragDropEffects.Copy);
					return;
				case 6:
					u0GAIHHahyHxCr1XJKud = sender as u0GAIHHahyHxCr1XJKud;
					num2 = 5;
					continue;
				case 2:
					return;
				case 3:
					obj = null;
					goto IL_01db;
				case 1:
					return;
				case 4:
					if (rM5s4c4uga18xZ0DLZF == null)
					{
						goto case 3;
					}
					obj = rM5s4c4uga18xZ0DLZF.Alert?.qgLfG0d5L0c();
					goto IL_01db;
				case 7:
					{
						if (vGE7QklFOmvljkbKlkds(j18iDj9nukSCmEyZs5lH.Settings) == IknmHh95XIeQvfxb4I0a.V6U95Eue85N)
						{
							SetLinkSymbol();
							return;
						}
						goto IL_0111;
					}
					IL_0111:
					rM5s4c4uga18xZ0DLZF = dataGridRow.Item as RM5s4c4uga18xZ0DLZF;
					if (rM5s4c4uga18xZ0DLZF == null)
					{
						return;
					}
					num = 4;
					break;
					IL_01db:
					symbol = (Symbol)mmf7pplFMErIpUMeiLqf(obj);
					if (symbol == null)
					{
						return;
					}
					num = 8;
					break;
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
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri((string)tqXcy0lFcD4CrPmy6dqa(-176525661 ^ -176536775), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)ucTo8WlFWMODBeS9qtZw(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (connectionId)
				{
				case 2:
					((Button)target).Click += MenuButton_Click;
					return;
				case 3:
					DataGrid = (u0GAIHHahyHxCr1XJKud)target;
					return;
				default:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				break;
			default:
				_contentLoaded = true;
				return;
			case 2:
				break;
			}
			break;
		}
		PopupButtonSymbols = (PopupButton)target;
	}

	static AlertsControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool PtWruOlF4OqYv3OHYOMv()
	{
		return cFMJLmlFlMmgVEMXE0Uf == null;
	}

	internal static AlertsControl snCvNvlFDRMY5K9NYUvK()
	{
		return cFMJLmlFlMmgVEMXE0Uf;
	}

	internal static int CxeaEklFbqcOqGFdI04t(object P_0)
	{
		return ((bBd5AkleWrv2LnDCh5X)P_0).p1o40aWw5a;
	}

	internal static void ULOWMOlFNrTIgHv1jdsA(object P_0, int P_1)
	{
		((DocLinkContext)P_0).GroupId = P_1;
	}

	internal static void Ie4GKLlFkjBpqY6AjJhe(object P_0, object P_1)
	{
		((DocLinkContext)P_0).LedBrush = (Brush)P_1;
	}

	internal static bool kX14kglF1eAjusw6ukit(object P_0)
	{
		return ((uPJaqK46ZA7lVpRfCuO)P_0).SourceChart;
	}

	internal static void M7AOZ2lF5Drvlw0sHq4i(object P_0, bool P_1)
	{
		((bBd5AkleWrv2LnDCh5X)P_0).pAolhUo5ik = P_1;
	}

	internal static bool J5m7R3lFSJQR57IkFyWr(object P_0)
	{
		return ((uPJaqK46ZA7lVpRfCuO)P_0).SourceTape;
	}

	internal static void pNj4SIlFxcJt16SO0NT3(object P_0, bool P_1)
	{
		((bBd5AkleWrv2LnDCh5X)P_0).T50lJ6CNit = P_1;
	}

	internal static void lnd5sflFL3IjZaiFdO6K(object P_0, bool P_1)
	{
		((bBd5AkleWrv2LnDCh5X)P_0).d4Ylp55ri8 = P_1;
	}

	internal static int p3BQ1ZlFelng1UHT2DOI(object P_0)
	{
		return ((mMZmHD44odQv31rC92N)P_0).SeIlfLmGQY2;
	}

	internal static void zJe1jflFsrAkMFRjj5NE(object P_0, int P_1)
	{
		((bBd5AkleWrv2LnDCh5X)P_0).p1o40aWw5a = P_1;
	}

	internal static object McsRlflFXAWq9MaVDE32(object P_0)
	{
		return ((ButtonBase)P_0).CommandParameter;
	}

	internal static object tqXcy0lFcD4CrPmy6dqa(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool tOh8kRlFjsvW9eLwaFQx(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void CqoE7FlFEAFeNaNrd2uU(object P_0)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).rWAHi2QjAqn();
	}

	internal static object dvoZtwlFQhjuNNmQ2I2j(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static void DCWlp7lFdpJ3S0Q89v5X(object P_0, object P_1)
	{
		((MenuItem)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void jRZgR6lFgR2BkVLyDrCU(object P_0, object P_1)
	{
		((ContextMenu)P_0).Opened += (RoutedEventHandler)P_1;
	}

	internal static object pC4ypVlFR4Tj4RkLhmr1()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object a8f43JlF6WhuhMJi1rts(object P_0)
	{
		return ((uPJaqK46ZA7lVpRfCuO)P_0).SelectedAlert;
	}

	internal static object mmf7pplFMErIpUMeiLqf(object P_0)
	{
		return SymbolManager.Get((string)P_0);
	}

	internal static IknmHh95XIeQvfxb4I0a vGE7QklFOmvljkbKlkds(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TickerSwitchingMode;
	}

	internal static Type sq7JbVlFq1iYeoW6UFvu(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle YWHr6TlFIwJPq0Xrad1n(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object ucTo8WlFWMODBeS9qtZw(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static object y3FcQMlFtsRhcLOm721n(object P_0)
	{
		return ((RM5s4c4uga18xZ0DLZF)P_0).Symbol;
	}

	internal static bool a5cFyblFUpfYlNGYtmfN(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
