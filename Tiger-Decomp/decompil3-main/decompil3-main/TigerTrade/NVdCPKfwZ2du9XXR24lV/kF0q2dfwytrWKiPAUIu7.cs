using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Media;
using aca0UM2bNj5rUnold3KQ;
using ECOEgqlSad8NUJZ2Dr9n;
using kHAs2cfl7hDVW64jByhf;
using LyhxtU2baEmYGKCYg2dY;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Dx;
using TigerTrade.Properties;
using TU1GsM2Dm9QaIaTGcmUQ;
using TuAMtrl1Nd3XoZQQUXf0;

namespace NVdCPKfwZ2du9XXR24lV;

[ReadOnly(true)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[DataContract(Name = "MarketDomFilter", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Settings")]
internal class kF0q2dfwytrWKiPAUIu7 : wNkTg8flwnoQb0vtSgf4
{
	private bool RiMf7aA0NdD;

	private tuubIB2bbAR8R6rFpai8 OaSf7i4bpWA;

	private jePqt32bBmSdvMA1gTDC Eqpf7la7wUG;

	private jePqt32bBmSdvMA1gTDC Bqif740xjpO;

	private XColor SOLf7DeV7nw;

	private XColor lLGf7bco7TQ;

	[CompilerGenerated]
	private bool HkDf7NC0Nox;

	internal static kF0q2dfwytrWKiPAUIu7 AsF7hMbanQyIYA5cLPRR;

	[DataMember(Name = "Enabled")]
	[T4IXj62qBfXCaxs2RI5("MarketDomFilter")]
	[NotifyParentProperty(true)]
	[DefaultValue(true)]
	[Description("CommonTemplate")]
	[bBo0Zd2ycQQr3LNHQf4("MarketDomFilterEnabled")]
	public bool Enabled
	{
		get
		{
			return RiMf7aA0NdD;
		}
		set
		{
			if (flag != RiMf7aA0NdD)
			{
				RiMf7aA0NdD = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				aETflPO46K0((string)RjrA2Wbao4B438jhKY14(-1380525184 ^ -1380782688));
			}
		}
	}

	[DataMember(Name = "MinValueRatioParam")]
	public tuubIB2bbAR8R6rFpai8 u9qfw8UT3gF
	{
		get
		{
			return OaSf7i4bpWA ?? (OaSf7i4bpWA = new tuubIB2bbAR8R6rFpai8(null));
		}
		set
		{
			OaSf7i4bpWA = oaSf7i4bpWA;
		}
	}

	[T4IXj62qBfXCaxs2RI5("MarketDomFilter")]
	[NotifyParentProperty(true)]
	[Description("CommonTemplate&SimplifiedTemplate")]
	[bBo0Zd2ycQQr3LNHQf4("MarketDomFilterMinValueRatio")]
	[DefaultValue(null)]
	public double? MinValueRatio
	{
		get
		{
			return u9qfw8UT3gF.Jva2DwEHfew(base.OURflzaw42X);
		}
		set
		{
			u9qfw8UT3gF.M6I2bksByXP(base.OURflzaw42X, num, 0.0, 10.0);
			aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -448973748));
		}
	}

	[DataMember(Name = "MinValueParam")]
	public jePqt32bBmSdvMA1gTDC Hxhfw3uFfpY
	{
		get
		{
			return Eqpf7la7wUG ?? (Eqpf7la7wUG = new jePqt32bBmSdvMA1gTDC(null));
		}
		set
		{
			Eqpf7la7wUG = eqpf7la7wUG;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("MarketDomFilterMinValue")]
	[Description("CommonTemplate&SimplifiedTemplate")]
	[T4IXj62qBfXCaxs2RI5("MarketDomFilter")]
	[DefaultValue(null)]
	[NotifyParentProperty(true)]
	public long? MinValue
	{
		get
		{
			return Hxhfw3uFfpY.Jva2DwEHfew(base.OURflzaw42X);
		}
		set
		{
			if (Hxhfw3uFfpY.GhN2biFSQFS(base.OURflzaw42X, num, 0L))
			{
				aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690544433));
			}
		}
	}

	[DataMember(Name = "MaxValueParam")]
	public jePqt32bBmSdvMA1gTDC RPOf72J0lh7
	{
		get
		{
			return Bqif740xjpO ?? (Bqif740xjpO = new jePqt32bBmSdvMA1gTDC(null));
		}
		set
		{
			Bqif740xjpO = bqif740xjpO;
		}
	}

	[NotifyParentProperty(true)]
	[T4IXj62qBfXCaxs2RI5("MarketDomFilter")]
	[DefaultValue(null)]
	[Description("CommonTemplate")]
	[bBo0Zd2ycQQr3LNHQf4("MarketDomFilterMaxValue")]
	public long? MaxValue
	{
		get
		{
			return RPOf72J0lh7.Jva2DwEHfew(base.OURflzaw42X);
		}
		set
		{
			if (RPOf72J0lh7.GhN2biFSQFS(base.OURflzaw42X, num, 0L))
			{
				if (num.HasValue)
				{
					MinValueRatio = null;
				}
				aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB3A4AB));
			}
		}
	}

	[Browsable(false)]
	[Description("CommonTemplate")]
	[DataMember(Name = "BackColor")]
	public XColor BackColor
	{
		get
		{
			return SOLf7DeV7nw;
		}
		set
		{
			if (!(xColor == SOLf7DeV7nw))
			{
				SOLf7DeV7nw = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435624517));
			}
		}
	}

	[Browsable(false)]
	[Description("CommonTemplate")]
	[DataMember(Name = "TextColor")]
	public XColor TextColor
	{
		get
		{
			return lLGf7bco7TQ;
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
					if (xColor == lLGf7bco7TQ)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					lLGf7bco7TQ = xColor;
					aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x148717AE));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public bool hblf7BO5Kfl
	{
		[CompilerGenerated]
		get
		{
			return HkDf7NC0Nox;
		}
		[CompilerGenerated]
		set
		{
			HkDf7NC0Nox = hkDf7NC0Nox;
		}
	}

	public kF0q2dfwytrWKiPAUIu7()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
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
			Enabled = true;
			BackColor = Colors.Orange;
			TextColor = Colors.White;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
			{
				num = 1;
			}
		}
	}

	public kF0q2dfwytrWKiPAUIu7(kF0q2dfwytrWKiPAUIu7 P_0, bool P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		MthfwKNJ1cE(P_0, P_1);
	}

	public void WsufwVDhSYT(long P_0)
	{
		int num = 1;
		int num2 = num;
		double? num3 = default(double?);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num3.HasValue)
				{
					MinValue = (long)Math.Round((double)P_0 * MinValueRatio.Value);
					MaxValue = null;
				}
				return;
			case 1:
				num3 = MinValueRatio;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void mYqfwCiG7ZQ(string P_0)
	{
		if (!(base.OURflzaw42X == P_0))
		{
			base.OURflzaw42X = P_0;
			wMLfwrd8g1U();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
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

	private void wMLfwrd8g1U()
	{
		aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFE8E9A));
		aETflPO46K0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -61127639));
	}

	private void MthfwKNJ1cE(kF0q2dfwytrWKiPAUIu7 P_0, bool P_1)
	{
		Enabled = SsTgDxbavdsnjV0TwUtd(P_0);
		int num;
		if (P_1)
		{
			Hxhfw3uFfpY.QSM2D8R8ont(P_0.Hxhfw3uFfpY, _0020: true);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
			{
				num = 0;
			}
		}
		else
		{
			MinValue = P_0.Hxhfw3uFfpY.Value;
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 3:
				TextColor = VYgmgsbaa5Zh52tXJ241(P_0);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				MaxValue = P_0.RPOf72J0lh7.Value;
				MinValueRatio = P_0.MinValueRatio;
				break;
			case 1:
				wMLfwrd8g1U();
				num = 4;
				continue;
			default:
				RPOf72J0lh7.QSM2D8R8ont((NeyDU62DKFU8Qyxyvfd6<long?>)jvwDvybaB3Ec113bRAlg(P_0), _0020: true);
				u9qfw8UT3gF.QSM2D8R8ont(P_0.u9qfw8UT3gF, _0020: true);
				break;
			}
			BackColor = P_0.BackColor;
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
			{
				num = 3;
			}
		}
	}

	public override string ToString()
	{
		if (!Enabled)
		{
			goto IL_00a8;
		}
		long? num;
		int num2;
		if (!MinValue.HasValue)
		{
			num = MaxValue;
			num2 = 3;
			goto IL_0009;
		}
		goto IL_00ae;
		IL_00ae:
		num = MinValue;
		num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
		{
			num2 = 0;
		}
		goto IL_0009;
		IL_00a8:
		return Resources.MarketDomFilterDisabled;
		IL_0009:
		while (true)
		{
			string text;
			switch (num2)
			{
			case 1:
				text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009531039);
				goto IL_00fb;
			default:
				if (num.HasValue)
				{
					num = MinValue;
					num2 = 2;
					continue;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				break;
			case 2:
				{
					text = num.ToString();
					goto IL_00fb;
				}
				IL_00fb:
				return string.Concat(str2: MaxValue.HasValue ? MaxValue.ToString() : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DEC653), str0: text, str1: stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x70656599));
			}
			break;
		}
		if (!num.HasValue)
		{
			goto IL_00a8;
		}
		goto IL_00ae;
	}

	public override object Clone()
	{
		kF0q2dfwytrWKiPAUIu7 obj = new kF0q2dfwytrWKiPAUIu7();
		obj.MthfwKNJ1cE(this, _0020: true);
		return obj;
	}

	static kF0q2dfwytrWKiPAUIu7()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object RjrA2Wbao4B438jhKY14(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Mn7NiTbaGr80Nm9oUDu6()
	{
		return AsF7hMbanQyIYA5cLPRR == null;
	}

	internal static kF0q2dfwytrWKiPAUIu7 VeD4sKbaYYRxTgRKXuNH()
	{
		return AsF7hMbanQyIYA5cLPRR;
	}

	internal static bool SsTgDxbavdsnjV0TwUtd(object P_0)
	{
		return ((kF0q2dfwytrWKiPAUIu7)P_0).Enabled;
	}

	internal static object jvwDvybaB3Ec113bRAlg(object P_0)
	{
		return ((kF0q2dfwytrWKiPAUIu7)P_0).RPOf72J0lh7;
	}

	internal static XColor VYgmgsbaa5Zh52tXJ241(object P_0)
	{
		return ((kF0q2dfwytrWKiPAUIu7)P_0).TextColor;
	}
}
