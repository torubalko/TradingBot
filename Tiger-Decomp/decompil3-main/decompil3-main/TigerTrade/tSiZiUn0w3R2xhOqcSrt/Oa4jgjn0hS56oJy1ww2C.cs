using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using AQB6mgf3wjOUxVfiEwwS;
using BSqjnpnHzA7jR1siKKL7;
using ECOEgqlSad8NUJZ2Dr9n;
using EWqOVgn97YSHRIL9xw24;
using FrIaYZnnSIaf4MUvcuVY;
using gdx3H5n2n1kKmq39QX3K;
using jS3Y2j9pTQRy0FnOknFG;
using k2djPS9h3aXysXOe0uK1;
using Mew74MnHaoAXj2LGZkss;
using NsWD4W9miMxRbFU3fsu9;
using PGh1t097dKGNtpYw9WbJ;
using rI6OsenfzT9t6MCWkcwl;
using ROhuQx9FcGTLTqPCaJ0j;
using s6Ily0n9N1XdcJ3TM5SO;
using sLcyilnfArvAs1ybn2Qh;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using V9ObVI9gCxZjgUce1Uw4;
using wfgqtU9htHKSCYqG2l2W;

namespace tSiZiUn0w3R2xhOqcSrt;

internal class Oa4jgjn0hS56oJy1ww2C : xOT7nVn29sROOtPFyM95
{
	[CompilerGenerated]
	private Action<j3bgDY9gV2i9bttJ1fiQ> m_Command;

	private rRU9qon9wK1uuIVJk37m YKvn20ovlqW;

	private int zVin22GIRjO;

	private int nc1n2HRp8k6;

	private readonly jjKtVJ9pUSOpdg38tqnP mdSn2fLSGY3;

	internal static Oa4jgjn0hS56oJy1ww2C gBP3XTb7MZbRXf9tAxMH;

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

	public Oa4jgjn0hS56oJy1ww2C(jjKtVJ9pUSOpdg38tqnP P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		YKvn20ovlqW = rRU9qon9wK1uuIVJk37m.None;
		mdSn2fLSGY3 = P_0;
	}

