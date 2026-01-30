using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using bnYBBQ4RRnJxHbvk4Rm;
using ECOEgqlSad8NUJZ2Dr9n;
using ESxd7loP1YOLcDZsCHL;
using euNCE9lsfjbYKw86YuS;
using LDVtQNv6lovJSSK7M7I;
using LpWHqpHFxDr7bif08Fn4;
using pBQZTE4DLtk18IAiFuJ;
using pduUFuHP7jFN8rkxyl0l;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using UfilkavH3oZDuNlIYbg;
using vG0WidHawbhpKdkcelf8;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.ToolControls.Limits;

internal sealed class LimitsControl : mMZmHD44odQv31rC92N, IComponentConnector
{
	[CompilerGenerated]
	private static Action m_Update;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	internal static LimitsControl xQPFHWl71oyIYEBu4k8S;

	public egRkWboAXfgpDYEiUFC ViewModel { get; }

	public static event Action Update
	{
		[CompilerGenerated]
		add
		{
			Action action = LimitsControl.m_Update;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
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
						break;
					}
					action = Interlocked.CompareExchange(ref LimitsControl.m_Update, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			Action action = LimitsControl.m_Update;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						action = Interlocked.CompareExchange(ref LimitsControl.m_Update, value2, action2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
			}
			while ((object)action != action2);
		}
	}

