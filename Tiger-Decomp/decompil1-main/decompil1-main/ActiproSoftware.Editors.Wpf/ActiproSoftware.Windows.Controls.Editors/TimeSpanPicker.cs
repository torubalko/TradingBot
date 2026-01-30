using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_PartSelector", Type = typeof(Selector))]
[TemplatePart(Name = "PART_ValuePicker", Type = typeof(Int32Picker))]
public class TimeSpanPicker : PickerBase
{
	private bool s0Q;

	private bool O0V;

	private bool N0C;

	private Selector a06;

	private Int32Picker N0M;

	public static readonly DependencyProperty DaysProperty;

	public static readonly DependencyProperty EditablePartsProperty;

	public static readonly DependencyProperty HoursProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MillisecondsProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty MinutesProperty;

	public static readonly DependencyProperty SecondsProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler F0s;

	internal static TimeSpanPicker xaj;

	public int Days
	{
		get
		{
			return (int)GetValue(DaysProperty);
		}
		private set
		{
			SetValue(DaysProperty, value);
		}
	}

	public TimeSpanEditableParts EditableParts
	{
		get
		{
			return (TimeSpanEditableParts)GetValue(EditablePartsProperty);
		}
		set
		{
			SetValue(EditablePartsProperty, value);
		}
	}

	public int Hours
	{
		get
		{
			return (int)GetValue(HoursProperty);
		}
		private set
		{
			SetValue(HoursProperty, value);
		}
	}

