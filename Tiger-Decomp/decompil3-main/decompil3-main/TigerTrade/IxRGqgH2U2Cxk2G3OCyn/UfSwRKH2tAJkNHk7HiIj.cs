using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ECOEgqlSad8NUJZ2Dr9n;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using qK52IFH2WpFQpklt3aW3;
using TuAMtrl1Nd3XoZQQUXf0;

namespace IxRGqgH2U2Cxk2G3OCyn;

public sealed class UfSwRKH2tAJkNHk7HiIj : uUWLIoH2IMa6ubyC18Xq
{
	private readonly WebView2 J7LH2w8tRYy;

	[CompilerGenerated]
	private EventHandler<bool> g4KH27ruNlE;

	[CompilerGenerated]
	private EventHandler fHRH28Md7wE;

	internal static UfSwRKH2tAJkNHk7HiIj oRnnl5Diten7hEBAZBFV;

	public Visibility Visibility
	{
		get
		{
			return fFEu0bDiZi6GPakwnBPt(J7LH2w8tRYy);
		}
		set
		{
			J7LH2w8tRYy.Visibility = visibility;
		}
	}

	public UfSwRKH2tAJkNHk7HiIj(WebView2 P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		J7LH2w8tRYy = P_0;
		J7LH2w8tRYy.CoreWebView2.ProcessFailed += PK2H2yeYUxx;
		J7LH2w8tRYy.NavigationCompleted += u2HH2ZpEnhs;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			((CoreWebView2)QVLCODDiyIA5ONg4iFlI(J7LH2w8tRYy)).ContainsFullScreenElementChanged += B06H2TjN59F;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
			{
				num = 1;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void yqGH2VPZl3S(EventHandler<bool> P_0)
	{
		EventHandler<bool> eventHandler = g4KH27ruNlE;
		EventHandler<bool> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bool> value = (EventHandler<bool>)Delegate.Combine(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref g4KH27ruNlE, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void kVoH2Clk8P3(EventHandler<bool> P_0)
	{
		EventHandler<bool> eventHandler = g4KH27ruNlE;
		EventHandler<bool> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bool> value = (EventHandler<bool>)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref g4KH27ruNlE, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void RExH2KjOZVo(EventHandler P_0)
	{
		EventHandler eventHandler = fHRH28Md7wE;
		while (true)
		{
			EventHandler eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)FCVpMTDiVqCDns4Gs0b0(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref fHRH28Md7wE, value, eventHandler2);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
			{
				num = 1;
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
				if ((object)eventHandler != eventHandler2)
				{
					break;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
				{
					num = 0;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void VynH2myagDL(EventHandler P_0)
	{
		EventHandler eventHandler = fHRH28Md7wE;
		while (true)
		{
			EventHandler eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref fHRH28Md7wE, value, eventHandler2);
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				if ((object)eventHandler != eventHandler2)
				{
					break;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num = 0;
				}
			}
		}
	}

	public void Navigate(Uri P_0)
	{
		J7LH2w8tRYy.Source = P_0;
	}

	private void B06H2TjN59F(object P_0, object P_1)
	{
		bool e = w9Oh97DiCe2GyxPQQFou(J7LH2w8tRYy.CoreWebView2);
		EventHandler<bool> eventHandler = g4KH27ruNlE;
		if (eventHandler == null)
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
			eventHandler(this, e);
		}
	}

	private void PK2H2yeYUxx(object P_0, CoreWebView2ProcessFailedEventArgs P_1)
	{
		EventHandler eventHandler = fHRH28Md7wE;
		if (eventHandler != null)
		{
			Blqo5PDirbZ7xdIAZXW1(eventHandler, this, EventArgs.Empty);
		}
	}

	private void u2HH2ZpEnhs(object P_0, CoreWebView2NavigationCompletedEventArgs P_1)
	{
		if (P_1.IsSuccess)
		{
			return;
		}
		EventHandler eventHandler = fHRH28Md7wE;
		if (eventHandler != null)
		{
			eventHandler(this, EventArgs.Empty);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
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

	static UfSwRKH2tAJkNHk7HiIj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object QVLCODDiyIA5ONg4iFlI(object P_0)
	{
		return ((WebView2)P_0).CoreWebView2;
	}

	internal static bool kbRdr0DiUAVPNypld1OB()
	{
		return oRnnl5Diten7hEBAZBFV == null;
	}

	internal static UfSwRKH2tAJkNHk7HiIj LWwxDcDiTA8DnnfrnlDY()
	{
		return oRnnl5Diten7hEBAZBFV;
	}

	internal static Visibility fFEu0bDiZi6GPakwnBPt(object P_0)
	{
		return ((UIElement)P_0).Visibility;
	}

	internal static object FCVpMTDiVqCDns4Gs0b0(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static bool w9Oh97DiCe2GyxPQQFou(object P_0)
	{
		return ((CoreWebView2)P_0).ContainsFullScreenElement;
	}

	internal static void Blqo5PDirbZ7xdIAZXW1(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (EventArgs)P_2);
	}
}
