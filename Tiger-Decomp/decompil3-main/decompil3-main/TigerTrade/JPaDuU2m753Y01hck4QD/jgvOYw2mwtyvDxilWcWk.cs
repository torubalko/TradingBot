using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using bl7Or1fDrLHNeTtGhT82;
using ECOEgqlSad8NUJZ2Dr9n;
using If1oyCHiFG4LnIUAsfeE;
using nC8oZVi8pvEIhb4vhIix;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using UIKit.Core;

namespace JPaDuU2m753Y01hck4QD;

internal class jgvOYw2mwtyvDxilWcWk : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private MarketSettings TRE2h1iY7AQ;

	private static MOWYtTHiJiOZMqTggitO[] BmN2h5oKDiB;

	[CompilerGenerated]
	private readonly ICommand BEe2hSwwC6K;

	private MOWYtTHiJiOZMqTggitO TrH2hxwUcKT;

	private int? qDc2hLAYrQu;

	private double? cAZ2helYZgq;

	private int? Q2o2hsV1p38;

	private double? tVe2hXHLBUk;

	private int? RYJ2hcHiIPY;

	private double? m6o2hj4DSnI;

	private int? RLb2hEGsfqy;

	private double? b1j2hQ2KJMb;

	private int? AVF2hdOPHTl;

	private double? vej2hgKi5Xn;

	internal jgvOYw2mwtyvDxilWcWk ThisWindow;

	internal DropDown TypeOffset;

	private bool pQO2hRFcgbB;

	private static jgvOYw2mwtyvDxilWcWk NHEppvDHm8ScT4rwioAl;

	public IEnumerable<MOWYtTHiJiOZMqTggitO> ValueTypes => BmN2h5oKDiB;

	public ICommand CloseCommand
	{
		[CompilerGenerated]
		get
		{
			return BEe2hSwwC6K;
		}
	}

	public MOWYtTHiJiOZMqTggitO OffsetsType
	{
		get
		{
			return TrH2hxwUcKT;
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
					if (mOWYtTHiJiOZMqTggitO != TrH2hxwUcKT)
					{
						TrH2hxwUcKT = mOWYtTHiJiOZMqTggitO;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x8096117));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int? LimitOrderOffset
	{
		get
		{
			return qDc2hLAYrQu;
		}
		set
		{
			if (num != qDc2hLAYrQu)
			{
				qDc2hLAYrQu = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673650647));
			}
		}
	}

	public double? LimitOrderPercentOffset
	{
		get
		{
			return cAZ2helYZgq;
		}
		set
		{
			if (num != cAZ2helYZgq)
			{
				cAZ2helYZgq = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520104569));
			}
		}
	}

	public int? StopOrderOffset
	{
		get
		{
			return Q2o2hsV1p38;
		}
		set
		{
			if (num != Q2o2hsV1p38)
			{
				Q2o2hsV1p38 = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225790559));
			}
		}
	}

	public double? StopOrderPercentOffset
	{
		get
		{
			return tVe2hXHLBUk;
		}
		set
		{
			if (num != tVe2hXHLBUk)
			{
				tVe2hXHLBUk = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82871584));
			}
		}
	}

	public int? TriggerOrderOffset
	{
		get
		{
			return RYJ2hcHiIPY;
		}
		set
		{
			if (num != RYJ2hcHiIPY)
			{
				RYJ2hcHiIPY = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BFCC52));
			}
		}
	}

	public double? TriggerOrderPercentOffset
	{
		get
		{
			return m6o2hj4DSnI;
		}
		set
		{
			if (num != m6o2hj4DSnI)
			{
				m6o2hj4DSnI = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315A6DBB));
			}
		}
	}

	public int? TakeProfitOffset
	{
		get
		{
			return RLb2hEGsfqy;
		}
		set
		{
			if (num != RLb2hEGsfqy)
			{
				RLb2hEGsfqy = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338802976));
			}
		}
	}

	public double? TakeProfitPercentOffset
	{
		get
		{
			return b1j2hQ2KJMb;
		}
		set
		{
			if (num != b1j2hQ2KJMb)
			{
				b1j2hQ2KJMb = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04FA7E));
			}
		}
	}

	public int? StopLossOffset
	{
		get
		{
			return AVF2hdOPHTl;
		}
		set
		{
			if (num != AVF2hdOPHTl)
			{
				AVF2hdOPHTl = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29734112));
			}
		}
	}

	public double? StopLossPercentOffset
	{
		get
		{
			return vej2hgKi5Xn;
		}
		set
		{
			if (num != vej2hgKi5Xn)
			{
				vej2hgKi5Xn = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962634703));
			}
		}
	}

	public jgvOYw2mwtyvDxilWcWk()
	{
		HxBogLDH7qx3aAKqLK1I();
		base._002Ector();
		BEe2hSwwC6K = new RelayCommand(X2W2mP0kbFS);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void OffsetsSettingsWindow_OnLoaded(object sender, RoutedEventArgs e)
	{
		LimitOrderOffset = TRE2h1iY7AQ.TradeSettings.LimitOrderOffset;
		StopOrderOffset = ((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).StopOrderOffset;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				StopLossOffset = TRE2h1iY7AQ.TradeSettings.StopLossOffset;
				LimitOrderPercentOffset = ((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).LimitOrderPercentOffset;
				num = 2;
				break;
			default:
				TriggerOrderOffset = TRE2h1iY7AQ.TradeSettings.TriggerOrderOffset;
				TakeProfitOffset = TRE2h1iY7AQ.TradeSettings.TakeProfitOffset;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				TakeProfitPercentOffset = ((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).TakeProfitPercentOffset;
				StopLossPercentOffset = TRE2h1iY7AQ.TradeSettings.StopLossPercentOffset;
				OffsetsType = ((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).OffsetsType;
				return;
			case 2:
				StopOrderPercentOffset = TRE2h1iY7AQ.TradeSettings.StopOrderPercentOffset;
				TriggerOrderPercentOffset = TRE2h1iY7AQ.TradeSettings.TriggerOrderPercentOffset;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public static bool D3i2m80T8I9(Window P_0, MarketSettings P_1)
	{
		return new jgvOYw2mwtyvDxilWcWk
		{
			Owner = P_0,
			TRE2h1iY7AQ = P_1
		}.ShowDialog() == true;
	}

	private void IWL2mAu6vnM(object P_0, RoutedEventArgs P_1)
	{
		TRE2h1iY7AQ.TradeSettings.LimitOrderOffset = LimitOrderOffset;
		TRE2h1iY7AQ.TradeSettings.StopOrderOffset = StopOrderOffset;
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
				TRE2h1iY7AQ.TradeSettings.StopLossOffset = StopLossOffset;
				((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).LimitOrderPercentOffset = LimitOrderPercentOffset;
				((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).StopOrderPercentOffset = StopOrderPercentOffset;
				TRE2h1iY7AQ.TradeSettings.TriggerOrderPercentOffset = TriggerOrderPercentOffset;
				TRE2h1iY7AQ.TradeSettings.TakeProfitPercentOffset = TakeProfitPercentOffset;
				((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).StopLossPercentOffset = StopLossPercentOffset;
				((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).OffsetsType = OffsetsType;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
				{
					num = 0;
				}
				break;
			default:
				base.DialogResult = true;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				Close();
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
				{
					num = 0;
				}
				break;
			case 2:
				((CR1isWfDCD1A4fwfUJUf)pc8W3eDH8A2qp3fybS8v(TRE2h1iY7AQ)).TriggerOrderOffset = TriggerOrderOffset;
				TRE2h1iY7AQ.TradeSettings.TakeProfitOffset = TakeProfitOffset;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void X2W2mP0kbFS(object P_0)
	{
		Close();
	}

	private void ggY2mJvbPjr(object P_0, RoutedEventArgs P_1)
	{
		string fileName = (string)PyWp9xDHADCNiA89uYQ2();
		try
		{
			iTx2wsDHPPpyBMrQd9Se(new ProcessStartInfo(fileName));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!pQO2hRFcgbB)
		{
			pQO2hRFcgbB = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894959166), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
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
		return (Delegate)lqS8KYDHJ38aZHmUin7f(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pQO2hRFcgbB = true;
				num2 = 3;
				continue;
			case 2:
				switch (P_0)
				{
				case 4:
					((AccentButton)P_1).Click += IWL2mAu6vnM;
					return;
				default:
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					TypeOffset = (DropDown)P_1;
					return;
				case 1:
					break;
				case 2:
					Qj6CulDHF5t0eRNfTYrW((M02cpSi83xElTeNoV0cD)P_1, new RoutedEventHandler(ggY2mJvbPjr));
					return;
				}
				break;
			case 3:
				return;
			}
			break;
		}
		ThisWindow = (jgvOYw2mwtyvDxilWcWk)P_1;
	}

	static jgvOYw2mwtyvDxilWcWk()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		BmN2h5oKDiB = new MOWYtTHiJiOZMqTggitO[2]
		{
			MOWYtTHiJiOZMqTggitO.PriceStep,
			MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq
		};
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void HxBogLDH7qx3aAKqLK1I()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool opsAJ5DHhdGdbb2pFuaw()
	{
		return NHEppvDHm8ScT4rwioAl == null;
	}

	internal static jgvOYw2mwtyvDxilWcWk rscVXwDHwPWH2rS1ubWl()
	{
		return NHEppvDHm8ScT4rwioAl;
	}

	internal static object pc8W3eDH8A2qp3fybS8v(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static object PyWp9xDHADCNiA89uYQ2()
	{
		return TigerTrade.Properties.Resources.OffsetsSettingsWindowManualUrl;
	}

	internal static object iTx2wsDHPPpyBMrQd9Se(object P_0)
	{
		return Process.Start((ProcessStartInfo)P_0);
	}

	internal static object lqS8KYDHJ38aZHmUin7f(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void Qj6CulDHF5t0eRNfTYrW(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
