using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.WinForms;

public class CoreWebView2CreationProperties
{
	private string _browserExecutableFolder;

	private string _userDataFolder;

	private string _language;

	private Task<CoreWebView2Environment> _task;

	public string BrowserExecutableFolder
	{
		get
		{
			return _browserExecutableFolder;
		}
		set
		{
			_browserExecutableFolder = value;
			_task = null;
		}
	}

	public string UserDataFolder
	{
		get
		{
			return _userDataFolder;
		}
		set
		{
			_userDataFolder = value;
			_task = null;
		}
	}

	public string Language
	{
		get
		{
			return _language;
		}
		set
		{
			_language = value;
			_task = null;
		}
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
