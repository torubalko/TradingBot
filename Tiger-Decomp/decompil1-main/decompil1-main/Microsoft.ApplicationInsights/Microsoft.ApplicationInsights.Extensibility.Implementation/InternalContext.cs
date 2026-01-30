using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class InternalContext
{
	private readonly IDictionary<string, string> tags;

	public string SdkVersion
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.InternalSdkVersion);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.InternalSdkVersion, value);
		}
	}

	public string AgentVersion
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.InternalAgentVersion);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.InternalAgentVersion, value);
		}
	}

	public string NodeName
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.InternalNodeName);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.InternalNodeName, value);
		}
	}

	internal InternalContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
