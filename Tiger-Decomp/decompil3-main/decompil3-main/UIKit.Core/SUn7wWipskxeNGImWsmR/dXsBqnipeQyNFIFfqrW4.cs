using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;
using UIKit.Core;
using xwgbvdiuOs8QddOUXrhy;

namespace SUn7wWipskxeNGImWsmR;

[TemplatePart(Name = "HoursPart", Type = typeof(Border))]
[TemplatePart(Name = "MinutesPart", Type = typeof(Border))]
[TemplatePart(Name = "SecondsPart", Type = typeof(Border))]
[TemplatePart(Name = "ErrorViewPopup", Type = typeof(Popup))]
public class dXsBqnipeQyNFIFfqrW4 : TextBox
{
	private Popup Htdiubhb3al;

	private bool yxyiuNqXjql;

	private bool giciukW1ZLw;

	private DispatcherTimer aHciu1920kS;

	public static readonly DependencyProperty W2fiu58Asfx;

	public static readonly DependencyProperty VW1iuSU0jsp;

	public static readonly DependencyProperty HKdiuxZ6sNw;

	public static readonly DependencyProperty bjPiuLUADsp;

	public static readonly DependencyProperty xTTiuetkIyf;

	public static readonly DependencyProperty kbtiusHgGTO;

	public static readonly DependencyProperty uPniuXmjvsH;

	public static readonly DependencyProperty dJAiucdcotJ;

	public static readonly DependencyProperty yqciuj81bhP;

	public static readonly DependencyProperty Ug7iuEi7kIg;

	public static readonly DependencyProperty Ng3iuQGShCr;

	public static readonly DependencyProperty wKqiudm4O5k;

	public static readonly DependencyProperty IsSmallProperty;

	public static readonly DependencyProperty aVRiugycBvg;

	public static readonly DependencyProperty RIOiuRwHjJR;

	public static readonly DependencyProperty um4iu6iQnCV;

	private static dXsBqnipeQyNFIFfqrW4 vVven2XvNEs4DOo4hGMJ;

	public TimeSpan? Time
	{
		get
		{
			return (TimeSpan?)GetValue(W2fiu58Asfx);
		}
		set
		{
			SetValue(W2fiu58Asfx, timeSpan);
		}
	}

	public string Hours
	{
		get
		{
			return (string)GetValue(VW1iuSU0jsp);
		}
		set
		{
			if (cMG4VmXvsGd3oG0fjk2N(Hours, text))
			{
				return;
			}
			int num = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22d0d1251c144ffb8e08dee8f7ca9f9a != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					PuhipWE8YiL();
					return;
				case 1:
					SetValue(VW1iuSU0jsp, text);
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_30b6a13fc6de439f86b8c44aa45349aa != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	public string Minutes
	{
		get
		{
			return (string)Gm3bKUXvXfhtmqJn4cAe(this, HKdiuxZ6sNw);
		}
		set
		{
			int num = 1;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = Minutes == text;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0e4e3e10f47f4fbdadc4c1fff6fde999 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					PuhipWE8YiL();
					return;
				}
				if (flag)
				{
					return;
				}
				SetValue(HKdiuxZ6sNw, text);
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6cac8bca385d4f06aa9f854441c8d5db == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public string Seconds
	{
		get
		{
			return (string)GetValue(bjPiuLUADsp);
		}
		set
		{
			if (Seconds == text)
			{
				return;
			}
			while (true)
			{
				Y7FGHSXvcf2s3tTHHkHy(this, bjPiuLUADsp, text);
				int num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					continue;
				}
				PuhipWE8YiL();
				return;
			}
		}
	}

	public HeOgP3iuMi8iBhftkEuh ActivePeriod
	{
		get
		{
			return (HeOgP3iuMi8iBhftkEuh)GetValue(xTTiuetkIyf);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, xTTiuetkIyf, heOgP3iuMi8iBhftkEuh);
		}
	}

	public string Header
	{
		get
		{
			return (string)GetValue(kbtiusHgGTO);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, kbtiusHgGTO, text);
		}
	}

	public string InfoText
	{
		get
		{
			return (string)GetValue(uPniuXmjvsH);
		}
		set
		{
			SetValue(uPniuXmjvsH, value2);
		}
	}

