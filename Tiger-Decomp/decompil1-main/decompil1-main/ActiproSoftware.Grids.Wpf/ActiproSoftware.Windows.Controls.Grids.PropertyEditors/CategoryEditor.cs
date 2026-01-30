using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class CategoryEditor : ObservableObjectBase
{
	private string hJh;

	private string QJZ;

	private string aJH;

	private DataTemplate DJD;

	private object LJ7;

	private CategoryEditorPropertyCollection RJs;

	internal static CategoryEditor yWD;

	public string Category
	{
		get
		{
			return hJh;
		}
		set
		{
			if (hJh != value)
			{
				hJh = value;
				NotifyPropertyChanged(xv.hTz(7708));
			}
		}
	}

	public string Description
	{
		get
		{
			return QJZ;
		}
		set
		{
			if (QJZ != value)
			{
				QJZ = value;
				NotifyPropertyChanged(xv.hTz(7728));
			}
		}
	}

	public string DisplayName
	{
		get
		{
			return aJH;
		}
		set
		{
			if (aJH != value)
			{
				aJH = value;
				NotifyPropertyChanged(xv.hTz(7754));
			}
		}
	}

	public DataTemplate EditorTemplate
	{
		get
		{
			return DJD;
		}
		set
		{
			if (DJD != value)
			{
				DJD = value;
				NotifyPropertyChanged(xv.hTz(7780));
			}
		}
	}

	public object EditorTemplateKey
	{
		get
		{
			return LJ7;
		}
		set
		{
			if (LJ7 != value)
			{
				LJ7 = value;
				NotifyPropertyChanged(xv.hTz(7812));
			}
		}
	}

	public CategoryEditorPropertyCollection Properties => RJs;

	public CategoryEditor()
	{
		fc.taYSkz();
		RJs = new CategoryEditorPropertyCollection();
		base._002Ector();
	}

	internal static bool dWb()
	{
		return yWD == null;
	}

	internal static CategoryEditor QWz()
	{
		return yWD;
	}
}
