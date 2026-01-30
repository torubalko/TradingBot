using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ToggleOutliningExpansionAction : EditActionBase
{
	internal static ToggleOutliningExpansionAction C9Z;

	public ToggleOutliningExpansionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandToggleOutliningExpansionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		return document != null && document.OutliningManager != null && document.OutliningManager.ActiveMode != OutliningMode.None;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager != null)
		{
			outliningManager.ToggleOutliningExpansion(view.CurrentViewLine);
			view.Scroller.ScrollToCaret();
		}
	}

	internal static bool g9F()
	{
		return C9Z == null;
	}

	internal static ToggleOutliningExpansionAction G99()
	{
		return C9Z;
	}
}
