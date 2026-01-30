using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using a71ZFuG7YJso6BiY1tbu;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using blUbhuYGrP1RZFCOGcw1;
using com.omnesys.rapi;
using D9oCu3aEgyKPNPKmY7V8;
using fprdaNaEWFuJeq2YEWyX;
using HpAYZ9advvCBqIuQqJM1;
using HUGROmaQL20CgL29Z5vy;
using jhuDCPG8d8bbdl4R91vn;
using jltmuhYY9F0mxXoQpVPj;
using jM4nKvYnJKRGaEl5dyvw;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using lfS1HaYYGmD3vcwK69uf;
using LPq3llG3QX4HMCBL7b1Q;
using OWhORdGzgDWLWxLpUFfx;
using R73uqWYnuNemEnvgLjdO;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc;
using TigerTrade.Tc.Collections;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.Tc.Properties;
using U0vBVyGFnRQg4TAEWduY;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;
using zJnmCrGAyrNEB66VU5ww;

namespace tdgDeHYniL2NMaWMYeO7;

internal sealed class K69fi4YnakxkH7CaMjfp : Yi88EJG7GEjfyLGpmx9j
{
	private pTUY25YGCEN5dn8fwd3g mGAYnm1teR4;

	private REngine kwhYnhsEAg1;

	private readonly sAsj96YYnyvHZcfgQGdV CB3YnwuNiPQ;

	private readonly object A3KYn7Om0wQ;

	private readonly DateTime rMoYn8jCsg4;

	private int HFtYnAGFHGN;

	internal static K69fi4YnakxkH7CaMjfp r46c49S9oN6ro82fIaCA;

	public override gpnr5oG8Q1cRMmiYT0Ut LSslYPBx4Vu => mGAYnm1teR4;

