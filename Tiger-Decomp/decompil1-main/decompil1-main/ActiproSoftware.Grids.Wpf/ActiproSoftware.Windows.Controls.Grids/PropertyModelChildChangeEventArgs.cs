using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyModelChildChangeEventArgs : CancelRoutedEventArgs
{
	private object GPM;

	[CompilerGenerated]
	private IPropertyModel bPe;

	[CompilerGenerated]
	private IPropertyModel gPr;

	internal static PropertyModelChildChangeEventArgs A5;

	public IPropertyModel ChildPropertyModel
	{
		[CompilerGenerated]
		get
		{
			return bPe;
		}
		[CompilerGenerated]
		private set
		{
			bPe = value;
		}
	}

	public object ChildValue
	{
		get
		{
			if (ChildPropertyModel != null)
			{
				return ChildPropertyModel.Value;
			}
			return GPM;
		}
		set
		{
			if (ChildPropertyModel == null)
			{
				GPM = value;
			}
			else
			{
				ChildPropertyModel.Value = value;
			}
		}
	}

	public IPropertyModel ParentPropertyModel
	{
		[CompilerGenerated]
		get
		{
			return gPr;
		}
		[CompilerGenerated]
		private set
		{
			gPr = value;
		}
	}

	public PropertyModelChildChangeEventArgs(IPropertyModel parentPropertyModel, object childValue)
	{
		fc.taYSkz();
		base._002Ector();
		ParentPropertyModel = parentPropertyModel;
		GPM = childValue;
	}

	public PropertyModelChildChangeEventArgs(IPropertyModel parentPropertyModel, IPropertyModel childPropertyModel)
	{
		fc.taYSkz();
		base._002Ector();
		ParentPropertyModel = parentPropertyModel;
		ChildPropertyModel = childPropertyModel;
	}

	internal static bool Ga()
	{
		return A5 == null;
	}

	internal static PropertyModelChildChangeEventArgs ne()
	{
		return A5;
	}
}
