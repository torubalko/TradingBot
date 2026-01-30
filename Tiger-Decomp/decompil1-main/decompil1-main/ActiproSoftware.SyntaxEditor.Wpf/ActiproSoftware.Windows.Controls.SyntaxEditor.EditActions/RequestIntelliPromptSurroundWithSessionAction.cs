using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class RequestIntelliPromptSurroundWithSessionAction : EditActionBase
{
	private static RequestIntelliPromptSurroundWithSessionAction mk1;

	public RequestIntelliPromptSurroundWithSessionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRequestIntelliPromptSurroundWithSessionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.Document.IsReadOnly)
		{
			ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
			if (language != null)
			{
				IEnumerable<ICodeSnippetProvider> enumerable = view.SyntaxEditor.jGF().g6Q<ICodeSnippetProvider>(_0020: false);
				int num = 0;
				if (ckG() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => enumerable?.Any() ?? false, 
				};
			}
		}
		return false;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
		int num = 0;
		if (ckG() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (language == null)
		{
			return;
		}
		view.Activate();
		IEnumerable<ICodeSnippetProvider> enumerable = view.SyntaxEditor.jGF().g6Q<ICodeSnippetProvider>(_0020: true);
		foreach (ICodeSnippetProvider item in enumerable)
		{
			if (item.RequestSelectionSession(view, CodeSnippetTypes.SurroundsWith))
			{
				break;
			}
		}
	}

	internal static bool Ok5()
	{
		return mk1 == null;
	}

	internal static RequestIntelliPromptSurroundWithSessionAction ckG()
	{
		return mk1;
	}
}
