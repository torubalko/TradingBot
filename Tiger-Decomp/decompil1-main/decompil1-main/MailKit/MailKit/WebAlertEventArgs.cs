using System;

namespace MailKit;

public class WebAlertEventArgs : AlertEventArgs
{
	public Uri WebUri { get; private set; }

	public WebAlertEventArgs(Uri uri, string message)
		: base(message)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		WebUri = uri;
	}
}
