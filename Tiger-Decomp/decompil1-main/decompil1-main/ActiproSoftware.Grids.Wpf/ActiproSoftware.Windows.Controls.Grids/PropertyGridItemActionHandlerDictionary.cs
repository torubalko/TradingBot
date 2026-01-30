using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

[SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
public class PropertyGridItemActionHandlerDictionary : Dictionary<Type, PropertyGridItemActionHandler>
{
	internal static PropertyGridItemActionHandlerDictionary Oq;

	private bool iPt(PropertyGridItemActionRequest P_0)
	{
		if (P_0 != null)
		{
			if (P_0.Element is ComboBox { IsEnabled: not false, IsEditable: not false } comboBox)
			{
				if (comboBox.IsReadOnly)
				{
					return false;
				}
				BindingExpression bindingExpression = comboBox.GetBindingExpression(ComboBox.TextProperty);
				if (bindingExpression != null)
				{
					int num = 0;
					if (!QH())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					default:
						bindingExpression.UpdateTarget();
						return true;
					}
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private bool kPU(PropertyGridItemActionRequest P_0)
	{
		if (P_0 != null)
		{
			if (P_0.Element is TextBox { IsEnabled: not false, IsReadOnly: false } textBox)
			{
				BindingExpression bindingExpression = textBox.GetBindingExpression(TextBox.TextProperty);
				if (bindingExpression != null)
				{
					bindingExpression.UpdateTarget();
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private bool yP6(PropertyGridItemActionRequest P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (!(P_0.Element is ComboBox { IsEnabled: not false, IsEditable: not false } comboBox))
		{
			return false;
		}
		if (comboBox.IsReadOnly)
		{
			return false;
		}
		BindingExpression bindingExpression = comboBox.GetBindingExpression(ComboBox.TextProperty);
		int num = 0;
		if (!QH())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (bindingExpression != null)
			{
				bindingExpression.UpdateSource();
				return true;
			}
			return false;
		}
	}

	private bool iPq(PropertyGridItemActionRequest P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_0.Element is TextBox { IsEnabled: not false, IsReadOnly: false } textBox)
		{
			BindingExpression bindingExpression = textBox.GetBindingExpression(TextBox.TextProperty);
			if (bindingExpression != null)
			{
				bindingExpression.UpdateSource();
				return true;
			}
			return false;
		}
		return false;
	}

	private bool aPJ(PropertyGridItemActionRequest P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_0.Element is TextBox textBox && textBox.Focus())
		{
			textBox.SelectAll();
			return true;
		}
		return false;
	}

	private bool KP5(PropertyGridItemActionRequest P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_0.Element is ToggleButton toggleButton && toggleButton.Focus())
		{
			if (P_0.Text == xv.hTz(3106))
			{
				if (toggleButton.IsChecked != true)
				{
					toggleButton.IsChecked = toggleButton.IsChecked.HasValue;
				}
				else
				{
					toggleButton.IsChecked = (toggleButton.IsThreeState ? ((bool?)null) : new bool?(false));
				}
			}
			return true;
		}
		return false;
	}

	private bool gPW(PropertyGridItemActionRequest P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_0.Element is Control control)
		{
			return control.Focus();
		}
		return false;
	}

	internal static PropertyGridItemActionHandlerDictionary RPn()
	{
		PropertyGridItemActionHandlerDictionary propertyGridItemActionHandlerDictionary = new PropertyGridItemActionHandlerDictionary();
		propertyGridItemActionHandlerDictionary[typeof(ComboBox)] = propertyGridItemActionHandlerDictionary.iPt;
		propertyGridItemActionHandlerDictionary[typeof(TextBox)] = propertyGridItemActionHandlerDictionary.kPU;
		return propertyGridItemActionHandlerDictionary;
	}

	internal static PropertyGridItemActionHandlerDictionary XPp()
	{
		PropertyGridItemActionHandlerDictionary propertyGridItemActionHandlerDictionary = new PropertyGridItemActionHandlerDictionary();
		propertyGridItemActionHandlerDictionary[typeof(ComboBox)] = propertyGridItemActionHandlerDictionary.yP6;
		propertyGridItemActionHandlerDictionary[typeof(TextBox)] = propertyGridItemActionHandlerDictionary.iPq;
		return propertyGridItemActionHandlerDictionary;
	}

	internal static PropertyGridItemActionHandlerDictionary wPE()
	{
		PropertyGridItemActionHandlerDictionary propertyGridItemActionHandlerDictionary = new PropertyGridItemActionHandlerDictionary();
		propertyGridItemActionHandlerDictionary[typeof(TextBox)] = propertyGridItemActionHandlerDictionary.aPJ;
		propertyGridItemActionHandlerDictionary[typeof(ToggleButton)] = propertyGridItemActionHandlerDictionary.KP5;
		propertyGridItemActionHandlerDictionary[typeof(UIElement)] = propertyGridItemActionHandlerDictionary.gPW;
		return propertyGridItemActionHandlerDictionary;
	}

	internal PropertyGridItemActionHandler QPC(Type P_0)
	{
		PropertyGridItemActionHandler value = null;
		while (true)
		{
			if (P_0 != null)
			{
				if (TryGetValue(P_0, out value))
				{
					break;
				}
				P_0 = P_0.BaseType;
				continue;
			}
			return null;
		}
		return value;
	}

	public PropertyGridItemActionHandlerDictionary()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool QH()
	{
		return Oq == null;
	}

	internal static PropertyGridItemActionHandlerDictionary tG()
	{
		return Oq;
	}
}
