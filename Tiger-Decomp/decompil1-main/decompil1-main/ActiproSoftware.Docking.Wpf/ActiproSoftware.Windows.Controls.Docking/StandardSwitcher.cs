using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking;

[TemplatePart(Name = "PART_ItemsPanel", Type = typeof(Grid))]
[ToolboxItem(false)]
public class StandardSwitcher : SwitcherBase
{
	private bool uWF;

	private bool sWV;

	private int OWP;

	private int aWf;

	private int NWU;

	private int oWc;

	private Grid KW4;

	private int uWj;

	private DelegateCommand<object> RWZ;

	private DelegateCommand<object> IWb;

	private DelegateCommand<object> eWA;

	private DelegateCommand<object> MWH;

	public static readonly DependencyProperty AreDocumentsVisibleProperty;

	public static readonly DependencyProperty AreToolWindowsVisibleProperty;

	public static readonly DependencyProperty DocumentsColumnTitleProperty;

	public static readonly DependencyProperty FooterTemplateProperty;

	public static readonly DependencyProperty HeaderTemplateProperty;

	public static readonly DependencyProperty ItemContainerStyleProperty;

	public static readonly DependencyProperty ItemTemplateProperty;

	public static readonly DependencyProperty MaxDocumentColumnCountProperty;

	public static readonly DependencyProperty MaxRowCountProperty;

	public static readonly DependencyProperty ScrollButtonStyleProperty;

	public static readonly DependencyProperty ScrollDownButtonContentTemplateProperty;

	public static readonly DependencyProperty ScrollUpButtonContentTemplateProperty;

	public static readonly DependencyProperty ShadowElevationProperty;

	public static readonly DependencyProperty ToolWindowsColumnTitleProperty;

	private static StandardSwitcher mHl;

	public bool AreDocumentsVisible
	{
		get
		{
			return (bool)GetValue(AreDocumentsVisibleProperty);
		}
		set
		{
			SetValue(AreDocumentsVisibleProperty, value);
		}
	}

	public bool AreToolWindowsVisible
	{
		get
		{
			return (bool)GetValue(AreToolWindowsVisibleProperty);
		}
		set
		{
			SetValue(AreToolWindowsVisibleProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string DocumentsColumnTitle
	{
		get
		{
			return (string)GetValue(DocumentsColumnTitleProperty);
		}
		set
		{
			SetValue(DocumentsColumnTitleProperty, value);
		}
	}

	public DataTemplate FooterTemplate
	{
		get
		{
			return (DataTemplate)GetValue(FooterTemplateProperty);
		}
		set
		{
			SetValue(FooterTemplateProperty, value);
		}
	}

	public DataTemplate HeaderTemplate
	{
		get
		{
			return (DataTemplate)GetValue(HeaderTemplateProperty);
		}
		set
		{
			SetValue(HeaderTemplateProperty, value);
		}
	}

	public Style ItemContainerStyle
	{
		get
		{
			return (Style)GetValue(ItemContainerStyleProperty);
		}
		set
		{
			SetValue(ItemContainerStyleProperty, value);
		}
	}

	public DataTemplate ItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ItemTemplateProperty);
		}
		set
		{
			SetValue(ItemTemplateProperty, value);
		}
	}

	public int MaxDocumentColumnCount
	{
		get
		{
			return (int)GetValue(MaxDocumentColumnCountProperty);
		}
		set
		{
			SetValue(MaxDocumentColumnCountProperty, value);
		}
	}

	public int MaxRowCount
	{
		get
		{
			return (int)GetValue(MaxRowCountProperty);
		}
		set
		{
			SetValue(MaxRowCountProperty, value);
		}
	}

	public Style ScrollButtonStyle
	{
		get
		{
			return (Style)GetValue(ScrollButtonStyleProperty);
		}
		set
		{
			SetValue(ScrollButtonStyleProperty, value);
		}
	}

