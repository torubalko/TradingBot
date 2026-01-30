using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class ExampleTextProvider : IExampleTextProvider
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string vcd;

	private static ExampleTextProvider NUH;

	public string ExampleText
	{
		[CompilerGenerated]
		get
		{
			return vcd;
		}
		[CompilerGenerated]
		set
		{
			vcd = value;
		}
	}

	public ExampleTextProvider(string exampleText)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		ExampleText = exampleText;
	}

	internal static bool AU6()
	{
		return NUH == null;
	}

	internal static ExampleTextProvider NUE()
	{
		return NUH;
	}
}
