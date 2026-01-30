using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace u39tbHiXvGDVKfT8mPrL;

[Indicator("TradesFlow", "TradesFlow", true, Type = typeof(kpmruLiXoithMKh71KZL))]
[DataContract(Name = "TradesFlowIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class kpmruLiXoithMKh71KZL : IndicatorBase
{
	internal sealed class xGHRaOiKqHBSdtNDeWRW
	{
		[CompilerGenerated]
		private DateTime pZkiKAEvXYv;

		[CompilerGenerated]
		private decimal joNiKPGy2nW;

		[CompilerGenerated]
		private decimal D7giKJGGHm3;

		[CompilerGenerated]
		private decimal bu3iKFnRcxP;

		[CompilerGenerated]
		private bool JYJiK3kZEpq;

		[CompilerGenerated]
		private bool YpXiKpugjsr;

		[CompilerGenerated]
		private bool bKgiKuUqKda;

		internal static xGHRaOiKqHBSdtNDeWRW VGXTCueUThDl0sZ8bOaI;

		public DateTime Time
		{
			[CompilerGenerated]
			get
			{
				return pZkiKAEvXYv;
			}
			[CompilerGenerated]
			set
			{
				pZkiKAEvXYv = dateTime;
			}
		}

		public decimal Price
		{
			[CompilerGenerated]
			get
			{
				return joNiKPGy2nW;
			}
			[CompilerGenerated]
			set
			{
				joNiKPGy2nW = num;
			}
		}

		public decimal Price2
		{
			[CompilerGenerated]
			get
			{
				return D7giKJGGHm3;
			}
			[CompilerGenerated]
			set
			{
				D7giKJGGHm3 = d7giKJGGHm;
			}
		}

		public decimal Size
		{
			[CompilerGenerated]
			get
			{
				return bu3iKFnRcxP;
			}
			[CompilerGenerated]
			set
			{
				bu3iKFnRcxP = num;
			}
		}

		public bool Alert
		{
			[CompilerGenerated]
			get
			{
				return bKgiKuUqKda;
			}
			[CompilerGenerated]
			set
			{
				bKgiKuUqKda = flag;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public bool oKmiKCf0ipv()
		{
			return JYJiK3kZEpq;
		}

		[SpecialName]
		[CompilerGenerated]
		public void vS3iKrTKmFB(bool P_0)
		{
			JYJiK3kZEpq = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool MI0iKm663x8()
		{
			return YpXiKpugjsr;
		}

		[SpecialName]
		[CompilerGenerated]
		public void PydiKhQwyQM(bool P_0)
		{
			YpXiKpugjsr = P_0;
		}

		public xGHRaOiKqHBSdtNDeWRW(IChartTick P_0)
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
			Time = P_0.Time;
			Price = RAPW0seUVetdM2FtZOc2(P_0);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
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
				Size = P_0.Size;
				vS3iKrTKmFB(P_0.IsBuy);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
				{
					num = 1;
				}
			}
		}

		static xGHRaOiKqHBSdtNDeWRW()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool xawH4aeUyXY85MBAHFH3()
		{
			return VGXTCueUThDl0sZ8bOaI == null;
		}

		internal static xGHRaOiKqHBSdtNDeWRW fJgij0eUZii963yFueRA()
		{
			return VGXTCueUThDl0sZ8bOaI;
		}

		internal static decimal RAPW0seUVetdM2FtZOc2(object P_0)
		{
			return ((IChartTick)P_0).Price;
		}
	}

	internal sealed class cXL4PHiKz3boTy6dZNda
	{
		private readonly LinkedList<xGHRaOiKqHBSdtNDeWRW> Nl0im98IM1i;

		[CompilerGenerated]
		private xGHRaOiKqHBSdtNDeWRW F3limnRdVxh;

		private bool r2UimGc6pGc;

		private decimal g6QimYDRtU5;

		internal static cXL4PHiKz3boTy6dZNda cpwjaVeUCO0FHU2TmcPk;

		public xGHRaOiKqHBSdtNDeWRW Last
		{
			[CompilerGenerated]
			get
			{
				return F3limnRdVxh;
			}
			[CompilerGenerated]
			private set
			{
				F3limnRdVxh = f3limnRdVxh;
			}
		}

		public void jwBim0KqX0p(IChartTick P_0, bool P_1, decimal P_2)
		{
			int num;
			if (r2UimGc6pGc == P_1)
			{
				if (g6QimYDRtU5 != P_2)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num = 2;
					}
					goto IL_0009;
				}
				goto IL_029c;
			}
			goto IL_02ea;
			IL_029c:
			if (Last == null)
			{
				Last = new xGHRaOiKqHBSdtNDeWRW(P_0);
			}
			if (P_1)
			{
				num = 5;
				goto IL_0009;
			}
			goto IL_0220;
			IL_00ff:
			if (!gxRqcseU8lN28W4gkKpf(Last))
			{
				num = 4;
				goto IL_0009;
			}
			goto IL_025c;
			IL_0220:
			if (mXwFxQeU7IqTDlDIFVa0(Last) >= P_2)
			{
				goto IL_00ff;
			}
			goto IL_025c;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 5:
					if (lYj9AaeUhBjS7P81WBaO(Last.Time, DscQWXeUmbN2KDrT3NHy(P_0)))
					{
						num = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
						{
							num = 9;
						}
						continue;
					}
					goto IL_0220;
				case 10:
					return;
				case 3:
					Last = null;
					Nl0im98IM1i.Clear();
					num = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
					{
						num = 13;
					}
					continue;
				case 11:
					break;
				case 1:
					goto IL_00ff;
				case 12:
					if (Last.MI0iKm663x8())
					{
						goto IL_00b0;
					}
					goto default;
				default:
					rthuxueUApDLbgnIYwdB(Last, true);
					Nl0im98IM1i.AddFirst(Last);
					goto IL_00b0;
				case 8:
					goto IL_0220;
				case 7:
					goto IL_025c;
				case 9:
					if (Last.oKmiKCf0ipv() == P_0.IsBuy)
					{
						Last.Size += P_0.Size;
						rYZ0cmeUwgHIBaUJiJsC(Last, P_0.Price);
						num = 11;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
						{
							num = 1;
						}
						continue;
					}
					goto IL_0220;
				case 13:
					goto IL_029c;
				case 4:
					Nl0im98IM1i.AddFirst(Last);
					num = 7;
					continue;
				case 6:
					g6QimYDRtU5 = P_2;
					num = 3;
					continue;
				case 2:
					goto IL_02ea;
				}
				break;
			}
			goto IL_00ee;
			IL_02ea:
			r2UimGc6pGc = P_1;
			num = 6;
			goto IL_0009;
			IL_00ee:
			if (Last == null || !(mXwFxQeU7IqTDlDIFVa0(Last) >= P_2))
			{
				goto IL_00b0;
			}
			num = 12;
			goto IL_0009;
			IL_025c:
			Last = new xGHRaOiKqHBSdtNDeWRW(P_0);
			goto IL_00ee;
			IL_00b0:
			if (Nl0im98IM1i.Count <= 500)
			{
				num = 10;
				goto IL_0009;
			}
			while (Nl0im98IM1i.Count >= 300)
			{
				Nl0im98IM1i.RemoveLast();
			}
		}

		public void Clear()
		{
			Last = null;
			Nl0im98IM1i.Clear();
		}

		public LinkedList<xGHRaOiKqHBSdtNDeWRW> C08im2N7TUc()
		{
			return Nl0im98IM1i;
		}

		public cXL4PHiKz3boTy6dZNda()
		{
			BHJZNOeUPgVUPqK3BOld();
			Nl0im98IM1i = new LinkedList<xGHRaOiKqHBSdtNDeWRW>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static cXL4PHiKz3boTy6dZNda()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ANwO1oeUJJBN5fkG7dFI();
		}

		internal static bool p8pSHgeUrQaPeJHOyngB()
		{
			return cpwjaVeUCO0FHU2TmcPk == null;
		}

		internal static cXL4PHiKz3boTy6dZNda GSjujNeUKFwV7uhy2nof()
		{
			return cpwjaVeUCO0FHU2TmcPk;
		}

		internal static DateTime DscQWXeUmbN2KDrT3NHy(object P_0)
		{
			return ((IChartTick)P_0).Time;
		}

		internal static bool lYj9AaeUhBjS7P81WBaO(DateTime P_0, DateTime P_1)
		{
			return P_0 == P_1;
		}

		internal static void rYZ0cmeUwgHIBaUJiJsC(object P_0, decimal P_1)
		{
			((xGHRaOiKqHBSdtNDeWRW)P_0).Price2 = P_1;
		}

		internal static decimal mXwFxQeU7IqTDlDIFVa0(object P_0)
		{
			return ((xGHRaOiKqHBSdtNDeWRW)P_0).Size;
		}

		internal static bool gxRqcseU8lN28W4gkKpf(object P_0)
		{
			return ((xGHRaOiKqHBSdtNDeWRW)P_0).MI0iKm663x8();
		}

		internal static void rthuxueUApDLbgnIYwdB(object P_0, bool P_1)
		{
			((xGHRaOiKqHBSdtNDeWRW)P_0).PydiKhQwyQM(P_1);
		}

		internal static void BHJZNOeUPgVUPqK3BOld()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		}

		internal static void ANwO1oeUJJBN5fkG7dFI()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal sealed class y2MPJkimoWfRH0mG77W1
	{
		[CompilerGenerated]
		private decimal jMtimcgY0y7;

		[CompilerGenerated]
		private bool kMvimjxeCwB;

		[CompilerGenerated]
		private bool npmimEUZdvo;

		[CompilerGenerated]
		private bool BGsimQePNBJ;

		[CompilerGenerated]
		private double QrvimdreHJk;

		[CompilerGenerated]
		private Point GTUimgqaWtl;

		[CompilerGenerated]
		private Rect GAQimROlThE;

		private static y2MPJkimoWfRH0mG77W1 WdFw7IeUFkUZcdbQ46ib;

		public decimal Size
		{
			[CompilerGenerated]
			get
			{
				return jMtimcgY0y7;
			}
			[CompilerGenerated]
			set
			{
				jMtimcgY0y7 = num;
			}
		}

		public Point Center
		{
			[CompilerGenerated]
			get
			{
				return GTUimgqaWtl;
			}
			[CompilerGenerated]
			set
			{
				GTUimgqaWtl = gTUimgqaWtl;
			}
		}

		public Rect Rect
		{
			[CompilerGenerated]
			get
			{
				return GAQimROlThE;
			}
			[CompilerGenerated]
			set
			{
				GAQimROlThE = gAQimROlThE;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public bool jx0imaQRjSw()
		{
			return kMvimjxeCwB;
		}

		[SpecialName]
		[CompilerGenerated]
		public void dpsimiPTXMT(bool P_0)
		{
			kMvimjxeCwB = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool G7Fim4FHhjq()
		{
			return npmimEUZdvo;
		}

		[SpecialName]
		[CompilerGenerated]
		public void cicimDWAQiL(bool P_0)
		{
			npmimEUZdvo = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool InAimNHcRcK()
		{
			return BGsimQePNBJ;
		}

		[SpecialName]
		[CompilerGenerated]
		public void zerimk1Sbaf(bool P_0)
		{
			BGsimQePNBJ = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double QC1im5Ebd6j()
		{
			return QrvimdreHJk;
		}

		[SpecialName]
		[CompilerGenerated]
		public void ASmimSnnqiq(double P_0)
		{
			QrvimdreHJk = P_0;
		}

		public y2MPJkimoWfRH0mG77W1()
		{
			dMIGxyeUun56yZxsRUfB();
			base._002Ector();
		}

		static y2MPJkimoWfRH0mG77W1()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool cbutvkeU3KnjOqxorO30()
		{
			return WdFw7IeUFkUZcdbQ46ib == null;
		}

		internal static y2MPJkimoWfRH0mG77W1 YtORpveUpSuBEywS71d0()
		{
			return WdFw7IeUFkUZcdbQ46ib;
		}

		internal static void dMIGxyeUun56yZxsRUfB()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		}
	}

	private IndicatorDecimalParam zwgicvX2Yx7;

	private IndicatorDecimalParam JtOicBiDTUx;

	private bool mm8icasUVge;

	private IndicatorIntParam Klkicivrbws;

	private bool W0eiclV4ZDX;

	private bool tgsic4WDBbp;

	private int wI0icD5pujg;

	private int EjPicbkFomZ;

	private ChartAlertSettings vHcicN7nYp1;

	private IndicatorIntParam fNVickjYlkV;

	[CompilerGenerated]
	private XBrush zqTic1k3tQD;

	[CompilerGenerated]
	private XBrush d5Oic5wFpEx;

	[CompilerGenerated]
	private XPen rYKicSGHA1M;

	private XColor Nanicx0AaY1;

	[CompilerGenerated]
	private XBrush Bu2icLDOF5x;

	[CompilerGenerated]
	private XBrush xOvicek7A6u;

	[CompilerGenerated]
	private XPen eWZics4s7a3;

	private XColor hYcicXM1mCK;

	[CompilerGenerated]
	private XBrush ySoiccfvnEM;

	private XColor uneicj1dDi8;

	private int SApicEgv65S;

	private cXL4PHiKz3boTy6dZNda jvpicQaCCkr;

	internal static kpmruLiXoithMKh71KZL yF9tTyeSyoYce7sF6btT;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "TradesFilterParam")]
	public IndicatorDecimalParam PRgiXinUeiD
	{
		get
		{
			return zwgicvX2Yx7 ?? (zwgicvX2Yx7 = new IndicatorDecimalParam(0m));
		}
		set
		{
			zwgicvX2Yx7 = indicatorDecimalParam;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(null)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsTradesFilter")]
	public decimal TradesFilter
	{
		get
		{
			return PRgiXinUeiD.Get(base.SettingsShortKey);
		}
		set
		{
			if (!PRgiXinUeiD.Set(base.SettingsShortKey, value2, 0m))
			{
				return;
			}
			OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(-1346994499 ^ -1346969541));
			cXL4PHiKz3boTy6dZNda cXL4PHiKz3boTy6dZNda = jvpicQaCCkr;
			if (cXL4PHiKz3boTy6dZNda != null)
			{
				cXL4PHiKz3boTy6dZNda.Clear();
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
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

	[DataMember(Name = "ValuesFilterParam")]
	public IndicatorDecimalParam gcuiXNcmEjA
	{
		get
		{
			return JtOicBiDTUx ?? (JtOicBiDTUx = new IndicatorDecimalParam(5m));
		}
		set
		{
			JtOicBiDTUx = jtOicBiDTUx;
		}
	}

	[DefaultValue(5)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsValuesFilter")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public decimal ValuesFilter
	{
		get
		{
			return gcuiXNcmEjA.Get(base.SettingsShortKey);
		}
		set
		{
			if (gcuiXNcmEjA.Set(base.SettingsShortKey, value2, 0m))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-617064403 ^ -617036145));
			}
		}
	}

	[DataMember(Name = "MinimizeValues")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimizeValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool MinimizeValues
	{
		get
		{
			return mm8icasUVge;
		}
		set
		{
			if (flag != mm8icasUVge)
			{
				mm8icasUVge = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1487846E ^ 0x14870078));
			}
		}
	}

	[DataMember(Name = "RoundValueParam")]
	public IndicatorIntParam WtZiXeo57pe
	{
		get
		{
			return Klkicivrbws ?? (Klkicivrbws = new IndicatorIntParam(0));
		}
		set
		{
			Klkicivrbws = klkicivrbws;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsRoundValues")]
	[DefaultValue(0)]
	public int RoundValues
	{
		get
		{
			return WtZiXeo57pe.Get(base.SettingsLongKey);
		}
		set
		{
			if (WtZiXeo57pe.Set(base.SettingsLongKey, value2, -4, 4))
			{
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(0x404ED0BE ^ 0x404E5488));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsCompactMode")]
	[DataMember(Name = "CompactMode")]
	[DefaultValue(false)]
	public bool CompactMode
	{
		get
		{
			return W0eiclV4ZDX;
		}
		set
		{
			if (flag != W0eiclV4ZDX)
			{
				W0eiclV4ZDX = flag;
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(-338769610 ^ -338798712));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAggregateTrades")]
	[DataMember(Name = "AggregateTicks")]
	[DefaultValue(false)]
	public bool AggregateTicks
	{
		get
		{
			return tgsic4WDBbp;
		}
		set
		{
			if (flag == tgsic4WDBbp)
			{
				return;
			}
			tgsic4WDBbp = flag;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x12629CB0));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
					{
						num = 0;
					}
					break;
				default:
					jvpicQaCCkr?.Clear();
					return;
				}
			}
		}
	}

	[DefaultValue(30)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Width")]
	public int Width
	{
		get
		{
			return wI0icD5pujg;
		}
		set
		{
			num = vv65apeSKiCqD25Jdegx(10, z1Y4fmeSr5L9dD2upcZU(100, num));
			if (num == wI0icD5pujg)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				wI0icD5pujg = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-377195341 ^ -377165237));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsOffset")]
	[DataMember(Name = "Offset")]
	[DefaultValue(0)]
	public int Offset
	{
		get
		{
			return EjPicbkFomZ;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != EjPicbkFomZ)
			{
				EjPicbkFomZ = num;
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(-57768881 ^ -57795767));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
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

	[DataMember(Name = "Alert")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[Browsable(true)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public ChartAlertSettings Alert
	{
		get
		{
			return vHcicN7nYp1 ?? (vHcicN7nYp1 = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, vHcicN7nYp1))
			{
				vHcicN7nYp1 = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x9F0F634 ^ 0x9F08BB2));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
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

	[DataMember(Name = "SignalFilterParam")]
	public IndicatorIntParam W1HiXWlGAVr
	{
		get
		{
			return fNVickjYlkV ?? (fNVickjYlkV = new IndicatorIntParam(100));
		}
		set
		{
			fNVickjYlkV = indicatorIntParam;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsSignal")]
	[DefaultValue(100)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSignalFilter")]
	public int SignalFilter
	{
		get
		{
			return W1HiXWlGAVr.Get(base.SettingsShortKey);
		}
		set
		{
			if (W1HiXWlGAVr.Set(base.SettingsShortKey, value2, 0))
			{
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(0x746ED405 ^ 0x746E4B13));
			}
		}
	}

	[Browsable(false)]
	public XBrush Q30iXZ9PyhE
	{
		[CompilerGenerated]
		get
		{
			return zqTic1k3tQD;
		}
		[CompilerGenerated]
		private set
		{
			zqTic1k3tQD = xBrush;
		}
	}

	[Browsable(false)]
	public XBrush MDliXr7WBxi
	{
		[CompilerGenerated]
		get
		{
			return d5Oic5wFpEx;
		}
		[CompilerGenerated]
		private set
		{
			d5Oic5wFpEx = xBrush;
		}
	}

	[Browsable(false)]
	public XPen uDPiXhLKcHr
	{
		[CompilerGenerated]
		get
		{
			return rYKicSGHA1M;
		}
		[CompilerGenerated]
		private set
		{
			rYKicSGHA1M = xPen;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "TickBuyBorderColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBuysColor")]
	public XColor TickBuyColor
	{
		get
		{
			return Nanicx0AaY1;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					Q30iXZ9PyhE = new XBrush(xColor);
					MDliXr7WBxi = new XBrush(new XColor(byte.MaxValue, xColor));
					uDPiXhLKcHr = new XPen(MDliXr7WBxi, 1);
					OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(-2108526692 ^ -2108493650));
					return;
				case 2:
					return;
				default:
					Nanicx0AaY1 = xColor;
					num2 = 3;
					break;
				case 1:
					if (HcjhkxeSmNnAPqFrpWS7(Nanicx0AaY1, xColor))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush VtPiXP5PXrq
	{
		[CompilerGenerated]
		get
		{
			return Bu2icLDOF5x;
		}
		[CompilerGenerated]
		private set
		{
			Bu2icLDOF5x = bu2icLDOF5x;
		}
	}

	[Browsable(false)]
	public XBrush ih1iX3d5GCd
	{
		[CompilerGenerated]
		get
		{
			return xOvicek7A6u;
		}
		[CompilerGenerated]
		private set
		{
			xOvicek7A6u = xBrush;
		}
	}

	[Browsable(false)]
	public XPen xffiXz5Vefs
	{
		[CompilerGenerated]
		get
		{
			return eWZics4s7a3;
		}
		[CompilerGenerated]
		private set
		{
			eWZics4s7a3 = xPen;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSellsColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "TickSellBorderColor")]
	public XColor TickSellColor
	{
		get
		{
			return hYcicXM1mCK;
		}
		set
		{
			if (hYcicXM1mCK == xColor)
			{
				return;
			}
			hYcicXM1mCK = xColor;
			VtPiXP5PXrq = new XBrush(xColor);
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					ih1iX3d5GCd = new XBrush(new XColor(byte.MaxValue, xColor));
					xffiXz5Vefs = new XPen(ih1iX3d5GCd, 1);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				default:
					OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(-1153206687 ^ -1153177297));
					num = 2;
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush nruic9xYsY9
	{
		[CompilerGenerated]
		get
		{
			return ySoiccfvnEM;
		}
		[CompilerGenerated]
		private set
		{
			ySoiccfvnEM = xBrush;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineColor")]
	[DataMember(Name = "TicksLineColor")]
	public XColor TicksLineColor
	{
		get
		{
			return uneicj1dDi8;
		}
		set
		{
			if (!HcjhkxeSmNnAPqFrpWS7(uneicj1dDi8, xColor))
			{
				uneicj1dDi8 = xColor;
				nruic9xYsY9 = new XBrush(xColor);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x34407BB ^ 0x34498D7));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineWidth")]
	[DefaultValue(1)]
	[DataMember(Name = "TicksLineWidth")]
	public int TicksLineWidth
	{
		get
		{
			return SApicEgv65S;
		}
		set
		{
			num = Math.Max(0, Math.Min(10, num));
			if (num != SApicEgv65S)
			{
				SApicEgv65S = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-490987856 ^ -490962628));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
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

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public kpmruLiXoithMKh71KZL()
	{
		XA3qgkeShWG5l1pL3DjR();
		base._002Ector();
		bZE8jbeSwWYJT6A9FNsc(this, false);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				TickSellColor = SdM00CeS7OtPR4hUwdik(EZAJ9peS8Obk4A2vDjwg(127, 178, 34, 34));
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				CompactMode = false;
				AggregateTicks = false;
				MinimizeValues = false;
				Width = 30;
				Offset = 0;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
				{
					num = 0;
				}
				break;
			case 4:
				TicksLineColor = SdM00CeS7OtPR4hUwdik(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				TickBuyColor = SdM00CeS7OtPR4hUwdik(Color.FromArgb(127, 70, 130, 180));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				TicksLineWidth = 1;
				return;
			}
		}
	}

	protected override void Execute()
	{
		int num;
		if (jvpicQaCCkr == null)
		{
			jvpicQaCCkr = new cXL4PHiKz3boTy6dZNda();
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0288;
		IL_0009:
		List<IChartTick>.Enumerator enumerator = default(List<IChartTick>.Enumerator);
		decimal num2 = default(decimal);
		int num4 = default(int);
		switch (num)
		{
		case 1:
			return;
		case 2:
			try
			{
				string arg2 = default(string);
				while (enumerator.MoveNext())
				{
					while (true)
					{
						IL_01f1:
						IChartTick current = enumerator.Current;
						fqGfNWeSA3b694PCKhTh(jvpicQaCCkr, current, AggregateTicks, num2);
						xGHRaOiKqHBSdtNDeWRW xGHRaOiKqHBSdtNDeWRW = (xGHRaOiKqHBSdtNDeWRW)bNHQqMeSP5DxNOwNpEsV(jvpicQaCCkr);
						int num3;
						if (!Alert.IsActive)
						{
							num3 = 2;
							goto IL_00bf;
						}
						if (xGHRaOiKqHBSdtNDeWRW.Size < Urvco5eSJNNA6UfAoDHP(num4))
						{
							break;
						}
						int num5 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
						{
							num5 = 4;
						}
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch (num5)
							{
							case 4:
								if (!xGHRaOiKqHBSdtNDeWRW.Alert)
								{
									xGHRaOiKqHBSdtNDeWRW.Alert = true;
									num5 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
									{
										num5 = 1;
									}
									continue;
								}
								goto end_IL_01f1;
							case 1:
								break;
							case 3:
							{
								string arg = ((IChartSymbol)VPf1HVeSFmJ28WSac4db(base.DataProvider)).FormatSizeFull(xGHRaOiKqHBSdtNDeWRW.Size);
								AddAlert(Alert, string.Format((string)BtaaBAeS38Ag84BOdWuJ(), xGHRaOiKqHBSdtNDeWRW.oKmiKCf0ipv() ? iDAvT9eSCxIpulh7SVaY(-1799510641 ^ -1799538121) : yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28C965BE ^ 0x28C9FA12), arg2, arg));
								goto end_IL_01f1;
							}
							case 2:
								goto end_IL_01f1;
							default:
								goto IL_01f1;
							}
							break;
						}
						arg2 = base.DataProvider.Symbol.FormatPrice(xGHRaOiKqHBSdtNDeWRW.Price);
						num3 = 3;
						goto IL_00bf;
						IL_00bf:
						num5 = num3;
						goto IL_00c3;
						continue;
						end_IL_01f1:
						break;
					}
				}
				return;
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
		}
		goto IL_0288;
		IL_0288:
		if (base.ClearData)
		{
			jvpicQaCCkr.Clear();
		}
		List<IChartTick> ticks = base.DataProvider.GetTicks();
		num2 = TradesFilter;
		num4 = SignalFilter;
		enumerator = ticks.GetEnumerator();
		int num6 = 2;
		num = num6;
		goto IL_0009;
	}

	public override void Render(DxVisualQueue P_0)
	{
		if (jvpicQaCCkr == null)
		{
			return;
		}
		LinkedList<xGHRaOiKqHBSdtNDeWRW> linkedList = jvpicQaCCkr.C08im2N7TUc();
		double num = default(double);
		int num2;
		if (linkedList.Count != 0)
		{
			num = HO4JPieSpRWcdXTZen0J(base.Canvas).Width / 100.0 * (double)Width;
			num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
			{
				num2 = 1;
			}
		}
		else
		{
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
			{
				num2 = 0;
			}
		}
		double num5 = default(double);
		double num4 = default(double);
		int num12 = default(int);
		LinkedList<y2MPJkimoWfRH0mG77W1> linkedList2 = default(LinkedList<y2MPJkimoWfRH0mG77W1>);
		Point[] array = default(Point[]);
		IChartSymbol chartSymbol = default(IChartSymbol);
		bool minimize = default(bool);
		xGHRaOiKqHBSdtNDeWRW current = default(xGHRaOiKqHBSdtNDeWRW);
		double num8 = default(double);
		decimal num3 = default(decimal);
		int round = default(int);
		y2MPJkimoWfRH0mG77W1 y2MPJkimoWfRH0mG77W = default(y2MPJkimoWfRH0mG77W1);
		double num9 = default(double);
		double y = default(double);
		bool flag = default(bool);
		double num13 = default(double);
		double num7 = default(double);
		LinkedList<y2MPJkimoWfRH0mG77W1>.Enumerator enumerator2 = default(LinkedList<y2MPJkimoWfRH0mG77W1>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				if (num5 < 20.0)
				{
					return;
				}
				num4 = num5;
				num12 = 0;
				linkedList2 = new LinkedList<y2MPJkimoWfRH0mG77W1>();
				array = new Point[linkedList.Count];
				chartSymbol = (IChartSymbol)VPf1HVeSFmJ28WSac4db(base.DataProvider);
				num2 = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num2 = 7;
				}
				break;
			case 7:
			{
				minimize = MinimizeValues;
				using (LinkedList<xGHRaOiKqHBSdtNDeWRW>.Enumerator enumerator = linkedList.GetEnumerator())
				{
					while (true)
					{
						IL_038f:
						int num6;
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							if (num4 < num5 - num)
							{
								continue;
							}
							num6 = 5;
						}
						else
						{
							num6 = 4;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 != 0)
							{
								num6 = 3;
							}
						}
						while (true)
						{
							double num10;
							switch (num6)
							{
							case 12:
								if (num4 - 2.0 * num8 - 4.0 < num5 - num)
								{
									int num11 = 6;
									num6 = num11;
									continue;
								}
								if (!(current.Size >= num3))
								{
									num6 = 4;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
									{
										num6 = 10;
									}
									continue;
								}
								num10 = num8 - 1.0;
								goto IL_04f6;
							case 11:
								if (V3Ah8xeSuJgDBgpoOFVG(current) >= num3)
								{
									Size size = base.Canvas.ChartFont.GetSize((string)IjCyrFeSzwQSIAK89pS2(chartSymbol, current.Size, round, minimize));
									if (size.Width > size.Height)
									{
										num8 = size.Width / 2.0;
										num6 = 7;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
										{
											num6 = 2;
										}
										continue;
									}
									num8 = size.Height / 2.0;
									goto case 7;
								}
								goto IL_03f6;
							case 3:
								linkedList2.AddFirst(y2MPJkimoWfRH0mG77W);
								num6 = 9;
								continue;
							case 2:
							{
								num4 -= num9;
								y = GetY(oCpj7aex0E3Rl0BRMwMP(base.Canvas) ? ((double)current.Price) : 0.5);
								y2MPJkimoWfRH0mG77W1 y2MPJkimoWfRH0mG77W2 = new y2MPJkimoWfRH0mG77W1();
								y2MPJkimoWfRH0mG77W2.Size = current.Size;
								y2MPJkimoWfRH0mG77W2.dpsimiPTXMT(hA8KQxex2wIxTDdFTNOv(current));
								J6JsApexHaF4eN05QrfB(y2MPJkimoWfRH0mG77W2, flag);
								y2MPJkimoWfRH0mG77W2.ASmimSnnqiq(num8);
								SlPwRVexfGTSExE932qT(y2MPJkimoWfRH0mG77W2, new Point(num4, y));
								y2MPJkimoWfRH0mG77W2.Rect = new Rect(num4 - num8, y - num8, num8 * 2.0, num8 * 2.0);
								y2MPJkimoWfRH0mG77W = y2MPJkimoWfRH0mG77W2;
								if (!(current.Price2 > 0m))
								{
									num6 = 3;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
									{
										num6 = 2;
									}
									continue;
								}
								num13 = GetY(base.Canvas.IsStock ? ((double)O0P3Z6ex9vl8RXZ1fVpr(current.Price, current.Price2)) : 0.5) - 10.0;
								num6 = 13;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
								{
									num6 = 10;
								}
								continue;
							}
							case 5:
								num8 = 3.0;
								flag = false;
								num6 = 11;
								continue;
							case 7:
								num8 += 2.0;
								flag = true;
								goto IL_03f6;
							case 10:
								num10 = 2.0;
								goto IL_04f6;
							case 6:
								num4 -= num8;
								num6 = 14;
								continue;
							case 1:
								y2MPJkimoWfRH0mG77W.Rect = new Rect(num4 - num8, num13, num8 * 2.0, num7 - num13);
								Q9JLDVexGZZbnAdWSiWv(y2MPJkimoWfRH0mG77W, true);
								goto case 3;
							case 8:
								if (!CompactMode)
								{
									num4 -= num9 + (double)TicksLineWidth / 2.0;
									num6 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								break;
							case 9:
								array[num12++] = new Point(num4, y);
								num6 = 8;
								continue;
							case 13:
								num7 = GetY(base.Canvas.IsStock ? ((double)Math.Min(OMT2pqexnWom8jypKmOc(current), current.Price2)) : 0.5) + 10.0;
								num6 = 1;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
								{
									num6 = 1;
								}
								continue;
							case 4:
								goto end_IL_0168;
								IL_03f6:
								num8 += (double)TicksLineWidth / 2.0;
								num6 = 12;
								continue;
								IL_04f6:
								num9 = num10;
								num6 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
								{
									num6 = 2;
								}
								continue;
							}
							goto IL_038f;
							continue;
							end_IL_0168:
							break;
						}
						break;
					}
				}
				goto case 1;
			}
			case 5:
				return;
			case 2:
				if (num < 20.0)
				{
					num2 = 3;
					break;
				}
				num5 = base.Canvas.Rect.Right - (double)Offset - 5.0;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				enumerator2 = linkedList2.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 4:
				try
				{
					while (enumerator2.MoveNext())
					{
						y2MPJkimoWfRH0mG77W1 current2 = enumerator2.Current;
						int num14;
						if (!current2.InAimNHcRcK())
						{
							num14 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
							{
								num14 = 0;
							}
						}
						else
						{
							P_0.FillRectangle(base.Canvas.Theme.ChartBackBrush, Qi1l03exli2SUOdsMOnv(current2));
							num14 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
							{
								num14 = 0;
							}
						}
						while (true)
						{
							switch (num14)
							{
							case 4:
								if (!current2.G7Fim4FHhjq())
								{
									num14 = 3;
									continue;
								}
								goto case 5;
							default:
								S0XBttexB16cd528iNPd(P_0, rsGavIexo2Npn64cRSxo(base.Canvas.Theme), current2.Center, current2.QC1im5Ebd6j(), JRJPovexvlOkp55TIXpf(current2));
								S0XBttexB16cd528iNPd(P_0, current2.jx0imaQRjSw() ? Q30iXZ9PyhE : VtPiXP5PXrq, t10UZqexaoauoBYCYEMg(current2), current2.QC1im5Ebd6j(), current2.QC1im5Ebd6j());
								num14 = 2;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
								{
									num14 = 2;
								}
								continue;
							case 3:
								break;
							case 5:
								P_0.DrawString((string)IjCyrFeSzwQSIAK89pS2(chartSymbol, NIYYhvexbcEuQk2CkZHQ(current2), round, minimize), base.Canvas.ChartFont, base.Canvas.Theme.ChartFontBrush, current2.Rect, XTextAlignment.Center);
								break;
							case 2:
								P_0.DrawEllipse(FxkJoOexiWeZO64JnQ2C(current2) ? uDPiXhLKcHr : xffiXz5Vefs, t10UZqexaoauoBYCYEMg(current2), current2.QC1im5Ebd6j(), JRJPovexvlOkp55TIXpf(current2));
								goto case 4;
							case 1:
								dZbp9qex4OTA8IIvIMyF(P_0, FxkJoOexiWeZO64JnQ2C(current2) ? Q30iXZ9PyhE : VtPiXP5PXrq, Qi1l03exli2SUOdsMOnv(current2));
								ReEy1HexDH2lANkO1iEO(P_0, current2.jx0imaQRjSw() ? uDPiXhLKcHr : xffiXz5Vefs, Qi1l03exli2SUOdsMOnv(current2));
								num14 = 4;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
								{
									num14 = 2;
								}
								continue;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
			case 3:
				return;
			case 1:
				if (TicksLineWidth > 0 && num12 > 1)
				{
					JMEaLwexYb7QphBnvBS8(P_0, new XPen(nruic9xYsY9, TicksLineWidth), array.Take(num12).ToArray());
					num2 = 8;
					break;
				}
				goto case 8;
			case 9:
				num3 = ValuesFilter;
				round = RoundValues;
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		TickBuyColor = new XColor(127, MZ3DMhexN28H3ESiLCWw(P_0.PaletteColor6));
		TickSellColor = new XColor(127, P_0.PaletteColor7);
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		kpmruLiXoithMKh71KZL kpmruLiXoithMKh71KZL2 = (kpmruLiXoithMKh71KZL)P_0;
		CompactMode = nCeln9exkYbjZPCrYRCK(kpmruLiXoithMKh71KZL2);
		AggregateTicks = Dd0Npmex1yYb4WSwGCZG(kpmruLiXoithMKh71KZL2);
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 7:
				Alert.Copy(kpmruLiXoithMKh71KZL2.Alert, !P_1);
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(0x34407BB ^ 0x3447A3D));
				PRgiXinUeiD.Copy(kpmruLiXoithMKh71KZL2.PRgiXinUeiD);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num = 0;
				}
				break;
			case 6:
				TicksLineColor = XtddbwexSkBJeHuCsaS6(kpmruLiXoithMKh71KZL2);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
				{
					num = 0;
				}
				break;
			case 2:
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				gcuiXNcmEjA.Copy(kpmruLiXoithMKh71KZL2.gcuiXNcmEjA);
				WtZiXeo57pe.Copy(kpmruLiXoithMKh71KZL2.WtZiXeo57pe);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
				{
					num = 5;
				}
				break;
			case 0:
				return;
			case 4:
			{
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(-530053095 ^ -530016497));
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				TicksLineWidth = ehri2IexxawqHsoWeEPh(kpmruLiXoithMKh71KZL2);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161590628));
				OnPropertyChanged((string)iDAvT9eSCxIpulh7SVaY(0xC1DDB3B ^ 0xC1D4599));
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
				{
					num = 1;
				}
				break;
			case 5:
				W1HiXWlGAVr.Copy(kpmruLiXoithMKh71KZL2.W1HiXWlGAVr);
				Width = kpmruLiXoithMKh71KZL2.Width;
				Offset = kpmruLiXoithMKh71KZL2.Offset;
				TickBuyColor = OscLtPex5ln1PWYhc5ll(kpmruLiXoithMKh71KZL2);
				TickSellColor = kpmruLiXoithMKh71KZL2.TickSellColor;
				num = 6;
				break;
			}
		}
	}

	static kpmruLiXoithMKh71KZL()
	{
		BZFvcHexLYbY8n7B13CG();
		LI8Oiqexeu03qtvx3U7D();
	}

	internal static bool qgIA9IeSZXHkePfVb13X()
	{
		return yF9tTyeSyoYce7sF6btT == null;
	}

	internal static kpmruLiXoithMKh71KZL xmsempeSVh1vTCUTLTEO()
	{
		return yF9tTyeSyoYce7sF6btT;
	}

	internal static object iDAvT9eSCxIpulh7SVaY(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static int z1Y4fmeSr5L9dD2upcZU(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int vv65apeSKiCqD25Jdegx(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool HcjhkxeSmNnAPqFrpWS7(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void XA3qgkeShWG5l1pL3DjR()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void bZE8jbeSwWYJT6A9FNsc(object P_0, bool value)
	{
		((IndicatorBase)P_0).ShowIndicatorTitle = value;
	}

	internal static XColor SdM00CeS7OtPR4hUwdik(Color P_0)
	{
		return P_0;
	}

	internal static Color EZAJ9peS8Obk4A2vDjwg(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static void fqGfNWeSA3b694PCKhTh(object P_0, object P_1, bool P_2, decimal P_3)
	{
		((cXL4PHiKz3boTy6dZNda)P_0).jwBim0KqX0p((IChartTick)P_1, P_2, P_3);
	}

	internal static object bNHQqMeSP5DxNOwNpEsV(object P_0)
	{
		return ((cXL4PHiKz3boTy6dZNda)P_0).Last;
	}

	internal static decimal Urvco5eSJNNA6UfAoDHP(int P_0)
	{
		return P_0;
	}

	internal static object VPf1HVeSFmJ28WSac4db(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static object BtaaBAeS38Ag84BOdWuJ()
	{
		return Resources.ChartIndicatorsTradesFlowAlert;
	}

	internal static Rect HO4JPieSpRWcdXTZen0J(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static decimal V3Ah8xeSuJgDBgpoOFVG(object P_0)
	{
		return ((xGHRaOiKqHBSdtNDeWRW)P_0).Size;
	}

	internal static object IjCyrFeSzwQSIAK89pS2(object P_0, decimal size, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatSize(size, round, minimize);
	}

	internal static bool oCpj7aex0E3Rl0BRMwMP(object P_0)
	{
		return ((IChartCanvas)P_0).IsStock;
	}

	internal static bool hA8KQxex2wIxTDdFTNOv(object P_0)
	{
		return ((xGHRaOiKqHBSdtNDeWRW)P_0).oKmiKCf0ipv();
	}

	internal static void J6JsApexHaF4eN05QrfB(object P_0, bool P_1)
	{
		((y2MPJkimoWfRH0mG77W1)P_0).cicimDWAQiL(P_1);
	}

	internal static void SlPwRVexfGTSExE932qT(object P_0, Point P_1)
	{
		((y2MPJkimoWfRH0mG77W1)P_0).Center = P_1;
	}

	internal static decimal O0P3Z6ex9vl8RXZ1fVpr(decimal P_0, decimal P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static decimal OMT2pqexnWom8jypKmOc(object P_0)
	{
		return ((xGHRaOiKqHBSdtNDeWRW)P_0).Price;
	}

	internal static void Q9JLDVexGZZbnAdWSiWv(object P_0, bool P_1)
	{
		((y2MPJkimoWfRH0mG77W1)P_0).zerimk1Sbaf(P_1);
	}

	internal static void JMEaLwexYb7QphBnvBS8(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).DrawLines((XPen)P_1, (Point[])P_2);
	}

	internal static object rsGavIexo2Npn64cRSxo(object P_0)
	{
		return ((IChartTheme)P_0).ChartBackBrush;
	}

	internal static double JRJPovexvlOkp55TIXpf(object P_0)
	{
		return ((y2MPJkimoWfRH0mG77W1)P_0).QC1im5Ebd6j();
	}

	internal static void S0XBttexB16cd528iNPd(object P_0, object P_1, Point P_2, double P_3, double P_4)
	{
		((DxVisualQueue)P_0).FillEllipse((XBrush)P_1, P_2, P_3, P_4);
	}

	internal static Point t10UZqexaoauoBYCYEMg(object P_0)
	{
		return ((y2MPJkimoWfRH0mG77W1)P_0).Center;
	}

	internal static bool FxkJoOexiWeZO64JnQ2C(object P_0)
	{
		return ((y2MPJkimoWfRH0mG77W1)P_0).jx0imaQRjSw();
	}

	internal static Rect Qi1l03exli2SUOdsMOnv(object P_0)
	{
		return ((y2MPJkimoWfRH0mG77W1)P_0).Rect;
	}

	internal static void dZbp9qex4OTA8IIvIMyF(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void ReEy1HexDH2lANkO1iEO(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).DrawRectangle((XPen)P_1, P_2);
	}

	internal static decimal NIYYhvexbcEuQk2CkZHQ(object P_0)
	{
		return ((y2MPJkimoWfRH0mG77W1)P_0).Size;
	}

	internal static Color MZ3DMhexN28H3ESiLCWw(XColor P_0)
	{
		return P_0;
	}

	internal static bool nCeln9exkYbjZPCrYRCK(object P_0)
	{
		return ((kpmruLiXoithMKh71KZL)P_0).CompactMode;
	}

	internal static bool Dd0Npmex1yYb4WSwGCZG(object P_0)
	{
		return ((kpmruLiXoithMKh71KZL)P_0).AggregateTicks;
	}

	internal static XColor OscLtPex5ln1PWYhc5ll(object P_0)
	{
		return ((kpmruLiXoithMKh71KZL)P_0).TickBuyColor;
	}

	internal static XColor XtddbwexSkBJeHuCsaS6(object P_0)
	{
		return ((kpmruLiXoithMKh71KZL)P_0).TicksLineColor;
	}

	internal static int ehri2IexxawqHsoWeEPh(object P_0)
	{
		return ((kpmruLiXoithMKh71KZL)P_0).TicksLineWidth;
	}

	internal static void BZFvcHexLYbY8n7B13CG()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void LI8Oiqexeu03qtvx3U7D()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
