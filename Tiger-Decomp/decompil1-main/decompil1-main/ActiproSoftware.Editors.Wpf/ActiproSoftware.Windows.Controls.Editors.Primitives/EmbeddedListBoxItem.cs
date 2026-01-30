using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class EmbeddedListBoxItem : ListBoxItem
{
	private InputAdapter iOg;

	private bool UOo;

	internal static EmbeddedListBoxItem zjS;

	public EmbeddedListBoxItem()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EmbeddedListBoxItem);
		WOf();
	}

	[SpecialName]
	private EmbeddedListBox UO0()
	{
		return ItemsControl.ItemsControlFromItemContainer(this) as EmbeddedListBox;
	}

	private void WOf()
	{
		iOg = new InputAdapter(this);
		iOg.PointerCaptureLost += YOl;
		iOg.PointerPressed += iOX;
		iOg.PointerReleased += HOx;
		iOg.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	private void YOl(object P_0, InputPointerEventArgs P_1)
	{
		UOo = false;
	}

	private void iOX(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && base.IsEnabled && P_1.ButtonKind == InputPointerButtonKind.Primary)
		{
			EmbeddedListBox embeddedListBox = UO0();
			if (embeddedListBox != null)
			{
				embeddedListBox.SelectedItem = base.Content;
				UOo = true;
				P_1.Handled = true;
				iOg.CapturePointer(P_1);
			}
		}
	}

	private void HOx(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (!UOo)
		{
			return;
		}
		UOo = false;
		iOg.ReleasePointerCaptures();
		if (P_1 == null)
		{
			return;
		}
		int num = 0;
		if (yjt() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (P_1.IsPositionOver(this))
		{
			UO0()?.jOs();
		}
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
	}

	internal static bool bjA()
	{
		return zjS == null;
	}

	internal static EmbeddedListBoxItem yjt()
	{
		return zjS;
	}
}
