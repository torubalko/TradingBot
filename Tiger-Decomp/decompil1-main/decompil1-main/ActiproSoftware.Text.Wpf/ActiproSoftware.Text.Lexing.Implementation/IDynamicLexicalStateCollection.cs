using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing.Implementation;

public interface IDynamicLexicalStateCollection : IKeyedObservableCollection<DynamicLexicalState>, IObservableCollection<DynamicLexicalState>, IList<DynamicLexicalState>, ICollection<DynamicLexicalState>, IEnumerable<DynamicLexicalState>, IEnumerable
{
}
