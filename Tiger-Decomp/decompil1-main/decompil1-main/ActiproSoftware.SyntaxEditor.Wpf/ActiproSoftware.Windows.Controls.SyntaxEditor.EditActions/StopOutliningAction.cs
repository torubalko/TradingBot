using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class StopOutliningAction : EditActionBase
{
	private static StopOutliningAction s9g;

	public StopOutliningAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandStopOutliningText));
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
		if (document.OutliningManager.ActiveMode == OutliningMode.Manual && document.OutliningManager.RootNode.Count == 0)
		{
			return false;
		}
		OutliningMode outliningMode = document.OutliningMode;
		OutliningMode outliningMode2 = outliningMode;
		if ((uint)outliningMode2 <= 1u)
		{
			return false;
		}
		return true;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return;
		}
		int num = 0;
		if (!s9A())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (outliningManager.ActiveMode == OutliningMode.Manual)
		{
			outliningManager.RemoveAllManualNodes();
		}
		else
		{
			outliningManager.ActiveMode = OutliningMode.Manual;
		}
		view.Scroller.ScrollToCaret();
	}

	internal static bool s9A()
	{
		return s9g == null;
	}

	internal static StopOutliningAction X9l()
	{
		return s9g;
	}
}
