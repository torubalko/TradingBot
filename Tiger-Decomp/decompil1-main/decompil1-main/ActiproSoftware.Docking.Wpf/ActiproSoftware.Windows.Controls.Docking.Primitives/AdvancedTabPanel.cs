using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class AdvancedTabPanel : TabPanel, IOrientedElement
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public TabLayoutKind? E6B;

		internal static _003C_003Ec__DisplayClass55_0 OcP;

		public _003C_003Ec__DisplayClass55_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool W6W(AdvancedTabItem t)
		{
			return t.LayoutKind == E6B.Value;
		}

		internal static bool Jce()
		{
			return OcP == null;
		}

		internal static _003C_003Ec__DisplayClass55_0 ucJ()
		{
			return OcP;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public double M6J;

		private static _003C_003Ec__DisplayClass56_0 fcU;

		public _003C_003Ec__DisplayClass56_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal _003C_003Ef__AnonymousType0<AdvancedTabItem, double> a6K(AdvancedTabItem t)
		{
			return new
			{
				t = t,
				tabOverAverageExtent = lOZ(t) - M6J
			};
		}

		internal static bool IcF()
		{
			return fcU == null;
		}

		internal static _003C_003Ec__DisplayClass56_0 ucd()
		{
			return fcU;
		}
	}

	private bool VT2;

	private Size NTe;

	private double jTG;

	private double HTI;

	private AdvancedTabControl hTk;

	private double DTC;

	private double JT1;

	private double bTN;

	private double pTQ;

	private double hTm;

	private double wTa;

	private bool HTW;

	private bool hTB;

	private static readonly DependencyProperty wTK;

	public static readonly DependencyProperty ContentOrientationProperty;

	public static readonly DependencyProperty OrientationProperty;

	private static readonly DependencyProperty kTJ;

	private static AdvancedTabPanel a85;

	private double MaxTabExtent
	{
		get
		{
			if (hTk == null)
			{
				return 260.0;
			}
			return hTk.MaxTabExtent;
		}
	}

	private double MinTabExtent
	{
		get
		{
			if (hTk == null)
			{
				return 30.0;
			}
			return hTk.MinTabExtent;
		}
	}

	private double TabSpacing
	{
		get
		{
			if (hTk == null)
			{
				return 0.0;
			}
			return hTk.TabSpacing;
		}
	}

	public Orientation ContentOrientation
	{
		get
		{
			return (Orientation)GetValue(ContentOrientationProperty);
		}
		set
		{
			SetValue(ContentOrientationProperty, value);
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

	public AdvancedTabPanel()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	protected AdvancedTabPanel(bool useCustomLayoutLogic)
	{
		IVH.CecNqz();
		this._002Ector();
		HTW = useCustomLayoutLogic;
	}

	private Rect NOq(AdvancedTabItem P_0, AdvancedTabItem P_1, Rect P_2)
	{
		if (P_0 == P_1 && hTk != null && hTk.Edv() != null)
		{
			if (Orientation == Orientation.Horizontal)
			{
				P_2.X = hTk.Edv().mSO();
			}
			else
			{
				P_2.Y = hTk.Edv().mSO();
			}
		}
		return P_2;
	}

	internal static Rect COF(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (Rect)P_0.GetValue(wTK);
	}

	internal static void POV(UIElement P_0, Rect P_1)
	{
		if (P_0 != null)
		{
			P_0.SetValue(wTK, P_1);
			return;
		}
		throw new ArgumentNullException(vVK.ssH(15298));
	}

	[SpecialName]
	private bool QOA()
	{
		if (hTk != null)
		{
			TabOverflowBehavior tabOverflowBehavior = hTk.TabOverflowBehavior;
			if ((uint)(tabOverflowBehavior - 2) <= 1u)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	private AdvancedTabItem GO0()
	{
		if (hTk == null || hTk.Edv() == null)
		{
			return null;
		}
		return hTk.Edv().DSJ();
	}

	private void vOP()
	{
		if (hTk == null)
		{
			hTk = VisualTreeHelperExtended.GetAncestor<AdvancedTabControl>(this);
			if (hTk != null)
			{
				hTk.gdf(this);
			}
		}
	}

	internal double rOf(AdvancedTabItem P_0)
	{
		if (!QOA() && P_0 != null && base.Children.Contains(P_0))
		{
			int num = 0;
			if (M8j())
			{
				num = 1;
			}
			FrameworkElement frameworkElement = default(FrameworkElement);
			double sizeExtent = default(double);
			Rect rect2 = default(Rect);
			int num2 = default(int);
			while (true)
			{
				Point location;
				double num3;
				Rect rect3;
				double num4;
				switch (num)
				{
				case 1:
					frameworkElement = (VisualTreeHelper.GetParent(this) as FrameworkElement) ?? this;
					sizeExtent = this.GetSizeExtent(frameworkElement.RenderSize);
					if (!(sizeExtent > 0.0))
					{
						break;
					}
					location = default(Point);
					rect2 = P_0.qwT();
					if (rect2.Width > 0.0 && rect2.Height > 0.0)
					{
						num = 0;
						if (!M8j())
						{
							num = num2;
						}
						continue;
					}
					goto IL_0164;
				default:
					{
						Rect rect = COF(P_0);
						location = new Point(rect.X - rect2.X, rect.Y - rect2.Y);
						goto IL_0164;
					}
					IL_0164:
					num3 = lOZ(P_0);
					rect3 = P_0.TransformToVisual(frameworkElement).TransformBounds(new Rect(location, this.CreateSize(num3, 0.0)));
					num4 = ((Orientation == Orientation.Horizontal) ? rect3.Left : rect3.Top);
					if (num4 != 0.0)
					{
						if (num4 < 0.0)
						{
							return 0.0 - num4;
						}
						if (num4 + num3 > sizeExtent)
						{
							return sizeExtent - (num4 + num3);
						}
					}
					break;
				}
				break;
			}
		}
		return 0.0;
	}

	internal Tuple<double, double> bOU(TabLayoutKind P_0)
	{
		if (HTW)
		{
			return Tuple.Create(0.0, base.ActualWidth);
		}
		return P_0 switch
		{
			TabLayoutKind.Pinned => Tuple.Create(JT1, DTC), 
			TabLayoutKind.Preview => Tuple.Create(pTQ, bTN), 
			_ => Tuple.Create(HTI, jTG), 
		};
	}

	internal double POc()
	{
		FrameworkElement frameworkElement = (VisualTreeHelper.GetParent(this) as FrameworkElement) ?? this;
		return this.GetSizeExtent(frameworkElement.RenderSize);
	}

	[SpecialName]
	private bool oOg()
	{
		if (hTk == null || hTk.Edv() == null)
		{
			return false;
		}
		return hTk.Edv().GS8();
	}

	[SpecialName]
	private NewTabButton VOo()
	{
		if (hTk != null && hTk.HasNewTabButton)
		{
			return hTk.od6();
		}
		return null;
	}

	[SpecialName]
	private double cOu()
	{
		NewTabButton newTabButton = VOo();
		if (newTabButton != null)
		{
			if (newTabButton.DesiredSize == default(Size))
			{
				newTabButton.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			}
			return this.GetSizeExtent(newTabButton.DesiredSize);
		}
		return 0.0;
	}

	private static void iO4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is AdvancedTabItem advancedTabItem))
		{
			return;
		}
		Rect rect = (Rect)P_1.OldValue;
		Rect rect2 = (Rect)P_1.NewValue;
		if (rect == rect2)
		{
			return;
		}
		AdvancedTabPanel ancestor = VisualTreeHelperExtended.GetAncestor<AdvancedTabPanel>(advancedTabItem);
		if (ancestor != null)
		{
			bool flag = advancedTabItem.qwT().Equals(default(Rect));
			bool flag2 = ancestor.VT2 && !flag && ancestor.hTk != null && (ancestor.hTk.Edv() == null || ancestor.hTk.Edv().DSJ() != advancedTabItem) && ancestor.hTk.IsLayoutAnimationEnabled;
			double num = ((ancestor.hTk != null) ? ancestor.hTk.Vdl() : 0.0);
			if (rect.X != rect2.X)
			{
				advancedTabItem.AnimateDoubleProperty(vVK.ssH(4540), rect2.X, flag2 ? num : 0.0);
			}
			if (rect.Y != rect2.Y)
			{
				advancedTabItem.AnimateDoubleProperty(vVK.ssH(4576), rect2.Y, flag2 ? num : 0.0);
			}
			if (rect.Width != rect2.Width)
			{
				advancedTabItem.AnimateDoubleProperty(vVK.ssH(4496), rect2.Width, flag2 ? num : 0.0);
			}
			if (rect.Height != rect2.Height)
			{
				advancedTabItem.AnimateDoubleProperty(vVK.ssH(4450), rect2.Height, flag2 ? num : 0.0);
			}
		}
	}

	private static void QOj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabPanel obj = (AdvancedTabPanel)P_0;
		obj.InvalidateMeasure();
		obj.InvalidateArrange();
	}

	private static double lOZ(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (double)P_0.GetValue(kTJ);
	}

	private static void LOb(UIElement P_0, double P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		P_0.SetValue(kTJ, P_1);
	}

	[SpecialName]
	internal double aTd()
	{
		return wTa;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override Size ArrangeOverride(Size finalSize)
	{
		VT2 = NTe == finalSize && base.IsLoaded;
		NTe = finalSize;
		if (HTW)
		{
			return finalSize;
		}
		Orientation orientation = Orientation;
		double num = TabSpacing;
		NewTabButton newTabButton = VOo();
		double num2 = Math.Floor(this.GetSizeExtent(finalSize));
		double num3 = Math.Floor(this.GetSizeAscent(finalSize));
		IEnumerable<AdvancedTabItem> tabItemElements = GetTabItemElements();
		int num4 = tabItemElements.Count();
		AdvancedTabItem[] array = tabItemElements.Where((AdvancedTabItem t) => t.LayoutKind == TabLayoutKind.Pinned).ToArray();
		AdvancedTabItem[] array2 = tabItemElements.Where((AdvancedTabItem t) => t.LayoutKind == TabLayoutKind.Normal).ToArray();
		AdvancedTabItem[] array3 = tabItemElements.Where((AdvancedTabItem t) => t.LayoutKind == TabLayoutKind.Preview).Reverse().ToArray();
		AdvancedTabItem advancedTabItem = GO0();
		bool flag = oOg();
		double num5 = 0.0;
		int num6 = num4;
		int num7 = 0;
		JT1 = num5;
		AdvancedTabItem[] array4 = array;
		foreach (AdvancedTabItem advancedTabItem2 in array4)
		{
			if (!flag)
			{
				advancedTabItem2.DragSortOrder = num7++;
			}
			double num9 = lOZ(advancedTabItem2);
			Panel.SetZIndex(advancedTabItem2, --num6 + (advancedTabItem2.IsSelected ? 1000 : 0));
			advancedTabItem2.Arrange(advancedTabItem2.qwT());
			Rect rect = NOq(advancedTabItem2, advancedTabItem, (orientation == Orientation.Horizontal) ? new Rect(num5, 0.0, num9, num3) : new Rect(0.0, num5, num3, num9));
			POV(advancedTabItem2, rect);
			num5 += num9 + num;
		}
		DTC = num5;
		num7 = 0;
		HTI = num5;
		array4 = array2;
		foreach (AdvancedTabItem advancedTabItem3 in array4)
		{
			if (!flag)
			{
				advancedTabItem3.DragSortOrder = num7++;
			}
			double num10 = lOZ(advancedTabItem3);
			Panel.SetZIndex(advancedTabItem3, --num6 + (advancedTabItem3.IsSelected ? 1000 : 0));
			advancedTabItem3.Arrange(advancedTabItem3.qwT());
			Rect rect = NOq(advancedTabItem3, advancedTabItem, (orientation == Orientation.Horizontal) ? new Rect(num5, 0.0, num10, num3) : new Rect(0.0, num5, num3, num10));
			POV(advancedTabItem3, rect);
			num5 += num10 + num;
		}
		jTG = num5;
		if (newTabButton != null)
		{
			string text = ((orientation == Orientation.Horizontal) ? vVK.ssH(3326) : vVK.ssH(3320));
			string text2 = ((orientation == Orientation.Horizontal) ? vVK.ssH(3320) : vVK.ssH(3326));
			Panel.SetZIndex(newTabButton, 1000);
			newTabButton.AnimateDoubleProperty(vVK.ssH(19988) + text + vVK.ssH(3504), num5, (VT2 && hTk != null) ? hTk.Vdl() : 0.0);
			newTabButton.AnimateDoubleProperty(vVK.ssH(19988) + text2 + vVK.ssH(3504), 0.0, 0.0);
		}
		double num11 = 0.0;
		num6 = 0;
		num7 = array3.Length;
		bTN = num2 - num11;
		array4 = array3;
		foreach (AdvancedTabItem advancedTabItem4 in array4)
		{
			if (!flag)
			{
				num7 = (advancedTabItem4.DragSortOrder = num7 - 1);
			}
			double num13 = lOZ(advancedTabItem4);
			Panel.SetZIndex(advancedTabItem4, num6++ + (advancedTabItem4.IsSelected ? 1000 : 0));
			advancedTabItem4.Arrange(advancedTabItem4.qwT());
			Rect rect = NOq(advancedTabItem4, advancedTabItem, (orientation == Orientation.Horizontal) ? new Rect(num2 - num11 - num13, 0.0, num13, num3) : new Rect(0.0, num2 - num11 - num13, num3, num13));
			POV(advancedTabItem4, rect);
			num11 += num13 + num;
		}
		pTQ = num2 - num11;
		if (hTm != num2 || hTB)
		{
			hTm = num2;
			if (hTk != null && !hTk.Yj())
			{
				hTk.EdB();
			}
		}
		return finalSize;
	}

	protected void ArrangeTab(AdvancedTabItem tabItem, Rect bounds, int sortOrder)
	{
		if (tabItem != null)
		{
			if (!oOg())
			{
				tabItem.DragSortOrder = sortOrder++;
			}
			Panel.SetZIndex(tabItem, base.Children.Count - sortOrder + (tabItem.IsSelected ? 1000 : 0));
			tabItem.Arrange(tabItem.qwT());
			bounds = NOq(tabItem, GO0(), bounds);
			POV(tabItem, bounds);
		}
	}

	protected override Geometry GetLayoutClip(Size layoutSlotSize)
	{
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
	protected internal IEnumerable<AdvancedTabItem> GetTabItemElements(TabLayoutKind? layoutKind = null)
	{
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass55_0();
		CS_0024_003C_003E8__locals3.E6B = layoutKind;
		IEnumerable<AdvancedTabItem> enumerable = from t in base.Children.OfType<AdvancedTabItem>()
			where t.Visibility != Visibility.Collapsed
			select t;
		if (hTk != null && hTk.Edv() != null)
		{
			enumerable = from t in enumerable
				orderby t.DragSortOrder
				orderby t.LayoutKind
				select t;
		}
		if (CS_0024_003C_003E8__locals3.E6B.HasValue)
		{
			enumerable = enumerable.Where((AdvancedTabItem t) => t.LayoutKind == CS_0024_003C_003E8__locals3.E6B.Value);
		}
		return enumerable;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		IEnumerable<AdvancedTabItem> tabItemElements = GetTabItemElements();
		int num = tabItemElements.Count();
		double val = MaxTabExtent;
		double val2 = MinTabExtent;
		double num2 = TabSpacing;
		double num3 = cOu();
		double sizeExtent = this.GetSizeExtent(availableSize);
		double sizeAscent = this.GetSizeAscent(availableSize);
		bool flag = ContentOrientation == Orientation.Horizontal;
		bool flag2 = Orientation == Orientation.Horizontal;
		double num4 = (double)Math.Max(0, num - 1) * num2 + num3;
		double num5 = 0.0;
		Size availableSize2 = ((flag2 == flag) ? this.CreateSize(Math.Max(val2, Math.Min(val, double.PositiveInfinity)), sizeAscent) : this.CreateSize(double.PositiveInfinity, Math.Max(val2, Math.Min(val, sizeAscent))));
		foreach (AdvancedTabItem item in tabItemElements)
		{
			item.Measure(availableSize2);
			double num6 = Math.Round(this.GetSizeExtent(item.DesiredSize));
			double val3 = Math.Ceiling(this.GetSizeAscent(item.DesiredSize));
			if (flag2 == flag)
			{
				num6 = Math.Max(val2, Math.Min(val, num6));
			}
			else
			{
				val3 = Math.Max(val2, Math.Min(val, val3));
			}
			num4 += num6;
			num5 = Math.Max(num5, val3);
			LOb(item, num6);
		}
		wTa = num4;
		double num7 = num4;
		double ascent = num5;
		double num8 = Math.Max(0.0, num7 - sizeExtent);
		if (num8 > 0.0 && QOA())
		{
			_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass56_0();
			num7 = this.GetSizeExtent(availableSize);
			CS_0024_003C_003E8__locals2.M6J = Math.Max(0.0, sizeExtent - num3) / (double)Math.Max(1, num);
			var array = (from t in tabItemElements
				let tabOverAverageExtent = lOZ(t) - CS_0024_003C_003E8__locals2.M6J
				where tabOverAverageExtent > 0.0
				select new
				{
					TabItem = t,
					TabOverAverageExtent = tabOverAverageExtent
				}).ToArray();
			double num9 = array.Sum(t => t.TabOverAverageExtent);
			if (num9 >= 1.0)
			{
				var array2 = array;
				foreach (var anon in array2)
				{
					double num11 = anon.TabOverAverageExtent / num9 * num8;
					double num12 = Math.Max(0.0, Math.Floor(lOZ(anon.TabItem) - num11));
					Size availableSize3 = this.CreateSize(num12, sizeAscent);
					anon.TabItem.Measure(availableSize3);
					LOb(anon.TabItem, num12);
				}
				if (array.Length != 0)
				{
					double num13 = num7 - tabItemElements.Sum((AdvancedTabItem t) => lOZ(t));
					if (num13 > 0.0 && num13 < 5.0)
					{
						LOb(array[0].TabItem, lOZ(array[0].TabItem) + num13);
					}
				}
			}
		}
		return this.CreateSize(num7, ascent);
	}

	protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
	{
		base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
		vOP();
	}

	protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
	{
		base.OnVisualChildrenChanged(visualAdded, visualRemoved);
		hTB = true;
	}

	static AdvancedTabPanel()
	{
		IVH.CecNqz();
		wTK = DependencyProperty.RegisterAttached(vVK.ssH(20160), typeof(Rect), typeof(AdvancedTabPanel), new PropertyMetadata(default(Rect), iO4));
		ContentOrientationProperty = DependencyProperty.Register(vVK.ssH(20186), typeof(Orientation), typeof(AdvancedTabPanel), new PropertyMetadata(Orientation.Horizontal, QOj));
		OrientationProperty = DependencyProperty.Register(vVK.ssH(15456), typeof(Orientation), typeof(AdvancedTabPanel), new PropertyMetadata(Orientation.Horizontal, QOj));
		kTJ = DependencyProperty.RegisterAttached(vVK.ssH(20226), typeof(double), typeof(AdvancedTabPanel), new PropertyMetadata(200.0));
	}

	internal static bool M8j()
	{
		return a85 == null;
	}

	internal static AdvancedTabPanel K8t()
	{
		return a85;
	}
}
