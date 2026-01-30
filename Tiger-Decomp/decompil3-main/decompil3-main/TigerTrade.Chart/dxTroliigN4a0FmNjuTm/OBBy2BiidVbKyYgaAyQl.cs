using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.List;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace dxTroliigN4a0FmNjuTm;

[DataContract(Name = "VolumeProfileObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("VolumeProfile", "ChartObjectsVolumeProfile", 2, Type = typeof(OBBy2BiidVbKyYgaAyQl))]
internal sealed class OBBy2BiidVbKyYgaAyQl : RectangleObject
{
	private class VUFmvAiCu8RTynCJ1RYY
	{
		private int fmdir94ZcwN;

		private int BxIirnmaRRh;

		private string vOIirG4qdPK;

		private RawCluster Bq8irYW2mhq;

		private long ylqirogJLcq;

		private long iaxirvjHkmF;

		internal static VUFmvAiCu8RTynCJ1RYY mpZ62qetMQULOkcOG4UC;

		private void fNJiCz2s9Mm(int P_0, int P_1, IChartDataProvider P_2)
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			IRawCluster rawCluster = default(IRawCluster);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (num3 > P_1)
					{
						return;
					}
					rawCluster = P_2.GetRawCluster(num3);
					if (rawCluster != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_00a3;
				case 2:
					num3 = P_0;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					LRvir0YrLH1(rawCluster, Bq8irYW2mhq);
					goto IL_00a3;
				case 0:
					return;
					IL_00a3:
					num3++;
					goto case 1;
				}
			}
		}

		private void LRvir0YrLH1(IRawCluster P_0, RawCluster P_1)
		{
			IEnumerator<IRawClusterItem> enumerator = P_0.Items.GetEnumerator();
			try
			{
				IRawClusterItem current = default(IRawClusterItem);
				while (true)
				{
					int num;
					if (aA2Hf1ettAjSA3HHu2aK(enumerator))
					{
						current = enumerator.Current;
						if (current.Price < iaxirvjHkmF || zaYWeWetIu1Df19d63Ln(current) > ylqirogJLcq)
						{
							continue;
						}
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
						{
							num = 0;
						}
					}
					else
					{
						num = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
						{
							num = 1;
						}
					}
					switch (num)
					{
					case 1:
						return;
					}
					QpQeUFetW5MWvvWc8RGH(P_1, current);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					wuVbQfetU72MAfofoiKU(enumerator);
				}
			}
		}

		private RawCluster OLoir2pjmU6(int P_0, int P_1, long P_2, long P_3, IChartDataProvider P_4)
		{
			P_1 = Math.Min(P_1, YFPUJVetT5LPGHF9Kuwb(P_4) - 2);
			int num;
			if (!(P_4.Symbol.Code != vOIirG4qdPK))
			{
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_0033;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 4:
					fNJiCz2s9Mm(P_0, P_1, P_4);
					num = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
					{
						num = 2;
					}
					continue;
				case 5:
					Bq8irYW2mhq.UpdateData();
					num = 7;
					continue;
				case 2:
					vOIirG4qdPK = (string)kAE0L8ety9DMtlJ25dbW(P_4.Symbol);
					goto IL_01f9;
				case 6:
					fNJiCz2s9Mm(BxIirnmaRRh + 1, P_1, P_4);
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
					{
						num = 0;
					}
					continue;
				case 1:
					EPlfYdetZYblL8TAUCq8(Bq8irYW2mhq);
					BxIirnmaRRh = P_1;
					goto IL_01f9;
				case 7:
					fmdir94ZcwN = P_0;
					BxIirnmaRRh = P_1;
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
					{
						num = 2;
					}
					continue;
				default:
					{
						if (P_0 != fmdir94ZcwN)
						{
							break;
						}
						if (P_1 < BxIirnmaRRh)
						{
							num = 3;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
							{
								num = 2;
							}
							continue;
						}
						if (P_2 == iaxirvjHkmF && P_3 == ylqirogJLcq)
						{
							if (P_1 > BxIirnmaRRh)
							{
								num = 6;
								continue;
							}
							goto IL_01f9;
						}
						break;
					}
					IL_01f9:
					return Bq8irYW2mhq;
				}
				break;
			}
			goto IL_0033;
			IL_0033:
			iaxirvjHkmF = P_2;
			ylqirogJLcq = P_3;
			Bq8irYW2mhq = new RawCluster(DateTime.MinValue);
			num = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
			{
				num = 4;
			}
			goto IL_0009;
		}

		private IRawCluster e9KirHhTvcW(int P_0, int P_1, IChartDataProvider P_2)
		{
			int num = P_2.Count - 1;
			if (P_1 >= num)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				if (P_0 <= num)
				{
					return (IRawCluster)NiSjQuetVvhDgTLNFmq7(P_2, num);
				}
			}
			return null;
		}

		public RawCluster B66irfRoZZd(int P_0, int P_1, long P_2, long P_3, IChartDataProvider P_4)
		{
			RawCluster rawCluster = new RawCluster(DateTime.MinValue);
			RawCluster cluster = OLoir2pjmU6(P_0, P_1, P_2, P_3, P_4);
			rawCluster.AddCluster(cluster);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
			{
				num = 1;
			}
			IRawCluster rawCluster2 = default(IRawCluster);
			while (true)
			{
				switch (num)
				{
				case 1:
					rawCluster2 = e9KirHhTvcW(P_0, P_1, P_4);
					if (rawCluster2 != null)
					{
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
						{
							num = 0;
						}
						break;
					}
					goto IL_001b;
				default:
					{
						LRvir0YrLH1(rawCluster2, rawCluster);
						goto IL_001b;
					}
					IL_001b:
					return rawCluster;
				}
			}
		}

		public VUFmvAiCu8RTynCJ1RYY()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		static VUFmvAiCu8RTynCJ1RYY()
		{
			VjjyeGetClxM6wikFJQk();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool ESkZVVetONu09J1xp14u()
		{
			return mpZ62qetMQULOkcOG4UC == null;
		}

		internal static VUFmvAiCu8RTynCJ1RYY XYVPhsetqgc3TfLohlZD()
		{
			return mpZ62qetMQULOkcOG4UC;
		}

		internal static long zaYWeWetIu1Df19d63Ln(object P_0)
		{
			return ((IRawClusterItem)P_0).Price;
		}

		internal static void QpQeUFetW5MWvvWc8RGH(object P_0, object P_1)
		{
			((RawCluster)P_0).AddItem((IRawClusterItem)P_1);
		}

		internal static bool aA2Hf1ettAjSA3HHu2aK(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void wuVbQfetU72MAfofoiKU(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static int YFPUJVetT5LPGHF9Kuwb(object P_0)
		{
			return ((IChartDataProvider)P_0).Count;
		}

		internal static object kAE0L8ety9DMtlJ25dbW(object P_0)
		{
			return ((IChartSymbol)P_0).Code;
		}

		internal static void EPlfYdetZYblL8TAUCq8(object P_0)
		{
			((RawCluster)P_0).UpdateData();
		}

		internal static object NiSjQuetVvhDgTLNFmq7(object P_0, int i)
		{
			return ((IChartDataProvider)P_0).GetRawCluster(i);
		}

		internal static void VjjyeGetClxM6wikFJQk()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}
	}

	private VUFmvAiCu8RTynCJ1RYY AR8ilLndCyw;

	private VUFmvAiCu8RTynCJ1RYY nNtileWxJmJ;

	private VolumeProfileType wuOilsjBglK;

	private XBrush wfCilXoxhy5;

	private XColor A0Lilcx3qkL;

	private XBrush wFNiljTjDGd;

	private XColor NTeilEbXxoQ;

	private bool yqXilQ4MsMs;

	private bool cjCildjF6mp;

	private bool KnOilgUrNGn;

	private bool CRtilRQUPrS;

	private int LjRil658cJe;

	private XBrush ssiilMiEUVw;

	private XColor W5rilOmvtXF;

	private VolumeProfileMaximumType LC5ilq6Q8gJ;

	private bool WVFilIeVKSZ;

	private bool Vp2ilWrSDrG;

	private bool UfAilt6Y5NY;

	private XBrush yOTilUZNAwi;

	private XColor ip7ilT7QFVL;

	private bool AsailyZ5HJ2;

	private bool ScPilZ0BRoy;

	private int GnailVHAVRp;

	private XBrush LPIilCNaZ1M;

	private XColor FQYilryjhjA;

	private bool BxYilK970ri;

	private int Q5Tilm0wFJd;

	private int rgnilhkQY5k;

	private XBrush xHKilw0nwx7;

	private XColor N9Ril7us8va;

	private static OBBy2BiidVbKyYgaAyQl Pfgo8Qe9roMLkZCvk240;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Cluster;

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsProfile")]
	[DataMember(Name = "ProfileType")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsType")]
	public VolumeProfileType ProfileType
	{
		get
		{
			return wuOilsjBglK;
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
				case 0:
					return;
				case 1:
					if (volumeProfileType != wuOilsjBglK)
					{
						wuOilsjBglK = volumeProfileType;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60821141));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	[DataMember(Name = "ProfileColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsProfile")]
	public XColor ProfileColor
	{
		get
		{
			return A0Lilcx3qkL;
		}
		set
		{
			if (!H7mXy1e9hAkC3F82VNKc(xColor, A0Lilcx3qkL))
			{
				A0Lilcx3qkL = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				wfCilXoxhy5 = new XBrush(A0Lilcx3qkL);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991828521));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsProfile")]
	[DataMember(Name = "Profile2Color")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor2")]
	public XColor Profile2Color
	{
		get
		{
			return NTeilEbXxoQ;
		}
		set
		{
			if (!H7mXy1e9hAkC3F82VNKc(xColor, NTeilEbXxoQ))
			{
				NTeilEbXxoQ = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				wFNiljTjDGd = new XBrush(NTeilEbXxoQ);
				OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(-1009517961 ^ -1009550895));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsProfile")]
	[DataMember(Name = "ExtendProfile")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsExtendProfile")]
	public bool ExtendProfile
	{
		get
		{
			return yqXilQ4MsMs;
		}
		set
		{
			if (flag != yqXilQ4MsMs)
			{
				yqXilQ4MsMs = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(0x32DEA4F1 ^ 0x32DE2735));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowCumValue")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsProfile")]
	[DataMember(Name = "ShowCumValue")]
	public bool ShowCumValue
	{
		get
		{
			return cjCildjF6mp;
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
					if (flag == cjCildjF6mp)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
						{
							num2 = 0;
						}
						break;
					}
					cjCildjF6mp = flag;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB18D8C));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShow")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValues")]
	[DataMember(Name = "ShowValues")]
	public bool ShowValues
	{
		get
		{
			return KnOilgUrNGn;
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
					if (flag == KnOilgUrNGn)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
						{
							num2 = 0;
						}
						break;
					}
					KnOilgUrNGn = flag;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB18D90));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsMinimize")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValues")]
	[DataMember(Name = "MinimizeValues")]
	public bool MinimizeValues
	{
		get
		{
			return CRtilRQUPrS;
		}
		set
		{
			if (flag != CRtilRQUPrS)
			{
				CRtilRQUPrS = flag;
				OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(0x2C8374E4 ^ 0x2C83F0F2));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsRound")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValues")]
	[DefaultValue(0)]
	[DataMember(Name = "RoundValues")]
	public int RoundValues
	{
		get
		{
			return LjRil658cJe;
		}
		set
		{
			num = Math.Max(-4, Math.Min(4, num));
			if (num != LjRil658cJe)
			{
				LjRil658cJe = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461292091 ^ -1461258253));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	[DataMember(Name = "ValuesColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValues")]
	public XColor ValuesColor
	{
		get
		{
			return W5rilOmvtXF;
		}
		set
		{
			if (!(xColor == W5rilOmvtXF))
			{
				W5rilOmvtXF = xColor;
				ssiilMiEUVw = new XBrush(W5rilOmvtXF);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x8093E9B));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsType")]
	[DataMember(Name = "MaximumType")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsMaximum")]
	public VolumeProfileMaximumType MaximumType
	{
		get
		{
			return LC5ilq6Q8gJ;
		}
		set
		{
			if (volumeProfileMaximumType != LC5ilq6Q8gJ)
			{
				LC5ilq6Q8gJ = volumeProfileMaximumType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-377195341 ^ -377163559));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShow")]
	[DataMember(Name = "ShowMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsMaximum")]
	public bool ShowMaximum
	{
		get
		{
			return WVFilIeVKSZ;
		}
		set
		{
			if (flag != WVFilIeVKSZ)
			{
				WVFilIeVKSZ = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3E0426F0 ^ 0x3E04A274));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowValue")]
	[DataMember(Name = "ShowMaximumValue")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsMaximum")]
	public bool ShowMaximumValue
	{
		get
		{
			return Vp2ilWrSDrG;
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
				case 0:
					return;
				case 1:
					if (flag != Vp2ilWrSDrG)
					{
						Vp2ilWrSDrG = flag;
						OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(-527080372 ^ -527048494));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsExtend")]
	[DataMember(Name = "ExtendMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsMaximum")]
	public bool ExtendMaximum
	{
		get
		{
			return UfAilt6Y5NY;
		}
		set
		{
			if (flag != UfAilt6Y5NY)
			{
				UfAilt6Y5NY = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24085900 ^ 0x2408DDC2));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	[DataMember(Name = "MaximumColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsMaximum")]
	public XColor MaximumColor
	{
		get
		{
			return ip7ilT7QFVL;
		}
		set
		{
			if (!(xColor == ip7ilT7QFVL))
			{
				ip7ilT7QFVL = xColor;
				yOTilUZNAwi = new XBrush(ip7ilT7QFVL);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(-2017337494 ^ -2017371254));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValueArea")]
	[DataMember(Name = "ShowValueArea")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShow")]
	public bool ShowValueArea
	{
		get
		{
			return AsailyZ5HJ2;
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
				case 0:
					return;
				case 1:
					if (flag != AsailyZ5HJ2)
					{
						AsailyZ5HJ2 = flag;
						OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(0x5CD4F15 ^ 0x5CDCBE9));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValueArea")]
	[DataMember(Name = "ExtendValueArea")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsExtend")]
	public bool ExtendValueArea
	{
		get
		{
			return ScPilZ0BRoy;
		}
		set
		{
			if (flag != ScPilZ0BRoy)
			{
				ScPilZ0BRoy = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xC1DDB3B ^ 0xC1D5E21));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsValueAreaPercent")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValueArea")]
	[DataMember(Name = "ValueAreaPercent")]
	public int ValueAreaPercent
	{
		get
		{
			return GnailVHAVRp;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 3:
					num3 = cfvKUte97iqEDd3m8tpO(0, Math.Min(100, num3));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					if (num3 == 0)
					{
						num3 = 70;
					}
					if (num3 != GnailVHAVRp)
					{
						GnailVHAVRp = num3;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3544E813 ^ 0x35446D2F));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
						{
							num2 = 1;
						}
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsValueArea")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	[DataMember(Name = "ValueAreaColor")]
	public XColor ValueAreaColor
	{
		get
		{
			return FQYilryjhjA;
		}
		set
		{
			if (!(xColor == FQYilryjhjA))
			{
				FQYilryjhjA = xColor;
				LPIilCNaZ1M = new XBrush(FQYilryjhjA);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192956002));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsEnable")]
	[DataMember(Name = "EnableFilter")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsFilter")]
	public bool EnableFilter
	{
		get
		{
			return BxYilK970ri;
		}
		set
		{
			if (flag != BxYilK970ri)
			{
				BxYilK970ri = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xC1DDB3B ^ 0xC1D5EBB));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsFilter")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsMinimum")]
	[DataMember(Name = "FilterMin")]
	public int FilterMin
	{
		get
		{
			return Q5Tilm0wFJd;
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
					if (num3 != Q5Tilm0wFJd)
					{
						Q5Tilm0wFJd = num3;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B5014E));
					}
					return;
				case 1:
					num3 = Math.Max(0, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsFilter")]
	[DataMember(Name = "FilterMax")]
	public int FilterMax
	{
		get
		{
			return rgnilhkQY5k;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != rgnilhkQY5k)
			{
				rgnilhkQY5k = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(-1848952786 ^ -1848918628));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	[DataMember(Name = "FilterColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsFilter")]
	public XColor FilterColor
	{
		get
		{
			return N9Ril7us8va;
		}
		set
		{
			if (!(xColor == N9Ril7us8va))
			{
				N9Ril7us8va = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				xHKilw0nwx7 = new XBrush(N9Ril7us8va);
				OnPropertyChanged((string)jyeQJJe9w4T0Ua5R9w7t(0x4297C3EB ^ 0x42974623));
			}
		}
	}

	public OBBy2BiidVbKyYgaAyQl()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		AR8ilLndCyw = new VUFmvAiCu8RTynCJ1RYY();
		nNtileWxJmJ = new VUFmvAiCu8RTynCJ1RYY();
		base._002Ector();
		ProfileType = VolumeProfileType.Volume;
		ProfileColor = Color.FromArgb(127, 70, 130, 180);
		Profile2Color = HfoFJCe98R7ndL0jucYq(Color.FromArgb(127, 178, 34, 34));
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 9:
				ExtendProfile = false;
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				ValuesColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				MaximumType = VolumeProfileMaximumType.Volume;
				num = 7;
				break;
			default:
				FilterMax = 0;
				num = 3;
				break;
			case 7:
				ShowMaximum = true;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
				{
					num = 5;
				}
				break;
			case 1:
				FilterMin = 0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
				{
					num = 0;
				}
				break;
			case 6:
				EnableFilter = false;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
				{
					num = 1;
				}
				break;
			case 10:
				ShowCumValue = false;
				ShowValues = false;
				MinimizeValues = false;
				num = 4;
				break;
			case 5:
				ShowMaximumValue = true;
				num = 8;
				break;
			case 2:
				MaximumColor = HfoFJCe98R7ndL0jucYq(Color.FromArgb(127, 178, 34, 34));
				ShowValueArea = true;
				ExtendValueArea = false;
				ValueAreaPercent = 70;
				ValueAreaColor = Color.FromArgb(127, 128, 128, 128);
				num = 6;
				break;
			case 3:
				FilterColor = HfoFJCe98R7ndL0jucYq(Color.FromArgb(127, 46, 139, 87));
				return;
			case 8:
				ExtendMaximum = false;
				num = 2;
				break;
			}
		}
	}

	protected override void Draw(DxVisualQueue P_0, ref List<ObjectLabelInfo> P_1)
	{
		int num = 5;
		int num2 = num;
		long num5 = default(long);
		double num6 = default(double);
		long num7 = default(long);
		int num9 = default(int);
		int num4 = default(int);
		int num8 = default(int);
		int num3 = default(int);
		RawCluster rawCluster = default(RawCluster);
		IRawClusterValueArea rawClusterValueArea = default(IRawClusterValueArea);
		Point point = default(Point);
		Point point2 = default(Point);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				if (!ExtendProfile)
				{
					num2 = 4;
					break;
				}
				goto IL_03a7;
			case 0:
				return;
			case 6:
				num5 = (long)(Math.Max(base.ControlPoints[0].Y, base.ControlPoints[1].Y) / num6);
				num7 = (long)(Math.Min(base.ControlPoints[0].Y, base.ControlPoints[1].Y) / num6);
				num2 = 14;
				break;
			case 9:
				goto IL_010a;
			case 2:
				num9 = base.Canvas.DateToIndex(base.ControlPoints[num4].X, 0);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
				{
					num2 = 13;
				}
				break;
			case 10:
				goto IL_01af;
			case 16:
				num8 = pK9Y2Ue9A2XEg0JXGjQd(base.Canvas, base.ControlPoints[num3].X, 0);
				num2 = 2;
				break;
			case 1:
				switch (ProfileType)
				{
				case VolumeProfileType.Trades:
					asxiiqEkcNG(P_0, rawCluster, rawClusterValueArea, point, point2, ref P_1);
					goto IL_0291;
				case VolumeProfileType.Delta:
					break;
				case VolumeProfileType.BidAsk:
					goto IL_010a;
				case VolumeProfileType.Volume:
					goto IL_01af;
				default:
					goto IL_0291;
				}
				HHIiiISsS6o(P_0, rawCluster, rawClusterValueArea, point, point2, ref P_1);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num2 = 2;
				}
				break;
			case 15:
				X6SiiRg5mJt(P_0, rawCluster);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
			case 7:
			case 8:
				goto IL_0291;
			case 14:
				rawCluster = (RawCluster)(ExtendProfile ? d44wtse9JkBYMyh2g1jV(AR8ilLndCyw, num8, num9, long.MinValue, long.MaxValue, base.DataProvider) : d44wtse9JkBYMyh2g1jV(nNtileWxJmJ, num8, num9, num7, num5, base.DataProvider));
				num2 = 12;
				break;
			case 13:
				num6 = x8JRf6e9PcMTrTT1BDTI(base.DataProvider);
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num2 = 6;
				}
				break;
			case 11:
				if (rawCluster.Volume <= 0)
				{
					return;
				}
				rawClusterValueArea = (ShowValueArea ? rawCluster.GetValueArea(ValueAreaPercent) : null);
				point = ToPoint(base.ControlPoints[num3]);
				point2 = ToPoint(base.ControlPoints[num4]);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				hK0FBNe9FsR9fJkZH6gn(rawCluster);
				num2 = 11;
				break;
			case 4:
				{
					base.Draw(P_0, ref P_1);
					goto IL_03a7;
				}
				IL_03a7:
				if (!base.Canvas.IsStock)
				{
					return;
				}
				num3 = 0;
				num4 = 1;
				if (base.ControlPoints[0].X > base.ControlPoints[1].X)
				{
					num3 = 1;
					num4 = 0;
					num2 = 16;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 16;
				IL_010a:
				FU9iiWIF5Hk(P_0, rawCluster, rawClusterValueArea, point, point2, ref P_1);
				num2 = 7;
				break;
				IL_0291:
				if (!ShowCumValue)
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
				{
					num2 = 15;
				}
				break;
				IL_01af:
				jvPiiOqQWHA(P_0, rawCluster, rawClusterValueArea, point, point2, ref P_1);
				num2 = 8;
				break;
			}
		}
	}

	private void X6SiiRg5mJt(DxVisualQueue P_0, IRawCluster P_1)
	{
		IChartSymbol symbol = base.DataProvider.Symbol;
		Rect rectangle = base.RectInfo.Rectangle;
		double num = Df6gL4e93t0TxBWoYgRU(base.Canvas.ChartFont);
		int num2 = 3;
		Rect rect = default(Rect);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 5:
				switch (ProfileType)
				{
				case VolumeProfileType.BidAsk:
				{
					string text4 = (string)jyTvWlenH07goPS8Bom9(symbol, NmsHCmen2HgJbjLyuFTx(P_1), RoundValues, MinimizeValues);
					string text5 = (string)jyTvWlenH07goPS8Bom9(symbol, P_1.Ask, RoundValues, MinimizeValues);
					P_0.DrawString((string)WHBBnYenfUujW38KEwZK(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6F7F734B ^ 0x6F7FF54B), text4, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002284583), text5), base.Canvas.ChartFont, ssiilMiEUVw, rect, XTextAlignment.Right);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					return;
				case VolumeProfileType.Volume:
				{
					string text3 = symbol.FormatRawSize(inH9n4e9pqTEI8JcEN6E(P_1), RoundValues, MinimizeValues);
					P_0.DrawString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45443521) + text3, base.Canvas.ChartFont, ssiilMiEUVw, rect, XTextAlignment.Right);
					return;
				}
				case VolumeProfileType.Trades:
					text = symbol.FormatTrades(yOKaUEe9u7a1a81KlhfV(P_1), RoundValues, MinimizeValues);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
					{
						num2 = 0;
					}
					break;
				case VolumeProfileType.Delta:
					text2 = symbol.FormatRawSize(P_1.Delta, RoundValues, MinimizeValues);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
					{
						num2 = 1;
					}
					break;
				}
				break;
			case 1:
				eYcfIlen0VZrejKHT4DP(P_0, rp7T17e9z6K5vO3eFjW4(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6E2DFBED ^ 0x6E2D7E1B), text2), base.Canvas.ChartFont, ssiilMiEUVw, rect, XTextAlignment.Right);
				num2 = 4;
				break;
			default:
				P_0.DrawString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x8093F27) + text, base.Canvas.ChartFont, ssiilMiEUVw, rect, XTextAlignment.Right);
				return;
			case 2:
				return;
			case 3:
				rect = new Rect(new Point(rectangle.Left + 2.0, rectangle.Bottom + 4.0), new Point(rectangle.Right - 2.0, rectangle.Bottom + num + 4.0));
				num2 = 5;
				break;
			}
		}
	}

	private bool YJpii60YaYN(IRawCluster P_0, IRawClusterItem P_1, IRawClusterMaxValues P_2)
	{
		switch (MaximumType)
		{
		case VolumeProfileMaximumType.Volume:
			return zB3JBCen9YFnoEkkUBsa(P_1) == rLlFAqenn1P9bdor6hQ9(P_2);
		case VolumeProfileMaximumType.Trades:
			return P_1.Trades == P_2.MaxTrades;
		case VolumeProfileMaximumType.Delta:
			return Math.Abs(P_1.Delta) == FiDpW6env0hkfwmaiaqD(Math.Abs(jbJwrbenGpYPmfH4oDga(P_2)), cUKRIVeno89LBfmKmHg7(XCO1EFenYwrmeeVZWsRF(P_2)));
		case VolumeProfileMaximumType.DeltaPlus:
			if (GBHyfsenB6RQwDBcuSgW(P_1) > 0)
			{
				return GBHyfsenB6RQwDBcuSgW(P_1) == P_2.MaxDelta;
			}
			return false;
		case VolumeProfileMaximumType.DeltaMinus:
			if (P_1.Delta >= 0)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
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
				goto case VolumeProfileMaximumType.Volume;
			}
			return P_1.Delta == P_2.MinDelta;
		case VolumeProfileMaximumType.Bid:
			return edvO0jenawZsS7myJu8N(P_1) == P_2.MaxBid;
		case VolumeProfileMaximumType.Ask:
			return RK0n52eniLaph0ZTilQV(P_1) == KMWZ8renlR9lhg4Sg9Ro(P_2);
		default:
			return false;
		}
	}

	private string Y0WiiMTkEe5(IRawClusterItem P_0)
	{
		switch (MaximumType)
		{
		case VolumeProfileMaximumType.Volume:
			return ((IChartSymbol)f1msIgen4R9rkCqG1HYi(base.DataProvider)).FormatRawSize(zB3JBCen9YFnoEkkUBsa(P_0), RoundValues, MinimizeValues);
		case VolumeProfileMaximumType.Trades:
			return base.DataProvider.Symbol.FormatTrades(P_0.Trades, RoundValues, MinimizeValues);
		case VolumeProfileMaximumType.Delta:
		case VolumeProfileMaximumType.DeltaPlus:
		case VolumeProfileMaximumType.DeltaMinus:
			return ((IChartSymbol)f1msIgen4R9rkCqG1HYi(base.DataProvider)).FormatRawSize(P_0.Delta, RoundValues, MinimizeValues);
		case VolumeProfileMaximumType.Bid:
			return (string)jyTvWlenH07goPS8Bom9(base.DataProvider.Symbol, edvO0jenawZsS7myJu8N(P_0), RoundValues, MinimizeValues);
		case VolumeProfileMaximumType.Ask:
			return ((IChartSymbol)f1msIgen4R9rkCqG1HYi(base.DataProvider)).FormatRawSize(RK0n52eniLaph0ZTilQV(P_0), RoundValues, MinimizeValues);
		default:
			return "";
		}
	}

	private void jvPiiOqQWHA(DxVisualQueue P_0, IRawCluster P_1, IRawClusterValueArea P_2, Point P_3, Point P_4, ref List<ObjectLabelInfo> P_5)
	{
		int num = 33;
		List<Point> list3 = default(List<Point>);
		double num3 = default(double);
		int num13 = default(int);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		IChartSymbol symbol = default(IChartSymbol);
		XFont font = default(XFont);
		double num5 = default(double);
		List<Tuple<Rect, XBrush>> list = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		List<Tuple<Rect, string>> list5 = default(List<Tuple<Rect, string>>);
		int num9 = default(int);
		double num8 = default(double);
		int num12 = default(int);
		long num6 = default(long);
		double num7 = default(double);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		List<Tuple<Rect, XBrush>> list2 = default(List<Tuple<Rect, XBrush>>);
		double y = default(double);
		double num4 = default(double);
		Rect item = default(Rect);
		List<Tuple<Rect, string>>.Enumerator enumerator3 = default(List<Tuple<Rect, string>>.Enumerator);
		double num11 = default(double);
		int round = default(int);
		int num10 = default(int);
		double num17 = default(double);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator2 = default(List<Tuple<Rect, XBrush>>.Enumerator);
		double val = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					list3.Add(new Point(num3, num13));
					cG34nNeneKss6Ql9XF5h(P_0, wfCilXoxhy5, list3.ToArray());
					num2 = 15;
					continue;
				case 27:
					if (FilterMax == 0)
					{
						num2 = 16;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
						{
							num2 = 24;
						}
						continue;
					}
					if (rawClusterItem.Volume <= symbol.CorrectSizeFilter(FilterMax))
					{
						num2 = 23;
						continue;
					}
					goto case 4;
				case 10:
					font = new XFont(base.Canvas.ChartFont.Name, val);
					num5 = SUSZ0benbJ324eQtLdLp(P_4.X - P_3.X + base.Canvas.ColumnWidth - (double)base.LineWidth, 0.0);
					num3 = P_3.X - SigO4KenNsnyO51L0fXx(base.Canvas) / 2.0 + Math.Ceiling((double)base.LineWidth / 2.0);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 32:
					list = new List<Tuple<Rect, XBrush>>();
					list4 = new List<Tuple<Rect, string>>();
					list5 = new List<Tuple<Rect, string>>();
					num2 = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					num9 = (int)(num3 + num8);
					num12 = (int)GetY(((double)num6 - 0.5) * num7);
					num2 = 31;
					continue;
				case 1:
					if (ExtendProfile)
					{
						num2 = 29;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 2;
				case 34:
					num8 = ((zB3JBCen9YFnoEkkUBsa(rawClusterItem) > 0) ? Math.Min(num5 / (double)rLlFAqenn1P9bdor6hQ9(maxValues) * (double)rawClusterItem.Volume, num5) : 0.0);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
					{
						num2 = 3;
					}
					continue;
				case 23:
				case 24:
					if (TGWBdVenLo6wPNq4gPfW(list2) > 0)
					{
						num2 = 37;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
						{
							num2 = 25;
						}
					}
					else
					{
						list2.Add(new Tuple<Rect, XBrush>(new Rect(num3, y, num8, num4), xHKilw0nwx7));
						num2 = 9;
					}
					continue;
				case 33:
					list2 = new List<Tuple<Rect, XBrush>>();
					num2 = 32;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
					{
						num2 = 29;
					}
					continue;
				case 13:
					num6--;
					goto default;
				case 37:
					item = list2[list2.Count - 1].Item1;
					num = 42;
					break;
				case 6:
					if (ShowMaximum)
					{
						num2 = 36;
						continue;
					}
					goto IL_0133;
				case 11:
					try
					{
						while (enumerator3.MoveNext())
						{
							Tuple<Rect, string> current2 = enumerator3.Current;
							int num14 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
							{
								num14 = 0;
							}
							switch (num14)
							{
							}
							P_0.DrawString(current2.Item2, font, ssiilMiEUVw, current2.Item1);
						}
					}
					finally
					{
						((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 41;
				default:
					if (num6 >= P_1.Low)
					{
						rawClusterItem = (IRawClusterItem)(iZPaFAen5hM4eGFLdQkZ(P_1, num6) ?? new RawClusterItem(num6));
						num2 = 34;
						continue;
					}
					num = 28;
					break;
				case 7:
					if (num11 > 7.0 && rawClusterItem.Volume > 0)
					{
						list4.Add(new Tuple<Rect, string>(new Rect(num3 + 2.0, y, num5, num11), symbol.FormatRawSize(rawClusterItem.Volume, round, MinimizeValues)));
						num2 = 13;
						continue;
					}
					goto case 13;
				case 41:
				{
					foreach (Tuple<Rect, string> item2 in list5)
					{
						int num15 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
						{
							num15 = 0;
						}
						switch (num15)
						{
						}
						P_0.DrawString(item2.Item2, base.Canvas.ChartFont, ssiilMiEUVw, item2.Item1, XTextAlignment.Right);
					}
					return;
				}
				case 35:
					FJUaTXen1rR8Cmynp3NW(P_0, base.LinePen, new Point(num3 + num5, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Top), new Point(num3 + num5, base.Canvas.Rect.Bottom));
					num2 = 2;
					continue;
				case 29:
					if (base.DrawBack)
					{
						P_0.FillRectangle(base.BackBrush, new Rect(new Point(num3, base.Canvas.Rect.Top), new Point(num3 + num5, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom)));
						num2 = 5;
						continue;
					}
					goto case 5;
				case 26:
					list3.Add(new Point(num9, num13));
					list3.Add(new Point(num9, num12));
					num10 = num9;
					goto IL_08fa;
				case 30:
					list5.Add(new Tuple<Rect, string>(new Rect(num3 + 2.0, y - num17 - 2.0, Math.Max(num5 - 4.0, 1.0), num17), Y0WiiMTkEe5(rawClusterItem)));
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
					{
						num2 = 19;
					}
					continue;
				case 12:
					list2.Add(new Tuple<Rect, XBrush>(new Rect(num3, y, num8, num4), xHKilw0nwx7));
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (base.DrawBorder)
					{
						P_0.DrawLine(base.LinePen, new Point(num3, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Top), new Point(num3, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom));
						num2 = 35;
						continue;
					}
					goto case 2;
				case 40:
					return;
				case 16:
					y = list3[kFeMHNenSjvcvLKeH57H(list3) - 2].Y;
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
					{
						num2 = 1;
					}
					continue;
				case 39:
					if (ExtendValueArea)
					{
						P_5.Add(new ObjectLabelInfo((double)num6 * num7, ValueAreaColor));
					}
					goto case 4;
				case 22:
					if (ShowMaximumValue)
					{
						num17 = Df6gL4e93t0TxBWoYgRU(base.Canvas.ChartFont);
						num2 = 30;
						continue;
					}
					goto case 4;
				case 17:
					if (EnableFilter && rawClusterItem.Volume >= FojEBLenxVwwU2wso0bS(symbol, FilterMin))
					{
						num2 = 27;
						continue;
					}
					goto case 4;
				case 8:
					try
					{
						while (enumerator2.MoveNext())
						{
							Tuple<Rect, XBrush> current4 = enumerator2.Current;
							P_0.FillRectangle(current4.Item2, current4.Item1);
						}
						int num16 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
						{
							num16 = 0;
						}
						switch (num16)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
					}
					enumerator3 = list4.GetEnumerator();
					num2 = 11;
					continue;
				case 21:
					round = RoundValues;
					num10 = (int)num3;
					num13 = (int)GetY(((double)P_1.High + 0.5) * num7);
					list3 = new List<Point>
					{
						new Point(num10, num13)
					};
					num6 = P_1.High;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 36:
					if (YJpii60YaYN(P_1, rawClusterItem, maxValues))
					{
						num2 = 18;
						continue;
					}
					goto IL_0133;
				case 42:
					if ((int)item.Y != (int)y)
					{
						goto case 12;
					}
					if (num8 > item.Width)
					{
						list2[list2.Count - 1] = new Tuple<Rect, XBrush>(new Rect(num3, y, num8, item.Height), xHKilw0nwx7);
					}
					goto case 4;
				case 31:
					num4 = SUSZ0benbJ324eQtLdLp(num12 - num13, num11);
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
					{
						num2 = 38;
					}
					continue;
				case 38:
					if (num12 > num13 || kFeMHNenSjvcvLKeH57H(list3) <= 2)
					{
						goto case 26;
					}
					if (num9 > num10)
					{
						num2 = 14;
						continue;
					}
					goto IL_08fa;
				case 20:
					num7 = x8JRf6e9PcMTrTT1BDTI(base.DataProvider);
					symbol = base.DataProvider.Symbol;
					num11 = Math.Max(base.Canvas.StepHeight, 1.0);
					val = UaIteBenDLVG6xR37fbI(num11 - 2.0, 18.0) * 96.0 / 72.0;
					val = Math.Min(val, base.Canvas.ChartFont.Size);
					num = 10;
					break;
				case 15:
					foreach (Tuple<Rect, XBrush> item3 in list2)
					{
						P_0.FillRectangle(item3.Item2, item3.Item1);
					}
					enumerator2 = list.GetEnumerator();
					num = 8;
					break;
				case 4:
				case 9:
				case 19:
					if (ShowValues)
					{
						num2 = 7;
						continue;
					}
					goto case 13;
				case 25:
					if (rawClusterItem.Price != P_2.Val)
					{
						goto case 17;
					}
					goto IL_0db6;
				case 2:
					if (P_1.High - P_1.Low <= 100000)
					{
						maxValues = P_1.MaxValues;
						num2 = 21;
					}
					else
					{
						num2 = 40;
					}
					continue;
				case 14:
					list3[list3.Count - 2] = new Point(num9, list3[list3.Count - 2].Y);
					list3[list3.Count - 1] = new Point(num9, list3[list3.Count - 1].Y);
					num10 = num9;
					goto IL_08fa;
				case 18:
					{
						list.Add(new Tuple<Rect, XBrush>(ExtendMaximum ? new Rect(new Point(num3, y), new Point(Ta9xsnenkYWmvcGCRIfd(base.Canvas).Right + 1.0, y + num4)) : new Rect(num3, y, num5, num4), yOTilUZNAwi));
						if (ExtendMaximum)
						{
							P_5.Add(new ObjectLabelInfo((double)num6 * num7, MaximumColor));
							goto case 22;
						}
						num2 = 22;
						continue;
					}
					IL_0133:
					if (P_2 == null)
					{
						num2 = 17;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
						{
							num2 = 7;
						}
						continue;
					}
					if (rawClusterItem.Price != P_2.Vah)
					{
						num2 = 25;
						continue;
					}
					goto IL_0db6;
					IL_0db6:
					list.Add(new Tuple<Rect, XBrush>(ExtendValueArea ? new Rect(new Point(num3, y), new Point(base.Canvas.Rect.Right + 1.0, y + num4)) : new Rect(num3, y, num5, num4), LPIilCNaZ1M));
					num2 = 39;
					continue;
					IL_08fa:
					num13 = num12;
					num2 = 15;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
					{
						num2 = 16;
					}
					continue;
				}
				break;
			}
		}
	}

	private void asxiiqEkcNG(DxVisualQueue P_0, IRawCluster P_1, IRawClusterValueArea P_2, Point P_3, Point P_4, ref List<ObjectLabelInfo> P_5)
	{
		int num = 29;
		long num6 = default(long);
		double step = default(double);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator = default(List<Tuple<Rect, XBrush>>.Enumerator);
		List<Tuple<Rect, XBrush>> list = default(List<Tuple<Rect, XBrush>>);
		double num11 = default(double);
		double num17 = default(double);
		XFont font = default(XFont);
		int num14 = default(int);
		double num3 = default(double);
		List<Tuple<Rect, XBrush>> list3 = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		double y = default(double);
		double num13 = default(double);
		Rect item = default(Rect);
		List<Tuple<Rect, string>> list5 = default(List<Tuple<Rect, string>>);
		IChartSymbol symbol = default(IChartSymbol);
		List<Point> list2 = default(List<Point>);
		int num12 = default(int);
		int num10 = default(int);
		int num9 = default(int);
		IRawClusterMaxValues rawClusterMaxValues = default(IRawClusterMaxValues);
		double num4 = default(double);
		double num5 = default(double);
		int round = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num7;
				switch (num2)
				{
				case 8:
					num6--;
					goto IL_0d08;
				case 23:
					P_5.Add(new ObjectLabelInfo((double)num6 * step, ValueAreaColor));
					num = 16;
					break;
				default:
					if (rawClusterItem.Price == KThn8DendWh7ylTovf3b(P_2))
					{
						num = 11;
						break;
					}
					goto case 3;
				case 34:
					if (ExtendMaximum)
					{
						num2 = 14;
						continue;
					}
					goto IL_0872;
				case 41:
					num6 = OvNkEDenjdcWCcsFHbdo(P_1);
					goto IL_0d08;
				case 21:
					enumerator = list.GetEnumerator();
					num2 = 11;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
					{
						num2 = 27;
					}
					continue;
				case 16:
				case 43:
					if (!ShowValues)
					{
						num2 = 8;
						continue;
					}
					if (num11 > 7.0)
					{
						num = 4;
						break;
					}
					goto case 8;
				case 38:
					num17 = Math.Min(num17, ((XFont)ivTJ24ens2cbaF8BEsm9(base.Canvas)).Size);
					font = new XFont(base.Canvas.ChartFont.Name, num17);
					num2 = 5;
					continue;
				case 3:
					if (!EnableFilter)
					{
						goto case 16;
					}
					goto case 39;
				case 25:
					return;
				case 12:
					num14 = (int)num3;
					num2 = 31;
					continue;
				case 29:
					list3 = new List<Tuple<Rect, XBrush>>();
					num2 = 28;
					continue;
				case 27:
					try
					{
						while (enumerator.MoveNext())
						{
							Tuple<Rect, XBrush> current2 = enumerator.Current;
							P_0.FillRectangle(current2.Item2, current2.Item1);
							int num15 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
							{
								num15 = 0;
							}
							switch (num15)
							{
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					foreach (Tuple<Rect, string> item2 in list4)
					{
						P_0.DrawString(item2.Item2, font, ssiilMiEUVw, item2.Item1);
					}
					goto case 17;
				case 42:
					list3[TGWBdVenLo6wPNq4gPfW(list3) - 1] = new Tuple<Rect, XBrush>(new Rect(num3, y, num13, item.Height), xHKilw0nwx7);
					goto case 16;
				case 9:
					if (ExtendValueArea)
					{
						num2 = 23;
						continue;
					}
					goto case 16;
				case 17:
				{
					foreach (Tuple<Rect, string> item3 in list5)
					{
						int num16 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
						{
							num16 = 0;
						}
						switch (num16)
						{
						}
						P_0.DrawString(item3.Item2, base.Canvas.ChartFont, ssiilMiEUVw, item3.Item1, XTextAlignment.Right);
					}
					return;
				}
				case 26:
					if (P_2 == null)
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				case 28:
					list = new List<Tuple<Rect, XBrush>>();
					list4 = new List<Tuple<Rect, string>>();
					list5 = new List<Tuple<Rect, string>>();
					step = base.DataProvider.Step;
					symbol = base.DataProvider.Symbol;
					num11 = SUSZ0benbJ324eQtLdLp(base.Canvas.StepHeight, 1.0);
					num17 = Math.Min(num11 - 2.0, 18.0) * 96.0 / 72.0;
					num2 = 38;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
					{
						num2 = 35;
					}
					continue;
				case 20:
					cG34nNeneKss6Ql9XF5h(P_0, wfCilXoxhy5, yhLWYLenRdZXASWO3bZ3(list2));
					num2 = 32;
					continue;
				case 1:
					if (LYQdPTenQN9PK3cLaQuG(rawClusterItem) != P_2.Vah)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 30:
					if (num13 > item.Width)
					{
						num2 = 42;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 16;
				case 13:
					if (num12 > num14)
					{
						list2[list2.Count - 2] = new Point(num12, list2[list2.Count - 2].Y);
						list2[list2.Count - 1] = new Point(num12, list2[list2.Count - 1].Y);
						num14 = num12;
						num2 = 7;
						continue;
					}
					goto case 7;
				case 31:
					num10 = (int)GetY(((double)P_1.High + 0.5) * step);
					num2 = 40;
					continue;
				case 7:
				case 37:
					num10 = num9;
					y = list2[kFeMHNenSjvcvLKeH57H(list2) - 2].Y;
					if (ShowMaximum)
					{
						if (YJpii60YaYN(P_1, rawClusterItem, rawClusterMaxValues))
						{
							num2 = 19;
							continue;
						}
						goto case 26;
					}
					num2 = 26;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
					{
						num2 = 5;
					}
					continue;
				case 32:
					enumerator = list3.GetEnumerator();
					num2 = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
					{
						num2 = 35;
					}
					continue;
				case 22:
					list3.Add(new Tuple<Rect, XBrush>(new Rect(num3, y, num13, num4), xHKilw0nwx7));
					goto case 16;
				case 5:
					num5 = P_4.X - P_3.X + SigO4KenNsnyO51L0fXx(base.Canvas) - (double)base.LineWidth;
					num3 = P_3.X - base.Canvas.ColumnWidth / 2.0 + Math.Ceiling((double)base.LineWidth / 2.0);
					if (!ExtendProfile)
					{
						goto IL_0245;
					}
					if (base.DrawBack)
					{
						Xbgm6venXynrKBA6hYGH(P_0, base.BackBrush, new Rect(new Point(num3, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Top), new Point(num3 + num5, base.Canvas.Rect.Bottom)));
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 33;
				case 33:
					if (base.DrawBorder)
					{
						num2 = 6;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_0245;
				case 4:
					if (n8V3JgengXuisAKt5gKs(rawClusterItem) > 0)
					{
						list4.Add(new Tuple<Rect, string>(new Rect(num3 + 2.0, y, num5, num11), symbol.FormatTrades(rawClusterItem.Trades, round, MinimizeValues)));
					}
					goto case 8;
				case 15:
					return;
				case 14:
					P_5.Add(new ObjectLabelInfo((double)num6 * step, MaximumColor));
					goto IL_0872;
				case 39:
					if (n8V3JgengXuisAKt5gKs(rawClusterItem) >= FilterMin && (FilterMax == 0 || n8V3JgengXuisAKt5gKs(rawClusterItem) <= FilterMax))
					{
						if (list3.Count <= 0)
						{
							goto case 22;
						}
						item = list3[TGWBdVenLo6wPNq4gPfW(list3) - 1].Item1;
						if ((int)item.Y == (int)y)
						{
							num = 30;
							break;
						}
						list3.Add(new Tuple<Rect, XBrush>(new Rect(num3, y, num13, num4), xHKilw0nwx7));
					}
					goto case 16;
				case 6:
					FJUaTXen1rR8Cmynp3NW(P_0, base.LinePen, new Point(num3, base.Canvas.Rect.Top), new Point(num3, base.Canvas.Rect.Bottom));
					P_0.DrawLine(base.LinePen, new Point(num3 + num5, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Top), new Point(num3 + num5, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom));
					goto IL_0245;
				case 10:
					num14 = num12;
					num2 = 37;
					continue;
				case 40:
					list2 = new List<Point>
					{
						new Point(num14, num10)
					};
					num2 = 41;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
					{
						num2 = 26;
					}
					continue;
				case 24:
					num12 = (int)(num3 + num13);
					num9 = (int)GetY(((double)num6 - 0.5) * step);
					num2 = 36;
					continue;
				case 2:
					rawClusterItem = (IRawClusterItem)(iZPaFAen5hM4eGFLdQkZ(P_1, num6) ?? new RawClusterItem(num6));
					if (rawClusterItem.Trades <= 0)
					{
						num2 = 18;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					num7 = Math.Min(num5 / (double)aAJnIOenES9YjSyxcjCo(rawClusterMaxValues) * (double)rawClusterItem.Trades, num5);
					goto IL_0d43;
				case 36:
					num4 = Math.Max(num9 - num10, num11);
					if (num9 > num10 || kFeMHNenSjvcvLKeH57H(list2) <= 2)
					{
						list2.Add(new Point(num12, num10));
						list2.Add(new Point(num12, num9));
						num2 = 10;
					}
					else
					{
						num2 = 13;
					}
					continue;
				case 35:
					try
					{
						while (enumerator.MoveNext())
						{
							Tuple<Rect, XBrush> current = enumerator.Current;
							P_0.FillRectangle(current.Item2, current.Item1);
						}
						int num8 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 21;
				case 18:
					num7 = 0.0;
					goto IL_0d43;
				case 19:
					list.Add(new Tuple<Rect, XBrush>(ExtendMaximum ? new Rect(new Point(num3, y), new Point(base.Canvas.Rect.Right + 1.0, y + num4)) : new Rect(num3, y, num5, num4), yOTilUZNAwi));
					num2 = 34;
					continue;
				case 11:
					{
						list.Add(new Tuple<Rect, XBrush>(ExtendValueArea ? new Rect(new Point(num3, y), new Point(base.Canvas.Rect.Right + 1.0, y + num4)) : new Rect(num3, y, num5, num4), LPIilCNaZ1M));
						num2 = 9;
						continue;
					}
					IL_0d43:
					num13 = num7;
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
					{
						num2 = 24;
					}
					continue;
					IL_0245:
					if (P_1.High - P_1.Low > 10000)
					{
						num2 = 25;
						continue;
					}
					rawClusterMaxValues = (IRawClusterMaxValues)tJrscHencvHguJAtgjVr(P_1);
					round = RoundValues;
					num2 = 12;
					continue;
					IL_0d08:
					if (num6 < P_1.Low)
					{
						list2.Add(new Point(num3, num10));
						num = 20;
						break;
					}
					goto case 2;
					IL_0872:
					if (ShowMaximumValue)
					{
						double height = base.Canvas.ChartFont.GetHeight();
						list5.Add(new Tuple<Rect, string>(new Rect(num3 + 2.0, y - height - 2.0, Math.Max(num5 - 4.0, 1.0), height), Y0WiiMTkEe5(rawClusterItem)));
						num2 = 43;
						continue;
					}
					goto case 16;
				}
				break;
			}
		}
	}

	private void HHIiiISsS6o(DxVisualQueue P_0, IRawCluster P_1, IRawClusterValueArea P_2, Point P_3, Point P_4, ref List<ObjectLabelInfo> P_5)
	{
		List<Tuple<Rect, XBrush>> list = new List<Tuple<Rect, XBrush>>();
		List<Tuple<Rect, XBrush>> list2 = new List<Tuple<Rect, XBrush>>();
		int num = 28;
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		IChartSymbol chartSymbol = default(IChartSymbol);
		double num11 = default(double);
		double num19 = default(double);
		IRawClusterMaxValues rawClusterMaxValues = default(IRawClusterMaxValues);
		int round = default(int);
		double num3 = default(double);
		double num12 = default(double);
		double num14 = default(double);
		List<Point> list5 = default(List<Point>);
		int num5 = default(int);
		int num6 = default(int);
		long num2 = default(long);
		double num4 = default(double);
		Rect item2 = default(Rect);
		double y = default(double);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		double y2 = default(double);
		List<Tuple<Rect, XBrush>> list6 = default(List<Tuple<Rect, XBrush>>);
		double num16 = default(double);
		double num13 = default(double);
		double step = default(double);
		long num7 = default(long);
		IRawClusterItem rawClusterItem2 = default(IRawClusterItem);
		List<Point> list3 = default(List<Point>);
		List<Tuple<Rect, string>>.Enumerator enumerator = default(List<Tuple<Rect, string>>.Enumerator);
		double height2 = default(double);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator2 = default(List<Tuple<Rect, XBrush>>.Enumerator);
		List<Tuple<Rect, string>> list9 = default(List<Tuple<Rect, string>>);
		int num9 = default(int);
		int num18 = default(int);
		Point point = default(Point);
		XFont xFont = default(XFont);
		List<Tuple<Rect, string>> list7 = default(List<Tuple<Rect, string>>);
		int num21 = default(int);
		Rect item = default(Rect);
		int num20 = default(int);
		double height = default(double);
		while (true)
		{
			double num17;
			int num10;
			double num15;
			switch (num)
			{
			case 58:
				if (rawClusterItem.Delta > FojEBLenxVwwU2wso0bS(chartSymbol, FilterMax))
				{
					goto case 3;
				}
				goto IL_0f20;
			case 2:
				num11 = SUSZ0benbJ324eQtLdLp(xhEbhwen6Smk2Uh43Ai4(base.Canvas), 1.0);
				num19 = Math.Min(num11 - 2.0, 18.0) * 96.0 / 72.0;
				num = 66;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
				{
					num = 27;
				}
				continue;
			case 42:
				if (OvNkEDenjdcWCcsFHbdo(P_1) - P_1.Low > 10000)
				{
					num = 30;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
					{
						num = 27;
					}
					continue;
				}
				rawClusterMaxValues = (IRawClusterMaxValues)tJrscHencvHguJAtgjVr(P_1);
				round = RoundValues;
				num3 = num12 + num14 / 2.0;
				num = 11;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
				{
					num = 21;
				}
				continue;
			case 1:
				list5 = new List<Point>
				{
					new Point(num5, num6)
				};
				num2 = OvNkEDenjdcWCcsFHbdo(P_1);
				goto IL_0183;
			case 4:
				if (num4 > item2.Width)
				{
					list2[TGWBdVenLo6wPNq4gPfW(list2) - 1] = new Tuple<Rect, XBrush>(new Rect(num3 - num4, y, num4, item2.Height), xHKilw0nwx7);
					num = 15;
					continue;
				}
				goto case 15;
			case 9:
				list4.Add(new Tuple<Rect, string>(new Rect(num3 + 2.0, y2, num14 / 2.0, num11), chartSymbol.FormatRawSize(rawClusterItem.Delta, round, MinimizeValues)));
				num = 8;
				continue;
			case 34:
				list6.Add(new Tuple<Rect, XBrush>(new Rect(num3, y2, num16, num13), xHKilw0nwx7));
				goto case 3;
			case 22:
				if (rawClusterItem.Delta <= 0)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
					{
						num = 38;
					}
					continue;
				}
				num17 = Math.Min(num14 / (double)Math.Max(cUKRIVeno89LBfmKmHg7(XCO1EFenYwrmeeVZWsRF(rawClusterMaxValues)), Math.Abs(jbJwrbenGpYPmfH4oDga(rawClusterMaxValues))) * (double)cUKRIVeno89LBfmKmHg7(rawClusterItem.Delta), num14) / 2.0;
				goto IL_14ea;
			case 43:
				step = base.DataProvider.Step;
				chartSymbol = (IChartSymbol)f1msIgen4R9rkCqG1HYi(base.DataProvider);
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
				{
					num = 1;
				}
				continue;
			case 21:
				num5 = (int)num3;
				num6 = (int)GetY(((double)P_1.High + 0.5) * step);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num = 1;
				}
				continue;
			case 11:
				if (num7 < KuxCcMenqWpowol8KvTJ(P_1))
				{
					num = 52;
					continue;
				}
				rawClusterItem2 = P_1.GetItem(num7) ?? new RawClusterItem(num7);
				num10 = 33;
				goto IL_0005;
			case 5:
				list3 = new List<Point>
				{
					new Point(num5, num6)
				};
				num7 = P_1.High;
				num = 11;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
				{
					num = 2;
				}
				continue;
			case 39:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, string> current6 = enumerator.Current;
						int num26 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
						{
							num26 = 0;
						}
						switch (num26)
						{
						}
						eYcfIlen0VZrejKHT4DP(P_0, current6.Item2, ivTJ24ens2cbaF8BEsm9(base.Canvas), ssiilMiEUVw, current6.Item1, XTextAlignment.Right);
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 31:
				list2.Add(new Tuple<Rect, XBrush>(new Rect(num3 - num4, y, num4, height2), xHKilw0nwx7));
				goto case 15;
			case 44:
				P_0.FillPolygon(wFNiljTjDGd, list3.ToArray());
				P_0.FillPolygon(wfCilXoxhy5, list5.ToArray());
				enumerator2 = list2.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
				{
					num = 0;
				}
				continue;
			case 30:
				return;
			case 35:
				num12 = P_3.X - SigO4KenNsnyO51L0fXx(base.Canvas) / 2.0 + lMYtBvenOxR6mwAyyrOQ((double)base.LineWidth / 2.0);
				if (ExtendProfile)
				{
					if (base.DrawBack)
					{
						P_0.FillRectangle(base.BackBrush, new Rect(new Point(num12, base.Canvas.Rect.Top), new Point(num12 + num14, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom)));
					}
					if (base.DrawBorder)
					{
						num = 37;
						continue;
					}
				}
				goto case 42;
			case 15:
			case 20:
				if (!ShowValues || !(num11 > 7.0) || rawClusterItem2.Delta >= 0)
				{
					goto IL_1211;
				}
				num = 38;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
				{
					num = 63;
				}
				continue;
			case 7:
				enumerator = list9.GetEnumerator();
				num = 6;
				continue;
			case 23:
				list5.Add(new Point(num9, num6));
				list5.Add(new Point(num9, num18));
				num5 = num9;
				goto case 54;
			case 54:
				num6 = num18;
				point = list5[kFeMHNenSjvcvLKeH57H(list5) - 2];
				y2 = point.Y;
				num = 32;
				continue;
			case 38:
				num17 = 0.0;
				goto IL_14ea;
			case 33:
				if (rawClusterItem2.Delta >= 0)
				{
					num = 16;
					continue;
				}
				num15 = Math.Min(num14 / (double)Math.Max(Math.Abs(XCO1EFenYwrmeeVZWsRF(rawClusterMaxValues)), Math.Abs(jbJwrbenGpYPmfH4oDga(rawClusterMaxValues))) * (double)cUKRIVeno89LBfmKmHg7(rawClusterItem2.Delta), num14) / 2.0;
				break;
			case 52:
				list3.Add(new Point(num3, num6));
				num10 = 44;
				goto IL_0005;
			case 28:
				list6 = new List<Tuple<Rect, XBrush>>();
				list9 = new List<Tuple<Rect, string>>();
				num = 34;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
				{
					num = 61;
				}
				continue;
			case 63:
				list9.Add(new Tuple<Rect, string>(new Rect(num12, y, num14 / 2.0 - 2.0, num11), chartSymbol.FormatRawSize(GBHyfsenB6RQwDBcuSgW(rawClusterItem2), round, MinimizeValues)));
				goto IL_1211;
			case 18:
				if (!YJpii60YaYN(P_1, rawClusterItem, rawClusterMaxValues))
				{
					goto IL_11bf;
				}
				list.Add(new Tuple<Rect, XBrush>(ExtendMaximum ? new Rect(new Point(num12, y2), new Point(base.Canvas.Rect.Right + 1.0, y2 + num13)) : new Rect(num12, y2, num14, num13), yOTilUZNAwi));
				num = 51;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
				{
					num = 64;
				}
				continue;
			case 6:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, string> current = enumerator.Current;
						int num8 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						}
						P_0.DrawString(current.Item2, xFont, ssiilMiEUVw, current.Item1, XTextAlignment.Right);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator = list4.GetEnumerator();
				num = 40;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 35;
				}
				continue;
			case 57:
				if (LYQdPTenQN9PK3cLaQuG(rawClusterItem) != KThn8DendWh7ylTovf3b(P_2))
				{
					goto IL_0d78;
				}
				goto IL_1570;
			case 46:
				xFont = new XFont((string)HbjHaXenMEYnw1KXclvN(ivTJ24ens2cbaF8BEsm9(base.Canvas)), num19);
				num14 = P_4.X - P_3.X + base.Canvas.ColumnWidth - (double)base.LineWidth;
				num = 35;
				continue;
			case 48:
				if (FilterMax != 0)
				{
					num = 67;
					continue;
				}
				goto case 26;
			default:
				try
				{
					while (enumerator2.MoveNext())
					{
						Tuple<Rect, XBrush> current3 = enumerator2.Current;
						int num23 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
						{
							num23 = 0;
						}
						switch (num23)
						{
						}
						P_0.FillRectangle(current3.Item2, current3.Item1);
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				foreach (Tuple<Rect, XBrush> item3 in list6)
				{
					int num24 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
					{
						num24 = 0;
					}
					switch (num24)
					{
					}
					Xbgm6venXynrKBA6hYGH(P_0, item3.Item2, item3.Item1);
				}
				enumerator2 = list.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Tuple<Rect, XBrush> current5 = enumerator2.Current;
						P_0.FillRectangle(current5.Item2, current5.Item1);
						int num25 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
						{
							num25 = 0;
						}
						switch (num25)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 7;
			case 40:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, string> current2 = enumerator.Current;
						int num22 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						}
						eYcfIlen0VZrejKHT4DP(P_0, current2.Item2, xFont, ssiilMiEUVw, current2.Item1, XTextAlignment.Left);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator = list7.GetEnumerator();
				num = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num = 39;
				}
				continue;
			case 62:
				num6 = num21;
				point = list3[list3.Count - 2];
				num = 13;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
				{
					num = 17;
				}
				continue;
			case 3:
			case 51:
				if (ShowValues && num11 > 7.0 && GBHyfsenB6RQwDBcuSgW(rawClusterItem) > 0)
				{
					num = 9;
					continue;
				}
				goto case 8;
			case 10:
				if (YJpii60YaYN(P_1, rawClusterItem2, rawClusterMaxValues))
				{
					goto case 15;
				}
				goto case 50;
			case 66:
				num19 = UaIteBenDLVG6xR37fbI(num19, ((XFont)ivTJ24ens2cbaF8BEsm9(base.Canvas)).Size);
				num10 = 46;
				goto IL_0005;
			case 17:
				y = point.Y;
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
				{
					num = 47;
				}
				continue;
			case 55:
				num6 = (int)GetY(((double)P_1.High + 0.5) * step);
				num10 = 5;
				goto IL_0005;
			case 36:
			{
				list5[list5.Count - 2] = new Point(num9, list5[kFeMHNenSjvcvLKeH57H(list5) - 2].Y);
				List<Point> list10 = list5;
				int index2 = kFeMHNenSjvcvLKeH57H(list5) - 1;
				double x2 = num9;
				point = list5[list5.Count - 1];
				list10[index2] = new Point(x2, point.Y);
				num5 = num9;
				num = 35;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
				{
					num = 54;
				}
				continue;
			}
			case 13:
				list6[TGWBdVenLo6wPNq4gPfW(list6) - 1] = new Tuple<Rect, XBrush>(new Rect(num3, y2, num16, item.Height), xHKilw0nwx7);
				goto case 3;
			case 45:
				if (list5.Count > 2)
				{
					num = 53;
					continue;
				}
				goto case 23;
			case 26:
				if (list2.Count > 0)
				{
					item2 = list2[list2.Count - 1].Item1;
					num = 24;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
					{
						num = 11;
					}
					continue;
				}
				goto case 31;
			case 50:
				if (EnableFilter && rawClusterItem2.Delta < 0 && -rawClusterItem2.Delta >= FojEBLenxVwwU2wso0bS(chartSymbol, FilterMin))
				{
					num10 = 48;
					goto IL_0005;
				}
				goto case 15;
			case 47:
				if (ShowMaximum)
				{
					num = 10;
					continue;
				}
				goto case 50;
			case 29:
				if (num20 < num5)
				{
					List<Point> list8 = list3;
					int index = list3.Count - 2;
					double x = num20;
					point = list3[kFeMHNenSjvcvLKeH57H(list3) - 2];
					list8[index] = new Point(x, point.Y);
					num = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num = 14;
					}
					continue;
				}
				goto case 62;
			case 25:
				list7 = new List<Tuple<Rect, string>>();
				num = 26;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
				{
					num = 43;
				}
				continue;
			case 41:
				height2 = SUSZ0benbJ324eQtLdLp(num21 - num6, num11);
				if (num21 <= num6)
				{
					num = 59;
					continue;
				}
				goto IL_06c4;
			case 67:
				if (-rawClusterItem2.Delta <= chartSymbol.CorrectSizeFilter(FilterMax))
				{
					num10 = 26;
					goto IL_0005;
				}
				goto case 15;
			case 60:
				num21 = (int)GetY(((double)num7 - 0.5) * step);
				num = 41;
				continue;
			case 8:
				num2--;
				goto IL_0183;
			case 14:
				list3[list3.Count - 1] = new Point(num20, list3[list3.Count - 1].Y);
				num5 = num20;
				goto case 62;
			case 56:
				list7.Add(new Tuple<Rect, string>(new Rect(num12 + 2.0, y2 - height - 2.0, SUSZ0benbJ324eQtLdLp(num14 - 4.0, 1.0), height), Y0WiiMTkEe5(rawClusterItem)));
				num = 3;
				continue;
			case 24:
				if ((int)item2.Y != (int)y)
				{
					list2.Add(new Tuple<Rect, XBrush>(new Rect(num3 - num4, y, num4, height2), xHKilw0nwx7));
					num = 20;
					continue;
				}
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num = 2;
				}
				continue;
			case 59:
				if (kFeMHNenSjvcvLKeH57H(list3) > 2)
				{
					num = 29;
					continue;
				}
				goto IL_06c4;
			case 61:
				list4 = new List<Tuple<Rect, string>>();
				num = 25;
				continue;
			case 32:
				if (ShowMaximum)
				{
					num = 18;
					continue;
				}
				goto IL_11bf;
			case 27:
				P_5.Add(new ObjectLabelInfo((double)num2 * step, ValueAreaColor));
				num = 51;
				continue;
			case 37:
				FJUaTXen1rR8Cmynp3NW(P_0, base.LinePen, new Point(num12, base.Canvas.Rect.Top), new Point(num12, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom));
				P_0.DrawLine(base.LinePen, new Point(num12 + num14, base.Canvas.Rect.Top), new Point(num12 + num14, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom));
				num = 42;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num = 7;
				}
				continue;
			case 49:
				if ((int)item.Y != (int)y2)
				{
					goto case 34;
				}
				if (num16 > item.Width)
				{
					num = 13;
					continue;
				}
				goto case 3;
			case 16:
				num15 = 0.0;
				break;
			case 12:
				list5.Add(new Point(num3, num6));
				num = 37;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
				{
					num = 65;
				}
				continue;
			case 53:
				if (num9 > num5)
				{
					num10 = 36;
					goto IL_0005;
				}
				goto case 54;
			case 65:
				num5 = (int)num3;
				num = 55;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
				{
					num = 18;
				}
				continue;
			case 19:
				if (rawClusterItem.Price != P_2.Vah)
				{
					num = 57;
					continue;
				}
				goto IL_1570;
			case 64:
				{
					if (ExtendMaximum)
					{
						P_5.Add(new ObjectLabelInfo((double)num2 * step, MaximumColor));
					}
					if (!ShowMaximumValue)
					{
						goto case 3;
					}
					height = base.Canvas.ChartFont.GetHeight();
					num = 56;
					continue;
				}
				IL_11bf:
				if (P_2 != null)
				{
					num = 19;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
					{
						num = 10;
					}
					continue;
				}
				goto IL_0d78;
				IL_0f20:
				if (list6.Count <= 0)
				{
					list6.Add(new Tuple<Rect, XBrush>(new Rect(num3, y2, num16, num13), xHKilw0nwx7));
					goto case 3;
				}
				item = list6[TGWBdVenLo6wPNq4gPfW(list6) - 1].Item1;
				num = 49;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
				{
					num = 43;
				}
				continue;
				IL_14ea:
				num16 = num17;
				num9 = (int)(num3 + num16);
				num18 = (int)GetY(((double)num2 - 0.5) * step);
				num13 = SUSZ0benbJ324eQtLdLp(num18 - num6, num11);
				if (num18 <= num6)
				{
					num = 45;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
					{
						num = 10;
					}
					continue;
				}
				goto case 23;
				IL_0d78:
				if (!EnableFilter || rawClusterItem.Delta <= 0 || rawClusterItem.Delta < FojEBLenxVwwU2wso0bS(chartSymbol, FilterMin))
				{
					goto case 3;
				}
				if (FilterMax != 0)
				{
					goto case 58;
				}
				goto IL_0f20;
				IL_0183:
				if (num2 < P_1.Low)
				{
					num = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
					{
						num = 12;
					}
					continue;
				}
				rawClusterItem = (IRawClusterItem)(iZPaFAen5hM4eGFLdQkZ(P_1, num2) ?? new RawClusterItem(num2));
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num = 22;
				}
				continue;
				IL_06c4:
				list3.Add(new Point(num20, num6));
				list3.Add(new Point(num20, num21));
				num5 = num20;
				num10 = 62;
				goto IL_0005;
				IL_1211:
				num7--;
				goto case 11;
				IL_0005:
				num = num10;
				continue;
				IL_1570:
				list.Add(new Tuple<Rect, XBrush>(ExtendValueArea ? new Rect(new Point(num12, y2), new Point(base.Canvas.Rect.Right + 1.0, y2 + num13)) : new Rect(num12, y2, num14, num13), LPIilCNaZ1M));
				if (ExtendValueArea)
				{
					num = 27;
					continue;
				}
				goto case 3;
			}
			num4 = num15;
			num20 = (int)(num3 - num4);
			num = 60;
		}
	}

	private void FU9iiWIF5Hk(DxVisualQueue P_0, IRawCluster P_1, IRawClusterValueArea P_2, Point P_3, Point P_4, ref List<ObjectLabelInfo> P_5)
	{
		List<Tuple<Rect, XBrush>> list = new List<Tuple<Rect, XBrush>>();
		List<Tuple<Rect, XBrush>> list2 = new List<Tuple<Rect, XBrush>>();
		int num = 44;
		IRawClusterItem rawClusterItem2 = default(IRawClusterItem);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		double num17 = default(double);
		long num6 = default(long);
		double num3 = default(double);
		List<Tuple<Rect, string>> list5 = default(List<Tuple<Rect, string>>);
		XFont font = default(XFont);
		List<Tuple<Rect, string>> list6 = default(List<Tuple<Rect, string>>);
		List<Tuple<Rect, string>>.Enumerator enumerator3 = default(List<Tuple<Rect, string>>.Enumerator);
		List<Tuple<Rect, string>> list8 = default(List<Tuple<Rect, string>>);
		List<Tuple<Rect, XBrush>> list4 = default(List<Tuple<Rect, XBrush>>);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator = default(List<Tuple<Rect, XBrush>>.Enumerator);
		int num15 = default(int);
		int num12 = default(int);
		List<Point> list3 = default(List<Point>);
		double num11 = default(double);
		int num14 = default(int);
		double y2 = default(double);
		double height = default(double);
		double y = default(double);
		double num7 = default(double);
		double num5 = default(double);
		IRawClusterItem rawClusterItem3 = default(IRawClusterItem);
		int round = default(int);
		int num8 = default(int);
		double step = default(double);
		double num16 = default(double);
		int num19 = default(int);
		Rect item2 = default(Rect);
		List<Point> list7 = default(List<Point>);
		IChartSymbol symbol = default(IChartSymbol);
		Rect item = default(Rect);
		long num2 = default(long);
		int num9 = default(int);
		int num13 = default(int);
		double num4 = default(double);
		int num20 = default(int);
		while (true)
		{
			int num10;
			object obj;
			object rawClusterItem;
			switch (num)
			{
			case 50:
				if (ShowMaximum)
				{
					if (!YJpii60YaYN(P_1, rawClusterItem2, maxValues))
					{
						num = 47;
						break;
					}
					goto case 19;
				}
				goto case 47;
			case 20:
				num17 = Math.Min(num17, base.Canvas.ChartFont.Size);
				num = 34;
				break;
			case 62:
				num6--;
				num = 35;
				break;
			case 24:
			case 25:
				if (base.DrawBorder)
				{
					P_0.DrawLine(base.LinePen, new Point(num3, base.Canvas.Rect.Top), new Point(num3, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom));
					num = 36;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
					{
						num = 20;
					}
					break;
				}
				goto IL_0f2e;
			case 32:
				foreach (Tuple<Rect, string> item3 in list5)
				{
					int num21 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
					{
						num21 = 0;
					}
					switch (num21)
					{
					}
					P_0.DrawString(item3.Item2, font, ssiilMiEUVw, item3.Item1, XTextAlignment.Right);
				}
				foreach (Tuple<Rect, string> item4 in list6)
				{
					P_0.DrawString(item4.Item2, font, ssiilMiEUVw, item4.Item1);
				}
				enumerator3 = list8.GetEnumerator();
				num = 48;
				break;
			case 44:
				list4 = new List<Tuple<Rect, XBrush>>();
				num = 41;
				break;
			case 31:
				if (ExtendProfile)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
					{
						num = 1;
					}
					break;
				}
				goto IL_0f2e;
			case 15:
				enumerator = list2.GetEnumerator();
				num = 13;
				break;
			case 41:
				list5 = new List<Tuple<Rect, string>>();
				list6 = new List<Tuple<Rect, string>>();
				num = 5;
				break;
			case 2:
				if (num15 > num12)
				{
					list3[list3.Count - 2] = new Point(num15, list3[list3.Count - 2].Y);
					list3[list3.Count - 1] = new Point(num15, list3[kFeMHNenSjvcvLKeH57H(list3) - 1].Y);
					num = 22;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
					{
						num = 20;
					}
					break;
				}
				goto case 52;
			case 26:
				list2.Add(new Tuple<Rect, XBrush>(new Rect(num11 - (double)num14, y2, num14, height), xHKilw0nwx7));
				goto case 19;
			case 43:
				list8.Add(new Tuple<Rect, string>(new Rect(num3 + 2.0, y - num7 - 2.0, Math.Max(num5 - 4.0, 1.0), num7), Y0WiiMTkEe5(rawClusterItem3)));
				goto case 58;
			case 13:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, XBrush> current5 = enumerator.Current;
						P_0.FillRectangle(current5.Item2, current5.Item1);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator = list4.GetEnumerator();
				num = 56;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num = 20;
				}
				break;
			case 51:
				if (rawClusterItem3.Price != P_2.Vah)
				{
					num = 37;
					break;
				}
				goto IL_14a8;
			case 28:
				num12 = (int)num11;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
				{
					num = 0;
				}
				break;
			case 1:
				if (!base.DrawBack)
				{
					num = 25;
					break;
				}
				P_0.FillRectangle(base.BackBrush, new Rect(new Point(num3, base.Canvas.Rect.Top), new Point(num3 + num5, base.Canvas.Rect.Bottom)));
				num = 24;
				break;
			case 59:
				if (list3.Count > 2)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
					{
						num = 2;
					}
					break;
				}
				goto IL_0817;
			case 38:
				round = RoundValues;
				num11 = Math.Floor(num3 + num5 / 2.0);
				num12 = (int)num11;
				num8 = (int)GetY(((double)P_1.High + 0.5) * step);
				list3 = new List<Point>
				{
					new Point(num12, num8)
				};
				num6 = OvNkEDenjdcWCcsFHbdo(P_1);
				num = 33;
				break;
			case 3:
				if (YJpii60YaYN(P_1, rawClusterItem3, maxValues))
				{
					num = 57;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
					{
						num = 41;
					}
					break;
				}
				goto IL_03cc;
			case 19:
			case 23:
				if (ShowValues)
				{
					num = 7;
					break;
				}
				goto IL_11cb;
			case 7:
				if (num16 > 7.0 && edvO0jenawZsS7myJu8N(rawClusterItem2) > 0)
				{
					num10 = 39;
					goto IL_0005;
				}
				goto IL_11cb;
			case 27:
				list3.Add(new Point(num11, num8));
				num = 28;
				break;
			case 49:
				if (num19 < num12)
				{
					num = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
					{
						num = 29;
					}
					break;
				}
				goto IL_08b2;
			default:
				num8 = (int)GetY(((double)OvNkEDenjdcWCcsFHbdo(P_1) + 0.5) * step);
				num = 30;
				break;
			case 56:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, XBrush> current6 = enumerator.Current;
						P_0.FillRectangle(current6.Item2, current6.Item1);
						int num22 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 46;
			case 45:
				item2 = list2[list2.Count - 1].Item1;
				if ((int)item2.Y == (int)y2)
				{
					num = 21;
					break;
				}
				goto case 26;
			case 61:
				if (list7.Count > 2)
				{
					num = 49;
					break;
				}
				goto IL_0516;
			case 37:
				if (LYQdPTenQN9PK3cLaQuG(rawClusterItem3) != P_2.Val)
				{
					goto IL_0ac0;
				}
				goto IL_14a8;
			case 47:
				if (!EnableFilter)
				{
					goto case 19;
				}
				goto case 12;
			case 29:
				list7[list7.Count - 2] = new Point(num19, list7[list7.Count - 2].Y);
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
				{
					num = 7;
				}
				break;
			case 33:
			case 35:
				if (num6 < KuxCcMenqWpowol8KvTJ(P_1))
				{
					num = 27;
					break;
				}
				goto case 42;
			case 9:
				list7[kFeMHNenSjvcvLKeH57H(list7) - 1] = new Point(num19, list7[list7.Count - 1].Y);
				num = 14;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num = 9;
				}
				break;
			case 58:
			case 65:
				if (ShowValues && num16 > 7.0 && rawClusterItem3.Ask > 0)
				{
					list6.Add(new Tuple<Rect, string>(new Rect(num11 + 2.0, y, num5 / 2.0, num16), symbol.FormatRawSize(rawClusterItem3.Ask, round, MinimizeValues)));
					num = 62;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
					{
						num = 49;
					}
					break;
				}
				goto case 62;
			case 60:
				if (list4.Count > 0)
				{
					item = list4[list4.Count - 1].Item1;
					num10 = 11;
					goto IL_0005;
				}
				goto case 54;
			case 14:
				num12 = num19;
				goto IL_08b2;
			case 48:
				try
				{
					while (enumerator3.MoveNext())
					{
						Tuple<Rect, string> current4 = enumerator3.Current;
						P_0.DrawString(current4.Item2, (XFont)ivTJ24ens2cbaF8BEsm9(base.Canvas), ssiilMiEUVw, current4.Item1, XTextAlignment.Right);
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
				}
			case 30:
				list7 = new List<Point>
				{
					new Point(num12, num8)
				};
				num2 = OvNkEDenjdcWCcsFHbdo(P_1);
				goto IL_055a;
			case 16:
				if (FilterMax == 0 || rawClusterItem2.Bid <= symbol.CorrectSizeFilter(FilterMax))
				{
					if (list2.Count <= 0)
					{
						list2.Add(new Tuple<Rect, XBrush>(new Rect(num11 - (double)num14, y2, num14, height), xHKilw0nwx7));
						num = 23;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
						{
							num = 6;
						}
					}
					else
					{
						num = 45;
					}
					break;
				}
				goto case 19;
			case 39:
				list5.Add(new Tuple<Rect, string>(new Rect(num3, y2, num5 / 2.0 - 2.0, num16), symbol.FormatRawSize(rawClusterItem2.Bid, round, MinimizeValues)));
				goto IL_11cb;
			case 46:
				enumerator = list.GetEnumerator();
				num = 53;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
				{
					num = 11;
				}
				break;
			case 22:
				num12 = num15;
				goto case 52;
			case 52:
				num8 = num9;
				y = list3[list3.Count - 2].Y;
				num = 4;
				break;
			case 63:
				cG34nNeneKss6Ql9XF5h(P_0, wfCilXoxhy5, list3.ToArray());
				num = 15;
				break;
			case 11:
				if ((int)item.Y == (int)y)
				{
					num = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
					{
						num = 55;
					}
					break;
				}
				goto case 18;
			case 53:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, XBrush> current = enumerator.Current;
						P_0.FillRectangle(current.Item2, current.Item1);
						int num18 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
						{
							num18 = 0;
						}
						switch (num18)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 32;
			case 34:
				font = new XFont(((XFont)ivTJ24ens2cbaF8BEsm9(base.Canvas)).Name, num17);
				num5 = P_4.X - P_3.X + SigO4KenNsnyO51L0fXx(base.Canvas) - (double)base.LineWidth;
				num = 40;
				break;
			case 5:
				list8 = new List<Tuple<Rect, string>>();
				step = base.DataProvider.Step;
				symbol = base.DataProvider.Symbol;
				num16 = Math.Max(base.Canvas.StepHeight, 1.0);
				num17 = Math.Min(num16 - 2.0, 18.0) * 96.0 / 72.0;
				num = 20;
				break;
			case 40:
				num3 = P_3.X - base.Canvas.ColumnWidth / 2.0 + lMYtBvenOxR6mwAyyrOQ((double)base.LineWidth / 2.0);
				num = 31;
				break;
			case 54:
				list4.Add(new Tuple<Rect, XBrush>(new Rect(num11, y, num13, num4), xHKilw0nwx7));
				goto case 58;
			case 8:
				list7.Add(new Point(num11, num8));
				cG34nNeneKss6Ql9XF5h(P_0, wFNiljTjDGd, yhLWYLenRdZXASWO3bZ3(list7));
				num = 63;
				break;
			case 64:
				if (rawClusterItem3.Ask > FojEBLenxVwwU2wso0bS(symbol, FilterMax))
				{
					goto case 58;
				}
				goto case 60;
			case 36:
				P_0.DrawLine(base.LinePen, new Point(num3 + num5, base.Canvas.Rect.Top), new Point(num3 + num5, base.Canvas.Rect.Bottom));
				goto IL_0f2e;
			case 42:
				obj = iZPaFAen5hM4eGFLdQkZ(P_1, num6);
				if (obj == null)
				{
					num = 6;
					break;
				}
				goto IL_1432;
			case 21:
				if ((double)num14 > item2.Width)
				{
					list2[list2.Count - 1] = new Tuple<Rect, XBrush>(new Rect(num11 - (double)num14, y2, num14, item2.Height), xHKilw0nwx7);
					num = 19;
					break;
				}
				goto case 19;
			case 18:
				list4.Add(new Tuple<Rect, XBrush>(new Rect(num11, y, num13, num4), xHKilw0nwx7));
				num = 58;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
				{
					num = 21;
				}
				break;
			case 55:
				if ((double)num13 > item.Width)
				{
					list4[list4.Count - 1] = new Tuple<Rect, XBrush>(new Rect(num11, y, num13, item.Height), xHKilw0nwx7);
				}
				goto case 58;
			case 4:
				if (ShowMaximum)
				{
					num = 3;
					break;
				}
				goto IL_03cc;
			case 12:
				if (rawClusterItem2.Bid >= symbol.CorrectSizeFilter(FilterMin))
				{
					num = 16;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
					{
						num = 8;
					}
					break;
				}
				goto case 19;
			case 6:
				obj = new RawClusterItem(num6);
				goto IL_1432;
			case 57:
				list.Add(new Tuple<Rect, XBrush>(ExtendMaximum ? new Rect(new Point(num3, y), new Point(base.Canvas.Rect.Right + 1.0, y + num4)) : new Rect(num3, y, num5, num4), yOTilUZNAwi));
				if (ExtendMaximum)
				{
					P_5.Add(new ObjectLabelInfo((double)num6 * step, MaximumColor));
				}
				if (!ShowMaximumValue)
				{
					goto case 58;
				}
				num7 = Df6gL4e93t0TxBWoYgRU(base.Canvas.ChartFont);
				num = 43;
				break;
			case 17:
				rawClusterItem = P_1.GetItem(num2);
				if (rawClusterItem != null)
				{
					goto IL_153c;
				}
				num = 10;
				break;
			case 10:
				{
					rawClusterItem = new RawClusterItem(num2);
					goto IL_153c;
				}
				IL_0005:
				num = num10;
				break;
				IL_0817:
				list3.Add(new Point(num15, num8));
				list3.Add(new Point(num15, num9));
				num12 = num15;
				num = 52;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num = 25;
				}
				break;
				IL_0516:
				list7.Add(new Point(num19, num8));
				list7.Add(new Point(num19, num20));
				num12 = num19;
				goto IL_08b2;
				IL_14a8:
				list.Add(new Tuple<Rect, XBrush>(ExtendValueArea ? new Rect(new Point(num3, y), new Point(Ta9xsnenkYWmvcGCRIfd(base.Canvas).Right + 1.0, y + num4)) : new Rect(num3, y, num5, num4), LPIilCNaZ1M));
				if (!ExtendValueArea)
				{
					goto case 58;
				}
				P_5.Add(new ObjectLabelInfo((double)num6 * step, ValueAreaColor));
				num = 65;
				break;
				IL_1432:
				rawClusterItem3 = (IRawClusterItem)obj;
				num13 = (int)(Math.Min(num5 / (double)FiDpW6env0hkfwmaiaqD(maxValues.MaxBid, KMWZ8renlR9lhg4Sg9Ro(maxValues)) * (double)rawClusterItem3.Ask, num5) / 2.0);
				num15 = (int)(num11 + (double)num13);
				num9 = (int)GetY(((double)num6 - 0.5) * step);
				num4 = Math.Max(num9 - num8, num16);
				if (num9 <= num8)
				{
					num = 59;
					break;
				}
				goto IL_0817;
				IL_153c:
				rawClusterItem2 = (IRawClusterItem)rawClusterItem;
				num14 = (int)(UaIteBenDLVG6xR37fbI(num5 / (double)FiDpW6env0hkfwmaiaqD(maxValues.MaxBid, maxValues.MaxAsk) * (double)rawClusterItem2.Bid, num5) / 2.0);
				num19 = (int)(num11 - (double)num14);
				num20 = (int)GetY(((double)num2 - 0.5) * step);
				height = Math.Max(num20 - num8, num16);
				if (num20 <= num8)
				{
					num = 61;
					break;
				}
				goto IL_0516;
				IL_0f2e:
				if (P_1.High - P_1.Low > 10000)
				{
					return;
				}
				maxValues = P_1.MaxValues;
				num = 38;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
				{
					num = 24;
				}
				break;
				IL_08b2:
				num8 = num20;
				y2 = list7[list7.Count - 2].Y;
				num = 50;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num = 25;
				}
				break;
				IL_11cb:
				num2--;
				goto IL_055a;
				IL_03cc:
				if (P_2 != null)
				{
					num10 = 51;
					goto IL_0005;
				}
				goto IL_0ac0;
				IL_0ac0:
				if (!EnableFilter || rawClusterItem3.Ask < symbol.CorrectSizeFilter(FilterMin))
				{
					goto case 58;
				}
				if (FilterMax == 0)
				{
					num = 60;
					break;
				}
				goto case 64;
				IL_055a:
				if (num2 < P_1.Low)
				{
					num = 8;
					break;
				}
				goto case 17;
			}
		}
	}

	private void RmeiitAs8iM(DxVisualQueue P_0, IRawCluster P_1, IRawClusterValueArea P_2, Point P_3, Point P_4, ref List<ObjectLabelInfo> P_5)
	{
		List<Tuple<Rect, XBrush>> list = new List<Tuple<Rect, XBrush>>();
		List<Tuple<Rect, XBrush>> list2 = new List<Tuple<Rect, XBrush>>();
		int num = 14;
		int num17 = default(int);
		double num2 = default(double);
		int num18 = default(int);
		List<Tuple<Rect, string>> list4 = default(List<Tuple<Rect, string>>);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		int round = default(int);
		List<Tuple<Rect, string>>.Enumerator enumerator2 = default(List<Tuple<Rect, string>>.Enumerator);
		XFont font = default(XFont);
		double num6 = default(double);
		double y = default(double);
		double num7 = default(double);
		Rect item = default(Rect);
		long num10 = default(long);
		double num3 = default(double);
		List<Point> list5 = default(List<Point>);
		int num9 = default(int);
		List<Tuple<Rect, XBrush>>.Enumerator enumerator = default(List<Tuple<Rect, XBrush>>.Enumerator);
		List<Tuple<Rect, string>> list3 = default(List<Tuple<Rect, string>>);
		double num14 = default(double);
		double num4 = default(double);
		int num8 = default(int);
		Point point = default(Point);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		List<Point> list6 = default(List<Point>);
		IChartSymbol chartSymbol = default(IChartSymbol);
		long openPos = default(long);
		long num21 = default(long);
		double num11 = default(double);
		long num5 = default(long);
		int num19 = default(int);
		int num16 = default(int);
		double num12 = default(double);
		while (true)
		{
			double num20;
			object obj;
			switch (num)
			{
			case 30:
				num17 = (int)num2;
				num18 = (int)num2;
				num = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
				{
					num = 31;
				}
				continue;
			case 40:
				list4 = new List<Tuple<Rect, string>>();
				num = 19;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
				{
					num = 2;
				}
				continue;
			case 12:
			case 29:
				if (P_1.High - P_1.Low > 100000)
				{
					return;
				}
				maxValues = P_1.MaxValues;
				round = RoundValues;
				num = 30;
				continue;
			case 50:
				try
				{
					while (enumerator2.MoveNext())
					{
						Tuple<Rect, string> current4 = enumerator2.Current;
						P_0.DrawString(current4.Item2, font, ssiilMiEUVw, current4.Item1);
					}
					int num23 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
					{
						num23 = 0;
					}
					switch (num23)
					{
					case 0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 2;
			case 39:
				if (ShowValues)
				{
					num = 20;
					continue;
				}
				goto case 48;
			case 19:
				num6 = x8JRf6e9PcMTrTT1BDTI(base.DataProvider);
				num = 7;
				continue;
			case 43:
				list[TGWBdVenLo6wPNq4gPfW(list) - 1] = new Tuple<Rect, XBrush>(new Rect(num2, y, num7, item.Height), xHKilw0nwx7);
				goto case 39;
			case 2:
			{
				foreach (Tuple<Rect, string> item2 in list4)
				{
					P_0.DrawString(item2.Item2, (XFont)ivTJ24ens2cbaF8BEsm9(base.Canvas), ssiilMiEUVw, item2.Item1, XTextAlignment.Right);
				}
				return;
			}
			case 35:
			case 37:
				if (!EnableFilter || num10 < FilterMin)
				{
					goto case 39;
				}
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
				{
					num = 16;
				}
				continue;
			case 33:
				if ((int)item.Y != (int)y)
				{
					list.Add(new Tuple<Rect, XBrush>(new Rect(num2, y, num7, num3), xHKilw0nwx7));
				}
				else if (num7 > item.Width)
				{
					num = 43;
					continue;
				}
				goto case 39;
			case 18:
				list5.Add(new Point(num2, num9));
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num = 3;
				}
				continue;
			case 41:
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, XBrush> current = enumerator.Current;
						Xbgm6venXynrKBA6hYGH(P_0, current.Item2, current.Item1);
					}
					int num15 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
					{
						num15 = 0;
					}
					switch (num15)
					{
					case 0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator = list2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Tuple<Rect, XBrush> current2 = enumerator.Current;
						P_0.FillRectangle(current2.Item2, current2.Item1);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator2 = list3.GetEnumerator();
				num = 50;
				continue;
			case 32:
			{
				double num13 = Math.Min(num14 - 2.0, 18.0) * 96.0 / 72.0;
				num13 = UaIteBenDLVG6xR37fbI(num13, ((XFont)ivTJ24ens2cbaF8BEsm9(base.Canvas)).Size);
				font = new XFont((string)HbjHaXenMEYnw1KXclvN(base.Canvas.ChartFont), num13);
				num4 = Math.Max(P_4.X - P_3.X + SigO4KenNsnyO51L0fXx(base.Canvas) - (double)base.LineWidth, 0.0);
				num2 = P_3.X - base.Canvas.ColumnWidth / 2.0 + lMYtBvenOxR6mwAyyrOQ((double)base.LineWidth / 2.0);
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num = 11;
				}
				continue;
			}
			case 47:
				return;
			case 23:
				list5.Add(new Point(num8, num9));
				num = 34;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 18;
				}
				continue;
			case 46:
				y = point.Y;
				if (ShowMaximum && YJpii60YaYN(P_1, rawClusterItem, maxValues))
				{
					num = 26;
					continue;
				}
				goto case 3;
			case 8:
				num20 = 0.0;
				break;
			case 1:
				if (ShowMaximumValue)
				{
					double num22 = Df6gL4e93t0TxBWoYgRU(base.Canvas.ChartFont);
					list4.Add(new Tuple<Rect, string>(new Rect(num2 + 2.0, y - num22 - 2.0, Math.Max(num4 - 4.0, 1.0), num22), Y0WiiMTkEe5(rawClusterItem)));
				}
				goto case 39;
			case 25:
				num18 = num8;
				goto IL_0e83;
			case 4:
				P_0.FillPolygon(wfCilXoxhy5, list6.ToArray());
				cG34nNeneKss6Ql9XF5h(P_0, wFNiljTjDGd, yhLWYLenRdZXASWO3bZ3(list5));
				enumerator = list.GetEnumerator();
				num = 41;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num = 40;
				}
				continue;
			case 13:
				num14 = SUSZ0benbJ324eQtLdLp(base.Canvas.StepHeight, 1.0);
				num = 32;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 23;
				}
				continue;
			case 45:
				P_0.FillRectangle(base.BackBrush, new Rect(new Point(num2, base.Canvas.Rect.Top), new Point(num2 + num4, Ta9xsnenkYWmvcGCRIfd(base.Canvas).Bottom)));
				goto IL_0b65;
			case 3:
				if (P_2 == null)
				{
					num = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
					{
						num = 37;
					}
					continue;
				}
				goto case 10;
			case 14:
				list3 = new List<Tuple<Rect, string>>();
				num = 40;
				continue;
			case 20:
				if (num14 > 7.0 && num10 > 0)
				{
					list3.Add(new Tuple<Rect, string>(new Rect(num2 + 2.0, y, num4, num14), (string)Hi9dSAenW7bl7Uy0s5Sd(chartSymbol, openPos, round, MinimizeValues)));
					num = 48;
					continue;
				}
				goto case 48;
			case 21:
				num21 = FiDpW6env0hkfwmaiaqD(-maxValues.MinOpenPos, maxValues.MaxOpenPos);
				num11 = ((openPos > 0) ? UaIteBenDLVG6xR37fbI(num4 / (double)num21 * (double)num10, num4) : 0.0);
				num = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
				{
					num = 27;
				}
				continue;
			case 49:
				P_5.Add(new ObjectLabelInfo((double)num5 * num6, ValueAreaColor));
				goto case 39;
			case 48:
				num5--;
				goto case 15;
			case 22:
				num3 = SUSZ0benbJ324eQtLdLp(num19 - num9, num14);
				if (num19 <= num9 && list6.Count > 2)
				{
					num = 44;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
					{
						num = 40;
					}
					continue;
				}
				goto case 36;
			case 44:
				if (num16 > num17)
				{
					List<Point> list9 = list6;
					int index3 = list6.Count - 2;
					double x3 = num16;
					point = list6[kFeMHNenSjvcvLKeH57H(list6) - 2];
					list9[index3] = new Point(x3, point.Y);
					num = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
					{
						num = 2;
					}
					continue;
				}
				goto IL_0d1a;
			case 9:
				num16 = (int)(num2 + num11);
				num8 = (int)(num2 + num12);
				num19 = (int)GetY(((double)num5 - 0.5) * num6);
				num = 22;
				continue;
			case 34:
				list5.Add(new Point(num8, num19));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num = 6;
				}
				continue;
			case 27:
				if (openPos >= 0)
				{
					num = 8;
					continue;
				}
				num20 = UaIteBenDLVG6xR37fbI(num4 / (double)num21 * (double)num10, num4);
				break;
			case 36:
				list6.Add(new Point(num16, num9));
				list6.Add(new Point(num16, num19));
				num17 = num16;
				num = 23;
				continue;
			case 6:
				num18 = num8;
				goto IL_0e83;
			case 10:
				if (rawClusterItem.Price == P_2.Vah || rawClusterItem.Price == KThn8DendWh7ylTovf3b(P_2))
				{
					list2.Add(new Tuple<Rect, XBrush>(ExtendValueArea ? new Rect(new Point(num2, y), new Point(base.Canvas.Rect.Right + 1.0, y + num3)) : new Rect(num2, y, num4, num3), LPIilCNaZ1M));
					if (ExtendValueArea)
					{
						num = 49;
						continue;
					}
					goto case 39;
				}
				goto case 35;
			case 7:
				chartSymbol = (IChartSymbol)f1msIgen4R9rkCqG1HYi(base.DataProvider);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num = 13;
				}
				continue;
			case 24:
				point = list6[list6.Count - 2];
				num = 46;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 42;
				}
				continue;
			case 11:
				if (!ExtendProfile)
				{
					goto case 12;
				}
				if (base.DrawBack)
				{
					num = 45;
					continue;
				}
				goto IL_0b65;
			case 31:
				num9 = (int)GetY(((double)P_1.High + 0.5) * num6);
				list6 = new List<Point>
				{
					new Point(num17, num9)
				};
				list5 = new List<Point>
				{
					new Point(num18, num9)
				};
				num = 38;
				continue;
			case 5:
			{
				List<Point> list8 = list6;
				int index2 = list6.Count - 1;
				double x2 = num16;
				point = list6[list6.Count - 1];
				list8[index2] = new Point(x2, point.Y);
				num17 = num16;
				goto IL_0d1a;
			}
			case 38:
				num5 = P_1.High;
				num = 15;
				continue;
			default:
			{
				list5[kFeMHNenSjvcvLKeH57H(list5) - 2] = new Point(num8, list6[list5.Count - 2].Y);
				List<Point> list7 = list5;
				int index = list5.Count - 1;
				double x = num8;
				point = list6[list5.Count - 1];
				list7[index] = new Point(x, point.Y);
				num = 25;
				continue;
			}
			case 42:
				obj = iZPaFAen5hM4eGFLdQkZ(P_1, num5);
				if (obj == null)
				{
					num = 17;
					continue;
				}
				goto IL_0f7a;
			case 16:
				if (FilterMax == 0 || num10 <= FilterMax)
				{
					num7 = Math.Max(num11, num12);
					if (list.Count <= 0)
					{
						list.Add(new Tuple<Rect, XBrush>(new Rect(num2, y, num7, num3), xHKilw0nwx7));
						num = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
						{
							num = 39;
						}
					}
					else
					{
						num = 8;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 != 0)
						{
							num = 28;
						}
					}
					continue;
				}
				goto case 39;
			case 15:
				if (num5 < P_1.Low)
				{
					list6.Add(new Point(num2, num9));
					num = 18;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
					{
						num = 8;
					}
					continue;
				}
				goto case 42;
			case 28:
				item = list[list.Count - 1].Item1;
				num = 25;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
				{
					num = 33;
				}
				continue;
			case 17:
				obj = new RawClusterItem(num5);
				goto IL_0f7a;
			case 26:
				{
					list2.Add(new Tuple<Rect, XBrush>(ExtendMaximum ? new Rect(new Point(num2, y), new Point(base.Canvas.Rect.Right + 1.0, y + num3)) : new Rect(num2, y, num4, num3), yOTilUZNAwi));
					if (ExtendMaximum)
					{
						P_5.Add(new ObjectLabelInfo((double)num5 * num6, MaximumColor));
						num = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
						{
							num = 1;
						}
						continue;
					}
					goto case 1;
				}
				IL_0b65:
				if (!base.DrawBorder)
				{
					num = 29;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
					{
						num = 20;
					}
					continue;
				}
				P_0.DrawLine(base.LinePen, new Point(num2, base.Canvas.Rect.Top), new Point(num2, base.Canvas.Rect.Bottom));
				FJUaTXen1rR8Cmynp3NW(P_0, base.LinePen, new Point(num2 + num4, base.Canvas.Rect.Top), new Point(num2 + num4, base.Canvas.Rect.Bottom));
				num = 12;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num = 0;
				}
				continue;
				IL_0e83:
				num9 = num19;
				num = 24;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
				{
					num = 12;
				}
				continue;
				IL_0d1a:
				if (num8 > num18)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
					{
						num = 0;
					}
					continue;
				}
				goto IL_0e83;
				IL_0f7a:
				rawClusterItem = (IRawClusterItem)obj;
				openPos = rawClusterItem.OpenPos;
				num10 = Math.Abs(ATKVTrenI5u7WX499qdI(rawClusterItem));
				num = 21;
				continue;
			}
			num12 = num20;
			num = 9;
		}
	}

	public override void CopyTemplate(ObjectBase P_0, bool P_1)
	{
		OBBy2BiidVbKyYgaAyQl oBBy2BiidVbKyYgaAyQl = P_0 as OBBy2BiidVbKyYgaAyQl;
		int num;
		if (oBBy2BiidVbKyYgaAyQl != null)
		{
			ProfileType = oBBy2BiidVbKyYgaAyQl.ProfileType;
			ProfileColor = oBBy2BiidVbKyYgaAyQl.ProfileColor;
			num = 4;
			goto IL_0009;
		}
		goto IL_0043;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 10:
				FilterColor = iIQdimenKNYrPMSWtRy7(oBBy2BiidVbKyYgaAyQl);
				num = 6;
				continue;
			case 3:
				ShowValues = oOMMTEenUtIpRa7kvn3D(oBBy2BiidVbKyYgaAyQl);
				MinimizeValues = rs3gc0enTPKvtTRqxt6I(oBBy2BiidVbKyYgaAyQl);
				RoundValues = oBBy2BiidVbKyYgaAyQl.RoundValues;
				num = 11;
				continue;
			case 2:
				FilterMin = oBBy2BiidVbKyYgaAyQl.FilterMin;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
				{
					num = 1;
				}
				continue;
			case 4:
				Profile2Color = oBBy2BiidVbKyYgaAyQl.Profile2Color;
				ExtendProfile = YXNV7eentivHxFBaG1Lq(oBBy2BiidVbKyYgaAyQl);
				AR8ilLndCyw = oBBy2BiidVbKyYgaAyQl.AR8ilLndCyw;
				nNtileWxJmJ = oBBy2BiidVbKyYgaAyQl.nNtileWxJmJ;
				num = 8;
				continue;
			case 9:
				MaximumColor = oBBy2BiidVbKyYgaAyQl.MaximumColor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num = 0;
				}
				continue;
			case 11:
				ValuesColor = oBBy2BiidVbKyYgaAyQl.ValuesColor;
				MaximumType = P9CFceenyBbIHIBU7WDX(oBBy2BiidVbKyYgaAyQl);
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num = 2;
				}
				continue;
			case 1:
				FilterMax = oBBy2BiidVbKyYgaAyQl.FilterMax;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
				{
					num = 10;
				}
				continue;
			default:
			{
				ShowValueArea = HTGcA3enVKTPvZF8kd6i(oBBy2BiidVbKyYgaAyQl);
				ExtendValueArea = VlyraSenCLFa0EweWq4K(oBBy2BiidVbKyYgaAyQl);
				ValueAreaPercent = oBBy2BiidVbKyYgaAyQl.ValueAreaPercent;
				ValueAreaColor = oBBy2BiidVbKyYgaAyQl.ValueAreaColor;
				EnableFilter = ov1bpIenr5DsocyBXfVb(oBBy2BiidVbKyYgaAyQl);
				int num2 = 2;
				num = num2;
				continue;
			}
			case 8:
				ShowCumValue = oBBy2BiidVbKyYgaAyQl.ShowCumValue;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
				{
					num = 3;
				}
				continue;
			case 7:
				return;
			case 5:
				ShowMaximum = j297nbenZWyBovFKcwoa(oBBy2BiidVbKyYgaAyQl);
				ShowMaximumValue = oBBy2BiidVbKyYgaAyQl.ShowMaximumValue;
				ExtendMaximum = oBBy2BiidVbKyYgaAyQl.ExtendMaximum;
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_0043;
		IL_0043:
		base.CopyTemplate(P_0, P_1);
		num = 7;
		goto IL_0009;
	}

	static OBBy2BiidVbKyYgaAyQl()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		uAf6iYenmmsDYbanOaIG();
	}

	internal static bool bkk7qoe9KontehaUNp5m()
	{
		return Pfgo8Qe9roMLkZCvk240 == null;
	}

	internal static OBBy2BiidVbKyYgaAyQl qBRkoge9muM7DCRApxvh()
	{
		return Pfgo8Qe9roMLkZCvk240;
	}

	internal static bool H7mXy1e9hAkC3F82VNKc(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static object jyeQJJe9w4T0Ua5R9w7t(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static int cfvKUte97iqEDd3m8tpO(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static XColor HfoFJCe98R7ndL0jucYq(Color P_0)
	{
		return P_0;
	}

	internal static int pK9Y2Ue9A2XEg0JXGjQd(object P_0, double dt, int dir)
	{
		return ((IChartCanvas)P_0).DateToIndex(dt, dir);
	}

	internal static double x8JRf6e9PcMTrTT1BDTI(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static object d44wtse9JkBYMyh2g1jV(object P_0, int P_1, int P_2, long P_3, long P_4, object P_5)
	{
		return ((VUFmvAiCu8RTynCJ1RYY)P_0).B66irfRoZZd(P_1, P_2, P_3, P_4, (IChartDataProvider)P_5);
	}

	internal static void hK0FBNe9FsR9fJkZH6gn(object P_0)
	{
		((RawCluster)P_0).UpdateData();
	}

	internal static double Df6gL4e93t0TxBWoYgRU(object P_0)
	{
		return ((XFont)P_0).GetHeight();
	}

	internal static long inH9n4e9pqTEI8JcEN6E(object P_0)
	{
		return ((IRawCluster)P_0).Volume;
	}

	internal static int yOKaUEe9u7a1a81KlhfV(object P_0)
	{
		return ((IRawCluster)P_0).Trades;
	}

	internal static object rp7T17e9z6K5vO3eFjW4(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void eYcfIlen0VZrejKHT4DP(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static long NmsHCmen2HgJbjLyuFTx(object P_0)
	{
		return ((IRawCluster)P_0).Bid;
	}

	internal static object jyTvWlenH07goPS8Bom9(object P_0, long size, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatRawSize(size, round, minimize);
	}

	internal static object WHBBnYenfUujW38KEwZK(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static long zB3JBCen9YFnoEkkUBsa(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static long rLlFAqenn1P9bdor6hQ9(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}

	internal static long jbJwrbenGpYPmfH4oDga(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxDelta;
	}

	internal static long XCO1EFenYwrmeeVZWsRF(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MinDelta;
	}

	internal static long cUKRIVeno89LBfmKmHg7(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static long FiDpW6env0hkfwmaiaqD(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static long GBHyfsenB6RQwDBcuSgW(object P_0)
	{
		return ((IRawClusterItem)P_0).Delta;
	}

	internal static long edvO0jenawZsS7myJu8N(object P_0)
	{
		return ((IRawClusterItem)P_0).Bid;
	}

	internal static long RK0n52eniLaph0ZTilQV(object P_0)
	{
		return ((IRawClusterItem)P_0).Ask;
	}

	internal static long KMWZ8renlR9lhg4Sg9Ro(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxAsk;
	}

	internal static object f1msIgen4R9rkCqG1HYi(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static double UaIteBenDLVG6xR37fbI(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double SUSZ0benbJ324eQtLdLp(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double SigO4KenNsnyO51L0fXx(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static Rect Ta9xsnenkYWmvcGCRIfd(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static void FJUaTXen1rR8Cmynp3NW(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static object iZPaFAen5hM4eGFLdQkZ(object P_0, long price)
	{
		return ((IRawCluster)P_0).GetItem(price);
	}

	internal static int kFeMHNenSjvcvLKeH57H(object P_0)
	{
		return ((List<Point>)P_0).Count;
	}

	internal static long FojEBLenxVwwU2wso0bS(object P_0, double filter)
	{
		return ((IChartSymbol)P_0).CorrectSizeFilter(filter);
	}

	internal static int TGWBdVenLo6wPNq4gPfW(object P_0)
	{
		return ((List<Tuple<Rect, XBrush>>)P_0).Count;
	}

	internal static void cG34nNeneKss6Ql9XF5h(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).FillPolygon((XBrush)P_1, (Point[])P_2);
	}

	internal static object ivTJ24ens2cbaF8BEsm9(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static void Xbgm6venXynrKBA6hYGH(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static object tJrscHencvHguJAtgjVr(object P_0)
	{
		return ((IRawCluster)P_0).MaxValues;
	}

	internal static long OvNkEDenjdcWCcsFHbdo(object P_0)
	{
		return ((IRawCluster)P_0).High;
	}

	internal static int aAJnIOenES9YjSyxcjCo(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxTrades;
	}

	internal static long LYQdPTenQN9PK3cLaQuG(object P_0)
	{
		return ((IRawClusterItem)P_0).Price;
	}

	internal static long KThn8DendWh7ylTovf3b(object P_0)
	{
		return ((IRawClusterValueArea)P_0).Val;
	}

	internal static int n8V3JgengXuisAKt5gKs(object P_0)
	{
		return ((IRawClusterItem)P_0).Trades;
	}

	internal static object yhLWYLenRdZXASWO3bZ3(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}

	internal static double xhEbhwen6Smk2Uh43Ai4(object P_0)
	{
		return ((IChartCanvas)P_0).StepHeight;
	}

	internal static object HbjHaXenMEYnw1KXclvN(object P_0)
	{
		return ((XFont)P_0).Name;
	}

	internal static double lMYtBvenOxR6mwAyyrOQ(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static long KuxCcMenqWpowol8KvTJ(object P_0)
	{
		return ((IRawCluster)P_0).Low;
	}

	internal static long ATKVTrenI5u7WX499qdI(object P_0)
	{
		return ((IRawClusterItem)P_0).OpenPos;
	}

	internal static object Hi9dSAenW7bl7Uy0s5Sd(object P_0, long trades, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatTrades(trades, round, minimize);
	}

	internal static bool YXNV7eentivHxFBaG1Lq(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).ExtendProfile;
	}

	internal static bool oOMMTEenUtIpRa7kvn3D(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).ShowValues;
	}

	internal static bool rs3gc0enTPKvtTRqxt6I(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).MinimizeValues;
	}

	internal static VolumeProfileMaximumType P9CFceenyBbIHIBU7WDX(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).MaximumType;
	}

	internal static bool j297nbenZWyBovFKcwoa(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).ShowMaximum;
	}

	internal static bool HTGcA3enVKTPvZF8kd6i(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).ShowValueArea;
	}

	internal static bool VlyraSenCLFa0EweWq4K(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).ExtendValueArea;
	}

	internal static bool ov1bpIenr5DsocyBXfVb(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).EnableFilter;
	}

	internal static XColor iIQdimenKNYrPMSWtRy7(object P_0)
	{
		return ((OBBy2BiidVbKyYgaAyQl)P_0).FilterColor;
	}

	internal static void uAf6iYenmmsDYbanOaIG()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
