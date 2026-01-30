using System;

namespace MimeKit;

internal class HeaderListChangedEventArgs : EventArgs
{
	public HeaderListChangedAction Action { get; private set; }

	public Header Header { get; private set; }

	internal HeaderListChangedEventArgs(Header header, HeaderListChangedAction action)
	{
		Header = header;
		Action = action;
	}
}
