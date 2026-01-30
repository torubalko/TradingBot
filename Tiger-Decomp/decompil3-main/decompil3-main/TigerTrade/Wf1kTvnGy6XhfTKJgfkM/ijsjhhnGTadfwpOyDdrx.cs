using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using Bs9FfLq8LSV7wJhpolq;
using ECOEgqlSad8NUJZ2Dr9n;
using Io0TBCnnT6SonDXm9K0y;
using JDQ6KCGfdXAs3N4Dq3K0;
using TigerTrade.Chart.Base;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace Wf1kTvnGy6XhfTKJgfkM;

internal sealed class ijsjhhnGTadfwpOyDdrx : SymbolBase, IChartSymbol
{
	[CompilerGenerated]
	private readonly string IIdnYS2R3Ze;

	[CompilerGenerated]
	private readonly string G2inYxuc6Pt;

	[CompilerGenerated]
	private readonly int F47nYLsQoBt;

	[CompilerGenerated]
	private int Ai7nYeeedbG;

	[CompilerGenerated]
	private readonly string xwNnYsR2gf7;

	[CompilerGenerated]
	private double GIQnYX9HPQS;

	[CompilerGenerated]
	private readonly double OMonYcLnA0N;

	[CompilerGenerated]
	private readonly decimal zihnYj2qw2B;

	[CompilerGenerated]
	private readonly long AyonYE4RyQc;

	[CompilerGenerated]
	private readonly int EUrnYQjsw0u;

	[CompilerGenerated]
	private readonly int SWunYdqEUlb;

	[CompilerGenerated]
	private readonly SymbolType jijnYgoGXXt;

	private readonly NumberFormatInfo aqsnYRIfxCY;

	private readonly CultureInfo FyrnY6aCjnO;

	internal static ijsjhhnGTadfwpOyDdrx vcuJqnbPzIvlZ51GJAhE;

	public string Code
	{
		[CompilerGenerated]
		get
		{
			return IIdnYS2R3Ze;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return G2inYxuc6Pt;
		}
	}

	public int Decimals
	{
		[CompilerGenerated]
		get
		{
			return F47nYLsQoBt;
		}
	}

	public string Currency
	{
		[CompilerGenerated]
		get
		{
			return xwNnYsR2gf7;
		}
	}

	public double LotStep
	{
		[CompilerGenerated]
		get
		{
			return GIQnYX9HPQS;
		}
		[CompilerGenerated]
		private set
		{
			GIQnYX9HPQS = gIQnYX9HPQS;
		}
	}

	public decimal StepPrice
	{
		[CompilerGenerated]
		get
		{
			return zihnYj2qw2B;
		}
	}

