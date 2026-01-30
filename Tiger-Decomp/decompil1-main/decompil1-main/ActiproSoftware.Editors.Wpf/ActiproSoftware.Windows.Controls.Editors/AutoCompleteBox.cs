using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Focused", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplatePart(Name = "PART_Popup", Type = typeof(Popup))]
[TemplatePart(Name = "PART_Selector", Type = typeof(EmbeddedListBox))]
[TemplatePart(Name = "PART_TextBox", Type = typeof(EmbeddedTextBox))]
public class AutoCompleteBox : Control
{
	private InputAdapter DU;

	private DeferrableObservableCollection<object> vz;

	private Dictionary<object, IEnumerable<StringFilterCapture>> IVQ;

	private bool EVV;

	private bool BVC;

	private bool GV6;

	private bool? VVM;

	private bool TVs;

	private Popup AVj;

	private EmbeddedListBox sVP;

	private EmbeddedTextBox NV2;

	private DelegateCommand<object> qVa;

	public static readonly DependencyProperty CanSelectAllOnUpdateProperty;

	public static readonly DependencyProperty DataFilterProperty;

	public static readonly DependencyProperty DisplayMemberPathProperty;

	public static readonly DependencyProperty HasClearButtonProperty;

	public static readonly DependencyProperty HasItemsProperty;

	public static readonly DependencyProperty HasPopupButtonProperty;

	public static readonly DependencyProperty InputModeProperty;

	public static readonly DependencyProperty IsClearButtonVisibleProperty;

	public static readonly DependencyProperty IsPopupOpenProperty;

	public static readonly DependencyProperty IsPopupButtonVisibleProperty;

	public static readonly DependencyProperty IsPopupOpenedOnFocusProperty;

	public static readonly DependencyProperty IsReadOnlyProperty;

	public static readonly DependencyProperty ItemContainerStyleProperty;

	public static readonly DependencyProperty ItemContainerStyleSelectorProperty;

	public static readonly DependencyProperty ItemsSourceProperty;

	public static readonly DependencyProperty ItemTemplateProperty;

	public static readonly DependencyProperty ItemTemplateSelectorProperty;

	public static readonly DependencyProperty MaxPopupHeightProperty;

	public static readonly DependencyProperty MinCharacterCountToOpenPopupProperty;

	public static readonly DependencyProperty NoItemsContentProperty;

	public static readonly DependencyProperty NoItemsContentTemplateProperty;

	public static readonly DependencyProperty PlaceholderTextProperty;

	public static readonly DependencyProperty SelectedItemProperty;

	public static readonly DependencyProperty TextProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty TextAlignmentProperty;

	public static readonly DependencyProperty TextMemberPathProperty;

	public static readonly RoutedEvent SelectedItemChangedEvent;

	public static readonly RoutedEvent SubmittedEvent;

	public static readonly RoutedEvent SuggestionChosenEvent;

	public static readonly RoutedEvent TextChangedEvent;

	public static readonly DependencyProperty CharacterCasingProperty;

	internal static AutoCompleteBox GJ;

	public bool CanSelectAllOnUpdate
	{
		get
		{
			return (bool)GetValue(CanSelectAllOnUpdateProperty);
		}
		set
		{
			SetValue(CanSelectAllOnUpdateProperty, value);
		}
	}

	public ICommand ClearCommand
	{
		get
		{
			if (qVa == null)
			{
				qVa = new DelegateCommand<object>(delegate
				{
					Text = string.Empty;
				});
			}
			return qVa;
		}
	}

	public IDataFilter DataFilter
	{
		get
		{
			return (IDataFilter)GetValue(DataFilterProperty);
		}
		set
		{
			SetValue(DataFilterProperty, value);
		}
	}

	public string DisplayMemberPath
	{
		get
		{
			return (string)GetValue(DisplayMemberPathProperty);
		}
		set
		{
			SetValue(DisplayMemberPathProperty, value);
		}
	}

	public IEnumerable FilteredItemsSource => vz;

	protected virtual string FilterText => Text;

	public bool HasClearButton
	{
		get
		{
			return (bool)GetValue(HasClearButtonProperty);
		}
		set
		{
			SetValue(HasClearButtonProperty, value);
		}
	}

	public bool HasItems
	{
		get
		{
			return (bool)GetValue(HasItemsProperty);
		}
		private set
		{
			SetValue(HasItemsProperty, value);
		}
	}

	public bool HasPopupButton
	{
		get
		{
			return (bool)GetValue(HasPopupButtonProperty);
		}
		set
		{
			SetValue(HasPopupButtonProperty, value);
		}
	}

