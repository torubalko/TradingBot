using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Common;

[ContentProperty("MainContent")]
[TemplatePart(Name = "PART_Popup", Type = typeof(Popup))]
[TemplatePart(Name = "PART_Background", Type = typeof(Panel))]
[TemplatePart(Name = "PART_POPUP_CONTENT_PRESENTER", Type = typeof(ContentPresenter))]
public class PopupButton : Control
{
	public enum OghNFunTrrjiNepoFSci
	{
		Default,
		OnMouseSelect,
		OnEnter
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class WR0XwwnTKVdGUgK7WUDk
	{
		public static readonly WR0XwwnTKVdGUgK7WUDk u9inTweDqbg;

		public static MouseButtonEventHandler dGXnT7FYGBr;

		public static KeyEventHandler VTCnT8nHB1T;

		internal static WR0XwwnTKVdGUgK7WUDk JJ8QugNLHYESmyAuCklL;

		static WR0XwwnTKVdGUgK7WUDk()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			u9inTweDqbg = new WR0XwwnTKVdGUgK7WUDk();
		}

		public WR0XwwnTKVdGUgK7WUDk()
		{
			SrpdTRNLn4d5pm51Juvy();
			base._002Ector();
		}

		internal void pITnTm8WL7e(object s, MouseButtonEventArgs e)
		{
			FT8HbRuwyZd();
		}

		internal void J9MnThL4o72(object s, KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				FT8HbRuwyZd();
			}
		}

		internal static bool dhpbk5NLfDMSxX6aFicf()
		{
			return JJ8QugNLHYESmyAuCklL == null;
		}

		internal static WR0XwwnTKVdGUgK7WUDk JFY3nnNL90AaRxXPR5P9()
		{
			return JJ8QugNLHYESmyAuCklL;
		}

		internal static void SrpdTRNLn4d5pm51Juvy()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	[CompilerGenerated]
	private sealed class ttQvDqnTA0iVXHORrEDd
	{
		public PopupButton zVMnTJmjZ3R;

		private static ttQvDqnTA0iVXHORrEDd eHRexjNLGWoIpH9MhpF3;

		public ttQvDqnTA0iVXHORrEDd()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void MI3nTPHHlIu()
		{
			sRL71UNLvUYGc9g26doT(zVMnTJmjZ3R);
		}

		static ttQvDqnTA0iVXHORrEDd()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool taJlYGNLYFqEuk9pl3Yr()
		{
			return eHRexjNLGWoIpH9MhpF3 == null;
		}

		internal static ttQvDqnTA0iVXHORrEDd rhDdTyNLoFaHvtirkZ1x()
		{
			return eHRexjNLGWoIpH9MhpF3;
		}

		internal static void sRL71UNLvUYGc9g26doT(object P_0)
		{
			SPXHbgAeWDh((PopupButton)P_0);
		}
	}

	public static readonly RoutedCommand ClosePopupCommand;

	public static readonly DependencyProperty XkuHNME9gNg;

	public static readonly DependencyProperty XSmHNOX4U4J;

	public static readonly DependencyProperty z2oHNqcgDpP;

	public static readonly DependencyProperty CwsHNId8bxU;

	public static readonly DependencyProperty cj7HNW5Aetw;

	public static readonly DependencyProperty WhDHNtpbxFO;

	public static readonly DependencyProperty RAUHNUeo0kq;

	public static readonly DependencyProperty cPxHNT8hDKt;

	public static readonly DependencyProperty ETIHNyLT9IC;

	public static readonly DependencyProperty e6qHNZydDsR;

	public static readonly DependencyProperty MsAHNVpZHFc;

	public static readonly DependencyProperty ypxHNCXqieu;

	public static readonly DependencyProperty LTMHNrR6sjR;

	public static readonly DependencyProperty ElBHNKBYiFw;

	public static readonly DependencyProperty VAoHNmO4cCM;

	public static readonly DependencyProperty bKgHNhZ4tcv;

	public static readonly DependencyProperty vMXHNw7rvC5;

	public static readonly DependencyProperty rfJHN7eLY0y;

	public static readonly DependencyProperty NFaHN814I0Z;

	public static readonly DependencyProperty rNIHNAOaAkC;

	public static readonly DependencyProperty MYJHNPIeXvN;

	public static readonly DependencyProperty e27HNJMkos0;

