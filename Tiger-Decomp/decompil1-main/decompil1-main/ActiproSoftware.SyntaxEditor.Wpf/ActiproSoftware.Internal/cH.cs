using System;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class cH : iTv<BreakpointIndicatorTagger, BreakpointIndicatorTag>, IBreakpointIndicatorManager, ITextRangeIndicatorManager<BreakpointIndicatorTagger, BreakpointIndicatorTag>
{
	internal static cH IgE;

	public cH(IIndicatorManager P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0);
	}

	public bool ToggleEnabledState(BreakpointIndicatorTag P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192830));
		}
		IEditorDocument document = gRF().Document;
		if (document != null)
		{
			BreakpointIndicatorTagger value = null;
			if (document.Properties.TryGetValue<BreakpointIndicatorTagger>(typeof(BreakpointIndicatorTagger), out value))
			{
				TagVersionRange<BreakpointIndicatorTag> tagVersionRange = value[P_0];
				if (tagVersionRange != null)
				{
					tagVersionRange.Tag.IsEnabled = !tagVersionRange.Tag.IsEnabled;
					value.RaiseTagsChanged(new TagsChangedEventArgs(tagVersionRange.VersionRange.Translate(document.CurrentSnapshot)));
					return true;
				}
			}
		}
		return false;
	}

	internal static bool Egw()
	{
		return IgE == null;
	}

	internal static cH cgu()
	{
		return IgE;
	}
}
