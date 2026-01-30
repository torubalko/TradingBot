using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Ax09UQ9q72dBb9cPuRKl;
using cPL0LPniWgA7dNYWcgpS;
using DFYYZy9qrXLVPKmhaMVk;
using ECOEgqlSad8NUJZ2Dr9n;
using enjrAF9IlFbLgy9Wm8OR;
using Ha9I1wna0XjsKnZiPJll;
using jS3Y2j9pTQRy0FnOknFG;
using NsWD4W9miMxRbFU3fsu9;
using s8CVoTnYOlGDs7vDiB5f;
using TigerTrade.Core.UI.Commands;
using TuAMtrl1Nd3XoZQQUXf0;
using W7vgMFnvUmmoQloCDPpC;

namespace JImXdX9qzB6OVpW11M5Z;

internal class zlrWq79quYbbxDu11FYh : hj2VKQ9IiwjgOwjEJctO
{
	private readonly jjKtVJ9pUSOpdg38tqnP CMZ9IoYwNYd;

	private readonly Stack<MX6Bnr9qCkKvJtdML9PK> UyJ9IvS8PVJ;

	private k97CdK9qw9ENfNwOy1dZ jEa9IBUdQGp;

	[CompilerGenerated]
	private readonly ICommand dW59IaIsttH;

	internal static zlrWq79quYbbxDu11FYh jybxMWbOYQGSo5E6JB7a;

	public ICommand ZoomOutCommand
	{
		[CompilerGenerated]
		get
		{
			return dW59IaIsttH;
		}
	}

	public bool CanZoomOut => UyJ9IvS8PVJ.Count > 0;

	public zlrWq79quYbbxDu11FYh(jjKtVJ9pUSOpdg38tqnP P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		UyJ9IvS8PVJ = new Stack<MX6Bnr9qCkKvJtdML9PK>();
		base._002Ector();
		CMZ9IoYwNYd = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				dW59IaIsttH = new RelayCommand(delegate
				{
					ZoomOut();
				}, (object obj) => CanZoomOut);
				return;
			}
			iWH9I5laPHK(Cursors.Cross);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void IpJl9W04yF8()
	{
		Clear();
	}

	public void DfP9I0v7RKs()
	{
		QjhXRXbOBlnXJN9d8RuZ(UyJ9IvS8PVJ);
		Clear();
	}

