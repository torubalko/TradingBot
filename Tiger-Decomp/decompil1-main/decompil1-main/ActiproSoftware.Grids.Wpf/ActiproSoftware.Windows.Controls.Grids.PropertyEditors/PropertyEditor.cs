using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class PropertyEditor : ObservableObjectBase
{
	private bool? j51;

	private bool? v5t;

	private DataTemplate B5U;

	private object K56;

	private DataTemplateSelector L5q;

	private Type p5J;

	private string f55;

	private Type c5W;

	private DataTemplate y5n;

	private object r5p;

	private DefaultValueTemplateKind k5E;

	private DataTemplateSelector W5C;

	internal static PropertyEditor DCe;

	public virtual DataTemplate NameTemplate
	{
		get
		{
			return B5U;
		}
		set
		{
			if (B5U != value)
			{
				B5U = value;
				LJA();
				NotifyPropertyChanged(xv.hTz(1154));
			}
		}
	}

	public virtual object NameTemplateKey
	{
		get
		{
			return K56;
		}
		set
		{
			if (K56 != value)
			{
				K56 = value;
				LJA();
				NotifyPropertyChanged(xv.hTz(7980));
			}
		}
	}

	public virtual DataTemplateSelector NameTemplateSelector
	{
		get
		{
			return L5q;
		}
		set
		{
			if (L5q != value)
			{
				L5q = value;
				LJA();
				NotifyPropertyChanged(xv.hTz(1182));
			}
		}
	}

	public Type ObjectType
	{
		get
		{
			return p5J;
		}
		set
		{
			if (p5J != value)
			{
				p5J = value;
				NotifyPropertyChanged(xv.hTz(7850));
			}
		}
	}

	public string PropertyName
	{
		get
		{
			return f55;
		}
		set
		{
			if (f55 != value)
			{
				f55 = value;
				NotifyPropertyChanged(xv.hTz(7874));
			}
		}
	}

	public Type PropertyType
	{
		get
		{
			return c5W;
		}
		set
		{
			if (c5W != value)
			{
				c5W = value;
				NotifyPropertyChanged(xv.hTz(7902));
			}
		}
	}

	public virtual DataTemplate ValueTemplate
	{
		get
		{
			return y5n;
		}
		set
		{
			if (y5n != value)
			{
				y5n = value;
				NJ4();
				NotifyPropertyChanged(xv.hTz(1456));
			}
		}
	}

	public virtual object ValueTemplateKey
	{
		get
		{
			return r5p;
		}
		set
		{
			if (r5p != value)
			{
				r5p = value;
				NJ4();
				NotifyPropertyChanged(xv.hTz(8014));
			}
		}
	}

	public virtual DefaultValueTemplateKind ValueTemplateKind
	{
		get
		{
			return k5E;
		}
		set
		{
			if (k5E != value)
			{
				k5E = value;
				NJ4();
				NotifyPropertyChanged(xv.hTz(8050));
			}
		}
	}

	public virtual DataTemplateSelector ValueTemplateSelector
	{
		get
		{
			return W5C;
		}
		set
		{
			if (W5C != value)
			{
				W5C = value;
				NJ4();
				NotifyPropertyChanged(xv.hTz(1486));
			}
		}
	}

	[SpecialName]
	internal bool RJS()
	{
		if (!j51.HasValue)
		{
			LJA();
		}
		return j51.Value;
	}

	[SpecialName]
	internal bool p5I()
	{
		if (!v5t.HasValue)
		{
			NJ4();
		}
		return v5t.Value;
	}

	private void LJA()
	{
		j51 = NameTemplate != null || NameTemplateSelector != null || NameTemplateKey != null;
	}

	private void NJ4()
	{
		v5t = ValueTemplateKind != DefaultValueTemplateKind.None || ValueTemplate != null || ValueTemplateSelector != null || ValueTemplateKey != null;
	}

	protected internal virtual bool? GetIsReadOnly(IPropertyModel propertyModel)
	{
		return null;
	}

	public PropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool RCv()
	{
		return DCe == null;
	}

	internal static PropertyEditor RCn()
	{
		return DCe;
	}
}
