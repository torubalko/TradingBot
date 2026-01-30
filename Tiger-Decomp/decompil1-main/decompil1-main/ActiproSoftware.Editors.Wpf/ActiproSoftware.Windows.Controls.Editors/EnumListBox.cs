using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors;

public class EnumListBox : ListBox
{
	private List<Enum> es9;

	private bool Is5;

	private bool dsc;

	public static readonly DependencyProperty EnumSortComparerProperty;

	public static readonly DependencyProperty EnumTypeProperty;

	public static readonly DependencyProperty EnumValueProperty;

	private static readonly DependencyProperty CsH;

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	public static readonly DependencyProperty IsFlagsEnumProperty;

	public static readonly DependencyProperty IsOnPopupProperty;

	public static readonly DependencyProperty UseDisplayAttributesProperty;

	internal static EnumListBox pBo;

	private object IntermediateEnumValue
	{
		get
		{
			return GetValue(CsH);
		}
		set
		{
			SetValue(CsH, value);
		}
	}

	public IComparer<Enum> EnumSortComparer
	{
		get
		{
			return (IComparer<Enum>)GetValue(EnumSortComparerProperty);
		}
		set
		{
			SetValue(EnumSortComparerProperty, value);
		}
	}

	public Type EnumType
	{
		get
		{
			return GetValue(EnumTypeProperty) as Type;
		}
		set
		{
			SetValue(EnumTypeProperty, value);
		}
	}

	public object EnumValue
	{
		get
		{
			return GetValue(EnumValueProperty);
		}
		set
		{
			SetValue(EnumValueProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	public bool IsFlagsEnum
	{
		get
		{
			return (bool)GetValue(IsFlagsEnumProperty);
		}
		private set
		{
			SetValue(IsFlagsEnumProperty, value);
		}
	}

	public bool IsOnPopup
	{
		get
		{
			return (bool)GetValue(IsOnPopupProperty);
		}
		set
		{
			SetValue(IsOnPopupProperty, value);
		}
	}

	public bool UseDisplayAttributes
	{
		get
		{
			return (bool)GetValue(UseDisplayAttributesProperty);
		}
		set
		{
			SetValue(UseDisplayAttributesProperty, value);
		}
	}

	public EnumListBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EnumListBox);
		base.SelectionChanged += gs0;
		base.Unloaded += msY;
	}

	private void Xss()
	{
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	private static bool? Bsj(long P_0, object P_1)
	{
		long num = Convert.ToInt64(P_1, CultureInfo.InvariantCulture);
		if ((P_0 != 0L && num != 0L && (P_0 & num) == num) || (P_0 == 0L && num == 0))
		{
			return true;
		}
		if (P_0 != 0L && num != 0L && (P_0 & num) != 0)
		{
			return null;
		}
		return false;
	}

	private long tsP()
	{
		long result = 0L;
		if (IntermediateEnumValue is Enum)
		{
			result = Convert.ToInt64(IntermediateEnumValue, CultureInfo.InvariantCulture);
		}
		return result;
	}

	private static bool ls2(object P_0)
	{
		if (P_0 is Enum obj)
		{
			Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
			if (underlyingType != null)
			{
				if (underlyingType == typeof(ulong))
				{
					return 0uL.Equals((ulong)P_0);
				}
				if (underlyingType == typeof(long))
				{
					return 0L.Equals((long)P_0);
				}
				return 0.Equals((int)P_0);
			}
		}
		return false;
	}

	private static void Usa(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumListBox enumListBox = (EnumListBox)P_0;
		enumListBox.asb(enumListBox.DsK());
	}

	private static void Vsf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumListBox enumListBox = (EnumListBox)P_0;
		enumListBox.Ksg(P_1.NewValue as Type);
	}