	private void Clear()
	{
		ephVEHbOalydPpR7O5vx(CMZ9IoYwNYd);
		jEa9IBUdQGp = null;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6246483));
	}

	private bool Dx09I2O8CNj(MX6Bnr9qCkKvJtdML9PK P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Math.Abs(P_0.SnC9qhMHxuY - P_0.Jhp9qmUDeRN) / ((ypqMIv9maFM0tRwF0xMh)TlI4qEbOitS0LFChjKPq(CMZ9IoYwNYd.Chart)).Step < 2.0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (P_0.ColumnWidth < qu3mltbOlEZeLEa1xVYv(CMZ9IoYwNYd.Chart) || P_0.ColumnWidth > OM0hkrbO4JsQvaYBLGfA(CMZ9IoYwNYd.Chart))
				{
					return false;
				}
				return true;
			default:
				return false;
			}
		}
	}

	protected override void rmil9tyBYTG()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				CMZ9IoYwNYd.Cursor = drS9I1RKH6U();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				CMZ9IoYwNYd.iay9ufvQSxe(this);
				jEa9IBUdQGp.bwi9I4g8dqQ();
				return;
			case 3:
				if (jEa9IBUdQGp != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num2 = 2;
					}
					break;
				}
				jEa9IBUdQGp = new k97CdK9qw9ENfNwOy1dZ(CMZ9IoYwNYd.Chart);
				elApSZbODHZNHgAJFAmG(jEa9IBUdQGp, (EventHandler)delegate
				{
					int num3 = 3;
					MX6Bnr9qCkKvJtdML9PK mX6Bnr9qCkKvJtdML9PK = default(MX6Bnr9qCkKvJtdML9PK);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								mX6Bnr9qCkKvJtdML9PK.ColumnWidth = AZJt2ubOSrbCDn3UQ2mG(CMZ9IoYwNYd.Chart);
								mX6Bnr9qCkKvJtdML9PK.Jhp9qmUDeRN = ((NMHchMnvtxgoKNmDEII2)IrpTe5bOLnAklCQkqTs4(((JWWhw2nBzBKPn08eRh08)PvGY4ebOxjaldGQmwNOu(CMZ9IoYwNYd)).jEKnaJCf32i())).I4pnBGVUykx;
								mX6Bnr9qCkKvJtdML9PK.SnC9qhMHxuY = ((vJGfm5nYMCEZFuST02my)FvKO8TbOe3wYy94l4SOc(CMZ9IoYwNYd.Chart)).ybUnYpBPWvT().O4PnBnYuFWH;
								num4 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							case 3:
								if (Dx09I2O8CNj(i474FdbO1lcFQgRftM8a(jEa9IBUdQGp)))
								{
									mX6Bnr9qCkKvJtdML9PK = new MX6Bnr9qCkKvJtdML9PK
									{
										ztw9qKf3k0T = HP0UZ2bO5RfmeGbEULg2(CMZ9IoYwNYd.Chart)
									};
									num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
									{
										num4 = 0;
									}
								}
								else
								{
									num4 = 2;
								}
								continue;
							case 5:
								Clear();
								XKh9IbDuq8F();
								num4 = 4;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
								{
									num4 = 2;
								}
								continue;
							case 4:
								return;
							case 2:
								jEa9IBUdQGp.GoZ9IDAjjop();
								return;
							}
							break;
						}
						MX6Bnr9qCkKvJtdML9PK item = mX6Bnr9qCkKvJtdML9PK;
						UyJ9IvS8PVJ.Push(item);
						SPrCm4bObSVKHpJleQj3(CMZ9IoYwNYd, jEa9IBUdQGp.y3U9q8BfCMY());
						num3 = 5;
					}
				});
				jEa9IBUdQGp.CoW9Ic5Txci(delegate
				{
					GoZ9IDAjjop();
				});
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void ZoomOut()
	{
		if (!CanZoomOut)
		{
			return;
		}
		int num;
		if (jEa9IBUdQGp == null)
		{
			MX6Bnr9qCkKvJtdML9PK mX6Bnr9qCkKvJtdML9PK = UyJ9IvS8PVJ.Pop();
			SPrCm4bObSVKHpJleQj3(CMZ9IoYwNYd, mX6Bnr9qCkKvJtdML9PK);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	public override bool u3vl9yYhQTF(vuqArBniIZpGahT6Xchg P_0)
	{
		if (P_0.sgjniTG2Rhm != null)
		{
			return Je8U9vbONZgUtF7clUjy(P_0.sgjniTG2Rhm);
		}
		return false;
	}

	public override void MouseDown(Point point)
	{
		jEa9IBUdQGp?.MouseDown(point);
	}

	public override void Hqyl9UsLXf3(Point P_0)
	{
		k97CdK9qw9ENfNwOy1dZ k97CdK9qw9ENfNwOy1dZ = jEa9IBUdQGp;
		if (k97CdK9qw9ENfNwOy1dZ != null)
		{
			OBdNNybOkD1M5dHCaZb1(k97CdK9qw9ENfNwOy1dZ, P_0);
		}
	}

	public override void Pp6l9TLphDT(Point P_0)
	{
		jEa9IBUdQGp.Pp6l9TLphDT(P_0);
	}

	[CompilerGenerated]
	private void pK59IHUvvmI(object P_0)
	{
		ZoomOut();
	}

	[CompilerGenerated]
	private bool e1x9Iftq8HJ(object P_0)
	{
		return CanZoomOut;
	}

	[CompilerGenerated]
	private void cAH9I9HxkMy(object P_0, EventArgs P_1)
	{
		int num = 3;
		MX6Bnr9qCkKvJtdML9PK mX6Bnr9qCkKvJtdML9PK = default(MX6Bnr9qCkKvJtdML9PK);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					mX6Bnr9qCkKvJtdML9PK.ColumnWidth = AZJt2ubOSrbCDn3UQ2mG(CMZ9IoYwNYd.Chart);
					mX6Bnr9qCkKvJtdML9PK.Jhp9qmUDeRN = ((NMHchMnvtxgoKNmDEII2)IrpTe5bOLnAklCQkqTs4(((JWWhw2nBzBKPn08eRh08)PvGY4ebOxjaldGQmwNOu(CMZ9IoYwNYd)).jEKnaJCf32i())).I4pnBGVUykx;
					mX6Bnr9qCkKvJtdML9PK.SnC9qhMHxuY = ((vJGfm5nYMCEZFuST02my)FvKO8TbOe3wYy94l4SOc(CMZ9IoYwNYd.Chart)).ybUnYpBPWvT().O4PnBnYuFWH;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 3:
					if (Dx09I2O8CNj(i474FdbO1lcFQgRftM8a(jEa9IBUdQGp)))
					{
						mX6Bnr9qCkKvJtdML9PK = new MX6Bnr9qCkKvJtdML9PK
						{
							ztw9qKf3k0T = HP0UZ2bO5RfmeGbEULg2(CMZ9IoYwNYd.Chart)
						};
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
					}
					continue;
				case 5:
					Clear();
					XKh9IbDuq8F();
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					return;
				case 2:
					jEa9IBUdQGp.GoZ9IDAjjop();
					return;
				}
				break;
			}
			MX6Bnr9qCkKvJtdML9PK item = mX6Bnr9qCkKvJtdML9PK;
			UyJ9IvS8PVJ.Push(item);
			SPrCm4bObSVKHpJleQj3(CMZ9IoYwNYd, jEa9IBUdQGp.y3U9q8BfCMY());
			num = 5;
		}
	}

	[CompilerGenerated]
	private void wC49InQiUnO(object P_0, EventArgs P_1)
	{
		GoZ9IDAjjop();
	}

	static zlrWq79quYbbxDu11FYh()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool kNqI3xbOoNRIAuq4Zw6O()
	{
		return jybxMWbOYQGSo5E6JB7a == null;
	}

	internal static zlrWq79quYbbxDu11FYh y2oyr7bOvrNL0h5SIKyW()
	{
		return jybxMWbOYQGSo5E6JB7a;
	}

	internal static void QjhXRXbOBlnXJN9d8RuZ(object P_0)
	{
		((Stack<MX6Bnr9qCkKvJtdML9PK>)P_0).Clear();
	}

	internal static void ephVEHbOalydPpR7O5vx(object P_0)
	{
		((jjKtVJ9pUSOpdg38tqnP)P_0).jM09u9oEiOQ();
	}

	internal static object TlI4qEbOitS0LFChjKPq(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).DataProvider;
	}

	internal static double qu3mltbOlEZeLEa1xVYv(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).KGjnazy8IA3();
	}

	internal static double OM0hkrbO4JsQvaYBLGfA(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).zDQni2rNNyg();
	}

	internal static void elApSZbODHZNHgAJFAmG(object P_0, object P_1)
	{
		((hj2VKQ9IiwjgOwjEJctO)P_0).T7r9IeVkkDo((EventHandler)P_1);
	}

	internal static void SPrCm4bObSVKHpJleQj3(object P_0, MX6Bnr9qCkKvJtdML9PK P_1)
	{
		((jjKtVJ9pUSOpdg38tqnP)P_0).ROs9uGLsLqt(P_1);
	}

	internal static bool Je8U9vbONZgUtF7clUjy(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).XXdnoI2riZU();
	}

	internal static void OBdNNybOkD1M5dHCaZb1(object P_0, Point P_1)
	{
		((hj2VKQ9IiwjgOwjEJctO)P_0).Hqyl9UsLXf3(P_1);
	}

	internal static MX6Bnr9qCkKvJtdML9PK i474FdbO1lcFQgRftM8a(object P_0)
	{
		return ((k97CdK9qw9ENfNwOy1dZ)P_0).y3U9q8BfCMY();
	}

	internal static int HP0UZ2bO5RfmeGbEULg2(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).uSinaqM80CE();
	}

	internal static double AZJt2ubOSrbCDn3UQ2mG(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).ColumnWidth;
	}

	internal static object PvGY4ebOxjaldGQmwNOu(object P_0)
	{
		return ((jjKtVJ9pUSOpdg38tqnP)P_0).Chart;
	}

	internal static object IrpTe5bOLnAklCQkqTs4(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).ybUnYpBPWvT();
	}

	internal static object FvKO8TbOe3wYy94l4SOc(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).jEKnaJCf32i();
	}
}
