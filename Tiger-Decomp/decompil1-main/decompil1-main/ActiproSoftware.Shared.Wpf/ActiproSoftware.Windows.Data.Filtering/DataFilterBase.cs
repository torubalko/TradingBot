using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

public abstract class DataFilterBase : DependencyObject, IDataFilter
{
	public static readonly DependencyProperty IncludedFilterResultProperty;

	public static readonly DependencyProperty IsEnabledProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler ilc;

	private static DataFilterBase COL;

	protected virtual DataFilterResult FallbackFilterResult => DataFilterResult.IncludedByDescendants;

	public DataFilterResult IncludedFilterResult
	{
		get
		{
			return (DataFilterResult)GetValue(IncludedFilterResultProperty);
		}
		set
		{
			SetValue(IncludedFilterResultProperty, value);
		}
	}

	public bool IsEnabled
	{
		get
		{
			return (bool)GetValue(IsEnabledProperty);
		}
		set
		{
			SetValue(IsEnabledProperty, value);
		}
	}

	public event EventHandler FilterChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = ilc;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ilc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = ilc;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ilc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal static void OnFilterRelatedPropertyValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
	{
		DataFilterBase dataFilterBase = (DataFilterBase)sender;
		bool flag = e.Property == IsEnabledProperty;
		dataFilterBase.Ukz(flag);
	}

	private void Ukz(bool P_0)
	{
		if (P_0 || IsEnabled)
		{
			ilc?.Invoke(this, EventArgs.Empty);
		}
	}

	public abstract DataFilterResult Filter(object item, object context);

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaiseFilterChangedEvent()
	{
		Ukz(_0020: false);
	}

	protected DataFilterBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static DataFilterBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IncludedFilterResultProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112802), typeof(DataFilterResult), typeof(DataFilterBase), new PropertyMetadata(DataFilterResult.Included, OnFilterRelatedPropertyValueChanged));
		IsEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112846), typeof(bool), typeof(DataFilterBase), new PropertyMetadata(true, OnFilterRelatedPropertyValueChanged));
	}

	internal static bool RO4()
	{
		return COL == null;
	}

	internal static DataFilterBase YOs()
	{
		return COL;
	}
}
