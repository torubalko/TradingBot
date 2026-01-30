using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ToggleAllOutliningExpansionAction : EditActionBase
{
	internal static ToggleAllOutliningExpansionAction B9W;

	public ToggleAllOutliningExpansionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandToggleAllOutliningExpansionText));
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
			outliningManager.ToggleAllOutliningExpansion();
			view.Scroller.ScrollToCaret();
		}
	}

	internal static bool K9S()
	{
		return B9W == null;
	}

	internal static ToggleAllOutliningExpansionAction q9k()
	{
		return B9W;
	}
}
