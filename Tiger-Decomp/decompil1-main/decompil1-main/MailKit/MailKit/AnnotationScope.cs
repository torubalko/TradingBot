using System;

namespace MailKit;

[Flags]
public enum AnnotationScope
{
	None = 0,
	Private = 1,
	Shared = 2,
	Both = 3
}
