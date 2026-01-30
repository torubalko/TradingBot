using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

public interface IEditorViewMarginFactoryCollection : IList<IEditorViewMarginFactory>, ICollection<IEditorViewMarginFactory>, IEnumerable<IEditorViewMarginFactory>, IEnumerable, IList, ICollection
{
}
