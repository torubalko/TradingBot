using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class StopHidingCurrentAction : EditActionBase
{
	internal static StopHidingCurrentAction L9x;

	public StopHidingCurrentAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandStopHidingCurrentText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.OutliningManager == null)
		{
			return false;
		}
		return document.OutliningManager.ActiveMode == OutliningMode.Manual;
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
			outliningManager.RemoveManualNode(new TextSnapshotOffset(view.CurrentSnapshot, view.Selection.EndOffset));
			view.Scroller.ScrollToCaret();
		}
	}

	internal static bool H9a()
	{
		return L9x == null;
	}

	internal static StopHidingCurrentAction b9L()
	{
		return L9x;
	}
}
