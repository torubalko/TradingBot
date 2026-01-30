using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using e6yRlZiVfcDgC6OvTK1x;
using MIGrPZi4v1c8N1FGp0Vb;
using NeyqekiVGOVGZDdQ1cfW;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;

namespace jrYRHxiDKtdglyN9xZQf;

[Indicator("ClusterSearch", "ClusterSearch", true, Type = typeof(lat7lZiDrhWcmRn7e9Li))]
[DataContract(Name = "ClusterSearchIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class lat7lZiDrhWcmRn7e9Li : IndicatorBase, IContainsSelection
{
	private class PoJL52irltaaMpEgr5Kb
	{
		[CompilerGenerated]
		private readonly DateTime F4wir5njSfn;

		[CompilerGenerated]
		private readonly long kvNirSBgasW;

		[CompilerGenerated]
		private readonly long tUNirxOOmE0;

		[CompilerGenerated]
		private readonly long tPoirLM4KlZ;

		private static PoJL52irltaaMpEgr5Kb AqvQAOet7gamMKa0Jpii;

		public DateTime Time
		{
			[CompilerGenerated]
			get
			{
				return F4wir5njSfn;
			}
		}

		public long Value
		{
			[CompilerGenerated]
			get
			{
				return tPoirLM4KlZ;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public long p4KirDHCbqB()
		{
			return kvNirSBgasW;
		}

		[SpecialName]
		[CompilerGenerated]
		public long IJYirNnJOtH()
		{
			return tUNirxOOmE0;
		}

		public PoJL52irltaaMpEgr5Kb(DateTime P_0, long P_1, long P_2, long P_3)
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
			F4wir5njSfn = P_0;
			kvNirSBgasW = P_1;
			tUNirxOOmE0 = P_2;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
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
				tPoirLM4KlZ = P_3;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 0;
				}
			}
		}

		static PoJL52irltaaMpEgr5Kb()
		{
			bp7rAGetPf0E0BTafd2U();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool o9bMUEet8b5xOw586DRS()
		{
			return AqvQAOet7gamMKa0Jpii == null;
		}

		internal static PoJL52irltaaMpEgr5Kb qufUeqetAMfZufQYkvnG()
		{
			return AqvQAOet7gamMKa0Jpii;
		}

		internal static void bp7rAGetPf0E0BTafd2U()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}
	}

	private class FyOrgmirefUZS2hBIWHp
	{
		private Rect TvEircplumY;

		private readonly PoJL52irltaaMpEgr5Kb PluirjkvLi7;

		private static FyOrgmirefUZS2hBIWHp b2jLxOetJOqNr1D5bLpB;

		public FyOrgmirefUZS2hBIWHp(Rect P_0, PoJL52irltaaMpEgr5Kb P_1)
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
			TvEircplumY = P_0;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			PluirjkvLi7 = P_1;
		}

		public bool wcfirsaxBCc(Point P_0)
		{
			return TvEircplumY.Contains(P_0);
		}

		public string RAxirXT7Q88(ClusterSearchDataType P_0, IChartDataProvider P_1, string P_2)
		{
			int num = 1;
			int num2 = num;
			string text3 = default(string);
			string text = default(string);
			string text2 = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					text3 = (string)((P_0 == ClusterSearchDataType.Trades) ? inZJpRetz40hO0LVt4sh(P_1.Symbol, PluirjkvLi7.Value) : ((IChartSymbol)gdEOqaetpm4vcxSkBjBO(P_1)).FormatRawSizeShort(TnyO4HetuKDINgja1OBM(PluirjkvLi7)));
					text = ((IChartSymbol)gdEOqaetpm4vcxSkBjBO(P_1)).FormatTime(FPHhGUeU0vHfoprt1WHc(PluirjkvLi7), (string)tkTuAgeU2L2T75X6oTwF(-176525661 ^ -176504639));
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					text2 = P_1.Symbol.FormatRawPrice((PluirjkvLi7.p4KirDHCbqB() + PluirjkvLi7.IJYirNnJOtH()) / 2, shortDecimals: true);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return P_2 + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x42976D9D) + text + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B52AA4) + text2 + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306914860) + text3;
				}
			}
		}

		static FyOrgmirefUZS2hBIWHp()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool lGi3uxetFd2L9hamsqXQ()
		{
			return b2jLxOetJOqNr1D5bLpB == null;
		}

		internal static FyOrgmirefUZS2hBIWHp QwD1Qhet36FpjcjyEbeb()
		{
			return b2jLxOetJOqNr1D5bLpB;
		}

		internal static object gdEOqaetpm4vcxSkBjBO(object P_0)
		{
			return ((IChartDataProvider)P_0).Symbol;
		}

		internal static long TnyO4HetuKDINgja1OBM(object P_0)
		{
			return ((PoJL52irltaaMpEgr5Kb)P_0).Value;
		}

		internal static object inZJpRetz40hO0LVt4sh(object P_0, long trades)
		{
			return ((IChartSymbol)P_0).FormatTrades(trades);
		}

		internal static DateTime FPHhGUeU0vHfoprt1WHc(object P_0)
		{
			return ((PoJL52irltaaMpEgr5Kb)P_0).Time;
		}

		internal static object tkTuAgeU2L2T75X6oTwF(int P_0)
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
		}
	}

	private class F899SFirEst4trTRSkCM
	{
		[CompilerGenerated]
		private readonly List<PoJL52irltaaMpEgr5Kb> MYKirtwjTni;

		[CompilerGenerated]
		private readonly HashSet<long> b70irUCiv9b;

		[CompilerGenerated]
		private readonly HashSet<long> HQiirTeNnWe;

		[CompilerGenerated]
		private long jbfiryjPOXj;

		private readonly HashSet<long> F0RirZFVtTY;

		private static F899SFirEst4trTRSkCM s9X1PoeUHwvmurLiRsQ0;

		public List<PoJL52irltaaMpEgr5Kb> Items
		{
			[CompilerGenerated]
			get
			{
				return MYKirtwjTni;
			}
		}

		public HashSet<long> SingleSelection
		{
			[CompilerGenerated]
			get
			{
				return HQiirTeNnWe;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public HashSet<long> npxir6HeAeG()
		{
			return b70irUCiv9b;
		}

		[SpecialName]
		[CompilerGenerated]
		public long nXoirqyYuvL()
		{
			return jbfiryjPOXj;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A26irIWNREJ(long P_0)
		{
			jbfiryjPOXj = P_0;
		}

		public F899SFirEst4trTRSkCM()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
			MYKirtwjTni = new List<PoJL52irltaaMpEgr5Kb>();
			b70irUCiv9b = new HashSet<long>();
			HQiirTeNnWe = new HashSet<long>();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
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
				F0RirZFVtTY = new HashSet<long>();
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
				{
					num = 0;
				}
			}
		}

		public void eVuirQSaUOG(PoJL52irltaaMpEgr5Kb P_0)
		{
			Items.Add(P_0);
		}

		public bool mMJirdsEY6M(long P_0)
		{
			if (F0RirZFVtTY.Contains(P_0))
			{
				return false;
			}
			F0RirZFVtTY.Add(P_0);
			return true;
		}

		public void Clear()
		{
			mfAVW8eUnO7GZVfC7OK8(Items);
			npxir6HeAeG().Clear();
			SingleSelection.Clear();
			A26irIWNREJ(0L);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public void FL9irgSNI6P()
		{
			int num = 2;
			long num5 = default(long);
			PoJL52irltaaMpEgr5Kb poJL52irltaaMpEgr5Kb = default(PoJL52irltaaMpEgr5Kb);
			long num4 = default(long);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (num5 > poJL52irltaaMpEgr5Kb.p4KirDHCbqB())
						{
							num2 = 4;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						if (!SingleSelection.Contains(num5))
						{
							SingleSelection.Add(num5);
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 2:
						poJL52irltaaMpEgr5Kb = null;
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
					{
						using (List<PoJL52irltaaMpEgr5Kb>.Enumerator enumerator = Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								while (true)
								{
									IL_01d3:
									PoJL52irltaaMpEgr5Kb current = enumerator.Current;
									int num3;
									if (poJL52irltaaMpEgr5Kb == null || poJL52irltaaMpEgr5Kb.Value < current.Value)
									{
										poJL52irltaaMpEgr5Kb = current;
										num3 = 3;
										goto IL_0125;
									}
									goto IL_0205;
									IL_0205:
									num4 = current.IJYirNnJOtH();
									num3 = 2;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
									{
										num3 = 0;
									}
									goto IL_0125;
									IL_0125:
									while (true)
									{
										switch (num3)
										{
										case 2:
											if (num4 > current.p4KirDHCbqB())
											{
												num3 = 0;
												if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
												{
													num3 = 0;
												}
												continue;
											}
											if (!npxir6HeAeG().Contains(num4))
											{
												num3 = 1;
												if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
												{
													num3 = 0;
												}
												continue;
											}
											goto IL_01f9;
										case 1:
											npxir6HeAeG().Add(num4);
											goto IL_01f9;
										case 4:
											goto IL_01d3;
										case 3:
											goto IL_0205;
											IL_01f9:
											num4++;
											goto case 2;
										}
										break;
									}
									break;
								}
							}
						}
						if (poJL52irltaaMpEgr5Kb == null)
						{
							return;
						}
						num5 = poJL52irltaaMpEgr5Kb.IJYirNnJOtH();
						goto case 3;
					}
					case 4:
						return;
					}
					break;
				}
				num5++;
				num = 3;
			}
		}

		static F899SFirEst4trTRSkCM()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			q6eWTPeUGdxCph1aDeDa();
		}

		internal static bool N9jkWseUfbq4M6FFLhCJ()
		{
			return s9X1PoeUHwvmurLiRsQ0 == null;
		}

		internal static F899SFirEst4trTRSkCM lRsNeReU9wFoPVBcoUCi()
		{
			return s9X1PoeUHwvmurLiRsQ0;
		}

		internal static void mfAVW8eUnO7GZVfC7OK8(object P_0)
		{
			((List<PoJL52irltaaMpEgr5Kb>)P_0).Clear();
		}

		internal static void q6eWTPeUGdxCph1aDeDa()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private ClusterSearchDataType LSsibAAxj5X;

	private CyB7CCiVHu1Q2FbDrIXm Fy0ibPmTHMY;

	private bcRhS6iVnsrvu2TG1BEB mYwibJZekoJ;

	private ChartAlertSettings QsnibF3k9fV;

	private XBrush L0lib3d01yp;

	private XColor TYaibpIR8DB;

	private XBrush Dudibu4PsIO;

	private XColor NWSibzNl53Z;

	private XBrush YidiN0canNO;

	private XPen lmriN2aA8h9;

	private XColor k1UiNH1A34l;

	private ClusterSearchObjectType RFhiNfvRMLV;

	private int R7LiN9QlWfU;

	private int jjyiNnZTe4U;

	private int NnZiNGefwjN;

	private int yvRiNY7FSCX;

	private ClusterSearchPriceRangeDirection ikWiNoBgMVA;

	private IndicatorNullIntParam HmwiNvDQZwG;

	private int? x2ZiNBHSYln;

	private int? iNMiNaL3U7W;

	private int? TMaiNiUqhK2;

	private int? KwRiNlU3pMT;

	private int? DPCiN4Vf3Za;

	private int? TZDiNDIVUYm;

	private ClusterSearchBarDirection la7iNbZ59sR;

	private ClusterSearchPriceLocation w3ciNN15Ufk;

	private bool WDxiNkFXTjX;

	private bool jJEiN1kWQLr;

	private TimeSpan dAAiN5p5kN6;

	private TimeSpan r48iNSgYEq0;

	private long vUpiNxdZK7d;

	private long DIwiNLodYID;

	private int h1biNeXFdo4;

	private Dictionary<int, F899SFirEst4trTRSkCM> ibDiNsaLpso;

	private List<FyOrgmirefUZS2hBIWHp> aXSiNX62UNB;

	internal static lat7lZiDrhWcmRn7e9Li QEEpUTe4KCf4LYSApqfo;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Cluster;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Type")]
	[DefaultValue(ClusterSearchDataType.Volume)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsType")]
	public ClusterSearchDataType Type
	{
		get
		{
			return LSsibAAxj5X;
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
					OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(0x50C1C840 ^ 0x50C15964));
					return;
				case 1:
					return;
				case 2:
					if (clusterSearchDataType != LSsibAAxj5X)
					{
						LSsibAAxj5X = clusterSearchDataType;
						Clear();
						OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(-203064540 ^ -203036100));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
						{
							num2 = 1;
						}
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "MinimumParam")]
	public CyB7CCiVHu1Q2FbDrIXm O0HiDFAFOCE
	{
		get
		{
			return Fy0ibPmTHMY ?? (Fy0ibPmTHMY = new CyB7CCiVHu1Q2FbDrIXm(1000L));
		}
		set
		{
			Fy0ibPmTHMY = fy0ibPmTHMY;
		}
	}

	[DefaultValue(1000)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	public long Minimum
	{
		get
		{
			return O0HiDFAFOCE.Get(base.SettingsLongKey);
		}
		set
		{
			if (O0HiDFAFOCE.dUNiV9IB4Ic(base.SettingsLongKey, num, 0L))
			{
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x78D396D8 ^ 0x78D307EA));
				OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(-3429745 ^ -3458133));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				case 0:
					break;
				case 1:
					break;
				}
			}
		}
	}

	[DataMember(Name = "MaximumParam")]
	public bcRhS6iVnsrvu2TG1BEB Qacib01csfP
	{
		get
		{
			return mYwibJZekoJ ?? (mYwibJZekoJ = new bcRhS6iVnsrvu2TG1BEB(null));
		}
		set
		{
			mYwibJZekoJ = bcRhS6iVnsrvu2TG1BEB;
		}
	}

	[DefaultValue(null)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public long? Maximum
	{
		get
		{
			return Qacib01csfP.Get(base.SettingsLongKey);
		}
		set
		{
			if (Qacib01csfP.aWyiVYE1DZj(base.SettingsLongKey, num, 0L))
			{
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24B0B9E6 ^ 0x24B028A2));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x404ED0BE ^ 0x404E419A));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Alert")]
	[Browsable(true)]
	public ChartAlertSettings Alert
	{
		get
		{
			return QsnibF3k9fV ?? (QsnibF3k9fV = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(chartAlertSettings, QsnibF3k9fV))
			{
				QsnibF3k9fV = chartAlertSettings;
				OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(0x5EA8FF2A ^ 0x5EA882AC));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSelectionColor")]
	[DataMember(Name = "SelectionColor")]
	public XColor SelectionColor
	{
		get
		{
			return TYaibpIR8DB;
		}
		set
		{
			if (!(xColor == TYaibpIR8DB))
			{
				TYaibpIR8DB = xColor;
				L0lib3d01yp = new XBrush(TYaibpIR8DB);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1087080834 ^ -1087052178));
			}
		}
	}

	[DataMember(Name = "ObjectColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsObjectBackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor ObjectBackColor
	{
		get
		{
			return NWSibzNl53Z;
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
					OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(-53782092 ^ -53753630));
					return;
				case 2:
					if (!M7aj7We47FcyuLOSJtZE(xColor, NWSibzNl53Z))
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 1:
					NWSibzNl53Z = xColor;
					Dudibu4PsIO = new XBrush(NWSibzNl53Z);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsObjectBorderColor")]
	[DataMember(Name = "ObjectBorderColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor ObjectBorderColor
	{
		get
		{
			return k1UiNH1A34l;
		}
		set
		{
			if (M7aj7We47FcyuLOSJtZE(xColor, k1UiNH1A34l))
			{
				return;
			}
			k1UiNH1A34l = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
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
				YidiN0canNO = new XBrush(k1UiNH1A34l);
				lmriN2aA8h9 = new XPen(YidiN0canNO, 1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108490012));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsObjectType")]
	[DataMember(Name = "ObjectType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public ClusterSearchObjectType ObjectType
	{
		get
		{
			return RFhiNfvRMLV;
		}
		set
		{
			if (clusterSearchObjectType != RFhiNfvRMLV)
			{
				RFhiNfvRMLV = clusterSearchObjectType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFD262));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinSize")]
	[DataMember(Name = "ObjectMinSize")]
	public int ObjectMinSize
	{
		get
		{
			return R7LiN9QlWfU;
		}
		set
		{
			num = Math.Max(10, Math.Min(num, 200));
			if (num == R7LiN9QlWfU)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
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
				R7LiN9QlWfU = num;
				OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(0x1AB79299 ^ 0x1AB7032F));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxSize")]
	[DataMember(Name = "ObjectMaxSize")]
	public int ObjectMaxSize
	{
		get
		{
			return jjyiNnZTe4U;
		}
		set
		{
			num = Math.Min(200, Math.Max(num, 10));
			if (num == jjyiNnZTe4U)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
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
				jjyiNnZTe4U = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3D46F));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBarsRange")]
	[DefaultValue(1)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DataMember(Name = "BarsRange")]
	public int BarsRange
	{
		get
		{
			return NnZiNGefwjN;
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
					return;
				case 0:
					return;
				case 1:
					if (num3 != NnZiNGefwjN)
					{
						NnZiNGefwjN = num3;
						Clear();
						OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(0x7D553BE0 ^ 0x7D55AA12));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPriceRange")]
	[DataMember(Name = "PriceRange")]
	[DefaultValue(1)]
	public int PriceRange
	{
		get
		{
			return yvRiNY7FSCX;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == yvRiNY7FSCX)
			{
				return;
			}
			yvRiNY7FSCX = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309585046));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DefaultValue(ClusterSearchPriceRangeDirection.All)]
	[DataMember(Name = "PriceRangeDir")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPriceRangeDir")]
	public ClusterSearchPriceRangeDirection PriceRangeDir
	{
		get
		{
			return ikWiNoBgMVA;
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
					if (clusterSearchPriceRangeDirection == ikWiNoBgMVA)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
						{
							num2 = 0;
						}
						break;
					}
					ikWiNoBgMVA = clusterSearchPriceRangeDirection;
					Clear();
					OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(-527080372 ^ -527042964));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "MinValueParam")]
	public IndicatorNullIntParam pQfibsQ5fIK
	{
		get
		{
			return HmwiNvDQZwG ?? (HmwiNvDQZwG = new IndicatorNullIntParam());
		}
		set
		{
			HmwiNvDQZwG = hmwiNvDQZwG;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinValue")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DefaultValue(null)]
	public int? MinValue
	{
		get
		{
			return pQfibsQ5fIK.Get(base.SettingsLongKey);
		}
		set
		{
			if (pQfibsQ5fIK.Set(base.SettingsLongKey, value2, 0))
			{
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1848952786 ^ -1848923632));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinDelta")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DefaultValue(null)]
	[DataMember(Name = "MinDelta")]
	public int? MinDelta
	{
		get
		{
			return x2ZiNBHSYln;
		}
		set
		{
			if (num != x2ZiNBHSYln)
			{
				x2ZiNBHSYln = num;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x42D899B5 ^ 0x42D80BE7));
			}
		}
	}

	[DefaultValue(null)]
	[DataMember(Name = "BidAskImbalance")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBidAskImbalance")]
	public int? BidAskImbalance
	{
		get
		{
			return iNMiNaL3U7W;
		}
		set
		{
			if (num != iNMiNaL3U7W)
			{
				iNMiNaL3U7W = num;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309585148));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsRangeFromHigh")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DefaultValue(null)]
	[DataMember(Name = "RangeFromHigh")]
	public int? RangeFromHigh
	{
		get
		{
			return TMaiNiUqhK2;
		}
		set
		{
			if (num.HasValue && num.Value < 1 && TMaiNiUqhK2.HasValue)
			{
				num = null;
			}
			else if (num.HasValue && num.Value < 1 && !TMaiNiUqhK2.HasValue)
			{
				num = 1;
			}
			if (num != TMaiNiUqhK2)
			{
				TMaiNiUqhK2 = num;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325263045));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DefaultValue(null)]
	[DataMember(Name = "RangeFromLow")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsRangeFromLow")]
	public int? RangeFromLow
	{
		get
		{
			return KwRiNlU3pMT;
		}
		set
		{
			if (num.HasValue && num.Value < 0)
			{
				num = null;
			}
			if (num != KwRiNlU3pMT)
			{
				KwRiNlU3pMT = num;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4662F6AF ^ 0x46626409));
			}
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinAvgTrade")]
	[DataMember(Name = "MinAvgTrade")]
	public int? MinAvgTrade
	{
		get
		{
			return DPCiN4Vf3Za;
		}
		set
		{
			if (num.HasValue && num.Value < 0)
			{
				num = null;
			}
			if (num != DPCiN4Vf3Za)
			{
				DPCiN4Vf3Za = num;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-520155535 ^ -520119117));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxAvgTrade")]
	[DefaultValue(null)]
	[DataMember(Name = "MaxAvgTrade")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	public int? MaxAvgTrade
	{
		get
		{
			return TZDiNDIVUYm;
		}
		set
		{
			if (num.HasValue && num.Value < 0)
			{
				num = null;
			}
			if (num != TZDiNDIVUYm)
			{
				TZDiNDIVUYm = num;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774638377));
			}
		}
	}

	[DataMember(Name = "BarDirection")]
	[DefaultValue(ClusterSearchBarDirection.Any)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBarDirection")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	public ClusterSearchBarDirection BarDirection
	{
		get
		{
			return la7iNbZ59sR;
		}
		set
		{
			if (clusterSearchBarDirection != la7iNbZ59sR)
			{
				la7iNbZ59sR = clusterSearchBarDirection;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6E2DFBED ^ 0x6E2D691B));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPriceLocation")]
	[DefaultValue(ClusterSearchPriceLocation.Any)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[DataMember(Name = "PriceLocation")]
	public ClusterSearchPriceLocation PriceLocation
	{
		get
		{
			return w3ciNN15Ufk;
		}
		set
		{
			if (clusterSearchPriceLocation != w3ciNN15Ufk)
			{
				w3ciNN15Ufk = clusterSearchPriceLocation;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Clear();
				OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(-1309555870 ^ -1309585296));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSingleSelection")]
	[DataMember(Name = "SingleSelection")]
	[DefaultValue(false)]
	public bool SingleSelection
	{
		get
		{
			return WDxiNkFXTjX;
		}
		set
		{
			if (flag != WDxiNkFXTjX)
			{
				WDxiNkFXTjX = flag;
				Clear();
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306905960));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsUseTimeFilter")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsTimeFilter")]
	[DataMember(Name = "UseTimeFilter")]
	public bool UseTimeFilter
	{
		get
		{
			return jJEiN1kWQLr;
		}
		set
		{
			if (flag != jJEiN1kWQLr)
			{
				jJEiN1kWQLr = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--737722733 ^ 0x2BF8523F));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStartTime")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsTimeFilter")]
	[DataMember(Name = "StartTime")]
	public TimeSpan StartTime
	{
		get
		{
			return dAAiN5p5kN6;
		}
		set
		{
			if (!(timeSpan == dAAiN5p5kN6))
			{
				dAAiN5p5kN6 = timeSpan;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309585390));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsTimeFilter")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsEndTime")]
	[DataMember(Name = "EndTime")]
	public TimeSpan EndTime
	{
		get
		{
			return r48iNSgYEq0;
		}
		set
		{
			if (!QrM3X2e48fkBAOhMuMJN(timeSpan, r48iNSgYEq0))
			{
				r48iNSgYEq0 = timeSpan;
				Clear();
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)iKquiRe4wOyI6W76lobA(0x315AB1E3 ^ 0x315A2265));
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
	private Dictionary<int, F899SFirEst4trTRSkCM> edaib7wycwg()
	{
		return ibDiNsaLpso ?? (ibDiNsaLpso = new Dictionary<int, F899SFirEst4trTRSkCM>());
	}

	public lat7lZiDrhWcmRn7e9Li()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
		{
			num = 7;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				PriceLocation = ClusterSearchPriceLocation.Any;
				SingleSelection = false;
				UseTimeFilter = false;
				StartTime = TimeSpan.Zero;
				EndTime = TimeSpan.Zero;
				return;
			case 9:
				MaxAvgTrade = null;
				MinAvgTrade = null;
				BarDirection = ClusterSearchBarDirection.Any;
				num = 6;
				break;
			case 4:
				PriceRange = 1;
				PriceRangeDir = ClusterSearchPriceRangeDirection.All;
				MinDelta = null;
				BidAskImbalance = null;
				RangeFromHigh = null;
				RangeFromLow = null;
				num = 9;
				break;
			case 5:
				ObjectMaxSize = 80;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
				{
					num = 0;
				}
				break;
			case 7:
				Type = ClusterSearchDataType.Volume;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num = 0;
				}
				break;
			case 2:
			{
				SelectionColor = wSF0WBe4Aer4hHPYO0GH(byte.MaxValue, 178, 34, 34);
				ObjectBackColor = Color.FromArgb(127, 30, 144, byte.MaxValue);
				int num2 = 8;
				num = num2;
				break;
			}
			case 1:
				ObjectMinSize = 20;
				num = 5;
				break;
			case 8:
				ObjectBorderColor = eVwkh7e4P6p1HXicZx45(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
				{
					num = 0;
				}
				break;
			default:
				ObjectType = ClusterSearchObjectType.Diamond;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd != 0)
				{
					num = 1;
				}
				break;
			case 3:
				BarsRange = 1;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	private void Clear()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				vUpiNxdZK7d = 0L;
				h1biNeXFdo4 = 0;
				OLl8aWe4Js6ckJYHbQrs(edaib7wycwg());
				return;
			case 1:
				DIwiNLodYID = 0L;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private bool Gr0iDmKvwFx(IRawCluster P_0, IRawClusterItem P_1, long? P_2, ref long P_3, ref long P_4, ref long P_5)
	{
		long num = 0L;
		switch (Type)
		{
		case ClusterSearchDataType.Volume:
			num = P_1.Volume;
			break;
		case ClusterSearchDataType.Trades:
			num = P_1.Trades;
			break;
		case ClusterSearchDataType.Bid:
			num = P_1.Bid;
			break;
		case ClusterSearchDataType.Ask:
			num = P_1.Ask;
			break;
		case ClusterSearchDataType.Delta:
		case ClusterSearchDataType.DeltaPlus:
		case ClusterSearchDataType.DeltaMinus:
			num = P_1.Delta;
			break;
		case ClusterSearchDataType.MaxVol:
		{
			IRawClusterMaxValues maxValues = P_0.MaxValues;
			num = ((P_1.Price == maxValues.Poc) ? maxValues.MaxVolume : 0);
			break;
		}
		}
		if (P_2.HasValue && P_2.Value > Math.Abs(num))
		{
			return false;
		}
		P_3 += num;
		P_4 += P_1.Bid;
		P_5 += P_1.Ask;
		return true;
	}

	private bool uIiiDhWpYhd(long P_0, long P_1, long? P_2)
	{
		switch (Type)
		{
		case ClusterSearchDataType.DeltaPlus:
			if (P_0 < 0)
			{
				return false;
			}
			break;
		case ClusterSearchDataType.DeltaMinus:
			if (P_0 > 0)
			{
				return false;
			}
			break;
		}
		if (Math.Abs(P_0) < P_1)
		{
			return false;
		}
		if (P_2.HasValue && Math.Abs(P_0) > P_2.Value)
		{
			return false;
		}
		return true;
	}

	protected override void Execute()
	{
		int num = 6;
		ClusterSearchBarDirection clusterSearchBarDirection = default(ClusterSearchBarDirection);
		F899SFirEst4trTRSkCM f899SFirEst4trTRSkCM = default(F899SFirEst4trTRSkCM);
		int num5 = default(int);
		IRawCluster rawCluster = default(IRawCluster);
		DateTime dateTime = default(DateTime);
		long num9 = default(long);
		IChartSymbol chartSymbol2 = default(IChartSymbol);
		long? num10 = default(long?);
		int? num3 = default(int?);
		long? num6 = default(long?);
		int? num7 = default(int?);
		long? num8 = default(long?);
		long? num4 = default(long?);
		long? num11 = default(long?);
		long num20 = default(long);
		bool flag = default(bool);
		long num15 = default(long);
		long num16 = default(long);
		long num17 = default(long);
		bool flag2 = default(bool);
		long val = default(long);
		IRawCluster rawCluster2 = default(IRawCluster);
		double num26 = default(double);
		bool flag5 = default(bool);
		double num22 = default(double);
		bool flag3 = default(bool);
		SortedSet<long>.Enumerator enumerator2 = default(SortedSet<long>.Enumerator);
		IRawCluster rawCluster3 = default(IRawCluster);
		long num32 = default(long);
		int num18 = default(int);
		int num31 = default(int);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		long num24 = default(long);
		double num25 = default(double);
		long num23 = default(long);
		bool flag4 = default(bool);
		long val2 = default(long);
		long num14 = default(long);
		long num29 = default(long);
		long num27 = default(long);
		long num28 = default(long);
		ClusterSearchPriceLocation clusterSearchPriceLocation = default(ClusterSearchPriceLocation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long? obj;
				IEnumerator<IRawClusterItem> enumerator;
				switch (num2)
				{
				case 5:
					Clear();
					num2 = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num2 = 10;
					}
					continue;
				case 6:
					if (base.ClearData)
					{
						num2 = 5;
						continue;
					}
					goto case 10;
				case 9:
					obj = null;
					goto IL_1434;
				case 21:
					if (clusterSearchBarDirection == ClusterSearchBarDirection.Down)
					{
						goto case 16;
					}
					goto IL_130e;
				case 22:
					f899SFirEst4trTRSkCM.FL9irgSNI6P();
					num2 = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
					{
						num2 = 2;
					}
					continue;
				case 23:
					if (!edaib7wycwg().ContainsKey(num5))
					{
						edaib7wycwg().Add(num5, new F899SFirEst4trTRSkCM());
						num2 = 20;
						continue;
					}
					goto case 20;
				case 18:
				case 19:
					if (num5 < EhrLWEeDaAuiP4xPQB3d(base.DataProvider))
					{
						rawCluster = base.DataProvider.GetRawCluster(num5);
						num2 = 23;
						continue;
					}
					h1biNeXFdo4 = Math.Max(EhrLWEeDaAuiP4xPQB3d(base.DataProvider) - 2, 0);
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					if (jdreVIe4uAZE2jU2TBcO(dateTime, Spghgve4z7ZBLxBZyTSJ(rawCluster).Date.Add(StartTime)) && dateTime > rawCluster.OpenTime.Date.Add(EndTime))
					{
						goto case 12;
					}
					goto IL_03a0;
				case 3:
					if (!w72Cphe4pQptNVtmyKgY(StartTime, EndTime))
					{
						goto case 11;
					}
					if (jdreVIe4uAZE2jU2TBcO(dateTime, rawCluster.OpenTime.Date.Add(StartTime)) || dateTime > rawCluster.OpenTime.Date.Add(EndTime))
					{
						goto case 12;
					}
					goto IL_03a0;
				case 20:
					f899SFirEst4trTRSkCM = edaib7wycwg()[num5];
					num2 = 14;
					continue;
				case 1:
					num9 = ((Type == ClusterSearchDataType.Trades) ? Minimum : uQSLDTe43E4OIojMpduv(chartSymbol2, Minimum));
					num10 = ((Type == ClusterSearchDataType.Trades) ? Maximum : chartSymbol2.CorrectSizeFilter(Maximum));
					num2 = 15;
					continue;
				case 14:
					if (f899SFirEst4trTRSkCM.nXoirqyYuvL() != rawCluster.Items.Count)
					{
						f899SFirEst4trTRSkCM.Clear();
						f899SFirEst4trTRSkCM.A26irIWNREJ(rawCluster.Items.Count);
						num2 = 4;
						continue;
					}
					goto case 12;
				case 4:
					if (UseTimeFilter)
					{
						dateTime = chartSymbol2.ConvertTimeToLocal(rawCluster.OpenTime);
						num = 3;
						break;
					}
					goto IL_03a0;
				case 12:
					num5++;
					num2 = 18;
					continue;
				case 10:
					chartSymbol2 = (IChartSymbol)hRuOr1e4FKA6DjuaynBH(base.DataProvider);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (hiK0OZeD0ond3Xvk9ShC(rawCluster) < rawCluster.Close)
					{
						goto case 12;
					}
					goto IL_130e;
				case 8:
					return;
				case 17:
					num5 = h1biNeXFdo4;
					num = 19;
					break;
				case 7:
					if (rawCluster.Open > rawCluster.Close)
					{
						goto case 12;
					}
					goto IL_130e;
				case 15:
					if (Type == ClusterSearchDataType.Trades)
					{
						num3 = MinValue;
						if (!num3.HasValue)
						{
							num2 = 3;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
							{
								num2 = 9;
							}
							continue;
						}
						obj = num3.GetValueOrDefault();
						goto IL_1434;
					}
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
					{
						num2 = 8;
					}
					continue;
				case 13:
				{
					IChartSymbol chartSymbol4 = chartSymbol2;
					num3 = MinValue;
					obj = chartSymbol4.CorrectSizeFilter(num3);
					goto IL_1434;
				}
				case 2:
				{
					num6 = chartSymbol2.CorrectSizeFilter(MinDelta);
					num7 = BidAskImbalance;
					IChartSymbol chartSymbol3 = chartSymbol2;
					num3 = MaxAvgTrade;
					num8 = chartSymbol3.CorrectSizeFilter(num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				default:
					{
						IChartSymbol chartSymbol = chartSymbol2;
						num3 = MinAvgTrade;
						num4 = chartSymbol.CorrectSizeFilter(num3);
						num = 17;
						break;
					}
					IL_1434:
					num11 = obj;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c != 0)
					{
						num2 = 2;
					}
					continue;
					IL_130e:
					enumerator = rawCluster.Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								IRawClusterItem current = enumerator.Current;
								long num12 = dgkmi9eD2mk6LPwH0GM6(current);
								int num13 = 10;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
								{
									num13 = 10;
								}
								while (true)
								{
									int num19;
									switch (num13)
									{
									case 41:
										if (uIiiDhWpYhd(num20, num9, num10))
										{
											goto IL_0a64;
										}
										goto IL_10fe;
									case 65:
										flag = true;
										num15 = 0L;
										num16 = 0L;
										num17 = 0L;
										flag2 = false;
										val = num12;
										num13 = 33;
										continue;
									case 24:
										if (rawCluster2 != null)
										{
											num13 = 14;
											continue;
										}
										goto case 47;
									case 2:
										num26 = (double)DnO4PMeD9MUMpSwJ1Nho(current) / (double)current.Trades;
										if (num4.HasValue)
										{
											num13 = 58;
											continue;
										}
										goto IL_0fcd;
									case 25:
										if (flag5 && num7.HasValue)
										{
											num22 = (double)num7.Value / 100.0;
											flag3 = true;
											num13 = 44;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
											{
												num13 = 11;
											}
											continue;
										}
										goto case 56;
									case 16:
										if (num3.HasValue)
										{
											long num21 = dgkmi9eD2mk6LPwH0GM6(current);
											long low = rawCluster.Low;
											num3 = RangeFromLow;
											if (num21 <= low + num3.Value)
											{
												num13 = 2;
												if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
												{
													num13 = 2;
												}
												continue;
											}
											goto end_IL_0624;
										}
										goto case 2;
									case 12:
									{
										long upperValue = num12 + PriceRange - 1;
										enumerator2 = rawCluster3.Prices.GetViewBetween(num12, upperValue).GetEnumerator();
										num19 = 8;
										goto IL_03da;
									}
									case 21:
										if (num32 >= num6.Value)
										{
											goto IL_0b66;
										}
										goto case 19;
									case 20:
										if (flag3)
										{
											num13 = 30;
											continue;
										}
										goto case 56;
									case 38:
										if (num12 >= Math.Min(rawCluster.Open, lYidw7eDHi8B8UWnCmJM(rawCluster)))
										{
											goto end_IL_0624;
										}
										goto IL_10f1;
									case 60:
										break;
									case 63:
										num18 = num5 - BarsRange + 1;
										goto IL_0ee6;
									case 66:
										goto IL_0737;
									case 61:
										if (num31 > num5)
										{
											num13 = 64;
											continue;
										}
										goto case 46;
									case 29:
										goto IL_07b3;
									case 18:
										if (flag7)
										{
											flag = false;
										}
										goto IL_09ae;
									case 43:
										flag6 = true;
										goto IL_0604;
									case 11:
										num24 = 0L;
										num13 = 0;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
										{
											num13 = 0;
										}
										continue;
									case 36:
										if (num25 > 0.0)
										{
											num13 = 52;
											continue;
										}
										goto IL_0994;
									case 34:
										Hl5iDwPDicJ(num11, rawCluster, ref num15, ref num16, ref num17, ref flag2, ref val, rawCluster3, num12);
										goto IL_0be3;
									case 50:
										flag7 = false;
										goto case 18;
									case 31:
										if (rawCluster3 != null)
										{
											if (PriceRange == 1)
											{
												num13 = 34;
												if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
												{
													num13 = 1;
												}
												continue;
											}
											goto case 12;
										}
										goto IL_0be3;
									case 57:
										goto IL_095c;
									case 64:
										if (!flag2 || !uIiiDhWpYhd(num15, num9, num10))
										{
											flag = false;
										}
										if (flag)
										{
											num13 = 39;
											continue;
										}
										goto case 35;
									case 55:
										flag5 = true;
										num13 = 17;
										continue;
									case 48:
										if (PriceRangeDir != ClusterSearchPriceRangeDirection.Upward)
										{
											num13 = 33;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
											{
												num13 = 42;
											}
											continue;
										}
										goto case 65;
									default:
										num23 = 0L;
										num13 = 23;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
										{
											num13 = 27;
										}
										continue;
									case 14:
									{
										if (PriceRange == 1)
										{
											num13 = 49;
											continue;
										}
										long lowerValue = num12 - PriceRange + 1;
										enumerator2 = rawCluster2.Prices.GetViewBetween(lowerValue, num12).GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												long current3 = enumerator2.Current;
												Hl5iDwPDicJ(num11, rawCluster, ref num20, ref num24, ref num23, ref flag4, ref val2, rawCluster2, current3);
												int num34 = 0;
												if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
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
											((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
										}
										goto case 47;
									}
									case 46:
										rawCluster3 = (IRawCluster)Q2LL9ZeDnBMGtDtOFQ2t(base.DataProvider, num31);
										num13 = 9;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
										{
											num13 = 31;
										}
										continue;
									case 3:
										if ((double)num16 > (double)num17 * (0.0 - num25))
										{
											num13 = 19;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
											{
												num13 = 50;
											}
											continue;
										}
										goto case 18;
									case 42:
										if (PriceRangeDir == ClusterSearchPriceRangeDirection.All)
										{
											num13 = 65;
											continue;
										}
										goto IL_105d;
									case 47:
										num18++;
										goto IL_0ee6;
									case 28:
										flag7 = true;
										num13 = 36;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
										{
											num13 = 1;
										}
										continue;
									case 33:
										num31 = num5 - BarsRange + 1;
										num13 = 61;
										continue;
									case 58:
										if (num26 < (double)num4.Value)
										{
											goto end_IL_0624;
										}
										goto IL_0fcd;
									case 59:
										if (num12 != rawCluster.Low)
										{
											num13 = 5;
											continue;
										}
										goto IL_10f1;
									case 32:
										num14 = FfHhKSeDop23deRdpowX(num29);
										num13 = 23;
										continue;
									case 30:
										flag5 = false;
										num13 = 19;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
										{
											num13 = 56;
										}
										continue;
									case 4:
										if (num7.HasValue)
										{
											num25 = (double)num7.Value / 100.0;
											num13 = 28;
											continue;
										}
										goto IL_09ae;
									case 27:
										flag4 = false;
										num13 = 62;
										continue;
									case 22:
										rawCluster2 = base.DataProvider.GetRawCluster(num18);
										num13 = 24;
										continue;
									case 37:
										if (flag4)
										{
											num19 = 41;
											goto IL_03da;
										}
										goto IL_10fe;
									case 40:
										num27 = Math.Max(num12, val2);
										num28 = Math.Min(num12, val2);
										num13 = 10;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
										{
											num13 = 43;
										}
										continue;
									case 8:
										try
										{
											while (enumerator2.MoveNext())
											{
												long current2 = enumerator2.Current;
												Hl5iDwPDicJ(num11, rawCluster, ref num15, ref num16, ref num17, ref flag2, ref val, rawCluster3, current2);
											}
											int num33 = 0;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
											{
												num33 = 0;
											}
											switch (num33)
											{
											case 0:
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
										}
										goto IL_0be3;
									case 53:
										if (num22 < 0.0 && (double)num24 > (double)num23 * (0.0 - num22))
										{
											flag3 = false;
											num13 = 2;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
											{
												num13 = 20;
											}
											continue;
										}
										goto case 20;
									case 52:
										if ((double)num17 > (double)num16 * num25)
										{
											flag7 = false;
											num13 = 18;
											continue;
										}
										goto IL_0994;
									case 15:
										if (PriceRangeDir != ClusterSearchPriceRangeDirection.Downward)
										{
											if (PriceRangeDir == ClusterSearchPriceRangeDirection.All)
											{
												num13 = 6;
												if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
												{
													num13 = 55;
												}
												continue;
											}
											goto IL_0604;
										}
										goto case 55;
									case 19:
										flag5 = false;
										num13 = 23;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
										{
											num13 = 25;
										}
										continue;
									case 5:
									case 9:
									case 26:
									case 45:
										goto end_IL_0624;
									case 39:
										if (num6.HasValue)
										{
											long num30 = num17 - num16;
											if ((num6.Value > 0 && num30 < num6.Value) || (num6.Value < 0 && num30 > num6.Value))
											{
												flag = false;
												num13 = 35;
												continue;
											}
										}
										goto case 35;
									case 10:
										clusterSearchPriceLocation = PriceLocation;
										num13 = 57;
										continue;
									case 17:
										num20 = 0L;
										num13 = 11;
										continue;
									case 62:
										val2 = num12;
										num13 = 33;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
										{
											num13 = 63;
										}
										continue;
									case 1:
										num32 = num23 - num24;
										if (num6.Value > 0)
										{
											num13 = 21;
											continue;
										}
										goto IL_0b66;
									case 56:
										if (flag5)
										{
											num29 = num20;
											num13 = 40;
											continue;
										}
										goto IL_0604;
									case 35:
										if (!flag)
										{
											goto IL_09ae;
										}
										goto case 4;
									case 13:
										f899SFirEst4trTRSkCM.eVuirQSaUOG(new PoJL52irltaaMpEgr5Kb(rawCluster.Time, num27, num28, num29));
										if (p0atTfeDGHa7RZPFHecC(Alert))
										{
											if (num5 == base.DataProvider.Count - 1 && W5UleheDYAvmoucBMBWI(f899SFirEst4trTRSkCM, num12))
											{
												AddAlert(Alert, nRuiD763XKw(num12, num29));
											}
											goto case 32;
										}
										num13 = 32;
										continue;
									case 7:
										goto IL_10c9;
									case 51:
										goto IL_10f1;
									case 54:
										if (num12 < Math.Min(hiK0OZeD0ond3Xvk9ShC(rawCluster), lYidw7eDHi8B8UWnCmJM(rawCluster)))
										{
											num13 = 26;
											continue;
										}
										goto IL_10f1;
									case 49:
										Hl5iDwPDicJ(num11, rawCluster, ref num20, ref num24, ref num23, ref flag4, ref val2, rawCluster2, num12);
										num19 = 47;
										goto IL_03da;
									case 44:
										if (num22 > 0.0 && (double)num23 > (double)num24 * num22)
										{
											flag3 = false;
											goto case 20;
										}
										goto case 53;
									case 23:
										DIwiNLodYID = ((DIwiNLodYID == 0L) ? num14 : F92Jh9eDvAsb79CdAtGa(DIwiNLodYID, num14));
										num19 = 6;
										goto IL_03da;
									case 6:
										{
											vUpiNxdZK7d = ((vUpiNxdZK7d == 0L) ? num14 : Math.Min(vUpiNxdZK7d, num14));
											goto end_IL_0624;
										}
										IL_10fe:
										flag5 = false;
										goto IL_0a64;
										IL_0fcd:
										if (!num8.HasValue || !(num26 > (double?)num8))
										{
											flag6 = false;
											num29 = 0L;
											num27 = 0L;
											num28 = 0L;
											num13 = 15;
											continue;
										}
										goto end_IL_0624;
										IL_0be3:
										num31++;
										goto case 61;
										IL_0994:
										if (num25 < 0.0)
										{
											num13 = 3;
											continue;
										}
										goto case 18;
										IL_0b66:
										if (num6.Value < 0 && num32 > num6.Value)
										{
											num13 = 19;
											continue;
										}
										goto case 25;
										IL_0a64:
										if (!flag5 || !num6.HasValue)
										{
											goto case 25;
										}
										goto case 1;
										IL_09ae:
										if (flag)
										{
											num29 = num15;
											num27 = Math.Max(num12, val);
											num28 = Math.Min(num12, val);
											flag6 = true;
										}
										goto IL_105d;
										IL_0604:
										if (!flag6)
										{
											num13 = 48;
											continue;
										}
										goto IL_105d;
										IL_0ee6:
										if (num18 > num5)
										{
											num13 = 37;
											continue;
										}
										goto case 22;
										IL_105d:
										if (flag6)
										{
											num13 = 13;
											continue;
										}
										goto end_IL_0624;
										IL_03da:
										num13 = num19;
										continue;
									}
									break;
									IL_095c:
									switch (clusterSearchPriceLocation)
									{
									case ClusterSearchPriceLocation.UpperWick:
										break;
									case ClusterSearchPriceLocation.Wick:
										goto IL_0674;
									case ClusterSearchPriceLocation.Body:
										goto IL_0737;
									case ClusterSearchPriceLocation.High:
										goto IL_07b3;
									case ClusterSearchPriceLocation.Low:
										goto IL_08fc;
									default:
										goto IL_0981;
									case ClusterSearchPriceLocation.HighLow:
										goto IL_10c9;
									case ClusterSearchPriceLocation.LowerWick:
										goto IL_1106;
									}
									if (num12 <= Math.Max(rawCluster.Open, rawCluster.Close))
									{
										goto end_IL_0624;
									}
									goto IL_10f1;
									IL_1106:
									if (num12 >= Math.Min(hiK0OZeD0ond3Xvk9ShC(rawCluster), rawCluster.Close))
									{
										goto end_IL_0624;
									}
									goto IL_10f1;
									IL_10c9:
									if (num12 != rawCluster.High)
									{
										num13 = 59;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
										{
											num13 = 17;
										}
										continue;
									}
									goto IL_10f1;
									IL_0737:
									if (num12 > Math.Max(rawCluster.Open, rawCluster.Close))
									{
										goto end_IL_0624;
									}
									num13 = 54;
									continue;
									IL_10f1:
									num3 = RangeFromHigh;
									if (num3.HasValue)
									{
										long price = current.Price;
										long num35 = FTClWReDfkW5xCifiTuo(rawCluster);
										num3 = RangeFromHigh;
										if (price < num35 - num3.Value)
										{
											goto end_IL_0624;
										}
									}
									num3 = RangeFromLow;
									num13 = 16;
									continue;
									IL_0981:
									num13 = 51;
									continue;
									IL_08fc:
									if (num12 != rawCluster.Low)
									{
										num13 = 45;
										continue;
									}
									goto IL_10f1;
									IL_07b3:
									if (num12 != rawCluster.High)
									{
										num13 = 9;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
										{
											num13 = 9;
										}
										continue;
									}
									goto IL_10f1;
									IL_0674:
									if (num12 <= Math.Max(rawCluster.Open, rawCluster.Close))
									{
										num13 = 38;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
										{
											num13 = 3;
										}
										continue;
									}
									goto IL_10f1;
								}
								continue;
								end_IL_0624:
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							VNhiexeDBknfhFUq31BE(enumerator);
						}
					}
					goto case 22;
					IL_03a0:
					clusterSearchBarDirection = BarDirection;
					if (clusterSearchBarDirection != ClusterSearchBarDirection.Up)
					{
						num2 = 21;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	private void Hl5iDwPDicJ(long? P_0, IRawCluster P_1, ref long P_2, ref long P_3, ref long P_4, ref bool P_5, ref long P_6, IRawCluster P_7, long P_8)
	{
		IRawClusterItem item = P_7.GetItem(P_8);
		if (item != null && Gr0iDmKvwFx(P_1, item, P_0, ref P_2, ref P_3, ref P_4))
		{
			P_6 = Math.Min(P_6, item.Price);
			P_5 = true;
		}
	}

	private string nRuiD763XKw(long P_0, long P_1)
	{
		string text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x34407BB ^ 0x34481C1);
		ClusterSearchDataType clusterSearchDataType = Type;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
		{
			num = 8;
		}
		string text2;
		while (true)
		{
			switch (num)
			{
			default:
				if (Type != ClusterSearchDataType.Trades)
				{
					num = 6;
					continue;
				}
				text2 = base.DataProvider.Symbol.FormatTrades(P_1);
				break;
			case 1:
				goto IL_00c8;
			case 8:
				switch (clusterSearchDataType)
				{
				case ClusterSearchDataType.MaxVol:
					goto IL_00c8;
				case ClusterSearchDataType.Delta:
					text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7F55E538 ^ 0x7F556BEC);
					break;
				case ClusterSearchDataType.DeltaPlus:
					goto IL_018e;
				case ClusterSearchDataType.Trades:
					text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5BC60);
					break;
				case ClusterSearchDataType.Bid:
					goto IL_01dc;
				case ClusterSearchDataType.DeltaMinus:
					goto IL_01f9;
				case ClusterSearchDataType.Ask:
					goto IL_0216;
				case ClusterSearchDataType.Volume:
					goto IL_0257;
				}
				goto default;
			case 6:
				text2 = base.DataProvider.Symbol.FormatRawSizeShort(P_1);
				break;
			case 3:
				goto IL_018e;
			case 2:
				goto IL_01f9;
				IL_0257:
				text = (string)iKquiRe4wOyI6W76lobA(-198991962 ^ -199028458);
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num = 4;
				}
				continue;
				IL_00c8:
				text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x315AB1E3 ^ 0x315A227B);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
				{
					num = 0;
				}
				continue;
				IL_0216:
				text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -6011121);
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
				{
					num = 7;
				}
				continue;
				IL_01f9:
				text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1EFE0A28 ^ 0x1EFE9990);
				goto default;
				IL_01dc:
				text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82892792);
				num = 5;
				continue;
				IL_018e:
				text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435624519);
				goto default;
			}
			break;
		}
		string text3 = text2;
		return (string)hQoAFJeDiGOOnc1FNBWW(Resources.ChartIndicatorsClusterSearchAlert, text, text3, base.DataProvider.Symbol.FormatRawPrice(P_0, shortDecimals: true));
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 22;
		int num4 = default(int);
		PoJL52irltaaMpEgr5Kb poJL52irltaaMpEgr5Kb = default(PoJL52irltaaMpEgr5Kb);
		int num12 = default(int);
		double step = default(double);
		int num13 = default(int);
		int num10 = default(int);
		ClusterSearchObjectType clusterSearchObjectType = default(ClusterSearchObjectType);
		int num8 = default(int);
		List<PoJL52irltaaMpEgr5Kb> list = default(List<PoJL52irltaaMpEgr5Kb>);
		int num7 = default(int);
		PoJL52irltaaMpEgr5Kb poJL52irltaaMpEgr5Kb2 = default(PoJL52irltaaMpEgr5Kb);
		DateTime dateTime = default(DateTime);
		Point[] array = default(Point[]);
		long num16 = default(long);
		int num5 = default(int);
		int num6 = default(int);
		Rect rect = default(Rect);
		int num11 = default(int);
		Point[] array2 = default(Point[]);
		double num14 = default(double);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num9;
				switch (num2)
				{
				case 7:
					num4 = (int)GetX(base.Canvas.DateToIndex(poJL52irltaaMpEgr5Kb.Time, -1));
					num12 = (int)GetY(((double)poJL52irltaaMpEgr5Kb.p4KirDHCbqB() + 0.5) * step);
					num13 = (int)GetY(((double)poJL52irltaaMpEgr5Kb.IJYirNnJOtH() - 0.5) * step);
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
					{
						num2 = 0;
					}
					continue;
				case 35:
					num9 = num10;
					goto IL_07e1;
				case 16:
					switch (clusterSearchObjectType)
					{
					case ClusterSearchObjectType.Diamond:
						goto IL_033f;
					case ClusterSearchObjectType.Triangle:
						goto IL_03b9;
					case ClusterSearchObjectType.Circle:
						goto IL_052b;
					case ClusterSearchObjectType.Rectangle:
						goto IL_0733;
					}
					goto case 23;
				case 18:
					if (num8 < list.Count)
					{
						goto case 33;
					}
					goto IL_0355;
				case 14:
					if (num7 < list.Count)
					{
						poJL52irltaaMpEgr5Kb2 = list[num7];
						if (poJL52irltaaMpEgr5Kb2.Time == dateTime)
						{
							num2 = 5;
							continue;
						}
					}
					goto IL_0237;
				case 33:
					poJL52irltaaMpEgr5Kb = list[num8];
					if (SingleSelection)
					{
						num2 = 2;
						continue;
					}
					goto IL_0237;
				case 5:
					if (Math.Abs(poJL52irltaaMpEgr5Kb2.Value) > Math.Abs(poJL52irltaaMpEgr5Kb.Value))
					{
						poJL52irltaaMpEgr5Kb = poJL52irltaaMpEgr5Kb2;
					}
					num8 = num7;
					num7++;
					num2 = 14;
					continue;
				case 9:
					P_0.FillPolygon(Dudibu4PsIO, array);
					P_0.DrawPolygon(lmriN2aA8h9, array);
					goto case 23;
				case 31:
					num16 = DIwiNLodYID - vUpiNxdZK7d;
					num2 = 11;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
					{
						num2 = 3;
					}
					continue;
				case 20:
					aXSiNX62UNB.Add(new FyOrgmirefUZS2hBIWHp(new Rect(new Point(num4 - num5, num6 - num5), new Point(num4 + num5, num6 + num5)), poJL52irltaaMpEgr5Kb));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
					{
						num2 = 0;
					}
					continue;
				case 27:
					num8 = 0;
					goto case 18;
				case 23:
				case 24:
					if (zoF8oXeDkkwFTAmFofau(base.Canvas) != ChartStockType.Clusters)
					{
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 15;
				case 29:
					P_0.DrawRectangle(lmriN2aA8h9, rect);
					goto case 23;
				case 30:
					if (Type != ClusterSearchDataType.Ask)
					{
						H9Bah4eD58Rx6blXPoyp(P_0, L0lib3d01yp, new Rect(new Point(num4 - num11, num12), new Point(num4 + num11 + 1, num13)));
					}
					else
					{
						P_0.FillRectangle(L0lib3d01yp, new Rect(new Point(num4, num12), new Point(num4 + num11 + 1, num13)));
					}
					goto case 15;
				case 12:
					array2[0] = new Point(num4 - num5, num6);
					num2 = 8;
					continue;
				case 15:
					num8++;
					num2 = 18;
					continue;
				case 13:
				{
					num6 = (int)((double)(num12 + num13) / 2.0);
					double num15 = 9.0;
					if (FfHhKSeDop23deRdpowX(poJL52irltaaMpEgr5Kb.Value) != DIwiNLodYID && num16 > 0)
					{
						num15 = (double)(FfHhKSeDop23deRdpowX(W8FMKweDDAq53TjONIQD(poJL52irltaaMpEgr5Kb)) - vUpiNxdZK7d) / ((double)num16 / 9.0);
					}
					num5 = (int)(((double)num10 + num14 * num15) / 2.0);
					num2 = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 17:
					aXSiNX62UNB = new List<FyOrgmirefUZS2hBIWHp>();
					goto IL_047e;
				case 4:
					num11 = (int)Math.Max(qANDqkeD1EfKQdwe5KQB(base.Canvas) / 2.0 - 1.0, 2.0);
					num2 = 19;
					continue;
				case 10:
					goto IL_052b;
				case 6:
					array2[2] = new Point(num4 + num5, num6);
					array2[3] = new Point(num4, num6 + num5);
					P_0.FillPolygon(Dudibu4PsIO, array2);
					P_0.DrawPolygon(lmriN2aA8h9, array2);
					num2 = 11;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num2 = 24;
					}
					continue;
				case 32:
					array[0] = new Point(num4, num6 - num5);
					array[1] = new Point(num4 + num5, num6 + num5);
					num = 28;
					break;
				case 22:
					base.Render(P_0);
					num2 = 21;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
					{
						num2 = 4;
					}
					continue;
				case 19:
					if (Type == ClusterSearchDataType.Bid)
					{
						H9Bah4eD58Rx6blXPoyp(P_0, L0lib3d01yp, new Rect(new Point(num4 - num11, num12), new Point(num4 + 1, num13)));
						num2 = 15;
						continue;
					}
					goto case 30;
				case 34:
					num9 = Math.Min(200, aLauIHeDl4Fa8o2Xdwds(ObjectMaxSize, 10));
					if (num9 < num10)
					{
						num2 = 35;
						continue;
					}
					goto IL_07e1;
				case 3:
					aXSiNX62UNB.Clear();
					goto IL_047e;
				case 1:
				{
					if (num3 >= lJMFn5eDSrUbmrj4jGhO(base.Canvas))
					{
						return;
					}
					int index = base.Canvas.GetIndex(num3);
					if (!edaib7wycwg().ContainsKey(index))
					{
						goto IL_0355;
					}
					list = edaib7wycwg()[index].Items;
					num2 = 27;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 26:
					goto IL_0733;
				case 21:
					if (aXSiNX62UNB == null)
					{
						num2 = 17;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 3;
				case 2:
					dateTime = nt1T8eeD4iQChqXua9Mu(poJL52irltaaMpEgr5Kb);
					num7 = num8 + 1;
					goto case 14;
				case 8:
					array2[1] = new Point(num4, num6 - num5);
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
					{
						num2 = 5;
					}
					continue;
				case 25:
					gcLkEweDNFVrScIugpFv(P_0, lmriN2aA8h9, new Point(num4, num6), num5, num5);
					num2 = 23;
					continue;
				default:
					clusterSearchObjectType = ObjectType;
					num2 = 16;
					continue;
				case 28:
					array[2] = new Point(num4 - num5, num6 + num5);
					num2 = 9;
					continue;
				case 11:
					{
						num3 = 0;
						goto case 1;
					}
					IL_052b:
					iRlmKkeDbvpvLuI0vMFj(P_0, Dudibu4PsIO, new Point(num4, num6), num5, num5);
					num2 = 25;
					continue;
					IL_033f:
					array2 = new Point[4];
					num = 12;
					break;
					IL_03b9:
					array = new Point[3];
					num2 = 32;
					continue;
					IL_07e1:
					num14 = (double)(num9 - num10) / 9.0;
					num2 = 31;
					continue;
					IL_0355:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
					{
						num2 = 0;
					}
					continue;
					IL_047e:
					num10 = Math.Max(10, Math.Min(200, ObjectMinSize));
					num2 = 34;
					continue;
					IL_0237:
					step = base.DataProvider.Step;
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num2 = 7;
					}
					continue;
					IL_0733:
					rect = new Rect(new Point(num4 - num5, num6 - num5), new Point(num4 + num5, num6 + num5));
					P_0.FillRectangle(Dudibu4PsIO, rect);
					num = 29;
					break;
				}
				break;
			}
		}
	}

	public override void RenderCursor(DxVisualQueue P_0, int P_1, Point P_2, ref int P_3)
	{
		if ((Keyboard.Modifiers & ModifierKeys.Control) == 0)
		{
			return;
		}
		List<string> list = default(List<string>);
		if (aXSiNX62UNB != null)
		{
			if (aXSiNX62UNB.Count == 0)
			{
				return;
			}
			list = new List<string>();
			using (List<FyOrgmirefUZS2hBIWHp>.Enumerator enumerator = aXSiNX62UNB.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FyOrgmirefUZS2hBIWHp current;
					while (true)
					{
						current = enumerator.Current;
						int num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
						{
							num = 0;
						}
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					if (current.wcfirsaxBCc(P_2))
					{
						list.Add((string)OiAYgpeDxfqh8xA1hE8W(current, Type, base.DataProvider, ToString()));
					}
				}
			}
			goto IL_02c2;
		}
		int num2 = 12;
		goto IL_0009;
		IL_02c2:
		if (list.Count == 0)
		{
			return;
		}
		double x = P_2.X + 15.0;
		num2 = 13;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
		{
			num2 = 6;
		}
		goto IL_0009;
		IL_0009:
		double num3 = default(double);
		double num4 = default(double);
		double num11 = default(double);
		double num6 = default(double);
		List<Tuple<string, Rect>> list2 = default(List<Tuple<string, Rect>>);
		Rect rect = default(Rect);
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		Rect item = default(Rect);
		string current2 = default(string);
		double num7 = default(double);
		List<Tuple<string, Rect>>.Enumerator enumerator3 = default(List<Tuple<string, Rect>>.Enumerator);
		double num9 = default(double);
		double num8 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 7:
				num3 -= num4 + 30.0;
				num11 = 0.0 - (num4 + 30.0);
				goto case 10;
			case 6:
				num6 = 0.0;
				num4 = 0.0;
				list2 = new List<Tuple<string, Rect>>();
				num2 = 2;
				continue;
			case 11:
				P_3 += (int)rect.Height + 5 + (int)num11;
				P_0.FillRectangle(base.Canvas.Theme.ChartBackBrush, rect);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
							{
								num5 = 1;
							}
							goto IL_01a6;
						}
						goto IL_01d5;
						IL_01a6:
						switch (num5)
						{
						case 2:
							goto IL_0253;
						case 1:
							goto end_IL_0218;
						}
						goto IL_01d5;
						IL_0253:
						num4 += item.Height + 2.0;
						list2.Add(new Tuple<string, Rect>(current2, item));
						continue;
						IL_01d5:
						current2 = enumerator2.Current;
						Size size = base.Canvas.ChartFont.GetSize(current2);
						num6 = Math.Max(num6, size.Width);
						item = new Rect(x, num7 + num4 + 2.0, num6, size.Height + 2.0);
						num5 = 2;
						goto IL_01a6;
						continue;
						end_IL_0218:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 9;
			case 12:
				return;
			case 3:
				break;
			case 8:
				try
				{
					while (enumerator3.MoveNext())
					{
						Tuple<string, Rect> current3 = enumerator3.Current;
						P_0.DrawString(current3.Item1, base.Canvas.ChartFont, (XBrush)yShNJ3eDsFF3wZRjpICY(YvyBU6eDeABHsh3kFn8b(base.Canvas)), new Rect(current3.Item2.X + num9, current3.Item2.Y + num11, current3.Item2.Width, current3.Item2.Height));
						int num12 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
				}
			case 4:
				num8 -= num6 + 30.0;
				num9 = 0.0 - (num6 + 30.0);
				goto IL_03f7;
			case 10:
				rect = new Rect(num8, num3 + (double)P_3, num6 + 10.0, num4 + 7.0);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
				{
					num2 = 11;
				}
				continue;
			case 9:
				num8 = P_2.X + 10.0;
				num9 = 0.0;
				if (num8 + num6 + 10.0 >= idV8QaeDLgrbgDhhDsFv(base.Canvas).Right)
				{
					int num10 = 4;
					num2 = num10;
					continue;
				}
				goto IL_03f7;
			case 13:
				num7 = P_2.Y + 13.0 + (double)P_3;
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				P_0.DrawRectangle(new XPen(new XBrush(base.Canvas.Theme.ChartAxisColor), 1), rect);
				enumerator3 = list2.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
				{
					num2 = 8;
				}
				continue;
			case 2:
				enumerator2 = list.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				{
					if (P_3 == 0)
					{
						if (num3 + num4 + 10.0 >= base.Canvas.Rect.Bottom)
						{
							num2 = 4;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 10;
					}
					num2 = 10;
					continue;
				}
				IL_03f7:
				num3 = P_2.Y + 10.0;
				num11 = 0.0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		goto IL_02c2;
	}

	public override IndicatorTitleInfo GetTitle()
	{
		return new IndicatorTitleInfo(base.Title, L0lib3d01yp);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		lat7lZiDrhWcmRn7e9Li lat7lZiDrhWcmRn7e9Li2 = (lat7lZiDrhWcmRn7e9Li)P_0;
		Type = lat7lZiDrhWcmRn7e9Li2.Type;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 12:
				MinAvgTrade = lat7lZiDrhWcmRn7e9Li2.MinAvgTrade;
				BarDirection = lat7lZiDrhWcmRn7e9Li2.BarDirection;
				num = 4;
				break;
			case 4:
				PriceLocation = AcMZO3eD6lCGIQjoQBnH(lat7lZiDrhWcmRn7e9Li2);
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num = 5;
				}
				break;
			case 0:
				return;
			case 9:
				MaxAvgTrade = lat7lZiDrhWcmRn7e9Li2.MaxAvgTrade;
				num = 12;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
				{
					num = 12;
				}
				break;
			case 10:
				BarsRange = el2NdJeDgrBfCBtstiQC(lat7lZiDrhWcmRn7e9Li2);
				PriceRange = lat7lZiDrhWcmRn7e9Li2.PriceRange;
				num = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
				{
					num = 8;
				}
				break;
			case 3:
				O0HiDFAFOCE.Copy(lat7lZiDrhWcmRn7e9Li2.O0HiDFAFOCE);
				SelectionColor = TDULSheDclIjDN7NuhFh(lat7lZiDrhWcmRn7e9Li2);
				ObjectBackColor = hA6YtFeDjRhUOhgZ4Js6(lat7lZiDrhWcmRn7e9Li2);
				ObjectBorderColor = zoj2pTeDEigmPvDuBdYC(lat7lZiDrhWcmRn7e9Li2);
				num = 6;
				break;
			case 8:
				PriceRangeDir = lat7lZiDrhWcmRn7e9Li2.PriceRangeDir;
				pQfibsQ5fIK.Copy((IndicatorParam<int?>)ngxx7IeDRbkOFuoEGsXY(lat7lZiDrhWcmRn7e9Li2));
				MinDelta = lat7lZiDrhWcmRn7e9Li2.MinDelta;
				BidAskImbalance = lat7lZiDrhWcmRn7e9Li2.BidAskImbalance;
				RangeFromHigh = lat7lZiDrhWcmRn7e9Li2.RangeFromHigh;
				RangeFromLow = lat7lZiDrhWcmRn7e9Li2.RangeFromLow;
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
				{
					num = 9;
				}
				break;
			case 11:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837258874));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 != 0)
				{
					num = 7;
				}
				break;
			case 6:
				ObjectType = lat7lZiDrhWcmRn7e9Li2.ObjectType;
				num = 2;
				break;
			case 5:
				SingleSelection = Ss6GmQeDMJ5sMDui3Lu3(lat7lZiDrhWcmRn7e9Li2);
				UseTimeFilter = lat7lZiDrhWcmRn7e9Li2.UseTimeFilter;
				StartTime = lat7lZiDrhWcmRn7e9Li2.StartTime;
				EndTime = lat7lZiDrhWcmRn7e9Li2.EndTime;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xAD5B8B3 ^ 0xAD529F7));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002282271));
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ObjectMinSize = NhThHCeDQj5D7BU3fYi8(lat7lZiDrhWcmRn7e9Li2);
				ObjectMaxSize = dlaDKkeDd2uuY46VntaD(lat7lZiDrhWcmRn7e9Li2);
				num = 10;
				break;
			case 1:
				Alert.Copy((ChartAlertSettings)unc619eDX0dLyBBynGY7(lat7lZiDrhWcmRn7e9Li2), !P_1);
				num = 11;
				break;
			case 7:
				Qacib01csfP.Copy(lat7lZiDrhWcmRn7e9Li2.Qacib01csfP);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public XBrush GetSelection(int P_0, long P_1, int P_2)
	{
		int num = 3;
		int num2 = num;
		ClusterSearchDataType clusterSearchDataType = default(ClusterSearchDataType);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return null;
			case 4:
				return null;
			case 1:
				switch (clusterSearchDataType)
				{
				case ClusterSearchDataType.Ask:
					if (P_2 == 4)
					{
						return null;
					}
					goto default;
				case ClusterSearchDataType.Delta:
				case ClusterSearchDataType.DeltaPlus:
				case ClusterSearchDataType.DeltaMinus:
					if (P_2 == 5)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case ClusterSearchDataType.Volume:
				case ClusterSearchDataType.MaxVol:
					if (P_2 == 1)
					{
						return null;
					}
					goto default;
				case ClusterSearchDataType.Bid:
					if (P_2 == 3)
					{
						return null;
					}
					goto default;
				default:
					if (SingleSelection ? edaib7wycwg()[P_0].SingleSelection.Contains(P_1) : edaib7wycwg()[P_0].npxir6HeAeG().Contains(P_1))
					{
						return L0lib3d01yp;
					}
					num2 = 5;
					break;
				case ClusterSearchDataType.Trades:
					if (P_2 == 2)
					{
						return null;
					}
					goto default;
				}
				break;
			default:
				return null;
			case 2:
				if (edaib7wycwg().ContainsKey(P_0))
				{
					clusterSearchDataType = Type;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
					{
						num2 = 4;
					}
				}
				break;
			case 3:
				if (base.ShowIndicator)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	public override string ToString()
	{
		if (Maximum.HasValue)
		{
			return string.Format((string)iKquiRe4wOyI6W76lobA(0x60620FC1 ^ 0x60629C09), Type, Minimum, Maximum.GetValueOrDefault());
		}
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346966191), Type, Minimum), 
		};
	}

	static lat7lZiDrhWcmRn7e9Li()
	{
		OoPYIweDOh8OsVeyCmVj();
		t3hFc4eDqt8k76ESyXEt();
	}

	internal static object iKquiRe4wOyI6W76lobA(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool fwMawIe4mbkRAKunt0Bs()
	{
		return QEEpUTe4KCf4LYSApqfo == null;
	}

	internal static lat7lZiDrhWcmRn7e9Li b3xgt1e4hV7FjYdLrkC6()
	{
		return QEEpUTe4KCf4LYSApqfo;
	}

	internal static bool M7aj7We47FcyuLOSJtZE(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static bool QrM3X2e48fkBAOhMuMJN(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static Color wSF0WBe4Aer4hHPYO0GH(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor eVwkh7e4P6p1HXicZx45(Color P_0)
	{
		return P_0;
	}

	internal static void OLl8aWe4Js6ckJYHbQrs(object P_0)
	{
		((Dictionary<int, F899SFirEst4trTRSkCM>)P_0).Clear();
	}

	internal static object hRuOr1e4FKA6DjuaynBH(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static long uQSLDTe43E4OIojMpduv(object P_0, double filter)
	{
		return ((IChartSymbol)P_0).CorrectSizeFilter(filter);
	}

	internal static bool w72Cphe4pQptNVtmyKgY(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 <= P_1;
	}

	internal static bool jdreVIe4uAZE2jU2TBcO(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static DateTime Spghgve4z7ZBLxBZyTSJ(object P_0)
	{
		return ((IRawCluster)P_0).OpenTime;
	}

	internal static long hiK0OZeD0ond3Xvk9ShC(object P_0)
	{
		return ((IRawCluster)P_0).Open;
	}

	internal static long dgkmi9eD2mk6LPwH0GM6(object P_0)
	{
		return ((IRawClusterItem)P_0).Price;
	}

	internal static long lYidw7eDHi8B8UWnCmJM(object P_0)
	{
		return ((IRawCluster)P_0).Close;
	}

	internal static long FTClWReDfkW5xCifiTuo(object P_0)
	{
		return ((IRawCluster)P_0).High;
	}

	internal static long DnO4PMeD9MUMpSwJ1Nho(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static object Q2LL9ZeDnBMGtDtOFQ2t(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetRawCluster(i);
	}

	internal static bool p0atTfeDGHa7RZPFHecC(object P_0)
	{
		return ((ChartAlertSettings)P_0).IsActive;
	}

	internal static bool W5UleheDYAvmoucBMBWI(object P_0, long P_1)
	{
		return ((F899SFirEst4trTRSkCM)P_0).mMJirdsEY6M(P_1);
	}

	internal static long FfHhKSeDop23deRdpowX(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static long F92Jh9eDvAsb79CdAtGa(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void VNhiexeDBknfhFUq31BE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int EhrLWEeDaAuiP4xPQB3d(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static object hQoAFJeDiGOOnc1FNBWW(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static int aLauIHeDl4Fa8o2Xdwds(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static DateTime nt1T8eeD4iQChqXua9Mu(object P_0)
	{
		return ((PoJL52irltaaMpEgr5Kb)P_0).Time;
	}

	internal static long W8FMKweDDAq53TjONIQD(object P_0)
	{
		return ((PoJL52irltaaMpEgr5Kb)P_0).Value;
	}

	internal static void iRlmKkeDbvpvLuI0vMFj(object P_0, object P_1, Point P_2, double P_3, double P_4)
	{
		((DxVisualQueue)P_0).FillEllipse((XBrush)P_1, P_2, P_3, P_4);
	}

	internal static void gcLkEweDNFVrScIugpFv(object P_0, object P_1, Point P_2, double P_3, double P_4)
	{
		((DxVisualQueue)P_0).DrawEllipse((XPen)P_1, P_2, P_3, P_4);
	}

	internal static ChartStockType zoF8oXeDkkwFTAmFofau(object P_0)
	{
		return ((IChartCanvas)P_0).StockType;
	}

	internal static double qANDqkeD1EfKQdwe5KQB(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static void H9Bah4eD58Rx6blXPoyp(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int lJMFn5eDSrUbmrj4jGhO(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static object OiAYgpeDxfqh8xA1hE8W(object P_0, ClusterSearchDataType P_1, object P_2, object P_3)
	{
		return ((FyOrgmirefUZS2hBIWHp)P_0).RAxirXT7Q88(P_1, (IChartDataProvider)P_2, (string)P_3);
	}

	internal static Rect idV8QaeDLgrbgDhhDsFv(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static object YvyBU6eDeABHsh3kFn8b(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static object yShNJ3eDsFF3wZRjpICY(object P_0)
	{
		return ((IChartTheme)P_0).ChartFontBrush;
	}

	internal static object unc619eDX0dLyBBynGY7(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).Alert;
	}

	internal static XColor TDULSheDclIjDN7NuhFh(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).SelectionColor;
	}

	internal static XColor hA6YtFeDjRhUOhgZ4Js6(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).ObjectBackColor;
	}

	internal static XColor zoj2pTeDEigmPvDuBdYC(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).ObjectBorderColor;
	}

	internal static int NhThHCeDQj5D7BU3fYi8(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).ObjectMinSize;
	}

	internal static int dlaDKkeDd2uuY46VntaD(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).ObjectMaxSize;
	}

	internal static int el2NdJeDgrBfCBtstiQC(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).BarsRange;
	}

	internal static object ngxx7IeDRbkOFuoEGsXY(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).pQfibsQ5fIK;
	}

	internal static ClusterSearchPriceLocation AcMZO3eD6lCGIQjoQBnH(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).PriceLocation;
	}

	internal static bool Ss6GmQeDMJ5sMDui3Lu3(object P_0)
	{
		return ((lat7lZiDrhWcmRn7e9Li)P_0).SingleSelection;
	}

	internal static void OoPYIweDOh8OsVeyCmVj()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void t3hFc4eDqt8k76ESyXEt()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
