using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using BfZtb759KlUg4482QKym;
using cWbksjY51Gr7kvj9dXXT;
using EyD6NKGhRYBSlyBqPfrJ;
using foW8PaGwFOCiEEiPNGWC;
using fZZsJCaSyFw8c88OJXiJ;
using jSIOgkGu0P3Y4vrBGi9s;
using K1GcsD5GTtMSlaiJI0Xh;
using k7lvGwG7nsmvY8cRB5pp;
using k88Q51iwn84dxUE4tGQC;
using KQ8pCGYqFAqmbLf8I6qC;
using m5kuVfaxJ5sLVYrQ8vob;
using O36HY1aeumxwrhMPQQiL;
using p9D0WNaxgVP5IJuowluK;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using Ua6xnyGh1Oy75y6IWviX;
using X56sUtasxKVNFqSrsuOF;
using x97CE55GhEYKgt7TSVZT;
using XC9bmxax3FyWNmXI1Y6L;

namespace TigerTrade.Tc.Manager;

public static class TcManager
{
	[Serializable]
	[CompilerGenerated]
	private sealed class eBpHhVaq0Je11Anf4XkK
	{
		public static readonly eBpHhVaq0Je11Anf4XkK m1OaqHVUbj5;

		public static Func<AdVNpgG79ErxvcbgBD1J, ConnectionInfo> Hksaqfw498d;

		private static eBpHhVaq0Je11Anf4XkK UHg5DbxusecZoWRyxHaY;

		static eBpHhVaq0Je11Anf4XkK()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			m1OaqHVUbj5 = new eBpHhVaq0Je11Anf4XkK();
		}

		public eBpHhVaq0Je11Anf4XkK()
		{
			zXjDgnxujIiCKnYCC0FH();
			base._002Ector();
		}

		internal ConnectionInfo d7Haq23JgwT(AdVNpgG79ErxvcbgBD1J c)
		{
			return (ConnectionInfo)P7D9LQxuETBmv5FAsZRo(c);
		}

		internal static bool lobRPExuXTDXpThMv8kr()
		{
			return UHg5DbxusecZoWRyxHaY == null;
		}

		internal static eBpHhVaq0Je11Anf4XkK y6R6GXxucBjwRaO8qR0v()
		{
			return UHg5DbxusecZoWRyxHaY;
		}

