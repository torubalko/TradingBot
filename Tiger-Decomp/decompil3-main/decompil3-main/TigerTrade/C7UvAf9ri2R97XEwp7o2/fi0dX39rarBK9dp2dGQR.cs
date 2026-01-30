using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using Ha9I1wna0XjsKnZiPJll;
using NsWD4W9miMxRbFU3fsu9;
using s8CVoTnYOlGDs7vDiB5f;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Settings;
using TigerTrade.Chart.Theme;
using TuAMtrl1Nd3XoZQQUXf0;

namespace C7UvAf9ri2R97XEwp7o2;

[DataContract(Name = "IndicatorSuperBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal abstract class fi0dX39rarBK9dp2dGQR : IndicatorBase, IDisposable
{
	[CompilerGenerated]
	private vJGfm5nYMCEZFuST02my b3T9rL2xwbO;

	[CompilerGenerated]
	private ChartTheme h9T9reC9w9X;

	[CompilerGenerated]
	private ChartSettings SmG9rs0cDd5;

	private DataCycleBase? zL59rX2sjLa;

	private int nyC9rcjmkOx;

	private ypqMIv9maFM0tRwF0xMh fQq9rjL9BCQ;

	internal static fi0dX39rarBK9dp2dGQR l64MGebyy6tfKOn2GWTk;

	protected ChartTheme Theme
	{
		[CompilerGenerated]
		get
		{
			return h9T9reC9w9X;
		}
		[CompilerGenerated]
		private set
		{
			h9T9reC9w9X = chartTheme;
		}
	}

	protected ChartSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return SmG9rs0cDd5;
		}
		[CompilerGenerated]
		private set
		{
			SmG9rs0cDd5 = smG9rs0cDd;
		}
	}

	protected new ypqMIv9maFM0tRwF0xMh DataProvider
	{
		get
		{
			return fQq9rjL9BCQ;
		}
		set
		{
			int num = 3;
			int num2 = num;
			ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh2 = default(ypqMIv9maFM0tRwF0xMh);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (n5RY6SbyCeUXf0HkjDUt(ypqMIv9maFM0tRwF0xMh.DataCycle) != zL59rX2sjLa || ypqMIv9maFM0tRwF0xMh.DataCycle.Repeat != nyC9rcjmkOx)
					{
						vV3l9VrwgiA(zL59rX2sjLa, nyC9rcjmkOx);
						zL59rX2sjLa = n5RY6SbyCeUXf0HkjDUt(yE2P9cbyrQWAFvoSxWoN(ypqMIv9maFM0tRwF0xMh));
						nyC9rcjmkOx = oHKCRWbyKxlBTQOBfFi2(ypqMIv9maFM0tRwF0xMh.DataCycle);
						num2 = 4;
						break;
					}
					return;
				case 5:
					ypqMIv9maFM0tRwF0xMh2 = fQq9rjL9BCQ;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
					{
						num2 = 0;
					}
					break;
				default:
					fQq9rjL9BCQ = ypqMIv9maFM0tRwF0xMh;
					oecKZSbymi5alt4fiPeu(this, ypqMIv9maFM0tRwF0xMh2);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 3:
					if (fQq9rjL9BCQ == ypqMIv9maFM0tRwF0xMh)
					{
						num2 = 2;
						break;
					}
					zL59rX2sjLa = ypqMIv9maFM0tRwF0xMh?.DataCycle?.CycleBase;
					nyC9rcjmkOx = ((ypqMIv9maFM0tRwF0xMh == null) ? ((int?)null) : ((DataCycle)yE2P9cbyrQWAFvoSxWoN(ypqMIv9maFM0tRwF0xMh))?.Repeat).GetValueOrDefault();
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					return;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	protected vJGfm5nYMCEZFuST02my cpI9r4xqdTB()
	{
		return b3T9rL2xwbO;
	}

	[SpecialName]
	[CompilerGenerated]
	private void oh89rDXIViV(vJGfm5nYMCEZFuST02my P_0)
	{
		b3T9rL2xwbO = P_0;
	}

	protected virtual void wxjl9ZbwOKd(ypqMIv9maFM0tRwF0xMh P_0)
	{
	}

	protected virtual void vV3l9VrwgiA(DataCycleBase? P_0, int P_1)
	{
	}

	public virtual void MV4l9mTDd9r(vJGfm5nYMCEZFuST02my P_0)
	{
		oh89rDXIViV(P_0);
		Theme = ((ChartSettings)ujclh9bywQuGuvS0qbmI(J2nMlebyhix93w60nFKY(P_0))).Theme;
		Settings = P_0.Chart.Settings;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		dCNrPSby76koHpnJYJjb(this, P_0.T6NnYzm3A5s());
	}

	public void L9w9rlp3upV(ypqMIv9maFM0tRwF0xMh P_0, string P_1, string P_2, string P_3)
	{
		DataProvider = P_0;
		Ql6PxvbyAldYpkLWpwTt(this, (P_0 != null) ? QmQtoCby8cr29kYByxTV(P_0) : null, P_1, P_2, P_3);
	}

	public virtual void Dispose()
	{
	}

	protected fi0dX39rarBK9dp2dGQR()
	{
		DZlgCSbyPuDyXyoohqv0();
		base._002Ector();
	}

	static fi0dX39rarBK9dp2dGQR()
	{
		DaUEfObyJBKRUf6gK2gK();
	}

	internal static bool bjWTVybyZXCohMIJitOt()
	{
		return l64MGebyy6tfKOn2GWTk == null;
	}

	internal static fi0dX39rarBK9dp2dGQR XlAqZAbyVp39yvXbpMDO()
	{
		return l64MGebyy6tfKOn2GWTk;
	}

	internal static DataCycleBase n5RY6SbyCeUXf0HkjDUt(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static object yE2P9cbyrQWAFvoSxWoN(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).DataCycle;
	}

	internal static int oHKCRWbyKxlBTQOBfFi2(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static void oecKZSbymi5alt4fiPeu(object P_0, object P_1)
	{
		((fi0dX39rarBK9dp2dGQR)P_0).wxjl9ZbwOKd((ypqMIv9maFM0tRwF0xMh)P_1);
	}

	internal static object J2nMlebyhix93w60nFKY(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).Chart;
	}

	internal static object ujclh9bywQuGuvS0qbmI(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).Settings;
	}

	internal static void dCNrPSby76koHpnJYJjb(object P_0, object P_1)
	{
		((IndicatorBase)P_0).Canvas = (IChartCanvas)P_1;
	}

	internal static object QmQtoCby8cr29kYByxTV(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).RwElnDSgI3U();
	}

	internal static void Ql6PxvbyAldYpkLWpwTt(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((IndicatorBase)P_0).Run((IChartDataProvider)P_1, (string)P_2, (string)P_3, (string)P_4);
	}

	internal static void DZlgCSbyPuDyXyoohqv0()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void DaUEfObyJBKRUf6gK2gK()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
