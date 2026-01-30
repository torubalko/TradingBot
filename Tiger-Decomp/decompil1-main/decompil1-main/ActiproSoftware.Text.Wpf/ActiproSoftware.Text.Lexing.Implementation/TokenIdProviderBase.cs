using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public abstract class TokenIdProviderBase : ITokenIdProvider, IIdProvider
{
	public const int DocumentEnd = -1;

	public const int Invalid = -2;

	private static TokenIdProviderBase QUf;

	public abstract int MaxId { get; }

	public abstract int MinId { get; }

	public abstract bool ContainsId(int id);

	public abstract string GetDescription(int id);

	public abstract string GetKey(int id);

	protected TokenIdProviderBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool UUM()
	{
		return QUf == null;
	}

	internal static TokenIdProviderBase zUZ()
	{
		return QUf;
	}
}
