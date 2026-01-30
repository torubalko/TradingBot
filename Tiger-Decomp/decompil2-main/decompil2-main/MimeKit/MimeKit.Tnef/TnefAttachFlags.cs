using System;

namespace MimeKit.Tnef;

[Flags]
public enum TnefAttachFlags
{
	None = 0,
	InvisibleInHtml = 1,
	InvisibleInRtf = 2,
	RenderedInBody = 4
}
