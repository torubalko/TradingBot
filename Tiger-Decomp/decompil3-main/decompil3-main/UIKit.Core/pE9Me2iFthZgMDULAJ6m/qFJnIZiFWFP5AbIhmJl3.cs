using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;
using nC8oZVi8pvEIhb4vhIix;
using QSf8R5iuIoHg3nPXYEYS;
using UIKit.Core;

namespace pE9Me2iFthZgMDULAJ6m;

[TemplatePart(Name = "ErrorViewPopup", Type = typeof(Popup))]
public class qFJnIZiFWFP5AbIhmJl3 : TextBox
{
	private readonly DispatcherTimer Yc7i3jXjKrA;

	private Popup wwsi3EGpH4W;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<string> seRi3QOvS9e;

	public static readonly DependencyProperty Om3i3dP03rA;

	public static readonly DependencyProperty ybdi3g9uUdO;

	public static readonly DependencyProperty CGVi3RowMXy;

	public static readonly DependencyProperty fc9i36L8U1V;

	public static readonly DependencyProperty wh8i3MacXYF;

	public static readonly DependencyProperty DANi3OZl6c7;

	public static readonly DependencyProperty WIOi3qW5GSe;

	public static readonly DependencyProperty FEri3IYAFIP;

	public static readonly DependencyProperty hcUi3WS9kNF;

	public static readonly DependencyProperty hXci3twrh4c;

	public static readonly DependencyProperty cBOi3UAajMn;

	public static readonly DependencyProperty hZNi3T2fUc9;

	public static readonly DependencyProperty qbVi3yjskd3;

	public static readonly DependencyProperty LSNi3Zdo8Im;

	private bool CLni3VUTUep;

	internal static qFJnIZiFWFP5AbIhmJl3 l5YKYwXojwGVbdds3ETi;

	public string Header
	{
		get
		{
			return (string)BgSXRDXogYPdMrU8DJfj(this, Om3i3dP03rA);
		}
		set
		{
			SetValue(Om3i3dP03rA, value2);
		}
	}

	public string InfoText
	{
		get
		{
			return (string)BgSXRDXogYPdMrU8DJfj(this, ybdi3g9uUdO);
		}
		set
		{
			raKHORXoRKB4qaxAIGkU(this, ybdi3g9uUdO, text);
		}
	}

	public string Placeholder
	{
		get
		{
			return (string)GetValue(CGVi3RowMXy);
		}
		set
		{
			raKHORXoRKB4qaxAIGkU(this, CGVi3RowMXy, text);
		}
	}

	public string ErrorMessage
	{
		get
		{
			return (string)GetValue(fc9i36L8U1V);
		}
		set
		{
			SetValue(fc9i36L8U1V, value2);
		}
	}

	public bool IsValid
	{
		get
		{
			return (bool)BgSXRDXogYPdMrU8DJfj(this, wh8i3MacXYF);
		}
		set
		{
			SetValue(wh8i3MacXYF, flag);
		}
	}

	public bool IsErrorVisible
	{
		get
		{
			return (bool)GetValue(WIOi3qW5GSe);
		}
		set
		{
			SetValue(WIOi3qW5GSe, flag);
		}
	}

	public bool IsPasswordVisible
	{
		get
		{
			return (bool)GetValue(FEri3IYAFIP);
		}
		set
		{
			SetValue(FEri3IYAFIP, flag);
		}
	}

	public ICommand HideOrShowPasswordCommand
	{
		get
		{
			return (ICommand)BgSXRDXogYPdMrU8DJfj(this, hcUi3WS9kNF);
		}
		set
		{
			raKHORXoRKB4qaxAIGkU(this, hcUi3WS9kNF, command);
		}
	}

	public string LinkText
	{
		get
		{
			return (string)GetValue(hXci3twrh4c);
		}
		set
		{
			raKHORXoRKB4qaxAIGkU(this, hXci3twrh4c, text);
		}
	}

	public bool IsLinkArrowVisible
	{
		get
		{
			return (bool)GetValue(cBOi3UAajMn);
		}
		set
		{
			SetValue(cBOi3UAajMn, flag);
		}
	}

	public ICommand LinkCommand
	{
		get
		{
			return (ICommand)GetValue(hZNi3T2fUc9);
		}
		set
		{
			SetValue(hZNi3T2fUc9, value2);
		}
	}

