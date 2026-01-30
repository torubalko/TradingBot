using System;
using System.Collections.Generic;
using BfZtb759KlUg4482QKym;
using nMhlMdY5c1fXreuVnAgL;
using qCQIuYGJryFOsEw3GPHq;
using TigerTrade.Tc.Data;
using WgpZwxGJT3LVlqrS4Ppx;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Connectors.Simulator.Player;

public static class HistoryPlayerModule
{
	private static VbQNTwY5XHCaLtIBo11m _client;

	internal static HistoryPlayerModule sTLuH3Sbb3iZdnCRR3XN;

	public static DateTime RecordDate { get; private set; }

	public static event Action<jDhdBvGJCYyeucPOsxGw> StatsChanged;

	public static event Action<j7hE9bGJUtiuJ2DVMLti> StateChanged;

	internal static void RegisterHistoryPlayer(VbQNTwY5XHCaLtIBo11m client)
	{
		_client = client;
	}

	public static void Init(DateTime date, string[] files)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				RecordDate = date;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_client?.XAZY5EMEaNu(date, files);
				return;
			}
		}
	}

	public static void Init(DateTime date, List<Tuple<Symbol, byte[]>> records)
	{
		RecordDate = date;
		_client?.fxsY5jMtQaj(date, records);
	}

	public static void Clear()
	{
		_client?.Clear();
	}

	public static void Play()
	{
		_client?.vo8Y5WqF4KK();
	}

	public static void Stop()
	{
		_client?.Stop();
	}

	public static void Pause()
	{
		_client?.fQ5Y5tM0lWL();
	}

	public static void Skip(int seconds)
	{
		_client?.qlOY5UssdWX(seconds);
	}

	public static void SkipTo(TimeSpan time)
	{
		_client?.uCcY5TFyS2j(time);
	}

	public static void SetSpeed(int speed)
	{
		_client?.ReYY5yS343R(speed);
	}

	internal static void RiseStateChanged(j7hE9bGJUtiuJ2DVMLti state)
	{
		HistoryPlayerModule.StateChanged?.Invoke(state);
	}

	internal static void RiseSecDataChanged(jDhdBvGJCYyeucPOsxGw stats)
	{
		HistoryPlayerModule.StatsChanged?.Invoke(stats);
	}

	public static HistoryPlayerState GetState()
	{
		return _client?.UNnY5Q4hD6s() ?? HistoryPlayerState.None;
	}

	public static List<HistoryPlayerStats> GetStats()
	{
		return _client?.PZoY5dInfPv();
	}

	static HistoryPlayerModule()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool KCqcugSbNY1EnUpNIF73()
	{
		return sTLuH3Sbb3iZdnCRR3XN == null;
	}

	internal static HistoryPlayerModule ESRiPkSbkdIfac01ckrN()
	{
		return sTLuH3Sbb3iZdnCRR3XN;
	}
}
