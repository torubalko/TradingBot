using System;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using AQB6mgf3wjOUxVfiEwwS;
using b1neT39sxtGuKbVPRyqn;
using bl7Or1fDrLHNeTtGhT82;
using cPL0LPniWgA7dNYWcgpS;
using dpoTZ395JPmKdIOgCedl;
using DtStr19QQaKg75OcD35U;
using e1kkxSfnYS0dpfg4WErY;
using ECOEgqlSad8NUJZ2Dr9n;
using h9KUNZ9dZR28k5beCLXQ;
using Ha9I1wna0XjsKnZiPJll;
using If1oyCHiFG4LnIUAsfeE;
using inUerCfHMLVDbG9HvwwZ;
using jS3Y2j9pTQRy0FnOknFG;
using k2djPS9h3aXysXOe0uK1;
using kOFMV2HpfuesrIvDSOyt;
using M7Qhok2zS37wTYN0rqJn;
using n4oTDO9gUS7JKJhhEkqi;
using npFCUo9g4I3If2iffCSK;
using NsWD4W9miMxRbFU3fsu9;
using o1srKL9PWRC5v3sURMga;
using PGh1t097dKGNtpYw9WbJ;
using ROhuQx9FcGTLTqPCaJ0j;
using s8CVoTnYOlGDs7vDiB5f;
using TigerTrade.Chart.Properties;
using TigerTrade.Chart.Settings;
using TigerTrade.Chart.Theme;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Controls.Notifications;
using TuAMtrl1Nd3XoZQQUXf0;
using uiNaOs9dK7PRc3hi6bHx;
using V9ObVI9gCxZjgUce1Uw4;
using waDpctGJom9MvAveNXHq;
using wse3wd2zgF9O4VW2DUfZ;
using xMisjq9gLlMxOLGf4FTR;
using XU91DLnly8KmfKu1ytG5;

namespace TvRPGL9dLBbQgDEQYdJ7;

internal sealed class liQnXV9dxGMvYlKyMGrI
{
	[CompilerGenerated]
	private Action<j3bgDY9gV2i9bttJ1fiQ> m_Command;

	[CompilerGenerated]
	private readonly jjKtVJ9pUSOpdg38tqnP sV29dWJIKQD;

	private FrFpU89dyE3xMtDTrecP TPt9dtRB6wx;

	private string vu59dUXnTw8;

	[CompilerGenerated]
	private readonly J3eOkQ9gxQ4xmbapBPJ3 ywA9dTNE0yB;

	private static liQnXV9dxGMvYlKyMGrI hitxDSbQtEDFbOup50w8;

