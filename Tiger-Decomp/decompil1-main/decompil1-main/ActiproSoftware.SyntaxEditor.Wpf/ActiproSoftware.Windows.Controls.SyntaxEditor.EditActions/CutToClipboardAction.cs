using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CutToClipboardAction : EditActionBase
{
	private static CutToClipboardAction cSl;

	protected virtual bool Append => false;

	public CutToClipboardAction()
	{
		grA.DaB7cz();
		this._002Ector(SR.GetString(SRName.UICommandCutToClipboardText));
	}

	protected CutToClipboardAction(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
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
		CopyToClipboardAction.eLS(view, Append, _0020: true, _0020: false);
	}

	internal static bool SSW()
	{
		return cSl == null;
	}

	internal static CutToClipboardAction tSS()
	{
		return cSl;
	}
}
