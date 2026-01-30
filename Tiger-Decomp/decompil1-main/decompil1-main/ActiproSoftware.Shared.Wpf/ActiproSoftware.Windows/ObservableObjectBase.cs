using System.ComponentModel;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public abstract class ObservableObjectBase : INotifyPropertyChanged
{
	private static ObservableObjectBase uM7;

	public event PropertyChangedEventHandler PropertyChanged;

	protected void NotifyPropertyChanged(string propertyName)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		this.PropertyChanged?.Invoke(this, e);
	}

	protected ObservableObjectBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool sMH()
	{
		return uM7 == null;
	}

	internal static ObservableObjectBase yMJ()
	{
		return uM7;
	}
}
