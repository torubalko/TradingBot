using System;
using System.Net;
using System.Net.Sockets;
using B7wByeim8eY9NSyMmL1e;
using HExkDCsORifnalUv1owx;
using uRJBNQimJrJkBGDIdSrI;
using UxBecVsOUPcejrh1NEnp;
using VDcZaSihxrowDaCDnBT8;
using vGgPQ4s6WEgjxnvUb1Vk;

namespace C8s10vihKTDmKy0eT5wQ;

public class IFB0JbihrM3SmKlVXVCj : IDisposable
{
	private readonly Socket vx7ihAfQJfl;

	private readonly EndPoint TJqihPuiqmF;

	public EventHandler SYaihJxkHjN;

	public EventHandler<ISNlDGim7sCvIZNs6pKH> kIQihFfAHox;

	public EventHandler<SocketAsyncEventArgs> Error;

	private static IFB0JbihrM3SmKlVXVCj RX3odksCgZGPsDKHxJhY;

	public IFB0JbihrM3SmKlVXVCj(EndPoint P_0)
	{
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
		vx7ihAfQJfl = bSDfhrihSfAbGTIuQ16h.UyjihLR0voS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_4613f38c15aa42aab5d77bb132211696 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		TJqihPuiqmF = P_0;
	}

	public void S6eihmOZOaI()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vx7ihAfQJfl.NoDelay = true;
				num2 = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_01b6556c67dc4017b08f29078e9199d5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				vx7ihAfQJfl.Bind(TJqihPuiqmF);
				vx7ihAfQJfl.Listen(10000);
				return;
			}
		}
	}

	public void N1cihhySNou()
	{
		qnB7ULsCMhP65nFuYIAb(vx7ihAfQJfl);
	}

	public void Dispose()
	{
		GIILVGsCOoC6NYdmr241(vx7ihAfQJfl);
	}

	public void InHihwG2qFV()
	{
		SocketAsyncEventArgs e = new SocketAsyncEventArgs();
		e.Completed += WGqih7OnvcS;
		int num = 0;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_9658cccc7eb247d6b08fd1440dccc88b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			bool flag = vx7ihAfQJfl.AcceptAsync(e);
			bool flag2 = !flag;
			int num2 = 0;
			if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_aff01ba2597543768f9a7d922a747dda != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			if (flag2)
			{
				WGqih7OnvcS(vx7ihAfQJfl, e);
			}
		}
		catch (ObjectDisposedException)
		{
			int num3 = 0;
			if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_006a9776a50a4b298f820cf49cc1ecc0 != 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			}
			e.Completed -= WGqih7OnvcS;
			QfkjG1sCqmWckrm0MC4N(e);
		}
		catch (Exception)
		{
			e.Completed -= WGqih7OnvcS;
			int num4 = 0;
			if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_7cc18b45d80e4d428162312d0fdac915 != 0)
			{
				num4 = 0;
			}
			switch (num4)
			{
			}
			QfkjG1sCqmWckrm0MC4N(e);
			vx7ihAfQJfl.Close();
		}
	}

	private void WGqih7OnvcS(object P_0, SocketAsyncEventArgs P_1)
	{
		int num = 4;
		int num2 = num;
		Socket socket = default(Socket);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				P_1.Dispose();
				socket = (Socket)aHG38RsCI1TkrC1nNcSB(P_1);
				num2 = 2;
				continue;
			case 1:
				return;
			case 4:
				P_1.Completed -= WGqih7OnvcS;
				num2 = 3;
				continue;
			case 5:
				return;
			case 2:
			{
				EventHandler sYaihJxkHjN = SYaihJxkHjN;
				if (sYaihJxkHjN != null)
				{
					KlmjwpsCWFbHwYPAqA3L(sYaihJxkHjN, this, EventArgs.Empty);
				}
				flag = IQNT2ZsCtGa959rY7Pwn(P_1) == SocketError.Success;
				num2 = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_c127a92ac73247d7b507ba2c1de68535 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			}
			if (flag)
			{
				EventHandler<ISNlDGim7sCvIZNs6pKH> eventHandler = kIQihFfAHox;
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(this, new ISNlDGim7sCvIZNs6pKH(new zBnPxAimPZhUWdNEJueG(socket)));
				num2 = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_8bc963d5e98742bcb73a349768a7d70d == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				EventHandler<SocketAsyncEventArgs> error = Error;
				if (error != null)
				{
					error(this, P_1);
					return;
				}
				num2 = 5;
			}
		}
	}

	static IFB0JbihrM3SmKlVXVCj()
	{
		qhHWErs6IBu8qtqJbdvd.DI9s6AAreQp();
		vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool UbOJJqsCRUb16m7mhYCt()
	{
		return RX3odksCgZGPsDKHxJhY == null;
	}

	internal static IFB0JbihrM3SmKlVXVCj V681aTsC6NFnAuIM560X()
	{
		return RX3odksCgZGPsDKHxJhY;
	}

	internal static void qnB7ULsCMhP65nFuYIAb(object P_0)
	{
		((Socket)P_0).Close();
	}

	internal static void GIILVGsCOoC6NYdmr241(object P_0)
	{
		((Socket)P_0).Dispose();
	}

	internal static void QfkjG1sCqmWckrm0MC4N(object P_0)
	{
		((SocketAsyncEventArgs)P_0).Dispose();
	}

	internal static object aHG38RsCI1TkrC1nNcSB(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).AcceptSocket;
	}

	internal static void KlmjwpsCWFbHwYPAqA3L(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (EventArgs)P_2);
	}

	internal static SocketError IQNT2ZsCtGa959rY7Pwn(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).SocketError;
	}
}
