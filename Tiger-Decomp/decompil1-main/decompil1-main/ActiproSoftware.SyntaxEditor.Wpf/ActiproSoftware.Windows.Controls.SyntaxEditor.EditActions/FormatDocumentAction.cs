using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FormatDocumentAction : EditActionBase
{
	internal static FormatDocumentAction Dke;

	public FormatDocumentAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandFormatDocumentText));
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
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document != null && document.Language != null)
		{
			ITextFormatter textFormatter = document.Language.GetTextFormatter();
			if (textFormatter != null)
			{
				ITextSnapshot currentSnapshot = view.CurrentSnapshot;
				textFormatter.Format(currentSnapshot, TextPositionRange.CreateCollection(view.Selection.PositionRange, isBlock: false), TextFormatMode.All);
			}
		}
	}

	internal static bool Lkz()
	{
		return Dke == null;
	}

	internal static FormatDocumentAction NZm()
	{
		return Dke;
	}
}
