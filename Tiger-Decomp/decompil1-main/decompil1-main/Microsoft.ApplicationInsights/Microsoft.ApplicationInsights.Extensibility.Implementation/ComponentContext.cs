using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class ComponentContext
{
	private readonly IDictionary<string, string> tags;

	public string Version
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.ApplicationVersion);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.ApplicationVersion, value);
		}
	}

	internal ComponentContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
