using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class SessionContext
{
	private readonly IDictionary<string, string> tags;

	public string Id
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.SessionId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.SessionId, value);
		}
	}

	public bool? IsFirst
	{
		get
		{
			return tags.GetTagBoolValueOrNull(ContextTagKeys.Keys.SessionIsFirst);
		}
		set
		{
			tags.SetTagValueOrRemove(ContextTagKeys.Keys.SessionIsFirst, value);
		}
	}

	internal SessionContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
