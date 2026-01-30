using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[ToolboxItem(false)]
public class ScrollBarSplitter : Control
{
	private InputAdapter yla;

	private bool xlx;

	private DateTime dlG;

	private Point rlX;

	internal static ScrollBarSplitter x0J;

	public ScrollBarSplitter()
	{
		grA.DaB7cz();
		dlG = DateTime.Today;
		base._002Ector();
		base.DefaultStyleKey = typeof(ScrollBarSplitter);
		wed();
	}

	private void wed()
	{
		yla = new InputAdapter(this);
		yla.PointerEntered += nez;
		yla.PointerExited += OlW;
		yla.PointerMoved += plP;
		yla.PointerPressed += RlE;
		yla.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed;
	}

	private void nez(object P_0, InputPointerEventArgs P_1)
	{
		xlx = true;
		Wlc(_0020: true);
	}

	private void OlW(object P_0, InputPointerEventArgs P_1)
	{
		xlx = false;
		Wlc(_0020: true);
	}

	private void plP(object P_0, InputPointerEventArgs P_1)
	{
		xlx = true;
		Wlc(_0020: true);
	}

	private void RlE(object P_0, InputPointerButtonEventArgs P_1)
	{
		DateTime dateTime = dlG;
		Point point = rlX;
		dlG = DateTime.Now;
		rlX = P_1.GetPosition(this);
		if (P_1 == null || !P_1.IsPrimaryButton)
		{
			return;
		}
		P_1.Handled = true;
		if (vAE.L0A(point, rlX, dateTime, dlG, P_1.DeviceKind == InputDeviceKind.Touch))
		{
			SyntaxEditor ancestor = VisualTreeHelperExtended.GetAncestor<SyntaxEditor>(this);
			if (ancestor != null)
			{
				ancestor.HasHorizontalSplit = true;
			}
		}
		else
		{
			VisualTreeHelperExtended.GetAncestor<EditorViewHost>(this)?.BgT(P_1);
		}
	}

	private void Wlc(bool P_0)
	{
		if (xlx)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(9508), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(9534), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Wlc(_0020: false);
	}

	internal static bool J0R()
	{
		return x0J == null;
	}

	internal static ScrollBarSplitter b0O()
	{
		return x0J;
	}
}
