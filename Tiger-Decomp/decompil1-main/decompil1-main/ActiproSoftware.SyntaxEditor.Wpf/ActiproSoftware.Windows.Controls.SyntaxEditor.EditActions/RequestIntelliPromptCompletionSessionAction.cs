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
public class RequestIntelliPromptCompletionSessionAction : EditActionBase
{
	internal static RequestIntelliPromptCompletionSessionAction nkg;

	public RequestIntelliPromptCompletionSessionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRequestIntelliPromptCompletionSessionText));
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
				return view.SyntaxEditor.jGF().g6Q<ICompletionProvider>(_0020: false)?.Any() ?? false;
			}
		}
		return false;
	}

	public override void Execute(IEditorView view)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					if (flag)
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
					{
						foreach (ICompletionProvider item in enumerable)
						{
							if (item.RequestSession(view, canCommitWithoutPopup: false))
							{
								break;
							}
						}
						return;
					}
				}
				case 1:
					break;
				}
				flag = view == null;
				num2 = 0;
			}
			while (ykA());
		}
	}

	internal static bool ykA()
	{
		return nkg == null;
	}

	internal static RequestIntelliPromptCompletionSessionAction qkl()
	{
		return nkg;
	}
}
