using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class SyntaxEditorAutomationPeer : FrameworkElementAutomationPeer, IMultipleViewProvider
{
	private static SyntaxEditorAutomationPeer FON;

	public int CurrentView => (int)(((SyntaxEditor)base.Owner).ActiveView?.Placement ?? ((EditorViewPlacement)0));

	public SyntaxEditorAutomationPeer(SyntaxEditor owner)
	{
		grA.DaB7cz();
		base._002Ector(owner);
	}

	private static int[] Jne(bool P_0)
	{
		if (P_0)
		{
			return new int[2] { 1, 2 };
		}
		return new int[1] { 1 };
	}

	internal void Mnl(IEditorView P_0, IEditorView P_1)
	{
		RaisePropertyChangedEvent(MultipleViewPatternIdentifiers.CurrentViewProperty, (int)(P_0?.Placement ?? ((EditorViewPlacement)0)), (int)(P_1?.Placement ?? ((EditorViewPlacement)0)));
	}

	internal void KnA()
	{
		int[] oldValue = Jne(_0020: false);
		int[] newValue = Jne(_0020: true);
		RaisePropertyChangedEvent(MultipleViewPatternIdentifiers.SupportedViewsProperty, oldValue, newValue);
	}

	internal void env()
	{
		int[] oldValue = Jne(_0020: true);
		int[] newValue = Jne(_0020: false);
		RaisePropertyChangedEvent(MultipleViewPatternIdentifiers.SupportedViewsProperty, oldValue, newValue);
	}

	public int[] GetSupportedViews()
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)base.Owner;
		return Jne(syntaxEditor.HasHorizontalSplit);
	}

	public string GetViewName(int viewId)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)base.Owner;
		string result;
		if (!syntaxEditor.HasHorizontalSplit)
		{
			result = Q7Z.tqM(13346);
		}
		else if (viewId != 2)
		{
			result = Q7Z.tqM(197086);
			int num = 0;
			if (IOj() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = Q7Z.tqM(197072);
		}
		return result;
	}

	public void SetCurrentView(int viewId)
	{
		if (!Enum.IsDefined(typeof(EditorViewPlacement), viewId))
		{
			throw new ArgumentException(Q7Z.tqM(197100));
		}
		SyntaxEditor syntaxEditor = (SyntaxEditor)base.Owner;
		syntaxEditor.GetView((EditorViewPlacement)viewId)?.Activate();
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Edit;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(197216);
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface != PatternInterface.MultipleView)
		{
			return base.GetPattern(patternInterface);
		}
		return this;
	}

	internal static bool ROH()
	{
		return FON == null;
	}

	internal static SyntaxEditorAutomationPeer IOj()
	{
		return FON;
	}
}
