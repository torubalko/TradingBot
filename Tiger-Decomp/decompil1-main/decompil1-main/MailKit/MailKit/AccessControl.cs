using System;
using System.Collections.Generic;

namespace MailKit;

public class AccessControl
{
	public string Name { get; private set; }

	public AccessRights Rights { get; private set; }

	public AccessControl(string name, IEnumerable<AccessRight> rights)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Rights = new AccessRights(rights);
		Name = name;
	}

	public AccessControl(string name, string rights)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Rights = new AccessRights(rights);
		Name = name;
	}

	public AccessControl(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Rights = new AccessRights();
		Name = name;
	}
}
