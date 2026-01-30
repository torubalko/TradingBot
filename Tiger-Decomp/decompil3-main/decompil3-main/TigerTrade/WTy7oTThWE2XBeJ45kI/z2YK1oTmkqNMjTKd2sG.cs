using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using A7PBFkrUtbNj4gSdVX7;
using ActiproSoftware.Windows.Controls.Docking;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bFLVeaGpb14YNScYcv2Q;
using cFuR4yZNvNDI2d1mIa2;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using i4WYHmmGr6wQtBbGc24;
using IJvSM0KZNRLJfn7wLHg;
using iTKs8kKoZFtJVRfCm8S;
using jgjtvHCL3QauSQfdFVQ;
using jS3Y2j9pTQRy0FnOknFG;
using lu2mPMmsdlOvPFIB25c;
using mjh1ZU2Dj2wC6DxZG11n;
using nAvYJWf1bMGCThCuJqPY;
using pSN0Obm4uT0my4JTdtJ;
using RNVda52xiPon1C9Km8N2;
using Sd0VM7yM7ZPkUlgREoF;
using TigerTrade.Chart.Base;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Common;
using tpDLBrGJAci5JWh2s4im;
using TpfAZxGpdyO6SBbUrRDP;
using TuAMtrl1Nd3XoZQQUXf0;
using U0vBVyGFnRQg4TAEWduY;
using UMI2GBGJ3kloSb47d3eV;
using uZqyk925mKGgabaJGJq6;
using vG0WidHawbhpKdkcelf8;
using XF1Tgs90kedR1Bnx4jOX;
using xhulFc2DTsAififEkcHC;
using XsDptMfu1TZDPkNQ2KkJ;

namespace WTy7oTThWE2XBeJ45kI;

internal class z2YK1oTmkqNMjTKd2sG : z6kMSs25KYyGVf55FxBT, IComponentConnector
{
	[CompilerGenerated]
	private sealed class Vgmpp2nXoOPqrB5Wu2Dt
	{
		public h3GPi790NINi0SKF01rq ELInXBJ5uS5;

		public z2YK1oTmkqNMjTKd2sG QZxnXa56OB5;

		private static Vgmpp2nXoOPqrB5Wu2Dt t4clteNBdBuRtMUpBevs;

		public Vgmpp2nXoOPqrB5Wu2Dt()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void ON6nXvOyQRW()
		{
			if (ELInXBJ5uS5.bky901AqCit().UyTfz4sb9ku() == QZxnXa56OB5.zbEykbmXR4 && ELInXBJ5uS5.Data.Count > 0)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				QZxnXa56OB5.gFRTzBQBEQ(ELInXBJ5uS5.Data);
			}
		}

		static Vgmpp2nXoOPqrB5Wu2Dt()
		{
			J1P86JNB6x5eDOcoF1Yg();
		}

		internal static bool qgy7bwNBgdhGvnPwnSx3()
		{
			return t4clteNBdBuRtMUpBevs == null;
		}

		internal static Vgmpp2nXoOPqrB5Wu2Dt B5OThCNBRsxgdvYI3P1f()
		{
			return t4clteNBdBuRtMUpBevs;
		}

		internal static void J1P86JNB6x5eDOcoF1Yg()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private string zbEykbmXR4;

	private Symbol nc3y1O6Cc1;

	private DispatcherTimer ppsy5NWqRj;

	private readonly Queue<EventOwner<TickEvent>> qt3ySgNykf;

	[CompilerGenerated]
	private readonly GNoxT6Cxk6dNaTagNVB KP3yxFSu3y;

	[CompilerGenerated]
	private readonly List<RaMKwNy6MS5NkqnnfuB> xdPyLSSCvf;

	private ICommand zhgyex7kIp;

	private ICommand E0hys8ceev;

	private ICommand q27yXsXDeW;

	private ICommand xhWycriBF8;

	internal PopupButton PopupButtonSymbols;

	internal PopupButton PopupButtonHistory;

	internal ScrollViewer MainScrollViewer;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	internal XweZ7cme4bUexhPLo8B TapeView;

	internal xfJdusmlMIKXdP5g3BA TapeScroll;

	private bool qeryjhqcvr;

	internal static z2YK1oTmkqNMjTKd2sG dEjCvA4DxIpExenO4jGS;

	public GNoxT6Cxk6dNaTagNVB Settings
	{
		[CompilerGenerated]
		get
		{
			return KP3yxFSu3y;
		}
	}

	public List<RaMKwNy6MS5NkqnnfuB> Items
	{
		[CompilerGenerated]
		get
		{
			return xdPyLSSCvf;
		}
	}

	public string SymbolName
	{
		get
		{
			if (nc3y1O6Cc1 == null)
			{
				return "";
			}
			return nc3y1O6Cc1.Name;
		}
	}

