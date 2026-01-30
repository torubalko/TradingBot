using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class StartAutomaticOutliningAction : EditActionBase
{
	internal static StartAutomaticOutliningAction j97;

	public StartAutomaticOutliningAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandStartAutomaticOutliningText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.OutliningManager == null || document.OutliningManager.ActiveMode == OutliningMode.Automatic)
		{
			return false;
		}
		OutliningMode outliningMode = document.OutliningMode;
		OutliningMode outliningMode2 = outliningMode;
		if (outliningMode2 == OutliningMode.None || outliningMode2 == OutliningMode.Manual)
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
			outliningManager.ActiveMode = OutliningMode.Automatic;
		}
	}

	internal static bool r9n()
	{
		return j97 == null;
	}

	internal static StartAutomaticOutliningAction B9q()
	{
		return j97;
	}
}
