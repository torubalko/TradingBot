using System.CodeDom.Compiler;
using System.Threading;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[GeneratedCode("gbc", "0.4.1.0")]
internal class ContextTagKeys
{
	private static ContextTagKeys keys;

	public string ApplicationVersion { get; set; }

	public string DeviceId { get; set; }

	public string DeviceLocale { get; set; }

	public string DeviceModel { get; set; }

	public string DeviceOEMName { get; set; }

	public string DeviceOSVersion { get; set; }

	public string DeviceType { get; set; }

	public string LocationIp { get; set; }

	public string OperationId { get; set; }

	public string OperationName { get; set; }

	public string OperationParentId { get; set; }

	public string OperationSyntheticSource { get; set; }

	public string OperationCorrelationVector { get; set; }

	public string SessionId { get; set; }

	public string SessionIsFirst { get; set; }

	public string UserAccountId { get; set; }

	public string UserAgent { get; set; }

	public string UserId { get; set; }

	public string UserAuthUserId { get; set; }

	public string CloudRole { get; set; }

	public string CloudRoleInstance { get; set; }

	public string InternalSdkVersion { get; set; }

	public string InternalAgentVersion { get; set; }

	public string InternalNodeName { get; set; }

	internal static ContextTagKeys Keys => LazyInitializer.EnsureInitialized(ref keys);

	public ContextTagKeys()
		: this("AI.ContextTagKeys", "ContextTagKeys")
	{
	}

	protected ContextTagKeys(string fullName, string name)
	{
		ApplicationVersion = "ai.application.ver";
		DeviceId = "ai.device.id";
		DeviceLocale = "ai.device.locale";
		DeviceModel = "ai.device.model";
		DeviceOEMName = "ai.device.oemName";
		DeviceOSVersion = "ai.device.osVersion";
		DeviceType = "ai.device.type";
		LocationIp = "ai.location.ip";
		OperationId = "ai.operation.id";
		OperationName = "ai.operation.name";
		OperationParentId = "ai.operation.parentId";
		OperationSyntheticSource = "ai.operation.syntheticSource";
		OperationCorrelationVector = "ai.operation.correlationVector";
		SessionId = "ai.session.id";
		SessionIsFirst = "ai.session.isFirst";
		UserAccountId = "ai.user.accountId";
		UserAgent = "ai.user.userAgent";
		UserId = "ai.user.id";
		UserAuthUserId = "ai.user.authUserId";
		CloudRole = "ai.cloud.role";
		CloudRoleInstance = "ai.cloud.roleInstance";
		InternalSdkVersion = "ai.internal.sdkVersion";
		InternalAgentVersion = "ai.internal.agentVersion";
		InternalNodeName = "ai.internal.nodeName";
	}
}
