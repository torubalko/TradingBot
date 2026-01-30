using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class SplitContainerPanel : Panel, IOrientedElement
{
	private class dVq
	{
		[CompilerGenerated]
		private double w6h;

		[CompilerGenerated]
		private double F6g;

		[CompilerGenerated]
		private UIElement G6X;

		[CompilerGenerated]
		private double e65;

		[CompilerGenerated]
		private double I6y;

		[CompilerGenerated]
		private double J6o;

		internal static dVq BM8;

		[SpecialName]
		[CompilerGenerated]
		public double R69()
		{
			return w6h;
		}

		[SpecialName]
		[CompilerGenerated]
		public void V6Y(double P_0)
		{
			w6h = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double W6s()
		{
			return F6g;
		}

		[SpecialName]
		[CompilerGenerated]
		public void j6q(double P_0)
		{
			F6g = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public UIElement M6V()
		{
			return G6X;
		}

		[SpecialName]
		[CompilerGenerated]
		public void L6P(UIElement P_0)
		{
			G6X = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double S6U()
		{
			return e65;
		}

		[SpecialName]
		[CompilerGenerated]
		public void D6c(double P_0)
		{
			e65 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double v6j()
		{
			return I6y;
		}

		[SpecialName]
		[CompilerGenerated]
		public void c6Z(double P_0)
		{
			I6y = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double n6A()
		{
			return J6o;
		}

		[SpecialName]
		[CompilerGenerated]
		public void P6H(double P_0)
		{
			J6o = P_0;
		}

		public dVq()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal static bool SMn()
		{
			return BM8 == null;
		}

		internal static dVq WMA()
		{
			return BM8;
		}
	}

	private DeferrableObservableCollection<UIElement> zrd;

	private List<SplitContainerSplitter> Mrw;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty SlotLengthProperty;

	internal static SplitContainerPanel on7;

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

	public DeferrableObservableCollection<UIElement> SlotElements => zrd;

	public SplitContainerPanel()
	{
		IVH.CecNqz();
		zrd = new DeferrableObservableCollection<UIElement>();
		Mrw = new List<SplitContainerSplitter>();
		base._002Ector();
		zrd.CollectionChanged += VEu;
	}

	private void pEb(Size P_0)
	{
		foreach (UIElement item in zrd)
		{
			if (item is SplitContainer splitContainer && splitContainer.naG() == null)
			{
				splitContainer.Measure(P_0);
			}
		}
	}

	internal SplitContainer xEA()
	{
		return VisualTreeHelperExtended.GetAncestor<SplitContainer>(this);
	}

	internal int TEH()
	{
		return Math.Max(0, zE5() - 1);
	}

	internal double BE0()
	{
		return Math.Round(Math.Max(1.0, (xEA()?.DockSite)?.SplitterSize ?? 5.0));
	}

	internal Size VEh()
	{
		UIElement[] array = GEy().ToArray();
		if (array.Length == 0)
		{
			return new Size(200.0, 200.0);
		}
		double num = BE0();
		double num2 = (double)TEH() * num;
		double num3 = 30.0;
		UIElement[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] is wH { DockedSize: var dockedSize })
			{
				num2 += this.GetSizeExtent(dockedSize);
				num3 = Math.Max(num3, this.GetSizeAscent(dockedSize));
			}
		}
		return this.CreateSize(num2, num3);
	}

	internal Size VEg()
	{
		UIElement[] array = GEy().ToArray();
		if (array.Length == 0)
		{
			return new Size(double.PositiveInfinity, double.PositiveInfinity);
		}
		double num = BE0();
		double num2 = (double)TEH() * num;
		double num3 = double.PositiveInfinity;
		UIElement[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] is wH { MaxSize: var maxSize })
			{
				num2 += this.GetSizeExtent(maxSize);
				num3 = Math.Min(num3, this.GetSizeAscent(maxSize));
			}
		}
		return this.CreateSize(num2, num3);
	}

	internal Size mEX()
	{
		UIElement[] array = GEy().ToArray();
		if (array.Length == 0)
		{
			return default(Size);
		}
		double num = BE0();
		double num2 = (double)TEH() * num;
		double num3 = 0.0;
		UIElement[] array2 = array;
		int num5 = default(int);
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] is wH { MinSize: var minSize })
			{
				int num4 = 0;
				if (!fnO())
				{
					num4 = num5;
				}
				switch (num4)
				{
				}
				num2 += this.GetSizeExtent(minSize);
				num3 = Math.Max(num3, this.GetSizeAscent(minSize));
			}
		}
		return this.CreateSize(num2, num3);
	}

	private int zE5()
	{
		return GEy().Count();
	}

	internal IEnumerable<UIElement> GEy()
	{
		return zrd.Where((UIElement e) => GEo(e));
	}

	private static bool GEo(UIElement P_0)
	{
		if (!(P_0 is wH wH))
		{
			return false;
		}
		if (!wH.ContainsDockingWindows)
		{
			return wH.ContainsWorkspace;
		}
		return true;
	}

	private static void NEt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SplitContainerPanel splitContainerPanel = (SplitContainerPanel)P_0;
		foreach (SplitContainerSplitter item in splitContainerPanel.Mrw)
		{
			item.Orientation = splitContainerPanel.Orientation;
		}
		splitContainerPanel.InvalidateMeasure();
		splitContainerPanel.InvalidateArrange();
	}

	private void VEu(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1.Action == NotifyCollectionChangedAction.Reset)
		{
			base.Children.Clear();
			foreach (UIElement item in zrd)
			{
				if (item != null)
				{
					base.Children.Add(item);
				}
			}
		}
		else
		{
			if (P_1.OldItems != null)
			{
				foreach (UIElement oldItem in P_1.OldItems)
				{
					if (oldItem != null && base.Children.Contains(oldItem))
					{
						base.Children.Remove(oldItem);
					}
				}
			}
			if (P_1.NewItems != null)
			{
				foreach (UIElement newItem in P_1.NewItems)
				{
					if (newItem != null && !base.Children.Contains(newItem))
					{
						base.Children.Insert(0, newItem);
					}
				}
			}
		}
		int num = Math.Max(0, zrd.Count - 1);
		int num3 = default(int);
		while (Mrw.Count > num)
		{
			SplitContainerSplitter splitContainerSplitter;
			while (true)
			{
				splitContainerSplitter = Mrw[0];
				if (!base.Children.Contains(splitContainerSplitter))
				{
					int num2 = 0;
					if (!fnO())
					{
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						continue;
					}
				}
				else
				{
					base.Children.Remove(splitContainerSplitter);
				}
				break;
			}
			Mrw.Remove(splitContainerSplitter);
		}
		while (Mrw.Count < num)
		{
			SplitContainerSplitter splitContainerSplitter2 = new SplitContainerSplitter
			{
				Orientation = Orientation
			};
			base.Children.Add(splitContainerSplitter2);
			Mrw.Add(splitContainerSplitter2);
		}
	}

	internal void nEz()
	{
		UIElement[] array = GEy().ToArray();
		int num = 0;
		SplitContainerPanel splitContainerPanel = default(SplitContainerPanel);
		int num3 = default(int);
		while (num < array.Length)
		{
			UIElement uIElement = array[num];
			wH wH = uIElement as wH;
			int num2;
			if (wH != null)
			{
				wH.DockedSize = this.CreateSize(GetSlotLength(uIElement), this.GetSizeAscent(wH.DockedSize));
				if (wH is SplitContainer splitContainer && splitContainer.Orientation != Orientation)
				{
					splitContainerPanel = splitContainer.naG();
					if (splitContainerPanel != null)
					{
						num2 = 1;
						if (dnb() != null)
						{
							goto IL_0005;
						}
						goto IL_0009;
					}
				}
			}
			goto IL_009b;
			IL_0005:
			num2 = num3;
			goto IL_0009;
			IL_0009:
			switch (num2)
			{
			case 1:
				break;
			default:
				continue;
			}
			UIElement[] array2 = splitContainerPanel.GEy().ToArray();
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] is wH wH2)
				{
					wH2.DockedSize = this.CreateSize(this.GetSizeExtent(wH.DockedSize), this.GetSizeAscent(wH2.DockedSize));
				}
			}
			goto IL_009b;
			IL_009b:
			num++;
			num2 = 0;
			if (dnb() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void Rri(double P_0, bool P_1)
	{
		double num = BE0();
		UIElement[] array = GEy().ToArray();
		if (array.Length != 0)
		{
			double num2 = (double)TEH() * num;
			double num3 = Math.Max(0.0, P_0 - num2);
			List<dVq> list = new List<dVq>();
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = 0.0;
			wH wH = null;
			UIElement obj = null;
			UIElement[] array2 = array;
			foreach (UIElement uIElement in array2)
			{
				if (uIElement is wH wH2)
				{
					if (wH2.ContainsWorkspace)
					{
						wH = wH2;
						obj = uIElement;
						continue;
					}
					double num7 = Math.Ceiling(this.GetSizeExtent(wH2.MinSize));
					double num8 = Math.Ceiling(this.GetSizeExtent(wH2.MaxSize));
					double num9 = Math.Ceiling(Math.Max(1.0, Math.Max(num7, Math.Min(num8, this.GetSizeExtent(wH2.DockedSize)))));
					num4 += num9;
					num5 += num7;
					num6 += num8;
					dVq dVq = new dVq();
					dVq.L6P(uIElement);
					dVq.P6H(num7);
					dVq.c6Z(num8);
					dVq.V6Y(num9);
					dVq.D6c(num9);
					list.Add(dVq);
				}
			}
			if (wH != null)
			{
				double num10 = Math.Ceiling(this.GetSizeExtent(wH.MinSize));
				if (num4 <= num3 - num10)
				{
					SetSlotLength(obj, num3 - num4);
				}
				else if (num5 <= num3 - num10)
				{
					SetSlotLength(obj, num10);
					if (list.Count > 0)
					{
						double num11 = num3 - num10;
						double num12 = Math.Ceiling(Math.Max(0.0, num4 - num11));
						while (num12 > 0.0)
						{
							IEnumerable<dVq> enumerable = list.Where((dVq l) => l.S6U() > l.n6A());
							int num13 = enumerable.Count();
							if (num13 == 0)
							{
								break;
							}
							double num14 = 0.0;
							double val = Math.Ceiling(num12 / (double)num13);
							foreach (dVq item in enumerable)
							{
								double num15 = Math.Min(Math.Max(0.0, item.S6U() - item.n6A()), Math.Min(val, num12));
								item.D6c(item.S6U() - num15);
								num14 += num15;
								num12 -= num15;
							}
							if (num14 == 0.0)
							{
								break;
							}
						}
					}
				}
				else
				{
					double num16 = Math.Floor(num3 / (double)array.Length);
					SetSlotLength(obj, num3 - (double)list.Count * num16);
					foreach (dVq item2 in list)
					{
						item2.D6c(num16);
					}
				}
			}
			else
			{
				foreach (dVq item3 in list)
				{
					item3.j6q(Math.Max(item3.n6A(), item3.R69()) / num4);
				}
				if (num5 <= num3)
				{
					if (list.Count > 0)
					{
						dVq dVq2 = null;
						double num17 = num4 - num3;
						if (num17 > 0.0)
						{
							num17 = Math.Ceiling(num17);
							while (num17 > 0.0)
							{
								IEnumerable<dVq> enumerable2 = list.Where((dVq l) => l.S6U() > l.n6A());
								if (!enumerable2.Any())
								{
									break;
								}
								double num18 = enumerable2.Sum((dVq l) => l.W6s());
								double num19 = 0.0;
								foreach (dVq item4 in enumerable2)
								{
									double num20 = Math.Min(Math.Max(0.0, item4.S6U() - item4.n6A()), Math.Max(1.0, Math.Round(item4.W6s() / num18 * num17)));
									item4.D6c(item4.S6U() - num20);
									num19 += num20;
									dVq2 = item4;
									if (num17 - num19 <= 0.0)
									{
										break;
									}
								}
								if (num19 == 0.0)
								{
									break;
								}
								num17 -= num19;
							}
						}
						else if (num17 < 0.0)
						{
							num17 = Math.Ceiling(Math.Abs(num17));
							while (num17 > 0.0)
							{
								IEnumerable<dVq> enumerable3 = list.Where((dVq l) => l.S6U() < l.v6j());
								if (!enumerable3.Any())
								{
									break;
								}
								double num21 = enumerable3.Sum((dVq l) => l.W6s());
								double num22 = 0.0;
								foreach (dVq item5 in enumerable3)
								{
									double num23 = Math.Min(Math.Max(0.0, item5.v6j() - item5.S6U()), Math.Max(1.0, Math.Round(item5.W6s() / num21 * num17)));
									item5.D6c(item5.S6U() + num23);
									num22 += num23;
									dVq2 = item5;
								}
								if (num22 == 0.0)
								{
									break;
								}
								num17 -= num22;
							}
						}
						if (num17 < 0.0)
						{
							dVq2?.D6c(Math.Max(0.0, dVq2.S6U() + num17));
						}
					}
				}
				else
				{
					double num24 = num3;
					double num25 = Math.Floor(num24 / (double)array.Length);
					for (int num26 = 0; num26 < list.Count; num26++)
					{
						dVq dVq3 = list[num26];
						if (num26 < list.Count - 1)
						{
							dVq3.D6c(num25);
							num24 = Math.Max(0.0, num24 - num25);
						}
						else
						{
							dVq3.D6c(num24);
							num24 = 0.0;
						}
					}
				}
			}
			foreach (dVq item6 in list)
			{
				SetSlotLength(item6.M6V(), item6.S6U());
			}
		}
		if (!P_1)
		{
			return;
		}
		double num27 = 0.0;
		for (int num28 = 0; num28 < Mrw.Count; num28++)
		{
			if (num28 < array.Length - 1)
			{
				num27 += GetSlotLength(array[num28]);
				Mrw[num28].CrD(num27);
				Mrw[num28].Trk(array[num28]);
				Mrw[num28].Wre(array[num28 + 1]);
				Mrw[num28].IsHitTestVisible = true;
				num27 += num;
			}
			else
			{
				Mrw[num28].IsHitTestVisible = false;
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = Math.Floor(this.GetSizeExtent(finalSize));
		double num2 = Math.Floor(this.GetSizeAscent(finalSize));
		Rri(num, _0020: true);
		double num3 = 0.0;
		double num4 = BE0();
		Orientation orientation = Orientation;
		Rect finalRect = default(Rect);
		double slotLength = default(double);
		int num6 = default(int);
		for (int i = 0; i < zrd.Count; i++)
		{
			UIElement uIElement = zrd[i];
			int num5 = 0;
			if (!fnO())
			{
				num5 = 0;
			}
			while (true)
			{
				switch (num5)
				{
				case 1:
					uIElement.Arrange(finalRect);
					num3 += slotLength + num4;
					break;
				default:
					if (!GEo(uIElement))
					{
						break;
					}
					slotLength = GetSlotLength(uIElement);
					if (orientation == Orientation.Horizontal)
					{
						finalRect = new Rect(num3, 0.0, slotLength, num2);
						goto case 1;
					}
					finalRect = new Rect(0.0, num3, num2, slotLength);
					num5 = 1;
					if (!fnO())
					{
						num5 = num6;
					}
					continue;
				}
				break;
			}
		}
		using (List<SplitContainerSplitter>.Enumerator enumerator = Mrw.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				SplitContainerSplitter current = enumerator.Current;
				if (!current.IsHitTestVisible)
				{
					current.Arrange(default(Rect));
				}
				else if (orientation == Orientation.Horizontal)
				{
					current.Arrange(new Rect(current.kr8(), 0.0, num4, num2));
				}
				else
				{
					current.Arrange(new Rect(0.0, current.kr8(), num2, num4));
				}
			}
			int num7 = 0;
			if (dnb() != null)
			{
				int num8 = default(int);
				num7 = num8;
			}
			switch (num7)
			{
			case 0:
				break;
			}
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		int num = 1;
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					double extent = (double)TEH() * num3;
					Size size = this.CreateSize(extent, 0.0);
					double num4 = Math.Floor(this.GetSizeExtent(availableSize));
					double ascent = Math.Floor(this.GetSizeAscent(availableSize));
					pEb(availableSize);
					Rri(num4, _0020: false);
					foreach (UIElement item in zrd)
					{
						if (item != null)
						{
							double slotLength = GetSlotLength(item);
							item.Measure(this.CreateSize(slotLength, ascent));
							if (GEo(item))
							{
								size = this.CreateSize(this.GetSizeExtent(size) + this.GetSizeExtent(item.DesiredSize), Math.Max(this.GetSizeAscent(size), this.GetSizeAscent(item.DesiredSize)));
							}
						}
					}
					{
						foreach (SplitContainerSplitter item2 in Mrw)
						{
							item2.Measure(this.CreateSize(num3, ascent));
						}
						return size;
					}
				}
				}
				num3 = BE0();
				num2 = 0;
			}
			while (dnb() == null);
		}
	}

	[AttachedPropertyBrowsableForChildren]
	public static double GetSlotLength(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (double)obj.GetValue(SlotLengthProperty);
	}

	public static void SetSlotLength(DependencyObject obj, double value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(SlotLengthProperty, value);
	}

	static SplitContainerPanel()
	{
		IVH.CecNqz();
		OrientationProperty = DependencyProperty.Register(vVK.ssH(15456), typeof(Orientation), typeof(SplitContainerPanel), new PropertyMetadata(Orientation.Horizontal, NEt));
		SlotLengthProperty = DependencyProperty.RegisterAttached(vVK.ssH(21536), typeof(double), typeof(SplitContainerPanel), new PropertyMetadata(200.0));
	}

	internal static bool fnO()
	{
		return on7 == null;
	}

	internal static SplitContainerPanel dnb()
	{
		return on7;
	}
}
