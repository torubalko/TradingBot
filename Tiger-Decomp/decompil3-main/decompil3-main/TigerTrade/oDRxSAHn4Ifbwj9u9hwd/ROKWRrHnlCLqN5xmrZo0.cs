using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using inUerCfHMLVDbG9HvwwZ;
using TigerTrade.Core.UI.Commands;
using TigerTrade.UI.Controls.LotSelect;
using TigerTrade.UI.DocControls.Trading.Settings;
using tk8EGrHlm26y65VZoXup;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace oDRxSAHn4Ifbwj9u9hwd;

internal class ROKWRrHnlCLqN5xmrZo0 : UserControl, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct sFc3Y6ntLSm6CcUCF2Cl : IAsyncStateMachine
	{
		public int LA7nteOuUOx;

		public AsyncVoidMethodBuilder WcXntsfLmRQ;

		public ROKWRrHnlCLqN5xmrZo0 hd7ntXonesA;

		private YieldAwaitable.YieldAwaiter eVCntcMdI9W;

		private static object AU2pjJNSlMEj3BSXKyqB;

		private void MoveNext()
		{
			int num = LA7nteOuUOx;
			ROKWRrHnlCLqN5xmrZo0 rOKWRrHnlCLqN5xmrZo = hd7ntXonesA;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
			{
				num2 = 0;
			}
			YieldAwaitable.YieldAwaiter awaiter = default(YieldAwaitable.YieldAwaiter);
			YieldAwaitable yieldAwaitable = default(YieldAwaitable);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				try
				{
					int num3;
					if (num != 0)
					{
						num3 = 2;
						goto IL_0031;
					}
					goto IL_012f;
					IL_012f:
					awaiter = eVCntcMdI9W;
					num3 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num3 = 7;
					}
					goto IL_0031;
					IL_0031:
					while (true)
					{
						switch (num3)
						{
						case 4:
							num = (LA7nteOuUOx = 0);
							eVCntcMdI9W = awaiter;
							num3 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
							{
								num3 = 1;
							}
							continue;
						case 6:
							goto end_IL_0031;
						default:
							awaiter.GetResult();
							rOKWRrHnlCLqN5xmrZo.rSuHncCBT0a();
							goto end_IL_0031;
						case 7:
							eVCntcMdI9W = default(YieldAwaitable.YieldAwaiter);
							num = (LA7nteOuUOx = -1);
							goto default;
						case 5:
							break;
						case 3:
							WcXntsfLmRQ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 2:
							if (rOKWRrHnlCLqN5xmrZo.GwOHnwVVueT.WindowState != WindowState.Minimized)
							{
								rOKWRrHnlCLqN5xmrZo.MainPopup.IsOpen = rOKWRrHnlCLqN5xmrZo.At2HnQ9dFmL();
								yieldAwaitable = Task.Yield();
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
								{
									num3 = 1;
								}
							}
							else
							{
								rOKWRrHnlCLqN5xmrZo.MainPopup.IsOpen = false;
								num3 = 5;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
								{
									num3 = 6;
								}
							}
							continue;
						case 1:
							awaiter = yieldAwaitable.GetAwaiter();
							if (awaiter.IsCompleted)
							{
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 4;
						}
						goto IL_012f;
						continue;
						end_IL_0031:
						break;
					}
				}
				catch (Exception exception)
				{
					LA7nteOuUOx = -2;
					WcXntsfLmRQ.SetException(exception);
					int num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
					return;
				}
				LA7nteOuUOx = -2;
				WcXntsfLmRQ.SetResult();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
				{
					num2 = 1;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			WcXntsfLmRQ.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static sFc3Y6ntLSm6CcUCF2Cl()
		{
			Q6K7LBNSbw3iXOpCfJOj();
		}

		internal static bool MXUi0vNS4DwTIy5qv23s()
		{
			return AU2pjJNSlMEj3BSXKyqB == null;
		}

		internal static object J9PD5ANSDJAM6wmbIZII()
		{
			return AU2pjJNSlMEj3BSXKyqB;
		}

		internal static void Q6K7LBNSbw3iXOpCfJOj()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private Window GwOHnwVVueT;

	public static readonly DependencyProperty YQaHn7pphlR;

	public static readonly DependencyProperty AYxHn8EauHP;

	public static readonly DependencyProperty HvvHnAmlq9W;

	public static readonly DependencyProperty uQjHnP4Cohy;

	public static readonly DependencyProperty RyFHnJoyWPt;

	public static readonly DependencyProperty jf5HnFgjkFq;

	public static readonly DependencyProperty A46Hn3f0s7e;

	public static readonly DependencyProperty qN8HnpGupqm;

	public static readonly DependencyProperty FuOHnu72tE2;

	[CompilerGenerated]
	private readonly ICommand QJtHnzW2jDM;

	internal ROKWRrHnlCLqN5xmrZo0 LotWidget;

	internal gSmKLKHlKEbExOB8YsSe MainPopup;

	internal Grid EditView;

	internal LotSelectControl LotSelectControl;

	private bool s39HG0nPPCD;

	private static ROKWRrHnlCLqN5xmrZo0 buOwHNDDIS1CRWHq4ZgK;

	public bool IsTopmost
	{
		get
		{
			return (bool)m22jOvDDVNYFCtanwNYy(this, YQaHn7pphlR);
		}
		set
		{
			YtpHikDDCU6tUWFYsIsw(this, YQaHn7pphlR, flag);
		}
	}

	public TradingSettings TradingSettings
	{
		get
		{
			return (TradingSettings)GetValue(AYxHn8EauHP);
		}
		set
		{
			SetValue(AYxHn8EauHP, value2);
		}
	}

	public bool IsOpen
	{
		get
		{
			return (bool)GetValue(HvvHnAmlq9W);
		}
		set
		{
			SetValue(HvvHnAmlq9W, flag);
		}
	}

	public double LeftOffset
	{
		get
		{
			return (double)m22jOvDDVNYFCtanwNYy(this, uQjHnP4Cohy);
		}
		set
		{
			SetValue(uQjHnP4Cohy, num);
		}
	}

	public bool IsLotsInDOMShowed
	{
		get
		{
			return (bool)GetValue(jf5HnFgjkFq);
		}
		set
		{
			YtpHikDDCU6tUWFYsIsw(this, jf5HnFgjkFq, flag);
		}
	}

	public double AvailableHeight
	{
		get
		{
			return (double)GetValue(RyFHnJoyWPt);
		}
		set
		{
			SetValue(RyFHnJoyWPt, num);
		}
	}

	public string SymbolName
	{
		get
		{
			return (string)m22jOvDDVNYFCtanwNYy(this, A46Hn3f0s7e);
		}
		set
		{
			SetValue(A46Hn3f0s7e, value2);
		}
	}

	public string Title
	{
		get
		{
			return (string)GetValue(qN8HnpGupqm);
		}
		private set
		{
			YtpHikDDCU6tUWFYsIsw(this, qN8HnpGupqm, text);
		}
	}

	public ICommand EditViewOpenCommand
	{
		get
		{
			return (ICommand)GetValue(FuOHnu72tE2);
		}
		set
		{
			YtpHikDDCU6tUWFYsIsw(this, FuOHnu72tE2, command);
		}
	}

	public ICommand CloseEditViewCommand
	{
		[CompilerGenerated]
		get
		{
			return QJtHnzW2jDM;
		}
	}

	[SpecialName]
	private bool At2HnQ9dFmL()
	{
		if (tJ7tPfDDUJxPirfR42pk(this))
		{
			return IsOpen;
		}
		return false;
	}

	public ROKWRrHnlCLqN5xmrZo0()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		CQ8upPDDTwA9A4U1TycA(this, new RoutedEventHandler(Vv2HnSfftIT));
		base.Unloaded += iy5HnxWBOGB;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				QJtHnzW2jDM = new RelayCommand(ID1Hnjb8Bxb);
				InitializeComponent();
				t5455lDDZ1usF1oKSvYp(MainPopup, new EventHandler(IPrHn5Qqtyh));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				wHt4rYDDyPMZp7jbG4It(this, new DependencyPropertyChangedEventHandler(hBMHnLY9VxT));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void fGVHnDlaOUB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		ROKWRrHnlCLqN5xmrZo0 rOKWRrHnlCLqN5xmrZo = default(ROKWRrHnlCLqN5xmrZo0);
		while (true)
		{
			switch (num2)
			{
			default:
				if (rOKWRrHnlCLqN5xmrZo != null)
				{
					pmhl5cDDryELieZFCQ12(rOKWRrHnlCLqN5xmrZo);
				}
				return;
			case 1:
				rOKWRrHnlCLqN5xmrZo = P_0 as ROKWRrHnlCLqN5xmrZo0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void g7nHnbpYRjl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is ROKWRrHnlCLqN5xmrZo0 rOKWRrHnlCLqN5xmrZo))
		{
			return;
		}
		object newValue = P_1.NewValue;
		int num = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
		{
			num = 3;
		}
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (newValue is bool)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
					{
						num = 0;
					}
					break;
				}
				return;
			case 1:
				return;
			case 2:
				bRQvcpDDKFq0sgR0Ydid(rOKWRrHnlCLqN5xmrZo.TradingSettings, flag);
				if (!flag)
				{
					gbuEe4DDmprVrH7cRGAx(rOKWRrHnlCLqN5xmrZo.TradingSettings, false);
				}
				return;
			default:
			{
				flag = (bool)newValue;
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	private static void DJxHnNhhAc8(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		ROKWRrHnlCLqN5xmrZo0 rOKWRrHnlCLqN5xmrZo = default(ROKWRrHnlCLqN5xmrZo0);
		bool flag = default(bool);
		object newValue = default(object);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!rOKWRrHnlCLqN5xmrZo.IsLoaded || !rOKWRrHnlCLqN5xmrZo.IsVisible)
				{
					return;
				}
				lFtS5SDDwafIGSe4Syyy(rOKWRrHnlCLqN5xmrZo, ((TradingSettings)EZljPZDDhpMIjZvn8CTb(rOKWRrHnlCLqN5xmrZo)).IsLotsInDOMShowed);
				To9G1LDD7WD8UdSJJuCJ(rOKWRrHnlCLqN5xmrZo.MainPopup, flag);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				rOKWRrHnlCLqN5xmrZo = P_0 as ROKWRrHnlCLqN5xmrZo0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (rOKWRrHnlCLqN5xmrZo == null)
				{
					return;
				}
				newValue = P_1.NewValue;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (!(newValue is bool))
				{
					return;
				}
				flag = (bool)newValue;
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	private static void KoGHnkd2I44(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is ROKWRrHnlCLqN5xmrZo0 rOKWRrHnlCLqN5xmrZo)
		{
			rOKWRrHnlCLqN5xmrZo.MainPopup.HorizontalOffset = rOKWRrHnlCLqN5xmrZo.LeftOffset;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			rOKWRrHnlCLqN5xmrZo.rSuHncCBT0a();
		}
	}

	private static void fmsHn1lidEe(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is ROKWRrHnlCLqN5xmrZo0 rOKWRrHnlCLqN5xmrZo)
		{
			pMKTPDDD8YJ4cYa4Bd8I(rOKWRrHnlCLqN5xmrZo, string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F0C74D), P_1.NewValue));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
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

	private void IPrHn5Qqtyh(object P_0, EventArgs P_1)
	{
		TradingSettings.IsExtendedLotsInDOMShowed = false;
	}

	private void Vv2HnSfftIT(object P_0, RoutedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				GwOHnwVVueT = Window.GetWindow(this);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (GwOHnwVVueT == null)
				{
					return;
				}
				MJJMtIDDAGs0YeCoSSmb(GwOHnwVVueT, new SizeChangedEventHandler(bc8HnXqrhkU));
				GwOHnwVVueT.StateChanged += OVuHneQ8VeO;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 0;
				}
				break;
			default:
				GwOHnwVVueT.LocationChanged += YKjHnspTvp4;
				MainPopup.IsOpen = At2HnQ9dFmL();
				rSuHncCBT0a();
				return;
			case 1:
				return;
			}
		}
	}

	private void iy5HnxWBOGB(object P_0, RoutedEventArgs P_1)
	{
		if (GwOHnwVVueT != null)
		{
			WM2dsMDDPFdafoS8CwOF(GwOHnwVVueT, new SizeChangedEventHandler(bc8HnXqrhkU));
			GwOHnwVVueT.StateChanged -= OVuHneQ8VeO;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			GwOHnwVVueT.LocationChanged -= YKjHnspTvp4;
		}
	}

	private void hBMHnLY9VxT(object P_0, DependencyPropertyChangedEventArgs P_1)
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
				if (base.IsVisible)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				MainPopup.IsOpen = false;
				return;
			default:
				MainPopup.IsOpen = At2HnQ9dFmL();
				rSuHncCBT0a();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(sFc3Y6ntLSm6CcUCF2Cl))]
	private void OVuHneQ8VeO(object P_0, EventArgs P_1)
	{
		sFc3Y6ntLSm6CcUCF2Cl stateMachine = default(sFc3Y6ntLSm6CcUCF2Cl);
		stateMachine.WcXntsfLmRQ = AsyncVoidMethodBuilder.Create();
		stateMachine.hd7ntXonesA = this;
		stateMachine.LA7nteOuUOx = -1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		stateMachine.WcXntsfLmRQ.Start(ref stateMachine);
	}

	private void YKjHnspTvp4(object P_0, EventArgs P_1)
	{
		rSuHncCBT0a();
	}

	private void bc8HnXqrhkU(object P_0, SizeChangedEventArgs P_1)
	{
		rSuHncCBT0a();
	}

	public void rSuHncCBT0a()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			double num3;
			switch (num2)
			{
			case 1:
			{
				FrameworkElement obj = MainPopup.Child as FrameworkElement;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = rTAFD2DDJSDSQ4m2qKNp(obj);
				break;
			}
			case 2:
				return;
			default:
				num3 = 0.0;
				break;
			}
			double num4 = num3;
			if (!(AvailableHeight < num4 + base.Margin.Bottom))
			{
				break;
			}
			To9G1LDD7WD8UdSJJuCJ(MainPopup, false);
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
			{
				num2 = 2;
			}
		}
		MainPopup.HorizontalOffset += 1.0;
		MainPopup.HorizontalOffset -= 1.0;
	}

	private void ID1Hnjb8Bxb(object P_0)
	{
		IsOpen = false;
	}

	private void qfnHnEV3uV7(object P_0, KeyEventArgs P_1)
	{
		if (vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().AdjPresetSizeViaScroll.Check(P_1))
		{
			P_1.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
				if (s39HG0nPPCD)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				s39HG0nPPCD = true;
				Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763960637), UriKind.Relative);
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
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
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
			case 3:
				return;
			case 2:
				switch (P_0)
				{
				case 3:
					lCmHtXDDFp5aPoNX3P46((Border)P_1, new KeyEventHandler(qfnHnEV3uV7));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					LotWidget = (ROKWRrHnlCLqN5xmrZo0)P_1;
					return;
				case 4:
					EditView = (Grid)P_1;
					return;
				default:
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					LotSelectControl = (LotSelectControl)P_1;
					return;
				case 2:
					MainPopup = (gSmKLKHlKEbExOB8YsSe)P_1;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				break;
			case 1:
				s39HG0nPPCD = true;
				return;
			}
		}
	}

	static ROKWRrHnlCLqN5xmrZo0()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		nr1BH7DD3wpKTpQr9tM6();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				YQaHn7pphlR = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB15BF72), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)), new FrameworkPropertyMetadata(false));
				AYxHn8EauHP = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746FDB7B), Type.GetTypeFromHandle(hR9U9gDDuIwBJykxtA9i(33554921)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)));
				HvvHnAmlq9W = (DependencyProperty)K9bcaMDDzpPEIl8TDHMi(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710531082), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)), new PropertyMetadata(false, DJxHnNhhAc8));
				uQjHnP4Cohy = DependencyProperty.Register((string)fSVRfDDb0sOcPNLNB9gX(0x6E2DFBED ^ 0x6E2CF44D), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)), new PropertyMetadata(0.0, KoGHnkd2I44));
				RyFHnJoyWPt = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28AB272), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(hR9U9gDDuIwBJykxtA9i(33555233)), new PropertyMetadata(double.PositiveInfinity, fGVHnDlaOUB));
				jf5HnFgjkFq = (DependencyProperty)K9bcaMDDzpPEIl8TDHMi(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962492061), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)), new PropertyMetadata(true, g7nHnbpYRjl));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				FuOHnu72tE2 = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90239776), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777377)), PKovwPDDpUkhSP69sbgV(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)));
				return;
			case 1:
				qN8HnpGupqm = (DependencyProperty)bAMHIlDb2r6RoeSmKGIS(fSVRfDDb0sOcPNLNB9gX(-837284864 ^ -837268066), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555233)));
				num = 3;
				break;
			default:
				A46Hn3f0s7e = (DependencyProperty)K9bcaMDDzpPEIl8TDHMi(fSVRfDDb0sOcPNLNB9gX(-1461949456 ^ -1461968402), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(hR9U9gDDuIwBJykxtA9i(33555233)), new PropertyMetadata(string.Empty, fmsHn1lidEe));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static bool tJ7tPfDDUJxPirfR42pk(object P_0)
	{
		return ((UIElement)P_0).IsVisible;
	}

	internal static bool lR8w6GDDW7wQPbHVSavg()
	{
		return buOwHNDDIS1CRWHq4ZgK == null;
	}

	internal static ROKWRrHnlCLqN5xmrZo0 GWe0tNDDtt59x7M4TwZF()
	{
		return buOwHNDDIS1CRWHq4ZgK;
	}

	internal static void CQ8upPDDTwA9A4U1TycA(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void wHt4rYDDyPMZp7jbG4It(object P_0, object P_1)
	{
		((UIElement)P_0).IsVisibleChanged += (DependencyPropertyChangedEventHandler)P_1;
	}

	internal static void t5455lDDZ1usF1oKSvYp(object P_0, object P_1)
	{
		((Popup)P_0).Closed += (EventHandler)P_1;
	}

	internal static object m22jOvDDVNYFCtanwNYy(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void YtpHikDDCU6tUWFYsIsw(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void pmhl5cDDryELieZFCQ12(object P_0)
	{
		((ROKWRrHnlCLqN5xmrZo0)P_0).rSuHncCBT0a();
	}

	internal static void bRQvcpDDKFq0sgR0Ydid(object P_0, bool P_1)
	{
		((TradingSettings)P_0).IsLotsInDOMShowed = P_1;
	}

	internal static void gbuEe4DDmprVrH7cRGAx(object P_0, bool P_1)
	{
		((TradingSettings)P_0).IsExtendedLotsInDOMShowed = P_1;
	}

	internal static object EZljPZDDhpMIjZvn8CTb(object P_0)
	{
		return ((ROKWRrHnlCLqN5xmrZo0)P_0).TradingSettings;
	}

	internal static void lFtS5SDDwafIGSe4Syyy(object P_0, bool P_1)
	{
		((ROKWRrHnlCLqN5xmrZo0)P_0).IsLotsInDOMShowed = P_1;
	}

	internal static void To9G1LDD7WD8UdSJJuCJ(object P_0, bool P_1)
	{
		((Popup)P_0).IsOpen = P_1;
	}

	internal static void pMKTPDDD8YJ4cYa4Bd8I(object P_0, object P_1)
	{
		((ROKWRrHnlCLqN5xmrZo0)P_0).Title = (string)P_1;
	}

	internal static void MJJMtIDDAGs0YeCoSSmb(object P_0, object P_1)
	{
		((FrameworkElement)P_0).SizeChanged += (SizeChangedEventHandler)P_1;
	}

	internal static void WM2dsMDDPFdafoS8CwOF(object P_0, object P_1)
	{
		((FrameworkElement)P_0).SizeChanged -= (SizeChangedEventHandler)P_1;
	}

	internal static double rTAFD2DDJSDSQ4m2qKNp(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static void lCmHtXDDFp5aPoNX3P46(object P_0, object P_1)
	{
		((UIElement)P_0).KeyDown += (KeyEventHandler)P_1;
	}

	internal static void nr1BH7DD3wpKTpQr9tM6()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Type PKovwPDDpUkhSP69sbgV(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle hR9U9gDDuIwBJykxtA9i(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object K9bcaMDDzpPEIl8TDHMi(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static object fSVRfDDb0sOcPNLNB9gX(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object bAMHIlDb2r6RoeSmKGIS(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
