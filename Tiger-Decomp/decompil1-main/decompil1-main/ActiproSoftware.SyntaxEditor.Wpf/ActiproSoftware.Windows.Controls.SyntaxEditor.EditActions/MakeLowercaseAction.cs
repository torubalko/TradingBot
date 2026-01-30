using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MakeLowercaseAction : ChangeCharacterCasingAction
{
	internal static MakeLowercaseAction dZa;

	protected override CharacterCasing? Casing => CharacterCasing.Lower;

	public MakeLowercaseAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMakeLowercaseText));
	}

	internal static bool NZL()
	{
		return dZa == null;
	}

	internal static MakeLowercaseAction jZg()
	{
		return dZa;
	}
}
