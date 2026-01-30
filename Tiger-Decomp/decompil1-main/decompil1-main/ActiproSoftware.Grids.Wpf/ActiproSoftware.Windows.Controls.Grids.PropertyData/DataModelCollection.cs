using System.Collections.Generic;
using System.Collections.ObjectModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class DataModelCollection : ObservableCollection<IDataModel>
{
	private static DataModelCollection p6l;

	public IDataModel this[string name]
	{
		get
		{
			using (IEnumerator<IDataModel> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IDataModel current = enumerator.Current;
					if (current != null && current.Name == name)
					{
						return current;
					}
				}
			}
			return null;
		}
	}

	public DataModelCollection()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool j6I()
	{
		return p6l == null;
	}

	internal static DataModelCollection p6Y()
	{
		return p6l;
	}
}
