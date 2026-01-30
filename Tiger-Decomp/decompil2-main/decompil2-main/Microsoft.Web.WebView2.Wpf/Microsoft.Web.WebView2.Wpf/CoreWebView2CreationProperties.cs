using System.Threading.Tasks;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Wpf;

public class CoreWebView2CreationProperties : DependencyObject
{
	public static readonly DependencyProperty BrowserExecutableFolderProperty = DependencyProperty.Register("BrowserExecutableFolder", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, PropertyChanged));

	public static readonly DependencyProperty UserDataFolderProperty = DependencyProperty.Register("UserDataFolder", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, PropertyChanged));

	public static readonly DependencyProperty LanguageProperty = DependencyProperty.Register("Language", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, PropertyChanged));

	private Task<CoreWebView2Environment> _task;

	public string BrowserExecutableFolder
	{
		get
		{
			return (string)GetValue(BrowserExecutableFolderProperty);
		}
		set
		{
			SetValue(BrowserExecutableFolderProperty, value);
		}
	}

	public string UserDataFolder
	{
		get
		{
			return (string)GetValue(UserDataFolderProperty);
		}
		set
		{
			SetValue(UserDataFolderProperty, value);
		}
	}

	public string Language
	{
		get
		{
			return (string)GetValue(LanguageProperty);
		}
		set
		{
			SetValue(LanguageProperty, value);
		}
	}

	private static void PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
	{
		((CoreWebView2CreationProperties)d)._task = null;
	}

	internal Task<CoreWebView2Environment> CreateEnvironmentAsync()
	{
		if (_task == null)
		{
			_task = CoreWebView2Environment.CreateAsync(BrowserExecutableFolder, UserDataFolder, new CoreWebView2EnvironmentOptions(null, Language));
		}
		return _task;
	}
}
