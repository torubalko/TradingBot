using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ToggleCharacterCasingAction : ChangeCharacterCasingAction
{
	internal static ToggleCharacterCasingAction UZi;

	protected override CharacterCasing? Casing => null;

	public ToggleCharacterCasingAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandToggleCharacterCasingText));
	}

	internal static bool hZ2()
	{
		return UZi == null;
	}

	internal static ToggleCharacterCasingAction BZV()
	{
		return UZi;
	}
}
