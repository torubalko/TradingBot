using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Editors;
using Beq7rVHb9tpwOWxquPXs;
using Bs9FfLq8LSV7wJhpolq;
using CfRULU2btb1wjWVeHetO;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using waDpctGJom9MvAveNXHq;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Controls.LotSelect;

internal sealed class LotSelectControl : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	private readonly double xSxHothtU6X;

	private bool M8FHoUk3VVE;

	private bool XonHoTRQFH5;

	private bool zfaHoysZhJh;

	public static readonly DependencyProperty evaHoZkQ9Ap;

	public static readonly DependencyProperty ix2HoVwAHMQ;

	public static readonly DependencyProperty VJnHoCIVLge;

	public static readonly DependencyProperty Ir3HorX7AyV;

	public static readonly DependencyProperty NRiHoKMipEf;

	public static readonly DependencyProperty XHOHomTTMFG;

	public static readonly DependencyProperty w4XHohDGWGd;

	public static readonly DependencyProperty g4nHowZ7e2j;

	public static readonly DependencyProperty yJxHo7rIS5N;

	public static readonly DependencyProperty qBjHo8cUa1y;

	public static readonly DependencyProperty z8FHoAiR2JZ;

	public static readonly DependencyProperty nTTHoPvq52a;

	public static readonly DependencyProperty i0yHoJdtdmd;

	public static readonly DependencyProperty KOuHoFbi0rg;

	public static readonly DependencyProperty MRTHo3j8bLy;

	public static readonly DependencyProperty SnBHop9qmor;

	public static readonly DependencyProperty B5PHouQRQox;

	public static readonly DependencyProperty vwEHozkIGRJ;

	public static readonly DependencyProperty x3PHv0MuwwW;

	public static readonly DependencyProperty LVcHv2AKdhy;

	public static readonly DependencyProperty hA8HvH83XCs;

	public static readonly DependencyProperty zLBHvfsyYiA;

	public static readonly DependencyProperty ADZHv9n5qix;

	public static readonly DependencyProperty w3pHvnZoRwM;

	public static readonly DependencyProperty Ed9HvGeE7nC;

	public static readonly DependencyProperty zxZHvY6MNEN;

	public static readonly DependencyProperty IkrHvoj4uFs;

	public static readonly DependencyProperty k9eHvvWfGDe;

	public static readonly DependencyProperty k6FHvBh6PCb;

	public static readonly DependencyProperty ETXHvab0soR;

	public static readonly DependencyProperty mTaHviNa8GG;

	public static readonly DependencyProperty e1fHvlFEDe2;

	public static readonly DependencyProperty DpyHv4Z2ZHJ;

	public static readonly DependencyProperty AEtHvDhUpNu;

	public static readonly DependencyProperty HQKHvbBm1h5;

	public static readonly DependencyProperty QKqHvNRiW6p;

	private double YYGHvkYGEHj;

	private double zbyHv1cCrbC;

	private double z90Hv54vUaB;

	private double gpKHvSUsEIe;

	private double E5kHvx8pcvJ;

	private double oicHvL4RMTO;

	private double u5OHve9yT3K;

	private double oCiHvsB6MJj;

	private double GaaHvXspCCc;

	private double W0bHvcIevyY;

	private int RbIHvjlJEsI;

	private int svRHvENeHCV;

	private int PFAHvQ58aFF;

	private int Y8kHvd6qsRm;

	private int v1VHvgJu1BZ;

	internal LotSelectControl LotSelectViewControl;

	internal Border Row1Background;

	internal DoubleEditBox EditPreset1Size;

	internal DoubleEditBox EditQuote1;

	internal Int16EditBox EditPercent1;

	internal Border Row2Background;

	internal DoubleEditBox EditPreset2Size;

	internal DoubleEditBox EditQuote2;

	internal Int16EditBox EditPercent2;

	internal Border Row3Background;

	internal DoubleEditBox EditPreset3Size;

	internal DoubleEditBox EditQuote3;

	internal Int16EditBox EditPercent3;

	internal Border Row4Background;

	internal DoubleEditBox EditPreset4Size;

	internal DoubleEditBox EditQuote4;

	internal Int16EditBox EditPercent4;

	internal Border Row5Background;

	internal DoubleEditBox EditPreset5Size;

	internal DoubleEditBox EditQuote5;

	internal Int16EditBox EditPercent5;

	private bool oMFHvRFXEXo;

	internal static LotSelectControl LZ6R4HDbHnEARwIrKw6L;

	public double LotStep
	{
		get
		{
			return (double)GetValue(evaHoZkQ9Ap);
		}
		set
		{
			if (num != LotStep)
			{
				SetValue(evaHoZkQ9Ap, num);
			}
		}
	}

	public double PriceStep
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, ix2HoVwAHMQ);
		}
		set
		{
			if (PriceStep != num)
			{
				SetValue(ix2HoVwAHMQ, num);
			}
		}
	}

	public double SizeStep
	{
		get
		{
			return (double)GetValue(VJnHoCIVLge);
		}
		set
		{
			if (SizeStep != num)
			{
				UbVcGrDbYmxt40M59iAt(this, VJnHoCIVLge, num);
			}
		}
	}

	public double ContractValue
	{
		get
		{
			return (double)GetValue(Ir3HorX7AyV);
		}
		set
		{
			if (num != ContractValue)
			{
				UbVcGrDbYmxt40M59iAt(this, Ir3HorX7AyV, num);
			}
		}
	}

	public double QuoteSizeStep => zHeUnwDbvAkVYP9PpJx4(IGv11sDboq7ja8g0uRPf(LotStep, CurrentPrice, PriceStep), 2);

	public long CurrentPrice
	{
		get
		{
			return (long)GetValue(NRiHoKMipEf);
		}
		set
		{
			SetValue(NRiHoKMipEf, num);
		}
	}

	public double Leverage
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, XHOHomTTMFG);
		}
		set
		{
			SetValue(XHOHomTTMFG, num);
		}
	}

	public double CurrencyFreeMargin
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, w4XHohDGWGd);
		}
		set
		{
			SetValue(w4XHohDGWGd, num);
		}
	}

	public double Preset1
	{
		get
		{
			return YYGHvkYGEHj;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (XonHoTRQFH5)
					{
						sBMHGUpkjep(1);
						RumHGTS7wVU(1);
					}
					return;
				default:
					YYGHvkYGEHj = num3;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (!(sFsl1NDbB1kRqDYF84YO(Preset1Size - num3) > xSxHothtU6X))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					Preset1Size = num3;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECB2F2C));
					num2 = 3;
					break;
				}
			}
		}
	}

	public double Preset2
	{
		get
		{
			return zbyHv1cCrbC;
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
					zbyHv1cCrbC = num3;
					Preset2Size = num3;
					num2 = 3;
					break;
				case 3:
					cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x2D313048 ^ 0x2D30205E));
					if (XonHoTRQFH5)
					{
						sBMHGUpkjep(2);
						RumHGTS7wVU(2);
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!(Math.Abs(Preset2Size - num3) > xSxHothtU6X))
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public double Preset3
	{
		get
		{
			return z90Hv54vUaB;
		}
		set
		{
			if (!(Math.Abs(Preset3Size - num) > xSxHothtU6X))
			{
				return;
			}
			z90Hv54vUaB = num;
			Preset3Size = num;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
					RumHGTS7wVU(3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					return;
				}
				cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x2CBEEA31 ^ 0x2CBFFA19));
				if (XonHoTRQFH5)
				{
					sBMHGUpkjep(3);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				return;
			}
		}
	}

	public double Preset4
	{
		get
		{
			return gpKHvSUsEIe;
		}
		set
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
					if (!(sFsl1NDbB1kRqDYF84YO(Preset4Size - num3) > xSxHothtU6X))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					RumHGTS7wVU(4);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num2 = 2;
					}
					continue;
				}
				gpKHvSUsEIe = num3;
				Preset4Size = num3;
				cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(-839659358 ^ -839729000));
				if (!XonHoTRQFH5)
				{
					return;
				}
				sBMHGUpkjep(4);
				num2 = 3;
			}
		}
	}

	public double Preset5
	{
		get
		{
			return E5kHvx8pcvJ;
		}
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						break;
					case 1:
						if (Math.Abs(Preset5Size - num3) > xSxHothtU6X)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					case 3:
						return;
					default:
						E5kHvx8pcvJ = num3;
						Preset5Size = num3;
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371701421));
						if (XonHoTRQFH5)
						{
							sBMHGUpkjep(5);
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					}
					break;
				}
				RumHGTS7wVU(5);
				num = 3;
			}
		}
	}

	public double Preset1Size
	{
		get
		{
			return (double)GetValue(g4nHowZ7e2j);
		}
		set
		{
			SetValue(g4nHowZ7e2j, num);
		}
	}

	public double Preset1QuoteSize
	{
		get
		{
			return (double)GetValue(yJxHo7rIS5N);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, yJxHo7rIS5N, num);
		}
	}

	public int Preset1PercentSize
	{
		get
		{
			return (int)fkmX6TDbGrGBdLsIZEqF(this, qBjHo8cUa1y);
		}
		set
		{
			SetValue(qBjHo8cUa1y, num);
		}
	}

	public double Preset2Size
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, z8FHoAiR2JZ);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, z8FHoAiR2JZ, num);
		}
	}

	public double Preset2QuoteSize
	{
		get
		{
			return (double)GetValue(nTTHoPvq52a);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, nTTHoPvq52a, num);
		}
	}

	public int Preset2PercentSize
	{
		get
		{
			return (int)GetValue(i0yHoJdtdmd);
		}
		set
		{
			SetValue(i0yHoJdtdmd, num);
		}
	}

	public double Preset3Size
	{
		get
		{
			return (double)GetValue(KOuHoFbi0rg);
		}
		set
		{
			SetValue(KOuHoFbi0rg, num);
		}
	}

	public double Preset3QuoteSize
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, MRTHo3j8bLy);
		}
		set
		{
			SetValue(MRTHo3j8bLy, num);
		}
	}

	public int Preset3PercentSize
	{
		get
		{
			return (int)GetValue(SnBHop9qmor);
		}
		set
		{
			SetValue(SnBHop9qmor, num);
		}
	}

	public double Preset4Size
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, B5PHouQRQox);
		}
		set
		{
			SetValue(B5PHouQRQox, num);
		}
	}

	public double Preset4QuoteSize
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, vwEHozkIGRJ);
		}
		set
		{
			SetValue(vwEHozkIGRJ, num);
		}
	}

	public int Preset4PercentSize
	{
		get
		{
			return (int)GetValue(x3PHv0MuwwW);
		}
		set
		{
			SetValue(x3PHv0MuwwW, num);
		}
	}

	public double Preset5Size
	{
		get
		{
			return (double)fkmX6TDbGrGBdLsIZEqF(this, LVcHv2AKdhy);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, LVcHv2AKdhy, num);
		}
	}

	public double Preset5QuoteSize
	{
		get
		{
			return (double)GetValue(hA8HvH83XCs);
		}
		set
		{
			SetValue(hA8HvH83XCs, num);
		}
	}

	public int Preset5PercentSize
	{
		get
		{
			return (int)fkmX6TDbGrGBdLsIZEqF(this, zLBHvfsyYiA);
		}
		set
		{
			SetValue(zLBHvfsyYiA, num);
		}
	}

	public int QuoteSizeDecimals
	{
		get
		{
			return (int)GetValue(ADZHv9n5qix);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, ADZHv9n5qix, num);
		}
	}

	public double QuoteSize1
	{
		get
		{
			return oicHvL4RMTO;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					py3HGCPDmll(1);
					RumHGTS7wVU(1);
					return;
				case 3:
					Preset1QuoteSize = num3;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DFB4AF));
					if (M8FHoUk3VVE)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				default:
					oicHvL4RMTO = num3;
					num2 = 3;
					break;
				case 1:
					if (!(sFsl1NDbB1kRqDYF84YO(oicHvL4RMTO - num3) > xSxHothtU6X))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public double QuoteSize2
	{
		get
		{
			return u5OHve9yT3K;
		}
		set
		{
			if (!(sFsl1NDbB1kRqDYF84YO(u5OHve9yT3K - num) > xSxHothtU6X))
			{
				return;
			}
			u5OHve9yT3K = num;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					Preset2QuoteSize = num;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490926394));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					if (M8FHoUk3VVE)
					{
						py3HGCPDmll(2);
						RumHGTS7wVU(2);
						num2 = 2;
						break;
					}
					return;
				}
			}
		}
	}

	public double QuoteSize3
	{
		get
		{
			return oCiHvsB6MJj;
		}
		set
		{
			if (!(Math.Abs(oCiHvsB6MJj - num) > xSxHothtU6X))
			{
				return;
			}
			oCiHvsB6MJj = num;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					Preset3QuoteSize = num;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57699135));
					if (!M8FHoUk3VVE)
					{
						return;
					}
					py3HGCPDmll(3);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					RumHGTS7wVU(3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public double QuoteSize4
	{
		get
		{
			return GaaHvXspCCc;
		}
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (Math.Abs(GaaHvXspCCc - num3) > xSxHothtU6X)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					case 3:
						if (M8FHoUk3VVE)
						{
							py3HGCPDmll(4);
							RumHGTS7wVU(4);
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						return;
					case 2:
						return;
					}
					break;
				}
				GaaHvXspCCc = num3;
				Preset4QuoteSize = num3;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1879022752));
				num = 3;
			}
		}
	}

	public double QuoteSize5
	{
		get
		{
			return W0bHvcIevyY;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					py3HGCPDmll(5);
					RumHGTS7wVU(5);
					return;
				case 2:
					W0bHvcIevyY = num3;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (!(sFsl1NDbB1kRqDYF84YO(W0bHvcIevyY - num3) > xSxHothtU6X))
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				Preset5QuoteSize = num3;
				cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x5EA8FF2A ^ 0x5EA9EF94));
				if (!M8FHoUk3VVE)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public int PercentSize1
	{
		get
		{
			return RbIHvjlJEsI;
		}
		set
		{
			if (RbIHvjlJEsI == num)
			{
				return;
			}
			RbIHvjlJEsI = num;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					if (zfaHoysZhJh)
					{
						TsTHGyPdHQ9(1);
						int num3 = 2;
						num2 = num3;
						break;
					}
					return;
				case 2:
					py3HGCPDmll(1);
					return;
				case 1:
					Preset1PercentSize = num;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763965201));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int PercentSize2
	{
		get
		{
			return svRHvENeHCV;
		}
		set
		{
			if (svRHvENeHCV == num)
			{
				return;
			}
			svRHvENeHCV = num;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
					TsTHGyPdHQ9(2);
					py3HGCPDmll(2);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
					{
						num2 = 1;
					}
					break;
				default:
					Preset2PercentSize = num;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009587579));
					if (zfaHoysZhJh)
					{
						num2 = 2;
						break;
					}
					return;
				case 1:
					return;
				}
			}
		}
	}

	public int PercentSize3
	{
		get
		{
			return PFAHvQ58aFF;
		}
		set
		{
			if (PFAHvQ58aFF == num)
			{
				return;
			}
			PFAHvQ58aFF = num;
			Preset3PercentSize = num;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(-1325234765 ^ -1325165379));
					if (!zfaHoysZhJh)
					{
						num2 = 2;
						break;
					}
					TsTHGyPdHQ9(3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num2 = 0;
					}
					break;
				default:
					py3HGCPDmll(3);
					return;
				case 2:
					return;
				}
			}
		}
	}

	public int PercentSize4
	{
		get
		{
			return Y8kHvd6qsRm;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (Y8kHvd6qsRm != num3)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				default:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C6FBCC));
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					if (zfaHoysZhJh)
					{
						TsTHGyPdHQ9(4);
						py3HGCPDmll(4);
					}
					return;
				case 1:
					Y8kHvd6qsRm = num3;
					Preset4PercentSize = num3;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int PercentSize5
	{
		get
		{
			return v1VHvgJu1BZ;
		}
		set
		{
			if (v1VHvgJu1BZ == num)
			{
				return;
			}
			v1VHvgJu1BZ = num;
			Preset5PercentSize = num;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (zfaHoysZhJh)
					{
						TsTHGyPdHQ9(5);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					py3HGCPDmll(5);
					return;
				case 1:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x3740E072));
					num2 = 2;
					break;
				}
			}
		}
	}

	public bool QuotesComing
	{
		get
		{
			return (bool)fkmX6TDbGrGBdLsIZEqF(this, w3pHvnZoRwM);
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7E6229));
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7E62C1));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					SetValue(w3pHvnZoRwM, flag);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1192920246));
					ieYHGtoHtGf();
					return;
				}
			}
		}
	}

	public bool IsExchangeAvailable
	{
		get
		{
			if (ChoiceOfCurrency)
			{
				if (!ExecuteInQuoteCurrency)
				{
					return ExecuteInPercents;
				}
				return true;
			}
			return false;
		}
	}

	public bool EditQuoteCurrency
	{
		get
		{
			return (bool)fkmX6TDbGrGBdLsIZEqF(this, Ed9HvGeE7nC);
		}
		set
		{
			SetValue(Ed9HvGeE7nC, flag);
			jffHGVHHXKQ();
		}
	}

	public bool ChoiceOfCurrency
	{
		get
		{
			return (bool)fkmX6TDbGrGBdLsIZEqF(this, zxZHvY6MNEN);
		}
		set
		{
			SetValue(zxZHvY6MNEN, flag);
			ieYHGtoHtGf();
		}
	}

	public bool ChoiceOfPercents
	{
		get
		{
			return (bool)GetValue(IkrHvoj4uFs);
		}
		set
		{
			SetValue(IkrHvoj4uFs, flag);
		}
	}

	public string BaseCurrency
	{
		get
		{
			return fkmX6TDbGrGBdLsIZEqF(this, k9eHvvWfGDe)?.ToString();
		}
		set
		{
			if (Meo95vDbi4dROZxRGwGJ(text, BaseCurrency))
			{
				UbVcGrDbYmxt40M59iAt(this, k9eHvvWfGDe, text);
			}
		}
	}

	public string QuoteCurrency
	{
		get
		{
			return GetValue(k6FHvBh6PCb)?.ToString();
		}
		set
		{
			if (text != QuoteCurrency)
			{
				SetValue(k6FHvBh6PCb, text);
			}
		}
	}

	public bool Preset1IsSelected
	{
		get
		{
			return (bool)GetValue(ETXHvab0soR);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, ETXHvab0soR, flag);
		}
	}

	public bool Preset2IsSelected
	{
		get
		{
			return (bool)GetValue(mTaHviNa8GG);
		}
		set
		{
			SetValue(mTaHviNa8GG, flag);
		}
	}

	public bool Preset3IsSelected
	{
		get
		{
			return (bool)GetValue(e1fHvlFEDe2);
		}
		set
		{
			SetValue(e1fHvlFEDe2, flag);
		}
	}

	public bool Preset4IsSelected
	{
		get
		{
			return (bool)GetValue(DpyHv4Z2ZHJ);
		}
		set
		{
			SetValue(DpyHv4Z2ZHJ, flag);
		}
	}

	public bool Preset5IsSelected
	{
		get
		{
			return (bool)fkmX6TDbGrGBdLsIZEqF(this, AEtHvDhUpNu);
		}
		set
		{
			SetValue(AEtHvDhUpNu, flag);
		}
	}

	public bool ExecuteInQuoteCurrency
	{
		get
		{
			return (bool)GetValue(HQKHvbBm1h5);
		}
		set
		{
			SetValue(HQKHvbBm1h5, flag);
		}
	}

	public bool ExecuteInPercents
	{
		get
		{
			return (bool)GetValue(QKqHvNRiW6p);
		}
		set
		{
			UbVcGrDbYmxt40M59iAt(this, QKqHvNRiW6p, flag);
		}
	}

	public bool BaseCurrencyEnable
	{
		get
		{
			if (ExecuteInQuoteCurrency && CurrentPrice <= 0)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => false, 
				};
			}
			if (ExecuteInPercents && !bfyHoBjpuxl())
			{
				return false;
			}
			return true;
		}
	}

	public bool QuoteCurrencyEnable
	{
		get
		{
			if (!ChoiceOfCurrency)
			{
				return false;
			}
			int num;
			if (!ExecuteInQuoteCurrency)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_0068;
			IL_0009:
			switch (num)
			{
			default:
				return false;
			case 1:
				break;
			}
			if (!ExecuteInPercents && CurrentPrice <= 0)
			{
				return false;
			}
			goto IL_0068;
			IL_0068:
			if (!ExecuteInPercents || bfyHoBjpuxl())
			{
				return true;
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
	}

	public bool PercentsEnable
	{
		get
		{
			if (!ChoiceOfPercents)
			{
				return false;
			}
			if (!ExecuteInPercents)
			{
				return bfyHoBjpuxl();
			}
			return true;
		}
	}

	public bool IsEqualSignVisible => CurrentPrice > 0;

	public LotSelectControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		xSxHothtU6X = 1E-08;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
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
				InitializeComponent();
				jffHGVHHXKQ();
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 2:
				base.IsVisibleChanged += MP6HGIeqUZh;
				u8kRyJDbn8vEZ5finqQB(this, new RoutedEventHandler(Eb0HGqDa2aF));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	private bool bfyHoBjpuxl()
	{
		if (CurrencyFreeMargin >= -5E-324 && Math.Abs(Leverage) >= double.Epsilon)
		{
			return CurrentPrice > 0;
		}
		return false;
	}

	private static void B6jHG2PZqiW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		LotSelectControl lotSelectControl = P_0 as LotSelectControl;
		int num;
		object oldValue = default(object);
		if (lotSelectControl == null)
		{
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
			{
				num = 4;
			}
		}
		else
		{
			oldValue = P_1.OldValue;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673614091));
				return;
			case 4:
				return;
			default:
				if (oldValue is long num2 && num2 == 0L)
				{
					num = 3;
					break;
				}
				goto IL_009c;
			case 3:
				lotSelectControl.ieYHGtoHtGf();
				goto IL_009c;
			case 1:
				{
					lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074210866));
					num = 2;
					break;
				}
				IL_009c:
				i4eBEPDblfG6RoYnflg4(lotSelectControl);
				lotSelectControl.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x86EFEF6 ^ 0x86FEF22));
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520216813));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private static void UHxHGHTwvAj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		LotSelectControl lotSelectControl = P_0 as LotSelectControl;
		int num;
		if (lotSelectControl == null)
		{
			num = 2;
		}
		else
		{
			if (!lotSelectControl.ExecuteInPercents)
			{
				lotSelectControl.RumHGTS7wVU();
				goto IL_00b4;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
			{
				num = 1;
			}
		}
		goto IL_0009;
		IL_00b4:
		lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82921558));
		lotSelectControl.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x6AB40973 ^ 0x6AB518F9));
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				goto IL_0072;
			case 2:
				return;
			case 3:
				break;
			default:
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C826550));
				return;
			}
			break;
			IL_0072:
			lotSelectControl.TsTHGyPdHQ9();
			lotSelectControl.py3HGCPDmll();
			num = 3;
		}
		goto IL_00b4;
	}

	private static void OupHGfQoh9V(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is LotSelectControl lotSelectControl))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D542A82));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
				{
					num = 1;
				}
				break;
			default:
				if (lotSelectControl.ExecuteInPercents)
				{
					goto case 2;
				}
				goto case 4;
			case 2:
				lotSelectControl.TsTHGyPdHQ9();
				lotSelectControl.py3HGCPDmll();
				num = 3;
				break;
			case 4:
				lotSelectControl.RumHGTS7wVU();
				goto case 3;
			case 1:
				lotSelectControl.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(--871424829 ^ 0x33F1F2B7));
				lotSelectControl.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x735715F1 ^ 0x73560445));
				return;
			}
		}
	}

	private static void POGHG9HvEec(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		LotSelectControl obj = P_0 as LotSelectControl;
		obj?.bvSHGLnscXF((double)P_1.NewValue);
		obj?.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB01FBA));
	}

	private static void fXaHGnLd8fG(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.r5VHGep9SFS((double)P_1.NewValue);
	}

	private static void nqqHGGOZfT5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		LotSelectControl lotSelectControl = default(LotSelectControl);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				lotSelectControl = P_0 as LotSelectControl;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			lotSelectControl?.ieYHGtoHtGf();
			LotSelectControl obj = P_0 as LotSelectControl;
			if (obj == null)
			{
				return;
			}
			obj.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x60620FC1 ^ 0x60631E15));
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
			{
				num2 = 2;
			}
		}
	}

	private static void VYRHGYsWiGB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is LotSelectControl lotSelectControl)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			lotSelectControl.ieYHGtoHtGf();
		}
	}

	private static void lciHGopHSVt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.shSHGsyg2op((bool)P_1.NewValue);
	}

	private static void iZQHGvE8B3g(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.kvjHGXg8EDm((bool)P_1.NewValue);
	}

	private static void u2yHGBDA4rA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		LotSelectControl lotSelectControl = default(LotSelectControl);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				yDIKZUDb4vqn5U5UQICU(lotSelectControl.EditQuote5, text);
				return;
			case 1:
				yDIKZUDb4vqn5U5UQICU(lotSelectControl.EditQuote2, text);
				num2 = 4;
				break;
			case 2:
				if (lotSelectControl == null || lotSelectControl == null)
				{
					return;
				}
				text = McPEV4q7m2685kMvrQH.bR1qJgPHqX(lotSelectControl.QuoteSizeDecimals, _0020: false);
				lotSelectControl.EditQuote1.Format = text;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				lotSelectControl.EditQuote3.Format = text;
				lotSelectControl.EditQuote4.Format = text;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				lotSelectControl = P_0 as LotSelectControl;
				num2 = 2;
				break;
			}
		}
	}

	private static void OdZHGaRyNq7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is LotSelectControl lotSelectControl)
		{
			lotSelectControl.VqfHGcpdC3n((bool)P_1.NewValue);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D302543));
		}
	}

	private static void BXFHGinZ9tC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is LotSelectControl lotSelectControl))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			lotSelectControl.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(-530053095 ^ -529983059));
		}
	}

	private static void KiUHGlZIBvE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.cqCHGjFNG3h(P_1.NewValue?.ToString());
	}

	private static void SxQHG4nv4Qb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.gm2HGEmqrwa(P_1.NewValue?.ToString());
	}

	private static void LqHHGD54cGY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.qx9HGQnksXt((bool)P_1.NewValue);
	}

	private static void d1BHGbWhUf7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.R1RHGdI49Al((bool)P_1.NewValue);
	}

	private static void x3RHGN3irm7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.WQHHGgfw58H((bool)P_1.NewValue);
	}

	private static void v8qHGkDWpmI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.bOFHGRapeV0((bool)P_1.NewValue);
	}

	private static void QCCHG1Fy6Q5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		(P_0 as LotSelectControl)?.aaTHG64eqRr((bool)P_1.NewValue);
	}

	private static void a8tHG5D0RXp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		LotSelectControl lotSelectControl = default(LotSelectControl);
		while (true)
		{
			switch (num2)
			{
			case 2:
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1879022940));
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522767625));
				return;
			case 1:
				lotSelectControl = P_0 as LotSelectControl;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (lotSelectControl == null)
			{
				return;
			}
			i4eBEPDblfG6RoYnflg4(lotSelectControl);
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
			{
				num2 = 0;
			}
		}
	}

	private static void Yl9HGS1XXMV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is LotSelectControl lotSelectControl))
		{
			return;
		}
		lotSelectControl.SkmHGx54WvN();
		lotSelectControl.cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(--146713930 ^ 0x8BFBC28));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53852098));
				lotSelectControl.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-838841832 ^ -838771796));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SkmHGx54WvN()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!base.IsVisible)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 1;
					}
					break;
				}
				cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(-1127423276 ^ -1127353562));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2CEA8F));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x4231C22));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C0D9F4));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(-1161619942 ^ -1161690106));
				return;
			case 1:
				return;
			}
		}
	}

	public void bvSHGLnscXF(double P_0)
	{
		LotStep = P_0;
	}

	public void r5VHGep9SFS(double P_0)
	{
		ContractValue = P_0;
	}

	public void shSHGsyg2op(bool P_0)
	{
		QuotesComing = P_0;
		cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127353562));
	}

	public void kvjHGXg8EDm(bool P_0)
	{
		EditQuoteCurrency = P_0;
	}

	public void VqfHGcpdC3n(bool P_0)
	{
		ChoiceOfCurrency = P_0;
		cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1879023052));
	}

	public void cqCHGjFNG3h(string P_0)
	{
		BaseCurrency = P_0;
	}

	public void gm2HGEmqrwa(string P_0)
	{
		QuoteCurrency = P_0;
	}

	public void qx9HGQnksXt(bool P_0)
	{
		Preset1IsSelected = P_0;
	}

	public void R1RHGdI49Al(bool P_0)
	{
		Preset2IsSelected = P_0;
	}

	public void WQHHGgfw58H(bool P_0)
	{
		Preset3IsSelected = P_0;
	}

	public void bOFHGRapeV0(bool P_0)
	{
		Preset4IsSelected = P_0;
	}

	public void aaTHG64eqRr(bool P_0)
	{
		Preset5IsSelected = P_0;
	}

	private static jstp7rlilhegAZXKBV8a OQbHGMCwKnN<jstp7rlilhegAZXKBV8a>(DependencyObject P_0) where jstp7rlilhegAZXKBV8a : DependencyObject
	{
		DependencyObject dependencyObject = jPVHGOwyuO8(P_0);
		if (dependencyObject == null)
		{
			return null;
		}
		if (dependencyObject is jstp7rlilhegAZXKBV8a result)
		{
			return result;
		}
		return OQbHGMCwKnN<jstp7rlilhegAZXKBV8a>(dependencyObject);
	}

	private static DependencyObject jPVHGOwyuO8(DependencyObject P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		ContentElement contentElement = P_0 as ContentElement;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
		{
			num = 3;
		}
		DependencyObject parent = default(DependencyObject);
		FrameworkElement frameworkElement = default(FrameworkElement);
		while (true)
		{
			switch (num)
			{
			case 4:
				return null;
			case 2:
				return parent;
			case 1:
			{
				DependencyObject parent2 = ContentOperations.GetParent(contentElement);
				if (parent2 != null)
				{
					return parent2;
				}
				if (contentElement is FrameworkContentElement frameworkContentElement)
				{
					return (DependencyObject)N2JZ73DbDmUADTIUwFl0(frameworkContentElement);
				}
				goto case 4;
			}
			default:
				if (frameworkElement != null)
				{
					parent = frameworkElement.Parent;
					if (parent != null)
					{
						goto case 2;
					}
				}
				return VisualTreeHelper.GetParent(P_0);
			case 3:
				if (contentElement == null)
				{
					frameworkElement = P_0 as FrameworkElement;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
					{
						num = 1;
					}
				}
				break;
			}
		}
	}

	private void Eb0HGqDa2aF(object P_0, RoutedEventArgs P_1)
	{
		LH4HG8nN95j();
	}

	private void MP6HGIeqUZh(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!base.IsVisible)
		{
			return;
		}
		while (true)
		{
			iw0HGWsRmg4();
			cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73560403));
			cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(-2002318893 ^ -2002380623));
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B65A6B));
					return;
				case 2:
					cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x6D18F862 ^ 0x6D19E9E8));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void iw0HGWsRmg4()
	{
		waq1Af2bWXQbeynqsiXl waq1Af2bWXQbeynqsiXl = OQbHGMCwKnN<waq1Af2bWXQbeynqsiXl>(this);
		int num;
		if (waq1Af2bWXQbeynqsiXl != null)
		{
			num = 4;
			goto IL_0005;
		}
		goto IL_035f;
		IL_035f:
		YYGHvkYGEHj = Preset1Size;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
		{
			num2 = 0;
		}
		goto IL_0009;
		IL_0005:
		num2 = num;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 13:
				GaaHvXspCCc = Preset4QuoteSize;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991922437));
				W0bHvcIevyY = Preset5QuoteSize;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DFB44F));
				num2 = 11;
				continue;
			case 9:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342676696));
				oCiHvsB6MJj = Preset3QuoteSize;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA9EFA4));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num2 = 13;
				}
				continue;
			case 12:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B1A9B8));
				u5OHve9yT3K = Preset2QuoteSize;
				num2 = 9;
				continue;
			case 1:
				CurrencyFreeMargin = waq1Af2bWXQbeynqsiXl.CurrencyFreeMargin;
				num2 = 2;
				continue;
			case 4:
				Leverage = fprxXgDbbfPUjEnJP8AY(waq1Af2bWXQbeynqsiXl);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86FEE20));
				svRHvENeHCV = Preset2PercentSize;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962586367));
				PFAHvQ58aFF = Preset3PercentSize;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F1E73A));
				num2 = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num2 = 10;
				}
				continue;
			case 6:
				z90Hv54vUaB = Preset3Size;
				num2 = 7;
				continue;
			case 11:
				RbIHvjlJEsI = Preset1PercentSize;
				num2 = 3;
				continue;
			case 10:
				break;
			default:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x706451F7));
				zbyHv1cCrbC = Preset2Size;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047226471));
				num2 = 6;
				continue;
			case 14:
				cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x735715F1 ^ 0x735605CB));
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num2 = 5;
				}
				continue;
			case 8:
				v1VHvgJu1BZ = Preset5PercentSize;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009587407));
				ieYHGtoHtGf();
				return;
			case 5:
				E5kHvx8pcvJ = Preset5Size;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CC5F59));
				oicHvL4RMTO = Preset1QuoteSize;
				num2 = 12;
				continue;
			case 2:
				goto IL_035f;
			case 7:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894841596));
				gpKHvSUsEIe = Preset4Size;
				num2 = 14;
				continue;
			}
			break;
		}
		Y8kHvd6qsRm = Preset4PercentSize;
		cY7HkOvo1nf((string)l61d3sDbasAssbCf9Vfd(0x16AD7E76 ^ 0x16AC6F5C));
		num = 8;
		goto IL_0005;
	}

	private void ieYHGtoHtGf(int P_0 = 0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				py3HGCPDmll(P_0);
				return;
			case 3:
				if (!ExecuteInQuoteCurrency)
				{
					if (ExecuteInPercents)
					{
						TsTHGyPdHQ9(P_0);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
						{
							num2 = 0;
						}
						break;
					}
					sBMHGUpkjep(P_0);
					RumHGTS7wVU(P_0);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 2:
				py3HGCPDmll(P_0);
				RumHGTS7wVU(P_0);
				return;
			}
		}
	}

	private void sBMHGUpkjep(int P_0)
	{
		int num = 9;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				QuoteSize3 = JLFqEJGJYiHaSdoROJXI.AZ0GJbFd8HF(Preset3, CurrentPrice, PriceStep);
				goto IL_0151;
			case 8:
				return;
			case 7:
				if (P_0 != 0)
				{
					if (P_0 == 1)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_015c;
				}
				goto default;
			case 6:
				if (CurrentPrice <= 0)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (!base.IsVisible)
				{
					return;
				}
				num2 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
			case 3:
				QuoteSize2 = IGv11sDboq7ja8g0uRPf(Preset2, CurrentPrice, PriceStep);
				goto IL_021d;
			case 9:
				if (!ChoiceOfCurrency)
				{
					num2 = 8;
					continue;
				}
				goto case 6;
			default:
				QuoteSize1 = JLFqEJGJYiHaSdoROJXI.AZ0GJbFd8HF(Preset1, CurrentPrice, PriceStep);
				goto IL_015c;
			case 5:
				break;
				IL_021d:
				if (P_0 == 0)
				{
					goto case 4;
				}
				if (P_0 == 3)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto IL_0151;
				IL_0151:
				if (P_0 == 0 || P_0 == 4)
				{
					QuoteSize4 = JLFqEJGJYiHaSdoROJXI.AZ0GJbFd8HF(Preset4, CurrentPrice, PriceStep);
				}
				switch (P_0)
				{
				default:
					return;
				case 5:
					num2 = 5;
					continue;
				case 0:
					break;
				}
				break;
				IL_015c:
				switch (P_0)
				{
				case 2:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
					{
						num2 = 3;
					}
					continue;
				case 0:
					num2 = 2;
					continue;
				}
				goto IL_021d;
			}
			break;
		}
		QuoteSize5 = JLFqEJGJYiHaSdoROJXI.AZ0GJbFd8HF(Preset5, CurrentPrice, PriceStep);
	}

	private void RumHGTS7wVU(int P_0 = 0)
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (P_0 != 0)
					{
						num2 = 2;
						continue;
					}
					goto IL_0075;
				case 5:
					if (bfyHoBjpuxl())
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					return;
				case 1:
					if (P_0 != 0)
					{
						num = 8;
						break;
					}
					goto IL_0190;
				case 8:
					if (P_0 != 5)
					{
						return;
					}
					goto IL_0190;
				case 2:
					if (P_0 == 4)
					{
						goto IL_0075;
					}
					goto case 1;
				case 7:
					PercentSize2 = HTaEx4DbNGHqYZZWvPXg(CurrencyFreeMargin, Leverage, QuoteSize2);
					goto IL_00e9;
				default:
					if (P_0 != 3)
					{
						goto case 3;
					}
					goto IL_0115;
				case 4:
					if (!base.IsVisible)
					{
						return;
					}
					if (P_0 == 0 || P_0 == 1)
					{
						PercentSize1 = HTaEx4DbNGHqYZZWvPXg(CurrencyFreeMargin, Leverage, QuoteSize1);
					}
					if (P_0 != 0)
					{
						if (P_0 == 2)
						{
							num2 = 7;
							continue;
						}
						goto IL_00e9;
					}
					goto case 7;
				case 6:
					{
						if (!ChoiceOfCurrency)
						{
							return;
						}
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					IL_0115:
					PercentSize3 = JLFqEJGJYiHaSdoROJXI.Qr8GJD6AHk5(CurrencyFreeMargin, Leverage, QuoteSize3);
					num = 3;
					break;
					IL_0075:
					PercentSize4 = JLFqEJGJYiHaSdoROJXI.Qr8GJD6AHk5(CurrencyFreeMargin, Leverage, QuoteSize4);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
					{
						num2 = 1;
					}
					continue;
					IL_0190:
					PercentSize5 = JLFqEJGJYiHaSdoROJXI.Qr8GJD6AHk5(CurrencyFreeMargin, Leverage, QuoteSize5);
					return;
					IL_00e9:
					if (P_0 != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0115;
				}
				break;
			}
		}
	}

	private void TsTHGyPdHQ9(int P_0 = 0)
	{
		if (!ChoiceOfCurrency || !bfyHoBjpuxl())
		{
			return;
		}
		while (true)
		{
			int num;
			if (!base.IsVisible)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
				{
					num = 3;
				}
			}
			else
			{
				if (P_0 == 0)
				{
					goto IL_01d3;
				}
				num = 5;
			}
			goto IL_0009;
			IL_00b5:
			QuoteSize5 = JLFqEJGJYiHaSdoROJXI.k62GJ45Rvfj(CurrencyFreeMargin, Leverage, PercentSize5);
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
			{
				num = 0;
			}
			goto IL_0009;
			IL_0184:
			if (P_0 == 0 || P_0 == 4)
			{
				QuoteSize4 = l0BGplDbkCde8YbqlHiJ(CurrencyFreeMargin, Leverage, PercentSize4);
			}
			if (P_0 != 0)
			{
				int num2 = 7;
				num = num2;
				goto IL_0009;
			}
			goto IL_00b5;
			IL_01b1:
			QuoteSize3 = l0BGplDbkCde8YbqlHiJ(CurrencyFreeMargin, Leverage, PercentSize3);
			goto IL_0184;
			IL_019b:
			if (P_0 == 2)
			{
				goto IL_0142;
			}
			goto IL_0164;
			IL_01d3:
			QuoteSize1 = JLFqEJGJYiHaSdoROJXI.k62GJ45Rvfj(CurrencyFreeMargin, Leverage, PercentSize1);
			goto IL_0066;
			IL_0066:
			if (P_0 != 0)
			{
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 5;
				}
				goto IL_0009;
			}
			goto IL_0142;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 4:
					return;
				case 2:
					break;
				case 3:
					return;
				case 5:
					goto IL_0122;
				case 7:
					goto IL_018f;
				case 6:
					goto IL_019b;
				default:
					goto IL_01b1;
				case 1:
					goto IL_01f5;
				}
				break;
				IL_01f5:
				if (P_0 == 3)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num = 0;
					}
					continue;
				}
				goto IL_0184;
			}
			continue;
			IL_0122:
			if (P_0 != 1)
			{
				goto IL_0066;
			}
			goto IL_01d3;
			IL_0142:
			QuoteSize2 = JLFqEJGJYiHaSdoROJXI.k62GJ45Rvfj(CurrencyFreeMargin, Leverage, PercentSize2);
			goto IL_0164;
			IL_0164:
			if (P_0 != 0)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_01b1;
			IL_018f:
			if (P_0 != 5)
			{
				break;
			}
			goto IL_00b5;
		}
	}

	private void acuHGZGE84l(object P_0, KeyEventArgs P_1)
	{
		Q1ZfpCHbfg8xj4pZQvis.LX5HbneePbI(P_1);
	}

	private void jffHGVHHXKQ()
	{
		string stateName = (EditQuoteCurrency ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741A9797) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CC5D51));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		VisualStateManager.GoToState(this, stateName, useTransitions: false);
	}

	private void py3HGCPDmll(int P_0 = 0)
	{
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					switch (P_0)
					{
					default:
						return;
					case 5:
						num2 = 3;
						continue;
					case 0:
						break;
					}
					goto case 3;
				case 6:
					if (P_0 == 4)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 5:
					if (P_0 != 0)
					{
						if (P_0 != 2)
						{
							goto IL_0150;
						}
						goto case 4;
					}
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					Preset3 = inwL01Db59bvYo0EwiTb(QuoteSize3, CurrentPrice, LotStep, PriceStep, ContractValue, SizeStep);
					goto IL_0108;
				case 4:
					Preset2 = JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(QuoteSize2, CurrentPrice, LotStep, PriceStep, ContractValue, SizeStep);
					goto IL_0150;
				case 7:
					if (CurrentPrice <= 0 || !TZ9ieFDb17GIhvAkvg8d(this))
					{
						return;
					}
					if (P_0 == 0 || P_0 == 1)
					{
						Preset1 = inwL01Db59bvYo0EwiTb(QuoteSize1, CurrentPrice, LotStep, PriceStep, ContractValue, SizeStep);
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 3:
					Preset5 = JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(QuoteSize5, CurrentPrice, LotStep, PriceStep, ContractValue, SizeStep);
					return;
				case 2:
					Preset4 = JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(QuoteSize4, CurrentPrice, LotStep, PriceStep, ContractValue, SizeStep);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					{
						if (!ChoiceOfCurrency)
						{
							return;
						}
						num = 7;
						break;
					}
					IL_0108:
					if (P_0 != 0)
					{
						num = 6;
						break;
					}
					goto case 2;
					IL_0150:
					if (P_0 != 0)
					{
						if (P_0 == 3)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_0108;
					}
					goto default;
				}
				break;
			}
		}
	}

	private void tNaHGr3O1YB(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		M8FHoUk3VVE = true;
	}

	private void L8SHGKwMLhW(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		M8FHoUk3VVE = false;
	}

	private void A1VHGmLvDuC(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		XonHoTRQFH5 = true;
	}

	private void WXkHGhKgkFc(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		XonHoTRQFH5 = false;
	}

	private void A2WHGwgWVlg(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		zfaHoysZhJh = true;
	}

	private void Fp6HG7PNiua(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		zfaHoysZhJh = false;
	}

	private void LH4HG8nN95j()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 11:
					return;
				case 5:
					EditQuote4.Focus();
					return;
				case 2:
					if (Preset1IsSelected)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (!Preset2IsSelected)
					{
						num2 = 16;
						continue;
					}
					goto case 10;
				case 10:
					if (!ExecuteInQuoteCurrency)
					{
						if (ExecuteInPercents)
						{
							num2 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
							{
								num2 = 2;
							}
							continue;
						}
						xDMjmxDbSJ6Ndn94vOc1(EditPreset2Size);
						num = 15;
						break;
					}
					xDMjmxDbSJ6Ndn94vOc1(EditQuote2);
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
					{
						num2 = 13;
					}
					continue;
				case 13:
					return;
				case 1:
					if (!ExecuteInQuoteCurrency)
					{
						if (ExecuteInPercents)
						{
							num2 = 12;
							continue;
						}
						EditPreset1Size.Focus();
						return;
					}
					EditQuote1.Focus();
					num = 4;
					break;
				case 14:
					if (!ExecuteInPercents)
					{
						EditPreset3Size.Focus();
						num2 = 11;
						continue;
					}
					xDMjmxDbSJ6Ndn94vOc1(EditPercent3);
					return;
				case 7:
					return;
				default:
					if (Preset5IsSelected)
					{
						if (ExecuteInQuoteCurrency)
						{
							EditQuote5.Focus();
						}
						else if (!ExecuteInPercents)
						{
							xDMjmxDbSJ6Ndn94vOc1(EditPreset5Size);
						}
						else
						{
							EditPercent5.Focus();
						}
					}
					return;
				case 9:
					EditPercent4.Focus();
					return;
				case 3:
					EditPercent2.Focus();
					return;
				case 15:
					return;
				case 16:
					if (!Preset3IsSelected)
					{
						if (!Preset4IsSelected)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
							{
								num2 = 0;
							}
						}
						else if (ExecuteInQuoteCurrency)
						{
							num2 = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
							{
								num2 = 4;
							}
						}
						else if (!ExecuteInPercents)
						{
							EditPreset4Size.Focus();
							num2 = 7;
						}
						else
						{
							num2 = 9;
						}
						continue;
					}
					num = 8;
					break;
				case 6:
					return;
				case 12:
					EditPercent1.Focus();
					num = 6;
					break;
				case 8:
					if (ExecuteInQuoteCurrency)
					{
						EditQuote3.Focus();
						return;
					}
					num = 14;
					break;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!oMFHvRFXEXo)
		{
			oMFHvRFXEXo = true;
			Uri resourceLocator = new Uri((string)l61d3sDbasAssbCf9Vfd(--737722733 ^ 0x2BF9D315), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 12:
			EditQuote3 = (DoubleEditBox)P_1;
			EditQuote3.GotKeyboardFocus += tNaHGr3O1YB;
			EditQuote3.LostKeyboardFocus += L8SHGKwMLhW;
			LguGlXDbLK0QReaUB8va(EditQuote3, new KeyEventHandler(acuHGZGE84l));
			break;
		case 4:
			EditQuote1 = (DoubleEditBox)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 7:
			EditPreset2Size = (DoubleEditBox)P_1;
			BoXptmDbxLWhObpO8BJL(EditPreset2Size, new KeyboardFocusChangedEventHandler(A1VHGmLvDuC));
			num = 2;
			goto IL_0009;
		case 20:
			EditQuote5 = (DoubleEditBox)P_1;
			BoXptmDbxLWhObpO8BJL(EditQuote5, new KeyboardFocusChangedEventHandler(tNaHGr3O1YB));
			num = 21;
			goto IL_0009;
		case 1:
			LotSelectViewControl = (LotSelectControl)P_1;
			break;
		case 5:
			EditPercent1 = (Int16EditBox)P_1;
			num = 10;
			goto IL_0009;
		case 8:
			EditQuote2 = (DoubleEditBox)P_1;
			num = 16;
			goto IL_0009;
		case 21:
			EditPercent5 = (Int16EditBox)P_1;
			BoXptmDbxLWhObpO8BJL(EditPercent5, new KeyboardFocusChangedEventHandler(A2WHGwgWVlg));
			EditPercent5.LostKeyboardFocus += Fp6HG7PNiua;
			EditPercent5.PreviewKeyDown += acuHGZGE84l;
			break;
		default:
			oMFHvRFXEXo = true;
			break;
		case 9:
			EditPercent2 = (Int16EditBox)P_1;
			EditPercent2.GotKeyboardFocus += A2WHGwgWVlg;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 3:
			EditPreset1Size = (DoubleEditBox)P_1;
			num = 8;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
			{
				num = 19;
			}
			goto IL_0009;
		case 14:
			Row4Background = (Border)P_1;
			num = 28;
			goto IL_0009;
		case 17:
			EditPercent4 = (Int16EditBox)P_1;
			num = 25;
			goto IL_0009;
		case 19:
			EditPreset5Size = (DoubleEditBox)P_1;
			num = 7;
			goto IL_0009;
		case 11:
			EditPreset3Size = (DoubleEditBox)P_1;
			EditPreset3Size.GotKeyboardFocus += A1VHGmLvDuC;
			EditPreset3Size.LostKeyboardFocus += WXkHGhKgkFc;
			EditPreset3Size.PreviewKeyDown += acuHGZGE84l;
			num = 9;
			goto IL_0009;
		case 2:
			Row1Background = (Border)P_1;
			num = 24;
			goto IL_0009;
		case 13:
			EditPercent3 = (Int16EditBox)P_1;
			BoXptmDbxLWhObpO8BJL(EditPercent3, new KeyboardFocusChangedEventHandler(A2WHGwgWVlg));
			EditPercent3.LostKeyboardFocus += Fp6HG7PNiua;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
			{
				num = 23;
			}
			goto IL_0009;
		case 15:
			EditPreset4Size = (DoubleEditBox)P_1;
			num = 15;
			goto IL_0009;
		case 16:
			EditQuote4 = (DoubleEditBox)P_1;
			EditQuote4.GotKeyboardFocus += tNaHGr3O1YB;
			EditQuote4.LostKeyboardFocus += L8SHGKwMLhW;
			num = 3;
			goto IL_0009;
		case 6:
			Row2Background = (Border)P_1;
			num = 18;
			goto IL_0009;
		case 10:
			Row3Background = (Border)P_1;
			num = 4;
			goto IL_0009;
		case 18:
			{
				Row5Background = (Border)P_1;
				break;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 9:
					return;
				case 20:
					EditPercent4.PreviewKeyDown += acuHGZGE84l;
					return;
				case 22:
					EditPreset4Size.LostKeyboardFocus += WXkHGhKgkFc;
					EditPreset4Size.PreviewKeyDown += acuHGZGE84l;
					return;
				case 17:
					iDeCGrDbe5mVC4LrrLBB(EditPreset5Size, new KeyboardFocusChangedEventHandler(WXkHGhKgkFc));
					EditPreset5Size.PreviewKeyDown += acuHGZGE84l;
					return;
				case 6:
					return;
				case 18:
					return;
				case 7:
					BoXptmDbxLWhObpO8BJL(EditPreset5Size, new KeyboardFocusChangedEventHandler(A1VHGmLvDuC));
					num = 17;
					break;
				case 19:
					BoXptmDbxLWhObpO8BJL(EditPreset1Size, new KeyboardFocusChangedEventHandler(A1VHGmLvDuC));
					num = 26;
					break;
				case 21:
				{
					iDeCGrDbe5mVC4LrrLBB(EditQuote5, new KeyboardFocusChangedEventHandler(L8SHGKwMLhW));
					int num2 = 29;
					num = num2;
					break;
				}
				case 29:
					LguGlXDbLK0QReaUB8va(EditQuote5, new KeyEventHandler(acuHGZGE84l));
					num = 14;
					break;
				case 15:
					EditPreset4Size.GotKeyboardFocus += A1VHGmLvDuC;
					num = 22;
					break;
				case 16:
					EditQuote2.GotKeyboardFocus += tNaHGr3O1YB;
					EditQuote2.LostKeyboardFocus += L8SHGKwMLhW;
					EditQuote2.PreviewKeyDown += acuHGZGE84l;
					return;
				case 13:
					return;
				case 14:
					return;
				case 24:
					return;
				case 12:
					return;
				case 11:
					EditPercent2.PreviewKeyDown += acuHGZGE84l;
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
					{
						num = 3;
					}
					break;
				case 8:
					return;
				case 2:
					iDeCGrDbe5mVC4LrrLBB(EditPreset2Size, new KeyboardFocusChangedEventHandler(WXkHGhKgkFc));
					EditPreset2Size.PreviewKeyDown += acuHGZGE84l;
					num = 13;
					break;
				case 3:
					EditQuote4.PreviewKeyDown += acuHGZGE84l;
					num = 8;
					break;
				case 4:
					return;
				case 27:
					EditPercent1.PreviewKeyDown += acuHGZGE84l;
					return;
				case 25:
					BoXptmDbxLWhObpO8BJL(EditPercent4, new KeyboardFocusChangedEventHandler(A2WHGwgWVlg));
					EditPercent4.LostKeyboardFocus += Fp6HG7PNiua;
					num = 20;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
					{
						num = 17;
					}
					break;
				case 28:
					return;
				case 23:
					LguGlXDbLK0QReaUB8va(EditPercent3, new KeyEventHandler(acuHGZGE84l));
					num = 12;
					break;
				case 26:
					EditPreset1Size.LostKeyboardFocus += WXkHGhKgkFc;
					LguGlXDbLK0QReaUB8va(EditPreset1Size, new KeyEventHandler(acuHGZGE84l));
					num = 6;
					break;
				case 1:
					EditQuote1.GotKeyboardFocus += tNaHGr3O1YB;
					EditQuote1.LostKeyboardFocus += L8SHGKwMLhW;
					LguGlXDbLK0QReaUB8va(EditQuote1, new KeyEventHandler(acuHGZGE84l));
					return;
				case 5:
					return;
				case 10:
					EditPercent1.GotKeyboardFocus += A2WHGwgWVlg;
					EditPercent1.LostKeyboardFocus += Fp6HG7PNiua;
					num = 27;
					break;
				default:
					iDeCGrDbe5mVC4LrrLBB(EditPercent2, new KeyboardFocusChangedEventHandler(Fp6HG7PNiua));
					num = 11;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
					{
						num = 5;
					}
					break;
				}
			}
		}
	}

	static LotSelectControl()
	{
		mK74o2DbskCJfrZRb5a3();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 11;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 14:
				e1fHvlFEDe2 = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056781644), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, x3RHGN3irm7));
				num = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				x3PHv0MuwwW = (DependencyProperty)wPmGIgDbEufTCpr102YY(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x4663E223), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777220)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				LVcHv2AKdhy = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73560145), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				num = 3;
				break;
			case 15:
				DpyHv4Z2ZHJ = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7395C428), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, v8qHGkDWpmI));
				AEtHvDhUpNu = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(-5977659 ^ -5906619), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(false, QCCHG1Fy6Q5));
				HQKHvbBm1h5 = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(l61d3sDbasAssbCf9Vfd(0x60620FC1 ^ 0x60628F15), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777221)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, a8tHG5D0RXp));
				num = 12;
				break;
			case 7:
				yJxHo7rIS5N = (DependencyProperty)wPmGIgDbEufTCpr102YY(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377133179), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)));
				qBjHo8cUa1y = (DependencyProperty)wPmGIgDbEufTCpr102YY(l61d3sDbasAssbCf9Vfd(0x6EC99CAF ^ 0x6EC88FF5), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777220)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)));
				z8FHoAiR2JZ = (DependencyProperty)wPmGIgDbEufTCpr102YY(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B25639), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				nTTHoPvq52a = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB146BF6), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				i0yHoJdtdmd = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(-962524685 ^ -962586061), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777220)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)));
				KOuHoFbi0rg = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2CE805), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				num = 9;
				break;
			case 5:
				w4XHohDGWGd = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530016701), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(OupHGfQoh9V));
				g4nHowZ7e2j = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28AAED6), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 3;
				}
				break;
			default:
				ADZHv9n5qix = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x384EAB1), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777220)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(-1, u2yHGBDA4rA));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num = 4;
				}
				break;
			case 12:
				QKqHvNRiW6p = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB7139D), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(false, Yl9HGS1XXMV));
				return;
			case 1:
				zxZHvY6MNEN = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C870D8), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, OdZHGaRyNq7));
				IkrHvoj4uFs = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1346933961), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, BXFHGinZ9tC));
				k9eHvvWfGDe = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(l61d3sDbasAssbCf9Vfd(-1435596783 ^ -1435525697), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(string.Empty, KiUHGlZIBvE));
				k6FHvBh6PCb = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D28312), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(string.Empty, SxQHG4nv4Qb));
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 8;
				}
				break;
			case 8:
				Ir3HorX7AyV = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056780674), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(0.0, fXaHGnLd8fG));
				NRiHoKMipEf = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338773850), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777261)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(B6jHG2PZqiW));
				XHOHomTTMFG = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009551781), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(UHxHGHTwvAj));
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 5;
				}
				break;
			case 6:
				SnBHop9qmor = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(0x24B0B9E6 ^ 0x24B1ADC0), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777220)), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(33555235)));
				num = 13;
				break;
			case 9:
				MRTHo3j8bLy = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(0x1D7BA1ED ^ 0x1D7AB5EF), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
				{
					num = 6;
				}
				break;
			case 11:
				evaHoZkQ9Ap = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x684F243E ^ 0x684F8B8E), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(16777262)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(0.0, POGHG9HvEec));
				ix2HoVwAHMQ = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225832353), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(0.0, nqqHGGOZfT5));
				VJnHoCIVLge = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(-82860344 ^ -82866624), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(0.0, VYRHGYsWiGB));
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
				{
					num = 8;
				}
				break;
			case 3:
				hA8HvH83XCs = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(-57768881 ^ -57700223), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				zLBHvfsyYiA = (DependencyProperty)wPmGIgDbEufTCpr102YY(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342675540), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777220)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num = 0;
				}
				break;
			case 13:
				B5PHouQRQox = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C8260AA), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				vwEHozkIGRJ = DependencyProperty.Register((string)l61d3sDbasAssbCf9Vfd(--855742383 ^ 0x330083C7), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)));
				num = 2;
				break;
			case 10:
				ETXHvab0soR = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(l61d3sDbasAssbCf9Vfd(0x9F0F634 ^ 0x9F1E3DC), GBS9D8DbcP5JLAYWgr9V(FF637YDbXbXwEsq3Zfn5(16777221)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(false, LqHHGD54cGY));
				mTaHviNa8GG = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5E0D90), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(FF637YDbXbXwEsq3Zfn5(33555235)), new PropertyMetadata(false, d1BHGbWhUf7));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num = 14;
				}
				break;
			case 4:
				w3pHvnZoRwM = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-838841832 ^ -838845516), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, lciHGopHSVt));
				Ed9HvGeE7nC = (DependencyProperty)qr8HmxDbjDlmeCx9CAda(l61d3sDbasAssbCf9Vfd(0x2D3134C9 ^ 0x2D302189), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), GBS9D8DbcP5JLAYWgr9V(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555235)), new PropertyMetadata(false, iZQHGvE8B3g));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void u8kRyJDbn8vEZ5finqQB(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static bool uqgU4UDbf2DARFhvmfGD()
	{
		return LZ6R4HDbHnEARwIrKw6L == null;
	}

	internal static LotSelectControl PdKXRYDb9FvJCfdibZv8()
	{
		return LZ6R4HDbHnEARwIrKw6L;
	}

	internal static object fkmX6TDbGrGBdLsIZEqF(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void UbVcGrDbYmxt40M59iAt(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static double IGv11sDboq7ja8g0uRPf(double P_0, long P_1, double P_2)
	{
		return JLFqEJGJYiHaSdoROJXI.AZ0GJbFd8HF(P_0, P_1, P_2);
	}

	internal static double zHeUnwDbvAkVYP9PpJx4(double P_0, int P_1)
	{
		return Math.Round(P_0, P_1);
	}

	internal static double sFsl1NDbB1kRqDYF84YO(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object l61d3sDbasAssbCf9Vfd(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Meo95vDbi4dROZxRGwGJ(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void i4eBEPDblfG6RoYnflg4(object P_0)
	{
		((LotSelectControl)P_0).SkmHGx54WvN();
	}

	internal static void yDIKZUDb4vqn5U5UQICU(object P_0, object P_1)
	{
		((DoubleEditBox)P_0).Format = (string)P_1;
	}

	internal static object N2JZ73DbDmUADTIUwFl0(object P_0)
	{
		return ((FrameworkContentElement)P_0).Parent;
	}

	internal static double fprxXgDbbfPUjEnJP8AY(object P_0)
	{
		return ((waq1Af2bWXQbeynqsiXl)P_0).Leverage;
	}

	internal static int HTaEx4DbNGHqYZZWvPXg(double P_0, double P_1, double P_2)
	{
		return JLFqEJGJYiHaSdoROJXI.Qr8GJD6AHk5(P_0, P_1, P_2);
	}

	internal static double l0BGplDbkCde8YbqlHiJ(double P_0, double P_1, int P_2)
	{
		return JLFqEJGJYiHaSdoROJXI.k62GJ45Rvfj(P_0, P_1, P_2);
	}

	internal static bool TZ9ieFDb17GIhvAkvg8d(object P_0)
	{
		return ((UIElement)P_0).IsVisible;
	}

	internal static double inwL01Db59bvYo0EwiTb(double P_0, long P_1, double P_2, double P_3, double P_4, double P_5)
	{
		return JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	internal static bool xDMjmxDbSJ6Ndn94vOc1(object P_0)
	{
		return ((UIElement)P_0).Focus();
	}

	internal static void BoXptmDbxLWhObpO8BJL(object P_0, object P_1)
	{
		((UIElement)P_0).GotKeyboardFocus += (KeyboardFocusChangedEventHandler)P_1;
	}

	internal static void LguGlXDbLK0QReaUB8va(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewKeyDown += (KeyEventHandler)P_1;
	}

	internal static void iDeCGrDbe5mVC4LrrLBB(object P_0, object P_1)
	{
		((UIElement)P_0).LostKeyboardFocus += (KeyboardFocusChangedEventHandler)P_1;
	}

	internal static void mK74o2DbskCJfrZRb5a3()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static RuntimeTypeHandle FF637YDbXbXwEsq3Zfn5(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type GBS9D8DbcP5JLAYWgr9V(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object qr8HmxDbjDlmeCx9CAda(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static object wPmGIgDbEufTCpr102YY(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
