using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public abstract class LexicalStateIdProviderBase : ILexicalStateIdProvider, IIdProvider
{
	internal static LexicalStateIdProviderBase DP7;

	public abstract int MaxId { get; }

	public abstract int MinId { get; }

	public abstract bool ContainsId(int id);

	public abstract string GetDescription(int id);

	public abstract string GetKey(int id);

	protected LexicalStateIdProviderBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool pPJ()
	{
		return DP7 == null;
	}

	internal static LexicalStateIdProviderBase EPy()
	{
		return DP7;
	}
}
