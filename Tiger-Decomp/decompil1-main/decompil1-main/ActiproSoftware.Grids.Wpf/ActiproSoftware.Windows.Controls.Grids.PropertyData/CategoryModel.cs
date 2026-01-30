using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

[SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
public class CategoryModel : DataModelBase, ICategoryModel, IDataModel, IDisposable
{
	private string mWU;

	private string HW6;

	private string dWq;

	private int HWJ;

	internal static CategoryModel d6R;

	public string Description
	{
		get
		{
			return mWU ?? xv.hTz(3106);
		}
		set
		{
			if (!(mWU == value))
			{
				mWU = value;
				NotifyPropertyChanged(xv.hTz(7728));
			}
		}
	}

	protected sealed override string DescriptionResolved => Description;

	public string DisplayName
	{
		get
		{
			return HW6;
		}
		set
		{
			if (!(HW6 == value))
			{
				HW6 = value;
				NotifyPropertyChanged(xv.hTz(7754));
			}
		}
	}

	protected sealed override string DisplayNameResolved => DisplayName;

	protected sealed override bool IsModifiedResolved => false;

	public string Name
	{
		get
		{
			return dWq;
		}
		set
		{
			if (!(dWq == value))
			{
				if (!string.IsNullOrEmpty(value))
				{
					dWq = value;
				}
				NotifyPropertyChanged(xv.hTz(8404));
			}
		}
	}

	protected sealed override string NameResolved => Name;

	protected override DataModelSortImportance SortImportanceResolved => DataModelSortImportance.Category;

	public int SortOrder
	{
		get
		{
			return HWJ;
		}
		set
		{
			if (HWJ != value)
			{
				HWJ = value;
				NotifyPropertyChanged(xv.hTz(8514));
			}
		}
	}

	protected sealed override int SortOrderResolved => SortOrder;

	public CategoryModel(string name)
	{
		fc.taYSkz();
		base._002Ector();
		dWq = name;
		HW6 = name;
	}

	internal static bool v6X()
	{
		return d6R == null;
	}

	internal static CategoryModel P69()
	{
		return d6R;
	}
}
