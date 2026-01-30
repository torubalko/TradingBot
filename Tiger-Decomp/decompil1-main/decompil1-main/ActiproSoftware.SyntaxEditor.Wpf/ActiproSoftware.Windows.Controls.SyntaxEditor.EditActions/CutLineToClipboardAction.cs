using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "CutLine")]
public class CutLineToClipboardAction : EditActionBase
{
	private static CutLineToClipboardAction iSL;

	public CutLineToClipboardAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCutLineToClipboardText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		CopyToClipboardAction.eLS(view, _0020: false, _0020: true, _0020: true);
	}

	internal static bool JSg()
	{
		return iSL == null;
	}

	internal static CutLineToClipboardAction FSA()
	{
		return iSL;
	}
}
