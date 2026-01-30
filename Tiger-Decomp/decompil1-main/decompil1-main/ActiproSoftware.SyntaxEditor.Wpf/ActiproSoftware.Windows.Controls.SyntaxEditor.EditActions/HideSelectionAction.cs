using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class HideSelectionAction : EditActionBase
{
	internal static HideSelectionAction B9D;

	public HideSelectionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandHideSelectionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.OutliningManager == null || document.OutliningManager.ActiveMode != OutliningMode.Manual)
		{
			return false;
		}
		return !view.Selection.IsZeroLength;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager != null && !view.Selection.IsZeroLength)
		{
			outliningManager.AddManualNode(view.Selection.SnapshotRange, null);
		}
	}

	internal static bool M9B()
	{
		return B9D == null;
	}

	internal static HideSelectionAction m90()
	{
		return B9D;
	}
}
