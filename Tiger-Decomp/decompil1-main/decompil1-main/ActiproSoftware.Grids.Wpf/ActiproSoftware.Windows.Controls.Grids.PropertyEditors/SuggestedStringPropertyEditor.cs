using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class SuggestedStringPropertyEditor : PropertyEditor
{
	private static SuggestedStringPropertyEditor kCb;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public SuggestedStringPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.SuggestedString;
	}

	internal static bool dCz()
	{
		return kCb == null;
	}

	internal static SuggestedStringPropertyEditor o6Q()
	{
		return kCb;
	}
}