	public object LinkCommandParameter
	{
		get
		{
			return BgSXRDXogYPdMrU8DJfj(this, qbVi3yjskd3);
		}
		set
		{
			SetValue(qbVi3yjskd3, value2);
		}
	}

	public ICommand SubmitCommand
	{
		get
		{
			return (ICommand)GetValue(LSNi3Zdo8Im);
		}
		set
		{
			SetValue(LSNi3Zdo8Im, value2);
		}
	}

	public string Password
	{
		get
		{
			return (string)GetValue(DANi3OZl6c7);
		}
		set
		{
			raKHORXoRKB4qaxAIGkU(this, DANi3OZl6c7, text);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void eyoi3LKWZPO(EventHandler<string> P_0)
	{
		EventHandler<string> eventHandler = seRi3QOvS9e;
		EventHandler<string> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<string> value = (EventHandler<string>)Delegate.Combine(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref seRi3QOvS9e, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c1Fi3evKLI3(EventHandler<string> P_0)
	{
		EventHandler<string> eventHandler = seRi3QOvS9e;
		EventHandler<string> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<string> value = (EventHandler<string>)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref seRi3QOvS9e, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public qFJnIZiFWFP5AbIhmJl3()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		CLni3VUTUep = false;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5a3bf026df2e4752aeee32ca0b5dd9a8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				DispatcherTimer dispatcherTimer = new DispatcherTimer();
				oI0kP3XodgSTHRbpvuN1(dispatcherTimer, new TimeSpan(0, 0, 0, 2));
				Yc7i3jXjKrA = dispatcherTimer;
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b0959dc81a9648239a346876bbff1f44 != 0)
				{
					num = 1;
				}
				continue;
			}
			case 3:
				return;
			case 2:
				Yc7i3jXjKrA.Tick += delegate
				{
					Y3tiF78jUAU();
				};
				num = 3;
				continue;
			}
			base.PreviewTextInput += UZSiFVwnBqU;
			base.PreviewKeyDown += YLDiFC4xHrR;
			CommandManager.AddPreviewExecutedHandler(this, X1CiFTJdCOw);
			HideOrShowPasswordCommand = new F5Ux3RiuqLSaMmKMukm1(PPuiFPWvh3E);
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 == 0)
			{
				num = 1;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		wwsi3EGpH4W = GetTemplateChild(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x735715F1 ^ 0x735713FB)) as Popup;
		base.OnApplyTemplate();
	}

