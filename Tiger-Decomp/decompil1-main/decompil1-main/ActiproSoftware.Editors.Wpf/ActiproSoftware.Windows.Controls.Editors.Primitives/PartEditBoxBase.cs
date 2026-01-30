using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
[TemplateVisualState(Name = "FocusedPopup", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "FocusedNonEditable", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Focused", GroupName = "CommonStates")]
[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[TemplatePart(Name = "PART_Popup", Type = typeof(Popup))]
[TemplatePart(Name = "PART_InlinePanel", Type = typeof(PartEditBoxInlinePanel))]
[TemplatePart(Name = "PART_TextBox", Type = typeof(EmbeddedTextBox))]
public abstract class PartEditBoxBase<T> : Control
{
	private InputAdapter gIj;

	private PartEditBoxInlinePanel HIP;

	private PartEditBoxCommitTriggers VI2;

	private bool UIa;

	private bool LIf;

	private bool eIl;

	private bool BIX;

	private string BIx;

	private IList<IPart> lI0;

	private string TIY;

	private Popup cIg;

	private EmbeddedTextBox dIo;

	private DelegateCommand<object> NIO;

	private DelegateCommand<object> KIT;

	private DelegateCommand<object> BII;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty ActivePartIndexProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty CommitTriggersProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty HasPopupProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Inlines")]
	public static readonly DependencyProperty InlinesProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty InputScopeNameValueProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IntermediateValueProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsArrowKeyPartNavigationEnabledProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsEditableProperty;

	private static readonly DependencyProperty UIb;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsNullAllowedProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsPopupButtonVisibleProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsPopupOpenProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsReadOnlyProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsSpinnerVisibleProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsUndoEnabledProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty PlaceholderTextProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty PopupBackgroundProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty PopupBorderBrushProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty PopupPickerStyleProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty SpinWrappingProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty TextAlignmentProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty ValueProperty;

	private bool SID;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty IsNonDefaultUsageContextProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty SpinnerVisibilityProperty;

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static readonly DependencyProperty UsageContextProperty;

	private static object Njp;

	public int ActivePartIndex
	{
		get
		{
			return (int)GetValue(ActivePartIndexProperty);
		}
		private set
		{
			SetValue(ActivePartIndexProperty, value);
		}
	}

	public PartEditBoxCommitTriggers CommitTriggers
	{
		get
		{
			return (PartEditBoxCommitTriggers)GetValue(CommitTriggersProperty);
		}
		set
		{
			SetValue(CommitTriggersProperty, value);
		}
	}

	protected int CurrentSelectionLength => (dIo != null) ? dIo.SelectionLength : 0;

	protected int CurrentSelectionStartOffset => (dIo != null) ? dIo.SelectionStart : 0;

	protected string CurrentText
	{
		get
		{
			return (dIo != null) ? dIo.Text : string.Empty;
		}
		set
		{
			if (dIo != null)
			{
				dIo.Text = value;
			}
		}
	}

	protected virtual bool HasPopupButtonWhenReadOnly => false;

	public bool HasPopup
	{
		get
		{
			return (bool)GetValue(HasPopupProperty);
		}
		set
		{
			SetValue(HasPopupProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Inlines")]
	[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public PartEditBoxInlineCollection Inlines
	{
		get
		{
			return (PartEditBoxInlineCollection)GetValue(InlinesProperty);
		}
		set
		{
			SetValue(InlinesProperty, value);
		}
	}

	public InputScopeNameValue InputScopeNameValue
	{
		get
		{
			return (InputScopeNameValue)GetValue(InputScopeNameValueProperty);
		}
		set
		{
			SetValue(InputScopeNameValueProperty, value);
		}
	}

	public T IntermediateValue
	{
		get
		{
			return (T)GetValue(IntermediateValueProperty);
		}
		private set
		{
			SetValue(IntermediateValueProperty, value);
		}
	}

	public bool IsArrowKeyPartNavigationEnabled
	{
		get
		{
			return (bool)GetValue(IsArrowKeyPartNavigationEnabledProperty);
		}
		set
		{
			SetValue(IsArrowKeyPartNavigationEnabledProperty, value);
		}
	}

	public bool IsEditable
	{
		get
		{
			return (bool)GetValue(IsEditableProperty);
		}
		set
		{
			SetValue(IsEditableProperty, value);
		}
	}

	public bool IsNullAllowed
	{
		get
		{
			return (bool)GetValue(IsNullAllowedProperty);
		}
		set
		{
			SetValue(IsNullAllowedProperty, value);
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

	public bool IsSpinnerVisible
	{
		get
		{
			return (bool)GetValue(IsSpinnerVisibleProperty);
		}
		private set
		{
			SetValue(IsSpinnerVisibleProperty, value);
		}
	}

	public bool IsUndoEnabled
	{
		get
		{
			return (bool)GetValue(IsUndoEnabledProperty);
		}
		set
		{
			SetValue(IsUndoEnabledProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GenerateParts")]
	public IList<IPart> Parts
	{
		get
		{
			if (lI0 == null)
			{
				lI0 = GenerateParts();
				if (lI0 == null)
				{
					throw new InvalidOperationException(QdM.AR8(24730));
				}
				foreach (IPart item in lI0)
				{
					if (item == null)
					{
						throw new InvalidOperationException(QdM.AR8(24830));
					}
				}
				HTL();
				OTR();
			}
			return lI0;
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

	public Brush PopupBackground
	{
		get
		{
			return (Brush)GetValue(PopupBackgroundProperty);
		}
		set
		{
			SetValue(PopupBackgroundProperty, value);
		}
	}

	public Brush PopupBorderBrush
	{
		get
		{
			return (Brush)GetValue(PopupBorderBrushProperty);
		}
		set
		{
			SetValue(PopupBorderBrushProperty, value);
		}
	}

	public Style PopupPickerStyle
	{
		get
		{
			return (Style)GetValue(PopupPickerStyleProperty);
		}
		set
		{
			SetValue(PopupPickerStyleProperty, value);
		}
	}

	public ICommand ResetValueCommand
	{
		get
		{
			if (NIO == null)
			{
				NIO = new DelegateCommand<object>(delegate
				{
					ResetValue();
				});
			}
			return NIO;
		}
	}

	public ICommand SmallDecrementValueCommand
	{
		get
		{
			if (KIT == null)
			{
				KIT = new DelegateCommand<object>(delegate
				{
					if (!vI6())
					{
						aOB();
					}
					oTO(SOk(Key.Down));
				}, (object P_0) => JOe(IncrementalChangeRequestKind.Decrease));
			}
			return KIT;
		}
	}

	public ICommand SmallIncrementValueCommand
	{
		get
		{
			if (BII == null)
			{
				BII = new DelegateCommand<object>(delegate
				{
					if (!vI6())
					{
						aOB();
					}
					oTO(SOk(Key.Up));
				}, (object P_0) => JOe(IncrementalChangeRequestKind.Increase));
			}
			return BII;
		}
	}

	public SpinWrapping SpinWrapping
	{
		get
		{
			return (SpinWrapping)GetValue(SpinWrappingProperty);
		}
		set
		{
			SetValue(SpinWrappingProperty, value);
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

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public T Value
	{
		get
		{
			return (T)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public bool IsNonDefaultUsageContext
	{
		get
		{
			return (bool)GetValue(IsNonDefaultUsageContextProperty);
		}
		private set
		{
			SetValue(IsNonDefaultUsageContextProperty, value);
		}
	}

	public SpinnerVisibility SpinnerVisibility
	{
		get
		{
			return (SpinnerVisibility)GetValue(SpinnerVisibilityProperty);
		}
		set
		{
			SetValue(SpinnerVisibilityProperty, value);
		}
	}

	public ControlUsageContext UsageContext
	{
		get
		{
			return (ControlUsageContext)GetValue(UsageContextProperty);
		}
		set
		{
			SetValue(UsageContextProperty, value);
		}
	}

	protected PartEditBoxBase()
	{
		awj.QuEwGz();
		base._002Ector();
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
		xOJ();
		AddHandler(Mouse.PreviewMouseDownOutsideCapturedElementEvent, new MouseButtonEventHandler(qTS), handledEventsToo: true);
	}

	[SpecialName]
	internal IPart NTJ()
	{
		return nd8.MGK(Parts, ActivePartIndex);
	}

	private void xOJ()
	{
		gIj = new InputAdapter(this);
		gIj.PointerEntered += dTj;
		gIj.PointerExited += xTP;
		gIj.PointerPressed += yT2;
		gIj.PointerWheelChanged += DTa;
		gIj.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerWheelChanged;
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "kind")]
	private bool JOe(IncrementalChangeRequestKind P_0)
	{
		ISpinnablePart<T> spinnablePart = NTJ() as ISpinnablePart<T>;
		return spinnablePart != null;
	}

	private static Key SOk(Key P_0)
	{
		if ((Ad6.suc() & ModifierKeys.Shift) == ModifierKeys.Shift)
		{
			switch (P_0)
			{
			case Key.Down:
				P_0 = Key.Next;
				break;
			case Key.Up:
				P_0 = Key.Prior;
				break;
			}
		}
		return P_0;
	}

	private static object ROE(DependencyObject P_0, object P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		return partEditBoxBase.CoerceValidValue((T)P_1);
	}

	private bool VO7(PartEditBoxCommitTriggers P_0)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (flag)
					{
						bool allowTextUpdate = true;
						if (P_0 == PartEditBoxCommitTriggers.ActivePartChange || P_0 == PartEditBoxCommitTriggers.StringValueChange)
						{
							allowTextUpdate = false;
						}
						return Commit(allowTextUpdate);
					}
					return false;
				case 1:
					break;
				}
				flag = (CommitTriggers & P_0) == P_0;
				num2 = 0;
			}
			while (xj4());
		}
	}

	internal void kO4()
	{
		bool flag = !IsNullAllowed && Value == null;
		int num = 0;
		if (!xj4())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			BindingExpression bindingExpression = GetBindingExpression(ValueProperty);
			if (bindingExpression == null || bindingExpression.Status != BindingStatus.Unattached)
			{
				ResetValue();
			}
		}
	}

	private void aOB()
	{
		if (IsEditable && dIo != null && dIo.Visibility == Visibility.Visible)
		{
			dIo.Focus();
		}
		else
		{
			Focus();
		}
	}

	[SpecialName]
	private PartEditBoxInlinePanel uTk()
	{
		return HIP;
	}

	[SpecialName]
	private void FTE(PartEditBoxInlinePanel value)
	{
		if (HIP != value)
		{
			TT9(_0020: true);
			HIP = value;
			TT9(_0020: false);
		}
	}

	private void UOh()
	{
		if (KIT != null)
		{
			KIT.RaiseCanExecuteChanged();
		}
		if (BII != null)
		{
			BII.RaiseCanExecuteChanged();
		}
	}

	private static bool cOw(DependencyObject P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(24604));
		}
		return (bool)P_0.GetValue(UIb);
	}

	private static void OON(DependencyObject P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(24604));
		}
		P_0.SetValue(UIb, P_1);
	}

	private static void xOU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.OTR();
	}

	private static void dOz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.HTF();
	}

	private static void aTQ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.TT9(_0020: false);
	}

	private static void zTV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.OnIntermediateValueChanged((T)P_1.OldValue, (T)P_1.NewValue);
		PartEditBoxCommitTriggers vI = partEditBoxBase.VI2;
		if (vI != PartEditBoxCommitTriggers.None)
		{
			partEditBoxBase.VI2 = PartEditBoxCommitTriggers.None;
			partEditBoxBase.VO7(vI);
		}
	}

	private static void yTC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.IsTabStop = !partEditBoxBase.IsEditable;
	}

	private static void mT6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.OnIsNullAllowedChanged((bool)P_1.OldValue, (bool)P_1.NewValue);
		partEditBoxBase.kO4();
	}

	private static void fTM(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		if (true.Equals(P_1.NewValue))
		{
			Mouse.Capture(partEditBoxBase, CaptureMode.SubTree);
		}
		else if (Mouse.Captured == partEditBoxBase)
		{
			Mouse.Capture(null);
		}
		partEditBoxBase.UTy(_0020: true);
	}

	private static void NTs(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.UTA();
		partEditBoxBase.HTF();
	}

	private void dTj(object P_0, InputPointerEventArgs P_1)
	{
		LIf = true;
		UTy(_0020: true);
		UTA();
	}

	private void xTP(object P_0, InputPointerEventArgs P_1)
	{
		LIf = false;
		UTy(_0020: true);
		UTA();
	}

	private void yT2(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (!IsEditable)
		{
			aOB();
			P_1.Handled = true;
			if (IsPopupButtonVisible)
			{
				IsPopupOpen = !IsPopupOpen;
				SID = true;
			}
		}
	}

	private void DTa(object P_0, InputPointerWheelEventArgs P_1)
	{
		if (P_1 != null)
		{
			P_1.Handled = IsPopupOpen;
		}
		if (IsReadOnly)
		{
			return;
		}
		int num;
		if (IsEditable && MTw() != null)
		{
			num = 0;
			if (xj4())
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0049;
		IL_001b:
		if (P_1 != null)
		{
			P_1.Handled = true;
		}
		oTO(SOk((P_1.Delta < 0) ? Key.Down : Key.Up));
		num = 0;
		if (!xj4())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		if (Ad6.cuR() == MTw())
		{
			goto IL_001b;
		}
		goto IL_0049;
		IL_0049:
		if (IsEditable || !UIa || Parts == null || Parts.Count != 1 || !NTJ().IsEditable)
		{
			return;
		}
		goto IL_001b;
	}

	private void WTf(object P_0, object P_1)
	{
		if (cIg != null && cIg.IsKeyboardFocusWithin)
		{
			aOB();
		}
		if (IsPopupOpen)
		{
			IsPopupOpen = false;
		}
	}

	private void UTl(object P_0, object P_1)
	{
		if (cIg != null && cIg.Child != null)
		{
			VisualTreeHelperExtended.GetFirstTabStopDescendant(cIg.Child)?.Focus();
			OnPopupOpened();
		}
	}

	private void iTX(object P_0, RoutedEventArgs P_1)
	{
		BIx = CurrentText;
		rTb();
	}

	private void jTx(object P_0, RoutedEventArgs P_1)
	{
		if (CurrentText != BIx && !aT3(_0020: true))
		{
			QTc();
		}
	}

	private void OT0(object P_0, KeyEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled)
		{
			return;
		}
		if (IsPopupButtonVisible && Ad6.tud(P_1, Key.Down))
		{
			P_1.Handled = true;
			IsPopupOpen = true;
			return;
		}
		switch (P_1.Key)
		{
		case Key.Prior:
		case Key.Next:
		case Key.Up:
		case Key.Down:
			if (!IsReadOnly)
			{
				P_1.Handled = true;
				oTO(SOk(P_1.Key));
			}
			break;
		case Key.Return:
			if (!IsReadOnly)
			{
				P_1.Handled = VO7(PartEditBoxCommitTriggers.EnterKeyDown);
			}
			break;
		case Key.Escape:
			if (!IsReadOnly)
			{
				P_1.Handled = QTc();
			}
			break;
		case Key.Left:
			P_1.Handled = iTT();
			break;
		case Key.Right:
			P_1.Handled = lTI();
			break;
		}
	}

	private void GTY(object P_0, RoutedEventArgs P_1)
	{
		HTL();
		if (jTd() && !eIl)
		{
			ETH(PartEditBoxCommitTriggers.ActivePartChange);
		}
	}

	private void CTg(object P_0, TextChangedEventArgs P_1)
	{
		HTL();
		if (!eIl)
		{
			ETH(PartEditBoxCommitTriggers.StringValueChange);
		}
	}

	private static void pTo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		if (!partEditBoxBase.BIX)
		{
			partEditBoxBase.QTc();
		}
		partEditBoxBase.OnValueChanged((T)P_1.OldValue, (T)P_1.NewValue);
		partEditBoxBase.RaiseValueChangedEvent();
	}

	[SpecialName]
	private Popup jT4()
	{
		return cIg;
	}

	[SpecialName]
	private void oTB(Popup value)
	{
		if (cIg == value)
		{
			return;
		}
		if (cIg != null)
		{
			cIg.Closed -= WTf;
			cIg.Opened -= UTl;
		}
		cIg = value;
		bool flag = cIg != null;
		int num = 0;
		if (!xj4())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			cIg.Closed += WTf;
			cIg.Opened += UTl;
		}
	}

	private bool oTO(Key P_0)
	{
		if (!(NTJ() is ISpinnablePart<T> spinnablePart))
		{
			goto IL_00ee;
		}
		ETH(PartEditBoxCommitTriggers.None);
		IncrementalChangeRequest<T> incrementalChangeRequest = null;
		int num;
		if (P_0 <= Key.Next)
		{
			if (P_0 != Key.Prior)
			{
				num = 3;
			}
			else
			{
				incrementalChangeRequest = CreateIncrementalChangeRequest(IncrementalChangeRequestKind.MultipleIncrease);
				num = 1;
				if (oj0() != null)
				{
					goto IL_0005;
				}
			}
			goto IL_0009;
		}
		if (P_0 == Key.Up)
		{
			incrementalChangeRequest = CreateIncrementalChangeRequest(IncrementalChangeRequestKind.Increase);
		}
		else if (P_0 == Key.Down)
		{
			incrementalChangeRequest = CreateIncrementalChangeRequest(IncrementalChangeRequestKind.Decrease);
		}
		goto IL_0175;
		IL_026a:
		IPart part = default(IPart);
		MTw().Select(part.StartOffset, part.Length);
		goto IL_00ee;
		IL_00ee:
		return false;
		IL_01b3:
		Value = incrementalChangeRequest.Value;
		goto IL_00e0;
		IL_00e0:
		HTL();
		int activePartIndex = default(int);
		part = nd8.MGK(Parts, activePartIndex);
		if (part != null)
		{
			num = 0;
			if (!xj4())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_00ee;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 3:
			if (P_0 == Key.Next)
			{
				incrementalChangeRequest = CreateIncrementalChangeRequest(IncrementalChangeRequestKind.MultipleDecrease);
			}
			break;
		case 1:
			break;
		case 2:
			goto IL_01b3;
		default:
			goto IL_026a;
		}
		goto IL_0175;
		IL_0175:
		if (incrementalChangeRequest == null || (incrementalChangeRequest.Kind != IncrementalChangeRequestKind.None && !spinnablePart.ApplyIncrementalChange(incrementalChangeRequest)) || MTw() == null)
		{
			goto IL_00ee;
		}
		activePartIndex = ActivePartIndex;
		if (IsEditable)
		{
			OT5(incrementalChangeRequest.Value);
			VO7(PartEditBoxCommitTriggers.SpinnerChange);
			goto IL_00e0;
		}
		goto IL_01b3;
	}

	private bool iTT()
	{
		if (!IsArrowKeyPartNavigationEnabled)
		{
			return false;
		}
		if (Ad6.suc() != ModifierKeys.None)
		{
			return false;
		}
		IPart part = NTJ();
		if (part != null && MTw() != null)
		{
			int selectionStart = MTw().SelectionStart;
			int selectionLength = MTw().SelectionLength;
			int length = MTw().Text.Length;
			if ((selectionLength == 0 && (selectionStart == part.StartOffset || selectionStart == length)) || (selectionLength == part.Length && selectionStart == part.StartOffset))
			{
				int num = ActivePartIndex - ((selectionStart != length) ? 1 : 0);
				return LTG(num);
			}
		}
		return false;
	}

	private bool lTI()
	{
		if (!IsArrowKeyPartNavigationEnabled)
		{
			return false;
		}
		if (Ad6.suc() != ModifierKeys.None)
		{
			return false;
		}
		IPart part = NTJ();
		if (part != null && MTw() != null)
		{
			int selectionStart = MTw().SelectionStart;
			int selectionLength = MTw().SelectionLength;
			if ((selectionLength == 0 && (selectionStart == 0 || selectionStart == part.StartOffset + part.Length)) || (selectionLength == part.Length && selectionStart == part.StartOffset))
			{
				int num = ActivePartIndex + ((selectionStart != 0 || selectionLength != 0) ? 1 : 0);
				return gTD(num);
			}
		}
		return false;
	}

	private void rTb()
	{
		if (MTw() != null && MTw().SelectionLength == 0 && Ad6.pu5(Key.Tab))
		{
			gTD(ActivePartIndex);
		}
	}

	private bool gTD(int P_0)
	{
		int num2 = default(int);
		for (int i = P_0; i < Parts.Count; i++)
		{
			IPart part = nd8.MGK(Parts, i);
			if (part != null && part.IsEditable && part.Length > 0)
			{
				MTw().Select(part.StartOffset, part.Length);
				int num = 0;
				if (!xj4())
				{
					num = num2;
				}
				return num switch
				{
					_ => true, 
				};
			}
		}
		return false;
	}

	private bool LTG(int P_0)
	{
		for (int num = P_0; num >= 0; num--)
		{
			IPart part = nd8.MGK(Parts, num);
			if (part != null && part.IsEditable && part.Length > 0)
			{
				MTw().Select(part.StartOffset, part.Length);
				return true;
			}
		}
		return false;
	}

	private void UTq(string P_0, bool P_1)
	{
		P_0 = P_0 ?? string.Empty;
		eIl = true;
		try
		{
			P_1 &= MTw() != null;
			int num = (P_1 ? Math.Min(MTw().SelectionStart, P_0.Length) : 0);
			int length = (P_1 ? Math.Min(MTw().SelectionLength, P_0.Length - num) : 0);
			CurrentText = P_0;
			if (P_1)
			{
				MTw().Select(num, length);
			}
		}
		finally
		{
			eIl = false;
		}
	}

	internal void LTu(IPart P_0, string P_1, int P_2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(24614));
		}
		P_1 = P_1 ?? string.Empty;
		string currentText = CurrentText;
		int num = Math.Max(0, currentText.Length - (P_0.StartOffset + P_0.Length));
		currentText = ((P_0.StartOffset > 0) ? currentText.Substring(0, P_0.StartOffset) : string.Empty) + P_1 + ((num > 0) ? currentText.Substring(currentText.Length - num) : string.Empty);
		eIl = true;
		try
		{
			CurrentText = currentText;
			if (MTw() != null && P_2 <= P_1.Length)
			{
				MTw().Select(P_0.StartOffset + P_2, P_1.Length - P_2);
			}
		}
		finally
		{
			eIl = false;
		}
	}

	private void NTK(T xL)
	{
		BIX = true;
		try
		{
			Value = xL;
		}
		finally
		{
			BIX = false;
		}
	}

	[SpecialName]
	internal EmbeddedTextBox MTw()
	{
		return dIo;
	}

	[SpecialName]
	internal void FTN(EmbeddedTextBox value)
	{
		if (dIo == value)
		{
			return;
		}
		if (dIo != null)
		{
			dIo.GotFocus -= iTX;
			dIo.IsKeyboardFocusWithinChanged -= IT8;
			dIo.PreviewKeyDown -= OT0;
			dIo.PreviewMouseDoubleClick -= JTr;
			dIo.PreviewTextInput -= VTv;
			dIo.SelectionChanged -= GTY;
			dIo.TextChanged -= CTg;
		}
		dIo = value;
		bool flag = dIo != null;
		int num = 0;
		if (oj0() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				dIo.TextChanged += CTg;
				return;
			}
			if (!flag)
			{
				return;
			}
			dIo.GotFocus += iTX;
			dIo.IsKeyboardFocusWithinChanged += IT8;
			dIo.PreviewKeyDown += OT0;
			dIo.PreviewMouseDoubleClick += JTr;
			dIo.PreviewTextInput += VTv;
			dIo.SelectionChanged += GTY;
			num = 1;
			if (xj4())
			{
				continue;
			}
			break;
		}
		goto IL_0005;
	}

	private void OTR()
	{
		UOh();
	}

	private bool jTd()
	{
		int activePartIndex = ActivePartIndex;
		int num = ((dIo != null) ? dIo.SelectionStart : 0);
		ActivePartIndex = nd8.sGu(Parts, num);
		return ActivePartIndex != activePartIndex;
	}

	private void TT9(bool P_0)
	{
		if (HIP == null)
		{
			return;
		}
		int num = HIP.Children.Count;
		for (int num2 = HIP.Children.Count - 1; num2 >= 0; num2--)
		{
			UIElement uIElement = HIP.Children[num2];
			if (uIElement != null)
			{
				if (cOw(uIElement))
				{
					HIP.Children.RemoveAt(num2);
					num--;
				}
				else if (uIElement is DropDownButton)
				{
					num = num2;
				}
			}
		}
		if (P_0)
		{
			return;
		}
		PartEditBoxInlineCollection inlines = Inlines;
		if (inlines == null || inlines.Count <= 0)
		{
			return;
		}
		foreach (PartEditBoxInline item in inlines)
		{
			if (item.ContentTemplate != null)
			{
				ContentPresenter contentPresenter = new ContentPresenter();
				OON(contentPresenter, _0020: true);
				contentPresenter.ContentTemplate = item.ContentTemplate;
				contentPresenter.Content = new WeakReference(this);
				HIP.Children.Insert(num++, contentPresenter);
			}
		}
	}

	private bool OT5(T HX)
	{
		IntermediateValue = HX;
		string text = ConvertToString(HX);
		if (CurrentText != text)
		{
			UTq(text, _0020: true);
			return true;
		}
		return false;
	}

	internal bool QTc()
	{
		IntermediateValue = Value;
		BIx = ConvertToString(Value);
		if (CurrentText != BIx)
		{
			UTq(BIx, _0020: true);
			return true;
		}
		return false;
	}

	private bool ETH(PartEditBoxCommitTriggers P_0)
	{
		string textToConvert = CurrentText.Trim();
		bool result;
		if (TryConvertFromString(textToConvert, canCoerce: false, out var value))
		{
			try
			{
				VI2 = P_0;
				IntermediateValue = value;
			}
			finally
			{
				VI2 = PartEditBoxCommitTriggers.None;
			}
			result = true;
			int num = 0;
			if (!xj4())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	private void HTL()
	{
		if (!(CurrentText == TIY))
		{
			TIY = CurrentText;
			nd8.oGR(Parts, TIY);
		}
	}

	private void HTF()
	{
		IsPopupButtonVisible = HasPopup && jT4() != null && (!IsReadOnly || HasPopupButtonWhenReadOnly);
	}

	private void UTA()
	{
		bool flag = false;
		SpinnerVisibility spinnerVisibility = SpinnerVisibility;
		SpinnerVisibility spinnerVisibility2 = spinnerVisibility;
		if (spinnerVisibility2 == SpinnerVisibility.Visible)
		{
			flag = true;
		}
		else
		{
			int num = 0;
			if (oj0() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (spinnerVisibility2 == SpinnerVisibility.VisibleWhenActive)
			{
				flag = base.IsKeyboardFocusWithin || LIf;
			}
		}
		IsSpinnerVisible = flag && !IsReadOnly;
	}

	private bool aT3(bool P_0)
	{
		string textToConvert = CurrentText.Trim();
		if (!TryConvertFromString(textToConvert, P_0, out var value))
		{
			return false;
		}
		if (!IsValidValue(value))
		{
			int num = 0;
			if (oj0() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => false, 
			};
		}
		NTK(value);
		if (P_0)
		{
			QTc();
		}
		return true;
	}

	private void UTy(bool P_0)
	{
		if (!base.IsEnabled)
		{
			VisualStateManager.GoToState(this, QdM.AR8(0), P_0);
		}
		else if (IsPopupOpen)
		{
			VisualStateManager.GoToState(this, QdM.AR8(24626), P_0);
		}
		else if (UIa)
		{
			VisualStateManager.GoToState(this, IsEditable ? QdM.AR8(20) : QdM.AR8(24654), P_0);
		}
		else if (LIf)
		{
			VisualStateManager.GoToState(this, QdM.AR8(38), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(64), P_0);
		}
	}

	protected virtual T CoerceValidValue(T value)
	{
		return value;
	}

	public bool Commit()
	{
		return Commit(allowTextUpdate: true);
	}

	public bool Commit(bool allowTextUpdate)
	{
		T value = Value;
		if (!aT3(allowTextUpdate))
		{
			return false;
		}
		if (value == null)
		{
			return Value == null;
		}
		return !value.Equals(Value);
	}

	protected internal abstract string ConvertToString(T valueToConvert);

	protected abstract IncrementalChangeRequest<T> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind);

	protected abstract IList<IPart> GenerateParts();

	protected void InvalidateParts()
	{
		lI0 = null;
		TIY = null;
	}

	protected abstract bool IsValidValue(T value);

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		FTE(GetTemplateChild(QdM.AR8(24694)) as PartEditBoxInlinePanel);
		oTB(GetTemplateChild(QdM.AR8(80)) as Popup);
		FTN(GetTemplateChild(QdM.AR8(134)) as EmbeddedTextBox);
		if (DependencyPropertyHelper.GetValueSource(this, ValueProperty).BaseValueSource == BaseValueSource.Default)
		{
			kO4();
		}
		HTF();
		QTc();
		int num = 0;
		if (oj0() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		UTy(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new PartEditBoxBaseAutomationPeer<T>(this);
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		UIa = true;
		if (e != null && e.OriginalSource == this && IsEditable && dIo != null)
		{
			dIo.Focus();
		}
		UTy(_0020: true);
	}

	protected virtual void OnIntermediateValueChanged(T oldValue, T newValue)
	{
	}

	protected virtual void OnIsNullAllowedChanged(bool oldValue, bool newValue)
	{
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e == null || e.Handled)
		{
			return;
		}
		if (IsPopupOpen)
		{
			switch (e.Key)
			{
			case Key.Return:
			case Key.Escape:
				e.Handled = true;
				IsPopupOpen = false;
				return;
			case Key.Left:
			case Key.Up:
			case Key.Right:
			case Key.Down:
				if (cIg != null && cIg.IsKeyboardFocusWithin)
				{
					e.Handled = true;
					return;
				}
				break;
			}
			if (Ad6.tud(e, Key.Up))
			{
				e.Handled = true;
				IsPopupOpen = false;
				return;
			}
		}
		if (IsPopupButtonVisible && Ad6.tud(e, Key.Down))
		{
			e.Handled = true;
			IsPopupOpen = true;
		}
		else
		{
			if (IsEditable)
			{
				return;
			}
			switch (e.Key)
			{
			case Key.Prior:
			case Key.Next:
			case Key.Up:
			case Key.Down:
				if (!IsReadOnly && Parts != null && Parts.Count == 1 && NTJ().IsEditable)
				{
					e.Handled = true;
					oTO(SOk(e.Key));
				}
				break;
			case Key.C:
			case Key.X:
				if (Ad6.suc() != ModifierKeys.Control)
				{
					break;
				}
				try
				{
					Ad6.tuu(CurrentText);
					if (e.Key == Key.X && !IsReadOnly)
					{
						ResetValue();
					}
					e.Handled = true;
					break;
				}
				catch
				{
					break;
				}
			case Key.V:
				if (Ad6.suc() != ModifierKeys.Control || IsReadOnly)
				{
					break;
				}
				try
				{
					string text = Ad6.FuK();
					if (!string.IsNullOrEmpty(text) && TryConvertFromString(text, canCoerce: true, out var value))
					{
						Value = value;
					}
					e.Handled = true;
					break;
				}
				catch
				{
					break;
				}
			}
		}
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		UIa = false;
		UTy(_0020: true);
	}

	protected virtual void OnPopupOpened()
	{
	}

	protected virtual void OnValueChanged(T oldValue, T newValue)
	{
	}

	protected virtual bool ProcessTextInput(string text)
	{
		return false;
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected abstract void RaiseValueChangedEvent();

	protected abstract void ResetValue();

	public void SelectAll()
	{
		if (dIo != null)
		{
			dIo.SelectAll();
		}
	}

	protected internal abstract bool TryConvertFromString(string textToConvert, bool canCoerce, out T value);

	private static bool bTm(DependencyObject P_0, DependencyObject P_1)
	{
		DependencyObject dependencyObject = P_1;
		while (dependencyObject != null)
		{
			if (dependencyObject == P_0)
			{
				return true;
			}
			for (FrameworkContentElement frameworkContentElement = dependencyObject as FrameworkContentElement; frameworkContentElement != null; frameworkContentElement = dependencyObject as FrameworkContentElement)
			{
				dependencyObject = frameworkContentElement.Parent;
			}
			if (!(dependencyObject is Visual))
			{
				continue;
			}
			DependencyObject dependencyObject2 = VisualTreeHelper.GetParent(dependencyObject);
			if (dependencyObject2 == null && dependencyObject != null && LogicalTreeHelper.GetParent(dependencyObject) is Popup popup)
			{
				dependencyObject2 = popup.Parent;
				if (dependencyObject2 == null)
				{
					dependencyObject2 = popup.PlacementTarget;
				}
			}
			dependencyObject = dependencyObject2;
		}
		return false;
	}

	[SpecialName]
	private bool vI6()
	{
		if (cIg != null && IsPopupOpen && cIg.IsKeyboardFocusWithin)
		{
			return true;
		}
		return false;
	}

	private static void qTS(object P_0, MouseButtonEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		if (P_1 != null && partEditBoxBase.IsPopupOpen && partEditBoxBase.cIg != null)
		{
			UIElement child = partEditBoxBase.cIg.Child;
			if (child != null && !VisualTreeHelperExtended.IsMouseOver(child, P_1))
			{
				partEditBoxBase.IsPopupOpen = false;
			}
		}
	}

	private static void JT1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.UTA();
	}

	private void IT8(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (dIo != null && !dIo.IsKeyboardFocusWithin)
		{
			jTx(P_0, null);
		}
	}

	private void JTr(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && dIo != null)
		{
			Point position = P_1.GetPosition(dIo);
			int characterIndexFromPoint = dIo.GetCharacterIndexFromPoint(position, snapToText: true);
			int num = nd8.sGu(Parts, characterIndexFromPoint);
			if (num >= 0 && num < Parts.Count)
			{
				IPart part = Parts[num];
				dIo.Select(part.StartOffset, part.Length);
				P_1.Handled = true;
			}
		}
	}

	private void VTv(object P_0, TextCompositionEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled)
		{
			return;
		}
		IList<IPart> parts = Parts;
		P_1.Handled = ProcessTextInput(P_1.Text);
		if (P_1.Handled)
		{
			return;
		}
		int num = ActivePartIndex + 1;
		if (num < parts.Count)
		{
			IPart part = parts[num];
			if (part.IsLiteral && !string.IsNullOrEmpty(part.StringValue) && part.StringValue.StartsWith(P_1.Text, StringComparison.OrdinalIgnoreCase))
			{
				P_1.Handled = gTD(num + 1);
			}
		}
	}

	private static void QTp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)P_0;
		partEditBoxBase.IsNonDefaultUsageContext = !ControlUsageContext.Default.Equals(P_1.NewValue);
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (false.Equals(e.NewValue) && IsPopupOpen && (cIg == null || cIg.Child == null || !cIg.Child.IsKeyboardFocusWithin))
		{
			IsPopupOpen = false;
		}
		UTA();
	}

	protected override void OnLostMouseCapture(MouseEventArgs e)
	{
		base.OnLostMouseCapture(e);
		IInputElement captured = Mouse.Captured;
		if (e == null || captured == this)
		{
			return;
		}
		if (e.OriginalSource == this)
		{
			if (captured == null && IsPopupOpen)
			{
				Mouse.Capture(this, CaptureMode.SubTree);
				e.Handled = true;
			}
			else if (!bTm(this, captured as DependencyObject))
			{
				IsPopupOpen = false;
			}
		}
		else if (bTm(this, e.OriginalSource as DependencyObject))
		{
			if (IsPopupOpen && captured == null)
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

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		base.OnMouseLeftButtonDown(e);
		if (e != null && !e.Handled && IsPopupOpen && cIg != null && cIg.Child != null && VisualTreeHelperExtended.IsMouseOver(cIg.Child, e))
		{
			e.Handled = true;
			int num = 0;
			if (oj0() != null)
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

	protected override void OnPreviewMouseUp(MouseButtonEventArgs e)
	{
		if (SID)
		{
			bool flag = e != null && !e.Handled && IsPopupOpen;
			int num = 0;
			if (!xj4())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				e.Handled = true;
			}
			SID = false;
		}
		base.OnPreviewMouseUp(e);
	}

	protected override void OnPreviewTextInput(TextCompositionEventArgs e)
	{
		if (e != null && !e.Handled && !IsEditable)
		{
			e.Handled = ProcessTextInput(e.Text);
			if (!e.Handled)
			{
			}
		}
	}

	static PartEditBoxBase()
	{
		awj.QuEwGz();
		ActivePartIndexProperty = DependencyProperty.Register(QdM.AR8(24948), typeof(int), typeof(PartEditBoxBase<T>), new PropertyMetadata(0, xOU));
		CommitTriggersProperty = DependencyProperty.Register(QdM.AR8(24982), typeof(PartEditBoxCommitTriggers), typeof(PartEditBoxBase<T>), new PropertyMetadata(PartEditBoxCommitTriggers.Default));
		HasPopupProperty = DependencyProperty.Register(QdM.AR8(25014), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(true, dOz));
		InlinesProperty = DependencyProperty.Register(QdM.AR8(25034), typeof(PartEditBoxInlineCollection), typeof(PartEditBoxBase<T>), new PropertyMetadata(null, aTQ));
		InputScopeNameValueProperty = DependencyProperty.Register(QdM.AR8(25052), typeof(InputScopeNameValue), typeof(PartEditBoxBase<T>), new PropertyMetadata(InputScopeNameValue.Default));
		IntermediateValueProperty = DependencyProperty.Register(QdM.AR8(25094), typeof(object), typeof(PartEditBoxBase<T>), new PropertyMetadata(default(T), zTV));
		IsArrowKeyPartNavigationEnabledProperty = DependencyProperty.Register(QdM.AR8(25132), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(true));
		IsEditableProperty = DependencyProperty.Register(QdM.AR8(3136), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(true, yTC));
		UIb = DependencyProperty.RegisterAttached(QdM.AR8(25198), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false));
		IsNullAllowedProperty = DependencyProperty.Register(QdM.AR8(1632), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false, mT6));
		IsPopupButtonVisibleProperty = DependencyProperty.Register(QdM.AR8(444), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false));
		IsPopupOpenProperty = DependencyProperty.Register(QdM.AR8(418), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false, fTM));
		IsReadOnlyProperty = DependencyProperty.Register(QdM.AR8(532), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false, NTs));
		IsSpinnerVisibleProperty = DependencyProperty.Register(QdM.AR8(25218), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false));
		IsUndoEnabledProperty = DependencyProperty.Register(QdM.AR8(25254), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(true));
		PlaceholderTextProperty = DependencyProperty.Register(QdM.AR8(922), typeof(string), typeof(PartEditBoxBase<T>), new PropertyMetadata(SR.GetString(SRName.UIPartEditBoxPlaceholderText)));
		PopupBackgroundProperty = DependencyProperty.Register(QdM.AR8(25284), typeof(Brush), typeof(PartEditBoxBase<T>), new PropertyMetadata(null));
		PopupBorderBrushProperty = DependencyProperty.Register(QdM.AR8(25318), typeof(Brush), typeof(PartEditBoxBase<T>), new PropertyMetadata(null));
		PopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(25354), typeof(Style), typeof(PartEditBoxBase<T>), new PropertyMetadata(null));
		SpinWrappingProperty = DependencyProperty.Register(QdM.AR8(25390), typeof(SpinWrapping), typeof(PartEditBoxBase<T>), new PropertyMetadata(SpinWrapping.NoWrap));
		TextAlignmentProperty = DependencyProperty.Register(QdM.AR8(996), typeof(TextAlignment), typeof(PartEditBoxBase<T>), new PropertyMetadata(TextAlignment.Left));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(T), typeof(PartEditBoxBase<T>), new FrameworkPropertyMetadata(default(T), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, pTo, ROE));
		IsNonDefaultUsageContextProperty = DependencyProperty.Register(QdM.AR8(25418), typeof(bool), typeof(PartEditBoxBase<T>), new PropertyMetadata(false));
		SpinnerVisibilityProperty = DependencyProperty.Register(QdM.AR8(25470), typeof(SpinnerVisibility), typeof(PartEditBoxBase<T>), new PropertyMetadata(SpinnerVisibility.Collapsed, JT1));
		UsageContextProperty = DependencyProperty.Register(QdM.AR8(25508), typeof(ControlUsageContext), typeof(PartEditBoxBase<T>), new PropertyMetadata(ControlUsageContext.Default, QTp));
	}

	[CompilerGenerated]
	private void pTW(object P_0)
	{
		ResetValue();
	}

	[CompilerGenerated]
	private void YTi(object P_0)
	{
		if (!vI6())
		{
			aOB();
		}
		oTO(SOk(Key.Down));
	}

	[CompilerGenerated]
	private bool JTZ(object P_0)
	{
		return JOe(IncrementalChangeRequestKind.Decrease);
	}

	[CompilerGenerated]
	private void tTt(object P_0)
	{
		if (!vI6())
		{
			aOB();
		}
		oTO(SOk(Key.Up));
	}

	[CompilerGenerated]
	private bool VTn(object P_0)
	{
		return JOe(IncrementalChangeRequestKind.Increase);
	}

	internal static bool xj4()
	{
		return Njp == null;
	}

	internal static object oj0()
	{
		return Njp;
	}
}
