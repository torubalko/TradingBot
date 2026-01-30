using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CapitalizeAction : ChangeCharacterCasingAction
{
	internal static CapitalizeAction xkY;

	protected override CharacterCasing? Casing => CharacterCasing.Normal;

	public CapitalizeAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCapitalizeText));
	}

	internal static bool Qkb()
	{
		return xkY == null;
	}

	internal static CapitalizeAction Sks()
	{
		return xkY;
	}
}
