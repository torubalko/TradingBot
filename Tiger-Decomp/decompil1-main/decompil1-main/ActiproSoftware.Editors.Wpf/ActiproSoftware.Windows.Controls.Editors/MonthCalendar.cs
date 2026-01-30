using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;
using ActiproSoftware.Windows.Media.Animation;

namespace ActiproSoftware.Windows.Controls.Editors;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public class MonthCalendar : Control
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public MonthCalendar duB;

		public DateTime Nuh;

		public DateTime Guw;

		public DaysOfWeek SuN;

		internal static _003C_003Ec__DisplayClass101_0 st2;

		public _003C_003Ec__DisplayClass101_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal bool du4(DateTime d)
		{
			return duB.E2r(d.Date, Nuh, Guw, SuN);
		}

		internal static bool ctl()
		{
			return st2 == null;
		}

		internal static _003C_003Ec__DisplayClass101_0 HtV()
		{
			return st2;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public MonthCalendar Vuz;

		public DateTime AKQ;

		public DateTime MKV;

		public DaysOfWeek eKC;

		internal static _003C_003Ec__DisplayClass102_0 atu;

		public _003C_003Ec__DisplayClass102_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal bool suU(DateTime d)
		{
			return Vuz.E2r(d.Date, AKQ, MKV, eKC);
		}

		internal static bool YtH()
		{
			return atu == null;
		}

		internal static _003C_003Ec__DisplayClass102_0 ntU()
		{
			return atu;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public MonthCalendar KKM;

		public DateTime cKs;

		public DateTime tKj;

		public DaysOfWeek HKP;

		private static _003C_003Ec__DisplayClass103_0 rt9;

		public _003C_003Ec__DisplayClass103_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal bool kK6(DateTime d)
		{
			return KKM.E2r(d.Date, cKs, tKj, HKP);
		}

		internal static bool StM()
		{
			return rt9 == null;
		}

		internal static _003C_003Ec__DisplayClass103_0 CtT()
		{
			return rt9;
		}
	}

	private DateTime? KaZ;

	private bool Tat;

	private TransitionPresenter Nan;

	private bool aaJ;

	private DateRangeCollection Vae;

	private bool tak;

	private DelegateCommand<object> paE;

	private DelegateCommand<object> la7;

	private DelegateCommand<object> ya4;

	public static readonly DependencyProperty ActiveDateProperty;

	public static readonly DependencyProperty ActiveViewModeProperty;

	public static readonly DependencyProperty CalendarWeekRuleProperty;

	public static readonly DependencyProperty CanRetainTimeProperty;

	public static readonly DependencyProperty ClearButtonStyleProperty;

	public static readonly DependencyProperty ClearButtonTextProperty;

	public static readonly DependencyProperty DayItemsPanelTemplateProperty;

	public static readonly DependencyProperty DayItemTemplateProperty;

	public static readonly DependencyProperty DayItemTemplateSelectorProperty;

	public static readonly DependencyProperty DayNameItemsPanelTemplateProperty;

	public static readonly DependencyProperty DayNameItemContainerStyleProperty;

	public static readonly DependencyProperty DayNameItemTemplateProperty;

	public static readonly DependencyProperty DayOfWeekFormatPatternProperty;

	public static readonly DependencyProperty DecadeItemsPanelTemplateProperty;

	public static readonly DependencyProperty DecadeItemTemplateProperty;

	public static readonly DependencyProperty DisabledDaysOfWeekProperty;

	public static readonly DependencyProperty FirstDayOfWeekProperty;

	public static readonly DependencyProperty IsClearButtonVisibleProperty;

	public static readonly DependencyProperty IsDateDisabledFuncProperty;

	public static readonly DependencyProperty IsDayOfWeekSelectionEnabledProperty;

	public static readonly DependencyProperty IsTodayButtonVisibleProperty;

	public static readonly DependencyProperty IsTodayHighlightedProperty;

	public static readonly DependencyProperty IsWeekNumberColumnVisibleProperty;

	public static readonly DependencyProperty IsWeekNumberSelectionEnabledProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MaxSelectionCountProperty;

	public static readonly DependencyProperty MaxViewModeProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty MonthItemsPanelTemplateProperty;

	public static readonly DependencyProperty MonthItemTemplateProperty;

	public static readonly DependencyProperty NavigationButtonStyleProperty;

	public static readonly DependencyProperty SelectedDateProperty;

	public static readonly DependencyProperty SelectionModeProperty;

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty TitleButtonStyleProperty;

	public static readonly DependencyProperty TodayButtonStyleProperty;

	public static readonly DependencyProperty TodayButtonTextProperty;

	public static readonly DependencyProperty ViewResetModeProperty;

	public static readonly DependencyProperty WeekNumberItemsPanelTemplateProperty;

	public static readonly DependencyProperty WeekNumberItemContainerStyleProperty;

	public static readonly DependencyProperty WeekNumberItemTemplateProperty;

	public static readonly DependencyProperty YearItemsPanelTemplateProperty;

	public static readonly DependencyProperty YearItemTemplateProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler PaB;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler jah;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ICommand Oaw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICommand QaN;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ICommand TaU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICommand daz;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICommand cfQ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICommand lfV;

	internal static MonthCalendar cW7;

	public DateTime ActiveDate
	{
		get
		{
			return (DateTime)GetValue(ActiveDateProperty);
		}
		set
		{
			SetValue(ActiveDateProperty, value);
		}
	}

	public MonthCalendarViewMode ActiveViewMode
	{
		get
		{
			return (MonthCalendarViewMode)GetValue(ActiveViewModeProperty);
		}
		set
		{
			SetValue(ActiveViewModeProperty, value);
		}
	}

	public CalendarWeekRule? CalendarWeekRule
	{
		get
		{
			return (CalendarWeekRule?)GetValue(CalendarWeekRuleProperty);
		}
		set
		{
			SetValue(CalendarWeekRuleProperty, value);
		}
	}

	public bool CanRetainTime
	{
		get
		{
			return (bool)GetValue(CanRetainTimeProperty);
		}
		set
		{
			SetValue(CanRetainTimeProperty, value);
		}
	}

	public Style ClearButtonStyle
	{
		get
		{
			return (Style)GetValue(ClearButtonStyleProperty);
		}
		set
		{
			SetValue(ClearButtonStyleProperty, value);
		}
	}

	public string ClearButtonText
	{
		get
		{
			return (string)GetValue(ClearButtonTextProperty);
		}
		set
		{
			SetValue(ClearButtonTextProperty, value);
		}
	}

	public ICommand ClearSelectionCommand
	{
		[CompilerGenerated]
		get
		{
			return Oaw;
		}
		[CompilerGenerated]
		private set
		{
			Oaw = value;
		}
	}

	public ItemsPanelTemplate DayItemsPanelTemplate
	{
		get
		{
			return (ItemsPanelTemplate)GetValue(DayItemsPanelTemplateProperty);
		}
		set
		{
			SetValue(DayItemsPanelTemplateProperty, value);
		}
	}

	public DataTemplate DayItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DayItemTemplateProperty);
		}
		set
		{
			SetValue(DayItemTemplateProperty, value);
		}
	}

	public DataTemplateSelector DayItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(DayItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(DayItemTemplateSelectorProperty, value);
		}
	}

	public ItemsPanelTemplate DayNameItemsPanelTemplate
	{
		get
		{
			return (ItemsPanelTemplate)GetValue(DayNameItemsPanelTemplateProperty);
		}
		set
		{
			SetValue(DayNameItemsPanelTemplateProperty, value);
		}
	}

	public DataTemplate DayNameItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DayNameItemTemplateProperty);
		}
		set
		{
			SetValue(DayNameItemTemplateProperty, value);
		}
	}

	public Style DayNameItemContainerStyle
	{
		get
		{
			return (Style)GetValue(DayNameItemContainerStyleProperty);
		}
		set
		{
			SetValue(DayNameItemContainerStyleProperty, value);
		}
	}

	public DayOfWeekFormatPattern DayOfWeekFormatPattern
	{
		get
		{
			return (DayOfWeekFormatPattern)GetValue(DayOfWeekFormatPatternProperty);
		}
		set
		{
			SetValue(DayOfWeekFormatPatternProperty, value);
		}
	}

	public ItemsPanelTemplate DecadeItemsPanelTemplate
	{
		get
		{
			return (ItemsPanelTemplate)GetValue(DecadeItemsPanelTemplateProperty);
		}
		set
		{
			SetValue(DecadeItemsPanelTemplateProperty, value);
		}
	}

	public DataTemplate DecadeItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DecadeItemTemplateProperty);
		}
		set
		{
			SetValue(DecadeItemTemplateProperty, value);
		}
	}

	public DaysOfWeek DisabledDaysOfWeek
	{
		get
		{
			return (DaysOfWeek)GetValue(DisabledDaysOfWeekProperty);
		}
		set
		{
			SetValue(DisabledDaysOfWeekProperty, value);
		}
	}

	public DayOfWeek? FirstDayOfWeek
	{
		get
		{
			return (DayOfWeek?)GetValue(FirstDayOfWeekProperty);
		}
		set
		{
			SetValue(FirstDayOfWeekProperty, value);
		}
	}

	public ICommand GoToNextViewCommand
	{
		[CompilerGenerated]
		get
		{
			return QaN;
		}
		[CompilerGenerated]
		private set
		{
			QaN = value;
		}
	}

	public ICommand GoToPreviousViewCommand
	{
		[CompilerGenerated]
		get
		{
			return TaU;
		}
		[CompilerGenerated]
		private set
		{
			TaU = value;
		}
	}

	public bool IsClearButtonVisible
	{
		get
		{
			return (bool)GetValue(IsClearButtonVisibleProperty);
		}
		set
		{
			SetValue(IsClearButtonVisibleProperty, value);
		}
	}

	public Func<DateTime, bool> IsDateDisabledFunc
	{
		get
		{
			return (Func<DateTime, bool>)GetValue(IsDateDisabledFuncProperty);
		}
		set
		{
			SetValue(IsDateDisabledFuncProperty, value);
		}
	}

	public bool IsDayOfWeekSelectionEnabled
	{
		get
		{
			return (bool)GetValue(IsDayOfWeekSelectionEnabledProperty);
		}
		set
		{
			SetValue(IsDayOfWeekSelectionEnabledProperty, value);
		}
	}

	public bool IsTodayButtonVisible
	{
		get
		{
			return (bool)GetValue(IsTodayButtonVisibleProperty);
		}
		set
		{
			SetValue(IsTodayButtonVisibleProperty, value);
		}
	}

	public bool IsTodayHighlighted
	{
		get
		{
			return (bool)GetValue(IsTodayHighlightedProperty);
		}
		set
		{
			SetValue(IsTodayHighlightedProperty, value);
		}
	}

	public bool IsWeekNumberColumnVisible
	{
		get
		{
			return (bool)GetValue(IsWeekNumberColumnVisibleProperty);
		}
		set
		{
			SetValue(IsWeekNumberColumnVisibleProperty, value);
		}
	}

	public bool IsWeekNumberSelectionEnabled
	{
		get
		{
			return (bool)GetValue(IsWeekNumberSelectionEnabledProperty);
		}
		set
		{
			SetValue(IsWeekNumberSelectionEnabledProperty, value);
		}
	}

	public DateTime Maximum
	{
		get
		{
			return (DateTime)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public int MaxSelectionCount
	{
		get
		{
			return (int)GetValue(MaxSelectionCountProperty);
		}
		set
		{
			SetValue(MaxSelectionCountProperty, value);
		}
	}

	public MonthCalendarViewMode MaxViewMode
	{
		get
		{
			return (MonthCalendarViewMode)GetValue(MaxViewModeProperty);
		}
		set
		{
			SetValue(MaxViewModeProperty, value);
		}
	}

	public DateTime Minimum
	{
		get
		{
			return (DateTime)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public ItemsPanelTemplate MonthItemsPanelTemplate
	{
		get
		{
			return (ItemsPanelTemplate)GetValue(MonthItemsPanelTemplateProperty);
		}
		set
		{
			SetValue(MonthItemsPanelTemplateProperty, value);
		}
	}

	public DataTemplate MonthItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(MonthItemTemplateProperty);
		}
		set
		{
			SetValue(MonthItemTemplateProperty, value);
		}
	}

	public Style NavigationButtonStyle
	{
		get
		{
			return (Style)GetValue(NavigationButtonStyleProperty);
		}
		set
		{
			SetValue(NavigationButtonStyleProperty, value);
		}
	}

	public ICommand SelectDateCommand
	{
		[CompilerGenerated]
		get
		{
			return daz;
		}
		[CompilerGenerated]
		private set
		{
			daz = value;
		}
	}

	public ICommand SelectDayOfWeekCommand => paE;

	public DateTime? SelectedDate
	{
		get
		{
			return (DateTime?)GetValue(SelectedDateProperty);
		}
		set
		{
			SetValue(SelectedDateProperty, value);
		}
	}

	public DateRangeCollection SelectedDates => Vae;

	public MonthCalendarSelectionMode SelectionMode
	{
		get
		{
			return (MonthCalendarSelectionMode)GetValue(SelectionModeProperty);
		}
		set
		{
			SetValue(SelectionModeProperty, value);
		}
	}

	public ICommand SelectTodayCommand => la7;

	public ICommand SelectWeekCommand => ya4;

	public string Title
	{
		get
		{
			return (string)GetValue(TitleProperty);
		}
		private set
		{
			SetValue(TitleProperty, value);
		}
	}

	public Style TitleButtonStyle
	{
		get
		{
			return (Style)GetValue(TitleButtonStyleProperty);
		}
		set
		{
			SetValue(TitleButtonStyleProperty, value);
		}
	}

	public Style TodayButtonStyle
	{
		get
		{
			return (Style)GetValue(TodayButtonStyleProperty);
		}
		set
		{
			SetValue(TodayButtonStyleProperty, value);
		}
	}

	public string TodayButtonText
	{
		get
		{
			return (string)GetValue(TodayButtonTextProperty);
		}
		private set
		{
			SetValue(TodayButtonTextProperty, value);
		}
	}

	public MonthCalendarViewResetMode ViewResetMode
	{
		get
		{
			return (MonthCalendarViewResetMode)GetValue(ViewResetModeProperty);
		}
		set
		{
			SetValue(ViewResetModeProperty, value);
		}
	}

	public ItemsPanelTemplate WeekNumberItemsPanelTemplate
	{
		get
		{
			return (ItemsPanelTemplate)GetValue(WeekNumberItemsPanelTemplateProperty);
		}
		set
		{
			SetValue(WeekNumberItemsPanelTemplateProperty, value);
		}
	}

	public DataTemplate WeekNumberItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(WeekNumberItemTemplateProperty);
		}
		set
		{
			SetValue(WeekNumberItemTemplateProperty, value);
		}
	}

	public Style WeekNumberItemContainerStyle
	{
		get
		{
			return (Style)GetValue(WeekNumberItemContainerStyleProperty);
		}
		set
		{
			SetValue(WeekNumberItemContainerStyleProperty, value);
		}
	}

	public ItemsPanelTemplate YearItemsPanelTemplate
	{
		get
		{
			return (ItemsPanelTemplate)GetValue(YearItemsPanelTemplateProperty);
		}
		set
		{
			SetValue(YearItemsPanelTemplateProperty, value);
		}
	}

	public DataTemplate YearItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(YearItemTemplateProperty);
		}
		set
		{
			SetValue(YearItemTemplateProperty, value);
		}
	}

	public ICommand ZoomInCommand
	{
		[CompilerGenerated]
		get
		{
			return cfQ;
		}
		[CompilerGenerated]
		private set
		{
			cfQ = value;
		}
	}

	public ICommand ZoomOutCommand
	{
		[CompilerGenerated]
		get
		{
			return lfV;
		}
		[CompilerGenerated]
		private set
		{
			lfV = value;
		}
	}

	public event EventHandler SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = PaB;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PaB, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = PaB;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PaB, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler SelectionCommitted
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = jah;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jah, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = jah;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jah, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public MonthCalendar()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(MonthCalendar);
		Kag();
		X2K();
		Vae = new DateRangeCollection();
		Vae.CollectionChanged += b2w;
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
		base.Unloaded += c2N;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void X2K()
	{
		ClearSelectionCommand = new DelegateCommand<object>(delegate
		{
			SelectedDate = null;
			OaQ();
		});
		GoToNextViewCommand = new DelegateCommand<object>(delegate
		{
			v2m();
		}, delegate
		{
			try
			{
				return Maximum > ldZ.QbJ(ActiveViewMode, ActiveDate);
			}
			catch (ArgumentException)
			{
				return false;
			}
		});
		GoToPreviousViewCommand = new DelegateCommand<object>(delegate
		{
			v2S();
		}, delegate
		{
			try
			{
				return Minimum < ldZ.mbe(ActiveViewMode, ActiveDate);
			}
			catch (ArgumentException)
			{
				return false;
			}
		});
		SelectDateCommand = new DelegateCommand<object>(delegate(object P_0)
		{
			if (P_0 is DateTime)
			{
				laC((DateTime)P_0, _0020: true);
			}
		}, (object param) => param is DateTime);
		int num = 0;
		if (sWo() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		paE = new DelegateCommand<object>(delegate(object P_0)
		{
			if (P_0 is DayOfWeek)
			{
				aa6((DayOfWeek)P_0);
			}
		}, delegate(object P_0)
		{
			MonthCalendarSelectionMode selectionMode = SelectionMode;
			MonthCalendarSelectionMode monthCalendarSelectionMode = selectionMode;
			return (uint)(monthCalendarSelectionMode - 1) <= 1u && P_0 is DayOfWeek && IsDayOfWeekSelectionEnabled;
		});
		la7 = new DelegateCommand<object>(delegate
		{
			SelectToday();
			OaQ();
		}, (object P_0) => u28(E2A()));
		ya4 = new DelegateCommand<object>(delegate(object P_0)
		{
			if (P_0 is int)
			{
				paM((int)P_0);
			}
		}, delegate(object P_0)
		{
			MonthCalendarSelectionMode selectionMode = SelectionMode;
			MonthCalendarSelectionMode monthCalendarSelectionMode = selectionMode;
			return (uint)(monthCalendarSelectionMode - 1) <= 2u && P_0 is int && IsWeekNumberSelectionEnabled;
		});
		ZoomInCommand = new DelegateCommand<object>(delegate(object P_0)
		{
			MonthCalendarViewMode? monthCalendarViewMode = Q23();
			if (monthCalendarViewMode.HasValue)
			{
				if (P_0 is DateTime)
				{
					Taj(monthCalendarViewMode.Value, (DateTime)P_0);
				}
				Sa2(monthCalendarViewMode.Value);
			}
		}, (object P_0) => Q23().HasValue);
		ZoomOutCommand = new DelegateCommand<object>(delegate
		{
			MonthCalendarViewMode? monthCalendarViewMode = l2y();
			if (monthCalendarViewMode.HasValue)
			{
				Sa2(monthCalendarViewMode.Value);
			}
		}, (object P_0) => l2y().HasValue);
	}

	private void Y2R()
	{
		if (ActiveViewMode != MonthCalendarViewMode.Month)
		{
			Sa2(MonthCalendarViewMode.Month);
		}
	}

	private void q2d(DateTime P_0)
	{
		if (!B21(P_0))
		{
			QaP(ActiveViewMode, P_0);
		}
		else
		{
			oas(ActiveViewMode, P_0);
		}
		h2H(P_0)?.Focus();
	}

	private void C29()
	{
		q2d(ActiveDate);
	}

	private static MonthCalendarItem p25()
	{
		return Ad6.cuR() as MonthCalendarItem;
	}

	private bool? n2c(DateTime P_0, DateTime P_1)
	{
		bool? result = null;
		switch (ActiveViewMode)
		{
		case MonthCalendarViewMode.Century:
		{
			int num = P_0.Year / 100 * 100;
			int num2 = P_1.Year / 100 * 100;
			if (num != num2)
			{
				result = num2 > num;
			}
			break;
		}
		case MonthCalendarViewMode.Decade:
		{
			int num3 = P_0.Year / 10 * 10;
			int num4 = P_1.Year / 10 * 10;
			if (num3 != num4)
			{
				result = num4 > num3;
			}
			break;
		}
		case MonthCalendarViewMode.Year:
			if (P_0.Year != P_1.Year)
			{
				result = P_1.Year > P_0.Year;
			}
			break;
		case MonthCalendarViewMode.Month:
			if (P_0.Year != P_1.Year)
			{
				result = P_1.Year > P_0.Year;
			}
			else if (P_0.Month != P_1.Month)
			{
				result = P_1.Month > P_0.Month;
			}
			break;
		}
		return result;
	}

	private MonthCalendarItem h2H(DateTime P_0)
	{
		if (Nan != null)
		{
			ItemsControl itemsControl = null;
			switch (ActiveViewMode)
			{
			case MonthCalendarViewMode.Century:
				itemsControl = Nan.Content as ItemsControl;
				P_0 = new DateTime(P_0.Year / 10 * 10, 1, 1);
				break;
			case MonthCalendarViewMode.Decade:
				itemsControl = Nan.Content as ItemsControl;
				P_0 = new DateTime(P_0.Year, 1, 1);
				break;
			case MonthCalendarViewMode.Year:
				itemsControl = Nan.Content as ItemsControl;
				P_0 = new DateTime(P_0.Year, P_0.Month, 1);
				break;
			case MonthCalendarViewMode.Month:
				if (Nan.Content is Grid grid)
				{
					itemsControl = grid.Children.OfType<UIElement>().LastOrDefault() as ItemsControl;
					P_0 = new DateTime(P_0.Year, P_0.Month, P_0.Day);
				}
				break;
			}
			if (itemsControl != null)
			{
				foreach (MonthCalendarItem item in (IEnumerable)itemsControl.Items)
				{
					if (item.Date == P_0)
					{
						return item;
					}
				}
			}
		}
		return null;
	}

	private int q2L()
	{
		if (Nan != null && Nan.Content is ItemsControl source && VisualTreeHelperExtended.GetFirstDescendant(source, typeof(UniformGrid)) is UniformGrid uniformGrid)
		{
			int num = 0;
			if (!nWw())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => Math.Max(1, uniformGrid.Columns), 
			};
		}
		return 1;
	}

	private DateTime? Y2F(DateTime? P_0, bool P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		DateTime value = P_0.Value;
		DateTime minimum = Minimum;
		DateTime maximum = Maximum;
		DaysOfWeek disabledDaysOfWeek = DisabledDaysOfWeek;
		if (disabledDaysOfWeek == DaysOfWeek.All)
		{
			return null;
		}
		if (E2r(value, minimum, maximum, disabledDaysOfWeek))
		{
			return value;
		}
		if (P_1)
		{
			value = value.AddDays(1.0);
			while (value <= maximum)
			{
				if (E2r(value, minimum, maximum, disabledDaysOfWeek))
				{
					return value;
				}
				value = value.AddDays(1.0);
			}
		}
		else
		{
			value = value.AddDays(-1.0);
			while (value >= minimum)
			{
				if (E2r(value, minimum, maximum, disabledDaysOfWeek))
				{
					return value;
				}
				value = value.AddDays(-1.0);
			}
		}
		return null;
	}

	private DateTime E2A()
	{
		DateTime? selectedDate = SelectedDate;
		DateTime result = DateTime.Today;
		if (CanRetainTime && selectedDate.HasValue)
		{
			result = new DateTime(result.Year, result.Month, result.Day, selectedDate.Value.Hour, selectedDate.Value.Minute, selectedDate.Value.Second, selectedDate.Value.Millisecond);
		}
		return result;
	}

	private MonthCalendarViewMode? Q23()
	{
		return ActiveViewMode switch
		{
			MonthCalendarViewMode.Century => MonthCalendarViewMode.Decade, 
			MonthCalendarViewMode.Decade => MonthCalendarViewMode.Year, 
			MonthCalendarViewMode.Year => MonthCalendarViewMode.Month, 
			_ => null, 
		};
	}

	private MonthCalendarViewMode? l2y()
	{
		if (ActiveViewMode >= MaxViewMode)
		{
			return null;
		}
		return ActiveViewMode switch
		{
			MonthCalendarViewMode.Month => MonthCalendarViewMode.Year, 
			MonthCalendarViewMode.Year => MonthCalendarViewMode.Decade, 
			MonthCalendarViewMode.Decade => MonthCalendarViewMode.Century, 
			_ => null, 
		};
	}

	private void v2m()
	{
		switch (ActiveViewMode)
		{
		case MonthCalendarViewMode.Month:
			QaP(ActiveViewMode, ActiveDate.AddMonths(1));
			break;
		case MonthCalendarViewMode.Decade:
			QaP(ActiveViewMode, ActiveDate.AddYears(10));
			break;
		case MonthCalendarViewMode.Year:
			QaP(ActiveViewMode, ActiveDate.AddYears(1));
			break;
		case MonthCalendarViewMode.Century:
			QaP(ActiveViewMode, ActiveDate.AddYears(100));
			break;
		}
	}

	private void v2S()
	{
		switch (ActiveViewMode)
		{
		case MonthCalendarViewMode.Century:
			QaP(ActiveViewMode, ActiveDate.AddYears(-100));
			break;
		case MonthCalendarViewMode.Decade:
			QaP(ActiveViewMode, ActiveDate.AddYears(-10));
			break;
		case MonthCalendarViewMode.Year:
			QaP(ActiveViewMode, ActiveDate.AddYears(-1));
			break;
		case MonthCalendarViewMode.Month:
			QaP(ActiveViewMode, ActiveDate.AddMonths(-1));
			break;
		}
	}

	private bool B21(DateTime P_0)
	{
		return ActiveViewMode switch
		{
			MonthCalendarViewMode.Century => ActiveDate.Year / 100 * 100 == P_0.Year / 100 * 100, 
			MonthCalendarViewMode.Decade => ActiveDate.Year / 10 * 10 == P_0.Year / 10 * 10, 
			MonthCalendarViewMode.Year => ActiveDate.Year == P_0.Year, 
			MonthCalendarViewMode.Month => ActiveDate.Year == P_0.Year && ActiveDate.Month == P_0.Month, 
			_ => false, 
		};
	}

	private bool u28(DateTime P_0)
	{
		return E2r(P_0, Minimum, Maximum, DisabledDaysOfWeek);
	}

	private bool E2r(DateTime P_0, DateTime P_1, DateTime P_2, DaysOfWeek P_3)
	{
		int result;
		if (ldZ.QDC(P_0, P_1, P_2) && !ldZ.zb8(P_3, P_0.DayOfWeek))
		{
			Func<DateTime, bool> isDateDisabledFunc = IsDateDisabledFunc;
			result = ((isDateDisabledFunc == null || !isDateDisabledFunc(P_0)) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private void x2v(bool P_0)
	{
		MonthCalendarItem monthCalendarItem = p25();
		if (monthCalendarItem != null && monthCalendarItem.Date.HasValue)
		{
			DateTime? dateTime = null;
			switch (ActiveViewMode)
			{
			case MonthCalendarViewMode.Century:
				dateTime = monthCalendarItem.Date.Value.AddYears(10 * q2L());
				break;
			case MonthCalendarViewMode.Decade:
				dateTime = monthCalendarItem.Date.Value.AddYears(q2L());
				break;
			case MonthCalendarViewMode.Year:
				dateTime = monthCalendarItem.Date.Value.AddMonths(q2L());
				break;
			case MonthCalendarViewMode.Month:
				dateTime = monthCalendarItem.Date.Value.AddDays(7.0);
				break;
			}
			dateTime = Y2F(dateTime, _0020: true);
			if (dateTime.HasValue)
			{
				q2d(dateTime.Value);
				if (P_0)
				{
					laC(dateTime.Value, _0020: false);
				}
				return;
			}
		}
		C29();
	}

	private void u2p(bool P_0)
	{
		MonthCalendarItem monthCalendarItem = p25();
		if (monthCalendarItem != null && monthCalendarItem.Date.HasValue)
		{
			DateTime? dateTime = monthCalendarItem.Date.Value;
			switch (ActiveViewMode)
			{
			case MonthCalendarViewMode.Century:
				dateTime = monthCalendarItem.Date.Value.AddYears(-10);
				break;
			case MonthCalendarViewMode.Decade:
				dateTime = monthCalendarItem.Date.Value.AddYears(-1);
				break;
			case MonthCalendarViewMode.Year:
				dateTime = monthCalendarItem.Date.Value.AddMonths(-1);
				break;
			case MonthCalendarViewMode.Month:
				dateTime = monthCalendarItem.Date.Value.AddDays(-1.0);
				break;
			}
			dateTime = Y2F(dateTime, _0020: false);
			if (dateTime.HasValue)
			{
				q2d(dateTime.Value);
				if (P_0)
				{
					laC(dateTime.Value, _0020: false);
				}
				return;
			}
		}
		C29();
	}

	private void v2W(bool P_0)
	{
		int num = 2;
		MonthCalendarItem monthCalendarItem = default(MonthCalendarItem);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					if (monthCalendarItem == null || !monthCalendarItem.Date.HasValue)
					{
						goto case 3;
					}
					dateTime = monthCalendarItem.Date.Value;
					switch (ActiveViewMode)
					{
					case MonthCalendarViewMode.Century:
						dateTime = monthCalendarItem.Date.Value.AddYears(10);
						break;
					case MonthCalendarViewMode.Year:
						dateTime = monthCalendarItem.Date.Value.AddMonths(1);
						break;
					case MonthCalendarViewMode.Decade:
						dateTime = monthCalendarItem.Date.Value.AddYears(1);
						break;
					default:
						goto IL_0185;
					case MonthCalendarViewMode.Month:
						dateTime = monthCalendarItem.Date.Value.AddDays(1.0);
						break;
					}
					goto default;
				case 3:
					C29();
					return;
				default:
					dateTime = Y2F(dateTime, _0020: true);
					if (dateTime.HasValue)
					{
						q2d(dateTime.Value);
						if (P_0)
						{
							laC(dateTime.Value, _0020: false);
						}
						return;
					}
					goto case 3;
				case 2:
					monthCalendarItem = p25();
					num2 = 1;
					if (sWo() != null)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0012;
				IL_0185:
				num2 = 0;
			}
			while (nWw());
		}
	}

	private void Q2i(bool P_0)
	{
		MonthCalendarItem monthCalendarItem = p25();
		if (monthCalendarItem != null && monthCalendarItem.Date.HasValue)
		{
			DateTime? dateTime = monthCalendarItem.Date.Value;
			MonthCalendarViewMode activeViewMode = ActiveViewMode;
			int num = 0;
			if (sWo() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				dateTime = monthCalendarItem.Date.Value.AddYears(-10 * q2L());
				break;
			case 2:
				goto IL_014a;
			default:
				{
					switch (activeViewMode)
					{
					case MonthCalendarViewMode.Century:
						break;
					default:
						goto end_IL_0009;
					case MonthCalendarViewMode.Decade:
						goto IL_014a;
					case MonthCalendarViewMode.Month:
						dateTime = monthCalendarItem.Date.Value.AddDays(-7.0);
						goto end_IL_0009;
					case MonthCalendarViewMode.Year:
						dateTime = monthCalendarItem.Date.Value.AddMonths(-q2L());
						goto end_IL_0009;
					}
					goto case 1;
				}
				IL_014a:
				dateTime = monthCalendarItem.Date.Value.AddYears(-q2L());
				break;
				end_IL_0009:
				break;
			}
			dateTime = Y2F(dateTime, _0020: false);
			if (dateTime.HasValue)
			{
				q2d(dateTime.Value);
				if (P_0)
				{
					laC(dateTime.Value, _0020: false);
				}
				return;
			}
		}
		C29();
	}

	private static void a2Z(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		if (monthCalendar.Tat)
		{
			return;
		}
		monthCalendar.Kag();
		int num = 0;
		if (!nWw())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		DateTime dateTime = (DateTime)P_1.OldValue;
		DateTime dateTime2 = (DateTime)P_1.NewValue;
		if (dateTime.Date != dateTime2.Date)
		{
			bool? flag = monthCalendar.n2c((DateTime)P_1.OldValue, (DateTime)P_1.NewValue);
			monthCalendar.Dal(monthCalendar.ActiveViewMode, monthCalendar.ActiveViewMode, flag, _0020: false);
		}
	}

	private static void Y2t(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		MonthCalendarViewMode monthCalendarViewMode = (MonthCalendarViewMode)P_1.OldValue;
		MonthCalendarViewMode monthCalendarViewMode2 = (MonthCalendarViewMode)P_1.NewValue;
		bool? flag = null;
		if (monthCalendarViewMode != monthCalendarViewMode2)
		{
			flag = monthCalendarViewMode2 < monthCalendarViewMode;
		}
		monthCalendar.Dal(monthCalendarViewMode, monthCalendarViewMode2, flag, _0020: false);
	}

	private static void B2n(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		monthCalendar.Vax();
		if (monthCalendar.ActiveViewMode == MonthCalendarViewMode.Month)
		{
			monthCalendar.Refresh(requiresNewView: true);
		}
	}

	private static void x2J(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		monthCalendar.Refresh(requiresNewView: false);
	}

	private static void C2e(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		monthCalendar.Vax();
		DateTime? selectedDate = monthCalendar.SelectedDate;
		if (selectedDate.HasValue)
		{
			DateTime dateTime = ldZ.BDP(selectedDate.Value, monthCalendar.Minimum, monthCalendar.Maximum);
			if (selectedDate.Value != dateTime)
			{
				monthCalendar.SelectedDate = dateTime;
				return;
			}
		}
		monthCalendar.Refresh(requiresNewView: false);
	}

	private static void s2k(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		if (monthCalendar.ActiveViewMode > monthCalendar.MaxViewMode)
		{
			monthCalendar.ActiveViewMode = monthCalendar.MaxViewMode;
		}
	}

	private static void u2E(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		monthCalendar.Vax();
		DateTime? selectedDate = monthCalendar.SelectedDate;
		if (selectedDate.HasValue)
		{
			DateTime dateTime = ldZ.BDP(selectedDate.Value, monthCalendar.Minimum, monthCalendar.Maximum);
			if (selectedDate.Value != dateTime)
			{
				monthCalendar.SelectedDate = dateTime;
				return;
			}
		}
		monthCalendar.Refresh(requiresNewView: false);
		int num = 0;
		if (!nWw())
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

	private void X27(object P_0, object P_1)
	{
		if (aaJ)
		{
			aaJ = false;
			MonthCalendarItem monthCalendarItem = h2H(ActiveDate);
			if (monthCalendarItem != null)
			{
				Nan.UpdateLayout();
				monthCalendarItem.Focus();
			}
		}
	}

	private static void o24(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		if (monthCalendar.ActiveViewMode == MonthCalendarViewMode.Month)
		{
			monthCalendar.Refresh(requiresNewView: true);
		}
	}

	private static void Q2B(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		if (monthCalendar.SelectionMode == MonthCalendarSelectionMode.Single && monthCalendar.SelectedDates.DayCount > 1 && monthCalendar.SelectedDate.HasValue)
		{
			monthCalendar.SelectedDates.SetToSingleDateRange(DateRange.FromDate(monthCalendar.SelectedDate.Value));
		}
		monthCalendar.Vax();
	}

	private static void j2h(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		DateTime? dateTime = (DateTime?)P_1.OldValue;
		DateTime? dateTime2 = (DateTime?)P_1.NewValue;
		if (monthCalendar.tak)
		{
			return;
		}
		try
		{
			monthCalendar.tak = true;
			monthCalendar.eaf(dateTime2);
			if (!dateTime.HasValue || (dateTime2.HasValue && dateTime.Value.Date != dateTime2.Value.Date))
			{
				bool? flag = monthCalendar.n2c(monthCalendar.ActiveDate, dateTime2.Value);
				monthCalendar.oas(monthCalendar.ActiveViewMode, dateTime2.Value);
				monthCalendar.Dal(monthCalendar.ActiveViewMode, monthCalendar.ActiveViewMode, flag, _0020: false);
			}
			else if (dateTime.HasValue && !dateTime2.HasValue)
			{
				monthCalendar.Refresh(requiresNewView: false);
			}
		}
		finally
		{
			monthCalendar.tak = false;
		}
		monthCalendar.b2z();
	}

	private void b2w(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (!tak)
		{
			try
			{
				tak = true;
				caa();
				Refresh(requiresNewView: false);
			}
			finally
			{
				tak = false;
			}
			b2z();
		}
	}

	private void c2N(object P_0, RoutedEventArgs P_1)
	{
		Y2R();
	}

	private static void W2U(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MonthCalendar monthCalendar = (MonthCalendar)P_0;
		monthCalendar.Vax();
	}

	[SpecialName]
	private TransitionPresenter Ia3()
	{
		return Nan;
	}

	[SpecialName]
	private void way(TransitionPresenter value)
	{
		if (Nan != null)
		{
			Nan.TransitionCompleted -= X27;
		}
		Nan = value;
		if (Nan != null)
		{
			Nan.TransitionCompleted += X27;
		}
	}

	private void b2z()
	{
		PaB?.Invoke(this, EventArgs.Empty);
	}

	private void OaQ()
	{
		jah?.Invoke(this, EventArgs.Empty);
	}

	private void waV()
	{
		if (!base.IsKeyboardFocusWithin && ViewResetMode != MonthCalendarViewResetMode.None)
		{
			DateTime activeDate = ViewResetMode switch
			{
				MonthCalendarViewResetMode.Active => ActiveDate, 
				MonthCalendarViewResetMode.FirstSelected => (Vae.Count <= 0) ? (SelectedDate ?? ActiveDate) : Vae[0].StartDate, 
				_ => DateTime.Today, 
			};
			Y2R();
			ActiveDate = activeDate;
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void laC(DateTime P_0, bool P_1)
	{
		_003C_003Ec__DisplayClass101_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass101_0();
		CS_0024_003C_003E8__locals8.duB = this;
		MonthCalendarSelectionMode selectionMode = SelectionMode;
		if (selectionMode != MonthCalendarSelectionMode.Single || !u28(P_0) || !ldZ.CDV(P_0, ActiveDate))
		{
			P_1 = false;
		}
		bool flag = p25()?.Date.HasValue ?? false;
		ModifierKeys modifierKeys = Ad6.suc();
		bool flag2 = (modifierKeys & ModifierKeys.Control) == ModifierKeys.Control;
		bool flag3 = (modifierKeys & ModifierKeys.Shift) == ModifierKeys.Shift;
		if (CanRetainTime)
		{
			DateTime? selectedDate = SelectedDate;
			P_0 = ((!selectedDate.HasValue) ? P_0.Date : new DateTime(P_0.Year, P_0.Month, P_0.Day, selectedDate.Value.Hour, selectedDate.Value.Minute, selectedDate.Value.Second, selectedDate.Value.Millisecond));
		}
		else
		{
			P_0 = P_0.Date;
		}
		P_0 = ldZ.BDP(P_0, Minimum, Maximum);
		int num = MaxSelectionCount;
		if (num < 0)
		{
			num = int.MaxValue;
		}
		CS_0024_003C_003E8__locals8.Nuh = Minimum;
		CS_0024_003C_003E8__locals8.Guw = Maximum;
		CS_0024_003C_003E8__locals8.SuN = DisabledDaysOfWeek;
		Predicate<DateTime> predicate = (DateTime d) => CS_0024_003C_003E8__locals8.duB.E2r(d.Date, CS_0024_003C_003E8__locals8.Nuh, CS_0024_003C_003E8__locals8.Guw, CS_0024_003C_003E8__locals8.SuN);
		if (selectionMode == MonthCalendarSelectionMode.Multiple || (flag2 && selectionMode == MonthCalendarSelectionMode.Extended))
		{
			if (Vae.Contains(P_0))
			{
				Vae.Remove(DateRange.FromDate(P_0));
				KaZ = P_0;
			}
			else
			{
				int num2 = Math.Max(0, num - Vae.DayCount);
				if (num2 > 0 && predicate(P_0))
				{
					Vae.Add(DateRange.FromDate(P_0));
					KaZ = P_0;
				}
			}
		}
		else if (flag3 && (selectionMode == MonthCalendarSelectionMode.Extended || selectionMode == MonthCalendarSelectionMode.Range))
		{
			if (KaZ.HasValue)
			{
				int num3 = num;
				if (num3 > 0)
				{
					List<DateRange> list = new List<DateRange>();
					DateRange dateRange = DateRange.FromRange(KaZ.Value, P_0);
					DateTime? dateTime = null;
					DateTime? dateTime2 = null;
					foreach (DateTime item in dateRange)
					{
						if (num3 == 0)
						{
							break;
						}
						if (!predicate(item))
						{
							if (dateTime.HasValue)
							{
								list.Add(DateRange.FromRange(dateTime.Value, dateTime2.Value));
								dateTime = null;
								dateTime2 = null;
							}
						}
						else
						{
							num3--;
							if (!dateTime.HasValue)
							{
								dateTime = item;
							}
							dateTime2 = item;
						}
					}
					if (dateTime.HasValue)
					{
						list.Add(DateRange.FromRange(dateTime.Value, dateTime2.Value));
					}
					if (list.Count > 0)
					{
						if (list.Count == 1)
						{
							Vae.SetToSingleDateRange(list[0]);
						}
						else
						{
							Vae.SetToMultipleDateRanges(list);
						}
					}
				}
			}
			else if (num >= 0 && predicate(P_0))
			{
				SelectedDate = P_0;
				KaZ = P_0;
			}
		}
		else if (num >= 0 && predicate(P_0))
		{
			SelectedDate = P_0;
			KaZ = P_0;
		}
		if (flag)
		{
			C29();
		}
		if (P_1)
		{
			OaQ();
		}
	}

	private void aa6(DayOfWeek P_0)
	{
		_003C_003Ec__DisplayClass102_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass102_0();
		CS_0024_003C_003E8__locals8.Vuz = this;
		if (ActiveViewMode != MonthCalendarViewMode.Month)
		{
			return;
		}
		int num = MaxSelectionCount;
		if (num < 0)
		{
			num = int.MaxValue;
		}
		CS_0024_003C_003E8__locals8.AKQ = Minimum;
		CS_0024_003C_003E8__locals8.MKV = Maximum;
		CS_0024_003C_003E8__locals8.eKC = DisabledDaysOfWeek;
		Predicate<DateTime> predicate = (DateTime d) => CS_0024_003C_003E8__locals8.Vuz.E2r(d.Date, CS_0024_003C_003E8__locals8.AKQ, CS_0024_003C_003E8__locals8.MKV, CS_0024_003C_003E8__locals8.eKC);
		IEnumerable<DateTime> enumerable = ldZ.RbW(ActiveDate, P_0);
		List<DateRange> list = new List<DateRange>();
		foreach (DateTime item in enumerable)
		{
			if (!predicate(item) || num-- == 0)
			{
				break;
			}
			list.Add(DateRange.FromDate(item));
		}
		if (list.Count > 0)
		{
			if (list.Count == 1)
			{
				Vae.SetToSingleDateRange(list[0]);
			}
			else
			{
				Vae.SetToMultipleDateRanges(list);
			}
		}
	}

	private void paM(int P_0)
	{
		_003C_003Ec__DisplayClass103_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass103_0();
		CS_0024_003C_003E8__locals8.KKM = this;
		if (ActiveViewMode != MonthCalendarViewMode.Month)
		{
			return;
		}
		int num = MaxSelectionCount;
		if (num < 0)
		{
			num = int.MaxValue;
		}
		CS_0024_003C_003E8__locals8.cKs = Minimum;
		CS_0024_003C_003E8__locals8.tKj = Maximum;
		CS_0024_003C_003E8__locals8.HKP = DisabledDaysOfWeek;
		Predicate<DateTime> predicate = (DateTime d) => CS_0024_003C_003E8__locals8.KKM.E2r(d.Date, CS_0024_003C_003E8__locals8.cKs, CS_0024_003C_003E8__locals8.tKj, CS_0024_003C_003E8__locals8.HKP);
		IEnumerable<DateTime> enumerable = ldZ.dbE(ActiveDate, P_0, ldZ.Abv(CalendarWeekRule), ldZ.Pbn(FirstDayOfWeek));
		List<DateRange> list = new List<DateRange>();
		DateTime? dateTime = null;
		DateTime? dateTime2 = null;
		foreach (DateTime item in enumerable)
		{
			if (num == 0)
			{
				break;
			}
			if (!predicate(item))
			{
				if (dateTime.HasValue)
				{
					list.Add(DateRange.FromRange(dateTime.Value, dateTime2.Value));
					dateTime = null;
					dateTime2 = null;
				}
			}
			else
			{
				num--;
				if (!dateTime.HasValue)
				{
					dateTime = item;
				}
				dateTime2 = item;
			}
		}
		if (dateTime.HasValue)
		{
			list.Add(DateRange.FromRange(dateTime.Value, dateTime2.Value));
		}
		if (list.Count > 0)
		{
			if (list.Count == 1)
			{
				Vae.SetToSingleDateRange(list[0]);
			}
			else
			{
				Vae.SetToMultipleDateRanges(list);
			}
		}
	}

	private void oas(MonthCalendarViewMode P_0, DateTime P_1)
	{
		try
		{
			Tat = true;
			QaP(P_0, P_1);
		}
		finally
		{
			Tat = false;
		}
	}

	private void Taj(MonthCalendarViewMode P_0, DateTime P_1)
	{
		int year = ActiveDate.Year;
		int month = ActiveDate.Month;
		int day = ActiveDate.Day;
		switch (P_0)
		{
		case MonthCalendarViewMode.Decade:
			year = P_1.Year + ActiveDate.Year % 10;
			break;
		case MonthCalendarViewMode.Month:
			month = P_1.Month;
			break;
		case MonthCalendarViewMode.Year:
			year = P_1.Year;
			break;
		}
		oas(P_0, new DateTime(year, month, Math.Min(DateTime.DaysInMonth(year, month), day)));
	}

	private void QaP(MonthCalendarViewMode P_0, DateTime P_1)
	{
		P_1 = ldZ.BDP(P_1.Date, ldZ.mbe(P_0, Minimum), ldZ.QbJ(P_0, Maximum));
		ActiveDate = P_1;
	}

	private void Sa2(MonthCalendarViewMode P_0)
	{
		if (P_0 > MaxViewMode)
		{
			P_0 = MaxViewMode;
		}
		ActiveViewMode = P_0;
	}

	private void caa()
	{
		if (Vae.Count > 0)
		{
			SelectedDate = Vae[0].StartDate;
		}
		else
		{
			SelectedDate = null;
		}
	}

	private void eaf(DateTime? P_0)
	{
		if (P_0.HasValue)
		{
			KaZ = P_0.Value;
			Vae.SetToSingleDateRange(DateRange.FromDate(P_0.Value));
		}
		else
		{
			Vae.Clear();
		}
	}

	private void Dal(MonthCalendarViewMode? P_0, MonthCalendarViewMode P_1, bool? P_2, bool P_3)
	{
		Kag();
		if (Nan == null)
		{
			return;
		}
		if (P_2.HasValue)
		{
			if (P_0.HasValue && P_0 != P_1)
			{
				Nan.Transition = new FadedZoomTransition
				{
					Mode = ((!P_2.Value) ? TransitionMode.Out : TransitionMode.In)
				};
			}
			else
			{
				Nan.Transition = new SlideTransition
				{
					IsFromContentPushed = true,
					Mode = ((!P_2.Value) ? TransitionMode.Out : TransitionMode.In)
				};
			}
		}
		else
		{
			Nan.Transition = null;
		}
		switch (P_1)
		{
		case MonthCalendarViewMode.Month:
			QaY(P_3 || P_2.HasValue);
			break;
		case MonthCalendarViewMode.Year:
			eao(P_3 || P_2.HasValue);
			break;
		case MonthCalendarViewMode.Decade:
			Ba0(P_3 || P_2.HasValue);
			break;
		case MonthCalendarViewMode.Century:
			FaX(P_3 || P_2.HasValue);
			break;
		}
		LaO();
		laT();
	}

	private void FaX(bool P_0)
	{
		int num = ActiveDate.Year / 100 * 100;
		if (!P_0)
		{
			P_0 = true;
			if (Nan.Content is Border { Child: ItemsControl child } && child.Items.Count == 10)
			{
				for (int i = 0; i < 10; i++)
				{
					DateTime date = new DateTime(num + i * 10, 1, 1);
					if (child.Items[i] is MonthCalendarItem item)
					{
						UpdateDecadeItem(item, date);
					}
				}
				P_0 = false;
			}
		}
		if (P_0)
		{
			if (Ad6.Pu9(Nan))
			{
				aaJ = true;
				Focus();
			}
			Border border2 = new Border
			{
				Background = base.Background
			};
			ItemsControl itemsControl = (ItemsControl)(border2.Child = new ItemsControl
			{
				Background = base.Background,
				IsTabStop = false,
				ItemsPanel = DecadeItemsPanelTemplate,
				MinWidth = ((Nan != null) ? Nan.ActualWidth : 0.0),
				MinHeight = ((Nan != null) ? Nan.ActualHeight : 0.0)
			});
			ICommand zoomInCommand = ZoomInCommand;
			DataTemplate decadeItemTemplate = DecadeItemTemplate;
			for (int j = 0; j < 10; j++)
			{
				DateTime date2 = new DateTime(num + j * 10, 1, 1);
				MonthCalendarItem monthCalendarItem = new MonthCalendarItem();
				monthCalendarItem.Command = zoomInCommand;
				monthCalendarItem.ContentTemplate = decadeItemTemplate;
				itemsControl.Items.Add(monthCalendarItem);
				UpdateDecadeItem(monthCalendarItem, date2);
			}
			Nan.Content = border2;
		}
	}

	private void Vax()
	{
		paE.RaiseCanExecuteChanged();
		la7.RaiseCanExecuteChanged();
		ya4.RaiseCanExecuteChanged();
	}

	private void Ba0(bool P_0)
	{
		int num = ActiveDate.Year / 10 * 10;
		Border border = default(Border);
		int num2;
		if (!P_0)
		{
			P_0 = true;
			border = Nan.Content as Border;
			if (border != null)
			{
				num2 = 4;
				if (!nWw())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		goto IL_005d;
		IL_005d:
		if (!P_0)
		{
			return;
		}
		if (Ad6.Pu9(Nan))
		{
			aaJ = true;
			Focus();
		}
		Border border2 = new Border
		{
			Background = base.Background
		};
		ItemsControl itemsControl = (ItemsControl)(border2.Child = new ItemsControl
		{
			Background = base.Background,
			IsTabStop = false,
			ItemsPanel = YearItemsPanelTemplate,
			MinWidth = ((Nan != null) ? Nan.ActualWidth : 0.0),
			MinHeight = ((Nan != null) ? Nan.ActualHeight : 0.0)
		});
		ICommand zoomInCommand = ZoomInCommand;
		DataTemplate yearItemTemplate = YearItemTemplate;
		int num3 = 0;
		goto IL_01cc;
		IL_01cc:
		if (num3 >= 10)
		{
			Nan.Content = border2;
			return;
		}
		DateTime date = new DateTime(num + num3, 1, 1);
		num2 = 3;
		if (!nWw())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num4 = default(int);
		num2 = num4;
		goto IL_0009;
		IL_0009:
		MonthCalendarItem monthCalendarItem = default(MonthCalendarItem);
		DateTime date2 = default(DateTime);
		int num5 = default(int);
		bool flag = default(bool);
		ItemsControl itemsControl2 = default(ItemsControl);
		while (true)
		{
			switch (num2)
			{
			default:
				if (monthCalendarItem != null)
				{
					UpdateYearItem(monthCalendarItem, date2);
				}
				num5++;
				goto IL_01b3;
			case 1:
				if (!flag)
				{
					goto IL_005d;
				}
				num5 = 0;
				goto IL_01b3;
			case 3:
				break;
			case 4:
				goto IL_0238;
			case 2:
				{
					date2 = new DateTime(num + num5, 1, 1);
					monthCalendarItem = itemsControl2.Items[num5] as MonthCalendarItem;
					num2 = 0;
					if (nWw())
					{
						num2 = 0;
					}
					continue;
				}
				IL_01b3:
				if (num5 >= 10)
				{
					P_0 = false;
					goto IL_005d;
				}
				goto case 2;
			}
			break;
			IL_0238:
			itemsControl2 = border.Child as ItemsControl;
			flag = itemsControl2 != null && itemsControl2.Items.Count == 10;
			num2 = 1;
			if (nWw())
			{
				continue;
			}
			goto IL_0005;
		}
		MonthCalendarItem monthCalendarItem2 = new MonthCalendarItem();
		monthCalendarItem2.Command = zoomInCommand;
		monthCalendarItem2.ContentTemplate = yearItemTemplate;
		itemsControl.Items.Add(monthCalendarItem2);
		UpdateYearItem(monthCalendarItem2, date);
		num3++;
		goto IL_01cc;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void QaY(bool P_0)
	{
		DateTime dateTime = ldZ.obt(ActiveDate);
		DayOfWeek dayOfWeek = ldZ.Pbn(FirstDayOfWeek);
		CalendarWeekRule calendarWeekRule = ldZ.Abv(CalendarWeekRule);
		DateTime dateTime2 = dateTime;
		try
		{
			dateTime2 = dateTime.AddDays(-ldZ.wbi(dateTime2, dayOfWeek));
		}
		catch (ArgumentOutOfRangeException)
		{
			dateTime2 = DateTime.MinValue;
		}
		if (!P_0)
		{
			P_0 = true;
			if (Nan.Content is Grid grid && grid.Children.Count == 3)
			{
				if (grid.Children[1] is ItemsControl itemsControl && itemsControl.Items.Count == 6)
				{
					for (int i = 0; i < 6; i++)
					{
						DateTime dateTime3 = ((i == 0) ? dateTime : dateTime2.AddDays(i * 7));
						int weekNumber = ldZ.lb7(dateTime3, calendarWeekRule, dayOfWeek);
						if (itemsControl.Items[i] is MonthCalendarItem item)
						{
							UpdateWeekNumberItem(item, weekNumber);
						}
					}
				}
				if (grid.Children[2] is ItemsControl itemsControl2 && itemsControl2.Items.Count == 42)
				{
					DateTime date = dateTime2;
					for (int j = 0; j < 42; j++)
					{
						if (itemsControl2.Items[j] is MonthCalendarItem item2)
						{
							UpdateDayItem(item2, date);
						}
						date = date.AddDays(1.0);
					}
					P_0 = false;
				}
			}
		}
		if (!P_0)
		{
			return;
		}
		if (Ad6.Pu9(Nan))
		{
			aaJ = true;
			Focus();
		}
		Grid grid2 = new Grid
		{
			Background = base.Background,
			MinWidth = ((Nan != null) ? Nan.ActualWidth : 0.0),
			MinHeight = ((Nan != null) ? Nan.ActualHeight : 0.0)
		};
		grid2.RowDefinitions.Add(new RowDefinition
		{
			Height = GridLength.Auto
		});
		grid2.RowDefinitions.Add(new RowDefinition());
		grid2.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = GridLength.Auto
		});
		grid2.ColumnDefinitions.Add(new ColumnDefinition());
		ItemsControl itemsControl3 = new ItemsControl
		{
			IsTabStop = false,
			ItemContainerStyle = DayNameItemContainerStyle,
			ItemsPanel = DayNameItemsPanelTemplate
		};
		Grid.SetColumn(itemsControl3, 1);
		grid2.Children.Add(itemsControl3);
		DataTemplate dayNameItemTemplate = DayNameItemTemplate;
		for (DayOfWeek dayOfWeek2 = dayOfWeek; dayOfWeek2 <= DayOfWeek.Saturday; dayOfWeek2++)
		{
			MonthCalendarItem monthCalendarItem = new MonthCalendarItem();
			itemsControl3.Items.Add(monthCalendarItem);
			monthCalendarItem.Command = paE;
			monthCalendarItem.ContentTemplate = dayNameItemTemplate;
			monthCalendarItem.IsHeader = true;
			monthCalendarItem.IsTabStop = false;
			UpdateDayNameItem(monthCalendarItem, dayOfWeek2);
		}
		for (DayOfWeek dayOfWeek3 = DayOfWeek.Sunday; dayOfWeek3 < dayOfWeek; dayOfWeek3++)
		{
			MonthCalendarItem monthCalendarItem2 = new MonthCalendarItem();
			itemsControl3.Items.Add(monthCalendarItem2);
			monthCalendarItem2.Command = paE;
			monthCalendarItem2.ContentTemplate = dayNameItemTemplate;
			monthCalendarItem2.IsHeader = true;
			monthCalendarItem2.IsTabStop = false;
			UpdateDayNameItem(monthCalendarItem2, dayOfWeek3);
		}
		if (IsWeekNumberColumnVisible)
		{
			itemsControl3 = new ItemsControl
			{
				IsTabStop = false,
				ItemContainerStyle = WeekNumberItemContainerStyle,
				ItemsPanel = WeekNumberItemsPanelTemplate
			};
			Grid.SetRow(itemsControl3, 1);
			grid2.Children.Add(itemsControl3);
			DataTemplate weekNumberItemTemplate = WeekNumberItemTemplate;
			for (int k = 0; k < 6; k++)
			{
				DateTime dateTime4 = ((k == 0) ? dateTime : dateTime2.AddDays(k * 7));
				int weekNumber2 = ldZ.lb7(dateTime4, calendarWeekRule, dayOfWeek);
				MonthCalendarItem monthCalendarItem3 = new MonthCalendarItem();
				itemsControl3.Items.Add(monthCalendarItem3);
				monthCalendarItem3.Command = ya4;
				monthCalendarItem3.ContentTemplate = weekNumberItemTemplate;
				monthCalendarItem3.IsHeader = true;
				monthCalendarItem3.IsTabStop = false;
				UpdateWeekNumberItem(monthCalendarItem3, weekNumber2);
			}
		}
		itemsControl3 = new ItemsControl
		{
			IsTabStop = false,
			ItemsPanel = DayItemsPanelTemplate
		};
		Grid.SetRow(itemsControl3, 1);
		Grid.SetColumn(itemsControl3, 1);
		grid2.Children.Add(itemsControl3);
		DateTime dateTime5 = dateTime2;
		ICommand selectDateCommand = SelectDateCommand;
		DataTemplate dayItemTemplate = DayItemTemplate;
		DataTemplateSelector dayItemTemplateSelector = DayItemTemplateSelector;
		for (int l = 0; l < 42; l++)
		{
			MonthCalendarItem monthCalendarItem4 = new MonthCalendarItem();
			itemsControl3.Items.Add(monthCalendarItem4);
			monthCalendarItem4.Command = selectDateCommand;
			if (dayItemTemplateSelector != null)
			{
				monthCalendarItem4.ContentTemplate = dayItemTemplateSelector.SelectTemplate(dateTime5, monthCalendarItem4) ?? dayItemTemplate;
			}
			else
			{
				monthCalendarItem4.ContentTemplate = dayItemTemplate;
			}
			UpdateDayItem(monthCalendarItem4, dateTime5);
			dateTime5 = dateTime5.AddDays(1.0);
		}
		Nan.Content = grid2;
	}

	private void Kag()
	{
		string text = SR.GetString(SRName.UICalendarTodayButtonText, DateTime.Today);
		if (TodayButtonText != text)
		{
			TodayButtonText = text;
		}
	}

	private void eao(bool P_0)
	{
		if (!P_0)
		{
			P_0 = true;
			if (Nan.Content is Border { Child: ItemsControl child } && child.Items.Count == 12)
			{
				DateTime date = new DateTime(ActiveDate.Year, 1, 1);
				for (int i = 0; i < 12; i++)
				{
					if (child.Items[i] is MonthCalendarItem item)
					{
						UpdateMonthItem(item, date);
					}
					date = date.AddMonths(1);
				}
				P_0 = false;
			}
		}
		if (P_0)
		{
			if (Ad6.Pu9(Nan))
			{
				aaJ = true;
				Focus();
			}
			Border border2 = new Border
			{
				Background = base.Background
			};
			ItemsControl itemsControl = (ItemsControl)(border2.Child = new ItemsControl
			{
				IsTabStop = false,
				ItemsPanel = MonthItemsPanelTemplate,
				MinWidth = ((Nan != null) ? Nan.ActualWidth : 0.0),
				MinHeight = ((Nan != null) ? Nan.ActualHeight : 0.0)
			});
			DateTime date2 = new DateTime(ActiveDate.Year, 1, 1);
			ICommand zoomInCommand = ZoomInCommand;
			DataTemplate monthItemTemplate = MonthItemTemplate;
			for (int j = 0; j < 12; j++)
			{
				MonthCalendarItem monthCalendarItem = new MonthCalendarItem();
				itemsControl.Items.Add(monthCalendarItem);
				monthCalendarItem.Command = zoomInCommand;
				monthCalendarItem.ContentTemplate = monthItemTemplate;
				UpdateMonthItem(monthCalendarItem, date2);
				date2 = date2.AddMonths(1);
			}
			Nan.Content = border2;
		}
	}

	private void LaO()
	{
		int num = 1;
		int num2 = num;
		MonthCalendarViewMode activeViewMode = default(MonthCalendarViewMode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				activeViewMode = ActiveViewMode;
				num2 = 0;
				if (!nWw())
				{
					num2 = 0;
				}
				continue;
			}
			switch (activeViewMode)
			{
			case MonthCalendarViewMode.Decade:
				Title = ldZ.qbZ(ActiveDate, _0020: false);
				break;
			case MonthCalendarViewMode.Century:
				Title = ldZ.Pbp(ActiveDate);
				break;
			case MonthCalendarViewMode.Year:
				Title = ActiveDate.ToString(QdM.AR8(20244), CultureInfo.CurrentCulture);
				break;
			case MonthCalendarViewMode.Month:
			{
				string text = null;
				if (CultureInfo.CurrentCulture.DateTimeFormat != null)
				{
					text = CultureInfo.CurrentCulture.DateTimeFormat.YearMonthPattern;
				}
				Title = ActiveDate.ToString(text ?? QdM.AR8(20222), CultureInfo.CurrentCulture);
				break;
			}
			}
			return;
		}
	}

	private void laT()
	{
		((DelegateCommand<object>)GoToNextViewCommand).RaiseCanExecuteChanged();
		((DelegateCommand<object>)GoToPreviousViewCommand).RaiseCanExecuteChanged();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		way(GetTemplateChild(QdM.AR8(20256)) as TransitionPresenter);
		Dal(null, ActiveViewMode, null, _0020: true);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new MonthCalendarAutomationPeer(this);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(QdM.AR8(20288));
		}
		base.OnKeyDown(e);
		if (e.Handled)
		{
			return;
		}
		ModifierKeys modifierKeys = Ad6.suc();
		bool flag = (modifierKeys & ModifierKeys.Control) == ModifierKeys.Control;
		bool flag2 = (modifierKeys & ModifierKeys.Shift) == ModifierKeys.Shift;
		MonthCalendarSelectionMode selectionMode = SelectionMode;
		MonthCalendarSelectionMode monthCalendarSelectionMode = selectionMode;
		if ((uint)monthCalendarSelectionMode <= 1u)
		{
			flag2 = false;
		}
		switch (e.Key)
		{
		case Key.Down:
			x2v(flag2);
			e.Handled = true;
			break;
		case Key.Return:
			if (SelectedDate.HasValue && modifierKeys == ModifierKeys.None)
			{
				OaQ();
			}
			break;
		case Key.Left:
			u2p(flag2);
			e.Handled = true;
			break;
		case Key.Next:
			v2m();
			e.Handled = true;
			break;
		case Key.Prior:
			v2S();
			e.Handled = true;
			break;
		case Key.Right:
			v2W(flag2);
			e.Handled = true;
			break;
		case Key.Up:
			Q2i(flag2);
			e.Handled = true;
			break;
		case Key.Add:
		case Key.OemPlus:
			if (flag)
			{
				ZoomInCommand.Execute(null);
				e.Handled = true;
			}
			break;
		case Key.Subtract:
		case Key.OemMinus:
			if (flag)
			{
				ZoomOutCommand.Execute(null);
				e.Handled = true;
			}
			break;
		}
	}

	public void Refresh(bool requiresNewView)
	{
		Dal(null, ActiveViewMode, null, requiresNewView);
	}

	public void SelectToday()
	{
		Y2R();
		DateTime dateTime = E2A();
		if (u28(dateTime))
		{
			SelectedDate = dateTime;
		}
		if (ActiveDate.Year != dateTime.Year || ActiveDate.Month != dateTime.Month)
		{
			ActiveDate = dateTime;
		}
	}

	protected virtual void UpdateDayNameItem(MonthCalendarItem item, DayOfWeek dayOfWeek)
	{
		if (item == null)
		{
			throw new ArgumentNullException(QdM.AR8(20294));
		}
		item.CommandParameter = dayOfWeek;
		item.Content = dayOfWeek.ToString(DayOfWeekFormatPattern, CultureInfo.CurrentCulture);
		item.DataContext = dayOfWeek;
	}

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Date")]
	protected virtual void UpdateDayItem(MonthCalendarItem item, DateTime date)
	{
		if (item == null)
		{
			throw new ArgumentNullException(QdM.AR8(20294));
		}
		if (ldZ.TDM(date))
		{
			item.CommandParameter = date;
			item.ContainsToday = date.Date == DateTime.Today && IsTodayHighlighted;
			item.DataContext = date;
			item.IsEnabled = u28(date);
			item.IsInactive = !ldZ.CDV(date, ActiveDate);
			int num = 0;
			if (!nWw())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			item.IsSelected = Vae.Contains(date.Date);
		}
		else
		{
			item.DataContext = null;
			item.IsEnabled = false;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Date")]
	protected virtual void UpdateDecadeItem(MonthCalendarItem item, DateTime date)
	{
		if (item == null)
		{
			throw new ArgumentNullException(QdM.AR8(20294));
		}
		if (ldZ.TDM(date))
		{
			item.CommandParameter = date;
			item.ContainsToday = ldZ.xDQ(DateTime.Today, date) && IsTodayHighlighted;
			item.DataContext = date;
			item.IsEnabled = ldZ.yD6(MonthCalendarViewMode.Decade, date, Minimum, Maximum);
			item.IsSelected = Vae.OverlapsWith(DateRange.FromDecade(date));
		}
		else
		{
			item.DataContext = null;
			item.IsEnabled = false;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Date")]
	protected virtual void UpdateMonthItem(MonthCalendarItem item, DateTime date)
	{
		if (item == null)
		{
			throw new ArgumentNullException(QdM.AR8(20294));
		}
		if (ldZ.TDM(date))
		{
			item.CommandParameter = date;
			item.ContainsToday = date.Year == DateTime.Today.Year && date.Month == DateTime.Today.Month && IsTodayHighlighted;
			int num = 0;
			if (!nWw())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			item.DataContext = date;
			item.IsEnabled = ldZ.yD6(MonthCalendarViewMode.Month, date, Minimum, Maximum);
			item.IsSelected = Vae.OverlapsWith(DateRange.FromMonth(date));
		}
		else
		{
			item.DataContext = null;
			item.IsEnabled = false;
		}
	}

	protected virtual void UpdateWeekNumberItem(MonthCalendarItem item, int weekNumber)
	{
		if (item == null)
		{
			throw new ArgumentNullException(QdM.AR8(20294));
		}
		item.CommandParameter = weekNumber;
		item.Content = weekNumber;
	}

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Date")]
	protected virtual void UpdateYearItem(MonthCalendarItem item, DateTime date)
	{
		if (item == null)
		{
			throw new ArgumentNullException(QdM.AR8(20294));
		}
		if (ldZ.TDM(date))
		{
			item.CommandParameter = date;
			item.ContainsToday = date.Year == DateTime.Today.Year && IsTodayHighlighted;
			item.DataContext = date;
			item.IsEnabled = ldZ.yD6(MonthCalendarViewMode.Year, date, Minimum, Maximum);
			item.IsInactive = !ldZ.xDQ(date, ActiveDate);
			int num = 0;
			if (!nWw())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			item.IsSelected = Vae.OverlapsWith(DateRange.FromYear(date));
		}
		else
		{
			item.DataContext = null;
			item.IsEnabled = false;
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		waV();
	}

	static MonthCalendar()
	{
		awj.QuEwGz();
		ActiveDateProperty = DependencyProperty.Register(QdM.AR8(20306), typeof(DateTime), typeof(MonthCalendar), new PropertyMetadata(DateTime.Today, a2Z));
		ActiveViewModeProperty = DependencyProperty.Register(QdM.AR8(20330), typeof(MonthCalendarViewMode), typeof(MonthCalendar), new PropertyMetadata(MonthCalendarViewMode.Month, Y2t));
		CalendarWeekRuleProperty = DependencyProperty.Register(QdM.AR8(20362), typeof(CalendarWeekRule?), typeof(MonthCalendar), new PropertyMetadata(null, o24));
		CanRetainTimeProperty = DependencyProperty.Register(QdM.AR8(18702), typeof(bool), typeof(MonthCalendar), new PropertyMetadata(false));
		ClearButtonStyleProperty = DependencyProperty.Register(QdM.AR8(20398), typeof(Style), typeof(MonthCalendar), new PropertyMetadata(null));
		ClearButtonTextProperty = DependencyProperty.Register(QdM.AR8(20434), typeof(string), typeof(MonthCalendar), new PropertyMetadata(SR.GetString(SRName.UICalendarClearButtonText)));
		DayItemsPanelTemplateProperty = DependencyProperty.Register(QdM.AR8(20468), typeof(ItemsPanelTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		DayItemTemplateProperty = DependencyProperty.Register(QdM.AR8(20514), typeof(DataTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		DayItemTemplateSelectorProperty = DependencyProperty.Register(QdM.AR8(20548), typeof(DataTemplateSelector), typeof(MonthCalendar), new PropertyMetadata(null));
		DayNameItemsPanelTemplateProperty = DependencyProperty.Register(QdM.AR8(20598), typeof(ItemsPanelTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		DayNameItemContainerStyleProperty = DependencyProperty.Register(QdM.AR8(20652), typeof(Style), typeof(MonthCalendar), new PropertyMetadata(null));
		DayNameItemTemplateProperty = DependencyProperty.Register(QdM.AR8(20706), typeof(DataTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		DayOfWeekFormatPatternProperty = DependencyProperty.Register(QdM.AR8(20748), typeof(DayOfWeekFormatPattern), typeof(MonthCalendar), new PropertyMetadata(DayOfWeekFormatPattern.AbbreviatedUppercase, o24));
		DecadeItemsPanelTemplateProperty = DependencyProperty.Register(QdM.AR8(20796), typeof(ItemsPanelTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		DecadeItemTemplateProperty = DependencyProperty.Register(QdM.AR8(20848), typeof(DataTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		DisabledDaysOfWeekProperty = DependencyProperty.Register(QdM.AR8(20888), typeof(DaysOfWeek), typeof(MonthCalendar), new PropertyMetadata(DaysOfWeek.None, B2n));
		FirstDayOfWeekProperty = DependencyProperty.Register(QdM.AR8(20928), typeof(DayOfWeek?), typeof(MonthCalendar), new PropertyMetadata(null, o24));
		IsClearButtonVisibleProperty = DependencyProperty.Register(QdM.AR8(374), typeof(bool), typeof(MonthCalendar), new FrameworkPropertyMetadata(false));
		IsDateDisabledFuncProperty = DependencyProperty.Register(QdM.AR8(20960), typeof(Func<DateTime, bool>), typeof(MonthCalendar), new FrameworkPropertyMetadata(null, o24));
		IsDayOfWeekSelectionEnabledProperty = DependencyProperty.Register(QdM.AR8(21000), typeof(bool), typeof(MonthCalendar), new FrameworkPropertyMetadata(true, W2U));
		IsTodayButtonVisibleProperty = DependencyProperty.Register(QdM.AR8(21058), typeof(bool), typeof(MonthCalendar), new PropertyMetadata(true));
		IsTodayHighlightedProperty = DependencyProperty.Register(QdM.AR8(21102), typeof(bool), typeof(MonthCalendar), new FrameworkPropertyMetadata(true, x2J));
		IsWeekNumberColumnVisibleProperty = DependencyProperty.Register(QdM.AR8(21142), typeof(bool), typeof(MonthCalendar), new FrameworkPropertyMetadata(false, o24));
		IsWeekNumberSelectionEnabledProperty = DependencyProperty.Register(QdM.AR8(21196), typeof(bool), typeof(MonthCalendar), new FrameworkPropertyMetadata(true, W2U));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(DateTime), typeof(MonthCalendar), new PropertyMetadata(ldZ.YD2, C2e));
		MaxSelectionCountProperty = DependencyProperty.Register(QdM.AR8(21256), typeof(int), typeof(MonthCalendar), new PropertyMetadata(-1));
		MaxViewModeProperty = DependencyProperty.Register(QdM.AR8(21294), typeof(MonthCalendarViewMode), typeof(MonthCalendar), new PropertyMetadata(MonthCalendarViewMode.Century, s2k));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(DateTime), typeof(MonthCalendar), new PropertyMetadata(ldZ.ADa, u2E));
		MonthItemsPanelTemplateProperty = DependencyProperty.Register(QdM.AR8(21320), typeof(ItemsPanelTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		MonthItemTemplateProperty = DependencyProperty.Register(QdM.AR8(21370), typeof(DataTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		NavigationButtonStyleProperty = DependencyProperty.Register(QdM.AR8(21408), typeof(Style), typeof(MonthCalendar), new PropertyMetadata(null));
		SelectedDateProperty = DependencyProperty.Register(QdM.AR8(21454), typeof(DateTime?), typeof(MonthCalendar), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, j2h));
		SelectionModeProperty = DependencyProperty.Register(QdM.AR8(21482), typeof(MonthCalendarSelectionMode), typeof(MonthCalendar), new PropertyMetadata(MonthCalendarSelectionMode.Single, Q2B));
		TitleProperty = DependencyProperty.Register(QdM.AR8(21512), typeof(string), typeof(MonthCalendar), new PropertyMetadata(null));
		TitleButtonStyleProperty = DependencyProperty.Register(QdM.AR8(21526), typeof(Style), typeof(MonthCalendar), new PropertyMetadata(null));
		TodayButtonStyleProperty = DependencyProperty.Register(QdM.AR8(21562), typeof(Style), typeof(MonthCalendar), new PropertyMetadata(null));
		TodayButtonTextProperty = DependencyProperty.Register(QdM.AR8(21598), typeof(string), typeof(MonthCalendar), new PropertyMetadata(SR.GetString(SRName.UICalendarTodayButtonText, DateTime.Today)));
		ViewResetModeProperty = DependencyProperty.Register(QdM.AR8(21632), typeof(MonthCalendarViewResetMode), typeof(MonthCalendar), new PropertyMetadata(MonthCalendarViewResetMode.None));
		WeekNumberItemsPanelTemplateProperty = DependencyProperty.Register(QdM.AR8(21662), typeof(ItemsPanelTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		WeekNumberItemContainerStyleProperty = DependencyProperty.Register(QdM.AR8(21722), typeof(Style), typeof(MonthCalendar), new PropertyMetadata(null));
		WeekNumberItemTemplateProperty = DependencyProperty.Register(QdM.AR8(21782), typeof(DataTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		YearItemsPanelTemplateProperty = DependencyProperty.Register(QdM.AR8(21830), typeof(ItemsPanelTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
		YearItemTemplateProperty = DependencyProperty.Register(QdM.AR8(21878), typeof(DataTemplate), typeof(MonthCalendar), new PropertyMetadata(null));
	}

	[CompilerGenerated]
	private void laI(object P_0)
	{
		SelectedDate = null;
		OaQ();
	}

	[CompilerGenerated]
	private void Aab(object P_0)
	{
		v2m();
	}

	[CompilerGenerated]
	private bool zaD(object P_0)
	{
		try
		{
			return Maximum > ldZ.QbJ(ActiveViewMode, ActiveDate);
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private void laG(object P_0)
	{
		v2S();
	}

	[CompilerGenerated]
	private bool Baq(object P_0)
	{
		try
		{
			return Minimum < ldZ.mbe(ActiveViewMode, ActiveDate);
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private void sau(object P_0)
	{
		if (P_0 is DateTime)
		{
			laC((DateTime)P_0, _0020: true);
		}
	}

	[CompilerGenerated]
	private void jaK(object P_0)
	{
		if (P_0 is DayOfWeek)
		{
			aa6((DayOfWeek)P_0);
		}
	}

	[CompilerGenerated]
	private bool uaR(object P_0)
	{
		MonthCalendarSelectionMode selectionMode = SelectionMode;
		MonthCalendarSelectionMode monthCalendarSelectionMode = selectionMode;
		if ((uint)(monthCalendarSelectionMode - 1) <= 1u)
		{
			return P_0 is DayOfWeek && IsDayOfWeekSelectionEnabled;
		}
		return false;
	}

	[CompilerGenerated]
	private void Fad(object P_0)
	{
		SelectToday();
		OaQ();
	}

	[CompilerGenerated]
	private bool Fa9(object P_0)
	{
		return u28(E2A());
	}

	[CompilerGenerated]
	private void Ma5(object P_0)
	{
		if (P_0 is int)
		{
			paM((int)P_0);
		}
	}

	[CompilerGenerated]
	private bool nac(object P_0)
	{
		MonthCalendarSelectionMode selectionMode = SelectionMode;
		MonthCalendarSelectionMode monthCalendarSelectionMode = selectionMode;
		if ((uint)(monthCalendarSelectionMode - 1) <= 2u)
		{
			return P_0 is int && IsWeekNumberSelectionEnabled;
		}
		return false;
	}

	[CompilerGenerated]
	private void QaH(object P_0)
	{
		MonthCalendarViewMode? monthCalendarViewMode = Q23();
		if (monthCalendarViewMode.HasValue)
		{
			if (P_0 is DateTime)
			{
				Taj(monthCalendarViewMode.Value, (DateTime)P_0);
			}
			Sa2(monthCalendarViewMode.Value);
		}
	}

	[CompilerGenerated]
	private bool daL(object P_0)
	{
		return Q23().HasValue;
	}

	[CompilerGenerated]
	private void taF(object P_0)
	{
		MonthCalendarViewMode? monthCalendarViewMode = l2y();
		if (monthCalendarViewMode.HasValue)
		{
			Sa2(monthCalendarViewMode.Value);
		}
	}

	[CompilerGenerated]
	private bool TaA(object P_0)
	{
		return l2y().HasValue;
	}

	internal static bool nWw()
	{
		return cW7 == null;
	}

	internal static MonthCalendar sWo()
	{
		return cW7;
	}
}
