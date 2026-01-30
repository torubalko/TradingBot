using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TuAMtrl1Nd3XoZQQUXf0;

namespace zlck9A92XhonsRBe1pDI;

[DataContract(Name = "AppTelegramSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config")]
internal sealed class lvva2q92sGGEos9amhJM : INotifyPropertyChanged
{
	[CompilerGenerated]
	private static Action eAF92Cvqo3B;

	private bool cfO92r9QtUx;

	[CompilerGenerated]
	private string h5r92KCZfvU;

	[CompilerGenerated]
	private long BO992m3xwyf;

	private string Y6i92hw4O9m;

	private bool miK92w05Lka;

	private bool i59927sNHLs;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static lvva2q92sGGEos9amhJM sH0iGVbDysnmWvEEMR5i;

	[DataMember(Name = "Enable")]
	public bool Enable
	{
		get
		{
			return cfO92r9QtUx;
		}
		set
		{
			if (flag != cfO92r9QtUx)
			{
				cfO92r9QtUx = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				IqZ92cOE7Fh(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371637825));
			}
		}
	}

	[DataMember(Name = "BotToken")]
	public string p2492gj2atP
	{
		[CompilerGenerated]
		get
		{
			return h5r92KCZfvU;
		}
		[CompilerGenerated]
		set
		{
			h5r92KCZfvU = text;
		}
	}

	[DataMember(Name = "UserId")]
	public long aaZ92Mn5dM1
	{
		[CompilerGenerated]
		get
		{
			return BO992m3xwyf;
		}
		[CompilerGenerated]
		set
		{
			BO992m3xwyf = bO992m3xwyf;
		}
	}

	[DataMember(Name = "ProxyId")]
	public string C2O92IhE5C2
	{
		get
		{
			return Y6i92hw4O9m;
		}
		set
		{
			if (Y6i92hw4O9m == text)
			{
				return;
			}
			Y6i92hw4O9m = text;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
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
				{
					Action action = eAF92Cvqo3B;
					if (action == null)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
						{
							num = 0;
						}
						break;
					}
					action();
					return;
				}
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "SendOrders")]
	public bool SendOrders
	{
		get
		{
			return miK92w05Lka;
		}
		set
		{
			if (flag != miK92w05Lka)
			{
				miK92w05Lka = flag;
				IqZ92cOE7Fh((string)UvLta1bDrR24X17dZQtg(-1009517961 ^ -1009524025));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
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

	[DataMember(Name = "SendExecutions")]
	public bool SendExecutions
	{
		get
		{
			return i59927sNHLs;
		}
		set
		{
			if (flag != i59927sNHLs)
			{
				i59927sNHLs = flag;
				IqZ92cOE7Fh(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338767362));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
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

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
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
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public static void n9h92yXBOjh(Action P_0)
	{
		Action action = eAF92Cvqo3B;
		while (true)
		{
			Action action2 = action;
			Action value = (Action)AyZ5kfbDC1DtFDx4T6IN(action2, P_0);
			action = Interlocked.CompareExchange(ref eAF92Cvqo3B, value, action2);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
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
				if ((object)action != action2)
				{
					break;
				}
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num = 0;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public static void aLI92ZUAok9(Action P_0)
	{
		Action action = eAF92Cvqo3B;
		while (true)
		{
			Action action2 = action;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
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
				Action value = (Action)Delegate.Remove(action2, P_0);
				action = Interlocked.CompareExchange(ref eAF92Cvqo3B, value, action2);
				if ((object)action != action2)
				{
					break;
				}
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
				{
					num = 1;
				}
			}
		}
	}

	public lvva2q92sGGEos9amhJM()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Enable = false;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				p2492gj2atP = "";
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num = 0;
				}
				break;
			default:
				aaZ92Mn5dM1 = 0L;
				SendOrders = false;
				SendExecutions = false;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void IqZ92cOE7Fh([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static lvva2q92sGGEos9amhJM()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object AyZ5kfbDC1DtFDx4T6IN(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static bool zLVtOqbDZlPpbUlc3vVo()
	{
		return sH0iGVbDysnmWvEEMR5i == null;
	}

	internal static lvva2q92sGGEos9amhJM yvupmBbDVfLyhVB3rgHa()
	{
		return sH0iGVbDysnmWvEEMR5i;
	}

	internal static object UvLta1bDrR24X17dZQtg(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
