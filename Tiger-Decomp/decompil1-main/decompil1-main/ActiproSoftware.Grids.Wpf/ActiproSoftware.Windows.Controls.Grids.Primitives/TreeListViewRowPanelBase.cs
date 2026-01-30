using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

public abstract class TreeListViewRowPanelBase : Panel, IOrientedElement
{
	internal class Ne
	{
		[CompilerGenerated]
		private Control VmS;

		[CompilerGenerated]
		private double Ymz;

		[CompilerGenerated]
		private double STI;

		[CompilerGenerated]
		private double QTP;

		[CompilerGenerated]
		private double qT1;

		internal static Ne WXJ;

		public double IndentAmount
		{
			[CompilerGenerated]
			get
			{
				return STI;
			}
			[CompilerGenerated]
			set
			{
				STI = sTI;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public Control Hmb()
		{
			return VmS;
		}

		[SpecialName]
		[CompilerGenerated]
		public void Fmh(Control P_0)
		{
			VmS = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double gmH()
		{
			return Ymz;
		}

		[SpecialName]
		[CompilerGenerated]
		public void umD(double P_0)
		{
			Ymz = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double Hmc()
		{
			return QTP;
		}

		[SpecialName]
		[CompilerGenerated]
		public void imV(double P_0)
		{
			QTP = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double Qm0()
		{
			return qT1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void ymA(double P_0)
		{
			qT1 = P_0;
		}

		public Ne()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal static bool rXK()
		{
			return WXJ == null;
		}

		internal static Ne VXE()
		{
			return WXJ;
		}
	}

	private class Er
	{
		[CompilerGenerated]
		private Ne uTo;

		[CompilerGenerated]
		private double xTY;

		[CompilerGenerated]
		private double LTk;

		[CompilerGenerated]
		private double lTQ;

		[CompilerGenerated]
		private double aTy;

		private static Er hXg;

		public double MinWidth
		{
			[CompilerGenerated]
			get
			{
				return lTQ;
			}
			[CompilerGenerated]
			set
			{
				lTQ = num;
			}
		}

		public double MaxWidth
		{
			[CompilerGenerated]
			get
			{
				return aTy;
			}
			[CompilerGenerated]
			set
			{
				aTy = num;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public Ne eTt()
		{
			return uTo;
		}

		[SpecialName]
		[CompilerGenerated]
		public void sTU(Ne P_0)
		{
			uTo = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double wTq()
		{
			return xTY;
		}

		[SpecialName]
		[CompilerGenerated]
		public void STJ(double P_0)
		{
			xTY = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public double hTW()
		{
			return LTk;
		}

		[SpecialName]
		[CompilerGenerated]
		public void nTn(double P_0)
		{
			LTk = P_0;
		}

		[SpecialName]
		public double wTl()
		{
			return wTq() - OTm();
		}

		[SpecialName]
		public double OTm()
		{
			return Math.Max(MinWidth, Math.Min(MaxWidth, wTq()));
		}

		public Er()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal static bool lXP()
		{
			return hXg == null;
		}

		internal static Er yXh()
		{
			return hXg;
		}
	}

	private List<Ne> gC7;

	private ug PCs;

	private Type oCF;

	private TreeListView TCc;

	private double oCV;

	private static TreeListViewRowPanelBase ssx;

	public Orientation Orientation => Orientation.Horizontal;

	protected TreeListViewRowPanelBase()
	{
		fc.taYSkz();
		gC7 = new List<Ne>();
		base._002Ector();
		base.DataContextChanged += TCw;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal double cCd(Size P_0, TreeListViewItem P_1, int P_2, FrameworkElement P_3, FrameworkElement P_4)
	{
		double num = 0.0;
		IList<Ne> list = mCL();
		if (PCs != null && PCs.Count == list.Count)
		{
			double num2 = P_0.Width;
			double num3 = Math.Max(0.0, P_0.Height);
			double num4 = 0.0;
			List<Er> list2 = null;
			for (int i = 0; i < list.Count; i++)
			{
				Ne ne = list[i];
				TreeListViewColumn treeListViewColumn = PCs[i];
				if (!treeListViewColumn.IsVisible)
				{
					continue;
				}
				switch (treeListViewColumn.Width.GridUnitType)
				{
				case GridUnitType.Auto:
				case GridUnitType.Pixel:
					ne.umD(treeListViewColumn.ActualWidth);
					num2 = Math.Max(0.0, num2 - treeListViewColumn.ActualWidth);
					break;
				case GridUnitType.Star:
					if (ne.Hmb() != null)
					{
						if (list2 == null)
						{
							list2 = new List<Er>();
						}
						List<Er> list3 = list2;
						Er er = new Er();
						er.sTU(ne);
						er.nTn(Math.Max(0.0, treeListViewColumn.Width.Value));
						er.MinWidth = treeListViewColumn.NqT();
						er.MaxWidth = treeListViewColumn.iqg();
						list3.Add(er);
						num4 += Math.Max(0.0, treeListViewColumn.Width.Value);
					}
					break;
				}
			}
			if (num4 > 0.0 && list2 != null)
			{
				double num5 = num2;
				double num6 = num4;
				List<Er> list4 = new List<Er>(list2);
				int count;
				do
				{
					double num7 = num5;
					num4 = num6;
					num6 = 0.0;
					count = list4.Count;
					for (int num8 = list4.Count - 1; num8 >= 0; num8--)
					{
						Er er2 = list4[num8];
						er2.STJ(num7 * er2.hTW() / num4);
						if (Math.Abs(er2.wTl()) < 1.0)
						{
							num6 += er2.hTW();
						}
						else
						{
							num5 = Math.Max(0.0, num5 - er2.OTm());
							list4.RemoveAt(num8);
						}
					}
				}
				while (list4.Count != count);
				if (list2.Count > 0)
				{
					double num9 = 0.0;
					for (int num10 = list2.Count - 1; num10 >= 0; num10--)
					{
						Er er3 = list2[num10];
						double num11 = Math.Round(er3.OTm(), MidpointRounding.AwayFromZero);
						double num12 = num11 - er3.OTm();
						num9 += num12;
						er3.STJ(num11);
					}
					if (num9 != 0.0)
					{
						Er er4 = list2[0];
						er4.STJ(er4.wTq() - num9);
					}
				}
				foreach (Er item in list2)
				{
					if (item.eTt().gmH() != item.OTm())
					{
						item.eTt().umD(item.OTm());
						InvalidateMeasure();
					}
				}
			}
			bool flag = P_2 >= PCs.Count;
			for (int j = 0; j < list.Count; j++)
			{
				TreeListViewColumn treeListViewColumn2 = PCs[j];
				if (!treeListViewColumn2.IsVisible)
				{
					continue;
				}
				Ne ne2 = list[j];
				Control control = ne2.Hmb();
				if (control != null)
				{
					double num13 = (treeListViewColumn2.ActualWidth = ne2.gmH());
					if (j == P_2 && P_1 != null && P_3 != null)
					{
						double num15 = ne2.IndentAmount - P_3.DesiredSize.Width;
						P_3.Opacity = 1.0;
						P_3.IsHitTestVisible = true;
						P_3.Arrange(new Rect(num + num15, 0.0, P_3.DesiredSize.Width, num3));
						OC8(P_3, treeListViewColumn2, num13, num3, num15);
						if (P_4 != null)
						{
							P_4.Arrange(new Rect(ne2.Qm0(), treeListViewColumn2.CellBorderThickness.Top, ne2.IndentAmount, Math.Max(0.0, num3 - treeListViewColumn2.CellBorderThickness.Top - treeListViewColumn2.CellBorderThickness.Bottom)));
							gC9(P_4, treeListViewColumn2, num13, num3);
						}
					}
					ne2.ymA(num);
					control.Arrange(new Rect(num, 0.0, Math.Max(0.0, num13), num3));
					num += num13;
				}
				else if (j == P_2 && P_3 != null)
				{
					flag = true;
				}
			}
			if (flag)
			{
				P_3.Opacity = 0.0;
				P_3.IsHitTestVisible = false;
			}
		}
		oCV = num;
		return num;
	}

	[SpecialName]
	internal IList<Ne> mCL()
	{
		return gC7;
	}

	[SpecialName]
	internal ug qCx()
	{
		return PCs;
	}

	[SpecialName]
	internal void rCa(ug value)
	{
		if (PCs == value)
		{
			return;
		}
		if (PCs != null)
		{
			PCs.CollectionChanged -= mCu;
			int num = 0;
			if (!asS())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			PCs.LEA(dCO);
		}
		PCs = value;
		if (PCs != null)
		{
			PCs.CollectionChanged += mCu;
			PCs.OE0(dCO);
		}
		aCX();
		UpdateAllCellElementZIndexes();
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal Size uCB(Size P_0, TreeListViewItem P_1, int P_2, FrameworkElement P_3, FrameworkElement P_4)
	{
		double num = P_0.Width;
		double height = P_0.Height;
		double num2 = 0.0;
		double num3 = 0.0;
		IList<Ne> list = mCL();
		if (PCs != null && PCs.Count == list.Count)
		{
			double num4 = 0.0;
			List<Er> list2 = null;
			for (int i = 0; i < list.Count; i++)
			{
				TreeListViewColumn treeListViewColumn = PCs[i];
				if (!treeListViewColumn.IsVisible)
				{
					continue;
				}
				Ne ne = list[i];
				Control control = ne.Hmb();
				if (control == null)
				{
					continue;
				}
				ne.IndentAmount = 0.0;
				if (i == P_2 && P_1 != null && P_3 != null)
				{
					P_3.Measure(new Size(double.PositiveInfinity, P_0.Height));
					ne.IndentAmount = ((P_1.IndentAmount > 0.0) ? (2.0 + P_1.IndentAmount) : 0.0);
					P_4?.Measure(new Size(ne.IndentAmount, Math.Max(0.0, P_0.Height - treeListViewColumn.CellBorderThickness.Top - treeListViewColumn.CellBorderThickness.Bottom)));
					if (control is TreeListViewItemCell treeListViewItemCell)
					{
						treeListViewItemCell.IndentAmount = Math.Max(0.0, ne.IndentAmount - TreeListViewColumn.jqj.Left);
					}
				}
				GridUnitType gridUnitType = treeListViewColumn.Width.GridUnitType;
				switch (gridUnitType)
				{
				case GridUnitType.Auto:
				case GridUnitType.Pixel:
				{
					TreeListViewColumnAutoWidthMode autoWidthMode = treeListViewColumn.AutoWidthMode;
					bool flag = P_1 == null;
					double num5 = ((gridUnitType == GridUnitType.Pixel) ? treeListViewColumn.Width.Value : treeListViewColumn.iqg());
					if (gridUnitType == GridUnitType.Auto && ((autoWidthMode == TreeListViewColumnAutoWidthMode.HeaderOnly && !flag) || (autoWidthMode == TreeListViewColumnAutoWidthMode.ItemsOnly && flag)))
					{
						num5 = Math.Min(num5, treeListViewColumn.Bqn());
					}
					ne.imV(num5);
					control.Measure(new Size(num5, height));
					if (gridUnitType == GridUnitType.Pixel || autoWidthMode == TreeListViewColumnAutoWidthMode.Both || (autoWidthMode == TreeListViewColumnAutoWidthMode.HeaderOnly && flag) || (autoWidthMode == TreeListViewColumnAutoWidthMode.ItemsOnly && !flag))
					{
						double num6 = Math.Max(0.0, (gridUnitType == GridUnitType.Pixel) ? num5 : control.DesiredSize.Width);
						treeListViewColumn.k62(flag, num6);
					}
					double actualWidth = treeListViewColumn.ActualWidth;
					num = Math.Max(0.0, num - actualWidth);
					num2 += actualWidth;
					num3 = Math.Max(num3, control.DesiredSize.Height);
					break;
				}
				case GridUnitType.Star:
				{
					if (list2 == null)
					{
						list2 = new List<Er>();
					}
					List<Er> list3 = list2;
					Er er = new Er();
					er.sTU(ne);
					er.nTn(Math.Max(0.0, treeListViewColumn.Width.Value));
					er.MinWidth = treeListViewColumn.NqT();
					er.MaxWidth = treeListViewColumn.iqg();
					list3.Add(er);
					num4 += Math.Max(0.0, treeListViewColumn.Width.Value);
					break;
				}
				}
			}
			if (num4 > 0.0 && list2 != null)
			{
				double num7 = (double.IsPositiveInfinity(num) ? Math.Max(0.0, base.ActualWidth - num2) : num);
				double num8 = num4;
				List<Er> list4 = new List<Er>(list2);
				int count;
				do
				{
					double num9 = num7;
					num4 = num8;
					num8 = 0.0;
					count = list4.Count;
					double num10 = 0.0;
					for (int num11 = list4.Count - 1; num11 >= 0; num11--)
					{
						Er er2 = list4[num11];
						er2.STJ(num9 * er2.hTW() / num4);
						if (Math.Abs(er2.wTl()) < 1.0)
						{
							num8 += er2.hTW();
						}
						else
						{
							num7 = Math.Max(0.0, num7 - er2.OTm());
							list4.RemoveAt(num11);
						}
					}
					num7 = Math.Max(0.0, num7 + num10);
				}
				while (list4.Count != count);
				foreach (Er item in list2)
				{
					item.eTt().imV(item.OTm());
					item.eTt().Hmb().Measure(new Size(item.OTm(), height));
					num2 += Math.Max(0.0, item.MinWidth);
					num3 = Math.Max(num3, item.eTt().Hmb().DesiredSize.Height);
				}
			}
		}
		return new Size(num2, num3);
	}

	private void ICR(NotifyCollectionChangedEventArgs P_0)
	{
		if (P_0.NewStartingIndex >= 0 && P_0.NewItems != null)
		{
			for (int i = 0; i < P_0.NewItems.Count; i++)
			{
				VC2(-1, P_0.NewStartingIndex + i);
			}
		}
	}

	private void pCM(NotifyCollectionChangedEventArgs P_0)
	{
		if (P_0.OldStartingIndex >= 0 && P_0.OldStartingIndex < gC7.Count && P_0.NewStartingIndex >= 0 && P_0.NewStartingIndex < gC7.Count)
		{
			Ne item = gC7[P_0.OldStartingIndex];
			gC7.RemoveAt(P_0.OldStartingIndex);
			gC7.Insert(P_0.NewStartingIndex, item);
			InvalidateMeasure();
		}
	}

	private void gCe(NotifyCollectionChangedEventArgs P_0)
	{
		if (P_0.OldStartingIndex >= 0 && P_0.OldItems != null && P_0.OldStartingIndex + P_0.OldItems.Count <= gC7.Count)
		{
			for (int i = 0; i < P_0.OldItems.Count; i++)
			{
				VC2(P_0.OldStartingIndex, -1);
			}
		}
	}

	private void WCr(NotifyCollectionChangedEventArgs P_0)
	{
		VC2(P_0.OldStartingIndex, P_0.OldStartingIndex);
	}

	private void rCG()
	{
		aCX();
	}

	private void mCu(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1 is ug.mM mM)
		{
			OnColumnPropertyChanged(mM.Column, mM.PropertyName);
		}
		else
		{
			if (P_1 == null || PCs == null)
			{
				return;
			}
			switch (P_1.Action)
			{
			case NotifyCollectionChangedAction.Reset:
				rCG();
				break;
			case NotifyCollectionChangedAction.Add:
				ICR(P_1);
				break;
			case NotifyCollectionChangedAction.Remove:
				gCe(P_1);
				break;
			case NotifyCollectionChangedAction.Move:
			{
				pCM(P_1);
				int num = 0;
				if (ss1() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			case NotifyCollectionChangedAction.Replace:
				WCr(P_1);
				break;
			}
		}
	}

	private void dCO(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (!(P_1 is ug.mM))
		{
			NotifyCollectionChangedAction action = P_1.Action;
			if (action == NotifyCollectionChangedAction.Add || (uint)(action - 2) <= 2u)
			{
				UpdateAllCellElementZIndexes();
			}
		}
	}

	private void TCw(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListViewRowPanelBase treeListViewRowPanelBase = (TreeListViewRowPanelBase)P_0;
		Type type = treeListViewRowPanelBase.oCF;
		treeListViewRowPanelBase.oCF = ((P_1.NewValue != null) ? P_1.NewValue.GetType() : null);
		if (type != treeListViewRowPanelBase.oCF)
		{
			treeListViewRowPanelBase.aCX();
		}
		else
		{
			treeListViewRowPanelBase.UpdateAllCellElementContent();
		}
		treeListViewRowPanelBase.UpdateAllCellElementZIndexes();
	}

	[SpecialName]
	internal TreeListView vCb()
	{
		return TCc;
	}

	[SpecialName]
	internal void eCh(TreeListView value)
	{
		if (TCc != value)
		{
			TCc = value;
			rCa(TCc?.Columns as ug);
		}
	}

	private void aCX()
	{
		if (gC7.Count > 0)
		{
			for (int num = gC7.Count - 1; num >= 0; num--)
			{
				VC2(num, -1);
			}
			gC7.Clear();
		}
		if (PCs == null)
		{
			return;
		}
		int num2 = 0;
		if (!asS())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		for (int i = 0; i < PCs.Count; i++)
		{
			VC2(-1, i);
		}
	}

	[SpecialName]
	internal double pCH()
	{
		return oCV;
	}

	internal void VC2(int P_0, int P_1)
	{
		if (P_0 >= 0 && P_0 < gC7.Count)
		{
			Ne ne = gC7[P_0];
			gC7.RemoveAt(P_0);
			Control control = ne.Hmb();
			if (control != null)
			{
				WC3(control, _0020: false);
				base.Children.Remove(control);
			}
		}
		if (PCs == null || P_1 < 0 || P_1 >= PCs.Count)
		{
			return;
		}
		int num = 0;
		if (ss1() == null)
		{
			num = 0;
		}
		Control control2 = default(Control);
		TreeListViewColumn treeListViewColumn = default(TreeListViewColumn);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				base.Children.Add(control2);
				WC3(control2, treeListViewColumn.IsFrozen);
				KCv(P_1);
				return;
			}
			if (P_1 <= gC7.Count)
			{
				treeListViewColumn = PCs[P_1];
				control2 = (treeListViewColumn.IsVisible ? CreateCellElement(treeListViewColumn) : null);
				Ne ne2 = new Ne();
				ne2.Fmh(control2);
				Ne item = ne2;
				gC7.Insert(P_1, item);
				if (control2 == null)
				{
					return;
				}
				num = 1;
				if (!asS())
				{
					num = num2;
				}
				continue;
			}
			return;
		}
	}

	internal void KCv(int P_0)
	{
		if (PCs == null || P_0 < 0 || P_0 >= gC7.Count)
		{
			return;
		}
		Control control = gC7[P_0].Hmb();
		if (control == null)
		{
			return;
		}
		double clipX = PCs[P_0].ClipX;
		int num = 0;
		if (!asS())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (clipX <= 0.0)
		{
			control.Clip = null;
			return;
		}
		control.Clip = new RectangleGeometry
		{
			Rect = new Rect(clipX, 0.0, Math.Max(10000.0, control.ActualWidth), Math.Max(10000.0, control.ActualHeight))
		};
	}

	internal static void OC8(FrameworkElement P_0, TreeListViewColumn P_1, double P_2, double P_3, double P_4)
	{
		P_0.Clip = new RectangleGeometry
		{
			Rect = new Rect(Math.Max(0.0, P_1.ClipX - P_4), 0.0, Math.Max(0.0, Math.Min(P_4 + P_0.DesiredSize.Width, P_2) + P_1.ClipX - P_4), P_3)
		};
	}

	internal static void gC9(FrameworkElement P_0, TreeListViewColumn P_1, double P_2, double P_3)
	{
		P_0.Clip = new RectangleGeometry
		{
			Rect = new Rect(0.0, 0.0, P_2 + P_1.ClipX, P_3)
		};
	}

	internal static void WC3(FrameworkElement P_0, bool P_1)
	{
		JK.OEL(P_0, P_1 ? SelectiveScrollingOrientation.Vertical : SelectiveScrollingOrientation.Both);
	}

	protected abstract Control CreateCellElement(TreeListViewColumn column);

	protected abstract void OnColumnPropertyChanged(TreeListViewColumn column, string propertyName);

	protected virtual void UpdateAllCellElementContent()
	{
	}

	protected internal virtual void UpdateAllCellElementZIndexes()
	{
	}

	internal static bool asS()
	{
		return ssx == null;
	}

	internal static TreeListViewRowPanelBase ss1()
	{
		return ssx;
	}
}
