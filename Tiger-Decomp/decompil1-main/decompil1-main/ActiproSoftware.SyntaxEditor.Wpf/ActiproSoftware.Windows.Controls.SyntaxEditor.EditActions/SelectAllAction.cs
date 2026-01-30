using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectAllAction : EditActionBase
{
	private static SelectAllAction aJi;

	public SelectAllAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectAllText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
		{
			return;
		}
		EditorViewSelectionBatchOptions options = ((!view.SyntaxEditor.ScrollToCaretOnSelectAll) ? EditorViewSelectionBatchOptions.NoScrollToCaret : EditorViewSelectionBatchOptions.None);
		using (view.Selection.CreateBatch(options))
		{
			view.Selection.SelectRange(0, view.CurrentSnapshot.Length, SelectionModes.ContinuousStream);
		}
	}

	internal static bool sJ2()
	{
		return aJi == null;
	}

	internal static SelectAllAction SJV()
	{
		return aJi;
	}
}
