using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text.Lexing;

public interface ILexicalScopeCollection : IList<ILexicalScope>, ICollection<ILexicalScope>, IEnumerable<ILexicalScope>, IEnumerable
{
}