	public LimitsControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Limits);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ViewModel = new egRkWboAXfgpDYEiUFC();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num = 0;
				}
				break;
			default:
				InitializeComponent();
				Update += delegate
				{
					XH4GsUl7qycbIO9nfsHe(ViewModel);
				};
				return;
			}
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		DependencyObject dependencyObject = (DependencyObject)e.OriginalSource;
		ContextMenu contextMenu = default(ContextMenu);
		MenuItem menuItem2 = default(MenuItem);
		while (true)
		{
			int num;
			if (dependencyObject != null && !(dependencyObject is DataGridCell) && !(dependencyObject is DataGridColumnHeader))
			{
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num = 5;
				}
				goto IL_0009;
			}
			goto IL_0196;
			IL_0196:
			if (!(dependencyObject is DataGridColumnHeader))
			{
				if (dependencyObject == null || !(DataGrid.SelectedItem is OMdL5pv2glbNcP3XDCe))
				{
					break;
				}
				contextMenu = new ContextMenu();
				MenuItem menuItem = new MenuItem();
				KieZJLl7e8UtUaYD8WEB(menuItem, vUg6Jul7LIYPYx4c7YW8());
				menuItem2 = menuItem;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 0;
				}
			}
			else
			{
				qdUcIOl7xk8gLIYpVBOA(DataGrid);
				int num2 = 7;
				num = num2;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 3:
					contextMenu.Opened += delegate
					{
						VL0098l7ton7mWYAWUe2(DataGrid, null);
					};
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
					{
						num = 2;
					}
					continue;
				case 7:
					return;
				case 5:
					DataGrid.ContextMenu = contextMenu;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
					{
						num = 1;
					}
					continue;
				case 1:
					menuItem2.Click += delegate
					{
						int num3 = 1;
						int num4 = num3;
						OMdL5pv2glbNcP3XDCe oMdL5pv2glbNcP3XDCe = default(OMdL5pv2glbNcP3XDCe);
						while (true)
						{
							switch (num4)
							{
							default:
								if (oMdL5pv2glbNcP3XDCe != null && !RwpUPtl7W7DiqjadjvOC(FNDlsbl7ItlvshommpkH(oMdL5pv2glbNcP3XDCe)))
								{
									Clipboard.SetText((string)FNDlsbl7ItlvshommpkH(oMdL5pv2glbNcP3XDCe));
								}
								return;
							case 1:
								oMdL5pv2glbNcP3XDCe = DataGrid.SelectedItem as OMdL5pv2glbNcP3XDCe;
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					};
					contextMenu.Items.Add(menuItem2);
					num = 3;
					continue;
				case 4:
				case 6:
					goto end_IL_0009;
				case 2:
					return;
				}
				goto IL_0196;
				continue;
				end_IL_0009:
				break;
			}
			dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
		}
	}

	private static void ShowEditor(Window owner)
	{
		int num = 3;
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
			{
				Action update = LimitsControl.Update;
				if (update == null)
				{
					return;
				}
				update();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 3:
				if (!string.IsNullOrEmpty(zyW7WyHPwnJEtIOWC1Wm.Settings.Password))
				{
					num2 = 2;
					continue;
				}
				break;
			case 2:
			{
				if (InputWindow.ShowWindow(owner, (string)uTqwsql7sFO4Y6gy2uhM(), TigerTrade.Properties.Resources.LimitsControlEnterPassword, out var value))
				{
					if (value != ((Jm1YX8HFSEpmh6QJJmd6)TO1axjl7XOqHkdqCNFpp()).Password)
					{
						MessageWindow.ShowWindow(owner, TigerTrade.Properties.Resources.LimitsEditorWindowTitle, TigerTrade.Properties.Resources.LimitsControlInvalidPassword);
						return;
					}
					break;
				}
				return;
			}
			}
			u333b2l7c6edHVuRiguW(owner);
			zyW7WyHPwnJEtIOWC1Wm.RhTHP8lZLVy();
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
			{
				num2 = 1;
			}
		}
	}

	private static void SetPassword(Window owner)
	{
		if (InputWindow.ShowWindow(owner, TigerTrade.Properties.Resources.LimitsEditorWindowTitle, (string)VcH3Wsl7jpfQBeCnX787(), out var value))
		{
			zyW7WyHPwnJEtIOWC1Wm.Settings.Password = value;
		}
	}

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		FcSVepl7EF2Ld55lpgJc(DataGrid, b0Y45wEcGs(workspaceID));
	}

	public override void Serialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.kUmHi9sIHwh(b0Y45wEcGs(workspaceID));
	}

	private void MenuButton_Click(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				text = ((ButtonBase)sender).CommandParameter.ToString();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7C95E))
			{
				QLldd5l7QpyrC2Ay212U(base.ParentWindow);
				return;
			}
			if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371623215))
			{
				XOqaV3l7ds1Bx8RPIJvv(base.ParentWindow);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return;
		}
	}

	private void DataGrid_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		int num = 3;
		int num2 = num;
		DataObject dataObject = default(DataObject);
		Symbol symbol = default(Symbol);
		u0GAIHHahyHxCr1XJKud u0GAIHHahyHxCr1XJKud = default(u0GAIHHahyHxCr1XJKud);
		while (true)
		{
			switch (num2)
			{
			case 1:
				uuG9aUl7M4Gl0LpEiMuM(dataObject, YHLhAYl76K7Y7K7RnqKK(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554595)), this);
				DragDrop.DoDragDrop(this, dataObject, DragDropEffects.Copy);
				return;
			case 4:
				return;
			default:
				dataObject = new DataObject(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777446)), symbol);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			{
				if (u0GAIHHahyHxCr1XJKud == null)
				{
					return;
				}
				DataGridRow dataGridRow = u0GAIHHahyHxCr1XJKud.fEnHiGVTCDB(e);
				if (dataGridRow != null)
				{
					if (!(P4gn0dl7gcVNuvk6owDu(dataGridRow) is OMdL5pv2glbNcP3XDCe oMdL5pv2glbNcP3XDCe))
					{
						return;
					}
					symbol = (Symbol)AGioS4l7RusXMUuDmY3i(oMdL5pv2glbNcP3XDCe);
					if (symbol == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			}
			case 3:
				u0GAIHHahyHxCr1XJKud = sender as u0GAIHHahyHxCr1XJKud;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
				{
					num2 = 2;
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
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801460630), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
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
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (connectionId != 1)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num2 = 0;
					}
					break;
				}
				tTaYMil7OE7Ne2i2MYrn((Button)target, new RoutedEventHandler(MenuButton_Click));
				return;
			case 1:
				if (connectionId != 2)
				{
					_contentLoaded = true;
					return;
				}
				DataGrid = (u0GAIHHahyHxCr1XJKud)target;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static LimitsControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool mbm761l75LqilHctQYCd()
	{
		return xQPFHWl71oyIYEBu4k8S == null;
	}

	internal static LimitsControl DXWSJAl7SsPY5cVUfBR2()
	{
		return xQPFHWl71oyIYEBu4k8S;
	}

	internal static void qdUcIOl7xk8gLIYpVBOA(object P_0)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).rWAHi2QjAqn();
	}

	internal static object vUg6Jul7LIYPYx4c7YW8()
	{
		return TigerTrade.Properties.Resources.WatchlistControlCopyTicker;
	}

	internal static void KieZJLl7e8UtUaYD8WEB(object P_0, object P_1)
	{
		((HeaderedItemsControl)P_0).Header = P_1;
	}

	internal static object uTqwsql7sFO4Y6gy2uhM()
	{
		return TigerTrade.Properties.Resources.LimitsEditorWindowTitle;
	}

	internal static object TO1axjl7XOqHkdqCNFpp()
	{
		return zyW7WyHPwnJEtIOWC1Wm.Settings;
	}

	internal static void u333b2l7c6edHVuRiguW(object P_0)
	{
		CUEEO5vRS5R4PQNymNG.M5Svhl98nr((Window)P_0);
	}

	internal static object VcH3Wsl7jpfQBeCnX787()
	{
		return TigerTrade.Properties.Resources.LimitsEditorWindowSetPasswordForSettings;
	}

	internal static void FcSVepl7EF2Ld55lpgJc(object P_0, object P_1)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).to8HinyXyDi((string)P_1);
	}

	internal static void QLldd5l7QpyrC2Ay212U(object P_0)
	{
		ShowEditor((Window)P_0);
	}

	internal static void XOqaV3l7ds1Bx8RPIJvv(object P_0)
	{
		SetPassword((Window)P_0);
	}

	internal static object P4gn0dl7gcVNuvk6owDu(object P_0)
	{
		return ((DataGridRow)P_0).Item;
	}

	internal static object AGioS4l7RusXMUuDmY3i(object P_0)
	{
		return ((OMdL5pv2glbNcP3XDCe)P_0).SymbolInstance;
	}

	internal static Type YHLhAYl76K7Y7K7RnqKK(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void uuG9aUl7M4Gl0LpEiMuM(object P_0, Type P_1, object P_2)
	{
		((DataObject)P_0).SetData(P_1, P_2);
	}

	internal static void tTaYMil7OE7Ne2i2MYrn(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void XH4GsUl7qycbIO9nfsHe(object P_0)
	{
		((egRkWboAXfgpDYEiUFC)P_0).OfOoJ5yDt9();
	}

	internal static object FNDlsbl7ItlvshommpkH(object P_0)
	{
		return ((OMdL5pv2glbNcP3XDCe)P_0).Symbol;
	}

	internal static bool RwpUPtl7W7DiqjadjvOC(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void VL0098l7ton7mWYAWUe2(object P_0, object P_1)
	{
		((FrameworkElement)P_0).ContextMenu = (ContextMenu)P_1;
	}
}
