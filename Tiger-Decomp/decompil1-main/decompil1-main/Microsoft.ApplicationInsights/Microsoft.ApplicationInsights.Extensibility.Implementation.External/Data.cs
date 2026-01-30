using System.CodeDom.Compiler;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[GeneratedCode("gbc", "0.4.1.0")]
internal class Data<TDomain> : Base
{
	public TDomain baseData { get; set; }

	public Data()
		: this("AI.Data", "Data")
	{
	}

	protected Data(string fullName, string name)
	{
	}
}
