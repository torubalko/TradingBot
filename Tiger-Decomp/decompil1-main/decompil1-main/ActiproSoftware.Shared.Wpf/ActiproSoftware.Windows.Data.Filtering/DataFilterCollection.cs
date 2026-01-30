using System.Collections.ObjectModel;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

public class DataFilterCollection : ObservableCollection<IDataFilter>
{
	internal static DataFilterCollection dOi;

	protected override void ClearItems()
	{
		for (int num = base.Count - 1; num >= 0; num--)
		{
			RemoveAt(num);
		}
	}

	public DataFilterCollection()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool mOp()
	{
		return dOi == null;
	}

	internal static DataFilterCollection COh()
	{
		return dOi;
	}
}
