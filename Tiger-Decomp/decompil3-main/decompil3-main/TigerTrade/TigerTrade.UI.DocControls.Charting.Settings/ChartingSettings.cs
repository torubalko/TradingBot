using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using AQB6mgf3wjOUxVfiEwwS;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using TigerTrade.Chart.Settings;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.DocControls.Charting.Settings;

[DataContract(Name = "ChartingSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal sealed class ChartingSettings : KqZtUj2kTEAQfYBkeSKy, ICloneable
{
	private bool _hidePanels;

	private bool _showChartSettings;

	private bool _showChartTrader;

	private bool _showChartTraderExpanded;

	private bool _showChartDom;

	private bool _chartTrading;

	private ChartSettings _chartSettings;

	private MarketSettings _marketSettings;

	internal static ChartingSettings pvZbdV4hP9Wu7pjXx1vJ;

	[DataMember(Name = "LinkMarketLevels")]
	public bool LinkMarketLevels
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[DataMember(Name = "HidePanels")]
	public bool HidePanels
	{
		get
		{
			return _hidePanels;
		}
		set
		{
			if (value != _hidePanels)
			{
				_hidePanels = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53744110));
			}
		}
	}

	[DataMember(Name = "ShowChartSettings")]
	public bool ShowChartSettings
	{
		get
		{
			return _showChartSettings;
		}
		set
		{
			if (value != _showChartSettings)
			{
				_showChartSettings = value;
				ifWlfmRSlkr((string)eUuuXo4h3wIjgsKlmPCG(0xC1DDB3B ^ 0xC1D60F7));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
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

	[DataMember(Name = "ShowChartTrader")]
	public bool ShowChartTrader
	{
		get
		{
			return _showChartTrader;
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
				case 0:
					return;
				case 1:
					if (value != _showChartTrader)
					{
						_showChartTrader = value;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801487248));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "ShowChartTraderExpanded")]
	public bool ShowChartTraderExpanded
	{
		get
		{
			return _showChartTraderExpanded;
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
					if (value == _showChartTraderExpanded)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
						{
							num2 = 0;
						}
						break;
					}
					_showChartTraderExpanded = value;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D5587F4));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "ShowChartDom")]
	public bool ShowChartDom
	{
		get
		{
			return _showChartDom;
		}
		set
		{
			if (value != _showChartDom)
			{
				_showChartDom = value;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD504F5));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
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

	public bool ChartTrading
	{
		get
		{
			return _chartTrading;
		}
		set
		{
			if (value != _chartTrading)
			{
				_chartTrading = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr((string)eUuuXo4h3wIjgsKlmPCG(-1435596783 ^ -1435618189));
			}
		}
	}

	[DataMember(Name = "ChartSettings")]
	[Browsable(false)]
	public ChartSettings ChartSettings
	{
		get
		{
			return _chartSettings ?? (_chartSettings = new ChartSettings());
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
					if (e9lQSo4hpDfisOg5X27Z(value, _chartSettings))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_chartSettings = value;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522675979));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "MarketSettings")]
	public MarketSettings MarketSettings
	{
		get
		{
			return _marketSettings ?? (_marketSettings = new MarketSettings());
		}
		set
		{
			if (!object.Equals(value, _marketSettings))
			{
				_marketSettings = value;
				ifWlfmRSlkr((string)eUuuXo4h3wIjgsKlmPCG(-602153869 ^ -602185921));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
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

	public override string DefaultTitle => (string)UhPe3x4wHO92eLTtpiVt();

	public void UpdateSettingsKey()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				s3oBtC4huRZATqkt0oeI(ChartSettings, base.Qom210PQiuE);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				((EpdvD7f3hWq8UlJ32f6V)jPIeVw4hzFEDgZgnD91s(MarketSettings)).DMlf37SVvG2(base.Qom210PQiuE);
				QmRTcG4w0CkoGVmhNqRV(MarketSettings.Preset3, base.Qom210PQiuE);
				MarketSettings.Preset4.DMlf37SVvG2(base.Qom210PQiuE);
				MarketSettings.Preset5.DMlf37SVvG2(base.Qom210PQiuE);
				return;
			default:
				MarketSettings.Preset1.DMlf37SVvG2(base.Qom210PQiuE);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public ChartingSettings()
	{
		yHOHPW4w2lV5embkxavN();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				ShowChartSettings = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
				{
					num = 0;
				}
				continue;
			case 3:
				base.vlP2kmioDGU = DefaultTitle;
				HidePanels = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num = 2;
				}
				continue;
			case 1:
				return;
			}
			ShowChartTrader = false;
			ShowChartTraderExpanded = false;
			ShowChartDom = false;
			ChartTrading = false;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
			{
				num = 0;
			}
		}
	}

	public object Clone()
	{
		ChartingSettings obj = new ChartingSettings
		{
			HidePanels = HidePanels
		};
		gcplW54wfGMVDxBbAyt2(obj, ShowChartSettings);
		obj.ShowChartTrader = ShowChartTrader;
		TXxc9v4w9tc21TYxHWNh(obj, ShowChartTraderExpanded);
		bh8QQ94wniTe5OWgtex4(obj, ShowChartDom);
		obj.ChartSettings = (ChartSettings)_chartSettings.Clone();
		mZXUo14wGotT6NXcMi6i(obj, (MarketSettings)MarketSettings.Clone());
		return obj;
	}

	static ChartingSettings()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool xaMntg4hJxWODQv8kcLd()
	{
		return pvZbdV4hP9Wu7pjXx1vJ == null;
	}

	internal static ChartingSettings Q37Gqw4hFTLpKuDPe0W2()
	{
		return pvZbdV4hP9Wu7pjXx1vJ;
	}

	internal static object eUuuXo4h3wIjgsKlmPCG(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool e9lQSo4hpDfisOg5X27Z(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void s3oBtC4huRZATqkt0oeI(object P_0, object P_1)
	{
		((ChartSettings)P_0).UpdateSettingsKey((string)P_1);
	}

	internal static object jPIeVw4hzFEDgZgnD91s(object P_0)
	{
		return ((MarketSettings)P_0).Preset2;
	}

	internal static void QmRTcG4w0CkoGVmhNqRV(object P_0, object P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).DMlf37SVvG2((string)P_1);
	}

	internal static void yHOHPW4w2lV5embkxavN()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object UhPe3x4wHO92eLTtpiVt()
	{
		return Resources.ChartingControlTitle;
	}

	internal static void gcplW54wfGMVDxBbAyt2(object P_0, bool value)
	{
		((ChartingSettings)P_0).ShowChartSettings = value;
	}

	internal static void TXxc9v4w9tc21TYxHWNh(object P_0, bool value)
	{
		((ChartingSettings)P_0).ShowChartTraderExpanded = value;
	}

	internal static void bh8QQ94wniTe5OWgtex4(object P_0, bool value)
	{
		((ChartingSettings)P_0).ShowChartDom = value;
	}

	internal static void mZXUo14wGotT6NXcMi6i(object P_0, object P_1)
	{
		((ChartingSettings)P_0).MarketSettings = (MarketSettings)P_1;
	}
}
