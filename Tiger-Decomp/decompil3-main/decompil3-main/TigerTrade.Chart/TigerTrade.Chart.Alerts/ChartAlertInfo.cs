using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Alerts;

public sealed class ChartAlertInfo
{
	internal static ChartAlertInfo o64BcTeWqh98Pr77Ci3f;

	public string Signal { get; }

	public int Duration { get; }

	public bool ShowPopup { get; }

	public bool SendEmail { get; }

	public bool SendTelegram { get; }

	public string Message { get; }

	public bool Log { get; }

	public ChartAlertInfo(ChartAlertSettings settings, string message)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Signal = (string)(settings.PlaySound ? Y1E0haeWtnaom7axdNeK(settings) : "");
		int num = 5;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				SendTelegram = settings.SendTelegram;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
				{
					num = 0;
				}
				break;
			case 4:
			case 9:
				ShowPopup = settings.ShowPopup;
				SendEmail = cAviNHeWUA7CycqE8BBO(settings);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
				{
					num = 3;
				}
				break;
			case 7:
				Message = message;
				return;
			case 6:
				Duration = 5;
				goto case 4;
			case 5:
				switch (settings.Duration)
				{
				case ChartAlertPlayDuration.Seconds5:
					break;
				case ChartAlertPlayDuration.Minute:
					goto IL_00d4;
				case ChartAlertPlayDuration.Seconds10:
					goto IL_0107;
				default:
					goto IL_018e;
				case ChartAlertPlayDuration.Seconds30:
					goto IL_01d9;
				}
				goto case 6;
			default:
				Message = (string)wkIoqheWTPbncdIFd6Wa(settings);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
				{
					num = 1;
				}
				break;
			case 8:
				return;
			case 1:
				Log = settings.Log;
				if (!oCHQMgeWyWobgWQ6EyYv(Message))
				{
					num = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 != 0)
					{
						num = 8;
					}
					break;
				}
				goto case 7;
			case 2:
				goto IL_018e;
				IL_01d9:
				Duration = 30;
				num = 4;
				break;
				IL_018e:
				Duration = 0;
				goto case 4;
				IL_0107:
				Duration = 10;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
				{
					num = 9;
				}
				break;
				IL_00d4:
				Duration = 60;
				goto case 4;
			}
		}
	}

	static ChartAlertInfo()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Y1E0haeWtnaom7axdNeK(object P_0)
	{
		return ((ChartAlertSettings)P_0).Signal;
	}

	internal static bool cAviNHeWUA7CycqE8BBO(object P_0)
	{
		return ((ChartAlertSettings)P_0).SendEmail;
	}

	internal static object wkIoqheWTPbncdIFd6Wa(object P_0)
	{
		return ((ChartAlertSettings)P_0).Message;
	}

	internal static bool oCHQMgeWyWobgWQ6EyYv(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool vIAIuveWIeXWOg6Fw5sd()
	{
		return o64BcTeWqh98Pr77Ci3f == null;
	}

	internal static ChartAlertInfo tB2fPpeWWje7DpkESv0V()
	{
		return o64BcTeWqh98Pr77Ci3f;
	}
}
