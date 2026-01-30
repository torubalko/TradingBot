using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Internal;

internal class aq : IDataFactoryRequest
{
	private cJ DWw;

	[CompilerGenerated]
	private IList<object> aWX;

	[CompilerGenerated]
	private IDataModel mW2;

	[CompilerGenerated]
	private object dWv;

	internal static aq w6q;

	public bool AreAttachedPropertiesBrowsable => DWw.AreAttachedPropertiesBrowsable;

	public bool AreCategoriesAutoExpanded => DWw.AreCategoriesAutoExpanded;

	public bool AreInheritedPropertiesBrowsable => DWw.AreInheritedPropertiesBrowsable;

	public bool AreNestedCategoriesSupported => DWw.AreNestedCategoriesSupported;

	public bool ArePropertiesAutoExpanded => DWw.ArePropertiesAutoExpanded;

	public bool AreReadOnlyPropertiesBrowsable => DWw.AreReadOnlyPropertiesBrowsable;

	public IEnumerable<Attribute> BrowsableAttributes => DWw.BrowsableAttributes;

	public IEnumerable<CategoryEditor> CategoryEditors => DWw.TWs();

	public CollectionPropertyDisplayMode CollectionPropertyDisplayMode => DWw.CollectionPropertyDisplayMode;

	public IList<object> DataObjects
	{
		[CompilerGenerated]
		get
		{
			return aWX;
		}
		[CompilerGenerated]
		internal set
		{
			aWX = list;
		}
	}

	public bool IsCategorized => DWw.IsCategorized;

	public bool IsHostReadOnly => DWw.IsHostReadOnly;

	public string MiscCategoryName => DWw.MiscCategoryName;

	public IDataModel Parent
	{
		[CompilerGenerated]
		get
		{
			return mW2;
		}
		[CompilerGenerated]
		internal set
		{
			mW2 = dataModel;
		}
	}

	public IEnumerable<IPropertyModel> Properties => DWw.gnP();

	public PropertyExpandability PropertyExpandability => DWw.PropertyExpandability;

	public DataModelSortComparer SortComparer => DWw.SortComparer;

	public object Source => DWw.Source;

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return dWv;
		}
		[CompilerGenerated]
		set
		{
			dWv = obj;
		}
	}

	public aq(cJ P_0)
	{
		fc.taYSkz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(8852));
		}
		DWw = P_0;
	}

	internal static bool L6H()
	{
		return w6q == null;
	}

	internal static aq d6G()
	{
		return w6q;
	}
}
