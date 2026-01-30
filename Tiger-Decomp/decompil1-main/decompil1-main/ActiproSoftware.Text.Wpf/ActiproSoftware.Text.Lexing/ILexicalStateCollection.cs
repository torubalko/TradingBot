using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text.Lexing;

public interface ILexicalStateCollection : IList<ILexicalState>, ICollection<ILexicalState>, IEnumerable<ILexicalState>, IEnumerable
{
}