	private static void Xsl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		EnumListBox enumListBox = default(EnumListBox);
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
					if (!(enumListBox.EnumType == null) || P_1.OldValue != null || P_1.NewValue == null)
					{
						enumListBox.IsFlagsEnum = Vdx.JDc(enumListBox.DsK());
						enumListBox.bsG();
					}
					else
					{
						enumListBox.Ksg(P_1.NewValue.GetType());
					}
					enumListBox.QsT(_0020: false);
					return;
				}
				enumListBox = (EnumListBox)P_0;
				num2 = 0;
			}
			while (QBl() == null);
		}
	}

	private static void WsX(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumListBox enumListBox = (EnumListBox)P_0;
		enumListBox.GsD(null);
		if (!enumListBox.IsOnPopup)
		{
			enumListBox.QsT(_0020: true);
		}
	}

	private static void rsx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumListBox enumListBox = (EnumListBox)P_0;
		enumListBox.asb(enumListBox.DsK());
	}

	private void gs0(object P_0, SelectionChangedEventArgs P_1)
	{
		List<object> list = P_1.AddedItems.OfType<object>().ToList();
		List<object> list2 = P_1.RemovedItems.OfType<object>().ToList();
		esI(list, list2);
		List<object> list3 = new List<object>(list.Union(list2));
		if (IsFlagsEnum && ls2(IntermediateEnumValue))
		{
			for (int num = list3.Count - 1; num >= 0; num--)
			{
				if (ls2(list3[num]) && P_1.RemovedItems.Contains(list3[num]))
				{
					list3.RemoveAt(num);
				}
			}
		}
		GsD(list3);
	}

	private void msY(object P_0, RoutedEventArgs P_1)
	{
		if (IsOnPopup)
		{
			QsT(_0020: false);
		}
	}

	private void Ksg(Type P_0)
	{
		Type type = Vdx.PDG(P_0, EnumValue);
		base.SelectedItem = null;
		IsFlagsEnum = Vdx.JDc(type);
		bsG();
		asb(type);
	}

	internal void Aso()
	{
		if (IsOnPopup)
		{
			QsT(_0020: true);
			if (!IsFlagsEnum)
			{
				Xss();
			}
		}
	}

	[SpecialName]
	private Type DsK()
	{
		return Vdx.PDG(EnumType, EnumValue);
	}

	private void NsO(IList<object> P_0, IEnumerable<object> P_1)
	{
		if (P_0 == null || P_0.Count == 0)
		{
			if (base.SelectedItem != null)
			{
				base.SelectedItem = null;
			}
		}
		else if (!IsFlagsEnum && P_0.Count == 1)
		{
			if (base.SelectedItem != P_0[0])
			{
				base.SelectedItem = P_0[0];
			}
		}
		else
		{
			if (!IsFlagsEnum)
			{
				return;
			}
			object[] array = base.Items.OfType<object>().ToArray();
			object[] array2 = array;
			foreach (object obj in array2)
			{
				bool flag = P_1?.Contains(obj) ?? false;
				if (base.ItemContainerGenerator.ContainerFromItem(obj) is EnumListBoxItem enumListBoxItem)
				{
					if (flag)
					{
						enumListBoxItem.msA();
					}
					else if (enumListBoxItem.IsSelected != P_0.Contains(obj))
					{
						enumListBoxItem.IsSelected = !enumListBoxItem.IsSelected;
						enumListBoxItem.msA();
					}
				}
			}
		}
	}

	private void QsT(bool P_0)
	{
		if (dsc)
		{
			return;
		}
		dsc = true;
		try
		{
			if (P_0)
			{
				if (EnumValue != IntermediateEnumValue)
				{
					EnumValue = IntermediateEnumValue;
				}
			}
			else if (IntermediateEnumValue != EnumValue)
			{
				IntermediateEnumValue = EnumValue;
			}
		}
		finally
		{
			dsc = false;
		}
	}

	private void esI(IList<object> P_0, IList<object> P_1)
	{
		if (Is5)
		{
			return;
		}
		Is5 = true;
		try
		{
			Type type = DsK();
			if (type != null)
			{
				object value = null;
				if (base.SelectionMode != SelectionMode.Single)
				{
					Type underlyingType = Enum.GetUnderlyingType(type);
					long num = 0L;
					if (P_0 == null || P_0.Count != 1 || Convert.ToInt64(P_0[0], CultureInfo.InvariantCulture) != 0)
					{
						foreach (object selectedItem in base.SelectedItems)
						{
							num |= Convert.ToInt64(selectedItem, CultureInfo.InvariantCulture);
						}
						if (P_1 != null && P_1.Count != 0)
						{
							foreach (object item in P_1)
							{
								num &= ~Convert.ToInt64(item, CultureInfo.InvariantCulture);
							}
						}
					}
					value = Enum.ToObject(type, Convert.ChangeType(num, underlyingType, CultureInfo.InvariantCulture));
				}
				else if (base.SelectedItem != null)
				{
					value = base.SelectedItem;
				}
				IntermediateEnumValue = value;
			}
			else
			{
				IntermediateEnumValue = null;
			}
		}
		finally
		{
			Is5 = false;
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void asb(Type P_0)
	{
		Is5 = true;
		try
		{
			es9 = null;
			if (P_0 != null)
			{
				Array array = Vdx.BDK(P_0);
				IComparer<Enum> enumSortComparer = EnumSortComparer;
				if (IsFlagsEnum)
				{
					es9 = new List<Enum>();
					List<Enum> list = new List<Enum>();
					foreach (object item in array)
					{
						if (Convert.ToInt64(item, CultureInfo.InvariantCulture) == 0)
						{
							list.Add((Enum)item);
						}
					}
					List<Enum> list2 = new List<Enum>();
					foreach (object item2 in array)
					{
						long num = Convert.ToInt64(item2, CultureInfo.InvariantCulture);
						if (num != 0L && (num & (num - 1)) != 0)
						{
							list2.Add((Enum)item2);
						}
					}
					List<Enum> list3 = new List<Enum>();
					foreach (object item3 in array)
					{
						long num2 = Convert.ToInt64(item3, CultureInfo.InvariantCulture);
						if (num2 != 0L && (num2 & (num2 - 1)) == 0)
						{
							list3.Add((Enum)item3);
						}
					}
					if (enumSortComparer != null)
					{
						list.Sort(enumSortComparer);
						list2.Sort(enumSortComparer);
						list3.Sort(enumSortComparer);
					}
					if (list3.Count > 0 && list.Count + list2.Count > 0)
					{
						es9.Add(list3[0]);
					}
					List<object> list4 = new List<object>(list.Count + list2.Count + list3.Count + 2);
					if (list.Count > 0)
					{
						foreach (Enum item4 in list)
						{
							list4.Add(item4);
						}
					}
					if (list2.Count > 0)
					{
						if (list4.Count > 0)
						{
							es9.Add(list2[0]);
						}
						foreach (Enum item5 in list2)
						{
							list4.Add(item5);
						}
					}
					if (list3.Count > 0)
					{
						if (list4.Count > 0)
						{
							es9.Add(list3[0]);
						}
						foreach (Enum item6 in list3)
						{
							list4.Add(item6);
						}
					}
					array = list4.ToArray();
				}
				else if (enumSortComparer != null)
				{
					List<Enum> list5 = new List<Enum>(array.Length);
					foreach (object item7 in array)
					{
						list5.Add((Enum)item7);
					}
					list5.Sort(enumSortComparer);
					array = list5.ToArray();
				}
				SetBinding(ItemsControl.ItemsSourceProperty, new Binding
				{
					Source = array
				});
				if (!IsFlagsEnum && IntermediateEnumValue != null && Array.IndexOf(array, IntermediateEnumValue) != -1)
				{
					base.SelectedItem = IntermediateEnumValue;
				}
			}
			else
			{
				ClearValue(ItemsControl.ItemsSourceProperty);
			}
		}
		finally
		{
			Is5 = false;
		}
	}

	private void GsD(IEnumerable<object> P_0)
	{
		if (Is5)
		{
			return;
		}
		Is5 = true;
		try
		{
			List<object> list = null;
			List<object> list2 = null;
			Type type = DsK();
			if (type != null)
			{
				if (base.SelectionMode != SelectionMode.Single)
				{
					list = new List<object>();
					list2 = new List<object>();
					long num = tsP();
					foreach (object item in Vdx.BDK(type))
					{
						bool? flag = Bsj(num, item);
						bool? flag2 = flag;
						if (flag2.HasValue)
						{
							if (flag2 == true)
							{
								list.Add(item);
							}
						}
						else
						{
							list2.Add(item);
						}
					}
				}
				else if (IntermediateEnumValue != null && Enum.IsDefined(type, IntermediateEnumValue))
				{
					list = new List<object>();
					list.Add(IntermediateEnumValue);
				}
			}
			NsO(list, P_0);
			if (!IsFlagsEnum)
			{
				return;
			}
			foreach (object item2 in (IEnumerable)base.Items)
			{
				if (base.ItemContainerGenerator.ContainerFromItem(item2) is EnumListBoxItem enumListBoxItem)
				{
					enumListBoxItem.IsPartiallySelected = list2?.Contains(item2) ?? false;
				}
			}
		}
		finally
		{
			Is5 = false;
		}
	}

	private void bsG()
	{
		SelectionMode selectionMode = (IsFlagsEnum ? SelectionMode.Multiple : SelectionMode.Single);
		if (base.SelectionMode != selectionMode)
		{
			base.SelectionMode = selectionMode;
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new EnumListBoxItem(IsFlagsEnum);
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is ListBoxItem;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (IsOnPopup && e != null)
		{
			switch (e.Key)
			{
			case Key.Escape:
				QsT(_0020: false);
				break;
			case Key.Return:
				QsT(_0020: true);
				Xss();
				break;
			}
		}
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (!(item is Enum obj) || !(element is ListBoxItem listBoxItem))
		{
			return;
		}
		if (UseDisplayAttributes)
		{
			Type type = DsK();
			if (type != null)
			{
				string text = Vdx.vD9(type, obj);
				if (!string.IsNullOrEmpty(text))
				{
					listBoxItem.Content = text;
				}
			}
		}
		if (!IsFlagsEnum || !(listBoxItem is EnumListBoxItem enumListBoxItem))
		{
			return;
		}
		long num = tsP();
		bool? flag = Bsj(num, obj);
		bool? flag2 = flag;
		if (flag2.HasValue)
		{
			if (flag2 == true)
			{
				Is5 = true;
				try
				{
					enumListBoxItem.IsSelected = true;
				}
				finally
				{
					Is5 = false;
				}
			}
		}
		else
		{
			enumListBoxItem.IsPartiallySelected = true;
		}
		if (es9 != null && es9.Contains(obj))
		{
			enumListBoxItem.IsGroupStart = true;
		}
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnGotKeyboardFocus(e);
		if (!IsOnPopup || base.SelectionMode != SelectionMode.Single || base.SelectedItem == null)
		{
			return;
		}
		int num = 0;
		if (!hB2())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (e != null && base.SelectedItem != e.NewFocus && base.ItemContainerGenerator.ContainerFromItem(base.SelectedItem) is EnumListBoxItem enumListBoxItem)
		{
			enumListBoxItem.Focus();
		}
	}

	static EnumListBox()
	{
		awj.QuEwGz();
		EnumSortComparerProperty = DependencyProperty.Register(QdM.AR8(19226), typeof(IComparer<Enum>), typeof(EnumListBox), new FrameworkPropertyMetadata(null, Usa));
		EnumTypeProperty = DependencyProperty.Register(QdM.AR8(19262), typeof(Type), typeof(EnumListBox), new FrameworkPropertyMetadata(null, Vsf));
		EnumValueProperty = DependencyProperty.Register(QdM.AR8(19326), typeof(object), typeof(EnumListBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, Xsl));
		CsH = DependencyProperty.Register(QdM.AR8(19348), typeof(object), typeof(EnumListBox), new FrameworkPropertyMetadata(null, WsX));
		IsFlagsEnumProperty = DependencyProperty.Register(QdM.AR8(19394), typeof(bool), typeof(EnumListBox), new FrameworkPropertyMetadata(false));
		IsOnPopupProperty = DependencyProperty.Register(QdM.AR8(19420), typeof(bool), typeof(EnumListBox), new PropertyMetadata(false));
		UseDisplayAttributesProperty = DependencyProperty.Register(QdM.AR8(19282), typeof(bool), typeof(EnumListBox), new FrameworkPropertyMetadata(false, rsx));
	}

	internal static bool hB2()
	{
		return pBo == null;
	}

	internal static EnumListBox QBl()
	{
		return pBo;
	}
}
