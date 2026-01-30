using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using Fb8gFFHFUNPFVH1wej60;
using iXecOGHHXy5JKyC88RF0;
using n0pHVoH9Rok0LZdfPCeU;
using PlpXjVH957XjBF1mxsIK;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Core.UI.Converters;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TigerTrade.UI.Controls.Toolbar;
using TnsUjXHHy7KFZTRRNgfB;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;
using YFrtCyH9YfQVFkAtgbL4;

namespace jKxkD8HfxfM8pAInciSU;

internal abstract class FY07xYHfSCiM5E3465o7
{
	[Serializable]
	[CompilerGenerated]
	private sealed class nErY87ntfeYkFAyoTwOL
	{
		public static readonly nErY87ntfeYkFAyoTwOL NCuntGiByBT;

		public static Func<string, bool> FmfntYCgmoa;

		public static Func<UINtTnH9G5KZSt24EWrs, bool> XB7ntokvWdA;

		internal static nErY87ntfeYkFAyoTwOL qAtaR7N5zsiHe031AMah;

		static nErY87ntfeYkFAyoTwOL()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			GhIRhhNSHsjJS0ptorGc();
			NCuntGiByBT = new nErY87ntfeYkFAyoTwOL();
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

		public nErY87ntfeYkFAyoTwOL()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool Ywgnt91yTOQ(UINtTnH9G5KZSt24EWrs t)
		{
			return t.Items?.Any((string i) => i == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520221267)) ?? false;
		}

