using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class QuickInfoProviderBase : IEditorViewPointerInputEventSink, IQuickInfoProvider, IOrderable, IKeyedObject
{
	private bool M32;

	private IIntelliPromptSessionType f37;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string u3i;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEnumerable<Ordering> t3p;

	private static QuickInfoProviderBase tgB;

	protected bool CanTrackPointerInput => M32;

	protected abstract IEnumerable<Type> ContextTypes { get; }

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return u3i;
		}
		[CompilerGenerated]
		private set
		{
			u3i = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return t3p;
		}
		[CompilerGenerated]
		private set
		{
			t3p = value;
		}
	}

	protected QuickInfoProviderBase()
	{
		grA.DaB7cz();
		this._002Ector(Guid.NewGuid().ToString(), (Ordering[])null);
	}

	protected QuickInfoProviderBase(string key)
	{
		grA.DaB7cz();
		this._002Ector(key, (Ordering[])null);
	}

	protected QuickInfoProviderBase(string key, params Ordering[] orderings)
	{
		grA.DaB7cz();
		M32 = true;
		f37 = IntelliPromptSessionTypes.QuickInfo;
		base._002Ector();
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = key;
		Orderings = orderings;
	}

	void IEditorViewPointerInputEventSink.NotifyPointerEntered(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerExited(IEditorView view, InputPointerEventArgs e)
	{
		H39(view, e, _0020: true);
	}

	void IEditorViewPointerInputEventSink.NotifyPointerHovered(IEditorView view, InputPointerEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (!e.Handled)
		{
			k3S(view, e);
		}
	}

	void IEditorViewPointerInputEventSink.NotifyPointerMoved(IEditorView view, InputPointerEventArgs e)
	{
		H39(view, e, _0020: false);
	}

	void IEditorViewPointerInputEventSink.NotifyPointerPressed(IEditorView view, InputPointerButtonEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerReleased(IEditorView view, InputPointerButtonEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerWheel(IEditorView view, InputPointerWheelEventArgs e)
	{
	}

	private static bool c3V(InputPointerEventArgs P_0)
	{
		if (P_0.WrappedEventArgs is MouseButtonEventArgs e)
		{
			return e.LeftButton == MouseButtonState.Pressed || e.RightButton == MouseButtonState.Pressed || e.MiddleButton == MouseButtonState.Pressed || e.XButton1 == MouseButtonState.Pressed || e.XButton2 == MouseButtonState.Pressed;
		}
		return false;
	}

	private void L3r(IEditorView P_0, object P_1)
	{
		if (P_0.SyntaxEditor == null || P_0.SyntaxEditor.IntelliPrompt == null || ContextTypes == null || P_1 == null)
		{
			return;
		}
		foreach (Type contextType in ContextTypes)
		{
			if (contextType.IsInstanceOfType(P_1))
			{
				M32 = true;
				P_0.SyntaxEditor.IntelliPrompt.CloseSessions(f37);
				break;
			}
		}
	}

	private IQuickInfoSession w3s(IEditorView P_0)
	{
		if (P_0.SyntaxEditor != null && P_0.SyntaxEditor.IntelliPrompt != null)
		{
			return P_0.SyntaxEditor.IntelliPrompt.Sessions[f37] as IQuickInfoSession;
		}
		return null;
	}

	private bool H3k(IEditorView P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		IQuickInfoSession quickInfoSession = default(IQuickInfoSession);
		while (true)
		{
			switch (num2)
			{
			case 1:
				quickInfoSession = w3s(P_0);
				num2 = 0;
				if (Kg7() != null)
				{
					num2 = 0;
				}
				break;
			default:
				if (quickInfoSession == null || quickInfoSession.Context == null)
				{
					return false;
				}
				return quickInfoSession.Context.Equals(P_1);
			}
		}
	}

	private void k3S(IEditorView P_0, InputPointerEventArgs P_1)
	{
		IQuickInfoSession quickInfoSession = w3s(P_0);
		if (quickInfoSession == null)
		{
			M32 = true;
		}
		if (!M32 || P_0.SyntaxEditor == null || c3V(P_1))
		{
			return;
		}
		Point position = P_1.GetPosition(P_0.SyntaxEditor);
		IHitTestResult hitTestResult = P_0.SyntaxEditor.HitTest(position);
		if (hitTestResult != null)
		{
			object context = GetContext(hitTestResult);
			if (context != null)
			{
				if (!H3k(P_0, context))
				{
					P_1.Handled = RequestSession(P_0, context, canTrackPointer: true);
				}
				else
				{
					P_1.Handled = true;
				}
				return;
			}
		}
		if (quickInfoSession != null)
		{
			L3r(P_0, quickInfoSession.Context);
		}
	}

	private void H39(IEditorView P_0, InputPointerEventArgs P_1, bool P_2)
	{
		IQuickInfoSession quickInfoSession = w3s(P_0);
		if (quickInfoSession == null)
		{
			M32 = true;
		}
		if (!M32 || quickInfoSession == null || P_0.SyntaxEditor == null)
		{
			return;
		}
		IHitTestResult hitTestResult = ((!P_2) ? P_0.SyntaxEditor.HitTest(P_1.GetPosition(P_0.SyntaxEditor)) : null);
		if (hitTestResult != null)
		{
			object context = GetContext(hitTestResult);
			if (context != null && H3k(P_0, context))
			{
				return;
			}
		}
		L3r(P_0, quickInfoSession.Context);
	}

	public virtual object GetContext(IHitTestResult hitTestResult)
	{
		if (hitTestResult == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(14128));
		}
		bool flag = hitTestResult.Type == HitTestResultType.ViewTextAreaOverCharacter && hitTestResult.View != null;
		int num = 0;
		if (Kg7() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (flag)
			{
				return GetContext(hitTestResult.View, hitTestResult.Offset);
			}
			return null;
		}
	}

	public abstract object GetContext(IEditorView view, int offset);

	protected abstract bool RequestSession(IEditorView view, object context);

	public bool RequestSession(IEditorView view, object context, bool canTrackPointer)
	{
		M32 = canTrackPointer;
		if (!canTrackPointer)
		{
			view?.SyntaxEditor.IntelliPrompt.CloseSessions(IntelliPromptSessionTypes.ParameterInfo);
		}
		return RequestSession(view, context);
	}

	internal static bool wg0()
	{
		return tgB == null;
	}

	internal static QuickInfoProviderBase Kg7()
	{
		return tgB;
	}
}
