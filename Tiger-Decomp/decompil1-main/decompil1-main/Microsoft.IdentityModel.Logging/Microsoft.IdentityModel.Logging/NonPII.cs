namespace Microsoft.IdentityModel.Logging;

internal struct NonPII
{
	public object Argument { get; set; }

	public NonPII(object argument)
	{
		Argument = argument;
	}

	public override string ToString()
	{
		return Argument?.ToString() ?? "Null";
	}
}
