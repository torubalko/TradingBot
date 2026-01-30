using System.Collections.Generic;

namespace MailKit;

public class AccessControlList : List<AccessControl>
{
	public AccessControlList(IEnumerable<AccessControl> controls)
		: base(controls)
	{
	}

	public AccessControlList()
	{
	}
}
