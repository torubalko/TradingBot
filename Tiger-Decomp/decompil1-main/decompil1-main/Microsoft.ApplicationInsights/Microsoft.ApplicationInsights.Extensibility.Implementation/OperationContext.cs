using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class OperationContext
{
	private readonly IDictionary<string, string> tags;

	public string Id
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.OperationId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.OperationId, value);
		}
	}

	public string ParentId
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.OperationParentId);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.OperationParentId, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public string CorrelationVector
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.OperationCorrelationVector);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.OperationCorrelationVector, value);
		}
	}

	public string Name
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.OperationName);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.OperationName, value);
		}
	}

	public string SyntheticSource
	{
		get
		{
			return tags.GetTagValueOrNull(ContextTagKeys.Keys.OperationSyntheticSource);
		}
		set
		{
			tags.SetStringValueOrRemove(ContextTagKeys.Keys.OperationSyntheticSource, value);
		}
	}

	internal OperationContext(IDictionary<string, string> tags)
	{
		this.tags = tags;
	}
}
