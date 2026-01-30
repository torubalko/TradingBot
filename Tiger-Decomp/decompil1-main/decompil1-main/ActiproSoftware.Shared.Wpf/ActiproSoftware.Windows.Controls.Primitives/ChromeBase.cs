using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public abstract class ChromeBase : Decorator
{
	public static readonly DependencyProperty IsAnimationEnabledProperty;

	private static ChromeBase q0W;

	public bool IsAnimationEnabled
	{
		get
		{
			return (bool)GetValue(IsAnimationEnabledProperty);
		}
		set
		{
			SetValue(IsAnimationEnabledProperty, value);
		}
	}

	protected bool IsAnimationEnabledResolved => IsAnimationEnabled && base.IsEnabled && SystemParameters.PowerLineStatus == PowerLineStatus.Online && SystemParameters.ClientAreaAnimation && RenderCapability.Tier > 0;

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ChromeBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IsAnimationEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97656), typeof(bool), typeof(ChromeBase), new FrameworkPropertyMetadata(false));
		UIElement.IsEnabledProperty.OverrideMetadata(typeof(ChromeBase), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
	}

	protected ChromeBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool O0z()
	{
		return q0W == null;
	}

	internal static ChromeBase DbK()
	{
		return q0W;
	}
}
