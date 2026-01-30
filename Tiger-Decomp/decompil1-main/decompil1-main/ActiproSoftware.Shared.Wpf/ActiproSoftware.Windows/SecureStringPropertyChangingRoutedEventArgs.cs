using System.Security;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class SecureStringPropertyChangingRoutedEventArgs : PropertyChangingRoutedEventArgs<SecureString>
{
	private static SecureStringPropertyChangingRoutedEventArgs RMe;

	public SecureStringPropertyChangingRoutedEventArgs(SecureString oldValue, SecureString newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(oldValue, newValue);
	}

	public SecureStringPropertyChangingRoutedEventArgs(RoutedEvent routedEvent, SecureString oldValue, SecureString newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, oldValue, newValue);
	}

	internal static bool rM6()
	{
		return RMe == null;
	}

	internal static SecureStringPropertyChangingRoutedEventArgs XMw()
	{
		return RMe;
	}
}
