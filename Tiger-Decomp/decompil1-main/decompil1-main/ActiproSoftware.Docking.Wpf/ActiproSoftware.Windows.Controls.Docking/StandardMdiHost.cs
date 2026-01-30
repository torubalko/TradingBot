using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking;

[TemplateVisualState(Name = "ScrollingDisabled", GroupName = "ScrollStates")]
[ToolboxItem(false)]
[TemplatePart(Name = "PART_ItemsControl", Type = typeof(StandardMdiItemsControl))]
[ContentProperty("Windows")]
[TemplateVisualState(Name = "ScrollingEnabled", GroupName = "ScrollStates")]
public class StandardMdiHost : MdiHostBase, iy, IDockTarget, jJ, wH, lX
{
	[CompilerGenerated]
	private sealed class _003CGetMdiWindows_003Ed__30 : IEnumerable<StandardMdiWindowControl>, IEnumerable, IEnumerator<StandardMdiWindowControl>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private StandardMdiWindowControl _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public StandardMdiHost _003C_003E4__this;

		private IEnumerator<DockingWindow> _003C_003E7__wrap1;

		internal static _003CGetMdiWindows_003Ed__30 MGg;

		StandardMdiWindowControl IEnumerator<StandardMdiWindowControl>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetMdiWindows_003Ed__30(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				StandardMdiHost standardMdiHost = _003C_003E4__this;
				switch (num)
				{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = standardMdiHost.kaz.GetEnumerator();
					_003C_003E1__state = -3;
					break;
				default:
					return false;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				StandardMdiWindowControl standardMdiWindowControl = default(StandardMdiWindowControl);
				int num3 = default(int);
				while (true)
				{
					int num2;
					if (_003C_003E7__wrap1.MoveNext())
					{
						DockingWindow current = _003C_003E7__wrap1.Current;
						if (current == null)
						{
							continue;
						}
						standardMdiWindowControl = standardMdiHost.FaL(current);
						num2 = 0;
						if (!dGi())
						{
							goto IL_000e;
						}
					}
					else
					{
						num2 = 1;
						if (QGZ() != null)
						{
							goto IL_000e;
						}
					}
					goto IL_0012;
					IL_0012:
					switch (num2)
					{
					case 1:
						_003C_003Em__Finally1();
						_003C_003E7__wrap1 = null;
						return false;
					}
					if (standardMdiWindowControl != null)
					{
						_003C_003E2__current = standardMdiWindowControl;
						_003C_003E1__state = 1;
						return true;
					}
					continue;
					IL_000e:
					num2 = num3;
					goto IL_0012;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<StandardMdiWindowControl> IEnumerable<StandardMdiWindowControl>.GetEnumerator()
		{
			_003CGetMdiWindows_003Ed__30 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetMdiWindows_003Ed__30(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<StandardMdiWindowControl>)this).GetEnumerator();
		}

		internal static bool dGi()
		{
			return MGg == null;
		}

		internal static _003CGetMdiWindows_003Ed__30 QGZ()
		{
			return MGg;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_LogicalChildren_003Ed__78 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StandardMdiHost _003C_003E4__this;

		private IEnumerator<DockingWindow> _003C_003E7__wrap1;

		private static _003Cget_LogicalChildren_003Ed__78 qGu;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003Cget_LogicalChildren_003Ed__78(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3 && num != 1)
			{
				return;
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2 = 0;
				if (!nGy())
				{
					goto IL_001e;
				}
				goto IL_0022;
				IL_001e:
				int num3 = default(int);
				num2 = num3;
				goto IL_0022;
				IL_0022:
				while (true)
				{
					switch (num2)
					{
					case 1:
						_003C_003Em__Finally1();
						_003C_003E7__wrap1 = null;
						return false;
					}
					StandardMdiHost standardMdiHost = _003C_003E4__this;
					switch (num)
					{
					case 0:
						_003C_003E1__state = -1;
						_003C_003E7__wrap1 = standardMdiHost.Windows.GetEnumerator();
						_003C_003E1__state = -3;
						break;
					default:
						return false;
					case 1:
						_003C_003E1__state = -3;
						break;
					}
					while (_003C_003E7__wrap1.MoveNext())
					{
						DockingWindow current = _003C_003E7__wrap1.Current;
						if (current != null)
						{
							_003C_003E2__current = current;
							_003C_003E1__state = 1;
							return true;
						}
					}
					num2 = 1;
					if (UGV() == null)
					{
						continue;
					}
					break;
				}
				goto IL_001e;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		internal static bool nGy()
		{
			return qGu == null;
		}

		internal static _003Cget_LogicalChildren_003Ed__78 UGV()
		{
			return qGu;
		}
	}

	private int Fao;

	private bool vat;

	private StandardMdiItemsControl Xau;

	private ObservableCollection<DockingWindow> kaz;

	private DelegateCommand<object> GWi;

	private DelegateCommand<object> LWd;

	private DelegateCommand<object> wWw;

	private DelegateCommand<object> aW2;

	public static readonly DependencyProperty AreMaximizedWindowFramesVisibleProperty;

	public static readonly DependencyProperty AreWindowsMaximizedProperty;

	public static readonly DependencyProperty CanWindowsMaximizeProperty;

	public static readonly DependencyProperty CanWindowsMinimizeProperty;

	public static readonly DependencyProperty IsAutoCascadeEnabledProperty;

	public static readonly DependencyProperty IsExternalMaximizedUIRequiredProperty;

	public static readonly DependencyProperty IsScrollingEnabledProperty;

	internal static StandardMdiHost MHM;

	public bool AreMaximizedWindowFramesVisible
	{
		get
		{
			return (bool)GetValue(AreMaximizedWindowFramesVisibleProperty);
		}
		set
		{
			SetValue(AreMaximizedWindowFramesVisibleProperty, value);
		}
	}

	public bool AreWindowsMaximized
	{
		get
		{
			return (bool)GetValue(AreWindowsMaximizedProperty);
		}
		set
		{
			SetValue(AreWindowsMaximizedProperty, value);
		}
	}

	public bool CanWindowsMaximize
	{
		get
		{
			return (bool)GetValue(CanWindowsMaximizeProperty);
		}
		set
		{
			SetValue(CanWindowsMaximizeProperty, value);
		}
	}

	public bool CanWindowsMinimize
	{
		get
		{
			return (bool)GetValue(CanWindowsMinimizeProperty);
		}
		set
		{
			SetValue(CanWindowsMinimizeProperty, value);
		}
	}

	public ICommand ClosePrimaryWindowCommand => GWi;

	public bool IsAutoCascadeEnabled
	{
		get
		{
			return (bool)GetValue(IsAutoCascadeEnabledProperty);
		}
		set
		{
			SetValue(IsAutoCascadeEnabledProperty, value);
		}
	}

	public bool IsExternalMaximizedUIRequired
	{
		get
		{
			return (bool)GetValue(IsExternalMaximizedUIRequiredProperty);
		}
		private set
		{
			SetValue(IsExternalMaximizedUIRequiredProperty, value);
		}
	}

	public bool IsScrollingEnabled
	{
		get
		{
			return (bool)GetValue(IsScrollingEnabledProperty);
		}
		set
		{
			SetValue(IsScrollingEnabledProperty, value);
		}
	}

	protected override IEnumerator LogicalChildren
	{
		get
		{
			int num2 = default(int);
			int num4 = default(int);
			while (true)
			{
				IL_0001:
				int num = num2;
				int num3 = 0;
				if (!_003Cget_LogicalChildren_003Ed__78.nGy())
				{
					goto IL_001e;
				}
				goto IL_0022;
				IL_0022:
				while (true)
				{
					switch (num3)
					{
					case 1:
						yield break;
					}
					StandardMdiHost standardMdiHost = this;
					if (num == 0)
					{
						using (IEnumerator<DockingWindow> enumerator = standardMdiHost.Windows.GetEnumerator())
						{
							goto IL_00f0;
							IL_00f0:
							while (true)
							{
								if (!enumerator.MoveNext())
								{
									num3 = 1;
									if (_003Cget_LogicalChildren_003Ed__78.UGV() == null)
									{
										break;
									}
									goto end_IL_0022;
								}
								DockingWindow current = enumerator.Current;
								if (current == null)
								{
									continue;
								}
								yield return current;
								goto end_IL_008f;
							}
							continue;
							end_IL_008f:;
						}
						goto IL_0001;
					}
					if (num != 1)
					{
						yield break;
					}
					goto IL_00f0;
					continue;
					end_IL_0022:
					break;
				}
				goto IL_001e;
				IL_001e:
				num3 = num4;
				goto IL_0022;
			}
		}
	}

	public ICommand MaximizePrimaryWindowCommand => LWd;

	public ICommand MinimizePrimaryWindowCommand => wWw;

	public ICommand RestorePrimaryWindowCommand => aW2;

	public ObservableCollection<DockingWindow> Windows => kaz;

	bool iy.HasDockGuides => true;

	bool iy.RequiresReverseOrderInsertion => true;

	bool wH.ContainsDockingWindows => kaz.Count > 0;

	bool wH.ContainsWorkspace => false;

	Size wH.DockedSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	DockHost wH.DockHost
	{
		get
		{
			return base.DockHost;
		}
		set
		{
			base.DockHost = value;
		}
	}

	Size wH.MaxSize => new Size(double.PositiveInfinity, double.PositiveInfinity);

	Size wH.MinSize => default(Size);

	IEnumerable<lX> lX.ChildNodes => kaz.OfType<lX>();

	bool jJ.CanCascade => true;

	bool jJ.CanTile => true;

	MdiKind jJ.Kind => MdiKind.Standard;

	public StandardMdiHost()
	{
		IVH.CecNqz();
		kaz = new ObservableCollection<DockingWindow>();
		base._002Ector();
		base.DefaultStyleKey = typeof(StandardMdiHost);
		qar();
		base.Loaded += eaq;
		base.SizeChanged += NaF;
		kaz.CollectionChanged += BaV;
	}

	private double Ma8()
	{
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		if (KHL() != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		DockingWindow dockingWindow = default(DockingWindow);
		double num5 = default(double);
		Size size = default(Size);
		int num6 = default(int);
		DockingWindow[] array2 = default(DockingWindow[]);
		while (true)
		{
			switch (num3)
			{
			case 1:
				if (dockingWindow != null)
				{
					StandardMdiWindowControl standardMdiWindowControl = FaL(dockingWindow);
					if (standardMdiWindowControl != null)
					{
						if (num5 > 0.0 && num5 + standardMdiWindowControl.ActualWidth > size.Width)
						{
							num5 = 0.0;
							num -= num2;
							num2 = 0.0;
						}
						standardMdiWindowControl.Left = num5;
						standardMdiWindowControl.Top = num - standardMdiWindowControl.ActualHeight;
						standardMdiWindowControl.Dr3(size.Height - Canvas.GetTop(standardMdiWindowControl));
						num5 += standardMdiWindowControl.ActualWidth;
						num2 = Math.Max(num2, standardMdiWindowControl.ActualHeight);
					}
				}
				num6++;
				goto IL_010a;
			default:
				{
					if (Xau == null)
					{
						goto IL_00a1;
					}
					DockingWindow[] array = kaz.Where((DockingWindow w) => w.StandardMdiWindowState == WindowState.Minimized).ToArray();
					size = Jal();
					num5 = 0.0;
					num = size.Height;
					array2 = array;
					num6 = 0;
					goto IL_010a;
				}
				IL_010a:
				if (num6 < array2.Length)
				{
					dockingWindow = array2[num6];
					num3 = 1;
					if (KHL() != null)
					{
						num3 = 0;
					}
					break;
				}
				goto IL_00a1;
				IL_00a1:
				return num - num2;
			}
		}
	}

	internal bool waD(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15482));
		}
		if (AreWindowsMaximized && P_0.StandardMdiWindowState != WindowState.Maximized)
		{
			P_0.StandardMdiWindowState = WindowState.Maximized;
		}
		if (Xau != null)
		{
			StandardMdiWindowControl standardMdiWindowControl = FaL(P_0);
			if (standardMdiWindowControl != null)
			{
				int zIndex = Panel.GetZIndex(standardMdiWindowControl);
				int num = EaS(P_0);
				int num2 = 0;
				if (KHL() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					if (num != zIndex)
					{
						Panel.SetZIndex(standardMdiWindowControl, num);
					}
					base.PrimaryWindow = P_0;
					return num != zIndex;
				}
			}
		}
		return false;
	}

	private void NaE(bool P_0)
	{
		UpdateLayout();
		AreWindowsMaximized = false;
		ArrangeMinimizedWindows();
		DockingWindow[] array = (from w in kaz
			where w.StandardMdiWindowState == WindowState.Normal
			orderby w.LastActiveDateTime
			select w).ToArray();
		Fao = 0;
		DockingWindow[] array2 = array;
		foreach (DockingWindow dockingWindow in array2)
		{
			if (dockingWindow != null)
			{
				bool flag = P_0 && (dockingWindow.SizeToContentModes & SizeToContentModes.StandardMdi) == SizeToContentModes.StandardMdi;
				dockingWindow.StandardMdiBounds = VaM(Fao, flag);
			}
		}
	}

	private void qar()
	{
		GWi = new DelegateCommand<object>(delegate
		{
			ClosePrimaryWindow();
		}, (object P_0) => base.PrimaryWindow != null);
		LWd = new DelegateCommand<object>(delegate
		{
			MaximizePrimaryWindow();
		}, (object P_0) => base.PrimaryWindow != null);
		wWw = new DelegateCommand<object>(delegate
		{
			MinimizePrimaryWindow();
		}, (object P_0) => base.PrimaryWindow != null);
		aW2 = new DelegateCommand<object>(delegate
		{
			RestorePrimaryWindow();
		}, (object P_0) => base.PrimaryWindow != null);
	}

	private void yax()
	{
		DockingWindow dockingWindow = (from w in kaz
			where w.StandardMdiWindowState != WindowState.Minimized
			orderby w.LastActiveDateTime descending
			select w).ToArray().FirstOrDefault();
		if (dockingWindow == null)
		{
			DockHost dockHost = base.DockHost;
			if (dockHost != null)
			{
				cP.elb(dockHost);
			}
		}
		else
		{
			dockingWindow.Activate();
		}
	}

	internal Size Jal()
	{
		if (Xau != null)
		{
			return new Size(Math.Max(0.0, Xau.ActualWidth - Xau.BorderThickness.Left - Xau.BorderThickness.Right), Math.Max(0.0, Xau.ActualHeight - Xau.BorderThickness.Top - Xau.BorderThickness.Bottom));
		}
		return new Size(300.0, 200.0);
	}

	private Rect VaM(int P_0, bool P_1)
	{
		Size size = Jal();
		size.Width = Math.Max(300.0, size.Width);
		size.Height = Math.Max(300.0, size.Height);
		P_0 %= 8;
		Fao = ((Fao + 1 < 8) ? (Fao + 1) : 0);
		Point location = new Point(0.0 - base.BorderThickness.Left + 2.0 + (double)P_0 * 30.0, 0.0 - base.BorderThickness.Top + 2.0 + (double)P_0 * 30.0);
		Size size2 = new Size(P_1 ? double.NaN : Math.Max(160.0, size.Width - 210.0), P_1 ? double.NaN : Math.Max(60.0, size.Height - 210.0));
		return new Rect(location, size2);
	}

	internal IEnumerable<StandardMdiWindowControl> Jav()
	{
		using IEnumerator<DockingWindow> enumerator = kaz.GetEnumerator();
		StandardMdiWindowControl standardMdiWindowControl = default(StandardMdiWindowControl);
		int num2 = default(int);
		while (true)
		{
			int num;
			if (enumerator.MoveNext())
			{
				DockingWindow current = enumerator.Current;
				if (current == null)
				{
					continue;
				}
				standardMdiWindowControl = FaL(current);
				num = 0;
				if (!_003CGetMdiWindows_003Ed__30.dGi())
				{
					goto IL_000e;
				}
			}
			else
			{
				num = 1;
				if (_003CGetMdiWindows_003Ed__30.QGZ() != null)
				{
					goto IL_000e;
				}
			}
			goto IL_0012;
			IL_0012:
			switch (num)
			{
			case 1:
				break;
			default:
				if (standardMdiWindowControl != null)
				{
					yield return standardMdiWindowControl;
				}
				continue;
			}
			break;
			IL_000e:
			num = num2;
			goto IL_0012;
		}
	}

	private Rect Ba7()
	{
		return new Rect(default(Point), Jal());
	}

	private Rect XaR(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15518));
		}
		Size size;
		Rect rect;
		DockingWindow[] array;
		double num;
		double num2;
		int num3;
		if (Xau != null)
		{
			StandardMdiWindowControl standardMdiWindowControl = FaL(P_0);
			if (standardMdiWindowControl != null)
			{
				size = Jal();
				rect = standardMdiWindowControl.DJT();
				array = kaz.Where((DockingWindow w) => w.StandardMdiWindowState == WindowState.Minimized).ToArray();
				num = 0.0;
				num2 = size.Height - rect.Height;
				num3 = 0;
				if (KHL() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		return new Rect(0.0, 0.0, 180.0, 32.0);
		IL_0005:
		int num4 = default(int);
		num3 = num4;
		goto IL_0009;
		IL_0009:
		bool flag = default(bool);
		DockingWindow[] array2 = default(DockingWindow[]);
		int num5 = default(int);
		do
		{
			switch (num3)
			{
			default:
				flag = false;
				array2 = array;
				num5 = 0;
				goto case 1;
			case 2:
				break;
			case 1:
				if (num5 < array2.Length)
				{
					DockingWindow dockingWindow = array2[num5];
					if (dockingWindow == P_0)
					{
						break;
					}
					StandardMdiWindowControl standardMdiWindowControl2 = FaL(dockingWindow);
					if (standardMdiWindowControl2 == null || standardMdiWindowControl2.Left != num || standardMdiWindowControl2.Top != num2)
					{
						break;
					}
					flag = true;
				}
				if (flag)
				{
					num += rect.Width;
					if (num >= size.Width)
					{
						num = 0.0;
						num2 -= rect.Height;
					}
					goto default;
				}
				return new Rect(num, num2, rect.Width, rect.Height);
			}
			num5++;
			num3 = 1;
		}
		while (KHL() == null);
		goto IL_0005;
	}

	internal int EaS(DockingWindow P_0)
	{
		int num = -1;
		if (Xau != null)
		{
			foreach (object item in (IEnumerable)Xau.Items)
			{
				if (item != P_0)
				{
					StandardMdiWindowControl standardMdiWindowControl = FaL(item);
					if (standardMdiWindowControl != null)
					{
						num = Math.Max(num, Panel.GetZIndex(standardMdiWindowControl));
					}
				}
			}
		}
		return Math.Min(1000000000, num + 1);
	}

	private StandardMdiWindowControl FaL(object P_0)
	{
		if (Xau != null && P_0 != null)
		{
			return Xau.ItemContainerGenerator.ContainerFromItem(P_0) as StandardMdiWindowControl;
		}
		return null;
	}

	[SpecialName]
	private StandardMdiItemsControl kag()
	{
		return Xau;
	}

	[SpecialName]
	private void SaX(StandardMdiItemsControl value)
	{
		Xau = value;
	}

	internal void Va3(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		StandardMdiWindowControl standardMdiWindowControl = FaL(P_0);
		if (standardMdiWindowControl == null)
		{
			return;
		}
		switch (standardMdiWindowControl.WindowState)
		{
		case WindowState.Maximized:
			AreWindowsMaximized = true;
			standardMdiWindowControl.yJ8(Ba7());
			break;
		case WindowState.Minimized:
		{
			AreWindowsMaximized = false;
			standardMdiWindowControl.Width = 180.0;
			standardMdiWindowControl.ClearValue(FrameworkElement.HeightProperty);
			standardMdiWindowControl.UpdateLayout();
			Size size = Jal();
			standardMdiWindowControl.yJ8(XaR(P_0));
			standardMdiWindowControl.Dr3(size.Height - standardMdiWindowControl.DJT().Top);
			if (base.PrimaryWindow == P_0)
			{
				yax();
			}
			break;
		}
		case WindowState.Normal:
			AreWindowsMaximized = false;
			if (P_0.StandardMdiBounds.IsEmpty)
			{
				bool flag = (P_0.SizeToContentModes & SizeToContentModes.StandardMdi) == SizeToContentModes.StandardMdi;
				P_0.StandardMdiBounds = VaM(Fao, flag);
			}
			standardMdiWindowControl.yJ8(P_0.StandardMdiBounds);
			break;
		}
	}

	private static void Da6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((StandardMdiHost)P_0).Jaf();
	}

	private static void ha9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		StandardMdiHost standardMdiHost = default(StandardMdiHost);
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
					if (standardMdiHost.AreWindowsMaximized)
					{
						DockingWindow primaryWindow = standardMdiHost.PrimaryWindow;
						if (primaryWindow != null && primaryWindow.StandardMdiWindowState != WindowState.Maximized)
						{
							primaryWindow.StandardMdiWindowState = WindowState.Maximized;
						}
					}
					else
					{
						foreach (DockingWindow window in standardMdiHost.Windows)
						{
							if (window != null && window.StandardMdiWindowState == WindowState.Maximized)
							{
								window.StandardMdiWindowState = WindowState.Normal;
							}
						}
					}
					standardMdiHost.VaU(_0020: true);
					standardMdiHost.Jaf();
					return;
				}
				standardMdiHost = (StandardMdiHost)P_0;
				num2 = 0;
			}
			while (PHh());
		}
	}

	private static void jaY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((StandardMdiHost)P_0).DockSite?.BNj();
	}

	private static void Lap(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((StandardMdiHost)P_0).DockSite?.BNj();
	}

	private static void jas(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((StandardMdiHost)P_0).VaU(_0020: true);
	}

	private void eaq(object P_0, RoutedEventArgs P_1)
	{
		mac();
		bool areWindowsMaximized = AreWindowsMaximized;
		if (!vat)
		{
			vat = true;
			if (kaz.Count > 1)
			{
				DockingWindow primaryWindow = base.PrimaryWindow;
				if (primaryWindow != null && !primaryWindow.IsActive && kaz.Last() != primaryWindow)
				{
					base.PrimaryWindow = kaz.Last();
				}
			}
			if (IsAutoCascadeEnabled)
			{
				NaE(_0020: true);
			}
		}
		if (areWindowsMaximized)
		{
			AreWindowsMaximized = true;
		}
	}

	private void NaF(object P_0, SizeChangedEventArgs P_1)
	{
		int num2 = default(int);
		foreach (DockingWindow item in kaz)
		{
			switch (item.StandardMdiWindowState)
			{
			case WindowState.Minimized:
			{
				Size size = Jal();
				StandardMdiWindowControl standardMdiWindowControl = FaL(item);
				if (standardMdiWindowControl != null)
				{
					standardMdiWindowControl.Top = size.Height - standardMdiWindowControl.CrL();
					int num = 0;
					if (!PHh())
					{
						num = num2;
					}
					switch (num)
					{
					}
				}
				break;
			}
			case WindowState.Maximized:
				if (AreWindowsMaximized)
				{
					FaL(item)?.yJ8(Ba7());
				}
				break;
			}
		}
	}

	private void BaV(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1.Action == NotifyCollectionChangedAction.Reset && !DesignerProperties.GetIsInDesignMode(this))
		{
			throw new NotSupportedException();
		}
		if (P_1.OldItems != null)
		{
			foreach (object oldItem in P_1.OldItems)
			{
				if (oldItem is DockingWindow dockingWindow)
				{
					RemoveLogicalChild(dockingWindow);
					dockingWindow.IsCurrentlyOpen = false;
					dockingWindow.IsSelected = false;
				}
			}
		}
		if (P_1.NewItems != null)
		{
			foreach (object newItem in P_1.NewItems)
			{
				if (newItem is DockingWindow dockingWindow2)
				{
					DockSite dockSite = base.DockSite;
					if (dockSite != null)
					{
						dockingWindow2.DockSite = dockSite;
					}
					AddLogicalChild(dockingWindow2);
					if (IsAutoCascadeEnabled || dockingWindow2.StandardMdiBounds.IsEmpty)
					{
						bool flag = (dockingWindow2.SizeToContentModes & SizeToContentModes.StandardMdi) == SizeToContentModes.StandardMdi;
						dockingWindow2.StandardMdiBounds = VaM(Fao, flag);
					}
					dockingWindow2.zIH(DockingWindowState.Document);
					dockingWindow2.IsCurrentlyOpen = true;
					dockingWindow2.IsSelected = false;
				}
			}
		}
		DockingWindow primaryWindow = base.PrimaryWindow;
		if (primaryWindow == null || !kaz.Contains(primaryWindow) || !vat)
		{
			base.PrimaryWindow = kaz.LastOrDefault();
		}
	}

	private void naP()
	{
		GWi.RaiseCanExecuteChanged();
		LWd.RaiseCanExecuteChanged();
		wWw.RaiseCanExecuteChanged();
		aW2.RaiseCanExecuteChanged();
	}

	private void Jaf()
	{
		IsExternalMaximizedUIRequired = base.PrimaryWindow != null && AreWindowsMaximized && !AreMaximizedWindowFramesVisible;
	}

	private void VaU(bool P_0)
	{
		VisualStateManager.GoToState(this, IsScrollingEnabled ? vVK.ssH(15584) : vVK.ssH(15546), P_0);
	}

	public void ArrangeMinimizedWindows()
	{
		Ma8();
	}

	public void Cascade()
	{
		NaE(_0020: false);
	}

	public void ClosePrimaryWindow()
	{
		base.PrimaryWindow?.Close();
	}

	public sealed override IList<DockingWindow> GetDocuments()
	{
		return kaz;
	}

	public void MaximizePrimaryWindow()
	{
		DockingWindow primaryWindow = base.PrimaryWindow;
		if (primaryWindow != null)
		{
			primaryWindow.Activate();
			primaryWindow.StandardMdiWindowState = WindowState.Maximized;
		}
	}

	public void MinimizePrimaryWindow()
	{
		DockingWindow primaryWindow = base.PrimaryWindow;
		if (primaryWindow != null)
		{
			primaryWindow.StandardMdiWindowState = WindowState.Minimized;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		naP();
		SaX(GetTemplateChild(vVK.ssH(15620)) as StandardMdiItemsControl);
		VaU(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new StandardMdiHostAutomationPeer(this);
	}

	protected override void OnPrimaryWindowChanged(DockingWindow oldValue, DockingWindow newValue)
	{
		if (oldValue != null)
		{
			oldValue.IsSelected = false;
		}
		if (newValue != null)
		{
			newValue.IsSelected = true;
			waD(newValue);
		}
		naP();
		Jaf();
	}

	public void RestorePrimaryWindow()
	{
		DockingWindow primaryWindow = base.PrimaryWindow;
		if (primaryWindow != null)
		{
			primaryWindow.Activate();
			primaryWindow.StandardMdiWindowState = WindowState.Normal;
		}
	}

	public void TileHorizontally()
	{
		AreWindowsMaximized = false;
		double height = Ma8();
		DockingWindow[] array = kaz.Where((DockingWindow w) => w.StandardMdiWindowState == WindowState.Normal).ToArray();
		Size size = Jal();
		size.Height = height;
		int num = (int)Math.Max(1.0, Math.Floor(Math.Sqrt(array.Length)));
		int num2 = (int)Math.Ceiling((double)array.Length / (double)num);
		int num3 = num * num2 - array.Length;
		double num4 = size.Width;
		int num5 = 0;
		if (!PHh())
		{
			int num6 = default(int);
			num5 = num6;
		}
		int num7 = default(int);
		double height2 = default(double);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		double num12 = default(double);
		double num13 = default(double);
		DockingWindow[] array2 = default(DockingWindow[]);
		int num14 = default(int);
		switch (num5)
		{
		default:
			num7 = (int)Math.Floor(num4 / (double)num);
			height2 = size.Height;
			num8 = 0;
			num9 = int.MaxValue;
			num10 = num2 - ((num3 > 0) ? 1 : 0);
			num11 = -1;
			num12 = 0.0;
			num13 = 0.0;
			array2 = array;
			num14 = 0;
			goto IL_0029;
		case 1:
			{
				DockingWindow obj = array2[num14];
				if (num9 >= num10)
				{
					if (num11 >= 0)
					{
						num12 += (double)num7;
					}
					num13 = 0.0;
					num11++;
					num10 = num2 - ((num3 > 0) ? 1 : 0);
					num9 = 0;
					if (num3 > 0)
					{
						num3--;
					}
					if (num11 == num - 1)
					{
						num7 = (int)num4;
					}
					else
					{
						num4 -= (double)num7;
					}
					num8 = (int)Math.Floor(height2 / (double)num10);
				}
				Rect standardMdiBounds = new Rect(num12, num13, num7, (num9 == num10 - 1) ? ((int)(height2 - (double)((num10 - 1) * num8))) : num8);
				standardMdiBounds.Width = Math.Max(123.0, standardMdiBounds.Width);
				standardMdiBounds.Height = Math.Max(30.0, standardMdiBounds.Height);
				num13 += (double)num8;
				num9++;
				obj.StandardMdiBounds = standardMdiBounds;
				num14++;
				goto IL_0029;
			}
			IL_0029:
			if (num14 >= array2.Length)
			{
				break;
			}
			goto case 1;
		}
	}

	public void TileVertically()
	{
		AreWindowsMaximized = false;
		double height = Ma8();
		DockingWindow[] array = kaz.Where((DockingWindow w) => w.StandardMdiWindowState == WindowState.Normal).ToArray();
		Size size = Jal();
		size.Height = height;
		int num = (int)Math.Max(1.0, Math.Floor(Math.Sqrt(array.Length)));
		int num2 = (int)Math.Ceiling((double)array.Length / (double)num);
		int num3 = num * num2 - array.Length;
		double num4 = size.Height;
		int num5 = (int)Math.Floor(num4 / (double)num);
		double width = size.Width;
		int num6 = 0;
		int num7 = int.MaxValue;
		int num8 = 0;
		if (KHL() != null)
		{
			int num9 = default(int);
			num8 = num9;
		}
		while (true)
		{
			switch (num8)
			{
			case 1:
				return;
			}
			int num10 = num2 - ((num3 > 0) ? 1 : 0);
			int num11 = -1;
			double num12 = 0.0;
			double num13 = 0.0;
			DockingWindow[] array2 = array;
			foreach (DockingWindow obj in array2)
			{
				if (num7 >= num10)
				{
					if (num11 >= 0)
					{
						num13 += (double)num5;
					}
					num12 = 0.0;
					num11++;
					num10 = num2 - ((num3 > 0) ? 1 : 0);
					num7 = 0;
					if (num3 > 0)
					{
						num3--;
					}
					if (num11 == num - 1)
					{
						num5 = (int)num4;
					}
					else
					{
						num4 -= (double)num5;
					}
					num6 = (int)Math.Floor(width / (double)num10);
				}
				Rect standardMdiBounds = new Rect(num12, num13, (num7 == num10 - 1) ? ((int)(width - (double)((num10 - 1) * num6))) : num6, num5);
				standardMdiBounds.Width = Math.Max(123.0, standardMdiBounds.Width);
				standardMdiBounds.Height = Math.Max(30.0, standardMdiBounds.Height);
				num12 += (double)num6;
				num7++;
				obj.StandardMdiBounds = standardMdiBounds;
			}
			num8 = 1;
			if (!PHh())
			{
				num8 = 1;
			}
		}
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		if (!side.HasValue)
		{
			return DockingWindowState.Document;
		}
		return DockingWindowState.Docked;
	}

	bool iy.SupportsAttach(DockHost draggedDockHost)
	{
		if (draggedDockHost != null)
		{
			return !pL.Mxl(draggedDockHost, (DockingWindow w) => !w.CanBecomeDocumentResolved).Any();
		}
		return true;
	}

	bool iy.SupportsInnerSideDock(DockHost draggedDockHost)
	{
		return false;
	}

	bool iy.SupportsOuterSideDock(DockHost draggedDockHost)
	{
		if (draggedDockHost != null)
		{
			kq kq = draggedDockHost.LayoutKind;
			if ((uint)(kq - 1) <= 1u)
			{
				DockHost dockHost = base.DockHost;
				if (dockHost == null)
				{
					return false;
				}
				return dockHost.GetVisibleToolWindowContainerCount(includeAutoHiddenContainers: false) > 0;
			}
		}
		return false;
	}

	int wH.GetVisibleToolWindowContainerCount()
	{
		return 0;
	}

	void jJ.AddRange(IEnumerable<DockingWindow> windowsToAdd)
	{
		if (windowsToAdd == null)
		{
			return;
		}
		foreach (DockingWindow item in windowsToAdd)
		{
			if (!kaz.Contains(item))
			{
				kaz.Insert(0, item);
			}
		}
	}

	bool jJ.BringToFront(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		return waD(window);
	}

	jJ jJ.CloneForFloatingDockHost()
	{
		StandardMdiHost standardMdiHost = new StandardMdiHost();
		standardMdiHost.BindToProperty(AreMaximizedWindowFramesVisibleProperty, this, vVK.ssH(15658), BindingMode.OneWay);
		standardMdiHost.BindToProperty(CanWindowsMaximizeProperty, this, vVK.ssH(15724), BindingMode.OneWay);
		standardMdiHost.BindToProperty(CanWindowsMinimizeProperty, this, vVK.ssH(15764), BindingMode.OneWay);
		standardMdiHost.BindToProperty(IsAutoCascadeEnabledProperty, this, vVK.ssH(15804), BindingMode.OneWay);
		standardMdiHost.BindToProperty(IsScrollingEnabledProperty, this, vVK.ssH(15848), BindingMode.OneWay);
		return standardMdiHost;
	}

	void jJ.DetachFromPrimaryDockHost()
	{
		BindingOperations.ClearBinding(this, AreMaximizedWindowFramesVisibleProperty);
		BindingOperations.ClearBinding(this, CanWindowsMaximizeProperty);
		BindingOperations.ClearBinding(this, CanWindowsMinimizeProperty);
		BindingOperations.ClearBinding(this, IsAutoCascadeEnabledProperty);
		BindingOperations.ClearBinding(this, IsScrollingEnabledProperty);
	}

	IDockTarget jJ.GetDefaultDockTarget()
	{
		return this;
	}

	int jJ.GetIndexInContainer(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		return kaz.IndexOf(window);
	}

	void jJ.Remove(DockingWindow window, bool leaveBreadcrumb)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (kaz.Contains(window))
		{
			kaz.Remove(window);
		}
	}

	bool jJ.RestoreToDefaultLocation(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (!kaz.Contains(window))
		{
			kaz.Add(window);
			return true;
		}
		return false;
	}

	void jJ.UpdateIsEmpty()
	{
		mac();
	}

	private void mac()
	{
		base.IsEmpty = !pL.Mxl<DockingWindow>(this, null).Any();
	}

	static StandardMdiHost()
	{
		IVH.CecNqz();
		AreMaximizedWindowFramesVisibleProperty = DependencyProperty.Register(vVK.ssH(15658), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(true, Da6));
		AreWindowsMaximizedProperty = DependencyProperty.Register(vVK.ssH(15888), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(false, ha9));
		CanWindowsMaximizeProperty = DependencyProperty.Register(vVK.ssH(15724), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(true, jaY));
		CanWindowsMinimizeProperty = DependencyProperty.Register(vVK.ssH(15764), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(true, Lap));
		IsAutoCascadeEnabledProperty = DependencyProperty.Register(vVK.ssH(15804), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(true));
		IsExternalMaximizedUIRequiredProperty = DependencyProperty.Register(vVK.ssH(15930), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(false));
		IsScrollingEnabledProperty = DependencyProperty.Register(vVK.ssH(15848), typeof(bool), typeof(StandardMdiHost), new PropertyMetadata(false, jas));
	}

	[CompilerGenerated]
	private void wa4(object P_0)
	{
		ClosePrimaryWindow();
	}

	[CompilerGenerated]
	private bool saj(object P_0)
	{
		return base.PrimaryWindow != null;
	}

	[CompilerGenerated]
	private void CaZ(object P_0)
	{
		MaximizePrimaryWindow();
	}

	[CompilerGenerated]
	private bool Vab(object P_0)
	{
		return base.PrimaryWindow != null;
	}

	[CompilerGenerated]
	private void CaA(object P_0)
	{
		MinimizePrimaryWindow();
	}

	[CompilerGenerated]
	private bool VaH(object P_0)
	{
		return base.PrimaryWindow != null;
	}

	[CompilerGenerated]
	private void Ha0(object P_0)
	{
		RestorePrimaryWindow();
	}

	[CompilerGenerated]
	private bool Bah(object P_0)
	{
		return base.PrimaryWindow != null;
	}

	internal static bool PHh()
	{
		return MHM == null;
	}

	internal static StandardMdiHost KHL()
	{
		return MHM;
	}
}