	public K69fi4YnakxkH7CaMjfp(ConnectionInfo P_0)
	{
		iYnZNfS9af2AysaEoALc();
		A3KYn7Om0wQ = new object();
		base._002Ector(P_0);
		CB3YnwuNiPQ = new sAsj96YYnyvHZcfgQGdV(this);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				rMoYn8jCsg4 = new DateTime(1970, 1, 1);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void GaTlY1SBHLM()
	{
		mGAYnm1teR4 = IrtG73OXImc<pTUY25YGCEN5dn8fwd3g>() ?? new pTUY25YGCEN5dn8fwd3g();
		mGAYnm1teR4.EeqG8RA1RNB(delegate
		{
			o0rG7pUoSyh(mGAYnm1teR4);
		});
		try
		{
			using List<string>.Enumerator enumerator = SymbolManager.GetCodes(base.mWXlYwTb86e.TradeClientID).GetEnumerator();
			string text = default(string);
			string current = default(string);
			string text2 = default(string);
			string[] array = default(string[]);
			Symbol symbol = default(Symbol);
			while (true)
			{
				IL_00c1:
				int num;
				if (!enumerator.MoveNext())
				{
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
					{
						num = 4;
					}
					goto IL_008b;
				}
				goto IL_0157;
				IL_00a9:
				text = current;
				text2 = "";
				array = (string[])LR1O3oS9lqoP6Ma7YaoU(current, new char[1] { '@' });
				num = 3;
				goto IL_008b;
				IL_008b:
				while (true)
				{
					switch (num)
					{
					case 2:
						break;
					case 3:
						goto IL_00b2;
					case 1:
						goto IL_0107;
					default:
						goto IL_0157;
					case 4:
						goto end_IL_00c1;
					}
					break;
					IL_0107:
					text2 = array[1];
					goto IL_0165;
					IL_00b2:
					if (array.Length == 2)
					{
						text = array[0];
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
						{
							num = 1;
						}
						continue;
					}
					goto IL_0165;
					IL_0165:
					dHFhAOaEIWwWtAWXjMZE dHFhAOaEIWwWtAWXjMZE = base.B5jlYEmv1MN;
					Rybo1XGzd9ch5SOUQC2H obj = new Rybo1XGzd9ch5SOUQC2H(symbol, current)
					{
						Code = text
					};
					tN1XBvS94lUmHRlelwjt(obj, text2);
					dHFhAOaEIWwWtAWXjMZE.kihaEtiwr0b(obj);
					goto IL_00c1;
				}
				goto IL_00a9;
				IL_0157:
				current = enumerator.Current;
				symbol = SymbolManager.Get((string)ktkfc3S9iEGsGeD7EsR0(base.mWXlYwTb86e), current);
				if (symbol == null)
				{
					continue;
				}
				goto IL_00a9;
				continue;
				end_IL_00c1:
				break;
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
		while (z5afoJS9DyMs4ba5E7vf(base.mWXlYwTb86e) && !DataManager.Player)
		{
			int num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
			{
				num2 = 1;
			}
			switch (num2)
			{
			case 1:
				lihlfMp6ULY();
				return;
			}
		}
	}

	public override void lihlfMp6ULY()
	{
		S1ZG7ryQ8hZ();
		try
		{
			if (mGAYnm1teR4.MP2YGKyEckI() != null && !M4iTWKS9bNA21t16smqE(mGAYnm1teR4.Login))
			{
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					case 2:
						ThreadPool.QueueUserWorkItem(bwYYnleAnjK);
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
						{
							num = 0;
						}
						continue;
					}
					if (string.IsNullOrEmpty(mGAYnm1teR4.Password))
					{
						break;
					}
					HFtYnAGFHGN = 0;
					num = 2;
				}
			}
			PghG7iHrixD(Resources.CommonInvalidConnectionSettings, _0020: true);
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	private void bwYYnleAnjK(object P_0)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Expected O, but got Unknown
		object a3KYn7Om0wQ = A3KYn7Om0wQ;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(a3KYn7Om0wQ, ref lockTaken);
			try
			{
				REngine obj = kwhYnhsEAg1;
				int num;
				if (obj == null)
				{
					num = 2;
					goto IL_0047;
				}
				obj.shutdown();
				goto IL_01d4;
				IL_0047:
				REngineParams val = default(REngineParams);
				zqUHQqYnpwFsIpgX42kQ zqUHQqYnpwFsIpgX42kQ = default(zqUHQqYnpwFsIpgX42kQ);
				while (true)
				{
					switch (num)
					{
					default:
						kwhYnhsEAg1 = new REngine(val);
						kwhYnhsEAg1.login((RCallbacks)(object)CB3YnwuNiPQ, mGAYnm1teR4.Login, mGAYnm1teR4.Password, zqUHQqYnpwFsIpgX42kQ.AfUYGxNsbFv(), mGAYnm1teR4.Login, mGAYnm1teR4.Password, (string)FgO51GS9Q9gjBBWi5jNw(zqUHQqYnpwFsIpgX42kQ), zqUHQqYnpwFsIpgX42kQ.DkQYGdlnMhn(), mGAYnm1teR4.Login, mGAYnm1teR4.Password, (string)RBSPxgS9dWaWWdCw2QN4(zqUHQqYnpwFsIpgX42kQ));
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
						{
							num = 1;
						}
						continue;
					case 2:
						break;
					case 1:
						return;
					}
					break;
				}
				goto IL_01d4;
				IL_01d4:
				zqUHQqYnpwFsIpgX42kQ = (zqUHQqYnpwFsIpgX42kQ)NwATlmS9kQKJtncxZ0cZ(mGAYnm1teR4);
				if (zqUHQqYnpwFsIpgX42kQ == null)
				{
					return;
				}
				REngineParams val2 = new REngineParams();
				Lp7NEpS95R1Z5hfCGkQ6((object)val2, YgDWJIS91a9MGs6EcP7L(zqUHQqYnpwFsIpgX42kQ));
				val2.DmnSrvrAddr = (string)hernEuS9SEKYmfahkxL1(zqUHQqYnpwFsIpgX42kQ);
				OijrxkS9xCFNodwwMMiF((object)val2, zqUHQqYnpwFsIpgX42kQ.DRxYGBrersK());
				val2.LicSrvrAddr = zqUHQqYnpwFsIpgX42kQ.jtMYGl7rs9S();
				val2.LocBrokAddr = zqUHQqYnpwFsIpgX42kQ.XMGYGbN6mRF();
				vMKeVvS9euP4SwKgNrn1((object)val2, mo6Kc8S9LFx9lZi8Q9ZT(zqUHQqYnpwFsIpgX42kQ));
				val2.AppName = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2017337494 ^ -2017402962);
				KCKUH7S9smeBcDS60TFi((object)val2, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-3429745 ^ -3495341));
				l6SEo9S9jwPxE5Y6ULL7((object)val2, S1U64XS9cI5Q9vWfmnQm(base.mWXlYwTb86e.LogsPath, fDDyKhS9XKss1Bok8Pmy(0x42D899B5 ^ 0x42D99945)));
				TCBEHAS9EM6qEr1b6f08((object)val2, new KhIWmfYYfTNws3u1BNlL());
				val = val2;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
				{
					num = 0;
				}
				goto IL_0047;
			}
			catch (Exception ex)
			{
				rvrlofnZLRT(ex);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(a3KYn7Om0wQ);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
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
	}

	public override void Disconnect()
	{
		try
		{
			GfbQeFS9gCuqVtdIO3vj(new WaitCallback(bLBYn4WkgaG));
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	private void bLBYn4WkgaG(object P_0)
	{
		lock (A3KYn7Om0wQ)
		{
			try
			{
				REngine obj = kwhYnhsEAg1;
				if (obj == null)
				{
					int num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
				}
				else
				{
					obj.shutdown();
				}
				kwhYnhsEAg1 = null;
			}
			catch (Exception ex)
			{
				v8PKsUS9NmejH4FInD2K(this, ex);
			}
		}
	}

	public override void Dispose()
	{
		Disconnect();
		base.Dispose();
	}

	internal void GQ8YnD0DtIT(AlertInfo P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected I4, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			AlertType alertType = P_0.AlertType;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 3:
					switch ((int)alertType)
					{
					default:
						return;
					case 4:
						HFtYnAGFHGN |= 1 << (int)P_0.ConnectionId;
						if ((HFtYnAGFHGN & 0x1E) == 30)
						{
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
							{
								num = 0;
							}
							goto end_IL_0017;
						}
						return;
					case 2:
					case 3:
					case 7:
					case 11:
						break;
					case 0:
					case 1:
					case 5:
					case 6:
					case 8:
					case 9:
					case 10:
						return;
					}
					goto case 2;
				case 2:
					HFtYnAGFHGN &= ~(1 << (int)P_0.ConnectionId);
					Disconnected(P_0.ConnectionId);
					return;
				case 1:
					Connected();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
					end_IL_0017:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	private void Connected()
	{
		KUrG7BdwhR9();
		RQUG7vyrcDN();
	}

	private void Disconnected(ConnectionId connectionId)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		if ((int)connectionId == 1)
		{
			base.NGZlYyv6dJg.Clear();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			TnYlYCCpDAI().Clear();
		}
		EqNG7aAq9LC();
	}

	protected override void I4DloH9Jfxr(Symbol P_0)
	{
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (kwhYnhsEAg1 == null)
			{
				return;
			}
			SubscriptionFlags val = default(SubscriptionFlags);
			while (true)
			{
				Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = base.B5jlYEmv1MN.LPiaEyKvEyx(P_0);
				if (rybo1XGzd9ch5SOUQC2H == null)
				{
					break;
				}
				int num = 11;
				while (true)
				{
					switch (num)
					{
					case 10:
						return;
					case 4:
						try
						{
							kwhYnhsEAg1.subscribe(rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l(), (string)Gvj66oS9OGxQy1YxLpZ7(rybo1XGzd9ch5SOUQC2H), val, (object)P_0);
							return;
						}
						catch (Exception ex)
						{
							rvrlofnZLRT(ex);
							return;
						}
					default:
						val = (SubscriptionFlags)(val | 1);
						num = 6;
						continue;
					case 12:
						if (UsKPmiS9R6CZ36QcUK19(P_0))
						{
							val = (SubscriptionFlags)(val | 4);
							val = (SubscriptionFlags)(val | 0x40);
							int num2 = 3;
							num = num2;
						}
						else
						{
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
							{
								num = 2;
							}
						}
						continue;
					case 1:
						val = (SubscriptionFlags)(val | 0x200);
						val = (SubscriptionFlags)(val | 1);
						goto case 6;
					case 7:
						if (I03291S9M0BJUYGET7Uf(P_0))
						{
							try
							{
								cTbESDS9qBERVOIXl65r(kwhYnhsEAg1, rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l(), Gvj66oS9OGxQy1YxLpZ7(rybo1XGzd9ch5SOUQC2H), rybo1XGzd9ch5SOUQC2H.Symbol);
							}
							catch (Exception ex3)
							{
								rvrlofnZLRT(ex3);
							}
						}
						num = 4;
						continue;
					case 3:
						val = (SubscriptionFlags)(val | 0x100);
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
						{
							num = 8;
						}
						continue;
					case 11:
						try
						{
							kwhYnhsEAg1.unsubscribe(rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l(), rybo1XGzd9ch5SOUQC2H.Code);
						}
						catch (Exception ex2)
						{
							rvrlofnZLRT(ex2);
						}
						val = (SubscriptionFlags)0;
						num = 12;
						continue;
					case 8:
						val = (SubscriptionFlags)(val | 0x1000);
						val = (SubscriptionFlags)(val | 0x20);
						val = (SubscriptionFlags)(val | 8);
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 != 0)
						{
							num = 0;
						}
						continue;
					case 2:
					case 5:
						if (xstjoWS96iYrWjlDASYF(P_0))
						{
							num = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 6;
					case 6:
						if (AFoGv5GAT4PeYBusSBbk.aqRGAKboHm4(P_0))
						{
							val = (SubscriptionFlags)(val | 2);
						}
						if ((int)val == 0)
						{
							num = 10;
							continue;
						}
						goto case 7;
					case 9:
						break;
					}
					break;
				}
			}
		}
		catch (Exception ex4)
		{
			rvrlofnZLRT(ex4);
		}
	}

	public void LdGYnblqFQU(AccountListInfo P_0)
	{
		try
		{
			IEnumerator<AccountInfo> enumerator = P_0.Accounts.GetEnumerator();
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
			{
				num = 1;
			}
			AccountInfo current = default(AccountInfo);
			Portfolio portfolio = default(Portfolio);
			Account account = default(Account);
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num2;
							if (!vRbDfSS9V7gi9uoYqmGt(enumerator))
							{
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 != 0)
								{
									num2 = 0;
								}
								goto IL_00bd;
							}
							goto IL_02f7;
							IL_00bd:
							while (true)
							{
								switch (num2)
								{
								case 0:
									break;
								case 2:
									goto IL_0105;
								case 3:
									try
									{
										kwhYnhsEAg1.replayPnl(current, (object)portfolio);
									}
									catch (Exception ex3)
									{
										rvrlofnZLRT(ex3);
									}
									try
									{
										kwhYnhsEAg1.subscribePnl(current);
									}
									catch (Exception ex4)
									{
										v8PKsUS9NmejH4FInD2K(this, ex4);
									}
									goto case 4;
								case 5:
									BSlL5ZS9UVhe18BCZPZ9(PK9lYTkx6L9(), portfolio);
									goto IL_02db;
								case 8:
									portfolio.Currency = current.RmsInfo.Currency;
									goto IL_022d;
								case 4:
									try
									{
										fH1Zl6S9yvLtQh81QOAc(kwhYnhsEAg1, current);
									}
									catch (Exception ex)
									{
										v8PKsUS9NmejH4FInD2K(this, ex);
									}
									try
									{
										kwhYnhsEAg1.replayAllOrders(current, 0, 0, (object)account);
									}
									catch (Exception ex2)
									{
										rvrlofnZLRT(ex2);
									}
									num2 = 2;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
									{
										num2 = 0;
									}
									continue;
								case 1:
									goto IL_02f7;
								case 7:
									account = new Account(base.mWXlYwTb86e, current.AccountId)
									{
										Name = current.AccountId,
										FcmId = current.FcmId,
										IbId = (string)lCSK9jS9IUARGkZ3UVSS(current)
									};
									base.m3jlYd926hA.uFqaExS6jk0(account);
									portfolio = PK9lYTkx6L9().z74aQsYheGu(current.AccountId);
									if (portfolio != null)
									{
										goto IL_02db;
									}
									goto case 6;
								case 6:
									{
										Portfolio portfolio2 = new Portfolio(base.mWXlYwTb86e, (string)K1dB3iS9W1hDjAR4FsHQ(current));
										q1nSFsS9tsEcEsf3xuIV(portfolio2, current.AccountId);
										portfolio = portfolio2;
										num2 = 5;
										continue;
									}
									IL_02db:
									if (TtGkKlS9TXplh7IAVLoX(current) != null)
									{
										num2 = 8;
										continue;
									}
									goto IL_022d;
									IL_022d:
									kynG7Ciqp0T(portfolio);
									num2 = 3;
									continue;
								}
								break;
							}
							break;
							IL_0105:
							try
							{
								i9txMXS9ZGlJgKjbNGrL(kwhYnhsEAg1, current, 0, 0, account);
							}
							catch (Exception ex5)
							{
								v8PKsUS9NmejH4FInD2K(this, ex5);
							}
							continue;
							IL_02f7:
							current = enumerator.Current;
							num2 = 7;
							goto IL_00bd;
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					try
					{
						U2oCQDS9CA3Psnk9AoEJ(kwhYnhsEAg1, null);
					}
					catch (Exception ex6)
					{
						rvrlofnZLRT(ex6);
					}
					kAnG740aHeo();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
		catch (Exception ex7)
		{
			v8PKsUS9NmejH4FInD2K(this, ex7);
		}
	}

	public void HZfYnN9CwLD(TradeRouteListInfo P_0)
	{
		try
		{
			Account current2 = default(Account);
			List<Account>.Enumerator enumerator2;
			foreach (TradeRouteInfo tradeRoute in P_0.TradeRoutes)
			{
				enumerator2 = base.m3jlYd926hA.H4saEsREVA4().GetEnumerator();
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					try
					{
						while (true)
						{
							IL_0217:
							int num2;
							if (!enumerator2.MoveNext())
							{
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
								{
									num2 = 0;
								}
							}
							else
							{
								current2 = enumerator2.Current;
								if (!(current2.FcmId == tradeRoute.FcmId) || !(current2.IbId == tradeRoute.IbId) || current2.TradeRoutes.ContainsKey(tradeRoute.Exchange))
								{
									continue;
								}
								num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
								{
									num2 = 1;
								}
							}
							while (true)
							{
								switch (num2)
								{
								default:
									goto end_IL_01cd;
								case 1:
									current2.TradeRoutes.Add(tradeRoute.Exchange, tradeRoute.TradeRoute);
									num2 = 2;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
									{
										num2 = 0;
									}
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_01cd;
								}
								goto IL_0217;
								continue;
								end_IL_01cd:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
					}
					break;
				}
			}
			enumerator2 = base.m3jlYd926hA.H4saEsREVA4().GetEnumerator();
			int num3 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			}
			try
			{
				Dictionary<string, string>.Enumerator enumerator3 = default(Dictionary<string, string>.Enumerator);
				while (enumerator2.MoveNext())
				{
					Account current3 = enumerator2.Current;
					int num4 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							enumerator3 = current3.TradeRoutes.GetEnumerator();
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
							{
								num4 = 0;
							}
							continue;
						}
						break;
					}
					try
					{
						while (enumerator3.MoveNext())
						{
							KeyValuePair<string, string> current4 = enumerator3.Current;
							RnKG823YqLt((string)WxL8ysS9rTJ70YFZWUjf(new string[5]
							{
								current3.Name,
								F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894925136),
								current4.Key,
								F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1799510641 ^ -1799551789),
								current4.Value
							}));
						}
						int num5 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	private Security OdUYnkIRKO7(Symbol P_0)
	{
		try
		{
			if (P_0 == null)
			{
				return null;
			}
			while (true)
			{
				Security security = (Security)j1AbNsS9KrFCFffM7NP7(base.NGZlYyv6dJg, P_0.ID);
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 2:
						if (security == null)
						{
							goto IL_003e;
						}
						return security;
					default:
						goto IL_003e;
					case 1:
						break;
					case 3:
						return security;
					}
					break;
					IL_003e:
					security = new Security(P_0);
					NPJrtoS9mMfhVqbOU2fD(base.NGZlYyv6dJg, security);
					num = 3;
				}
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
			{
				num2 = 0;
			}
			return num2 switch
			{
				_ => null, 
			};
		}
	}

	public void HtlYn1yyuf3(BidInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			if (security == null)
			{
				return;
			}
			while (true)
			{
				security.BidPrice = security.Symbol.GetShortPrice(mIB6ZvS9hJd2KbLdAwFg(P_0));
				security.BidSize = PchSomS9wGjf5P8XS8AY(P_0);
				security.BidTime = KibYnrNOQol(P_0.Ssboe, P_0.Usecs, (Symbol)GfFOPfS97gGU44J6qm5c(security));
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 2:
						pnqG75MeHXY(security.GetEvent((Symbol)GfFOPfS97gGU44J6qm5c(security)));
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
						{
							num = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	public void vjZYn5OExmB(AskInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(Cm0xFMS98Pyr54h8rPbr(P_0) as Symbol);
			if (security == null)
			{
				return;
			}
			while (true)
			{
				security.AskPrice = cZtfI9S9Aes4c683idvn(security.Symbol, P_0.Price);
				security.AskSize = P_0.Size;
				security.AskTime = KibYnrNOQol(VJdmQhS9PymfLWfGSXG6(P_0), NyMr8mS9JJVAx1xldwwg(P_0), security.Symbol);
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						pnqG75MeHXY((SecurityEvent)QYgco5S9FywVprfVQENF(security, GfFOPfS97gGU44J6qm5c(security)));
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void hPIYnSUP6r3(BidInfo P_0, AskInfo P_1)
	{
		try
		{
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					TGPODdS9z9sDbVKXkODf(security, VZETO9S9uS5cJslIqxAe(P_1));
					security.AskTime = KibYnrNOQol(VJdmQhS9PymfLWfGSXG6(P_1), NyMr8mS9JJVAx1xldwwg(P_1), security.Symbol);
					pnqG75MeHXY((SecurityEvent)QYgco5S9FywVprfVQENF(security, GfFOPfS97gGU44J6qm5c(security)));
					num = 3;
					continue;
				case 2:
					security.AskPrice = ((Symbol)GfFOPfS97gGU44J6qm5c(security)).GetShortPrice(P_1.Price);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
					{
						num = 1;
					}
					continue;
				case 3:
					return;
				}
				if (security != null)
				{
					kdKX1TS93p8v8dni0T0N(security, security.Symbol.GetShortPrice(P_0.Price));
					security.BidSize = P_0.Size;
					security.BidTime = KibYnrNOQol(OUdrpQS9pLwhmNwAMXq4(P_0), P_0.Usecs, security.Symbol);
					num = 2;
					continue;
				}
				return;
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void JNUYnxaPJnc(OpenPriceInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(cWWreRSn0WaFmPfKAOZq(P_0) as Symbol);
			if (security != null)
			{
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				case 1:
					QoXDEXSnHrIqu1t3UWQo(security, Oj3P4VSn2hYcHsitbxnA(P_0));
					pnqG75MeHXY(security.GetEvent(security.Symbol));
					break;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void LibYnLUrKXC(HighPriceInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			if (security == null)
			{
				return;
			}
			while (true)
			{
				security.HighPrice = P_0.Price;
				pnqG75MeHXY(security.GetEvent((Symbol)GfFOPfS97gGU44J6qm5c(security)));
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void wf7YneLTlA3(LowPriceInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			if (security == null)
			{
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					return;
				}
			}
			OnX1HeSnfu37wRq7ORvd(security, P_0.Price);
			pnqG75MeHXY((SecurityEvent)QYgco5S9FywVprfVQENF(security, security.Symbol));
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void gu8YnsOr7M9(ClosePriceInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (security != null)
					{
						security.ClosePrice = P_0.Price;
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
						{
							num = 0;
						}
						break;
					}
					return;
				default:
					pnqG75MeHXY((SecurityEvent)QYgco5S9FywVprfVQENF(security, security.Symbol));
					return;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void FgPYnXwTOnI(SettlementPriceInfo P_0)
	{
		try
		{
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					if (security == null)
					{
						return;
					}
					security.ClosePrice = P_0.Price;
					pnqG75MeHXY((SecurityEvent)QYgco5S9FywVprfVQENF(security, security.Symbol));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void qbNYncxNVSr(TradeVolumeInfo P_0)
	{
		try
		{
			if (!P_0.TotalVolumeFlag)
			{
				return;
			}
			Security security = OdUYnkIRKO7(P_0.Context as Symbol);
			int num;
			if (security == null)
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
				{
					num = 2;
				}
				goto IL_0015;
			}
			goto IL_008d;
			IL_008d:
			security.Volume = P_0.TotalVolume;
			pnqG75MeHXY((SecurityEvent)QYgco5S9FywVprfVQENF(security, security.Symbol));
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
			{
				num = 0;
			}
			goto IL_0015;
			IL_0015:
			switch (num)
			{
			default:
				return;
			case 2:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			goto IL_008d;
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	public void go4YnjCK4ZB(OpenInterestInfo P_0)
	{
		try
		{
			if (!P_0.QuantityFlag)
			{
				return;
			}
			while (true)
			{
				Security security = OdUYnkIRKO7(P_0.Context as Symbol);
				if (security == null)
				{
					break;
				}
				X44O3FSn9Z75CO3RXMny(security, P_0.Quantity);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						break;
					default:
						pnqG75MeHXY(security.GetEvent(security.Symbol));
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
						{
							num = 0;
						}
						continue;
					case 1:
						return;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void lkBYnEnPYFm(OrderBookInfo P_0)
	{
		try
		{
			Symbol symbol = EAn1fhSnnIf194imeRl7(P_0) as Symbol;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
			{
				num = 0;
			}
			MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					oyZG7Sb34Ly(marketDepthFullEvent);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a != 0)
					{
						num = 0;
					}
					break;
				default:
					if (symbol == null)
					{
						return;
					}
					marketDepthFullEvent = (MarketDepthFullEvent)ytSBVSSnG94H8R0a0VIN(symbol);
					marketDepthFullEvent.Version.vNpG3X8YCxF();
					num = 3;
					break;
				case 3:
				{
					IEnumerator<AskInfo> enumerator = P_0.Asks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							AskInfo current = enumerator.Current;
							int num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							}
							marketDepthFullEvent.AcdlolmAx8M(symbol.GetShortPrice(T3OLfOSnYtVpIAjPt30d(current)), current.Size);
						}
					}
					finally
					{
						if (enumerator != null)
						{
							enumerator.Dispose();
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
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
					using (IEnumerator<BidInfo> enumerator2 = P_0.Bids.GetEnumerator())
					{
						while (vRbDfSS9V7gi9uoYqmGt(enumerator2))
						{
							BidInfo current2 = enumerator2.Current;
							marketDepthFullEvent.YlHloi6rCYj(cZtfI9S9Aes4c683idvn(symbol, mIB6ZvS9hJd2KbLdAwFg(current2)), current2.Size);
						}
					}
					goto case 2;
				}
				}
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	public void jZ2YnQT9w9B(AskInfo P_0)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between Unknown and I4
		try
		{
			Symbol symbol = Cm0xFMS98Pyr54h8rPbr(P_0) as Symbol;
			int num;
			MarketDepth marketDepth = default(MarketDepth);
			if (symbol == null)
			{
				num = 3;
			}
			else
			{
				marketDepth = (MarketDepth)j4DHhbSnofm9STr1GjmQ(TnYlYCCpDAI(), symbol);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
				{
					num = 1;
				}
			}
			long shortPrice = default(long);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if ((int)P_0.UpdateType == 1 || (int)vEvXIvSnveDA88NXDPG1(P_0) == 4)
					{
						oyZG7Sb34Ly(marketDepth.GetEvent(symbol));
						num = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
						{
							num = 0;
						}
						break;
					}
					return;
				case 5:
					marketDepth.Asks[shortPrice] = P_0.Size;
					goto case 2;
				default:
					shortPrice = symbol.GetShortPrice(P_0.Price);
					if (P_0.Size <= 0)
					{
						if (marketDepth.Asks.ContainsKey(shortPrice))
						{
							num = 4;
							break;
						}
						goto case 2;
					}
					num2 = 6;
					goto IL_0013;
				case 3:
					return;
				case 6:
					if (!marketDepth.Asks.ContainsKey(shortPrice))
					{
						marketDepth.Add(shortPrice, VZETO9S9uS5cJslIqxAe(P_0), Side.Sell);
						num = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
						{
							num = 1;
						}
						break;
					}
					num2 = 5;
					goto IL_0013;
				case 4:
					marketDepth.Asks.Remove(shortPrice);
					goto case 2;
				case 1:
					if (marketDepth != null)
					{
						goto default;
					}
					return;
				case 7:
					return;
					IL_0013:
					num = num2;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void pspYnd3YoTj(BidInfo P_0)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Invalid comparison between Unknown and I4
		try
		{
			if (!(P_0.Context is Symbol symbol))
			{
				return;
			}
			MarketDepth marketDepth = (MarketDepth)j4DHhbSnofm9STr1GjmQ(TnYlYCCpDAI(), symbol);
			long shortPrice = default(long);
			int num;
			if (marketDepth != null)
			{
				shortPrice = symbol.GetShortPrice(P_0.Price);
				num = 3;
			}
			else
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (marketDepth.Bids.ContainsKey(shortPrice))
					{
						num = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 != 0)
						{
							num = 7;
						}
						break;
					}
					goto case 5;
				case 4:
					return;
				case 7:
					marketDepth.Bids.Remove(shortPrice);
					goto case 5;
				case 6:
					marketDepth.Bids[shortPrice] = P_0.Size;
					goto case 5;
				case 3:
					if (P_0.Size <= 0)
					{
						goto default;
					}
					if (!marketDepth.Bids.ContainsKey(shortPrice))
					{
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
						{
							num = 1;
						}
						break;
					}
					goto case 6;
				case 5:
					if ((int)P_0.UpdateType == 1 || (int)pmTWbiSnBI1v7KKTSqLD(P_0) == 4)
					{
						oyZG7Sb34Ly(marketDepth.GetEvent(symbol));
						num = 2;
						break;
					}
					return;
				case 1:
					marketDepth.Add(shortPrice, P_0.Size, Side.Buy);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
					{
						num = 5;
					}
					break;
				case 2:
					return;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void njVYnguAuyu(TradeInfo P_0)
	{
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		try
		{
			Symbol symbol = rHkulxSnaH3O8velBn7J(P_0) as Symbol;
			int num = 4;
			TickEvent tickEvent = default(TickEvent);
			Security security = default(Security);
			while (true)
			{
				switch (num)
				{
				case 2:
					pC5QpASn49mSsJwnsKQU(tickEvent, P_0.Size);
					tickEvent.Side = ((!MhjRR0SnbNhgNEJwUjTy(P9pN5uSnDW79YIDLtY60(P_0), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F00689))) ? Side.Sell : Side.Buy);
					num = 8;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
					{
						num = 5;
					}
					break;
				case 5:
					iNTJZkSnNpEtBVkMH6jB(security, P_0.Size);
					security.LastTime = cJrPalSnk3HSjWvw5Dhr(tickEvent);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num = 0;
					}
					break;
				case 4:
					if (symbol == null)
					{
						return;
					}
					tickEvent = IlvHiXGF9pA6U4gUK5bq.yxVGF4IeGkY(symbol);
					num = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
					{
						num = 6;
					}
					break;
				case 3:
					FWmNWsSn5YX18X2IiYVk(tickEvent, Ed9sELSn19L9WRLSRZlE(security));
					SmkfmNSnx7nahy3Ol92L(tickEvent, GVZld4SnSbPocDIDnqVx(security));
					num = 7;
					break;
				case 8:
					tickEvent.Market = symbol.Exchange;
					if ((int)P_0.CallbackType != 3)
					{
						security = OdUYnkIRKO7(symbol);
						if (security != null)
						{
							security.LastPrice = ((Symbol)GfFOPfS97gGU44J6qm5c(security)).GetShortPrice(ElALQRSniH3F7Je4hG6A(P_0));
							num = 5;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
							{
								num = 5;
							}
							break;
						}
						return;
					}
					return;
				case 6:
					tickEvent.Time = KibYnrNOQol(P_0.Ssboe, P_0.Usecs, symbol);
					ifJSkgSnlGWOMvK33OBE(tickEvent, symbol.GetShortPrice(ElALQRSniH3F7Je4hG6A(P_0)));
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num = 1;
					}
					break;
				case 1:
					d8DG7LdJncL(tickEvent);
					return;
				default:
					pnqG75MeHXY(security.GetEvent(symbol));
					tickEvent.Bid = security.BidPrice;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num = 3;
					}
					break;
				case 7:
					tickEvent.AskSize = security.AskSize;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void trgYnRS5GhQ(TradeReplayInfo P_0)
	{
		try
		{
			_ = dqjxXTSnLGg28VJY22fV(P_0) is Symbol;
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void aYoYn6Udosl(OrderReplayInfo P_0)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				jGhYnMGTgud(P_0.Orders[num3]);
				num3--;
				goto default;
			case 1:
				num3 = P_0.Orders.Count - 1;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 < 0)
				{
					return;
				}
				goto case 2;
			}
		}
	}

	public void jGhYnMGTgud(LineInfo P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			IPTQ5wSneNMjBGDAnClf(P_0, stringBuilder);
			RnKG823YqLt(stringBuilder.ToString());
			if (P_0.Status == null)
			{
				return;
			}
			bool flag = default(bool);
			Order order2 = default(Order);
			Symbol symbol = default(Symbol);
			Account account = default(Account);
			while (true)
			{
				IL_069f:
				Order order = base.yuplYRm5htt.kJOaQoAYWmU(P_0.OrderNum);
				if (order != null)
				{
					goto IL_06d7;
				}
				int num = 3;
				goto IL_0011;
				IL_02db:
				flag = false;
				if (order2 != null)
				{
					num = 16;
					goto IL_0011;
				}
				goto IL_028f;
				IL_0011:
				while (true)
				{
					switch (num)
					{
					case 13:
						GZ8R4nSn61vpSHRqRgk1(order2, OrderType.Market);
						goto IL_033d;
					case 8:
						if (!((string)Mu3xIaSnRG8PSsMUU2eR(P_0) == Constants.ORDER_TYPE_STOP_MARKET))
						{
							if (P_0.OrderType == Constants.ORDER_TYPE_STOP_LIMIT)
							{
								order2.Type = OrderType.StopLimit;
								nmLMhsSnO0kCfNXJ6YeR(order2, cZtfI9S9Aes4c683idvn(order2.Symbol, P_0.PriceToFill));
								num = 24;
								continue;
							}
						}
						else
						{
							GZ8R4nSn61vpSHRqRgk1(order2, OrderType.Stop);
							order2.StopPrice = ((Symbol)uvc0u5SnMQKoeakZ65R1(order2)).GetShortPrice(P_0.TriggerPrice);
						}
						goto IL_033d;
					case 12:
						if (!flag)
						{
							num = 22;
							continue;
						}
						goto case 11;
					case 20:
						order2 = new Order(symbol, account);
						flag = true;
						num = 10;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 != 0)
						{
							num = 2;
						}
						continue;
					case 28:
						order2.Quantity = gCUlNBSnESSrrm83MtHJ(P_0);
						num = 19;
						continue;
					case 11:
					case 18:
					case 26:
					case 29:
						tqaG7WXqTfP(order2);
						return;
					case 5:
						return;
					case 7:
						order2.State = OrderState.Rejected;
						num = 26;
						continue;
					case 23:
						if (Eh0ZbcSnUqKYZqllOk0U(order2) != OrderState.Completed)
						{
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 11;
					case 2:
						break;
					case 9:
					case 27:
						goto IL_02db;
					default:
						if (symbol != null && account != null)
						{
							goto case 20;
						}
						return;
					case 19:
						goto IL_032a;
					case 22:
						FCLG7q7YoMK(order2);
						goto case 11;
					case 25:
						goto IL_0381;
					case 14:
						if (!(P_0.Status == Constants.LINE_STATUS_MODIFIED))
						{
							if (!MhjRR0SnbNhgNEJwUjTy(D2J7rOSnI3DJ12drnHwM(P_0), Constants.LINE_STATUS_COMPLETE))
							{
								goto case 11;
							}
							if (MhjRR0SnbNhgNEJwUjTy(d2ZGetSntINFQDO6NucH(P_0), Constants.COMPLETION_REASON_FILL))
							{
								num = 23;
								continue;
							}
							goto case 32;
						}
						num = 21;
						continue;
					case 30:
						gYUADpSnWjlHI9G5OWtH(order2, OrderState.Canceled);
						goto case 11;
					case 15:
						order2.Time = KibYnrNOQol(pyjuErSncY4tWy1OIDrI(P_0), P_0.Usecs, order2.Symbol);
						order2.Side = ((!((string)gtMnjeSnj2kFPCc82QnE(P_0) == Constants.BUY_SELL_TYPE_BUY)) ? Side.Sell : Side.Buy);
						num = 28;
						continue;
					case 21:
						gYUADpSnWjlHI9G5OWtH(order2, OrderState.Active);
						num = 29;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
						{
							num = 6;
						}
						continue;
					case 1:
						goto IL_0564;
					case 17:
						if (!((string)d2ZGetSntINFQDO6NucH(P_0) == Constants.COMPLETION_REASON_CANCEL))
						{
							if ((string)d2ZGetSntINFQDO6NucH(P_0) == Constants.COMPLETION_REASON_PFBC)
							{
								goto case 30;
							}
							order2.State = OrderState.None;
							num = 11;
							continue;
						}
						num = 30;
						continue;
					case 6:
						goto IL_05a6;
					case 24:
						order2.StopPrice = order2.Symbol.GetShortPrice(seWwFJSnqfQGTJyu0hZH(P_0));
						goto IL_033d;
					case 10:
					case 16:
						order2.OrderID = (string)QhqukPSnXTejg9cAChB9(P_0);
						num = 15;
						continue;
					case 32:
						if (P_0.CompletionReason == Constants.COMPLETION_REASON_REJECT)
						{
							goto case 7;
						}
						if (P_0.CompletionReason == Constants.COMPLETION_REASON_FAILURE)
						{
							num = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
							{
								num = 7;
							}
							continue;
						}
						goto case 17;
					case 31:
						goto IL_069f;
					case 3:
						goto IL_06c6;
					case 4:
						{
							order2.AvgFillPrice = ((!ePDEpeSng3N103Zq8m25(NtrysJSndP3Fs0FlI4hG(P_0))) ? new double?(P_0.AvgFillPrice) : ((double?)null));
							if ((string)Mu3xIaSnRG8PSsMUU2eR(P_0) == Constants.ORDER_TYPE_MARKET)
							{
								num = 13;
								continue;
							}
							if (!MhjRR0SnbNhgNEJwUjTy(P_0.OrderType, Constants.ORDER_TYPE_LIMIT))
							{
								goto case 8;
							}
							GZ8R4nSn61vpSHRqRgk1(order2, OrderType.Limit);
							nmLMhsSnO0kCfNXJ6YeR(order2, cZtfI9S9Aes4c683idvn(uvc0u5SnMQKoeakZ65R1(order2), P_0.PriceToFill));
							goto IL_033d;
						}
						IL_033d:
						if (P_0.Status == Constants.LINE_STATUS_OPEN_PENDING)
						{
							order2.State = OrderState.Wait;
							num = 8;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
							{
								num = 18;
							}
							continue;
						}
						if ((string)D2J7rOSnI3DJ12drnHwM(P_0) == Constants.LINE_STATUS_OPEN || P_0.Status == Constants.LINE_STATUS_TRIGGER_PENDING)
						{
							goto case 21;
						}
						num = 14;
						continue;
					}
					break;
				}
				goto IL_028f;
				IL_06c6:
				order = HjcG8sgZFrT.DGKadD52Epx(P_0.Tag);
				goto IL_06d7;
				IL_06d7:
				order2 = order;
				int num2;
				if (order2 == null)
				{
					num2 = 25;
					goto IL_000d;
				}
				object value = order2.OrderID;
				goto IL_06e5;
				IL_028f:
				symbol = SymbolManager.Get(base.mWXlYwTb86e.TradeClientID, P_0.Symbol, (string)BVSM1dSnsVLkbJD8curS(P_0));
				account = base.m3jlYd926hA.eTHaEeINcUH(P_0.Account.AccountId);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
				{
					num = 0;
				}
				goto IL_0011;
				IL_032a:
				order2.Filled = P_0.Filled;
				GvpLxeSnQHEemDg2QiMr(order2, order2.Quantity - order2.Filled);
				order2.DisplayQty = P_0.MaxShowQty;
				num2 = 4;
				goto IL_000d;
				IL_0564:
				gYUADpSnWjlHI9G5OWtH(order2, OrderState.Completed);
				num2 = 12;
				goto IL_000d;
				IL_0381:
				value = null;
				goto IL_06e5;
				IL_06e5:
				if (string.IsNullOrEmpty((string)value))
				{
					num = 27;
					goto IL_0011;
				}
				goto IL_05a6;
				IL_000d:
				num = num2;
				goto IL_0011;
				IL_05a6:
				if (order2.OrderID != P_0.OrderNum)
				{
					order2 = null;
					num = 9;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
					{
						num = 7;
					}
					goto IL_0011;
				}
				goto IL_02db;
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void ax9YnOGYAvI(OrderStatusReport P_0)
	{
		try
		{
			Order order = base.yuplYRm5htt.kJOaQoAYWmU((string)S50FqESnTZMoKM0VJ1N1(P_0)) ?? HjcG8sgZFrT.DGKadD52Epx((string)f1mk0eSnyGpu8p8AM9Wp(P_0));
			if (order != null)
			{
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				blUG7jW7Xo7(order);
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	public void KSHYnqIln8Y(OrderFailureReport P_0)
	{
		try
		{
			Order order = (Order)(eC8ZoFSnZIDVPqvWYiXN(base.yuplYRm5htt, ((OrderReport)P_0).OrderNum) ?? YKYTrcSnVgFfZT2cx53r(HjcG8sgZFrT, ((OrderReport)P_0).Tag));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (order == null)
					{
						return;
					}
					OmCG7gXTrkt(order, (string)IfanRLSnClXYCIrffrEq(P_0));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	public void ltEYnITyR1J(OrderRejectReport P_0)
	{
		try
		{
			Order order = (Order)(eC8ZoFSnZIDVPqvWYiXN(base.yuplYRm5htt, ((OrderReport)P_0).OrderNum) ?? HjcG8sgZFrT.DGKadD52Epx((string)f1mk0eSnyGpu8p8AM9Wp(P_0)));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
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
				if (order != null)
				{
					OmCG7gXTrkt(order, (string)IfanRLSnClXYCIrffrEq(P_0));
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num = 0;
					}
					continue;
				}
				return;
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void njLYnWgYtM2(OrderCancelReport P_0)
	{
		try
		{
			Order order = base.yuplYRm5htt.kJOaQoAYWmU(((OrderReport)P_0).OrderNum) ?? HjcG8sgZFrT.DGKadD52Epx((string)f1mk0eSnyGpu8p8AM9Wp(P_0));
			int num;
			if (order == null)
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 != 0)
				{
					num = 1;
				}
			}
			else
			{
				MKrG7Mt4yCE(order);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void qGhYnty6Hxm(OrderNotCancelledReport P_0)
	{
		try
		{
			object obj = eC8ZoFSnZIDVPqvWYiXN(base.yuplYRm5htt, ((OrderReport)P_0).OrderNum);
			int num;
			if (obj == null)
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
				{
					num = 0;
				}
				goto IL_0037;
			}
			goto IL_0098;
			IL_0037:
			switch (num)
			{
			case 1:
				return;
			}
			obj = YKYTrcSnVgFfZT2cx53r(HjcG8sgZFrT, ((OrderReport)P_0).Tag);
			goto IL_0098;
			IL_0098:
			Order order = (Order)obj;
			if (order != null)
			{
				yP4G7OAAy8s(order, ((OrderReport)P_0).Text);
				return;
			}
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
			{
				num = 1;
			}
			goto IL_0037;
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void gcIYnUc0U3E(OrderModifyReport P_0)
	{
		try
		{
			Order order = base.yuplYRm5htt.kJOaQoAYWmU((string)S50FqESnTZMoKM0VJ1N1(P_0)) ?? HjcG8sgZFrT.DGKadD52Epx(((OrderReport)P_0).Tag);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (order != null)
					{
						gFDG7RmFMv0(order);
						return;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void cbBYnTKEwre(OrderNotModifiedReport P_0)
	{
		try
		{
			Order order = (Order)(eC8ZoFSnZIDVPqvWYiXN(base.yuplYRm5htt, ((OrderReport)P_0).OrderNum) ?? YKYTrcSnVgFfZT2cx53r(HjcG8sgZFrT, f1mk0eSnyGpu8p8AM9Wp(P_0)));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				if (order == null)
				{
					return;
				}
				break;
			case 1:
				break;
			}
			t3AG7647LuV(order, ((OrderReport)P_0).Text);
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	public void c21YnyZiaar(ExecutionReplayInfo P_0)
	{
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = P_0.Executions.Count - 1;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (num3 < 0)
			{
				return;
			}
			xh8YnZYuI85(P_0.Executions[num3]);
			num3--;
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
			{
				num2 = 0;
			}
		}
	}

	public void xh8YnZYuI85(OrderFillReport P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			((OrderReport)P_0).Dump(stringBuilder);
			int num = 8;
			Account account = default(Account);
			Execution execution = default(Execution);
			Symbol symbol = default(Symbol);
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 9:
					RnKG823YqLt(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416921015) + ((OrderReport)P_0).ReportType);
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num = 0;
					}
					break;
				case 7:
					RnKG823YqLt((string)fDDyKhS9XKss1Bok8Pmy(-1325234765 ^ -1325168877));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num = 0;
					}
					break;
				case 2:
					if (!MbvYW0SnrR5KjABZThCO(((OrderReport)P_0).ReportType, Constants.REPORT_TYPE_FILL))
					{
						num = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
						{
							num = 6;
						}
						break;
					}
					goto IL_00a7;
				case 1:
					if (account == null)
					{
						num = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
						{
							num = 2;
						}
						break;
					}
					execution = new Execution(symbol, account)
					{
						ExecutionID = (string)dDEYukSnhlBGXMFsl8XJ(P_0),
						OrderID = ((OrderReport)P_0).OrderNum,
						Price = symbol.GetShortPrice(((OrderReport)P_0).FillPrice),
						Quantity = ((OrderReport)P_0).FillSize,
						Time = KibYnrNOQol(((OrderReport)P_0).Ssboe, ((OrderReport)P_0).Usecs, symbol),
						Side = ((!((string)uAidv9SnwuHiKJGnX1Rl(P_0) == Constants.BUY_SELL_TYPE_BUY)) ? Side.Sell : Side.Buy)
					};
					num = 5;
					break;
				case 4:
					if (symbol == null)
					{
						goto case 7;
					}
					goto case 1;
				case 6:
					if (MhjRR0SnbNhgNEJwUjTy(((OrderReport)P_0).ReportId, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-690510723 ^ -690576075)))
					{
						goto IL_00a7;
					}
					RnKG823YqLt(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x86EFEF6 ^ 0x86FFF68) + base.mWXlYwTb86e.TradeClientID + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2017337494 ^ -2017403210) + ((OrderReport)P_0).Symbol + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416920929) + (string)XAT99wSnKhA642YaZwjc(P_0) + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-342738082 ^ -342726288));
					symbol = SymbolManager.Get(base.mWXlYwTb86e.TradeClientID, ((OrderReport)P_0).Symbol, (string)XAT99wSnKhA642YaZwjc(P_0));
					if (symbol == null)
					{
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
						{
							num = 2;
						}
						break;
					}
					goto IL_010b;
				case 3:
					RnKG823YqLt(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5CD4F15 ^ 0x5CC4EF7));
					goto IL_010b;
				case 5:
					vxaG7toNUft(execution);
					return;
				case 8:
					{
						RnKG823YqLt(stringBuilder.ToString());
						num = 9;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
						{
							num = 1;
						}
						break;
					}
					IL_00a7:
					RnKG823YqLt(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1192989954 ^ -1192924244));
					return;
					IL_010b:
					RnKG823YqLt((string)IJ7uCISnmCR19E7guXxy(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x20B584D2 ^ 0x20B486F2), ((OrderReport)P_0).Account.AccountId, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-690510723 ^ -690489773)));
					account = base.m3jlYd926hA.eTHaEeINcUH(((OrderReport)P_0).Account.AccountId);
					if (account == null)
					{
						RnKG823YqLt((string)fDDyKhS9XKss1Bok8Pmy(0x2BD86B18 ^ 0x2BD96978));
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
						{
							num = 4;
						}
						break;
					}
					goto case 4;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	public void GQ0YnVWbfa3(PnlReplayInfo P_0)
	{
		foreach (PnlInfo pnlInfo in P_0.PnlInfoList)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			IGkYnCswPOT(pnlInfo);
		}
	}

	public void IGkYnCswPOT(PnlInfo P_0)
	{
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Portfolio portfolio = PK9lYTkx6L9().z74aQsYheGu(P_0.Account.AccountId);
			int num;
			if (portfolio != null)
			{
				if (string.IsNullOrEmpty(P_0.Symbol))
				{
					goto IL_0791;
				}
				num = 31;
			}
			else
			{
				num = 26;
			}
			goto IL_0022;
			IL_0186:
			Ignorable<double> val = P_0.MarginBalance;
			num = 8;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
			{
				num = 1;
			}
			goto IL_0022;
			IL_076c:
			VCVkIJSn7x6m6ntLAqTK(portfolio, P_0.AccountBalance.Value);
			goto IL_0186;
			IL_0285:
			val = P_0.AccountBalance;
			if (val.Clear)
			{
				num = 22;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
				{
					num = 1;
				}
				goto IL_0022;
			}
			goto IL_0186;
			IL_0022:
			Position position = default(Position);
			Symbol symbol = default(Symbol);
			Account account = default(Account);
			string text = default(string);
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 10:
					if (!val.Use)
					{
						goto case 30;
					}
					portfolio.UnrealizedPnl = P_0.OpenPnl.Value;
					goto IL_029e;
				case 1:
					break;
				case 15:
					nKIJyYSnPfVZclltgN9k(position, 0L);
					goto IL_0755;
				case 4:
				case 24:
					val = P_0.ClosedPnl;
					num = 25;
					continue;
				case 34:
					val = P_0.ClosedPnl;
					num = 20;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
					{
						num = 10;
					}
					continue;
				case 25:
					if (val.Clear)
					{
						position.RealizedPnl = 0.0;
					}
					goto case 19;
				case 31:
				case 35:
					if (!M4iTWKS9bNA21t16smqE(P_0.Symbol) && !M4iTWKS9bNA21t16smqE(P_0.Exchange))
					{
						symbol = SymbolManager.Get(base.mWXlYwTb86e.TradeClientID, (string)fxOZD8Sn8ssmvrTkuEyv(P_0), P_0.Exchange);
						account = (Account)HjQBseSnAUKR4ecAlB7I(base.m3jlYd926hA, K1dB3iS9W1hDjAR4FsHQ(P_0.Account));
						num = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 != 0)
						{
							num = 2;
						}
						continue;
					}
					return;
				case 27:
					goto IL_0285;
				case 32:
					if (val.Clear)
					{
						num = 12;
						continue;
					}
					goto case 3;
				case 29:
					position = base.FxalYqgjyul.Cn7aQg7hGId(text);
					if (position == null)
					{
						position = new Position(symbol, account, text);
						base.FxalYqgjyul.yXJaQdI5IEf(position);
						num = 5;
						continue;
					}
					goto case 5;
				case 21:
				{
					Position position3 = position;
					val = P_0.OpenPnl;
					position3.UnrealizedPnl = val.Value;
					num = 34;
					continue;
				}
				case 26:
					return;
				case 33:
					portfolio.UnrealizedPnl = 0.0;
					goto IL_029e;
				case 11:
					return;
				case 12:
					portfolio.RealizedPnl = 0.0;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
					{
						num = 3;
					}
					continue;
				case 2:
					val = P_0.OpenPnl;
					if (!val.Use)
					{
						val = P_0.OpenPnl;
						num = 8;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
						{
							num = 9;
						}
					}
					else
					{
						num = 21;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
						{
							num = 21;
						}
					}
					continue;
				case 3:
					kynG7Ciqp0T(portfolio);
					num = 35;
					continue;
				case 13:
				{
					Position position2 = position;
					val = P_0.ClosedPnl;
					position2.RealizedPnl = val.Value;
					num = 19;
					continue;
				}
				case 16:
					val = P_0.ClosedPnl;
					portfolio.RealizedPnl = val.Value;
					goto case 3;
				case 7:
					goto IL_05a9;
				case 28:
					portfolio.FreeMargin = 0.0;
					num = 18;
					continue;
				case 20:
					if (!val.Use)
					{
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
						{
							num = 4;
						}
						continue;
					}
					goto case 13;
				case 19:
					OpTG7yddYDM(position);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
					{
						num = 0;
					}
					continue;
				case 5:
					if (P_0.Position.Use)
					{
						goto case 23;
					}
					if (P_0.Position.Clear)
					{
						goto case 15;
					}
					goto IL_0755;
				case 23:
					position.Quantity = P_0.Position.Value;
					goto IL_0755;
				case 30:
					val = P_0.OpenPnl;
					if (val.Clear)
					{
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
						{
							num = 33;
						}
						continue;
					}
					goto IL_029e;
				case 14:
				case 18:
					goto IL_0720;
				case 9:
					if (val.Clear)
					{
						position.UnrealizedPnl = 0.0;
					}
					goto case 34;
				case 17:
					goto IL_076c;
				case 6:
					goto IL_0791;
				case 8:
					goto IL_07c0;
				case 22:
					portfolio.Balance = 0.0;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f != 0)
					{
						num = 0;
					}
					continue;
				case 0:
					return;
					IL_029e:
					val = P_0.ClosedPnl;
					if (val.Use)
					{
						num = 16;
						continue;
					}
					val = P_0.ClosedPnl;
					num = 32;
					continue;
					IL_0755:
					if (P_0.AvgOpenFillPrice.Use)
					{
						Position position4 = position;
						val = P_0.AvgOpenFillPrice;
						position4.AvgPrice = val.Value;
						num = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
						{
							num = 2;
						}
						continue;
					}
					if (P_0.AvgOpenFillPrice.Use)
					{
						position.AvgPrice = 0.0;
					}
					goto case 2;
				}
				break;
				IL_07c0:
				if (!val.Use)
				{
					val = P_0.MarginBalance;
					if (val.Clear)
					{
						num = 28;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
						{
							num = 17;
						}
						continue;
					}
					goto IL_0720;
				}
				val = P_0.MarginBalance;
				portfolio.FreeMargin = val.Value;
				num = 14;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num = 14;
				}
				continue;
				IL_0720:
				val = P_0.OpenPnl;
				num = 10;
				continue;
				IL_05a9:
				if (symbol == null)
				{
					return;
				}
				if (account == null)
				{
					int num2 = 11;
					num = num2;
					continue;
				}
				text = symbol.ID + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325242477) + account.UniqueID;
				num = 29;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
				{
					num = 23;
				}
			}
			goto IL_0186;
			IL_0791:
			if (!P_0.AccountBalance.Use)
			{
				goto IL_0285;
			}
			goto IL_076c;
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	protected override void kpTlYz9YLrV(Order P_0)
	{
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ec: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02b4: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_03f0: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		try
		{
			Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = base.B5jlYEmv1MN.LPiaEyKvEyx((Symbol)uvc0u5SnMQKoeakZ65R1(P_0));
			int num = 2;
			string text = default(string);
			OrderType orderType = default(OrderType);
			while (true)
			{
				REngine obj2;
				StopMarketOrderParams val2;
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 7:
					return;
				case 3:
					text = (((Account)zyImRZSnJELYcDH8c3O9(P_0)).TradeRoutes.ContainsKey(rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l()) ? P_0.Account.TradeRoutes[rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l()] : "");
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					HjcG8sgZFrT.uUhadink4GI(P_0, _0020: true);
					num = 8;
					continue;
				case 8:
					orderType = oUJ2n4SnFEAgtO93yaIW(P_0);
					num = 6;
					continue;
				case 2:
					if (rybo1XGzd9ch5SOUQC2H == null)
					{
						return;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num = 3;
					}
					continue;
				case 6:
					switch (orderType)
					{
					default:
						return;
					case OrderType.Market:
						break;
					case OrderType.Limit:
					{
						REngine obj = kwhYnhsEAg1;
						LimitOrderParams val = new LimitOrderParams();
						eLvmqOSG95Rv2rFanCcK((object)val, (object)new AccountInfo((string)nfevvDSG2FFHVwliktcq(P_0.Account), (string)wrfumgSGHnr7q8FZONDY(P_0.Account), (string)UeoLVSSGf5laTbOyDde1(zyImRZSnJELYcDH8c3O9(P_0))));
						rucAdXSGGOt0GwZHbM83((object)val, (IO2upUSGnR8o3wNxG3qj(P_0) == Side.Buy) ? Constants.BUY_SELL_TYPE_BUY : Constants.BUY_SELL_TYPE_SELL);
						val.Duration = ((dWps5jSGYvGVlCDFFDsT(P_0) == OrderValidity.Gtc) ? Constants.ORDER_DURATION_GTC : Constants.ORDER_DURATION_DAY);
						val.EntryType = Constants.ORDER_ENTRY_TYPE_MANUAL;
						val.Exchange = rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l();
						val.Price = V7SeeLSGvPjYep2lBbu9(P_0.Symbol, Ux85LeSGoRLiNDy25T6I(P_0));
						val.Qty = (int)P_0.Quantity;
						val.Symbol = (string)Gvj66oS9OGxQy1YxLpZ7(rybo1XGzd9ch5SOUQC2H);
						eIv42CSGBLeerENc5kuA((object)val, FJP91SSnznkRO3bBYMUE(P_0));
						val.TradeRoute = text;
						l95vI6SGaMmVcuoEJtFM(obj, (object)val);
						return;
					}
					case OrderType.Stop:
						goto IL_035c;
					case OrderType.StopLimit:
						goto end_IL_0028;
					}
					goto case 1;
				case 1:
				{
					REngine obj3 = kwhYnhsEAg1;
					MarketOrderParams val3 = new MarketOrderParams();
					kdVXuUSn3mqM3cMfjaaa((object)val3, (object)new AccountInfo(P_0.Account.FcmId, ((Account)zyImRZSnJELYcDH8c3O9(P_0)).IbId, P_0.Account.Name));
					val3.BuySellType = ((P_0.Side == Side.Buy) ? Constants.BUY_SELL_TYPE_BUY : Constants.BUY_SELL_TYPE_SELL);
					val3.Duration = ((P_0.Validity == OrderValidity.Gtc) ? Constants.ORDER_DURATION_GTC : Constants.ORDER_DURATION_DAY);
					val3.EntryType = Constants.ORDER_ENTRY_TYPE_MANUAL;
					val3.Exchange = (string)jL0GgQSnpv4ksj1V2cCk(rybo1XGzd9ch5SOUQC2H);
					val3.Qty = (int)P_0.Quantity;
					lQGPCQSnu8jboubNrZML((object)val3, Gvj66oS9OGxQy1YxLpZ7(rybo1XGzd9ch5SOUQC2H));
					val3.Tag = (string)FJP91SSnznkRO3bBYMUE(P_0);
					val3.TradeRoute = text;
					bDNUFrSG0KQ0WF4I7C63(obj3, (object)val3);
					return;
				}
				case 5:
					goto IL_035c;
				case 4:
					break;
					IL_035c:
					obj2 = kwhYnhsEAg1;
					val2 = new StopMarketOrderParams
					{
						TriggerPrice = V7SeeLSGvPjYep2lBbu9(P_0.Symbol, qnD3AsSGix8HngAti5fq(P_0)),
						Account = new AccountInfo(P_0.Account.FcmId, P_0.Account.IbId, P_0.Account.Name),
						BuySellType = ((IO2upUSGnR8o3wNxG3qj(P_0) == Side.Buy) ? Constants.BUY_SELL_TYPE_BUY : Constants.BUY_SELL_TYPE_SELL)
					};
					Bf0PtcSGlPdtdXx1yFwg((object)val2, (dWps5jSGYvGVlCDFFDsT(P_0) == OrderValidity.Gtc) ? Constants.ORDER_DURATION_GTC : Constants.ORDER_DURATION_DAY);
					((MarketOrderParams)val2).EntryType = Constants.ORDER_ENTRY_TYPE_MANUAL;
					((MarketOrderParams)val2).Exchange = rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l();
					Bvup3ASG43wMl1urkuHQ((object)val2, (int)P_0.Quantity);
					lQGPCQSnu8jboubNrZML((object)val2, rybo1XGzd9ch5SOUQC2H.Code);
					sl6S4DSGDbS5pnI9vsGQ((object)val2, P_0.StrCookie);
					((MarketOrderParams)val2).TradeRoute = text;
					obj2.sendOrder(val2);
					return;
					end_IL_0028:
					break;
				}
				REngine obj4 = kwhYnhsEAg1;
				StopLimitOrderParams val4 = new StopLimitOrderParams
				{
					TriggerPrice = ((Symbol)uvc0u5SnMQKoeakZ65R1(P_0)).GetRealPrice(qnD3AsSGix8HngAti5fq(P_0)),
					Account = new AccountInfo(((Account)zyImRZSnJELYcDH8c3O9(P_0)).FcmId, (string)wrfumgSGHnr7q8FZONDY(P_0.Account), P_0.Account.Name),
					BuySellType = ((P_0.Side == Side.Buy) ? Constants.BUY_SELL_TYPE_BUY : Constants.BUY_SELL_TYPE_SELL),
					Duration = ((P_0.Validity == OrderValidity.Gtc) ? Constants.ORDER_DURATION_GTC : Constants.ORDER_DURATION_DAY),
					EntryType = Constants.ORDER_ENTRY_TYPE_MANUAL
				};
				yGBsKySGbsgvxuWTJdKj((object)val4, rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l());
				p6CkyxSGNZZ3Kr6T26Q5((object)val4, V7SeeLSGvPjYep2lBbu9(uvc0u5SnMQKoeakZ65R1(P_0), P_0.Price));
				bkI3xeSGkfq0wYmlHjGB((object)val4, (int)P_0.Quantity);
				q3UOpFSG1qbEuNBx82CX((object)val4, rybo1XGzd9ch5SOUQC2H.Code);
				eIv42CSGBLeerENc5kuA((object)val4, P_0.StrCookie);
				((LimitOrderParams)val4).TradeRoute = text;
				obj4.sendOrder(val4);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
				{
					num = 7;
				}
			}
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	protected override void jNJlo90jRN4(Order P_0)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		try
		{
			OrderModifyParams modifyParams = P_0.ModifyParams;
			if (modifyParams == null)
			{
				return;
			}
			OrderType type = default(OrderType);
			while (true)
			{
				P_0.ModifyParams = null;
				Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = base.B5jlYEmv1MN.LPiaEyKvEyx(P_0.Symbol);
				int num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
				{
					num = 3;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						return;
					case 4:
					{
						REngine obj2 = kwhYnhsEAg1;
						ModifyStopMarketOrderParams val2 = new ModifyStopMarketOrderParams
						{
							Account = new AccountInfo(P_0.Account.FcmId, ((Account)zyImRZSnJELYcDH8c3O9(P_0)).IbId, (string)UeoLVSSGf5laTbOyDde1(zyImRZSnJELYcDH8c3O9(P_0)))
						};
						DKAwFbSG5GPM4Ufvbj6j((object)val2, Constants.ORDER_ENTRY_TYPE_MANUAL);
						JpvdmfSGSWBw0hVYrWFB((object)val2, rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l());
						EmGuvySGx9OCbWmFhgWm((object)val2, P_0.OrderID);
						val2.TriggerPrice = V7SeeLSGvPjYep2lBbu9(uvc0u5SnMQKoeakZ65R1(P_0), modifyParams.StopPrice);
						val2.Qty = (int)modifyParams.Quantity;
						val2.Symbol = rybo1XGzd9ch5SOUQC2H.Code;
						obj2.modifyOrder(val2);
						return;
					}
					case 5:
						break;
					case 3:
					{
						if (rybo1XGzd9ch5SOUQC2H == null)
						{
							return;
						}
						type = P_0.Type;
						int num2 = 2;
						num = num2;
						continue;
					}
					case 2:
						switch (type)
						{
						default:
							return;
						case OrderType.Stop:
							break;
						case OrderType.StopLimit:
						{
							REngine obj = kwhYnhsEAg1;
							ModifyStopLimitOrderParams val = new ModifyStopLimitOrderParams
							{
								Account = new AccountInfo(((Account)zyImRZSnJELYcDH8c3O9(P_0)).FcmId, (string)wrfumgSGHnr7q8FZONDY(zyImRZSnJELYcDH8c3O9(P_0)), P_0.Account.Name),
								EntryType = Constants.ORDER_ENTRY_TYPE_MANUAL
							};
							BE05NWSGLsKge3V38aFw((object)val, rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l());
							val.OrderNum = (string)NZ2HVVSGe39YaOA8ykUk(P_0);
							U3qrekSGXe769fgBkk55((object)val, ((Symbol)uvc0u5SnMQKoeakZ65R1(P_0)).GetRealPrice(bCJ7YwSGscnOeQoA8mEc(modifyParams)));
							val.TriggerPrice = P_0.Symbol.GetRealPrice(modifyParams.StopPrice);
							SBlGhBSGcxGagcuUR6IY((object)val, (int)modifyParams.Quantity);
							val.Symbol = rybo1XGzd9ch5SOUQC2H.Code;
							lOpaDiSGjBCPsQC6BMOM(obj, (object)val);
							num = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
							{
								num = 0;
							}
							continue;
						}
						case OrderType.Limit:
							kwhYnhsEAg1.modifyOrder(new ModifyLimitOrderParams
							{
								Account = new AccountInfo(P_0.Account.FcmId, P_0.Account.IbId, (string)UeoLVSSGf5laTbOyDde1(zyImRZSnJELYcDH8c3O9(P_0))),
								EntryType = Constants.ORDER_ENTRY_TYPE_MANUAL,
								Exchange = rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l(),
								OrderNum = P_0.OrderID,
								Price = V7SeeLSGvPjYep2lBbu9(P_0.Symbol, modifyParams.Price),
								Qty = (int)modifyParams.Quantity,
								Symbol = rybo1XGzd9ch5SOUQC2H.Code
							});
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
							{
								num = 1;
							}
							continue;
						}
						goto case 4;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			v8PKsUS9NmejH4FInD2K(this, ex);
		}
	}

	protected override void DqPlo0ULSuU(Order P_0)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		try
		{
			P_0.StrCookie = "";
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			HjcG8sgZFrT.uUhadink4GI(P_0, _0020: true);
			PYTvhcSGEL85wmth9LxP(kwhYnhsEAg1, (object)new AccountInfo(P_0.Account.FcmId, P_0.Account.IbId, (string)UeoLVSSGf5laTbOyDde1(P_0.Account)), P_0.OrderID, Constants.ORDER_ENTRY_TYPE_MANUAL, null, null, null);
		}
		catch (Exception ex)
		{
			rvrlofnZLRT(ex);
		}
	}

	private DateTime KibYnrNOQol(int P_0, int P_1, Symbol P_2)
	{
		return rMoYn8jCsg4.Add(TimeHelper.EasternTimeOffsetUtc).AddTicks((long)P_0 * 10000000L + (long)P_1 * 10000L / 1000);
	}

	public override void EL3lnODvZSu()
	{
		o0rG7pUoSyh(mGAYnm1teR4);
		jryG7maKpTu();
	}

	[SpecialName]
	public override SuSj0gaXkIlYcfCsT0qp KyslYhCu6Vs()
	{
		return new N4FYDXYnP6rLipRuGt7q(mGAYnm1teR4);
	}

	[CompilerGenerated]
	private void cIbYnK9yfeI()
	{
		o0rG7pUoSyh(mGAYnm1teR4);
	}

	static K69fi4YnakxkH7CaMjfp()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void iYnZNfS9af2AysaEoALc()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool WYlBWtS9vfJyxkgg5vIn()
	{
		return r46c49S9oN6ro82fIaCA == null;
	}

	internal static K69fi4YnakxkH7CaMjfp o99RTmS9BJKexMW7fk1K()
	{
		return r46c49S9oN6ro82fIaCA;
	}

	internal static object ktkfc3S9iEGsGeD7EsR0(object P_0)
	{
		return ((ConnectionInfo)P_0).TradeClientID;
	}

	internal static object LR1O3oS9lqoP6Ma7YaoU(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void tN1XBvS94lUmHRlelwjt(object P_0, object P_1)
	{
		((Rybo1XGzd9ch5SOUQC2H)P_0).mH2GzUrgmWj((string)P_1);
	}

	internal static bool z5afoJS9DyMs4ba5E7vf(object P_0)
	{
		return ((ConnectionInfo)P_0).AutoConnect;
	}

	internal static bool M4iTWKS9bNA21t16smqE(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void v8PKsUS9NmejH4FInD2K(object P_0, object P_1)
	{
		((Yi88EJG7GEjfyLGpmx9j)P_0).rvrlofnZLRT((Exception)P_1);
	}

	internal static object NwATlmS9kQKJtncxZ0cZ(object P_0)
	{
		return ((pTUY25YGCEN5dn8fwd3g)P_0).MP2YGKyEckI();
	}

	internal static object YgDWJIS91a9MGs6EcP7L(object P_0)
	{
		return ((zqUHQqYnpwFsIpgX42kQ)P_0).hoCYG9wGUoB();
	}

	internal static void Lp7NEpS95R1Z5hfCGkQ6(object P_0, object P_1)
	{
		((REngineParams)P_0).AdmCnnctPt = (string)P_1;
	}

	internal static object hernEuS9SEKYmfahkxL1(object P_0)
	{
		return ((zqUHQqYnpwFsIpgX42kQ)P_0).bkFYGYwU3ZK();
	}

	internal static void OijrxkS9xCFNodwwMMiF(object P_0, object P_1)
	{
		((REngineParams)P_0).DomainName = (string)P_1;
	}

	internal static object mo6Kc8S9LFx9lZi8Q9ZT(object P_0)
	{
		return ((zqUHQqYnpwFsIpgX42kQ)P_0).N9XYG1o4CEn();
	}

	internal static void vMKeVvS9euP4SwKgNrn1(object P_0, object P_1)
	{
		((REngineParams)P_0).LoggerAddr = (string)P_1;
	}

	internal static void KCKUH7S9smeBcDS60TFi(object P_0, object P_1)
	{
		((REngineParams)P_0).AppVersion = (string)P_1;
	}

	internal static object fDDyKhS9XKss1Bok8Pmy(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object S1U64XS9cI5Q9vWfmnQm(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void l6SEo9S9jwPxE5Y6ULL7(object P_0, object P_1)
	{
		((REngineParams)P_0).LogFilePath = (string)P_1;
	}

	internal static void TCBEHAS9EM6qEr1b6f08(object P_0, object P_1)
	{
		((REngineParams)P_0).AdmCallbacks = (AdmCallbacks)P_1;
	}

	internal static object FgO51GS9Q9gjBBWi5jNw(object P_0)
	{
		return ((zqUHQqYnpwFsIpgX42kQ)P_0).cDiYGjFG0F5();
	}

	internal static object RBSPxgS9dWaWWdCw2QN4(object P_0)
	{
		return ((zqUHQqYnpwFsIpgX42kQ)P_0).FiAYGsWg8db();
	}

	internal static bool GfbQeFS9gCuqVtdIO3vj(object P_0)
	{
		return ThreadPool.QueueUserWorkItem((WaitCallback)P_0);
	}

	internal static bool UsKPmiS9R6CZ36QcUK19(object P_0)
	{
		return AFoGv5GAT4PeYBusSBbk.pJBGArTkG0n((Symbol)P_0);
	}

	internal static bool xstjoWS96iYrWjlDASYF(object P_0)
	{
		return AFoGv5GAT4PeYBusSBbk.jaKGAmShKvV((Symbol)P_0);
	}

	internal static bool I03291S9M0BJUYGET7Uf(object P_0)
	{
		return AFoGv5GAT4PeYBusSBbk.aqRGAKboHm4((Symbol)P_0);
	}

	internal static object Gvj66oS9OGxQy1YxLpZ7(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Code;
	}

	internal static void cTbESDS9qBERVOIXl65r(object P_0, object P_1, object P_2, object P_3)
	{
		((REngine)P_0).rebuildBook((string)P_1, (string)P_2, P_3);
	}

	internal static object lCSK9jS9IUARGkZ3UVSS(object P_0)
	{
		return ((AccountInfo)P_0).IbId;
	}

	internal static object K1dB3iS9W1hDjAR4FsHQ(object P_0)
	{
		return ((AccountInfo)P_0).AccountId;
	}

	internal static void q1nSFsS9tsEcEsf3xuIV(object P_0, object P_1)
	{
		((Portfolio)P_0).Name = (string)P_1;
	}

	internal static void BSlL5ZS9UVhe18BCZPZ9(object P_0, object P_1)
	{
		((Yf7Wh7aQx5n0OwURsfH6)P_0).vwgaQefLqWv((Portfolio)P_1);
	}

	internal static object TtGkKlS9TXplh7IAVLoX(object P_0)
	{
		return ((AccountInfo)P_0).RmsInfo;
	}

	internal static void fH1Zl6S9yvLtQh81QOAc(object P_0, object P_1)
	{
		((REngine)P_0).subscribeOrder((AccountInfo)P_1);
	}

	internal static void i9txMXS9ZGlJgKjbNGrL(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		((REngine)P_0).replayExecutions((AccountInfo)P_1, P_2, P_3, P_4);
	}

	internal static bool vRbDfSS9V7gi9uoYqmGt(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void U2oCQDS9CA3Psnk9AoEJ(object P_0, object P_1)
	{
		((REngine)P_0).listTradeRoutes(P_1);
	}

	internal static object WxL8ysS9rTJ70YFZWUjf(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object j1AbNsS9KrFCFffM7NP7(object P_0, object P_1)
	{
		return ((Securities)P_0).jemaQZBB4Zt((string)P_1);
	}

	internal static void NPJrtoS9mMfhVqbOU2fD(object P_0, object P_1)
	{
		((Securities)P_0).qKPaQyx1AxZ((Security)P_1);
	}

	internal static double mIB6ZvS9hJd2KbLdAwFg(object P_0)
	{
		return ((BidInfo)P_0).Price;
	}

	internal static int PchSomS9wGjf5P8XS8AY(object P_0)
	{
		return ((BidInfo)P_0).Size;
	}

	internal static object GfFOPfS97gGU44J6qm5c(object P_0)
	{
		return ((Security)P_0).Symbol;
	}

	internal static object Cm0xFMS98Pyr54h8rPbr(object P_0)
	{
		return ((AskInfo)P_0).Context;
	}

	internal static long cZtfI9S9Aes4c683idvn(object P_0, double price)
	{
		return ((Symbol)P_0).GetShortPrice(price);
	}

	internal static int VJdmQhS9PymfLWfGSXG6(object P_0)
	{
		return ((AskInfo)P_0).Ssboe;
	}

	internal static int NyMr8mS9JJVAx1xldwwg(object P_0)
	{
		return ((AskInfo)P_0).Usecs;
	}

	internal static object QYgco5S9FywVprfVQENF(object P_0, object P_1)
	{
		return ((Security)P_0).GetEvent((Symbol)P_1);
	}

	internal static void kdKX1TS93p8v8dni0T0N(object P_0, long value)
	{
		((Security)P_0).BidPrice = value;
	}

	internal static int OUdrpQS9pLwhmNwAMXq4(object P_0)
	{
		return ((BidInfo)P_0).Ssboe;
	}

	internal static int VZETO9S9uS5cJslIqxAe(object P_0)
	{
		return ((AskInfo)P_0).Size;
	}

	internal static void TGPODdS9z9sDbVKXkODf(object P_0, long value)
	{
		((Security)P_0).AskSize = value;
	}

	internal static object cWWreRSn0WaFmPfKAOZq(object P_0)
	{
		return ((OpenPriceInfo)P_0).Context;
	}

	internal static double Oj3P4VSn2hYcHsitbxnA(object P_0)
	{
		return ((OpenPriceInfo)P_0).Price;
	}

	internal static void QoXDEXSnHrIqu1t3UWQo(object P_0, double value)
	{
		((Security)P_0).OpenPrice = value;
	}

	internal static void OnX1HeSnfu37wRq7ORvd(object P_0, double value)
	{
		((Security)P_0).LowPrice = value;
	}

	internal static void X44O3FSn9Z75CO3RXMny(object P_0, long value)
	{
		((Security)P_0).OpenInt = value;
	}

	internal static object EAn1fhSnnIf194imeRl7(object P_0)
	{
		return ((OrderBookInfo)P_0).Context;
	}

	internal static object ytSBVSSnG94H8R0a0VIN(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk((Symbol)P_0);
	}

	internal static double T3OLfOSnYtVpIAjPt30d(object P_0)
	{
		return ((AskInfo)P_0).Price;
	}

	internal static object j4DHhbSnofm9STr1GjmQ(object P_0, object P_1)
	{
		return ((iUurRSaEdsHhvxFJgcBd)P_0).f0oaEMlfDjn((Symbol)P_1);
	}

	internal static UpdateType vEvXIvSnveDA88NXDPG1(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((AskInfo)P_0).UpdateType;
	}

	internal static UpdateType pmTWbiSnBI1v7KKTSqLD(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((BidInfo)P_0).UpdateType;
	}

	internal static object rHkulxSnaH3O8velBn7J(object P_0)
	{
		return ((TradeInfo)P_0).Context;
	}

	internal static double ElALQRSniH3F7Je4hG6A(object P_0)
	{
		return ((TradeInfo)P_0).Price;
	}

	internal static void ifJSkgSnlGWOMvK33OBE(object P_0, long P_1)
	{
		((TickEvent)P_0).Price = P_1;
	}

	internal static void pC5QpASn49mSsJwnsKQU(object P_0, long P_1)
	{
		((TickEvent)P_0).Size = P_1;
	}

	internal static object P9pN5uSnDW79YIDLtY60(object P_0)
	{
		return ((TradeInfo)P_0).AggressorSide;
	}

	internal static bool MhjRR0SnbNhgNEJwUjTy(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void iNTJZkSnNpEtBVkMH6jB(object P_0, long value)
	{
		((Security)P_0).LastSize = value;
	}

	internal static DateTime cJrPalSnk3HSjWvw5Dhr(object P_0)
	{
		return ((TickEvent)P_0).Time;
	}

	internal static long Ed9sELSn19L9WRLSRZlE(object P_0)
	{
		return ((Security)P_0).BidSize;
	}

	internal static void FWmNWsSn5YX18X2IiYVk(object P_0, long P_1)
	{
		((TickEvent)P_0).BidSize = P_1;
	}

	internal static long GVZld4SnSbPocDIDnqVx(object P_0)
	{
		return ((Security)P_0).AskPrice;
	}

	internal static void SmkfmNSnx7nahy3Ol92L(object P_0, long P_1)
	{
		((TickEvent)P_0).Ask = P_1;
	}

	internal static object dqjxXTSnLGg28VJY22fV(object P_0)
	{
		return ((TradeReplayInfo)P_0).Context;
	}

	internal static void IPTQ5wSneNMjBGDAnClf(object P_0, object P_1)
	{
		((LineInfo)P_0).Dump((StringBuilder)P_1);
	}

	internal static object BVSM1dSnsVLkbJD8curS(object P_0)
	{
		return ((LineInfo)P_0).Exchange;
	}

	internal static object QhqukPSnXTejg9cAChB9(object P_0)
	{
		return ((LineInfo)P_0).OrderNum;
	}

	internal static int pyjuErSncY4tWy1OIDrI(object P_0)
	{
		return ((LineInfo)P_0).Ssboe;
	}

	internal static object gtMnjeSnj2kFPCc82QnE(object P_0)
	{
		return ((LineInfo)P_0).BuySellType;
	}

	internal static int gCUlNBSnESSrrm83MtHJ(object P_0)
	{
		return ((LineInfo)P_0).QuantityToFill;
	}

	internal static void GvpLxeSnQHEemDg2QiMr(object P_0, long value)
	{
		((Order)P_0).Remaining = value;
	}

	internal static double NtrysJSndP3Fs0FlI4hG(object P_0)
	{
		return ((LineInfo)P_0).AvgFillPrice;
	}

	internal static bool ePDEpeSng3N103Zq8m25(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static object Mu3xIaSnRG8PSsMUU2eR(object P_0)
	{
		return ((LineInfo)P_0).OrderType;
	}

	internal static void GZ8R4nSn61vpSHRqRgk1(object P_0, OrderType value)
	{
		((Order)P_0).Type = value;
	}

	internal static object uvc0u5SnMQKoeakZ65R1(object P_0)
	{
		return ((Order)P_0).Symbol;
	}

	internal static void nmLMhsSnO0kCfNXJ6YeR(object P_0, long value)
	{
		((Order)P_0).Price = value;
	}

	internal static double seWwFJSnqfQGTJyu0hZH(object P_0)
	{
		return ((LineInfo)P_0).TriggerPrice;
	}

	internal static object D2J7rOSnI3DJ12drnHwM(object P_0)
	{
		return ((LineInfo)P_0).Status;
	}

	internal static void gYUADpSnWjlHI9G5OWtH(object P_0, OrderState value)
	{
		((Order)P_0).State = value;
	}

	internal static object d2ZGetSntINFQDO6NucH(object P_0)
	{
		return ((LineInfo)P_0).CompletionReason;
	}

	internal static OrderState Eh0ZbcSnUqKYZqllOk0U(object P_0)
	{
		return ((Order)P_0).State;
	}

	internal static object S50FqESnTZMoKM0VJ1N1(object P_0)
	{
		return ((OrderReport)P_0).OrderNum;
	}

	internal static object f1mk0eSnyGpu8p8AM9Wp(object P_0)
	{
		return ((OrderReport)P_0).Tag;
	}

	internal static object eC8ZoFSnZIDVPqvWYiXN(object P_0, object P_1)
	{
		return ((Orders)P_0).kJOaQoAYWmU((string)P_1);
	}

	internal static object YKYTrcSnVgFfZT2cx53r(object P_0, object P_1)
	{
		return ((w0Orr3adoDNjLMW2u5tF)P_0).DGKadD52Epx((string)P_1);
	}

	internal static object IfanRLSnClXYCIrffrEq(object P_0)
	{
		return ((OrderReport)P_0).Text;
	}

	internal static bool MbvYW0SnrR5KjABZThCO(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object XAT99wSnKhA642YaZwjc(object P_0)
	{
		return ((OrderReport)P_0).Exchange;
	}

	internal static object IJ7uCISnmCR19E7guXxy(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object dDEYukSnhlBGXMFsl8XJ(object P_0)
	{
		return ((OrderReport)P_0).ReportId;
	}

	internal static object uAidv9SnwuHiKJGnX1Rl(object P_0)
	{
		return ((OrderReport)P_0).BuySellType;
	}

	internal static void VCVkIJSn7x6m6ntLAqTK(object P_0, double value)
	{
		((Portfolio)P_0).Balance = value;
	}

	internal static object fxOZD8Sn8ssmvrTkuEyv(object P_0)
	{
		return ((PnlInfo)P_0).Symbol;
	}

	internal static object HjQBseSnAUKR4ecAlB7I(object P_0, object P_1)
	{
		return ((Accounts)P_0).eTHaEeINcUH((string)P_1);
	}

	internal static void nKIJyYSnPfVZclltgN9k(object P_0, long value)
	{
		((Position)P_0).Quantity = value;
	}

	internal static object zyImRZSnJELYcDH8c3O9(object P_0)
	{
		return ((Order)P_0).Account;
	}

	internal static OrderType oUJ2n4SnFEAgtO93yaIW(object P_0)
	{
		return ((Order)P_0).Type;
	}

	internal static void kdVXuUSn3mqM3cMfjaaa(object P_0, object P_1)
	{
		((MarketOrderParams)P_0).Account = (AccountInfo)P_1;
	}

	internal static object jL0GgQSnpv4ksj1V2cCk(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).kbJGztBrI0l();
	}

	internal static void lQGPCQSnu8jboubNrZML(object P_0, object P_1)
	{
		((MarketOrderParams)P_0).Symbol = (string)P_1;
	}

	internal static object FJP91SSnznkRO3bBYMUE(object P_0)
	{
		return ((Order)P_0).StrCookie;
	}

	internal static void bDNUFrSG0KQ0WF4I7C63(object P_0, object P_1)
	{
		((REngine)P_0).sendOrder((MarketOrderParams)P_1);
	}

	internal static object nfevvDSG2FFHVwliktcq(object P_0)
	{
		return ((Account)P_0).FcmId;
	}

	internal static object wrfumgSGHnr7q8FZONDY(object P_0)
	{
		return ((Account)P_0).IbId;
	}

	internal static object UeoLVSSGf5laTbOyDde1(object P_0)
	{
		return ((Account)P_0).Name;
	}

	internal static void eLvmqOSG95Rv2rFanCcK(object P_0, object P_1)
	{
		((LimitOrderParams)P_0).Account = (AccountInfo)P_1;
	}

	internal static Side IO2upUSGnR8o3wNxG3qj(object P_0)
	{
		return ((Order)P_0).Side;
	}

	internal static void rucAdXSGGOt0GwZHbM83(object P_0, object P_1)
	{
		((LimitOrderParams)P_0).BuySellType = (string)P_1;
	}

	internal static OrderValidity dWps5jSGYvGVlCDFFDsT(object P_0)
	{
		return ((Order)P_0).Validity;
	}

	internal static long Ux85LeSGoRLiNDy25T6I(object P_0)
	{
		return ((Order)P_0).Price;
	}

	internal static double V7SeeLSGvPjYep2lBbu9(object P_0, long price)
	{
		return ((Symbol)P_0).GetRealPrice(price);
	}

	internal static void eIv42CSGBLeerENc5kuA(object P_0, object P_1)
	{
		((LimitOrderParams)P_0).Tag = (string)P_1;
	}

	internal static void l95vI6SGaMmVcuoEJtFM(object P_0, object P_1)
	{
		((REngine)P_0).sendOrder((LimitOrderParams)P_1);
	}

	internal static long qnD3AsSGix8HngAti5fq(object P_0)
	{
		return ((Order)P_0).StopPrice;
	}

	internal static void Bf0PtcSGlPdtdXx1yFwg(object P_0, object P_1)
	{
		((MarketOrderParams)P_0).Duration = (string)P_1;
	}

	internal static void Bvup3ASG43wMl1urkuHQ(object P_0, int P_1)
	{
		((MarketOrderParams)P_0).Qty = P_1;
	}

	internal static void sl6S4DSGDbS5pnI9vsGQ(object P_0, object P_1)
	{
		((MarketOrderParams)P_0).Tag = (string)P_1;
	}

	internal static void yGBsKySGbsgvxuWTJdKj(object P_0, object P_1)
	{
		((LimitOrderParams)P_0).Exchange = (string)P_1;
	}

	internal static void p6CkyxSGNZZ3Kr6T26Q5(object P_0, double P_1)
	{
		((LimitOrderParams)P_0).Price = P_1;
	}

	internal static void bkI3xeSGkfq0wYmlHjGB(object P_0, int P_1)
	{
		((LimitOrderParams)P_0).Qty = P_1;
	}

	internal static void q3UOpFSG1qbEuNBx82CX(object P_0, object P_1)
	{
		((LimitOrderParams)P_0).Symbol = (string)P_1;
	}

	internal static void DKAwFbSG5GPM4Ufvbj6j(object P_0, object P_1)
	{
		((ModifyStopMarketOrderParams)P_0).EntryType = (string)P_1;
	}

	internal static void JpvdmfSGSWBw0hVYrWFB(object P_0, object P_1)
	{
		((ModifyStopMarketOrderParams)P_0).Exchange = (string)P_1;
	}

	internal static void EmGuvySGx9OCbWmFhgWm(object P_0, object P_1)
	{
		((ModifyStopMarketOrderParams)P_0).OrderNum = (string)P_1;
	}

	internal static void BE05NWSGLsKge3V38aFw(object P_0, object P_1)
	{
		((ModifyStopLimitOrderParams)P_0).Exchange = (string)P_1;
	}

	internal static object NZ2HVVSGe39YaOA8ykUk(object P_0)
	{
		return ((Order)P_0).OrderID;
	}

	internal static long bCJ7YwSGscnOeQoA8mEc(object P_0)
	{
		return ((OrderModifyParams)P_0).Price;
	}

	internal static void U3qrekSGXe769fgBkk55(object P_0, double P_1)
	{
		((ModifyStopLimitOrderParams)P_0).Price = P_1;
	}

	internal static void SBlGhBSGcxGagcuUR6IY(object P_0, int P_1)
	{
		((ModifyStopLimitOrderParams)P_0).Qty = P_1;
	}

	internal static void lOpaDiSGjBCPsQC6BMOM(object P_0, object P_1)
	{
		((REngine)P_0).modifyOrder((ModifyStopLimitOrderParams)P_1);
	}

	internal static void PYTvhcSGEL85wmth9LxP(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6)
	{
		((REngine)P_0).cancelOrder((AccountInfo)P_1, (string)P_2, (string)P_3, (string)P_4, (string)P_5, P_6);
	}
}
