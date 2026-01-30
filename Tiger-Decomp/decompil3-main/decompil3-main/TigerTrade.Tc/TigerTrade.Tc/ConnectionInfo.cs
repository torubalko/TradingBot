using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using OhwR2LaxHYJ0lj0C9GSK;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Tc.Annotations;
using TigerTrade.Tc.Manager;
using x97CE55GhEYKgt7TSVZT;
using xtKZMnaLHhXNCotZhjGh;

namespace TigerTrade.Tc;

public sealed class ConnectionInfo : INotifyPropertyChanged
{
	private string _connectionName;

	private bool _isConnected;

	private bool _connectState;

	private int _indicator;

	private qXLXHlax25yCgG9femcG _proxyData;

	private bool _isConnecting;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ConnectionInfo MU1t1w5WWVnDTkQZRXcb;

	public string TradeClientID { get; }

	public string TradeClientName { get; }

	public string TradeClientExtra { get; }

	public string ConnectionID { get; }

	public string ConnectionName
	{
		get
		{
			return _connectionName;
		}
		set
		{
			_connectionName = value;
			OnPropertyChanged(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461292091 ^ -1461267795));
		}
	}

	public bool Simulator { get; }

	public bool Trust { get; }

	public string MarketType { get; set; }

	internal string SettingsFile { get; }

	internal string PositionsFile { get; }

	internal string DataPath { get; }

	internal string LogsPath { get; private set; }

	internal bool AsyncOrders { get; set; }

	public bool MarketData { get; set; }

	public bool AutoConnect { get; set; }

	public bool IsConnected
	{
		get
		{
			return _isConnected;
		}
		internal set
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
					if (value == _isConnected)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_isConnected = value;
					lEogQ45WT4tK3cfcnkkl((Action)delegate
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								IsConnecting = false;
								OnPropertyChanged(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7FD14D));
								return;
							case 1:
								_connectState = IsConnected;
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool IsConnecting
	{
		get
		{
			return _isConnecting;
		}
		set
		{
			_isConnecting = value;
			lEogQ45WT4tK3cfcnkkl((Action)delegate
			{
				OnPropertyChanged(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DE06D1));
				OnPropertyChanged((string)RtgJO25WC7DF6KnhJtQ9(-1192989954 ^ -1192965950));
			});
		}
	}

	public bool ConnectState
	{
		get
		{
			return _connectState;
		}
		set
		{
			if (!AllowConnect)
			{
				IsConnecting = false;
				return;
			}
			int num;
			if (IsConnecting)
			{
				num = 3;
				goto IL_0009;
			}
			goto IL_0097;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
				{
					IsConnecting = false;
					int num2 = 2;
					num = num2;
					continue;
				}
				case 2:
					return;
				case 3:
					break;
				case 4:
					_connectState = true;
					IsConnecting = true;
					mfsq7F5Wy5tVTnyJIgAO(ConnectionID);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
					{
						num = 0;
					}
					continue;
				}
				if (value != _connectState)
				{
					break;
				}
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
				{
					num = 1;
				}
			}
			goto IL_0097;
			IL_0097:
			if (!value)
			{
				_connectState = false;
				IsConnecting = false;
				hqqvBL5WZQDwvtiS392M(ConnectionID);
				return;
			}
			num = 4;
			goto IL_0009;
		}
	}

	public bool AllowConnect { get; set; }

	public bool AllowMarketData { get; set; }

	public int Indicator
	{
		get
		{
			return _indicator;
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
					if (value != _indicator)
					{
						_indicator = value;
						OnPropertyChanged(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24085900 ^ 0x2408F888));
						OnPropertyChanged(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3544E813 ^ 0x3544498D));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Brush LedBrush => u8myvQaL2lirBxlZIa7k.uJmaLfsMTvY(Indicator);

	public qXLXHlax25yCgG9femcG Proxy
	{
		get
		{
			return _proxyData;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					if (_proxyData != value)
					{
						_proxyData = value;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
						{
							num2 = 1;
						}
					}
					break;
				default:
					if (_proxyData != null)
					{
						DataManager.SetClientProxy(value, ConnectionID);
					}
					OnPropertyChanged(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894927714));
					return;
				}
			}
		}
	}

	public bool HasProxy => Proxy != null;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
						{
							num = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ConnectionInfo(string tradeClientID, string tradeClientName, string tradeClientExtra, string connectionID, string connectionName, int indicator, bool marketData, bool autoConnect, bool simulator, bool trust, string dataPath)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TradeClientID = tradeClientID;
		TradeClientName = tradeClientName;
		int num = 6;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				TradeClientExtra = tradeClientExtra;
				ConnectionID = connectionID;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 != 0)
				{
					num = 0;
				}
				continue;
			case 4:
				Simulator = simulator;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
				{
					num = 0;
				}
				continue;
			case 2:
				AutoConnect = autoConnect;
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				Trust = trust;
				AllowConnect = true;
				AllowMarketData = true;
				DataPath = dataPath;
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
				{
					num = 8;
				}
				continue;
			case 3:
				Directory.CreateDirectory(LogsPath);
				return;
			case 8:
				LogsPath = (string)owrtBb5WVh6K44fN5xr4(dataPath, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1127423276 ^ -1127464172));
				SettingsFile = Path.Combine(dataPath, (string)RtgJO25WC7DF6KnhJtQ9(0x1EFE0A28 ^ 0x1EFEABE4));
				PositionsFile = Path.Combine(dataPath, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1009517961 ^ -1009558625));
				if (!tPBquH5WrlD5C8kJbRM8(DataPath))
				{
					num = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			default:
			{
				ConnectionName = connectionName;
				Indicator = indicator;
				MarketData = marketData;
				int num2 = 2;
				num = num2;
				continue;
			}
			case 5:
				Directory.CreateDirectory(DataPath);
				num = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
				{
					num = 7;
				}
				continue;
			case 7:
				break;
			}
			if (Directory.Exists(LogsPath))
			{
				break;
			}
			num = 3;
		}
	}

	public void SetLogsPath(string path)
	{
		try
		{
			if (!tPBquH5WrlD5C8kJbRM8(path))
			{
				sPi5GD5WKIP8OKUxwT1g(path);
			}
		}
		catch (Exception ex)
		{
			hJjG4q5Wm0RZWDEO8iAK(ex);
		}
		LogsPath = path;
	}

	public override string ToString()
	{
		return ConnectionName;
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static ConnectionInfo()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool faMCdT5WtDH8rdHY3F2F()
	{
		return MU1t1w5WWVnDTkQZRXcb == null;
	}

	internal static ConnectionInfo LWIInx5WUoZoJ7uE5IVS()
	{
		return MU1t1w5WWVnDTkQZRXcb;
	}

	internal static void lEogQ45WT4tK3cfcnkkl(object P_0)
	{
		DataManager.GuiAsync((Action)P_0);
	}

	internal static void mfsq7F5Wy5tVTnyJIgAO(object P_0)
	{
		DataManager.ClientConnect((string)P_0);
	}

	internal static void hqqvBL5WZQDwvtiS392M(object P_0)
	{
		DataManager.ClientDisconnect((string)P_0);
	}

	internal static object owrtBb5WVh6K44fN5xr4(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object RtgJO25WC7DF6KnhJtQ9(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool tPBquH5WrlD5C8kJbRM8(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object sPi5GD5WKIP8OKUxwT1g(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static void hJjG4q5Wm0RZWDEO8iAK(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}
}
