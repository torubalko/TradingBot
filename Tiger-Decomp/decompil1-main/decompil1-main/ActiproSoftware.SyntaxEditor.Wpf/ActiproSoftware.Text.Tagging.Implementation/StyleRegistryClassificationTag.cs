using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class StyleRegistryClassificationTag : ClassificationTag, IHighlightingStyleRegistryProvider
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IHighlightingStyleRegistry rI8;

	internal static StyleRegistryClassificationTag L5r;

	public IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		[CompilerGenerated]
		get
		{
			return rI8;
		}
		[CompilerGenerated]
		set
		{
			rI8 = value;
		}
	}

	public StyleRegistryClassificationTag()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	public StyleRegistryClassificationTag(IClassificationType classificationType, IHighlightingStyleRegistry highlightingStyleRegistry)
	{
		grA.DaB7cz();
		this._002Ector();
		base.ClassificationType = classificationType;
		HighlightingStyleRegistry = highlightingStyleRegistry;
	}

	internal static bool l5X()
	{
		return L5r == null;
	}

	internal static StyleRegistryClassificationTag n5E()
	{
		return L5r;
	}
}
