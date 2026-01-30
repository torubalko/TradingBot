using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using LgG2iaajiPaPidMEDVBM;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using XPZd6XG3i7VywBHCqjR;

namespace qlYYgiGUrPB4hUPGZhy;

internal sealed class qNUyidGtHr87QVuWB9h : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly ObservableCollection<e21rPRGFkaM5W9IlKjo> dWmG8sU5RO;

	private readonly Dictionary<string, e21rPRGFkaM5W9IlKjo> Gn1GAXsREb;

	private e21rPRGFkaM5W9IlKjo HUMGP3rp0I;

	private bool kKuGJxbPBc;

	private static qNUyidGtHr87QVuWB9h CNNCqqlhVYBb6dK2JKGl;

	public ObservableCollection<e21rPRGFkaM5W9IlKjo> Positions
	{
		[CompilerGenerated]
		get
		{
			return dWmG8sU5RO;
		}
	}

	public e21rPRGFkaM5W9IlKjo SelectedPosition
	{
		get
		{
			return HUMGP3rp0I;
		}
		set
		{
			if (!object.Equals(e21rPRGFkaM5W9IlKjo, HUMGP3rp0I))
			{
				HUMGP3rp0I = e21rPRGFkaM5W9IlKjo;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371623461));
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225830203));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
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
	}

	public bool CanClose
	{
		get
		{
			if (SelectedPosition != null)
			{
				return Gu2GTvkIdQ((Position)iq3XT7lhKGD6FGKPrUB1(SelectedPosition));
			}
			return false;
		}
	}

	public bool OnlyOpenPositions
	{
		get
		{
			return kKuGJxbPBc;
		}
		set
		{
			if (flag == kKuGJxbPBc)
			{
				return;
			}
			kKuGJxbPBc = flag;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					cv1GZ9KPC5();
					return;
				}
				JZYHkZsWiJ6((string)QttMeRlhmY012SvqDZHp(-342738082 ^ -342746206));
				SelectedPosition = null;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
				{
					num = 1;
				}
			}
		}
	}

	public qNUyidGtHr87QVuWB9h()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		Gn1GAXsREb = new Dictionary<string, e21rPRGFkaM5W9IlKjo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
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
			dWmG8sU5RO = new ObservableCollection<e21rPRGFkaM5W9IlKjo>();
			DataManager.OnPosition += delegate(Position P_0)
			{
				int num2 = 2;
				int num3 = num2;
				e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo = default(e21rPRGFkaM5W9IlKjo);
				while (true)
				{
					switch (num3)
					{
					case 1:
					{
						e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo2 = Gn1GAXsREb[(string)FVfeyTlhpa9YpVa1Y28B(P_0)];
						OSTeRslhu2nlVOsq6hQk(e21rPRGFkaM5W9IlKjo2, P_0);
						e21rPRGFkaM5W9IlKjo2.IsVisible = Filter(e21rPRGFkaM5W9IlKjo2);
						return;
					}
					case 2:
						if (Gn1GAXsREb.ContainsKey(P_0.PositionID))
						{
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
							{
								num3 = 1;
							}
						}
						else
						{
							e21rPRGFkaM5W9IlKjo = new e21rPRGFkaM5W9IlKjo(P_0);
							t86oSrlhzUtZjZ7eoG1E(e21rPRGFkaM5W9IlKjo, Filter(e21rPRGFkaM5W9IlKjo));
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
							{
								num3 = 0;
							}
						}
						break;
					default:
						Gn1GAXsREb.Add(P_0.PositionID, e21rPRGFkaM5W9IlKjo);
						num3 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
						{
							num3 = 2;
						}
						break;
					case 3:
						Positions.Add(e21rPRGFkaM5W9IlKjo);
						return;
					}
				}
			};
			DataManager.OnUpdateFilters += delegate
			{
				cv1GZ9KPC5();
			};
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
			{
				num = 0;
			}
		}
	}

	public bool Gu2GTvkIdQ(Position P_0)
	{
		return X5DqpYlhhoJnDqPCxdYj(P_0) != 0;
	}

	public void ClosePosition(Position position)
	{
		if (X5DqpYlhhoJnDqPCxdYj(position) == 0L)
		{
			return;
		}
		double num = (position.Symbol.IsDenomination ? ((double)position.Quantity * position.Symbol.ContractValue) : ((double)position.Quantity));
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
		{
			num2 = 0;
		}
		Order order = default(Order);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (bbrp54lhAqEZZCuF4fd3(((SymbolBase)BcT0Dulh8XINSBkFZksO(position)).Exchange))
				{
					num2 = 2;
					continue;
				}
				goto IL_001f;
			case 2:
				{
					SCMiPslhP9T3aCplQVkx(order, position.PosNumID.ToString());
					goto IL_001f;
				}
				IL_001f:
				DataManager.ClientPlaceOrder(order);
				return;
			}
			Order obj = new Order(position.Symbol, position.Account)
			{
				Type = OrderType.Market,
				Quantity = LYDOqglhw1TlUHlM0es9((long)num),
				Side = ((position.Quantity >= 0) ? Side.Sell : Side.Buy),
				PosClose = true
			};
			GX2sSllh74b7Jkc4Fyta(obj, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839650944));
			order = obj;
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
			{
				num2 = 1;
			}
		}
	}

	public void SToGye2XOX()
	{
		if (SelectedPosition != null)
		{
			ClosePosition((Position)iq3XT7lhKGD6FGKPrUB1(SelectedPosition));
		}
	}

	public void CloseAllPositions()
	{
		IEnumerator<e21rPRGFkaM5W9IlKjo> enumerator = Positions.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				e21rPRGFkaM5W9IlKjo current = enumerator.Current;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ClosePosition(current.Position);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
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

	public bool Filter(object obj)
	{
		if (!(obj is e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo))
		{
			return false;
		}
		if (!vfL39ZlhF3DPwqA0U419(gdYp9mlhJDU8jrTy8Ykt(e21rPRGFkaM5W9IlKjo.Position)))
		{
			return false;
		}
		if (!OnlyOpenPositions)
		{
			return true;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => FHuGTYlh3PIHOuwJa4hN(e21rPRGFkaM5W9IlKjo.Side, Resources.PositionSideFlat), 
		};
	}

	private void cv1GZ9KPC5()
	{
		foreach (e21rPRGFkaM5W9IlKjo item in Positions)
		{
			item.IsVisible = Filter(item);
		}
	}

	[CompilerGenerated]
	private void qWvGVFYdTO(Position P_0)
	{
		int num = 2;
		int num2 = num;
		e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo = default(e21rPRGFkaM5W9IlKjo);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				e21rPRGFkaM5W9IlKjo e21rPRGFkaM5W9IlKjo2 = Gn1GAXsREb[(string)FVfeyTlhpa9YpVa1Y28B(P_0)];
				OSTeRslhu2nlVOsq6hQk(e21rPRGFkaM5W9IlKjo2, P_0);
				e21rPRGFkaM5W9IlKjo2.IsVisible = Filter(e21rPRGFkaM5W9IlKjo2);
				return;
			}
			case 2:
				if (Gn1GAXsREb.ContainsKey(P_0.PositionID))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
					{
						num2 = 1;
					}
					break;
				}
				e21rPRGFkaM5W9IlKjo = new e21rPRGFkaM5W9IlKjo(P_0);
				t86oSrlhzUtZjZ7eoG1E(e21rPRGFkaM5W9IlKjo, Filter(e21rPRGFkaM5W9IlKjo));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Gn1GAXsREb.Add(P_0.PositionID, e21rPRGFkaM5W9IlKjo);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				Positions.Add(e21rPRGFkaM5W9IlKjo);
				return;
			}
		}
	}

	[CompilerGenerated]
	private void JPEGC6bxTk()
	{
		cv1GZ9KPC5();
	}

	static qNUyidGtHr87QVuWB9h()
	{
		XywZRxlw0wdYDbNSMANC();
	}

	internal static bool dehbhrlhC0w9kvoOHLNX()
	{
		return CNNCqqlhVYBb6dK2JKGl == null;
	}

	internal static qNUyidGtHr87QVuWB9h Csr8AglhrGpNdgLOoLBA()
	{
		return CNNCqqlhVYBb6dK2JKGl;
	}

	internal static object iq3XT7lhKGD6FGKPrUB1(object P_0)
	{
		return ((e21rPRGFkaM5W9IlKjo)P_0).Position;
	}

	internal static object QttMeRlhmY012SvqDZHp(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static long X5DqpYlhhoJnDqPCxdYj(object P_0)
	{
		return ((Position)P_0).Quantity;
	}

	internal static long LYDOqglhw1TlUHlM0es9(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static void GX2sSllh74b7Jkc4Fyta(object P_0, object P_1)
	{
		((Order)P_0).PlaceInitiator = (string)P_1;
	}

	internal static object BcT0Dulh8XINSBkFZksO(object P_0)
	{
		return ((Position)P_0).Symbol;
	}

	internal static bool bbrp54lhAqEZZCuF4fd3(object P_0)
	{
		return YtFfukajaSr17E52hP4h.d59ajl8LAnH((string)P_0);
	}

	internal static void SCMiPslhP9T3aCplQVkx(object P_0, object P_1)
	{
		((Order)P_0).OrderID = (string)P_1;
	}

	internal static object gdYp9mlhJDU8jrTy8Ykt(object P_0)
	{
		return ((Position)P_0).Account;
	}

	internal static bool vfL39ZlhF3DPwqA0U419(object P_0)
	{
		return DataManager.FilterAccount((Account)P_0);
	}

	internal static bool FHuGTYlh3PIHOuwJa4hN(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object FVfeyTlhpa9YpVa1Y28B(object P_0)
	{
		return ((Position)P_0).PositionID;
	}

	internal static void OSTeRslhu2nlVOsq6hQk(object P_0, object P_1)
	{
		((e21rPRGFkaM5W9IlKjo)P_0).j5rGpvuy43((Position)P_1);
	}

	internal static void t86oSrlhzUtZjZ7eoG1E(object P_0, bool P_1)
	{
		((e21rPRGFkaM5W9IlKjo)P_0).IsVisible = P_1;
	}

	internal static void XywZRxlw0wdYDbNSMANC()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
