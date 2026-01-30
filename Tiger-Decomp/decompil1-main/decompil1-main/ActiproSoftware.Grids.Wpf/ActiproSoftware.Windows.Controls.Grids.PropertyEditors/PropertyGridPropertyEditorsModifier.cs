using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

[ContentProperty("PropertyEditors")]
public class PropertyGridPropertyEditorsModifier : DependencyObject, IPropertyEditorsProvider
{
	private PropertyEditorCollection O5T;

	public static readonly DependencyProperty ClearProperty;

	internal static PropertyGridPropertyEditorsModifier YCp;

	public bool Clear
	{
		get
		{
			return (bool)GetValue(ClearProperty);
		}
		set
		{
			SetValue(ClearProperty, value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public PropertyEditorCollection PropertyEditors => O5T;

	public PropertyGridPropertyEditorsModifier()
	{
		fc.taYSkz();
		base._002Ector();
		O5T = new PropertyEditorCollection();
		O5T.CollectionChanged += d5m;
	}

	private static void k5g(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_ = (PropertyGridPropertyEditorsModifier)P_0;
		if (true.Equals(P_1.NewValue))
		{
			PropertyGrid.DefaultPropertyEditors.Clear();
		}
	}

	private void d5m(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1 == null || P_1.Action != NotifyCollectionChangedAction.Add || P_1.NewItems == null)
		{
			return;
		}
		PropertyEditorCollection defaultPropertyEditors = PropertyGrid.DefaultPropertyEditors;
		foreach (PropertyEditor newItem in P_1.NewItems)
		{
			if (!defaultPropertyEditors.Contains(newItem))
			{
				defaultPropertyEditors.Add(newItem);
			}
		}
	}

	static PropertyGridPropertyEditorsModifier()
	{
		fc.taYSkz();
		ClearProperty = DependencyProperty.Register(xv.hTz(8088), typeof(bool), typeof(PropertyGridPropertyEditorsModifier), new PropertyMetadata(false, k5g));
	}

	internal static bool hCr()
	{
		return YCp == null;
	}

	internal static PropertyGridPropertyEditorsModifier UCd()
	{
		return YCp;
	}
}
