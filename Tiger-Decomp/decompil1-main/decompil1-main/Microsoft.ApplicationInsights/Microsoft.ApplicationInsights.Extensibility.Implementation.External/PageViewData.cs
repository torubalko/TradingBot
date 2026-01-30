using System.CodeDom.Compiler;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_PageViewData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class PageViewData : EventData
{
	public string url { get; set; }

	public string duration { get; set; }

	public PageViewData()
		: this("AI.PageViewData", "PageViewData")
	{
	}

	protected PageViewData(string fullName, string name)
	{
		url = "";
		duration = "";
	}
}
