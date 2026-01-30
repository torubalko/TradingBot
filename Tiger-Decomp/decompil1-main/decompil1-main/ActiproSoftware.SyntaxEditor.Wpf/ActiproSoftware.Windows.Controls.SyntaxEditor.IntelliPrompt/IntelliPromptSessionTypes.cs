using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public static class IntelliPromptSessionTypes
{
	private static IIntelliPromptSessionType yCW;

	private static IIntelliPromptSessionType BCP;

	private static IIntelliPromptSessionType BCE;

	private static IIntelliPromptSessionType iCc;

	private static IIntelliPromptSessionType QCa;

	private static IIntelliPromptSessionType FCx;

	private static IIntelliPromptSessionType WCG;

	internal static IntelliPromptSessionTypes yxA;

	[Obsolete("Use the 'IntelliPromptSessionTypes.CodeSnippetTemplate' property instead.", false)]
	public static IIntelliPromptSessionType CodeSnippet => CodeSnippetTemplate;

	public static IIntelliPromptSessionType CodeSnippetSelection
	{
		get
		{
			if (yCW == null)
			{
				yCW = new IntelliPromptSessionType(Q7Z.tqM(12138), areMultipleSessionsAllowed: false);
			}
			return yCW;
		}
	}

	public static IIntelliPromptSessionType CodeSnippetTemplate
	{
		get
		{
			if (BCP == null)
			{
				BCP = new IntelliPromptSessionType(Q7Z.tqM(12182), areMultipleSessionsAllowed: false);
			}
			return BCP;
		}
	}

	public static IIntelliPromptSessionType Completion
	{
		get
		{
			if (BCE == null)
			{
				BCE = new IntelliPromptSessionType(Q7Z.tqM(12224), areMultipleSessionsAllowed: false);
			}
			return BCE;
		}
	}

	public static IIntelliPromptSessionType CompletionDescriptionTip
	{
		get
		{
			if (iCc == null)
			{
				iCc = new IntelliPromptSessionType(Q7Z.tqM(12248), areMultipleSessionsAllowed: false);
			}
			return iCc;
		}
	}

	public static IIntelliPromptSessionType ParameterInfo
	{
		get
		{
			if (QCa == null)
			{
				QCa = new IntelliPromptSessionType(Q7Z.tqM(12300), areMultipleSessionsAllowed: false);
			}
			return QCa;
		}
	}

	public static IIntelliPromptSessionType QuickInfo
	{
		get
		{
			if (FCx == null)
			{
				FCx = new IntelliPromptSessionType(Q7Z.tqM(12330), areMultipleSessionsAllowed: false);
			}
			return FCx;
		}
	}

	public static IIntelliPromptSessionType SmartTag
	{
		get
		{
			if (WCG == null)
			{
				WCG = new IntelliPromptSessionType(Q7Z.tqM(12352), areMultipleSessionsAllowed: false);
			}
			return WCG;
		}
	}

	internal static bool wxl()
	{
		return yxA == null;
	}

	internal static IntelliPromptSessionTypes MxW()
	{
		return yxA;
	}
}
