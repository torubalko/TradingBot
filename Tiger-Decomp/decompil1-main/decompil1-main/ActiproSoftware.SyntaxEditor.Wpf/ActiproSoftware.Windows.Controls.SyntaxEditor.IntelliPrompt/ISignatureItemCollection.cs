using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ISignatureItemCollection : IObservableCollection<ISignatureItem>, IList<ISignatureItem>, ICollection<ISignatureItem>, IEnumerable<ISignatureItem>, IEnumerable
{
}
