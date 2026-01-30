using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

public static class VisualTreeHelperExtended
{
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	public delegate VisualDescendantFilterBehavior VisualDescendantFilterCallback(DependencyObject obj);

	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	public delegate VisualResultBehavior VisualResultCallback(DependencyObject obj);

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public Type tUb;

		private static _003C_003Ec__DisplayClass25_0 Sjg;

		public _003C_003Ec__DisplayClass25_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal VisualResultBehavior UUp(DependencyObject obj)
		{
			if (tUb.IsAssignableFrom(obj.GetType()))
			{
				return VisualResultBehavior.Stop;
			}
			return VisualResultBehavior.Continue;
		}

		internal static bool mj8()
		{
			return Sjg == null;
		}

		internal static _003C_003Ec__DisplayClass25_0 Sjj()
		{
			return Sjg;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public ItemsControl PUJ;

		internal static _003C_003Ec__DisplayClass29_0 ajk;

		public _003C_003Ec__DisplayClass29_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal VisualResultBehavior eUt(DependencyObject obj)
		{
			if (obj is Panel panel)
			{
				if (panel.IsItemsHost && panel.TemplatedParent == PUJ)
				{
					return VisualResultBehavior.Stop;
				}
				if (panel.TemplatedParent is ItemsPresenter itemsPresenter && itemsPresenter.TemplatedParent == PUJ)
				{
					return VisualResultBehavior.Stop;
				}
			}
			return VisualResultBehavior.Continue;
		}

		internal static bool xjF()
		{
			return ajk == null;
		}

		internal static _003C_003Ec__DisplayClass29_0 Rjd()
		{
			return ajk;
		}
	}

	internal static VisualTreeHelperExtended W7A;

	private static void dQF<SO>(DependencyObject P_0, IList<SO> P_1) where SO : DependencyObject
	{
		if (P_0 == null)
		{
			return;
		}
		int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
		for (int i = 0; i < childrenCount; i++)
		{
			DependencyObject child = VisualTreeHelper.GetChild(P_0, i);
			if (child != null)
			{
				if (typeof(SO).IsAssignableFrom(child.GetType()))
				{
					P_1.Add((SO)child);
				}
				dQF(child, P_1);
			}
		}
	}

	private static void OQo(DependencyObject P_0, Type P_1, IList<DependencyObject> P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
		for (int i = 0; i < childrenCount; i++)
		{
			DependencyObject child = VisualTreeHelper.GetChild(P_0, i);
			if (child != null)
			{
				if (P_1.IsAssignableFrom(child.GetType()))
				{
					P_2.Add(child);
				}
				OQo(child, P_1, P_2);
			}
		}
	}

