using System.Collections.Generic;
using System.Collections.ObjectModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class PropertyModelCollection : ObservableCollection<IPropertyModel>
{
	private static PropertyModelCollection sFI;

	public IPropertyModel this[string name]
	{
		get
		{
			using (IEnumerator<IPropertyModel> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IPropertyModel current = enumerator.Current;
					if (current != null && current.Name == name)
					{
						return current;
					}
				}
			}
			return null;
		}
	}

	public PropertyModelCollection()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool QFY()
	{
		return sFI == null;
	}

	internal static PropertyModelCollection TFM()
	{
		return sFI;
	}
}