	public static readonly DependencyProperty P6XHNFOCtJW;

	public static readonly DependencyProperty WwNHN3lobTx;

	public static readonly DependencyProperty QdhHNp5pT7Q;

	public static readonly DependencyProperty dSgHNurhgjK;

	public static readonly DependencyProperty GfKHNzDO9ft;

	public static readonly DependencyProperty OseHk0JuPII;

	[CompilerGenerated]
	private RoutedEventHandler m_PopupOpened;

	private ContentPresenter gHfHk2MD0lT;

	internal static PopupButton iLybK9DSSdq4u5raH5Rv;

	public object MainContent
	{
		get
		{
			return GetValue(XkuHNME9gNg);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, XkuHNME9gNg, obj);
		}
	}

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(XSmHNOX4U4J);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, XSmHNOX4U4J, cornerRadius);
		}
	}

	public object PopupIndicatorTemplate
	{
		get
		{
			return TAxWIuDSXNA3Aaunr6MP(this, z2oHNqcgDpP);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, z2oHNqcgDpP, obj);
		}
	}

	public Visibility PopupIndicatorVisibility
	{
		get
		{
			return (Visibility)TAxWIuDSXNA3Aaunr6MP(this, CwsHNId8bxU);
		}
		set
		{
			SetValue(CwsHNId8bxU, visibility);
		}
	}

	public object PopupContent
	{
		get
		{
			return TAxWIuDSXNA3Aaunr6MP(this, cj7HNW5Aetw);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, cj7HNW5Aetw, obj);
		}
	}

	public Brush BackgroundHover
	{
		get
		{
			return (Brush)GetValue(WhDHNtpbxFO);
		}
		set
		{
			SetValue(WhDHNtpbxFO, value2);
		}
	}

	public Brush BackgroundActive
	{
		get
		{
			return (Brush)TAxWIuDSXNA3Aaunr6MP(this, RAUHNUeo0kq);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, RAUHNUeo0kq, brush);
		}
	}

	public Brush BorderHover
	{
		get
		{
			return (Brush)GetValue(cPxHNT8hDKt);
		}
		set
		{
			SetValue(cPxHNT8hDKt, value2);
		}
	}

	public Brush BorderActive
	{
		get
		{
			return (Brush)GetValue(ETIHNyLT9IC);
		}
		set
		{
			SetValue(ETIHNyLT9IC, value2);
		}
	}

	public Brush PopupBackground
	{
		get
		{
			return (Brush)GetValue(e6qHNZydDsR);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, e6qHNZydDsR, brush);
		}
	}

	public Brush PopupBorderBrush
	{
		get
		{
			return (Brush)GetValue(MsAHNVpZHFc);
		}
		set
		{
			SetValue(MsAHNVpZHFc, value2);
		}
	}

	public Thickness PopupBorderThickness
	{
		get
		{
			return (Thickness)GetValue(ypxHNCXqieu);
		}
		set
		{
			SetValue(ypxHNCXqieu, thickness);
		}
	}

	public CornerRadius PopupCornerRadius
	{
		get
		{
			return (CornerRadius)TAxWIuDSXNA3Aaunr6MP(this, LTMHNrR6sjR);
		}
		set
		{
			SetValue(LTMHNrR6sjR, cornerRadius);
		}
	}

	public bool IsPopupOpen
	{
		get
		{
			return (bool)TAxWIuDSXNA3Aaunr6MP(this, ElBHNKBYiFw);
		}
		set
		{
			SetValue(ElBHNKBYiFw, flag);
		}
	}

	public bool IsChecked
	{
		get
		{
			return (bool)TAxWIuDSXNA3Aaunr6MP(this, VAoHNmO4cCM);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, VAoHNmO4cCM, flag);
		}
	}

	public bool IsPressed
	{
		get
		{
			return (bool)GetValue(bKgHNhZ4tcv);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, bKgHNhZ4tcv, flag);
		}
	}

	public ICommand Command
	{
		get
		{
			return (ICommand)TAxWIuDSXNA3Aaunr6MP(this, vMXHNw7rvC5);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, vMXHNw7rvC5, command);
		}
	}

	public object CommandParameter
	{
		get
		{
			return GetValue(rfJHN7eLY0y);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, rfJHN7eLY0y, obj);
		}
	}

	public bool IsTransparencyModeEnabled
	{
		get
		{
			return (bool)GetValue(NFaHN814I0Z);
		}
		set
		{
			SetValue(NFaHN814I0Z, flag);
		}
	}

	public bool AllowsTransparency
	{
		get
		{
			return (bool)GetValue(rNIHNAOaAkC);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, rNIHNAOaAkC, flag);
		}
	}

	public bool IsAutoFocusOnOpenEnabled
	{
		get
		{
			return (bool)GetValue(MYJHNPIeXvN);
		}
		set
		{
			SetValue(MYJHNPIeXvN, flag);
		}
	}

	public ContextMenu PopupMenu
	{
		get
		{
			return (ContextMenu)GetValue(e27HNJMkos0);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, e27HNJMkos0, contextMenu);
		}
	}

	public object PopupMenuDataContext
	{
		get
		{
			return GetValue(P6XHNFOCtJW);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, P6XHNFOCtJW, obj);
		}
	}

	public object PopupDataContext
	{
		get
		{
			return TAxWIuDSXNA3Aaunr6MP(this, WwNHN3lobTx);
		}
		set
		{
			SetValue(WwNHN3lobTx, value2);
		}
	}

	public double PopupVerticalOffset
	{
		get
		{
			return (double)TAxWIuDSXNA3Aaunr6MP(this, QdhHNp5pT7Q);
		}
		set
		{
			SetValue(QdhHNp5pT7Q, num);
		}
	}

	public double PopupHorizontalOffset
	{
		get
		{
			return (double)GetValue(dSgHNurhgjK);
		}
		set
		{
			SetValue(dSgHNurhgjK, num);
		}
	}

	public OghNFunTrrjiNepoFSci AutoCloseBehavior
	{
		get
		{
			return (OghNFunTrrjiNepoFSci)GetValue(GfKHNzDO9ft);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, GfKHNzDO9ft, oghNFunTrrjiNepoFSci);
		}
	}

	public DocumentWindow ParentDocumentWindow
	{
		get
		{
			return (DocumentWindow)GetValue(OseHk0JuPII);
		}
		set
		{
			CO6aqmDSsbv5IQmhGR6F(this, OseHk0JuPII, documentWindow);
		}
	}

	public event RoutedEventHandler PopupOpened
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = this.m_PopupOpened;
			RoutedEventHandler routedEventHandler2;
			RoutedEventHandler value2 = default(RoutedEventHandler);
			do
			{
				routedEventHandler2 = routedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						value2 = (RoutedEventHandler)Delegate.Combine(routedEventHandler2, b);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
						{
							num = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				routedEventHandler = Interlocked.CompareExchange(ref this.m_PopupOpened, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RoutedEventHandler routedEventHandler = this.m_PopupOpened;
			while (true)
			{
				RoutedEventHandler routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value3);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					}
					routedEventHandler = Interlocked.CompareExchange(ref this.m_PopupOpened, value2, routedEventHandler2);
					if ((object)routedEventHandler != routedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public PopupButton()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		base.DefaultStyleKey = DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.PreviewMouseLeftButtonDown += KCLHbsj1f3M;
	}

	private void KCLHbsj1f3M(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (ParentDocumentWindow != null)
				{
					ParentDocumentWindow.IsActive = true;
				}
				return;
			case 1:
				P_1.Handled = !IsPopupOpen;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		gHfHk2MD0lT = rnuxWRDSc7wG8YPQRBTF(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624813969)) as ContentPresenter;
		RtULYlDSjqVkGlORYcKD(gHfHk2MD0lT.CommandBindings, new CommandBinding(ClosePopupCommand, ab1Hb6jhTNd));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
		{
			num = 1;
		}
		Border border = default(Border);
		OghNFunTrrjiNepoFSci oghNFunTrrjiNepoFSci = default(OghNFunTrrjiNepoFSci);
		while (true)
		{
			switch (num)
			{
			case 7:
				if (border != null)
				{
					cBmpPdDSEThEvLkwi4Sf(border, new MouseButtonEventHandler(flnHbXkwW9S));
					num = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num = 4;
					}
					break;
				}
				goto case 2;
			case 5:
				oghNFunTrrjiNepoFSci = AutoCloseBehavior;
				num = 3;
				break;
			case 4:
				return;
			default:
				if (oghNFunTrrjiNepoFSci == OghNFunTrrjiNepoFSci.OnEnter)
				{
					FJAj7VDSd4mAM90w7E16(gHfHk2MD0lT, (KeyEventHandler)delegate(object s, KeyEventArgs e)
					{
						if (e.Key == Key.Return)
						{
							FT8HbRuwyZd();
						}
					});
				}
				goto case 8;
			case 6:
			{
				y0Q5qWDSQhykr5tIB8Ka(border, new MouseButtonEventHandler(S84HbcHLBWq));
				border.MouseLeave += jUvHbjYHeWb;
				border.MouseLeftButtonUp += yIfHbQm1NnZ;
				int num2 = 2;
				num = num2;
				break;
			}
			case 8:
				base.KeyUp += B4bHbEE9FTQ;
				vgbW5kDSgPTOZuxWEJwc(this);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num = 4;
				}
				break;
			case 3:
				if (oghNFunTrrjiNepoFSci != OghNFunTrrjiNepoFSci.OnMouseSelect)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
					{
						num = 0;
					}
				}
				else
				{
					gHfHk2MD0lT.PreviewMouseLeftButtonUp += delegate
					{
						FT8HbRuwyZd();
					};
					num = 8;
				}
				break;
			case 1:
				border = rnuxWRDSc7wG8YPQRBTF(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127350424)) as Border;
				num = 7;
				break;
			case 2:
				if (!(rnuxWRDSc7wG8YPQRBTF(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7E7E29)) is Popup popup))
				{
					goto case 5;
				}
				popup.CustomPopupPlacementCallback = pAQHbMAAgFC;
				num = 5;
				break;
			}
		}
	}

	private void flnHbXkwW9S(object P_0, MouseButtonEventArgs P_1)
	{
		IsPressed = true;
	}

	private void S84HbcHLBWq(object P_0, MouseButtonEventArgs P_1)
	{
		IsPressed = false;
	}

	private void jUvHbjYHeWb(object P_0, MouseEventArgs P_1)
	{
		IsPressed = false;
	}

	private void B4bHbEE9FTQ(object P_0, KeyEventArgs P_1)
	{
		if (P_1.Key == Key.Escape && IsPopupOpen)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			IsPopupOpen = false;
			P_1.Handled = true;
		}
	}

	private void yIfHbQm1NnZ(object P_0, MouseButtonEventArgs P_1)
	{
		int num;
		if (PopupMenu == null)
		{
			if (PopupContent != null)
			{
				if (IsPopupOpen)
				{
					goto IL_0111;
				}
				RoutedEventHandler routedEventHandler = this.PopupOpened;
				if (routedEventHandler == null)
				{
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
					{
						num = 2;
					}
				}
				else
				{
					routedEventHandler(this, P_1);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
					{
						num = 0;
					}
				}
			}
			else
			{
				ICommand command = Command;
				if (command == null || !QZwchvDS6XxfK5vwGtPC(command, CommandParameter))
				{
					return;
				}
				Command.Execute(CommandParameter);
				num = 5;
			}
		}
		else
		{
			PopupMenu.PlacementTarget = this;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				ParentDocumentWindow.IsActive = true;
				return;
			case 6:
				PopupMenu.Placement = PlacementMode.Bottom;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num = 2;
				}
				continue;
			default:
				ko8oSwDSRCfm8PENJnvy(PopupMenu, PopupMenuDataContext);
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 5;
				}
				continue;
			case 5:
				return;
			case 2:
				PopupMenu.StaysOpen = false;
				PopupMenu.IsOpen = true;
				if (ParentDocumentWindow == null)
				{
					return;
				}
				num = 3;
				continue;
			case 1:
			case 4:
				break;
			}
			break;
		}
		goto IL_0111;
		IL_0111:
		IsPopupOpen = !IsPopupOpen;
	}

	private static void CtaHbdQha2T(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		ttQvDqnTA0iVXHORrEDd ttQvDqnTA0iVXHORrEDd = default(ttQvDqnTA0iVXHORrEDd);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ttQvDqnTA0iVXHORrEDd = new ttQvDqnTA0iVXHORrEDd();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				return;
			}
			ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R = P_0 as PopupButton;
			if (ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R == null)
			{
				return;
			}
			if (ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.gHfHk2MD0lT == null)
			{
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ko8oSwDSRCfm8PENJnvy(ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.gHfHk2MD0lT, ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.PopupDataContext ?? ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.DataContext);
			if (ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.IsAutoFocusOnOpenEnabled && ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.IsPopupOpen)
			{
				mBCt5WDSMnM0SGSYoJ6y(ttQvDqnTA0iVXHORrEDd.zVMnTJmjZ3R.Dispatcher, DispatcherPriority.Loaded, new Action(ttQvDqnTA0iVXHORrEDd.MI3nTPHHlIu));
				num2 = 3;
				continue;
			}
			return;
		}
	}

	private static void SPXHbgAeWDh(PopupButton P_0)
	{
		IInputElement inputElement = Keyboard.Focus(P_0.gHfHk2MD0lT?.Content as FrameworkElement);
		bool flag = inputElement is PartEditBoxBase<object>;
		bool flag2 = inputElement is TextBox;
		if (flag)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
		{
			num = 2;
		}
		TraversalRequest request = default(TraversalRequest);
		while (true)
		{
			switch (num)
			{
			case 2:
				if (!flag2)
				{
					request = new TraversalRequest(FocusNavigationDirection.Next);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
					{
						num = 0;
					}
					continue;
				}
				return;
			case 1:
				return;
			}
			if (mUn3UuDSOiDIoq6n8bLC() is FrameworkElement frameworkElement)
			{
				frameworkElement.MoveFocus(request);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
				{
					num = 1;
				}
				continue;
			}
			return;
		}
	}

	public static void FT8HbRuwyZd(IInputElement P_0 = null)
	{
		ClosePopupCommand.Execute(null, P_0);
	}

	private void ab1Hb6jhTNd(object P_0, ExecutedRoutedEventArgs P_1)
	{
		IsPopupOpen = false;
	}

	private CustomPopupPlacement[] pAQHbMAAgFC(Size P_0, Size P_1, Point P_2)
	{
		return new CustomPopupPlacement[1]
		{
			new CustomPopupPlacement(new Point(0.0, P_1.Height + P_2.Y), PopupPrimaryAxis.Vertical)
		};
	}

	static PopupButton()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		ClosePopupCommand = new RoutedCommand((string)XDfu6MDSqvgqP4YtmcKX(-1309555870 ^ -1309614404), DJQkNnDSeSoQurYtTnBL(OsGXCRDSIqAWh3f1199W(33555299)));
		XkuHNME9gNg = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x34519BF), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(33555299)));
		XSmHNOX4U4J = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130F010D), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777950)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
		int num = 11;
		while (true)
		{
			switch (num)
			{
			case 1:
				vMXHNw7rvC5 = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710439064), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777377)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 7;
				break;
			case 8:
				OseHk0JuPII = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -60927195), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777442)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				return;
			case 7:
				rfJHN7eLY0y = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B49FC8), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(16777240)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 6;
				break;
			case 4:
				LTMHNrR6sjR = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D54246C), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777950)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				ElBHNKBYiFw = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624691215), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)), new PropertyMetadata(false, CtaHbdQha2T));
				VAoHNmO4cCM = DependencyProperty.Register((string)XDfu6MDSqvgqP4YtmcKX(0x28C965BE ^ 0x28C90E1E), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				bKgHNhZ4tcv = (DependencyProperty)PcqqQrDSWj01q333of9E(XDfu6MDSqvgqP4YtmcKX(--134855371 ^ 0x808A579), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num = 1;
				}
				break;
			case 12:
				WwNHN3lobTx = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C0E8DC), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num = 1;
				}
				break;
			default:
				P6XHNFOCtJW = (DependencyProperty)PcqqQrDSWj01q333of9E(XDfu6MDSqvgqP4YtmcKX(-602153869 ^ -602211325), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(16777240)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 12;
				break;
			case 10:
				ypxHNCXqieu = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -5908827), DJQkNnDSeSoQurYtTnBL(OsGXCRDSIqAWh3f1199W(16777469)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 4;
				break;
			case 9:
				rNIHNAOaAkC = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2CE413), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				MYJHNPIeXvN = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44466769), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(16777221)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				e27HNJMkos0 = DependencyProperty.Register((string)XDfu6MDSqvgqP4YtmcKX(-57768881 ^ -57695211), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777449)), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(33555299)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num = 0;
				}
				break;
			case 11:
				z2oHNqcgDpP = DependencyProperty.Register((string)XDfu6MDSqvgqP4YtmcKX(0x42D899B5 ^ 0x42D987AB), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				CwsHNId8bxU = (DependencyProperty)x7e0fdDStb4dmgaLxkOs(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799570495), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777415)), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(33555299)), new UIPropertyMetadata(Visibility.Visible));
				cj7HNW5Aetw = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D302ECA), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				WhDHNtpbxFO = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962586771), DJQkNnDSeSoQurYtTnBL(OsGXCRDSIqAWh3f1199W(16777400)), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(33555299)));
				RAUHNUeo0kq = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1CC5FB), DJQkNnDSeSoQurYtTnBL(OsGXCRDSIqAWh3f1199W(16777400)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				cPxHNT8hDKt = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446BA9C0), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				ETIHNyLT9IC = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087018880), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				e6qHNZydDsR = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461881622), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), DJQkNnDSeSoQurYtTnBL(OsGXCRDSIqAWh3f1199W(33555299)));
				MsAHNVpZHFc = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736505412), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), DJQkNnDSeSoQurYtTnBL(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 10;
				break;
			case 6:
				NFaHN814I0Z = (DependencyProperty)PcqqQrDSWj01q333of9E(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73560A39), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 9;
				break;
			case 5:
				GfKHNzDO9ft = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BE62E4), DJQkNnDSeSoQurYtTnBL(OsGXCRDSIqAWh3f1199W(33555300)), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(33555299)), new PropertyMetadata(OghNFunTrrjiNepoFSci.Default));
				num = 8;
				break;
			case 2:
				QdhHNp5pT7Q = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710429536), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(OsGXCRDSIqAWh3f1199W(33555299)));
				num = 3;
				break;
			case 3:
				dSgHNurhgjK = (DependencyProperty)PcqqQrDSWj01q333of9E(XDfu6MDSqvgqP4YtmcKX(-1346994499 ^ -1346937257), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555299)));
				num = 5;
				break;
			}
		}
	}

	internal static Type DJQkNnDSeSoQurYtTnBL(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool UekiqtDSxeMoh3WaFdDl()
	{
		return iLybK9DSSdq4u5raH5Rv == null;
	}

	internal static PopupButton fZ3Y5yDSLs6TA6tX1d9m()
	{
		return iLybK9DSSdq4u5raH5Rv;
	}

	internal static void CO6aqmDSsbv5IQmhGR6F(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object TAxWIuDSXNA3Aaunr6MP(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static object rnuxWRDSc7wG8YPQRBTF(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static int RtULYlDSjqVkGlORYcKD(object P_0, object P_1)
	{
		return ((CommandBindingCollection)P_0).Add((CommandBinding)P_1);
	}

	internal static void cBmpPdDSEThEvLkwi4Sf(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewMouseLeftButtonDown += (MouseButtonEventHandler)P_1;
	}

	internal static void y0Q5qWDSQhykr5tIB8Ka(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewMouseLeftButtonUp += (MouseButtonEventHandler)P_1;
	}

	internal static void FJAj7VDSd4mAM90w7E16(object P_0, object P_1)
	{
		((UIElement)P_0).KeyUp += (KeyEventHandler)P_1;
	}

	internal static void vgbW5kDSgPTOZuxWEJwc(object P_0)
	{
		((FrameworkElement)P_0).OnApplyTemplate();
	}

	internal static void ko8oSwDSRCfm8PENJnvy(object P_0, object P_1)
	{
		((FrameworkElement)P_0).DataContext = P_1;
	}

	internal static bool QZwchvDS6XxfK5vwGtPC(object P_0, object P_1)
	{
		return ((ICommand)P_0).CanExecute(P_1);
	}

	internal static object mBCt5WDSMnM0SGSYoJ6y(object P_0, DispatcherPriority P_1, object P_2)
	{
		return ((Dispatcher)P_0).BeginInvoke(P_1, (Delegate)P_2);
	}

	internal static object mUn3UuDSOiDIoq6n8bLC()
	{
		return Keyboard.FocusedElement;
	}

	internal static object XDfu6MDSqvgqP4YtmcKX(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static RuntimeTypeHandle OsGXCRDSIqAWh3f1199W(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object PcqqQrDSWj01q333of9E(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static object x7e0fdDStb4dmgaLxkOs(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
