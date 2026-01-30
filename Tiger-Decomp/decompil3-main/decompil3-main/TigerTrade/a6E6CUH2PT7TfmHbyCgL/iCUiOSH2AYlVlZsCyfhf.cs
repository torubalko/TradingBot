using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using b9WDP9H2QaL9mXKBtG4J;
using ECOEgqlSad8NUJZ2Dr9n;
using IxRGqgH2U2Cxk2G3OCyn;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using qK52IFH2WpFQpklt3aW3;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace a6E6CUH2PT7TfmHbyCgL;

public class iCUiOSH2AYlVlZsCyfhf : UserControl, IComponentConnector
{
	public enum State
	{
		Loading,
		Loaded,
		Error
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct zIwxlxnWRVnhht1Y8VZm : IAsyncStateMachine
	{
		public int TqynW6bhKDG;

		public AsyncVoidMethodBuilder VSInWMnLIrL;

		public iCUiOSH2AYlVlZsCyfhf l8nnWO500v6;

		private TaskAwaiter dJinWqSLCpC;

		private static object XgeMgUN5Z4ZrNg3q09VP;

		private void MoveNext()
		{
			int num = TqynW6bhKDG;
			iCUiOSH2AYlVlZsCyfhf iCUiOSH2AYlVlZsCyfhf2 = l8nnWO500v6;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
			{
				num2 = 1;
			}
			switch (num2)
			{
			case 1:
				try
				{
					int num3;
					if (num != 0)
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
						{
							num3 = 0;
						}
						goto IL_0041;
					}
					goto IL_0053;
					IL_0041:
					switch (num3)
					{
					default:
						iCUiOSH2AYlVlZsCyfhf2.utMHH0FppPa(State.Loading);
						break;
					case 1:
						{
							try
							{
								int num4;
								if (num != 0)
								{
									num4 = 8;
									goto IL_009e;
								}
								goto IL_01a1;
								IL_01a1:
								TaskAwaiter awaiter = dJinWqSLCpC;
								int num5 = 4;
								goto IL_00a2;
								IL_009e:
								num5 = num4;
								goto IL_00a2;
								IL_00a2:
								while (true)
								{
									switch (num5)
									{
									case 7:
										dJinWqSLCpC = awaiter;
										VSInWMnLIrL.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 5:
										iCUiOSH2AYlVlZsCyfhf2.uMBH2uhF49d();
										goto end_IL_0089;
									case 4:
										dJinWqSLCpC = default(TaskAwaiter);
										num = (TqynW6bhKDG = -1);
										num5 = 2;
										continue;
									case 8:
										awaiter = HRbCawN5rtlj2l79Lqjd(iCUiOSH2AYlVlZsCyfhf2.WebView.EnsureCoreWebView2Async());
										if (!awaiter.IsCompleted)
										{
											num5 = 3;
											continue;
										}
										goto case 2;
									case 6:
										break;
									case 2:
										awaiter.GetResult();
										if (iCUiOSH2AYlVlZsCyfhf2.WebView.CoreWebView2 != null)
										{
											UfSwRKH2tAJkNHk7HiIj ufSwRKH2tAJkNHk7HiIj = new UfSwRKH2tAJkNHk7HiIj(iCUiOSH2AYlVlZsCyfhf2.WebView);
											ufSwRKH2tAJkNHk7HiIj.RExH2KjOZVo(iCUiOSH2AYlVlZsCyfhf2.BGxH23al7iF);
											iCUiOSH2AYlVlZsCyfhf2.WebView.CoreWebView2.ContainsFullScreenElementChanged += iCUiOSH2AYlVlZsCyfhf2.znFH2FIhcAy;
											iCUiOSH2AYlVlZsCyfhf2.Unloaded += iCUiOSH2AYlVlZsCyfhf2.u9pH2pFAUGQ;
											iCUiOSH2AYlVlZsCyfhf2.tI0HHaLXlfb = ufSwRKH2tAJkNHk7HiIj;
											num5 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
											{
												num5 = 0;
											}
											continue;
										}
										goto IL_0271;
									case 3:
										goto IL_0239;
									default:
										iCUiOSH2AYlVlZsCyfhf2.uMBH2uhF49d();
										goto end_IL_0089;
									case 1:
										goto IL_0271;
									}
									break;
								}
								goto IL_01a1;
								IL_0239:
								num = (TqynW6bhKDG = 0);
								num4 = 7;
								goto IL_009e;
								IL_0271:
								iCUiOSH2AYlVlZsCyfhf2.tI0HHaLXlfb = iCUiOSH2AYlVlZsCyfhf2.FakeView;
								num4 = 5;
								goto IL_009e;
								end_IL_0089:;
							}
							catch (Exception)
							{
								iCUiOSH2AYlVlZsCyfhf2.utMHH0FppPa(State.Error);
								goto IL_007b;
							}
							goto end_IL_001c;
						}
						IL_007b:
						iCUiOSH2AYlVlZsCyfhf2.utMHH0FppPa(State.Error);
						goto end_IL_001c;
					}
					goto IL_0053;
					IL_0053:
					num3 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
					{
						num3 = 1;
					}
					goto IL_0041;
					end_IL_001c:;
				}
				catch (Exception exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					}
					TqynW6bhKDG = -2;
					VSInWMnLIrL.SetException(exception);
					return;
				}
				break;
			}
			TqynW6bhKDG = -2;
			VSInWMnLIrL.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			VSInWMnLIrL.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static zIwxlxnWRVnhht1Y8VZm()
		{
			S1FsK7N5KdFd4sY13nuL();
		}

