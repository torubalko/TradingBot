using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public interface IHighlightingStyleRegistry : IClassificationTypeRegistry, IEnumerable<IClassificationType>, IEnumerable, IEnumerable<KeyValuePair<IClassificationType, IHighlightingStyle>>
{
	ICollection<IClassificationType> ClassificationTypes { get; }

	string Description { get; set; }

	ICollection<IHighlightingStyle> HighlightingStyles { get; }

	[SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers")]
	IHighlightingStyle this[IClassificationType classificationType] { get; }

	event EventHandler Changed;

	IClassificationType GetClassificationType(string key);

	bool ImportHighlightingStyles(Stream stream);

	bool Register(IClassificationType classificationType, IHighlightingStyle style);

	bool Register(IClassificationType classificationType, IHighlightingStyle style, bool overwriteExisting);

	bool Unregister(IClassificationType classificationType);
}
