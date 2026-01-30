using System;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class CategoryEditorProperty : ObservableObjectBase
{
	private Type KJF;

	private string rJc;

	private Type PJV;

	internal static CategoryEditorProperty bC6;

	public Type ObjectType
	{
		get
		{
			return KJF;
		}
		set
		{
			if (KJF != value)
			{
				KJF = value;
				NotifyPropertyChanged(xv.hTz(7850));
			}
		}
	}

	public string PropertyName
	{
		get
		{
			return rJc;
		}
		set
		{
			if (rJc != value)
			{
				rJc = value;
				NotifyPropertyChanged(xv.hTz(7874));
			}
		}
	}

	public Type PropertyType
	{
		get
		{
			return PJV;
		}
		set
		{
			if (PJV != value)
			{
				PJV = value;
				NotifyPropertyChanged(xv.hTz(7902));
			}
		}
	}

	public CategoryEditorProperty()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool KCF()
	{
		return bC6 == null;
	}

	internal static CategoryEditorProperty cCs()
	{
		return bC6;
	}
}
