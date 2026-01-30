using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyModelValueChangeEventArgs : CancelRoutedEventArgs
{
	[CompilerGenerated]
	private IPropertyModel BPO;

	[CompilerGenerated]
	private object bPw;

	internal static PropertyModelValueChangeEventArgs Iv;

	public IPropertyModel PropertyModel
	{
		[CompilerGenerated]
		get
		{
			return BPO;
		}
		[CompilerGenerated]
		private set
		{
			BPO = value;
		}
	}

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return bPw;
		}
		[CompilerGenerated]
		private set
		{
			bPw = value;
		}
	}

	public PropertyModelValueChangeEventArgs(IPropertyModel propertyModel, object value)
	{
		fc.taYSkz();
		base._002Ector();
		if (propertyModel == null)
		{
			throw new ArgumentNullException(xv.hTz(3262));
		}
		PropertyModel = propertyModel;
		Value = value;
	}

	internal static bool An()
	{
		return Iv == null;
	}

	internal static PropertyModelValueChangeEventArgs ww()
	{
		return Iv;
	}
}
