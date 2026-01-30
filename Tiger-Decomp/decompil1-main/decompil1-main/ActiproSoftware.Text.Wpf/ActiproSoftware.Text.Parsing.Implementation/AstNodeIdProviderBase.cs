using System.Diagnostics.CodeAnalysis;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Parsing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ast")]
public abstract class AstNodeIdProviderBase : IAstNodeIdProvider, IIdProvider
{
	private static AstNodeIdProviderBase Y1f;

	public abstract int MaxId { get; }

	public abstract int MinId { get; }

	public abstract bool ContainsId(int id);

	public abstract string GetDescription(int id);

	public abstract string GetKey(int id);

	protected AstNodeIdProviderBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool q1M()
	{
		return Y1f == null;
	}

	internal static AstNodeIdProviderBase R1Z()
	{
		return Y1f;
	}
}
