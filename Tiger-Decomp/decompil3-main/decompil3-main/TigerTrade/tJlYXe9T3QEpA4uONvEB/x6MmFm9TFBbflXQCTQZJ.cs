using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using bFLVeaGpb14YNScYcv2Q;
using bQeLQJ9JVIVGlOu9BJva;
using C7UvAf9ri2R97XEwp7o2;
using e6yRlZiVfcDgC6OvTK1x;
using ECOEgqlSad8NUJZ2Dr9n;
using Io0TBCnnT6SonDXm9K0y;
using lyad2x98JraxOXunXS1L;
using MIA3eC2ZXsuRyAB0mjn;
using NeyqekiVGOVGZDdQ1cfW;
using NsWD4W9miMxRbFU3fsu9;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Chart.Settings;
using TigerTrade.Chart.Theme;
using TigerTrade.Core.Utils.Binary;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using TuAMtrl1Nd3XoZQQUXf0;
using WAdK5R9P6tprYEqxYeNB;
using Wf1kTvnGy6XhfTKJgfkM;
using zy8uls9AtRKGi5l5tZKJ;

namespace tJlYXe9T3QEpA4uONvEB;

[DataContract(Name = "BigTradesIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("BigTrades", "BigTrades", true, Type = typeof(x6MmFm9TFBbflXQCTQZJ))]
internal sealed class x6MmFm9TFBbflXQCTQZJ : fi0dX39rarBK9dp2dGQR, IContainsSelection, qt9C3B9AWZP5dEmJcrrj
{
	private class FSHxRunpKYYjjiyQrvDW
	{
		public DateTime Time;

		public readonly long RFAnpA8FQSP;

		public long PJZnpPumg2v;

		public long Size;

		public readonly Side gC0npJCO1It;

		public long Trades;

		public bool Ea9npF3hK6X;

		private static FSHxRunpKYYjjiyQrvDW dEbkcwNtbjXS0BnAGoUH;

		public FSHxRunpKYYjjiyQrvDW(DateTime P_0, long P_1, long P_2, long P_3, Side P_4, long P_5)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			Time = P_0;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					PJZnpPumg2v = P_2;
					Size = P_3;
					gC0npJCO1It = P_4;
					Trades = P_5;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				case 1:
					RFAnpA8FQSP = P_1;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num = 2;
					}
					break;
				}
			}
		}

		public FSHxRunpKYYjjiyQrvDW(KHxL9R9JZMZ1sv2HFY9P P_0)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					PJZnpPumg2v = P_0.Price;
					num = 2;
					continue;
				case 2:
					Size = C0D0pcNt5KrL7XyWMLOH(P_0);
					gC0npJCO1It = P_0.Side;
					Trades = 1L;
					return;
				}
				Time = P_0.Time;
				RFAnpA8FQSP = CvVRj2Nt1iDpJTVYLrl9(P_0);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 1;
				}
			}
		}

		public void WfWnpmx1iha(long P_0, long P_1)
		{
			Size += P_1;
			PJZnpPumg2v = P_0;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Trades++;
		}

		[SpecialName]
		public long pFMnphjxvbp()
		{
			return Math.Max(RFAnpA8FQSP, PJZnpPumg2v);
		}

		[SpecialName]
		public long Mftnp7teFeU()
		{
			return nOMX04NtSbkI5HMoyqC3(RFAnpA8FQSP, PJZnpPumg2v);
		}

		static FSHxRunpKYYjjiyQrvDW()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool t2jS2GNtNYxIDyvcRDAK()
		{
			return dEbkcwNtbjXS0BnAGoUH == null;
		}

		internal static FSHxRunpKYYjjiyQrvDW l3N5P2NtkuCqkbHg2mi4()
		{
			return dEbkcwNtbjXS0BnAGoUH;
		}

		internal static long CvVRj2Nt1iDpJTVYLrl9(object P_0)
		{
			return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Price;
		}

		internal static long C0D0pcNt5KrL7XyWMLOH(object P_0)
		{
			return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Size;
		}

		internal static long nOMX04NtSbkI5HMoyqC3(long P_0, long P_1)
		{
			return Math.Min(P_0, P_1);
		}
	}

	private class Jyfp9unp3Mi5n8KPGJXm
	{
		private Rect YgLnpz4Wv2K;

		private readonly FSHxRunpKYYjjiyQrvDW BMFnu0IS5sL;

		internal static Jyfp9unp3Mi5n8KPGJXm xfMjy2NtxJmfDALvEqm2;

		public Jyfp9unp3Mi5n8KPGJXm(Rect P_0, FSHxRunpKYYjjiyQrvDW P_1)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			YgLnpz4Wv2K = P_0;
			BMFnu0IS5sL = P_1;
		}

		public bool DfZnppvCu6P(Point P_0)
		{
			return YgLnpz4Wv2K.Contains(P_0);
		}

		public string qvenpuNOups(ypqMIv9maFM0tRwF0xMh P_0, string P_1)
		{
			string text = P_0.Symbol.uhTnGh8ahcs(BMFnu0IS5sL.RFAnpA8FQSP, _0020: true);
			int num;
			if (BMFnu0IS5sL.RFAnpA8FQSP != BMFnu0IS5sL.PJZnpPumg2v)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_0167;
			IL_0009:
			string text3 = default(string);
			long num2 = default(long);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					string text2 = (string)ol3moKNtcNjqB2WNciIc(P_0.Symbol, BMFnu0IS5sL.Time, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82861572));
					return (string)HSnTfkNtjptk6t93QHZx(new string[7]
					{
						P_1,
						(string)JeN24nNtsRSqcQdRXh0D(-1306877528 ^ -1306886126),
						text2,
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC9BD15),
						text,
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53512010),
						text3
					});
				}
				default:
					num2 = BMFnu0IS5sL.PJZnpPumg2v - BMFnu0IS5sL.RFAnpA8FQSP;
					if (num2 <= 0)
					{
						num = 2;
						continue;
					}
					text = (string)MVtUKkNtXynRa2FjNOyB(text, JeN24nNtsRSqcQdRXh0D(0x6D18F862 ^ 0x6D1C66A4), num2.ToString());
					break;
				case 2:
					text = (string)MVtUKkNtXynRa2FjNOyB(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746EF5BF), num2.ToString());
					num = 3;
					continue;
				case 3:
					break;
				}
				break;
			}
			goto IL_0167;
			IL_0167:
			text3 = P_0.Symbol.FormatRawSizeShort(BMFnu0IS5sL.Size);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}

		static Jyfp9unp3Mi5n8KPGJXm()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool dcvl5cNtLOiUYto0yaEu()
		{
			return xfMjy2NtxJmfDALvEqm2 == null;
		}

		internal static Jyfp9unp3Mi5n8KPGJXm L0nF1cNte1sxCoXFoDjh()
		{
			return xfMjy2NtxJmfDALvEqm2;
		}

		internal static object JeN24nNtsRSqcQdRXh0D(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object MVtUKkNtXynRa2FjNOyB(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static object ol3moKNtcNjqB2WNciIc(object P_0, DateTime P_1, object P_2)
		{
			return ((ijsjhhnGTadfwpOyDdrx)P_0).FormatTime(P_1, (string)P_2);
		}

		internal static object HSnTfkNtjptk6t93QHZx(object P_0)
		{
			return string.Concat((string[])P_0);
		}
	}

	private class dtWXJ3nu27wV4q2ef9iH : BinReader<FSHxRunpKYYjjiyQrvDW>
	{
		private long wU5nuHnUj7c;

		private long Gm5nufyFxax;

		private long Ewqnu9K8eMN;

		private static dtWXJ3nu27wV4q2ef9iH fDpGmdNtEedqLD8j8YWF;

		public dtWXJ3nu27wV4q2ef9iH(byte[] P_0)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector(P_0);
		}

		protected override FSHxRunpKYYjjiyQrvDW ReadItem()
		{
			wU5nuHnUj7c += cR8LxTNtgoIDoKxqStYl(this);
			Gm5nufyFxax += cR8LxTNtgoIDoKxqStYl(this);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
			{
				num = 0;
			}
			long gm5nufyFxax2 = default(long);
			long gm5nufyFxax = default(long);
			while (true)
			{
				switch (num)
				{
				case 2:
					Gm5nufyFxax += cR8LxTNtgoIDoKxqStYl(this);
					gm5nufyFxax2 = Gm5nufyFxax;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
					{
						num = 1;
					}
					break;
				default:
					gm5nufyFxax = Gm5nufyFxax;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num = 1;
					}
					break;
				case 1:
				{
					Ewqnu9K8eMN = cR8LxTNtgoIDoKxqStYl(this);
					Side side = (Side)cR8LxTNtgoIDoKxqStYl(this);
					long num2 = cR8LxTNtgoIDoKxqStYl(this);
					return new FSHxRunpKYYjjiyQrvDW(new DateTime(wU5nuHnUj7c), gm5nufyFxax, gm5nufyFxax2, Ewqnu9K8eMN, side, num2);
				}
				}
			}
		}

		static dtWXJ3nu27wV4q2ef9iH()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool pfvLZyNtQvu23fgMcvbi()
		{
			return fDpGmdNtEedqLD8j8YWF == null;
		}

		internal static dtWXJ3nu27wV4q2ef9iH jYVkTKNtdrDxs9KYapZN()
		{
			return fDpGmdNtEedqLD8j8YWF;
		}

		internal static long cR8LxTNtgoIDoKxqStYl(object P_0)
		{
			return ((BinReader<FSHxRunpKYYjjiyQrvDW>)P_0).ReadLeb128();
		}
	}

	private class lUWTRDnunZFkXi24q3ad
	{
		[CompilerGenerated]
		private readonly List<FSHxRunpKYYjjiyQrvDW> SFSnu4TGbOm;

		[CompilerGenerated]
		private readonly HashSet<long> t4HnuDrOs4f;

		[CompilerGenerated]
		private readonly HashSet<long> bAdnubQ4FiO;

		[CompilerGenerated]
		private readonly Dictionary<long, long> eX7nuNnAyNX;

		private static lUWTRDnunZFkXi24q3ad MgoARrNtRDplYoE3MFx0;

		public List<FSHxRunpKYYjjiyQrvDW> Items
		{
			[CompilerGenerated]
			get
			{
				return SFSnu4TGbOm;
			}
		}

		public Dictionary<long, long> Values
		{
			[CompilerGenerated]
			get
			{
				return eX7nuNnAyNX;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public HashSet<long> r08nuvCseXq()
		{
			return t4HnuDrOs4f;
		}

		[SpecialName]
		[CompilerGenerated]
		public HashSet<long> a6tnuaws77p()
		{
			return bAdnubQ4FiO;
		}

		public lUWTRDnunZFkXi24q3ad()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			SFSnu4TGbOm = new List<FSHxRunpKYYjjiyQrvDW>();
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
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
					t4HnuDrOs4f = new HashSet<long>();
					bAdnubQ4FiO = new HashSet<long>();
					eX7nuNnAyNX = new Dictionary<long, long>();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void tHEnuGmxl9K(FSHxRunpKYYjjiyQrvDW P_0)
		{
			Items.Add(P_0);
		}

		public void OuknuYcS5jX(x6MmFm9TFBbflXQCTQZJ P_0)
		{
			ngNfmANtOUZXxmS6OCCr(r08nuvCseXq());
			ngNfmANtOUZXxmS6OCCr(a6tnuaws77p());
			Values.Clear();
			ijsjhhnGTadfwpOyDdrx symbol = P_0.DataProvider.Symbol;
			int num = 2;
			int num2 = default(int);
			List<FSHxRunpKYYjjiyQrvDW>.Enumerator enumerator = default(List<FSHxRunpKYYjjiyQrvDW>.Enumerator);
			DateTime dateTime = default(DateTime);
			Dictionary<long, long> dictionary = default(Dictionary<long, long>);
			long item2 = default(long);
			long num5 = default(long);
			long item = default(long);
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					num2 = TJcF2oNtI71xmUs3UGdA(gEpDokNtq3nmj8WrKuS3(P_0));
					enumerator = Items.GetEnumerator();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
					{
						num = 0;
					}
					continue;
				}
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IL_00f0:
							FSHxRunpKYYjjiyQrvDW current = enumerator.Current;
							int num4;
							if (P_0.UseTimeFilter)
							{
								dateTime = Jq4LbgNtW38kgmPlcvMd(symbol, current.Time);
								if (!(P_0.StartTime <= P_0.EndTime))
								{
									if (dateTime < current.Time.Date.Add(SJ07JwNtTWEYoPoAAxhD(P_0)))
									{
										int num3 = 4;
										num4 = num3;
										goto IL_0082;
									}
								}
								else if (dateTime < current.Time.Date.Add(P_0.StartTime) || CYbC4qNtUtWT5O4GovYu(dateTime, current.Time.Date.Add(IxdL1MNttgwL9EnhX3FZ(P_0))))
								{
									break;
								}
							}
							goto IL_00d8;
							IL_0082:
							while (true)
							{
								switch (num4)
								{
								case 6:
									break;
								case 8:
									goto IL_00f0;
								case 1:
									goto IL_011b;
								case 18:
									goto end_IL_00f0;
								case 11:
									dictionary[current.RFAnpA8FQSP] += Math.Abs(current.Size);
									goto end_IL_00f0;
								case 3:
									Values.Add(current.RFAnpA8FQSP, Math.Abs(current.Size));
									num4 = 18;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
									{
										num4 = 13;
									}
									continue;
								case 9:
									if (current.gC0npJCO1It == Side.Buy)
									{
										if (r08nuvCseXq().Contains(item2))
										{
											num4 = 2;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
											{
												num4 = 2;
											}
											continue;
										}
										goto case 5;
									}
									goto IL_0383;
								case 4:
									if (!CYbC4qNtUtWT5O4GovYu(dateTime, current.Time.Date.Add(IxdL1MNttgwL9EnhX3FZ(P_0))))
									{
										num4 = 6;
										continue;
									}
									goto end_IL_00f0;
								case 5:
									r08nuvCseXq().Add(item2);
									goto IL_0491;
								case 7:
									if (current.gC0npJCO1It == Side.Sell)
									{
										num4 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 10;
								case 2:
								case 17:
									goto IL_0383;
								case 12:
									goto IL_0395;
								case 10:
									num5++;
									goto IL_041d;
								case 15:
									if (current.gC0npJCO1It != Side.Buy)
									{
										goto case 7;
									}
									goto case 14;
								default:
									if (a6tnuaws77p().Contains(item))
									{
										goto case 10;
									}
									goto case 13;
								case 16:
									goto IL_0491;
								case 13:
									a6tnuaws77p().Add(item);
									num4 = 10;
									continue;
								case 14:
									if (r08nuvCseXq().Contains(item))
									{
										goto case 7;
									}
									r08nuvCseXq().Add(item);
									goto case 10;
								}
								break;
								IL_0383:
								if (current.gC0npJCO1It == Side.Sell)
								{
									if (a6tnuaws77p().Contains(item2))
									{
										num4 = 3;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
										{
											num4 = 16;
										}
										continue;
									}
									a6tnuaws77p().Add(item2);
								}
								goto IL_0491;
							}
							goto IL_00d8;
							IL_0395:
							num5 = current.Mftnp7teFeU();
							goto IL_041d;
							IL_0491:
							if (!Values.ContainsKey(current.RFAnpA8FQSP))
							{
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
								{
									num4 = 3;
								}
								goto IL_0082;
							}
							goto IL_011b;
							IL_041d:
							if (num5 <= current.pFMnphjxvbp())
							{
								item = MI4nfsnnUf3PYtFXkT2T.zaMnnyYmoGU(num5, num2);
								num4 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
								{
									num4 = 15;
								}
								goto IL_0082;
							}
							goto IL_0491;
							IL_011b:
							dictionary = Values;
							num4 = 11;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
							{
								num4 = 4;
							}
							goto IL_0082;
							IL_00d8:
							if (current.RFAnpA8FQSP == current.PJZnpPumg2v)
							{
								item2 = MI4nfsnnUf3PYtFXkT2T.zaMnnyYmoGU(current.RFAnpA8FQSP, num2);
								num4 = 9;
								goto IL_0082;
							}
							goto IL_0395;
							continue;
							end_IL_00f0:
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
		}

		static lUWTRDnunZFkXi24q3ad()
		{
			C9lJPSNtyDU1Fh1mrmEx();
		}

		internal static bool mx79YjNt611qtWrabJme()
		{
			return MgoARrNtRDplYoE3MFx0 == null;
		}

		internal static lUWTRDnunZFkXi24q3ad QweVN0NtMImKTpK5ixYL()
		{
			return MgoARrNtRDplYoE3MFx0;
		}

		internal static void ngNfmANtOUZXxmS6OCCr(object P_0)
		{
			((HashSet<long>)P_0).Clear();
		}

		internal static object gEpDokNtq3nmj8WrKuS3(object P_0)
		{
			return ((fi0dX39rarBK9dp2dGQR)P_0).DataProvider;
		}

		internal static int TJcF2oNtI71xmUs3UGdA(object P_0)
		{
			return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
		}

		internal static DateTime Jq4LbgNtW38kgmPlcvMd(object P_0, DateTime P_1)
		{
			return ((ijsjhhnGTadfwpOyDdrx)P_0).ConvertTimeToLocal(P_1);
		}

		internal static TimeSpan IxdL1MNttgwL9EnhX3FZ(object P_0)
		{
			return ((x6MmFm9TFBbflXQCTQZJ)P_0).EndTime;
		}

		internal static bool CYbC4qNtUtWT5O4GovYu(DateTime P_0, DateTime P_1)
		{
			return P_0 > P_1;
		}

		internal static TimeSpan SJ07JwNtTWEYoPoAAxhD(object P_0)
		{
			return ((x6MmFm9TFBbflXQCTQZJ)P_0).StartTime;
		}

		internal static void C9lJPSNtyDU1Fh1mrmEx()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private CyB7CCiVHu1Q2FbDrIXm Rje9yyEIMsQ;

	private static readonly long fL59yZAk5ch;

	private bcRhS6iVnsrvu2TG1BEB BVC9yVC0fmC;

	private bool zIV9yC4k7xG;

	private ChartAlertSettings oxT9yrQXrwJ;

	private XBrush PTT9yKe9HxC;

	private XColor oBB9ym7FKDK;

	private XBrush lrW9yh3ZTW7;

	private XColor Jne9ywOWe4F;

	private XBrush gMP9y7bBQSf;

	private XPen JBe9y82GeXD;

	private XColor XPo9yAhdgAT;

	private XBrush Xmd9yP97dsS;

	private XColor EMy9yJ3aTpL;

	private XBrush spO9yFN6cA9;

	private XColor BFf9y35Mvsd;

	private XBrush Nq19ypBkLOU;

	private XPen nN89yuxmmI2;

	private XColor bnf9yzjs5ox;

	private BigTradesObjectType qqC9Z0ilh9A;

	private int p4l9Z2UxYIh;

	private int YXn9ZHAUVjL;

	private bool lpW9Zf2w463;

	private bool sNl9Z9vlXt1;

	private TimeSpan KQd9ZnA6PEC;

	private TimeSpan icS9ZGBKipO;

	private string f809ZYjBiGI;

	private FSHxRunpKYYjjiyQrvDW gmS9ZoR4tKG;

	private DateTime SdS9Zv85q9b;

	private int snh9ZB1tX4y;

	private long QQ99Zaebssj;

	private long I7D9Zi3qjIV;

	private Dictionary<int, lUWTRDnunZFkXi24q3ad> uB89ZldrKaP;

	private List<Jyfp9unp3Mi5n8KPGJXm> N4h9Z4BOPIQ;

	private bool CSw9ZDMicwb;

	private static x6MmFm9TFBbflXQCTQZJ GR6CmibWoGvHjtcdYwkv;

	[DataMember(Name = "MinVolumeParam")]
	public CyB7CCiVHu1Q2FbDrIXm t479yfW0eSS
	{
		get
		{
			return Rje9yyEIMsQ ?? (Rje9yyEIMsQ = new CyB7CCiVHu1Q2FbDrIXm(1000L));
		}
		set
		{
			Rje9yyEIMsQ = rje9yyEIMsQ;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsMinVolume")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DefaultValue(1000)]
	public long MinVolume
	{
		get
		{
			return t479yfW0eSS.Get((string)MYgQq2bWawPsWuiGQeSR(this));
		}
		set
		{
			if (wYkKimbWiO5nf1Zvvv0i(t479yfW0eSS, MYgQq2bWawPsWuiGQeSR(this), num, fL59yZAk5ch, long.MaxValue))
			{
				n7TkqObWljZEbkQIGmf9(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690763525));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193006240));
			}
		}
	}

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "MaxVolumeParam")]
	public bcRhS6iVnsrvu2TG1BEB wnK9yoWkGqj
	{
		get
		{
			return BVC9yVC0fmC ?? (BVC9yVC0fmC = new bcRhS6iVnsrvu2TG1BEB(null));
		}
		set
		{
			BVC9yVC0fmC = bVC9yVC0fmC;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsMaxVolume")]
	[DefaultValue(null)]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	public long? MaxVolume
	{
		get
		{
			return wnK9yoWkGqj.Get(base.SettingsLongKey);
		}
		set
		{
			if (wnK9yoWkGqj.aWyiVYE1DZj(base.SettingsLongKey, num, 10L))
			{
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161601904));
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087096864));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsAggregate")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DataMember(Name = "Aggregate")]
	public bool Aggregate
	{
		get
		{
			return zIV9yC4k7xG;
		}
		set
		{
			if (flag != zIV9yC4k7xG)
			{
				zIV9yC4k7xG = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBA86AD));
			}
		}
	}

	[DataMember(Name = "Alert")]
	[Browsable(true)]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsAlert")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	public ChartAlertSettings Alert
	{
		get
		{
			return oxT9yrQXrwJ ?? (oxT9yrQXrwJ = new ChartAlertSettings());
		}
		set
		{
			if (!ts3u17bW4x66RWpJHx3i(chartAlertSettings, oxT9yrQXrwJ))
			{
				oxT9yrQXrwJ = chartAlertSettings;
				n7TkqObWljZEbkQIGmf9(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD18E53));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsBuysSelectionColor")]
	[DataMember(Name = "BuysSelectionColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public XColor BuysSelectionColor
	{
		get
		{
			return oBB9ym7FKDK;
		}
		set
		{
			if (!(xColor == oBB9ym7FKDK))
			{
				oBB9ym7FKDK = xColor;
				PTT9yKe9HxC = new XBrush(oBB9ym7FKDK);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063076211));
			}
		}
	}

	[DataMember(Name = "BuysColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsBuysObjectBackColor")]
	public XColor BuysObjectBackColor
	{
		get
		{
			return Jne9ywOWe4F;
		}
		set
		{
			if (!JIGHLDbWDoP5Gnh5gPN9(xColor, Jne9ywOWe4F))
			{
				Jne9ywOWe4F = xColor;
				lrW9yh3ZTW7 = new XBrush(Jne9ywOWe4F);
				n7TkqObWljZEbkQIGmf9(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801737384));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
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

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsBuysObjectBorderColor")]
	[DataMember(Name = "BuysObjectBorderColor")]
	public XColor BuysObjectBorderColor
	{
		get
		{
			return XPo9yAhdgAT;
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
				case 2:
					gMP9y7bBQSf = new XBrush(XPo9yAhdgAT);
					JBe9y82GeXD = new XPen(gMP9y7bBQSf, 1);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839402074));
					return;
				case 0:
					return;
				case 1:
					if (!(xColor == XPo9yAhdgAT))
					{
						XPo9yAhdgAT = xColor;
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "SellsSelectionColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsSellsSelectionColor")]
	public XColor SellsSelectionColor
	{
		get
		{
			return EMy9yJ3aTpL;
		}
		set
		{
			if (!(xColor == EMy9yJ3aTpL))
			{
				EMy9yJ3aTpL = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Xmd9yP97dsS = new XBrush(EMy9yJ3aTpL);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583056780));
			}
		}
	}

	[DataMember(Name = "SellsObjectColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsSellsObjectBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public XColor SellsObjectBackColor
	{
		get
		{
			return BFf9y35Mvsd;
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
					BFf9y35Mvsd = xColor;
					spO9yFN6cA9 = new XBrush(BFf9y35Mvsd);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BFCAC31));
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 1:
					if (xColor == BFf9y35Mvsd)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "SellsObjectBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsSellsObjectBorderColor")]
	public XColor SellsObjectBorderColor
	{
		get
		{
			return bnf9yzjs5ox;
		}
		set
		{
			if (xColor == bnf9yzjs5ox)
			{
				return;
			}
			bnf9yzjs5ox = xColor;
			Nq19ypBkLOU = new XBrush(bnf9yzjs5ox);
			nN89yuxmmI2 = new XPen(Nq19ypBkLOU, 1);
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
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
					OnPropertyChanged((string)g7ieV0bWbgLpbdSylOOy(0x735715F1 ^ 0x73537879));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsObjectType")]
	[DataMember(Name = "ObjectType")]
	public BigTradesObjectType ObjectType
	{
		get
		{
			return qqC9Z0ilh9A;
		}
		set
		{
			if (bigTradesObjectType != qqC9Z0ilh9A)
			{
				qqC9Z0ilh9A = bigTradesObjectType;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520395831));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
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

	[DataMember(Name = "ObjectMinSize")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsMinSize")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public int ObjectMinSize
	{
		get
		{
			return p4l9Z2UxYIh;
		}
		set
		{
			num = Math.Max(10, xs0jjbbWNBL8Fi15NNoR(num, 200));
			if (num == p4l9Z2UxYIh)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
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
				p4l9Z2UxYIh = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x60666211));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsMaxSize")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "ObjectMaxSize")]
	public int ObjectMaxSize
	{
		get
		{
			return YXn9ZHAUVjL;
		}
		set
		{
			num = Math.Min(200, xjNLDPbWkmUHEw0LP4iN(num, 10));
			if (num == YXn9ZHAUVjL)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
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
				YXn9ZHAUVjL = num;
				OnPropertyChanged((string)g7ieV0bWbgLpbdSylOOy(-1461292091 ^ -1461576149));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsShowVolume")]
	[DataMember(Name = "ShowValues")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public bool ShowValues
	{
		get
		{
			return lpW9Zf2w463;
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
					if (flag != lpW9Zf2w463)
					{
						lpW9Zf2w463 = flag;
						n7TkqObWljZEbkQIGmf9(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176260061));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsUseTimeFilter")]
	[DataMember(Name = "UseTimeFilter")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsTimeFilter")]
	public bool UseTimeFilter
	{
		get
		{
			return sNl9Z9vlXt1;
		}
		set
		{
			if (flag != sNl9Z9vlXt1)
			{
				sNl9Z9vlXt1 = flag;
				snh9ZB1tX4y = 0;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842328717));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsStartTime")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsTimeFilter")]
	[DataMember(Name = "StartTime")]
	public TimeSpan StartTime
	{
		get
		{
			return KQd9ZnA6PEC;
		}
		set
		{
			if (!Wpt4FmbW1lIX3QHvSX1x(timeSpan, KQd9ZnA6PEC))
			{
				KQd9ZnA6PEC = timeSpan;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				snh9ZB1tX4y = 0;
				n7TkqObWljZEbkQIGmf9(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F0AF51));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsEndTime")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsTimeFilter")]
	[DataMember(Name = "EndTime")]
	public TimeSpan EndTime
	{
		get
		{
			return icS9ZGBKipO;
		}
		set
		{
			if (!(timeSpan == icS9ZGBKipO))
			{
				icS9ZGBKipO = timeSpan;
				snh9ZB1tX4y = 0;
				OnPropertyChanged((string)g7ieV0bWbgLpbdSylOOy(-203064540 ^ -203081818));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
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

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	[SpecialName]
	private Dictionary<int, lUWTRDnunZFkXi24q3ad> zb19yU2QuWC()
	{
		return uB89ZldrKaP ?? (uB89ZldrKaP = new Dictionary<int, lUWTRDnunZFkXi24q3ad>());
	}

	public x6MmFm9TFBbflXQCTQZJ()
	{
		lkx7VPbW5PuVICNikYtl();
		f809ZYjBiGI = "";
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 6:
				ObjectMaxSize = 80;
				ShowValues = false;
				num = 5;
				break;
			case 2:
				MinVolume = 1000L;
				MaxVolume = null;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				Aggregate = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
				{
					num = 0;
				}
				break;
			default:
				BuysSelectionColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				BuysObjectBackColor = Color.FromArgb(127, 30, 144, byte.MaxValue);
				BuysObjectBorderColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
				num = 4;
				break;
			case 4:
			{
				SellsSelectionColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				SellsObjectBackColor = Color.FromArgb(127, 178, 34, 34);
				SellsObjectBorderColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				int num2 = 7;
				num = num2;
				break;
			}
			case 5:
				UseTimeFilter = false;
				StartTime = TimeSpan.Zero;
				EndTime = TimeSpan.Zero;
				return;
			case 7:
				ObjectType = BigTradesObjectType.Rectangle;
				ObjectMinSize = 20;
				num = 6;
				break;
			}
		}
	}

	protected override void Execute()
	{
		int num;
		if (base.ClearData)
		{
			IxQ9y0VlnWV();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_00a5;
		IL_00a5:
		igC9TpcrgiQ(((GI2ck09PRdT1QIUcDtaR)O6HJE7bWSRT1upFgytet(base.DataProvider)).DGw9POoEmcE(), _0020: false);
		int num2 = snh9ZB1tX4y;
		goto IL_0043;
		IL_0043:
		if (num2 < base.DataProvider.Count)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		snh9ZB1tX4y = xjNLDPbWkmUHEw0LP4iN(base.DataProvider.Count - 2, 0);
		return;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				if (uB89ZldrKaP.ContainsKey(num2))
				{
					uB89ZldrKaP[num2].OuknuYcS5jX(this);
				}
				num2++;
				num = 3;
				continue;
			case 2:
				goto IL_00a5;
			}
			break;
		}
		goto IL_0043;
	}

	private void Clear()
	{
		gmS9ZoR4tKG = null;
		SdS9Zv85q9b = DateTime.MinValue;
		snh9ZB1tX4y = 0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				QQ99Zaebssj = 0L;
				I7D9Zi3qjIV = 0L;
				zb19yU2QuWC().Clear();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
				{
					num = 0;
				}
				continue;
			}
			List<Jyfp9unp3Mi5n8KPGJXm> n4h9Z4BOPIQ = N4h9Z4BOPIQ;
			if (n4h9Z4BOPIQ == null)
			{
				return;
			}
			n4h9Z4BOPIQ.Clear();
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
			{
				num = 0;
			}
		}
	}

	private void igC9TpcrgiQ(List<KHxL9R9JZMZ1sv2HFY9P> P_0, bool P_1)
	{
		double num = (base.DataProvider.Symbol.IsDenomination ? (1.0 / (double)base.DataProvider.Symbol.NOvnY43A4X4()) : ((double)base.DataProvider.Symbol.NOvnY43A4X4()));
		long num2 = Math.Max(fL59yZAk5ch, (long)((double)MinVolume * num));
		long num3 = ((MaxVolume > 0) ? ((long)((double?)MaxVolume * num).Value) : long.MaxValue);
		if (!Aggregate)
		{
			foreach (KHxL9R9JZMZ1sv2HFY9P item in P_0)
			{
				if (!(item.Time < SdS9Zv85q9b))
				{
					SdS9Zv85q9b = item.Time;
					if (item.Size >= num2 && item.Size <= num3)
					{
						FSHxRunpKYYjjiyQrvDW fSHxRunpKYYjjiyQrvDW = new FSHxRunpKYYjjiyQrvDW(item);
						s2q9TuUiZCj(fSHxRunpKYYjjiyQrvDW, !P_1);
					}
				}
			}
			return;
		}
		foreach (KHxL9R9JZMZ1sv2HFY9P item2 in P_0)
		{
			if (item2.Time < SdS9Zv85q9b)
			{
				continue;
			}
			SdS9Zv85q9b = item2.Time;
			if (gmS9ZoR4tKG == null)
			{
				gmS9ZoR4tKG = new FSHxRunpKYYjjiyQrvDW(item2);
				continue;
			}
			if (gmS9ZoR4tKG.Time == item2.Time && gmS9ZoR4tKG.gC0npJCO1It == item2.Side)
			{
				gmS9ZoR4tKG.WfWnpmx1iha(item2.Price, item2.Size);
				continue;
			}
			if (gmS9ZoR4tKG.Size >= num2 && gmS9ZoR4tKG.Size <= num3 && !gmS9ZoR4tKG.Ea9npF3hK6X)
			{
				s2q9TuUiZCj(gmS9ZoR4tKG, !P_1);
			}
			gmS9ZoR4tKG = new FSHxRunpKYYjjiyQrvDW(item2);
		}
		if (gmS9ZoR4tKG != null && !gmS9ZoR4tKG.Ea9npF3hK6X && gmS9ZoR4tKG.Size >= num2 && gmS9ZoR4tKG.Size <= num3)
		{
			gmS9ZoR4tKG.Ea9npF3hK6X = true;
			s2q9TuUiZCj(gmS9ZoR4tKG, !P_1);
		}
	}

	private void s2q9TuUiZCj(FSHxRunpKYYjjiyQrvDW P_0, bool P_1)
	{
		int key = bnk9TzRLv3n(P_0.Time.ToOADate(), -1);
		if (!zb19yU2QuWC().ContainsKey(key))
		{
			zb19yU2QuWC().Add(key, new lUWTRDnunZFkXi24q3ad());
		}
		zb19yU2QuWC()[key].tHEnuGmxl9K(P_0);
		int num;
		if (QQ99Zaebssj != 0L && I7D9Zi3qjIV != 0L)
		{
			num = 11;
			goto IL_0009;
		}
		goto IL_0207;
		IL_0207:
		QQ99Zaebssj = P_0.Size;
		I7D9Zi3qjIV = P_0.Size;
		num = 2;
		goto IL_0009;
		IL_0009:
		bool flag = default(bool);
		string arg = default(string);
		DateTime dateTime = default(DateTime);
		string arg2 = default(string);
		while (true)
		{
			switch (num)
			{
			case 9:
				if (!flag)
				{
					return;
				}
				arg = base.DataProvider.Symbol.FormatRawPrice(P_0.RFAnpA8FQSP / r32vyAbWslOu3abl5K7u(base.DataProvider), _0020: true);
				num = 8;
				continue;
			case 4:
				if (StartTime <= EndTime)
				{
					if (!PmE91ibWLJaRBW2EwLtK(dateTime, P_0.Time.Date.Add(StartTime)))
					{
						num = 10;
						continue;
					}
					goto IL_00e1;
				}
				if (!PmE91ibWLJaRBW2EwLtK(dateTime, P_0.Time.Date.Add(StartTime)))
				{
					goto case 9;
				}
				goto case 1;
			case 6:
			{
				AddAlert(Alert, string.Format(Resources.IndicatorBigTradesAlert, P_0.gC0npJCO1It, arg, arg2));
				int num2 = 7;
				num = num2;
				continue;
			}
			case 3:
				return;
			case 7:
				return;
			default:
				if (Alert.IsActive)
				{
					flag = true;
					if (UseTimeFilter)
					{
						dateTime = base.Canvas.ConvertTimeToLocal(P_0.Time);
						num = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
						{
							num = 4;
						}
						continue;
					}
					goto case 9;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num = 3;
				}
				continue;
			case 5:
				break;
			case 8:
				arg2 = (string)WXQPlNbWcDFAhhCP6bDT(jX61UrbWXUgLvdDo9HfY(base.DataProvider), P_0.Size);
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num = 2;
				}
				continue;
			case 12:
				I7D9Zi3qjIV = G7W8V5bWxnTC84ChVoWG(I7D9Zi3qjIV, P_0.Size);
				if (!P_1)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 0;
				}
				continue;
			case 2:
			case 11:
				QQ99Zaebssj = Math.Min(QQ99Zaebssj, P_0.Size);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
				{
					num = 12;
				}
				continue;
			case 1:
				if (xe4TXNbWeRwcSM2KCElO(dateTime, P_0.Time.Date.Add(EndTime)))
				{
					flag = false;
				}
				goto case 9;
			case 10:
				{
					if (!(dateTime > P_0.Time.Date.Add(EndTime)))
					{
						goto case 9;
					}
					goto IL_00e1;
				}
				IL_00e1:
				flag = false;
				num = 9;
				continue;
			}
			break;
		}
		goto IL_0207;
	}

	private int bnk9TzRLv3n(double P_0, int P_1)
	{
		int num = 4;
		int num2 = num;
		int num4 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		double[] date = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return num4;
			default:
				if (num5 < num3)
				{
					num4 = (num5 + num3 - P_1) / 2;
					if (date[num4] < P_0 - 1E-07)
					{
						num5 = num4 + P_1 + 1;
						num2 = 6;
						break;
					}
					goto case 1;
				}
				return num5;
			case 3:
				if (date.Length == 0)
				{
					return 0;
				}
				if (!(P_0 <= date[date.Length - 1]))
				{
					return date.Length - 1;
				}
				num5 = 0;
				num3 = date.Length - 1;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				date = base.Helper.Date;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				num3 = num4 + P_1;
				goto default;
			case 1:
				if (date[num4] > P_0 + 1E-07)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	private void IxQ9y0VlnWV()
	{
		Clear();
		if (base.DataProvider == null || base.DataProvider.Count == 0)
		{
			return;
		}
		hb81CfbWjrLW19B8jYK0(base.DataProvider, f809ZYjBiGI);
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				f809ZYjBiGI = Guid.NewGuid().ToString();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
			{
				owRcNi98PvGJmqNtfWpH owRcNi98PvGJmqNtfWpH = new owRcNi98PvGJmqNtfWpH(MaxVolume.GetValueOrDefault(), MinVolume, Aggregate);
				base.DataProvider.GGGlnaVMwtf(f809ZYjBiGI, owRcNi98PvGJmqNtfWpH, this);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public void V6Hl9CmUBcW(string P_0, ICollection<byte[]> P_1)
	{
		if (f809ZYjBiGI != P_0)
		{
			return;
		}
		Clear();
		foreach (byte[] item in P_1)
		{
			dtWXJ3nu27wV4q2ef9iH dtWXJ3nu27wV4q2ef9iH = new dtWXJ3nu27wV4q2ef9iH(item);
			while (dtWXJ3nu27wV4q2ef9iH.Read())
			{
				FSHxRunpKYYjjiyQrvDW lastItem = dtWXJ3nu27wV4q2ef9iH.LastItem;
				if (lastItem != null)
				{
					SdS9Zv85q9b = lastItem.Time;
					s2q9TuUiZCj(lastItem, _0020: false);
				}
			}
		}
	}

	public void jn1l9rlHE2X(string P_0, IDataReader<TickEvent> P_1)
	{
		List<KHxL9R9JZMZ1sv2HFY9P> list = new List<KHxL9R9JZMZ1sv2HFY9P>();
		while (P_1.Read())
		{
			TickEvent lastItem = P_1.LastItem;
			if (lastItem != null)
			{
				list.Add(new KHxL9R9JZMZ1sv2HFY9P
				{
					Time = lastItem.Time,
					Price = lastItem.Price,
					Size = lastItem.Size,
					Side = lastItem.Side
				});
			}
		}
		igC9TpcrgiQ(list, _0020: true);
		snh9ZB1tX4y = 0;
	}

	public void LTel9KrLkYM()
	{
		IxQ9y0VlnWV();
	}

	public override void Render(DxVisualQueue P_0)
	{
		base.Render(P_0);
		if (hpMa2XbWExWJ97dWvwey(zb19yU2QuWC()) == 0)
		{
			return;
		}
		int num;
		if (N4h9Z4BOPIQ == null)
		{
			num = 7;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
			{
				num = 5;
			}
			goto IL_0009;
		}
		goto IL_0835;
		IL_08b0:
		N4h9Z4BOPIQ = new List<Jyfp9unp3Mi5n8KPGJXm>();
		goto IL_086e;
		IL_0835:
		lc0mRMbWQfxgSlBKIUfU(N4h9Z4BOPIQ);
		goto IL_086e;
		IL_086e:
		int num2 = Math.Max(10, xs0jjbbWNBL8Fi15NNoR(200, ObjectMinSize));
		num = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
		{
			num = 5;
		}
		goto IL_0009;
		IL_0009:
		List<FSHxRunpKYYjjiyQrvDW>.Enumerator enumerator2 = default(List<FSHxRunpKYYjjiyQrvDW>.Enumerator);
		int num16 = default(int);
		int num15 = default(int);
		int num13 = default(int);
		XBrush xBrush = default(XBrush);
		DateTime dateTime = default(DateTime);
		XPen pen = default(XPen);
		Point[] points = default(Point[]);
		long num9 = default(long);
		Point[] array = default(Point[]);
		int num11 = default(int);
		int num12 = default(int);
		double num14 = default(double);
		double num8 = default(double);
		int index = default(int);
		int num6 = default(int);
		int num7 = default(int);
		string text = default(string);
		Size size = default(Size);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 8:
				try
				{
					while (enumerator2.MoveNext())
					{
						while (true)
						{
							FSHxRunpKYYjjiyQrvDW current2 = enumerator2.Current;
							int num10;
							if (UseTimeFilter)
							{
								num10 = 10;
								goto IL_0086;
							}
							goto IL_0537;
							IL_0086:
							while (true)
							{
								int num17;
								XPen jBe9y82GeXD;
								Rect rect;
								switch (num10)
								{
								case 10:
									break;
								case 17:
									N4h9Z4BOPIQ.Add(new Jyfp9unp3Mi5n8KPGJXm(new Rect(new Point(num16 - num15, num13 - num15), new Point(num16 + num15, num13 + num15)), current2));
									xBrush = ((current2.gC0npJCO1It == Side.Buy) ? lrW9yh3ZTW7 : spO9yFN6cA9);
									num10 = 15;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
									{
										num10 = 11;
									}
									continue;
								case 13:
									goto IL_0291;
								case 4:
									if (xe4TXNbWeRwcSM2KCElO(dateTime, current2.Time.Date.Add(EndTime)))
									{
										num10 = 7;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
										{
											num10 = 3;
										}
										continue;
									}
									goto IL_0537;
								case 22:
									P_0.DrawPolygon(pen, points);
									num10 = 16;
									continue;
								case 1:
									goto end_IL_0086;
								case 5:
									if (num9 > 0)
									{
										num10 = 20;
										continue;
									}
									goto IL_055c;
								case 8:
									goto IL_03e0;
								case 14:
									if (!PmE91ibWLJaRBW2EwLtK(dateTime, current2.Time.Date.Add(StartTime)))
									{
										if (xe4TXNbWeRwcSM2KCElO(dateTime, current2.Time.Date.Add(EndTime)))
										{
											num10 = 12;
											continue;
										}
										goto IL_0537;
									}
									goto end_IL_0376;
								case 15:
									if (current2.gC0npJCO1It != Side.Buy)
									{
										num17 = 6;
										goto IL_0082;
									}
									jBe9y82GeXD = JBe9y82GeXD;
									goto IL_0702;
								case 9:
									if (current2.Size != I7D9Zi3qjIV)
									{
										num10 = 2;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
										{
											num10 = 5;
										}
										continue;
									}
									goto IL_055c;
								case 19:
									array[0] = new Point(num16 - num15, num13);
									array[1] = new Point(num16, num13 - num15);
									array[2] = new Point(num16 + num15, num13);
									array[3] = new Point(num16, num13 + num15);
									Wqf9VLbWOTZbx0bchnFj(P_0, xBrush, array);
									P_0.DrawPolygon(pen, array);
									goto case 11;
								case 2:
									goto IL_0537;
								case 3:
									switch (ObjectType)
									{
									case BigTradesObjectType.Triangle:
										break;
									default:
										goto IL_0341;
									case BigTradesObjectType.Rectangle:
										goto IL_03e0;
									case BigTradesObjectType.Circle:
										goto IL_044e;
									case BigTradesObjectType.Diamond:
										goto IL_05cb;
									}
									goto IL_0291;
								case 21:
									goto IL_05cb;
								case 11:
								case 16:
								case 23:
									if (base.Settings.StockViewType != StockViewType.Clusters)
									{
										int num18 = (int)Math.Max(((IChartCanvas)WJ3bwbbWqdjrklaHh34V(this)).ColumnWidth / 2.0 - 1.0, 2.0);
										P_0.FillRectangle((current2.gC0npJCO1It == Side.Buy) ? PTT9yKe9HxC : Xmd9yP97dsS, new Rect(new Point(num16 - num18, num11), new Point(num16 + num18 + 1, num12)));
										num10 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
										{
											num10 = 0;
										}
										continue;
									}
									goto end_IL_0376;
								case 20:
									num14 = (double)(current2.Size - QQ99Zaebssj) / ((double)num9 / 9.0);
									goto IL_055c;
								case 18:
									num11 = (int)SUvsd2bWRJCO5cCpsjSZ(this, U2owJlbWgSXVwkNs9a23(base.DataProvider, x5hp8hbWdCfxvoCRW2Zo(current2)) + base.DataProvider.Step / 2.0);
									num12 = (int)SUvsd2bWRJCO5cCpsjSZ(this, base.DataProvider.emBlnYovsAq(current2.Mftnp7teFeU()) - fW2YiDbW6P6DNiMugPMJ(base.DataProvider) / 2.0);
									num13 = (int)((double)(num11 + num12) / 2.0);
									num14 = 9.0;
									num10 = 9;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
									{
										num10 = 7;
									}
									continue;
								default:
									goto end_IL_0376;
								case 6:
									{
										jBe9y82GeXD = nN89yuxmmI2;
										goto IL_0702;
									}
									IL_055c:
									num15 = (int)(((double)num2 + num8 * num14) / 2.0);
									num10 = 17;
									continue;
									IL_05cb:
									array = new Point[4];
									num10 = 19;
									continue;
									IL_044e:
									P_0.FillEllipse(xBrush, new Point(num16, num13), num15, num15);
									P_0.DrawEllipse(pen, new Point(num16, num13), num15, num15);
									goto case 11;
									IL_0341:
									num17 = 23;
									goto IL_0082;
									IL_0702:
									pen = jBe9y82GeXD;
									num10 = 3;
									continue;
									IL_03e0:
									rect = new Rect(new Point(num16 - num15, num13 - num15), new Point(num16 + num15, num13 + num15));
									WecJpcbWMjY5M2SDn2pa(P_0, xBrush, rect);
									P_0.DrawRectangle(pen, rect);
									num17 = 11;
									goto IL_0082;
									IL_0082:
									num10 = num17;
									continue;
								}
								dateTime = base.Canvas.ConvertTimeToLocal(current2.Time);
								if (StartTime <= EndTime)
								{
									num10 = 14;
									continue;
								}
								if (PmE91ibWLJaRBW2EwLtK(dateTime, current2.Time.Date.Add(StartTime)))
								{
									num10 = 4;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
									{
										num10 = 1;
									}
									continue;
								}
								goto IL_0537;
								IL_0291:
								points = new Point[3]
								{
									new Point(num16, num13 - num15),
									new Point(num16 + num15, num13 + num15),
									new Point(num16 - num15, num13 + num15)
								};
								P_0.FillPolygon(xBrush, points);
								num10 = 22;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
								{
									num10 = 15;
								}
								continue;
								end_IL_0086:
								break;
							}
							continue;
							IL_0537:
							num16 = (int)GetX(index);
							num10 = 18;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
							{
								num10 = 2;
							}
							goto IL_0086;
							continue;
							end_IL_0376:
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				if (ShowValues)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
					{
						num = 0;
					}
					continue;
				}
				goto IL_07ae;
			case 1:
				foreach (KeyValuePair<long, long> item in zb19yU2QuWC()[index].Values)
				{
					int num5 = 3;
					while (true)
					{
						switch (num5)
						{
						case 1:
							break;
						case 3:
							num6 = (int)GetX(index);
							num7 = (int)GetY(U2owJlbWgSXVwkNs9a23(base.DataProvider, item.Key));
							num5 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
							{
								num5 = 0;
							}
							continue;
						default:
							text = base.DataProvider.Symbol.FormatRawSizeShort(item.Value);
							num5 = 2;
							continue;
						case 2:
							size = base.Canvas.ChartFont.GetSize(text);
							num5 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
							{
								num5 = 0;
							}
							continue;
						}
						break;
					}
					P_0.DrawString(rect: new Rect(new Point((double)num6 - size.Width / 2.0 - 2.0, (double)num7 - size.Height / 2.0 - 2.0), new Point((double)num6 + size.Width / 2.0 + 2.0, (double)num7 + size.Height / 2.0 + 2.0)), text: text, font: (XFont)f5AmqebWIhrl76KgtNV3(base.Canvas), brush: base.Theme.ChartFontBrush, alignment: XTextAlignment.Center);
				}
				goto IL_07ae;
			case 2:
				if (num3 < num2)
				{
					num3 = num2;
					num = 6;
					continue;
				}
				goto case 6;
			case 7:
				goto IL_08b0;
			case 9:
				if (num4 >= base.Canvas.Count)
				{
					num = 4;
					continue;
				}
				goto case 3;
			case 6:
				num8 = (double)(num3 - num2) / 9.0;
				num9 = I7D9Zi3qjIV - QQ99Zaebssj;
				num4 = 0;
				goto case 9;
			case 3:
				index = base.Canvas.GetIndex(num4);
				if (zb19yU2QuWC().ContainsKey(index))
				{
					enumerator2 = zb19yU2QuWC()[index].Items.GetEnumerator();
					int num19 = 8;
					num = num19;
					continue;
				}
				goto IL_07ae;
			case 5:
				{
					num3 = Math.Min(200, xjNLDPbWkmUHEw0LP4iN(ObjectMaxSize, 10));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
					{
						num = 2;
					}
					continue;
				}
				IL_07ae:
				num4++;
				num = 9;
				continue;
			}
			break;
		}
		goto IL_0835;
	}

	public override void RenderCursor(DxVisualQueue P_0, int P_1, Point P_2, ref int P_3)
	{
		if ((Keyboard.Modifiers & ModifierKeys.Control) == 0 || N4h9Z4BOPIQ == null)
		{
			return;
		}
		List<string> list = default(List<string>);
		int num;
		if (edTwebbWWg9k4jL9TfTG(N4h9Z4BOPIQ) != 0)
		{
			list = new List<string>();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
			{
				num = 10;
			}
		}
		else
		{
			num = 4;
		}
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		string current2 = default(string);
		Size size = default(Size);
		double num5 = default(double);
		double x = default(double);
		double num4 = default(double);
		double num6 = default(double);
		List<Tuple<string, Rect>> list2 = default(List<Tuple<string, Rect>>);
		double num8 = default(double);
		Rect rect = default(Rect);
		double num2 = default(double);
		double num9 = default(double);
		double num10 = default(double);
		Jyfp9unp3Mi5n8KPGJXm current = default(Jyfp9unp3Mi5n8KPGJXm);
		while (true)
		{
			switch (num)
			{
			default:
				try
				{
					while (true)
					{
						IL_0136:
						int num7;
						if (enumerator2.MoveNext())
						{
							current2 = enumerator2.Current;
							num7 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
							{
								num7 = 2;
							}
						}
						else
						{
							num7 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
							{
								num7 = 0;
							}
						}
						while (true)
						{
							switch (num7)
							{
							case 2:
								size = p3RMUCbWUdipo9Vdk5UE(qRl7MdbWta2IpWlW5ok0(base.Settings), current2);
								num5 = Math.Max(num5, size.Width);
								num7 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
								{
									num7 = 1;
								}
								continue;
							case 1:
								goto IL_00b9;
							case 0:
								break;
							}
							break;
							IL_00b9:
							Rect item = new Rect(x, num4 + num6 + 2.0, num5, size.Height + 2.0);
							num6 += item.Height + 2.0;
							list2.Add(new Tuple<string, Rect>(current2, item));
							goto IL_0136;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				num8 = P_2.X + 10.0;
				num = 5;
				continue;
			case 1:
				list2 = new List<Tuple<string, Rect>>();
				num = 6;
				continue;
			case 4:
				return;
			case 11:
				if (num8 + num5 + 10.0 >= base.Canvas.Rect.Right)
				{
					num8 -= num5 + 30.0;
					num = 12;
					continue;
				}
				goto IL_04fd;
			case 3:
				if (P_3 == 0)
				{
					num = 13;
					continue;
				}
				break;
			case 2:
			{
				P_0.DrawRectangle(base.Theme.ChartAxisPen, rect);
				using List<Tuple<string, Rect>>.Enumerator enumerator3 = list2.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Tuple<string, Rect> current3 = enumerator3.Current;
					P_0.DrawString(current3.Item1, (XFont)f5AmqebWIhrl76KgtNV3(WJ3bwbbWqdjrklaHh34V(this)), ((IChartTheme)sVPphqbWZLix2PPMKRd2(base.Canvas)).ChartFontBrush, new Rect(current3.Item2.X + num2, current3.Item2.Y + num9, current3.Item2.Width, current3.Item2.Height));
				}
				int num11 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num11 = 0;
				}
				switch (num11)
				{
				case 0:
					break;
				}
				return;
			}
			case 6:
				enumerator2 = list.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num = 0;
				}
				continue;
			case 12:
				num2 = 0.0 - (num5 + 30.0);
				goto IL_04fd;
			case 13:
				if (num10 + num6 + 10.0 >= QSiRAsbWTWEVtXF9AYw1(base.Canvas).Bottom)
				{
					num10 -= num6 + 30.0;
					num9 = 0.0 - (num6 + 30.0);
					num = 7;
					continue;
				}
				break;
			case 8:
				P_3 += (int)rect.Height + 5 + (int)num9;
				P_0.FillRectangle((XBrush)qbuU2RbWyNW35tm0JvPw(base.Theme), rect);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 1;
				}
				continue;
			case 9:
				if (list.Count == 0)
				{
					return;
				}
				x = P_2.X + 15.0;
				num4 = P_2.Y + 13.0 + (double)P_3;
				num5 = 0.0;
				num6 = 0.0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
				{
					num = 1;
				}
				continue;
			case 10:
			{
				using (List<Jyfp9unp3Mi5n8KPGJXm>.Enumerator enumerator = N4h9Z4BOPIQ.GetEnumerator())
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							current = enumerator.Current;
							if (!current.DfZnppvCu6P(P_2))
							{
								continue;
							}
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
							{
								num3 = 1;
							}
						}
						switch (num3)
						{
						case 1:
							list.Add(current.qvenpuNOups(base.DataProvider, ToString()));
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 9;
			}
			case 5:
				num2 = 0.0;
				num = 11;
				continue;
			case 7:
				break;
				IL_04fd:
				num10 = P_2.Y + 10.0;
				num9 = 0.0;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
				{
					num = 3;
				}
				continue;
			}
			rect = new Rect(num8, num10 + (double)P_3, num5 + 10.0, num6 + 7.0);
			num = 8;
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BuysSelectionColor = P_0.PaletteColor6;
		BuysObjectBackColor = new XColor(127, P_0.PaletteColor6);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				BuysObjectBorderColor = P_0.PaletteColor6;
				num = 2;
				break;
			case 2:
				SellsSelectionColor = oJbsQGbWVN6pLhDpDxU1(P_0);
				SellsObjectBackColor = new XColor(127, YXVp3HbWCBfcFExMlrxM(P_0.PaletteColor7));
				SellsObjectBorderColor = oJbsQGbWVN6pLhDpDxU1(P_0);
				base.ApplyColors(P_0);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		x6MmFm9TFBbflXQCTQZJ x6MmFm9TFBbflXQCTQZJ2 = (x6MmFm9TFBbflXQCTQZJ)P_0;
		wnK9yoWkGqj.Copy((IndicatorParam<long?>)mkVi9AbWrOnrmt4q6g31(x6MmFm9TFBbflXQCTQZJ2));
		t479yfW0eSS.Copy((IndicatorParam<long>)ICh0e0bWKAM65SIqoqZF(x6MmFm9TFBbflXQCTQZJ2));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				Alert.Copy((ChartAlertSettings)uMSgjBbWhL33hivttKDP(x6MmFm9TFBbflXQCTQZJ2), !P_1);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315E8703));
				BuysSelectionColor = x6MmFm9TFBbflXQCTQZJ2.BuysSelectionColor;
				num = 4;
				break;
			case 7:
				StartTime = hKDNGVbWAj5YQHFsFUdy(x6MmFm9TFBbflXQCTQZJ2);
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 0;
				}
				break;
			case 8:
				EndTime = Y3YppabWPg3MYBBn2fyy(x6MmFm9TFBbflXQCTQZJ2);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADBBC1B));
				OnPropertyChanged((string)g7ieV0bWbgLpbdSylOOy(-45476899 ^ -45187237));
				base.CopyTemplate(P_0, P_1);
				return;
			default:
				Aggregate = AZo648bWml0HXJFlQCYC(x6MmFm9TFBbflXQCTQZJ2);
				num = 6;
				break;
			case 4:
				BuysObjectBackColor = x6MmFm9TFBbflXQCTQZJ2.BuysObjectBackColor;
				BuysObjectBorderColor = GZNVgsbWwfAKjxcpUVdg(x6MmFm9TFBbflXQCTQZJ2);
				SellsSelectionColor = tWfrxIbW7QQlvN82tPKy(x6MmFm9TFBbflXQCTQZJ2);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				SellsObjectBackColor = x6MmFm9TFBbflXQCTQZJ2.SellsObjectBackColor;
				SellsObjectBorderColor = x6MmFm9TFBbflXQCTQZJ2.SellsObjectBorderColor;
				num = 3;
				break;
			case 3:
				ObjectType = x6MmFm9TFBbflXQCTQZJ2.ObjectType;
				ObjectMinSize = x6MmFm9TFBbflXQCTQZJ2.ObjectMinSize;
				num = 5;
				break;
			case 5:
				ObjectMaxSize = x6MmFm9TFBbflXQCTQZJ2.ObjectMaxSize;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				ShowValues = x6MmFm9TFBbflXQCTQZJ2.ShowValues;
				UseTimeFilter = T0tvKqbW8rrpcSpVXHE3(x6MmFm9TFBbflXQCTQZJ2);
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public XBrush GetSelection(int P_0, long P_1, int P_2)
	{
		if (base.ShowIndicator)
		{
			if (zb19yU2QuWC().ContainsKey(P_0))
			{
				lUWTRDnunZFkXi24q3ad lUWTRDnunZFkXi24q3ad = zb19yU2QuWC()[P_0];
				if (!lUWTRDnunZFkXi24q3ad.r08nuvCseXq().Contains(P_1))
				{
					if (lUWTRDnunZFkXi24q3ad.a6tnuaws77p().Contains(P_1))
					{
						return Xmd9yP97dsS;
					}
					goto IL_006e;
				}
				return PTT9yKe9HxC;
			}
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_006e;
			}
		}
		return null;
		IL_006e:
		return null;
	}

	public override string ToString()
	{
		if (!MaxVolume.HasValue)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BDC055C), MinVolume), 
			};
		}
		return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45187593), MinVolume, MaxVolume.GetValueOrDefault());
	}

	public override bool CheckNeedRedraw()
	{
		bool cSw9ZDMicwb = CSw9ZDMicwb;
		CSw9ZDMicwb = false;
		return cSw9ZDMicwb;
	}

	public override object Clone()
	{
		x6MmFm9TFBbflXQCTQZJ obj = new x6MmFm9TFBbflXQCTQZJ
		{
			t479yfW0eSS = t479yfW0eSS,
			wnK9yoWkGqj = wnK9yoWkGqj,
			Aggregate = Aggregate,
			Alert = Alert,
			BuysSelectionColor = BuysSelectionColor,
			BuysObjectBackColor = BuysObjectBackColor,
			BuysObjectBorderColor = BuysObjectBorderColor,
			SellsSelectionColor = SellsSelectionColor
		};
		vXG0r5bWJSAqlPQdfSVh(obj, SellsObjectBackColor);
		obj.SellsObjectBorderColor = SellsObjectBorderColor;
		obj.ObjectType = ObjectType;
		obj.ObjectMinSize = ObjectMinSize;
		XgtVNobWFj2sn3HNvZ8v(obj, ObjectMaxSize);
		vM95aVbW3hq2OW4lPdvE(obj, ShowValues);
		obj.UseTimeFilter = UseTimeFilter;
		obj.StartTime = StartTime;
		obj.EndTime = EndTime;
		return obj;
	}

	static x6MmFm9TFBbflXQCTQZJ()
	{
		KpaDYIbWpkVGTl0wqaxS();
	}

	internal static bool u26wR2bWvnT0UX1hd2i2()
	{
		return GR6CmibWoGvHjtcdYwkv == null;
	}

	internal static x6MmFm9TFBbflXQCTQZJ WiIrRZbWBXrqRbRZRtuB()
	{
		return GR6CmibWoGvHjtcdYwkv;
	}

	internal static object MYgQq2bWawPsWuiGQeSR(object P_0)
	{
		return ((IndicatorBase)P_0).SettingsLongKey;
	}

	internal static bool wYkKimbWiO5nf1Zvvv0i(object P_0, object P_1, long P_2, long P_3, long P_4)
	{
		return ((CyB7CCiVHu1Q2FbDrIXm)P_0).dUNiV9IB4Ic((string)P_1, P_2, P_3, P_4);
	}

	internal static void n7TkqObWljZEbkQIGmf9(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static bool ts3u17bW4x66RWpJHx3i(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static bool JIGHLDbWDoP5Gnh5gPN9(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static object g7ieV0bWbgLpbdSylOOy(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static int xs0jjbbWNBL8Fi15NNoR(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int xjNLDPbWkmUHEw0LP4iN(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool Wpt4FmbW1lIX3QHvSX1x(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static void lkx7VPbW5PuVICNikYtl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object O6HJE7bWSRT1upFgytet(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).ucml9PsYqY2();
	}

	internal static long G7W8V5bWxnTC84ChVoWG(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool PmE91ibWLJaRBW2EwLtK(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static bool xe4TXNbWeRwcSM2KCElO(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static int r32vyAbWslOu3abl5K7u(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
	}

	internal static object jX61UrbWXUgLvdDo9HfY(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Symbol;
	}

	internal static object WXQPlNbWcDFAhhCP6bDT(object P_0, long P_1)
	{
		return ((SymbolBase)P_0).FormatRawSizeFull(P_1);
	}

	internal static void hb81CfbWjrLW19B8jYK0(object P_0, object P_1)
	{
		((ypqMIv9maFM0tRwF0xMh)P_0).og0lnBFfnMH((string)P_1);
	}

	internal static int hpMa2XbWExWJ97dWvwey(object P_0)
	{
		return ((Dictionary<int, lUWTRDnunZFkXi24q3ad>)P_0).Count;
	}

	internal static void lc0mRMbWQfxgSlBKIUfU(object P_0)
	{
		((List<Jyfp9unp3Mi5n8KPGJXm>)P_0).Clear();
	}

	internal static long x5hp8hbWdCfxvoCRW2Zo(object P_0)
	{
		return ((FSHxRunpKYYjjiyQrvDW)P_0).pFMnphjxvbp();
	}

	internal static double U2owJlbWgSXVwkNs9a23(object P_0, long P_1)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).emBlnYovsAq(P_1);
	}

	internal static double SUvsd2bWRJCO5cCpsjSZ(object P_0, double P_1)
	{
		return ((IndicatorBase)P_0).GetY(P_1);
	}

	internal static double fW2YiDbW6P6DNiMugPMJ(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Step;
	}

	internal static void WecJpcbWMjY5M2SDn2pa(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void Wqf9VLbWOTZbx0bchnFj(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).FillPolygon((XBrush)P_1, (Point[])P_2);
	}

	internal static object WJ3bwbbWqdjrklaHh34V(object P_0)
	{
		return ((IndicatorBase)P_0).Canvas;
	}

	internal static object f5AmqebWIhrl76KgtNV3(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static int edTwebbWWg9k4jL9TfTG(object P_0)
	{
		return ((List<Jyfp9unp3Mi5n8KPGJXm>)P_0).Count;
	}

	internal static object qRl7MdbWta2IpWlW5ok0(object P_0)
	{
		return ((ChartSettings)P_0).ChartFont;
	}

	internal static Size p3RMUCbWUdipo9Vdk5UE(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static Rect QSiRAsbWTWEVtXF9AYw1(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static object qbuU2RbWyNW35tm0JvPw(object P_0)
	{
		return ((ChartTheme)P_0).ChartBackBrush;
	}

	internal static object sVPphqbWZLix2PPMKRd2(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static XColor oJbsQGbWVN6pLhDpDxU1(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor7;
	}

	internal static Color YXVp3HbWCBfcFExMlrxM(XColor P_0)
	{
		return P_0;
	}

	internal static object mkVi9AbWrOnrmt4q6g31(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).wnK9yoWkGqj;
	}

	internal static object ICh0e0bWKAM65SIqoqZF(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).t479yfW0eSS;
	}

	internal static bool AZo648bWml0HXJFlQCYC(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).Aggregate;
	}

	internal static object uMSgjBbWhL33hivttKDP(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).Alert;
	}

	internal static XColor GZNVgsbWwfAKjxcpUVdg(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).BuysObjectBorderColor;
	}

	internal static XColor tWfrxIbW7QQlvN82tPKy(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).SellsSelectionColor;
	}

	internal static bool T0tvKqbW8rrpcSpVXHE3(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).UseTimeFilter;
	}

	internal static TimeSpan hKDNGVbWAj5YQHFsFUdy(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).StartTime;
	}

	internal static TimeSpan Y3YppabWPg3MYBBn2fyy(object P_0)
	{
		return ((x6MmFm9TFBbflXQCTQZJ)P_0).EndTime;
	}

	internal static void vXG0r5bWJSAqlPQdfSVh(object P_0, XColor P_1)
	{
		((x6MmFm9TFBbflXQCTQZJ)P_0).SellsObjectBackColor = P_1;
	}

	internal static void XgtVNobWFj2sn3HNvZ8v(object P_0, int P_1)
	{
		((x6MmFm9TFBbflXQCTQZJ)P_0).ObjectMaxSize = P_1;
	}

	internal static void vM95aVbW3hq2OW4lPdvE(object P_0, bool P_1)
	{
		((x6MmFm9TFBbflXQCTQZJ)P_0).ShowValues = P_1;
	}

	internal static void KpaDYIbWpkVGTl0wqaxS()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
