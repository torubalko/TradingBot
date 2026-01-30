using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using AFhqHf9jBdUU0oY6bWZl;
using AMj7i59xpIF2mbHGTtbm;
using b1neT39sxtGuKbVPRyqn;
using ECOEgqlSad8NUJZ2Dr9n;
using jS3Y2j9pTQRy0FnOknFG;
using O4MOGg9s9Mb8ki42CBMv;
using oaHFMv2b4o31O8WGaeUF;
using oecYxS9xZZ8gWvdvTg3u;
using PMH7kB9LS7xf0LikQbe5;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Theme;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;
using Ubyym82bHttFNkeQsYlY;

namespace TigerTrade.Chart.Settings;

[DataContract(Name = "ChartSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Settings")]
internal sealed class ChartSettings : VUcpcX9sfGdSlTmYZQvV, IChartSettings, ICloneable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class oU60DdnFTC70Wendb9IF
	{
		public static readonly oU60DdnFTC70Wendb9IF mpNnFZIE0BE;

		public static Func<CR9nZ49x3RUlacnAckjy, CR9nZ49x3RUlacnAckjy> T5cnFVOG1Gn;

		private static oU60DdnFTC70Wendb9IF snjc1tNqTmvJRwXDO51M;

		static oU60DdnFTC70Wendb9IF()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					mpNnFZIE0BE = new oU60DdnFTC70Wendb9IF();
					return;
				case 1:
					IcFdXhNqVuDBmaoSvaik();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public oU60DdnFTC70Wendb9IF()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal CR9nZ49x3RUlacnAckjy JC1nFyO94Gc(CR9nZ49x3RUlacnAckjy x)
		{
			return (CR9nZ49x3RUlacnAckjy)k6MSb3NqCbqy8CrMtveC(x);
		}

		internal static void IcFdXhNqVuDBmaoSvaik()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool s0BRZ6NqybgSWcu6qS8R()
		{
			return snjc1tNqTmvJRwXDO51M == null;
		}

		internal static oU60DdnFTC70Wendb9IF f0WrNiNqZDu8qD79D5LL()
		{
			return snjc1tNqTmvJRwXDO51M;
		}

		internal static object k6MSb3NqCbqy8CrMtveC(object P_0)
		{
			return ((VUcpcX9sfGdSlTmYZQvV)P_0).Clone();
		}
	}

	private ChartTheme _theme;

	private List<CR9nZ49x3RUlacnAckjy> _areas;

	private double _columnWidth;

	private double _columnWidth2;

	private ee3m5R2blOAsUyGExn75 _stepHeightParam;

	private double _rightMargin;

	private DataCycle _dataCycle;

	private u9cjrs2b2q0r2LuEQmub _dataScaleParam;

	private StockViewType _stockViewType;

	private StockViewType _stockViewType2;

	private ChartCursorType _cursorType;

	private int _scaleValue;

	private bool _magnetMode;

	private bool _strongMagnetMode;

	private bool _lockAllObjects;

	private bool _hideAllObjects;

	private mR4Dhe9jvRbCaGB7gqgA _visualSettings;

	private KO34fu9L5FtbhDmWJ1ad _clusterSettings;

	private dyykKj9sS7wbwJvEPZ4K _tradeSettings;

	private bool _isMarketLocked;

	private int? _lockedMarketSymbolType;

	private bool _isSymbolSwitchError;

	private bool _isExchangeLocked;

	private string _lockedExchange;

	private XFont _chartFont;

	private XFont _chartFontBold;

	private XFont _chartSymbolFont;

	private static ChartSettings e06fCybXXymIf7T2OYMx;

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

	[DataMember(Name = "TemplateID")]
	public string TemplateID { get; set; }

	[DataMember(Name = "TemplateName")]
	public string TemplateName { get; set; }

	[DataMember(Name = "ContainsIndicators")]
	public bool ContainsIndicators { get; set; }

	[DataMember(Name = "ContainsObjects")]
	public bool ContainsObjects { get; set; }

	[DataMember(Name = "ContainsPeriod")]
	public bool ContainsPeriod { get; set; }

	[DataMember(Name = "ContainsTheme")]
	public bool ContainsTheme { get; set; }

	[DataMember(Name = "ContainsTradeSettings")]
	public bool ContainsTradeSettings { get; set; }

	[DataMember(Name = "Theme")]
	public ChartTheme Theme
	{
		get
		{
			return _theme ?? (_theme = (ChartTheme)IaeQgHbXEYHLlnV4OpFk());
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
					if (object.Equals(value, _theme))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
						{
							num2 = 0;
						}
						break;
					}
					_theme = value;
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325262909));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "Areas")]
	public List<CR9nZ49x3RUlacnAckjy> Areas
	{
		get
		{
			return _areas ?? (_areas = new List<CR9nZ49x3RUlacnAckjy>());
		}
		set
		{
			if (!object.Equals(value, _areas))
			{
				_areas = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520400541));
			}
		}
	}

	[DataMember(Name = "ColumnWidth")]
	public double ColumnWidth
	{
		get
		{
			return _columnWidth;
		}
		set
		{
			if (!value.Equals(_columnWidth))
			{
				_columnWidth = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1152964287));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
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

	[DataMember(Name = "ColumnWidth2")]
	public double ColumnWidth2
	{
		get
		{
			return _columnWidth2;
		}
		set
		{
			if (!value.Equals(_columnWidth2))
			{
				_columnWidth2 = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E0079CA));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
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

	[DataMember(Name = "StepHeightParam")]
	public ee3m5R2blOAsUyGExn75 StepHeightParam
	{
		get
		{
			return _stepHeightParam ?? (_stepHeightParam = new ee3m5R2blOAsUyGExn75(0.0));
		}
		set
		{
			_stepHeightParam = value;
		}
	}

	public double StepHeight
	{
		get
		{
			return StepHeightParam.Jva2DwEHfew(base.RYc9sBOlPSU);
		}
		set
		{
			if (StepHeightParam.VJL2bDnC6kr(base.RYc9sBOlPSU, value, 0.0))
			{
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB11273C));
			}
		}
	}

	[DataMember(Name = "RightMargin")]
	public double RightMargin
	{
		get
		{
			return _rightMargin;
		}
		set
		{
			if (value != _rightMargin)
			{
				_rightMargin = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				sQM9sYVV4VP((string)dGNsFDbXQnlcG0Stt10Z(0x24B0B9E6 ^ 0x24B4E688));
			}
		}
	}

	[DataMember(Name = "DataCycle")]
	public DataCycle DataCycle
	{
		get
		{
			return _dataCycle ?? (_dataCycle = DataCycle.Minute);
		}
		set
		{
			if (object.Equals(value, _dataCycle))
			{
				return;
			}
			_dataCycle = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
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
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82841822));
				UpdateSettingsKey(base.RYc9sBOlPSU);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num = 0;
				}
			}
		}
	}

	[DataMember(Name = "DataScaleParam")]
	public u9cjrs2b2q0r2LuEQmub DataScaleParam
	{
		get
		{
			return _dataScaleParam ?? (_dataScaleParam = new u9cjrs2b2q0r2LuEQmub(1));
		}
		set
		{
			_dataScaleParam = value;
		}
	}

	public int DataScale
	{
		get
		{
			return DataScaleParam.kOx2DhNaCjU(base.RYc9sBOlPSU, 1);
		}
		set
		{
			if (DataScaleParam.js02bfsgQ4R(base.RYc9sBOlPSU, value, 1))
			{
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADB87BD));
			}
		}
	}

	[DataMember(Name = "StockViewType")]
	public StockViewType StockViewType
	{
		get
		{
			return _stockViewType;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					sQM9sYVV4VP((string)dGNsFDbXQnlcG0Stt10Z(-5977659 ^ -5999253));
					return;
				case 1:
					return;
				case 2:
					if (value != _stockViewType)
					{
						if (value != StockViewType.Clusters)
						{
							StockViewType2 = value;
						}
						_stockViewType = value;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num2 = 1;
						}
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "StockViewType2")]
	public StockViewType StockViewType2
	{
		get
		{
			return _stockViewType2;
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
					value = StockViewType.Candles;
					break;
				case 1:
					if (value == StockViewType.Clusters)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					return;
				}
				if (value == _stockViewType2)
				{
					break;
				}
				_stockViewType2 = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x73908DFA));
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[DataMember(Name = "CursorType")]
	public ChartCursorType CursorType
	{
		get
		{
			return _cursorType;
		}
		set
		{
			if (value != _cursorType)
			{
				_cursorType = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADB4A5D));
			}
		}
	}

	[DataMember(Name = "ScaleValue")]
	public int ScaleValue
	{
		get
		{
			return _scaleValue;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					value = Math.Max(-10, RPY31gbXdg6QAUgYKT5o(10, value));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (value != _scaleValue)
				{
					_scaleValue = value;
					UpdateFonts();
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801724782));
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[DataMember(Name = "MagnetMode")]
	public bool MagnetMode
	{
		get
		{
			return _magnetMode;
		}
		set
		{
			if (value == _magnetMode)
			{
				return;
			}
			_magnetMode = value;
			sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763959211));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
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
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342465290));
				if (!value)
				{
					return;
				}
				StrongMagnetMode = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "StrongMagnetMode")]
	public bool StrongMagnetMode
	{
		get
		{
			return _strongMagnetMode;
		}
		set
		{
			if (value == _strongMagnetMode)
			{
				return;
			}
			_strongMagnetMode = value;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6253053));
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
					{
						num = 2;
					}
					break;
				default:
					if (value)
					{
						MagnetMode = false;
					}
					return;
				case 2:
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583068434));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsAnyMagnetOn
	{
		get
		{
			if (!MagnetMode)
			{
				return StrongMagnetMode;
			}
			return true;
		}
	}

	[DataMember(Name = "LockAllObjects")]
	public bool LockAllObjects
	{
		get
		{
			return _lockAllObjects;
		}
		set
		{
			if (value != _lockAllObjects)
			{
				_lockAllObjects = value;
				sQM9sYVV4VP((string)dGNsFDbXQnlcG0Stt10Z(0x7F55E538 ^ 0x7F54EDBC));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
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

	[DataMember(Name = "HideAllObjects")]
	public bool HideAllObjects
	{
		get
		{
			return _hideAllObjects;
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
					if (value == _hideAllObjects)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_hideAllObjects = value;
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBFE295));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "VisualSettings")]
	public mR4Dhe9jvRbCaGB7gqgA VisualSettings
	{
		get
		{
			return _visualSettings ?? (_visualSettings = new mR4Dhe9jvRbCaGB7gqgA());
		}
		set
		{
			if (!object.Equals(value, _visualSettings))
			{
				_visualSettings = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28FA69C));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
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

	[DataMember(Name = "ClusterSettings")]
	public KO34fu9L5FtbhDmWJ1ad ClusterSettings
	{
		get
		{
			return _clusterSettings ?? (_clusterSettings = new KO34fu9L5FtbhDmWJ1ad());
		}
		set
		{
			if (!object.Equals(value, _clusterSettings))
			{
				_clusterSettings = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x3401CCD));
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
		}
	}

	[DataMember(Name = "TradeSettings")]
	public dyykKj9sS7wbwJvEPZ4K TradeSettings
	{
		get
		{
			return _tradeSettings ?? (_tradeSettings = new dyykKj9sS7wbwJvEPZ4K());
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
					if (object.Equals(value, _tradeSettings))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
						{
							num2 = 0;
						}
						break;
					}
					_tradeSettings = value;
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4293D873));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "IsMarketLocked")]
	public bool IsMarketLocked
	{
		get
		{
			return _isMarketLocked;
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
					if (object.Equals(value, _isMarketLocked))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_isMarketLocked = value;
					sQM9sYVV4VP((string)dGNsFDbXQnlcG0Stt10Z(-710503328 ^ -710482580));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "LockedMarketSymbolType")]
	public int? LockedMarketSymbolType
	{
		get
		{
			return _lockedMarketSymbolType;
		}
		set
		{
			if (value != _lockedMarketSymbolType)
			{
				_lockedMarketSymbolType = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D187B0E));
			}
		}
	}

	[DataMember(Name = "IsSymbolSwitchError")]
	public bool IsSymbolSwitchError
	{
		get
		{
			return _isSymbolSwitchError;
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
					if (value == _isSymbolSwitchError)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_isSymbolSwitchError = value;
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x60628C5D));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "IsExchangeLocked")]
	public bool IsExchangeLocked
	{
		get
		{
			return _isExchangeLocked;
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
					if (value != _isExchangeLocked)
					{
						_isExchangeLocked = value;
						sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1417018747));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "LockedExchange")]
	public string LockedExchange
	{
		get
		{
			return _lockedExchange;
		}
		set
		{
			if (!FYWujmbXgbU3MAPMCLxN(value, _lockedExchange))
			{
				_lockedExchange = value;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153174133));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
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

	public XFont ChartFont
	{
		get
		{
			return _chartFont ?? (_chartFont = new XFont());
		}
		private set
		{
			_chartFont = value;
		}
	}

	public XFont ChartFontBold
	{
		get
		{
			return _chartFontBold ?? (_chartFontBold = new XFont(bold: true));
		}
		private set
		{
			_chartFontBold = value;
		}
	}

	public XFont ChartSymbolFont
	{
		get
		{
			return _chartSymbolFont ?? (_chartSymbolFont = new XFont());
		}
		set
		{
			_chartSymbolFont = value;
		}
	}

	public bool ChartShowSymbol => U1998IbXmfE1irnQRkis(j18iDj9nukSCmEyZs5lH.Settings);

	public XColor ChartSymbolForegroundColor => a39l4UbXhAwIoWqqJa1S(j18iDj9nukSCmEyZs5lH.Settings);

	private string FontName { get; set; }

	private int FontSize { get; set; }

	public bool TransformHorLines => ClusterSettings.TransformHorLines;

	public bool TransformVertLines => eVf18EbX8kQVdOGfKnZH(ClusterSettings);

	public void SetStepHeight(double height)
	{
		StepHeightParam.VJL2bDnC6kr(base.RYc9sBOlPSU, height, 0.0);
	}

	public int GetDataScale(string symbolID)
	{
		return DataScaleParam.kOx2DhNaCjU(symbolID, 1);
	}

	public ChartSettings()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				ScaleValue = 0;
				MagnetMode = false;
				int num2 = 9;
				num = num2;
				break;
			}
			case 6:
				RightMargin = 0.0;
				DataCycle = (DataCycle)flQ2s4bXRuMHXH5xS9nu();
				StockViewType = StockViewType.Candles;
				StockViewType2 = StockViewType.Candles;
				num = 5;
				break;
			case 5:
				CursorType = ChartCursorType.Default;
				num = 4;
				break;
			case 7:
				ContainsIndicators = true;
				ContainsObjects = true;
				Theme = (ChartTheme)IaeQgHbXEYHLlnV4OpFk();
				num = 8;
				break;
			case 8:
				Areas = new List<CR9nZ49x3RUlacnAckjy>();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num = 2;
				}
				break;
			default:
				IsMarketLocked = false;
				IsSymbolSwitchError = false;
				return;
			case 3:
				ClusterSettings = new KO34fu9L5FtbhDmWJ1ad();
				TradeSettings = new dyykKj9sS7wbwJvEPZ4K();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ColumnWidth = 5.0;
				ColumnWidth2 = 50.0;
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
				{
					num = 2;
				}
				break;
			case 9:
				LockAllObjects = false;
				HideAllObjects = false;
				VisualSettings = new mR4Dhe9jvRbCaGB7gqgA();
				num = 3;
				break;
			case 1:
				ContainsPeriod = true;
				ContainsTheme = true;
				num = 7;
				break;
			}
		}
	}

	public void UpdateSettingsKey(string shortKey)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				TradeSettings.CLL9ssW1FnH(text, shortKey);
				UpdateChanges();
				return;
			case 4:
				l8Xm9QbXOXRiBMjiEa65(ClusterSettings, text, shortKey);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (string.IsNullOrEmpty(shortKey))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = BaOKHQbXMnOK4KWvjNIR(shortKey, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404EFDEE), AeDLT8bX6qQY5HLog2Oe(DataCycle));
				break;
			case 1:
				obj = null;
				break;
			case 3:
				VisualSettings.NF19jaFo4Md(text, shortKey);
				num2 = 4;
				continue;
			}
			text = (base.d8J9slSlLBq = (string)obj);
			base.RYc9sBOlPSU = shortKey;
			num2 = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
			{
				num2 = 3;
			}
		}
	}

	private void UpdateChanges()
	{
		sQM9sYVV4VP((string)dGNsFDbXQnlcG0Stt10Z(-1962651919 ^ -1962655779));
		sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710751434));
	}

	public void CopySettings(ChartSettings settings, bool full)
	{
		int num = 1;
		int num2 = num;
		List<CR9nZ49x3RUlacnAckjy>.Enumerator enumerator = default(List<CR9nZ49x3RUlacnAckjy>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (settings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			}
			try
			{
				ChartSettings chartSettings = ConfigSerializer.LoadFromString<ChartSettings>(ConfigSerializer.SaveToString(settings, (DataContractResolver)xhXmXVbXqGfSVhQ9HOCZ()), jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
				int num3;
				if (full || chartSettings.ContainsTheme)
				{
					Theme.CopyTheme(chartSettings.Theme);
					num3 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
					{
						num3 = 0;
					}
					goto IL_0045;
				}
				goto IL_027b;
				IL_027b:
				if (!full)
				{
					if (chartSettings.ContainsIndicators)
					{
						goto IL_0499;
					}
					if (!chartSettings.ContainsObjects)
					{
						goto IL_0460;
					}
					num3 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num3 = 13;
					}
				}
				else
				{
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num3 = 0;
					}
				}
				goto IL_0045;
				IL_0147:
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB700E9));
				goto IL_027b;
				IL_0499:
				if (!chartSettings.ContainsIndicators)
				{
					enumerator = chartSettings.Areas.GetEnumerator();
					num3 = 9;
					goto IL_0045;
				}
				goto IL_0227;
				IL_0045:
				while (true)
				{
					switch (num3)
					{
					case 4:
						goto IL_0147;
					case 10:
					{
						DataScaleParam.QSM2D8R8ont(chartSettings.DataScaleParam);
						StockViewType = ohIm53bXU9AS7gDd2OwI(chartSettings);
						int num5 = 8;
						num3 = num5;
						continue;
					}
					case 7:
						DataCycle = chartSettings.DataCycle;
						num3 = 10;
						continue;
					case 12:
						try
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Objects.Clear();
								int num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								}
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
						goto IL_0257;
					case 2:
						goto IL_0257;
					case 11:
						enumerator = chartSettings.Areas.GetEnumerator();
						num3 = 12;
						continue;
					case 15:
						LockAllObjects = FwwL6xbXyCWNTEKHhqxn(chartSettings);
						HideAllObjects = chartSettings.HideAllObjects;
						num3 = 14;
						continue;
					case 6:
						UpdateChanges();
						return;
					case 1:
						kexo8IbXCJcBCvExI5RD(ClusterSettings, YY9sb7bXVaD6Hf22XsXT(chartSettings));
						zvCZo2bXrCilKZvKRyFG(TradeSettings, chartSettings.TradeSettings, chartSettings.ContainsTradeSettings || full);
						num3 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num3 = 6;
						}
						continue;
					case 14:
						khqc9HbXZIkshf2pxBlf(VisualSettings, chartSettings.VisualSettings);
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num3 = 0;
						}
						continue;
					case 9:
						goto IL_037e;
					case 5:
						if (!full)
						{
							if (chartSettings.ContainsPeriod)
							{
								num3 = 7;
								continue;
							}
							goto case 10;
						}
						goto case 7;
					case 8:
						StockViewType2 = chartSettings.StockViewType;
						CursorType = chartSettings.CursorType;
						ScaleValue = chartSettings.ScaleValue;
						MagnetMode = dMdL8IbXTYapZaOSM4GV(chartSettings);
						num3 = 15;
						continue;
					case 3:
						ColumnWidth2 = chartSettings.ColumnWidth2;
						RightMargin = jm3HKbbXtLw5wH8QxRWM(chartSettings);
						StepHeightParam.QSM2D8R8ont(chartSettings.StepHeightParam);
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
						{
							num3 = 5;
						}
						continue;
					case 13:
						goto IL_0499;
					}
					break;
				}
				Areas = chartSettings.Areas;
				goto IL_0460;
				IL_0227:
				if (!chartSettings.ContainsObjects)
				{
					num3 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
					{
						num3 = 11;
					}
					goto IL_0045;
				}
				goto IL_0257;
				IL_0257:
				Areas = chartSettings.Areas;
				goto IL_0460;
				IL_037e:
				try
				{
					while (enumerator.MoveNext())
					{
						jq2CwLbXIplt3X6FnDQf(enumerator.Current.Indicators);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto IL_0227;
				IL_0460:
				ColumnWidth = rPSTcFbXWAJX1JW03gs0(chartSettings);
				num3 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
				{
					num3 = 3;
				}
				goto IL_0045;
			}
			catch (Exception ex)
			{
				BmWJ0gbXKSPuq1jibLiK(ex);
				return;
			}
		}
	}

	public void SaveTemplate()
	{
		sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D317B11));
	}

	public void RiseUpdate()
	{
		sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962260411));
	}

	public void PrepareFonts()
	{
		string text = j18iDj9nukSCmEyZs5lH.Settings.ChartFontName;
		if (string.IsNullOrEmpty(text))
		{
			text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225809281);
		}
		int num = B0YWpXbXw6n1IeDRRO9O(j18iDj9nukSCmEyZs5lH.Settings);
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				if (num < 8 || num > 50)
				{
					num = 14;
				}
				FontName = text;
				num2 = 3;
				break;
			case 2:
				UpdateFonts();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				FontSize = num;
				num2 = 2;
				break;
			}
		}
	}

	private void UpdateFonts()
	{
		int num = 2;
		int num2 = num;
		double size = default(double);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 7:
				size = (double)FontSize * num3;
				num2 = 5;
				continue;
			case 2:
				num3 = 1.0;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				ChartSymbolFont = new XFont(FontName, vi24h1bX72fsUM1Gw25L(j18iDj9nukSCmEyZs5lH.Settings));
				return;
			case 1:
				if (ScaleValue > 0)
				{
					num3 = 1.0 + (double)ScaleValue * 0.2;
					goto IL_011a;
				}
				goto case 3;
			case 6:
				num3 = 1.0 + (double)ScaleValue * 0.06;
				goto IL_011a;
			case 5:
				ChartFont = new XFont(FontName, size);
				ChartFontBold = new XFont(FontName, size, bold: true);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				{
					if (ScaleValue < 0)
					{
						num2 = 6;
						continue;
					}
					goto IL_011a;
				}
				IL_011a:
				if (string.IsNullOrEmpty(FontName))
				{
					FontName = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7BCB4);
				}
				if (FontSize < 8)
				{
					break;
				}
				if (FontSize > 50)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			}
			FontSize = 14;
			num2 = 7;
		}
	}

	public new object Clone()
	{
		ChartSettings obj = new ChartSettings
		{
			Theme = (ChartTheme)Theme.Clone(),
			TemplateID = TemplateID,
			TemplateName = TemplateName
		};
		YveO8bbXAO99cXNOntMe(obj, ContainsIndicators);
		obj.ContainsObjects = ContainsObjects;
		RqkNJPbXPXuAX6sbXOKf(obj, ContainsPeriod);
		obj.ContainsTheme = ContainsTheme;
		obj.ContainsTradeSettings = ContainsTradeSettings;
		obj.Areas = new List<CR9nZ49x3RUlacnAckjy>(Areas.Select((CR9nZ49x3RUlacnAckjy x) => (CR9nZ49x3RUlacnAckjy)oU60DdnFTC70Wendb9IF.k6MSb3NqCbqy8CrMtveC(x)));
		obj.ColumnWidth = ColumnWidth;
		OJiXa1bXJeBmH05qv8uW(obj, ColumnWidth2);
		obj.StepHeightParam = (ee3m5R2blOAsUyGExn75)StepHeightParam.Clone();
		obj.RightMargin = RightMargin;
		obj.DataCycle = (DataCycle)DataCycle.Clone();
		obj.DataScaleParam = (u9cjrs2b2q0r2LuEQmub)DataScaleParam.Clone();
		obj.StockViewType = StockViewType;
		obj.StockViewType2 = StockViewType2;
		Gk6L0nbXFZmIUUeUrm05(obj, CursorType);
		obj.ScaleValue = ScaleValue;
		eXv6VYbX3q12wsRHivc6(obj, MagnetMode);
		obj.StrongMagnetMode = StrongMagnetMode;
		i9HuQLbXpqWslKnflHBd(obj, LockAllObjects);
		obj.HideAllObjects = HideAllObjects;
		quspNkbXukudyFas62Qj(obj, (mR4Dhe9jvRbCaGB7gqgA)VisualSettings.Clone());
		obj.ClusterSettings = (KO34fu9L5FtbhDmWJ1ad)ClusterSettings.Clone();
		obj.TradeSettings = (dyykKj9sS7wbwJvEPZ4K)TradeSettings.Clone();
		obj.IsMarketLocked = IsMarketLocked;
		obj.LockedMarketSymbolType = LockedMarketSymbolType;
		obj.IsSymbolSwitchError = IsSymbolSwitchError;
		KbOO6sbXzLjXlF3Qxak3(obj, IsExchangeLocked);
		obj.LockedExchange = LockedExchange;
		return obj;
	}

	static ChartSettings()
	{
		gQDcDHbc0IMVxU2S5whx();
	}

	internal static bool Oqh4wXbXctG0yGQ6nkD9()
	{
		return e06fCybXXymIf7T2OYMx == null;
	}

	internal static ChartSettings gbuuc4bXjOYmuA5EqfwZ()
	{
		return e06fCybXXymIf7T2OYMx;
	}

	internal static object IaeQgHbXEYHLlnV4OpFk()
	{
		return inug6w9xygmyBdLc9sPv.cMl9xhQOsrv();
	}

	internal static object dGNsFDbXQnlcG0Stt10Z(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static int RPY31gbXdg6QAUgYKT5o(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool FYWujmbXgbU3MAPMCLxN(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object flQ2s4bXRuMHXH5xS9nu()
	{
		return DataCycle.Minute;
	}

	internal static object AeDLT8bX6qQY5HLog2Oe(object P_0)
	{
		return ((DataCycle)P_0).GetKey();
	}

	internal static object BaOKHQbXMnOK4KWvjNIR(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void l8Xm9QbXOXRiBMjiEa65(object P_0, object P_1, object P_2)
	{
		((KO34fu9L5FtbhDmWJ1ad)P_0).Erf9Lxoq9Se((string)P_1, (string)P_2);
	}

	internal static object xhXmXVbXqGfSVhQ9HOCZ()
	{
		return jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns();
	}

	internal static void jq2CwLbXIplt3X6FnDQf(object P_0)
	{
		((List<IndicatorBase>)P_0).Clear();
	}

	internal static double rPSTcFbXWAJX1JW03gs0(object P_0)
	{
		return ((ChartSettings)P_0).ColumnWidth;
	}

	internal static double jm3HKbbXtLw5wH8QxRWM(object P_0)
	{
		return ((ChartSettings)P_0).RightMargin;
	}

	internal static StockViewType ohIm53bXU9AS7gDd2OwI(object P_0)
	{
		return ((ChartSettings)P_0).StockViewType;
	}

	internal static bool dMdL8IbXTYapZaOSM4GV(object P_0)
	{
		return ((ChartSettings)P_0).MagnetMode;
	}

	internal static bool FwwL6xbXyCWNTEKHhqxn(object P_0)
	{
		return ((ChartSettings)P_0).LockAllObjects;
	}

	internal static void khqc9HbXZIkshf2pxBlf(object P_0, object P_1)
	{
		((mR4Dhe9jvRbCaGB7gqgA)P_0).XO99jlWhdan((mR4Dhe9jvRbCaGB7gqgA)P_1);
	}

	internal static object YY9sb7bXVaD6Hf22XsXT(object P_0)
	{
		return ((ChartSettings)P_0).ClusterSettings;
	}

	internal static void kexo8IbXCJcBCvExI5RD(object P_0, object P_1)
	{
		((KO34fu9L5FtbhDmWJ1ad)P_0).LjI9LsN4QKM((KO34fu9L5FtbhDmWJ1ad)P_1);
	}

	internal static void zvCZo2bXrCilKZvKRyFG(object P_0, object P_1, bool P_2)
	{
		((dyykKj9sS7wbwJvEPZ4K)P_0).qiK9scdomvR((dyykKj9sS7wbwJvEPZ4K)P_1, P_2);
	}

	internal static void BmWJ0gbXKSPuq1jibLiK(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static bool U1998IbXmfE1irnQRkis(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartShowSymbolNameOnBackground;
	}

	internal static XColor a39l4UbXhAwIoWqqJa1S(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameForegroundColor;
	}

	internal static int B0YWpXbXw6n1IeDRRO9O(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartFontSize;
	}

	internal static int vi24h1bX72fsUM1Gw25L(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameFontSize;
	}

	internal static bool eVf18EbX8kQVdOGfKnZH(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).TransformVertLines;
	}

	internal static void YveO8bbXAO99cXNOntMe(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsIndicators = value;
	}

	internal static void RqkNJPbXPXuAX6sbXOKf(object P_0, bool value)
	{
		((ChartSettings)P_0).ContainsPeriod = value;
	}

	internal static void OJiXa1bXJeBmH05qv8uW(object P_0, double value)
	{
		((ChartSettings)P_0).ColumnWidth2 = value;
	}

	internal static void Gk6L0nbXFZmIUUeUrm05(object P_0, ChartCursorType value)
	{
		((ChartSettings)P_0).CursorType = value;
	}

	internal static void eXv6VYbX3q12wsRHivc6(object P_0, bool value)
	{
		((ChartSettings)P_0).MagnetMode = value;
	}

	internal static void i9HuQLbXpqWslKnflHBd(object P_0, bool value)
	{
		((ChartSettings)P_0).LockAllObjects = value;
	}

	internal static void quspNkbXukudyFas62Qj(object P_0, object P_1)
	{
		((ChartSettings)P_0).VisualSettings = (mR4Dhe9jvRbCaGB7gqgA)P_1;
	}

	internal static void KbOO6sbXzLjXlF3Qxak3(object P_0, bool value)
	{
		((ChartSettings)P_0).IsExchangeLocked = value;
	}

	internal static void gQDcDHbc0IMVxU2S5whx()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
