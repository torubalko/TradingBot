using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class IntelliPromptQuickInfo : Control
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IQuickInfoSession heT;

	internal static IntelliPromptQuickInfo WB6;

	public IQuickInfoSession Session
	{
		[CompilerGenerated]
		get
		{
			return heT;
		}
		[CompilerGenerated]
		private set
		{
			heT = value;
		}
	}

	public IntelliPromptQuickInfo(IQuickInfoSession session)
	{
		grA.DaB7cz();
		base._002Ector();
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		Session = session;
		base.DefaultStyleKey = typeof(IntelliPromptQuickInfo);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new IntelliPromptQuickInfoAutomationPeer(this);
	}

	internal static bool cBK()
	{
		return WB6 == null;
	}

	internal static IntelliPromptQuickInfo bBC()
	{
		return WB6;
	}
}
