using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

public class TitleBar : Control
{
	private Window abUiPw7VfVa;

	public static readonly DependencyProperty X3biP7KbxyD;

	public static readonly DependencyProperty qokiP87AfiE;

	public static readonly DependencyProperty WYIiPApkWME;

	public static readonly DependencyProperty xYwiPPGfPNV;

	public static readonly DependencyProperty qmNiPJxJjac;

	public static readonly DependencyProperty EYZiPF6TEtM;

	public static readonly DependencyProperty XFniP3eZtEf;

	public static readonly DependencyProperty taRiPpL9B1y;

	public static readonly DependencyProperty YFpiPumsxss;

	public static readonly DependencyProperty oKbiPzNjr5f;

	public static readonly DependencyProperty JJMiJ0JmHg5;

	public static readonly DependencyProperty alRiJ2OKkHn;

	private static TitleBar mqcxtyXYdxkjJif7Csij;

	public string Title
	{
		get
		{
			return (string)rmxcUMXYqjoUrvGQt4lo(this, X3biP7KbxyD);
		}
		set
		{
			SetValue(X3biP7KbxyD, value2);
		}
	}

	public bool CanMove
	{
		get
		{
			return (bool)GetValue(qokiP87AfiE);
		}
		set
		{
			h4EFmEXYIUOpR91pbDqn(this, qokiP87AfiE, flag);
		}
	}

	public bool CanGoBack
	{
		get
		{
			return (bool)rmxcUMXYqjoUrvGQt4lo(this, WYIiPApkWME);
		}
		set
		{
			SetValue(WYIiPApkWME, flag);
		}
	}

	public ICommand GoBackCommand
	{
		get
		{
			return (ICommand)rmxcUMXYqjoUrvGQt4lo(this, xYwiPPGfPNV);
		}
		set
		{
			h4EFmEXYIUOpR91pbDqn(this, xYwiPPGfPNV, command);
		}
	}

	public object GoBackCommandParameter
	{
		get
		{
			return GetValue(qmNiPJxJjac);
		}
		set
		{
			SetValue(qmNiPJxJjac, value2);
		}
	}

	public bool CanMinimize
	{
		get
		{
			return (bool)GetValue(EYZiPF6TEtM);
		}
		set
		{
			SetValue(EYZiPF6TEtM, flag);
		}
	}

	public ICommand MinimizeCommand
	{
		get
		{
			return (ICommand)rmxcUMXYqjoUrvGQt4lo(this, XFniP3eZtEf);
		}
		set
		{
			SetValue(XFniP3eZtEf, value2);
		}
	}

	public bool CanMaximize
	{
		get
		{
			return (bool)GetValue(taRiPpL9B1y);
		}
		set
		{
			SetValue(taRiPpL9B1y, flag);
		}
	}

	public ICommand MaximizeCommand
	{
		get
		{
			return (ICommand)rmxcUMXYqjoUrvGQt4lo(this, YFpiPumsxss);
		}
		set
		{
			SetValue(YFpiPumsxss, value2);
		}
	}

	public bool CanClose
	{
		get
		{
			return (bool)GetValue(oKbiPzNjr5f);
		}
		set
		{
			SetValue(oKbiPzNjr5f, flag);
		}
	}

	public ICommand CloseCommand
	{
		get
		{
			return (ICommand)GetValue(JJMiJ0JmHg5);
		}
		set
		{
			h4EFmEXYIUOpR91pbDqn(this, JJMiJ0JmHg5, command);
		}
	}

	public Thickness CornerRadius
	{
		get
		{
			return (Thickness)GetValue(alRiJ2OKkHn);
		}
		set
		{
			SetValue(alRiJ2OKkHn, thickness);
		}
	}