	public string ErrorMessage
	{
		get
		{
			return (string)GetValue(dJAiucdcotJ);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, dJAiucdcotJ, text);
		}
	}

	public string LinkText
	{
		get
		{
			return (string)GetValue(yqciuj81bhP);
		}
		set
		{
			SetValue(yqciuj81bhP, value2);
		}
	}

	public bool IsLinkArrowVisible
	{
		get
		{
			return (bool)GetValue(Ug7iuEi7kIg);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, Ug7iuEi7kIg, flag);
		}
	}

	public ICommand LinkCommand
	{
		get
		{
			return (ICommand)GetValue(Ng3iuQGShCr);
		}
		set
		{
			SetValue(Ng3iuQGShCr, value2);
		}
	}

	public object LinkCommandParameter
	{
		get
		{
			return Gm3bKUXvXfhtmqJn4cAe(this, wKqiudm4O5k);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, wKqiudm4O5k, obj);
		}
	}

	public bool IsSmall
	{
		get
		{
			return (bool)GetValue(IsSmallProperty);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, IsSmallProperty, flag);
		}
	}

	public bool IsSecondsOn
	{
		get
		{
			return (bool)GetValue(aVRiugycBvg);
		}
		set
		{
			SetValue(aVRiugycBvg, flag);
		}
	}

	public ICommand SubmitCommand
	{
		get
		{
			return (ICommand)Gm3bKUXvXfhtmqJn4cAe(this, RIOiuRwHjJR);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, RIOiuRwHjJR, command);
		}
	}

	public bool IsErrorVisible
	{
		get
		{
			return (bool)GetValue(um4iu6iQnCV);
		}
		set
		{
			Y7FGHSXvcf2s3tTHHkHy(this, um4iu6iQnCV, flag);
		}
	}

	public override void OnApplyTemplate()
	{
		aHciu1920kS = new DispatcherTimer(DispatcherPriority.Input)
		{
			Interval = TimeSpan.FromMilliseconds(200.0)
		};
		Htdiubhb3al = GpoUHlXvS7T6iBFr3PxI(this, Lrh99sXv5ItINOWGxxCb(0x50C1C840 ^ 0x50C1CE4A)) as Popup;
		Border border = GetTemplateChild(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-60853733 ^ -60851573)) as Border;
		bool flag = border != null;
		int num = 2;
		Border border2 = default(Border);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			case 5:
				border2 = GetTemplateChild(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2002318893 ^ -2002321035)) as Border;
				flag2 = border2 != null;
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5a3bf026df2e4752aeee32ca0b5dd9a8 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				if (flag2)
				{
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_59623cce0ac64326b0580b159ffae8e9 == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 7;
			case 2:
				if (flag)
				{
					QTgdPoXvxLqwGl43IqgU(border, new MouseButtonEventHandler(zvOipE9Vdu1));
					num = 5;
					break;
				}
				goto case 5;
			case 6:
				return;
			default:
				QTgdPoXvxLqwGl43IqgU(border2, new MouseButtonEventHandler(a9NipQPOisx));
				num = 3;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_42b310095a3c40c8b2751106577afb55 != 0)
				{
					num = 7;
				}
				break;
			case 3:
			{
				base.KeyUp += iufipR4vn3D;
				ULFgmSXvLmE08XLCC94p(this, new TextCompositionEventHandler(HgXipgdjnuF));
				base.PreviewKeyDown += rocipO6EmlO;
				int num2 = 4;
				num = num2;
				break;
			}
			case 4:
				a4LpImXvejKBjdIfKTpn(this, new RoutedEventHandler(miyipq7fTAP));
				base.LostFocus += LhfipIyQajs;
				base.OnApplyTemplate();
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_457e68c9d4ab4ecd899461247f8893ca == 0)
				{
					num = 6;
				}
				break;
			case 7:
				if (GetTemplateChild((string)Lrh99sXv5ItINOWGxxCb(0x2BD86B18 ^ 0x2BD863D8)) is Border border3)
				{
					border3.MouseLeftButtonUp += w8fipdotARF;
					num = 3;
					break;
				}
				goto case 3;
			}
		}
	}

	private static void y9ZipX67U7G(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is dXsBqnipeQyNFIFfqrW4 dXsBqnipeQyNFIFfqrW5))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_fa7c698855154b848bef2100c49719ad != 0)
		{
			num = 0;
		}
		object newValue = default(object);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				newValue = P_1.NewValue;
				num = 3;
				continue;
			case 1:
				gTwjF0XvjxlQoB8wYIY8(dXsBqnipeQyNFIFfqrW5, timeSpan.Seconds.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1346994499 ^ -1346996633)));
				return;
			case 3:
				if (newValue is TimeSpan)
				{
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_00e09dc7183a485ea31bd9282e0f2cd4 == 0)
					{
						num = 2;
					}
					continue;
				}
				num2 = 0;
				break;
			case 2:
				timeSpan = (TimeSpan)newValue;
				num = 4;
				continue;
			case 4:
				num2 = 1;
				break;
			}
			if (num2 != 0)
			{
				dXsBqnipeQyNFIFfqrW5.Hours = timeSpan.Hours.ToString((string)Lrh99sXv5ItINOWGxxCb(-1311293279 ^ -1311291269));
				dXsBqnipeQyNFIFfqrW5.Minutes = timeSpan.Minutes.ToString((string)Lrh99sXv5ItINOWGxxCb(-1763895751 ^ -1763893533));
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f4b1c8890eb74a208beeb28d12eddc3d != 0)
				{
					num = 1;
				}
				continue;
			}
			break;
		}
	}

	private static void RLhipcdXEoK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		dXsBqnipeQyNFIFfqrW4 dXsBqnipeQyNFIFfqrW5 = P_0 as dXsBqnipeQyNFIFfqrW4;
		bool isOpen = default(bool);
		int num;
		int num2;
		if (dXsBqnipeQyNFIFfqrW5 != null)
		{
			object newValue = P_1.NewValue;
			if (newValue is bool)
			{
				isOpen = (bool)newValue;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0e4e3e10f47f4fbdadc4c1fff6fde999 != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			num2 = 0;
			goto IL_0114;
		}
		int num3 = 1;
		goto IL_0122;
		IL_0122:
		bool flag = (byte)num3 != 0;
		num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_73192da35ad547548b56bccf34aa52bd != 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				if (dXsBqnipeQyNFIFfqrW5.Htdiubhb3al == null)
				{
					return;
				}
				goto case 5;
			case 1:
				if (!flag)
				{
					num = 3;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1a6c635ab4940dbb3ffcd364da08562 != 0)
					{
						num = 3;
					}
					continue;
				}
				return;
			case 2:
				return;
			case 5:
				dXsBqnipeQyNFIFfqrW5.Htdiubhb3al.IsOpen = isOpen;
				return;
			}
			break;
		}
		num2 = 1;
		goto IL_0114;
		IL_0114:
		num3 = ((num2 == 0) ? 1 : 0);
		goto IL_0122;
	}

	private void hBTipjAsDVL(object P_0, EventArgs P_1)
	{
		int num;
		if (giciukW1ZLw)
		{
			PGnip68Ov7J();
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d5cf9ea404004c488c3b0bf4ea818b28 != 0)
			{
				num = 0;
			}
		}
		else
		{
			kswipMFycvX();
			num = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_747acb5925c7480aa9dfd38106a74c05 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	private void zvOipE9Vdu1(object P_0, MouseButtonEventArgs P_1)
	{
		yxyiuNqXjql = true;
		ActivePeriod = HeOgP3iuMi8iBhftkEuh.Hours;
	}

	private void a9NipQPOisx(object P_0, MouseButtonEventArgs P_1)
	{
		yxyiuNqXjql = true;
		ActivePeriod = HeOgP3iuMi8iBhftkEuh.Minutes;
	}

	private void w8fipdotARF(object P_0, MouseButtonEventArgs P_1)
	{
		yxyiuNqXjql = true;
		ActivePeriod = HeOgP3iuMi8iBhftkEuh.Seconds;
	}

	private void HgXipgdjnuF(object P_0, TextCompositionEventArgs P_1)
	{
		int num = 19;
		int result2 = default(int);
		string s = default(string);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int result = default(int);
		HeOgP3iuMi8iBhftkEuh heOgP3iuMi8iBhftkEuh2 = default(HeOgP3iuMi8iBhftkEuh);
		bool flag3 = default(bool);
		int result3 = default(int);
		HeOgP3iuMi8iBhftkEuh heOgP3iuMi8iBhftkEuh = default(HeOgP3iuMi8iBhftkEuh);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				string s2;
				string obj2;
				switch (num2)
				{
				case 6:
					Minutes = result2.ToString((string)Lrh99sXv5ItINOWGxxCb(-2056710528 ^ -2056708510));
					goto IL_0166;
				case 19:
					P_1.Handled = true;
					num2 = 18;
					continue;
				case 9:
					return;
				case 10:
					return;
				case 20:
					return;
				case 16:
					obj = fbVuliXvEmBMJ8dT7xb2(Hours, P_1.Text);
					goto IL_0406;
				default:
					goto IL_0166;
				case 8:
					if (int.TryParse(s, out result2))
					{
						flag2 = result2 >= 60;
						num2 = 13;
						continue;
					}
					goto IL_0166;
				case 5:
					if (!flag)
					{
						Hours = result.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x2C8374E4 ^ 0x2C837C06));
						num2 = 7;
						continue;
					}
					Hours = P_1.Text;
					yxyiuNqXjql = false;
					num2 = 10;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_98790ccfa91e4cc4b8e56de14d056b9b != 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					Minutes = P_1.Text;
					yxyiuNqXjql = false;
					num2 = 20;
					continue;
				case 13:
					if (flag2)
					{
						num2 = 3;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_dae2a0acfd5b428ba7eb3ad10fcbb7da == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 6;
				case 18:
					heOgP3iuMi8iBhftkEuh2 = ActivePeriod;
					num2 = 14;
					continue;
				case 4:
					if (!flag3)
					{
						goto IL_0166;
					}
					if (result3 < 60)
					{
						Seconds = result3.ToString((string)Lrh99sXv5ItINOWGxxCb(-82860344 ^ -82858454));
						num2 = 12;
						continue;
					}
					Seconds = P_1.Text;
					num2 = 11;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f4b1c8890eb74a208beeb28d12eddc3d != 0)
					{
						num2 = 8;
					}
					continue;
				case 14:
					heOgP3iuMi8iBhftkEuh = heOgP3iuMi8iBhftkEuh2;
					num2 = 15;
					continue;
				case 11:
					yxyiuNqXjql = false;
					num2 = 9;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_cc0a9b45cb4f45a7adab1adba50d4a70 == 0)
					{
						num2 = 9;
					}
					continue;
				case 15:
					switch (heOgP3iuMi8iBhftkEuh)
					{
					case HeOgP3iuMi8iBhftkEuh.Minutes:
						break;
					case HeOgP3iuMi8iBhftkEuh.None:
						goto IL_0166;
					case HeOgP3iuMi8iBhftkEuh.Seconds:
						goto IL_01f3;
					default:
						goto IL_03b7;
					case HeOgP3iuMi8iBhftkEuh.Hours:
						goto IL_03d1;
					}
					s = (yxyiuNqXjql ? P_1.Text : (Minutes + P_1.Text));
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_c5986cef94cb48f88092eb5b714ee326 != 0)
					{
						num2 = 8;
					}
					continue;
				case 17:
					{
						flag = result >= 24;
						num2 = 5;
						continue;
					}
					IL_03d1:
					if (!yxyiuNqXjql)
					{
						goto end_IL_0012;
					}
					obj = P_1.Text;
					goto IL_0406;
					IL_03b7:
					num2 = 2;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_26b3e8355b0647d7acbfe1c7692947fd == 0)
					{
						num2 = 1;
					}
					continue;
					IL_0406:
					s2 = (string)obj;
					if (!int.TryParse(s2, out result))
					{
						num2 = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a4dd3ba864e24f44bf9ef3932a4f38e3 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
					IL_01f3:
					obj2 = (yxyiuNqXjql ? P_1.Text : (Seconds + P_1.Text));
					break;
					IL_0166:
					yxyiuNqXjql = false;
					return;
				}
				string s3 = obj2;
				flag3 = int.TryParse(s3, out result3);
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			num = 16;
		}
	}

	private void iufipR4vn3D(object P_0, KeyEventArgs P_1)
	{
		aHciu1920kS.Stop();
		Key key = P_1.Key;
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_73b6a8536efd4e5ba31378391aa47e85 == 0)
		{
			num = 0;
		}
		HeOgP3iuMi8iBhftkEuh heOgP3iuMi8iBhftkEuh = default(HeOgP3iuMi8iBhftkEuh);
		HeOgP3iuMi8iBhftkEuh heOgP3iuMi8iBhftkEuh2 = default(HeOgP3iuMi8iBhftkEuh);
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 8:
				return;
			case 12:
				return;
			case 9:
				ActivePeriod = HeOgP3iuMi8iBhftkEuh.Minutes;
				return;
			case 2:
				switch (ActivePeriod)
				{
				case HeOgP3iuMi8iBhftkEuh.Seconds:
					ActivePeriod = HeOgP3iuMi8iBhftkEuh.Minutes;
					return;
				default:
					num = 5;
					continue;
				case HeOgP3iuMi8iBhftkEuh.Minutes:
					ActivePeriod = HeOgP3iuMi8iBhftkEuh.Hours;
					return;
				case HeOgP3iuMi8iBhftkEuh.None:
					return;
				case HeOgP3iuMi8iBhftkEuh.Hours:
					break;
				}
				break;
			default:
				heOgP3iuMi8iBhftkEuh = heOgP3iuMi8iBhftkEuh2;
				num = 10;
				continue;
			case 13:
				return;
			case 1:
				switch (key)
				{
				case Key.Right:
					yxyiuNqXjql = true;
					heOgP3iuMi8iBhftkEuh2 = ActivePeriod;
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_045d0f7a0142410b9c67d902cef040ca == 0)
					{
						num = 0;
					}
					continue;
				default:
					num = 7;
					continue;
				case Key.Down:
				{
					kswipMFycvX();
					int num2 = 13;
					num = num2;
					continue;
				}
				case Key.Up:
					PGnip68Ov7J();
					num = 4;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_dae2a0acfd5b428ba7eb3ad10fcbb7da == 0)
					{
						num = 0;
					}
					continue;
				case Key.Left:
					break;
				}
				goto case 6;
			case 7:
				return;
			case 11:
				return;
			case 3:
				return;
			case 4:
				return;
			case 6:
				yxyiuNqXjql = true;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_eb5248e0c761453cb12954b91b9ede6d == 0)
				{
					num = 2;
				}
				continue;
			case 10:
				switch (heOgP3iuMi8iBhftkEuh)
				{
				case HeOgP3iuMi8iBhftkEuh.Seconds:
					ActivePeriod = HeOgP3iuMi8iBhftkEuh.Hours;
					num = 12;
					continue;
				default:
					return;
				case HeOgP3iuMi8iBhftkEuh.None:
					return;
				case HeOgP3iuMi8iBhftkEuh.Hours:
					break;
				case HeOgP3iuMi8iBhftkEuh.Minutes:
					ActivePeriod = ((!IsSecondsOn) ? HeOgP3iuMi8iBhftkEuh.Hours : HeOgP3iuMi8iBhftkEuh.Seconds);
					return;
				}
				goto case 9;
			case 14:
				break;
			}
			break;
		}
		ActivePeriod = (IsSecondsOn ? HeOgP3iuMi8iBhftkEuh.Seconds : HeOgP3iuMi8iBhftkEuh.Minutes);
	}

	private void PGnip68Ov7J()
	{
		bool flag = default(bool);
		int result3 = default(int);
		int num;
		int result = default(int);
		int result2;
		switch (ActivePeriod)
		{
		case HeOgP3iuMi8iBhftkEuh.Minutes:
			flag = int.TryParse(Minutes, out result3);
			num = 4;
			goto IL_0009;
		case HeOgP3iuMi8iBhftkEuh.Hours:
			if (int.TryParse(Hours, out result))
			{
				num = 6;
				goto IL_0009;
			}
			break;
		case HeOgP3iuMi8iBhftkEuh.None:
			break;
		case HeOgP3iuMi8iBhftkEuh.Seconds:
			goto IL_0125;
			IL_01eb:
			Seconds = result2.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1999650146 ^ -1999648188));
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_eaadedb0c2364349a5191442ca7eb967 == 0)
			{
				num = 1;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 10:
					if (result >= 24)
					{
						result = 0;
					}
					Hours = result.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x32DEA4F1 ^ 0x32DEAC2B));
					return;
				case 5:
					break;
				case 4:
					if (flag)
					{
						num = 9;
						continue;
					}
					return;
				case 2:
					return;
				case 1:
					return;
				case 3:
					return;
				case 7:
					return;
				default:
					goto IL_0125;
				case 9:
					result3++;
					if (result3 >= 60)
					{
						result3 = 0;
						num = 11;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_ec51f99afa1d4015a6304fbbb0f17b3a != 0)
						{
							num = 11;
						}
						continue;
					}
					goto case 11;
				case 11:
					Minutes = result3.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2017337494 ^ -2017339472));
					num = 2;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8cdc9ad005814fe2a98187bc4b0a89ab == 0)
					{
						num = 2;
					}
					continue;
				case 8:
					goto IL_0222;
				case 6:
					result++;
					num = 10;
					continue;
				}
				break;
			}
			goto case HeOgP3iuMi8iBhftkEuh.Minutes;
			IL_0222:
			result2 = 0;
			goto IL_01eb;
			IL_0125:
			if (!int.TryParse(Seconds, out result2))
			{
				break;
			}
			result2++;
			if (result2 >= 60)
			{
				num = 8;
				goto IL_0009;
			}
			goto IL_01eb;
		}
	}

	private void kswipMFycvX()
	{
		int num = 2;
		int num2 = num;
		int result2 = default(int);
		int result3 = default(int);
		bool flag = default(bool);
		int result = default(int);
		bool flag2 = default(bool);
		HeOgP3iuMi8iBhftkEuh heOgP3iuMi8iBhftkEuh = default(HeOgP3iuMi8iBhftkEuh);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				result2--;
				if (result2 < 0)
				{
					break;
				}
				goto case 5;
			case 10:
				result3 = 59;
				goto IL_0102;
			case 8:
				if (flag)
				{
					result--;
					num2 = 9;
					continue;
				}
				num2 = 12;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf == 0)
				{
					num2 = 1;
				}
				continue;
			case 13:
				return;
			case 3:
				if (!flag2)
				{
					return;
				}
				result3--;
				if (result3 < 0)
				{
					num2 = 10;
					continue;
				}
				goto IL_0102;
			case 11:
				Hours = result.ToString((string)Lrh99sXv5ItINOWGxxCb(--855742383 ^ 0x33019F75));
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2de1ce522cf44e4cac85a49e39c09b28 == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				if (result < 0)
				{
					num2 = 4;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1c958f34803646f7bd8283df13e97b54 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 11;
			case 5:
				Seconds = result2.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-198991962 ^ -198994052));
				num2 = 5;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f613416004f048ed97d95a2596e7c9aa == 0)
				{
					num2 = 13;
				}
				continue;
			case 0:
				return;
			case 12:
				return;
			case 1:
				switch (heOgP3iuMi8iBhftkEuh)
				{
				case HeOgP3iuMi8iBhftkEuh.Seconds:
					if (!int.TryParse(Seconds, out result2))
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_972dd0905aa74735b7862b8138b18a1d == 0)
					{
						num2 = 6;
					}
					break;
				default:
					return;
				case HeOgP3iuMi8iBhftkEuh.Minutes:
					flag2 = int.TryParse(Minutes, out result3);
					num2 = 3;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22d0d1251c144ffb8e08dee8f7ca9f9a == 0)
					{
						num2 = 3;
					}
					break;
				case HeOgP3iuMi8iBhftkEuh.Hours:
					flag = int.TryParse(Hours, out result);
					num2 = 8;
					break;
				case HeOgP3iuMi8iBhftkEuh.None:
					return;
				}
				continue;
			case 2:
				heOgP3iuMi8iBhftkEuh = ActivePeriod;
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e500693622c345f4b5a2910bf7d09298 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				result = 23;
				num2 = 5;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_faab0d03eb4e4bb7bc79fb35300cacbb != 0)
				{
					num2 = 11;
				}
				continue;
			case 7:
				break;
				IL_0102:
				Minutes = result3.ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-602153869 ^ -602155863));
				return;
			}
			result2 = 59;
			num2 = 5;
		}
	}

	private void rocipO6EmlO(object P_0, KeyEventArgs P_1)
	{
		Key key = C6U7NLXvQcIRulWvlBAo(P_1);
		Key key2 = key;
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f97c2b59553f423fb8445ca09317c97d == 0)
		{
			num = 1;
		}
		int result3 = default(int);
		bool flag3 = default(bool);
		int result2 = default(int);
		bool flag = default(bool);
		int result = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			case 17:
				return;
			case 23:
				Hours = (result3 / 10).ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-44540535 ^ -44542637));
				return;
			case 2:
				return;
			case 4:
				return;
			case 7:
				return;
			case 16:
				return;
			case 20:
				return;
			case 21:
				return;
			case 22:
				return;
			case 24:
				return;
			case 25:
				Minutes = OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x9F0F634 ^ 0x9F0FEEE);
				num = 20;
				continue;
			case 3:
			case 18:
				if (key2 != Key.Space)
				{
					return;
				}
				P_1.Handled = true;
				num = 24;
				continue;
			case 26:
				if (!flag3)
				{
					Seconds = (string)Lrh99sXv5ItINOWGxxCb(0x68DEE0F ^ 0x68DE6D5);
					return;
				}
				Seconds = (result2 / 10).ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x42D899B5 ^ 0x42D8916F));
				num = 16;
				continue;
			case 10:
				if (flag)
				{
					Minutes = (result / 10).ToString(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x4220DA8 ^ 0x4220572));
					return;
				}
				goto case 25;
			default:
				if (result3 > 0)
				{
					num = 23;
					continue;
				}
				goto case 6;
			case 19:
				if (key2 != Key.Delete)
				{
					num = 21;
					continue;
				}
				goto case 5;
			case 9:
				switch (ActivePeriod)
				{
				case HeOgP3iuMi8iBhftkEuh.None:
					return;
				default:
					num = 17;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 != 0)
					{
						num = 6;
					}
					continue;
				case HeOgP3iuMi8iBhftkEuh.Seconds:
					if (!int.TryParse(Seconds, out result2))
					{
						return;
					}
					flag3 = result2 > 0;
					num = 26;
					continue;
				case HeOgP3iuMi8iBhftkEuh.Hours:
					break;
				case HeOgP3iuMi8iBhftkEuh.Minutes:
					flag2 = int.TryParse(Minutes, out result);
					num = 14;
					continue;
				}
				goto case 11;
			case 6:
				Hours = OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1047165041 ^ -1047163051);
				num = 4;
				continue;
			case 8:
				switch (key2)
				{
				case Key.Return:
				{
					P_1.Handled = true;
					ICommand command = SubmitCommand;
					if (command == null)
					{
						return;
					}
					command.Execute(null);
					num = 2;
					continue;
				}
				default:
					num = 18;
					continue;
				case Key.Back:
					break;
				}
				goto case 5;
			case 5:
			{
				P_1.Handled = true;
				int num2 = 9;
				num = num2;
				continue;
			}
			case 11:
				if (!int.TryParse(Hours, out result3))
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_156f781fb1b2449cbaf69125616eaf4b == 0)
				{
					num = 0;
				}
				continue;
			case 12:
				dUbqZtXvdadrxInnH8F0(P_1, true);
				giciukW1ZLw = true;
				aHciu1920kS.Start();
				return;
			case 14:
				if (!flag2)
				{
					return;
				}
				goto case 13;
			case 13:
				flag = result > 0;
				num = 10;
				continue;
			case 1:
				if (key2 > Key.Space)
				{
					if (key2 != Key.Up)
					{
						if (key2 == Key.Down)
						{
							break;
						}
						goto case 19;
					}
					goto case 12;
				}
				num = 8;
				continue;
			case 15:
				break;
			}
			break;
		}
		P_1.Handled = true;
		giciukW1ZLw = false;
		aHciu1920kS.Start();
	}

	private void miyipq7fTAP(object P_0, RoutedEventArgs P_1)
	{
		dUbqZtXvdadrxInnH8F0(P_1, true);
		yxyiuNqXjql = true;
		g4M1H8Xvg0FqfYn3dqTh(aHciu1920kS, new EventHandler(hBTipjAsDVL));
		ActivePeriod = HeOgP3iuMi8iBhftkEuh.Hours;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_c5986cef94cb48f88092eb5b714ee326 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void LhfipIyQajs(object P_0, RoutedEventArgs P_1)
	{
		P_1.Handled = true;
		ActivePeriod = HeOgP3iuMi8iBhftkEuh.None;
		L4TVfAXvRoIo8IuGsWLB(aHciu1920kS);
		aHciu1920kS.Tick -= hBTipjAsDVL;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_045d0f7a0142410b9c67d902cef040ca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void PuhipWE8YiL()
	{
		int.TryParse(Hours, out var result);
		int.TryParse(Minutes, out var result2);
		int.TryParse(Seconds, out var result3);
		Time = new TimeSpan(result, result2, result3);
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_4c8ecf325a364ca59e2eb4ef96febad8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public dXsBqnipeQyNFIFfqrW4()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		yxyiuNqXjql = false;
		giciukW1ZLw = false;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1c958f34803646f7bd8283df13e97b54 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static dXsBqnipeQyNFIFfqrW4()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					VW1iuSU0jsp = (DependencyProperty)ITM0YVXvMGLOv6tbGyZa(Lrh99sXv5ItINOWGxxCb(-1009517961 ^ -1009519999), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new UIPropertyMetadata(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x22BF43FC ^ 0x22BF4B26)));
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6cac8bca385d4f06aa9f854441c8d5db != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					break;
				case 6:
					wKqiudm4O5k = DependencyProperty.Register((string)Lrh99sXv5ItINOWGxxCb(-894902996 ^ -894902714), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(aKkr0OXvqv1J51Y4xYxG(33554470)));
					IsSmallProperty = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1461292091 ^ -1461291645), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new UIPropertyMetadata(false));
					aVRiugycBvg = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-377195341 ^ -377192969), NVI28AXvOSv2sjcXq3Fw(aKkr0OXvqv1J51Y4xYxG(16777220)), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new UIPropertyMetadata(false));
					num2 = 7;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_13019221e20c438386b6c8d9a8967f7c != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					um4iu6iQnCV = DependencyProperty.Register((string)Lrh99sXv5ItINOWGxxCb(-520155535 ^ -520157143), Type.GetTypeFromHandle(aKkr0OXvqv1J51Y4xYxG(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new PropertyMetadata(false, RLhipcdXEoK));
					return;
				case 1:
					HKdiuxZ6sNw = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1306877528 ^ -1306875732), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new UIPropertyMetadata(Lrh99sXv5ItINOWGxxCb(-53782092 ^ -53784210)));
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f97c2b59553f423fb8445ca09317c97d == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
					eZKTsEXv6JLZv6yC1jcg();
					W2fiu58Asfx = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x37B74BDF ^ 0x37B74335), typeof(TimeSpan?), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new UIPropertyMetadata(null, y9ZipX67U7G));
					num2 = 8;
					continue;
				case 7:
					RIOiuRwHjJR = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x3E0426F0 ^ 0x3E042E82), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)));
					num2 = 5;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					bjPiuLUADsp = DependencyProperty.Register((string)Lrh99sXv5ItINOWGxxCb(0x706541F3 ^ 0x706548E5), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)), new UIPropertyMetadata(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x7F55E538 ^ 0x7F55EDE2)));
					xTTiuetkIyf = (DependencyProperty)C24RnkXvIPvmXIuVNSbH(Lrh99sXv5ItINOWGxxCb(-1153206687 ^ -1153204407), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554471)), Type.GetTypeFromHandle(aKkr0OXvqv1J51Y4xYxG(33554470)));
					kbtiusHgGTO = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-60853733 ^ -60853665), Type.GetTypeFromHandle(aKkr0OXvqv1J51Y4xYxG(16777225)), Type.GetTypeFromHandle(aKkr0OXvqv1J51Y4xYxG(33554470)));
					uPniuXmjvsH = (DependencyProperty)C24RnkXvIPvmXIuVNSbH(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x2BD86B18 ^ 0x2BD86818), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), NVI28AXvOSv2sjcXq3Fw(aKkr0OXvqv1J51Y4xYxG(33554470)));
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_839435b576b741b9b9b22142d05dd2f3 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					dJAiucdcotJ = (DependencyProperty)C24RnkXvIPvmXIuVNSbH(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-29702950 ^ -29703440), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)));
					yqciuj81bhP = (DependencyProperty)C24RnkXvIPvmXIuVNSbH(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2056710528 ^ -2056710764), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)));
					Ug7iuEi7kIg = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x50C1C840 ^ 0x50C1CB68), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), NVI28AXvOSv2sjcXq3Fw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)));
					Ng3iuQGShCr = (DependencyProperty)C24RnkXvIPvmXIuVNSbH(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-44540535 ^ -44540199), NVI28AXvOSv2sjcXq3Fw(aKkr0OXvqv1J51Y4xYxG(16777255)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554470)));
					num2 = 6;
					continue;
				}
				break;
			}
			OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
			num = 2;
		}
	}

	internal static object Lrh99sXv5ItINOWGxxCb(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object GpoUHlXvS7T6iBFr3PxI(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static void QTgdPoXvxLqwGl43IqgU(object P_0, object P_1)
	{
		((UIElement)P_0).MouseLeftButtonUp += (MouseButtonEventHandler)P_1;
	}

	internal static void ULFgmSXvLmE08XLCC94p(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewTextInput += (TextCompositionEventHandler)P_1;
	}

	internal static void a4LpImXvejKBjdIfKTpn(object P_0, object P_1)
	{
		((UIElement)P_0).GotFocus += (RoutedEventHandler)P_1;
	}

	internal static bool HAnXGSXvkKVOFvNUN8Ga()
	{
		return vVven2XvNEs4DOo4hGMJ == null;
	}

	internal static dXsBqnipeQyNFIFfqrW4 jv7IhyXv1OriCyRUNyjS()
	{
		return vVven2XvNEs4DOo4hGMJ;
	}

	internal static bool cMG4VmXvsGd3oG0fjk2N(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object Gm3bKUXvXfhtmqJn4cAe(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void Y7FGHSXvcf2s3tTHHkHy(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void gTwjF0XvjxlQoB8wYIY8(object P_0, object P_1)
	{
		((dXsBqnipeQyNFIFfqrW4)P_0).Seconds = (string)P_1;
	}

	internal static object fbVuliXvEmBMJ8dT7xb2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Key C6U7NLXvQcIRulWvlBAo(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static void dUbqZtXvdadrxInnH8F0(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static void g4M1H8Xvg0FqfYn3dqTh(object P_0, object P_1)
	{
		((DispatcherTimer)P_0).Tick += (EventHandler)P_1;
	}

	internal static void L4TVfAXvRoIo8IuGsWLB(object P_0)
	{
		((DispatcherTimer)P_0).Stop();
	}

	internal static void eZKTsEXv6JLZv6yC1jcg()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static object ITM0YVXvMGLOv6tbGyZa(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static Type NVI28AXvOSv2sjcXq3Fw(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle aKkr0OXvqv1J51Y4xYxG(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static object C24RnkXvIPvmXIuVNSbH(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
