using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ApplyDefaultOutliningExpansionAction : EditActionBase
{
	internal static ApplyDefaultOutliningExpansionAction VFw;

	public ApplyDefaultOutliningExpansionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandApplyDefaultOutliningExpansionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.OutliningManager == null || document.OutliningManager.ActiveMode == OutliningMode.None)
		{
			return false;
		}
		return document.Language != null && document.Language.GetOutliner() != null;
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
			if (outliningManager.ActiveMode != OutliningMode.Automatic)
			{
				outliningManager.ActiveMode = OutliningMode.Automatic;
			}
			outliningManager.ApplyDefaultOutliningExpansion();
		}
	}

	internal static bool nFu()
	{
		return VFw == null;
	}

	internal static ApplyDefaultOutliningExpansionAction tF8()
	{
		return VFw;
	}
}
