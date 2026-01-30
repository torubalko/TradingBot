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
using bnYBBQ4RRnJxHbvk4Rm;
using ECOEgqlSad8NUJZ2Dr9n;
using euNCE9lsfjbYKw86YuS;
using mBOuwh2x7WYCRTWvJexc;
using pBQZTE4DLtk18IAiFuJ;
using PgTFZmHaRDLPpi3M5aW9;
using qlYYgiGUrPB4hUPGZhy;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using TVTsoXTU3e2Lf43w2rV;
using vG0WidHawbhpKdkcelf8;
using xfdMo0lS4TP9pN36Goka;
using XPZd6XG3i7VywBHCqjR;
using yH1aSw95cBMPqRpT6nEr;

namespace TigerTrade.UI.ToolControls.Positions;

internal sealed class PositionsControl : mMZmHD44odQv31rC92N, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class aNc07yn48w9XxLQETfUG
	{
		public static readonly aNc07yn48w9XxLQETfUG MqHn4PyP7vO;

		public static Predicate<object> zkrn4JmYG6P;

		internal static aNc07yn48w9XxLQETfUG WK5WHiN0HTiobctBxkjU;

		static aNc07yn48w9XxLQETfUG()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			MqHn4PyP7vO = new aNc07yn48w9XxLQETfUG();
		}

		public aNc07yn48w9XxLQETfUG()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool c9Fn4A2VIjZ(object o)
		{
			if (o is e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo)
			{
				return nVpMIjN0n8kfAxTrsQWv(e21rPRGFkaM5W9IlKjo);
			}
			return false;
		}

		internal static bool sddMWZN0fTsbhA3mni6F()
		{
			return WK5WHiN0HTiobctBxkjU == null;
		}

		internal static aNc07yn48w9XxLQETfUG pFUKxVN09uK2CC09hdil()
		{
			return WK5WHiN0HTiobctBxkjU;
		}

		internal static bool nVpMIjN0n8kfAxTrsQWv(object P_0)
		{
			return ((e21rPRGFkaM5W9IlKjo)P_0).IsVisible;
		}
	}

	[CompilerGenerated]
	private sealed class cf6cvcn4FwjaJrrInJxo
	{
		public e21rPRGFkaM5W9IlKjo htNn4pXSKNW;

		public PositionsControl rLun4u4uofF;

		private static cf6cvcn4FwjaJrrInJxo TaYTZLN0GB6B8W0Cg0LO;

		public cf6cvcn4FwjaJrrInJxo()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void Ydqn43MLOpH(object o, RoutedEventArgs args)
		{
			W267pmN0BypdPYsK698B(rLun4u4uofF.ViewModel, hTAmW5N0vrsMeMqnQJMJ(htNn4pXSKNW));
		}

		static cf6cvcn4FwjaJrrInJxo()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool YwbepUN0YGs4LNFPGn6q()
		{
			return TaYTZLN0GB6B8W0Cg0LO == null;
		}

		internal static cf6cvcn4FwjaJrrInJxo q3mqI0N0oDR6wIdwrghv()
		{
			return TaYTZLN0GB6B8W0Cg0LO;
		}

		internal static object hTAmW5N0vrsMeMqnQJMJ(object P_0)
		{
			return ((e21rPRGFkaM5W9IlKjo)P_0).Position;
		}

		internal static void W267pmN0BypdPYsK698B(object P_0, object P_1)
		{
			((qNUyidGtHr87QVuWB9h)P_0).ClosePosition((Position)P_1);
		}
	}

	private CollectionViewSource viewSource;

	private readonly ContextMenu _itemContextMenu;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	internal static PositionsControl zG0m0olhLR3gqC2W0ecg;

	public qNUyidGtHr87QVuWB9h ViewModel { get; }

	public PositionsControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		_itemContextMenu = new ContextMenu();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Positions);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
		{
			num = 1;
		}
		MenuItem menuItem = default(MenuItem);
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				viewSource = (CollectionViewSource)base.Resources[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F0E83A)];
				viewSource.View.Filter = (object o) => o is e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo && aNc07yn48w9XxLQETfUG.nVpMIjN0n8kfAxTrsQWv(e21rPRGFkaM5W9IlKjo);
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				ViewModel = new qNUyidGtHr87QVuWB9h();
				InitializeComponent();
				num = 3;
				break;
			default:
				tbCJG1lhcjusD6OGlJpl(_itemContextMenu.Items, menuItem);
				return;
			case 2:
				menuItem = new MenuItem
				{
					Header = uBOWXmlhXHteBJpJoIpf()
				};
				menuItem.Click += OnItemContextMenuClick;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		DependencyObject dependencyObject = (DependencyObject)zh3JR5lhjM0Im593cQb0(e);
		cf6cvcn4FwjaJrrInJxo cf6cvcn4FwjaJrrInJxo = default(cf6cvcn4FwjaJrrInJxo);
		ContextMenu contextMenu = default(ContextMenu);
		MenuItem menuItem2 = default(MenuItem);
		object obj2 = default(object);
		while (true)
		{
			int num;
			if (dependencyObject != null)
			{
				num = 10;
				goto IL_0005;
			}
			goto IL_017b;
			IL_0005:
			int num2 = num;
			goto IL_0009;
			IL_017b:
			if (!(dependencyObject is DataGridColumnHeader))
			{
				if (dependencyObject != null)
				{
					cf6cvcn4FwjaJrrInJxo = new cf6cvcn4FwjaJrrInJxo();
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
					{
						num2 = 7;
					}
					goto IL_0009;
				}
				return;
			}
			break;
			IL_0009:
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 9:
				{
					DataGridRow rowContainingElement = DataGridRow.GetRowContainingElement(dependencyObject as DataGridCell);
					if (rowContainingElement == null)
					{
						num2 = 3;
						continue;
					}
					obj = rowContainingElement.Item;
					goto IL_02cf;
				}
				case 7:
					cf6cvcn4FwjaJrrInJxo.rLun4u4uofF = this;
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					return;
				case 5:
					contextMenu = new ContextMenu();
					num2 = 9;
					continue;
				default:
					contextMenu.Items.Add(menuItem2);
					contextMenu.Items.Add(new Separator());
					if (ViewModel.Gu2GTvkIdQ(cf6cvcn4FwjaJrrInJxo.htNn4pXSKNW.Position))
					{
						MenuItem menuItem3 = new MenuItem
						{
							Header = BTxPSqlhQHaYdi1oXXYJ()
						};
						menuItem3.Click += cf6cvcn4FwjaJrrInJxo.Ydqn43MLOpH;
						tbCJG1lhcjusD6OGlJpl(contextMenu.Items, menuItem3);
						num2 = 11;
						continue;
					}
					break;
				case 11:
					break;
				case 2:
					cf6cvcn4FwjaJrrInJxo.htNn4pXSKNW = obj2 as e21rPRGFkaM5W9IlKjo;
					if (cf6cvcn4FwjaJrrInJxo.htNn4pXSKNW != null)
					{
						MenuItem menuItem = new MenuItem();
						JoJ4ljlhES2LvECfAVkj(menuItem, uBOWXmlhXHteBJpJoIpf());
						menuItem2 = menuItem;
						menuItem2.Click += OnItemContextMenuClick;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 8:
					goto end_IL_0009;
				case 10:
					goto IL_027f;
				case 4:
				case 6:
					dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
					num2 = 8;
					continue;
				case 3:
					{
						obj = null;
						goto IL_02cf;
					}
					IL_02cf:
					obj2 = obj;
					num2 = 2;
					continue;
				}
				if (ADGgWclhg8fPRCSIjcsR(ThF4welhdbdhKrE575sK(contextMenu)) != 0)
				{
					contextMenu.Opened += delegate
					{
						DataGrid.ContextMenu = null;
					};
					tYOk9tlhRwbo3yA0CecL(DataGrid, contextMenu);
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0009:
				break;
			}
			continue;
			IL_027f:
			if (!(dependencyObject is DataGridCell) && !(dependencyObject is DataGridColumnHeader))
			{
				num = 4;
				goto IL_0005;
			}
			goto IL_017b;
		}
		DataGrid.rWAHi2QjAqn();
	}

	private void OnItemContextMenuClick(object sender, RoutedEventArgs e)
	{
		if (DataGrid.SelectedItem is e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo)
		{
			Clipboard.Clear();
			Clipboard.SetText((string)E0KjJTlh6b6FZu4S3Eim(e21rPRGFkaM5W9IlKjo), TextDataFormat.UnicodeText);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
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

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.to8HinyXyDi(b0Y45wEcGs(workspaceID));
		ViewModel.OnlyOpenPositions = settings.OnlyOpenPositions;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				base.DocLinkContext.LedBrush = MfLO4e2xwx7qp1Q89I0Y.kp22x8aRS0a(SeIlfLmGQY2);
				return;
			case 1:
				SeIlfLmGQY2 = settings.KPjlZIpNqs;
				base.DocLinkContext.GroupId = SeIlfLmGQY2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
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
		settings.OnlyOpenPositions = ViewModel.OnlyOpenPositions;
		settings.KPjlZIpNqs = SeIlfLmGQY2;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void MenuButton_Click(object sender, RoutedEventArgs e)
	{
		string text = ((ButtonBase)sender).CommandParameter.ToString();
		int num;
		if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BF63E8))
		{
			ViewModel.SToGye2XOX();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416978079) && YesNoWindow.ShowWindow(base.ParentWindow, TigerTrade.Properties.Resources.PositionsControlConfirmCloseAllTitle, TigerTrade.Properties.Resources.PositionsControlConfirmCloseAllMsg))
		{
			YhbAyZlhM6EaxtKDX6Si(ViewModel);
		}
	}

	private void DataGrid_OnSorting(object sender, DataGridSortingEventArgs e)
	{
		e.Handled = true;
		DataGridColumn dataGridColumn = (DataGridColumn)GUcdPGlhOXvg9EwTXdj4(e);
		dataGridColumn.PdwHa6wgtGq();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Ir4HBFlhIHyxj61vP66C((ListCollectionView)mxr5tClhqSl3y2XwU8Oa(viewSource), new DRhm0KTtoiwpM8Aa5Gm(dataGridColumn));
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		O1I4NQwQCH(groupID);
	}

	private void OnSetLinkSymbol(Symbol symbol)
	{
		if (symbol != null)
		{
			GGi4kNPKJO(symbol);
		}
	}

	private void DataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (j18iDj9nukSCmEyZs5lH.Settings.TickerSwitchingMode == IknmHh95XIeQvfxb4I0a.uSr95jaMU03)
		{
			SetLinkSymbol();
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
	}

	private void SetLinkSymbol()
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj2 = o5lrLmlhWsrOMXMZvPq3(ViewModel);
				if (obj2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = ogEIJ5lhtRostcIhWJQC(((e21rPRGFkaM5W9IlKjo)obj2).Position);
				break;
			}
			default:
				obj = null;
				break;
			}
			break;
		}
		Symbol symbol = (Symbol)obj;
		GGi4kNPKJO(symbol);
	}

	private void DataGrid_OnPreviewLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		int num = 3;
		DataObject dataObject = default(DataObject);
		u0GAIHHahyHxCr1XJKud u0GAIHHahyHxCr1XJKud = default(u0GAIHHahyHxCr1XJKud);
		e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo = default(e21rPRGFkaM5W9IlKjo);
		Symbol symbol = default(Symbol);
		DataGridRow dataGridRow = default(DataGridRow);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					DragDrop.DoDragDrop(this, dataObject, DragDropEffects.Copy);
					return;
				case 3:
					u0GAIHHahyHxCr1XJKud = sender as u0GAIHHahyHxCr1XJKud;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num2 = 2;
					}
					break;
				case 7:
				{
					Position position = e21rPRGFkaM5W9IlKjo.Position;
					symbol = (Symbol)((position != null) ? MKGr8HlhUhY83CLVO0vJ(position) : null);
					num2 = 4;
					break;
				}
				case 5:
					if (dataGridRow == null)
					{
						return;
					}
					if (e.ClickCount == 2)
					{
						goto end_IL_0012;
					}
					goto IL_0136;
				case 2:
					if (u0GAIHHahyHxCr1XJKud == null)
					{
						return;
					}
					dataGridRow = u0GAIHHahyHxCr1XJKud.fEnHiGVTCDB(e);
					num2 = 5;
					break;
				case 0:
					return;
				case 6:
					if (j18iDj9nukSCmEyZs5lH.Settings.TickerSwitchingMode == IknmHh95XIeQvfxb4I0a.V6U95Eue85N)
					{
						SetLinkSymbol();
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0136;
				case 4:
					{
						if (symbol == null)
						{
							return;
						}
						dataObject = new DataObject(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777446)), symbol);
						dataObject.SetData(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554595)), this);
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
						{
							num2 = 1;
						}
						break;
					}
					IL_0136:
					e21rPRGFkaM5W9IlKjo = dataGridRow.Item as e21rPRGFkaM5W9IlKjo;
					if (e21rPRGFkaM5W9IlKjo != null)
					{
						num2 = 7;
						break;
					}
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2DDBDB), UriKind.Relative);
			JjOamFlhTXvv1RC4A6YE(this, uri);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)se9glLlhy9P4J9fJSrwQ(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 1:
			gjmhiFlhZSR8LRyqwMRB((Button)target, new RoutedEventHandler(MenuButton_Click));
			break;
		case 2:
			((Button)target).Click += MenuButton_Click;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			_contentLoaded = true;
			break;
		case 3:
			{
				DataGrid = (u0GAIHHahyHxCr1XJKud)target;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static PositionsControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object uBOWXmlhXHteBJpJoIpf()
	{
		return TigerTrade.Properties.Resources.WatchlistControlCopyTicker;
	}

	internal static int tbCJG1lhcjusD6OGlJpl(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static bool m14KfplheLkE9Qc0Vpik()
	{
		return zG0m0olhLR3gqC2W0ecg == null;
	}

	internal static PositionsControl iSZGE6lhs9b2KsYAPhoJ()
	{
		return zG0m0olhLR3gqC2W0ecg;
	}

	internal static object zh3JR5lhjM0Im593cQb0(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static void JoJ4ljlhES2LvECfAVkj(object P_0, object P_1)
	{
		((HeaderedItemsControl)P_0).Header = P_1;
	}

	internal static object BTxPSqlhQHaYdi1oXXYJ()
	{
		return TigerTrade.Properties.Resources.PositionsControlClose;
	}

	internal static object ThF4welhdbdhKrE575sK(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static int ADGgWclhg8fPRCSIjcsR(object P_0)
	{
		return ((CollectionView)P_0).Count;
	}

	internal static void tYOk9tlhRwbo3yA0CecL(object P_0, object P_1)
	{
		((FrameworkElement)P_0).ContextMenu = (ContextMenu)P_1;
	}

	internal static object E0KjJTlh6b6FZu4S3Eim(object P_0)
	{
		return ((e21rPRGFkaM5W9IlKjo)P_0).Symbol;
	}

	internal static void YhbAyZlhM6EaxtKDX6Si(object P_0)
	{
		((qNUyidGtHr87QVuWB9h)P_0).CloseAllPositions();
	}

	internal static object GUcdPGlhOXvg9EwTXdj4(object P_0)
	{
		return ((DataGridColumnEventArgs)P_0).Column;
	}

	internal static object mxr5tClhqSl3y2XwU8Oa(object P_0)
	{
		return ((CollectionViewSource)P_0).View;
	}

	internal static void Ir4HBFlhIHyxj61vP66C(object P_0, object P_1)
	{
		((ListCollectionView)P_0).CustomSort = (IComparer)P_1;
	}

	internal static object o5lrLmlhWsrOMXMZvPq3(object P_0)
	{
		return ((qNUyidGtHr87QVuWB9h)P_0).SelectedPosition;
	}

	internal static object ogEIJ5lhtRostcIhWJQC(object P_0)
	{
		return ((Position)P_0).Symbol;
	}

	internal static object MKGr8HlhUhY83CLVO0vJ(object P_0)
	{
		return ((Position)P_0).Symbol;
	}

	internal static void JjOamFlhTXvv1RC4A6YE(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object se9glLlhy9P4J9fJSrwQ(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void gjmhiFlhZSR8LRyqwMRB(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