	public override int LinkGroup
	{
		get
		{
			return Settings.LinkGroupID.GetValueOrDefault();
		}
		protected set
		{
			Settings.LinkGroupID = value2;
			Symbol symbol = iu52S2PbqF0();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
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
					if (symbol == null)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
						{
							num = 0;
						}
						break;
					}
					SetSymbol(symbol);
					return;
				case 0:
					return;
				}
			}
		}
	}

	public ICommand LoadHistoryCommand => zhgyex7kIp ?? (zhgyex7kIp = new RelayCommand(B8Ayfs3hbV, (object P_0) => nc3y1O6Cc1 != null));

	public ICommand OpenSettingsCommand => E0hys8ceev ?? (E0hys8ceev = new RelayCommand(e6jy9fZDjL));

	public ICommand ShowToolbarCommand => q27yXsXDeW ?? (q27yXsXDeW = new RelayCommand(Y7XynCIOHm));

	public ICommand ClearTapeCommand => xhWycriBF8 ?? (xhWycriBF8 = new RelayCommand(kSNyGmkwDo));

	public z2YK1oTmkqNMjTKd2sG(DockingWindow P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		qt3ySgNykf = new Queue<EventOwner<TickEvent>>();
		base._002Ector(P_0, lOqyZR2xahfYNVbq7H4p.SmartTape);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 7:
				ALkPIb4DXpw8LFLOP8CL(DataGrid, new Action(UjJTF41OIo));
				SymbolManager.SymbolUpdated += DvRTA8AvOS;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num = 0;
				}
				break;
			case 2:
				TapeView.lQsmrrnqJu(zBI2Sjoyuyr());
				num = 5;
				break;
			case 6:
				xdPyLSSCvf = new List<RaMKwNy6MS5NkqnnfuB>();
				InitializeComponent();
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num = 9;
				}
				break;
			case 1:
				base.GotFocus += NHPTwiHagp;
				HrJTuQDoVx();
				Oo0ytU4Djn9Xl6QbMnjI(this);
				return;
			case 4:
				z6kMSs25KYyGVf55FxBT.PXY2S88S5Ph(sL4TPuaJYr);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 1;
				}
				break;
			case 9:
				PpS2SH4LJi3(Settings.vlP2kmioDGU);
				DataGrid.to8HinyXyDi(kop2Sw1sSfc());
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
				{
					num = 2;
				}
				break;
			default:
				b8AkysfukSBAWXjMK6sm.IBcfuKIDIDv(mIkT8IwNSb);
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num = 3;
				}
				break;
			case 5:
				TapeView.kWemhIZUgv(DataGrid);
				TapeView.cv5mc00jwU((f3LRAlrtSOUwGiXtTI7)y2RFQI4DsCuQToxZl6rU(Settings));
				TapeScroll.QuVmkNk31D(TapeView);
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
				{
					num = 4;
				}
				break;
			case 8:
				DataManager.OnTickEvent += IBgT7DKofG;
				elEbCh4Dcpf1CV3xMXwn(new Action(fmcy2eOw1P));
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				KP3yxFSu3y = aJ42S93GFJy<GNoxT6Cxk6dNaTagNVB>(EGk2SmdrsFj()) ?? new GNoxT6Cxk6dNaTagNVB();
				((f3LRAlrtSOUwGiXtTI7)y2RFQI4DsCuQToxZl6rU(Settings)).GeneralSettings.PropertyChanged += MEiT3vqkjw;
				Settings.SmartTapeSettings.AlertsSettings.PropertyChanged += MEiT3vqkjw;
				((f3LRAlrtSOUwGiXtTI7)y2RFQI4DsCuQToxZl6rU(Settings)).A6trZRfgGA();
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
				{
					num = 6;
				}
				break;
			}
		}
	}

	protected override Symbol GetSymbol()
	{
		return nc3y1O6Cc1;
	}

	private void NHPTwiHagp(object P_0, RoutedEventArgs P_1)
	{
		int num;
		if (!(P_1.OriginalSource is ContentControl) && !(rcJBWK4DEX7dcFBjst5y(P_1) is mrGdQof1Dl8Jsg7DRfOq))
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_001b;
		IL_001b:
		TQ525pb1OP3(TapeView.p6ImdZyrIK(), _0020: false, _0020: true);
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 0:
			return;
		}
		if (P_1.OriginalSource is jjKtVJ9pUSOpdg38tqnP || P_1.OriginalSource is DxHwndHost)
		{
			goto IL_001b;
		}
	}

	private void IBgT7DKofG(EventOwner<TickEvent> P_0)
	{
		if (nc3y1O6Cc1 != null && !(nc3y1O6Cc1.ID != P_0.Value.Symbol.ID))
		{
			qt3ySgNykf.Enqueue(P_0);
			P_0.TKjGJzSd8Na();
		}
	}

	private void mIkT8IwNSb(h3GPi790NINi0SKF01rq P_0)
	{
		Vgmpp2nXoOPqrB5Wu2Dt CS_0024_003C_003E8__locals7 = new Vgmpp2nXoOPqrB5Wu2Dt();
		CS_0024_003C_003E8__locals7.ELInXBJ5uS5 = P_0;
		CS_0024_003C_003E8__locals7.QZxnXa56OB5 = this;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ugsqf64DdCvZic8lD4gd(nVwMRT4DQiPFTsDZ7lZx(this), (Action)delegate
		{
			if (CS_0024_003C_003E8__locals7.ELInXBJ5uS5.bky901AqCit().UyTfz4sb9ku() == CS_0024_003C_003E8__locals7.QZxnXa56OB5.zbEykbmXR4 && CS_0024_003C_003E8__locals7.ELInXBJ5uS5.Data.Count > 0)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					CS_0024_003C_003E8__locals7.QZxnXa56OB5.gFRTzBQBEQ(CS_0024_003C_003E8__locals7.ELInXBJ5uS5.Data);
					break;
				}
			}
		});
	}

	private void DvRTA8AvOS(Symbol P_0)
	{
		if (nc3y1O6Cc1 != null && nc3y1O6Cc1.ID == (string)YcFLHj4DgOVZ9V5EaUsN(P_0))
		{
			SetSymbol(P_0, _0020: true);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
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

	private void sL4TPuaJYr(BAEtAp2DUfuBKyaAJXwQ P_0)
	{
		if (P_0.Type == (BlmlL92DciZPrtYF1X4r)9)
		{
			evCTJbMwna();
		}
	}

	private void evCTJbMwna()
	{
		Settings.SmartTapeSettings.A6trZRfgGA();
		qZYICv4DRPYSqW4KvF27(TapeView);
	}

	private void UjJTF41OIo()
	{
		TapeView.DN2mtm0veC();
	}

	private void MEiT3vqkjw(object P_0, PropertyChangedEventArgs P_1)
	{
		TapeView.jdtmjYgcGe();
		TapeView.DN2mtm0veC();
	}

	private void SmartTapeControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (JR62S6js1Bp())
		{
			return;
		}
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29718248));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		rs92SMnpCBe(_0020: true);
		ppsy5NWqRj = new DispatcherTimer(TimeSpan.FromMilliseconds(100.0), DispatcherPriority.Normal, delegate
		{
			CUpyHIYiOf();
		}, (Dispatcher)nVwMRT4DQiPFTsDZ7lZx(this));
	}

	protected override void Dispose(bool P_0)
	{
		if (Vsa2SyQkClw())
		{
			goto IL_00a0;
		}
		DispatcherTimer dispatcherTimer = ppsy5NWqRj;
		if (dispatcherTimer == null)
		{
			goto IL_0104;
		}
		dispatcherTimer.Stop();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 6:
			{
				DataManager.OnTickEvent -= IBgT7DKofG;
				DataManager.OnClearMarket -= fmcy2eOw1P;
				base.GotFocus -= NHPTwiHagp;
				int num2 = 2;
				num = num2;
				continue;
			}
			case 4:
				return;
			case 2:
				break;
			case 1:
				SymbolManager.SymbolUpdated -= DvRTA8AvOS;
				b8AkysfukSBAWXjMK6sm.TFNfumSaQuM(mIkT8IwNSb);
				num = 6;
				continue;
			case 3:
				goto IL_0104;
			case 5:
				DataGrid.J19HixEVRCV(UjJTF41OIo);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num = 0;
				}
				continue;
			default:
				goto IL_01b5;
			}
			break;
		}
		z6kMSs25KYyGVf55FxBT.yDi2SAGZYBD(sL4TPuaJYr);
		TapeView.IgQmZCxNaj();
		goto IL_00a0;
		IL_01b5:
		HZ3dZY4D6LLOkyIA7u31(SubscriptionFlags.Ticks, new Symbol[1] { nc3y1O6Cc1 });
		goto IL_015e;
		IL_0104:
		if (nc3y1O6Cc1 != null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_015e;
		IL_00a0:
		base.Dispose(P_0);
		num = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_015e:
		cdqFUG4DO30c6f1JSk2P(kAdmx54DMP3sp17VIKnT(Settings.SmartTapeSettings), new PropertyChangedEventHandler(MEiT3vqkjw));
		cdqFUG4DO30c6f1JSk2P(BbgD0O4DqYaDqokwn8fn(Settings.SmartTapeSettings), new PropertyChangedEventHandler(MEiT3vqkjw));
		num = 5;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
		{
			num = 3;
		}
		goto IL_0009;
	}

	private void cTHTpIf6uE()
	{
		string text = default(string);
		int num;
		string text2 = default(string);
		if (nc3y1O6Cc1 == null)
		{
			if (!Settings.zDi2k7CwL38)
			{
				PpS2SH4LJi3(Settings.DefaultTitle);
				return;
			}
			text = Settings.vlP2kmioDGU;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
			{
				num = 0;
			}
		}
		else
		{
			text2 = (VkK3Oo4DIgvGqqbgQrGf(Settings) ? Settings.vlP2kmioDGU : ((MhMDPU9v8rkigy1ao0Th)RJhqyE4DW80qRcE6nly7()).pmI9ipSWbX4);
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
			{
				num = 3;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (bFZRo94DtXnIkSWrq4aM(text2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42D8D06B)))
				{
					num = 6;
					break;
				}
				goto case 4;
			case 3:
				if (!bFZRo94DtXnIkSWrq4aM(text2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x809F301)))
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
					{
						num = 7;
					}
					break;
				}
				text2 = (string)GwCuor4DTgdIHu1x3Fsc(text2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583326068), PfC0hQ4DU3xHGeM7Eovh(Settings));
				goto case 7;
			case 7:
				if (text2.Contains(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063347221)))
				{
					text2 = text2.Replace((string)GDZ9Rn4Dyif3ewMTRflC(-1841489831 ^ -1841475187), nc3y1O6Cc1.Name);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 1;
			case 2:
				text = (string)GwCuor4DTgdIHu1x3Fsc(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C30EF), "");
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num = 5;
				}
				break;
			case 6:
				text2 = text2.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB147B0), nc3y1O6Cc1.Exchange);
				num = 4;
				break;
			case 4:
				PpS2SH4LJi3(text2);
				return;
			case 5:
				PpS2SH4LJi3(text);
				return;
			default:
				text = (string)GwCuor4DTgdIHu1x3Fsc(text, GDZ9Rn4Dyif3ewMTRflC(-1801468030 ^ -1801482666), "");
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override void SetCustomTitle(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				efotJc4DZtRt2Osu6TT5(Settings, P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Settings.zDi2k7CwL38 = !string.IsNullOrEmpty(P_0);
				cTHTpIf6uE();
				return;
			}
		}
	}

	protected override void SaveSettings(string P_0, string P_1, int P_2)
	{
		n8S2SGJFdMU(Settings, P_0);
		DataGrid.kUmHi9sIHwh(P_1);
	}

	private void HrJTuQDoVx()
	{
		if (nc3y1O6Cc1 != null)
		{
			return;
		}
		Symbol symbol = SymbolManager.Get(Settings.Qom210PQiuE);
		if (symbol == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				return;
			}
		}
		SetSymbol(symbol);
	}

	public override void SetSymbol(Symbol P_0, bool P_1 = false, bool P_2 = false)
	{
		if (P_0 == null)
		{
			return;
		}
		if (nc3y1O6Cc1 != null)
		{
			goto IL_0033;
		}
		goto IL_0124;
		IL_0009:
		int num;
		while (true)
		{
			switch (num)
			{
			case 2:
				cTHTpIf6uE();
				base.SetSymbol(P_0, P_1, P_2);
				num = 6;
				continue;
			case 1:
				return;
			case 7:
				DataManager.UnSubscribe(SubscriptionFlags.Ticks, nc3y1O6Cc1);
				num = 5;
				continue;
			case 4:
				return;
			case 6:
				return;
			case 5:
				goto IL_01b8;
			case 3:
				FS0OwN4DKBuCMp1vgZVE(TapeView, P_0);
				KEi2Soek3o0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894920910));
				DataManager.Subscribe(SubscriptionFlags.Ticks, nc3y1O6Cc1);
				num = 2;
				continue;
			}
			break;
			IL_01b8:
			if (PiB3K04DVqKSyRN2GUCY(YcFLHj4DgOVZ9V5EaUsN(P_0), YcFLHj4DgOVZ9V5EaUsN(nc3y1O6Cc1)) && P_0.IsDeleted)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_00ab;
		}
		goto IL_0033;
		IL_0124:
		if (nc3y1O6Cc1 != null)
		{
			num = 7;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
			{
				num = 4;
			}
			goto IL_0009;
		}
		goto IL_00ab;
		IL_0033:
		if (!(P_0.ID == nc3y1O6Cc1.ID) || P_1)
		{
			goto IL_0124;
		}
		return;
		IL_00ab:
		nc3y1O6Cc1 = P_0;
		FJ5fPO4DCcmgontaBiac(Settings, YcFLHj4DgOVZ9V5EaUsN(nc3y1O6Cc1));
		K3JClo4DrXqM7FFMewaQ(Settings.SmartTapeSettings, nc3y1O6Cc1.ID);
		num = 3;
		goto IL_0009;
	}

	protected override void SetSwitchMarketStatus(bool P_0)
	{
		base.SetSwitchMarketStatus(_0020: false);
	}

	protected override void OpenSymbolsPopup()
	{
		GS3yYu4DmOVp2G3MjT1L(PopupButtonSymbols, true);
	}

	private void RequestData(int days)
	{
		if (nc3y1O6Cc1 != null)
		{
			zbEykbmXR4 = Guid.NewGuid().ToString();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			DataCycle dataCycle = new DataCycle
			{
				StartDate = TimeHelper.GetCurrDate(nc3y1O6Cc1.Exchange).AddDays(-(days - 1)),
				EndDate = TimeHelper.GetCurrDate(nc3y1O6Cc1.Exchange)
			};
			fZqcIv4DhMBixkccFlPS(zbEykbmXR4, zBI2Sjoyuyr(), GDZ9Rn4Dyif3ewMTRflC(-1416986301 ^ -1416967003), nc3y1O6Cc1, dataCycle, 1);
		}
	}

	public void gFRTzBQBEQ(ICollection<byte[]> P_0)
	{
		List<MkBOssmnh52O7dtV8L1> list = new List<MkBOssmnh52O7dtV8L1>();
		foreach (byte[] item in P_0)
		{
			if (!Settings.SmartTapeSettings.GeneralSettings.AggregateTicks)
			{
				long num = 0L;
				TicksReader ticksReader = new TicksReader(nc3y1O6Cc1, item, nc3y1O6Cc1.Step, nc3y1O6Cc1.SizeStep, TimeSpan.Zero, nc3y1O6Cc1.Type == SymbolType.Forex);
				while (ticksReader.Read())
				{
					TickEvent lastItem = ticksReader.LastItem;
					if (lastItem != null)
					{
						long yTZmaRQPnD = lastItem.OpenInterest - num;
						num = lastItem.OpenInterest;
						list.Add(new MkBOssmnh52O7dtV8L1
						{
							Time = lastItem.Time,
							B7Tmo1HnRA = lastItem.Price,
							Size = lastItem.Size,
							Bid = lastItem.Bid,
							Ask = lastItem.Ask,
							UGTmvvUvFE = lastItem.Side,
							yTZmaRQPnD = yTZmaRQPnD,
							OpenInt = lastItem.OpenInterest,
							JfNmBlpHwm = JvnU7mKyhAsjhMnNsh5.D7sKVWhwBp(lastItem.MarketCenter)
						});
					}
				}
				continue;
			}
			long num2 = 0L;
			MkBOssmnh52O7dtV8L1 mkBOssmnh52O7dtV8L = null;
			TicksReader ticksReader2 = new TicksReader(nc3y1O6Cc1, item, nc3y1O6Cc1.Step, nc3y1O6Cc1.SizeStep, TimeSpan.Zero, nc3y1O6Cc1.Type == SymbolType.Forex);
			while (ticksReader2.Read())
			{
				TickEvent lastItem2 = ticksReader2.LastItem;
				if (lastItem2 != null)
				{
					long num3 = lastItem2.OpenInterest - num2;
					num2 = lastItem2.OpenInterest;
					if (mkBOssmnh52O7dtV8L == null)
					{
						mkBOssmnh52O7dtV8L = new MkBOssmnh52O7dtV8L1
						{
							Time = lastItem2.Time,
							B7Tmo1HnRA = lastItem2.Price,
							Size = lastItem2.Size,
							Bid = lastItem2.Bid,
							Ask = lastItem2.Ask,
							Trades = 1L,
							UGTmvvUvFE = lastItem2.Side,
							yTZmaRQPnD = num3,
							OpenInt = lastItem2.OpenInterest,
							JfNmBlpHwm = JvnU7mKyhAsjhMnNsh5.D7sKVWhwBp(lastItem2.MarketCenter)
						};
					}
					else if (mkBOssmnh52O7dtV8L.Time == lastItem2.Time && mkBOssmnh52O7dtV8L.UGTmvvUvFE == lastItem2.Side)
					{
						mkBOssmnh52O7dtV8L.Size += lastItem2.Size;
						mkBOssmnh52O7dtV8L.Trades++;
						mkBOssmnh52O7dtV8L.yTZmaRQPnD += num3;
						mkBOssmnh52O7dtV8L.OpenInt = lastItem2.OpenInterest;
					}
					else
					{
						list.Add(mkBOssmnh52O7dtV8L);
						mkBOssmnh52O7dtV8L = new MkBOssmnh52O7dtV8L1
						{
							Time = lastItem2.Time,
							B7Tmo1HnRA = lastItem2.Price,
							Size = lastItem2.Size,
							Bid = lastItem2.Bid,
							Ask = lastItem2.Ask,
							Trades = 1L,
							UGTmvvUvFE = lastItem2.Side,
							yTZmaRQPnD = num3,
							OpenInt = lastItem2.OpenInterest,
							JfNmBlpHwm = JvnU7mKyhAsjhMnNsh5.D7sKVWhwBp(lastItem2.MarketCenter)
						};
					}
				}
			}
			if (mkBOssmnh52O7dtV8L != null)
			{
				list.Add(mkBOssmnh52O7dtV8L);
			}
		}
		TapeView.Jj8mQbnmRU(list);
	}

	private void FYXy0CMfCJ(TicksResponseEvent P_0)
	{
		if (PKJViv4DwjZcy3N5WIcE(P_0.Request.RequestID, zbEykbmXR4))
		{
			return;
		}
		IDataReader<TickEvent> reader = P_0.Reader;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				if (reader.LastItem != null)
				{
					EventOwner<TickEvent> eventOwner = IlvHiXGF9pA6U4gUK5bq.JoWGFYLGguA();
					eventOwner.k1pGJpywlFB(reader.LastItem);
					qt3ySgNykf.Enqueue(eventOwner);
					eventOwner.TKjGJzSd8Na();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
					{
						num = 0;
					}
					break;
				}
				goto default;
			default:
				if (!reader.Read())
				{
					num = 3;
					break;
				}
				goto case 2;
			case 3:
				return;
			}
		}
	}

	private void fmcy2eOw1P()
	{
		TapeView.Clear();
	}

	private void CUpyHIYiOf()
	{
		bool flag = false;
		EventOwner<TickEvent> eventOwner = default(EventOwner<TickEvent>);
		TickEvent value = default(TickEvent);
		while (true)
		{
			int num;
			if (Vu2sm14DAeLFfgMTOhLp(qt3ySgNykf) <= 0)
			{
				num = 5;
			}
			else
			{
				eventOwner = qt3ySgNykf.Dequeue();
				value = eventOwner.Value;
				num = 2;
			}
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (nc3y1O6Cc1 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_012b;
				case 4:
					break;
				case 5:
					if (flag)
					{
						TapeView.DN2mtm0veC();
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					TapeView.zJnmXteSEI();
					return;
				case 1:
					if (!((string)YcFLHj4DgOVZ9V5EaUsN(nc3y1O6Cc1) != (string)YcFLHj4DgOVZ9V5EaUsN(oGmny14D75gGKxSlGmov(value))))
					{
						TapeView.dkMmE8eXnr(value);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_012b;
				default:
					eventOwner.Uw7GF03Qn6r();
					flag = true;
					break;
				case 3:
					return;
					IL_012b:
					qMNr9P4D8shewEysqBCd(eventOwner);
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	private void SymbolSearchControl_SymbolSelected(Symbol symbol)
	{
		GS3yYu4DmOVp2G3MjT1L(PopupButtonSymbols, false);
		TQ525pb1OP3(symbol);
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		SsS253ZUwy8(groupID);
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		DependencyObject dependencyObject = (DependencyObject)e.OriginalSource;
		while (true)
		{
			if (dependencyObject == null || dependencyObject is DataGridCell)
			{
				goto IL_0043;
			}
			goto IL_00d5;
			IL_0009:
			int num;
			switch (num)
			{
			case 2:
				return;
			case 3:
				break;
			case 1:
				goto IL_007f;
			default:
				goto IL_00d5;
			}
			goto IL_0043;
			IL_0043:
			if (!(dependencyObject is DataGridColumnHeadersPresenter))
			{
				break;
			}
			YtVdgr4DP0LW2vJYb1R9(DataGrid);
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
			{
				num = 0;
			}
			goto IL_0009;
			IL_00d5:
			if (!(dependencyObject is DataGridColumnHeadersPresenter))
			{
				goto IL_007f;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
			{
				num = 3;
			}
			goto IL_0009;
			IL_007f:
			dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
		}
	}

	private void DataGrid_OnAutoGeneratedColumns(object sender, EventArgs e)
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
				if (DataGrid.ColumnInfo == null)
				{
					IEnumerator<DataGridColumn> enumerator = DataGrid.Columns.GetEnumerator();
					try
					{
						while (w7DOuZ4Dp4uZqbQasiHL(enumerator))
						{
							while (true)
							{
								DataGridColumn current = enumerator.Current;
								string text = (string)CaDflw4DJMdiwNdpGrQp(current);
								int num3 = 6;
								while (true)
								{
									switch (num3)
									{
									case 2:
									case 5:
										current.Width = 80.0;
										num3 = 2;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
										{
											num3 = 4;
										}
										continue;
									case 7:
										break;
									case 1:
										if (PiB3K04DVqKSyRN2GUCY(text, GDZ9Rn4Dyif3ewMTRflC(-203064540 ^ -203082024)))
										{
											int num4 = 2;
											num3 = num4;
											continue;
										}
										goto default;
									case 4:
										goto end_IL_00dd;
									case 6:
										if (!PiB3K04DVqKSyRN2GUCY(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490995228)))
										{
											if (text == (string)GDZ9Rn4Dyif3ewMTRflC(0x315AB1E3 ^ 0x315AAE83))
											{
												goto case 2;
											}
											goto case 1;
										}
										goto case 8;
									case 8:
										ipER0W4DFaNClgR95IBq(current, 90.0);
										goto end_IL_00dd;
									case 3:
										if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F647096)))
										{
											ipER0W4DFaNClgR95IBq(current, w8ZWxk4D3ZxTRcSRtrHo(70.0));
											goto end_IL_00dd;
										}
										goto IL_01fb;
									default:
										{
											if (text == (string)GDZ9Rn4Dyif3ewMTRflC(-1127423276 ^ -1127437094))
											{
												goto case 2;
											}
											if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D18B642))
											{
												goto IL_01fb;
											}
											goto case 3;
										}
										IL_01fb:
										current.Width = 25.0;
										goto end_IL_00dd;
									}
									break;
								}
								continue;
								end_IL_00dd:
								break;
							}
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							t8PHcD4DuHHjfKtepuGI(enumerator);
						}
					}
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void B8Ayfs3hbV(object P_0)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = ckgjKh4DzBJW9sOs8kgI((string)P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 > 0)
				{
					RequestData(num3);
				}
				return;
			}
		}
	}

	private void e6jy9fZDjL(object P_0)
	{
		rDyCVQ4b0FxrWAMagU6U(base.ParentWindow, Settings.SmartTapeSettings);
	}

	private void Y7XynCIOHm(object P_0)
	{
		Settings.ShowToolBar = !Settings.ShowToolBar;
	}

	private void kSNyGmkwDo(object P_0)
	{
		TapeView.Clear();
	}

	private void GKJyYBsyhm(object P_0, ScrollChangedEventArgs P_1)
	{
		TapeView.DN2mtm0veC();
	}

	private void J6syoMENms(object P_0, RoutedEventArgs P_1)
	{
		if (!string.IsNullOrEmpty(SymbolName))
		{
			Clipboard.SetText(SymbolName);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
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
			{
				if (qeryjhqcvr)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 0;
					}
					break;
				}
				qeryjhqcvr = true;
				Uri resourceLocator = new Uri((string)GDZ9Rn4Dyif3ewMTRflC(-838841832 ^ -838859722), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)Vutpbh4b2N5dsKefWuBw(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 7:
			TapeScroll = (xfJdusmlMIKXdP5g3BA)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			PopupButtonSymbols = (PopupButton)P_1;
			break;
		case 2:
			PopupButtonHistory = (PopupButton)P_1;
			break;
		default:
			qeryjhqcvr = true;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
			{
				num = 3;
			}
			goto IL_0009;
		case 4:
			DataGrid = (u0GAIHHahyHxCr1XJKud)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 6:
			((MenuItem)P_1).Click += J6syoMENms;
			break;
		case 5:
			TapeView = (XweZ7cme4bUexhPLo8B)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
			{
				num = 2;
			}
			goto IL_0009;
		case 3:
			{
				MainScrollViewer = (ScrollViewer)P_1;
				iyNJ3C4bHIcXHlpVWXN8(MainScrollViewer, new ScrollChangedEventHandler(GKJyYBsyhm));
				break;
			}
			IL_0009:
			switch (num)
			{
			case 0:
				break;
			case 2:
				break;
			case 1:
				break;
			case 3:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private void HdNyvfELFu(object P_0, EventArgs P_1)
	{
		CUpyHIYiOf();
	}

	[CompilerGenerated]
	private bool rIRyBY2Dmp(object P_0)
	{
		return nc3y1O6Cc1 != null;
	}

	static z2YK1oTmkqNMjTKd2sG()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool qIS9ny4DLtxKkj5fS8Xr()
	{
		return dEjCvA4DxIpExenO4jGS == null;
	}

	internal static z2YK1oTmkqNMjTKd2sG aoewQc4DeaqVHlJbL64R()
	{
		return dEjCvA4DxIpExenO4jGS;
	}

	internal static object y2RFQI4DsCuQToxZl6rU(object P_0)
	{
		return ((GNoxT6Cxk6dNaTagNVB)P_0).SmartTapeSettings;
	}

	internal static void ALkPIb4DXpw8LFLOP8CL(object P_0, object P_1)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).xN4HiSsTrjJ((Action)P_1);
	}

	internal static void elEbCh4Dcpf1CV3xMXwn(object P_0)
	{
		DataManager.OnClearMarket += (Action)P_0;
	}

	internal static void Oo0ytU4Djn9Xl6QbMnjI(object P_0)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).InitLink();
	}

	internal static object rcJBWK4DEX7dcFBjst5y(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static object nVwMRT4DQiPFTsDZ7lZx(object P_0)
	{
		return ((DispatcherObject)P_0).Dispatcher;
	}

	internal static object ugsqf64DdCvZic8lD4gd(object P_0, object P_1)
	{
		return ((Dispatcher)P_0).InvokeAsync((Action)P_1);
	}

	internal static object YcFLHj4DgOVZ9V5EaUsN(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void qZYICv4DRPYSqW4KvF27(object P_0)
	{
		((XweZ7cme4bUexhPLo8B)P_0).DN2mtm0veC();
	}

	internal static void HZ3dZY4D6LLOkyIA7u31(SubscriptionFlags P_0, object P_1)
	{
		DataManager.UnSubscribe(P_0, (Symbol[])P_1);
	}

	internal static object kAdmx54DMP3sp17VIKnT(object P_0)
	{
		return ((f3LRAlrtSOUwGiXtTI7)P_0).GeneralSettings;
	}

	internal static void cdqFUG4DO30c6f1JSk2P(object P_0, object P_1)
	{
		((zImfxTKY16LCm1N4HBE)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	internal static object BbgD0O4DqYaDqokwn8fn(object P_0)
	{
		return ((f3LRAlrtSOUwGiXtTI7)P_0).AlertsSettings;
	}

	internal static bool VkK3Oo4DIgvGqqbgQrGf(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).zDi2k7CwL38;
	}

	internal static object RJhqyE4DW80qRcE6nly7()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool bFZRo94DtXnIkSWrq4aM(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object PfC0hQ4DU3xHGeM7Eovh(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).DefaultTitle;
	}

	internal static object GwCuor4DTgdIHu1x3Fsc(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object GDZ9Rn4Dyif3ewMTRflC(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void efotJc4DZtRt2Osu6TT5(object P_0, object P_1)
	{
		((KqZtUj2kTEAQfYBkeSKy)P_0).vlP2kmioDGU = (string)P_1;
	}

	internal static bool PiB3K04DVqKSyRN2GUCY(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void FJ5fPO4DCcmgontaBiac(object P_0, object P_1)
	{
		((KqZtUj2kTEAQfYBkeSKy)P_0).Qom210PQiuE = (string)P_1;
	}

	internal static void K3JClo4DrXqM7FFMewaQ(object P_0, object P_1)
	{
		((f3LRAlrtSOUwGiXtTI7)P_0).XTfrTRvU8v((string)P_1);
	}

	internal static void FS0OwN4DKBuCMp1vgZVE(object P_0, object P_1)
	{
		((XweZ7cme4bUexhPLo8B)P_0).kgrmgEonhE((Symbol)P_1);
	}

	internal static void GS3yYu4DmOVp2G3MjT1L(object P_0, bool P_1)
	{
		((PopupButton)P_0).IsPopupOpen = P_1;
	}

	internal static void fZqcIv4DhMBixkccFlPS(object P_0, object P_1, object P_2, object P_3, object P_4, int P_5)
	{
		b8AkysfukSBAWXjMK6sm.BrHfuWeREBg((string)P_0, (string)P_1, (string)P_2, (Symbol)P_3, (DataCycle)P_4, P_5);
	}

	internal static bool PKJViv4DwjZcy3N5WIcE(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object oGmny14D75gGKxSlGmov(object P_0)
	{
		return ((anI4lfGJ8TTwhTlujQ36)P_0).Symbol;
	}

	internal static void qMNr9P4D8shewEysqBCd(object P_0)
	{
		((EventOwner<TickEvent>)P_0).Uw7GF03Qn6r();
	}

	internal static int Vu2sm14DAeLFfgMTOhLp(object P_0)
	{
		return ((Queue<EventOwner<TickEvent>>)P_0).Count;
	}

	internal static void YtVdgr4DP0LW2vJYb1R9(object P_0)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).rWAHi2QjAqn();
	}

	internal static object CaDflw4DJMdiwNdpGrQp(object P_0)
	{
		return ((DataGridColumn)P_0).SortMemberPath;
	}

	internal static void ipER0W4DFaNClgR95IBq(object P_0, DataGridLength P_1)
	{
		((DataGridColumn)P_0).Width = P_1;
	}

	internal static DataGridLength w8ZWxk4D3ZxTRcSRtrHo(double P_0)
	{
		return P_0;
	}

	internal static bool w7DOuZ4Dp4uZqbQasiHL(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void t8PHcD4DuHHjfKtepuGI(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int ckgjKh4DzBJW9sOs8kgI(object P_0)
	{
		return Convert.ToInt32((string)P_0);
	}

	internal static void rDyCVQ4b0FxrWAMagU6U(object P_0, object P_1)
	{
		PYVXUVZbIW94VI2qFWh.JxrZew1GoF((Window)P_0, (f3LRAlrtSOUwGiXtTI7)P_1);
	}

	internal static object Vutpbh4b2N5dsKefWuBw(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void iyNJ3C4bHIcXHlpVWXN8(object P_0, object P_1)
	{
		((ScrollViewer)P_0).ScrollChanged += (ScrollChangedEventHandler)P_1;
	}
}
