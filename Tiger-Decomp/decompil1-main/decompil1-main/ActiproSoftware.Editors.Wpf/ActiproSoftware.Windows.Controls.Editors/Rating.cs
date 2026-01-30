using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

public class Rating : ItemsControl, IOrientedElement
{
	private InputAdapter sll;

	private DelegateCommand<object> GlX;

	private bool Qlx;

	private RatingPanel wl0;

	private int OlY;

	public static readonly DependencyProperty AverageValueProperty;

	public static readonly DependencyProperty ItemCountProperty;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler Alg;

	private static Rating ErA;

	public double AverageValue
	{
		get
		{
			return (double)GetValue(AverageValueProperty);
		}
		set
		{
			SetValue(AverageValueProperty, value);
		}
	}

	public ICommand ClearValueCommand
	{
		get
		{
			if (GlX == null)
			{
				GlX = new DelegateCommand<object>(delegate
				{
					Value = null;
				});
			}
			return GlX;
		}
	}

	public int ItemCount
	{
		get
		{
			return (int)GetValue(ItemCountProperty);
		}
		set
		{
			SetValue(ItemCountProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public double? Value
	{
		get
		{
			return (double?)GetValue(ValueProperty);
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
			EventHandler eventHandler = Alg;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Alg, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Alg;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Alg, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Rating()
	{
		awj.QuEwGz();
		OlY = -1;
		base._002Ector();
		base.DefaultStyleKey = typeof(Rating);
		Hf4();
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
	}

	private void Hf4()
	{
		sll = new InputAdapter(this);
		sll.PointerExited += yfU;
		sll.PointerMoved += sfz;
		sll.PointerPressed += OlQ;
		sll.AttachedEventKinds = InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed;
	}

	private RatingItem jfB(int P_0)
	{
		if (P_0 >= 0 && P_0 < base.Items.Count)
		{
			return (base.Items[P_0] as RatingItem) ?? (base.ItemContainerGenerator.ContainerFromIndex(P_0) as RatingItem);
		}
		return null;
	}

	private int efh(InputPointerEventArgs P_0)
	{
		if (P_0 != null)
		{
			for (int i = 0; i < base.Items.Count; i++)
			{
				RatingItem ratingItem = jfB(i);
				if (ratingItem != null && P_0.IsPositionOver(ratingItem))
				{
					return i;
				}
			}
		}
		return -1;
	}

	[SpecialName]
	internal RatingPanel Pls()
	{
		return wl0;
	}

	[SpecialName]
	internal void Llj(RatingPanel value)
	{
		if (wl0 == value)
		{
			return;
		}
		if (wl0 != null)
		{
			BindingOperations.ClearBinding(wl0, StackPanel.OrientationProperty);
		}
		wl0 = value;
		if (wl0 != null)
		{
			wl0.BindToProperty(StackPanel.OrientationProperty, this, QdM.AR8(22356), BindingMode.OneWay);
			int num = 0;
			if (bre() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private static void yfw(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Rating rating = (Rating)P_0;
		rating.Tl6();
	}

	private static void xfN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Rating rating = (Rating)P_0;
		if (rating.Qlx)
		{
			return;
		}
		try
		{
			rating.Qlx = true;
			int num = Math.Max(0, (int)P_1.NewValue);
			while (rating.Items.Count > num)
			{
				rating.Items.RemoveAt(rating.Items.Count - 1);
			}
			int num3 = default(int);
			while (true)
			{
				bool flag = rating.Items.Count < num;
				int num2 = 0;
				if (bre() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				default:
					if (!flag)
					{
						break;
					}
					rating.Items.Add(new RatingItem());
					continue;
				}
				break;
			}
		}
		finally
		{
			rating.Qlx = false;
		}
		rating.Tl6();
	}

	private void yfU(object P_0, InputPointerEventArgs P_1)
	{
		Lla(-1);
	}

	private void sfz(object P_0, InputPointerEventArgs P_1)
	{
		Lla(efh(P_1));
	}

	private void OlQ(object P_0, InputPointerButtonEventArgs P_1)
	{
		int num = efh(P_1);
		if (num != -1)
		{
			Value = num + 1;
		}
		Focus();
		P_1.Handled = true;
	}

	private static void ilV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Rating rating = (Rating)P_0;
		rating.Tl6();
		rating.jlC();
	}

	[SpecialName]
	private int zl2()
	{
		return OlY;
	}

	[SpecialName]
	private void Lla(int value)
	{
		if (OlY != value)
		{
			OlY = value;
			Tl6();
		}
	}

	private void jlC()
	{
		Alg?.Invoke(this, EventArgs.Empty);
	}

	private void Tl6()
	{
		double averageValue = AverageValue;
		Orientation value = ((Orientation == Orientation.Horizontal) ? Orientation.Vertical : Orientation.Horizontal);
		for (int i = 0; i < base.Items.Count; i++)
		{
			RatingItem ratingItem = jfB(i);
			if (ratingItem == null)
			{
				continue;
			}
			if (OlY >= i)
			{
				ratingItem.State = RatingItemState.Active;
				ratingItem.ClipPercentage = double.NaN;
			}
			else if (OlY == -1 && Value.HasValue && Value.Value > (double)i)
			{
				ratingItem.State = RatingItemState.Selected;
				ratingItem.ClipPercentage = double.NaN;
			}
			else if (OlY == -1 && !Value.HasValue && averageValue > (double)i)
			{
				ratingItem.State = RatingItemState.Average;
				if (averageValue < (double)(i + 1))
				{
					ratingItem.ClipPercentage = averageValue - (double)i;
				}
				else
				{
					ratingItem.ClipPercentage = double.NaN;
				}
			}
			else
			{
				ratingItem.State = RatingItemState.Normal;
				ratingItem.ClipPercentage = double.NaN;
			}
			ratingItem.Orientation = value;
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new RatingAutomationPeer(this);
	}

	protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
	{
		base.OnItemsChanged(e);
		if (!Qlx)
		{
			try
			{
				Qlx = true;
				ItemCount = base.Items.Count;
			}
			finally
			{
				Qlx = false;
			}
			Tl6();
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e == null || e.Handled || !base.IsEnabled || ItemCount <= 0)
		{
			return;
		}
		switch (e.Key)
		{
		case Key.Prior:
		case Key.Up:
		case Key.Right:
		case Key.Add:
		case Key.OemPlus:
			e.Handled = true;
			if (Value.HasValue)
			{
				Value = Math.Max(1.0, Math.Min(ItemCount, Value.Value + 1.0));
			}
			else
			{
				Value = ItemCount;
			}
			break;
		case Key.Next:
		case Key.Left:
		case Key.Down:
		case Key.Subtract:
		case Key.OemMinus:
			e.Handled = true;
			if (Value.HasValue)
			{
				Value = Math.Max(1.0, Math.Min(ItemCount, Value.Value - 1.0));
			}
			else
			{
				Value = 1.0;
			}
			break;
		}
	}

	static Rating()
	{
		awj.QuEwGz();
		AverageValueProperty = DependencyProperty.Register(QdM.AR8(22382), typeof(double), typeof(Rating), new PropertyMetadata(0.0, yfw));
		ItemCountProperty = DependencyProperty.Register(QdM.AR8(22410), typeof(int), typeof(Rating), new PropertyMetadata(0, xfN));
		OrientationProperty = DependencyProperty.Register(QdM.AR8(22356), typeof(Orientation), typeof(Rating), new PropertyMetadata(Orientation.Horizontal));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(double?), typeof(Rating), new PropertyMetadata(null, ilV));
	}

	[CompilerGenerated]
	private void clM(object P_0)
	{
		Value = null;
	}

	internal static bool Hrt()
	{
		return ErA == null;
	}

	internal static Rating bre()
	{
		return ErA;
	}
}
