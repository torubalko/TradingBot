using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids;

[ContentProperty("CellTemplate")]
public class TreeListViewColumn : DependencyObject, INotifyPropertyChanged
{
	private double AqO;

	private double oqw;

	private double LqX;

	private double Hq2;

	private BindingBase Jqv;

	private bool Aq8;

	private double lq9;

	private double eq3;

	private WeakReference YqL;

	internal static readonly Thickness jqj;

	public static readonly DependencyProperty AutoWidthModeProperty;

	public static readonly DependencyProperty CanReorderProperty;

	public static readonly DependencyProperty CanResizeProperty;

	public static readonly DependencyProperty CanToggleVisibilityProperty;

	public static readonly DependencyProperty CellBorderThicknessProperty;

	public static readonly DependencyProperty CellContainerStyleProperty;

	public static readonly DependencyProperty CellHorizontalAlignmentProperty;

	public static readonly DependencyProperty CellPaddingProperty;

	public static readonly DependencyProperty CellTemplateProperty;

	public static readonly DependencyProperty CellTemplateSelectorProperty;

	public static readonly DependencyProperty CellVerticalAlignmentProperty;

	public static readonly DependencyProperty HeaderProperty;

	public static readonly DependencyProperty HeaderCellBorderThicknessProperty;

	public static readonly DependencyProperty HeaderCellPaddingProperty;

	public static readonly DependencyProperty HeaderContainerStyleProperty;

	public static readonly DependencyProperty HeaderHorizontalAlignmentProperty;

	public static readonly DependencyProperty HeaderTemplateProperty;

	public static readonly DependencyProperty HeaderTemplateSelectorProperty;

	public static readonly DependencyProperty IndexProperty;

	public static readonly DependencyProperty IsFrozenProperty;

	public static readonly DependencyProperty IsResizeGripperEnabledProperty;

	public static readonly DependencyProperty IsVisibleProperty;

	public static readonly DependencyProperty MaxWidthProperty;

	public static readonly DependencyProperty MinWidthProperty;

	public static readonly DependencyProperty SortDirectionProperty;

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty WidthProperty;

	[CompilerGenerated]
	private ICommand Xqx;

	[CompilerGenerated]
	private ICommand yqa;

	internal static TreeListViewColumn wWH;

	public double ActualWidth
	{
		get
		{
			return AqO;
		}
		internal set
		{
			if (!double.IsNaN(value) && !double.IsInfinity(value) && value >= 0.0 && AqO != value)
			{
				AqO = value;
				H6v(xv.hTz(7270));
				VqY()?.i6U();
			}
		}
	}

	public TreeListViewColumnAutoWidthMode AutoWidthMode
	{
		get
		{
			return (TreeListViewColumnAutoWidthMode)GetValue(AutoWidthModeProperty);
		}
		set
		{
			SetValue(AutoWidthModeProperty, value);
		}
	}

	public bool? CanReorder
	{
		get
		{
			return (bool?)GetValue(CanReorderProperty);
		}
		set
		{
			SetValue(CanReorderProperty, value);
		}
	}

	public bool? CanResize
	{
		get
		{
			return (bool?)GetValue(CanResizeProperty);
		}
		set
		{
			SetValue(CanResizeProperty, value);
		}
	}

	public bool? CanToggleVisibility
	{
		get
		{
			return (bool?)GetValue(CanToggleVisibilityProperty);
		}
		set
		{
			SetValue(CanToggleVisibilityProperty, value);
		}
	}

	public Thickness CellBorderThickness
	{
		get
		{
			return (Thickness)GetValue(CellBorderThicknessProperty);
		}
		set
		{
			SetValue(CellBorderThicknessProperty, value);
		}
	}

	public Style CellContainerStyle
	{
		get
		{
			return (Style)GetValue(CellContainerStyleProperty);
		}
		set
		{
			SetValue(CellContainerStyleProperty, value);
		}
	}

