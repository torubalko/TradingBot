using System;

namespace MailKit;

[Flags]
public enum DeliveryStatusNotification
{
	Never = 0,
	Success = 1,
	Failure = 2,
	Delay = 4
}
