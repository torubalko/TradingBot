using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

[SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
public class CategoryEditorModel : DataModelBase, ICategoryEditorModel, IDataModel, IDisposable
{
	private CategoryEditor z54;

	private string I5S;

	private string D5z;

	private DataTemplate GWI;

	private object aWP;

	private string jW1;

	private int iWt;

	private static CategoryEditorModel m6F;

	public CategoryEditor CategoryEditor => z54;

	public string Description
	{
		get
		{
			return I5S ?? xv.hTz(3106);
		}
		set
		{
			if (!(I5S == value))
			{
				I5S = value;
				NotifyPropertyChanged(xv.hTz(7728));
			}
		}
	}

	protected sealed override string DescriptionResolved => Description;

	public string DisplayName
	{
		get
		{
			return D5z;
		}
		set
		{
			if (!(D5z == value))
			{
				D5z = value;
				NotifyPropertyChanged(xv.hTz(7754));
			}
		}
	}

	protected sealed override string DisplayNameResolved => DisplayName;

	public DataTemplate EditorTemplate
	{
		get
		{
			return GWI;
		}
		set
		{
			if (GWI != value)
			{
				GWI = value;
				NotifyPropertyChanged(xv.hTz(7780));
			}
		}
	}

	public object EditorTemplateKey
	{
		get
		{
			return aWP;
		}
		set
		{
			if (aWP != value)
			{
				aWP = value;
				NotifyPropertyChanged(xv.hTz(7812));
			}
		}
	}

	protected override bool IsModifiedResolved => false;

	public string Name
	{
		get
		{
			return jW1;
		}
		set
		{
			if (!(jW1 == value))
			{
				if (!string.IsNullOrEmpty(value))
				{
					jW1 = value;
				}
				NotifyPropertyChanged(xv.hTz(8404));
			}
		}
	}

	protected sealed override string NameResolved => Name;

	protected override DataModelSortImportance SortImportanceResolved => DataModelSortImportance.CategoryEditor;

	public int SortOrder
	{
		get
		{
			return iWt;
		}
		set
		{
			if (iWt != value)
			{
				iWt = value;
				NotifyPropertyChanged(xv.hTz(8514));
			}
		}
	}

	protected sealed override int SortOrderResolved => SortOrder;

	public CategoryEditorModel()
	{
		fc.taYSkz();
		base._002Ector();
	}

	public CategoryEditorModel(CategoryEditor categoryEditor)
	{
		fc.taYSkz();
		this._002Ector();
		if (categoryEditor == null)
		{
			throw new ArgumentNullException(xv.hTz(8716));
		}
		z54 = categoryEditor;
		I5S = categoryEditor.Description;
		D5z = categoryEditor.DisplayName;
		GWI = categoryEditor.EditorTemplate;
		aWP = categoryEditor.EditorTemplateKey;
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		jW1 = categoryEditor.DisplayName;
	}

	internal static bool m6s()
	{
		return m6F == null;
	}

	internal static CategoryEditorModel H6c()
	{
		return m6F;
	}
}
