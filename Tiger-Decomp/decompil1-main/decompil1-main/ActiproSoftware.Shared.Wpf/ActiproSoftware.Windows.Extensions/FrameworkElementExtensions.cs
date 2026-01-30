using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Animation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Extensions;

public static class FrameworkElementExtensions
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public FrameworkElement nHm;

		public DependencyProperty FHw;

		public double? EH4;

		public double HHu;

		public Storyboard eH2;

		internal static _003C_003Ec__DisplayClass0_0 FeF;

		public _003C_003Ec__DisplayClass0_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal void lHh(object sender, EventArgs e)
		{
			nHm.SetValue(FHw, EH4 ?? HHu);
			eH2.Remove(nHm);
		}

		internal static bool Ned()
		{
			return FeF == null;
		}

		internal static _003C_003Ec__DisplayClass0_0 Qev()
		{
			return FeF;
		}
	}

	internal static FrameworkElementExtensions Y3r;

	internal static void AnimateDoubleProperty(this FrameworkElement element, DependencyProperty property, double targetValue, double duration = 0.2, double startTime = 0.0, double? finalValue = null)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals26.nHm = element;
		CS_0024_003C_003E8__locals26.FHw = property;
		CS_0024_003C_003E8__locals26.EH4 = finalValue;
		CS_0024_003C_003E8__locals26.HHu = targetValue;
		if (CS_0024_003C_003E8__locals26.nHm == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		if (CS_0024_003C_003E8__locals26.FHw == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111080));
		}
		CS_0024_003C_003E8__locals26.eH2 = new Storyboard();
		CS_0024_003C_003E8__locals26.eH2.BeginTime = TimeSpan.FromSeconds(startTime);
		CS_0024_003C_003E8__locals26.eH2.FillBehavior = FillBehavior.Stop;
		Storyboard.SetTarget(CS_0024_003C_003E8__locals26.eH2, CS_0024_003C_003E8__locals26.nHm);
		Storyboard.SetTargetProperty(CS_0024_003C_003E8__locals26.eH2, new PropertyPath(CS_0024_003C_003E8__locals26.FHw.Name));
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
		{
			KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
			{
				EasingFunction = new QuadraticEase(),
				KeyTime = TimeSpan.FromSeconds(duration),
				Value = CS_0024_003C_003E8__locals26.HHu
			} }
		};
		CS_0024_003C_003E8__locals26.eH2.Children.Add(doubleAnimationUsingKeyFrames);
		if (CS_0024_003C_003E8__locals26.EH4.HasValue)
		{
			doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
			{
				KeyTime = TimeSpan.FromSeconds(duration),
				Value = CS_0024_003C_003E8__locals26.EH4.Value
			});
		}
		CS_0024_003C_003E8__locals26.eH2.Completed += delegate
		{
			CS_0024_003C_003E8__locals26.nHm.SetValue(CS_0024_003C_003E8__locals26.FHw, CS_0024_003C_003E8__locals26.EH4 ?? CS_0024_003C_003E8__locals26.HHu);
			CS_0024_003C_003E8__locals26.eH2.Remove(CS_0024_003C_003E8__locals26.nHm);
		};
		CS_0024_003C_003E8__locals26.eH2.Begin(CS_0024_003C_003E8__locals26.nHm, isControllable: true);
	}

	[SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void AnimateDoubleProperty(this FrameworkElement element, string propertyPath, double targetValue, double duration = 0.2, double startTime = 0.0, double? finalValue = null, double? initialValue = null)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		if (propertyPath == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111100));
		}
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = TimeSpan.FromSeconds(startTime);
		Storyboard.SetTarget(storyboard, element);
		Storyboard.SetTargetProperty(storyboard, new PropertyPath(propertyPath));
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
		if (initialValue.HasValue)
		{
			doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
			{
				KeyTime = TimeSpan.FromSeconds(0.0),
				Value = initialValue.Value
			});
		}
		doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
		{
			EasingFunction = new QuadraticEase(),
			KeyTime = TimeSpan.FromSeconds(duration),
			Value = targetValue
		});
		storyboard.Children.Add(doubleAnimationUsingKeyFrames);
		if (finalValue.HasValue)
		{
			doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
			{
				KeyTime = TimeSpan.FromSeconds(duration),
				Value = finalValue.Value
			});
		}
		storyboard.Begin();
	}

	[SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
	public static void BindToProperty(this FrameworkElement element, DependencyProperty targetProperty, object source, string sourcePropertyName, BindingMode mode, IValueConverter converter = null, object converterParameter = null)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		Binding binding = new Binding(sourcePropertyName);
		binding.Source = source;
		binding.Mode = mode;
		binding.Converter = converter;
		binding.ConverterParameter = converterParameter;
		element.SetBinding(targetProperty, binding);
	}

	public static Size GetCurrentSize(this FrameworkElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return new Size((element.ActualWidth > 0.0) ? element.ActualWidth : (double.IsNaN(element.Width) ? 0.0 : element.Width), (element.ActualHeight > 0.0) ? element.ActualHeight : (double.IsNaN(element.Height) ? 0.0 : element.Height));
	}

	internal static bool T3I()
	{
		return Y3r == null;
	}

	internal static FrameworkElementExtensions Q3D()
	{
		return Y3r;
	}
}
