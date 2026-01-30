using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CommentLinesAction : EditActionBase
{
	internal static CommentLinesAction gky;

	public CommentLinesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCommentLinesText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view != null)
		{
			IEditorDocument document = view.SyntaxEditor.Document;
			return document != null && !document.IsReadOnly && document.Language != null && document.Language.GetLineCommenter() != null;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document != null && document.Language != null)
		{
			document.Language.GetLineCommenter()?.Comment(view.CurrentSnapshot, view.Selection.Ranges, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			});
		}
	}

	internal static bool xkh()
	{
		return gky == null;
	}

	internal static CommentLinesAction Sk6()
	{
		return gky;
	}
}
