using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[GeneratedCode("gbc", "0.4.1.0")]
internal class Envelope
{
	public int ver { get; set; }

	public string name { get; set; }

	public string time { get; set; }

	public double sampleRate { get; set; }

	public string seq { get; set; }

	public string iKey { get; set; }

	public IDictionary<string, string> tags { get; set; }

	public Base data { get; set; }

	public Envelope()
		: this("AI.Envelope", "Envelope")
	{
	}

	protected Envelope(string fullName, string name)
	{
		ver = 1;
		this.name = "";
		time = "";
		sampleRate = 100.0;
		seq = "";
		iKey = "";
		tags = new ConcurrentDictionary<string, string>();
	}
}