	private static void u5BiFUy8nHO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		qFJnIZiFWFP5AbIhmJl3 qFJnIZiFWFP5AbIhmJl4 = P_0 as qFJnIZiFWFP5AbIhmJl3;
		bool flag = qFJnIZiFWFP5AbIhmJl4 != null;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_00e09dc7183a485ea31bd9282e0f2cd4 == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 1:
			if (!flag)
			{
				return;
			}
			break;
		}
		qFJnIZiFWFP5AbIhmJl4.rwwiFAmHFdI();
	}

	private static void X1CiFTJdCOw(object P_0, ExecutedRoutedEventArgs P_1)
	{
		int num = 6;
		bool flag = default(bool);
		string text = default(string);
		qFJnIZiFWFP5AbIhmJl3 qFJnIZiFWFP5AbIhmJl4 = default(qFJnIZiFWFP5AbIhmJl3);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (P_1.Command == ApplicationCommands.Copy)
					{
						num = 10;
						break;
					}
					if (P_1.Command != ApplicationCommands.Cut)
					{
						if (P_1.Command == ApplicationCommands.Paste)
						{
							flag = Clipboard.ContainsText(TextDataFormat.UnicodeText);
							num2 = 0;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d4dad42da098482ba0a241e15597d6a0 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					}
					num = 12;
					break;
				case 10:
					text = qFJnIZiFWFP5AbIhmJl4.Password.Substring(qFJnIZiFWFP5AbIhmJl4.SelectionStart, qFJnIZiFWFP5AbIhmJl4.SelectionLength);
					Uk6HCMXo6rAWo0LkaAyi();
					num2 = 4;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b722cf66163942b8bd102d3477674df0 == 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
					P_1.Handled = true;
					num2 = 14;
					continue;
				default:
					if (P_1.Command != RjQTSvXoUYUpLHRxkXgY())
					{
						num2 = 8;
						continue;
					}
					goto IL_02a3;
				case 1:
					if (!flag)
					{
						num = 13;
						break;
					}
					goto case 4;
				case 12:
					text2 = (string)D9f8XTXoOHy2X5YKP0mJ(qFJnIZiFWFP5AbIhmJl4.Password, qFJnIZiFWFP5AbIhmJl4.SelectionStart, qFJnIZiFWFP5AbIhmJl4.SelectionLength);
					Clipboard.Clear();
					num2 = 3;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_165393879de545558ca62c901f90f36f == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (P_1.Command == ApplicationCommands.Undo)
					{
						goto IL_02a3;
					}
					return;
				case 5:
					if (qFJnIZiFWFP5AbIhmJl4 == null)
					{
						return;
					}
					goto case 2;
				case 14:
					return;
				case 3:
					RNJ3MwXoqCIgfgIW0EqY(text2, TextDataFormat.UnicodeText);
					mUZFLuXoWsEf5XUV8gjL(qFJnIZiFWFP5AbIhmJl4, qFJnIZiFWFP5AbIhmJl4.SelectionStart, HEQfKpXoI6jlQMhrioPa(qFJnIZiFWFP5AbIhmJl4));
					P_1.Handled = true;
					return;
				case 6:
					qFJnIZiFWFP5AbIhmJl4 = P_0 as qFJnIZiFWFP5AbIhmJl3;
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a4dd3ba864e24f44bf9ef3932a4f38e3 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					Clipboard.SetText(text, TextDataFormat.UnicodeText);
					SQxLaTXoM8vjLyshQT7V(P_1, true);
					return;
				case 11:
				case 13:
					SQxLaTXoM8vjLyshQT7V(P_1, true);
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22f1d8a6a91b4fb198e1e1bbe4572bc0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					{
						string text3 = (string)Lu2lO0Xotjs1wCNo3Vut(TextDataFormat.UnicodeText);
						qFJnIZiFWFP5AbIhmJl4.dDliFrU7o7L(text3);
						num2 = 11;
						continue;
					}
					IL_02a3:
					qFJnIZiFWFP5AbIhmJl4.Y3tiF78jUAU();
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	private static void jUqiFy6TySd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		bool isOpen = default(bool);
		object newValue = default(object);
		qFJnIZiFWFP5AbIhmJl3 qFJnIZiFWFP5AbIhmJl4 = default(qFJnIZiFWFP5AbIhmJl3);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 6:
				return;
			case 2:
				isOpen = (bool)newValue;
				num3 = 1;
				goto IL_011c;
			case 4:
				return;
			case 1:
				qFJnIZiFWFP5AbIhmJl4 = P_0 as qFJnIZiFWFP5AbIhmJl3;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				newValue = P_1.NewValue;
				if (newValue is bool)
				{
					num2 = 2;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f803e8ef04c14ef097ea51825f131558 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = 0;
				goto IL_011c;
			default:
				if (qFJnIZiFWFP5AbIhmJl4 != null)
				{
					num2 = 3;
					continue;
				}
				goto IL_00e2;
			case 5:
				break;
				IL_00e2:
				num2 = 6;
				continue;
				IL_011c:
				if (num3 != 0)
				{
					break;
				}
				goto IL_00e2;
			}
			if (qFJnIZiFWFP5AbIhmJl4.wwsi3EGpH4W != null)
			{
				break;
			}
			num2 = 4;
		}
		qFJnIZiFWFP5AbIhmJl4.wwsi3EGpH4W.IsOpen = isOpen;
	}

	private static void T4FiFZPwdqs(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		bool flag2 = default(bool);
		qFJnIZiFWFP5AbIhmJl3 qFJnIZiFWFP5AbIhmJl4 = default(qFJnIZiFWFP5AbIhmJl3);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (flag2)
				{
					qFJnIZiFWFP5AbIhmJl4.Y3tiF78jUAU(_0020: true);
				}
				return;
			case 3:
				qFJnIZiFWFP5AbIhmJl4 = P_0 as qFJnIZiFWFP5AbIhmJl3;
				num2 = 2;
				continue;
			case 2:
				flag = qFJnIZiFWFP5AbIhmJl4 == null;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e45e5ac62513442e89d79a2fa6de9ea2 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (flag)
			{
				return;
			}
			flag2 = !qFJnIZiFWFP5AbIhmJl4.CLni3VUTUep;
			num2 = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0e4e3e10f47f4fbdadc4c1fff6fde999 == 0)
			{
				num2 = 1;
			}
		}
	}

	private void UZSiFVwnBqU(object P_0, TextCompositionEventArgs P_1)
	{
		SQxLaTXoM8vjLyshQT7V(P_1, true);
		dDliFrU7o7L(P_1.Text, _0020: true);
	}

	private void YLDiFC4xHrR(object P_0, KeyEventArgs P_1)
	{
		int num = 14;
		Key key = default(Key);
		Key key2 = default(Key);
		bool flag2 = default(bool);
		Key key3 = default(Key);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			Key num4;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					return;
				case 12:
					return;
				case 2:
					if (key != Key.Return)
					{
						num2 = 17;
						continue;
					}
					goto case 15;
				case 8:
					if (NnaE7aXoZlmgINKHMkXR(this) < ereiFyXoVm7J5hLG4dBU(base.Text))
					{
						num2 = 6;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 7;
				case 3:
					key = key2;
					num2 = 11;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_737065c8a4b74d1d9d7a50423d7ba3fc == 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					if (flag2)
					{
						CZMiFKB4RgI(NnaE7aXoZlmgINKHMkXR(this) - 1, 1);
						num2 = 4;
						continue;
					}
					goto case 4;
				case 7:
					if (key3 == Key.Back)
					{
						num2 = 10;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0186f9916c474408b21410971ecb054c != 0)
						{
							num2 = 6;
						}
						continue;
					}
					num3 = 0;
					break;
				case 11:
					if (flag)
					{
						SubmitCommand?.Execute(null);
						P_1.Handled = true;
						num2 = 12;
						continue;
					}
					return;
				case 13:
					num4 = MFIsfmXoTlV1TjEMLE9f(P_1);
					goto end_IL_0012;
				case 0:
					return;
				case 17:
					return;
				case 16:
					if (key > Key.Return)
					{
						switch (key)
						{
						case Key.Escape:
						case Key.Space:
							P_1.Handled = true;
							num2 = 9;
							continue;
						default:
							return;
						case Key.Delete:
							break;
						}
					}
					else if (key != Key.Back)
					{
						goto case 2;
					}
					if (base.SelectionLength > 0)
					{
						CZMiFKB4RgI(base.SelectionStart, E5BbdTXoyvfre7ZyQwHr(this));
						num2 = 6;
						continue;
					}
					goto case 1;
				case 15:
					flag = !(P_1.OriginalSource is M02cpSi83xElTeNoV0cD);
					num2 = 11;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8498c2de12f54982b39e8d73ac4157f9 == 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
				case 6:
					P_1.Handled = true;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e9984bb1541d41d58b47e3c8a388ab36 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return;
				case 18:
					CZMiFKB4RgI(base.CaretIndex, 1);
					goto case 4;
				case 14:
					if (MFIsfmXoTlV1TjEMLE9f(P_1) != Key.System)
					{
						num2 = 13;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a7f6954a72b440769776337ebaf426d5 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					num4 = P_1.SystemKey;
					goto end_IL_0012;
				case 1:
					if (key3 == Key.Delete)
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				case 10:
					num3 = ((base.CaretIndex > 0) ? 1 : 0);
					break;
				}
				flag2 = (byte)num3 != 0;
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			key3 = num4;
			key2 = key3;
			num = 3;
		}
	}

	private void dDliFrU7o7L(string P_0, bool P_1 = false)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				rwwiFAmHFdI(base.CaretIndex + ereiFyXoVm7J5hLG4dBU(P_0) - 1);
				demwTJXoKKNRejaWBSJJ(this, Math.Min(num3 + P_0.Length, ereiFyXoVm7J5hLG4dBU(Password)));
				return;
			case 3:
				Y3tiF78jUAU();
				goto IL_006b;
			case 2:
				if (flag)
				{
					PvTiFmp31TH(I55VpYXorgdJMEKjaTCn(this), E5BbdTXoyvfre7ZyQwHr(this));
					goto case 5;
				}
				num2 = 5;
				break;
			case 5:
				p8PiFhpcTtU(NnaE7aXoZlmgINKHMkXR(this), P_0);
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8e3e4338deec43e48dad5ad47c3daa41 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				if (!ujlQhbXoCLeJto9lk5yr(Yc7i3jXjKrA))
				{
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_45beddfe9d2c40369d7410b1ce3b00ea == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0139;
			case 6:
			{
				num3 = NnaE7aXoZlmgINKHMkXR(this);
				int length = Password.Length;
				num2 = 4;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_950e000f8b8e487a9fb408c5cce03cd7 != 0)
				{
					num2 = 2;
				}
				break;
			}
			default:
				{
					if (base.CaretIndex <= ereiFyXoVm7J5hLG4dBU(Password) - 1)
					{
						goto IL_006b;
					}
					goto IL_0139;
				}
				IL_006b:
				flag = base.SelectionLength > 0;
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1594731a38ca4f1ca85d192afb773766 != 0)
				{
					num2 = 2;
				}
				break;
				IL_0139:
				num2 = 3;
				break;
			}
		}
	}

	private void CZMiFKB4RgI(int P_0, int P_1)
	{
		GKGmFPXomVZwL2sro3EO(Yc7i3jXjKrA);
		PvTiFmp31TH(P_0, P_1);
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5fd60ba0c8914ea3b4e84bce73b6a8b9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		rwwiFAmHFdI();
		base.CaretIndex = P_0;
	}

	private void PvTiFmp31TH(int P_0, int P_1)
	{
		P_0 = nLTyf7Xoh670R9Gcm74M(Math.Max(0, P_0), Password.Length);
		int val = Math.Max(0, Password.Length - P_0);
		P_1 = Math.Min(AHLpfNXow2cZLfW0M6Wi(0, P_1), val);
		d5kiFwLNoEY((string)dphUbuXo7lfLFhrVEEOC(Password, P_0, P_1));
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_de599029a5c7471f9afafcb351c68d36 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void p8PiFhpcTtU(int P_0, string P_1)
	{
		P_0 = nLTyf7Xoh670R9Gcm74M(Math.Max(0, P_0), ereiFyXoVm7J5hLG4dBU(Password));
		d5kiFwLNoEY(Password.Insert(P_0, P_1));
	}

	private void d5kiFwLNoEY(string P_0)
	{
		int num = 2;
		int num2 = num;
		BindingExpression bindingExpression = default(BindingExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
			{
				CoerceValue(DANi3OZl6c7);
				EventHandler<string> eventHandler = seRi3QOvS9e;
				if (eventHandler == null)
				{
					num2 = 3;
					continue;
				}
				eventHandler(this, P_0);
				return;
			}
			case 1:
			{
				string text = Password;
				Password = P_0;
				CLni3VUTUep = false;
				if (llQ6osXo8JMCrj3fWnyt(text, P_0))
				{
					bindingExpression = GetBindingExpression(DANi3OZl6c7);
					if (bindingExpression == null)
					{
						num2 = 4;
						continue;
					}
					break;
				}
				return;
			}
			case 2:
				CLni3VUTUep = true;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_bdc18810d6a64e4595bd8812b2a35dea != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				break;
			}
			YpfiRbXoA7susyb5A5b4(bindingExpression);
			num2 = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22f1d8a6a91b4fb198e1e1bbe4572bc0 != 0)
			{
				num2 = 0;
			}
		}
	}

	private void Y3tiF78jUAU(bool P_0 = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				int caretIndex = base.CaretIndex;
				rwwiFAmHFdI();
				demwTJXoKKNRejaWBSJJ(this, P_0 ? Password.Length : caretIndex);
				return;
			}
			case 1:
				Yc7i3jXjKrA.Stop();
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2aca65174e2e4ee8910c4728495ecb10 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Pp3iF8LHI0q(int P_0)
	{
		int num = 2;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				stringBuilder = new StringBuilder(new string('•', Password.Length));
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2de1ce522cf44e4cac85a49e39c09b28 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (P_0 >= 0 && P_0 < Password.Length)
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				XturVUXoJ5GGpVAYDeVl(stringBuilder, P_0, hhWJlWXoPfhTopMWU3RJ(Password, P_0));
				Yc7i3jXjKrA.Start();
				break;
			case 0:
				return;
			}
			base.Text = stringBuilder.ToString();
			num2 = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_9e10945a24ab416eb40e04a5b259cd53 == 0)
			{
				num2 = 0;
			}
		}
	}

	private void rwwiFAmHFdI(int P_0 = -1)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (!flag)
				{
					Pp3iF8LHI0q(P_0);
					return;
				}
				base.Text = Password;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_4c8ecf325a364ca59e2eb4ef96febad8 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				flag = IsPasswordVisible;
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5763bbd513064af0bca9440b7fc08de2 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void PPuiFPWvh3E(object P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				IsPasswordVisible = !IsPasswordVisible;
				rwwiFAmHFdI();
				return;
			case 1:
				GKGmFPXomVZwL2sro3EO(Yc7i3jXjKrA);
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a863574b23b747caa2b08ae3edec8640 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static qFJnIZiFWFP5AbIhmJl3()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				hZNi3T2fUc9 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x78D396D8 ^ 0x78D39588), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)));
				num = 3;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d0223d742fec4f149986da581d0284c4 != 0)
				{
					num = 3;
				}
				break;
			case 1:
				Om3i3dP03rA = (DependencyProperty)gWfYGuXopiqMoBaoZniA(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0xAD5B8B3 ^ 0xAD5B8F7), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), RvD9NNXo3uTAwY6Lt5Mj(HQdlaAXoFoxJZ2rN4N5Z(33554467)));
				ybdi3g9uUdO = (DependencyProperty)gWfYGuXopiqMoBaoZniA(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1127423276 ^ -1127423532), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(HQdlaAXoFoxJZ2rN4N5Z(33554467)));
				CGVi3RowMXy = DependencyProperty.Register((string)emt57lXouysFD6pi61RW(0x24085900 ^ 0x24085EAE), Type.GetTypeFromHandle(HQdlaAXoFoxJZ2rN4N5Z(16777225)), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_936331747ae74ee19c9bb932c2cd39d1 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_4b7f4d393584484a8e2ed4b0d3da28af == 0)
				{
					num = 1;
				}
				break;
			case 3:
				qbVi3yjskd3 = DependencyProperty.Register((string)emt57lXouysFD6pi61RW(-1416986301 ^ -1416986071), RvD9NNXo3uTAwY6Lt5Mj(HQdlaAXoFoxJZ2rN4N5Z(16777236)), Type.GetTypeFromHandle(HQdlaAXoFoxJZ2rN4N5Z(33554467)));
				LSNi3Zdo8Im = (DependencyProperty)gWfYGuXopiqMoBaoZniA(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x1A5F1B9E ^ 0x1A5F13EC), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)));
				num = 5;
				break;
			default:
				fc9i36L8U1V = DependencyProperty.Register((string)emt57lXouysFD6pi61RW(-894902996 ^ -894903546), RvD9NNXo3uTAwY6Lt5Mj(HQdlaAXoFoxJZ2rN4N5Z(16777225)), Type.GetTypeFromHandle(HQdlaAXoFoxJZ2rN4N5Z(33554467)));
				wh8i3MacXYF = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-530053095 ^ -530051095), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)), new PropertyMetadata(true));
				num = 6;
				break;
			case 6:
				DANi3OZl6c7 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x24B0B9E6 ^ 0x24B0B1E4), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, T4FiFZPwdqs));
				WIOi3qW5GSe = DependencyProperty.Register((string)emt57lXouysFD6pi61RW(-1047165041 ^ -1047166505), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)), new PropertyMetadata(false, jUqiFy6TySd));
				FEri3IYAFIP = (DependencyProperty)umJ1CvXozHltt2Ir9mRx(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x28C965BE ^ 0x28C96DA8), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)), new PropertyMetadata(false, u5BiFUy8nHO));
				hcUi3WS9kNF = (DependencyProperty)umJ1CvXozHltt2Ir9mRx(emt57lXouysFD6pi61RW(-1309555870 ^ -1309553826), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)), new PropertyMetadata(null));
				hXci3twrh4c = (DependencyProperty)gWfYGuXopiqMoBaoZniA(emt57lXouysFD6pi61RW(0x741B85CB ^ 0x741B86DF), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554467)));
				cBOi3UAajMn = DependencyProperty.Register((string)emt57lXouysFD6pi61RW(--927068468 ^ 0x3741F21C), RvD9NNXo3uTAwY6Lt5Mj(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), RvD9NNXo3uTAwY6Lt5Mj(HQdlaAXoFoxJZ2rN4N5Z(33554467)));
				num = 2;
				break;
			case 5:
				return;
			}
		}
	}

	[CompilerGenerated]
	private void QRpiFJ4QnCb(object P_0, EventArgs P_1)
	{
		Y3tiF78jUAU();
	}

	internal static void oI0kP3XodgSTHRbpvuN1(object P_0, TimeSpan P_1)
	{
		((DispatcherTimer)P_0).Interval = P_1;
	}

	internal static bool cpy8AjXoEvIyBQPUylwm()
	{
		return l5YKYwXojwGVbdds3ETi == null;
	}

	internal static qFJnIZiFWFP5AbIhmJl3 cOBnw9XoQyBgllTvhu8O()
	{
		return l5YKYwXojwGVbdds3ETi;
	}

	internal static object BgSXRDXogYPdMrU8DJfj(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void raKHORXoRKB4qaxAIGkU(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void Uk6HCMXo6rAWo0LkaAyi()
	{
		Clipboard.Clear();
	}

	internal static void SQxLaTXoM8vjLyshQT7V(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static object D9f8XTXoOHy2X5YKP0mJ(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static void RNJ3MwXoqCIgfgIW0EqY(object P_0, TextDataFormat P_1)
	{
		Clipboard.SetText((string)P_0, P_1);
	}

	internal static int HEQfKpXoI6jlQMhrioPa(object P_0)
	{
		return ((TextBox)P_0).SelectionLength;
	}

	internal static void mUZFLuXoWsEf5XUV8gjL(object P_0, int P_1, int P_2)
	{
		((qFJnIZiFWFP5AbIhmJl3)P_0).CZMiFKB4RgI(P_1, P_2);
	}

	internal static object Lu2lO0Xotjs1wCNo3Vut(TextDataFormat P_0)
	{
		return Clipboard.GetText(P_0);
	}

	internal static object RjQTSvXoUYUpLHRxkXgY()
	{
		return ApplicationCommands.Redo;
	}

	internal static Key MFIsfmXoTlV1TjEMLE9f(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static int E5BbdTXoyvfre7ZyQwHr(object P_0)
	{
		return ((TextBox)P_0).SelectionLength;
	}

	internal static int NnaE7aXoZlmgINKHMkXR(object P_0)
	{
		return ((TextBox)P_0).CaretIndex;
	}

	internal static int ereiFyXoVm7J5hLG4dBU(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static bool ujlQhbXoCLeJto9lk5yr(object P_0)
	{
		return ((DispatcherTimer)P_0).IsEnabled;
	}

	internal static int I55VpYXorgdJMEKjaTCn(object P_0)
	{
		return ((TextBox)P_0).SelectionStart;
	}

	internal static void demwTJXoKKNRejaWBSJJ(object P_0, int P_1)
	{
		((TextBox)P_0).CaretIndex = P_1;
	}

	internal static void GKGmFPXomVZwL2sro3EO(object P_0)
	{
		((DispatcherTimer)P_0).Stop();
	}

	internal static int nLTyf7Xoh670R9Gcm74M(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int AHLpfNXow2cZLfW0M6Wi(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object dphUbuXo7lfLFhrVEEOC(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static bool llQ6osXo8JMCrj3fWnyt(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void YpfiRbXoA7susyb5A5b4(object P_0)
	{
		((BindingExpressionBase)P_0).UpdateSource();
	}

	internal static char hhWJlWXoPfhTopMWU3RJ(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static void XturVUXoJ5GGpVAYDeVl(object P_0, int P_1, char P_2)
	{
		((StringBuilder)P_0)[P_1] = P_2;
	}

	internal static RuntimeTypeHandle HQdlaAXoFoxJZ2rN4N5Z(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type RvD9NNXo3uTAwY6Lt5Mj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object gWfYGuXopiqMoBaoZniA(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static object emt57lXouysFD6pi61RW(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object umJ1CvXozHltt2Ir9mRx(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