	private static DependencyObject gQQ(DependencyObject P_0, Type P_1, ref int P_2)
	{
		int childrenCount;
		int num;
		int num2;
		if (P_0 != null)
		{
			childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
			num = 0;
			num2 = 1;
			if (w7T() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_00e4;
		IL_00e4:
		return null;
		IL_0005:
		int num3 = default(int);
		num2 = num3;
		goto IL_0009;
		IL_0009:
		DependencyObject dependencyObject = default(DependencyObject);
		while (true)
		{
			switch (num2)
			{
			default:
				if (dependencyObject != null)
				{
					return dependencyObject;
				}
				goto IL_014c;
			case 1:
				{
					if (num >= childrenCount)
					{
						break;
					}
					dependencyObject = VisualTreeHelper.GetChild(P_0, num);
					if (dependencyObject != null)
					{
						if (P_1.IsAssignableFrom(dependencyObject.GetType()) && --P_2 < 0)
						{
							return dependencyObject;
						}
						goto IL_010c;
					}
					goto IL_014c;
				}
				IL_014c:
				num++;
				goto case 1;
			}
			break;
			IL_010c:
			dependencyObject = gQQ(dependencyObject, P_1, ref P_2);
			num2 = 0;
			if (w7T() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_00e4;
	}

	private static TZ dQO<TZ>(DependencyObject P_0, Predicate<TZ> P_1, ref int P_2) where TZ : DependencyObject
	{
		if (P_0 != null)
		{
			int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
			for (int i = 0; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(P_0, i);
				if (child is TZ obj && (P_1 == null || P_1(obj)) && --P_2 < 0)
				{
					return child as TZ;
				}
				child = dQO(child, P_1, ref P_2);
				if (child != null)
				{
					return child as TZ;
				}
			}
		}
		return null;
	}

	private static UIElement XQ0(DependencyObject P_0)
	{
		if (IsVisual(P_0))
		{
			int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
			for (int num = childrenCount - 1; num >= 0; num--)
			{
				DependencyObject child = VisualTreeHelper.GetChild(P_0, num);
				if (child != null)
				{
					UIElement uIElement = XQ0(child);
					if (uIElement != null)
					{
						return uIElement;
					}
					if (child is UIElement uIElement2 && IsFocusable(uIElement2))
					{
						return uIElement2;
					}
				}
			}
		}
		return null;
	}

	private static DependencyObject uQk(DependencyObject P_0)
	{
		if (IsVisual(P_0))
		{
			DependencyObject parent = VisualTreeHelper.GetParent(P_0);
			if (IsVisual(parent))
			{
				bool flag = false;
				int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
				for (int i = 0; i < childrenCount; i++)
				{
					DependencyObject child = VisualTreeHelper.GetChild(parent, i);
					if (child != null)
					{
						if (child == P_0)
						{
							flag = true;
						}
						else if (flag)
						{
							return child;
						}
					}
				}
			}
		}
		return null;
	}

	private static DependencyObject TQl(DependencyObject P_0)
	{
		DependencyObject parent = default(DependencyObject);
		DependencyObject dependencyObject = default(DependencyObject);
		int childrenCount = default(int);
		int i = default(int);
		int num;
		if (IsVisual(P_0))
		{
			parent = VisualTreeHelper.GetParent(P_0);
			if (IsVisual(parent))
			{
				dependencyObject = null;
				childrenCount = VisualTreeHelper.GetChildrenCount(parent);
				i = 0;
				num = 0;
				if (!P7V())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0009;
			}
		}
		DependencyObject result = null;
		num = 0;
		if (P7V())
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			for (; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(parent, i);
				if (child != null)
				{
					if (child == P_0)
					{
						break;
					}
					dependencyObject = child;
				}
			}
			result = dependencyObject;
			break;
		case 1:
			break;
		}
		return result;
	}

	public static IList<T> GetAllDescendants<T>(DependencyObject source) where T : DependencyObject
	{
		List<T> list = new List<T>();
		dQF(source, list);
		return list;
	}

	public static IList<DependencyObject> GetAllDescendants(DependencyObject source, Type desiredType)
	{
		List<DependencyObject> list = new List<DependencyObject>();
		OQo(source, desiredType, list);
		return (list.Count != 0) ? list : null;
	}

	public static T GetAncestor<T>(DependencyObject source) where T : DependencyObject
	{
		if (IsVisual(source))
		{
			source = VisualTreeHelper.GetParent(source);
			while (IsVisual(source))
			{
				if (typeof(T).IsAssignableFrom(source.GetType()))
				{
					return source as T;
				}
				source = VisualTreeHelper.GetParent(source);
			}
		}
		return null;
	}

	public static DependencyObject GetAncestor(DependencyObject source, Type desiredType)
	{
		DependencyObject result;
		if (!(desiredType == null))
		{
			if (IsVisual(source))
			{
				source = VisualTreeHelper.GetParent(source);
				while (IsVisual(source))
				{
					if (!desiredType.IsAssignableFrom(source.GetType()))
					{
						source = VisualTreeHelper.GetParent(source);
						continue;
					}
					goto IL_00db;
				}
			}
			result = null;
			int num = 0;
			if (!P7V())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			goto IL_0017;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107278));
		IL_00db:
		result = source;
		goto IL_0017;
		IL_0017:
		return result;
	}

	public static DependencyObject GetAncestor(DependencyObject source, params Type[] desiredTypes)
	{
		if (desiredTypes != null && IsVisual(source))
		{
			source = VisualTreeHelper.GetParent(source);
			while (IsVisual(source))
			{
				foreach (Type type in desiredTypes)
				{
					if (type != null && type.IsAssignableFrom(source.GetType()))
					{
						return source;
					}
				}
				source = VisualTreeHelper.GetParent(source);
			}
		}
		return null;
	}

	public static int GetAncestorCount(DependencyObject source, Type desiredType)
	{
		if (desiredType == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107278));
		}
		int num = 0;
		if (IsVisual(source))
		{
			source = VisualTreeHelper.GetParent(source);
			while (IsVisual(source))
			{
				if (desiredType.IsAssignableFrom(source.GetType()))
				{
					num++;
				}
				source = VisualTreeHelper.GetParent(source);
			}
		}
		return num;
	}

