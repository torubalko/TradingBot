using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ExpandAllOutliningAction : EditActionBase
{
	private static ExpandAllOutliningAction L9m;

	public ExpandAllOutliningAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandExpandAllOutliningText));
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
			outliningManager.ExpandAllOutlining();
			view.Scroller.ScrollToCaret();
		}
	}

	internal static bool h9p()
	{
		return L9m == null;
	}

	internal static ExpandAllOutliningAction k94()
	{
		return L9m;
	}
}
