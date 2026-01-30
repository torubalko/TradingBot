using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;
using ActiproSoftware.Windows.Themes.Generation;
using dg3ypDAonQcOidMs0w;
using Microsoft.Win32;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public static class ThemeManager
{
	private class qB : ThemedResourceDictionary
	{
		internal static qB q8O;

		public qB()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
			base.Source = ResourceHelper.GetLocationUri(Assembly.GetExecutingAssembly(), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136306));
		}

		internal static bool C8q()
		{
			return q8O == null;
		}

		internal static qB A8G()
		{
			return q8O;
		}
	}

	private class Jc : ThemedResourceDictionary
	{
		internal static Jc t8n;

		public Jc()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
			base.Source = ResourceHelper.GetLocationUri(Assembly.GetExecutingAssembly(), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136424));
			try
			{
				fqg();
			}
			catch
			{
			}
		}

		private void fqg()
		{
			Assembly assembly = typeof(TextBox).Assembly;
			if (!(assembly != null))
			{
				return;
			}
			Type type = assembly.GetType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136526), throwOnError: false);
			if (type != null && base[typeof(ContextMenu)] is Style basedOn)
			{
				Add(type, new Style(type, basedOn));
			}
			Type type2 = assembly.GetType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136658), throwOnError: false);
			int num = 0;
			if (!x80())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (type2 != null && base[typeof(MenuItem)] is Style basedOn2)
			{
				Add(type2, new Style(type2, basedOn2));
			}
		}

		internal static bool x80()
		{
			return t8n == null;
		}

		internal static Jc L8b()
		{
			return t8n;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public ThemeCatalogBase PWT;

		internal static _003C_003Ec__DisplayClass28_0 r8j;

		public _003C_003Ec__DisplayClass28_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal bool qWX(ThemeCatalogBase c)
		{
			return c == PWT;
		}

		internal static bool d8e()
		{
			return r8j == null;
		}

		internal static _003C_003Ec__DisplayClass28_0 O86()
		{
			return r8j;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_1
	{
		public Type cWp;

		internal static _003C_003Ec__DisplayClass28_1 d8w;

		public _003C_003Ec__DisplayClass28_1()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal bool LWB(ThemeCatalogBase c)
		{
			return c.GetType() == cWp;
		}

		internal static bool P8k()
		{
			return d8w == null;
		}

		internal static _003C_003Ec__DisplayClass28_1 p8F()
		{
			return d8w;
		}
	}

	private static bool T4K;

	private static string J4g;

	private static bool W48;

	private static bool F4D;

	private static object f4P;

	private static int B4G;

	private static object I41;

	private static Dictionary<string, string> w4z;

	private static List<ThemeCatalogBase> Suc;

	private static Dictionary<object, ThemeCatalogBase> buj;

	public static readonly DependencyProperty AreNativeThemesEnabledProperty;

	public static readonly DependencyProperty DesignModeAreNativeThemesEnabledProperty;

	public static readonly DependencyProperty DesignModeThemeProperty;

	public static readonly DependencyProperty ThemeProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static EventHandler luv;

	private static Dictionary<string, ThemeDefinition> uuX;

	private static WeakReference EuT;

	private static bool SuB;

	private static SystemApplicationMode? pup;

	private static Color Aub;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static EventHandler uuy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string juf;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static string vui;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string yuS;

	private static ThemeManager QYG;

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public static bool AreNativeThemesEnabled
	{
		get
		{
			return T4K;
		}
		set
		{
			if (T4K != value)
			{
				T4K = value;
				ApplyTheme();
			}
		}
	}

	public static string CurrentTheme
	{
		get
		{
			return J4g;
		}
		set
		{
			string text = value?.Trim();
			if (text != null && w4z.TryGetValue(text, out var value2))
			{
				text = value2;
			}
			if (!(J4g == text))
			{
				J4g = text;
				r4Z();
				ApplyTheme();
			}
		}
	}

	public static IEnumerable<ThemeCatalogBase> RegisteredCatalogs
	{
		get
		{
			lock (f4P)
			{
				return Suc.AsReadOnly();
			}
		}
	}

	public static IEnumerable<ThemeDefinition> RegisteredThemeDefinitions
	{
		get
		{
			lock (f4P)
			{
				return uuX.Values;
			}
		}
	}

	internal static string AutomaticDarkTheme
	{
		[CompilerGenerated]
		get
		{
			return juf;
		}
		[CompilerGenerated]
		private set
		{
			juf = value;
		}
	}

	internal static string AutomaticHighContrastTheme
	{
		[CompilerGenerated]
		get
		{
			return vui;
		}
		[CompilerGenerated]
		private set
		{
			vui = value;
		}
	}

	internal static string AutomaticLightTheme
	{
		[CompilerGenerated]
		get
		{
			return yuS;
		}
		[CompilerGenerated]
		private set
		{
			yuS = value;
		}
	}

	public static bool HasAutomaticThemes => !string.IsNullOrEmpty(AutomaticLightTheme) || !string.IsNullOrEmpty(AutomaticDarkTheme) || !string.IsNullOrEmpty(AutomaticHighContrastTheme);

	public static bool IsAnimationSupported => SystemParameters.ClientAreaAnimation && IsGraphicsHardwareAccelerationSupported;

	public static bool IsGraphicsHardwareAccelerationSupported => RenderCapability.Tier > 0;

	public static SystemApplicationMode SystemApplicationMode
	{
		get
		{
			if (!pup.HasValue)
			{
				e45();
			}
			return pup.Value;
		}
	}

	[Description("Occurs after the CurrentTheme property has changed.")]
	public static event EventHandler CurrentThemeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = luv;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref luv, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = luv;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref luv, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public static event EventHandler SystemApplicationModeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = uuy;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uuy, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = uuy;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uuy, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ThemeManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		f4P = new object();
		I41 = new object();
		w4z = new Dictionary<string, string>
		{
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94920),
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94954)
			},
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94988),
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95020)
			},
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95052),
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95088)
			}
		};
		Suc = new List<ThemeCatalogBase>();
		buj = new Dictionary<object, ThemeCatalogBase>();
		AreNativeThemesEnabledProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95124), typeof(bool), typeof(ThemeManager), new FrameworkPropertyMetadata(false, o4I));
		DesignModeAreNativeThemesEnabledProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95172), typeof(bool), typeof(ThemeManager), new FrameworkPropertyMetadata(false, w4x));
		DesignModeThemeProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95240), typeof(string), typeof(ThemeManager), new FrameworkPropertyMetadata(null, q4r));
		ThemeProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95274), typeof(string), typeof(ThemeManager), new FrameworkPropertyMetadata(null, t4n));
		Aub = SystemColors.ActiveBorderColor;
		e45();
		R4Y(_0020: true);
		J4s();
	}

	public static void ApplyThemeAndRaiseChangedEvent()
	{
		ApplyTheme();
		r4Z();
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static void X4C(ResourceDictionary P_0, bool P_1, string P_2, bool P_3)
	{
		lock (f4P)
		{
			if (!W48)
			{
				return;
			}
			F4D = true;
			int num = -1;
			int num2 = P_0.MergedDictionaries.Count - 1;
			ThemedResourceDictionary themedResourceDictionary = default(ThemedResourceDictionary);
			string text = default(string);
			int num4 = default(int);
			while (true)
			{
				int num3;
				if (num2 < 0)
				{
					themedResourceDictionary = new ThemedResourceDictionary();
					text = P_2 ?? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94896);
					ThemeDefinition themeDefinition = GetThemeDefinition(text);
					if (themeDefinition != null)
					{
						ResourceDictionary resourceDictionary = p4q(themeDefinition);
						if (resourceDictionary != null)
						{
							themedResourceDictionary.MergedDictionaries.Add(resourceDictionary);
						}
						if (themeDefinition.ArrowKind != ArrowKind.FilledTriangle)
						{
							num3 = 2;
							if (mY0() != null)
							{
								goto IL_002a;
							}
							goto IL_002e;
						}
						themedResourceDictionary.MergedDictionaries.Add(new qB());
					}
					goto IL_041c;
				}
				ResourceDictionary resourceDictionary2 = P_0.MergedDictionaries[num2];
				if (resourceDictionary2 is ThemedResourceDictionary)
				{
					if (num != -1)
					{
						num--;
						P_0.MergedDictionaries.RemoveAt(num2);
						num3 = 4;
						if (mY0() != null)
						{
							goto IL_002a;
						}
						goto IL_002e;
					}
					num = num2;
				}
				goto IL_00c4;
				IL_002e:
				switch (num3)
				{
				case 4:
					goto IL_00c4;
				case 3:
					goto IL_0135;
				case 1:
					goto IL_03cb;
				case 2:
					goto IL_041c;
				}
				continue;
				IL_002a:
				num3 = num4;
				goto IL_002e;
				IL_041c:
				foreach (ThemeCatalogBase item in Suc.OrderBy((ThemeCatalogBase c) => c.Priority + ((!(c is SystemThemeCatalog)) ? 100000 : 0)))
				{
					IEnumerable<ThemedResourceDictionaryReference> dictionaryReferencesForTheme = item.GetDictionaryReferencesForTheme(text);
					if (dictionaryReferencesForTheme != null)
					{
						themedResourceDictionary.MergedDictionaries.AddRange(dictionaryReferencesForTheme.Select((ThemedResourceDictionaryReference d) => d.GetResourceDictionary()));
					}
				}
				if (P_3)
				{
					themedResourceDictionary.MergedDictionaries.Add(new Jc());
					num3 = 1;
					if (!gYn())
					{
						goto IL_002a;
					}
					goto IL_002e;
				}
				goto IL_03cb;
				IL_0135:
				if (themedResourceDictionary.MergedDictionaries.Count != 0)
				{
					P_0.MergedDictionaries.Insert(0, themedResourceDictionary);
				}
				return;
				IL_00c4:
				num2--;
				num3 = 0;
				if (!gYn())
				{
					goto IL_002a;
				}
				goto IL_002e;
				IL_03cb:
				if (num >= 0 && num < P_0.MergedDictionaries.Count)
				{
					break;
				}
				goto IL_0135;
			}
			if (themedResourceDictionary.MergedDictionaries.Count == 0)
			{
				P_0.MergedDictionaries.RemoveAt(num);
			}
			else
			{
				P_0.MergedDictionaries[num] = themedResourceDictionary;
			}
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "count")]
	private static void R4Y(bool P_0)
	{
		if (W48)
		{
			return;
		}
		Application current = Application.Current;
		bool flag = current != null;
		int num = 0;
		if (!gYn())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			int count = current.Resources.Count;
			current.TryFindResource(new ComponentResourceKey(typeof(ThemeManager), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95288)));
			W48 = true;
		}
		else if (!P_0)
		{
			W48 = true;
		}
		else
		{
			Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
			{
				R4Y(_0020: false);
			});
		}
	}

	private static void o4I(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is FrameworkElement frameworkElement)
		{
			X4C(frameworkElement.Resources, _0020: true, GetTheme(frameworkElement), (bool)P_1.NewValue);
		}
	}

	private static void w4x(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is FrameworkElement frameworkElement && DesignerProperties.GetIsInDesignMode(frameworkElement))
		{
			X4C(frameworkElement.Resources, _0020: false, GetDesignModeTheme(frameworkElement), (bool)P_1.NewValue);
		}
	}

	private static void q4r(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is FrameworkElement frameworkElement && DesignerProperties.GetIsInDesignMode(frameworkElement))
		{
			X4C(frameworkElement.Resources, _0020: false, P_1.NewValue as string, GetDesignModeAreNativeThemesEnabled(frameworkElement));
		}
	}

	private static void r4Z()
	{
		luv?.Invoke(null, EventArgs.Empty);
	}

	private static void t4n(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is FrameworkElement frameworkElement)
		{
			X4C(frameworkElement.Resources, _0020: false, P_1.NewValue as string, GetAreNativeThemesEnabled(frameworkElement));
		}
	}

	private static void z4a(object P_0, ThemeCatalogBase P_1)
	{
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals11.PWT = P_1;
		lock (f4P)
		{
			_003C_003Ec__DisplayClass28_1 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass28_1();
			CS_0024_003C_003E8__locals10.cWp = CS_0024_003C_003E8__locals11.PWT.GetType();
			if (CS_0024_003C_003E8__locals11.PWT is SystemThemeCatalog)
			{
				if (Suc.Any((ThemeCatalogBase c) => c.GetType() == CS_0024_003C_003E8__locals10.cWp))
				{
					return;
				}
				Suc.Add(CS_0024_003C_003E8__locals11.PWT);
				if (CS_0024_003C_003E8__locals11.PWT.DictionaryReferences?.Any() ?? (!F4D))
				{
					Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
					{
						ApplyTheme();
					});
				}
				return;
			}
			if (P_0 != null && buj.TryGetValue(P_0, out var value) && value != null)
			{
				Suc.Remove(value);
				buj.Remove(P_0);
			}
			if (!Suc.Any((ThemeCatalogBase c) => c == CS_0024_003C_003E8__locals11.PWT))
			{
				Suc.Add(CS_0024_003C_003E8__locals11.PWT);
				if (P_0 != null)
				{
					buj[P_0] = CS_0024_003C_003E8__locals11.PWT;
				}
				ApplyTheme();
			}
		}
	}

	public static void ApplyTheme()
	{
		if (Application.Current != null && B4G == 0)
		{
			X4C(Application.Current.Resources, _0020: true, J4g, T4K);
		}
	}

	public static void ApplyTheme(FrameworkElement element)
	{
		if (element != null)
		{
			X4C(element.Resources, _0020: false, GetTheme(element), GetAreNativeThemesEnabled(element));
		}
	}

	public static bool GetAreNativeThemesEnabled(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(AreNativeThemesEnabledProperty);
	}

	public static void SetAreNativeThemesEnabled(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(AreNativeThemesEnabledProperty, value);
	}

	public static void BeginUpdate()
	{
		lock (I41)
		{
			B4G = Math.Min(2147483646, B4G + 1);
		}
	}

	public static bool GetDesignModeAreNativeThemesEnabled(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(DesignModeAreNativeThemesEnabledProperty);
	}

	public static void SetDesignModeAreNativeThemesEnabled(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(DesignModeAreNativeThemesEnabledProperty, value);
	}

	public static string GetDesignModeTheme(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (string)obj.GetValue(DesignModeThemeProperty);
	}

	public static void SetDesignModeTheme(DependencyObject obj, string value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(DesignModeThemeProperty, value);
	}

	public static void EndUpdate()
	{
		bool flag = false;
		if (B4G > 0)
		{
			lock (I41)
			{
				if (B4G > 0)
				{
					B4G = Math.Max(0, B4G - 1);
					if (B4G == 0)
					{
						flag = true;
					}
				}
			}
		}
		bool flag2 = flag;
		int num = 0;
		if (mY0() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag2)
		{
			ApplyTheme();
		}
	}

	public static void RegisterThemeCatalog(ThemeCatalogBase catalog)
	{
		if (catalog == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95332));
		}
		z4a(null, catalog);
	}

	public static void RegisterThemeCatalog(object key, ThemeCatalogBase catalog)
	{
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95350));
		}
		if (catalog == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95332));
		}
		if (catalog is SystemThemeCatalog)
		{
			throw new InvalidOperationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95360));
		}
		z4a(key, catalog);
	}

	public static string GetTheme(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (string)obj.GetValue(ThemeProperty);
	}

	public static void SetTheme(DependencyObject obj, string value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(ThemeProperty, value);
	}

	public static void UnregisterThemeCatalog(ThemeCatalogBase catalog)
	{
		if (catalog == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95332));
		}
		lock (f4P)
		{
			if (Suc.Remove(catalog))
			{
				ApplyTheme();
			}
		}
	}

	public static void UnregisterThemeCatalog(object key)
	{
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95350));
		}
		lock (f4P)
		{
			if (buj.TryGetValue(key, out var value) && value != null)
			{
				Suc.Remove(value);
				buj.Remove(key);
				ApplyTheme();
			}
		}
	}

	private static ResourceDictionary p4q(ThemeDefinition P_0)
	{
		ResourceDictionary result = null;
		if (P_0 != null)
		{
			ThemeGenerator themeGenerator = new ThemeGenerator();
			result = themeGenerator.Generate(P_0);
		}
		return result;
	}

	private static ColorFamilyName P4W(string P_0)
	{
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95462), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Teal;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95474), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Green;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95488), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Indigo;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95504), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Orange;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95520), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Pink;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95532), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Purple;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95548), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Red;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95558), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Indigo;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95572), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Teal;
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95584), StringComparison.InvariantCulture))
		{
			return ColorFamilyName.Yellow;
		}
		return ColorFamilyName.Blue;
	}

	public static ThemeDefinition CreateDefaultThemeDefinition(string themeName)
	{
		ThemeDefinition themeDefinition = null;
		if (themeName != null)
		{
			if (themeName.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95462), StringComparison.InvariantCulture))
			{
				themeName = themeName.Substring(0, themeName.Length - 4) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95572);
			}
			else if (themeName.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95558), StringComparison.InvariantCulture))
			{
				themeName = themeName.Substring(0, themeName.Length - 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95488);
			}
		}
		string text = themeName;
		string text2 = text;
		ColorFamilyName colorFamilyName;
		ColorFamilyName colorFamilyName2;
		ThemeIntent intent;
		string text3;
		string text4;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text2))
		{
		case 4089584005u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95600)))
			{
				break;
			}
			goto IL_06ac;
		case 3646684246u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95624)))
			{
				break;
			}
			goto IL_06ac;
		case 1899748558u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94896)))
			{
				break;
			}
			goto IL_06ac;
		case 2024507879u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95646)))
			{
				break;
			}
			goto IL_06ac;
		case 4262062000u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95670)))
			{
				break;
			}
			return new OfficeBlackThemeDefinition(themeName);
		case 1086387963u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95696)))
			{
				break;
			}
			goto IL_0731;
		case 1687749510u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95736)))
			{
				break;
			}
			goto IL_0731;
		case 2402257249u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95778)))
			{
				break;
			}
			goto IL_0731;
		case 1508752789u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95822)))
			{
				break;
			}
			goto IL_0731;
		case 3874195319u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95866)))
			{
				break;
			}
			goto IL_0731;
		case 3984466757u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95906)))
			{
				break;
			}
			goto IL_0731;
		case 2968845990u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95950)))
			{
				break;
			}
			goto IL_0731;
		case 2856493441u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95988)))
			{
				break;
			}
			goto IL_0731;
		case 803002155u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96028)))
			{
				break;
			}
			goto IL_0731;
		case 3724729986u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96072)))
			{
				break;
			}
			goto IL_0749;
		case 182608757u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96106)))
			{
				break;
			}
			goto IL_0749;
		case 2576639908u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96142)))
			{
				break;
			}
			goto IL_0749;
		case 1043656348u:
			if (text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96180))
			{
				goto IL_0749;
			}
			break;
		case 1257895014u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96218)))
			{
				break;
			}
			goto IL_0749;
		case 2702413192u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96252)))
			{
				break;
			}
			goto IL_0749;
		case 79075169u:
			if (text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96290))
			{
				goto IL_0749;
			}
			break;
		case 778814160u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96322)))
			{
				break;
			}
			goto IL_0749;
		case 2424221922u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96356)))
			{
				break;
			}
			goto IL_0749;
		case 3459376875u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96394)))
			{
				break;
			}
			return new HighContrastThemeDefinition(themeName);
		case 1969082158u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96422)))
			{
				break;
			}
			goto IL_076e;
		case 3815713973u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94954)))
			{
				break;
			}
			goto IL_076e;
		case 26890522u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95020)))
			{
				break;
			}
			goto IL_076e;
		case 3703116271u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95088)))
			{
				break;
			}
			goto IL_076e;
		case 721696580u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96456)))
			{
				break;
			}
			return new ThemeDefinition(themeName, ThemeIntent.Black);
		case 1163329637u:
			if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96470)))
			{
				break;
			}
			return new ThemeDefinition(themeName, ThemeIntent.Dark);
		case 1827351814u:
			{
				if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96482)))
				{
					break;
				}
				return new ThemeDefinition(themeName, ThemeIntent.White);
			}
			IL_076e:
			return new ThemeDefinition(themeName)
			{
				Intent = ThemeIntent.Light,
				ArrowKind = ArrowKind.FilledTriangle
			};
			IL_0749:
			colorFamilyName = P4W(themeName);
			return new OfficeWhiteThemeDefinition(themeName, colorFamilyName);
			IL_0731:
			colorFamilyName2 = P4W(themeName);
			return new OfficeColorfulThemeDefinition(themeName, colorFamilyName2);
			IL_06ac:
			intent = ThemeIntent.Light;
			text3 = themeName;
			text4 = text3;
			if (!(text4 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95600)))
			{
				if (!(text4 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95624)))
				{
					if (text4 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95646))
					{
						intent = ThemeIntent.White;
					}
				}
				else
				{
					intent = ThemeIntent.Dark;
				}
			}
			else
			{
				intent = ThemeIntent.Black;
			}
			return new MetroThemeDefinition(themeName, intent);
		}
		return new ThemeDefinition(themeName, ThemeIntent.Light);
	}

	public static ThemeDefinition GetThemeDefinition(string themeName)
	{
		ThemeDefinition value = null;
		if (uuX != null)
		{
			int num = 0;
			if (mY0() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			uuX.TryGetValue(themeName, out value);
		}
		if (value == null)
		{
			value = CreateDefaultThemeDefinition(themeName);
		}
		return value;
	}

	public static bool IsDarkTheme(string themeName)
	{
		UIColor uIColor;
		int num;
		if (!string.IsNullOrEmpty(themeName))
		{
			if (uuX != null && uuX.TryGetValue(themeName, out var value))
			{
				if (value.Intent != ThemeIntent.HighContrast)
				{
					return value.IsDarkTheme;
				}
				uIColor = UIColor.FromColor(SystemColors.WindowColor);
				num = 1;
				if (mY0() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			if (themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96456) || themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96470) || themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95600) || themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95624) || themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95670))
			{
				return true;
			}
			if (themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96394))
			{
				goto IL_00e0;
			}
		}
		return false;
		IL_00e0:
		uIColor = UIColor.FromColor(SystemColors.WindowColor);
		num = 0;
		if (!gYn())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 2:
			break;
		default:
			return !uIColor.IsLight;
		case 1:
			return !uIColor.IsLight;
		}
		goto IL_00e0;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	public static bool IsHighContrastTheme(string themeName)
	{
		if (!string.IsNullOrEmpty(themeName))
		{
			if (uuX != null && uuX.TryGetValue(themeName, out var value))
			{
				return value.Intent == ThemeIntent.HighContrast;
			}
			if (themeName == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96394))
			{
				return true;
			}
		}
		return false;
	}

	public static void RegisterThemeDefinition(ThemeDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96496));
		}
		if (uuX == null)
		{
			uuX = new Dictionary<string, ThemeDefinition>();
		}
		string text = definition.Name ?? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96520);
		uuX[text] = definition;
		if (CurrentTheme == text)
		{
			ApplyThemeAndRaiseChangedEvent();
		}
	}

	public static void UnregisterThemeDefinition(string themeName)
	{
		if (uuX != null)
		{
			themeName = themeName ?? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96520);
			uuX.Remove(themeName);
			if (CurrentTheme == themeName)
			{
				ApplyThemeAndRaiseChangedEvent();
			}
		}
	}

	private static void s4U(bool P_0)
	{
		if (P_0 == SuB)
		{
			return;
		}
		Application current = Application.Current;
		if (current != null)
		{
			if (P_0)
			{
				current.Activated += h4R;
			}
			else
			{
				current.Activated -= h4R;
			}
			SuB = P_0;
		}
	}

	private static void h4H(bool P_0)
	{
		string text = null;
		switch (SystemApplicationMode)
		{
		case SystemApplicationMode.Light:
			text = AutomaticLightTheme;
			break;
		case SystemApplicationMode.Dark:
			text = AutomaticDarkTheme;
			break;
		case SystemApplicationMode.HighContrast:
			text = AutomaticHighContrastTheme;
			break;
		}
		bool flag = !string.IsNullOrEmpty(text);
		int num = 0;
		if (!gYn())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (!flag)
			{
				return;
			}
			if (CurrentTheme != text)
			{
				CurrentTheme = text;
				return;
			}
			break;
		case 1:
			break;
		}
		if (P_0)
		{
			ApplyThemeAndRaiseChangedEvent();
		}
	}

	private static void V46()
	{
		Color aub = Aub;
		SystemApplicationMode? systemApplicationMode = pup;
		Aub = SystemColors.ActiveBorderColor;
		pup = null;
		bool flag = SystemApplicationMode == SystemApplicationMode.HighContrast && aub != Aub;
		int num = 0;
		if (gYn())
		{
			num = 1;
		}
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				flag2 = systemApplicationMode != SystemApplicationMode;
				flag3 = flag2;
				num = 0;
				if (!gYn())
				{
					num = num2;
				}
				continue;
			}
			if (flag3)
			{
				B4E();
			}
			if (flag2 || flag)
			{
				bool flag4 = !flag2 && flag;
				h4H(flag4);
			}
			return;
		}
	}

	private static SystemApplicationMode T4V()
	{
		if (SystemParameters.HighContrast)
		{
			return SystemApplicationMode.HighContrast;
		}
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96536), writable: false))
		{
			if (registryKey != null && (int)registryKey.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96660), 1) == 0)
			{
				return SystemApplicationMode.Dark;
			}
		}
		return SystemApplicationMode.Light;
	}

	private static void e45()
	{
		pup = SystemApplicationMode.Light;
		if (!SecurityHelper.IsFullTrust)
		{
			return;
		}
		try
		{
			pup = T4V();
		}
		catch
		{
		}
	}

	private static void h4R(object P_0, EventArgs P_1)
	{
		if (Application.Current?.MainWindow != null)
		{
			s4U(_0020: false);
			J4s();
		}
	}

	private static void B4E()
	{
		uuy?.Invoke(null, EventArgs.Empty);
	}

	private static void J4s()
	{
		HwndSource hwndSource = ((EuT != null && EuT.IsAlive) ? ((HwndSource)EuT.Target) : null);
		EuT = null;
		Application current = Application.Current;
		if (current != null)
		{
			Window window = current?.MainWindow;
			if (window != null)
			{
				IntPtr handle = new WindowInteropHelper(window).Handle;
				if (handle != IntPtr.Zero)
				{
					HwndSource hwndSource2 = HwndSource.FromHwnd(handle);
					if (hwndSource2 != null)
					{
						EuT = new WeakReference(hwndSource2);
						if (hwndSource == hwndSource2)
						{
							return;
						}
						hwndSource2.AddHook(Y4L);
					}
				}
			}
			else
			{
				s4U(_0020: true);
			}
		}
		hwndSource?.RemoveHook(Y4L);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static IntPtr Y4L(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
	{
		if (P_1 == 26)
		{
			string text = Marshal.PtrToStringAuto(P_3);
			if (text == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96698))
			{
				V46();
			}
		}
		return IntPtr.Zero;
	}

	public static void RegisterAutomaticThemes(string lightThemeName, string darkThemeName, string highContrastThemeName)
	{
		AutomaticLightTheme = lightThemeName;
		AutomaticDarkTheme = darkThemeName;
		AutomaticHighContrastTheme = highContrastThemeName;
		h4H(_0020: false);
		J4s();
	}

	public static void UnregisterAutomaticThemes()
	{
		AutomaticLightTheme = null;
		AutomaticDarkTheme = null;
		AutomaticHighContrastTheme = null;
	}

	internal static bool gYn()
	{
		return QYG == null;
	}

	internal static ThemeManager mY0()
	{
		return QYG;
	}
}
