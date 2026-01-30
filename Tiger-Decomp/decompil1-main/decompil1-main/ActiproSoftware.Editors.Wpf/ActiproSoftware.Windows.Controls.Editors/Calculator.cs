using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "PointerFocused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
public class Calculator : Control
{
	private enum Xdc
	{
		None,
		Add,
		Subtract,
		Multiply,
		Divide
	}

	private string JCc;

	private bool yCH;

	private CalculatorOperationKind? FCL;

	private double? oCF;

	private double tCA;

	private double OC3;

	private CalculatorOperationKind? OCy;

	private double SCm;

	private DelegateCommand<object> wCS;

	private DelegateCommand<object> AC1;

	private DelegateCommand<object> yC8;

	private DelegateCommand<object> HCr;

	private DelegateCommand<object> PCv;

	private DelegateCommand<object> JCp;

	private DelegateCommand<object> gCW;

	private DelegateCommand<object> UCi;

	private DelegateCommand<object> xCZ;

	private DelegateCommand<object> LCt;

	private DelegateCommand<object> HCn;

	private DelegateCommand<object> FCJ;

	private InputAdapter OCe;

	private bool tCk;

	private bool MCE;

	public static readonly DependencyProperty AcceptsEscapeProperty;

	public static readonly DependencyProperty DigitButtonStyleProperty;

	public static readonly DependencyProperty DisplayFontSizeProperty;

	public static readonly DependencyProperty DisplayTextProperty;

	public static readonly DependencyProperty HasDisplayProperty;

	public static readonly DependencyProperty HasMemoryButtonsProperty;

	public static readonly DependencyProperty IsOutOfRangeProperty;

	public static readonly DependencyProperty MemoryButtonStyleProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty OperationButtonStyleProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler wC7;

	internal static Calculator Ow;

	public ICommand AddToMemoryCommand
	{
		get
		{
			if (wCS == null)
			{
				wCS = new DelegateCommand<object>(delegate
				{
					Focus();
					try
					{
						OC3 = zCs(SCm);
						tCA += OC3;
						mCR(null);
					}
					catch (ArithmeticException)
					{
					}
				});
			}
			return wCS;
		}
	}

	public ICommand BackspaceCommand
	{
		get
		{
			if (AC1 == null)
			{
				AC1 = new DelegateCommand<object>(delegate
				{
					Focus();
					string text = UCK() ?? string.Empty;
					if (text.Length <= 1)
					{
						text = null;
						int num = 0;
						if (A2() != null)
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
						text = text.Substring(0, text.Length - 1);
					}
					mCR(text);
					yCX();
				});
			}
			return AC1;
		}
	}

	public ICommand CalculateCommand
	{
		get
		{
			if (yC8 == null)
			{
				yC8 = new DelegateCommand<object>(delegate
				{
					Focus();
					eVz(OCy ?? FCL);
					yCH = true;
				});
			}
			return yC8;
		}
	}

	public ICommand ClearCommand
	{
		get
		{
			if (HCr == null)
			{
				HCr = new DelegateCommand<object>(delegate
				{
					Focus();
					yCH = false;
					oCF = null;
					FCL = null;
					OCy = null;
					CCP(0.0, _0020: true);
					mCR(QdM.AR8(2092));
				});
			}
			return HCr;
		}
	}

	public ICommand ClearEntryCommand
	{
		get
		{
			if (PCv == null)
			{
				PCv = new DelegateCommand<object>(delegate
				{
					Focus();
					mCR(QdM.AR8(2092));
				});
			}
			return PCv;
		}
	}

	public ICommand ClearMemoryCommand
	{
		get
		{
			if (JCp == null)
			{
				JCp = new DelegateCommand<object>(delegate
				{
					Focus();
					tCA = 0.0;
				});
			}
			return JCp;
		}
	}

	public ICommand InsertDecimalSeparatorCommand
	{
		get
		{
			if (gCW == null)
			{
				gCW = new DelegateCommand<object>(delegate
				{
					Focus();
					string text = UCK() ?? string.Empty;
					NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
					string text2 = ((numberFormat != null) ? numberFormat.NumberDecimalSeparator : QdM.AR8(2104));
					if (!text.Contains(text2))
					{
						text += text2;
						mCR(text);
						yCX();
					}
				});
			}
			return gCW;
		}
	}

