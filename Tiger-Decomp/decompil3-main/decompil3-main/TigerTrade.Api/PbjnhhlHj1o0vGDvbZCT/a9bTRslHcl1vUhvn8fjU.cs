using System;
using System.Runtime.CompilerServices;
using System.Threading;
using c0HWNClH0DD0LrKx40LO;
using CSS6XalHK5HsekHKPmtp;
using eOwMKHlHYdULxeer5XoP;
using HuO5Y0lHnExR4FQdnCur;
using Mp0rQhXtcD2M433xKykv;
using nXNMiwXTSjaRAVOuyCXd;
using oXyYyLlHhTmFPSxGiS65;
using QSiDZalflVDTvl4pbnjn;
using QuE5CilHDXZ5kwVUBQSj;
using stgQjolf9YnaMr4Rx1Rc;
using WebSocketSharp;
using WebSocketSharp.Server;
using WUsie0XTELvQJLckfItk;
using zdeQVllfHIQMlfp9cipJ;

namespace PbjnhhlHj1o0vGDvbZCT;

internal class a9bTRslHcl1vUhvn8fjU : nkQalBl2zxRsJJrVdHl6
{
	private readonly GXmvf7lfiXtpqKM447jv XxFlH6hxnV3;

	private WebSocketServer P2TlHMwPnN6;

	[CompilerGenerated]
	private Action<zeTpRElHGPnIA7I1m3us> Ia7lHOFXw9B;

	private static a9bTRslHcl1vUhvn8fjU uG0KB1X7QqiXl32njYDk;

