using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing.Implementation;

public interface IDynamicLexicalMacroCollection : IKeyedObservableCollection<DynamicLexicalMacro>, IObservableCollection<DynamicLexicalMacro>, IList<DynamicLexicalMacro>, ICollection<DynamicLexicalMacro>, IEnumerable<DynamicLexicalMacro>, IEnumerable
{
}
