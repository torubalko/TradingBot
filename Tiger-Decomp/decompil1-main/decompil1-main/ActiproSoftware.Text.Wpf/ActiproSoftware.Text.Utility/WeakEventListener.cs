using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class WeakEventListener<TInstance, TEventArgs> where TInstance : class where TEventArgs : EventArgs
{
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	[SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes")]
	public delegate void EventAction<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);

	private WeakReference gBs;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<WeakEventListener<TInstance, TEventArgs>> RBI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventAction<TInstance, object, TEventArgs> nB7;

	private static object OWy;

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	public Action<WeakEventListener<TInstance, TEventArgs>> OnDetachAction
	{
		[CompilerGenerated]
		get
		{
			return RBI;
		}
		[CompilerGenerated]
		set
		{
			RBI = value;
		}
	}

	public EventAction<TInstance, object, TEventArgs> OnEventAction
	{
		[CompilerGenerated]
		get
		{
			return nB7;
		}
		[CompilerGenerated]
		set
		{
			nB7 = value;
		}
	}

	public WeakEventListener(TInstance instance)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (instance == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5372));
		}
		gBs = new WeakReference(instance);
	}

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	public WeakEventListener(TInstance instance, EventAction<TInstance, object, TEventArgs> onEventAction, Action<WeakEventListener<TInstance, TEventArgs>> onDetachAction)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(instance);
		if (onEventAction == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5392));
		}
		if (onDetachAction == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5422));
		}
		OnEventAction = onEventAction;
		OnDetachAction = onDetachAction;
	}

	public void Detach()
	{
		if (OnDetachAction != null)
		{
			OnDetachAction(this);
			OnDetachAction = null;
			OnEventAction = null;
		}
	}

	public void OnEvent(object source, TEventArgs eventArgs)
	{
		if (gBs.Target is TInstance arg)
		{
			if (OnEventAction != null)
			{
				OnEventAction(arg, source, eventArgs);
			}
		}
		else
		{
			Detach();
		}
	}

	internal static bool rWF()
	{
		return OWy == null;
	}

	internal static object TWO()
	{
		return OWy;
	}
}
