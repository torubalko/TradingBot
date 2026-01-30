using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public sealed class AmbientHighlightingStyleRegistry : HighlightingStyleRegistry
{
	private static IHighlightingStyleRegistry CLf;

	internal static AmbientHighlightingStyleRegistry kWT;

	public static IHighlightingStyleRegistry Instance
	{
		get
		{
			if (CLf == null)
			{
				CLf = new AmbientHighlightingStyleRegistry();
			}
			return CLf;
		}
	}

	private AmbientHighlightingStyleRegistry()
	{
		grA.DaB7cz();
		base._002Ector();
		base.Description = SR.GetString(SRName.UIAmbientHighlightingStyleRegistryDescription);
	}

	internal static bool zWt()
	{
		return kWT == null;
	}

	internal static AmbientHighlightingStyleRegistry UWY()
	{
		return kWT;
	}
}
