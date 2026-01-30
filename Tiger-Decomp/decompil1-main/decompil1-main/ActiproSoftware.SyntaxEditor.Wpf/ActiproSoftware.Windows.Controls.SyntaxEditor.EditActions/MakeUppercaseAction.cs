using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MakeUppercaseAction : ChangeCharacterCasingAction
{
	internal static MakeUppercaseAction HZA;

	protected override CharacterCasing? Casing => CharacterCasing.Upper;

	public MakeUppercaseAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMakeUppercaseText));
	}

	internal static bool cZl()
	{
		return HZA == null;
	}

	internal static MakeUppercaseAction oZW()
	{
		return HZA;
	}
}
