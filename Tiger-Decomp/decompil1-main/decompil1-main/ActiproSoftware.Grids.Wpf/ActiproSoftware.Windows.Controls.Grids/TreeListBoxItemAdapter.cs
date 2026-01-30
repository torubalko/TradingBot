using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListBoxItemAdapter
{
	private Binding dUy;

	private string UUd;

	private up IUB;

	private Binding bUR;

	private string fUM;

	private Binding rUe;

	private string KUr;

	private Binding gUG;

	private string FUu;

	private Binding AUO;

	private string NUw;

	private Binding TUX;

	private string WU2;

	[CompilerGenerated]
	private string DUv;

	[CompilerGenerated]
	private TreeItemChildrenQueryMode sU8;

	[CompilerGenerated]
	private TreeItemExpandability XU9;

	[CompilerGenerated]
	private Binding BU3;

	[CompilerGenerated]
	private Binding lUL;

	[CompilerGenerated]
	private bool kUj;

	[CompilerGenerated]
	private string eUx;

	[CompilerGenerated]
	private bool TUa;

	[CompilerGenerated]
	private string zUi;

	[CompilerGenerated]
	private string BUb;

	[CompilerGenerated]
	private string vUh;

	[CompilerGenerated]
	private string OUZ;

	[CompilerGenerated]
	private Binding fUH;

	[CompilerGenerated]
	private Binding cUD;

	[CompilerGenerated]
	private TreeItemExpandability HU7;

	internal static TreeListBoxItemAdapter vWX;

	public Binding ChildrenBinding
	{
		get
		{
			return dUy;
		}
		set
		{
			if (dUy != value)
			{
				dUy = value;
				UUd = lUp(dUy);
			}
		}
	}

	public string ChildrenPath
	{
		[CompilerGenerated]
		get
		{
			return DUv;
		}
		[CompilerGenerated]
		set
		{
			DUv = value;
		}
	}

	public TreeItemChildrenQueryMode ChildrenQueryModeDefault
	{
		[CompilerGenerated]
		get
		{
			return sU8;
		}
		[CompilerGenerated]
		set
		{
			sU8 = value;
		}
	}

	public TreeItemExpandability ExpandabilityDefault
	{
		[CompilerGenerated]
		get
		{
			return XU9;
		}
		[CompilerGenerated]
		set
		{
			XU9 = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Draggable")]
	public Binding IsDraggableBinding
	{
		[CompilerGenerated]
		get
		{
			return BU3;
		}
		[CompilerGenerated]
		set
		{
			BU3 = value;
		}
	}

	public Binding IsEditableBinding
	{
		[CompilerGenerated]
		get
		{
			return lUL;
		}
		[CompilerGenerated]
		set
		{
			lUL = value;
		}
	}

	public bool IsEditableDefault
	{
		[CompilerGenerated]
		get
		{
			return kUj;
		}
		[CompilerGenerated]
		set
		{
			kUj = value;
		}
	}

	public Binding IsEditingBinding
	{
		get
		{
			return bUR;
		}
		set
		{
			if (bUR != value)
			{
				bUR = value;
				fUM = lUp(bUR);
			}
		}
	}

	public string IsEditingPath
	{
		[CompilerGenerated]
		get
		{
			return eUx;
		}
		[CompilerGenerated]
		set
		{
			eUx = value;
		}
	}

	public Binding IsExpandedBinding
	{
		get
		{
			return rUe;
		}
		set
		{
			if (rUe != value)
			{
				rUe = value;
				KUr = lUp(rUe);
			}
		}
	}

	public bool IsExpandedDefault
	{
		[CompilerGenerated]
		get
		{
			return TUa;
		}
		[CompilerGenerated]
		set
		{
			TUa = value;
		}
	}

	public string IsExpandedPath
	{
		[CompilerGenerated]
		get
		{
			return zUi;
		}
		[CompilerGenerated]
		set
		{
			zUi = value;
		}
	}

	public Binding IsLoadingBinding
	{
		get
		{
			return gUG;
		}
		set
		{
			if (gUG != value)
			{
				gUG = value;
				FUu = lUp(gUG);
			}
		}
	}

	public string IsLoadingPath
	{
		[CompilerGenerated]
		get
		{
			return BUb;
		}
		[CompilerGenerated]
		set
		{
			BUb = value;
		}
	}

	public Binding IsSelectableBinding
	{
		get
		{
			return AUO;
		}
		set
		{
			if (AUO != value)
			{
				AUO = value;
				NUw = lUp(AUO);
			}
		}
	}

	public string IsSelectablePath
	{
		[CompilerGenerated]
		get
		{
			return vUh;
		}
		[CompilerGenerated]
		set
		{
			vUh = value;
		}
	}

	public Binding IsSelectedBinding
	{
		get
		{
			return TUX;
		}
		set
		{
			if (TUX != value)
			{
				TUX = value;
				WU2 = lUp(TUX);
			}
		}
	}

	public string IsSelectedPath
	{
		[CompilerGenerated]
		get
		{
			return OUZ;
		}
		[CompilerGenerated]
		set
		{
			OUZ = value;
		}
	}

	public Binding PathBinding
	{
		[CompilerGenerated]
		get
		{
			return fUH;
		}
		[CompilerGenerated]
		set
		{
			fUH = value;
		}
	}

	public Binding SearchTextBinding
	{
		[CompilerGenerated]
		get
		{
			return cUD;
		}
		[CompilerGenerated]
		set
		{
			cUD = value;
		}
	}

	public TreeItemExpandability TopLevelExpandabilityDefault
	{
		[CompilerGenerated]
		get
		{
			return HU7;
		}
		[CompilerGenerated]
		set
		{
			HU7 = value;
		}
	}

	[SpecialName]
	internal string mUE()
	{
		return ChildrenPath ?? UUd;
	}

	private static string lUp(Binding P_0)
	{
		if (P_0 != null)
		{
			string text = P_0.Path?.Path;
			if (!string.IsNullOrEmpty(text))
			{
				text = text.Trim();
				if (text.Length > 0 && text.IndexOfAny(new char[3] { '.', '[', ']' }) == -1)
				{
					return text;
				}
			}
		}
		return null;
	}

	[SpecialName]
	internal string VUK()
	{
		return IsEditingPath ?? fUM;
	}

	[SpecialName]
	internal string SUl()
	{
		return IsExpandedPath ?? KUr;
	}

	[SpecialName]
	internal string pUm()
	{
		return IsLoadingPath ?? FUu;
	}

	[SpecialName]
	internal string uUo()
	{
		return IsSelectablePath ?? NUw;
	}

	[SpecialName]
	internal string FUk()
	{
		return IsSelectedPath ?? WU2;
	}

	public virtual bool CanHaveChildren(TreeListBox ownerControl, object item)
	{
		return item != null;
	}

	public virtual ITreeItemVirtualPlaceholder CreateVirtualPlaceholder(TreeListBox ownerControl, object parentItem, int index)
	{
		return new Fl(index);
	}

	public virtual DataFilterResult Filter(TreeListBox ownerControl, object item)
	{
		IDataFilter dataFilter = ownerControl?.DataFilter;
		if (dataFilter == null || !dataFilter.IsEnabled)
		{
			return DataFilterResult.Included;
		}
		return dataFilter.Filter(item, null);
	}

	public virtual IEnumerable GetChildren(TreeListBox ownerControl, object item)
	{
		Binding childrenBinding = ChildrenBinding;
		if (childrenBinding != null)
		{
			return IUB.lEN<IEnumerable>(childrenBinding, item);
		}
		return null;
	}

	public virtual TreeItemChildrenQueryMode GetChildrenQueryMode(TreeListBox ownerControl, object item)
	{
		return ChildrenQueryModeDefault;
	}

	public virtual TreeItemExpandability GetExpandability(TreeListBox ownerControl, object item, int depth)
	{
		if (depth <= 0 && TopLevelExpandabilityDefault == TreeItemExpandability.Never)
		{
			return TreeItemExpandability.Never;
		}
		return ExpandabilityDefault;
	}

	public virtual double GetIndentAmount(TreeListBox ownerControl, object item, int depth)
	{
		if (ownerControl != null)
		{
			return Math.Max(0.0, ownerControl.TopLevelIndent + (double)depth * ownerControl.IndentIncrement);
		}
		return 0.0;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Draggable")]
	public virtual bool GetIsDraggable(TreeListBox ownerControl, object item)
	{
		Binding isDraggableBinding = IsDraggableBinding;
		if (isDraggableBinding != null)
		{
			return IUB.GEl(isDraggableBinding, item);
		}
		return true;
	}

	public virtual bool GetIsEditable(TreeListBox ownerControl, object item)
	{
		Binding isEditableBinding = IsEditableBinding;
		if (isEditableBinding != null)
		{
			return IUB.GEl(isEditableBinding, item);
		}
		return IsEditableDefault;
	}

	public virtual bool GetIsEditing(TreeListBox ownerControl, object item)
	{
		Binding isEditingBinding = IsEditingBinding;
		if (isEditingBinding != null)
		{
			return IUB.GEl(isEditingBinding, item);
		}
		return false;
	}

	public virtual bool GetIsExpanded(TreeListBox ownerControl, object item)
	{
		Binding isExpandedBinding = IsExpandedBinding;
		if (isExpandedBinding != null)
		{
			return IUB.GEl(isExpandedBinding, item);
		}
		return IsExpandedDefault;
	}

	public virtual bool GetIsLoading(TreeListBox ownerControl, object item)
	{
		Binding isLoadingBinding = IsLoadingBinding;
		if (isLoadingBinding != null)
		{
			return IUB.GEl(isLoadingBinding, item);
		}
		return false;
	}

	public virtual bool GetIsSelectable(TreeListBox ownerControl, object item)
	{
		Binding isSelectableBinding = IsSelectableBinding;
		if (isSelectableBinding != null)
		{
			return IUB.GEl(isSelectableBinding, item);
		}
		return true;
	}

	public virtual bool GetIsSelected(TreeListBox ownerControl, object item)
	{
		Binding isSelectedBinding = IsSelectedBinding;
		if (isSelectedBinding != null)
		{
			return IUB.GEl(isSelectedBinding, item);
		}
		return false;
	}

	public virtual string GetPath(TreeListBox ownerControl, object item)
	{
		Binding pathBinding = PathBinding;
		if (pathBinding != null)
		{
			return IUB.lEN<string>(pathBinding, item);
		}
		return null;
	}

	public virtual string GetSearchText(TreeListBox ownerControl, object item)
	{
		Binding searchTextBinding = SearchTextBinding;
		if (searchTextBinding != null)
		{
			return IUB.lEN<string>(searchTextBinding, item);
		}
		return null;
	}

	public virtual DragDropEffects InitializeDataObject(TreeListBox sourceControl, IDataObject dataObject, IEnumerable<object> items)
	{
		return DragDropEffects.None;
	}

	public virtual void OnDragComplete(InputPointerEventArgs e, TreeListBox sourceControl, DataObject dataObject, DragDropEffects effect)
	{
	}

	public virtual TreeItemExpandability OnDragHover(DragEventArgs e, TreeListBox targetControl, object targetItem)
	{
		return TreeItemExpandability.Auto;
	}

	public virtual TreeItemDropArea OnDragOver(DragEventArgs e, TreeListBox targetControl, object targetItem, TreeItemDropArea dropArea)
	{
		if (e != null)
		{
			e.Effects = DragDropEffects.None;
		}
		return TreeItemDropArea.None;
	}

	public virtual void OnDragStart(InputPointerEventArgs e, TreeListBox sourceControl, DataObject dataObject, DragDropEffects allowedEffects)
	{
	}

	public virtual void OnDrop(DragEventArgs e, TreeListBox targetControl, object targetItem, TreeItemDropArea dropArea)
	{
		if (e != null)
		{
			e.Effects = DragDropEffects.None;
		}
	}

	public virtual void SetIsEditing(TreeListBox ownerControl, object item, bool value)
	{
		Binding isEditingBinding = IsEditingBinding;
		if (isEditingBinding != null)
		{
			IUB.UEg(isEditingBinding, item, value);
		}
	}

	public virtual void SetIsExpanded(TreeListBox ownerControl, object item, bool value)
	{
		Binding isExpandedBinding = IsExpandedBinding;
		if (isExpandedBinding != null)
		{
			IUB.UEg(isExpandedBinding, item, value);
		}
	}

	public virtual void SetIsSelected(TreeListBox ownerControl, object item, bool value)
	{
		Binding isSelectedBinding = IsSelectedBinding;
		if (isSelectedBinding != null)
		{
			IUB.UEg(isSelectedBinding, item, value);
		}
	}

	public TreeListBoxItemAdapter()
	{
		fc.taYSkz();
		IUB = new up();
		base._002Ector();
	}

	internal static bool uW9()
	{
		return vWX == null;
	}

	internal static TreeListBoxItemAdapter FW8()
	{
		return vWX;
	}
}
