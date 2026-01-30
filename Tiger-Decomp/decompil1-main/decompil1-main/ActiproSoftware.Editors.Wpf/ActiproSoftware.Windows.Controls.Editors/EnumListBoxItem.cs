using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplateVisualState(Name = "Unchecked", GroupName = "CheckStates")]
[TemplateVisualState(Name = "Checked", GroupName = "CheckStates")]
[TemplateVisualState(Name = "Indeterminate", GroupName = "CheckStates")]
[TemplateVisualState(Name = "GroupStart", GroupName = "GroupStates")]
[TemplateVisualState(Name = "GroupNormal", GroupName = "GroupStates")]
[ToolboxItem(false)]
public class EnumListBoxItem : ListBoxItem
{
	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	public static readonly DependencyProperty IsFlagsEnumProperty;

	public static readonly DependencyProperty IsGroupStartProperty;

	public static readonly DependencyProperty IsPartiallySelectedProperty;

	private InputAdapter Lsi;

	private bool FsZ;

	private static EnumListBoxItem tBV;

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	public bool IsFlagsEnum
	{
		get
		{
			return (bool)GetValue(IsFlagsEnumProperty);
		}
		internal set
		{
			SetValue(IsFlagsEnumProperty, value);
		}
	}

	public bool IsGroupStart
	{
		get
		{
			return (bool)GetValue(IsGroupStartProperty);
		}
		internal set
		{
			SetValue(IsGroupStartProperty, value);
		}
	}

	public bool IsPartiallySelected
	{
		get
		{
			return (bool)GetValue(IsPartiallySelectedProperty);
		}
		internal set
		{
			SetValue(IsPartiallySelectedProperty, value);
		}
	}

	public EnumListBoxItem()
	{
		awj.QuEwGz();
		this._002Ector(isFlagsEnum: true);
	}

	internal EnumListBoxItem(bool isFlagsEnum)
	{
		awj.QuEwGz();
		base._002Ector();
		IsFlagsEnum = isFlagsEnum;
		base.DefaultStyleKey = typeof(EnumListBoxItem);
		qsy();
	}

	private static void jsL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumListBoxItem enumListBoxItem = (EnumListBoxItem)P_0;
		enumListBoxItem.msA();
	}

	private static void csF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumListBoxItem enumListBoxItem = (EnumListBoxItem)P_0;
		enumListBoxItem.msA();
	}

	[SpecialName]
	private EnumListBox Fs8()
	{
		return ItemsControl.ItemsControlFromItemContainer(this) as EnumListBox;
	}

	internal void msA()
	{
		vs3(_0020: true);
	}

	private void vs3(bool P_0)
	{
		if (IsGroupStart)
		{
			VisualStateManager.GoToState(this, QdM.AR8(19442), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(19466), P_0);
		}
		if (base.IsSelected)
		{
			VisualStateManager.GoToState(this, QdM.AR8(19492), P_0);
		}
		else if (IsPartiallySelected)
		{
			VisualStateManager.GoToState(this, QdM.AR8(19510), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(19540), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		vs3(_0020: false);
	}

	private void qsy()
	{
		Lsi = new InputAdapter(this);
		Lsi.PointerCaptureLost += Usm;
		Lsi.PointerPressed += zsS;
		Lsi.PointerReleased += ts1;
		Lsi.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	private void Usm(object P_0, InputPointerEventArgs P_1)
	{
		FsZ = false;
	}

	private void zsS(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && base.IsEnabled && P_1.ButtonKind == InputPointerButtonKind.Primary)
		{
			EnumListBox enumListBox = Fs8();
			if (enumListBox != null)
			{
				if (enumListBox.SelectionMode != SelectionMode.Single)
				{
					goto IL_00d5;
				}
				enumListBox.SelectedItem = base.DataContext;
				goto IL_00ea;
			}
			return;
		}
		return;
		IL_00ea:
		FsZ = true;
		P_1.Handled = true;
		int num = 1;
		if (!oBu())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			Lsi.CapturePointer(P_1);
			return;
		}
		goto IL_00d5;
		IL_00d5:
		base.IsSelected = !base.IsSelected;
		goto IL_00ea;
	}

	private void ts1(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (FsZ)
		{
			FsZ = false;
			Lsi.ReleasePointerCaptures();
			if (P_1 != null && P_1.IsPositionOver(this))
			{
				Fs8()?.Aso();
			}
		}
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
	}

	static EnumListBoxItem()
	{
		awj.QuEwGz();
		IsFlagsEnumProperty = DependencyProperty.Register(QdM.AR8(19394), typeof(bool), typeof(EnumListBoxItem), new FrameworkPropertyMetadata(true));
		IsGroupStartProperty = DependencyProperty.Register(QdM.AR8(19562), typeof(bool), typeof(EnumListBoxItem), new FrameworkPropertyMetadata(false, jsL));
		IsPartiallySelectedProperty = DependencyProperty.Register(QdM.AR8(19590), typeof(bool), typeof(EnumListBoxItem), new FrameworkPropertyMetadata(false, csF));
	}

	internal static bool oBu()
	{
		return tBV == null;
	}

	internal static EnumListBoxItem sBH()
	{
		return tBV;
	}
}
