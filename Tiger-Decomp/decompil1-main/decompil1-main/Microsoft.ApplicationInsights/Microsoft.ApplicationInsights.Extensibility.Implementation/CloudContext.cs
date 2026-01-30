using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class CloudContext
{
	private readonly IDictionary<string, string> tags;

	public string RoleName
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.CloudRole);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.CloudRole, value);
		}
	}

	public string RoleInstance
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.CloudRoleInstance);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.CloudRoleInstance, value);
		}
	}

	internal CloudContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
