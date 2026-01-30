using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class DeviceContext
{
	private readonly IDictionary<string, string> tags;

	private readonly IDictionary<string, string> properties;

	public string Type
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.DeviceType);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.DeviceType, value);
		}
	}

	public string Id
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.DeviceId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.DeviceId, value);
		}
	}

	public string OperatingSystem
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.DeviceOSVersion);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.DeviceOSVersion, value);
		}
	}

	public string OemName
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.DeviceOEMName);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.DeviceOEMName, value);
		}
	}

	public string Model
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.DeviceModel);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.DeviceModel, value);
		}
	}

	[Obsolete("Use custom properties.")]
	public string NetworkType
	{
		get
		{
			return properties.GetTagValueOrNull("ai.device.network");
		}
		set
		{
			properties.SetTagValueOrRemove("ai.device.network", value);
		}
	}

	[Obsolete("Use custom properties.")]
	public string ScreenResolution
	{
		get
		{
			return properties.GetTagValueOrNull("ai.device.screenResolution");
		}
		set
		{
			properties.SetStringValueOrRemove("ai.device.screenResolution", value);
		}
	}

	[Obsolete("Use custom properties.")]
	public string Language
	{
		get
		{
			return properties.GetTagValueOrNull("ai.device.language");
		}
		set
		{
			properties.SetStringValueOrRemove("ai.device.language", value);
		}
	}

	internal DeviceContext(IDictionary<string, string> tags, IDictionary<string, string> properties)
	{
		this.tags = tags;
		this.properties = properties;
	}
}