	public AutoCompleteBoxInputMode InputMode
	{
		get
		{
			return (AutoCompleteBoxInputMode)GetValue(InputModeProperty);
		}
		set
		{
			SetValue(InputModeProperty, value);
		}
	}

	public bool IsClearButtonVisible
	{
		get
		{
			return (bool)GetValue(IsClearButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsClearButtonVisibleProperty, value);
		}
	}

	public bool IsPopupButtonVisible
	{
		get
		{
			return (bool)GetValue(IsPopupButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsPopupButtonVisibleProperty, value);
		}
	}

	public bool IsPopupOpen
	{
		get
		{
			return (bool)GetValue(IsPopupOpenProperty);
		}
		set
		{
			SetValue(IsPopupOpenProperty, value);
		}
	}

	public bool IsPopupOpenedOnFocus
	{
		get
		{
			return (bool)GetValue(IsPopupOpenedOnFocusProperty);
		}
		set
		{
			SetValue(IsPopupOpenedOnFocusProperty, value);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return (bool)GetValue(IsReadOnlyProperty);
		}
		set
		{
			SetValue(IsReadOnlyProperty, value);
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

	public StyleSelector ItemContainerStyleSelector
	{
		get
		{
			return (StyleSelector)GetValue(ItemContainerStyleSelectorProperty);
		}
		set
		{
			SetValue(ItemContainerStyleSelectorProperty, value);
		}
	}

	public IEnumerable ItemsSource
	{
		get
		{
			return (IEnumerable)GetValue(ItemsSourceProperty);
		}
		set
		{
			SetValue(ItemsSourceProperty, value);
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

	public DataTemplateSelector ItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(ItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(ItemTemplateSelectorProperty, value);
		}
	}

	public double MaxPopupHeight
	{
		get
		{
			return (double)GetValue(MaxPopupHeightProperty);
		}
		set
		{
			SetValue(MaxPopupHeightProperty, value);
		}
	}

	public int MinCharacterCountToOpenPopup
	{
		get
		{
			return (int)GetValue(MinCharacterCountToOpenPopupProperty);
		}
		set
		{
			SetValue(MinCharacterCountToOpenPopupProperty, value);
		}
	}

	public object NoItemsContent
	{
		get
		{
			return GetValue(NoItemsContentProperty);
		}
		set
		{
			SetValue(NoItemsContentProperty, value);
		}
	}

	public DataTemplate NoItemsContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(NoItemsContentTemplateProperty);
		}
		set
		{
			SetValue(NoItemsContentTemplateProperty, value);
		}
	}

	public string PlaceholderText
	{
		get
		{
			return (string)GetValue(PlaceholderTextProperty);
		}
		set
		{
			SetValue(PlaceholderTextProperty, value);
		}
	}

	public object SelectedItem
	{
		get
		{
			return GetValue(SelectedItemProperty);
		}
		set
		{
			SetValue(SelectedItemProperty, value);
		}
	}

	public string Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public TextAlignment TextAlignment
	{
		get
		{
			return (TextAlignment)GetValue(TextAlignmentProperty);
		}
		set
		{
			SetValue(TextAlignmentProperty, value);
		}
	}

	public string TextMemberPath
	{
		get
		{
			return (string)GetValue(TextMemberPathProperty);
		}
		set
		{
			SetValue(TextMemberPathProperty, value);
		}
	}

	public CharacterCasing CharacterCasing
	{
		get
		{
			return (CharacterCasing)GetValue(CharacterCasingProperty);
		}
		set
		{
			SetValue(CharacterCasingProperty, value);
		}
	}

	public event EventHandler<AutoCompleteBoxEventArgs> SelectedItemChanged
	{
		add
		{
			AddHandler(SelectedItemChangedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectedItemChangedEvent, value);
		}
	}

	public event EventHandler<AutoCompleteBoxEventArgs> Submitted
	{
		add
		{
			AddHandler(SubmittedEvent, value);
		}
		remove
		{
			RemoveHandler(SubmittedEvent, value);
		}
	}

	public event EventHandler<AutoCompleteBoxEventArgs> SuggestionChosen
	{
		add
		{
			AddHandler(SuggestionChosenEvent, value);
		}
		remove
		{
			RemoveHandler(SuggestionChosenEvent, value);
		}
	}

	public event EventHandler<AutoCompleteBoxEventArgs> TextChanged
	{
		add
		{
			AddHandler(TextChangedEvent, value);
		}
		remove
		{
			RemoveHandler(TextChangedEvent, value);
		}
	}

	public AutoCompleteBox()
	{
		awj.QuEwGz();
		vz = new DeferrableObservableCollection<object>();
		IVQ = new Dictionary<object, IEnumerable<StringFilterCapture>>();
		base._002Ector();
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
		base.DefaultStyleKey = typeof(AutoCompleteBox);
		B6();
		base.Loaded += FO;
	}

	private void B6()
	{
		DU = new InputAdapter(this);
		DU.PointerEntered += hT;
		DU.PointerExited += bI;
		DU.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited;
	}

	[SpecialName]
	private bool ai()
	{
		return AVj != null && sVP != null && sVP.Items.Count > 0 && !IsReadOnly;
	}

	private bool dM()
	{
		if (sVP != null && sVP.SelectedItem != null)
		{
			string text = ConvertToString(sVP.SelectedItem);
			if (IsPopupOpen)
			{
				IsPopupOpen = false;
			}
			AutoCompleteBoxEventArgs e = new AutoCompleteBoxEventArgs(AutoCompleteBoxChangeReason.SuggestionChosen, sVP.SelectedItem, Text);
			e.Text = text;
			R8(e);
			if (e.Text != null)
			{
				W3(e.Text, AutoCompleteBoxChangeReason.SuggestionChosen, _0020: true, _0020: true);
				return true;
			}
		}
		return false;
	}

	private void As()
	{
		if (NV2 != null)
		{
			if (Ad6.cuR() != NV2)
			{
				int num = 0;
				if (!nh())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				NV2.Focus();
			}
		}
		else if (Ad6.cuR() != this)
		{
			Focus();
		}
	}

	internal IEnumerable<StringFilterCapture> kj(object P_0)
	{
		IEnumerable<StringFilterCapture> value = null;
		if (IVQ.TryGetValue(P_0, out value))
		{
			return value;
		}
		return null;
	}

	private Tuple<int, int, int, int> yP(ScrollViewer P_0)
	{
		int num = ((vz != null) ? vz.Count : 0);
		int num2 = (int)P_0.ViewportHeight;
		int num3 = num - (int)P_0.ExtentHeight;
		int num4 = Math.Max(0, Math.Min(num - 1, (int)P_0.VerticalOffset + num3));
		int item = Math.Max(num4, Math.Min(num - 1, num4 + num2 - 1));
		return Tuple.Create(num2, num3, num4, item);
	}

	private bool t2()
	{
		if (!VVM.HasValue)
		{
			VVM = true;
			if (AVj != null && sVP != null)
			{
				Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(sVP);
				VVM = ancestorPopup != AVj;
			}
		}
		return VVM.Value;
	}

	private bool fa()
	{
		bool result;
		if (sVP != null)
		{
			if (!t2())
			{
				if (AVj == null)
				{
					goto IL_00ac;
				}
				result = AVj.IsOpen;
			}
			else
			{
				result = true;
				int num = 0;
				if (!nh())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			goto IL_006b;
		}
		goto IL_00ac;
		IL_006b:
		return result;
		IL_00ac:
		result = false;
		goto IL_006b;
	}

	private void rf(object P_0, EventArgs P_1)
	{
		z5();
	}

	private static void Nl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		IDataFilter dataFilter = P_1.OldValue as IDataFilter;
		IDataFilter dataFilter2 = P_1.NewValue as IDataFilter;
		if (dataFilter != null)
		{
			dataFilter.FilterChanged -= autoCompleteBox.rf;
			int num = 0;
			if (xS() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (dataFilter2 != null)
		{
			dataFilter2.FilterChanged += autoCompleteBox.rf;
		}
		autoCompleteBox.z5();
	}

	private static void iX(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		autoCompleteBox.xL();
	}

	private static void fx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		autoCompleteBox.lA();
	}

	private static void j0(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		if (autoCompleteBox.IsPopupOpen)
		{
			autoCompleteBox.As();
		}
		autoCompleteBox.av(autoCompleteBox.IsPopupOpen);
		autoCompleteBox.Xm(_0020: true);
	}

	private static void qY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		autoCompleteBox.xL();
		autoCompleteBox.lA();
	}

	private void Vg(object P_0, EventArgs P_1)
	{
		z5();
	}

	private static void Oo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		INotifyCollectionChanged notifyCollectionChanged = P_1.OldValue as INotifyCollectionChanged;
		INotifyCollectionChanged notifyCollectionChanged2 = P_1.NewValue as INotifyCollectionChanged;
		if (notifyCollectionChanged != null)
		{
			notifyCollectionChanged.CollectionChanged -= autoCompleteBox.Vg;
		}
		if (notifyCollectionChanged2 != null)
		{
			notifyCollectionChanged2.CollectionChanged += autoCompleteBox.Vg;
		}
		autoCompleteBox.z5();
	}

