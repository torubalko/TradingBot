using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using jS3Y2j9pTQRy0FnOknFG;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Market.Settings;
using TigerTrade.UI.DocControls.Charting.Settings;
using TuAMtrl1Nd3XoZQQUXf0;

namespace pt0FBR91ItQpvpimPGdP;

internal static class zVLaqo91qecSjPA3glYj
{
	[Serializable]
	[CompilerGenerated]
	private sealed class iCjFh5nFkkxd1YqyfiLS
	{
		public static readonly iCjFh5nFkkxd1YqyfiLS R6enF5AgeO8;

		public static Func<ObjectBase, string> r8hnFSifpeO;

		private static iCjFh5nFkkxd1YqyfiLS zGOjmVNqkpbwbUuOn9lw;

		static iCjFh5nFkkxd1YqyfiLS()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
					{
						num2 = 0;
					}
					break;
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					R6enF5AgeO8 = new iCjFh5nFkkxd1YqyfiLS();
					return;
				}
			}
		}

		public iCjFh5nFkkxd1YqyfiLS()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string QZXnF1D5UkR(ObjectBase g)
		{
			return g.SymbolID;
		}

		internal static bool D82OZbNq1XL9GP906ygG()
		{
			return zGOjmVNqkpbwbUuOn9lw == null;
		}

		internal static iCjFh5nFkkxd1YqyfiLS R113umNq581xZeLI3trr()
		{
			return zGOjmVNqkpbwbUuOn9lw;
		}
	}

	private static zVLaqo91qecSjPA3glYj Y0iyR4bSQqapiYoQD8tC;

	public static void cAw91W9F5aM()
	{
		ygK91tS2f72();
	}

	private static void ygK91tS2f72()
	{
		try
		{
			int num;
			if (!Directory.Exists((string)qvZKvZbSRxlnausSUKs3()))
			{
				num = 3;
				goto IL_0025;
			}
			string[] files = Directory.GetFiles(j18iDj9nukSCmEyZs5lH.mCD9GU85vS2());
			int num2 = 0;
			goto IL_005b;
			IL_0088:
			string text = files[num2];
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
			{
				num = 1;
			}
			goto IL_0025;
			IL_005b:
			if (num2 >= files.Length)
			{
				return;
			}
			goto IL_0088;
			IL_0025:
			switch (num)
			{
			case 3:
				return;
			default:
				num2++;
				goto IL_005b;
			case 2:
				break;
			case 1:
				try
				{
					int num3;
					if (!gPyPVcbS6KnsIwtakJI0(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x330127C9)))
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
						{
							num3 = 0;
						}
						goto IL_00ed;
					}
					goto IL_01f5;
					IL_00ed:
					List<ObjectBase> source = default(List<ObjectBase>);
					ChartingSettings chartingSettings = default(ChartingSettings);
					switch (num3)
					{
					default:
						goto end_IL_00b2;
					case 3:
						source = chartingSettings.ChartSettings.Areas[0].Objects;
						if (!ncKkZubSOlP7g4l3Pcfc(chartingSettings.Qom210PQiuE))
						{
							goto case 1;
						}
						goto end_IL_00b2;
					case 4:
						break;
					case 0:
						goto end_IL_00b2;
					case 1:
						foreach (IGrouping<string, ObjectBase> item in from g in source.ToList()
							group g by g.SymbolID)
						{
							PeL91UcBNUU(item.ToList());
							int num4 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							}
						}
						goto end_IL_00b2;
					case 2:
						goto end_IL_00b2;
					}
					goto IL_01f5;
					IL_01f5:
					chartingSettings = ConfigSerializer.LoadFromFile<ChartingSettings>(text, (DataContractResolver)gLwnx3bSMPlK7lT090Iw());
					if (chartingSettings != null && chartingSettings.ChartSettings.Areas[0].Objects.Count != 0)
					{
						num3 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
						{
							num3 = 0;
						}
						goto IL_00ed;
					}
					end_IL_00b2:;
				}
				catch (Exception e)
				{
					LogManager.WriteError(e);
				}
				goto default;
			}
			goto IL_0088;
		}
		catch (Exception ex)
		{
			iX8a6VbSqvXRsUSUWWgZ(ex);
		}
	}

	[CompilerGenerated]
	internal static void PeL91UcBNUU(List<ObjectBase> P_0)
	{
		if (P_0.Count != 0)
		{
			string symbolID = P_0[0].SymbolID;
			if (!Directory.Exists(j18iDj9nukSCmEyZs5lH.das9Gr3ODK2()))
			{
				Directory.CreateDirectory(j18iDj9nukSCmEyZs5lH.das9Gr3ODK2());
			}
			string fileName = j18iDj9nukSCmEyZs5lH.das9Gr3ODK2() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176276185) + symbolID + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527092662);
			MarketSettings obj = ConfigSerializer.LoadFromFile<MarketSettings>(fileName, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns()) ?? new MarketSettings();
			obj.Objects = P_0;
			ConfigSerializer.SaveToFileDebounced(obj, fileName, 0, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
		}
	}

	static zVLaqo91qecSjPA3glYj()
	{
		axQmTDbSIMYoU8oyANkx();
	}

	internal static object qvZKvZbSRxlnausSUKs3()
	{
		return j18iDj9nukSCmEyZs5lH.mCD9GU85vS2();
	}

	internal static bool gPyPVcbS6KnsIwtakJI0(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object gLwnx3bSMPlK7lT090Iw()
	{
		return jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns();
	}

	internal static bool ncKkZubSOlP7g4l3Pcfc(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void iX8a6VbSqvXRsUSUWWgZ(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static bool hQZnibbSdEXF4bHP6d4E()
	{
		return Y0iyR4bSQqapiYoQD8tC == null;
	}

	internal static zVLaqo91qecSjPA3glYj dJwBlabSgb2PuUssy1Ga()
	{
		return Y0iyR4bSQqapiYoQD8tC;
	}

	internal static void axQmTDbSIMYoU8oyANkx()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
