using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace KbAGANiQ5cCsmSmhpUng;

[Indicator("VolumeProfiles", "VolumeProfiles", true, Type = typeof(O2XR1WiQ19qhAdqSxCed))]
[DataContract(Name = "VolumeProfilesIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class O2XR1WiQ19qhAdqSxCed : IndicatorBase
{
	private class VolumeProfile
	{
		public readonly int tsYim6JrMO3;

		public int r0qimMRaM1h;

		public readonly RawCluster gP8imOxtD9i;

		public bool g1bimqZlmOk;

		private static VolumeProfile wCihbaeUzOsYKxL8MJCn;

		public VolumeProfile(RawCluster P_0, int P_1)
		{
			S021PieTHHgbw9VnudML();
			base._002Ector();
			gP8imOxtD9i = P_0;
			tsYim6JrMO3 = P_1;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static VolumeProfile()
		{
			V5kgi3eTfKlSkOCXAlBR();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void S021PieTHHgbw9VnudML()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		}

		internal static bool zhOGBLeT0Uivb9Zr9Z2y()
		{
			return wCihbaeUzOsYKxL8MJCn == null;
		}

		internal static VolumeProfile q7whoXeT2wXdNiMMww2a()
		{
			return wCihbaeUzOsYKxL8MJCn;
		}

		internal static void V5kgi3eTfKlSkOCXAlBR()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}
	}

	private List<VolumeProfile> Q9uidBl0Rtt;

	private VolumeProfilesPeriodType M6fidaiq71Z;

	private int C1bidiTKw0H;

	private VolumeProfilesType S3KidlqpPJo;

	private int uElid4bf18o;

	private XBrush OF6idDi9O2L;

	private XColor wB7idbfGuhV;

	private XBrush lrJidNNdgw3;

	private XColor PdOidkr53Xk;

	private bool kD6id10lVWL;

	private bool FVtid56UBPJ;

	private IndicatorIntParam dH7idSxdqac;

	private XBrush tyHidxGCO22;

	private XColor UL9idLXFZlB;

	private VolumeProfilesMaximumType fswideMD6uu;

	private bool aG9idsas9Yh;

	private XBrush DvKidXeBaR4;

	private XColor rCtidcB4Awm;

	private bool SlVidj7xyLp;

	private int niNidE51QiI;

	private XBrush Bq1idQsc5Di;

	private XColor Ww9iddkqp7p;

	private bool xZnidgsIvFB;

	private int pt8idRuBGsU;

	private int uFOid6VtnND;

	private XBrush yT5idMk4fEm;

	private XColor taJidOZWXIw;

	private int CxkidqgKARb;

	internal static O2XR1WiQ19qhAdqSxCed vAIjg9eLtnh5SF3QnhQW;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Cluster;

	[DataMember(Name = "PeriodType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodType")]
	public VolumeProfilesPeriodType PeriodType
	{
		get
		{
			return M6fidaiq71Z;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (volumeProfilesPeriodType == M6fidaiq71Z)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
						{
							num2 = 0;
						}
						break;
					}
					M6fidaiq71Z = volumeProfilesPeriodType;
					C1bidiTKw0H = ((M6fidaiq71Z != VolumeProfilesPeriodType.Minute) ? 1 : 15);
					Clear();
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
					{
						num2 = 2;
					}
					break;
				case 0:
					return;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1127423276 ^ -1127449634));
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodValue")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[DataMember(Name = "PeriodValue")]
	public int PeriodValue
	{
		get
		{
			return C1bidiTKw0H;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68C7EAE6 ^ 0x68C773C4));
					return;
				}
				if (num3 == C1bidiTKw0H)
				{
					return;
				}
				C1bidiTKw0H = num3;
				Clear();
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsProfile")]
	[DataMember(Name = "ProfileType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsType")]
	public VolumeProfilesType ProfileType
	{
		get
		{
			return S3KidlqpPJo;
		}
		set
		{
			if (volumeProfilesType != S3KidlqpPJo)
			{
				S3KidlqpPJo = volumeProfilesType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-520155535 ^ -520123135));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsCustomProportion")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsProfile")]
	[DataMember(Name = "ProfileProportion")]
	public int ProfileProportion
	{
		get
		{
			return uElid4bf18o;
		}
		set
		{
			num = ckRYJeeLyQi2egymkeiI(0, num);
			if (num != uElid4bf18o)
			{
				uElid4bf18o = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(0x37B74BDF ^ 0x37B7EB81));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsProfileColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsProfile")]
	[DataMember(Name = "ProfileColor")]
	public XColor ProfileColor
	{
		get
		{
			return wB7idbfGuhV;
		}
		set
		{
			if (!(xColor == wB7idbfGuhV))
			{
				wB7idbfGuhV = xColor;
				OF6idDi9O2L = new XBrush(wB7idbfGuhV);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-1461292091 ^ -1461260209));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsProfileBackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsProfile")]
	[DataMember(Name = "ProfileBackColor")]
	public XColor ProfileBackColor
	{
		get
		{
			return PdOidkr53Xk;
		}
		set
		{
			if (!jwmFQxeLVdIHrfmE5Vqm(xColor, PdOidkr53Xk))
			{
				PdOidkr53Xk = xColor;
				lrJidNNdgw3 = new XBrush(PdOidkr53Xk);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346970055));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShow")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValues")]
	[DataMember(Name = "ShowValues")]
	public bool ShowValues
	{
		get
		{
			return kD6id10lVWL;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (flag == kD6id10lVWL)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
						{
							num2 = 0;
						}
						break;
					}
					kD6id10lVWL = flag;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774633995));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimize")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValues")]
	[DataMember(Name = "MinimizeValues")]
	public bool MinimizeValues
	{
		get
		{
			return FVtid56UBPJ;
		}
		set
		{
			if (flag != FVtid56UBPJ)
			{
				FVtid56UBPJ = flag;
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-690510723 ^ -690544533));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
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

	[DataMember(Name = "RoundValueParam")]
	public IndicatorIntParam VYCiQrEeSOT
	{
		get
		{
			return dH7idSxdqac ?? (dH7idSxdqac = new IndicatorIntParam(0));
		}
		set
		{
			dH7idSxdqac = indicatorIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsRound")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValues")]
	[DefaultValue(0)]
	public int RoundValues
	{
		get
		{
			return VYCiQrEeSOT.Get(base.SettingsLongKey);
		}
		set
		{
			if (VYCiQrEeSOT.Set(base.SettingsLongKey, value2, -4, 4))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x11D1040B ^ 0x11D1803D));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	[DataMember(Name = "ValuesColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValues")]
	public XColor ValuesColor
	{
		get
		{
			return UL9idLXFZlB;
		}
		set
		{
			if (xColor == UL9idLXFZlB)
			{
				return;
			}
			UL9idLXFZlB = xColor;
			tyHidxGCO22 = new XBrush(UL9idLXFZlB);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009549785));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
				{
					num = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsMaximum")]
	[DataMember(Name = "MaximumType")]
	public VolumeProfilesMaximumType MaximumType
	{
		get
		{
			return fswideMD6uu;
		}
		set
		{
			if (volumeProfilesMaximumType != fswideMD6uu)
			{
				fswideMD6uu = volumeProfilesMaximumType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1999650146 ^ -1999681804));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
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

	[DataMember(Name = "ShowMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsMaximum")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShow")]
	public bool ShowMaximum
	{
		get
		{
			return aG9idsas9Yh;
		}
		set
		{
			if (flag != aG9idsas9Yh)
			{
				aG9idsas9Yh = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x4297476F));
			}
		}
	}

	[DataMember(Name = "MaximumColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsMaximum")]
	public XColor MaximumColor
	{
		get
		{
			return rCtidcB4Awm;
		}
		set
		{
			if (!(xColor == rCtidcB4Awm))
			{
				rCtidcB4Awm = xColor;
				DvKidXeBaR4 = new XBrush(rCtidcB4Awm);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3544E813 ^ 0x35446CF3));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	[DataMember(Name = "ShowValueArea")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShow")]
	public bool ShowValueArea
	{
		get
		{
			return SlVidj7xyLp;
		}
		set
		{
			if (flag != SlVidj7xyLp)
			{
				SlVidj7xyLp = flag;
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-57768881 ^ -57802573));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
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

	[DataMember(Name = "ValueAreaPercent")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsValueAreaPercent")]
	public int ValueAreaPercent
	{
		get
		{
			return niNidE51QiI;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CFC0D));
					return;
				case 2:
					num3 = Math.Max(0, Math.Min(100, num3));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (num3 != 0)
					{
						break;
					}
					goto case 3;
				case 3:
					num3 = 70;
					break;
				}
				if (num3 == niNidE51QiI)
				{
					break;
				}
				niNidE51QiI = num3;
				Clear();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	[DataMember(Name = "ValueAreaColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	public XColor ValueAreaColor
	{
		get
		{
			return Ww9iddkqp7p;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (xColor == Ww9iddkqp7p)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
						{
							num2 = 0;
						}
						break;
					}
					Ww9iddkqp7p = xColor;
					Bq1idQsc5Di = new XBrush(Ww9iddkqp7p);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3C0DB));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsEnable")]
	[DataMember(Name = "EnableFilter")]
	public bool EnableFilter
	{
		get
		{
			return xZnidgsIvFB;
		}
		set
		{
			if (flag != xZnidgsIvFB)
			{
				xZnidgsIvFB = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-1346994499 ^ -1346962627));
			}
		}
	}

	[DataMember(Name = "FilterValue")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter")]
	public int FilterMin
	{
		get
		{
			return pt8idRuBGsU;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != pt8idRuBGsU)
			{
				pt8idRuBGsU = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-2056710528 ^ -2056678628));
			}
		}
	}

	[DataMember(Name = "FilterMax")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsFilter")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	public int FilterMax
	{
		get
		{
			return uFOid6VtnND;
		}
		set
		{
			num = Math.Max(0, num);
			if (num == uFOid6VtnND)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
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
				uFOid6VtnND = num;
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-377195341 ^ -377163519));
			}
		}
	}

	[DataMember(Name = "FilterColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter")]
	public XColor FilterColor
	{
		get
		{
			return taJidOZWXIw;
		}
		set
		{
			if (!jwmFQxeLVdIHrfmE5Vqm(xColor, taJidOZWXIw))
			{
				taJidOZWXIw = xColor;
				yT5idMk4fEm = new XBrush(taJidOZWXIw);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)LyPWhPeLZSlXGmayKYAV(-29702950 ^ -29736686));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	[SpecialName]
	private List<VolumeProfile> C58iQccTV6U()
	{
		return Q9uidBl0Rtt ?? (Q9uidBl0Rtt = new List<VolumeProfile>());
	}

	public O2XR1WiQ19qhAdqSxCed()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShowIndicatorTitle = false;
		int num = 4;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
		{
			num = 8;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				ShowValues = false;
				MinimizeValues = false;
				num = 2;
				break;
			case 3:
			{
				ProfileColor = Color.FromArgb(127, 70, 130, 180);
				ProfileBackColor = PalUZjeLrPKa3jHLBlph(K4UHQgeLCf50woYFicTB(30, 70, 130, 180));
				int num2 = 5;
				num = num2;
				break;
			}
			case 1:
				return;
			case 8:
				PeriodType = VolumeProfilesPeriodType.Hour;
				num = 7;
				break;
			case 4:
				MaximumType = VolumeProfilesMaximumType.Volume;
				ShowMaximum = true;
				MaximumColor = PalUZjeLrPKa3jHLBlph(Color.FromArgb(127, 178, 34, 34));
				ShowValueArea = true;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
				{
					num = 0;
				}
				break;
			case 6:
				FilterMax = 0;
				FilterColor = K4UHQgeLCf50woYFicTB(127, 46, 139, 87);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				PeriodValue = 1;
				ProfileType = VolumeProfilesType.Volume;
				ProfileProportion = 0;
				num = 3;
				break;
			default:
				ValueAreaPercent = 70;
				ValueAreaColor = K4UHQgeLCf50woYFicTB(127, 128, 128, 128);
				EnableFilter = false;
				FilterMin = 0;
				num = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
				{
					num = 2;
				}
				break;
			case 2:
				ValuesColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				num = 4;
				break;
			}
		}
	}

	private void Clear()
	{
		CxkidqgKARb = 0;
		C58iQccTV6U().Clear();
	}

	private int MjHiQSe4Ap9(DateTime P_0, double P_1)
	{
		ChartPeriodType type = ChartPeriodType.Hour;
		VolumeProfilesPeriodType volumeProfilesPeriodType = PeriodType;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				type = ChartPeriodType.Month;
				break;
			case 4:
				goto IL_006f;
			case 3:
				goto IL_0094;
			case 2:
				{
					switch (volumeProfilesPeriodType)
					{
					case VolumeProfilesPeriodType.Month:
						break;
					case VolumeProfilesPeriodType.Minute:
						goto IL_006f;
					case VolumeProfilesPeriodType.Day:
						goto IL_0077;
					case VolumeProfilesPeriodType.Week:
						goto IL_0094;
					case VolumeProfilesPeriodType.Hour:
						type = ChartPeriodType.Hour;
						goto end_IL_0009;
					default:
						goto end_IL_0009;
					}
					goto case 1;
				}
				IL_0077:
				type = ChartPeriodType.Day;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
				{
					num = 0;
				}
				continue;
				IL_0094:
				type = ChartPeriodType.Week;
				break;
				IL_006f:
				type = ChartPeriodType.Minute;
				break;
				end_IL_0009:
				break;
			}
			break;
		}
		return base.DataProvider.Period.GetSequence(type, PeriodValue, P_0, P_1);
	}

	protected override void Execute()
	{
		int num;
		if (base.ClearData)
		{
			Clear();
			num = 8;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
			{
				num = 8;
			}
			goto IL_0009;
		}
		goto IL_027c;
		IL_027c:
		if (C58iQccTV6U().Count > 0 && !C58iQccTV6U()[C58iQccTV6U().Count - 1].g1bimqZlmOk)
		{
			num = 3;
			goto IL_0009;
		}
		goto IL_0292;
		IL_0292:
		double sessionOffset = TimeHelper.GetSessionOffset((string)RulswKeLmkVhQFoCaFd5(base.DataProvider.Symbol));
		int num2 = -1;
		int num3 = CxkidqgKARb;
		num = 4;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_0009:
		IRawCluster rawCluster = default(IRawCluster);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 11:
				num3++;
				goto case 4;
			default:
			{
				VolumeProfile volumeProfile = C58iQccTV6U()[C58iQccTV6U().Count - 1];
				volumeProfile.gP8imOxtD9i.AddCluster(rawCluster);
				volumeProfile.r0qimMRaM1h = num3;
				num = 11;
				continue;
			}
			case 3:
				break;
			case 6:
				if (C58iQccTV6U().Count <= 0 || C58iQccTV6U()[C58iQccTV6U().Count - 1].g1bimqZlmOk)
				{
					return;
				}
				goto case 2;
			case 10:
				C58iQccTV6U()[C58iQccTV6U().Count - 1].g1bimqZlmOk = true;
				C58iQccTV6U()[C58iQccTV6U().Count - 1].gP8imOxtD9i.UpdateData();
				goto IL_01f3;
			case 1:
				return;
			case 7:
				if (num3 > CxkidqgKARb)
				{
					CxkidqgKARb = num3;
					int num5 = 10;
					num = num5;
					continue;
				}
				goto IL_01f3;
			case 2:
				C58iQccTV6U()[C58iQccTV6U().Count - 1].gP8imOxtD9i.UpdateData();
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
				{
					num = 0;
				}
				continue;
			case 9:
				if (C58iQccTV6U().Count != 0 && num4 == num2)
				{
					goto default;
				}
				num2 = num4;
				if (C58iQccTV6U().Count > 0)
				{
					num = 7;
					continue;
				}
				goto IL_01f3;
			case 8:
				goto IL_027c;
			case 4:
				if (num3 < MN2BxWeL75CMbThcYfU6(base.DataProvider))
				{
					rawCluster = (IRawCluster)D0xO5XeLh3S8dnAIjkXW(base.DataProvider, num3);
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num = 5;
					}
				}
				else
				{
					num = 6;
				}
				continue;
			case 5:
				{
					num4 = MjHiQSe4Ap9(kbTm7leLwqmg5lgNCE7L(rawCluster), sessionOffset);
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
					{
						num = 9;
					}
					continue;
				}
				IL_01f3:
				C58iQccTV6U().Add(new VolumeProfile(new RawCluster(kbTm7leLwqmg5lgNCE7L(rawCluster)), num3));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		F0mKrqeLK75PQhG1RyuQ(C58iQccTV6U(), C58iQccTV6U().Count - 1);
		goto IL_0292;
	}

	public override void Render(DxVisualQueue P_0)
	{
		if (C58iQccTV6U().Count == 0)
		{
			return;
		}
		long num = (long)(idE21peL8MhKKRI81Shf(base.Canvas) / pk43FteLP6hxM9Ordde2(mDWdZceLAyRaoqCNfOQ1(base.Helper))) - 1;
		if ((long)(base.Canvas.MaxY / base.Helper.DataProvider.Step) + 1 - num > 20000)
		{
			return;
		}
		VolumeProfilesType volumeProfilesType = ProfileType;
		int num2 = 2;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				switch (volumeProfilesType)
				{
				default:
					return;
				case VolumeProfilesType.Delta:
					n3yiQeRFsQY(P_0);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
					{
						num2 = 1;
					}
					break;
				case VolumeProfilesType.BidAsk:
					wKkiQsB7iBp(P_0);
					return;
				case VolumeProfilesType.Volume:
					MnviQxByk3A(P_0);
					num2 = 3;
					break;
				case VolumeProfilesType.Trades:
					haZiQLUc7mc(P_0);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num2 = 0;
					}
					break;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			case 3:
				return;
			}
		}
	}

	private void MnviQxByk3A(DxVisualQueue P_0)
	{
		int num = wrQp2teLJXkSHNWPBea1(base.Canvas);
		int num2 = wrQp2teLJXkSHNWPBea1(base.Canvas) + base.Canvas.Count;
		double num3 = pk43FteLP6hxM9Ordde2(base.DataProvider);
		int num4 = 4;
		long num19 = default(long);
		IChartSymbol symbol = default(IChartSymbol);
		double num27 = default(double);
		XFont font = default(XFont);
		double num21 = default(double);
		long num16 = default(long);
		double num23 = default(double);
		long num18 = default(long);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		double num13 = default(double);
		double y = default(double);
		double num14 = default(double);
		Point point = default(Point);
		List<Point> list = default(List<Point>);
		double num22 = default(double);
		int num12 = default(int);
		List<Tuple<Rect, XBrush>> list3 = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, XBrush>> list2 = default(List<Tuple<Rect, XBrush>>);
		int num7 = default(int);
		double num17 = default(double);
		RawCluster gP8imOxtD9i = default(RawCluster);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		IRawClusterValueArea rawClusterValueArea = default(IRawClusterValueArea);
		long num10 = default(long);
		int num11 = default(int);
		int num9 = default(int);
		double num26 = default(double);
		Rect item = default(Rect);
		int num8 = default(int);
		while (true)
		{
			switch (num4)
			{
			case 6:
				num19 = RE66hNeLF5sUqvgjhyGv(symbol, FilterMax);
				num4 = 2;
				break;
			case 3:
				return;
			case 4:
				symbol = base.DataProvider.Symbol;
				num4 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num4 = 0;
				}
				break;
			case 5:
				num27 = Math.Min(num27, base.Canvas.ChartFont.Size);
				font = new XFont(((XFont)V5MZsreL3AqnNKkrxJ4b(base.Canvas)).Name, num27);
				num21 = tAaUJAeLpYd5C3H2DgnK(base.Canvas) / 2.0;
				num4 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
				{
					num4 = 1;
				}
				break;
			case 2:
				num16 = symbol.CorrectSizeFilter(ProfileProportion);
				num23 = GetY(0.0) - GetY(num3);
				num27 = Math.Min(num23 - 2.0, 18.0) * 96.0 / 72.0;
				num4 = 5;
				break;
			default:
				num18 = symbol.CorrectSizeFilter(FilterMin);
				num4 = 6;
				break;
			case 1:
			{
				int round = RoundValues;
				int num5 = int.MinValue;
				using List<VolumeProfile>.Enumerator enumerator = C58iQccTV6U().GetEnumerator();
				while (enumerator.MoveNext())
				{
					while (true)
					{
						VolumeProfile current = enumerator.Current;
						if (current.r0qimMRaM1h < num)
						{
							break;
						}
						int num6 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
						{
							num6 = 18;
						}
						while (true)
						{
							int num20;
							long num15;
							long val;
							switch (num6)
							{
							case 12:
								foreach (Tuple<Rect, string> item2 in list4)
								{
									P_0.DrawString(item2.Item2, font, tyHidxGCO22, item2.Item1);
								}
								goto end_IL_0228;
							case 1:
								if (num23 > 7.0 && rawClusterItem.Volume > 0)
								{
									list4.Add(new Tuple<Rect, string>(new Rect(num13, y, num14, num23), (string)qkFAM2eefn8JTUemKKOL(symbol, rawClusterItem.Volume, round, MinimizeValues)));
									num20 = 21;
									goto IL_015d;
								}
								goto case 21;
							case 3:
								break;
							case 19:
							{
								XBrush brush = lrJidNNdgw3;
								double x3 = num13;
								point = list[0];
								P_0.FillRectangle(brush, new Rect(new Point(x3, point.Y), new Point(num22, num12)));
								P_0.FillPolygon(OF6idDi9O2L, (Point[])esECbdeen2RJs6cvkApL(list));
								foreach (Tuple<Rect, XBrush> item3 in list3)
								{
									P_0.FillRectangle(item3.Item2, item3.Item1);
									int num24 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
									{
										num24 = 0;
									}
									switch (num24)
									{
									}
								}
								foreach (Tuple<Rect, XBrush> item4 in list2)
								{
									int num25 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
									{
										num25 = 0;
									}
									switch (num25)
									{
									}
									BeKOdseeGGcOAQnbivXL(P_0, item4.Item2, item4.Item1);
								}
								goto case 12;
							}
							case 33:
								list2 = new List<Tuple<Rect, XBrush>>();
								num6 = 23;
								continue;
							case 29:
								if (ShowMaximum)
								{
									num6 = 20;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
									{
										num6 = 17;
									}
									continue;
								}
								goto case 7;
							case 27:
								num7 = (int)(num13 + num17);
								num6 = 34;
								continue;
							case 22:
							{
								double x = base.Canvas.GetX(current.tsYim6JrMO3);
								double x2 = base.Canvas.GetX(current.r0qimMRaM1h);
								gP8imOxtD9i = current.gP8imOxtD9i;
								maxValues = gP8imOxtD9i.MaxValues;
								rawClusterValueArea = (ShowValueArea ? gP8imOxtD9i.GetValueArea(ValueAreaPercent) : null);
								num13 = x - num21;
								num22 = x2 + num21 - 1.0;
								if (num5 != int.MinValue)
								{
									num6 = 11;
									continue;
								}
								goto IL_0a82;
							}
							default:
								num10 = gP8imOxtD9i.High;
								num6 = 32;
								continue;
							case 17:
								list3.Add(new Tuple<Rect, XBrush>(new Rect(num13, y, num17, num11), yT5idMk4fEm));
								goto case 10;
							case 34:
								num9 = (int)GetY(((double)num10 - 0.5) * num3);
								num11 = Math.Max(num9 - num12, 1);
								if (num9 == num12 && xE7ULnee2fouKiJHkFUf(list) > 2)
								{
									num6 = 9;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
									{
										num6 = 6;
									}
									continue;
								}
								goto case 5;
							case 26:
								point = list[xE7ULnee2fouKiJHkFUf(list) - 2];
								num6 = 4;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
								{
									num6 = 16;
								}
								continue;
							case 7:
								if (rawClusterValueArea == null || (rawClusterItem.Price != oa0PG8eeHmbZBqpVGxRB(rawClusterValueArea) && rawClusterItem.Price != rawClusterValueArea.Val))
								{
									if (EnableFilter)
									{
										num6 = 14;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto case 10;
								}
								list2.Add(new Tuple<Rect, XBrush>(new Rect(num13, y, num14, num11), Bq1idQsc5Di));
								num6 = 31;
								continue;
							case 32:
								if (num10 >= LXSJ11ee9ZYjm5Mm7FJF(gP8imOxtD9i))
								{
									rawClusterItem = gP8imOxtD9i.GetItem(num10) ?? new RawClusterItem(num10);
									num17 = A4EqKqee0I9SmcXvalbY(num26 * (double)BdtEaLeLz3YWuuaIMO5r(rawClusterItem), num14);
									num6 = 17;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d != 0)
									{
										num6 = 27;
									}
								}
								else
								{
									list.Add(new Point(num13, num12));
									num6 = 19;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
									{
										num6 = 7;
									}
								}
								continue;
							case 8:
								if (num17 > item.Width)
								{
									list3[list3.Count - 1] = new Tuple<Rect, XBrush>(new Rect(num13, y, num17, item.Height), yT5idMk4fEm);
								}
								goto case 10;
							case 16:
								y = point.Y;
								num6 = 29;
								continue;
							case 10:
							case 24:
							case 31:
								if (ShowValues)
								{
									num6 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa == 0)
									{
										num6 = 1;
									}
									continue;
								}
								goto case 21;
							case 15:
								num15 = maxValues.MaxVolume;
								goto IL_0b71;
							case 13:
								num8 = num7;
								goto IL_01f7;
							case 2:
							{
								list[list.Count - 2] = new Point(num7, list[xE7ULnee2fouKiJHkFUf(list) - 2].Y);
								List<Point> list5 = list;
								int index = list.Count - 1;
								double x4 = num7;
								point = list[list.Count - 1];
								list5[index] = new Point(x4, point.Y);
								num6 = 13;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
								{
									num6 = 2;
								}
								continue;
							}
							case 20:
								if (QfGiQXIFENj(gP8imOxtD9i, rawClusterItem, maxValues))
								{
									list2.Add(new Tuple<Rect, XBrush>(new Rect(num13, y, num14, num11), DvKidXeBaR4));
									num20 = 10;
									goto IL_015d;
								}
								goto case 7;
							case 6:
								list3.Add(new Tuple<Rect, XBrush>(new Rect(num13, y, num17, num11), yT5idMk4fEm));
								num6 = 24;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
								{
									num6 = 14;
								}
								continue;
							case 5:
								list.Add(new Point(num7, num12));
								num6 = 4;
								continue;
							case 11:
								num13 = num5;
								goto IL_0a82;
							case 25:
								if ((int)item.Y == (int)y)
								{
									num6 = 8;
									continue;
								}
								goto case 6;
							case 30:
								list3 = new List<Tuple<Rect, XBrush>>();
								num6 = 33;
								continue;
							case 21:
								num10--;
								goto case 32;
							case 23:
								list4 = new List<Tuple<Rect, string>>();
								num8 = (int)num13;
								num12 = (int)GetY(((double)yxEspIeLul2itdLbf3Hk(gP8imOxtD9i) + 0.5) * num3);
								list = new List<Point>
								{
									new Point(num8, num12)
								};
								num6 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
								{
									num6 = 0;
								}
								continue;
							case 14:
								if (BdtEaLeLz3YWuuaIMO5r(rawClusterItem) >= num18 && (num19 == 0L || BdtEaLeLz3YWuuaIMO5r(rawClusterItem) <= num19))
								{
									if (list3.Count > 0)
									{
										item = list3[list3.Count - 1].Item1;
										num6 = 25;
										continue;
									}
									goto case 17;
								}
								goto case 10;
							case 4:
								list.Add(new Point(num7, num9));
								num8 = num7;
								goto IL_01f7;
							case 18:
								if (current.tsYim6JrMO3 <= num2)
								{
									num6 = 22;
									continue;
								}
								goto end_IL_0228;
							case 28:
								if (ProfileProportion <= 0)
								{
									num6 = 7;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd != 0)
									{
										num6 = 15;
									}
									continue;
								}
								num15 = num16;
								goto IL_0b71;
							case 9:
								{
									if (num7 > num8)
									{
										num6 = 2;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto IL_01f7;
								}
								IL_015d:
								num6 = num20;
								continue;
								IL_0a82:
								num5 = (int)num22;
								num14 = Math.Max(num22 - num13, 1.0);
								num6 = 28;
								continue;
								IL_01f7:
								num12 = num9;
								num6 = 26;
								continue;
								IL_0b71:
								val = num15;
								num26 = num14 / (double)Math.Max(val, 1L);
								num6 = 30;
								continue;
							}
							break;
						}
						continue;
						end_IL_0228:
						break;
					}
				}
				return;
			}
			}
		}
	}

	private void haZiQLUc7mc(DxVisualQueue P_0)
	{
		int num = 2;
		int num2 = num;
		int num4 = default(int);
		int stop = default(int);
		double num7 = default(double);
		double num21 = default(double);
		IChartSymbol symbol = default(IChartSymbol);
		double num19 = default(double);
		XFont font = default(XFont);
		List<Tuple<Rect, XBrush>> list = default(List<Tuple<Rect, XBrush>>);
		double y = default(double);
		double num10 = default(double);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num17 = default(int);
		int num16 = default(int);
		List<Point> list3 = default(List<Point>);
		long num20 = default(long);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		int val = default(int);
		List<Tuple<Rect, XBrush>> list2 = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator2 = default(List<Tuple<Rect, XBrush>>.Enumerator);
		double num18 = default(double);
		double num11 = default(double);
		Rect item = default(Rect);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = base.Canvas.Stop + base.Canvas.Count;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				stop = base.Canvas.Stop;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				num7 = tAaUJAeLpYd5C3H2DgnK(base.Canvas) / 2.0;
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				num21 = pk43FteLP6hxM9Ordde2(base.DataProvider);
				symbol = base.DataProvider.Symbol;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				num19 = GetY(0.0) - GetY(num21);
				double num23 = Math.Min(num19 - 2.0, 18.0) * 96.0 / 72.0;
				num23 = A4EqKqee0I9SmcXvalbY(num23, tPQAjGeeYfmuLN6tjvcU(base.Canvas.ChartFont));
				font = new XFont(base.Canvas.ChartFont.Name, num23);
				num2 = 3;
				break;
			}
			case 5:
			{
				int round = RoundValues;
				int num3 = int.MinValue;
				{
					foreach (VolumeProfile item2 in C58iQccTV6U())
					{
						if (item2.r0qimMRaM1h < stop || item2.tsYim6JrMO3 > num4)
						{
							continue;
						}
						double x = base.Canvas.GetX(item2.tsYim6JrMO3);
						double num5 = OVxPCgeeoddVBNUy0U9o(base.Canvas, item2.r0qimMRaM1h);
						RawCluster gP8imOxtD9i = item2.gP8imOxtD9i;
						IRawClusterMaxValues maxValues = gP8imOxtD9i.MaxValues;
						IRawClusterValueArea rawClusterValueArea = (ShowValueArea ? gP8imOxtD9i.GetValueArea(ValueAreaPercent) : null);
						double num6 = x - num7;
						double num8 = num5 + num7 - 1.0;
						if (num3 != int.MinValue)
						{
							num6 = num3;
						}
						num3 = (int)num8;
						int num9 = 29;
						while (true)
						{
							int num15;
							switch (num9)
							{
							case 26:
								list.Add(new Tuple<Rect, XBrush>(new Rect(num6, y, num10, num12), yT5idMk4fEm));
								num9 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
								{
									num9 = 1;
								}
								continue;
							case 5:
								num13 = num14;
								goto IL_0257;
							case 31:
								if (num17 == num16)
								{
									num15 = 10;
									goto IL_0107;
								}
								goto case 12;
							case 8:
								num16 = (int)GetY(((double)gP8imOxtD9i.High + 0.5) * num21);
								list3 = new List<Point>
								{
									new Point(num13, num16)
								};
								num20 = yxEspIeLul2itdLbf3Hk(gP8imOxtD9i);
								goto IL_01f6;
							case 7:
								if (rawClusterItem.Trades >= FilterMin)
								{
									num9 = 14;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
									{
										num9 = 14;
									}
									continue;
								}
								goto case 1;
							case 4:
								val = ((ProfileProportion > 0) ? ProfileProportion : DMURBteevwjxKNZ3n5hn(maxValues));
								num9 = 10;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
								{
									num9 = 33;
								}
								continue;
							case 23:
								list2 = new List<Tuple<Rect, XBrush>>();
								list4 = new List<Tuple<Rect, string>>();
								num13 = (int)num6;
								num9 = 8;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
								{
									num9 = 2;
								}
								continue;
							case 15:
								enumerator2 = list.GetEnumerator();
								num9 = 3;
								continue;
							case 1:
							case 16:
								if (ShowValues)
								{
									num9 = 22;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
									{
										num9 = 21;
									}
									continue;
								}
								goto IL_0275;
							case 9:
								num10 = Math.Min(num18 * (double)rawClusterItem.Trades, num11);
								num9 = 18;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
								{
									num9 = 3;
								}
								continue;
							case 11:
								if (list.Count > 0)
								{
									num9 = 27;
									continue;
								}
								goto case 26;
							case 34:
								break;
							case 33:
								num18 = num11 / (double)Math.Max(val, 1);
								list = new List<Tuple<Rect, XBrush>>();
								num9 = 23;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
								{
									num9 = 6;
								}
								continue;
							default:
								list3.Add(new Point(num6, num16));
								num9 = 32;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 != 0)
								{
									num9 = 30;
								}
								continue;
							case 19:
								y = list3[list3.Count - 2].Y;
								if (!ShowMaximum || !QfGiQXIFENj(gP8imOxtD9i, rawClusterItem, maxValues))
								{
									if (rawClusterValueArea != null)
									{
										if (BFRqF8eeB87GdkGUDfZx(rawClusterItem) != oa0PG8eeHmbZBqpVGxRB(rawClusterValueArea))
										{
											num9 = 20;
											continue;
										}
										goto IL_044b;
									}
									goto case 30;
								}
								num9 = 21;
								continue;
							case 3:
								try
								{
									while (enumerator2.MoveNext())
									{
										Tuple<Rect, XBrush> current2 = enumerator2.Current;
										BeKOdseeGGcOAQnbivXL(P_0, current2.Item2, current2.Item1);
									}
								}
								finally
								{
									((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								}
								enumerator2 = list2.GetEnumerator();
								num9 = 34;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
								{
									num9 = 15;
								}
								continue;
							case 25:
								if (num10 > item.Width)
								{
									num9 = 24;
									continue;
								}
								goto case 1;
							case 29:
								num11 = Math.Max(num8 - num6, 1.0);
								num9 = 4;
								continue;
							case 28:
								num17 = (int)GetY(((double)num20 - 0.5) * num21);
								num12 = Math.Max(num17 - num16, 1);
								num9 = 31;
								continue;
							case 22:
								if (num19 > 7.0 && rawClusterItem.Trades > 0)
								{
									list4.Add(new Tuple<Rect, string>(new Rect(num6, y, num11, num19), symbol.FormatTrades(rawClusterItem.Trades, round, MinimizeValues)));
								}
								goto IL_0275;
							case 32:
								P_0.FillRectangle(lrJidNNdgw3, new Rect(new Point(num6, list3[0].Y), new Point(num8, num16)));
								P_0.FillPolygon(OF6idDi9O2L, (Point[])esECbdeen2RJs6cvkApL(list3));
								num9 = 5;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
								{
									num9 = 15;
								}
								continue;
							case 2:
								if (num14 > num13)
								{
									num9 = 17;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
									{
										num9 = 3;
									}
									continue;
								}
								goto IL_0257;
							case 30:
								if (EnableFilter)
								{
									num15 = 7;
									goto IL_0107;
								}
								goto case 1;
							case 17:
								list3[list3.Count - 2] = new Point(num14, list3[list3.Count - 2].Y);
								list3[xE7ULnee2fouKiJHkFUf(list3) - 1] = new Point(num14, list3[list3.Count - 1].Y);
								num13 = num14;
								goto IL_0257;
							case 20:
								if (rawClusterItem.Price == rawClusterValueArea.Val)
								{
									goto IL_044b;
								}
								goto case 30;
							case 10:
								if (xE7ULnee2fouKiJHkFUf(list3) > 2)
								{
									num9 = 2;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
									{
										num9 = 2;
									}
									continue;
								}
								goto case 12;
							case 21:
								list2.Add(new Tuple<Rect, XBrush>(new Rect(num6, y, num11, num12), DvKidXeBaR4));
								goto case 1;
							case 13:
								rawClusterItem = gP8imOxtD9i.GetItem(num20) ?? new RawClusterItem(num20);
								num9 = 9;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
								{
									num9 = 3;
								}
								continue;
							case 27:
								item = list[list.Count - 1].Item1;
								num9 = 6;
								continue;
							case 18:
								num14 = (int)(num6 + num10);
								num9 = 28;
								continue;
							case 6:
								if ((int)item.Y != (int)y)
								{
									list.Add(new Tuple<Rect, XBrush>(new Rect(num6, y, num10, num12), yT5idMk4fEm));
									goto case 1;
								}
								num9 = 16;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
								{
									num9 = 25;
								}
								continue;
							case 12:
								list3.Add(new Point(num14, num16));
								list3.Add(new Point(num14, num17));
								num9 = 5;
								continue;
							case 14:
								if (FilterMax != 0)
								{
									if (rawClusterItem.Trades <= FilterMax)
									{
										num9 = 9;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
										{
											num9 = 11;
										}
										continue;
									}
									goto case 1;
								}
								goto case 11;
							case 24:
								{
									list[list.Count - 1] = new Tuple<Rect, XBrush>(new Rect(num6, y, num10, item.Height), yT5idMk4fEm);
									goto case 1;
								}
								IL_044b:
								list2.Add(new Tuple<Rect, XBrush>(new Rect(num6, y, num11, num12), Bq1idQsc5Di));
								num9 = 16;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
								{
									num9 = 13;
								}
								continue;
								IL_0257:
								num16 = num17;
								num9 = 19;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
								{
									num9 = 1;
								}
								continue;
								IL_0275:
								num20--;
								goto IL_01f6;
								IL_0107:
								num9 = num15;
								continue;
								IL_01f6:
								if (num20 < LXSJ11ee9ZYjm5Mm7FJF(gP8imOxtD9i))
								{
									num9 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b != 0)
									{
										num9 = 0;
									}
									continue;
								}
								goto case 13;
							}
							break;
						}
						try
						{
							while (enumerator2.MoveNext())
							{
								Tuple<Rect, XBrush> current3 = enumerator2.Current;
								BeKOdseeGGcOAQnbivXL(P_0, current3.Item2, current3.Item1);
							}
						}
						finally
						{
							((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
						}
						using List<Tuple<Rect, string>>.Enumerator enumerator3 = list4.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							Tuple<Rect, string> current4 = enumerator3.Current;
							P_0.DrawString(current4.Item2, font, tyHidxGCO22, current4.Item1);
						}
						int num22 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
					return;
				}
			}
			}
		}
	}

	private void n3yiQeRFsQY(DxVisualQueue P_0)
	{
		int stop = base.Canvas.Stop;
		int num = wrQp2teLJXkSHNWPBea1(base.Canvas) + base.Canvas.Count;
		double num2 = pk43FteLP6hxM9Ordde2(base.DataProvider);
		int num3 = 5;
		IChartSymbol symbol = default(IChartSymbol);
		long num7 = default(long);
		double num6 = default(double);
		XFont font = default(XFont);
		long num5 = default(long);
		long num4 = default(long);
		List<Point> list = default(List<Point>);
		int num26 = default(int);
		int num27 = default(int);
		RawCluster gP8imOxtD9i = default(RawCluster);
		IRawClusterItem rawClusterItem4 = default(IRawClusterItem);
		IRawClusterMaxValues rawClusterMaxValues = default(IRawClusterMaxValues);
		double num17 = default(double);
		double num23 = default(double);
		int num18 = default(int);
		IRawClusterItem rawClusterItem3 = default(IRawClusterItem);
		long num12 = default(long);
		List<Point> list2 = default(List<Point>);
		int num30 = default(int);
		int num16 = default(int);
		double y2 = default(double);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator2 = default(List<Tuple<Rect, XBrush>>.Enumerator);
		double num22 = default(double);
		int num28 = default(int);
		int num25 = default(int);
		long num11 = default(long);
		double num14 = default(double);
		IRawClusterValueArea rawClusterValueArea = default(IRawClusterValueArea);
		Rect item = default(Rect);
		List<Tuple<Rect, XBrush>> list4 = default(List<Tuple<Rect, XBrush>>);
		double y = default(double);
		int num29 = default(int);
		double num20 = default(double);
		double num21 = default(double);
		List<Tuple<Rect, string>>.Enumerator enumerator3 = default(List<Tuple<Rect, string>>.Enumerator);
		List<Tuple<Rect, string>> list6 = default(List<Tuple<Rect, string>>);
		List<Tuple<Rect, string>> list7 = default(List<Tuple<Rect, string>>);
		double num13 = default(double);
		double num15 = default(double);
		List<Tuple<Rect, XBrush>> list5 = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, XBrush>> list3 = default(List<Tuple<Rect, XBrush>>);
		while (true)
		{
			switch (num3)
			{
			case 4:
				return;
			case 5:
				symbol = base.DataProvider.Symbol;
				num3 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
				{
					num3 = 1;
				}
				continue;
			case 2:
				num7 = RE66hNeLF5sUqvgjhyGv(symbol, FilterMax);
				num3 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
				{
					num3 = 3;
				}
				continue;
			case 6:
			{
				double val = A4EqKqee0I9SmcXvalbY(num6 - 2.0, 18.0) * 96.0 / 72.0;
				val = Math.Min(val, base.Canvas.ChartFont.Size);
				font = new XFont((string)sNjdW0eeaaBnKBvgmlyf(base.Canvas.ChartFont), val);
				num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
				{
					num3 = 0;
				}
				continue;
			}
			case 3:
				num5 = symbol.CorrectSizeFilter(ProfileProportion);
				num6 = GetY(0.0) - GetY(num2);
				num3 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num3 = 0;
				}
				continue;
			case 1:
				num4 = RE66hNeLF5sUqvgjhyGv(symbol, FilterMin);
				num3 = 2;
				continue;
			}
			double num8 = tAaUJAeLpYd5C3H2DgnK(base.Canvas) / 2.0;
			int round = RoundValues;
			int num9 = int.MinValue;
			using List<VolumeProfile>.Enumerator enumerator = C58iQccTV6U().GetEnumerator();
			while (enumerator.MoveNext())
			{
				while (true)
				{
					VolumeProfile current = enumerator.Current;
					if (current.r0qimMRaM1h < stop)
					{
						break;
					}
					int num10 = 54;
					while (true)
					{
						int num24;
						double num19;
						object rawClusterItem;
						object rawClusterItem2;
						switch (num10)
						{
						case 31:
							list.Add(new Point(num26, num27));
							num10 = 50;
							continue;
						case 57:
							if (QfGiQXIFENj(gP8imOxtD9i, rawClusterItem4, rawClusterMaxValues))
							{
								goto IL_0e41;
							}
							goto IL_1184;
						default:
							num26 = (int)(num17 - num23);
							num10 = 36;
							continue;
						case 44:
							num18 = (int)GetY(((double)yxEspIeLul2itdLbf3Hk(gP8imOxtD9i) + 0.5) * num2);
							num10 = 28;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
							{
								num10 = 49;
							}
							continue;
						case 41:
							if (rawClusterItem3.Delta > num7)
							{
								goto case 8;
							}
							goto IL_0be3;
						case 7:
						case 13:
							if (num12 < LXSJ11ee9ZYjm5Mm7FJF(gP8imOxtD9i))
							{
								list2.Add(new Point(num17, num18));
								num10 = 23;
								continue;
							}
							goto case 12;
						case 60:
							if (-rawClusterItem4.Delta <= num7)
							{
								goto IL_0a31;
							}
							goto IL_0e41;
						case 61:
							if (xE7ULnee2fouKiJHkFUf(list2) <= 2)
							{
								goto IL_0dba;
							}
							if (num30 > num16)
							{
								list2[xE7ULnee2fouKiJHkFUf(list2) - 2] = new Point(num30, list2[xE7ULnee2fouKiJHkFUf(list2) - 2].Y);
								list2[list2.Count - 1] = new Point(num30, list2[list2.Count - 1].Y);
								num10 = 15;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
								{
									num10 = 5;
								}
								continue;
							}
							goto IL_1261;
						case 37:
							y2 = list2[list2.Count - 2].Y;
							num10 = 40;
							continue;
						case 63:
							try
							{
								while (enumerator2.MoveNext())
								{
									Tuple<Rect, XBrush> current2 = enumerator2.Current;
									BeKOdseeGGcOAQnbivXL(P_0, current2.Item2, current2.Item1);
								}
								int num31 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
								{
									num31 = 0;
								}
								switch (num31)
								{
								case 0:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
							}
							goto case 28;
						case 21:
							num30 = (int)(num17 + num22);
							num28 = (int)GetY(((double)num12 - 0.5) * num2);
							num25 = Math.Max(num28 - num18, 1);
							num10 = 30;
							continue;
						case 2:
							num11 = yxEspIeLul2itdLbf3Hk(gP8imOxtD9i);
							goto IL_0771;
						case 3:
							num14 = OVxPCgeeoddVBNUy0U9o(base.Canvas, current.tsYim6JrMO3);
							num10 = 6;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 != 0)
							{
								num10 = 6;
							}
							continue;
						case 22:
							if (BFRqF8eeB87GdkGUDfZx(rawClusterItem4) != rawClusterValueArea.Val)
							{
								num10 = 16;
								continue;
							}
							goto IL_0e41;
						case 53:
							list[xE7ULnee2fouKiJHkFUf(list) - 1] = new Point(num26, list[list.Count - 1].Y);
							num10 = 62;
							continue;
						case 30:
							if (num28 <= num18)
							{
								num24 = 61;
								goto IL_0171;
							}
							goto IL_0dba;
						case 26:
							break;
						case 55:
							num19 = 0.0;
							goto IL_13aa;
						case 8:
						case 33:
							if (ShowValues)
							{
								num10 = 42;
								continue;
							}
							goto IL_07ff;
						case 17:
							item = list4[list4.Count - 1].Item1;
							if ((int)item.Y == (int)y)
							{
								if (num23 > item.Width)
								{
									num10 = 25;
									continue;
								}
								goto IL_0e41;
							}
							goto case 27;
						case 46:
							list4.Add(new Tuple<Rect, XBrush>(new Rect(num17 - num23, y, num23, num29), yT5idMk4fEm));
							goto IL_0e41;
						case 49:
							list2 = new List<Point>
							{
								new Point(num16, num18)
							};
							num12 = gP8imOxtD9i.High;
							num10 = 3;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
							{
								num10 = 7;
							}
							continue;
						case 29:
							if (kE4mWueebBnaR6LLqllP(rawClusterItem4) >= 0)
							{
								num10 = 26;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
								{
									num10 = 55;
								}
								continue;
							}
							num19 = A4EqKqee0I9SmcXvalbY(num20 * (double)UWlGXWee1cCt10WaqN2g(kE4mWueebBnaR6LLqllP(rawClusterItem4)), num21) / 2.0;
							goto IL_13aa;
						case 47:
							if (rawClusterItem3.Price != GcFkckeeNsaSgKweDxu1(rawClusterValueArea))
							{
								goto case 45;
							}
							goto IL_1115;
						case 28:
							enumerator3 = list6.GetEnumerator();
							num10 = 26;
							continue;
						case 34:
							rawClusterItem = gP8imOxtD9i.GetItem(num11);
							if (rawClusterItem == null)
							{
								num10 = 1;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
								{
									num10 = 1;
								}
								continue;
							}
							goto IL_136d;
						case 42:
							if (num6 > 7.0 && rawClusterItem3.Delta > 0)
							{
								list7.Add(new Tuple<Rect, string>(new Rect(num17 + 2.0, y2, num21 / 2.0, num6), symbol.FormatRawSize(rawClusterItem3.Delta, round, MinimizeValues)));
							}
							goto IL_07ff;
						case 4:
							if (rawClusterItem4.Price != rawClusterValueArea.Vah)
							{
								num10 = 22;
								continue;
							}
							goto IL_0e41;
						case 59:
							if (num9 != int.MinValue)
							{
								num13 = num9;
							}
							num9 = (int)num15;
							num10 = 48;
							continue;
						case 43:
							num29 = ckRYJeeLyQi2egymkeiI(num27 - num18, 1);
							num10 = 56;
							continue;
						case 16:
							if (EnableFilter && kE4mWueebBnaR6LLqllP(rawClusterItem4) < 0 && -rawClusterItem4.Delta >= num4)
							{
								num10 = 11;
								continue;
							}
							goto IL_0e41;
						case 5:
							if (rawClusterItem4.Delta < 0)
							{
								num10 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
								{
									num10 = 9;
								}
								continue;
							}
							goto IL_1013;
						case 9:
							list6.Add(new Tuple<Rect, string>(new Rect(num13, y, num21 / 2.0 - 2.0, num6), (string)qkFAM2eefn8JTUemKKOL(symbol, rawClusterItem4.Delta, round, MinimizeValues)));
							goto IL_1013;
						case 35:
							goto end_IL_0175;
						case 51:
						{
							dO9Nk3ee5EvioxLPhJ4b(P_0, OF6idDi9O2L, list2.ToArray());
							foreach (Tuple<Rect, XBrush> item3 in list4)
							{
								BeKOdseeGGcOAQnbivXL(P_0, item3.Item2, item3.Item1);
								int num32 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
								{
									num32 = 0;
								}
								switch (num32)
								{
								}
							}
							using (List<Tuple<Rect, XBrush>>.Enumerator enumerator4 = list5.GetEnumerator())
							{
								while (enumerator4.MoveNext())
								{
									Tuple<Rect, XBrush> current4 = enumerator4.Current;
									P_0.FillRectangle(current4.Item2, current4.Item1);
								}
								int num33 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
								{
									num33 = 0;
								}
								switch (num33)
								{
								case 0:
									break;
								}
							}
							enumerator2 = list3.GetEnumerator();
							num10 = 63;
							continue;
						}
						case 62:
							num16 = num26;
							num10 = 13;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
							{
								num10 = 24;
							}
							continue;
						case 25:
							list4[gxMENJeekGCjIaZpmnB8(list4) - 1] = new Tuple<Rect, XBrush>(new Rect(num17 - num23, y, num23, item.Height), yT5idMk4fEm);
							goto IL_0e41;
						case 20:
							if (num7 != 0L)
							{
								num10 = 41;
								continue;
							}
							goto IL_0be3;
						case 15:
							num16 = num30;
							goto IL_1261;
						case 45:
							if (EnableFilter && kE4mWueebBnaR6LLqllP(rawClusterItem3) > 0)
							{
								num10 = 32;
								continue;
							}
							goto case 8;
						case 32:
							if (rawClusterItem3.Delta >= num4)
							{
								num10 = 19;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
								{
									num10 = 20;
								}
								continue;
							}
							goto case 8;
						case 12:
							rawClusterItem2 = gP8imOxtD9i.GetItem(num12);
							if (rawClusterItem2 == null)
							{
								num10 = 7;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
								{
									num10 = 10;
								}
								continue;
							}
							goto IL_130d;
						case 50:
							num16 = num26;
							goto case 24;
						case 11:
							if (num7 != 0L)
							{
								num10 = 60;
								continue;
							}
							goto IL_0a31;
						case 56:
							if (num27 <= num18 && list.Count > 2)
							{
								if (num26 >= num16)
								{
									goto case 24;
								}
								list[list.Count - 2] = new Point(num26, list[list.Count - 2].Y);
								num24 = 53;
							}
							else
							{
								list.Add(new Point(num26, num18));
								num24 = 31;
							}
							goto IL_0171;
						case 39:
						{
							Rect item2 = list5[list5.Count - 1].Item1;
							if ((int)item2.Y != (int)y2)
							{
								list5.Add(new Tuple<Rect, XBrush>(new Rect(num17, y2, num22, num25), yT5idMk4fEm));
								num24 = 33;
								goto IL_0171;
							}
							if (num22 > item2.Width)
							{
								list5[gxMENJeekGCjIaZpmnB8(list5) - 1] = new Tuple<Rect, XBrush>(new Rect(num17, y2, num22, item2.Height), yT5idMk4fEm);
								num10 = 8;
								continue;
							}
							goto case 8;
						}
						case 19:
							list2.Add(new Point(num30, num28));
							num16 = num30;
							goto IL_1261;
						case 36:
							num27 = (int)GetY(((double)num11 - 0.5) * num2);
							num10 = 21;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
							{
								num10 = 43;
							}
							continue;
						case 40:
							if (ShowMaximum)
							{
								if (!QfGiQXIFENj(gP8imOxtD9i, rawClusterItem3, rawClusterMaxValues))
								{
									num10 = 48;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
									{
										num10 = 58;
									}
									continue;
								}
								list3.Add(new Tuple<Rect, XBrush>(new Rect(num13, y2, num21, num25), DvKidXeBaR4));
								goto case 8;
							}
							goto case 52;
						case 52:
						case 58:
							if (rawClusterValueArea != null)
							{
								num10 = 18;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
								{
									num10 = 18;
								}
								continue;
							}
							goto case 45;
						case 48:
						{
							num21 = zKXN8VeelYLfVVtsjO65(num15 - num13, 1.0);
							long val2 = ((ProfileProportion > 0) ? num5 : rQvEjPeeDmw0Ob17ypT3(Math.Abs(yCZFkjee4l1jbwiWmglq(rawClusterMaxValues)), Math.Abs(rawClusterMaxValues.MaxDelta)));
							num20 = num21 / (double)Math.Max(val2, 1L);
							list3 = new List<Tuple<Rect, XBrush>>();
							list4 = new List<Tuple<Rect, XBrush>>();
							list5 = new List<Tuple<Rect, XBrush>>();
							list6 = new List<Tuple<Rect, string>>();
							list7 = new List<Tuple<Rect, string>>();
							num17 = num13 + num21 / 2.0;
							num16 = (int)num17;
							num10 = 44;
							continue;
						}
						case 38:
							num22 = ((kE4mWueebBnaR6LLqllP(rawClusterItem3) > 0) ? (A4EqKqee0I9SmcXvalbY(num20 * (double)Math.Abs(rawClusterItem3.Delta), num21) / 2.0) : 0.0);
							num10 = 5;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
							{
								num10 = 21;
							}
							continue;
						case 18:
							if (rawClusterItem3.Price != rawClusterValueArea.Vah)
							{
								num10 = 47;
								continue;
							}
							goto IL_1115;
						case 54:
							goto IL_104f;
						case 24:
							num18 = num27;
							y = list[xE7ULnee2fouKiJHkFUf(list) - 2].Y;
							if (ShowMaximum)
							{
								num10 = 8;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
								{
									num10 = 57;
								}
								continue;
							}
							goto IL_1184;
						case 14:
							list = new List<Point>
							{
								new Point(num16, num18)
							};
							num10 = 2;
							continue;
						case 23:
							num16 = (int)num17;
							num18 = (int)GetY(((double)yxEspIeLul2itdLbf3Hk(gP8imOxtD9i) + 0.5) * num2);
							num10 = 14;
							continue;
						case 27:
							list4.Add(new Tuple<Rect, XBrush>(new Rect(num17 - num23, y, num23, num29), yT5idMk4fEm));
							goto IL_0e41;
						case 6:
						{
							double x = base.Canvas.GetX(current.r0qimMRaM1h);
							gP8imOxtD9i = current.gP8imOxtD9i;
							rawClusterMaxValues = (IRawClusterMaxValues)Rq24eaeei09xSdnvFdaG(gP8imOxtD9i);
							rawClusterValueArea = (ShowValueArea ? gP8imOxtD9i.GetValueArea(ValueAreaPercent) : null);
							num13 = num14 - num8;
							num15 = x + num8 - 1.0;
							num10 = 59;
							continue;
						}
						case 10:
							rawClusterItem2 = new RawClusterItem(num12);
							goto IL_130d;
						case 1:
							{
								rawClusterItem = new RawClusterItem(num11);
								goto IL_136d;
							}
							IL_1184:
							if (rawClusterValueArea != null)
							{
								num10 = 4;
								continue;
							}
							goto case 16;
							IL_1013:
							num11--;
							goto IL_0771;
							IL_130d:
							rawClusterItem3 = (IRawClusterItem)rawClusterItem2;
							num10 = 21;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
							{
								num10 = 38;
							}
							continue;
							IL_0771:
							if (num11 < LXSJ11ee9ZYjm5Mm7FJF(gP8imOxtD9i))
							{
								list.Add(new Point(num17, num18));
								P_0.FillRectangle(lrJidNNdgw3, new Rect(new Point(num13, list[0].Y), new Point(num15, num18)));
								dO9Nk3ee5EvioxLPhJ4b(P_0, OF6idDi9O2L, list.ToArray());
								num24 = 51;
								goto IL_0171;
							}
							goto case 34;
							IL_0be3:
							if (list5.Count > 0)
							{
								num10 = 36;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
								{
									num10 = 39;
								}
								continue;
							}
							list5.Add(new Tuple<Rect, XBrush>(new Rect(num17, y2, num22, num25), yT5idMk4fEm));
							goto case 8;
							IL_0171:
							num10 = num24;
							continue;
							IL_13aa:
							num23 = num19;
							num10 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
							{
								num10 = 0;
							}
							continue;
							IL_0e41:
							if (ShowValues && num6 > 7.0)
							{
								num10 = 5;
								continue;
							}
							goto IL_1013;
							IL_07ff:
							num12--;
							num10 = 13;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
							{
								num10 = 11;
							}
							continue;
							IL_136d:
							rawClusterItem4 = (IRawClusterItem)rawClusterItem;
							num10 = 29;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
							{
								num10 = 20;
							}
							continue;
							IL_1261:
							num18 = num28;
							num10 = 37;
							continue;
							IL_0dba:
							list2.Add(new Point(num30, num18));
							num24 = 19;
							goto IL_0171;
							IL_0a31:
							if (list4.Count > 0)
							{
								num24 = 17;
								goto IL_0171;
							}
							goto case 46;
							IL_1115:
							list3.Add(new Tuple<Rect, XBrush>(new Rect(num13, y2, num21, num25), Bq1idQsc5Di));
							goto case 8;
						}
						try
						{
							while (enumerator3.MoveNext())
							{
								Tuple<Rect, string> current5 = enumerator3.Current;
								P_0.DrawString(current5.Item2, font, tyHidxGCO22, current5.Item1, XTextAlignment.Right);
								int num34 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
								{
									num34 = 0;
								}
								switch (num34)
								{
								}
							}
						}
						finally
						{
							((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
						}
						enumerator3 = list7.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								Tuple<Rect, string> current6 = enumerator3.Current;
								P_0.DrawString(current6.Item2, font, tyHidxGCO22, current6.Item1);
							}
						}
						finally
						{
							((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
						}
						goto end_IL_0b9f;
						IL_104f:
						if (current.tsYim6JrMO3 > num)
						{
							goto end_IL_0b9f;
						}
						num10 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
						{
							num10 = 3;
						}
						continue;
						end_IL_0175:
						break;
					}
					continue;
					end_IL_0b9f:
					break;
				}
			}
			return;
		}
	}

	private void wKkiQsB7iBp(DxVisualQueue P_0)
	{
		int num = 1;
		long num4 = default(long);
		IChartSymbol symbol = default(IChartSymbol);
		double num9 = default(double);
		XFont xFont = default(XFont);
		int num10 = default(int);
		double step = default(double);
		int stop = default(int);
		double num5 = default(double);
		int num20 = default(int);
		int num22 = default(int);
		Point point = default(Point);
		List<Point> list6 = default(List<Point>);
		int num17 = default(int);
		Rect item = default(Rect);
		List<Tuple<Rect, XBrush>> list = default(List<Tuple<Rect, XBrush>>);
		double num16 = default(double);
		double y = default(double);
		int num3 = default(int);
		IRawClusterItem rawClusterItem2 = default(IRawClusterItem);
		List<Tuple<Rect, string>>.Enumerator enumerator3 = default(List<Tuple<Rect, string>>.Enumerator);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		List<Tuple<Rect, XBrush>> list2 = default(List<Tuple<Rect, XBrush>>);
		double y2 = default(double);
		double num26 = default(double);
		int num24 = default(int);
		List<Tuple<Rect, XBrush>> list5 = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, string>> list9 = default(List<Tuple<Rect, string>>);
		List<Point> list3 = default(List<Point>);
		int num21 = default(int);
		double num27 = default(double);
		int num25 = default(int);
		double num8 = default(double);
		int round = default(int);
		long num14 = default(long);
		int num29 = default(int);
		long num15 = default(long);
		int num28 = default(int);
		IRawClusterItem rawClusterItem3 = default(IRawClusterItem);
		int num18 = default(int);
		long num6 = default(long);
		long num7 = default(long);
		int num23 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num4 = symbol.CorrectSizeFilter(FilterMin);
					num2 = 4;
					continue;
				case 5:
					num9 = Math.Min(num9, ((XFont)V5MZsreL3AqnNKkrxJ4b(base.Canvas)).Size);
					xFont = new XFont((string)sNjdW0eeaaBnKBvgmlyf(base.Canvas.ChartFont), num9);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					num10 = base.Canvas.Stop + base.Canvas.Count;
					step = base.DataProvider.Step;
					symbol = base.DataProvider.Symbol;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
				{
					using List<VolumeProfile>.Enumerator enumerator = C58iQccTV6U().GetEnumerator();
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IL_1247:
							VolumeProfile current = enumerator.Current;
							if (current.r0qimMRaM1h < stop || current.tsYim6JrMO3 > num10)
							{
								break;
							}
							double x = base.Canvas.GetX(current.tsYim6JrMO3);
							double x2 = base.Canvas.GetX(current.r0qimMRaM1h);
							RawCluster gP8imOxtD9i = current.gP8imOxtD9i;
							IRawClusterMaxValues maxValues = gP8imOxtD9i.MaxValues;
							IRawClusterValueArea rawClusterValueArea = (ShowValueArea ? gP8imOxtD9i.GetValueArea(ValueAreaPercent) : null);
							double num11 = x - num5;
							double num12 = x2 + num5 - 1.0;
							int num13 = 51;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
							{
								num13 = 13;
							}
							while (true)
							{
								int num19;
								object rawClusterItem;
								object obj;
								switch (num13)
								{
								case 19:
								case 32:
									num20 = num22;
									point = list6[xE7ULnee2fouKiJHkFUf(list6) - 2];
									num13 = 12;
									continue;
								case 29:
									if ((double)num17 > item.Width)
									{
										list[gxMENJeekGCjIaZpmnB8(list) - 1] = new Tuple<Rect, XBrush>(new Rect(num16 - (double)num17, y, num17, item.Height), yT5idMk4fEm);
										num13 = 2;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
										{
											num13 = 8;
										}
										continue;
									}
									goto case 8;
								case 51:
									if (num3 != int.MinValue)
									{
										num19 = 42;
										goto IL_012d;
									}
									goto case 27;
								case 57:
									if (!QfGiQXIFENj(gP8imOxtD9i, rawClusterItem2, maxValues))
									{
										goto IL_0a7e;
									}
									goto case 8;
								case 12:
									y = point.Y;
									num13 = 9;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
									{
										num13 = 13;
									}
									continue;
								case 34:
									enumerator3 = list4.GetEnumerator();
									num13 = 40;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
									{
										num13 = 34;
									}
									continue;
								case 47:
									list2.Add(new Tuple<Rect, XBrush>(new Rect(num11, y2, num26, num24), DvKidXeBaR4));
									num13 = 5;
									continue;
								case 6:
									break;
								case 14:
								case 37:
									if (EnableFilter)
									{
										num13 = 58;
										continue;
									}
									goto case 5;
								case 52:
									foreach (Tuple<Rect, XBrush> item3 in list5)
									{
										int num30 = 0;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
										{
											num30 = 0;
										}
										switch (num30)
										{
										}
										P_0.FillRectangle(item3.Item2, item3.Item1);
									}
									foreach (Tuple<Rect, XBrush> item4 in list2)
									{
										P_0.FillRectangle(item4.Item2, item4.Item1);
									}
									goto case 34;
								case 40:
									try
									{
										while (enumerator3.MoveNext())
										{
											Tuple<Rect, string> current5 = enumerator3.Current;
											P_0.DrawString(current5.Item2, xFont, tyHidxGCO22, current5.Item1, XTextAlignment.Right);
										}
									}
									finally
									{
										((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
									}
									enumerator3 = list9.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											Tuple<Rect, string> current6 = enumerator3.Current;
											fJoHDyeeeJO5oPwVRIhu(P_0, current6.Item2, xFont, tyHidxGCO22, current6.Item1, XTextAlignment.Left);
										}
									}
									finally
									{
										((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
									}
									break;
								case 20:
									list3.Add(new Point(num16, num20));
									num21 = (int)num16;
									num13 = 3;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
									{
										num13 = 4;
									}
									continue;
								case 42:
									num11 = num3;
									num13 = 10;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
									{
										num13 = 27;
									}
									continue;
								case 38:
									num17 = (int)(Math.Min(num27 * (double)rawClusterItem2.Bid, num26) / 2.0);
									num25 = (int)(num16 - (double)num17);
									num13 = 18;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
									{
										num13 = 18;
									}
									continue;
								case 48:
									list4.Add(new Tuple<Rect, string>(new Rect(num11, y, num26 / 2.0 - 2.0, num8), symbol.FormatRawSize(rawClusterItem2.Bid, round, MinimizeValues)));
									goto IL_0887;
								case 4:
									num20 = (int)GetY(((double)gP8imOxtD9i.High + 0.5) * step);
									list6 = new List<Point>
									{
										new Point(num21, num20)
									};
									num14 = yxEspIeLul2itdLbf3Hk(gP8imOxtD9i);
									num19 = 41;
									goto IL_012d;
								case 56:
									num29 = (int)GetY(((double)num15 - 0.5) * step);
									num24 = Math.Max(num29 - num20, 1);
									num13 = 45;
									continue;
								case 61:
									list3.Add(new Point(num28, num20));
									list3.Add(new Point(num28, num29));
									num21 = num28;
									num13 = 59;
									continue;
								case 53:
									num15 = gP8imOxtD9i.High;
									goto case 2;
								case 55:
									if (list3.Count <= 2)
									{
										goto case 61;
									}
									if (num28 > num21)
									{
										list3[xE7ULnee2fouKiJHkFUf(list3) - 2] = new Point(num28, list3[list3.Count - 2].Y);
										List<Point> list10 = list3;
										int index3 = list3.Count - 1;
										double x6 = num28;
										point = list3[list3.Count - 1];
										list10[index3] = new Point(x6, point.Y);
										num21 = num28;
									}
									goto case 59;
								case 1:
									point = list3[xE7ULnee2fouKiJHkFUf(list3) - 2];
									y2 = point.Y;
									if (!ShowMaximum || !QfGiQXIFENj(gP8imOxtD9i, rawClusterItem3, maxValues))
									{
										if (rawClusterValueArea == null)
										{
											num13 = 37;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
											{
												num13 = 33;
											}
											continue;
										}
										if (rawClusterItem3.Price == rawClusterValueArea.Vah || BFRqF8eeB87GdkGUDfZx(rawClusterItem3) == rawClusterValueArea.Val)
										{
											list2.Add(new Tuple<Rect, XBrush>(new Rect(num11, y2, num26, num24), Bq1idQsc5Di));
											num19 = 17;
											goto IL_012d;
										}
										goto case 14;
									}
									num13 = 47;
									continue;
								case 15:
									num21 = (int)num16;
									num19 = 49;
									goto IL_012d;
								case 33:
									list5 = new List<Tuple<Rect, XBrush>>();
									num13 = 24;
									continue;
								case 44:
									list9 = new List<Tuple<Rect, string>>();
									num16 = num11 + num26 / 2.0;
									num13 = 6;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
									{
										num13 = 15;
									}
									continue;
								case 2:
									if (num15 < LXSJ11ee9ZYjm5Mm7FJF(gP8imOxtD9i))
									{
										num13 = 20;
										continue;
									}
									goto case 23;
								case 28:
									if (list.Count <= 0)
									{
										list.Add(new Tuple<Rect, XBrush>(new Rect(num16 - (double)num17, y, num17, num18), yT5idMk4fEm));
										num13 = 30;
										continue;
									}
									item = list[list.Count - 1].Item1;
									if ((int)item.Y != (int)y)
									{
										list.Add(new Tuple<Rect, XBrush>(new Rect(num16 - (double)num17, y, num17, num18), yT5idMk4fEm));
										goto case 8;
									}
									num19 = 29;
									goto IL_012d;
								case 9:
									list6.Add(new Point(num25, num20));
									num13 = 25;
									continue;
								case 62:
									if (num8 > 7.0 && rawClusterItem2.Bid > 0)
									{
										num13 = 13;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
										{
											num13 = 48;
										}
										continue;
									}
									goto IL_0887;
								case 39:
								{
									list6.Add(new Point(num16, num20));
									XBrush brush = lrJidNNdgw3;
									double x5 = num11;
									point = list6[0];
									P_0.FillRectangle(brush, new Rect(new Point(x5, point.Y), new Point(num12, num20)));
									P_0.FillPolygon(OF6idDi9O2L, (Point[])esECbdeen2RJs6cvkApL(list6));
									num13 = 10;
									continue;
								}
								case 25:
									list6.Add(new Point(num25, num22));
									num21 = num25;
									num13 = 19;
									continue;
								default:
									if (EnableFilter && z55oUZeeLRl6lpIt4vqW(rawClusterItem2) >= num4)
									{
										if (num6 == 0L)
										{
											num13 = 28;
											continue;
										}
										if (z55oUZeeLRl6lpIt4vqW(rawClusterItem2) <= num6)
										{
											goto case 28;
										}
									}
									goto case 8;
								case 43:
									list = new List<Tuple<Rect, XBrush>>();
									num13 = 11;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
									{
										num13 = 33;
									}
									continue;
								case 31:
								{
									num26 = zKXN8VeelYLfVVtsjO65(num12 - num11, 1.0);
									long val = ((ProfileProportion > 0) ? num7 : Math.Max(maxValues.MaxBid, maxValues.MaxAsk));
									num27 = num26 / (double)Math.Max(val, 1L);
									num13 = 5;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
									{
										num13 = 7;
									}
									continue;
								}
								case 10:
									P_0.FillPolygon(OF6idDi9O2L, (Point[])esECbdeen2RJs6cvkApL(list3));
									num19 = 11;
									goto IL_012d;
								case 45:
									if (num29 <= num20)
									{
										num13 = 55;
										continue;
									}
									goto case 61;
								case 35:
									if (rawClusterItem2.Price != rawClusterValueArea.Val)
									{
										num13 = 0;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
										{
											num13 = 0;
										}
										continue;
									}
									goto case 8;
								case 3:
									goto IL_0d9a;
								case 58:
									if (rawClusterItem3.Ask >= num4)
									{
										if (num6 == 0L)
										{
											goto IL_0d9a;
										}
										if (KmNSKXeeSEc85PLEPiv5(rawClusterItem3) <= num6)
										{
											num13 = 3;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
											{
												num13 = 3;
											}
											continue;
										}
									}
									goto case 5;
								case 22:
								{
									List<Point> list8 = list6;
									int index2 = list6.Count - 1;
									double x4 = num25;
									point = list6[list6.Count - 1];
									list8[index2] = new Point(x4, point.Y);
									num21 = num25;
									num13 = 32;
									continue;
								}
								case 16:
									num18 = Math.Max(num22 - num20, 1);
									if (num22 <= num20 && xE7ULnee2fouKiJHkFUf(list6) > 2)
									{
										if (num25 < num21)
										{
											List<Point> list7 = list6;
											int index = xE7ULnee2fouKiJHkFUf(list6) - 2;
											double x3 = num25;
											point = list6[xE7ULnee2fouKiJHkFUf(list6) - 2];
											list7[index] = new Point(x3, point.Y);
											num13 = 22;
											continue;
										}
										goto case 19;
									}
									goto case 9;
								case 8:
								case 30:
									if (ShowValues)
									{
										num13 = 62;
										continue;
									}
									goto IL_0887;
								case 27:
									num3 = (int)num12;
									num13 = 22;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
									{
										num13 = 31;
									}
									continue;
								case 46:
								{
									Rect item2 = list5[list5.Count - 1].Item1;
									if ((int)item2.Y == (int)y2)
									{
										if ((double)num23 > item2.Width)
										{
											list5[list5.Count - 1] = new Tuple<Rect, XBrush>(new Rect(num16, y2, num23, item2.Height), yT5idMk4fEm);
										}
										goto case 5;
									}
									goto case 60;
								}
								case 23:
									rawClusterItem = gP8imOxtD9i.GetItem(num15);
									if (rawClusterItem == null)
									{
										num13 = 54;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
										{
											num13 = 3;
										}
										continue;
									}
									goto IL_12de;
								case 18:
									num22 = (int)GetY(((double)num14 - 0.5) * step);
									num13 = 16;
									continue;
								case 24:
									list4 = new List<Tuple<Rect, string>>();
									num13 = 44;
									continue;
								case 41:
									if (num14 >= gP8imOxtD9i.Low)
									{
										obj = ReA9xGeexjNNfHLOqmw1(gP8imOxtD9i, num14);
										if (obj == null)
										{
											num13 = 21;
											continue;
										}
										goto IL_1310;
									}
									num13 = 39;
									continue;
								case 36:
									num15--;
									num13 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
									{
										num13 = 2;
									}
									continue;
								case 59:
									num20 = num29;
									num13 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
									{
										num13 = 1;
									}
									continue;
								case 5:
								case 17:
								case 26:
									if (ShowValues && num8 > 7.0 && rawClusterItem3.Ask > 0)
									{
										list9.Add(new Tuple<Rect, string>(new Rect(num16 + 2.0, y2, num26 / 2.0, num8), symbol.FormatRawSize(KmNSKXeeSEc85PLEPiv5(rawClusterItem3), round, MinimizeValues)));
										num13 = 11;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 != 0)
										{
											num13 = 36;
										}
										continue;
									}
									goto case 36;
								case 60:
									list5.Add(new Tuple<Rect, XBrush>(new Rect(num16, y2, num23, num24), yT5idMk4fEm));
									goto case 5;
								case 11:
									foreach (Tuple<Rect, XBrush> item5 in list)
									{
										P_0.FillRectangle(item5.Item2, item5.Item1);
									}
									goto case 52;
								case 49:
									num20 = (int)GetY(((double)gP8imOxtD9i.High + 0.5) * step);
									list3 = new List<Point>
									{
										new Point(num21, num20)
									};
									num13 = 53;
									continue;
								case 7:
									list2 = new List<Tuple<Rect, XBrush>>();
									num13 = 43;
									continue;
								case 13:
									if (ShowMaximum)
									{
										num13 = 57;
										continue;
									}
									goto IL_0a7e;
								case 50:
									goto IL_1247;
								case 54:
									rawClusterItem = new RawClusterItem(num15);
									goto IL_12de;
								case 21:
									{
										obj = new RawClusterItem(num14);
										goto IL_1310;
									}
									IL_1310:
									rawClusterItem2 = (IRawClusterItem)obj;
									num19 = 38;
									goto IL_012d;
									IL_12de:
									rawClusterItem3 = (IRawClusterItem)rawClusterItem;
									num23 = ((rawClusterItem3.Ask > 0) ? ((int)(Math.Min(num27 * (double)KmNSKXeeSEc85PLEPiv5(rawClusterItem3), num26) / 2.0)) : 0);
									num28 = (int)(num16 + (double)num23);
									num13 = 44;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
									{
										num13 = 56;
									}
									continue;
									IL_0a7e:
									if (rawClusterValueArea == null)
									{
										goto default;
									}
									if (rawClusterItem2.Price != rawClusterValueArea.Vah)
									{
										num13 = 35;
										continue;
									}
									goto case 8;
									IL_012d:
									num13 = num19;
									continue;
									IL_0887:
									num14--;
									goto case 41;
								}
								break;
								IL_0d9a:
								if (gxMENJeekGCjIaZpmnB8(list5) <= 0)
								{
									list5.Add(new Tuple<Rect, XBrush>(new Rect(num16, y2, num23, num24), yT5idMk4fEm));
									num13 = 26;
								}
								else
								{
									num13 = 46;
								}
							}
							break;
						}
					}
					return;
				}
				case 4:
					num6 = symbol.CorrectSizeFilter(FilterMax);
					num7 = symbol.CorrectSizeFilter(ProfileProportion);
					num8 = GetY(0.0) - GetY(step);
					num9 = A4EqKqee0I9SmcXvalbY(num8 - 2.0, 18.0) * 96.0 / 72.0;
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					num5 = base.Canvas.ColumnWidth / 2.0;
					round = RoundValues;
					num = 6;
					break;
				case 1:
					stop = base.Canvas.Stop;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					num3 = int.MinValue;
					num = 7;
					break;
				}
				break;
			}
		}
	}

	private bool QfGiQXIFENj(IRawCluster P_0, IRawClusterItem P_1, IRawClusterMaxValues P_2)
	{
		switch (MaximumType)
		{
		case VolumeProfilesMaximumType.Volume:
			return BdtEaLeLz3YWuuaIMO5r(P_1) == blic40ees5ZnFHxg0cSw(P_2);
		case VolumeProfilesMaximumType.Trades:
			return P_1.Trades == P_2.MaxTrades;
		case VolumeProfilesMaximumType.Delta:
			return Math.Abs(P_1.Delta) == Math.Max(UWlGXWee1cCt10WaqN2g(alMbb9eeXERjFTxceOAB(P_2)), Math.Abs(P_2.MinDelta));
		case VolumeProfilesMaximumType.DeltaPlus:
			if (P_1.Delta > 0)
			{
				return kE4mWueebBnaR6LLqllP(P_1) == alMbb9eeXERjFTxceOAB(P_2);
			}
			return false;
		case VolumeProfilesMaximumType.DeltaMinus:
			if (kE4mWueebBnaR6LLqllP(P_1) < 0)
			{
				return P_1.Delta == yCZFkjee4l1jbwiWmglq(P_2);
			}
			return false;
		default:
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				return false;
			}
			goto case VolumeProfilesMaximumType.Volume;
		}
		case VolumeProfilesMaximumType.Bid:
			return z55oUZeeLRl6lpIt4vqW(P_1) == TnZrX7eecQsE3X1TAdfR(P_2);
		case VolumeProfilesMaximumType.Ask:
			return KmNSKXeeSEc85PLEPiv5(P_1) == P_2.MaxAsk;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 3;
		O2XR1WiQ19qhAdqSxCed o2XR1WiQ19qhAdqSxCed = default(O2XR1WiQ19qhAdqSxCed);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					FilterMin = fhXQJqeeRlFB6ibC5hwe(o2XR1WiQ19qhAdqSxCed);
					FilterMax = Yf4pUBee6FBqJI8gE46a(o2XR1WiQ19qhAdqSxCed);
					FilterColor = o2XR1WiQ19qhAdqSxCed.FilterColor;
					num2 = 8;
					continue;
				case 2:
					PeriodType = o2XR1WiQ19qhAdqSxCed.PeriodType;
					PeriodValue = loMvcYeejqejim9UyJZF(o2XR1WiQ19qhAdqSxCed);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					ValueAreaColor = o2XR1WiQ19qhAdqSxCed.ValueAreaColor;
					EnableFilter = la3ebLeegSKlgHCG95Xg(o2XR1WiQ19qhAdqSxCed);
					num2 = 4;
					continue;
				case 8:
					base.CopyTemplate(P_0, P_1);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 6:
					MaximumColor = LEXhn3eeQopln2q3K36k(o2XR1WiQ19qhAdqSxCed);
					ShowValueArea = VwJEaWeedqqcSLUsjCJQ(o2XR1WiQ19qhAdqSxCed);
					ValueAreaPercent = o2XR1WiQ19qhAdqSxCed.ValueAreaPercent;
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					break;
				case 1:
					MaximumType = o2XR1WiQ19qhAdqSxCed.MaximumType;
					ShowMaximum = o2XR1WiQ19qhAdqSxCed.ShowMaximum;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					o2XR1WiQ19qhAdqSxCed = (O2XR1WiQ19qhAdqSxCed)P_0;
					num2 = 2;
					continue;
				case 7:
					ProfileBackColor = o2XR1WiQ19qhAdqSxCed.ProfileBackColor;
					ShowValues = o2XR1WiQ19qhAdqSxCed.ShowValues;
					MinimizeValues = o2XR1WiQ19qhAdqSxCed.MinimizeValues;
					ValuesColor = o2XR1WiQ19qhAdqSxCed.ValuesColor;
					VYCiQrEeSOT.Copy(o2XR1WiQ19qhAdqSxCed.VYCiQrEeSOT);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			ProfileType = o2XR1WiQ19qhAdqSxCed.ProfileType;
			ProfileProportion = o2XR1WiQ19qhAdqSxCed.ProfileProportion;
			ProfileColor = imOMRGeeEFeB9L2NmPVm(o2XR1WiQ19qhAdqSxCed);
			num = 7;
		}
	}

	static O2XR1WiQ19qhAdqSxCed()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ASM7W4eeMCUM2RaJfCUs();
	}

	internal static bool mYBB3peLU7f9AhsqvaeZ()
	{
		return vAIjg9eLtnh5SF3QnhQW == null;
	}

	internal static O2XR1WiQ19qhAdqSxCed MXhEKHeLTIpawqhwRLQH()
	{
		return vAIjg9eLtnh5SF3QnhQW;
	}

	internal static int ckRYJeeLyQi2egymkeiI(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object LyPWhPeLZSlXGmayKYAV(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool jwmFQxeLVdIHrfmE5Vqm(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static Color K4UHQgeLCf50woYFicTB(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor PalUZjeLrPKa3jHLBlph(Color P_0)
	{
		return P_0;
	}

	internal static void F0mKrqeLK75PQhG1RyuQ(object P_0, int P_1)
	{
		((List<VolumeProfile>)P_0).RemoveAt(P_1);
	}

	internal static object RulswKeLmkVhQFoCaFd5(object P_0)
	{
		return ((IChartSymbol)P_0).Exchange;
	}

	internal static object D0xO5XeLh3S8dnAIjkXW(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetRawCluster(i);
	}

	internal static DateTime kbTm7leLwqmg5lgNCE7L(object P_0)
	{
		return ((IRawCluster)P_0).Time;
	}

	internal static int MN2BxWeL75CMbThcYfU6(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static double idE21peL8MhKKRI81Shf(object P_0)
	{
		return ((IChartCanvas)P_0).MinY;
	}

	internal static object mDWdZceLAyRaoqCNfOQ1(object P_0)
	{
		return ((IndicatorsHelper)P_0).DataProvider;
	}

	internal static double pk43FteLP6hxM9Ordde2(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static int wrQp2teLJXkSHNWPBea1(object P_0)
	{
		return ((IChartCanvas)P_0).Stop;
	}

	internal static long RE66hNeLF5sUqvgjhyGv(object P_0, double filter)
	{
		return ((IChartSymbol)P_0).CorrectSizeFilter(filter);
	}

	internal static object V5MZsreL3AqnNKkrxJ4b(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static double tAaUJAeLpYd5C3H2DgnK(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static long yxEspIeLul2itdLbf3Hk(object P_0)
	{
		return ((RawCluster)P_0).High;
	}

	internal static long BdtEaLeLz3YWuuaIMO5r(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static double A4EqKqee0I9SmcXvalbY(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int xE7ULnee2fouKiJHkFUf(object P_0)
	{
		return ((List<Point>)P_0).Count;
	}

	internal static long oa0PG8eeHmbZBqpVGxRB(object P_0)
	{
		return ((IRawClusterValueArea)P_0).Vah;
	}

	internal static object qkFAM2eefn8JTUemKKOL(object P_0, long size, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatRawSize(size, round, minimize);
	}

	internal static long LXSJ11ee9ZYjm5Mm7FJF(object P_0)
	{
		return ((RawCluster)P_0).Low;
	}

	internal static object esECbdeen2RJs6cvkApL(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}

	internal static void BeKOdseeGGcOAQnbivXL(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int tPQAjGeeYfmuLN6tjvcU(object P_0)
	{
		return ((XFont)P_0).Size;
	}

	internal static double OVxPCgeeoddVBNUy0U9o(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static int DMURBteevwjxKNZ3n5hn(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxTrades;
	}

	internal static long BFRqF8eeB87GdkGUDfZx(object P_0)
	{
		return ((IRawClusterItem)P_0).Price;
	}

	internal static object sNjdW0eeaaBnKBvgmlyf(object P_0)
	{
		return ((XFont)P_0).Name;
	}

	internal static object Rq24eaeei09xSdnvFdaG(object P_0)
	{
		return ((RawCluster)P_0).MaxValues;
	}

	internal static double zKXN8VeelYLfVVtsjO65(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static long yCZFkjee4l1jbwiWmglq(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MinDelta;
	}

	internal static long rQvEjPeeDmw0Ob17ypT3(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static long kE4mWueebBnaR6LLqllP(object P_0)
	{
		return ((IRawClusterItem)P_0).Delta;
	}

	internal static long GcFkckeeNsaSgKweDxu1(object P_0)
	{
		return ((IRawClusterValueArea)P_0).Val;
	}

	internal static int gxMENJeekGCjIaZpmnB8(object P_0)
	{
		return ((List<Tuple<Rect, XBrush>>)P_0).Count;
	}

	internal static long UWlGXWee1cCt10WaqN2g(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static void dO9Nk3ee5EvioxLPhJ4b(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).FillPolygon((XBrush)P_1, (Point[])P_2);
	}

	internal static long KmNSKXeeSEc85PLEPiv5(object P_0)
	{
		return ((IRawClusterItem)P_0).Ask;
	}

	internal static object ReA9xGeexjNNfHLOqmw1(object P_0, long price)
	{
		return ((RawCluster)P_0).GetItem(price);
	}

	internal static long z55oUZeeLRl6lpIt4vqW(object P_0)
	{
		return ((IRawClusterItem)P_0).Bid;
	}

	internal static void fJoHDyeeeJO5oPwVRIhu(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static long blic40ees5ZnFHxg0cSw(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}

	internal static long alMbb9eeXERjFTxceOAB(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxDelta;
	}

	internal static long TnZrX7eecQsE3X1TAdfR(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxBid;
	}

	internal static int loMvcYeejqejim9UyJZF(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).PeriodValue;
	}

	internal static XColor imOMRGeeEFeB9L2NmPVm(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).ProfileColor;
	}

	internal static XColor LEXhn3eeQopln2q3K36k(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).MaximumColor;
	}

	internal static bool VwJEaWeedqqcSLUsjCJQ(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).ShowValueArea;
	}

	internal static bool la3ebLeegSKlgHCG95Xg(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).EnableFilter;
	}

	internal static int fhXQJqeeRlFB6ibC5hwe(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).FilterMin;
	}

	internal static int Yf4pUBee6FBqJI8gE46a(object P_0)
	{
		return ((O2XR1WiQ19qhAdqSxCed)P_0).FilterMax;
	}

	internal static void ASM7W4eeMCUM2RaJfCUs()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
