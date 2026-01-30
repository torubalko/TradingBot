using System.Security;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class SecureStringPropertyChangedRoutedEventArgs : PropertyChangedRoutedEventArgs<SecureString>
{
	private static SecureStringPropertyChangedRoutedEventArgs oMg;

	public SecureStringPropertyChangedRoutedEventArgs(SecureString oldValue, SecureString newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(oldValue, newValue);
	}

	public SecureStringPropertyChangedRoutedEventArgs(RoutedEvent routedEvent, SecureString oldValue, SecureString newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, oldValue, newValue);
	}

	internal static bool uM8()
	{
		return oMg == null;
	}

	internal static SecureStringPropertyChangedRoutedEventArgs EMj()
	{
		return oMg;
	}
}
