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
public class RequestIntelliPromptAutoCompleteAction : EditActionBase
{
	internal static RequestIntelliPromptAutoCompleteAction Okx;

	public RequestIntelliPromptAutoCompleteAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRequestIntelliPromptAutoCompleteText));
	}

	public override bool CanExecute(IEditorView view)
	{
		bool result;
		if (view != null)
		{
			if (!view.SyntaxEditor.Document.IsReadOnly)
			{
				ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
				if (language != null)
				{
					result = view.SyntaxEditor.jGF().g6Q<ICompletionProvider>(_0020: false)?.Any() ?? false;
					int num = 0;
					if (OkL() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					goto IL_00e9;
				}
			}
			result = false;
			goto IL_00e9;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
		IL_00e9:
		return result;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
		if (language == null)
		{
			return;
		}
		view.Activate();
		IEnumerable<ICompletionProvider> enumerable = view.SyntaxEditor.jGF().g6Q<ICompletionProvider>(_0020: true);
		foreach (ICompletionProvider item in enumerable)
		{
			if (!item.RequestSession(view, canCommitWithoutPopup: true))
			{
				continue;
			}
			break;
		}
	}

	internal static bool Yka()
	{
		return Okx == null;
	}

	internal static RequestIntelliPromptAutoCompleteAction OkL()
	{
		return Okx;
	}
}
