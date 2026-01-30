using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;

namespace t89ByGiSoPOoaxpqO0hI;

[DataContract(Name = "DynamicLevelsIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("DynamicLevels", "DynamicLevels", true, Type = typeof(zZvbGliSYRewjSFHwRCl))]
internal sealed class zZvbGliSYRewjSFHwRCl : IndicatorBase
{
	private class M1oA8rirhWY0f4LX1I0P
	{
		public double[] Fviir7y9bEe;

		public double[] WMair8uSIgI;

		public double[] SJyirA3g5u2;

		public bool[] EwxirPOaMc7;

		public int Qk4irJp9sNO;

		public int bguirFrNWFf;

		public int Ew2ir3Ycoue;

		public readonly List<kc1ySkiruoHITKYTOIWw> gmairpK7q3f;

		internal static M1oA8rirhWY0f4LX1I0P enyrcCeUa8H2mOMEnSlX;

		public M1oA8rirhWY0f4LX1I0P()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			gmairpK7q3f = new List<kc1ySkiruoHITKYTOIWw>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Clear();
		}

		public void Clear()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					Qk4irJp9sNO = -1;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					WMair8uSIgI = new double[0];
					SJyirA3g5u2 = new double[0];
					EwxirPOaMc7 = new bool[0];
					StWpv2eU4lZkBMy1MhA9(gmairpK7q3f);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
					{
						num2 = 1;
					}
					break;
				default:
					bguirFrNWFf = 0;
					Ew2ir3Ycoue = 0;
					Fviir7y9bEe = new double[0];
					num2 = 3;
					break;
				}
			}
		}

		public void Kmjirw52t4v(int P_0, double P_1)
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			kc1ySkiruoHITKYTOIWw kc1ySkiruoHITKYTOIWw = default(kc1ySkiruoHITKYTOIWw);
			while (true)
			{
				switch (num2)
				{
				case 7:
					SJyirA3g5u2[num3] = (double)kc1ySkiruoHITKYTOIWw.urmiKny4sZv * P_1;
					EwxirPOaMc7[num3] = kc1ySkiruoHITKYTOIWw.AZIiKoVKuTk;
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					if (num3 >= P_0 - 1)
					{
						num2 = 6;
						break;
					}
					kc1ySkiruoHITKYTOIWw = gmairpK7q3f[num3];
					Fviir7y9bEe[num3] = (double)kc1ySkiruoHITKYTOIWw.lHkiKGa5El4 * P_1;
					WMair8uSIgI[num3] = (double)kc1ySkiruoHITKYTOIWw.PFiiKYU2fiP * P_1;
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num2 = 7;
					}
					break;
				default:
					Fviir7y9bEe = new double[P_0];
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					bguirFrNWFf = Math.Max(0, P_0 - 1);
					num2 = 2;
					break;
				case 4:
					SJyirA3g5u2 = new double[P_0];
					EwxirPOaMc7 = new bool[P_0];
					num3 = 0;
					goto case 5;
				case 1:
					WMair8uSIgI = new double[P_0];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
					{
						num2 = 4;
					}
					break;
				case 8:
					return;
				case 6:
					if (P_0 <= 1)
					{
						return;
					}
					Fviir7y9bEe[P_0 - 1] = Fviir7y9bEe[P_0 - 2];
					WMair8uSIgI[P_0 - 1] = WMair8uSIgI[P_0 - 2];
					SJyirA3g5u2[P_0 - 1] = SJyirA3g5u2[P_0 - 2];
					num2 = 8;
					break;
				case 2:
					Ew2ir3Ycoue = P_0;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static M1oA8rirhWY0f4LX1I0P()
		{
			jyBSu6eUDHsdXUcbRONS();
			RHJDD4eUb58Jo5xGpjKr();
		}

		internal static bool mmHimpeUiZqZY1Ir7uC8()
		{
			return enyrcCeUa8H2mOMEnSlX == null;
		}

		internal static M1oA8rirhWY0f4LX1I0P u0ChpdeUlTN3ZLQqCDo0()
		{
			return enyrcCeUa8H2mOMEnSlX;
		}

		internal static void StWpv2eU4lZkBMy1MhA9(object P_0)
		{
			((List<kc1ySkiruoHITKYTOIWw>)P_0).Clear();
		}

		internal static void jyBSu6eUDHsdXUcbRONS()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}

		internal static void RHJDD4eUb58Jo5xGpjKr()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal sealed class kc1ySkiruoHITKYTOIWw
	{
		public DateTime Time;

		public long wKIiKHPld98;

		public long QRyiKfqNstG;

		public long Volume;

		public long bwriK94DwxK;

		public long urmiKny4sZv;

		public long lHkiKGa5El4;

		public long PFiiKYU2fiP;

		public bool AZIiKoVKuTk;

		private readonly Dictionary<long, long> QtJiKv6MKTj;

		private static kc1ySkiruoHITKYTOIWw CwiGEreUNVE7qRsJj2LX;

		public kc1ySkiruoHITKYTOIWw(kc1ySkiruoHITKYTOIWw P_0)
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			QtJiKv6MKTj = new Dictionary<long, long>();
			base._002Ector();
			int num = 3;
			Dictionary<long, long>.Enumerator enumerator = default(Dictionary<long, long>.Enumerator);
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<long, long> current = enumerator.Current;
							QtJiKv6MKTj.Add(current.Key, current.Value);
						}
						int num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					wKIiKHPld98 = P_0.wKIiKHPld98;
					QRyiKfqNstG = P_0.QRyiKfqNstG;
					Volume = P_0.Volume;
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
					{
						num = 1;
					}
					break;
				default:
					QtJiKv6MKTj = new Dictionary<long, long>(P_0.QtJiKv6MKTj.Count);
					enumerator = P_0.QtJiKv6MKTj.GetEnumerator();
					num = 2;
					break;
				case 3:
					if (P_0 == null)
					{
						return;
					}
					Time = P_0.Time;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				}
			}
		}

		public void EZrirzIned0(IRawCluster P_0)
		{
			int num = 2;
			int num2 = num;
			IEnumerator<IRawClusterItem> enumerator = default(IEnumerator<IRawClusterItem>);
			long key = default(long);
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumerator = P_0.Items.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					Time = P_0.Time;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IRawClusterItem current = enumerator.Current;
							if (!QtJiKv6MKTj.ContainsKey(current.Price))
							{
								QtJiKv6MKTj.Add(current.Price, 0L);
							}
							Dictionary<long, long> qtJiKv6MKTj = QtJiKv6MKTj;
							int num3 = 2;
							while (true)
							{
								switch (num3)
								{
								case 1:
									qtJiKv6MKTj[key] += Mut4PAeUS7Wc9UWUZmLt(current);
									num3 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									break;
								default:
									goto end_IL_00f9;
								case 2:
									key = nMggodeU5MdfwHJLgkTH(current);
									num3 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
							continue;
							end_IL_00f9:
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						q2Sa6ceUxbskaqy6bSxx(enumerator);
					}
				}
				wKIiKHPld98 = ((wKIiKHPld98 == 0L) ? P_0.High : Math.Max(wKIiKHPld98, P_0.High));
				QRyiKfqNstG = ((QRyiKfqNstG == 0L) ? Xck7AIeULAJi1BFY0cKw(P_0) : Math.Min(QRyiKfqNstG, P_0.Low));
				Volume += lqOceNeUeQtSPgu17dpR(P_0);
				return;
			}
		}

		public void XW1iK0HOSt8()
		{
			bwriK94DwxK = 0L;
			urmiKny4sZv = 0L;
			Dictionary<long, long>.Enumerator enumerator = QtJiKv6MKTj.GetEnumerator();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				try
				{
					while (true)
					{
						if (!enumerator.MoveNext())
						{
							int num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								break;
							}
						}
						KeyValuePair<long, long> current = enumerator.Current;
						if (current.Value > bwriK94DwxK)
						{
							bwriK94DwxK = current.Value;
							urmiKny4sZv = current.Key;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			}
		}

		public void vCJiK2LO3aZ(double P_0)
		{
			int num = 3;
			int num10 = default(int);
			long num3 = default(long);
			int num6 = default(int);
			long num8 = default(long);
			long num7 = default(long);
			long num9 = default(long);
			long num5 = default(long);
			long num11 = default(long);
			long num4 = default(long);
			double num12 = default(double);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (num10 <= 1)
						{
							if (wKIiKHPld98 >= num3 + 1)
							{
								num2 = 19;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
								{
									num2 = 13;
								}
								continue;
							}
							goto IL_00e6;
						}
						num6 = 0;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						if (QtJiKv6MKTj.Count == 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						if (wKIiKHPld98 - QRyiKfqNstG <= 100000)
						{
							if (!(P_0 < 0.01))
							{
								if (!(P_0 > 0.99))
								{
									num8 = 0L;
									num7 = 0L;
									if (wKIiKHPld98 != 0L && QRyiKfqNstG != 0L)
									{
										num2 = 1;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
										{
											num2 = 4;
										}
										continue;
									}
									goto case 21;
								}
								lHkiKGa5El4 = wKIiKHPld98;
								num2 = 16;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 == 0)
								{
									num2 = 2;
								}
								continue;
							}
							num2 = 11;
							continue;
						}
						num2 = 12;
						continue;
					case 5:
						return;
					case 14:
						if (num9 >= num5)
						{
							num8 = num3;
							num11 += num9;
							goto IL_00c7;
						}
						goto case 17;
					default:
						if (num6 > 1)
						{
							num2 = 18;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 9;
					case 20:
						num10 = 0;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
						{
							num2 = 1;
						}
						continue;
					case 9:
						if (QRyiKfqNstG <= num4 - 1)
						{
							num4--;
							if (QtJiKv6MKTj.ContainsKey(num4))
							{
								num5 += QtJiKv6MKTj[num4];
							}
						}
						num6++;
						num2 = 23;
						continue;
					case 4:
						num8 = urmiKny4sZv;
						num2 = 24;
						continue;
					case 8:
						num11 += num5;
						goto IL_00c7;
					case 11:
						lHkiKGa5El4 = urmiKny4sZv;
						num2 = 22;
						continue;
					case 12:
						return;
					case 24:
						num7 = urmiKny4sZv;
						num11 = bwriK94DwxK;
						num12 = (double)Volume * P_0;
						goto IL_0405;
					case 18:
						if (num9 == num5 && num9 == 0L)
						{
							if (wKIiKHPld98 == num3)
							{
								num7 = num4;
							}
							if (QRyiKfqNstG == num4)
							{
								num8 = num3;
								num = 14;
								break;
							}
						}
						goto case 14;
					case 7:
						if (num8 < wKIiKHPld98 || num7 > QRyiKfqNstG)
						{
							num9 = 0L;
							num = 10;
							break;
						}
						goto case 21;
					case 13:
						if (QtJiKv6MKTj.ContainsKey(num3))
						{
							num9 += QtJiKv6MKTj[num3];
						}
						goto IL_00e6;
					case 2:
						return;
					case 22:
						PFiiKYU2fiP = urmiKny4sZv;
						return;
					case 16:
						PFiiKYU2fiP = QRyiKfqNstG;
						num = 5;
						break;
					case 15:
						return;
					case 10:
						num5 = 0L;
						num3 = num8;
						num2 = 6;
						continue;
					case 21:
						lHkiKGa5El4 = num8;
						PFiiKYU2fiP = num7;
						num2 = 15;
						continue;
					case 6:
						num4 = num7;
						num2 = 20;
						continue;
					case 19:
						num3++;
						num2 = 13;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
						{
							num2 = 10;
						}
						continue;
					case 17:
						{
							num7 = num4;
							num2 = 8;
							continue;
						}
						IL_00e6:
						num10++;
						goto case 1;
						IL_00c7:
						if (!((double)num11 >= num12))
						{
							goto IL_0405;
						}
						goto case 21;
						IL_0405:
						if (!((double)num11 < num12))
						{
							num2 = 21;
							continue;
						}
						goto case 7;
					}
					break;
				}
			}
		}

		public void ClearItems()
		{
			QtJiKv6MKTj.Clear();
		}

		static kc1ySkiruoHITKYTOIWw()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool mh1Wt7eUkMY4RqgJMZcX()
		{
			return CwiGEreUNVE7qRsJj2LX == null;
		}

		internal static kc1ySkiruoHITKYTOIWw G75ywQeU1Tusen7qyEgM()
		{
			return CwiGEreUNVE7qRsJj2LX;
		}

		internal static long nMggodeU5MdfwHJLgkTH(object P_0)
		{
			return ((IRawClusterItem)P_0).Price;
		}

		internal static long Mut4PAeUS7Wc9UWUZmLt(object P_0)
		{
			return ((IRawClusterItem)P_0).Volume;
		}

		internal static void q2Sa6ceUxbskaqy6bSxx(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static long Xck7AIeULAJi1BFY0cKw(object P_0)
		{
			return ((IRawCluster)P_0).Low;
		}

		internal static long lqOceNeUeQtSPgu17dpR(object P_0)
		{
			return ((IRawCluster)P_0).Volume;
		}
	}

	private DynamicLevelsPeriodType FDniSc8EPva;

	private bool MpViSjn6ten;

	private int Ic5iSEY1Zc1;

	private XColor nD9iSQMC02B;

	private XColor cWiiSdV66KA;

	private int Nm4iSgPuf1R;

	private bool JTsiSRNeJS0;

	private XColor ENLiS649Y6a;

	private int V2aiSM68ATY;

	private M1oA8rirhWY0f4LX1I0P XgZiSO65YKo;

	internal static zZvbGliSYRewjSFHwRCl v9whaoek29sd4uXVHKvS;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public DynamicLevelsPeriodType Period
	{
		get
		{
			return FDniSc8EPva;
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
				case 2:
					if (dynamicLevelsPeriodType == FDniSc8EPva)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
						{
							num2 = 1;
						}
						break;
					}
					FDniSc8EPva = dynamicLevelsPeriodType;
					XgZiSO65YKo?.Clear();
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--737722733 ^ 0x2BF846DB));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowValueArea")]
	[DataMember(Name = "ShowValueArea")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	public bool ShowValueArea
	{
		get
		{
			return MpViSjn6ten;
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
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-894902996 ^ -894936624));
					return;
				case 2:
				{
					if (flag == MpViSjn6ten)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
						{
							num2 = 0;
						}
						break;
					}
					MpViSjn6ten = flag;
					M1oA8rirhWY0f4LX1I0P xgZiSO65YKo = XgZiSO65YKo;
					if (xgZiSO65YKo == null)
					{
						goto default;
					}
					xgZiSO65YKo.Clear();
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsValueAreaPercent")]
	[DataMember(Name = "ValueAreaPercent")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	public int ValueAreaPercent
	{
		get
		{
			return Ic5iSEY1Zc1;
		}
		set
		{
			num = UNyIfIeknSkfVnD6JjQy(0, dIZMmuek9O3aF4Cxpu0H(100, num));
			int num2;
			if (num == 0)
			{
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num2 = 0;
				}
				goto IL_0009;
			}
			goto IL_0085;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 2:
					num = 70;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
			goto IL_0085;
			IL_0085:
			if (num == Ic5iSEY1Zc1)
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
				{
					num2 = 0;
				}
				goto IL_0009;
			}
			Ic5iSEY1Zc1 = num;
			XgZiSO65YKo?.Clear();
			OnPropertyChanged((string)HqR6SkekG5fHOrIfqfL9(-90307782 ^ -90274298));
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBackColor")]
	[DataMember(Name = "ValueAreaBackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	public XColor ValueAreaBackColor
	{
		get
		{
			return nD9iSQMC02B;
		}
		set
		{
			if (!(xColor == nD9iSQMC02B))
			{
				nD9iSQMC02B = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)HqR6SkekG5fHOrIfqfL9(0x5EA8FF2A ^ 0x5EA86718));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBorderColor")]
	[DataMember(Name = "ValueAreaBorderColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	public XColor ValueAreaBorderColor
	{
		get
		{
			return cWiiSdV66KA;
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
					if (!(xColor == cWiiSdV66KA))
					{
						cWiiSdV66KA = xColor;
						OnPropertyChanged((string)HqR6SkekG5fHOrIfqfL9(-1962651919 ^ -1962617173));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBorderWidth")]
	[DataMember(Name = "ValueAreaBorderWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsValueArea")]
	public int ValueAreaBorderWidth
	{
		get
		{
			return Nm4iSgPuf1R;
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
					if (num3 != Nm4iSgPuf1R)
					{
						Nm4iSgPuf1R = num3;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837249914));
					}
					return;
				case 1:
					num3 = UNyIfIeknSkfVnD6JjQy(0, Math.Min(10, num3));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowPoc")]
	[DataMember(Name = "ShowPoc")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPoc")]
	public bool ShowPoc
	{
		get
		{
			return JTsiSRNeJS0;
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
					if (flag != JTsiSRNeJS0)
					{
						JTsiSRNeJS0 = flag;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8F3AA));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineColor")]
	[DataMember(Name = "PocLineColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPoc")]
	public XColor PocLineColor
	{
		get
		{
			return ENLiS649Y6a;
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
					if (xColor == ENLiS649Y6a)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
						{
							num2 = 0;
						}
						break;
					}
					ENLiS649Y6a = xColor;
					OnPropertyChanged((string)HqR6SkekG5fHOrIfqfL9(-2056710528 ^ -2056679868));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineWidth")]
	[DataMember(Name = "PocLineWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPoc")]
	public int PocLineWidth
	{
		get
		{
			return V2aiSM68ATY;
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
					num3 = Math.Max(1, Math.Min(10, num3));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (num3 != V2aiSM68ATY)
					{
						V2aiSM68ATY = num3;
						OnPropertyChanged((string)HqR6SkekG5fHOrIfqfL9(-123775059 ^ -123744435));
					}
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnBarClose;

	public zZvbGliSYRewjSFHwRCl()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = DynamicLevelsPeriodType.Day;
		ShowValueArea = true;
		ValueAreaPercent = 70;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				ShowPoc = true;
				PocLineColor = bbdZLRekYoU4CVfPSdoF(ycreEPekoHUaG3lvoUol());
				PocLineWidth = 1;
				return;
			case 1:
				ValueAreaBorderColor = bbdZLRekYoU4CVfPSdoF(Colors.Black);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num = 0;
				}
				break;
			default:
				ValueAreaBorderWidth = 1;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
				{
					num = 0;
				}
				break;
			case 2:
				ValueAreaBackColor = bbdZLRekYoU4CVfPSdoF(Color.FromArgb(50, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		if (base.ClearData)
		{
			XgZiSO65YKo = null;
		}
		int num;
		if (XgZiSO65YKo == null)
		{
			num = 13;
			goto IL_0009;
		}
		goto IL_0486;
		IL_029d:
		if (!ShowValueArea)
		{
			num = 8;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
			{
				num = 21;
			}
			goto IL_0009;
		}
		goto IL_0544;
		IL_03c2:
		IEnumerator<IndicatorSeriesData> enumerator = base.Series.GetEnumerator();
		num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
		{
			num = 23;
		}
		goto IL_0009;
		IL_03b2:
		XgZiSO65YKo = new M1oA8rirhWY0f4LX1I0P();
		goto IL_0486;
		IL_0009:
		kc1ySkiruoHITKYTOIWw kc1ySkiruoHITKYTOIWw2 = default(kc1ySkiruoHITKYTOIWw);
		kc1ySkiruoHITKYTOIWw kc1ySkiruoHITKYTOIWw = default(kc1ySkiruoHITKYTOIWw);
		bool aZIiKoVKuTk = default(bool);
		IRawCluster rawCluster = default(IRawCluster);
		int num3 = default(int);
		int num4 = default(int);
		DynamicLevelsPeriodType dynamicLevelsPeriodType = default(DynamicLevelsPeriodType);
		IndicatorSeriesData indicatorSeriesData3 = default(IndicatorSeriesData);
		IndicatorSeriesData indicatorSeriesData2 = default(IndicatorSeriesData);
		double[] date = default(double[]);
		double timeOffset = default(double);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 21:
				break;
			case 8:
				kc1ySkiruoHITKYTOIWw2 = new kc1ySkiruoHITKYTOIWw(kc1ySkiruoHITKYTOIWw)
				{
					AZIiKoVKuTk = aZIiKoVKuTk
				};
				kc1ySkiruoHITKYTOIWw2.EZrirzIned0(rawCluster);
				kc1ySkiruoHITKYTOIWw2.XW1iK0HOSt8();
				if (ShowValueArea)
				{
					FNxWXdekivFujfxIPC9N(kc1ySkiruoHITKYTOIWw2, (double)ValueAreaPercent / 100.0);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto default;
			case 12:
				aZIiKoVKuTk = false;
				if (num3 != XgZiSO65YKo.Qk4irJp9sNO)
				{
					num2 = 9;
					goto IL_0005;
				}
				goto case 8;
			case 17:
				return;
			case 4:
				XgZiSO65YKo.gmairpK7q3f[num4] = kc1ySkiruoHITKYTOIWw2;
				goto IL_0292;
			case 23:
				try
				{
					while (iyXfpOekNdEh14xdTR5L(enumerator))
					{
						IndicatorSeriesData current = enumerator.Current;
						((Hashtable)ocW8PVekbl1UmKluJMam(current))[HqR6SkekG5fHOrIfqfL9(-1736566656 ^ -1736540036)] = XgZiSO65YKo.EwxirPOaMc7;
						current.UserData[yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799537523)] = true;
						int num5 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						}
					}
					return;
				}
				finally
				{
					enumerator?.Dispose();
				}
			case 7:
				num3 = -1;
				dynamicLevelsPeriodType = Period;
				num = 6;
				continue;
			case 6:
				switch (dynamicLevelsPeriodType)
				{
				case DynamicLevelsPeriodType.Week:
					goto IL_0352;
				case DynamicLevelsPeriodType.Day:
					goto IL_04d5;
				case DynamicLevelsPeriodType.Hour:
					goto IL_0601;
				case DynamicLevelsPeriodType.Month:
					goto IL_0633;
				}
				num = 10;
				continue;
			case 22:
				goto IL_029d;
			case 3:
				goto IL_02c2;
			case 20:
				kc1ySkiruoHITKYTOIWw = ((num4 > 0) ? XgZiSO65YKo.gmairpK7q3f[num4 - 1] : null);
				num = 12;
				continue;
			case 13:
				goto IL_03b2;
			case 15:
				jZdOxqekDblj1N5JdTYf(base.Series, indicatorSeriesData3, indicatorSeriesData2);
				break;
			case 11:
				XgZiSO65YKo.Qk4irJp9sNO = num3;
				aZIiKoVKuTk = true;
				num = 8;
				continue;
			case 18:
				goto IL_04d5;
			case 9:
				kc1ySkiruoHITKYTOIWw = null;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
				{
					num = 11;
				}
				continue;
			case 1:
			case 10:
				rawCluster = base.DataProvider.GetRawCluster(num4);
				num = 20;
				continue;
			case 14:
				goto IL_0544;
			case 16:
				if (num4 >= date.Length - 1)
				{
					XgZiSO65YKo.Kmjirw52t4v(date.Length, base.DataProvider.Step);
					num = 22;
					continue;
				}
				goto case 7;
			case 5:
			{
				double[] wMair8uSIgI = XgZiSO65YKo.WMair8uSIgI;
				ChartSeries chartSeries = new ChartSeries(ChartSeriesType.Line, ValueAreaBorderColor);
				XtIoFSek4CdSy0tw98t6(chartSeries, ValueAreaBorderWidth);
				IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(wMair8uSIgI, chartSeries);
				indicatorSeriesData.Style.DisableMinMax = true;
				indicatorSeriesData2 = indicatorSeriesData;
				num2 = 15;
				goto IL_0005;
			}
			case 2:
				goto IL_0633;
			case 19:
				XgZiSO65YKo.gmairpK7q3f[XgZiSO65YKo.gmairpK7q3f.Count - 2].ClearItems();
				goto IL_0292;
			default:
				{
					if (XgZiSO65YKo.gmairpK7q3f.Count != date.Length)
					{
						XgZiSO65YKo.gmairpK7q3f.Add(kc1ySkiruoHITKYTOIWw2);
						if (XgZiSO65YKo.gmairpK7q3f.Count > 1)
						{
							num = 9;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
							{
								num = 19;
							}
							continue;
						}
						goto IL_0292;
					}
					num2 = 4;
					goto IL_0005;
				}
				IL_0005:
				num = num2;
				continue;
				IL_0292:
				num4++;
				goto case 16;
				IL_0633:
				num3 = ((IChartPeriod)Skq0GsekBpDfbn0LbIPn(base.DataProvider)).GetSequence(ChartPeriodType.Month, 1, date[num4], timeOffset);
				goto case 1;
				IL_0601:
				num3 = HBudqWekatRghN5RHcsE(Skq0GsekBpDfbn0LbIPn(base.DataProvider), ChartPeriodType.Hour, 1, date[num4], timeOffset);
				goto case 1;
				IL_04d5:
				num3 = HBudqWekatRghN5RHcsE(Skq0GsekBpDfbn0LbIPn(base.DataProvider), ChartPeriodType.Day, 1, date[num4], timeOffset);
				goto case 1;
				IL_0352:
				num3 = base.DataProvider.Period.GetSequence(ChartPeriodType.Week, 1, date[num4], timeOffset);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
				{
					num = 1;
				}
				continue;
			}
			break;
		}
		goto IL_0073;
		IL_02c2:
		IndicatorSeriesData indicatorSeriesData4 = new IndicatorSeriesData(XgZiSO65YKo.SJyirA3g5u2, new ChartSeries(ChartSeriesType.Line, PocLineColor));
		((IndicatorSeriesStyle)Ad629Gekl9cmiwiIPblZ(indicatorSeriesData4)).DisableMinMax = true;
		indicatorSeriesData4.Style.StraightLine = true;
		((IndicatorSeriesStyle)Ad629Gekl9cmiwiIPblZ(indicatorSeriesData4)).LineWidth = PocLineWidth;
		IndicatorSeriesData series = indicatorSeriesData4;
		base.Series.Add(series);
		goto IL_03c2;
		IL_0544:
		IndicatorSeriesData indicatorSeriesData5 = new IndicatorSeriesData(XgZiSO65YKo.Fviir7y9bEe, new ChartRegion(ValueAreaBackColor));
		((IndicatorSeriesStyle)Ad629Gekl9cmiwiIPblZ(indicatorSeriesData5)).DisableMinMax = true;
		indicatorSeriesData5[yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1999650146 ^ -1999683496)] = XgZiSO65YKo.WMair8uSIgI;
		IndicatorSeriesData series2 = indicatorSeriesData5;
		base.Series.Add(series2);
		if (ValueAreaBorderWidth > 0)
		{
			IndicatorSeriesData indicatorSeriesData6 = new IndicatorSeriesData(XgZiSO65YKo.Fviir7y9bEe, new ChartSeries(ChartSeriesType.Line, ValueAreaBorderColor)
			{
				Width = ValueAreaBorderWidth
			});
			indicatorSeriesData6.Style.DisableMinMax = true;
			indicatorSeriesData3 = indicatorSeriesData6;
			num = 3;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
			{
				num = 5;
			}
			goto IL_0009;
		}
		goto IL_0073;
		IL_0486:
		date = base.Helper.Date;
		timeOffset = MlDRqyekvb3heemB5prw(base.DataProvider.Symbol.Exchange);
		if (date.Length > XgZiSO65YKo.Ew2ir3Ycoue)
		{
			num4 = XgZiSO65YKo.bguirFrNWFf;
			num = 16;
			goto IL_0009;
		}
		goto IL_029d;
		IL_0073:
		if (ShowPoc)
		{
			num = 3;
			goto IL_0009;
		}
		goto IL_03c2;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ValueAreaBorderColor = P_0.GetNextColor();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ValueAreaBackColor = new XColor(50, ValueAreaBorderColor);
				PocLineColor = WQBp19ekkIu0WYDpbb2s(P_0);
				base.ApplyColors(P_0);
				return;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		zZvbGliSYRewjSFHwRCl zZvbGliSYRewjSFHwRCl2 = default(zZvbGliSYRewjSFHwRCl);
		while (true)
		{
			switch (num2)
			{
			default:
				Period = zZvbGliSYRewjSFHwRCl2.Period;
				ShowValueArea = wGSxhlek1GZAOnJE2mad(zZvbGliSYRewjSFHwRCl2);
				ValueAreaPercent = zZvbGliSYRewjSFHwRCl2.ValueAreaPercent;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				PocLineWidth = zZvbGliSYRewjSFHwRCl2.PocLineWidth;
				base.CopyTemplate(P_0, P_1);
				return;
			case 2:
				ValueAreaBackColor = zZvbGliSYRewjSFHwRCl2.ValueAreaBackColor;
				ValueAreaBorderColor = zZvbGliSYRewjSFHwRCl2.ValueAreaBorderColor;
				ValueAreaBorderWidth = zZvbGliSYRewjSFHwRCl2.ValueAreaBorderWidth;
				ShowPoc = zZvbGliSYRewjSFHwRCl2.ShowPoc;
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				PocLineColor = aUF15eek5ECX8FLe3vLq(zZvbGliSYRewjSFHwRCl2);
				num2 = 3;
				break;
			case 1:
				zZvbGliSYRewjSFHwRCl2 = (zZvbGliSYRewjSFHwRCl)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static zZvbGliSYRewjSFHwRCl()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool EiiOTHekHEIBRl3TvNOg()
	{
		return v9whaoek29sd4uXVHKvS == null;
	}

	internal static zZvbGliSYRewjSFHwRCl rnahRMekfZqvmhFY51EH()
	{
		return v9whaoek29sd4uXVHKvS;
	}

	internal static int dIZMmuek9O3aF4Cxpu0H(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int UNyIfIeknSkfVnD6JjQy(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object HqR6SkekG5fHOrIfqfL9(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor bbdZLRekYoU4CVfPSdoF(Color P_0)
	{
		return P_0;
	}

	internal static Color ycreEPekoHUaG3lvoUol()
	{
		return Colors.Black;
	}

	internal static double MlDRqyekvb3heemB5prw(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static object Skq0GsekBpDfbn0LbIPn(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static int HBudqWekatRghN5RHcsE(object P_0, ChartPeriodType type, int interval, double dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static void FNxWXdekivFujfxIPC9N(object P_0, double P_1)
	{
		((kc1ySkiruoHITKYTOIWw)P_0).vCJiK2LO3aZ(P_1);
	}

	internal static object Ad629Gekl9cmiwiIPblZ(object P_0)
	{
		return ((IndicatorSeriesData)P_0).Style;
	}

	internal static void XtIoFSek4CdSy0tw98t6(object P_0, int value)
	{
		((ChartSeries)P_0).Width = value;
	}

	internal static void jZdOxqekDblj1N5JdTYf(object P_0, object P_1, object P_2)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1, (IndicatorSeriesData)P_2);
	}

	internal static object ocW8PVekbl1UmKluJMam(object P_0)
	{
		return ((IndicatorSeriesData)P_0).UserData;
	}

	internal static bool iyXfpOekNdEh14xdTR5L(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static XColor WQBp19ekkIu0WYDpbb2s(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static bool wGSxhlek1GZAOnJE2mad(object P_0)
	{
		return ((zZvbGliSYRewjSFHwRCl)P_0).ShowValueArea;
	}

	internal static XColor aUF15eek5ECX8FLe3vLq(object P_0)
	{
		return ((zZvbGliSYRewjSFHwRCl)P_0).PocLineColor;
	}
}
