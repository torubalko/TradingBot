using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Extensions;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using Fb8gFFHFUNPFVH1wej60;
using G62jYXHff7IHsGnly3Of;
using jKxkD8HfxfM8pAInciSU;
using RAt2FG2t8OpVdd2cmIwD;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.UI.Controls.Toolbar;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Controls.PeriodSelect;

internal sealed class PeriodSelectControl : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	public static readonly DependencyProperty ShowSimpleBarsProperty;

	public static readonly DependencyProperty ValueProperty;

	private DataCycle _currentDataCycle;

	private Visibility _loadBarsVisibility;

	internal PeriodSelectControl PeriodSelect;

	internal ListBox ListBoxPeriods;

	internal StackPanel StackPanelPeriodSelected;

	internal ColumnDefinition ColumnDefinition0;

	internal ColumnDefinition ColumnDefinition1;

	internal ColumnDefinition ColumnDefinition2;

	internal DateEditBox DateEditBoxStartDate;

	internal DateEditBox DateEditBoxEndDate;

	internal Button ButtonEdit;

	internal Button ButtonApply;

	private bool _contentLoaded;

	private static PeriodSelectControl GVXh1FDDLdfcfUEDB6oo;

	public bool ShowSimpleBars
	{
		get
		{
			return (bool)GetValue(ShowSimpleBarsProperty);
		}
		set
		{
			SetValue(ShowSimpleBarsProperty, value);
		}
	}

	public DataCycle Value
	{
		get
		{
			return (DataCycle)I0gjVFDDXUfjIMDst8Jj(this, ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public List<XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X> Positions { get; }

	public DataCycle CurrentDataCycle
	{
		get
		{
			return _currentDataCycle ?? (_currentDataCycle = DataCycle.Minute);
		}
		set
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
					if (!axDXlXDDcrS4R7wftAJk(value, _currentDataCycle))
					{
						_currentDataCycle = value;
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311355553));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ObservableCollection<DataCycle> Periods { get; set; }

	public Visibility LoadBarsVisibility
	{
		get
		{
			if (!ShowSimpleBars)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
		set
		{
			if (value != _loadBarsVisibility)
			{
				_loadBarsVisibility = value;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA9F2FC));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
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

	public Visibility Period2Visibility { get; set; }

	public event Action<DataCycle> PeriodChanged;

	private static void ShowSimpleBarsChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
	{
		if (o is PeriodSelectControl periodSelectControl)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			periodSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7395DFA4));
		}
	}

	private static void OnValueChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
	{
		(dependencyObject as PeriodSelectControl)?.SetDataCycle(args.NewValue as DataCycle, setDates: true);
	}

	public PeriodSelectControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Periods = new ObservableCollection<DataCycle>();
				Periods.AddRange(fKvKggHFteRddgHojOPb.Periods);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				InitializeComponent();
				fKvKggHFteRddgHojOPb.i9QHFrSPdFy(DataCyclesManagerOnChanged);
				return;
			case 2:
				Positions = new List<XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X>
				{
					new XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X(XToolbarPosition.None, (string)og6jfbDDE09HpNeM2EBV(LrcT3XDDjpYt7eCGpV7V(-1774602229 ^ -1774669125))),
					new XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X(XToolbarPosition.Top, FY07xYHfSCiM5E3465o7.suYHfE4hBHG((string)LrcT3XDDjpYt7eCGpV7V(0x4297C3EB ^ 0x429704D1))),
					new XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X(XToolbarPosition.Left, (string)og6jfbDDE09HpNeM2EBV(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446A700A))),
					new XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X(XToolbarPosition.Right, FY07xYHfSCiM5E3465o7.suYHfE4hBHG((string)LrcT3XDDjpYt7eCGpV7V(0x7F55E538 ^ 0x7F54EF3E))),
					new XOsXXoHfHX1hjTKSXyG3.G6bK55nW34cGGixAn37X(XToolbarPosition.Bottom, (string)og6jfbDDE09HpNeM2EBV(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446BBD30)))
				};
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void DataCyclesManagerOnChanged()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Periods.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Periods.AddRange(fKvKggHFteRddgHojOPb.Periods);
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1849017302));
				return;
			}
		}
	}

	private void PeriodSelectControl_MouseDown(object sender, MouseButtonEventArgs e)
	{
		e.Handled = true;
	}

	private void ButtonEdit_Click(object sender, RoutedEventArgs e)
	{
		t7ykx32t7oea68MPvy1p t7ykx32t7oea68MPvy1p = new t7ykx32t7oea68MPvy1p();
		t7ykx32t7oea68MPvy1p.Owner = Window.GetWindow(this);
		t7ykx32t7oea68MPvy1p.ShowDialog();
	}

	private void ButtonApply_Click(object sender, RoutedEventArgs e)
	{
		DataCycle obj = new DataCycle(CurrentDataCycle)
		{
			DaysToLoadChart = null,
			DaysToLoadDom = null
		};
		Action<DataCycle> action = this.PeriodChanged;
		if (action == null)
		{
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
		else
		{
			action(obj);
		}
	}

	private void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		DataCycle dataCycle = default(DataCycle);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				DataCycle obj = new DataCycle(CurrentDataCycle)
				{
					DaysToLoadChart = dataCycle.DaysToLoadChart,
					DaysToLoadDom = dataCycle.DaysToLoadDom
				};
				this.PeriodChanged?.Invoke(obj);
				return;
			}
			case 1:
				dataCycle = ListBoxPeriods.SelectedItem as DataCycle;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (dataCycle == null)
			{
				return;
			}
			SetDataCycle(dataCycle, setDates: false);
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
			{
				num2 = 2;
			}
		}
	}

	public void SetDataCycle(DataCycle dc, bool setDates)
	{
		if (dc == null || axDXlXDDcrS4R7wftAJk(dc, CurrentDataCycle))
		{
			return;
		}
		nODroiDDQ9f5bKllMlIg(CurrentDataCycle, dc.CycleBase);
		CurrentDataCycle.Repeat = dc.Repeat;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				CurrentDataCycle.RepeatParam1 = dc.RepeatParam1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
				{
					num = 2;
				}
				break;
			case 1:
				if (setDates)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
					{
						num = 0;
					}
					break;
				}
				goto IL_0023;
			default:
				CurrentDataCycle.StartDate = dc.StartDate;
				CurrentDataCycle.EndDate = dc.EndDate;
				CurrentDataCycle.DataType = dc.DataType;
				goto IL_0023;
			case 2:
				{
					p5khGvDDgP7ht5jwoOxd(CurrentDataCycle, bGvsiNDDd9xMK8qibhhM(dc));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
					{
						num = 1;
					}
					break;
				}
				IL_0023:
				ListBoxPeriods.SelectedIndex = -1;
				return;
			}
		}
	}

	private void PeriodSelectControl_OnLoaded(object sender, RoutedEventArgs e)
	{
		cY7HkOvo1nf((string)LrcT3XDDjpYt7eCGpV7V(0x50C1C840 ^ 0x50C0C596));
	}

	private void DateEditBoxStartDate_OnValueChanged(object sender, EventArgs e)
	{
		DateEditBoxStartDate.IsPopupOpen = false;
	}

	private void DateEditBoxEndDate_OnValueChanged(object sender, EventArgs e)
	{
		DateEditBoxEndDate.IsPopupOpen = false;
	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		int num;
		if (CurrentDataCycle.CycleBase != DataCycleBase.Reversal)
		{
			ColumnDefinition2.Width = GridLength.Auto;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
			{
				num = 0;
			}
		}
		else
		{
			JX9bSqDDRow19a4Io5gc(ColumnDefinition2, new GridLength(1.0, GridUnitType.Star));
			Period2Visibility = Visibility.Visible;
			cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E0528D2));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
			{
				num = 0;
			}
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
				Period2Visibility = Visibility.Collapsed;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CC4137));
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				if (_contentLoaded)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				_contentLoaded = true;
				Uri resourceLocator = new Uri((string)LrcT3XDDjpYt7eCGpV7V(-1606927328 ^ -1606864280), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				return;
			}
			case 0:
				return;
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
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					ButtonEdit.Click += ButtonEdit_Click;
					return;
				case 6:
					switch (connectionId)
					{
					case 1:
						PeriodSelect = (PeriodSelectControl)target;
						return;
					case 10:
						ButtonEdit = (Button)target;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
						{
							num2 = 4;
						}
						goto end_IL_0012;
					default:
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					case 3:
						break;
					case 2:
						ListBoxPeriods = (ListBox)target;
						num2 = 3;
						goto end_IL_0012;
					case 11:
						ButtonApply = (Button)target;
						ButtonApply.Click += ButtonApply_Click;
						return;
					case 7:
						ColumnDefinition2 = (ColumnDefinition)target;
						return;
					case 8:
						DateEditBoxStartDate = (DateEditBox)target;
						DEn6JEDDMDlNiuUEAeVw(DateEditBoxStartDate, new EventHandler(DateEditBoxStartDate_OnValueChanged));
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					case 6:
						ColumnDefinition1 = (ColumnDefinition)target;
						return;
					case 9:
						DateEditBoxEndDate = (DateEditBox)target;
						num2 = 7;
						goto end_IL_0012;
					case 5:
						ColumnDefinition0 = (ColumnDefinition)target;
						return;
					case 4:
						nBTerqDD66ngjLRnmqrO((ComboBox)target, new SelectionChangedEventHandler(ComboBox_SelectionChanged));
						num2 = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
						{
							num2 = 7;
						}
						goto end_IL_0012;
					}
					goto end_IL_0012_2;
				case 3:
					ListBoxPeriods.SelectionChanged += Selector_SelectionChanged;
					return;
				case 1:
					return;
				case 7:
					DEn6JEDDMDlNiuUEAeVw(DateEditBoxEndDate, new EventHandler(DateEditBoxEndDate_OnValueChanged));
					return;
				case 5:
					_contentLoaded = true;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					return;
				case 2:
					return;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
			StackPanelPeriodSelected = (StackPanel)target;
			num = 2;
		}
	}

	static PeriodSelectControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		ShowSimpleBarsProperty = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736501670), F8EblHDDOMLZywFFbOMH(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), F8EblHDDOMLZywFFbOMH(QPqceUDDqd81mv7vMfpE(33555232)), new PropertyMetadata(false, ShowSimpleBarsChanged));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ValueProperty = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520146767), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556088)), F8EblHDDOMLZywFFbOMH(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555232)), new PropertyMetadata(null, OnValueChangedCallback));
	}

	internal static bool IlS3ZEDDeddyg181PwA1()
	{
		return GVXh1FDDLdfcfUEDB6oo == null;
	}

	internal static PeriodSelectControl Pw99EODDsDJPioOwyTL5()
	{
		return GVXh1FDDLdfcfUEDB6oo;
	}

	internal static object I0gjVFDDXUfjIMDst8Jj(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool axDXlXDDcrS4R7wftAJk(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object LrcT3XDDjpYt7eCGpV7V(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object og6jfbDDE09HpNeM2EBV(object P_0)
	{
		return FY07xYHfSCiM5E3465o7.suYHfE4hBHG((string)P_0);
	}

	internal static void nODroiDDQ9f5bKllMlIg(object P_0, DataCycleBase value)
	{
		((DataCycle)P_0).CycleBase = value;
	}

	internal static int bGvsiNDDd9xMK8qibhhM(object P_0)
	{
		return ((DataCycle)P_0).RepeatParam2;
	}

	internal static void p5khGvDDgP7ht5jwoOxd(object P_0, int value)
	{
		((DataCycle)P_0).RepeatParam2 = value;
	}

	internal static void JX9bSqDDRow19a4Io5gc(object P_0, GridLength P_1)
	{
		((ColumnDefinition)P_0).Width = P_1;
	}

	internal static void nBTerqDD66ngjLRnmqrO(object P_0, object P_1)
	{
		((Selector)P_0).SelectionChanged += (SelectionChangedEventHandler)P_1;
	}

	internal static void DEn6JEDDMDlNiuUEAeVw(object P_0, object P_1)
	{
		((DateTimeEditBox)P_0).ValueChanged += (EventHandler)P_1;
	}

	internal static Type F8EblHDDOMLZywFFbOMH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle QPqceUDDqd81mv7vMfpE(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
