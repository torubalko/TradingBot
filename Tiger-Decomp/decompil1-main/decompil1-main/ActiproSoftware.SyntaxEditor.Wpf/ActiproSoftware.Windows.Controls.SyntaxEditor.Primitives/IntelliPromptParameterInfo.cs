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

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
[ToolboxItem(false)]
public class IntelliPromptParameterInfo : Control
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IParameterInfoSession keH;

	internal static IntelliPromptParameterInfo IBQ;

	public bool IsSelectionPanelVisible => Session.Items.Count > 1;

	public IParameterInfoSession Session
	{
		[CompilerGenerated]
		get
		{
			return keH;
		}
		[CompilerGenerated]
		private set
		{
			keH = value;
		}
	}

	public IntelliPromptParameterInfo(IParameterInfoSession session)
	{
		grA.DaB7cz();
		base._002Ector();
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		Session = session;
		base.DefaultStyleKey = typeof(IntelliPromptParameterInfo);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new IntelliPromptParameterInfoAutomationPeer(this);
	}

	internal static bool CBy()
	{
		return IBQ == null;
	}

	internal static IntelliPromptParameterInfo dBh()
	{
		return IBQ;
	}
}
