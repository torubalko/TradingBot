using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing.Implementation;

public interface IDynamicLexicalPatternCollection : IObservableCollection<DynamicLexicalPattern>, IList<DynamicLexicalPattern>, ICollection<DynamicLexicalPattern>, IEnumerable<DynamicLexicalPattern>, IEnumerable
{
}
