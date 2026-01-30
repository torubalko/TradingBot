using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class DelegateCommand<T> : ICommand
{
	private Func<T, bool> G0J;

	private Action<T> N09;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler N0h;

	internal static object MHV;

	public event EventHandler CanExecuteChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = N0h;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref N0h, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = N0h;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref N0h, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DelegateCommand(Action<T> executeAction)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(executeAction, (Func<T, bool>)null);
	}

	public DelegateCommand(Action<T> executeAction, Func<T, bool> canExecuteFunc)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (executeAction == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110480));
		}
		N09 = executeAction;
		G0J = canExecuteFunc;
	}

	bool ICommand.CanExecute(object parameter)
	{
		return CanExecute((T)parameter);
	}

	void ICommand.Execute(object parameter)
	{
		Execute((T)parameter);
	}

	public bool CanExecute(T parameter)
	{
		return G0J == null || G0J(parameter);
	}

	public void Execute(T parameter)
	{
		if (CanExecute(parameter))
		{
			N09(parameter);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	public void RaiseCanExecuteChanged()
	{
		N0h?.Invoke(this, EventArgs.Empty);
	}

	internal static bool rHT()
	{
		return MHV == null;
	}

	internal static object IHX()
	{
		return MHV;
	}
}
