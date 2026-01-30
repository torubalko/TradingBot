using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CopyAndAppendToClipboardAction : CopyToClipboardAction
{
	internal static CopyAndAppendToClipboardAction uS4;

	protected override bool Append => true;

	public CopyAndAppendToClipboardAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCopyAndAppendToClipboardText));
	}

	internal static bool rSD()
	{
		return uS4 == null;
	}

	internal static CopyAndAppendToClipboardAction WSB()
	{
		return uS4;
	}
}