		internal static void zXjDgnxujIiCKnYCC0FH()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static object P7D9LQxuETBmv5FAsZRo(object P_0)
		{
			return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
		}
	}

	public static string CommonDataPath;

	private static string _dataPath;

	private static string _settingsFile;

	private static bool _clientsLoaded;

	private static jRIf3waxF6Rj56SrIqWN _connectionSettings;

	internal static Window MainWindow;

	internal static TcManager wRGcbk5hTcyUBKQtBvfa;

	public static hD6xHBYqJxeuxQDIpQ9d TTGate { get; private set; }

	internal static bool AreConnectionsInitialized { get; set; }

	public static CW2GevaepETlPEEUFsEM SortSettings
	{
		get
		{
			return _connectionSettings.LfvaL0HkA1n;
		}
		set
		{
			_connectionSettings.LfvaL0HkA1n = value;
		}
	}

	public static void Init(string settingsPath, string commonDataPath, string dataPath, Window mainWindow, hD6xHBYqJxeuxQDIpQ9d ttGate)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				TTGate = ttGate;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				_dataPath = dataPath;
				CommonDataPath = commonDataPath;
				MainWindow = mainWindow;
				if (!Directory.Exists(_dataPath))
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				Directory.CreateDirectory(_dataPath);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		_settingsFile = Path.Combine(settingsPath, (string)(dataPath.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1801468030 ^ -1801510146)) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-710503328 ^ -710510840) : Dd7QuC5hVSxoZJHIIyk2(0x86EFEF6 ^ 0x86E1DB0)));
		rwlc60axdATOINfnxFFP.JYhaxV3KmOl().o0taxRtwahi(settingsPath);
	}

	public static void Load(byte[] clients, iRHZWSY5kYQyV4m4KQjc simulatorComissionHelper)
	{
		int num = 4;
		List<string> list = default(List<string>);
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J2 = default(AdVNpgG79ErxvcbgBD1J);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					DataManager.InitConnections();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					CleanUp(list);
					return;
				case 4:
					break;
				case 5:
				{
					list.Add(adVNpgG79ErxvcbgBD1J2.mWXlYwTb86e.DataPath);
					SPb4E25hrG4QPawSNohC(adVNpgG79ErxvcbgBD1J2);
					AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J3 = (AdVNpgG79ErxvcbgBD1J)cI9IYr5hKn7a6S7Of814(_dataPath);
					list.Add(adVNpgG79ErxvcbgBD1J3.mWXlYwTb86e.DataPath);
					DataManager.SubscribeClient(adVNpgG79ErxvcbgBD1J3);
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
					{
						num2 = 6;
					}
					continue;
				}
				default:
					list = new List<string>();
					foreach (F4EwxMaSTBNo9qLimEuT item in _connectionSettings.Connections)
					{
						try
						{
							AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Wro6CpGwJN5r99xB0rAs.L1eGwptT5is(item, _dataPath);
							int num3;
							if (adVNpgG79ErxvcbgBD1J != null)
							{
								DataManager.SubscribeClient(adVNpgG79ErxvcbgBD1J);
								list.Add((string)O8pgct5hCx3Vdhb0grSD(adVNpgG79ErxvcbgBD1J.mWXlYwTb86e));
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
								{
									num3 = 0;
								}
							}
							else
							{
								num3 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
								{
									num3 = 1;
								}
							}
							switch (num3)
							{
							case 1:
								break;
							case 0:
								break;
							}
						}
						catch (Exception e)
						{
							LogManager.WriteError(e);
						}
					}
					adVNpgG79ErxvcbgBD1J2 = Wro6CpGwJN5r99xB0rAs.WCoGwu9PtqY(_dataPath, simulatorComissionHelper);
					num2 = 5;
					continue;
				case 1:
					_connectionSettings = ConfigSerializer.LoadFromFile<jRIf3waxF6Rj56SrIqWN>(_settingsFile) ?? new jRIf3waxF6Rj56SrIqWN();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_clientsLoaded = true;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			Wro6CpGwJN5r99xB0rAs.ifRG70FSfLk(clients);
			num = 3;
		}
	}

	public static void LoadSimulator(iRHZWSY5kYQyV4m4KQjc simulatorComissionHelper)
	{
		DataManager.SubscribeClient((AdVNpgG79ErxvcbgBD1J)oxFsYc5hmMyFs68i81tx(_dataPath, simulatorComissionHelper));
		DataManager.InitConnections();
	}

	public static void Save()
	{
		sWpuDx5hhQT0lANcQ8iW();
		DataManager.UnSubscribeClients();
	}

	public static void SaveSettings()
	{
		if (!_clientsLoaded)
		{
			return;
		}
		_connectionSettings.Connections.Clear();
		IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = DataManager.GetConnections().GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			try
			{
				while (enumerator.MoveNext())
				{
					AdVNpgG79ErxvcbgBD1J current = enumerator.Current;
					try
					{
						current.EL3lnODvZSu();
						if (!current.mWXlYwTb86e.Simulator)
						{
							List<F4EwxMaSTBNo9qLimEuT> list = _connectionSettings.Connections;
							F4EwxMaSTBNo9qLimEuT f4EwxMaSTBNo9qLimEuT = new F4EwxMaSTBNo9qLimEuT();
							GTlPef5h7yT2KFipolHt(f4EwxMaSTBNo9qLimEuT, ((ConnectionInfo)hyd4FO5hwF8rTa44ePDF(current)).ConnectionID);
							f4EwxMaSTBNo9qLimEuT.ConnectionName = current.mWXlYwTb86e.ConnectionName;
							f4EwxMaSTBNo9qLimEuT.Indicator = F3iBms5h8j2SG3IaWHHM(current.mWXlYwTb86e);
							f4EwxMaSTBNo9qLimEuT.lBTaShRPEYu = (string)MqYN7l5hAJ0PZXPLT2UH(hyd4FO5hwF8rTa44ePDF(current));
							k8kWJL5hPsA0B02fLyhA(f4EwxMaSTBNo9qLimEuT, current.mWXlYwTb86e.MarketData);
							f4EwxMaSTBNo9qLimEuT.AutoConnect = BsR8Xi5hJyOWy3YeNKSR(hyd4FO5hwF8rTa44ePDF(current));
							list.Add(f4EwxMaSTBNo9qLimEuT);
							int num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							case 0:
								break;
							}
						}
					}
					catch (Exception e)
					{
						LogManager.WriteError(e);
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
			ConfigSerializer.SaveToFile(_connectionSettings, _settingsFile);
			break;
		}
	}

	private static void CleanUp(List<string> activeDirs)
	{
		try
		{
			List<string> list = Directory.GetDirectories(_dataPath).ToList();
			foreach (string activeDir in activeDirs)
			{
				if (list.Contains(activeDir))
				{
					list.Remove(activeDir);
				}
			}
			foreach (string item in list)
			{
				try
				{
					Directory.Delete(item, recursive: true);
				}
				catch (Exception e)
				{
					LogManager.WriteError(e);
				}
			}
		}
		catch (Exception e2)
		{
			LogManager.WriteError(e2);
		}
	}

	public static void SetTelegramSettingsEnabled(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.vsYGwvN7KBa(value);
	}

	public static void SetTelegramSettingsSendOrders(bool value)
	{
		TQVW6u5hF300OBShkOuH(value);
	}

	public static void SetTelegramSettingsSendExecutions(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.JEjGwDp8yh5(value);
	}

	public static void SetSymbolDepth(Dictionary<string, int> list)
	{
		Acj0FgGhg83F5A0lfPa4.uGcGwGh021S(list);
	}

	public static void SetLocalTime(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.HYmGwfyob9I(value);
	}

	public static void SetPositionPartClose(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.fs3GhIg5aa4(value);
	}

	public static void SetPositionPriceStrategy(int value)
	{
		VVWeml5h3hmoLtwXFWXD((ApidlOGpzEFH7ruf5jBr)value);
	}

	public static void SetDynamicSlTp(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.w3qGhhFLh1O(value);
	}

	public static void SetServerStopLoss(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.JeKGhZ02Omg(value);
	}

	public static void SetServerTakeProfit(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.sq8GhrgZMUI(value);
	}

	public static void SetCancelOrdersOnClose(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.m76Gh8wkvxm(value);
	}

	public static void SetViewDeletedSymbols(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.okNGhJFrTV1(value);
	}

	public static void SetViewOptionsSymbols(bool value)
	{
		Acj0FgGhg83F5A0lfPa4.CbvGhpxBul2(value);
	}

	public static void SetNtpDiffTime(long value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Acj0FgGhg83F5A0lfPa4.owlGwQrHqla(_0020: true);
				YihEHA5hpwY6vlLyBS2J(value);
				return;
			case 1:
				Acj0FgGhg83F5A0lfPa4.ryHGwchL9tO(value);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void SetupConnections(Action<Window> setupDialog, Window window, HnUJKOaxPE3WmiOMiR1q connectionWindowsManager = null)
	{
	}

	internal static Kb4Jsjiw9kA3pBXEIXBC GetSetupViewModel(Window owner, HnUJKOaxPE3WmiOMiR1q connectionWindowsManager = null)
	{
		return new PmWBAcasSZi1i4TPFqN8(owner, connectionWindowsManager);
	}

	internal static bool CanAddConnection(KujNH9Ghk4kirc4iv3Bq desc)
	{
		if (desc == null)
		{
			return false;
		}
		if (desc.u25Ghxh8WHm() == (string)Dd7QuC5hVSxoZJHIIyk2(-671204305 ^ -671163977))
		{
			return !DataManager.ContainsTradeClient(desc.mgjGh5dDjLb());
		}
		return true;
	}

	internal static AdVNpgG79ErxvcbgBD1J CreateTradeClient(KujNH9Ghk4kirc4iv3Bq desc)
	{
		int num = 3;
		int num2 = num;
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = default(AdVNpgG79ErxvcbgBD1J);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (desc != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return null;
			case 2:
			{
				string text = Guid.NewGuid().ToString();
				adVNpgG79ErxvcbgBD1J = Wro6CpGwJN5r99xB0rAs.L1eGwptT5is(new F4EwxMaSTBNo9qLimEuT
				{
					lBTaShRPEYu = desc.mgjGh5dDjLb(),
					ConnectionID = text,
					ConnectionName = (string)PfsNud5huaYfQgTZpc5P(desc),
					MarketData = true
				}, _dataPath);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 1:
				adVNpgG79ErxvcbgBD1J.GaTlY1SBHLM();
				return adVNpgG79ErxvcbgBD1J;
			}
			if (adVNpgG79ErxvcbgBD1J != null)
			{
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return null;
		}
	}

	internal static void AddConnection(AdVNpgG79ErxvcbgBD1J tradeClient, KujNH9Ghk4kirc4iv3Bq desc)
	{
		DataManager.SubscribeClient(tradeClient);
		TcEvents.RiseTrackAddConnection(desc.u25Ghxh8WHm());
	}

	internal static void RemoveConnection(string id)
	{
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = (AdVNpgG79ErxvcbgBD1J)yjp7v05hz4ONXXHFQyO9(id);
		if (adVNpgG79ErxvcbgBD1J != null)
		{
			DataManager.UnSubscribeClient(adVNpgG79ErxvcbgBD1J);
		}
	}

	public static ConnectionInfo[] GetMarketDataConnections(string symbolId)
	{
		return (from c in DataManager.GetMarketDataConnections(symbolId)
			select (ConnectionInfo)eBpHhVaq0Je11Anf4XkK.P7D9LQxuETBmv5FAsZRo(c)).ToArray();
	}

	static TcManager()
	{
		ktaEGQ5w0WKdTIIp2Mbr();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Dd7QuC5hVSxoZJHIIyk2(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool ghs68N5hy9S8IMoZ56aW()
	{
		return wRGcbk5hTcyUBKQtBvfa == null;
	}

	internal static TcManager q3SNpt5hZR5v3oOGUQL0()
	{
		return wRGcbk5hTcyUBKQtBvfa;
	}

	internal static object O8pgct5hCx3Vdhb0grSD(object P_0)
	{
		return ((ConnectionInfo)P_0).DataPath;
	}

	internal static void SPb4E25hrG4QPawSNohC(object P_0)
	{
		DataManager.SubscribeClient((AdVNpgG79ErxvcbgBD1J)P_0);
	}

	internal static object cI9IYr5hKn7a6S7Of814(object P_0)
	{
		return Wro6CpGwJN5r99xB0rAs.of8GwzT2uca((string)P_0);
	}

	internal static object oxFsYc5hmMyFs68i81tx(object P_0, object P_1)
	{
		return Wro6CpGwJN5r99xB0rAs.WCoGwu9PtqY((string)P_0, (iRHZWSY5kYQyV4m4KQjc)P_1);
	}

	internal static void sWpuDx5hhQT0lANcQ8iW()
	{
		SaveSettings();
	}

	internal static object hyd4FO5hwF8rTa44ePDF(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
	}

	internal static void GTlPef5h7yT2KFipolHt(object P_0, object P_1)
	{
		((F4EwxMaSTBNo9qLimEuT)P_0).ConnectionID = (string)P_1;
	}

	internal static int F3iBms5h8j2SG3IaWHHM(object P_0)
	{
		return ((ConnectionInfo)P_0).Indicator;
	}

	internal static object MqYN7l5hAJ0PZXPLT2UH(object P_0)
	{
		return ((ConnectionInfo)P_0).TradeClientID;
	}

	internal static void k8kWJL5hPsA0B02fLyhA(object P_0, bool P_1)
	{
		((F4EwxMaSTBNo9qLimEuT)P_0).MarketData = P_1;
	}

	internal static bool BsR8Xi5hJyOWy3YeNKSR(object P_0)
	{
		return ((ConnectionInfo)P_0).AutoConnect;
	}

	internal static void TQVW6u5hF300OBShkOuH(bool P_0)
	{
		Acj0FgGhg83F5A0lfPa4.d41GwiwBEoY(P_0);
	}

	internal static void VVWeml5h3hmoLtwXFWXD(ApidlOGpzEFH7ruf5jBr P_0)
	{
		Acj0FgGhg83F5A0lfPa4.LVhGhUqIgmy(P_0);
	}

	internal static void YihEHA5hpwY6vlLyBS2J(long P_0)
	{
		TimeHelper.NtpTimeDiff = P_0;
	}

	internal static object PfsNud5huaYfQgTZpc5P(object P_0)
	{
		return ((KujNH9Ghk4kirc4iv3Bq)P_0).u25Ghxh8WHm();
	}

	internal static object yjp7v05hz4ONXXHFQyO9(object P_0)
	{
		return DataManager.GetConnection((string)P_0);
	}

	internal static void ktaEGQ5w0WKdTIIp2Mbr()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
