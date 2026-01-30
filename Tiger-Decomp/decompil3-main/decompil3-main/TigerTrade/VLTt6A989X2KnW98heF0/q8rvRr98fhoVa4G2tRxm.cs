using System;
using ECOEgqlSad8NUJZ2Dr9n;
using QmOgjd9h4C152q15GnsF;
using TigerTrade.Chart.Data;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace VLTt6A989X2KnW98heF0;

internal sealed class q8rvRr98fhoVa4G2tRxm : IChartDeal
{
	private readonly IhHpoC9hliGX2eZqQA6k BsK98nFKkMH;

	private readonly double aFK98GTsImh;

	internal static q8rvRr98fhoVa4G2tRxm CfJbmFbCoU6Geb4MVNhk;

	public DateTime OpenTime => BsK98nFKkMH.OpenTime;

	public double OpenPrice => BsK98nFKkMH.OpenPrice;

	public DateTime CloseTime => BsK98nFKkMH.CloseTime;

	public double ClosePrice => CfGcOtbCabLwYOJAYFes(BsK98nFKkMH);

	public bool IsBuy => BsK98nFKkMH.Side == Side.Buy;

	public double Quantity => pvvyJTbCiVNoYPSUgfYc(BsK98nFKkMH);

	public double Points => BsK98nFKkMH.Points;

	public double Profit => GmQMEPbClVMVfiI02NEN(BsK98nFKkMH);

	public q8rvRr98fhoVa4G2tRxm(IhHpoC9hliGX2eZqQA6k P_0, double P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		BsK98nFKkMH = P_0;
		aFK98GTsImh = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static q8rvRr98fhoVa4G2tRxm()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool t1eITLbCv4RXqqrS4ePg()
	{
		return CfJbmFbCoU6Geb4MVNhk == null;
	}

	internal static q8rvRr98fhoVa4G2tRxm bHsURrbCBKhB5d4qFx34()
	{
		return CfJbmFbCoU6Geb4MVNhk;
	}

	internal static double CfGcOtbCabLwYOJAYFes(object P_0)
	{
		return ((IhHpoC9hliGX2eZqQA6k)P_0).ClosePrice;
	}

	internal static double pvvyJTbCiVNoYPSUgfYc(object P_0)
	{
		return ((IhHpoC9hliGX2eZqQA6k)P_0).Quantity;
	}

	internal static double GmQMEPbClVMVfiI02NEN(object P_0)
	{
		return ((IhHpoC9hliGX2eZqQA6k)P_0).Profit;
	}
}
