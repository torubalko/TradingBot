using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class LocationContext
{
	private readonly IDictionary<string, string> tags;

	public string Ip
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.LocationIp);
		}
		set
		{
			if (value != null)
			{
				tags.SetStringValueOrRemove(ContextTagKeys.Keys.LocationIp, value);
			}
		}
	}

	internal LocationContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