	public DataTemplate ScrollDownButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollDownButtonContentTemplateProperty);
		}
		set
		{
			SetValue(ScrollDownButtonContentTemplateProperty, value);
		}
	}

	public DataTemplate ScrollUpButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollUpButtonContentTemplateProperty);
		}
		set
		{
			SetValue(ScrollUpButtonContentTemplateProperty, value);
		}
	}

	public int ShadowElevation
	{
		get
		{
			return (int)GetValue(ShadowElevationProperty);
		}
		set
		{
			SetValue(ShadowElevationProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string ToolWindowsColumnTitle
	{
		get
		{
			return (string)GetValue(ToolWindowsColumnTitleProperty);
		}
		set
		{
			SetValue(ToolWindowsColumnTitleProperty, value);
		}
	}

	public StandardSwitcher()
	{
		IVH.CecNqz();
		base._002Ector(canSortByLastFocusedDateTime: true);
		base.DefaultStyleKey = typeof(StandardSwitcher);
		rWG();
		if (BrowserInteropHelper.IsBrowserHosted)
		{
			ShadowElevation = 0;
		}
	}

	[SpecialName]
	private bool xW7()
	{
		if (uWF)
		{
			return aWf < base.Documents.Count - (OWP * oWc - (uWF ? 2 : 0));
		}
		return false;
	}

	[SpecialName]
	private bool rWS()
	{
		if (uWF)
		{
			return aWf > 0;
		}
		return false;
	}

	[SpecialName]
	private bool vW3()
	{
		if (sWV)
		{
			return NWU < base.ToolWindows.Count - (uWj * oWc - (sWV ? 2 : 0));
		}
		return false;
	}

	[SpecialName]
	private bool NW9()
	{
		if (sWV)
		{
			return NWU > 0;
		}
		return false;
	}

	private void WWe()
	{
		if (KW4 != null)
		{
			KW4.Children.Clear();
			KW4.RowDefinitions.Clear();
			KW4.ColumnDefinitions.Clear();
		}
		sWV = false;
		uWF = false;
		NWU = 0;
		aWf = 0;
	}

	private void rWG()
	{
		RWZ = new DelegateCommand<object>(delegate
		{
			if (xW7())
			{
				aWf++;
				zWO();
				jWJ();
			}
		}, (object P_0) => xW7());
		IWb = new DelegateCommand<object>(delegate
		{
			if (rWS())
			{
				aWf--;
				zWO();
				jWJ();
			}
		}, (object P_0) => rWS());
		eWA = new DelegateCommand<object>(delegate
		{
			if (vW3())
			{
				NWU++;
				zWO();
				jWJ();
			}
		}, (object P_0) => vW3());
		MWH = new DelegateCommand<object>(delegate
		{
			if (NW9())
			{
				NWU--;
				zWO();
				jWJ();
			}
		}, (object P_0) => NW9());
	}

	private void bWI(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		bool flag = base.Documents.Contains(P_0);
		ToolWindow toolWindow = P_0 as ToolWindow;
		int num = 0;
		if (!yH9())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				zWO();
				jWJ();
				return;
			case 1:
				return;
			}
			if (!flag)
			{
				if (!sWV || toolWindow == null)
				{
					return;
				}
				if (!base.ToolWindows.Contains(toolWindow))
				{
					num = 1;
					if (!yH9())
					{
						break;
					}
					continue;
				}
			}
			else if (!uWF)
			{
				return;
			}
			if (!flag)
			{
				int num2 = base.ToolWindows.IndexOf(toolWindow);
				if (num2 < NWU)
				{
					NWU = num2;
					zWO();
					jWJ();
				}
				else if (num2 >= NWU + uWj * oWc - 2)
				{
					NWU = num2 - (uWj * oWc - 2) + 1;
					zWO();
					jWJ();
				}
				return;
			}
			int num3 = base.Documents.IndexOf(P_0);
			if (num3 < aWf)
			{
				aWf = num3;
				num = 2;
				continue;
			}
			if (num3 >= aWf + OWP * oWc - 2)
			{
				aWf = num3 - (OWP * oWc - 2) + 1;
				zWO();
				jWJ();
			}
			return;
		}
		goto IL_0005;
		IL_0005:
		int num4 = default(int);
		num = num4;
		goto IL_0009;
	}

	private static int dWk(Control P_0)
	{
		if (P_0 != null)
		{
			return Grid.GetColumn(P_0) / 2;
		}
		return 0;
	}

	private StandardSwitcherItem EWC(int P_0, int P_1)
	{
		if (KW4 != null)
		{
			foreach (object child in KW4.Children)
			{
				if (child is StandardSwitcherItem standardSwitcherItem && kW1(standardSwitcherItem) == P_0 && dWk(standardSwitcherItem) == P_1)
				{
					return standardSwitcherItem;
				}
			}
		}
		return null;
	}

	private static int kW1(Control P_0)
	{
		if (P_0 != null)
		{
			return Math.Max(0, Grid.GetRow(P_0) - 1);
		}
		return 0;
	}

	internal StandardSwitcherItem qWN()
	{
		if (KW4 != null)
		{
			foreach (object child in KW4.Children)
			{
				if (child is StandardSwitcherItem { IsSelected: not false } standardSwitcherItem)
				{
					return standardSwitcherItem;
				}
			}
		}
		return null;
	}

	[SpecialName]
	internal Grid rWp()
	{
		return KW4;
	}

	[SpecialName]
	internal void UWs(Grid value)
	{
		KW4 = value;
	}

	private void HWQ()
	{
		DockingWindow selectedWindow = base.SelectedWindow;
		if (selectedWindow is ToolWindow value)
		{
			int num = base.ToolWindows.IndexOf(value);
			if (num != -1)
			{
				if (num + 1 < base.ToolWindows.Count)
				{
					base.SelectedWindow = base.ToolWindows[num + 1];
				}
				else if (AreDocumentsVisible && base.Documents.Count > 0)
				{
					base.SelectedWindow = base.Documents[0];
				}
				else
				{
					base.SelectedWindow = base.ToolWindows[0];
				}
				return;
			}
		}
		if (selectedWindow == null)
		{
			return;
		}
		int num2 = base.Documents.IndexOf(selectedWindow);
		if (num2 != -1)
		{
			if (num2 + 1 < base.Documents.Count)
			{
				base.SelectedWindow = base.Documents[num2 + 1];
			}
			else if (AreToolWindowsVisible && base.ToolWindows.Count > 0)
			{
				base.SelectedWindow = base.ToolWindows[0];
			}
			else
			{
				base.SelectedWindow = base.Documents[0];
			}
		}
	}

	private void aWm()
	{
		StandardSwitcherItem standardSwitcherItem = qWN();
		if (standardSwitcherItem == null)
		{
			return;
		}
		int num = dWk(standardSwitcherItem) - 1;
		if (num < 0)
		{
			num = uWj + OWP - 1;
		}
		int num2 = kW1(standardSwitcherItem);
		if (num2 == 0)
		{
			if (!dWK(num2, num))
			{
				dWK(num2 + 1, num);
			}
			return;
		}
		while (num2 >= 0)
		{
			if (dWK(num2, num))
			{
				return;
			}
			num2--;
		}
		int num3 = 0;
		if (iHm() != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		case 0:
			break;
		}
	}

	private void jWa()
	{
		StandardSwitcherItem standardSwitcherItem = qWN();
		if (standardSwitcherItem == null)
		{
			return;
		}
		int num = dWk(standardSwitcherItem) + 1;
		if (num >= uWj + OWP)
		{
			num = 0;
		}
		int num2 = kW1(standardSwitcherItem);
		if (num2 == 0)
		{
			if (!dWK(num2, num))
			{
				dWK(num2 + 1, num);
			}
		}
		else
		{
			while (num2 >= 0 && !dWK(num2, num))
			{
				num2--;
			}
		}
	}

	private void yWW()
	{
		DockingWindow selectedWindow = base.SelectedWindow;
		if (selectedWindow is ToolWindow value)
		{
			int num = base.ToolWindows.IndexOf(value);
			if (num != -1)
			{
				if (num - 1 >= 0)
				{
					base.SelectedWindow = base.ToolWindows[num - 1];
				}
				else if (AreDocumentsVisible && base.Documents.Count > 0)
				{
					base.SelectedWindow = base.Documents[base.Documents.Count - 1];
				}
				else
				{
					base.SelectedWindow = base.ToolWindows[base.ToolWindows.Count - 1];
				}
				return;
			}
		}
		if (selectedWindow == null)
		{
			return;
		}
		int num2 = base.Documents.IndexOf(selectedWindow);
		if (num2 != -1)
		{
			if (num2 - 1 >= 0)
			{
				base.SelectedWindow = base.Documents[num2 - 1];
			}
			else if (AreToolWindowsVisible && base.ToolWindows.Count > 0)
			{
				base.SelectedWindow = base.ToolWindows[base.ToolWindows.Count - 1];
			}
			else
			{
				base.SelectedWindow = base.Documents[base.Documents.Count - 1];
			}
		}
	}

	internal void hWB(StandardSwitcherItem P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15992));
		}
		DockingWindow dockingWindow = P_0.DockingWindow;
		if (dockingWindow == null)
		{
			return;
		}
		if (!base.Documents.Contains(dockingWindow))
		{
			if (dockingWindow is ToolWindow value && base.ToolWindows.Contains(value))
			{
				base.SelectedWindow = dockingWindow;
				int num = 0;
				if (!yH9())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
		else
		{
			base.SelectedWindow = dockingWindow;
		}
	}

	private bool dWK(int P_0, int P_1)
	{
		StandardSwitcherItem standardSwitcherItem = EWC(P_0, P_1);
		if (standardSwitcherItem != null)
		{
			base.SelectedWindow = standardSwitcherItem.DockingWindow;
			return true;
		}
		return false;
	}

	private void jWJ()
	{
		RWZ.RaiseCanExecuteChanged();
		IWb.RaiseCanExecuteChanged();
		eWA.RaiseCanExecuteChanged();
		MWH.RaiseCanExecuteChanged();
	}

	private void NWn()
	{
		if (KW4 == null)
		{
			return;
		}
		bool areToolWindowsVisible = AreToolWindowsVisible;
		bool areDocumentsVisible = AreDocumentsVisible;
		int val = (areToolWindowsVisible ? base.ToolWindows.Count : 0);
		int num = (areDocumentsVisible ? base.Documents.Count : 0);
		oWc = Math.Max(3, Math.Min(MaxRowCount, Math.Max(val, num)));
		int num2 = 1 + oWc;
		uWj = (areToolWindowsVisible ? 1 : 0);
		int val2 = Math.Max(1, MaxDocumentColumnCount);
		int val3 = num / oWc + ((num % oWc > 0) ? 1 : 0);
		OWP = (areDocumentsVisible ? Math.Max(1, Math.Min(val2, val3)) : 0);
		int num3 = Math.Max(0, uWj + OWP - 1);
		int num4 = uWj + OWP + num3;
		WWe();
		for (int i = 0; i < num2; i++)
		{
			KW4.RowDefinitions.Add(new RowDefinition());
		}
		for (int j = 0; j < num4; j++)
		{
			ColumnDefinition columnDefinition = new ColumnDefinition();
			if (j % 2 == 1)
			{
				columnDefinition.Width = new GridLength(5.0);
			}
			KW4.ColumnDefinitions.Add(columnDefinition);
		}
		if (areToolWindowsVisible)
		{
			TextBlock element = new TextBlock
			{
				FontWeight = FontWeights.Bold,
				Margin = new Thickness(0.0, 0.0, 0.0, 3.0),
				MinWidth = 180.0,
				Text = ToolWindowsColumnTitle,
				TextTrimming = TextTrimming.CharacterEllipsis
			};
			KW4.Children.Add(element);
			sWV = base.ToolWindows.Count > uWj * oWc;
			if (sWV)
			{
				RepeatButton element2 = new RepeatButton
				{
					Command = MWH,
					ContentTemplate = ScrollUpButtonContentTemplate,
					Style = ScrollButtonStyle
				};
				Grid.SetRow(element2, 1);
				KW4.Children.Add(element2);
				RepeatButton element3 = new RepeatButton
				{
					Command = eWA,
					ContentTemplate = ScrollDownButtonContentTemplate,
					Style = ScrollButtonStyle
				};
				Grid.SetRow(element3, KW4.RowDefinitions.Count - 1);
				Grid.SetColumn(element3, (uWj - 1) * 2);
				KW4.Children.Add(element3);
			}
		}
		if (areDocumentsVisible)
		{
			TextBlock element4 = new TextBlock
			{
				FontWeight = FontWeights.Bold,
				Margin = new Thickness(0.0, 0.0, 0.0, 3.0),
				MinWidth = 180.0,
				Text = DocumentsColumnTitle,
				TextTrimming = TextTrimming.CharacterEllipsis
			};
			int num5 = ((uWj > 0) ? (uWj * 2) : 0);
			Grid.SetColumn(element4, num5);
			KW4.Children.Add(element4);
			uWF = base.Documents.Count > OWP * oWc;
			if (uWF)
			{
				RepeatButton element5 = new RepeatButton
				{
					Command = IWb,
					ContentTemplate = ScrollUpButtonContentTemplate,
					Style = ScrollButtonStyle
				};
				Grid.SetRow(element5, 1);
				Grid.SetColumn(element5, num5);
				KW4.Children.Add(element5);
				RepeatButton element6 = new RepeatButton
				{
					Command = RWZ,
					ContentTemplate = ScrollDownButtonContentTemplate,
					Style = ScrollButtonStyle
				};
				Grid.SetRow(element6, KW4.RowDefinitions.Count - 1);
				Grid.SetColumn(element6, num5 + (OWP - 1) * 2);
				KW4.Children.Add(element6);
			}
		}
		zWO();
		jWJ();
	}

	private void zWO()
	{
		if (KW4 == null)
		{
			return;
		}
		for (int num = KW4.Children.Count - 1; num >= 0; num--)
		{
			if (KW4.Children[num] is StandardSwitcherItem)
			{
				KW4.Children.RemoveAt(num);
			}
		}
		if (AreToolWindowsVisible)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < uWj; i++)
			{
				num2 += num3;
				num3 = 0;
				int num4 = 0;
				if (sWV && i == 0)
				{
					num4 = 1;
				}
				for (int j = NWU + num2; j < base.ToolWindows.Count; j++)
				{
					ToolWindow content = base.ToolWindows[j];
					StandardSwitcherItem element = new StandardSwitcherItem
					{
						Style = ItemContainerStyle,
						ContentTemplate = ItemTemplate,
						Content = content
					};
					Grid.SetRow(element, 1 + num4 + num3);
					Grid.SetColumn(element, i * 2);
					KW4.Children.Add(element);
					if (num4 + ++num3 >= oWc || (sWV && i == uWj - 1 && num4 + num3 == oWc - 1))
					{
						break;
					}
				}
			}
		}
		if (AreDocumentsVisible)
		{
			int num5 = 0;
			int num6 = 0;
			for (int k = 0; k < OWP; k++)
			{
				num5 += num6;
				num6 = 0;
				int num7 = 0;
				if (uWF && k == 0)
				{
					num7 = 1;
				}
				for (int l = aWf + num5; l < base.Documents.Count; l++)
				{
					DockingWindow content2 = base.Documents[l];
					StandardSwitcherItem element2 = new StandardSwitcherItem
					{
						Style = ItemContainerStyle,
						ContentTemplate = ItemTemplate,
						Content = content2
					};
					Grid.SetRow(element2, 1 + num7 + num6);
					Grid.SetColumn(element2, uWj * 2 + k * 2);
					KW4.Children.Add(element2);
					if (num7 + ++num6 >= oWc || (uWF && k == OWP - 1 && num7 + num6 == oWc - 1))
					{
						break;
					}
				}
			}
		}
		XWT();
	}

	private void XWT()
	{
		if (KW4 == null)
		{
			return;
		}
		DockingWindow selectedWindow = base.SelectedWindow;
		for (int num = KW4.Children.Count - 1; num >= 0; num--)
		{
			if (KW4.Children[num] is StandardSwitcherItem standardSwitcherItem)
			{
				standardSwitcherItem.IsSelected = standardSwitcherItem.DockingWindow == selectedWindow;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		UWs(GetTemplateChild(vVK.ssH(16004)) as Grid);
		NWn();
	}

	protected override void OnClosed()
	{
		base.OnClosed();
		WWe();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new StandardSwitcherAutomationPeer(this);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		switch ((e.Key == Key.System) ? e.SystemKey : e.Key)
		{
		case Key.Down:
			HWQ();
			e.Handled = true;
			break;
		case Key.Left:
			aWm();
			e.Handled = true;
			break;
		case Key.Right:
			jWa();
			e.Handled = true;
			break;
		case Key.Up:
			yWW();
			e.Handled = true;
			break;
		case Key.Return:
		case Key.Escape:
			Close();
			e.Handled = true;
			break;
		}
		base.OnKeyDown(e);
	}

	protected override void OnOpened()
	{
		base.OnOpened();
		NWn();
	}

	protected override void OnSelectedWindowChanged(DockingWindow oldValue, DockingWindow newValue)
	{
		base.OnSelectedWindowChanged(oldValue, newValue);
		bWI(newValue);
		XWT();
		if (AutomationPeer.ListenerExists(AutomationEvents.SelectionPatternOnInvalidated) && UIElementAutomationPeer.CreatePeerForElement(this) is StandardSwitcherAutomationPeer standardSwitcherAutomationPeer)
		{
			standardSwitcherAutomationPeer.YR7();
		}
	}

	static StandardSwitcher()
	{
		IVH.CecNqz();
		AreDocumentsVisibleProperty = DependencyProperty.Register(vVK.ssH(16038), typeof(bool), typeof(StandardSwitcher), new PropertyMetadata(true));
		AreToolWindowsVisibleProperty = DependencyProperty.Register(vVK.ssH(16080), typeof(bool), typeof(StandardSwitcher), new PropertyMetadata(true));
		DocumentsColumnTitleProperty = DependencyProperty.Register(vVK.ssH(16126), typeof(string), typeof(StandardSwitcher), new PropertyMetadata(SR.GetString(SRName.UIStandardSwitcherDocumentsText)));
		FooterTemplateProperty = DependencyProperty.Register(vVK.ssH(16170), typeof(DataTemplate), typeof(StandardSwitcher), new PropertyMetadata(null));
		HeaderTemplateProperty = DependencyProperty.Register(vVK.ssH(16202), typeof(DataTemplate), typeof(StandardSwitcher), new PropertyMetadata(null));
		ItemContainerStyleProperty = DependencyProperty.Register(vVK.ssH(16234), typeof(Style), typeof(StandardSwitcher), new PropertyMetadata(null));
		ItemTemplateProperty = DependencyProperty.Register(vVK.ssH(16274), typeof(DataTemplate), typeof(StandardSwitcher), new PropertyMetadata(null));
		MaxDocumentColumnCountProperty = DependencyProperty.Register(vVK.ssH(16302), typeof(int), typeof(StandardSwitcher), new PropertyMetadata(3));
		MaxRowCountProperty = DependencyProperty.Register(vVK.ssH(16350), typeof(int), typeof(StandardSwitcher), new PropertyMetadata(15));
		ScrollButtonStyleProperty = DependencyProperty.Register(vVK.ssH(16376), typeof(Style), typeof(StandardSwitcher), new PropertyMetadata(null));
		ScrollDownButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(16414), typeof(DataTemplate), typeof(StandardSwitcher), new PropertyMetadata(null));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		ScrollUpButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(16480), typeof(DataTemplate), typeof(StandardSwitcher), new PropertyMetadata(null));
		ShadowElevationProperty = DependencyProperty.Register(vVK.ssH(16542), typeof(int), typeof(StandardSwitcher), new PropertyMetadata(8));
		ToolWindowsColumnTitleProperty = DependencyProperty.Register(vVK.ssH(16576), typeof(string), typeof(StandardSwitcher), new PropertyMetadata(SR.GetString(SRName.UIStandardSwitcherToolWindowsText)));
	}

	[CompilerGenerated]
	private void JW8(object P_0)
	{
		if (xW7())
		{
			aWf++;
			zWO();
			jWJ();
		}
	}

	[CompilerGenerated]
	private bool hWD(object P_0)
	{
		return xW7();
	}

	[CompilerGenerated]
	private void kWE(object P_0)
	{
		if (rWS())
		{
			aWf--;
			zWO();
			jWJ();
		}
	}

	[CompilerGenerated]
	private bool qWr(object P_0)
	{
		return rWS();
	}

	[CompilerGenerated]
	private void sWx(object P_0)
	{
		if (vW3())
		{
			NWU++;
			zWO();
			jWJ();
		}
	}

	[CompilerGenerated]
	private bool CWl(object P_0)
	{
		return vW3();
	}

	[CompilerGenerated]
	private void oWM(object P_0)
	{
		if (NW9())
		{
			NWU--;
			zWO();
			jWJ();
		}
	}

	[CompilerGenerated]
	private bool VWv(object P_0)
	{
		return NW9();
	}

	internal static bool yH9()
	{
		return mHl == null;
	}

	internal static StandardSwitcher iHm()
	{
		return mHl;
	}
}
