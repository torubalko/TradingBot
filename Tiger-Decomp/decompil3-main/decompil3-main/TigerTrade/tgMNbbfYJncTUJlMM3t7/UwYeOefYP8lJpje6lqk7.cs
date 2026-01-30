using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using ECOEgqlSad8NUJZ2Dr9n;
using JbtcCQfvnTuno7NXkd9W;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Core.UI.Common;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace tgMNbbfYJncTUJlMM3t7;

[DataContract(Name = "SoundAlertsSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Alerts")]
internal sealed class UwYeOefYP8lJpje6lqk7 : IDynamicProperty, IExtensibleDataObject
{
	private static HashSet<string> ErGfoT72AoG;

	private static readonly Dictionary<string, string> nOUfoyPGmf5;

	[CompilerGenerated]
	private ExtensionDataObject kB4foZjoJXt;

	[CompilerGenerated]
	private bool TStfoVycwxA;

	[CompilerGenerated]
	private string cRZfoChyKFM;

	[CompilerGenerated]
	private bool qCJforQOLnA;

	[CompilerGenerated]
	private string MbGfoKKh0ch;

	[CompilerGenerated]
	private bool RS9fom4AwRi;

	[CompilerGenerated]
	private string bHNfoh2bWit;

	[CompilerGenerated]
	private bool sCjfow33xx8;

	[CompilerGenerated]
	private string iN0fo7pXL8S;

	[CompilerGenerated]
	private bool tJPfo89rje3;

	[CompilerGenerated]
	private string aXWfoAZmnKA;

	[CompilerGenerated]
	private bool ArTfoPFi1KM;

	[CompilerGenerated]
	private string FWkfoJAESfu;

	[CompilerGenerated]
	private bool MIgfoFsE7Fv;

	[CompilerGenerated]
	private string mvyfo33UkPP;

	[CompilerGenerated]
	private bool R1Hfop0N0W3;

	[CompilerGenerated]
	private string PVafouSyqQJ;

	[CompilerGenerated]
	private bool Xcafozicv2K;

	[CompilerGenerated]
	private string q0Zfv0S6DSu;

	[CompilerGenerated]
	private bool xvnfv2yjPMs;

	[CompilerGenerated]
	private string bOdfvHwqlKG;

	private int vaHfvf6suAV;

	internal static UwYeOefYP8lJpje6lqk7 i3JAfnDry22NC3miaTQe;

	[Browsable(false)]
	public ExtensionDataObject ExtensionData
	{
		[CompilerGenerated]
		get
		{
			return kB4foZjoJXt;
		}
		[CompilerGenerated]
		set
		{
			kB4foZjoJXt = extensionDataObject;
		}
	}

	[DefaultValue(true)]
	[Browsable(false)]
	[DataMember(Name = "PlayConnectedSound")]
	public bool PlayConnectedSound
	{
		[CompilerGenerated]
		get
		{
			return TStfoVycwxA;
		}
		[CompilerGenerated]
		set
		{
			TStfoVycwxA = tStfoVycwxA;
		}
	}

