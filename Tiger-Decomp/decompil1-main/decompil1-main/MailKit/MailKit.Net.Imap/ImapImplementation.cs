using System.Collections.Generic;

namespace MailKit.Net.Imap;

public class ImapImplementation
{
	public Dictionary<string, string> Properties { get; private set; }

	public string Name
	{
		get
		{
			return GetProperty("name");
		}
		set
		{
			Properties["name"] = value;
		}
	}

	public string Version
	{
		get
		{
			return GetProperty("version");
		}
		set
		{
			Properties["version"] = value;
		}
	}

	public string OS
	{
		get
		{
			return GetProperty("os");
		}
		set
		{
			Properties["os"] = value;
		}
	}

	public string OSVersion
	{
		get
		{
			return GetProperty("os-version");
		}
		set
		{
			Properties["os-version"] = value;
		}
	}

	public string Vendor
	{
		get
		{
			return GetProperty("vendor");
		}
		set
		{
			Properties["vendor"] = value;
		}
	}

	public string SupportUrl
	{
		get
		{
			return GetProperty("support-url");
		}
		set
		{
			Properties["support-url"] = value;
		}
	}

	public string Address
	{
		get
		{
			return GetProperty("address");
		}
		set
		{
			Properties["address"] = value;
		}
	}

	public string ReleaseDate
	{
		get
		{
			return GetProperty("date");
		}
		set
		{
			Properties["date"] = value;
		}
	}

	public string Command
	{
		get
		{
			return GetProperty("command");
		}
		set
		{
			Properties["command"] = value;
		}
	}

	public string Arguments
	{
		get
		{
			return GetProperty("arguments");
		}
		set
		{
			Properties["arguments"] = value;
		}
	}

	public string Environment
	{
		get
		{
			return GetProperty("environment");
		}
		set
		{
			Properties["environment"] = value;
		}
	}

	public ImapImplementation()
	{
		Properties = new Dictionary<string, string>();
	}

	private string GetProperty(string property)
	{
		Properties.TryGetValue(property, out var value);
		return value;
	}
}
