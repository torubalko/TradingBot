using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class UserContext
{
	private readonly IDictionary<string, string> tags;

	public string Id
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.UserId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.UserId, value);
		}
	}

	public string AccountId
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.UserAccountId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.UserAccountId, value);
		}
	}

	public string UserAgent
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.UserAgent);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.UserAgent, value);
		}
	}

	public string AuthenticatedUserId
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.UserAuthUserId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.UserAuthUserId, value);
		}
	}

	internal UserContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
