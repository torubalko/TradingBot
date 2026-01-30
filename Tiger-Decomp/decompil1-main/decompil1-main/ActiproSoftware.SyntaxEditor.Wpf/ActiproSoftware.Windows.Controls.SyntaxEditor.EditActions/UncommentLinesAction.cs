using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class UncommentLinesAction : EditActionBase
{
	internal static UncommentLinesAction uZh;

	public UncommentLinesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandUncommentLinesText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		return document != null && !document.IsReadOnly && document.Language != null && document.Language.GetLineCommenter() != null;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			int num = 0;
			if (!WZ6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(952));
			}
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document != null && document.Language != null)
		{
			document.Language.GetLineCommenter()?.Uncomment(view.CurrentSnapshot, view.Selection.Ranges, new EditorViewTextChangeOptions(view)
			{
				CheckReadOnly = true
			});
		}
	}

	internal static bool WZ6()
	{
		return uZh == null;
	}

	internal static UncommentLinesAction eZK()
	{
		return uZh;
	}
}