	public TitleBar()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_dae2a0acfd5b428ba7eb3ad10fcbb7da == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Su82uhXY6WabLPwDe4Cc(this, new RoutedEventHandler(b8MiPeEnoAI));
	}

	private void b8MiPeEnoAI(object P_0, RoutedEventArgs P_1)
	{
		abUiPw7VfVa = Window.GetWindow(this);
		xsNCJhXYMTKV8HlqQPEV(this, new MouseButtonEventHandler(kEoiPX7pbYd));
		base.MouseDoubleClick += yXEiPsW0oYW;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_cf097f93df0446efbff91752c3a6e19b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void yXEiPsW0oYW(object P_0, MouseButtonEventArgs P_1)
	{
		if (CanMaximize)
		{
			KxJpvOXYOiWCfjvCfNnd(MaximizeCommand, this);
		}
	}

	private void kEoiPX7pbYd(object P_0, MouseButtonEventArgs P_1)
	{
		if (!CanMove)
		{
			return;
		}
		Window window = abUiPw7VfVa;
		if (window != null)
		{
			window.DragMove();
			int num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_42bc11c38b8e48eeaa3a7e6f002e0752 != 0)
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

	static TitleBar()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		X3biP7KbxyD = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x28BBDCA ^ 0x28BBE5C), Type.GetTypeFromHandle(LVjNdpXYWLd6fFafnnB5(16777225)), Type.GetTypeFromHandle(LVjNdpXYWLd6fFafnnB5(33554463)));
		int num = 3;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_45beddfe9d2c40369d7410b1ce3b00ea != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				JJMiJ0JmHg5 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1161619942 ^ -1161620814), Type.GetTypeFromHandle(LVjNdpXYWLd6fFafnnB5(16777255)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554463)));
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_cc0a9b45cb4f45a7adab1adba50d4a70 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				YFpiPumsxss = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-44540535 ^ -44541855), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), Type.GetTypeFromHandle(LVjNdpXYWLd6fFafnnB5(33554463)));
				oKbiPzNjr5f = (DependencyProperty)t3sabRXYTpUQforxYv8o(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x7ADBF691 ^ 0x7ADBF691), UBaFUNXYtXKSB28JyBHF(LVjNdpXYWLd6fFafnnB5(16777220)), UBaFUNXYtXKSB28JyBHF(LVjNdpXYWLd6fFafnnB5(33554463)));
				num = 5;
				break;
			case 4:
				WYIiPApkWME = DependencyProperty.Register((string)qCcYX6XYUZrxeQ2lFvwS(0x68C7EAE6 ^ 0x68C7EAF2), UBaFUNXYtXKSB28JyBHF(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554463)));
				xYwiPPGfPNV = (DependencyProperty)t3sabRXYTpUQforxYv8o(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x32DEA4F1 ^ 0x32DEA1AF), UBaFUNXYtXKSB28JyBHF(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554463)));
				qmNiPJxJjac = (DependencyProperty)t3sabRXYTpUQforxYv8o(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2063361985 ^ -2063360701), UBaFUNXYtXKSB28JyBHF(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554463)));
				EYZiPF6TEtM = DependencyProperty.Register((string)qCcYX6XYUZrxeQ2lFvwS(-530053095 ^ -530053069), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554463)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a0279c4ba1c84315962e441eb713cbcc == 0)
				{
					num = 0;
				}
				break;
			default:
				XFniP3eZtEf = (DependencyProperty)t3sabRXYTpUQforxYv8o(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x37B74BDF ^ 0x37B74E73), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), Type.GetTypeFromHandle(LVjNdpXYWLd6fFafnnB5(33554463)));
				taRiPpL9B1y = (DependencyProperty)t3sabRXYTpUQforxYv8o(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-837284864 ^ -837285426), UBaFUNXYtXKSB28JyBHF(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554463)));
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0186f9916c474408b21410971ecb054c != 0)
				{
					num = 1;
				}
				break;
			case 2:
				alRiJ2OKkHn = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(--500511424 ^ 0x1DD53382), UBaFUNXYtXKSB28JyBHF(LVjNdpXYWLd6fFafnnB5(16777299)), UBaFUNXYtXKSB28JyBHF(LVjNdpXYWLd6fFafnnB5(33554463)));
				return;
			case 3:
				qokiP87AfiE = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-342738082 ^ -342737390), UBaFUNXYtXKSB28JyBHF(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(LVjNdpXYWLd6fFafnnB5(33554463)), new PropertyMetadata(true));
				num = 4;
				break;
			}
		}
	}

	internal static void Su82uhXY6WabLPwDe4Cc(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static bool j49vhgXYgFZYvejw8nkT()
	{
		return mqcxtyXYdxkjJif7Csij == null;
	}

	internal static TitleBar y9BD2dXYRf1VKqp4oLIF()
	{
		return mqcxtyXYdxkjJif7Csij;
	}

	internal static void xsNCJhXYMTKV8HlqQPEV(object P_0, object P_1)
	{
		((UIElement)P_0).MouseLeftButtonDown += (MouseButtonEventHandler)P_1;
	}

	internal static void KxJpvOXYOiWCfjvCfNnd(object P_0, object P_1)
	{
		((ICommand)P_0).Execute(P_1);
	}

	internal static object rmxcUMXYqjoUrvGQt4lo(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void h4EFmEXYIUOpR91pbDqn(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static RuntimeTypeHandle LVjNdpXYWLd6fFafnnB5(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type UBaFUNXYtXKSB28JyBHF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object qCcYX6XYUZrxeQ2lFvwS(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object t3sabRXYTpUQforxYv8o(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
