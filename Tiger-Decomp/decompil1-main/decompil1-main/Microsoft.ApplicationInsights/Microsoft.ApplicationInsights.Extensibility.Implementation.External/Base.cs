using System.CodeDom.Compiler;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[GeneratedCode("gbc", "0.4.1.0")]
internal class Base
{
	public string baseType { get; set; }

	public Base()
		: this("AI.Base", "Base")
	{
	}

	protected Base(string fullName, string name)
	{
		baseType = "";
	}
}
