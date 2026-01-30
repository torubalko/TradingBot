using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
[TemplateVisualState(Name = "TabStripTop", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "PopupOpenPointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "TabStripBottom", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "TabStripLeft", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "PopupOpen", GroupName = "CommonStates")]
[TemplateVisualState(Name = "TabStripRight", GroupName = "TabStripPlacementStates")]
public class AutoHideTabItem : ContentControl
{
	private InputAdapter G8B;

	private bool l8K;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty IsAutoHidePopupOpenProperty;

	public static readonly DependencyProperty IsImageVisibleProperty;

	public static readonly DependencyProperty PlacementProperty;

	internal static AutoHideTabItem H8Q;

	private DockSite DockSite => j8k()?.DockSite;

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
		}
	}

	public bool IsAutoHidePopupOpen
	{
		get
		{
			return (bool)GetValue(IsAutoHidePopupOpenProperty);
		}
		set
		{
			SetValue(IsAutoHidePopupOpenProperty, value);
		}
	}

	public bool IsImageVisible
	{
		get
		{
			return (bool)GetValue(IsImageVisibleProperty);
		}
		private set
		{
			SetValue(IsImageVisibleProperty, value);
		}
	}

	public Side Placement
	{
		get
		{
			return (Side)GetValue(PlacementProperty);
		}
		set
		{
			SetValue(PlacementProperty, value);
		}
	}

	public AutoHideTabItem()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(AutoHideTabItem);
		aTy();
		base.AllowDrop = true;
	}

	private void aT5()
	{
		L8m()?.Activate();
	}

	private void aTy()
	{
		G8B = new InputAdapter(this);
		G8B.PointerEntered += P8i;
		G8B.PointerExited += T8d;
		G8B.PointerMoved += f8w;
		G8B.PointerPressed += U82;
		G8B.PointerReleased += k8e;
		G8B.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	[SpecialName]
	private DockHost j8k()
	{
		return VisualTreeHelperExtended.GetAncestor<DockHost>(this);
	}

	private void CTo(bool P_0)
	{
		j8k()?.few().Fli(L8m(), P_0);
	}

	private void cTt(bool P_0)
	{
		j8k()?.few().Kld(L8m(), P_0);
	}

	private static void cTu(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AutoHideTabItem)P_0).c8I(_0020: false);
	}

	private static void CTz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AutoHideTabItem)P_0).c8I(_0020: false);
	}

	private void P8i(object P_0, InputPointerEventArgs P_1)
	{
		l8K = true;
		c8I(_0020: true);
		CTo(_0020: false);
	}

	private void T8d(object P_0, InputPointerEventArgs P_1)
	{
		l8K = false;
		c8I(_0020: true);
		cTt(_0020: false);
	}

	private void f8w(object P_0, InputPointerEventArgs P_1)
	{
		l8K = true;
		c8I(_0020: true);
	}

	private void U82(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled || !P_1.IsPrimaryButton)
		{
			return;
		}
		DockHost dockHost = j8k();
		if (dockHost == null)
		{
			return;
		}
		P_1.Handled = true;
		DockSite dockSite = DockSite;
		if (!V8N() && dockHost.IsAutoHidePopupOpen)
		{
			int num = 0;
			if (!I8v())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (dockHost.AutoHidePopupToolWindow == L8m())
			{
				Focus();
				dockHost.CloseAutoHidePopup(closeImmediately: false, blurFocus: false);
				return;
			}
		}
		if (dockSite == null || dockSite.jCz(L8m()))
		{
			Focus();
			aT5();
		}
	}

	private void k8e(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && P_1.ButtonKind == InputPointerButtonKind.Secondary)
		{
			AutoHideTabStrip ancestor = VisualTreeHelperExtended.GetAncestor<AutoHideTabStrip>(this);
			if (ancestor != null)
			{
				P_1.Handled = true;
				ancestor.p8T(P_1, L8m());
			}
		}
	}

	[SpecialName]
	private bool V8N()
	{
		return DockSite?.AutoHidePopupOpensOnMouseHover ?? false;
	}

	[SpecialName]
	private ToolWindow L8m()
	{
		return base.Content as ToolWindow;
	}

	internal void j8G()
	{
		ToolWindow toolWindow = L8m();
		ToolWindowContainer toolWindowContainer = toolWindow?.DBR();
		IsImageVisible = toolWindow != null && toolWindow.ImageSource != null && (toolWindowContainer?.HasTabImages ?? false);
	}

	private void c8I(bool P_0)
	{
		switch (Placement)
		{
		case Side.Bottom:
			VisualStateManager.GoToState(this, vVK.ssH(3600), P_0);
			break;
		case Side.Left:
			VisualStateManager.GoToState(this, vVK.ssH(3632), P_0);
			break;
		case Side.Right:
			VisualStateManager.GoToState(this, vVK.ssH(3660), P_0);
			break;
		default:
			VisualStateManager.GoToState(this, vVK.ssH(3690), P_0);
			break;
		}
		if (IsAutoHidePopupOpen)
		{
			VisualStateManager.GoToState(this, l8K ? vVK.ssH(20406) : vVK.ssH(20384), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, l8K ? vVK.ssH(4148) : vVK.ssH(20450), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		c8I(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AutoHideTabItemAutomationPeer(this);
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		base.OnDragOver(e);
		CTo(_0020: true);
	}

	protected override void OnDragLeave(DragEventArgs e)
	{
		base.OnDragLeave(e);
		cTt(_0020: true);
	}

	static AutoHideTabItem()
	{
		IVH.CecNqz();
		CornerRadiusProperty = DependencyProperty.Register(vVK.ssH(5600), typeof(CornerRadius), typeof(AutoHideTabItem), new PropertyMetadata(default(CornerRadius)));
		IsAutoHidePopupOpenProperty = DependencyProperty.Register(vVK.ssH(17660), typeof(bool), typeof(AutoHideTabItem), new PropertyMetadata(false, cTu));
		IsImageVisibleProperty = DependencyProperty.Register(vVK.ssH(6250), typeof(bool), typeof(AutoHideTabItem), new PropertyMetadata(false));
		PlacementProperty = DependencyProperty.Register(vVK.ssH(20362), typeof(Side), typeof(AutoHideTabItem), new PropertyMetadata(Side.Top, CTz));
	}

	internal static bool I8v()
	{
		return H8Q == null;
	}

	internal static AutoHideTabItem A8N()
	{
		return H8Q;
	}
}
