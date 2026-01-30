using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Media;
using cY9HKMfP6DC0C8LIwE00;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace NHkZqbf77HnCtq0ER8ta;

[KnownType(typeof(tQdY3yfPR6B0dxodinwZ))]
[DataContract(Name = "PriceLevel", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Market.Common")]
internal class BpmEftf7wYbuVebk5Vku : ICloneable, INotifyPropertyChanged
{
	[Serializable]
	[CompilerGenerated]
	private sealed class LEhybUnJ21USq1Mk69v9
	{
		public static readonly LEhybUnJ21USq1Mk69v9 LVhnJfT8pBI;

		public static Func<BpmEftf7wYbuVebk5Vku, long> xEYnJ9bPAmx;

		private static LEhybUnJ21USq1Mk69v9 D3YmxgNOHV5ZFXUqmQvZ;

		static LEhybUnJ21USq1Mk69v9()
		{
			PE3QmsNOnedDTktJVYr4();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			LVhnJfT8pBI = new LEhybUnJ21USq1Mk69v9();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public LEhybUnJ21USq1Mk69v9()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal long mELnJHioVly(BpmEftf7wYbuVebk5Vku priceLevel)
		{
			return priceLevel.mIjl9ITKC93();
		}

		internal static void PE3QmsNOnedDTktJVYr4()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool Dx9iVWNOfSgBSkG0L1x9()
		{
			return D3YmxgNOHV5ZFXUqmQvZ == null;
		}

		internal static LEhybUnJ21USq1Mk69v9 PtldeeNO9YhbOwgh98e6()
		{
			return D3YmxgNOHV5ZFXUqmQvZ;
		}
	}

	private string rCdf87SdgdS;

	[CompilerGenerated]
	private double R8Uf88s0fBe;

	[CompilerGenerated]
	private double h17f8AtWj5v;

	private long oFdf8PTSvfm;

	[CompilerGenerated]
	private XBrush zKxf8J07Lt3;

	[CompilerGenerated]
	private XPen AJCf8FdBGyO;

	[CompilerGenerated]
	private XBrush MGxf83fSZNj;

	[CompilerGenerated]
	private XPen YaGf8pTec6U;

	private XColor ouZf8ug6wFN;

	private int Uhcf8zWtPny;

	[CompilerGenerated]
	private XBrush vI3fA0iF1d1;

	[CompilerGenerated]
	private XPen eqRfA2XT4qT;

	private XColor TAKfAHOCx38;

	[CompilerGenerated]
	private XBrush fShfAftMn6f;

	private XColor pCJfA9wjrdX;

	private int e0BfAnooPa8;

	private XDashStyle IVUfAGmD6So;

	private string hjJfAYf9km9;

	private ObjectTextAlignment xEdfAoNGFHo;

	private int A6ZfAv3jsKa;

	[CompilerGenerated]
	private DateTime zZWfABGMqBA;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static BpmEftf7wYbuVebk5Vku pXdKy6baQhVYmXC8GAIx;

	[Browsable(false)]
	[DataMember(Name = "ID")]
	public string balf7pvwCJI
	{
		get
		{
			if (t16bhIbaR9WtKpbDQxYq(rCdf87SdgdS))
			{
				rCdf87SdgdS = Guid.NewGuid().ToString();
			}
			return rCdf87SdgdS;
		}
		set
		{
			rCdf87SdgdS = text;
		}
	}

	[DataMember(Name = "Step")]
	[Browsable(false)]
	public double u2Uf80PdXgt
	{
		[CompilerGenerated]
		get
		{
			return R8Uf88s0fBe;
		}
		[CompilerGenerated]
		set
		{
			R8Uf88s0fBe = r8Uf88s0fBe;
		}
	}

	[Browsable(false)]
	public double YHbf8fE2TKg
	{
		[CompilerGenerated]
		get
		{
			return h17f8AtWj5v;
		}
		[CompilerGenerated]
		set
		{
			h17f8AtWj5v = num;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("PriceLevelPrice")]
	[Browsable(false)]
	[T4IXj62qBfXCaxs2RI5("PriceLevelLevel")]
	public decimal RealPrice
	{
		get
		{
			return (decimal)((double)Price * u2Uf80PdXgt);
		}
		set
		{
			Price = ((u2Uf80PdXgt > 0.0) ? ((int)((double)num / u2Uf80PdXgt + 0.5)) : 0);
		}
	}

	[DataMember(Name = "Price")]
	[Browsable(false)]
	public long Price
	{
		get
		{
			return oFdf8PTSvfm;
		}
		set
		{
			num = bR7tBAba66nVgew3GgRf(0L, num);
			if (num == oFdf8PTSvfm)
			{
				return;
			}
			oFdf8PTSvfm = num;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181341798));
					W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461885224));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ai8f8BaBZhP
	{
		[CompilerGenerated]
		get
		{
			return zKxf8J07Lt3;
		}
		[CompilerGenerated]
		private set
		{
			zKxf8J07Lt3 = xBrush;
		}
	}

	[Browsable(false)]
	public XPen TCKf8lusEtJ
	{
		[CompilerGenerated]
		get
		{
			return AJCf8FdBGyO;
		}
		[CompilerGenerated]
		private set
		{
			AJCf8FdBGyO = aJCf8FdBGyO;
		}
	}

	[Browsable(false)]
	public XBrush FkTf8bF3ZCJ
	{
		[CompilerGenerated]
		get
		{
			return MGxf83fSZNj;
		}
		[CompilerGenerated]
		private set
		{
			MGxf83fSZNj = mGxf83fSZNj;
		}
	}

	[Browsable(false)]
	public XPen mnpf81gmaD7
	{
		[CompilerGenerated]
		get
		{
			return YaGf8pTec6U;
		}
		[CompilerGenerated]
		private set
		{
			YaGf8pTec6U = yaGf8pTec6U;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("PriceLevelLineColor")]
	[DataMember(Name = "LineColor")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	public XColor LineColor
	{
		get
		{
			return ouZf8ug6wFN;
		}
		set
		{
			if (xColor == ouZf8ug6wFN)
			{
				return;
			}
			ouZf8ug6wFN = xColor;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					FkTf8bF3ZCJ = new XBrush(new XColor(127, xA6GQwbaMUWxAEOwNYu6(xColor)));
					TCKf8lusEtJ = new XPen(ai8f8BaBZhP, LineWidth, LineStyle);
					mnpf81gmaD7 = new XPen(FkTf8bF3ZCJ, LineWidth, LineStyle);
					W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -61124491));
					num = 2;
					break;
				case 1:
					ai8f8BaBZhP = new XBrush(xColor);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	[DataMember(Name = "LineWidth")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	[bBo0Zd2ycQQr3LNHQf4("PriceLevelLineWidth")]
	public int LineWidth
	{
		get
		{
			return Uhcf8zWtPny;
		}
		set
		{
			num = ztmB4Sbaq5eeDZJfOIgQ(1, SaiboSbaOqr3i465Rnb2(10, num));
			int num2;
			if (num != Uhcf8zWtPny)
			{
				Uhcf8zWtPny = num;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
				{
					num2 = 1;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			S8Ul9MSCTAl(Uhcf8zWtPny, LineStyle);
			W5Wf7JieErq((string)lj6Y6rbaIXlBJkaQqSFa(0x50C1C840 ^ 0x50C5FE06));
		}
	}

	[Browsable(false)]
	public XBrush g1Uf8Xk69kE
	{
		[CompilerGenerated]
		get
		{
			return vI3fA0iF1d1;
		}
		[CompilerGenerated]
		private set
		{
			vI3fA0iF1d1 = xBrush;
		}
	}

	[Browsable(false)]
	public XPen MgDf8Ep0uHI
	{
		[CompilerGenerated]
		get
		{
			return eqRfA2XT4qT;
		}
		[CompilerGenerated]
		private set
		{
			eqRfA2XT4qT = xPen;
		}
	}

	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	[bBo0Zd2ycQQr3LNHQf4("MarketThemeLevelCpBorderColor")]
	[DataMember(Name = "CpBorderColor")]
	public XColor CpBorderColor
	{
		get
		{
			return TAKfAHOCx38;
		}
		set
		{
			if (xColor.Equals(TAKfAHOCx38))
			{
				return;
			}
			TAKfAHOCx38 = xColor;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
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
				g1Uf8Xk69kE = new XBrush(xColor);
				MgDf8Ep0uHI = new XPen(g1Uf8Xk69kE, 1);
				W5Wf7JieErq((string)lj6Y6rbaIXlBJkaQqSFa(0x68C7EAE6 ^ 0x68C3DCBA));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush xivf86t9rn8
	{
		[CompilerGenerated]
		get
		{
			return fShfAftMn6f;
		}
		[CompilerGenerated]
		private set
		{
			fShfAftMn6f = xBrush;
		}
	}

	[DataMember(Name = "CpBackColor")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	[bBo0Zd2ycQQr3LNHQf4("MarketThemeLevelCpBackColor")]
	public XColor CpBackColor
	{
		get
		{
			return pCJfA9wjrdX;
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
					if (!color.Equals(pCJfA9wjrdX))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					return;
				default:
					pCJfA9wjrdX = color;
					xivf86t9rn8 = new XBrush(color);
					W5Wf7JieErq((string)lj6Y6rbaIXlBJkaQqSFa(--855742383 ^ 0x3305A1D5));
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("PriceLevelLineLength")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	[DefaultValue(100)]
	[DataMember(Name = "LineLength")]
	public int LineLength
	{
		get
		{
			return e0BfAnooPa8;
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
					num3 = Math.Max(1, Math.Min(100, num3));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (num3 != e0BfAnooPa8)
					{
						e0BfAnooPa8 = num3;
						W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991604535));
					}
					return;
				}
			}
		}
	}

	[DataMember(Name = "LineStyle")]
	[bBo0Zd2ycQQr3LNHQf4("PriceLevelLineStyle")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	public XDashStyle LineStyle
	{
		get
		{
			return IVUfAGmD6So;
		}
		set
		{
			if (xDashStyle != IVUfAGmD6So)
			{
				IVUfAGmD6So = xDashStyle;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				S8Ul9MSCTAl(LineWidth, IVUfAGmD6So);
				W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -601888033));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("PriceLevelText")]
	[bBo0Zd2ycQQr3LNHQf4("PriceLevelText")]
	[Browsable(false)]
	[DataMember(Name = "Text")]
	public string Text
	{
		get
		{
			return hjJfAYf9km9;
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
					if (Bye5qmbaWg5X9vXvKfW8(text, hjJfAYf9km9))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
						{
							num2 = 0;
						}
						break;
					}
					hjJfAYf9km9 = text;
					W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108459628));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "TextAlignment")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelText")]
	[bBo0Zd2ycQQr3LNHQf4("PriceLevelTextAlignment")]
	public ObjectTextAlignment TextAlignment
	{
		get
		{
			return xEdfAoNGFHo;
		}
		set
		{
			if (objectTextAlignment != xEdfAoNGFHo)
			{
				xEdfAoNGFHo = objectTextAlignment;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962903501));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("PriceLevelTextSize")]
	[T4IXj62qBfXCaxs2RI5("PriceLevelText")]
	[DataMember(Name = "FontSize")]
	public int FontSize
	{
		get
		{
			return A6ZfAv3jsKa;
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
					if (num3 != A6ZfAv3jsKa)
					{
						A6ZfAv3jsKa = num3;
						W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017342336));
					}
					return;
				case 1:
					num3 = ztmB4Sbaq5eeDZJfOIgQ(10, Math.Min(100, num3));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public DateTime oqff8mcuTCH
	{
		[CompilerGenerated]
		get
		{
			return zZWfABGMqBA;
		}
		[CompilerGenerated]
		private set
		{
			zZWfABGMqBA = dateTime;
		}
	}

	[Browsable(false)]
	public string FullName
	{
		get
		{
			if (Price <= 0)
			{
				return Resources.PriceLevelNewLevel;
			}
			return RealPrice.ToString((string)GSgqidbaVRgmBQyNXecM(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1346934277), YHbf8fE2TKg.ToString()));
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
				{
					num2 = 2;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler3 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					propertyChangedEventHandler = propertyChangedEventHandler3;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					propertyChangedEventHandler3 = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)FDUGfHbaCVXHenvWd2TI(propertyChangedEventHandler, propertyChangedEventHandler2);
					propertyChangedEventHandler3 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					if ((object)propertyChangedEventHandler3 == propertyChangedEventHandler)
					{
						return;
					}
					goto default;
				}
				}
			}
		}
	}

	protected virtual void S8Ul9MSCTAl(int P_0, XDashStyle P_1)
	{
		TCKf8lusEtJ = new XPen(ai8f8BaBZhP, P_0, P_1);
		mnpf81gmaD7 = new XPen(FkTf8bF3ZCJ, P_0, P_1);
	}

	public BpmEftf7wYbuVebk5Vku()
	{
		PkgkDXbatDmy6QiF9h5x();
		base._002Ector();
		balf7pvwCJI = Guid.NewGuid().ToString();
		Price = 0L;
		LineColor = W4ViotbaU8HKBOsKDi98();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				LineWidth = 2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				u2Uf80PdXgt = 0.0;
				YHbf8fE2TKg = 0.0;
				Text = "";
				num = 5;
				break;
			case 5:
				TextAlignment = ObjectTextAlignment.RightTop;
				FontSize = 14;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
				{
					num = 4;
				}
				break;
			default:
				CpBorderColor = IoWYgfbaTdtBf52Tp5Nm(byte.MaxValue, byte.MaxValue, 165, 0);
				CpBackColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 215, 0);
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
				{
					num = 6;
				}
				break;
			case 1:
				LineLength = 100;
				num = 2;
				break;
			case 2:
				LineStyle = XDashStyle.Solid;
				num = 3;
				break;
			case 4:
				oqff8mcuTCH = DateTime.MinValue;
				return;
			}
		}
	}

	[OnDeserializing]
	protected void BC0f78qnRkO(StreamingContext P_0)
	{
		BpmEftf7wYbuVebk5Vku bpmEftf7wYbuVebk5Vku = new BpmEftf7wYbuVebk5Vku();
		LineLength = d6ebBsbayVyhFMvt91Gg(bpmEftf7wYbuVebk5Vku);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				CpBorderColor = bpmEftf7wYbuVebk5Vku.CpBorderColor;
				return;
			}
			LineColor = bpmEftf7wYbuVebk5Vku.LineColor;
			CpBackColor = wXcBLbbaZWeQ1mxeujXB(bpmEftf7wYbuVebk5Vku);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
			{
				num = 1;
			}
		}
	}

	public virtual object Clone()
	{
		if (LineLength == 0)
		{
			LineLength = 100;
		}
		return MemberwiseClone();
	}

	public override string ToString()
	{
		return FullName;
	}

	public virtual void UXOl9OdBHfZ()
	{
	}

	public virtual void i4jl9qtyMQG()
	{
	}

	public static bool bYof7AHatOb(IEnumerable<BpmEftf7wYbuVebk5Vku> P_0, IEnumerable<BpmEftf7wYbuVebk5Vku> P_1)
	{
		return l5qf7POjKQq(P_0) == l5qf7POjKQq(P_1);
	}

	private static long l5qf7POjKQq(IEnumerable<BpmEftf7wYbuVebk5Vku> P_0)
	{
		return P_0.Sum((BpmEftf7wYbuVebk5Vku priceLevel) => priceLevel.mIjl9ITKC93());
	}

	protected virtual long mIjl9ITKC93()
	{
		return (long)(balf7pvwCJI.GetHashCode() + Price.GetHashCode() + LineColor.GetHashCode() + CpBorderColor.GetHashCode() + CpBackColor.GetHashCode() + LineWidth + LineStyle + Text.GetHashCode());
	}

	[NotifyPropertyChangedInvocator]
	protected void W5Wf7JieErq([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		oqff8mcuTCH = il2AYlbarrPM18w3otlH();
		propertyChangedEventHandler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static BpmEftf7wYbuVebk5Vku()
	{
		Nb9SQRbaKCAjSUvtGh5N();
	}

	internal static bool t16bhIbaR9WtKpbDQxYq(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool DKc1T5badjFpCoiiUvP9()
	{
		return pXdKy6baQhVYmXC8GAIx == null;
	}

	internal static BpmEftf7wYbuVebk5Vku wy2fdEbaguHxAXT9p8sn()
	{
		return pXdKy6baQhVYmXC8GAIx;
	}

	internal static long bR7tBAba66nVgew3GgRf(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Color xA6GQwbaMUWxAEOwNYu6(XColor P_0)
	{
		return P_0;
	}

	internal static int SaiboSbaOqr3i465Rnb2(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int ztmB4Sbaq5eeDZJfOIgQ(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object lj6Y6rbaIXlBJkaQqSFa(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Bye5qmbaWg5X9vXvKfW8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void PkgkDXbatDmy6QiF9h5x()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Color W4ViotbaU8HKBOsKDi98()
	{
		return Colors.CornflowerBlue;
	}

	internal static Color IoWYgfbaTdtBf52Tp5Nm(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static int d6ebBsbayVyhFMvt91Gg(object P_0)
	{
		return ((BpmEftf7wYbuVebk5Vku)P_0).LineLength;
	}

	internal static XColor wXcBLbbaZWeQ1mxeujXB(object P_0)
	{
		return ((BpmEftf7wYbuVebk5Vku)P_0).CpBackColor;
	}

	internal static object GSgqidbaVRgmBQyNXecM(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object FDUGfHbaCVXHenvWd2TI(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static DateTime il2AYlbarrPM18w3otlH()
	{
		return DateTime.Now;
	}

	internal static void Nb9SQRbaKCAjSUvtGh5N()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