	public SymbolType Type
	{
		[CompilerGenerated]
		get
		{
			return jijnYgoGXXt;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int ho2nYHTryiS()
	{
		return Ai7nYeeedbG;
	}

	[SpecialName]
	[CompilerGenerated]
	private void LjwnYf9tREG(int P_0)
	{
		Ai7nYeeedbG = P_0;
	}

	[SpecialName]
	public double MUMnYooWDEl()
	{
		if (!lJNa1bbJHCBTNZYFDQvw(this))
		{
			return base.Step * LotStep;
		}
		return base.ContractValue * xUwhO7bJflHBGLDHmplw(this) * LotStep;
	}

	[SpecialName]
	public double l1gnYBxuVo7()
	{
		if (!lJNa1bbJHCBTNZYFDQvw(this))
		{
			return myUnYiqx2XK() * LotStep;
		}
		return base.ContractValue * myUnYiqx2XK() * LotStep;
	}

	[SpecialName]
	[CompilerGenerated]
	public double myUnYiqx2XK()
	{
		return OMonYcLnA0N;
	}

	[SpecialName]
	[CompilerGenerated]
	public long NOvnY43A4X4()
	{
		return AyonYE4RyQc;
	}

	[SpecialName]
	[CompilerGenerated]
	public int LNPnYb1KgZV()
	{
		return EUrnYQjsw0u;
	}

	[SpecialName]
	[CompilerGenerated]
	public int tWZnYkBOT9A()
	{
		return SWunYdqEUlb;
	}

	public ijsjhhnGTadfwpOyDdrx(Symbol P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		aqsnYRIfxCY = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x347D649), useUserOverride: false).NumberFormat;
		FyrnY6aCjnO = new CultureInfo((string)aMW2i6bJ9fZ0PqwaT5Uv(--18459671 ^ 0x11A7DE5));
		base._002Ector();
		IIdnYS2R3Ze = P_0.ID;
		G2inYxuc6Pt = P_0.Name;
		int num = 4;
		while (true)
		{
			int num2 = num;
			long ayonYE4RyQc;
			while (true)
			{
				switch (num2)
				{
				case 8:
					F47nYLsQoBt = P_0.Precision;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					QH8MPMbJBkAtJuVSWws5(this, P_0.SizeStep);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 7:
					SWunYdqEUlb = P_0.PnlPrecision;
					jijnYgoGXXt = acbwsZbJluix5HJDvVS3(P_0);
					xwNnYsR2gf7 = (string)cO52oWbJ4FjIEy9UTLcY(P_0);
					ayonYE4RyQc = (P_0.IsDenomination ? ((long)P_0.ContractValue) : ((long)(1.0 / sHMsSgbJDltYxBum9dOp(this))));
					goto end_IL_006b;
				default:
					base.IsDenomination = P_0.IsDenomination;
					base.NeedHistoryCorrect = QD8NlXbJa84nuGVm5jt7(P_0);
					EUrnYQjsw0u = iZ1svIbJi60VoNJeQyGj(P_0);
					num2 = 7;
					break;
				case 3:
					LotStep = Nc9vSlbJoLVWbMXTav1x(P_0);
					base.ContractValue = P_0.ContractValue;
					OMonYcLnA0N = P_0.Step;
					num2 = 6;
					break;
				case 4:
					base.Exchange = (string)boHwpibJnZpZGsLcdHn0(P_0);
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
					{
						num2 = 6;
					}
					break;
				case 6:
					zihnYj2qw2B = a8YkqmbJvY73SPYbRbTK(P_0.GetStepPrice());
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					LjwnYf9tREG(Wst0NtbJGci4XaXxtuXB(P_0));
					iXPDc9bJYDLrKBojFlDt(this, P_0.Step);
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_006b:
				break;
			}
			AyonYE4RyQc = ayonYE4RyQc;
			num = 2;
		}
	}

	public void uqMnGZULX5S(double P_0)
	{
		base.Step = P_0;
		LjwnYf9tREG(xJABt8GfQN3bpiGT4k9G.LocGfReqp7D(P_0));
	}

	public double GetPrice(long P_0)
	{
		return (double)P_0 * base.Step;
	}

	public long GetRawQuoteSize(long P_0, long P_1, int P_2 = 1)
	{
		double num = ((base.IsDenomination && sHMsSgbJDltYxBum9dOp(this) < 1.0) ? ((double)P_1) : ((double)P_1 * sHMsSgbJDltYxBum9dOp(this)));
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => (long)((double)P_0 * (num / LotStep) / (double)P_2), 
		};
	}

