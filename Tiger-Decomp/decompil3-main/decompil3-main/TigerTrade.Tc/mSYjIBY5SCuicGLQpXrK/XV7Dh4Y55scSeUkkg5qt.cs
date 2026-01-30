using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using a71ZFuG7YJso6BiY1tbu;
using B96ro0aXbiuAOf9Hoedx;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using k56rXOGpHcZIas56ia8y;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using tpDLBrGJAci5JWh2s4im;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace mSYjIBY5SCuicGLQpXrK;

internal sealed class XV7Dh4Y55scSeUkkg5qt : Yi88EJG7GEjfyLGpmx9j
{
	private readonly Dictionary<string, TrustAccount> If7Y5sm77RW;

	internal static XV7Dh4Y55scSeUkkg5qt zU73R3S4SFt1SafAbuIl;

	public XV7Dh4Y55scSeUkkg5qt(ConnectionInfo P_0)
	{
		cpYKj2S4enSmfdTPFjqd();
		If7Y5sm77RW = new Dictionary<string, TrustAccount>();
		base._002Ector(P_0);
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				P_0.AsyncOrders = true;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f != 0)
				{
					num = 0;
				}
				break;
			default:
				lbkFdVS4sDPnihDVovSw(P_0, true);
				return;
			}
		}
	}

	public override void GaTlY1SBHLM()
	{
		S1ZG7ryQ8hZ();
	}

	public void vCvY5x2RNiB(List<TrustAccount> P_0)
	{
		base.m3jlYd926hA.Clear();
		If7Y5sm77RW.Clear();
		foreach (TrustAccount item in P_0)
		{
			if (!If7Y5sm77RW.ContainsKey(item.ID))
			{
				If7Y5sm77RW.Add(item.ID, item);
			}
		}
		foreach (TrustAccount item2 in P_0)
		{
			base.m3jlYd926hA.uFqaExS6jk0(new Account(base.mWXlYwTb86e, item2.ID)
			{
				Name = item2.Name,
				Trust = true,
				TrustAccounts = item2.Accounts
			});
		}
		kAnG740aHeo();
	}

	public override void p2JlYeJO25d(g62JgfGp2rGReTRRFt16 P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				PhQG7PDqTaE(P_0);
				W7rURWS4XmMBNXsZhjCH(base.NGZlYyv6dJg.H2DaQVpJneq(P_0.Symbol), P_0);
				r3vY5e0hsKN((Symbol)Y3lMhlS4c8ywZwhrxK1T(P_0), P_0.LastPrice);
				return;
			case 1:
				RyHG7h5DyGt(P_0);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	public override SuSj0gaXkIlYcfCsT0qp KyslYhCu6Vs()
	{
		return new DimDvWaXDFRtadPuXugj();
	}

	public override void EL3lnODvZSu()
	{
		jryG7maKpTu();
	}

	private DateTime C5OY5L8QSOC(string P_0)
	{
		return STXDYDS4jFUgLi1GqcBR(P_0);
	}

	protected override void kpTlYz9YLrV(Order P_0)
	{
		P_0.TrustID = EP0VldS4EGv3qsC3TsKy().ToString();
		OrderType type = P_0.Type;
		int num;
		if ((uint)(type - 1) > 1u)
		{
			if ((uint)(type - 3) <= 1u)
			{
				num = 16;
				goto IL_0009;
			}
			goto IL_04b9;
		}
		P_0.OrderID = Order.GetLocalID();
		P_0.Time = C5OY5L8QSOC((string)yecgDFS4R6JUEl0UldtH(P_0.Symbol));
		int num2 = 3;
		goto IL_0005;
		IL_040c:
		num2 = 18;
		goto IL_0005;
		IL_0754:
		object obj;
		TrustAccount trustAccount = (TrustAccount)obj;
		num = 19;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 != 0)
		{
			num = 20;
		}
		goto IL_0009;
		IL_0005:
		num = num2;
		goto IL_0009;
		IL_0009:
		long askPrice = default(long);
		long num3 = default(long);
		Dictionary<string, decimal>.Enumerator enumerator = default(Dictionary<string, decimal>.Enumerator);
		Order order2 = default(Order);
		double num5 = default(double);
		UserPosition userPosition = default(UserPosition);
		Account account = default(Account);
		Security security = default(Security);
		while (true)
		{
			switch (num)
			{
			case 11:
			{
				tqaG7WXqTfP(P_0);
				Execution obj2 = new Execution((Symbol)VeNo6ZS46lHkN8nX25u2(P_0), P_0.Account)
				{
					ExecutionID = Execution.GetLocalID(),
					OrderID = P_0.OrderID,
					Time = C5OY5L8QSOC(P_0.Symbol.Exchange)
				};
				mjQ8T2S4Wrwce7ie6ksr(obj2, (P_0.Side == Side.Buy) ? askPrice : num3);
				PErQ3uS4t0hvXTqj1uu5(obj2, P_0.Quantity);
				obj2.Side = P_0.Side;
				Execution execution = obj2;
				vxaG7toNUft(execution);
				goto IL_04b9;
			}
			case 4:
				return;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, decimal> current = enumerator.Current;
						int num4 = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
						{
							num4 = 7;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
							case 4:
								DataManager.ClientPlaceOrder(order2);
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
								{
									num4 = 0;
								}
								continue;
							case 5:
								num5 = z49pgES4ZTrve1hZSq3I(VeNo6ZS46lHkN8nX25u2(P_0), P_0.Quantity) * (double)current.Value;
								if (!((decimal)P_0.Symbol.SizeStep == 1m))
								{
									num4 = 6;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 2;
							case 2:
								num5 = Math.Round(num5);
								goto case 6;
							case 3:
								if (userPosition.Size != 0L)
								{
									order2.Quantity = eCYHDBS4hR9RjsZPLgwQ(userPosition.Size);
									order2.Side = ((userPosition.Size > 0) ? Side.Sell : Side.Buy);
									num4 = 4;
									continue;
								}
								return;
							case 7:
								account = DataManager.GetAccount(current.Key);
								if (account != null)
								{
									num4 = 4;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
									{
										num4 = 5;
									}
									continue;
								}
								break;
							case 6:
							{
								Order order = new Order((Symbol)VeNo6ZS46lHkN8nX25u2(P_0), account, P_0.Options);
								BYYOC4S4CyHD61DE6OK9(order, P0uGFyS4VLkcRU4SMCgg(P_0));
								order.Type = P_0.Type;
								order.Price = ea8O3ZS4rS9oeg7oFGSd(P_0);
								order.StopPrice = ormaRrS4KySj9JwuxXMO(P_0);
								order.Quantity = P_0.Symbol.GetShortSize(num5);
								order.Side = P_0.Side;
								pIivBMS4mf9R0CHn49lr(order, P_0.Validity);
								order2 = order;
								if (!P_0.PosClose)
								{
									num4 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
									{
										num4 = 1;
									}
									continue;
								}
								userPosition = DataManager.GetUserPosition((Symbol)VeNo6ZS46lHkN8nX25u2(P_0), account);
								if (userPosition != null)
								{
									num4 = 3;
									continue;
								}
								return;
							}
							}
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 14:
				break;
			case 10:
				goto IL_0439;
			case 18:
				goto IL_0454;
			case 9:
				TCX9vwS4dvTjiKPeDeYA(P_0, P_0.Quantity);
				num = 2;
				continue;
			case 15:
				goto end_IL_0009;
			case 5:
			case 12:
			case 19:
				goto IL_04b9;
			case 6:
				askPrice = security.AskPrice;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
				{
					num = 7;
				}
				continue;
			case 17:
				num3 = ydVWreS4O7RehU3vgeSa(security);
				num = 6;
				continue;
			case 20:
				if (trustAccount == null)
				{
					return;
				}
				enumerator = trustAccount.Accounts.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
				{
					num = 1;
				}
				continue;
			case 21:
				tqaG7WXqTfP(P_0);
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
				{
					num = 5;
				}
				continue;
			default:
				FCLG7q7YoMK(P_0);
				num = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
				{
					num = 11;
				}
				continue;
			case 3:
				TCX9vwS4dvTjiKPeDeYA(P_0, P_0.Quantity);
				P_0.State = OrderState.Active;
				blUG7jW7Xo7(P_0);
				security = base.NGZlYyv6dJg.jemaQZBB4Zt((string)rgvWRDS4Mbvl3sKESZot(VeNo6ZS46lHkN8nX25u2(P_0)));
				if (security == null)
				{
					num = 8;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
					{
						num = 6;
					}
					continue;
				}
				goto case 17;
			case 2:
				cVru9hS4g8KkB3VrMZWJ(P_0, OrderState.Active);
				blUG7jW7Xo7(P_0);
				num = 21;
				continue;
			case 16:
				goto IL_0620;
			case 7:
				if (num3 <= 0 || askPrice <= 0)
				{
					tqaG7WXqTfP(P_0);
					num = 19;
					continue;
				}
				if (FCXm9BS4qhB7GLHGrkWU(P_0) != Side.Buy)
				{
					goto IL_0439;
				}
				goto case 13;
			case 8:
				tqaG7WXqTfP(P_0);
				goto IL_04b9;
			case 13:
				if (P_0.Price < askPrice && P_0.Type != OrderType.Market)
				{
					num = 10;
					continue;
				}
				goto IL_0454;
			}
			if (jplCcWS4IU4rhZZnB7pQ(P_0) == OrderType.Market)
			{
				goto IL_040c;
			}
			goto IL_068e;
			IL_0439:
			if (P_0.Side == Side.Sell)
			{
				if (P_0.Price > num3)
				{
					num = 14;
					continue;
				}
				goto IL_0454;
			}
			goto IL_068e;
			IL_068e:
			tqaG7WXqTfP(P_0);
			num = 12;
			continue;
			IL_0454:
			P_0.Filled = P_0.Quantity;
			P_0.Remaining = 0L;
			P_0.State = OrderState.Completed;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
			{
				num = 0;
			}
			continue;
			end_IL_0009:
			break;
		}
		obj = If7Y5sm77RW[((Account)oAdMoAS4ytB5qQMUgJCe(P_0)).UniqueID];
		goto IL_0754;
		IL_0620:
		P_0.OrderID = (string)H0xKX5S4Q0BXPN3Q9Fay();
		P_0.Time = C5OY5L8QSOC(P_0.Symbol.Exchange);
		num2 = 9;
		goto IL_0005;
		IL_04b9:
		if (A8MH81S4UDMJRD8g5jlu(P_0))
		{
			return;
		}
		if (If7Y5sm77RW.ContainsKey((string)ebdntgS4TyIIPNVYVb78(P_0.Account)))
		{
			num = 15;
			goto IL_0009;
		}
		obj = null;
		goto IL_0754;
	}

	protected override void jNJlo90jRN4(Order P_0)
	{
		OrderModifyParams modifyParams = P_0.ModifyParams;
		Order order = default(Order);
		int num;
		if (modifyParams != null)
		{
			P_0.ModifyParams = null;
			order = base.yuplYRm5htt.kJOaQoAYWmU(P_0.OrderID);
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				tqaG7WXqTfP(order);
				{
					foreach (Order order2 in DataManager.GetOrders(P_0.TrustID))
					{
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 != 0)
						{
							num2 = 0;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								order2.ModifyParams = new OrderModifyParams
								{
									Price = modifyParams.Price,
									StopPrice = modifyParams.StopPrice,
									Quantity = order2.Quantity
								};
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
								{
									num2 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
						DataManager.ClientModifyOrder(order2);
					}
					return;
				}
			default:
				if (order == null)
				{
					return;
				}
				order.Price = modifyParams.Price;
				order.StopPrice = modifyParams.StopPrice;
				num = 2;
				break;
			case 1:
				gFDG7RmFMv0(order);
				num = 4;
				break;
			case 2:
				order.Quantity = modifyParams.Quantity;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	protected override void DqPlo0ULSuU(Order P_0)
	{
		Order order = base.yuplYRm5htt.kJOaQoAYWmU((string)BwFH8AS4w7T0DF6HWyZE(P_0));
		if (order == null)
		{
			return;
		}
		int num;
		if (P_0.State != OrderState.Canceled)
		{
			cVru9hS4g8KkB3VrMZWJ(order, OrderState.Canceled);
			num = 3;
			goto IL_0009;
		}
		goto IL_011d;
		IL_0009:
		List<Order>.Enumerator enumerator = default(List<Order>.Enumerator);
		while (true)
		{
			switch (num)
			{
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						DataManager.ClientCancelOrder(enumerator.Current);
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 2:
				break;
			case 3:
				goto IL_012c;
			case 1:
				return;
			}
			break;
			IL_012c:
			MKrG7Mt4yCE(order);
			num = 2;
		}
		goto IL_011d;
		IL_011d:
		tqaG7WXqTfP(order);
		enumerator = DataManager.GetOrders(P_0.TrustID).GetEnumerator();
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	protected override void SetLeverage(Symbol symbol, string accountID, double leverage)
	{
		int num = 3;
		int num2 = num;
		Account account2 = default(Account);
		Dictionary<string, decimal>.Enumerator enumerator = default(Dictionary<string, decimal>.Enumerator);
		Account account = default(Account);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				account2 = base.m3jlYd926hA.N07aELTPF6E(accountID);
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (account2 == null)
				{
					num2 = 4;
					continue;
				}
				if (!If7Y5sm77RW.ContainsKey(account2.UniqueID))
				{
					obj = null;
					break;
				}
				goto case 1;
			case 1:
				obj = If7Y5sm77RW[account2.UniqueID];
				break;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
							{
								num3 = 0;
							}
							goto IL_00fd;
						}
						goto IL_0143;
						IL_0143:
						account = DataManager.GetAccount(enumerator.Current.Key);
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
						{
							num3 = 2;
						}
						goto IL_00fd;
						IL_00fd:
						switch (num3)
						{
						default:
							return;
						case 2:
							break;
						case 1:
							goto IL_0143;
						case 0:
							return;
						}
						if (account != null)
						{
							DataManager.ClientUpdateUserPosition(UserPositionData.SetLeverage(account.ConnectionID, symbol.ID, (string)QjSlskS47EPfKXo3wPrb(account), leverage));
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 4:
				return;
			}
			TrustAccount trustAccount = (TrustAccount)obj;
			if (trustAccount == null)
			{
				break;
			}
			enumerator = trustAccount.Accounts.GetEnumerator();
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
			{
				num2 = 0;
			}
		}
	}

	private void r3vY5e0hsKN(Symbol P_0, long? P_1)
	{
		foreach (Order item in base.yuplYRm5htt.VlLaQixssUY(OrderGroup.All, P_0.ID))
		{
			if (item.Symbol.ID != P_0.ID || !P_1.HasValue || P_1 == 0)
			{
				continue;
			}
			long value = P_1.Value;
			switch (item.Type)
			{
			case OrderType.Market:
			case OrderType.Limit:
				if (item.Type == OrderType.Market || (item.Side == Side.Buy && value < item.Price) || (item.Side == Side.Sell && value > item.Price))
				{
					RnKG823YqLt(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1311293279 ^ -1311372985), item.Price, value));
					item.Filled = item.Quantity;
					item.Remaining = 0L;
					item.State = OrderState.Completed;
					FCLG7q7YoMK(item);
					tqaG7WXqTfP(item);
					long price = ((item.Type == OrderType.Market) ? value : item.Price);
					Execution execution = new Execution(item.Symbol, item.Account)
					{
						ExecutionID = Execution.GetLocalID(),
						OrderID = item.OrderID,
						Time = C5OY5L8QSOC(item.Symbol.Exchange),
						Price = price,
						Quantity = item.Quantity,
						Side = item.Side
					};
					vxaG7toNUft(execution);
				}
				break;
			case OrderType.Stop:
			case OrderType.StopLimit:
				if ((item.Side == Side.Buy && item.StopPrice <= value) || (item.Side == Side.Sell && item.StopPrice >= value))
				{
					RnKG823YqLt(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x16AD7E76 ^ 0x16AC3440), item.StopPrice, value));
					item.Filled = item.Quantity;
					item.Remaining = 0L;
					item.State = OrderState.Completed;
					FCLG7q7YoMK(item);
					tqaG7WXqTfP(item);
					Order order = new Order(item.Symbol, item.Account)
					{
						TrustExclude = true,
						Type = ((item.Type != OrderType.StopLimit) ? OrderType.Market : OrderType.Limit),
						Price = ((item.Type == OrderType.StopLimit) ? item.Price : 0),
						Quantity = item.Quantity,
						Side = item.Side
					};
					order.PlaceInitiator = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1606927328 ^ -1606846802);
					rXVlY5KWTqS(order);
				}
				break;
			}
		}
	}

	static XV7Dh4Y55scSeUkkg5qt()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void cpYKj2S4enSmfdTPFjqd()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void lbkFdVS4sDPnihDVovSw(object P_0, bool value)
	{
		((ConnectionInfo)P_0).IsConnected = value;
	}

	internal static bool iuQZwqS4xQMn8fb0hqsV()
	{
		return zU73R3S4SFt1SafAbuIl == null;
	}

	internal static XV7Dh4Y55scSeUkkg5qt kOevALS4LC1f2oA8SdtS()
	{
		return zU73R3S4SFt1SafAbuIl;
	}

	internal static void W7rURWS4XmMBNXsZhjCH(object P_0, object P_1)
	{
		((Security)P_0).Apply((g62JgfGp2rGReTRRFt16)P_1);
	}

	internal static object Y3lMhlS4c8ywZwhrxK1T(object P_0)
	{
		return ((anI4lfGJ8TTwhTlujQ36)P_0).Symbol;
	}

	internal static DateTime STXDYDS4jFUgLi1GqcBR(object P_0)
	{
		return TimeHelper.GetCurrTime((string)P_0);
	}

	internal static Guid EP0VldS4EGv3qsC3TsKy()
	{
		return Guid.NewGuid();
	}

	internal static object H0xKX5S4Q0BXPN3Q9Fay()
	{
		return Order.GetLocalID();
	}

	internal static void TCX9vwS4dvTjiKPeDeYA(object P_0, long value)
	{
		((Order)P_0).Remaining = value;
	}

	internal static void cVru9hS4g8KkB3VrMZWJ(object P_0, OrderState value)
	{
		((Order)P_0).State = value;
	}

	internal static object yecgDFS4R6JUEl0UldtH(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static object VeNo6ZS46lHkN8nX25u2(object P_0)
	{
		return ((Order)P_0).Symbol;
	}

	internal static object rgvWRDS4Mbvl3sKESZot(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static long ydVWreS4O7RehU3vgeSa(object P_0)
	{
		return ((Security)P_0).BidPrice;
	}

	internal static Side FCXm9BS4qhB7GLHGrkWU(object P_0)
	{
		return ((Order)P_0).Side;
	}

	internal static OrderType jplCcWS4IU4rhZZnB7pQ(object P_0)
	{
		return ((Order)P_0).Type;
	}

	internal static void mjQ8T2S4Wrwce7ie6ksr(object P_0, long value)
	{
		((Execution)P_0).Price = value;
	}

	internal static void PErQ3uS4t0hvXTqj1uu5(object P_0, long value)
	{
		((Execution)P_0).Quantity = value;
	}

	internal static bool A8MH81S4UDMJRD8g5jlu(object P_0)
	{
		return ((Order)P_0).TrustExclude;
	}

	internal static object ebdntgS4TyIIPNVYVb78(object P_0)
	{
		return ((Account)P_0).UniqueID;
	}

	internal static object oAdMoAS4ytB5qQMUgJCe(object P_0)
	{
		return ((Order)P_0).Account;
	}

	internal static double z49pgES4ZTrve1hZSq3I(object P_0, long size)
	{
		return ((SymbolBase)P_0).GetRealSize(size);
	}

	internal static object P0uGFyS4VLkcRU4SMCgg(object P_0)
	{
		return ((Order)P_0).TrustID;
	}

	internal static void BYYOC4S4CyHD61DE6OK9(object P_0, object P_1)
	{
		((Order)P_0).TrustID = (string)P_1;
	}

	internal static long ea8O3ZS4rS9oeg7oFGSd(object P_0)
	{
		return ((Order)P_0).Price;
	}

	internal static long ormaRrS4KySj9JwuxXMO(object P_0)
	{
		return ((Order)P_0).StopPrice;
	}

	internal static void pIivBMS4mf9R0CHn49lr(object P_0, OrderValidity value)
	{
		((Order)P_0).Validity = value;
	}

	internal static long eCYHDBS4hR9RjsZPLgwQ(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object BwFH8AS4w7T0DF6HWyZE(object P_0)
	{
		return ((Order)P_0).OrderID;
	}

	internal static object QjSlskS47EPfKXo3wPrb(object P_0)
	{
		return ((Account)P_0).AccountID;
	}
}
