using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using iN2lHyHD4mvrPn6GqDfN;
using TigerTrade.Annotations;
using ttPdaPH4UIV7wakQ3boE;
using TuAMtrl1Nd3XoZQQUXf0;

namespace OWUMXkHkWgCUprHQ3jb9;

internal class PbGEeJHkI13kYvWpne18 : Window, INotifyPropertyChanged
{
	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static PbGEeJHkI13kYvWpne18 UCl5CJDx50cy6yEOSDYa;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
					{
						num2 = 0;
					}
					break;
				default:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				}
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				}
			}
		}
	}

	public PbGEeJHkI13kYvWpne18()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected void yFmHkt9E0av()
	{
	}

	protected void XpNHkUgjpt1()
	{
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (j18iDj9nukSCmEyZs5lH.VUi9vquhfBp)
		{
			return base.OnCreateAutomationPeer();
		}
		return new URSL9GHDlV79iGykbVj6(this);
	}

	protected override void OnSourceInitialized(EventArgs P_0)
	{
		ziDYFoDxLG1Rp2V7PP8o(this);
		D2t6qZDxeIpMaVRBMF6e(this, P_0);
	}

	protected override void OnClosed(EventArgs P_0)
	{
		T1PidKH4tUNimKjMkjFl.Dx9H4rRn2in(this);
		erRGcfDxsNopnhv4I8T4(this, P_0);
	}

	static PbGEeJHkI13kYvWpne18()
	{
		D3SwiKDxXbWHaf9Xdr0i();
	}

	internal static bool r3CnrADxSWqBG66PS04k()
	{
		return UCl5CJDx50cy6yEOSDYa == null;
	}

	internal static PbGEeJHkI13kYvWpne18 YuBqJ0Dxx4b9jP7GBYmU()
	{
		return UCl5CJDx50cy6yEOSDYa;
	}

	internal static void ziDYFoDxLG1Rp2V7PP8o(object P_0)
	{
		T1PidKH4tUNimKjMkjFl.zO0H4C3wa1t((PbGEeJHkI13kYvWpne18)P_0);
	}

	internal static void D2t6qZDxeIpMaVRBMF6e(object P_0, object P_1)
	{
		((Window)P_0).OnSourceInitialized((EventArgs)P_1);
	}

	internal static void erRGcfDxsNopnhv4I8T4(object P_0, object P_1)
	{
		((Window)P_0).OnClosed((EventArgs)P_1);
	}

	internal static void D3SwiKDxXbWHaf9Xdr0i()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
