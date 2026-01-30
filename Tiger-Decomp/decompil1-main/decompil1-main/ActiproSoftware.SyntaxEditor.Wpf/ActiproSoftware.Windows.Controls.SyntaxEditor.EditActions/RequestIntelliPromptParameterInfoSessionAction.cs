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
public class RequestIntelliPromptParameterInfoSessionAction : EditActionBase
{
	private static RequestIntelliPromptParameterInfoSessionAction hkZ;

	public RequestIntelliPromptParameterInfoSessionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRequestIntelliPromptParameterInfoSessionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
		if (language != null)
		{
			return view.SyntaxEditor.jGF().g6Q<IParameterInfoProvider>(_0020: false)?.Any() ?? false;
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
		if (language == null)
		{
			return;
		}
		view.Activate();
		IEnumerable<IParameterInfoProvider> enumerable = view.SyntaxEditor.jGF().g6Q<IParameterInfoProvider>(_0020: true);
		foreach (IParameterInfoProvider item in enumerable)
		{
			if (item.RequestSession(view))
			{
				break;
			}
		}
	}

	internal static bool hkF()
	{
		return hkZ == null;
	}

	internal static RequestIntelliPromptParameterInfoSessionAction vk9()
	{
		return hkZ;
	}
}