	public HorizontalAlignment CellHorizontalAlignment
	{
		get
		{
			return (HorizontalAlignment)GetValue(CellHorizontalAlignmentProperty);
		}
		set
		{
			SetValue(CellHorizontalAlignmentProperty, value);
		}
	}

	public Thickness CellPadding
	{
		get
		{
			return (Thickness)GetValue(CellPaddingProperty);
		}
		set
		{
			SetValue(CellPaddingProperty, value);
		}
	}

	public DataTemplate CellTemplate
	{
		get
		{
			return (DataTemplate)GetValue(CellTemplateProperty);
		}
		set
		{
			SetValue(CellTemplateProperty, value);
		}
	}

	public DataTemplateSelector CellTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(CellTemplateSelectorProperty);
		}
		set
		{
			SetValue(CellTemplateSelectorProperty, value);
		}
	}

	public VerticalAlignment CellVerticalAlignment
	{
		get
		{
			return (VerticalAlignment)GetValue(CellVerticalAlignmentProperty);
		}
		set
		{
			SetValue(CellVerticalAlignmentProperty, value);
		}
	}

	public double ClipX
	{
		get
		{
			return oqw;
		}
		internal set
		{
			if (oqw != value)
			{
				oqw = value;
				H6v(xv.hTz(7296));
			}
		}
	}

	public BindingBase DisplayMemberBinding
	{
		get
		{
			return Jqv;
		}
		set
		{
			if (Jqv != value)
			{
				Jqv = value;
				H6v(xv.hTz(7310));
			}
		}
	}

	public object Header
	{
		get
		{
			return GetValue(HeaderProperty);
		}
		set
		{
			SetValue(HeaderProperty, value);
		}
	}

	public Thickness HeaderCellBorderThickness
	{
		get
		{
			return (Thickness)GetValue(HeaderCellBorderThicknessProperty);
		}
		set
		{
			SetValue(HeaderCellBorderThicknessProperty, value);
		}
	}

	public Thickness HeaderCellPadding
	{
		get
		{
			return (Thickness)GetValue(HeaderCellPaddingProperty);
		}
		set
		{
			SetValue(HeaderCellPaddingProperty, value);
		}
	}

	public Style HeaderContainerStyle
	{
		get
		{
			return (Style)GetValue(HeaderContainerStyleProperty);
		}
		set
		{
			SetValue(HeaderContainerStyleProperty, value);
		}
	}

	public HorizontalAlignment HeaderHorizontalAlignment
	{
		get
		{
			return (HorizontalAlignment)GetValue(HeaderHorizontalAlignmentProperty);
		}
		set
		{
			SetValue(HeaderHorizontalAlignmentProperty, value);
		}
	}

	public DataTemplate HeaderTemplate
	{
		get
		{
			return (DataTemplate)GetValue(HeaderTemplateProperty);
		}
		set
		{
			SetValue(HeaderTemplateProperty, value);
		}
	}

	public DataTemplateSelector HeaderTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(HeaderTemplateSelectorProperty);
		}
		set
		{
			SetValue(HeaderTemplateSelectorProperty, value);
		}
	}

	public int Index
	{
		get
		{
			return (int)GetValue(IndexProperty);
		}
		internal set
		{
			SetValue(IndexProperty, value);
		}
	}

	public bool IsFrozen
	{
		get
		{
			return (bool)GetValue(IsFrozenProperty);
		}
		internal set
		{
			SetValue(IsFrozenProperty, value);
		}
	}

	public bool IsResizeGripperEnabled
	{
		get
		{
			return (bool)GetValue(IsResizeGripperEnabledProperty);
		}
		private set
		{
			SetValue(IsResizeGripperEnabledProperty, value);
		}
	}

	public bool IsVisible
	{
		get
		{
			return (bool)GetValue(IsVisibleProperty);
		}
		set
		{
			SetValue(IsVisibleProperty, value);
		}
	}

	public double MaxWidth
	{
		get
		{
			return (double)GetValue(MaxWidthProperty);
		}
		set
		{
			SetValue(MaxWidthProperty, value);
		}
	}

	public double MinWidth
	{
		get
		{
			return (double)GetValue(MinWidthProperty);
		}
		set
		{
			SetValue(MinWidthProperty, value);
		}
	}

	public ICommand SizeToFitCommand
	{
		[CompilerGenerated]
		get
		{
			return Xqx;
		}
		[CompilerGenerated]
		private set
		{
			Xqx = value;
		}
	}

	public ColumnSortDirection? SortDirection
	{
		get
		{
			return (ColumnSortDirection?)GetValue(SortDirectionProperty);
		}
		set
		{
			SetValue(SortDirectionProperty, value);
		}
	}

	public string Title
	{
		get
		{
			return (string)GetValue(TitleProperty);
		}
		set
		{
			SetValue(TitleProperty, value);
		}
	}

	public ICommand ToggleVisibilityCommand
	{
		[CompilerGenerated]
		get
		{
			return yqa;
		}
		[CompilerGenerated]
		private set
		{
			yqa = value;
		}
	}

	public GridLength Width
	{
		get
		{
			return (GridLength)GetValue(WidthProperty);
		}
		set
		{
			SetValue(WidthProperty, value);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public TreeListViewColumn()
	{
		fc.taYSkz();
		lq9 = double.PositiveInfinity;
		base._002Ector();
		T6X();
	}

	[SpecialName]
	internal bool rqq()
	{
		if (CanReorder.HasValue)
		{
			return CanReorder.Value;
		}
		return VqY()?.CanColumnsReorder ?? false;
	}

	[SpecialName]
	internal bool yq5()
	{
		if (CanToggleVisibility.HasValue)
		{
			return CanToggleVisibility.Value;
		}
		return VqY()?.CanColumnsToggleVisibility ?? false;
	}

	private void T6X()
	{
		SizeToFitCommand = new DelegateCommand<object>(delegate
		{
			SizeToFit();
		});
		ToggleVisibilityCommand = new DelegateCommand<object>(delegate
		{
			IsVisible = !IsVisible;
		}, (object P_0) => yq5());
	}

	[SpecialName]
	internal double Bqn()
	{
		return AutoWidthMode switch
		{
			TreeListViewColumnAutoWidthMode.HeaderOnly => LqX, 
			TreeListViewColumnAutoWidthMode.ItemsOnly => Hq2, 
			_ => Math.Max(LqX, Hq2), 
		};
	}

	internal void k62(bool P_0, double P_1)
	{
		if (P_0)
		{
			if (LqX != P_1)
			{
				LqX = P_1;
				if (Width.GridUnitType == GridUnitType.Auto && AutoWidthMode != TreeListViewColumnAutoWidthMode.ItemsOnly)
				{
					Fq1();
				}
			}
		}
		else
		{
			if (!(P_1 > Hq2))
			{
				return;
			}
			Hq2 = P_1;
			if (Width.GridUnitType == GridUnitType.Auto && AutoWidthMode != TreeListViewColumnAutoWidthMode.HeaderOnly)
			{
				int num = 0;
				if (MW0() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Fq1();
			}
		}
	}

	[SpecialName]
	internal bool nqE()
	{
		TreeListView treeListView = VqY();
		if (treeListView != null)
		{
			int expansionColumnIndex = treeListView.ExpansionColumnIndex;
			if (expansionColumnIndex >= 0 && expansionColumnIndex < treeListView.Columns.Count)
			{
				return treeListView.Columns[expansionColumnIndex] == this;
			}
		}
		return false;
	}

	[SpecialName]
	internal bool nqK()
	{
		return Aq8;
	}

	[SpecialName]
	internal void YqN(bool value)
	{
		Aq8 = value;
	}

	[SpecialName]
	internal double iqg()
	{
		return lq9;
	}

	[SpecialName]
	internal double NqT()
	{
		return eq3;
	}

	private void H6v(string P_0)
	{
		e64(new PropertyChangedEventArgs(P_0));
	}

	private static void h68(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListViewColumn obj = (TreeListViewColumn)P_0;
		obj.lqI();
		obj.H6v(xv.hTz(6504));
	}

	private static void E69(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).CqP();
	}

	private static void F63(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6534));
	}

	private static void s6L(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6576));
	}

	private static void I6j(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6616));
	}

	private static void K6x(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6666));
	}

	private static void r6a(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6692));
	}

	private static void E6i(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6720));
	}

	private static void w6b(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6764));
	}

	private static void G6h(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6810));
	}

	private static void c6Z(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6826));
	}

	private static void s6H(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6880));
	}

	private static void V6D(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6918));
	}

	private static void O67(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6962));
	}

	private static void X6s(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(6994));
	}

	private static void P6F(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(7048));
	}

	private static void s6c(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(7096));
	}

	private static void d6V(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(7116));
	}

	private static void W6f(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListViewColumn treeListViewColumn = (TreeListViewColumn)P_0;
		treeListViewColumn.H6v(xv.hTz(7164));
		treeListViewColumn.VqY()?.X6m(new TreeListViewColumnEventArgs(treeListViewColumn));
	}

	private static void b60(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListViewColumn obj = (TreeListViewColumn)P_0;
		obj.Fq1();
		obj.H6v(xv.hTz(7186));
	}

	private static void g6A(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListViewColumn obj = (TreeListViewColumn)P_0;
		obj.Fq1();
		obj.H6v(xv.hTz(7206));
	}

	private void e64(PropertyChangedEventArgs P_0)
	{
		this.PropertyChanged?.Invoke(this, P_0);
	}

	private static void U6S(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumn)P_0).H6v(xv.hTz(7226));
	}

	private static void N6z(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListViewColumn treeListViewColumn = (TreeListViewColumn)P_0;
		treeListViewColumn.lqI();
		treeListViewColumn.Fq1();
		treeListViewColumn.H6v(xv.hTz(7256));
		TreeListView treeListView = treeListViewColumn.VqY();
		GridLength gridLength = (GridLength)P_1.OldValue;
		GridLength gridLength2 = (GridLength)P_1.NewValue;
		if (treeListView != null)
		{
			int num = 0;
			if (!RWG())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (gridLength.IsStar != gridLength2.IsStar)
			{
				treeListView.O6K();
				return;
			}
		}
		treeListViewColumn.CqP();
	}

	[SpecialName]
	internal TreeListView VqY()
	{
		if (YqL != null)
		{
			if (YqL.IsAlive)
			{
				return YqL.Target as TreeListView;
			}
			YqL = null;
		}
		return null;
	}

	[SpecialName]
	internal void mqk(TreeListView value)
	{
		if (VqY() != value)
		{
			YqL = ((value != null) ? new WeakReference(value) : null);
			CqP();
		}
	}

	internal void lqI()
	{
		LqX = 0.0;
		Hq2 = 0.0;
	}

	[SpecialName]
	internal string cqy()
	{
		string text = Title;
		if (string.IsNullOrEmpty(text))
		{
			text = Header as string;
		}
		return text;
	}

	internal void CqP()
	{
		TreeListView treeListView = VqY();
		bool? canResize = CanResize;
		bool num;
		if (!canResize.HasValue)
		{
			if (treeListView == null)
			{
				goto IL_007d;
			}
			num = treeListView.CanColumnsResize;
		}
		else
		{
			num = canResize == true;
		}
		if (num)
		{
			if (Width.GridUnitType == GridUnitType.Star)
			{
				IsResizeGripperEnabled = treeListView != null && treeListView.Q6t(this) != null;
			}
			else
			{
				IsResizeGripperEnabled = true;
			}
			return;
		}
		goto IL_007d;
		IL_007d:
		IsResizeGripperEnabled = false;
	}

	private void Fq1()
	{
		double num = MinWidth;
		if (num < 0.0 || double.IsNaN(num) || double.IsInfinity(num))
		{
			num = 0.0;
		}
		double num2 = MaxWidth;
		int num3;
		if (!(num2 < num))
		{
			if (double.IsNaN(num2))
			{
				num3 = 2;
				if (MW0() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			if (double.IsNegativeInfinity(num2))
			{
				goto IL_01d1;
			}
		}
		else
		{
			num2 = num;
		}
		goto IL_00fb;
		IL_00fb:
		GridLength width = Width;
		double num4 = width.Value;
		GridUnitType gridUnitType = width.GridUnitType;
		if (gridUnitType == GridUnitType.Auto)
		{
			goto IL_01af;
		}
		if (gridUnitType != GridUnitType.Star)
		{
			if (double.IsNaN(num4) || double.IsInfinity(num4))
			{
				num4 = Bqn();
			}
			goto IL_008a;
		}
		num3 = 1;
		if (!RWG())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num5 = default(int);
		num3 = num5;
		goto IL_0009;
		IL_008a:
		if (!double.IsPositiveInfinity(num2))
		{
			num4 = Math.Min(num2, num4);
		}
		num4 = Math.Max(num, num4);
		eq3 = num;
		lq9 = num2;
		ActualWidth = num4;
		return;
		IL_0009:
		switch (num3)
		{
		case 1:
			goto IL_01af;
		case 2:
			goto IL_01d1;
		}
		goto IL_008a;
		IL_01d1:
		num2 = double.PositiveInfinity;
		goto IL_00fb;
		IL_01af:
		num4 = Bqn();
		num3 = 0;
		if (MW0() != null)
		{
			num3 = 0;
		}
		goto IL_0009;
	}

	public void SizeToFit()
	{
		YqN(value: true);
		if (Width.GridUnitType == GridUnitType.Auto)
		{
			Width = new GridLength(ActualWidth);
		}
		Width = GridLength.Auto;
	}

	static TreeListViewColumn()
	{
		fc.taYSkz();
		jqj = new Thickness(7.0, 2.0, 7.0, 2.0);
		AutoWidthModeProperty = DependencyProperty.Register(xv.hTz(6504), typeof(TreeListViewColumnAutoWidthMode), typeof(TreeListViewColumn), new PropertyMetadata(TreeListViewColumnAutoWidthMode.Both, h68));
		CanReorderProperty = DependencyProperty.Register(xv.hTz(7354), typeof(bool?), typeof(TreeListViewColumn), new PropertyMetadata(null));
		int num = 0;
		if (false)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num)
			{
			default:
				CanResizeProperty = DependencyProperty.Register(xv.hTz(7378), typeof(bool?), typeof(TreeListViewColumn), new PropertyMetadata(null, E69));
				CanToggleVisibilityProperty = DependencyProperty.Register(xv.hTz(7400), typeof(bool?), typeof(TreeListViewColumn), new PropertyMetadata(null));
				CellBorderThicknessProperty = DependencyProperty.Register(xv.hTz(6534), typeof(Thickness), typeof(TreeListViewColumn), new PropertyMetadata(new Thickness(0.0), F63));
				CellContainerStyleProperty = DependencyProperty.Register(xv.hTz(6576), typeof(Style), typeof(TreeListViewColumn), new PropertyMetadata(null, s6L));
				CellHorizontalAlignmentProperty = DependencyProperty.Register(xv.hTz(6616), typeof(HorizontalAlignment), typeof(TreeListViewColumn), new PropertyMetadata(HorizontalAlignment.Stretch, I6j));
				CellPaddingProperty = DependencyProperty.Register(xv.hTz(6666), typeof(Thickness), typeof(TreeListViewColumn), new PropertyMetadata(jqj, K6x));
				CellTemplateProperty = DependencyProperty.Register(xv.hTz(6692), typeof(DataTemplate), typeof(TreeListViewColumn), new PropertyMetadata(null, r6a));
				CellTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(6720), typeof(DataTemplateSelector), typeof(TreeListViewColumn), new PropertyMetadata(null, E6i));
				CellVerticalAlignmentProperty = DependencyProperty.Register(xv.hTz(6764), typeof(VerticalAlignment), typeof(TreeListViewColumn), new PropertyMetadata(VerticalAlignment.Center, w6b));
				num = 2;
				if (false)
				{
					num = 2;
				}
				goto IL_0009_2;
			case 2:
				break;
			case 1:
				IndexProperty = DependencyProperty.Register(xv.hTz(7442), typeof(int), typeof(TreeListViewColumn), new PropertyMetadata(0));
				IsFrozenProperty = DependencyProperty.Register(xv.hTz(7096), typeof(bool), typeof(TreeListViewColumn), new PropertyMetadata(false, s6c));
				IsResizeGripperEnabledProperty = DependencyProperty.Register(xv.hTz(7116), typeof(bool), typeof(TreeListViewColumn), new PropertyMetadata(true, d6V));
				IsVisibleProperty = DependencyProperty.Register(xv.hTz(7164), typeof(bool), typeof(TreeListViewColumn), new PropertyMetadata(true, W6f));
				MaxWidthProperty = DependencyProperty.Register(xv.hTz(7186), typeof(double), typeof(TreeListViewColumn), new PropertyMetadata(double.NaN, b60));
				MinWidthProperty = DependencyProperty.Register(xv.hTz(7206), typeof(double), typeof(TreeListViewColumn), new PropertyMetadata(30.0, g6A));
				SortDirectionProperty = DependencyProperty.Register(xv.hTz(7226), typeof(ColumnSortDirection?), typeof(TreeListViewColumn), new PropertyMetadata(null, U6S));
				TitleProperty = DependencyProperty.Register(xv.hTz(7456), typeof(string), typeof(TreeListViewColumn), new PropertyMetadata(null));
				WidthProperty = DependencyProperty.Register(xv.hTz(7256), typeof(GridLength), typeof(TreeListViewColumn), new PropertyMetadata(GridLength.Auto, N6z));
				return;
			}
			HeaderProperty = DependencyProperty.Register(xv.hTz(6810), typeof(object), typeof(TreeListViewColumn), new PropertyMetadata(null, G6h));
			HeaderCellBorderThicknessProperty = DependencyProperty.Register(xv.hTz(6826), typeof(Thickness), typeof(TreeListViewColumn), new PropertyMetadata(new Thickness(0.0, 0.0, 1.0, 1.0), c6Z));
			HeaderCellPaddingProperty = DependencyProperty.Register(xv.hTz(6880), typeof(Thickness), typeof(TreeListViewColumn), new PropertyMetadata(jqj, s6H));
			HeaderContainerStyleProperty = DependencyProperty.Register(xv.hTz(6918), typeof(Style), typeof(TreeListViewColumn), new PropertyMetadata(null, V6D));
			HeaderHorizontalAlignmentProperty = DependencyProperty.Register(xv.hTz(6994), typeof(HorizontalAlignment), typeof(TreeListViewColumn), new PropertyMetadata(HorizontalAlignment.Left, X6s));
			HeaderTemplateProperty = DependencyProperty.Register(xv.hTz(6962), typeof(DataTemplate), typeof(TreeListViewColumn), new PropertyMetadata(null, O67));
			HeaderTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(7048), typeof(DataTemplateSelector), typeof(TreeListViewColumn), new PropertyMetadata(null, P6F));
			num = 1;
		}
		while (true);
		goto IL_0005;
	}

	[CompilerGenerated]
	private void Oqt(object P_0)
	{
		SizeToFit();
	}

	[CompilerGenerated]
	private void YqU(object P_0)
	{
		IsVisible = !IsVisible;
	}

	[CompilerGenerated]
	private bool Qq6(object P_0)
	{
		return yq5();
	}

	internal static bool RWG()
	{
		return wWH == null;
	}

	internal static TreeListViewColumn MW0()
	{
		return wWH;
	}
}