		internal bool XRZntnu2l3m(string i)
		{
			return i == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520221267);
		}

		internal static void GhIRhhNSHsjJS0ptorGc()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool wdhO2gNS0STZebtF8iSt()
		{
			return qAtaR7N5zsiHe031AMah == null;
		}

		internal static nErY87ntfeYkFAyoTwOL ynMlGyNS2i50ZolaFW4p()
		{
			return qAtaR7N5zsiHe031AMah;
		}
	}

	[CompilerGenerated]
	private sealed class h2ZKHRntvTEthcVdnRaq
	{
		public HashSet<string> puDntiPgCKW;

		public Func<string, bool> TFMntlQ2ebI;

		public Func<string, bool> abant4lmTqu;

		private static h2ZKHRntvTEthcVdnRaq CsBi6kNSfbksv3edrII0;

		public h2ZKHRntvTEthcVdnRaq()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool ArentB78l3j(string i)
		{
			return puDntiPgCKW.Contains(i);
		}

		internal bool lWNntaxOAby(string i)
		{
			return puDntiPgCKW.Contains(i);
		}

		static h2ZKHRntvTEthcVdnRaq()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool LmlZ6XNS9y4d04XHDNlM()
		{
			return CsBi6kNSfbksv3edrII0 == null;
		}

		internal static h2ZKHRntvTEthcVdnRaq MixJcuNSnpfEAeCBNmrb()
		{
			return CsBi6kNSfbksv3edrII0;
		}
	}

	protected imIfHHH91uA5mZTRNIJC Toolbars;

	private static FY07xYHfSCiM5E3465o7 APcKA7D4DVZKhdpkb0fB;

	[SpecialName]
	protected abstract string ggDlfphVicB();

	protected void elBHfLlBvFh()
	{
		Toolbars = (imIfHHH91uA5mZTRNIJC)(ConfigSerializer.LoadFromFile<imIfHHH91uA5mZTRNIJC>((string)AfS2WBD4ktunXZ9qbOt6(this)) ?? tOWGudD418jFFJ08xVy1(this));
		if (Toolbars.Toolbars.Count > 0)
		{
			return;
		}
		Toolbars = (imIfHHH91uA5mZTRNIJC)tOWGudD418jFFJ08xVy1(this);
		try
		{
			File.Delete(ggDlfphVicB());
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public void vYUHfeyH4eY()
	{
		ConfigSerializer.SaveToFile(Toolbars, ggDlfphVicB());
	}

	public imIfHHH91uA5mZTRNIJC L8yHfsgtv0U()
	{
		return ConfigSerializer.LoadFromFile<imIfHHH91uA5mZTRNIJC>(ggDlfphVicB()) ?? p7qlfzB4Jgs();
	}

	protected abstract void wCblfupqQ7e();

	public void A3OHfXpUYDc(imIfHHH91uA5mZTRNIJC P_0)
	{
		Toolbars = P_0;
		UINtTnH9G5KZSt24EWrs uINtTnH9G5KZSt24EWrs = P_0.Toolbars.FirstOrDefault((UINtTnH9G5KZSt24EWrs t) => t.Items?.Any((string i) => i == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520221267)) ?? false);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				wCblfupqQ7e();
				return;
			}
			j18iDj9nukSCmEyZs5lH.Settings.TimeframePosition = uINtTnH9G5KZSt24EWrs?.Position ?? XToolbarPosition.None;
			ConfigSerializer.SaveToFile(P_0, ggDlfphVicB());
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 1;
			}
		}
	}

	public void cPMHfc4R8gI(UserControl P_0)
	{
		YrwHfQf8xfr(P_0, Toolbars);
	}

	public bool YEiHfjvLIKV(string P_0)
	{
		return Toolbars.VyjH9Sc1cib(P_0);
	}

	public abstract List<string> OSkl90IKTGg();

	public abstract imIfHHH91uA5mZTRNIJC p7qlfzB4Jgs();

	public virtual string LtAl92ycKdR(string P_0)
	{
		if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047231473))
		{
			return Resources.ToolbarSeparator;
		}
		return P_0;
	}

	public static string suYHfE4hBHG(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Resources.ToolbarPositionEnumLeft;
			case 3:
				return P_0;
			case 2:
				if (iX1iOKD4SAyYAOiccF43(P_0, LyJt9XD45rnl3NfT6BYs(-1999650146 ^ -1999716066)))
				{
					return Resources.ToolbarSeparator;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!(P_0 == (string)LyJt9XD45rnl3NfT6BYs(--871424829 ^ 0x33F02407)))
				{
					if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x344C095))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (!iX1iOKD4SAyYAOiccF43(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28AB7CC)))
					{
						if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B48EC6))
						{
							return Resources.ToolbarPositionEnumBottom;
						}
						if (P_0 == (string)LyJt9XD45rnl3NfT6BYs(0x6AB40973 ^ 0x6AB503C3))
						{
							return (string)gXc2bHD4LJAwaQ3ld0jl();
						}
						num2 = 3;
						break;
					}
					return Resources.ToolbarPositionEnumRight;
				}
				return (string)sUeHxDD4xkGlEQXU35OF();
			}
		}
	}

	protected void YrwHfQf8xfr(UserControl P_0, imIfHHH91uA5mZTRNIJC P_1)
	{
		h2ZKHRntvTEthcVdnRaq CS_0024_003C_003E8__locals4 = new h2ZKHRntvTEthcVdnRaq();
		int num = 0;
		_ = ((MhMDPU9v8rkigy1ao0Th)vEdA1CD4epwYp78yqdXB()).IconsSize;
		int num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
		{
			num2 = 1;
		}
		Dictionary<XToolbarPosition, int> dictionary = default(Dictionary<XToolbarPosition, int>);
		List<UINtTnH9G5KZSt24EWrs>.Enumerator enumerator = default(List<UINtTnH9G5KZSt24EWrs>.Enumerator);
		List<mAHhmOH9gHTWcA6hYgFE> list = default(List<mAHhmOH9gHTWcA6hYgFE>);
		UINtTnH9G5KZSt24EWrs current = default(UINtTnH9G5KZSt24EWrs);
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		ToolBar toolBar = default(ToolBar);
		ToolBarTray toolBarTray = default(ToolBarTray);
		La0ca4HHTc6Pirgseila la0ca4HHTc6Pirgseila = default(La0ca4HHTc6Pirgseila);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 1:
				dictionary = new Dictionary<XToolbarPosition, int>();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					while (enumerator.MoveNext())
					{
						UINtTnH9G5KZSt24EWrs current4 = enumerator.Current;
						int num7 = 2;
						while (true)
						{
							switch (num7)
							{
							case 1:
								dictionary[current4.Position] = 0;
								break;
							case 2:
								if (current4.Items.Count((string i) => CS_0024_003C_003E8__locals4.puDntiPgCKW.Contains(i)) != 0)
								{
									dictionary.TryGetValue(current4.Position, out var value);
									dictionary[current4.Position] = value + 1;
									num7 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
									{
										num7 = 0;
									}
								}
								else
								{
									num7 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
									{
										num7 = 1;
									}
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				list = WNtHfdrBSq2();
				enumerator = P_1.Toolbars.GetEnumerator();
				num3 = 3;
				goto IL_0005;
			case 3:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 4;
						}
						else
						{
							current = enumerator.Current;
							num4 = 2;
						}
						while (true)
						{
							int num5 = num4;
							while (true)
							{
								switch (num5)
								{
								case 4:
									return;
								case 5:
									break;
								case 3:
									enumerator2 = current.Items.GetEnumerator();
									num5 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
								{
									Binding binding = new Binding((string)LyJt9XD45rnl3NfT6BYs(-45476899 ^ -45410037))
									{
										Mode = BindingMode.OneTime
									};
									toolBar.ItemTemplateSelector = new IbgoiZHHsn43MdPnxQyM(P_0.Resources);
									BindingOperations.SetBinding(toolBar, ItemsControl.ItemsSourceProperty, binding);
									if (toolBarTray != null)
									{
										toolBarTray.ToolBars.Add(toolBar);
										num5 = 5;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
										{
											num5 = 1;
										}
										continue;
									}
									break;
								}
								default:
									try
									{
										while (enumerator2.MoveNext())
										{
											while (true)
											{
												string current2 = enumerator2.Current;
												int num6 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
												{
													num6 = 1;
												}
												switch (num6)
												{
												case 2:
													continue;
												case 3:
													la0ca4HHTc6Pirgseila.nRWHHZLWQ5h(current2);
													break;
												case 1:
													if (current2 == (string)LyJt9XD45rnl3NfT6BYs(0x37B74BDF ^ 0x37B64803))
													{
														foreach (mAHhmOH9gHTWcA6hYgFE item in list)
														{
															la0ca4HHTc6Pirgseila.jHZHHVwL8Qy(item, current.Position);
														}
														break;
													}
													goto default;
												default:
													if (!CS_0024_003C_003E8__locals4.puDntiPgCKW.Contains(current2))
													{
														break;
													}
													goto case 3;
												}
												break;
											}
										}
									}
									finally
									{
										((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
									}
									goto case 1;
								case 2:
									if (current.Items.Count((string i) => CS_0024_003C_003E8__locals4.puDntiPgCKW.Contains(i)) == 0)
									{
										break;
									}
									goto end_IL_01e8;
								}
								goto end_IL_01e4;
								continue;
								end_IL_01e8:
								break;
							}
							toolBarTray = (ToolBarTray)P_0.FindName((string)LyJt9XD45rnl3NfT6BYs(0x4220DA8 ^ 0x4230714) + current.Position);
							la0ca4HHTc6Pirgseila = new La0ca4HHTc6Pirgseila(P_0.DataContext as xRgq7gHkTVINiHGAKc0y, toolBarTray.Orientation == Orientation.Vertical);
							toolBar = new ToolBar
							{
								Padding = new Thickness(0.0),
								HorizontalAlignment = HorizontalAlignment.Right,
								Band = num++,
								DataContext = la0ca4HHTc6Pirgseila
							};
							num4 = 3;
							continue;
							end_IL_01e4:
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			default:
				{
					CS_0024_003C_003E8__locals4.puDntiPgCKW = OSkl90IKTGg().ToHashSet();
					enumerator = P_1.Toolbars.GetEnumerator();
					num3 = 2;
					goto IL_0005;
				}
				IL_0005:
				num2 = num3;
				break;
			}
		}
	}

	private List<mAHhmOH9gHTWcA6hYgFE> WNtHfdrBSq2()
	{
		List<mAHhmOH9gHTWcA6hYgFE> list = new List<mAHhmOH9gHTWcA6hYgFE>();
		Dictionary<DataCycleBase, int> dictionary = new Dictionary<DataCycleBase, int>();
		foreach (DataCycle item in fKvKggHFteRddgHojOPb.Periods)
		{
			string text = item.ShortName;
			if (text.Trim().Length > 3 || item.CycleBase == DataCycleBase.Reversal)
			{
				if (!dictionary.ContainsKey(item.CycleBase))
				{
					dictionary.Add(item.CycleBase, 1);
				}
				int num = dictionary[item.CycleBase]++;
				text = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009586029), item.ShortBase, num);
			}
			string description = EnumDescriptionTypeConverter.GetDescription(Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556110)), item.CycleBase.ToString());
			string empty = string.Empty;
			string text2 = string.Empty;
			if (item.CycleBase == DataCycleBase.Reversal)
			{
				empty = description;
				text2 = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087013750), Resources.TimeframeRepeatLabel, item.Repeat, Environment.NewLine, Resources.TimeframeMinBarSizeLabel, item.RepeatParam1);
			}
			else
			{
				empty = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53782686), item.Repeat, description);
			}
			if (item.DaysToLoadChart.HasValue || item.DaysToLoadDom.HasValue)
			{
				text2 += Resources.DataCycleDaysToLoad;
			}
			if (item.DaysToLoadChart.HasValue)
			{
				text2 = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461225253), text2, Environment.NewLine, Resources.DataCycleDaysToLoadChart, item.DaysToLoadChart);
			}
			if (item.DaysToLoadDom.HasValue)
			{
				text2 = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D00F15), text2, Environment.NewLine, Resources.DataCycleDaysToLoadDom, item.DaysToLoadDom);
			}
			list.Add(new mAHhmOH9gHTWcA6hYgFE(item, text, empty, text2));
		}
		return list;
	}

	protected FY07xYHfSCiM5E3465o7()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static FY07xYHfSCiM5E3465o7()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object AfS2WBD4ktunXZ9qbOt6(object P_0)
	{
		return ((FY07xYHfSCiM5E3465o7)P_0).ggDlfphVicB();
	}

	internal static object tOWGudD418jFFJ08xVy1(object P_0)
	{
		return ((FY07xYHfSCiM5E3465o7)P_0).p7qlfzB4Jgs();
	}

	internal static bool ewvq9fD4bUdVQ3XaSObV()
	{
		return APcKA7D4DVZKhdpkb0fB == null;
	}

	internal static FY07xYHfSCiM5E3465o7 A2is1uD4Nh9IPh70Z2W3()
	{
		return APcKA7D4DVZKhdpkb0fB;
	}

	internal static object LyJt9XD45rnl3NfT6BYs(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool iX1iOKD4SAyYAOiccF43(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object sUeHxDD4xkGlEQXU35OF()
	{
		return Resources.ToolbarPositionEnumTop;
	}

	internal static object gXc2bHD4LJAwaQ3ld0jl()
	{
		return Resources.ToolbarPositionEnumNone;
	}

	internal static object vEdA1CD4epwYp78yqdXB()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}
}
