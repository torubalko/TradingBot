using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using oaHFMv2b4o31O8WGaeUF;
using TigerTrade.Annotations;
using TU1GsM2Dm9QaIaTGcmUQ;
using TuAMtrl1Nd3XoZQQUXf0;
using Ubyym82bHttFNkeQsYlY;

namespace AQB6mgf3wjOUxVfiEwwS;

[ReadOnly(true)]
[DataContract(Name = "TradingPreset", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Market.Common")]
internal sealed class EpdvD7f3hWq8UlJ32f6V : INotifyPropertyChanged
{
	[CompilerGenerated]
	private string MCyfpimYDx7;

	private ee3m5R2blOAsUyGExn75 UcZfplJQvrj;

	private ee3m5R2blOAsUyGExn75 IYQfp40MFkG;

	private u9cjrs2b2q0r2LuEQmub ukwfpDNCt18;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static EpdvD7f3hWq8UlJ32f6V yLo615blLQ1LP1WQT80F;

	[Browsable(false)]
	public string JGkf33jlUPP
	{
		[CompilerGenerated]
		get
		{
			return MCyfpimYDx7;
		}
		[CompilerGenerated]
		private set
		{
			MCyfpimYDx7 = mCyfpimYDx;
		}
	}

	[DataMember(Name = "SizeParam")]
	public ee3m5R2blOAsUyGExn75 KTHf3z56Hl0
	{
		get
		{
			return UcZfplJQvrj ?? (UcZfplJQvrj = new ee3m5R2blOAsUyGExn75(0.0));
		}
		set
		{
			UcZfplJQvrj = ucZfplJQvrj;
		}
	}

	[DefaultValue(0)]
	public double Size
	{
		get
		{
			return KTHf3z56Hl0.Jva2DwEHfew(JGkf33jlUPP);
		}
		set
		{
			if (KTHf3z56Hl0.VJL2bDnC6kr(JGkf33jlUPP, num, 0.0))
			{
				t6Rf3P0hUk7((string)i8pEGrblX1eqH2Hdf9m4(--500511424 ^ 0x1DD552C6));
			}
		}
	}

	[DataMember(Name = "QuoteSizeParam")]
	public ee3m5R2blOAsUyGExn75 b8Mfp98YYVn
	{
		get
		{
			return IYQfp40MFkG ?? (IYQfp40MFkG = new ee3m5R2blOAsUyGExn75(0.0));
		}
		set
		{
			IYQfp40MFkG = iYQfp40MFkG;
		}
	}

	public double QuoteSize
	{
		get
		{
			return b8Mfp98YYVn.Jva2DwEHfew(JGkf33jlUPP);
		}
		set
		{
			if (b8Mfp98YYVn.VJL2bDnC6kr(JGkf33jlUPP, num, 0.0))
			{
				t6Rf3P0hUk7((string)i8pEGrblX1eqH2Hdf9m4(0x9F0F634 ^ 0x9F0771E));
			}
		}
	}

	[DataMember(Name = "PercentSizeParam")]
	public u9cjrs2b2q0r2LuEQmub gFUfpve2n4X
	{
		get
		{
			return ukwfpDNCt18 ?? (ukwfpDNCt18 = new u9cjrs2b2q0r2LuEQmub(0));
		}
		set
		{
			ukwfpDNCt18 = u9cjrs2b2q0r2LuEQmub;
		}
	}

	public int PercentSize
	{
		get
		{
			return gFUfpve2n4X.Jva2DwEHfew(JGkf33jlUPP);
		}
		set
		{
			if (gFUfpve2n4X.js02bfsgQ4R(JGkf33jlUPP, num, 0))
			{
				t6Rf3P0hUk7((string)i8pEGrblX1eqH2Hdf9m4(-1801468030 ^ -1801500990));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
						{
							num = 1;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
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
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
					{
						num = 1;
					}
				}
			}
		}
	}

	public EpdvD7f3hWq8UlJ32f6V()
	{
		DdVvPQblcw6PeVFbDJxA();
		base._002Ector();
	}

	public EpdvD7f3hWq8UlJ32f6V(int P_0)
	{
		DdVvPQblcw6PeVFbDJxA();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Size = P_0;
	}

	public void DMlf37SVvG2(string P_0)
	{
		if (!(JGkf33jlUPP == P_0))
		{
			JGkf33jlUPP = P_0;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Widf38LmTcn();
		}
	}

	private void Widf38LmTcn()
	{
		t6Rf3P0hUk7(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002294315));
		t6Rf3P0hUk7(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583311764));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		t6Rf3P0hUk7(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x8093B8B));
	}

	public void Vc1f3AqL3cu(EpdvD7f3hWq8UlJ32f6V P_0, bool P_1)
	{
		if (P_1)
		{
			goto IL_006f;
		}
		int num;
		if (Size == P_0.KTHf3z56Hl0.Value && QuoteSize == P_0.b8Mfp98YYVn.Value)
		{
			num = 2;
			goto IL_0005;
		}
		goto IL_00b0;
		IL_0120:
		if (PercentSize == ((NeyDU62DKFU8Qyxyvfd6<int>)iSLwttblE9vvJJmMvexr(P_0)).Value)
		{
			return;
		}
		num = 3;
		goto IL_0005;
		IL_006f:
		KTHf3z56Hl0.QSM2D8R8ont((NeyDU62DKFU8Qyxyvfd6<double>)EhTImObljpVp2GD5Zstm(P_0), _0020: true);
		b8Mfp98YYVn.QSM2D8R8ont(P_0.b8Mfp98YYVn, _0020: true);
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
		{
			num2 = 0;
		}
		goto IL_0009;
		IL_00b0:
		Size = P_0.KTHf3z56Hl0.Value;
		QuoteSize = ((NeyDU62DKFU8Qyxyvfd6<double>)SiceAPblQuL1HyY2K1NO(P_0)).Value;
		PercentSize = P_0.gFUfpve2n4X.Value;
		Widf38LmTcn();
		return;
		IL_0005:
		num2 = num;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				break;
			case 3:
				goto IL_00b0;
			case 2:
				goto IL_0120;
			default:
				gFUfpve2n4X.QSM2D8R8ont(P_0.gFUfpve2n4X, _0020: true);
				Widf38LmTcn();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		goto IL_006f;
	}

	[NotifyPropertyChangedInvocator]
	private void t6Rf3P0hUk7([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			D7Yk6ZbldH86lOlZdN7h(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	static EpdvD7f3hWq8UlJ32f6V()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool apQNhPblegM32ssLE9o9()
	{
		return yLo615blLQ1LP1WQT80F == null;
	}

	internal static EpdvD7f3hWq8UlJ32f6V ARbHBiblscFBn25pKNaJ()
	{
		return yLo615blLQ1LP1WQT80F;
	}

	internal static object i8pEGrblX1eqH2Hdf9m4(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void DdVvPQblcw6PeVFbDJxA()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object EhTImObljpVp2GD5Zstm(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).KTHf3z56Hl0;
	}

	internal static object iSLwttblE9vvJJmMvexr(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).gFUfpve2n4X;
	}

	internal static object SiceAPblQuL1HyY2K1NO(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).b8Mfp98YYVn;
	}

	internal static void D7Yk6ZbldH86lOlZdN7h(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
