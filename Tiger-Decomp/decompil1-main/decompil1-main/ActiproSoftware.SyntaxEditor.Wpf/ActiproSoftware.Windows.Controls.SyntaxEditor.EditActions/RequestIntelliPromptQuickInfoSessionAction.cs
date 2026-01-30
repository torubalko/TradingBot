using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class RequestIntelliPromptQuickInfoSessionAction : EditActionBase
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? ALZ;

	internal static RequestIntelliPromptQuickInfoSessionAction ckJ;

	public int? TargetOffset
	{
		[CompilerGenerated]
		get
		{
			return ALZ;
		}
		[CompilerGenerated]
		set
		{
			ALZ = value;
		}
	}

	public RequestIntelliPromptQuickInfoSessionAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRequestIntelliPromptQuickInfoSessionText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
		if (language == null)
		{
			return false;
		}
		IEnumerable<IQuickInfoProvider> enumerable = view.SyntaxEditor.jGF().g6Q<IQuickInfoProvider>(_0020: false);
		int num = 0;
		if (skO() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => enumerable?.Any() ?? false, 
		};
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ISyntaxLanguage language = view.SyntaxEditor.Document.Language;
		bool flag = language != null;
		int num = 0;
		if (skO() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag)
		{
			return;
		}
		view.Activate();
		IEnumerable<IQuickInfoProvider> enumerable = view.SyntaxEditor.jGF().g6Q<IQuickInfoProvider>(_0020: true);
		foreach (IQuickInfoProvider item in enumerable)
		{
			object context = item.GetContext(view, TargetOffset ?? view.Selection.EndOffset);
			if (context != null && item.RequestSession(view, context, canTrackPointer: false))
			{
				break;
			}
		}
	}

	internal static bool AkR()
	{
		return ckJ == null;
	}

	internal static RequestIntelliPromptQuickInfoSessionAction skO()
	{
		return ckJ;
	}
}
