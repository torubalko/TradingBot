using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public interface IIntelliPromptSessionCollection : IObservableCollection<IIntelliPromptSession>, IList<IIntelliPromptSession>, ICollection<IIntelliPromptSession>, IEnumerable<IIntelliPromptSession>, IEnumerable
{
	[SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers")]
	IIntelliPromptSession this[IIntelliPromptSessionType sessionType] { get; }

	bool Contains(IIntelliPromptSessionType sessionType);

	int IndexOf(IIntelliPromptSessionType sessionType);
}
