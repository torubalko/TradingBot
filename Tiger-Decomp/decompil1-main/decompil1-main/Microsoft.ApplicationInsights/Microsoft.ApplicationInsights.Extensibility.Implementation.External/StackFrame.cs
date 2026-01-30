using System.CodeDom.Compiler;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData]
[GeneratedCode("gbc", "0.4.1.0")]
internal class StackFrame
{
	public int level { get; set; }

	public string method { get; set; }

	public string assembly { get; set; }

	public string fileName { get; set; }

	public int line { get; set; }

	public StackFrame()
		: this("AI.StackFrame", "StackFrame")
	{
	}

	protected StackFrame(string fullName, string name)
	{
		method = "";
		assembly = "";
		fileName = "";
	}
}
