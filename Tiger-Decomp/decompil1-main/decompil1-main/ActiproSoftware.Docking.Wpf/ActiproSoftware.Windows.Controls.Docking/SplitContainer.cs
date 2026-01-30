using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking;

[ContentProperty("Children")]
[TemplatePart(Name = "PART_Panel", Type = typeof(SplitContainerPanel))]
[ToolboxItem(false)]
public class SplitContainer : Control, IOrientedElement, wH, lX
{
	[CompilerGenerated]
	private sealed class _003Cget_LogicalChildren_003Ed__31 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SplitContainer _003C_003E4__this;

		private IEnumerator _003CbaseEnumerator_003E5__2;

		private IEnumerator<DependencyObject> _003C_003E7__wrap2;

		internal static _003Cget_LogicalChildren_003Ed__31 CGR;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003Cget_LogicalChildren_003Ed__31(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3 && num != 2)
			{
				return;
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				SplitContainer splitContainer = _003C_003E4__this;
				int num2;
				int num3 = default(int);
				DependencyObject current2;
				switch (num)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003CbaseEnumerator_003E5__2 = ((FrameworkElement)splitContainer).LogicalChildren;
					if (_003CbaseEnumerator_003E5__2 == null)
					{
						goto IL_00d8;
					}
					goto IL_00f3;
				case 2:
					_003C_003E1__state = -3;
					goto IL_017a;
				case 1:
					{
						_003C_003E1__state = -1;
						goto IL_00f3;
					}
					IL_00f3:
					while (_003CbaseEnumerator_003E5__2.MoveNext())
					{
						object current = _003CbaseEnumerator_003E5__2.Current;
						if (current != null)
						{
							_003C_003E2__current = current;
							_003C_003E1__state = 1;
							return true;
						}
					}
					num2 = 1;
					if (!MGD())
					{
						goto IL_000e;
					}
					goto IL_0012;
					IL_000e:
					num2 = num3;
					goto IL_0012;
					IL_00d8:
					if (splitContainer.gan != null)
					{
						break;
					}
					_003C_003E7__wrap2 = splitContainer.oaK.OfType<DependencyObject>().GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_017a;
					IL_0012:
					switch (num2)
					{
					case 2:
						break;
					default:
						return true;
					case 1:
						goto IL_00d8;
					}
					goto IL_003d;
					IL_017a:
					if (!_003C_003E7__wrap2.MoveNext())
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap2 = null;
						break;
					}
					goto IL_003d;
					IL_003d:
					current2 = _003C_003E7__wrap2.Current;
					_003C_003E2__current = current2;
					_003C_003E1__state = 2;
					num2 = 0;
					if (!MGD())
					{
						goto IL_000e;
					}
					goto IL_0012;
				}
				return false;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		internal static bool MGD()
		{
			return CGR == null;
		}

		internal static _003Cget_LogicalChildren_003Ed__31 SGE()
		{
			return CGR;
		}
	}

	private ObservableCollection<FrameworkElement> oaK;

	private DockHost taJ;

	private SplitContainerPanel gan;

	public static readonly DependencyProperty OrientationProperty;

	[CompilerGenerated]
	private bool iaO;

	private Size? baT;

	internal static SplitContainer NHK;

	public ObservableCollection<FrameworkElement> Children => oaK;

	public DockHost DockHost
	{
		get
		{
			return taJ;
		}
		private set
		{
			taJ = value;
			foreach (wH item in oaK.OfType<wH>())
			{
				item.DockHost = value;
			}
		}
	}

	public DockSite DockSite
	{
		get
		{
			if (taJ == null)
			{
				return null;
			}
			return taJ.DockSite;
		}
	}

	protected override IEnumerator LogicalChildren
	{
		get
		{
			IEnumerator baseEnumerator = base.LogicalChildren;
			if (baseEnumerator != null)
			{
				while (baseEnumerator.MoveNext())
				{
					object current = baseEnumerator.Current;
					if (current != null)
					{
						yield return current;
					}
				}
				int num = 1;
				if (!_003Cget_LogicalChildren_003Ed__31.MGD())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 2:
					goto IL_003d;
				default:
					/*Error near IL_020b: Unexpected return in MoveNext()*/;
				case 1:
					break;
				}
			}
			if (gan != null)
			{
				yield break;
			}
			using IEnumerator<DependencyObject> enumerator = oaK.OfType<DependencyObject>().GetEnumerator();
			if (enumerator.MoveNext())
			{
				goto IL_003d;
			}
			goto end_IL_0033;
			IL_003d:
			yield return enumerator.Current;
			/*Error: Unable to find 'return true' for yield return*/;
			end_IL_0033:;
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

	bool wH.ContainsDockingWindows => na1();

	bool wH.ContainsWorkspace => KaQ();

	Size wH.DockedSize
	{
		get
		{
			return Daa();
		}
		set
		{
			WaW(value);
		}
	}

	DockHost wH.DockHost
	{
		get
		{
			return DockHost;
		}
		set
		{
			DockHost = value;
		}
	}

	Size wH.MaxSize
	{
		get
		{
			if (gan == null)
			{
				return new Size(double.PositiveInfinity, double.PositiveInfinity);
			}
			return gan.VEg();
		}
	}

	Size wH.MinSize
	{
		get
		{
			if (gan == null)
			{
				return default(Size);
			}
			return gan.mEX();
		}
	}

	IEnumerable<lX> lX.ChildNodes => oaK.OfType<lX>();

	public SplitContainer()
	{
		IVH.CecNqz();
		oaK = new ObservableCollection<FrameworkElement>();
		base._002Ector();
		base.DefaultStyleKey = typeof(SplitContainer);
		oaK.CollectionChanged += Smo;
	}

	internal SplitContainer(DockHost dockHost)
	{
		IVH.CecNqz();
		this._002Ector();
		if (dockHost == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		DockHost = dockHost;
	}

	internal static Do Omh<Do>(Control P_0, bool P_1) where Do : IDockTarget, Control, G0
	{
		if (P_0 != null)
		{
			Tuple<SplitContainer, Control> tuple = Lm5(P_0);
			if (tuple != null)
			{
				SplitContainer item = tuple.Item1;
				if (item != null)
				{
					int num = item.Children.IndexOf(P_0);
					if (num != -1)
					{
						Do val = kmg<Do>(item, num, P_1);
						if (val != null)
						{
							return val;
						}
					}
					return Omh<Do>(item, P_1);
				}
			}
		}
		return null;
	}

	private static vd kmg<vd>(SplitContainer P_0, int P_1, bool P_2) where vd : G0, IDockTarget, Control
	{
		if (P_0 != null)
		{
			int num = (P_2 ? 1 : (-1));
			for (int i = (P_1 += num); P_2 ? (i < P_0.Children.Count) : (i >= 0); i += num)
			{
				Control control = P_0.Children[i] as Control;
				if (control is vd val && val.Windows.Any())
				{
					return val;
				}
				if (control is SplitContainer splitContainer)
				{
					vd val2 = kmg<vd>(splitContainer, P_2 ? (-1) : splitContainer.Children.Count, P_2);
					if (val2 != null && val2.Windows.Any())
					{
						return val2;
					}
				}
			}
		}
		return null;
	}

	internal Tuple<int, int, wH, wH> PmX(Control P_0)
	{
		FrameworkElement[] array = oaK.Where((FrameworkElement c) => c.Visibility == Visibility.Visible).ToArray();
		int num = Array.IndexOf(array, P_0);
		FrameworkElement frameworkElement = ((num > 0) ? array[num - 1] : null);
		FrameworkElement frameworkElement2 = ((num != -1 && num < array.Length - 1) ? array[num + 1] : null);
		return Tuple.Create(num, array.Length, frameworkElement as wH, frameworkElement2 as wH);
	}

	internal static Tuple<SplitContainer, Control> Lm5(Control P_0)
	{
		if (P_0 != null)
		{
			if (VisualTreeHelper.GetParent(P_0) is SplitContainerPanel splitContainerPanel)
			{
				SplitContainer splitContainer = splitContainerPanel.xEA();
				if (splitContainer != null)
				{
					return Tuple.Create(splitContainer, P_0);
				}
			}
			else if (P_0 is wH { DockHost: { } dockHost } && dockHost.veR() == P_0 && dockHost.Workspace != null && VisualTreeHelper.GetParent(dockHost.Workspace) is SplitContainerPanel splitContainerPanel2)
			{
				SplitContainer splitContainer2 = splitContainerPanel2.xEA();
				if (splitContainer2 != null)
				{
					return Tuple.Create(splitContainer2, (Control)dockHost.Workspace);
				}
			}
		}
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool law()
	{
		return iaO;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Ha2(bool value)
	{
		iaO = value;
	}

	internal void wmy(int P_0, FrameworkElement P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		P_0 = Math.Max(0, Math.Min(Children.Count, P_0));
		SplitContainer splitContainer = P_1 as SplitContainer;
		Orientation? obj = splitContainer?.Orientation;
		if (Orientation == obj)
		{
			amu(splitContainer.Children.ToArray());
			for (int num = splitContainer.Children.Count - 1; num >= 0; num--)
			{
				FrameworkElement item = splitContainer.Children[num];
				splitContainer.Children.RemoveAt(num);
				Children.Insert(P_0, item);
			}
		}
		else
		{
			amu(new FrameworkElement[1] { P_1 });
			Children.Insert(P_0, P_1);
		}
	}

	private void Smo(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1.Action != NotifyCollectionChangedAction.Reset || DesignerProperties.GetIsInDesignMode(this))
		{
			if (P_1.OldItems != null)
			{
				foreach (wH item in P_1.OldItems.OfType<wH>())
				{
					if (!law())
					{
						item.DockHost = null;
					}
				}
			}
			if (P_1.NewItems != null)
			{
				foreach (wH item2 in P_1.NewItems.OfType<wH>())
				{
					item2.DockHost = taJ;
				}
			}
			if (gan != null)
			{
				gan.SlotElements.BeginUpdate();
				if (P_1.OldItems != null)
				{
					foreach (UIElement item3 in P_1.OldItems.OfType<UIElement>())
					{
						gan.SlotElements.Remove(item3);
					}
				}
				if (P_1.NewItems != null)
				{
					int num = ((gan != null) ? Math.Max(0, Math.Min(gan.SlotElements.Count, P_1.NewStartingIndex)) : 0);
					foreach (UIElement item4 in P_1.NewItems.OfType<UIElement>())
					{
						gan.SlotElements.Insert(num++, item4);
					}
				}
				gan.SlotElements.EndUpdate();
				return;
			}
			if (P_1.OldItems != null)
			{
				IEnumerator<DependencyObject> enumerator3;
				int num3 = default(int);
				while (true)
				{
					enumerator3 = P_1.OldItems.OfType<DependencyObject>().GetEnumerator();
					int num2 = 1;
					if (!wHG())
					{
						num2 = num3;
					}
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						continue;
					case 1:
						break;
					}
					break;
				}
				try
				{
					while (enumerator3.MoveNext())
					{
						DependencyObject current4 = enumerator3.Current;
						if (LogicalTreeHelper.GetParent(current4) == this)
						{
							RemoveLogicalChild(current4);
						}
					}
				}
				finally
				{
					enumerator3?.Dispose();
				}
			}
			if (P_1.NewItems == null)
			{
				return;
			}
			{
				foreach (DependencyObject item5 in P_1.NewItems.OfType<DependencyObject>())
				{
					if (LogicalTreeHelper.GetParent(item5) == null)
					{
						AddLogicalChild(item5);
					}
				}
				return;
			}
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExSplitContainerChildrenCollectionReset));
	}

	[SpecialName]
	internal SplitContainerPanel naG()
	{
		return gan;
	}

	[SpecialName]
	private void YaI(SplitContainerPanel value)
	{
		if (gan != null)
		{
			gan.SlotElements.Clear();
		}
		gan = value;
		if (gan == null)
		{
			return;
		}
		gan.SlotElements.BeginUpdate();
		try
		{
			foreach (FrameworkElement item in oaK)
			{
				DependencyObject dependencyObject = item;
				if (dependencyObject != null && LogicalTreeHelper.GetParent(dependencyObject) == this)
				{
					RemoveLogicalChild(dependencyObject);
				}
				gan.SlotElements.Add(item);
			}
		}
		finally
		{
			gan.SlotElements.EndUpdate();
		}
	}

	internal void Ymt(int P_0, FrameworkElement P_1)
	{
		if (P_1 != null)
		{
			FrameworkElement frameworkElement = Children[P_0];
			wH wH = frameworkElement as wH;
			wH wH2 = P_1 as wH;
			double slotLength = SplitContainerPanel.GetSlotLength(frameworkElement);
			SplitContainerPanel.SetSlotLength(P_1, slotLength);
			if (wH != null && wH2 != null)
			{
				wH2.DockedSize = wH.DockedSize;
			}
			Ha2(value: true);
			Children.RemoveAt(P_0);
			Ha2(value: false);
			Children.Insert(P_0, P_1);
		}
	}

	private void amu(FrameworkElement[] P_0)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			return;
		}
		if (gan != null && !gan.IsMeasureValid && base.RenderSize.Width > 0.0 && base.RenderSize.Height > 0.0)
		{
			gan.Measure(base.RenderSize);
			gan.Arrange(new Rect(default(Point), base.RenderSize));
			gan.nEz();
		}
		double num = DockSite?.SplitterSize ?? 5.0;
		UIElement[] array2;
		UIElement[] array;
		if (gan == null)
		{
			array = oaK.ToArray();
			array2 = array;
		}
		else
		{
			array2 = gan.GEy().ToArray();
		}
		double num2 = (double)(array2.Length - 1) * num;
		double num3 = 0.0;
		List<Tuple<wH, double, double>> list = new List<Tuple<wH, double, double>>();
		Tuple<wH, double, double> tuple = null;
		array = array2;
		foreach (UIElement uIElement in array)
		{
			if (!(uIElement is wH wH))
			{
				continue;
			}
			double num4 = Math.Max(30.0, this.GetSizeExtent(wH.MinSize));
			double sizeExtent = this.GetSizeExtent(uIElement.RenderSize);
			num2 += sizeExtent;
			if (sizeExtent > num4)
			{
				Tuple<wH, double, double> tuple2 = Tuple.Create(wH, num4, sizeExtent);
				if (tuple == null && wH.ContainsWorkspace)
				{
					tuple = tuple2;
					continue;
				}
				num3 += sizeExtent - num4;
				list.Add(tuple2);
			}
		}
		double num5 = (double)P_0.Length * num;
		for (int i = 0; i < P_0.Length; i++)
		{
			num5 = ((!(P_0[i] is wH wH2)) ? (num5 + this.GetSizeExtent(new Size(200.0, 200.0))) : (num5 + this.GetSizeExtent(wH2.DockedSize)));
		}
		double num6 = Math.Max(0.0, Math.Min(num2 / 2.0, num5));
		if (num6 > 0.0 && tuple != null)
		{
			wH item = tuple.Item1;
			double item2 = tuple.Item2;
			double item3 = tuple.Item3;
			double num7 = Math.Max(item2, item3 - num6);
			if (num7 < item3)
			{
				num6 = Math.Max(0.0, num6 - (item3 - num7));
				item.DockedSize = this.CreateSize(num7, this.GetSizeAscent(item.DockedSize));
			}
		}
		if (!(num6 > 0.0))
		{
			return;
		}
		foreach (Tuple<wH, double, double> item7 in list)
		{
			wH item4 = item7.Item1;
			double item5 = item7.Item2;
			double item6 = item7.Item3;
			double num8 = (item6 - item5) / num3 * num6;
			double extent = Math.Max(item5, item6 - num8);
			item4.DockedSize = this.CreateSize(extent, this.GetSizeAscent(item4.DockedSize));
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		YaI(GetTemplateChild(vVK.ssH(15330)) as SplitContainerPanel);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new SplitContainerAutomationPeer(this);
	}

	public void ResizeSlots(params double[] desiredRatios)
	{
		if (gan == null)
		{
			return;
		}
		double sizeExtent = gan.GetSizeExtent(new Rect(0.0, 0.0, gan.ActualWidth, gan.ActualHeight));
		double num = gan.BE0();
		double num2 = (double)gan.TEH() * num;
		UIElement[] array = gan.GEy().ToArray();
		sizeExtent = Math.Max(0.0, sizeExtent - num2);
		double num3 = sizeExtent;
		if (desiredRatios != null && desiredRatios.Length > 1)
		{
			if (desiredRatios.Any((double r) => r <= 0.0))
			{
				throw new ArgumentOutOfRangeException(vVK.ssH(15354), SR.GetString(SRName.ExSplitContainerSlotResizeRatioMustBeGreaterThanZero));
			}
			double num4 = desiredRatios.Sum();
			List<double> list = new List<double>(desiredRatios);
			while (list.Count < array.Length)
			{
				list.Add(desiredRatios[desiredRatios.Length - 1]);
			}
			for (int num5 = 0; num5 < array.Length - 1; num5++)
			{
				double num6 = Math.Floor(list[num5] / num4 * sizeExtent);
				num3 -= num6;
				if (array[num5] is wH wH)
				{
					wH.DockedSize = gan.CreateSize(num6, gan.GetSizeAscent(wH.DockedSize));
				}
			}
		}
		else if (array.Length != 0)
		{
			double num7 = Math.Floor(sizeExtent / (double)array.Length);
			for (int num8 = 0; num8 < array.Length - 1; num8++)
			{
				num3 -= num7;
				if (array[num8] is wH wH2)
				{
					wH2.DockedSize = gan.CreateSize(num7, gan.GetSizeAscent(wH2.DockedSize));
				}
			}
		}
		if (array.Length != 0 && array[array.Length - 1] is wH wH3)
		{
			wH3.DockedSize = gan.CreateSize(num3, gan.GetSizeAscent(wH3.DockedSize));
		}
		gan.InvalidateMeasure();
	}

	public void ReverseSlots()
	{
		for (int i = 1; i < oaK.Count; i++)
		{
			oaK.Move(i, 0);
		}
		InvalidateMeasure();
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, vVK.ssH(15384), new object[3]
		{
			GetType().Name,
			Orientation,
			oaK.Count
		});
	}

	int wH.GetVisibleToolWindowContainerCount()
	{
		return Gmz();
	}

	[SpecialName]
	private bool na1()
	{
		foreach (FrameworkElement item in oaK)
		{
			if (item is wH { ContainsDockingWindows: not false })
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	internal bool KaQ()
	{
		foreach (FrameworkElement item in oaK)
		{
			if (Kai(item))
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	internal Size Daa()
	{
		if (!baT.HasValue)
		{
			if (gan != null)
			{
				baT = gan.VEh();
			}
			else
			{
				baT = new Size(200.0, 200.0);
			}
		}
		return baT.Value;
	}

	[SpecialName]
	internal void WaW(Size value)
	{
		baT = value;
	}

	private int Gmz()
	{
		int num = 0;
		foreach (FrameworkElement item in oaK)
		{
			if (item is wH wH)
			{
				num += wH.GetVisibleToolWindowContainerCount();
			}
		}
		return num;
	}

	private static bool Kai(FrameworkElement P_0)
	{
		if (P_0 is wH wH)
		{
			return wH.ContainsWorkspace;
		}
		return false;
	}

	static SplitContainer()
	{
		IVH.CecNqz();
		OrientationProperty = DependencyProperty.Register(vVK.ssH(15456), typeof(Orientation), typeof(SplitContainer), new PropertyMetadata(Orientation.Horizontal));
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator lad()
	{
		return base.LogicalChildren;
	}

	internal static bool wHG()
	{
		return NHK == null;
	}

	internal static SplitContainer DHc()
	{
		return NHK;
	}
}
