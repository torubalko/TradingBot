using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplateVisualState(Name = "ExcludesToday", GroupName = "ContainsTodayStates")]
[ToolboxItem(false)]
[TemplateVisualState(Name = "ContainsToday", GroupName = "ContainsTodayStates")]
[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
[TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
[TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
[TemplateVisualState(Name = "SelectedPointerOver", GroupName = "SelectionStates")]
public class MonthCalendarItem : ContentControl
{
	private InputAdapter cfX;

	private bool Lfx;

	private bool Of0;

	public static readonly DependencyProperty CommandProperty;

	public static readonly DependencyProperty CommandParameterProperty;

	public static readonly DependencyProperty ContainsTodayProperty;

	public static readonly DependencyProperty IsHeaderProperty;

	public static readonly DependencyProperty IsInactiveProperty;

	public static readonly DependencyProperty IsPressedProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	internal static MonthCalendarItem LW2;

	public ICommand Command
	{
		get
		{
			return (ICommand)GetValue(CommandProperty);
		}
		set
		{
			SetValue(CommandProperty, value);
		}
	}

	public object CommandParameter
	{
		get
		{
			return GetValue(CommandParameterProperty);
		}
		set
		{
			SetValue(CommandParameterProperty, value);
		}
	}

	public bool ContainsToday
	{
		get
		{
			return (bool)GetValue(ContainsTodayProperty);
		}
		set
		{
			SetValue(ContainsTodayProperty, value);
		}
	}

	public DateTime? Date => base.DataContext as DateTime?;

	public bool IsHeader
	{
		get
		{
			return (bool)GetValue(IsHeaderProperty);
		}
		set
		{
			SetValue(IsHeaderProperty, value);
		}
	}

	public bool IsInactive
	{
		get
		{
			return (bool)GetValue(IsInactiveProperty);
		}
		set
		{
			SetValue(IsInactiveProperty, value);
		}
	}

	public bool IsPressed
	{
		get
		{
			return (bool)GetValue(IsPressedProperty);
		}
		private set
		{
			SetValue(IsPressedProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public MonthCalendarItem()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(MonthCalendarItem);
		VfC();
	}

	private void VfC()
	{
		cfX = new InputAdapter(this);
		cfX.PointerCaptureLost += nf6;
		cfX.PointerEntered += mfM;
		cfX.PointerExited += jfs;
		cfX.PointerMoved += ffj;
		cfX.PointerPressed += LfP;
		cfX.PointerReleased += Hf2;
		cfX.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	private void nf6(object P_0, InputPointerEventArgs P_1)
	{
		if (Of0 || IsPressed)
		{
			Of0 = false;
			IsPressed = false;
			Jff(_0020: true);
		}
	}

	private void mfM(object P_0, InputPointerEventArgs P_1)
	{
		Of0 = true;
		Jff(_0020: true);
	}

	private void jfs(object P_0, InputPointerEventArgs P_1)
	{
		Of0 = false;
		Jff(_0020: true);
	}

	private void ffj(object P_0, InputPointerEventArgs P_1)
	{
		Of0 = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight).Contains(P_1.GetPosition(this));
		Jff(_0020: true);
	}

	private void LfP(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null)
		{
			cfX.CapturePointer(P_1);
		}
		IsPressed = true;
		Jff(_0020: true);
		bool flag = !P_1.Handled;
		int num = 0;
		if (mWV() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			Focus();
			P_1.Handled = true;
		}
	}

	private void Hf2(object P_0, InputPointerButtonEventArgs P_1)
	{
		bool flag = IsPressed && Of0;
		IsPressed = false;
		Jff(_0020: true);
		cfX.ReleasePointerCaptures();
		if (flag)
		{
			if (Command != null && Command.CanExecute(CommandParameter))
			{
				Command.Execute(CommandParameter);
			}
			P_1.Handled = true;
		}
	}

	private static void ifa(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendarItem monthCalendarItem = (MonthCalendarItem)P_0;
		monthCalendarItem.Jff(_0020: true);
	}

	private void Jff(bool P_0)
	{
		if (base.IsEnabled)
		{
			bool flag = Of0 && !IsHeader;
			int num = 1;
			if (!MWl())
			{
				num = 1;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						VisualStateManager.GoToState(this, QdM.AR8(64), P_0);
						num = 2;
						if (MWl())
						{
							continue;
						}
					}
					else
					{
						if (!IsPressed)
						{
							if (!IsSelected)
							{
								VisualStateManager.GoToState(this, QdM.AR8(38), P_0);
								VisualStateManager.GoToState(this, QdM.AR8(21914), P_0);
							}
							else
							{
								VisualStateManager.GoToState(this, QdM.AR8(64), P_0);
								VisualStateManager.GoToState(this, QdM.AR8(21976), P_0);
							}
							break;
						}
						num = 0;
						if (MWl())
						{
							continue;
						}
					}
					num = num2;
					continue;
				default:
					VisualStateManager.GoToState(this, QdM.AR8(21958), P_0);
					VisualStateManager.GoToState(this, QdM.AR8(21914), P_0);
					break;
				case 2:
					VisualStateManager.GoToState(this, IsSelected ? QdM.AR8(21938) : QdM.AR8(21914), P_0);
					break;
				}
				break;
			}
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(0), P_0);
			VisualStateManager.GoToState(this, IsSelected ? QdM.AR8(21938) : QdM.AR8(21914), P_0);
		}
		VisualStateManager.GoToState(this, ContainsToday ? QdM.AR8(22048) : QdM.AR8(22018), P_0);
		VisualStateManager.GoToState(this, Lfx ? QdM.AR8(20) : QdM.AR8(2148), P_0);
		VisualStateManager.GoToState(this, (IsInactive || !base.IsEnabled) ? QdM.AR8(22094) : QdM.AR8(22078), P_0);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Jff(_0020: false);
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		Lfx = true;
		Jff(_0020: true);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(QdM.AR8(20288));
		}
		base.OnKeyDown(e);
		if (!e.Handled)
		{
			Key key = e.Key;
			Key key2 = key;
			if ((key2 == Key.Return || key2 == Key.Space) && Command != null && Command.CanExecute(CommandParameter))
			{
				Command.Execute(CommandParameter);
				e.Handled = true;
			}
		}
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		Lfx = false;
		Jff(_0020: true);
	}

	static MonthCalendarItem()
	{
		awj.QuEwGz();
		CommandProperty = DependencyProperty.Register(QdM.AR8(22114), typeof(ICommand), typeof(MonthCalendarItem), new PropertyMetadata(null));
		CommandParameterProperty = DependencyProperty.Register(QdM.AR8(22132), typeof(object), typeof(MonthCalendarItem), new PropertyMetadata(null));
		ContainsTodayProperty = DependencyProperty.Register(QdM.AR8(22048), typeof(bool), typeof(MonthCalendarItem), new PropertyMetadata(false, ifa));
		IsHeaderProperty = DependencyProperty.Register(QdM.AR8(22168), typeof(bool), typeof(MonthCalendarItem), new PropertyMetadata(false, ifa));
		IsInactiveProperty = DependencyProperty.Register(QdM.AR8(22188), typeof(bool), typeof(MonthCalendarItem), new PropertyMetadata(false, ifa));
		IsPressedProperty = DependencyProperty.Register(QdM.AR8(22212), typeof(bool), typeof(MonthCalendarItem), new PropertyMetadata(false, ifa));
		IsSelectedProperty = DependencyProperty.Register(QdM.AR8(22234), typeof(bool), typeof(MonthCalendarItem), new PropertyMetadata(false, ifa));
	}

	internal static bool MWl()
	{
		return LW2 == null;
	}

	internal static MonthCalendarItem mWV()
	{
		return LW2;
	}
}