		internal static TaskAwaiter HRbCawN5rtlj2l79Lqjd(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static bool V3sL1JN5VReOJitiMoIG()
		{
			return XgeMgUN5Z4ZrNg3q09VP == null;
		}

		internal static object BtB6xTN5CehYkLdCnpQK()
		{
			return XgeMgUN5Z4ZrNg3q09VP;
		}

		internal static void S1FsK7N5KdFd4sY13nuL()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	public static readonly DependencyProperty u8mHHovYDNm;

	public static readonly DependencyProperty SvQHHvZDkNF;

	[CompilerGenerated]
	private EventHandler<bool> XjtHHBZw5Gl;

	private uUWLIoH2IMa6ubyC18Xq tI0HHaLXlfb;

	internal iCUiOSH2AYlVlZsCyfhf Root;

	internal Border RootBorder;

	internal StackPanel ErrorView;

	internal Rectangle Shimmer;

	internal GradientStop WhiteStop;

	internal WebView2 WebView;

	internal xbb1HDH2EkVSoVw21YRc FakeView;

	private bool lLvHHiEtHdM;

	private static iCUiOSH2AYlVlZsCyfhf x2f9eSDiKrhknpfIYFVO;

	public ICommand FailedCommand
	{
		get
		{
			return (ICommand)GetValue(u8mHHovYDNm);
		}
		set
		{
			SetValue(u8mHHovYDNm, value2);
		}
	}

	public Uri Source
	{
		get
		{
			return (Uri)SfkdHoDiwQaZs6xm5kQ3(this, SvQHHvZDkNF);
		}
		set
		{
			SetValue(SvQHHvZDkNF, value2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void dwcHHnaZnJt(EventHandler<bool> P_0)
	{
		EventHandler<bool> eventHandler = XjtHHBZw5Gl;
		EventHandler<bool> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bool> value = (EventHandler<bool>)Delegate.Combine(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref XjtHHBZw5Gl, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void rllHHG782yT(EventHandler<bool> P_0)
	{
		EventHandler<bool> eventHandler = XjtHHBZw5Gl;
		EventHandler<bool> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bool> value = (EventHandler<bool>)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref XjtHHBZw5Gl, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public iCUiOSH2AYlVlZsCyfhf()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
		sUEH2Jh9WBp();
	}

	[AsyncStateMachine(typeof(zIwxlxnWRVnhht1Y8VZm))]
	private void sUEH2Jh9WBp()
	{
		zIwxlxnWRVnhht1Y8VZm stateMachine = default(zIwxlxnWRVnhht1Y8VZm);
		stateMachine.VSInWMnLIrL = AsyncVoidMethodBuilder.Create();
		stateMachine.l8nnWO500v6 = this;
		stateMachine.TqynW6bhKDG = -1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		stateMachine.VSInWMnLIrL.Start(ref stateMachine);
	}

	private void znFH2FIhcAy(object P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		bool e = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				e = E0LHGgDi7Z1eyMvuSLIn(WebView.CoreWebView2);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				XjtHHBZw5Gl?.Invoke(this, e);
				return;
			}
		}
	}

	private void BGxH23al7iF(object P_0, EventArgs P_1)
	{
		utMHH0FppPa(State.Error);
	}

	private void u9pH2pFAUGQ(object P_0, RoutedEventArgs P_1)
	{
		if (UmNfnXDi8sEcaCPyq9bh(WebView) != null)
		{
			poXt3nDiAY5dNCPLkixa(WebView);
		}
	}

	private void uMBH2uhF49d()
	{
		if (tI0HHaLXlfb == null)
		{
			return;
		}
		utMHH0FppPa(State.Loading);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			tI0HHaLXlfb.Navigate(Source);
			utMHH0FppPa(State.Loaded);
		}
		catch (Exception)
		{
			utMHH0FppPa(State.Error);
		}
	}

	private static void sSmH2ze4jkt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		iCUiOSH2AYlVlZsCyfhf iCUiOSH2AYlVlZsCyfhf2 = default(iCUiOSH2AYlVlZsCyfhf);
		while (true)
		{
			switch (num2)
			{
			case 2:
				iCUiOSH2AYlVlZsCyfhf2 = P_0 as iCUiOSH2AYlVlZsCyfhf;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 1;
				}
				break;
			default:
				pYCGEjDiJ3jnDTUYXUCk(iCUiOSH2AYlVlZsCyfhf2, State.Error);
				return;
			case 1:
				if (iCUiOSH2AYlVlZsCyfhf2 == null)
				{
					return;
				}
				if ((Uri)vLrWWjDiP0BCnxlgMMbB(iCUiOSH2AYlVlZsCyfhf2) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num2 = 0;
					}
					break;
				}
				iCUiOSH2AYlVlZsCyfhf2.uMBH2uhF49d();
				return;
			}
		}
	}