	public bool MouseDown(int mouseX, int mouseY, int clickCount, MouseButton changedButton)
	{
		int num = 17;
		NL1i5Mnf8jPGhxIDc9Dv nL1i5Mnf8jPGhxIDc9Dv = default(NL1i5Mnf8jPGhxIDc9Dv);
		GZHRennHuoVU02hLg991 gZHRennHuoVU02hLg = default(GZHRennHuoVU02hLg991);
		XCcQXynn56uUBMUiiwNp xCcQXynn56uUBMUiiwNp = default(XCcQXynn56uUBMUiiwNp);
		long num5 = default(long);
		pKXgcNn9bLV0wVLYFwxS pKXgcNn9bLV0wVLYFwxS = default(pKXgcNn9bLV0wVLYFwxS);
		I0xHaV9hWE00eUtcW1Zm i0xHaV9hWE00eUtcW1Zm = default(I0xHaV9hWE00eUtcW1Zm);
		double num4 = default(double);
		Side side = default(Side);
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action;
				Action<j3bgDY9gV2i9bttJ1fiQ> action2;
				Action<j3bgDY9gV2i9bttJ1fiQ> action3;
				Action<j3bgDY9gV2i9bttJ1fiQ> action4;
				Action<j3bgDY9gV2i9bttJ1fiQ> action5;
				switch (num2)
				{
				case 5:
					nL1i5Mnf8jPGhxIDc9Dv = KxStfWb7T2E5q5UwKyFY(gZHRennHuoVU02hLg, mouseX, mouseY);
					switch (nL1i5Mnf8jPGhxIDc9Dv)
					{
					case NL1i5Mnf8jPGhxIDc9Dv.Sell:
						break;
					case (NL1i5Mnf8jPGhxIDc9Dv)5:
					case (NL1i5Mnf8jPGhxIDc9Dv)6:
						goto IL_0204;
					case (NL1i5Mnf8jPGhxIDc9Dv)7:
						goto IL_0433;
					default:
						goto IL_04bf;
					case (NL1i5Mnf8jPGhxIDc9Dv)4:
						goto IL_04d5;
					case NL1i5Mnf8jPGhxIDc9Dv.Buy:
						goto IL_05a1;
					case (NL1i5Mnf8jPGhxIDc9Dv)3:
						goto IL_0806;
					}
					if (changedButton == MouseButton.Left)
					{
						xCcQXynn56uUBMUiiwNp = YxCAYcb7ya27d0HkquUd(gZHRennHuoVU02hLg);
						num2 = 7;
						continue;
					}
					goto case 32;
				case 17:
					_ = 2;
					num2 = 16;
					continue;
				case 21:
					if (num5 != 0L)
					{
						num2 = 26;
						continue;
					}
					goto case 5;
				case 8:
				case 10:
				case 12:
				case 18:
				case 23:
				case 25:
				case 29:
					return true;
				case 15:
					this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)dHhjXEb7VLTr267RKDk8(gZHRennHuoVU02hLg.Price));
					goto case 8;
				case 36:
					goto IL_0204;
				case 2:
				case 34:
				{
					Action<j3bgDY9gV2i9bttJ1fiQ> action6 = this.Command;
					if (action6 == null)
					{
						num = 15;
						break;
					}
					action6(j3bgDY9gV2i9bttJ1fiQ.pr39RG1Z4ax(gZHRennHuoVU02hLg.Price));
					goto case 15;
				}
				case 35:
				{
					SEGDEsnHBKdiAgFQRmSf sEGDEsnHBKdiAgFQRmSf = base.DomView;
					kTmmBunfuPbML2TVcI4C kTmmBunfuPbML2TVcI4C = new kTmmBunfuPbML2TVcI4C();
					IRHn8Ab7mtnGXqERjoX5(kTmmBunfuPbML2TVcI4C, pKXgcNn9bLV0wVLYFwxS);
					kTmmBunfuPbML2TVcI4C.GEln9fDEQVJ(i0xHaV9hWE00eUtcW1Zm.Price);
					JdsDGOb7htLlL0QHvHOu(kTmmBunfuPbML2TVcI4C, i0xHaV9hWE00eUtcW1Zm.Price);
					kTmmBunfuPbML2TVcI4C.Side = xWnt7eb7rAtQ92BFJYw1(i0xHaV9hWE00eUtcW1Zm);
					kTmmBunfuPbML2TVcI4C.Quantity = SiXJMnb7wQxEY9eDV8t9(i0xHaV9hWE00eUtcW1Zm);
					sEGDEsnHBKdiAgFQRmSf.EjvnHcjPSff(kTmmBunfuPbML2TVcI4C);
					num2 = 22;
					continue;
				}
				case 26:
					if ((Keyboard.Modifiers & ModifierKeys.Alt) == 0)
					{
						goto case 5;
					}
					num4 = (double)Math.Abs(num5) * base.DataProvider.Symbol.SizeStep;
					num2 = 5;
					continue;
				case 31:
					if (i0xHaV9hWE00eUtcW1Zm.Side != side)
					{
						num2 = 20;
						continue;
					}
					goto IL_0367;
				case 13:
					xCcQXynn56uUBMUiiwNp = YxCAYcb7ya27d0HkquUd(gZHRennHuoVU02hLg);
					switch (xCcQXynn56uUBMUiiwNp)
					{
					case XCcQXynn56uUBMUiiwNp.Buy:
					case (XCcQXynn56uUBMUiiwNp)3:
					case (XCcQXynn56uUBMUiiwNp)5:
					case (XCcQXynn56uUBMUiiwNp)6:
						this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.lHo9gKTVT6f(num3, num4));
						break;
					case XCcQXynn56uUBMUiiwNp.Sell:
					case (XCcQXynn56uUBMUiiwNp)4:
					case (XCcQXynn56uUBMUiiwNp)7:
						goto IL_0715;
					}
					goto case 8;
				case 20:
					pKXgcNn9bLV0wVLYFwxS = (pKXgcNn9bLV0wVLYFwxS)3;
					i0xHaV9hWE00eUtcW1Zm = (I0xHaV9hWE00eUtcW1Zm)Aw9p31b7K2NsGBtPT2Uc(vM9qvQb7CyrQIsYapUwt(base.DataProvider), OrderGroup.Trigger, gZHRennHuoVU02hLg.Price);
					goto IL_0367;
				case 4:
					num5 = ((CoPfjK9hF3ASs5TbM8OK)lOhycYb7UqMIolRKaBUa(base.DataProvider.d73l9JpDb23)).PositionSize;
					num2 = 21;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					goto IL_0433;
				case 14:
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.GLY9g8Zh5EP(num3, num4));
					goto case 8;
				case 16:
					switch (changedButton)
					{
					case MouseButton.Middle:
						ScrollCenter();
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
						{
							num2 = 19;
						}
						continue;
					default:
						num2 = 24;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
						{
							num2 = 13;
						}
						continue;
					case MouseButton.Left:
						break;
					}
					goto case 6;
				case 37:
					if (gZHRennHuoVU02hLg != null && YKvn20ovlqW == rRU9qon9wK1uuIVJk37m.None)
					{
						if (changedButton == MouseButton.Left)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
							{
								num2 = 0;
							}
							continue;
						}
						if (changedButton == MouseButton.Right)
						{
							goto default;
						}
					}
					return false;
				case 33:
					goto IL_04d5;
				case 30:
					i0xHaV9hWE00eUtcW1Zm = ((t4J54f97Q2MUX30RSwuQ)vM9qvQb7CyrQIsYapUwt(base.DataProvider)).xoT976PMTbM(OrderGroup.MarketAndLimit, gZHRennHuoVU02hLg.Price);
					num2 = 9;
					continue;
				case 3:
					goto IL_052e;
				case 19:
					return true;
				case 9:
					if (i0xHaV9hWE00eUtcW1Zm != null && xWnt7eb7rAtQ92BFJYw1(i0xHaV9hWE00eUtcW1Zm) == side)
					{
						goto IL_0367;
					}
					pKXgcNn9bLV0wVLYFwxS = (pKXgcNn9bLV0wVLYFwxS)2;
					i0xHaV9hWE00eUtcW1Zm = ((t4J54f97Q2MUX30RSwuQ)vM9qvQb7CyrQIsYapUwt(base.DataProvider)).xoT976PMTbM(OrderGroup.StopAndStopLimit, gZHRennHuoVU02hLg.Price);
					if (i0xHaV9hWE00eUtcW1Zm != null)
					{
						num2 = 31;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 20;
				case 6:
					TDCn2zMGl1I = true;
					num2 = 27;
					continue;
				case 24:
				case 27:
					gZHRennHuoVU02hLg = base.DomView.wL6nHNI5Ynd(PhBn2bdb7Hn(mouseX, mouseY));
					num2 = 37;
					continue;
				default:
					num3 = oQMl6sb7I3ShMp018cOK(gZHRennHuoVU02hLg) * base.DataProvider.UJElnHayjot;
					num4 = (((MarketSettings)l9gtCtb7Wf17vANhfxVh(mdSn2fLSGY3)).ExecuteInQuoteCurrency ? ((MarketSettings)l9gtCtb7Wf17vANhfxVh(mdSn2fLSGY3)).CurrentPreset.QuoteSize : DIQK5vb7tF81VEQ1GGLv(mdSn2fLSGY3.MarketSettings.CurrentPreset));
					num = 4;
					break;
				case 22:
					e9mn2TNtDNK(_0020: true);
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					switch (xCcQXynn56uUBMUiiwNp)
					{
					case XCcQXynn56uUBMUiiwNp.Buy:
					case (XCcQXynn56uUBMUiiwNp)3:
					case (XCcQXynn56uUBMUiiwNp)6:
						goto IL_052e;
					case XCcQXynn56uUBMUiiwNp.Sell:
					case (XCcQXynn56uUBMUiiwNp)4:
					case (XCcQXynn56uUBMUiiwNp)5:
					case (XCcQXynn56uUBMUiiwNp)7:
						goto IL_0778;
					}
					goto case 8;
				case 11:
					goto IL_0715;
				case 28:
					goto IL_0778;
				case 32:
					{
						this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.SkY9guXe8vg(num3, num4));
						goto case 8;
					}
					IL_0778:
					action = this.Command;
					if (action == null)
					{
						goto case 8;
					}
					action(j3bgDY9gV2i9bttJ1fiQ.xCb9gPlN9Ao(num3, num4));
					num2 = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
					{
						num2 = 15;
					}
					continue;
					IL_0715:
					action2 = this.Command;
					if (action2 == null)
					{
						num2 = 10;
						continue;
					}
					action2(j3bgDY9gV2i9bttJ1fiQ.nnW9gh7VonN(num3, num4));
					num2 = 29;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
					{
						num2 = 2;
					}
					continue;
					IL_05a1:
					if (changedButton == MouseButton.Left)
					{
						num2 = 13;
						continue;
					}
					goto case 14;
					IL_0806:
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.Yox9RHE0iQV(gZHRennHuoVU02hLg.Price));
					this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)MGK3gib7ZKs3kIQekPcD(gZHRennHuoVU02hLg.Price));
					action3 = this.Command;
					if (action3 == null)
					{
						num2 = 25;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num2 = 9;
						}
						continue;
					}
					action3(j3bgDY9gV2i9bttJ1fiQ.sYu9RoYg2kO(gZHRennHuoVU02hLg.Price));
					goto case 8;
					IL_052e:
					action4 = this.Command;
					if (action4 == null)
					{
						num2 = 22;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
						{
							num2 = 23;
						}
						continue;
					}
					action4(j3bgDY9gV2i9bttJ1fiQ.Apx9gFiZ2i4(num3, num4));
					goto case 8;
					IL_0367:
					if (i0xHaV9hWE00eUtcW1Zm != null && i0xHaV9hWE00eUtcW1Zm.Side == side)
					{
						YKvn20ovlqW = rRU9qon9wK1uuIVJk37m.Order;
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 8;
					IL_04d5:
					action5 = this.Command;
					if (action5 == null)
					{
						num2 = 2;
						continue;
					}
					action5(j3bgDY9gV2i9bttJ1fiQ.GRZ9RfRIJKj(oQMl6sb7I3ShMp018cOK(gZHRennHuoVU02hLg)));
					num2 = 34;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
					{
						num2 = 6;
					}
					continue;
					IL_0204:
					side = ((nL1i5Mnf8jPGhxIDc9Dv != (NL1i5Mnf8jPGhxIDc9Dv)5) ? Side.Sell : Side.Buy);
					pKXgcNn9bLV0wVLYFwxS = (pKXgcNn9bLV0wVLYFwxS)1;
					num2 = 30;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 11;
					}
					continue;
					IL_04bf:
					num2 = 12;
					continue;
					IL_0433:
					iSGn0pIJlCa(num3, gZHRennHuoVU02hLg.Price);
					goto case 8;
				}
				break;
			}
		}
	}

	public void pa5n07JND8W()
	{
		wMeBGPb78yo79Vmfxb96(mdSn2fLSGY3, IbwHJAb77fB3bKCcPnQM());
		int num;
		if (YKvn20ovlqW == rRU9qon9wK1uuIVJk37m.Order)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
			{
				num = 4;
			}
			goto IL_0009;
		}
		goto IL_0072;
		IL_0009:
		kTmmBunfuPbML2TVcI4C kTmmBunfuPbML2TVcI4C = default(kTmmBunfuPbML2TVcI4C);
		pKXgcNn9bLV0wVLYFwxS pKXgcNn9bLV0wVLYFwxS = default(pKXgcNn9bLV0wVLYFwxS);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
				if (kTmmBunfuPbML2TVcI4C.Price != kTmmBunfuPbML2TVcI4C.pQXn9HTcCIl())
				{
					pKXgcNn9bLV0wVLYFwxS = kTmmBunfuPbML2TVcI4C.Type;
					num = 7;
					continue;
				}
				goto case 1;
			case 0:
				return;
			case 6:
				break;
			case 3:
				TDCn2zMGl1I = false;
				num = 2;
				continue;
			case 7:
				switch (pKXgcNn9bLV0wVLYFwxS)
				{
				case (pKXgcNn9bLV0wVLYFwxS)2:
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.eHC9RiUNaZ4(drAHfAb7POsLhhgtxT8Z(kTmmBunfuPbML2TVcI4C), kTmmBunfuPbML2TVcI4C.Price));
					break;
				case (pKXgcNn9bLV0wVLYFwxS)1:
				{
					Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
					if (action == null)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
						{
							num = 1;
						}
						continue;
					}
					action(j3bgDY9gV2i9bttJ1fiQ.H5B9RaqOZAE(kTmmBunfuPbML2TVcI4C.pQXn9HTcCIl(), kTmmBunfuPbML2TVcI4C.Price));
					break;
				}
				case (pKXgcNn9bLV0wVLYFwxS)3:
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.Q3V9Rl1Suni(kTmmBunfuPbML2TVcI4C.pQXn9HTcCIl(), kTmmBunfuPbML2TVcI4C.Price));
					break;
				}
				goto case 1;
			case 1:
				base.DomView.EjvnHcjPSff(null);
				num = 6;
				continue;
			case 2:
				e9mn2TNtDNK(_0020: true);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
				{
					num = 0;
				}
				continue;
			case 4:
				kTmmBunfuPbML2TVcI4C = (kTmmBunfuPbML2TVcI4C)W7GM2Bb7AMXVYMXy1yfF(base.DomView);
				num = 5;
				continue;
			}
			break;
		}
		goto IL_0072;
		IL_0072:
		YKvn20ovlqW = rRU9qon9wK1uuIVJk37m.None;
		num = 3;
		goto IL_0009;
	}

	public void n9Ln08YoyCu(int P_0)
	{
		Scroll(P_0 / 2);
	}

	public void SLqn0ABch7q(int P_0, int P_1)
	{
		iGgn2PhthNx = P_0;
		F83n2JYQMPm = P_1;
		if (base.DataProvider == null)
		{
			return;
		}
		int num;
		if (zVin22GIRjO - 2 >= iGgn2PhthNx)
		{
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_018e;
		IL_01e2:
		if (YKvn20ovlqW == rRU9qon9wK1uuIVJk37m.None)
		{
			int num2 = 8;
			num = num2;
			goto IL_0009;
		}
		goto IL_0217;
		IL_013c:
		GZHRennHuoVU02hLg991 gZHRennHuoVU02hLg = (GZHRennHuoVU02hLg991)VsQSayb7JUdVYW1vcxma(base.DomView, PhBn2bdb7Hn(iGgn2PhthNx, F83n2JYQMPm));
		if (gZHRennHuoVU02hLg != null && KxStfWb7T2E5q5UwKyFY(gZHRennHuoVU02hLg, iGgn2PhthNx, F83n2JYQMPm) != NL1i5Mnf8jPGhxIDc9Dv.None)
		{
			mdSn2fLSGY3.Cursor = Cursors.Hand;
		}
		goto IL_0217;
		IL_0038:
		if (YKvn20ovlqW == rRU9qon9wK1uuIVJk37m.Order)
		{
			if (base.DomView.GHHnHXRtp7p() != null)
			{
				base.DomView.GHHnHXRtp7p().Price = Bk8n2D6jjnJ(F83n2JYQMPm);
				num = 6;
			}
			else
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_01e2;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 3:
				break;
			case 7:
				if (F83n2JYQMPm < nc1n2HRp8k6 + 2)
				{
					num = 5;
					continue;
				}
				break;
			case 8:
				mdSn2fLSGY3.Cursor = Cursors.Arrow;
				num = 4;
				continue;
			default:
				nc1n2HRp8k6 = F83n2JYQMPm;
				e9mn2TNtDNK(_0020: true);
				return;
			case 4:
				goto IL_013c;
			case 1:
				goto IL_018e;
			case 2:
			case 6:
				goto IL_01e2;
			}
			break;
		}
		goto IL_0038;
		IL_018e:
		if (iGgn2PhthNx < zVin22GIRjO + 2 && nc1n2HRp8k6 - 2 < F83n2JYQMPm)
		{
			num = 7;
			goto IL_0009;
		}
		goto IL_0038;
		IL_0217:
		zVin22GIRjO = iGgn2PhthNx;
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	public void U8Bn0PdM3CO()
	{
		if (F83n2JYQMPm != 0)
		{
			goto IL_0098;
		}
		if (iGgn2PhthNx == 0)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				e9mn2TNtDNK(_0020: true);
				return;
			case 1:
				UPlRR3b7FYkNNgApFMuy(base.DomView, null);
				m3sn2uukYsB = true;
				num = 3;
				continue;
			case 2:
				F83n2JYQMPm = 0;
				YKvn20ovlqW = rRU9qon9wK1uuIVJk37m.None;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
				{
					num = 1;
				}
				continue;
			}
			break;
		}
		goto IL_0098;
		IL_0098:
		iGgn2PhthNx = 0;
		num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
		{
			num = 2;
		}
		goto IL_0009;
	}

	protected void urVn0JXsJvN(MouseButtonEventArgs P_0)
	{
	}

	public void wc5n0FHvFlo(long P_0)
	{
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ((t4J54f97Q2MUX30RSwuQ)vM9qvQb7CyrQIsYapUwt(base.DataProvider)).Position;
		if (coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
		{
			coPfjK9hF3ASs5TbM8OK.U1s9wNKsKAb(base.DataProvider, P_0, base.Settings.TradeSettings.TakeProfitOffset, out var _);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
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

	public void RMLn03F6VUa(long P_0)
	{
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = base.DataProvider.d73l9JpDb23.Position;
		if (coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
		{
			coPfjK9hF3ASs5TbM8OK.Dy59wYpU9Vv(base.DataProvider, P_0, base.Settings.TradeSettings.StopLossOffset, out var _);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
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

	private void iSGn0pIJlCa(long P_0, long P_1)
	{
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = (CoPfjK9hF3ASs5TbM8OK)lOhycYb7UqMIolRKaBUa(base.DataProvider.d73l9JpDb23);
		int num;
		daEwNq9FXerRxid1xGMa daEwNq9FXerRxid1xGMa = default(daEwNq9FXerRxid1xGMa);
		if (coPfjK9hF3ASs5TbM8OK.PositionSize == 0L)
		{
			num = 2;
		}
		else
		{
			if (coPfjK9hF3ASs5TbM8OK.Dww9wBNheQd(P_0))
			{
				return;
			}
			if (coPfjK9hF3ASs5TbM8OK.Le39w5yjwNE(P_0))
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
				{
					num = 0;
				}
			}
			else
			{
				daEwNq9FXerRxid1xGMa = base.DataProvider.OpZl98KAYgk();
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
				{
					num = 5;
				}
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				return;
			case 6:
				return;
			case 4:
				return;
			case 0:
				return;
			case 2:
				return;
			case 5:
				if (l6rIJhb732YDLOTj6KC8(coPfjK9hF3ASs5TbM8OK) <= 0)
				{
					if (P_1 < daEwNq9FXerRxid1xGMa.AskPrice)
					{
						if (P_1 >= daEwNq9FXerRxid1xGMa.AskPrice)
						{
							return;
						}
						wc5n0FHvFlo(P_0);
						num = 3;
					}
					else
					{
						RMLn03F6VUa(P_0);
						num = 6;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
						{
							num = 0;
						}
					}
				}
				else if (P_1 > daEwNq9FXerRxid1xGMa.BidPrice)
				{
					wc5n0FHvFlo(P_0);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
					{
						num = 1;
					}
				}
				else
				{
					if (P_1 > VhJFy2b7py2JYqyaB9QE(daEwNq9FXerRxid1xGMa))
					{
						return;
					}
					RMLn03F6VUa(P_0);
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num = 0;
					}
				}
				break;
			case 1:
				return;
			}
		}
	}

	static Oa4jgjn0hS56oJy1ww2C()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool SWQ8qFb7OIknDYNqYmRc()
	{
		return gBP3XTb7MZbRXf9tAxMH == null;
	}

	internal static Oa4jgjn0hS56oJy1ww2C DRVRdob7qN7P0tqQpjmg()
	{
		return gBP3XTb7MZbRXf9tAxMH;
	}

	internal static long oQMl6sb7I3ShMp018cOK(object P_0)
	{
		return ((GZHRennHuoVU02hLg991)P_0).Price;
	}

	internal static object l9gtCtb7Wf17vANhfxVh(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).MarketSettings;
	}

	internal static double DIQK5vb7tF81VEQ1GGLv(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).Size;
	}

	internal static object lOhycYb7UqMIolRKaBUa(object P_0)
	{
		return ((t4J54f97Q2MUX30RSwuQ)P_0).Position;
	}

	internal static NL1i5Mnf8jPGhxIDc9Dv KxStfWb7T2E5q5UwKyFY(object P_0, int P_1, int P_2)
	{
		return ((GZHRennHuoVU02hLg991)P_0).gVpnf9mIvce(P_1, P_2);
	}

	internal static XCcQXynn56uUBMUiiwNp YxCAYcb7ya27d0HkquUd(object P_0)
	{
		return ((GZHRennHuoVU02hLg991)P_0).wecnfnvgyGy();
	}

	internal static object MGK3gib7ZKs3kIQekPcD(long P_0)
	{
		return j3bgDY9gV2i9bttJ1fiQ.mPX9RnyALTk(P_0);
	}

	internal static object dHhjXEb7VLTr267RKDk8(long P_0)
	{
		return j3bgDY9gV2i9bttJ1fiQ.VAt9RvmdQFD(P_0);
	}

	internal static object vM9qvQb7CyrQIsYapUwt(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).d73l9JpDb23;
	}

	internal static Side xWnt7eb7rAtQ92BFJYw1(object P_0)
	{
		return ((I0xHaV9hWE00eUtcW1Zm)P_0).Side;
	}

	internal static object Aw9p31b7K2NsGBtPT2Uc(object P_0, OrderGroup P_1, long P_2)
	{
		return ((t4J54f97Q2MUX30RSwuQ)P_0).xoT976PMTbM(P_1, P_2);
	}

	internal static void IRHn8Ab7mtnGXqERjoX5(object P_0, pKXgcNn9bLV0wVLYFwxS P_1)
	{
		((kTmmBunfuPbML2TVcI4C)P_0).Type = P_1;
	}

	internal static void JdsDGOb7htLlL0QHvHOu(object P_0, long P_1)
	{
		((kTmmBunfuPbML2TVcI4C)P_0).Price = P_1;
	}

	internal static long SiXJMnb7wQxEY9eDV8t9(object P_0)
	{
		return ((I0xHaV9hWE00eUtcW1Zm)P_0).Quantity;
	}

	internal static object IbwHJAb77fB3bKCcPnQM()
	{
		return Cursors.Arrow;
	}

	internal static void wMeBGPb78yo79Vmfxb96(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Cursor = (Cursor)P_1;
	}

	internal static object W7GM2Bb7AMXVYMXy1yfF(object P_0)
	{
		return ((SEGDEsnHBKdiAgFQRmSf)P_0).GHHnHXRtp7p();
	}

	internal static long drAHfAb7POsLhhgtxT8Z(object P_0)
	{
		return ((kTmmBunfuPbML2TVcI4C)P_0).pQXn9HTcCIl();
	}

	internal static object VsQSayb7JUdVYW1vcxma(object P_0, long P_1)
	{
		return ((SEGDEsnHBKdiAgFQRmSf)P_0).wL6nHNI5Ynd(P_1);
	}

	internal static void UPlRR3b7FYkNNgApFMuy(object P_0, object P_1)
	{
		((SEGDEsnHBKdiAgFQRmSf)P_0).EjvnHcjPSff((kTmmBunfuPbML2TVcI4C)P_1);
	}

	internal static long l6rIJhb732YDLOTj6KC8(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionSize;
	}

	internal static long VhJFy2b7py2JYqyaB9QE(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).BidPrice;
	}
}
