using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class ExtendedStringPropertyEditor : PropertyEditor
{
	private ExtendedStringPropertyEditorBehavior HJf;

	private ICommand LJ0;

	private static ExtendedStringPropertyEditor TCJ;

	public ExtendedStringPropertyEditorBehavior Behavior
	{
		get
		{
			return HJf;
		}
		set
		{
			if (HJf != value)
			{
				HJf = value;
				NotifyPropertyChanged(xv.hTz(7930));
			}
		}
	}

	public ICommand ButtonCommand
	{
		get
		{
			return LJ0;
		}
		set
		{
			if (LJ0 != value)
			{
				LJ0 = value;
				NotifyPropertyChanged(xv.hTz(7950));
			}
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public ExtendedStringPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.ExtendedString;
	}

	protected internal override bool? GetIsReadOnly(IPropertyModel propertyModel)
	{
		if (HJf == ExtendedStringPropertyEditorBehavior.ButtonEnabled && propertyModel != null && !propertyModel.IsHostReadOnly)
		{
			return false;
		}
		return base.GetIsReadOnly(propertyModel);
	}

	internal static bool nCK()
	{
		return TCJ == null;
	}

	internal static ExtendedStringPropertyEditor ACE()
	{
		return TCJ;
	}
}
