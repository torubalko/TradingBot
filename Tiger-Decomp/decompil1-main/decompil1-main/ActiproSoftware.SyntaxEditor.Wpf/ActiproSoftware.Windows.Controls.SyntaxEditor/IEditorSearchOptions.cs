using System;
using ActiproSoftware.Text.Searching;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorSearchOptions : ISearchOptions, ICloneable
{
	EditorSearchScope Scope { get; set; }
}
