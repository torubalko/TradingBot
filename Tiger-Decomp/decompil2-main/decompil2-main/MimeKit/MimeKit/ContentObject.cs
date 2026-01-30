using System;
using System.IO;

namespace MimeKit;

[Obsolete("Use the MimeContent class instead.")]
public class ContentObject : MimeContent
{
	[Obsolete("Use the MimeContent class instead.")]
	public ContentObject(Stream stream, ContentEncoding encoding = ContentEncoding.Default)
		: base(stream, encoding)
	{
	}
}