	public static Popup GetAncestorPopup(DependencyObject source)
	{
		if (IsVisual(source))
		{
			int num = 0;
			if (w7T() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			source = GetRoot(source);
			if (source != null)
			{
				return LogicalTreeHelper.GetParent(source) as Popup;
			}
		}
		return null;
	}

	public static DependencyObject GetChild(DependencyObject source, Type desiredType)
	{
		if (desiredType == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107278));
		}
		if (source != null)
		{
			int childrenCount = VisualTreeHelper.GetChildrenCount(source);
			for (int i = 0; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(source, i);
				if (child != null && desiredType.IsAssignableFrom(child.GetType()))
				{
					return child;
				}
			}
		}
		return null;
	}

	public static DependencyObject GetCurrentOrAncestor(DependencyObject source, Type desiredType)
	{
		if (desiredType == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107278));
		}
		if (source != null && desiredType.IsAssignableFrom(source.GetType()))
		{
			return source;
		}
		return GetAncestor(source, desiredType);
	}

	public static DependencyObject GetDescendant(DependencyObject source, VisualResultCallback resultCallback)
	{
		return GetDescendant(source, resultCallback, null);
	}

	public static DependencyObject GetDescendant(DependencyObject source, VisualResultCallback resultCallback, VisualDescendantFilterCallback filterCallback)
	{
		if (resultCallback == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107304));
		}
		if (source != null)
		{
			int childrenCount = VisualTreeHelper.GetChildrenCount(source);
			for (int i = 0; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(source, i);
				if (child == null)
				{
					continue;
				}
				VisualDescendantFilterBehavior visualDescendantFilterBehavior = VisualDescendantFilterBehavior.Continue;
				if (filterCallback != null)
				{
					visualDescendantFilterBehavior = filterCallback(child);
				}
				if (VisualDescendantFilterBehavior.Stop == visualDescendantFilterBehavior)
				{
					return child;
				}
				bool flag = true;
				bool flag2 = true;
				switch (visualDescendantFilterBehavior)
				{
				case VisualDescendantFilterBehavior.ContinueSkipChildren:
					flag2 = false;
					break;
				case VisualDescendantFilterBehavior.ContinueSkipSelf:
					flag = false;
					break;
				case VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren:
					flag = false;
					flag2 = false;
					break;
				}
				if (flag && resultCallback(child) == VisualResultBehavior.Stop)
				{
					return child;
				}
				if (flag2)
				{
					child = GetDescendant(child, resultCallback, filterCallback);
					if (child != null)
					{
						return child;
					}
				}
			}
		}
		return null;
	}

	public static DependencyObject GetDescendant(DependencyObject source, Type desiredType, int skipCount)
	{
		return gQQ(source, desiredType, ref skipCount);
	}

	public static T GetDescendant<T>(DependencyObject source, int skipCount) where T : DependencyObject
	{
		return GetDescendant<T>(source, null, skipCount);
	}

	public static T GetDescendant<T>(DependencyObject source, Predicate<T> condition, int skipCount) where T : DependencyObject
	{
		return dQO(source, condition, ref skipCount);
	}

	public static DependencyObject GetFirstChild(DependencyObject source)
	{
		if (source == null || VisualTreeHelper.GetChildrenCount(source) <= 0)
		{
			return null;
		}
		return VisualTreeHelper.GetChild(source, 0);
	}

	public static DependencyObject GetFirstDescendant(DependencyObject source, Type desiredType)
	{
		return GetFirstDescendant(source, desiredType, null);
	}

	public static DependencyObject GetFirstDescendant(DependencyObject source, Type desiredType, VisualDescendantFilterCallback filterCallback)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals2.tUb = desiredType;
		return GetDescendant(source, (DependencyObject obj) => (!CS_0024_003C_003E8__locals2.tUb.IsAssignableFrom(obj.GetType())) ? VisualResultBehavior.Continue : VisualResultBehavior.Stop, filterCallback);
	}

	public static UIElement GetFirstFocusableDescendant(DependencyObject source)
	{
		return GetFirstFocusableDescendant(source, null);
	}

	public static UIElement GetFirstFocusableDescendant(DependencyObject source, VisualDescendantFilterCallback filterCallback)
	{
		if (!IsVisual(source))
		{
			return null;
		}
		return GetDescendant(source, (DependencyObject obj) => (!(obj is UIElement element) || !IsFocusable(element)) ? VisualResultBehavior.Continue : VisualResultBehavior.Stop, filterCallback) as UIElement;
	}

	public static Control GetFirstTabStopDescendant(DependencyObject source)
	{
		Control control = GetDescendant(source, (Control c) => c.IsTabStop, 0);
		if (control != null)
		{
			int num = control.TabIndex;
			DependencyObject parent = VisualTreeHelper.GetParent(control);
			if (parent != null)
			{
				int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
				for (int num2 = 0; num2 < childrenCount; num2++)
				{
					if (VisualTreeHelper.GetChild(parent, num2) is Control { IsTabStop: not false, TabIndex: var tabIndex } control2 && tabIndex < num)
					{
						control = control2;
						num = tabIndex;
					}
				}
			}
		}
		return control;
	}

	public static Panel GetItemsPanel(ItemsControl source)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals4.PUJ = source;
		return GetDescendant(CS_0024_003C_003E8__locals4.PUJ, delegate(DependencyObject obj)
		{
			if (obj is Panel panel)
			{
				if (panel.IsItemsHost && panel.TemplatedParent == CS_0024_003C_003E8__locals4.PUJ)
				{
					return VisualResultBehavior.Stop;
				}
				if (panel.TemplatedParent is ItemsPresenter itemsPresenter && itemsPresenter.TemplatedParent == CS_0024_003C_003E8__locals4.PUJ)
				{
					return VisualResultBehavior.Stop;
				}
			}
			return VisualResultBehavior.Continue;
		}, null) as Panel;
	}

	public static UIElement GetNextFocusable(DependencyObject source, DependencyObject root)
	{
		if (IsVisual(source))
		{
			UIElement firstFocusableDescendant = GetFirstFocusableDescendant(source);
			if (firstFocusableDescendant != null)
			{
				return firstFocusableDescendant;
			}
			firstFocusableDescendant = source as UIElement;
			while (firstFocusableDescendant != null && firstFocusableDescendant != root)
			{
				for (UIElement uIElement = uQk(firstFocusableDescendant) as UIElement; uIElement != null; uIElement = uQk(uIElement) as UIElement)
				{
					if (IsFocusable(uIElement))
					{
						return uIElement;
					}
					UIElement firstFocusableDescendant2 = GetFirstFocusableDescendant(uIElement);
					if (firstFocusableDescendant2 != null)
					{
						return firstFocusableDescendant2;
					}
				}
				firstFocusableDescendant = VisualTreeHelper.GetParent(firstFocusableDescendant) as UIElement;
			}
		}
		return null;
	}

	public static UIElement GetPreviousFocusable(DependencyObject source, DependencyObject root)
	{
		if (IsVisual(source))
		{
			UIElement uIElement = source as UIElement;
			while (uIElement != null && uIElement != root)
			{
				for (UIElement uIElement2 = TQl(uIElement) as UIElement; uIElement2 != null; uIElement2 = TQl(uIElement2) as UIElement)
				{
					UIElement uIElement3 = XQ0(uIElement2);
					if (uIElement3 != null)
					{
						return uIElement3;
					}
					if (IsFocusable(uIElement2))
					{
						return uIElement2;
					}
				}
				uIElement = VisualTreeHelper.GetParent(uIElement) as UIElement;
			}
		}
		return null;
	}

	public static DependencyObject GetRoot(DependencyObject source)
	{
		while (IsVisual(source) && VisualTreeHelper.GetParent(source) != null)
		{
			source = VisualTreeHelper.GetParent(source);
		}
		return source;
	}

	public static bool IsDescendant(DependencyObject possibleAncestor, DependencyObject source)
	{
		DependencyObject dependencyObject = source;
		while (dependencyObject != null)
		{
			if (dependencyObject == possibleAncestor)
			{
				return true;
			}
			DependencyObject parent = VisualTreeHelper.GetParent(dependencyObject);
			if (parent != null)
			{
				dependencyObject = parent;
				continue;
			}
			Popup ancestorPopup = GetAncestorPopup(dependencyObject);
			dependencyObject = ((ancestorPopup == null) ? null : (ancestorPopup.Parent ?? ancestorPopup.PlacementTarget));
		}
		return false;
	}

	public static bool IsFocusable(UIElement element)
	{
		return element != null && element.Focusable && element.IsVisible;
	}

	public static bool IsMouseOver(DependencyObject obj, DragEventArgs e)
	{
		if (e == null)
		{
			int num = 0;
			if (!P7V())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
			}
		}
		if (obj is UIElement { IsVisible: not false } uIElement)
		{
			return new Rect(new Point(0.0, 0.0), uIElement.RenderSize).Contains(e.GetPosition(uIElement));
		}
		return false;
	}

	public static bool IsMouseOver(DependencyObject obj, MouseEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		if (obj is UIElement uIElement)
		{
			int num = 0;
			if (w7T() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (uIElement.IsVisible)
			{
				return new Rect(new Point(0.0, 0.0), uIElement.RenderSize).Contains(e.GetPosition(uIElement));
			}
		}
		return false;
	}

	public static bool IsVisual(DependencyObject obj)
	{
		return obj is Visual || obj is Visual3D;
	}

	internal static bool P7V()
	{
		return W7A == null;
	}

	internal static VisualTreeHelperExtended w7T()
	{
		return W7A;
	}
}