	public long hlJnGV6qLWT(long P_0)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = (double)P_0 * base.Step;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (lJNa1bbJHCBTNZYFDQvw(this) && xUwhO7bJflHBGLDHmplw(this) < 1.0)
				{
					num3 *= zCO2XlbJbfxZLZVKSKEK(this);
				}
				return (long)num3;
			}
		}
	}

	public double nlhnGCG2624(long P_0, long P_1)
	{
		if (base.IsDenomination)
		{
			return (double)P_1 * myUnYiqx2XK() * ((double)P_0 * base.ContractValue);
		}
		if (!(base.SizeStep < 1.0))
		{
			return (double)P_1 * myUnYiqx2XK() * (double)P_0;
		}
		return (double)P_1 * myUnYiqx2XK() * ((double)P_0 * base.SizeStep);
	}

	public string JcjnGr27qRe(decimal P_0, int P_1 = 3)
	{
		aqsnYRIfxCY.PercentDecimalDigits = P_1;
		return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377134129), aqsnYRIfxCY);
	}

	public decimal GetSize(long P_0)
	{
		double num;
		if (lJNa1bbJHCBTNZYFDQvw(this))
		{
			if (base.SizeStep < 1.0)
			{
				num = (double)P_0 * base.ContractValue;
				goto IL_0071;
			}
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
		}
		num = (double)P_0 * sHMsSgbJDltYxBum9dOp(this);
		goto IL_0071;
		IL_0071:
		return (decimal)num;
	}

	public string F7PnGKuif8P(double P_0, bool P_1 = false)
	{
		return P_0.ToString((string)yigWqcbJNWP1HCIVHRUE(aMW2i6bJ9fZ0PqwaT5Uv(0x130FEA25 ^ 0x130FC5C9), (P_1 ? ho2nYHTryiS() : Decimals).ToString()));
	}

	public string FormatPrice(decimal P_0, bool P_1 = false)
	{
		return P_0.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-225822163 ^ -225831487) + (P_1 ? ho2nYHTryiS() : Decimals));
	}

	public string FormatRawPrice(long P_0, bool P_1 = false)
	{
		return F7PnGKuif8P((double)P_0 * base.Step, P_1);
	}

	public string FqunGmNxUTm(long P_0, bool P_1, int P_2)
	{
		double num = (double)P_0 * base.Step;
		if (P_2 > 0)
		{
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			default:
			{
				int num3 = (int)(num * (double)xJABt8GfQN3bpiGT4k9G.bFKGfOYMUp3[ho2nYHTryiS()] + 0.5);
				if (P_0 >= 0)
				{
					return (string)aMW2i6bJ9fZ0PqwaT5Uv(-602153869 ^ -601924243) + P_2 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D30DE4) + num3;
				}
				return (string)NmVFlZbJkPeIV7ubFyH0(aMW2i6bJ9fZ0PqwaT5Uv(-1848952786 ^ -1848657654), P_2.ToString(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B022DA), (-num3).ToString());
			}
			}
		}
		return F7PnGKuif8P(num, P_1);
	}

	public string uhTnGh8ahcs(long P_0, bool P_1 = false)
	{
		return F7PnGKuif8P((double)P_0 * myUnYiqx2XK(), P_1);
	}

	public string FormatSize(decimal P_0, int P_1 = 2)
	{
		return Fv5nGw2n73r((double)P_0, P_1);
	}

	public string Fv5nGw2n73r(double P_0, int P_1 = 2)
	{
		if (P_1 >= 0)
		{
			if (!(sHMsSgbJDltYxBum9dOp(this) < 1.0))
			{
				return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53799448));
			}
			return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848961086) + P_1);
		}
		double num = P_0 / Math.Pow(10.0, -P_1);
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => num.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-342738082 ^ -342722814)), 
		};
	}

	public string FormatSize(decimal P_0, int P_1, bool P_2)
	{
		return MocnG7k2wy1(cdP5N0bJ1N8fkdm9vcu4(P_0), P_1, P_2);
	}

	public string MocnG7k2wy1(double P_0, int P_1, bool P_2)
	{
		int num;
		if (P_1 >= 0)
		{
			if (sHMsSgbJDltYxBum9dOp(this) < 1.0)
			{
				if (!P_2)
				{
					return P_0.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-1127423276 ^ -1127428808) + P_1);
				}
				return (string)mLeWS2bJ5Zn6wWEigeTn(P_0);
			}
			if (P_2)
			{
				return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(P_0);
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
			{
				num = 0;
			}
		}
		else
		{
			P_0 /= Math.Pow(10.0, -P_1);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		default:
			return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522715359));
		case 1:
			if (!P_2)
			{
				return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130FA679));
			}
			return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(P_0);
		}
	}

	public string FormatSizeShort(decimal P_0)
	{
		return HO0nG8GiTiX((double)P_0);
	}

	public string HO0nG8GiTiX(double P_0)
	{
		if (!(sHMsSgbJDltYxBum9dOp(this) < 1.0))
		{
			return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB153436));
		}
		return P_0.ToString((string)((wEvMxybJSVBsxR9m4x66(P_0) >= 10.0) ? aMW2i6bJ9fZ0PqwaT5Uv(0x769C7931 ^ 0x769C356D) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673706307)));
	}

	public string FormatSizeFull(decimal P_0)
	{
		return duBnGApCnU2((double)P_0);
	}

	public string duBnGApCnU2(double P_0)
	{
		if (!(base.SizeStep < 1.0))
		{
			return P_0.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-60853733 ^ -60867001));
		}
		return P_0.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(0x68DEE0F ^ 0x68D840B));
	}

	public string FormatRawSize(long P_0, int P_1 = 2)
	{
		double num = ((base.SizeStep < 1.0) ? ((double)P_0 * base.SizeStep) : ((double)P_0));
		int num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
		{
			num2 = 0;
		}
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (base.IsDenomination && sHMsSgbJDltYxBum9dOp(this) < 1.0)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 2:
				num = (double)P_0 * base.ContractValue;
				num2 = 3;
				break;
			case 3:
				if (P_1 < 0)
				{
					num3 = num / DJhxDgbJxPb1WUCEchhf(10.0, -P_1);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!(sHMsSgbJDltYxBum9dOp(this) < 1.0))
				{
					return num.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B0F5BA));
				}
				return num.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F55CAD4) + P_1);
			default:
				return num3.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBEA66D));
			}
		}
	}

	public string FormatRawSize(long P_0, int P_1, bool P_2)
	{
		double num = ((sHMsSgbJDltYxBum9dOp(this) < 1.0) ? ((double)P_0 * base.SizeStep) : ((double)P_0));
		int num3;
		if (base.IsDenomination && base.SizeStep < 1.0)
		{
			num = (double)P_0 * base.ContractValue;
			int num2 = 3;
			num3 = num2;
			goto IL_0009;
		}
		goto IL_0118;
		IL_0040:
		return num.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(0x7F645F3C ^ 0x7F641360));
		IL_0009:
		while (true)
		{
			switch (num3)
			{
			case 1:
				goto IL_00cb;
			case 2:
				goto IL_010d;
			case 3:
				goto IL_0118;
			case 4:
				return num.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-1309555870 ^ -1309545330) + P_1);
			}
			break;
			IL_00cb:
			if (!P_2)
			{
				num3 = 4;
				continue;
			}
			return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num);
		}
		goto IL_0040;
		IL_0118:
		if (P_1 < 0)
		{
			num /= DJhxDgbJxPb1WUCEchhf(10.0, -P_1);
			num3 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
			{
				num3 = 2;
			}
		}
		else
		{
			if (!(sHMsSgbJDltYxBum9dOp(this) < 1.0))
			{
				if (P_2)
				{
					return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num);
				}
				goto IL_0040;
			}
			num3 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
			{
				num3 = 0;
			}
		}
		goto IL_0009;
		IL_010d:
		if (!P_2)
		{
			return num.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(0x7394D272 ^ 0x73949E2E));
		}
		return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num);
	}

	public string FormatRawQuoteSize(long P_0, int P_1, bool P_2)
	{
		int num = 3;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!P_2)
				{
					return num3.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D5577BC));
				}
				return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num3);
			case 1:
				if (!P_2)
				{
					return num3.ToString((string)yigWqcbJNWP1HCIVHRUE(aMW2i6bJ9fZ0PqwaT5Uv(0x6D18F862 ^ 0x6D18D78E), P_1.ToString()));
				}
				return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num3);
			case 3:
				num3 = (double)P_0 * LotStep * base.Step;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				num3 *= zCO2XlbJbfxZLZVKSKEK(this);
				goto IL_006b;
			case 5:
				num3 /= Math.Pow(10.0, -P_1);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				{
					if (base.IsDenomination && base.SizeStep < 1.0)
					{
						num2 = 4;
						break;
					}
					goto IL_006b;
				}
				IL_006b:
				if (P_1 < 0)
				{
					num2 = 5;
					break;
				}
				if (!(LotStep * base.Step < 1.0))
				{
					if (!P_2)
					{
						return num3.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123790351));
					}
					return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num3);
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public string oFonGPo7jqW(double P_0)
	{
		string text = McPEV4q7m2685kMvrQH.bR1qJgPHqX(j18iDj9nukSCmEyZs5lH.Settings.QuoteCurrencyOrderDecimals, _0020: true);
		return P_0.ToString(text, (IFormatProvider)d6CTlabJLSqRmVKr4agB());
	}

	public string PtUnGJZaYC0(long P_0, long P_1)
	{
		if (lJNa1bbJHCBTNZYFDQvw(this))
		{
			double num = (double)P_1 * base.Step * ((double)P_0 * base.ContractValue);
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			default:
				return num.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD5F4EF));
			case 1:
				break;
			}
		}
		if (!(sHMsSgbJDltYxBum9dOp(this) < 1.0))
		{
			return ((double)P_1 * base.Step * (double)P_0).ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490974484));
		}
		return ((double)P_1 * xUwhO7bJflHBGLDHmplw(this) * ((double)P_0 * sHMsSgbJDltYxBum9dOp(this))).ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047138933));
	}

	public string FormatRawSizeShort(long P_0)
	{
		int num = 1;
		int num2 = num;
		double value = default(double);
		while (true)
		{
			double num3;
			switch (num2)
			{
			default:
				num3 = P_0;
				goto IL_00eb;
			case 3:
				if (!(base.SizeStep < 1.0))
				{
					return value.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-1848952786 ^ -1848937358));
				}
				return value.ToString((Math.Abs(value) >= 10.0) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x684F243E ^ 0x684F6862) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710476388));
			case 1:
				if (!(sHMsSgbJDltYxBum9dOp(this) < 1.0))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				num3 = (double)P_0 * base.SizeStep;
				goto IL_00eb;
			case 2:
				{
					value = (double)P_0 * base.ContractValue;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_00eb:
				value = num3;
				if (lJNa1bbJHCBTNZYFDQvw(this) && base.SizeStep < 1.0)
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public string FormatTrades(long P_0)
	{
		return P_0.ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-1416986301 ^ -1416966881));
	}

	public string FormatTrades(long P_0, int P_1, bool P_2)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (P_1 < 0)
				{
					num3 = (double)P_0 / DJhxDgbJxPb1WUCEchhf(10.0, -P_1);
					if (P_2)
					{
						return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num3);
					}
					goto case 2;
				}
				if (!P_2)
				{
					return num3.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3414317));
				}
				return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(num3);
			case 2:
				return num3.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B5C88E));
			}
		}
	}

	public string uFxnGFlmC1E(double P_0)
	{
		return (P_0 / myUnYiqx2XK() * (double)StepPrice).ToString((string)aMW2i6bJ9fZ0PqwaT5Uv(-520155535 ^ -520132723));
	}

	public string AYZnG3b2I7A(double P_0)
	{
		return P_0.ToString((string)yigWqcbJNWP1HCIVHRUE(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D12BE7), Decimals.ToString()));
	}

	public string aXYnGpTr3Ee(double P_0)
	{
		if (!(wEvMxybJSVBsxR9m4x66(P_0) >= 100.0))
		{
			return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736558740) + tWZnYkBOT9A());
		}
		return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5F57C2));
	}

	public string cDQnGuIji8y(double P_0)
	{
		return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D189196));
	}

	public string g1InGzrvM9M(double P_0)
	{
		return P_0.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x16AD7E76 ^ 0x16AC6942), FyrnY6aCjnO);
	}

	public long bDEnY0NwwJF(long P_0)
	{
		if (!base.IsDenomination)
		{
			return (long)((double)P_0 / sHMsSgbJDltYxBum9dOp(this));
		}
		return P_0 / (long)zCO2XlbJbfxZLZVKSKEK(this);
	}

	public long CorrectSizeFilter(double P_0)
	{
		if (!base.IsDenomination)
		{
			return (long)(P_0 / sHMsSgbJDltYxBum9dOp(this));
		}
		return (long)(P_0 / zCO2XlbJbfxZLZVKSKEK(this));
	}

	public long gN7nY27Lkwh(double P_0, bool P_1)
	{
		if (!P_1)
		{
			return (long)(P_0 / l1gnYBxuVo7() + 0.5);
		}
		return CorrectSizeFilter(P_0);
	}

	public long? CorrectSizeFilter(double? P_0)
	{
		if (P_0.HasValue)
		{
			return CorrectSizeFilter(P_0.Value);
		}
		return null;
	}

	public string FormatTime(DateTime P_0, string P_1)
	{
		return (string)LKp25BbJeaXQm9pkPOKM(P_0, P_1, base.Exchange);
	}

	public DateTime ConvertTimeToLocal(DateTime P_0)
	{
		return TimeHelper.ConvertTimeToLocal(P_0, base.Exchange);
	}

	public DateTime ConvertTimeFromLocal(DateTime P_0)
	{
		return TimeHelper.ConvertTimeFromLocal(P_0, base.Exchange);
	}

	public double CalculateVolumeToFilter(double P_0)
	{
		if (!lJNa1bbJHCBTNZYFDQvw(this))
		{
			return P_0 * base.SizeStep;
		}
		return P_0 * base.ContractValue;
	}

	public double CalculateVolumeInQuoteToFilter(double P_0)
	{
		return P_0 * MUMnYooWDEl();
	}

	public override string ToString()
	{
		return Name;
	}

	[SpecialName]
	string IChartSymbol.get_Exchange()
	{
		return base.Exchange;
	}

	[SpecialName]
	bool IChartSymbol.get_IsDenomination()
	{
		return base.IsDenomination;
	}

	string IChartSymbol.FormatRawSizeFull(long P_0)
	{
		return (string)fyMLelbJsFdCbhVPphaD(this, P_0);
	}

	static ijsjhhnGTadfwpOyDdrx()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool IeKc4HbJ0xfV28kRmhXI()
	{
		return vcuJqnbPzIvlZ51GJAhE == null;
	}

	internal static ijsjhhnGTadfwpOyDdrx LFGcn5bJ2M6IDjB8eaYT()
	{
		return vcuJqnbPzIvlZ51GJAhE;
	}

	internal static bool lJNa1bbJHCBTNZYFDQvw(object P_0)
	{
		return ((SymbolBase)P_0).IsDenomination;
	}

	internal static double xUwhO7bJflHBGLDHmplw(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static object aMW2i6bJ9fZ0PqwaT5Uv(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object boHwpibJnZpZGsLcdHn0(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static int Wst0NtbJGci4XaXxtuXB(object P_0)
	{
		return ((Symbol)P_0).Precision;
	}

	internal static void iXPDc9bJYDLrKBojFlDt(object P_0, double P_1)
	{
		((SymbolBase)P_0).Step = P_1;
	}

	internal static double Nc9vSlbJoLVWbMXTav1x(object P_0)
	{
		return ((Symbol)P_0).LotStep;
	}

	internal static decimal a8YkqmbJvY73SPYbRbTK(double P_0)
	{
		return (decimal)P_0;
	}

	internal static void QH8MPMbJBkAtJuVSWws5(object P_0, double P_1)
	{
		((SymbolBase)P_0).SizeStep = P_1;
	}

	internal static bool QD8NlXbJa84nuGVm5jt7(object P_0)
	{
		return ((SymbolBase)P_0).NeedHistoryCorrect;
	}

	internal static int iZ1svIbJi60VoNJeQyGj(object P_0)
	{
		return ((Symbol)P_0).SizePrecision;
	}

	internal static SymbolType acbwsZbJluix5HJDvVS3(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static object cO52oWbJ4FjIEy9UTLcY(object P_0)
	{
		return ((Symbol)P_0).Currency;
	}

	internal static double sHMsSgbJDltYxBum9dOp(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static double zCO2XlbJbfxZLZVKSKEK(object P_0)
	{
		return ((SymbolBase)P_0).ContractValue;
	}

	internal static object yigWqcbJNWP1HCIVHRUE(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object NmVFlZbJkPeIV7ubFyH0(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static double cdP5N0bJ1N8fkdm9vcu4(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object mLeWS2bJ5Zn6wWEigeTn(double P_0)
	{
		return MI4nfsnnUf3PYtFXkT2T.FqsnnVnHjED(P_0);
	}

	internal static double wEvMxybJSVBsxR9m4x66(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double DJhxDgbJxPb1WUCEchhf(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	internal static object d6CTlabJLSqRmVKr4agB()
	{
		return NumberFormatInfo.CurrentInfo;
	}

	internal static object LKp25BbJeaXQm9pkPOKM(DateTime P_0, object P_1, object P_2)
	{
		return TimeHelper.FormatTime(P_0, (string)P_1, (string)P_2);
	}

	internal static object fyMLelbJsFdCbhVPphaD(object P_0, long P_1)
	{
		return ((SymbolBase)P_0).FormatRawSizeFull(P_1);
	}
}
