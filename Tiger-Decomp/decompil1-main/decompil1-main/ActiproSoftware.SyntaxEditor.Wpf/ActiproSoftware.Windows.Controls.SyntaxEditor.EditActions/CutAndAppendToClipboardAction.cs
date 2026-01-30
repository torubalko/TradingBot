using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CutAndAppendToClipboardAction : CutToClipboardAction
{
	private static CutAndAppendToClipboardAction cSq;

	protected override bool Append => true;

	public CutAndAppendToClipboardAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCutAndAppendToClipboardText));
	}

	internal static bool YSx()
	{
		return cSq == null;
	}

	internal static CutAndAppendToClipboardAction tSa()
	{
		return cSq;
	}
}