	[DefaultValue("")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsConnected")]
	[DataMember(Name = "Connected")]
	public string Connected
	{
		[CompilerGenerated]
		get
		{
			return cRZfoChyKFM;
		}
		[CompilerGenerated]
		set
		{
			cRZfoChyKFM = text;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "PlayDisconnectedSound")]
	[DefaultValue(true)]
	public bool PlayDisconnectedSound
	{
		[CompilerGenerated]
		get
		{
			return qCJforQOLnA;
		}
		[CompilerGenerated]
		set
		{
			qCJforQOLnA = flag;
		}
	}

	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsDisconnected")]
	[DefaultValue("")]
	[DataMember(Name = "Disconnected")]
	public string Disconnected
	{
		[CompilerGenerated]
		get
		{
			return MbGfoKKh0ch;
		}
		[CompilerGenerated]
		set
		{
			MbGfoKKh0ch = mbGfoKKh0ch;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "PlayOrderPlacedSound")]
	[DefaultValue(true)]
	public bool PlayOrderPlacedSound
	{
		[CompilerGenerated]
		get
		{
			return RS9fom4AwRi;
		}
		[CompilerGenerated]
		set
		{
			RS9fom4AwRi = rS9fom4AwRi;
		}
	}

	[DataMember(Name = "OrderPlaced")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderPlaced")]
	[DefaultValue("")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	public string OrderPlaced
	{
		[CompilerGenerated]
		get
		{
			return bHNfoh2bWit;
		}
		[CompilerGenerated]
		set
		{
			bHNfoh2bWit = text;
		}
	}

	[DataMember(Name = "PlayOrderRejectedSound")]
	[DefaultValue(true)]
	[Browsable(false)]
	public bool PlayOrderRejectedSound
	{
		[CompilerGenerated]
		get
		{
			return sCjfow33xx8;
		}
		[CompilerGenerated]
		set
		{
			sCjfow33xx8 = flag;
		}
	}

	[DataMember(Name = "OrderRejected")]
	[DefaultValue("")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderRejected")]
	public string OrderRejected
	{
		[CompilerGenerated]
		get
		{
			return iN0fo7pXL8S;
		}
		[CompilerGenerated]
		set
		{
			iN0fo7pXL8S = text;
		}
	}

	[DataMember(Name = "PlayOrderModifiedSound")]
	[Browsable(false)]
	[DefaultValue(true)]
	public bool PlayOrderModifiedSound
	{
		[CompilerGenerated]
		get
		{
			return tJPfo89rje3;
		}
		[CompilerGenerated]
		set
		{
			tJPfo89rje3 = flag;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderModified")]
	[DefaultValue("")]
	[DataMember(Name = "OrderModified")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	public string OrderModified
	{
		[CompilerGenerated]
		get
		{
			return aXWfoAZmnKA;
		}
		[CompilerGenerated]
		set
		{
			aXWfoAZmnKA = text;
		}
	}

	[DataMember(Name = "PlayOrderModifyRejectedSound")]
	[DefaultValue(true)]
	[Browsable(false)]
	public bool PlayOrderModifyRejectedSound
	{
		[CompilerGenerated]
		get
		{
			return ArTfoPFi1KM;
		}
		[CompilerGenerated]
		set
		{
			ArTfoPFi1KM = arTfoPFi1KM;
		}
	}

	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderModifyRejected")]
	[DataMember(Name = "OrderModifyRejected")]
	[DefaultValue("")]
	public string OrderModifyRejected
	{
		[CompilerGenerated]
		get
		{
			return FWkfoJAESfu;
		}
		[CompilerGenerated]
		set
		{
			FWkfoJAESfu = fWkfoJAESfu;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "PlayOrderCanceledSound")]
	[DefaultValue(true)]
	public bool PlayOrderCanceledSound
	{
		[CompilerGenerated]
		get
		{
			return MIgfoFsE7Fv;
		}
		[CompilerGenerated]
		set
		{
			MIgfoFsE7Fv = mIgfoFsE7Fv;
		}
	}

	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[DataMember(Name = "OrderCanceled")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderCanceled")]
	[DefaultValue("")]
	public string OrderCanceled
	{
		[CompilerGenerated]
		get
		{
			return mvyfo33UkPP;
		}
		[CompilerGenerated]
		set
		{
			mvyfo33UkPP = text;
		}
	}

	[DefaultValue(true)]
	[Browsable(false)]
	[DataMember(Name = "PlayOrderCancelRejectedSound")]
	public bool PlayOrderCancelRejectedSound
	{
		[CompilerGenerated]
		get
		{
			return R1Hfop0N0W3;
		}
		[CompilerGenerated]
		set
		{
			R1Hfop0N0W3 = r1Hfop0N0W;
		}
	}

	[DataMember(Name = "OrderCancelRejected")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[DefaultValue("")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderCancelRejected")]
	public string OrderCancelRejected
	{
		[CompilerGenerated]
		get
		{
			return PVafouSyqQJ;
		}
		[CompilerGenerated]
		set
		{
			PVafouSyqQJ = pVafouSyqQJ;
		}
	}

	[DefaultValue(true)]
	[DataMember(Name = "PlayOrderFilledSound")]
	[Browsable(false)]
	public bool PlayOrderFilledSound
	{
		[CompilerGenerated]
		get
		{
			return Xcafozicv2K;
		}
		[CompilerGenerated]
		set
		{
			Xcafozicv2K = xcafozicv2K;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsOrderFilled")]
	[DataMember(Name = "OrderFilled")]
	[DefaultValue("")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	public string OrderFilled
	{
		[CompilerGenerated]
		get
		{
			return q0Zfv0S6DSu;
		}
		[CompilerGenerated]
		set
		{
			q0Zfv0S6DSu = text;
		}
	}

	[DataMember(Name = "PlayScreenerAlertSound")]
	[Browsable(false)]
	[DefaultValue(true)]
	public bool PlayScreenerAlertSound
	{
		[CompilerGenerated]
		get
		{
			return xvnfv2yjPMs;
		}
		[CompilerGenerated]
		set
		{
			xvnfv2yjPMs = flag;
		}
	}

	[DefaultValue("")]
	[DataMember(Name = "ScreenerAlert")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsSoundAlerts")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsScreenerAlert")]
	public string ScreenerAlert
	{
		[CompilerGenerated]
		get
		{
			return bOdfvHwqlKG;
		}
		[CompilerGenerated]
		set
		{
			bOdfvHwqlKG = text;
		}
	}

	[DefaultValue(5)]
	[DataMember(Name = "SoundVolume")]
	[T4IXj62qBfXCaxs2RI5("SoundAlertsSettingsOptions")]
	[bBo0Zd2ycQQr3LNHQf4("SoundAlertsSettingsSoundVolume")]
	public int V6IfoUT1bpc
	{
		get
		{
			return vaHfvf6suAV;
		}
		set
		{
			val = mxbITtDrCIIunkItVxRU(1, Math.Min(10, val));
			vaHfvf6suAV = val;
		}
	}

	public UwYeOefYP8lJpje6lqk7()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		PlayConnectedSound = true;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 4:
				OrderCanceled = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46620EA9);
				PlayOrderCancelRejectedSound = true;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				PlayDisconnectedSound = true;
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
				{
					num = 5;
				}
				break;
			case 5:
				V6IfoUT1bpc = 5;
				num = 7;
				break;
			default:
				OrderModifyRejected = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416989025);
				PlayOrderCanceledSound = true;
				num = 4;
				break;
			case 9:
				Connected = (string)jDdm1NDrrDpmirXOcOZD(0x706541F3 ^ 0x7065B6A7);
				num = 6;
				break;
			case 6:
				Disconnected = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45423433);
				PlayOrderPlacedSound = true;
				OrderPlaced = (string)jDdm1NDrrDpmirXOcOZD(0x769C7931 ^ 0x769C8EB7);
				num = 3;
				break;
			case 1:
				OrderCancelRejected = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123789400);
				PlayOrderFilledSound = true;
				OrderFilled = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x7357EDBF);
				PlayScreenerAlertSound = true;
				ScreenerAlert = (string)jDdm1NDrrDpmirXOcOZD(-1461292091 ^ -1461552821);
				num = 2;
				break;
			case 2:
				return;
			case 3:
				PlayOrderRejectedSound = true;
				OrderRejected = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741B726B);
				PlayOrderModifiedSound = true;
				OrderModified = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x33016011);
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
				{
					num = 5;
				}
				break;
			case 8:
				PlayOrderModifyRejectedSound = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool GetPropertyHasStandardValues(string P_0)
	{
		int num = 4;
		int num2 = num;
		uint num3 = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 11:
				if (num3 != 2864429845u)
				{
					num2 = 7;
					break;
				}
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -617042035)))
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 10;
			case 10:
			case 19:
				return true;
			case 2:
			case 5:
			case 9:
			case 13:
			case 17:
				return false;
			case 14:
				if (num3 != 838159352)
				{
					num2 = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 5;
					}
					break;
				}
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DE5C99)))
				{
					num2 = 9;
					break;
				}
				goto case 10;
			case 6:
				if (!KK0pSRDrKTKlPaGMWaxJ(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839702364)))
				{
					num2 = 17;
					break;
				}
				goto case 10;
			case 16:
				if (num3 <= 2448031718u)
				{
					if (num3 != 2079757168)
					{
						if (num3 != 2448031718u)
						{
							num2 = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
							{
								num2 = 2;
							}
							break;
						}
						if (KK0pSRDrKTKlPaGMWaxJ(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82882226)))
						{
							goto case 10;
						}
						goto case 2;
					}
					goto case 12;
				}
				num2 = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num2 = 7;
				}
				break;
			case 18:
				if (num3 != 1428919215)
				{
					if (num3 == 1630637035 && P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130F1201))
					{
						goto case 10;
					}
					goto case 2;
				}
				goto case 8;
			case 3:
				if (num3 > 1630637035)
				{
					num2 = 16;
					break;
				}
				goto default;
			case 15:
				if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848914032))
				{
					goto case 10;
				}
				goto case 2;
			default:
				if (num3 > 756052682)
				{
					num2 = 14;
					break;
				}
				goto case 1;
			case 7:
				if (num3 == 3688813071u)
				{
					if (KK0pSRDrKTKlPaGMWaxJ(P_0, jDdm1NDrrDpmirXOcOZD(0x78D396D8 ^ 0x78D36E96)))
					{
						goto case 10;
					}
					goto case 2;
				}
				if (num3 != 4204077332u)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 15;
			case 12:
				if (KK0pSRDrKTKlPaGMWaxJ(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520095451)))
				{
					goto case 10;
				}
				goto case 2;
			case 1:
				if (num3 != 661893800)
				{
					if (num3 != 756052682 || !(P_0 == (string)jDdm1NDrrDpmirXOcOZD(0x86EFEF6 ^ 0x86E099C)))
					{
						goto case 2;
					}
					goto case 10;
				}
				goto case 6;
			case 8:
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1346991775)))
				{
					goto case 2;
				}
				num2 = 19;
				break;
			case 4:
				num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public bool GetPropertyReadOnly(string P_0)
	{
		return false;
	}

	[OnDeserialized]
	private void vlJfYFSNsHf(StreamingContext P_0)
	{
		int num = 8;
		int num2 = num;
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!kiDXV5DrmPpJAYQLjF29(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x80940DB)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 6:
				if (!DClfYupLQn3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583289198)))
				{
					PlayOrderCancelRejectedSound = !flag || flag2;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 3:
				if (!kiDXV5DrmPpJAYQLjF29(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB1F452)))
				{
					PlayScreenerAlertSound = !flag || flag2;
				}
				ExtensionData = null;
				return;
			case 9:
				if (!DClfYupLQn3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2D0331)))
				{
					PlayOrderPlacedSound = !flag || flag2;
				}
				if (!DClfYupLQn3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962625031)))
				{
					PlayOrderRejectedSound = !flag || flag2;
					num2 = 10;
					break;
				}
				goto case 10;
			case 7:
				if (!kiDXV5DrmPpJAYQLjF29(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671169367)))
				{
					PlayConnectedSound = !flag || flag2;
					num2 = 4;
					break;
				}
				goto case 4;
			case 2:
				if (!DClfYupLQn3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECAC68C)))
				{
					PlayOrderCanceledSound = !flag || flag2;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 6;
			case 4:
				if (!DClfYupLQn3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x3741099A)))
				{
					PlayDisconnectedSound = !flag || flag2;
					num2 = 9;
					break;
				}
				goto case 9;
			case 10:
				if (kiDXV5DrmPpJAYQLjF29(jDdm1NDrrDpmirXOcOZD(-3429745 ^ -3451977)))
				{
					goto case 5;
				}
				PlayOrderModifiedSound = !flag || flag2;
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				if (!DClfYupLQn3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416988629)))
				{
					PlayOrderModifyRejectedSound = !flag || flag2;
					num2 = 2;
					break;
				}
				goto case 2;
			case 8:
				flag = ksPfY3Iv7b6(out flag2);
				num2 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				PlayOrderFilledSound = !flag || flag2;
				num2 = 3;
				break;
			}
		}
	}

	private bool ksPfY3Iv7b6(out bool P_0)
	{
		P_0 = false;
		if (nOUfoyPGmf5.TryGetValue((string)jDdm1NDrrDpmirXOcOZD(0x86EFEF6 ^ 0x86AF44E), out var value) && bool.TryParse(value, out var result))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				P_0 = result;
				return true;
			}
		}
		return false;
	}

	public IEnumerable<object> GetPropertyStandardValues(string P_0)
	{
		return PPM8INfv9VK01EnoXpRO.ipNfvio6OFp();
	}

	public bool GetPropertyVisibility(string P_0)
	{
		return true;
	}

	public static void wDkfYplXa43(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				NocqsiDrhSp0XVbHeuf2(ErGfoT72AoG);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				nOUfoyPGmf5.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (!h2y7aHDrw5O29N0DcrAA(P_0))
			{
				return;
			}
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(P_0);
				XmlElement documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					return;
				}
				while (true)
				{
					IEnumerator enumerator = ((XmlNodeList)HJZyC7Dr7KDt3k7gyvxk(documentElement)).GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 1:
						continue;
					}
					try
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								XmlNode xmlNode = (XmlNode)enumerator.Current;
								int num4 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										break;
									case 2:
										goto IL_0119;
									default:
										goto IL_016a;
									}
									break;
									IL_016a:
									string localName = xmlNode.LocalName;
									ErGfoT72AoG.Add(localName);
									nOUfoyPGmf5[localName] = xmlNode.InnerText;
									goto end_IL_00f1;
									IL_0119:
									if (xmlNode.NodeType != XmlNodeType.Element)
									{
										goto end_IL_00f1;
									}
									num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
									{
										num4 = 0;
									}
								}
								continue;
								end_IL_00f1:
								break;
							}
						}
						return;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num5 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						default:
							if (disposable != null)
							{
								jqaCJfDr8E2BdI8MNXH1(disposable);
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				UusDffDrArhOWLHbBZ28(ex);
				return;
			}
		}
	}

	private static bool DClfYupLQn3(string P_0)
	{
		return ErGfoT72AoG.Contains(P_0);
	}

	static UwYeOefYP8lJpje6lqk7()
	{
		parjF9DrPlhtsXRFY49i();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		ErGfoT72AoG = new HashSet<string>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		nOUfoyPGmf5 = new Dictionary<string, string>((IEqualityComparer<string>)PbwXJmDrJ205fIPYibXL());
	}

	internal static bool Ur3O9PDrZp01uybaUoaQ()
	{
		return i3JAfnDry22NC3miaTQe == null;
	}

	internal static UwYeOefYP8lJpje6lqk7 DHSbOqDrVumHSE1KnoFa()
	{
		return i3JAfnDry22NC3miaTQe;
	}

	internal static int mxbITtDrCIIunkItVxRU(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object jDdm1NDrrDpmirXOcOZD(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool KK0pSRDrKTKlPaGMWaxJ(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool kiDXV5DrmPpJAYQLjF29(object P_0)
	{
		return DClfYupLQn3((string)P_0);
	}

	internal static void NocqsiDrhSp0XVbHeuf2(object P_0)
	{
		((HashSet<string>)P_0).Clear();
	}

	internal static bool h2y7aHDrw5O29N0DcrAA(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object HJZyC7Dr7KDt3k7gyvxk(object P_0)
	{
		return ((XmlNode)P_0).ChildNodes;
	}

	internal static void jqaCJfDr8E2BdI8MNXH1(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void UusDffDrArhOWLHbBZ28(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static void parjF9DrPlhtsXRFY49i()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object PbwXJmDrJ205fIPYibXL()
	{
		return StringComparer.Ordinal;
	}
}
