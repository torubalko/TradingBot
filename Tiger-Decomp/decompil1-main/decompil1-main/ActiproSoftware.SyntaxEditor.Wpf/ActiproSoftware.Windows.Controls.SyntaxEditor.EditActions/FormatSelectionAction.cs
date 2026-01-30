using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FormatSelectionAction : EditActionBase
{
	internal static FormatSelectionAction pZp;

	public FormatSelectionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandFormatSelectionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.IsReadOnly)
		{
			return false;
		}
		return document.Language != null && document.Language.GetTextFormatter() != null;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ICodeDocument document = view.SyntaxEditor.Document;
		if (document != null && document.Language != null)
		{
			ITextFormatter textFormatter = document.Language.GetTextFormatter();
			int num = 0;
			if (!nZ4())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			textFormatter?.Format(view.CurrentSnapshot, view.Selection.Ranges);
		}
	}

	internal static bool nZ4()
	{
		return pZp == null;
	}

	internal static FormatSelectionAction UZD()
	{
		return pZp;
	}
}
