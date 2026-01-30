using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing.Implementation;

public interface IDynamicLexicalScopeCollection : IObservableCollection<DynamicLexicalScope>, IList<DynamicLexicalScope>, ICollection<DynamicLexicalScope>, IEnumerable<DynamicLexicalScope>, IEnumerable
{
}