	public TimeSpan Maximum
	{
		get
		{
			return (TimeSpan)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public int Milliseconds
	{
		get
		{
			return (int)GetValue(MillisecondsProperty);
		}
		private set
		{
			SetValue(MillisecondsProperty, value);
		}
	}

	public TimeSpan Minimum
	{
		get
		{
			return (TimeSpan)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public int Minutes
	{
		get
		{
			return (int)GetValue(MinutesProperty);
		}
		private set
		{
			SetValue(MinutesProperty, value);
		}
	}

	public int Seconds
	{
		get
		{
			return (int)GetValue(SecondsProperty);
		}
		private set
		{
			SetValue(SecondsProperty, value);
		}
	}

	public TimeSpan SmallChange
	{
		get
		{
			return (TimeSpan)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public TimeSpan Value
	{
		get
		{
			return (TimeSpan)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = F0s;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref F0s, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = F0s;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref F0s, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public TimeSpanPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TimeSpanPicker);
	}

	private string HxS()
	{
		if (Pxe() != null)
		{
			switch (Pxe().SelectedIndex)
			{
			case 0:
				return QdM.AR8(23136);
			case 2:
				return QdM.AR8(23148);
			case 3:
				return QdM.AR8(23166);
			case 4:
				return QdM.AR8(23184);
			}
		}
		return QdM.AR8(23212);
	}

	private static void wx1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanPicker timeSpanPicker = (TimeSpanPicker)P_0;
		timeSpanPicker.uxt();
	}

	private static void gx8(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanPicker timeSpanPicker = (TimeSpanPicker)P_0;
		timeSpanPicker.cxJ(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void Lxr(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanPicker timeSpanPicker = (TimeSpanPicker)P_0;
		timeSpanPicker.cxJ(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void nxv(object P_0, SelectionChangedEventArgs P_1)
	{
		cxJ(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void Kxp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanPicker timeSpanPicker = (TimeSpanPicker)P_0;
		timeSpanPicker.cxJ(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void pxW(object P_0, EventArgs P_1)
	{
		if (N0C || Fx7() == null)
		{
			return;
		}
		try
		{
			O0V = true;
			int days = Days;
			int hours = Hours;
			int minutes = Minutes;
			int seconds = Seconds;
			int milliseconds = Milliseconds;
			int num = 1;
			if (!caG())
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
				{
					string text = HxS();
					string text2 = text;
					if (!(text2 == QdM.AR8(23136)))
					{
						if (!(text2 == QdM.AR8(23212)))
						{
							if (text2 == QdM.AR8(23148))
							{
								Value = new TimeSpan(Days, Hours, Fx7().Value, Seconds, Milliseconds);
							}
							else if (text2 == QdM.AR8(23166))
							{
								Value = new TimeSpan(Days, Hours, Minutes, Fx7().Value, Milliseconds);
							}
							else if (text2 == QdM.AR8(23184))
							{
								Value = new TimeSpan(Days, Hours, Minutes, Seconds, Fx7().Value);
							}
							return;
						}
						Value = new TimeSpan(Days, Fx7().Value, Minutes, Seconds, Milliseconds);
						num = 0;
						if (JaJ() == null)
						{
							num = 0;
						}
						break;
					}
					Value = new TimeSpan(Fx7().Value, Hours, Minutes, Seconds, Milliseconds);
					return;
				}
				case 0:
					return;
				}
			}
		}
		finally
		{
			O0V = false;
		}
	}

	private static void Ixi(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanPicker timeSpanPicker = (TimeSpanPicker)P_0;
		timeSpanPicker.cxJ(_0020: false, _0020: false, _0020: false, _0020: true);
		timeSpanPicker.nxn();
		timeSpanPicker.wxZ();
	}

	[SpecialName]
	private Selector Pxe()
	{
		return a06;
	}

	[SpecialName]
	private void xxk(Selector value)
	{
		if (a06 == value)
		{
			return;
		}
		bool flag = a06 != null;
		int num = 0;
		if (!caG())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			a06.SelectionChanged -= nxv;
		}
		a06 = value;
		if (a06 != null)
		{
			uxt();
			a06.SelectionChanged += nxv;
		}
	}

	private void wxZ()
	{
		F0s?.Invoke(this, EventArgs.Empty);
	}

	private void uxt()
	{
		if (a06 == null || a06.Items.Count < 5)
		{
			return;
		}
		TimeSpanEditableParts editableParts = EditableParts;
		bool flag = (editableParts & TimeSpanEditableParts.Days) == TimeSpanEditableParts.Days;
		bool flag2 = (editableParts & TimeSpanEditableParts.Hours) == TimeSpanEditableParts.Hours;
		bool flag3 = (editableParts & TimeSpanEditableParts.Minutes) == TimeSpanEditableParts.Minutes;
		bool flag4 = (editableParts & TimeSpanEditableParts.Seconds) == TimeSpanEditableParts.Seconds;
		bool flag5 = (editableParts & TimeSpanEditableParts.Milliseconds) == TimeSpanEditableParts.Milliseconds;
		ListBoxItem listBoxItem = a06.Items[0] as ListBoxItem;
		ListBoxItem listBoxItem2 = a06.Items[1] as ListBoxItem;
		ListBoxItem listBoxItem3 = a06.Items[2] as ListBoxItem;
		ListBoxItem listBoxItem4 = a06.Items[3] as ListBoxItem;
		ListBoxItem listBoxItem5 = a06.Items[4] as ListBoxItem;
		if (listBoxItem != null)
		{
			listBoxItem.Visibility = ((!flag) ? Visibility.Collapsed : Visibility.Visible);
		}
		if (listBoxItem2 != null)
		{
			listBoxItem2.Visibility = ((!flag2) ? Visibility.Collapsed : Visibility.Visible);
		}
		if (listBoxItem3 != null)
		{
			listBoxItem3.Visibility = ((!flag3) ? Visibility.Collapsed : Visibility.Visible);
		}
		if (listBoxItem4 != null)
		{
			listBoxItem4.Visibility = ((!flag4) ? Visibility.Collapsed : Visibility.Visible);
		}
		if (listBoxItem5 != null)
		{
			listBoxItem5.Visibility = ((!flag5) ? Visibility.Collapsed : Visibility.Visible);
		}
		bool flag6 = a06.SelectedIndex == -1;
		switch (a06.SelectedIndex)
		{
		case 0:
			flag6 = !flag;
			break;
		case 1:
			flag6 = !flag2;
			break;
		case 2:
			flag6 = !flag3;
			break;
		case 3:
			flag6 = !flag4;
			break;
		case 4:
			flag6 = !flag5;
			break;
		}
		if (flag6)
		{
			if (flag4)
			{
				a06.SelectedIndex = 3;
			}
			else if (flag3)
			{
				a06.SelectedIndex = 2;
			}
			else if (flag2)
			{
				a06.SelectedIndex = 1;
			}
			else if (flag)
			{
				a06.SelectedIndex = 0;
			}
			else if (flag5)
			{
				a06.SelectedIndex = 4;
			}
		}
	}

	private void nxn()
	{
		if (!s0Q)
		{
			s0Q = true;
			try
			{
				TimeSpan value = Value;
				Days = Math.Abs(value.Days);
				Hours = Math.Abs(value.Hours);
				Minutes = Math.Abs(value.Minutes);
				Seconds = Math.Abs(value.Seconds);
				Milliseconds = Math.Abs(value.Milliseconds);
			}
			finally
			{
				s0Q = false;
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void cxJ(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (O0V || Fx7() == null)
		{
			return;
		}
		string text = HxS();
		try
		{
			N0C = true;
			string text2 = HxS();
			string text3 = text2;
			if (!(text3 == QdM.AR8(23136)))
			{
				if (!(text3 == QdM.AR8(23212)))
				{
					if (!(text3 == QdM.AR8(23148)))
					{
						if (!(text3 == QdM.AR8(23166)))
						{
							if (text3 == QdM.AR8(23184))
							{
								if (P_0)
								{
									Fx7().Minimum = 0;
								}
								if (P_1)
								{
									Fx7().Maximum = 999;
								}
								if (P_2)
								{
									Fx7().SmallChange = SmallChange.Milliseconds;
								}
								if (P_3)
								{
									Fx7().Value = Milliseconds;
								}
							}
						}
						else
						{
							if (P_0)
							{
								Fx7().Minimum = 0;
							}
							if (P_1)
							{
								Fx7().Maximum = 59;
							}
							if (P_2)
							{
								Fx7().SmallChange = SmallChange.Seconds;
							}
							if (P_3)
							{
								Fx7().Value = Seconds;
							}
						}
					}
					else
					{
						if (P_0)
						{
							Fx7().Minimum = 0;
						}
						if (P_1)
						{
							Fx7().Maximum = 59;
						}
						if (P_2)
						{
							Fx7().SmallChange = SmallChange.Minutes;
						}
						if (P_3)
						{
							Fx7().Value = Minutes;
						}
					}
				}
				else
				{
					if (P_0)
					{
						Fx7().Minimum = 0;
					}
					if (P_1)
					{
						Fx7().Maximum = 23;
					}
					if (P_2)
					{
						Fx7().SmallChange = SmallChange.Hours;
					}
					if (P_3)
					{
						Fx7().Value = Hours;
					}
				}
			}
			else
			{
				if (P_0)
				{
					Fx7().Minimum = Math.Max(0, Minimum.Days);
				}
				if (P_1)
				{
					Fx7().Maximum = Maximum.Days;
				}
				if (P_2)
				{
					Fx7().SmallChange = SmallChange.Days;
				}
				if (P_3)
				{
					Fx7().Value = Days;
				}
			}
		}
		finally
		{
			N0C = false;
		}
	}

	[SpecialName]
	private Int32Picker Fx7()
	{
		return N0M;
	}

	[SpecialName]
	private void xx4(Int32Picker value)
	{
		if (N0M == value)
		{
			int num = 0;
			if (!caG())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		if (N0M != null)
		{
			N0M.ValueChanged -= pxW;
		}
		N0M = value;
		if (N0M != null)
		{
			N0M.ValueChanged += pxW;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		xxk(GetTemplateChild(QdM.AR8(3528)) as Selector);
		xx4(GetTemplateChild(QdM.AR8(3566)) as Int32Picker);
		cxJ(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static TimeSpanPicker()
	{
		awj.QuEwGz();
		DaysProperty = DependencyProperty.Register(QdM.AR8(23136), typeof(int), typeof(TimeSpanPicker), new PropertyMetadata(0));
		EditablePartsProperty = DependencyProperty.Register(QdM.AR8(23226), typeof(TimeSpanEditableParts), typeof(TimeSpanPicker), new PropertyMetadata(TimeSpanEditableParts.All, wx1));
		HoursProperty = DependencyProperty.Register(QdM.AR8(23212), typeof(int), typeof(TimeSpanPicker), new PropertyMetadata(0));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(TimeSpan), typeof(TimeSpanPicker), new PropertyMetadata(xdU.WuV, gx8));
		MillisecondsProperty = DependencyProperty.Register(QdM.AR8(23184), typeof(int), typeof(TimeSpanPicker), new PropertyMetadata(0));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(TimeSpan), typeof(TimeSpanPicker), new PropertyMetadata(TimeSpan.Zero, Lxr));
		MinutesProperty = DependencyProperty.Register(QdM.AR8(23148), typeof(int), typeof(TimeSpanPicker), new PropertyMetadata(0));
		SecondsProperty = DependencyProperty.Register(QdM.AR8(23166), typeof(int), typeof(TimeSpanPicker), new PropertyMetadata(0));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(TimeSpan), typeof(TimeSpanPicker), new PropertyMetadata(xdU.Wu6, Kxp));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(TimeSpan), typeof(TimeSpanPicker), new PropertyMetadata(xdU.duM, Ixi));
	}

	internal static bool caG()
	{
		return xaj == null;
	}

	internal static TimeSpanPicker JaJ()
	{
		return xaj;
	}
}
