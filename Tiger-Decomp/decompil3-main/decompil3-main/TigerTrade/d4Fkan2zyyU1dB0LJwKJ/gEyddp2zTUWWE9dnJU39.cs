using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Annotations;
using TigerTrade.UI.Controls.Notifications;
using TuAMtrl1Nd3XoZQQUXf0;
using xCOmUuHDjdTrt2GotQpl;

namespace d4Fkan2zyyU1dB0LJwKJ;

internal sealed class gEyddp2zTUWWE9dnJU39 : Window, INotifyPropertyChanged, IComponentConnector
{
	private NotificationPosition rao2zr3ftbv;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private bool W8H2zKcslSm;

	internal static gEyddp2zTUWWE9dnJU39 tJtAbfDBP3B97QRRIkak;

	public NotificationPosition NotificationPosition
	{
		get
		{
			return rao2zr3ftbv;
		}
		set
		{
			if (notificationPosition != rao2zr3ftbv)
			{
				rao2zr3ftbv = notificationPosition;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				eR12zZjUo86(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BE5192));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)T5KmubDBpJ8LPcGA50hl(propertyChangedEventHandler2, propertyChangedEventHandler3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
						{
							num = 0;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public gEyddp2zTUWWE9dnJU39()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		rao2zr3ftbv = NotificationPosition.BottomRight;
		InitializeComponent();
	}

	protected override void OnInitialized(EventArgs P_0)
	{
		base.OnInitialized(P_0);
		QeoniMDB3tC7rckoJ346(this);
	}

	[NotifyPropertyChangedInvocator]
	private void eR12zZjUo86([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!W8H2zKcslSm)
		{
			W8H2zKcslSm = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA8022E), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)Xyum1hDBu7t57x7ffe3N(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		W8H2zKcslSm = true;
	}

	static gEyddp2zTUWWE9dnJU39()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool XBbUWtDBJxiR4GqIbBIR()
	{
		return tJtAbfDBP3B97QRRIkak == null;
	}

	internal static gEyddp2zTUWWE9dnJU39 x5YAFrDBFDIwpmkE52WI()
	{
		return tJtAbfDBP3B97QRRIkak;
	}

	internal static void QeoniMDB3tC7rckoJ346(object P_0)
	{
		S6BaSJHDc2pgAe1j8DZH.nYmHDZSndd6((Window)P_0);
	}

	internal static object T5KmubDBpJ8LPcGA50hl(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object Xyum1hDBu7t57x7ffe3N(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}
}
