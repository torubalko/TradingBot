using System;

namespace MailKit.Net.Imap;

internal class WebAlertResponseCode : ImapResponseCode
{
	public Uri WebUri;

	internal WebAlertResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
