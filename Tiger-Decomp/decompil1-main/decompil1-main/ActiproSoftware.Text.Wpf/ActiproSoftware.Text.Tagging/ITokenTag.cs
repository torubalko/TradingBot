using ActiproSoftware.Text.Lexing;

namespace ActiproSoftware.Text.Tagging;

public interface ITokenTag : ITag
{
	IToken Token { get; }
}
