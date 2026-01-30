using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Compatibility;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class EditableContentControl : ContentControl
{
	private bool GAJ;

	public static readonly DependencyProperty EditableContentProperty;

	public static readonly DependencyProperty IsEditingProperty;

	private static EditableContentControl CGJ;

	public object EditableContent
	{
		get
		{
			return GetValue(EditableContentProperty);
		}
		set
		{
			SetValue(EditableContentProperty, value);
		}
	}

	public bool IsEditing
	{
		get
		{
			return (bool)GetValue(IsEditingProperty);
		}
		set
		{
			SetValue(IsEditingProperty, value);
		}
	}

	public EditableContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EditableContentControl);
		base.LayoutUpdated += hAi;
		base.Unloaded += DAS;
	}

	private void KAb()
	{
		EditableContent = base.Content;
		GAJ = true;
	}

	private void sAy()
	{
		ClearValue(EditableContentProperty);
		GAJ = false;
	}

	private static void wAf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EditableContentControl editableContentControl = (EditableContentControl)P_0;
		if (true.Equals(P_1.NewValue))
		{
			editableContentControl.KAb();
		}
		else
		{
			editableContentControl.sAy();
		}
	}

	private void hAi(object P_0, object P_1)
	{
		if (!GAJ)
		{
			return;
		}
		GAJ = false;
		Control control = VisualTreeHelperExtended.GetFirstFocusableDescendant(this) as Control;
		bool flag = control != null;
		int num = 0;
		if (!tG3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			if (control is TextBox textBox)
			{
				SelectText(textBox);
			}
			control.Focus();
		}
	}

	private void DAS(object P_0, RoutedEventArgs P_1)
	{
		OA3(_0020: false);
	}

	private void OA3(bool P_0)
	{
		if (!IsEditing)
		{
			return;
		}
		bool flag = CompatibilityHelper.IsFocusWithin(this);
		object obj = null;
		obj = (P_0 ? base.Content : ((!(base.Content is string)) ? EditableContent : (EditableContent ?? string.Empty)));
		IsEditing = false;
		SetContentAfterEditing(obj);
		if (!flag || IsEditing)
		{
			return;
		}
		for (DependencyObject parent = VisualTreeHelper.GetParent(this); parent != null; parent = VisualTreeHelper.GetParent(parent))
		{
			if (parent is Control { IsTabStop: not false } control)
			{
				control.Focus();
				break;
			}
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (!IsEditing)
		{
			return;
		}
		int num = 0;
		if (!tG3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (e != null)
		{
			switch (e.Key)
			{
			case Key.Return:
				OA3(_0020: false);
				e.Handled = true;
				break;
			case Key.Escape:
				OA3(_0020: true);
				e.Handled = true;
				break;
			}
		}
	}

	protected virtual void SelectText(TextBox textBox)
	{
		textBox?.SelectAll();
	}

	protected virtual void SetContentAfterEditing(object editedContent)
	{
		base.Content = editedContent;
	}

	private void EAt()
	{
		if (!base.IsKeyboardFocusWithin)
		{
			ContextMenu contextMenu = Keyboard.FocusedElement as ContextMenu;
			if (contextMenu == null)
			{
				OA3(_0020: false);
			}
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		EAt();
	}

	static EditableContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		EditableContentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114368), typeof(object), typeof(EditableContentControl), new PropertyMetadata(null));
		IsEditingProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114402), typeof(bool), typeof(EditableContentControl), new PropertyMetadata(false, wAf));
	}

	internal static bool tG3()
	{
		return CGJ == null;
	}

	internal static EditableContentControl mGN()
	{
		return CGJ;
	}
}
