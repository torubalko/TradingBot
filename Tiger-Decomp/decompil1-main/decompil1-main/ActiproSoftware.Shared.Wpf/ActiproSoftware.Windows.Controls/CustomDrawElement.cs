using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class CustomDrawElement : FrameworkElement
{
	public static readonly RoutedEvent CustomDrawEvent;

	internal static CustomDrawElement Oq4;

	[Description("Occurs when the element requests to be custom drawn.")]
	public event EventHandler<CustomDrawElementCustomDrawEventArgs> CustomDraw
	{
		add
		{
			AddHandler(CustomDrawEvent, value);
		}
		remove
		{
			RemoveHandler(CustomDrawEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static CustomDrawElement()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CustomDrawEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114050), RoutingStrategy.Bubble, typeof(EventHandler<CustomDrawElementCustomDrawEventArgs>), typeof(CustomDrawElement));
		KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(CustomDrawElement), new FrameworkPropertyMetadata(false));
		UIElement.FocusableProperty.OverrideMetadata(typeof(CustomDrawElement), new FrameworkPropertyMetadata(false));
		UIElement.SnapsToDevicePixelsProperty.OverrideMetadata(typeof(CustomDrawElement), new FrameworkPropertyMetadata(true));
	}

	protected override Geometry GetLayoutClip(Size layoutSlotSize)
	{
		return null;
	}

	protected virtual void OnCustomDraw(DrawingContext drawingContext)
	{
		RaiseEvent(new CustomDrawElementCustomDrawEventArgs(CustomDrawEvent, this, drawingContext));
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		base.OnRender(drawingContext);
		OnCustomDraw(drawingContext);
	}

	public CustomDrawElement()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool yqs()
	{
		return Oq4 == null;
	}

	internal static CustomDrawElement Eqi()
	{
		return Oq4;
	}
}
