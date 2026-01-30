using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class PropertyEditorCollection : ObservableCollection<PropertyEditor>
{
	private static PropertyEditorCollection hCw;

	private Tuple<PropertyEditor, int> w5K(IPropertyModel P_0)
	{
		int num = int.MaxValue;
		PropertyEditor item = null;
		if (P_0 != null)
		{
			for (int num2 = base.Count - 1; num2 >= 0; num2--)
			{
				PropertyEditor propertyEditor = base[num2];
				if (propertyEditor != null && propertyEditor.RJS())
				{
					int num3 = IU.q5y(propertyEditor, P_0);
					if (num3 < num)
					{
						item = propertyEditor;
						num = num3;
					}
				}
			}
		}
		return Tuple.Create(item, num);
	}

	private Tuple<PropertyEditor, int> B5N(IPropertyModel P_0)
	{
		int num = int.MaxValue;
		PropertyEditor item = null;
		if (P_0 != null)
		{
			for (int num2 = base.Count - 1; num2 >= 0; num2--)
			{
				PropertyEditor propertyEditor = base[num2];
				if (propertyEditor != null && propertyEditor.p5I())
				{
					int num3 = IU.q5y(propertyEditor, P_0);
					if (num3 < num)
					{
						item = propertyEditor;
						num = num3;
					}
				}
			}
		}
		return Tuple.Create(item, num);
	}

	internal void G5l()
	{
		Add(new StringPropertyEditor
		{
			PropertyType = typeof(Array)
		});
		Add(new StringPropertyEditor
		{
			PropertyType = typeof(ICollection)
		});
		Add(new StringPropertyEditor
		{
			PropertyType = typeof(ICollection<>)
		});
		Add(new FontFamilyPropertyEditor
		{
			PropertyType = typeof(FontFamily)
		});
		Add(new FontStretchPropertyEditor
		{
			PropertyType = typeof(FontStretch)
		});
		Add(new FontStylePropertyEditor
		{
			PropertyType = typeof(FontStyle)
		});
		Add(new FontWeightPropertyEditor
		{
			PropertyType = typeof(FontWeight)
		});
		Add(new ColorPropertyEditor
		{
			PropertyType = typeof(Color)
		});
		Add(new BrushPropertyEditor
		{
			PropertyType = typeof(Brush)
		});
		Add(new LimitedStringPropertyEditor
		{
			PropertyType = typeof(Enum)
		});
		int num = 0;
		if (hCV() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Add(new NullableBooleanPropertyEditor
		{
			PropertyType = typeof(bool?)
		});
		Add(new BooleanPropertyEditor
		{
			PropertyType = typeof(bool)
		});
	}

	public PropertyEditor GetNameEditor(IPropertyModel propertyModel)
	{
		Tuple<PropertyEditor, int> tuple = PropertyGrid.DefaultPropertyEditors.w5K(propertyModel);
		PropertyEditor item = tuple.Item1;
		Tuple<PropertyEditor, int> tuple2 = w5K(propertyModel);
		PropertyEditor item2 = tuple2.Item1;
		if (item != null)
		{
			if (item2 != null)
			{
				int item3 = tuple.Item2;
				if (tuple2.Item2 > item3)
				{
					return item;
				}
				return item2;
			}
			return item;
		}
		return item2;
	}

	public PropertyEditor GetValueEditor(IPropertyModel propertyModel)
	{
		Tuple<PropertyEditor, int> tuple = PropertyGrid.DefaultPropertyEditors.B5N(propertyModel);
		PropertyEditor item = tuple.Item1;
		Tuple<PropertyEditor, int> tuple2 = B5N(propertyModel);
		PropertyEditor item2 = tuple2.Item1;
		if (item != null)
		{
			if (item2 != null)
			{
				int item3 = tuple.Item2;
				if (tuple2.Item2 > item3)
				{
					return item;
				}
				return item2;
			}
			return item;
		}
		return item2;
	}

	public PropertyEditorCollection()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool RC2()
	{
		return hCw == null;
	}

	internal static PropertyEditorCollection hCV()
	{
		return hCw;
	}
}
