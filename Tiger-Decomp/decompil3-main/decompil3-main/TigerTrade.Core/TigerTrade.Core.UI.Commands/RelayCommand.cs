using System;
using System.Windows.Input;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace TigerTrade.Core.UI.Commands;

public sealed class RelayCommand : ICommand
{
	private readonly Action<object> _execute;

	private readonly Predicate<object> _canExecute;

	private static RelayCommand W9xlBAkniD0Vf7v859RS;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			CommandManager.RequerySuggested += value;
		}
		remove
		{
			rtmNXyknDNfG0smddywV(value);
		}
	}

	public RelayCommand(Action<object> execute)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		this._002Ector(execute, null);
	}

	public RelayCommand(Action<object> execute, Predicate<object> canExecute)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		_execute = execute;
		_canExecute = canExecute;
	}

	public bool CanExecute(object parameter)
	{
		if (_canExecute != null)
		{
			return _canExecute(parameter);
		}
		return true;
	}

	public void Execute(object parameter)
	{
		_execute(parameter);
	}

	static RelayCommand()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		zchfgnknbBAvJ4Lf3FLa();
	}

	internal static void rtmNXyknDNfG0smddywV(object P_0)
	{
		CommandManager.RequerySuggested -= (EventHandler)P_0;
	}

	internal static bool Ph57LsknlDhTjSGjTZgV()
	{
		return W9xlBAkniD0Vf7v859RS == null;
	}

	internal static RelayCommand lr5Nx7kn4blUDHc6C3iY()
	{
		return W9xlBAkniD0Vf7v859RS;
	}

	internal static void zchfgnknbBAvJ4Lf3FLa()
	{
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}
}
