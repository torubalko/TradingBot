using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
public class TrimAllTrailingWhitespaceAction : EditActionBase
{
	internal static TrimAllTrailingWhitespaceAction VSr;

	public TrimAllTrailingWhitespaceAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandTrimAllTrailingWhitespaceText));
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
		if (view.CurrentSnapshot.Length <= 0)
		{
			return;
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			TrimTrailingWhitespaceAction.FLM(view.CurrentSnapshot, new TextRange[1] { view.CurrentSnapshot.TextRange }, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true,
				RetainSelection = true
			});
		}
	}

	internal static bool aSX()
	{
		return VSr == null;
	}

	internal static TrimAllTrailingWhitespaceAction qSE()
	{
		return VSr;
	}
}