	public ChartTheme Theme => ((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).Theme;

	public ChartSettings Settings => BG09ddpAWBZ().Chart.Settings;

	public event Action<j3bgDY9gV2i9bttJ1fiQ> Command
	{
		[CompilerGenerated]
		add
		{
			Action<j3bgDY9gV2i9bttJ1fiQ> action = this.m_Command;
			Action<j3bgDY9gV2i9bttJ1fiQ> action2;
			do
			{
				action2 = action;
				Action<j3bgDY9gV2i9bttJ1fiQ> value2 = (Action<j3bgDY9gV2i9bttJ1fiQ>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Command, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<j3bgDY9gV2i9bttJ1fiQ> action = this.m_Command;
			Action<j3bgDY9gV2i9bttJ1fiQ> action2;
			do
			{
				action2 = action;
				Action<j3bgDY9gV2i9bttJ1fiQ> value2 = (Action<j3bgDY9gV2i9bttJ1fiQ>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Command, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public jjKtVJ9pUSOpdg38tqnP BG09ddpAWBZ()
	{
		return sV29dWJIKQD;
	}

	[SpecialName]
	[CompilerGenerated]
	public J3eOkQ9gxQ4xmbapBPJ3 P8n9dM2IMjd()
	{
		return ywA9dTNE0yB;
	}

	public liQnXV9dxGMvYlKyMGrI(jjKtVJ9pUSOpdg38tqnP P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		sV29dWJIKQD = P_0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ywA9dTNE0yB = new J3eOkQ9gxQ4xmbapBPJ3();
				return;
			case 1:
				TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool KeyDown(KeyEventArgs e)
	{
		if (!AmrG9DbQZsnQ0bnmZOE3(BG09ddpAWBZ()))
		{
			return false;
		}
		long num = default(long);
		int num2;
		int num5;
		if (!hCUGojbQV7JEeDxuHIPg(vspL39fH6Hd69qemUHrA.Chart.BuyMarket, e))
		{
			if (((UQpOEF95Pl27GeSpKZ6s)Io7s7dbQwQnZot4bq9tx(vspL39fH6Hd69qemUHrA.Chart)).Check(e))
			{
				num = CrRFMDbQ870XWmMmFkBm(((ypqMIv9maFM0tRwF0xMh)GIyarkbQ7tKOkdFlOaJi(BG09ddpAWBZ().Chart)).OpZl98KAYgk());
				num2 = 20;
			}
			else if (!hCUGojbQV7JEeDxuHIPg(pVgZfybQAREfJyVaLFda(vspL39fH6Hd69qemUHrA.Chart), e))
			{
				if (vspL39fH6Hd69qemUHrA.Chart.SellLimit.Check(e))
				{
					long num3 = PQjRkhbQJnK5bn5wSxRl(BG09ddpAWBZ().Chart.DataProvider.OpZl98KAYgk());
					if (!iWD9dEmwOP5(num3, out var num4) || w1yLn5bQmT5exXixSY14(num4))
					{
						return false;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
					if (action != null)
					{
						action(j3bgDY9gV2i9bttJ1fiQ.SellLimit(num3, num4));
						num5 = 27;
						goto IL_0005;
					}
					num2 = 8;
				}
				else
				{
					if (!vspL39fH6Hd69qemUHrA.Chart.ReversePosition.Check(e))
					{
						goto IL_0093;
					}
					num2 = 14;
				}
			}
			else
			{
				num2 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
				{
					num2 = 4;
				}
			}
		}
		else
		{
			num2 = 19;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
			{
				num2 = 5;
			}
		}
		goto IL_0009;
		IL_03d9:
		e.Handled = true;
		num2 = 13;
		goto IL_0009;
		IL_0009:
		double num7 = default(double);
		double num6 = default(double);
		double num8 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 21:
				break;
			default:
				e.Handled = true;
				goto IL_0468;
			case 1:
			case 9:
				e.Handled = true;
				goto IL_0468;
			case 18:
				goto IL_00c5;
			case 20:
				goto IL_0104;
			case 16:
				goto IL_014b;
			case 19:
				if (!iWD9dEmwOP5(WmPi9sbQrxV8cSobN6CA(VZH2vabQCyKtgw460b4t(BG09ddpAWBZ().Chart.DataProvider)) * Mxtb2BbQKRFudN6KKoWJ(BG09ddpAWBZ().Chart.DataProvider), out num7))
				{
					num2 = 29;
					continue;
				}
				goto IL_00c5;
			case 23:
				e.Handled = true;
				goto IL_0468;
			case 15:
				goto IL_01fd;
			case 29:
			case 30:
				return false;
			case 28:
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action2 = this.Command;
				if (action2 == null)
				{
					goto case 23;
				}
				action2(j3bgDY9gV2i9bttJ1fiQ.SellMarket(num6));
				num2 = 23;
				continue;
			}
			case 26:
				goto IL_02bc;
			case 17:
				goto IL_0313;
			case 8:
			case 27:
				goto IL_03b5;
			case 2:
				goto IL_03d9;
			case 14:
				goto IL_0409;
			case 31:
				goto IL_0420;
			case 22:
				goto IL_0450;
			case 11:
			case 12:
				e.Handled = true;
				goto IL_0468;
			case 6:
			case 10:
			case 13:
				goto IL_0468;
			case 5:
				goto IL_04fa;
			case 7:
				goto IL_0514;
			case 4:
			case 25:
				e.Handled = true;
				num2 = 6;
				continue;
			case 3:
				goto IL_0586;
			}
			break;
			IL_0586:
			if (!double.IsInfinity(num6))
			{
				num2 = 28;
				continue;
			}
			goto IL_029e;
			IL_0420:
			oKggK3bQhbUPYjNvkCay(e, true);
			goto IL_0468;
			IL_0514:
			if (iWD9dEmwOP5(lkO257bQPwW45huJeHdb(VZH2vabQCyKtgw460b4t(BG09ddpAWBZ().Chart.DataProvider)) * Mxtb2BbQKRFudN6KKoWJ(((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider), out num6))
			{
				num2 = 3;
				continue;
			}
			goto IL_029e;
			IL_00c5:
			if (w1yLn5bQmT5exXixSY14(num7))
			{
				goto IL_00d1;
			}
			Action<j3bgDY9gV2i9bttJ1fiQ> action3 = this.Command;
			if (action3 == null)
			{
				num2 = 31;
				continue;
			}
			action3(j3bgDY9gV2i9bttJ1fiQ.BuyMarket(num7));
			goto IL_0420;
			IL_029e:
			return false;
			IL_0409:
			Action<j3bgDY9gV2i9bttJ1fiQ> action4 = this.Command;
			if (action4 == null)
			{
				num2 = 11;
				continue;
			}
			action4(j3bgDY9gV2i9bttJ1fiQ.ReversePosition());
			num2 = 12;
			continue;
			IL_01e9:
			return false;
			IL_0104:
			if (iWD9dEmwOP5(num, out num8))
			{
				num2 = 15;
				continue;
			}
			goto IL_01e9;
			IL_01fd:
			if (!double.IsInfinity(num8))
			{
				this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(num, num8));
				e.Handled = true;
				goto IL_0468;
			}
			goto IL_01e9;
		}
		goto IL_0093;
		IL_02bc:
		e.Handled = true;
		goto IL_0468;
		IL_0450:
		e.Handled = true;
		goto IL_0468;
		IL_0005:
		num2 = num5;
		goto IL_0009;
		IL_0093:
		if (!vspL39fH6Hd69qemUHrA.Chart.ClosePosition.Check(e))
		{
			goto IL_014b;
		}
		Action<j3bgDY9gV2i9bttJ1fiQ> action5 = this.Command;
		if (action5 == null)
		{
			num2 = 8;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
			{
				num2 = 22;
			}
			goto IL_0009;
		}
		action5(j3bgDY9gV2i9bttJ1fiQ.ClosePosition());
		goto IL_0450;
		IL_014b:
		if (!hCUGojbQV7JEeDxuHIPg(q3Z7d8bQFV6h7O0LTnyv(vspL39fH6Hd69qemUHrA.Chart), e))
		{
			if (hCUGojbQV7JEeDxuHIPg(((PyYTjtHpHbZRtxYfvYWW)DXI1ifbQ3bh2FbR1t97G()).CancelAsks, e))
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action6 = this.Command;
				if (action6 != null)
				{
					action6((j3bgDY9gV2i9bttJ1fiQ)XwruOBbQp9x8RtsY1tEk());
					goto IL_02bc;
				}
				num2 = 26;
			}
			else if (!vspL39fH6Hd69qemUHrA.Chart.CancelAll.Check(e))
			{
				if (hCUGojbQV7JEeDxuHIPg(((PyYTjtHpHbZRtxYfvYWW)DXI1ifbQ3bh2FbR1t97G()).SetTakeProfit, e))
				{
					Action<j3bgDY9gV2i9bttJ1fiQ> action7 = this.Command;
					if (action7 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						action7((j3bgDY9gV2i9bttJ1fiQ)eXyugQbQuKtEflZ3Xooh());
						num2 = 24;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
						{
							num2 = 22;
						}
					}
				}
				else
				{
					if (!((UQpOEF95Pl27GeSpKZ6s)uNurNZbQz4yoDdQlQRmZ(vspL39fH6Hd69qemUHrA.Chart)).Check(e))
					{
						goto IL_0313;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action8 = this.Command;
					if (action8 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
						{
							num2 = 25;
						}
					}
					else
					{
						action8(j3bgDY9gV2i9bttJ1fiQ.StopLoss());
						num2 = 4;
					}
				}
			}
			else
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action9 = this.Command;
				if (action9 == null)
				{
					goto IL_03d9;
				}
				action9(j3bgDY9gV2i9bttJ1fiQ.CancelAll());
				num2 = 2;
			}
		}
		else
		{
			Action<j3bgDY9gV2i9bttJ1fiQ> action10 = this.Command;
			if (action10 == null)
			{
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				action10(j3bgDY9gV2i9bttJ1fiQ.CancelBids());
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num2 = 9;
				}
			}
		}
		goto IL_0009;
		IL_0313:
		if (!((PyYTjtHpHbZRtxYfvYWW)DXI1ifbQ3bh2FbR1t97G()).SetBreakevenStopLoss.Check(e))
		{
			goto IL_0468;
		}
		goto IL_04fa;
		IL_03b5:
		e.Handled = true;
		num5 = 10;
		goto IL_0005;
		IL_04fa:
		SetBreakevenStopLoss();
		e.Handled = true;
		goto IL_0468;
		IL_00d1:
		num5 = 30;
		goto IL_0005;
		IL_0468:
		return r8igZYbd0NS07r6GCWd9(e);
	}

	public bool KmO9deg1chF(vuqArBniIZpGahT6Xchg P_0)
	{
		int num = 23;
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = default(CoPfjK9hF3ASs5TbM8OK);
		long num3 = default(long);
		List<H17eBN9drmrGxanUFRD0>.Enumerator enumerator = default(List<H17eBN9drmrGxanUFRD0>.Enumerator);
		bool result = default(bool);
		ExitStrategyTarget exitStrategyTarget2 = default(ExitStrategyTarget);
		ExitStrategyTarget exitStrategyTarget = default(ExitStrategyTarget);
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 26:
					if (P8n9dM2IMjd().Type != bFjy1e9gtcJMGbrnrT3H.StopLoss)
					{
						if (P8n9dM2IMjd().Type == bFjy1e9gtcJMGbrnrT3H.TakeProfit)
						{
							coPfjK9hF3ASs5TbM8OK.RMg9wpA6CUj(num3);
							P8n9dM2IMjd().Price = num3;
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 29;
					}
					TBJI7CbdfJYgKMD4qRgo(coPfjK9hF3ASs5TbM8OK, num3);
					YyOuwHbd9e3vN9I0BvTj(P8n9dM2IMjd(), num3);
					num2 = 21;
					continue;
				case 4:
					enumerator = P_0.sgjniTG2Rhm.OphnocDJshi().OUB9QrZAXI6().GetEnumerator();
					num2 = 17;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
					{
						num2 = 15;
					}
					continue;
				case 17:
					try
					{
						int num4;
						while (true)
						{
							if (enumerator.MoveNext())
							{
								H17eBN9drmrGxanUFRD0 current = enumerator.Current;
								if (ushq5wbdvLdpfcmWYlQA(current).Contains(P_0.X, P_0.Y))
								{
									num4 = 4;
									break;
								}
								if (current.mF59d3YDffQ().Contains(P_0.X, P_0.Y))
								{
									num4 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
									{
										num4 = 1;
									}
									break;
								}
								continue;
							}
							num4 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
							{
								num4 = 0;
							}
							break;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
							case 4:
								BG09ddpAWBZ().Cursor = (Cursor)MELq1LbdBlYlH5I0g2AI();
								BG09ddpAWBZ().hFu9zU8KWXY(_0020: true);
								num4 = 3;
								continue;
							case 3:
							{
								result = true;
								int num5 = 2;
								num4 = num5;
								continue;
							}
							case 0:
								break;
							case 2:
								return result;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 14;
				case 18:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
					num2 = 15;
					continue;
				default:
					if (Y74rOWbdocRNuASkGIHY(exitStrategyTarget2) < num3 - 2)
					{
						exitStrategyTarget2.StopLossTrailingRange = num3 - Y74rOWbdocRNuASkGIHY(exitStrategyTarget2);
					}
					goto IL_0455;
				case 11:
					exitStrategyTarget = coPfjK9hF3ASs5TbM8OK.p8w9wjM6R5l(vu59dUXnTw8);
					if (exitStrategyTarget == null)
					{
						goto IL_0455;
					}
					if (coPfjK9hF3ASs5TbM8OK.PositionSize > 0)
					{
						num2 = 25;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 12;
				case 22:
					return false;
				case 10:
					if (coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
					{
						num2 = 28;
						continue;
					}
					goto IL_0455;
				case 1:
				case 3:
				case 6:
				case 7:
				case 19:
				case 21:
				case 24:
					goto IL_0455;
				case 9:
				case 27:
					coPfjK9hF3ASs5TbM8OK.jPs9wJ1xvmD(0L);
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
					vu59dUXnTw8 = "";
					goto IL_0455;
				case 2:
					TBJI7CbdfJYgKMD4qRgo(coPfjK9hF3ASs5TbM8OK, num3);
					goto IL_0455;
				case 12:
					if (exitStrategyTarget.TakeProfitPrice < num3 - 2)
					{
						exitStrategyTarget.TakeProfitRange = num3 - a0vicnbdnVOvy7Cj4gkS(exitStrategyTarget);
					}
					goto IL_0455;
				case 28:
					if (coPfjK9hF3ASs5TbM8OK.PositionSize > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (Y74rOWbdocRNuASkGIHY(exitStrategyTarget2) > num3 + 2)
					{
						exitStrategyTarget2.StopLossTrailingRange = Y74rOWbdocRNuASkGIHY(exitStrategyTarget2) - num3;
						num = 7;
						break;
					}
					goto IL_0455;
				case 23:
					if (AmrG9DbQZsnQ0bnmZOE3(BG09ddpAWBZ()))
					{
						if (TPt9dtRB6wx == FrFpU89dyE3xMtDTrecP.None)
						{
							if (P_0.VaxniVEaIDj == (f1xMHJnlTRMcWr2NsmSZ)4)
							{
								num2 = 4;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 14;
						}
						if (P_0.sgjniTG2Rhm != null)
						{
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto IL_041c;
					}
					num2 = 22;
					continue;
				case 14:
					return false;
				case 20:
					if (exitStrategyTarget2 != null)
					{
						num2 = 10;
						continue;
					}
					goto case 13;
				case 15:
					vu59dUXnTw8 = "";
					goto IL_0455;
				case 5:
					coPfjK9hF3ASs5TbM8OK.RMg9wpA6CUj(0L);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
					{
						num2 = 18;
					}
					continue;
				case 13:
					coPfjK9hF3ASs5TbM8OK.nUa9wvxIwoV();
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
					num2 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
					{
						num2 = 3;
					}
					continue;
				case 25:
					if (a0vicnbdnVOvy7Cj4gkS(exitStrategyTarget) > num3 + 2)
					{
						exitStrategyTarget.TakeProfitRange = exitStrategyTarget.TakeProfitPrice - num3;
						num2 = 6;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_0455;
				case 8:
					if (ajI2i9bd2K3hO0gyrTot(P_0.sgjniTG2Rhm))
					{
						ypqMIv9maFM0tRwF0xMh = BG09ddpAWBZ().Chart.DataProvider;
						coPfjK9hF3ASs5TbM8OK = ((t4J54f97Q2MUX30RSwuQ)mO9Y3lbdHHS6rOxDDFOP(ypqMIv9maFM0tRwF0xMh)).Position;
						num3 = (long)Math.Round(P_0.sgjniTG2Rhm.ybUnYpBPWvT().rPGnvCy3AGu(P_0.Y) / (ypqMIv9maFM0tRwF0xMh.Step / (double)Mxtb2BbQKRFudN6KKoWJ(ypqMIv9maFM0tRwF0xMh)));
						switch (TPt9dtRB6wx)
						{
						case FrFpU89dyE3xMtDTrecP.Order:
							break;
						case FrFpU89dyE3xMtDTrecP.StopLossTrailing:
							goto IL_00f4;
						case (FrFpU89dyE3xMtDTrecP)2:
							goto IL_0173;
						case FrFpU89dyE3xMtDTrecP.TakeProfitTrailing:
							goto IL_02d6;
						case (FrFpU89dyE3xMtDTrecP)3:
							goto IL_0444;
						default:
							goto IL_0455;
						}
						goto case 26;
					}
					goto IL_041c;
				case 29:
					P8n9dM2IMjd().Price = (long)Math.Round(P_0.sgjniTG2Rhm.ybUnYpBPWvT().rPGnvCy3AGu(P_0.Y) / ypqMIv9maFM0tRwF0xMh.Step);
					goto IL_0455;
				case 16:
					{
						vu59dUXnTw8 = "";
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_0444:
					if (coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
					{
						XxXBhsbdGnESvqJ6ZU56(coPfjK9hF3ASs5TbM8OK, num3);
						num2 = 19;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 5;
					IL_041c:
					return true;
					IL_02d6:
					if (coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
					{
						num2 = 11;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					coPfjK9hF3ASs5TbM8OK.Xmc9w1pffIA();
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
					vu59dUXnTw8 = "";
					num = 24;
					break;
					IL_0455:
					return true;
					IL_0173:
					if (coPfjK9hF3ASs5TbM8OK.PositionSize == 0L)
					{
						num2 = 27;
						continue;
					}
					goto case 2;
					IL_00f4:
					exitStrategyTarget2 = (ExitStrategyTarget)VK3stPbdYcNlSosrmnlX(coPfjK9hF3ASs5TbM8OK, vu59dUXnTw8);
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	public bool MouseDown(vuqArBniIZpGahT6Xchg hitInfo, int clickCount, MouseButton changedButton)
	{
		if (!AmrG9DbQZsnQ0bnmZOE3(BG09ddpAWBZ()))
		{
			return false;
		}
		if (hitInfo.VaxniVEaIDj == (f1xMHJnlTRMcWr2NsmSZ)4)
		{
			int num = 2;
			CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK2 = default(CoPfjK9hF3ASs5TbM8OK);
			ExitStrategyTarget exitStrategyTarget = default(ExitStrategyTarget);
			ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh4 = default(ypqMIv9maFM0tRwF0xMh);
			vJGfm5nYMCEZFuST02my sgjniTG2Rhm = default(vJGfm5nYMCEZFuST02my);
			H17eBN9drmrGxanUFRD0 h17eBN9drmrGxanUFRD = default(H17eBN9drmrGxanUFRD0);
			Rect rect = default(Rect);
			CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK4 = default(CoPfjK9hF3ASs5TbM8OK);
			ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh3 = default(ypqMIv9maFM0tRwF0xMh);
			ExitStrategyTarget exitStrategyTarget3 = default(ExitStrategyTarget);
			xg2cjD9QE5jRw708Tc0u xg2cjD9QE5jRw708Tc0u = default(xg2cjD9QE5jRw708Tc0u);
			int num3 = default(int);
			long num5 = default(long);
			ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
			PcRcnY9glMCwOW1X7rwa pcRcnY9glMCwOW1X7rwa = default(PcRcnY9glMCwOW1X7rwa);
			ExitStrategyTarget exitStrategyTarget4 = default(ExitStrategyTarget);
			ExitStrategyTarget exitStrategyTarget2 = default(ExitStrategyTarget);
			ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh2 = default(ypqMIv9maFM0tRwF0xMh);
			CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK3 = default(CoPfjK9hF3ASs5TbM8OK);
			int? offset2 = default(int?);
			ExitStrategyTarget exitStrategyTarget5 = default(ExitStrategyTarget);
			CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = default(CoPfjK9hF3ASs5TbM8OK);
			long num4 = default(long);
			while (true)
			{
				int num2;
				Action<j3bgDY9gV2i9bttJ1fiQ> action;
				Action<j3bgDY9gV2i9bttJ1fiQ> action2;
				Action<j3bgDY9gV2i9bttJ1fiQ> action3;
				switch (num)
				{
				case 51:
					P8n9dM2IMjd().Quantity = eTY8Y9bdQkSDq0A5BPde(coPfjK9hF3ASs5TbM8OK2.PositionSize);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
					{
						num = 1;
					}
					continue;
				case 30:
					bWx9csbdMINbiC8Hkv4x(exitStrategyTarget, 0L);
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6(TigerTrade.Chart.Properties.Resources.ErrorPlacingSlOnWrongSideTitle, TigerTrade.Chart.Properties.Resources.ErrorPlacingSlOnWrongSideMessage, NotificationType.Error));
					goto IL_0d7a;
				case 11:
					BG09ddpAWBZ().hFu9zU8KWXY(_0020: false);
					num = 36;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
					{
						num = 11;
					}
					continue;
				case 3:
					TBJI7CbdfJYgKMD4qRgo(BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position, 0L);
					num = 64;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
					{
						num = 59;
					}
					continue;
				case 57:
					if (changedButton == MouseButton.Left)
					{
						goto case 34;
					}
					goto IL_0feb;
				case 49:
					if (exitStrategyTarget != null)
					{
						ypqMIv9maFM0tRwF0xMh4 = ((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider;
						num = 31;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
						{
							num = 23;
						}
						continue;
					}
					goto IL_0feb;
				case 56:
					((xg2cjD9QE5jRw708Tc0u)YQEpMFbd5s3Wr6LhncdS(sgjniTG2Rhm)).yT19QdJ61QY(P8n9dM2IMjd());
					P8n9dM2IMjd().Type = (bFjy1e9gtcJMGbrnrT3H)2;
					P8n9dM2IMjd().AkR9gcsS1jK(pX0hJFbdlvifc34hv00j(h17eBN9drmrGxanUFRD));
					P8n9dM2IMjd().Price = 0L;
					P8n9dM2IMjd().Quantity = h17eBN9drmrGxanUFRD.Quantity;
					P8n9dM2IMjd().Side = QwIcsIbd1hCt4ciEWr3i(h17eBN9drmrGxanUFRD);
					num = 61;
					continue;
				case 38:
					return true;
				case 1:
					TBJI7CbdfJYgKMD4qRgo(coPfjK9hF3ASs5TbM8OK2, pX0hJFbdlvifc34hv00j(h17eBN9drmrGxanUFRD));
					vu59dUXnTw8 = h17eBN9drmrGxanUFRD.FxO9gHeFsPi();
					goto IL_0748;
				case 39:
					return true;
				case 24:
					rect = hm0q51bdkxWBFCedqsLP(h17eBN9drmrGxanUFRD);
					num2 = 63;
					goto IL_0005;
				case 66:
					coPfjK9hF3ASs5TbM8OK4 = (CoPfjK9hF3ASs5TbM8OK)YpCk1jbd4JmCA2Ijq1Yq(mO9Y3lbdHHS6rOxDDFOP(ypqMIv9maFM0tRwF0xMh3));
					exitStrategyTarget3 = coPfjK9hF3ASs5TbM8OK4.p8w9wjM6R5l((string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD));
					if (exitStrategyTarget3 == null)
					{
						num = 27;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num = 9;
						}
						continue;
					}
					goto case 17;
				case 2:
					if (!hitInfo.sgjniTG2Rhm.XXdnoI2riZU())
					{
						break;
					}
					sgjniTG2Rhm = hitInfo.sgjniTG2Rhm;
					xg2cjD9QE5jRw708Tc0u = sgjniTG2Rhm.OphnocDJshi();
					num3 = xg2cjD9QE5jRw708Tc0u.OUB9QrZAXI6().Count;
					goto IL_0e86;
				case 58:
					num5 = ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).AskPrice * ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).PriceScale;
					num = 67;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num = 67;
					}
					continue;
				case 36:
					return true;
				case 21:
					pcRcnY9glMCwOW1X7rwa = h17eBN9drmrGxanUFRD.Type;
					num2 = 32;
					goto IL_0005;
				case 40:
					P8n9dM2IMjd().Side = QwIcsIbd1hCt4ciEWr3i(h17eBN9drmrGxanUFRD);
					num2 = 26;
					goto IL_0005;
				case 31:
				{
					long num6 = ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh4)).BidPrice * v3SEVAbdgXi1giEDZXok(MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh4));
					long num7 = ypqMIv9maFM0tRwF0xMh4.lEVl9w6fCd9().AskPrice * ypqMIv9maFM0tRwF0xMh4.lEVl9w6fCd9().PriceScale;
					CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK5 = ypqMIv9maFM0tRwF0xMh4.d73l9JpDb23.Position;
					if (hBbPvlfnGPAsNPHIOheE.pkVfnoYHhyH(T2etHQbdewuvuxQlsYql(coPfjK9hF3ASs5TbM8OK5), num6, num7, PMymRPbdR0JIM9mggXY0(coPfjK9hF3ASs5TbM8OK5)))
					{
						int? offset = BG09ddpAWBZ().Symbol.GetOffset(((CR1isWfDCD1A4fwfUJUf)PtJcBDbd6oaiqMpMWZQB(BG09ddpAWBZ().MarketSettings)).StopLossOffset, ((CR1isWfDCD1A4fwfUJUf)PtJcBDbd6oaiqMpMWZQB(BG09ddpAWBZ().MarketSettings)).StopLossPercentOffset, coPfjK9hF3ASs5TbM8OK5.d919wPySHGR(), BG09ddpAWBZ().MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
						exitStrategyTarget.StopLossOffset = offset;
						exitStrategyTarget.StopLossPrice = coPfjK9hF3ASs5TbM8OK5.d919wPySHGR();
						goto IL_0d7a;
					}
					num = 30;
					continue;
				}
				case 52:
					exitStrategyTarget4.TpSynchronized = false;
					num = 28;
					continue;
				case 41:
					if (exitStrategyTarget2.TakeProfitRange == 0L)
					{
						exitStrategyTarget2.TakeProfitRange = 10 * Mxtb2BbQKRFudN6KKoWJ(ypqMIv9maFM0tRwF0xMh2);
						exitStrategyTarget2.TakeProfitStopActive = false;
					}
					else
					{
						q45GDubdclMSnsjRFXJk(exitStrategyTarget2, 0L);
						ihwUySbdj1wVYNJeP0uN(exitStrategyTarget2, false);
					}
					goto IL_0748;
				case 67:
					coPfjK9hF3ASs5TbM8OK3 = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
					num2 = 22;
					goto IL_0005;
				case 50:
					return true;
				case 19:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
					num2 = 57;
					goto IL_0005;
				case 65:
					BG09ddpAWBZ().hFu9zU8KWXY(_0020: false);
					num2 = 50;
					goto IL_0005;
				case 63:
					if (rect.Contains(hitInfo.X, hitInfo.Y))
					{
						num = 21;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
						{
							num = 0;
						}
						continue;
					}
					goto IL_0360;
				case 48:
					offset2 = BG09ddpAWBZ().Symbol.GetOffset(BG09ddpAWBZ().MarketSettings.TradeSettings.TakeProfitOffset, ((CR1isWfDCD1A4fwfUJUf)PtJcBDbd6oaiqMpMWZQB(e2OIgUbdW3Qk1Ygc8wj0(BG09ddpAWBZ()))).TakeProfitPercentOffset, coPfjK9hF3ASs5TbM8OK3.mfq9w3ApRCG(), ((MarketSettings)e2OIgUbdW3Qk1Ygc8wj0(BG09ddpAWBZ())).TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
					{
						num = 4;
					}
					continue;
				case 20:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.TakeProfitTrailing;
					vu59dUXnTw8 = (string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD);
					goto IL_035e;
				case 42:
					switch (changedButton)
					{
					case MouseButton.Left:
						return imG9dsetmPw((H17eBN9drmrGxanUFRD0)FqirmBbdUHh2LjjjP9d9(YQEpMFbd5s3Wr6LhncdS(sgjniTG2Rhm)));
					case MouseButton.Right:
						num = 5;
						continue;
					}
					goto IL_0fd2;
				case 13:
					return true;
				case 55:
					s5hYTFbdE5DKhvPSoPob(P8n9dM2IMjd(), h17eBN9drmrGxanUFRD.Price);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
					{
						num = 0;
					}
					continue;
				case 17:
					if (Oqijw0bdLQTSn1LA3kkM(exitStrategyTarget3) == 0L)
					{
						num = 53;
						continue;
					}
					exitStrategyTarget3.StopLossTrailingRange = 0L;
					num2 = 25;
					goto IL_0005;
				case 14:
					exitStrategyTarget2 = ((CoPfjK9hF3ASs5TbM8OK)YpCk1jbd4JmCA2Ijq1Yq(ypqMIv9maFM0tRwF0xMh2.d73l9JpDb23)).p8w9wjM6R5l((string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD));
					if (exitStrategyTarget2 != null)
					{
						num = 21;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
						{
							num = 41;
						}
						continue;
					}
					goto IL_0748;
				case 10:
					vu59dUXnTw8 = (string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD);
					goto case 25;
				case 62:
					h9mmQkbdXxmfXuA3QM78(P8n9dM2IMjd(), bFjy1e9gtcJMGbrnrT3H.StopLoss);
					num = 18;
					continue;
				case 43:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.Order;
					num = 12;
					continue;
				case 32:
					switch (pcRcnY9glMCwOW1X7rwa)
					{
					case PcRcnY9glMCwOW1X7rwa.TakeProfitTrailing:
						goto IL_051a;
					case PcRcnY9glMCwOW1X7rwa.StopLoss:
						goto IL_053f;
					case PcRcnY9glMCwOW1X7rwa.StopLossTrailing:
						TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.StopLossTrailing;
						vu59dUXnTw8 = (string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD);
						return true;
					case (PcRcnY9glMCwOW1X7rwa)10:
						goto IL_0aef;
					case PcRcnY9glMCwOW1X7rwa.TakeProfit:
						goto IL_0d69;
					case (PcRcnY9glMCwOW1X7rwa)9:
						goto IL_0d87;
					case (PcRcnY9glMCwOW1X7rwa)11:
						goto IL_0e55;
					}
					goto IL_0360;
				case 26:
					return true;
				case 46:
					if (exitStrategyTarget5 != null)
					{
						exitStrategyTarget5.TakeProfitStopActive = false;
					}
					goto IL_035e;
				case 35:
					h9mmQkbdXxmfXuA3QM78(P8n9dM2IMjd(), bFjy1e9gtcJMGbrnrT3H.TakeProfit);
					num = 55;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
					{
						num = 55;
					}
					continue;
				case 37:
					VVnqpZbdS63EvSBZo4U5(P8n9dM2IMjd(), Math.Abs(coPfjK9hF3ASs5TbM8OK.PositionSize));
					coPfjK9hF3ASs5TbM8OK.jPs9wJ1xvmD(h17eBN9drmrGxanUFRD.Price);
					num = 10;
					continue;
				case 12:
					((xg2cjD9QE5jRw708Tc0u)YQEpMFbd5s3Wr6LhncdS(sgjniTG2Rhm)).yT19QdJ61QY(P8n9dM2IMjd());
					num = 35;
					continue;
				case 53:
				{
					long val = ((T2etHQbdewuvuxQlsYql(coPfjK9hF3ASs5TbM8OK4) > 0) ? (((daEwNq9FXerRxid1xGMa)VZH2vabQCyKtgw460b4t(ypqMIv9maFM0tRwF0xMh3)).BidPrice * ypqMIv9maFM0tRwF0xMh3.UJElnHayjot - Y74rOWbdocRNuASkGIHY(exitStrategyTarget3)) : (exitStrategyTarget3.StopLossPrice - ypqMIv9maFM0tRwF0xMh3.OpZl98KAYgk().AskPrice * Mxtb2BbQKRFudN6KKoWJ(ypqMIv9maFM0tRwF0xMh3)));
					UTqkUXbdsPs2RuqXbgwA(exitStrategyTarget3, Math.Max(10 * ypqMIv9maFM0tRwF0xMh3.UJElnHayjot, val));
					num = 54;
					continue;
				}
				case 6:
					goto IL_0bde;
				case 9:
					P8n9dM2IMjd().AkR9gcsS1jK(pX0hJFbdlvifc34hv00j(h17eBN9drmrGxanUFRD));
					P8n9dM2IMjd().Price = 0L;
					num2 = 16;
					goto IL_0005;
				case 29:
					P8n9dM2IMjd().Price = 0L;
					P8n9dM2IMjd().Quantity = h17eBN9drmrGxanUFRD.Quantity;
					num = 40;
					continue;
				case 7:
					exitStrategyTarget4.TakeProfitPrice = coPfjK9hF3ASs5TbM8OK3.mfq9w3ApRCG();
					goto case 52;
				case 28:
					vu59dUXnTw8 = "";
					((CoPfjK9hF3ASs5TbM8OK)YpCk1jbd4JmCA2Ijq1Yq(mO9Y3lbdHHS6rOxDDFOP(BG09ddpAWBZ().Chart.DataProvider))).RMg9wpA6CUj(0L);
					dJDT5DbdOjCVRjZxDIdL(BG09ddpAWBZ(), BG09ddpAWBZ().riG9uw4EYX4());
					num = 42;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
					{
						num = 65;
					}
					continue;
				case 16:
					VVnqpZbdS63EvSBZo4U5(P8n9dM2IMjd(), h17eBN9drmrGxanUFRD.Quantity);
					iFsVjgbdxRo800ItQmsw(P8n9dM2IMjd(), QwIcsIbd1hCt4ciEWr3i(h17eBN9drmrGxanUFRD));
					return true;
				case 47:
					ypqMIv9maFM0tRwF0xMh3 = ((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider;
					num = 66;
					continue;
				case 25:
				case 27:
				case 54:
					return true;
				case 8:
					goto IL_0d87;
				case 4:
					exitStrategyTarget4.TakeProfitOffset = offset2;
					num = 7;
					continue;
				case 15:
					exitStrategyTarget4.TakeProfitPrice = 0L;
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)PWnP7Ubdt9DggPKXBQhc(), TigerTrade.Chart.Properties.Resources.ErrorPlacingTpOnWrongSideMessage, NotificationType.Error));
					num = 27;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num = 52;
					}
					continue;
				case 23:
					switch (pcRcnY9glMCwOW1X7rwa)
					{
					case PcRcnY9glMCwOW1X7rwa.StopLoss:
						break;
					case PcRcnY9glMCwOW1X7rwa.TakeProfitTrailing:
						goto IL_05cd;
					case PcRcnY9glMCwOW1X7rwa.TakeProfit:
						E0ys6ebdboJ8i7rdtQiQ(YpCk1jbd4JmCA2Ijq1Yq(((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider.d73l9JpDb23), h17eBN9drmrGxanUFRD.FxO9gHeFsPi());
						return true;
					case (PcRcnY9glMCwOW1X7rwa)9:
						goto IL_0bde;
					default:
						goto IL_0ded;
					case PcRcnY9glMCwOW1X7rwa.StopLossTrailing:
						goto IL_0f68;
					case (PcRcnY9glMCwOW1X7rwa)10:
						this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)bSc7I8bdikdC3MwmJbwk(h17eBN9drmrGxanUFRD.Price));
						return true;
					case (PcRcnY9glMCwOW1X7rwa)11:
						goto IL_10e3;
					case PcRcnY9glMCwOW1X7rwa.Position:
						goto IL_111c;
					}
					((CoPfjK9hF3ASs5TbM8OK)YpCk1jbd4JmCA2Ijq1Yq(mO9Y3lbdHHS6rOxDDFOP(GIyarkbQ7tKOkdFlOaJi(BG09ddpAWBZ().Chart)))).JXC9wangJGu(h17eBN9drmrGxanUFRD.FxO9gHeFsPi());
					num = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num = 33;
					}
					continue;
				case 44:
					ypqMIv9maFM0tRwF0xMh2 = ((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
					{
						num = 14;
					}
					continue;
				case 61:
					return true;
				case 18:
					P8n9dM2IMjd().AkR9gcsS1jK(h17eBN9drmrGxanUFRD.Price);
					P8n9dM2IMjd().Price = 0L;
					coPfjK9hF3ASs5TbM8OK = BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position;
					num = 45;
					continue;
				case 64:
					dJDT5DbdOjCVRjZxDIdL(BG09ddpAWBZ(), BG09ddpAWBZ().riG9uw4EYX4());
					num = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num = 11;
					}
					continue;
				case 34:
					exitStrategyTarget = ((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider.d73l9JpDb23.Position.p8w9wjM6R5l(vu59dUXnTw8);
					num = 49;
					continue;
				case 33:
					return true;
				case 5:
					return imG9dsetmPw(sgjniTG2Rhm.OphnocDJshi().UR79QVmteFG());
				case 22:
					if (nYSQi5bdI8ywlYMp66V6(coPfjK9hF3ASs5TbM8OK3.PositionSize, num4, num5, XQWbBUbdqw6vEWCiKd7t(coPfjK9hF3ASs5TbM8OK3)))
					{
						num = 25;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
						{
							num = 48;
						}
						continue;
					}
					goto case 15;
				default:
					YyOuwHbd9e3vN9I0BvTj(P8n9dM2IMjd(), 0L);
					coPfjK9hF3ASs5TbM8OK2 = BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position;
					P8n9dM2IMjd().Side = ((coPfjK9hF3ASs5TbM8OK2.PositionSize > 0) ? Side.Sell : Side.Buy);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
					{
						num = 51;
					}
					continue;
				case 60:
					return true;
				case 59:
					return true;
				case 45:
					{
						P8n9dM2IMjd().Side = ((T2etHQbdewuvuxQlsYql(coPfjK9hF3ASs5TbM8OK) > 0) ? Side.Sell : Side.Buy);
						num = 37;
						continue;
					}
					IL_0d7a:
					exitStrategyTarget.SlSynchronized = false;
					goto IL_0feb;
					IL_0360:
					num3--;
					goto IL_0e86;
					IL_111c:
					action = this.Command;
					if (action == null)
					{
						goto case 38;
					}
					action(j3bgDY9gV2i9bttJ1fiQ.ClosePosition());
					num2 = 38;
					goto IL_0005;
					IL_10e3:
					action2 = this.Command;
					if (action2 == null)
					{
						goto case 59;
					}
					action2(j3bgDY9gV2i9bttJ1fiQ.jEY9RYPqb91(pX0hJFbdlvifc34hv00j(h17eBN9drmrGxanUFRD)));
					num = 59;
					continue;
					IL_0feb:
					vu59dUXnTw8 = "";
					num = 3;
					continue;
					IL_0f68:
					VF3NdJbdDuKCaRX7yKjx(BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position, h17eBN9drmrGxanUFRD.FxO9gHeFsPi());
					num = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num = 13;
					}
					continue;
					IL_0ded:
					num = 24;
					continue;
					IL_05cd:
					((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider.d73l9JpDb23.Position.ER99wxMcNWb((string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD));
					num = 39;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num = 11;
					}
					continue;
					IL_0bde:
					action3 = this.Command;
					if (action3 == null)
					{
						num = 60;
						continue;
					}
					action3((j3bgDY9gV2i9bttJ1fiQ)DP55RTbdaOQ0IE7BneeH(h17eBN9drmrGxanUFRD.Price));
					goto case 60;
					IL_0e86:
					if (num3 > 0)
					{
						h17eBN9drmrGxanUFRD = xg2cjD9QE5jRw708Tc0u.OUB9QrZAXI6()[num3 - 1];
						rect = ushq5wbdvLdpfcmWYlQA(h17eBN9drmrGxanUFRD);
						if (rect.Contains(hitInfo.X, hitInfo.Y))
						{
							pcRcnY9glMCwOW1X7rwa = h17eBN9drmrGxanUFRD.Type;
							num = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
							{
								num = 23;
							}
							continue;
						}
						goto case 24;
					}
					if (TPt9dtRB6wx != (FrFpU89dyE3xMtDTrecP)2)
					{
						if (TPt9dtRB6wx != (FrFpU89dyE3xMtDTrecP)3)
						{
							if (sgjniTG2Rhm.Chart.xFinij9iLDm && !BG09ddpAWBZ().Wna9ztZYlSp())
							{
								num = 42;
								continue;
							}
							goto IL_0fd2;
						}
						TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
						if (changedButton == MouseButton.Left)
						{
							exitStrategyTarget4 = (ExitStrategyTarget)VK3stPbdYcNlSosrmnlX(BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position, vu59dUXnTw8);
							if (exitStrategyTarget4 != null)
							{
								ypqMIv9maFM0tRwF0xMh = (ypqMIv9maFM0tRwF0xMh)GIyarkbQ7tKOkdFlOaJi(BG09ddpAWBZ().Chart);
								num4 = ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9().BidPrice * ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9().PriceScale;
								num = 58;
								continue;
							}
						}
						goto case 28;
					}
					num = 19;
					continue;
					IL_0005:
					num = num2;
					continue;
					IL_0e55:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.Order;
					sgjniTG2Rhm.OphnocDJshi().yT19QdJ61QY(P8n9dM2IMjd());
					P8n9dM2IMjd().Type = (bFjy1e9gtcJMGbrnrT3H)3;
					num = 9;
					continue;
					IL_0d87:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.Order;
					sgjniTG2Rhm.OphnocDJshi().yT19QdJ61QY(P8n9dM2IMjd());
					P8n9dM2IMjd().Type = (bFjy1e9gtcJMGbrnrT3H)1;
					P8n9dM2IMjd().AkR9gcsS1jK(h17eBN9drmrGxanUFRD.Price);
					num = 29;
					continue;
					IL_0d69:
					if (clickCount == 2)
					{
						num = 44;
						continue;
					}
					goto case 43;
					IL_0aef:
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.Order;
					num = 56;
					continue;
					IL_053f:
					if (clickCount == 2)
					{
						num = 18;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
						{
							num = 47;
						}
						continue;
					}
					TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.Order;
					sgjniTG2Rhm.OphnocDJshi().yT19QdJ61QY(P8n9dM2IMjd());
					num2 = 62;
					goto IL_0005;
					IL_051a:
					if (clickCount == 2)
					{
						exitStrategyTarget5 = BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position.p8w9wjM6R5l((string)gtCIFTbdN9MPPwt1NQcZ(h17eBN9drmrGxanUFRD));
						num = 46;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
						{
							num = 26;
						}
						continue;
					}
					goto case 20;
					IL_0748:
					return true;
					IL_035e:
					return true;
					IL_0fd2:
					return false;
				}
				break;
			}
		}
		return false;
	}

	private void SetBreakevenStopLoss()
	{
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = BG09ddpAWBZ().Chart.DataProvider;
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num = 0;
		}
		long num2 = default(long);
		long num3 = default(long);
		ExitStrategyTarget exitStrategyTarget = default(ExitStrategyTarget);
		while (true)
		{
			object obj;
			switch (num)
			{
			case 4:
				if (hBbPvlfnGPAsNPHIOheE.pkVfnoYHhyH(coPfjK9hF3ASs5TbM8OK.PositionSize, num2, num3, coPfjK9hF3ASs5TbM8OK.PositionPrice))
				{
					int? offset = BG09ddpAWBZ().Symbol.GetOffset(((CR1isWfDCD1A4fwfUJUf)PtJcBDbd6oaiqMpMWZQB(e2OIgUbdW3Qk1Ygc8wj0(BG09ddpAWBZ()))).StopLossOffset, BG09ddpAWBZ().MarketSettings.TradeSettings.StopLossPercentOffset, PMymRPbdR0JIM9mggXY0(coPfjK9hF3ASs5TbM8OK), m2Tka9bdCuGTiq2r9nri(PtJcBDbd6oaiqMpMWZQB(BG09ddpAWBZ().MarketSettings)) == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					exitStrategyTarget.StopLossOffset = offset;
					exitStrategyTarget.StopLossPrice = aH0ZpgbdrZi6VC5ElNXL(coPfjK9hF3ASs5TbM8OK);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
					{
						num = 0;
					}
				}
				else
				{
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)dTnQcJbdKdX6cKaoiG7B(), TigerTrade.Chart.Properties.Resources.ErrorPlacingSlOnWrongSideMessage, NotificationType.Error));
					num = 5;
				}
				continue;
			case 1:
			{
				if (coPfjK9hF3ASs5TbM8OK.PositionSize == 0L)
				{
					return;
				}
				object obj2 = leux14bdTlS4SxHSEmvh(coPfjK9hF3ASs5TbM8OK);
				if (obj2 == null)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
					{
						num = 2;
					}
					continue;
				}
				obj = lXdy9QbdZw3KgDuSjMAb(zANDp1bdyX6sb9uQlt9u(obj2), true);
				break;
			}
			case 3:
				return;
			case 5:
				return;
			default:
				exitStrategyTarget.SlSynchronized = false;
				num = 3;
				continue;
			case 2:
				obj = null;
				break;
			}
			exitStrategyTarget = (ExitStrategyTarget)obj;
			if (exitStrategyTarget == null)
			{
				break;
			}
			num2 = ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9().BidPrice * ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).PriceScale;
			num3 = ImQDgEbdVxtTtoYB5u8p(ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9()) * ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9().PriceScale;
			num = 4;
		}
	}

	private bool imG9dsetmPw(H17eBN9drmrGxanUFRD0 P_0)
	{
		int num = 16;
		double num3 = default(double);
		long num4 = default(long);
		bool flag = default(bool);
		PcRcnY9glMCwOW1X7rwa pcRcnY9glMCwOW1X7rwa = default(PcRcnY9glMCwOW1X7rwa);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action3;
				switch (num2)
				{
				case 14:
					return false;
				case 3:
					if (!w1yLn5bQmT5exXixSY14(num3))
					{
						num2 = 10;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					return false;
				case 15:
					num4 = T2etHQbdewuvuxQlsYql(BG09ddpAWBZ().Chart.DataProvider.d73l9JpDb23.Position);
					num2 = 11;
					continue;
				case 6:
					return false;
				case 4:
				{
					Action<j3bgDY9gV2i9bttJ1fiQ> action6 = this.Command;
					if (action6 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						action6(j3bgDY9gV2i9bttJ1fiQ.Apx9gFiZ2i4(P_0.Price, num3));
						num2 = 19;
					}
					continue;
				}
				case 22:
					flag = true;
					num2 = 13;
					continue;
				case 24:
					return true;
				case 17:
				{
					Action<j3bgDY9gV2i9bttJ1fiQ> action4 = this.Command;
					if (action4 == null)
					{
						goto case 5;
					}
					action4(j3bgDY9gV2i9bttJ1fiQ.BuyMarket(num3));
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
					{
						num2 = 5;
					}
					continue;
				}
				case 7:
					if (!iWD9dEmwOP5(P_0.Price, out num3))
					{
						return false;
					}
					goto IL_02d7;
				case 18:
					pcRcnY9glMCwOW1X7rwa = P_0.Type;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
					{
						num2 = 20;
					}
					continue;
				case 5:
					return true;
				case 11:
					flag = false;
					if (num4 != 0L)
					{
						num2 = 23;
						continue;
					}
					goto case 18;
				case 25:
					return false;
				case 2:
					return true;
				case 9:
					return true;
				case 8:
					return false;
				case 23:
					if ((Keyboard.Modifiers & ModifierKeys.Alt) != ModifierKeys.None)
					{
						goto case 22;
					}
					goto case 18;
				case 20:
					switch (pcRcnY9glMCwOW1X7rwa)
					{
					case (PcRcnY9glMCwOW1X7rwa)6:
						break;
					case PcRcnY9glMCwOW1X7rwa.SellMarket:
						goto IL_0228;
					case PcRcnY9glMCwOW1X7rwa.SellLimit:
						goto IL_0236;
					case (PcRcnY9glMCwOW1X7rwa)4:
						goto IL_02ea;
					case (PcRcnY9glMCwOW1X7rwa)3:
						goto IL_032c;
					default:
						return false;
					case PcRcnY9glMCwOW1X7rwa.BuyLimit:
						goto IL_03d7;
					case PcRcnY9glMCwOW1X7rwa.BuyMarket:
						goto IL_040e;
					case (PcRcnY9glMCwOW1X7rwa)5:
						goto IL_0483;
					}
					if (flag || iWD9dEmwOP5(P_0.Price, out num3))
					{
						if (w1yLn5bQmT5exXixSY14(num3))
						{
							return false;
						}
						if (BG09ddpAWBZ().Chart.DataProvider.Symbol.IsDenomination)
						{
							num3 /= BG09ddpAWBZ().Chart.DataProvider.Symbol.ContractValue;
						}
						Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
						if (action == null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						action(j3bgDY9gV2i9bttJ1fiQ.SkY9guXe8vg(pX0hJFbdlvifc34hv00j(P_0), num3));
						goto default;
					}
					num2 = 14;
					continue;
				case 21:
					goto IL_03d7;
				case 26:
					if (!iWD9dEmwOP5(P_0.Price, out num3))
					{
						return false;
					}
					goto IL_02fd;
				default:
					return true;
				case 1:
				case 19:
					return true;
				case 12:
					if (!iWD9dEmwOP5(P_0.Price, out num3))
					{
						return false;
					}
					goto IL_0589;
				case 16:
					num3 = 0.0;
					num2 = 15;
					continue;
				case 13:
					num3 = (double)Math.Abs(num4) * Hm3NlCbdhNjDSBthIYWw(foQ1Sgbdm57ft7BF9Y78(GIyarkbQ7tKOkdFlOaJi(BG09ddpAWBZ().Chart)));
					num2 = 18;
					continue;
				case 10:
					{
						this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.lHo9gKTVT6f(pX0hJFbdlvifc34hv00j(P_0), num3));
						return true;
					}
					IL_02ea:
					if (!flag)
					{
						num2 = 26;
						continue;
					}
					goto IL_02fd;
					IL_02fd:
					if (!double.IsInfinity(num3))
					{
						num = 4;
						break;
					}
					goto case 6;
					IL_0483:
					if (flag || iWD9dEmwOP5(P_0.Price, out num3))
					{
						if (w1yLn5bQmT5exXixSY14(num3))
						{
							return false;
						}
						if (TXleSKbdwrsJDMcHlg8H(foQ1Sgbdm57ft7BF9Y78(((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider)))
						{
							num3 /= ((ypqMIv9maFM0tRwF0xMh)GIyarkbQ7tKOkdFlOaJi(BG09ddpAWBZ().Chart)).Symbol.ContractValue;
						}
						Action<j3bgDY9gV2i9bttJ1fiQ> action2 = this.Command;
						if (action2 == null)
						{
							num = 24;
							break;
						}
						action2(j3bgDY9gV2i9bttJ1fiQ.GLY9g8Zh5EP(P_0.Price, num3));
						goto case 24;
					}
					num2 = 25;
					continue;
					IL_0236:
					if (!flag)
					{
						num2 = 12;
						continue;
					}
					goto IL_0589;
					IL_0589:
					if (w1yLn5bQmT5exXixSY14(num3))
					{
						return false;
					}
					action3 = this.Command;
					if (action3 == null)
					{
						goto case 2;
					}
					action3(j3bgDY9gV2i9bttJ1fiQ.xCb9gPlN9Ao(pX0hJFbdlvifc34hv00j(P_0), num3));
					num2 = 2;
					continue;
					IL_040e:
					if (!flag && !iWD9dEmwOP5(WmPi9sbQrxV8cSobN6CA(VZH2vabQCyKtgw460b4t(((JWWhw2nBzBKPn08eRh08)WREIkFbQyWPEBEkid9OJ(BG09ddpAWBZ())).DataProvider)) * BG09ddpAWBZ().Chart.DataProvider.UJElnHayjot, out num3))
					{
						return false;
					}
					if (!double.IsInfinity(num3))
					{
						num2 = 17;
						continue;
					}
					return false;
					IL_0228:
					if (!flag && !iWD9dEmwOP5(lkO257bQPwW45huJeHdb(BG09ddpAWBZ().Chart.DataProvider.OpZl98KAYgk()) * Mxtb2BbQKRFudN6KKoWJ(BG09ddpAWBZ().Chart.DataProvider), out num3))
					{
						return false;
					}
					if (!double.IsInfinity(num3))
					{
						Action<j3bgDY9gV2i9bttJ1fiQ> action5 = this.Command;
						if (action5 == null)
						{
							goto case 9;
						}
						action5(j3bgDY9gV2i9bttJ1fiQ.SellMarket(num3));
						num = 9;
						break;
					}
					num2 = 8;
					continue;
					IL_03d7:
					if (!flag)
					{
						if (!iWD9dEmwOP5(pX0hJFbdlvifc34hv00j(P_0), out num3))
						{
							return false;
						}
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 3;
					IL_02d7:
					if (double.IsInfinity(num3))
					{
						return false;
					}
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.nnW9gh7VonN(pX0hJFbdlvifc34hv00j(P_0), num3));
					return true;
					IL_032c:
					if (!flag)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto IL_02d7;
				}
				break;
			}
		}
	}

	public bool YHc9dXpGEiX()
	{
		int num = 20;
		ExitStrategyTarget exitStrategyTarget = default(ExitStrategyTarget);
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = default(CoPfjK9hF3ASs5TbM8OK);
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
		long num6 = default(long);
		FrFpU89dyE3xMtDTrecP tPt9dtRB6wx = default(FrFpU89dyE3xMtDTrecP);
		long num4 = default(long);
		long num5 = default(long);
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action2;
				switch (num2)
				{
				case 16:
					exitStrategyTarget.StopLossPrice = exitStrategyTarget.TakeProfitPrice + 1;
					num2 = 2;
					continue;
				case 12:
					coPfjK9hF3ASs5TbM8OK = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
					num2 = 26;
					continue;
				case 1:
					eA5fLsbdPq9we9cK5dL1(exitStrategyTarget, exitStrategyTarget.StopLossPrice + 1);
					num2 = 15;
					continue;
				case 18:
					num6 = ImQDgEbdVxtTtoYB5u8p(MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)) * v3SEVAbdgXi1giEDZXok(MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh));
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					if ((uint)(tPt9dtRB6wx - 4) <= 1u)
					{
						TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
						num2 = 30;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					return false;
				case 28:
				{
					Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
					if (action == null)
					{
						num2 = 31;
						continue;
					}
					action(j3bgDY9gV2i9bttJ1fiQ.Q3V9Rl1Suni(wdnxasbd8AHA4SldgaKV(P8n9dM2IMjd()), P8n9dM2IMjd().Price));
					num2 = 14;
					continue;
				}
				case 4:
					num4 = ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).AskPrice * ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).PriceScale;
					num = 23;
					break;
				case 19:
					return false;
				case 32:
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6(TigerTrade.Chart.Properties.Resources.ErrorPlacingSlOnWrongSideTitle, (string)KIr5kTbdJI4p1534hpAO(), NotificationType.Error));
					num2 = 17;
					continue;
				case 21:
					P8n9dM2IMjd().Price = 0L;
					return true;
				case 2:
					XxXBhsbdGnESvqJ6ZU56(coPfjK9hF3ASs5TbM8OK, 0L);
					vu59dUXnTw8 = "";
					num2 = 10;
					continue;
				case 3:
					if (exitStrategyTarget.StopLossPrice <= exitStrategyTarget.TakeProfitPrice)
					{
						exitStrategyTarget.TakeProfitPrice = exitStrategyTarget.StopLossPrice - 1;
					}
					goto case 8;
				case 13:
					if (!nZgDaybdA7UZjR6eoRVh(T2etHQbdewuvuxQlsYql(coPfjK9hF3ASs5TbM8OK), num5, num6, P8n9dM2IMjd().Price))
					{
						goto case 32;
					}
					bWx9csbdMINbiC8Hkv4x(exitStrategyTarget, P8n9dM2IMjd().Price);
					exitStrategyTarget.SlSynchronized = false;
					if (exitStrategyTarget.TakeProfitPrice != 0L)
					{
						if (T2etHQbdewuvuxQlsYql(coPfjK9hF3ASs5TbM8OK) > 0 && exitStrategyTarget.StopLossPrice >= exitStrategyTarget.TakeProfitPrice)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 24;
					}
					goto case 8;
				case 30:
					vu59dUXnTw8 = "";
					BG09ddpAWBZ().Cursor = (Cursor)JU6BR6bd33eeMPLtl07u(BG09ddpAWBZ());
					rDo51qbdpMnGcVhE54k5(BG09ddpAWBZ(), false);
					return true;
				case 6:
					coPfjK9hF3ASs5TbM8OK = ((t4J54f97Q2MUX30RSwuQ)mO9Y3lbdHHS6rOxDDFOP(ypqMIv9maFM0tRwF0xMh)).Position;
					exitStrategyTarget = coPfjK9hF3ASs5TbM8OK.p8w9wjM6R5l(vu59dUXnTw8);
					if (exitStrategyTarget != null)
					{
						num3 = ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).BidPrice * ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).PriceScale;
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 26:
					exitStrategyTarget = coPfjK9hF3ASs5TbM8OK.p8w9wjM6R5l(vu59dUXnTw8);
					if (exitStrategyTarget == null)
					{
						num2 = 8;
						continue;
					}
					goto case 27;
				case 23:
					if (!hBbPvlfnGPAsNPHIOheE.grMfnvRcxNi(coPfjK9hF3ASs5TbM8OK.PositionSize, num3, num4, f1W6FHbd7vG95LlqcMGV(P8n9dM2IMjd())))
					{
						K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)PWnP7Ubdt9DggPKXBQhc(), (string)laTIvjbdFuVJEVtooNk1(), NotificationType.Error));
						goto case 2;
					}
					exitStrategyTarget.TakeProfitPrice = P8n9dM2IMjd().Price;
					exitStrategyTarget.TpSynchronized = false;
					num2 = 29;
					continue;
				case 27:
					num5 = ((kjc7Gl9PIEfKaxcEBwuk)MGlosGbddFruZQnKvwbC(ypqMIv9maFM0tRwF0xMh)).BidPrice * v3SEVAbdgXi1giEDZXok(ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9());
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
					{
						num2 = 18;
					}
					continue;
				default:
					if (Y74rOWbdocRNuASkGIHY(exitStrategyTarget) <= a0vicnbdnVOvy7Cj4gkS(exitStrategyTarget))
					{
						num2 = 16;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 2;
				case 9:
				case 10:
				case 11:
				case 14:
				case 22:
				case 31:
					goto IL_061f;
				case 24:
					if (coPfjK9hF3ASs5TbM8OK.PositionSize < 0)
					{
						goto case 3;
					}
					goto case 8;
				case 25:
					bWx9csbdMINbiC8Hkv4x(exitStrategyTarget, a0vicnbdnVOvy7Cj4gkS(exitStrategyTarget) - 1);
					goto case 2;
				case 20:
					if (BG09ddpAWBZ().rhw9uznkSlZ())
					{
						tPt9dtRB6wx = TPt9dtRB6wx;
						if (tPt9dtRB6wx != FrFpU89dyE3xMtDTrecP.Order)
						{
							num2 = 7;
							continue;
						}
						TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
						if (P8n9dM2IMjd().Price != 0L && f1W6FHbd7vG95LlqcMGV(P8n9dM2IMjd()) != wdnxasbd8AHA4SldgaKV(P8n9dM2IMjd()))
						{
							switch (P8n9dM2IMjd().Type)
							{
							case (bFjy1e9gtcJMGbrnrT3H)3:
								break;
							case bFjy1e9gtcJMGbrnrT3H.StopLoss:
								goto IL_0458;
							case bFjy1e9gtcJMGbrnrT3H.TakeProfit:
								goto IL_04d7;
							default:
								goto IL_061f;
							case (bFjy1e9gtcJMGbrnrT3H)1:
								goto IL_072b;
							case (bFjy1e9gtcJMGbrnrT3H)2:
								goto IL_078a;
							}
							goto case 28;
						}
						goto IL_061f;
					}
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
					{
						num2 = 19;
					}
					continue;
				case 8:
				case 15:
				case 17:
					coPfjK9hF3ASs5TbM8OK.jPs9wJ1xvmD(0L);
					vu59dUXnTw8 = "";
					num2 = 9;
					continue;
				case 29:
					if (Y74rOWbdocRNuASkGIHY(exitStrategyTarget) != 0L)
					{
						if (coPfjK9hF3ASs5TbM8OK.PositionSize > 0 && exitStrategyTarget.StopLossPrice >= a0vicnbdnVOvy7Cj4gkS(exitStrategyTarget))
						{
							num = 25;
							break;
						}
						if (coPfjK9hF3ASs5TbM8OK.PositionSize < 0)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
							{
								num2 = 0;
							}
							continue;
						}
					}
					goto case 2;
				case 5:
					goto IL_078a;
					IL_078a:
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.eHC9RiUNaZ4(wdnxasbd8AHA4SldgaKV(P8n9dM2IMjd()), f1W6FHbd7vG95LlqcMGV(P8n9dM2IMjd())));
					goto IL_061f;
					IL_072b:
					action2 = this.Command;
					if (action2 == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					action2(j3bgDY9gV2i9bttJ1fiQ.H5B9RaqOZAE(P8n9dM2IMjd().nxj9gXTZkuo(), P8n9dM2IMjd().Price));
					num = 22;
					break;
					IL_04d7:
					ypqMIv9maFM0tRwF0xMh = BG09ddpAWBZ().Chart.DataProvider;
					num2 = 6;
					continue;
					IL_0458:
					ypqMIv9maFM0tRwF0xMh = BG09ddpAWBZ().Chart.DataProvider;
					num2 = 12;
					continue;
					IL_061f:
					h9mmQkbdXxmfXuA3QM78(P8n9dM2IMjd(), bFjy1e9gtcJMGbrnrT3H.None);
					P8n9dM2IMjd().AkR9gcsS1jK(0L);
					num2 = 11;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
					{
						num2 = 21;
					}
					continue;
				}
				break;
			}
		}
	}

	public void Lgk9dcnlQpm()
	{
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = BG09ddpAWBZ().Chart.DataProvider;
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
		int num;
		int? offset = default(int?);
		if (TPt9dtRB6wx == (FrFpU89dyE3xMtDTrecP)2)
		{
			TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
			coPfjK9hF3ASs5TbM8OK.jPs9wJ1xvmD(0L);
			num = 4;
		}
		else
		{
			offset = ((Symbol)jZJHAqbduoDO0pHuCQ3s(coPfjK9hF3ASs5TbM8OK.XlV9wd4ELTW())).GetOffset(Settings.TradeSettings.StopLossOffset, ((dyykKj9sS7wbwJvEPZ4K)rCyxpxbdzlfmG7SI6JJI(Settings)).StopLossPercentOffset, GuTfZqbg0PYLwOPnOQ8t(ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9()), Settings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
			{
				num = 5;
			}
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				BG09ddpAWBZ().KLn9ppXIgKi();
				return;
			case 2:
				rDo51qbdpMnGcVhE54k5(BG09ddpAWBZ(), true);
				break;
			case 4:
			{
				vu59dUXnTw8 = "";
				int num2 = 3;
				num = num2;
				continue;
			}
			case 5:
				coPfjK9hF3ASs5TbM8OK.Dy59wYpU9Vv(ypqMIv9maFM0tRwF0xMh, 0L, offset, out text);
				if (coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
				{
					coPfjK9hF3ASs5TbM8OK.jPs9wJ1xvmD(gC067Ybg2Kne3Ejsy6ga(BG09ddpAWBZ()));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 1;
			case 6:
				vu59dUXnTw8 = text;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num = 0;
				}
				continue;
			default:
				if (coPfjK9hF3ASs5TbM8OK.d919wPySHGR() != 0L)
				{
					dJDT5DbdOjCVRjZxDIdL(BG09ddpAWBZ(), Cursors.SizeNS);
					num = 2;
					continue;
				}
				break;
			}
			TPt9dtRB6wx = (FrFpU89dyE3xMtDTrecP)2;
			num = 6;
		}
	}

	public void dFb9djUXKuY()
	{
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = (ypqMIv9maFM0tRwF0xMh)GIyarkbQ7tKOkdFlOaJi(BG09ddpAWBZ().Chart);
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
		int num;
		int? offset = default(int?);
		if (TPt9dtRB6wx == (FrFpU89dyE3xMtDTrecP)3)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
			{
				num = 0;
			}
		}
		else
		{
			offset = ((UserPosition)leux14bdTlS4SxHSEmvh(coPfjK9hF3ASs5TbM8OK)).Symbol.GetOffset(Settings.TradeSettings.TakeProfitOffset, Settings.TradeSettings.TakeProfitPercentOffset, ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9().LastPrice, ((dyykKj9sS7wbwJvEPZ4K)rCyxpxbdzlfmG7SI6JJI(Settings)).OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
			num = 7;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
			{
				num = 3;
			}
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				dJDT5DbdOjCVRjZxDIdL(BG09ddpAWBZ(), Cursors.SizeNS);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
				{
					num = 6;
				}
				break;
			case 1:
				TPt9dtRB6wx = FrFpU89dyE3xMtDTrecP.None;
				coPfjK9hF3ASs5TbM8OK.RMg9wpA6CUj(0L);
				num = 3;
				break;
			case 7:
				coPfjK9hF3ASs5TbM8OK.U1s9wNKsKAb(ypqMIv9maFM0tRwF0xMh, 0L, offset, out text);
				num = 2;
				break;
			case 2:
				if (T2etHQbdewuvuxQlsYql(coPfjK9hF3ASs5TbM8OK) == 0L)
				{
					goto case 4;
				}
				coPfjK9hF3ASs5TbM8OK.RMg9wpA6CUj(BG09ddpAWBZ().RCN9uTLq7a2());
				num = 5;
				break;
			case 3:
				vu59dUXnTw8 = "";
				num = 4;
				break;
			case 6:
				BG09ddpAWBZ().hFu9zU8KWXY(_0020: true);
				goto IL_01b3;
			case 4:
				zPChU3bgHlbPdJEYTuNq(BG09ddpAWBZ());
				return;
			case 5:
				{
					if (XQWbBUbdqw6vEWCiKd7t(coPfjK9hF3ASs5TbM8OK) != 0L)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
						{
							num = 0;
						}
						break;
					}
					goto IL_01b3;
				}
				IL_01b3:
				TPt9dtRB6wx = (FrFpU89dyE3xMtDTrecP)3;
				vu59dUXnTw8 = text;
				goto case 4;
			}
		}
	}

	private bool iWD9dEmwOP5(long P_0, out double P_1)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		double freeMargin = default(double);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				if (!JLFqEJGJYiHaSdoROJXI.UAtGJlwm3mG((Symbol)IyOvBybg94X8FB039Em8(BG09ddpAWBZ()), BG09ddpAWBZ().MarketSettings.ExecuteInQuoteCurrency, WmFRVsbgf6FKpvROMJge(BG09ddpAWBZ().MarketSettings), num3, freeMargin, num4, P_0, out P_1, out var text))
				{
					if (!string.IsNullOrEmpty(text))
					{
						K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)B59BSebgGmqTFF6RqJp4(TigerTrade.Properties.Resources.ResourceManager, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F0CF9)), text, NotificationType.Error));
					}
					return false;
				}
				return true;
			}
			case 1:
				num4 = tsb9dQrymeo(BG09ddpAWBZ().MarketSettings.CurrentPreset, ((MarketSettings)e2OIgUbdW3Qk1Ygc8wj0(BG09ddpAWBZ())).ExecuteInQuoteCurrency, WmFRVsbgf6FKpvROMJge(BG09ddpAWBZ().MarketSettings));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			Account account = DataManager.GetAccount(((MarketSettings)e2OIgUbdW3Qk1Ygc8wj0(BG09ddpAWBZ())).Account);
			num3 = TQIkSrbgnfKLkBZoRcEr(account?.ConnectionID, IyOvBybg94X8FB039Em8(BG09ddpAWBZ()));
			freeMargin = DataManager.GetFreeMargin(account?.ConnectionID, (Symbol)IyOvBybg94X8FB039Em8(BG09ddpAWBZ()));
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
			{
				num2 = 2;
			}
		}
	}

	[CompilerGenerated]
	internal static double tsb9dQrymeo(EpdvD7f3hWq8UlJ32f6V P_0, bool P_1, bool P_2)
	{
		if (P_2)
		{
			return P_0.PercentSize;
		}
		if (!P_1)
		{
			return P_0.Size;
		}
		return x8BkUubgYRvYW2uLn12w(P_0);
	}

	static liQnXV9dxGMvYlKyMGrI()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object WREIkFbQyWPEBEkid9OJ(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).Chart;
	}

	internal static bool buchh2bQUG016A0UFgRP()
	{
		return hitxDSbQtEDFbOup50w8 == null;
	}

	internal static liQnXV9dxGMvYlKyMGrI i2eDwlbQTkoYVgKlASLn()
	{
		return hitxDSbQtEDFbOup50w8;
	}

	internal static bool AmrG9DbQZsnQ0bnmZOE3(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).rhw9uznkSlZ();
	}

	internal static bool hCUGojbQV7JEeDxuHIPg(object P_0, object P_1)
	{
		return ((UQpOEF95Pl27GeSpKZ6s)P_0).Check((KeyEventArgs)P_1);
	}

	internal static object VZH2vabQCyKtgw460b4t(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).OpZl98KAYgk();
	}

	internal static long WmPi9sbQrxV8cSobN6CA(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).AskPrice;
	}

	internal static int Mxtb2BbQKRFudN6KKoWJ(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
	}

	internal static bool w1yLn5bQmT5exXixSY14(double P_0)
	{
		return double.IsInfinity(P_0);
	}

	internal static void oKggK3bQhbUPYjNvkCay(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static object Io7s7dbQwQnZot4bq9tx(object P_0)
	{
		return ((PyYTjtHpHbZRtxYfvYWW)P_0).BuyLimit;
	}

	internal static object GIyarkbQ7tKOkdFlOaJi(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).DataProvider;
	}

	internal static long CrRFMDbQ870XWmMmFkBm(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).MOr9F63nWYw();
	}

	internal static object pVgZfybQAREfJyVaLFda(object P_0)
	{
		return ((PyYTjtHpHbZRtxYfvYWW)P_0).SellMarket;
	}

	internal static long lkO257bQPwW45huJeHdb(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).BidPrice;
	}

	internal static long PQjRkhbQJnK5bn5wSxRl(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).sZK9Ftv0iH4();
	}

	internal static object q3Z7d8bQFV6h7O0LTnyv(object P_0)
	{
		return ((PyYTjtHpHbZRtxYfvYWW)P_0).CancelBids;
	}

	internal static object DXI1ifbQ3bh2FbR1t97G()
	{
		return vspL39fH6Hd69qemUHrA.Chart;
	}

	internal static object XwruOBbQp9x8RtsY1tEk()
	{
		return j3bgDY9gV2i9bttJ1fiQ.CancelAsks();
	}

	internal static object eXyugQbQuKtEflZ3Xooh()
	{
		return j3bgDY9gV2i9bttJ1fiQ.TakeProfit();
	}

	internal static object uNurNZbQz4yoDdQlQRmZ(object P_0)
	{
		return ((PyYTjtHpHbZRtxYfvYWW)P_0).SetStopLoss;
	}

	internal static bool r8igZYbd0NS07r6GCWd9(object P_0)
	{
		return ((RoutedEventArgs)P_0).Handled;
	}

	internal static bool ajI2i9bd2K3hO0gyrTot(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).XXdnoI2riZU();
	}

	internal static object mO9Y3lbdHHS6rOxDDFOP(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).d73l9JpDb23;
	}

	internal static void TBJI7CbdfJYgKMD4qRgo(object P_0, long P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).jPs9wJ1xvmD(P_1);
	}

	internal static void YyOuwHbd9e3vN9I0BvTj(object P_0, long P_1)
	{
		((J3eOkQ9gxQ4xmbapBPJ3)P_0).Price = P_1;
	}

	internal static long a0vicnbdnVOvy7Cj4gkS(object P_0)
	{
		return ((ExitStrategyTarget)P_0).TakeProfitPrice;
	}

	internal static void XxXBhsbdGnESvqJ6ZU56(object P_0, long P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).RMg9wpA6CUj(P_1);
	}

	internal static object VK3stPbdYcNlSosrmnlX(object P_0, object P_1)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).p8w9wjM6R5l((string)P_1);
	}

	internal static long Y74rOWbdocRNuASkGIHY(object P_0)
	{
		return ((ExitStrategyTarget)P_0).StopLossPrice;
	}

	internal static Rect ushq5wbdvLdpfcmWYlQA(object P_0)
	{
		return ((H17eBN9drmrGxanUFRD0)P_0).Bdd9dJ8tdig();
	}

	internal static object MELq1LbdBlYlH5I0g2AI()
	{
		return Cursors.Hand;
	}

	internal static object DP55RTbdaOQ0IE7BneeH(long P_0)
	{
		return j3bgDY9gV2i9bttJ1fiQ.LWY9R26ocec(P_0);
	}

	internal static object bSc7I8bdikdC3MwmJbwk(long P_0)
	{
		return j3bgDY9gV2i9bttJ1fiQ.h7R9R9TcxFD(P_0);
	}

	internal static long pX0hJFbdlvifc34hv00j(object P_0)
	{
		return ((H17eBN9drmrGxanUFRD0)P_0).Price;
	}

	internal static object YpCk1jbd4JmCA2Ijq1Yq(object P_0)
	{
		return ((t4J54f97Q2MUX30RSwuQ)P_0).Position;
	}

	internal static void VF3NdJbdDuKCaRX7yKjx(object P_0, object P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).lmN9wikYIoZ((string)P_1);
	}

	internal static void E0ys6ebdboJ8i7rdtQiQ(object P_0, object P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).AIQ9wS1kwA3((string)P_1);
	}

	internal static object gtCIFTbdN9MPPwt1NQcZ(object P_0)
	{
		return ((H17eBN9drmrGxanUFRD0)P_0).FxO9gHeFsPi();
	}

	internal static Rect hm0q51bdkxWBFCedqsLP(object P_0)
	{
		return ((H17eBN9drmrGxanUFRD0)P_0).mF59d3YDffQ();
	}

	internal static Side QwIcsIbd1hCt4ciEWr3i(object P_0)
	{
		return ((H17eBN9drmrGxanUFRD0)P_0).Side;
	}

	internal static object YQEpMFbd5s3Wr6LhncdS(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).OphnocDJshi();
	}

	internal static void VVnqpZbdS63EvSBZo4U5(object P_0, long P_1)
	{
		((J3eOkQ9gxQ4xmbapBPJ3)P_0).Quantity = P_1;
	}

	internal static void iFsVjgbdxRo800ItQmsw(object P_0, Side P_1)
	{
		((J3eOkQ9gxQ4xmbapBPJ3)P_0).Side = P_1;
	}

	internal static long Oqijw0bdLQTSn1LA3kkM(object P_0)
	{
		return ((ExitStrategyTarget)P_0).StopLossTrailingRange;
	}

	internal static long T2etHQbdewuvuxQlsYql(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionSize;
	}

	internal static void UTqkUXbdsPs2RuqXbgwA(object P_0, long P_1)
	{
		((ExitStrategyTarget)P_0).StopLossTrailingRange = P_1;
	}

	internal static void h9mmQkbdXxmfXuA3QM78(object P_0, bFjy1e9gtcJMGbrnrT3H P_1)
	{
		((J3eOkQ9gxQ4xmbapBPJ3)P_0).Type = P_1;
	}

	internal static void q45GDubdclMSnsjRFXJk(object P_0, long P_1)
	{
		((ExitStrategyTarget)P_0).TakeProfitRange = P_1;
	}

	internal static void ihwUySbdj1wVYNJeP0uN(object P_0, bool P_1)
	{
		((ExitStrategyTarget)P_0).TakeProfitStopActive = P_1;
	}

	internal static void s5hYTFbdE5DKhvPSoPob(object P_0, long P_1)
	{
		((J3eOkQ9gxQ4xmbapBPJ3)P_0).AkR9gcsS1jK(P_1);
	}

	internal static long eTY8Y9bdQkSDq0A5BPde(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object MGlosGbddFruZQnKvwbC(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).lEVl9w6fCd9();
	}

	internal static int v3SEVAbdgXi1giEDZXok(object P_0)
	{
		return ((kjc7Gl9PIEfKaxcEBwuk)P_0).PriceScale;
	}

	internal static long PMymRPbdR0JIM9mggXY0(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).d919wPySHGR();
	}

	internal static object PtJcBDbd6oaiqMpMWZQB(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static void bWx9csbdMINbiC8Hkv4x(object P_0, long P_1)
	{
		((ExitStrategyTarget)P_0).StopLossPrice = P_1;
	}

	internal static void dJDT5DbdOjCVRjZxDIdL(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Cursor = (Cursor)P_1;
	}

	internal static long XQWbBUbdqw6vEWCiKd7t(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).mfq9w3ApRCG();
	}

	internal static bool nYSQi5bdI8ywlYMp66V6(long P_0, long P_1, long P_2, long P_3)
	{
		return hBbPvlfnGPAsNPHIOheE.grMfnvRcxNi(P_0, P_1, P_2, P_3);
	}

	internal static object e2OIgUbdW3Qk1Ygc8wj0(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).MarketSettings;
	}

	internal static object PWnP7Ubdt9DggPKXBQhc()
	{
		return TigerTrade.Chart.Properties.Resources.ErrorPlacingTpOnWrongSideTitle;
	}

	internal static object FqirmBbdUHh2LjjjP9d9(object P_0)
	{
		return ((xg2cjD9QE5jRw708Tc0u)P_0).ock9QykwWZF();
	}

	internal static object leux14bdTlS4SxHSEmvh(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).XlV9wd4ELTW();
	}

	internal static object zANDp1bdyX6sb9uQlt9u(object P_0)
	{
		return ((UserPosition)P_0).Strategy;
	}

	internal static object lXdy9QbdZw3KgDuSjMAb(object P_0, bool P_1)
	{
		return ((ExitStrategy)P_0).GetStrategySingleTarget(P_1);
	}

	internal static long ImQDgEbdVxtTtoYB5u8p(object P_0)
	{
		return ((kjc7Gl9PIEfKaxcEBwuk)P_0).AskPrice;
	}

	internal static MOWYtTHiJiOZMqTggitO m2Tka9bdCuGTiq2r9nri(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).OffsetsType;
	}

	internal static long aH0ZpgbdrZi6VC5ElNXL(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionPrice;
	}

	internal static object dTnQcJbdKdX6cKaoiG7B()
	{
		return TigerTrade.Chart.Properties.Resources.ErrorPlacingSlOnWrongSideTitle;
	}

	internal static object foQ1Sgbdm57ft7BF9Y78(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Symbol;
	}

	internal static double Hm3NlCbdhNjDSBthIYWw(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static bool TXleSKbdwrsJDMcHlg8H(object P_0)
	{
		return ((SymbolBase)P_0).IsDenomination;
	}

	internal static long f1W6FHbd7vG95LlqcMGV(object P_0)
	{
		return ((J3eOkQ9gxQ4xmbapBPJ3)P_0).Price;
	}

	internal static long wdnxasbd8AHA4SldgaKV(object P_0)
	{
		return ((J3eOkQ9gxQ4xmbapBPJ3)P_0).nxj9gXTZkuo();
	}

	internal static bool nZgDaybdA7UZjR6eoRVh(long P_0, long P_1, long P_2, long P_3)
	{
		return hBbPvlfnGPAsNPHIOheE.pkVfnoYHhyH(P_0, P_1, P_2, P_3);
	}

	internal static void eA5fLsbdPq9we9cK5dL1(object P_0, long P_1)
	{
		((ExitStrategyTarget)P_0).TakeProfitPrice = P_1;
	}

	internal static object KIr5kTbdJI4p1534hpAO()
	{
		return TigerTrade.Chart.Properties.Resources.ErrorPlacingSlOnWrongSideMessage;
	}

	internal static object laTIvjbdFuVJEVtooNk1()
	{
		return TigerTrade.Chart.Properties.Resources.ErrorPlacingTpOnWrongSideMessage;
	}

	internal static object JU6BR6bd33eeMPLtl07u(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).riG9uw4EYX4();
	}

	internal static void rDo51qbdpMnGcVhE54k5(object P_0, bool P_1)
	{
		((jjKtVJ9pUSOpdg38tqnP)P_0).hFu9zU8KWXY(P_1);
	}

	internal static object jZJHAqbduoDO0pHuCQ3s(object P_0)
	{
		return ((UserPosition)P_0).Symbol;
	}

	internal static object rCyxpxbdzlfmG7SI6JJI(object P_0)
	{
		return ((ChartSettings)P_0).TradeSettings;
	}

	internal static long GuTfZqbg0PYLwOPnOQ8t(object P_0)
	{
		return ((kjc7Gl9PIEfKaxcEBwuk)P_0).LastPrice;
	}

	internal static long gC067Ybg2Kne3Ejsy6ga(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).RCN9uTLq7a2();
	}

	internal static void zPChU3bgHlbPdJEYTuNq(object P_0)
	{
		((jjKtVJ9pUSOpdg38tqnP)P_0).KLn9ppXIgKi();
	}

	internal static bool WmFRVsbgf6FKpvROMJge(object P_0)
	{
		return ((MarketSettings)P_0).ExecuteInPercents;
	}

	internal static object IyOvBybg94X8FB039Em8(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).Symbol;
	}

	internal static double TQIkSrbgnfKLkBZoRcEr(object P_0, object P_1)
	{
		return DataManager.GetLeverage((string)P_0, (Symbol)P_1);
	}

	internal static object B59BSebgGmqTFF6RqJp4(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetString((string)P_1);
	}

	internal static double x8BkUubgYRvYW2uLn12w(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).QuoteSize;
	}
}
