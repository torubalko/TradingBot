using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Parts.HotKeys;
using TigerTrade.Parts.Symbols;
using TuAMtrl1Nd3XoZQQUXf0;

namespace LxkBMPH3MZ8ObkVk5Atk;

[DataContract(Name = "SymbolSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Symbols")]
internal sealed class p4gwA9H36qTSRys5LY33 : INotifyPropertyChanged
{
	[CompilerGenerated]
	private string aWQH3KpWLoK;

	private SymbolCommissionType QU0H3mrA4Ar;

	private double pCrH3hsr8ZI;

	private double G6KH3wZwSqJ;

	private SymbolHotKey EfnH37rZE5O;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static p4gwA9H36qTSRys5LY33 zGObRgDZpGZqhfaVJvR6;

	[Browsable(false)]
	[DataMember(Name = "SymbolID")]
	public string QA0H3WLB2Gj
	{
		[CompilerGenerated]
		get
		{
			return aWQH3KpWLoK;
		}
		[CompilerGenerated]
		set
		{
			aWQH3KpWLoK = text;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("SymbolSettingsCommissionType")]
	[T4IXj62qBfXCaxs2RI5("SymbolSettingsOptions")]
	[DataMember(Name = "CommissionType")]
	public SymbolCommissionType CommissionType
	{
		get
		{
			return QU0H3mrA4Ar;
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
					return;
				case 1:
					if (symbolCommissionType == QU0H3mrA4Ar)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
						{
							num2 = 0;
						}
						break;
					}
					QU0H3mrA4Ar = symbolCommissionType;
					i9MH3OGBoX9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839899630));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "BrokerComission")]
	[T4IXj62qBfXCaxs2RI5("SymbolSettingsOptions")]
	[bBo0Zd2ycQQr3LNHQf4("SymbolSettingsBrokerComission")]
	public double BrokerComission
	{
		get
		{
			return pCrH3hsr8ZI;
		}
		set
		{
			val = Math.Max(0.0, val);
			if (val.Equals(pCrH3hsr8ZI))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
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
				pCrH3hsr8ZI = val;
				i9MH3OGBoX9((string)KUYrxpDV05wrRk0VfxdN(0x28C965BE ^ 0x28CA936E));
			}
		}
	}

	[DataMember(Name = "ExchangeComission")]
	[bBo0Zd2ycQQr3LNHQf4("SymbolSettingsExchangeComission")]
	[T4IXj62qBfXCaxs2RI5("SymbolSettingsOptions")]
	public double ExchangeComission
	{
		get
		{
			return G6KH3wZwSqJ;
		}
		set
		{
			num = NHw2DUDV2rOJ485cn6gs(0.0, num);
			if (!num.Equals(G6KH3wZwSqJ))
			{
				G6KH3wZwSqJ = num;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				i9MH3OGBoX9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527002946));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("SymbolSettingsOptions")]
	[DataMember(Name = "HotKey")]
	[DefaultValue(SymbolHotKey.None)]
	[bBo0Zd2ycQQr3LNHQf4("SymbolSettingsHotKey")]
	public SymbolHotKey HotKey
	{
		get
		{
			return EfnH37rZE5O;
		}
		set
		{
			if (symbolHotKey != EfnH37rZE5O)
			{
				EfnH37rZE5O = symbolHotKey;
				i9MH3OGBoX9((string)KUYrxpDV05wrRk0VfxdN(-673683647 ^ -673476519));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)ENKhWuDVf9D7SgjHxAsh(propertyChangedEventHandler2, propertyChangedEventHandler3);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
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
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
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
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
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
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
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

	public p4gwA9H36qTSRys5LY33()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		CommissionType = SymbolCommissionType.Fixed;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ExchangeComission = 0.0;
				HotKey = SymbolHotKey.None;
				return;
			case 1:
				BrokerComission = 0.0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public p4gwA9H36qTSRys5LY33(string P_0)
	{
		WRuTS9DVHilaVGxBefA7();
		this._002Ector();
		QA0H3WLB2Gj = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[NotifyPropertyChangedInvocator]
	private void i9MH3OGBoX9([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static p4gwA9H36qTSRys5LY33()
	{
		OT5k3pDV9yLXpxmqoQxt();
	}

	internal static bool HVb9oqDZuUNuJdq6YnsX()
	{
		return zGObRgDZpGZqhfaVJvR6 == null;
	}

	internal static p4gwA9H36qTSRys5LY33 C3pHXiDZzsqX82DPHalB()
	{
		return zGObRgDZpGZqhfaVJvR6;
	}

	internal static object KUYrxpDV05wrRk0VfxdN(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static double NHw2DUDV2rOJ485cn6gs(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void WRuTS9DVHilaVGxBefA7()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object ENKhWuDVf9D7SgjHxAsh(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void OT5k3pDV9yLXpxmqoQxt()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
