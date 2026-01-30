using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace RPVQtsHPzsQV1qIogYUn;

[DataContract(Name = "RiskPortfolio", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Risk")]
internal sealed class KQbAjaHPuhQcsTd7NH8a : INotifyPropertyChanged, ICloneable
{
	private string ltUHF9q1UHM;

	private string m5VHFnZgAiS;

	[CompilerGenerated]
	private TimeSpan fNvHFGKT6C8;

	[CompilerGenerated]
	private DateTime lh6HFY2HekP;

	private decimal flWHFoTSySK;

	private decimal qNdHFvXqlW3;

	[CompilerGenerated]
	private decimal CDBHFBMutjk;

	private decimal lm6HFacAYmv;

	[CompilerGenerated]
	private decimal LSFHFihge3s;

	private int SHuHFlx8WsP;

	[CompilerGenerated]
	private int qDRHF4FltMT;

	private int td1HFDyKJJe;

	[CompilerGenerated]
	private int ePeHFbQ10uw;

	private int YrKHFNlT7w2;

	[CompilerGenerated]
	private int UNFHFkr1hhA;

	[CompilerGenerated]
	private bool z4mHF1TlCpA;

	[CompilerGenerated]
	private DateTime oMCHF59gPJe;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static KQbAjaHPuhQcsTd7NH8a zqYHxlDytNMmFOHOBAYG;

	[Browsable(false)]
	public string FullName => (string)t5OEoIDyZiOi9m1n14NQ(AccountName, A5l1gfDyy4DZKJxKQYlB(0x1AB79299 ^ 0x1AB464E7), SymbolName);

	[Browsable(false)]
	public string Key => Account + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29693558) + Symbol;

	[Browsable(false)]
	public string AccountName
	{
		get
		{
			if (rIqykGDyVGxURllqaLPw(Account))
			{
				return (string)siJMafDyCFahlYSUtMXv();
			}
			return Account;
		}
	}

	[Browsable(false)]
	public string vvHHJ4fKkK1
	{
		get
		{
			if (string.IsNullOrEmpty(Account))
			{
				return Resources.RiskPortfolioAll;
			}
			return Account;
		}
	}

	[Browsable(false)]
	public string SymbolName
	{
		get
		{
			Symbol symbol = SymbolManager.Get(Symbol);
			if (symbol == null)
			{
				return Resources.RiskPortfolioAllSymbols;
			}
			return (string)g82OB4Dyrcwvo1mHU0qs(symbol);
		}
	}

	[Browsable(false)]
	public string FpHHJNbBvoO
	{
		get
		{
			Symbol symbol = SymbolManager.Get(Symbol);
			if (symbol == null)
			{
				return (string)OmIhurDyKtjG8g7p4w2n();
			}
			return symbol.Name;
		}
	}

	[DataMember(Name = "Symbol")]
	[T4IXj62qBfXCaxs2RI5("RiskPortfolioParameters")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioSymbol")]
	public string Symbol
	{
		get
		{
			return ltUHF9q1UHM;
		}
		set
		{
			if (!nJBdZDDymxSMPbkZFFnR(text, ltUHF9q1UHM))
			{
				ltUHF9q1UHM = text ?? "";
				gseHJvMK7bV(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894909888));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				gseHJvMK7bV(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710436536));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("RiskPortfolioParameters")]
	[DataMember(Name = "Account")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioAccount")]
	public string Account
	{
		get
		{
			return m5VHFnZgAiS;
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
					if (m5VHFnZgAiS == text)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
						{
							num2 = 0;
						}
						break;
					}
					m5VHFnZgAiS = text ?? "";
					gseHJvMK7bV((string)A5l1gfDyy4DZKJxKQYlB(-2056710528 ^ -2056774744));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("RiskPortfolioParameters")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioResetTime")]
	[DataMember(Name = "ResetTime")]
	public TimeSpan CACHJeyCCiS
	{
		[CompilerGenerated]
		get
		{
			return fNvHFGKT6C8;
		}
		[CompilerGenerated]
		set
		{
			fNvHFGKT6C8 = timeSpan;
		}
	}

	[DataMember(Name = "ResetDateTime")]
	[Browsable(false)]
	public DateTime OOMHJc1aas9
	{
		[CompilerGenerated]
		get
		{
			return lh6HFY2HekP;
		}
		[CompilerGenerated]
		set
		{
			lh6HFY2HekP = dateTime;
		}
	}

	[DataMember(Name = "PosMaxSize")]
	[T4IXj62qBfXCaxs2RI5("RiskPortfolioLimits")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioPosMaxSize")]
	public decimal PosMaxSize
	{
		get
		{
			return flWHFoTSySK;
		}
		set
		{
			flWHFoTSySK = Math.Max(0m, val);
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioDayLoss")]
	[T4IXj62qBfXCaxs2RI5("RiskPortfolioLimits")]
	[DataMember(Name = "DayLossMax")]
	public decimal mpZHJgmsVbn
	{
		get
		{
			return qNdHFvXqlW3;
		}
		set
		{
			qNdHFvXqlW3 = Math.Max(0m, val);
		}
	}

	[Browsable(false)]
	[DataMember(Name = "DayLossCurrent")]
	public decimal EwFHJMMLHap
	{
		[CompilerGenerated]
		get
		{
			return CDBHFBMutjk;
		}
		[CompilerGenerated]
		set
		{
			CDBHFBMutjk = cDBHFBMutjk;
		}
	}

	[T4IXj62qBfXCaxs2RI5("RiskPortfolioLimits")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioDrawdown")]
	[DataMember(Name = "DrawdownMax")]
	public decimal sJMHJI52taP
	{
		get
		{
			return lm6HFacAYmv;
		}
		set
		{
			lm6HFacAYmv = Math.Max(0m, val);
		}
	}

	[DataMember(Name = "DrawdownCurrent")]
	[Browsable(false)]
	public decimal KlZHJUDfBZG
	{
		[CompilerGenerated]
		get
		{
			return LSFHFihge3s;
		}
		[CompilerGenerated]
		set
		{
			LSFHFihge3s = lSFHFihge3s;
		}
	}

	[T4IXj62qBfXCaxs2RI5("RiskPortfolioLimits")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioTotalTrades")]
	[DataMember(Name = "TotalTradesMax")]
	public int SvXHJZ10p6M
	{
		get
		{
			return SHuHFlx8WsP;
		}
		set
		{
			SHuHFlx8WsP = Math.Max(0, val);
		}
	}

	[DataMember(Name = "TotalTradesCurrent")]
	[Browsable(false)]
	public int sdWHJrQiPnC
	{
		[CompilerGenerated]
		get
		{
			return qDRHF4FltMT;
		}
		[CompilerGenerated]
		set
		{
			qDRHF4FltMT = num;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioLossTrades")]
	[T4IXj62qBfXCaxs2RI5("RiskPortfolioLimits")]
	[DataMember(Name = "LossTradesMax")]
	public int dQNHJh0Aa1Q
	{
		get
		{
			return td1HFDyKJJe;
		}
		set
		{
			td1HFDyKJJe = Math.Max(0, val);
		}
	}

	[DataMember(Name = "LossTradesCurrent")]
	[Browsable(false)]
	public int kBgHJ8GE8aV
	{
		[CompilerGenerated]
		get
		{
			return ePeHFbQ10uw;
		}
		[CompilerGenerated]
		set
		{
			ePeHFbQ10uw = num;
		}
	}

	[T4IXj62qBfXCaxs2RI5("RiskPortfolioLimits")]
	[bBo0Zd2ycQQr3LNHQf4("RiskPortfolioLossSequense")]
	[DataMember(Name = "LossSequenseMax")]
	public int YdCHJJbrCL1
	{
		get
		{
			return YrKHFNlT7w2;
		}
		set
		{
			YrKHFNlT7w2 = Math.Max(0, val);
		}
	}

	[Browsable(false)]
	[DataMember(Name = "LossSequenseCurrent")]
	public int vwgHJpO84NL
	{
		[CompilerGenerated]
		get
		{
			return UNFHFkr1hhA;
		}
		[CompilerGenerated]
		set
		{
			UNFHFkr1hhA = uNFHFkr1hhA;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "TradingLock")]
	public bool kybHF0DJKF0
	{
		[CompilerGenerated]
		get
		{
			return z4mHF1TlCpA;
		}
		[CompilerGenerated]
		set
		{
			z4mHF1TlCpA = flag;
		}
	}

	[DataMember(Name = "TradingLockExpiration")]
	[Browsable(false)]
	public DateTime O8CHFf1Ykuo
	{
		[CompilerGenerated]
		get
		{
			return oMCHF59gPJe;
		}
		[CompilerGenerated]
		set
		{
			oMCHF59gPJe = dateTime;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				case 1:
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)PuMZQbDyFQkCl5e2HX7W(propertyChangedEventHandler2, propertyChangedEventHandler3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
						{
							num = 0;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public bool VfyHJ0tnRui(string P_0, string P_1)
	{
		object obj;
		int num;
		Symbol symbol;
		if (string.IsNullOrEmpty(Account) || !(P_0 != Account))
		{
			symbol = SymbolManager.Get(Symbol);
			if (symbol != null)
			{
				obj = symbol.GetSymbol();
				goto IL_00ff;
			}
			num = 2;
		}
		else
		{
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
			{
				num = 0;
			}
		}
		goto IL_0009;
		IL_00ff:
		symbol = (Symbol)obj;
		if (symbol != null)
		{
			if (!(P_1 != symbol.ID))
			{
				goto IL_00e5;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
			{
				num = 0;
			}
		}
		goto IL_0009;
		IL_00e5:
		return true;
		IL_0009:
		switch (num)
		{
		case 3:
			return false;
		case 2:
			break;
		case 1:
			return false;
		default:
			goto IL_00e5;
		}
		obj = null;
		goto IL_00ff;
	}

	public KQbAjaHPuhQcsTd7NH8a()
	{
		WDgSjvDyhSrfuWI46meN();
		base._002Ector();
		CACHJeyCCiS = new TimeSpan(23, 55, 0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void nNOHJ2LAklF()
	{
		DateTime localTime = TimeHelper.LocalTime;
		if (OOMHJc1aas9 >= localTime)
		{
			return;
		}
		mVZHJ93WtG8();
		DateTime dateTime = new DateTime(localTime.Year, localTime.Month, localTime.Day);
		int num = 2;
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num)
			{
			case 2:
				dateTime2 = dateTime.Add(CACHJeyCCiS);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 3:
				OOMHJc1aas9 = dateTime2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num = 1;
				}
				break;
			default:
				if (wHwCSiDywY29Oha9lPpZ(dateTime2, localTime))
				{
					dateTime2 = dateTime2.AddDays(1.0);
					goto case 3;
				}
				num = 3;
				break;
			}
		}
	}

	private void NpsHJHyCDWw()
	{
		if (kybHF0DJKF0)
		{
			return;
		}
		int num;
		if (mpZHJgmsVbn > 0m)
		{
			if (!o8aZGHDy7H5W55qhKVSc(-EwFHJMMLHap, mpZHJgmsVbn))
			{
				num = 2;
			}
			else
			{
				dviHJfbhIp0();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
				{
					num = 0;
				}
			}
			goto IL_0009;
		}
		goto IL_01c3;
		IL_01c3:
		if (sJMHJI52taP > 0m && -KlZHJUDfBZG >= sJMHJI52taP)
		{
			num = 7;
		}
		else
		{
			if (SvXHJZ10p6M > 0 && sdWHJrQiPnC >= SvXHJZ10p6M)
			{
				dviHJfbhIp0();
				return;
			}
			if (dQNHJh0Aa1Q > 0)
			{
				goto IL_00d8;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
			{
				num = 1;
			}
		}
		goto IL_0009;
		IL_018c:
		if (vwgHJpO84NL < YdCHJJbrCL1)
		{
			return;
		}
		dviHJfbhIp0();
		int num2 = 3;
		goto IL_0005;
		IL_0005:
		num = num2;
		goto IL_0009;
		IL_00d8:
		if (kBgHJ8GE8aV >= dQNHJh0Aa1Q)
		{
			num2 = 4;
			goto IL_0005;
		}
		goto IL_0115;
		IL_0115:
		if (YdCHJJbrCL1 <= 0)
		{
			return;
		}
		goto IL_018c;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 3:
			return;
		case 4:
			dviHJfbhIp0();
			return;
		case 7:
			dviHJfbhIp0();
			return;
		case 6:
			break;
		case 1:
			goto IL_0115;
		case 5:
			goto IL_018c;
		case 0:
			return;
		case 2:
			goto IL_01c3;
		}
		goto IL_00d8;
	}

	private void dviHJfbhIp0()
	{
		kybHF0DJKF0 = true;
		O8CHFf1Ykuo = OOMHJc1aas9;
	}

	private void mVZHJ93WtG8()
	{
		EwFHJMMLHap = 0m;
		KlZHJUDfBZG = 0m;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
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
			{
				O8CHFf1Ykuo = DateTime.MinValue;
				int num2 = 2;
				num = num2;
				continue;
			}
			}
			sdWHJrQiPnC = 0;
			kBgHJ8GE8aV = 0;
			vwgHJpO84NL = 0;
			kybHF0DJKF0 = false;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
			{
				num = 1;
			}
		}
	}

	public bool l2JHJnClZFx()
	{
		if (wHwCSiDywY29Oha9lPpZ(O8CHFf1Ykuo, TimeHelper.LocalTime))
		{
			kybHF0DJKF0 = false;
		}
		return !kybHF0DJKF0;
	}

	public bool uZJHJGUZyAD(double P_0)
	{
		if (PchCl9Dy8aT2dUhYw8Ti(PosMaxSize, 0m))
		{
			return !((decimal)P_0 > PosMaxSize);
		}
		return true;
	}

	public void hgEHJYOINep(double P_0)
	{
		nNOHJ2LAklF();
		EwFHJMMLHap += QcpYT8DyAixMWNCEOZT8(P_0);
		KlZHJUDfBZG = opWehtDyJYD7Sa9i19PZ(0m, XhCb8qDyPMvepHjVvF6l(KlZHJUDfBZG, (decimal)P_0));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				vwgHJpO84NL++;
				goto IL_008d;
			default:
				num2 = sdWHJrQiPnC;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				sdWHJrQiPnC = num2 + 1;
				num = 4;
				break;
			case 3:
				kBgHJ8GE8aV = num2 + 1;
				num = 2;
				break;
			case 4:
				{
					if (!(P_0 < 0.0))
					{
						vwgHJpO84NL = 0;
						goto IL_008d;
					}
					num2 = kBgHJ8GE8aV;
					num = 3;
					break;
				}
				IL_008d:
				NpsHJHyCDWw();
				return;
			}
		}
	}

	public void yS7HJonD8Gq()
	{
		nNOHJ2LAklF();
		NpsHJHyCDWw();
	}

	public override string ToString()
	{
		return FullName;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	[NotifyPropertyChangedInvocator]
	private void gseHJvMK7bV([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static KQbAjaHPuhQcsTd7NH8a()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object A5l1gfDyy4DZKJxKQYlB(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object t5OEoIDyZiOi9m1n14NQ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool d16OL6DyUQn73UenH1nL()
	{
		return zqYHxlDytNMmFOHOBAYG == null;
	}

	internal static KQbAjaHPuhQcsTd7NH8a ABl3uNDyTQIx5dHftTNB()
	{
		return zqYHxlDytNMmFOHOBAYG;
	}

	internal static bool rIqykGDyVGxURllqaLPw(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object siJMafDyCFahlYSUtMXv()
	{
		return Resources.RiskPortfolioAllAccounts;
	}

	internal static object g82OB4Dyrcwvo1mHU0qs(object P_0)
	{
		return ((Symbol)P_0).Name;
	}

	internal static object OmIhurDyKtjG8g7p4w2n()
	{
		return Resources.RiskPortfolioAll;
	}

	internal static bool nJBdZDDymxSMPbkZFFnR(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void WDgSjvDyhSrfuWI46meN()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool wHwCSiDywY29Oha9lPpZ(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static bool o8aZGHDy7H5W55qhKVSc(decimal P_0, decimal P_1)
	{
		return P_0 >= P_1;
	}

	internal static bool PchCl9Dy8aT2dUhYw8Ti(decimal P_0, decimal P_1)
	{
		return P_0 > P_1;
	}

	internal static decimal QcpYT8DyAixMWNCEOZT8(double P_0)
	{
		return (decimal)P_0;
	}

	internal static decimal XhCb8qDyPMvepHjVvF6l(decimal P_0, decimal P_1)
	{
		return P_0 + P_1;
	}

	internal static decimal opWehtDyJYD7Sa9i19PZ(decimal P_0, decimal P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object PuMZQbDyFQkCl5e2HX7W(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}
}
