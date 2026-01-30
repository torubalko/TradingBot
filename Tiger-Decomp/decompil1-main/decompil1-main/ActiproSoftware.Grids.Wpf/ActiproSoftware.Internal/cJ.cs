using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Internal;

internal class cJ
{
	[CompilerGenerated]
	private bool gnn;

	[CompilerGenerated]
	private bool Bnp;

	[CompilerGenerated]
	private bool XnE;

	[CompilerGenerated]
	private bool knC;

	[CompilerGenerated]
	private bool hnK;

	[CompilerGenerated]
	private bool PnN;

	[CompilerGenerated]
	private IEnumerable<Attribute> Lnl;

	[CompilerGenerated]
	private IEnumerable<CategoryEditor> Ong;

	[CompilerGenerated]
	private CollectionPropertyDisplayMode Enm;

	[CompilerGenerated]
	private bool wnT;

	[CompilerGenerated]
	private bool Xno;

	[CompilerGenerated]
	private string gnY;

	[CompilerGenerated]
	private IEnumerable<IPropertyModel> Ynk;

	[CompilerGenerated]
	private PropertyExpandability bnQ;

	[CompilerGenerated]
	private DataModelSortComparer tny;

	[CompilerGenerated]
	private object lnd;

	private static cJ t60;

	public bool AreAttachedPropertiesBrowsable
	{
		[CompilerGenerated]
		get
		{
			return gnn;
		}
		[CompilerGenerated]
		set
		{
			gnn = flag;
		}
	}

	public bool AreCategoriesAutoExpanded
	{
		[CompilerGenerated]
		get
		{
			return Bnp;
		}
		[CompilerGenerated]
		set
		{
			Bnp = bnp;
		}
	}

	public bool AreInheritedPropertiesBrowsable
	{
		[CompilerGenerated]
		get
		{
			return XnE;
		}
		[CompilerGenerated]
		set
		{
			XnE = xnE;
		}
	}

	public bool AreNestedCategoriesSupported
	{
		[CompilerGenerated]
		get
		{
			return knC;
		}
		[CompilerGenerated]
		set
		{
			knC = flag;
		}
	}

	public bool ArePropertiesAutoExpanded
	{
		[CompilerGenerated]
		get
		{
			return hnK;
		}
		[CompilerGenerated]
		set
		{
			hnK = flag;
		}
	}

	public bool AreReadOnlyPropertiesBrowsable
	{
		[CompilerGenerated]
		get
		{
			return PnN;
		}
		[CompilerGenerated]
		set
		{
			PnN = pnN;
		}
	}

	public IEnumerable<Attribute> BrowsableAttributes
	{
		[CompilerGenerated]
		get
		{
			return Lnl;
		}
		[CompilerGenerated]
		set
		{
			Lnl = lnl;
		}
	}

	public CollectionPropertyDisplayMode CollectionPropertyDisplayMode
	{
		[CompilerGenerated]
		get
		{
			return Enm;
		}
		[CompilerGenerated]
		set
		{
			Enm = enm;
		}
	}

	public bool IsCategorized
	{
		[CompilerGenerated]
		get
		{
			return wnT;
		}
		[CompilerGenerated]
		set
		{
			wnT = flag;
		}
	}

	public bool IsHostReadOnly
	{
		[CompilerGenerated]
		get
		{
			return Xno;
		}
		[CompilerGenerated]
		set
		{
			Xno = xno;
		}
	}

	public string MiscCategoryName
	{
		[CompilerGenerated]
		get
		{
			return gnY;
		}
		[CompilerGenerated]
		set
		{
			gnY = text;
		}
	}

	public PropertyExpandability PropertyExpandability
	{
		[CompilerGenerated]
		get
		{
			return bnQ;
		}
		[CompilerGenerated]
		set
		{
			bnQ = propertyExpandability;
		}
	}

	public DataModelSortComparer SortComparer
	{
		[CompilerGenerated]
		get
		{
			return tny;
		}
		[CompilerGenerated]
		set
		{
			tny = dataModelSortComparer;
		}
	}

	public object Source
	{
		[CompilerGenerated]
		get
		{
			return lnd;
		}
		[CompilerGenerated]
		set
		{
			lnd = obj;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public IEnumerable<CategoryEditor> TWs()
	{
		return Ong;
	}

	[SpecialName]
	[CompilerGenerated]
	public void GWF(IEnumerable<CategoryEditor> P_0)
	{
		Ong = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public IEnumerable<IPropertyModel> gnP()
	{
		return Ynk;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bn1(IEnumerable<IPropertyModel> P_0)
	{
		Ynk = P_0;
	}

	public cJ()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool U6j()
	{
		return t60 == null;
	}

	internal static cJ k6L()
	{
		return t60;
	}
}