	private void FO(object P_0, RoutedEventArgs P_1)
	{
		if (InputMode == AutoCompleteBoxInputMode.ComboBox)
		{
			bF(_0020: false);
			ty(_0020: false);
		}
	}

	private void hT(object P_0, InputPointerEventArgs P_1)
	{
		GV6 = true;
		Xm(_0020: true);
	}

	private void bI(object P_0, InputPointerEventArgs P_1)
	{
		GV6 = false;
		Xm(_0020: true);
	}

	private static void wb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		if (autoCompleteBox == null)
		{
			return;
		}
		bool flag = autoCompleteBox.InputMode == AutoCompleteBoxInputMode.ComboBox && !autoCompleteBox.IsKeyboardFocusWithin;
		int num = 0;
		if (!nh())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			autoCompleteBox.bF(_0020: false);
			autoCompleteBox.ty(_0020: false);
		}
		autoCompleteBox.yS(new AutoCompleteBoxEventArgs(AutoCompleteBoxChangeReason.ProgrammaticChange, P_1.NewValue, autoCompleteBox.Text));
	}

	private void eD(object P_0, KeyEventArgs P_1)
	{
		Dd(P_1);
	}

	private void WG(object P_0, EventArgs P_1)
	{
		string text = Text;
		dM();
		OH(AutoCompleteBoxChangeReason.SuggestionChosen, sVP.SelectedItem, text);
	}

	private void Vq(object P_0, KeyEventArgs P_1)
	{
		Dd(P_1);
	}

	private void iu(object P_0, object P_1)
	{
		if (NV2 != null)
		{
			W3(NV2.Text, AutoCompleteBoxChangeReason.UserInput, _0020: false, _0020: true);
		}
	}

	private static void LK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)P_0;
		if (autoCompleteBox != null)
		{
			autoCompleteBox.W3(autoCompleteBox.Text, AutoCompleteBoxChangeReason.ProgrammaticChange, _0020: true, _0020: true);
			autoCompleteBox.xL();
		}
	}

	private void UR()
	{
		if (!IsPopupOpen && ai() && IsPopupOpenedOnFocus)
		{
			IsPopupOpen = true;
		}
	}

	[SpecialName]
	private Popup st()
	{
		return AVj;
	}

	[SpecialName]
	private void pn(Popup value)
	{
		AVj = value;
	}

	private void Dd(KeyEventArgs P_0)
	{
		if (P_0 == null || P_0.Handled)
		{
			return;
		}
		if (ai() && Ad6.tud(P_0, Key.Down))
		{
			IsPopupOpen = true;
			As();
			P_0.Handled = true;
			return;
		}
		if (Ad6.tud(P_0, Key.Up))
		{
			As();
			IsPopupOpen = false;
			P_0.Handled = true;
			return;
		}
		switch (P_0.Key)
		{
		case Key.Down:
			if (fa())
			{
				jc(_0020: true, _0020: false);
				As();
				P_0.Handled = true;
			}
			break;
		case Key.Return:
		{
			string text = Text;
			if (fa() && dM())
			{
				OH(AutoCompleteBoxChangeReason.UserInput, sVP.SelectedItem, text);
				P_0.Handled = true;
			}
			else
			{
				OH(AutoCompleteBoxChangeReason.UserInput, null, text);
				P_0.Handled = true;
			}
			break;
		}
		case Key.Escape:
			if (IsPopupOpen)
			{
				As();
				IsPopupOpen = false;
				P_0.Handled = true;
			}
			break;
		case Key.Next:
			if (fa())
			{
				jc(_0020: true, _0020: true);
				As();
				P_0.Handled = true;
			}
			break;
		case Key.Prior:
			if (fa())
			{
				jc(_0020: false, _0020: true);
				As();
				P_0.Handled = true;
			}
			break;
		case Key.Up:
			if (fa())
			{
				jc(_0020: false, _0020: false);
				As();
				P_0.Handled = true;
			}
			break;
		}
	}

	private void u9()
	{
		try
		{
			vz.BeginUpdate();
			vz.Clear();
			IVQ.Clear();
			IEnumerable itemsSource = ItemsSource;
			if (itemsSource != null)
			{
				IDataFilter dataFilter = DataFilter;
				StringFilterBase stringFilterBase = dataFilter as StringFilterBase;
				string filterText = FilterText;
				foreach (object item in itemsSource)
				{
					if (dataFilter != null)
					{
						string text = ConvertToString(item);
						if (!dataFilter.IsEnabled || dataFilter.Filter(text, filterText) <= DataFilterResult.IncludedWithDescendants)
						{
							vz.Add(item);
						}
						if (item != null && stringFilterBase != null)
						{
							IVQ[item] = stringFilterBase.GetCaptures(text, filterText);
						}
					}
					else
					{
						vz.Add(item);
					}
				}
			}
		}
		finally
		{
			vz.EndUpdate();
		}
		bool flag = (HasItems = vz.Count > 0);
		if (AVj == null)
		{
			return;
		}
		if (flag || NoItemsContent != null || NoItemsContentTemplate != null)
		{
			if (BVC && !IsPopupOpen)
			{
				BVC = false;
				IsPopupOpen = true;
			}
		}
		else if (IsPopupOpen)
		{
			BVC = true;
			IsPopupOpen = false;
		}
	}

	private void z5()
	{
		if (!EVV)
		{
			EVV = true;
			base.Dispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
			{
				EVV = false;
				u9();
			});
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void jc(bool P_0, bool P_1)
	{
		if (sVP == null || sVP.Items.Count == 0)
		{
			return;
		}
		ScrollViewer scrollViewer = null;
		if (P_1)
		{
			scrollViewer = VisualTreeHelperExtended.GetDescendant<ScrollViewer>(sVP, 0);
			if (scrollViewer == null)
			{
				P_1 = false;
			}
		}
		int selectedIndex = sVP.SelectedIndex;
		int num = ((selectedIndex != -1) ? selectedIndex : 0);
		if (P_1)
		{
			Tuple<int, int, int, int> tuple = yP(scrollViewer);
			int item = tuple.Item1;
			if (P_0)
			{
				int item2 = tuple.Item4;
				selectedIndex = ((selectedIndex < item2) ? item2 : Math.Min(sVP.Items.Count - 1, selectedIndex + item - 1));
			}
			else
			{
				int item3 = tuple.Item3;
				selectedIndex = ((selectedIndex > item3) ? item3 : Math.Max(0, selectedIndex - item + 1));
			}
		}
		else
		{
			selectedIndex += (P_0 ? 1 : (-1));
		}
		int num2;
		for (num2 = (P_0 ? 1 : (-1)); selectedIndex >= 0 && selectedIndex < sVP.Items.Count; selectedIndex += num2)
		{
			sVP.ScrollIntoView(sVP.Items[selectedIndex]);
			if (sVP.ItemContainerGenerator.ContainerFromIndex(selectedIndex) is Control { IsEnabled: not false })
			{
				sVP.SelectedIndex = selectedIndex;
				return;
			}
		}
		if (selectedIndex < 0)
		{
			selectedIndex = sVP.Items.Count - 1;
		}
		else if (selectedIndex >= sVP.Items.Count)
		{
			selectedIndex = 0;
		}
		for (; selectedIndex >= 0 && selectedIndex < sVP.Items.Count && ((P_0 && selectedIndex < num) || (!P_0 && selectedIndex > num)); selectedIndex += num2)
		{
			sVP.ScrollIntoView(sVP.Items[selectedIndex]);
			if (sVP.ItemContainerGenerator.ContainerFromIndex(selectedIndex) is Control { IsEnabled: not false })
			{
				sVP.SelectedIndex = selectedIndex;
				break;
			}
		}
	}

	[SpecialName]
	private EmbeddedListBox He()
	{
		return sVP;
	}

	[SpecialName]
	private void bk(EmbeddedListBox value)
	{
		if (sVP == value)
		{
			return;
		}
		if (sVP != null)
		{
			sVP.PreviewKeyDown -= eD;
			sVP.gO2 -= WG;
		}
		sVP = value;
		int num = 0;
		if (xS() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (sVP != null)
		{
			sVP.PreviewKeyDown += eD;
			sVP.gO2 += WG;
		}
	}

	private void OH(AutoCompleteBoxChangeReason P_0, object P_1, string P_2)
	{
		if (InputMode == AutoCompleteBoxInputMode.ComboBox)
		{
			bF(_0020: false);
		}
		As();
		AutoCompleteBoxEventArgs e = new AutoCompleteBoxEventArgs(P_0, P_1, P_2);
		e.Text = Text;
		M1(e);
	}

	[SpecialName]
	private EmbeddedTextBox o7()
	{
		return NV2;
	}

	[SpecialName]
	private void g4(EmbeddedTextBox value)
	{
		if (NV2 == value)
		{
			return;
		}
		bool flag = NV2 != null;
		int num = 0;
		if (!nh())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			NV2.PreviewKeyDown -= Vq;
			NV2.TextChanged -= iu;
		}
		NV2 = value;
		if (NV2 != null)
		{
			NV2.Text = Text ?? string.Empty;
			NV2.Select(NV2.Text.Length, 0);
			NV2.PreviewKeyDown += Vq;
			NV2.TextChanged += iu;
		}
	}

	private void xL()
	{
		bool flag = InputMode != AutoCompleteBoxInputMode.ComboBox || base.IsKeyboardFocusWithin;
		IsClearButtonVisible = HasClearButton && !IsReadOnly && !string.IsNullOrEmpty(Text) && flag;
	}

	private void bF(bool P_0)
	{
		IDataFilter dataFilter = DataFilter;
		if (dataFilter != null)
		{
			dataFilter.IsEnabled = P_0;
		}
	}

	private void lA()
	{
		IsPopupButtonVisible = HasPopupButton && st() != null && !IsReadOnly;
	}

	private void W3(string P_0, AutoCompleteBoxChangeReason P_1, bool P_2, bool P_3)
	{
		if (TVs)
		{
			return;
		}
		bool flag = true;
		string text = null;
		try
		{
			string text2 = Text;
			TVs = true;
			P_0 = P_0 ?? string.Empty;
			text = P_0;
			if (Text != P_0)
			{
				Text = P_0;
			}
			if (NV2 != null)
			{
				if (NV2.Text != P_0)
				{
					NV2.Text = P_0;
				}
				if (P_2)
				{
					if (CanSelectAllOnUpdate)
					{
						NV2.SelectAll();
					}
					else
					{
						NV2.Select(NV2.Text.Length, 0);
					}
				}
			}
			if (P_3 && InputMode == AutoCompleteBoxInputMode.ComboBox)
			{
				bF(_0020: true);
			}
			AutoCompleteBoxEventArgs e = new AutoCompleteBoxEventArgs(P_1, null, text2);
			e.IsPopupAllowed = flag;
			e.Text = P_0;
			fr(e);
			flag = e.IsPopupAllowed;
			if (e.Text != null && e.Text != P_0)
			{
				text = e.Text;
			}
			else if (Text != P_0)
			{
				text = Text;
			}
		}
		finally
		{
			TVs = false;
		}
		if (text != P_0 && NV2 != null)
		{
			NV2.Text = text;
			NV2.Select(NV2.Text.Length, 0);
			return;
		}
		if (DataFilter != null)
		{
			z5();
		}
		if (flag)
		{
			if (!IsPopupOpen && ai() && P_1 == AutoCompleteBoxChangeReason.UserInput && P_0.Length >= MinCharacterCountToOpenPopup)
			{
				IsPopupOpen = true;
			}
		}
		else if (IsPopupOpen)
		{
			IsPopupOpen = false;
		}
	}

	private void ty(bool P_0)
	{
		string item;
		if (P_0 && SelectedItem != null)
		{
			IDataFilter dataFilter = DataFilter;
			if (dataFilter != null)
			{
				string filterText = FilterText;
				item = ConvertToString(SelectedItem);
				if (string.IsNullOrEmpty(filterText) || dataFilter.Filter(item, filterText) == DataFilterResult.Excluded)
				{
					SelectedItem = null;
				}
			}
		}
		item = ConvertToString(SelectedItem);
		W3(item, AutoCompleteBoxChangeReason.ProgrammaticChange, _0020: true, _0020: false);
	}

	private void Xm(bool P_0)
	{
		if (!base.IsEnabled)
		{
			VisualStateManager.GoToState(this, QdM.AR8(0), P_0);
		}
		else if (base.IsKeyboardFocusWithin)
		{
			VisualStateManager.GoToState(this, QdM.AR8(20), P_0);
		}
		else if (GV6)
		{
			VisualStateManager.GoToState(this, QdM.AR8(38), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(64), P_0);
		}
	}

	protected virtual string ConvertToString(object itemToConvert)
	{
		if (itemToConvert == null)
		{
			return string.Empty;
		}
		string textMemberPath = TextMemberPath;
		if (!string.IsNullOrEmpty(textMemberPath))
		{
			Binding binding = Ldu.EIz(itemToConvert, textMemberPath, BindingMode.OneTime, null);
			int num = 0;
			if (!nh())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				object obj = new OdX().rIN(binding, itemToConvert);
				return (obj != null) ? obj.ToString() : string.Empty;
			}
			}
		}
		return itemToConvert.ToString();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		VVM = null;
		pn(GetTemplateChild(QdM.AR8(80)) as Popup);
		bk(GetTemplateChild(QdM.AR8(104)) as EmbeddedListBox);
		g4(GetTemplateChild(QdM.AR8(134)) as EmbeddedTextBox);
		xL();
		lA();
		Xm(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AutoCompleteBoxAutomationPeer(this);
	}

	public void SelectAll()
	{
		if (NV2 != null)
		{
			NV2.SelectAll();
		}
	}

	internal void yS(AutoCompleteBoxEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = SelectedItemChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnSelectedItemChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void M1(AutoCompleteBoxEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = SubmittedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnSubmitted(P_0);
		RaiseEvent(P_0);
	}

	internal void R8(AutoCompleteBoxEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = SuggestionChosenEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnSuggestionChosen(P_0);
		RaiseEvent(P_0);
	}

	internal void fr(AutoCompleteBoxEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = TextChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnTextChanged(P_0);
		RaiseEvent(P_0);
	}

	protected virtual void OnSelectedItemChanged(AutoCompleteBoxEventArgs e)
	{
	}

	protected virtual void OnSubmitted(AutoCompleteBoxEventArgs e)
	{
	}

	protected virtual void OnSuggestionChosen(AutoCompleteBoxEventArgs e)
	{
	}

	protected virtual void OnTextChanged(AutoCompleteBoxEventArgs e)
	{
	}

	private void av(bool P_0)
	{
		bool flag = Mouse.Captured == this;
		if (P_0)
		{
			bool flag2 = !flag;
			int num = 0;
			if (!nh())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag2)
			{
				Mouse.Capture(this, CaptureMode.SubTree);
			}
		}
		else if (flag)
		{
			Mouse.Capture(null);
		}
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		if (e != null && e.OriginalSource == this && NV2 != null)
		{
			NV2.Focus();
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		bool flag = true;
		if (true.Equals(e.NewValue))
		{
			UR();
		}
		else
		{
			BVC = false;
			if (IsPopupOpen && (AVj == null || AVj.Child == null || !AVj.Child.IsKeyboardFocusWithin))
			{
				IsPopupOpen = false;
			}
			if (InputMode == AutoCompleteBoxInputMode.ComboBox)
			{
				ty(_0020: true);
				bF(_0020: false);
			}
		}
		Xm(_0020: true);
		xL();
	}

	protected override void OnLostMouseCapture(MouseEventArgs e)
	{
		base.OnLostMouseCapture(e);
		if (e == null || Mouse.Captured == this)
		{
			return;
		}
		if (e.OriginalSource == this)
		{
			if (Mouse.Captured == null || !VisualTreeHelperExtended.IsDescendant(this, Mouse.Captured as DependencyObject))
			{
				IsPopupOpen = false;
			}
		}
		else if (VisualTreeHelperExtended.IsDescendant(this, e.OriginalSource as DependencyObject))
		{
			if (IsPopupOpen && Mouse.Captured == null)
			{
				Mouse.Capture(this, CaptureMode.SubTree);
				e.Handled = true;
			}
		}
		else
		{
			IsPopupOpen = false;
		}
	}

	protected override void OnMouseWheel(MouseWheelEventArgs e)
	{
		base.OnMouseWheel(e);
		if (e != null && !e.Handled && IsPopupOpen && sVP != null && !VisualTreeHelperExtended.IsMouseOver(sVP, e))
		{
			e.Handled = true;
		}
	}

	protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
	{
		base.OnPreviewMouseDown(e);
		if (e != null && e.OriginalSource == this && Mouse.Captured == this && IsPopupOpen)
		{
			IsPopupOpen = false;
		}
	}

	static AutoCompleteBox()
	{
		awj.QuEwGz();
		CanSelectAllOnUpdateProperty = DependencyProperty.Register(QdM.AR8(162), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(true));
		DataFilterProperty = DependencyProperty.Register(QdM.AR8(206), typeof(IDataFilter), typeof(AutoCompleteBox), new PropertyMetadata(null, Nl));
		DisplayMemberPathProperty = DependencyProperty.Register(QdM.AR8(230), typeof(string), typeof(AutoCompleteBox), new PropertyMetadata(string.Empty));
		HasClearButtonProperty = DependencyProperty.Register(QdM.AR8(268), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false, iX));
		HasItemsProperty = DependencyProperty.Register(QdM.AR8(300), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false));
		HasPopupButtonProperty = DependencyProperty.Register(QdM.AR8(320), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(true, fx));
		InputModeProperty = DependencyProperty.Register(QdM.AR8(352), typeof(AutoCompleteBoxInputMode), typeof(AutoCompleteBox), new PropertyMetadata(AutoCompleteBoxInputMode.Search));
		IsClearButtonVisibleProperty = DependencyProperty.Register(QdM.AR8(374), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false));
		IsPopupOpenProperty = DependencyProperty.Register(QdM.AR8(418), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false, j0));
		IsPopupButtonVisibleProperty = DependencyProperty.Register(QdM.AR8(444), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false));
		int num = 1;
		if (false)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				IsPopupOpenedOnFocusProperty = DependencyProperty.Register(QdM.AR8(488), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false));
				IsReadOnlyProperty = DependencyProperty.Register(QdM.AR8(532), typeof(bool), typeof(AutoCompleteBox), new PropertyMetadata(false, qY));
				ItemContainerStyleProperty = DependencyProperty.Register(QdM.AR8(556), typeof(Style), typeof(AutoCompleteBox), new PropertyMetadata(null));
				ItemContainerStyleSelectorProperty = DependencyProperty.Register(QdM.AR8(596), typeof(StyleSelector), typeof(AutoCompleteBox), new PropertyMetadata(null));
				ItemsSourceProperty = DependencyProperty.Register(QdM.AR8(652), typeof(IEnumerable), typeof(AutoCompleteBox), new PropertyMetadata(null, Oo));
				ItemTemplateProperty = DependencyProperty.Register(QdM.AR8(678), typeof(DataTemplate), typeof(AutoCompleteBox), new PropertyMetadata(null));
				ItemTemplateSelectorProperty = DependencyProperty.Register(QdM.AR8(706), typeof(DataTemplateSelector), typeof(AutoCompleteBox), new PropertyMetadata(null));
				MaxPopupHeightProperty = DependencyProperty.Register(QdM.AR8(750), typeof(double), typeof(AutoCompleteBox), new PropertyMetadata(500.0));
				MinCharacterCountToOpenPopupProperty = DependencyProperty.Register(QdM.AR8(782), typeof(int), typeof(AutoCompleteBox), new PropertyMetadata(1));
				NoItemsContentProperty = DependencyProperty.Register(QdM.AR8(842), typeof(object), typeof(AutoCompleteBox), new PropertyMetadata(null));
				NoItemsContentTemplateProperty = DependencyProperty.Register(QdM.AR8(874), typeof(DataTemplate), typeof(AutoCompleteBox), new PropertyMetadata(null));
				PlaceholderTextProperty = DependencyProperty.Register(QdM.AR8(922), typeof(string), typeof(AutoCompleteBox), new PropertyMetadata(null));
				num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				SelectedItemProperty = DependencyProperty.Register(QdM.AR8(956), typeof(object), typeof(AutoCompleteBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, wb));
				TextProperty = DependencyProperty.Register(QdM.AR8(984), typeof(string), typeof(AutoCompleteBox), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, LK));
				TextAlignmentProperty = DependencyProperty.Register(QdM.AR8(996), typeof(TextAlignment), typeof(AutoCompleteBox), new PropertyMetadata(TextAlignment.Left));
				TextMemberPathProperty = DependencyProperty.Register(QdM.AR8(1026), typeof(string), typeof(AutoCompleteBox), new PropertyMetadata(string.Empty));
				SelectedItemChangedEvent = EventManager.RegisterRoutedEvent(QdM.AR8(1058), RoutingStrategy.Bubble, typeof(EventHandler<AutoCompleteBoxEventArgs>), typeof(AutoCompleteBox));
				SubmittedEvent = EventManager.RegisterRoutedEvent(QdM.AR8(1100), RoutingStrategy.Bubble, typeof(EventHandler<AutoCompleteBoxEventArgs>), typeof(AutoCompleteBox));
				SuggestionChosenEvent = EventManager.RegisterRoutedEvent(QdM.AR8(1122), RoutingStrategy.Bubble, typeof(EventHandler<AutoCompleteBoxEventArgs>), typeof(AutoCompleteBox));
				TextChangedEvent = EventManager.RegisterRoutedEvent(QdM.AR8(1158), RoutingStrategy.Bubble, typeof(EventHandler<AutoCompleteBoxEventArgs>), typeof(AutoCompleteBox));
				CharacterCasingProperty = DependencyProperty.Register(QdM.AR8(1184), typeof(CharacterCasing), typeof(AutoCompleteBox), new PropertyMetadata(CharacterCasing.Normal));
				num = 2;
				if (false)
				{
					int num2;
					num = num2;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void rp()
	{
		EVV = false;
		u9();
	}

	[CompilerGenerated]
	private void BW(object P_0)
	{
		Text = string.Empty;
	}

	internal static bool nh()
	{
		return GJ == null;
	}

	internal static AutoCompleteBox xS()
	{
		return GJ;
	}
}