	private void utMHH0FppPa(State P_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				tI0HHaLXlfb.Visibility = Visibility.Collapsed;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				if (tI0HHaLXlfb == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num2 = 2;
					}
					break;
				}
				switch (P_0)
				{
				case State.Loaded:
					CDPEf9DiFMgAr7L3d7SI(Shimmer, Visibility.Collapsed);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num2 = 4;
					}
					break;
				case State.Error:
					Shimmer.Visibility = Visibility.Collapsed;
					ErrorView.Visibility = Visibility.Visible;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return;
				case State.Loading:
					CDPEf9DiFMgAr7L3d7SI(Shimmer, Visibility.Visible);
					CDPEf9DiFMgAr7L3d7SI(ErrorView, Visibility.Collapsed);
					hHveAhDi3HrK7FtZbLan(tI0HHaLXlfb, Visibility.Collapsed);
					return;
				}
				break;
			case 4:
				ErrorView.Visibility = Visibility.Collapsed;
				tI0HHaLXlfb.Visibility = Visibility.Visible;
				return;
			case 2:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lLvHHiEtHdM)
		{
			lLvHHiEtHdM = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1CD94D), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 7:
			FakeView = (xbb1HDH2EkVSoVw21YRc)P_1;
			break;
		case 2:
			RootBorder = (Border)P_1;
			break;
		case 1:
			Root = (iCUiOSH2AYlVlZsCyfhf)P_1;
			break;
		case 5:
			WhiteStop = (GradientStop)P_1;
			break;
		default:
			lLvHHiEtHdM = true;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 3:
			ErrorView = (StackPanel)P_1;
			num = 2;
			goto IL_0009;
		case 4:
			Shimmer = (Rectangle)P_1;
			num = 3;
			goto IL_0009;
		case 6:
			{
				WebView = (WebView2)P_1;
				break;
			}
			IL_0009:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 3:
				return;
			case 2:
				return;
			case 0:
				return;
			}
			goto case 1;
		}
	}

	static iCUiOSH2AYlVlZsCyfhf()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				u8mHHovYDNm = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690575741), BEZBMoDippecMAR1YrCZ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777377)), BEZBMoDippecMAR1YrCZ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555206)));
				SvQHHvZDkNF = DependencyProperty.Register((string)rWqUkODiuywLyPZUrnBS(-1461292091 ^ -1461298631), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777315)), Type.GetTypeFromHandle(lFAy3EDiz0iOxlVgg28m(33555206)), new PropertyMetadata(null, sSmH2ze4jkt));
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool cnokxTDimpWaaKg2xpYD()
	{
		return x2f9eSDiKrhknpfIYFVO == null;
	}

	internal static iCUiOSH2AYlVlZsCyfhf WB9JHaDihtcXElKupsjZ()
	{
		return x2f9eSDiKrhknpfIYFVO;
	}

	internal static object SfkdHoDiwQaZs6xm5kQ3(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool E0LHGgDi7Z1eyMvuSLIn(object P_0)
	{
		return ((CoreWebView2)P_0).ContainsFullScreenElement;
	}

	internal static object UmNfnXDi8sEcaCPyq9bh(object P_0)
	{
		return ((WebView2)P_0).CoreWebView2;
	}

	internal static void poXt3nDiAY5dNCPLkixa(object P_0)
	{
		((HwndHost)P_0).Dispose();
	}

	internal static object vLrWWjDiP0BCnxlgMMbB(object P_0)
	{
		return ((iCUiOSH2AYlVlZsCyfhf)P_0).Source;
	}

	internal static void pYCGEjDiJ3jnDTUYXUCk(object P_0, State P_1)
	{
		((iCUiOSH2AYlVlZsCyfhf)P_0).utMHH0FppPa(P_1);
	}

	internal static void CDPEf9DiFMgAr7L3d7SI(object P_0, Visibility P_1)
	{
		((UIElement)P_0).Visibility = P_1;
	}

	internal static void hHveAhDi3HrK7FtZbLan(object P_0, Visibility P_1)
	{
		((uUWLIoH2IMa6ubyC18Xq)P_0).Visibility = P_1;
	}

	internal static Type BEZBMoDippecMAR1YrCZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object rWqUkODiuywLyPZUrnBS(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static RuntimeTypeHandle lFAy3EDiz0iOxlVgg28m(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