	public ICommand InsertDigitCommand
	{
		get
		{
			if (UCi == null)
			{
				UCi = new DelegateCommand<object>(delegate(object P_0)
				{
					Focus();
					if (P_0 != null && int.TryParse(P_0.ToString(), out var result))
					{
						string text = UCK() ?? string.Empty;
						if (text.Length < 15)
						{
							if (text.Length > 0 && text.StartsWith(QdM.AR8(2092), StringComparison.Ordinal))
							{
								text = text.Substring(1);
							}
							text += result.ToString(CultureInfo.InvariantCulture);
							mCR(text);
						}
					}
				});
			}
			return UCi;
		}
	}

	public ICommand OperationCommand
	{
		get
		{
			if (xCZ == null)
			{
				xCZ = new DelegateCommand<object>(delegate(object P_0)
				{
					Focus();
					if (!(P_0 is CalculatorOperationKind))
					{
						if (!(P_0 is int))
						{
							return;
						}
						P_0 = (CalculatorOperationKind)P_0;
					}
					CalculatorOperationKind calculatorOperationKind = (CalculatorOperationKind)P_0;
					if (!ACM(calculatorOperationKind))
					{
						eVz(calculatorOperationKind);
						return;
					}
					bool flag;
					int num;
					if (OCy.HasValue)
					{
						flag = string.IsNullOrEmpty(UCK());
						num = 1;
						if (!Oo())
						{
							goto IL_0005;
						}
						goto IL_0009;
					}
					yCH = false;
					goto IL_0116;
					IL_0009:
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						default:
							OCy = calculatorOperationKind;
							return;
						}
						if (!flag)
						{
							break;
						}
						num = 0;
						if (A2() == null)
						{
							continue;
						}
						goto IL_0005;
					}
					eVz(OCy);
					goto IL_0116;
					IL_0116:
					OCy = calculatorOperationKind;
					OC3 = zCs(SCm);
					mCR(null);
					return;
					IL_0005:
					int num2 = default(int);
					num = num2;
					goto IL_0009;
				});
			}
			return xCZ;
		}
	}

	public ICommand RecallMemoryCommand
	{
		get
		{
			if (LCt == null)
			{
				LCt = new DelegateCommand<object>(delegate
				{
					Focus();
					mCR(tCA.ToString(CultureInfo.CurrentCulture));
				});
			}
			return LCt;
		}
	}

	public ICommand SetMemoryCommand
	{
		get
		{
			if (HCn == null)
			{
				HCn = new DelegateCommand<object>(delegate
				{
					Focus();
					OC3 = zCs(SCm);
					tCA = OC3;
					mCR(null);
				});
			}
			return HCn;
		}
	}

	public ICommand SubtractFromMemoryCommand
	{
		get
		{
			if (FCJ == null)
			{
				FCJ = new DelegateCommand<object>(delegate
				{
					Focus();
					try
					{
						OC3 = zCs(SCm);
						tCA -= OC3;
						mCR(null);
					}
					catch (ArithmeticException)
					{
					}
				});
			}
			return FCJ;
		}
	}

	public bool AcceptsEscape
	{
		get
		{
			return (bool)GetValue(AcceptsEscapeProperty);
		}
		set
		{
			SetValue(AcceptsEscapeProperty, value);
		}
	}

	public Style DigitButtonStyle
	{
		get
		{
			return (Style)GetValue(DigitButtonStyleProperty);
		}
		set
		{
			SetValue(DigitButtonStyleProperty, value);
		}
	}

	public double DisplayFontSize
	{
		get
		{
			return (double)GetValue(DisplayFontSizeProperty);
		}
		set
		{
			SetValue(DisplayFontSizeProperty, value);
		}
	}

	public string DisplayText
	{
		get
		{
			return (string)GetValue(DisplayTextProperty);
		}
		private set
		{
			SetValue(DisplayTextProperty, value);
		}
	}

	public bool HasDisplay
	{
		get
		{
			return (bool)GetValue(HasDisplayProperty);
		}
		set
		{
			SetValue(HasDisplayProperty, value);
		}
	}

	public bool HasMemoryButtons
	{
		get
		{
			return (bool)GetValue(HasMemoryButtonsProperty);
		}
		set
		{
			SetValue(HasMemoryButtonsProperty, value);
		}
	}

	public bool IsOutOfRange
	{
		get
		{
			return (bool)GetValue(IsOutOfRangeProperty);
		}
		private set
		{
			SetValue(IsOutOfRangeProperty, value);
		}
	}

	public double Maximum
	{
		get
		{
			return (double)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Style MemoryButtonStyle
	{
		get
		{
			return (Style)GetValue(MemoryButtonStyleProperty);
		}
		set
		{
			SetValue(MemoryButtonStyleProperty, value);
		}
	}

	public double Minimum
	{
		get
		{
			return (double)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public Style OperationButtonStyle
	{
		get
		{
			return (Style)GetValue(OperationButtonStyleProperty);
		}
		set
		{
			SetValue(OperationButtonStyleProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public double Value
	{
		get
		{
			return (double)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = wC7;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wC7, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = wC7;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wC7, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private void eVz(CalculatorOperationKind? P_0)
	{
		if (!P_0.HasValue)
		{
			return;
		}
		try
		{
			CalculatorOperationKind? calculatorOperationKind = P_0;
			CalculatorOperationKind? calculatorOperationKind2 = calculatorOperationKind;
			if (calculatorOperationKind2.HasValue)
			{
				CalculatorOperationKind valueOrDefault = calculatorOperationKind2.GetValueOrDefault();
				if (valueOrDefault == CalculatorOperationKind.Percent)
				{
					sCQ();
					return;
				}
			}
			FCL = P_0.Value;
			OCy = null;
			if (ACM(FCL.Value))
			{
				double num;
				if (yCH && oCF.HasValue && !string.IsNullOrEmpty(UCK()))
				{
					OC3 = zCs(SCm);
					num = oCF.Value;
				}
				else
				{
					num = zCs(oCF ?? SCm);
				}
				switch (FCL)
				{
				case CalculatorOperationKind.Add:
					CCP(OC3 + num, _0020: true);
					break;
				case CalculatorOperationKind.Divide:
					CCP(OC3 / num, _0020: true);
					break;
				case CalculatorOperationKind.Multiply:
					CCP(OC3 * num, _0020: true);
					break;
				case CalculatorOperationKind.Subtract:
					CCP(OC3 - num, _0020: true);
					break;
				}
				mCR(null);
				oCF = num;
				yCH = false;
				return;
			}
			oCF = null;
			yCH = false;
			CalculatorOperationKind? fCL = FCL;
			CalculatorOperationKind? calculatorOperationKind3 = fCL;
			if (calculatorOperationKind3.HasValue)
			{
				switch (calculatorOperationKind3.GetValueOrDefault())
				{
				case CalculatorOperationKind.Reciprocal:
					dCV();
					break;
				case CalculatorOperationKind.SquareRoot:
					yCC();
					break;
				case CalculatorOperationKind.ToggleSign:
					cC6();
					break;
				}
			}
		}
		catch (ArithmeticException)
		{
		}
	}

	private void sCQ()
	{
		double num = zCs(0.0) / 100.0;
		mCR((OC3 * num).ToString(CultureInfo.CurrentCulture));
	}

	private void dCV()
	{
		CCP(1.0 / zCs(SCm), _0020: true);
		mCR(null);
	}

	private void yCC()
	{
		CCP(Math.Sqrt(zCs(SCm)), _0020: true);
		mCR(null);
	}

	private void cC6()
	{
		string displayText = DisplayText;
		if (displayText != QdM.AR8(2092))
		{
			if (!displayText.StartsWith(QdM.AR8(2098), StringComparison.Ordinal))
			{
				mCR(QdM.AR8(2098) + displayText);
			}
			else
			{
				mCR(displayText.Substring(1));
			}
		}
	}

	[SpecialName]
	private string UCK()
	{
		return JCc;
	}

	[SpecialName]
	private void mCR(string value)
	{
		if (JCc != value)
		{
			JCc = value;
			if (string.IsNullOrEmpty(JCc))
			{
				CCP(OC3, _0020: false);
			}
			else
			{
				CCP(zCs(0.0), _0020: false);
			}
		}
	}

	private static bool ACM(CalculatorOperationKind P_0)
	{
		if ((uint)P_0 > 3u)
		{
			return false;
		}
		return true;
	}

	private double zCs(double P_0)
	{
		if (!string.IsNullOrEmpty(JCc) && double.TryParse(JCc, NumberStyles.Number | NumberStyles.AllowExponent, CultureInfo.CurrentCulture, out var result))
		{
			return result;
		}
		return P_0;
	}

	private void jCj(double P_0, bool P_1)
	{
		if (P_1)
		{
			OC3 = P_0;
		}
		SCm = P_0;
		yCX();
	}

	private void CCP(double P_0, bool P_1)
	{
		MCE = true;
		try
		{
			double num = qdP.jDO(P_0, double.MinValue, double.MaxValue, 8);
			double num2 = (Value = qdP.jDO(P_0, Minimum, Maximum, 8));
			IsOutOfRange = num != num2;
		}
		finally
		{
			MCE = false;
		}
		jCj(P_0, P_1);
	}

	public Calculator()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Calculator);
		NC2();
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
	}

	private void NC2()
	{
		OCe = new InputAdapter(this);
		OCe.PointerPressed += gCa;
		OCe.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	private void gCa(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null)
		{
			P_1.Handled = true;
			Focus();
		}
	}

	private static void qCf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Calculator calculator = (Calculator)P_0;
		if (!calculator.MCE)
		{
			calculator.jCj(calculator.Value, _0020: true);
			calculator.JCc = calculator.SCm.ToString(CultureInfo.InvariantCulture);
		}
		calculator.SCl();
	}

	private void SCl()
	{
		wC7?.Invoke(this, EventArgs.Empty);
	}

	private void yCX()
	{
		NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
		string text = UCK() ?? string.Empty;
		string text2 = ((numberFormat != null) ? numberFormat.NumberDecimalSeparator : QdM.AR8(2104));
		int num = ((!string.IsNullOrEmpty(text2)) ? text.LastIndexOf(text2) : (-1));
		bool flag = num != -1 && num == text.Length - 1;
		int num2 = 0;
		if (num != -1)
		{
			int num3 = text.Length - 1;
			while (num3 > Math.Max(0, num) && text[num3] == '0')
			{
				num2++;
				num3--;
			}
		}
		string text3 = SCm.ToString(CultureInfo.CurrentCulture);
		if (text3.IndexOf(QdM.AR8(2110), StringComparison.OrdinalIgnoreCase) == -1)
		{
			bool flag2 = !string.IsNullOrEmpty(text2) && text3.Contains(text2);
			if (num != -1 && !flag2)
			{
				text3 += text2;
			}
			text3 += new string('0', num2);
		}
		DisplayText = text3;
	}

	private void jCx(bool P_0)
	{
		if (tCk)
		{
			if (!base.IsKeyboardFocused)
			{
				VisualStateManager.GoToState(this, QdM.AR8(2116), P_0);
			}
			else
			{
				VisualStateManager.GoToState(this, QdM.AR8(20), P_0);
			}
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(2148), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		jCx(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new CalculatorAutomationPeer(this);
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		tCk = true;
		jCx(_0020: true);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e == null || e.Handled)
		{
			return;
		}
		switch (Ad6.suc())
		{
		case ModifierKeys.None:
			switch (e.Key)
			{
			case Key.D0:
			case Key.NumPad0:
				InsertDigitCommand.Execute(QdM.AR8(2092));
				e.Handled = true;
				break;
			case Key.D1:
			case Key.NumPad1:
				InsertDigitCommand.Execute(QdM.AR8(2170));
				e.Handled = true;
				break;
			case Key.D2:
			case Key.NumPad2:
				InsertDigitCommand.Execute(QdM.AR8(2176));
				e.Handled = true;
				break;
			case Key.D3:
			case Key.NumPad3:
				InsertDigitCommand.Execute(QdM.AR8(2182));
				e.Handled = true;
				break;
			case Key.D4:
			case Key.NumPad4:
				InsertDigitCommand.Execute(QdM.AR8(2188));
				e.Handled = true;
				break;
			case Key.D5:
			case Key.NumPad5:
				InsertDigitCommand.Execute(QdM.AR8(2194));
				e.Handled = true;
				break;
			case Key.D6:
			case Key.NumPad6:
				InsertDigitCommand.Execute(QdM.AR8(2200));
				e.Handled = true;
				break;
			case Key.D7:
			case Key.NumPad7:
				InsertDigitCommand.Execute(QdM.AR8(2206));
				e.Handled = true;
				break;
			case Key.D8:
			case Key.NumPad8:
				InsertDigitCommand.Execute(QdM.AR8(2212));
				e.Handled = true;
				break;
			case Key.D9:
			case Key.NumPad9:
				InsertDigitCommand.Execute(QdM.AR8(2218));
				e.Handled = true;
				break;
			case Key.Decimal:
			case Key.OemPeriod:
				InsertDecimalSeparatorCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.Add:
				OperationCommand.Execute(CalculatorOperationKind.Add);
				e.Handled = true;
				break;
			case Key.Back:
				BackspaceCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.Delete:
				ClearEntryCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.Divide:
			case Key.Oem2:
				OperationCommand.Execute(CalculatorOperationKind.Divide);
				e.Handled = true;
				break;
			case Key.Return:
			case Key.OemPlus:
				CalculateCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.Escape:
				if (AcceptsEscape)
				{
					ClearCommand.Execute(null);
					e.Handled = true;
				}
				break;
			case Key.F9:
				OperationCommand.Execute(CalculatorOperationKind.ToggleSign);
				e.Handled = true;
				break;
			case Key.Multiply:
				OperationCommand.Execute(CalculatorOperationKind.Multiply);
				e.Handled = true;
				break;
			case Key.R:
				OperationCommand.Execute(CalculatorOperationKind.Reciprocal);
				e.Handled = true;
				break;
			case Key.Subtract:
			case Key.OemMinus:
				OperationCommand.Execute(CalculatorOperationKind.Subtract);
				e.Handled = true;
				break;
			}
			break;
		case ModifierKeys.Shift:
			switch (e.Key)
			{
			case Key.D2:
				OperationCommand.Execute(CalculatorOperationKind.SquareRoot);
				e.Handled = true;
				break;
			case Key.D5:
				OperationCommand.Execute(CalculatorOperationKind.Percent);
				e.Handled = true;
				break;
			case Key.D8:
				OperationCommand.Execute(CalculatorOperationKind.Multiply);
				e.Handled = true;
				break;
			case Key.Delete:
				ClearCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.OemPlus:
				OperationCommand.Execute(CalculatorOperationKind.Add);
				e.Handled = true;
				break;
			}
			break;
		case ModifierKeys.Control:
			switch (e.Key)
			{
			case Key.L:
				ClearMemoryCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.M:
				SetMemoryCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.P:
				AddToMemoryCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.Q:
				SubtractFromMemoryCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.R:
				RecallMemoryCommand.Execute(null);
				e.Handled = true;
				break;
			case Key.N:
			case Key.O:
				break;
			}
			break;
		case ModifierKeys.Alt:
		case ModifierKeys.Alt | ModifierKeys.Control:
			break;
		}
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		if (OCy.HasValue && !string.IsNullOrEmpty(UCK()))
		{
			eVz(OCy);
			yCH = true;
		}
		tCk = false;
		jCx(_0020: true);
	}

	static Calculator()
	{
		awj.QuEwGz();
		AcceptsEscapeProperty = DependencyProperty.Register(QdM.AR8(2224), typeof(bool), typeof(Calculator), new PropertyMetadata(true));
		DigitButtonStyleProperty = DependencyProperty.Register(QdM.AR8(2254), typeof(Style), typeof(Calculator), new PropertyMetadata(null));
		DisplayFontSizeProperty = DependencyProperty.Register(QdM.AR8(2290), typeof(double), typeof(Calculator), new PropertyMetadata(16.0));
		DisplayTextProperty = DependencyProperty.Register(QdM.AR8(2324), typeof(string), typeof(Calculator), new PropertyMetadata(QdM.AR8(2092)));
		HasDisplayProperty = DependencyProperty.Register(QdM.AR8(2350), typeof(bool), typeof(Calculator), new PropertyMetadata(true));
		HasMemoryButtonsProperty = DependencyProperty.Register(QdM.AR8(2374), typeof(bool), typeof(Calculator), new PropertyMetadata(true));
		IsOutOfRangeProperty = DependencyProperty.Register(QdM.AR8(2410), typeof(bool), typeof(Calculator), new PropertyMetadata(false));
		MemoryButtonStyleProperty = DependencyProperty.Register(QdM.AR8(2438), typeof(Style), typeof(Calculator), new PropertyMetadata(null));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(double), typeof(Calculator), new PropertyMetadata(double.MaxValue));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(double), typeof(Calculator), new PropertyMetadata(double.MinValue));
		OperationButtonStyleProperty = DependencyProperty.Register(QdM.AR8(2476), typeof(Style), typeof(Calculator), new PropertyMetadata(null));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(double), typeof(Calculator), new PropertyMetadata(0.0, qCf));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[CompilerGenerated]
	private void SC0(object P_0)
	{
		Focus();
		try
		{
			OC3 = zCs(SCm);
			tCA += OC3;
			mCR(null);
		}
		catch (ArithmeticException)
		{
		}
	}

	[CompilerGenerated]
	private void nCY(object P_0)
	{
		Focus();
		string text = UCK() ?? string.Empty;
		if (text.Length <= 1)
		{
			text = null;
			int num = 0;
			if (A2() != null)
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
			text = text.Substring(0, text.Length - 1);
		}
		mCR(text);
		yCX();
	}

	[CompilerGenerated]
	private void hCg(object P_0)
	{
		Focus();
		eVz(OCy ?? FCL);
		yCH = true;
	}

	[CompilerGenerated]
	private void WCo(object P_0)
	{
		Focus();
		yCH = false;
		oCF = null;
		FCL = null;
		OCy = null;
		CCP(0.0, _0020: true);
		mCR(QdM.AR8(2092));
	}

	[CompilerGenerated]
	private void rCO(object P_0)
	{
		Focus();
		mCR(QdM.AR8(2092));
	}

	[CompilerGenerated]
	private void oCT(object P_0)
	{
		Focus();
		tCA = 0.0;
	}

	[CompilerGenerated]
	private void DCI(object P_0)
	{
		Focus();
		string text = UCK() ?? string.Empty;
		NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
		string text2 = ((numberFormat != null) ? numberFormat.NumberDecimalSeparator : QdM.AR8(2104));
		if (!text.Contains(text2))
		{
			text += text2;
			mCR(text);
			yCX();
		}
	}

	[CompilerGenerated]
	private void XCb(object P_0)
	{
		Focus();
		if (P_0 == null || !int.TryParse(P_0.ToString(), out var result))
		{
			return;
		}
		string text = UCK() ?? string.Empty;
		if (text.Length < 15)
		{
			if (text.Length > 0 && text.StartsWith(QdM.AR8(2092), StringComparison.Ordinal))
			{
				text = text.Substring(1);
			}
			text += result.ToString(CultureInfo.InvariantCulture);
			mCR(text);
		}
	}

	[CompilerGenerated]
	private void TCD(object P_0)
	{
		Focus();
		if (!(P_0 is CalculatorOperationKind))
		{
			if (!(P_0 is int))
			{
				return;
			}
			P_0 = (CalculatorOperationKind)P_0;
		}
		CalculatorOperationKind calculatorOperationKind = (CalculatorOperationKind)P_0;
		bool flag;
		int num;
		if (ACM(calculatorOperationKind))
		{
			if (OCy.HasValue)
			{
				flag = string.IsNullOrEmpty(UCK());
				num = 1;
				if (!Oo())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			yCH = false;
			goto IL_0116;
		}
		eVz(calculatorOperationKind);
		return;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				OCy = calculatorOperationKind;
				return;
			}
			if (!flag)
			{
				break;
			}
			num = 0;
			if (A2() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		eVz(OCy);
		goto IL_0116;
		IL_0116:
		OCy = calculatorOperationKind;
		OC3 = zCs(SCm);
		mCR(null);
		return;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	[CompilerGenerated]
	private void aCG(object P_0)
	{
		Focus();
		mCR(tCA.ToString(CultureInfo.CurrentCulture));
	}

	[CompilerGenerated]
	private void gCq(object P_0)
	{
		Focus();
		OC3 = zCs(SCm);
		tCA = OC3;
		mCR(null);
	}

	[CompilerGenerated]
	private void CCu(object P_0)
	{
		Focus();
		try
		{
			OC3 = zCs(SCm);
			tCA -= OC3;
			mCR(null);
		}
		catch (ArithmeticException)
		{
		}
	}

	internal static bool Oo()
	{
		return Ow == null;
	}

	internal static Calculator A2()
	{
		return Ow;
	}
}