	public bool uaIlvdf2q2n
	{
		get
		{
			WebSocketServer p2TlHMwPnN = P2TlHMwPnN6;
			if (p2TlHMwPnN == null)
			{
				return false;
			}
			return p2TlHMwPnN.IsListening;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void NHnlvEp8prC(Action<zeTpRElHGPnIA7I1m3us> P_0)
	{
		Action<zeTpRElHGPnIA7I1m3us> action = Ia7lHOFXw9B;
		Action<zeTpRElHGPnIA7I1m3us> action2;
		do
		{
			action2 = action;
			Action<zeTpRElHGPnIA7I1m3us> value = (Action<zeTpRElHGPnIA7I1m3us>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref Ia7lHOFXw9B, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void D0ElvQHRyTH(Action<zeTpRElHGPnIA7I1m3us> P_0)
	{
		Action<zeTpRElHGPnIA7I1m3us> action = Ia7lHOFXw9B;
		Action<zeTpRElHGPnIA7I1m3us> action2;
		do
		{
			action2 = action;
			Action<zeTpRElHGPnIA7I1m3us> value = (Action<zeTpRElHGPnIA7I1m3us>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref Ia7lHOFXw9B, value, action2);
		}
		while ((object)action != action2);
	}

	public a9bTRslHcl1vUhvn8fjU(GXmvf7lfiXtpqKM447jv P_0)
	{
		dXhdMSX7RnTQrwvV5yHZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_056dade4dff840ce9cd38205b166e4bf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		XxFlH6hxnV3 = P_0;
	}

	public void dHqlnXLmFxp(int P_0)
	{
		Stop();
		P2TlHMwPnN6 = w8tlHEEyfyk(P_0);
		QJwtA0X768lmcwjUhKrZ(P2TlHMwPnN6);
		int num = 0;
		if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_c9fa8a91dc4646f4b7815b51086dbf5f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Stop()
	{
		if (uaIlvdf2q2n)
		{
			P2TlHMwPnN6.Stop();
		}
	}

	private WebSocketServer w8tlHEEyfyk(int P_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		WebSocketServer val = new WebSocketServer(string.Format((string)N3eLwWX7MIdUTmiexFFT(-3429745 ^ -3430005), P_0));
		val.Log.Level = (LogLevel)4;
		((Logger)pKk9DIX7OnJ8bubtqWGv((object)val)).Output = RIMlHglLIbI;
		val.AddWebSocketService<NLa9PylH4n6RJrlR13Mq>(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x385FFAB ^ 0x385FC87), (Func<NLa9PylH4n6RJrlR13Mq>)(() => new NLa9PylH4n6RJrlR13Mq(g9mlHQO92Qx, XxFlH6hxnV3)));
		return val;
	}

	private void g9mlHQO92Qx(nciIUmlHmmRAonJs47XR P_0, VoUcLvlH9KoApXATZoKl P_1)
	{
		try
		{
			Ia7lHOFXw9B?.Invoke(new zeTpRElHGPnIA7I1m3us(rd4lHd35sMI(P_0), P_1));
		}
		catch (Exception arg)
		{
			r8X9D5X7q1FOUUiVqYWs(XxFlH6hxnV3, string.Format(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-530053095 ^ -530052309), arg));
		}
	}

	private yQU8B0lHrEjK6ouSYJTF rd4lHd35sMI(nciIUmlHmmRAonJs47XR P_0)
	{
		if (P_0 is AC60jelff9vfeYJnXXxt aC60jelff9vfeYJnXXxt)
		{
			return new YyxQOAlf25dNl74NJVuK
			{
				Exchange = aC60jelff9vfeYJnXXxt.q2ulfGBfgb5,
				Symbol = aC60jelff9vfeYJnXXxt.tKHlfoTaZ4F,
				Market = aC60jelff9vfeYJnXXxt.udjlfnPqTRr(),
				LinkGroup = aC60jelff9vfeYJnXXxt.QxHlfvCofv6
			};
		}
		throw new NotImplementedException();
	}

	private void RIMlHglLIbI(LogData P_0, string P_1)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected I4, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		LogLevel level = default(LogLevel);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				level = P_0.Level;
				num2 = 0;
				if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_d82afa3a94784953b100be184f1c6810 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			}
			switch (level - 2)
			{
			case 0:
				XxFlH6hxnV3.Info(((object)P_0).ToString());
				return;
			case 1:
				XxFlH6hxnV3.Warn(((object)P_0).ToString());
				num2 = 3;
				if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_36ac4936e4984e37ac8e6a87b969abb2 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				r8X9D5X7q1FOUUiVqYWs(XxFlH6hxnV3, ((object)P_0).ToString());
				num2 = 0;
				if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_93543731a00d4042a6714fa395c54c1f == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				XxFlH6hxnV3.Fatal(((object)P_0).ToString());
				return;
			default:
				XxFlH6hxnV3.Debug(((object)P_0).ToString());
				return;
			}
		}
	}

	[CompilerGenerated]
	private NLa9PylH4n6RJrlR13Mq h7vlHRpaSr5()
	{
		return new NLa9PylH4n6RJrlR13Mq(g9mlHQO92Qx, XxFlH6hxnV3);
	}

	static a9bTRslHcl1vUhvn8fjU()
	{
		T2OXZhXtXqRemtkpvtX8.g1uXtTdsjEL();
		opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void dXhdMSX7RnTQrwvV5yHZ()
	{
		ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
	}

	internal static bool J3bj4hX7dl1wlh0mk7pA()
	{
		return uG0KB1X7QqiXl32njYDk == null;
	}

	internal static a9bTRslHcl1vUhvn8fjU EIZBIkX7gr0uN9WaUXm5()
	{
		return uG0KB1X7QqiXl32njYDk;
	}

	internal static void QJwtA0X768lmcwjUhKrZ(object P_0)
	{
		((WebSocketServer)P_0).Start();
	}

	internal static object N3eLwWX7MIdUTmiexFFT(int P_0)
	{
		return T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(P_0);
	}

	internal static object pKk9DIX7OnJ8bubtqWGv(object P_0)
	{
		return ((WebSocketServer)P_0).Log;
	}

	internal static void r8X9D5X7q1FOUUiVqYWs(object P_0, object P_1)
	{
		((GXmvf7lfiXtpqKM447jv)P_0).Error((string)P_1);
	}
}
