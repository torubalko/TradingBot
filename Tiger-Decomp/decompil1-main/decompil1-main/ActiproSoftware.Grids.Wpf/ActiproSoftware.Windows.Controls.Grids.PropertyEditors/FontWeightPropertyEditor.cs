using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class FontWeightPropertyEditor : PropertyEditor
{
	private static FontWeightPropertyEditor iC4;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public FontWeightPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.FontWeight;
	}

	internal static bool hCl()
	{
		return iC4 == null;
	}

	internal static FontWeightPropertyEditor TCI()
	{
		return iC4;
	}
}
