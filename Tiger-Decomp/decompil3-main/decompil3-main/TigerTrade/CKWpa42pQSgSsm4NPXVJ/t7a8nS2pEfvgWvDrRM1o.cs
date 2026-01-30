using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Annotations;
using TuAMtrl1Nd3XoZQQUXf0;

namespace CKWpa42pQSgSsm4NPXVJ;

internal sealed class t7a8nS2pEfvgWvDrRM1o : INotifyPropertyChanged
{
	[CompilerGenerated]
	private readonly bool jpB2pUjHiee;

	private bool hfG2pTxltvT;

	private int KUr2pymFT8C;

	private int ln52pZ0fdo3;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static t7a8nS2pEfvgWvDrRM1o dLbFd5DoKiTWqEuECEsI;

	public bool Checked
	{
		get
		{
			return hfG2pTxltvT;
		}
		set
		{
			if (flag != hfG2pTxltvT)
			{
				hfG2pTxltvT = flag;
				yYc2pgUYbd0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D371F4));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
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
	}

	public int Min
	{
		get
		{
			return KUr2pymFT8C;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num3 != KUr2pymFT8C)
					{
						KUr2pymFT8C = num3;
						yYc2pgUYbd0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90245356));
					}
					return;
				case 1:
					num3 = jKTV7YDowoO2sggqXr3B(0, num3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Max
	{
		get
		{
			return ln52pZ0fdo3;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num3 != ln52pZ0fdo3)
					{
						ln52pZ0fdo3 = num3;
						yYc2pgUYbd0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BE5972));
					}
					return;
				case 1:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
						{
							num = 1;
						}
						continue;
					}
					case 1:
						break;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
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
				case 2:
					propertyChangedEventHandler2 = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				default:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler, value3);
					propertyChangedEventHandler2 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					if ((object)propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						return;
					}
					break;
				}
				}
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool xDV2pReXaBf()
	{
		return jpB2pUjHiee;
	}

	public t7a8nS2pEfvgWvDrRM1o()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	public t7a8nS2pEfvgWvDrRM1o(int P_0, int P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		jpB2pUjHiee = true;
		Min = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
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
				Max = P_1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AWg2pdQHFse(bool P_0, int P_1, int P_2)
	{
		Checked = P_0;
		Min = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Max = P_2;
	}

	[NotifyPropertyChangedInvocator]
	private void yYc2pgUYbd0([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			rENMjIDo7wgUaGFjSApq(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	static t7a8nS2pEfvgWvDrRM1o()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool tO6LkODomf0bPSRtySVj()
	{
		return dLbFd5DoKiTWqEuECEsI == null;
	}

	internal static t7a8nS2pEfvgWvDrRM1o x9UdfKDoh1wNZU4a9CBb()
	{
		return dLbFd5DoKiTWqEuECEsI;
	}

	internal static int jKTV7YDowoO2sggqXr3B(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void rENMjIDo7wgUaGFjSApq(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
